using System;
using AppKit;
using CoreGraphics;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace Xamarin.Agora.Mac
{
    [Static]
    partial interface Constants
    {
        // extern const NSInteger AgoraVideoBitrateStandard;
        [Field("AgoraVideoBitrateStandard", LibraryName = "AgoraRtcKit.framework")]
        nint AgoraVideoBitrateStandard { get; }

        // extern const NSInteger AgoraVideoBitrateCompatible;
        [Field("AgoraVideoBitrateCompatible", LibraryName = "AgoraRtcKit.framework")]
        nint AgoraVideoBitrateCompatible { get; }

        // extern const NSInteger AgoraVideoBitrateDefaultMin;
        [Field("AgoraVideoBitrateDefaultMin", LibraryName = "AgoraRtcKit.framework")]
        nint AgoraVideoBitrateDefaultMin { get; }

        // extern const CGSize AgoraVideoDimension120x120;
        [Field("AgoraVideoDimension120x120", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension120x120 { get; }

        // extern const CGSize AgoraVideoDimension160x120;
        [Field("AgoraVideoDimension160x120", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension160x120 { get; }

        // extern const CGSize AgoraVideoDimension180x180;
        [Field("AgoraVideoDimension180x180", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension180x180 { get; }

        // extern const CGSize AgoraVideoDimension240x180;
        [Field("AgoraVideoDimension240x180", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension240x180 { get; }

        // extern const CGSize AgoraVideoDimension320x180;
        [Field("AgoraVideoDimension320x180", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension320x180 { get; }

        // extern const CGSize AgoraVideoDimension240x240;
        [Field("AgoraVideoDimension240x240", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension240x240 { get; }

        // extern const CGSize AgoraVideoDimension320x240;
        [Field("AgoraVideoDimension320x240", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension320x240 { get; }

        // extern const CGSize AgoraVideoDimension424x240;
        [Field("AgoraVideoDimension424x240", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension424x240 { get; }

        // extern const CGSize AgoraVideoDimension360x360;
        [Field("AgoraVideoDimension360x360", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension360x360 { get; }

        // extern const CGSize AgoraVideoDimension480x360;
        [Field("AgoraVideoDimension480x360", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension480x360 { get; }

        // extern const CGSize AgoraVideoDimension640x360;
        [Field("AgoraVideoDimension640x360", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension640x360 { get; }

        // extern const CGSize AgoraVideoDimension480x480;
        [Field("AgoraVideoDimension480x480", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension480x480 { get; }

        // extern const CGSize AgoraVideoDimension640x480;
        [Field("AgoraVideoDimension640x480", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension640x480 { get; }

        // extern const CGSize AgoraVideoDimension840x480;
        [Field("AgoraVideoDimension840x480", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension840x480 { get; }

        // extern const CGSize AgoraVideoDimension960x720;
        [Field("AgoraVideoDimension960x720", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension960x720 { get; }

        // extern const CGSize AgoraVideoDimension1280x720;
        [Field("AgoraVideoDimension1280x720", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension1280x720 { get; }

        // extern const CGSize AgoraVideoDimension1920x1080;
        [Field("AgoraVideoDimension1920x1080", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension1920x1080 { get; }

        // extern const CGSize AgoraVideoDimension2540x1440;
        [Field("AgoraVideoDimension2540x1440", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension2540x1440 { get; }

        // extern const CGSize AgoraVideoDimension3840x2160;
        [Field("AgoraVideoDimension3840x2160", LibraryName = "AgoraRtcKit.framework")]
        CGSize AgoraVideoDimension3840x2160 { get; }

        // extern NSString *const _Nonnull LBHQ;
        [Field("LBHQ", LibraryName = "AgoraRtcKit.framework")]
        NSString LBHQ { get; }

        // extern NSString *const _Nonnull VEO;
        [Field("VEO", LibraryName = "AgoraRtcKit.framework")]
        NSString VEO { get; }
    }

    // @interface AgoraAudioFrame : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraAudioFrame
    {
        // @property (assign, nonatomic) NSInteger samplesPerChannel;
        [Export("samplesPerChannel")]
        nint SamplesPerChannel { get; set; }

        // @property (assign, nonatomic) NSInteger bytesPerSample;
        [Export("bytesPerSample")]
        nint BytesPerSample { get; set; }

        // @property (assign, nonatomic) NSInteger channels;
        [Export("channels")]
        nint Channels { get; set; }

        // @property (assign, nonatomic) NSInteger samplesPerSec;
        [Export("samplesPerSec")]
        nint SamplesPerSec { get; set; }

        // @property (nonatomic, strong) NSData * _Nullable buffer;
        [NullAllowed, Export("buffer", ArgumentSemantic.Strong)]
        NSData Buffer { get; set; }

        // @property (assign, nonatomic) int64_t renderTimeMs;
        [Export("renderTimeMs")]
        long RenderTimeMs { get; set; }

        // @property (assign, nonatomic) NSInteger avSyncType;
        [Export("avSyncType")]
        nint AvSyncType { get; set; }
    }

    // @interface AgoraRtcVideoCanvas : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCanvas
    {
        // @property (nonatomic, strong) VIEW_CLASS * _Nullable view;
        [NullAllowed, Export("view", ArgumentSemantic.Strong)]
        NSView View { get; set; }

        // @property (assign, nonatomic) AgoraVideoRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        VideoRenderMode RenderMode { get; set; }

        // @property (copy, nonatomic) int * _Nullable channelId;
        [NullAllowed, Export("channelId", ArgumentSemantic.Copy)]
        string ChannelId { get; set; }

        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) int mirrorMode;
        [Export("mirrorMode")]
        VideoMirrorMode MirrorMode { get; set; }
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
        LastmileProbeResultState State { get; set; }

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

        // @property (assign, nonatomic) NSUInteger encoderOutputFrameRate;
        [Export("encoderOutputFrameRate")]
        nuint EncoderOutputFrameRate { get; set; }

        // @property (assign, nonatomic) NSUInteger rendererOutputFrameRate;
        [Export("rendererOutputFrameRate")]
        nuint RendererOutputFrameRate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentTargetBitrate;
        [Export("sentTargetBitrate")]
        nuint SentTargetBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentTargetFrameRate;
        [Export("sentTargetFrameRate")]
        nuint SentTargetFrameRate { get; set; }

        // @property (assign, nonatomic) AgoraVideoQualityAdaptIndication qualityAdaptIndication;
        [Export("qualityAdaptIndication", ArgumentSemantic.Assign)]
        VideoQualityAdaptIndication QualityAdaptIndication { get; set; }

        // @property (assign, nonatomic) NSUInteger encodedBitrate;
        [Export("encodedBitrate")]
        nuint EncodedBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger encodedFrameWidth;
        [Export("encodedFrameWidth")]
        nuint EncodedFrameWidth { get; set; }

        // @property (assign, nonatomic) NSUInteger encodedFrameHeight;
        [Export("encodedFrameHeight")]
        nuint EncodedFrameHeight { get; set; }

        // @property (assign, nonatomic) NSUInteger encodedFrameCount;
        [Export("encodedFrameCount")]
        nuint EncodedFrameCount { get; set; }

        // @property (assign, nonatomic) AgoraVideoCodecType codecType;
        [Export("codecType", ArgumentSemantic.Assign)]
        VideoCodecType CodecType { get; set; }

        // @property (assign, nonatomic) NSInteger txPacketLossRate;
        [Export("txPacketLossRate")]
        nint TxPacketLossRate { get; set; }

        // @property (assign, nonatomic) NSInteger captureFrameRate;
        [Export("captureFrameRate")]
        nint CaptureFrameRate { get; set; }

        // @property (assign, nonatomic) AgoraCaptureBrightnessLevelType captureBrightnessLevel;
        [Export("captureBrightnessLevel", ArgumentSemantic.Assign)]
        CaptureBrightnessLevelType CaptureBrightnessLevel { get; set; }
    }

    // @interface AgoraRtcRemoteVideoStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcRemoteVideoStats
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) NSUInteger delay __attribute__((deprecated("")));
        [Export("delay")]
        nuint Delay { get; }

        // @property (assign, nonatomic) NSUInteger width;
        [Export("width")]
        nuint Width { get; set; }

        // @property (assign, nonatomic) NSUInteger height;
        [Export("height")]
        nuint Height { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedBitrate;
        [Export("receivedBitrate")]
        nuint ReceivedBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger decoderOutputFrameRate;
        [Export("decoderOutputFrameRate")]
        nuint DecoderOutputFrameRate { get; set; }

        // @property (assign, nonatomic) NSUInteger rendererOutputFrameRate;
        [Export("rendererOutputFrameRate")]
        nuint RendererOutputFrameRate { get; set; }

        // @property (assign, nonatomic) NSUInteger packetLossRate;
        [Export("packetLossRate")]
        nuint PacketLossRate { get; set; }

        // @property (assign, nonatomic) AgoraVideoStreamType rxStreamType;
        [Export("rxStreamType", ArgumentSemantic.Assign)]
        VideoStreamType RxStreamType { get; set; }

        // @property (assign, nonatomic) NSUInteger totalFrozenTime;
        [Export("totalFrozenTime")]
        nuint TotalFrozenTime { get; set; }

        // @property (assign, nonatomic) NSUInteger frozenRate;
        [Export("frozenRate")]
        nuint FrozenRate { get; set; }

        // @property (assign, nonatomic) int totalActiveTime;
        [Export("totalActiveTime")]
        nuint TotalActiveTime { get; set; }

        // @property (assign, nonatomic) NSInteger publishDuration;
        [Export("publishDuration")]
        nint PublishDuration { get; set; }
    }

    // @interface AgoraRtcLocalAudioStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcLocalAudioStats
    {
        // @property (assign, nonatomic) NSUInteger numChannels;
        [Export("numChannels")]
        nuint NumChannels { get; set; }

        // @property (assign, nonatomic) NSUInteger sentSampleRate;
        [Export("sentSampleRate")]
        nuint SentSampleRate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentBitrate;
        [Export("sentBitrate")]
        nuint SentBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger txPacketLossRate;
        [Export("txPacketLossRate")]
        nuint TxPacketLossRate { get; set; }
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

        // @property (assign, nonatomic) NSUInteger numChannels;
        [Export("numChannels")]
        nuint NumChannels { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedSampleRate;
        [Export("receivedSampleRate")]
        nuint ReceivedSampleRate { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedBitrate;
        [Export("receivedBitrate")]
        nuint ReceivedBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger totalFrozenTime;
        [Export("totalFrozenTime")]
        nuint TotalFrozenTime { get; set; }

        // @property (assign, nonatomic) NSUInteger frozenRate;
        [Export("frozenRate")]
        nuint FrozenRate { get; set; }

        // @property (assign, nonatomic) int totalActiveTime;
        [Export("totalActiveTime")]
        nuint TotalActiveTime { get; set; }

        // @property (assign, nonatomic) NSInteger publishDuration;
        [Export("publishDuration")]
        nint PublishDuration { get; set; }

        // @property (assign, nonatomic) NSUInteger qoeQuality;
        [Export("qoeQuality")]
        nuint QoeQuality { get; set; }

        // @property (assign, nonatomic) NSUInteger qualityChangedReason;
        [Export("qualityChangedReason")]
        nuint QualityChangedReason { get; set; }

        // @property (assign, nonatomic) int mosValue;
        [Export("mosValue")]
        nint MosValue { get; set; }
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

        // @property (assign, nonatomic) NSUInteger vad;
        [Export("vad")]
        nuint Vad { get; set; }

        // @property (copy, nonatomic) int * _Nonnull channelId;
        [Export("channelId", ArgumentSemantic.Copy)]
        string ChannelId { get; set; }
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

        // @property (assign, nonatomic) NSInteger txAudioBytes;
        [Export("txAudioBytes")]
        nint TxAudioBytes { get; set; }

        // @property (assign, nonatomic) NSInteger txVideoBytes;
        [Export("txVideoBytes")]
        nint TxVideoBytes { get; set; }

        // @property (assign, nonatomic) NSInteger rxAudioBytes;
        [Export("rxAudioBytes")]
        nint RxAudioBytes { get; set; }

        // @property (assign, nonatomic) NSInteger rxVideoBytes;
        [Export("rxVideoBytes")]
        nint RxVideoBytes { get; set; }

        // @property (assign, nonatomic) NSInteger txKBitrate;
        [Export("txKBitrate")]
        nint TxKBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger rxKBitrate;
        [Export("rxKBitrate")]
        nint RxKBitrate { get; set; }

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

        // @property (assign, nonatomic) NSInteger txPacketLossRate;
        [Export("txPacketLossRate")]
        nint TxPacketLossRate { get; set; }

        // @property (assign, nonatomic) NSInteger rxPacketLossRate;
        [Export("rxPacketLossRate")]
        nint RxPacketLossRate { get; set; }

        // @property (assign, nonatomic) NSInteger userCount;
        [Export("userCount")]
        nint UserCount { get; set; }

        // @property (assign, nonatomic) double cpuAppUsage;
        [Export("cpuAppUsage")]
        double CpuAppUsage { get; set; }

        // @property (assign, nonatomic) double cpuTotalUsage;
        [Export("cpuTotalUsage")]
        double CpuTotalUsage { get; set; }

        // @property (assign, nonatomic) int gatewayRtt;
        [Export("gatewayRtt")]
        nint GatewayRtt { get; set; }

        // @property (assign, nonatomic) double memoryAppUsageRatio;
        [Export("memoryAppUsageRatio")]
        double MemoryAppUsageRatio { get; set; }

        // @property (assign, nonatomic) double memoryTotalUsageRatio;
        [Export("memoryTotalUsageRatio")]
        double MemoryTotalUsageRatio { get; set; }

        // @property (assign, nonatomic) int memoryAppUsageInKbytes;
        [Export("memoryAppUsageInKbytes")]
        nint MemoryAppUsageInKbytes { get; set; }
    }

    // @interface AgoraVideoEncoderConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraVideoEncoderConfiguration
    {
        // @property (assign, nonatomic) CGSize dimensions;
        [Export("dimensions", ArgumentSemantic.Assign)]
        CGSize Dimensions { get; set; }

        // @property (assign, nonatomic) NSInteger frameRate;
        [Export("frameRate")]
        nint FrameRate { get; set; }

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
        DegradationPreference DegradationPreference { get; set; }

        // @property (assign, nonatomic) AgoraVideoMirrorMode mirrorMode;
        [Export("mirrorMode", ArgumentSemantic.Assign)]
        VideoMirrorMode MirrorMode { get; set; }

        // -(instancetype _Nonnull)initWithSize:(CGSize)size frameRate:(AgoraVideoFrameRate)frameRate bitrate:(NSInteger)bitrate orientationMode:(AgoraVideoOutputOrientationMode)orientationMode;
        [Export("initWithSize:frameRate:bitrate:orientationMode:")]
        IntPtr Constructor(CGSize size, VideoFrameRate frameRate, nint bitrate, VideoOutputOrientationMode orientationMode);

        // -(instancetype _Nonnull)initWithWidth:(NSInteger)width height:(NSInteger)height frameRate:(AgoraVideoFrameRate)frameRate bitrate:(NSInteger)bitrate orientationMode:(AgoraVideoOutputOrientationMode)orientationMode;
        [Export("initWithWidth:height:frameRate:bitrate:orientationMode:")]
        IntPtr Constructor(nint width, nint height, VideoFrameRate frameRate, nint bitrate, VideoOutputOrientationMode orientationMode);
    }

    // @interface AgoraScreenCaptureParameters : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraScreenCaptureParameters
    {
        // @property (assign, nonatomic) CGSize dimensions;
        [Export("dimensions", ArgumentSemantic.Assign)]
        CGSize Dimensions { get; set; }

        // @property (assign, nonatomic) NSInteger frameRate;
        [Export("frameRate")]
        nint FrameRate { get; set; }

        // @property (assign, nonatomic) NSInteger bitrate;
        [Export("bitrate")]
        nint Bitrate { get; set; }

        // @property (assign, nonatomic) BOOL captureMouseCursor;
        [Export("captureMouseCursor")]
        bool CaptureMouseCursor { get; set; }

        // @property (assign, nonatomic) BOOL windowFocus;
        [Export("windowFocus")]
        bool WindowFocus { get; set; }

        //@property (copy, nonatomic) NSArray * _Nullable excludeWindowList;
        [NullAllowed, Export("excludeWindowList", ArgumentSemantic.Copy)]
        NSObject[] ExcludeWindowList { get; set; }
    }


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

    // @interface AgoraLiveStreamAdvancedFeature : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLiveStreamAdvancedFeature
    {
        // @property (copy, nonatomic) NSString * _Nullable featureName;
        [NullAllowed, Export("featureName")]
        string FeatureName { get; set; }

        // @property (assign, nonatomic) BOOL opened;
        [Export("opened")]
        bool Opened { get; set; }
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

    // @interface WatermarkOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface WatermarkOptions
    {
        // @property (assign, nonatomic) BOOL visibleInPreview;
        [Export("visibleInPreview")]
        bool VisibleInPreview { get; set; }

        // @property (assign, nonatomic) CGRect positionInLandscapeMode;
        [Export("positionInLandscapeMode", ArgumentSemantic.Assign)]
        CGRect PositionInLandscapeMode { get; set; }

        // @property (assign, nonatomic) CGRect positionInPortraitMode;
        [Export("positionInPortraitMode", ArgumentSemantic.Assign)]
        CGRect PositionInPortraitMode { get; set; }
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

        // @property (assign, nonatomic) AgoraVideoCodecTypeForStream videoCodecType;
        [Export("videoCodecType", ArgumentSemantic.Assign)]
        VideoCodecTypeForStream VideoCodecType { get; set; }

        // @property (copy, nonatomic) NSArray<AgoraLiveTranscodingUser *> * _Nullable transcodingUsers;
        [NullAllowed, Export("transcodingUsers", ArgumentSemantic.Copy)]
        AgoraLiveTranscodingUser[] TranscodingUsers { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable transcodingExtraInfo;
        [NullAllowed, Export("transcodingExtraInfo")]
        string TranscodingExtraInfo { get; set; }

        // @property (nonatomic, strong) AgoraImage * _Nullable watermark;
        [NullAllowed, Export("watermark", ArgumentSemantic.Strong)]
        AgoraImage Watermark { get; set; }

        // @property (nonatomic, strong) AgoraImage * _Nullable backgroundImage;
        [NullAllowed, Export("backgroundImage", ArgumentSemantic.Strong)]
        AgoraImage BackgroundImage { get; set; }

        // @property (nonatomic, strong) COLOR_CLASS * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        NSColor BackgroundColor { get; set; }

        // @property (assign, nonatomic) AgoraAudioSampleRateType audioSampleRate;
        [Export("audioSampleRate", ArgumentSemantic.Assign)]
        AudioSampleRateType AudioSampleRate { get; set; }

        // @property (assign, nonatomic) NSInteger audioBitrate;
        [Export("audioBitrate")]
        nint AudioBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audioChannels;
        [Export("audioChannels")]
        nint AudioChannels { get; set; }

        // @property (assign, nonatomic) AgoraAudioCodecProfileType audioCodecProfile;
        [Export("audioCodecProfile", ArgumentSemantic.Assign)]
        AudioCodecProfileType AudioCodecProfile { get; set; }

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

        // -(void)setAdvancedFeatures:(NSString *)featureName opened:(BOOL)opened;
        [Export("setAdvancedFeatures:opened:")]
        void SetAdvancedFeatures(string featureName, bool opened);

        // -(NSArray<AgoraLiveStreamAdvancedFeature *> *)getAdvancedFeatures;
        [NullAllowed, Export("getAdvancedFeatures")]
        AgoraLiveStreamAdvancedFeature[] AdvancedFeatures { get; }
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
        CameraCaptureOutputPreference Preference { get; set; }

        // @property (assign, nonatomic) int captureWidth;
        [Export("captureWidth")]
        int CaptureWidth { get; set; }

        // @property (assign, nonatomic) int captureHeight;
        [Export("captureHeight")]
        int CaptureHeight { get; set; }

        // @property (assign, nonatomic) AgoraCameraDirection cameraDirection;
        [Export("cameraDirection")]
        CameraDirection CameraDirection { get; set; }

        // -(instancetype _Nonnull)initWithSize:(CGSize)size facing:(AgoraCameraDirection)facing;
        [Export("initWithSize:facing:")]
        IntPtr Constructor(CGSize size, CameraDirection facing);

        // -(instancetype _Nonnull)initWithWidth:(NSInteger)width height:(NSInteger)height facing:(AgoraCameraDirection)facing;
        [Export("initWithWidth:height:facing:")]
        IntPtr Constructor(nint width, nint height, CameraDirection facing);
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
        CMTime Time { get; set; }

        // @property (assign, nonatomic) int stride __attribute__((deprecated("use strideInPixels instead")));
        [Export("stride")]
        int Stride { get; set; }

        // @property (assign, nonatomic) int strideInPixels;
        [Export("strideInPixels")]
        int StrideInPixels { get; set; }

        // @property (assign, nonatomic) int height;
        [Export("height")]
        int Height { get; set; }

        // @property (assign, nonatomic) CVPixelBufferRef _Nullable textureBuf;
        [NullAllowed, Export("textureBuf", ArgumentSemantic.Assign)]
        unsafe IntPtr TextureBuf { get; set; }

        // @property (nonatomic, strong) NSData * _Nullable dataBuf;
        [NullAllowed, Export("dataBuf", ArgumentSemantic.Strong)]
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

    // @interface AgoraChannelMediaRelayInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraChannelMediaRelayInfo
    {
        // @property (copy, nonatomic) NSString * _Nullable token;
        [NullAllowed, Export("token")]
        string Token { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable channelName;
        [NullAllowed, Export("channelName")]
        string ChannelName { get; set; }

        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // -(instancetype _Nonnull)initWithToken:(NSString * _Nullable)token;
        [Export("initWithToken:")]
        IntPtr Constructor([NullAllowed] string token);
    }

    // @interface AgoraDataStreamConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraDataStreamConfig
    {
        // @property (assign, nonatomic) BOOL ordered;
        [Export("ordered")]
        bool Ordered { get; set; }

        // @property (assign, nonatomic) BOOL syncWithAudio;
        [Export("syncWithAudio")]
        bool SyncWithAudio { get; set; }
    }

    // @interface AgoraChannelMediaRelayConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraChannelMediaRelayConfiguration
    {
        // @property (readonly, nonatomic, strong) NSDictionary<NSString *,AgoraChannelMediaRelayInfo *> * _Nullable destinationInfos;
        [NullAllowed, Export("destinationInfos", ArgumentSemantic.Strong)]
        NSDictionary DestinationInfos { get; }

        // @property (nonatomic, strong) AgoraChannelMediaRelayInfo * _Nonnull sourceInfo;
        [Export("sourceInfo", ArgumentSemantic.Strong)]
        AgoraChannelMediaRelayInfo SourceInfo { get; set; }

        // -(BOOL)setDestinationInfo:(AgoraChannelMediaRelayInfo * _Nonnull)destinationInfo forChannelName:(NSString * _Nonnull)channelName;
        [Export("setDestinationInfo:forChannelName:")]
        bool SetDestinationInfo(AgoraChannelMediaRelayInfo destinationInfo, string channelName);

        // -(BOOL)removeDestinationInfoForChannelName:(NSString * _Nonnull)channelName;
        [Export("removeDestinationInfoForChannelName:")]
        bool RemoveDestinationInfoForChannelName(string channelName);
    }

    // @interface AgoraBeautyOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraBeautyOptions
    {
        // @property (assign, nonatomic) AgoraLighteningContrastLevel lighteningContrastLevel;
        [Export("lighteningContrastLevel", ArgumentSemantic.Assign)]
        LighteningContrastLevel LighteningContrastLevel { get; set; }

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

    // @interface AgoraUserInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraUserInfo
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable userAccount;
        [NullAllowed, Export("userAccount")]
        string UserAccount { get; set; }
    }

    // @interface AgoraRtcChannelMediaOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcChannelMediaOptions
    {
        // @property (assign, nonatomic) BOOL autoSubscribeAudio;
        [Export("autoSubscribeAudio")]
        bool AutoSubscribeAudio { get; set; }

        // @property (assign, nonatomic) BOOL autoSubscribeVideo;
        [Export("autoSubscribeVideo")]
        bool AutoSubscribeVideo { get; set; }
    }

    // @interface AgoraFacePositionInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraFacePositionInfo
    {
        // @property (assign, nonatomic) NSInteger x;
        [Export("x")]
        nint X { get; set; }

        // @property (assign, nonatomic) NSInteger y;
        [Export("y")]
        nint Y { get; set; }

        // @property (assign, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (assign, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }
    }

    // @interface AgoraLogConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraLogConfig
    {
        // @property (copy, nonatomic) NSString * _Nullable filePath;
        [NullAllowed, Export("filePath")]
        string FilePath { get; set; }

        // @property (assign, nonatomic) NSInteger fileSize;
        [Export("fileSize")]
        nint FileSize { get; set; }

        // @property (assign, nonatomic) AgoraLogLevel level;
        [Export("level", ArgumentSemantic.Assign)]
        AgoraLogLevel Level { get; set; }
    }

    // @interface AgoraRtcEngineConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcEngineConfig
    {
        // @property (copy, nonatomic) NSString * _Nullable appId;
        [NullAllowed, Export("appId")]
        string AppId { get; set; }

        // @property (assign, nonatomic) NSUInteger areaCode;
        [Export("areaCode")]
        nuint AreaCode { get; set; }

        // @property (nonatomic, strong) AgoraLogConfig * _Nullable logConfig;
        [NullAllowed, Export("logConfig", ArgumentSemantic.Strong)]
        AgoraLogConfig LogConfig { get; set; }
    }

    // @interface AgoraEncryptionConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraEncryptionConfig
    {
        // @property (assign, nonatomic) AgoraEncryptionMode encryptionMode;
        [Export("encryptionMode", ArgumentSemantic.Assign)]
        EncryptionMode EncryptionMode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable encryptionKey;
        [NullAllowed, Export("encryptionKey")]
        string EncryptionKey { get; set; }
    }

    // @interface AgoraClientRoleOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraClientRoleOptions
    {
        // @property (assign, nonatomic) AgoraAudienceLatencyLevelType audienceLatencyLevel;
        [Export("audienceLatencyLevel", ArgumentSemantic.Assign)]
        AudienceLatencyLevelType AudienceLatencyLevel { get; set; }
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

    // @protocol AgoraVideoSourceProtocol <NSObject>
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
        ////[Verify(MethodToProperty)]
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
        ////[Verify(MethodToProperty)]
        VideoBufferType BufferType { get; }

        // @required -(AgoraVideoCaptureType)captureType;
        [Abstract]
        [Export("captureType")]
        VideoCaptureType CaptureType { get; }

        // @required -(AgoraVideoContentHint)contentHint;
        [Abstract]
        [Export("contentHint")]
        VideoContentHint ContentHint { get; }
    }

    // @protocol AgoraVideoSinkProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraVideoSinkProtocol
    {
        // @required -(BOOL)shouldInitialize;
        [Abstract]
        [Export("shouldInitialize")]
        //[Verify(MethodToProperty)]
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
        //[Verify(MethodToProperty)]
        VideoBufferType BufferType { get; }

        // @required -(AgoraVideoPixelFormat)pixelFormat;
        [Abstract]
        [Export("pixelFormat")]
        //[Verify(MethodToProperty)]
        VideoPixelFormat PixelFormat { get; }

        // @optional -(void)renderPixelBuffer:(CVPixelBufferRef _Nonnull)pixelBuffer rotation:(AgoraVideoRotation)rotation;
        [Export("renderPixelBuffer:rotation:")]
        unsafe void RenderPixelBuffer(IntPtr pixelBuffer, VideoRotation rotation);

        // @optional -(void)renderRawData:(void * _Nonnull)rawData size:(CGSize)size rotation:(AgoraVideoRotation)rotation;
        [Export("renderRawData:size:rotation:")]
        unsafe void RenderRawData(IntPtr rawData, CGSize size, VideoRotation rotation);
    }
    [Protocol]
    interface IAgoraVideoSourceProtocol
    {
    }

    // @interface AgoraRtcDefaultCamera : NSObject <AgoraVideoSourceProtocol>
    [BaseType(typeof(NSObject))]
    interface AgoraRtcDefaultCamera : IAgoraVideoSourceProtocol
    {
        // @property (assign, nonatomic) AgoraRtcDefaultCameraPosition position;
        [Export("position", ArgumentSemantic.Assign)]
        RtcDefaultCameraPosition Position { get; set; }

        // -(instancetype _Nonnull)initWithPosition:(AgoraRtcDefaultCameraPosition)position;
        [Export("initWithPosition:")]
        IntPtr Constructor(RtcDefaultCameraPosition position);
    }

    [Protocol]
    interface IAgoraVideoSinkProtocol
    {
    }

    // @interface AgoraRtcDefaultRenderer : NSObject <AgoraVideoSinkProtocol>
    [BaseType(typeof(NSObject))]
    interface AgoraRtcDefaultRenderer : IAgoraVideoSinkProtocol
    {
        // @property (readonly, nonatomic, strong) VIEW_CLASS * _Nonnull view;
        [Export("view", ArgumentSemantic.Strong)]
        NSView View { get; }

        // @property (assign, nonatomic) AgoraVideoRenderMode mode;
        [Export("mode", ArgumentSemantic.Assign)]
        VideoRenderMode Mode { get; set; }

        // -(instancetype _Nonnull)initWithView:(VIEW_CLASS * _Nonnull)view renderMode:(AgoraVideoRenderMode)mode;
        [Export("initWithView:renderMode:")]
        IntPtr Constructor(NSView view, VideoRenderMode mode);
    }

    // @protocol AgoraMediaMetadataDataSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraMediaMetadataDataSource
    {
        // @required -(NSInteger)metadataMaxSize;
        [Abstract]
        [Export("metadataMaxSize")]
        nint MetadataMaxSize { get; }

        // @required -(NSData * _Nullable)readyToSendMetadataAtTimestamp:(NSTimeInterval)timestamp;
        [Abstract]
        [Export("readyToSendMetadataAtTimestamp:")]
        [return: NullAllowed]
        NSData ReadyToSendMetadataAtTimestamp(double timestamp);
    }

    // @protocol AgoraMediaMetadataDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraMediaMetadataDelegate
    {
        // @required -(void)receiveMetadata:(NSData * _Nonnull)data fromUser:(NSInteger)uid atTimestamp:(NSTimeInterval)timestamp;
        [Abstract]
        [Export("receiveMetadata:fromUser:atTimestamp:")]
        void FromUser(NSData data, nint uid, double timestamp);
    }

    // @protocol AgoraAudioFrameDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraAudioFrameDelegate
    {
        // @required -(BOOL)onRecordAudioFrame:(AgoraAudioFrame * _Nonnull)frame;
        [Abstract]
        [Export("onRecordAudioFrame:")]
        bool OnRecordAudioFrame(AgoraAudioFrame frame);

        // @required -(BOOL)onPlaybackAudioFrame:(AgoraAudioFrame * _Nonnull)frame;
        [Abstract]
        [Export("onPlaybackAudioFrame:")]
        bool OnPlaybackAudioFrame(AgoraAudioFrame frame);

        // @required -(BOOL)onMixedAudioFrame:(AgoraAudioFrame * _Nonnull)frame;
        [Abstract]
        [Export("onMixedAudioFrame:")]
        bool OnMixedAudioFrame(AgoraAudioFrame frame);

        // @required -(BOOL)onPlaybackAudioFrameBeforeMixing:(AgoraAudioFrame * _Nonnull)frame uid:(NSUInteger)uid;
        [Abstract]
        [Export("onPlaybackAudioFrameBeforeMixing:uid:")]
        bool OnPlaybackAudioFrameBeforeMixing(AgoraAudioFrame frame, nuint uid);
    }

    // @protocol AgoraRtcEngineDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraRtcEngineDelegate
    {
        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOccurWarning:(AgoraWarningCode)warningCode;
        [Export("rtcEngine:didOccurWarning:")]
        [EventArgs("DidOccurWarning")]
        void DidOccurWarning(AgoraRtcEngineKit engine, WarningCode warningCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOccurError:(AgoraErrorCode)errorCode;
        [Export("rtcEngine:didOccurError:")]
        [EventArgs("DidOccurError")]
        void DidOccurError(AgoraRtcEngineKit engine, ErrorCode errorCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didApiCallExecute:(NSInteger)error api:(NSString * _Nonnull)api result:(NSString * _Nonnull)result;
        [Export("rtcEngine:didApiCallExecute:api:result:")]
        [EventArgs("DidApiCallExecute")]
        void DidApiCallExecute(AgoraRtcEngineKit engine, nint error, string api, string result);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didJoinChannel:(NSString * _Nonnull)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinChannel:withUid:elapsed:")]
        [EventArgs("DidJoinChannel")]
        void DidJoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didRejoinChannel:(NSString * _Nonnull)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didRejoinChannel:withUid:elapsed:")]
        [EventArgs("DidRejoinChannel")]
        void DidRejoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLeaveChannelWithStats:(AgoraChannelStats * _Nonnull)stats;
        [Export("rtcEngine:didLeaveChannelWithStats:")]
        [EventArgs("DidLeaveChannelWithStats")]
        void DidLeaveChannelWithStats(AgoraRtcEngineKit engine, AgoraChannelStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didRegisteredLocalUser:(NSString * _Nonnull)userAccount withUid:(NSUInteger)uid;
        [Export("rtcEngine:didRegisteredLocalUser:withUid:")]
        [EventArgs("DidRegisteredLocalUser")]
        void DidRegisteredLocalUser(AgoraRtcEngineKit engine, string userAccount, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didUpdatedUserInfo:(AgoraUserInfo * _Nonnull)userInfo withUid:(NSUInteger)uid;
        [Export("rtcEngine:didUpdatedUserInfo:withUid:")]
        [EventArgs("DidUpdatedUserInfo")]
        void DidUpdatedUserInfo(AgoraRtcEngineKit engine, AgoraUserInfo userInfo, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didClientRoleChanged:(AgoraClientRole)oldRole newRole:(AgoraClientRole)newRole;
        [Export("rtcEngine:didClientRoleChanged:newRole:")]
        [EventArgs("DidClientRoleChanged")]
        void DidClientRoleChanged(AgoraRtcEngineKit engine, ClientRole oldRole, ClientRole newRole);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didJoinedOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinedOfUid:elapsed:")]
        [EventArgs("DidJoinedOfUid")]
        void DidJoinedOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOfflineOfUid:(NSUInteger)uid reason:(AgoraUserOfflineReason)reason;
        [Export("rtcEngine:didOfflineOfUid:reason:")]
        [EventArgs("DidOfflineOfUid")]
        void DidOfflineOfUid(AgoraRtcEngineKit engine, nuint uid, UserOfflineReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine connectionChangedToState:(AgoraConnectionStateType)state reason:(AgoraConnectionChangedReason)reason;
        [Export("rtcEngine:connectionChangedToState:reason:")]
        [EventArgs("connectionChangedToState")]
        void ConnectionChangedToState(AgoraRtcEngineKit engine, ConnectionStateType state, ConnectionChangedReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine networkTypeChangedToType:(AgoraNetworkType)type;
        [Export("rtcEngine:networkTypeChangedToType:")]
        [EventArgs("NetworkTypeChangedToType")]
        void NetworkTypeChangedToType(AgoraRtcEngineKit engine, NetworkType type);

        // @optional -(void)rtcEngineConnectionDidLost:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidLost:")]
        [EventArgs("RtcEngineConnectionDidLost")]
        void RtcEngineConnectionDidLost(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine tokenPrivilegeWillExpire:(NSString * _Nonnull)token;
        [Export("rtcEngine:tokenPrivilegeWillExpire:")]
        [EventArgs("TokenPrivilegeWillExpire")]
        void TokenPrivilegeWillExpire(AgoraRtcEngineKit engine, string token);

        // @optional -(void)rtcEngineRequestToken:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRequestToken:")]
        [EventArgs("RtcEngineRequestToken")]
        void RtcEngineRequestToken(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine reportAudioVolumeIndicationOfSpeakers:(NSArray<AgoraRtcAudioVolumeInfo *> * _Nonnull)speakers totalVolume:(NSInteger)totalVolume;
        [Export("rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:")]
        [EventArgs("ReportAudioVolumeIndicationOfSpeakers")]
        void ReportAudioVolumeIndicationOfSpeakers(AgoraRtcEngineKit engine, AgoraRtcAudioVolumeInfo[] speakers, nint totalVolume);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine activeSpeaker:(NSUInteger)speakerUid;
        [Export("rtcEngine:activeSpeaker:")]
        [EventArgs("OnActiveSpeaker")]
        void ActiveSpeaker(AgoraRtcEngineKit engine, nuint speakerUid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstLocalAudioFramePublished:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalAudioFramePublished:")]
        [EventArgs("FirstLocalAudioFramePublished")]
        void FirstLocalAudioFramePublished(AgoraRtcEngineKit engine, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstLocalVideoFrameWithSize:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalVideoFrameWithSize:elapsed:")]
        [EventArgs("FirstLocalVideoFrameWithSize")]
        void FirstLocalVideoFrameWithSize(AgoraRtcEngineKit engine, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstLocalVideoFramePublished:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalVideoFramePublished:")]
        [EventArgs("FirstLocalVideoFramePublished")]
        void FirstLocalVideoFramePublished(AgoraRtcEngineKit engine, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine videoSizeChangedOfUid:(NSUInteger)uid size:(CGSize)size rotation:(NSInteger)rotation;
        [Export("rtcEngine:videoSizeChangedOfUid:size:rotation:")]
        [EventArgs("VideoSizeChangedOfUid")]
        void VideoSizeChangedOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint rotation);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteVideoStateChangedOfUid:(NSUInteger)uid state:(AgoraVideoRemoteState)state reason:(AgoraVideoRemoteStateReason)reason elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:remoteVideoStateChangedOfUid:state:reason:elapsed:")]
        [EventArgs("RemoteVideoStateChangedOfUid2")]
        void RemoteVideoStateChangedOfUid2(AgoraRtcEngineKit engine, nuint uid, VideoRemoteState state, VideoRemoteStateReason reason, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine superResolutionEnabledOfUid:(NSUInteger)uid enabled:(BOOL)enabled reason:(AgoraSuperResolutionStateReason)reason;
        [Export("rtcEngine:superResolutionEnabledOfUid:enabled:reason:")]
        [EventArgs("SuperResolutionEnabledOfUid")]
        void SuperResolutionEnabledOfUid(AgoraRtcEngineKit engine, nuint uid, bool enabled, SuperResolutionStateReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localVideoStateChange:(AgoraLocalVideoStreamState)state error:(AgoraLocalVideoStreamError)error;
        [Export("rtcEngine:localVideoStateChange:error:")]
        [EventArgs("LocalVideoStateChange")]
        void LocalVideoStateChange(AgoraRtcEngineKit engine, LocalVideoStreamState state, LocalVideoStreamError error);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteAudioStateChangedOfUid:(NSUInteger)uid state:(AgoraAudioRemoteState)state reason:(AgoraAudioRemoteStateReason)reason elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:remoteAudioStateChangedOfUid:state:reason:elapsed:")]
        [EventArgs("RemoteAudioStateChangedOfUid")]
        void RemoteAudioStateChangedOfUid(AgoraRtcEngineKit engine, nuint uid, AudioRemoteState state, AudioRemoteStateReason reason, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localAudioStateChange:(AgoraAudioLocalState)state error:(AgoraAudioLocalError)error;
        [Export("rtcEngine:localAudioStateChange:error:")]
        [EventArgs("LocalAudioStateChange")]
        void LocalAudioStateChange(AgoraRtcEngineKit engine, AudioLocalState state, AudioLocalError error);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteVideoFrameOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:")]
        [EventArgs("FirstRemoteVideoFrameOfUid")]
        void FirstRemoteVideoFrameOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didAudioPublishStateChange:(NSString * _Nonnull)channel oldState:(AgoraStreamPublishState)oldState newState:(AgoraStreamPublishState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcEngine:didAudioPublishStateChange:oldState:newState:elapseSinceLastState:")]
        [EventArgs("DidAudioPublishStateChange")]
        void DidAudioPublishStateChange(AgoraRtcEngineKit engine, string channel, StreamPublishState oldState, StreamPublishState newState, nint elapseSinceLastState);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didVideoPublishStateChange:(NSString * _Nonnull)channel oldState:(AgoraStreamPublishState)oldState newState:(AgoraStreamPublishState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcEngine:didVideoPublishStateChange:oldState:newState:elapseSinceLastState:")]
        [EventArgs("DidVideoPublishStateChange")]
        void DidVideoPublishStateChange(AgoraRtcEngineKit engine, string channel, StreamPublishState oldState, StreamPublishState newState, nint elapseSinceLastState);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didAudioSubscribeStateChange:(NSString * _Nonnull)channel withUid:(NSUInteger)uid oldState:(AgoraStreamSubscribeState)oldState newState:(AgoraStreamSubscribeState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcEngine:didAudioSubscribeStateChange:withUid:oldState:newState:elapseSinceLastState:")]
        [EventArgs("DidAudioSubscribeStateChange")]
        void DidAudioSubscribeStateChange(AgoraRtcEngineKit engine, string channel, nuint uid, StreamSubscribeState oldState, StreamSubscribeState newState, nint elapseSinceLastState);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didVideoSubscribeStateChange:(NSString * _Nonnull)channel withUid:(NSUInteger)uid oldState:(AgoraStreamSubscribeState)oldState newState:(AgoraStreamSubscribeState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcEngine:didVideoSubscribeStateChange:withUid:oldState:newState:elapseSinceLastState:")]
        [EventArgs("DidVideoSubscribeStateChange")]
        void DidVideoSubscribeStateChange(AgoraRtcEngineKit engine, string channel, nuint uid, StreamSubscribeState oldState, StreamSubscribeState newState, nint elapseSinceLastState);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didVideoMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoMuted:byUid:")]
        [EventArgs("DidVideoMuted")]
        void DidVideoMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLocalPublishFallbackToAudioOnly:(BOOL)isFallbackOrRecover;
        [Export("rtcEngine:didLocalPublishFallbackToAudioOnly:")]
        [EventArgs("DidLocalPublishFallbackToAudioOnly")]
        void DidLocalPublishFallbackToAudioOnly(AgoraRtcEngineKit engine, bool isFallbackOrRecover);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didRemoteSubscribeFallbackToAudioOnly:(BOOL)isFallbackOrRecover byUid:(NSUInteger)uid;
        [Export("rtcEngine:didRemoteSubscribeFallbackToAudioOnly:byUid:")]
        [EventArgs("DidRemoteSubscribeFallbackToAudioOnly")]
        void DidRemoteSubscribeFallbackToAudioOnly(AgoraRtcEngineKit engine, bool isFallbackOrRecover, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine facePositionDidChangeWidth:(int)width previewHeight:(int)height faces:(NSArray<AgoraFacePositionInfo *> * _Nullable)faces;
        [Export("rtcEngine:facePositionDidChangeWidth:previewHeight:faces:")]
        [EventArgs("FacePositionDidChangeWidth")]
        void FacePositionDidChangeWidth(AgoraRtcEngineKit engine, int width, int height, [NullAllowed] AgoraFacePositionInfo[] faces);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didAudioRouteChanged:(AgoraAudioOutputRouting)routing;
        [Export("rtcEngine:didAudioRouteChanged:")]
        [EventArgs("DidAudioRouteChanged")]
        void DidAudioRouteChanged(AgoraRtcEngineKit engine, AudioOutputRouting routing);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine cameraFocusDidChangedToRect:(CGRect)rect;
        [Export("rtcEngine:cameraFocusDidChangedToRect:")]
        [EventArgs("CameraFocusDidChangedToRect")]
        void CameraFocusDidChangedToRect(AgoraRtcEngineKit engine, CGRect rect);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine cameraExposureDidChangedToRect:(CGRect)rect;
        [Export("rtcEngine:cameraExposureDidChangedToRect:")]
        [EventArgs("CameraExposureDidChangedToRect")]
        void CameraExposureDidChangedToRect(AgoraRtcEngineKit engine, CGRect rect);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine reportRtcStats:(AgoraChannelStats * _Nonnull)stats;
        [Export("rtcEngine:reportRtcStats:")]
        [EventArgs("ReportRtcStats")]
        void ReportRtcStats(AgoraRtcEngineKit engine, AgoraChannelStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine lastmileQuality:(AgoraNetworkQuality)quality;
        [Export("rtcEngine:lastmileQuality:")]
        [EventArgs("LastmileQuality")]
        void LastmileQuality(AgoraRtcEngineKit engine, NetworkQuality quality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine networkQuality:(NSUInteger)uid txQuality:(AgoraNetworkQuality)txQuality rxQuality:(AgoraNetworkQuality)rxQuality;
        [Export("rtcEngine:networkQuality:txQuality:rxQuality:")]
        [EventArgs("NetwokQuality")]
        void NetwokQuality(AgoraRtcEngineKit engine, nuint uid, NetworkQuality txQuality, NetworkQuality rxQuality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine lastmileProbeTestResult:(AgoraLastmileProbeResult * _Nonnull)result;
        [Export("rtcEngine:lastmileProbeTestResult:")]
        [EventArgs("LastmileProbeTestResult")]
        void LastmileProbeTestResult(AgoraRtcEngineKit engine, AgoraLastmileProbeResult result);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localVideoStats:(AgoraRtcLocalVideoStats * _Nonnull)stats;
        [Export("rtcEngine:localVideoStats:")]
        [EventArgs("LocalVideoStats")]
        void LocalVideoStats(AgoraRtcEngineKit engine, AgoraRtcLocalVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localAudioStats:(AgoraRtcLocalAudioStats * _Nonnull)stats;
        [Export("rtcEngine:localAudioStats:")]
        [EventArgs("LocalAudioStats")]
        void LocalAudioStats(AgoraRtcEngineKit engine, AgoraRtcLocalAudioStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteVideoStats:(AgoraRtcRemoteVideoStats * _Nonnull)stats;
        [Export("rtcEngine:remoteVideoStats:")]
        [EventArgs("RemoteVideoStats")]
        void RemoteVideoStats(AgoraRtcEngineKit engine, AgoraRtcRemoteVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteAudioStats:(AgoraRtcRemoteAudioStats * _Nonnull)stats;
        [Export("rtcEngine:remoteAudioStats:")]
        [EventArgs("RemoteAudioStats")]
        void RemoteAudioStats(AgoraRtcEngineKit engine, AgoraRtcRemoteAudioStats stats);

        // @optional -(void)rtcEngineLocalAudioMixingDidFinish:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineLocalAudioMixingDidFinish:")]
        [EventArgs("RtcEngineLocalAudioMixingDidFinish")]
        void RtcEngineLocalAudioMixingDidFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localAudioMixingStateDidChanged:(AgoraAudioMixingStateCode)state errorCode:(AgoraAudioMixingErrorCode)errorCode;
        [Export("rtcEngine:localAudioMixingStateDidChanged:errorCode:")]
        [EventArgs("LocalAudioMixingStateDidChanged")]
        void LocalAudioMixingStateDidChanged(AgoraRtcEngineKit engine, AudioMixingStateCode state, AudioMixingErrorCode errorCode);

        // @optional -(void)rtcEngineRemoteAudioMixingDidStart:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRemoteAudioMixingDidStart:")]
        [EventArgs("RtcEngineRemoteAudioMixingDidStart")]
        void RtcEngineRemoteAudioMixingDidStart(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineRemoteAudioMixingDidFinish:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRemoteAudioMixingDidFinish:")]
        [EventArgs("RtcEngineRemoteAudioMixingDidFinish")]
        void RtcEngineRemoteAudioMixingDidFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineDidAudioEffectFinish:(AgoraRtcEngineKit * _Nonnull)engine soundId:(NSInteger)soundId;
        [Export("rtcEngineDidAudioEffectFinish:soundId:")]
        [EventArgs("RtcEngineDidAudioEffectFinish")]
        void RtcEngineDidAudioEffectFinish(AgoraRtcEngineKit engine, nint soundId);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine rtmpStreamingChangedToState:(NSString * _Nonnull)url state:(AgoraRtmpStreamingState)state errorCode:(AgoraRtmpStreamingErrorCode)errorCode;
        [Export("rtcEngine:rtmpStreamingChangedToState:state:errorCode:")]
        [EventArgs("RtmpStreamingChangedToState")]
        void RtmpStreamingChangedToState(AgoraRtcEngineKit engine, string url, RtmpStreamingState state, RtmpStreamingErrorCode errorCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine rtmpStreamingEventWithUrl:(NSString * _Nonnull)url eventCode:(AgoraRtmpStreamingEvent)eventCode;
        [Export("rtcEngine:rtmpStreamingEventWithUrl:eventCode:")]
        [EventArgs("RtmpStreamingEventWithUrl")]
        void RtmpStreamingEventWithUrl(AgoraRtcEngineKit engine, string url, RtmpStreamingEvent eventCode);

        // @optional -(void)rtcEngineTranscodingUpdated:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineTranscodingUpdated:")]
        [EventArgs("RtcEngineTranscodingUpdated")]
        void RtcEngineTranscodingUpdated(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamInjectedStatusOfUrl:(NSString * _Nonnull)url uid:(NSUInteger)uid status:(AgoraInjectStreamStatus)status;
        [Export("rtcEngine:streamInjectedStatusOfUrl:uid:status:")]
        [EventArgs("StreamInjectedStatusOfUrl")]
        void StreamInjectedStatusOfUrl(AgoraRtcEngineKit engine, string url, nuint uid, InjectStreamStatus status);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine receiveStreamMessageFromUid:(NSUInteger)uid streamId:(NSInteger)streamId data:(NSData * _Nonnull)data;
        [Export("rtcEngine:receiveStreamMessageFromUid:streamId:data:")]
        [EventArgs("ReceiveStreamMessageFromUid")]
        void ReceiveStreamMessageFromUid(AgoraRtcEngineKit engine, nuint uid, nint streamId, NSData data);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOccurStreamMessageErrorFromUid:(NSUInteger)uid streamId:(NSInteger)streamId error:(NSInteger)error missed:(NSInteger)missed cached:(NSInteger)cached;
        [Export("rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:")]
        [EventArgs("DidOccurStreamMessageErrorFromUid")]
        void DidOccurStreamMessageErrorFromUid(AgoraRtcEngineKit engine, nuint uid, nint streamId, nint error, nint missed, nint cached);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine uploadLogResultRequestId:(NSString * _Nonnull)requestId success:(BOOL)success reason:(AgoraUploadErrorReason)reason;
        [Export("rtcEngine:uploadLogResultRequestId:success:reason:")]
        [EventArgs("UploadLogResultRequestId")]
        void UploadLogResultRequestId(AgoraRtcEngineKit engine, string requestId, bool success, UploadErrorReason reason);

        // @optional -(void)rtcEngineMediaEngineDidLoaded:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineMediaEngineDidLoaded:")]
        [EventArgs("RtcEngineMediaEngineDidLoaded")]
        void RtcEngineMediaEngineDidLoaded(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineMediaEngineDidStartCall:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineMediaEngineDidStartCall:")]
        [EventArgs("RtcEngineMediaEngineDidStartCall")]
        void RtcEngineMediaEngineDidStartCall(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine channelMediaRelayStateDidChange:(AgoraChannelMediaRelayState)state error:(AgoraChannelMediaRelayError)error;
        [Export("rtcEngine:channelMediaRelayStateDidChange:error:")]
        [EventArgs("ChannelMediaRelayStateDidChange")]
        void ChannelMediaRelayStateDidChange(AgoraRtcEngineKit engine, ChannelMediaRelayState state, ChannelMediaRelayError error);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didReceiveChannelMediaRelayEvent:(AgoraChannelMediaRelayEvent)event;
        [Export("rtcEngine:didReceiveChannelMediaRelayEvent:")]
        [EventArgs("DidReceiveChannelMediaRelayEvent")]
        void DidReceiveChannelMediaRelayEvent(AgoraRtcEngineKit engine, ChannelMediaRelayEvent e);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstLocalAudioFrame:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalAudioFrame:")]
        [EventArgs("FirstLocalAudioFrame")]
        void FirstLocalAudioFrame(AgoraRtcEngineKit engine, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteAudioFrameOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteAudioFrameOfUid:elapsed:")]
        [EventArgs("FirstRemoteAudioFrameOfUid")]
        void FirstRemoteAudioFrameOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteAudioFrameDecodedOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteAudioFrameDecodedOfUid:elapsed:")]
        [EventArgs("FirstRemoteAudioFrameDecodedOfUid")]
        void FirstRemoteAudioFrameDecodedOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didAudioMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didAudioMuted:byUid:")]
        [EventArgs("DidAudioMuted")]
        void DidAudioMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamPublishedWithUrl:(NSString * _Nonnull)url errorCode:(AgoraErrorCode)errorCode;
        [Export("rtcEngine:streamPublishedWithUrl:errorCode:")]
        [EventArgs("StreamPublishedWithUrl")]
        void StreamPublishedWithUrl(AgoraRtcEngineKit engine, string url, ErrorCode errorCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamUnpublishedWithUrl:(NSString * _Nonnull)url;
        [Export("rtcEngine:streamUnpublishedWithUrl:")]
        [EventArgs("StreamUnpublishedWithUrl")]
        void StreamUnpublishedWithUrl(AgoraRtcEngineKit engine, string url);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine audioTransportStatsOfUid:(NSUInteger)uid delay:(NSUInteger)delay lost:(NSUInteger)lost rxKBitRate:(NSUInteger)rxKBitRate;
        [Export("rtcEngine:audioTransportStatsOfUid:delay:lost:rxKBitRate:")]
        [EventArgs("AudioTransportStatsOfUid")]
        void AudioTransportStatsOfUid(AgoraRtcEngineKit engine, nuint uid, nuint delay, nuint lost, nuint rxKBitRate);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine videoTransportStatsOfUid:(NSUInteger)uid delay:(NSUInteger)delay lost:(NSUInteger)lost rxKBitRate:(NSUInteger)rxKBitRate;
        [Export("rtcEngine:videoTransportStatsOfUid:delay:lost:rxKBitRate:")]
        [EventArgs("VideoTransportStatsOfUid")]
        void VideoTransportStatsOfUid(AgoraRtcEngineKit engine, nuint uid, nuint delay, nuint lost, nuint rxKBitRate);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoEnabled:byUid:")]
        [EventArgs("DidVideoEnabled")]
        void DidVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLocalVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didLocalVideoEnabled:byUid:")]
        [EventArgs("DidLocalVideoEnabled")]
        void DidLocalVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteVideoDecodedOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:")]
        [EventArgs("FirstRemoteVideoDecodedOfUid")]
        void FirstRemoteVideoDecodedOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didMicrophoneEnabled:(BOOL)enabled;
        [Export("rtcEngine:didMicrophoneEnabled:")]
        [EventArgs("DidMicrophoneEnabled")]
        void DidMicrophoneEnabled(AgoraRtcEngineKit engine, bool enabled);

        // @optional -(void)rtcEngineConnectionDidInterrupted:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidInterrupted:")]
        [EventArgs("RtcEngineConnectionDidInterrupted")]
        void RtcEngineConnectionDidInterrupted(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidBanned:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidBanned:")]
        [EventArgs("RtcEngineConnectionDidBanned")]
        void RtcEngineConnectionDidBanned(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine audioQualityOfUid:(NSUInteger)uid quality:(AgoraNetworkQuality)quality delay:(NSUInteger)delay lost:(NSUInteger)lost;
        [Export("rtcEngine:audioQualityOfUid:quality:delay:lost:")]
        [EventArgs("AudioQualityOfUid")]
        void AudioQualityOfUid(AgoraRtcEngineKit engine, nuint uid, NetworkQuality quality, nuint delay, nuint lost);

        // @optional -(void)rtcEngineCameraDidReady:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineCameraDidReady:")]
        [EventArgs("RtcEngineCameraDidReady")]
        void RtcEngineCameraDidReady(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineVideoDidStop:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineVideoDidStop:")]
        [EventArgs("RtcEngineVideoDidStop")]
        void RtcEngineVideoDidStop(AgoraRtcEngineKit engine);
    }

    // @interface AgoraRtcEngineKit : NSObject
    [BaseType(typeof(NSObject),
        Delegates = new string[] { "WeakDelegate" },
        Events = new Type[] { typeof(AgoraRtcEngineDelegate) })]
    interface AgoraRtcEngineKit
    {
        // +(instancetype _Nonnull)sharedEngineWithAppId:(NSString * _Nonnull)appId delegate:(id<AgoraRtcEngineDelegate> _Nullable)delegate;
        [Static]
        [Export("sharedEngineWithAppId:delegate:")]
        AgoraRtcEngineKit SharedEngineWithAppId(string appId, [NullAllowed] AgoraRtcEngineDelegate @delegate);

        // +(instancetype _Nonnull)sharedEngineWithConfig:(AgoraRtcEngineConfig * _Nonnull)config delegate:(id<AgoraRtcEngineDelegate> _Nullable)delegate;
        [Static]
        [Export("sharedEngineWithConfig:delegate:")]
        AgoraRtcEngineKit SharedEngineWithConfig(AgoraRtcEngineConfig config, [NullAllowed] AgoraRtcEngineDelegate @delegate);

        // +(void)destroy;
        [Static]
        [Export("destroy")]
        void Destroy();

        // -(int)setChannelProfile:(AgoraChannelProfile)profile;
        [Export("setChannelProfile:")]
        int SetChannelProfile(ChannelProfile profile);

        // -(int)setClientRole:(AgoraClientRole)role;
        [Export("setClientRole:")]
        int SetClientRole(ClientRole role);

        // -(int)setClientRole:(AgoraClientRole)role options:(AgoraClientRoleOptions * _Nullable)options;
        [Export("setClientRole:options:")]
        int SetClientRole(ClientRole role, [NullAllowed] AgoraClientRoleOptions options);

        // -(int)joinChannelByToken:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId info:(NSString * _Nullable)info uid:(NSUInteger)uid joinSuccess:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))joinSuccessBlock;
        [Export("joinChannelByToken:channelId:info:uid:joinSuccess:")]
        int JoinChannelByToken([NullAllowed] string token, string channelId, [NullAllowed] string info, nuint uid, [NullAllowed] Action<NSString, nuint, nint> joinSuccessBlock);

        // -(int)joinChannelByToken:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId info:(NSString * _Nullable)info uid:(NSUInteger)uid options:(AgoraRtcChannelMediaOptions * _Nonnull)options;
        [Export("joinChannelByToken:channelId:info:uid:options:")]
        int JoinChannelByToken([NullAllowed] string token, string channelId, [NullAllowed] string info, nuint uid, AgoraRtcChannelMediaOptions options);

        // -(int)joinChannelByUserAccount:(NSString * _Nonnull)userAccount token:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId joinSuccess:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))joinSuccessBlock;
        [Export("joinChannelByUserAccount:token:channelId:joinSuccess:")]
        int JoinChannelByUserAccount(string userAccount, [NullAllowed] string token, string channelId, [NullAllowed] Action<NSString, nuint, nint> joinSuccessBlock);

        // -(int)joinChannelByUserAccount:(NSString * _Nonnull)userAccount token:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId options:(AgoraRtcChannelMediaOptions * _Nonnull)options;
        [Export("joinChannelByUserAccount:token:channelId:options:")]
        int JoinChannelByUserAccount(string userAccount, [NullAllowed] string token, string channelId, AgoraRtcChannelMediaOptions options);

        // -(int) registerLocalUserAccount:(NSString* _Nonnull) userAccount appId:(NSString* _Nonnull) appId;
        [Export("registerLocalUserAccount:appId:")]
        int RegisterLocalUserAccount(string userAccount, string appId);

        // -(AgoraUserInfo * _Nullable)getUserInfoByUserAccount:(NSString * _Nonnull)userAccount withError:(AgoraErrorCode * _Nullable)error;
        [Export("getUserInfoByUserAccount:withError:")]
        [return: NullAllowed]
        unsafe AgoraUserInfo GetUserInfoByUserAccount(string userAccount, [NullAllowed] ErrorCode error);

        // -(AgoraUserInfo * _Nullable)getUserInfoByUid:(NSUInteger)uid withError:(AgoraErrorCode * _Nullable)error;
        [Export("getUserInfoByUid:withError:")]
        [return: NullAllowed]
        unsafe AgoraUserInfo GetUserInfoByUid(nuint uid, [NullAllowed] ErrorCode error);

        // -(int)switchChannelByToken:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId joinSuccess:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))joinSuccessBlock;
        [Export("switchChannelByToken:channelId:joinSuccess:")]
        int SwitchChannelByToken([NullAllowed] string token, string channelId, [NullAllowed] Action<NSString, nuint, nint> joinSuccessBlock);

        // -(int)switchChannelByToken:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId options:(AgoraRtcChannelMediaOptions * _Nonnull)options;
        [Export("switchChannelByToken:channelId:options:")]
        int SwitchChannelByToken([NullAllowed] string token, string channelId, AgoraRtcChannelMediaOptions options);

        // -(int)leaveChannel:(void (^ _Nullable)(AgoraChannelStats * _Nonnull))leaveChannelBlock;
        [Export("leaveChannel:")]
        int LeaveChannel([NullAllowed] Action<AgoraChannelStats> leaveChannelBlock);

        // -(int)renewToken:(NSString * _Nonnull)token;
        [Export("renewToken:")]
        int RenewToken(string token);

        // -(AgoraConnectionStateType)getConnectionState;
        [Export("getConnectionState")]
        ConnectionStateType ConnectionState { get; }

        // -(int)startChannelMediaRelay:(AgoraChannelMediaRelayConfiguration * _Nonnull)config;
        [Export("startChannelMediaRelay:")]
        int StartChannelMediaRelay(AgoraChannelMediaRelayConfiguration config);

        // -(int)updateChannelMediaRelay:(AgoraChannelMediaRelayConfiguration * _Nonnull)config;
        [Export("updateChannelMediaRelay:")]
        int UpdateChannelMediaRelay(AgoraChannelMediaRelayConfiguration config);

        // -(int)stopChannelMediaRelay;
        [Export("stopChannelMediaRelay")]
        int StopChannelMediaRelay();

        // -(int)setCloudProxy:(AgoraCloudProxyType)proxyType;
        [Export("setCloudProxy:")]
        int SetCloudProxy(CloudProxyType proxyType);

        // -(int)enableAudio;
        [Export("enableAudio")]
        //[Verify(MethodToProperty)]
        int EnableAudio();

        // -(int)disableAudio;
        [Export("disableAudio")]
        //[Verify(MethodToProperty)]
        int DisableAudio();

        // -(int)setAudioProfile:(AgoraAudioProfile)profile scenario:(AgoraAudioScenario)scenario;
        [Export("setAudioProfile:scenario:")]
        int SetAudioProfile(AudioProfile profile, AudioScenario scenario);

        // -(int)adjustRecordingSignalVolume:(NSInteger)volume;
        [Export("adjustRecordingSignalVolume:")]
        int AdjustRecordingSignalVolume(nint volume);

        // -(int)adjustPlaybackSignalVolume:(NSInteger)volume;
        [Export("adjustPlaybackSignalVolume:")]
        int AdjustPlaybackSignalVolume(nint volume);

        // -(int)enableAudioVolumeIndication:(NSInteger)interval smooth:(NSInteger)smooth report_vad:(BOOL)report_vad;
        [Export("enableAudioVolumeIndication:smooth:report_vad:")]
        int EnableAudioVolumeIndication(nint interval, nint smooth, bool report_vad);

        // -(int)enableLocalAudio:(BOOL)enabled;
        [Export("enableLocalAudio:")]
        int EnableLocalAudio(bool enabled);

        // -(int)muteLocalAudioStream:(BOOL)mute;
        [Export("muteLocalAudioStream:")]
        int MuteLocalAudioStream(bool mute);

        // -(int)muteRemoteAudioStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteAudioStream:mute:")]
        int MuteRemoteAudioStream(nuint uid, bool mute);

        // -(int)muteAllRemoteAudioStreams:(BOOL)mute;
        [Export("muteAllRemoteAudioStreams:")]
        int MuteAllRemoteAudioStreams(bool mute);

        // -(int)adjustUserPlaybackSignalVolume:(id)uid volume:(int)volume;
        [Export("adjustUserPlaybackSignalVolume:volume:")]
        int AdjustUserPlaybackSignalVolume(NSObject uid, int volume);

        // -(int)enableVideo;
        [Export("enableVideo")]
        //[Verify(MethodToProperty)]
        int EnableVideo();

        // -(int)disableVideo;
        [Export("disableVideo")]
        //[Verify(MethodToProperty)]
        int DisableVideo();

        // -(int)setVideoEncoderConfiguration:(AgoraVideoEncoderConfiguration * _Nonnull)config;
        [Export("setVideoEncoderConfiguration:")]
        int SetVideoEncoderConfiguration(AgoraVideoEncoderConfiguration config);

        // -(int)setupLocalVideo:(AgoraRtcVideoCanvas * _Nullable)local;
        [Export("setupLocalVideo:")]
        int SetupLocalVideo([NullAllowed] AgoraRtcVideoCanvas local);

        // -(int)setupRemoteVideo:(AgoraRtcVideoCanvas * _Nonnull)remote;
        [Export("setupRemoteVideo:")]
        int SetupRemoteVideo(AgoraRtcVideoCanvas remote);

        // -(int)setLocalRenderMode:(AgoraVideoRenderMode)renderMode mirrorMode:(AgoraVideoMirrorMode)mirrorMode;
        [Export("setLocalRenderMode:mirrorMode:")]
        int SetLocalRenderMode(VideoRenderMode renderMode, VideoMirrorMode mirrorMode);

        // -(int)setRemoteRenderMode:(NSUInteger)uid renderMode:(AgoraVideoRenderMode)renderMode mirrorMode:(AgoraVideoMirrorMode)mirrorMode;
        [Export("setRemoteRenderMode:renderMode:mirrorMode:")]
        int SetRemoteRenderMode(nuint uid, VideoRenderMode renderMode, VideoMirrorMode mirrorMode);

        // -(int)startPreview;
        [Export("startPreview")]
        //[Verify(MethodToProperty)]
        int StartPreview();

        // -(int)stopPreview;
        [Export("stopPreview")]
        //[Verify(MethodToProperty)]
        int StopPreview();

        // -(int)enableLocalVideo:(BOOL)enabled;
        [Export("enableLocalVideo:")]
        int EnableLocalVideo(bool enabled);

        // -(int)muteLocalVideoStream:(BOOL)mute;
        [Export("muteLocalVideoStream:")]
        int MuteLocalVideoStream(bool mute);


        // -(int)muteAllRemoteVideoStreams:(BOOL)mute;
        [Export("muteAllRemoteVideoStreams:")]
        int MuteAllRemoteVideoStreams(bool mute);

        // -(int)muteRemoteVideoStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteVideoStream:mute:")]
        int MuteRemoteVideoStream(nuint uid, bool mute);

        // -(int)setBeautyEffectOptions:(BOOL)enable options:(AgoraBeautyOptions * _Nullable)options;
        [Export("setBeautyEffectOptions:options:")]
        int SetBeautyEffectOptions(bool enable, [NullAllowed] AgoraBeautyOptions options);

        // -(int)enableRemoteSuperResolution:(NSUInteger)uid enabled:(BOOL)enabled;
        [Export("enableRemoteSuperResolution:enabled:")]
        int EnableRemoteSuperResolution(nuint uid, bool enabled);

        // -(int)enableFaceDetection:(_Bool)enable;
        [Export("enableFaceDetection:")]
        int EnableFaceDetection(bool enable);

        // -(int)setDefaultAudioRouteToSpeakerphone:(BOOL)defaultToSpeaker;
        [Export("setDefaultAudioRouteToSpeakerphone:")]
        int SetDefaultAudioRouteToSpeakerphone(bool defaultToSpeaker);

        // -(int)setEnableSpeakerphone:(BOOL)enableSpeaker;
        [Export("setEnableSpeakerphone:")]
        int SetEnableSpeakerphone(bool enableSpeaker);

        // -(BOOL)isSpeakerphoneEnabled;
        [Export("isSpeakerphoneEnabled")]
        bool IsSpeakerphoneEnabled();

        // -(int)enableInEarMonitoring:(BOOL)enabled;
        [Export("enableInEarMonitoring:")]
        int EnableInEarMonitoring(bool enabled);

        // -(int)setInEarMonitoringVolume:(NSInteger)volume;
        [Export("setInEarMonitoringVolume:")]
        int SetInEarMonitoringVolume(nint volume);

        // -(int)setLocalVoicePitch:(double)pitch;
        [Export("setLocalVoicePitch:")]
        int SetLocalVoicePitch(double pitch);

        // -(int)setLocalVoiceEqualizationOfBandFrequency:(AgoraAudioEqualizationBandFrequency)bandFrequency withGain:(NSInteger)gain;
        [Export("setLocalVoiceEqualizationOfBandFrequency:withGain:")]
        int SetLocalVoiceEqualizationOfBandFrequency(AudioEqualizationBandFrequency bandFrequency, nint gain);

        // -(int)setLocalVoiceReverbOfType:(AgoraAudioReverbType)reverbType withValue:(NSInteger)value;
        [Export("setLocalVoiceReverbOfType:withValue:")]
        int SetLocalVoiceReverbOfType(AudioReverbType reverbType, nint value);

        // -(int)setVoiceBeautifierPreset:(AgoraVoiceBeautifierPreset)preset;
        [Export("setVoiceBeautifierPreset:")]
        int SetVoiceBeautifierPreset(VoiceBeautifierPreset preset);

        // -(int)setVoiceBeautifierParameters:(AgoraVoiceBeautifierPreset)preset param1:(int)param1 param2:(int)param2;
        [Export("setVoiceBeautifierParameters:param1:param2:")]
        int SetVoiceBeautifierParameters(VoiceBeautifierPreset preset, int param1, int param2);

        // -(int)setAudioEffectPreset:(AgoraAudioEffectPreset)preset;
        [Export("setAudioEffectPreset:")]
        int SetAudioEffectPreset(AudioEffectPreset preset);

        // -(int)setVoiceConversionPreset:(AgoraVoiceConversionPreset)preset;
        [Export("setVoiceConversionPreset:")]
        int SetVoiceConversionPreset(VoiceConversionPreset preset);

        // -(int)setAudioEffectParameters:(AgoraAudioEffectPreset)preset param1:(int)param1 param2:(int)param2;
        [Export("setAudioEffectParameters:param1:param2:")]
        int SetAudioEffectParameters(AudioEffectPreset preset, int param1, int param2);

        // -(int)enableSoundPositionIndication:(BOOL)enabled;
        [Export("enableSoundPositionIndication:")]
        int EnableSoundPositionIndication(bool enabled);

        // -(int)setRemoteVoicePosition:(NSUInteger)uid pan:(double)pan gain:(double)gain;
        [Export("setRemoteVoicePosition:pan:gain:")]
        int SetRemoteVoicePosition(nuint uid, double pan, double gain);

        // -(int)startAudioMixing:(NSString * _Nonnull)filePath loopback:(BOOL)loopback replace:(BOOL)replace cycle:(NSInteger)cycle;
        [Export("startAudioMixing:loopback:replace:cycle:")]
        int StartAudioMixing(string filePath, bool loopback, bool replace, nint cycle);

        // -(int)stopAudioMixing;
        [Export("stopAudioMixing")]
        //[Verify(MethodToProperty)]
        int StopAudioMixing();

        // -(int)pauseAudioMixing;
        [Export("pauseAudioMixing")]
        //[Verify(MethodToProperty)]
        int PauseAudioMixing();

        // -(int)resumeAudioMixing;
        [Export("resumeAudioMixing")]
        //[Verify(MethodToProperty)]
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

        // -(int)getAudioMixingPublishVolume;
        [Export("getAudioMixingPublishVolume")]
        int AudioMixingPublishVolume { get; }

        // -(int)getAudioMixingPlayoutVolume;
        [Export("getAudioMixingPlayoutVolume")]
        int AudioMixingPlayoutVolume { get; }

        // -(int)getAudioMixingDuration;
        [Export("getAudioMixingDuration")]
        //[Verify(MethodToProperty)]
        int AudioMixingDuration { get; }

        // -(int)getAudioMixingCurrentPosition;
        [Export("getAudioMixingCurrentPosition")]
        //[Verify(MethodToProperty)]
        int AudioMixingCurrentPosition { get; }

        // -(int)setAudioMixingPosition:(NSInteger)pos;
        [Export("setAudioMixingPosition:")]
        int SetAudioMixingPosition(nint pos);

        // -(int)setAudioMixingPitch:(NSInteger)pitch;
        [Export("setAudioMixingPitch:")]
        int SetAudioMixingPitch(nint pitch);

        // -(double)getEffectsVolume;
        [Export("getEffectsVolume")]
        //[Verify(MethodToProperty)]
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

        // -(int)stopEffect:(int)soundId;
        [Export("stopEffect:")]
        int StopEffect(int soundId);

        // -(int)stopAllEffects;
        [Export("stopAllEffects")]
        //[Verify(MethodToProperty)]
        int StopAllEffects();

        // -(int)preloadEffect:(int)soundId filePath:(NSString * _Nullable)filePath;
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
        //[Verify(MethodToProperty)]
        int PauseAllEffects();

        // -(int)resumeEffect:(int)soundId;
        [Export("resumeEffect:")]
        int ResumeEffect(int soundId);

        // -(int)resumeAllEffects;
        [Export("resumeAllEffects")]
        //[Verify(MethodToProperty)]
        int ResumeAllEffects();

        // -(int)startAudioRecording:(NSString * _Nonnull)filePath sampleRate:(NSInteger)sampleRate quality:(AgoraAudioRecordingQuality)quality;
        [Export("startAudioRecording:sampleRate:quality:")]
        int StartAudioRecording(string filePath, nint sampleRate, AudioRecordingQuality quality);

        // -(int)stopAudioRecording;
        [Export("stopAudioRecording")]
        //[Verify(MethodToProperty)]
        int StopAudioRecording();

        // -(void)setAudioSessionOperationRestriction:(AgoraAudioSessionOperationRestriction)restriction;
        [Export("setAudioSessionOperationRestriction:")]
        void SetAudioSessionOperationRestriction(AudioSessionOperationRestriction restriction);

        // -(int)enableDeepLearningDenoise:(BOOL)enabled;
        [Export("enableDeepLearningDenoise:")]
        int EnableDeepLearningDenoise(bool enabled);

        // -(int)startEchoTestWithInterval:(NSInteger)interval successBlock:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))successBlock;
        [Export("startEchoTestWithInterval:successBlock:")]
        int StartEchoTestWithInterval(nint interval, [NullAllowed] Action<NSString, nuint, nint> successBlock);

        // -(int)stopEchoTest;
        [Export("stopEchoTest")]
        //[Verify(MethodToProperty)]
        int StopEchoTest();

        // -(int)enableLastmileTest;
        [Export("enableLastmileTest")]
        //[Verify(MethodToProperty)]
        int EnableLastmileTest();

        // -(int)disableLastmileTest;
        [Export("disableLastmileTest")]
        //[Verify(MethodToProperty)]
        int DisableLastmileTest();

        // -(int)startLastmileProbeTest:(AgoraLastmileProbeConfig * _Nullable)config;
        [Export("startLastmileProbeTest:")]
        int StartLastmileProbeTest([NullAllowed] AgoraLastmileProbeConfig config);

        // -(int)stopLastmileProbeTest;
        [Export("stopLastmileProbeTest")]
        int StopLastmileProbeTest { get; }

        // -(void)setRemoteVideoRenderer:(id<AgoraVideoSinkProtocol> _Nullable)videoRenderer forUserId:(NSUInteger)userId;
        [Export("setRemoteVideoRenderer:forUserId:")]
        void SetRemoteVideoRenderer([NullAllowed] AgoraVideoSinkProtocol videoRenderer, nuint userId);

        // -(id<AgoraVideoSourceProtocol> _Nullable)videoSource;
        // -(void)setVideoSource:(id<AgoraVideoSourceProtocol> _Nullable)videoSource;
        [NullAllowed, Export("videoSource")]
        //[Verify(MethodToProperty)]
        AgoraVideoSourceProtocol VideoSource { get; set; }

        // -(id<AgoraVideoSinkProtocol> _Nullable)localVideoRenderer;
        // -(void)setLocalVideoRenderer:(id<AgoraVideoSinkProtocol> _Nullable)videoRenderer;
        [NullAllowed, Export("localVideoRenderer")]
        //[Verify(MethodToProperty)]
        AgoraVideoSinkProtocol LocalVideoRenderer { get; set; }

        // -(id<AgoraVideoSinkProtocol> _Nullable)remoteVideoRendererOfUserId:(NSUInteger)userId;
        [Export("remoteVideoRendererOfUserId:")]
        [return: NullAllowed]
        AgoraVideoSinkProtocol RemoteVideoRendererOfUserId(nuint userId);

        // -(void)enableExternalAudioSink:(NSUInteger)sampleRate channels:(NSUInteger)channels;
        [Export("enableExternalAudioSink:channels:")]
        void EnableExternalAudioSink(nuint sampleRate, nuint channels);

        // -(void)disableExternalAudioSink;
        [Export("disableExternalAudioSink")]
        void DisableExternalAudioSink();

        // -(BOOL)pullPlaybackAudioFrameRawData:(void * _Nonnull)data lengthInByte:(NSUInteger)lengthInByte;
        [Export("pullPlaybackAudioFrameRawData:lengthInByte:")]
        unsafe bool PullPlaybackAudioFrameRawData(IntPtr data, nuint lengthInByte);

        // -(CMSampleBufferRef _Nullable)pullPlaybackAudioFrameSampleBufferByLengthInByte:(NSUInteger)lengthInByte;
        [Export("pullPlaybackAudioFrameSampleBufferByLengthInByte:")]
        [return: NullAllowed]
        unsafe IntPtr PullPlaybackAudioFrameSampleBufferByLengthInByte(nuint lengthInByte);

        // -(void)enableExternalAudioSourceWithSampleRate:(NSUInteger)sampleRate channelsPerFrame:(NSUInteger)channelsPerFrame;
        [Export("enableExternalAudioSourceWithSampleRate:channelsPerFrame:")]
        void EnableExternalAudioSourceWithSampleRate(nuint sampleRate, nuint channelsPerFrame);

        // -(void)disableExternalAudioSource;
        [Export("disableExternalAudioSource")]
        void DisableExternalAudioSource();

        // -(BOOL)pushExternalAudioFrameRawData:(void * _Nonnull)data samples:(NSUInteger)samples timestamp:(NSTimeInterval)timestamp;
        [Export("pushExternalAudioFrameRawData:samples:timestamp:")]
        unsafe bool PushExternalAudioFrameRawData(IntPtr data, nuint samples, double timestamp);

        // -(BOOL)pushExternalAudioFrameSampleBuffer:(CMSampleBufferRef _Nonnull)sampleBuffer;
        [Export("pushExternalAudioFrameSampleBuffer:")]
        unsafe bool PushExternalAudioFrameSampleBuffer(IntPtr sampleBuffer);

        // -(void)setExternalVideoSource:(BOOL)enable useTexture:(BOOL)useTexture pushMode:(BOOL)pushMode;
        [Export("setExternalVideoSource:useTexture:pushMode:")]
        void SetExternalVideoSource(bool enable, bool useTexture, bool pushMode);

        // -(BOOL)pushExternalVideoFrame:(AgoraVideoFrame * _Nonnull)frame;
        [Export("pushExternalVideoFrame:")]
        bool PushExternalVideoFrame(AgoraVideoFrame frame);

        // -(int)setRecordingAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraAudioRawFrameOperationMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetRecordingAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AudioRawFrameOperationMode mode, nint samplesPerCall);

        // -(int)setPlaybackAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraAudioRawFrameOperationMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetPlaybackAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AudioRawFrameOperationMode mode, nint samplesPerCall);

        // -(int)setMixedAudioFrameParametersWithSampleRate:(NSInteger)sampleRate samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:")]
        int SetMixedAudioFrameParametersWithSampleRate(nint sampleRate, nint samplesPerCall);

        // -(BOOL)setAudioFrameDelegate:(id<AgoraAudioFrameDelegate> _Nullable)delegate;
        [Export("setAudioFrameDelegate:")]
        bool SetAudioFrameDelegate([NullAllowed] AgoraAudioFrameDelegate @delegate);

        // -(int)addVideoWatermark:(NSURL * _Nonnull)url options:(WatermarkOptions * _Nonnull)options;
        [Export("addVideoWatermark:options:")]
        int AddVideoWatermark(NSUrl url, WatermarkOptions options);

        // -(void)clearVideoWatermarks;
        [Export("clearVideoWatermarks")]
        void ClearVideoWatermarks();

        // -(int)setRemoteUserPriority:(NSUInteger)uid type:(AgoraUserPriority)userPriority;
        [Export("setRemoteUserPriority:type:")]
        int SetRemoteUserPriority(nuint uid, UserPriority userPriority);

        // -(int)setLocalPublishFallbackOption:(AgoraStreamFallbackOptions)option;
        [Export("setLocalPublishFallbackOption:")]
        int SetLocalPublishFallbackOption(StreamFallbackOptions option);

        // -(int)setRemoteSubscribeFallbackOption:(AgoraStreamFallbackOptions)option;
        [Export("setRemoteSubscribeFallbackOption:")]
        int SetRemoteSubscribeFallbackOption(StreamFallbackOptions option);

        // -(int)enableDualStreamMode:(BOOL)enabled;
        [Export("enableDualStreamMode:")]
        int EnableDualStreamMode(bool enabled);

        // -(int)setRemoteVideoStream:(NSUInteger)uid type:(AgoraVideoStreamType)streamType;
        [Export("setRemoteVideoStream:type:")]
        int SetRemoteVideoStream(nuint uid, VideoStreamType streamType);

        // -(int)setRemoteDefaultVideoStreamType:(AgoraVideoStreamType)streamType;
        [Export("setRemoteDefaultVideoStreamType:")]
        int SetRemoteDefaultVideoStreamType(VideoStreamType streamType);

        // -(int)enableEncryption:(_Bool)enabled encryptionConfig:(AgoraEncryptionConfig *)config;
        [Export("enableEncryption:encryptionConfig:")]
        int EnableEncryption(bool enabled, AgoraEncryptionConfig config);

        // -(int)addInjectStreamUrl:(NSString * _Nonnull)url config:(AgoraLiveInjectStreamConfig * _Nonnull)config;
        [Export("addInjectStreamUrl:config:")]
        int AddInjectStreamUrl(string url, AgoraLiveInjectStreamConfig config);

        // -(int)removeInjectStreamUrl:(NSString * _Nonnull)url;
        [Export("removeInjectStreamUrl:")]
        int RemoveInjectStreamUrl(string url);

        // -(int)addPublishStreamUrl:(NSString * _Nonnull)url transcodingEnabled:(BOOL)transcodingEnabled;
        [Export("addPublishStreamUrl:transcodingEnabled:")]
        int AddPublishStreamUrl(string url, bool transcodingEnabled);

        // -(int)removePublishStreamUrl:(NSString * _Nonnull)url;
        [Export("removePublishStreamUrl:")]
        int RemovePublishStreamUrl(string url);

        // -(int)setLiveTranscoding:(AgoraLiveTranscoding * _Nullable)transcoding;
        [Export("setLiveTranscoding:")]
        int SetLiveTranscoding([NullAllowed] AgoraLiveTranscoding transcoding);

        // -(int)createDataStream:(NSInteger * _Nonnull)streamId config:(AgoraDataStreamConfig * _Nonnull)config;
        [Export("createDataStream:config:")]
        unsafe int CreateDataStream(ref nint streamId, AgoraDataStreamConfig config);

        // -(int)sendStreamMessage:(NSInteger)streamId data:(NSData * _Nonnull)data;
        [Export("sendStreamMessage:data:")]
        int SendStreamMessage(nint streamId, NSData data);

        // -(int)setCameraCapturerConfiguration:(AgoraCameraCapturerConfiguration * _Nullable)configuration;
        [Export("setCameraCapturerConfiguration:")]
        int SetCameraCapturerConfiguration([NullAllowed] AgoraCameraCapturerConfiguration configuration);

        // -(int)switchCamera;
        [Export("switchCamera")]
        //[Verify(MethodToProperty)]
        int SwitchCamera { get; }

        // -(BOOL)isCameraZoomSupported;
        [Export("isCameraZoomSupported")]
        //[Verify(MethodToProperty)]
        bool IsCameraZoomSupported { get; }

        // -(BOOL)isCameraTorchSupported;
        [Export("isCameraTorchSupported")]
        //[Verify(MethodToProperty)]
        bool IsCameraTorchSupported { get; }

        // -(BOOL)isCameraFocusPositionInPreviewSupported;
        [Export("isCameraFocusPositionInPreviewSupported")]
        //[Verify(MethodToProperty)]
        bool IsCameraFocusPositionInPreviewSupported { get; }

        // -(BOOL)isCameraExposurePositionSupported;
        [Export("isCameraExposurePositionSupported")]
        //[Verify(MethodToProperty)]
        bool IsCameraExposurePositionSupported { get; }

        // -(BOOL)isCameraAutoFocusFaceModeSupported;
        [Export("isCameraAutoFocusFaceModeSupported")]
        //[Verify(MethodToProperty)]
        bool IsCameraAutoFocusFaceModeSupported { get; }

        // -(CGFloat)setCameraZoomFactor:(CGFloat)zoomFactor;
        [Export("setCameraZoomFactor:")]
        nfloat SetCameraZoomFactor(nfloat zoomFactor);

        // -(BOOL)setCameraFocusPositionInPreview:(CGPoint)position;
        [Export("setCameraFocusPositionInPreview:")]
        bool SetCameraFocusPositionInPreview(CGPoint position);

        // -(BOOL)setCameraExposurePosition:(CGPoint)positionInView;
        [Export("setCameraExposurePosition:")]
        bool SetCameraExposurePosition(CGPoint positionInView);

        // -(BOOL)setCameraTorchOn:(BOOL)isOn;
        [Export("setCameraTorchOn:")]
        bool SetCameraTorchOn(bool isOn);

        // -(BOOL)setCameraAutoFocusFaceModeEnabled:(BOOL)enable;
        [Export("setCameraAutoFocusFaceModeEnabled:")]
        bool SetCameraAutoFocusFaceModeEnabled(bool enable);

        // -(BOOL)setMediaMetadataDataSource:(id<AgoraMediaMetadataDataSource> _Nullable)metadataDataSource withType:(AgoraMetadataType)type;
        [Export("setMediaMetadataDataSource:withType:")]
        bool SetMediaMetadataDataSource([NullAllowed] AgoraMediaMetadataDataSource metadataDataSource, MetadataType type);

        // -(BOOL)setMediaMetadataDelegate:(id<AgoraMediaMetadataDelegate> _Nullable)metadataDelegate withType:(AgoraMetadataType)type;
        [Export("setMediaMetadataDelegate:withType:")]
        bool SetMediaMetadataDelegate([NullAllowed] AgoraMediaMetadataDelegate metadataDelegate, MetadataType type);

        // -(NSString * _Nullable)getCallId;
        [NullAllowed, Export("getCallId")]
        //[Verify(MethodToProperty)]
        string CallId { get; }

        // -(int)rate:(NSString * _Nonnull)callId rating:(NSInteger)rating description:(NSString * _Nullable)description;
        [Export("rate:rating:description:")]
        int Rate(string callId, nint rating, [NullAllowed] string description);

        // -(int)complain:(NSString * _Nonnull)callId description:(NSString * _Nullable)description;
        [Export("complain:description:")]
        int Complain(string callId, [NullAllowed] string description);

        // -(int)enableMainQueueDispatch:(BOOL)enabled;
        [Export("enableMainQueueDispatch:")]
        int EnableMainQueueDispatch(bool enabled);

        // +(NSString * _Nonnull)getSdkVersion;
        [Static]
        [Export("getSdkVersion")]
        //[Verify(MethodToProperty)]
        string SdkVersion { get; }

        // +(NSString * _Nullable)getErrorDescription:(NSInteger)code;
        [Static]
        [Export("getErrorDescription:")]
        string GetErrorDescription(nint code);

        // -(NSString * _Nullable)uploadLogFile;
        [NullAllowed, Export("uploadLogFile")]
        //[Verify(MethodToProperty)]
        string UploadLogFile { get; }

        // -(int)sendCustomReportMessage:(NSString * _Nonnull)id category:(NSString * _Nonnull)category event:(NSString * _Nonnull)event label:(NSString * _Nonnull)label value:(NSInteger)value;
        [Export("sendCustomReportMessage:category:event:label:value:")]
        int SendCustomReportMessage(string id, string category, string @event, string label, nint value);

        // -(void * _Nullable)getNativeHandle;
        [NullAllowed, Export("getNativeHandle")]
        //[Verify(MethodToProperty)]
        unsafe IntPtr NativeHandle { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        AgoraRtcEngineDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AgoraRtcEngineDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(int)setParameters:(NSString * _Nonnull)options;
        [Export("setParameters:")]
        int SetParameters(string options);

        // -(NSString * _Nullable)getParameter:(NSString * _Nonnull)parameter args:(NSString * _Nullable)args;
        [Export("getParameter:args:")]
        [return: NullAllowed]
        string GetParameter(string parameter, [NullAllowed] string args);

        // -(int)setDefaultMuteAllRemoteVideoStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteVideoStreams:")]
        int SetDefaultMuteAllRemoteVideoStreams(bool mute);

        // -(int)setDefaultMuteAllRemoteAudioStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteAudioStreams:")]
        int SetDefaultMuteAllRemoteAudioStreams(bool mute);

        // -(int)setLogFile:(NSString * _Nonnull)filePath;
        [Export("setLogFile:")]
        int SetLogFile(string filePath);

        // -(int)setLogFilter:(NSUInteger)filter;
        [Export("setLogFilter:")]
        int SetLogFilter(nuint filter);

        // -(int)setLogFileSize:(NSUInteger)fileSizeInKBytes;
        [Export("setLogFileSize:")]
        int SetLogFileSize(nuint fileSizeInKBytes);

        // -(int)createDataStream:(NSInteger * _Nonnull)streamId reliable:(BOOL)reliable ordered:(BOOL)ordered;
        [Export("createDataStream:reliable:ordered:")]
        unsafe int CreateDataStream(ref nint streamId, bool reliable, bool ordered);

        // -(int)setLocalVoiceChanger:(AgoraAudioVoiceChanger)voiceChanger __attribute__((deprecated("use setAudioEffectPreset or setVoiceBeautifierPreset instead.")));
        [Export("setLocalVoiceChanger:")]
        int SetLocalVoiceChanger(AudioVoiceChanger voiceChanger);

        // -(int)setLocalVoiceReverbPreset:(AgoraAudioReverbPreset)reverbPreset __attribute__((deprecated("use setAudioEffectPreset or setVoiceBeautifierPreset instead.")));
        [Export("setLocalVoiceReverbPreset:")]
        int SetLocalVoiceReverbPreset(AudioReverbPreset reverbPreset);

        // -(int)setEncryptionSecret:(NSString * _Nullable)secret;
        [Export("setEncryptionSecret:")]
        int SetEncryptionSecret([NullAllowed] string secret);

        // -(int)setEncryptionMode:(NSString * _Nullable)encryptionMode;
        [Export("setEncryptionMode:")]
        int SetEncryptionMode([NullAllowed] string encryptionMode);

        // -(int)setLocalRenderMode:(AgoraVideoRenderMode)mode;
        [Export("setLocalRenderMode:")]
        int SetLocalRenderMode(VideoRenderMode mode);

        // -(int)setRemoteRenderMode:(NSUInteger)uid mode:(AgoraVideoRenderMode)mode;
        [Export("setRemoteRenderMode:mode:")]
        int SetRemoteRenderMode(nuint uid, VideoRenderMode mode);

        // -(int)setLocalVideoMirrorMode:(AgoraVideoMirrorMode)mode;
        [Export("setLocalVideoMirrorMode:")]
        int SetLocalVideoMirrorMode(VideoMirrorMode mode);

        // -(int)enableWebSdkInteroperability:(BOOL)enabled;
        [Export("enableWebSdkInteroperability:")]
        int EnableWebSdkInteroperability(bool enabled);

        // -(int)addVideoWatermark:(AgoraImage * _Nonnull)watermark;
        [Export("addVideoWatermark:")]
        [Obsolete("use addVideoWatermark:url options instead.")]
        int AddVideoWatermark(AgoraImage watermark);

        // -(int)startAudioRecording:(NSString * _Nonnull)filePath quality:(AgoraAudioRecordingQuality)quality;
        [Export("startAudioRecording:quality:")]
        int StartAudioRecording(string filePath, AudioRecordingQuality quality);

        // -(int)startEchoTest:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))successBlock;
        [Export("startEchoTest:")]
        int StartEchoTest([NullAllowed] Action<NSString, nuint, nint> successBlock);

        // -(int)setVideoQualityParameters:(BOOL)preferFrameRateOverImageQuality;
        [Export("setVideoQualityParameters:")]
        [Obsolete("use AgoraDegradationPreference instead.")]
        int SetVideoQualityParameters(bool preferFrameRateOverImageQuality);

        [Static]
        [Export("sharedEngineWithAppId:error:")]
        AgoraRtcEngineKit SharedEngineWithAppId(string AppId, [NullAllowed] Action<ErrorCode> errorBlock);

        // -(int)pauseAudio;
        [Export("pauseAudio")]
        [Obsolete("use DisableAudio instead.")]
        //[Verify(MethodToProperty)]
        int PauseAudio();

        // -(int)resumeAudio;
        [Export("resumeAudio")]
        [Obsolete("use EnableAudio instead.")]
        //[Verify(MethodToProperty)]
        int ResumeAudio();

        // -(int)setHighQualityAudioParametersWithFullband:(BOOL)fullband stereo:(BOOL)stereo fullBitrate:(BOOL)fullBitrate __attribute__((deprecated("")));
        [Export("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:")]
        [Obsolete("use setAudioProfile:scenario: instead.")]
        int SetHighQualityAudioParametersWithFullband(bool fullband, bool stereo, bool fullBitrate);

        // -(int)setVideoProfile:(AgoraVideoProfile)profile swapWidthAndHeight:(BOOL)swapWidthAndHeight;
        [Export("setVideoProfile:swapWidthAndHeight:")]
        int SetVideoProfile(VideoProfile profile, bool swapWidthAndHeight);

        // -(int)setVideoResolution:(CGSize)size andFrameRate:(NSInteger)frameRate bitrate:(NSInteger)bitrate;
        [Export("setVideoResolution:andFrameRate:bitrate:")]
        int SetVideoResolution(CGSize size, nint frameRate, nint bitrate);

        // -(int)playEffect:(int)soundId filePath:(NSString * _Nullable)filePath loopCount:(int)loopCount pitch:(double)pitch pan:(double)pan gain:(double)gain __attribute__((deprecated("")));
        [Export("playEffect:filePath:loopCount:pitch:pan:gain:")]
        [Obsolete("use playEffect:filePath:loopCount:pitch:pan:gain:publish: instead.")]
        int PlayEffect(int soundId, [NullAllowed] string filePath, int loopCount, double pitch, double pan, double gain);

        // +(NSString * _Nonnull)getMediaEngineVersion;
        [Static]
        [Export("getMediaEngineVersion")]
        [Obsolete("use getSdkVersion instead")]
        //[Verify(MethodToProperty)]
        string MediaEngineVersion { get; }

        // -(void)audioVolumeIndicationBlock:(void (^ _Nullable)(NSArray * _Nonnull, NSInteger))audioVolumeIndicationBlock __attribute__((deprecated("")));
        [Export("audioVolumeIndicationBlock:")]
        void AudioVolumeIndicationBlock([NullAllowed] Action<NSArray, nint> audioVolumeIndicationBlock);

        // -(void)firstLocalVideoFrameBlock:(void (^ _Nullable)(NSInteger, NSInteger, NSInteger))firstLocalVideoFrameBlock __attribute__((deprecated("")));
        [Export("firstLocalVideoFrameBlock:")]
        void FirstLocalVideoFrameBlock([NullAllowed] Action<nint, nint, nint> firstLocalVideoFrameBlock);

        // -(void)firstRemoteVideoDecodedBlock:(void (^ _Nullable)(NSUInteger, NSInteger, NSInteger, NSInteger))firstRemoteVideoDecodedBlock __attribute__((deprecated("")));
        [Export("firstRemoteVideoDecodedBlock:")]
        void FirstRemoteVideoDecodedBlock([NullAllowed] Action<nuint, nint, nint, nint> firstRemoteVideoDecodedBlock);

        // -(void)firstRemoteVideoFrameBlock:(void (^ _Nullable)(NSUInteger, NSInteger, NSInteger, NSInteger))firstRemoteVideoFrameBlock __attribute__((deprecated("")));
        [Export("firstRemoteVideoFrameBlock:")]
        void FirstRemoteVideoFrameBlock([NullAllowed] Action<nuint, nint, nint, nint> firstRemoteVideoFrameBlock);

        // -(void)userJoinedBlock:(void (^ _Nullable)(NSUInteger, NSInteger))userJoinedBlock __attribute__((deprecated("")));
        [Export("userJoinedBlock:")]
        void UserJoinedBlock([NullAllowed] Action<nuint, nint> userJoinedBlock);

        // -(void)userOfflineBlock:(void (^ _Nullable)(NSUInteger))userOfflineBlock __attribute__((deprecated("")));
        [Export("userOfflineBlock:")]
        void UserOfflineBlock([NullAllowed] Action<nuint> userOfflineBlock);

        // -(void)userMuteAudioBlock:(void (^ _Nullable)(NSUInteger, BOOL))userMuteAudioBlock __attribute__((deprecated("")));
        [Export("userMuteAudioBlock:")]
        void UserMuteAudioBlock([NullAllowed] Action<nuint, bool> userMuteAudioBlock);

        // -(void)userMuteVideoBlock:(void (^ _Nullable)(NSUInteger, BOOL))userMuteVideoBlock __attribute__((deprecated("")));
        [Export("userMuteVideoBlock:")]
        void UserMuteVideoBlock([NullAllowed] Action<nuint, bool> userMuteVideoBlock);

        // -(void)cameraReadyBlock:(void (^ _Nullable)(void))cameraReadyBlock __attribute__((deprecated("")));
        [Export("cameraReadyBlock:")]
        void CameraReadyBlock([NullAllowed] Action cameraReadyBlock);

        // -(void)connectionLostBlock:(void (^ _Nullable)(void))connectionLostBlock __attribute__((deprecated("")));
        [Export("connectionLostBlock:")]
        void ConnectionLostBlock([NullAllowed] Action connectionLostBlock);

        // -(void)rejoinChannelSuccessBlock:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))rejoinChannelSuccessBlock __attribute__((deprecated("")));
        [Export("rejoinChannelSuccessBlock:")]
        void RejoinChannelSuccessBlock([NullAllowed] Action<NSString, nuint, nint> rejoinChannelSuccessBlock);

        // -(void)rtcStatsBlock:(void (^ _Nullable)(AgoraChannelStats * _Nonnull))rtcStatsBlock __attribute__((deprecated("")));
        [Export("rtcStatsBlock:")]
        void RtcStatsBlock([NullAllowed] Action<AgoraChannelStats> rtcStatsBlock);

        // -(void)leaveChannelBlock:(void (^ _Nullable)(AgoraChannelStats * _Nonnull))leaveChannelBlock __attribute__((deprecated("")));
        [Export("leaveChannelBlock:")]
        void LeaveChannelBlock([NullAllowed] Action<AgoraChannelStats> leaveChannelBlock);

        // -(void)audioQualityBlock:(void (^ _Nullable)(NSUInteger, AgoraNetworkQuality, NSUInteger, NSUInteger))audioQualityBlock __attribute__((deprecated("")));
        [Export("audioQualityBlock:")]
        void AudioQualityBlock([NullAllowed] Action<nuint, NetworkQuality, nuint, nuint> audioQualityBlock);

        // -(void)networkQualityBlock:(void (^ _Nullable)(NSUInteger, AgoraNetworkQuality, AgoraNetworkQuality))networkQualityBlock __attribute__((deprecated("")));
        [Export("networkQualityBlock:")]
        void NetworkQualityBlock([NullAllowed] Action<nuint, NetworkQuality, NetworkQuality> networkQualityBlock);

        // -(void)lastmileQualityBlock:(void (^ _Nullable)(AgoraNetworkQuality))lastmileQualityBlock __attribute__((deprecated("")));
        [Export("lastmileQualityBlock:")]
        void LastmileQualityBlock([NullAllowed] Action<NetworkQuality> lastmileQualityBlock);

        // -(void)mediaEngineEventBlock:(void (^ _Nullable)(NSInteger))mediaEngineEventBlock __attribute__((deprecated("")));
        [Export("mediaEngineEventBlock:")]
        void MediaEngineEventBlock([NullAllowed] Action<nint> mediaEngineEventBlock);

        [Export("createRtcChannel:")]
        [return: NullAllowed]
        AgoraRtcChannel CreateRtcChannel(string channelId);
    }

    // @interface AgoraRtcChannel : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcChannel
    {
        // -(int)destroy;
        [Export("destroy")]
        int Destroy();

        // -(void)setRtcChannelDelegate:(id<AgoraRtcChannelDelegate> _Nullable)channelDelegate;
        [Export("setRtcChannelDelegate:")]
        void SetRtcChannelDelegate([NullAllowed] AgoraRtcChannelDelegate channelDelegate);

        // -(NSString * _Nullable)getChannelId;
        [NullAllowed, Export("getChannelId")]
        string ChannelId { get; }

        // -(NSString * _Nullable)getCallId;
        [NullAllowed, Export("getCallId")]
        string CallId { get; }

        // -(AgoraConnectionStateType)getConnectionState;
        [Export("getConnectionState")]
        ConnectionStateType ConnectionState { get; }

        // -(int)joinChannelByToken:(NSString * _Nullable)token info:(NSString * _Nullable)info uid:(NSUInteger)uid options:(AgoraRtcChannelMediaOptions * _Nonnull)options;
        [Export("joinChannelByToken:info:uid:options:")]
        int JoinChannelByToken([NullAllowed] string token, [NullAllowed] string info, nuint uid, AgoraRtcChannelMediaOptions options);

        // -(int)joinChannelByUserAccount:(NSString * _Nonnull)userAccount token:(NSString * _Nullable)token options:(AgoraRtcChannelMediaOptions * _Nonnull)options;
        [Export("joinChannelByUserAccount:token:options:")]
        int JoinChannelByUserAccount(string userAccount, [NullAllowed] string token, AgoraRtcChannelMediaOptions options);

        // -(int)leaveChannel;
        [Export("leaveChannel")]
        int LeaveChannel();

        // -(int)publish;
        [Export("publish")]
        int Publish();

        // -(int)unpublish;
        [Export("unpublish")]
        int Unpublish();

        // -(int)setClientRole:(AgoraClientRole)role;
        [Export("setClientRole:")]
        int SetClientRole(ClientRole role);

        // -(int)setClientRole:(AgoraClientRole)role options:(AgoraClientRoleOptions * _Nullable)options;
        [Export("setClientRole:options:")]
        int SetClientRole(ClientRole role, [NullAllowed] AgoraClientRoleOptions options);

        // -(int)renewToken:(NSString * _Nonnull)token;
        [Export("renewToken:")]
        int RenewToken(string token);

        // -(int)setEncryptionSecret:(NSString * _Nullable)secret;
        [Export("setEncryptionSecret:")]
        int SetEncryptionSecret([NullAllowed] string secret);

        // -(int)setEncryptionMode:(NSString * _Nullable)encryptionMode;
        [Export("setEncryptionMode:")]
        int SetEncryptionMode([NullAllowed] string encryptionMode);

        // -(int)enableEncryption:(_Bool)enabled encryptionConfig:(AgoraEncryptionConfig *)config;
        [Export("enableEncryption:encryptionConfig:")]
        int EnableEncryption(bool enabled, AgoraEncryptionConfig config);

        // -(int)setRemoteUserPriority:(NSUInteger)uid type:(AgoraUserPriority)userPriority;
        [Export("setRemoteUserPriority:type:")]
        int SetRemoteUserPriority(nuint uid, UserPriority userPriority);

        // -(int)setRemoteVoicePosition:(NSUInteger)uid pan:(double)pan gain:(double)gain;
        [Export("setRemoteVoicePosition:pan:gain:")]
        int SetRemoteVoicePosition(nuint uid, double pan, double gain);

        // -(int)setRemoteRenderMode:(NSUInteger)uid renderMode:(AgoraVideoRenderMode)renderMode mirrorMode:(AgoraVideoMirrorMode)mirrorMode;
        [Export("setRemoteRenderMode:renderMode:mirrorMode:")]
        int SetRemoteRenderMode(nuint uid, VideoRenderMode renderMode, VideoMirrorMode mirrorMode);

        // -(int)setDefaultMuteAllRemoteAudioStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteAudioStreams:")]
        int SetDefaultMuteAllRemoteAudioStreams(bool mute);

        // -(int)setDefaultMuteAllRemoteVideoStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteVideoStreams:")]
        int SetDefaultMuteAllRemoteVideoStreams(bool mute);

        // -(int)muteRemoteAudioStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteAudioStream:mute:")]
        int MuteRemoteAudioStream(nuint uid, bool mute);

        // -(int)adjustUserPlaybackSignalVolume:(NSUInteger)uid volume:(int)volume;
        [Export("adjustUserPlaybackSignalVolume:volume:")]
        int AdjustUserPlaybackSignalVolume(nuint uid, int volume);

        // -(int)muteAllRemoteAudioStreams:(BOOL)mute;
        [Export("muteAllRemoteAudioStreams:")]
        int MuteAllRemoteAudioStreams(bool mute);

        // -(int)muteRemoteVideoStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteVideoStream:mute:")]
        int MuteRemoteVideoStream(nuint uid, bool mute);

        // -(int)muteAllRemoteVideoStreams:(BOOL)mute;
        [Export("muteAllRemoteVideoStreams:")]
        int MuteAllRemoteVideoStreams(bool mute);

        // -(int)setRemoteVideoStream:(NSUInteger)uid type:(AgoraVideoStreamType)streamType;
        [Export("setRemoteVideoStream:type:")]
        int SetRemoteVideoStream(nuint uid, VideoStreamType streamType);

        // -(int)setRemoteDefaultVideoStreamType:(AgoraVideoStreamType)streamType;
        [Export("setRemoteDefaultVideoStreamType:")]
        int SetRemoteDefaultVideoStreamType(VideoStreamType streamType);

        // -(int)addInjectStreamUrl:(NSString * _Nonnull)url config:(AgoraLiveInjectStreamConfig * _Nonnull)config;
        [Export("addInjectStreamUrl:config:")]
        int AddInjectStreamUrl(string url, AgoraLiveInjectStreamConfig config);

        // -(int)removeInjectStreamUrl:(NSString * _Nonnull)url;
        [Export("removeInjectStreamUrl:")]
        int RemoveInjectStreamUrl(string url);

        // -(int)addPublishStreamUrl:(NSString * _Nonnull)url transcodingEnabled:(BOOL)transcodingEnabled;
        [Export("addPublishStreamUrl:transcodingEnabled:")]
        int AddPublishStreamUrl(string url, bool transcodingEnabled);

        // -(int)removePublishStreamUrl:(NSString * _Nonnull)url;
        [Export("removePublishStreamUrl:")]
        int RemovePublishStreamUrl(string url);

        // -(int)setLiveTranscoding:(AgoraLiveTranscoding * _Nullable)transcoding;
        [Export("setLiveTranscoding:")]
        int SetLiveTranscoding([NullAllowed] AgoraLiveTranscoding transcoding);

        // -(int)createDataStream:(NSInteger * _Nonnull)streamId reliable:(BOOL)reliable ordered:(BOOL)ordered;
        [Export("createDataStream:reliable:ordered:")]
        unsafe int CreateDataStream(ref nint streamId, bool reliable, bool ordered);

        // -(int)createDataStream:(NSInteger * _Nonnull)streamId config:(AgoraDataStreamConfig * _Nonnull)config;
        [Export("createDataStream:config:")]
        unsafe int CreateDataStream(ref nint streamId, AgoraDataStreamConfig config);

        // -(int)sendStreamMessage:(NSInteger)streamId data:(NSData * _Nonnull)data;
        [Export("sendStreamMessage:data:")]
        int SendStreamMessage(nint streamId, NSData data);

        // -(int)startChannelMediaRelay:(AgoraChannelMediaRelayConfiguration * _Nonnull)config;
        [Export("startChannelMediaRelay:")]
        int StartChannelMediaRelay(AgoraChannelMediaRelayConfiguration config);

        // -(int)updateChannelMediaRelay:(AgoraChannelMediaRelayConfiguration * _Nonnull)config;
        [Export("updateChannelMediaRelay:")]
        int UpdateChannelMediaRelay(AgoraChannelMediaRelayConfiguration config);

        // -(int)stopChannelMediaRelay;
        [Export("stopChannelMediaRelay")]
        int StopChannelMediaRelay();

        // -(int)enableRemoteSuperResolution:(NSUInteger)uid enabled:(BOOL)enabled;
        [Export("enableRemoteSuperResolution:enabled:")]
        int EnableRemoteSuperResolution(nuint uid, bool enabled);

        // -(void)setRemoteVideoRenderer:(id<AgoraVideoSinkProtocol> _Nullable)videoRenderer forUserId:(NSUInteger)userId;
        [Export("setRemoteVideoRenderer:forUserId:")]
        void SetRemoteVideoRenderer([NullAllowed] AgoraVideoSinkProtocol videoRenderer, nuint userId);

        // -(id<AgoraVideoSinkProtocol> _Nullable)remoteVideoRendererOfUserId:(NSUInteger)userId;
        [Export("remoteVideoRendererOfUserId:")]
        [return: NullAllowed]
        AgoraVideoSinkProtocol RemoteVideoRendererOfUserId(nuint userId);

        // -(BOOL)setMediaMetadataDataSource:(id<AgoraMediaMetadataDataSource> _Nullable)metadataDataSource withType:(AgoraMetadataType)type;
        [Export("setMediaMetadataDataSource:withType:")]
        bool SetMediaMetadataDataSource([NullAllowed] AgoraMediaMetadataDataSource metadataDataSource, MetadataType type);

        // -(BOOL)setMediaMetadataDelegate:(id<AgoraMediaMetadataDelegate> _Nullable)metadataDelegate withType:(AgoraMetadataType)type;
        [Export("setMediaMetadataDelegate:withType:")]
        bool SetMediaMetadataDelegate([NullAllowed] AgoraMediaMetadataDelegate metadataDelegate, MetadataType type);
    }

    // @protocol AgoraRtcChannelDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface AgoraRtcChannelDelegate
    {
        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didOccurWarning:(AgoraWarningCode)warningCode;
        [Export("rtcChannel:didOccurWarning:")]
        [EventArgs("DidOccurWarning")]
        void DidOccurWarning(AgoraRtcChannel rtcChannel, WarningCode warningCode);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didOccurError:(AgoraErrorCode)errorCode;
        [Export("rtcChannel:didOccurError:")]
        [EventArgs("DidOccurError")]
        void DidOccurError(AgoraRtcChannel rtcChannel, ErrorCode errorCode);

        // @optional -(void)rtcChannelDidJoinChannel:(AgoraRtcChannel * _Nonnull)rtcChannel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcChannelDidJoinChannel:withUid:elapsed:")]
        [EventArgs("DidJoinChannel")]
        void DidJoinChannel(AgoraRtcChannel rtcChannel, nuint uid, nint elapsed);

        // @optional -(void)rtcChannelDidRejoinChannel:(AgoraRtcChannel * _Nonnull)rtcChannel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcChannelDidRejoinChannel:withUid:elapsed:")]
        [EventArgs("DidRejoinChannel")]
        void DidRejoinChannel(AgoraRtcChannel rtcChannel, nuint uid, nint elapsed);

        // @optional -(void)rtcChannelDidLeaveChannel:(AgoraRtcChannel * _Nonnull)rtcChannel withStats:(AgoraChannelStats * _Nonnull)stats;
        [Export("rtcChannelDidLeaveChannel:withStats:")]
        [EventArgs("DidLeaveChannel")]
        void DidLeaveChannel(AgoraRtcChannel rtcChannel, AgoraChannelStats stats);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didClientRoleChanged:(AgoraClientRole)oldRole newRole:(AgoraClientRole)newRole;
        [Export("rtcChannel:didClientRoleChanged:newRole:")]
        [EventArgs("DidClientRoleChanged")]
        void DidClientRoleChanged(AgoraRtcChannel rtcChannel, ClientRole oldRole, ClientRole newRole);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didJoinedOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcChannel:didJoinedOfUid:elapsed:")]
        [EventArgs("DidJoinedOfUid")]
        void DidJoinedOfUid(AgoraRtcChannel rtcChannel, nuint uid, nint elapsed);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didOfflineOfUid:(NSUInteger)uid reason:(AgoraUserOfflineReason)reason;
        [Export("rtcChannel:didOfflineOfUid:reason:")]
        [EventArgs("DidOfflineOfUid")]
        void DidOfflineOfUid(AgoraRtcChannel rtcChannel, nuint uid, UserOfflineReason reason);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel connectionChangedToState:(AgoraConnectionStateType)state reason:(AgoraConnectionChangedReason)reason;
        [Export("rtcChannel:connectionChangedToState:reason:")]
        [EventArgs("ConnectionChangedToState")]
        void ConnectionChangedToState(AgoraRtcChannel rtcChannel, ConnectionStateType state, ConnectionChangedReason reason);

        // @optional -(void)rtcChannelDidLost:(AgoraRtcChannel * _Nonnull)rtcChannel;
        [Export("rtcChannelDidLost:")]
        [EventArgs("RtcChannelDidLost")]
        void RtcChannelDidLost(AgoraRtcChannel rtcChannel);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel tokenPrivilegeWillExpire:(NSString * _Nonnull)token;
        [Export("rtcChannel:tokenPrivilegeWillExpire:")]
        [EventArgs("TokenPrivilegeWillExpire")]
        void TokenPrivilegeWillExpire(AgoraRtcChannel rtcChannel, string token);

        // @optional -(void)rtcChannelRequestToken:(AgoraRtcChannel * _Nonnull)rtcChannel;
        [Export("rtcChannelRequestToken:")]
        [EventArgs("RtcChannelRequestToken")]
        void RtcChannelRequestToken(AgoraRtcChannel rtcChannel);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel activeSpeaker:(NSUInteger)speakerUid;
        [Export("rtcChannel:activeSpeaker:")]
        [EventArgs("ActiveSpeaker")]
        void ActiveSpeaker(AgoraRtcChannel rtcChannel, nuint speakerUid);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel videoSizeChangedOfUid:(NSUInteger)uid size:(CGSize)size rotation:(NSInteger)rotation;
        [Export("rtcChannel:videoSizeChangedOfUid:size:rotation:")]
        [EventArgs("VideoSizeChangedOfUid")]
        void VideoSizeChangedOfUid(AgoraRtcChannel rtcChannel, nuint uid, CGSize size, nint rotation);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel remoteVideoStateChangedOfUid:(NSUInteger)uid state:(AgoraVideoRemoteState)state reason:(AgoraVideoRemoteStateReason)reason elapsed:(NSInteger)elapsed;
        [Export("rtcChannel:remoteVideoStateChangedOfUid:state:reason:elapsed:")]
        [EventArgs("RemoteVideoStateChangedOfUid")]
        void RemoteVideoStateChangedOfUid(AgoraRtcChannel rtcChannel, nuint uid, VideoRemoteState state, VideoRemoteStateReason reason, nint elapsed);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel superResolutionEnabledOfUid:(NSUInteger)uid enabled:(BOOL)enabled reason:(AgoraSuperResolutionStateReason)reason;
        [Export("rtcChannel:superResolutionEnabledOfUid:enabled:reason:")]
        [EventArgs("SuperResolutionEnabledOfUid")]
        void SuperResolutionEnabledOfUid(AgoraRtcChannel rtcChannel, nuint uid, bool enabled, SuperResolutionStateReason reason);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel remoteAudioStateChangedOfUid:(NSUInteger)uid state:(AgoraAudioRemoteState)state reason:(AgoraAudioRemoteStateReason)reason elapsed:(NSInteger)elapsed;
        [Export("rtcChannel:remoteAudioStateChangedOfUid:state:reason:elapsed:")]
        [EventArgs("RemoteAudioStateChangedOfUid")]
        void RemoteAudioStateChangedOfUid(AgoraRtcChannel rtcChannel, nuint uid, AudioRemoteState state, AudioRemoteStateReason reason, nint elapsed);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didLocalPublishFallbackToAudioOnly:(BOOL)isFallbackOrRecover;
        [Export("rtcChannel:didLocalPublishFallbackToAudioOnly:")]
        [EventArgs("DidLocalPublishFallbackToAudioOnly")]
        void DidLocalPublishFallbackToAudioOnly(AgoraRtcChannel rtcChannel, bool isFallbackOrRecover);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didRemoteSubscribeFallbackToAudioOnly:(BOOL)isFallbackOrRecover byUid:(NSUInteger)uid;
        [Export("rtcChannel:didRemoteSubscribeFallbackToAudioOnly:byUid:")]
        [EventArgs("DidRemoteSubscribeFallbackToAudioOnly")]
        void DidRemoteSubscribeFallbackToAudioOnly(AgoraRtcChannel rtcChannel, bool isFallbackOrRecover, nuint uid);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel reportRtcStats:(AgoraChannelStats * _Nonnull)stats;
        [Export("rtcChannel:reportRtcStats:")]
        [EventArgs("ReportRtcStats")]
        void RtcChannel(AgoraRtcChannel rtcChannel, AgoraChannelStats stats);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel networkQuality:(NSUInteger)uid txQuality:(AgoraNetworkQuality)txQuality rxQuality:(AgoraNetworkQuality)rxQuality;
        [Export("rtcChannel:networkQuality:txQuality:rxQuality:")]
        [EventArgs("NetworkQuality")]
        void NetworkQuality(AgoraRtcChannel rtcChannel, nuint uid, NetworkQuality txQuality, NetworkQuality rxQuality);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel remoteVideoStats:(AgoraRtcRemoteVideoStats * _Nonnull)stats;
        [Export("rtcChannel:remoteVideoStats:")]
        [EventArgs("RemoteVideoStats")]
        void RemoteVideoStats(AgoraRtcChannel rtcChannel, AgoraRtcRemoteVideoStats stats);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel remoteAudioStats:(AgoraRtcRemoteAudioStats * _Nonnull)stats;
        [Export("rtcChannel:remoteAudioStats:")]
        [EventArgs("RemoteAudioStats")]
        void RemoteAudioStats(AgoraRtcChannel rtcChannel, AgoraRtcRemoteAudioStats stats);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel rtmpStreamingChangedToState:(NSString * _Nonnull)url state:(AgoraRtmpStreamingState)state errorCode:(AgoraRtmpStreamingErrorCode)errorCode;
        [Export("rtcChannel:rtmpStreamingChangedToState:state:errorCode:")]
        [EventArgs("RtmpStreamingChangedToState")]
        void RtmpStreamingChangedToState(AgoraRtcChannel rtcChannel, string url, RtmpStreamingState state, RtmpStreamingErrorCode errorCode);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel rtmpStreamingEventWithUrl:(NSString * _Nonnull)url eventCode:(AgoraRtmpStreamingEvent)eventCode;
        [Export("rtcChannel:rtmpStreamingEventWithUrl:eventCode:")]
        [EventArgs("RtmpStreamingEventWithUrl")]
        void RtmpStreamingEventWithUrl(AgoraRtcChannel rtcChannel, string url, RtmpStreamingEvent eventCode);

        // @optional -(void)rtcChannelTranscodingUpdated:(AgoraRtcChannel * _Nonnull)rtcChannel;
        [Export("rtcChannelTranscodingUpdated:")]
        [EventArgs("RtcChannelTranscodingUpdated")]
        void RtcChannelTranscodingUpdated(AgoraRtcChannel rtcChannel);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel streamInjectedStatusOfUrl:(NSString * _Nonnull)url uid:(NSUInteger)uid status:(AgoraInjectStreamStatus)status;
        [Export("rtcChannel:streamInjectedStatusOfUrl:uid:status:")]
        [EventArgs("StreamInjectedStatusOfUrl")]
        void StreamInjectedStatusOfUrl(AgoraRtcChannel rtcChannel, string url, nuint uid, InjectStreamStatus status);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel receiveStreamMessageFromUid:(NSUInteger)uid streamId:(NSInteger)streamId data:(NSData * _Nonnull)data;
        [Export("rtcChannel:receiveStreamMessageFromUid:streamId:data:")]
        [EventArgs("ReceiveStreamMessageFromUid")]
        void ReceiveStreamMessageFromUid(AgoraRtcChannel rtcChannel, nuint uid, nint streamId, NSData data);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didOccurStreamMessageErrorFromUid:(NSUInteger)uid streamId:(NSInteger)streamId error:(NSInteger)error missed:(NSInteger)missed cached:(NSInteger)cached;
        [Export("rtcChannel:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:")]
        [EventArgs("DidOccurStreamMessageErrorFromUid")]
        void DidOccurStreamMessageErrorFromUid(AgoraRtcChannel rtcChannel, nuint uid, nint streamId, nint error, nint missed, nint cached);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel channelMediaRelayStateDidChange:(AgoraChannelMediaRelayState)state error:(AgoraChannelMediaRelayError)error;
        [Export("rtcChannel:channelMediaRelayStateDidChange:error:")]
        [EventArgs("ChannelMediaRelayStateDidChange")]
        void ChannelMediaRelayStateDidChange(AgoraRtcChannel rtcChannel, ChannelMediaRelayState state, ChannelMediaRelayError error);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didReceiveChannelMediaRelayEvent:(AgoraChannelMediaRelayEvent)event;
        [Export("rtcChannel:didReceiveChannelMediaRelayEvent:")]
        [EventArgs("DidReceiveChannelMediaRelayEvent")]
        void DidReceiveChannelMediaRelayEvent(AgoraRtcChannel rtcChannel, ChannelMediaRelayEvent relayEvent);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didAudioPublishStateChange:(AgoraStreamPublishState)oldState newState:(AgoraStreamPublishState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcChannel:didAudioPublishStateChange:newState:elapseSinceLastState:")]
        [EventArgs("DidAudioPublishStateChange")]
        void DidAudioPublishStateChange(AgoraRtcChannel rtcChannel, StreamPublishState oldState, StreamPublishState newState, nint elapseSinceLastState);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didVideoPublishStateChange:(AgoraStreamPublishState)oldState newState:(AgoraStreamPublishState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcChannel:didVideoPublishStateChange:newState:elapseSinceLastState:")]
        [EventArgs("DidVideoPublishStateChange")]
        void DidVideoPublishStateChange(AgoraRtcChannel rtcChannel, StreamPublishState oldState, StreamPublishState newState, nint elapseSinceLastState);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didAudioSubscribeStateChange:(NSUInteger)uid oldState:(AgoraStreamSubscribeState)oldState newState:(AgoraStreamSubscribeState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcChannel:didAudioSubscribeStateChange:oldState:newState:elapseSinceLastState:")]
        [EventArgs("DidAudioSubscribeStateChange")]
        void DidAudioSubscribeStateChange(AgoraRtcChannel rtcChannel, nuint uid, StreamSubscribeState oldState, StreamSubscribeState newState, nint elapseSinceLastState);

        // @optional -(void)rtcChannel:(AgoraRtcChannel * _Nonnull)rtcChannel didVideoSubscribeStateChange:(NSUInteger)uid oldState:(AgoraStreamSubscribeState)oldState newState:(AgoraStreamSubscribeState)newState elapseSinceLastState:(NSInteger)elapseSinceLastState;
        [Export("rtcChannel:didVideoSubscribeStateChange:oldState:newState:elapseSinceLastState:")]
        [EventArgs("DidVideoSubscribeStateChange")]
        void DidVideoSubscribeStateChange(AgoraRtcChannel rtcChannel, nuint uid, StreamSubscribeState oldState, StreamSubscribeState newState, nint elapseSinceLastState);

    }

    [Protocol]
    interface IAgoraRtcChannelDelegate
    {
    }
}
