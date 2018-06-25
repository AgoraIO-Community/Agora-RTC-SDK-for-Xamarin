using System;
using System.Collections.Generic;
using Android.Runtime;

namespace DT.Xamarin.Agora.Internal
{
    public partial class RtcEngineMessage : global::Java.Lang.Object
    {
        public partial class MediaAppContext : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.MediaAppContext __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.MediaAppContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.MediaAppContext']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class MediaNetworkInfo : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.MediaNetworkInfo __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.MediaNetworkInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.MediaNetworkInfo']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class MediaResSetupTime : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.MediaResSetupTime __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.MediaResSetupTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.MediaResSetupTime']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PApiCallExecuted : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PApiCallExecuted __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PApiCallExecuted>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PApiCallExecuted']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PError : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PError __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PError']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PFirstLocalVideoFrame : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstLocalVideoFrame __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstLocalVideoFrame>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PFirstLocalVideoFrame']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PFirstRemoteVideoDecoded : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstRemoteVideoDecoded __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstRemoteVideoDecoded>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PFirstRemoteVideoDecoded']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PFirstRemoteVideoFrame : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstRemoteVideoFrame __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstRemoteVideoFrame>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PFirstRemoteVideoFrame']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PLocalVideoStat : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PLocalVideoStat __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PLocalVideoStat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PLocalVideoStat']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaEngineEvent : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaEngineEvent __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaEngineEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaEngineEvent']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaReqConnectMedia2 : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqConnectMedia2 __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqConnectMedia2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaReqConnectMedia2']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaReqCreateChannel : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqCreateChannel __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqCreateChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaReqCreateChannel']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaReqJoinMeida : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqJoinMeida __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqJoinMeida>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaReqJoinMeida']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaReqLeaveChannel : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqLeaveChannel __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqLeaveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaReqLeaveChannel']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaReqLeaveLinkd : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqLeaveLinkd __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqLeaveLinkd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaReqLeaveLinkd']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaReqUserData : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqUserData __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaReqUserData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaReqUserData']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResAudioQuality : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResAudioQuality __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResAudioQuality>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResAudioQuality']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResJoinMedia : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResJoinMedia __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResJoinMedia>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResJoinMedia']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResLastmileQuality : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResLastmileQuality __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResLastmileQuality>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResLastmileQuality']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResNetworkQuality : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResNetworkQuality __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResNetworkQuality>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResNetworkQuality']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResRtcStats : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResRtcStats __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResRtcStats>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResRtcStats']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResSpeakersReport : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResSpeakersReport __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResSpeakersReport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResSpeakersReport']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResTransportQuality : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResTransportQuality __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResTransportQuality>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResTransportQuality']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResUserJoinedEvent : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResUserJoinedEvent __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResUserJoinedEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResUserJoinedEvent']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResUserOfflineEvent : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResUserOfflineEvent __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResUserOfflineEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResUserOfflineEvent']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResUserState : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResUserState __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResUserState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResUserState']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PRecordingServiceStatus : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PRecordingServiceStatus __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PRecordingServiceStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PRecordingServiceStatus']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PRemoteVideoStat : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PRemoteVideoStat __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PRemoteVideoStat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PRemoteVideoStat']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PStreamMessage : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamMessage __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PStreamMessage']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PStreamMessageError : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamMessageError __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamMessageError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PStreamMessageError']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PVideoNetOptions : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PVideoNetOptions __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PVideoNetOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PVideoNetOptions']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }
        public partial class PVideoCompositingLayout : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PVideoCompositingLayout __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PVideoCompositingLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PVideoCompositingLayout']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PVideoSizeChanged : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PVideoSizeChanged __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PVideoSizeChanged>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PVideoSizeChanged']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PActiveSpeaker : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PActiveSpeaker __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PActiveSpeaker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PActiveSpeaker']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PFirstLocalAudioFrame : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstLocalAudioFrame __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstLocalAudioFrame>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PFirstLocalAudioFrame']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PMediaResAudioEffectFinished : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResAudioEffectFinished __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PMediaResAudioEffectFinished>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PMediaResAudioEffectFinished']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PFirstRemoteAudioFrame : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstRemoteAudioFrame __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PFirstRemoteAudioFrame>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PFirstRemoteAudioFrame']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PClientRoleChanged : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PClientRoleChanged __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PClientRoleChanged>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PClientRoleChanged']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PCameraFocusAreaChanged : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PCameraFocusAreaChanged __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PCameraFocusAreaChanged>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PCameraFocusAreaChanged']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PHostInRequest : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PHostInRequest __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PHostInRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PHostInRequest']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PHostInResponse : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PHostInResponse __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PHostInResponse>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PHostInResponse']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PHostInStopped : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PHostInStopped __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PHostInStopped>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PHostInStopped']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PInjectStreamConfig : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PInjectStreamConfig __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PInjectStreamConfig>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PInjectStreamConfig']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PLiveTranscoding : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PLiveTranscoding __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PLiveTranscoding>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PLiveTranscoding']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PStreamInjectedStatus : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamInjectedStatus __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamInjectedStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PStreamInjectedStatus']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PStreamPublished : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamPublished __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamPublished>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PStreamPublished']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PStreamUnPublished : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamUnPublished __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PStreamUnPublished>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PStreamUnPublished']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }

        public partial class PRemoteVideoState : global::DT.Xamarin.Agora.Internal.Marshallable
        {
            static Delegate cb_pushStringArray_Ljava_util_ArrayList_;
#pragma warning disable 0169
            static Delegate GetPushStringArray_Ljava_util_ArrayList_Handler()
            {
                if (cb_pushStringArray_Ljava_util_ArrayList_ == null)
                    cb_pushStringArray_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_PushStringArray_Ljava_util_ArrayList_);
                return cb_pushStringArray_Ljava_util_ArrayList_;
            }

            static void n_PushStringArray_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PRemoteVideoState __this = global::Java.Lang.Object.GetObject<global::DT.Xamarin.Agora.Internal.RtcEngineMessage.PRemoteVideoState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.PushStringArray(p0);
            }
#pragma warning restore 0169

            static IntPtr id_pushStringArray_Ljava_util_ArrayList_;
            // Metadata.xml XPath method reference: path="/api/package[@name='io.agora.rtc.internal']/class[@name='RtcEngineMessage.PRemoteVideoState']/method[@name='pushStringArray' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
            [Register("pushStringArray", "(Ljava/util/ArrayList;)V", "GetPushStringArray_Ljava_util_ArrayList_Handler")]
            public override unsafe void PushStringArray(global::System.Collections.Generic.IList<string> p0)
            {
                if (id_pushStringArray_Ljava_util_ArrayList_ == IntPtr.Zero)
                    id_pushStringArray_Ljava_util_ArrayList_ = JNIEnv.GetMethodID(class_ref, "pushStringArray", "(Ljava/util/ArrayList;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle(p0);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_pushStringArray_Ljava_util_ArrayList_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "pushStringArray", "(Ljava/util/ArrayList;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }
    }
}
