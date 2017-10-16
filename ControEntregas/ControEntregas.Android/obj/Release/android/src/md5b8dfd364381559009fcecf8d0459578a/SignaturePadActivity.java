package md5b8dfd364381559009fcecf8d0459578a;


public class SignaturePadActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"";
		mono.android.Runtime.register ("Acr.XamForms.SignaturePad.Droid.SignaturePadActivity, Acr.XamForms.SignaturePad.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SignaturePadActivity.class, __md_methods);
	}


	public SignaturePadActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SignaturePadActivity.class)
			mono.android.TypeManager.Activate ("Acr.XamForms.SignaturePad.Droid.SignaturePadActivity, Acr.XamForms.SignaturePad.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();

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
