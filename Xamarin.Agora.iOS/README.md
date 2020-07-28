## Get native libs

Download native Full and Voice SDK from [https://www.agora.io/en/download/](https://www.agora.io/en/download/)

unpack and copy files:

`Agora_Native_SDK_for_iOS_FULL/libs/ALL_ARCHITECTURE/AgoraRtcKit.framework/*` to `Xamarin.Agora.iOS/Xamarin.Agora.Full.iOS/AgoraRtcKit.framework/`

`Agora_Native_SDK_for_iOS_FULL/libs/ALL_ARCHITECTURE/AgoraRtcCryptoLoader.framework/*` to `Xamarin.Agora.iOS/Xamarin.Agora.Full.iOS/AgoraRtcCryptoLoader.framework/`

`Agora_Native_SDK_for_iOS_VOICE/libs/ALL_ARCHITECTURE/AgoraRtcKit.framework/*` to `Xamarin.Agora.iOS/Xamarin.Agora.Voice.iOS/AgoraRtcKit.framework/`

`Agora_Native_SDK_for_iOS_VOICE/libs/ALL_ARCHITECTURE/AgoraRtcCryptoLoader.framework/*` to `Xamarin.Agora.iOS/Xamarin.Agora.Voice.iOS/AgoraRtcCryptoLoader.framework/`


## Update/Install Sharpie

download latest [Sharpie](https://download.xamarin.com/objective-sharpie/ObjectiveSharpie.pkg) (or check instructions here https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/) 

## Update [ApiDefinitions & StructsAndEnums files](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/platform/apidefinitions-structsandenums)

### Generate binding files for AgoraRtcKit.framework

```
MacBook-Pro:AgoraRtcKit.framework user$ sharpie bind -output Binding -sdk iphoneos -scope Headers Headers/AgoraRtcChannel.h -c
...
...
Submitting usage data to Xamarin...
  usage data:
    CommandLine: -output binding --namespace=AgoraRtcChannel --sdk=iphoneos Headers/AgoraRtcChannel.h -v
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
