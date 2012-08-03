using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V4.App {

	[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse", DoNotGenerateAcw=true)]
	public abstract partial class _ActionBarSherlockTrojanHorse : global::Android.Support.V4.App.FragmentActivity, global::ActionBar_Sherlock.ActionBarSherlock.IOnCreatePanelMenuListener, global::ActionBar_Sherlock.ActionBarSherlock.IOnMenuItemSelectedListener, global::ActionBar_Sherlock.ActionBarSherlock.IOnPreparePanelListener {

		[Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnCreateOptionsMenuListener", "", "Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerInvoker")]
		public partial interface IOnCreateOptionsMenuListener : IJavaObject {

			[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlockBinding")]
			void OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0, global::ActionBar_Sherlock.View.MenuInflater p1);

		}

		[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnCreateOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnCreateOptionsMenuListenerInvoker : Java.Lang.Object, IOnCreateOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnCreateOptionsMenuListener");
			IntPtr class_ref;

			public static IOnCreateOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnCreateOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v4.app._ActionBarSherlockTrojanHorse.OnCreateOptionsMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCreateOptionsMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCreateOptionsMenuListenerInvoker); }
			}

			static Delegate cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
#pragma warning disable 0169
			static Delegate GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler ()
			{
				if (cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ == null)
					cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_);
				return cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
			}

			static void n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				IOnCreateOptionsMenuListener __this = Java.Lang.Object.GetObject<IOnCreateOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.MenuInflater p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateOptionsMenu (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
			public void OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0, global::ActionBar_Sherlock.View.MenuInflater p1)
			{
				if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ == IntPtr.Zero)
					id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class CreateOptionsMenuEventArgs : global::System.EventArgs {

			public CreateOptionsMenuEventArgs (global::ActionBar_Sherlock.View.IMenu p0, global::ActionBar_Sherlock.View.MenuInflater p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::ActionBar_Sherlock.View.IMenu p0;
			public global::ActionBar_Sherlock.View.IMenu P0 {
				get { return p0; }
			}

			global::ActionBar_Sherlock.View.MenuInflater p1;
			public global::ActionBar_Sherlock.View.MenuInflater P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor")]
		internal sealed class IOnCreateOptionsMenuListenerImplementor : Java.Lang.Object, IOnCreateOptionsMenuListener {

			object sender;

			public IOnCreateOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CreateOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public void OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0, global::ActionBar_Sherlock.View.MenuInflater p1)
			{
				if (Handler != null)
					Handler (sender, new CreateOptionsMenuEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnCreateOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnOptionsItemSelectedListener", "", "Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerInvoker")]
		public partial interface IOnOptionsItemSelectedListener : IJavaObject {

			[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlockBinding")]
			bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0);

		}

		[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnOptionsItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnOptionsItemSelectedListenerInvoker : Java.Lang.Object, IOnOptionsItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnOptionsItemSelectedListener");
			IntPtr class_ref;

			public static IOnOptionsItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnOptionsItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v4.app._ActionBarSherlockTrojanHorse.OnOptionsItemSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnOptionsItemSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnOptionsItemSelectedListenerInvoker); }
			}

			static Delegate cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler ()
			{
				if (cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == null)
					cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_);
				return cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
			}

			static bool n_OnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				IOnOptionsItemSelectedListener __this = Java.Lang.Object.GetObject<IOnOptionsItemSelectedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenuItem p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnOptionsItemSelected (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
			public bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0)
			{
				if (id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
					id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
				return __ret;
			}

		}

		public partial class OptionsItemSelectedEventArgs : global::System.EventArgs {

			public OptionsItemSelectedEventArgs (bool handled, global::ActionBar_Sherlock.View.IMenuItem p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::ActionBar_Sherlock.View.IMenuItem p0;
			public global::ActionBar_Sherlock.View.IMenuItem P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor")]
		internal sealed class IOnOptionsItemSelectedListenerImplementor : Java.Lang.Object, IOnOptionsItemSelectedListener {

			object sender;

			public IOnOptionsItemSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<OptionsItemSelectedEventArgs> Handler;
#pragma warning restore 0649

			public bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new OptionsItemSelectedEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnOptionsItemSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnPrepareOptionsMenuListener", "", "Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnPrepareOptionsMenuListenerInvoker")]
		public partial interface IOnPrepareOptionsMenuListener : IJavaObject {

			[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)V", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnPrepareOptionsMenuListenerInvoker, ActionBarSherlockBinding")]
			void OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0);

		}

		[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnPrepareOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnPrepareOptionsMenuListenerInvoker : Java.Lang.Object, IOnPrepareOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnPrepareOptionsMenuListener");
			IntPtr class_ref;

			public static IOnPrepareOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnPrepareOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v4.app._ActionBarSherlockTrojanHorse.OnPrepareOptionsMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPrepareOptionsMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPrepareOptionsMenuListenerInvoker); }
			}

			static Delegate cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler ()
			{
				if (cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == null)
					cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
				return cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			}

			static void n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				IOnPrepareOptionsMenuListener __this = Java.Lang.Object.GetObject<IOnPrepareOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepareOptionsMenu (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			public void OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
			{
				if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)V");
				JNIEnv.CallVoidMethod (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			}

		}

		public partial class PrepareOptionsMenuEventArgs : global::System.EventArgs {

			public PrepareOptionsMenuEventArgs (global::ActionBar_Sherlock.View.IMenu p0)
			{
				this.p0 = p0;
			}

			global::ActionBar_Sherlock.View.IMenu p0;
			public global::ActionBar_Sherlock.View.IMenu P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnPrepareOptionsMenuListenerImplementor")]
		internal sealed class IOnPrepareOptionsMenuListenerImplementor : Java.Lang.Object, IOnPrepareOptionsMenuListener {

			object sender;

			public IOnPrepareOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnPrepareOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PrepareOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public void OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
			{
				if (Handler != null)
					Handler (sender, new PrepareOptionsMenuEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPrepareOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (_ActionBarSherlockTrojanHorse); }
		}

		protected _ActionBarSherlockTrojanHorse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public _ActionBarSherlockTrojanHorse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (_ActionBarSherlockTrojanHorse)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSupportMenuInflater;
#pragma warning disable 0169
		static Delegate GetGetSupportMenuInflaterHandler ()
		{
			if (cb_getSupportMenuInflater == null)
				cb_getSupportMenuInflater = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportMenuInflater);
			return cb_getSupportMenuInflater;
		}

		static IntPtr n_GetSupportMenuInflater (IntPtr jnienv, IntPtr native__this)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportMenuInflater);
		}
#pragma warning restore 0169

		public abstract global::ActionBar_Sherlock.View.MenuInflater SupportMenuInflater { [Register ("getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetSupportMenuInflaterHandler")] get; }

		static Delegate cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == null)
				cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
			return cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public abstract bool OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0);

		static Delegate cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ == null)
				cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_);
			return cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenu p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreatePanelMenu (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
		[Register ("onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z", "GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler")]
		public virtual bool OnCreatePanelMenu (int p0, global::ActionBar_Sherlock.View.IMenu p1)
		{
			if (id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_);
			return cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItem p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemSelected (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
		[Register ("onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler")]
		public virtual bool OnMenuItemSelected (int p0, global::ActionBar_Sherlock.View.IMenuItem p1)
		{
			if (id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_);
			return cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItem p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler")]
		public abstract bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0);

		static Delegate cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == null)
				cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
			return cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public abstract bool OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0);

		static Delegate cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ == null)
				cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_);
			return cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			_ActionBarSherlockTrojanHorse __this = Java.Lang.Object.GetObject<_ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenu p2 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPreparePanel (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
		[Register ("onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler")]
		public virtual bool OnPreparePanel (int p0, global::Android.Views.View p1, global::ActionBar_Sherlock.View.IMenu p2)
		{
			if (id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse", DoNotGenerateAcw=true)]
	internal partial class _ActionBarSherlockTrojanHorseInvoker : _ActionBarSherlockTrojanHorse {

		public _ActionBarSherlockTrojanHorseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (_ActionBarSherlockTrojanHorseInvoker); }
		}

		static IntPtr id_getSupportMenuInflater;
		public override global::ActionBar_Sherlock.View.MenuInflater SupportMenuInflater {
			[Register ("getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetSupportMenuInflaterHandler")]
			get {
				if (id_getSupportMenuInflater == IntPtr.Zero)
					id_getSupportMenuInflater = JNIEnv.GetMethodID (class_ref, "getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getSupportMenuInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public override bool OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
		{
			if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler")]
		public override bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public override bool OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I;
		[Register ("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", "GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler")]
		public override global::System.Boolean BindService (global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, [global::Android.Runtime.GeneratedEnum] global::Android.Content.Bind flags)
		{
			if (id_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I == IntPtr.Zero)
				id_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I = JNIEnv.GetMethodID (class_ref, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I, new JValue (service), new JValue (conn), new JValue ((int) flags));
			return __ret;
		}

		static IntPtr id_checkCallingOrSelfPermission_Ljava_lang_String_;
		[Register ("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", "GetCheckCallingOrSelfPermission_Ljava_lang_String_Handler")]
		public override global::Android.Content.PM.Permission CheckCallingOrSelfPermission (string permission)
		{
			if (id_checkCallingOrSelfPermission_Ljava_lang_String_ == IntPtr.Zero)
				id_checkCallingOrSelfPermission_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			IntPtr native_permission = JNIEnv.NewString (permission);
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkCallingOrSelfPermission_Ljava_lang_String_, new JValue (native_permission));
			JNIEnv.DeleteLocalRef (native_permission);
			return __ret;
		}

		static IntPtr id_checkCallingOrSelfUriPermission_Landroid_net_Uri_I;
		[Register ("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingOrSelfUriPermission_Landroid_net_Uri_IHandler")]
		public override global::Android.Content.PM.Permission CheckCallingOrSelfUriPermission (global::Android.Net.Uri uri, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags)
		{
			if (id_checkCallingOrSelfUriPermission_Landroid_net_Uri_I == IntPtr.Zero)
				id_checkCallingOrSelfUriPermission_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkCallingOrSelfUriPermission_Landroid_net_Uri_I, new JValue (uri), new JValue ((int) modeFlags));
			return __ret;
		}

		static IntPtr id_checkCallingPermission_Ljava_lang_String_;
		[Register ("checkCallingPermission", "(Ljava/lang/String;)I", "GetCheckCallingPermission_Ljava_lang_String_Handler")]
		public override global::Android.Content.PM.Permission CheckCallingPermission (string permission)
		{
			if (id_checkCallingPermission_Ljava_lang_String_ == IntPtr.Zero)
				id_checkCallingPermission_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkCallingPermission", "(Ljava/lang/String;)I");
			IntPtr native_permission = JNIEnv.NewString (permission);
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkCallingPermission_Ljava_lang_String_, new JValue (native_permission));
			JNIEnv.DeleteLocalRef (native_permission);
			return __ret;
		}

		static IntPtr id_checkCallingUriPermission_Landroid_net_Uri_I;
		[Register ("checkCallingUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingUriPermission_Landroid_net_Uri_IHandler")]
		public override global::Android.Content.PM.Permission CheckCallingUriPermission (global::Android.Net.Uri uri, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags)
		{
			if (id_checkCallingUriPermission_Landroid_net_Uri_I == IntPtr.Zero)
				id_checkCallingUriPermission_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkCallingUriPermission_Landroid_net_Uri_I, new JValue (uri), new JValue ((int) modeFlags));
			return __ret;
		}

		static IntPtr id_checkPermission_Ljava_lang_String_II;
		[Register ("checkPermission", "(Ljava/lang/String;II)I", "GetCheckPermission_Ljava_lang_String_IIHandler")]
		public override global::Android.Content.PM.Permission CheckPermission (string permission, int pid, int uid)
		{
			if (id_checkPermission_Ljava_lang_String_II == IntPtr.Zero)
				id_checkPermission_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "checkPermission", "(Ljava/lang/String;II)I");
			IntPtr native_permission = JNIEnv.NewString (permission);
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkPermission_Ljava_lang_String_II, new JValue (native_permission), new JValue (pid), new JValue (uid));
			JNIEnv.DeleteLocalRef (native_permission);
			return __ret;
		}

		static IntPtr id_checkUriPermission_Landroid_net_Uri_III;
		[Register ("checkUriPermission", "(Landroid/net/Uri;III)I", "GetCheckUriPermission_Landroid_net_Uri_IIIHandler")]
		public override global::Android.Content.PM.Permission CheckUriPermission (global::Android.Net.Uri uri, int pid, int uid, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags)
		{
			if (id_checkUriPermission_Landroid_net_Uri_III == IntPtr.Zero)
				id_checkUriPermission_Landroid_net_Uri_III = JNIEnv.GetMethodID (class_ref, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkUriPermission_Landroid_net_Uri_III, new JValue (uri), new JValue (pid), new JValue (uid), new JValue ((int) modeFlags));
			return __ret;
		}

		static IntPtr id_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III;
		[Register ("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", "GetCheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public override global::Android.Content.PM.Permission CheckUriPermission (global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags)
		{
			if (id_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III == IntPtr.Zero)
				id_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			IntPtr native_readPermission = JNIEnv.NewString (readPermission);
			IntPtr native_writePermission = JNIEnv.NewString (writePermission);
			global::Android.Content.PM.Permission __ret = (global::Android.Content.PM.Permission) JNIEnv.CallIntMethod  (Handle, id_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III, new JValue (uri), new JValue (native_readPermission), new JValue (native_writePermission), new JValue (pid), new JValue (uid), new JValue ((int) modeFlags));
			JNIEnv.DeleteLocalRef (native_readPermission);
			JNIEnv.DeleteLocalRef (native_writePermission);
			return __ret;
		}

		static IntPtr id_clearWallpaper;
		[Register ("clearWallpaper", "()V", "GetClearWallpaperHandler")]
		public override void ClearWallpaper ()
		{
			if (id_clearWallpaper == IntPtr.Zero)
				id_clearWallpaper = JNIEnv.GetMethodID (class_ref, "clearWallpaper", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clearWallpaper);
		}

		static IntPtr id_createPackageContext_Ljava_lang_String_I;
		[Register ("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", "GetCreatePackageContext_Ljava_lang_String_IHandler")]
		public override global::Android.Content.Context CreatePackageContext (string packageName, [global::Android.Runtime.GeneratedEnum] global::Android.Content.PackageContextFlags flags)
		{
			if (id_createPackageContext_Ljava_lang_String_I == IntPtr.Zero)
				id_createPackageContext_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			global::Android.Content.Context __ret = Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_createPackageContext_Ljava_lang_String_I, new JValue (native_packageName), new JValue ((int) flags)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_packageName);
			return __ret;
		}

		static IntPtr id_databaseList;
		[Register ("databaseList", "()[Ljava/lang/String;", "GetDatabaseListHandler")]
		public override global::System.String[] DatabaseList ()
		{
			if (id_databaseList == IntPtr.Zero)
				id_databaseList = JNIEnv.GetMethodID (class_ref, "databaseList", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_databaseList), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static IntPtr id_deleteDatabase_Ljava_lang_String_;
		[Register ("deleteDatabase", "(Ljava/lang/String;)Z", "GetDeleteDatabase_Ljava_lang_String_Handler")]
		public override global::System.Boolean DeleteDatabase (string name)
		{
			if (id_deleteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteDatabase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteDatabase", "(Ljava/lang/String;)Z");
			IntPtr native_name = JNIEnv.NewString (name);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_deleteDatabase_Ljava_lang_String_, new JValue (native_name));
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_deleteFile_Ljava_lang_String_;
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "GetDeleteFile_Ljava_lang_String_Handler")]
		public override global::System.Boolean DeleteFile (string name)
		{
			if (id_deleteFile_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteFile", "(Ljava/lang/String;)Z");
			IntPtr native_name = JNIEnv.NewString (name);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_deleteFile_Ljava_lang_String_, new JValue (native_name));
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_;
		[Register ("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override void EnforceCallingOrSelfPermission (string permission, string message)
		{
			if (id_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_permission = JNIEnv.NewString (permission);
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_, new JValue (native_permission), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_permission);
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_;
		[Register ("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public override void EnforceCallingOrSelfUriPermission (global::Android.Net.Uri uri, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags, string message)
		{
			if (id_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ == IntPtr.Zero)
				id_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_, new JValue (uri), new JValue ((int) modeFlags), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_;
		[Register ("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override void EnforceCallingPermission (string permission, string message)
		{
			if (id_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_permission = JNIEnv.NewString (permission);
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_, new JValue (native_permission), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_permission);
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_;
		[Register ("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public override void EnforceCallingUriPermission (global::Android.Net.Uri uri, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags, string message)
		{
			if (id_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ == IntPtr.Zero)
				id_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_, new JValue (uri), new JValue ((int) modeFlags), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_enforcePermission_Ljava_lang_String_IILjava_lang_String_;
		[Register ("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", "GetEnforcePermission_Ljava_lang_String_IILjava_lang_String_Handler")]
		public override void EnforcePermission (string permission, int pid, int uid, string message)
		{
			if (id_enforcePermission_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_enforcePermission_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			IntPtr native_permission = JNIEnv.NewString (permission);
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforcePermission_Ljava_lang_String_IILjava_lang_String_, new JValue (native_permission), new JValue (pid), new JValue (uid), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_permission);
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_;
		[Register ("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_Handler")]
		public override void EnforceUriPermission (global::Android.Net.Uri uri, int pid, int uid, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags, string message)
		{
			if (id_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ == IntPtr.Zero)
				id_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_, new JValue (uri), new JValue (pid), new JValue (uid), new JValue ((int) modeFlags), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
		[Register ("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler")]
		public override void EnforceUriPermission (global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags, string message)
		{
			if (id_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ == IntPtr.Zero)
				id_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			IntPtr native_readPermission = JNIEnv.NewString (readPermission);
			IntPtr native_writePermission = JNIEnv.NewString (writePermission);
			IntPtr native_message = JNIEnv.NewString (message);
			JNIEnv.CallVoidMethod  (Handle, id_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_, new JValue (uri), new JValue (native_readPermission), new JValue (native_writePermission), new JValue (pid), new JValue (uid), new JValue ((int) modeFlags), new JValue (native_message));
			JNIEnv.DeleteLocalRef (native_readPermission);
			JNIEnv.DeleteLocalRef (native_writePermission);
			JNIEnv.DeleteLocalRef (native_message);
		}

		static IntPtr id_fileList;
		[Register ("fileList", "()[Ljava/lang/String;", "GetFileListHandler")]
		public override global::System.String[] FileList ()
		{
			if (id_fileList == IntPtr.Zero)
				id_fileList = JNIEnv.GetMethodID (class_ref, "fileList", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_fileList), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static IntPtr id_getDatabasePath_Ljava_lang_String_;
		[Register ("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetDatabasePath_Ljava_lang_String_Handler")]
		public override global::Java.IO.File GetDatabasePath (string name)
		{
			if (id_getDatabasePath_Ljava_lang_String_ == IntPtr.Zero)
				id_getDatabasePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Java.IO.File __ret = Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDatabasePath_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_getDir_Ljava_lang_String_I;
		[Register ("getDir", "(Ljava/lang/String;I)Ljava/io/File;", "GetGetDir_Ljava_lang_String_IHandler")]
		public override global::Java.IO.File GetDir (string name, [global::Android.Runtime.GeneratedEnum] global::Android.Content.FileCreationMode mode)
		{
			if (id_getDir_Ljava_lang_String_I == IntPtr.Zero)
				id_getDir_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Java.IO.File __ret = Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDir_Ljava_lang_String_I, new JValue (native_name), new JValue ((int) mode)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_getExternalFilesDir_Ljava_lang_String_;
		[Register ("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", "GetGetExternalFilesDir_Ljava_lang_String_Handler")]
		public override global::Java.IO.File GetExternalFilesDir (string type)
		{
			if (id_getExternalFilesDir_Ljava_lang_String_ == IntPtr.Zero)
				id_getExternalFilesDir_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_type = JNIEnv.NewString (type);
			global::Java.IO.File __ret = Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getExternalFilesDir_Ljava_lang_String_, new JValue (native_type)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_type);
			return __ret;
		}

		static IntPtr id_getFileStreamPath_Ljava_lang_String_;
		[Register ("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetFileStreamPath_Ljava_lang_String_Handler")]
		public override global::Java.IO.File GetFileStreamPath (string name)
		{
			if (id_getFileStreamPath_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileStreamPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Java.IO.File __ret = Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getFileStreamPath_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_getSharedPreferences_Ljava_lang_String_I;
		[Register ("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", "GetGetSharedPreferences_Ljava_lang_String_IHandler")]
		public override global::Android.Content.ISharedPreferences GetSharedPreferences (string name, [global::Android.Runtime.GeneratedEnum] global::Android.Content.FileCreationMode mode)
		{
			if (id_getSharedPreferences_Ljava_lang_String_I == IntPtr.Zero)
				id_getSharedPreferences_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Android.Content.ISharedPreferences __ret = Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallObjectMethod  (Handle, id_getSharedPreferences_Ljava_lang_String_I, new JValue (native_name), new JValue ((int) mode)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_getSystemService_Ljava_lang_String_;
		[Register ("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetSystemService_Ljava_lang_String_Handler")]
		public override global::Java.Lang.Object GetSystemService (string name)
		{
			if (id_getSystemService_Ljava_lang_String_ == IntPtr.Zero)
				id_getSystemService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Java.Lang.Object __ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getSystemService_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I;
		[Register ("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", "GetGrantUriPermission_Ljava_lang_String_Landroid_net_Uri_IHandler")]
		public override void GrantUriPermission (string toPackage, global::Android.Net.Uri uri, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags)
		{
			if (id_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I == IntPtr.Zero)
				id_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			IntPtr native_toPackage = JNIEnv.NewString (toPackage);
			JNIEnv.CallVoidMethod  (Handle, id_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I, new JValue (native_toPackage), new JValue (uri), new JValue ((int) modeFlags));
			JNIEnv.DeleteLocalRef (native_toPackage);
		}

		static IntPtr id_openFileInput_Ljava_lang_String_;
		[Register ("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", "GetOpenFileInput_Ljava_lang_String_Handler")]
		public override global::System.IO.Stream OpenFileInput (string name)
		{
			if (id_openFileInput_Ljava_lang_String_ == IntPtr.Zero)
				id_openFileInput_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_openFileInput_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_openFileOutput_Ljava_lang_String_I;
		[Register ("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", "GetOpenFileOutput_Ljava_lang_String_IHandler")]
		public override global::System.IO.Stream OpenFileOutput (string name, [global::Android.Runtime.GeneratedEnum] global::Android.Content.FileCreationMode mode)
		{
			if (id_openFileOutput_Ljava_lang_String_I == IntPtr.Zero)
				id_openFileOutput_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::System.IO.Stream __ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_openFileOutput_Ljava_lang_String_I, new JValue (native_name), new JValue ((int) mode)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_;
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Handler")]
		public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string name, [global::Android.Runtime.GeneratedEnum] global::Android.Content.FileCreationMode mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory)
		{
			if (id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ == IntPtr.Zero)
				id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ = JNIEnv.GetMethodID (class_ref, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Android.Database.Sqlite.SQLiteDatabase __ret = Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod  (Handle, id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_, new JValue (native_name), new JValue ((int) mode), new JValue (factory)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_;
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_Handler")]
		public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string name, [global::Android.Runtime.GeneratedEnum] global::Android.Content.FileCreationMode mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler)
		{
			if (id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ == IntPtr.Zero)
				id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ = JNIEnv.GetMethodID (class_ref, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Android.Database.Sqlite.SQLiteDatabase __ret = Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod  (Handle, id_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_, new JValue (native_name), new JValue ((int) mode), new JValue (factory), new JValue (errorHandler)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_peekWallpaper;
		[Register ("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetPeekWallpaperHandler")]
		public override global::Android.Graphics.Drawables.Drawable PeekWallpaper ()
		{
			if (id_peekWallpaper == IntPtr.Zero)
				id_peekWallpaper = JNIEnv.GetMethodID (class_ref, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			return Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_peekWallpaper), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler")]
		public override global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter)
		{
			if (id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == IntPtr.Zero)
				id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNIEnv.GetMethodID (class_ref, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_, new JValue (receiver), new JValue (filter)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public override global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.OS.Handler scheduler)
		{
			if (id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ == IntPtr.Zero)
				id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			IntPtr native_broadcastPermission = JNIEnv.NewString (broadcastPermission);
			global::Android.Content.Intent __ret = Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_, new JValue (receiver), new JValue (filter), new JValue (native_broadcastPermission), new JValue (scheduler)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_broadcastPermission);
			return __ret;
		}

		static IntPtr id_removeStickyBroadcast_Landroid_content_Intent_;
		[Register ("removeStickyBroadcast", "(Landroid/content/Intent;)V", "GetRemoveStickyBroadcast_Landroid_content_Intent_Handler")]
		public override void RemoveStickyBroadcast (global::Android.Content.Intent intent)
		{
			if (id_removeStickyBroadcast_Landroid_content_Intent_ == IntPtr.Zero)
				id_removeStickyBroadcast_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeStickyBroadcast_Landroid_content_Intent_, new JValue (intent));
		}

		static IntPtr id_revokeUriPermission_Landroid_net_Uri_I;
		[Register ("revokeUriPermission", "(Landroid/net/Uri;I)V", "GetRevokeUriPermission_Landroid_net_Uri_IHandler")]
		public override void RevokeUriPermission (global::Android.Net.Uri uri, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags modeFlags)
		{
			if (id_revokeUriPermission_Landroid_net_Uri_I == IntPtr.Zero)
				id_revokeUriPermission_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_revokeUriPermission_Landroid_net_Uri_I, new JValue (uri), new JValue ((int) modeFlags));
		}

		static IntPtr id_sendBroadcast_Landroid_content_Intent_;
		[Register ("sendBroadcast", "(Landroid/content/Intent;)V", "GetSendBroadcast_Landroid_content_Intent_Handler")]
		public override void SendBroadcast (global::Android.Content.Intent intent)
		{
			if (id_sendBroadcast_Landroid_content_Intent_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "sendBroadcast", "(Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_sendBroadcast_Landroid_content_Intent_, new JValue (intent));
		}

		static IntPtr id_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_;
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public override void SendBroadcast (global::Android.Content.Intent intent, string receiverPermission)
		{
			if (id_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			JNIEnv.CallVoidMethod  (Handle, id_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_, new JValue (intent), new JValue (native_receiverPermission));
			JNIEnv.DeleteLocalRef (native_receiverPermission);
		}

		static IntPtr id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_;
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public override void SendOrderedBroadcast (global::Android.Content.Intent intent, string receiverPermission)
		{
			if (id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			JNIEnv.CallVoidMethod  (Handle, id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_, new JValue (intent), new JValue (native_receiverPermission));
			JNIEnv.DeleteLocalRef (native_receiverPermission);
		}

		static IntPtr id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override void SendOrderedBroadcast (global::Android.Content.Intent intent, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, [global::Android.Runtime.GeneratedEnum] global::Android.App.Result initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			if (id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			JNIEnv.CallVoidMethod  (Handle, id_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_, new JValue (intent), new JValue (native_receiverPermission), new JValue (resultReceiver), new JValue (scheduler), new JValue ((int) initialCode), new JValue (native_initialData), new JValue (initialExtras));
			JNIEnv.DeleteLocalRef (native_receiverPermission);
			JNIEnv.DeleteLocalRef (native_initialData);
		}

		static IntPtr id_sendStickyBroadcast_Landroid_content_Intent_;
		[Register ("sendStickyBroadcast", "(Landroid/content/Intent;)V", "GetSendStickyBroadcast_Landroid_content_Intent_Handler")]
		public override void SendStickyBroadcast (global::Android.Content.Intent intent)
		{
			if (id_sendStickyBroadcast_Landroid_content_Intent_ == IntPtr.Zero)
				id_sendStickyBroadcast_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_sendStickyBroadcast_Landroid_content_Intent_, new JValue (intent));
		}

		static IntPtr id_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		[Register ("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override void SendStickyOrderedBroadcast (global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, [global::Android.Runtime.GeneratedEnum] global::Android.App.Result initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			if (id_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			JNIEnv.CallVoidMethod  (Handle, id_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_, new JValue (intent), new JValue (resultReceiver), new JValue (scheduler), new JValue ((int) initialCode), new JValue (native_initialData), new JValue (initialExtras));
			JNIEnv.DeleteLocalRef (native_initialData);
		}

		static IntPtr id_setTheme_I;
		[Register ("setTheme", "(I)V", "GetSetTheme_IHandler")]
		public override void SetTheme (int resid)
		{
			if (id_setTheme_I == IntPtr.Zero)
				id_setTheme_I = JNIEnv.GetMethodID (class_ref, "setTheme", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setTheme_I, new JValue (resid));
		}

		static IntPtr id_setWallpaper_Landroid_graphics_Bitmap_;
		[Register ("setWallpaper", "(Landroid/graphics/Bitmap;)V", "GetSetWallpaper_Landroid_graphics_Bitmap_Handler")]
		public override void SetWallpaper (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_setWallpaper_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setWallpaper_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setWallpaper_Landroid_graphics_Bitmap_, new JValue (bitmap));
		}

		static IntPtr id_setWallpaper_Ljava_io_InputStream_;
		[Register ("setWallpaper", "(Ljava/io/InputStream;)V", "GetSetWallpaper_Ljava_io_InputStream_Handler")]
		public override void SetWallpaper (global::System.IO.Stream data)
		{
			if (id_setWallpaper_Ljava_io_InputStream_ == IntPtr.Zero)
				id_setWallpaper_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setWallpaper", "(Ljava/io/InputStream;)V");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			JNIEnv.CallVoidMethod  (Handle, id_setWallpaper_Ljava_io_InputStream_, new JValue (native_data));
			JNIEnv.DeleteLocalRef (native_data);
		}

		static IntPtr id_startActivities_arrayLandroid_content_Intent_;
		[Register ("startActivities", "([Landroid/content/Intent;)V", "GetStartActivities_arrayLandroid_content_Intent_Handler")]
		public override void StartActivities (global::Android.Content.Intent[] intents)
		{
			if (id_startActivities_arrayLandroid_content_Intent_ == IntPtr.Zero)
				id_startActivities_arrayLandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startActivities", "([Landroid/content/Intent;)V");
			IntPtr native_intents = JNIEnv.NewArray (intents);
			JNIEnv.CallVoidMethod  (Handle, id_startActivities_arrayLandroid_content_Intent_, new JValue (native_intents));
			if (intents != null) {
				JNIEnv.CopyArray (native_intents, intents);
				JNIEnv.DeleteLocalRef (native_intents);
			}
		}

		static IntPtr id_startActivity_Landroid_content_Intent_;
		[Register ("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public override void StartActivity (global::Android.Content.Intent intent)
		{
			if (id_startActivity_Landroid_content_Intent_ == IntPtr.Zero)
				id_startActivity_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startActivity", "(Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_startActivity_Landroid_content_Intent_, new JValue (intent));
		}

		static IntPtr id_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_;
		[Register ("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", "GetStartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override global::System.Boolean StartInstrumentation (global::Android.Content.ComponentName className, string profileFile, global::Android.OS.Bundle arguments)
		{
			if (id_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			IntPtr native_profileFile = JNIEnv.NewString (profileFile);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_, new JValue (className), new JValue (native_profileFile), new JValue (arguments));
			JNIEnv.DeleteLocalRef (native_profileFile);
			return __ret;
		}

		static IntPtr id_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III;
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIIHandler")]
		public override void StartIntentSender (global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags flagsMask, [global::Android.Runtime.GeneratedEnum] global::Android.Content.ActivityFlags flagsValues, int extraFlags)
		{
			if (id_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III == IntPtr.Zero)
				id_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III = JNIEnv.GetMethodID (class_ref, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			JNIEnv.CallVoidMethod  (Handle, id_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III, new JValue (intent), new JValue (fillInIntent), new JValue ((int) flagsMask), new JValue ((int) flagsValues), new JValue (extraFlags));
		}

		static IntPtr id_startService_Landroid_content_Intent_;
		[Register ("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", "GetStartService_Landroid_content_Intent_Handler")]
		public override global::Android.Content.ComponentName StartService (global::Android.Content.Intent service)
		{
			if (id_startService_Landroid_content_Intent_ == IntPtr.Zero)
				id_startService_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::Android.Content.ComponentName __ret = Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (JNIEnv.CallObjectMethod  (Handle, id_startService_Landroid_content_Intent_, new JValue (service)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_stopService_Landroid_content_Intent_;
		[Register ("stopService", "(Landroid/content/Intent;)Z", "GetStopService_Landroid_content_Intent_Handler")]
		public override global::System.Boolean StopService (global::Android.Content.Intent service)
		{
			if (id_stopService_Landroid_content_Intent_ == IntPtr.Zero)
				id_stopService_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "stopService", "(Landroid/content/Intent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_stopService_Landroid_content_Intent_, new JValue (service));
			return __ret;
		}

		static IntPtr id_unbindService_Landroid_content_ServiceConnection_;
		[Register ("unbindService", "(Landroid/content/ServiceConnection;)V", "GetUnbindService_Landroid_content_ServiceConnection_Handler")]
		public override void UnbindService (global::Android.Content.IServiceConnection conn)
		{
			if (id_unbindService_Landroid_content_ServiceConnection_ == IntPtr.Zero)
				id_unbindService_Landroid_content_ServiceConnection_ = JNIEnv.GetMethodID (class_ref, "unbindService", "(Landroid/content/ServiceConnection;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unbindService_Landroid_content_ServiceConnection_, new JValue (conn));
		}

		static IntPtr id_unregisterReceiver_Landroid_content_BroadcastReceiver_;
		[Register ("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public override void UnregisterReceiver (global::Android.Content.BroadcastReceiver receiver)
		{
			if (id_unregisterReceiver_Landroid_content_BroadcastReceiver_ == IntPtr.Zero)
				id_unregisterReceiver_Landroid_content_BroadcastReceiver_ = JNIEnv.GetMethodID (class_ref, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unregisterReceiver_Landroid_content_BroadcastReceiver_, new JValue (receiver));
		}

	}

}
