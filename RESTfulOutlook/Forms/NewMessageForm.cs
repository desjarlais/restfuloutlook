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

        public NewMessageForm(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;
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

                List<Recipient> toRecipients = new List<Recipient>();
                Recipient recip = new Recipient();
                EmailAddress email = new EmailAddress();
                email.Address = tbToRecipients.Text;
                recip.EmailAddress = email;
                toRecipients.Add(recip);

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
    }
}
