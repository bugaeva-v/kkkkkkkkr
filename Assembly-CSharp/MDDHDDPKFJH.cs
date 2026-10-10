using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x02000219 RID: 537
public static class MDDHDDPKFJH
{
	// Token: 0x06004346 RID: 17222 RVA: 0x001D59EF File Offset: 0x001D3BEF
	public static void GMGPLOLADGB(int PLKMJJIIJNO)
	{
		MDDHDDPKFJH.GMGPLOLADGB(PLKMJJIIJNO, null);
	}

	// Token: 0x06004347 RID: 17223 RVA: 0x001D59F8 File Offset: 0x001D3BF8
	public static int FFFJLJBKCHC(int PLKMJJIIJNO)
	{
		return MDDHDDPKFJH.FFFJLJBKCHC(PLKMJJIIJNO, null);
	}

	// Token: 0x06004348 RID: 17224 RVA: 0x001D5A04 File Offset: 0x001D3C04
	private static HashSet<int> HLCOGPHDCKN()
	{
		if (MDDHDDPKFJH.GNNOJPJPJCL != null)
		{
			return MDDHDDPKFJH.GNNOJPJPJCL;
		}
		MDDHDDPKFJH.GNNOJPJPJCL = new HashSet<int>();
		try
		{
			string @string = PlayerPrefs.GetString("sksn", "");
			if (!string.IsNullOrEmpty(@string))
			{
				string[] array = @string.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					int item;
					if (int.TryParse(array[i], out item))
					{
						MDDHDDPKFJH.GNNOJPJPJCL.Add(item);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return MDDHDDPKFJH.GNNOJPJPJCL;
	}

	// Token: 0x06004349 RID: 17225 RVA: 0x001D5A90 File Offset: 0x001D3C90
	public static int FFFJLJBKCHC(int PLKMJJIIJNO, List<string> MKLBDPIIBNE)
	{
		int num = 0;
		try
		{
			List<int> list = DHFLKLPKNJG.GNEJAPMDJPI(PLKMJJIIJNO, MKLBDPIIBNE);
			HashSet<int> hashSet = MDDHDDPKFJH.HLCOGPHDCKN();
			for (int i = 0; i < list.Count; i++)
			{
				if (!hashSet.Contains(list[i]))
				{
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x0600434A RID: 17226 RVA: 0x001D5AEC File Offset: 0x001D3CEC
	public static int FFFJLJBKCHC()
	{
		int num = 0;
		try
		{
			List<int> list = DHFLKLPKNJG.GNEJAPMDJPI(-1);
			HashSet<int> hashSet = MDDHDDPKFJH.HLCOGPHDCKN();
			for (int i = 0; i < list.Count; i++)
			{
				if (!hashSet.Contains(list[i]))
				{
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x0600434B RID: 17227 RVA: 0x001D5B48 File Offset: 0x001D3D48
	public static void GMGPLOLADGB(int PLKMJJIIJNO, List<string> MKLBDPIIBNE)
	{
		try
		{
			List<int> list = DHFLKLPKNJG.GNEJAPMDJPI(PLKMJJIIJNO, MKLBDPIIBNE);
			HashSet<int> hashSet = MDDHDDPKFJH.HLCOGPHDCKN();
			bool flag = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (hashSet.Add(list[i]))
				{
					flag = true;
				}
			}
			if (flag)
			{
				MDDHDDPKFJH.LPCBDEBKAIM(hashSet);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600434C RID: 17228 RVA: 0x001D5BAC File Offset: 0x001D3DAC
	public static void EPJKDCDOEMM()
	{
		try
		{
			MDDHDDPKFJH.GNNOJPJPJCL = null;
			PlayerPrefs.DeleteKey("sksn");
			PlayerPrefs.Save();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600434D RID: 17229 RVA: 0x001D5BE8 File Offset: 0x001D3DE8
	private static void LPCBDEBKAIM(HashSet<int> ILOPFGPCKBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (int value in ILOPFGPCKBF)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append(value);
		}
		PlayerPrefs.SetString("sksn", stringBuilder.ToString());
		PlayerPrefs.Save();
	}

	// Token: 0x040012A3 RID: 4771
	private const string MAFGLIADKCF = "sksn";

	// Token: 0x040012A4 RID: 4772
	private const char COMCEOKNMNP = ',';

	// Token: 0x040012A5 RID: 4773
	public const int PNAJOEBLCAJ = 99;

	// Token: 0x040012A6 RID: 4774
	private static HashSet<int> GNNOJPJPJCL;
}
