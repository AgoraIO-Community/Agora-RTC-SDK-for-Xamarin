using System;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace DT.Xamarin.Agora
{
    [Static]
    partial interface Constants
    {
        // extern const NSInteger AgoraVideoBitrateStandard;
        [Field("AgoraVideoBitrateStandard", "__Internal")]
        nint AgoraVideoBitrateStandard { get; }

        // extern const NSInteger AgoraVideoBitrateCompatible;
        [Field("AgoraVideoBitrateCompatible", "__Internal")]
        nint AgoraVideoBitrateCompatible { get; }

        //// extern const NSInteger AgoraVideoBitrateDefaultMin;
        //[Field("AgoraVideoBitrateDefaultMin", "__Internal")]
        //nint AgoraVideoBitrateDefaultMin { get; }

        // extern const CGSize AgoraVideoDimension120x120;
        [Field("AgoraVideoDimension120x120", "__Internal")]
        CGSize AgoraVideoDimension120x120 { get; }

        // extern const CGSize AgoraVideoDimension160x120;
        [Field("AgoraVideoDimension160x120", "__Internal")]
        CGSize AgoraVideoDimension160x120 { get; }

        // extern const CGSize AgoraVideoDimension180x180;
        [Field("AgoraVideoDimension180x180", "__Internal")]
        CGSize AgoraVideoDimension180x180 { get; }

        // extern const CGSize AgoraVideoDimension240x180;
        [Field("AgoraVideoDimension240x180", "__Internal")]
        CGSize AgoraVideoDimension240x180 { get; }

        // extern const CGSize AgoraVideoDimension320x180;
        [Field("AgoraVideoDimension320x180", "__Internal")]
        CGSize AgoraVideoDimension320x180 { get; }

        // extern const CGSize AgoraVideoDimension240x240;
        [Field("AgoraVideoDimension240x240", "__Internal")]
        CGSize AgoraVideoDimension240x240 { get; }

        // extern const CGSize AgoraVideoDimension320x240;
        [Field("AgoraVideoDimension320x240", "__Internal")]
        CGSize AgoraVideoDimension320x240 { get; }

        // extern const CGSize AgoraVideoDimension424x240;
        [Field("AgoraVideoDimension424x240", "__Internal")]
        CGSize AgoraVideoDimension424x240 { get; }

        // extern const CGSize AgoraVideoDimension360x360;
        [Field("AgoraVideoDimension360x360", "__Internal")]
        CGSize AgoraVideoDimension360x360 { get; }

        // extern const CGSize AgoraVideoDimension480x360;
        [Field("AgoraVideoDimension480x360", "__Internal")]
        CGSize AgoraVideoDimension480x360 { get; }

        // extern const CGSize AgoraVideoDimension640x360;
        [Field("AgoraVideoDimension640x360", "__Internal")]
        CGSize AgoraVideoDimension640x360 { get; }

        // extern const CGSize AgoraVideoDimension480x480;
        [Field("AgoraVideoDimension480x480", "__Internal")]
        CGSize AgoraVideoDimension480x480 { get; }

        // extern const CGSize AgoraVideoDimension640x480;
        [Field("AgoraVideoDimension640x480", "__Internal")]
        CGSize AgoraVideoDimension640x480 { get; }

        // extern const CGSize AgoraVideoDimension840x480;
        [Field("AgoraVideoDimension840x480", "__Internal")]
        CGSize AgoraVideoDimension840x480 { get; }

        // extern const CGSize AgoraVideoDimension960x720;
        [Field("AgoraVideoDimension960x720", "__Internal")]
        CGSize AgoraVideoDimension960x720 { get; }

        // extern const CGSize AgoraVideoDimension1280x720;
        [Field("AgoraVideoDimension1280x720", "__Internal")]
        CGSize AgoraVideoDimension1280x720 { get; }

        // extern const CGSize AgoraVideoDimension1920x1080;
        [Field("AgoraVideoDimension1920x1080", "__Internal")]
        CGSize AgoraVideoDimension1920x1080 { get; }

        // extern const CGSize AgoraVideoDimension2540x1440;
        [Field("AgoraVideoDimension2540x1440", "__Internal")]
        CGSize AgoraVideoDimension2540x1440 { get; }

        // extern const CGSize AgoraVideoDimension3840x2160;
        [Field("AgoraVideoDimension3840x2160", "__Internal")]
        CGSize AgoraVideoDimension3840x2160 { get; }
    }

    // @interface AgoraRtcVideoCanvas : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCanvas
    {
        // @property (nonatomic, strong) VIEW_CLASS * view;
        [Export("view", ArgumentSemantic.Strong)]
        UIView View { get; set; }

        // @property (assign, nonatomic) AgoraRtcRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        VideoRenderMode RenderMode { get; set; }

        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }
    }

    // @interface AgoraLastmileProbeConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLastmileProbeConfig
    {
        // @property (assign, nonatomic) BOOL probeUplink;
        [Export("probeUplink")]
        bool ProbeUplink { get; set; }

        // @property (assign, nonatomic) BOOL probeDownlink;
        [Export("probeDownlink")]
        bool ProbeDownlink { get; set; }

        // @property (assign, nonatomic) NSUInteger expectedUplinkBitrate;
        [Export("expectedUplinkBitrate")]
        nuint ExpectedUplinkBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger expectedDownlinkBitrate;
        [Export("expectedDownlinkBitrate")]
        nuint ExpectedDownlinkBitrate { get; set; }
    }

    // @interface AgoraLastmileProbeOneWayResult : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLastmileProbeOneWayResult
    {
        // @property (assign, nonatomic) NSUInteger packetLossRate;
        [Export("packetLossRate")]
        nuint PacketLossRate { get; set; }

        // @property (assign, nonatomic) NSUInteger jitter;
        [Export("jitter")]
        nuint Jitter { get; set; }

        // @property (assign, nonatomic) NSUInteger availableBandwidth;
        [Export("availableBandwidth")]
        nuint AvailableBandwidth { get; set; }
    }

    // @interface AgoraLastmileProbeResult : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLastmileProbeResult
    {
        // @property (assign, nonatomic) AgoraLastmileProbeResultState state;
        [Export("state", ArgumentSemantic.Assign)]
        AgoraLastmileProbeResultState State { get; set; }

        // @property (assign, nonatomic) NSUInteger rtt;
        [Export("rtt")]
        nuint Rtt { get; set; }

        // @property (nonatomic, strong) AgoraLastmileProbeOneWayResult * _Nonnull uplinkReport;
        [Export("uplinkReport", ArgumentSemantic.Strong)]
        AgoraLastmileProbeOneWayResult UplinkReport { get; set; }

        // @property (nonatomic, strong) AgoraLastmileProbeOneWayResult * _Nonnull downlinkReport;
        [Export("downlinkReport", ArgumentSemantic.Strong)]
        AgoraLastmileProbeOneWayResult DownlinkReport { get; set; }
    }

    // @interface AgoraVideoFrame : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraVideoFrame
    {
        // @property (assign, nonatomic) NSInteger format;
        [Export("format")]
        nint Format { get; set; }

        // @property (assign, nonatomic) CMTime time;
        [Export("time", ArgumentSemantic.Assign)]
        CoreMedia.CMTime Time { get; set; }

        // @property (assign, nonatomic) int stride;
        [Export("stride")]
        int Stride { get; set; }

        // @property (assign, nonatomic) int strideInPixels;
        [Export("strideInPixels")]
        int StrideInPixels { get; set; }

        // @property (assign, nonatomic) int height;
        [Export("height")]
        int Height { get; set; }

        //@property (assign, nonatomic) CVPixelBufferRef textureBuf;
        [Export("textureBuf", ArgumentSemantic.Assign)]
        unsafe IntPtr TextureBuf { get; set; }

        // @property (nonatomic, strong) NSData * dataBuf;
        [Export("dataBuf", ArgumentSemantic.Strong)]
        NSData DataBuf { get; set; }

        // @property (assign, nonatomic) int cropLeft;
        [Export("cropLeft")]
        int CropLeft { get; set; }

        // @property (assign, nonatomic) int cropTop;
        [Export("cropTop")]
        int CropTop { get; set; }

        // @property (assign, nonatomic) int cropRight;
        [Export("cropRight")]
        int CropRight { get; set; }

        // @property (assign, nonatomic) int cropBottom;
        [Export("cropBottom")]
        int CropBottom { get; set; }

        // @property (assign, nonatomic) int rotation;
        [Export("rotation")]
        int Rotation { get; set; }
    }

    // @interface AgoraBeautyOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraBeautyOptions
    {
        // @property (assign, nonatomic) AgoraLighteningContrastLevel lighteningContrastLevel;
        [Export("lighteningContrastLevel", ArgumentSemantic.Assign)]
        AgoraLighteningContrastLevel LighteningContrastLevel { get; set; }

        // @property (assign, nonatomic) float lighteningLevel;
        [Export("lighteningLevel")]
        float LighteningLevel { get; set; }

        // @property (assign, nonatomic) float smoothnessLevel;
        [Export("smoothnessLevel")]
        float SmoothnessLevel { get; set; }

        // @property (assign, nonatomic) float rednessLevel;
        [Export("rednessLevel")]
        float RednessLevel { get; set; }
    }

    // @interface AgoraRtcLocalVideoStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcLocalVideoStats
    {
        // @property (assign, nonatomic) NSUInteger sentBitrate;
        [Export("sentBitrate")]
        nuint SentBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentFrameRate;
        [Export("sentFrameRate")]
        nuint SentFrameRate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentTargetBitrate;
        [Export("sentTargetBitrate")]
        nuint SentTargetBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentTargetFrameRate;
        [Export("sentTargetFrameRate")]
        nuint SentTargetFrameRate { get; set; }

        // @property (assign, nonatomic) AgoraVideoQualityAdaptIndication qualityAdaptIndication;
        [Export("qualityAdaptIndication", ArgumentSemantic.Assign)]
        AgoraVideoQualityAdaptIndication QualityAdaptIndication { get; set; }
    }

    // @interface AgoraRtcRemoteVideoStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcRemoteVideoStats
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) NSUInteger delay;
        [Export("delay")]
        nuint Delay { get; set; }

        // @property (assign, nonatomic) NSUInteger width;
        [Export("width")]
        nuint Width { get; set; }

        // @property (assign, nonatomic) NSUInteger height;
        [Export("height")]
        nuint Height { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedBitrate;
        [Export("receivedBitrate")]
        nuint ReceivedBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedFrameRate;
        [Export("receivedFrameRate")]
        nuint ReceivedFrameRate { get; set; }

        // @property (assign, nonatomic) AgoraRtcVideoStreamType rxStreamType;
        [Export("rxStreamType", ArgumentSemantic.Assign)]
        VideoStreamType RxStreamType { get; set; }
    }

    // @interface AgoraRtcRemoteAudioStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcRemoteAudioStats
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) NSUInteger quality;
        [Export("quality")]
        nuint Quality { get; set; }

        // @property (assign, nonatomic) NSUInteger networkTransportDelay;
        [Export("networkTransportDelay")]
        nuint NetworkTransportDelay { get; set; }

        // @property (assign, nonatomic) NSUInteger jitterBufferDelay;
        [Export("jitterBufferDelay")]
        nuint JitterBufferDelay { get; set; }

        // @property (assign, nonatomic) NSUInteger audioLossRate;
        [Export("audioLossRate")]
        nuint AudioLossRate { get; set; }
    }

    // @interface AgoraRtcAudioVolumeInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcAudioVolumeInfo
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) NSUInteger volume;
        [Export("volume")]
        nuint Volume { get; set; }
    }

    // @interface AgoraChannelStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraChannelStats
    {
        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }

        // @property (assign, nonatomic) NSInteger txBytes;
        [Export("txBytes")]
        nint TxBytes { get; set; }

        // @property (assign, nonatomic) NSInteger rxBytes;
        [Export("rxBytes")]
        nint RxBytes { get; set; }

        // @property (assign, nonatomic) NSInteger txAudioKBitrate;
        [Export("txAudioKBitrate")]
        nint TxAudioKBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger rxAudioKBitrate;
        [Export("rxAudioKBitrate")]
        nint RxAudioKBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger txVideoKBitrate;
        [Export("txVideoKBitrate")]
        nint TxVideoKBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger rxVideoKBitrate;
        [Export("rxVideoKBitrate")]
        nint RxVideoKBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger lastmileDelay;
        [Export("lastmileDelay")]
        nint LastmileDelay { get; set; }

        // @property (assign, nonatomic) NSInteger userCount;
        [Export("userCount")]
        nint UserCount { get; set; }

        // @property (assign, nonatomic) double cpuAppUsage;
        [Export("cpuAppUsage")]
        double CpuAppUsage { get; set; }

        // @property (assign, nonatomic) double cpuTotalUsage;
        [Export("cpuTotalUsage")]
        double CpuTotalUsage { get; set; }
    }

    //// @interface AgoraScreenCaptureParameters : NSObject
    //[BaseType(typeof(NSObject))]
    //interface AgoraScreenCaptureParameters
    //{
    //    // @property (assign, nonatomic) CGSize dimensions;
    //    [Export("dimensions", ArgumentSemantic.Assign)]
    //    CGSize Dimensions { get; set; }

    //    // @property (assign, nonatomic) NSInteger frameRate;
    //    [Export("frameRate")]
    //    nint FrameRate { get; set; }

    //    // @property (assign, nonatomic) NSInteger bitrate;
    //    [Export("bitrate")]
    //    nint Bitrate { get; set; }
    //}

    // @interface AgoraLiveTranscodingUser : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLiveTranscodingUser
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) CGRect rect;
        [Export("rect", ArgumentSemantic.Assign)]
        CGRect Rect { get; set; }

        // @property (assign, nonatomic) NSInteger zOrder;
        [Export("zOrder")]
        nint ZOrder { get; set; }

        // @property (assign, nonatomic) double alpha;
        [Export("alpha")]
        double Alpha { get; set; }

        // @property (assign, nonatomic) NSInteger audioChannel;
        [Export("audioChannel")]
        nint AudioChannel { get; set; }
    }

    // @interface AgoraImage : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraImage
    {
        // @property (nonatomic, strong) NSURL * _Nonnull url;
        [Export("url", ArgumentSemantic.Strong)]
        NSUrl Url { get; set; }

        // @property (assign, nonatomic) CGRect rect;
        [Export("rect", ArgumentSemantic.Assign)]
        CGRect Rect { get; set; }
    }

    // @interface AgoraLiveTranscoding : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLiveTranscoding
    {
        // @property (assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // @property (assign, nonatomic) NSInteger videoBitrate;
        [Export("videoBitrate")]
        nint VideoBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger videoFramerate;
        [Export("videoFramerate")]
        nint VideoFramerate { get; set; }

        // @property (assign, nonatomic) BOOL lowLatency;
        [Export("lowLatency")]
        bool LowLatency { get; set; }

        // @property (assign, nonatomic) NSInteger videoGop;
        [Export("videoGop")]
        nint VideoGop { get; set; }

        // @property (assign, nonatomic) AgoraVideoCodecProfileType videoCodecProfile;
        [Export("videoCodecProfile", ArgumentSemantic.Assign)]
        VideoCodecProfileType VideoCodecProfile { get; set; }

        // @property (nonatomic, strong) AgoraImage * _Nullable backgroundImage;
        [NullAllowed, Export("backgroundImage", ArgumentSemantic.Strong)]
        AgoraImage BackgroundImage { get; set; }

        // @property (nonatomic, strong) COLOR_CLASS * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (copy, nonatomic) NSArray<AgoraLiveTranscodingUser *> * _Nullable transcodingUsers;
        [NullAllowed, Export("transcodingUsers", ArgumentSemantic.Copy)]
        AgoraLiveTranscodingUser[] TranscodingUsers { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable transcodingExtraInfo;
        [NullAllowed, Export("transcodingExtraInfo")]
        string TranscodingExtraInfo { get; set; }

        // @property (nonatomic, strong) AgoraImage * _Nullable watermark;
        [NullAllowed, Export("watermark", ArgumentSemantic.Strong)]
        AgoraImage Watermark { get; set; }

        // @property (assign, nonatomic) AgoraAudioSampleRateType audioSampleRate;
        [Export("audioSampleRate", ArgumentSemantic.Assign)]
        AudioSampleRateType AudioSampleRate { get; set; }

        // @property (assign, nonatomic) NSInteger audioBitrate;
        [Export("audioBitrate")]
        nint AudioBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audioChannels;
        [Export("audioChannels")]
        nint AudioChannels { get; set; }

        // +(AgoraLiveTranscoding * _Nonnull)defaultTranscoding;
        [Static]
        [Export("defaultTranscoding")]
        AgoraLiveTranscoding DefaultTranscoding { get; }

        // -(int)addUser:(AgoraLiveTranscodingUser * _Nonnull)user;
        [Export("addUser:")]
        int AddUser(AgoraLiveTranscodingUser user);

        // -(int)removeUser:(NSUInteger)uid;
        [Export("removeUser:")]
        int RemoveUser(nuint uid);
    }

    // @interface AgoraLiveInjectStreamConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLiveInjectStreamConfig
    {
        // @property (assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // @property (assign, nonatomic) NSInteger videoGop;
        [Export("videoGop")]
        nint VideoGop { get; set; }

        // @property (assign, nonatomic) NSInteger videoFramerate;
        [Export("videoFramerate")]
        nint VideoFramerate { get; set; }

        // @property (assign, nonatomic) NSInteger videoBitrate;
        [Export("videoBitrate")]
        nint VideoBitrate { get; set; }

        // @property (assign, nonatomic) AgoraAudioSampleRateType audioSampleRate;
        [Export("audioSampleRate", ArgumentSemantic.Assign)]
        AudioSampleRateType AudioSampleRate { get; set; }

        // @property (assign, nonatomic) NSInteger audioBitrate;
        [Export("audioBitrate")]
        nint AudioBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audioChannels;
        [Export("audioChannels")]
        nint AudioChannels { get; set; }

        // +(AgoraLiveInjectStreamConfig * _Nonnull)defaultConfig;
        [Static]
        [Export("defaultConfig")]
        AgoraLiveInjectStreamConfig DefaultConfig { get; }
    }

    // @interface AgoraCameraCapturerConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraCameraCapturerConfiguration
    {
        // @property (assign, nonatomic) AgoraCameraCaptureOutputPreference preference;
        [Export("preference", ArgumentSemantic.Assign)]
        AgoraCameraCaptureOutputPreference Preference { get; set; }
    }


    // @interface AgoraRtcVideoCompositingRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCompositingRegion
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) double x;
        [Export("x")]
        double X { get; set; }

        // @property (assign, nonatomic) double y;
        [Export("y")]
        double Y { get; set; }

        // @property (assign, nonatomic) double width;
        [Export("width")]
        double Width { get; set; }

        // @property (assign, nonatomic) double height;
        [Export("height")]
        double Height { get; set; }

        // @property (assign, nonatomic) NSInteger zOrder;
        [Export("zOrder")]
        nint ZOrder { get; set; }

        // @property (assign, nonatomic) double alpha;
        [Export("alpha")]
        double Alpha { get; set; }

        // @property (assign, nonatomic) AgoraRtcRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        VideoRenderMode RenderMode { get; set; }
    }

    // @interface AgoraRtcVideoCompositingLayout : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCompositingLayout
    {
        // @property (assign, nonatomic) NSInteger canvasWidth;
        [Export("canvasWidth")]
        nint CanvasWidth { get; set; }

        // @property (assign, nonatomic) NSInteger canvasHeight;
        [Export("canvasHeight")]
        nint CanvasHeight { get; set; }

        // @property (copy, nonatomic) NSString * backgroundColor;
        [NullAllowed, Export("backgroundColor")]
        string BackgroundColor { get; set; }

        // @property (retain, nonatomic) NSArray * regions;
        [NullAllowed, Export("regions", ArgumentSemantic.Retain)]
        AgoraRtcVideoCompositingRegion[] Regions { get; set; }

        // @property (copy, nonatomic) NSString * appData;
        [NullAllowed, Export("appData")]
        string AppData { get; set; }
    }

    //@interface AgoraPublisherConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraPublisherConfiguration
    {
        // @property (assign, nonatomic) BOOL owner;
        [Export("owner")]
        bool Owner { get; set; }

        // @property (assign, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (assign, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }

        // @property (assign, nonatomic) NSInteger framerate;
        [Export("framerate")]
        nint Framerate { get; set; }

        // @property (assign, nonatomic) NSInteger bitrate;
        [Export("bitrate")]
        nint Bitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audiosamplerate;
        [Export("audiosamplerate")]
        nint Audiosamplerate { get; set; }

        // @property (assign, nonatomic) NSInteger audiobitrate;
        [Export("audiobitrate")]
        nint Audiobitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audiochannels;
        [Export("audiochannels")]
        nint Audiochannels { get; set; }

        // @property (assign, nonatomic) NSInteger defaultLayout;
        [Export("defaultLayout")]
        nint DefaultLayout { get; set; }

        // @property (assign, nonatomic) AgoraRtmpStreamLifeCycle lifeCycle;
        [Export("lifeCycle", ArgumentSemantic.Assign)]
        RtmpStreamLifeCycle LifeCycle { get; set; }

        // @property (assign, nonatomic) NSInteger injectStreamWidth;
        [Export("injectStreamWidth")]
        nint InjectStreamWidth { get; set; }

        // @property (assign, nonatomic) NSInteger injectStreamHeight;
        [Export("injectStreamHeight")]
        nint InjectStreamHeight { get; set; }

        // @property (copy, nonatomic) NSString * injectStreamUrl;
        [Export("injectStreamUrl")]
        string InjectStreamUrl { get; set; }

        // @property (copy, nonatomic) NSString * publishUrl;
        [Export("publishUrl")]
        string PublishUrl { get; set; }

        // @property (copy, nonatomic) NSString * rawStreamUrl;
        [Export("rawStreamUrl")]
        string RawStreamUrl { get; set; }

        // @property (copy, nonatomic) NSString * extraInfo;
        [Export("extraInfo")]
        string ExtraInfo { get; set; }

        // -(BOOL)validate;
        [Export("validate")]
        bool Validate();
    }

    // @protocol AgoraRtcEngineDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraRtcEngineDelegate
    {
        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOccurWarning:(AgoraRtcWarningCode)warningCode;
        [Export("rtcEngine:didOccurWarning:")]
        [EventArgs("DidOccurWarning")]
        void DidOccurWarning(AgoraRtcEngineKit engine, WarningCode warningCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOccurError:(AgoraRtcErrorCode)errorCode;
        [Export("rtcEngine:didOccurError:")]
        [EventArgs("DidOccurError")]
        void DidOccurError(AgoraRtcEngineKit engine, ErrorCode errorCode);

        // @optional -(void)rtcEngineMediaEngineDidLoaded:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineMediaEngineDidLoaded:")]
        [EventArgs("RtcEngineMediaEngineDidLoaded")]
        void RtcEngineMediaEngineDidLoaded(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineRequestToken:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRequestToken:")]
        [EventArgs("RequestToken")]
        void RequestToken(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didMicrophoneEnabled:(BOOL)enabled;
        [Export("rtcEngine:didMicrophoneEnabled:")]
        [EventArgs("DidMicrophoneEnabled")]
        void DidMicrophoneEnabled(AgoraRtcEngineKit engine, bool enabled);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine reportAudioVolumeIndicationOfSpeakers:(NSArray *)speakers totalVolume:(NSInteger)totalVolume;
        [Export("rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:")]
        [EventArgs("ReportAudioVolumeIndicationOfSpeakers")]
        void ReportAudioVolumeIndicationOfSpeakers(AgoraRtcEngineKit engine, NSObject[] speakers, nint totalVolume);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstLocalVideoFrameWithSize:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalVideoFrameWithSize:elapsed:")]
        [EventArgs("FirstLocalVideoFrameWithSize")]
        void FirstLocalVideoFrameWithSize(AgoraRtcEngineKit engine, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstRemoteVideoDecodedOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:")]
        [EventArgs("FirstRemoteVideoDecodedOfUid")]
        void FirstRemoteVideoDecodedOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine videoSizeChangedOfUid:(NSUInteger)uid size:(CGSize)size rotation:(NSInteger)rotation;
        [Export("rtcEngine:videoSizeChangedOfUid:size:rotation:")]
        [EventArgs("VideoSizeChangedOfUid")]
        void VideoSizeChangedOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint rotation);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteVideoStateChangedOfUid:(NSUInteger)uid state:(AgoraVideoRemoteState)state;
        [Export("rtcEngine:remoteVideoStateChangedOfUid:state:")]
        [EventArgs("RemoteVideoStateChangedOfUid")]
        void RemoteVideoStateChangedOfUid(AgoraRtcEngineKit engine, nuint uid, VideoRemoteState state);

        // @optional -(void)rtcEngineRemoteAudioMixingDidStart:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRemoteAudioMixingDidStart:")]
        [EventArgs("RemoteAudioMixingDidStart")]
        void RemoteAudioMixingDidStart(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineRemoteAudioMixingDidFinish:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRemoteAudioMixingDidFinish:")]
        [EventArgs("RemoteAudioMixingDidFinish")]
        void RemoteAudioMixingDidFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstRemoteVideoFrameOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:")]
        [EventArgs("FirstRemoteVideoFrameOfUid")]
        void FirstRemoteVideoFrameOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didJoinedOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinedOfUid:elapsed:")]
        [EventArgs("DidJoinedOfUid")]
        void DidJoinedOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine connectionChangedToState:(AgoraConnectionStateType)state reason:(AgoraConnectionChangedReason)reason;
        [Export("rtcEngine:connectionChangedToState:reason:")]
        [EventArgs("DidConnectionChangedToState")]
        void ConnectionChangedToState(AgoraRtcEngineKit engine, AgoraConnectionStateType state, AgoraConnectionChangedReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOfflineOfUid:(NSUInteger)uid reason:(AgoraRtcUserOfflineReason)reason;
        [Export("rtcEngine:didOfflineOfUid:reason:")]
        [EventArgs("DidOfflineOfUid")]
        void DidOfflineOfUid(AgoraRtcEngineKit engine, nuint uid, UserOfflineReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didAudioMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didAudioMuted:byUid:")]
        [EventArgs("DidAudioMuted")]
        void DidAudioMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didVideoMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoMuted:byUid:")]
        [EventArgs("DidVideoMuted")]
        void DidVideoMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didAudioRouteChanged:(AudioOutputRouting)routing;
        [Export("rtcEngine:didAudioRouteChanged:")]
        [EventArgs("DidAudioRouteChanged")]
        void DidAudioRouteChanged(AgoraRtcEngineKit engine, AudioOutputRouting routing);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoEnabled:byUid:")]
        [EventArgs("DidVideoEnabled")]
        void DidVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine localVideoStats:(AgoraRtcLocalVideoStats *)stats;
        [Export("rtcEngine:localVideoStats:")]
        [EventArgs("LocalVideoStats")]
        void LocalVideoStats(AgoraRtcEngineKit engine, AgoraRtcLocalVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLocalVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didLocalVideoEnabled:byUid:")]
        [EventArgs("DidLocalVideoEnabled")]
        void DidLocalVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine remoteVideoStats:(AgoraRtcRemoteVideoStats *)stats;
        [Export("rtcEngine:remoteVideoStats:")]
        [EventArgs("RemoteVideoStats")]
        void RemoteVideoStats(AgoraRtcEngineKit engine, AgoraRtcRemoteVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteAudioStats:(AgoraRtcRemoteAudioStats * _Nonnull)stats;
        [Export("rtcEngine:remoteAudioStats:")]
        [EventArgs("RemoteAudioStats")]
        void RemoteAudioStats(AgoraRtcEngineKit engine, AgoraRtcRemoteAudioStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamPublishedWithUrl:(NSString * _Nonnull)url errorCode:(AgoraErrorCode)errorCode;
        [Export("rtcEngine:streamPublishedWithUrl:errorCode:")]
        [EventArgs("StreamPublishedWithUrl")]
        void StreamPublishedWithUrl(AgoraRtcEngineKit engine, string url, ErrorCode errorCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamInjectedStatusOfUrl:(NSString * _Nonnull)url uid:(NSUInteger)uid status:(AgoraInjectStreamStatus)status;
        [Export("rtcEngine:streamInjectedStatusOfUrl:uid:status:")]
        [EventArgs("StreamInjectedStatusOfUrl")]
        void StreamInjectedStatusOfUrl(AgoraRtcEngineKit engine, string url, nuint uid, InjectStreamStatus status);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamUnpublishedWithUrl:(NSString * _Nonnull)url;
        [Export("rtcEngine:streamUnpublishedWithUrl:")]
        [EventArgs("StreamUnpublishedWithUrl")]
        void StreamUnpublishedWithUrl(AgoraRtcEngineKit engine, string url);

        // @optional -(void)rtcEngineTranscodingUpdated:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineTranscodingUpdated:")]
        [EventArgs("TranscodingUpdated")]
        void TranscodingUpdated(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineMediaEngineDidStartCall:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineMediaEngineDidStartCall:")]
        [EventArgs("MediaEngineDidStartCall")]
        void MediaEngineDidStartCall(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineCameraDidReady:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineCameraDidReady:")]
        [EventArgs("CameraDidReady")]
        void CameraDidReady(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine cameraExposureDidChangedToRect:(CGRect)rect;
        [Export("rtcEngine:cameraExposureDidChangedToRect:")]
        [EventArgs("CameraExposureDidChangedToRect")]
        void CameraExposureDidChangedToRect(AgoraRtcEngineKit engine, CGRect rect);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine cameraFocusDidChangedToRect:(CGRect)rect;
        [Export("rtcEngine:cameraFocusDidChangedToRect:")]
        [EventArgs("CameraFocusDidChangedToRect")]
        void CameraFocusDidChangedToRect(AgoraRtcEngineKit engine, CGRect rect);

        // @optional -(void)rtcEngineVideoDidStop:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineVideoDidStop:")]
        [EventArgs("VideoDidStop")]
        void VideoDidStop(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineDidAudioEffectFinish:(AgoraRtcEngineKit * _Nonnull)engine soundId:(NSInteger)soundId;
        [Export("rtcEngineDidAudioEffectFinish:soundId:")]
        [EventArgs("DidAudioEffectFinish")]
        void DidAudioEffectFinish(AgoraRtcEngineKit engine, nint soundId);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localAudioMixingStateDidChanged:(AgoraAudioMixingStateCode)state errorCode:(AgoraAudioMixingErrorCode)errorCode;
        [Export("rtcEngine:localAudioMixingStateDidChanged:errorCode:")]
        [EventArgs("LocalAudioMixingStateDidChanged")]
        void LocalAudioMixingStateDidChanged(AgoraRtcEngineKit engine, AgoraAudioMixingStateCode state, AgoraAudioMixingErrorCode errorCode);

        // @optional -(void)rtcEngineLocalAudioMixingDidFinish:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineLocalAudioMixingDidFinish:")]
        [EventArgs("LocalAudioMixingDidFinish")]
        void LocalAudioMixingDidFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidInterrupted:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineConnectionDidInterrupted:")]
        [EventArgs("ConnectionDidInterrupted")]
        void ConnectionDidInterrupted(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidLost:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineConnectionDidLost:")]
        [EventArgs("ConnectionDidLost")]
        void ConnectionDidLost(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didJoinChannel:(NSString *)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinChannel:withUid:elapsed:")]
        [EventArgs("DidJoinChannel")]
        void DidJoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didRejoinChannel:(NSString *)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didRejoinChannel:withUid:elapsed:")]
        [EventArgs("DidRejoinChannel")]
        void DidRejoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine reportRtcStats:(AgoraChannelStats *)stats;
        [Export("rtcEngine:reportRtcStats:")]
        [EventArgs("ReportRtcStats")]
        void ReportRtcStats(AgoraRtcEngineKit engine, AgoraChannelStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didLeaveChannelWithStats:(AgoraChannelStats *)stats;
        [Export("rtcEngine:didLeaveChannelWithStats:")]
        [EventArgs("DidLeaveChannelWithStats")]
        void DidLeaveChannelWithStats(AgoraRtcEngineKit engine, AgoraChannelStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine audioQualityOfUid:(NSUInteger)uid quality:(AgoraRtcQuality)quality delay:(NSUInteger)delay lost:(NSUInteger)lost;
        [Export("rtcEngine:audioQualityOfUid:quality:delay:lost:")]
        [EventArgs("AudioQualityOfUid")]
        void AudioQualityOfUid(AgoraRtcEngineKit engine, nuint uid, Quality quality, nuint delay, nuint lost);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine lastmileProbeTestResult:(AgoraLastmileProbeResult * _Nonnull)result;
        [Export("rtcEngine:lastmileProbeTestResult:")]
        [EventArgs("LastmileProbeTestResult")]
        void LastmileProbeTestResult(AgoraRtcEngineKit engine, AgoraLastmileProbeResult result);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine networkQuality:(NSUInteger)uid txQuality:(AgoraRtcQuality)txQuality rxQuality:(AgoraRtcQuality)rxQuality;
        [Export("rtcEngine:networkQuality:txQuality:rxQuality:")]
        [EventArgs("NetworkQuality")]
        void NetworkQuality(AgoraRtcEngineKit engine, nuint uid, Quality txQuality, Quality rxQuality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine lastmileQuality:(AgoraRtcQuality)quality;
        [Export("rtcEngine:lastmileQuality:")]
        [EventArgs("LastmileQuality")]
        void LastmileQuality(AgoraRtcEngineKit engine, Quality quality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didApiCallExecute:(NSInteger)error api:(NSString * _Nonnull)api result:(NSString * _Nonnull)result;
        [Export("rtcEngine:didApiCallExecute:api:result:")]
        [EventArgs("DidApiCallExecute")]
        void DidApiCallExecute(AgoraRtcEngineKit engine, nint error, string api, string result);

        // @optional -(void)rtcEngineConnectionDidBanned:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidBanned:")]
        [EventArgs("ConnectionDidBanned")]
        void ConnectionDidBanned(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine receiveStreamMessageFromUid:(NSUInteger)uid streamId:(NSInteger)streamId data:(NSData *)data;
        [Export("rtcEngine:receiveStreamMessageFromUid:streamId:data:")]
        [EventArgs("ReceiveStreamMessageFromUid")]
        void ReceiveStreamMessageFromUid(AgoraRtcEngineKit engine, nuint uid, nint streamId, NSData data);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOccurStreamMessageErrorFromUid:(NSUInteger)uid streamId:(NSInteger)streamId error:(NSInteger)error missed:(NSInteger)missed cached:(NSInteger)cached;
        [Export("rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:")]
        [EventArgs("DidOccurStreamMessageErrorFromUid")]
        void DidOccurStreamMessageErrorFromUid(AgoraRtcEngineKit engine, nuint uid, nint streamId, nint error, nint missed, nint cached);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstLocalAudioFrame:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalAudioFrame:")]
        [EventArgs("FirstLocalAudioFrame")]
        void FirstLocalAudioFrame(AgoraRtcEngineKit engine, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstRemoteAudioFrameOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteAudioFrameOfUid:elapsed:")]
        [EventArgs("FirstRemoteAudioFrameOfUid")]
        void FirstRemoteAudioFrameOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine activeSpeaker:(NSUInteger)speakerUid;
        [Export("rtcEngine:activeSpeaker:")]
        [EventArgs("ActiveSpeaker")]
        void ActiveSpeaker(AgoraRtcEngineKit engine, nuint speakerUid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didClientRoleChanged:(AgoraRtcClientRole)oldRole newRole:(AgoraRtcClientRole)newRole;
        [Export("rtcEngine:didClientRoleChanged:newRole:")]
        [EventArgs("DidClientRoleChanged")]
        void DidClientRoleChanged(AgoraRtcEngineKit engine, ClientRole oldRole, ClientRole newRole);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine tokenPrivilegeWillExpire:(NSString * _Nonnull)token;
        [Export("rtcEngine:tokenPrivilegeWillExpire:")]
        [EventArgs("TokenPrivilegeWillExpire")]
        void TokenPrivilegeWillExpire(AgoraRtcEngineKit engine, string token);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLocalPublishFallbackToAudioOnly:(BOOL)isFallbackOrRecover;
        [Export("rtcEngine:didLocalPublishFallbackToAudioOnly:")]
        [EventArgs("DidLocalPublishFallbackToAudioOnly")]
        void DidLocalPublishFallbackToAudioOnly(AgoraRtcEngineKit engine, bool isFallbackOrRecover);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine audioTransportStatsOfUid:(NSUInteger)uid delay:(NSUInteger)delay lost:(NSUInteger)lost rxKBitRate:(NSUInteger)rxKBitRate;
        [Export("rtcEngine:audioTransportStatsOfUid:delay:lost:rxKBitRate:")]
        [EventArgs("AudioTransportStatsOfUid")]
        void AudioTransportStatsOfUid(AgoraRtcEngineKit engine, nuint uid, nuint delay, nuint lost, nuint rxKBitRate);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didRemoteSubscribeFallbackToAudioOnly:(BOOL)isFallbackOrRecover byUid:(NSUInteger)uid;
        [Export("rtcEngine:didRemoteSubscribeFallbackToAudioOnly:byUid:")]
        [EventArgs("DidRemoteSubscribeFallbackToAudioOnly")]
        void DidRemoteSubscribeFallbackToAudioOnly(AgoraRtcEngineKit engine, bool isFallbackOrRecover, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine videoTransportStatsOfUid:(NSUInteger)uid delay:(NSUInteger)delay lost:(NSUInteger)lost rxKBitRate:(NSUInteger)rxKBitRate;
        [Export("rtcEngine:videoTransportStatsOfUid:delay:lost:rxKBitRate:")]
        [EventArgs("VideoTransportStatsOfUid")]
        void VideoTransportStatsOfUid(AgoraRtcEngineKit engine, nuint uid, nuint delay, nuint lost, nuint rxKBitRate);
    }

    [Protocol]
    interface IAgoraRtcEngineDelegate
    {
    }

    // @interface AgoraRtcEngineKit : NSObject
    [BaseType(typeof(NSObject),
        Delegates = new string[] { "WeakDelegate" },
        Events = new Type[] { typeof(AgoraRtcEngineDelegate) })]
    interface AgoraRtcEngineKit
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        AgoraRtcEngineDelegate Delegate { get; set; }

        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // +(NSString *)getSdkVersion;
        [Static]
        [Export("getSdkVersion")]
        string SdkVersion { get; }

        // +(NSString *)getMediaEngineVersion;
        [Static]
        [Export("getMediaEngineVersion")]
        string MediaEngineVersion { get; }

        // -(void *)getNativeHandle;
        [Export("getNativeHandle")]
        unsafe IntPtr NativeHandle { get; }

        // +(instancetype)sharedEngineWithAppId:(NSString *)appId delegate:(id<AgoraRtcEngineDelegate>)delegate;
        [Static]
        [Export("sharedEngineWithAppId:delegate:")]
        AgoraRtcEngineKit SharedEngineWithAppIdAndDelegate(string appId, [NullAllowed] IAgoraRtcEngineDelegate @delegate);

        // +(instancetype)sharedEngineWithAppId:(NSString *)AppId error:(void (^)(AgoraRtcErrorCode))errorBlock __attribute__((deprecated("")));
        [Static]
        [Export("sharedEngineWithAppId:error:")]
        [Obsolete("use sharedEngineWithAppId:delegate: instead.")]
        AgoraRtcEngineKit SharedEngineWithAppId(string AppId, [NullAllowed] Action<ErrorCode> errorBlock);

        // +(void)destroy;
        [Static]
        [Export("destroy")]
        void Destroy();

        // -(int)joinChannelByToken:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId info:(NSString * _Nullable)info uid:(NSUInteger)uid joinSuccess:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))joinSuccessBlock;
        [Export("joinChannelByToken:channelId:info:uid:joinSuccess:")]
        int JoinChannelByToken([NullAllowed] string token, string channelId, [NullAllowed] string info, nuint uid, [NullAllowed] Action<NSString, nuint, nint> joinSuccessBlock);

        // -(void)audioVolumeIndicationBlock:(void (^)(NSArray *, NSInteger))audioVolumeIndicationBlock __attribute__((deprecated("")));
        [Export("audioVolumeIndicationBlock:")]
        void AudioVolumeIndicationBlock([NullAllowed] Action<NSArray, nint> audioVolumeIndicationBlock);

        // -(void)firstLocalVideoFrameBlock:(void (^)(NSInteger, NSInteger, NSInteger))firstLocalVideoFrameBlock __attribute__((deprecated("")));
        [Export("firstLocalVideoFrameBlock:")]
        void FirstLocalVideoFrameBlock([NullAllowed] Action<nint, nint, nint> firstLocalVideoFrameBlock);

        // -(void)firstRemoteVideoDecodedBlock:(void (^)(NSUInteger, NSInteger, NSInteger, NSInteger))firstRemoteVideoDecodedBlock __attribute__((deprecated("")));
        [Export("firstRemoteVideoDecodedBlock:")]
        void FirstRemoteVideoDecodedBlock([NullAllowed] Action<nuint, nint, nint, nint> firstRemoteVideoDecodedBlock);

        // -(void)firstRemoteVideoFrameBlock:(void (^)(NSUInteger, NSInteger, NSInteger, NSInteger))firstRemoteVideoFrameBlock __attribute__((deprecated("")));
        [Export("firstRemoteVideoFrameBlock:")]
        void FirstRemoteVideoFrameBlock([NullAllowed] Action<nuint, nint, nint, nint> firstRemoteVideoFrameBlock);

        // -(void)userJoinedBlock:(void (^)(NSUInteger, NSInteger))userJoinedBlock __attribute__((deprecated("")));
        [Export("userJoinedBlock:")]
        void UserJoinedBlock([NullAllowed] Action<nuint, nint> userJoinedBlock);

        // -(void)userOfflineBlock:(void (^)(NSUInteger))userOfflineBlock __attribute__((deprecated("")));
        [Export("userOfflineBlock:")]
        void UserOfflineBlock([NullAllowed] Action<nuint> userOfflineBlock);

        // -(void)userMuteAudioBlock:(void (^)(NSUInteger, BOOL))userMuteAudioBlock __attribute__((deprecated("")));
        [Export("userMuteAudioBlock:")]
        void UserMuteAudioBlock([NullAllowed] Action<nuint, bool> userMuteAudioBlock);

        // -(void)userMuteVideoBlock:(void (^)(NSUInteger, BOOL))userMuteVideoBlock __attribute__((deprecated("")));
        [Export("userMuteVideoBlock:")]
        void UserMuteVideoBlock([NullAllowed] Action<nuint, bool> userMuteVideoBlock);

        // -(void)localVideoStatBlock:(void (^)(NSInteger, NSInteger))localVideoStatBlock __attribute__((deprecated("")));
        [Export("localVideoStatBlock:")]
        void LocalVideoStatBlock([NullAllowed] Action<nint, nint> localVideoStatBlock);

        // -(void)remoteVideoStatBlock:(void (^)(NSUInteger, NSInteger, NSInteger, NSInteger))remoteVideoStatBlock __attribute__((deprecated("")));
        [Export("remoteVideoStatBlock:")]
        void RemoteVideoStatBlock([NullAllowed] Action<nuint, nint, nint, nint> remoteVideoStatBlock);

        // -(void)cameraReadyBlock:(void (^)())cameraReadyBlock __attribute__((deprecated("")));
        [Export("cameraReadyBlock:")]
        void CameraReadyBlock([NullAllowed] Action cameraReadyBlock);

        // -(void)remoteAudioStatBlock:(void (^ _Nullable)(NSUInteger, NSInteger, NSInteger, NSInteger, NSInteger))remoteAudioStatBlock __attribute__((deprecated("use delegate instead.")));
        [Export("remoteAudioStatBlock:")]
        void RemoteAudioStatBlock([NullAllowed] Action<nuint, nint, nint, nint, nint> remoteAudioStatBlock);

        // -(void)connectionLostBlock:(void (^)())connectionLostBlock __attribute__((deprecated("")));
        [Export("connectionLostBlock:")]
        void ConnectionLostBlock([NullAllowed] Action connectionLostBlock);

        // -(void)rejoinChannelSuccessBlock:(void (^)(NSString *, NSUInteger, NSInteger))rejoinChannelSuccessBlock __attribute__((deprecated("")));
        [Export("rejoinChannelSuccessBlock:")]
        void RejoinChannelSuccessBlock([NullAllowed] Action<NSString, nuint, nint> rejoinChannelSuccessBlock);

        // -(void)rtcStatsBlock:(void (^)(AgoraChannelStats *))rtcStatsBlock __attribute__((deprecated("")));
        [Export("rtcStatsBlock:")]
        void RtcStatsBlock([NullAllowed] Action<AgoraChannelStats> rtcStatsBlock);

        // -(void)leaveChannelBlock:(void (^ _Nullable)(AgoraChannelStats * _Nonnull))leaveChannelBlock __attribute__((deprecated("")));
        [Export("leaveChannelBlock:")]
        void LeaveChannelBlock([NullAllowed] Action<AgoraChannelStats> leaveChannelBlock);

        // -(void)audioQualityBlock:(void (^)(NSUInteger, AgoraRtcQuality, NSUInteger, NSUInteger))audioQualityBlock __attribute__((deprecated("")));
        [Export("audioQualityBlock:")]
        void AudioQualityBlock([NullAllowed] Action<nuint, Quality, nuint, nuint> audioQualityBlock);

        // -(void)networkQualityBlock:(void (^)(NSUInteger, AgoraRtcQuality, AgoraRtcQuality))networkQualityBlock __attribute__((deprecated("")));
        [Export("networkQualityBlock:")]
        void NetworkQualityBlock([NullAllowed] Action<nuint, Quality, Quality> networkQualityBlock);

        // -(void)lastmileQualityBlock:(void (^)(AgoraRtcQuality))lastmileQualityBlock __attribute__((deprecated("")));
        [Export("lastmileQualityBlock:")]
        void LastmileQualityBlock([NullAllowed] Action<Quality> lastmileQualityBlock);

        // -(void)mediaEngineEventBlock:(void (^)(NSInteger))mediaEngineEventBlock __attribute__((deprecated("")));
        [Export("mediaEngineEventBlock:")]
        void MediaEngineEventBlock([NullAllowed] Action<nint> mediaEngineEventBlock);

        // -(int)enableMainQueueDispatch:(BOOL)enabled;
        [Export("enableMainQueueDispatch:")]
        int EnableMainQueueDispatch(bool enabled);

        // -(int)leaveChannel:(void (^)(AgoraChannelStats *))leaveChannelBlock;
        [Export("leaveChannel:")]
        int LeaveChannel([NullAllowed] Action<AgoraChannelStats> leaveChannelBlock);

        // -(int)enableLastmileTest;
        [Export("enableLastmileTest")]
        int EnableLastmileTest();

        // -(int)disableLastmileTest;
        [Export("disableLastmileTest")]
        int DisableLastmileTest();

        // -(int)startLastmileProbeTest:(AgoraLastmileProbeConfig * _Nullable)config;
        [Export("startLastmileProbeTest:")]
        int StartLastmileProbeTest([NullAllowed] AgoraLastmileProbeConfig config);

        // -(int)stopLastmileProbeTest;
        [Export("stopLastmileProbeTest")]
        int StopLastmileProbeTest();

        // -(int)enableVideo;
        [Export("enableVideo")]
        int EnableVideo();

        // -(int)disableVideo;
        [Export("disableVideo")]
        int DisableVideo();

        // -(int)enableLocalVideo:(BOOL)enabled;
        [Export("enableLocalVideo:")]
        int EnableLocalVideo(bool enabled);

        // -(int)startPreview;
        [Export("startPreview")]
        int StartPreview();

        // -(int)stopPreview;
        [Export("stopPreview")]
        int StopPreview();

        // -(int)enableAudio;
        [Export("enableAudio")]
        int EnableAudio();

        // -(int)disableAudio;
        [Export("disableAudio")]
        int DisableAudio();

        // -(int)setParameters:(NSString *)options;
        [Export("setParameters:")]
        int SetParameters(string options);

        // -(NSString *)getParameter:(NSString *)parameter args:(NSString *)args;
        [Export("getParameter:args:")]
        string GetParameter(string parameter, [NullAllowed] string args);

        // -(NSString *)getCallId;
        [Export("getCallId")]
        string CallId { get; }

        // -(int)rate:(NSString *)callId rating:(NSInteger)rating description:(NSString *)description;
        [Export("rate:rating:description:")]
        int Rate(string callId, nint rating, [NullAllowed] string description);

        // -(int)complain:(NSString *)callId description:(NSString *)description;
        [Export("complain:description:")]
        int Complain(string callId, [NullAllowed] string description);

        // -(int)setEnableSpeakerphone:(BOOL)enableSpeaker;
        [Export("setEnableSpeakerphone:")]
        int SetEnableSpeakerphone(bool enableSpeaker);

        // -(BOOL)isSpeakerphoneEnabled;
        [Export("isSpeakerphoneEnabled")]
        bool IsSpeakerphoneEnabled { get; }

        // -(int)setDefaultAudioRouteToSpeakerphone:(BOOL)defaultToSpeaker;
        [Export("setDefaultAudioRouteToSpeakerphone:")]
        int SetDefaultAudioRouteToSpeakerphone(bool defaultToSpeaker);

        // -(int)enableAudioVolumeIndication:(NSInteger)interval smooth:(NSInteger)smooth;
        [Export("enableAudioVolumeIndication:smooth:")]
        int EnableAudioVolumeIndication(nint interval, nint smooth);

        // -(int)startAudioRecording:(NSString *)filePath quality:(AgoraRtcAudioRecordingQuality)quality;
        [Export("startAudioRecording:quality:")]
        int StartAudioRecording(string filePath, AudioRecordingQuality quality);

        // -(int)stopAudioRecording;
        [Export("stopAudioRecording")]
        int StopAudioRecording();

        // -(int)enableLocalAudio:(BOOL)enabled;
        [Export("enableLocalAudio:")]
        int EnableLocalAudio(bool enabled);

        // -(int)startAudioMixing:(NSString *)filePath loopback:(BOOL)loopback replace:(BOOL)replace cycle:(NSInteger)cycle;
        [Export("startAudioMixing:loopback:replace:cycle:")]
        int StartAudioMixing(string filePath, bool loopback, bool replace, nint cycle);

        // -(int)pauseAudio;
        [Export("pauseAudio")]
        [Obsolete("use DisableAudio instead.")]
        int PauseAudio();

        // -(int)resumeAudio;
        [Export("resumeAudio")]
        [Obsolete("use EnableAudio instead.")]
        int ResumeAudio();

        // -(int)stopAudioMixing;
        [Export("stopAudioMixing")]
        int StopAudioMixing();

        // -(int)pauseAudioMixing;
        [Export("pauseAudioMixing")]
        int PauseAudioMixing();

        // -(int)resumeAudioMixing;
        [Export("resumeAudioMixing")]
        int ResumeAudioMixing();

        // -(int)adjustAudioMixingVolume:(NSInteger)volume;
        [Export("adjustAudioMixingVolume:")]
        int AdjustAudioMixingVolume(nint volume);

        // -(int)adjustAudioMixingPlayoutVolume:(NSInteger)volume;
        [Export("adjustAudioMixingPlayoutVolume:")]
        int AdjustAudioMixingPlayoutVolume(nint volume);

        // -(int)adjustAudioMixingPublishVolume:(NSInteger)volume;
        [Export("adjustAudioMixingPublishVolume:")]
        int AdjustAudioMixingPublishVolume(nint volume);

        // -(int)getAudioMixingDuration;
        [Export("getAudioMixingDuration")]
        int AudioMixingDuration { get; }

        // -(int)getAudioMixingCurrentPosition;
        [Export("getAudioMixingCurrentPosition")]
        int AudioMixingCurrentPosition { get; }

        // -(int)setAudioMixingPosition:(NSInteger)pos;
        [Export("setAudioMixingPosition:")]
        int SetAudioMixingPosition(nint pos);

        // -(int)startEchoTest:(void (^)(NSString *, NSUInteger, NSInteger))successBlock;
        [Export("startEchoTest:")]
        int StartEchoTest(Action<NSString, nuint, nint> successBlock);

        // -(int)startEchoTestWithInterval:(NSInteger)interval successBlock:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))successBlock;
        [Export("startEchoTestWithInterval:successBlock:")]
        int StartEchoTestWithInterval(nint interval, [NullAllowed] Action<NSString, nuint, nint> successBlock);

        // -(int)stopEchoTest;
        [Export("stopEchoTest")]
        int StopEchoTest { get; }

        // -(id<AgoraVideoSourceProtocol> _Nullable)videoSource;
        // -(void)setVideoSource:(id<AgoraVideoSourceProtocol> _Nullable)videoSource;
        [NullAllowed, Export("videoSource")]
        IAgoraVideoSourceProtocol VideoSource { get; set; }

        // -(id<AgoraVideoSinkProtocol> _Nullable)localVideoRenderer;
        // -(void)setLocalVideoRenderer:(id<AgoraVideoSinkProtocol> _Nullable)videoRenderer;
        [NullAllowed, Export("localVideoRenderer")]
        IAgoraVideoSinkProtocol LocalVideoRenderer { get; set; }

        // -(void)setRemoteVideoRenderer:(id<AgoraVideoSinkProtocol> _Nullable)videoRenderer forUserId:(NSUInteger)userId;
        [Export("setRemoteVideoRenderer:forUserId:")]
        void SetRemoteVideoRenderer([NullAllowed] IAgoraVideoSinkProtocol videoRenderer, nuint userId);

        // -(id<AgoraVideoSinkProtocol> _Nullable)remoteVideoRendererOfUserId:(NSUInteger)userId;
        [Export("remoteVideoRendererOfUserId:")]
        [return: NullAllowed]
        IAgoraVideoSinkProtocol RemoteVideoRendererOfUserId(nuint userId);

        // -(int)muteLocalAudioStream:(BOOL)mute;
        [Export("muteLocalAudioStream:")]
        int MuteLocalAudioStream(bool mute);

        // -(int)muteAllRemoteAudioStreams:(BOOL)mute;
        [Export("muteAllRemoteAudioStreams:")]
        int MuteAllRemoteAudioStreams(bool mute);

        // -(int)setDefaultMuteAllRemoteAudioStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteAudioStreams:")]
        int SetDefaultMuteAllRemoteAudioStreams(bool mute);

        // -(int)muteRemoteAudioStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteAudioStream:mute:")]
        int MuteRemoteAudioStream(nuint uid, bool mute);

        // -(int)setupLocalVideo:(AgoraRtcVideoCanvas *)local;
        [Export("setupLocalVideo:")]
        int SetupLocalVideo([NullAllowed] AgoraRtcVideoCanvas local);

        // -(int)setLocalVideoMirrorMode:(AgoraRtcVideoMirrorMode)mode;
        [Export("setLocalVideoMirrorMode:")]
        int SetLocalVideoMirrorMode(VideoMirrorMode mode);

        // -(int)setupRemoteVideo:(AgoraRtcVideoCanvas *)remote;
        [Export("setupRemoteVideo:")]
        int SetupRemoteVideo([NullAllowed] AgoraRtcVideoCanvas remote);

        // -(int)addVideoWatermark:(AgoraImage * _Nonnull)watermark;
        [Export("addVideoWatermark:")]
        int AddVideoWatermark(AgoraImage watermark);

        // -(void)clearVideoWatermarks;
        [Export("clearVideoWatermarks")]
        void ClearVideoWatermarks();

        // -(int)setLocalRenderMode:(AgoraRtcRenderMode)mode;
        [Export("setLocalRenderMode:")]
        int SetLocalRenderMode(VideoRenderMode mode);

        // -(int)setRemoteUserPriority:(NSUInteger)uid type:(AgoraUserPriority)userPriority;
        [Export("setRemoteUserPriority:type:")]
        int SetRemoteUserPriority(nuint uid, AgoraUserPriority userPriority);

        // -(int)setRemoteRenderMode:(NSUInteger)uid mode:(AgoraRtcRenderMode)mode;
        [Export("setRemoteRenderMode:mode:")]
        int SetRemoteRenderMode(nuint uid, VideoRenderMode mode);

        // -(int)switchCamera;
        [Export("switchCamera")]
        int SwitchCamera();

        // -(int)setVideoProfile:(AgoraRtcVideoProfile)profile swapWidthAndHeight:(BOOL)swapWidthAndHeight;
        [Export("setVideoProfile:swapWidthAndHeight:")]
        [Obsolete("use setVideoEncoderConfiguration: instead.")]
        int SetVideoProfile(VideoProfile profile, bool swapWidthAndHeight);

        // -(int)setVideoResolution:(CGSize)size andFrameRate:(NSInteger)frameRate bitrate:(NSInteger)bitrate;
        [Export("setVideoResolution:andFrameRate:bitrate:")]
        [Obsolete("use setVideoEncoderConfiguration: instead.")]
        int SetVideoResolution(CGSize size, nint frameRate, nint bitrate);

        // -(int)setAudioProfile:(AgoraRtcAudioProfile)profile scenario:(AgoraRtcAudioScenario)scenario;
        [Export("setAudioProfile:scenario:")]
        int SetAudioProfile(AudioProfile profile, AudioScenario scenario);

        // -(int)enableRemoteSuperResolution:(NSUInteger)uid enabled:(BOOL)enabled;
        [Export("enableRemoteSuperResolution:enabled:")]
        int EnableRemoteSuperResolution(nuint uid, bool enabled);


        // -(int)muteLocalVideoStream:(BOOL)mute;
        [Export("muteLocalVideoStream:")]
        int MuteLocalVideoStream(bool mute);

        // -(int)muteAllRemoteVideoStreams:(BOOL)mute;
        [Export("muteAllRemoteVideoStreams:")]
        int MuteAllRemoteVideoStreams(bool mute);

        // -(int)setDefaultMuteAllRemoteVideoStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteVideoStreams:")]
        int SetDefaultMuteAllRemoteVideoStreams(bool mute);

        // -(int)muteRemoteVideoStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteVideoStream:mute:")]
        int MuteRemoteVideoStream(nuint uid, bool mute);

        // -(int)setBeautyEffectOptions:(BOOL)enable options:(AgoraBeautyOptions * _Nullable)options;
        [Export("setBeautyEffectOptions:options:")]
        int SetBeautyEffectOptions(bool enable, [NullAllowed] AgoraBeautyOptions options);

        // -(int)setLogFile:(NSString *)filePath;
        [Export("setLogFile:")]
        int SetLogFile(string filePath);

        // -(int)setLogFilter:(NSUInteger)filter;
        [Export("setLogFilter:")]
        int SetLogFilter(nuint filter);

        // -(int)setLogFileSize:(NSUInteger)fileSizeInKBytes;
        [Export("setLogFileSize:")]
        int SetLogFileSize(nuint fileSizeInKBytes);

        // -(int)setChannelProfile:(AgoraRtcChannelProfile)profile;
        [Export("setChannelProfile:")]
        int SetChannelProfile(ChannelProfile profile);

        // -(int)setClientRole:(AgoraClientRole)role;
        [Export("setClientRole:")]
        int SetClientRole(ClientRole role);

        // -(int)addPublishStreamUrl:(NSString * _Nonnull)url transcodingEnabled:(BOOL)transcodingEnabled;
        [Export("addPublishStreamUrl:transcodingEnabled:")]
        int AddPublishStreamUrl(string url, bool transcodingEnabled);

        // -(int)removePublishStreamUrl:(NSString * _Nonnull)url;
        [Export("removePublishStreamUrl:")]
        int RemovePublishStreamUrl(string url);

        // -(int)setLiveTranscoding:(AgoraLiveTranscoding * _Nullable)transcoding;
        [Export("setLiveTranscoding:")]
        int SetLiveTranscoding([NullAllowed] AgoraLiveTranscoding transcoding);

        // -(int)addInjectStreamUrl:(NSString * _Nonnull)url config:(AgoraLiveInjectStreamConfig * _Nonnull)config;
        [Export("addInjectStreamUrl:config:")]
        int AddInjectStreamUrl(string url, AgoraLiveInjectStreamConfig config);

        // -(int)removeInjectStreamUrl:(NSString * _Nonnull)url;
        [Export("removeInjectStreamUrl:")]
        int RemoveInjectStreamUrl(string url);

        // -(int)renewToken:(NSString * _Nonnull)token;
        [Export("renewToken:")]
        int RenewToken(string token);

        // -(int)enableDualStreamMode:(BOOL)enabled;
        [Export("enableDualStreamMode:")]
        int EnableDualStreamMode(bool enabled);

        // -(int)setEncryptionMode:(NSString *)encryptionMode;
        [Export("setEncryptionMode:")]
        int SetEncryptionMode(string encryptionMode);

        // -(int)setEncryptionSecret:(NSString *)secret;
        [Export("setEncryptionSecret:")]
        int SetEncryptionSecret(string secret);

        // -(int)setRemoteVideoStream:(NSUInteger)uid type:(AgoraRtcVideoStreamType)streamType;
        [Export("setRemoteVideoStream:type:")]
        int SetRemoteVideoStream(nuint uid, VideoStreamType streamType);

        // -(int)setRemoteDefaultVideoStreamType:(AgoraRtcVideoStreamType)streamType;
        [Export("setRemoteDefaultVideoStreamType:")]
        int SetRemoteDefaultVideoStreamType(VideoStreamType streamType);

        // -(CGFloat)setCameraZoomFactor:(CGFloat)zoomFactor;
        [Export("setCameraZoomFactor:")]
        nfloat SetCameraZoomFactor(nfloat zoomFactor);

        // -(int)createDataStream:(NSInteger *)streamId reliable:(BOOL)reliable ordered:(BOOL)ordered;
        [Export("createDataStream:reliable:ordered:")]
        int CreateDataStream(ref nint streamId, bool reliable, bool ordered);

        // -(int)sendStreamMessage:(NSInteger)streamId data:(NSData *)data;
        [Export("sendStreamMessage:data:")]
        int SendStreamMessage(nint streamId, NSData data);

        // -(int)setRecordingAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraRtcRawAudioFrameOpMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetRecordingAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AudioRawFrameOperationMode mode, nint samplesPerCall);

        // -(int)setPlaybackAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraRtcRawAudioFrameOpMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetPlaybackAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AudioRawFrameOperationMode mode, nint samplesPerCall);

        // -(int)setMixedAudioFrameParametersWithSampleRate:(NSInteger)sampleRate samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:")]
        int SetMixedAudioFrameParametersWithSampleRate(nint sampleRate, nint samplesPerCall);

        // -(int)adjustRecordingSignalVolume:(NSInteger)volume;
        [Export("adjustRecordingSignalVolume:")]
        int AdjustRecordingSignalVolume(nint volume);

        // -(int)adjustPlaybackSignalVolume:(NSInteger)volume;
        [Export("adjustPlaybackSignalVolume:")]
        int AdjustPlaybackSignalVolume(nint volume);

        // -(int)setHighQualityAudioParametersWithFullband:(BOOL)fullband stereo:(BOOL)stereo fullBitrate:(BOOL)fullBitrate;
        [Export("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:")]
        [Obsolete("use setAudioProfile:scenario: instead.")]
        int SetHighQualityAudioParametersWithFullband(bool fullband, bool stereo, bool fullBitrate);

        // -(int)enableInEarMonitoring:(BOOL)enabled;
        [Export("enableInEarMonitoring:")]
        int EnableInEarMonitoring(bool enabled);

        // -(AgoraConnectionStateType)getConnectionState;
        [Export("getConnectionState")]
        AgoraConnectionStateType ConnectionState { get; }

        // -(int)setInEarMonitoringVolume:(NSInteger)volume;
        [Export("setInEarMonitoringVolume:")]
        int SetInEarMonitoringVolume(nint volume);

        // -(int)enableWebSdkInteroperability:(BOOL)enabled;
        [Export("enableWebSdkInteroperability:")]
        int EnableWebSdkInteroperability(bool enabled);

        // -(int)setVideoQualityParameters:(BOOL)preferFrameRateOverImageQuality;
        [Export("setVideoQualityParameters:")]
        int SetVideoQualityParameters(bool preferFrameRateOverImageQuality);

        // -(int)configPublisher:(AgoraPublisherConfiguration *)config;
        [Export("configPublisher:")]
        [Obsolete(" This method is deprecated. Agora recommends using the following methods instead: * [addPublishStreamUrl](addPublishStreamUrl:transcodingEnabled:) or * [removePublishStreamUrl](removePublishStreamUrl:) or  * [setLiveTranscoding](setLiveTranscoding:)")]
        int ConfigPublisher(AgoraPublisherConfiguration config);

        // -(int)setVideoCompositingLayout:(AgoraRtcVideoCompositingLayout *)layout;
        [Export("setVideoCompositingLayout:")]
        [Obsolete("This method is deprecated and Agora recommends using the [setLiveTranscoding](setLiveTranscoding:) method.")]
        int SetVideoCompositingLayout(AgoraRtcVideoCompositingLayout layout);

        // -(int)clearVideoCompositingLayout;
        [Export("clearVideoCompositingLayout")]
        [Obsolete]
        int ClearVideoCompositingLayout { get; }

        // -(BOOL)isCameraZoomSupported;
        [Export("isCameraZoomSupported")]
        bool IsCameraZoomSupported { get; }

        // -(BOOL)isCameraExposurePositionSupported;
        [Export("isCameraExposurePositionSupported")]
        bool IsCameraExposurePositionSupported { get; }

        // -(BOOL)isCameraFocusPositionInPreviewSupported;
        [Export("isCameraFocusPositionInPreviewSupported")]
        bool IsCameraFocusPositionInPreviewSupported { get; }

        // -(BOOL)setCameraFocusPositionInPreview:(CGPoint)position;
        [Export("setCameraFocusPositionInPreview:")]
        bool SetCameraFocusPositionInPreview(CGPoint position);

        // -(BOOL)setCameraExposurePosition:(CGPoint)positionInView;
        [Export("setCameraExposurePosition:")]
        bool SetCameraExposurePosition(CGPoint positionInView);

        // -(BOOL)isCameraTorchSupported;
        [Export("isCameraTorchSupported")]
        bool IsCameraTorchSupported { get; }

        // -(BOOL)setCameraTorchOn:(BOOL)isOn;
        [Export("setCameraTorchOn:")]
        bool SetCameraTorchOn(bool isOn);

        // -(BOOL)isCameraAutoFocusFaceModeSupported;
        [Export("isCameraAutoFocusFaceModeSupported")]
        bool IsCameraAutoFocusFaceModeSupported { get; }

        // -(BOOL)setCameraAutoFocusFaceModeEnabled:(BOOL)enable;
        [Export("setCameraAutoFocusFaceModeEnabled:")]
        bool SetCameraAutoFocusFaceModeEnabled(bool enable);

        // -(double)getEffectsVolume;
        [Export("getEffectsVolume")]
        double EffectsVolume { get; }

        // -(int)setEffectsVolume:(double)volume;
        [Export("setEffectsVolume:")]
        int SetEffectsVolume(double volume);

        // -(int)setVolumeOfEffect:(int)soundId withVolume:(double)volume;
        [Export("setVolumeOfEffect:withVolume:")]
        int SetVolumeOfEffect(int soundId, double volume);

        // -(int)playEffect:(int)soundId filePath:(NSString * _Nullable)filePath loopCount:(int)loopCount pitch:(double)pitch pan:(double)pan gain:(double)gain publish:(BOOL)publish;
        [Export("playEffect:filePath:loopCount:pitch:pan:gain:publish:")]
        int PlayEffect(int soundId, [NullAllowed] string filePath, int loopCount, double pitch, double pan, double gain, bool publish);

        // -(int)playEffect:(int)soundId filePath:(NSString * _Nullable)filePath loopCount:(int)loopCount pitch:(double)pitch pan:(double)pan gain:(double)gain __attribute__((deprecated("use playEffect:filePath:loopCount:pitch:pan:gain:publish: instead.")));
        [Export("playEffect:filePath:loopCount:pitch:pan:gain:")]
        [Obsolete("use playEffect:filePath:loopCount:pitch:pan:gain:publish: instead.")]
        int PlayEffect(int soundId, [NullAllowed] string filePath, int loopCount, double pitch, double pan, double gain);

        // -(int)stopEffect:(int)soundId;
        [Export("stopEffect:")]
        int StopEffect(int soundId);

        // -(int)stopAllEffects;
        [Export("stopAllEffects")]
        int StopAllEffects();

        // -(int)preloadEffect:(int)soundId filePath:(NSString *)filePath;
        [Export("preloadEffect:filePath:")]
        int PreloadEffect(int soundId, [NullAllowed] string filePath);

        // -(int)unloadEffect:(int)soundId;
        [Export("unloadEffect:")]
        int UnloadEffect(int soundId);

        // -(int)pauseEffect:(int)soundId;
        [Export("pauseEffect:")]
        int PauseEffect(int soundId);

        // -(int)pauseAllEffects;
        [Export("pauseAllEffects")]
        int PauseAllEffects();

        // -(int)resumeEffect:(int)soundId;
        [Export("resumeEffect:")]
        int ResumeEffect(int soundId);

        // -(int)resumeAllEffects;
        [Export("resumeAllEffects")]
        int ResumeAllEffects();

        // -(int)setLocalVoicePitch:(double)pitch;
        [Export("setLocalVoicePitch:")]
        int SetLocalVoicePitch(double pitch);

        // -(void)setExternalVideoSource:(BOOL)enable useTexture:(BOOL)useTexture pushMode:(BOOL)pushMode;
        [Export("setExternalVideoSource:useTexture:pushMode:")]
        void SetExternalVideoSource(bool enable, bool useTexture, bool pushMode);

        // -(BOOL)pushExternalVideoFrame:(AgoraVideoFrame *)frame;
        [Export("pushExternalVideoFrame:")]
        bool PushExternalVideoFrame(AgoraVideoFrame frame);

        // -(void)enableExternalAudioSourceWithSampleRate:(NSUInteger)sampleRate channelsPerFrame:(NSUInteger)channelsPerFrame;
        [Export("enableExternalAudioSourceWithSampleRate:channelsPerFrame:")]
        void EnableExternalAudioSourceWithSampleRate(nuint sampleRate, nuint channelsPerFrame);

        // -(void)disableExternalAudioSource;
        [Export("disableExternalAudioSource")]
        void DisableExternalAudioSource();

        // -(int)setLocalVoiceEqualizationOfBandFrequency:(AgoraAudioEqualizationBandFrequency)bandFrequency withGain:(NSInteger)gain;
        [Export("setLocalVoiceEqualizationOfBandFrequency:withGain:")]
        int SetLocalVoiceEqualizationOfBandFrequency(AudioEqualizationBandFrequency bandFrequency, nint gain);

        // -(int)setLocalVoiceReverbOfType:(AgoraAudioReverbType)reverbType withValue:(NSInteger)value;
        [Export("setLocalVoiceReverbOfType:withValue:")]
        int SetLocalVoiceReverbOfType(AudioReverbType reverbType, nint value);

        // -(int)setLocalVoiceChanger:(AgoraAudioVoiceChanger)voiceChanger;
        [Export("setLocalVoiceChanger:")]
        int SetLocalVoiceChanger(AgoraAudioVoiceChanger voiceChanger);

        // -(int)setRemoteVoicePosition:(NSUInteger)uid pan:(double)pan gain:(double)gain;
        [Export("setRemoteVoicePosition:pan:gain:")]
        int SetRemoteVoicePosition(nuint uid, double pan, double gain);

        // -(int)enableSoundPositionIndication:(BOOL)enabled;
        [Export("enableSoundPositionIndication:")]
        int EnableSoundPositionIndication(bool enabled);

        // -(int)setLocalVoiceReverbPreset:(AgoraAudioReverbPreset)reverbPreset;
        [Export("setLocalVoiceReverbPreset:")]
        int SetLocalVoiceReverbPreset(AgoraAudioReverbPreset reverbPreset);

        // -(BOOL)pushExternalAudioFrameRawData:(void * _Nonnull)data samples:(NSUInteger)samples timestamp:(NSTimeInterval)timestamp;
        [Export("pushExternalAudioFrameRawData:samples:timestamp:")]
        unsafe bool PushExternalAudioFrameRawData(IntPtr data, nuint samples, double timestamp);

        // -(BOOL)pushExternalAudioFrameSampleBuffer:(CMSampleBufferRef _Nonnull)sampleBuffer;
        [Export("pushExternalAudioFrameSampleBuffer:")]
        unsafe bool PushExternalAudioFrameSampleBuffer(IntPtr sampleBuffer);

        // -(int)setLocalPublishFallbackOption:(AgoraStreamFallbackOptions)option;
        [Export("setLocalPublishFallbackOption:")]
        int SetLocalPublishFallbackOption(StreamFallbackOptions option);

        // -(int)setRemoteSubscribeFallbackOption:(AgoraStreamFallbackOptions)option;
        [Export("setRemoteSubscribeFallbackOption:")]
        int SetRemoteSubscribeFallbackOption(StreamFallbackOptions option);
        // -(void)setAudioSessionOperationRestriction:(AudioSessionOperationRestriction)restriction;
        [Export("setAudioSessionOperationRestriction:")]
        void SetAudioSessionOperationRestriction(AudioSessionOperationRestriction restriction);

        // -(int)setCameraCapturerConfiguration:(AgoraCameraCapturerConfiguration * _Nullable)configuration;
        [Export("setCameraCapturerConfiguration:")]
        int SetCameraCapturerConfiguration([NullAllowed] AgoraCameraCapturerConfiguration configuration);

        // -(int)setVideoEncoderConfiguration:(AgoraVideoEncoderConfiguration * _Nonnull)config;
        [Export("setVideoEncoderConfiguration:")]
        int SetVideoEncoderConfiguration(AgoraVideoEncoderConfiguration config);

        // -(int)muteRecordingSignal:(BOOL)muted;
        [Export("muteRecordingSignal:")]
        int MuteRecordingSignal(bool muted);

        // -(NSString * _Nullable)getDeviceId:(AgoraMediaDeviceType)type __attribute__((deprecated("use getDeviceInfo: instead.")));
        [Export("getDeviceId:")]
        [return: NullAllowed]
        [Obsolete("use GetDeviceInfo: instead.")]
        string GetDeviceId(MediaDeviceType type);
    }

    // @interface AgoraVideoEncoderConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraVideoEncoderConfiguration
    {
        // @property (assign, nonatomic) CGSize dimensions;
        [Export("dimensions", ArgumentSemantic.Assign)]
        CGSize Dimensions { get; set; }

        // @property (assign, nonatomic) AgoraVideoFrameRate frameRate;
        [Export("frameRate", ArgumentSemantic.Assign)]
        VideoFrameRate FrameRate { get; set; }


        // @property (assign, nonatomic) NSInteger minFrameRate;
        [Export("minFrameRate")]
        nint MinFrameRate { get; set; }

        // @property (assign, nonatomic) NSInteger bitrate;
        [Export("bitrate")]
        nint Bitrate { get; set; }

        // @property (assign, nonatomic) NSInteger minBitrate;
        [Export("minBitrate")]
        nint MinBitrate { get; set; }

        // @property (assign, nonatomic) AgoraVideoOutputOrientationMode orientationMode;
        [Export("orientationMode", ArgumentSemantic.Assign)]
        VideoOutputOrientationMode OrientationMode { get; set; }

        // @property (assign, nonatomic) AgoraDegradationPreference degradationPreference;
        [Export("degradationPreference", ArgumentSemantic.Assign)]
        AgoraDegradationPreference DegradationPreference { get; set; }

        // -(instancetype _Nonnull)initWithSize:(CGSize)size frameRate:(AgoraVideoFrameRate)frameRate bitrate:(NSInteger)bitrate orientationMode:(AgoraVideoOutputOrientationMode)orientationMode;
        [Export("initWithSize:frameRate:bitrate:orientationMode:")]
        IntPtr Constructor(CGSize size, VideoFrameRate frameRate, nint bitrate, VideoOutputOrientationMode orientationMode);

        // -(instancetype _Nonnull)initWithWidth:(NSInteger)width height:(NSInteger)height frameRate:(AgoraVideoFrameRate)frameRate bitrate:(NSInteger)bitrate orientationMode:(AgoraVideoOutputOrientationMode)orientationMode;
        [Export("initWithWidth:height:frameRate:bitrate:orientationMode:")]
        IntPtr Constructor(nint width, nint height, VideoFrameRate frameRate, nint bitrate, VideoOutputOrientationMode orientationMode);
    }

    // @protocol AgoraVideoFrameConsumer <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraVideoFrameConsumer
    {
        // @required -(void)consumePixelBuffer:(CVPixelBufferRef _Nonnull)pixelBuffer withTimestamp:(CMTime)timestamp rotation:(AgoraVideoRotation)rotation;
        [Abstract]
        [Export("consumePixelBuffer:withTimestamp:rotation:")]
        unsafe void ConsumePixelBuffer(IntPtr pixelBuffer, CMTime timestamp, VideoRotation rotation);

        // @required -(void)consumeRawData:(void * _Nonnull)rawData withTimestamp:(CMTime)timestamp format:(AgoraVideoPixelFormat)format size:(CGSize)size rotation:(AgoraVideoRotation)rotation;
        [Abstract]
        [Export("consumeRawData:withTimestamp:format:size:rotation:")]
        unsafe void ConsumeRawData(IntPtr rawData, CMTime timestamp, VideoPixelFormat format, CGSize size, VideoRotation rotation);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraVideoSourceProtocol
    {
        // @required @property (strong) id<AgoraVideoFrameConsumer> _Nullable consumer;
        [Abstract]
        [NullAllowed, Export("consumer", ArgumentSemantic.Strong)]
        AgoraVideoFrameConsumer Consumer { get; set; }

        // @required -(BOOL)shouldInitialize;
        [Abstract]
        [Export("shouldInitialize")]
        bool ShouldInitialize { get; }

        // @required -(void)shouldStart;
        [Abstract]
        [Export("shouldStart")]
        void ShouldStart();

        // @required -(void)shouldStop;
        [Abstract]
        [Export("shouldStop")]
        void ShouldStop();

        // @required -(void)shouldDispose;
        [Abstract]
        [Export("shouldDispose")]
        void ShouldDispose();

        // @required -(AgoraVideoBufferType)bufferType;
        [Abstract]
        [Export("bufferType")]
        VideoBufferType BufferType { get; }
    }

    [Protocol]
    interface IAgoraVideoSourceProtocol
    {
    }

    // @protocol AgoraVideoSinkProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraVideoSinkProtocol
    {
        // @required -(BOOL)shouldInitialize;
        [Abstract]
        [Export("shouldInitialize")]
        bool ShouldInitialize { get; }

        // @required -(void)shouldStart;
        [Abstract]
        [Export("shouldStart")]
        void ShouldStart();

        // @required -(void)shouldStop;
        [Abstract]
        [Export("shouldStop")]
        void ShouldStop();

        // @required -(void)shouldDispose;
        [Abstract]
        [Export("shouldDispose")]
        void ShouldDispose();

        // @required -(AgoraVideoBufferType)bufferType;
        [Abstract]
        [Export("bufferType")]
        VideoBufferType BufferType { get; }

        // @required -(AgoraVideoPixelFormat)pixelFormat;
        [Abstract]
        [Export("pixelFormat")]
        VideoPixelFormat PixelFormat { get; }

        // @optional -(void)renderPixelBuffer:(CVPixelBufferRef _Nonnull)pixelBuffer rotation:(AgoraVideoRotation)rotation;
        [Export("renderPixelBuffer:rotation:")]
        unsafe void RenderPixelBuffer(IntPtr pixelBuffer, VideoRotation rotation);

        // @optional -(void)renderRawData:(void * _Nonnull)rawData size:(CGSize)size rotation:(AgoraVideoRotation)rotation;
        [Export("renderRawData:size:rotation:")]
        unsafe void RenderRawData(IntPtr rawData, CGSize size, VideoRotation rotation);

    }

    [Protocol]
    interface IAgoraVideoSinkProtocol
    {
    }

    // @interface AgoraRtcDefaultCamera : NSObject <AgoraVideoSourceProtocol>
    [BaseType(typeof(NSObject))]
    interface AgoraRtcDefaultCamera : AgoraVideoSourceProtocol
    {
        // @property (assign, nonatomic) AgoraRtcDefaultCameraPosition position;
        [Export("position", ArgumentSemantic.Assign)]
        RtcDefaultCameraPosition Position { get; set; }

        // -(instancetype _Nonnull)initWithPosition:(AgoraRtcDefaultCameraPosition)position;
        [Export("initWithPosition:")]
        IntPtr Constructor(RtcDefaultCameraPosition position);
    }

    // @interface AgoraRtcDefaultRenderer : NSObject <AgoraVideoSinkProtocol>
    [BaseType(typeof(NSObject))]
    interface AgoraRtcDefaultRenderer : AgoraVideoSinkProtocol
    {
        // @property (readonly, nonatomic, strong) VIEW_CLASS * _Nonnull view;
        [Export("view", ArgumentSemantic.Strong)]
        UIView View { get; }

        // @property (assign, nonatomic) AgoraVideoRenderMode mode;
        [Export("mode", ArgumentSemantic.Assign)]
        VideoRenderMode Mode { get; set; }

        // -(instancetype _Nonnull)initWithView:(VIEW_CLASS * _Nonnull)view renderMode:(AgoraVideoRenderMode)mode;
        [Export("initWithView:renderMode:")]
        IntPtr Constructor(UIView view, VideoRenderMode mode);
    }
}
