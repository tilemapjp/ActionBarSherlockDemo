package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnActionModeFinishedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnActionModeFinishedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onActionModeFinished:(Lcom/actionbarsherlock/view/ActionMode;)V:GetOnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnActionModeFinishedListenerInvoker, ActionBarSherlockBinding\n" +
			"";
		mono.android.Runtime.register ("ActionBar_Sherlock.ActionBarSherlock/IOnActionModeFinishedListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnActionModeFinishedListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnActionModeFinishedListenerImplementor ()
	{
		super ();
		if (getClass () == ActionBarSherlock_OnActionModeFinishedListenerImplementor.class)
			mono.android.TypeManager.Activate ("ActionBar_Sherlock.ActionBarSherlock/IOnActionModeFinishedListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onActionModeFinished (com.actionbarsherlock.view.ActionMode p0)
	{
		n_onActionModeFinished (p0);
	}

	private native void n_onActionModeFinished (com.actionbarsherlock.view.ActionMode p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
