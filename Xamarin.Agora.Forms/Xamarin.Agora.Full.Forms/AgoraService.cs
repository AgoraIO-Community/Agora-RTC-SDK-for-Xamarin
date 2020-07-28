using System;

namespace Xamarin.Agora.Full.Forms
{
    /// <summary>
    /// Agora service.
    /// </summary>
    public partial class AgoraService
    { 
        /// <summary>
        /// The unknown local stream identifier.
        /// </summary>
        public const uint UnknownLocalStreamId = 0;

        /// <summary>
        /// The unknown remote stream identifier.
        /// </summary>
        public const uint UnknownRemoteStreamId = 1;

        static Lazy<IAgoraService> Implementation = new Lazy<IAgoraService>(() => CreateService(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        static IAgoraService CreateService()
        {
#if NETSTANDARD2_0
            return null;
#else
            return new AgoraServiceImplementation();
#endif
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static IAgoraService Instance
        {
            get
            {
                IAgoraService realValue = Implementation.Value;
                if (realValue == null)
                {
                    throw new NotImplementedException();
                }
                return realValue;
            }
        }

        /// <summary>
        /// Gets the current IAgoraService
        /// </summary>
        /// <value>The current.</value>
        public static IAgoraService Current { get; private set; }

        /// <summary>
        /// Init the specified instance.
        /// </summary>
        /// <param name="instance">Instance.</param>
        public static void Init(IAgoraService instance)
        {
            Current = instance;
        }
    }
}
