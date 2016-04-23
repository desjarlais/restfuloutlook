using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    class Contact : OutlookItem
    {
        public string givenName { get; set; }
        public string surname { get; set; }
        public List<EmailAddress> emailAddresses { get; set; }
        public List<string> businessPhones { get; set; }
        public string assistantName { get; set; }
        public DateTimeOffset? birthday { get; set; }
        public List<PhysicalAddress> businessAddress { get; set; }
        public string businessHomePage { get; set; }
        public List<string> children { get; set; }
        public string companyName { get; set; }
        public string department { get; set; }
        public string displayName { get; set; }
        public string fileAs { get; set; }
        public string generation { get; set; }
        public List<PhysicalAddress> homeAddress { get; set; }
        public List<string> homePhones { get; set; }
        public List<string> imAddresses { get; set; }
        public string initials { get; set; }
        public string jobTitle { get; set; }
        public string manager { get; set; }
        public string middleName { get; set; }
        public string mobilePhone { get; set; }
        public string nickName { get; set; }
        public string officeLocation { get; set; }
        public List<PhysicalAddress> otherAddress { get; set; }
        public string parentFolderId { get; set; }
        public string personalNotes { get; set; }
        public string profession { get; set; }
        public string spouseName { get; set; }
        public string title { get; set; }
        public string yomiCompanyName { get; set; }
        public string yomiGivenName { get; set; }
        public string yomiSurname { get; set; }
    }
}
