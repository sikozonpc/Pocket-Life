package md52dc97e7ae4c4179b16f3a695e68180e4;


public class ScrollChangedListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.ViewTreeObserver.OnScrollChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScrollChanged:()V:GetOnScrollChangedHandler:Android.Views.ViewTreeObserver/IOnScrollChangedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("C1.Android.Core.ScrollChangedListener, C1.Android.Core", ScrollChangedListener.class, __md_methods);
	}


	public ScrollChangedListener ()
	{
		super ();
		if (getClass () == ScrollChangedListener.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.ScrollChangedListener, C1.Android.Core", "", this, new java.lang.Object[] {  });
	}


	public void onScrollChanged ()
	{
		n_onScrollChanged ();
	}

	private native void n_onScrollChanged ();

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
