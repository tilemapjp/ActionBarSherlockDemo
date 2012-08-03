using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock {

	[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock", DoNotGenerateAcw=true)]
	public abstract partial class ActionBarSherlock : global::Java.Lang.Object {


		[Register ("DEBUG")]
		protected const bool Debug = (bool) false;

		[Register ("FLAG_DELEGATE")]
		public const int FlagDelegate = (int) 1;

		[Register ("TAG")]
		protected const string Tag = (string) "ActionBarSherlock";

		static IntPtr mActivity_jfieldId;

		[Register ("mActivity")]
		protected global::Android.App.Activity MActivity {
			get {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mActivity_jfieldId);
				return Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				JNIEnv.SetField (Handle, mActivity_jfieldId, JNIEnv.ToLocalJniHandle (value));
			}
		}

		static IntPtr mIsDelegate_jfieldId;

		[Register ("mIsDelegate")]
		protected bool MIsDelegate {
			get {
				if (mIsDelegate_jfieldId == IntPtr.Zero)
					mIsDelegate_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDelegate", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsDelegate_jfieldId);
			}
			set {
				if (mIsDelegate_jfieldId == IntPtr.Zero)
					mIsDelegate_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDelegate", "Z");
				JNIEnv.SetField (Handle, mIsDelegate_jfieldId, value);
			}
		}

		static IntPtr mMenuInflater_jfieldId;

		[Register ("mMenuInflater")]
		protected global::ActionBar_Sherlock.View.MenuInflater MMenuInflater {
			get {
				if (mMenuInflater_jfieldId == IntPtr.Zero)
					mMenuInflater_jfieldId = JNIEnv.GetFieldID (class_ref, "mMenuInflater", "Lcom/actionbarsherlock/view/MenuInflater;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMenuInflater_jfieldId);
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMenuInflater_jfieldId == IntPtr.Zero)
					mMenuInflater_jfieldId = JNIEnv.GetFieldID (class_ref, "mMenuInflater", "Lcom/actionbarsherlock/view/MenuInflater;");
				JNIEnv.SetField (Handle, mMenuInflater_jfieldId, JNIEnv.ToLocalJniHandle (value));
			}
		}
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeFinishedListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnActionModeFinishedListenerInvoker")]
		public partial interface IOnActionModeFinishedListener : IJavaObject {

			[Register ("onActionModeFinished", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnActionModeFinishedListenerInvoker, ActionBarSherlockBinding")]
			void OnActionModeFinished (global::ActionBar_Sherlock.View.ActionMode p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeFinishedListener", DoNotGenerateAcw=true)]
		internal class IOnActionModeFinishedListenerInvoker : Java.Lang.Object, IOnActionModeFinishedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnActionModeFinishedListener");
			IntPtr class_ref;

			public static IOnActionModeFinishedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnActionModeFinishedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnActionModeFinishedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnActionModeFinishedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnActionModeFinishedListenerInvoker); }
			}

			static Delegate cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetOnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_Handler ()
			{
				if (cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ == null)
					cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_);
				return cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
			}

			static void n_OnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				IOnActionModeFinishedListener __this = Java.Lang.Object.GetObject<IOnActionModeFinishedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.ActionMode p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActionModeFinished (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
			public void OnActionModeFinished (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				if (id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
					id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeFinished", "(Lcom/actionbarsherlock/view/ActionMode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			}

		}

		public partial class ActionModeFinishedEventArgs : global::System.EventArgs {

			public ActionModeFinishedEventArgs (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				this.p0 = p0;
			}

			global::ActionBar_Sherlock.View.ActionMode p0;
			public global::ActionBar_Sherlock.View.ActionMode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeFinishedListenerImplementor")]
		internal sealed class IOnActionModeFinishedListenerImplementor : Java.Lang.Object, IOnActionModeFinishedListener {

			object sender;

			public IOnActionModeFinishedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeFinishedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActionModeFinishedEventArgs> Handler;
#pragma warning restore 0649

			public void OnActionModeFinished (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				if (Handler != null)
					Handler (sender, new ActionModeFinishedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnActionModeFinishedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeStartedListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnActionModeStartedListenerInvoker")]
		public partial interface IOnActionModeStartedListener : IJavaObject {

			[Register ("onActionModeStarted", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnActionModeStartedListenerInvoker, ActionBarSherlockBinding")]
			void OnActionModeStarted (global::ActionBar_Sherlock.View.ActionMode p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeStartedListener", DoNotGenerateAcw=true)]
		internal class IOnActionModeStartedListenerInvoker : Java.Lang.Object, IOnActionModeStartedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnActionModeStartedListener");
			IntPtr class_ref;

			public static IOnActionModeStartedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnActionModeStartedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnActionModeStartedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnActionModeStartedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnActionModeStartedListenerInvoker); }
			}

			static Delegate cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetOnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_Handler ()
			{
				if (cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ == null)
					cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_);
				return cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
			}

			static void n_OnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				IOnActionModeStartedListener __this = Java.Lang.Object.GetObject<IOnActionModeStartedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.ActionMode p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActionModeStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
			public void OnActionModeStarted (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				if (id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
					id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeStarted", "(Lcom/actionbarsherlock/view/ActionMode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			}

		}

		public partial class ActionModeStartedEventArgs : global::System.EventArgs {

			public ActionModeStartedEventArgs (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				this.p0 = p0;
			}

			global::ActionBar_Sherlock.View.ActionMode p0;
			public global::ActionBar_Sherlock.View.ActionMode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeStartedListenerImplementor")]
		internal sealed class IOnActionModeStartedListenerImplementor : Java.Lang.Object, IOnActionModeStartedListener {

			object sender;

			public IOnActionModeStartedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeStartedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActionModeStartedEventArgs> Handler;
#pragma warning restore 0649

			public void OnActionModeStarted (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				if (Handler != null)
					Handler (sender, new ActionModeStartedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnActionModeStartedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnCreateOptionsMenuListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnCreateOptionsMenuListenerInvoker")]
		public partial interface IOnCreateOptionsMenuListener : IJavaObject {

			[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlockBinding")]
			bool OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnCreateOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnCreateOptionsMenuListenerInvoker : Java.Lang.Object, IOnCreateOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnCreateOptionsMenuListener");
			IntPtr class_ref;

			public static IOnCreateOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnCreateOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnCreateOptionsMenuListener"));
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
				IOnCreateOptionsMenuListener __this = Java.Lang.Object.GetObject<IOnCreateOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreateOptionsMenu (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			public bool OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
			{
				if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
				return __ret;
			}

		}

		public partial class CreateOptionsMenuEventArgs : global::System.EventArgs {

			public CreateOptionsMenuEventArgs (bool handled, global::ActionBar_Sherlock.View.IMenu p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::ActionBar_Sherlock.View.IMenu p0;
			public global::ActionBar_Sherlock.View.IMenu P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreateOptionsMenuListenerImplementor")]
		internal sealed class IOnCreateOptionsMenuListenerImplementor : Java.Lang.Object, IOnCreateOptionsMenuListener {

			object sender;

			public IOnCreateOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreateOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CreateOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public bool OnCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new CreateOptionsMenuEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnCreateOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnCreatePanelMenuListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnCreatePanelMenuListenerInvoker")]
		public partial interface IOnCreatePanelMenuListener : IJavaObject {

			[Register ("onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z", "GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnCreatePanelMenuListenerInvoker, ActionBarSherlockBinding")]
			bool OnCreatePanelMenu (int p0, global::ActionBar_Sherlock.View.IMenu p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnCreatePanelMenuListener", DoNotGenerateAcw=true)]
		internal class IOnCreatePanelMenuListenerInvoker : Java.Lang.Object, IOnCreatePanelMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnCreatePanelMenuListener");
			IntPtr class_ref;

			public static IOnCreatePanelMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnCreatePanelMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnCreatePanelMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCreatePanelMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCreatePanelMenuListenerInvoker); }
			}

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
				IOnCreatePanelMenuListener __this = Java.Lang.Object.GetObject<IOnCreatePanelMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreatePanelMenu (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
			public bool OnCreatePanelMenu (int p0, global::ActionBar_Sherlock.View.IMenu p1)
			{
				if (id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		public partial class CreatePanelMenuEventArgs : global::System.EventArgs {

			public CreatePanelMenuEventArgs (bool handled, int p0, global::ActionBar_Sherlock.View.IMenu p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::ActionBar_Sherlock.View.IMenu p1;
			public global::ActionBar_Sherlock.View.IMenu P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreatePanelMenuListenerImplementor")]
		internal sealed class IOnCreatePanelMenuListenerImplementor : Java.Lang.Object, IOnCreatePanelMenuListener {

			object sender;

			public IOnCreatePanelMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreatePanelMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CreatePanelMenuEventArgs> Handler;
#pragma warning restore 0649

			public bool OnCreatePanelMenu (int p0, global::ActionBar_Sherlock.View.IMenu p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new CreatePanelMenuEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnCreatePanelMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnMenuItemSelectedListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnMenuItemSelectedListenerInvoker")]
		public partial interface IOnMenuItemSelectedListener : IJavaObject {

			[Register ("onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnMenuItemSelectedListenerInvoker, ActionBarSherlockBinding")]
			bool OnMenuItemSelected (int p0, global::ActionBar_Sherlock.View.IMenuItem p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnMenuItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnMenuItemSelectedListenerInvoker : Java.Lang.Object, IOnMenuItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnMenuItemSelectedListener");
			IntPtr class_ref;

			public static IOnMenuItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnMenuItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnMenuItemSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMenuItemSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMenuItemSelectedListenerInvoker); }
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
				IOnMenuItemSelectedListener __this = Java.Lang.Object.GetObject<IOnMenuItemSelectedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenuItem p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMenuItemSelected (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
			public bool OnMenuItemSelected (int p0, global::ActionBar_Sherlock.View.IMenuItem p1)
			{
				if (id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
					id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		public partial class MenuItemSelectedEventArgs : global::System.EventArgs {

			public MenuItemSelectedEventArgs (bool handled, int p0, global::ActionBar_Sherlock.View.IMenuItem p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::ActionBar_Sherlock.View.IMenuItem p1;
			public global::ActionBar_Sherlock.View.IMenuItem P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnMenuItemSelectedListenerImplementor")]
		internal sealed class IOnMenuItemSelectedListenerImplementor : Java.Lang.Object, IOnMenuItemSelectedListener {

			object sender;

			public IOnMenuItemSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnMenuItemSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MenuItemSelectedEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMenuItemSelected (int p0, global::ActionBar_Sherlock.View.IMenuItem p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MenuItemSelectedEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMenuItemSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnOptionsItemSelectedListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerInvoker")]
		public partial interface IOnOptionsItemSelectedListener : IJavaObject {

			[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlockBinding")]
			bool OnOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnOptionsItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnOptionsItemSelectedListenerInvoker : Java.Lang.Object, IOnOptionsItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnOptionsItemSelectedListener");
			IntPtr class_ref;

			public static IOnOptionsItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnOptionsItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnOptionsItemSelectedListener"));
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

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnOptionsItemSelectedListenerImplementor")]
		internal sealed class IOnOptionsItemSelectedListenerImplementor : Java.Lang.Object, IOnOptionsItemSelectedListener {

			object sender;

			public IOnOptionsItemSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnOptionsItemSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
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


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnPrepareOptionsMenuListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnPrepareOptionsMenuListenerInvoker")]
		public partial interface IOnPrepareOptionsMenuListener : IJavaObject {

			[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnPrepareOptionsMenuListenerInvoker, ActionBarSherlockBinding")]
			bool OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnPrepareOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnPrepareOptionsMenuListenerInvoker : Java.Lang.Object, IOnPrepareOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnPrepareOptionsMenuListener");
			IntPtr class_ref;

			public static IOnPrepareOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnPrepareOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnPrepareOptionsMenuListener"));
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
					cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
				return cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			}

			static bool n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				IOnPrepareOptionsMenuListener __this = Java.Lang.Object.GetObject<IOnPrepareOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPrepareOptionsMenu (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			public bool OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
			{
				if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
				return __ret;
			}

		}

		public partial class PrepareOptionsMenuEventArgs : global::System.EventArgs {

			public PrepareOptionsMenuEventArgs (bool handled, global::ActionBar_Sherlock.View.IMenu p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::ActionBar_Sherlock.View.IMenu p0;
			public global::ActionBar_Sherlock.View.IMenu P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor")]
		internal sealed class IOnPrepareOptionsMenuListenerImplementor : Java.Lang.Object, IOnPrepareOptionsMenuListener {

			object sender;

			public IOnPrepareOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PrepareOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public bool OnPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new PrepareOptionsMenuEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnPrepareOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/ActionBarSherlock$OnPreparePanelListener", "", "ActionBar_Sherlock.ActionBarSherlock/IOnPreparePanelListenerInvoker")]
		public partial interface IOnPreparePanelListener : IJavaObject {

			[Register ("onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnPreparePanelListenerInvoker, ActionBarSherlockBinding")]
			bool OnPreparePanel (int p0, global::Android.Views.View p1, global::ActionBar_Sherlock.View.IMenu p2);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnPreparePanelListener", DoNotGenerateAcw=true)]
		internal class IOnPreparePanelListenerInvoker : Java.Lang.Object, IOnPreparePanelListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnPreparePanelListener");
			IntPtr class_ref;

			public static IOnPreparePanelListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnPreparePanelListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnPreparePanelListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPreparePanelListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPreparePanelListenerInvoker); }
			}

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
				IOnPreparePanelListener __this = Java.Lang.Object.GetObject<IOnPreparePanelListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p2 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPreparePanel (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
			public bool OnPreparePanel (int p0, global::Android.Views.View p1, global::ActionBar_Sherlock.View.IMenu p2)
			{
				if (id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1), new JValue (p2));
				return __ret;
			}

		}

		public partial class PreparePanelEventArgs : global::System.EventArgs {

			public PreparePanelEventArgs (bool handled, int p0, global::Android.Views.View p1, global::ActionBar_Sherlock.View.IMenu p2)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}

			global::ActionBar_Sherlock.View.IMenu p2;
			public global::ActionBar_Sherlock.View.IMenu P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnPreparePanelListenerImplementor")]
		internal sealed class IOnPreparePanelListenerImplementor : Java.Lang.Object, IOnPreparePanelListener {

			object sender;

			public IOnPreparePanelListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnPreparePanelListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PreparePanelEventArgs> Handler;
#pragma warning restore 0649

			public bool OnPreparePanel (int p0, global::Android.Views.View p1, global::ActionBar_Sherlock.View.IMenu p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new PreparePanelEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnPreparePanelListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarSherlock); }
		}

		protected ActionBarSherlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_I;
		[Register (".ctor", "(Landroid/app/Activity;I)V", "")]
		protected ActionBarSherlock (global::Android.App.Activity p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActionBarSherlock)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/app/Activity;I)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_app_Activity_I == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_app_Activity_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getActionBar;
#pragma warning disable 0169
		static Delegate GetGetActionBarHandler ()
		{
			if (cb_getActionBar == null)
				cb_getActionBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionBar);
			return cb_getActionBar;
		}

		static IntPtr n_GetActionBar (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionBar);
		}
#pragma warning restore 0169

		public abstract global::ActionBar_Sherlock.App.ActionBar ActionBar { [Register ("getActionBar", "()Lcom/actionbarsherlock/app/ActionBar;", "GetGetActionBarHandler")] get; }

		static Delegate cb_getMenuInflater;
#pragma warning disable 0169
		static Delegate GetGetMenuInflaterHandler ()
		{
			if (cb_getMenuInflater == null)
				cb_getMenuInflater = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMenuInflater);
			return cb_getMenuInflater;
		}

		static IntPtr n_GetMenuInflater (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MenuInflater);
		}
#pragma warning restore 0169

		static IntPtr id_getMenuInflater;
		public virtual global::ActionBar_Sherlock.View.MenuInflater MenuInflater {
			[Register ("getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetMenuInflaterHandler")]
			get {
				if (id_getMenuInflater == IntPtr.Zero)
					id_getMenuInflater = JNIEnv.GetMethodID (class_ref, "getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getMenuInflater), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMenuInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThemedContext;
#pragma warning disable 0169
		static Delegate GetGetThemedContextHandler ()
		{
			if (cb_getThemedContext == null)
				cb_getThemedContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThemedContext);
			return cb_getThemedContext;
		}

		static IntPtr n_GetThemedContext (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThemedContext);
		}
#pragma warning restore 0169

		protected abstract global::Android.Content.Context ThemedContext { [Register ("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")] get; }

		static Delegate cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler ()
		{
			if (cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
				cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_);
			return cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		static void n_AddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup.LayoutParams p1 = Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddContentView (p0, p1);
		}
#pragma warning restore 0169

		[Register ("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public abstract void AddContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1);

		static IntPtr id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		[Register ("callbackCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "")]
		protected bool CallbackCreateOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
		{
			if (id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "callbackCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		[Register ("callbackOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "")]
		protected bool CallbackOptionsItemSelected (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			if (id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "callbackOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		[Register ("callbackPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "")]
		protected bool CallbackPrepareOptionsMenu (global::ActionBar_Sherlock.View.IMenu p0)
		{
			if (id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "callbackPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_dispatchCloseOptionsMenu;
#pragma warning disable 0169
		static Delegate GetDispatchCloseOptionsMenuHandler ()
		{
			if (cb_dispatchCloseOptionsMenu == null)
				cb_dispatchCloseOptionsMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DispatchCloseOptionsMenu);
			return cb_dispatchCloseOptionsMenu;
		}

		static bool n_DispatchCloseOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DispatchCloseOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchCloseOptionsMenu;
		[Register ("dispatchCloseOptionsMenu", "()Z", "GetDispatchCloseOptionsMenuHandler")]
		public virtual bool DispatchCloseOptionsMenu ()
		{
			if (id_dispatchCloseOptionsMenu == IntPtr.Zero)
				id_dispatchCloseOptionsMenu = JNIEnv.GetMethodID (class_ref, "dispatchCloseOptionsMenu", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_dispatchCloseOptionsMenu);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchCloseOptionsMenu);
		}

		static Delegate cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetDispatchConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_DispatchConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchConfigurationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchConfigurationChanged_Landroid_content_res_Configuration_;
		[Register ("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetDispatchConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual void DispatchConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_dispatchConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_dispatchConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchConfigurationChanged_Landroid_content_res_Configuration_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchConfigurationChanged_Landroid_content_res_Configuration_, new JValue (p0));
		}

		static Delegate cb_dispatchCreateOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchCreateOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_dispatchCreateOptionsMenu_Landroid_view_Menu_ == null)
				cb_dispatchCreateOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchCreateOptionsMenu_Landroid_view_Menu_);
			return cb_dispatchCreateOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_DispatchCreateOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p0 = Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchCreateOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("dispatchCreateOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchCreateOptionsMenu_Landroid_view_Menu_Handler")]
		public abstract bool DispatchCreateOptionsMenu (global::Android.Views.IMenu p0);

		static Delegate cb_dispatchDestroy;
#pragma warning disable 0169
		static Delegate GetDispatchDestroyHandler ()
		{
			if (cb_dispatchDestroy == null)
				cb_dispatchDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchDestroy);
			return cb_dispatchDestroy;
		}

		static void n_DispatchDestroy (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchDestroy;
		[Register ("dispatchDestroy", "()V", "GetDispatchDestroyHandler")]
		public virtual void DispatchDestroy ()
		{
			if (id_dispatchDestroy == IntPtr.Zero)
				id_dispatchDestroy = JNIEnv.GetMethodID (class_ref, "dispatchDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchDestroy);
		}

		static Delegate cb_dispatchInvalidateOptionsMenu;
#pragma warning disable 0169
		static Delegate GetDispatchInvalidateOptionsMenuHandler ()
		{
			if (cb_dispatchInvalidateOptionsMenu == null)
				cb_dispatchInvalidateOptionsMenu = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchInvalidateOptionsMenu);
			return cb_dispatchInvalidateOptionsMenu;
		}

		static void n_DispatchInvalidateOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchInvalidateOptionsMenu ();
		}
#pragma warning restore 0169

		[Register ("dispatchInvalidateOptionsMenu", "()V", "GetDispatchInvalidateOptionsMenuHandler")]
		public abstract void DispatchInvalidateOptionsMenu ();

		static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchKeyEvent_Landroid_view_KeyEvent_);
			return cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p0 = Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchKeyEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchKeyEvent_Landroid_view_KeyEvent_;
		[Register ("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual bool DispatchKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_dispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchKeyEvent_Landroid_view_KeyEvent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchKeyEvent_Landroid_view_KeyEvent_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_dispatchMenuOpened_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchMenuOpened_ILandroid_view_Menu_Handler ()
		{
			if (cb_dispatchMenuOpened_ILandroid_view_Menu_ == null)
				cb_dispatchMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_DispatchMenuOpened_ILandroid_view_Menu_);
			return cb_dispatchMenuOpened_ILandroid_view_Menu_;
		}

		static bool n_DispatchMenuOpened_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchMenuOpened (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchMenuOpened_ILandroid_view_Menu_;
		[Register ("dispatchMenuOpened", "(ILandroid/view/Menu;)Z", "GetDispatchMenuOpened_ILandroid_view_Menu_Handler")]
		public virtual bool DispatchMenuOpened (int p0, global::Android.Views.IMenu p1)
		{
			if (id_dispatchMenuOpened_ILandroid_view_Menu_ == IntPtr.Zero)
				id_dispatchMenuOpened_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchMenuOpened", "(ILandroid/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchMenuOpened_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchMenuOpened_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_dispatchOpenOptionsMenu;
#pragma warning disable 0169
		static Delegate GetDispatchOpenOptionsMenuHandler ()
		{
			if (cb_dispatchOpenOptionsMenu == null)
				cb_dispatchOpenOptionsMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DispatchOpenOptionsMenu);
			return cb_dispatchOpenOptionsMenu;
		}

		static bool n_DispatchOpenOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DispatchOpenOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchOpenOptionsMenu;
		[Register ("dispatchOpenOptionsMenu", "()Z", "GetDispatchOpenOptionsMenuHandler")]
		public virtual bool DispatchOpenOptionsMenu ()
		{
			if (id_dispatchOpenOptionsMenu == IntPtr.Zero)
				id_dispatchOpenOptionsMenu = JNIEnv.GetMethodID (class_ref, "dispatchOpenOptionsMenu", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_dispatchOpenOptionsMenu);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchOpenOptionsMenu);
		}

		static Delegate cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetDispatchOptionsItemSelected_Landroid_view_MenuItem_Handler ()
		{
			if (cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_ == null)
				cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchOptionsItemSelected_Landroid_view_MenuItem_);
			return cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_;
		}

		static bool n_DispatchOptionsItemSelected_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem p0 = Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetDispatchOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public abstract bool DispatchOptionsItemSelected (global::Android.Views.IMenuItem p0);

		static Delegate cb_dispatchPanelClosed_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchPanelClosed_ILandroid_view_Menu_Handler ()
		{
			if (cb_dispatchPanelClosed_ILandroid_view_Menu_ == null)
				cb_dispatchPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DispatchPanelClosed_ILandroid_view_Menu_);
			return cb_dispatchPanelClosed_ILandroid_view_Menu_;
		}

		static void n_DispatchPanelClosed_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPanelClosed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPanelClosed_ILandroid_view_Menu_;
		[Register ("dispatchPanelClosed", "(ILandroid/view/Menu;)V", "GetDispatchPanelClosed_ILandroid_view_Menu_Handler")]
		public virtual void DispatchPanelClosed (int p0, global::Android.Views.IMenu p1)
		{
			if (id_dispatchPanelClosed_ILandroid_view_Menu_ == IntPtr.Zero)
				id_dispatchPanelClosed_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchPanelClosed", "(ILandroid/view/Menu;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPanelClosed_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPanelClosed_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_dispatchPause;
#pragma warning disable 0169
		static Delegate GetDispatchPauseHandler ()
		{
			if (cb_dispatchPause == null)
				cb_dispatchPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchPause);
			return cb_dispatchPause;
		}

		static void n_DispatchPause (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPause ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPause;
		[Register ("dispatchPause", "()V", "GetDispatchPauseHandler")]
		public virtual void DispatchPause ()
		{
			if (id_dispatchPause == IntPtr.Zero)
				id_dispatchPause = JNIEnv.GetMethodID (class_ref, "dispatchPause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPause);
		}

		static Delegate cb_dispatchPostCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDispatchPostCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_dispatchPostCreate_Landroid_os_Bundle_ == null)
				cb_dispatchPostCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchPostCreate_Landroid_os_Bundle_);
			return cb_dispatchPostCreate_Landroid_os_Bundle_;
		}

		static void n_DispatchPostCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPostCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPostCreate_Landroid_os_Bundle_;
		[Register ("dispatchPostCreate", "(Landroid/os/Bundle;)V", "GetDispatchPostCreate_Landroid_os_Bundle_Handler")]
		public virtual void DispatchPostCreate (global::Android.OS.Bundle p0)
		{
			if (id_dispatchPostCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_dispatchPostCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "dispatchPostCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPostCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPostCreate_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_dispatchPostResume;
#pragma warning disable 0169
		static Delegate GetDispatchPostResumeHandler ()
		{
			if (cb_dispatchPostResume == null)
				cb_dispatchPostResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchPostResume);
			return cb_dispatchPostResume;
		}

		static void n_DispatchPostResume (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPostResume ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPostResume;
		[Register ("dispatchPostResume", "()V", "GetDispatchPostResumeHandler")]
		public virtual void DispatchPostResume ()
		{
			if (id_dispatchPostResume == IntPtr.Zero)
				id_dispatchPostResume = JNIEnv.GetMethodID (class_ref, "dispatchPostResume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPostResume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPostResume);
		}

		static Delegate cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchPrepareOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_ == null)
				cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchPrepareOptionsMenu_Landroid_view_Menu_);
			return cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_DispatchPrepareOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p0 = Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchPrepareOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchPrepareOptionsMenu_Landroid_view_Menu_Handler")]
		public abstract bool DispatchPrepareOptionsMenu (global::Android.Views.IMenu p0);

		static Delegate cb_dispatchStop;
#pragma warning disable 0169
		static Delegate GetDispatchStopHandler ()
		{
			if (cb_dispatchStop == null)
				cb_dispatchStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchStop);
			return cb_dispatchStop;
		}

		static void n_DispatchStop (IntPtr jnienv, IntPtr native__this)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchStop ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchStop;
		[Register ("dispatchStop", "()V", "GetDispatchStopHandler")]
		public virtual void DispatchStop ()
		{
			if (id_dispatchStop == IntPtr.Zero)
				id_dispatchStop = JNIEnv.GetMethodID (class_ref, "dispatchStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchStop);
		}

		static Delegate cb_dispatchTitleChanged_Ljava_lang_CharSequence_I;
#pragma warning disable 0169
		static Delegate GetDispatchTitleChanged_Ljava_lang_CharSequence_IHandler ()
		{
			if (cb_dispatchTitleChanged_Ljava_lang_CharSequence_I == null)
				cb_dispatchTitleChanged_Ljava_lang_CharSequence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DispatchTitleChanged_Ljava_lang_CharSequence_I);
			return cb_dispatchTitleChanged_Ljava_lang_CharSequence_I;
		}

		static void n_DispatchTitleChanged_Ljava_lang_CharSequence_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchTitleChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchTitleChanged_Ljava_lang_CharSequence_I;
		[Register ("dispatchTitleChanged", "(Ljava/lang/CharSequence;I)V", "GetDispatchTitleChanged_Ljava_lang_CharSequence_IHandler")]
		public virtual void DispatchTitleChanged (global::Java.Lang.ICharSequence p0, int p1)
		{
			if (id_dispatchTitleChanged_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_dispatchTitleChanged_Ljava_lang_CharSequence_I = JNIEnv.GetMethodID (class_ref, "dispatchTitleChanged", "(Ljava/lang/CharSequence;I)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchTitleChanged_Ljava_lang_CharSequence_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchTitleChanged_Ljava_lang_CharSequence_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		public void DispatchTitleChanged (string p0, int p1)
		{
			Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
			DispatchTitleChanged (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_hasFeature_I;
#pragma warning disable 0169
		static Delegate GetHasFeature_IHandler ()
		{
			if (cb_hasFeature_I == null)
				cb_hasFeature_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_HasFeature_I);
			return cb_hasFeature_I;
		}

		static bool n_HasFeature_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFeature (p0);
		}
#pragma warning restore 0169

		[Register ("hasFeature", "(I)Z", "GetHasFeature_IHandler")]
		public abstract bool HasFeature (int p0);

		static IntPtr id_registerImplementation_Ljava_lang_Class_;
		[Register ("registerImplementation", "(Ljava/lang/Class;)V", "")]
		public static void RegisterImplementation (global::Java.Lang.Class p0)
		{
			if (id_registerImplementation_Ljava_lang_Class_ == IntPtr.Zero)
				id_registerImplementation_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "registerImplementation", "(Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerImplementation_Ljava_lang_Class_, new JValue (p0));
		}

		static Delegate cb_requestFeature_I;
#pragma warning disable 0169
		static Delegate GetRequestFeature_IHandler ()
		{
			if (cb_requestFeature_I == null)
				cb_requestFeature_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RequestFeature_I);
			return cb_requestFeature_I;
		}

		static bool n_RequestFeature_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestFeature (p0);
		}
#pragma warning restore 0169

		[Register ("requestFeature", "(I)Z", "GetRequestFeature_IHandler")]
		public abstract bool RequestFeature (int p0);

		static Delegate cb_setContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetContentView_Landroid_view_View_Handler ()
		{
			if (cb_setContentView_Landroid_view_View_ == null)
				cb_setContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentView_Landroid_view_View_);
			return cb_setContentView_Landroid_view_View_;
		}

		static void n_SetContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentView_Landroid_view_View_;
		[Register ("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
		public virtual void SetContentView (global::Android.Views.View p0)
		{
			if (id_setContentView_Landroid_view_View_ == IntPtr.Zero)
				id_setContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setContentView", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContentView_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setContentView_Landroid_view_View_, new JValue (p0));
		}

		static Delegate cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler ()
		{
			if (cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
				cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_);
			return cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		static void n_SetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup.LayoutParams p1 = Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetContentView (p0, p1);
		}
#pragma warning restore 0169

		[Register ("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public abstract void SetContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1);

		static Delegate cb_setContentView_I;
#pragma warning disable 0169
		static Delegate GetSetContentView_IHandler ()
		{
			if (cb_setContentView_I == null)
				cb_setContentView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContentView_I);
			return cb_setContentView_I;
		}

		static void n_SetContentView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentView (p0);
		}
#pragma warning restore 0169

		[Register ("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public abstract void SetContentView (int p0);

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (p0);
		}
#pragma warning restore 0169

		[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
		public abstract void SetProgress (int p0);

		static Delegate cb_setProgressBarIndeterminate_Z;
#pragma warning disable 0169
		static Delegate GetSetProgressBarIndeterminate_ZHandler ()
		{
			if (cb_setProgressBarIndeterminate_Z == null)
				cb_setProgressBarIndeterminate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProgressBarIndeterminate_Z);
			return cb_setProgressBarIndeterminate_Z;
		}

		static void n_SetProgressBarIndeterminate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarIndeterminate (p0);
		}
#pragma warning restore 0169

		[Register ("setProgressBarIndeterminate", "(Z)V", "GetSetProgressBarIndeterminate_ZHandler")]
		public abstract void SetProgressBarIndeterminate (bool p0);

		static Delegate cb_setProgressBarIndeterminateVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetProgressBarIndeterminateVisibility_ZHandler ()
		{
			if (cb_setProgressBarIndeterminateVisibility_Z == null)
				cb_setProgressBarIndeterminateVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProgressBarIndeterminateVisibility_Z);
			return cb_setProgressBarIndeterminateVisibility_Z;
		}

		static void n_SetProgressBarIndeterminateVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarIndeterminateVisibility (p0);
		}
#pragma warning restore 0169

		[Register ("setProgressBarIndeterminateVisibility", "(Z)V", "GetSetProgressBarIndeterminateVisibility_ZHandler")]
		public abstract void SetProgressBarIndeterminateVisibility (bool p0);

		static Delegate cb_setProgressBarVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetProgressBarVisibility_ZHandler ()
		{
			if (cb_setProgressBarVisibility_Z == null)
				cb_setProgressBarVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProgressBarVisibility_Z);
			return cb_setProgressBarVisibility_Z;
		}

		static void n_SetProgressBarVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarVisibility (p0);
		}
#pragma warning restore 0169

		[Register ("setProgressBarVisibility", "(Z)V", "GetSetProgressBarVisibility_ZHandler")]
		public abstract void SetProgressBarVisibility (bool p0);

		static Delegate cb_setSecondaryProgress_I;
#pragma warning disable 0169
		static Delegate GetSetSecondaryProgress_IHandler ()
		{
			if (cb_setSecondaryProgress_I == null)
				cb_setSecondaryProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSecondaryProgress_I);
			return cb_setSecondaryProgress_I;
		}

		static void n_SetSecondaryProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSecondaryProgress (p0);
		}
#pragma warning restore 0169

		[Register ("setSecondaryProgress", "(I)V", "GetSetSecondaryProgress_IHandler")]
		public abstract void SetSecondaryProgress (int p0);

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static void n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_I;
		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public virtual void SetTitle (int p0)
		{
			if (id_setTitle_I == IntPtr.Zero)
				id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTitle_I, new JValue (p0));
		}

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public abstract void SetTitle (global::Java.Lang.ICharSequence p0);

		public void SetTitle (string p0)
		{
			Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
			SetTitle (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setUiOptions_I;
#pragma warning disable 0169
		static Delegate GetSetUiOptions_IHandler ()
		{
			if (cb_setUiOptions_I == null)
				cb_setUiOptions_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUiOptions_I);
			return cb_setUiOptions_I;
		}

		static void n_SetUiOptions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUiOptions (p0);
		}
#pragma warning restore 0169

		[Register ("setUiOptions", "(I)V", "GetSetUiOptions_IHandler")]
		public abstract void SetUiOptions (int p0);

		static Delegate cb_setUiOptions_II;
#pragma warning disable 0169
		static Delegate GetSetUiOptions_IIHandler ()
		{
			if (cb_setUiOptions_II == null)
				cb_setUiOptions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetUiOptions_II);
			return cb_setUiOptions_II;
		}

		static void n_SetUiOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUiOptions (p0, p1);
		}
#pragma warning restore 0169

		[Register ("setUiOptions", "(II)V", "GetSetUiOptions_IIHandler")]
		public abstract void SetUiOptions (int p0, int p1);

		static Delegate cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler ()
		{
			if (cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ == null)
				cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_);
			return cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
		}

		static IntPtr n_StartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBarSherlock __this = Java.Lang.Object.GetObject<ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.ActionMode.ICallback p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		[Register ("startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;", "GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler")]
		public abstract global::ActionBar_Sherlock.View.ActionMode StartActionMode (global::ActionBar_Sherlock.View.ActionMode.ICallback p0);

		static IntPtr id_unregisterImplementation_Ljava_lang_Class_;
		[Register ("unregisterImplementation", "(Ljava/lang/Class;)Z", "")]
		public static bool UnregisterImplementation (global::Java.Lang.Class p0)
		{
			if (id_unregisterImplementation_Ljava_lang_Class_ == IntPtr.Zero)
				id_unregisterImplementation_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterImplementation", "(Ljava/lang/Class;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_unregisterImplementation_Ljava_lang_Class_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_wrap_Landroid_app_Activity_;
		[Register ("wrap", "(Landroid/app/Activity;)Lcom/actionbarsherlock/ActionBarSherlock;", "")]
		public static global::ActionBar_Sherlock.ActionBarSherlock Wrap (global::Android.App.Activity p0)
		{
			if (id_wrap_Landroid_app_Activity_ == IntPtr.Zero)
				id_wrap_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/app/Activity;)Lcom/actionbarsherlock/ActionBarSherlock;");
			global::ActionBar_Sherlock.ActionBarSherlock __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.ActionBarSherlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_app_Activity_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_wrap_Landroid_app_Activity_I;
		[Register ("wrap", "(Landroid/app/Activity;I)Lcom/actionbarsherlock/ActionBarSherlock;", "")]
		public static global::ActionBar_Sherlock.ActionBarSherlock Wrap (global::Android.App.Activity p0, int p1)
		{
			if (id_wrap_Landroid_app_Activity_I == IntPtr.Zero)
				id_wrap_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/app/Activity;I)Lcom/actionbarsherlock/ActionBarSherlock;");
			global::ActionBar_Sherlock.ActionBarSherlock __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.ActionBarSherlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_app_Activity_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock", DoNotGenerateAcw=true)]
	internal partial class ActionBarSherlockInvoker : ActionBarSherlock {

		public ActionBarSherlockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarSherlockInvoker); }
		}

		static IntPtr id_getActionBar;
		public override global::ActionBar_Sherlock.App.ActionBar ActionBar {
			[Register ("getActionBar", "()Lcom/actionbarsherlock/app/ActionBar;", "GetGetActionBarHandler")]
			get {
				if (id_getActionBar == IntPtr.Zero)
					id_getActionBar = JNIEnv.GetMethodID (class_ref, "getActionBar", "()Lcom/actionbarsherlock/app/ActionBar;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar> (JNIEnv.CallObjectMethod  (Handle, id_getActionBar), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getThemedContext;
		protected override global::Android.Content.Context ThemedContext {
			[Register ("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")]
			get {
				if (id_getThemedContext == IntPtr.Zero)
					id_getThemedContext = JNIEnv.GetMethodID (class_ref, "getThemedContext", "()Landroid/content/Context;");
				return Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getThemedContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		[Register ("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public override void AddContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1)
		{
			if (id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_dispatchCreateOptionsMenu_Landroid_view_Menu_;
		[Register ("dispatchCreateOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchCreateOptionsMenu_Landroid_view_Menu_Handler")]
		public override bool DispatchCreateOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_dispatchCreateOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_dispatchCreateOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchCreateOptionsMenu_Landroid_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_dispatchInvalidateOptionsMenu;
		[Register ("dispatchInvalidateOptionsMenu", "()V", "GetDispatchInvalidateOptionsMenuHandler")]
		public override void DispatchInvalidateOptionsMenu ()
		{
			if (id_dispatchInvalidateOptionsMenu == IntPtr.Zero)
				id_dispatchInvalidateOptionsMenu = JNIEnv.GetMethodID (class_ref, "dispatchInvalidateOptionsMenu", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_dispatchInvalidateOptionsMenu);
		}

		static IntPtr id_dispatchOptionsItemSelected_Landroid_view_MenuItem_;
		[Register ("dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetDispatchOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public override bool DispatchOptionsItemSelected (global::Android.Views.IMenuItem p0)
		{
			if (id_dispatchOptionsItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
				id_dispatchOptionsItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchOptionsItemSelected_Landroid_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_dispatchPrepareOptionsMenu_Landroid_view_Menu_;
		[Register ("dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchPrepareOptionsMenu_Landroid_view_Menu_Handler")]
		public override bool DispatchPrepareOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_dispatchPrepareOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_dispatchPrepareOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchPrepareOptionsMenu_Landroid_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hasFeature_I;
		[Register ("hasFeature", "(I)Z", "GetHasFeature_IHandler")]
		public override bool HasFeature (int p0)
		{
			if (id_hasFeature_I == IntPtr.Zero)
				id_hasFeature_I = JNIEnv.GetMethodID (class_ref, "hasFeature", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_hasFeature_I, new JValue (p0));
		}

		static IntPtr id_requestFeature_I;
		[Register ("requestFeature", "(I)Z", "GetRequestFeature_IHandler")]
		public override bool RequestFeature (int p0)
		{
			if (id_requestFeature_I == IntPtr.Zero)
				id_requestFeature_I = JNIEnv.GetMethodID (class_ref, "requestFeature", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_requestFeature_I, new JValue (p0));
		}

		static IntPtr id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		[Register ("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public override void SetContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1)
		{
			if (id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setContentView_I;
		[Register ("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public override void SetContentView (int p0)
		{
			if (id_setContentView_I == IntPtr.Zero)
				id_setContentView_I = JNIEnv.GetMethodID (class_ref, "setContentView", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_I, new JValue (p0));
		}

		static IntPtr id_setProgress_I;
		[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
		public override void SetProgress (int p0)
		{
			if (id_setProgress_I == IntPtr.Zero)
				id_setProgress_I = JNIEnv.GetMethodID (class_ref, "setProgress", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgress_I, new JValue (p0));
		}

		static IntPtr id_setProgressBarIndeterminate_Z;
		[Register ("setProgressBarIndeterminate", "(Z)V", "GetSetProgressBarIndeterminate_ZHandler")]
		public override void SetProgressBarIndeterminate (bool p0)
		{
			if (id_setProgressBarIndeterminate_Z == IntPtr.Zero)
				id_setProgressBarIndeterminate_Z = JNIEnv.GetMethodID (class_ref, "setProgressBarIndeterminate", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgressBarIndeterminate_Z, new JValue (p0));
		}

		static IntPtr id_setProgressBarIndeterminateVisibility_Z;
		[Register ("setProgressBarIndeterminateVisibility", "(Z)V", "GetSetProgressBarIndeterminateVisibility_ZHandler")]
		public override void SetProgressBarIndeterminateVisibility (bool p0)
		{
			if (id_setProgressBarIndeterminateVisibility_Z == IntPtr.Zero)
				id_setProgressBarIndeterminateVisibility_Z = JNIEnv.GetMethodID (class_ref, "setProgressBarIndeterminateVisibility", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgressBarIndeterminateVisibility_Z, new JValue (p0));
		}

		static IntPtr id_setProgressBarVisibility_Z;
		[Register ("setProgressBarVisibility", "(Z)V", "GetSetProgressBarVisibility_ZHandler")]
		public override void SetProgressBarVisibility (bool p0)
		{
			if (id_setProgressBarVisibility_Z == IntPtr.Zero)
				id_setProgressBarVisibility_Z = JNIEnv.GetMethodID (class_ref, "setProgressBarVisibility", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgressBarVisibility_Z, new JValue (p0));
		}

		static IntPtr id_setSecondaryProgress_I;
		[Register ("setSecondaryProgress", "(I)V", "GetSetSecondaryProgress_IHandler")]
		public override void SetSecondaryProgress (int p0)
		{
			if (id_setSecondaryProgress_I == IntPtr.Zero)
				id_setSecondaryProgress_I = JNIEnv.GetMethodID (class_ref, "setSecondaryProgress", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setSecondaryProgress_I, new JValue (p0));
		}

		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public override void SetTitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setUiOptions_I;
		[Register ("setUiOptions", "(I)V", "GetSetUiOptions_IHandler")]
		public override void SetUiOptions (int p0)
		{
			if (id_setUiOptions_I == IntPtr.Zero)
				id_setUiOptions_I = JNIEnv.GetMethodID (class_ref, "setUiOptions", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setUiOptions_I, new JValue (p0));
		}

		static IntPtr id_setUiOptions_II;
		[Register ("setUiOptions", "(II)V", "GetSetUiOptions_IIHandler")]
		public override void SetUiOptions (int p0, int p1)
		{
			if (id_setUiOptions_II == IntPtr.Zero)
				id_setUiOptions_II = JNIEnv.GetMethodID (class_ref, "setUiOptions", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setUiOptions_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
		[Register ("startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;", "GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler")]
		public override global::ActionBar_Sherlock.View.ActionMode StartActionMode (global::ActionBar_Sherlock.View.ActionMode.ICallback p0)
		{
			if (id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ == IntPtr.Zero)
				id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;");
			global::ActionBar_Sherlock.View.ActionMode __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
