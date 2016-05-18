# RESTfulOutlook

![image] (http://i.imgur.com/I8MIiAV.jpg)

## Introduction
This sample app is a .net/winform tool to test making REST calls for Outlook/Exchange data, using either the [Microsoft Graph SDK](https://www.nuget.org/packages/Microsoft.Graph) or sending the calls directly to the Microsoft Graph endpoint, similar to the [MS Graph Explorer](https://graph.microsoft.io/en-us/graph-explorer#/).

## Prerequisites
This sample requires the following:  

  * [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads) 
  * Either a [Microsoft](http://www.outlook.com) or [Office 365 for business account](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).
 
##Register and configure the app
You can use one of the following two ways to register and configure the app to work against the Microsoft Graph endpoint.

First, you can use the [Microsoft Application Registration Portal](https://apps.dev.microsoft.com/).  Follow these steps to register using this model.

1. Sign into the [App Registration Portal](https://apps.dev.microsoft.com/) using either your personal or work or school account.
2. Select **Add an app**.
3. Enter a name for the app, and select **Create application**.
	
	The registration page displays, listing the properties of your app.
 
4. Under **Platforms**, select **Add platform**.
5. Select **Mobile platform**.
6. Copy both the Client Id (App Id) and Redirect URI values to the clipboard. You'll need to enter these values into the sample app.

	The app id is a unique identifier for your app. The redirect URI is a unique URI provided by Windows 10 for each application to ensure that messages sent to that URI are only sent to that application. 

7. Select **Save**.
8. Open the restfuloutlook app and click on Settings
9. Check the box for Edit Registration and populate the clientid and uri
10. Click on **Save**.

Second, you can use [Microsoft Azure Active Directory](https://manage.windowsazure.com/).  You can use the following steps to register with this model.

1. No matter what you use to configure your app, you will need to have an Office 365 Developer account and register your app with it. To sign up for an Office 365 developer account:

  * Visit [dev.office.com/devprogram](http://dev.office.com/devprogram) or go directly to the [profile creation page](https://profile.microsoft.com/RegSysProfileCenter/wizardnp.aspx?wizid=14b845d0-938c-45af-b061-f798fbb4d170&lcid=1033) and create a profile.

  * Follow the link in the confirmation email and create an Office 365 developer account.

  * For detailed instructions on signing up for a developer account go [here](https://msdn.microsoft.com/en-us/library/office/fp179924.aspx#o365_signup).

2. Once you have created an Office 365 Dev Account, go to [graph.microsoft.io](http://graph.microsoft.io/en-us/) to register your app and click **App Registration** then click **Office 365 App Registration Tool** or you can go directly to the registration page [dev.office.com/app-registration](http://dev.office.com/app-registration).

  ![Get started](/img/ms-graph-get-started.jpg) 

  ![Next step](/img/ms-graph-get-started-2.jpg)

3. Give your app a name and select **Native App** in the **App type** line. Then pick a Redirect URI, the preferred naming convention is: "your Office 365 domain + a unique name for your app", but it is not required, it must however, be formatted as a URI and be unique. For example, I named my app https://greencricketcreations.onmicrosoft.com/MyCalendarApp. The Redirect URI isn't a real website; it is more of a unique identifier for your app. Once you have entered a name and Redirect URI set the permissions. The necessary permissions are:

  * Read user profiles
  * Read user contacts
  * Read and write user calendars
  * Read user calendars
  * Send mail as user
  * Read and write user mail

4. Once you have filled out the form, click **Register App**.

  ![Register App](/img/ms-graph-get-started-3.jpg)

5. When your registration is complete, you will receive a Client ID. Make note of the Client ID and Redirect URI, you will need them to configure your app.

6. If you need more control of the registration options, you can follow these [detailed instructions](https://github.com/jasonjoh/office365-azure-guides/blob/master/RegisterAnAppInAzure.md) to register your app in Azure. Note that these instructions use the Azure classic portal. You can access the [Azure classic portal here](https://manage.windowsazure.com/).

##Questions and comments
If you have any feedback about this project, use the issues section for any questions or suggestions located here: [Issues](https://github.com/desjarlais/restfuloutlook/issues)

##Using the restful tool / application
Click on the Login button and once you have successfully authenticated, the buttons in the app will light up.  From there you can start looking at the different API's and the data they return.  The SDK buttons use the Microsoft Graph SDK to return information from Exchange and the Graph API Explorer button is somewhat a clone of [MS Graph Explorer](https://graph.microsoft.io/en-us/graph-explorer#/) 

##Additional Links and Resources
Here are some additional helpful links if you are working with, or looking to work with the Microsoft Graph API and SDK's:

- [Microsoft Graph overview](http://graph.microsoft.io)
- [Office 365 APIs platform overview](https://msdn.microsoft.com/office/office365/howto/platform-development-overview)
- [Office 365 API code samples and videos](https://msdn.microsoft.com/office/office365/howto/starter-projects-and-code-samples)
- [Office developer code samples](http://dev.office.com/code-samples)
- [Office dev center](http://dev.office.com/)

Here are some sandboxes that you can use to test out the Outlook and Graph API's:
- [Outlook Endpoint Sandbox](https://oauthplay.azurewebsites.net/)
- [Graph Explorer](https://graph.microsoft.io/en-us/graph-explorer#)
- [Getting Started with Office365 API's Sandbox](http://dev.office.com/getting-started/office365apis)
