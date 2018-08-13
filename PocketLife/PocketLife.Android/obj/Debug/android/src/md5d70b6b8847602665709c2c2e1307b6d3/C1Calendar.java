package md5d70b6b8847602665709c2c2e1307b6d3;


public class C1Calendar
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttachedToWindow:()V:GetOnAttachedToWindowHandler\n" +
			"n_onDetachedFromWindow:()V:GetOnDetachedFromWindowHandler\n" +
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_setBackgroundColor:(I)V:GetSetBackgroundColor_IHandler\n" +
			"";
		mono.android.Runtime.register ("C1.Android.Calendar.C1Calendar, C1.Android.Calendar", C1Calendar.class, __md_methods);
	}


	public C1Calendar (android.content.Context p0)
	{
		super (p0);
		if (getClass () == C1Calendar.class)
			mono.android.TypeManager.Activate ("C1.Android.Calendar.C1Calendar, C1.Android.Calendar", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public C1Calendar (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == C1Calendar.class)
			mono.android.TypeManager.Activate ("C1.Android.Calendar.C1Calendar, C1.Android.Calendar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public C1Calendar (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == C1Calendar.class)
			mono.android.TypeManager.Activate ("C1.Android.Calendar.C1Calendar, C1.Android.Calendar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public C1Calendar (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == C1Calendar.class)
			mono.android.TypeManager.Activate ("C1.Android.Calendar.C1Calendar, C1.Android.Calendar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onAttachedToWindow ()
	{
		n_onAttachedToWindow ();
	}

	private native void n_onAttachedToWindow ();


	public void onDetachedFromWindow ()
	{
		n_onDetachedFromWindow ();
	}

	private native void n_onDetachedFromWindow ();


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void setBackgroundColor (int p0)
	{
		n_setBackgroundColor (p0);
	}

	private native void n_setBackgroundColor (int p0);

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
