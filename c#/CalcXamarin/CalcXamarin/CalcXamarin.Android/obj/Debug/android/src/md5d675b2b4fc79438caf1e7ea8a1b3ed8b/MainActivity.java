package md5d675b2b4fc79438caf1e7ea8a1b3ed8b;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_OnOperand:(Landroid/view/View;)V:__export__\n" +
			"n_OnOperator:(Landroid/view/View;)V:__export__\n" +
			"n_OnEqual:(Landroid/view/View;)V:__export__\n" +
			"n_OnClear:(Landroid/view/View;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("CalcXamarin.Droid.MainActivity, CalcXamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("CalcXamarin.Droid.MainActivity, CalcXamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void OnOperand (android.view.View p0)
	{
		n_OnOperand (p0);
	}

	private native void n_OnOperand (android.view.View p0);


	public void OnOperator (android.view.View p0)
	{
		n_OnOperator (p0);
	}

	private native void n_OnOperator (android.view.View p0);


	public void OnEqual (android.view.View p0)
	{
		n_OnEqual (p0);
	}

	private native void n_OnEqual (android.view.View p0);


	public void OnClear (android.view.View p0)
	{
		n_OnClear (p0);
	}

	private native void n_OnClear (android.view.View p0);

	private java.util.ArrayList refList;
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
