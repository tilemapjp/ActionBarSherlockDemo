package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnOptionsItemSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnOptionsItemSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onOptionsItemSelected:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:ActionBar_Sherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlockBinding\n" +
			"";
		mono.android.Runtime.register ("ActionBar_Sherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnOptionsItemSelectedListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnOptionsItemSelectedListenerImplementor ()
	{
		super ();
		if (getClass () == ActionBarSherlock_OnOptionsItemSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("ActionBar_Sherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onOptionsItemSelected (com.actionbarsherlock.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (com.actionbarsherlock.view.MenuItem p0);

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
