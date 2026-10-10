using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x020004CC RID: 1228
public static class GOAEAMLNFOC
{
	// Token: 0x0600942B RID: 37931 RVA: 0x00415104 File Offset: 0x00413304
	public static uint KPMOLLGDKKO(uint IJFKKHACLKF, int DLEHGOIKKNM, string DIMBCOBNMAM)
	{
		uint num = 2166136261U;
		num = (num ^ (IJFKKHACLKF & 255U)) * 16777619U;
		num = (num ^ (IJFKKHACLKF >> 8 & 255U)) * 16777619U;
		num = (num ^ (IJFKKHACLKF >> 16 & 255U)) * 16777619U;
		num = (num ^ (IJFKKHACLKF >> 24 & 255U)) * 16777619U;
		num = (num ^ (uint)(DLEHGOIKKNM & 255)) * 16777619U;
		num = (num ^ ((uint)DLEHGOIKKNM >> 8 & 255U)) * 16777619U;
		num = (num ^ ((uint)DLEHGOIKKNM >> 16 & 255U)) * 16777619U;
		num = (num ^ ((uint)DLEHGOIKKNM >> 24 & 255U)) * 16777619U;
		if (DIMBCOBNMAM != null)
		{
			for (int i = 0; i < DIMBCOBNMAM.Length; i++)
			{
				num = (num ^ (uint)(DIMBCOBNMAM[i] & 'ÿ')) * 16777619U;
				num = (num ^ (uint)(DIMBCOBNMAM[i] >> 8 & 'ÿ')) * 16777619U;
			}
		}
		return num;
	}

	// Token: 0x0600942C RID: 37932 RVA: 0x004151EC File Offset: 0x004133EC
	private static bool GJNFOEGLLOA(List<int> PFHJCPMHFDL, List<POKPDFKMOFC> FLDHGLJBDOB, int LEIDIONKMBF, Func<int, List<JBBNEEHANHL>> LHNIAENPECN)
	{
		int num = GOAEAMLNFOC.NGJJLKPPDDO(PFHJCPMHFDL, LHNIAENPECN);
		if (num < 0)
		{
			return false;
		}
		int num2 = FLDHGLJBDOB.Count - LEIDIONKMBF;
		if (num2 < 0)
		{
			num2 = 0;
		}
		for (int i = num2; i < FLDHGLJBDOB.Count; i++)
		{
			if (FLDHGLJBDOB[i].CLPIMBKGJOP == num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600942D RID: 37933 RVA: 0x0041523C File Offset: 0x0041343C
	private static int BABLECCKICA(List<POKPDFKMOFC> PKEMFCKFBFE, List<POKPDFKMOFC> FLDHGLJBDOB, Dictionary<int, int> HOPCNEDBKEK, bool FMHODLODFPC, Func<int, List<JBBNEEHANHL>> LHNIAENPECN)
	{
		for (int i = 0; i < PKEMFCKFBFE.Count; i++)
		{
			if (!FMHODLODFPC || PKEMFCKFBFE[i].GEJIGDJBONA)
			{
				List<int> pfhjcpmhfdl = GOAEAMLNFOC.BBGIDNOFNMN(PKEMFCKFBFE[i], HOPCNEDBKEK);
				if (!GOAEAMLNFOC.PNHHGMNINPM(pfhjcpmhfdl, FLDHGLJBDOB, 2) && !GOAEAMLNFOC.GJNFOEGLLOA(pfhjcpmhfdl, FLDHGLJBDOB, 2, LHNIAENPECN))
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x0600942E RID: 37934 RVA: 0x00415294 File Offset: 0x00413494
	private static int NGJJLKPPDDO(List<int> BNDOOCJFKGO, Func<int, List<JBBNEEHANHL>> LHNIAENPECN)
	{
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		int num = 0;
		while (num < BNDOOCJFKGO.Count && num < 3)
		{
			List<JBBNEEHANHL> list3 = LHNIAENPECN(BNDOOCJFKGO[num]);
			if (list3 != null && list3.Count != 0)
			{
				int item = (int)list3[0];
				int num2 = list.IndexOf(item);
				if (num2 < 0)
				{
					list.Add(item);
					list2.Add(1);
				}
				else
				{
					List<int> list4 = list2;
					int index = num2;
					int num3 = list4[index];
					list4[index] = num3 + 1;
				}
			}
			num++;
		}
		int result = -1;
		int num4 = 0;
		for (int i = 0; i < list.Count; i++)
		{
			if (list2[i] > num4)
			{
				result = list[i];
				num4 = list2[i];
			}
		}
		return result;
	}

	// Token: 0x0600942F RID: 37935 RVA: 0x00415360 File Offset: 0x00413560
	private static void LHABNPFIGMK(List<POKPDFKMOFC> PKEMFCKFBFE)
	{
		for (int i = 1; i < PKEMFCKFBFE.Count; i++)
		{
			POKPDFKMOFC pokpdfkmofc = PKEMFCKFBFE[i];
			int num = i - 1;
			while (num >= 0 && PKEMFCKFBFE[num].AGMOECJFFJI < pokpdfkmofc.AGMOECJFFJI)
			{
				PKEMFCKFBFE[num + 1] = PKEMFCKFBFE[num];
				num--;
			}
			PKEMFCKFBFE[num + 1] = pokpdfkmofc;
		}
	}

	// Token: 0x06009430 RID: 37936 RVA: 0x004153C2 File Offset: 0x004135C2
	public static bool DLIKABOBPIO(JBBNEEHANHL HBBJBNJBMPK)
	{
		return HBBJBNJBMPK - JBBNEEHANHL.newFilterSupernatural <= 5 || HBBJBNJBMPK - JBBNEEHANHL.newFilterAdventure <= 3;
	}

	// Token: 0x06009431 RID: 37937 RVA: 0x004153D4 File Offset: 0x004135D4
	public static uint FKKNGEFLDAN(uint IJFKKHACLKF, List<int> IOFBIDPIDEA, List<int> FJPJJPKHJAJ)
	{
		List<int> list = new List<int>();
		if (IOFBIDPIDEA != null)
		{
			list.AddRange(IOFBIDPIDEA);
		}
		list.Sort();
		List<int> list2 = new List<int>();
		if (FJPJJPKHJAJ != null)
		{
			list2.AddRange(FJPJJPKHJAJ);
		}
		list2.Sort();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list.Count; i++)
		{
			stringBuilder.Append(list[i]);
			stringBuilder.Append(',');
		}
		stringBuilder.Append('|');
		for (int j = 0; j < list2.Count; j++)
		{
			stringBuilder.Append(list2[j]);
			stringBuilder.Append(',');
		}
		return GOAEAMLNFOC.KPMOLLGDKKO(IJFKKHACLKF, 0, stringBuilder.ToString());
	}

	// Token: 0x06009432 RID: 37938 RVA: 0x00415480 File Offset: 0x00413680
	private static float BNMAHODIGJE(int PLKMJJIIJNO, EGBNGOMIJEE FOKFGMIEEDB, Func<int, List<JBBNEEHANHL>> LHNIAENPECN)
	{
		List<JBBNEEHANHL> list = LHNIAENPECN(PLKMJJIIJNO);
		if (list == null || list.Count == 0)
		{
			return 0f;
		}
		float num = 0f;
		int num2 = 0;
		while (num2 < list.Count && num2 < 3)
		{
			int num3 = (int)list[num2];
			if (num3 >= 0 && num3 < FOKFGMIEEDB.OKAONKKBAFK.Length)
			{
				float num4 = 0.1f;
				if (num2 == 0)
				{
					num4 = 0.7f;
				}
				else if (1 == num2)
				{
					num4 = 0.2f;
				}
				num += num4 * FOKFGMIEEDB.OKAONKKBAFK[num3];
			}
			num2++;
		}
		return Mathf.Clamp01(num);
	}

	// Token: 0x06009433 RID: 37939 RVA: 0x0041550C File Offset: 0x0041370C
	public static List<POKPDFKMOFC> DMJNCOAHBHI(List<MJJBPLAMLAN> OFPLLEEJIJF, EGBNGOMIJEE FOKFGMIEEDB, Func<int, bool> PEEGAKLLELK, Func<int, List<JBBNEEHANHL>> LHNIAENPECN, Func<int, float> KJIONEDBGND)
	{
		List<POKPDFKMOFC> list = new List<POKPDFKMOFC>();
		try
		{
			if (OFPLLEEJIJF == null || FOKFGMIEEDB == null || PEEGAKLLELK == null || LHNIAENPECN == null || KJIONEDBGND == null)
			{
				return list;
			}
			List<POKPDFKMOFC> list2 = new List<POKPDFKMOFC>();
			for (int i = 0; i < OFPLLEEJIJF.Count; i++)
			{
				MJJBPLAMLAN mjjbplamlan = OFPLLEEJIJF[i];
				if (mjjbplamlan != null && mjjbplamlan.GOMICAEJLAM && (!FOKFGMIEEDB.EEHAMAJIHOA || !mjjbplamlan.LJOAEJHFHIL))
				{
					List<int> list3 = new List<int>();
					for (int j = 0; j < mjjbplamlan.JAPFMDOBPKJ.Count; j++)
					{
						int num = mjjbplamlan.JAPFMDOBPKJ[j];
						if (!list3.Contains(num) && PEEGAKLLELK(num))
						{
							list3.Add(num);
						}
					}
					if (list3.Count >= 1)
					{
						float dnloinkgolf = GOAEAMLNFOC.CIMPPOBEJDF(list3, FOKFGMIEEDB, LHNIAENPECN);
						float num2 = Mathf.Min(1f, (float)list3.Count / 3f);
						float mpdnajnpgfp = (float)Mathf.Clamp(mjjbplamlan.CJEOPBAIOHB, 1, 9) / 9f * num2;
						POKPDFKMOFC pokpdfkmofc = new POKPDFKMOFC();
						pokpdfkmofc.IEJLOIMDPDO = mjjbplamlan.DBHMNECMIAB;
						pokpdfkmofc.JAPFMDOBPKJ = GOAEAMLNFOC.DFPFAENEHAN(list3, KJIONEDBGND);
						pokpdfkmofc.DNLOINKGOLF = dnloinkgolf;
						pokpdfkmofc.MPDNAJNPGFP = mpdnajnpgfp;
						pokpdfkmofc.CLPIMBKGJOP = GOAEAMLNFOC.NGJJLKPPDDO(pokpdfkmofc.JAPFMDOBPKJ, LHNIAENPECN);
						list2.Add(pokpdfkmofc);
					}
				}
			}
			uint num3 = FOKFGMIEEDB.JNKDDGGHOEA;
			if (num3 == 0U)
			{
				num3 = FOKFGMIEEDB.LBLLBJKKOAP;
			}
			List<int> list4 = new List<int>();
			for (int k = 0; k < list2.Count; k++)
			{
				list4.Add(Mathf.RoundToInt(list2[k].DNLOINKGOLF / 0.0001f));
			}
			for (int l = 0; l < list2.Count; l++)
			{
				int num4 = 0;
				int num5 = 0;
				for (int m = 0; m < list2.Count; m++)
				{
					if (list4[m] < list4[l])
					{
						num4++;
					}
					else if (list4[m] == list4[l])
					{
						num5++;
					}
				}
				float num6 = 1f;
				if (list2.Count > 1)
				{
					num6 = ((float)num4 + 0.5f * (float)(num5 - 1)) / (float)(list2.Count - 1);
				}
				list2[l].OKEFIJDNJPC = num6;
				float num7 = GOAEAMLNFOC.ABAEDACHEIK(num3, FOKFGMIEEDB.LOPKBMGNEGJ, list2[l].IEJLOIMDPDO);
				float num8 = GOAEAMLNFOC.ABAEDACHEIK(num3, 100000 + FOKFGMIEEDB.PBJGGLCJADD, list2[l].IEJLOIMDPDO);
				list2[l].AGMOECJFFJI = 0.5f * num6 + 0.2f * list2[l].MPDNAJNPGFP + 0.25f * num7 + 0.05f * num8;
				list2[l].GEJIGDJBONA = (num6 < 0.3f);
			}
			GOAEAMLNFOC.LHABNPFIGMK(list2);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			List<POKPDFKMOFC> list5 = new List<POKPDFKMOFC>();
			while ((list2.Count > 0 || list5.Count > 0) && list.Count < 40)
			{
				POKPDFKMOFC pokpdfkmofc2 = null;
				if ((list.Count + 1) % 5 == 0)
				{
					int num9 = GOAEAMLNFOC.BABLECCKICA(list5, list, dictionary, true, LHNIAENPECN);
					if (num9 >= 0)
					{
						pokpdfkmofc2 = list5[num9];
						list5.RemoveAt(num9);
					}
					else
					{
						int num10 = GOAEAMLNFOC.BABLECCKICA(list2, list, dictionary, true, LHNIAENPECN);
						if (num10 >= 0)
						{
							pokpdfkmofc2 = list2[num10];
							list2.RemoveAt(num10);
						}
					}
				}
				if (pokpdfkmofc2 == null)
				{
					int num11 = GOAEAMLNFOC.BABLECCKICA(list5, list, dictionary, false, LHNIAENPECN);
					if (num11 >= 0)
					{
						pokpdfkmofc2 = list5[num11];
						list5.RemoveAt(num11);
					}
				}
				if (pokpdfkmofc2 == null)
				{
					if (list2.Count > 0)
					{
						pokpdfkmofc2 = list2[0];
						list2.RemoveAt(0);
						List<int> pfhjcpmhfdl = GOAEAMLNFOC.BBGIDNOFNMN(pokpdfkmofc2, dictionary);
						if (GOAEAMLNFOC.PNHHGMNINPM(pfhjcpmhfdl, list, 2) || GOAEAMLNFOC.GJNFOEGLLOA(pfhjcpmhfdl, list, 2, LHNIAENPECN))
						{
							list5.Add(pokpdfkmofc2);
							continue;
						}
					}
					else
					{
						pokpdfkmofc2 = list5[0];
						list5.RemoveAt(0);
					}
				}
				List<int> list6 = GOAEAMLNFOC.BBGIDNOFNMN(pokpdfkmofc2, dictionary);
				if (list6.Count >= 1)
				{
					for (int n = 0; n < list6.Count; n++)
					{
						int num12 = 0;
						dictionary.TryGetValue(list6[n], out num12);
						dictionary[list6[n]] = num12 + 1;
					}
					pokpdfkmofc2.JAPFMDOBPKJ = list6;
					pokpdfkmofc2.CLPIMBKGJOP = GOAEAMLNFOC.NGJJLKPPDDO(list6, LHNIAENPECN);
					list.Add(pokpdfkmofc2);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06009434 RID: 37940 RVA: 0x004159B4 File Offset: 0x00413BB4
	private static bool PNHHGMNINPM(List<int> PFHJCPMHFDL, List<POKPDFKMOFC> FLDHGLJBDOB, int LEIDIONKMBF)
	{
		int num = FLDHGLJBDOB.Count - LEIDIONKMBF;
		if (num < 0)
		{
			num = 0;
		}
		for (int i = num; i < FLDHGLJBDOB.Count; i++)
		{
			for (int j = 0; j < PFHJCPMHFDL.Count; j++)
			{
				if (FLDHGLJBDOB[i].JAPFMDOBPKJ.Contains(PFHJCPMHFDL[j]))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06009435 RID: 37941 RVA: 0x00415A10 File Offset: 0x00413C10
	private static float CIMPPOBEJDF(List<int> BNDOOCJFKGO, EGBNGOMIJEE FOKFGMIEEDB, Func<int, List<JBBNEEHANHL>> LHNIAENPECN)
	{
		float num = 0f;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < BNDOOCJFKGO.Count; i++)
		{
			num += GOAEAMLNFOC.BNMAHODIGJE(BNDOOCJFKGO[i], FOKFGMIEEDB, LHNIAENPECN);
			bool flag = FOKFGMIEEDB.OPDNPPGBELO.Contains(BNDOOCJFKGO[i]);
			if (!flag && FOKFGMIEEDB.NBABLDKAEBC.Contains(BNDOOCJFKGO[i]))
			{
				num2++;
			}
			if (flag)
			{
				num3++;
			}
			if (FOKFGMIEEDB.ECOBLMDOBBF.Contains(BNDOOCJFKGO[i]))
			{
				num4++;
			}
		}
		float num5 = (float)BNDOOCJFKGO.Count;
		return Mathf.Clamp01(0.7f * (num / num5) + 0.25f * ((float)num2 / num5) + 0.25f * ((float)num4 / num5) - 0.2f * ((float)num3 / num5));
	}

	// Token: 0x06009436 RID: 37942 RVA: 0x00415ADA File Offset: 0x00413CDA
	public static float ABAEDACHEIK(uint IJFKKHACLKF, int DLEHGOIKKNM, string DIMBCOBNMAM)
	{
		return (GOAEAMLNFOC.KPMOLLGDKKO(IJFKKHACLKF, DLEHGOIKKNM, DIMBCOBNMAM) & 16777215U) / 16777216f;
	}

	// Token: 0x06009437 RID: 37943 RVA: 0x00415AF4 File Offset: 0x00413CF4
	private static List<int> BBGIDNOFNMN(POKPDFKMOFC POPEMMIOOIC, Dictionary<int, int> HOPCNEDBKEK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < POPEMMIOOIC.JAPFMDOBPKJ.Count; i++)
		{
			int num = POPEMMIOOIC.JAPFMDOBPKJ[i];
			int num2 = 0;
			HOPCNEDBKEK.TryGetValue(num, out num2);
			if (num2 < 3)
			{
				list.Add(num);
				if (list.Count >= 3)
				{
					break;
				}
			}
		}
		return list;
	}

	// Token: 0x06009438 RID: 37944 RVA: 0x00415B4B File Offset: 0x00413D4B
	public static uint BPIKBAEIIAA(string DIMBCOBNMAM)
	{
		return GOAEAMLNFOC.KPMOLLGDKKO(0U, 0, DIMBCOBNMAM);
	}

	// Token: 0x06009439 RID: 37945 RVA: 0x00415B58 File Offset: 0x00413D58
	private static List<int> DFPFAENEHAN(List<int> BNDOOCJFKGO, Func<int, float> KJIONEDBGND)
	{
		List<int> list = new List<int>(BNDOOCJFKGO);
		List<float> list2 = new List<float>();
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(KJIONEDBGND(list[i]));
		}
		for (int j = 1; j < list.Count; j++)
		{
			int value = list[j];
			float num = list2[j];
			int num2 = j - 1;
			while (num2 >= 0 && list2[num2] < num)
			{
				list[num2 + 1] = list[num2];
				list2[num2 + 1] = list2[num2];
				num2--;
			}
			list[num2 + 1] = value;
			list2[num2 + 1] = num;
		}
		return list;
	}

	// Token: 0x04002937 RID: 10551
	public const int LLEIKHCPBCI = 1;

	// Token: 0x04002938 RID: 10552
	public const int PCBDCHAMANH = 3;

	// Token: 0x04002939 RID: 10553
	public const int KBNBAPMGAPB = 3;

	// Token: 0x0400293A RID: 10554
	public const int GGKNDEBGCGF = 5;

	// Token: 0x0400293B RID: 10555
	public const int MBKNBHENDBI = 40;

	// Token: 0x0400293C RID: 10556
	public const int EEBAJAJHMCP = 2;

	// Token: 0x0400293D RID: 10557
	private const float GCAOGJMKGJC = 0.5f;

	// Token: 0x0400293E RID: 10558
	private const float AJKFEPAKMMB = 0.2f;

	// Token: 0x0400293F RID: 10559
	private const float IELMILOHBPM = 0.25f;

	// Token: 0x04002940 RID: 10560
	private const float FJBAIBJHACH = 0.05f;

	// Token: 0x04002941 RID: 10561
	private const float LEPEDOGFNGD = 0.3f;

	// Token: 0x04002942 RID: 10562
	private const float PKIOLNIJNHO = 0.0001f;

	// Token: 0x04002943 RID: 10563
	private const int EOPALAPBEDB = 3;

	// Token: 0x04002944 RID: 10564
	public const int BCHPIBJLGBL = 2;

	// Token: 0x04002945 RID: 10565
	public const float HJEINBKLLBB = 1f;

	// Token: 0x04002946 RID: 10566
	public const float MEMMENJICFL = 0.3f;

	// Token: 0x04002947 RID: 10567
	public const float EABPHENBPLG = 0.15f;

	// Token: 0x04002948 RID: 10568
	public const float NDBDPALKHJN = 0.05f;

	// Token: 0x04002949 RID: 10569
	private const float GLHNHFHKKMO = 0.7f;

	// Token: 0x0400294A RID: 10570
	private const float MMGPBDBHNFE = 0.2f;

	// Token: 0x0400294B RID: 10571
	private const float HHKKFGDKFGD = 0.1f;

	// Token: 0x0400294C RID: 10572
	private const float DFFNPPEBFEJ = 0.7f;

	// Token: 0x0400294D RID: 10573
	private const float DEKHBMEBPCG = 0.25f;

	// Token: 0x0400294E RID: 10574
	private const float FAEGBKKICFJ = 0.25f;

	// Token: 0x0400294F RID: 10575
	private const float IFGMHCGOGNI = 0.2f;
}
