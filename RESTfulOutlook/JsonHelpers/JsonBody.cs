using Newtonsoft.Json;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    public class JsonBody
    {
        public static string CreateMessageJson()
        {
            // create the root object
            RootObject ro = new RootObject();
            ro.saveToSentItems = "True";

            // create message
            Item msg = new Item();

            // set the subject and importance
            msg.subject = "json test message";
            msg.importance = "Normal";

            // create and populate the body object
            Body msgBody = new Body();
            msgBody.contentType = "HTML";
            msgBody.content = "The <b>new</b> cafeteria is open!";
            msg.body = msgBody;

            // create and populate the recips object
            // first create a List of ToRecipient objects
            List<ToRecipient> recipList = new List<ToRecipient>();

            // now create an individual recip (ToRecipient) object
            // set the emailaddress info for the recip
            ToRecipient recip = new ToRecipient();
            EmailAddress msgEmail = new EmailAddress();
            msgEmail.address = "pavelb@a830edad9050849NDA1.onmicrosoft.com";
            msgEmail.name = "Pavel Bansky";

            // add the email address object to the recipient
            // then add the recip to the list
            recip.emailAddress = msgEmail;
            recipList.Add(recip);
            msg.toRecipients = recipList;

            // add the attachments
            List<Attachment> msgAttachments = new List<Attachment>();
            Attachment msgAttachment = new Attachment();
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

            return json;
        }

        public static string CreateDraftMessageJson()
        {
            // create message
            Item msg = new Item();

            // set the subject and importance
            msg.subject = "json test message";
            msg.importance = "Normal";

            // create and populate the body object
            Body dftBody = new Body();
            dftBody.contentType = "HTML";
            dftBody.content = "The <b>new</b> cafeteria is open!";
            msg.body = dftBody;

            // create and populate the recips object
            // first create a List of ToRecipient objects
            List<ToRecipient> recipList = new List<ToRecipient>();

            // now create an individual recip (ToRecipient) object
            // set the emailaddress info for the recip
            ToRecipient recip = new ToRecipient();
            EmailAddress email = new EmailAddress();
            email.address = "pavelb@a830edad9050849NDA1.onmicrosoft.com";
            email.name = "Pavel Bansky";

            // add the email address object to the recipient
            // then add the recip to the list
            recip.emailAddress = email;
            recipList.Add(recip);
            msg.toRecipients = recipList;

            // add the attachments
            List<Attachment> msgAttachments = new List<Attachment>();
            Attachment msgAttachment = new Attachment();
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

            return json;
        }

        public static string CreateEventJson()
        {
            // create the event object
            Event evt = new Event();
            evt.subject = "Discuss the Calendar REST API";

            // create the body object
            Body body = new Body();
            body.contentType = "HTML";
            body.content = "I think it will meet our requirements!";
            evt.body = body;

            // create the start time
            Start start = new Start();
            start.dateTime = "2016-02-02T18:00:00";
            start.timeZone = "Pacific Standard Time";
            evt.start = start;

            // create the end time
            End end = new End();
            end.dateTime = "2016-02-02T19:00:00";
            end.timeZone = "Pacific Standard Time";
            evt.end = end;

            // create the attendee list, attendee object and emailaddress object
            List<Attendee> attendeesList = new List<Attendee>();
            Attendee attendee = new Attendee();
            EmailAddress email = new EmailAddress();

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

            return json;
        }

        public static string CreateContactJson()
        {
            // create the contact object and set the root properties
            Contact contact = new Contact();
            contact.givenName = "Pavel";
            contact.surname = "Bansky";

            // create the email address list and emailaddress objects
            List<EmailAddress> emailAddresses = new List<EmailAddress>();
            EmailAddress email = new EmailAddress();

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

            return json;
        }

        public static string CreateSubscriptionJson(string guid)
        {
            Notifications notif = new Notifications();
            notif.oDataType = "#Microsoft.OutlookServices.PushSubscription";
            notif.Resource = "https://outlook.office.com/api/v2.0/me/events";
            notif.NotificationURL = "https://mywebhook.azurewebsites.net/api/send/myNotifyClient";
            notif.ChangeType = "Created";
            notif.ClientState = guid;

            string json = JsonConvert.SerializeObject(notif, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return json;
        }
    }
}
