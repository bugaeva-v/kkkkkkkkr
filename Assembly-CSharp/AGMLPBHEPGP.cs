using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000168 RID: 360
public class AGMLPBHEPGP
{
	// Token: 0x06002DBD RID: 11709 RVA: 0x0013C89A File Offset: 0x0013AA9A
	public static T[] CONIHBPFAPG<T>(string ODOLNLJDFEC)
	{
		return JsonUtility.FromJson<AGMLPBHEPGP.Wrapper<T>>("{ \"array\": " + ODOLNLJDFEC + "}").array;
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x0013C8B8 File Offset: 0x0013AAB8
	public static string AEHPNBOEAJP<T>(List<T> HKOODGACHPK)
	{
		T[] array = new T[HKOODGACHPK.Count];
		for (int i = 0; i < HKOODGACHPK.Count; i++)
		{
			array[i] = HKOODGACHPK[i];
		}
		return JsonUtility.ToJson(new AGMLPBHEPGP.Wrapper<T>
		{
			array = array
		});
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x0013C901 File Offset: 0x0013AB01
	public static string JLBBHOHMAOB<T>(T[] CIKHNNHJGAP)
	{
		return JsonUtility.ToJson(new AGMLPBHEPGP.Wrapper<T>
		{
			array = CIKHNNHJGAP
		});
	}

	// Token: 0x02000169 RID: 361
	[Serializable]
	private class Wrapper<T>
	{
		// Token: 0x04000E00 RID: 3584
		public T[] array;
	}
}
