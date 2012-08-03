using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.View {

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/Window", DoNotGenerateAcw=true)]
	public abstract partial class Window : global::Android.Views.Window {


		[Register ("FEATURE_ACTION_BAR")]
		public const long FeatureActionBar = (long) 8L;

		[Register ("FEATURE_ACTION_BAR_OVERLAY")]
		public const long FeatureActionBarOverlay = (long) 9L;

		[Register ("FEATURE_ACTION_MODE_OVERLAY")]
		public const long FeatureActionModeOverlay = (long) 10L;

		[Register ("FEATURE_INDETERMINATE_PROGRESS")]
		public const long FeatureIndeterminateProgress = (long) 5L;

		[Register ("FEATURE_NO_TITLE")]
		public const long FeatureNoTitle = (long) 1L;

		[Register ("FEATURE_PROGRESS")]
		public const long FeatureProgress = (long) 2L;
		[Register ("com/actionbarsherlock/view/Window$Callback", "", "ActionBar_Sherlock.View.Window/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			[Register ("onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.View.Window/ICallbackInvoker, ActionBarSherlockBinding")]
			bool OnMenuItemSelected (int p0, global::ActionBar_Sherlock.View.IMenuItem p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/view/Window$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/Window$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.Window.Callback"));
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
				ICallback __this = Java.Lang.Object.GetObject<ICallback> (native__this, JniHandleOwnership.DoNotTransfer);
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


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/view/Window", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Window); }
		}

		protected Window (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/Window", DoNotGenerateAcw=true)]
	internal partial class WindowInvoker : Window {

		public WindowInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WindowInvoker); }
		}

		static IntPtr id_getCurrentFocus;
		public override global::Android.Views.View CurrentFocus {
			[Register ("getCurrentFocus", "()Landroid/view/View;", "GetGetCurrentFocusHandler")]
			get {
				if (id_getCurrentFocus == IntPtr.Zero)
					id_getCurrentFocus = JNIEnv.GetMethodID (class_ref, "getCurrentFocus", "()Landroid/view/View;");
				return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentFocus), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDecorView;
		public override global::Android.Views.View DecorView {
			[Register ("getDecorView", "()Landroid/view/View;", "GetGetDecorViewHandler")]
			get {
				if (id_getDecorView == IntPtr.Zero)
					id_getDecorView = JNIEnv.GetMethodID (class_ref, "getDecorView", "()Landroid/view/View;");
				return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getDecorView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isFloating;
		public override global::System.Boolean IsFloating {
			[Register ("isFloating", "()Z", "GetGetIsFloatingHandler")]
			get {
				if (id_isFloating == IntPtr.Zero)
					id_isFloating = JNIEnv.GetMethodID (class_ref, "isFloating", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isFloating);
			}
		}

		static IntPtr id_getLayoutInflater;
		public override global::Android.Views.LayoutInflater LayoutInflater {
			[Register ("getLayoutInflater", "()Landroid/view/LayoutInflater;", "GetGetLayoutInflaterHandler")]
			get {
				if (id_getLayoutInflater == IntPtr.Zero)
					id_getLayoutInflater = JNIEnv.GetMethodID (class_ref, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
				return Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (JNIEnv.CallObjectMethod  (Handle, id_getLayoutInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getVolumeControlStream;
		static IntPtr id_setVolumeControlStream_I;
		public override global::Android.Media.Stream VolumeControlStream {
			[Register ("getVolumeControlStream", "()I", "GetGetVolumeControlStreamHandler")]
			get {
				if (id_getVolumeControlStream == IntPtr.Zero)
					id_getVolumeControlStream = JNIEnv.GetMethodID (class_ref, "getVolumeControlStream", "()I");
				return (global::Android.Media.Stream) JNIEnv.CallIntMethod  (Handle, id_getVolumeControlStream);
			}
			[Register ("setVolumeControlStream", "(I)V", "GetSetVolumeControlStream_IHandler")]
			set {
				if (id_setVolumeControlStream_I == IntPtr.Zero)
					id_setVolumeControlStream_I = JNIEnv.GetMethodID (class_ref, "setVolumeControlStream", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVolumeControlStream_I, new JValue ((int) value));
			}
		}

		static IntPtr id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		[Register ("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public override void AddContentView (global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params)
		{
			if (id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (view), new JValue (@params));
		}

		static IntPtr id_closeAllPanels;
		[Register ("closeAllPanels", "()V", "GetCloseAllPanelsHandler")]
		public override void CloseAllPanels ()
		{
			if (id_closeAllPanels == IntPtr.Zero)
				id_closeAllPanels = JNIEnv.GetMethodID (class_ref, "closeAllPanels", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_closeAllPanels);
		}

		static IntPtr id_closePanel_I;
		[Register ("closePanel", "(I)V", "GetClosePanel_IHandler")]
		public override void ClosePanel (int featureId)
		{
			if (id_closePanel_I == IntPtr.Zero)
				id_closePanel_I = JNIEnv.GetMethodID (class_ref, "closePanel", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_closePanel_I, new JValue (featureId));
		}

		static IntPtr id_invalidatePanelMenu_I;
		[Register ("invalidatePanelMenu", "(I)V", "GetInvalidatePanelMenu_IHandler")]
		public override void InvalidatePanelMenu ([global::Android.Runtime.GeneratedEnum] global::Android.Views.WindowFeatures featureId)
		{
			if (id_invalidatePanelMenu_I == IntPtr.Zero)
				id_invalidatePanelMenu_I = JNIEnv.GetMethodID (class_ref, "invalidatePanelMenu", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_invalidatePanelMenu_I, new JValue ((int) featureId));
		}

		static IntPtr id_isShortcutKey_ILandroid_view_KeyEvent_;
		[Register ("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", "GetIsShortcutKey_ILandroid_view_KeyEvent_Handler")]
		public override global::System.Boolean IsShortcutKey ([global::Android.Runtime.GeneratedEnum] global::Android.Views.Keycode keyCode, global::Android.Views.KeyEvent e)
		{
			if (id_isShortcutKey_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_isShortcutKey_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_isShortcutKey_ILandroid_view_KeyEvent_, new JValue ((int) keyCode), new JValue (e));
			return __ret;
		}

		static IntPtr id_onActive;
		[Register ("onActive", "()V", "GetOnActiveHandler")]
		protected override void OnActive ()
		{
			if (id_onActive == IntPtr.Zero)
				id_onActive = JNIEnv.GetMethodID (class_ref, "onActive", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onActive);
		}

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public override void OnConfigurationChanged (global::Android.Content.Res.Configuration newConfig)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, new JValue (newConfig));
		}

		static IntPtr id_openPanel_ILandroid_view_KeyEvent_;
		[Register ("openPanel", "(ILandroid/view/KeyEvent;)V", "GetOpenPanel_ILandroid_view_KeyEvent_Handler")]
		public override void OpenPanel (int featureId, global::Android.Views.KeyEvent e)
		{
			if (id_openPanel_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_openPanel_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "openPanel", "(ILandroid/view/KeyEvent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_openPanel_ILandroid_view_KeyEvent_, new JValue (featureId), new JValue (e));
		}

		static IntPtr id_peekDecorView;
		[Register ("peekDecorView", "()Landroid/view/View;", "GetPeekDecorViewHandler")]
		public override global::Android.Views.View PeekDecorView ()
		{
			if (id_peekDecorView == IntPtr.Zero)
				id_peekDecorView = JNIEnv.GetMethodID (class_ref, "peekDecorView", "()Landroid/view/View;");
			return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_peekDecorView), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_performContextMenuIdentifierAction_II;
		[Register ("performContextMenuIdentifierAction", "(II)Z", "GetPerformContextMenuIdentifierAction_IIHandler")]
		public override global::System.Boolean PerformContextMenuIdentifierAction (int id, [global::Android.Runtime.GeneratedEnum] global::Android.Views.MenuPerformFlags flags)
		{
			if (id_performContextMenuIdentifierAction_II == IntPtr.Zero)
				id_performContextMenuIdentifierAction_II = JNIEnv.GetMethodID (class_ref, "performContextMenuIdentifierAction", "(II)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_performContextMenuIdentifierAction_II, new JValue (id), new JValue ((int) flags));
		}

		static IntPtr id_performPanelIdentifierAction_III;
		[Register ("performPanelIdentifierAction", "(III)Z", "GetPerformPanelIdentifierAction_IIIHandler")]
		public override global::System.Boolean PerformPanelIdentifierAction (int featureId, int id, [global::Android.Runtime.GeneratedEnum] global::Android.Views.MenuPerformFlags flags)
		{
			if (id_performPanelIdentifierAction_III == IntPtr.Zero)
				id_performPanelIdentifierAction_III = JNIEnv.GetMethodID (class_ref, "performPanelIdentifierAction", "(III)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_performPanelIdentifierAction_III, new JValue (featureId), new JValue (id), new JValue ((int) flags));
		}

		static IntPtr id_performPanelShortcut_IILandroid_view_KeyEvent_I;
		[Register ("performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z", "GetPerformPanelShortcut_IILandroid_view_KeyEvent_IHandler")]
		public override global::System.Boolean PerformPanelShortcut (int featureId, [global::Android.Runtime.GeneratedEnum] global::Android.Views.Keycode keyCode, global::Android.Views.KeyEvent e, [global::Android.Runtime.GeneratedEnum] global::Android.Views.MenuPerformFlags flags)
		{
			if (id_performPanelShortcut_IILandroid_view_KeyEvent_I == IntPtr.Zero)
				id_performPanelShortcut_IILandroid_view_KeyEvent_I = JNIEnv.GetMethodID (class_ref, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_performPanelShortcut_IILandroid_view_KeyEvent_I, new JValue (featureId), new JValue ((int) keyCode), new JValue (e), new JValue ((int) flags));
			return __ret;
		}

		static IntPtr id_restoreHierarchyState_Landroid_os_Bundle_;
		[Register ("restoreHierarchyState", "(Landroid/os/Bundle;)V", "GetRestoreHierarchyState_Landroid_os_Bundle_Handler")]
		public override void RestoreHierarchyState (global::Android.OS.Bundle savedInstanceState)
		{
			if (id_restoreHierarchyState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_restoreHierarchyState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod  (Handle, id_restoreHierarchyState_Landroid_os_Bundle_, new JValue (savedInstanceState));
		}

		static IntPtr id_saveHierarchyState;
		[Register ("saveHierarchyState", "()Landroid/os/Bundle;", "GetSaveHierarchyStateHandler")]
		public override global::Android.OS.Bundle SaveHierarchyState ()
		{
			if (id_saveHierarchyState == IntPtr.Zero)
				id_saveHierarchyState = JNIEnv.GetMethodID (class_ref, "saveHierarchyState", "()Landroid/os/Bundle;");
			return Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_saveHierarchyState), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public override void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			if (id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (drawable));
		}

		static IntPtr id_setChildDrawable_ILandroid_graphics_drawable_Drawable_;
		[Register ("setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V", "GetSetChildDrawable_ILandroid_graphics_drawable_Drawable_Handler")]
		public override void SetChildDrawable (int featureId, global::Android.Graphics.Drawables.Drawable drawable)
		{
			if (id_setChildDrawable_ILandroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setChildDrawable_ILandroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setChildDrawable_ILandroid_graphics_drawable_Drawable_, new JValue (featureId), new JValue (drawable));
		}

		static IntPtr id_setChildInt_II;
		[Register ("setChildInt", "(II)V", "GetSetChildInt_IIHandler")]
		public override void SetChildInt (int featureId, int value)
		{
			if (id_setChildInt_II == IntPtr.Zero)
				id_setChildInt_II = JNIEnv.GetMethodID (class_ref, "setChildInt", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setChildInt_II, new JValue (featureId), new JValue (value));
		}

		static IntPtr id_setContentView_Landroid_view_View_;
		[Register ("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
		public override void SetContentView (global::Android.Views.View view)
		{
			if (id_setContentView_Landroid_view_View_ == IntPtr.Zero)
				id_setContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setContentView", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_Landroid_view_View_, new JValue (view));
		}

		static IntPtr id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		[Register ("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public override void SetContentView (global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params)
		{
			if (id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (view), new JValue (@params));
		}

		static IntPtr id_setContentView_I;
		[Register ("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public override void SetContentView (int layoutResID)
		{
			if (id_setContentView_I == IntPtr.Zero)
				id_setContentView_I = JNIEnv.GetMethodID (class_ref, "setContentView", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_I, new JValue (layoutResID));
		}

		static IntPtr id_setFeatureDrawable_ILandroid_graphics_drawable_Drawable_;
		[Register ("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", "GetSetFeatureDrawable_ILandroid_graphics_drawable_Drawable_Handler")]
		public override void SetFeatureDrawable ([global::Android.Runtime.GeneratedEnum] global::Android.Views.WindowFeatures featureId, global::Android.Graphics.Drawables.Drawable drawable)
		{
			if (id_setFeatureDrawable_ILandroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setFeatureDrawable_ILandroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setFeatureDrawable_ILandroid_graphics_drawable_Drawable_, new JValue ((int) featureId), new JValue (drawable));
		}

		static IntPtr id_setFeatureDrawableAlpha_II;
		[Register ("setFeatureDrawableAlpha", "(II)V", "GetSetFeatureDrawableAlpha_IIHandler")]
		public override void SetFeatureDrawableAlpha ([global::Android.Runtime.GeneratedEnum] global::Android.Views.WindowFeatures featureId, int alpha)
		{
			if (id_setFeatureDrawableAlpha_II == IntPtr.Zero)
				id_setFeatureDrawableAlpha_II = JNIEnv.GetMethodID (class_ref, "setFeatureDrawableAlpha", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setFeatureDrawableAlpha_II, new JValue ((int) featureId), new JValue (alpha));
		}

		static IntPtr id_setFeatureDrawableResource_II;
		[Register ("setFeatureDrawableResource", "(II)V", "GetSetFeatureDrawableResource_IIHandler")]
		public override void SetFeatureDrawableResource ([global::Android.Runtime.GeneratedEnum] global::Android.Views.WindowFeatures featureId, int resId)
		{
			if (id_setFeatureDrawableResource_II == IntPtr.Zero)
				id_setFeatureDrawableResource_II = JNIEnv.GetMethodID (class_ref, "setFeatureDrawableResource", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setFeatureDrawableResource_II, new JValue ((int) featureId), new JValue (resId));
		}

		static IntPtr id_setFeatureDrawableUri_ILandroid_net_Uri_;
		[Register ("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", "GetSetFeatureDrawableUri_ILandroid_net_Uri_Handler")]
		public override void SetFeatureDrawableUri ([global::Android.Runtime.GeneratedEnum] global::Android.Views.WindowFeatures featureId, global::Android.Net.Uri uri)
		{
			if (id_setFeatureDrawableUri_ILandroid_net_Uri_ == IntPtr.Zero)
				id_setFeatureDrawableUri_ILandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setFeatureDrawableUri_ILandroid_net_Uri_, new JValue ((int) featureId), new JValue (uri));
		}

		static IntPtr id_setFeatureInt_II;
		[Register ("setFeatureInt", "(II)V", "GetSetFeatureInt_IIHandler")]
		public override void SetFeatureInt ([global::Android.Runtime.GeneratedEnum] global::Android.Views.WindowFeatures featureId, int value)
		{
			if (id_setFeatureInt_II == IntPtr.Zero)
				id_setFeatureInt_II = JNIEnv.GetMethodID (class_ref, "setFeatureInt", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setFeatureInt_II, new JValue ((int) featureId), new JValue (value));
		}

		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public override void SetTitle (global::Java.Lang.ICharSequence title)
		{
			if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, new JValue (title));
		}

		static IntPtr id_setTitleColor_I;
		[Register ("setTitleColor", "(I)V", "GetSetTitleColor_IHandler")]
		public override void SetTitleColor (global::Android.Graphics.Color textColor)
		{
			if (id_setTitleColor_I == IntPtr.Zero)
				id_setTitleColor_I = JNIEnv.GetMethodID (class_ref, "setTitleColor", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setTitleColor_I, new JValue (textColor.ToArgb ()));
		}

		static IntPtr id_superDispatchGenericMotionEvent_Landroid_view_MotionEvent_;
		[Register ("superDispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", "GetSuperDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler")]
		public override global::System.Boolean SuperDispatchGenericMotionEvent (global::Android.Views.MotionEvent e)
		{
			if (id_superDispatchGenericMotionEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_superDispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "superDispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_superDispatchGenericMotionEvent_Landroid_view_MotionEvent_, new JValue (e));
			return __ret;
		}

		static IntPtr id_superDispatchKeyEvent_Landroid_view_KeyEvent_;
		[Register ("superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetSuperDispatchKeyEvent_Landroid_view_KeyEvent_Handler")]
		public override global::System.Boolean SuperDispatchKeyEvent (global::Android.Views.KeyEvent e)
		{
			if (id_superDispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_superDispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_superDispatchKeyEvent_Landroid_view_KeyEvent_, new JValue (e));
			return __ret;
		}

		static IntPtr id_superDispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
		[Register ("superDispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", "GetSuperDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler")]
		public override global::System.Boolean SuperDispatchKeyShortcutEvent (global::Android.Views.KeyEvent e)
		{
			if (id_superDispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_superDispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "superDispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_superDispatchKeyShortcutEvent_Landroid_view_KeyEvent_, new JValue (e));
			return __ret;
		}

		static IntPtr id_superDispatchTouchEvent_Landroid_view_MotionEvent_;
		[Register ("superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetSuperDispatchTouchEvent_Landroid_view_MotionEvent_Handler")]
		public override global::System.Boolean SuperDispatchTouchEvent (global::Android.Views.MotionEvent e)
		{
			if (id_superDispatchTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_superDispatchTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_superDispatchTouchEvent_Landroid_view_MotionEvent_, new JValue (e));
			return __ret;
		}

		static IntPtr id_superDispatchTrackballEvent_Landroid_view_MotionEvent_;
		[Register ("superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", "GetSuperDispatchTrackballEvent_Landroid_view_MotionEvent_Handler")]
		public override global::System.Boolean SuperDispatchTrackballEvent (global::Android.Views.MotionEvent e)
		{
			if (id_superDispatchTrackballEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_superDispatchTrackballEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod  (Handle, id_superDispatchTrackballEvent_Landroid_view_MotionEvent_, new JValue (e));
			return __ret;
		}

		static IntPtr id_takeInputQueue_Landroid_view_InputQueue_Callback_;
		[Register ("takeInputQueue", "(Landroid/view/InputQueue$Callback;)V", "GetTakeInputQueue_Landroid_view_InputQueue_Callback_Handler")]
		public override void TakeInputQueue (global::Android.Views.InputQueue.ICallback @callback)
		{
			if (id_takeInputQueue_Landroid_view_InputQueue_Callback_ == IntPtr.Zero)
				id_takeInputQueue_Landroid_view_InputQueue_Callback_ = JNIEnv.GetMethodID (class_ref, "takeInputQueue", "(Landroid/view/InputQueue$Callback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_takeInputQueue_Landroid_view_InputQueue_Callback_, new JValue (@callback));
		}

		static IntPtr id_takeKeyEvents_Z;
		[Register ("takeKeyEvents", "(Z)V", "GetTakeKeyEvents_ZHandler")]
		public override void TakeKeyEvents (bool get)
		{
			if (id_takeKeyEvents_Z == IntPtr.Zero)
				id_takeKeyEvents_Z = JNIEnv.GetMethodID (class_ref, "takeKeyEvents", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_takeKeyEvents_Z, new JValue (get));
		}

		static IntPtr id_takeSurface_Landroid_view_SurfaceHolder_Callback2_;
		[Register ("takeSurface", "(Landroid/view/SurfaceHolder$Callback2;)V", "GetTakeSurface_Landroid_view_SurfaceHolder_Callback2_Handler")]
		public override void TakeSurface (global::Android.Views.ISurfaceHolderCallback2 @callback)
		{
			if (id_takeSurface_Landroid_view_SurfaceHolder_Callback2_ == IntPtr.Zero)
				id_takeSurface_Landroid_view_SurfaceHolder_Callback2_ = JNIEnv.GetMethodID (class_ref, "takeSurface", "(Landroid/view/SurfaceHolder$Callback2;)V");
			JNIEnv.CallVoidMethod  (Handle, id_takeSurface_Landroid_view_SurfaceHolder_Callback2_, new JValue (@callback));
		}

		static IntPtr id_togglePanel_ILandroid_view_KeyEvent_;
		[Register ("togglePanel", "(ILandroid/view/KeyEvent;)V", "GetTogglePanel_ILandroid_view_KeyEvent_Handler")]
		public override void TogglePanel (int featureId, global::Android.Views.KeyEvent e)
		{
			if (id_togglePanel_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_togglePanel_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_togglePanel_ILandroid_view_KeyEvent_, new JValue (featureId), new JValue (e));
		}

	}

}
