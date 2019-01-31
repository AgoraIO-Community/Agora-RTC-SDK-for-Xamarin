using System;
namespace Xamarin.Agora.Full.Forms
{
    /// <summary>
    /// Agora service ios.
    /// </summary>
    public class AgoraServiceIos
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            AgoraService.Init(new AgoraServiceImplementation());
        }
    }
}
