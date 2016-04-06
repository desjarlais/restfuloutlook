using System;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Office365.OutlookServices;
using Microsoft.Graph;

namespace RESTfulOutlook.Forms
{
    public partial class RecurrenceForm : Form
    {
        public RecurrenceForm(RecurrencePattern pattern, RecurrenceRange range)
        {
            InitializeComponent();
            StringBuilder dow = new StringBuilder();
            int n = dgRecurrencePattern.Rows.Add();
            dgRecurrencePattern.Rows[n].Cells[0].Value = pattern.Type;
            dgRecurrencePattern.Rows[n].Cells[1].Value = pattern.Interval;
            dgRecurrencePattern.Rows[n].Cells[2].Value = pattern.DayOfMonth;
            dgRecurrencePattern.Rows[n].Cells[3].Value = pattern.Month;
            foreach (var item in pattern.DaysOfWeek)
            {
                dow.Append(item + "-");
            }
            dgRecurrencePattern.Rows[n].Cells[4].Value = dow;
            dgRecurrencePattern.Rows[n].Cells[5].Value = pattern.FirstDayOfWeek;
            dgRecurrencePattern.Rows[n].Cells[6].Value = pattern.Index;

            int x = dgRecurrenceRange.Rows.Add();
            dgRecurrenceRange.Rows[n].Cells[0].Value = range.Type;
            dgRecurrenceRange.Rows[n].Cells[1].Value = range.StartDate;
            dgRecurrenceRange.Rows[n].Cells[2].Value = range.EndDate;
            dgRecurrenceRange.Rows[n].Cells[3].Value = range.NumberOfOccurrences;
            dgRecurrenceRange.Rows[n].Cells[4].Value = range.RecurrenceTimeZone;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgRecurrencePattern.CurrentCell.RowIndex;
                int y = dgRecurrencePattern.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgRecurrencePattern.Rows[x].Cells[y].Value.ToString());   
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgRecurrenceRange.CurrentCell.RowIndex;
                int y = dgRecurrenceRange.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgRecurrenceRange.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }   
        }

        private void dgRecurrencePattern_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgRecurrencePattern.CurrentCell = dgRecurrencePattern[e.ColumnIndex, e.RowIndex];
            }
        }

        private void dgRecurrenceRange_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgRecurrenceRange.CurrentCell = dgRecurrenceRange[e.ColumnIndex, e.RowIndex];
            }
        }
    }
}
