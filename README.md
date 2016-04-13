# restfuloutlook

![image] (http://i.imgur.com/I8MIiAV.jpg)

## Introduction
This sample app is a .net/winform tool to test making REST calls for Outlook/Exchange data, using either the Graph client SDK or sending the calls directly to the Microsoft Graph endpoint, similar to the [MS Graph Explorer](https://graph.microsoft.io/en-us/graph-explorer#/).

## Prerequisites
This sample requires the following:  

  * [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads) 
  * Either a [Microsoft](http://www.outlook.com) or [Office 365 for business account](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).
 
##Register and configure the app
There are a couple ways to register the application.  First, you can manually register the application using the steps in the following article:

[Manually register your app with Azure AD so it can access Office 365 APIs](https://msdn.microsoft.com/en-us/office/office365/howto/add-common-consent-manually)

Another way to manually register is using the following steps, but these are for the v2 authentication model which are typically only if you need to use outlook.com accounts along with work and school accounts.

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

There is also another option.  I did include my registration details in the settings, but currently you can't use the tool as-is without registering the app in your tenant.  I think this is because I'm using ADAL.NET and there is no option to prompt for consent so logging in with an account outside where the app is registered is going to fail.

##Questions and comments

If you have any feedback about this project, use the issues section for any questions or suggestions located here: [Issues](https://github.com/desjarlais/restfuloutlook/issues)

##Using the tool/application
Click on the Login button and once you have successfully authenticated, the buttons in the app will light up.  From there you can start looking at the different API's and the data they return.  The SDK buttons use the Microsoft Graph SDK to return information from Exchange and the Graph API Explorer button is somewhat a clone of [MS Graph Explorer](https://graph.microsoft.io/en-us/graph-explorer#/) 

##Additional Links and Resources
Here are some additional helpful links if you are working with, or looking to work with the Microsoft Graph API and SDK's

- [Microsoft Graph overview](http://graph.microsoft.io)
- [Office 365 APIs platform overview](https://msdn.microsoft.com/office/office365/howto/platform-development-overview)
- [Office 365 API code samples and videos](https://msdn.microsoft.com/office/office365/howto/starter-projects-and-code-samples)
- [Office developer code samples](http://dev.office.com/code-samples)
- [Office dev center](http://dev.office.com/)
