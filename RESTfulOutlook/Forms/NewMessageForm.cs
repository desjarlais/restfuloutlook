using Microsoft.Graph;
using RESTfulOutlook.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class NewMessageForm : Form
    {
        GraphServiceClient graphClient;
        ClassLogger applogger = null;
        ClassLogger sdklogger = null;
        List<Recipient> toRecipients, ccRecipients, bccRecipients;

        public NewMessageForm(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;
            toRecipients = new List<Recipient>();
            ccRecipients = new List<Recipient>();
            bccRecipients = new List<Recipient>();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            CreateNewMessage();
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                FileInfo f = new FileInfo(file);

                try
                {
                    int n = dgAttachments.Rows.Add();
                    string size = Utils.AttachmentHelper.SizeSuffix(f.Length);
                    dgAttachments.Rows[n].Cells[0].Value = file;
                    dgAttachments.Rows[n].Cells[1].Value = Path.GetFileName(file);
                    dgAttachments.Rows[n].Cells[2].Value = "Octet";
                    dgAttachments.Rows[n].Cells[3].Value = size;
                    dgAttachments.Rows[n].Cells[4].Value = "";
                    dgAttachments.Rows[n].Cells[5].Value = "False";
                    dgAttachments.Rows[n].Cells[6].Value = "#Microsoft.OutlookServices.FileAttachment";
                }
                catch (IOException ioe)
                {
                    sdklogger.Log("Error: " + ioe.Message);
                    sdklogger.Log("StackTrace: " + ioe.StackTrace);
                }
                catch (Exception ex)
                {
                    sdklogger.Log("Error: " + ex.Message);
                    sdklogger.Log("StackTrace: " + ex.StackTrace);
                }
            }
        }

        private void btnRemoveAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                int cellRow = dgAttachments.CurrentCellAddress.Y;
                if (dgAttachments.CurrentCell.ColumnIndex >= 0)
                {
                    dgAttachments.Rows.RemoveAt(dgAttachments.Rows[cellRow].Index);
                }
            }
            catch (NullReferenceException nre)
            {
                // if the attachment grid is empty, just return
                if (dgAttachments.CurrentCellAddress.Y < 1)
                {
                    return;
                }
                else
                {
                    // log any other null ref errors
                    sdklogger.Log("Error: " + nre.Message);
                    sdklogger.Log("StackTrace: " + nre.StackTrace);
                    sdklogger.Log("Inner Exception: " + nre.InnerException);
                }
            }
            catch (Exception ex)
            {
                sdklogger.Log("Error: " + ex.Message);
                sdklogger.Log("StackTrace: " + ex.StackTrace);
            }
        }

        public async void CreateNewMessage()
        {
            try
            {
                // split out the different email addresses and add to collection
                char[] delim = { ';' };
                
                // handle To:
                string[] toArray = tbToRecipients.Text.Split(delim);
                foreach (var to in toArray)
                {
                    AddRecipToCollection(to, toRecipients);
                }

                // handle Cc:
                string[] ccArray = tbCC.Text.Split(delim);
                foreach (var cc in toArray)
                {
                    AddRecipToCollection(cc, ccRecipients);
                }

                // handle Bcc:
                string[] bccArray = tbBcc.Text.Split(delim);
                foreach (var bcc in toArray)
                {
                    AddRecipToCollection(bcc, bccRecipients);
                }

                // create the item body
                ItemBody body = new ItemBody();
                body.Content = rtbBody.Text;
                body.ContentType = BodyType.Html;

                // create the message object and add the properties
                Microsoft.Graph.Message msg = new Microsoft.Graph.Message();
                msg.Subject = tbSubject.Text;
                msg.Body = body;
                msg.ToRecipients = toRecipients;
                msg.CcRecipients = ccRecipients;
                msg.BccRecipients = bccRecipients;

                // set importance
                if (cbxImportance.Text == "Normal")
                {
                    msg.Importance = Importance.Normal;
                }
                else if (cbxImportance.Text == "High")
                {
                    msg.Importance = Importance.High;
                }
                else
                {
                    msg.Importance = Importance.Low;
                }

                // setup the attachment collection
                if (dgAttachments.Rows.Count > 0)
                {
                    // setup the attachments collection
                    msg.Attachments = new MessageAttachmentsCollectionPage();

                    // add attachments
                    foreach (DataGridViewRow row in dgAttachments.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            // create the file attachment from the file path
                            FileAttachment file = new FileAttachment();
                            byte[] array = System.IO.File.ReadAllBytes(row.Cells[0].Value.ToString());
                            file.ContentBytes = array;
                            file.Name = row.Cells[1].Value.ToString();
                            file.ContentType = row.Cells[2].Value.ToString();
                            file.ContentId = row.Cells[4].Value.ToString();
                            file.IsInline = false;
                            file.ODataType = row.Cells[6].Value.ToString();

                            // add it to the message        
                            msg.Attachments.Add(file);
                        }
                    }
                }                

                // log the request info
                sdklogger.Log(graphClient.Me.SendMail(msg, true).Request().GetHttpRequestMessage().Headers.ToString());
                sdklogger.Log(graphClient.Me.SendMail(msg, true).Request().GetHttpRequestMessage().RequestUri.ToString());

                // send the new message
                await graphClient.Me.SendMail(msg, true).Request().PostAsync();
            }
            catch (Exception ex)
            {
                sdklogger.Log("NewMessageSend Failed: ");
                sdklogger.Log(ex.Message);
                sdklogger.Log(ex.StackTrace);
            }
            finally
            {
                // close the form
                Close();
            }
        }

        /// <summary>
        /// This function creates a new recip and emailaddress object,
        /// then adds the recip to the collection
        /// </summary>
        /// <param name="email">smtp address for the recipient</param>
        public void AddRecipToCollection(string email, List<Recipient> recips)
        {
            // trim the address for any spaces before adding
            email = email.Trim();

            // create the recip and add the email address
            Recipient recip = new Recipient();
            EmailAddress recipAddress = new EmailAddress();
            recipAddress.Address = email;
            recip.EmailAddress = recipAddress;
            recips.Add(recip);
        }
    }
}
