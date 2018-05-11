package md51c08100e87a7c9c5d6ff26cd17a216f5;


public class Classe
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Lor0138.Classes.Filtro.Classe, Lor0138, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Classe.class, __md_methods);
	}


	public Classe ()
	{
		super ();
		if (getClass () == Classe.class)
			mono.android.TypeManager.Activate ("Lor0138.Classes.Filtro.Classe, Lor0138, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
