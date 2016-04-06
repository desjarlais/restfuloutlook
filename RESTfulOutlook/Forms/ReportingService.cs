using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Security;
using System.Collections.Generic;

namespace RESTfulOutlook.Forms
{
    public partial class ReportingService : Form
    {        
        const String CRLF = "\r\n";
        const String indent = "  "; // two characters for the indent level when formatting Json replies.

        // Passwords are stored in SecureStrings, and handled as infrequently as possible
        private SecureString passwordEntered = new SecureString();
        private String userNameEntered = System.String.Empty;
        private String fqdnHost = System.String.Empty;
        private String fullRestURL = System.String.Empty;
        private String serverCookie = System.String.Empty;
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public ReportingService(string user, SecureString pass)
        {
            InitializeComponent();
            
            // set creds
            userNameEntered = user;
            passwordEntered = pass;

            PopulateComboBoxList();
            cmbReportList.Enabled = false;
            toolStripFormStatus.Text = "Ready";
        }

        public void PopulateComboBoxList()
        {
            // set the reports dictionary
            dictionary.Add("GroupActivityDaily", "$select=Date,GroupCreated,GroupDeleted,TenantGuid,TenantName&amp;$filter=Date gt datetime'2016-01-01T00:00:00'");
            dictionary.Add("GroupActivityWeekly", "$select=Date,GroupCreated,GroupDeleted,TenantGuid,TenantName&amp;$filter=Date gt datetime'2016-01-01T00:00:00'");
            dictionary.Add("GroupActivityMonthly", "$select=Date,GroupCreated,GroupDeleted,TenantGuid,TenantName&amp;$filter=Date gt datetime'2016-01-01T00:00:00'");
            dictionary.Add("GroupActivityYearly", "$select=Date,GroupCreated,GroupDeleted,TenantGuid,TenantName&amp;$filter=Date gt datetime'2012-01-01T00:00:00'");
            dictionary.Add("MailboxActivityDaily", "$select=Date,TenantName,TenantGuid,AccountCreated,AccountDeleted,TotalNumberOfActiveMailboxes");
            dictionary.Add("MailboxActivityWeekly", "$select=Date,TenantName,TenantGuid,AccountCreated,AccountDeleted,TotalNumberOfActiveMailboxes");
            dictionary.Add("MailboxActivityMonthly", "$select=Date,TenantName,TenantGuid,AccountCreated,AccountDeleted,TotalNumberOfActiveMailboxes");
            dictionary.Add("MailboxActivityYearly", "$select=Date,TenantName,TenantGuid,AccountCreated,AccountDeleted,TotalNumberOfActiveMailboxes");
            dictionary.Add("MailDetail", "$select=AggregateBy,Date,Direction,Domain,EndDate,EventType,Index,MessageId,MessageSize,MessageTraceId,Organization,RecipientAddress,SenderAddress,SenderIP,StartDate,Subject");
            dictionary.Add("MailDetailDlpPolicy", "$select=Action,Date,Direction,DlpPolicy,Domain,EndDate,EventType,Index,Justification,MessageId,MessageSize,MessageTraceId,Organization,RecipientAddress,SenderAddress,SensitiveInformationConfidence,SensitiveInformationCount,SensitiveInformationType,StartDate,Subject,TransportRule,UserAction");
            dictionary.Add("MailDetailMalware", "$select=Action,Date,Direction,Domain,EndDate,EventType,FileName,Index,MalwareName,MessageId,MessageSize,MessageTraceId,Organization,RecipientAddress,SenderAddress,StartDate,Subject");
            dictionary.Add("MailDetailSpam", "$select=Action,Date,Direction,Domain,EndDate,EventType,Index,MessageId,MessageSize,MessageTraceId,Organization,RecipientAddress,SenderAddress,StartDate,Subject");
            dictionary.Add("MailDetailTransportRule (inbound)", "$select=Action,Date,Direction,Domain,EndDate,EventType,Index,MessageId,MessageSize,MessageTraceId,Organization,RecipientAddress,SenderAddress,StartDate,Subject,TransportRule&amp;$filter=Direction eq 'Inbound'");
            dictionary.Add("MailDetailTransportRule (outbound)", "$select=Action,Date,Direction,Domain,EndDate,EventType,Index,MessageId,MessageSize,MessageTraceId,Organization,RecipientAddress,SenderAddress,StartDate,Subject,TransportRule&amp;$filter=Direction eq 'Outbound'");
            dictionary.Add("MailFilterList", "$select=Display,Domain,Organization,ParentTarget,ParentValue,SelectionTarget");
            dictionary.Add("MailTraffic (inbound)", "$select=Action,AggregateBy,Date,Direction,Domain,EndDate,EventType,Index,MessageCount,Organization,StartDate,SummarizeBy&amp;$filter=Direction eq 'Inbound'");
            dictionary.Add("MailTraffic (outbound)", "$select=Action,AggregateBy,Date,Direction,Domain,EndDate,EventType,Index,MessageCount,Organization,StartDate,SummarizeBy&amp;$filter=Direction eq 'Outbound'");
            dictionary.Add("MailTrafficPolicy (inbound)", "$select=Action,AggregateBy,Date,Direction,DlpPolicy,Domain,EndDate,EventType,Index,MessageCount,Organization,StartDate,SummarizeBy,TransportRule&amp;$filter=Direction eq 'Inbound'");
            dictionary.Add("MailTrafficPolicy (outbound)", "$select=Action,AggregateBy,Date,Direction,DlpPolicy,Domain,EndDate,EventType,Index,MessageCount,Organization,StartDate,SummarizeBy,TransportRule&amp;$filter=Direction eq 'Outbound'");
            dictionary.Add("MailTrafficSummary (TopMailSender)", "$select=C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,Category,DlpPolicy,Domain,EndDate,Index,StartDate,TransportRule&amp;$filter=Category eq 'TopMailSender'");
            dictionary.Add("MailTrafficSummary (TopMalware)", "$select=C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,Category,DlpPolicy,Domain,EndDate,Index,StartDate,TransportRule&amp;$filter=Category eq 'TopMalware'");
            dictionary.Add("MailTrafficTop (inbound)", "$select=AggregateBy,Date,Direction,Domain,EndDate,EventType,Index,MessageCount,Name,Organization,StartDate,SummarizeBy&amp;$filter=Direction eq 'Inbound'");
            dictionary.Add("MailTrafficTop (outbound)", "$select=AggregateBy,Date,Direction,Domain,EndDate,EventType,Index,MessageCount,Name,Organization,StartDate,SummarizeBy&amp;$filter=Direction eq 'Outbound'");
            dictionary.Add("MessageTrace", "$select=EndDate,FromIP,Index,MessageId,MessageTraceId,Organization,Received,RecipientAddress,SenderAddress,Size,StartDate,Status,Subject,ToIP");
            dictionary.Add("MessageTraceDetail", "$select=Action,Data,Date,Detail,EndDate,Event,Index,MessageId,MessageTraceId,Organization,RecipientAddress,SenderAddress,StartDate");
            dictionary.Add("StaleMailbox", "$select=ActiveMailboxes,Date,InactiveMailboxes31To60Days,InactiveMailboxes61To90Days,InactiveMailboxes91To1460Days,TenantGuid,TenantName");
            dictionary.Add("StaleMailboxDetail", "$select=Date,DaysInactive,LastLogin,TenantGuid,TenantName,UserName,WindowsLiveID");
        }

        private void btnCheckEndpoint_Click(object sender, System.EventArgs e)
        {
            toolStripFormStatus.Text = "Checking Endpoints...";
            // determine whether the endpoint name is actually in the form of a fully-qualified domain name
            fqdnHost = txtO365ReportingServiceEndpoint.Text;
            String pattern = @"(?=^.{1,254}$)(^(?:(?!\d+\.)[a-zA-Z0-9_\-]{1,63}\.?)+(?:[a-zA-Z]{1,})$)";
            Boolean isValidFqdn = Regex.IsMatch(fqdnHost, pattern);
            // 
            // next try to do a simple dns lookup of the host. some might do a UDP ping to ensure the
            // server is "alive". but, current security practices have servers not responding to pings,
            // to avoid Denial-of-Service attacks targeting the ping interface. So, check the DNS 
            // records instead.
            //
            IPHostEntry hostInfo = new IPHostEntry();
            // only attempt the DNS lookup if endpoint appears to be a valid domain name.
            if (isValidFqdn == true)
            {
                // First do a DNS Lookup to make sure the server actually exists. Some DNS errors come back
                // having an empty address list, and others throw and exception. Either error mode means  can't
                // use that as a web services endpoint
                try
                {
                    // this is the call to do the DNS lookup
                    hostInfo = Dns.GetHostEntry(fqdnHost);
                    if (hostInfo.AddressList == null)
                    {
                        toolStripFormStatus.Text = "DNS lookup failed. The DNS lookup returned no addresses; check the name";

                        return;
                    }
                }
                catch (Exception lookupException)
                {
                    toolStripFormStatus.Text = "DNS lookup failed" + "The DNS lookup returned no addresses; check the name" + "Exception = " + lookupException.Message;
                    return;
                }
                // Next check whether anything returns from the Reporting web service endpoint
                // using the credentials the user entered. This simple query retrieves the service definition
                // document. One benefit is that retrieving this document doesn't require the
                // Web service to access the various log databases, so it should give minimal load to 
                // the Web service. Use the returned document, if there is one, to set the available
                // reports.
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(string.Format("https://{0}/ecp/reportingwebservice/reporting.svc", fqdnHost));
                request.Method = "GET";
                // this header specifies the ODATA provider's minimum version. Use $select in later queries,
                // it needs to have at least ODATA (v1). There isn't any support for anything higher than 2.0, 
                // use that as a maximum also.
                request.Headers.Add("DataServiceVersion", "1.0");
                request.Headers.Add("MaxDataServiceVersion", "2.0");
                // Add RWS language header
                request.Headers.Add("Accept-Language", "EN-US");
                // Add RWS service version section header
                request.Headers.Add("X-RWS-Version", "2013-V1");
                // becuase of authentication reasons, avoid redirecting the HTTPS request, just out of caution.
                request.AllowAutoRedirect = false;
                
                // this is the "simple" way to get the credentials. Eventually if/when the Forefront reporting system comes 
                // online, we'll include how to authenticate using a token obtained from LiveID.
                request.Credentials = new NetworkCredential(userNameEntered, passwordEntered);

                HttpWebResponse response = null;
                // outer try block is for any random other exceptions, but also to ensure that no matter what happens, the
                // response object gets properly closed.
                try
                {
                    // inner try block is for the actual HTTPS call to the host
                    try
                    {
                        // this makes the probe-call to get the service description document
                        response = (HttpWebResponse)request.GetResponse();
                    }
                    // because this is just a probing request, don't need to worry about errors coming back via 
                    // this exception source. 
                    catch { }
                    // if the request succeeded, including loggin in, use the response with a proper StatusCode.
                    if (response != null)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            // if the request failed, indicate in the label and its tooltip what the error was. this part
                            // is for when a normal HTTP error occurs, like a 404 not found error. 
                            toolStripFormStatus.Text = "Attempt failed: " + response.StatusCode.ToString();
                            return;
                        }
                    }
                    else
                    {
                        toolStripFormStatus.Text = "Attempt failed: " + "Make sure username/password were correct.";
                        // this error condition is for when the HttpWebRequest fails so completely that there is no response
                        // object, and thus no HTTP error. This can happen if the user puts in a domain that exists, but that
                        // doesn't reply properly with the requested service document.
                        return;
                    }
                }
                finally
                {
                    // make sure the response, if it exists, gets properly closed.
                    if (response != null) response.Close();
                }

                toolStripFormStatus.Text = "Request successful";
                cmbReportList.Enabled = true;
                return;
            }
            else
            {
                // this error is reported when the domain name just isn't normal-looking
                // according to the regular expressions above.
                toolStripFormStatus.Text = "Invalid service endpoint.  The name does not appear to be a valid domain name";
            }
        }

        private void btnGenerateRESTURL_Click(object sender, System.EventArgs e)
        {
            toolStripFormStatus.Text = "Generating REST URL...";
            // Remove the line breaks between parameters, and replace them with the &
            // because this is an HTTP GET, not a POST.
            String requestArgs = Regex.Replace(txtRange.Text.Trim(), @"\r\n?|\n", "&");
            // depending on the setting of the radio-buttons, add the ODATA2 format specifier
            String formatArg = (rdoJSON.Checked == true ? "$format=Json" : "$format=Atom");

            // and now we create the URL out of the component pieces.
            UriBuilder ub = new UriBuilder("https", fqdnHost);
            ub.Path = string.Format("ecp/reportingwebservice/reporting.svc/{0}",
                    Regex.Replace(cmbReportList.SelectedItem.ToString(), @" \(.*", ""));
            ub.Query = (requestArgs == String.Empty ? formatArg : requestArgs + "&" + formatArg);
            fullRestURL = Uri.EscapeUriString(ub.Uri.ToString());
            // take the URL string and place it in the edit text box so it can be viewed.
            txtRESTUrl.Text = fullRestURL;
            toolStripFormStatus.Text = "Ready";
        }

        private void btnCopyRESTURL_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(txtRESTUrl.Text);
        }

        private void btnSendRequest_Click(object sender, System.EventArgs e)
        {
            toolStripFormStatus.Text = "Sending Request...";
            int charsRead = 0;
            // clear the currently displayed text 
            txtResults.Text = String.Empty;
            // create the two date-time variables for calculating the request duration
            DateTime responseReceived = new DateTime();
            DateTime requestStarted = new DateTime();
            // create the Web request container; REST uses HTTP(S) GET calls
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(fullRestURL);
            request.Method = "GET";
            // this header specifies the ODATA provider's minimum version. The intent is to use $select in later queries,
            // so it has to be least ODATA2. Use that same version as the maximum for when 3.0 is implemented.
            request.Headers.Add("DataServiceVersion", "2.0");
            request.Headers.Add("MaxDataServiceVersion", "2.0");
            // Add RWS language header
            request.Headers.Add("Accept-Language", "EN-US");
            // Add RWS service version section header
            request.Headers.Add("X-RWS-Version", "2013-V1");

            if (serverCookie != string.Empty)
            {
                request.Headers.Add("Cookie", serverCookie.ToString());
            }

            // becuase of authentication reasons, avoid redirecting the HTTPS request, just out of caution.
            request.AllowAutoRedirect = false;
            // this is the "simple" way to get the credentials. Eventually if/when the Forefront reporting system comes 
            // online, the application can be updated to authenticate using a token obtained from LiveID.
            request.Credentials = new NetworkCredential(userNameEntered, passwordEntered);
            // empty the response so that if it all falls through, it doesn't have the variable holding on to an old reference
            HttpWebResponse response = null;
            // outer try block is for any random other exceptions, but also to ensure that no matter what happens, the
            // response object gets properly closed.
            try
            {
                // create the variables that will hold the components of information to be displayed for the user
                int responseCode = 0; // the numeric response code
                String responseDesc = String.Empty; // descriptive HTTP response
                String requestHeadersBlock = String.Empty; // will hold formatted text of the headers sent
                String responseHeadersBlock = String.Empty; // the headers that came back
                String badDataReturned = String.Empty; // if the request fails, keep that bad data separate
                String requestDataReturned = String.Empty; // and where to put the returns when they succeed
                // inner try block is for the actual HTTPS call to the host
                try
                {
                    // get the current time, to calculate the time for processing
                    requestStarted = DateTime.Now;
                    // make the HTTP request to the server
                    response = (HttpWebResponse)request.GetResponse();
                    // if the call succeeds, some time later it will arrive here
                    responseReceived = DateTime.Now;
                    // record the response code and description
                    responseCode = (int)response.StatusCode;
                    responseDesc = response.StatusDescription;
                    // retrieve the headers SENT to the service and create the formatted block of text 
                    if (request.Headers.Count > 0)
                    {
                        for (int i = 0; i < request.Headers.Count; i++)
                        {
                            requestHeadersBlock += CRLF + request.Headers.GetKey(i) + ":" + request.Headers.GetValues(i)[0].ToString();
                        }
                    }
                    // retrieve the headers RECEIVED from the service and create the formatted block of text
                    if (response.Headers.Count > 0)
                    {
                        for (int i = 0; i < response.Headers.Count; i++)
                        {
                            responseHeadersBlock += CRLF + response.Headers.GetKey(i) + ":" + response.Headers.GetValues(i)[0].ToString();
                            // check to see if the header is the server's cookie; store it to return on the next call.
                            if ((response.Headers.GetKey(i) != null) && (response.Headers.GetKey(i) == "Set-Cookie"))
                            {
                                // set the cookie value to the header value
                                // note that normally you would verify the path of the cookie to make sure the code returns the right one. 
                                // however, for the Reporting web service, it always returns the same path, "/ecp/reportingwebservice",
                                // so it is reasonably safe to just return it, for this sample.
                                serverCookie = response.Headers.GetValues(i)[0].ToString();
                            }
                        }
                    }
                }
                // arrive here when something goes wrong with the request 
                catch (WebException excptn)
                {
                    // record when the response failed
                    responseReceived = DateTime.Now;
                    // get the response object passed in the exception
                    HttpWebResponse caughtResponse = (HttpWebResponse)excptn.Response;
                    // record the response HTTP code and description
                    responseCode = (int)caughtResponse.StatusCode;
                    responseDesc = caughtResponse.StatusDescription;
                    // retrieve the headers SENT to the service and create the formatted block of text
                    if (request.Headers.Count > 0)
                    {
                        for (int i = 0; i < request.Headers.Count; i++)
                        {
                            requestHeadersBlock += CRLF + request.Headers.GetKey(i) + ":" + request.Headers.GetValues(i)[0].ToString();
                        }
                    }
                    // retrieve the headers RECEIVED from the service and create the formatted block of text
                    // note that it only captures the FIRST value of that header, in case there are multiple values
                    if (caughtResponse.Headers.Count > 0)
                    {
                        for (int i = 0; i < caughtResponse.Headers.Count; i++)
                        {
                            responseHeadersBlock += CRLF + caughtResponse.Headers.GetKey(i) + ":" + caughtResponse.Headers.GetValues(i)[0].ToString();
                            // check to see if the header is the server's cookie, needed to return on the next call.
                            if ((caughtResponse.Headers.GetKey(i) != null) && (caughtResponse.Headers.GetKey(i) == "Set-Cookie"))
                            {
                                // set the cookie value to the header value
                                // note that normally you would verify the path of the cookie to make sure the code returns the right one. 
                                // however, for the Reporting web service, it always returns the same path, "/ecp/reportingwebservice",
                                // so it is reasonably safe to just return it, for this sample.
                                serverCookie = caughtResponse.Headers.GetValues(i)[0].ToString();
                            }
                        }
                    }
                    // now start the process of formatting the response body into something more human-readable
                    // force the character encoding so there are no mismatches
                    Encoding encode = Encoding.GetEncoding("utf-8");
                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(caughtResponse.GetResponseStream(), encode);
                    // create a "temporary" string building to add the text.
                    StringBuilder sb = new StringBuilder();
                    if (rdoAtom.Checked == true)
                    {
                        // Atom data is returned as an XML document, so create a new parser object
                        XmlDocument doc = new XmlDocument();
                        // and load the received stream into the document object
                        doc.LoadXml(readStream.ReadToEnd());
                        // create a base writer to receive the formatted XML contents
                        TextWriter tr = new StringWriter(sb);
                        // and then create an XML writer based on that textwriter
                        XmlTextWriter wr = new XmlTextWriter(tr);
                        // enable indenting of the output text
                        wr.Formatting = Formatting.Indented;
                        // then save the XML document into the XML writer
                        doc.Save(wr);
                        // extract out the formatted text that came with the HTTP error
                        badDataReturned = sb.ToString();
                        // and close the XML writer
                        wr.Close();
                    }
                    else
                    {
                        // although this looks simpler, the JavaScript Json data has to be formatted
                        // by brute-force effort, which has been encapsulated into the PrettyPrintJson routine.
                        // remember that the formatted Json data should NOT be considered syntactically
                        // perfect. the ONLY intent is to allow a human to make sense of it.
                        charsRead = prettyPrintJson(readStream, ref sb);
                        // retrieve the data for use in the output
                        badDataReturned = sb.ToString();
                    }
                    // and close the stream holding the response body
                    readStream.Close();
                }
                // calculate the number of milliseconds that the request took to complete
                TimeSpan milliseconds = responseReceived.Subtract(requestStarted);
                // process the normal response block
                if (response != null)
                {
                    Encoding encode = Encoding.GetEncoding("utf-8");
                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(response.GetResponseStream(), encode);
                    // create a "temporary" string building into which the code adds the text.
                    StringBuilder sb = new StringBuilder();
                    if (rdoAtom.Checked == true)
                    {
                        // Atom data is returned as an XML document, so create a new parser object
                        XmlDocument doc = new XmlDocument();
                        // and load the received stream into the document object
                        doc.LoadXml(readStream.ReadToEnd());
                        TextWriter tr = new StringWriter(sb);
                        // and then create an XML writer based on that textwriter
                        XmlTextWriter wr = new XmlTextWriter(tr);
                        // enable indenting of the output text
                        wr.Formatting = Formatting.Indented;
                        // then save the XML document into the XML writer
                        doc.Save(wr);
                        // extract out the formatted text that came with the HTTP error
                        requestDataReturned = sb.ToString();
                        // and close the XML writer
                        wr.Close();
                    }
                    else
                    {
                        // although this looks simpler, the JavaScript Json data has to be formatted
                        // by brute-force effort, which has been encapsulated into the PrettyPrintJson routine
                        // remember that the formatted Json data should NOT be considered syntactically
                        // perfect. the ONLY intent is to allow a human to make sense of it.
                        charsRead = prettyPrintJson(readStream, ref sb);
                        // retrieve the data for use in the output
                        requestDataReturned = sb.ToString();
                    }
                    // and close the stream holding the response body
                    readStream.Close();
                    //
                    // now format the results block for a successful request/response.
                    txtResults.Text =
                        "==========================================================" + CRLF +
                        "====               SUCCESSFUL                         ====" + CRLF +
                        "==========================================================" + CRLF +
                        "Type:              " + cmbReportList.SelectedItem.ToString() + CRLF +
                        "Request sent:      " + requestStarted.ToString() + CRLF +
                        "Response received: " + responseReceived.ToString() + CRLF +
                        "Response time:     " + milliseconds.TotalMilliseconds + " ms" + CRLF +
                        "User name:         " + userNameEntered + CRLF +
                        "HTTP response:     " + responseCode + " " + responseDesc + CRLF +
                        "==== REQUEST URL =========================================" + CRLF +
                        fullRestURL + CRLF +
                        "==== HEADERS SENT ========================================" +
                        (requestHeadersBlock == System.String.Empty ? "*** No headers ***" : requestHeadersBlock) + CRLF +
                        "==== HEADERS RCVD ========================================" +
                        (responseHeadersBlock == System.String.Empty ? "*** No headers ***" : responseHeadersBlock) + CRLF +
                        "==== RESULTS DOCUMENT ====================================" + CRLF +
                        requestDataReturned + CRLF +
                        "==========================================================" + CRLF +
                        "==========================================================" + CRLF + CRLF;
                }
                else
                {
                    // and do a similar formatting for the failed reqests
                    txtResults.Text =
                        "==========================================================" + CRLF +
                        "====               FAILURE                            ====" + CRLF +
                        "==========================================================" + CRLF +
                        "Type:              " + cmbReportList.SelectedItem.ToString() + CRLF +
                        "Request sent:      " + requestStarted.ToString() + CRLF +
                        "Response received: " + responseReceived.ToString() + CRLF +
                        "Response time:     " + milliseconds.TotalMilliseconds + " ms" + CRLF +
                        "User name:         " + userNameEntered + CRLF +
                        "HTTP response:     " + responseCode + " " + responseDesc + CRLF +
                        "==== REQUEST URL =========================================" + CRLF +
                        fullRestURL + CRLF +
                        "==== HEADERS SENT ========================================" +
                        (requestHeadersBlock == System.String.Empty ? "*** No headers ***" : requestHeadersBlock) + CRLF +
                        "==== HEADERS RCVD ========================================" +
                        (responseHeadersBlock == System.String.Empty ? "*** No headers ***" : responseHeadersBlock) + CRLF +
                        "==== RESULTS DOCUMENT ====================================" + CRLF +
                        badDataReturned + CRLF +
                        "==========================================================" + CRLF +
                        "==========================================================" + CRLF + CRLF;
                    toolStripFormStatus.Text = "Ready";
                    return;
                }
                toolStripFormStatus.Text = "Ready";
            }
            finally
            {
                // arrive here to ensure that the response stream is assured of being closed
                if (response != null) response.Close();
            }
        }

        private void btnCopyResults_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(txtResults.Text);
        }

        private void btnAppendToLog_Click(object sender, System.EventArgs e)
        {
            String myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String todaysDate = Regex.Replace(DateTime.Now.ToShortDateString(), @"/", @"-");
            String logFileName = myDocumentsPath + string.Format("\\O365RWSLog_{0}.txt", todaysDate);
            StreamWriter logFile = File.AppendText(logFileName);
            logFile.Write(txtResults.Text);
            logFile.Flush();
            logFile.Close();
        }

        private void cmbReportList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (pair.Key == cmbReportList.SelectedItem.ToString())
                {
                    txtRange.Text = pair.Value;
                }
            }
        }

        /// <summary>
        /// this utility routine takes the response steam contents that comes back from a JSON
        /// query and formats it so that the information will be reasonably readable. The data
        /// sent back is compacted with white space removed for faster transfer. But, in 
        /// this sample, it needs to be human-readable.
        /// 
        /// 
        /// IMPORTANT: the text data produced should NOT be considered "correct", in that
        /// commas, {,[,], and }  embedded in non-structural portions will be handled as
        /// if they WERE structural. So it will be human-readable, but not guaranteed to 
        /// be syntactically correct. Do NOT use the output as actual Javascript code!
        /// 
        /// 
        /// </summary>
        /// <param name="sourceStream">the stream containing the information from the service</param>
        /// <param name="destString">the string that will contain the formatted material</param>
        /// <returns></returns>
        private int prettyPrintJson(StreamReader sourceStream, ref StringBuilder destString)
        {
            String tmpData = sourceStream.ReadToEnd();
            int indentLevel = 0;
            int charsRead = 0;
            char ch;
            for (int j = 0; j < tmpData.Length; j++)
            {
                ch = tmpData[j];
                charsRead++;
                switch (ch)
                {
                    case '{':
                    case '[':
                        {
                            // to open a block or array, add a line, indent, place the character, 
                            // then add another line and increment the indentation level.
                            destString.Append("\r\n");
                            indentLevel++;
                            for (int i = 0; i < indentLevel; i++)
                            {
                                destString.Append(indent);
                            }
                            destString.Append(ch);
                            destString.Append("\r\n");
                            indentLevel++;
                            for (int i = 0; i < indentLevel; i++)
                            {
                                destString.Append(indent);
                            }
                            break;
                        }
                    case ',':
                        {
                            // for a comma, break the line and indent to get there.
                            // yes, this could mess with string contents. But really, you're 
                            // not supposed to use this json data in an application. Normally you'd
                            // use the information as returned from the service.
                            //
                            // THIS part is what causes the likelihood of the Json data being corrupted,
                            // because it doesn't take into account that when a comma occurs inside a string
                            // you're NOT supposed to break the line and effectively add whitespace.
                            //
                            destString.Append(ch);
                            destString.Append("\r\n");
                            for (int i = 0; i < indentLevel; i++)
                            {
                                destString.Append(indent);
                            }
                            break;
                        }
                    case ']':
                    case '}':
                        {
                            // To close a block or array, break the line, decrement the indent
                            // and add the closing character, and then break the line again and decrement
                            // the indent level
                            destString.Append("\r\n");
                            indentLevel--;
                            for (int i = 0; i < indentLevel; i++)
                            {
                                destString.Append(indent);
                            }
                            destString.Append(ch);
                            if (tmpData[(j < tmpData.Length - 1 ? j + 1 : j)] == ',')
                            {
                                j++;
                                charsRead++;
                                destString.Append(',');
                            }
                            if (j < tmpData.Length)
                            {
                                destString.Append("\r\n");
                                indentLevel--;
                                for (int i = 0; i < indentLevel; i++)
                                {
                                    destString.Append(indent);
                                }
                            }
                            break;
                        }

                    default:
                        {
                            // if it's not one of those special characters, just pass it through.
                            destString.Append(ch);
                            break;
                        }
                }
            }
            return charsRead;
        }

        private void btnEditRESTURL_Click(object sender, EventArgs e)
        {
            txtRESTUrl.ReadOnly = false;
        }
    }
}
