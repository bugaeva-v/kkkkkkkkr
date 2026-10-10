using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x0200052E RID: 1326
public static class DHFLKLPKNJG
{
	// Token: 0x0600A1D4 RID: 41428 RVA: 0x0045FBA8 File Offset: 0x0045DDA8
	public static bool JHLMGHEHHBI(ECJCFGAOPHJ FFACCDIEBIA)
	{
		return DHFLKLPKNJG.FIPHMDGKAAH(FFACCDIEBIA) && FFACCDIEBIA.HLEOLMIFCGI() && (FFACCDIEBIA.MNBBOAPGCMM <= 0 || !AppManager.EHBBFMCILPC.UnsupportedRevision(FFACCDIEBIA.MNBBOAPGCMM)) && (AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(FFACCDIEBIA.OBLBNLBFBNI) || !FFACCDIEBIA.PPBPOPEEPDJ(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA()));
	}

	// Token: 0x0600A1D5 RID: 41429 RVA: 0x0045FC0D File Offset: 0x0045DE0D
	public static List<HECEJCDAIOJ> DCCLCEAJPFL(int PLKMJJIIJNO)
	{
		return DHFLKLPKNJG.DCCLCEAJPFL(PLKMJJIIJNO, null);
	}

	// Token: 0x0600A1D6 RID: 41430 RVA: 0x0045FC16 File Offset: 0x0045DE16
	public static Sprite OLLDCINAIAD(int GELBBKHCIBA)
	{
		if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.profileDataAsset5)
		{
			return null;
		}
		return AssetsManager.EHBBFMCILPC.profileDataAsset5.OLLDCINAIAD(GELBBKHCIBA);
	}

	// Token: 0x0600A1D7 RID: 41431 RVA: 0x0045FC4C File Offset: 0x0045DE4C
	private static string PEGBIHBAELO(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null || DIMBCOBNMAM.Length == 0)
		{
			return DIMBCOBNMAM;
		}
		bool flag = false;
		for (int i = 0; i < DIMBCOBNMAM.Length; i++)
		{
			char c = DIMBCOBNMAM[i];
			if ('<' == c)
			{
				flag = true;
			}
			else if ('>' == c)
			{
				flag = false;
			}
			else if (!flag && char.IsLetter(c))
			{
				if (char.IsUpper(c))
				{
					return DIMBCOBNMAM;
				}
				return DIMBCOBNMAM.Substring(0, i) + char.ToUpper(c).ToString() + DIMBCOBNMAM.Substring(i + 1);
			}
		}
		return DIMBCOBNMAM;
	}

	// Token: 0x0600A1D8 RID: 41432 RVA: 0x0045FCCE File Offset: 0x0045DECE
	public static bool FIPHMDGKAAH(ECJCFGAOPHJ FFACCDIEBIA)
	{
		return FFACCDIEBIA != null && FFACCDIEBIA.LMEALGJPGDA() && FFACCDIEBIA.OBLBNLBFBNI >= 0 && FFACCDIEBIA.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x0600A1D9 RID: 41433 RVA: 0x0045FCF4 File Offset: 0x0045DEF4
	public static string OGDMMEGFLIK(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null || FOEEIJFHMGG.OLAKHHEICKO < 0)
		{
			return null;
		}
		string text = DHFLKLPKNJG.IFNFJKFJBGB("loungebonus" + FOEEIJFHMGG.OLAKHHEICKO.ToString());
		if (text == null)
		{
			return null;
		}
		return DHFLKLPKNJG.OICMDBFLBCA(text, FOEEIJFHMGG.MDKIKKJNJKK, FOEEIJFHMGG.JNCJNLEAFLG);
	}

	// Token: 0x0600A1DA RID: 41434 RVA: 0x0045FD41 File Offset: 0x0045DF41
	public static bool FGKONCADNNO(HECEJCDAIOJ FOEEIJFHMGG)
	{
		return FOEEIJFHMGG != null && AKLFPGMDKLA.EHBBFMCILPC != null && (FOEEIJFHMGG.JOBAGHGMDHC == BGDLJKJPOOO.iapOnly || FOEEIJFHMGG.LEAFNBOALFN) && AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(FOEEIJFHMGG.IPICGONHLAM);
	}

	// Token: 0x0600A1DB RID: 41435 RVA: 0x0045FD74 File Offset: 0x0045DF74
	public static string FMLFBFCPPPJ(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return null;
		}
		return DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfotitle" + Mathf.Clamp(FOEEIJFHMGG.IPICGONHLAM, 0, 4).ToString());
	}

	// Token: 0x0600A1DC RID: 41436 RVA: 0x0045FDAC File Offset: 0x0045DFAC
	public static List<int> GNEJAPMDJPI(int PLKMJJIIJNO, List<string> MKLBDPIIBNE)
	{
		List<int> list = new List<int>();
		try
		{
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			HFDAGKJJHOA hfdagkjjhoa = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE();
			if (hfdagkjjhoa == null)
			{
				return list;
			}
			long celgkakngbg = AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
			List<FJLGCKNOJMJ> list2 = hfdagkjjhoa.JPPCGJEMJBF();
			for (int i = 0; i < list2.Count; i++)
			{
				FJLGCKNOJMJ fjlgcknojmj = list2[i];
				if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB && (PLKMJJIIJNO < 0 || fjlgcknojmj.AMKCLHLIIMN == PLKMJJIIJNO) && DHFLKLPKNJG.IKOPPGGEIAJ(fjlgcknojmj.AMKCLHLIIMN))
				{
					for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO.Count; j++)
					{
						DMDNKJKEPKO dmdnkjkepko = fjlgcknojmj.OINAAMKLNLO[j];
						if (dmdnkjkepko != null && (MKLBDPIIBNE == null || MKLBDPIIBNE.Contains(dmdnkjkepko.KALBADOPCDN)))
						{
							for (int k = 0; k < dmdnkjkepko.KKEENPEFFBJ.Count; k++)
							{
								ECJCFGAOPHJ ecjcfgaophj = dmdnkjkepko.KKEENPEFFBJ[k];
								if (ecjcfgaophj != null && ecjcfgaophj.LMEALGJPGDA() && ecjcfgaophj.OBLBNLBFBNI >= 0 && ecjcfgaophj.PODGFLMDBEC != BGDLJKJPOOO.none && ecjcfgaophj.HLEOLMIFCGI() && (ecjcfgaophj.MNBBOAPGCMM <= 0 || !AppManager.EHBBFMCILPC.UnsupportedRevision(ecjcfgaophj.MNBBOAPGCMM)) && (AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(ecjcfgaophj.OBLBNLBFBNI) || !ecjcfgaophj.PPBPOPEEPDJ(celgkakngbg)))
								{
									list.Add(ecjcfgaophj.OBLBNLBFBNI);
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600A1DD RID: 41437 RVA: 0x0045FF88 File Offset: 0x0045E188
	public static string ADJENEJBFJE(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return null;
		}
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfoidentity" + Mathf.Clamp(FOEEIJFHMGG.IPICGONHLAM, 0, 4).ToString());
		if (text4 != null)
		{
			string text5 = GKJPOGNFKNK.HPAHOEOKEBB("anthology" + FOEEIJFHMGG.AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text5 == null || text5.EndsWith("_not_found"))
			{
				text5 = "";
			}
			string text6 = DHFLKLPKNJG.GDJKDPKNAMB(FOEEIJFHMGG.KALBADOPCDN);
			if (text5.Length > 0 && text6 != null && text6.Length > 0)
			{
				text = DHFLKLPKNJG.MLGGAOHIJGA(text, text4.Replace("{skin}", DHFLKLPKNJG.MDIPDBDPIEJ(FOEEIJFHMGG.BDIHOCKCCBL)).Replace("{character}", text6).Replace("{story}", text5));
			}
		}
		if (!FOEEIJFHMGG.MAFBMDFOBGH)
		{
			text2 = DHFLKLPKNJG.MLGGAOHIJGA(text2, DHFLKLPKNJG.FJDMMBKEMLC(DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfounlockgate"), FOEEIJFHMGG.FEJEPPDIDJE, FOEEIJFHMGG.EBDFCICNAOE));
		}
		if (FOEEIJFHMGG.OLAKHHEICKO >= 0)
		{
			text3 = DHFLKLPKNJG.MLGGAOHIJGA(text3, DHFLKLPKNJG.FJDMMBKEMLC(DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfobonus" + FOEEIJFHMGG.OLAKHHEICKO.ToString()), FOEEIJFHMGG.MDKIKKJNJKK, FOEEIJFHMGG.JNCJNLEAFLG));
		}
		if (FOEEIJFHMGG.PMFNECKIMBG)
		{
			text3 = DHFLKLPKNJG.MLGGAOHIJGA(text3, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfolireq"));
		}
		return DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM("", text), text2), text3), DHFLKLPKNJG.PJHNFOHOGDF()), DHFLKLPKNJG.PHFEHFNPADJ(FOEEIJFHMGG));
	}

	// Token: 0x0600A1DE RID: 41438 RVA: 0x00460120 File Offset: 0x0045E320
	public static bool BBKPPACFGHE(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return false;
		}
		string text = DHFLKLPKNJG.FMLFBFCPPPJ(FOEEIJFHMGG);
		string text2;
		if (FOEEIJFHMGG.OPFKKIBPPID)
		{
			text2 = DHFLKLPKNJG.ADJENEJBFJE(FOEEIJFHMGG);
		}
		else
		{
			text2 = DHFLKLPKNJG.FIJILDPKLFN(FOEEIJFHMGG);
		}
		if (text == null || text.Length == 0 || text2 == null || text2.Length == 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[SkinShop] info popup skipped, texts not imported: " + FOEEIJFHMGG.BDIHOCKCCBL);
			return false;
		}
		int lindilppnnk = DHFLKLPKNJG.CGNDDBHPPLC(text2);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(text, text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSkinShopInfo, 0f, lindilppnnk);
		return true;
	}

	// Token: 0x0600A1DF RID: 41439 RVA: 0x004601AC File Offset: 0x0045E3AC
	public static string ALJDCCNGIIM(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return "";
		}
		string text = KBOJLHAJPCP.KACBFPFFJEO[FOEEIJFHMGG.IPICGONHLAM] + " " + DHFLKLPKNJG.HGPOMLKJGNE(FOEEIJFHMGG);
		string text2 = DHFLKLPKNJG.HOJINNKONMP(FOEEIJFHMGG);
		if (text2 != null)
		{
			text = string.Concat(new string[]
			{
				text,
				"\n",
				KBOJLHAJPCP.DJGPGIKKCKH,
				" ",
				text2
			});
		}
		string text3 = DHFLKLPKNJG.OGDMMEGFLIK(FOEEIJFHMGG);
		if (text3 != null)
		{
			text = string.Concat(new string[]
			{
				text,
				"\n",
				KBOJLHAJPCP.DLGEKDBIJCH,
				" ",
				text3
			});
		}
		return text;
	}

	// Token: 0x0600A1E0 RID: 41440 RVA: 0x0046024C File Offset: 0x0045E44C
	public static string FIJILDPKLFN(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return null;
		}
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfoidentity" + Mathf.Clamp(FOEEIJFHMGG.IPICGONHLAM, 0, 4).ToString());
		if (text5 != null)
		{
			string text6 = GKJPOGNFKNK.HPAHOEOKEBB("anthology" + FOEEIJFHMGG.AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text6 == null || text6.EndsWith("_not_found"))
			{
				text6 = "";
			}
			string text7 = DHFLKLPKNJG.GDJKDPKNAMB(FOEEIJFHMGG.KALBADOPCDN);
			if (text6.Length > 0 && text7 != null && text7.Length > 0)
			{
				text = DHFLKLPKNJG.MLGGAOHIJGA(text, text5.Replace("{skin}", DHFLKLPKNJG.MDIPDBDPIEJ(FOEEIJFHMGG.BDIHOCKCCBL)).Replace("{character}", text7).Replace("{story}", text6));
			}
		}
		if (FOEEIJFHMGG.OIKGLAAHHJF)
		{
			if (FOEEIJFHMGG.MAFBMDFOBGH)
			{
				text2 = DHFLKLPKNJG.MLGGAOHIJGA(text2, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfoowned"));
			}
			else
			{
				text2 = DHFLKLPKNJG.MLGGAOHIJGA(text2, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfoownedgated"));
				text2 = DHFLKLPKNJG.MLGGAOHIJGA(text2, DHFLKLPKNJG.FJDMMBKEMLC(DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfounlockgate"), FOEEIJFHMGG.FEJEPPDIDJE, FOEEIJFHMGG.EBDFCICNAOE));
			}
		}
		else if (FOEEIJFHMGG.MAFBMDFOBGH)
		{
			text2 = DHFLKLPKNJG.MLGGAOHIJGA(text2, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfounlocknow"));
		}
		else
		{
			text2 = DHFLKLPKNJG.MLGGAOHIJGA(text2, DHFLKLPKNJG.FJDMMBKEMLC(DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfounlockgate"), FOEEIJFHMGG.FEJEPPDIDJE, FOEEIJFHMGG.EBDFCICNAOE));
		}
		if (FOEEIJFHMGG.OLAKHHEICKO >= 0)
		{
			text3 = DHFLKLPKNJG.MLGGAOHIJGA(text3, DHFLKLPKNJG.FJDMMBKEMLC(DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfobonus" + FOEEIJFHMGG.OLAKHHEICKO.ToString()), FOEEIJFHMGG.MDKIKKJNJKK, FOEEIJFHMGG.JNCJNLEAFLG));
		}
		if (FOEEIJFHMGG.PMFNECKIMBG)
		{
			text3 = DHFLKLPKNJG.MLGGAOHIJGA(text3, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfolireq"));
		}
		long num = 0L;
		if (FOEEIJFHMGG.HMJELDILAPC)
		{
			num = FOEEIJFHMGG.JADMHPJBCOF - AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
			if (num < 0L)
			{
				num = 0L;
			}
		}
		bool flag = FOEEIJFHMGG.HMJELDILAPC && num <= 0L;
		if (!FOEEIJFHMGG.OIKGLAAHHJF && !flag)
		{
			bool flag2 = DHFLKLPKNJG.FGKONCADNNO(FOEEIJFHMGG);
			if (flag2)
			{
				text4 = DHFLKLPKNJG.MLGGAOHIJGA(text4, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfotoken"));
			}
			else if (FOEEIJFHMGG.LEAFNBOALFN && FOEEIJFHMGG.IONJPGKLGLJ != null && FOEEIJFHMGG.IONJPGKLGLJ.Length > 0)
			{
				text4 = DHFLKLPKNJG.MLGGAOHIJGA(text4, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfodual"));
			}
			if (FOEEIJFHMGG.HMJELDILAPC)
			{
				bool mkcmihpglcn = num >= 86400L;
				string text8 = (FOEEIJFHMGG.JGEDHIMPKCL > 0 && !flag2) ? DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfotimeddiscount") : DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfotimed");
				if (text8 != null)
				{
					text4 = DHFLKLPKNJG.MLGGAOHIJGA(text4, text8.Replace("{time}", DPGJIJGOCIC.LCOMEDGJNMP((int)num, mkcmihpglcn, false)).Replace("{percent}", FOEEIJFHMGG.JGEDHIMPKCL.ToString() ?? ""));
				}
			}
		}
		return DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM(DHFLKLPKNJG.ICNKNOELLDM("", text), text2), text3), text4), DHFLKLPKNJG.PJHNFOHOGDF()), DHFLKLPKNJG.PHFEHFNPADJ(FOEEIJFHMGG));
	}

	// Token: 0x0600A1E1 RID: 41441 RVA: 0x00460579 File Offset: 0x0045E779
	public static bool IKOPPGGEIAJ(int PLKMJJIIJNO)
	{
		return !(null == AssetsManager.EHBBFMCILPC) && !(null == GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO));
	}

	// Token: 0x0600A1E2 RID: 41442 RVA: 0x0046059C File Offset: 0x0045E79C
	public static HECEJCDAIOJ FEGCAFLOKBC(int PLKMJJIIJNO, string FBKAPCPPNKA)
	{
		if (FBKAPCPPNKA == null || FBKAPCPPNKA.Length == 0)
		{
			return null;
		}
		List<HECEJCDAIOJ> list = DHFLKLPKNJG.DCCLCEAJPFL(PLKMJJIIJNO);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && FBKAPCPPNKA == list[i].BDIHOCKCCBL)
			{
				return list[i];
			}
		}
		return null;
	}

	// Token: 0x0600A1E3 RID: 41443 RVA: 0x004605F4 File Offset: 0x0045E7F4
	private static string EENGPKMHFKL(HECEJCDAIOJ FOEEIJFHMGG, string KIDHBAMJGDO)
	{
		if (FOEEIJFHMGG == null || !FOEEIJFHMGG.PMFNECKIMBG)
		{
			return KIDHBAMJGDO;
		}
		string text = DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumlireq");
		if (text == null || text.Length == 0)
		{
			return KIDHBAMJGDO;
		}
		return KIDHBAMJGDO + " " + text;
	}

	// Token: 0x0600A1E4 RID: 41444 RVA: 0x00460632 File Offset: 0x0045E832
	public static string FGGAAMNCOOE(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null || !FOEEIJFHMGG.PMFNECKIMBG)
		{
			return null;
		}
		return DHFLKLPKNJG.IFNFJKFJBGB("loungelireq");
	}

	// Token: 0x0600A1E5 RID: 41445 RVA: 0x0046064B File Offset: 0x0045E84B
	private static int ENMFKCBFBEE(HECEJCDAIOJ MIDLEBAGDMN, HECEJCDAIOJ DFNFPEMFNPN)
	{
		if (MIDLEBAGDMN.HMJELDILAPC != DFNFPEMFNPN.HMJELDILAPC)
		{
			if (!MIDLEBAGDMN.HMJELDILAPC)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			if (MIDLEBAGDMN.OBLBNLBFBNI == DFNFPEMFNPN.OBLBNLBFBNI)
			{
				return 0;
			}
			if (MIDLEBAGDMN.OBLBNLBFBNI <= DFNFPEMFNPN.OBLBNLBFBNI)
			{
				return 1;
			}
			return -1;
		}
	}

	// Token: 0x0600A1E6 RID: 41446 RVA: 0x00460688 File Offset: 0x0045E888
	public static string HOJINNKONMP(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return null;
		}
		if (FOEEIJFHMGG.MAFBMDFOBGH)
		{
			return DHFLKLPKNJG.IFNFJKFJBGB("skinshopunlocknow");
		}
		string text = DHFLKLPKNJG.IFNFJKFJBGB("loungelockedinfo");
		if (text == null)
		{
			return null;
		}
		return DHFLKLPKNJG.OICMDBFLBCA(text, FOEEIJFHMGG.FEJEPPDIDJE, FOEEIJFHMGG.EBDFCICNAOE);
	}

	// Token: 0x0600A1E7 RID: 41447 RVA: 0x004606D0 File Offset: 0x0045E8D0
	public static string GDJKDPKNAMB(string OKDNLCOEOIJ)
	{
		string text = "";
		try
		{
			if (OKDNLCOEOIJ == null || OKDNLCOEOIJ.Length == 0)
			{
				return "";
			}
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				DMDNKJKEPKO dmdnkjkepko = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DLCFCKOCIGB(OKDNLCOEOIJ);
				if (dmdnkjkepko != null && dmdnkjkepko.KMHILDMHJMA != null && dmdnkjkepko.KMHILDMHJMA.Length > 0)
				{
					string text2 = GKJPOGNFKNK.HPAHOEOKEBB(dmdnkjkepko.KMHILDMHJMA, "lititle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
					if (text2 != null && text2.Length > 0 && !text2.EndsWith("_not_found"))
					{
						text = text2;
					}
				}
			}
			if (text.Length == 0 && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
			{
				JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
				if (null != jsonarray)
				{
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONObject asObject = jsonarray[i].AsObject;
						string text3 = asObject["oid"];
						if (text3 != null && text3.Replace(" ", "").Equals(OKDNLCOEOIJ))
						{
							string text4 = asObject["lititle"];
							if (text4 == null || text4.Replace(" ", "").Length == 0)
							{
								string text5 = asObject["var"];
								string text6 = asObject["ant"];
								text4 = ((text5 != null) ? text5.Replace(" ", "") : "") + ((text6 != null) ? text6.Replace(" ", "") : "");
							}
							if (text4 != null && text4.Replace(" ", "").Length != 0)
							{
								string text7 = GKJPOGNFKNK.HPAHOEOKEBB(text4.Replace(" ", ""), "lititle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
								if (text7 != null && text7.Length > 0 && !text7.EndsWith("_not_found"))
								{
									text = text7;
									break;
								}
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (text.Length == 0)
		{
			text = OKDNLCOEOIJ;
		}
		return text;
	}

	// Token: 0x0600A1E8 RID: 41448 RVA: 0x0046093C File Offset: 0x0045EB3C
	public static string KCPIJEOEELJ(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return "";
		}
		if (!FOEEIJFHMGG.OIKGLAAHHJF && DHFLKLPKNJG.FGKONCADNNO(FOEEIJFHMGG))
		{
			return "<space=0.33em><space=0.31em>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfree") + "<space=0.125em>" + KBOJLHAJPCP.GOEIBHCAJLM;
		}
		if (FOEEIJFHMGG.JOBAGHGMDHC == BGDLJKJPOOO.iapOnly)
		{
			if (FOEEIJFHMGG.IONJPGKLGLJ != null && FOEEIJFHMGG.IONJPGKLGLJ.Length > 0)
			{
				return "<space=0.33em><space=0.31em>" + FOEEIJFHMGG.IONJPGKLGLJ + "<space=0.125em>" + KBOJLHAJPCP.GOEIBHCAJLM;
			}
			DPGJIJGOCIC.ADFCDFHBDAF("[SkinShop] IAP look without a resolvable store price (shop " + FOEEIJFHMGG.OBLBNLBFBNI.ToString() + "), cost hidden");
			return "";
		}
		else
		{
			string text = DHFLKLPKNJG.BONKOEABHBH(FOEEIJFHMGG.JOBAGHGMDHC, FOEEIJFHMGG.LEAFNBOALFN && FOEEIJFHMGG.IONJPGKLGLJ != null && FOEEIJFHMGG.IONJPGKLGLJ.Length > 0);
			if (FOEEIJFHMGG.OAOMKNHCHGO < 0)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[SkinShop] look without a resolvable amount (shop " + FOEEIJFHMGG.OBLBNLBFBNI.ToString() + "), cost hidden");
				return "";
			}
			return string.Concat(new string[]
			{
				"<space=0.33em>",
				(text.Length > 0) ? "<space=0.24em>" : "",
				FOEEIJFHMGG.OAOMKNHCHGO.ToString(),
				"<space=0.125em>",
				text
			});
		}
	}

	// Token: 0x0600A1E9 RID: 41449 RVA: 0x00460A88 File Offset: 0x0045EC88
	public static string OICMDBFLBCA(string DIMBCOBNMAM, int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		int num = 1;
		try
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(NLLCKPCKGOH);
			if (null != assetAnthology && null != assetAnthology.header)
			{
				num = assetAnthology.header.CJJOGBNCCCH(NLLCKPCKGOH) + 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DIMBCOBNMAM.Replace("XXX", (OLKMHHNMDLP + 1).ToString() ?? "").Replace("YYY", num.ToString() ?? "");
	}

	// Token: 0x0600A1EA RID: 41450 RVA: 0x00460B18 File Offset: 0x0045ED18
	private static string FJDMMBKEMLC(string DIMBCOBNMAM, int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		if (DIMBCOBNMAM == null || DIMBCOBNMAM.Length == 0)
		{
			return null;
		}
		return DHFLKLPKNJG.OICMDBFLBCA(DIMBCOBNMAM, NLLCKPCKGOH, OLKMHHNMDLP);
	}

	// Token: 0x0600A1EB RID: 41451 RVA: 0x00460B30 File Offset: 0x0045ED30
	private static string PJHNFOHOGDF()
	{
		string text = DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosummary");
		if (text == null || text.Length == 0)
		{
			return null;
		}
		return "<align=\"center\">" + text + "</align>";
	}

	// Token: 0x0600A1EC RID: 41452 RVA: 0x00460B65 File Offset: 0x0045ED65
	private static string BONKOEABHBH(BGDLJKJPOOO KCMMNPLNPGL, bool JOHKACKAGEI)
	{
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency0)
		{
			if (!JOHKACKAGEI)
			{
				return KBOJLHAJPCP.DBCAFJGPECE;
			}
			return KBOJLHAJPCP.NENCABBIJOK;
		}
		else if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency1)
		{
			if (!JOHKACKAGEI)
			{
				return KBOJLHAJPCP.DGMDEJKHKFL;
			}
			return KBOJLHAJPCP.PCGOLCMNFBI;
		}
		else
		{
			if (KCMMNPLNPGL != BGDLJKJPOOO.specialCurrency2)
			{
				return "";
			}
			if (!JOHKACKAGEI)
			{
				return KBOJLHAJPCP.KMEBHIBPPJC;
			}
			return KBOJLHAJPCP.AAHIADFKCKH;
		}
	}

	// Token: 0x0600A1ED RID: 41453 RVA: 0x00460BA4 File Offset: 0x0045EDA4
	private static string ICNKNOELLDM(string BHJJLJJACFE, string DFFHLDNHDPM)
	{
		if (DFFHLDNHDPM == null || DFFHLDNHDPM.Length == 0)
		{
			return BHJJLJJACFE;
		}
		if (BHJJLJJACFE == null || BHJJLJJACFE.Length == 0)
		{
			return DFFHLDNHDPM;
		}
		return BHJJLJJACFE + "\n\n" + DFFHLDNHDPM;
	}

	// Token: 0x0600A1EE RID: 41454 RVA: 0x00460BCC File Offset: 0x0045EDCC
	private static string OCFJFALEDBB(string AEENFDHAGGG, string AFHIPGHANJE, string KIDHBAMJGDO)
	{
		if (AFHIPGHANJE == null || AFHIPGHANJE.Length == 0 || KIDHBAMJGDO == null || KIDHBAMJGDO.Length == 0)
		{
			return AEENFDHAGGG;
		}
		string text = AFHIPGHANJE + " <i>" + DHFLKLPKNJG.PEGBIHBAELO(KIDHBAMJGDO) + "</i>";
		if (AEENFDHAGGG == null || AEENFDHAGGG.Length == 0)
		{
			return text;
		}
		return AEENFDHAGGG + "\n" + text;
	}

	// Token: 0x0600A1EF RID: 41455 RVA: 0x00460C24 File Offset: 0x0045EE24
	public static List<HECEJCDAIOJ> DCCLCEAJPFL(int PLKMJJIIJNO, List<string> MKLBDPIIBNE)
	{
		List<HECEJCDAIOJ> list = new List<HECEJCDAIOJ>();
		try
		{
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			HFDAGKJJHOA hfdagkjjhoa = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE();
			if (hfdagkjjhoa == null)
			{
				return list;
			}
			long num = AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
			List<FJLGCKNOJMJ> list2 = hfdagkjjhoa.JPPCGJEMJBF();
			for (int i = 0; i < list2.Count; i++)
			{
				FJLGCKNOJMJ fjlgcknojmj = list2[i];
				if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB && (PLKMJJIIJNO < 0 || fjlgcknojmj.AMKCLHLIIMN == PLKMJJIIJNO) && DHFLKLPKNJG.IKOPPGGEIAJ(fjlgcknojmj.AMKCLHLIIMN))
				{
					APNIHJMGNIM apnihjmgnim = AKLFPGMDKLA.EHBBFMCILPC.GKNBOCPKMDM(fjlgcknojmj.AMKCLHLIIMN);
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
					AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(fjlgcknojmj.AMKCLHLIIMN);
					bool flag = plfdajjhmko != null && null != assetAnthology && null != assetAnthology.header && assetAnthology.header.availableStories.Contains(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI);
					for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO.Count; j++)
					{
						DMDNKJKEPKO dmdnkjkepko = fjlgcknojmj.OINAAMKLNLO[j];
						if (dmdnkjkepko != null && (MKLBDPIIBNE == null || MKLBDPIIBNE.Contains(dmdnkjkepko.KALBADOPCDN)))
						{
							for (int k = 0; k < dmdnkjkepko.KKEENPEFFBJ.Count; k++)
							{
								ECJCFGAOPHJ ecjcfgaophj = dmdnkjkepko.KKEENPEFFBJ[k];
								if (ecjcfgaophj != null && ecjcfgaophj.LMEALGJPGDA() && ecjcfgaophj.OBLBNLBFBNI >= 0 && ecjcfgaophj.PODGFLMDBEC != BGDLJKJPOOO.none && ecjcfgaophj.HLEOLMIFCGI() && (ecjcfgaophj.MNBBOAPGCMM <= 0 || !AppManager.EHBBFMCILPC.UnsupportedRevision(ecjcfgaophj.MNBBOAPGCMM)))
								{
									bool flag2 = AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(ecjcfgaophj.OBLBNLBFBNI);
									if (flag2 || !ecjcfgaophj.PPBPOPEEPDJ(num))
									{
										Sprite sprite = DHFLKLPKNJG.OLLDCINAIAD(ecjcfgaophj.OBLBNLBFBNI);
										if (!(null == sprite))
										{
											HECEJCDAIOJ hecejcdaioj = new HECEJCDAIOJ();
											hecejcdaioj.AMKCLHLIIMN = fjlgcknojmj.AMKCLHLIIMN;
											hecejcdaioj.KALBADOPCDN = dmdnkjkepko.KALBADOPCDN;
											hecejcdaioj.DENODLCMDAL = ecjcfgaophj;
											hecejcdaioj.BDIHOCKCCBL = ecjcfgaophj.IJEEKLNDJGE;
											hecejcdaioj.OBLBNLBFBNI = ecjcfgaophj.OBLBNLBFBNI;
											hecejcdaioj.OIKGLAAHHJF = flag2;
											hecejcdaioj.HMJELDILAPC = (ecjcfgaophj.BEJGHHLMJNB > num);
											hecejcdaioj.JADMHPJBCOF = ecjcfgaophj.BEJGHHLMJNB;
											hecejcdaioj.JGEDHIMPKCL = ecjcfgaophj.BMJIGANCIDG(num);
											hecejcdaioj.OAOMKNHCHGO = ecjcfgaophj.NIOGHOKEKDI(num);
											if (ecjcfgaophj.PODGFLMDBEC == BGDLJKJPOOO.iapOnly || hecejcdaioj.OAOMKNHCHGO <= 0)
											{
												hecejcdaioj.JGEDHIMPKCL = 0;
											}
											hecejcdaioj.JOBAGHGMDHC = ecjcfgaophj.PODGFLMDBEC;
											hecejcdaioj.LEAFNBOALFN = ecjcfgaophj.ECMIHEAHOLL();
											if (hecejcdaioj.JOBAGHGMDHC == BGDLJKJPOOO.iapOnly || hecejcdaioj.LEAFNBOALFN)
											{
												hecejcdaioj.IONJPGKLGLJ = ChoiceExtendedManager.GetShopLocalizedPrice(KDCJJBLGCBH.EHBBFMCILPC.KHECDLLIOAF(ecjcfgaophj.CBLPKDDMLBL));
												if (hecejcdaioj.IONJPGKLGLJ == null)
												{
													hecejcdaioj.IONJPGKLGLJ = "";
												}
											}
											hecejcdaioj.IPICGONHLAM = Mathf.Clamp(ecjcfgaophj.CBLPKDDMLBL, 0, KBOJLHAJPCP.KACBFPFFJEO.Length - 1);
											hecejcdaioj.FEJEPPDIDJE = ecjcfgaophj.PBGKGCHMHOP;
											hecejcdaioj.EBDFCICNAOE = ecjcfgaophj.CGKKPPEIFJH;
											hecejcdaioj.MAFBMDFOBGH = (apnihjmgnim != null && apnihjmgnim.MEAPPCCOEFL && apnihjmgnim.LMGFNJAFOLC(hecejcdaioj.FEJEPPDIDJE, hecejcdaioj.EBDFCICNAOE));
											if (!hecejcdaioj.MAFBMDFOBGH && DHFLKLPKNJG.ANMHEFCLDPH(assetAnthology, hecejcdaioj.FEJEPPDIDJE, hecejcdaioj.EBDFCICNAOE))
											{
												hecejcdaioj.MAFBMDFOBGH = true;
											}
											if (flag)
											{
												hecejcdaioj.MAFBMDFOBGH = SceneStoryManager.LoungeMappingUnlockReached(ecjcfgaophj, plfdajjhmko);
											}
											hecejcdaioj.OLAKHHEICKO = ecjcfgaophj.OLAKHHEICKO;
											hecejcdaioj.MDKIKKJNJKK = ecjcfgaophj.MDKIKKJNJKK;
											hecejcdaioj.JNCJNLEAFLG = ecjcfgaophj.JNCJNLEAFLG;
											hecejcdaioj.PMFNECKIMBG = ecjcfgaophj.PMFNECKIMBG;
											hecejcdaioj.JHPOFDLKALO = sprite;
											list.Add(hecejcdaioj);
										}
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			list.Sort(new Comparison<HECEJCDAIOJ>(DHFLKLPKNJG.ENMFKCBFBEE));
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return list;
	}

	// Token: 0x0600A1F0 RID: 41456 RVA: 0x004610BC File Offset: 0x0045F2BC
	private static string MLGGAOHIJGA(string BHJJLJJACFE, string AFCOCAFFGLP)
	{
		if (AFCOCAFFGLP == null || AFCOCAFFGLP.Length == 0)
		{
			return BHJJLJJACFE;
		}
		if (BHJJLJJACFE == null || BHJJLJJACFE.Length == 0)
		{
			return AFCOCAFFGLP;
		}
		return BHJJLJJACFE + " " + AFCOCAFFGLP;
	}

	// Token: 0x0600A1F1 RID: 41457 RVA: 0x004610E4 File Offset: 0x0045F2E4
	private static string MOJDPGCCAKH(int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		return DHFLKLPKNJG.FJDMMBKEMLC(DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumse"), NLLCKPCKGOH, OLKMHHNMDLP);
	}

	// Token: 0x0600A1F2 RID: 41458 RVA: 0x004610F8 File Offset: 0x0045F2F8
	public static bool PDCGKIJCCJI()
	{
		try
		{
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return false;
			}
			HFDAGKJJHOA hfdagkjjhoa = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE();
			if (hfdagkjjhoa == null)
			{
				return false;
			}
			List<FJLGCKNOJMJ> list = hfdagkjjhoa.JPPCGJEMJBF();
			for (int i = 0; i < list.Count; i++)
			{
				FJLGCKNOJMJ fjlgcknojmj = list[i];
				if (fjlgcknojmj != null && DHFLKLPKNJG.IKOPPGGEIAJ(fjlgcknojmj.AMKCLHLIIMN))
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600A1F3 RID: 41459 RVA: 0x00461194 File Offset: 0x0045F394
	public static int CGNDDBHPPLC(string BHJJLJJACFE)
	{
		if (BHJJLJJACFE == null)
		{
			return 28;
		}
		int num = 0;
		int num2 = 0;
		bool flag = false;
		foreach (char c in BHJJLJJACFE)
		{
			if ('\n' == c)
			{
				num++;
			}
			else if ('<' == c)
			{
				flag = true;
			}
			else if ('>' == c)
			{
				flag = false;
			}
			else if (!flag)
			{
				num2++;
			}
		}
		int num3 = Mathf.Clamp(num + num2 / 30 - 25, 0, 5);
		return 28 - num3;
	}

	// Token: 0x0600A1F4 RID: 41460 RVA: 0x00461208 File Offset: 0x0045F408
	private static string ENJLBBPPFEG(HECEJCDAIOJ FOEEIJFHMGG, int GDMJJBJFGEA, string IPGCPNLDHAK, string BILIIGMDFAI)
	{
		if (FOEEIJFHMGG.OLAKHHEICKO != GDMJJBJFGEA)
		{
			return BILIIGMDFAI;
		}
		string text = DHFLKLPKNJG.MOJDPGCCAKH(FOEEIJFHMGG.MDKIKKJNJKK, FOEEIJFHMGG.JNCJNLEAFLG);
		if (text == null || text.Length == 0)
		{
			return DHFLKLPKNJG.EENGPKMHFKL(FOEEIJFHMGG, IPGCPNLDHAK);
		}
		return DHFLKLPKNJG.EENGPKMHFKL(FOEEIJFHMGG, IPGCPNLDHAK + " " + text);
	}

	// Token: 0x0600A1F5 RID: 41461 RVA: 0x00461257 File Offset: 0x0045F457
	public static List<int> GNEJAPMDJPI(int PLKMJJIIJNO)
	{
		return DHFLKLPKNJG.GNEJAPMDJPI(PLKMJJIIJNO, null);
	}

	// Token: 0x0600A1F6 RID: 41462 RVA: 0x00461260 File Offset: 0x0045F460
	public static string IFNFJKFJBGB(string DMNKDCGMKKP)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(DMNKDCGMKKP);
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			return null;
		}
		return text;
	}

	// Token: 0x0600A1F7 RID: 41463 RVA: 0x00461294 File Offset: 0x0045F494
	public static string MDIPDBDPIEJ(string FBKAPCPPNKA)
	{
		string text = GKJPOGNFKNK.HPAHOEOKEBB(FBKAPCPPNKA, "loungetitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			text = FBKAPCPPNKA;
		}
		return text;
	}

	// Token: 0x0600A1F8 RID: 41464 RVA: 0x004612D2 File Offset: 0x0045F4D2
	public static string HGPOMLKJGNE(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return "";
		}
		return DHFLKLPKNJG.MDIPDBDPIEJ(FOEEIJFHMGG.BDIHOCKCCBL);
	}

	// Token: 0x0600A1F9 RID: 41465 RVA: 0x004612E8 File Offset: 0x0045F4E8
	public static HECEJCDAIOJ EKMGFCLFAHF(int PLKMJJIIJNO, string OKDNLCOEOIJ, string FBKAPCPPNKA, int LMCEDCHDIIB, bool OKGIGHJDLEN, int GNMFOFCNFEJ, int MKJOOKMAIOM, int GDMJJBJFGEA, int IEOPGFADJEO, int PCBFEMCAEME, bool CNDAMFPGGKD)
	{
		return new HECEJCDAIOJ
		{
			OPFKKIBPPID = true,
			AMKCLHLIIMN = PLKMJJIIJNO,
			KALBADOPCDN = OKDNLCOEOIJ,
			BDIHOCKCCBL = FBKAPCPPNKA,
			IPICGONHLAM = Mathf.Clamp(LMCEDCHDIIB, 0, KBOJLHAJPCP.KACBFPFFJEO.Length - 1),
			MAFBMDFOBGH = OKGIGHJDLEN,
			FEJEPPDIDJE = GNMFOFCNFEJ,
			EBDFCICNAOE = MKJOOKMAIOM,
			OLAKHHEICKO = GDMJJBJFGEA,
			MDKIKKJNJKK = IEOPGFADJEO,
			JNCJNLEAFLG = PCBFEMCAEME,
			PMFNECKIMBG = CNDAMFPGGKD
		};
	}

	// Token: 0x0600A1FA RID: 41466 RVA: 0x00461364 File Offset: 0x0045F564
	private static string PHFEHFNPADJ(HECEJCDAIOJ FOEEIJFHMGG)
	{
		string aeenfdhaggg = "";
		string ipgcpnldhak = DHFLKLPKNJG.IFNFJKFJBGB("yes");
		string text = DHFLKLPKNJG.IFNFJKFJBGB("no");
		int num = Mathf.Clamp(FOEEIJFHMGG.IPICGONHLAM, 0, KBOJLHAJPCP.KACBFPFFJEO.Length - 1);
		string text2 = DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumrarity" + num.ToString());
		if (text2 != null)
		{
			aeenfdhaggg = DHFLKLPKNJG.OCFJFALEDBB(aeenfdhaggg, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumrarity"), KBOJLHAJPCP.FIOEKALDNPB[num] + text2);
		}
		if (FOEEIJFHMGG.MAFBMDFOBGH)
		{
			aeenfdhaggg = DHFLKLPKNJG.OCFJFALEDBB(aeenfdhaggg, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumavailable"), DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumimmediate"));
		}
		else
		{
			aeenfdhaggg = DHFLKLPKNJG.OCFJFALEDBB(aeenfdhaggg, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumavailable"), DHFLKLPKNJG.MOJDPGCCAKH(FOEEIJFHMGG.FEJEPPDIDJE, FOEEIJFHMGG.EBDFCICNAOE));
		}
		aeenfdhaggg = DHFLKLPKNJG.OCFJFALEDBB(aeenfdhaggg, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumreaction"), DHFLKLPKNJG.ENJLBBPPFEG(FOEEIJFHMGG, 1, ipgcpnldhak, text));
		aeenfdhaggg = DHFLKLPKNJG.OCFJFALEDBB(aeenfdhaggg, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumbonus"), DHFLKLPKNJG.ENJLBBPPFEG(FOEEIJFHMGG, 0, ipgcpnldhak, text));
		return DHFLKLPKNJG.OCFJFALEDBB(aeenfdhaggg, DHFLKLPKNJG.IFNFJKFJBGB("skinshopinfosumrelation"), text);
	}

	// Token: 0x0600A1FB RID: 41467 RVA: 0x0046146C File Offset: 0x0045F66C
	private static bool ANMHEFCLDPH(AssetAnthology AAOGJEGPCAE, int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		bool result;
		try
		{
			if (null == AAOGJEGPCAE || null == AAOGJEGPCAE.header || AAOGJEGPCAE.header.availableStories == null || AAOGJEGPCAE.header.availableStories.Count == 0)
			{
				result = false;
			}
			else
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AAOGJEGPCAE.header.index);
				int index = 0;
				if (eioplefllim != null)
				{
					index = Mathf.Clamp(eioplefllim.EGHHCFFLPCP(-1), 0, AAOGJEGPCAE.header.availableStories.Count - 1);
				}
				int num = AAOGJEGPCAE.header.availableStories[index];
				if (num > NLLCKPCKGOH)
				{
					result = true;
				}
				else
				{
					result = (num == NLLCKPCKGOH && OLKMHHNMDLP <= 0);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x04002C3F RID: 11327
	private const string CNJFMDEMPFM = "<space=0.31em>";

	// Token: 0x04002C40 RID: 11328
	private const string EGJKLMCICLH = "<space=0.24em>";

	// Token: 0x04002C41 RID: 11329
	private const string KLGGEKKNDNG = "<space=0.33em>";

	// Token: 0x04002C42 RID: 11330
	private const string MJICNBJGGEJ = "<space=0.125em>";

	// Token: 0x04002C43 RID: 11331
	private const int LPIEELOIPLL = 28;

	// Token: 0x04002C44 RID: 11332
	private const int CDJOCOEMFDJ = 25;

	// Token: 0x04002C45 RID: 11333
	private const int ABHOGPFOFHP = 30;

	// Token: 0x04002C46 RID: 11334
	private const int ADNMPLGCGMO = 5;
}
