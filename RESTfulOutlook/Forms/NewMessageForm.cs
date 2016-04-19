using Microsoft.Graph;
using RESTfulOutlook.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class NewMessageForm : Form
    {
        GraphServiceClient graphClient;
        ClassLogger applogger = null;
        ClassLogger sdklogger = null;
        List<Recipient> toRecipients;

        public NewMessageForm(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;
            toRecipients = new List<Recipient>();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            CreateNewMessage();
        }

        public void CreateNewMessage()
        {
            try
            {
                ItemBody body = new ItemBody();
                body.Content = tbBody.Text;
                body.ContentType = BodyType.Html;

                // split out the different email addresses and add to collection
                char[] delim = { ';' };
                string[] smtpArray = tbToRecipients.Text.Split(delim);
                foreach (var smtp in smtpArray)
                {
                    AddRecipToCollection(smtp);
                }

                Microsoft.Graph.Message msg = new Microsoft.Graph.Message();
                msg.Subject = tbSubject.Text;
                msg.Body = body;
                msg.ToRecipients = toRecipients;

                // log the request info
                sdklogger.Log(graphClient.Me.SendMail(msg, true).Request().GetHttpRequestMessage().Headers.ToString());
                sdklogger.Log(graphClient.Me.SendMail(msg, true).Request().GetHttpRequestMessage().RequestUri.ToString());

                // send the new message
                graphClient.Me.SendMail(msg, true).Request().PostAsync();
            }
            catch (Exception ex)
            {
                sdklogger.Log("NewMessageSend Failed: " + ex.Message);
                sdklogger.Log(ex.Message);
            }
            finally
            {
                // close the form
                Close();
            }
        }

        /// <summary>
        /// This function creates a new recip and emailaddress object,
        /// then adds the recip to the collection
        /// </summary>
        /// <param name="email">smtp address for the recipient</param>
        public void AddRecipToCollection(string email)
        {
            Recipient recip = new Recipient();
            EmailAddress recipAddress = new EmailAddress();
            recipAddress.Address = email;
            recip.EmailAddress = recipAddress;
            toRecipients.Add(recip);
        }
    }
}
