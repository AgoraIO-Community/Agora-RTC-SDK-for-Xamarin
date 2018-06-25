## Get native libraries

Download native Full and Voice SDK from [https://www.agora.io/en/download/](https://www.agora.io/en/download/)

unpack and copy files:

`Agora_Native_SDK_for_iOS_FULL/libs/libcrypto.a` to `Xamarin.Agora.iOS/Xamarin.Agora.Full.iOS/libcrypto.a`

`Agora_Native_SDK_for_iOS_FULL/libs/AgoraRtcEngineKit.framework` to `Xamarin.Agora.iOS/Xamarin.Agora.Full.iOS/AgoraRtcEngineKit.framework`

`Agora_Native_SDK_for_iOS_FULL/libs/AgoraRtcCryptoLoader.framework` to `Xamarin.Agora.iOS/Xamarin.Agora.Full.iOS/AgoraRtcCryptoLoader.framework`

`Agora_Native_SDK_for_iOS_VOICE/libs/libcrypto.a` to `Xamarin.Agora.iOS/Xamarin.Agora.Voice.iOS/libcrypto.a`

`Agora_Native_SDK_for_iOS_VOICE/libs/AgoraAudioKit.framework` to `Xamarin.Agora.iOS/Xamarin.Agora.Voice.iOS/AgoraAudioKit.framework`

`Agora_Native_SDK_for_iOS_VOICE/libs/AgoraRtcCryptoLoader.framework` to `Xamarin.Agora.iOS/Xamarin.Agora.Voice.iOS/AgoraRtcCryptoLoader.framework`


## Update/Install Sharpie

download latest [Sharpie](https://download.xamarin.com/objective-sharpie/ObjectiveSharpie.pkg) (or check instructions here https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/) 

## Update [ApiDefinitions & StructsAndEnums files](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/platform/apidefinitions-structsandenums)

### Generate binding files for AgoraRtcEngineKit.framework

```
MacBook-Pro:AgoraRtcEngineKit.framework user$ sharpie bind -output Binding -sdk iphoneos -scope Headers Headers/AgoraRtcEngineKit.h -c
...
...
Submitting usage data to Xamarin...
  usage data:
    CommandLine: -output binding --namespace=AgoraRtcEngineKit --sdk=iphoneos Headers/AgoraRtcEngineKit.h -v
    DocsWritten: 2
    ToolName: bind
    ExitCode: 0

  Submitted - thank you for helping to improve Objective Sharpie!

Done.
```
now you have 2 files in folder "binding" which content we will use in 3.2

### Generate files for AgoraRtcCryptoLoader.framework
```
sharpie bind -output binding -sdk iphoneos -scope Headers Headers/AgoraRtcCryptoLoader.h -v
```

### Update ApiDefinition.cs and StructsAndEnums.cs

Update [ApiDefinition.cs](ApiDefinition.cs) and [StructsAndEnums.cs](StructsAndEnums.cs) with content from generated files in previous 2 steps.

## Done, now you can build dll's
