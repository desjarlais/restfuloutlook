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
        public string hdrName, hdrValue, xAnchorMbx;
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
            DateTimeOffset dtoEnd = dtoStart.AddHours(1);          

            // add each sample into the dictionary, using the same name from the UI combobox
            dictionary.Add("OutlookMail-ListMessages", "me/messages");
            dictionary.Add("OutlookMail-ListMailFolders", "me/mailFolders");
            dictionary.Add("OutlookMail-SearchInbox", "me/messages/?$search=%22tailspin%20toys%22");
            dictionary.Add("OutlookMail-GetImportanUnreadMessages", "me/messages/?$filter=importance%20eq%20%27high%27%20and%20isread%20eq%20false");
            dictionary.Add("OutlookMail-GetSenderSubjectOnly", "me/MailFolders/sentitems/messages/?$select=Sender,Subject");
            dictionary.Add("OutlookMail-SendNewMessage", "me/sendmail");
            dictionary.Add("OutlookMail-CreateDraftMessage", "me/messages");
            dictionary.Add("OutlookCalendar-ListCalendars", "me/calendars");
            dictionary.Add("OutlookCalendar-CreateEvent", "me/events");
            dictionary.Add("OutlookCalendar-ListCalendarGroups", "me/calendarGroups");
            dictionary.Add("OutlookCalendar-ListCalendarView", "me/calendarView?startDateTime=" + dtoStart + "&endDateTime=" + dtoEnd);
            dictionary.Add("OutlookContacts-ListContacts", "me/contacts");
            dictionary.Add("OutlookContacts-CreateContact", "me/contacts");
            dictionary.Add("OutlookContacts-ListContactFolders", "me/contactFolders");
            dictionary.Add("OutlookGroups-ListGroups", "groups");
            dictionary.Add("OutlookGroups-ListMemberOf", "me/memberOf");
            dictionary.Add("Graph-Metadata", "$metadata");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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

                // create the http request
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

                // start processing the response
                HttpResponseMessage response = httpClient.SendAsync(request).Result;              

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
                    TreeNode errorParent = Json2Tree(jResult);
                    errorParent.Text = "Request failed.";
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
                    // there is no return value so let the user know it was successful
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

                        AddNode(dom.DocumentElement, tNode);
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
                        TreeNode parent = Json2Tree(jResult);
                        parent.Text = "Root Object";
                        tvw.Nodes.Add(parent);
                        logger.Log(jResult.ToString());
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
                logger.Log(ex.Message);
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

                foreach (KeyValuePair<string, string> pair in dictionary)
                {
                    if (pair.Key == cbRESTQuery.SelectedItem.ToString())
                    {
                        tbRequestUrl.Text = Properties.Settings.Default.GraphEndpoint + apiVersion + pair.Value;

                        // check for examples where we need to create json for the POST body
                        if (pair.Key == "OutlookMail-SendNewMessage")
                        {
                            CreateMessageJson();
                        }
                        else if (pair.Key == "OutlookMail-CreateDraftMessage")
                        {
                            CreateDraftMessageJson();
                        }
                        else if (pair.Key == "OutlookCalendar-CreateEvent")
                        {
                            CreateEventJson();
                        }
                        else if (pair.Key == "OutlookContacts-CreateContact")
                        {
                            CreateContactJson();
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
            }
        }

        #region Create Json Body functions
        private void CreateMessageJson()
        {
            // create the root object
            JsonHelpers.RootObject ro = new JsonHelpers.RootObject();
            ro.saveToSentItems = "True";
            
            // create message
            JsonHelpers.Item msg = new JsonHelpers.Item();
            
            // set the subject and importance
            msg.subject = "json test message";
            msg.importance = "Normal";

            // create and populate the body object
            JsonHelpers.Body msgBody = new JsonHelpers.Body();
            msgBody.contentType = "HTML";
            msgBody.content = "The <b>new</b> cafeteria is open!";
            msg.body = msgBody;
            
            // create and populate the recips object
            // first create a List of ToRecipient objects
            List<JsonHelpers.ToRecipient> recipList = new List<JsonHelpers.ToRecipient>();

            // now create an individual recip (ToRecipient) object
            // set the emailaddress info for the recip
            JsonHelpers.ToRecipient recip = new JsonHelpers.ToRecipient();
            JsonHelpers.EmailAddress msgEmail = new JsonHelpers.EmailAddress();
            msgEmail.address = "pavelb@a830edad9050849NDA1.onmicrosoft.com";
            msgEmail.name = "Pavel Bansky";

            // add the email address object to the recipient
            // then add the recip to the list
            recip.emailAddress = msgEmail;
            recipList.Add(recip);
            msg.toRecipients = recipList;

            // add the attachments
            List<JsonHelpers.Attachment> msgAttachments = new List<JsonHelpers.Attachment>();
            JsonHelpers.Attachment msgAttachment = new JsonHelpers.Attachment();
            msgAttachment.oDataType = "#Microsoft.OutlookServices.FileAttachment";
            msgAttachment.name = "menu.txt";
            msgAttachment.contentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk=";
            msgAttachments.Add(msgAttachment);
            msg.attachments = msgAttachments;

            // now the message object is complete and we can set it on the root object
            ro.message = msg;           
            
            // serialize the .net object -> json and display in the textbox
            string json = JsonConvert.SerializeObject(ro, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            tbRequestBody.Text = json;

            // set headers and POST
            cmbHttpMethod.Text = "POST";
        }

        private void CreateDraftMessageJson()
        {
            // create message
            JsonHelpers.Item msg = new JsonHelpers.Item();

            // set the subject and importance
            msg.subject = "json test message";
            msg.importance = "Normal";

            // create and populate the body object
            JsonHelpers.Body dftBody = new JsonHelpers.Body();
            dftBody.contentType = "HTML";
            dftBody.content = "The <b>new</b> cafeteria is open!";
            msg.body = dftBody;

            // create and populate the recips object
            // first create a List of ToRecipient objects
            List<JsonHelpers.ToRecipient> recipList = new List<JsonHelpers.ToRecipient>();

            // now create an individual recip (ToRecipient) object
            // set the emailaddress info for the recip
            JsonHelpers.ToRecipient recip = new JsonHelpers.ToRecipient();
            JsonHelpers.EmailAddress email = new JsonHelpers.EmailAddress();
            email.address = "pavelb@a830edad9050849NDA1.onmicrosoft.com";
            email.name = "Pavel Bansky";

            // add the email address object to the recipient
            // then add the recip to the list
            recip.emailAddress = email;
            recipList.Add(recip);
            msg.toRecipients = recipList;

            // add the attachments
            List<JsonHelpers.Attachment> msgAttachments = new List<JsonHelpers.Attachment>();
            JsonHelpers.Attachment msgAttachment = new JsonHelpers.Attachment();
            msgAttachment.oDataType = "#Microsoft.OutlookServices.FileAttachment";
            msgAttachment.name = "menu.txt";
            msgAttachment.contentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk=";
            msgAttachments.Add(msgAttachment);
            msg.attachments = msgAttachments;

            // serialize the .net object -> json and display in the textbox
            string json = JsonConvert.SerializeObject(msg, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            tbRequestBody.Text = json;

            // set headers and POST
            cmbHttpMethod.Text = "POST";
        }

        private void CreateEventJson()
        {
            // create the event object
            JsonHelpers.Event evt = new JsonHelpers.Event();
            evt.subject = "Discuss the Calendar REST API";

            // create the body object
            JsonHelpers.Body body = new JsonHelpers.Body();
            body.contentType = "HTML";
            body.content = "I think it will meet our requirements!";
            evt.body = body;

            // create the start time
            JsonHelpers.Start start = new JsonHelpers.Start();
            start.dateTime = "2016-02-02T18:00:00";
            start.timeZone = "Pacific Standard Time";
            evt.start = start;

            // create the end time
            JsonHelpers.End end = new JsonHelpers.End();
            end.dateTime = "2016-02-02T19:00:00";
            end.timeZone = "Pacific Standard Time";
            evt.end = end;

            // create the attendee list, attendee object and emailaddress object
            List<JsonHelpers.Attendee> attendeesList = new List<JsonHelpers.Attendee>();
            JsonHelpers.Attendee attendee = new JsonHelpers.Attendee();
            JsonHelpers.EmailAddress email = new JsonHelpers.EmailAddress();

            // set values for email and attendee
            email.address = "pavelb@a830edad9050849NDA1.onmicrosoft.com";
            email.name = "Pavel Bansky";
            attendee.emailAddress = email;
            attendee.type = "Required";

            // add the attendee to the list and set the event object
            attendeesList.Add(attendee);
            evt.attendees = attendeesList;

            // serialize the .net object -> json and display in the textbox
            string json = JsonConvert.SerializeObject(evt, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            tbRequestBody.Text = json;

            // set headers and POST
            cmbHttpMethod.Text = "POST";
            AddRequestHeader("Accept", "application/json");
        }

        public void CreateContactJson()
        {
            // create the contact object and set the root properties
            JsonHelpers.Contact contact = new JsonHelpers.Contact();
            contact.givenName = "Pavel";
            contact.surname = "Bansky";

            // create the email address list and emailaddress objects
            List<JsonHelpers.EmailAddress> emailAddresses = new List<JsonHelpers.EmailAddress>();
            JsonHelpers.EmailAddress email = new JsonHelpers.EmailAddress();

            // set the email object props and add it to the list
            email.address = "pavelb@a830edad9050849NDA1.onmicrosoft.com";
            email.name = "Pavel Bansky";
            emailAddresses.Add(email);

            // set the contact emailaddresses
            contact.emailAddresses = emailAddresses;

            // create a phone number list, add it to the object and set it for the contact object
            List<string> businessPhoneNumbers = new List<string>();
            businessPhoneNumbers.Add("+1 732 555 0102");
            contact.businessPhones = businessPhoneNumbers;

            // serialize the .net object -> json and display in the textbox
            string json = JsonConvert.SerializeObject(contact, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            tbRequestBody.Text = json;

            // set headers and POST
            cmbHttpMethod.Text = "POST";
            AddRequestHeader("Accept", "application/json");
        }
        #endregion

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
