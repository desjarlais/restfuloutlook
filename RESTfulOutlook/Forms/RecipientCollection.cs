//using Microsoft.Office365.OutlookServices;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class RecipientCollection : Form
    {
        public RecipientCollection(string id, List<Recipient> recips)
        {
            InitializeComponent();
            try
            {
                foreach (var item in recips)
                {
                    // populate the grid view
                    int n = dgRecipients.Rows.Add();
                    dgRecipients.Rows[n].Cells[0].Value = item.EmailAddress.Name;
                    dgRecipients.Rows[n].Cells[1].Value = item.EmailAddress.Address;
                }
            }
            catch (NullReferenceException)
            {
                toolStripStatus.Text = "No recipients to display.";
            }
            catch (Exception ex)
            {
                toolStripStatus.Text = ex.Message;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                int x = dgRecipients.CurrentCell.RowIndex;
                int y = dgRecipients.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgRecipients.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void dgRecipients_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgRecipients.CurrentCell = dgRecipients[e.ColumnIndex, e.RowIndex];
            }
        }
    }
}
