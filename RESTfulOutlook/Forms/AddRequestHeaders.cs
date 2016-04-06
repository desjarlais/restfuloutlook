using System;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class AddRequestHeaders : Form
    {
        public AddRequestHeaders()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbName.Text != "" && txtValue.Text != "")
            {
                GraphAPI gForm = this.Owner as GraphAPI;
                gForm.hdrName = cmbName.Text;
                gForm.hdrValue = txtValue.Text;
            }
            this.Close();
        }
    }
}
