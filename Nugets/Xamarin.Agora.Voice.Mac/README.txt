## Xamarin.Agora.Voice.Mac

Thank you for installing Xamarin.Agora.Voice.Mac, for details and issues reporting use our nuget sources repository:
https://github.com/AgoraIO-Community/Agora-RTC-SDK-for-Xamarin/wiki

### Samples of using Agora packages:

https://github.com/DreamTeamMobile/Xamarin.Agora.Samples

## Setup package

Before running the project, you need to set your signing and team, and add device permissions.

1. Set your signing and team

In Xcode, navigate to TARGETS > Project Name > General > Signing, and choose Automatically manage signing.
Read the prompts carefully, and click Enable Automatic.
After you successfully set your signing, choose a developer in Team.


2. Add device permissions

open the info.plist file. Add the following contents to add permissions for your device:

Key	                                   | Type   |	Value
Privacy - Microphone Usage Description | String |	The purpose for accessing the microphone, such as for a call or interactive live streaming.

Navigate to TARGETS > Project Name > Signing & Capabilities, and add the following permissions in App Sandbox and Hardened Runtime:
Capability       |	Category      |	Permission
App Sandbox      |	Network	      |
                 |                | Incoming Connections (Server)
                 |                | Outgoing Connections (Client)
App Sandbox	     |  Hardware	    | Audio Input
Hardened Runtime |Resource Access | Audio Input

Caution!
If you need to add a third-party plug-in or library (such as a third-party camera), and the signing of the third-party plug-in or library is different from your project, you need to navigate to Hardened Runtime > Runtime Exceptions, and check the Disable Library Validation option.
See more considerations in Preparing Your App for Distribution (https://developer.apple.com/documentation/xcode/preparing_your_app_for_distribution).

In Xcode 12.2 and later, to avoid compliation errors, you need to navigate to TARGETS > Project Name > Build Settings > Architectures, and set the Architectures property to x86_64 before the compilation.
