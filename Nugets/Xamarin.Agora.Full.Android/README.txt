## Xamarin.Agora.Full.Android

Thank you for installing Xamarin.Agora.Full.Android, for details and issues reporting use our nuget sources repository:
https://github.com/AgoraIO-Community/Agora-RTC-SDK-for-Xamarin/wiki

### Samples of using Agora packages:

https://github.com/DreamTeamMobile/Xamarin.Agora.Samples

## Setup package

- Modify Properties/AndroidManifest.xml, Add the following permissions for device access according to your needs:

<manifest xmlns:android="http://schemas.android.com/apk/res/android"
   package="io.agora.tutorials1v1acall">

   <uses-permission android:name="android.permission.READ_PHONE_STATE" />
   <uses-permission android:name="android.permission.INTERNET" />
   <uses-permission android:name="android.permission.RECORD_AUDIO" />
   <uses-permission android:name="android.permission.CAMERA" />
   <uses-permission android:name="android.permission.MODIFY_AUDIO_SETTINGS" />
   <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
   <uses-permission android:name="android.permission.BLUETOOTH" />
   <uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
   // Add the following permission if your scenario involves reading the external storage:
   <uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
   // For devices running Android 10.0 or later, you also need to add the following permission:
   <uses-permission android:name="android.permission.READ_PRIVILEGED_PHONE_STATE" />

...
</manifest>

If your targetSdkVersion ≥ 29, add the following line in the <application> module in the AndroidManifest.xml file:
<application
     android:requestLegacyExternalStorage="true">
</application>

## Known Issues and Limitations
Privacy changes
If your app targets Android 9, you should keep the following behavior changes in mind. These updates to device serial and DNS information enhance user privacy.

Build serial number deprecation

In Android 9, Build.SERIAL is always set to "UNKNOWN" to protect users' privacy.
If your app needs to access a device's hardware serial number, you should instead request the READ_PHONE_STATE permission, then call getSerial().

DNS privacy

Apps targeting Android 9 should honor the private DNS APIs. In particular, apps should ensure that, if the system resolver is doing DNS-over-TLS, any built-in DNS client either uses encrypted DNS to the same hostname as the system, or is disabled in favor of the system resolver.

For more information about privacy changes, see [Android Privacy Changes](https://developer.android.com/about/versions/pie/android-9.0-changes-28#privacy-changes-p).
