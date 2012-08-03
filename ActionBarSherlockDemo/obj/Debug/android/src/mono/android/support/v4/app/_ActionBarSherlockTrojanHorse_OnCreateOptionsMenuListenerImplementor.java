package mono.android.support.v4.app;


public class _ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.app._ActionBarSherlockTrojanHorse.OnCreateOptionsMenuListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateOptionsMenu:(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V:GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlockBinding\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", _ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor.class, __md_methods);
	}


	public _ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor ()
	{
		super ();
		if (getClass () == _ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerImplementor, ActionBarSherlockBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0, com.actionbarsherlock.view.MenuInflater p1)
	{
		n_onCreateOptionsMenu (p0, p1);
	}

	private native void n_onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0, com.actionbarsherlock.view.MenuInflater p1);

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
