using System;
using System.Windows.Forms;
using Microsoft.Graph;

namespace RESTfulOutlook.Forms
{
    public partial class PhysicalAddressForm : Form
    {
        public PhysicalAddressForm(PhysicalAddress address)
        {
            InitializeComponent();
            // populate the grid view
            int n = dgPhysicalAddress.Rows.Add();
            dgPhysicalAddress.Rows[n].Cells[0].Value = address.Street;
            dgPhysicalAddress.Rows[n].Cells[1].Value = address.City;
            dgPhysicalAddress.Rows[n].Cells[2].Value = address.State;
            dgPhysicalAddress.Rows[n].Cells[4].Value = address.PostalCode;
            dgPhysicalAddress.Rows[n].Cells[3].Value = address.CountryOrRegion;
        }

        private void dgPhysicalAddress_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgPhysicalAddress.CurrentCell = dgPhysicalAddress[e.ColumnIndex, e.RowIndex];
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgPhysicalAddress.CurrentCell.RowIndex;
                int y = dgPhysicalAddress.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgPhysicalAddress.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }
        }
    }
}
