using System;
namespace Xamarin.Agora.Full.Forms
{
    /// <summary>
    /// Agora service droid.
    /// </summary>
    public class AgoraServiceDroid
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
