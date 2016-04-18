using Microsoft.Graph;
using RESTfulOutlook.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class NewContactForm : Form
    {
        GraphServiceClient graphClient;
        ClassLogger applogger = null;
        ClassLogger sdklogger = null;

        public NewContactForm(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;
        }

        public async Task CreateNewContact()
        {
            try
            {
                Microsoft.Graph.Contact contact = new Microsoft.Graph.Contact();
                contact.GivenName = tbFName.Text;
                contact.Surname = tbLName.Text;
                contact.MiddleName = tbMName.Text;
                contact.CompanyName = tbCompany.Text;
                
                List<EmailAddress> emailAddresses = new List<EmailAddress>();
                EmailAddress email = new EmailAddress();
                email.Address = tbEmailAddress1.Text;
                email.Name = tbFName.Text + " " + tbLName.Text;
                emailAddresses.Add(email);
                contact.EmailAddresses = emailAddresses;

                // log the request info
                sdklogger.Log(graphClient.Me.Contacts.Request().GetHttpRequestMessage().Headers.ToString());
                sdklogger.Log(graphClient.Me.Contacts.Request().GetHttpRequestMessage().RequestUri.ToString());

                // sent the new contact request
                await graphClient.Me.Contacts.Request().AddAsync(contact);
            }
            catch (Exception ex)
            {
                sdklogger.Log("NewContactSend Failed: " + ex.Message);
                sdklogger.Log(ex.Message);
            }
            finally
            {
                // close the form
                Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await CreateNewContact();
        }
    }
}
