using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using RESTfulOutlook.Utils;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics;
using Newtonsoft.Json;

namespace RESTfulOutlook.Forms
{
    public partial class GraphAPI : Form
    {
        AuthenticationResult result;
        private HttpClient httpClient = new HttpClient();
        Uri redirectUri = new Uri(Properties.Settings.Default.RedirectUri);
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public string hdrName, hdrValue;
        ClassLogger logger = null;

        public GraphAPI(AuthenticationResult authResult)
        {
            InitializeComponent();

            // setup links
            lnkQueryParams.Links.Add(0, 16, "http://graph.microsoft.io/en-us/docs/overview/query_parameters");
            lnkPaging.Links.Add(0, 6, "http://graph.microsoft.io/en-us/docs/overview/paging");
            lnkCallAPI.Links.Add(0, 21, "http://graph.microsoft.io/en-us/docs/overview/call_api");
            lnkErrors.Links.Add(0, 6, "http://graph.microsoft.io/en-us/docs/overview/errors");
            
            // create logger
            logger = new ClassLogger("restfuloutlook-graphexplorer.log");

            // init local auth result
            result = authResult;

            // populate the sample queries
            PopulateComboBox();
        }

        public void PopulateComboBox()
        {
            dictionary.Add("OutlookMail-ListMessages", "me/messages");
            dictionary.Add("OutlookMail-ListMailFolders", "me/mailFolders");
            dictionary.Add("OutlookMail-SearchInbox", "me/messages/?$search=%22tailspin%20toys%22");
            dictionary.Add("OutlookMail-GetImportanUnreadMessages", "me/messages/?$filter=importance%20eq%20%27high%27%20and%20isread%20eq%20false");
            dictionary.Add("OutlookMail-SendTestMessage", "me/sendmail");
            dictionary.Add("OutlookCalendar-ListCalendars", "me/calendars");
            dictionary.Add("OutlookCalendar-ListCalendarGroups", "me/calendarGroups");
            dictionary.Add("OutlookCalendar-ListCalendarView", "me/calendarView");
            dictionary.Add("OutlookContacts-ListContacts", "me/contacts");
            dictionary.Add("OutlookContacts-ListContactFolders", "me/contactFolders");
            dictionary.Add("OutlookGroups-ListGroups", "groups");
            dictionary.Add("OutlookGroups-ListMemberOf", "me/memberOf");
            dictionary.Add("Graph-Metadata", "$metadata");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatus.Text = "Running query...";
                ClearResponseTree();
                string graphRequest = tbRequest.Text;
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

                logger.Log("REQUEST HEADER");
                logger.Log(request.Headers.ToString());
                logger.Log("REQUEST");
                logger.Log(request.ToString());

                HttpResponseMessage response = httpClient.SendAsync(request).Result;              

                if (!response.IsSuccessStatusCode)
                    throw new WebException(response.StatusCode.ToString() + ": " + response.ReasonPhrase);

                string content = response.Content.ReadAsStringAsync().Result;

                logger.Log("RESPONSE HEADER");
                logger.Log(response.Headers.ToString());
                logger.Log("RESPONSE");
                logger.Log(content);

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

                    AddNode(dom.DocumentElement, tNode);
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
                    TreeNode parent = Json2Tree(jResult);
                    parent.Text = "Root Object";
                    tvw.Nodes.Add(parent);
                }
            }
            catch (Exception ex)
            {
                logger.Log("Error: " + ex.Message);
                logger.Log(ex.StackTrace);
            }
            finally
            {
                // clear the headers and update status label
                dgRequestHeaders.Rows.Clear();
                toolStripStatus.Text = "Ready";
            }
        }

        private void cbRESTQuery_SelectedValueChanged(object sender, EventArgs e)
        {
            string apiVersion = null;

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

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (pair.Key == cbRESTQuery.SelectedItem.ToString())
                {
                    tbRequest.Text = Properties.Settings.Default.GraphEndpoint + apiVersion + pair.Value;
                    
                    if (pair.Key == "OutlookMail-SendTestMessage")
                    {
                        // create new message helper
                        JsonHelpers.Message msg = new JsonHelpers.Message();

                        // add the subject
                        msg.Subject = "my test subject from json";

                        // create and populate the body object
                        JsonHelpers.Body body = new JsonHelpers.Body();
                        body.ContentType = "Text";
                        body.Content = "The new cafeteria is open.";
                        msg.Body = body;

                        // create and populate the recips object
                        // first create a list of recipients object
                        List<JsonHelpers.ToRecipient> recipList = new List<JsonHelpers.ToRecipient>();

                        // now create a recip (ToRecipient) object and set the emailaddress info
                        JsonHelpers.ToRecipient recip = new JsonHelpers.ToRecipient();
                        JsonHelpers.EmailAddress email = new JsonHelpers.EmailAddress();
                        email.Address = "brandes@desjarlaisdev.onmicrosoft.com";

                        // add the email address object to the recipient
                        // then add the recip to the list
                        recip.EmailAddress = email;
                        recipList.Add(recip);

                        // finally set the message recipients to the list
                        msg.ToRecipients = recipList;

                        string json = JsonConvert.SerializeObject(msg);
                        tbRequestBody.Text = json;

                        // setup headers and POST info
                        cmbHttpMethod.Text = "POST";
                        AddRequestHeader("Accept", "text/*, application/xml, application/json; odata.metadata=none");
                    }
                    else
                    {
                        AddRequestHeader("Accept", "application/json");
                    }
                }
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    string nodeName = null;
                    if (xNode.Attributes.Count > 0)
                    {
                        foreach (XmlAttribute xAtt in xNode.Attributes)
                        {
                            if (xAtt.Name == "Name")
                            {
                                nodeName = xAtt.Value + " : ";
                            }
                        }
                    }
                    
                    if (nodeName == null)
                    {
                        nodeName = xNode.Name;
                    }

                    inTreeNode.Nodes.Add(new TreeNode(nodeName));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private TreeNode Json2Tree(JObject obj)
        {
            // create the parent node
            TreeNode parent = new TreeNode();
            // loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                // change the display Content of the parent
                parent.Text = token.Key.ToString();
                // create the child node
                TreeNode child = new TreeNode();
                child.Text = token.Key.ToString();
                // check if the value is of type obj recall the method
                if (token.Value.Type.ToString() == "Object")
                {
                    // child.Text = token.Key.ToString();
                    // create a new JObject using the the Token.value
                    JObject o = (JObject)token.Value;
                    // check for empty entities
                    if (o.Count > 0)
                    {
                        // recall the method, make sure to keep track of parent to name the node correctly
                        child = Json2Tree(o);
                        child.Text = parent.Text;
                    }
                    
                    // add the child to the parentNode
                    parent.Nodes.Add(child);
                }
                // if type is of array
                else if (token.Value.Type.ToString() == "Array")
                {
                    int ix = -1;
                    // child.Text = token.Key.ToString();
                    // loop though the array
                    foreach (var itm in token.Value)
                    {
                        // check if value is an Array of objects
                        if (itm.Type.ToString() == "Object")
                        {
                            TreeNode objTN = new TreeNode();
                            // child.Text = token.Key.ToString();
                            // call back the method
                            ix++;

                            JObject o = (JObject)itm;
                            objTN = Json2Tree(o);
                            objTN.Text = token.Key.ToString() + "[" + ix + "]";
                            child.Nodes.Add(objTN);
                            // parent.Nodes.Add(child);
                        }
                        // regular array string, int, etc
                        else if (itm.Type.ToString() == "Array")
                        {
                            ix++;
                            TreeNode dataArray = new TreeNode();
                            foreach (var data in itm)
                            {
                                dataArray.Text = token.Key.ToString() + "[" + ix + "]";
                                dataArray.Nodes.Add(data.ToString());
                            }
                            child.Nodes.Add(dataArray);
                        }

                        else
                        {
                            child.Nodes.Add(itm.ToString());
                        }
                    }
                    parent.Nodes.Add(child);
                }
                else
                {
                    // if token.Value is not nested
                    // child.Text = token.Key.ToString();
                    // change the value into N/A if value == null or an empty string 
                    if (token.Value.ToString() == "")
                        child.Nodes.Add("N/A");
                    else
                        child.Nodes.Add(token.Value.ToString());
                    parent.Nodes.Add(child);
                }
            }
            return parent;
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
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void GraphAPI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // cleanup
            logger.Dispose();
        }

        private void btnAddRequestHeader_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.AddRequestHeaders aHdrForm = new Forms.AddRequestHeaders();
                aHdrForm.Owner = this;
                aHdrForm.ShowDialog(this);

                if (hdrName != null && hdrValue != null)
                {
                    AddRequestHeader(hdrName, hdrValue);
                }
            }
            catch (Exception ex)
            {
                logger.Log("Error: " + ex.Message);
                logger.Log("StackTrace: " + ex.StackTrace);
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
                    logger.Log("Error: " + nre.Message);
                    logger.Log("StackTrace: " + nre.StackTrace);
                    logger.Log("Inner Exception: " + nre.InnerException);
                }

            }
            catch (Exception ex)
            {
                logger.Log("Error: " + ex.Message);
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
