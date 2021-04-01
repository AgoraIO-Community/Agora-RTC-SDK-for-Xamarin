## Get native libs

Download native Full and Voice SDK from [https://www.agora.io/en/download/](https://www.agora.io/en/download/)

unpack and copy:

`Agora_Native_SDK_for_Mac_FULL/libs/*` to `Xamarin.Agora.Mac/Xamarin.Agora.Full.Mac/libs/*`

`Agora_Native_SDK_for_Mac_VOICE/libs/*` to `Xamarin.Agora.Mac/Xamarin.Agora.Voice.Mac/libs/*`

## Update/Install Sharpie

download latest [Sharpie](https://download.xamarin.com/objective-sharpie/ObjectiveSharpie.pkg) (or check instructions here https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/)

## Update [ApiDefinitions & StructsAndEnums files](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/platform/apidefinitions-structsandenums)

### Generate binding files for AgoraRtcKit.framework
sharpie failed to map types correctly for macosx SDK, so as a workaround we do in 2 steps

1) bind for iphoneos SDK
```
sharpie bind -output Binding -sdk iphoneos -scope Headers Headers/AgoraRtcChannel.h -c
```

that will give you 2 files with all types, just keep in mind that base classes should be from macos, for example UIView -> NSView

2) bind for macosx SDK
```
sharpie bind -output Binding -sdk macosx -scope Headers Headers/AgoraRtcChannel.h -c
```

and verify class members, because in that mode 2 files will contain only property and functions belongs to macos and supported on macos, but will have types-trash, ignore thash and only correct members of protocols(classes and interfaces)

output looks like that:
```
sharpie bind -output Binding -sdk macosx -scope Headers Headers/AgoraRtcChannel.h -c
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
