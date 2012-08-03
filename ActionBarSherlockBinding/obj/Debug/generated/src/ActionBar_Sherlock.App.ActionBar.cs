using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ActionBar_Sherlock.App {

	[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar", DoNotGenerateAcw=true)]
	public abstract partial class ActionBar : global::Java.Lang.Object {


		[Register ("DISPLAY_HOME_AS_UP")]
		public const int DisplayHomeAsUp = (int) 4;

		[Register ("DISPLAY_SHOW_CUSTOM")]
		public const int DisplayShowCustom = (int) 16;

		[Register ("DISPLAY_SHOW_HOME")]
		public const int DisplayShowHome = (int) 2;

		[Register ("DISPLAY_SHOW_TITLE")]
		public const int DisplayShowTitle = (int) 8;

		[Register ("DISPLAY_USE_LOGO")]
		public const int DisplayUseLogo = (int) 1;

		[Register ("NAVIGATION_MODE_LIST")]
		public const int NavigationModeList = (int) 1;

		[Register ("NAVIGATION_MODE_STANDARD")]
		public const int NavigationModeStandard = (int) 0;

		[Register ("NAVIGATION_MODE_TABS")]
		public const int NavigationModeTabs = (int) 2;
		[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams {


			static IntPtr gravity_jfieldId;

			[Register ("gravity")]
			public int Gravity {
				get {
					if (gravity_jfieldId == IntPtr.Zero)
						gravity_jfieldId = JNIEnv.GetFieldID (class_ref, "gravity", "I");
					return JNIEnv.GetIntField (Handle, gravity_jfieldId);
				}
				set {
					if (gravity_jfieldId == IntPtr.Zero)
						gravity_jfieldId = JNIEnv.GetFieldID (class_ref, "gravity", "I");
					JNIEnv.SetField (Handle, gravity_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/actionbarsherlock/app/ActionBar$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public LayoutParams (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_II;
			[Register (".ctor", "(II)V", "")]
			public LayoutParams (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_III;
			[Register (".ctor", "(III)V", "")]
			public LayoutParams (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(III)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_III, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_I;
			[Register (".ctor", "(I)V", "")]
			public LayoutParams (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_;
			[Register (".ctor", "(Lcom/actionbarsherlock/app/ActionBar$LayoutParams;)V", "")]
			public LayoutParams (global::ActionBar_Sherlock.App.ActionBar.LayoutParams p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/actionbarsherlock/app/ActionBar$LayoutParams;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ == IntPtr.Zero)
					id_ctor_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/actionbarsherlock/app/ActionBar$LayoutParams;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_Landroid_view_ViewGroup_LayoutParams_;
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public LayoutParams (global::Android.Views.ViewGroup.LayoutParams p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/view/ViewGroup$LayoutParams;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
					id_ctor_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		[Register ("com/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener", "", "ActionBar_Sherlock.App.ActionBar/IOnMenuVisibilityListenerInvoker")]
		public partial interface IOnMenuVisibilityListener : IJavaObject {

			[Register ("onMenuVisibilityChanged", "(Z)V", "GetOnMenuVisibilityChanged_ZHandler:ActionBar_Sherlock.App.ActionBar/IOnMenuVisibilityListenerInvoker, ActionBarSherlockBinding")]
			void OnMenuVisibilityChanged (bool p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener", DoNotGenerateAcw=true)]
		internal class IOnMenuVisibilityListenerInvoker : Java.Lang.Object, IOnMenuVisibilityListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener");
			IntPtr class_ref;

			public static IOnMenuVisibilityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnMenuVisibilityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.app.ActionBar.OnMenuVisibilityListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMenuVisibilityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMenuVisibilityListenerInvoker); }
			}

			static Delegate cb_onMenuVisibilityChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnMenuVisibilityChanged_ZHandler ()
			{
				if (cb_onMenuVisibilityChanged_Z == null)
					cb_onMenuVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnMenuVisibilityChanged_Z);
				return cb_onMenuVisibilityChanged_Z;
			}

			static void n_OnMenuVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				IOnMenuVisibilityListener __this = Java.Lang.Object.GetObject<IOnMenuVisibilityListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMenuVisibilityChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMenuVisibilityChanged_Z;
			public void OnMenuVisibilityChanged (bool p0)
			{
				if (id_onMenuVisibilityChanged_Z == IntPtr.Zero)
					id_onMenuVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onMenuVisibilityChanged", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onMenuVisibilityChanged_Z, new JValue (p0));
			}

		}

		public partial class MenuVisibilityEventArgs : global::System.EventArgs {

			public MenuVisibilityEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/app/ActionBar_OnMenuVisibilityListenerImplementor")]
		internal sealed class IOnMenuVisibilityListenerImplementor : Java.Lang.Object, IOnMenuVisibilityListener {

			object sender;

			public IOnMenuVisibilityListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/app/ActionBar_OnMenuVisibilityListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MenuVisibilityEventArgs> Handler;
#pragma warning restore 0649

			public void OnMenuVisibilityChanged (bool p0)
			{
				if (Handler != null)
					Handler (sender, new MenuVisibilityEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMenuVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/actionbarsherlock/app/ActionBar$OnNavigationListener", "", "ActionBar_Sherlock.App.ActionBar/IOnNavigationListenerInvoker")]
		public partial interface IOnNavigationListener : IJavaObject {

			[Register ("onNavigationItemSelected", "(IJ)Z", "GetOnNavigationItemSelected_IJHandler:ActionBar_Sherlock.App.ActionBar/IOnNavigationListenerInvoker, ActionBarSherlockBinding")]
			bool OnNavigationItemSelected (int p0, long p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar$OnNavigationListener", DoNotGenerateAcw=true)]
		internal class IOnNavigationListenerInvoker : Java.Lang.Object, IOnNavigationListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/app/ActionBar$OnNavigationListener");
			IntPtr class_ref;

			public static IOnNavigationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IOnNavigationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.app.ActionBar.OnNavigationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnNavigationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnNavigationListenerInvoker); }
			}

			static Delegate cb_onNavigationItemSelected_IJ;
#pragma warning disable 0169
			static Delegate GetOnNavigationItemSelected_IJHandler ()
			{
				if (cb_onNavigationItemSelected_IJ == null)
					cb_onNavigationItemSelected_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, bool>) n_OnNavigationItemSelected_IJ);
				return cb_onNavigationItemSelected_IJ;
			}

			static bool n_OnNavigationItemSelected_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				IOnNavigationListener __this = Java.Lang.Object.GetObject<IOnNavigationListener> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnNavigationItemSelected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onNavigationItemSelected_IJ;
			public bool OnNavigationItemSelected (int p0, long p1)
			{
				if (id_onNavigationItemSelected_IJ == IntPtr.Zero)
					id_onNavigationItemSelected_IJ = JNIEnv.GetMethodID (class_ref, "onNavigationItemSelected", "(IJ)Z");
				return JNIEnv.CallBooleanMethod (Handle, id_onNavigationItemSelected_IJ, new JValue (p0), new JValue (p1));
			}

		}

		public partial class NavigationEventArgs : global::System.EventArgs {

			public NavigationEventArgs (bool handled, int p0, long p1)
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

			long p1;
			public long P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/app/ActionBar_OnNavigationListenerImplementor")]
		internal sealed class IOnNavigationListenerImplementor : Java.Lang.Object, IOnNavigationListener {

			object sender;

			public IOnNavigationListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/app/ActionBar_OnNavigationListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NavigationEventArgs> Handler;
#pragma warning restore 0649

			public bool OnNavigationItemSelected (int p0, long p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new NavigationEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnNavigationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar$Tab", DoNotGenerateAcw=true)]
		public abstract partial class Tab : global::Java.Lang.Object {


			[Register ("INVALID_POSITION")]
			public const int InvalidPosition = (int) -1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/actionbarsherlock/app/ActionBar$Tab", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tab); }
			}

			protected Tab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public Tab () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Tab)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getContentDescription;
#pragma warning disable 0169
			static Delegate GetGetContentDescriptionHandler ()
			{
				if (cb_getContentDescription == null)
					cb_getContentDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDescription);
				return cb_getContentDescription;
			}

			static IntPtr n_GetContentDescription (IntPtr jnienv, IntPtr native__this)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.ContentDescriptionFormatted);
			}
#pragma warning restore 0169

			public abstract global::Java.Lang.ICharSequence ContentDescriptionFormatted { [Register ("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")] get; }

			public string ContentDescription {
				get { return ContentDescriptionFormatted == null ? null : ContentDescriptionFormatted.ToString (); }
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
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CustomView);
			}
#pragma warning restore 0169

			public abstract global::Android.Views.View CustomView { [Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get; }

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
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Icon);
			}
#pragma warning restore 0169

			public abstract global::Android.Graphics.Drawables.Drawable Icon { [Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")] get; }

			static Delegate cb_getPosition;
#pragma warning disable 0169
			static Delegate GetGetPositionHandler ()
			{
				if (cb_getPosition == null)
					cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosition);
				return cb_getPosition;
			}

			static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Position;
			}
#pragma warning restore 0169

			public abstract int Position { [Register ("getPosition", "()I", "GetGetPositionHandler")] get; }

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
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Tag);
			}
#pragma warning restore 0169

			public abstract global::Java.Lang.Object Tag { [Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")] get; }

			static Delegate cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.TextFormatted);
			}
#pragma warning restore 0169

			public abstract global::Java.Lang.ICharSequence TextFormatted { [Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")] get; }

			public string Text {
				get { return TextFormatted == null ? null : TextFormatted.ToString (); }
			}

			static Delegate cb_select;
#pragma warning disable 0169
			static Delegate GetSelectHandler ()
			{
				if (cb_select == null)
					cb_select = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Select);
				return cb_select;
			}

			static void n_Select (IntPtr jnienv, IntPtr native__this)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.Select ();
			}
#pragma warning restore 0169

			[Register ("select", "()V", "GetSelectHandler")]
			public abstract void Select ();

			static Delegate cb_setContentDescription_I;
#pragma warning disable 0169
			static Delegate GetSetContentDescription_IHandler ()
			{
				if (cb_setContentDescription_I == null)
					cb_setContentDescription_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetContentDescription_I);
				return cb_setContentDescription_I;
			}

			static IntPtr n_SetContentDescription_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetContentDescription (p0));
			}
#pragma warning restore 0169

			[Register ("setContentDescription", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetContentDescription_IHandler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetContentDescription (int p0);

			static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setContentDescription_Ljava_lang_CharSequence_ == null)
					cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentDescription_Ljava_lang_CharSequence_);
				return cb_setContentDescription_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentDescription (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("setContentDescription", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetContentDescription (global::Java.Lang.ICharSequence p0);

			public global::ActionBar_Sherlock.App.ActionBar.Tab SetContentDescription (string p0)
			{
				Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
				global::ActionBar_Sherlock.App.ActionBar.Tab __result = SetContentDescription (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setCustomView_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetSetCustomView_Landroid_view_View_Handler ()
			{
				if (cb_setCustomView_Landroid_view_View_ == null)
					cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_);
				return cb_setCustomView_Landroid_view_View_;
			}

			static IntPtr n_SetCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomView (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("setCustomView", "(Landroid/view/View;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetCustomView (global::Android.Views.View p0);

			static Delegate cb_setCustomView_I;
#pragma warning disable 0169
			static Delegate GetSetCustomView_IHandler ()
			{
				if (cb_setCustomView_I == null)
					cb_setCustomView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetCustomView_I);
				return cb_setCustomView_I;
			}

			static IntPtr n_SetCustomView_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCustomView (p0));
			}
#pragma warning restore 0169

			[Register ("setCustomView", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetCustomView_IHandler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetCustomView (int p0);

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
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetIcon (global::Android.Graphics.Drawables.Drawable p0);

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
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
			}
#pragma warning restore 0169

			[Register ("setIcon", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetIcon_IHandler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetIcon (int p0);

			static Delegate cb_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_;
#pragma warning disable 0169
			static Delegate GetSetTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_Handler ()
			{
				if (cb_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_ == null)
					cb_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_);
				return cb_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_;
			}

			static IntPtr n_SetTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.App.ActionBar.ITabListener p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.ITabListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTabListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("setTabListener", "(Lcom/actionbarsherlock/app/ActionBar$TabListener;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_Handler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetTabListener (global::ActionBar_Sherlock.App.ActionBar.ITabListener p0);

			static Delegate cb_setTag_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetTag_Ljava_lang_Object_Handler ()
			{
				if (cb_setTag_Ljava_lang_Object_ == null)
					cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_Object_);
				return cb_setTag_Ljava_lang_Object_;
			}

			static IntPtr n_SetTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("setTag", "(Ljava/lang/Object;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetTag (global::Java.Lang.Object p0);

			static Delegate cb_setText_I;
#pragma warning disable 0169
			static Delegate GetSetText_IHandler ()
			{
				if (cb_setText_I == null)
					cb_setText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetText_I);
				return cb_setText_I;
			}

			static IntPtr n_SetText_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetText (p0));
			}
#pragma warning restore 0169

			[Register ("setText", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetText_IHandler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetText (int p0);

			static Delegate cb_setText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetText_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setText_Ljava_lang_CharSequence_ == null)
					cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_CharSequence_);
				return cb_setText_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Tab __this = Java.Lang.Object.GetObject<Tab> (native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.ICharSequence p0 = Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetText (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("setText", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SetText (global::Java.Lang.ICharSequence p0);

			public global::ActionBar_Sherlock.App.ActionBar.Tab SetText (string p0)
			{
				Java.Lang.String jls_p0 = p0 == null ? null : new Java.Lang.String (p0);
				global::ActionBar_Sherlock.App.ActionBar.Tab __result = SetText (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar$Tab", DoNotGenerateAcw=true)]
		internal partial class TabInvoker : Tab {

			public TabInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TabInvoker); }
			}

			static IntPtr id_getContentDescription;
			public override global::Java.Lang.ICharSequence ContentDescriptionFormatted {
				[Register ("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")]
				get {
					if (id_getContentDescription == IntPtr.Zero)
						id_getContentDescription = JNIEnv.GetMethodID (class_ref, "getContentDescription", "()Ljava/lang/CharSequence;");
					return Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getContentDescription), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getCustomView;
			public override global::Android.Views.View CustomView {
				[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
				get {
					if (id_getCustomView == IntPtr.Zero)
						id_getCustomView = JNIEnv.GetMethodID (class_ref, "getCustomView", "()Landroid/view/View;");
					return Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getCustomView), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getIcon;
			public override global::Android.Graphics.Drawables.Drawable Icon {
				[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
				get {
					if (id_getIcon == IntPtr.Zero)
						id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Landroid/graphics/drawable/Drawable;");
					return Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getPosition;
			public override int Position {
				[Register ("getPosition", "()I", "GetGetPositionHandler")]
				get {
					if (id_getPosition == IntPtr.Zero)
						id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getPosition);
				}
			}

			static IntPtr id_getTag;
			public override global::Java.Lang.Object Tag {
				[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
				get {
					if (id_getTag == IntPtr.Zero)
						id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");
					return Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getText;
			public override global::Java.Lang.ICharSequence TextFormatted {
				[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
				get {
					if (id_getText == IntPtr.Zero)
						id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/CharSequence;");
					return Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_select;
			[Register ("select", "()V", "GetSelectHandler")]
			public override void Select ()
			{
				if (id_select == IntPtr.Zero)
					id_select = JNIEnv.GetMethodID (class_ref, "select", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_select);
			}

			static IntPtr id_setContentDescription_I;
			[Register ("setContentDescription", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetContentDescription_IHandler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetContentDescription (int p0)
			{
				if (id_setContentDescription_I == IntPtr.Zero)
					id_setContentDescription_I = JNIEnv.GetMethodID (class_ref, "setContentDescription", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setContentDescription_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setContentDescription_Ljava_lang_CharSequence_;
			[Register ("setContentDescription", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetContentDescription (global::Java.Lang.ICharSequence p0)
			{
				if (id_setContentDescription_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setContentDescription_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setContentDescription", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				global::ActionBar_Sherlock.App.ActionBar.Tab __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setContentDescription_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setCustomView_Landroid_view_View_;
			[Register ("setCustomView", "(Landroid/view/View;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetCustomView (global::Android.Views.View p0)
			{
				if (id_setCustomView_Landroid_view_View_ == IntPtr.Zero)
					id_setCustomView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				global::ActionBar_Sherlock.App.ActionBar.Tab __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setCustomView_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setCustomView_I;
			[Register ("setCustomView", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetCustomView_IHandler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetCustomView (int p0)
			{
				if (id_setCustomView_I == IntPtr.Zero)
					id_setCustomView_I = JNIEnv.GetMethodID (class_ref, "setCustomView", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setCustomView_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetIcon (global::Android.Graphics.Drawables.Drawable p0)
			{
				if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				global::ActionBar_Sherlock.App.ActionBar.Tab __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setIcon_I;
			[Register ("setIcon", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetIcon_IHandler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetIcon (int p0)
			{
				if (id_setIcon_I == IntPtr.Zero)
					id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setIcon_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_;
			[Register ("setTabListener", "(Lcom/actionbarsherlock/app/ActionBar$TabListener;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_Handler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetTabListener (global::ActionBar_Sherlock.App.ActionBar.ITabListener p0)
			{
				if (id_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_ == IntPtr.Zero)
					id_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_ = JNIEnv.GetMethodID (class_ref, "setTabListener", "(Lcom/actionbarsherlock/app/ActionBar$TabListener;)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				global::ActionBar_Sherlock.App.ActionBar.Tab __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setTabListener_Lcom_actionbarsherlock_app_ActionBar_TabListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setTag_Ljava_lang_Object_;
			[Register ("setTag", "(Ljava/lang/Object;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetTag (global::Java.Lang.Object p0)
			{
				if (id_setTag_Ljava_lang_Object_ == IntPtr.Zero)
					id_setTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/Object;)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				global::ActionBar_Sherlock.App.ActionBar.Tab __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setTag_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setText_I;
			[Register ("setText", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetText_IHandler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetText (int p0)
			{
				if (id_setText_I == IntPtr.Zero)
					id_setText_I = JNIEnv.GetMethodID (class_ref, "setText", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setText_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setText_Ljava_lang_CharSequence_;
			[Register ("setText", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public override global::ActionBar_Sherlock.App.ActionBar.Tab SetText (global::Java.Lang.ICharSequence p0)
			{
				if (id_setText_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setText_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/CharSequence;)Lcom/actionbarsherlock/app/ActionBar$Tab;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				global::ActionBar_Sherlock.App.ActionBar.Tab __ret = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setText_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		[Register ("com/actionbarsherlock/app/ActionBar$TabListener", "", "ActionBar_Sherlock.App.ActionBar/ITabListenerInvoker")]
		public partial interface ITabListener : IJavaObject {

			[Register ("onTabReselected", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V", "GetOnTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler:ActionBar_Sherlock.App.ActionBar/ITabListenerInvoker, ActionBarSherlockBinding")]
			void OnTabReselected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1);

			[Register ("onTabSelected", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V", "GetOnTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler:ActionBar_Sherlock.App.ActionBar/ITabListenerInvoker, ActionBarSherlockBinding")]
			void OnTabSelected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1);

			[Register ("onTabUnselected", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V", "GetOnTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler:ActionBar_Sherlock.App.ActionBar/ITabListenerInvoker, ActionBarSherlockBinding")]
			void OnTabUnselected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar$TabListener", DoNotGenerateAcw=true)]
		internal class ITabListenerInvoker : Java.Lang.Object, ITabListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/app/ActionBar$TabListener");
			IntPtr class_ref;

			public static ITabListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ITabListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.app.ActionBar.TabListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITabListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ITabListenerInvoker); }
			}

			static Delegate cb_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
#pragma warning disable 0169
			static Delegate GetOnTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler ()
			{
				if (cb_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ == null)
					cb_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_);
				return cb_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
			}

			static void n_OnTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ITabListener __this = Java.Lang.Object.GetObject<ITabListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.App.FragmentTransaction p1 = Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentTransaction> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTabReselected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
			public void OnTabReselected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				if (id_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ == IntPtr.Zero)
					id_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ = JNIEnv.GetMethodID (class_ref, "onTabReselected", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V");
				JNIEnv.CallVoidMethod (Handle, id_onTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
#pragma warning disable 0169
			static Delegate GetOnTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler ()
			{
				if (cb_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ == null)
					cb_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_);
				return cb_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
			}

			static void n_OnTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ITabListener __this = Java.Lang.Object.GetObject<ITabListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.App.FragmentTransaction p1 = Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentTransaction> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTabSelected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
			public void OnTabSelected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				if (id_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ == IntPtr.Zero)
					id_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ = JNIEnv.GetMethodID (class_ref, "onTabSelected", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V");
				JNIEnv.CallVoidMethod (Handle, id_onTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
#pragma warning disable 0169
			static Delegate GetOnTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler ()
			{
				if (cb_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ == null)
					cb_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_);
				return cb_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
			}

			static void n_OnTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ITabListener __this = Java.Lang.Object.GetObject<ITabListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.App.FragmentTransaction p1 = Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentTransaction> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTabUnselected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_;
			public void OnTabUnselected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				if (id_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ == IntPtr.Zero)
					id_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_ = JNIEnv.GetMethodID (class_ref, "onTabUnselected", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V");
				JNIEnv.CallVoidMethod (Handle, id_onTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class TabReselectedEventArgs : global::System.EventArgs {

			public TabReselectedEventArgs (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::ActionBar_Sherlock.App.ActionBar.Tab p0;
			public global::ActionBar_Sherlock.App.ActionBar.Tab P0 {
				get { return p0; }
			}

			global::Android.Support.V4.App.FragmentTransaction p1;
			public global::Android.Support.V4.App.FragmentTransaction P1 {
				get { return p1; }
			}
		}

		public partial class TabSelectedEventArgs : global::System.EventArgs {

			public TabSelectedEventArgs (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::ActionBar_Sherlock.App.ActionBar.Tab p0;
			public global::ActionBar_Sherlock.App.ActionBar.Tab P0 {
				get { return p0; }
			}

			global::Android.Support.V4.App.FragmentTransaction p1;
			public global::Android.Support.V4.App.FragmentTransaction P1 {
				get { return p1; }
			}
		}

		public partial class TabUnselectedEventArgs : global::System.EventArgs {

			public TabUnselectedEventArgs (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::ActionBar_Sherlock.App.ActionBar.Tab p0;
			public global::ActionBar_Sherlock.App.ActionBar.Tab P0 {
				get { return p0; }
			}

			global::Android.Support.V4.App.FragmentTransaction p1;
			public global::Android.Support.V4.App.FragmentTransaction P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/app/ActionBar_TabListenerImplementor")]
		internal sealed class ITabListenerImplementor : Java.Lang.Object, ITabListener {

			object sender;

			public ITabListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/app/ActionBar_TabListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TabReselectedEventArgs> OnTabReselectedHandler;
#pragma warning restore 0649

			public void OnTabReselected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				if (OnTabReselectedHandler != null)
					OnTabReselectedHandler (sender, new TabReselectedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<TabSelectedEventArgs> OnTabSelectedHandler;
#pragma warning restore 0649

			public void OnTabSelected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				if (OnTabSelectedHandler != null)
					OnTabSelectedHandler (sender, new TabSelectedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<TabUnselectedEventArgs> OnTabUnselectedHandler;
#pragma warning restore 0649

			public void OnTabUnselected (global::ActionBar_Sherlock.App.ActionBar.Tab p0, global::Android.Support.V4.App.FragmentTransaction p1)
			{
				if (OnTabUnselectedHandler != null)
					OnTabUnselectedHandler (sender, new TabUnselectedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (ITabListenerImplementor value)
			{
				return value.OnTabReselectedHandler == null && value.OnTabSelectedHandler == null && value.OnTabUnselectedHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/app/ActionBar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBar); }
		}

		protected ActionBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public ActionBar () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActionBar)) {
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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomView = p0;
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View CustomView { [Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get; [Register ("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")] set; }

		static Delegate cb_getDisplayOptions;
#pragma warning disable 0169
		static Delegate GetGetDisplayOptionsHandler ()
		{
			if (cb_getDisplayOptions == null)
				cb_getDisplayOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayOptions);
			return cb_getDisplayOptions;
		}

		static int n_GetDisplayOptions (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayOptions;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayOptions_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOptions_IHandler ()
		{
			if (cb_setDisplayOptions_I == null)
				cb_setDisplayOptions_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayOptions_I);
			return cb_setDisplayOptions_I;
		}

		static void n_SetDisplayOptions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayOptions = p0;
		}
#pragma warning restore 0169

		public abstract int DisplayOptions { [Register ("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")] get; [Register ("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")] set; }

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public abstract int Height { [Register ("getHeight", "()I", "GetGetHeightHandler")] get; }

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		public abstract bool IsShowing { [Register ("isShowing", "()Z", "GetIsShowingHandler")] get; }

		static Delegate cb_getNavigationItemCount;
#pragma warning disable 0169
		static Delegate GetGetNavigationItemCountHandler ()
		{
			if (cb_getNavigationItemCount == null)
				cb_getNavigationItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationItemCount);
			return cb_getNavigationItemCount;
		}

		static int n_GetNavigationItemCount (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationItemCount;
		}
#pragma warning restore 0169

		public abstract int NavigationItemCount { [Register ("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")] get; }

		static Delegate cb_getNavigationMode;
#pragma warning disable 0169
		static Delegate GetGetNavigationModeHandler ()
		{
			if (cb_getNavigationMode == null)
				cb_getNavigationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationMode);
			return cb_getNavigationMode;
		}

		static int n_GetNavigationMode (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationMode;
		}
#pragma warning restore 0169

		static Delegate cb_setNavigationMode_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationMode_IHandler ()
		{
			if (cb_setNavigationMode_I == null)
				cb_setNavigationMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavigationMode_I);
			return cb_setNavigationMode_I;
		}

		static void n_SetNavigationMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.NavigationMode = p0;
		}
#pragma warning restore 0169

		public abstract int NavigationMode { [Register ("getNavigationMode", "()I", "GetGetNavigationModeHandler")] get; [Register ("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")] set; }

		static Delegate cb_getSelectedNavigationIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedNavigationIndexHandler ()
		{
			if (cb_getSelectedNavigationIndex == null)
				cb_getSelectedNavigationIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedNavigationIndex);
			return cb_getSelectedNavigationIndex;
		}

		static int n_GetSelectedNavigationIndex (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedNavigationIndex;
		}
#pragma warning restore 0169

		public abstract int SelectedNavigationIndex { [Register ("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")] get; }

		static Delegate cb_getSelectedTab;
#pragma warning disable 0169
		static Delegate GetGetSelectedTabHandler ()
		{
			if (cb_getSelectedTab == null)
				cb_getSelectedTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedTab);
			return cb_getSelectedTab;
		}

		static IntPtr n_GetSelectedTab (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedTab);
		}
#pragma warning restore 0169

		public abstract global::ActionBar_Sherlock.App.ActionBar.Tab SelectedTab { [Register ("getSelectedTab", "()Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetGetSelectedTabHandler")] get; }

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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getTabCount;
#pragma warning disable 0169
		static Delegate GetGetTabCountHandler ()
		{
			if (cb_getTabCount == null)
				cb_getTabCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabCount);
			return cb_getTabCount;
		}

		static int n_GetTabCount (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabCount;
		}
#pragma warning restore 0169

		public abstract int TabCount { [Register ("getTabCount", "()I", "GetGetTabCountHandler")] get; }

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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThemedContext);
		}
#pragma warning restore 0169

		static IntPtr id_getThemedContext;
		public virtual global::Android.Content.Context ThemedContext {
			[Register ("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")]
			get {
				if (id_getThemedContext == IntPtr.Zero)
					id_getThemedContext = JNIEnv.GetMethodID (class_ref, "getThemedContext", "()Landroid/content/Context;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getThemedContext), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getThemedContext), JniHandleOwnership.TransferLocalRef);
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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetAddOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_Handler ()
		{
			if (cb_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ == null)
				cb_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_);
			return cb_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_;
		}

		static void n_AddOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnMenuVisibilityListener (p0);
		}
#pragma warning restore 0169

		[Register ("addOnMenuVisibilityListener", "(Lcom/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public abstract void AddOnMenuVisibilityListener (global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener p0);

		static Delegate cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler ()
		{
			if (cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ == null)
				cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_);
			return cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
		}

		static void n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0);
		}
#pragma warning restore 0169

		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler")]
		public abstract void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0);

		static Delegate cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z;
#pragma warning disable 0169
		static Delegate GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ZHandler ()
		{
			if (cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z == null)
				cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z);
			return cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z;
		}

		static void n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1);
		}
#pragma warning restore 0169

		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Z)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ZHandler")]
		public abstract void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0, bool p1);

		static Delegate cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I;
#pragma warning disable 0169
		static Delegate GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IHandler ()
		{
			if (cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I == null)
				cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I);
			return cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I;
		}

		static void n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1);
		}
#pragma warning restore 0169

		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;I)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IHandler")]
		public abstract void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0, int p1);

		static Delegate cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ;
#pragma warning disable 0169
		static Delegate GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZHandler ()
		{
			if (cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ == null)
				cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ);
			return cb_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ;
		}

		static void n_AddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1, p2);
		}
#pragma warning restore 0169

		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;IZ)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZHandler")]
		public abstract void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0, int p1, bool p2);

		static Delegate cb_getTabAt_I;
#pragma warning disable 0169
		static Delegate GetGetTabAt_IHandler ()
		{
			if (cb_getTabAt_I == null)
				cb_getTabAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTabAt_I);
			return cb_getTabAt_I;
		}

		static IntPtr n_GetTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTabAt (p0));
		}
#pragma warning restore 0169

		[Register ("getTabAt", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public abstract global::ActionBar_Sherlock.App.ActionBar.Tab GetTabAt (int p0);

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		[Register ("hide", "()V", "GetHideHandler")]
		public abstract void Hide ();

		static Delegate cb_newTab;
#pragma warning disable 0169
		static Delegate GetNewTabHandler ()
		{
			if (cb_newTab == null)
				cb_newTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewTab);
			return cb_newTab;
		}

		static IntPtr n_NewTab (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewTab ());
		}
#pragma warning restore 0169

		[Register ("newTab", "()Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetNewTabHandler")]
		public abstract global::ActionBar_Sherlock.App.ActionBar.Tab NewTab ();

		static Delegate cb_removeAllTabs;
#pragma warning disable 0169
		static Delegate GetRemoveAllTabsHandler ()
		{
			if (cb_removeAllTabs == null)
				cb_removeAllTabs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllTabs);
			return cb_removeAllTabs;
		}

		static void n_RemoveAllTabs (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllTabs ();
		}
#pragma warning restore 0169

		[Register ("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public abstract void RemoveAllTabs ();

		static Delegate cb_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_Handler ()
		{
			if (cb_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ == null)
				cb_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_);
			return cb_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_;
		}

		static void n_RemoveOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnMenuVisibilityListener (p0);
		}
#pragma warning restore 0169

		[Register ("removeOnMenuVisibilityListener", "(Lcom/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public abstract void RemoveOnMenuVisibilityListener (global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener p0);

		static Delegate cb_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetRemoveTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler ()
		{
			if (cb_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ == null)
				cb_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTab_Lcom_actionbarsherlock_app_ActionBar_Tab_);
			return cb_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
		}

		static void n_RemoveTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTab (p0);
		}
#pragma warning restore 0169

		[Register ("removeTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V", "GetRemoveTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler")]
		public abstract void RemoveTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0);

		static Delegate cb_removeTabAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveTabAt_IHandler ()
		{
			if (cb_removeTabAt_I == null)
				cb_removeTabAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveTabAt_I);
			return cb_removeTabAt_I;
		}

		static void n_RemoveTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTabAt (p0);
		}
#pragma warning restore 0169

		[Register ("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public abstract void RemoveTabAt (int p0);

		static Delegate cb_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetSelectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler ()
		{
			if (cb_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ == null)
				cb_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_);
			return cb_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
		}

		static void n_SelectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.Tab p0 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectTab (p0);
		}
#pragma warning restore 0169

		[Register ("selectTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V", "GetSelectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler")]
		public abstract void SelectTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0);

		static Delegate cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_Handler ()
		{
			if (cb_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ == null)
				cb_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_);
			return cb_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_;
		}

		static void n_SetCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.LayoutParams p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomView (p0, p1);
		}
#pragma warning restore 0169

		[Register ("setCustomView", "(Landroid/view/View;Lcom/actionbarsherlock/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_Handler")]
		public abstract void SetCustomView (global::Android.Views.View p0, global::ActionBar_Sherlock.App.ActionBar.LayoutParams p1);

		static Delegate cb_setCustomView_I;
#pragma warning disable 0169
		static Delegate GetSetCustomView_IHandler ()
		{
			if (cb_setCustomView_I == null)
				cb_setCustomView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCustomView_I);
			return cb_setCustomView_I;
		}

		static void n_SetCustomView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomView (p0);
		}
#pragma warning restore 0169

		[Register ("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public abstract void SetCustomView (int p0);

		static Delegate cb_setDisplayHomeAsUpEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayHomeAsUpEnabled_ZHandler ()
		{
			if (cb_setDisplayHomeAsUpEnabled_Z == null)
				cb_setDisplayHomeAsUpEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayHomeAsUpEnabled_Z);
			return cb_setDisplayHomeAsUpEnabled_Z;
		}

		static void n_SetDisplayHomeAsUpEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayHomeAsUpEnabled (p0);
		}
#pragma warning restore 0169

		[Register ("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public abstract void SetDisplayHomeAsUpEnabled (bool p0);

		static Delegate cb_setDisplayOptions_II;
#pragma warning disable 0169
		static Delegate GetSetDisplayOptions_IIHandler ()
		{
			if (cb_setDisplayOptions_II == null)
				cb_setDisplayOptions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetDisplayOptions_II);
			return cb_setDisplayOptions_II;
		}

		static void n_SetDisplayOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayOptions (p0, p1);
		}
#pragma warning restore 0169

		[Register ("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public abstract void SetDisplayOptions (int p0, int p1);

		static Delegate cb_setDisplayShowCustomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowCustomEnabled_ZHandler ()
		{
			if (cb_setDisplayShowCustomEnabled_Z == null)
				cb_setDisplayShowCustomEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowCustomEnabled_Z);
			return cb_setDisplayShowCustomEnabled_Z;
		}

		static void n_SetDisplayShowCustomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowCustomEnabled (p0);
		}
#pragma warning restore 0169

		[Register ("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public abstract void SetDisplayShowCustomEnabled (bool p0);

		static Delegate cb_setDisplayShowHomeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowHomeEnabled_ZHandler ()
		{
			if (cb_setDisplayShowHomeEnabled_Z == null)
				cb_setDisplayShowHomeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowHomeEnabled_Z);
			return cb_setDisplayShowHomeEnabled_Z;
		}

		static void n_SetDisplayShowHomeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowHomeEnabled (p0);
		}
#pragma warning restore 0169

		[Register ("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public abstract void SetDisplayShowHomeEnabled (bool p0);

		static Delegate cb_setDisplayShowTitleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowTitleEnabled_ZHandler ()
		{
			if (cb_setDisplayShowTitleEnabled_Z == null)
				cb_setDisplayShowTitleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowTitleEnabled_Z);
			return cb_setDisplayShowTitleEnabled_Z;
		}

		static void n_SetDisplayShowTitleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowTitleEnabled (p0);
		}
#pragma warning restore 0169

		[Register ("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public abstract void SetDisplayShowTitleEnabled (bool p0);

		static Delegate cb_setDisplayUseLogoEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayUseLogoEnabled_ZHandler ()
		{
			if (cb_setDisplayUseLogoEnabled_Z == null)
				cb_setDisplayUseLogoEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayUseLogoEnabled_Z);
			return cb_setDisplayUseLogoEnabled_Z;
		}

		static void n_SetDisplayUseLogoEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayUseLogoEnabled (p0);
		}
#pragma warning restore 0169

		[Register ("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public abstract void SetDisplayUseLogoEnabled (bool p0);

		static Delegate cb_setHomeButtonEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHomeButtonEnabled_ZHandler ()
		{
			if (cb_setHomeButtonEnabled_Z == null)
				cb_setHomeButtonEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHomeButtonEnabled_Z);
			return cb_setHomeButtonEnabled_Z;
		}

		static void n_SetHomeButtonEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHomeButtonEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHomeButtonEnabled_Z;
		[Register ("setHomeButtonEnabled", "(Z)V", "GetSetHomeButtonEnabled_ZHandler")]
		public virtual void SetHomeButtonEnabled (bool p0)
		{
			if (id_setHomeButtonEnabled_Z == IntPtr.Zero)
				id_setHomeButtonEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHomeButtonEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHomeButtonEnabled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setHomeButtonEnabled_Z, new JValue (p0));
		}

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetIcon (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public abstract void SetIcon (int p0);

		static Delegate cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_;
#pragma warning disable 0169
		static Delegate GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_Handler ()
		{
			if (cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_ == null)
				cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_);
			return cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_;
		}

		static void n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ISpinnerAdapter p0 = Java.Lang.Object.GetObject<global::Android.Widget.ISpinnerAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::ActionBar_Sherlock.App.ActionBar.IOnNavigationListener p1 = Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.IOnNavigationListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetListNavigationCallbacks (p0, p1);
		}
#pragma warning restore 0169

		[Register ("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Lcom/actionbarsherlock/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_Handler")]
		public abstract void SetListNavigationCallbacks (global::Android.Widget.ISpinnerAdapter p0, global::ActionBar_Sherlock.App.ActionBar.IOnNavigationListener p1);

		static Delegate cb_setLogo_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetLogo_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setLogo_Landroid_graphics_drawable_Drawable_ == null)
				cb_setLogo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogo_Landroid_graphics_drawable_Drawable_);
			return cb_setLogo_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetLogo_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		[Register ("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetLogo (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_setLogo_I;
#pragma warning disable 0169
		static Delegate GetSetLogo_IHandler ()
		{
			if (cb_setLogo_I == null)
				cb_setLogo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogo_I);
			return cb_setLogo_I;
		}

		static void n_SetLogo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		[Register ("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public abstract void SetLogo (int p0);

		static Delegate cb_setSelectedNavigationItem_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedNavigationItem_IHandler ()
		{
			if (cb_setSelectedNavigationItem_I == null)
				cb_setSelectedNavigationItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedNavigationItem_I);
			return cb_setSelectedNavigationItem_I;
		}

		static void n_SetSelectedNavigationItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedNavigationItem (p0);
		}
#pragma warning restore 0169

		[Register ("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public abstract void SetSelectedNavigationItem (int p0);

		static Delegate cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSplitBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		[Register ("setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetSplitBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
		}

		static Delegate cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStackedBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		[Register ("setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetStackedBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
		}

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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
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
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public abstract void SetTitle (int p0);

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			ActionBar __this = Java.Lang.Object.GetObject<ActionBar> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		[Register ("show", "()V", "GetShowHandler")]
		public abstract void Show ();

#region "Event implementation for ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener"
		public event EventHandler<global::ActionBar_Sherlock.App.ActionBar.MenuVisibilityEventArgs> MenuVisibility {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener, global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListenerImplementor>(
						ref weak_implementor_AddOnMenuVisibilityListener,
						__CreateIOnMenuVisibilityListenerImplementor,
						AddOnMenuVisibilityListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener, global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListenerImplementor>(
						ref weak_implementor_AddOnMenuVisibilityListener,
						global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListenerImplementor.__IsEmpty,
						AddOnMenuVisibilityListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnMenuVisibilityListener;

		global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListenerImplementor __CreateIOnMenuVisibilityListenerImplementor ()
		{
			return new global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/app/ActionBar", DoNotGenerateAcw=true)]
	internal partial class ActionBarInvoker : ActionBar {

		public ActionBarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarInvoker); }
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

		static IntPtr id_getDisplayOptions;
		static IntPtr id_setDisplayOptions_I;
		public override int DisplayOptions {
			[Register ("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")]
			get {
				if (id_getDisplayOptions == IntPtr.Zero)
					id_getDisplayOptions = JNIEnv.GetMethodID (class_ref, "getDisplayOptions", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getDisplayOptions);
			}
			[Register ("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")]
			set {
				if (id_setDisplayOptions_I == IntPtr.Zero)
					id_setDisplayOptions_I = JNIEnv.GetMethodID (class_ref, "setDisplayOptions", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayOptions_I, new JValue (value));
			}
		}

		static IntPtr id_getHeight;
		public override int Height {
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getHeight);
			}
		}

		static IntPtr id_isShowing;
		public override bool IsShowing {
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isShowing);
			}
		}

		static IntPtr id_getNavigationItemCount;
		public override int NavigationItemCount {
			[Register ("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")]
			get {
				if (id_getNavigationItemCount == IntPtr.Zero)
					id_getNavigationItemCount = JNIEnv.GetMethodID (class_ref, "getNavigationItemCount", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getNavigationItemCount);
			}
		}

		static IntPtr id_getNavigationMode;
		static IntPtr id_setNavigationMode_I;
		public override int NavigationMode {
			[Register ("getNavigationMode", "()I", "GetGetNavigationModeHandler")]
			get {
				if (id_getNavigationMode == IntPtr.Zero)
					id_getNavigationMode = JNIEnv.GetMethodID (class_ref, "getNavigationMode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getNavigationMode);
			}
			[Register ("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")]
			set {
				if (id_setNavigationMode_I == IntPtr.Zero)
					id_setNavigationMode_I = JNIEnv.GetMethodID (class_ref, "setNavigationMode", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setNavigationMode_I, new JValue (value));
			}
		}

		static IntPtr id_getSelectedNavigationIndex;
		public override int SelectedNavigationIndex {
			[Register ("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")]
			get {
				if (id_getSelectedNavigationIndex == IntPtr.Zero)
					id_getSelectedNavigationIndex = JNIEnv.GetMethodID (class_ref, "getSelectedNavigationIndex", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getSelectedNavigationIndex);
			}
		}

		static IntPtr id_getSelectedTab;
		public override global::ActionBar_Sherlock.App.ActionBar.Tab SelectedTab {
			[Register ("getSelectedTab", "()Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetGetSelectedTabHandler")]
			get {
				if (id_getSelectedTab == IntPtr.Zero)
					id_getSelectedTab = JNIEnv.GetMethodID (class_ref, "getSelectedTab", "()Lcom/actionbarsherlock/app/ActionBar$Tab;");
				return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_getSelectedTab), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_getTabCount;
		public override int TabCount {
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")]
			get {
				if (id_getTabCount == IntPtr.Zero)
					id_getTabCount = JNIEnv.GetMethodID (class_ref, "getTabCount", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getTabCount);
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

		static IntPtr id_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_;
		[Register ("addOnMenuVisibilityListener", "(Lcom/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public override void AddOnMenuVisibilityListener (global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener p0)
		{
			if (id_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ == IntPtr.Zero)
				id_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "addOnMenuVisibilityListener", "(Lcom/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_, new JValue (p0));
		}

		static IntPtr id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler")]
		public override void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0)
		{
			if (id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ == IntPtr.Zero)
				id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_, new JValue (p0));
		}

		static IntPtr id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z;
		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Z)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ZHandler")]
		public override void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0, bool p1)
		{
			if (id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z == IntPtr.Zero)
				id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z = JNIEnv.GetMethodID (class_ref, "addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Z, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I;
		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;I)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IHandler")]
		public override void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0, int p1)
		{
			if (id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I == IntPtr.Zero)
				id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I = JNIEnv.GetMethodID (class_ref, "addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ;
		[Register ("addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;IZ)V", "GetAddTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZHandler")]
		public override void AddTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0, int p1, bool p2)
		{
			if (id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ == IntPtr.Zero)
				id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ = JNIEnv.GetMethodID (class_ref, "addTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;IZ)V");
			JNIEnv.CallVoidMethod  (Handle, id_addTab_Lcom_actionbarsherlock_app_ActionBar_Tab_IZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getTabAt_I;
		[Register ("getTabAt", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public override global::ActionBar_Sherlock.App.ActionBar.Tab GetTabAt (int p0)
		{
			if (id_getTabAt_I == IntPtr.Zero)
				id_getTabAt_I = JNIEnv.GetMethodID (class_ref, "getTabAt", "(I)Lcom/actionbarsherlock/app/ActionBar$Tab;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_getTabAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_hide;
		[Register ("hide", "()V", "GetHideHandler")]
		public override void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_hide);
		}

		static IntPtr id_newTab;
		[Register ("newTab", "()Lcom/actionbarsherlock/app/ActionBar$Tab;", "GetNewTabHandler")]
		public override global::ActionBar_Sherlock.App.ActionBar.Tab NewTab ()
		{
			if (id_newTab == IntPtr.Zero)
				id_newTab = JNIEnv.GetMethodID (class_ref, "newTab", "()Lcom/actionbarsherlock/app/ActionBar$Tab;");
			return Java.Lang.Object.GetObject<global::ActionBar_Sherlock.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_newTab), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_removeAllTabs;
		[Register ("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public override void RemoveAllTabs ()
		{
			if (id_removeAllTabs == IntPtr.Zero)
				id_removeAllTabs = JNIEnv.GetMethodID (class_ref, "removeAllTabs", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_removeAllTabs);
		}

		static IntPtr id_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_;
		[Register ("removeOnMenuVisibilityListener", "(Lcom/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public override void RemoveOnMenuVisibilityListener (global::ActionBar_Sherlock.App.ActionBar.IOnMenuVisibilityListener p0)
		{
			if (id_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ == IntPtr.Zero)
				id_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "removeOnMenuVisibilityListener", "(Lcom/actionbarsherlock/app/ActionBar$OnMenuVisibilityListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeOnMenuVisibilityListener_Lcom_actionbarsherlock_app_ActionBar_OnMenuVisibilityListener_, new JValue (p0));
		}

		static IntPtr id_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
		[Register ("removeTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V", "GetRemoveTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler")]
		public override void RemoveTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0)
		{
			if (id_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ == IntPtr.Zero)
				id_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "removeTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeTab_Lcom_actionbarsherlock_app_ActionBar_Tab_, new JValue (p0));
		}

		static IntPtr id_removeTabAt_I;
		[Register ("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public override void RemoveTabAt (int p0)
		{
			if (id_removeTabAt_I == IntPtr.Zero)
				id_removeTabAt_I = JNIEnv.GetMethodID (class_ref, "removeTabAt", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeTabAt_I, new JValue (p0));
		}

		static IntPtr id_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_;
		[Register ("selectTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V", "GetSelectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_Handler")]
		public override void SelectTab (global::ActionBar_Sherlock.App.ActionBar.Tab p0)
		{
			if (id_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ == IntPtr.Zero)
				id_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "selectTab", "(Lcom/actionbarsherlock/app/ActionBar$Tab;)V");
			JNIEnv.CallVoidMethod  (Handle, id_selectTab_Lcom_actionbarsherlock_app_ActionBar_Tab_, new JValue (p0));
		}

		static IntPtr id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public override void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
		}

		static IntPtr id_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_;
		[Register ("setCustomView", "(Landroid/view/View;Lcom/actionbarsherlock/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_Handler")]
		public override void SetCustomView (global::Android.Views.View p0, global::ActionBar_Sherlock.App.ActionBar.LayoutParams p1)
		{
			if (id_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ == IntPtr.Zero)
				id_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;Lcom/actionbarsherlock/app/ActionBar$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setCustomView_Landroid_view_View_Lcom_actionbarsherlock_app_ActionBar_LayoutParams_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setCustomView_I;
		[Register ("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public override void SetCustomView (int p0)
		{
			if (id_setCustomView_I == IntPtr.Zero)
				id_setCustomView_I = JNIEnv.GetMethodID (class_ref, "setCustomView", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setCustomView_I, new JValue (p0));
		}

		static IntPtr id_setDisplayHomeAsUpEnabled_Z;
		[Register ("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public override void SetDisplayHomeAsUpEnabled (bool p0)
		{
			if (id_setDisplayHomeAsUpEnabled_Z == IntPtr.Zero)
				id_setDisplayHomeAsUpEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayHomeAsUpEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDisplayHomeAsUpEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setDisplayOptions_II;
		[Register ("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public override void SetDisplayOptions (int p0, int p1)
		{
			if (id_setDisplayOptions_II == IntPtr.Zero)
				id_setDisplayOptions_II = JNIEnv.GetMethodID (class_ref, "setDisplayOptions", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDisplayOptions_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setDisplayShowCustomEnabled_Z;
		[Register ("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public override void SetDisplayShowCustomEnabled (bool p0)
		{
			if (id_setDisplayShowCustomEnabled_Z == IntPtr.Zero)
				id_setDisplayShowCustomEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowCustomEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowCustomEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setDisplayShowHomeEnabled_Z;
		[Register ("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public override void SetDisplayShowHomeEnabled (bool p0)
		{
			if (id_setDisplayShowHomeEnabled_Z == IntPtr.Zero)
				id_setDisplayShowHomeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowHomeEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowHomeEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setDisplayShowTitleEnabled_Z;
		[Register ("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public override void SetDisplayShowTitleEnabled (bool p0)
		{
			if (id_setDisplayShowTitleEnabled_Z == IntPtr.Zero)
				id_setDisplayShowTitleEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowTitleEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowTitleEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setDisplayUseLogoEnabled_Z;
		[Register ("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public override void SetDisplayUseLogoEnabled (bool p0)
		{
			if (id_setDisplayUseLogoEnabled_Z == IntPtr.Zero)
				id_setDisplayUseLogoEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayUseLogoEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDisplayUseLogoEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public override void SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, new JValue (p0));
		}

		static IntPtr id_setIcon_I;
		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public override void SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setIcon_I, new JValue (p0));
		}

		static IntPtr id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_;
		[Register ("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Lcom/actionbarsherlock/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_Handler")]
		public override void SetListNavigationCallbacks (global::Android.Widget.ISpinnerAdapter p0, global::ActionBar_Sherlock.App.ActionBar.IOnNavigationListener p1)
		{
			if (id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_ == IntPtr.Zero)
				id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_ = JNIEnv.GetMethodID (class_ref, "setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Lcom/actionbarsherlock/app/ActionBar$OnNavigationListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Lcom_actionbarsherlock_app_ActionBar_OnNavigationListener_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setLogo_Landroid_graphics_drawable_Drawable_;
		[Register ("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public override void SetLogo (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setLogo_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setLogo_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setLogo", "(Landroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setLogo_Landroid_graphics_drawable_Drawable_, new JValue (p0));
		}

		static IntPtr id_setLogo_I;
		[Register ("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public override void SetLogo (int p0)
		{
			if (id_setLogo_I == IntPtr.Zero)
				id_setLogo_I = JNIEnv.GetMethodID (class_ref, "setLogo", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setLogo_I, new JValue (p0));
		}

		static IntPtr id_setSelectedNavigationItem_I;
		[Register ("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public override void SetSelectedNavigationItem (int p0)
		{
			if (id_setSelectedNavigationItem_I == IntPtr.Zero)
				id_setSelectedNavigationItem_I = JNIEnv.GetMethodID (class_ref, "setSelectedNavigationItem", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setSelectedNavigationItem_I, new JValue (p0));
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

		static IntPtr id_show;
		[Register ("show", "()V", "GetShowHandler")]
		public override void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_show);
		}

	}

}
