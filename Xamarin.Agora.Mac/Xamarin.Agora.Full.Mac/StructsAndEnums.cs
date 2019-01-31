﻿using System;
using ObjCRuntime;

namespace Xamarin.Agora.Mac
{
    [Native]
    public enum AgoraWarningCode : long
    {
        InvalidView = 8,
        InitVideo = 16,
        Pending = 20,
        NoAvailableChannel = 103,
        LookupChannelTimeout = 104,
        LookupChannelRejected = 105,
        OpenChannelTimeout = 106,
        OpenChannelRejected = 107,
        SwitchLiveVideoTimeout = 111,
        SetClientRoleTimeout = 118,
        SetClientRoleNotAuthorized = 119,
        OpenChannelInvalidTicket = 121,
        OpenChannelTryNextVos = 122,
        AudioMixingOpenError = 701,
        AdmRuntimePlayoutWarning = 1014,
        AdmRuntimeRecordingWarning = 1016,
        AdmRecordAudioSilence = 1019,
        AdmPlaybackMalfunction = 1020,
        AdmRecordMalfunction = 1021,
        AdmInterruption = 1025,
        AdmRecordAudioLowlevel = 1031,
        AdmPlayoutAudioLowlevel = 1032,
        ApmHowling = 1051,
        AdmGlitchState = 1052,
        AdmImproperSettings = 1053
    }

    [Native]
    public enum AgoraErrorCode : long
    {
        NoError = 0,
        Failed = 1,
        InvalidArgument = 2,
        NotReady = 3,
        NotSupported = 4,
        Refused = 5,
        BufferTooSmall = 6,
        NotInitialized = 7,
        NoPermission = 9,
        TimedOut = 10,
        Canceled = 11,
        TooOften = 12,
        BindSocket = 13,
        NetDown = 14,
        NoBufs = 15,
        JoinChannelRejected = 17,
        LeaveChannelRejected = 18,
        AlreadyInUse = 19,
        Abort = 20,
        InitNetEngine = 21,
        ResourceLimited = 22,
        InvalidAppId = 101,
        InvalidChannelId = 102,
        TokenExpired = 109,
        InvalidToken = 110,
        Connectiolongerrupted = 111,
        ConnectionLost = 112,
        NotInChannel = 113,
        SizeTooLarge = 114,
        BitrateLimit = 115,
        TooManyDataStreams = 116,
        DecryptionFailed = 120,
        WatermarkParam = 124,
        WatermarkPath = 125,
        WatermarkPng = 126,
        WatermarkInfo = 127,
        WatermarkAGRB = 128,
        WatermarkRead = 129,
        EncryptedStreamNotAllowedPublish = 130,
        PublishFailed = 150,
        LoadMediaEngine = 1001,
        StartCall = 1002,
        StartCamera = 1003,
        StartVideoRender = 1004,
        AdmGeneralError = 1005,
        AdmJavaResource = 1006,
        AdmSampleRate = 1007,
        AdmInitPlayout = 1008,
        AdmStartPlayout = 1009,
        AdmStopPlayout = 1010,
        AdmInitRecording = 1011,
        AdmStartRecording = 1012,
        AdmStopRecording = 1013,
        AdmRuntimePlayoutError = 1015,
        AdmRuntimeRecordingError = 1017,
        AdmRecordAudioFailed = 1018,
        AdmPlayAbnormalFrequency = 1020,
        AdmRecordAbnormalFrequency = 1021,
        AdmInitLoopback = 1022,
        AdmStartLoopback = 1023,
        AdmNoRecordingDevice = 1359,
        AdmNoPlayoutDevice = 1360,
        VdmCameraNotAuthorized = 1501,
        VcmUnknownError = 1600,
        VcmEncoderInitError = 1601,
        VcmEncoderEncodeError = 1602,
        VcmEncoderSetError = 1603
    }

    [Native]
    public enum AgoraVideoProfile : long
    {
        Invalid = -1,
        Landscape120P = 0,
        Landscape240P = 20,
        Landscape360P = 30,
        Landscape360P_4 = 33,
        Landscape360P_6 = 35,
        Landscape360P_7 = 36,
        Landscape360P_8 = 37,
        Landscape360P_9 = 38,
        Landscape360P_10 = 39,
        Landscape360P_11 = 100,
        Landscape480P = 40,
        Landscape480P_4 = 43,
        Landscape480P_6 = 45,
        Landscape480P_8 = 47,
        Landscape480P_9 = 48,
        Landscape480P_10 = 49,
        Landscape720P = 50,
        Landscape720P_3 = 52,
        Landscape720P_5 = 54,
        Landscape720P_6 = 55,
        Landscape1080P = 60,
        Landscape1080P_3 = 62,
        Landscape1080P_5 = 64,
        Landscape1440P = 66,
        Landscape1440P_2 = 67,
        Landscape4K = 70,
        Landscape4K_3 = 72,
        Portrait120P = 1000,
        Portrait240P = 1020,
        Portrait360P = 1030,
        Portrait360P_4 = 1033,
        Portrait360P_6 = 1035,
        Portrait360P_7 = 1036,
        Portrait360P_8 = 1037,
        Portrait360P_9 = 1038,
        Portrait360P_10 = 1039,
        Portrait360P_11 = 1100,
        Portrait480P = 1040,
        Portrait480P_4 = 1043,
        Portrait480P_6 = 1045,
        Portrait480P_8 = 1047,
        Portrait480P_9 = 1048,
        Portrait480P_10 = 1049,
        Portrait720P = 1050,
        Portrait720P_3 = 1052,
        Portrait720P_5 = 1054,
        Portrait720P_6 = 1055,
        Portrait1080P = 1060,
        Portrait1080P_3 = 1062,
        Portrait1080P_5 = 1064,
        Portrait1440P = 1066,
        Portrait1440P_2 = 1067,
        Portrait4K = 1070,
        Portrait4K_3 = 1072,
        Default = Landscape360P
    }

    [Native]
    public enum AgoraChannelProfile : long
    {
        Communication = 0,
        LiveBroadcasting = 1,
        Game = 2
    }

    [Native]
    public enum AgoraClientRole : long
    {
        Broadcaster = 1,
        Audience = 2
    }

    [Native]
    public enum AgoraMediaType : long
    {
        None = 0,
        AudioOnly = 1,
        VideoOnly = 2,
        AudioAndVideo = 3
    }

    [Native]
    public enum AgoraEncryptionMode : long
    {
        None = 0,
        Aes128xts = 1,
        Aes256xts = 2,
        Aes128ecb = 3
    }

    [Native]
    public enum AgoraUserOfflineReason : ulong
    {
        Quit = 0,
        Dropped = 1,
        BecomeAudience = 2
    }

    [Native]
    public enum AgoraInjectStreamStatus : ulong
    {
        StartSuccess = 0,
        StartAlreadyExists = 1,
        StartUnauthorized = 2,
        StartTimedout = 3,
        StartFailed = 4,
        StopSuccess = 5,
        StopNotFound = 6,
        StopUnauthorized = 7,
        StopTimedout = 8,
        StopFailed = 9,
        Broken = 10
    }

    [Native]
    public enum AgoraLogFilter : ulong
    {
        Off = 0,
        Debug = 2063,
        Info = 15,
        Warning = 14,
        Error = 12,
        Critical = 8
    }

    [Native]
    public enum AgoraAudioRecordingQuality : long
    {
        Low = 0,
        Medium = 1,
        High = 2
    }

    [Native]
    public enum AgoraRtmpStreamLifeCycle : long
    {
        Channel = 1,
        Ownner = 2
    }

    [Native]
    public enum AgoraNetworkQuality : ulong
    {
        Unknown = 0,
        Excellent = 1,
        Good = 2,
        Poor = 3,
        Bad = 4,
        VBad = 5,
        Down = 6
    }

    [Native]
    public enum AgoraVideoStreamType : long
    {
        High = 0,
        Low = 1
    }

    [Native]
    public enum AgoraVideoRenderMode : ulong
    {
        Hidden = 1,
        Fit = 2,
        Adaptive = 3
    }

    [Native]
    public enum AgoraVideoCodecProfileType : long
    {
        BaseLine = 66,
        Main = 77,
        High = 100
    }

    [Native]
    public enum AgoraVideoMirrorMode : ulong
    {
        Auto = 0,
        Enabled = 1,
        Disabled = 2
    }

    [Native]
    public enum AgoraVideoRemoteState : ulong
    {
        Stopped = 0,
        Running = 1,
        Frozen = 2
    }

    [Native]
    public enum AgoraAudioSampleRateType : long
    {
        AgoraAudioSampleRateType32000 = 32000,
        AgoraAudioSampleRateType44100 = 44100,
        AgoraAudioSampleRateType48000 = 48000
    }

    [Native]
    public enum AgoraAudioProfile : long
    {
        Default = 0,
        SpeechStandard = 1,
        MusicStandard = 2,
        MusicStandardStereo = 3,
        MusicHighQuality = 4,
        MusicHighQualityStereo = 5
    }

    [Native]
    public enum AgoraAudioScenario : long
    {
        Default = 0,
        ChatRoomEntertainment = 1,
        Education = 2,
        GameStreaming = 3,
        ShowRoom = 4,
        ChatRoomGaming = 5
    }

    [Native]
    public enum AgoraAudioOutputRouting : long
    {
        Default = -1,
        Headset = 0,
        Earpiece = 1,
        HeadsetNoMic = 2,
        Speakerphone = 3,
        Loudspeaker = 4,
        HeadsetBluetooth = 5
    }

    [Native]
    public enum AgoraAudioRawFrameOperationMode : long
    {
        ReadOnly = 0,
        WriteOnly = 1,
        ReadWrite = 2
    }

    [Native]
    public enum AgoraAudioEqualizationBandFrequency : long
    {
        AgoraAudioEqualizationBand31 = 0,
        AgoraAudioEqualizationBand62 = 1,
        AgoraAudioEqualizationBand125 = 2,
        AgoraAudioEqualizationBand250 = 3,
        AgoraAudioEqualizationBand500 = 4,
        AgoraAudioEqualizationBand1K = 5,
        AgoraAudioEqualizationBand2K = 6,
        AgoraAudioEqualizationBand4K = 7,
        AgoraAudioEqualizationBand8K = 8,
        AgoraAudioEqualizationBand16K = 9
    }

    [Native]
    public enum AgoraAudioReverbType : long
    {
        DryLevel = 0,
        WetLevel = 1,
        RoomSize = 2,
        WetDelay = 3,
        Strength = 4
    }

    [Native]
    public enum AgoraMediaDeviceType : long
    {
        AudioUnknown = -1,
        AudioRecording = 0,
        AudioPlayout = 1,
        VideoRender = 2,
        VideoCapture = 3
    }

    [Native]
    public enum AgoraVideoPixelFormat : ulong
    {
        I420 = 1,
        Bgra = 2,
        Nv12 = 8
    }

    [Native]
    public enum AgoraVideoRotation : long
    {
        None = 0,
        AgoraVideoRotation90 = 1,
        AgoraVideoRotation180 = 2,
        AgoraVideoRotation270 = 3
    }

    [Native]
    public enum AgoraVideoBufferType : long
    {
        PixelBuffer = 1,
        RawData = 2
    }

    [Native]
    public enum AgoraRtcDefaultCameraPosition : long
    {
        Front = 0,
        Back = 1
    }
}
