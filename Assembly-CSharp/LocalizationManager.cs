using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001E4 RID: 484
public class LocalizationManager : MonoBehaviour
{
	// Token: 0x06003BAB RID: 15275 RVA: 0x0018B9B4 File Offset: 0x00189BB4
	private void EBLIMOOAPHD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("[Lounge] npc animation pack of another anthology skipped: ", new UnityAction(this.EPGNFLEIHFK));
	}

	// Token: 0x06003BAC RID: 15276 RVA: 0x0018B9D9 File Offset: 0x00189BD9
	private void HOJIMOHCLHE()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.LNIJDKDDOAN));
		this.JFEBKAONPHI();
	}

	// Token: 0x06003BAD RID: 15277 RVA: 0x0018B9FC File Offset: 0x00189BFC
	private void OEDMFHBLKMN()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.FIENAKIHNOM(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.HIPJILDCHJC(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 1)
					{
						this.NPDEIFPJBKA[i].text = this.MEPECBDCOLG(this.stringIndex);
					}
					else if (this.stringId.Length > 1)
					{
						this.NPDEIFPJBKA[i].text = this.IBDKJDMJNBE(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BAE RID: 15278 RVA: 0x00002296 File Offset: 0x00000496
	private void HDLJEMNOAFB()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003BAF RID: 15279 RVA: 0x0018BAFC File Offset: 0x00189CFC
	private void GPMIFPNCOLC()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("assetbundlecollectablecard", new UnityAction(this.OEDMFHBLKMN));
	}

	// Token: 0x06003BB0 RID: 15280 RVA: 0x0018BB24 File Offset: 0x00189D24
	private void AACNGGBHKJI()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.FIENAKIHNOM(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.DNILNCLIHAP(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 1)
					{
						this.NPDEIFPJBKA[i].text = this.NBGKHEJMJHH(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.DEEEPKAJAJF(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BB1 RID: 15281 RVA: 0x0018BC24 File Offset: 0x00189E24
	private string CLFFOEGMCAE(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.BIAEAOMHBMM().GLEFEKBDHNK(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "p", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003BB2 RID: 15282 RVA: 0x0018BC50 File Offset: 0x00189E50
	private void KGHIKMIOHCC()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.DNILNCLIHAP(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.DNILNCLIHAP(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.DNILNCLIHAP(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.DNILNCLIHAP(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x000022C3 File Offset: 0x000004C3
	private void DJMBMOLEPEO()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BB4 RID: 15284 RVA: 0x0018BD50 File Offset: 0x00189F50
	private void OJLALFAEEKP()
	{
		this.KIDOILDEFEB();
	}

	// Token: 0x06003BB5 RID: 15285 RVA: 0x000022C3 File Offset: 0x000004C3
	private void BGGGJJBFMHN()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BB6 RID: 15286 RVA: 0x0018BD58 File Offset: 0x00189F58
	private string LKBIOFEFBGP(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.DLGLFACMHPG().GMLHKCGNMIO(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "ong", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003BB7 RID: 15287 RVA: 0x0018BD83 File Offset: 0x00189F83
	private string FGFBENKGKPO(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.CPCOODCFDDP().PPMPLNFFGGB(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "nastring", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003BB8 RID: 15288 RVA: 0x0018BDAE File Offset: 0x00189FAE
	private void FGILNOIHMCJ()
	{
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("<", new UnityAction(this.EIKHNOJIJJF));
		this.KBOHGKGFENO();
	}

	// Token: 0x06003BB9 RID: 15289 RVA: 0x0018BDD1 File Offset: 0x00189FD1
	private string GMLHKCGNMIO(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.CEGAOMEEFBE().IPEIONBNIPH(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "LoveInterestsLoungesHub - ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003BBA RID: 15290 RVA: 0x0018BDFC File Offset: 0x00189FFC
	private void BAMHPOCKBML()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.KGHIKMIOHCC();
	}

	// Token: 0x06003BBB RID: 15291 RVA: 0x0018BE26 File Offset: 0x0018A026
	private string HPOAGPJFHPM(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KFAABHHGOPO().GJJLOMLOKNE(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "OnSaveSyncAnyResult", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003BBC RID: 15292 RVA: 0x0018BE51 File Offset: 0x0018A051
	private void MNNHONLLGCD()
	{
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("author", new UnityAction(this.OEDMFHBLKMN));
		this.DGEGGMIJNFK();
	}

	// Token: 0x06003BBD RID: 15293 RVA: 0x0018BE74 File Offset: 0x0018A074
	private void EKOGHMFPHDH()
	{
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("fdnpr", new UnityAction(this.IMGNMMBLMHI));
		this.EPGNFLEIHFK();
	}

	// Token: 0x06003BBE RID: 15294 RVA: 0x0018BE97 File Offset: 0x0018A097
	private string GLEFEKBDHNK(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.EAIAHCBAIEJ().DFCIIIKIABF(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003BBF RID: 15295 RVA: 0x0018BEC4 File Offset: 0x0018A0C4
	private void AKMGONEKIJG()
	{
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.HPOAGPJFHPM(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.HIPJILDCHJC(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.FGFBENKGKPO(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.DEEEPKAJAJF(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BC0 RID: 15296 RVA: 0x0018BFC4 File Offset: 0x0018A1C4
	private void EPGNFLEIHFK()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.GLEFEKBDHNK(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.OHLNGCKIACD(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 1)
					{
						this.NPDEIFPJBKA[i].text = this.DNILNCLIHAP(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.CLFFOEGMCAE(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BC1 RID: 15297 RVA: 0x0018C0C4 File Offset: 0x0018A2C4
	private void HHBPGAMBAAE()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.KBOHGKGFENO();
	}

	// Token: 0x06003BC2 RID: 15298 RVA: 0x0018C0F0 File Offset: 0x0018A2F0
	private void HODLFACDLNB()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.DHDNPCGNCDE(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.MNINMBIDLDG(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.FIENAKIHNOM(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.CGNFIBHFLOP(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BC3 RID: 15299 RVA: 0x00002296 File Offset: 0x00000496
	private void BJGAGLBOFPB()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003BC4 RID: 15300 RVA: 0x000022C3 File Offset: 0x000004C3
	private void LCABJCEEJJO()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x0018C1F0 File Offset: 0x0018A3F0
	private void IMGNMMBLMHI()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.EIIHLNAMKCN(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.IKMNGFIDCLM(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.MCBNMABCKKG(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.MNINMBIDLDG(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BC6 RID: 15302 RVA: 0x0018C2F0 File Offset: 0x0018A4F0
	private void KCCHCNHBNHC()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.DHDNPCGNCDE(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.ENOMPNKEAJG(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.EIIHLNAMKCN(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.HIPJILDCHJC(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BC7 RID: 15303 RVA: 0x0018C3F0 File Offset: 0x0018A5F0
	private void KGENGPOFIEL()
	{
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("0.000", new UnityAction(this.AKMGONEKIJG));
		this.HODLFACDLNB();
	}

	// Token: 0x06003BC8 RID: 15304 RVA: 0x0018C413 File Offset: 0x0018A613
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLanguageChange", new UnityAction(this.KGHIKMIOHCC));
		this.KGHIKMIOHCC();
	}

	// Token: 0x06003BC9 RID: 15305 RVA: 0x0018C436 File Offset: 0x0018A636
	private void AADPIFCICBL()
	{
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("OnSaveSlotDelete", new UnityAction(this.LNIJDKDDOAN));
		this.IMGNMMBLMHI();
	}

	// Token: 0x06003BCA RID: 15306 RVA: 0x0018C459 File Offset: 0x0018A659
	private string DEEJDPFGCCD(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KFDLFGHBPLP().IKMNGFIDCLM(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003BCB RID: 15307 RVA: 0x00002296 File Offset: 0x00000496
	private void MPJCJLOMPED()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003BCC RID: 15308 RVA: 0x0018C484 File Offset: 0x0018A684
	private void OCOOJNFJJPG()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.IJMCFFNBOKH();
	}

	// Token: 0x06003BCD RID: 15309 RVA: 0x0018C4AE File Offset: 0x0018A6AE
	private string CGNFIBHFLOP(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.DLGLFACMHPG().DNILNCLIHAP(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "Error. FadeDst(), layer ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003BCE RID: 15310 RVA: 0x0018C4D9 File Offset: 0x0018A6D9
	private string GAOMHAHEEFH(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KMNBCEMEBBD().NACCNJEBNHL(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "liveOfferId", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003BD0 RID: 15312 RVA: 0x000022C3 File Offset: 0x000004C3
	private void EHCGGEMIOGE()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BD1 RID: 15313 RVA: 0x000022C3 File Offset: 0x000004C3
	private void LOACLDAHKGF()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BD2 RID: 15314 RVA: 0x0018C528 File Offset: 0x0018A728
	private void IJMCFFNBOKH()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.DHDNPCGNCDE(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.OFOFBBPBFBN(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 1)
					{
						this.NPDEIFPJBKA[i].text = this.MCBNMABCKKG(this.stringIndex);
					}
					else if (this.stringId.Length > 1)
					{
						this.NPDEIFPJBKA[i].text = this.GMLHKCGNMIO(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BD3 RID: 15315 RVA: 0x0018C628 File Offset: 0x0018A828
	private void HBBFAAOICDH()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.EIKHNOJIJJF();
	}

	// Token: 0x06003BD4 RID: 15316 RVA: 0x0018BD50 File Offset: 0x00189F50
	private void CIHNHBCEAMI()
	{
		this.KIDOILDEFEB();
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x0018BD50 File Offset: 0x00189F50
	private void DBMENPFHHCM()
	{
		this.KIDOILDEFEB();
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x0018C652 File Offset: 0x0018A852
	private string BFBEFOBGAPG(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KNKGCDDMLDP().KLAOJFGLCKB(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "getDepot", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003BD8 RID: 15320 RVA: 0x0018C680 File Offset: 0x0018A880
	private void NHIIGLBFFBD()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.LKBIOFEFBGP(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.IKMNGFIDCLM(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.DHDNPCGNCDE(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.MNINMBIDLDG(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BD9 RID: 15321 RVA: 0x0018C780 File Offset: 0x0018A980
	private string PKCFNHEIIDG(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.CPCOODCFDDP().HIPJILDCHJC(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "errortitle", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003BDA RID: 15322 RVA: 0x0018C7AB File Offset: 0x0018A9AB
	private void OJIOGKJEBMM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().MHLNJIACIGO("OnBackendSavePublicProfileSuccess", new UnityAction(this.EIKHNOJIJJF));
	}

	// Token: 0x06003BDB RID: 15323 RVA: 0x000022C3 File Offset: 0x000004C3
	private void MOEKELPHKIE()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BDC RID: 15324 RVA: 0x0018C7D0 File Offset: 0x0018A9D0
	private string MEPECBDCOLG(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.INKJIBDDMLL().IDIEOPEMJBA(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "skinshoplimited", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003BDD RID: 15325 RVA: 0x0018C7FB File Offset: 0x0018A9FB
	private string LNIOENMPDFD(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KNKGCDDMLDP().NACCNJEBNHL(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "x", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003BDE RID: 15326 RVA: 0x0018C826 File Offset: 0x0018AA26
	private void KDKPPDMCEBF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("CLIENT.SCREEN.AVATAR.", new UnityAction(this.IJMCFFNBOKH));
	}

	// Token: 0x06003BDF RID: 15327 RVA: 0x000022C3 File Offset: 0x000004C3
	private void GBKJFCMFOHA()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BE0 RID: 15328 RVA: 0x0018C84C File Offset: 0x0018AA4C
	private void JFEBKAONPHI()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.NACCNJEBNHL(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.EDADDMHFLOL(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.LNIOENMPDFD(this.stringIndex);
					}
					else if (this.stringId.Length > 1)
					{
						this.NPDEIFPJBKA[i].text = this.DEEJDPFGCCD(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BE1 RID: 15329 RVA: 0x0018C94C File Offset: 0x0018AB4C
	private void DJEHHCPNPHC()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("ok", new UnityAction(this.DAODGOPILEC));
		this.DGEGGMIJNFK();
	}

	// Token: 0x06003BE2 RID: 15330 RVA: 0x0018C96F File Offset: 0x0018AB6F
	private void GEPMOBKFIMI()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("no", new UnityAction(this.KGHIKMIOHCC));
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x0018C994 File Offset: 0x0018AB94
	private void AKIFACAINPL()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("OnStoryChoiceClick", new UnityAction(this.HODLFACDLNB));
		this.DGEGGMIJNFK();
	}

	// Token: 0x06003BE4 RID: 15332 RVA: 0x0018C9B7 File Offset: 0x0018ABB7
	private void MKPFIAHNCOH()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.IMGNMMBLMHI();
	}

	// Token: 0x06003BE5 RID: 15333 RVA: 0x0018C9E1 File Offset: 0x0018ABE1
	private void HKCLEPNKGDH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("rsl", new UnityAction(this.KCCHCNHBNHC));
	}

	// Token: 0x06003BE6 RID: 15334 RVA: 0x0018CA08 File Offset: 0x0018AC08
	private void JCDOLLLCCGO()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.EIIHLNAMKCN(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 0)
				{
					this.DPLMFJDDAKD.text = this.DNILNCLIHAP(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.HPOAGPJFHPM(this.stringIndex);
					}
					else if (this.stringId.Length > 1)
					{
						this.NPDEIFPJBKA[i].text = this.OFOFBBPBFBN(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BE7 RID: 15335 RVA: 0x0018CB08 File Offset: 0x0018AD08
	private void NGPCCGAKIHA()
	{
		this.LGOFOGNAGDK();
	}

	// Token: 0x06003BE8 RID: 15336 RVA: 0x0018CB10 File Offset: 0x0018AD10
	private void DGAFAPKAKIA()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.LNIJDKDDOAN();
	}

	// Token: 0x06003BE9 RID: 15337 RVA: 0x0018CB3A File Offset: 0x0018AD3A
	private void LFOJBMBCOFP()
	{
		this.HBBFAAOICDH();
	}

	// Token: 0x06003BEA RID: 15338 RVA: 0x0018CB42 File Offset: 0x0018AD42
	private string EDADDMHFLOL(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.JINDKPHNLBK().DNILNCLIHAP(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003BEB RID: 15339 RVA: 0x0018CB6D File Offset: 0x0018AD6D
	private string ENOMPNKEAJG(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.JMDJPKKOHNI().BDGPNPNIAPA(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "p", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003BEC RID: 15340 RVA: 0x0018CB98 File Offset: 0x0018AD98
	private void LNKJIJJJGIA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().KDIFKFKMCOH("), skipped: last saveSync ack was ", new UnityAction(this.HODLFACDLNB));
	}

	// Token: 0x06003BED RID: 15341 RVA: 0x0018CBBD File Offset: 0x0018ADBD
	private void GPEDLMKNBCJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("seq", new UnityAction(this.LNIJDKDDOAN));
	}

	// Token: 0x06003BEE RID: 15342 RVA: 0x0018CBE2 File Offset: 0x0018ADE2
	private void KIDOILDEFEB()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.JFEBKAONPHI();
	}

	// Token: 0x06003BEF RID: 15343 RVA: 0x0018CC0C File Offset: 0x0018AE0C
	private void HHDMNFGALBA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.trinket: bulk choice index must be > 0.", new UnityAction(this.DAODGOPILEC));
	}

	// Token: 0x06003BF0 RID: 15344 RVA: 0x0018CC31 File Offset: 0x0018AE31
	private void ILMGFGFCHNL()
	{
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ(" ", new UnityAction(this.JFEBKAONPHI));
		this.DGEGGMIJNFK();
	}

	// Token: 0x06003BF1 RID: 15345 RVA: 0x0018CC54 File Offset: 0x0018AE54
	private void EMBGPLOIGEN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("RemoveAcknowledgedSubRequests() - keeping sub-requests queued while the envelope was in flight, queued:", new UnityAction(this.LNIJDKDDOAN));
	}

	// Token: 0x06003BF2 RID: 15346 RVA: 0x0018CC79 File Offset: 0x0018AE79
	private string CKJCKPMBNCA(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.APGODIBBPOD().MEPECBDCOLG(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "anthologiesdesc", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003BF3 RID: 15347 RVA: 0x0018CCA4 File Offset: 0x0018AEA4
	private string DNILNCLIHAP(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003BF4 RID: 15348 RVA: 0x0018CCCF File Offset: 0x0018AECF
	private void MCOMCHOLOOO()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.DGEGGMIJNFK();
	}

	// Token: 0x06003BF5 RID: 15349 RVA: 0x0018CCF9 File Offset: 0x0018AEF9
	private void HNHFFPPELIG()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.HODLFACDLNB();
	}

	// Token: 0x06003BF6 RID: 15350 RVA: 0x0018CD23 File Offset: 0x0018AF23
	private string BDHLPOGCPNB(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.BIAEAOMHBMM().MCBNMABCKKG(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "serversync", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x0018CD50 File Offset: 0x0018AF50
	private void EIKHNOJIJJF()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.DHDNPCGNCDE(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.OFOFBBPBFBN(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.MEPECBDCOLG(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.DEEJDPFGCCD(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003BF8 RID: 15352 RVA: 0x0018CE50 File Offset: 0x0018B050
	private string FNEPBLBCCEO(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KMNBCEMEBBD().FIENAKIHNOM(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "OnBackendPremiumChoiceSuccess", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003BF9 RID: 15353 RVA: 0x0018CE7B File Offset: 0x0018B07B
	private void LPJCNKJFKJI()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.KCCHCNHBNHC();
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x0018CEA5 File Offset: 0x0018B0A5
	private void Awake()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x0018CEAD File Offset: 0x0018B0AD
	private void GIAGKNDOADK()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().KDIFKFKMCOH("randomprofclickanth", new UnityAction(this.IJMCFFNBOKH));
	}

	// Token: 0x06003BFC RID: 15356 RVA: 0x0018CED2 File Offset: 0x0018B0D2
	private void OLDLKHFCIHC()
	{
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE("ind", new UnityAction(this.DAODGOPILEC));
		this.JCDOLLLCCGO();
	}

	// Token: 0x06003BFD RID: 15357 RVA: 0x000022C3 File Offset: 0x000004C3
	private void DHNHPHLAIOP()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003BFE RID: 15358 RVA: 0x0018CB10 File Offset: 0x0018AD10
	private void MIFPDCLHKDH()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.LNIJDKDDOAN();
	}

	// Token: 0x06003BFF RID: 15359 RVA: 0x0018CEF5 File Offset: 0x0018B0F5
	private string DEEEPKAJAJF(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.BFHKGNBFHCH().OHLNGCKIACD(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "nsktk", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003C00 RID: 15360 RVA: 0x0018CF20 File Offset: 0x0018B120
	private string IBDKJDMJNBE(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.HFAKOKBHCGH().BDGPNPNIAPA(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "OnLanguageChange", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003C01 RID: 15361 RVA: 0x0018CF4B File Offset: 0x0018B14B
	private void AEOKJCHEALH()
	{
		this.HNHFFPPELIG();
	}

	// Token: 0x06003C02 RID: 15362 RVA: 0x0018CF53 File Offset: 0x0018B153
	private string MAJJLAHEMFM(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.DBFFFOMCLKM().DFCIIIKIABF(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003C03 RID: 15363 RVA: 0x0018CE7B File Offset: 0x0018B07B
	private void ONCMEAFFFIB()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.KCCHCNHBNHC();
	}

	// Token: 0x06003C04 RID: 15364 RVA: 0x0018CF7E File Offset: 0x0018B17E
	private string OFOFBBPBFBN(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.PLJMLDOCPNM().HPOAGPJFHPM(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "...", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003C05 RID: 15365 RVA: 0x0018CFAC File Offset: 0x0018B1AC
	private void DAODGOPILEC()
	{
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.EIIHLNAMKCN(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.DEEJDPFGCCD(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 1)
					{
						this.NPDEIFPJBKA[i].text = this.MEPECBDCOLG(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.CGNFIBHFLOP(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003C06 RID: 15366 RVA: 0x0018D0AC File Offset: 0x0018B2AC
	private string NACCNJEBNHL(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.APGODIBBPOD().PPMPLNFFGGB(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "open", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003C07 RID: 15367 RVA: 0x0018D0D7 File Offset: 0x0018B2D7
	private void LDLLCBDGGHN()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("\"", new UnityAction(this.KGHIKMIOHCC));
		this.AKMGONEKIJG();
	}

	// Token: 0x06003C08 RID: 15368 RVA: 0x0018D0FA File Offset: 0x0018B2FA
	private void MHIHCHGGIDM()
	{
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("retry", new UnityAction(this.JCDOLLLCCGO));
		this.JCDOLLLCCGO();
	}

	// Token: 0x06003C09 RID: 15369 RVA: 0x0018D11D File Offset: 0x0018B31D
	private string MCBNMABCKKG(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.ONCPHEEJLOP().ENOMPNKEAJG(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "pmterror004", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003C0A RID: 15370 RVA: 0x0018D148 File Offset: 0x0018B348
	private void NIKBFENFMID()
	{
		AOBJLALDBAA.CEGAOMEEFBE().MFIMALJPCDP("OnChapterSnapshotRestore", new UnityAction(this.OEDMFHBLKMN));
		this.IMGNMMBLMHI();
	}

	// Token: 0x06003C0B RID: 15371 RVA: 0x0018C628 File Offset: 0x0018A828
	private void BGLIAHEKACL()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.EIKHNOJIJJF();
	}

	// Token: 0x06003C0C RID: 15372 RVA: 0x0018D16B File Offset: 0x0018B36B
	private void LAFCNAHCIFJ()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.DAODGOPILEC();
	}

	// Token: 0x06003C0D RID: 15373 RVA: 0x0018D195 File Offset: 0x0018B395
	private string HIPJILDCHJC(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KMNBCEMEBBD().BGELFMIOBCL(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, " from ", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003C0E RID: 15374 RVA: 0x0018D1C0 File Offset: 0x0018B3C0
	private void EPECDBPOOLB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("", new UnityAction(this.EPGNFLEIHFK));
	}

	// Token: 0x06003C0F RID: 15375 RVA: 0x0018D1E5 File Offset: 0x0018B3E5
	private string FNJNLPPECHC(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KNKGCDDMLDP().NIBDPHGPMIB(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "Error. GetActiveStory(), activeStory is negative.", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003C10 RID: 15376 RVA: 0x0018CB3A File Offset: 0x0018AD3A
	private void KFMLOGKINPG()
	{
		this.HBBFAAOICDH();
	}

	// Token: 0x06003C11 RID: 15377 RVA: 0x0018D210 File Offset: 0x0018B410
	private void KHPGMEMIJMB()
	{
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("OnRewardsItemClose", new UnityAction(this.DGEGGMIJNFK));
		this.AACNGGBHKJI();
	}

	// Token: 0x06003C12 RID: 15378 RVA: 0x0018D233 File Offset: 0x0018B433
	private string IKMNGFIDCLM(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.DBFFFOMCLKM().FIENAKIHNOM(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "acli21", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003C13 RID: 15379 RVA: 0x0018D25E File Offset: 0x0018B45E
	private string EIIHLNAMKCN(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.NIOJNOFGIJO().IDADLHHLGFJ(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, " cloud shop row(s) appended to ", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003C14 RID: 15380 RVA: 0x0018C0C4 File Offset: 0x0018A2C4
	private void LGOFOGNAGDK()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.KBOHGKGFENO();
	}

	// Token: 0x06003C15 RID: 15381 RVA: 0x0018D289 File Offset: 0x0018B489
	private void JLCMPGICMDC()
	{
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE(" ", new UnityAction(this.JFEBKAONPHI));
		this.EPGNFLEIHFK();
	}

	// Token: 0x06003C16 RID: 15382 RVA: 0x0018D2AC File Offset: 0x0018B4AC
	private string FIENAKIHNOM(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.GIOAFDDKKHI().NIBDPHGPMIB(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, " ", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003C17 RID: 15383 RVA: 0x0018D2D7 File Offset: 0x0018B4D7
	private void CPHKLKGJEBH()
	{
		this.HHBPGAMBAAE();
	}

	// Token: 0x06003C18 RID: 15384 RVA: 0x0018D2DF File Offset: 0x0018B4DF
	private string NBGKHEJMJHH(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.ILACPHFEDEP().CKJCKPMBNCA(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06003C19 RID: 15385 RVA: 0x0018D30A File Offset: 0x0018B50A
	private string OHLNGCKIACD(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.EHBBFMCILPC.GLEFEKBDHNK(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003C1A RID: 15386 RVA: 0x0018D335 File Offset: 0x0018B535
	private void NEHDFKDKBLC()
	{
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("avatarcollectionssubrequiredtitle", new UnityAction(this.KCCHCNHBNHC));
		this.OEDMFHBLKMN();
	}

	// Token: 0x06003C1B RID: 15387 RVA: 0x0018D358 File Offset: 0x0018B558
	private void MPDHFPBIION()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("yes", new UnityAction(this.KCCHCNHBNHC));
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x0018CF4B File Offset: 0x0018B14B
	private void FDLCNFDHAAM()
	{
		this.HNHFFPPELIG();
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x0018D37D File Offset: 0x0018B57D
	private string DHDNPCGNCDE(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.KLAKLFCOMJC().ENOMPNKEAJG(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "$USELAYERSV3", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
	}

	// Token: 0x06003C1E RID: 15390 RVA: 0x000022C3 File Offset: 0x000004C3
	private void IGAAJBMALKA()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003C1F RID: 15391 RVA: 0x0018D3A8 File Offset: 0x0018B5A8
	private void FCOKGLDPJJO()
	{
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("OnLobbyLoungeAssetsDownloadFailed", new UnityAction(this.KGHIKMIOHCC));
		this.KBOHGKGFENO();
	}

	// Token: 0x06003C20 RID: 15392 RVA: 0x0018D3CC File Offset: 0x0018B5CC
	private void LNIJDKDDOAN()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ();
				if (this.stringIndex >= 1)
				{
					this.DPLMFJDDAKD.text = this.LKBIOFEFBGP(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.EDADDMHFLOL(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.DNILNCLIHAP(this.stringIndex);
					}
					else if (this.stringId.Length > 1)
					{
						this.NPDEIFPJBKA[i].text = this.FNEPBLBCCEO(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003C21 RID: 15393 RVA: 0x0018D4CC File Offset: 0x0018B6CC
	private string DNILNCLIHAP(int DKOLMNNPMDB)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(DKOLMNNPMDB);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DKOLMNNPMDB, "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06003C22 RID: 15394 RVA: 0x0018D16B File Offset: 0x0018B36B
	private void KLJIMOGLHEF()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.DAODGOPILEC();
	}

	// Token: 0x06003C23 RID: 15395 RVA: 0x0018CE7B File Offset: 0x0018B07B
	private void FNLKGBALACA()
	{
		this.DPLMFJDDAKD = base.gameObject.GetComponent<Text>();
		this.NPDEIFPJBKA = base.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
		this.KCCHCNHBNHC();
	}

	// Token: 0x06003C24 RID: 15396 RVA: 0x0018D4F7 File Offset: 0x0018B6F7
	private string MNINMBIDLDG(string DMNKDCGMKKP)
	{
		if (this.source == KEFOLACHFHL.client)
		{
			return CCOJBMMKNAP.JINDKPHNLBK().BGELFMIOBCL(DMNKDCGMKKP);
		}
		return GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, "ok", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
	}

	// Token: 0x06003C25 RID: 15397 RVA: 0x0018D524 File Offset: 0x0018B724
	private void DGEGGMIJNFK()
	{
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.FGFBENKGKPO(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.GMLHKCGNMIO(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				for (int i = 0; i < this.NPDEIFPJBKA.Length; i += 0)
				{
					if (this.stringIndex >= 0)
					{
						this.NPDEIFPJBKA[i].text = this.BFBEFOBGAPG(this.stringIndex);
					}
					else if (this.stringId.Length > 0)
					{
						this.NPDEIFPJBKA[i].text = this.IKMNGFIDCLM(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003C26 RID: 15398 RVA: 0x0018D624 File Offset: 0x0018B824
	private void KBOHGKGFENO()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != (CEIBHCNNIDC)this.LHABEJBDLGN)
		{
			if (null != this.DPLMFJDDAKD)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ();
				if (this.stringIndex >= 0)
				{
					this.DPLMFJDDAKD.text = this.FNJNLPPECHC(this.stringIndex);
					return;
				}
				if (this.stringId.Length > 1)
				{
					this.DPLMFJDDAKD.text = this.DEEJDPFGCCD(this.stringId);
					return;
				}
			}
			else if (this.NPDEIFPJBKA != null)
			{
				this.LHABEJBDLGN = (int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD();
				for (int i = 1; i < this.NPDEIFPJBKA.Length; i++)
				{
					if (this.stringIndex >= 1)
					{
						this.NPDEIFPJBKA[i].text = this.MEPECBDCOLG(this.stringIndex);
					}
					else if (this.stringId.Length > 1)
					{
						this.NPDEIFPJBKA[i].text = this.CGNFIBHFLOP(this.stringId);
					}
				}
			}
		}
	}

	// Token: 0x06003C27 RID: 15399 RVA: 0x0018D724 File Offset: 0x0018B924
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLanguageChange", new UnityAction(this.KGHIKMIOHCC));
	}

	// Token: 0x06003C28 RID: 15400 RVA: 0x000022C3 File Offset: 0x000004C3
	private void HELIPJGLNKD()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x04001152 RID: 4434
	public KEFOLACHFHL source;

	// Token: 0x04001153 RID: 4435
	public int stringIndex = -1;

	// Token: 0x04001154 RID: 4436
	public string stringId = "";

	// Token: 0x04001155 RID: 4437
	private Text DPLMFJDDAKD;

	// Token: 0x04001156 RID: 4438
	private TextMeshProUGUI[] NPDEIFPJBKA;

	// Token: 0x04001157 RID: 4439
	private int LHABEJBDLGN = -1;
}
