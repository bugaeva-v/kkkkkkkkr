using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// Token: 0x0200015F RID: 351
public static class MKCHEIHILDB
{
	// Token: 0x06002CC6 RID: 11462 RVA: 0x00139444 File Offset: 0x00137644
	private static void PABOGIHLNLP(List<OJPLEKECIFI> IMDMGILBEIG)
	{
		for (int i = 1; i < IMDMGILBEIG.Count; i++)
		{
			OJPLEKECIFI ojplekecifi = IMDMGILBEIG[i];
			int num = i - 1;
			while (0 <= num && MKCHEIHILDB.IMMPGJLMFBO(ojplekecifi, IMDMGILBEIG[num]))
			{
				IMDMGILBEIG[num + 1] = IMDMGILBEIG[num];
				num--;
			}
			IMDMGILBEIG[num + 1] = ojplekecifi;
		}
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x001394A1 File Offset: 0x001376A1
	private static bool PNPGNMABMJC(string DIMBCOBNMAM, string FINCAHGFJCF)
	{
		return DIMBCOBNMAM.Length >= FINCAHGFJCF.Length && string.CompareOrdinal(DIMBCOBNMAM, 0, FINCAHGFJCF, 0, FINCAHGFJCF.Length) == 0;
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x001394C8 File Offset: 0x001376C8
	internal static void JANJEMFAEPK(string GOJOGDKCNMO, CEIBHCNNIDC JDKEFOCIIOI, List<int> GFFOPEDMCAP, List<OJPLEKECIFI> IMDMGILBEIG, bool CLAPKNDJJHO)
	{
		IMDMGILBEIG.Clear();
		if (!MLIBDDCCKBM.KEDEPEDDNJP() && MLIBDDCCKBM.FACIFBONANM())
		{
			MLIBDDCCKBM.MAAPBEBFHLJ();
		}
		if (MLIBDDCCKBM.CHCJFKALAGP == 0 || GFFOPEDMCAP == null || MKCHEIHILDB.CCIEKIAAJOB(GOJOGDKCNMO))
		{
			if (CLAPKNDJJHO)
			{
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"StoriesSearchRanker: nothing to search (anthologies ",
					MLIBDDCCKBM.CHCJFKALAGP.ToString(),
					", candidates ",
					(GFFOPEDMCAP == null) ? "null" : GFFOPEDMCAP.Count.ToString(),
					", query '",
					GOJOGDKCNMO,
					"')"
				}));
			}
			return;
		}
		int num = GADABGOBJIM.IJBHNMOOIJF(JDKEFOCIIOI);
		if (num < 0)
		{
			if (!MKCHEIHILDB.OPMOFGDDHJN)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchRanker - non-lobby UI language " + JDKEFOCIIOI.ToString() + ", searching as en");
				MKCHEIHILDB.OPMOFGDDHJN = true;
			}
			num = 0;
		}
		bool flag = MLIBDDCCKBM.IHEFHIIOGMM() && CEIBHCNNIDC.ru == JDKEFOCIIOI;
		int num2 = GADABGOBJIM.IEDAGPCMENK(num);
		bool hamkgnncgpe = 7 == num;
		string text = GADABGOBJIM.CBGFJALLOAF(GOJOGDKCNMO);
		bool flag2 = 0 < text.Length && !GADABGOBJIM.EPHMKCINEFD(text[text.Length - 1]);
		GADABGOBJIM.IAAMHNDECNP(text, MKCHEIHILDB.MJGDNDEOOKE);
		MKCHEIHILDB.MJJDIAMBPEA.Clear();
		for (int i = 0; i < MKCHEIHILDB.MJGDNDEOOKE.Count; i++)
		{
			string text2 = MKCHEIHILDB.MJGDNDEOOKE[i];
			MKCHEIHILDB.BKOCIAEIGEJ item = default(MKCHEIHILDB.BKOCIAEIGEJ);
			item.DGDHGMPEMEI = text2;
			if (GADABGOBJIM.JOMNLCJJOBD(text2))
			{
				item.JKLAKEDMACO = text2;
				item.EIHHPNCJMGD = text2;
				item.IELFPENPFOG = text2.Length;
				item.JENAEGCHCBA = true;
				MKCHEIHILDB.MJJDIAMBPEA.Add(item);
			}
			else
			{
				string text3 = GADABGOBJIM.MAGFECMLHAJ(text2);
				if (text3.Length >= 2 && !GADABGOBJIM.LGLGBJOOFJL(num, text3))
				{
					string text4 = GADABGOBJIM.ECIBPEJJLJB(text3);
					item.EIHHPNCJMGD = text4;
					item.JKLAKEDMACO = GADABGOBJIM.DKNKPKLMMLN(num, text4);
					item.LDMEFKHCDFI = GADABGOBJIM.MEGLOMOLHBH(num, text4);
					item.IELFPENPFOG = text4.Length;
					MKCHEIHILDB.MJJDIAMBPEA.Add(item);
				}
			}
		}
		bool flag3 = false;
		if (MKCHEIHILDB.MJJDIAMBPEA.Count == 0 && 0 < MKCHEIHILDB.MJGDNDEOOKE.Count)
		{
			flag3 = true;
			for (int j = 0; j < MKCHEIHILDB.MJGDNDEOOKE.Count; j++)
			{
				MKCHEIHILDB.BKOCIAEIGEJ bkociaeigej = default(MKCHEIHILDB.BKOCIAEIGEJ);
				bkociaeigej.DGDHGMPEMEI = MKCHEIHILDB.MJGDNDEOOKE[j];
				bkociaeigej.JKLAKEDMACO = GADABGOBJIM.ECIBPEJJLJB(GADABGOBJIM.MAGFECMLHAJ(MKCHEIHILDB.MJGDNDEOOKE[j]));
				bkociaeigej.IELFPENPFOG = bkociaeigej.JKLAKEDMACO.Length;
				MKCHEIHILDB.MJJDIAMBPEA.Add(bkociaeigej);
			}
		}
		if (MKCHEIHILDB.MJJDIAMBPEA.Count == 0)
		{
			if (CLAPKNDJJHO)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("StoriesSearchRanker: query '" + GOJOGDKCNMO + "' has no usable tokens");
			}
			return;
		}
		if (MKCHEIHILDB.MJJDIAMBPEA.Count > MKCHEIHILDB.KCEJOFCMKDO)
		{
			MKCHEIHILDB.MJJDIAMBPEA.RemoveRange(MKCHEIHILDB.KCEJOFCMKDO, MKCHEIHILDB.MJJDIAMBPEA.Count - MKCHEIHILDB.KCEJOFCMKDO);
		}
		int count = MKCHEIHILDB.MJJDIAMBPEA.Count;
		MLIBDDCCKBM.OPACHKBHPMN(count);
		int phedigcfidd = MLIBDDCCKBM.PHEDIGCFIDD;
		int dlljfcpcmfl = MLIBDDCCKBM.DLLJFCPCMFL;
		float[] anhljbmijjc = MLIBDDCCKBM.ANHLJBMIJJC;
		ushort[] fjiblacmflp = MLIBDDCCKBM.FJIBLACMFLP;
		bool[] amecihieajh = MLIBDDCCKBM.AMECIHIEAJH;
		float[] banoolghmab = MLIBDDCCKBM.BANOOLGHMAB;
		bool[] dkblkjfdngl = MLIBDDCCKBM.DKBLKJFDNGL;
		Array.Clear(anhljbmijjc, 0, anhljbmijjc.Length);
		Array.Clear(fjiblacmflp, 0, fjiblacmflp.Length);
		Array.Clear(amecihieajh, 0, amecihieajh.Length);
		Array.Clear(banoolghmab, 0, banoolghmab.Length);
		Array.Clear(dkblkjfdngl, 0, dkblkjfdngl.Length);
		for (int k = 0; k < GFFOPEDMCAP.Count; k++)
		{
			int num3 = GFFOPEDMCAP[k];
			if (0 <= num3 && num3 <= dlljfcpcmfl)
			{
				dkblkjfdngl[num3] = true;
			}
		}
		if (MKCHEIHILDB.JBCCPONLIPP.Length < count)
		{
			MKCHEIHILDB.JBCCPONLIPP = new float[count];
		}
		MKCHEIHILDB.AOJJCLBMOEI.Clear();
		if (CLAPKNDJJHO)
		{
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
			{
				"StoriesSearchRanker: query '",
				GOJOGDKCNMO,
				"' ui ",
				GADABGOBJIM.JPMPIIIBIEN(num),
				" tokens ",
				count.ToString(),
				flag3 ? " (all-stopwords fallback)" : "",
				flag2 ? " (last token incomplete)" : "",
				flag ? " (lgbtq hidden)" : "",
				" candidates ",
				GFFOPEDMCAP.Count.ToString()
			}));
		}
		List<HEGNCPKIFKM> cbibfjocfke = MLIBDDCCKBM.CBIBFJOCFKE;
		for (int l = 0; l < count; l++)
		{
			MKCHEIHILDB.BKOCIAEIGEJ bkociaeigej2 = MKCHEIHILDB.MJJDIAMBPEA[l];
			MKCHEIHILDB.OKLNOGEJONN(bkociaeigej2, num, flag2 && l == count - 1, hamkgnncgpe, flag3);
			float num4 = 1f;
			if (0 < MKCHEIHILDB.PLCCGINOHHG.Count)
			{
				num4 = 0f;
				for (int m = 0; m < MKCHEIHILDB.PLCCGINOHHG.Count; m++)
				{
					if (MKCHEIHILDB.PLCCGINOHHG[m].CALMBPNDMKP.LILFHCLAEEO > num4)
					{
						num4 = MKCHEIHILDB.PLCCGINOHHG[m].CALMBPNDMKP.LILFHCLAEEO;
					}
				}
			}
			MKCHEIHILDB.JBCCPONLIPP[l] = num4;
			if (CLAPKNDJJHO)
			{
				MKCHEIHILDB.BFFMKFENEHG.Length = 0;
				MKCHEIHILDB.BFFMKFENEHG.Append("  token[").Append(l).Append("] '").Append(bkociaeigej2.DGDHGMPEMEI).Append("' key='").Append(bkociaeigej2.JKLAKEDMACO).Append("'");
				if (bkociaeigej2.EIHHPNCJMGD != null && !string.Equals(bkociaeigej2.EIHHPNCJMGD, bkociaeigej2.JKLAKEDMACO, StringComparison.Ordinal))
				{
					MKCHEIHILDB.BFFMKFENEHG.Append(" folded='").Append(bkociaeigej2.EIHHPNCJMGD).Append("'");
				}
				if (bkociaeigej2.LDMEFKHCDFI != null)
				{
					MKCHEIHILDB.BFFMKFENEHG.Append(" short='").Append(bkociaeigej2.LDMEFKHCDFI).Append("'");
				}
				if (bkociaeigej2.JENAEGCHCBA)
				{
					MKCHEIHILDB.BFFMKFENEHG.Append(" digit");
				}
				MKCHEIHILDB.BFFMKFENEHG.Append(" tokenIdf=").Append(num4.ToString("0.000", CultureInfo.InvariantCulture)).Append(" cands=").Append(MKCHEIHILDB.PLCCGINOHHG.Count);
				DPGJIJGOCIC.NFIDPOMCNLP(MKCHEIHILDB.BFFMKFENEHG.ToString());
				for (int n = 0; n < MKCHEIHILDB.PLCCGINOHHG.Count; n++)
				{
					MKCHEIHILDB.GJIFDKMJHGI gjifdkmjhgi = MKCHEIHILDB.PLCCGINOHHG[n];
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"    cand '",
						gjifdkmjhgi.CALMBPNDMKP.JKLAKEDMACO,
						"' ",
						MKCHEIHILDB.NGKMFHAOKOM(gjifdkmjhgi.IODLKFKJIHF),
						" tier=",
						gjifdkmjhgi.FIOLEEOGPNO.ToString("0.00", CultureInfo.InvariantCulture),
						" df=",
						gjifdkmjhgi.CALMBPNDMKP.NINBFOMIAEG.ToString(),
						" idf=",
						gjifdkmjhgi.CALMBPNDMKP.LILFHCLAEEO.ToString("0.000", CultureInfo.InvariantCulture),
						" postings=",
						gjifdkmjhgi.CALMBPNDMKP.OMKOGCBFAJK.Length.ToString()
					}));
				}
			}
			for (int num5 = 0; num5 < MKCHEIHILDB.PLCCGINOHHG.Count; num5++)
			{
				MKCHEIHILDB.GJIFDKMJHGI gjifdkmjhgi2 = MKCHEIHILDB.PLCCGINOHHG[num5];
				foreach (DHJPAFCHGHL dhjpafchghl in gjifdkmjhgi2.CALMBPNDMKP.OMKOGCBFAJK)
				{
					if ((int)dhjpafchghl.PLMHNBPHMKP <= dlljfcpcmfl && dkblkjfdngl[(int)dhjpafchghl.PLMHNBPHMKP] && MLIBDDCCKBM.GLOJJFCHMMN((int)dhjpafchghl.GEMCPMEMNHJ, gjifdkmjhgi2.IODLKFKJIHF) && (!flag || !dhjpafchghl.LJOAEJHFHIL) && (!dhjpafchghl.JCKHEBJFPEC || flag3))
					{
						bool flag4 = dhjpafchghl.GEMCPMEMNHJ == 0 || 1 == dhjpafchghl.GEMCPMEMNHJ;
						bool flag5 = ((int)dhjpafchghl.PPINNBMGMIE & num2) != 0;
						if (!flag3 || (flag4 && flag5))
						{
							float num7 = flag5 ? 1f : MKCHEIHILDB.MKGMKMODECM;
							float num8 = gjifdkmjhgi2.CALMBPNDMKP.LILFHCLAEEO;
							if ((2 == dhjpafchghl.GEMCPMEMNHJ || 3 == dhjpafchghl.GEMCPMEMNHJ) && num8 > MKCHEIHILDB.ONOFPGCDGDP)
							{
								num8 = MKCHEIHILDB.ONOFPGCDGDP;
							}
							if (5 == dhjpafchghl.GEMCPMEMNHJ && num8 < MKCHEIHILDB.KGMIIPCDIMK)
							{
								num8 = MKCHEIHILDB.KGMIIPCDIMK;
							}
							float num9 = gjifdkmjhgi2.FIOLEEOGPNO;
							if (dhjpafchghl.GDCEBNDONMN && num9 > MKCHEIHILDB.KLAOCLIIGIP)
							{
								num9 = MKCHEIHILDB.KLAOCLIIGIP;
							}
							float num10 = (float)dhjpafchghl.BFOOIPKJGOM / 100f * num9 * num7 * num8 * (bkociaeigej2.JENAEGCHCBA ? MKCHEIHILDB.HMCIGDENMCD : 1f);
							float num11 = num9 * num7;
							if (CLAPKNDJJHO)
							{
								DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
								{
									"      aind ",
									dhjpafchghl.PLMHNBPHMKP.ToString(),
									" row '",
									cbibfjocfke[(int)dhjpafchghl.OGPKMMOIHLG].DBHMNECMIAB,
									"' ",
									MLIBDDCCKBM.PBPGBNOCHKM((int)dhjpafchghl.GEMCPMEMNHJ),
									" w=",
									dhjpafchghl.BFOOIPKJGOM.ToString(),
									" tier=",
									num9.ToString("0.00", CultureInfo.InvariantCulture),
									" lang=",
									num7.ToString("0.00", CultureInfo.InvariantCulture),
									" idf=",
									num8.ToString("0.000", CultureInfo.InvariantCulture),
									" c=",
									num10.ToString("0.000", CultureInfo.InvariantCulture),
									dhjpafchghl.AMEAMPOBGEO ? " secondary(pending)" : ""
								}));
							}
							if (dhjpafchghl.AMEAMPOBGEO)
							{
								MKCHEIHILDB.JAHKKNMKBKD item2 = default(MKCHEIHILDB.JAHKKNMKBKD);
								item2.PLMHNBPHMKP = (int)dhjpafchghl.PLMHNBPHMKP;
								item2.ENBBONPKHBC = l;
								item2.OGPKMMOIHLG = dhjpafchghl.OGPKMMOIHLG;
								item2.FMKCKAHEEAF = num10;
								item2.EADLLKEANLI = flag5;
								item2.HDMHKHHHHLE = num11;
								MKCHEIHILDB.AOJJCLBMOEI.Add(item2);
							}
							else
							{
								int num12 = (int)dhjpafchghl.PLMHNBPHMKP * phedigcfidd + l;
								if (num10 > anhljbmijjc[num12])
								{
									anhljbmijjc[num12] = num10;
									fjiblacmflp[num12] = dhjpafchghl.OGPKMMOIHLG;
									amecihieajh[num12] = flag5;
									banoolghmab[num12] = num11;
								}
							}
						}
					}
				}
			}
		}
		for (int num13 = 0; num13 < MKCHEIHILDB.AOJJCLBMOEI.Count; num13++)
		{
			MKCHEIHILDB.JAHKKNMKBKD jahkknmkbkd = MKCHEIHILDB.AOJJCLBMOEI[num13];
			int num14 = jahkknmkbkd.PLMHNBPHMKP * phedigcfidd + jahkknmkbkd.ENBBONPKHBC;
			bool flag6 = false;
			if (0 < jahkknmkbkd.ENBBONPKHBC)
			{
				int num15 = num14 - 1;
				if (0f < anhljbmijjc[num15] && fjiblacmflp[num15] == jahkknmkbkd.OGPKMMOIHLG)
				{
					flag6 = true;
				}
			}
			if (!flag6 && jahkknmkbkd.ENBBONPKHBC < count - 1)
			{
				int num16 = num14 + 1;
				if (0f < anhljbmijjc[num16] && fjiblacmflp[num16] == jahkknmkbkd.OGPKMMOIHLG)
				{
					flag6 = true;
				}
			}
			if (CLAPKNDJJHO)
			{
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"  secondary aind ",
					jahkknmkbkd.PLMHNBPHMKP.ToString(),
					" token[",
					jahkknmkbkd.ENBBONPKHBC.ToString(),
					"] row '",
					cbibfjocfke[(int)jahkknmkbkd.OGPKMMOIHLG].DBHMNECMIAB,
					"' c=",
					jahkknmkbkd.FMKCKAHEEAF.ToString("0.000", CultureInfo.InvariantCulture),
					flag6 ? " resolved" : " dropped (no same-row neighbour)"
				}));
			}
			if (flag6 && jahkknmkbkd.FMKCKAHEEAF > anhljbmijjc[num14])
			{
				anhljbmijjc[num14] = jahkknmkbkd.FMKCKAHEEAF;
				fjiblacmflp[num14] = jahkknmkbkd.OGPKMMOIHLG;
				amecihieajh[num14] = jahkknmkbkd.EADLLKEANLI;
				banoolghmab[num14] = jahkknmkbkd.HDMHKHHHHLE;
			}
		}
		float num17 = 0f;
		for (int num18 = 0; num18 < count; num18++)
		{
			num17 += MKCHEIHILDB.JBCCPONLIPP[num18];
		}
		if (num17 <= 0f)
		{
			num17 = 1f;
		}
		float num19 = 0f;
		for (int num20 = 0; num20 < GFFOPEDMCAP.Count; num20++)
		{
			int num21 = GFFOPEDMCAP[num20];
			if (num21 >= 0 && num21 <= dlljfcpcmfl && dkblkjfdngl[num21])
			{
				dkblkjfdngl[num21] = false;
				float num22 = 0f;
				float num23 = 0f;
				int num24 = 0;
				int num25 = 0;
				bool flag7 = false;
				float num26 = 0f;
				int num27 = num21 * phedigcfidd;
				for (int num28 = 0; num28 < count; num28++)
				{
					int num29 = num27 + num28;
					if (anhljbmijjc[num29] > 0f)
					{
						num22 += anhljbmijjc[num29];
						num23 += MKCHEIHILDB.JBCCPONLIPP[num28];
						num26 += banoolghmab[num29] * MKCHEIHILDB.JBCCPONLIPP[num28];
						num24++;
						if (amecihieajh[num29])
						{
							num25++;
						}
						if (0 < num28 && 0f < anhljbmijjc[num29 - 1] && fjiblacmflp[num29 - 1] == fjiblacmflp[num29])
						{
							flag7 = true;
						}
					}
				}
				if (num24 != 0)
				{
					float num30 = num22 * (MKCHEIHILDB.IAHCPBLNAHI + (1f - MKCHEIHILDB.IAHCPBLNAHI) * num23 / num17);
					if (flag7 && num24 >= 2)
					{
						num30 *= MKCHEIHILDB.LGMABIBFFEN;
					}
					OJPLEKECIFI ojplekecifi = default(OJPLEKECIFI);
					ojplekecifi.PLMHNBPHMKP = num21;
					ojplekecifi.AGMOECJFFJI = num30;
					ojplekecifi.PAELDIINOLA = num24;
					ojplekecifi.BFDGIDOOELC = num25;
					ojplekecifi.DJJBLNKIMFL = num26 / num17;
					ojplekecifi.NJBCLIILMOF = ojplekecifi.DJJBLNKIMFL * num30;
					ojplekecifi.LHLDMMFCCKO = new int[count];
					for (int num31 = 0; num31 < count; num31++)
					{
						int num32 = num27 + num31;
						ojplekecifi.LHLDMMFCCKO[num31] = ((anhljbmijjc[num32] > 0f) ? ((int)fjiblacmflp[num32]) : -1);
					}
					IMDMGILBEIG.Add(ojplekecifi);
					if (num30 > num19)
					{
						num19 = num30;
					}
				}
			}
		}
		if (num19 < MKCHEIHILDB.HHHJBPNNHEA)
		{
			if (CLAPKNDJJHO)
			{
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"  top ",
					num19.ToString("0.000", CultureInfo.InvariantCulture),
					" < MIN_TOP - no results (",
					IMDMGILBEIG.Count.ToString(),
					" scored)"
				}));
			}
			IMDMGILBEIG.Clear();
			return;
		}
		float num33 = 0.5f * num19;
		if (num33 > MKCHEIHILDB.CEHDIDMDPFD)
		{
			num33 = MKCHEIHILDB.CEHDIDMDPFD;
		}
		if (num33 < MKCHEIHILDB.BMIJFBHDKKM * num19)
		{
			num33 = MKCHEIHILDB.BMIJFBHDKKM * num19;
		}
		int num34 = 0;
		for (int num35 = 0; num35 < IMDMGILBEIG.Count; num35++)
		{
			if (IMDMGILBEIG[num35].AGMOECJFFJI >= num33)
			{
				IMDMGILBEIG[num34] = IMDMGILBEIG[num35];
				num34++;
			}
		}
		if (num34 < IMDMGILBEIG.Count)
		{
			IMDMGILBEIG.RemoveRange(num34, IMDMGILBEIG.Count - num34);
		}
		MKCHEIHILDB.PABOGIHLNLP(IMDMGILBEIG);
		if (CLAPKNDJJHO)
		{
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
			{
				"  top ",
				num19.ToString("0.000", CultureInfo.InvariantCulture),
				" cut ",
				num33.ToString("0.000", CultureInfo.InvariantCulture),
				" results ",
				IMDMGILBEIG.Count.ToString()
			}));
			for (int num36 = 0; num36 < IMDMGILBEIG.Count; num36++)
			{
				OJPLEKECIFI ojplekecifi2 = IMDMGILBEIG[num36];
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"    #",
					(num36 + 1).ToString(),
					" aind ",
					ojplekecifi2.PLMHNBPHMKP.ToString(),
					" score ",
					ojplekecifi2.AGMOECJFFJI.ToString("0.000", CultureInfo.InvariantCulture),
					" order ",
					ojplekecifi2.NJBCLIILMOF.ToString("0.000", CultureInfo.InvariantCulture),
					" hits ",
					ojplekecifi2.PAELDIINOLA.ToString(),
					" uiHits ",
					ojplekecifi2.BFDGIDOOELC.ToString()
				}));
			}
		}
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x0013A510 File Offset: 0x00138710
	static MKCHEIHILDB()
	{
		MKCHEIHILDB.ABGFBEBMJPE();
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x0013A574 File Offset: 0x00138774
	private static void OKLNOGEJONN(MKCHEIHILDB.BKOCIAEIGEJ PFFFECFKDGG, int OPEGPMCCBKM, bool BGFKEGCJHMH, bool HAMKGNNCGPE, bool PLEODKHLHBI)
	{
		MKCHEIHILDB.PLCCGINOHHG.Clear();
		Dictionary<string, GDAOFOFBLPF> lgmonccmedo = MLIBDDCCKBM.LGMONCCMEDO;
		GDAOFOFBLPF gdaofofblpf;
		if (PFFFECFKDGG.JENAEGCHCBA)
		{
			if (lgmonccmedo.TryGetValue(PFFFECFKDGG.JKLAKEDMACO, out gdaofofblpf))
			{
				MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, 1f, 0);
			}
			return;
		}
		if (PLEODKHLHBI)
		{
			if (lgmonccmedo.TryGetValue(PFFFECFKDGG.JKLAKEDMACO, out gdaofofblpf) && gdaofofblpf.KMHILDMHJMA && gdaofofblpf.NINBFOMIAEG <= MKCHEIHILDB.CPNHNNCOGLP)
			{
				MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, 1f, 0);
			}
			return;
		}
		if (lgmonccmedo.TryGetValue(PFFFECFKDGG.JKLAKEDMACO, out gdaofofblpf))
		{
			MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, 1f, 0);
		}
		if (!string.Equals(PFFFECFKDGG.EIHHPNCJMGD, PFFFECFKDGG.JKLAKEDMACO, StringComparison.Ordinal) && lgmonccmedo.TryGetValue(PFFFECFKDGG.EIHHPNCJMGD, out gdaofofblpf))
		{
			MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, 1f, 0);
		}
		if (PFFFECFKDGG.LDMEFKHCDFI != null && lgmonccmedo.TryGetValue(PFFFECFKDGG.LDMEFKHCDFI, out gdaofofblpf))
		{
			MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, MKCHEIHILDB.KLAOCLIIGIP, 0);
		}
		if (MKCHEIHILDB.PLCCGINOHHG.Count == 0 && PFFFECFKDGG.IELFPENPFOG >= 4)
		{
			for (int i = 0; i < 9; i++)
			{
				if (i != OPEGPMCCBKM)
				{
					string text = GADABGOBJIM.LFHDACDCILH(i, PFFFECFKDGG.EIHHPNCJMGD);
					if (!string.Equals(text, PFFFECFKDGG.JKLAKEDMACO, StringComparison.Ordinal) && !string.Equals(text, PFFFECFKDGG.EIHHPNCJMGD, StringComparison.Ordinal) && text.Length >= MKCHEIHILDB.ALIHMPEGADL && lgmonccmedo.TryGetValue(text, out gdaofofblpf))
					{
						MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, 1f, 0);
					}
				}
			}
		}
		int num = BGFKEGCJHMH ? MKCHEIHILDB.PLOBALBOLNL : 5;
		if (PFFFECFKDGG.IELFPENPFOG >= num)
		{
			float num2 = BGFKEGCJHMH ? MKCHEIHILDB.CDKNKMIOFOB : MKCHEIHILDB.PONABDHCJHD;
			int num3 = BGFKEGCJHMH ? MKCHEIHILDB.HEGJKIPKMJJ : MKCHEIHILDB.JNLGAPIEGGM;
			GDAOFOFBLPF[] jjmmilpeele = MLIBDDCCKBM.JJMMILPEELE;
			int num4 = MKCHEIHILDB.LCGEKENPBCE(jjmmilpeele, PFFFECFKDGG.JKLAKEDMACO);
			int num5 = 0;
			while (num4 < jjmmilpeele.Length && num5 < MKCHEIHILDB.AIBBOBBOLAE && MKCHEIHILDB.PNPGNMABMJC(jjmmilpeele[num4].JKLAKEDMACO, PFFFECFKDGG.JKLAKEDMACO))
			{
				GDAOFOFBLPF gdaofofblpf2 = jjmmilpeele[num4];
				num4++;
				num5++;
				if (PFFFECFKDGG.IELFPENPFOG >= 5 || gdaofofblpf2.KMHILDMHJMA || gdaofofblpf2.AHGIOFJBEAB)
				{
					int num6 = gdaofofblpf2.JKLAKEDMACO.Length - PFFFECFKDGG.JKLAKEDMACO.Length;
					if (0 < num6 && num6 <= num3)
					{
						float num7 = num2 - MKCHEIHILDB.EDJEGCGKKEN * (float)num6;
						if (num7 < MKCHEIHILDB.NAAAKNCCDJA)
						{
							num7 = MKCHEIHILDB.NAAAKNCCDJA;
						}
						MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf2, num7, 1);
					}
				}
			}
			if (PFFFECFKDGG.IELFPENPFOG >= 5)
			{
				for (int j = 5; j < PFFFECFKDGG.JKLAKEDMACO.Length; j++)
				{
					gdaofofblpf = MKCHEIHILDB.AMPLJAMLKKG(jjmmilpeele, PFFFECFKDGG.JKLAKEDMACO, j);
					if (gdaofofblpf != null)
					{
						int num8 = PFFFECFKDGG.JKLAKEDMACO.Length - j;
						if (num8 <= MKCHEIHILDB.JNLGAPIEGGM)
						{
							MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, MKCHEIHILDB.PKGKDHMGIII - MKCHEIHILDB.EDJEGCGKKEN * (float)num8, 1);
						}
						else if (HAMKGNNCGPE)
						{
							MKCHEIHILDB.ADLFEKADHNA(gdaofofblpf, MKCHEIHILDB.ILFGCELOHAI, 1);
						}
					}
				}
			}
		}
		if (MKCHEIHILDB.PLCCGINOHHG.Count == 0 && PFFFECFKDGG.IELFPENPFOG >= 5)
		{
			int num9 = (PFFFECFKDGG.IELFPENPFOG >= 8) ? 2 : 1;
			List<GDAOFOFBLPF>[] lknigbbmpmg = MLIBDDCCKBM.LKNIGBBMPMG;
			int num10 = PFFFECFKDGG.JKLAKEDMACO.Length - num9;
			if (num10 < MKCHEIHILDB.ALIHMPEGADL)
			{
				num10 = MKCHEIHILDB.ALIHMPEGADL;
			}
			int num11 = PFFFECFKDGG.JKLAKEDMACO.Length + num9;
			if (num11 > lknigbbmpmg.Length - 1)
			{
				num11 = lknigbbmpmg.Length - 1;
			}
			for (int k = num10; k <= num11; k++)
			{
				List<GDAOFOFBLPF> list = lknigbbmpmg[k];
				if (list != null)
				{
					for (int l = 0; l < list.Count; l++)
					{
						GDAOFOFBLPF gdaofofblpf3 = list[l];
						if (!gdaofofblpf3.OFELEAKFHJH && GADABGOBJIM.BENDHLBOJMA(gdaofofblpf3.JKLAKEDMACO, PFFFECFKDGG.JKLAKEDMACO) && GADABGOBJIM.OJFKHOJBCBJ(gdaofofblpf3.JKLAKEDMACO, PFFFECFKDGG.JKLAKEDMACO))
						{
							int num12 = GADABGOBJIM.HACOKLOMEIN(PFFFECFKDGG.JKLAKEDMACO, gdaofofblpf3.JKLAKEDMACO, num9);
							if (num12 <= num9)
							{
								MKCHEIHILDB.BJKBPICPBJN(gdaofofblpf3, (1 == num12) ? MKCHEIHILDB.CKJIFAPFLAB : MKCHEIHILDB.CGACPMLNNLK);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x0013A96C File Offset: 0x00138B6C
	private static void BJKBPICPBJN(GDAOFOFBLPF FOEEIJFHMGG, float NOGLFFOMDBN)
	{
		int num = MKCHEIHILDB.PLCCGINOHHG.Count;
		for (int i = 0; i < MKCHEIHILDB.PLCCGINOHHG.Count; i++)
		{
			MKCHEIHILDB.GJIFDKMJHGI gjifdkmjhgi = MKCHEIHILDB.PLCCGINOHHG[i];
			if (gjifdkmjhgi.FIOLEEOGPNO < NOGLFFOMDBN || (gjifdkmjhgi.FIOLEEOGPNO == NOGLFFOMDBN && gjifdkmjhgi.CALMBPNDMKP.NINBFOMIAEG < FOEEIJFHMGG.NINBFOMIAEG))
			{
				num = i;
				break;
			}
		}
		if (num >= MKCHEIHILDB.OELMFBPBCEO)
		{
			return;
		}
		MKCHEIHILDB.GJIFDKMJHGI item = default(MKCHEIHILDB.GJIFDKMJHGI);
		item.CALMBPNDMKP = FOEEIJFHMGG;
		item.FIOLEEOGPNO = NOGLFFOMDBN;
		item.IODLKFKJIHF = 2;
		MKCHEIHILDB.PLCCGINOHHG.Insert(num, item);
		if (MKCHEIHILDB.PLCCGINOHHG.Count > MKCHEIHILDB.OELMFBPBCEO)
		{
			MKCHEIHILDB.PLCCGINOHHG.RemoveAt(MKCHEIHILDB.PLCCGINOHHG.Count - 1);
		}
	}

	// Token: 0x06002CCC RID: 11468 RVA: 0x0013AA2A File Offset: 0x00138C2A
	private static string NGKMFHAOKOM(int EIABBAKCGNM)
	{
		if (1 == EIABBAKCGNM)
		{
			return "prefix";
		}
		if (2 == EIABBAKCGNM)
		{
			return "fuzzy";
		}
		return "exact";
	}

	// Token: 0x06002CCD RID: 11469 RVA: 0x0013AA48 File Offset: 0x00138C48
	private static bool IMMPGJLMFBO(OJPLEKECIFI MIDLEBAGDMN, OJPLEKECIFI DFNFPEMFNPN)
	{
		if (MIDLEBAGDMN.NJBCLIILMOF != DFNFPEMFNPN.NJBCLIILMOF)
		{
			return MIDLEBAGDMN.NJBCLIILMOF > DFNFPEMFNPN.NJBCLIILMOF;
		}
		if (MIDLEBAGDMN.AGMOECJFFJI != DFNFPEMFNPN.AGMOECJFFJI)
		{
			return MIDLEBAGDMN.AGMOECJFFJI > DFNFPEMFNPN.AGMOECJFFJI;
		}
		if (MIDLEBAGDMN.BFDGIDOOELC != DFNFPEMFNPN.BFDGIDOOELC)
		{
			return MIDLEBAGDMN.BFDGIDOOELC > DFNFPEMFNPN.BFDGIDOOELC;
		}
		return MIDLEBAGDMN.PAELDIINOLA > DFNFPEMFNPN.PAELDIINOLA;
	}

	// Token: 0x06002CCE RID: 11470 RVA: 0x0013AABC File Offset: 0x00138CBC
	private static void ADLFEKADHNA(GDAOFOFBLPF FOEEIJFHMGG, float NOGLFFOMDBN, int EIABBAKCGNM)
	{
		for (int i = 0; i < MKCHEIHILDB.PLCCGINOHHG.Count; i++)
		{
			if (MKCHEIHILDB.PLCCGINOHHG[i].CALMBPNDMKP == FOEEIJFHMGG)
			{
				if (NOGLFFOMDBN > MKCHEIHILDB.PLCCGINOHHG[i].FIOLEEOGPNO)
				{
					MKCHEIHILDB.GJIFDKMJHGI value = MKCHEIHILDB.PLCCGINOHHG[i];
					value.FIOLEEOGPNO = NOGLFFOMDBN;
					value.IODLKFKJIHF = EIABBAKCGNM;
					MKCHEIHILDB.PLCCGINOHHG[i] = value;
				}
				return;
			}
		}
		MKCHEIHILDB.GJIFDKMJHGI item = default(MKCHEIHILDB.GJIFDKMJHGI);
		item.CALMBPNDMKP = FOEEIJFHMGG;
		item.FIOLEEOGPNO = NOGLFFOMDBN;
		item.IODLKFKJIHF = EIABBAKCGNM;
		MKCHEIHILDB.PLCCGINOHHG.Add(item);
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x0013AB58 File Offset: 0x00138D58
	private static int LCGEKENPBCE(GDAOFOFBLPF[] JOFCKIFBACA, string MJHGIIEINOE)
	{
		int i = 0;
		int num = JOFCKIFBACA.Length;
		while (i < num)
		{
			int num2 = i + (num - i >> 1);
			if (string.CompareOrdinal(JOFCKIFBACA[num2].JKLAKEDMACO, MJHGIIEINOE) < 0)
			{
				i = num2 + 1;
			}
			else
			{
				num = num2;
			}
		}
		return i;
	}

	// Token: 0x06002CD0 RID: 11472 RVA: 0x0013AB94 File Offset: 0x00138D94
	public static void ABGFBEBMJPE()
	{
		MKCHEIHILDB.KCEJOFCMKDO = 8;
		MKCHEIHILDB.MKGMKMODECM = 0.7f;
		MKCHEIHILDB.HMCIGDENMCD = 0.5f;
		MKCHEIHILDB.PONABDHCJHD = 0.7f;
		MKCHEIHILDB.PKGKDHMGIII = 0.6f;
		MKCHEIHILDB.EDJEGCGKKEN = 0.1f;
		MKCHEIHILDB.NAAAKNCCDJA = 0.4f;
		MKCHEIHILDB.JNLGAPIEGGM = 4;
		MKCHEIHILDB.CDKNKMIOFOB = 0.9f;
		MKCHEIHILDB.HEGJKIPKMJJ = 32;
		MKCHEIHILDB.PLOBALBOLNL = 3;
		MKCHEIHILDB.ILFGCELOHAI = 0.5f;
		MKCHEIHILDB.CKJIFAPFLAB = 0.5f;
		MKCHEIHILDB.CGACPMLNNLK = 0.3f;
		MKCHEIHILDB.OELMFBPBCEO = 8;
		MKCHEIHILDB.ALIHMPEGADL = 5;
		MKCHEIHILDB.AIBBOBBOLAE = 64;
		MKCHEIHILDB.KELFHIFOIBJ = 0.1f;
		MKCHEIHILDB.IAHCPBLNAHI = 0.5f;
		MKCHEIHILDB.LGMABIBFFEN = 1.15f;
		MKCHEIHILDB.HHHJBPNNHEA = 0.05f;
		MKCHEIHILDB.CEHDIDMDPFD = 0.3f;
		MKCHEIHILDB.BMIJFBHDKKM = 0.15f;
		MKCHEIHILDB.KLAOCLIIGIP = 0.9f;
		MKCHEIHILDB.ONOFPGCDGDP = 0.5f;
		MKCHEIHILDB.CPNHNNCOGLP = 6;
		MKCHEIHILDB.KGMIIPCDIMK = 1f;
	}

	// Token: 0x06002CD1 RID: 11473 RVA: 0x0013AC94 File Offset: 0x00138E94
	private static GDAOFOFBLPF AMPLJAMLKKG(GDAOFOFBLPF[] JOFCKIFBACA, string DIMBCOBNMAM, int CFAGLGEOFIF)
	{
		int i = 0;
		int num = JOFCKIFBACA.Length;
		while (i < num)
		{
			int num2 = i + (num - i >> 1);
			if (string.CompareOrdinal(JOFCKIFBACA[num2].JKLAKEDMACO, 0, DIMBCOBNMAM, 0, CFAGLGEOFIF) < 0)
			{
				i = num2 + 1;
			}
			else
			{
				num = num2;
			}
		}
		if (i < JOFCKIFBACA.Length)
		{
			GDAOFOFBLPF gdaofofblpf = JOFCKIFBACA[i];
			if (gdaofofblpf.JKLAKEDMACO.Length == CFAGLGEOFIF && string.CompareOrdinal(gdaofofblpf.JKLAKEDMACO, 0, DIMBCOBNMAM, 0, CFAGLGEOFIF) == 0)
			{
				return gdaofofblpf;
			}
		}
		return null;
	}

	// Token: 0x06002CD2 RID: 11474 RVA: 0x0013AD00 File Offset: 0x00138F00
	private static bool CCIEKIAAJOB(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		for (int i = 0; i < DIMBCOBNMAM.Length; i++)
		{
			if (!char.IsWhiteSpace(DIMBCOBNMAM[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x04000DBE RID: 3518
	public static int KCEJOFCMKDO;

	// Token: 0x04000DBF RID: 3519
	public static float MKGMKMODECM;

	// Token: 0x04000DC0 RID: 3520
	public static float HMCIGDENMCD;

	// Token: 0x04000DC1 RID: 3521
	public static float PONABDHCJHD;

	// Token: 0x04000DC2 RID: 3522
	public static float PKGKDHMGIII;

	// Token: 0x04000DC3 RID: 3523
	public static float EDJEGCGKKEN;

	// Token: 0x04000DC4 RID: 3524
	public static float NAAAKNCCDJA;

	// Token: 0x04000DC5 RID: 3525
	public static int JNLGAPIEGGM;

	// Token: 0x04000DC6 RID: 3526
	public static float CDKNKMIOFOB;

	// Token: 0x04000DC7 RID: 3527
	public static int HEGJKIPKMJJ;

	// Token: 0x04000DC8 RID: 3528
	public static int PLOBALBOLNL;

	// Token: 0x04000DC9 RID: 3529
	public static float ILFGCELOHAI;

	// Token: 0x04000DCA RID: 3530
	public static float CKJIFAPFLAB;

	// Token: 0x04000DCB RID: 3531
	public static float CGACPMLNNLK;

	// Token: 0x04000DCC RID: 3532
	public static int OELMFBPBCEO;

	// Token: 0x04000DCD RID: 3533
	public static int ALIHMPEGADL;

	// Token: 0x04000DCE RID: 3534
	public static int AIBBOBBOLAE;

	// Token: 0x04000DCF RID: 3535
	public static float KELFHIFOIBJ;

	// Token: 0x04000DD0 RID: 3536
	public static float IAHCPBLNAHI;

	// Token: 0x04000DD1 RID: 3537
	public static float LGMABIBFFEN;

	// Token: 0x04000DD2 RID: 3538
	public static float HHHJBPNNHEA;

	// Token: 0x04000DD3 RID: 3539
	public static float CEHDIDMDPFD;

	// Token: 0x04000DD4 RID: 3540
	public static float BMIJFBHDKKM;

	// Token: 0x04000DD5 RID: 3541
	public static float KLAOCLIIGIP;

	// Token: 0x04000DD6 RID: 3542
	public static float ONOFPGCDGDP;

	// Token: 0x04000DD7 RID: 3543
	public static int CPNHNNCOGLP;

	// Token: 0x04000DD8 RID: 3544
	public static float KGMIIPCDIMK;

	// Token: 0x04000DD9 RID: 3545
	private static readonly List<string> MJGDNDEOOKE = new List<string>(16);

	// Token: 0x04000DDA RID: 3546
	private static readonly List<MKCHEIHILDB.BKOCIAEIGEJ> MJJDIAMBPEA = new List<MKCHEIHILDB.BKOCIAEIGEJ>(8);

	// Token: 0x04000DDB RID: 3547
	private static readonly List<MKCHEIHILDB.GJIFDKMJHGI> PLCCGINOHHG = new List<MKCHEIHILDB.GJIFDKMJHGI>(96);

	// Token: 0x04000DDC RID: 3548
	private static readonly List<MKCHEIHILDB.JAHKKNMKBKD> AOJJCLBMOEI = new List<MKCHEIHILDB.JAHKKNMKBKD>(32);

	// Token: 0x04000DDD RID: 3549
	private static float[] JBCCPONLIPP = new float[8];

	// Token: 0x04000DDE RID: 3550
	private static bool OPMOFGDDHJN = false;

	// Token: 0x04000DDF RID: 3551
	private static readonly StringBuilder BFFMKFENEHG = new StringBuilder(256);

	// Token: 0x02000160 RID: 352
	private struct BKOCIAEIGEJ
	{
		// Token: 0x04000DE0 RID: 3552
		public string DGDHGMPEMEI;

		// Token: 0x04000DE1 RID: 3553
		public string JKLAKEDMACO;

		// Token: 0x04000DE2 RID: 3554
		public string EIHHPNCJMGD;

		// Token: 0x04000DE3 RID: 3555
		public string LDMEFKHCDFI;

		// Token: 0x04000DE4 RID: 3556
		public int IELFPENPFOG;

		// Token: 0x04000DE5 RID: 3557
		public bool JENAEGCHCBA;
	}

	// Token: 0x02000161 RID: 353
	private struct GJIFDKMJHGI
	{
		// Token: 0x04000DE6 RID: 3558
		public GDAOFOFBLPF CALMBPNDMKP;

		// Token: 0x04000DE7 RID: 3559
		public float FIOLEEOGPNO;

		// Token: 0x04000DE8 RID: 3560
		public int IODLKFKJIHF;
	}

	// Token: 0x02000162 RID: 354
	private struct JAHKKNMKBKD
	{
		// Token: 0x04000DE9 RID: 3561
		public int PLMHNBPHMKP;

		// Token: 0x04000DEA RID: 3562
		public int ENBBONPKHBC;

		// Token: 0x04000DEB RID: 3563
		public ushort OGPKMMOIHLG;

		// Token: 0x04000DEC RID: 3564
		public float FMKCKAHEEAF;

		// Token: 0x04000DED RID: 3565
		public bool EADLLKEANLI;

		// Token: 0x04000DEE RID: 3566
		public float HDMHKHHHHLE;
	}
}
