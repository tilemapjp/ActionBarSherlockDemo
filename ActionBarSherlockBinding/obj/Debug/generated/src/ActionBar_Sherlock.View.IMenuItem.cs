using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.View {

	[Register ("com/actionbarsherlock/view/MenuItem$OnActionExpandListener", "", "ActionBar_Sherlock.View.IMenuItemOnActionExpandListenerInvoker")]
	public partial interface IMenuItemOnActionExpandListener : IJavaObject {

		[Register ("onMenuItemActionCollapse", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.View.IMenuItemOnActionExpandListenerInvoker, ActionBarSherlockBinding")]
		bool OnMenuItemActionCollapse (global::ActionBar_Sherlock.View.IMenuItem p0);

		[Register ("onMenuItemActionExpand", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.View.IMenuItemOnActionExpandListenerInvoker, ActionBarSherlockBinding")]
		bool OnMenuItemActionExpand (global::ActionBar_Sherlock.View.IMenuItem p0);

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/MenuItem$OnActionExpandListener", DoNotGenerateAcw=true)]
	internal class IMenuItemOnActionExpandListenerInvoker : Java.Lang.Object, IMenuItemOnActionExpandListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/MenuItem$OnActionExpandListener");
		IntPtr class_ref;

		public static IMenuItemOnActionExpandListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.MenuItem.OnActionExpandListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMenuItemOnActionExpandListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMenuItemOnActionExpandListenerInvoker); }
		}

		static Delegate cb_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_);
			return cb_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItemOnActionExpandListener __this = Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItem p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemActionCollapse (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_;
		public bool OnMenuItemActionCollapse (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			if (id_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemActionCollapse", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_);
			return cb_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItemOnActionExpandListener __this = Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItem p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemActionExpand (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_;
		public bool OnMenuItemActionExpand (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			if (id_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemActionExpand", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

	}

	public partial class MenuItemActionCollapseEventArgs : global::System.EventArgs {

		public MenuItemActionCollapseEventArgs (bool handled, global::ActionBar_Sherlock.View.IMenuItem p0)
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

	public partial class MenuItemActionExpandEventArgs : global::System.EventArgs {

		public MenuItemActionExpandEventArgs (bool handled, global::ActionBar_Sherlock.View.IMenuItem p0)
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

	[global::Android.Runtime.Register ("mono/com/actionbarsherlock/view/MenuItem_OnActionExpandListenerImplementor")]
	internal sealed class IMenuItemOnActionExpandListenerImplementor : Java.Lang.Object, IMenuItemOnActionExpandListener {

		object sender;

		public IMenuItemOnActionExpandListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/view/MenuItem_OnActionExpandListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MenuItemActionCollapseEventArgs> OnMenuItemActionCollapseHandler;
#pragma warning restore 0649

		public bool OnMenuItemActionCollapse (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			var __h = OnMenuItemActionCollapseHandler;
			if (__h == null)
				return false;
			var __e = new MenuItemActionCollapseEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<MenuItemActionExpandEventArgs> OnMenuItemActionExpandHandler;
#pragma warning restore 0649

		public bool OnMenuItemActionExpand (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			var __h = OnMenuItemActionExpandHandler;
			if (__h == null)
				return false;
			var __e = new MenuItemActionExpandEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMenuItemOnActionExpandListenerImplementor value)
		{
			return value.OnMenuItemActionCollapseHandler == null && value.OnMenuItemActionExpandHandler == null;
		}
	}


	[Register ("com/actionbarsherlock/view/MenuItem$OnMenuItemClickListener", "", "ActionBar_Sherlock.View.IMenuItemOnMenuItemClickListenerInvoker")]
	public partial interface IMenuItemOnMenuItemClickListener : IJavaObject {

		[Register ("onMenuItemClick", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.View.IMenuItemOnMenuItemClickListenerInvoker, ActionBarSherlockBinding")]
		bool OnMenuItemClick (global::ActionBar_Sherlock.View.IMenuItem p0);

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/MenuItem$OnMenuItemClickListener", DoNotGenerateAcw=true)]
	internal class IMenuItemOnMenuItemClickListenerInvoker : Java.Lang.Object, IMenuItemOnMenuItemClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/MenuItem$OnMenuItemClickListener");
		IntPtr class_ref;

		public static IMenuItemOnMenuItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuItemOnMenuItemClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.MenuItem.OnMenuItemClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMenuItemOnMenuItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMenuItemOnMenuItemClickListenerInvoker); }
		}

		static Delegate cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_);
			return cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItemOnMenuItemClickListener __this = Java.Lang.Object.GetObject<IMenuItemOnMenuItemClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItem p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemClick (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
		public bool OnMenuItemClick (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			if (id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemClick", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

	}

	public partial class MenuItemOnMenuItemClickEventArgs : global::System.EventArgs {

		public MenuItemOnMenuItemClickEventArgs (bool handled, global::ActionBar_Sherlock.View.IMenuItem p0)
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

	[global::Android.Runtime.Register ("mono/com/actionbarsherlock/view/MenuItem_OnMenuItemClickListenerImplementor")]
	internal sealed class IMenuItemOnMenuItemClickListenerImplementor : Java.Lang.Object, IMenuItemOnMenuItemClickListener {

		object sender;

		public IMenuItemOnMenuItemClickListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/view/MenuItem_OnMenuItemClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MenuItemOnMenuItemClickEventArgs> Handler;
#pragma warning restore 0649

		public bool OnMenuItemClick (global::ActionBar_Sherlock.View.IMenuItem p0)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new MenuItemOnMenuItemClickEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMenuItemOnMenuItemClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	[Register ("com/actionbarsherlock/view/MenuItem")]
	public abstract class MenuItem {

		internal MenuItem ()
		{
		}

		[Register ("SHOW_AS_ACTION_ALWAYS")]
		public const int ShowAsActionAlways = (int) 2;

		[Register ("SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW")]
		public const int ShowAsActionCollapseActionView = (int) 8;

		[Register ("SHOW_AS_ACTION_IF_ROOM")]
		public const int ShowAsActionIfRoom = (int) 1;

		[Register ("SHOW_AS_ACTION_NEVER")]
		public const int ShowAsActionNever = (int) 0;

		[Register ("SHOW_AS_ACTION_WITH_TEXT")]
		public const int ShowAsActionWithText = (int) 4;
	}

	[System.Obsolete ("Use the 'MenuItem' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class MenuItemConsts : MenuItem {

		private MenuItemConsts ()
		{
		}
	}

	[Register ("com/actionbarsherlock/view/MenuItem", "", "ActionBar_Sherlock.View.IMenuItemInvoker")]
	public partial interface IMenuItem : IJavaObject {

		global::ActionBar_Sherlock.View.ActionProvider ActionProvider {
			[Register ("getActionProvider", "()Lcom/actionbarsherlock/view/ActionProvider;", "GetGetActionProviderHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::Android.Views.View ActionView {
			[Register ("getActionView", "()Landroid/view/View;", "GetGetActionViewHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		char AlphabeticShortcut {
			[Register ("getAlphabeticShortcut", "()C", "GetGetAlphabeticShortcutHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		int GroupId {
			[Register ("getGroupId", "()I", "GetGetGroupIdHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		bool HasSubMenu {
			[Register ("hasSubMenu", "()Z", "GetHasSubMenuHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::Android.Graphics.Drawables.Drawable Icon {
			[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::Android.Content.Intent Intent {
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		bool IsActionViewExpanded {
			[Register ("isActionViewExpanded", "()Z", "GetIsActionViewExpandedHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		bool IsCheckable {
			[Register ("isCheckable", "()Z", "GetIsCheckableHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		bool IsChecked {
			[Register ("isChecked", "()Z", "GetIsCheckedHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		bool IsEnabled {
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		bool IsVisible {
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		int ItemId {
			[Register ("getItemId", "()I", "GetGetItemIdHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::Android.Views.IContextMenuContextMenuInfo MenuInfo {
			[Register ("getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", "GetGetMenuInfoHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		char NumericShortcut {
			[Register ("getNumericShortcut", "()C", "GetGetNumericShortcutHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		int Order {
			[Register ("getOrder", "()I", "GetGetOrderHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::ActionBar_Sherlock.View.ISubMenu SubMenu {
			[Register ("getSubMenu", "()Lcom/actionbarsherlock/view/SubMenu;", "GetGetSubMenuHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::Java.Lang.ICharSequence TitleFormatted {
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		global::Java.Lang.ICharSequence TitleCondensedFormatted {
			[Register ("getTitleCondensed", "()Ljava/lang/CharSequence;", "GetGetTitleCondensedHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")] get;
		}

		[Register ("collapseActionView", "()Z", "GetCollapseActionViewHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		bool CollapseActionView ();

		[Register ("expandActionView", "()Z", "GetExpandActionViewHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		bool ExpandActionView ();

		[Register ("setActionProvider", "(Lcom/actionbarsherlock/view/ActionProvider;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetActionProvider_Lcom_actionbarsherlock_view_ActionProvider_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetActionProvider (global::ActionBar_Sherlock.View.ActionProvider p0);

		[Register ("setActionView", "(Landroid/view/View;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetActionView_Landroid_view_View_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetActionView (global::Android.Views.View p0);

		[Register ("setActionView", "(I)Lcom/actionbarsherlock/view/MenuItem;", "GetSetActionView_IHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetActionView (int p0);

		[Register ("setAlphabeticShortcut", "(C)Lcom/actionbarsherlock/view/MenuItem;", "GetSetAlphabeticShortcut_CHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetAlphabeticShortcut (char p0);

		[Register ("setCheckable", "(Z)Lcom/actionbarsherlock/view/MenuItem;", "GetSetCheckable_ZHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetCheckable (bool p0);

		[Register ("setChecked", "(Z)Lcom/actionbarsherlock/view/MenuItem;", "GetSetChecked_ZHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetChecked (bool p0);

		[Register ("setEnabled", "(Z)Lcom/actionbarsherlock/view/MenuItem;", "GetSetEnabled_ZHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetEnabled (bool p0);

		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetIcon (global::Android.Graphics.Drawables.Drawable p0);

		[Register ("setIcon", "(I)Lcom/actionbarsherlock/view/MenuItem;", "GetSetIcon_IHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetIcon (int p0);

		[Register ("setIntent", "(Landroid/content/Intent;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetIntent_Landroid_content_Intent_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetIntent (global::Android.Content.Intent p0);

		[Register ("setNumericShortcut", "(C)Lcom/actionbarsherlock/view/MenuItem;", "GetSetNumericShortcut_CHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetNumericShortcut (char p0);

		[Register ("setOnActionExpandListener", "(Lcom/actionbarsherlock/view/MenuItem$OnActionExpandListener;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetOnActionExpandListener (global::ActionBar_Sherlock.View.IMenuItemOnActionExpandListener p0);

		[Register ("setOnMenuItemClickListener", "(Lcom/actionbarsherlock/view/MenuItem$OnMenuItemClickListener;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetOnMenuItemClickListener (global::ActionBar_Sherlock.View.IMenuItemOnMenuItemClickListener p0);

		[Register ("setShortcut", "(CC)Lcom/actionbarsherlock/view/MenuItem;", "GetSetShortcut_CCHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetShortcut (char p0, char p1);

		[Register ("setShowAsAction", "(I)V", "GetSetShowAsAction_IHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		void SetShowAsAction (int p0);

		[Register ("setShowAsActionFlags", "(I)Lcom/actionbarsherlock/view/MenuItem;", "GetSetShowAsActionFlags_IHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetShowAsActionFlags (int p0);

		[Register ("setTitle", "(I)Lcom/actionbarsherlock/view/MenuItem;", "GetSetTitle_IHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetTitle (int p0);

		[Register ("setTitle", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetTitle_Ljava_lang_CharSequence_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetTitle (global::Java.Lang.ICharSequence p0);

		[Register ("setTitleCondensed", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/MenuItem;", "GetSetTitleCondensed_Ljava_lang_CharSequence_Handler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetTitleCondensed (global::Java.Lang.ICharSequence p0);

		[Register ("setVisible", "(Z)Lcom/actionbarsherlock/view/MenuItem;", "GetSetVisible_ZHandler:ActionBar_Sherlock.View.IMenuItemInvoker, ActionBarSherlockBinding")]
		global::ActionBar_Sherlock.View.IMenuItem SetVisible (bool p0);

	}

	public static partial class IMenuItemExtensions {

		public static global::ActionBar_Sherlock.View.IMenuItem SetTitle (this ActionBar_Sherlock.View.IMenuItem self, string p0)
		{
			Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
			global::ActionBar_Sherlock.View.IMenuItem __result = self.SetTitle (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

		public static global::ActionBar_Sherlock.View.IMenuItem SetTitleCondensed (this ActionBar_Sherlock.View.IMenuItem self, string p0)
		{
			Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
			global::ActionBar_Sherlock.View.IMenuItem __result = self.SetTitleCondensed (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}
	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/MenuItem", DoNotGenerateAcw=true)]
	internal class IMenuItemInvoker : Java.Lang.Object, IMenuItem {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/MenuItem");
		IntPtr class_ref;

		public static IMenuItem GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuItem> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.MenuItem"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMenuItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMenuItemInvoker); }
		}

		static Delegate cb_getActionProvider;
#pragma warning disable 0169
		static Delegate GetGetActionProviderHandler ()
		{
			if (cb_getActionProvider == null)
				cb_getActionProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionProvider);
			return cb_getActionProvider;
		}

		static IntPtr n_GetActionProvider (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionProvider);
		}
#pragma warning restore 0169

		IntPtr id_getActionProvider;
		public global::ActionBar_Sherlock.View.ActionProvider ActionProvider {
			get {
				if (id_getActionProvider == IntPtr.Zero)
					id_getActionProvider = JNIEnv.GetMethodID (class_ref, "getActionProvider", "()Lcom/actionbarsherlock/view/ActionProvider;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionProvider> (JNIEnv.CallObjectMethod (Handle, id_getActionProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getActionView;
#pragma warning disable 0169
		static Delegate GetGetActionViewHandler ()
		{
			if (cb_getActionView == null)
				cb_getActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionView);
			return cb_getActionView;
		}

		static IntPtr n_GetActionView (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionView);
		}
#pragma warning restore 0169

		IntPtr id_getActionView;
		public global::Android.Views.View ActionView {
			get {
				if (id_getActionView == IntPtr.Zero)
					id_getActionView = JNIEnv.GetMethodID (class_ref, "getActionView", "()Landroid/view/View;");
				return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getActionView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAlphabeticShortcut;
#pragma warning disable 0169
		static Delegate GetGetAlphabeticShortcutHandler ()
		{
			if (cb_getAlphabeticShortcut == null)
				cb_getAlphabeticShortcut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetAlphabeticShortcut);
			return cb_getAlphabeticShortcut;
		}

		static char n_GetAlphabeticShortcut (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphabeticShortcut;
		}
#pragma warning restore 0169

		IntPtr id_getAlphabeticShortcut;
		public char AlphabeticShortcut {
			get {
				if (id_getAlphabeticShortcut == IntPtr.Zero)
					id_getAlphabeticShortcut = JNIEnv.GetMethodID (class_ref, "getAlphabeticShortcut", "()C");
				return JNIEnv.CallCharMethod (Handle, id_getAlphabeticShortcut);
			}
		}

		static Delegate cb_getGroupId;
#pragma warning disable 0169
		static Delegate GetGetGroupIdHandler ()
		{
			if (cb_getGroupId == null)
				cb_getGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGroupId);
			return cb_getGroupId;
		}

		static int n_GetGroupId (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GroupId;
		}
#pragma warning restore 0169

		IntPtr id_getGroupId;
		public int GroupId {
			get {
				if (id_getGroupId == IntPtr.Zero)
					id_getGroupId = JNIEnv.GetMethodID (class_ref, "getGroupId", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getGroupId);
			}
		}

		static Delegate cb_hasSubMenu;
#pragma warning disable 0169
		static Delegate GetHasSubMenuHandler ()
		{
			if (cb_hasSubMenu == null)
				cb_hasSubMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSubMenu);
			return cb_hasSubMenu;
		}

		static bool n_HasSubMenu (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSubMenu;
		}
#pragma warning restore 0169

		IntPtr id_hasSubMenu;
		public bool HasSubMenu {
			get {
				if (id_hasSubMenu == IntPtr.Zero)
					id_hasSubMenu = JNIEnv.GetMethodID (class_ref, "hasSubMenu", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasSubMenu);
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		IntPtr id_getIcon;
		public global::Android.Graphics.Drawables.Drawable Icon {
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Landroid/graphics/drawable/Drawable;");
				return Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		IntPtr id_getIntent;
		public global::Android.Content.Intent Intent {
			get {
				if (id_getIntent == IntPtr.Zero)
					id_getIntent = JNIEnv.GetMethodID (class_ref, "getIntent", "()Landroid/content/Intent;");
				return Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (Handle, id_getIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isActionViewExpanded;
#pragma warning disable 0169
		static Delegate GetIsActionViewExpandedHandler ()
		{
			if (cb_isActionViewExpanded == null)
				cb_isActionViewExpanded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActionViewExpanded);
			return cb_isActionViewExpanded;
		}

		static bool n_IsActionViewExpanded (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActionViewExpanded;
		}
#pragma warning restore 0169

		IntPtr id_isActionViewExpanded;
		public bool IsActionViewExpanded {
			get {
				if (id_isActionViewExpanded == IntPtr.Zero)
					id_isActionViewExpanded = JNIEnv.GetMethodID (class_ref, "isActionViewExpanded", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isActionViewExpanded);
			}
		}

		static Delegate cb_isCheckable;
#pragma warning disable 0169
		static Delegate GetIsCheckableHandler ()
		{
			if (cb_isCheckable == null)
				cb_isCheckable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCheckable);
			return cb_isCheckable;
		}

		static bool n_IsCheckable (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCheckable;
		}
#pragma warning restore 0169

		IntPtr id_isCheckable;
		public bool IsCheckable {
			get {
				if (id_isCheckable == IntPtr.Zero)
					id_isCheckable = JNIEnv.GetMethodID (class_ref, "isCheckable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCheckable);
			}
		}

		static Delegate cb_isChecked;
#pragma warning disable 0169
		static Delegate GetIsCheckedHandler ()
		{
			if (cb_isChecked == null)
				cb_isChecked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChecked);
			return cb_isChecked;
		}

		static bool n_IsChecked (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChecked;
		}
#pragma warning restore 0169

		IntPtr id_isChecked;
		public bool IsChecked {
			get {
				if (id_isChecked == IntPtr.Zero)
					id_isChecked = JNIEnv.GetMethodID (class_ref, "isChecked", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isChecked);
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isEnabled;
		public bool IsEnabled {
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEnabled);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVisible;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		public bool IsVisible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isVisible);
			}
		}

		static Delegate cb_getItemId;
#pragma warning disable 0169
		static Delegate GetGetItemIdHandler ()
		{
			if (cb_getItemId == null)
				cb_getItemId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemId);
			return cb_getItemId;
		}

		static int n_GetItemId (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemId;
		}
#pragma warning restore 0169

		IntPtr id_getItemId;
		public int ItemId {
			get {
				if (id_getItemId == IntPtr.Zero)
					id_getItemId = JNIEnv.GetMethodID (class_ref, "getItemId", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getItemId);
			}
		}

		static Delegate cb_getMenuInfo;
#pragma warning disable 0169
		static Delegate GetGetMenuInfoHandler ()
		{
			if (cb_getMenuInfo == null)
				cb_getMenuInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMenuInfo);
			return cb_getMenuInfo;
		}

		static IntPtr n_GetMenuInfo (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MenuInfo);
		}
#pragma warning restore 0169

		IntPtr id_getMenuInfo;
		public global::Android.Views.IContextMenuContextMenuInfo MenuInfo {
			get {
				if (id_getMenuInfo == IntPtr.Zero)
					id_getMenuInfo = JNIEnv.GetMethodID (class_ref, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
				return Java.Lang.Object.GetObject<global::Android.Views.IContextMenuContextMenuInfo> (JNIEnv.CallObjectMethod (Handle, id_getMenuInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNumericShortcut;
#pragma warning disable 0169
		static Delegate GetGetNumericShortcutHandler ()
		{
			if (cb_getNumericShortcut == null)
				cb_getNumericShortcut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetNumericShortcut);
			return cb_getNumericShortcut;
		}

		static char n_GetNumericShortcut (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumericShortcut;
		}
#pragma warning restore 0169

		IntPtr id_getNumericShortcut;
		public char NumericShortcut {
			get {
				if (id_getNumericShortcut == IntPtr.Zero)
					id_getNumericShortcut = JNIEnv.GetMethodID (class_ref, "getNumericShortcut", "()C");
				return JNIEnv.CallCharMethod (Handle, id_getNumericShortcut);
			}
		}

		static Delegate cb_getOrder;
#pragma warning disable 0169
		static Delegate GetGetOrderHandler ()
		{
			if (cb_getOrder == null)
				cb_getOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrder);
			return cb_getOrder;
		}

		static int n_GetOrder (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Order;
		}
#pragma warning restore 0169

		IntPtr id_getOrder;
		public int Order {
			get {
				if (id_getOrder == IntPtr.Zero)
					id_getOrder = JNIEnv.GetMethodID (class_ref, "getOrder", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getOrder);
			}
		}

		static Delegate cb_getSubMenu;
#pragma warning disable 0169
		static Delegate GetGetSubMenuHandler ()
		{
			if (cb_getSubMenu == null)
				cb_getSubMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubMenu);
			return cb_getSubMenu;
		}

		static IntPtr n_GetSubMenu (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubMenu);
		}
#pragma warning restore 0169

		IntPtr id_getSubMenu;
		public global::ActionBar_Sherlock.View.ISubMenu SubMenu {
			get {
				if (id_getSubMenu == IntPtr.Zero)
					id_getSubMenu = JNIEnv.GetMethodID (class_ref, "getSubMenu", "()Lcom/actionbarsherlock/view/SubMenu;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (JNIEnv.CallObjectMethod (Handle, id_getSubMenu), JniHandleOwnership.TransferLocalRef);
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
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public global::Java.Lang.ICharSequence TitleFormatted {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				return Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTitleCondensed;
#pragma warning disable 0169
		static Delegate GetGetTitleCondensedHandler ()
		{
			if (cb_getTitleCondensed == null)
				cb_getTitleCondensed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleCondensed);
			return cb_getTitleCondensed;
		}

		static IntPtr n_GetTitleCondensed (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleCondensedFormatted);
		}
#pragma warning restore 0169

		IntPtr id_getTitleCondensed;
		public global::Java.Lang.ICharSequence TitleCondensedFormatted {
			get {
				if (id_getTitleCondensed == IntPtr.Zero)
					id_getTitleCondensed = JNIEnv.GetMethodID (class_ref, "getTitleCondensed", "()Ljava/lang/CharSequence;");
				return Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (Handle, id_getTitleCondensed), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_collapseActionView;
#pragma warning disable 0169
		static Delegate GetCollapseActionViewHandler ()
		{
			if (cb_collapseActionView == null)
				cb_collapseActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CollapseActionView);
			return cb_collapseActionView;
		}

		static bool n_CollapseActionView (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CollapseActionView ();
		}
#pragma warning restore 0169

		IntPtr id_collapseActionView;
		public bool CollapseActionView ()
		{
			if (id_collapseActionView == IntPtr.Zero)
				id_collapseActionView = JNIEnv.GetMethodID (class_ref, "collapseActionView", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_collapseActionView);
		}

		static Delegate cb_expandActionView;
#pragma warning disable 0169
		static Delegate GetExpandActionViewHandler ()
		{
			if (cb_expandActionView == null)
				cb_expandActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ExpandActionView);
			return cb_expandActionView;
		}

		static bool n_ExpandActionView (IntPtr jnienv, IntPtr native__this)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpandActionView ();
		}
#pragma warning restore 0169

		IntPtr id_expandActionView;
		public bool ExpandActionView ()
		{
			if (id_expandActionView == IntPtr.Zero)
				id_expandActionView = JNIEnv.GetMethodID (class_ref, "expandActionView", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_expandActionView);
		}

		static Delegate cb_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_;
#pragma warning disable 0169
		static Delegate GetSetActionProvider_Lcom_actionbarsherlock_view_ActionProvider_Handler ()
		{
			if (cb_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_ == null)
				cb_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActionProvider_Lcom_actionbarsherlock_view_ActionProvider_);
			return cb_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_;
		}

		static IntPtr n_SetActionProvider_Lcom_actionbarsherlock_view_ActionProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.ActionProvider p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActionProvider (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_;
		public global::ActionBar_Sherlock.View.IMenuItem SetActionProvider (global::ActionBar_Sherlock.View.ActionProvider p0)
		{
			if (id_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_ == IntPtr.Zero)
				id_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_ = JNIEnv.GetMethodID (class_ref, "setActionProvider", "(Lcom/actionbarsherlock/view/ActionProvider;)Lcom/actionbarsherlock/view/MenuItem;");
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setActionProvider_Lcom_actionbarsherlock_view_ActionProvider_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setActionView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetActionView_Landroid_view_View_Handler ()
		{
			if (cb_setActionView_Landroid_view_View_ == null)
				cb_setActionView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActionView_Landroid_view_View_);
			return cb_setActionView_Landroid_view_View_;
		}

		static IntPtr n_SetActionView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActionView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setActionView_Landroid_view_View_;
		public global::ActionBar_Sherlock.View.IMenuItem SetActionView (global::Android.Views.View p0)
		{
			if (id_setActionView_Landroid_view_View_ == IntPtr.Zero)
				id_setActionView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setActionView", "(Landroid/view/View;)Lcom/actionbarsherlock/view/MenuItem;");
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setActionView_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setActionView_I;
#pragma warning disable 0169
		static Delegate GetSetActionView_IHandler ()
		{
			if (cb_setActionView_I == null)
				cb_setActionView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetActionView_I);
			return cb_setActionView_I;
		}

		static IntPtr n_SetActionView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetActionView (p0));
		}
#pragma warning restore 0169

		IntPtr id_setActionView_I;
		public global::ActionBar_Sherlock.View.IMenuItem SetActionView (int p0)
		{
			if (id_setActionView_I == IntPtr.Zero)
				id_setActionView_I = JNIEnv.GetMethodID (class_ref, "setActionView", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setActionView_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setAlphabeticShortcut_C;
#pragma warning disable 0169
		static Delegate GetSetAlphabeticShortcut_CHandler ()
		{
			if (cb_setAlphabeticShortcut_C == null)
				cb_setAlphabeticShortcut_C = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char, IntPtr>) n_SetAlphabeticShortcut_C);
			return cb_setAlphabeticShortcut_C;
		}

		static IntPtr n_SetAlphabeticShortcut_C (IntPtr jnienv, IntPtr native__this, char p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAlphabeticShortcut (p0));
		}
#pragma warning restore 0169

		IntPtr id_setAlphabeticShortcut_C;
		public global::ActionBar_Sherlock.View.IMenuItem SetAlphabeticShortcut (char p0)
		{
			if (id_setAlphabeticShortcut_C == IntPtr.Zero)
				id_setAlphabeticShortcut_C = JNIEnv.GetMethodID (class_ref, "setAlphabeticShortcut", "(C)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setAlphabeticShortcut_C, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setCheckable_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckable_ZHandler ()
		{
			if (cb_setCheckable_Z == null)
				cb_setCheckable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCheckable_Z);
			return cb_setCheckable_Z;
		}

		static IntPtr n_SetCheckable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCheckable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setCheckable_Z;
		public global::ActionBar_Sherlock.View.IMenuItem SetCheckable (bool p0)
		{
			if (id_setCheckable_Z == IntPtr.Zero)
				id_setCheckable_Z = JNIEnv.GetMethodID (class_ref, "setCheckable", "(Z)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setCheckable_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setChecked_Z;
#pragma warning disable 0169
		static Delegate GetSetChecked_ZHandler ()
		{
			if (cb_setChecked_Z == null)
				cb_setChecked_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetChecked_Z);
			return cb_setChecked_Z;
		}

		static IntPtr n_SetChecked_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetChecked (p0));
		}
#pragma warning restore 0169

		IntPtr id_setChecked_Z;
		public global::ActionBar_Sherlock.View.IMenuItem SetChecked (bool p0)
		{
			if (id_setChecked_Z == IntPtr.Zero)
				id_setChecked_Z = JNIEnv.GetMethodID (class_ref, "setChecked", "(Z)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setChecked_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static IntPtr n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnabled (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnabled_Z;
		public global::ActionBar_Sherlock.View.IMenuItem SetEnabled (bool p0)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		public global::ActionBar_Sherlock.View.IMenuItem SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/view/MenuItem;");
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
		}
#pragma warning restore 0169

		IntPtr id_setIcon_I;
		public global::ActionBar_Sherlock.View.IMenuItem SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setIcon_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_setIntent_Landroid_content_Intent_ == null)
				cb_setIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetIntent_Landroid_content_Intent_);
			return cb_setIntent_Landroid_content_Intent_;
		}

		static IntPtr n_SetIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setIntent_Landroid_content_Intent_;
		public global::ActionBar_Sherlock.View.IMenuItem SetIntent (global::Android.Content.Intent p0)
		{
			if (id_setIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_setIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "setIntent", "(Landroid/content/Intent;)Lcom/actionbarsherlock/view/MenuItem;");
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setIntent_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setNumericShortcut_C;
#pragma warning disable 0169
		static Delegate GetSetNumericShortcut_CHandler ()
		{
			if (cb_setNumericShortcut_C == null)
				cb_setNumericShortcut_C = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char, IntPtr>) n_SetNumericShortcut_C);
			return cb_setNumericShortcut_C;
		}

		static IntPtr n_SetNumericShortcut_C (IntPtr jnienv, IntPtr native__this, char p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNumericShortcut (p0));
		}
#pragma warning restore 0169

		IntPtr id_setNumericShortcut_C;
		public global::ActionBar_Sherlock.View.IMenuItem SetNumericShortcut (char p0)
		{
			if (id_setNumericShortcut_C == IntPtr.Zero)
				id_setNumericShortcut_C = JNIEnv.GetMethodID (class_ref, "setNumericShortcut", "(C)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setNumericShortcut_C, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_;
#pragma warning disable 0169
		static Delegate GetSetOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_Handler ()
		{
			if (cb_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_ == null)
				cb_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_);
			return cb_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_;
		}

		static IntPtr n_SetOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItemOnActionExpandListener p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItemOnActionExpandListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnActionExpandListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_;
		public global::ActionBar_Sherlock.View.IMenuItem SetOnActionExpandListener (global::ActionBar_Sherlock.View.IMenuItemOnActionExpandListener p0)
		{
			if (id_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_ == IntPtr.Zero)
				id_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_ = JNIEnv.GetMethodID (class_ref, "setOnActionExpandListener", "(Lcom/actionbarsherlock/view/MenuItem$OnActionExpandListener;)Lcom/actionbarsherlock/view/MenuItem;");
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setOnActionExpandListener_Lcom_actionbarsherlock_view_MenuItem_OnActionExpandListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_Handler ()
		{
			if (cb_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_ == null)
				cb_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_);
			return cb_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_;
		}

		static IntPtr n_SetOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.IMenuItemOnMenuItemClickListener p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItemOnMenuItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnMenuItemClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_;
		public global::ActionBar_Sherlock.View.IMenuItem SetOnMenuItemClickListener (global::ActionBar_Sherlock.View.IMenuItemOnMenuItemClickListener p0)
		{
			if (id_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_ == IntPtr.Zero)
				id_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMenuItemClickListener", "(Lcom/actionbarsherlock/view/MenuItem$OnMenuItemClickListener;)Lcom/actionbarsherlock/view/MenuItem;");
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setOnMenuItemClickListener_Lcom_actionbarsherlock_view_MenuItem_OnMenuItemClickListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setShortcut_CC;
#pragma warning disable 0169
		static Delegate GetSetShortcut_CCHandler ()
		{
			if (cb_setShortcut_CC == null)
				cb_setShortcut_CC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char, char, IntPtr>) n_SetShortcut_CC);
			return cb_setShortcut_CC;
		}

		static IntPtr n_SetShortcut_CC (IntPtr jnienv, IntPtr native__this, char p0, char p1)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShortcut (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_setShortcut_CC;
		public global::ActionBar_Sherlock.View.IMenuItem SetShortcut (char p0, char p1)
		{
			if (id_setShortcut_CC == IntPtr.Zero)
				id_setShortcut_CC = JNIEnv.GetMethodID (class_ref, "setShortcut", "(CC)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setShortcut_CC, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setShowAsAction_I;
#pragma warning disable 0169
		static Delegate GetSetShowAsAction_IHandler ()
		{
			if (cb_setShowAsAction_I == null)
				cb_setShowAsAction_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShowAsAction_I);
			return cb_setShowAsAction_I;
		}

		static void n_SetShowAsAction_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowAsAction (p0);
		}
#pragma warning restore 0169

		IntPtr id_setShowAsAction_I;
		public void SetShowAsAction (int p0)
		{
			if (id_setShowAsAction_I == IntPtr.Zero)
				id_setShowAsAction_I = JNIEnv.GetMethodID (class_ref, "setShowAsAction", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_setShowAsAction_I, new JValue (p0));
		}

		static Delegate cb_setShowAsActionFlags_I;
#pragma warning disable 0169
		static Delegate GetSetShowAsActionFlags_IHandler ()
		{
			if (cb_setShowAsActionFlags_I == null)
				cb_setShowAsActionFlags_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetShowAsActionFlags_I);
			return cb_setShowAsActionFlags_I;
		}

		static IntPtr n_SetShowAsActionFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShowAsActionFlags (p0));
		}
#pragma warning restore 0169

		IntPtr id_setShowAsActionFlags_I;
		public global::ActionBar_Sherlock.View.IMenuItem SetShowAsActionFlags (int p0)
		{
			if (id_setShowAsActionFlags_I == IntPtr.Zero)
				id_setShowAsActionFlags_I = JNIEnv.GetMethodID (class_ref, "setShowAsActionFlags", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setShowAsActionFlags_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static IntPtr n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitle (p0));
		}
#pragma warning restore 0169

		IntPtr id_setTitle_I;
		public global::ActionBar_Sherlock.View.IMenuItem SetTitle (int p0)
		{
			if (id_setTitle_I == IntPtr.Zero)
				id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setTitle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTitle_Ljava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.IMenuItem SetTitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/MenuItem;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setTitle_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTitleCondensed_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitleCondensed_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitleCondensed_Ljava_lang_CharSequence_ == null)
				cb_setTitleCondensed_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitleCondensed_Ljava_lang_CharSequence_);
			return cb_setTitleCondensed_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetTitleCondensed_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitleCondensed (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTitleCondensed_Ljava_lang_CharSequence_;
		public global::ActionBar_Sherlock.View.IMenuItem SetTitleCondensed (global::Java.Lang.ICharSequence p0)
		{
			if (id_setTitleCondensed_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setTitleCondensed_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitleCondensed", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/view/MenuItem;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			global::ActionBar_Sherlock.View.IMenuItem __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setTitleCondensed_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static IntPtr n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			IMenuItem __this = Java.Lang.Object.GetObject<IMenuItem> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetVisible (p0));
		}
#pragma warning restore 0169

		IntPtr id_setVisible_Z;
		public global::ActionBar_Sherlock.View.IMenuItem SetVisible (bool p0)
		{
			if (id_setVisible_Z == IntPtr.Zero)
				id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)Lcom/actionbarsherlock/view/MenuItem;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.IMenuItem> (JNIEnv.CallObjectMethod (Handle, id_setVisible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
