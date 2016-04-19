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
        List<EmailAddress> emailAddresses;
        List<string> businessPhones;
        List<string> homePhones;

        public NewContactForm(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;
            emailAddresses = new List<EmailAddress>();
            businessPhones = new List<string>();
            homePhones = new List<string>();
        }

        public async Task CreateNewContact()
        {
            try
            {
                // create contact and get names
                Microsoft.Graph.Contact contact = new Microsoft.Graph.Contact();
                contact.GivenName = tbFName.Text;
                contact.Surname = tbLName.Text;
                contact.MiddleName = tbMName.Text;
                
                // check for email addresses
                if (tbEmailAddress1.Text != "")
                {
                    AddEmailAddressToCollection(tbEmailAddress1.Text);
                }

                if (tbEmailAddress1.Text != "")
                {
                    AddEmailAddressToCollection(tbEmailAddress2.Text);
                }

                if (tbEmailAddress1.Text != "")
                {
                    AddEmailAddressToCollection(tbEmailAddress3.Text);
                }
                
                // set the addresses for the contact         
                contact.EmailAddresses = emailAddresses;

                // get phone numbers
                contact.MobilePhone = tbMobilePhone.Text;
                businessPhones.Add(tbBusinessPhone.Text);
                homePhones.Add(tbHomePhone.Text);
                contact.BusinessPhones = businessPhones;
                contact.HomePhones = homePhones;

                // get company info
                contact.JobTitle = tbTitle.Text;
                contact.CompanyName = tbCompany.Text;
                contact.FileAs = tbFileAs.Text;

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

        /// <summary>
        /// create an emailaddress and populate the info
        /// </summary>
        /// <param name="email">smtp of the recipient</param>
        /// <returns>Graph EmailAddress object</returns>
        public EmailAddress AddEmailAddressToCollection(string email)
        {
            EmailAddress emailAddress = new EmailAddress();
            emailAddress.Address = tbEmailAddress1.Text;
            emailAddress.Name = tbFName.Text + " " + tbLName.Text;
            emailAddresses.Add(emailAddress);
            return emailAddress;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await CreateNewContact();
        }
    }
}
