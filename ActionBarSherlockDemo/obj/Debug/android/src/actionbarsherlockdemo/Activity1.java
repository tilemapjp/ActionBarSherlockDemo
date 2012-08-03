package actionbarsherlockdemo;


public class Activity1
	extends com.actionbarsherlock.app.SherlockActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateOptionsMenu:(Lcom/actionbarsherlock/view/Menu;)Z:GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler\n" +
			"n_onOptionsItemSelected:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler\n" +
			"";
		mono.android.Runtime.register ("ActionBarSherlockDemo.Activity1, ActionBarSherlockDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Activity1.class, __md_methods);
	}


	public Activity1 ()
	{
		super ();
		if (getClass () == Activity1.class)
			mono.android.TypeManager.Activate ("ActionBarSherlockDemo.Activity1, ActionBarSherlockDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0)
	{
		return n_onCreateOptionsMenu (p0);
	}

	private native boolean n_onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0);


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
