using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.View {

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/ActionProvider", DoNotGenerateAcw=true)]
	public abstract partial class ActionProvider : global::Java.Lang.Object {

		[Register ("com/actionbarsherlock/view/ActionProvider$SubUiVisibilityListener", "", "ActionBar_Sherlock.View.ActionProvider/ISubUiVisibilityListenerInvoker")]
		public partial interface ISubUiVisibilityListener : IJavaObject {

			[Register ("onSubUiVisibilityChanged", "(Z)V", "GetOnSubUiVisibilityChanged_ZHandler:ActionBar_Sherlock.View.ActionProvider/ISubUiVisibilityListenerInvoker, ActionBarSherlockBinding")]
			void OnSubUiVisibilityChanged (bool p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/view/ActionProvider$SubUiVisibilityListener", DoNotGenerateAcw=true)]
		internal class ISubUiVisibilityListenerInvoker : Java.Lang.Object, ISubUiVisibilityListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/view/ActionProvider$SubUiVisibilityListener");
			IntPtr class_ref;

			public static ISubUiVisibilityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ISubUiVisibilityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.view.ActionProvider.SubUiVisibilityListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISubUiVisibilityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ISubUiVisibilityListenerInvoker); }
			}

			static Delegate cb_onSubUiVisibilityChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnSubUiVisibilityChanged_ZHandler ()
			{
				if (cb_onSubUiVisibilityChanged_Z == null)
					cb_onSubUiVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnSubUiVisibilityChanged_Z);
				return cb_onSubUiVisibilityChanged_Z;
			}

			static void n_OnSubUiVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				ISubUiVisibilityListener __this = Java.Lang.Object.GetObject<ISubUiVisibilityListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSubUiVisibilityChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSubUiVisibilityChanged_Z;
			public void OnSubUiVisibilityChanged (bool p0)
			{
				if (id_onSubUiVisibilityChanged_Z == IntPtr.Zero)
					id_onSubUiVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onSubUiVisibilityChanged", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onSubUiVisibilityChanged_Z, new JValue (p0));
			}

		}

		public partial class SubUiVisibilityEventArgs : global::System.EventArgs {

			public SubUiVisibilityEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/view/ActionProvider_SubUiVisibilityListenerImplementor")]
		internal sealed class ISubUiVisibilityListenerImplementor : Java.Lang.Object, ISubUiVisibilityListener {

			object sender;

			public ISubUiVisibilityListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/view/ActionProvider_SubUiVisibilityListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SubUiVisibilityEventArgs> Handler;
#pragma warning restore 0649

			public void OnSubUiVisibilityChanged (bool p0)
			{
				if (Handler != null)
					Handler (sender, new SubUiVisibilityEventArgs (p0));
			}

			internal static bool __IsEmpty (ISubUiVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/view/ActionProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionProvider); }
		}

		protected ActionProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ActionProvider (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActionProvider)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			ActionProvider __this = Java.Lang.Object.GetObject<ActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSubMenu;
		}
#pragma warning restore 0169

		static IntPtr id_hasSubMenu;
		public virtual bool HasSubMenu {
			[Register ("hasSubMenu", "()Z", "GetHasSubMenuHandler")]
			get {
				if (id_hasSubMenu == IntPtr.Zero)
					id_hasSubMenu = JNIEnv.GetMethodID (class_ref, "hasSubMenu", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasSubMenu);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasSubMenu);
			}
		}

		static Delegate cb_onCreateActionView;
#pragma warning disable 0169
		static Delegate GetOnCreateActionViewHandler ()
		{
			if (cb_onCreateActionView == null)
				cb_onCreateActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnCreateActionView);
			return cb_onCreateActionView;
		}

		static IntPtr n_OnCreateActionView (IntPtr jnienv, IntPtr native__this)
		{
			ActionProvider __this = Java.Lang.Object.GetObject<ActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCreateActionView ());
		}
#pragma warning restore 0169

		[Register ("onCreateActionView", "()Landroid/view/View;", "GetOnCreateActionViewHandler")]
		public abstract global::Android.Views.View OnCreateActionView ();

		static Delegate cb_onPerformDefaultAction;
#pragma warning disable 0169
		static Delegate GetOnPerformDefaultActionHandler ()
		{
			if (cb_onPerformDefaultAction == null)
				cb_onPerformDefaultAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnPerformDefaultAction);
			return cb_onPerformDefaultAction;
		}

		static bool n_OnPerformDefaultAction (IntPtr jnienv, IntPtr native__this)
		{
			ActionProvider __this = Java.Lang.Object.GetObject<ActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnPerformDefaultAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onPerformDefaultAction;
		[Register ("onPerformDefaultAction", "()Z", "GetOnPerformDefaultActionHandler")]
		public virtual bool OnPerformDefaultAction ()
		{
			if (id_onPerformDefaultAction == IntPtr.Zero)
				id_onPerformDefaultAction = JNIEnv.GetMethodID (class_ref, "onPerformDefaultAction", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_onPerformDefaultAction);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onPerformDefaultAction);
		}

		static Delegate cb_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_;
#pragma warning disable 0169
		static Delegate GetOnPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_Handler ()
		{
			if (cb_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_ == null)
				cb_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_);
			return cb_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_;
		}

		static void n_OnPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionProvider __this = Java.Lang.Object.GetObject<ActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.ISubMenu p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ISubMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepareSubMenu (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_;
		[Register ("onPrepareSubMenu", "(Lcom/actionbarsherlock/view/SubMenu;)V", "GetOnPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_Handler")]
		public virtual void OnPrepareSubMenu (global::ActionBar_Sherlock.View.ISubMenu p0)
		{
			if (id_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_ == IntPtr.Zero)
				id_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_ = JNIEnv.GetMethodID (class_ref, "onPrepareSubMenu", "(Lcom/actionbarsherlock/view/SubMenu;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPrepareSubMenu_Lcom_actionbarsherlock_view_SubMenu_, new JValue (p0));
		}

		static Delegate cb_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetSetSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_Handler ()
		{
			if (cb_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_ == null)
				cb_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_);
			return cb_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_;
		}

		static void n_SetSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionProvider __this = Java.Lang.Object.GetObject<ActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListener p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSubUiVisibilityListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_;
		[Register ("setSubUiVisibilityListener", "(Lcom/actionbarsherlock/view/ActionProvider$SubUiVisibilityListener;)V", "GetSetSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_Handler")]
		public virtual void SetSubUiVisibilityListener (global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListener p0)
		{
			if (id_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_ == IntPtr.Zero)
				id_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "setSubUiVisibilityListener", "(Lcom/actionbarsherlock/view/ActionProvider$SubUiVisibilityListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSubUiVisibilityListener_Lcom_actionbarsherlock_view_ActionProvider_SubUiVisibilityListener_, new JValue (p0));
		}

		static Delegate cb_subUiVisibilityChanged_Z;
#pragma warning disable 0169
		static Delegate GetSubUiVisibilityChanged_ZHandler ()
		{
			if (cb_subUiVisibilityChanged_Z == null)
				cb_subUiVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SubUiVisibilityChanged_Z);
			return cb_subUiVisibilityChanged_Z;
		}

		static void n_SubUiVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionProvider __this = Java.Lang.Object.GetObject<ActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubUiVisibilityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_subUiVisibilityChanged_Z;
		[Register ("subUiVisibilityChanged", "(Z)V", "GetSubUiVisibilityChanged_ZHandler")]
		public virtual void SubUiVisibilityChanged (bool p0)
		{
			if (id_subUiVisibilityChanged_Z == IntPtr.Zero)
				id_subUiVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "subUiVisibilityChanged", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_subUiVisibilityChanged_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_subUiVisibilityChanged_Z, new JValue (p0));
		}

#region "Event implementation for ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListener"
		public event EventHandler<global::ActionBar_Sherlock.View.ActionProvider.SubUiVisibilityEventArgs> SubUiVisibility {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListener, global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListenerImplementor>(
						ref weak_implementor_SetSubUiVisibilityListener,
						__CreateISubUiVisibilityListenerImplementor,
						SetSubUiVisibilityListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListener, global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListenerImplementor>(
						ref weak_implementor_SetSubUiVisibilityListener,
						global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListenerImplementor.__IsEmpty,
						SetSubUiVisibilityListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetSubUiVisibilityListener;

		global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListenerImplementor __CreateISubUiVisibilityListenerImplementor ()
		{
			return new global::ActionBar_Sherlock.View.ActionProvider.ISubUiVisibilityListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/view/ActionProvider", DoNotGenerateAcw=true)]
	internal partial class ActionProviderInvoker : ActionProvider {

		public ActionProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionProviderInvoker); }
		}

		static IntPtr id_onCreateActionView;
		[Register ("onCreateActionView", "()Landroid/view/View;", "GetOnCreateActionViewHandler")]
		public override global::Android.Views.View OnCreateActionView ()
		{
			if (id_onCreateActionView == IntPtr.Zero)
				id_onCreateActionView = JNIEnv.GetMethodID (class_ref, "onCreateActionView", "()Landroid/view/View;");
			return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_onCreateActionView), JniHandleOwnership.TransferLocalRef);
		}

	}

}
