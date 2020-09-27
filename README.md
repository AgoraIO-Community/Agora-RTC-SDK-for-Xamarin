# [Agora.io](http://www.agora.io/en/) Xamarin Agora SDK for iOS/Android/MacOS

The Agora SDK allows you to effortlessly integrate call functionality into your app or website.

## Nugets packages for Xamarin

Android FULL: [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Full.Android)](https://www.nuget.org/packages/Xamarin.Agora.Full.Android/)

Android VOICE: [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Voice.Android)](https://www.nuget.org/packages/Xamarin.Agora.Voice.Android/)

iOS FULL: [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Full.iOS)](https://www.nuget.org/packages/Xamarin.Agora.Full.iOS/)

iOS VOICE: [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Voice.iOS)](https://www.nuget.org/packages/Xamarin.Agora.Voice.iOS/)

MacOS FULL: [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Full.Mac)](https://www.nuget.org/packages/Xamarin.Agora.Full.Mac/)

MacOS VOICE: [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Full.Mac)](https://www.nuget.org/packages/Xamarin.Agora.Voice.Mac/)

Xamarin.Forms FULL (discontinued): [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Full.Forms)](https://www.nuget.org/packages/Xamarin.Agora.Full.Forms/)

## Native SDKs

Native packages you can [download here](http://www.agora.io/en/blog/download/).

In this repo you will find binding projects for both versions - FULL and VOICE, difference is in support of video and size of lib

## Sample App

You can build and run OneToOne sample app available on [GitHub](https://github.com/DreamTeamMobile/Xamarin.Agora.Samples)

Step by step iOS tutorial is available on [GitHub](https://github.com/DreamTeamMobile/Xamarin.Agora.Samples/tree/master/Tutorial)
## Build

* [to update and compile Xamarin Agora SDK for Android](/Xamarin.Agora.Android)
* [to update and compile Xamarin Agora SDK for iOS](/Xamarin.Agora.iOS)
* [to update and compile Xamarin Agora SDK for MacOS](/Xamarin.Agora.Mac)
* [to update and compile Xamarin Agora SDK for Xamarin.Forms](/Xamarin.Agora.Forms)
* [pack Nugets](/Nugets)

## License
The MIT License (MIT).

P.S.
Known Issues:
- removed AgoraScreenCaptureParameters - linking failed in release mode to find this class in sdk, but sharpie see that class
- from 3.0 agora providing 2 builds for 1 version in iOS SDK "AgoraRtcKit.framework" and "ALL_ARCHITECTURE/AgoraRtcKit.framework" we using "AgoraRtcKit.framework", because if we bind "ALL_ARCHITECTURE/AgoraRtcKit.framework" - unable to submit built app to store, it raise issue that build contains code for simulator
