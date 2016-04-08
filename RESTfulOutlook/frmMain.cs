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
using System.Diagnostics;
using System.IO;

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
        private String userNameEntered = String.Empty;
        public string userName = null;

        // token cache, logging and config objects
        private FileCache fc;
        public LoggedOnUserHelper user;
        ClassLogger applogger = null;
        ClassLogger sdklogger = null;
        ConfigHelper config = null;
        Stream logFile = null;

        public frmMain()
        {
            InitializeComponent();

            // init config helper
            config = new ConfigHelper();
            config.clientId = Properties.Settings.Default.ClientId;
            config.authority = Properties.Settings.Default.Authority;
            config.tenantId = Properties.Settings.Default.TenantId;
            config.graphEndpoint = Properties.Settings.Default.GraphEndpoint;
            config.redirectUri = Properties.Settings.Default.RedirectUri;

            // init config values
            redirectUri = new Uri(config.redirectUri);
            authority = String.Format(CultureInfo.InvariantCulture, config.authority, config.tenantId);
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

            // setup adal tracing
            logFile = System.IO.File.Open("restfuloutlook-adal.log", FileMode.Append, FileAccess.Write);
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            SetAdalTracing();
        }

        public void SetAdalTracing()
        {
            // set the trace level
            switch (Properties.Settings.Default.AdalTraceLevel)
            {
                case "Info":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.Information;
                    break;
                case "Warning":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.Warning;
                    break;
                case "Error":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.Error;
                    break;
                case "Verbose":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.Verbose;
                    break;
                case "All":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.All;
                    break;
                case "ActivityTracing":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.ActivityTracing;
                    break;
                case "Critical":
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.Critical;
                    break;
                default:
                    AdalTrace.TraceSource.Switch.Level = SourceLevels.Off;
                    break;
            }
        }

        public void ToggleButtons()
        {
            // by the time we get here and login is the text for the button
            // we are logging out and need to disable/reset the UI
            if (btnLoginLogout.Text == "Login")
            {
                if (rdoBasic.Checked)
                {
                    btnReportingService.Enabled = false;
                }

                if (rdoGraphAPI.Checked)
                {
                    btnMailAPI.Enabled = false;
                    btnContactsAPI.Enabled = false;
                    btnCalendarAPI.Enabled = false;
                    btnGraphAPI.Enabled = false;
                }
            }
            else
            {
                // since we aren't logging out, light up the UI
                if (rdoBasic.Checked)
                {
                    btnReportingService.Enabled = true;
                }

                if (rdoGraphAPI.Checked)
                {
                    btnMailAPI.Enabled = true;
                    btnContactsAPI.Enabled = true;
                    btnCalendarAPI.Enabled = true;
                    btnGraphAPI.Enabled = true;
                }
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
                }
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
            }
            finally
            {
                // reset UI text
                lblUsername.Text = "No User Logged In";
                btnLoginLogout.Text = "Login";
            }
        }

        private async Task GetGraphSDKClient()
        {            
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
                        authResult = authContext.AcquireToken(graphApiEndpoint, clientId, redirectUri, PromptBehavior.Auto);
                        break;
                    case "Never":
                        authResult = authContext.AcquireToken(graphApiEndpoint, clientId, redirectUri, PromptBehavior.Never);
                        break;
                    case "RefreshSession":
                        authResult = authContext.AcquireToken(graphApiEndpoint, clientId, redirectUri, PromptBehavior.RefreshSession);
                        break;
                    default:
                        authResult = authContext.AcquireToken(graphApiEndpoint, clientId, redirectUri, PromptBehavior.Always);
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
                    ToggleButtons();
                    ToggleRdoButtons();
                    Logout();
                }
                // if user interaction is required, proceed to main page without sign in
                return;
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
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
            user.RefreshToken = authResult.RefreshToken;
            user.ExpiresOn = authResult.ExpiresOn;
            user.AccessTokenType = authResult.AccessTokenType;
        }

        public async void Login()
        {
            try
            {
                // get the graph client
                await GetGraphSDKClient();
                GetUserInfo();
                userName = authResult.UserInfo.DisplayableId;
                lblUsername.Text = userName;
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
            }

            toolStripStatusLabel1.Text = "Ready";
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
            else
            {
                if (btnLoginLogout.Text == "Logout")
                {
                    // light up the auth options
                    ToggleRdoButtons();
                    btnLoginLogout.Text = "Login";
                    if (rdoBasic.Checked)
                    {
                        tbUsername.Enabled = true;
                        mskPassword.Enabled = true;
                    }

                    // start the logout sequence
                    Logout();
                    ToggleButtons();
                }
                else
                {
                    // disable the auth options
                    ToggleRdoButtons();
                    btnLoginLogout.Text = "Logout";

                    // start the login sequence
                    try
                    {
                        if (rdoGraphAPI.Checked == true)
                        {
                            Login();
                        }
                        else
                        {
                            passwordEntered = converToSecureString(mskPassword.Text);
                            userNameEntered = tbUsername.Text;
                            tbUsername.Text = string.Empty;
                            mskPassword.Text = string.Empty;
                            lblUsername.Text = userNameEntered;
                            tbUsername.Enabled = false;
                            mskPassword.Enabled = false;
                        }
                        ToggleButtons();
                    }
                    catch (AdalException ae)
                    {
                        toolStripStatusLabel1.Text = "User Auth Cancelled.";
                        applogger.Log(ae.Message);
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabel1.Text = "Error: Exception";
                        applogger.Log(ex.Message);
                    }
                }
            }
        }

        private void btnContactsAPI_Click(object sender, EventArgs e)
        {
            Forms.ContactsAPI mContactsAPI = new Forms.ContactsAPI(graphClient, applogger, sdklogger);
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
            Forms.CalendarAPI mCalendarAPI = new Forms.CalendarAPI(graphClient, applogger, sdklogger);
            mCalendarAPI.Owner = this;
            mCalendarAPI.ShowDialog(this);
        }

        private void btnMailAPI_Click(object sender, EventArgs e)
        {
            Forms.MailAPI mMailAPI = new Forms.MailAPI(graphClient, applogger, sdklogger);
            mMailAPI.Owner = this;
            mMailAPI.ShowDialog(this);
        }

        private void btnGraphAPI_Click(object sender, EventArgs e)
        {
            Forms.GraphAPI mGraph = new Forms.GraphAPI(authResult);
            mGraph.Owner = this;
            mGraph.ShowDialog(this);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Forms.Settings mSettings = new Forms.Settings();
            mSettings.Owner = this;
            mSettings.ShowDialog();
            SetAdalTracing();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            Forms.UserInfoForm mUserInfo = new Forms.UserInfoForm(user);
            mUserInfo.Owner = this;
            mUserInfo.ShowDialog(this);
        }

        private void btnScopes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Graph Scopes : \r\n" + "============================\r\n" 
                + "View users' basic profile\r\n" + "View users' email address\r\n"
                + "Read user contacts\r\n" + "Read user calendars\r\n" + "Read user mail\r\n"
                + "Access directory as the signed on user\r\n" + "Sign in and read user profile", "Application Scopes"
                + "Sign in and read user profile\r\n" + "Read items in all site collections\r\n"
                + "Read threat intelligence data for your organization\r\n" + "Read activity data for your organization\r\n"
                + "Read service health information for your organization\r\n" + "Read activity reports for your organization",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Trace.Listeners.Clear();
            logFile.Close();
        }
    }
}