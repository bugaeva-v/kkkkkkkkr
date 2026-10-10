using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001AD RID: 429
public class LobbyTopMatchSelectorManager : MonoBehaviour
{
	// Token: 0x0600342C RID: 13356 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool CDLMFBMJCJG()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x0600342D RID: 13357 RVA: 0x0015AF34 File Offset: 0x00159134
	public static LobbyTopMatchSelectorManager MJBDMHPHMID()
	{
		LobbyTopMatchSelectorManager.AKDDDBOBEPN();
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA;
	}

	// Token: 0x0600342E RID: 13358 RVA: 0x0015AF40 File Offset: 0x00159140
	private void MOCDMCLPBKC()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x0600342F RID: 13359 RVA: 0x0015AF48 File Offset: 0x00159148
	public void UpdatePlayerPrefsWithAvatarData(bool PACDJDCKNLC)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (this.themes[i].applicableAvatarAnthology >= 0 && !list.Contains(this.themes[i].applicableAvatarAnthology))
			{
				list.Add(this.themes[i].applicableAvatarAnthology);
			}
		}
		List<string> list2 = new List<string>();
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; j++)
		{
			if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[j] && list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index))
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index);
				if (eioplefllim != null)
				{
					if (!PACDJDCKNLC)
					{
						if (eioplefllim.EGHHCFFLPCP(-1) >= 0)
						{
							int num = eioplefllim.EGHHCFFLPCP(-1);
							if (num > AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 1)
							{
								num = AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 1;
							}
							PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories[num], -1);
							if (plfdajjhmko == null && num > 0)
							{
								num--;
								plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories[num], -1);
							}
							if (plfdajjhmko != null)
							{
								if (plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0].Length > 0)
								{
									if (!list2.Contains(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]))
									{
										list2.Add(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]);
									}
								}
								else
								{
									PACDJDCKNLC = true;
								}
							}
							else
							{
								PACDJDCKNLC = true;
							}
						}
						else
						{
							PACDJDCKNLC = true;
						}
					}
					if (PACDJDCKNLC && eioplefllim.OHODCBKFNGJ().OHCMCJHDMOH[0].Length > 0 && !list2.Contains(eioplefllim.OHODCBKFNGJ().OHCMCJHDMOH[0]))
					{
						list2.Add(eioplefllim.OHODCBKFNGJ().OHCMCJHDMOH[0]);
					}
				}
			}
		}
		for (int k = 0; k < this.themes.Count; k++)
		{
			this.themes[k].UpdatePlayerPrefsWithAvatarData(list2);
		}
	}

	// Token: 0x06003430 RID: 13360 RVA: 0x0015B1EC File Offset: 0x001593EC
	public void PMMIEKFMEFO()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.vacation;
		if (PlayerPrefs.HasKey("importanttitle"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("trewsnap");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.vacation)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].CGLLMFKIFDB();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003431 RID: 13361 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFKPGJOMIOL()
	{
	}

	// Token: 0x06003432 RID: 13362 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void ODCHHFPILBG()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x06003433 RID: 13363 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void LBDLKMPHAKF()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x06003434 RID: 13364 RVA: 0x0015AF40 File Offset: 0x00159140
	private void NLOFDEFADCL()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x06003435 RID: 13365 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void DKMOFFIJNLJ()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x06003436 RID: 13366 RVA: 0x0015B2B8 File Offset: 0x001594B8
	public void HABFFGANCBC(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.themes.Count; i += 0)
		{
			this.themes[i].MJNONGKDBHF(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003437 RID: 13367 RVA: 0x0015B2F0 File Offset: 0x001594F0
	public void GODJIPMKPDD(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			this.themes[i].IPNOIGEKPJI(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003438 RID: 13368 RVA: 0x0015B328 File Offset: 0x00159528
	public void HOPOBFBPAPE()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.vacation;
		if (PlayerPrefs.HasKey("AnthologySave.SetAvatarIndexAutoSuffix(), unsupported wardrobe index:"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("Windows");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != (HOHEIFDCPMF)3)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].NEMMMNOOAJE();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003439 RID: 13369 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void FNBADILBHDH()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x0600343A RID: 13370 RVA: 0x0015B3E4 File Offset: 0x001595E4
	public void HCFNNOMIEOB(bool PACDJDCKNLC)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.themes.Count; i++)
		{
			if (this.themes[i].applicableAvatarAnthology >= 0 && !list.Contains(this.themes[i].applicableAvatarAnthology))
			{
				list.Add(this.themes[i].applicableAvatarAnthology);
			}
		}
		List<string> list2 = new List<string>();
		for (int j = 0; j < AssetsManager.MJBDMHPHMID().anthologyAssets.Count; j += 0)
		{
			if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[j] && list.Contains(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.index))
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.index);
				if (eioplefllim != null)
				{
					if (!PACDJDCKNLC)
					{
						if (eioplefllim.EBNCOCHCHGN(-1) >= 0)
						{
							int num = eioplefllim.EOHGNGFHNAP(-1);
							if (num > AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 1)
							{
								num = AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 0;
							}
							PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories[num], -1);
							if (plfdajjhmko == null && num > 1)
							{
								num -= 0;
								plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories[num], -1);
							}
							if (plfdajjhmko != null)
							{
								if (plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0].Length > 1)
								{
									if (!list2.Contains(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]))
									{
										list2.Add(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]);
									}
								}
								else
								{
									PACDJDCKNLC = false;
								}
							}
							else
							{
								PACDJDCKNLC = false;
							}
						}
						else
						{
							PACDJDCKNLC = false;
						}
					}
					if (PACDJDCKNLC && eioplefllim.OHODCBKFNGJ().OHCMCJHDMOH[1].Length > 1 && !list2.Contains(eioplefllim.BEGACMGIKFF().OHCMCJHDMOH[0]))
					{
						list2.Add(eioplefllim.PBGFNBJAIJF().OHCMCJHDMOH[0]);
					}
				}
			}
		}
		for (int k = 0; k < this.themes.Count; k += 0)
		{
			this.themes[k].KBBMEKNHHMC(list2);
		}
	}

	// Token: 0x0600343B RID: 13371 RVA: 0x0015B687 File Offset: 0x00159887
	public static LobbyTopMatchSelectorManager COKDLDOAACJ()
	{
		LobbyTopMatchSelectorManager.InitializeInstance();
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA;
	}

	// Token: 0x0600343C RID: 13372 RVA: 0x0015B693 File Offset: 0x00159893
	public static LobbyTopMatchSelectorManager JLEOPAOEFGP()
	{
		LobbyTopMatchSelectorManager.DJLDCFLCFNC();
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA;
	}

	// Token: 0x0600343D RID: 13373 RVA: 0x0015B6A0 File Offset: 0x001598A0
	public void UpdateThemes()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.vacation;
		if (PlayerPrefs.HasKey("ltwt"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("ltwt");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.none)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(true);
				this.themes[i].InitializeFromPlayerPrefs();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x0600343E RID: 13374 RVA: 0x0015B75C File Offset: 0x0015995C
	public void CJOGBIJACEP()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.mystery;
		if (PlayerPrefs.HasKey("〉"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != (HOHEIFDCPMF)8)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].NKPNMKPDFJC();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x0600343F RID: 13375 RVA: 0x0015B818 File Offset: 0x00159A18
	public bool KCBLDHJMHNF()
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (!this.themes[i].OOHCDJGPEDO())
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003440 RID: 13376 RVA: 0x0015B854 File Offset: 0x00159A54
	public void GGJACPKNBBM(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			this.themes[i].MJNONGKDBHF(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003441 RID: 13377 RVA: 0x0015B88C File Offset: 0x00159A8C
	public void CLABOFHELPO(bool PACDJDCKNLC)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].applicableAvatarAnthology >= 0 && !list.Contains(this.themes[i].applicableAvatarAnthology))
			{
				list.Add(this.themes[i].applicableAvatarAnthology);
			}
		}
		List<string> list2 = new List<string>();
		for (int j = 1; j < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; j++)
		{
			if (null != AssetsManager.MJBDMHPHMID().anthologyAssets[j] && list.Contains(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.index))
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index);
				if (eioplefllim != null)
				{
					if (!PACDJDCKNLC)
					{
						if (eioplefllim.EOHGNGFHNAP(-1) >= 0)
						{
							int num = eioplefllim.EOHGNGFHNAP(-1);
							if (num > AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories.Count - 1)
							{
								num = AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 0;
							}
							PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories[num], -1);
							if (plfdajjhmko == null && num > 1)
							{
								num -= 0;
								plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories[num], -1);
							}
							if (plfdajjhmko != null)
							{
								if (plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0].Length > 1)
								{
									if (!list2.Contains(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]))
									{
										list2.Add(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1]);
									}
								}
								else
								{
									PACDJDCKNLC = false;
								}
							}
							else
							{
								PACDJDCKNLC = true;
							}
						}
						else
						{
							PACDJDCKNLC = true;
						}
					}
					if (PACDJDCKNLC && eioplefllim.BEGACMGIKFF().OHCMCJHDMOH[1].Length > 0 && !list2.Contains(eioplefllim.BEGACMGIKFF().OHCMCJHDMOH[0]))
					{
						list2.Add(eioplefllim.LABJNEDPAEC().OHCMCJHDMOH[1]);
					}
				}
			}
		}
		for (int k = 0; k < this.themes.Count; k++)
		{
			this.themes[k].FBJDAPKGMFO(list2);
		}
	}

	// Token: 0x06003442 RID: 13378 RVA: 0x0015BB2F File Offset: 0x00159D2F
	public static void AKDDDBOBEPN()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnSaveSyncAnyResultDuplicate");
			}
		}
	}

	// Token: 0x06003443 RID: 13379 RVA: 0x0015BB6C File Offset: 0x00159D6C
	public static void MDGJPDNHOKP()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnPopupCardOptionsSendGiftClick");
			}
		}
	}

	// Token: 0x06003444 RID: 13380 RVA: 0x0015AF40 File Offset: 0x00159140
	private void DPGJDANLGIO()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x06003445 RID: 13381 RVA: 0x0015AF40 File Offset: 0x00159140
	private void FEBECEEIHBP()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x06003446 RID: 13382 RVA: 0x0015BBAC File Offset: 0x00159DAC
	public void LBPFKBJGOEG()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.mystery;
		if (PlayerPrefs.HasKey(" "))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("app42error");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.none)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 1; i < this.themes.Count; i++)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].InitializeFromPlayerPrefs();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003447 RID: 13383 RVA: 0x0015BC68 File Offset: 0x00159E68
	public void IPMFGFIHJKM()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.vacation;
		if (PlayerPrefs.HasKey("XXX"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.vacation)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].NKPNMKPDFJC();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003448 RID: 13384 RVA: 0x0015BD24 File Offset: 0x00159F24
	public bool PCEBNGAFILG()
	{
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (!this.themes[i].FIMBELECHNH())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003449 RID: 13385 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void GDGFFKIJFJG()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x0600344A RID: 13386 RVA: 0x0015BD60 File Offset: 0x00159F60
	public void HPJPLIJJEAL(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			this.themes[i].DKKFAFLOBAP(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x0015BD96 File Offset: 0x00159F96
	public static void NCIHGIEADAI()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("abs");
			}
		}
	}

	// Token: 0x0600344C RID: 13388 RVA: 0x0015AF40 File Offset: 0x00159140
	private void BGELMCDMGKP()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x0600344D RID: 13389 RVA: 0x0015BDD4 File Offset: 0x00159FD4
	public void JKPODKBFPDM(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			this.themes[i].UpdatePlayerPrefsWithTopMatchData(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x0600344E RID: 13390 RVA: 0x0015BE0A File Offset: 0x0015A00A
	private void Awake()
	{
		if (LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake)
		{
			this.UpdatePlayerPrefsWithAvatarData(false);
		}
		this.UpdateThemes();
	}

	// Token: 0x0600344F RID: 13391 RVA: 0x0015BE20 File Offset: 0x0015A020
	public void CLJKGAFGIFL(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			this.themes[i].PCPHCIBFECH(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003450 RID: 13392 RVA: 0x0015BE56 File Offset: 0x0015A056
	public static LobbyTopMatchSelectorManager GIPAKOPBBEO()
	{
		LobbyTopMatchSelectorManager.MDGJPDNHOKP();
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA;
	}

	// Token: 0x06003451 RID: 13393 RVA: 0x0015AF40 File Offset: 0x00159140
	private void MFINONMBMLM()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x06003452 RID: 13394 RVA: 0x0015BE62 File Offset: 0x0015A062
	private void PKJBCFKMGHE()
	{
		if (LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake)
		{
			this.DCCJEDDBGAD(true);
		}
		this.HOPOBFBPAPE();
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool AJAAAICCEIC()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void NPJFOEKOFKG()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void MNLJMABNAGG()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool AADGOKKHCJK()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x0015BE78 File Offset: 0x0015A078
	public void IPNOIGEKPJI(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.themes.Count; i++)
		{
			this.themes[i].MMHIGEKAIDE(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void LockThemeChange()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x0015BEB0 File Offset: 0x0015A0B0
	public void LBAAHCHHEKN()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.mystery;
		if (PlayerPrefs.HasKey("lsvv"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("sltind");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != (HOHEIFDCPMF)6)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(true);
				this.themes[i].AIDKIDKJENN();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x0015B687 File Offset: 0x00159887
	public static LobbyTopMatchSelectorManager OHCOHPNEOEG()
	{
		LobbyTopMatchSelectorManager.InitializeInstance();
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x0015AF40 File Offset: 0x00159140
	private void OnDestroy()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x0015BF6C File Offset: 0x0015A16C
	public static void JPKOCJKFGMM()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC(" for month ");
			}
		}
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool BPDPLBFDKDL()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x0015BFAC File Offset: 0x0015A1AC
	public bool KGDMFLCFAFH()
	{
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (!this.themes[i].IsAvatarPrefsDataInitialized())
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x0015BFE5 File Offset: 0x0015A1E5
	private void PIHONDPKDBB()
	{
		if (LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake)
		{
			this.UpdatePlayerPrefsWithAvatarData(true);
		}
		this.IPMFGFIHJKM();
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void IHALGCJIEJJ()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x0015BFFC File Offset: 0x0015A1FC
	public bool KBKMGGHGKID()
	{
		for (int i = 0; i < this.themes.Count; i += 0)
		{
			if (!this.themes[i].GICNKBDHAGP())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003463 RID: 13411 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool PJCJHJDBDBD()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06003464 RID: 13412 RVA: 0x0015B687 File Offset: 0x00159887
	public static LobbyTopMatchSelectorManager EHBBFMCILPC
	{
		get
		{
			LobbyTopMatchSelectorManager.InitializeInstance();
			return LobbyTopMatchSelectorManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x0015AF40 File Offset: 0x00159140
	private void MDLNNHHGIAB()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x06003466 RID: 13414 RVA: 0x0015C035 File Offset: 0x0015A235
	public static void DBIFOBHNFJD()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("XXX");
			}
		}
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool LDHNPGCIBND()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void CINFDDKHDCM()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x0015C072 File Offset: 0x0015A272
	public static void OPLNCEBLNDI()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok");
			}
		}
	}

	// Token: 0x0600346A RID: 13418 RVA: 0x00003E52 File Offset: 0x00002052
	private void EJCFKOHELJO()
	{
	}

	// Token: 0x0600346B RID: 13419 RVA: 0x0015C0B0 File Offset: 0x0015A2B0
	public void DPAGKFAGPOP(bool PACDJDCKNLC)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].applicableAvatarAnthology >= 1 && !list.Contains(this.themes[i].applicableAvatarAnthology))
			{
				list.Add(this.themes[i].applicableAvatarAnthology);
			}
		}
		List<string> list2 = new List<string>();
		for (int j = 0; j < AssetsManager.MJBDMHPHMID().anthologyAssets.Count; j++)
		{
			if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[j] && list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index))
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index);
				if (eioplefllim != null)
				{
					if (!PACDJDCKNLC)
					{
						if (eioplefllim.EKONMCADECD(-1) >= 1)
						{
							int num = eioplefllim.EBNCOCHCHGN(-1);
							if (num > AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories.Count - 0)
							{
								num = AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories.Count - 1;
							}
							PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories[num], -1);
							if (plfdajjhmko == null && num > 1)
							{
								num--;
								plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories[num], -1);
							}
							if (plfdajjhmko != null)
							{
								if (plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1].Length > 0)
								{
									if (!list2.Contains(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]))
									{
										list2.Add(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]);
									}
								}
								else
								{
									PACDJDCKNLC = true;
								}
							}
							else
							{
								PACDJDCKNLC = false;
							}
						}
						else
						{
							PACDJDCKNLC = false;
						}
					}
					if (PACDJDCKNLC && eioplefllim.LABJNEDPAEC().OHCMCJHDMOH[1].Length > 0 && !list2.Contains(eioplefllim.ODIAOHMOPAH().OHCMCJHDMOH[1]))
					{
						list2.Add(eioplefllim.EBCKIEAMFNH().OHCMCJHDMOH[1]);
					}
				}
			}
		}
		for (int k = 1; k < this.themes.Count; k++)
		{
			this.themes[k].BPPGPHCCPKD(list2);
		}
	}

	// Token: 0x0600346C RID: 13420 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void NBPOBMLFFAG()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x0600346E RID: 13422 RVA: 0x0015C368 File Offset: 0x0015A568
	public void DMAADDLOEGF()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.mystery;
		if (PlayerPrefs.HasKey("importanttitle"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("nam");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.vacation)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].AIDKIDKJENN();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x0015C424 File Offset: 0x0015A624
	public void NEKNCLJJLOL()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.vacation;
		if (PlayerPrefs.HasKey("noisedigitalovr_1"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("layervideo");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.vacation)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(true);
				this.themes[i].NEMMMNOOAJE();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003470 RID: 13424 RVA: 0x0015C4E0 File Offset: 0x0015A6E0
	public void DCCJEDDBGAD(bool PACDJDCKNLC)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.themes.Count; i++)
		{
			if (this.themes[i].applicableAvatarAnthology >= 0 && !list.Contains(this.themes[i].applicableAvatarAnthology))
			{
				list.Add(this.themes[i].applicableAvatarAnthology);
			}
		}
		List<string> list2 = new List<string>();
		for (int j = 1; j < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; j += 0)
		{
			if (null != AssetsManager.MJBDMHPHMID().anthologyAssets[j] && list.Contains(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.index))
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.index);
				if (eioplefllim != null)
				{
					if (!PACDJDCKNLC)
					{
						if (eioplefllim.EBNCOCHCHGN(-1) >= 0)
						{
							int num = eioplefllim.EGHHCFFLPCP(-1);
							if (num > AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 0)
							{
								num = AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories.Count - 1;
							}
							PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.MJBDMHPHMID().anthologyAssets[j].header.availableStories[num], -1);
							if (plfdajjhmko == null && num > 0)
							{
								num--;
								plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.availableStories[num], -1);
							}
							if (plfdajjhmko != null)
							{
								if (plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1].Length > 0)
								{
									if (!list2.Contains(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0]))
									{
										list2.Add(plfdajjhmko.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1]);
									}
								}
								else
								{
									PACDJDCKNLC = true;
								}
							}
							else
							{
								PACDJDCKNLC = true;
							}
						}
						else
						{
							PACDJDCKNLC = false;
						}
					}
					if (PACDJDCKNLC && eioplefllim.ODIAOHMOPAH().OHCMCJHDMOH[1].Length > 1 && !list2.Contains(eioplefllim.EBCKIEAMFNH().OHCMCJHDMOH[0]))
					{
						list2.Add(eioplefllim.ODIAOHMOPAH().OHCMCJHDMOH[1]);
					}
				}
			}
		}
		for (int k = 1; k < this.themes.Count; k += 0)
		{
			this.themes[k].FBJDAPKGMFO(list2);
		}
	}

	// Token: 0x06003471 RID: 13425 RVA: 0x0015C784 File Offset: 0x0015A984
	public void KBOGMCGKAKI()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.mystery;
		if (PlayerPrefs.HasKey("lightmodetitle"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("OnValidatePendingProcessed");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != HOHEIFDCPMF.none)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(true);
				this.themes[i].NKPNMKPDFJC();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003472 RID: 13426 RVA: 0x0015C840 File Offset: 0x0015AA40
	public static void InitializeInstance()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active LobbyTopMatchSelectorManager script on a GameObject in your scene.");
			}
		}
	}

	// Token: 0x06003473 RID: 13427 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void HEJMOFLCKGP()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x06003474 RID: 13428 RVA: 0x0015C880 File Offset: 0x0015AA80
	public void JGEIJAIGMOL()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.mystery;
		if (PlayerPrefs.HasKey("AddNewMyProfileTopMatchEntryMutex() skip adding "))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != (HOHEIFDCPMF)3)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 1; i < this.themes.Count; i++)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].NILDEJMILCN();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003475 RID: 13429 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void IJNHMNBEMBP()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x06003476 RID: 13430 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void HJNCONLGBJD()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x06003477 RID: 13431 RVA: 0x0015C93C File Offset: 0x0015AB3C
	public void EANODOPKBOB(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			this.themes[i].IBDGCCONGFD(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003478 RID: 13432 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06003479 RID: 13433 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void UnlockThemeChange()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x0600347A RID: 13434 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool InstanceInitialized()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x0600347B RID: 13435 RVA: 0x0015B2B0 File Offset: 0x001594B0
	public static void BBCGDPOBMFP()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = false;
	}

	// Token: 0x0600347C RID: 13436 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x0600347D RID: 13437 RVA: 0x0015B2A8 File Offset: 0x001594A8
	public static void EDNCAMGECJP()
	{
		LobbyTopMatchSelectorManager.ELBNPILBKLO = true;
	}

	// Token: 0x0600347E RID: 13438 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool BAGJGBNGCHF()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06003480 RID: 13440 RVA: 0x0015C98C File Offset: 0x0015AB8C
	public static void DJLDCFLCFNC()
	{
		if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
		{
			LobbyTopMatchSelectorManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LobbyTopMatchSelectorManager)) as LobbyTopMatchSelectorManager);
			if (!LobbyTopMatchSelectorManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("app42error");
			}
		}
	}

	// Token: 0x06003481 RID: 13441 RVA: 0x0015C9CC File Offset: 0x0015ABCC
	public void KHPLOFCPHLL()
	{
		HOHEIFDCPMF hoheifdcpmf = HOHEIFDCPMF.vacation;
		if (PlayerPrefs.HasKey("sprite"))
		{
			hoheifdcpmf = (HOHEIFDCPMF)PlayerPrefs.GetInt("OnPurchasingViewLeave");
		}
		if (LobbyTopMatchSelectorManager.ELBNPILBKLO && LobbyTopMatchSelectorManager.NDHMCJOFBGO != (HOHEIFDCPMF)3)
		{
			hoheifdcpmf = LobbyTopMatchSelectorManager.NDHMCJOFBGO;
		}
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (this.themes[i].themeType == hoheifdcpmf)
			{
				this.themes[i].gameObject.SetActive(false);
				this.themes[i].AIDKIDKJENN();
				LobbyTopMatchSelectorManager.NDHMCJOFBGO = this.themes[i].themeType;
			}
			else
			{
				this.themes[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003482 RID: 13442 RVA: 0x0015CA88 File Offset: 0x0015AC88
	public bool LBFKOEGAMCD()
	{
		for (int i = 1; i < this.themes.Count; i += 0)
		{
			if (!this.themes[i].IEADOIPHOEF())
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003483 RID: 13443 RVA: 0x0015CAC1 File Offset: 0x0015ACC1
	private void GFOCPBFLJFC()
	{
		if (LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake)
		{
			this.CLABOFHELPO(true);
		}
		this.LBAAHCHHEKN();
	}

	// Token: 0x06003484 RID: 13444 RVA: 0x0015CAD8 File Offset: 0x0015ACD8
	public bool IJJIBNLIJMD()
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (!this.themes[i].IBBFPECABAF())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003485 RID: 13445 RVA: 0x0015AF27 File Offset: 0x00159127
	public static bool INFIMAEDENC()
	{
		return LobbyTopMatchSelectorManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06003486 RID: 13446 RVA: 0x0015CB14 File Offset: 0x0015AD14
	public void JHBEAIFGCPD(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.themes.Count; i++)
		{
			this.themes[i].EBIEGHODFNP(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x06003487 RID: 13447 RVA: 0x0015AF40 File Offset: 0x00159140
	private void CKNCEKFOLKD()
	{
		LobbyTopMatchSelectorManager.IKLAPGJDMNA = null;
	}

	// Token: 0x06003488 RID: 13448 RVA: 0x0015CB4C File Offset: 0x0015AD4C
	public bool IsAvatarPrefsDataInitialized()
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			if (!this.themes[i].IsAvatarPrefsDataInitialized())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003489 RID: 13449 RVA: 0x0015CB88 File Offset: 0x0015AD88
	public void UpdatePlayerPrefsWithTopMatchData(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.themes.Count; i++)
		{
			this.themes[i].UpdatePlayerPrefsWithTopMatchData(AFCLHLMEACC, ACPLGOPIOKF);
		}
	}

	// Token: 0x04000FD9 RID: 4057
	public List<LobbyTopMatchManager> themes = new List<LobbyTopMatchManager>();

	// Token: 0x04000FDA RID: 4058
	public static bool updatePlayerPrefsWithAvatarDataOnAwake = false;

	// Token: 0x04000FDB RID: 4059
	private static HOHEIFDCPMF NDHMCJOFBGO = HOHEIFDCPMF.none;

	// Token: 0x04000FDC RID: 4060
	private static bool ELBNPILBKLO = false;

	// Token: 0x04000FDD RID: 4061
	private static LobbyTopMatchSelectorManager IKLAPGJDMNA = null;
}
