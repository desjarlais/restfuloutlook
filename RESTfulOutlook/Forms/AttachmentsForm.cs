using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Graph;
using RESTfulOutlook.Utils;

namespace RESTfulOutlook.Forms
{
    public partial class AttachmentsForm : Form
    {
        public Dictionary<string, object> dAdditionalFileData;
        public Dictionary<string, object> dAdditionalItemData;
        public Dictionary<string, object> dAdditionalRefData;
        public Dictionary<string, byte[]> dContentBytes;

        ClassLogger applogger = null;

        public AttachmentsForm(string id, List<FileAttachment> fAttachments, List<ItemAttachment> iAttachments, List<ReferenceAttachment> rAttachments, ref ClassLogger appLogger)
        {
            InitializeComponent();
            applogger = appLogger;
            
            // init dictionaries
            dAdditionalFileData = new Dictionary<string, object>();
            dAdditionalItemData = new Dictionary<string, object>();
            dAdditionalRefData = new Dictionary<string, object>();
            dContentBytes = new Dictionary<string, byte[]>();

            try
            {
                Cursor = Cursors.WaitCursor;

                if (fAttachments != null)
                {
                    foreach (var fItem in fAttachments)
                    {
                        // populate the grid view for file attachments
                        int n = dgFileAttachments.Rows.Add();
                        if (fItem.ContentBytes != null)
                        {
                            dgFileAttachments.Rows[n].Cells[0].Value = "View Data";
                            dContentBytes.Add(fItem.Id, fItem.ContentBytes);
                        }
                        dgFileAttachments.Rows[n].Cells[1].Value = fItem.ContentId;
                        dgFileAttachments.Rows[n].Cells[2].Value = fItem.ContentLocation;
                        dgFileAttachments.Rows[n].Cells[3].Value = fItem.ContentType;
                        dgFileAttachments.Rows[n].Cells[4].Value = fItem.LastModifiedDateTime;
                        dgFileAttachments.Rows[n].Cells[5].Value = fItem.Id;
                        dgFileAttachments.Rows[n].Cells[6].Value = fItem.IsInline.ToString();
                        dgFileAttachments.Rows[n].Cells[7].Value = fItem.Name;
                        dgFileAttachments.Rows[n].Cells[8].Value = AttachmentHelper.SizeSuffix(fItem.Size.Value);

                        if (fItem.AdditionalData != null)
                        {
                            dgFileAttachments.Rows[n].Cells[9].Value = "View Data";
                            foreach (var data in fItem.AdditionalData)
                            {
                                dAdditionalFileData.Add(data.Key, data.Value);
                            }
                        }
                    }
                }
                
                if (iAttachments != null)
                {
                    // populate the grid for item attachments
                    foreach (var iItem in iAttachments)
                    {
                        int m = dgItemAttachments.Rows.Add();
                        dgItemAttachments.Rows[m].Cells[0].Value = iItem.ContentType;
                        dgItemAttachments.Rows[m].Cells[1].Value = iItem.LastModifiedDateTime;
                        dgItemAttachments.Rows[m].Cells[2].Value = iItem.Id;
                        dgItemAttachments.Rows[m].Cells[3].Value = iItem.Item;
                        dgItemAttachments.Rows[m].Cells[4].Value = iItem.IsInline.ToString();
                        dgItemAttachments.Rows[m].Cells[5].Value = iItem.Name;
                        dgItemAttachments.Rows[m].Cells[6].Value = AttachmentHelper.SizeSuffix(iItem.Size.Value);

                        if (iItem.AdditionalData != null)
                        {
                            dgItemAttachments.Rows[m].Cells[7].Value = "View Data";
                            foreach (var data in iItem.AdditionalData)
                            {
                                dAdditionalItemData.Add(data.Key, data.Value);
                            }
                        }
                    }
                }

                if (rAttachments != null)
                {
                    // populate the grid for reference attachments
                    foreach (var iItem in rAttachments)
                    {
                        int m = dgRefAttachments.Rows.Add();
                        dgRefAttachments.Rows[m].Cells[0].Value = iItem.ContentType;
                        dgRefAttachments.Rows[m].Cells[1].Value = iItem.LastModifiedDateTime;
                        dgRefAttachments.Rows[m].Cells[2].Value = iItem.Id;
                        dgRefAttachments.Rows[m].Cells[3].Value = iItem.IsInline.ToString();
                        dgRefAttachments.Rows[m].Cells[4].Value = iItem.Name;
                        dgRefAttachments.Rows[m].Cells[5].Value = AttachmentHelper.SizeSuffix(iItem.Size.Value);

                        if (iItem.AdditionalData != null)
                        {
                            dgRefAttachments.Rows[m].Cells[6].Value = "View Data";
                            foreach (var data in iItem.AdditionalData)
                            {
                                dAdditionalRefData.Add(data.Key, data.Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                applogger.Log("ctor exception:");
                applogger.Log(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgFileAttachments.CurrentCell.RowIndex;
                int y = dgFileAttachments.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgFileAttachments.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Copy Error: ");
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log("Copy Error: " + ex.Message);
                applogger.Log(ex.Message);
            }
        }

        private void dgAttachments_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgFileAttachments.CurrentCell = dgFileAttachments[e.ColumnIndex, e.RowIndex];
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgItemAttachments.CurrentCell.RowIndex;
                int y = dgItemAttachments.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgItemAttachments.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Copy Error: ");
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log("Copy Error: " + ex.Message);
                applogger.Log(ex.Message);
            }
        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgRefAttachments.CurrentCell.RowIndex;
                int y = dgRefAttachments.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgRefAttachments.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Copy Error: ");
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log("Copy Error: " + ex.Message);
                applogger.Log(ex.Message);
            }
        }

        private void dgFileAttachments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the selected item Id
            string mId = dgFileAttachments.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (e.ColumnIndex == 9)
            {
                List<string> tempAdditionalData = new List<string>();
                foreach (KeyValuePair<string, object> pair in dAdditionalFileData)
                {
                    if (pair.Value != null)
                    {
                        tempAdditionalData.Add(pair.Key + " : " + pair.Value.ToString());
                    }
                    else
                    {
                        tempAdditionalData.Add(pair.Key);
                    }
                }

                CategoriesForm mCategories = new CategoriesForm(tempAdditionalData);
                mCategories.Owner = this;
                mCategories.ShowDialog(this);
            }

            if (e.ColumnIndex == 0)
            {
                byte[] tempByteArray = null;
                foreach (KeyValuePair<string, byte[]> pair in dContentBytes)
                {
                    if (pair.Key == mId)
                    {
                        tempByteArray = pair.Value;
                    }
                }

                ContentBytesForm cBytes = new ContentBytesForm(tempByteArray);
                cBytes.Owner = this;
                cBytes.ShowDialog(this);
            }
        }

        private void dgRefAttachments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                List<string> tempAdditionalData = new List<string>();
                foreach (KeyValuePair<string, object> pair in dAdditionalRefData)
                {
                    if (pair.Value != null)
                    {
                        tempAdditionalData.Add(pair.Key + " : " + pair.Value.ToString());
                    }
                    else
                    {
                        tempAdditionalData.Add(pair.Key);
                    }
                }

                CategoriesForm mCategories = new CategoriesForm(tempAdditionalData);
                mCategories.Owner = this;
                mCategories.ShowDialog(this);
            }
        }

        private void dgItemAttachments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                List<string> tempAdditionalData = new List<string>();
                foreach (KeyValuePair<string, object> pair in dAdditionalItemData)
                {
                    if (pair.Value != null)
                    {
                        tempAdditionalData.Add(pair.Key + " : " + pair.Value.ToString());
                    }
                    else
                    {
                        tempAdditionalData.Add(pair.Key);
                    }
                }

                CategoriesForm mCategories = new CategoriesForm(tempAdditionalData);
                mCategories.Owner = this;
                mCategories.ShowDialog(this);
            }
        }
    }
}
