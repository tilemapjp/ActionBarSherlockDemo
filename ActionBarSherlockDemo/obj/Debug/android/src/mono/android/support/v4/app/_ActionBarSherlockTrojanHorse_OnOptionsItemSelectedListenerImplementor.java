package mono.android.support.v4.app;


public class _ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.app._ActionBarSherlockTrojanHorse.OnOptionsItemSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onOptionsItemSelected:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlockBinding\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", _ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor.class, __md_methods);
	}


	public _ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor ()
	{
		super ();
		if (getClass () == _ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
