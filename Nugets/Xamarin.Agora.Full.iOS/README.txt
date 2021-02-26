## Xamarin.Agora.Full.iOS

Thank you for installing Xamarin.Agora.Full.iOS, for details and issues reporting use our nuget sources repository:
https://github.com/AgoraIO-Community/Agora-RTC-SDK-for-Xamarin/wiki

Caution! this package is for running on a device only. If you want to run on Simulator - install
Xamarin.Agora.Full.iOS.Simulator

### Samples of using Agora packages:

https://github.com/DreamTeamMobile/Xamarin.Agora.Samples

## Setup package

open the info.plist file. Add the following contents to add permissions for your device:

Key	| Type |	Value
Privacy - Microphone Usage Description | String |	The purpose for accessing the microphone, such as for a call or interactive live streaming.
Privacy - Camera Usage Description |	String |	The purpose for accessing the camera, such as for a call or interactive live streaming.

Caution!
iOS 14.0 adds the Privacy - Local Network Usage Description permission. If you use a version of the SDK earlier than v3.1.2, you need to add this permission. See https://docs.agora.io/en/faq/local_network_privacy for details.
