using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.App {

	[global::Android.Runtime.Register ("com/actionbarsherlock/app/SherlockDialogFragment", DoNotGenerateAcw=true)]
	public partial class SherlockDialogFragment : global::Android.Support.V4.App.DialogFragment, global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnCreateOptionsMenuListener, global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnOptionsItemSelectedListener, global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnPrepareOptionsMenuListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/app/SherlockDialogFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SherlockDialogFragment); }
		}

		protected SherlockDialogFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public SherlockDialogFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SherlockDialogFragment)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSherlockActivity;
#pragma warning disable 0169
		static Delegate GetGetSherlockActivityHandler ()
		{
			if (cb_getSherlockActivity == null)
				cb_getSherlockActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSherlockActivity);
			return cb_getSherlockActivity;
		}

		static IntPtr n_GetSherlockActivity (IntPtr jnienv, IntPtr native__this)
		{
			SherlockDialogFragment __this = Java.Lang.Object.GetObject<SherlockDialogFragment> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SherlockActivity);
		}
#pragma warning restore 0169

		static IntPtr id_getSherlockActivity;
		public virtual global::ActionBar_Sherlock.App.SherlockFragmentActivity SherlockActivity {
			[Register ("getSherlockActivity", "()Lcom/actionbarsherlock/app/SherlockFragmentActivity;", "GetGetSherlockActivityHandler")]
			get {
				if (id_getSherlockActivity == IntPtr.Zero)
					id_getSherlockActivity = JNIEnv.GetMethodID (class_ref, "getSherlockActivity", "()Lcom/actionbarsherlock/app/SherlockFragmentActivity;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.SherlockFragmentActivity> (JNIEnv.CallObjectMethod  (Handle, id_getSherlockActivity), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.SherlockFragmentActivity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSherlockActivity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_;
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V", "")]
		public override void OnCreateOptionsMenu (global::Android.Views.IMenu p0, global::Android.Views.MenuInflater p1)
		{
			if (id_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_, new JValue (p0), new JValue (p1));
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
			SherlockDialogFragment __this = Java.Lang.Object.GetObject<SherlockDialogFragment> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.MenuInflater p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateOptionsMenu (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
		[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler")]
		public virtual void OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0, global::ActionBar_Sherlock.View.MenuInflater p1)
		{
			if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_;
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "")]
		public override bool OnOptionsItemSelected (global::Android.Views.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Landroid_view_MenuItem_, new JValue (p0));
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
			SherlockDialogFragment __this = Java.Lang.Object.GetObject<SherlockDialogFragment> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItem p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler")]
		public virtual bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_;
		[Register ("onPrepareOptionsMenu", "(Landroid/view/Menu;)V", "")]
		public override void OnPrepareOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Landroid/view/Menu;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onPrepareOptionsMenu_Landroid_view_Menu_, new JValue (p0));
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
			SherlockDialogFragment __this = Java.Lang.Object.GetObject<SherlockDialogFragment> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepareOptionsMenu (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)V", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public virtual void OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
		}

	}
}
