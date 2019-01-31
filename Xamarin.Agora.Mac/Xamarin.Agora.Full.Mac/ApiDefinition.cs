using System;
using Xamarin.Agora.Mac;
using AppKit;
using CoreGraphics;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace Xamarin.Agora.Mac
{
    // @interface AgoraRtcVideoCanvas : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCanvas
    {
        // @property (nonatomic, strong) VIEW_CLASS * _Nullable view;
        [NullAllowed, Export("view", ArgumentSemantic.Strong)]
        NSView View { get; set; }

        // @property (assign, nonatomic) AgoraVideoRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        AgoraVideoRenderMode RenderMode { get; set; }

        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }
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

        // @property (assign, nonatomic) AgoraVideoStreamType rxStreamType;
        [Export("rxStreamType", ArgumentSemantic.Assign)]
        AgoraVideoStreamType RxStreamType { get; set; }
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
        AgoraVideoCodecProfileType VideoCodecProfile { get; set; }

        // @property (nonatomic, strong) COLOR_CLASS * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        NSColor BackgroundColor { get; set; }

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
        AgoraAudioSampleRateType AudioSampleRate { get; set; }

        // @property (assign, nonatomic) NSInteger audioBitrate;
        [Export("audioBitrate")]
        nint AudioBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audioChannels;
        [Export("audioChannels")]
        nint AudioChannels { get; set; }

        // +(AgoraLiveTranscoding * _Nonnull)defaultTranscoding;
        [Static]
        [Export("defaultTranscoding")]
        //[Verify(MethodToProperty)]
        AgoraLiveTranscoding DefaultTranscoding { get; }
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
        AgoraAudioSampleRateType AudioSampleRate { get; set; }

        // @property (assign, nonatomic) NSInteger audioBitrate;
        [Export("audioBitrate")]
        nint AudioBitrate { get; set; }

        // @property (assign, nonatomic) NSInteger audioChannels;
        [Export("audioChannels")]
        nint AudioChannels { get; set; }

        // +(AgoraLiveInjectStreamConfig * _Nonnull)defaultConfig;
        [Static]
        [Export("defaultConfig")]
        //[Verify(MethodToProperty)]
        AgoraLiveInjectStreamConfig DefaultConfig { get; }
    }

    // @interface AgoraRtcVideoCompositingRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCompositingRegion
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) CGFloat x;
        [Export("x")]
        nfloat X { get; set; }

        // @property (assign, nonatomic) CGFloat y;
        [Export("y")]
        nfloat Y { get; set; }

        // @property (assign, nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; set; }

        // @property (assign, nonatomic) CGFloat height;
        [Export("height")]
        nfloat Height { get; set; }

        // @property (assign, nonatomic) NSInteger zOrder;
        [Export("zOrder")]
        nint ZOrder { get; set; }

        // @property (assign, nonatomic) CGFloat alpha;
        [Export("alpha")]
        nfloat Alpha { get; set; }

        // @property (assign, nonatomic) AgoraVideoRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        AgoraVideoRenderMode RenderMode { get; set; }
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

        // @property (copy, nonatomic) NSString * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor")]
        string BackgroundColor { get; set; }

        // @property (copy, nonatomic) NSArray<AgoraRtcVideoCompositingRegion *> * _Nullable regions;
        [NullAllowed, Export("regions", ArgumentSemantic.Copy)]
        AgoraRtcVideoCompositingRegion[] Regions { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable appData;
        [NullAllowed, Export("appData")]
        string AppData { get; set; }
    }

    // @interface AgoraPublisherConfiguration : NSObject
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

        // @property (assign, nonatomic) NSInteger defaultLayout;
        [Export("defaultLayout")]
        nint DefaultLayout { get; set; }

        // @property (assign, nonatomic) AgoraRtmpStreamLifeCycle lifeCycle;
        [Export("lifeCycle", ArgumentSemantic.Assign)]
        AgoraRtmpStreamLifeCycle LifeCycle { get; set; }

        // @property (assign, nonatomic) NSInteger injectStreamWidth;
        [Export("injectStreamWidth")]
        nint InjectStreamWidth { get; set; }

        // @property (assign, nonatomic) NSInteger injectStreamHeight;
        [Export("injectStreamHeight")]
        nint InjectStreamHeight { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable injectStreamUrl;
        [NullAllowed, Export("injectStreamUrl")]
        string InjectStreamUrl { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable publishUrl;
        [NullAllowed, Export("publishUrl")]
        string PublishUrl { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable rawStreamUrl;
        [NullAllowed, Export("rawStreamUrl")]
        string RawStreamUrl { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable extraInfo;
        [NullAllowed, Export("extraInfo")]
        string ExtraInfo { get; set; }

        // -(BOOL)validate;
        [Export("validate")]
        //[Verify(MethodToProperty)]
        bool Validate();
    }

    // @interface AgoraRtcDeviceInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcDeviceInfo
    {
        // @property (assign, nonatomic) int index;
        [Export("index")]
        int Index { get; set; }

        // @property (assign, nonatomic) AgoraMediaDeviceType type;
        [Export("type", ArgumentSemantic.Assign)]
        AgoraMediaDeviceType Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable deviceId;
        [NullAllowed, Export("deviceId")]
        string DeviceId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable deviceName;
        [NullAllowed, Export("deviceName")]
        string DeviceName { get; set; }
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

    // @protocol AgoraVideoFrameConsumer <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraVideoFrameConsumer
    {
        // @required -(void)consumePixelBuffer:(CVPixelBufferRef _Nonnull)pixelBuffer withTimestamp:(CMTime)timestamp rotation:(AgoraVideoRotation)rotation;
        [Abstract]
        [Export("consumePixelBuffer:withTimestamp:rotation:")]
        unsafe void ConsumePixelBuffer(IntPtr pixelBuffer, CMTime timestamp, AgoraVideoRotation rotation);

        // @required -(void)consumeRawData:(void * _Nonnull)rawData withTimestamp:(CMTime)timestamp format:(AgoraVideoPixelFormat)format size:(CGSize)size rotation:(AgoraVideoRotation)rotation;
        [Abstract]
        [Export("consumeRawData:withTimestamp:format:size:rotation:")]
        unsafe void ConsumeRawData(IntPtr rawData, CMTime timestamp, AgoraVideoPixelFormat format, CGSize size, AgoraVideoRotation rotation);
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
        AgoraVideoBufferType BufferType { get; }
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
        AgoraVideoBufferType BufferType { get; }

        // @required -(AgoraVideoPixelFormat)pixelFormat;
        [Abstract]
        [Export("pixelFormat")]
        //[Verify(MethodToProperty)]
        AgoraVideoPixelFormat PixelFormat { get; }

        // @optional -(void)renderPixelBuffer:(CVPixelBufferRef _Nonnull)pixelBuffer rotation:(AgoraVideoRotation)rotation;
        [Export("renderPixelBuffer:rotation:")]
        unsafe void RenderPixelBuffer(IntPtr pixelBuffer, AgoraVideoRotation rotation);

        // @optional -(void)renderRawData:(void * _Nonnull)rawData size:(CGSize)size rotation:(AgoraVideoRotation)rotation;
        [Export("renderRawData:size:rotation:")]
        unsafe void RenderRawData(IntPtr rawData, CGSize size, AgoraVideoRotation rotation);
    }
    [Protocol]
    interface IAgoraVideoSourceProtocol
    {
    }

    // @interface AgoraRtcDefaultCamera : NSObject <AgoraVideoSourceProtocol>
    [BaseType(typeof(NSObject))]
    interface AgoraRtcDefaultCamera : IAgoraVideoSourceProtocol
    {
    }

    // @interface AgoraRtcScreenCapture : NSObject <AgoraVideoSourceProtocol>
    [BaseType(typeof(NSObject))]
    interface AgoraRtcScreenCapture : IAgoraVideoSourceProtocol
    {
        // @property (readonly, nonatomic) NSUInteger windowId;
        [Export("windowId")]
        nuint WindowId { get; }

        // +(instancetype _Nonnull)fullScreenCaptureWithFrequency:(NSInteger)captureFrequency bitRate:(NSInteger)bitRate;
        [Static]
        [Export("fullScreenCaptureWithFrequency:bitRate:")]
        AgoraRtcScreenCapture FullScreenCaptureWithFrequency(nint captureFrequency, nint bitRate);

        // +(instancetype _Nonnull)windowCaptureWithId:(CGWindowID)windowId captureFrequency:(NSInteger)captureFrequency bitRate:(NSInteger)bitRate rect:(CGRect)rect;
        [Static]
        [Export("windowCaptureWithId:captureFrequency:bitRate:rect:")]
        AgoraRtcScreenCapture WindowCaptureWithId(uint windowId, nint captureFrequency, nint bitRate, CGRect rect);
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
        AgoraVideoRenderMode Mode { get; set; }

        // -(instancetype _Nonnull)initWithView:(VIEW_CLASS * _Nonnull)view renderMode:(AgoraVideoRenderMode)mode;
        [Export("initWithView:renderMode:")]
        IntPtr Constructor(NSView view, AgoraVideoRenderMode mode);
    }

    // @protocol AgoraRtcEngineDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraRtcEngineDelegate
    {
        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOccurWarning:(AgoraWarningCode)warningCode;
        [Export("rtcEngine:didOccurWarning:")]
        [EventArgs("DidOccurWarning")]
        void DidOccurWarning(AgoraRtcEngineKit engine, AgoraWarningCode warningCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOccurError:(AgoraErrorCode)errorCode;
        [Export("rtcEngine:didOccurError:")]
        [EventArgs("DidOccurError")]
        void DidOccurError(AgoraRtcEngineKit engine, AgoraErrorCode errorCode);

        // @optional -(void)rtcEngineMediaEngineDidLoaded:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineMediaEngineDidLoaded:")]
        [EventArgs("RtcEngineMediaEngineDidLoaded")]
        void RtcEngineMediaEngineDidLoaded(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineMediaEngineDidStartCall:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineMediaEngineDidStartCall:")]
        [EventArgs("RtcEngineMediaEngineDidStartCall")]
        void RtcEngineMediaEngineDidStartCall(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineRequestToken:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRequestToken:")]
        [EventArgs("RtcEngineRequestToken")]
        void RtcEngineRequestToken(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidInterrupted:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidInterrupted:")]
        [EventArgs("RtcEngineConnectionDidInterrupted")]
        void RtcEngineConnectionDidInterrupted(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidLost:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidLost:")]
        [EventArgs("RtcEngineConnectionDidLost")]
        void RtcEngineConnectionDidLost(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidBanned:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineConnectionDidBanned:")]
        [EventArgs("RtcEngineConnectionDidBanned")]
        void RtcEngineConnectionDidBanned(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine reportRtcStats:(AgoraChannelStats * _Nonnull)stats;
        [Export("rtcEngine:reportRtcStats:")]
        [EventArgs("ReportRtcStats")]
        void ReportRtcStats(AgoraRtcEngineKit engine, AgoraChannelStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine lastmileQuality:(AgoraNetworkQuality)quality;
        [Export("rtcEngine:lastmileQuality:")]
        [EventArgs("LastmileQuality")]
        void LastmileQuality(AgoraRtcEngineKit engine, AgoraNetworkQuality quality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didApiCallExecute:(NSInteger)error api:(NSString * _Nonnull)api result:(NSString * _Nonnull)result;
        [Export("rtcEngine:didApiCallExecute:api:result:")]
        [EventArgs("DidApiCallExecute")]
        void DidApiCallExecute(AgoraRtcEngineKit engine, nint error, string api, string result);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didRefreshRecordingServiceStatus:(NSInteger)status;
        [Export("rtcEngine:didRefreshRecordingServiceStatus:")]
        [EventArgs("DidRefreshRecordigServiceStatus")]
        void DidRefreshRecordigServiceStatus(AgoraRtcEngineKit engine, nint status);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine device:(NSString * _Nonnull)deviceId type:(AgoraMediaDeviceType)deviceType stateChanged:(NSInteger)state;
        [Export("rtcEngine:device:type:stateChanged:")]
        [EventArgs("StateChanged")]
        void StateChanged(AgoraRtcEngineKit engine, string deviceId, AgoraMediaDeviceType deviceType, nint state);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didJoinChannel:(NSString * _Nonnull)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinChannel:withUid:elapsed:")]
        [EventArgs("DidJoinChannel")]
        void DidJoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didRejoinChannel:(NSString * _Nonnull)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didRejoinChannel:withUid:elapsed:")]
        [EventArgs("DidRejoinChannel")]
        void DidRejoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didClientRoleChanged:(AgoraClientRole)oldRole newRole:(AgoraClientRole)newRole;
        [Export("rtcEngine:didClientRoleChanged:newRole:")]
        [EventArgs("DidClientRoleChanged")]
        void DidClientRoleChanged(AgoraRtcEngineKit engine, AgoraClientRole oldRole, AgoraClientRole newRole);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLeaveChannelWithStats:(AgoraChannelStats * _Nonnull)stats;
        [Export("rtcEngine:didLeaveChannelWithStats:")]
        [EventArgs("DidLeaveChannelWithStats")]
        void DidLeaveChannelWithStats(AgoraRtcEngineKit engine, AgoraChannelStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine networkQuality:(NSUInteger)uid txQuality:(AgoraNetworkQuality)txQuality rxQuality:(AgoraNetworkQuality)rxQuality;
        [Export("rtcEngine:networkQuality:txQuality:rxQuality:")]
        [EventArgs("NetwokQuality")]
        void NetwokQuality(AgoraRtcEngineKit engine, nuint uid, AgoraNetworkQuality txQuality, AgoraNetworkQuality rxQuality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstLocalAudioFrame:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalAudioFrame:")]
        [EventArgs("FirstLocalAudioFrame")]
        void FirstLocalAudioFrame(AgoraRtcEngineKit engine, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didAudioRouteChanged:(AgoraAudioOutputRouting)routing;
        [Export("rtcEngine:didAudioRouteChanged:")]
        [EventArgs("DidAudioRouteChanged")]
        void DidAudioRouteChanged(AgoraRtcEngineKit engine, AgoraAudioOutputRouting routing);

        // @optional -(void)rtcEngineLocalAudioMixingDidFinish:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineLocalAudioMixingDidFinish:")]
        [EventArgs("RtcEngineLocalAudioMixingDidFinish")]
        void RtcEngineLocalAudioMixingDidFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineDidAudioEffectFinish:(AgoraRtcEngineKit * _Nonnull)engine soundId:(NSInteger)soundId;
        [Export("rtcEngineDidAudioEffectFinish:soundId:")]
        [EventArgs("RtcEngineDidAudioEffectFinish")]
        void RtcEngineDidAudioEffectFinish(AgoraRtcEngineKit engine, nint soundId);

        // @optional -(void)rtcEngineCameraDidReady:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineCameraDidReady:")]
        [EventArgs("RtcEngineCameraDidReady")]
        void RtcEngineCameraDidReady(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineVideoDidStop:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineVideoDidStop:")]
        [EventArgs("RtcEngineVideoDidStop")]
        void RtcEngineVideoDidStop(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstLocalVideoFrameWithSize:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalVideoFrameWithSize:elapsed:")]
        [EventArgs("FirstLocalVideoFrameWithSize")]
        void FirstLocalVideoFrameWithSize(AgoraRtcEngineKit engine, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine localVideoStats:(AgoraRtcLocalVideoStats * _Nonnull)stats;
        [Export("rtcEngine:localVideoStats:")]
        [EventArgs("LocalVideoStats")]
        void LocalVideoStats(AgoraRtcEngineKit engine, AgoraRtcLocalVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didJoinedOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinedOfUid:elapsed:")]
        [EventArgs("DidJoinedOfUid")]
        void DidJoinedOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOfflineOfUid:(NSUInteger)uid reason:(AgoraUserOfflineReason)reason;
        [Export("rtcEngine:didOfflineOfUid:reason:")]
        [EventArgs("DidOfflineOfUid")]
        void DidOfflineOfUid(AgoraRtcEngineKit engine, nuint uid, AgoraUserOfflineReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine receiveStreamMessageFromUid:(NSUInteger)uid streamId:(NSInteger)streamId data:(NSData * _Nonnull)data;
        [Export("rtcEngine:receiveStreamMessageFromUid:streamId:data:")]
        [EventArgs("ReceiveStreamMessageFromUid")]
        void ReceiveStreamMessageFromUid(AgoraRtcEngineKit engine, nuint uid, nint streamId, NSData data);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didOccurStreamMessageErrorFromUid:(NSUInteger)uid streamId:(NSInteger)streamId error:(NSInteger)error missed:(NSInteger)missed cached:(NSInteger)cached;
        [Export("rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:")]
        [EventArgs("DidOccurStreamMessageErrorFromUid")]
        void DidOccurStreamMessageErrorFromUid(AgoraRtcEngineKit engine, nuint uid, nint streamId, nint error, nint missed, nint cached);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteAudioFrameOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteAudioFrameOfUid:elapsed:")]
        [EventArgs("FirstRemoteAudioFrameOfUid")]
        void FirstRemoteAudioFrameOfUid(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didAudioMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didAudioMuted:byUid:")]
        [EventArgs("DidAudioMuted")]
        void DidAudioMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine reportAudioVolumeIndicationOfSpeakers:(NSArray<AgoraRtcAudioVolumeInfo *> * _Nonnull)speakers totalVolume:(NSInteger)totalVolume;
        [Export("rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:")]
        [EventArgs("ReportAudioVolumeIndicationOfSpeakers")]
        void ReportAudioVolumeIndicationOfSpeakers(AgoraRtcEngineKit engine, AgoraRtcAudioVolumeInfo[] speakers, nint totalVolume);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine activeSpeaker:(NSUInteger)speakerUid;
        [Export("rtcEngine:activeSpeaker:")]
        [EventArgs("OnActiveSpeaker")]
        void ActiveSpeaker(AgoraRtcEngineKit engine, nuint speakerUid);

        // @optional -(void)rtcEngineRemoteAudioMixingDidStart:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRemoteAudioMixingDidStart:")]
        [EventArgs("RtcEngineRemoteAudioMixingDidStart")]
        void RtcEngineRemoteAudioMixingDidStart(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineRemoteAudioMixingDidFinish:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineRemoteAudioMixingDidFinish:")]
        [EventArgs("RtcEngineRemoteAudioMixingDidFinish")]
        void RtcEngineRemoteAudioMixingDidFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine audioQualityOfUid:(NSUInteger)uid quality:(AgoraNetworkQuality)quality delay:(NSUInteger)delay lost:(NSUInteger)lost;
        [Export("rtcEngine:audioQualityOfUid:quality:delay:lost:")]
        [EventArgs("AudioQualityOfUid")]
        void AudioQualityOfUid(AgoraRtcEngineKit engine, nuint uid, AgoraNetworkQuality quality, nuint delay, nuint lost);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteVideoDecodedOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:")]
        [EventArgs("FirstRemoteVideoDecodedOfUid")]
        void FirstRemoteVideoDecodedOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine firstRemoteVideoFrameOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:")]
        [EventArgs("FirstRemoteVideoFrameOfUid")]
        void FirstRemoteVideoFrameOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine videoSizeChangedOfUid:(NSUInteger)uid size:(CGSize)size rotation:(NSInteger)rotation;
        [Export("rtcEngine:videoSizeChangedOfUid:size:rotation:")]
        [EventArgs("VideoSizeChangedOfUid")]
        void VideoSizeChangedOfUid(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint rotation);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteVideoStateChangedOfUid:(NSUInteger)uid state:(AgoraVideoRemoteState)state;
        [Export("rtcEngine:remoteVideoStateChangedOfUid:state:")]
        [EventArgs("RemoteVideoStateChangedOfUid")]
        void RemoteVideoStateChangedOfUid(AgoraRtcEngineKit engine, nuint uid, AgoraVideoRemoteState state);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didVideoMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoMuted:byUid:")]
        [EventArgs("DidVideoMuted")]
        void DidVideoMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoEnabled:byUid:")]
        [EventArgs("DidVideoEnabled")]
        void DidVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine didLocalVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didLocalVideoEnabled:byUid:")]
        [EventArgs("DidLocalVideoEnabled")]
        void DidLocalVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine remoteVideoStats:(AgoraRtcRemoteVideoStats * _Nonnull)stats;
        [Export("rtcEngine:remoteVideoStats:")]
        [EventArgs("RemoteVideoStats")]
        void RemoteVideoStats(AgoraRtcEngineKit engine, AgoraRtcRemoteVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamPublishedWithUrl:(NSString * _Nonnull)url errorCode:(AgoraErrorCode)errorCode;
        [Export("rtcEngine:streamPublishedWithUrl:errorCode:")]
        [EventArgs("StreamPublishedWithUrl")]
        void StreamPublishedWithUrl(AgoraRtcEngineKit engine, string url, AgoraErrorCode errorCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamUnpublishedWithUrl:(NSString * _Nonnull)url;
        [Export("rtcEngine:streamUnpublishedWithUrl:")]
        [EventArgs("StreamUnpublishedWithUrl")]
        void StreamUnpublishedWithUrl(AgoraRtcEngineKit engine, string url);

        // @optional -(void)rtcEngineTranscodingUpdated:(AgoraRtcEngineKit * _Nonnull)engine;
        [Export("rtcEngineTranscodingUpdated:")]
        [EventArgs("RtcEngineTranscodingUpdated")]
        void RtcEngineTranscodingUpdated(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit * _Nonnull)engine streamInjectedStatusOfUrl:(NSString * _Nonnull)url uid:(NSUInteger)uid status:(AgoraInjectStreamStatus)status;
        [Export("rtcEngine:streamInjectedStatusOfUrl:uid:status:")]
        [EventArgs("StreamInjectedStatusOfUrl")]
        void StreamInjectedStatusOfUrl(AgoraRtcEngineKit engine, string url, nuint uid, AgoraInjectStreamStatus status);
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

        // @property (nonatomic, weak) id<AgoraRtcEngineDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // +(instancetype _Nonnull)sharedEngineWithAppId:(NSString * _Nonnull)appId delegate:(id<AgoraRtcEngineDelegate> _Nullable)delegate;
        [Static]
        [Export("sharedEngineWithAppId:delegate:")]
        AgoraRtcEngineKit SharedEngineWithAppId(string appId, [NullAllowed] AgoraRtcEngineDelegate @delegate);

        // +(instancetype _Nonnull)sharedEngineWithAppId:(NSString * _Nonnull)AppId error:(void (^ _Nullable)(AgoraErrorCode))errorBlock __attribute__((deprecated("")));
        [Static]
        [Obsolete("use sharedEngineWithAppId:delegate: instead.")]
        [Export("sharedEngineWithAppId:error:")]
        AgoraRtcEngineKit SharedEngineWithAppId(string AppId, [NullAllowed] Action<AgoraErrorCode> errorBlock);

        // +(void)destroy;
        [Static]
        [Export("destroy")]
        void Destroy();

        // +(NSString * _Nonnull)getSdkVersion;
        [Static]
        [Export("getSdkVersion")]
        //[Verify(MethodToProperty)]
        string SdkVersion { get; }

        // +(NSString * _Nonnull)getMediaEngineVersion;
        [Static]
        [Export("getMediaEngineVersion")]
        [Obsolete("use getSdkVersion instead")]
        //[Verify(MethodToProperty)]
        string MediaEngineVersion { get; }

        // -(void * _Nullable)getNativeHandle;
        [NullAllowed, Export("getNativeHandle")]
        //[Verify(MethodToProperty)]
        unsafe IntPtr NativeHandle { get; }

        // -(int)joinChannelByToken:(NSString * _Nullable)token channelId:(NSString * _Nonnull)channelId info:(NSString * _Nullable)info uid:(NSUInteger)uid joinSuccess:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))joinSuccessBlock;
        [Export("joinChannelByToken:channelId:info:uid:joinSuccess:")]
        int JoinChannelByToken([NullAllowed] string token, string channelId, [NullAllowed] string info, nuint uid, [NullAllowed] Action<NSString, nuint, nint> joinSuccessBlock);

        // -(int)leaveChannel:(void (^ _Nullable)(AgoraChannelStats * _Nonnull))leaveChannelBlock;
        [Export("leaveChannel:")]
        int LeaveChannel([NullAllowed] Action<AgoraChannelStats> leaveChannelBlock);

        // -(int)setChannelProfile:(AgoraChannelProfile)profile;
        [Export("setChannelProfile:")]
        int SetChannelProfile(AgoraChannelProfile profile);

        // -(int)setClientRole:(AgoraClientRole)role;
        [Export("setClientRole:")]
        int SetClientRole(AgoraClientRole role);

        // -(int)renewToken:(NSString * _Nonnull)token;
        [Export("renewToken:")]
        int RenewToken(string token);

        // -(int)enableWebSdkInteroperability:(BOOL)enabled;
        [Export("enableWebSdkInteroperability:")]
        int EnableWebSdkInteroperability(bool enabled);

        // -(int)enableLastmileTest;
        [Export("enableLastmileTest")]
        //[Verify(MethodToProperty)]
        int EnableLastmileTest();

        // -(int)disableLastmileTest;
        [Export("disableLastmileTest")]
        //[Verify(MethodToProperty)]
        int DisableLastmileTest();

        // -(int)setParameters:(NSString * _Nonnull)options;
        [Export("setParameters:")]
        int SetParameters(string options);

        // -(NSString * _Nullable)getParameter:(NSString * _Nonnull)parameter args:(NSString * _Nullable)args;
        [Export("getParameter:args:")]
        [return: NullAllowed]
        string GetParameter(string parameter, [NullAllowed] string args);

        // -(int)setLogFile:(NSString * _Nonnull)filePath;
        [Export("setLogFile:")]
        int SetLogFile(string filePath);

        // -(int)setLogFilter:(NSUInteger)filter;
        [Export("setLogFilter:")]
        int SetLogFilter(nuint filter);

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

        // -(int)enableVideo;
        [Export("enableVideo")]
        //[Verify(MethodToProperty)]
        int EnableVideo();

        // -(int)disableVideo;
        [Export("disableVideo")]
        //[Verify(MethodToProperty)]
        int DisableVideo();

        // -(int)enableLocalVideo:(BOOL)enabled;
        [Export("enableLocalVideo:")]
        int EnableLocalVideo(bool enabled);

        // -(int)setVideoProfile:(AgoraVideoProfile)profile swapWidthAndHeight:(BOOL)swapWidthAndHeight;
        [Export("setVideoProfile:swapWidthAndHeight:")]
        int SetVideoProfile(AgoraVideoProfile profile, bool swapWidthAndHeight);

        // -(int)setVideoResolution:(CGSize)size andFrameRate:(NSInteger)frameRate bitrate:(NSInteger)bitrate;
        [Export("setVideoResolution:andFrameRate:bitrate:")]
        int SetVideoResolution(CGSize size, nint frameRate, nint bitrate);

        // -(int)enableLocalVideoCapture:(_Bool)enabled;
        [Export("enableLocalVideoCapture:")]
        int EnableLocalVideoCapture(bool enabled);

        // -(int)enableLocalVideoRender:(_Bool)enabled;
        [Export("enableLocalVideoRender:")]
        int EnableLocalVideoRender(bool enabled);

        // -(int)enableLocalVideoSend:(_Bool)enabled;
        [Export("enableLocalVideoSend:")]
        int EnableLocalVideoSend(bool enabled);

        // -(int)setVideoQualityParameters:(BOOL)preferFrameRateOverImageQuality;
        [Export("setVideoQualityParameters:")]
        int SetVideoQualityParameters(bool preferFrameRateOverImageQuality);

        // -(int)setupLocalVideo:(AgoraRtcVideoCanvas * _Nullable)local;
        [Export("setupLocalVideo:")]
        int SetupLocalVideo([NullAllowed] AgoraRtcVideoCanvas local);

        // -(int)setLocalRenderMode:(AgoraVideoRenderMode)mode;
        [Export("setLocalRenderMode:")]
        int SetLocalRenderMode(AgoraVideoRenderMode mode);

        // -(int)setLocalVideoMirrorMode:(AgoraVideoMirrorMode)mode;
        [Export("setLocalVideoMirrorMode:")]
        int SetLocalVideoMirrorMode(AgoraVideoMirrorMode mode);

        // -(int)startPreview;
        [Export("startPreview")]
        //[Verify(MethodToProperty)]
        int StartPreview();

        // -(int)stopPreview;
        [Export("stopPreview")]
        //[Verify(MethodToProperty)]
        int StopPreview();

        // -(int)setupRemoteVideo:(AgoraRtcVideoCanvas * _Nonnull)remote;
        [Export("setupRemoteVideo:")]
        int SetupRemoteVideo(AgoraRtcVideoCanvas remote);

        // -(int)addVideoWatermark:(AgoraImage * _Nonnull)watermark;
        [Export("addVideoWatermark:")]
        int AddVideoWatermark(AgoraImage watermark);

        // -(void)clearVideoWatermarks;
        [Export("clearVideoWatermarks")]
        void ClearVideoWatermarks();

        // -(int)setRemoteRenderMode:(NSUInteger)uid mode:(AgoraVideoRenderMode)mode;
        [Export("setRemoteRenderMode:mode:")]
        int SetRemoteRenderMode(nuint uid, AgoraVideoRenderMode mode);

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

        // -(int)switchView:(NSUInteger)uid1 andAnother:(NSUInteger)uid2 __attribute__((deprecated("")));
        [Export("switchView:andAnother:")]
        int SwitchView(nuint uid1, nuint uid2);

        // -(int)enableDualStreamMode:(BOOL)enabled;
        [Export("enableDualStreamMode:")]
        int EnableDualStreamMode(bool enabled);

        // -(int)setRemoteVideoStream:(NSUInteger)uid type:(AgoraVideoStreamType)streamType;
        [Export("setRemoteVideoStream:type:")]
        int SetRemoteVideoStream(nuint uid, AgoraVideoStreamType streamType);

        // -(int)setRemoteDefaultVideoStreamType:(AgoraVideoStreamType)streamType;
        [Export("setRemoteDefaultVideoStreamType:")]
        int SetRemoteDefaultVideoStreamType(AgoraVideoStreamType streamType);

        // -(int)enableAudio;
        [Export("enableAudio")]
        //[Verify(MethodToProperty)]
        int EnableAudio();

        // -(int)disableAudio;
        [Export("disableAudio")]
        //[Verify(MethodToProperty)]
        int DisableAudio();

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

        // -(int)setAudioProfile:(AgoraAudioProfile)profile scenario:(AgoraAudioScenario)scenario;
        [Export("setAudioProfile:scenario:")]
        int SetAudioProfile(AgoraAudioProfile profile, AgoraAudioScenario scenario);

        // -(int)setHighQualityAudioParametersWithFullband:(BOOL)fullband stereo:(BOOL)stereo fullBitrate:(BOOL)fullBitrate __attribute__((deprecated("")));
        [Export("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:")]
        [Obsolete("use setAudioProfile:scenario: instead.")]
        int SetHighQualityAudioParametersWithFullband(bool fullband, bool stereo, bool fullBitrate);

        // -(int)adjustRecordingSignalVolume:(NSInteger)volume;
        [Export("adjustRecordingSignalVolume:")]
        int AdjustRecordingSignalVolume(nint volume);

        // -(int)adjustPlaybackSignalVolume:(NSInteger)volume;
        [Export("adjustPlaybackSignalVolume:")]
        int AdjustPlaybackSignalVolume(nint volume);

        // -(int)setSpeakerphoneVolume:(NSUInteger)volume __attribute__((deprecated("")));
        [Export("setSpeakerphoneVolume:")]
        [Obsolete("use setDeviceVolume:volume: instead.")]
        int SetSpeakerphoneVolume(nuint volume);

        // -(int)enableAudioVolumeIndication:(NSInteger)interval smooth:(NSInteger)smooth;
        [Export("enableAudioVolumeIndication:smooth:")]
        int EnableAudioVolumeIndication(nint interval, nint smooth);

        // -(int)muteLocalAudioStream:(BOOL)mute;
        [Export("muteLocalAudioStream:")]
        int MuteLocalAudioStream(bool mute);

        // -(int)muteRemoteAudioStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteAudioStream:mute:")]
        int MuteRemoteAudioStream(nuint uid, bool mute);

        // -(int)muteAllRemoteAudioStreams:(BOOL)mute;
        [Export("muteAllRemoteAudioStreams:")]
        int MuteAllRemoteAudioStreams(bool mute);

        // -(int)setDefaultMuteAllRemoteAudioStreams:(BOOL)mute;
        [Export("setDefaultMuteAllRemoteAudioStreams:")]
        int SetDefaultMuteAllRemoteAudioStreams(bool mute);

        // -(int)setLocalVoicePitch:(double)pitch;
        [Export("setLocalVoicePitch:")]
        int SetLocalVoicePitch(double pitch);

        // -(int)setLocalVoiceEqualizationOfBandFrequency:(AgoraAudioEqualizationBandFrequency)bandFrequency withGain:(NSInteger)gain;
        [Export("setLocalVoiceEqualizationOfBandFrequency:withGain:")]
        int SetLocalVoiceEqualizationOfBandFrequency(AgoraAudioEqualizationBandFrequency bandFrequency, nint gain);

        // -(int)setLocalVoiceReverbOfType:(AgoraAudioReverbType)reverbType withValue:(NSInteger)value;
        [Export("setLocalVoiceReverbOfType:withValue:")]
        int SetLocalVoiceReverbOfType(AgoraAudioReverbType reverbType, nint value);

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

        // -(int)playEffect:(int)soundId filePath:(NSString * _Nullable)filePath loopCount:(int)loopCount pitch:(double)pitch pan:(double)pan gain:(double)gain __attribute__((deprecated("")));
        [Export("playEffect:filePath:loopCount:pitch:pan:gain:")]
        [Obsolete("use playEffect:filePath:loopCount:pitch:pan:gain:publish: instead.")]
        int PlayEffect(int soundId, [NullAllowed] string filePath, int loopCount, double pitch, double pan, double gain);

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

        // -(int)startAudioRecording:(NSString * _Nonnull)filePath quality:(AgoraAudioRecordingQuality)quality;
        [Export("startAudioRecording:quality:")]
        int StartAudioRecording(string filePath, AgoraAudioRecordingQuality quality);

        // -(int)stopAudioRecording;
        [Export("stopAudioRecording")]
        //[Verify(MethodToProperty)]
        int StopAudioRecording();

        // -(int)startEchoTest:(void (^ _Nullable)(NSString * _Nonnull, NSUInteger, NSInteger))successBlock;
        [Export("startEchoTest:")]
        int StartEchoTest([NullAllowed] Action<NSString, nuint, nint> successBlock);

        // -(int)stopEchoTest;
        [Export("stopEchoTest")]
        //[Verify(MethodToProperty)]
        int StopEchoTest();

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

        // -(void)setRemoteVideoRenderer:(id<AgoraVideoSinkProtocol> _Nullable)videoRenderer forUserId:(NSUInteger)userId;
        [Export("setRemoteVideoRenderer:forUserId:")]
        void SetRemoteVideoRenderer([NullAllowed] AgoraVideoSinkProtocol videoRenderer, nuint userId);

        // -(id<AgoraVideoSinkProtocol> _Nullable)remoteVideoRendererOfUserId:(NSUInteger)userId;
        [Export("remoteVideoRendererOfUserId:")]
        [return: NullAllowed]
        AgoraVideoSinkProtocol RemoteVideoRendererOfUserId(nuint userId);

        // -(void)setExternalVideoSource:(BOOL)enable useTexture:(BOOL)useTexture pushMode:(BOOL)pushMode;
        [Export("setExternalVideoSource:useTexture:pushMode:")]
        void SetExternalVideoSource(bool enable, bool useTexture, bool pushMode);

        // -(BOOL)pushExternalVideoFrame:(AgoraVideoFrame * _Nonnull)frame;
        [Export("pushExternalVideoFrame:")]
        bool PushExternalVideoFrame(AgoraVideoFrame frame);

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

        // -(int)setRecordingAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraAudioRawFrameOperationMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetRecordingAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AgoraAudioRawFrameOperationMode mode, nint samplesPerCall);

        // -(int)setPlaybackAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraAudioRawFrameOperationMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetPlaybackAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AgoraAudioRawFrameOperationMode mode, nint samplesPerCall);

        // -(int)setMixedAudioFrameParametersWithSampleRate:(NSInteger)sampleRate samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:")]
        int SetMixedAudioFrameParametersWithSampleRate(nint sampleRate, nint samplesPerCall);

        // -(int)setEncryptionMode:(NSString * _Nullable)encryptionMode;
        [Export("setEncryptionMode:")]
        int SetEncryptionMode([NullAllowed] string encryptionMode);

        // -(int)setEncryptionSecret:(NSString * _Nullable)secret;
        [Export("setEncryptionSecret:")]
        int SetEncryptionSecret([NullAllowed] string secret);

        // -(int)createDataStream:(NSInteger * _Nonnull)streamId reliable:(BOOL)reliable ordered:(BOOL)ordered;
        [Export("createDataStream:reliable:ordered:")]
        unsafe int CreateDataStream(ref nint streamId, bool reliable, bool ordered);

        // -(int)sendStreamMessage:(NSInteger)streamId data:(NSData * _Nonnull)data;
        [Export("sendStreamMessage:data:")]
        int SendStreamMessage(nint streamId, NSData data);

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

        // -(int)configPublisher:(AgoraPublisherConfiguration * _Nonnull)config __attribute__((deprecated("")));
        [Export("configPublisher:")]
        [Obsolete(" This method is deprecated. Agora recommends using the following methods instead: * [addPublishStreamUrl](addPublishStreamUrl:transcodingEnabled:) or * [removePublishStreamUrl](removePublishStreamUrl:) or  * [setLiveTranscoding](setLiveTranscoding:)")]
        int ConfigPublisher(AgoraPublisherConfiguration config);

        // -(int)setVideoCompositingLayout:(AgoraRtcVideoCompositingLayout * _Nonnull)layout __attribute__((deprecated("")));
        [Export("setVideoCompositingLayout:")]
        [Obsolete("This method is deprecated and Agora recommends using the [setLiveTranscoding](setLiveTranscoding:) method.")]
        int SetVideoCompositingLayout(AgoraRtcVideoCompositingLayout layout);

        // -(int)clearVideoCompositingLayout __attribute__((deprecated("")));
        [Export("clearVideoCompositingLayout")]
        //[Verify(MethodToProperty)]
        [Obsolete]
        int ClearVideoCompositingLayout();

        // -(int)startScreenCapture:(NSUInteger)windowId withCaptureFreq:(NSInteger)captureFreq bitRate:(NSInteger)bitRate andRect:(CGRect)rect;
        [Export("startScreenCapture:withCaptureFreq:bitRate:andRect:")]
        int StartScreenCapture(nuint windowId, nint captureFreq, nint bitRate, CGRect rect);

        // -(int)stopScreenCapture;
        [Export("stopScreenCapture")]
        //[Verify(MethodToProperty)]
        int StopScreenCapture();

        // -(int)updateScreenCaptureRegion:(CGRect)rect;
        [Export("updateScreenCaptureRegion:")]
        int UpdateScreenCaptureRegion(CGRect rect);

        // -(void)monitorDeviceChange:(BOOL)enabled;
        [Export("monitorDeviceChange:")]
        void MonitorDeviceChange(bool enabled);

        // -(NSArray<AgoraRtcDeviceInfo *> * _Nullable)enumerateDevices:(AgoraMediaDeviceType)type;
        [Export("enumerateDevices:")]
        [return: NullAllowed]
        AgoraRtcDeviceInfo[] EnumerateDevices(AgoraMediaDeviceType type);

        // -(NSString * _Nullable)getDeviceId:(AgoraMediaDeviceType)type;
        [Export("getDeviceId:")]
        [return: NullAllowed]
        [Obsolete("use GetDeviceInfo: instead.")]
        string GetDeviceId(AgoraMediaDeviceType type);

        // -(int)setDevice:(AgoraMediaDeviceType)type deviceId:(NSString * _Nonnull)deviceId;
        [Export("setDevice:deviceId:")]
        int SetDevice(AgoraMediaDeviceType type, string deviceId);

        // -(int)getDeviceVolume:(AgoraMediaDeviceType)type;
        [Export("getDeviceVolume:")]
        int GetDeviceVolume(AgoraMediaDeviceType type);

        // -(int)setDeviceVolume:(AgoraMediaDeviceType)type volume:(int)volume;
        [Export("setDeviceVolume:volume:")]
        int SetDeviceVolume(AgoraMediaDeviceType type, int volume);

        // -(int)startRecordingDeviceTest:(int)indicationInterval;
        [Export("startRecordingDeviceTest:")]
        int StartRecordingDeviceTest(int indicationInterval);

        // -(int)stopRecordingDeviceTest;
        [Export("stopRecordingDeviceTest")]
        //[Verify(MethodToProperty)]
        int StopRecordingDeviceTest();

        // -(int)startPlaybackDeviceTest:(NSString * _Nonnull)audioFileName;
        [Export("startPlaybackDeviceTest:")]
        int StartPlaybackDeviceTest(string audioFileName);

        // -(int)stopPlaybackDeviceTest;
        [Export("stopPlaybackDeviceTest")]
        //[Verify(MethodToProperty)]
        int StopPlaybackDeviceTest();

        // -(int)startCaptureDeviceTest:(NSView * _Nonnull)view;
        [Export("startCaptureDeviceTest:")]
        int StartCaptureDeviceTest(NSView view);

        // -(int)stopCaptureDeviceTest;
        [Export("stopCaptureDeviceTest")]
        //[Verify(MethodToProperty)]
        int StopCaptureDeviceTest();

        // -(int)startRecordingService:(NSString * _Nonnull)recordingKey;
        [Export("startRecordingService:")]
        int StartRecordingService(string recordingKey);

        // -(int)stopRecordingService:(NSString * _Nonnull)recordingKey;
        [Export("stopRecordingService:")]
        int StopRecordingService(string recordingKey);

        // -(int)refreshRecordingServiceStatus;
        [Export("refreshRecordingServiceStatus")]
        //[Verify(MethodToProperty)]
        int RefreshRecordingServiceStatus();

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

        // -(void)localVideoStatBlock:(void (^ _Nullable)(NSInteger, NSInteger))localVideoStatBlock __attribute__((deprecated("")));
        [Export("localVideoStatBlock:")]
        void LocalVideoStatBlock([NullAllowed] Action<nint, nint> localVideoStatBlock);

        // -(void)remoteVideoStatBlock:(void (^ _Nullable)(NSUInteger, NSInteger, NSInteger, NSInteger))remoteVideoStatBlock __attribute__((deprecated("")));
        [Export("remoteVideoStatBlock:")]
        void RemoteVideoStatBlock([NullAllowed] Action<nuint, nint, nint, nint> remoteVideoStatBlock);

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
        void AudioQualityBlock([NullAllowed] Action<nuint, AgoraNetworkQuality, nuint, nuint> audioQualityBlock);

        // -(void)networkQualityBlock:(void (^ _Nullable)(NSUInteger, AgoraNetworkQuality, AgoraNetworkQuality))networkQualityBlock __attribute__((deprecated("")));
        [Export("networkQualityBlock:")]
        void NetworkQualityBlock([NullAllowed] Action<nuint, AgoraNetworkQuality, AgoraNetworkQuality> networkQualityBlock);

        // -(void)lastmileQualityBlock:(void (^ _Nullable)(AgoraNetworkQuality))lastmileQualityBlock __attribute__((deprecated("")));
        [Export("lastmileQualityBlock:")]
        void LastmileQualityBlock([NullAllowed] Action<AgoraNetworkQuality> lastmileQualityBlock);

        // -(void)mediaEngineEventBlock:(void (^ _Nullable)(NSInteger))mediaEngineEventBlock __attribute__((deprecated("")));
        [Export("mediaEngineEventBlock:")]
        void MediaEngineEventBlock([NullAllowed] Action<nint> mediaEngineEventBlock);
    }
}
