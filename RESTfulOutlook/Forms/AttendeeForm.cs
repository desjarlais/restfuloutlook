using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Graph;

namespace RESTfulOutlook.Forms
{
    public partial class AttendeeForm : Form
    {
        public AttendeeForm(string id, List<Attendee> attendees)
        {
            InitializeComponent();
            foreach (var item in attendees)
            {
                // populate the grid view
                int n = dgAttendee.Rows.Add();
                dgAttendee.Rows[n].Cells[0].Value = item.Status.Response;
                dgAttendee.Rows[n].Cells[1].Value = item.Type;
                dgAttendee.Rows[n].Cells[2].Value = item.EmailAddress.Address;
                dgAttendee.Rows[n].Cells[3].Value = item.EmailAddress.Name;
                dgAttendee.Rows[n].Cells[4].Value = item.Status.Time;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgAttendee.CurrentCell.RowIndex;
                int y = dgAttendee.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgAttendee.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void dgAttendee_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgAttendee.CurrentCell = dgAttendee[e.ColumnIndex, e.RowIndex];
            }
        }
    }
}
