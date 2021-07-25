using System;
using ObjCRuntime;

namespace DT.Xamarin.Agora
{
	[Native]
	public enum WarningCode : long
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
		AdmCategoryNotPlayAndRecord = 1029,
		AdmRecordAudioLowlevel = 1031,
		AdmPlayoutAudioLowlevel = 1032,
		AdmNoDataReadyCallback = 1040,
		AdmInconsistentDevices = 1042,
		ApmHowling = 1051,
		AdmGlitchState = 1052,
		ApmResidualEcho = 1053,
		SuperResolutionStreamOverLimitation = 1610,
		SuperResolutionUserCountOverLimitation = 1611,
		SuperResolutionDeviceNotSupported = 1612
	}

	[Native]
	public enum ErrorCode : long
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
		NoServerResources = 103,
		TokenExpired = 109,
        InvalidToken = 110,
        ConnectionInterrupted = 111,
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
        InvalidUserAccount = 134,
        PublishStreamCDNError = 151,
        PublishStreamNumReachLimit = 152,
        PublishStreamNotAuthorized = 153,
        PublishStreamInternalServerError = 154,
        PublishStreamNotFound = 155,
        PublishStreamFormatNotSuppported = 156,
		ModuleNotFound = 157,
		AlreadyInRecording = 160,
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
        AdmNoPermission = 1027,
		AdmActivateSessionFail = 1206,
		AdmNoRecordingDevice = 1359,
        AdmNoPlayoutDevice = 1360,
        VdmCameraNotAuthorized = 1501,
        VcmUnknownError = 1600,
        VcmEncoderInitError = 1601,
        VcmEncoderEncodeError = 1602,
        VcmEncoderSetError = 1603
    }

	[Native]
	public enum AudioMixingStateCode : long
	{
		Playing = 710,
		Paused = 711,
		Stopped = 713,
		Failed = 714
	}

	[Native]
	public enum AudioMixingErrorCode : long
	{
		CanNotOpen = 701,
		TooFrequentCall = 702,
		InterruptedEOF = 703,
		Ok = 0
	}

	[Native]
	public enum AudioMixingReasonCode : long
	{
		CanNotOpen = 701,
		TooFrequentCall = 702,
		InterruptedEOF = 703,
		StartedByUser = 720,
		OneLoopCompleted = 721,
		StartNewLoop = 722,
		AllLoopsCompleted = 723,
		StoppedByUser = 724,
		PausedByUser = 725,
		ResumedByUser = 726
	}

	[Native]
	public enum VideoProfile : long
	{
		Invalid = -1,
		Landscape120P = 0,
		Landscape120P_3 = 2,
		Landscape180P = 10,
		Landscape180P_3 = 12,
		Landscape180P_4 = 13,
		Landscape240P = 20,
		Landscape240P_3 = 22,
		Landscape240P_4 = 23,
		Landscape360P = 30,
		Landscape360P_3 = 32,
		Landscape360P_4 = 33,
		Landscape360P_6 = 35,
		Landscape360P_7 = 36,
		Landscape360P_8 = 37,
		Landscape360P_9 = 38,
		Landscape360P_10 = 39,
		Landscape360P_11 = 100,
		Landscape480P = 40,
		Landscape480P_3 = 42,
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
		Portrait120P_3 = 1002,
		Portrait180P = 1010,
		Portrait180P_3 = 1012,
		Portrait180P_4 = 1013,
		Portrait240P = 1020,
		Portrait240P_3 = 1022,
		Portrait240P_4 = 1023,
		Portrait360P = 1030,
		Portrait360P_3 = 1032,
		Portrait360P_4 = 1033,
		Portrait360P_6 = 1035,
		Portrait360P_7 = 1036,
		Portrait360P_8 = 1037,
		Portrait360P_9 = 1038,
		Portrait360P_10 = 1039,
		Portrait360P_11 = 1100,
		Portrait480P = 1040,
		Portrait480P_3 = 1042,
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
	public enum CameraCaptureOutputPreference : long
	{
		Auto = 0,
		Performance = 1,
		Preview = 2,
		Manual = 3,
		Unkown = 4
	}

	[Native]
	public enum CameraDirection : long
	{
		Rear = 0,
		Front = 1
	}

	[Native]
	public enum VideoFrameRate : long
	{
		VideoFrameRateFps1 = 1,
		VideoFrameRateFps7 = 7,
		VideoFrameRateFps10 = 10,
		VideoFrameRateFps15 = 15,
		VideoFrameRateFps24 = 24,
		VideoFrameRateFps30 = 30,
		VideoFrameRateFps60 = 60
	}

	[Native]
	public enum VideoOutputOrientationMode : long
	{
		Adaptative = 0,
		FixedLandscape = 1,
		FixedPortrait = 2
	}

	[Native]
	public enum ChannelProfile : long
	{
		Communication = 0,
		LiveBroadcasting = 1,
		Game = 2
	}

	[Native]
	public enum ClientRole : long
	{
		Broadcaster = 1,
		Audience = 2
	}

	[Native]
	public enum AudienceLatencyLevelType : long
	{
		LowLatency = 1,
		UltraLowLatency = 2
	}

	[Native]
	public enum CaptureBrightnessLevelType : long
	{
		Invalid = -1,
		Normal = 0,
		Bright = 1,
		Dark = 2
	}

	[Native]
	public enum MediaType : long
	{
		None = 0,
		AudioOnly = 1,
		VideoOnly = 2,
		AudioAndVideo = 3
	}

	[Native]
	public enum EncryptionMode : long
	{
		None = 0,
		Aes128xts = 1,
		Aes128ecb = 2,
		Aes256xts = 3,
		Sm4128ecb = 4,
		Aes128gcm = 5,
		Aes256gcm = 6,
		Aes128gcm2 = 7,
		Aes256gcm2 = 8,
		End
	}

	[Native]
	public enum UserOfflineReason : ulong
	{
		Quit = 0,
		Dropped = 1,
		BecomeAudience = 2
	}

	[Native]
	public enum RtmpStreamingState : ulong
	{
		Idle = 0,
		Connecting = 1,
		Running = 2,
		Recovering = 3,
		Failure = 4
	}

	[Native]
	public enum RtmpStreamingErrorCode : ulong
	{
		Ok = 0,
		InvalidParameters = 1,
		EncryptedStreamNotAllowed = 2,
		ConnectionTimeout = 3,
		InternalServerError = 4,
		RtmpServerError = 5,
		TooOften = 6,
		ReachLimit = 7,
		NotAuthorized = 8,
		StreamNotFound = 9,
		FormatNotSupported = 10,
		UnpublishOK = 100
	}

	[Native]
	public enum RtmpStreamingEvent : ulong
	{
		FailedLoadImage = 1,
		UrlAlreadyInUse = 2
	}

	[Native]
	public enum InjectStreamStatus : ulong
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
	public enum LogFilter : ulong
	{
		Off = 0,
		Debug = 2063,
		Info = 15,
		Warning = 14,
		Error = 12,
		Critical = 8
	}

	[Native]
	public enum AudioRecordingQuality : long
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	[Native]
	public enum AudioRecordingPosition : long
	{
		MixedRecordingAndPlayback = 0,
		Recording = 1,
		MixedPlayback = 2
	}

	[Native]
	public enum RtmpStreamLifeCycle : long
	{
		Channel = 1,
		Ownner = 2
	}

	[Native]
	public enum NetworkQuality : ulong
	{
		Unknown = 0,
		Excellent = 1,
		Good = 2,
		Poor = 3,
		Bad = 4,
		VBad = 5,
		Down = 6,
		Unsupported = 7,
		Detecting = 8
	}

	[Native]
	public enum ExperienceQuality : ulong
	{
		Good = 0,
		Bad = 1
	}

	[Native]
	public enum ExperiencePoorReason : ulong
	{
		ExperienceReasonNone = 0,
		RemoteNetworkPoor = 1,
		LocalNetworkPoor = 2,
		WirelessSignalPoor = 4,
		WifiBluetoothCoexist = 8
	}

	[Native]
	public enum UploadErrorReason : long
	{
		Success = 0,
		NetError = 1,
		ServerError = 2
	}

	[Native]
	public enum VideoStreamType : long
	{
		High = 0,
		Low = 1
	}

	[Native]
	public enum UserPriority : long
	{
		High = 50,
		Normal = 100
	}

	[Native]
	public enum VideoQualityAdaptIndication : long
	{
		None = 0,
		UpBandwidth = 1,
		DownBandwidth = 2
	}

	[Native]
	public enum VideoRenderMode : long
	{
		Hidden = 1,
		Fit = 2,
		Adaptive = 3,
		Fill = 4
	}

	[Native]
	public enum VideoCodecProfileType : long
	{
		BaseLine = 66,
		Main = 77,
		High = 100
	}

	[Native]
	public enum VideoCodecType : long
	{
		Vp8 = 1,
		H264 = 2,
		Evp = 3,
		E264 = 4
	}

	[Native]
	public enum VideoCodecTypeForStream : long
	{
		VideoCodecTypeH264ForStream = 1,
		VideoCodecTypeH265ForStream = 2
	}

	[Native]
	public enum VideoMirrorMode : ulong
	{
		Auto = 0,
		Enabled = 1,
		Disabled = 2
	}

	[Native]
	public enum StreamPublishState : ulong
	{
		Idle = 0,
		NoPublished = 1,
		Publishing = 2,
		Published = 3
	}

	[Native]
	public enum StreamSubscribeState : ulong
	{
		Idle = 0,
		NoSubscribed = 1,
		Subscribing = 2,
		Subscribed = 3
	}

	[Native]
	public enum VideoContentHint : ulong
	{
		None = 0,
		Motion = 1,
		Details = 2
	}

	[Native]
	public enum VideoRemoteState : ulong
	{
		Stopped = 0,
		Starting = 1,
		Decoding = 2,
		Frozen = 3,
		Failed = 4
	}

	[Native]
	public enum VideoRemoteStateReason : ulong
	{
		Internal = 0,
		NetworkCongestion = 1,
		NetworkRecovery = 2,
		LocalMuted = 3,
		LocalUnmuted = 4,
		RemoteMuted = 5,
		RemoteUnmuted = 6,
		RemoteOffline = 7,
		AudioFallback = 8,
		AudioFallbackRecovery = 9
	}

	[Native]
	public enum SuperResolutionStateReason : ulong
	{
		Success = 0,
		StreamOverLimitation = 1,
		UserCountOverLimitation = 2,
		DeviceNotSupported = 3
	}

	[Native]
	public enum VirtualBackgroundSourceStateReason : ulong
	{
		Success = 0,
		ImageNotExist = 1,
		ColorFormatNotSupported = 2,
		DeviceNotSupported = 3
	}

	[Native]
	public enum StreamFallbackOptions : long
	{
		Disabled = 0,
		VideoStreamLow = 1,
		AudioOnly = 2
	}

	[Native]
	public enum AudioSampleRateType : long
	{
		AudioSampleRateType32000 = 32000,
		AudioSampleRateType44100 = 44100,
		AudioSampleRateType48000 = 48000
	}

	[Native]
	public enum AudioProfile : long
	{
		Default = 0,
		SpeechStandard = 1,
		MusicStandard = 2,
		MusicStandardStereo = 3,
		MusicHighQuality = 4,
		MusicHighQualityStereo = 5
	}

	[Native]
	public enum AudioScenario : long
	{
		Default = 0,
		ChatRoomEntertainment = 1,
		Education = 2,
		GameStreaming = 3,
		ShowRoom = 4,
		ChatRoomGaming = 5,
		Iot = 6,
		Communication = 7,
		Meeting = 8
	}

	[Native]
	public enum AudioOutputRouting : long
	{
		Default = -1,
		Headset = 0,
		Earpiece = 1,
		HeadsetNoMic = 2,
		Speakerphone = 3,
		Loudspeaker = 4,
		HeadsetBluetooth = 5,
		Usb = 6,
		Hdmi = 7,
		DisplayPort = 8,
		AirPlay = 9
	}

	[Native]
	public enum AudioRawFrameOperationMode : long
	{
		ReadOnly = 0,
		WriteOnly = 1,
		ReadWrite = 2
	}

	[Native]
	public enum AudioEqualizationBandFrequency : long
	{
		AudioEqualizationBand31 = 0,
		AudioEqualizationBand62 = 1,
		AudioEqualizationBand125 = 2,
		AudioEqualizationBand250 = 3,
		AudioEqualizationBand500 = 4,
		AudioEqualizationBand1K = 5,
		AudioEqualizationBand2K = 6,
		AudioEqualizationBand4K = 7,
		AudioEqualizationBand8K = 8,
		AudioEqualizationBand16K = 9
	}

	[Native]
	public enum AudioReverbType : long
	{
		DryLevel = 0,
		WetLevel = 1,
		RoomSize = 2,
		WetDelay = 3,
		Strength = 4
	}

	[Native]
	public enum AudioVoiceChanger : long
	{
		VoiceChangerOff = 0,
		VoiceChangerOldMan = 1,
		VoiceChangerBabyBoy = 2,
		VoiceChangerBabyGirl = 3,
		VoiceChangerZhuBaJie = 4,
		VoiceChangerEthereal = 5,
		VoiceChangerHulk = 6,
		VoiceBeautyVigorous = 1048577,
		VoiceBeautyDeep = 1048578,
		VoiceBeautyMellow = 1048579,
		VoiceBeautyFalsetto = 1048580,
		VoiceBeautyFull = 1048581,
		VoiceBeautyClear = 1048582,
		VoiceBeautyResounding = 1048583,
		VoiceBeautyRinging = 1048584,
		VoiceBeautySpacial = 1048585,
		GeneralBeautyVoiceMaleMagnetic = 2097153,
		GeneralBeautyVoiceFemaleFresh = 2097154,
		GeneralBeautyVoiceFemaleVitality = 2097155
	}

	[Native]
	public enum AudioReverbPreset : long
	{
		Off = 0,
		FxKTV = 1048577,
		FxVocalConcert = 1048578,
		FxUncle = 1048579,
		FxSister = 1048580,
		FxStudio = 1048581,
		FxPopular = 1048582,
		FxRNB = 1048583,
		FxPhonograph = 1048584,
		Popular = 1,
		RnB = 2,
		Rock = 3,
		HipHop = 4,
		VocalConcert = 5,
		Ktv = 6,
		Studio = 7,
		VirtualStereo = 2097153,
		ElectronicVoice = 3145729,
		ThreeDimVoice = 4194305
	}

	[Native]
	public enum VoiceBeautifierPreset : long
	{
		VoiceBeautifierOff = 0,
		ChatBeautifierMagnetic = 16843008,
		ChatBeautifierFresh = 16843264,
		ChatBeautifierVitality = 16843520,
		SingingBeautifier = 16908544,
		TimbreTransformationVigorous = 16974080,
		TimbreTransformationDeep = 16974336,
		TimbreTransformationMellow = 16974592,
		TimbreTransformationFalsetto = 16974848,
		TimbreTransformationFull = 16975104,
		TimbreTransformationClear = 16975360,
		TimbreTransformationResounding = 16975616,
		TimbreTransformationRinging = 16975872
	}

	[Native]
	public enum AudioEffectPreset : long
	{
		AudioEffectOff = 0,
		RoomAcousticsKTV = 33620224,
		RoomAcousticsVocalConcert = 33620480,
		RoomAcousticsStudio = 33620736,
		RoomAcousticsPhonograph = 33620992,
		RoomAcousticsVirtualStereo = 33621248,
		RoomAcousticsSpacial = 33621504,
		RoomAcousticsEthereal = 33621760,
		RoomAcoustics3DVoice = 33622016,
		VoiceChangerEffectUncle = 33685760,
		VoiceChangerEffectOldMan = 33686016,
		VoiceChangerEffectBoy = 33686272,
		VoiceChangerEffectSister = 33686528,
		VoiceChangerEffectGirl = 33686784,
		VoiceChangerEffectPigKing = 33687040,
		VoiceChangerEffectHulk = 33687296,
		StyleTransformationRnB = 33751296,
		StyleTransformationPopular = 33751552,
		PitchCorrection = 33816832
	}

	[Native]
	public enum VoiceConversionPreset : long
	{
		onversionOff = 0,
		hangerNeutral = 50397440,
		hangerSweet = 50397696,
		hangerSolid = 50397952,
		hangerBass = 50398208
	}

	[Flags]
	[Native]
	public enum AudioSessionOperationRestriction : ulong
	{
		None = 0,
		SetCategory = 1,
		ConfigureSession = 1 << 1,
		DeactivateSession = 1 << 2,
		All = 1 << 7
	}

	[Native]
	public enum AudioCodecProfileType : long
	{
		Lcaac = 0,
		Heaac = 1
	}

	[Native]
	public enum AudioRemoteState : ulong
	{
		Stopped = 0,
		Starting = 1,
		Decoding = 2,
		Frozen = 3,
		Failed = 4
	}

	[Native]
	public enum AudioRemoteStateReason : ulong
	{
		Internal = 0,
		NetworkCongestion = 1,
		NetworkRecovery = 2,
		LocalMuted = 3,
		LocalUnmuted = 4,
		RemoteMuted = 5,
		RemoteUnmuted = 6,
		RemoteOffline = 7
	}

	[Native]
	public enum AudioLocalState : ulong
	{
		Stopped = 0,
		Recording = 1,
		Encoding = 2,
		Failed = 3
	}

	[Native]
	public enum AudioLocalError : ulong
	{
		Ok = 0,
		Failure = 1,
		DeviceNoPermission = 2,
		DeviceBusy = 3,
		RecordFailure = 4,
		EncodeFailure = 5
	}

	[Native]
	public enum MediaDeviceType : long
	{
		AudioUnknown = -1,
		AudioPlayout = 0,
		AudioRecording = 1,
		VideoRender = 2,
		VideoCapture = 3
	}

	[Native]
	public enum ConnectionStateType : long
	{
		Disconnected = 1,
		Connecting = 2,
		Connected = 3,
		Reconnecting = 4,
		Failed = 5
	}

	[Native]
    public enum ConnectionChangedReason : ulong
	{
		Connecting = 0,
		JoinSuccess = 1,
		Interrupted = 2,
		BannedByServer = 3,
		JoinFailed = 4,
		LeaveChannel = 5,
		InvalidAppId = 6,
		InvalidChannelName = 7,
		InvalidToken = 8,
		TokenExpired = 9,
		RejectedByServer = 10,
		SettingProxyServer = 11,
		RenewToken = 12,
		ClientIpAddressChanged = 13,
		KeepAliveTimeout = 14,
		ProxyServerInterrupted = 15
	}

	[Native]
	public enum ChannelMediaRelayState : long
	{
		Idle = 0,
		Connecting = 1,
		Running = 2,
		Failure = 3
	}

	[Native]
	public enum ChannelMediaRelayEvent : long
	{
		Disconnect = 0,
		Connected = 1,
		JoinedSourceChannel = 2,
		JoinedDestinationChannel = 3,
		SentToDestinationChannel = 4,
		ReceivedVideoPacketFromSource = 5,
		ReceivedAudioPacketFromSource = 6,
		UpdateDestinationChannel = 7,
		UpdateDestinationChannelRefused = 8,
		UpdateDestinationChannelNotChange = 9,
		UpdateDestinationChannelIsNil = 10,
		VideoProfileUpdate = 11
	}

	[Native]
	public enum ChannelMediaRelayError : long
	{
		None = 0,
		ServerErrorResponse = 1,
		ServerNoResponse = 2,
		NoResourceAvailable = 3,
		FailedJoinSourceChannel = 4,
		FailedJoinDestinationChannel = 5,
		FailedPacketReceivedFromSource = 6,
		FailedPacketSentToDestination = 7,
		ServerConnectionLost = 8,
		InternalError = 9,
		SourceTokenExpired = 10,
		DestinationTokenExpired = 11
	}

	[Native]
	public enum NetworkType : long
	{
		Unknown = -1,
		Disconnected = 0,
		Lan = 1,
		Wifi = 2,
		Mobile2G = 3,
		Mobile3G = 4,
		Mobile4G = 5
	}

	[Native]
	public enum DegradationPreference : long
	{
		MaintainQuality = 0,
		MaintainFramerate = 1,
		Balanced = 2
	}

	[Native]
	public enum LighteningContrastLevel : ulong
	{
		Low = 0,
		Normal = 1,
		High = 2
	}

	[Native]
	public enum VirtualBackgroundSourceType : ulong
	{
		Color = 1,
		Img = 2
	}

	[Native]
	public enum LastmileProbeResultState : ulong
	{
		Complete = 1,
		IncompleteNoBwe = 2,
		Unavailable = 3
	}

	[Native]
	public enum LocalVideoStreamState : long
	{
		Stopped = 0,
		Capturing = 1,
		Encoding = 2,
		Failed = 3
	}

	[Native]
	public enum LocalVideoStreamError : long
	{
		Ok = 0,
		Failure = 1,
		DeviceNoPermission = 2,
		DeviceBusy = 3,
		CaptureFailure = 4,
		EncodeFailure = 5,
		CaptureInBackGround = 6,
		CaptureMultipleForegroundApps = 7,
		CaptureNoDeviceFound = 8,
		CaptureDeviceDisconnected = 9,
		ScreenCaptureWindowMinimized = 11,
		ScreenCaptureWindowClosed = 12
	}

	[Native]
	public enum AgoraAreaCode : ulong
	{
		Cn = 1,
		Na = 2,
		Eu = 4,
		As = 8,
		Jp = 16,
		In = 32,
		Glob = 4294967295L
	}

	[Native]
	public enum AgoraLogLevel : long
	{
		None = 0,
		Info = 1,
		Warn = 2,
		Error = 4,
		Fatal = 8
	}

	[Native]
	public enum CloudProxyType : ulong
	{
		NoneProxy = 0,
		UdpProxy = 1,
		TcpProxy = 2
	}

	[Native]
	public enum VideoPixelFormat : ulong
	{
		I420 = 1,
		Bgra = 2,
		Nv12 = 8
	}

	[Native]
	public enum VideoRotation : long
	{
		None = 0,
		VideoRotation90 = 1,
		VideoRotation180 = 2,
		VideoRotation270 = 3
	}

	[Native]
	public enum VideoFrameType : ulong
	{
		Yuv420 = 0,
		Yuv422 = 1,
		Rgba = 2
	}

	[Native]
	public enum VideoEncodeType : ulong
	{
		BlankFrame = 0,
		KeyFrame = 3,
		DetaFrame = 4,
		BFrame = 5
	}

	[Native]
	public enum VideoFramePosition : ulong
	{
		ostCapture = 1uL << 0,
		reRenderer = 1uL << 1,
		reEncoder = 1uL << 2
	}

	[Native]
	public enum AudioFramePosition : ulong
	{
		Playback = 1uL << 0,
		Record = 1uL << 1,
		Mixed = 1uL << 2,
		BeforeMixing = 1uL << 3
	}

	[Native]
	public enum VideoBufferType : long
	{
		PixelBuffer = 1,
		RawData = 2
	}

	[Native]
	public enum VideoCaptureType : long
	{
		Unknown = 0,
		Camera = 1,
		Screen = 2
	}

	[Native]
	public enum RtcDefaultCameraPosition : long
	{
		Front = 0,
		Back = 1
	}

	[Native]
	public enum MetadataType : long
	{
		Unknown = -1,
		Video = 0
	}
}
