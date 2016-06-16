using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Windows.Forms;
using System.Security;
using System.Net.Http.Headers;
using RESTfulOutlook.Utils;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace RESTfulOutlook
{
    public partial class frmMain : Form
    {
        // clientId is used by the application to uniquely identify itself to Azure AD.
        // redirectUri is the URI where Azure AD will return OAuth responses.
        // authority is the sign-in URL of the tenant.
        // graphApiEndpoint is the resource url for the unified graph api
        private static string clientId;
        Uri redirectUri;
        private static string authority;
        private static string graphApiEndpoint;

        // ADAL and Graph SDK objects
        private AuthenticationContext authContext = null;
        private AuthenticationResult authResult = null;
        public GraphServiceClient graphClient;

        // Basic authentication objects
        private SecureString passwordEntered = new SecureString();
        private string userNameEntered = string.Empty;
        public string userName = null;

        // token cache, logging and config objects
        private FileCache fc;
        public LoggedOnUserHelper user;
        ClassLogger applogger = null;
        ClassLogger sdklogger = null;
        ConfigHelper config = null;

        public frmMain()
        {
            InitializeComponent();

            // init config helper
            config = new ConfigHelper();
            config.clientId = Properties.Settings.Default.ClientId;
            config.graphEndpoint = Properties.Settings.Default.GraphEndpoint;
            config.redirectUri = Properties.Settings.Default.RedirectUri;

            // init config values
            redirectUri = new Uri(config.redirectUri);
            authority = String.Format(CultureInfo.InvariantCulture, config.aadInstance, "common");
            clientId = config.clientId;
            graphApiEndpoint = config.graphEndpoint;
            
            // create log and token cache objects
            applogger = new ClassLogger("restfuloutlook-app.log");
            sdklogger = new ClassLogger("restfuloutlook-graphsdk.log");
            user = new LoggedOnUserHelper();
            fc = new FileCache(Environment.CurrentDirectory);

            // init button state
            btnMailAPI.Enabled = false;
            btnGraphAPI.Enabled = false;
            btnContactsAPI.Enabled = false;
            btnCalendarAPI.Enabled = false;
            btnReportingService.Enabled = false;
            btnUserPhotoAPI.Enabled = false;
        }

        public void ToggleButtons()
        {
            if (rdoBasic.Checked)
            {
                btnReportingService.Enabled = !btnReportingService.Enabled;
            }

            if (rdoGraphAPI.Checked)
            {
                btnMailAPI.Enabled = !btnMailAPI.Enabled;
                btnContactsAPI.Enabled = !btnContactsAPI.Enabled;
                btnCalendarAPI.Enabled = !btnCalendarAPI.Enabled;
                btnGraphAPI.Enabled = !btnGraphAPI.Enabled;
            }
        }

        public void ToggleRdoButtons()
        {
            rdoGraphAPI.Enabled = !rdoGraphAPI.Enabled;
            rdoBasic.Enabled = !rdoBasic.Enabled;
        }

        public void Logout()
        {
            try
            {
                if (rdoGraphAPI.Checked)
                {
                    // clear the token cache
                    authContext.TokenCache.Clear();

                    // check for cache type
                    if (Properties.Settings.Default.TokenCache == "File")
                    {
                        fc.Clear();
                    }
                    else
                    {
                        // clear cookies from browser control
                        ClearCookies();
                    }

                    // clear the user info
                    user.Clear();
                }
                else
                {
                    // reset basic auth controls
                    passwordEntered = null;
                    userNameEntered = null;
                    tbUsername.Enabled = true;
                    mskPassword.Enabled = true;
                    ToggleButtons();
                    ToggleRdoButtons();
                }
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
            }
            finally
            {
                // reset UI text
                ToggleRdoButtons();
                ToggleButtons();
                lblUsername.Text = "No User Logged In";
                btnLoginLogout.Text = "Login";
            }
        }

        private async Task GetGraphSDKClient()
        {
            bool userCancel = false;
                  
            try
            {
                // setup the context based on app settings
                if (Properties.Settings.Default.TokenCache == "Adal")
                {
                    authContext = new AuthenticationContext(authority);
                }
                else
                {
                    authContext = new AuthenticationContext(authority, fc);
                }               
                
                // get access token
                switch (Properties.Settings.Default.AuthPromptBehavior)
                {
                    case "Auto":
                        authResult = await authContext.AcquireTokenAsync(graphApiEndpoint, clientId, redirectUri, new PlatformParameters(PromptBehavior.Auto, null));
                        break;
                    case "Never":
                        authResult = await authContext.AcquireTokenAsync(graphApiEndpoint, clientId, redirectUri, new PlatformParameters(PromptBehavior.Never, null));
                        break;
                    case "RefreshSession":
                        authResult = await authContext.AcquireTokenAsync(graphApiEndpoint, clientId, redirectUri, new PlatformParameters(PromptBehavior.RefreshSession, null));
                        break;
                    default:
                        authResult = await authContext.AcquireTokenAsync(graphApiEndpoint, clientId, redirectUri, new PlatformParameters(PromptBehavior.Always, null));
                        break;
                }
                
                // create the graph client
                graphClient = new GraphServiceClient(
                    new DelegateAuthenticationProvider(
                        (requestMessage) =>
                        {
                            requestMessage.Headers.Authorization = new AuthenticationHeaderValue(authResult.AccessTokenType, authResult.AccessToken);
                            return Task.FromResult(0);
                        }));
            }
            catch (AdalException ae)
            {
                if (ae.ErrorCode != "user_interaction_required")
                {
                    applogger.Log(ae.Message);
                    userCancel = true;
                }
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
            }
            finally
            {
                if (userCancel == false)
                {
                    GetUserInfo();
                    userName = authResult.UserInfo.DisplayableId;
                    lblUsername.Text = userName;
                    btnLoginLogout.Text = "Logout";
                    ToggleRdoButtons();
                    ToggleButtons();
                }
                else
                {
                    lblUsername.Text = "No User Logged In";
                    btnLoginLogout.Text = "Login";
                }
            }
        }

        public void GetUserInfo()
        {
            // populate user info
            user.DisplayableId = authResult.UserInfo.DisplayableId;
            user.GivenName = authResult.UserInfo.GivenName;
            user.FamilyName = authResult.UserInfo.FamilyName;
            user.AccessToken = authResult.AccessToken;
            user.IdToken = authResult.IdToken;
            user.ExpiresOn = authResult.ExpiresOn;
            user.AccessTokenType = authResult.AccessTokenType;
        }

        public async void Login()
        {
            try
            {
                if (rdoGraphAPI.Checked)
                {
                    // get the graph client
                    await GetGraphSDKClient();
                }
                else
                {
                    // store the basic auth creds
                    passwordEntered = converToSecureString(mskPassword.Text);
                    userNameEntered = tbUsername.Text;
                    tbUsername.Text = string.Empty;
                    mskPassword.Text = string.Empty;
                    lblUsername.Text = userNameEntered;
                    tbUsername.Enabled = false;
                    mskPassword.Enabled = false;
                    ToggleButtons();
                    ToggleRdoButtons();
                    btnLoginLogout.Text = "Logout";
                }
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
            }
        }

        public SecureString converToSecureString(string pass)
        {
            var secureString = new SecureString();
            if (pass.Length > 0)
            {
                foreach (var c in pass.ToCharArray())
                {
                    secureString.AppendChar(c);
                }
            }
            return secureString;
        }

        #region Form Button Clicks
        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoBasic.Checked && (tbUsername.Text == string.Empty || mskPassword.Text == string.Empty) && btnLoginLogout.Text == "Login")
                {
                    MessageBox.Show("Authenticate using basic credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (rdoBasic.Checked && btnLoginLogout.Text == "Logout")
                {
                    btnReportingService.Enabled = false;
                    ToggleRdoButtons();
                    Logout();
                }
                else if (btnLoginLogout.Text == "Login")
                {
                    Login();
                }
                else
                {
                    Logout();
                }
            }
            catch(Exception ex)
            {
                applogger.Log(ex.Message);
            }
        }

        private void btnContactsAPI_Click(object sender, EventArgs e)
        {
            Forms.ContactsAPI mContactsAPI = new Forms.ContactsAPI(ref graphClient, ref applogger, ref sdklogger);
            mContactsAPI.Owner = this;
            mContactsAPI.ShowDialog(this);
        }

        private void btnReportingService_Click(object sender, EventArgs e)
        {
            Forms.ReportingService mReportingService = new Forms.ReportingService(userNameEntered, passwordEntered);
            mReportingService.Owner = this;
            mReportingService.ShowDialog(this);
        }

        private void btnCalendarAPI_Click(object sender, EventArgs e)
        {
            Forms.CalendarAPI mCalendarAPI = new Forms.CalendarAPI(ref graphClient, ref applogger, ref sdklogger);
            mCalendarAPI.Owner = this;
            mCalendarAPI.ShowDialog(this);
        }

        private void btnMailAPI_Click(object sender, EventArgs e)
        {
            Forms.MailAPI mMailAPI = new Forms.MailAPI(ref graphClient, ref applogger, ref sdklogger);
            mMailAPI.Owner = this;
            mMailAPI.ShowDialog(this);
        }

        private void btnGraphAPI_Click(object sender, EventArgs e)
        {
            Forms.GraphAPI mGraph = new Forms.GraphAPI(authResult, user.DisplayableId);
            mGraph.Owner = this;
            mGraph.ShowDialog(this);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Forms.Settings mSettings = new Forms.Settings();
            mSettings.Owner = this;
            mSettings.ShowDialog();
            try
            {
                // update the config values
                clientId = Properties.Settings.Default.ClientId;
                redirectUri = new Uri(Properties.Settings.Default.RedirectUri);

                config.clientId = clientId;
                config.redirectUri = Properties.Settings.Default.RedirectUri;
            }
            catch (Exception ex)
            {
                // if we fail on a bad config setting, clear property
                applogger.Log("Settings failed to update: " + ex.Message);
                Properties.Settings.Default.ClientId = "";
                Properties.Settings.Default.RedirectUri = "";
                Properties.Settings.Default.Save();
            }
            
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            Forms.UserInfoForm mUserInfo = new Forms.UserInfoForm(user);
            mUserInfo.Owner = this;
            mUserInfo.ShowDialog(this);
        }

        private void btnScopes_Click(object sender, EventArgs e)
        {
            string bodyText = "View users' basic profile\r\n" + "View users' email address\r\n"
                + "Read user contacts\r\n" + "Read user calendars\r\n" + "Read user mail\r\n"
                + "Access directory as the signed on user\r\n" + "Sign in and read user profile"
                + "Sign in and read user profile\r\n" + "Read items in all site collections\r\n"
                + "Read threat intelligence data for your organization\r\n" + "Read activity data for your organization\r\n"
                + "Read service health information for your organization\r\n" + "Read activity reports for your organization";

            MessageBox.Show(bodyText, "Office365 Graph Scopes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Cookie Management

        // This function clears cookies from the browser control used by ADAL.
        private void ClearCookies()
        {
            const int INTERNET_OPTION_END_BROWSER_SESSION = 42;
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_END_BROWSER_SESSION, IntPtr.Zero, 0);
        }

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        #endregion

        private void rdoGraphAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGraphAPI.Checked == true)
            {
                mskPassword.Text = "";
                tbUsername.Text = "";
                tbUsername.Enabled = false;
                mskPassword.Enabled = false;
            }
        }
        private void rdoBasic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBasic.Checked == true)
            {
                tbUsername.Enabled = true;
                mskPassword.Enabled = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // cleanup resources on exit
            applogger.Dispose();
            sdklogger.Dispose();
        }
    }
}