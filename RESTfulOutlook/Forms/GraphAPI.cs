using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using RESTfulOutlook.Utils;
using RESTfulOutlook.JsonHelpers;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics;

namespace RESTfulOutlook.Forms
{
    public partial class GraphAPI : Form
    {
        AuthenticationResult result;
        private HttpClient httpClient = new HttpClient();
        Uri redirectUri = new Uri(Properties.Settings.Default.RedirectUri);
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        List<string> notificationGuids = new List<string>();
        public string hdrName, hdrValue, xAnchorMbx, treeViewResult;
        ClassLogger logger = null;

        public GraphAPI(AuthenticationResult authResult, string anchor)
        {
            InitializeComponent();

            xAnchorMbx = anchor;

            // setup links
            lnkQueryParams.Links.Add(0, 16, "http://graph.microsoft.io/en-us/docs/overview/query_parameters");
            lnkPaging.Links.Add(0, 6, "http://graph.microsoft.io/en-us/docs/overview/paging");
            lnkCallAPI.Links.Add(0, 21, "http://graph.microsoft.io/en-us/docs/overview/call_api");
            lnkErrors.Links.Add(0, 6, "http://graph.microsoft.io/en-us/docs/overview/errors");
            
            // create logger
            logger = new ClassLogger("restfuloutlook-graphexplorer.log");

            // init local auth result
            result = authResult;

            // populate the sample queries into the local dictionary
            PopulateComboBox();
        }

        public void PopulateComboBox()
        {
            // create a generic StartDateTime and EndDateTime for calls like CalendarView
            DateTimeOffset dtoStart = DateTimeOffset.Now;
            DateTimeOffset dtoEnd = dtoStart.AddMinutes(30);

            // add each sample into the dictionary, using the same name from the UI combobox
            dictionary.Add("OutlookMail-ListMessages", "me/messages");
            dictionary.Add("OutlookMail-ListMailFolders", "me/mailFolders");
            dictionary.Add("OutlookMail-SearchInbox", "me/messages/?$search=%22tailspin%20toys%22");
            dictionary.Add("OutlookMail-SearchToAndTop25", "me/messages?$search=%22to:" + xAnchorMbx + "%22&$top25");
            dictionary.Add("OutlookMail-GetImportanUnreadMessages", "me/messages/?$filter=importance%20eq%20%27high%27%20and%20isread%20eq%20false");
            dictionary.Add("OutlookMail-GetSenderSubjectOnly", "me/MailFolders/sentitems/messages/?$select=Sender,Subject");
            dictionary.Add("OutlookMail-SendNewMessage", "me/sendmail");
            dictionary.Add("OutlookMail-CreateDraftMessage", "me/messages");
            dictionary.Add("OutlookMail-CreateFolder", "me/MailFolders/Inbox/childFolders");
            dictionary.Add("OutlookCalendar-ListCalendars", "me/calendars");
            dictionary.Add("OutlookCalendar-CreateEvent", "me/events");
            dictionary.Add("OutlookCalendar-ListCalendarGroups", "me/calendarGroups");
            dictionary.Add("OutlookCalendar-ListCalendarView", "me/calendarView?startDateTime=" + dtoStart + "&endDateTime=" + dtoEnd);
            dictionary.Add("OutlookContacts-ListContacts", "me/contacts");
            dictionary.Add("OutlookContacts-CreateContact", "me/contacts");
            dictionary.Add("OutlookContacts-ListContactFolders", "me/contactFolders");
            dictionary.Add("OutlookGroups-ListGroups", "groups");
            dictionary.Add("OutlookGroups-ListMemberOf", "me/memberOf");
            dictionary.Add("OutlookNotifications-CreatePushSubscription", "me/subscriptions");
            dictionary.Add("Graph-Metadata", "$metadata");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // setup variables for response time
            DateTime responseReceived = new DateTime();
            DateTime requestStarted = new DateTime();

            try
            {
                Cursor = Cursors.WaitCursor;
                ClearResponseTree();

                // get the request url and request method
                string graphRequest = tbRequestUrl.Text;
                HttpMethod HttpRequestMethod;

                switch (cmbHttpMethod.Text)
                {
                    case "GET":
                        HttpRequestMethod = HttpMethod.Get;
                        break;
                    case "POST":
                        HttpRequestMethod = HttpMethod.Post;
                        break;
                    case "PUT":
                        HttpRequestMethod = HttpMethod.Put;
                        break;
                    case "HEAD":
                        HttpRequestMethod = HttpMethod.Head;
                        break;
                    case "OPTIONS":
                        HttpRequestMethod = HttpMethod.Options;
                        break;
                    default:
                        HttpRequestMethod = HttpMethod.Delete;
                        break;
                }

                // create the http request and add the access token in the header
                HttpRequestMessage request = new HttpRequestMessage(HttpRequestMethod, graphRequest);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", result.AccessToken);

                // check for diagnostics flag
                if (Properties.Settings.Default.OutlookDiagnostics == "On")
                {
                    AddRequestHeader("Prefer", "outlook.diagnostics");
                }

                // add headers to the request
                foreach (DataGridViewRow row in dgRequestHeaders.Rows)
                {
                    request.Headers.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }

                // check for a request body
                if (tbRequestBody.Text != "")
                {
                    request.Content = new StringContent(tbRequestBody.Text, System.Text.Encoding.UTF8, "application/json");
                }

                logger.Log("REQUEST HEADER:");
                logger.Log(request.Headers.ToString());
                logger.Log("REQUEST:");
                logger.Log(request.ToString());

                // get the current time for response time calculation
                requestStarted = DateTime.Now;

                // start processing the response
                HttpResponseMessage response = httpClient.SendAsync(request).Result;

                // get the current time again to figure out the response time
                responseReceived = DateTime.Now;
                
                // calculate the number of milliseconds that the request took to complete
                TimeSpan milliseconds = responseReceived.Subtract(requestStarted);
                logger.Log("RESPONSE TIME: " + milliseconds);

                // handle non-successful requests
                if (!response.IsSuccessStatusCode)
                {
                    string errorJsonContent = response.Content.ReadAsStringAsync().Result;

                    JObject jResult = JObject.Parse(errorJsonContent);

                    // check for odata error
                    if (jResult["odata.error"] != null)
                    {
                        throw new Exception((string)jResult["odata.error"]["message"]["value"]);
                    }

                    // check for null result
                    if (jResult[""] != null)
                    {
                        logger.Log("## null response ##");
                    }

                    // log non-odata errors
                    logger.Log("RESPONSE JSON CONTENT:");
                    logger.Log(jResult.ToString());

                    // display error details in the UI
                    TreeNode errorParent = TreeViewHelper.Json2Tree(jResult);
                    errorParent.Text = "Request failed.";
                    treeViewResult = errorParent.ToString();
                    tvw.Nodes.Add(errorParent);

                    // finally throw the exception to prevent further processing of the request
                    throw new WebException(response.StatusCode.ToString() + ": " + response.ReasonPhrase);
                }
                
                // process successful request                      
                string content = response.Content.ReadAsStringAsync().Result;

                logger.Log("RESPONSE HEADER:");
                logger.Log(response.Headers.ToString());
                logger.Log("RESPONSE:");

                if (response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.Created)
                {
                    // POST responses that are successful return 202 Accepted or 201 Created,
                    // there is no response body so let the user know it was successful
                    tvw.Nodes.Add(new TreeNode("Message created/sent succesfully."));
                    logger.Log("StatusCode = " + response.StatusCode.ToString());
                }
                else if (response.StatusCode == HttpStatusCode.OK)
                {
                    // GET responses should have a return type of xml or json
                    if (content[0] == '<')
                    {
                        // check for an xml response and populate the tree
                        // this is mainly for the metadata query
                        XmlDocument dom = new XmlDocument();
                        dom.LoadXml(content);

                        tvw.Nodes.Clear();
                        tvw.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                        TreeNode tNode = new TreeNode();
                        tNode = tvw.Nodes[0];

                        TreeViewHelper.AddNode(dom.DocumentElement, tNode);
                        treeViewResult = dom.ToString();
                        logger.Log(dom.ToString());
                    }
                    else
                    {
                        // if it isn't xml it should be json, populate the tree
                        JObject jResult = JObject.Parse(content);

                        if (jResult["odata.error"] != null)
                        {
                            throw new Exception((string)jResult["odata.error"]["message"]["value"]);
                        }

                        if (jResult[""] != null)
                        {

                            logger.Log("");
                        }

                        tvw.Nodes.Clear();
                        TreeNode parent = TreeViewHelper.Json2Tree(jResult);
                        parent.Text = "Root Object";
                        tvw.Nodes.Add(parent);
                        logger.Log(jResult.ToString());
                        treeViewResult = jResult.ToString();
                    }
                }
                else
                {
                    // log anything that is not an OK or Accepted response, but also not an error
                    logger.Log(response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                logger.Log("Exception: " + ex.Message);
            }
            finally
            {
                // clear the headers
                dgRequestHeaders.Rows.Clear();
                Cursor = Cursors.Default;
            }
        }

        private void cbRESTQuery_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string apiVersion = null;
                dgRequestHeaders.Rows.Clear();

                if (rdoV1.Checked)
                {
                    apiVersion = "v1.0/";
                }
                else if (rdoV2.Checked)
                {
                    apiVersion = "v2.0/";
                }
                else
                {
                    apiVersion = "beta/";
                }

                // lookup the selected value and populate the request information
                foreach (KeyValuePair<string, string> pair in dictionary)
                {
                    if (pair.Key == cbRESTQuery.SelectedItem.ToString())
                    {
                        tbRequestUrl.Text = Properties.Settings.Default.GraphEndpoint + apiVersion + pair.Value;

                        // check for examples where we need to create json for the POST body
                        if (pair.Key == "OutlookMail-SendNewMessage")
                        {
                            tbRequestBody.Text = JsonBody.CreateMessageJson();

                            // set headers and POST
                            cmbHttpMethod.Text = "POST";
                        }
                        else if (pair.Key == "OutlookMail-CreateDraftMessage")
                        {
                            tbRequestBody.Text = JsonBody.CreateDraftMessageJson();
                            cmbHttpMethod.Text = "POST";
                        }
                        else if (pair.Key == "OutlookCalendar-CreateEvent")
                        {
                            tbRequestBody.Text = JsonBody.CreateEventJson();
                            cmbHttpMethod.Text = "POST";
                        }
                        else if (pair.Key == "OutlookContacts-CreateContact")
                        {
                            tbRequestBody.Text = JsonBody.CreateContactJson();
                            cmbHttpMethod.Text = "POST";
                        }
                        else if (pair.Key == "OutlookNotifications-CreatePushSubscription")
                        {
                            Guid id = Guid.NewGuid();
                            notificationGuids.Add(id.ToString());
                            tbRequestBody.Text = JsonBody.CreateSubscriptionJson(id.ToString());
                            cmbHttpMethod.Text = "POST";
                            AddRequestHeader("Accept", "application/json");
                            AddRequestHeader("ContentType", "text/plain");
                        }
                        else if (pair.Key == "OutlookMail-CreateFolder")
                        {
                            tbRequestBody.Text = JsonBody.CreateMailFolder("MyTestFolder");
                            cmbHttpMethod.Text = "POST";
                        }
                        else
                        {
                            // use the same settings for all GET requests
                            AddRequestHeader("Accept", "application/json");
                            AddRequestHeader("x-AnchorMailbox", xAnchorMbx);
                            cmbHttpMethod.Text = "GET";
                            tbRequestBody.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                Properties.Settings.Default.NextLink = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvw.SelectedNode.Parent.Text != null)
                {
                    Clipboard.SetText(tvw.SelectedNode.Text);
                }
            }
            catch (NullReferenceException nre)
            {
                logger.Log("Copy Error: " + nre.Message);
            }
            catch (Exception ex)
            {
                logger.Log("Copy Error: " + ex.Message);
            }
        }

        private void GraphAPI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // cleanup
            logger.Dispose();
            httpClient.Dispose();
        }

        private void btnAddRequestHeader_Click(object sender, EventArgs e)
        {
            try
            {
                AddRequestHeaders aHdrForm = new AddRequestHeaders();
                aHdrForm.Owner = this;
                aHdrForm.ShowDialog(this);

                if (hdrName != null && hdrValue != null)
                {
                    AddRequestHeader(hdrName, hdrValue);
                }
            }
            catch (Exception ex)
            {
                logger.Log("Add Header Error:");
                logger.Log(ex.Message);
                logger.Log(ex.StackTrace);
            }
        }

        private void btnDeleteHeader_Click(object sender, EventArgs e)
        {
            try
            {
                int cellRow = dgRequestHeaders.CurrentCellAddress.Y;
                if (dgRequestHeaders.CurrentCell.ColumnIndex >= 0)
                {
                    dgRequestHeaders.Rows.RemoveAt(dgRequestHeaders.Rows[cellRow].Index);
                }
            }
            catch (NullReferenceException nre)
            {
                // if the header grid is empty, just return
                if (dgRequestHeaders.CurrentCellAddress.Y < 1)
                {
                    return;
                }
                else
                {
                    logger.Log("Delete Header Error:");
                    logger.Log(nre.Message);
                    logger.Log("StackTrace: " + nre.StackTrace);
                    logger.Log("Inner Exception: " + nre.InnerException);
                }

            }
            catch (Exception ex)
            {
                logger.Log("Delete Header Error: ");
                logger.Log(ex.Message);
                logger.Log("StackTrace: " + ex.StackTrace);
            }
        }

        private void lnkQueryParams_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void lnkPaging_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void lnkCallAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void lnkErrors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void btnGraphLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "restfuloutlook-graphexplorer.log");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open log file: " + ex.Message);
            }
        }

        private void btnClearResponse_Click(object sender, EventArgs e)
        {
            ClearResponseTree();
            Properties.Settings.Default.NextLink = "";
        }

        private void btnPageForward_Click(object sender, EventArgs e)
        {
            try
            {
                tbRequestUrl.Text = Properties.Settings.Default.NextLink;
                btnRunQuery.PerformClick();
            }
            catch (Exception ex)
            {
                logger.Log("Paging Error:");
                logger.Log(ex.Message);
                logger.Log(ex.StackTrace);
            }            
        }

        private void btnCopyResponse_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(treeViewResult);
            }
            catch (Exception ex)
            {
                logger.Log("Copy Error:" + ex.Message);
            }
        }

        public void ClearResponseTree()
        {
            tvw.Nodes.Clear();
        }

        public void AddRequestHeader(string name, string value)
        {
            int n = dgRequestHeaders.Rows.Add();
            dgRequestHeaders.Rows[n].Cells[0].Value = name;
            dgRequestHeaders.Rows[n].Cells[1].Value = value;
        }
    }
}
