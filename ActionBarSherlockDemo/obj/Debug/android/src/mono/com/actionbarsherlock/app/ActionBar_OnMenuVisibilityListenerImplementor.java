package mono.com.actionbarsherlock.app;


public class ActionBar_OnMenuVisibilityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.app.ActionBar.OnMenuVisibilityListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuVisibilityChanged:(Z)V:GetOnMenuVisibilityChanged_ZHandler:ActionBar_Sherlock.App.ActionBar/IOnMenuVisibilityListenerInvoker, ActionBarSherlockBinding\n" +
			"";
		mono.android.Runtime.register ("ActionBar_Sherlock.App.ActionBar/IOnMenuVisibilityListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBar_OnMenuVisibilityListenerImplementor.class, __md_methods);
	}


	public ActionBar_OnMenuVisibilityListenerImplementor ()
	{
		super ();
		if (getClass () == ActionBar_OnMenuVisibilityListenerImplementor.class)
			mono.android.TypeManager.Activate ("ActionBar_Sherlock.App.ActionBar/IOnMenuVisibilityListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMenuVisibilityChanged (boolean p0)
	{
		n_onMenuVisibilityChanged (p0);
	}

	private native void n_onMenuVisibilityChanged (boolean p0);

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
