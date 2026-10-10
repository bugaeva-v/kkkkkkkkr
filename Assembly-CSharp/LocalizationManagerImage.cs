using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000002 RID: 2
public class LocalizationManagerImage : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private void HGEODIPIBPG()
	{
		this.KIDOILDEFEB();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	private void GMPHANBKGBK()
	{
		this.BINMFOOKFPC();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002060 File Offset: 0x00000260
	private void LKDDONLABEO()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.Localizable(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split((char)-128, StringSplitOptions.None)[0];
				string str = this.DNPKIGDLNKO.sprite.name.Split((char)-47, StringSplitOptions.RemoveEmptyEntries)[0];
				text = LanguageManager.EHBBFMCILPC.LocalizeFileName(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "stat6long" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "anthology" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002178 File Offset: 0x00000378
	private void AKHDIJHLKBJ()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split(',', StringSplitOptions.None)[1];
				string str = this.DNPKIGDLNKO.sprite.name.Split((char)-71, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000228E File Offset: 0x0000048E
	private void OPBNOGLBNDK()
	{
		this.NGCNFNNMPKC();
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002296 File Offset: 0x00000496
	private void ELLPAFIDJNA()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000229E File Offset: 0x0000049E
	private void HHHJOCGGNHE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("OnStoryChoiceClick", new UnityAction(this.LKDDONLABEO));
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000022C3 File Offset: 0x000004C3
	private void CPLMECFGOFF()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000022CC File Offset: 0x000004CC
	private void DFKEKPBHKOD()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split((char)-107, StringSplitOptions.RemoveEmptyEntries)[0];
				string str = this.DNPKIGDLNKO.sprite.name.Split('4', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "pmterror007" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "wshcds" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000023E2 File Offset: 0x000005E2
	private void HDCOHOPHPOF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("errortitle", new UnityAction(this.AKHDIJHLKBJ));
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000022C3 File Offset: 0x000004C3
	private void FEGFEMDEHNE()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002408 File Offset: 0x00000608
	private void NEAKHFJJCPA()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.EECILBHACFL(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split((char)-70, StringSplitOptions.RemoveEmptyEntries)[0];
				string str = this.DNPKIGDLNKO.sprite.name.Split('\u0018', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "OnLobbyStoryManagerDownloadSplashScreenSuccess" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "aind" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000251E File Offset: 0x0000071E
	private void BINMFOOKFPC()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002531 File Offset: 0x00000731
	private void AFCGMNGCPMD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("", new UnityAction(this.LAPBPFAGGLL));
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002556 File Offset: 0x00000756
	private void JFFNFDKBMGP()
	{
		this.NNNKIPGJMMF();
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000255E File Offset: 0x0000075E
	private void EDANCCNNDMN()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("sspaid", new UnityAction(this.LAPBPFAGGLL));
		this.HIMBKAMCCAI();
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002584 File Offset: 0x00000784
	private void ONAHKDGPAFE()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split((char)-73, StringSplitOptions.None)[0];
				string str = this.DNPKIGDLNKO.sprite.name.Split(',', StringSplitOptions.RemoveEmptyEntries)[0];
				text = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + " " + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "anthologiestitle" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000022C3 File Offset: 0x000004C3
	private void PBIJFPLLPDH()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000269A File Offset: 0x0000089A
	private void Awake()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000251E File Offset: 0x0000071E
	private void BAMHPOCKBML()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002296 File Offset: 0x00000496
	private void BKJPJKEBHPI()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000026A2 File Offset: 0x000008A2
	private void GPEDLMKNBCJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("Y", new UnityAction(this.JONOCDOJFBI));
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000026C7 File Offset: 0x000008C7
	private void HONIBLHFFAE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("saveslotstitleempty", new UnityAction(this.JONOCDOJFBI));
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002296 File Offset: 0x00000496
	private void KNCAACKFGDC()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000026EC File Offset: 0x000008EC
	private void PBLDIMHDNNJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO("*", new UnityAction(this.HIMBKAMCCAI));
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002711 File Offset: 0x00000911
	private void COMPLLBGJPB()
	{
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("$", new UnityAction(this.HIMBKAMCCAI));
		this.ONAHKDGPAFE();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002734 File Offset: 0x00000934
	private void IKBLOOGEPJB()
	{
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("_Amplitude", new UnityAction(this.LKDDONLABEO));
		this.NEAKHFJJCPA();
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002757 File Offset: 0x00000957
	private void EKIDOPDDHJD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("", new UnityAction(this.DFKEKPBHKOD));
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002296 File Offset: 0x00000496
	private void MFCNOIJEFKE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NAJNKMAHMMI()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000277C File Offset: 0x0000097C
	private void LOACLFMGICF()
	{
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("[LoadingEnv] skipping ", new UnityAction(this.HIMBKAMCCAI));
		this.AKHDIJHLKBJ();
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000251E File Offset: 0x0000071E
	private void ACGGMOACIHN()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000279F File Offset: 0x0000099F
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLanguageChange", new UnityAction(this.JONOCDOJFBI));
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000027C4 File Offset: 0x000009C4
	private void DNHCEOCKPIH()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split('_', StringSplitOptions.RemoveEmptyEntries)[1];
				string str = this.DNPKIGDLNKO.sprite.name.Split((char)-101, StringSplitOptions.RemoveEmptyEntries)[0];
				text = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + " " + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000028DA File Offset: 0x00000ADA
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLanguageChange", new UnityAction(this.JONOCDOJFBI));
		this.JONOCDOJFBI();
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000028FD File Offset: 0x00000AFD
	private void GFOCPBFLJFC()
	{
		this.ACGGMOACIHN();
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000251E File Offset: 0x0000071E
	private void NNNKIPGJMMF()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002905 File Offset: 0x00000B05
	private void FOHMEJDIILN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("OnSystemBackButton", new UnityAction(this.AKHDIJHLKBJ));
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000292A File Offset: 0x00000B2A
	private void OKBGBJDJMNI()
	{
		this.AJNNDKIIFDN();
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002296 File Offset: 0x00000496
	private void CCEAFBHKFMM()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NHEHKDCEKJL()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002296 File Offset: 0x00000496
	private void LEHACICAGMP()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000228E File Offset: 0x0000048E
	private void ODPDLANJNIP()
	{
		this.NGCNFNNMPKC();
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000251E File Offset: 0x0000071E
	private void AJNNDKIIFDN()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002932 File Offset: 0x00000B32
	private void AADPIFCICBL()
	{
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("_not_found", new UnityAction(this.ONAHKDGPAFE));
		this.HIMBKAMCCAI();
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000251E File Offset: 0x0000071E
	private void KIDOILDEFEB()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002958 File Offset: 0x00000B58
	private void LAPBPFAGGLL()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split(';', StringSplitOptions.RemoveEmptyEntries)[1];
				string str = this.DNPKIGDLNKO.sprite.name.Split('8', StringSplitOptions.RemoveEmptyEntries)[0];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "pmtsuccess" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "[Lounge] info text key missing, widget stays hidden: " + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002296 File Offset: 0x00000496
	private void MMMNGHMPHHC()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002058 File Offset: 0x00000258
	private void GOLKPDKALNC()
	{
		this.BINMFOOKFPC();
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002A6E File Offset: 0x00000C6E
	private void KPNLKBPCDAF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().POLEDPIKODD(" ", new UnityAction(this.HIMBKAMCCAI));
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002A94 File Offset: 0x00000C94
	private void HIMBKAMCCAI()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.Localizable(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split('u', StringSplitOptions.None)[1];
				string str = this.DNPKIGDLNKO.sprite.name.Split((char)-40, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "PlayerCharacterManager.UpdateAvatarGraphicsV2() - exception raised:" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "AvatarCollectionsItem.OnAvatarCollectionSelect(): index out of range" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002BAC File Offset: 0x00000DAC
	private void JONOCDOJFBI()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN && null != this.DNPKIGDLNKO)
		{
			this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			if (null != this.DNPKIGDLNKO.sprite && LanguageManager.EHBBFMCILPC.Localizable(this.DNPKIGDLNKO.sprite.name))
			{
				string text = this.DNPKIGDLNKO.sprite.name.Split('@', StringSplitOptions.None)[0];
				string str = this.DNPKIGDLNKO.sprite.name.Split('@', StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.LocalizeFileName(text);
				if (!this.DNPKIGDLNKO.sprite.name.Equals(text + "@" + str))
				{
					Sprite sprite = Resources.Load<Sprite>(text + "@" + str);
					if (sprite)
					{
						this.DNPKIGDLNKO.sprite = sprite;
						if (this.setNativeSize)
						{
							this.DNPKIGDLNKO.SetNativeSize();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002CC2 File Offset: 0x00000EC2
	private void FEIMBKIFIBP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.POLEDPIKODD("fsharv2", new UnityAction(this.DFKEKPBHKOD));
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002CE7 File Offset: 0x00000EE7
	private void MHIHCHGGIDM()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("_ColorNoise", new UnityAction(this.JONOCDOJFBI));
		this.JONOCDOJFBI();
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002296 File Offset: 0x00000496
	private void KEOPNPKGHGP()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002556 File Offset: 0x00000756
	private void EKEOFMOJCGF()
	{
		this.NNNKIPGJMMF();
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002296 File Offset: 0x00000496
	private void JKIPGFCJJJA()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000251E File Offset: 0x0000071E
	private void NGCNFNNMPKC()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002D19 File Offset: 0x00000F19
	private void IJMPLMMFIEP()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("tradewishcardoption0", new UnityAction(this.NEAKHFJJCPA));
		this.NEAKHFJJCPA();
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002D3C File Offset: 0x00000F3C
	private void NGPHDNKNGHE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("YYY", new UnityAction(this.JONOCDOJFBI));
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000228E File Offset: 0x0000048E
	private void ECDLFGCLAGG()
	{
		this.NGCNFNNMPKC();
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000022C3 File Offset: 0x000004C3
	private void BIMDHMGMLPB()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002D61 File Offset: 0x00000F61
	private void ELGAOFFOLPP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("AAA", new UnityAction(this.DNHCEOCKPIH));
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002D86 File Offset: 0x00000F86
	private void KMBJJAFMBMN()
	{
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("", new UnityAction(this.LAPBPFAGGLL));
		this.ONAHKDGPAFE();
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002DA9 File Offset: 0x00000FA9
	private void GFJBNGMOBAC()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("TextRaycastZone", new UnityAction(this.LKDDONLABEO));
		this.LKDDONLABEO();
	}

	// Token: 0x04000001 RID: 1
	public bool setNativeSize;

	// Token: 0x04000002 RID: 2
	private Image DNPKIGDLNKO;

	// Token: 0x04000003 RID: 3
	private int LHABEJBDLGN = -1;
}
