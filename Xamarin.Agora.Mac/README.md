## Get native libs

Download native Full and Voice SDK from [https://www.agora.io/en/download/](https://www.agora.io/en/download/)

unpack and copy:

`Agora_Native_SDK_for_Mac_FULL/libs/ALL_ARCHITECTURE/AgoraRtcKit.framework/*` to `Xamarin.Agora.Mac/Xamarin.Agora.Full.Mac/AgoraRtcKit.framework/`

`Agora_Native_SDK_for_Mac_VOICE/libs/ALL_ARCHITECTURE/AgoraRtcKit.framework/*` to `Xamarin.Agora.Mac/Xamarin.Agora.Voice.Mac/AgoraRtcKit.framework/`

## Update/Install Sharpie

download latest [Sharpie](https://download.xamarin.com/objective-sharpie/ObjectiveSharpie.pkg) (or check instructions here https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/) 

## Update [ApiDefinitions & StructsAndEnums files](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/platform/apidefinitions-structsandenums)

### Generate binding files for AgoraRtcKit.framework

```
MacBook-Pro:AgoraRtcKit.framework user$ sharpie bind -output Binding -sdk macosx -scope Headers Headers/AgoraRtcChannel.h -c
...
...
Submitting usage data to Xamarin...
  usage data:
    CommandLine: -output binding --namespace=AgoraRtcChannel --sdk=macosx Headers/AgoraRtcChannel.h -v
    DocsWritten: 2
    ToolName: bind
    ExitCode: 0

  Submitted - thank you for helping to improve Objective Sharpie!

Done.
```
now you have 2 files in folder "binding" which content we will use in 3.2

### Update ApiDefinition.cs and StructsAndEnums.cs

Update [ApiDefinition.cs](ApiDefinition.cs) and [StructsAndEnums.cs](StructsAndEnums.cs) with content from generated files in previous 2 steps.

## Done, now you can build dll's
