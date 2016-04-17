using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Graph;
using System.Collections.Generic;
using System.Linq;
using RESTfulOutlook.Utils;

namespace RESTfulOutlook.Forms
{
    public partial class MailAPI : Form
    {
        GraphServiceClient graphClient;
        public Dictionary<string, List<Recipient>> dRecips;
        public Dictionary<string, List<ItemBody>> dItemBody;
        public Dictionary<string, List<Recipient>> dBcc;
        public Dictionary<string, List<Recipient>> dCc;
        public Dictionary<string, List<Recipient>> dReplyTo;
        public Dictionary<string, List<string>> dCategories;
        public Dictionary<string, List<FileAttachment>> dFileAttachments;
        public Dictionary<string, List<ItemAttachment>> dItemAttachments;
        public Dictionary<string, List<ReferenceAttachment>> dReferenceAttachments;
        public Dictionary<string, string> dFolderIds;

        ClassLogger applogger = null;
        ClassLogger sdklogger = null;

        public MailAPI(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;

            // init the dictionaries
            dRecips = new Dictionary<string, List<Recipient>>();
            dItemBody = new Dictionary<string, List<ItemBody>>();
            dBcc = new Dictionary<string, List<Recipient>>();
            dCc = new Dictionary<string, List<Recipient>>();
            dReplyTo = new Dictionary<string, List<Recipient>>();
            dCategories = new Dictionary<string, List<string>>();
            dFileAttachments = new Dictionary<string, List<FileAttachment>>();
            dItemAttachments = new Dictionary<string, List<ItemAttachment>>();
            dReferenceAttachments = new Dictionary<string, List<ReferenceAttachment>>();
            dFolderIds = new Dictionary<string, string>();

            GetFoldersAsync();
        }

        private async Task GetFoldersAsync()
        {
            // TODO: return subfolders
            try
            {
                // adjust UI so user knows work is happening
                Cursor = Cursors.WaitCursor;

                // log the request
                sdklogger.Log("REQUEST");
                sdklogger.Log(graphClient.Me.MailFolders.Request().GetHttpRequestMessage().ToString());

                // get the folders
                var mailFolders = await graphClient.Me.MailFolders.Request()
                    .Expand("childfolders")
                    .Top(100)
                    .GetAsync();

                // clear any previous tree view
                tvwFolders.Nodes.Clear();

                // loop parent folders
                foreach (var mailFolder in mailFolders.CurrentPage)
                {    
                    // populate folder ids in the local dictionary
                    // any requests for a specific folder need to use Id, not display name
                    dFolderIds.Add(mailFolder.DisplayName, mailFolder.Id);

                    // need to check each folder for child folders
                    AddFoldersToTree(mailFolder);
                }
            }
            catch (ServiceException se)
            {
                sdklogger.Log("GetFoldersAsync ServiceException:");
                sdklogger.Log(se.Message);
                sdklogger.Log(se.StackTrace);
            }
            catch (Exception ex)
            {
                sdklogger.Log("GetFoldersAsync Exception:");
                sdklogger.Log(ex.Message);
                sdklogger.Log(ex.StackTrace);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// This function will display the folder name,
        /// then loop through the child folders, adding nodes as needed
        /// </summary>
        /// <param name="folder">MailFolder object</param>
        public void AddFoldersToTree(MailFolder folder)
        {
            try
            {
                // create the parent node for the folder and set the text
                TreeNode parent = new TreeNode();
                parent.Text = folder.DisplayName;
                tvwFolders.Nodes.Add(parent);

                // check for child folders
                if (folder.ChildFolderCount > 0)
                {
                    // get the child folders collection
                    var childFolders = folder.ChildFolders;
                    TreeNode[] children = new TreeNode[childFolders.Count];

                    // loop the child folders and display 
                    foreach (MailFolder childFolder in childFolders)
                    {
                        // create the child tree node and set the text
                        TreeNode child = new TreeNode();
                        child.Text = childFolder.DisplayName;
                        // since we have a child folder, need to add this id to the dictionary
                        dFolderIds.Add(childFolder.DisplayName, childFolder.Id);
                        
                        // now display the child folder in the tree view
                        parent.Nodes.Add(child);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnGetMessages_Click(object sender, EventArgs e)
        {
            await GetMessagesAsync();
        }

        private async Task GetMessagesAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dgCleanup();

                // get folder name from selected dropdown item and convert to folder id
                //string folderName = cmbFolders.SelectedItem.ToString();
                string folderName = tvwFolders.SelectedNode.Text;
                string folderId = null;

                foreach (KeyValuePair<string, string> pair in dFolderIds)
                {
                    if (pair.Key == folderName)
                    {
                        folderId = pair.Value;
                    }
                }

                int msgLimit = (Int32)nudMessages.Value;

                // log the request
                sdklogger.Log("REQUEST");
                sdklogger.Log(graphClient.Me.MailFolders[folderId].Messages.Request().GetHttpRequestMessage().ToString());

                // get the messages
                var messages = await graphClient.Me.MailFolders[folderId].Messages.Request()
                    .Expand("attachments")
                    .Top(msgLimit)
                    .GetAsync();

                foreach (var msg in messages.CurrentPage)
                {
                    // populate the new grid view rows
                    int n = dgMessages.Rows.Add();
                    dgMessages.Rows[n].Cells[(int)columns.Id].Value = msg.Id;
                    dgMessages.Rows[n].Cells[(int)columns.Subject].Value = msg.Subject;
                    dgMessages.Rows[n].Cells[(int)columns.Sender].Value = msg.Sender.EmailAddress.Address;
                    dgMessages.Rows[n].Cells[(int)columns.BodyPreview].Value = msg.BodyPreview;
                    dgMessages.Rows[n].Cells[(int)columns.ChangeKey].Value = msg.ChangeKey;
                    dgMessages.Rows[n].Cells[(int)columns.ConversationId].Value = msg.ConversationId;
                    dgMessages.Rows[n].Cells[(int)columns.CreatedDateTime].Value = msg.CreatedDateTime;
                    dgMessages.Rows[n].Cells[(int)columns.LastModifiedDateTime].Value = msg.LastModifiedDateTime;
                    dgMessages.Rows[n].Cells[(int)columns.ReceivedDateTime].Value = msg.ReceivedDateTime;
                    dgMessages.Rows[n].Cells[(int)columns.SentDateTime].Value = msg.SentDateTime;
                    dgMessages.Rows[n].Cells[(int)columns.From].Value = msg.From.EmailAddress.Address;
                    dgMessages.Rows[n].Cells[(int)columns.HasAttachments].Value = msg.HasAttachments;
                    dgMessages.Rows[n].Cells[(int)columns.Importance].Value = msg.Importance;
                    dgMessages.Rows[n].Cells[(int)columns.IsDeliveryReceiptRequested].Value = msg.IsDeliveryReceiptRequested;
                    dgMessages.Rows[n].Cells[(int)columns.IsDraft].Value = msg.IsDraft;
                    dgMessages.Rows[n].Cells[(int)columns.IsRead].Value = msg.IsRead;
                    dgMessages.Rows[n].Cells[(int)columns.IsReadReceiptRequested].Value = msg.IsReadReceiptRequested;
                    dgMessages.Rows[n].Cells[(int)columns.ParentFolderId].Value = msg.ParentFolderId;
                    dgMessages.Rows[n].Cells[(int)columns.UniqueBody].Value = msg.UniqueBody;
                    dgMessages.Rows[n].Cells[(int)columns.WebLink].Value = msg.WebLink;

                    if (msg.ToRecipients.Any())
                    {
                        List<Recipient> toRecipients = new List<Recipient>();
                        foreach (var recip in msg.ToRecipients)
                        {
                            toRecipients.Add(recip);
                        }
                        dgMessages.Rows[n].Cells[(int)columns.To].Value = "View Recipients";
                        dRecips.Add(msg.Id, toRecipients);
                    }

                    if (msg.Body != null)
                    {
                        dgMessages.Rows[n].Cells[(int)columns.Body].Value = "View Body";
                        List<ItemBody> iBody = new List<ItemBody>();
                        iBody.Add(msg.Body);
                        dItemBody.Add(msg.Id, iBody);
                    }

                    if (msg.BccRecipients.Any())
                    {
                        List<Recipient> tempRecipients = new List<Recipient>();
                        foreach (var recip in msg.BccRecipients)
                        {
                            tempRecipients.Add(recip);
                        }
                        dgMessages.Rows[n].Cells[(int)columns.Bcc].Value = "View Recipients";
                        dBcc.Add(msg.Id, tempRecipients);
                    }

                    if (msg.CcRecipients.Any())
                    {
                        List<Recipient> tempRecipients = new List<Recipient>();
                        foreach (var recip in msg.CcRecipients)
                        {
                            tempRecipients.Add(recip);
                        }
                        dgMessages.Rows[n].Cells[(int)columns.Cc].Value = "View Recipients";
                        dCc.Add(msg.Id, tempRecipients);
                    }

                    if (msg.ReplyTo.Any())
                    {
                        List<Recipient> tempRecipients = new List<Recipient>();
                        foreach (var recip in msg.ReplyTo)
                        {
                            tempRecipients.Add(recip);
                        }
                        dgMessages.Rows[n].Cells[(int)columns.ReplyTo].Value = "View Recipients";
                        dReplyTo.Add(msg.Id, tempRecipients);
                    }

                    if (msg.Categories.Any())
                    {
                        List<string> tempCategories = new List<string>();
                        foreach (var item in msg.Categories)
                        {
                            tempCategories.Add(item);
                        }
                        dgMessages.Rows[n].Cells[(int)columns.Categories].Value = "View Categories";
                        dCategories.Add(msg.Id, tempCategories);
                    }

                    if (msg.HasAttachments == true)
                    {
                        var attachments = msg.Attachments.CurrentPage;
                        List<FileAttachment> tempFileAttachment = new List<FileAttachment>();
                        List<ItemAttachment> tempItemAttachment = new List<ItemAttachment>();
                        List<ReferenceAttachment> tempRefAttachment = new List<ReferenceAttachment>();

                        foreach (var attachment in attachments)
                        {
                            if (attachment.GetType().ToString() == "Microsoft.Graph.FileAttachment")
                            {
                                tempFileAttachment.Add((FileAttachment)attachment);
                            }
                            else if (attachment.GetType().ToString() == "Microsoft.Graph.ReferenceAttachment")
                            {
                                tempRefAttachment.Add((ReferenceAttachment)attachment);
                            }
                            else
                            {
                                tempItemAttachment.Add((ItemAttachment)attachment);
                            }
                        }

                        if (attachments.Count > 0)
                        {
                            dgMessages.Rows[n].Cells[(int)columns.Attachments].Value = "View Attachments";
                            if (tempFileAttachment.Count > 0)
                            {
                                dFileAttachments.Add(msg.Id, tempFileAttachment);
                            }
                            if (tempItemAttachment.Count > 0)
                            {
                                dItemAttachments.Add(msg.Id, tempItemAttachment);
                            }
                            if (tempRefAttachment.Count > 0)
                            {
                                dReferenceAttachments.Add(msg.Id, tempRefAttachment);
                            }
                        }
                    }
                }
            }
            catch (ServiceException se)
            {
                sdklogger.Log("GetMessagesAsync GraphServiceException:");
                sdklogger.Log(se.Message);
            }
            catch (ArgumentOutOfRangeException aor)
            {
                sdklogger.Log("GetMessagesAsync ArgumentOutOfRangeException:");
                sdklogger.Log(aor.Message);
            }
            catch (Exception ex)
            {
                sdklogger.Log("GetMessagesAsync Exception:");
                sdklogger.Log(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void dgCleanup()
        {
            // clear any previous rows
            dgMessages.Rows.Clear();

            // cleanup dictionaries
            dRecips.Clear();
            dItemBody.Clear();
            dBcc.Clear();
            dCc.Clear();
            dReplyTo.Clear();
            dCategories.Clear();
            dFileAttachments.Clear();
            dItemAttachments.Clear();
            dReferenceAttachments.Clear();
        }

        private void dgMessages_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the selected item Id
                string mId = dgMessages.Rows[e.RowIndex].Cells[(int)columns.Id].Value.ToString();

                // open the associated form based on the selected column
                if (e.ColumnIndex == (int)columns.To)
                {
                    // create a temp recip collection
                    List<Recipient> tRecips = null;

                    // loop through the cached dictionary values
                    foreach (KeyValuePair<string, List<Recipient>> pair in dRecips)
                    {
                        // if the value matches the selected item id
                        // add it to the temp dictionary
                        if (pair.Key == mId)
                        {
                            tRecips = pair.Value;
                        }
                    }

                    // pass the temp dictionary to the form
                    RecipientCollection mRecipients = new RecipientCollection(mId, tRecips);
                    mRecipients.Owner = this;
                    mRecipients.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Attachments)
                {
                    if (dFileAttachments.Count > 0 || dItemAttachments.Count > 0)
                    {
                        List<FileAttachment> tFileAttachments = null;
                        List<ItemAttachment> tItemAttachments = null;
                        List<ReferenceAttachment> tRefAttachments = null;

                        foreach (KeyValuePair<string, List<FileAttachment>> pair in dFileAttachments)
                        {
                            if (pair.Key == mId)
                            {
                                tFileAttachments = pair.Value;
                            }
                        }

                        foreach (KeyValuePair<string, List<ItemAttachment>> pair in dItemAttachments)
                        {
                            if (pair.Key == mId)
                            {
                                tItemAttachments = pair.Value;
                            }
                        }

                        foreach (KeyValuePair<string, List<ReferenceAttachment>> pair in dReferenceAttachments)
                        {
                            if (pair.Key == mId)
                            {
                                tRefAttachments = pair.Value;
                            }
                        }

                        AttachmentsForm mAttachment = new AttachmentsForm(mId, tFileAttachments, tItemAttachments, tRefAttachments, applogger);
                        mAttachment.Owner = this;
                        mAttachment.ShowDialog(this);
                    }
                }
                if (e.ColumnIndex == (int)columns.Bcc)
                {
                    List<Recipient> tRecips = null;

                    foreach (KeyValuePair<string, List<Recipient>> pair in dBcc)
                    {
                        if (pair.Key == mId)
                        {
                            tRecips = pair.Value;
                        }
                    }

                    RecipientCollection mRecipients = new RecipientCollection(mId, tRecips);
                    mRecipients.Owner = this;
                    mRecipients.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Cc)
                {
                    List<Recipient> tRecips = null;

                    foreach (KeyValuePair<string, List<Recipient>> pair in dCc)
                    {
                        if (pair.Key == mId)
                        {
                            tRecips = pair.Value;
                        }
                    }

                    RecipientCollection mRecipients = new RecipientCollection(mId, tRecips);
                    mRecipients.Owner = this;
                    mRecipients.ShowDialog(this);                    
                }
                if (e.ColumnIndex == (int)columns.ReplyTo)
                {
                    List<Recipient> tRecips = null;

                    foreach (KeyValuePair<string, List<Recipient>> pair in dReplyTo)
                    {
                        if (pair.Key == mId)
                        {
                            tRecips = pair.Value;
                        }
                    }

                    RecipientCollection mRecipients = new RecipientCollection(mId, tRecips);
                    mRecipients.Owner = this;
                    mRecipients.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Body)
                {
                    List<ItemBody> lBody = null;
                    foreach (KeyValuePair<string, List<ItemBody>> pair in dItemBody)
                    {
                        if (pair.Key == mId)
                        {
                            lBody = pair.Value;
                        }
                    }

                    ItemBodyForm mItemBodyCollection = new ItemBodyForm(mId, lBody);
                    mItemBodyCollection.Owner = this;
                    mItemBodyCollection.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Categories)
                {
                    List<string> lCategories = null;
                    foreach (KeyValuePair<string, List<string>> pair in dCategories)
                    {
                        if (pair.Key == mId)
                        {
                            lCategories = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lCategories);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                applogger.Log("Double-click Error:");
                applogger.Log(ex.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgMessages.CurrentCell.RowIndex;
                int y = dgMessages.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgMessages.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Copy Error:");
                applogger.Log(nre.Message);
                applogger.Log(nre.StackTrace);
            }
            catch (Exception ex)
            {
                applogger.Log("Copy Error:");
                applogger.Log(ex.Message);
                applogger.Log(ex.StackTrace);
            }
        }

        private void dgMessages_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgMessages.CurrentCell = dgMessages[e.ColumnIndex, e.RowIndex];
            }
        }

        // enum for the datagridview columns
        // any changes in the dg column, should only need to be made here
        enum columns
        {
            Id = 0,
            Subject = 1,
            Sender = 2,
            To = 3,
            Attachments = 4,
            Bcc = 5,
            Body = 6,
            Cc = 7,
            ReplyTo = 8,
            Categories = 9,
            BodyPreview = 10,
            ChangeKey = 11,
            ConversationId = 12,
            CreatedDateTime = 13,
            LastModifiedDateTime = 14,
            ReceivedDateTime = 15,
            SentDateTime = 16,
            From = 17,
            HasAttachments = 18,
            Importance = 19,
            IsDeliveryReceiptRequested = 20,
            IsDraft = 21,
            IsRead = 22,
            IsReadReceiptRequested = 23,
            ParentFolderId = 24,
            UniqueBody = 25,
            WebLink = 26,
        };

        private void MailAPI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // cleanup
            //applogger.Dispose();
            //sdklogger.Dispose();
        }

        private void btnCreateNewMessage_Click(object sender, EventArgs e)
        {
            NewMessageForm newMsg = new NewMessageForm(ref graphClient, ref applogger, ref sdklogger);
            newMsg.Owner = this;
            newMsg.ShowDialog(this);
        }

        private async void tvwFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            await GetMessagesAsync();
        }
    }
}