using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            
            // display assembly version and help link
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            lblVersion.Text = version.ToString();

            // populate hyperlinks
            linkFeedback.Text = "RESTfulOutlook Website";
            linkFeedback.Links.Add(0, 22, "http://github.com/desjarlais/restfuloutlook/issues");

            linkRegistration.Text = "Microsoft Graph App Registration";
            linkRegistration.Links.Add(0, 32, "https://graph.microsoft.io/en-us/docs/authorization/app_authorization");

            // get the app settings and populate radio buttons
            string prompt = Properties.Settings.Default.AuthPromptBehavior;

            switch (prompt)
            {
                case "Always":
                    rdoAlways.Checked = true;
                    break;
                case "Never":
                    rdoNever.Checked = true;
                    break;
                case "Auto":
                    rdoAuto.Checked = true;
                    break;
                default:
                    rdoRefresh.Checked = true;
                    break;
            }

            // set the token cache value
            if (Properties.Settings.Default.TokenCache != "Adal")
            {
                rdoFileCache.Checked = true;
            }

            // set the diagnostics options
            if (Properties.Settings.Default.OutlookDiagnostics == "On")
            {
                ckOutlookDiag.Checked = true;
            }
            else
            {
                ckOutlookDiag.Checked = false;
            }

            // set the initial config values
            txtClientId.Text = Properties.Settings.Default.ClientId;
            txtRedirectUri.Text = Properties.Settings.Default.RedirectUri;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // set the prompt behavior setting
            if (rdoAuto.Checked)
            {
                Properties.Settings.Default.AuthPromptBehavior = "Auto";
            }
            else if (rdoNever.Checked)
            {
                Properties.Settings.Default.AuthPromptBehavior = "Never";
            }
            else if (rdoRefresh.Checked)
            {
                Properties.Settings.Default.AuthPromptBehavior = "RefreshSession";
            }
            else
            {
                Properties.Settings.Default.AuthPromptBehavior = "Always";
            }

            // set the token cache type
            if (rdoAdalCache.Checked)
            {
                Properties.Settings.Default.TokenCache = "Adal";
            }
            else
            {
                Properties.Settings.Default.TokenCache = "File";
            }

            // diagnostic settings
            if (ckOutlookDiag.Checked)
            {
                Properties.Settings.Default.OutlookDiagnostics = "On";
            }
            else
            {
                Properties.Settings.Default.OutlookDiagnostics = "Off";
            }

            // set config values
            Properties.Settings.Default.ClientId = txtClientId.Text;
            Properties.Settings.Default.RedirectUri = txtRedirectUri.Text;

            // save settings and close form
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Button Log Click
        private void btnAppLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "restfuloutlook-app.log");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open log file: " + ex.Message);
            }
        }

        private void btnGraphLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "restfuloutlook-graphsdk.log");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open log file: " + ex.Message);
            }
        }

        #endregion

        private void chkEditAppRegistration_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditAppRegistration.Checked)
            {
                txtClientId.Enabled = true;
                txtRedirectUri.Enabled = true;
                btnResetRegistration.Enabled = true;
            }
            else
            {
                txtClientId.Enabled = false;
                txtRedirectUri.Enabled = false;
                btnResetRegistration.Enabled = false;
            }
        }       

        // hyperlink button click events
        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void linkFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void btnResetRegistration_Click(object sender, EventArgs e)
        {
            txtClientId.Text = "";
            txtRedirectUri.Text = "";
        }
    }
}
