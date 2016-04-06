# restfuloutlook

![image] (http://i.imgur.com/I8MIiAV.jpg)

## Introduction
This sample app is a .net/winform tool to test making REST calls for Outlook/Exchange data, using either the client SDK or sending the calls directly to the Office365 REST API, similar to the Graph Explorer 

## Prerequisites
This sample requires the following:  

  * [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads) 
  * Windows 10 ([development mode enabled](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx))
  * Either a [Microsoft](www.outlook.com) or [Office 365 for business account](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).
 
##Register and configure the app
1. Sign into the [App Registration Portal](https://apps.dev.microsoft.com/) using either your personal or work or school account.
2. Select **Add an app**.
3. Enter a name for the app, and select **Create application**.
	
	The registration page displays, listing the properties of your app.
 
4. Under **Platforms**, select **Add platform**.
5. Select **Mobile platform**.
6. Copy both the Client Id (App Id) and Redirect URI values to the clipboard. You'll need to enter these values into the sample app.

	The app id is a unique identifier for your app. The redirect URI is a unique URI provided by Windows 10 for each application to ensure that messages sent to that URI are only sent to that application. 

7. Select **Save**.


**Note**: I did include my registration details in the settings, so it might be possible to just use the tool without registering.  I would recommend going through the registration process however.

