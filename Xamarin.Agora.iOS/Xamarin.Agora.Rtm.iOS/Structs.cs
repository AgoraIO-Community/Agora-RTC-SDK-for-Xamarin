using ObjCRuntime;

namespace DT.Xamarin.Agora
{
    [Native]
    public enum AgoraRtmLocalInvitationState : long
    {
        Idle = 0,
        SentToRemote = 1,
        ReceivedByRemote = 2,
        AcceptedByRemote = 3,
        RefusedByRemote = 4,
        Canceled = 5,
        Failure = 6
    }

    [Native]
    public enum AgoraRtmRemoteInvitationState : long
    {
        Idle = 0,
        InvitationReceived = 1,
        AcceptSentToLocal = 2,
        Refused = 3,
        Accepted = 4,
        Canceled = 5,
        Failure = 6
    }

    [Native]
    public enum AgoraRtmLocalInvitationErrorCode : long
    {
        Ok = 0,
        RemoteOffline = 1,
        RemoteNoResponse = 2,
        Expire = 3
    }

    [Native]
    public enum AgoraRtmRemoteInvitationErrorCode : long
    {
        Ok = 0,
        LocalOffline = 1,
        AcceptFailure = 2,
        Expire = 3
    }

    [Native]
    public enum AgoraRtmInvitationApiCallErrorCode : long
    {
        Ok = 0,
        InvalidAugment = 1,
        NotStarted = 2,
        AlreadyEnd = 3,
        AlreadyAccept = 4,
        AlreadySent = 5
    }

    [Native]
    public enum AgoraRtmMessageType : long
    {
        Undefined = 0,
        Text = 1
    }

    [Native]
    public enum AgoraRtmSendPeerMessageErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        Timeout = 2,
        PeerUnreachable = 3,
        CachedByServer = 4,
        TooOften = 5,
        InvalidUserId = 6,
        InvalidMessage = 7,
        NotInitialized = 101,
        NotLoggedIn = 102
	}

    [Native]
    public enum AgoraRtmConnectionState : long
    {
        Disconnected = 1,
        Connecting = 2,
        Connected = 3,
        Reconnecting = 4,
        Aborted = 5
    }

    [Native]
    public enum AgoraRtmConnectionChangeReason : long
    {
        Login = 1,
        LoginSuccess = 2,
        LoginFailure = 3,
        LoginTimeout = 4,
        Interrupted = 5,
        Logout = 6,
        BannedByServer = 7,
        RemoteLogin = 8
    }

    [Native]
    public enum AgoraRtmLoginErrorCode : long
    {
        Ok = 0,
        Unknown = 1,
        Rejected = 2,
        InvalidArgument = 3,
        InvalidAppId = 4,
        InvalidToken = 5,
        TokenExpired = 6,
        NotAuthorized = 7,
        AlreadyLogin = 8,
        Timeout = 9,
        LoginTooOften = 10,
        LoginNotInitialized = 101
	}

    [Native]
    public enum AgoraRtmLogoutErrorCode : long
    {
        Ok = 0,
        Rejected = 1,
        NotInitialized = 101,
        NotLoggedIn = 102
	}

    [Native]
    public enum AgoraRtmQueryPeersOnlineErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        InvalidArgument = 2,
        Rejected = 3,
        Timeout = 4,
        TooOften = 5,
        NotInitialized = 101,
        NotLoggedIn = 102
    }

    [Native]
    public enum AgoraRtmProcessAttributeErrorCode : long
    {
        Ok = 0,
        NotReady = 1,
        Failure = 2,
        InvalidArgument = 3,
        SizeOverflow = 4,
        TooOften = 5,
        UserNotFound = 6,
        Timeout = 7,
        NotInitialized = 101,
        NotLoggedIn = 102
    }

    [Native]
    public enum AgoraRtmRenewTokenErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        InvalidArgument = 2,
        Rejected = 3,
        TooOften = 4,
        TokenExpired = 5,
        InvalidToken = 6,
        NotInitialized = 101,
        NotLoggedIn = 102
    }

    [Native]
    public enum AgoraRtmChannelMemberCountErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        InvalidArgument = 2,
        TooOften = 3,
        Timeout = 4,
        ExceedLimit = 5,
        NotInitialized = 101,
        NotLoggedIn = 102
    }

    [Native]
    public enum AgoraRtmLogFilter : long
    {
        Off = 0,
        Info = 15,
        Warn = 14,
        Error = 12,
        Critical = 8,
        Mask = 2063
    }

	[Native]
    public enum AgoraRtmSendChannelMessageErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        Timeout = 2,
        TooOften = 3,
        InvalidMessage = 4,
        ErrorNotInitialized = 101,
        NotLoggedIn = 102
    }

    [Native]
    public enum AgoraRtmJoinChannelErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        Rejected = 2,
        InvalidArgument = 3,
        Timeout = 4,
        ExceedLimit = 5,
        AlreadyJoined = 6,
        ChannelErrorTooOften = 7,
        SameChannelErrorTooOften = 8,
        NotInitialized = 101,
        NotLoggedIn = 102
	}

    [Native]
    public enum AgoraRtmLeaveChannelErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        Rejected = 2,
        NotInChannel = 3,
        NotInitialized = 101,
        NotLoggedIn = 102
	}

    [Native]
    public enum AgoraRtmGetMembersErrorCode : long
    {
        Ok = 0,
        Failure = 1,
        Rejected = 2,
        Timeout = 3,
        TooOften = 4,
        NotInChannel = 5,
        NotInitialized = 101,
        NotLoggedIn = 102
	}
}