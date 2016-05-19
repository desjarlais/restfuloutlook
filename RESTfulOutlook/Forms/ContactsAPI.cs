using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Graph;
using System.Collections.Generic;
using System.Linq;
using RESTfulOutlook.Utils;

namespace RESTfulOutlook.Forms
{
    public partial class ContactsAPI : Form
    {
        GraphServiceClient graphClient;
        public Dictionary<string, List<string>> dBusinessPhones;
        public Dictionary<string, List<string>> dHomePhones;
        public Dictionary<string, List<string>> dCategories;
        public Dictionary<string, List<string>> dChildren;
        public Dictionary<string, List<string>> dImAddresses;
        public Dictionary<string, List<string>> dEmailAddresses;
        public Dictionary<string, PhysicalAddress> dHomeAddress;
        public Dictionary<string, PhysicalAddress> dOtherAddress;
        public Dictionary<string, PhysicalAddress> dBusinessAddress;

        ClassLogger applogger = null;
        ClassLogger sdklogger = null;

        public ContactsAPI(ref GraphServiceClient client, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = client;
            applogger = appLogger;
            sdklogger = sdkLogger;

            dBusinessPhones = new Dictionary<string, List<string>>();
            dHomePhones = new Dictionary<string, List<string>>();
            dCategories = new Dictionary<string, List<string>>();
            dChildren = new Dictionary<string, List<string>>();
            dImAddresses = new Dictionary<string, List<string>>();
            dEmailAddresses = new Dictionary<string, List<string>>();
            dHomeAddress = new Dictionary<string, PhysicalAddress>();
            dOtherAddress = new Dictionary<string, PhysicalAddress>();
            dBusinessAddress = new Dictionary<string, PhysicalAddress>();

            #pragma warning disable 4014
            GetFoldersAsync();
            #pragma warning restore 4014
        }

        private async Task GetFoldersAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                sdklogger.Log("REQUEST");
                sdklogger.Log(graphClient.Me.ContactFolders.Request().GetHttpRequestMessage().ToString());
                sdklogger.Log(graphClient.Me.ContactFolders.Request().GetHttpRequestMessage().RequestUri.ToString());

                var contactFolders = await graphClient.Me.ContactFolders.Request()
                    .GetAsync();
                
                foreach (var contactFolder in contactFolders.CurrentPage)
                {
                    cmbFolders.Items.Add(contactFolder.DisplayName);
                    cmbFolders.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                sdklogger.Log("Contacts:GetFolderAsync Exception:");
                sdklogger.Log(ex.ToString());
                sdklogger.Log(ex.Message);
                sdklogger.Log(ex.StackTrace);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnGetContacts_Click(object sender, EventArgs e)
        {
            await GetContactsAsync();
        }

        private async Task GetContactsAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DgCleanup();

                int mLimit = (Int32)nudContacts.Value;

                sdklogger.Log("REQUEST");
                sdklogger.Log(graphClient.Me.Contacts.Request().GetHttpRequestMessage().ToString());
                sdklogger.Log(graphClient.Me.Contacts.Request().GetHttpRequestMessage().RequestUri.ToString());

                var contacts = await graphClient.Me.Contacts.Request()
                    .Top(mLimit)
                    .GetAsync();

                foreach (var contact in contacts.CurrentPage)
                {
                    // populate the new grid view rows
                    int n = dgContactsList.Rows.Add();
                    dgContactsList.Rows[n].Cells[(int)columns.GivenName].Value = contact.GivenName; 
                    dgContactsList.Rows[n].Cells[(int)columns.Surname].Value = contact.Surname; 
                    dgContactsList.Rows[n].Cells[(int)columns.CompanyName].Value = contact.CompanyName;
                    dgContactsList.Rows[n].Cells[(int)columns.BusinessHomePage].Value = contact.BusinessHomePage;
                    dgContactsList.Rows[n].Cells[(int)columns.AssistantName].Value = contact.AssistantName;
                    dgContactsList.Rows[n].Cells[(int)columns.Birthday].Value = contact.Birthday;
                    dgContactsList.Rows[n].Cells[(int)columns.ChangeKey].Value = contact.ChangeKey;
                    dgContactsList.Rows[n].Cells[(int)columns.Department].Value = contact.Department;
                    dgContactsList.Rows[n].Cells[(int)columns.CreatedDateTime].Value = contact.CreatedDateTime;
                    dgContactsList.Rows[n].Cells[(int)columns.LastModifiedDateTime].Value = contact.LastModifiedDateTime;
                    dgContactsList.Rows[n].Cells[(int)columns.DisplayName].Value = contact.DisplayName;
                    dgContactsList.Rows[n].Cells[(int)columns.FileAs].Value = contact.FileAs;
                    dgContactsList.Rows[n].Cells[(int)columns.Generation].Value = contact.Generation;
                    dgContactsList.Rows[n].Cells[(int)columns.Id].Value = contact.Id;
                    dgContactsList.Rows[n].Cells[(int)columns.Initials].Value = contact.Initials;
                    dgContactsList.Rows[n].Cells[(int)columns.JobTitle].Value = contact.JobTitle;
                    dgContactsList.Rows[n].Cells[(int)columns.Manager].Value = contact.Manager;
                    dgContactsList.Rows[n].Cells[(int)columns.MiddleName].Value = contact.MiddleName;
                    dgContactsList.Rows[n].Cells[(int)columns.NickName].Value = contact.NickName;
                    dgContactsList.Rows[n].Cells[(int)columns.OfficeLocation].Value = contact.OfficeLocation;
                    dgContactsList.Rows[n].Cells[(int)columns.ParentFolderId].Value = contact.ParentFolderId;
                    dgContactsList.Rows[n].Cells[(int)columns.Profession].Value = contact.Profession;
                    dgContactsList.Rows[n].Cells[(int)columns.PersonalNotes].Value = contact.PersonalNotes;
                    dgContactsList.Rows[n].Cells[(int)columns.SpouseName].Value = contact.SpouseName;
                    dgContactsList.Rows[n].Cells[(int)columns.Title].Value = contact.Title;
                    dgContactsList.Rows[n].Cells[(int)columns.YomiCompanyName].Value = contact.YomiCompanyName;
                    dgContactsList.Rows[n].Cells[(int)columns.YomiGivenName].Value = contact.YomiGivenName;
                    dgContactsList.Rows[n].Cells[(int)columns.YomiSurname].Value = contact.YomiSurname;

                    if (contact.BusinessPhones.Any())
                    {
                        List<string> tempBusinessPhones = new List<string>();
                        foreach (var item in contact.BusinessPhones)
                        {
                            tempBusinessPhones.Add(item);
                        }
                        dgContactsList.Rows[n].Cells[(int)columns.BusinessPhone].Value = "View Numbers";
                        dBusinessPhones.Add(contact.Id, tempBusinessPhones);
                    }

                    if (contact.Categories.Any())
                    {
                        List<string> tempCategories = new List<string>();
                        foreach (var item in contact.Categories)
                        {
                            tempCategories.Add(item);
                        }
                        dgContactsList.Rows[n].Cells[(int)columns.Categories].Value = "View Categories";
                        dCategories.Add(contact.Id, tempCategories);
                    }


                    if (contact.HomePhones.Any())
                    {
                        List<string> tempHomePhones = new List<string>();
                        foreach (var item in contact.HomePhones)
                        {
                            tempHomePhones.Add(item);
                        }
                        dgContactsList.Rows[n].Cells[(int)columns.HomePhone].Value = "View Numbers";
                        dHomePhones.Add(contact.Id, tempHomePhones);
                    }

                    if (contact.ImAddresses.Any())
                    {
                        List<string> tempImAddress = new List<string>();
                        foreach (var item in contact.ImAddresses)
                        {
                            tempImAddress.Add(item);
                        }
                        dgContactsList.Rows[n].Cells[(int)columns.ImAddresses].Value = "View Addresses";
                        dImAddresses.Add(contact.Id, tempImAddress);
                    }

                    if (contact.EmailAddresses.Any())
                    {
                        List<string> tempEmailAddress = new List<string>();
                        foreach (var item in contact.EmailAddresses)
                        {
                            tempEmailAddress.Add(item.Address);
                        }
                        dgContactsList.Rows[n].Cells[(int)columns.EmailAddress].Value = "View Addresses";
                        dEmailAddresses.Add(contact.Id, tempEmailAddress);
                    }

                    if (contact.HomeAddress.Street != null)
                    {
                        dHomeAddress.Add(contact.Id, contact.HomeAddress);
                        dgContactsList.Rows[n].Cells[(int)columns.HomeAddress].Value = "View Address";
                    }

                    if (contact.OtherAddress.Street != null)
                    {
                        dOtherAddress.Add(contact.Id, contact.OtherAddress);
                        dgContactsList.Rows[n].Cells[(int)columns.OtherAddress].Value = "View Address";
                    }

                    if (contact.BusinessAddress.Street != null)
                    {
                        dBusinessAddress.Add(contact.Id, contact.BusinessAddress);
                        dgContactsList.Rows[n].Cells[(int)columns.BusinessAddress].Value = "View Address";
                    }
                }
                
            }
            catch (ServiceException se)
            {
                sdklogger.Log("Contacts:GetContactAsync GraphServiceException:");
                sdklogger.Log(se.Message);
                return;
            }
            catch (ArgumentOutOfRangeException aor)
            {
                sdklogger.Log("Contacts:GetContactAsync ArgumentOutOfRangeException:");
                sdklogger.Log(aor.Message);
                return;
            }
            catch (AdalException ae)
            {
                sdklogger.Log("Contacts:GetContactAsync AdalException:");
                sdklogger.Log(ae.Message);
                return;
            }
            catch (Exception ex)
            {
                sdklogger.Log("Contacts:GetContactAsync Exception:");
                sdklogger.Log(ex.Message);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void DgCleanup()
        {
            // clear the dgview
            dgContactsList.Rows.Clear();

            // cleanup the associated dictionaries
            dBusinessPhones.Clear();
            dHomePhones.Clear();
            dCategories.Clear();
            dChildren.Clear();
            dImAddresses.Clear();
            dHomeAddress.Clear();
            dOtherAddress.Clear();
            dBusinessAddress.Clear();
            dEmailAddresses.Clear();
        }

        private void dgContactsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the selected items Id
                string mId = dgContactsList.Rows[e.RowIndex].Cells[(int)columns.Id].Value.ToString();

                // open the associated form based on the selected column
                if (e.ColumnIndex == (int)columns.HomeAddress)
                {
                    PhysicalAddress tHomeAddress = null;

                    foreach (KeyValuePair<string, PhysicalAddress> pair in dHomeAddress)
                    {
                        if (pair.Key == mId)
                        {
                            tHomeAddress = (PhysicalAddress)pair.Value;
                        }
                    }

                    PhysicalAddressForm mPhysicalAddress = new PhysicalAddressForm(tHomeAddress);
                    mPhysicalAddress.Owner = this;
                    mPhysicalAddress.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.BusinessAddress)
                {
                    PhysicalAddress tBusinessAddress = null;

                    foreach (KeyValuePair<string, PhysicalAddress> pair in dBusinessAddress)
                    {
                        if (pair.Key == mId)
                        {
                            tBusinessAddress = (PhysicalAddress)pair.Value;
                        }
                    }

                    PhysicalAddressForm mPhysicalAddress = new PhysicalAddressForm(tBusinessAddress);
                    mPhysicalAddress.Owner = this;
                    mPhysicalAddress.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.OtherAddress)
                {
                    PhysicalAddress tOtherAddress = null;

                    foreach (KeyValuePair<string, PhysicalAddress> pair in dOtherAddress)
                    {
                        if (pair.Key == mId)
                        {
                            tOtherAddress = (PhysicalAddress)pair.Value;
                        }
                    }

                    PhysicalAddressForm mPhysicalAddress = new PhysicalAddressForm(tOtherAddress);
                    mPhysicalAddress.Owner = this;
                    mPhysicalAddress.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.BusinessPhone)
                {
                    List<string> lBusinessPhones = null;
                    foreach (KeyValuePair<string, List<string>> pair in dBusinessPhones)
                    {
                        if (pair.Key == mId)
                        {
                            lBusinessPhones = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lBusinessPhones);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Categories)
                {
                    List<string> lCategories = null;
                    foreach (KeyValuePair<string, List<string>> pair in dCategories)
                    {
                        if (pair.Key == mId)
                        {
                            lCategories = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lCategories);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.HomePhone)
                {
                    List<string> lHomePhones = null;
                    foreach (KeyValuePair<string, List<string>> pair in dHomePhones)
                    {
                        if (pair.Key == mId)
                        {
                            lHomePhones = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lHomePhones);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.ImAddresses)
                {
                    List<string> lImAddress = null;
                    foreach (KeyValuePair<string, List<string>> pair in dImAddresses)
                    {
                        if (pair.Key == mId)
                        {
                            lImAddress = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lImAddress);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);                    
                }
                if (e.ColumnIndex == (int)columns.EmailAddress)
                {
                    List<string> lEmailAddresses = null;
                    foreach (KeyValuePair<string, List<string>> pair in dEmailAddresses)
                    {
                        if (pair.Key == mId)
                        {
                            lEmailAddresses = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lEmailAddresses);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);
                }
            }
            catch (NullReferenceException nre)
            {
                // likely a cell collection that is empty, just return
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log(ex.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgContactsList.CurrentCell.RowIndex;
                int y = dgContactsList.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgContactsList.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Copy Error:");
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log("Copy Error:");
                applogger.Log(ex.Message);
            }
        }

        private void dgContactsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgContactsList.CurrentCell = dgContactsList[e.ColumnIndex, e.RowIndex];
            }
        }

        // enum for the datagridview columns
        // any changes in the dg column, should only need to be made here
        enum columns
        {
            GivenName = 0,
            Surname = 1,
            CompanyName = 2,
            BusinessPhone = 3,
            BusinessAddress = 4,
            BusinessHomePage = 5,
            HomePhone = 6,
            HomeAddress = 7,
            EmailAddress = 8,
            AssistantName = 9,
            Birthday = 10,
            Categories = 11,
            ChangeKey = 12,
            Children = 13,
            Department = 14,
            CreatedDateTime = 15,
            LastModifiedDateTime = 16,
            DisplayName = 17,
            FileAs = 18,
            Generation = 19,
            Id = 20,
            ImAddresses = 21,
            Initials = 22,
            JobTitle = 23,
            Manager = 24,
            MiddleName = 25,
            Photo = 26,
            NickName = 27,
            OfficeLocation = 28,
            OtherAddress = 29,
            ParentFolderId = 30,
            PersonalNotes = 31,
            Profession = 32,
            SpouseName = 33,
            Title = 34,
            YomiCompanyName = 35,
            YomiGivenName = 36,
            YomiSurname = 37
        };

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            NewContactForm newContact = new NewContactForm(ref graphClient, ref applogger, ref sdklogger);
            newContact.Owner = this;
            newContact.ShowDialog(this);
        }
    }
}