using System;
using Foundation;
using ObjCRuntime;

namespace DT.Xamarin.Agora
{
    // typedef void (^AgoraRtmLocalInvitationSendBlock)(AgoraRtmInvitationApiCallErrorCode);
    delegate void AgoraRtmLocalInvitationSendBlock (AgoraRtmInvitationApiCallErrorCode arg0);

	// typedef void (^AgoraRtmRemoteInvitationAcceptBlock)(AgoraRtmInvitationApiCallErrorCode);
	delegate void AgoraRtmRemoteInvitationAcceptBlock (AgoraRtmInvitationApiCallErrorCode arg0);

	// typedef void (^AgoraRtmRemoteInvitationRefuseBlock)(AgoraRtmInvitationApiCallErrorCode);
	delegate void AgoraRtmRemoteInvitationRefuseBlock (AgoraRtmInvitationApiCallErrorCode arg0);

	// typedef void (^AgoraRtmLocalInvitationCancelBlock)(AgoraRtmInvitationApiCallErrorCode);
	delegate void AgoraRtmLocalInvitationCancelBlock (AgoraRtmInvitationApiCallErrorCode arg0);

	// @interface AgoraRtmLocalInvitation : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmLocalInvitation
	{
		// @property (copy, nonatomic) NSString * _Nonnull calleeId;
		[Export ("calleeId")]
		string CalleeId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable content;
		[NullAllowed, Export ("content")]
		string Content { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable response;
		[NullAllowed, Export ("response")]
		string Response { get; }

		// @property (copy, nonatomic) NSString * _Nullable channelId;
		[NullAllowed, Export ("channelId")]
		string ChannelId { get; set; }

		// @property (readonly, assign, nonatomic) AgoraRtmLocalInvitationState state;
		[Export ("state", ArgumentSemantic.Assign)]
		AgoraRtmLocalInvitationState State { get; }

		// -(instancetype _Nonnull)initWithCalleeId:(NSString * _Nonnull)calleeId;
		[Export ("initWithCalleeId:")]
		IntPtr Constructor (string calleeId);
	}

	// @interface AgoraRtmRemoteInvitation : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmRemoteInvitation
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull callerId;
		[Export ("callerId")]
		string CallerId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable content;
		[NullAllowed, Export ("content")]
		string Content { get; }

		// @property (copy, nonatomic) NSString * _Nullable response;
		[NullAllowed, Export ("response")]
		string Response { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable channelId;
		[NullAllowed, Export ("channelId")]
		string ChannelId { get; }

		// @property (readonly, assign, nonatomic) AgoraRtmRemoteInvitationState state;
		[Export ("state", ArgumentSemantic.Assign)]
		AgoraRtmRemoteInvitationState State { get; }
	}

	// @protocol AgoraRtmCallDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AgoraRtmCallDelegate
	{
		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit localInvitationReceivedByPeer:(AgoraRtmLocalInvitation * _Nonnull)localInvitation;
		[Export ("rtmCallKit:localInvitationReceivedByPeer:")]
		void LocalInvitationReceivedByPeer (AgoraRtmCallKit callKit, AgoraRtmLocalInvitation localInvitation);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit localInvitationAccepted:(AgoraRtmLocalInvitation * _Nonnull)localInvitation withResponse:(NSString * _Nullable)response;
		[Export ("rtmCallKit:localInvitationAccepted:withResponse:")]
		void LocalInvitationAccepted (AgoraRtmCallKit callKit, AgoraRtmLocalInvitation localInvitation, [NullAllowed] string response);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit localInvitationRefused:(AgoraRtmLocalInvitation * _Nonnull)localInvitation withResponse:(NSString * _Nullable)response;
		[Export ("rtmCallKit:localInvitationRefused:withResponse:")]
		void LocalInvitationRefused (AgoraRtmCallKit callKit, AgoraRtmLocalInvitation localInvitation, [NullAllowed] string response);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit localInvitationCanceled:(AgoraRtmLocalInvitation * _Nonnull)localInvitation;
		[Export ("rtmCallKit:localInvitationCanceled:")]
		void LocalInvitationCanceled (AgoraRtmCallKit callKit, AgoraRtmLocalInvitation localInvitation);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit localInvitationFailure:(AgoraRtmLocalInvitation * _Nonnull)localInvitation errorCode:(AgoraRtmLocalInvitationErrorCode)errorCode;
		[Export ("rtmCallKit:localInvitationFailure:errorCode:")]
		void LocalInvitationFailure (AgoraRtmCallKit callKit, AgoraRtmLocalInvitation localInvitation, AgoraRtmLocalInvitationErrorCode errorCode);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit remoteInvitationReceived:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation;
		[Export ("rtmCallKit:remoteInvitationReceived:")]
		void RemoteInvitationReceived (AgoraRtmCallKit callKit, AgoraRtmRemoteInvitation remoteInvitation);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit remoteInvitationRefused:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation;
		[Export ("rtmCallKit:remoteInvitationRefused:")]
		void RemoteInvitationRefused (AgoraRtmCallKit callKit, AgoraRtmRemoteInvitation remoteInvitation);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit remoteInvitationAccepted:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation;
		[Export ("rtmCallKit:remoteInvitationAccepted:")]
		void RemoteInvitationAccepted (AgoraRtmCallKit callKit, AgoraRtmRemoteInvitation remoteInvitation);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit remoteInvitationCanceled:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation;
		[Export ("rtmCallKit:remoteInvitationCanceled:")]
		void RemoteInvitationCanceled (AgoraRtmCallKit callKit, AgoraRtmRemoteInvitation remoteInvitation);

		// @optional -(void)rtmCallKit:(AgoraRtmCallKit * _Nonnull)callKit remoteInvitationFailure:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation errorCode:(AgoraRtmRemoteInvitationErrorCode)errorCode;
		[Export ("rtmCallKit:remoteInvitationFailure:errorCode:")]
		void RemoteInvitationFailure (AgoraRtmCallKit callKit, AgoraRtmRemoteInvitation remoteInvitation, AgoraRtmRemoteInvitationErrorCode errorCode);
	}

	// @interface AgoraRtmCallKit : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmCallKit
	{
		// @property (readonly, atomic, weak) AgoraRtmKit * _Nullable rtmKit;
		[NullAllowed, Export ("rtmKit", ArgumentSemantic.Weak)]
		AgoraRtmKit RtmKit { get; }

		[Wrap ("WeakCallDelegate")]
		[NullAllowed]
		AgoraRtmCallDelegate CallDelegate { get; set; }

		// @property (nonatomic, weak) id<AgoraRtmCallDelegate> _Nullable callDelegate;
		[NullAllowed, Export ("callDelegate", ArgumentSemantic.Weak)]
		NSObject WeakCallDelegate { get; set; }

		// -(void)sendLocalInvitation:(AgoraRtmLocalInvitation * _Nonnull)localInvitation completion:(AgoraRtmLocalInvitationSendBlock _Nullable)completion;
		[Export ("sendLocalInvitation:completion:")]
		void SendLocalInvitation (AgoraRtmLocalInvitation localInvitation, [NullAllowed] AgoraRtmLocalInvitationSendBlock completion);

		// -(void)cancelLocalInvitation:(AgoraRtmLocalInvitation * _Nonnull)localInvitation completion:(AgoraRtmLocalInvitationCancelBlock _Nullable)completion;
		[Export ("cancelLocalInvitation:completion:")]
		void CancelLocalInvitation (AgoraRtmLocalInvitation localInvitation, [NullAllowed] AgoraRtmLocalInvitationCancelBlock completion);

		// -(void)acceptRemoteInvitation:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation completion:(AgoraRtmRemoteInvitationAcceptBlock _Nullable)completion;
		[Export ("acceptRemoteInvitation:completion:")]
		void AcceptRemoteInvitation (AgoraRtmRemoteInvitation remoteInvitation, [NullAllowed] AgoraRtmRemoteInvitationAcceptBlock completion);

		// -(void)refuseRemoteInvitation:(AgoraRtmRemoteInvitation * _Nonnull)remoteInvitation completion:(AgoraRtmRemoteInvitationRefuseBlock _Nullable)completion;
		[Export ("refuseRemoteInvitation:completion:")]
		void RefuseRemoteInvitation (AgoraRtmRemoteInvitation remoteInvitation, [NullAllowed] AgoraRtmRemoteInvitationRefuseBlock completion);
	}

	// typedef void (^AgoraRtmLoginBlock)(AgoraRtmLoginErrorCode);
	delegate void AgoraRtmLoginBlock (AgoraRtmLoginErrorCode arg0);

	// typedef void (^AgoraRtmLogoutBlock)(AgoraRtmLogoutErrorCode);
	delegate void AgoraRtmLogoutBlock (AgoraRtmLogoutErrorCode arg0);

	// typedef void (^AgoraRtmSendPeerMessageBlock)(AgoraRtmSendPeerMessageErrorCode);
	delegate void AgoraRtmSendPeerMessageBlock (AgoraRtmSendPeerMessageErrorCode arg0);

    // typedef void (^AgoraRtmQueryPeersOnlineBlock)(NSArray<AgoraRtmPeerOnlineStatus *> *, AgoraRtmQueryPeersOnlineErrorCode);
    delegate void AgoraRtmQueryPeersOnlineBlock(AgoraRtmPeerOnlineStatus[] arg0, AgoraRtmQueryPeersOnlineErrorCode arg1);

    // typedef void (^AgoraRtmRenewTokenBlock)(NSString *, AgoraRtmRenewTokenErrorCode);
    delegate void AgoraRtmRenewTokenBlock(string arg0, AgoraRtmRenewTokenErrorCode arg1);

    // @interface AgoraRtmMessage : NSObject
    [BaseType (typeof(NSObject))]
	interface AgoraRtmMessage
	{
		// @property (readonly, assign, nonatomic) AgoraRtmMessageType type;
		[Export ("type", ArgumentSemantic.Assign)]
		AgoraRtmMessageType Type { get; }

		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

        // @property (readonly, assign, nonatomic) long long serverReceivedTs;
        [Export("serverReceivedTs")]
        long ServerReceivedTs { get; }

        // @property (readonly, assign, nonatomic) BOOL isOfflineMessage;
        [Export("isOfflineMessage")]
        bool IsOfflineMessage { get; }

        // -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text;
        [Export ("initWithText:")]
		IntPtr Constructor (string text);
	}

    // @interface AgoraRtmPeerOnlineStatus : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtmPeerOnlineStatus
    {
        // @property (copy, nonatomic) NSString * _Nonnull peerId;
        [Export("peerId")]
        string PeerId { get; set; }

        // @property (assign, nonatomic) BOOL isOnline;
        [Export("isOnline")]
        bool IsOnline { get; set; }
    }

    // @interface AgoraRtmChannelMemberCount : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtmChannelMemberCount
    {
        // @property (copy, nonatomic) NSString * _Nonnull channelId;
        [Export("channelId")]
        string ChannelId { get; set; }

        // @property (assign, nonatomic) int count;
        [Export("count")]
        int Count { get; set; }
    }

    // @protocol AgoraRtmDelegate <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AgoraRtmDelegate
	{
		// @optional -(void)rtmKit:(AgoraRtmKit * _Nonnull)kit connectionStateChanged:(AgoraRtmConnectionState)state reason:(AgoraRtmConnectionChangeReason)reason;
		[Export ("rtmKit:connectionStateChanged:reason:")]
		void ConnectionStateChanged (AgoraRtmKit kit, AgoraRtmConnectionState state, AgoraRtmConnectionChangeReason reason);

		// @optional -(void)rtmKit:(AgoraRtmKit * _Nonnull)kit messageReceived:(AgoraRtmMessage * _Nonnull)message fromPeer:(NSString * _Nonnull)peerId;
		[Export ("rtmKit:messageReceived:fromPeer:")]
		void MessageReceived (AgoraRtmKit kit, AgoraRtmMessage message, string peerId);

        // @optional -(void)rtmKitTokenDidExpire:(AgoraRtmKit * _Nonnull)kit;
        [Export("rtmKitTokenDidExpire:")]
        void RtmKitTokenDidExpire(AgoraRtmKit kit);
    }

    // @interface AgoraRtmAttribute : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtmAttribute
    {
        // @property (copy, nonatomic) NSString * _Nonnull key;
        [Export("key")]
        string Key { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull value;
        [Export("value")]
        string Value { get; set; }
    }

    // @interface AgoraRtmChannelAttribute : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtmChannelAttribute
    {
        // @property (copy, nonatomic) NSString * _Nonnull key;
        [Export("key")]
        string Key { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull value;
        [Export("value")]
        string Value { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull lastUpdateUserId;
        [Export("lastUpdateUserId")]
        string LastUpdateUserId { get; set; }

        // @property (readonly, assign, nonatomic) long long lastUpdateTs;
        [Export("lastUpdateTs")]
        long LastUpdateTs { get; }
    }

    // typedef void (^AgoraRtmSetLocalUserAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmSetLocalUserAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmAddOrUpdateLocalUserAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmAddOrUpdateLocalUserAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmDeleteLocalUserAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmDeleteLocalUserAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmClearLocalUserAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmClearLocalUserAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmGetUserAttributesBlock)(NSArray<AgoraRtmAttribute *> * _Nullable, NSString *, AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmGetUserAttributesBlock([NullAllowed] AgoraRtmAttribute[] arg0, string arg1, AgoraRtmProcessAttributeErrorCode arg2);

    // typedef void (^AgoraRtmChannelMemberCountBlock)(NSArray<AgoraRtmChannelMemberCount *> *, AgoraRtmChannelMemberCountErrorCode);
    delegate void AgoraRtmChannelMemberCountBlock(AgoraRtmChannelMemberCount[] arg0, AgoraRtmChannelMemberCountErrorCode arg1);

    // typedef void (^AgoraRtmSetChannelAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmSetChannelAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmAddOrUpdateChannelAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmAddOrUpdateChannelAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmDeleteChannelAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmDeleteChannelAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmClearChannelAttributesBlock)(AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmClearChannelAttributesBlock(AgoraRtmProcessAttributeErrorCode arg0);

    // typedef void (^AgoraRtmGetChannelAttributesBlock)(NSArray<AgoraRtmChannelAttribute *> * _Nullable, AgoraRtmProcessAttributeErrorCode);
    delegate void AgoraRtmGetChannelAttributesBlock([NullAllowed] AgoraRtmChannelAttribute[] arg0, AgoraRtmProcessAttributeErrorCode arg1);

    // @interface AgoraRtmSendMessageOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtmSendMessageOptions
    {
        // @property (assign, nonatomic) BOOL enableOfflineMessaging;
        [Export("enableOfflineMessaging")]
        bool EnableOfflineMessaging { get; set; }

        // @property (assign, nonatomic) BOOL enableHistoricalMessaging;
        [Export("enableHistoricalMessaging")]
        bool EnableHistoricalMessaging { get; set; }
    }

    // @interface AgoraRtmChannelAttributeOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtmChannelAttributeOptions
    {
        // @property (assign, nonatomic) BOOL enableNotificationToChannelMembers;
        [Export("enableNotificationToChannelMembers")]
        bool EnableNotificationToChannelMembers { get; set; }
    }

    // @interface AgoraRtmKit : NSObject
    [BaseType (typeof(NSObject))]
	interface AgoraRtmKit
	{
		[Wrap ("WeakAgoraRtmDelegate")]
		[NullAllowed]
		AgoraRtmDelegate AgoraRtmDelegate { get; set; }

		// @property (atomic, weak) id<AgoraRtmDelegate> _Nullable agoraRtmDelegate;
		[NullAllowed, Export ("agoraRtmDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAgoraRtmDelegate { get; set; }

		// @property (readonly, atomic) NSMutableDictionary<NSString *,AgoraRtmChannel *> * _Nullable channels __attribute__((deprecated("")));
		[NullAllowed, Export ("channels")]
		NSMutableDictionary<NSString, AgoraRtmChannel> Channels { get; }

		// @property (atomic, strong) AgoraRtmCallKit * _Nullable rtmCallKit;
		[NullAllowed, Export ("rtmCallKit", ArgumentSemantic.Strong)]
		AgoraRtmCallKit RtmCallKit { get; set; }

		// -(instancetype _Nullable)initWithAppId:(NSString * _Nonnull)appId delegate:(id<AgoraRtmDelegate> _Nullable)delegate;
		[Export ("initWithAppId:delegate:")]
		IntPtr Constructor (string appId, [NullAllowed] AgoraRtmDelegate @delegate);

		// -(void)loginByToken:(NSString * _Nullable)token user:(NSString * _Nonnull)userId completion:(AgoraRtmLoginBlock _Nullable)completionBlock;
		[Export ("loginByToken:user:completion:")]
		void LoginByToken ([NullAllowed] string token, string userId, [NullAllowed] AgoraRtmLoginBlock completionBlock);

		// -(void)logoutWithCompletion:(AgoraRtmLogoutBlock _Nullable)completionBlock;
		[Export ("logoutWithCompletion:")]
		void LogoutWithCompletion ([NullAllowed] AgoraRtmLogoutBlock completionBlock);

        // -(void)renewToken:(NSString * _Nonnull)token completion:(AgoraRtmRenewTokenBlock _Nullable)completionBlock;
        [Export("renewToken:completion:")]
        void RenewToken(string token, [NullAllowed] AgoraRtmRenewTokenBlock completionBlock);

        // -(void)sendMessage:(AgoraRtmMessage * _Nonnull)message toPeer:(NSString * _Nonnull)peerId completion:(AgoraRtmSendPeerMessageBlock _Nullable)completionBlock;
        [Export ("sendMessage:toPeer:completion:")]
		void SendMessage (AgoraRtmMessage message, string peerId, [NullAllowed] AgoraRtmSendPeerMessageBlock completionBlock);

        // -(void)sendMessage:(AgoraRtmMessage * _Nonnull)message toPeer:(NSString * _Nonnull)peerId sendMessageOptions:(AgoraRtmSendMessageOptions * _Nonnull)options completion:(AgoraRtmSendPeerMessageBlock _Nullable)completionBlock;
        [Export("sendMessage:toPeer:sendMessageOptions:completion:")]
        void SendMessage(AgoraRtmMessage message, string peerId, AgoraRtmSendMessageOptions options, [NullAllowed] AgoraRtmSendPeerMessageBlock completionBlock);

        // -(AgoraRtmChannel * _Nullable)createChannelWithId:(NSString * _Nonnull)channelId delegate:(id<AgoraRtmChannelDelegate> _Nullable)delegate;
        [Export ("createChannelWithId:delegate:")]
		[return: NullAllowed]
		AgoraRtmChannel CreateChannelWithId (string channelId, [NullAllowed] AgoraRtmChannelDelegate @delegate);

		// -(BOOL)destroyChannelWithId:(NSString * _Nonnull)channelId;
		[Export ("destroyChannelWithId:")]
		bool DestroyChannelWithId (string channelId);

        // -(AgoraRtmCallKit * _Nullable)getRtmCallKit;
        [NullAllowed, Export("getRtmCallKit")]
        AgoraRtmCallKit GetRtmCallKit();

        // -(void)queryPeersOnlineStatus:(NSArray<NSString *> * _Nonnull)peerIds completion:(AgoraRtmQueryPeersOnlineBlock _Nullable)completionBlock;
        [Export("queryPeersOnlineStatus:completion:")]
        void QueryPeersOnlineStatus(string[] peerIds, [NullAllowed] AgoraRtmQueryPeersOnlineBlock completionBlock);

        // -(void)setLocalUserAttributes:(NSArray<AgoraRtmAttribute *> * _Nullable)attributes completion:(AgoraRtmSetLocalUserAttributesBlock _Nullable)completionBlock;
        [Export("setLocalUserAttributes:completion:")]
        void SetLocalUserAttributes([NullAllowed] AgoraRtmAttribute[] attributes, [NullAllowed] AgoraRtmSetLocalUserAttributesBlock completionBlock);

        // -(void)addOrUpdateLocalUserAttributes:(NSArray<AgoraRtmAttribute *> * _Nullable)attributes completion:(AgoraRtmAddOrUpdateLocalUserAttributesBlock _Nullable)completionBlock;
        [Export("addOrUpdateLocalUserAttributes:completion:")]
        void AddOrUpdateLocalUserAttributes([NullAllowed] AgoraRtmAttribute[] attributes, [NullAllowed] AgoraRtmAddOrUpdateLocalUserAttributesBlock completionBlock);

        // -(void)deleteLocalUserAttributesByKeys:(NSArray<NSString *> * _Nullable)attributeKeys completion:(AgoraRtmDeleteLocalUserAttributesBlock _Nullable)completionBlock;
        [Export("deleteLocalUserAttributesByKeys:completion:")]
        void DeleteLocalUserAttributesByKeys([NullAllowed] string[] attributeKeys, [NullAllowed] AgoraRtmDeleteLocalUserAttributesBlock completionBlock);

        // -(void)clearLocalUserAttributesWithCompletion:(AgoraRtmClearLocalUserAttributesBlock _Nullable)completionBlock;
        [Export("clearLocalUserAttributesWithCompletion:")]
        void ClearLocalUserAttributesWithCompletion([NullAllowed] AgoraRtmClearLocalUserAttributesBlock completionBlock);

        // -(void)getUserAllAttributes:(NSString *)userId completion:(AgoraRtmGetUserAttributesBlock _Nullable)completionBlock;
        [Export("getUserAllAttributes:completion:")]
        void GetUserAllAttributes(string userId, [NullAllowed] AgoraRtmGetUserAttributesBlock completionBlock);

        // -(void)getUserAttributes:(NSString *)userId ByKeys:(NSArray<NSString *> * _Nullable)attributeKeys completion:(AgoraRtmGetUserAttributesBlock _Nullable)completionBlock;
        [Export("getUserAttributes:ByKeys:completion:")]
        void GetUserAttributes(string userId, [NullAllowed] string[] attributeKeys, [NullAllowed] AgoraRtmGetUserAttributesBlock completionBlock);

        // -(void)getChannelMemberCount:(NSArray<NSString *> * _Nonnull)channelIds completion:(AgoraRtmChannelMemberCountBlock _Nullable)completionBlock;
        [Export("getChannelMemberCount:completion:")]
        void GetChannelMemberCount(string[] channelIds, [NullAllowed] AgoraRtmChannelMemberCountBlock completionBlock);

        // -(void)setChannel:(NSString * _Nonnull)channelId Attributes:(NSArray<AgoraRtmChannelAttribute *> * _Nullable)attributes Options:(AgoraRtmChannelAttributeOptions * _Nonnull)options completion:(AgoraRtmSetChannelAttributesBlock _Nullable)completionBlock;
        [Export("setChannel:Attributes:Options:completion:")]
        void SetChannel(string channelId, [NullAllowed] AgoraRtmChannelAttribute[] attributes, AgoraRtmChannelAttributeOptions options, [NullAllowed] AgoraRtmSetChannelAttributesBlock completionBlock);

        // -(void)addOrUpdateChannel:(NSString * _Nonnull)channelId Attributes:(NSArray<AgoraRtmChannelAttribute *> * _Nullable)attributes Options:(AgoraRtmChannelAttributeOptions * _Nonnull)options completion:(AgoraRtmAddOrUpdateChannelAttributesBlock _Nullable)completionBlock;
        [Export("addOrUpdateChannel:Attributes:Options:completion:")]
        void AddOrUpdateChannel(string channelId, [NullAllowed] AgoraRtmChannelAttribute[] attributes, AgoraRtmChannelAttributeOptions options, [NullAllowed] AgoraRtmAddOrUpdateChannelAttributesBlock completionBlock);

        // -(void)deleteChannel:(NSString * _Nonnull)channelId AttributesByKeys:(NSArray<NSString *> * _Nullable)attributeKeys Options:(AgoraRtmChannelAttributeOptions * _Nonnull)options completion:(AgoraRtmDeleteChannelAttributesBlock _Nullable)completionBlock;
        [Export("deleteChannel:AttributesByKeys:Options:completion:")]
        void DeleteChannel(string channelId, [NullAllowed] string[] attributeKeys, AgoraRtmChannelAttributeOptions options, [NullAllowed] AgoraRtmDeleteChannelAttributesBlock completionBlock);

        // -(void)clearChannel:(NSString * _Nonnull)channelId Options:(AgoraRtmChannelAttributeOptions * _Nonnull)options AttributesWithCompletion:(AgoraRtmClearChannelAttributesBlock _Nullable)completionBlock;
        [Export("clearChannel:Options:AttributesWithCompletion:")]
        void ClearChannel(string channelId, AgoraRtmChannelAttributeOptions options, [NullAllowed] AgoraRtmClearChannelAttributesBlock completionBlock);

        // -(void)getChannelAllAttributes:(NSString * _Nonnull)channelId completion:(AgoraRtmGetChannelAttributesBlock _Nullable)completionBlock;
        [Export("getChannelAllAttributes:completion:")]
        void GetChannelAllAttributes(string channelId, [NullAllowed] AgoraRtmGetChannelAttributesBlock completionBlock);

        // -(void)getChannelAttributes:(NSString * _Nonnull)channelId ByKeys:(NSArray<NSString *> * _Nullable)attributeKeys completion:(AgoraRtmGetChannelAttributesBlock _Nullable)completionBlock;
        [Export("getChannelAttributes:ByKeys:completion:")]
        void GetChannelAttributes(string channelId, [NullAllowed] string[] attributeKeys, [NullAllowed] AgoraRtmGetChannelAttributesBlock completionBlock);

        // -(int)setParameters:(NSString * _Nonnull)parameters;
        [Export("setParameters:")]
        int SetParameters(string parameters);

        // -(int)setLogFile:(NSString * _Nonnull)logFile;
        [Export("setLogFile:")]
        int SetLogFile(string logFile);

        // -(int)setLogFileSize:(int)fileSize;
        [Export("setLogFileSize:")]
        int SetLogFileSize(int fileSize);

        // -(int)setLogFilters:(AgoraRtmLogFilter)filter;
        [Export("setLogFilters:")]
        int SetLogFilters(AgoraRtmLogFilter filter);

        // +(NSString *)getSDKVersion;
        [Static]
        [Export("getSDKVersion")]
        string GetSDKVersion();
    }

	// @interface AgoraRtmMember : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmMember
	{
		// @property (copy, nonatomic) NSString * _Nonnull userId;
		[Export ("userId")]
		string UserId { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull channelId;
		[Export ("channelId")]
		string ChannelId { get; set; }
	}

	// typedef void (^AgoraRtmJoinChannelBlock)(AgoraRtmJoinChannelErrorCode);
	delegate void AgoraRtmJoinChannelBlock (AgoraRtmJoinChannelErrorCode arg0);

	// typedef void (^AgoraRtmLeaveChannelBlock)(AgoraRtmLeaveChannelErrorCode);
	delegate void AgoraRtmLeaveChannelBlock (AgoraRtmLeaveChannelErrorCode arg0);

	// typedef void (^AgoraRtmSendChannelMessageBlock)(AgoraRtmSendChannelMessageErrorCode);
	delegate void AgoraRtmSendChannelMessageBlock (AgoraRtmSendChannelMessageErrorCode arg0);

	// typedef void (^AgoraRtmGetMembersBlock)(NSArray<AgoraRtmMember *> * _Nullable, AgoraRtmGetMembersErrorCode);
	delegate void AgoraRtmGetMembersBlock ([NullAllowed] AgoraRtmMember[] arg0, AgoraRtmGetMembersErrorCode arg1);

	// @protocol AgoraRtmChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AgoraRtmChannelDelegate
	{
		// @optional -(void)channel:(AgoraRtmChannel * _Nonnull)channel memberJoined:(AgoraRtmMember * _Nonnull)member;
		[Export ("channel:memberJoined:")]
		void MemberJoined (AgoraRtmChannel channel, AgoraRtmMember member);

		// @optional -(void)channel:(AgoraRtmChannel * _Nonnull)channel memberLeft:(AgoraRtmMember * _Nonnull)member;
		[Export ("channel:memberLeft:")]
		void MemberLeft (AgoraRtmChannel channel, AgoraRtmMember member);

		// @optional -(void)channel:(AgoraRtmChannel * _Nonnull)channel messageReceived:(AgoraRtmMessage * _Nonnull)message fromMember:(AgoraRtmMember * _Nonnull)member;
		[Export ("channel:messageReceived:fromMember:")]
		void MessageReceived (AgoraRtmChannel channel, AgoraRtmMessage message, AgoraRtmMember member);

        // @optional -(void)channel:(AgoraRtmChannel * _Nonnull)channel attributeUpdate:(NSArray<AgoraRtmChannelAttribute *> * _Nonnull)attributes;
        [Export("channel:attributeUpdate:")]
        void AttributeUpdate(AgoraRtmChannel channel, AgoraRtmChannelAttribute[] attributes);

        // @optional -(void)channel:(AgoraRtmChannel * _Nonnull)channel memberCount:(int)count;
        [Export("channel:memberCount:")]
        void MemberCount(AgoraRtmChannel channel, int count);
    }

	// @interface AgoraRtmChannel : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmChannel : INativeObject
    {
		// @property (readonly, atomic) AgoraRtmKit * _Nonnull kit;
		[Export ("kit")]
		AgoraRtmKit Kit { get; }

		[Wrap ("WeakChannelDelegate")]
		[NullAllowed]
		AgoraRtmChannelDelegate ChannelDelegate { get; set; }

		// @property (nonatomic, weak) id<AgoraRtmChannelDelegate> _Nullable channelDelegate;
		[NullAllowed, Export ("channelDelegate", ArgumentSemantic.Weak)]
		NSObject WeakChannelDelegate { get; set; }

		// -(void)joinWithCompletion:(AgoraRtmJoinChannelBlock _Nullable)completionBlock;
		[Export ("joinWithCompletion:")]
		void JoinWithCompletion ([NullAllowed] AgoraRtmJoinChannelBlock completionBlock);

		// -(void)leaveWithCompletion:(AgoraRtmLeaveChannelBlock _Nullable)completionBlock;
		[Export ("leaveWithCompletion:")]
		void LeaveWithCompletion ([NullAllowed] AgoraRtmLeaveChannelBlock completionBlock);

		// -(void)sendMessage:(AgoraRtmMessage * _Nonnull)message completion:(AgoraRtmSendChannelMessageBlock _Nullable)completionBlock;
		[Export ("sendMessage:completion:")]
		void SendMessage (AgoraRtmMessage message, [NullAllowed] AgoraRtmSendChannelMessageBlock completionBlock);

        // -(void)sendMessage:(AgoraRtmMessage * _Nonnull)message sendMessageOptions:(AgoraRtmSendMessageOptions * _Nonnull)options completion:(AgoraRtmSendChannelMessageBlock _Nullable)completionBlock;
        [Export("sendMessage:sendMessageOptions:completion:")]
        void SendMessage(AgoraRtmMessage message, AgoraRtmSendMessageOptions options, [NullAllowed] AgoraRtmSendChannelMessageBlock completionBlock);

        // -(void)getMembersWithCompletion:(AgoraRtmGetMembersBlock _Nullable)completionBlock;
        [Export ("getMembersWithCompletion:")]
		void GetMembersWithCompletion ([NullAllowed] AgoraRtmGetMembersBlock completionBlock);
	}
}
