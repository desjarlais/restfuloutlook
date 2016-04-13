using RESTfulOutlook.Utils;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm(LoggedOnUserHelper user)
        {
            InitializeComponent();
            lstResults.Items.Add("User Id: = " + user.DisplayableId);
            lstResults.Items.Add("Given Name: = " + user.GivenName);
            lstResults.Items.Add("Family Name: = " + user.FamilyName);
            lstResults.Items.Add("Access Token = " + user.AccessToken);
            lstResults.Items.Add("Access Token Type = " + user.AccessTokenType);
            lstResults.Items.Add("Access Token Expires = " + user.ExpiresOn.ToString());
            lstResults.Items.Add("Id Token = " + user.IdToken);
        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(lstResults.SelectedItem.ToString());
        }
    }
}
