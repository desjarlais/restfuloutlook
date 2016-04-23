using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    public class JsonBody
    {
        /// <summary>
        /// create a json message of pre-defined values
        /// </summary>
        /// <returns>json formatted message body</returns>
        public static string CreateMessageJson()
        {
            // create the root object
            RootObject ro = new RootObject();
            ro.saveToSentItems = "True";
            
            // create message
            Message msg = new Message();

            // set the subject and importance
            msg.subject = "json test message";
            msg.importance = "Normal";

            // create an offset with the current time
            DateTimeOffset dto = new DateTimeOffset();
            dto = DateTime.Now;

            // set the time values for the message
            msg.createdDateTime = dto;
            msg.lastModifiedDateTime = dto;
            msg.receivedDateTime = dto;

            // create and populate the body object
            Body msgBody = new Body();
            msgBody.contentType = "HTML";
            msgBody.content = "The <b>new</b> cafeteria is open!";
            msg.body = msgBody;

            // create and populate the recips object
            // first create a List of ToRecipient objects
            List<Recipient> recipList = new List<Recipient>();

            // use the NewRecipient function to create an individual recip 
            // and set the emailaddress info
            Recipient recip1 = NewRecipient("pavelb@a830edad9050849NDA1.onmicrosoft.com", "Pavel Bansky");
            Recipient recip2 = NewRecipient("mavelb@a830edad9050849NDA1.onmicrosoft.com", "Mavel Bansky");

            // add the recips to the list
            recipList.Add(recip1);
            recipList.Add(recip2);
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

            return SerializeJson(ro);
        }

        /// <summary>
        /// serialize the .net object -> json
        /// </summary>
        /// <param name="value">.net object to be serialized</param>
        /// <returns>serialized string of formatted json</returns>
        private static string SerializeJson(object value)
        {
            string json = JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return json;
        }

        /// <summary>
        /// create a draft message using pre-defined values
        /// </summary>
        /// <returns>json formatted draft message body</returns>
        public static string CreateDraftMessageJson()
        {
            // create message
            Message msg = new Message();
            
            // set the subject and importance
            msg.subject = "json test message";
            msg.importance = "Normal";

            // create and populate the body object
            Body dftBody = new Body();
            dftBody.contentType = "HTML";
            dftBody.content = "The <b>new</b> cafeteria is open!";
            msg.body = dftBody;

            // create an offset with the current time
            DateTimeOffset dto = new DateTimeOffset();
            dto = DateTime.Now;

            // set the time values for the message
            msg.createdDateTime = dto;
            msg.lastModifiedDateTime = dto;
            msg.receivedDateTime = dto;

            // create and populate the recips object
            // first create a List of ToRecipient objects
            List<Recipient> recipList = new List<Recipient>();

            // use the NewRecipient function to create an individual recip 
            // and set the emailaddress info
            Recipient recip1 = NewRecipient("pavelb@a830edad9050849NDA1.onmicrosoft.com", "Pavel Bansky");
            Recipient recip2 = NewRecipient("mavelb@a830edad9050849NDA1.onmicrosoft.com", "Mavel Bansky");
            
            // add the recips to the list
            recipList.Add(recip1);
            recipList.Add(recip2);
            msg.toRecipients = recipList;

            // add the attachments
            List<Attachment> msgAttachments = new List<Attachment>();
            Attachment msgAttachment = new Attachment();
            msgAttachment.oDataType = "#Microsoft.OutlookServices.FileAttachment";
            msgAttachment.name = "menu.txt";
            msgAttachment.contentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk=";
            msgAttachments.Add(msgAttachment);
            msg.attachments = msgAttachments;
            
            return SerializeJson(msg);
        }
        
        /// <summary>
        /// this function does the work of creating the email address object
        /// and setting the necessary recipient email address values
        /// </summary>
        /// <param name="emailAddress">address property for Recipient</param>
        /// <param name="emailName">name property for the Recipient</param>
        /// <returns>Recipient object</returns>
        public static Recipient NewRecipient(string emailAddress, string emailName)
        {
            Recipient recip = new Recipient();
            EmailAddress email = new EmailAddress();
            email.address = emailAddress;
            email.name = emailName;
            recip.emailAddress = email;
            return recip;
        }

        /// <summary>
        /// create a meeting with pre-defined values
        /// </summary>
        /// <returns>json formatted string body</returns>
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
            
            // create an offset with the current time
            DateTimeOffset dto = new DateTimeOffset();
            dto = DateTime.Now;

            // create the start time
            DateTimeTimeZone start = new DateTimeTimeZone();
            start.dateTime = dto;
            start.timeZone = "Pacific Standard Time";
            evt.start = start;

            // create the end time
            DateTimeTimeZone end = new DateTimeTimeZone();
            end.dateTime = dto.AddMinutes(30);
            end.timeZone = "Pacific Standard Time";
            evt.end = end;

            // set the other time values
            evt.createdDateTime = dto;
            evt.lastModifiedDateTime = dto;
            evt.originalStart = dto;
            evt.reminderMinutesBeforeStart = 15;
            
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
            
            return SerializeJson(evt);
        }

        /// <summary>
        /// create a contact
        /// </summary>
        /// <returns>json body formatted as a string</returns>
        public static string CreateContactJson()
        {
            // create the contact object and set the root properties
            Contact contact = new Contact();
            contact.givenName = "Pavel";
            contact.surname = "Bansky";

            // create an offset with the current time
            DateTimeOffset dto = new DateTimeOffset();
            dto = DateTime.Now;

            // set the time values for the contact
            contact.birthday = dto;
            contact.createdDateTime = dto;
            contact.lastModifiedDateTime = dto;

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
            
            return SerializeJson(contact);
        }

        /// <summary>
        /// create a notification
        /// </summary>
        /// <param name="guid">unique id for the subscription</param>
        /// <returns>json body formatted as a string</returns>
        public static string CreateSubscriptionJson(string guid)
        {
            Notifications notif = new Notifications();
            notif.oDataType = "#Microsoft.OutlookServices.PushSubscription";
            notif.resource = "https://outlook.office.com/api/v2.0/me/events";
            notif.notificationURL = "https://appurlhere/api/send/myNotifyClient";
            notif.changeType = "Created";
            notif.clientState = guid;
            notif.expirationDateTime = DateTime.Now.AddMinutes(30);

            return SerializeJson(notif);
        }
    }
}
