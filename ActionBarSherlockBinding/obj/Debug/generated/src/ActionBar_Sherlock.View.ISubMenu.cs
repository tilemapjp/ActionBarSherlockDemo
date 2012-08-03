using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.View {

	[Register ("com/actionbarsherlock/view/SubMenu", "", "ActionBar_Sherlock.View.ISubMenuInvoker")]
	public partial interface ISubMenu : global::ActionBar_Sherlock.View.IMenu {

		global::ActionBar_Sherlock.View.IMenuItem Item {
			[Register ("getItem", "()Lcom/actionbarsherlock/view/MenuItem;", "GetGetItemHandler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")] get;
		}

		[Register ("clearHeader", "()V", "GetClearHeaderHandler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		void ClearHeader ();

		[Register ("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/view/SubMenu;", "GetSetHeaderIcon_Landroid_graphics_drawable_Drawable_Handler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetHeaderIcon (global::Android.Graphics.Drawables.Drawable p0);

		[Register ("setHeaderIcon", "(I)Lcom/actionbarsherlock/view/SubMenu;", "GetSetHeaderIcon_IHandler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetHeaderIcon (int p0);

		[Register ("setHeaderTitle", "(I)Lcom/actionbarsherlock/view/SubMenu;", "GetSetHeaderTitle_IHandler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetHeaderTitle (int p0);

		[Register ("setHeaderTitle", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/SubMenu;", "GetSetHeaderTitle_Ljava_lang_CharSequence_Handler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetHeaderTitle (global::Java.Lang.ICharSequence p0);

		[Register ("setHeaderView", "(Landroid/view/View;)Lcom/actionbarsherlock/view/SubMenu;", "GetSetHeaderView_Landroid_view_View_Handler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetHeaderView (global::Android.Views.View p0);

		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/view/SubMenu;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetIcon (global::Android.Graphics.Drawables.Drawable p0);

		[Register ("setIcon", "(I)Lcom/actionbarsherlock/view/SubMenu;", "GetSetIcon_IHandler:ActionBar_Sherlock.View.ISubMenuInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.ISubMenu SetIcon (int p0);

	}

	public static partial class ISubMenuExtensions {

		public static global::ActionBar_Sherlock.View.ISubMenu SetHeaderTitle (this ActionBar_Sherlock.View.ISubMenu self, string p0)
		{
			Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
			global::ActionBar_Sherlock.View.ISubMenu __result = self.SetHeaderTitle (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}
	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/SubMenu", DoNotGenerateAcw=true)]
	internal class ISubMenuInvoker : Java.Lang.Object, ISubMenu {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/SubMenu");
		IntPtr class_ref;

		public static ISubMenu GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISubMenu> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.SubMenu"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubMenuInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISubMenuInvoker); }
		}

		static Delegate cb_getItem;
#pragma warning disable 0169
		static Delegate GetGetItemHandler ()
		{
			if (cb_getItem == null)
				cb_getItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItem);
			return cb_getItem;
		}

		static IntPtr n_GetItem (IntPtr jnienv, IntPtr native__this)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Item);
		}
#pragma warning restore 0169

		IntPtr id_getItem;
		public global::ActionBar_Sherlock.View.IMenuItem Item {
			get {
				if (id_getItem == IntPtr.Zero)
					id_getItem = JNIEnv.GetMethodID (class_ref, "getItem", "()Lcom/actionbarsherlock/view/MenuItem;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_getItem), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clearHeader;
#pragma warning disable 0169
		static Delegate GetClearHeaderHandler ()
		{
			if (cb_clearHeader == null)
				cb_clearHeader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearHeader);
			return cb_clearHeader;
		}

		static void n_ClearHeader (IntPtr jnienv, IntPtr native__this)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearHeader ();
		}
#pragma warning restore 0169

		IntPtr id_clearHeader;
		public void ClearHeader ()
		{
			if (id_clearHeader == IntPtr.Zero)
				id_clearHeader = JNIEnv.GetMethodID (class_ref, "clearHeader", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clearHeader);
		}

		static Delegate cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetHeaderIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHeaderIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setHeaderIcon_Landroid_graphics_drawable_Drawable_;
		public global::ActionBar_Sherlock.View.ISubMenu SetHeaderIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/view/SubMenu;");
			global::ActionBar_Sherlock.View.ISubMenu __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setHeaderIcon_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setHeaderIcon_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderIcon_IHandler ()
		{
			if (cb_setHeaderIcon_I == null)
				cb_setHeaderIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderIcon_I);
			return cb_setHeaderIcon_I;
		}

		static IntPtr n_SetHeaderIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderIcon (p0));
		}
#pragma warning restore 0169

		IntPtr id_setHeaderIcon_I;
		public global::ActionBar_Sherlock.View.ISubMenu SetHeaderIcon (int p0)
		{
			if (id_setHeaderIcon_I == IntPtr.Zero)
				id_setHeaderIcon_I = JNIEnv.GetMethodID (class_ref, "setHeaderIcon", "(I)Lcom/actionbarsherlock/view/SubMenu;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setHeaderIcon_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setHeaderTitle_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderTitle_IHandler ()
		{
			if (cb_setHeaderTitle_I == null)
				cb_setHeaderTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderTitle_I);
			return cb_setHeaderTitle_I;
		}

		static IntPtr n_SetHeaderTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderTitle (p0));
		}
#pragma warning restore 0169

		IntPtr id_setHeaderTitle_I;
		public global::ActionBar_Sherlock.View.ISubMenu SetHeaderTitle (int p0)
		{
			if (id_setHeaderTitle_I == IntPtr.Zero)
				id_setHeaderTitle_I = JNIEnv.GetMethodID (class_ref, "setHeaderTitle", "(I)Lcom/actionbarsherlock/view/SubMenu;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setHeaderTitle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setHeaderTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetHeaderTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setHeaderTitle_Ljava_lang_CharSequence_ == null)
				cb_setHeaderTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeaderTitle_Ljava_lang_CharSequence_);
			return cb_setHeaderTitle_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetHeaderTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHeaderTitle (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setHeaderTitle_Ljava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.ISubMenu SetHeaderTitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setHeaderTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setHeaderTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setHeaderTitle", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/SubMenu;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			global::ActionBar_Sherlock.View.ISubMenu __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setHeaderTitle_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setHeaderView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetHeaderView_Landroid_view_View_Handler ()
		{
			if (cb_setHeaderView_Landroid_view_View_ == null)
				cb_setHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeaderView_Landroid_view_View_);
			return cb_setHeaderView_Landroid_view_View_;
		}

		static IntPtr n_SetHeaderView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHeaderView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setHeaderView_Landroid_view_View_;
		public global::ActionBar_Sherlock.View.ISubMenu SetHeaderView (global::Android.Views.View p0)
		{
			if (id_setHeaderView_Landroid_view_View_ == IntPtr.Zero)
				id_setHeaderView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setHeaderView", "(Landroid/view/View;)Lcom/actionbarsherlock/view/SubMenu;");
			global::ActionBar_Sherlock.View.ISubMenu __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setHeaderView_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		public global::ActionBar_Sherlock.View.ISubMenu SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/view/SubMenu;");
			global::ActionBar_Sherlock.View.ISubMenu __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static IntPtr n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
		}
#pragma warning restore 0169

		IntPtr id_setIcon_I;
		public global::ActionBar_Sherlock.View.ISubMenu SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)Lcom/actionbarsherlock/view/SubMenu;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_setIcon_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_hasVisibleItems;
#pragma warning disable 0169
		static Delegate GetHasVisibleItemsHandler ()
		{
			if (cb_hasVisibleItems == null)
				cb_hasVisibleItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasVisibleItems);
			return cb_hasVisibleItems;
		}

		static bool n_HasVisibleItems (IntPtr jnienv, IntPtr native__this)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasVisibleItems;
		}
#pragma warning restore 0169

		IntPtr id_hasVisibleItems;
		public bool HasVisibleItems {
			get {
				if (id_hasVisibleItems == IntPtr.Zero)
					id_hasVisibleItems = JNIEnv.GetMethodID (class_ref, "hasVisibleItems", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasVisibleItems);
			}
		}

		static Delegate cb_add_I;
#pragma warning disable 0169
		static Delegate GetAdd_IHandler ()
		{
			if (cb_add_I == null)
				cb_add_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Add_I);
			return cb_add_I;
		}

		static IntPtr n_Add_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Add (p0));
		}
#pragma warning restore 0169

		IntPtr id_add_I;
		public global::ActionBar_Sherlock.View.IMenuItem Add (int p0)
		{
			if (id_add_I == IntPtr.Zero)
				id_add_I = JNIEnv.GetMethodID (class_ref, "add", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_add_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_add_IIII;
#pragma warning disable 0169
		static Delegate GetAdd_IIIIHandler ()
		{
			if (cb_add_IIII == null)
				cb_add_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Add_IIII);
			return cb_add_IIII;
		}

		static IntPtr n_Add_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Add (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		IntPtr id_add_IIII;
		public global::ActionBar_Sherlock.View.IMenuItem Add (int p0, int p1, int p2, int p3)
		{
			if (id_add_IIII == IntPtr.Zero)
				id_add_IIII = JNIEnv.GetMethodID (class_ref, "add", "(IIII)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_add_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_add_IIILjava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetAdd_IIILjava_lang_CharSequence_Handler ()
		{
			if (cb_add_IIILjava_lang_CharSequence_ == null)
				cb_add_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr>) n_Add_IIILjava_lang_CharSequence_);
			return cb_add_IIILjava_lang_CharSequence_;
		}

		static IntPtr n_Add_IIILjava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p3 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_IIILjava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.IMenuItem Add (int p0, int p1, int p2, global::Java.Lang.ICharSequence p3)
		{
			if (id_add_IIILjava_lang_CharSequence_ == IntPtr.Zero)
				id_add_IIILjava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "add", "(IIILjava/lang/CharSequence;)Lcom/actionbarsherlock/view/MenuItem;");
			IntPtr native_p3 = CharSequence.ToLocalJniHandle (p3);
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_add_IIILjava_lang_CharSequence_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_add_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_add_Ljava_lang_CharSequence_ == null)
				cb_add_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_CharSequence_);
			return cb_add_Ljava_lang_CharSequence_;
		}

		static IntPtr n_Add_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_Ljava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.IMenuItem Add (global::Java.Lang.ICharSequence p0)
		{
			if (id_add_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_add_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/MenuItem;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_add_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetAddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_ == null)
				cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_);
			return cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_;
		}

		static int n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6, IntPtr native_p7)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName p3 = Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p3, JniHandleOwnership.DoNotTransfer);
			Android.Content.Intent[] p4 = (Android.Content.Intent[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (Android.Content.Intent));
			global::Android.Content.Intent p5 = Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p5, JniHandleOwnership.DoNotTransfer);
			ActionBar_Sherlock.View.IMenuItem[] p7 = (ActionBar_Sherlock.View.IMenuItem[]) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (ActionBar_Sherlock.View.IMenuItem));
			int __ret = __this.AddIntentOptions (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_;
		public int AddIntentOptions (int p0, int p1, int p2, global::Android.Content.ComponentName p3, global::Android.Content.Intent[] p4, global::Android.Content.Intent p5, int p6, global::ActionBar_Sherlock.View.IMenuItem[] p7)
		{
			if (id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Lcom/actionbarsherlock/view/MenuItem;)I");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			int __ret = JNIEnv.CallIntMethod (Handle, id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4), new JValue (p5), new JValue (p6), new JValue (native_p7));
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
			return __ret;
		}

		static Delegate cb_addSubMenu_I;
#pragma warning disable 0169
		static Delegate GetAddSubMenu_IHandler ()
		{
			if (cb_addSubMenu_I == null)
				cb_addSubMenu_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddSubMenu_I);
			return cb_addSubMenu_I;
		}

		static IntPtr n_AddSubMenu_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddSubMenu (p0));
		}
#pragma warning restore 0169

		IntPtr id_addSubMenu_I;
		public global::ActionBar_Sherlock.View.ISubMenu AddSubMenu (int p0)
		{
			if (id_addSubMenu_I == IntPtr.Zero)
				id_addSubMenu_I = JNIEnv.GetMethodID (class_ref, "addSubMenu", "(I)Lcom/actionbarsherlock/view/SubMenu;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_addSubMenu_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_addSubMenu_IIII;
#pragma warning disable 0169
		static Delegate GetAddSubMenu_IIIIHandler ()
		{
			if (cb_addSubMenu_IIII == null)
				cb_addSubMenu_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_AddSubMenu_IIII);
			return cb_addSubMenu_IIII;
		}

		static IntPtr n_AddSubMenu_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddSubMenu (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		IntPtr id_addSubMenu_IIII;
		public global::ActionBar_Sherlock.View.ISubMenu AddSubMenu (int p0, int p1, int p2, int p3)
		{
			if (id_addSubMenu_IIII == IntPtr.Zero)
				id_addSubMenu_IIII = JNIEnv.GetMethodID (class_ref, "addSubMenu", "(IIII)Lcom/actionbarsherlock/view/SubMenu;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_addSubMenu_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_addSubMenu_IIILjava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetAddSubMenu_IIILjava_lang_CharSequence_Handler ()
		{
			if (cb_addSubMenu_IIILjava_lang_CharSequence_ == null)
				cb_addSubMenu_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr>) n_AddSubMenu_IIILjava_lang_CharSequence_);
			return cb_addSubMenu_IIILjava_lang_CharSequence_;
		}

		static IntPtr n_AddSubMenu_IIILjava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p3 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddSubMenu (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addSubMenu_IIILjava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.ISubMenu AddSubMenu (int p0, int p1, int p2, global::Java.Lang.ICharSequence p3)
		{
			if (id_addSubMenu_IIILjava_lang_CharSequence_ == IntPtr.Zero)
				id_addSubMenu_IIILjava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "addSubMenu", "(IIILjava/lang/CharSequence;)Lcom/actionbarsherlock/view/SubMenu;");
			IntPtr native_p3 = CharSequence.ToLocalJniHandle (p3);
			global::ActionBar_Sherlock.View.ISubMenu __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_addSubMenu_IIILjava_lang_CharSequence_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_addSubMenu_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetAddSubMenu_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_addSubMenu_Ljava_lang_CharSequence_ == null)
				cb_addSubMenu_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSubMenu_Ljava_lang_CharSequence_);
			return cb_addSubMenu_Ljava_lang_CharSequence_;
		}

		static IntPtr n_AddSubMenu_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddSubMenu (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addSubMenu_Ljava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.ISubMenu AddSubMenu (global::Java.Lang.ICharSequence p0)
		{
			if (id_addSubMenu_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_addSubMenu_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "addSubMenu", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/SubMenu;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			global::ActionBar_Sherlock.View.ISubMenu __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_addSubMenu_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

		static Delegate cb_findItem_I;
#pragma warning disable 0169
		static Delegate GetFindItem_IHandler ()
		{
			if (cb_findItem_I == null)
				cb_findItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindItem_I);
			return cb_findItem_I;
		}

		static IntPtr n_FindItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindItem (p0));
		}
#pragma warning restore 0169

		IntPtr id_findItem_I;
		public global::ActionBar_Sherlock.View.IMenuItem FindItem (int p0)
		{
			if (id_findItem_I == IntPtr.Zero)
				id_findItem_I = JNIEnv.GetMethodID (class_ref, "findItem", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_findItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		IntPtr id_getItem_I;
		public global::ActionBar_Sherlock.View.IMenuItem GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isShortcutKey_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetIsShortcutKey_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_isShortcutKey_ILandroid_view_KeyEvent_ == null)
				cb_isShortcutKey_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_IsShortcutKey_ILandroid_view_KeyEvent_);
			return cb_isShortcutKey_ILandroid_view_KeyEvent_;
		}

		static bool n_IsShortcutKey_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsShortcutKey (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isShortcutKey_ILandroid_view_KeyEvent_;
		public bool IsShortcutKey (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_isShortcutKey_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_isShortcutKey_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isShortcutKey_ILandroid_view_KeyEvent_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_performIdentifierAction_II;
#pragma warning disable 0169
		static Delegate GetPerformIdentifierAction_IIHandler ()
		{
			if (cb_performIdentifierAction_II == null)
				cb_performIdentifierAction_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_PerformIdentifierAction_II);
			return cb_performIdentifierAction_II;
		}

		static bool n_PerformIdentifierAction_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PerformIdentifierAction (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_performIdentifierAction_II;
		public bool PerformIdentifierAction (int p0, int p1)
		{
			if (id_performIdentifierAction_II == IntPtr.Zero)
				id_performIdentifierAction_II = JNIEnv.GetMethodID (class_ref, "performIdentifierAction", "(II)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_performIdentifierAction_II, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_performShortcut_ILandroid_view_KeyEvent_I;
#pragma warning disable 0169
		static Delegate GetPerformShortcut_ILandroid_view_KeyEvent_IHandler ()
		{
			if (cb_performShortcut_ILandroid_view_KeyEvent_I == null)
				cb_performShortcut_ILandroid_view_KeyEvent_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, bool>) n_PerformShortcut_ILandroid_view_KeyEvent_I);
			return cb_performShortcut_ILandroid_view_KeyEvent_I;
		}

		static bool n_PerformShortcut_ILandroid_view_KeyEvent_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PerformShortcut (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_performShortcut_ILandroid_view_KeyEvent_I;
		public bool PerformShortcut (int p0, global::Android.Views.KeyEvent p1, int p2)
		{
			if (id_performShortcut_ILandroid_view_KeyEvent_I == IntPtr.Zero)
				id_performShortcut_ILandroid_view_KeyEvent_I = JNIEnv.GetMethodID (class_ref, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_performShortcut_ILandroid_view_KeyEvent_I, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_removeGroup_I;
#pragma warning disable 0169
		static Delegate GetRemoveGroup_IHandler ()
		{
			if (cb_removeGroup_I == null)
				cb_removeGroup_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveGroup_I);
			return cb_removeGroup_I;
		}

		static void n_RemoveGroup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGroup (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeGroup_I;
		public void RemoveGroup (int p0)
		{
			if (id_removeGroup_I == IntPtr.Zero)
				id_removeGroup_I = JNIEnv.GetMethodID (class_ref, "removeGroup", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_removeGroup_I, new JValue (p0));
		}

		static Delegate cb_removeItem_I;
#pragma warning disable 0169
		static Delegate GetRemoveItem_IHandler ()
		{
			if (cb_removeItem_I == null)
				cb_removeItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveItem_I);
			return cb_removeItem_I;
		}

		static void n_RemoveItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveItem (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeItem_I;
		public void RemoveItem (int p0)
		{
			if (id_removeItem_I == IntPtr.Zero)
				id_removeItem_I = JNIEnv.GetMethodID (class_ref, "removeItem", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_removeItem_I, new JValue (p0));
		}

		static Delegate cb_setGroupCheckable_IZZ;
#pragma warning disable 0169
		static Delegate GetSetGroupCheckable_IZZHandler ()
		{
			if (cb_setGroupCheckable_IZZ == null)
				cb_setGroupCheckable_IZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool, bool>) n_SetGroupCheckable_IZZ);
			return cb_setGroupCheckable_IZZ;
		}

		static void n_SetGroupCheckable_IZZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1, bool p2)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGroupCheckable (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setGroupCheckable_IZZ;
		public void SetGroupCheckable (int p0, bool p1, bool p2)
		{
			if (id_setGroupCheckable_IZZ == IntPtr.Zero)
				id_setGroupCheckable_IZZ = JNIEnv.GetMethodID (class_ref, "setGroupCheckable", "(IZZ)V");
			JNIEnv.CallVoidMethod (Handle, id_setGroupCheckable_IZZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_setGroupEnabled_IZ;
#pragma warning disable 0169
		static Delegate GetSetGroupEnabled_IZHandler ()
		{
			if (cb_setGroupEnabled_IZ == null)
				cb_setGroupEnabled_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetGroupEnabled_IZ);
			return cb_setGroupEnabled_IZ;
		}

		static void n_SetGroupEnabled_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGroupEnabled (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setGroupEnabled_IZ;
		public void SetGroupEnabled (int p0, bool p1)
		{
			if (id_setGroupEnabled_IZ == IntPtr.Zero)
				id_setGroupEnabled_IZ = JNIEnv.GetMethodID (class_ref, "setGroupEnabled", "(IZ)V");
			JNIEnv.CallVoidMethod (Handle, id_setGroupEnabled_IZ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setGroupVisible_IZ;
#pragma warning disable 0169
		static Delegate GetSetGroupVisible_IZHandler ()
		{
			if (cb_setGroupVisible_IZ == null)
				cb_setGroupVisible_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetGroupVisible_IZ);
			return cb_setGroupVisible_IZ;
		}

		static void n_SetGroupVisible_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGroupVisible (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setGroupVisible_IZ;
		public void SetGroupVisible (int p0, bool p1)
		{
			if (id_setGroupVisible_IZ == IntPtr.Zero)
				id_setGroupVisible_IZ = JNIEnv.GetMethodID (class_ref, "setGroupVisible", "(IZ)V");
			JNIEnv.CallVoidMethod (Handle, id_setGroupVisible_IZ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setQwertyMode_Z;
#pragma warning disable 0169
		static Delegate GetSetQwertyMode_ZHandler ()
		{
			if (cb_setQwertyMode_Z == null)
				cb_setQwertyMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetQwertyMode_Z);
			return cb_setQwertyMode_Z;
		}

		static void n_SetQwertyMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQwertyMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_setQwertyMode_Z;
		public void SetQwertyMode (bool p0)
		{
			if (id_setQwertyMode_Z == IntPtr.Zero)
				id_setQwertyMode_Z = JNIEnv.GetMethodID (class_ref, "setQwertyMode", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setQwertyMode_Z, new JValue (p0));
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			ISubMenu __this = Java.Lang.Object.GetObject<ISubMenu> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (Handle, id_size);
		}

	}

}
