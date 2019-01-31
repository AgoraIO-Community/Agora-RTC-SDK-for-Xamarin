## Get native libraries

Download native MacOS SDK [https://docs.agora.io/en/Agora%20Platform/downloads](https://docs.agora.io/en/Agora%20Platform/downloads)

unpack and copy files:

`Agora_Native_SDK_for_Mac_v2_3_3_FULL/libs/AgoraRtcEngineKit.framework` to `Xamarin.Agora.MacOS/Xamarin.Agora.Full.Mac/AgoraRtcEngineKit.framework`


## Update/Install Sharpie

download latest [Sharpie](https://download.xamarin.com/objective-sharpie/ObjectiveSharpie.pkg) (or check instructions here https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/) 

## Update [ApiDefinitions & StructsAndEnums files](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/platform/apidefinitions-structsandenums)

### Generate binding files for AgoraRtcEngineKit.framework

```
$ sharpie bind -output Binding -sdk macosx10.14 -scope AgoraRtcEngineKit.framework/Headers AgoraRtcEngineKit.framework/Headers/AgoraRtcEngineKit.h -c
...
...
Parsing 1 header files...

Binding...
  [write] ApiDefinitions.cs
  [write] StructsAndEnums.cs

Binding Analysis:
  Automated binding is complete, but there are a few APIs which have been flagged with [Verify] attributes. While the entire binding should be audited for best API design practices, look more closely at APIs with the following Verify attribute hints:

  ConstantsInterfaceAssociation (1 instance):
    There's no foolproof way to determine with which Objective-C interface an extern variable declaration may be associated. Instances of these are bound as [Field] properties in a partial interface into a nearby concrete interface to produce a more
    intuitive API, possibly eliminating the 'Constants' interface altogether.

  MethodToProperty (42 instances):
    An Objective-C method was bound as a C# property due to convention such as taking no parameters and returning a value (non-void return). Often methods like these should be bound as properties to surface a nicer API, but sometimes false-positives can
    occur and the binding should actually be a method.

  Once you have verified a Verify attribute, you should remove it from the binding source code. The presence of Verify attributes intentionally cause build failures.
  
  For more information about the Verify attribute hints above, consult the Objective Sharpie documentation by running 'sharpie docs' or visiting the following URL:

    http://xmn.io/sharpie-docs

Done.
```
now you have 2 files in folder "Binding" which content we will use in 3.2

### Update ApiDefinition.cs and StructsAndEnums.cs

Update [ApiDefinition.cs](ApiDefinition.cs) and [StructsAndEnums.cs](StructsAndEnums.cs) with content from generated files in previous 2 steps.

## Done, now you can build the project
