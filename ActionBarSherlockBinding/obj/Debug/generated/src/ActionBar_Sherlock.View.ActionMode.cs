using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.View {

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/ActionMode", DoNotGenerateAcw=true)]
	public abstract partial class ActionMode : global::Java.Lang.Object {

		[Register ("com/actionbarsherlock/view/ActionMode$Callback", "", "ActionBar_Sherlock.View.ActionMode/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			[Register ("onActionItemClicked", "(Lcom/actionbarsherlock/view/ActionMode;Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.View.ActionMode/ICallbackInvoker, ActionBarSherlockBinding")]
			bool OnActionItemClicked (global::ActionBar_Sherlock.View.ActionMode p0, global::ActionBar_Sherlock.View.IMenuItem p1);

			[Register ("onCreateActionMode", "(Lcom/actionbarsherlock/view/ActionMode;Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_Handler:ActionBar_Sherlock.View.ActionMode/ICallbackInvoker, ActionBarSherlockBinding")]
			bool OnCreateActionMode (global::ActionBar_Sherlock.View.ActionMode p0, global::ActionBar_Sherlock.View.IMenu p1);

			[Register ("onDestroyActionMode", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_Handler:ActionBar_Sherlock.View.ActionMode/ICallbackInvoker, ActionBarSherlockBinding")]
			void OnDestroyActionMode (global::ActionBar_Sherlock.View.ActionMode p0);

			[Register ("onPrepareActionMode", "(Lcom/actionbarsherlock/view/ActionMode;Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_Handler:ActionBar_Sherlock.View.ActionMode/ICallbackInvoker, ActionBarSherlockBinding")]
			bool OnPrepareActionMode (global::ActionBar_Sherlock.View.ActionMode p0, global::ActionBar_Sherlock.View.IMenu p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/view/ActionMode$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/ActionMode$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.ActionMode.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			static Delegate cb_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_Handler ()
			{
				if (cb_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_ == null)
					cb_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_);
				return cb_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_;
			}

			static bool n_OnActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ICallback __this = Java.Lang.Object.GetObject<ICallback> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.ActionMode p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenuItem p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnActionItemClicked (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_;
			public bool OnActionItemClicked (global::ActionBar_Sherlock.View.ActionMode p0, global::ActionBar_Sherlock.View.IMenuItem p1)
			{
				if (id_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
					id_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onActionItemClicked", "(Lcom/actionbarsherlock/view/ActionMode;Lcom/actionbarsherlock/view/MenuItem;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onActionItemClicked_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
				return __ret;
			}

			static Delegate cb_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_Handler ()
			{
				if (cb_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ == null)
					cb_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_);
				return cb_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_;
			}

			static bool n_OnCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ICallback __this = Java.Lang.Object.GetObject<ICallback> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.ActionMode p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreateActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_;
			public bool OnCreateActionMode (global::ActionBar_Sherlock.View.ActionMode p0, global::ActionBar_Sherlock.View.IMenu p1)
			{
				if (id_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateActionMode", "(Lcom/actionbarsherlock/view/ActionMode;Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onCreateActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
				return __ret;
			}

			static Delegate cb_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetOnDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_Handler ()
			{
				if (cb_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_ == null)
					cb_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_);
				return cb_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_;
			}

			static void n_OnDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ICallback __this = Java.Lang.Object.GetObject<ICallback> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.ActionMode p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyActionMode (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_;
			public void OnDestroyActionMode (global::ActionBar_Sherlock.View.ActionMode p0)
			{
				if (id_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
					id_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onDestroyActionMode", "(Lcom/actionbarsherlock/view/ActionMode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onDestroyActionMode_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			}

			static Delegate cb_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_Handler ()
			{
				if (cb_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ == null)
					cb_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_);
				return cb_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_;
			}

			static bool n_OnPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ICallback __this = Java.Lang.Object.GetObject<ICallback> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.ActionMode p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.View.IMenu p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPrepareActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_;
			public bool OnPrepareActionMode (global::ActionBar_Sherlock.View.ActionMode p0, global::ActionBar_Sherlock.View.IMenu p1)
			{
				if (id_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareActionMode", "(Lcom/actionbarsherlock/view/ActionMode;Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onPrepareActionMode_Lcom_actionbarsherlock_view_ActionMode_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/view/ActionMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionMode); }
		}

		protected ActionMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public ActionMode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActionMode)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCustomView;
#pragma warning disable 0169
		static Delegate GetGetCustomViewHandler ()
		{
			if (cb_getCustomView == null)
				cb_getCustomView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomView);
			return cb_getCustomView;
		}

		static IntPtr n_GetCustomView (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomView);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCustomView_Landroid_view_View_Handler ()
		{
			if (cb_setCustomView_Landroid_view_View_ == null)
				cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_);
			return cb_setCustomView_Landroid_view_View_;
		}

		static void n_SetCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomView = p0;
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View CustomView { [Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get; [Register ("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")] set; }

		static Delegate cb_isUiFocusable;
#pragma warning disable 0169
		static Delegate GetIsUiFocusableHandler ()
		{
			if (cb_isUiFocusable == null)
				cb_isUiFocusable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUiFocusable);
			return cb_isUiFocusable;
		}

		static bool n_IsUiFocusable (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUiFocusable;
		}
#pragma warning restore 0169

		static IntPtr id_isUiFocusable;
		public virtual bool IsUiFocusable {
			[Register ("isUiFocusable", "()Z", "GetIsUiFocusableHandler")]
			get {
				if (id_isUiFocusable == IntPtr.Zero)
					id_isUiFocusable = JNIEnv.GetMethodID (class_ref, "isUiFocusable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isUiFocusable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isUiFocusable);
			}
		}

		static Delegate cb_getMenu;
#pragma warning disable 0169
		static Delegate GetGetMenuHandler ()
		{
			if (cb_getMenu == null)
				cb_getMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMenu);
			return cb_getMenu;
		}

		static IntPtr n_GetMenu (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Menu);
		}
#pragma warning restore 0169

		public abstract global::ActionBar_Sherlock.View.IMenu Menu { [Register ("getMenu", "()Lcom/actionbarsherlock/view/Menu;", "GetGetMenuHandler")] get; }

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
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MenuInflater);
		}
#pragma warning restore 0169

		public abstract global::ActionBar_Sherlock.View.MenuInflater MenuInflater { [Register ("getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetMenuInflaterHandler")] get; }

		static Delegate cb_getSubtitle;
#pragma warning disable 0169
		static Delegate GetGetSubtitleHandler ()
		{
			if (cb_getSubtitle == null)
				cb_getSubtitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubtitle);
			return cb_getSubtitle;
		}

		static IntPtr n_GetSubtitle (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.SubtitleFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setSubtitle_Ljava_lang_CharSequence_ == null)
				cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubtitle_Ljava_lang_CharSequence_);
			return cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		static void n_SetSubtitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubtitleFormatted = p0;
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.ICharSequence SubtitleFormatted { [Register ("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")] get; [Register ("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")] set; }

		public string Subtitle {
			get { return SubtitleFormatted == null ? null : SubtitleFormatted.ToString (); }
			set {
				Java.Lang.String jls = value == null ? null : new Java.Lang.String (value);
				SubtitleFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag);
		}
#pragma warning restore 0169

		static Delegate cb_setTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_Object_Handler ()
		{
			if (cb_setTag_Ljava_lang_Object_ == null)
				cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_Object_);
			return cb_setTag_Ljava_lang_Object_;
		}

		static void n_SetTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		static IntPtr id_setTag_Ljava_lang_Object_;
		public virtual global::Java.Lang.Object Tag {
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTag), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setTag", "(Ljava/lang/Object;)V", "GetSetTag_Ljava_lang_Object_Handler")]
			set {
				if (id_setTag_Ljava_lang_Object_ == IntPtr.Zero)
					id_setTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/Object;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTag_Ljava_lang_Object_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTag_Ljava_lang_Object_, new JValue (value));
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

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
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TitleFormatted = p0;
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.ICharSequence TitleFormatted { [Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")] get; [Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")] set; }

		public string Title {
			get { return TitleFormatted == null ? null : TitleFormatted.ToString (); }
			set {
				Java.Lang.String jls = value == null ? null : new Java.Lang.String (value);
				TitleFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		[Register ("finish", "()V", "GetFinishHandler")]
		public abstract void Finish ();

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public abstract void Invalidate ();

		static Delegate cb_setSubtitle_I;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_IHandler ()
		{
			if (cb_setSubtitle_I == null)
				cb_setSubtitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSubtitle_I);
			return cb_setSubtitle_I;
		}

		static void n_SetSubtitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSubtitle (p0);
		}
#pragma warning restore 0169

		[Register ("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public abstract void SetSubtitle (int p0);

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
			ActionMode __this = Java.Lang.Object.GetObject<ActionMode> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public abstract void SetTitle (int p0);

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/ActionMode", DoNotGenerateAcw=true)]
	internal partial class ActionModeInvoker : ActionMode {

		public ActionModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionModeInvoker); }
		}

		static IntPtr id_getCustomView;
		static IntPtr id_setCustomView_Landroid_view_View_;
		public override global::Android.Views.View CustomView {
			[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
			get {
				if (id_getCustomView == IntPtr.Zero)
					id_getCustomView = JNIEnv.GetMethodID (class_ref, "getCustomView", "()Landroid/view/View;");
				return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getCustomView), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")]
			set {
				if (id_setCustomView_Landroid_view_View_ == IntPtr.Zero)
					id_setCustomView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCustomView_Landroid_view_View_, new JValue (value));
			}
		}

		static IntPtr id_getMenu;
		public override global::ActionBar_Sherlock.View.IMenu Menu {
			[Register ("getMenu", "()Lcom/actionbarsherlock/view/Menu;", "GetGetMenuHandler")]
			get {
				if (id_getMenu == IntPtr.Zero)
					id_getMenu = JNIEnv.GetMethodID (class_ref, "getMenu", "()Lcom/actionbarsherlock/view/Menu;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenu> (JNIEnv.CallObjectMethod  (Handle, id_getMenu), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMenuInflater;
		public override global::ActionBar_Sherlock.View.MenuInflater MenuInflater {
			[Register ("getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetMenuInflaterHandler")]
			get {
				if (id_getMenuInflater == IntPtr.Zero)
					id_getMenuInflater = JNIEnv.GetMethodID (class_ref, "getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getMenuInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSubtitle;
		static IntPtr id_setSubtitle_Ljava_lang_CharSequence_;
		public override global::Java.Lang.ICharSequence SubtitleFormatted {
			[Register ("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")]
			get {
				if (id_getSubtitle == IntPtr.Zero)
					id_getSubtitle = JNIEnv.GetMethodID (class_ref, "getSubtitle", "()Ljava/lang/CharSequence;");
				return Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getSubtitle), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setSubtitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setSubtitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_Ljava_lang_CharSequence_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		public override global::Java.Lang.ICharSequence TitleFormatted {
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				return Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_finish;
		[Register ("finish", "()V", "GetFinishHandler")]
		public override void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_finish);
		}

		static IntPtr id_invalidate;
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public override void Invalidate ()
		{
			if (id_invalidate == IntPtr.Zero)
				id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_invalidate);
		}

		static IntPtr id_setSubtitle_I;
		[Register ("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public override void SetSubtitle (int p0)
		{
			if (id_setSubtitle_I == IntPtr.Zero)
				id_setSubtitle_I = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_I, new JValue (p0));
		}

		static IntPtr id_setTitle_I;
		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public override void SetTitle (int p0)
		{
			if (id_setTitle_I == IntPtr.Zero)
				id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setTitle_I, new JValue (p0));
		}

	}

}
