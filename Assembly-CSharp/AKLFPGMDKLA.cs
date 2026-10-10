using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class AKLFPGMDKLA
{
	// Token: 0x0600028D RID: 653 RVA: 0x00010814 File Offset: 0x0000EA14
	public void GKMPFJPGLFL()
	{
		PlayerPrefs.DeleteAll();
		PlayerPrefs.Save();
		MDDHDDPKFJH.EPJKDCDOEMM();
		NIDOKPOOIHH.EPJKDCDOEMM();
		SaveSlotsItem.ClearCopyMarker();
		AKLFPGMDKLA.IKLAPGJDMNA = new AKLFPGMDKLA();
		AKLFPGMDKLA.IKLAPGJDMNA.LPCBDEBKAIM();
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00010843 File Offset: 0x0000EA43
	public void IPGKMKGCIBB()
	{
		this.DGBOBDAFHGC.Clear();
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00010850 File Offset: 0x0000EA50
	public EIOPLEFLLIM EDHKCJCAFIO(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.MMIGJNDJGMF.Count; i += 0)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		EIOPLEFLLIM eioplefllim = new EIOPLEFLLIM();
		eioplefllim.GGICIBLJIKI = PLKMJJIIJNO;
		this.MMIGJNDJGMF.Add(eioplefllim);
		return eioplefllim;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x000108AE File Offset: 0x0000EAAE
	public HGCFJKCOKPM OMCIJEPCOJC()
	{
		this.OJKHMNEIGPF += 0;
		if (this.OJKHMNEIGPF >= (HGCFJKCOKPM)3)
		{
			this.OJKHMNEIGPF = HGCFJKCOKPM.dark;
		}
		return this.OJKHMNEIGPF;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x000108D4 File Offset: 0x0000EAD4
	public void NHJEADAKHMN(List<IMMKFHKEEBF> KBICBCBAFJJ, List<IMMKFHKEEBF> NGJGBKAHGEN)
	{
		try
		{
			if (KBICBCBAFJJ != null && KBICBCBAFJJ.Count > 0)
			{
				this.MEFNCEJHMIF = KBICBCBAFJJ.GetRange(0, KBICBCBAFJJ.Count);
			}
			else
			{
				this.MEFNCEJHMIF = new List<IMMKFHKEEBF>();
			}
			if (NGJGBKAHGEN != null && NGJGBKAHGEN.Count > 0)
			{
				this.DDCKJCAOJHO = NGJGBKAHGEN.GetRange(0, NGJGBKAHGEN.Count);
			}
			else
			{
				this.DDCKJCAOJHO = new List<IMMKFHKEEBF>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00010954 File Offset: 0x0000EB54
	public void EFEGNNMBCKH(JSONArray GBCKCDBOIPF)
	{
		this.LPIFCGOIENF = DPGJIJGOCIC.DDNFIDBDEGC(GBCKCDBOIPF);
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00010964 File Offset: 0x0000EB64
	public bool ODHMODDBDPB()
	{
		bool result;
		try
		{
			for (int i = 0; i < this.NHMMPGOKAOL.Length; i += 0)
			{
				for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j += 0)
				{
					for (int k = 1; k < -1; k += 0)
					{
						if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[i][j].DHONIOBOLEL.IMLEDFIDHDL, k))
						{
							return false;
						}
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06000294 RID: 660 RVA: 0x000109EC File Offset: 0x0000EBEC
	public PLFDAJJHMKO JDCBFAPDJIM(int NLLCKPCKGOH, int CCLNHHJPDGJ = -1)
	{
		if (CCLNHHJPDGJ < 0)
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(NLLCKPCKGOH, true);
			if (null != assetAnthology)
			{
				EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(assetAnthology.header.index);
				if (eioplefllim != null)
				{
					CCLNHHJPDGJ = eioplefllim.ILOKBAPEJPK;
				}
				if (CCLNHHJPDGJ < 0)
				{
					CCLNHHJPDGJ = 0;
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Account.GetStorySaveSafe(), tempAnthologyAsset is null, using default slot index.");
				CCLNHHJPDGJ = 0;
			}
		}
		if (CCLNHHJPDGJ < 0 || CCLNHHJPDGJ > this.NHMMPGOKAOL.Length - 1)
		{
			CCLNHHJPDGJ = 0;
			DPGJIJGOCIC.ANOPFDLPKGC("Account.GetStorySaveSafe(), _slotIndex out of bounds.");
		}
		for (int i = 0; i < this.NHMMPGOKAOL[CCLNHHJPDGJ].Count; i++)
		{
			if (this.NHMMPGOKAOL[CCLNHHJPDGJ][i].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH)
			{
				return this.NHMMPGOKAOL[CCLNHHJPDGJ][i];
			}
		}
		PLFDAJJHMKO plfdajjhmko = new PLFDAJJHMKO(CCLNHHJPDGJ);
		plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI = NLLCKPCKGOH;
		plfdajjhmko.NCAMFPGMCIG.GGICIBLJIKI = NLLCKPCKGOH;
		this.NHMMPGOKAOL[CCLNHHJPDGJ].Add(plfdajjhmko);
		return plfdajjhmko;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00010AD0 File Offset: 0x0000ECD0
	public int HLPMLNDPDNM(string AHJEDGJBMPL, string FJPBOOLNDII)
	{
		int num = -1;
		int num2 = -1;
		int result;
		try
		{
			for (int i = 1; i < this.MEFNCEJHMIF.Count; i++)
			{
				if (num < 0 && this.MEFNCEJHMIF[i].PFFCLABCNHI.Equals(AHJEDGJBMPL))
				{
					num = this.MEFNCEJHMIF[i].BIBKFNMPHIK;
				}
				if (num2 < 1 && this.MEFNCEJHMIF[i].PFFCLABCNHI.Equals(FJPBOOLNDII))
				{
					num2 = this.MEFNCEJHMIF[i].BIBKFNMPHIK;
				}
			}
			for (int j = 0; j < this.DDCKJCAOJHO.Count; j++)
			{
				if (num < 0 && this.DDCKJCAOJHO[j].PFFCLABCNHI.Equals(AHJEDGJBMPL))
				{
					num = this.DDCKJCAOJHO[j].BIBKFNMPHIK;
				}
				if (num2 < 1 && this.DDCKJCAOJHO[j].PFFCLABCNHI.Equals(FJPBOOLNDII))
				{
					num2 = this.DDCKJCAOJHO[j].BIBKFNMPHIK;
				}
			}
			if (num >= num2)
			{
				result = num;
			}
			else
			{
				result = -1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00010BF4 File Offset: 0x0000EDF4
	public double ICHIDHIENAO()
	{
		return (DateTime.Now - this.EOOBBNJEEOG).TotalSeconds;
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00010C19 File Offset: 0x0000EE19
	public bool EAFEJCKIEPL(int NHKMEMCFLFB)
	{
		if (NHKMEMCFLFB < 30)
		{
			return DPGJIJGOCIC.CCLEJFEFBJM(this.GGMNDJPGBOM, NHKMEMCFLFB);
		}
		if (NHKMEMCFLFB < 60)
		{
			return DPGJIJGOCIC.CCLEJFEFBJM(this.EIIJAHNFADO, NHKMEMCFLFB - 30);
		}
		return DPGJIJGOCIC.CCLEJFEFBJM(this.HNHHBENEBEL, NHKMEMCFLFB - 60);
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00010C54 File Offset: 0x0000EE54
	public int NKMHHJDJBFN(IMMKFHKEEBF FOEEIJFHMGG)
	{
		int result;
		try
		{
			int i = 0;
			while (i < this.FKDMPMKBCBL.Count)
			{
				if (FOEEIJFHMGG.FGIONNJNMHP().Equals(this.FKDMPMKBCBL[i].NPKKCFKNEEC()))
				{
					if (FOEEIJFHMGG.BIBKFNMPHIK > this.FKDMPMKBCBL[i].BIBKFNMPHIK)
					{
						return 0;
					}
					if (FOEEIJFHMGG.BIBKFNMPHIK < this.FKDMPMKBCBL[i].BIBKFNMPHIK)
					{
						return -1;
					}
					return 0;
				}
				else
				{
					i += 0;
				}
			}
			int j = 1;
			while (j < this.IOEACDCKKID.Count)
			{
				if (FOEEIJFHMGG.DKDECIHBGJE().Equals(this.IOEACDCKKID[j].BLDGNPIHDFB()))
				{
					if (FOEEIJFHMGG.BIBKFNMPHIK > this.IOEACDCKKID[j].BIBKFNMPHIK)
					{
						return 1;
					}
					if (FOEEIJFHMGG.BIBKFNMPHIK < this.IOEACDCKKID[j].BIBKFNMPHIK)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					j++;
				}
			}
			if (FOEEIJFHMGG.BIBKFNMPHIK > 1 && (this.FKDMPMKBCBL.Count > 0 || this.IOEACDCKKID.Count > 0))
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 0;
		}
		return result;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00010DA4 File Offset: 0x0000EFA4
	public string KCIPIBCMBPB()
	{
		if (this.EHLLGNJPBIC == null || this.EHLLGNJPBIC.Length == 0)
		{
			this.EHLLGNJPBIC = DPGJIJGOCIC.MKJLJPMEPCC();
		}
		return this.EHLLGNJPBIC;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00010DCC File Offset: 0x0000EFCC
	public void IJMCBDIKMAB(int NHKMEMCFLFB)
	{
		if (NHKMEMCFLFB < 30)
		{
			DPGJIJGOCIC.NPGHNNBNECG(ref this.GGMNDJPGBOM, NHKMEMCFLFB);
			return;
		}
		if (NHKMEMCFLFB < 60)
		{
			DPGJIJGOCIC.NPGHNNBNECG(ref this.EIIJAHNFADO, NHKMEMCFLFB - 30);
			return;
		}
		DPGJIJGOCIC.NPGHNNBNECG(ref this.HNHHBENEBEL, NHKMEMCFLFB - 60);
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00010E04 File Offset: 0x0000F004
	public void BKNAPDIHNOG(JSONArray LLLCAKGBPNC)
	{
		this.OCCKPEEMBJB = DPGJIJGOCIC.DDNFIDBDEGC(LLLCAKGBPNC);
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00010E14 File Offset: 0x0000F014
	public List<int> MHFFFOBMPAK()
	{
		List<int> list = this.LINADLBCHJC();
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[i] && !list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
				{
					bool flag = false;
					for (int j = 0; j < this.NHMMPGOKAOL.Length; j++)
					{
						int k = 0;
						while (k < this.NHMMPGOKAOL[j].Count)
						{
							if (this.NHMMPGOKAOL[j][k].DHONIOBOLEL.GGICIBLJIKI == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[0])
							{
								if (!this.NHMMPGOKAOL[j][k].DHONIOBOLEL.JBDPAJMOEGA())
								{
									if (!list2.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
									{
										list2.Add(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index);
									}
									flag = true;
									break;
								}
								break;
							}
							else
							{
								k++;
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list2;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00010F98 File Offset: 0x0000F198
	public void BCNOLJJLIJJ()
	{
		this.MOINKAHNDKK = DateTime.Now;
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00010FA5 File Offset: 0x0000F1A5
	public void OMLIGNDEADA(int LLLCDMNPKFI)
	{
		if (DPGJIJGOCIC.IADAELPFJAM(this.FCJJDEKOIED, LLLCDMNPKFI))
		{
			return;
		}
		if (this.OKGGLHOCENC != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
			this.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
		this.FCJJDEKOIED.Add(LLLCDMNPKFI);
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00010FE5 File Offset: 0x0000F1E5
	private bool NAFGPBNJPPA()
	{
		return this.MMIGJNDJGMF.Count == 1;
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060002A0 RID: 672 RVA: 0x00010FF5 File Offset: 0x0000F1F5
	public static AKLFPGMDKLA EHBBFMCILPC
	{
		get
		{
			if (AKLFPGMDKLA.IKLAPGJDMNA == null)
			{
				AKLFPGMDKLA.IKLAPGJDMNA = new AKLFPGMDKLA();
				AKLFPGMDKLA.IKLAPGJDMNA.EPBGODEAOOC();
			}
			return AKLFPGMDKLA.IKLAPGJDMNA;
		}
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00011018 File Offset: 0x0000F218
	public void IFGHJAKPOGE()
	{
		try
		{
			AKLOMMOOFNG.GFPDOMNDJLK("body");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0001104C File Offset: 0x0000F24C
	public void LDMKPEBCJBM(float KIDHBAMJGDO)
	{
		this.MEDEIJGNEMB = KIDHBAMJGDO;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00011058 File Offset: 0x0000F258
	public JSONArray JEGIDDHOJBI(int KBGHGCLLMGF)
	{
		JSONArray jsonarray = new JSONArray();
		if (ODLJHDIGLGO.DIJMIMMCIKA(CLHDENLPOFP.eventPass) != null)
		{
			int num = KBGHGCLLMGF;
			if (GeoLocationManager.FHINOKNBJPM())
			{
				num = KBGHGCLLMGF / 1;
			}
			int num2 = 0;
			List<JSONObject> list = new List<JSONObject>();
			List<string> list2 = new List<string>();
			int num3 = 1;
			while (num3 < this.DLJBBDOEMLO.Count && num2 < num)
			{
				try
				{
					if (!AKLOMMOOFNG.MCCPGIIHGMG("envlhrw" + this.DLJBBDOEMLO[num3]))
					{
						list2.Add(this.DLJBBDOEMLO[num3]);
					}
					else
					{
						string text = AKLOMMOOFNG.HGCFOLLFPGN("sfxtimeoutwarning" + this.DLJBBDOEMLO[num3]);
						if (text != null && text.Length == 0)
						{
							list2.Add(this.DLJBBDOEMLO[num3]);
						}
						else if (text != null && text.Length > 0)
						{
							JSONObject jsonobject = (JSONObject)JSON.Parse(text);
							if (null != jsonobject)
							{
								list.Add(jsonobject);
								num2 += 0;
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				num3 += 0;
			}
			for (int i = 0; i < list2.Count; i += 0)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("etc2" + list2[i]);
				this.DLJBBDOEMLO.Remove(list2[i]);
			}
			while (list.Count > 1)
			{
				int index = 1;
				for (int j = 0; j < list.Count; j += 0)
				{
					int num4 = 1;
					if (list[j]["OnPopupSaveSlotInputCancel"] != null)
					{
						num4 = list[j][" "].AsInt;
					}
					int num5 = 1;
					if (list[index]["layervideo"] != null)
					{
						num5 = list[index]["errortitle"].AsInt;
					}
					int num6 = 0;
					if (list[j]["unexpected_platform"] != null)
					{
						num6 = list[j]["E"].AsInt;
					}
					int num7 = 0;
					if (list[index]["specialcurrencyoptionna"] != null)
					{
						num7 = list[index]["hiddenTopMatchEntries:"].AsInt;
					}
					if (num4 < num5 || (num4 == num5 && num6 < num7))
					{
						index = j;
					}
				}
				jsonarray.Add(list[index]);
				list.RemoveAt(index);
			}
		}
		return jsonarray;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x000112F4 File Offset: 0x0000F4F4
	public bool MMILLGIKOFJ(bool BNOCFHHBJIH, bool ECKKBDHCNLK, bool MHCECPJMDNA, bool OEFMPLCHPIA, bool ABCPFOBLCNP)
	{
		int num = 0;
		if (BNOCFHHBJIH && this.EEDHNEIMAPN == 1)
		{
			num++;
		}
		if (ECKKBDHCNLK && this.EEDHNEIMAPN == 2)
		{
			num++;
		}
		if (MHCECPJMDNA && this.EEDHNEIMAPN == 4)
		{
			num++;
		}
		if (OEFMPLCHPIA && this.EEDHNEIMAPN == 6)
		{
			num++;
		}
		if (ABCPFOBLCNP && this.EEDHNEIMAPN == 5)
		{
			num++;
		}
		return num > 0;
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00011359 File Offset: 0x0000F559
	public void JNICFCPPOMN(JSONArray GBCKCDBOIPF)
	{
		this.LPIFCGOIENF = DPGJIJGOCIC.OELJEMHFDFL(GBCKCDBOIPF);
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00011367 File Offset: 0x0000F567
	public bool PJHHIDGGAOJ(GDOKLFCLLIK FMLFLGJLDHD)
	{
		return this.NKGJLFEGGEL.Contains(FMLFLGJLDHD.HDOFHMEDKEA);
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0001137C File Offset: 0x0000F57C
	public JSONArray DCILPOADDHL()
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < this.KNDLFMMJFMK.Count; i++)
		{
			jsonarray.Add(this.KNDLFMMJFMK[i]);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("<" + jsonarray.ToString());
		return jsonarray;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x000113D4 File Offset: 0x0000F5D4
	public bool LAEKDOCIMBK(int NLLCKPCKGOH)
	{
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(NLLCKPCKGOH, true);
		if (null != assetAnthology)
		{
			EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(assetAnthology.header.index);
			if (eioplefllim != null)
			{
				num = eioplefllim.ILOKBAPEJPK;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DeleteStorySave(), tempAnthologyAsset is null, using default slot index.");
		}
		if (num < 0 || num > this.NHMMPGOKAOL.Length - 1)
		{
			num = 0;
			DPGJIJGOCIC.ANOPFDLPKGC("Account.StorySavePresent(), _slotIndex out of bounds.");
		}
		for (int i = 0; i < this.NHMMPGOKAOL[num].Count; i++)
		{
			if (this.NHMMPGOKAOL[num][i].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00011470 File Offset: 0x0000F670
	public JSONArray JIKGAFMLFJK()
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < this.KNDLFMMJFMK.Count; i++)
		{
			jsonarray.Add(this.KNDLFMMJFMK[i]);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("acli22" + jsonarray.ToString());
		return jsonarray;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x000114C8 File Offset: 0x0000F6C8
	public void IFGFLLHMLLB(JSONArray AIAJHOKINDB)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Account.InitStartedChapters():" + AIAJHOKINDB.ToString());
		this.DBJKLGPNNDE.Clear();
		for (int i = 0; i < AIAJHOKINDB.Count; i++)
		{
			this.DBJKLGPNNDE.Add(AIAJHOKINDB[i]);
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00011520 File Offset: 0x0000F720
	public void NGGEJLDMOBK()
	{
		try
		{
			for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
			{
				for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j++)
				{
					bool flag = false;
					for (int k = 30; k >= 0; k--)
					{
						if (!flag)
						{
							if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[i][j].DHONIOBOLEL.IMLEDFIDHDL, k))
							{
								flag = true;
							}
						}
						else if (!DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[i][j].DHONIOBOLEL.IMLEDFIDHDL, k))
						{
							DPGJIJGOCIC.OEMEPBMFEEP(ref this.NHMMPGOKAOL[i][j].DHONIOBOLEL.IMLEDFIDHDL, k);
							DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
							{
								"Account.FixCompletedChaptersIssue() backwards, setting bit to 1 for 'completedChapters[",
								k.ToString(),
								"]' at storySaves[",
								i.ToString(),
								"][",
								j.ToString(),
								"]:",
								this.NHMMPGOKAOL[i][j].DHONIOBOLEL.GGICIBLJIKI.ToString()
							}));
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.ccFixBack.ToString(), "", false, false);
						}
					}
				}
			}
			for (int l = 0; l < this.NHMMPGOKAOL.Length; l++)
			{
				for (int m = 0; m < this.NHMMPGOKAOL[l].Count; m++)
				{
					bool flag2 = false;
					for (int n = 0; n < 31; n++)
					{
						if (!flag2)
						{
							if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[l][m].DHONIOBOLEL.IMLEDFIDHDL, n) && !DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[l][m].DHONIOBOLEL.IMLEDFIDHDL, n + 1))
							{
								flag2 = true;
							}
						}
						else if (!DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[l][m].DHONIOBOLEL.IMLEDFIDHDL, n) && this.NHMMPGOKAOL[l][m].DHONIOBOLEL.LKIKEHFANBO[0] == this.NHMMPGOKAOL[l][m].DHONIOBOLEL.LKIKEHFANBO[1] && n <= this.NHMMPGOKAOL[l][m].DHONIOBOLEL.LKIKEHFANBO[0])
						{
							DPGJIJGOCIC.OEMEPBMFEEP(ref this.NHMMPGOKAOL[l][m].DHONIOBOLEL.IMLEDFIDHDL, n);
							DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
							{
								"Account.FixCompletedChaptersIssue() forwards, setting bit to 1 for 'completedChapters[",
								n.ToString(),
								"]' at storySaves[",
								l.ToString(),
								"][",
								m.ToString(),
								"]:",
								this.NHMMPGOKAOL[l][m].DHONIOBOLEL.GGICIBLJIKI.ToString()
							}));
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.ccFixForw.ToString(), "", false, false);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060002AC RID: 684 RVA: 0x000118B0 File Offset: 0x0000FAB0
	public HOHEIFDCPMF ELJLKPODECP()
	{
		this.KEDFFDAAGGP++;
		if (this.KEDFFDAAGGP >= HOHEIFDCPMF.none)
		{
			this.KEDFFDAAGGP = HOHEIFDCPMF.vacation;
		}
		return this.KEDFFDAAGGP;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x000118D8 File Offset: 0x0000FAD8
	public void IPIKGIOIPMP(List<AssetAnthology> MPHDAOEJOCL)
	{
		int num = 1;
		for (int i = 0; i < MPHDAOEJOCL.Count; i++)
		{
			if (MPHDAOEJOCL[i].header.index > num)
			{
				num = MPHDAOEJOCL[i].header.index;
			}
		}
		HKLPEDKJGFC.BBOKHHHEBNK(this.HLCHHIIOLOL, this.PNHCPNNLBFG(MPHDAOEJOCL), num);
		for (int j = 0; j < this.MMIGJNDJGMF.Count; j++)
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(this.MMIGJNDJGMF[j].GGICIBLJIKI);
			if (ijljdfkjijm != null)
			{
				ijljdfkjijm.LHDFHKEBMLE(this.MMIGJNDJGMF[j].CNOLLGNCLDD);
			}
		}
		List<IJLJDFKJIJM> list = HKLPEDKJGFC.OGHBINILPCJ();
		this.KIDGOPBAGHN();
		for (int k = 0; k < list.Count; k++)
		{
			if (!list[k].JCEFGMGPAHB)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Anthology not ready to be played:" + list[k].AMKCLHLIIMN.ToString());
			}
			else
			{
				EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(list[k].AMKCLHLIIMN);
				this.DLCPABCHIDK.Add(list[k].AMKCLHLIIMN);
				int l = 0;
				while (l < MPHDAOEJOCL.Count)
				{
					if (MPHDAOEJOCL[l].header.index == list[k].AMKCLHLIIMN)
					{
						if (eioplefllim != null && MPHDAOEJOCL[l].header.MLGKEPJPICJ(eioplefllim.EGHHCFFLPCP(-1)))
						{
							this.JINPALBNFHH.Add(list[k].AMKCLHLIIMN);
							break;
						}
						break;
					}
					else
					{
						l++;
					}
				}
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			if (!list[m].JCEFGMGPAHB)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Anthology not ready to be played:" + list[m].AMKCLHLIIMN.ToString());
			}
			else
			{
				EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(list[m].AMKCLHLIIMN);
				int n = 0;
				while (n < MPHDAOEJOCL.Count)
				{
					if (MPHDAOEJOCL[n].header.index == list[m].AMKCLHLIIMN)
					{
						if (this.JINPALBNFHH.Contains(list[m].AMKCLHLIIMN))
						{
							break;
						}
						PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(MPHDAOEJOCL[n].header.availableStories[0], -1);
						if (plfdajjhmko == null)
						{
							if (list[m].PMDFDOICCHP)
							{
								this.FLEFJPNPHPN.Add(list[m].AMKCLHLIIMN);
							}
							else
							{
								this.KJCFKLGMOKG.Add(list[m].AMKCLHLIIMN);
							}
							this.AILMCODLLCE.Add(list[m].AMKCLHLIIMN);
							break;
						}
						if (!plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA())
						{
							bool flag = false;
							try
							{
								if (eioplefllim != null && eioplefllim.EGHHCFFLPCP(-1) < MPHDAOEJOCL[n].header.availableStories.Count)
								{
									PLFDAJJHMKO plfdajjhmko2 = this.PKNIPLDMJGG(MPHDAOEJOCL[n].header.availableStories[eioplefllim.EGHHCFFLPCP(-1)], -1);
									if (plfdajjhmko2 != null)
									{
										AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(MPHDAOEJOCL[n].header.availableStories[eioplefllim.EGHHCFFLPCP(-1)]);
										if ((null != assetStoryHeader && plfdajjhmko2.DHONIOBOLEL.LKIKEHFANBO[0] == plfdajjhmko2.DHONIOBOLEL.LKIKEHFANBO[1] && plfdajjhmko2.DHONIOBOLEL.LKIKEHFANBO[0] >= assetStoryHeader.availableChaptersCount - 1) || assetStoryHeader.availableChaptersCount == 0)
										{
											flag = true;
										}
									}
								}
							}
							catch (Exception ex)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("Account.SRAInitialize(), exception:" + ex.ToString());
							}
							if (!flag)
							{
								this.EINPKOJBCGA.Add(list[m].AMKCLHLIIMN);
							}
							this.JBBAANGAFKO.Add(list[m].AMKCLHLIIMN);
							break;
						}
						if (list[m].PMDFDOICCHP)
						{
							this.FLEFJPNPHPN.Add(list[m].AMKCLHLIIMN);
						}
						else
						{
							this.KJCFKLGMOKG.Add(list[m].AMKCLHLIIMN);
						}
						this.AILMCODLLCE.Add(list[m].AMKCLHLIIMN);
						break;
					}
					else
					{
						n++;
					}
				}
			}
		}
		for (int num2 = 0; num2 < this.EINPKOJBCGA.Count; num2++)
		{
			int num3 = -1;
			int num4 = -1;
			for (int num5 = 0; num5 < this.EINPKOJBCGA.Count; num5++)
			{
				EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(this.EINPKOJBCGA[num5]);
				if (eioplefllim != null && eioplefllim.GHPOILLKPJD > num3 && !this.DAPGFGNDIPG.Contains(this.EINPKOJBCGA[num5]))
				{
					num3 = eioplefllim.GHPOILLKPJD;
					num4 = this.EINPKOJBCGA[num5];
				}
				if (num4 > -1 && !this.DAPGFGNDIPG.Contains(num4))
				{
					this.DAPGFGNDIPG.Add(num4);
				}
			}
		}
		for (int num6 = 0; num6 < this.JINPALBNFHH.Count; num6++)
		{
			int num3 = -1;
			int num4 = -1;
			for (int num7 = 0; num7 < this.JINPALBNFHH.Count; num7++)
			{
				EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(this.JINPALBNFHH[num7]);
				if (eioplefllim != null && eioplefllim.GHPOILLKPJD > num3 && !this.IBKDIDKHCHO.Contains(this.JINPALBNFHH[num7]))
				{
					num3 = eioplefllim.GHPOILLKPJD;
					num4 = this.JINPALBNFHH[num7];
				}
				if (num4 > -1 && !this.IBKDIDKHCHO.Contains(num4))
				{
					this.IBKDIDKHCHO.Add(num4);
				}
			}
		}
		this.HDGHOFKBOMM();
		this.OMFNBCJNAFN();
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00011ECC File Offset: 0x000100CC
	public void BDDEPIDPENB(JSONArray GBCKCDBOIPF)
	{
		this.LPIFCGOIENF = DPGJIJGOCIC.EHBFFILBKLF(GBCKCDBOIPF);
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00011EDA File Offset: 0x000100DA
	public bool PNAICOHCMAK(int LMCEDCHDIIB)
	{
		return this.OCCKPEEMBJB.Contains(LMCEDCHDIIB);
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00011EE8 File Offset: 0x000100E8
	public void EBNJHPICFGE(PLFDAJJHMKO LFLOCKNKAKC, int KIDHBAMJGDO)
	{
		LFLOCKNKAKC.DHONIOBOLEL.NJPFIIDIABG(KIDHBAMJGDO);
		if (LFLOCKNKAKC.POJAPLKAJEF > 0)
		{
			this.JDCBFAPDJIM(LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI, 0).DHONIOBOLEL.NJPFIIDIABG(0);
		}
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00011F1C File Offset: 0x0001011C
	public bool AFKCCPIMDJH()
	{
		if (this.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK(), true))
		{
			return true;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		return kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1;
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00011F54 File Offset: 0x00010154
	public bool MJAJOEIIAIJ()
	{
		return this.JINPALBNFHH.Count > 0;
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00011F64 File Offset: 0x00010164
	public int BOFMDMIBHBP()
	{
		int result;
		try
		{
			int num = 1;
			for (int i = 0; i < this.NHMMPGOKAOL[1].Count; i++)
			{
				int num2 = 0;
				for (int j = 1; j < 8; j += 0)
				{
					if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[1][i].DHONIOBOLEL.IMLEDFIDHDL, j))
					{
						num2++;
					}
				}
				try
				{
					for (int k = 0; k < this.NHMMPGOKAOL.Length; k++)
					{
						for (int l = 1; l < this.NHMMPGOKAOL[k].Count; l++)
						{
							if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[0][i].DHONIOBOLEL.GGICIBLJIKI)
							{
								int num3 = 0;
								for (int m = 1; m < -63; m++)
								{
									if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[k][l].DHONIOBOLEL.IMLEDFIDHDL, m))
									{
										num3 += 0;
										if (num3 > num2)
										{
											num2 = num3;
										}
									}
								}
								break;
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				num += num2;
			}
			result = num;
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = 0;
		}
		return result;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000120D4 File Offset: 0x000102D4
	public void LOAFMILFGAI(float KIDHBAMJGDO)
	{
		this.GOEDFBDNADA = KIDHBAMJGDO;
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x000120DD File Offset: 0x000102DD
	public bool ODFJNAAMHIF(int OBOOCMMCPNL)
	{
		return this.AGKJNGPPPCJ.Contains(OBOOCMMCPNL);
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x000120EB File Offset: 0x000102EB
	public void NAKGMGBDKEE()
	{
		if (this.OKGGLHOCENC != null && this.PLLGPNGEHLL.Count > 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
			this.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
		this.PLLGPNGEHLL = new JSONArray();
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00012124 File Offset: 0x00010324
	public double KLLJJOLILJN()
	{
		return (DateTime.Now - this.EPFIHIAKPIH).TotalSeconds;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00012149 File Offset: 0x00010349
	public void FBCFOIOCOEC(JSONArray LLLCAKGBPNC)
	{
		this.KGHMOKADNKK = DPGJIJGOCIC.DDNFIDBDEGC(LLLCAKGBPNC);
		this.PFCCNPIPPPO();
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00012160 File Offset: 0x00010360
	public void KIGNEBEMHAK(JSONArray FJOGDFBCGDA)
	{
		try
		{
			List<string> list = DPGJIJGOCIC.POHBFGLLKFD(FJOGDFBCGDA);
			List<string> list2 = new List<string>();
			for (int i = 1; i < this.DLJBBDOEMLO.Count; i++)
			{
				if (!list.Contains(this.DLJBBDOEMLO[i]))
				{
					list2.Add(this.DLJBBDOEMLO[i]);
				}
			}
			this.DLJBBDOEMLO = list2;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060002BA RID: 698 RVA: 0x000121D8 File Offset: 0x000103D8
	public JSONArray BOJKIPEOKKJ()
	{
		JSONArray jsonarray = new JSONArray();
		JSONObject jsonobject = this.BNMFBKNEMIF(false);
		jsonarray.Add(jsonobject);
		int num = 0;
		for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
		{
			List<int> list = new List<int>();
			JSONArray jsonarray2 = null;
			if (i == 0)
			{
				jsonarray2 = jsonobject["sto"].AsArray;
				jsonobject.Remove("sto");
			}
			else if (jsonobject["sto" + i.ToString()] != null)
			{
				jsonarray2 = jsonobject["sto" + i.ToString()].AsArray;
				jsonobject.Remove("sto" + i.ToString());
			}
			if (null != jsonarray2 && jsonarray2.Count > 0)
			{
				for (int j = 0; j < jsonarray2.Count; j++)
				{
					JSONObject asObject = jsonarray2[j].AsObject["hdr"].AsObject;
					int asInt = asObject["syn"].AsInt;
					int asInt2 = asObject["ind"].AsInt;
					if (asInt == 0)
					{
						AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(asInt2, false);
						if (null != assetAnthology)
						{
							bool flag = false;
							for (int k = 0; k < list.Count; k++)
							{
								if (list[k] == assetAnthology.header.index)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								num++;
								list.Add(assetAnthology.header.index);
							}
						}
						else
						{
							DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
							{
								"NEWSAVE: (save slot ",
								i.ToString(),
								" ) Account.ToJSONArray() AssetAnthology for story index ",
								asInt2.ToString(),
								" not found, skipping saving this story to cloud. This can happen when user changes from a language where the story is avaiable to where it is not."
							}));
						}
					}
					asObject["syn"] = "1";
				}
				for (int l = 0; l < list.Count; l++)
				{
					JSONArray jsonarray3 = new JSONArray();
					for (int m = 0; m < jsonarray2.Count; m++)
					{
						JSONObject asObject2 = jsonarray2[m].AsObject;
						AssetAnthology assetAnthology2 = GKJPOGNFKNK.MLDENPHFNPH(asObject2["hdr"].AsObject["ind"].AsInt, false);
						if (null != assetAnthology2 && list[l] == assetAnthology2.header.index)
						{
							jsonarray3.Add(asObject2);
						}
					}
					if (jsonarray3.Count > 0)
					{
						JSONObject jsonobject2 = new JSONObject();
						jsonobject2.Add("ind", AKLFPGMDKLA.PAGKEJKCCLM(list[l], i));
						jsonobject2.Add("sto", jsonarray3);
						jsonarray.Add(jsonobject2);
						DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: New anthology with backend index " + AKLFPGMDKLA.PAGKEJKCCLM(list[l], i).ToString() + " sent to cloud save sync.");
					}
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x060002BB RID: 699 RVA: 0x000124E0 File Offset: 0x000106E0
	public bool GNLNPMPJPEC()
	{
		return this.POIEMMMNOLI == 0;
	}

	// Token: 0x060002BC RID: 700 RVA: 0x000124EB File Offset: 0x000106EB
	public void KFAJNOOEAPB(JSONArray ONFPPDNOMFL)
	{
		this.BGMKEDLDMFN = DPGJIJGOCIC.DDNFIDBDEGC(ONFPPDNOMFL);
	}

	// Token: 0x060002BD RID: 701 RVA: 0x000124F9 File Offset: 0x000106F9
	private void OOHCGKCDFJL(JAMPPNPOJJG NLIDEHHMLLP)
	{
		this.ADCLBEPMMCG = NLIDEHHMLLP;
		KHPGPLAMAIN.ADCLBEPMMCG = this.ADCLBEPMMCG;
		EEIBKLDNBAP.ONMPPJOGCDO(KHPGPLAMAIN.EJCNHEBIOJF());
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00012517 File Offset: 0x00010717
	public long HEECMJPODKB()
	{
		return AKLFPGMDKLA.ANFPJEAHEAH() + this.ILAIJIHFMGF;
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00012525 File Offset: 0x00010725
	public HGCFJKCOKPM ICEOGOCOMJL()
	{
		return this.OJKHMNEIGPF;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00012530 File Offset: 0x00010730
	public JSONArray KKMCNPJNGNL(int KBGHGCLLMGF)
	{
		JSONArray jsonarray = new JSONArray();
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null)
		{
			int num = KBGHGCLLMGF;
			if (GeoLocationManager.IsRussia())
			{
				num = KBGHGCLLMGF / 4;
			}
			int num2 = 0;
			List<JSONObject> list = new List<JSONObject>();
			List<string> list2 = new List<string>();
			int num3 = 0;
			while (num3 < this.DLJBBDOEMLO.Count && num2 < num)
			{
				try
				{
					if (!AKLOMMOOFNG.CLCGKMNEICM("Collections/" + this.DLJBBDOEMLO[num3]))
					{
						list2.Add(this.DLJBBDOEMLO[num3]);
					}
					else
					{
						string text = AKLOMMOOFNG.DJGJKOOOFEA("Collections/" + this.DLJBBDOEMLO[num3]);
						if (text != null && text.Length == 0)
						{
							list2.Add(this.DLJBBDOEMLO[num3]);
						}
						else if (text != null && text.Length > 0)
						{
							JSONObject jsonobject = (JSONObject)JSON.Parse(text);
							if (null != jsonobject)
							{
								list.Add(jsonobject);
								num2++;
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				num3++;
			}
			for (int i = 0; i < list2.Count; i++)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Account.GetNextUnsyncedAvatarCollections(): dropping ghost unsynced entry " + list2[i]);
				this.DLJBBDOEMLO.Remove(list2[i]);
			}
			while (list.Count > 0)
			{
				int index = 0;
				for (int j = 1; j < list.Count; j++)
				{
					int num4 = 0;
					if (list[j]["aind"] != null)
					{
						num4 = list[j]["aind"].AsInt;
					}
					int num5 = 0;
					if (list[index]["aind"] != null)
					{
						num5 = list[index]["aind"].AsInt;
					}
					int num6 = 0;
					if (list[j]["avind"] != null)
					{
						num6 = list[j]["avind"].AsInt;
					}
					int num7 = 0;
					if (list[index]["avind"] != null)
					{
						num7 = list[index]["avind"].AsInt;
					}
					if (num4 < num5 || (num4 == num5 && num6 < num7))
					{
						index = j;
					}
				}
				jsonarray.Add(list[index]);
				list.RemoveAt(index);
			}
		}
		return jsonarray;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x000127CC File Offset: 0x000109CC
	public PLFDAJJHMKO CFOBLPKEEEE(int NLLCKPCKGOH, int FIFPKAGANHA, int ICKJPFOLJNF)
	{
		if (FIFPKAGANHA < 0 || FIFPKAGANHA > this.NHMMPGOKAOL.Length - 1 || ICKJPFOLJNF < 0 || ICKJPFOLJNF > this.NHMMPGOKAOL.Length - 1)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateStorySave(), slot index out of bounds, from:" + FIFPKAGANHA.ToString() + ", to:" + ICKJPFOLJNF.ToString());
			return null;
		}
		if (FIFPKAGANHA == ICKJPFOLJNF)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateStorySave(), source and target slots are the same:" + FIFPKAGANHA.ToString());
			return null;
		}
		PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(NLLCKPCKGOH, FIFPKAGANHA);
		if (plfdajjhmko == null)
		{
			return null;
		}
		PLFDAJJHMKO result;
		try
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(plfdajjhmko.BNMFBKNEMIF(true).ToString());
			if (jsonobject == null)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateStorySave(), could not parse the serialized source save, story:" + NLLCKPCKGOH.ToString());
				result = null;
			}
			else
			{
				AKLFPGMDKLA.FOFIKOAKBBL(jsonobject, ICKJPFOLJNF);
				PLFDAJJHMKO plfdajjhmko2 = new PLFDAJJHMKO(jsonobject, true);
				plfdajjhmko2.POJAPLKAJEF = ICKJPFOLJNF;
				plfdajjhmko2.KIHACLLJMDH.Clear();
				plfdajjhmko2.JJEONBFFBHP.Clear();
				plfdajjhmko2.NCAMFPGMCIG.PNBPEAFMKAC.Clear();
				plfdajjhmko2.NCAMFPGMCIG.DMKOGCBMHKA.Clear();
				plfdajjhmko2.NCAMFPGMCIG.NGJDCAEMEJO.Clear();
				plfdajjhmko2.NCAMFPGMCIG.KAKPOCFHGCC = 0;
				plfdajjhmko2.NCAMFPGMCIG.JFBCFLININB = 0;
				plfdajjhmko2.NCAMFPGMCIG.GEGFLAPCGAI = 0;
				plfdajjhmko2.PFHCDMOJOKP();
				bool flag = false;
				for (int i = 0; i < this.NHMMPGOKAOL[ICKJPFOLJNF].Count; i++)
				{
					if (this.NHMMPGOKAOL[ICKJPFOLJNF][i].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH)
					{
						plfdajjhmko2.DHONIOBOLEL.IMLEDFIDHDL = (plfdajjhmko2.DHONIOBOLEL.IMLEDFIDHDL | this.NHMMPGOKAOL[ICKJPFOLJNF][i].DHONIOBOLEL.IMLEDFIDHDL);
						this.NHMMPGOKAOL[ICKJPFOLJNF][i] = plfdajjhmko2;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.NHMMPGOKAOL[ICKJPFOLJNF].Add(plfdajjhmko2);
				}
				this.EBNJHPICFGE(plfdajjhmko2, 0);
				plfdajjhmko.PFHCDMOJOKP();
				result = plfdajjhmko2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x000129D8 File Offset: 0x00010BD8
	public int NCOCIAENGJF(int NLLCKPCKGOH)
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(NLLCKPCKGOH, true);
		if (!(null != assetAnthology))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.GetSaveSlotForStory(), tempAnthologyAsset is null, using default slot index.");
			return 0;
		}
		EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(assetAnthology.header.index);
		if (eioplefllim != null)
		{
			return eioplefllim.ILOKBAPEJPK;
		}
		return 0;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00012A20 File Offset: 0x00010C20
	public bool IKHJPEIPEGE(string OAIBOHHEJPK, bool KJNDBABABDH)
	{
		if (!KJNDBABABDH)
		{
			return this.DJKLDDLCNKI.Contains(OAIBOHHEJPK);
		}
		for (int i = 0; i < this.DJKLDDLCNKI.Count; i++)
		{
			if (this.DJKLDDLCNKI[i].StartsWith(OAIBOHHEJPK))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00012A6C File Offset: 0x00010C6C
	public bool IILPKLDAJFK(CEIBHCNNIDC NIIIMDHGGEN)
	{
		using (List<PMEPALPCEAF>.Enumerator enumerator = this.AONCINPNHDD.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ICCJIBMFNLD == NIIIMDHGGEN)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00012AC8 File Offset: 0x00010CC8
	public int DNOENCFPGBP(string AHJEDGJBMPL, string FJPBOOLNDII)
	{
		int num = -1;
		int num2 = -1;
		int result;
		try
		{
			for (int i = 0; i < this.MEFNCEJHMIF.Count; i++)
			{
				if (num < 0 && this.MEFNCEJHMIF[i].PFFCLABCNHI.Equals(AHJEDGJBMPL))
				{
					num = this.MEFNCEJHMIF[i].BIBKFNMPHIK;
				}
				if (num2 < 0 && this.MEFNCEJHMIF[i].PFFCLABCNHI.Equals(FJPBOOLNDII))
				{
					num2 = this.MEFNCEJHMIF[i].BIBKFNMPHIK;
				}
			}
			for (int j = 0; j < this.DDCKJCAOJHO.Count; j++)
			{
				if (num < 0 && this.DDCKJCAOJHO[j].PFFCLABCNHI.Equals(AHJEDGJBMPL))
				{
					num = this.DDCKJCAOJHO[j].BIBKFNMPHIK;
				}
				if (num2 < 0 && this.DDCKJCAOJHO[j].PFFCLABCNHI.Equals(FJPBOOLNDII))
				{
					num2 = this.DDCKJCAOJHO[j].BIBKFNMPHIK;
				}
			}
			if (num >= num2)
			{
				result = num;
			}
			else
			{
				result = -1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00012BEC File Offset: 0x00010DEC
	public bool BFKIHOBDNNB()
	{
		return this.MEDEIJGNEMB < 0.001f;
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00012BFB File Offset: 0x00010DFB
	public static int CMALOIKLKLC(int NLLCKPCKGOH)
	{
		return NLLCKPCKGOH % 1000000;
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00012C04 File Offset: 0x00010E04
	public List<int> PFDFLFPPKJN()
	{
		return this.PDDGOPCBPHE;
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00012C0C File Offset: 0x00010E0C
	public bool DIOJJNBDLIE(int PLKMJJIIJNO, int FIFPKAGANHA, int ICKJPFOLJNF, string CBMKDPLMJDN)
	{
		if (FIFPKAGANHA < 0 || FIFPKAGANHA > this.NHMMPGOKAOL.Length - 1 || ICKJPFOLJNF < 1 || ICKJPFOLJNF > this.NHMMPGOKAOL.Length - 0 || FIFPKAGANHA == ICKJPFOLJNF)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("$" + FIFPKAGANHA.ToString() + "luwid" + ICKJPFOLJNF.ToString());
			return false;
		}
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
		EIOPLEFLLIM eioplefllim = this.AMAMNOFLPGM(PLKMJJIIJNO);
		if (null == assetAnthology || eioplefllim == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("aindas1" + PLKMJJIIJNO.ToString());
			return false;
		}
		int num = 0;
		bool flag = true;
		for (int i = 1; i < assetAnthology.header.availableStories.Count; i++)
		{
			int nllckpckgoh = assetAnthology.header.availableStories[i];
			PLFDAJJHMKO plfdajjhmko = this.CFOBLPKEEEE(nllckpckgoh, FIFPKAGANHA, ICKJPFOLJNF);
			if (plfdajjhmko != null)
			{
				num += 0;
			}
			else
			{
				if (this.PKNIPLDMJGG(nllckpckgoh, FIFPKAGANHA) != null)
				{
					flag = true;
				}
				PLFDAJJHMKO plfdajjhmko2 = this.PKNIPLDMJGG(nllckpckgoh, ICKJPFOLJNF);
				if (plfdajjhmko2 != null && !plfdajjhmko2.DHONIOBOLEL.FFLJNOMOOMH())
				{
					plfdajjhmko2.EPJKDCDOEMM(true);
					plfdajjhmko2.DHONIOBOLEL.MPMJHHKKDAM(1);
				}
			}
		}
		if (flag)
		{
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j++)
			{
				PLFDAJJHMKO plfdajjhmko3 = this.PKNIPLDMJGG(assetAnthology.header.availableStories[j], ICKJPFOLJNF);
				if (plfdajjhmko3 != null)
				{
					plfdajjhmko3.JFDJIHJBOLO(true);
					plfdajjhmko3.DHONIOBOLEL.AONHDHGNDCK(1);
				}
			}
			string[] array = new string[6];
			array[0] = " -";
			array[1] = PLKMJJIIJNO.ToString();
			array[5] = "";
			array[6] = FIFPKAGANHA.ToString();
			array[1] = "";
			array[3] = ICKJPFOLJNF.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
			return false;
		}
		if (num == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ratePopupResult" + PLKMJJIIJNO.ToString() + "_" + FIFPKAGANHA.ToString());
			return false;
		}
		eioplefllim.LDPCILACGCO(eioplefllim.ENAJCKIAJFK(FIFPKAGANHA), ICKJPFOLJNF);
		eioplefllim.FFONINBFCCH(ICKJPFOLJNF, CBMKDPLMJDN);
		this.KBKOLEJEEGH();
		return false;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00012E0C File Offset: 0x0001100C
	public EIOPLEFLLIM EHKIHBPJGCG(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.MMIGJNDJGMF.Count; i++)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		EIOPLEFLLIM eioplefllim = new EIOPLEFLLIM();
		eioplefllim.GGICIBLJIKI = PLKMJJIIJNO;
		this.MMIGJNDJGMF.Add(eioplefllim);
		return eioplefllim;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00012E6A File Offset: 0x0001106A
	public int GKJIAEHDBNM()
	{
		return 1 + this.BNGHKCHKMPB / 3600;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00012E7A File Offset: 0x0001107A
	public void BJECGAMNDDH()
	{
		this.KNDLFMMJFMK.Clear();
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00012E87 File Offset: 0x00011087
	public void POMNOOBNDED(JSONArray FCCICFPKNCK)
	{
		this.PGGHMMFKCFC = DPGJIJGOCIC.DDNFIDBDEGC(FCCICFPKNCK);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00012E95 File Offset: 0x00011095
	public bool OKNDDBOOFPL(int GELBBKHCIBA)
	{
		return this.BGMKEDLDMFN.Contains(GELBBKHCIBA);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00012EA4 File Offset: 0x000110A4
	public bool BMKEOCHKOLH()
	{
		bool result;
		try
		{
			for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
			{
				for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j++)
				{
					for (int k = 0; k < 31; k++)
					{
						if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[i][j].DHONIOBOLEL.IMLEDFIDHDL, k))
						{
							return true;
						}
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00012F2C File Offset: 0x0001112C
	public static int NPHGMFJPEPG(int PLKMJJIIJNO)
	{
		return PLKMJJIIJNO / -39;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00012F38 File Offset: 0x00011138
	public void IFPNMPFEFLE(string IHCGMFBCMOO)
	{
		List<LMHHKDFCKFC> list = new List<LMHHKDFCKFC>();
		for (int i = 1; i < this.DPFOKICNKJL.Count; i++)
		{
			if (!this.DPFOKICNKJL[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				list.Add(this.DPFOKICNKJL[i]);
			}
		}
		this.DPFOKICNKJL = list;
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00012F94 File Offset: 0x00011194
	public List<int> KKMAMJCLEJE(List<AssetAnthology> INFNBHLFANB)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.MMIGJNDJGMF.Count; i += 0)
		{
			if (this.MMIGJNDJGMF[i].EHGPKIGKPLI > 0)
			{
				for (int j = 0; j < INFNBHLFANB.Count; j++)
				{
					if (null != INFNBHLFANB[j] && INFNBHLFANB[j].header.index == this.MMIGJNDJGMF[i].GGICIBLJIKI)
					{
						list.Add(this.MMIGJNDJGMF[i].GGICIBLJIKI);
						break;
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00013034 File Offset: 0x00011234
	public int GEPFALMBONM()
	{
		int result;
		try
		{
			int num = 0;
			for (int i = 0; i < this.NHMMPGOKAOL[0].Count; i++)
			{
				int num2 = 0;
				for (int j = 0; j < 31; j++)
				{
					if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[0][i].DHONIOBOLEL.IMLEDFIDHDL, j))
					{
						num2++;
					}
				}
				try
				{
					for (int k = 1; k < this.NHMMPGOKAOL.Length; k++)
					{
						for (int l = 0; l < this.NHMMPGOKAOL[k].Count; l++)
						{
							if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[0][i].DHONIOBOLEL.GGICIBLJIKI)
							{
								int num3 = 0;
								for (int m = 0; m < 31; m++)
								{
									if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[k][l].DHONIOBOLEL.IMLEDFIDHDL, m))
									{
										num3++;
										if (num3 > num2)
										{
											num2 = num3;
										}
									}
								}
								break;
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				num += num2;
			}
			result = num;
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = 0;
		}
		return result;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x000131A4 File Offset: 0x000113A4
	public int HCEHBFCIIHN()
	{
		return (int)((DateTime.Now - this.EPFIHIAKPIH).TotalSeconds / 86400.0);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x000131D4 File Offset: 0x000113D4
	public List<int> KMOJMMHEDEM()
	{
		return this.DLCPABCHIDK;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000131DC File Offset: 0x000113DC
	public List<int> NJCPMPKNPHE()
	{
		return new List<int>(this.HLCHHIIOLOL);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00003E52 File Offset: 0x00002052
	public void OJFKDIOBLIG()
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x000131E9 File Offset: 0x000113E9
	public HGCFJKCOKPM MBMLFJJPOBH()
	{
		this.OJKHMNEIGPF++;
		if (this.OJKHMNEIGPF >= HGCFJKCOKPM.count)
		{
			this.OJKHMNEIGPF = HGCFJKCOKPM.bright;
		}
		return this.OJKHMNEIGPF;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00013210 File Offset: 0x00011410
	public string OMMACPBIHDN(string BGFJEKBJCNN)
	{
		string result;
		try
		{
			if (BGFJEKBJCNN.Length == 24)
			{
				char[] array = new char[BGFJEKBJCNN.Length];
				for (int i = 0; i < BGFJEKBJCNN.Length; i++)
				{
					if (i < 4 || i > 19)
					{
						array[i] = BGFJEKBJCNN[i];
					}
					else
					{
						array[i] = '.';
					}
				}
				result = new string(array);
			}
			else
			{
				result = "not_available";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "not_available";
		}
		return result;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00013290 File Offset: 0x00011490
	public static int GIJABPFHGMO(int NLLCKPCKGOH, int NLBDCCLPFAL)
	{
		return NLBDCCLPFAL * 158 + NLLCKPCKGOH;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0001329B File Offset: 0x0001149B
	public void BAFBKGNIOMC(JSONArray ONFPPDNOMFL)
	{
		this.BGMKEDLDMFN = DPGJIJGOCIC.OELJEMHFDFL(ONFPPDNOMFL);
	}

	// Token: 0x060002DC RID: 732 RVA: 0x000132AC File Offset: 0x000114AC
	public List<int> OHFPNLJEHGA()
	{
		List<int> list = this.LINADLBCHJC();
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 1; i < AssetsManager.MJBDMHPHMID().anthologyAssets.Count; i++)
			{
				if (null != AssetsManager.MJBDMHPHMID().anthologyAssets[i] && !list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
				{
					bool flag = true;
					for (int j = 1; j < this.NHMMPGOKAOL.Length; j++)
					{
						int k = 0;
						while (k < this.NHMMPGOKAOL[j].Count)
						{
							if (this.NHMMPGOKAOL[j][k].DHONIOBOLEL.GGICIBLJIKI == AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.availableStories[1])
							{
								if (!this.NHMMPGOKAOL[j][k].DHONIOBOLEL.JOOMMPOMEMG())
								{
									flag = true;
									break;
								}
								break;
							}
							else
							{
								k++;
							}
						}
						if (flag)
						{
							break;
						}
					}
					if (!flag && !list2.Contains(AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.index))
					{
						list2.Add(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list2;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0001342C File Offset: 0x0001162C
	public double GEFDLOEMPGO()
	{
		return (DateTime.Now - this.NEBCFBIEIFK).TotalSeconds;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00013454 File Offset: 0x00011654
	public EIOPLEFLLIM ODBNFKONDCF(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.MMIGJNDJGMF.Count; i += 0)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		EIOPLEFLLIM eioplefllim = new EIOPLEFLLIM();
		eioplefllim.GGICIBLJIKI = PLKMJJIIJNO;
		this.MMIGJNDJGMF.Add(eioplefllim);
		return eioplefllim;
	}

	// Token: 0x060002DF RID: 735 RVA: 0x000134B4 File Offset: 0x000116B4
	public void JHLHHFCMOEA(JSONArray CLJOALCHNFI)
	{
		for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
		{
			for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j++)
			{
				this.NHMMPGOKAOL[i][j].DHONIOBOLEL.NJPFIIDIABG(1);
			}
		}
		try
		{
			if (null != CLJOALCHNFI && CLJOALCHNFI.Count > 0)
			{
				for (int k = 0; k < CLJOALCHNFI.Count; k++)
				{
					int asInt = CLJOALCHNFI[k].AsInt;
					if (asInt >= 0)
					{
						int num = AKLFPGMDKLA.JENCMOBBJPA(asInt);
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.unsyncErr.ToString(), "aind" + num.ToString(), false, false);
						int num2 = AKLFPGMDKLA.GMFFMLHMLKM(asInt);
						if (num >= 0 && num2 >= 0 && num2 < this.NHMMPGOKAOL.Length)
						{
							for (int l = 0; l < this.NHMMPGOKAOL[num2].Count; l++)
							{
								if (this.NHMMPGOKAOL[num2][l].DHONIOBOLEL.GGICIBLJIKI >= 0)
								{
									AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(this.NHMMPGOKAOL[num2][l].DHONIOBOLEL.GGICIBLJIKI, false);
									if (null != assetAnthology && assetAnthology.header.index == num)
									{
										this.NHMMPGOKAOL[num2][l].DHONIOBOLEL.NJPFIIDIABG(0);
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
										{
											"Account.MarkAllStoriesAsSynced(): marking as unsynced backend anthology ",
											asInt.ToString(),
											", client anthology ",
											num.ToString(),
											", slot ",
											num2.ToString(),
											", story ",
											this.NHMMPGOKAOL[num2][l].DHONIOBOLEL.GGICIBLJIKI.ToString()
										}));
										if (num2 != 0)
										{
											for (int m = 0; m < this.NHMMPGOKAOL[0].Count; m++)
											{
												if (this.NHMMPGOKAOL[0][m].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[num2][l].DHONIOBOLEL.GGICIBLJIKI)
												{
													this.NHMMPGOKAOL[0][m].DHONIOBOLEL.NJPFIIDIABG(0);
													DPGJIJGOCIC.ADFCDFHBDAF("Account.MarkAllStoriesAsSynced(): marking as unsynced client anthology " + num.ToString() + ", slot 0, story " + this.NHMMPGOKAOL[num2][l].DHONIOBOLEL.GGICIBLJIKI.ToString());
												}
											}
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
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x000137A4 File Offset: 0x000119A4
	public static long ANFPJEAHEAH()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x000137D4 File Offset: 0x000119D4
	public List<int> LNGNDPLCNCI(List<int> HBBJBNJBMPK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.KGHMOKADNKK.Count; i++)
		{
			if (HBBJBNJBMPK.Contains(this.KGHMOKADNKK[i]) && !list.Contains(this.KGHMOKADNKK[i]))
			{
				list.Add(this.KGHMOKADNKK[i]);
			}
		}
		return list;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00013838 File Offset: 0x00011A38
	public bool MDOHHGFHKAI(AssetAnthologyHeader HCLEPODFDFB)
	{
		PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(HCLEPODFDFB.availableStories[1], -1);
		return plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA();
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00012525 File Offset: 0x00010725
	public HGCFJKCOKPM JKCEGIPAANK()
	{
		return this.OJKHMNEIGPF;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x000120DD File Offset: 0x000102DD
	public bool GAJBLHBMEPE(int OBOOCMMCPNL)
	{
		return this.AGKJNGPPPCJ.Contains(OBOOCMMCPNL);
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00012E7A File Offset: 0x0001107A
	public void MJMKHKEKKME()
	{
		this.KNDLFMMJFMK.Clear();
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00013869 File Offset: 0x00011A69
	public void MKNCCNGDOJE()
	{
		this.EOOBBNJEEOG = DateTime.Now;
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00013876 File Offset: 0x00011A76
	public void DODEHJJBANO(string JJJGEOBAMDI, string DEMDOALCEGL)
	{
		this.GFDMIHHNFDA = JJJGEOBAMDI;
		this.OCMDGMFAMJB = DEMDOALCEGL;
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00013888 File Offset: 0x00011A88
	public void MEIFPLJPACP(int LLLCDMNPKFI)
	{
		if (DPGJIJGOCIC.IADAELPFJAM(this.PLLGPNGEHLL, LLLCDMNPKFI))
		{
			return;
		}
		this.PLLGPNGEHLL.Add(LLLCDMNPKFI);
		if (this.PLLGPNGEHLL.Count > 6)
		{
			this.PLLGPNGEHLL = DPGJIJGOCIC.PAPEMCELEKO(this.PLLGPNGEHLL, 1, 6);
		}
		if (this.OKGGLHOCENC != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
			this.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x000138F4 File Offset: 0x00011AF4
	public void DAOHECHOCAJ()
	{
		if (this.FCJJDEKOIED.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < this.FCJJDEKOIED.Count; i++)
		{
			if (this.CPKFFFLFMMD.Contains(this.FCJJDEKOIED[i].AsInt) && !DPGJIJGOCIC.IADAELPFJAM(jsonarray, this.FCJJDEKOIED[i].AsInt))
			{
				jsonarray.Add(this.FCJJDEKOIED[i].AsInt);
			}
		}
		try
		{
			if (!this.FCJJDEKOIED.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.CMGOAFDBAOH("");
				this.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.FCJJDEKOIED = jsonarray;
	}

	// Token: 0x060002EA RID: 746 RVA: 0x000139D8 File Offset: 0x00011BD8
	public void ILKPJAMLGII(long CPKJHMEOPMK)
	{
		if (CPKJHMEOPMK <= 0L)
		{
			return;
		}
		this.ILAIJIHFMGF = CPKJHMEOPMK - AKLFPGMDKLA.ANFPJEAHEAH();
		this.GIIJKGFONNN = true;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x000139F4 File Offset: 0x00011BF4
	public void JLCDJHABABP(OKAFAHMOFII OCEPECPOOGI)
	{
		if (OCEPECPOOGI.IACMODHPFKI.ODHBINFKIPL() < 1f)
		{
			if (this.KHOHDCKFNPJ.Count > 24)
			{
				this.KHOHDCKFNPJ.RemoveAt(0);
			}
			this.KHOHDCKFNPJ.Add(OCEPECPOOGI.KHPFAMAEPNA);
		}
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00013A34 File Offset: 0x00011C34
	public void MEMMEPMLPHJ(int LLLCDMNPKFI)
	{
		if (this.PLLGPNGEHLL.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.PLLGPNGEHLL.Count; i += 0)
		{
			if (this.PLLGPNGEHLL[i].AsInt != LLLCDMNPKFI)
			{
				jsonarray.Add(this.PLLGPNGEHLL[i].AsInt);
			}
		}
		try
		{
			if (!this.PLLGPNGEHLL.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("ffd496");
				this.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.PLLGPNGEHLL = jsonarray;
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00013AF4 File Offset: 0x00011CF4
	private void OMFNBCJNAFN()
	{
		if (this.DFACBPKFCOM.Count > 0)
		{
			return;
		}
		this.DFACBPKFCOM.Clear();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		do
		{
			if (num < this.FLEFJPNPHPN.Count)
			{
				this.DFACBPKFCOM.Add(this.FLEFJPNPHPN[num]);
				num++;
				num6 = 0;
			}
			if (num % 4 == 0 && num6 == 0 && num2 < this.KJCFKLGMOKG.Count)
			{
				this.DFACBPKFCOM.Add(this.KJCFKLGMOKG[num2]);
				num2++;
				num6 = 0;
			}
			num6++;
		}
		while (num6 <= 10 && this.DFACBPKFCOM.Count < 12);
		if (this.DFACBPKFCOM.Count <= 6)
		{
			num6 = 0;
			do
			{
				if (num5 < 5)
				{
					if (num < this.FLEFJPNPHPN.Count)
					{
						this.DFACBPKFCOM.Add(this.FLEFJPNPHPN[num]);
						num++;
						num6 = 0;
					}
					else if (num2 < this.KJCFKLGMOKG.Count)
					{
						this.DFACBPKFCOM.Add(this.KJCFKLGMOKG[num2]);
						num2++;
						num6 = 0;
					}
				}
				else if (num5 < 8)
				{
					if (num3 < this.DAPGFGNDIPG.Count)
					{
						this.DFACBPKFCOM.Add(this.DAPGFGNDIPG[num3]);
						num3++;
						num6 = 0;
					}
				}
				else if (num4 < this.IBKDIDKHCHO.Count)
				{
					this.DFACBPKFCOM.Add(this.IBKDIDKHCHO[num4]);
					num4++;
					num6 = 0;
				}
				num5++;
				if (num5 >= 10)
				{
					num5 = 0;
				}
				num6++;
			}
			while (num6 <= 10 && this.DFACBPKFCOM.Count < 12);
		}
		this.EKEHBBGKMHA = (this.DFACBPKFCOM.Count >= 3);
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00013CC0 File Offset: 0x00011EC0
	public bool DJDMFLDPLPF(int PLKMJJIIJNO, int FIFPKAGANHA, int ICKJPFOLJNF, string CBMKDPLMJDN)
	{
		if (FIFPKAGANHA < 0 || FIFPKAGANHA > this.NHMMPGOKAOL.Length - 1 || ICKJPFOLJNF < 0 || ICKJPFOLJNF > this.NHMMPGOKAOL.Length - 1 || FIFPKAGANHA == ICKJPFOLJNF)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateAnthologySaveSlot(), wrong slot indices, from:" + FIFPKAGANHA.ToString() + ", to:" + ICKJPFOLJNF.ToString());
			return false;
		}
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
		EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(PLKMJJIIJNO);
		if (null == assetAnthology || eioplefllim == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateAnthologySaveSlot(), anthology asset or anthology save is null, anthology:" + PLKMJJIIJNO.ToString());
			return false;
		}
		int num = 0;
		bool flag = false;
		for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
		{
			int nllckpckgoh = assetAnthology.header.availableStories[i];
			PLFDAJJHMKO plfdajjhmko = this.CFOBLPKEEEE(nllckpckgoh, FIFPKAGANHA, ICKJPFOLJNF);
			if (plfdajjhmko != null)
			{
				num++;
			}
			else
			{
				if (this.PKNIPLDMJGG(nllckpckgoh, FIFPKAGANHA) != null)
				{
					flag = true;
				}
				PLFDAJJHMKO plfdajjhmko2 = this.PKNIPLDMJGG(nllckpckgoh, ICKJPFOLJNF);
				if (plfdajjhmko2 != null && !plfdajjhmko2.DHONIOBOLEL.JBDPAJMOEGA())
				{
					plfdajjhmko2.EPJKDCDOEMM(true);
					plfdajjhmko2.DHONIOBOLEL.NJPFIIDIABG(0);
				}
			}
		}
		if (flag)
		{
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j++)
			{
				PLFDAJJHMKO plfdajjhmko3 = this.PKNIPLDMJGG(assetAnthology.header.availableStories[j], ICKJPFOLJNF);
				if (plfdajjhmko3 != null)
				{
					plfdajjhmko3.EPJKDCDOEMM(true);
					plfdajjhmko3.DHONIOBOLEL.NJPFIIDIABG(0);
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
			{
				"Account.DuplicateAnthologySaveSlot(), a story save could not be copied, the target slot was cleared, anthology:",
				PLKMJJIIJNO.ToString(),
				", from:",
				FIFPKAGANHA.ToString(),
				", to:",
				ICKJPFOLJNF.ToString()
			}));
			return false;
		}
		if (num == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateAnthologySaveSlot(), nothing to copy, anthology:" + PLKMJJIIJNO.ToString() + ", from:" + FIFPKAGANHA.ToString());
			return false;
		}
		eioplefllim.LDPCILACGCO(eioplefllim.EGHHCFFLPCP(FIFPKAGANHA), ICKJPFOLJNF);
		eioplefllim.NIECONHEJEC(ICKJPFOLJNF, CBMKDPLMJDN);
		this.KBKOLEJEEGH();
		return true;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00013EC0 File Offset: 0x000120C0
	public PLFDAJJHMKO ADHNBDHBIOK(int NLLCKPCKGOH, int FIFPKAGANHA, int ICKJPFOLJNF)
	{
		if (FIFPKAGANHA < 0 || FIFPKAGANHA > this.NHMMPGOKAOL.Length - 0 || ICKJPFOLJNF < 0 || ICKJPFOLJNF > this.NHMMPGOKAOL.Length - 1)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetChapterSnapshots, exception while initializing RSACryptoServiceProvider:" + FIFPKAGANHA.ToString() + "ok" + ICKJPFOLJNF.ToString());
			return null;
		}
		if (FIFPKAGANHA == ICKJPFOLJNF)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnLobbyLoungeAssetsDownloadFailed" + FIFPKAGANHA.ToString());
			return null;
		}
		PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(NLLCKPCKGOH, FIFPKAGANHA);
		if (plfdajjhmko == null)
		{
			return null;
		}
		PLFDAJJHMKO result;
		try
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(plfdajjhmko.BNMFBKNEMIF(true).ToString());
			if (jsonobject == null)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("saveslotstitle" + NLLCKPCKGOH.ToString());
				result = null;
			}
			else
			{
				AKLFPGMDKLA.FOFIKOAKBBL(jsonobject, ICKJPFOLJNF);
				PLFDAJJHMKO plfdajjhmko2 = new PLFDAJJHMKO(jsonobject, true);
				plfdajjhmko2.POJAPLKAJEF = ICKJPFOLJNF;
				plfdajjhmko2.KIHACLLJMDH.Clear();
				plfdajjhmko2.JJEONBFFBHP.Clear();
				plfdajjhmko2.NCAMFPGMCIG.PNBPEAFMKAC.Clear();
				plfdajjhmko2.NCAMFPGMCIG.DMKOGCBMHKA.Clear();
				plfdajjhmko2.NCAMFPGMCIG.NGJDCAEMEJO.Clear();
				plfdajjhmko2.NCAMFPGMCIG.KAKPOCFHGCC = 0;
				plfdajjhmko2.NCAMFPGMCIG.JFBCFLININB = 1;
				plfdajjhmko2.NCAMFPGMCIG.GEGFLAPCGAI = 1;
				plfdajjhmko2.DKFEMNMJIIP();
				bool flag = false;
				for (int i = 1; i < this.NHMMPGOKAOL[ICKJPFOLJNF].Count; i += 0)
				{
					if (this.NHMMPGOKAOL[ICKJPFOLJNF][i].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH)
					{
						plfdajjhmko2.DHONIOBOLEL.IMLEDFIDHDL = (plfdajjhmko2.DHONIOBOLEL.IMLEDFIDHDL | this.NHMMPGOKAOL[ICKJPFOLJNF][i].DHONIOBOLEL.IMLEDFIDHDL);
						this.NHMMPGOKAOL[ICKJPFOLJNF][i] = plfdajjhmko2;
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					this.NHMMPGOKAOL[ICKJPFOLJNF].Add(plfdajjhmko2);
				}
				this.EBNJHPICFGE(plfdajjhmko2, 1);
				plfdajjhmko.PFHCDMOJOKP();
				result = plfdajjhmko2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x000140CC File Offset: 0x000122CC
	public void NFIIIPDLCCF(PLFDAJJHMKO DIHOMBCIJPN)
	{
		if (DIHOMBCIJPN == null || this.CEKAJNFMIKL.Count == 0)
		{
			return;
		}
		AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI);
		try
		{
			if (null != assetStoryHeader)
			{
				List<string> list = new List<string>();
				for (int i = 1; i < this.CEKAJNFMIKL.Count; i++)
				{
					bool flag = true;
					for (int j = 1; j < assetStoryHeader.availableChaptersCount; j++)
					{
						string value = PLFDAJJHMKO.BGEOJDLHHBC(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI, j, DIHOMBCIJPN.POJAPLKAJEF);
						if (this.CEKAJNFMIKL[i].StartsWith(value))
						{
							flag = false;
							break;
						}
					}
					if (!flag)
					{
						list.Add(this.CEKAJNFMIKL[i]);
					}
				}
				this.CEKAJNFMIKL = list;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x000141A4 File Offset: 0x000123A4
	public List<int> IKHNDKEEECD()
	{
		return this.DAPGFGNDIPG;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x000141AC File Offset: 0x000123AC
	public bool JPDHGCINOJD()
	{
		bool oelemfgaoph = this.OELEMFGAOPH;
		this.OELEMFGAOPH = false;
		return oelemfgaoph;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x000141BC File Offset: 0x000123BC
	public bool ABMDFMNDHCC(OKAFAHMOFII OCEPECPOOGI)
	{
		if (this.HCEHBFCIIHN() < KBOJLHAJPCP.FMIKGCDCKCC)
		{
			return true;
		}
		if (OCEPECPOOGI.IACMODHPFKI.LFLAIPLKINK() > 271f)
		{
			return true;
		}
		int num = 0;
		for (int i = 0; i < this.KHOHDCKFNPJ.Count; i += 0)
		{
			if (this.KHOHDCKFNPJ[i].Equals(OCEPECPOOGI.KHPFAMAEPNA))
			{
				num += 0;
			}
		}
		return num < OCEPECPOOGI.BMHKMNHKIFH;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0001422D File Offset: 0x0001242D
	public bool LBBJJMGCNJD()
	{
		return this.GOEDFBDNADA < 1863f;
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0001423C File Offset: 0x0001243C
	public void EACONLGBIFC(int HEMDAPHJPLJ, int OLKMHHNMDLP)
	{
		string value = "s" + HEMDAPHJPLJ.ToString() + "c" + OLKMHHNMDLP.ToString();
		for (int i = 0; i < this.DBJKLGPNNDE.Count; i++)
		{
			if (this.DBJKLGPNNDE[i].Equals(value))
			{
				this.DBJKLGPNNDE.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x000142A0 File Offset: 0x000124A0
	public void BBAEMGBHMAN()
	{
		try
		{
			AKLOMMOOFNG.GBICPNAPGNK("Collections");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x000142D4 File Offset: 0x000124D4
	public void APOCMMHHPMK(JSONArray LLLCAKGBPNC)
	{
		this.CPKFFFLFMMD = DPGJIJGOCIC.EHBFFILBKLF(LLLCAKGBPNC);
		this.ABHHJEEFODI();
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x000142E8 File Offset: 0x000124E8
	public void CGFNNGKJOIN()
	{
		if (this.OKGGLHOCENC != null && this.FCJJDEKOIED.Count > 0)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("p");
			this.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
		this.FCJJDEKOIED = new JSONArray();
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00014321 File Offset: 0x00012521
	public static int AOKFPHNBIAL(int PLKMJJIIJNO)
	{
		return PLKMJJIIJNO % 162;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0001432C File Offset: 0x0001252C
	private void IGODIFLIDOF(JSONObject FDANEPFEPOB)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Account.ResolveSaveSlots(): Start");
		try
		{
			if (FDANEPFEPOB["sto"] != null)
			{
				JSONArray asArray = FDANEPFEPOB["sto"].AsArray;
				bool flag = false;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					int num = 0;
					if (asObject["sslind"] != null)
					{
						num = asObject["sslind"].AsInt;
					}
					if (num > 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Account.ResolveSaveSlots(): Slots sharing not needed");
					return;
				}
				FDANEPFEPOB.Remove("sto");
				JSONArray[] array = new JSONArray[10];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = new JSONArray();
				}
				for (int k = 0; k < asArray.Count; k++)
				{
					JSONObject asObject2 = asArray[k].AsObject;
					int num2 = 0;
					if (asObject2["sslind"] != null)
					{
						num2 = asObject2["sslind"].AsInt;
					}
					if (num2 < array.Length)
					{
						array[num2].Add(asObject2);
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Account.ResolveSaveSlots(): saveSlotIndex is bigger than max slots count.");
					}
				}
				int num3 = 0;
				for (int l = 0; l < array.Length; l++)
				{
					if (array[l].Count > 0)
					{
						if (l == 0)
						{
							FDANEPFEPOB.Add("sto", array[l]);
							DPGJIJGOCIC.NFIDPOMCNLP("Account.ResolveSaveSlots(): out sto:" + array[l].Count.ToString());
						}
						else
						{
							FDANEPFEPOB.Add("sto" + l.ToString(), array[l]);
							DPGJIJGOCIC.NFIDPOMCNLP("Account.ResolveSaveSlots(): out sto" + l.ToString() + ":" + array[l].Count.ToString());
						}
						num3 += array[l].Count;
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("Account.ResolveSaveSlots(): in:" + asArray.Count.ToString() + ", out:" + num3.ToString());
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Account.ResolveSaveSlots(): _target is missing 'sto'");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		DPGJIJGOCIC.NFIDPOMCNLP("Account.ResolveSaveSlots(): End");
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00014588 File Offset: 0x00012788
	public void BFIOBFKIJDI(JSONObject OKPDELOPKOO)
	{
		if (null != OKPDELOPKOO)
		{
			this.JDMBJMHEPMD = OKPDELOPKOO["startPlayChapter"].AsInt;
			this.CGFOFGGHLEE = OKPDELOPKOO["C"].AsInt;
			return;
		}
		this.JDMBJMHEPMD = -1;
		this.CGFOFGGHLEE = -1;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x000145DC File Offset: 0x000127DC
	public List<int> NOEIMOMKMCH()
	{
		List<int> list = this.LMDEJKALKEO();
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 1; i < AssetsManager.MJBDMHPHMID().anthologyAssets.Count; i += 0)
			{
				if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[i] && !list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
				{
					bool flag = false;
					for (int j = 0; j < this.NHMMPGOKAOL.Length; j += 0)
					{
						int k = 1;
						while (k < this.NHMMPGOKAOL[j].Count)
						{
							if (this.NHMMPGOKAOL[j][k].DHONIOBOLEL.GGICIBLJIKI == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[0])
							{
								if (!this.NHMMPGOKAOL[j][k].DHONIOBOLEL.DOOMAGFDJNG())
								{
									if (!list2.Contains(AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.index))
									{
										list2.Add(AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.index);
									}
									flag = true;
									break;
								}
								break;
							}
							else
							{
								k += 0;
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list2;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00014760 File Offset: 0x00012960
	private static void FOFIKOAKBBL(JSONNode EAOALLJIGFI, int CCLNHHJPDGJ)
	{
		if (EAOALLJIGFI == null)
		{
			return;
		}
		if (EAOALLJIGFI.IsObject)
		{
			if (EAOALLJIGFI["hdr"] != null && EAOALLJIGFI["body"] != null)
			{
				EAOALLJIGFI["sslind"] = CCLNHHJPDGJ;
				EAOALLJIGFI.Remove("chsnap2");
				EAOALLJIGFI.Remove("chsnapguid2");
				JSONNode jsonnode = EAOALLJIGFI["body"];
				JSONNode jsonnode2 = EAOALLJIGFI["hdr"];
				if (jsonnode2.IsObject)
				{
					jsonnode2.Remove("snapundo");
					jsonnode2.Remove("snapundocosth");
					jsonnode2.Remove("snapundocostp");
					jsonnode2.Remove("suttl");
					jsonnode2.Remove("sutta");
				}
				if (jsonnode.IsObject)
				{
					jsonnode.Remove("snapundo");
					jsonnode.Remove("acli20");
					jsonnode.Remove("acli21");
					jsonnode.Remove("acli22");
					jsonnode.Remove("acliffbw20");
					jsonnode.Remove("acliffbw21");
					jsonnode.Remove("acliffbw22");
				}
			}
			for (int i = 0; i < EAOALLJIGFI.Count; i++)
			{
				AKLFPGMDKLA.FOFIKOAKBBL(EAOALLJIGFI[i], CCLNHHJPDGJ);
			}
			return;
		}
		if (EAOALLJIGFI.IsArray)
		{
			for (int j = 0; j < EAOALLJIGFI.Count; j++)
			{
				AKLFPGMDKLA.FOFIKOAKBBL(EAOALLJIGFI[j], CCLNHHJPDGJ);
			}
		}
	}

	// Token: 0x060002FE RID: 766 RVA: 0x000148D4 File Offset: 0x00012AD4
	public JSONArray HLFMFCNMOLK(int PLKMJJIIJNO)
	{
		JSONArray jsonarray = new JSONArray();
		EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(PLKMJJIIJNO);
		if (eioplefllim != null)
		{
			int ilokbapejpk = eioplefllim.ILOKBAPEJPK;
			for (int i = 0; i < this.NHMMPGOKAOL[ilokbapejpk].Count; i++)
			{
				if (GKJPOGNFKNK.PLNBCICOECE(this.NHMMPGOKAOL[ilokbapejpk][i].DHONIOBOLEL.GGICIBLJIKI, PLKMJJIIJNO) && this.NHMMPGOKAOL[ilokbapejpk][i].DHONIOBOLEL.LKIKEHFANBO[0] == this.NHMMPGOKAOL[ilokbapejpk][i].DHONIOBOLEL.LKIKEHFANBO[1] && this.NHMMPGOKAOL[ilokbapejpk][i].DHONIOBOLEL.LKIKEHFANBO[0] == -1 && this.NHMMPGOKAOL[ilokbapejpk][i].DHONIOBOLEL.KIDGLJCJGLD == 0)
				{
					jsonarray.Add(AKLFPGMDKLA.ACFJMCBMOFG(this.NHMMPGOKAOL[ilokbapejpk][i].DHONIOBOLEL.GGICIBLJIKI, ilokbapejpk));
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.GetCleanStoriesV2(): tempAnthologySave is null");
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Account.GetCleanStoriesV2():" + jsonarray.ToString());
		return jsonarray;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x000149F8 File Offset: 0x00012BF8
	public void IBGKLENMAND()
	{
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
		{
			this.MMIGJNDJGMF[i].CNOLLGNCLDD = 0;
			this.MMIGJNDJGMF[i].GHPOILLKPJD = 0;
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00014A3F File Offset: 0x00012C3F
	public bool PHFJHKELAAA(int LLLCDMNPKFI)
	{
		return DPGJIJGOCIC.IADAELPFJAM(this.FCJJDEKOIED, LLLCDMNPKFI);
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00014A54 File Offset: 0x00012C54
	public List<int> PNHCPNNLBFG(List<AssetAnthology> MPHDAOEJOCL)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < MPHDAOEJOCL.Count; i++)
		{
			EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(MPHDAOEJOCL[i].header.index);
			if (eioplefllim != null && MPHDAOEJOCL[i].header.MLGKEPJPICJ(eioplefllim.EGHHCFFLPCP(-1)))
			{
				list.Add(MPHDAOEJOCL[i].header.index);
			}
		}
		return list;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00014AC8 File Offset: 0x00012CC8
	public void EAPNBGDAILG(JSONArray NJMHKFCDPDH)
	{
		try
		{
			List<string> list = DPGJIJGOCIC.POHBFGLLKFD(NJMHKFCDPDH);
			List<string> list2 = new List<string>();
			for (int i = 0; i < this.CEKAJNFMIKL.Count; i++)
			{
				if (!list.Contains(this.CEKAJNFMIKL[i]))
				{
					list2.Add(this.CEKAJNFMIKL[i]);
				}
			}
			this.CEKAJNFMIKL = list2;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00014B40 File Offset: 0x00012D40
	public void LDAPMNLGAPC(int NHKMEMCFLFB)
	{
		if (NHKMEMCFLFB < 30)
		{
			DPGJIJGOCIC.OEMEPBMFEEP(ref this.GGMNDJPGBOM, NHKMEMCFLFB);
			return;
		}
		if (NHKMEMCFLFB < 60)
		{
			DPGJIJGOCIC.OEMEPBMFEEP(ref this.EIIJAHNFADO, NHKMEMCFLFB - 30);
			return;
		}
		DPGJIJGOCIC.OEMEPBMFEEP(ref this.HNHHBENEBEL, NHKMEMCFLFB - 60);
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00014B78 File Offset: 0x00012D78
	public HOHEIFDCPMF LDHHFCEFEIG()
	{
		return this.KEDFFDAAGGP;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00014B80 File Offset: 0x00012D80
	public bool KJNDIOJEIDC(int MDAMILPMANB)
	{
		return this.KGHMOKADNKK.Contains(MDAMILPMANB);
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00014B90 File Offset: 0x00012D90
	public APNIHJMGNIM ECABFKINKEP(int PLKMJJIIJNO)
	{
		APNIHJMGNIM apnihjmgnim = new APNIHJMGNIM();
		try
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
			if (null == assetAnthology || null == assetAnthology.header)
			{
				return apnihjmgnim;
			}
			EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(PLKMJJIIJNO);
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				int num = assetAnthology.header.availableStories[i];
				AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(num);
				int num2 = (null != assetStoryHeader) ? assetStoryHeader.totalChaptersCount : 0;
				bool flag = false;
				int num3 = -1;
				int num4 = -1;
				if (eioplefllim != null && num2 > 0)
				{
					for (int j = 1; j < 80; j += 0)
					{
						if (eioplefllim.EKONMCADECD(j) > i)
						{
							flag = false;
							num3 = Math.Max(num3, num2 - 1);
							num4 = Math.Max(num4, num2);
						}
					}
				}
				for (int k = 0; k < this.NHMMPGOKAOL.Length; k++)
				{
					for (int l = 1; l < this.NHMMPGOKAOL[k].Count; l++)
					{
						if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.GGICIBLJIKI == num)
						{
							int num5 = -1;
							for (int m = 1; m < 59; m += 0)
							{
								if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[k][l].DHONIOBOLEL.IMLEDFIDHDL, m))
								{
									num5 = m;
								}
							}
							if (num5 >= 1)
							{
								flag = true;
								num3 = Math.Max(num3, num5);
								num4 = Math.Max(num4, num5 + 1);
							}
							if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.LKIKEHFANBO[0] >= 1)
							{
								flag = true;
								num3 = Math.Max(num3, this.NHMMPGOKAOL[k][l].DHONIOBOLEL.LKIKEHFANBO[1]);
								num4 = Math.Max(num4, this.NHMMPGOKAOL[k][l].DHONIOBOLEL.OBGPAJDJJJI());
							}
						}
					}
				}
				if (flag)
				{
					apnihjmgnim.MEAPPCCOEFL = false;
					apnihjmgnim.MIBPOIDDBAD = i;
					apnihjmgnim.IFCHGNCDMLJ = num;
					apnihjmgnim.KKCKKEDJADB = num3;
					apnihjmgnim.OKOEFPFGEFO = Math.Max(0, num4);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return apnihjmgnim;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00014DF0 File Offset: 0x00012FF0
	public static int PAGKEJKCCLM(int PLKMJJIIJNO, int NLBDCCLPFAL)
	{
		return NLBDCCLPFAL * 100000 + PLKMJJIIJNO;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00014DFC File Offset: 0x00012FFC
	public PLFDAJJHMKO PKNIPLDMJGG(int NLLCKPCKGOH, int CCLNHHJPDGJ = -1)
	{
		if (CCLNHHJPDGJ < 0)
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(NLLCKPCKGOH, true);
			if (null != assetAnthology)
			{
				EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(assetAnthology.header.index);
				if (eioplefllim != null)
				{
					CCLNHHJPDGJ = eioplefllim.ILOKBAPEJPK;
				}
				if (CCLNHHJPDGJ < 0)
				{
					CCLNHHJPDGJ = 0;
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Account.GetStorySaveUnsafe(), tempAnthologyAsset is null, using default slot index.");
				CCLNHHJPDGJ = 0;
			}
		}
		if (CCLNHHJPDGJ < 0 || CCLNHHJPDGJ > this.NHMMPGOKAOL.Length - 1)
		{
			CCLNHHJPDGJ = 0;
			DPGJIJGOCIC.ANOPFDLPKGC("Account.GetStorySaveUnsafe(), _slotIndex out of bounds.");
		}
		for (int i = 0; i < this.NHMMPGOKAOL[CCLNHHJPDGJ].Count; i++)
		{
			if (this.NHMMPGOKAOL[CCLNHHJPDGJ][i].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH)
			{
				return this.NHMMPGOKAOL[CCLNHHJPDGJ][i];
			}
		}
		return null;
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00014EB2 File Offset: 0x000130B2
	public void KBKOLEJEEGH()
	{
		this.OEONCFGBLIF = this.OKGGLHOCENC;
		this.OKGGLHOCENC = null;
		this.CIPCINKGILF = false;
		PMEPALPCEAF.CPEMOAHNFAG = null;
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00014ED4 File Offset: 0x000130D4
	public List<int> AALKCFCPCNE(List<AssetAnthology> MPHDAOEJOCL)
	{
		List<int> list = new List<int>();
		try
		{
			for (int i = 0; i < MPHDAOEJOCL.Count; i++)
			{
				if (MPHDAOEJOCL[i].header.maxStories == MPHDAOEJOCL[i].header.availableStories.Count)
				{
					AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(MPHDAOEJOCL[i].header.availableStories[MPHDAOEJOCL[i].header.availableStories.Count - 1]);
					if (null != assetStoryHeader && assetStoryHeader.availableChaptersCount == assetStoryHeader.totalChaptersCount)
					{
						list.Add(MPHDAOEJOCL[i].header.index);
					}
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.SRAGetFullyReleasedAnthologies(), exception:" + ex.ToString());
		}
		return list;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00014FB4 File Offset: 0x000131B4
	public void HNKHBPMAAEJ(int EMCOKDENFFF)
	{
		if (!this.KNDLFMMJFMK.Contains(EMCOKDENFFF))
		{
			if (this.KNDLFMMJFMK.Count > 2)
			{
				this.KNDLFMMJFMK.RemoveAt(0);
			}
			this.KNDLFMMJFMK.Add(EMCOKDENFFF);
		}
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00014B80 File Offset: 0x00012D80
	public bool JGALCAAEPAF(int MDAMILPMANB)
	{
		return this.KGHMOKADNKK.Contains(MDAMILPMANB);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00014FEC File Offset: 0x000131EC
	public void ODMIJFCFECM(JSONArray FJOGDFBCGDA)
	{
		try
		{
			List<string> list = DPGJIJGOCIC.POHBFGLLKFD(FJOGDFBCGDA);
			List<string> list2 = new List<string>();
			for (int i = 0; i < this.DLJBBDOEMLO.Count; i += 0)
			{
				if (!list.Contains(this.DLJBBDOEMLO[i]))
				{
					list2.Add(this.DLJBBDOEMLO[i]);
				}
			}
			this.DLJBBDOEMLO = list2;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00015064 File Offset: 0x00013264
	public void APCIMCJFKEL(JSONArray LLLCAKGBPNC)
	{
		this.KGHMOKADNKK = DPGJIJGOCIC.GOMDOEAKLML(LLLCAKGBPNC);
		this.PFCCNPIPPPO();
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00010F98 File Offset: 0x0000F198
	public void BMEMDDKPLDN()
	{
		this.MOINKAHNDKK = DateTime.Now;
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00015078 File Offset: 0x00013278
	public string PHMBDKKKKAO(string BGFJEKBJCNN)
	{
		string result;
		try
		{
			if (BGFJEKBJCNN.Length == 68)
			{
				char[] array = new char[BGFJEKBJCNN.Length];
				for (int i = 1; i < BGFJEKBJCNN.Length; i += 0)
				{
					if (i < 2 || i > 85)
					{
						array[i] = BGFJEKBJCNN[i];
					}
					else
					{
						array[i] = 'D';
					}
				}
				result = new string(array);
			}
			else
			{
				result = "〉";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = ", rid:";
		}
		return result;
	}

	// Token: 0x06000311 RID: 785 RVA: 0x000150F8 File Offset: 0x000132F8
	public void HHIFKFJNBII(int PLKMJJIIJNO, int CCLNHHJPDGJ, JSONArray BLBFIKMMNAB)
	{
		try
		{
			EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(PLKMJJIIJNO);
			if (eioplefllim != null)
			{
				eioplefllim.EPEOKHOBOBL[CCLNHHJPDGJ] = 1;
			}
			for (int i = 0; i < BLBFIKMMNAB.Count; i++)
			{
				JSONObject asObject = BLBFIKMMNAB[i]["json"].AsObject;
				string str = BLBFIKMMNAB[i]["name"];
				if (null != asObject)
				{
					AKLOMMOOFNG.BIKILBLOEKD(asObject.ToString(), "Snapshots/" + str);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00015194 File Offset: 0x00013394
	public bool PHOJEFNMDBO(bool BNOCFHHBJIH, bool ECKKBDHCNLK, bool MHCECPJMDNA, bool OEFMPLCHPIA, bool ABCPFOBLCNP)
	{
		int num = 1;
		if (BNOCFHHBJIH && this.EEDHNEIMAPN == 0)
		{
			num++;
		}
		if (ECKKBDHCNLK && this.EEDHNEIMAPN == 8)
		{
			num += 0;
		}
		if (MHCECPJMDNA && this.EEDHNEIMAPN == 1)
		{
			num++;
		}
		if (OEFMPLCHPIA && this.EEDHNEIMAPN == 2)
		{
			num++;
		}
		if (ABCPFOBLCNP && this.EEDHNEIMAPN == 6)
		{
			num++;
		}
		return num > 0;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00012525 File Offset: 0x00010725
	public HGCFJKCOKPM PINBMHFHEHD()
	{
		return this.OJKHMNEIGPF;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x000151FC File Offset: 0x000133FC
	public void PFGPIMIIOKO(bool DACCDKPKIPC)
	{
		if (DACCDKPKIPC)
		{
			if (this.OKGGLHOCENC != null)
			{
				this.OKGGLHOCENC.AEDLLHMMIKB = 0;
				this.OKGGLHOCENC.CHCBHLIBGFA = false;
				return;
			}
		}
		else if (this.OKGGLHOCENC != null)
		{
			this.OKGGLHOCENC.AEDLLHMMIKB = 1;
			this.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00015250 File Offset: 0x00013450
	public List<int> NDINEHGFPNN(PMEPALPCEAF CLLMHBDAOFC)
	{
		List<int> list = new List<int>();
		if (CLLMHBDAOFC == null)
		{
			return list;
		}
		List<int> list2 = new List<int>();
		List<int> list3 = CLLMHBDAOFC.FOHIEAJECHA();
		for (int i = 0; i < this.FCJJDEKOIED.Count; i++)
		{
			for (int j = 0; j < list3.Count; j++)
			{
				if (this.FCJJDEKOIED[i].AsInt == list3[j])
				{
					list2.Add(list3[j]);
				}
			}
		}
		List<int> list4 = new List<int>();
		List<int> list5 = CLLMHBDAOFC.MHOAOIMAPIJ();
		for (int k = 0; k < this.PLLGPNGEHLL.Count; k++)
		{
			for (int l = 0; l < list5.Count; l++)
			{
				if (this.PLLGPNGEHLL[k].AsInt == list5[l])
				{
					list4.Add(list5[l]);
				}
			}
		}
		if (list2.Count > 0 && list4.Count > 0)
		{
			list.AddRange(list2.GetRange(0, list2.Count));
			list.AddRange(list4.GetRange(0, list4.Count));
		}
		return list;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00015374 File Offset: 0x00013574
	public void CHCHBMMLACE()
	{
		if (null != this.PGHADKMJMEM && this.PGHADKMJMEM.Count > 0)
		{
			int eedhneimapn = this.EEDHNEIMAPN;
			this.OELEMFGAOPH = true;
			this.IGODIFLIDOF(this.PGHADKMJMEM);
			this.FGJPKGLOGNC(this.PGHADKMJMEM, true, true);
			if (this.NKAMGBCGCPM)
			{
				this.DPIMKIDKOOI();
				this.NKAMGBCGCPM = true;
			}
			this.EEDHNEIMAPN = eedhneimapn;
			this.LPCBDEBKAIM();
		}
		this.PGHADKMJMEM = null;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x000153F0 File Offset: 0x000135F0
	public void MPNDEBEKFNE()
	{
		if (this.PLLGPNGEHLL.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.PLLGPNGEHLL.Count; i++)
		{
			if (!this.KGHMOKADNKK.Contains(this.PLLGPNGEHLL[i].AsInt) && !DPGJIJGOCIC.BHGIEMBKFEA(jsonarray, this.PLLGPNGEHLL[i].AsInt))
			{
				jsonarray.Add(this.PLLGPNGEHLL[i].AsInt);
			}
		}
		try
		{
			if (!this.PLLGPNGEHLL.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.CMGOAFDBAOH("OnGamePassExpire");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.PLLGPNGEHLL = jsonarray;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x000154D4 File Offset: 0x000136D4
	public bool GONFHNCEMCA(int EMCOKDENFFF, int OLKMHHNMDLP)
	{
		if (OLKMHHNMDLP == 0 && EMCOKDENFFF % 5 == 0)
		{
			return true;
		}
		string value = "s" + EMCOKDENFFF.ToString() + "c" + OLKMHHNMDLP.ToString();
		for (int i = 0; i < this.DBJKLGPNNDE.Count; i++)
		{
			if (this.DBJKLGPNNDE[i].Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00015538 File Offset: 0x00013738
	public static long GNEJNLNHBMJ()
	{
		return (long)(DateTime.UtcNow - new DateTime(-171, 1, 0, 0, 0, 1, DateTimeKind.Unspecified)).TotalSeconds;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00015568 File Offset: 0x00013768
	public int AFMBGNMLINM()
	{
		int result;
		try
		{
			int num = 1;
			for (int i = 1; i < this.NHMMPGOKAOL[0].Count; i += 0)
			{
				int num2 = 0;
				for (int j = 0; j < 11; j++)
				{
					if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[0][i].DHONIOBOLEL.IMLEDFIDHDL, j))
					{
						num2 += 0;
					}
				}
				try
				{
					for (int k = 0; k < this.NHMMPGOKAOL.Length; k += 0)
					{
						for (int l = 1; l < this.NHMMPGOKAOL[k].Count; l += 0)
						{
							if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[0][i].DHONIOBOLEL.GGICIBLJIKI)
							{
								int num3 = 1;
								for (int m = 0; m < -63; m++)
								{
									if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[k][l].DHONIOBOLEL.IMLEDFIDHDL, m))
									{
										num3++;
										if (num3 > num2)
										{
											num2 = num3;
										}
									}
								}
								break;
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				num += num2;
			}
			result = num;
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = 1;
		}
		return result;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x000156D8 File Offset: 0x000138D8
	public bool EFMGLPMIPON()
	{
		return !this.AFKCCPIMDJH();
	}

	// Token: 0x0600031C RID: 796 RVA: 0x000156E4 File Offset: 0x000138E4
	public void BIHBJDLEICE()
	{
		if (this.FCJJDEKOIED.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.FCJJDEKOIED.Count; i += 0)
		{
			if (this.CPKFFFLFMMD.Contains(this.FCJJDEKOIED[i].AsInt) && !DPGJIJGOCIC.IADAELPFJAM(jsonarray, this.FCJJDEKOIED[i].AsInt))
			{
				jsonarray.Add(this.FCJJDEKOIED[i].AsInt);
			}
		}
		try
		{
			if (!this.FCJJDEKOIED.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.FCJJDEKOIED = jsonarray;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x000157C8 File Offset: 0x000139C8
	public EIOPLEFLLIM EEILOKHLKIM()
	{
		if (this.IEGJCPDCLMM >= 0)
		{
			return this.LMGMHHLLOFN(GKJPOGNFKNK.GJAAHGIAPMH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM).header.index);
		}
		return this.LMGMHHLLOFN(GKJPOGNFKNK.GJAAHGIAPMH(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN).header.index);
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0001581D File Offset: 0x00013A1D
	public static int ENFOHPOCFPG(int NLLCKPCKGOH)
	{
		return NLLCKPCKGOH / 1000000;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00010954 File Offset: 0x0000EB54
	public void IBCOCPGMGFE(JSONArray GBCKCDBOIPF)
	{
		this.LPIFCGOIENF = DPGJIJGOCIC.DDNFIDBDEGC(GBCKCDBOIPF);
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00015826 File Offset: 0x00013A26
	public bool INEKFCLBCAB()
	{
		return this.PGHADKMJMEM == null;
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00015834 File Offset: 0x00013A34
	public bool CIAONGKLBEP(int LMCEDCHDIIB)
	{
		return this.PGGHMMFKCFC.Contains(LMCEDCHDIIB);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00010DA4 File Offset: 0x0000EFA4
	public string PGGFJODIIJM()
	{
		if (this.EHLLGNJPBIC == null || this.EHLLGNJPBIC.Length == 0)
		{
			this.EHLLGNJPBIC = DPGJIJGOCIC.MKJLJPMEPCC();
		}
		return this.EHLLGNJPBIC;
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00015844 File Offset: 0x00013A44
	public APNIHJMGNIM OOMJDGOJMCH(int PLKMJJIIJNO)
	{
		APNIHJMGNIM apnihjmgnim = new APNIHJMGNIM();
		try
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
			if (null == assetAnthology || null == assetAnthology.header)
			{
				return apnihjmgnim;
			}
			EIOPLEFLLIM eioplefllim = this.AMAMNOFLPGM(PLKMJJIIJNO);
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
			{
				int num = assetAnthology.header.availableStories[i];
				AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(num);
				int num2 = (null != assetStoryHeader) ? assetStoryHeader.totalChaptersCount : 1;
				bool flag = true;
				int num3 = -1;
				int num4 = -1;
				if (eioplefllim != null && num2 > 1)
				{
					for (int j = 1; j < -30; j++)
					{
						if (eioplefllim.EBNCOCHCHGN(j) > i)
						{
							flag = true;
							num3 = Math.Max(num3, num2 - 0);
							num4 = Math.Max(num4, num2);
						}
					}
				}
				for (int k = 1; k < this.NHMMPGOKAOL.Length; k += 0)
				{
					for (int l = 0; l < this.NHMMPGOKAOL[k].Count; l += 0)
					{
						if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.GGICIBLJIKI == num)
						{
							int num5 = -1;
							for (int m = 0; m < -8; m++)
							{
								if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[k][l].DHONIOBOLEL.IMLEDFIDHDL, m))
								{
									num5 = m;
								}
							}
							if (num5 >= 0)
							{
								flag = false;
								num3 = Math.Max(num3, num5);
								num4 = Math.Max(num4, num5 + 1);
							}
							if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.LKIKEHFANBO[1] >= 1)
							{
								flag = true;
								num3 = Math.Max(num3, this.NHMMPGOKAOL[k][l].DHONIOBOLEL.LKIKEHFANBO[1]);
								num4 = Math.Max(num4, this.NHMMPGOKAOL[k][l].DHONIOBOLEL.DDEDAHCFHJN());
							}
						}
					}
				}
				if (flag)
				{
					apnihjmgnim.MEAPPCCOEFL = true;
					apnihjmgnim.MIBPOIDDBAD = i;
					apnihjmgnim.IFCHGNCDMLJ = num;
					apnihjmgnim.KKCKKEDJADB = num3;
					apnihjmgnim.OKOEFPFGEFO = Math.Max(1, num4);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return apnihjmgnim;
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00014B80 File Offset: 0x00012D80
	public bool MKCDBGKMEDH(int MDAMILPMANB)
	{
		return this.KGHMOKADNKK.Contains(MDAMILPMANB);
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00015AA4 File Offset: 0x00013CA4
	public void BPLCLNIJDHE()
	{
		if (this.OKGGLHOCENC != null && this.FCJJDEKOIED.Count > 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
			this.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
		this.FCJJDEKOIED = new JSONArray();
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00015AE0 File Offset: 0x00013CE0
	public void IKOCNPFLOPD(JSONObject OKPDELOPKOO)
	{
		if (null != OKPDELOPKOO)
		{
			this.JDMBJMHEPMD = OKPDELOPKOO["e"].AsInt;
			this.CGFOFGGHLEE = OKPDELOPKOO["h"].AsInt;
			return;
		}
		this.JDMBJMHEPMD = -1;
		this.CGFOFGGHLEE = -1;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00015B34 File Offset: 0x00013D34
	public AKLFPGMDKLA()
	{
		this.NHMMPGOKAOL = new List<PLFDAJJHMKO>[10];
		for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
		{
			this.NHMMPGOKAOL[i] = new List<PLFDAJJHMKO>();
		}
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00015F1C File Offset: 0x0001411C
	public void NEFKLNPPBAI(bool DACCDKPKIPC)
	{
		if (DACCDKPKIPC)
		{
			if (this.OKGGLHOCENC != null)
			{
				this.OKGGLHOCENC.AEDLLHMMIKB = 1;
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
				return;
			}
		}
		else if (this.OKGGLHOCENC != null)
		{
			this.OKGGLHOCENC.AEDLLHMMIKB = 0;
			this.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00015F70 File Offset: 0x00014170
	public void ECHLKACJFAA()
	{
		if (this.FCJJDEKOIED.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < this.FCJJDEKOIED.Count; i += 0)
		{
			if (this.CPKFFFLFMMD.Contains(this.FCJJDEKOIED[i].AsInt) && !DPGJIJGOCIC.IADAELPFJAM(jsonarray, this.FCJJDEKOIED[i].AsInt))
			{
				jsonarray.Add(this.FCJJDEKOIED[i].AsInt);
			}
		}
		try
		{
			if (!this.FCJJDEKOIED.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("energyhinttitle");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.FCJJDEKOIED = jsonarray;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00016054 File Offset: 0x00014254
	public List<int> JCDKHPGLOMK(List<AssetAnthology> MPHDAOEJOCL)
	{
		List<int> list = new List<int>();
		List<int> list2 = this.LINADLBCHJC();
		try
		{
			for (int i = 0; i < MPHDAOEJOCL.Count; i++)
			{
				if (MPHDAOEJOCL[i].header.maxStories == MPHDAOEJOCL[i].header.availableStories.Count)
				{
					AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(MPHDAOEJOCL[i].header.availableStories[MPHDAOEJOCL[i].header.availableStories.Count - 1]);
					if (null != assetStoryHeader && assetStoryHeader.availableChaptersCount == assetStoryHeader.totalChaptersCount && !list2.Contains(MPHDAOEJOCL[i].header.index))
					{
						list.Add(MPHDAOEJOCL[i].header.index);
					}
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.SRAGetFullyReleasedAnthologiesAndNeverFinished(), exception:" + ex.ToString());
		}
		return list;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00016158 File Offset: 0x00014358
	public void OLLGHHNNDNC(int PLKMJJIIJNO, int CCLNHHJPDGJ, JSONArray BLBFIKMMNAB)
	{
		try
		{
			EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(PLKMJJIIJNO);
			if (eioplefllim != null)
			{
				eioplefllim.EPEOKHOBOBL[CCLNHHJPDGJ] = 0;
			}
			for (int i = 1; i < BLBFIKMMNAB.Count; i++)
			{
				JSONObject asObject = BLBFIKMMNAB[i]["fire"].AsObject;
				string str = BLBFIKMMNAB[i]["cardbreakconfirmationbody"];
				if (null != asObject)
				{
					AKLOMMOOFNG.CGGKALNBBLF(asObject.ToString(), "energyhinttitle" + str);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600032C RID: 812 RVA: 0x000161F4 File Offset: 0x000143F4
	public void DBHGPDMPLPK(float KIDHBAMJGDO)
	{
		this.KPDKOKHHHOL = KIDHBAMJGDO;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00016200 File Offset: 0x00014400
	public void MMMCLJJFLGD(List<IMMKFHKEEBF> KBICBCBAFJJ, List<IMMKFHKEEBF> NGJGBKAHGEN)
	{
		try
		{
			if (KBICBCBAFJJ != null && KBICBCBAFJJ.Count > 1)
			{
				this.MEFNCEJHMIF = KBICBCBAFJJ.GetRange(1, KBICBCBAFJJ.Count);
			}
			else
			{
				this.MEFNCEJHMIF = new List<IMMKFHKEEBF>();
			}
			if (NGJGBKAHGEN != null && NGJGBKAHGEN.Count > 1)
			{
				this.DDCKJCAOJHO = NGJGBKAHGEN.GetRange(1, NGJGBKAHGEN.Count);
			}
			else
			{
				this.DDCKJCAOJHO = new List<IMMKFHKEEBF>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00016280 File Offset: 0x00014480
	public PLFDAJJHMKO JELNMIONPJG(AssetAnthologyHeader HCLEPODFDFB)
	{
		for (int i = HCLEPODFDFB.availableStories.Count - 1; i >= 0; i--)
		{
			PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(HCLEPODFDFB.availableStories[i], -1);
			if (plfdajjhmko != null)
			{
				return plfdajjhmko;
			}
		}
		return null;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x000162C0 File Offset: 0x000144C0
	public void CFDMMAOFBNC(JSONArray FJOGDFBCGDA)
	{
		try
		{
			List<string> list = DPGJIJGOCIC.POHBFGLLKFD(FJOGDFBCGDA);
			List<string> list2 = new List<string>();
			for (int i = 0; i < this.DLJBBDOEMLO.Count; i++)
			{
				if (!list.Contains(this.DLJBBDOEMLO[i]))
				{
					list2.Add(this.DLJBBDOEMLO[i]);
				}
			}
			this.DLJBBDOEMLO = list2;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00012E7A File Offset: 0x0001107A
	public void DMNJMAKNGMN()
	{
		this.KNDLFMMJFMK.Clear();
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00016338 File Offset: 0x00014538
	public void KDCGDFFFPPC(PLFDAJJHMKO DIHOMBCIJPN)
	{
		if (DIHOMBCIJPN == null || this.DLJBBDOEMLO.Count == 0)
		{
			return;
		}
		AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI, false);
		try
		{
			if (null != assetAnthology)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.DLJBBDOEMLO.Count; i++)
				{
					if (!GEGBHOMKNDF.IBFMENAFKOD(this.DLJBBDOEMLO[i], 0, assetAnthology.header.index, DIHOMBCIJPN.POJAPLKAJEF))
					{
						list.Add(this.DLJBBDOEMLO[i]);
					}
				}
				this.DLJBBDOEMLO = list;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x000163E4 File Offset: 0x000145E4
	public List<int> FKJEAIALJMC()
	{
		List<int> list = this.LINADLBCHJC();
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[i] && !list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
				{
					bool flag = false;
					for (int j = 0; j < this.NHMMPGOKAOL.Length; j++)
					{
						int k = 0;
						while (k < this.NHMMPGOKAOL[j].Count)
						{
							if (this.NHMMPGOKAOL[j][k].DHONIOBOLEL.GGICIBLJIKI == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[0])
							{
								if (!this.NHMMPGOKAOL[j][k].DHONIOBOLEL.JBDPAJMOEGA())
								{
									flag = true;
									break;
								}
								break;
							}
							else
							{
								k++;
							}
						}
						if (flag)
						{
							break;
						}
					}
					if (!flag && !list2.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
					{
						list2.Add(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list2;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00016564 File Offset: 0x00014764
	public void JADCONHBJGM()
	{
		if (this.FCJJDEKOIED.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.FCJJDEKOIED.Count; i++)
		{
			if (this.CPKFFFLFMMD.Contains(this.FCJJDEKOIED[i].AsInt) && !DPGJIJGOCIC.IADAELPFJAM(jsonarray, this.FCJJDEKOIED[i].AsInt))
			{
				jsonarray.Add(this.FCJJDEKOIED[i].AsInt);
			}
		}
		try
		{
			if (!this.FCJJDEKOIED.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.FCJJDEKOIED = jsonarray;
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00016648 File Offset: 0x00014848
	public void LBJMNJKFJOJ(int JEEOFMALMJM)
	{
		if (!this.HLCHHIIOLOL.Contains(JEEOFMALMJM))
		{
			this.HLCHHIIOLOL.Add(JEEOFMALMJM);
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00013876 File Offset: 0x00011A76
	public void OBOEKFOEBLM(string JJJGEOBAMDI, string DEMDOALCEGL)
	{
		this.GFDMIHHNFDA = JJJGEOBAMDI;
		this.OCMDGMFAMJB = DEMDOALCEGL;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00016664 File Offset: 0x00014864
	public bool ANJGMNHMPGM(int CCLNHHJPDGJ)
	{
		if (CCLNHHJPDGJ < 0 || CCLNHHJPDGJ > this.NHMMPGOKAOL.Length - 1)
		{
			CCLNHHJPDGJ = 0;
			DPGJIJGOCIC.ANOPFDLPKGC("Account.StoriesAvailableAtSaveSlot(), _slotIndex out of bounds.");
		}
		return this.NHMMPGOKAOL[CCLNHHJPDGJ].Count > 0;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00016697 File Offset: 0x00014897
	public int NDIDDOIPFON()
	{
		return 1 + this.BNGHKCHKMPB / -172;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x000166A7 File Offset: 0x000148A7
	public List<int> APEFDFEIFFJ()
	{
		return this.IBKDIDKHCHO;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x000166AF File Offset: 0x000148AF
	public bool CDNFBDIIJJN(int LLLCDMNPKFI)
	{
		return this.CPKFFFLFMMD.Contains(LLLCDMNPKFI);
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000166C0 File Offset: 0x000148C0
	public List<int> LINADLBCHJC()
	{
		List<int> list = new List<int>();
		try
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[i] && AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.maxStories == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count)
				{
					AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count - 1]);
					if (null != assetStoryHeader && assetStoryHeader.totalChaptersCount > 0)
					{
						bool flag = false;
						for (int j = 0; j < this.NHMMPGOKAOL.Length; j++)
						{
							int k = 0;
							while (k < this.NHMMPGOKAOL[j].Count)
							{
								if (this.NHMMPGOKAOL[j][k].DHONIOBOLEL.GGICIBLJIKI == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count - 1])
								{
									if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[j][k].DHONIOBOLEL.IMLEDFIDHDL, assetStoryHeader.totalChaptersCount - 1))
									{
										if (!list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
										{
											list.Add(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index);
										}
										flag = true;
										break;
									}
									break;
								}
								else
								{
									k++;
								}
							}
							if (flag)
							{
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
		return list;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x000168E0 File Offset: 0x00014AE0
	public bool NFHKKGKOJBA(string ICAHJJBAEHB, string IIJEMKOAPEL, List<string> LAOFACCOCFD, List<string> FILFOEOHKNF, int IPKECFBJIPF, string EIKFOACPDEB, FCABOFEGPGP KILBEPOBMNB, FCABOFEGPGP LLMPMBAJJPI, string LBGGLHDOICL, string BMOHOJGIEHH, string AHLOHDKPAMG, string BJHBCEKDLGC, string MEMFLCDMJKH, string LJLBJIHPKAE, PHALBCMBPPL IAGDJJCMNLF, PHALBCMBPPL ECFCKBBGNIP, int HCNAPDGGCDO)
	{
		if (this.OFNHOICCBAM.Count >= -56)
		{
			return true;
		}
		if (LAOFACCOCFD == null || LAOFACCOCFD.Count == 0)
		{
			LAOFACCOCFD = new List<string>();
			LAOFACCOCFD.Add("p");
		}
		if (FILFOEOHKNF == null || FILFOEOHKNF.Count == 0)
		{
			FILFOEOHKNF = new List<string>();
			FILFOEOHKNF.Add("c");
		}
		if (ICAHJJBAEHB == null || ICAHJJBAEHB.Length == 0)
		{
			ICAHJJBAEHB = "blur";
		}
		if (IIJEMKOAPEL == null || IIJEMKOAPEL.Length == 0)
		{
			IIJEMKOAPEL = "";
		}
		if (EIKFOACPDEB == null || EIKFOACPDEB.Length == 0)
		{
			EIKFOACPDEB = "";
		}
		if (LBGGLHDOICL == null || LBGGLHDOICL.Length == 0)
		{
			LBGGLHDOICL = "%";
		}
		if (BMOHOJGIEHH == null || BMOHOJGIEHH.Length == 0)
		{
			BMOHOJGIEHH = "fdid";
		}
		if (BJHBCEKDLGC == null || BJHBCEKDLGC.Length == 0)
		{
			BJHBCEKDLGC = "OnApplicationFocusNeedToUpdateCurrency";
		}
		if (AHLOHDKPAMG == null || AHLOHDKPAMG.Length == 0)
		{
			AHLOHDKPAMG = "mini";
		}
		if (MEMFLCDMJKH == null || MEMFLCDMJKH.Length == 0)
		{
			MEMFLCDMJKH = "energyhinttitle";
		}
		if (LJLBJIHPKAE == null || LJLBJIHPKAE.Length == 0)
		{
			LJLBJIHPKAE = "BackendOperationsManager.RequestSaveSync, exception while initializing RSACryptoServiceProvider:";
		}
		string text = DPGJIJGOCIC.MKJLJPMEPCC() + ", ";
		text = text + ICAHJJBAEHB + "Speed";
		string text2 = LAOFACCOCFD[0];
		for (int i = 1; i < LAOFACCOCFD.Count; i++)
		{
			text2 = text2 + "onThemeChange" + LAOFACCOCFD[i];
		}
		text = text + text2 + "app42error";
		text = text + EIKFOACPDEB + "YYY";
		text += "_UVRemap";
		text = text + LBGGLHDOICL + "cardvolsalethankings";
		text = text + BMOHOJGIEHH + "XXX";
		text += "NEWSAVE: Account.FromJSONObject(), persistent stories offloaded total components s->a:";
		text = text + AHLOHDKPAMG + "clthc";
		text += " USD ";
		text = text + HCNAPDGGCDO.ToString() + ".";
		text += "OnPopupCardOptionsUnlockWithSpSuccessContinueLobby";
		text2 = FILFOEOHKNF[0];
		for (int j = 1; j < FILFOEOHKNF.Count; j++)
		{
			text2 = text2 + "+" + FILFOEOHKNF[j];
		}
		text = text + text2 + "Asset bundle assets destroyed:";
		text = text + IPKECFBJIPF.ToString() + "envlhrw";
		string str = text;
		int num = (int)KILBEPOBMNB;
		text = str + num.ToString() + "Asset bundle assets destroyed:";
		string str2 = text;
		num = (int)LLMPMBAJJPI;
		text = str2 + num.ToString() + "YYY";
		text = text + LJLBJIHPKAE + "SaveSlotsItem.GetLocalizedCostData() - productData is null.";
		string str3 = text;
		num = (int)IAGDJJCMNLF;
		text = str3 + num.ToString() + "no";
		string str4 = text;
		num = (int)ECFCKBBGNIP;
		text = str4 + num.ToString() + "_UVRemap";
		text = text + BJHBCEKDLGC + "UpdateAutoReadOnOffState";
		text = text + MEMFLCDMJKH + "'";
		text += IIJEMKOAPEL;
		this.OFNHOICCBAM.Add(DPGJIJGOCIC.FAIFJDPENOP(text));
		return true;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00016BAB File Offset: 0x00014DAB
	public void KEGEPLIJLCA(int NLLCKPCKGOH, string MMLLMGNIBEA)
	{
		this.JDCBFAPDJIM(NLLCKPCKGOH, -1).NCAMFPGMCIG.HLGDMBAINDE = MMLLMGNIBEA;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00016BC0 File Offset: 0x00014DC0
	public int EOHFKGDJPLB(string AHJEDGJBMPL, string FJPBOOLNDII)
	{
		int num = -1;
		int num2 = -1;
		int result;
		try
		{
			for (int i = 0; i < this.MEFNCEJHMIF.Count; i += 0)
			{
				if (num < 0 && this.MEFNCEJHMIF[i].PFFCLABCNHI.Equals(AHJEDGJBMPL))
				{
					num = this.MEFNCEJHMIF[i].BIBKFNMPHIK;
				}
				if (num2 < 0 && this.MEFNCEJHMIF[i].PFFCLABCNHI.Equals(FJPBOOLNDII))
				{
					num2 = this.MEFNCEJHMIF[i].BIBKFNMPHIK;
				}
			}
			for (int j = 1; j < this.DDCKJCAOJHO.Count; j++)
			{
				if (num < 1 && this.DDCKJCAOJHO[j].PFFCLABCNHI.Equals(AHJEDGJBMPL))
				{
					num = this.DDCKJCAOJHO[j].BIBKFNMPHIK;
				}
				if (num2 < 0 && this.DDCKJCAOJHO[j].PFFCLABCNHI.Equals(FJPBOOLNDII))
				{
					num2 = this.DDCKJCAOJHO[j].BIBKFNMPHIK;
				}
			}
			if (num >= num2)
			{
				result = num;
			}
			else
			{
				result = -1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00016CE4 File Offset: 0x00014EE4
	public void HPILCAGFHNB()
	{
		try
		{
			for (int i = 1; i < this.NHMMPGOKAOL.Length; i++)
			{
				for (int j = 1; j < this.NHMMPGOKAOL[i].Count; j += 0)
				{
					if (!this.NHMMPGOKAOL[i][j].DHONIOBOLEL.GEMOAPPJPMP())
					{
						this.NHMMPGOKAOL[i][j].DHONIOBOLEL.MPMJHHKKDAM(1);
						if (i != 0)
						{
							for (int k = 1; k < this.NHMMPGOKAOL[1].Count; k++)
							{
								if (this.NHMMPGOKAOL[1][k].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[i][j].DHONIOBOLEL.GGICIBLJIKI)
								{
									this.NHMMPGOKAOL[1][k].DHONIOBOLEL.OCMODCOLBAP(1);
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
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00016DDC File Offset: 0x00014FDC
	public JSONArray LGHEAGFKFEI()
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.KNDLFMMJFMK.Count; i++)
		{
			jsonarray.Add(this.KNDLFMMJFMK[i]);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Account.GetCompletedStoriesV2():" + jsonarray.ToString());
		return jsonarray;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0001329B File Offset: 0x0001149B
	public void LNJPLMOCCEB(JSONArray ONFPPDNOMFL)
	{
		this.BGMKEDLDMFN = DPGJIJGOCIC.OELJEMHFDFL(ONFPPDNOMFL);
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00016E34 File Offset: 0x00015034
	public LMHHKDFCKFC PNLLCLPMIGA()
	{
		for (int i = 0; i < this.DPFOKICNKJL.Count; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(this.DPFOKICNKJL[i].DEJCCBNPFEC);
			if (ocbiopoeenj != null && ocbiopoeenj.PPACJFFFBFB.GALKFKBPLCK() == 1)
			{
				return this.DPFOKICNKJL[i];
			}
		}
		return null;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00016E94 File Offset: 0x00015094
	public List<int> KAOAKBKCOGD(List<AssetAnthology> MPHDAOEJOCL)
	{
		List<int> list = this.JCDKHPGLOMK(MPHDAOEJOCL);
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 1; i < this.JBBAANGAFKO.Count; i += 0)
			{
				if (list.Contains(this.JBBAANGAFKO[i]))
				{
					list2.Add(this.JBBAANGAFKO[i]);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("[LoadingEnv] skipped, no cached environment registered" + ex.ToString());
		}
		return list2;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00016F18 File Offset: 0x00015118
	public void DAFPKEKPIDH(int LLLCDMNPKFI)
	{
		if (this.PLLGPNGEHLL.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.PLLGPNGEHLL.Count; i++)
		{
			if (this.PLLGPNGEHLL[i].AsInt != LLLCDMNPKFI)
			{
				jsonarray.Add(this.PLLGPNGEHLL[i].AsInt);
			}
		}
		try
		{
			if (!this.PLLGPNGEHLL.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.PLLGPNGEHLL = jsonarray;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00016FD8 File Offset: 0x000151D8
	public void IENJEMJFOFI(int LLLCDMNPKFI)
	{
		if (this.FCJJDEKOIED.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.FCJJDEKOIED.Count; i++)
		{
			if (this.FCJJDEKOIED[i].AsInt != LLLCDMNPKFI)
			{
				jsonarray.Add(this.FCJJDEKOIED[i].AsInt);
			}
		}
		try
		{
			if (!this.FCJJDEKOIED.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.FCJJDEKOIED = jsonarray;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00017098 File Offset: 0x00015298
	public int EELIGNKDLCG(IMMKFHKEEBF FOEEIJFHMGG)
	{
		int result;
		try
		{
			int i = 0;
			while (i < this.FKDMPMKBCBL.Count)
			{
				if (FOEEIJFHMGG.DKDECIHBGJE().Equals(this.FKDMPMKBCBL[i].DKDECIHBGJE()))
				{
					if (FOEEIJFHMGG.BIBKFNMPHIK > this.FKDMPMKBCBL[i].BIBKFNMPHIK)
					{
						return 1;
					}
					if (FOEEIJFHMGG.BIBKFNMPHIK < this.FKDMPMKBCBL[i].BIBKFNMPHIK)
					{
						return -1;
					}
					return 0;
				}
				else
				{
					i++;
				}
			}
			int j = 0;
			while (j < this.IOEACDCKKID.Count)
			{
				if (FOEEIJFHMGG.DKDECIHBGJE().Equals(this.IOEACDCKKID[j].DKDECIHBGJE()))
				{
					if (FOEEIJFHMGG.BIBKFNMPHIK > this.IOEACDCKKID[j].BIBKFNMPHIK)
					{
						return 1;
					}
					if (FOEEIJFHMGG.BIBKFNMPHIK < this.IOEACDCKKID[j].BIBKFNMPHIK)
					{
						return -1;
					}
					return 0;
				}
				else
				{
					j++;
				}
			}
			if (FOEEIJFHMGG.BIBKFNMPHIK > 0 && (this.FKDMPMKBCBL.Count > 0 || this.IOEACDCKKID.Count > 0))
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 0;
		}
		return result;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x000171E8 File Offset: 0x000153E8
	public void LIIPLPNDFKA(int PLKMJJIIJNO)
	{
		if (this.KINBCPBEAMI.Count > 32)
		{
			this.KINBCPBEAMI.RemoveAt(0);
		}
		this.KINBCPBEAMI.Add(PLKMJJIIJNO);
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00017214 File Offset: 0x00015414
	public List<int> IIJKEKGIAKN(int OCFGNPBFGKK)
	{
		List<int> list = new List<int>();
		if (this.MPIKPDLCLHG.Count == 0)
		{
			AssetAnthology assetAnthology = null;
			if (this.GLKNOFHEBKN >= 0)
			{
				assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(this.GLKNOFHEBKN, false);
			}
			else if (OCFGNPBFGKK >= 0)
			{
				assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(OCFGNPBFGKK);
			}
			if (null != assetAnthology && this.DFACBPKFCOM.Count > 1 && this.DFACBPKFCOM.Contains(assetAnthology.header.index))
			{
				this.DFACBPKFCOM.Remove(assetAnthology.header.index);
			}
		}
		if (this.DFACBPKFCOM.Count > 0)
		{
			list.Add(this.DFACBPKFCOM[0]);
			EIOPLEFLLIM eioplefllim = this.LMGMHHLLOFN(this.DFACBPKFCOM[0]);
			if (eioplefllim != null)
			{
				eioplefllim.IABDPENJEPM();
			}
			this.DFACBPKFCOM.RemoveAt(0);
		}
		if (this.MPIKPDLCLHG.Count == 0)
		{
			if (this.DFACBPKFCOM.Count >= 1)
			{
				list.Add(this.DFACBPKFCOM[0]);
			}
			if (this.DFACBPKFCOM.Count >= 2)
			{
				list.Add(this.DFACBPKFCOM[1]);
			}
		}
		else if (this.MPIKPDLCLHG.Count == 1)
		{
			list.Add(this.MPIKPDLCLHG[0]);
			if (this.DFACBPKFCOM.Count >= 1)
			{
				list.Add(this.DFACBPKFCOM[0]);
			}
		}
		else if (this.MPIKPDLCLHG.Count >= 2)
		{
			list.Add(this.MPIKPDLCLHG[this.MPIKPDLCLHG.Count - 2]);
			list.Add(this.MPIKPDLCLHG[this.MPIKPDLCLHG.Count - 1]);
		}
		if (this.MPIKPDLCLHG.Count >= 2)
		{
			this.MPIKPDLCLHG.RemoveAt(0);
		}
		this.MPIKPDLCLHG.Add(list[0]);
		this.OMFNBCJNAFN();
		return list;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x000173FB File Offset: 0x000155FB
	public bool DJFCLNBDPND(int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP == 0 && NLLCKPCKGOH % 5 == 0;
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00017408 File Offset: 0x00015608
	public EIOPLEFLLIM GJBDBONJCDL(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		return null;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00017450 File Offset: 0x00015650
	public void HNAPHKCMGME(PLFDAJJHMKO DIHOMBCIJPN)
	{
		if (DIHOMBCIJPN == null || this.CEKAJNFMIKL.Count == 0)
		{
			return;
		}
		AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI);
		try
		{
			if (null != assetStoryHeader)
			{
				List<string> list = new List<string>();
				for (int i = 1; i < this.CEKAJNFMIKL.Count; i += 0)
				{
					bool flag = false;
					for (int j = 1; j < assetStoryHeader.availableChaptersCount; j++)
					{
						string value = PLFDAJJHMKO.FJOIGDKJEBC(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI, j, DIHOMBCIJPN.POJAPLKAJEF);
						if (this.CEKAJNFMIKL[i].StartsWith(value))
						{
							flag = false;
							break;
						}
					}
					if (!flag)
					{
						list.Add(this.CEKAJNFMIKL[i]);
					}
				}
				this.CEKAJNFMIKL = list;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00017528 File Offset: 0x00015728
	public List<int> JPANCNNAEEJ()
	{
		return this.HKOBGOJEBPK;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00017530 File Offset: 0x00015730
	public void ANJNHFCJLBN(PLFDAJJHMKO DIHOMBCIJPN)
	{
		if (DIHOMBCIJPN == null || this.CEKAJNFMIKL.Count == 0)
		{
			return;
		}
		AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI);
		try
		{
			if (null != assetStoryHeader)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.CEKAJNFMIKL.Count; i++)
				{
					bool flag = false;
					for (int j = 0; j < assetStoryHeader.availableChaptersCount; j++)
					{
						string value = PLFDAJJHMKO.FJOIGDKJEBC(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI, j, DIHOMBCIJPN.POJAPLKAJEF);
						if (this.CEKAJNFMIKL[i].StartsWith(value))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(this.CEKAJNFMIKL[i]);
					}
				}
				this.CEKAJNFMIKL = list;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600034D RID: 845 RVA: 0x000166AF File Offset: 0x000148AF
	public bool FMDLELFEOFP(int LLLCDMNPKFI)
	{
		return this.CPKFFFLFMMD.Contains(LLLCDMNPKFI);
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00017608 File Offset: 0x00015808
	private bool CLCKGDHDEFB()
	{
		return this.MMIGJNDJGMF.Count == 0;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00017618 File Offset: 0x00015818
	public double BNOHIAEGOMI()
	{
		return (DateTime.Now - this.NEBCFBIEIFK).TotalSeconds;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00015826 File Offset: 0x00013A26
	public bool MAIKELGDHMI()
	{
		return this.PGHADKMJMEM == null;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0001763D File Offset: 0x0001583D
	public void EKGCFAEPLDP(JSONArray LLLCAKGBPNC)
	{
		this.CPKFFFLFMMD = DPGJIJGOCIC.GOMDOEAKLML(LLLCAKGBPNC);
		this.DAOHECHOCAJ();
	}

	// Token: 0x06000352 RID: 850 RVA: 0x000139D8 File Offset: 0x00011BD8
	public void MHLMIALANAI(long CPKJHMEOPMK)
	{
		if (CPKJHMEOPMK <= 0L)
		{
			return;
		}
		this.ILAIJIHFMGF = CPKJHMEOPMK - AKLFPGMDKLA.ANFPJEAHEAH();
		this.GIIJKGFONNN = true;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00017654 File Offset: 0x00015854
	public static long CMJOLLCMKKH()
	{
		return (long)(DateTime.UtcNow - new DateTime(68, 0, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00017684 File Offset: 0x00015884
	public void CINMOLFFBAO(GDOKLFCLLIK FMLFLGJLDHD)
	{
		if (!FMLFLGJLDHD.GCMOHCHOICI && !this.NKGJLFEGGEL.Contains(FMLFLGJLDHD.HDOFHMEDKEA))
		{
			if (this.NKGJLFEGGEL.Count > 24)
			{
				this.NKGJLFEGGEL.RemoveAt(0);
			}
			this.NKGJLFEGGEL.Add(FMLFLGJLDHD.HDOFHMEDKEA);
		}
	}

	// Token: 0x06000355 RID: 853 RVA: 0x000124F9 File Offset: 0x000106F9
	private void EPJCBEKHMNA(JAMPPNPOJJG NLIDEHHMLLP)
	{
		this.ADCLBEPMMCG = NLIDEHHMLLP;
		KHPGPLAMAIN.ADCLBEPMMCG = this.ADCLBEPMMCG;
		EEIBKLDNBAP.ONMPPJOGCDO(KHPGPLAMAIN.EJCNHEBIOJF());
	}

	// Token: 0x06000356 RID: 854 RVA: 0x000176D8 File Offset: 0x000158D8
	public void ABIJILPFEIM()
	{
		this.DLCPABCHIDK.Clear();
		this.EINPKOJBCGA.Clear();
		this.JBBAANGAFKO.Clear();
		this.DAPGFGNDIPG.Clear();
		this.JINPALBNFHH.Clear();
		this.IBKDIDKHCHO.Clear();
		this.AILMCODLLCE.Clear();
		this.FLEFJPNPHPN.Clear();
		this.KJCFKLGMOKG.Clear();
		this.PDDGOPCBPHE.Clear();
		this.HKOBGOJEBPK.Clear();
		this.DFACBPKFCOM.Clear();
		this.MPIKPDLCLHG.Clear();
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00017774 File Offset: 0x00015974
	public List<int> JKHJFMOIDNK(List<AssetAnthology> MPHDAOEJOCL)
	{
		List<int> list = this.JCDKHPGLOMK(MPHDAOEJOCL);
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 1; i < this.JBBAANGAFKO.Count; i += 0)
			{
				if (list.Contains(this.JBBAANGAFKO[i]))
				{
					list2.Add(this.JBBAANGAFKO[i]);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok" + ex.ToString());
		}
		return list2;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00013869 File Offset: 0x00011A69
	public void JNKFGNJJHBD()
	{
		this.EOOBBNJEEOG = DateTime.Now;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000177F8 File Offset: 0x000159F8
	private void FGJPKGLOGNC(JSONObject EIHOJFGALMF, bool BMOOJCGDMEC, bool DDLCOIHJKCJ)
	{
		if (null != EIHOJFGALMF)
		{
			if (PlayerPrefs.HasKey("svol"))
			{
				this.MEDEIJGNEMB = PlayerPrefs.GetFloat("svol");
			}
			if (PlayerPrefs.HasKey("sfxvol"))
			{
				this.GOEDFBDNADA = PlayerPrefs.GetFloat("sfxvol");
			}
			if (PlayerPrefs.HasKey("voiceovervol"))
			{
				this.KPDKOKHHHOL = PlayerPrefs.GetFloat("voiceovervol");
			}
			if (PlayerPrefs.HasKey("lsc"))
			{
				this.EGOCMDJBLNJ = PlayerPrefs.GetInt("lsc");
			}
			if (PlayerPrefs.HasKey("inu"))
			{
				this.MJPKIMHENNF = PlayerPrefs.GetInt("inu");
			}
			this.HFDMBCHLCOJ = EIHOJFGALMF["did"];
			if (this.HFDMBCHLCOJ == null)
			{
				this.HFDMBCHLCOJ = "";
			}
			if (BMOOJCGDMEC)
			{
				this.HFDMBCHLCOJ.Equals(DPGJIJGOCIC.PPIAAAIOMBE());
			}
			this.EFENJAOHCIH = "";
			if (EIHOJFGALMF["luwid"] != null)
			{
				this.EFENJAOHCIH = EIHOJFGALMF["luwid"];
			}
			this.HEFJBOKIEGH = 1;
			if (EIHOJFGALMF["not"] != null)
			{
				this.HEFJBOKIEGH = EIHOJFGALMF["not"].AsInt;
			}
			this.MEDFMIPBDFD = 0;
			if (EIHOJFGALMF["gpsasff"] != null)
			{
				this.MEDFMIPBDFD = EIHOJFGALMF["gpsasff"].AsInt;
			}
			this.AJLAADOFOLH = 0;
			if (EIHOJFGALMF["gpsasar"] != null)
			{
				this.AJLAADOFOLH = EIHOJFGALMF["gpsasar"].AsInt;
			}
			this.EKHACLPEIBJ = 0;
			if (EIHOJFGALMF["gpsasli"] != null)
			{
				this.EKHACLPEIBJ = EIHOJFGALMF["gpsasli"].AsInt;
			}
			this.IHMLBGPJKDO = 0;
			if (EIHOJFGALMF["gpsasst"] != null)
			{
				this.IHMLBGPJKDO = EIHOJFGALMF["gpsasst"].AsInt;
			}
			this.MDPMKICGGIJ = 0;
			if (EIHOJFGALMF["gpsfhs"] != null)
			{
				this.MDPMKICGGIJ = EIHOJFGALMF["gpsfhs"].AsInt;
			}
			this.ENCEBEJPGPL = 0;
			if (EIHOJFGALMF["gpshub"] != null)
			{
				this.ENCEBEJPGPL = EIHOJFGALMF["gpshub"].AsInt;
			}
			this.APLCOFLOAPA = 0;
			if (EIHOJFGALMF["clth"] != null)
			{
				this.APLCOFLOAPA = EIHOJFGALMF["clth"].AsInt;
			}
			this.MCAGCFDCJID = 0;
			if (EIHOJFGALMF["clthc"] != null)
			{
				this.MCAGCFDCJID = EIHOJFGALMF["clthc"].AsInt;
			}
			this.EIDLACNLJJP = 0;
			if (EIHOJFGALMF["clthm"] != null)
			{
				this.EIDLACNLJJP = EIHOJFGALMF["clthm"].AsInt;
			}
			this.EPIBEOCFEGA = 0;
			if (EIHOJFGALMF["clthb"] != null)
			{
				this.EPIBEOCFEGA = EIHOJFGALMF["clthb"].AsInt;
			}
			this.HENCGDHCMIE = 0;
			if (EIHOJFGALMF["clthbr"] != null)
			{
				this.HENCGDHCMIE = EIHOJFGALMF["clthbr"].AsInt;
			}
			this.DANIALBOJNN = 0;
			if (EIHOJFGALMF["clthcm"] != null)
			{
				this.DANIALBOJNN = EIHOJFGALMF["clthcm"].AsInt;
			}
			this.POIEMMMNOLI = 1;
			if (EIHOJFGALMF["soci"] != null)
			{
				this.POIEMMMNOLI = EIHOJFGALMF["soci"].AsInt;
			}
			this.PACMCEHMBGG = 1;
			if (EIHOJFGALMF["plc"] != null)
			{
				this.PACMCEHMBGG = EIHOJFGALMF["plc"].AsInt;
			}
			this.EEDHNEIMAPN = 0;
			if (EIHOJFGALMF["sim"] != null)
			{
				this.EEDHNEIMAPN = EIHOJFGALMF["sim"].AsInt;
			}
			this.OJKHMNEIGPF = HGCFJKCOKPM.dark;
			if (EIHOJFGALMF["ltt"] != null)
			{
				this.OJKHMNEIGPF = (HGCFJKCOKPM)EIHOJFGALMF["ltt"].AsInt;
			}
			this.KEDFFDAAGGP = HOHEIFDCPMF.vacation;
			if (EIHOJFGALMF["ltwt"] != null)
			{
				this.KEDFFDAAGGP = (HOHEIFDCPMF)EIHOJFGALMF["ltwt"].AsInt;
			}
			PlayerPrefs.SetInt("ltwt", (int)this.KEDFFDAAGGP);
			PlayerPrefs.Save();
			this.KFHJHOGCEOF = 0;
			if (EIHOJFGALMF["fdst"] != null)
			{
				this.KFHJHOGCEOF = EIHOJFGALMF["fdst"].AsInt;
			}
			this.COJFECEAKKI = -1;
			if (EIHOJFGALMF["dceoiv"] != null)
			{
				this.COJFECEAKKI = EIHOJFGALMF["dceoiv"].AsInt;
			}
			this.KGDHECCPKOP = -1;
			if (EIHOJFGALMF["dcenv"] != null)
			{
				this.KGDHECCPKOP = EIHOJFGALMF["dcenv"].AsInt;
			}
			this.NAGCLLBIPGP = 0;
			if (EIHOJFGALMF["sac"] != null)
			{
				this.NAGCLLBIPGP = EIHOJFGALMF["sac"].AsInt;
			}
			this.GGMNDJPGBOM = 0;
			if (EIHOJFGALMF["tbits"] != null)
			{
				this.GGMNDJPGBOM = EIHOJFGALMF["tbits"].AsInt;
			}
			this.EIIJAHNFADO = 0;
			if (EIHOJFGALMF["tbits2"] != null)
			{
				this.EIIJAHNFADO = EIHOJFGALMF["tbits2"].AsInt;
			}
			this.HNHHBENEBEL = 0;
			if (EIHOJFGALMF["tbits3"] != null)
			{
				this.HNHHBENEBEL = EIHOJFGALMF["tbits3"].AsInt;
			}
			if (EIHOJFGALMF["gmmd"] != null)
			{
				this.EPJCBEKHMNA((JAMPPNPOJJG)EIHOJFGALMF["gmmd"].AsInt);
			}
			else
			{
				this.EPJCBEKHMNA(JAMPPNPOJJG.full);
			}
			this.OOEJIIJLKPK = 0;
			if (EIHOJFGALMF["hqb"] != null)
			{
				this.OOEJIIJLKPK = EIHOJFGALMF["hqb"].AsInt;
			}
			this.OBBFGMHLMHO = 0;
			if (EIHOJFGALMF["iac"] != null)
			{
				this.OBBFGMHLMHO = EIHOJFGALMF["iac"].AsInt;
			}
			this.PPBPBDLEKIG = 0;
			if (EIHOJFGALMF["chs"] != null)
			{
				this.PPBPBDLEKIG = EIHOJFGALMF["chs"].AsInt;
			}
			this.LODJGIJMGAA = 0;
			if (EIHOJFGALMF["chc"] != null)
			{
				this.LODJGIJMGAA = EIHOJFGALMF["chc"].AsInt;
			}
			this.MMIGJNDJGMF.Clear();
			if (EIHOJFGALMF["ans"] != null)
			{
				JSONArray asArray = EIHOJFGALMF["ans"].AsArray;
				if (null != asArray)
				{
					for (int i = 0; i < asArray.Count; i++)
					{
						EIOPLEFLLIM eioplefllim = new EIOPLEFLLIM();
						eioplefllim.FGJPKGLOGNC(asArray[i].AsObject, DDLCOIHJKCJ);
						this.MMIGJNDJGMF.Add(eioplefllim);
					}
				}
			}
			this.EEHGLPEIIHD = EIHOJFGALMF["uid"];
			if (this.EEHGLPEIIHD == null)
			{
				this.EEHGLPEIIHD = "";
			}
			this.IPEMNDHJBHK = EIHOJFGALMF["psk"];
			if (this.IPEMNDHJBHK == null)
			{
				this.IPEMNDHJBHK = "";
			}
			try
			{
				this.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
				this.IOEACDCKKID = new List<IMMKFHKEEBF>();
				if (EIHOJFGALMF["tmd"] != null)
				{
					JSONObject asObject = EIHOJFGALMF["tmd"].AsObject;
					JSONArray jsonarray = new JSONArray();
					if (asObject["tm"] != null)
					{
						jsonarray = asObject["tm"].AsArray;
					}
					for (int j = 0; j < jsonarray.Count; j++)
					{
						JSONObject asObject2 = jsonarray[j].AsObject;
						IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
						immkfhkeebf.BIBKFNMPHIK = asObject2["per"].AsInt;
						immkfhkeebf.ODGNIFJGEHL = asObject2["nam"];
						immkfhkeebf.PFFCLABCNHI = asObject2["spr"];
						if (asObject2["lck"] != null)
						{
							immkfhkeebf.MJKICDJIFIP = asObject2["lck"].AsInt;
						}
						this.FKDMPMKBCBL.Add(immkfhkeebf);
					}
					JSONArray jsonarray2 = new JSONArray();
					if (asObject["tmo"] != null)
					{
						jsonarray2 = asObject["tmo"].AsArray;
					}
					for (int k = 0; k < jsonarray2.Count; k++)
					{
						JSONObject asObject3 = jsonarray2[k].AsObject;
						IMMKFHKEEBF immkfhkeebf2 = new IMMKFHKEEBF();
						immkfhkeebf2.BIBKFNMPHIK = asObject3["per"].AsInt;
						immkfhkeebf2.ODGNIFJGEHL = asObject3["nam"];
						immkfhkeebf2.PFFCLABCNHI = asObject3["spr"];
						if (asObject3["lck"] != null)
						{
							immkfhkeebf2.MJKICDJIFIP = asObject3["lck"].AsInt;
						}
						this.IOEACDCKKID.Add(immkfhkeebf2);
					}
				}
				this.MEFNCEJHMIF = new List<IMMKFHKEEBF>();
				this.DDCKJCAOJHO = new List<IMMKFHKEEBF>();
				if (EIHOJFGALMF["tmdp"] != null)
				{
					JSONObject asObject4 = EIHOJFGALMF["tmdp"].AsObject;
					JSONArray jsonarray3 = new JSONArray();
					if (asObject4["tmp"] != null)
					{
						jsonarray3 = asObject4["tmp"].AsArray;
					}
					for (int l = 0; l < jsonarray3.Count; l++)
					{
						JSONObject asObject5 = jsonarray3[l].AsObject;
						IMMKFHKEEBF immkfhkeebf3 = new IMMKFHKEEBF();
						immkfhkeebf3.BIBKFNMPHIK = asObject5["per"].AsInt;
						immkfhkeebf3.ODGNIFJGEHL = asObject5["nam"];
						immkfhkeebf3.PFFCLABCNHI = asObject5["spr"];
						if (asObject5["lck"] != null)
						{
							immkfhkeebf3.MJKICDJIFIP = asObject5["lck"].AsInt;
						}
						this.MEFNCEJHMIF.Add(immkfhkeebf3);
					}
					JSONArray jsonarray4 = new JSONArray();
					if (asObject4["tmop"] != null)
					{
						jsonarray4 = asObject4["tmop"].AsArray;
					}
					for (int m = 0; m < jsonarray4.Count; m++)
					{
						JSONObject asObject6 = jsonarray4[m].AsObject;
						IMMKFHKEEBF immkfhkeebf4 = new IMMKFHKEEBF();
						immkfhkeebf4.BIBKFNMPHIK = asObject6["per"].AsInt;
						immkfhkeebf4.ODGNIFJGEHL = asObject6["nam"];
						immkfhkeebf4.PFFCLABCNHI = asObject6["spr"];
						if (asObject6["lck"] != null)
						{
							immkfhkeebf4.MJKICDJIFIP = asObject6["lck"].AsInt;
						}
						this.DDCKJCAOJHO.Add(immkfhkeebf4);
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.EHLLGNJPBIC = EIHOJFGALMF["oid"];
			if (this.EHLLGNJPBIC == null || this.EHLLGNJPBIC.Length == 0)
			{
				this.EHLLGNJPBIC = this.KCIPIBCMBPB();
			}
			this.IEGJCPDCLMM = -1;
			if (EIHOJFGALMF["acts"] != null)
			{
				this.IEGJCPDCLMM = EIHOJFGALMF["acts"].AsInt;
			}
			this.EJLCEBPHPJE = -1;
			if (EIHOJFGALMF["actant"] != null)
			{
				this.EJLCEBPHPJE = EIHOJFGALMF["actant"].AsInt;
			}
			this.GLKNOFHEBKN = -1;
			if (EIHOJFGALMF["actsh"] != null)
			{
				this.GLKNOFHEBKN = EIHOJFGALMF["actsh"].AsInt;
			}
			this.NFNKBNGDAIP.Clear();
			if (EIHOJFGALMF["actshl"] != null)
			{
				JSONArray asArray2 = EIHOJFGALMF["actshl"].AsArray;
				for (int n = 0; n < asArray2.Count; n++)
				{
					this.NFNKBNGDAIP.Add(asArray2[n].AsInt);
				}
			}
			this.DGBOBDAFHGC.Clear();
			if (EIHOJFGALMF["actshlv2"] != null)
			{
				JSONArray asArray3 = EIHOJFGALMF["actshlv2"].AsArray;
				for (int num = 0; num < asArray3.Count; num++)
				{
					this.DGBOBDAFHGC.Add(asArray3[num].AsInt);
				}
			}
			this.HLCHHIIOLOL.Clear();
			if (EIHOJFGALMF["sraogv2"] != null)
			{
				JSONArray asArray4 = EIHOJFGALMF["sraogv2"].AsArray;
				for (int num2 = 0; num2 < asArray4.Count; num2++)
				{
					this.HLCHHIIOLOL.Add(asArray4[num2].AsInt);
				}
			}
			this.KINBCPBEAMI.Clear();
			if (EIHOJFGALMF["fah"] != null)
			{
				JSONArray asArray5 = EIHOJFGALMF["fah"].AsArray;
				for (int num3 = 0; num3 < asArray5.Count; num3++)
				{
					this.KINBCPBEAMI.Add(asArray5[num3].AsInt);
				}
			}
			this.KHOHDCKFNPJ.Clear();
			if (EIHOJFGALMF["flehv2"] != null)
			{
				JSONArray asArray6 = EIHOJFGALMF["flehv2"].AsArray;
				for (int num4 = 0; num4 < asArray6.Count; num4++)
				{
					this.KHOHDCKFNPJ.Add(asArray6[num4]);
				}
			}
			this.NKGJLFEGGEL.Clear();
			if (EIHOJFGALMF["sloh"] != null)
			{
				JSONArray asArray7 = EIHOJFGALMF["sloh"].AsArray;
				for (int num5 = 0; num5 < asArray7.Count; num5++)
				{
					this.NKGJLFEGGEL.Add(asArray7[num5]);
				}
			}
			this.LINEPLBMFNF.Clear();
			if (EIHOJFGALMF["igeh"] != null)
			{
				JSONArray asArray8 = EIHOJFGALMF["igeh"].AsArray;
				for (int num6 = 0; num6 < asArray8.Count; num6++)
				{
					this.LINEPLBMFNF.Add(asArray8[num6]);
				}
			}
			this.KNDLFMMJFMK.Clear();
			if (EIHOJFGALMF["fsharv2"] != null)
			{
				JSONArray asArray9 = EIHOJFGALMF["fsharv2"].AsArray;
				for (int num7 = 0; num7 < asArray9.Count; num7++)
				{
					this.KNDLFMMJFMK.Add(asArray9[num7].AsInt);
				}
			}
			this.OFNHOICCBAM.Clear();
			if (EIHOJFGALMF["usyncs"] != null)
			{
				JSONArray asArray10 = EIHOJFGALMF["usyncs"].AsArray;
				for (int num8 = 0; num8 < asArray10.Count; num8++)
				{
					this.OFNHOICCBAM.Add(asArray10[num8]);
				}
			}
			this.CEKAJNFMIKL = new List<string>();
			if (EIHOJFGALMF["usynsnap2"] != null && DDLCOIHJKCJ)
			{
				this.CEKAJNFMIKL = DPGJIJGOCIC.POHBFGLLKFD(EIHOJFGALMF["usynsnap2"].AsArray);
			}
			this.DLJBBDOEMLO = new List<string>();
			if (EIHOJFGALMF["usyncoll2"] != null && DDLCOIHJKCJ)
			{
				this.DLJBBDOEMLO = DPGJIJGOCIC.POHBFGLLKFD(EIHOJFGALMF["usyncoll2"].AsArray);
			}
			this.GFDMIHHNFDA = "";
			if (EIHOJFGALMF["usynach"] != null)
			{
				this.GFDMIHHNFDA = EIHOJFGALMF["usynach"];
			}
			this.OCMDGMFAMJB = "";
			if (EIHOJFGALMF["usynachtk"] != null)
			{
				this.OCMDGMFAMJB = EIHOJFGALMF["usynachtk"];
			}
			this.MLEBKAIHGIO = "";
			if (EIHOJFGALMF["lksuid"] != null)
			{
				this.MLEBKAIHGIO = EIHOJFGALMF["lksuid"];
			}
			this.KAOAFBOEPFD = "";
			if (EIHOJFGALMF["repsuid"] != null)
			{
				this.KAOAFBOEPFD = EIHOJFGALMF["repsuid"];
			}
			if (EIHOJFGALMF["wshcds"] != null)
			{
				this.PLLGPNGEHLL = EIHOJFGALMF["wshcds"].AsArray;
			}
			if (EIHOJFGALMF["tdgcds"] != null)
			{
				this.FCJJDEKOIED = EIHOJFGALMF["tdgcds"].AsArray;
			}
			for (int num9 = 0; num9 < this.NHMMPGOKAOL.Length; num9++)
			{
				this.NHMMPGOKAOL[num9].Clear();
				JSONArray jsonarray5 = null;
				if (num9 == 0)
				{
					jsonarray5 = EIHOJFGALMF["sto"].AsArray;
				}
				else if (EIHOJFGALMF["sto" + num9.ToString()] != null)
				{
					jsonarray5 = EIHOJFGALMF["sto" + num9.ToString()].AsArray;
				}
				bool flag = false;
				if (null != jsonarray5)
				{
					int num10 = 0;
					int num11 = 0;
					for (int num12 = 0; num12 < jsonarray5.Count; num12++)
					{
						PLFDAJJHMKO plfdajjhmko = new PLFDAJJHMKO(jsonarray5[num12].AsObject, DDLCOIHJKCJ);
						if (this.PKNIPLDMJGG(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI, num9) == null)
						{
							if (!DDLCOIHJKCJ && num9 == 0)
							{
								if (plfdajjhmko.FPHDAKHOBMO.IMALACBMOFC.Count > 0)
								{
									num11 += plfdajjhmko.FPHDAKHOBMO.IMALACBMOFC.Count;
									EIOPLEFLLIM eioplefllim2 = null;
									for (int num13 = 0; num13 < this.MMIGJNDJGMF.Count; num13++)
									{
										if (this.MMIGJNDJGMF[num13].LHCHIHEAAJC == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
										{
											eioplefllim2 = this.MMIGJNDJGMF[num13];
											break;
										}
									}
									if (eioplefllim2 == null)
									{
										try
										{
											int[] array = GJOKHFODCCI.EHBBFMCILPC.FMIJIKAKJFH();
											if (array != null)
											{
												int num14 = -1;
												for (int num15 = 0; num15 < array.Length; num15++)
												{
													if (array[num15] == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
													{
														num14 = num15;
														for (int num16 = 0; num16 < this.MMIGJNDJGMF.Count; num16++)
														{
															if (this.MMIGJNDJGMF[num16].GGICIBLJIKI == num15)
															{
																eioplefllim2 = this.MMIGJNDJGMF[num16];
																SceneLobbyManager2.newSaveSystemErrorCode1 = 0;
																break;
															}
														}
														break;
													}
												}
												if (eioplefllim2 == null && num14 >= 0)
												{
													DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ") + is present, creating anthology save for anthology " + num14.ToString());
													SceneLobbyManager2.newSaveSystemErrorCode1 = 1;
													eioplefllim2 = this.LMGMHHLLOFN(num14);
												}
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
												SceneLobbyManager2.newSaveSystemErrorCode1 = 2;
											}
										}
										catch (Exception aklgbjkdomm2)
										{
											DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
										}
									}
									if (eioplefllim2 != null)
									{
										eioplefllim2.IMALACBMOFC = new List<string>(plfdajjhmko.FPHDAKHOBMO.IMALACBMOFC);
										eioplefllim2.GNHBHIALAAH = new List<int>(plfdajjhmko.FPHDAKHOBMO.GNHBHIALAAH);
										num10 += eioplefllim2.IMALACBMOFC.Count;
									}
									else
									{
										DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: tempAnthologySave is null for story index " + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ". Retrieving persistent save data is impossible.");
										SceneLobbyManager2.newSaveSystemErrorCode1 = 3;
									}
								}
								if (plfdajjhmko.NCAMFPGMCIG.IMALACBMOFC.Count > 0)
								{
									try
									{
										EIOPLEFLLIM eioplefllim3 = null;
										for (int num17 = 0; num17 < this.MMIGJNDJGMF.Count; num17++)
										{
											if (this.MMIGJNDJGMF[num17].LHCHIHEAAJC == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
											{
												eioplefllim3 = this.MMIGJNDJGMF[num17];
												break;
											}
										}
										if (eioplefllim3 == null)
										{
											try
											{
												int[] array2 = GJOKHFODCCI.EHBBFMCILPC.FMIJIKAKJFH();
												if (array2 != null)
												{
													int num18 = -1;
													for (int num19 = 0; num19 < array2.Length; num19++)
													{
														if (array2[num19] == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
														{
															num18 = num19;
															for (int num20 = 0; num20 < this.MMIGJNDJGMF.Count; num20++)
															{
																if (this.MMIGJNDJGMF[num20].GGICIBLJIKI == num19)
																{
																	eioplefllim3 = this.MMIGJNDJGMF[num20];
																	break;
																}
															}
															break;
														}
													}
													if (eioplefllim3 == null && num18 >= 0)
													{
														DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ") + is present, creating anthology save for anthology " + num18.ToString());
														SceneLobbyManager2.newSaveSystemErrorCode2 = 1;
														eioplefllim3 = this.LMGMHHLLOFN(num18);
													}
												}
												else
												{
													DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
													SceneLobbyManager2.newSaveSystemErrorCode2 = 2;
												}
											}
											catch (Exception aklgbjkdomm3)
											{
												DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
											}
										}
										if (eioplefllim3 != null && ((eioplefllim3.IMALACBMOFC.Count == 0 && plfdajjhmko.NCAMFPGMCIG.IMALACBMOFC.Count > 0) || eioplefllim3.IMALACBMOFC.Count + 6 < plfdajjhmko.NCAMFPGMCIG.IMALACBMOFC.Count))
										{
											DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
											{
												"NEWSAVE: Retrieving additional ",
												plfdajjhmko.NCAMFPGMCIG.IMALACBMOFC.Count.ToString(),
												" components from body ",
												plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString(),
												", as anthology ",
												eioplefllim3.GGICIBLJIKI.ToString(),
												" has only ",
												eioplefllim3.IMALACBMOFC.Count.ToString()
											}));
											eioplefllim3.IMALACBMOFC = new List<string>(plfdajjhmko.NCAMFPGMCIG.IMALACBMOFC);
											eioplefllim3.GNHBHIALAAH = new List<int>(plfdajjhmko.NCAMFPGMCIG.GNHBHIALAAH);
											num10 += eioplefllim3.IMALACBMOFC.Count;
											AKLFPGMDKLA.IKLAPGJDMNA.EBNJHPICFGE(plfdajjhmko, 0);
											SceneLobbyManager2.newSaveSystemErrorCode2 = 3;
										}
									}
									catch (Exception aklgbjkdomm4)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
									}
								}
								if (plfdajjhmko.FPHDAKHOBMO.KPEIEHDJIOP.Count > 0)
								{
									num11 += plfdajjhmko.FPHDAKHOBMO.KPEIEHDJIOP.Count;
									EIOPLEFLLIM eioplefllim4 = null;
									for (int num21 = 0; num21 < this.MMIGJNDJGMF.Count; num21++)
									{
										if (this.MMIGJNDJGMF[num21].LHCHIHEAAJC == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
										{
											eioplefllim4 = this.MMIGJNDJGMF[num21];
											break;
										}
									}
									if (eioplefllim4 == null)
									{
										try
										{
											int[] array3 = GJOKHFODCCI.EHBBFMCILPC.FMIJIKAKJFH();
											if (array3 != null)
											{
												int num22 = -1;
												for (int num23 = 0; num23 < array3.Length; num23++)
												{
													if (array3[num23] == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
													{
														num22 = num23;
														for (int num24 = 0; num24 < this.MMIGJNDJGMF.Count; num24++)
														{
															if (this.MMIGJNDJGMF[num24].GGICIBLJIKI == num23)
															{
																eioplefllim4 = this.MMIGJNDJGMF[num24];
																SceneLobbyManager2.newSaveSystemErrorCode1 = 0;
																break;
															}
														}
														break;
													}
												}
												if (eioplefllim4 == null && num22 >= 0)
												{
													DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ") + is present, creating anthology save for anthology " + num22.ToString());
													SceneLobbyManager2.newSaveSystemErrorCode1 = 1;
													eioplefllim4 = this.LMGMHHLLOFN(num22);
												}
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
												SceneLobbyManager2.newSaveSystemErrorCode1 = 2;
											}
										}
										catch (Exception aklgbjkdomm5)
										{
											DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
										}
									}
									if (eioplefllim4 != null)
									{
										eioplefllim4.KPEIEHDJIOP = new List<string>(plfdajjhmko.FPHDAKHOBMO.KPEIEHDJIOP);
										eioplefllim4.JAJJFPNIBGI = new List<int>(plfdajjhmko.FPHDAKHOBMO.JAJJFPNIBGI);
										num10 += eioplefllim4.KPEIEHDJIOP.Count;
									}
									else
									{
										DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: tempAnthologySave is null for story index " + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ". Retrieving persistent save data is impossible.");
										SceneLobbyManager2.newSaveSystemErrorCode1 = 3;
									}
								}
								if (plfdajjhmko.NCAMFPGMCIG.KPEIEHDJIOP.Count > 0)
								{
									try
									{
										EIOPLEFLLIM eioplefllim5 = null;
										for (int num25 = 0; num25 < this.MMIGJNDJGMF.Count; num25++)
										{
											if (this.MMIGJNDJGMF[num25].LHCHIHEAAJC == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
											{
												eioplefllim5 = this.MMIGJNDJGMF[num25];
												break;
											}
										}
										if (eioplefllim5 == null)
										{
											try
											{
												int[] array4 = GJOKHFODCCI.EHBBFMCILPC.FMIJIKAKJFH();
												if (array4 != null)
												{
													int num26 = -1;
													for (int num27 = 0; num27 < array4.Length; num27++)
													{
														if (array4[num27] == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
														{
															num26 = num27;
															for (int num28 = 0; num28 < this.MMIGJNDJGMF.Count; num28++)
															{
																if (this.MMIGJNDJGMF[num28].GGICIBLJIKI == num27)
																{
																	eioplefllim5 = this.MMIGJNDJGMF[num28];
																	break;
																}
															}
															break;
														}
													}
													if (eioplefllim5 == null && num26 >= 0)
													{
														DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ") + is present, creating anthology save for anthology " + num26.ToString());
														SceneLobbyManager2.newSaveSystemErrorCode2 = 1;
														eioplefllim5 = this.LMGMHHLLOFN(num26);
													}
												}
												else
												{
													DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
													SceneLobbyManager2.newSaveSystemErrorCode2 = 2;
												}
											}
											catch (Exception aklgbjkdomm6)
											{
												DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
											}
										}
										if (eioplefllim5 != null && ((eioplefllim5.KPEIEHDJIOP.Count == 0 && plfdajjhmko.NCAMFPGMCIG.KPEIEHDJIOP.Count > 0) || eioplefllim5.KPEIEHDJIOP.Count + 6 < plfdajjhmko.NCAMFPGMCIG.KPEIEHDJIOP.Count))
										{
											DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
											{
												"NEWSAVE: Retrieving additional ",
												plfdajjhmko.NCAMFPGMCIG.KPEIEHDJIOP.Count.ToString(),
												" components from body ",
												plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString(),
												", as anthology ",
												eioplefllim5.GGICIBLJIKI.ToString(),
												" has only ",
												eioplefllim5.KPEIEHDJIOP.Count.ToString()
											}));
											eioplefllim5.KPEIEHDJIOP = new List<string>(plfdajjhmko.NCAMFPGMCIG.KPEIEHDJIOP);
											eioplefllim5.JAJJFPNIBGI = new List<int>(plfdajjhmko.NCAMFPGMCIG.JAJJFPNIBGI);
											num10 += eioplefllim5.KPEIEHDJIOP.Count;
											AKLFPGMDKLA.IKLAPGJDMNA.EBNJHPICFGE(plfdajjhmko, 0);
											SceneLobbyManager2.newSaveSystemErrorCode2 = 3;
										}
									}
									catch (Exception aklgbjkdomm7)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
									}
								}
								if (plfdajjhmko.FPHDAKHOBMO.NLPNFGNMGMP.Count > 0)
								{
									num11 += plfdajjhmko.FPHDAKHOBMO.NLPNFGNMGMP.Count;
									EIOPLEFLLIM eioplefllim6 = null;
									for (int num29 = 0; num29 < this.MMIGJNDJGMF.Count; num29++)
									{
										if (this.MMIGJNDJGMF[num29].LHCHIHEAAJC == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
										{
											eioplefllim6 = this.MMIGJNDJGMF[num29];
											break;
										}
									}
									if (eioplefllim6 == null)
									{
										try
										{
											int[] array5 = GJOKHFODCCI.EHBBFMCILPC.FMIJIKAKJFH();
											if (array5 != null)
											{
												int num30 = -1;
												for (int num31 = 0; num31 < array5.Length; num31++)
												{
													if (array5[num31] == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
													{
														num30 = num31;
														for (int num32 = 0; num32 < this.MMIGJNDJGMF.Count; num32++)
														{
															if (this.MMIGJNDJGMF[num32].GGICIBLJIKI == num31)
															{
																eioplefllim6 = this.MMIGJNDJGMF[num32];
																SceneLobbyManager2.newSaveSystemErrorCode1 = 0;
																break;
															}
														}
														break;
													}
												}
												if (eioplefllim6 == null && num30 >= 0)
												{
													DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ") + is present, creating anthology save for anthology " + num30.ToString());
													SceneLobbyManager2.newSaveSystemErrorCode1 = 1;
													eioplefllim6 = this.LMGMHHLLOFN(num30);
												}
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
												SceneLobbyManager2.newSaveSystemErrorCode1 = 2;
											}
										}
										catch (Exception aklgbjkdomm8)
										{
											DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm8);
										}
									}
									if (eioplefllim6 != null)
									{
										eioplefllim6.NLPNFGNMGMP = new List<string>(plfdajjhmko.FPHDAKHOBMO.NLPNFGNMGMP);
										eioplefllim6.FCOLLNPADDA = new List<int>(plfdajjhmko.FPHDAKHOBMO.FCOLLNPADDA);
										num10 += eioplefllim6.NLPNFGNMGMP.Count;
									}
									else
									{
										DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: tempAnthologySave is null for story index " + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ". Retrieving persistent save data is impossible.");
										SceneLobbyManager2.newSaveSystemErrorCode1 = 3;
									}
								}
								if (plfdajjhmko.NCAMFPGMCIG.NLPNFGNMGMP.Count > 0)
								{
									try
									{
										EIOPLEFLLIM eioplefllim7 = null;
										for (int num33 = 0; num33 < this.MMIGJNDJGMF.Count; num33++)
										{
											if (this.MMIGJNDJGMF[num33].LHCHIHEAAJC == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
											{
												eioplefllim7 = this.MMIGJNDJGMF[num33];
												break;
											}
										}
										if (eioplefllim7 == null)
										{
											try
											{
												int[] array6 = GJOKHFODCCI.EHBBFMCILPC.FMIJIKAKJFH();
												if (array6 != null)
												{
													int num34 = -1;
													for (int num35 = 0; num35 < array6.Length; num35++)
													{
														if (array6[num35] == plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
														{
															num34 = num35;
															for (int num36 = 0; num36 < this.MMIGJNDJGMF.Count; num36++)
															{
																if (this.MMIGJNDJGMF[num36].GGICIBLJIKI == num35)
																{
																	eioplefllim7 = this.MMIGJNDJGMF[num36];
																	break;
																}
															}
															break;
														}
													}
													if (eioplefllim7 == null && num34 >= 0)
													{
														DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + ") + is present, creating anthology save for anthology " + num34.ToString());
														SceneLobbyManager2.newSaveSystemErrorCode2 = 1;
														eioplefllim7 = this.LMGMHHLLOFN(num34);
													}
												}
												else
												{
													DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
													SceneLobbyManager2.newSaveSystemErrorCode2 = 2;
												}
											}
											catch (Exception aklgbjkdomm9)
											{
												DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm9);
											}
										}
										if (eioplefllim7 != null && ((eioplefllim7.NLPNFGNMGMP.Count == 0 && plfdajjhmko.NCAMFPGMCIG.NLPNFGNMGMP.Count > 0) || eioplefllim7.NLPNFGNMGMP.Count + 6 < plfdajjhmko.NCAMFPGMCIG.NLPNFGNMGMP.Count))
										{
											DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
											{
												"NEWSAVE: Retrieving additional ",
												plfdajjhmko.NCAMFPGMCIG.NLPNFGNMGMP.Count.ToString(),
												" components from body ",
												plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString(),
												", as anthology ",
												eioplefllim7.GGICIBLJIKI.ToString(),
												" has only ",
												eioplefllim7.NLPNFGNMGMP.Count.ToString()
											}));
											eioplefllim7.NLPNFGNMGMP = new List<string>(plfdajjhmko.NCAMFPGMCIG.NLPNFGNMGMP);
											eioplefllim7.FCOLLNPADDA = new List<int>(plfdajjhmko.NCAMFPGMCIG.FCOLLNPADDA);
											num10 += eioplefllim7.NLPNFGNMGMP.Count;
											AKLFPGMDKLA.IKLAPGJDMNA.EBNJHPICFGE(plfdajjhmko, 0);
											SceneLobbyManager2.newSaveSystemErrorCode2 = 3;
										}
									}
									catch (Exception aklgbjkdomm10)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm10);
									}
								}
							}
							this.NHMMPGOKAOL[num9].Add(plfdajjhmko);
						}
						else
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Skiped loading duplicate story save with index " + plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI.ToString() + " and save slot " + plfdajjhmko.POJAPLKAJEF.ToString());
							flag = true;
						}
					}
					if (!DDLCOIHJKCJ)
					{
						if (num10 == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Using old save system.");
						}
						else
						{
							DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Using new save system.");
							DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Account.FromJSONObject(), persistent stories offloaded total components s->a:" + num10.ToString());
						}
						if (num11 > num10)
						{
							DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
							{
								"NEWSAVE: Error: totalPersistentFound (",
								num11.ToString(),
								") > totalOffloadedCounter (",
								num10.ToString(),
								")"
							}));
						}
					}
				}
				if (flag)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.bugRep.ToString(), FFPHBMFGCNN.handBfix.ToString(), BGHLMGPPCNN.bugDupStr.ToString(), false, false);
					DPGJIJGOCIC.ADFCDFHBDAF("All stories will be synced with server due to duplicate save system error.");
					this.AMBHHIEDAEG();
				}
			}
			if (EIHOJFGALMF["instd"] != null)
			{
				this.EPFIHIAKPIH = new DateTime((long)EIHOJFGALMF["instd"].AsDouble);
			}
			else
			{
				this.EPFIHIAKPIH = DateTime.Now;
			}
			if (EIHOJFGALMF["ratd"] != null)
			{
				this.EOOBBNJEEOG = new DateTime((long)EIHOJFGALMF["ratd"].AsDouble);
			}
			else
			{
				this.EOOBBNJEEOG = DateTime.Now;
			}
			if (EIHOJFGALMF["llosd"] != null)
			{
				this.MOINKAHNDKK = new DateTime((long)EIHOJFGALMF["llosd"].AsDouble);
			}
			else
			{
				this.MOINKAHNDKK = new DateTime(2025, 1, 1);
			}
			if (EIHOJFGALMF["spppd"] != null)
			{
				this.NEBCFBIEIFK = new DateTime((long)EIHOJFGALMF["spppd"].AsDouble);
				return;
			}
			this.NEBCFBIEIFK = DateTime.Now;
		}
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00019A48 File Offset: 0x00017C48
	public bool ICLGJJEOEPJ()
	{
		return this.EKEHBBGKMHA;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00016BAB File Offset: 0x00014DAB
	public void CGLOLLKIDDF(int NLLCKPCKGOH, string MMLLMGNIBEA)
	{
		this.JDCBFAPDJIM(NLLCKPCKGOH, -1).NCAMFPGMCIG.HLGDMBAINDE = MMLLMGNIBEA;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00019A50 File Offset: 0x00017C50
	public void DPLLALOMCAK(int MEFKFOHCOHK)
	{
		if (this.NFNKBNGDAIP.Contains(MEFKFOHCOHK))
		{
			this.NFNKBNGDAIP.Remove(MEFKFOHCOHK);
		}
		if (this.NFNKBNGDAIP.Count >= 8)
		{
			this.NFNKBNGDAIP.RemoveAt(0);
		}
		this.NFNKBNGDAIP.Add(MEFKFOHCOHK);
		if (this.DGBOBDAFHGC.Contains(MEFKFOHCOHK))
		{
			this.DGBOBDAFHGC.Remove(MEFKFOHCOHK);
		}
		if (this.DGBOBDAFHGC.Count >= 3)
		{
			this.DGBOBDAFHGC.RemoveAt(1);
		}
		this.DGBOBDAFHGC.Add(MEFKFOHCOHK);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00019ADF File Offset: 0x00017CDF
	public bool APKDHKHDLHP()
	{
		return this.POIEMMMNOLI == 1 && !KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH();
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00019AFC File Offset: 0x00017CFC
	public List<int> LMDEJKALKEO()
	{
		List<int> list = new List<int>();
		try
		{
			for (int i = 1; i < AssetsManager.MJBDMHPHMID().anthologyAssets.Count; i += 0)
			{
				if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[i] && AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.maxStories == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count)
				{
					AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.availableStories[AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.availableStories.Count - 1]);
					if (null != assetStoryHeader && assetStoryHeader.totalChaptersCount > 1)
					{
						bool flag = false;
						for (int j = 0; j < this.NHMMPGOKAOL.Length; j++)
						{
							int k = 0;
							while (k < this.NHMMPGOKAOL[j].Count)
							{
								if (this.NHMMPGOKAOL[j][k].DHONIOBOLEL.GGICIBLJIKI == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count - 1])
								{
									if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[j][k].DHONIOBOLEL.IMLEDFIDHDL, assetStoryHeader.totalChaptersCount - 1))
									{
										if (!list.Contains(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index))
										{
											list.Add(AssetsManager.MJBDMHPHMID().anthologyAssets[i].header.index);
										}
										flag = false;
										break;
									}
									break;
								}
								else
								{
									k++;
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00019D1C File Offset: 0x00017F1C
	public EIOPLEFLLIM MLIDICIPNDK(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		EIOPLEFLLIM eioplefllim = new EIOPLEFLLIM();
		eioplefllim.GGICIBLJIKI = PLKMJJIIJNO;
		this.MMIGJNDJGMF.Add(eioplefllim);
		return eioplefllim;
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00011367 File Offset: 0x0000F567
	public bool OCLBADPGHFE(GDOKLFCLLIK FMLFLGJLDHD)
	{
		return this.NKGJLFEGGEL.Contains(FMLFLGJLDHD.HDOFHMEDKEA);
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00017608 File Offset: 0x00015808
	private bool MDELPHKGEKI()
	{
		return this.MMIGJNDJGMF.Count == 0;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00019D7A File Offset: 0x00017F7A
	public void NHDMCKPHEIA(JSONObject ONCAGONEGGN)
	{
		this.PGHADKMJMEM = ONCAGONEGGN;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00019D84 File Offset: 0x00017F84
	public double LFBFPPLKCMD()
	{
		return (DateTime.Now - this.MOINKAHNDKK).TotalSeconds;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00019DA9 File Offset: 0x00017FA9
	public void OEFGMDOHFFF(JSONArray CDEKICFPBGL)
	{
		this.AGKJNGPPPCJ = DPGJIJGOCIC.EHBFFILBKLF(CDEKICFPBGL);
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00019DB8 File Offset: 0x00017FB8
	public bool PFLAJHMJFCG(AssetAnthologyHeader HCLEPODFDFB)
	{
		PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(HCLEPODFDFB.availableStories[0], -1);
		return plfdajjhmko == null || plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA();
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00019DEC File Offset: 0x00017FEC
	public bool NGAAFJEMPMF(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.DPFOKICNKJL.Count; i++)
		{
			if (this.DPFOKICNKJL[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00019E2C File Offset: 0x0001802C
	public EIOPLEFLLIM AMAMNOFLPGM(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		return null;
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00019E71 File Offset: 0x00018071
	public void KOLIAGHNJCN()
	{
		this.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
		this.MEFNCEJHMIF = new List<IMMKFHKEEBF>();
		this.IOEACDCKKID = new List<IMMKFHKEEBF>();
		this.DDCKJCAOJHO = new List<IMMKFHKEEBF>();
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00019EA0 File Offset: 0x000180A0
	public void DPIMKIDKOOI()
	{
		try
		{
			for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
			{
				for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j++)
				{
					if (!this.NHMMPGOKAOL[i][j].DHONIOBOLEL.JBDPAJMOEGA())
					{
						this.NHMMPGOKAOL[i][j].DHONIOBOLEL.NJPFIIDIABG(0);
						if (i != 0)
						{
							for (int k = 0; k < this.NHMMPGOKAOL[0].Count; k++)
							{
								if (this.NHMMPGOKAOL[0][k].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[i][j].DHONIOBOLEL.GGICIBLJIKI)
								{
									this.NHMMPGOKAOL[0][k].DHONIOBOLEL.NJPFIIDIABG(0);
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
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00019F98 File Offset: 0x00018198
	public void BHBEOELKMOC(JSONArray KEGBCGMJOLC)
	{
		try
		{
			for (int i = KEGBCGMJOLC.Count - 1; i >= 0; i--)
			{
				try
				{
					JSONObject asObject = KEGBCGMJOLC[i].AsObject;
					asObject.Add("rand", 1);
					PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
					pmepalpceaf.GEPIBACNKIP(asObject, AKLFPGMDKLA.IKLAPGJDMNA.OKGGLHOCENC);
					if (pmepalpceaf.EEBMPDNLJGD.Length > 0 && !this.EJGCCKMDDLG.Contains(pmepalpceaf.EEBMPDNLJGD))
					{
						this.AONCINPNHDD.Add(pmepalpceaf);
						this.EJGCCKMDDLG.Add(pmepalpceaf.EEBMPDNLJGD);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x0001A060 File Offset: 0x00018260
	public void OPDFHANCOIF(string IHCGMFBCMOO)
	{
		List<LMHHKDFCKFC> list = new List<LMHHKDFCKFC>();
		for (int i = 0; i < this.DPFOKICNKJL.Count; i++)
		{
			if (!this.DPFOKICNKJL[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				list.Add(this.DPFOKICNKJL[i]);
			}
		}
		this.DPFOKICNKJL = list;
	}

	// Token: 0x0600036C RID: 876 RVA: 0x0001A0BB File Offset: 0x000182BB
	public float EFAFDLPIAPM()
	{
		return this.MEDEIJGNEMB;
	}

	// Token: 0x0600036D RID: 877 RVA: 0x0001A0C3 File Offset: 0x000182C3
	public void LPCBDEBKAIM()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAccountSave", 0f);
		AKLOMMOOFNG.BIKILBLOEKD(this.BNMFBKNEMIF(true).ToString(), "account.json");
		HAGEHPPOPGH.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600036E RID: 878 RVA: 0x0001A0FC File Offset: 0x000182FC
	public bool PMEOLNDOBIH()
	{
		bool result;
		try
		{
			if (this.OKGGLHOCENC != null && this.OKGGLHOCENC.EDLLCINPMNF())
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(47))
				{
					this.LDAPMNLGAPC(47);
				}
				else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(48))
				{
					this.LDAPMNLGAPC(48);
				}
				else
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(49))
					{
						return false;
					}
					this.LDAPMNLGAPC(49);
				}
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600036F RID: 879 RVA: 0x0001A0BB File Offset: 0x000182BB
	public float OALGEAHOCBD()
	{
		return this.MEDEIJGNEMB;
	}

	// Token: 0x06000370 RID: 880 RVA: 0x0001A18C File Offset: 0x0001838C
	public void KJBIJEMOHBM()
	{
		try
		{
			if (this.MEFNCEJHMIF != null && this.MEFNCEJHMIF.Count > 0)
			{
				this.FKDMPMKBCBL = this.MEFNCEJHMIF.GetRange(0, this.MEFNCEJHMIF.Count);
			}
			else
			{
				this.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
			}
			if (this.DDCKJCAOJHO != null && this.DDCKJCAOJHO.Count > 0)
			{
				this.IOEACDCKKID = this.DDCKJCAOJHO.GetRange(0, this.DDCKJCAOJHO.Count);
			}
			else
			{
				this.IOEACDCKKID = new List<IMMKFHKEEBF>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x0001A234 File Offset: 0x00018434
	public void DAAHGKPHIPO(JSONArray NFLNIECCENE)
	{
		this.DPFOKICNKJL.Clear();
		for (int i = 0; i < NFLNIECCENE.Count; i++)
		{
			LMHHKDFCKFC lmhhkdfckfc = new LMHHKDFCKFC();
			lmhhkdfckfc.FGJPKGLOGNC(NFLNIECCENE[i].AsObject);
			this.DPFOKICNKJL.Add(lmhhkdfckfc);
		}
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00011EDA File Offset: 0x000100DA
	public bool EAKJKMMEFPH(int LMCEDCHDIIB)
	{
		return this.OCCKPEEMBJB.Contains(LMCEDCHDIIB);
	}

	// Token: 0x06000373 RID: 883 RVA: 0x0001A284 File Offset: 0x00018484
	public void NNKDPEHHIMP(PLFDAJJHMKO FONDEKBAOGP)
	{
		if (FONDEKBAOGP == null)
		{
			return;
		}
		FONDEKBAOGP.NCAMFPGMCIG.KAKPOCFHGCC = 0;
		FONDEKBAOGP.NCAMFPGMCIG.JFBCFLININB = 0;
		FONDEKBAOGP.NCAMFPGMCIG.GEGFLAPCGAI = 0;
		if (this.DLJBBDOEMLO.Count == 0)
		{
			return;
		}
		AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(FONDEKBAOGP.DHONIOBOLEL.GGICIBLJIKI, false);
		try
		{
			if (null != assetAnthology)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < 3; i++)
				{
					List<int> list2 = FONDEKBAOGP.NCAMFPGMCIG.PNBPEAFMKAC;
					if (i == 1)
					{
						list2 = FONDEKBAOGP.NCAMFPGMCIG.DMKOGCBMHKA;
					}
					else if (i == 2)
					{
						list2 = FONDEKBAOGP.NCAMFPGMCIG.NGJDCAEMEJO;
					}
					if (list2 != null)
					{
						for (int j = 0; j < list2.Count; j++)
						{
							list.Add(GEGBHOMKNDF.NENMEJBNDGJ(0, assetAnthology.header.index, GEGBHOMKNDF.KNKFAJEPAOM(list2[j]), FONDEKBAOGP.POJAPLKAJEF, i, GEGBHOMKNDF.IHIABMJMDHE(list2[j])));
						}
					}
				}
				List<string> list3 = new List<string>();
				for (int k = 0; k < this.DLJBBDOEMLO.Count; k++)
				{
					if (!GEGBHOMKNDF.IBFMENAFKOD(this.DLJBBDOEMLO[k], 0, assetAnthology.header.index, FONDEKBAOGP.POJAPLKAJEF) || list.Contains(this.DLJBBDOEMLO[k]))
					{
						list3.Add(this.DLJBBDOEMLO[k]);
					}
				}
				this.DLJBBDOEMLO = list3;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0001A41C File Offset: 0x0001861C
	public void NANJJIAKLJM(int LLLCDMNPKFI)
	{
		if (this.PLLGPNGEHLL.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.PLLGPNGEHLL.Count; i++)
		{
			if (this.PLLGPNGEHLL[i].AsInt != LLLCDMNPKFI)
			{
				jsonarray.Add(this.PLLGPNGEHLL[i].AsInt);
			}
		}
		try
		{
			if (!this.PLLGPNGEHLL.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("liveprofilethemethumb");
				this.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.PLLGPNGEHLL = jsonarray;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00010954 File Offset: 0x0000EB54
	public void EKBICKBKHFI(JSONArray GBCKCDBOIPF)
	{
		this.LPIFCGOIENF = DPGJIJGOCIC.DDNFIDBDEGC(GBCKCDBOIPF);
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0001A4DC File Offset: 0x000186DC
	public bool OGNDGBOIPID()
	{
		return this.GOEDFBDNADA < 0.001f;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x0001A4EC File Offset: 0x000186EC
	public void AMBHHIEDAEG()
	{
		for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
		{
			for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j++)
			{
				this.NHMMPGOKAOL[i][j].DHONIOBOLEL.NJPFIIDIABG(0);
			}
		}
	}

	// Token: 0x06000378 RID: 888 RVA: 0x0001A53D File Offset: 0x0001873D
	public PLFDAJJHMKO HFBNIIHICBP(int CCLNHHJPDGJ = -1)
	{
		if (this.IEGJCPDCLMM < 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. GetActiveStory(), activeStory is negative.");
			return null;
		}
		return this.JDCBFAPDJIM(this.IEGJCPDCLMM, CCLNHHJPDGJ);
	}

	// Token: 0x06000379 RID: 889 RVA: 0x0001A561 File Offset: 0x00018761
	public long OHMJEABODIC()
	{
		return AKLFPGMDKLA.GNEJNLNHBMJ() + this.ILAIJIHFMGF;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x0001A570 File Offset: 0x00018770
	public double IFMHLDFOFJI()
	{
		return (DateTime.Now - this.MOINKAHNDKK).TotalSeconds;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x0001A595 File Offset: 0x00018795
	public bool CCBMHNGMFMC()
	{
		return this.OKGGLHOCENC != null && this.OKGGLHOCENC.AEDLLHMMIKB == 1;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x0001A5AF File Offset: 0x000187AF
	public int DHFJGFHBIOH(JFGBECHLPGI HFKKMPIFGBF)
	{
		if (HFKKMPIFGBF == JFGBECHLPGI.energy)
		{
			return this.MPMKMCJFHOG.GALKFKBPLCK() - this.EJEKPNHAABH.GALKFKBPLCK();
		}
		return this.ODMKLADKHMO.GALKFKBPLCK() - this.EAFDLIOEKCP.GALKFKBPLCK();
	}

	// Token: 0x0600037D RID: 893 RVA: 0x0001A5E4 File Offset: 0x000187E4
	private void HDGHOFKBOMM()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		for (int i = 0; i < this.DAPGFGNDIPG.Count; i++)
		{
			this.HKOBGOJEBPK.Add(this.DAPGFGNDIPG[i]);
			num3++;
			if (num3 >= 2)
			{
				break;
			}
		}
		do
		{
			if (num < this.FLEFJPNPHPN.Count)
			{
				this.PDDGOPCBPHE.Add(this.FLEFJPNPHPN[num]);
				this.HKOBGOJEBPK.Add(this.FLEFJPNPHPN[num]);
				num++;
				num6 = 0;
			}
			if (num % 4 == 0 && num6 == 0 && num2 < this.KJCFKLGMOKG.Count)
			{
				this.PDDGOPCBPHE.Add(this.KJCFKLGMOKG[num2]);
				this.HKOBGOJEBPK.Add(this.KJCFKLGMOKG[num2]);
				num2++;
				num6 = 0;
			}
			num6++;
		}
		while (num6 <= 10 && this.HKOBGOJEBPK.Count < 10);
		num6 = 0;
		do
		{
			if (num5 < 4)
			{
				if (num < this.FLEFJPNPHPN.Count)
				{
					this.PDDGOPCBPHE.Add(this.FLEFJPNPHPN[num]);
					this.HKOBGOJEBPK.Add(this.FLEFJPNPHPN[num]);
					num++;
					num6 = 0;
				}
			}
			else if (num5 < 6)
			{
				if (num2 < this.KJCFKLGMOKG.Count)
				{
					this.PDDGOPCBPHE.Add(this.KJCFKLGMOKG[num2]);
					this.HKOBGOJEBPK.Add(this.KJCFKLGMOKG[num2]);
					num2++;
					num6 = 0;
				}
			}
			else if (num5 < 8)
			{
				if (num3 < this.DAPGFGNDIPG.Count)
				{
					this.HKOBGOJEBPK.Add(this.DAPGFGNDIPG[num3]);
					num3++;
					num6 = 0;
				}
			}
			else if (num4 < this.IBKDIDKHCHO.Count)
			{
				this.HKOBGOJEBPK.Add(this.IBKDIDKHCHO[num4]);
				num4++;
				num6 = 0;
			}
			num5++;
			if (num5 >= 10)
			{
				num5 = 0;
			}
			num6++;
		}
		while (num6 <= 10);
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0001A804 File Offset: 0x00018A04
	public void IDPFOGHKMBL()
	{
		if (null != this.PGHADKMJMEM && this.PGHADKMJMEM.Count > 0)
		{
			int eedhneimapn = this.EEDHNEIMAPN;
			this.OELEMFGAOPH = true;
			this.IGODIFLIDOF(this.PGHADKMJMEM);
			this.FGJPKGLOGNC(this.PGHADKMJMEM, false, false);
			if (this.NKAMGBCGCPM)
			{
				this.DPIMKIDKOOI();
				this.NKAMGBCGCPM = false;
			}
			this.EEDHNEIMAPN = eedhneimapn;
			this.LPCBDEBKAIM();
		}
		this.PGHADKMJMEM = null;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0001A880 File Offset: 0x00018A80
	public bool BHIBEHFEFBM()
	{
		if (this.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true))
		{
			return false;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.gamePass, false);
		return kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0001A8B8 File Offset: 0x00018AB8
	public bool KNDMKJOHCHJ(OKAFAHMOFII OCEPECPOOGI)
	{
		if (this.HCEHBFCIIHN() < KBOJLHAJPCP.FMIKGCDCKCC)
		{
			return false;
		}
		if (OCEPECPOOGI.IACMODHPFKI.ODHBINFKIPL() > 0f)
		{
			return false;
		}
		int num = 0;
		for (int i = 0; i < this.KHOHDCKFNPJ.Count; i++)
		{
			if (this.KHOHDCKFNPJ[i].Equals(OCEPECPOOGI.KHPFAMAEPNA))
			{
				num++;
			}
		}
		return num < OCEPECPOOGI.BMHKMNHKIFH;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0001A92C File Offset: 0x00018B2C
	private JSONObject BNMFBKNEMIF(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		PlayerPrefs.SetFloat("svol", this.MEDEIJGNEMB);
		PlayerPrefs.SetFloat("sfxvol", this.GOEDFBDNADA);
		PlayerPrefs.SetFloat("voiceovervol", this.KPDKOKHHHOL);
		PlayerPrefs.SetInt("lsc", this.EGOCMDJBLNJ);
		PlayerPrefs.SetInt("inu", this.MJPKIMHENNF);
		PlayerPrefs.Save();
		if (this.EFENJAOHCIH.Length > 0)
		{
			jsonobject["luwid"] = this.EFENJAOHCIH;
		}
		if (this.HEFJBOKIEGH != 1)
		{
			jsonobject["not"] = this.HEFJBOKIEGH.ToString();
		}
		if (this.MEDFMIPBDFD != 0)
		{
			jsonobject["gpsasff"] = this.MEDFMIPBDFD;
		}
		if (this.AJLAADOFOLH != 0)
		{
			jsonobject["gpsasar"] = this.AJLAADOFOLH;
		}
		if (this.EKHACLPEIBJ != 0)
		{
			jsonobject["gpsasli"] = this.EKHACLPEIBJ;
		}
		if (this.IHMLBGPJKDO != 0)
		{
			jsonobject["gpsasst"] = this.IHMLBGPJKDO;
		}
		if (this.MDPMKICGGIJ != 0)
		{
			jsonobject["gpsfhs"] = this.MDPMKICGGIJ;
		}
		if (this.ENCEBEJPGPL != 0)
		{
			jsonobject["gpshub"] = this.ENCEBEJPGPL;
		}
		if (this.APLCOFLOAPA != 0)
		{
			jsonobject["clth"] = this.APLCOFLOAPA;
		}
		if (this.MCAGCFDCJID != 0)
		{
			jsonobject["clthc"] = this.MCAGCFDCJID;
		}
		if (this.EIDLACNLJJP != 0)
		{
			jsonobject["clthm"] = this.EIDLACNLJJP;
		}
		if (this.EPIBEOCFEGA != 0)
		{
			jsonobject["clthb"] = this.EPIBEOCFEGA;
		}
		if (this.HENCGDHCMIE != 0)
		{
			jsonobject["clthbr"] = this.HENCGDHCMIE;
		}
		if (this.DANIALBOJNN != 0)
		{
			jsonobject["clthcm"] = this.DANIALBOJNN;
		}
		if (this.PACMCEHMBGG != 1)
		{
			jsonobject["plc"] = this.PACMCEHMBGG.ToString();
		}
		if (this.POIEMMMNOLI != 1)
		{
			jsonobject["soci"] = this.POIEMMMNOLI.ToString();
		}
		if (this.EEDHNEIMAPN != 0)
		{
			jsonobject["sim"] = this.EEDHNEIMAPN.ToString();
		}
		int ojkhmneigpf = (int)this.OJKHMNEIGPF;
		jsonobject["ltt"] = ojkhmneigpf.ToString();
		int kedffdaaggp = (int)this.KEDFFDAAGGP;
		jsonobject["ltwt"] = kedffdaaggp.ToString();
		PlayerPrefs.SetInt("ltwt", (int)this.KEDFFDAAGGP);
		PlayerPrefs.Save();
		if (this.KFHJHOGCEOF != 0)
		{
			jsonobject["fdst"] = this.KFHJHOGCEOF.ToString();
		}
		if (this.COJFECEAKKI >= 0)
		{
			jsonobject["dceoiv"] = this.COJFECEAKKI.ToString();
		}
		if (this.KGDHECCPKOP >= 0)
		{
			jsonobject["dcenv"] = this.KGDHECCPKOP.ToString();
		}
		if (this.NAGCLLBIPGP != 0)
		{
			jsonobject["sac"] = this.NAGCLLBIPGP.ToString();
		}
		if (this.GGMNDJPGBOM != 0)
		{
			jsonobject["tbits"] = this.GGMNDJPGBOM.ToString();
		}
		if (this.EIIJAHNFADO != 0)
		{
			jsonobject["tbits2"] = this.EIIJAHNFADO.ToString();
		}
		if (this.HNHHBENEBEL != 0)
		{
			jsonobject["tbits3"] = this.HNHHBENEBEL.ToString();
		}
		if (this.ADCLBEPMMCG != JAMPPNPOJJG.full)
		{
			int adclbepmmcg = (int)this.ADCLBEPMMCG;
			jsonobject["gmmd"] = adclbepmmcg.ToString();
		}
		if (this.OOEJIIJLKPK != 0)
		{
			jsonobject["hqb"] = this.OOEJIIJLKPK.ToString();
		}
		if (this.OBBFGMHLMHO != 0)
		{
			jsonobject["iac"] = this.OBBFGMHLMHO.ToString();
		}
		if (this.PPBPBDLEKIG != 0)
		{
			jsonobject["chs"] = this.PPBPBDLEKIG.ToString();
		}
		if (this.LODJGIJMGAA != 0)
		{
			jsonobject["chc"] = this.LODJGIJMGAA.ToString();
		}
		if (!this.CLCKGDHDEFB())
		{
			int num = 0;
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
			{
				if (!DDLCOIHJKCJ)
				{
					if (this.MMIGJNDJGMF[i].IMALACBMOFC.Count > 0 && GKJPOGNFKNK.BKBCNMEHGFA(this.MMIGJNDJGMF[i].GGICIBLJIKI) >= 0)
					{
						PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(GKJPOGNFKNK.BKBCNMEHGFA(this.MMIGJNDJGMF[i].GGICIBLJIKI), 0);
						if (plfdajjhmko != null)
						{
							if (this.MMIGJNDJGMF[i].LHCHIHEAAJC != plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI)
							{
								this.MMIGJNDJGMF[i].LHCHIHEAAJC = plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI;
								plfdajjhmko.DHONIOBOLEL.NJPFIIDIABG(0);
							}
							plfdajjhmko.FPHDAKHOBMO.IMALACBMOFC = new List<string>(this.MMIGJNDJGMF[i].IMALACBMOFC);
							plfdajjhmko.FPHDAKHOBMO.GNHBHIALAAH = new List<int>(this.MMIGJNDJGMF[i].GNHBHIALAAH);
							if (plfdajjhmko.DHONIOBOLEL.KCKMIHMFNBH() == 0)
							{
								num += plfdajjhmko.FPHDAKHOBMO.IMALACBMOFC.Count;
							}
						}
					}
					if (this.MMIGJNDJGMF[i].KPEIEHDJIOP.Count > 0 && GKJPOGNFKNK.BKBCNMEHGFA(this.MMIGJNDJGMF[i].GGICIBLJIKI) >= 0)
					{
						PLFDAJJHMKO plfdajjhmko2 = this.PKNIPLDMJGG(GKJPOGNFKNK.BKBCNMEHGFA(this.MMIGJNDJGMF[i].GGICIBLJIKI), 0);
						if (plfdajjhmko2 != null)
						{
							if (this.MMIGJNDJGMF[i].LHCHIHEAAJC != plfdajjhmko2.DHONIOBOLEL.GGICIBLJIKI)
							{
								this.MMIGJNDJGMF[i].LHCHIHEAAJC = plfdajjhmko2.DHONIOBOLEL.GGICIBLJIKI;
								plfdajjhmko2.DHONIOBOLEL.NJPFIIDIABG(0);
							}
							plfdajjhmko2.FPHDAKHOBMO.KPEIEHDJIOP = new List<string>(this.MMIGJNDJGMF[i].KPEIEHDJIOP);
							plfdajjhmko2.FPHDAKHOBMO.JAJJFPNIBGI = new List<int>(this.MMIGJNDJGMF[i].JAJJFPNIBGI);
							if (plfdajjhmko2.DHONIOBOLEL.KCKMIHMFNBH() == 0)
							{
								num += plfdajjhmko2.FPHDAKHOBMO.KPEIEHDJIOP.Count;
							}
						}
					}
					if (this.MMIGJNDJGMF[i].NLPNFGNMGMP.Count > 0 && GKJPOGNFKNK.BKBCNMEHGFA(this.MMIGJNDJGMF[i].GGICIBLJIKI) >= 0)
					{
						PLFDAJJHMKO plfdajjhmko3 = this.PKNIPLDMJGG(GKJPOGNFKNK.BKBCNMEHGFA(this.MMIGJNDJGMF[i].GGICIBLJIKI), 0);
						if (plfdajjhmko3 != null)
						{
							if (this.MMIGJNDJGMF[i].LHCHIHEAAJC != plfdajjhmko3.DHONIOBOLEL.GGICIBLJIKI)
							{
								this.MMIGJNDJGMF[i].LHCHIHEAAJC = plfdajjhmko3.DHONIOBOLEL.GGICIBLJIKI;
								plfdajjhmko3.DHONIOBOLEL.NJPFIIDIABG(0);
							}
							plfdajjhmko3.FPHDAKHOBMO.NLPNFGNMGMP = new List<string>(this.MMIGJNDJGMF[i].NLPNFGNMGMP);
							plfdajjhmko3.FPHDAKHOBMO.FCOLLNPADDA = new List<int>(this.MMIGJNDJGMF[i].FCOLLNPADDA);
							if (plfdajjhmko3.DHONIOBOLEL.KCKMIHMFNBH() == 0)
							{
								num += plfdajjhmko3.FPHDAKHOBMO.NLPNFGNMGMP.Count;
							}
						}
					}
				}
				jsonarray.Add(this.MMIGJNDJGMF[i].BNMFBKNEMIF(DDLCOIHJKCJ));
			}
			jsonobject["ans"] = jsonarray;
			if (!DDLCOIHJKCJ)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Using new save system.");
				DPGJIJGOCIC.ADFCDFHBDAF("NEWSAVE: Account.ToJSONObject(), anthologies offloaded total components a->s:" + num.ToString());
			}
		}
		jsonobject["uid"] = this.EEHGLPEIIHD;
		if (DDLCOIHJKCJ)
		{
			jsonobject["psk"] = this.IPEMNDHJBHK;
			try
			{
				JSONObject jsonobject2 = new JSONObject();
				JSONArray jsonarray2 = new JSONArray();
				for (int j = 0; j < this.FKDMPMKBCBL.Count; j++)
				{
					JSONObject jsonobject3 = new JSONObject();
					jsonobject3.Add("per", this.FKDMPMKBCBL[j].BIBKFNMPHIK);
					jsonobject3.Add("nam", this.FKDMPMKBCBL[j].ODGNIFJGEHL);
					jsonobject3.Add("lck", this.FKDMPMKBCBL[j].MJKICDJIFIP);
					jsonobject3.Add("spr", this.FKDMPMKBCBL[j].PFFCLABCNHI);
					jsonarray2.Add(jsonobject3);
				}
				jsonobject2.Add("tm", jsonarray2);
				JSONArray jsonarray3 = new JSONArray();
				for (int k = 0; k < this.IOEACDCKKID.Count; k++)
				{
					JSONObject jsonobject4 = new JSONObject();
					jsonobject4.Add("per", this.IOEACDCKKID[k].BIBKFNMPHIK);
					jsonobject4.Add("nam", this.IOEACDCKKID[k].ODGNIFJGEHL);
					jsonobject4.Add("lck", this.IOEACDCKKID[k].MJKICDJIFIP);
					jsonobject4.Add("spr", this.IOEACDCKKID[k].PFFCLABCNHI);
					jsonarray3.Add(jsonobject4);
				}
				jsonobject2.Add("tmo", jsonarray3);
				jsonobject["tmd"] = jsonobject2;
				JSONObject jsonobject5 = new JSONObject();
				JSONArray jsonarray4 = new JSONArray();
				for (int l = 0; l < this.MEFNCEJHMIF.Count; l++)
				{
					JSONObject jsonobject6 = new JSONObject();
					jsonobject6.Add("per", this.MEFNCEJHMIF[l].BIBKFNMPHIK);
					jsonobject6.Add("nam", this.MEFNCEJHMIF[l].ODGNIFJGEHL);
					jsonobject6.Add("lck", this.MEFNCEJHMIF[l].MJKICDJIFIP);
					jsonobject6.Add("spr", this.MEFNCEJHMIF[l].PFFCLABCNHI);
					jsonarray4.Add(jsonobject6);
				}
				jsonobject5.Add("tmp", jsonarray4);
				JSONArray jsonarray5 = new JSONArray();
				for (int m = 0; m < this.DDCKJCAOJHO.Count; m++)
				{
					JSONObject jsonobject7 = new JSONObject();
					jsonobject7.Add("per", this.DDCKJCAOJHO[m].BIBKFNMPHIK);
					jsonobject7.Add("nam", this.DDCKJCAOJHO[m].ODGNIFJGEHL);
					jsonobject7.Add("lck", this.DDCKJCAOJHO[m].MJKICDJIFIP);
					jsonobject7.Add("spr", this.DDCKJCAOJHO[m].PFFCLABCNHI);
					jsonarray5.Add(jsonobject7);
				}
				jsonobject5.Add("tmop", jsonarray5);
				jsonobject["tmdp"] = jsonobject5;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		jsonobject["did"] = DPGJIJGOCIC.PPIAAAIOMBE();
		jsonobject["oid"] = this.KCIPIBCMBPB();
		jsonobject["acts"] = this.IEGJCPDCLMM.ToString();
		jsonobject["actsh"] = this.GLKNOFHEBKN.ToString();
		jsonobject["actant"] = this.EJLCEBPHPJE.ToString();
		if (this.NFNKBNGDAIP.Count > 0)
		{
			JSONArray jsonarray6 = new JSONArray();
			for (int n = 0; n < this.NFNKBNGDAIP.Count; n++)
			{
				jsonarray6.Add(this.NFNKBNGDAIP[n].ToString());
			}
			jsonobject["actshl"] = jsonarray6;
		}
		if (this.DGBOBDAFHGC.Count > 0)
		{
			JSONArray jsonarray7 = new JSONArray();
			for (int num2 = 0; num2 < this.DGBOBDAFHGC.Count; num2++)
			{
				jsonarray7.Add(this.DGBOBDAFHGC[num2].ToString());
			}
			jsonobject["actshlv2"] = jsonarray7;
		}
		if (this.HLCHHIIOLOL.Count > 0)
		{
			JSONArray jsonarray8 = new JSONArray();
			for (int num3 = 0; num3 < this.HLCHHIIOLOL.Count; num3++)
			{
				jsonarray8.Add(this.HLCHHIIOLOL[num3].ToString());
			}
			jsonobject["sraogv2"] = jsonarray8;
		}
		if (this.KINBCPBEAMI.Count > 0)
		{
			JSONArray jsonarray9 = new JSONArray();
			for (int num4 = 0; num4 < this.KINBCPBEAMI.Count; num4++)
			{
				jsonarray9.Add(this.KINBCPBEAMI[num4].ToString());
			}
			jsonobject["fah"] = jsonarray9;
		}
		if (this.KHOHDCKFNPJ.Count > 0)
		{
			JSONArray jsonarray10 = new JSONArray();
			for (int num5 = 0; num5 < this.KHOHDCKFNPJ.Count; num5++)
			{
				jsonarray10.Add(this.KHOHDCKFNPJ[num5].ToString());
			}
			jsonobject["flehv2"] = jsonarray10;
		}
		if (this.NKGJLFEGGEL.Count > 0)
		{
			JSONArray jsonarray11 = new JSONArray();
			for (int num6 = 0; num6 < this.NKGJLFEGGEL.Count; num6++)
			{
				jsonarray11.Add(this.NKGJLFEGGEL[num6].ToString());
			}
			jsonobject["sloh"] = jsonarray11;
		}
		if (this.LINEPLBMFNF.Count > 0)
		{
			JSONArray jsonarray12 = new JSONArray();
			for (int num7 = 0; num7 < this.LINEPLBMFNF.Count; num7++)
			{
				jsonarray12.Add(this.LINEPLBMFNF[num7].ToString());
			}
			jsonobject["igeh"] = jsonarray12;
		}
		if (this.KNDLFMMJFMK.Count > 0)
		{
			JSONArray jsonarray13 = new JSONArray();
			for (int num8 = 0; num8 < this.KNDLFMMJFMK.Count; num8++)
			{
				jsonarray13.Add(this.KNDLFMMJFMK[num8]);
			}
			jsonobject["fsharv2"] = jsonarray13;
		}
		if (this.OFNHOICCBAM.Count > 0)
		{
			JSONArray jsonarray14 = new JSONArray();
			for (int num9 = 0; num9 < this.OFNHOICCBAM.Count; num9++)
			{
				jsonarray14.Add(this.OFNHOICCBAM[num9].ToString());
			}
			jsonobject["usyncs"] = jsonarray14;
		}
		if (DDLCOIHJKCJ && this.CEKAJNFMIKL.Count > 0)
		{
			jsonobject.Add("usynsnap2", DPGJIJGOCIC.EEIMLELMKJC(this.CEKAJNFMIKL, 256));
		}
		if (DDLCOIHJKCJ && this.DLJBBDOEMLO.Count > 0)
		{
			jsonobject.Add("usyncoll2", DPGJIJGOCIC.EEIMLELMKJC(this.DLJBBDOEMLO, 1024));
		}
		if (this.GFDMIHHNFDA.Length > 0)
		{
			jsonobject["usynach"] = this.GFDMIHHNFDA;
		}
		if (this.OCMDGMFAMJB.Length > 0)
		{
			jsonobject["usynachtk"] = this.OCMDGMFAMJB;
		}
		if (this.MLEBKAIHGIO.Length > 0)
		{
			jsonobject["lksuid"] = this.MLEBKAIHGIO;
		}
		if (this.KAOAFBOEPFD.Length > 0)
		{
			jsonobject["repsuid"] = this.KAOAFBOEPFD;
		}
		if (this.PLLGPNGEHLL.Count > 0)
		{
			jsonobject["wshcds"] = this.PLLGPNGEHLL;
		}
		if (this.FCJJDEKOIED.Count > 0)
		{
			jsonobject["tdgcds"] = this.FCJJDEKOIED;
		}
		for (int num10 = 0; num10 < this.NHMMPGOKAOL.Length; num10++)
		{
			JSONArray jsonarray15 = new JSONArray();
			for (int num11 = 0; num11 < this.NHMMPGOKAOL[num10].Count; num11++)
			{
				jsonarray15.Add(this.NHMMPGOKAOL[num10][num11].BNMFBKNEMIF(DDLCOIHJKCJ));
			}
			if (num10 == 0)
			{
				jsonobject["sto"] = jsonarray15;
			}
			else if (jsonarray15.Count > 0)
			{
				jsonobject["sto" + num10.ToString()] = jsonarray15;
			}
		}
		jsonobject["instd"] = this.EPFIHIAKPIH.Ticks.ToString();
		jsonobject["ratd"] = this.EOOBBNJEEOG.Ticks.ToString();
		jsonobject["llosd"] = this.MOINKAHNDKK.Ticks.ToString();
		jsonobject["spppd"] = this.NEBCFBIEIFK.Ticks.ToString();
		return jsonobject;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x0001BB2C File Offset: 0x00019D2C
	public void KLCFCINBMAP(long CPKJHMEOPMK)
	{
		if (CPKJHMEOPMK <= 0L)
		{
			return;
		}
		this.ILAIJIHFMGF = CPKJHMEOPMK - AKLFPGMDKLA.CMJOLLCMKKH();
		this.GIIJKGFONNN = true;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x0001BB48 File Offset: 0x00019D48
	public void LNEPJBGFEBG(JSONArray KEGBCGMJOLC)
	{
		this.EJGCCKMDDLG = new List<string>();
		this.AONCINPNHDD = new List<PMEPALPCEAF>();
		try
		{
			for (int i = KEGBCGMJOLC.Count - 1; i >= 0; i--)
			{
				try
				{
					JSONObject asObject = KEGBCGMJOLC[i].AsObject;
					asObject.Add("rand", 1);
					PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
					pmepalpceaf.GEPIBACNKIP(asObject, AKLFPGMDKLA.IKLAPGJDMNA.OKGGLHOCENC);
					if (pmepalpceaf.EEBMPDNLJGD.Length > 0 && !this.EJGCCKMDDLG.Contains(pmepalpceaf.EEBMPDNLJGD))
					{
						this.AONCINPNHDD.Add(pmepalpceaf);
						this.EJGCCKMDDLG.Add(pmepalpceaf.EEBMPDNLJGD);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06000384 RID: 900 RVA: 0x0001BC28 File Offset: 0x00019E28
	public void LNNOANMGOIH(int PLKMJJIIJNO)
	{
		if (this.KINBCPBEAMI.Count > 39)
		{
			this.KINBCPBEAMI.RemoveAt(0);
		}
		this.KINBCPBEAMI.Add(PLKMJJIIJNO);
	}

	// Token: 0x06000385 RID: 901 RVA: 0x0001BC54 File Offset: 0x00019E54
	public List<int> IGLLOABLMGM(List<AssetAnthology> INFNBHLFANB)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i += 0)
		{
			if (this.MMIGJNDJGMF[i].EHGPKIGKPLI > 0)
			{
				for (int j = 0; j < INFNBHLFANB.Count; j += 0)
				{
					if (null != INFNBHLFANB[j] && INFNBHLFANB[j].header.index == this.MMIGJNDJGMF[i].GGICIBLJIKI)
					{
						list.Add(this.MMIGJNDJGMF[i].GGICIBLJIKI);
						break;
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00012517 File Offset: 0x00010717
	public long CDNGHFCPPEA()
	{
		return AKLFPGMDKLA.ANFPJEAHEAH() + this.ILAIJIHFMGF;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0001BCF2 File Offset: 0x00019EF2
	public static int ACFJMCBMOFG(int NLLCKPCKGOH, int NLBDCCLPFAL)
	{
		return NLBDCCLPFAL * 1000000 + NLLCKPCKGOH;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0001BD00 File Offset: 0x00019F00
	public List<int> PEGAFBPLFFJ(List<int> HBBJBNJBMPK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.KGHMOKADNKK.Count; i++)
		{
			if (HBBJBNJBMPK.Contains(this.KGHMOKADNKK[i]) && !list.Contains(this.KGHMOKADNKK[i]))
			{
				list.Add(this.KGHMOKADNKK[i]);
			}
		}
		return list;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x0001BD64 File Offset: 0x00019F64
	public void OIHPBIMHKLC(PLFDAJJHMKO DIHOMBCIJPN)
	{
		if (DIHOMBCIJPN == null || this.DLJBBDOEMLO.Count == 0)
		{
			return;
		}
		AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(DIHOMBCIJPN.DHONIOBOLEL.GGICIBLJIKI, false);
		try
		{
			if (null != assetAnthology)
			{
				List<string> list = new List<string>();
				for (int i = 1; i < this.DLJBBDOEMLO.Count; i++)
				{
					if (!GEGBHOMKNDF.IBFMENAFKOD(this.DLJBBDOEMLO[i], 0, assetAnthology.header.index, DIHOMBCIJPN.POJAPLKAJEF))
					{
						list.Add(this.DLJBBDOEMLO[i]);
					}
				}
				this.DLJBBDOEMLO = list;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0001BE10 File Offset: 0x0001A010
	public static int GMFFMLHMLKM(int PLKMJJIIJNO)
	{
		return PLKMJJIIJNO / 100000;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x0001BE1C File Offset: 0x0001A01C
	private static void NFFHLIHJLAH(JSONNode EAOALLJIGFI, int CCLNHHJPDGJ)
	{
		if (EAOALLJIGFI == null)
		{
			return;
		}
		if (EAOALLJIGFI.IsObject)
		{
			if (EAOALLJIGFI["\nINK:"] != null && EAOALLJIGFI["energyhinttitle"] != null)
			{
				EAOALLJIGFI["lsn"] = CCLNHHJPDGJ;
				EAOALLJIGFI.Remove("");
				EAOALLJIGFI.Remove("@");
				JSONNode jsonnode = EAOALLJIGFI["SceneLobbyManager2.GetStarterGroups() - "];
				JSONNode jsonnode2 = EAOALLJIGFI["OnFriendsPlusUnlockContinueToPurchasingScreen"];
				if (jsonnode2.IsObject)
				{
					jsonnode2.Remove("importanttitle");
					jsonnode2.Remove(" (");
					jsonnode2.Remove("XXX");
					jsonnode2.Remove("ok");
					jsonnode2.Remove("");
				}
				if (jsonnode.IsObject)
				{
					jsonnode.Remove("energyhinttitle");
					jsonnode.Remove("OnBackendGetSketchesBalanceSuccess");
					jsonnode.Remove("ZZZ");
					jsonnode.Remove("SkinShopItem");
					jsonnode.Remove("OnLobbySkinShopCdnFailed");
					jsonnode.Remove("");
					jsonnode.Remove("discount");
				}
			}
			for (int i = 1; i < EAOALLJIGFI.Count; i++)
			{
				AKLFPGMDKLA.NFFHLIHJLAH(EAOALLJIGFI[i], CCLNHHJPDGJ);
			}
			return;
		}
		if (EAOALLJIGFI.IsArray)
		{
			for (int j = 1; j < EAOALLJIGFI.Count; j += 0)
			{
				AKLFPGMDKLA.FOFIKOAKBBL(EAOALLJIGFI[j], CCLNHHJPDGJ);
			}
		}
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00011367 File Offset: 0x0000F567
	public bool CNCPKMJHHAJ(GDOKLFCLLIK FMLFLGJLDHD)
	{
		return this.NKGJLFEGGEL.Contains(FMLFLGJLDHD.HDOFHMEDKEA);
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0001BF90 File Offset: 0x0001A190
	private void MPGIOICOIPI()
	{
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		int num4 = 1;
		int num5 = 0;
		int num6 = 0;
		for (int i = 1; i < this.DAPGFGNDIPG.Count; i++)
		{
			this.HKOBGOJEBPK.Add(this.DAPGFGNDIPG[i]);
			num3++;
			if (num3 >= 1)
			{
				break;
			}
		}
		do
		{
			if (num < this.FLEFJPNPHPN.Count)
			{
				this.PDDGOPCBPHE.Add(this.FLEFJPNPHPN[num]);
				this.HKOBGOJEBPK.Add(this.FLEFJPNPHPN[num]);
				num++;
				num6 = 0;
			}
			if (num % 8 == 0 && num6 == 0 && num2 < this.KJCFKLGMOKG.Count)
			{
				this.PDDGOPCBPHE.Add(this.KJCFKLGMOKG[num2]);
				this.HKOBGOJEBPK.Add(this.KJCFKLGMOKG[num2]);
				num2 += 0;
				num6 = 0;
			}
			num6 += 0;
		}
		while (num6 <= 0 && this.HKOBGOJEBPK.Count < -97);
		num6 = 0;
		do
		{
			if (num5 < 1)
			{
				if (num < this.FLEFJPNPHPN.Count)
				{
					this.PDDGOPCBPHE.Add(this.FLEFJPNPHPN[num]);
					this.HKOBGOJEBPK.Add(this.FLEFJPNPHPN[num]);
					num++;
					num6 = 1;
				}
			}
			else if (num5 < 1)
			{
				if (num2 < this.KJCFKLGMOKG.Count)
				{
					this.PDDGOPCBPHE.Add(this.KJCFKLGMOKG[num2]);
					this.HKOBGOJEBPK.Add(this.KJCFKLGMOKG[num2]);
					num2++;
					num6 = 0;
				}
			}
			else if (num5 < 2)
			{
				if (num3 < this.DAPGFGNDIPG.Count)
				{
					this.HKOBGOJEBPK.Add(this.DAPGFGNDIPG[num3]);
					num3++;
					num6 = 0;
				}
			}
			else if (num4 < this.IBKDIDKHCHO.Count)
			{
				this.HKOBGOJEBPK.Add(this.IBKDIDKHCHO[num4]);
				num4++;
				num6 = 0;
			}
			num5++;
			if (num5 >= -33)
			{
				num5 = 0;
			}
			num6++;
		}
		while (num6 <= -113);
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
	public bool NCPPKEGJPKC()
	{
		if (this.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true))
		{
			return true;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		return kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1;
	}

	// Token: 0x0600038F RID: 911 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
	public APNIHJMGNIM GKNBOCPKMDM(int PLKMJJIIJNO)
	{
		APNIHJMGNIM apnihjmgnim = new APNIHJMGNIM();
		try
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
			if (null == assetAnthology || null == assetAnthology.header)
			{
				return apnihjmgnim;
			}
			EIOPLEFLLIM eioplefllim = this.GJBDBONJCDL(PLKMJJIIJNO);
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
			{
				int num = assetAnthology.header.availableStories[i];
				AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(num);
				int num2 = (null != assetStoryHeader) ? assetStoryHeader.totalChaptersCount : 0;
				bool flag = false;
				int num3 = -1;
				int num4 = -1;
				if (eioplefllim != null && num2 > 0)
				{
					for (int j = 0; j < 10; j++)
					{
						if (eioplefllim.EGHHCFFLPCP(j) > i)
						{
							flag = true;
							num3 = Math.Max(num3, num2 - 1);
							num4 = Math.Max(num4, num2);
						}
					}
				}
				for (int k = 0; k < this.NHMMPGOKAOL.Length; k++)
				{
					for (int l = 0; l < this.NHMMPGOKAOL[k].Count; l++)
					{
						if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.GGICIBLJIKI == num)
						{
							int num5 = -1;
							for (int m = 0; m < 31; m++)
							{
								if (DPGJIJGOCIC.CCLEJFEFBJM(this.NHMMPGOKAOL[k][l].DHONIOBOLEL.IMLEDFIDHDL, m))
								{
									num5 = m;
								}
							}
							if (num5 >= 0)
							{
								flag = true;
								num3 = Math.Max(num3, num5);
								num4 = Math.Max(num4, num5 + 1);
							}
							if (this.NHMMPGOKAOL[k][l].DHONIOBOLEL.LKIKEHFANBO[0] >= 0)
							{
								flag = true;
								num3 = Math.Max(num3, this.NHMMPGOKAOL[k][l].DHONIOBOLEL.LKIKEHFANBO[0]);
								num4 = Math.Max(num4, this.NHMMPGOKAOL[k][l].DHONIOBOLEL.DDEDAHCFHJN());
							}
						}
					}
				}
				if (flag)
				{
					apnihjmgnim.MEAPPCCOEFL = true;
					apnihjmgnim.MIBPOIDDBAD = i;
					apnihjmgnim.IFCHGNCDMLJ = num;
					apnihjmgnim.KKCKKEDJADB = num3;
					apnihjmgnim.OKOEFPFGEFO = Math.Max(0, num4);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return apnihjmgnim;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x0001C448 File Offset: 0x0001A648
	public int PBGIIOFDLND()
	{
		return 0 + this.BNGHKCHKMPB / -126;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0001C458 File Offset: 0x0001A658
	public void NIBNLDPFEFG(int LLLCDMNPKFI)
	{
		if (this.PLLGPNGEHLL.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.PLLGPNGEHLL.Count; i += 0)
		{
			if (this.PLLGPNGEHLL[i].AsInt != LLLCDMNPKFI)
			{
				jsonarray.Add(this.PLLGPNGEHLL[i].AsInt);
			}
		}
		try
		{
			if (!this.PLLGPNGEHLL.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.CMGOAFDBAOH("trinket");
				this.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.PLLGPNGEHLL = jsonarray;
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0001C518 File Offset: 0x0001A718
	public bool JLNAMEBGOLB()
	{
		return this.GOEDFBDNADA < 1726f;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x0001C528 File Offset: 0x0001A728
	public double PEPMKPPBOJD()
	{
		return (DateTime.Now - this.EPFIHIAKPIH).TotalSeconds;
	}

	// Token: 0x06000394 RID: 916 RVA: 0x0001C550 File Offset: 0x0001A750
	public void JMEMHOGKKCP(JSONObject HEEKMAFFDDN)
	{
		if (null != HEEKMAFFDDN)
		{
			this.BJIDACANAJH = HEEKMAFFDDN["e"].AsInt;
			this.PNNHDJFBHOL = HEEKMAFFDDN["h"].AsInt;
			this.DBJMOAOBHKE = HEEKMAFFDDN["drs"].AsInt;
			return;
		}
		this.BJIDACANAJH = -1;
		this.PNNHDJFBHOL = -1;
		this.DBJMOAOBHKE = -1;
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0001C5BE File Offset: 0x0001A7BE
	public void HDCJELAIOCH()
	{
		this.HLCHHIIOLOL.Clear();
	}

	// Token: 0x06000396 RID: 918 RVA: 0x0001C5CC File Offset: 0x0001A7CC
	public void PFCCNPIPPPO()
	{
		if (this.PLLGPNGEHLL.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.PLLGPNGEHLL.Count; i++)
		{
			if (!this.KGHMOKADNKK.Contains(this.PLLGPNGEHLL[i].AsInt) && !DPGJIJGOCIC.IADAELPFJAM(jsonarray, this.PLLGPNGEHLL[i].AsInt))
			{
				jsonarray.Add(this.PLLGPNGEHLL[i].AsInt);
			}
		}
		try
		{
			if (!this.PLLGPNGEHLL.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("Trading/Wished cards userPublicProfile.modified = true hit");
				this.OKGGLHOCENC.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.PLLGPNGEHLL = jsonarray;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
	public void HOBAOJMIPBC()
	{
		this.NEBCFBIEIFK = DateTime.Now;
	}

	// Token: 0x06000398 RID: 920 RVA: 0x0001C6BD File Offset: 0x0001A8BD
	public static int JENCMOBBJPA(int PLKMJJIIJNO)
	{
		return PLKMJJIIJNO % 100000;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
	public bool MPLENGHOJAC(int PLKMJJIIJNO, IJLJDFKJIJM ANNIMFJMPGG)
	{
		if (ANNIMFJMPGG == null)
		{
			return false;
		}
		int num = 0;
		for (int i = 0; i < this.KINBCPBEAMI.Count; i++)
		{
			if (this.KINBCPBEAMI[i] == PLKMJJIIJNO)
			{
				num++;
			}
		}
		return num < ANNIMFJMPGG.BMHKMNHKIFH;
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0001C714 File Offset: 0x0001A914
	public EIOPLEFLLIM LMGMHHLLOFN(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
		{
			if (this.MMIGJNDJGMF[i].GGICIBLJIKI == PLKMJJIIJNO)
			{
				return this.MMIGJNDJGMF[i];
			}
		}
		EIOPLEFLLIM eioplefllim = new EIOPLEFLLIM();
		eioplefllim.GGICIBLJIKI = PLKMJJIIJNO;
		this.MMIGJNDJGMF.Add(eioplefllim);
		return eioplefllim;
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0001C774 File Offset: 0x0001A974
	public List<int> CEAOAFBKNAP(List<AssetAnthology> MPHDAOEJOCL)
	{
		List<int> list = this.JCDKHPGLOMK(MPHDAOEJOCL);
		List<int> list2 = new List<int>();
		try
		{
			for (int i = 0; i < this.JBBAANGAFKO.Count; i++)
			{
				if (list.Contains(this.JBBAANGAFKO[i]))
				{
					list2.Add(this.JBBAANGAFKO[i]);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.SRAGetFullyReleasedAnthologiesAndNeverFinishedAndWithProgress(), exception:" + ex.ToString());
		}
		return list2;
	}

	// Token: 0x0600039C RID: 924 RVA: 0x0001C7F8 File Offset: 0x0001A9F8
	public List<int> JCBEPJJHAII(List<AssetAnthology> INFNBHLFANB)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.MMIGJNDJGMF.Count; i++)
		{
			if (this.MMIGJNDJGMF[i].EHGPKIGKPLI > 0)
			{
				for (int j = 0; j < INFNBHLFANB.Count; j++)
				{
					if (null != INFNBHLFANB[j] && INFNBHLFANB[j].header.index == this.MMIGJNDJGMF[i].GGICIBLJIKI)
					{
						list.Add(this.MMIGJNDJGMF[i].GGICIBLJIKI);
						break;
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0001C898 File Offset: 0x0001AA98
	public void DGAEIEOHBIJ(List<IMMKFHKEEBF> KBICBCBAFJJ, List<IMMKFHKEEBF> NGJGBKAHGEN)
	{
		try
		{
			if (KBICBCBAFJJ != null && KBICBCBAFJJ.Count > 1)
			{
				this.MEFNCEJHMIF = KBICBCBAFJJ.GetRange(0, KBICBCBAFJJ.Count);
			}
			else
			{
				this.MEFNCEJHMIF = new List<IMMKFHKEEBF>();
			}
			if (NGJGBKAHGEN != null && NGJGBKAHGEN.Count > 0)
			{
				this.DDCKJCAOJHO = NGJGBKAHGEN.GetRange(1, NGJGBKAHGEN.Count);
			}
			else
			{
				this.DDCKJCAOJHO = new List<IMMKFHKEEBF>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00010814 File Offset: 0x0000EA14
	public void IJHHMHAEKKE()
	{
		PlayerPrefs.DeleteAll();
		PlayerPrefs.Save();
		MDDHDDPKFJH.EPJKDCDOEMM();
		NIDOKPOOIHH.EPJKDCDOEMM();
		SaveSlotsItem.ClearCopyMarker();
		AKLFPGMDKLA.IKLAPGJDMNA = new AKLFPGMDKLA();
		AKLFPGMDKLA.IKLAPGJDMNA.LPCBDEBKAIM();
	}

	// Token: 0x0600039F RID: 927 RVA: 0x0001C918 File Offset: 0x0001AB18
	public static int MIEODKAHNAO(int PLKMJJIIJNO)
	{
		return PLKMJJIIJNO / -174;
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x0001C921 File Offset: 0x0001AB21
	public bool DHHNMAEABFI()
	{
		return this.HLCHHIIOLOL.Count > 0;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x0001C931 File Offset: 0x0001AB31
	public static int AHCKADPCNPB(int PLKMJJIIJNO)
	{
		return PLKMJJIIJNO / -108;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0001C93C File Offset: 0x0001AB3C
	public bool GNALDALIFJL(OKAFAHMOFII OCEPECPOOGI)
	{
		if (this.HCEHBFCIIHN() < KBOJLHAJPCP.FMIKGCDCKCC)
		{
			return false;
		}
		if (OCEPECPOOGI.IACMODHPFKI.GLAPKLGPCKE() > 821f)
		{
			return true;
		}
		int num = 1;
		for (int i = 1; i < this.KHOHDCKFNPJ.Count; i += 0)
		{
			if (this.KHOHDCKFNPJ[i].Equals(OCEPECPOOGI.KHPFAMAEPNA))
			{
				num++;
			}
		}
		return num < OCEPECPOOGI.BMHKMNHKIFH;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
	public void ABHHJEEFODI()
	{
		if (this.FCJJDEKOIED.Count == 0)
		{
			return;
		}
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.FCJJDEKOIED.Count; i++)
		{
			if (this.CPKFFFLFMMD.Contains(this.FCJJDEKOIED[i].AsInt) && !DPGJIJGOCIC.BHGIEMBKFEA(jsonarray, this.FCJJDEKOIED[i].AsInt))
			{
				jsonarray.Add(this.FCJJDEKOIED[i].AsInt);
			}
		}
		try
		{
			if (!this.FCJJDEKOIED.ToString().Equals(jsonarray.ToString()) && this.OKGGLHOCENC != null)
			{
				DPGJIJGOCIC.CMGOAFDBAOH("congratstitle");
				this.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.FCJJDEKOIED = jsonarray;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0001CA94 File Offset: 0x0001AC94
	public void KIDGOPBAGHN()
	{
		this.DLCPABCHIDK.Clear();
		this.EINPKOJBCGA.Clear();
		this.JBBAANGAFKO.Clear();
		this.DAPGFGNDIPG.Clear();
		this.JINPALBNFHH.Clear();
		this.IBKDIDKHCHO.Clear();
		this.AILMCODLLCE.Clear();
		this.FLEFJPNPHPN.Clear();
		this.KJCFKLGMOKG.Clear();
		this.PDDGOPCBPHE.Clear();
		this.HKOBGOJEBPK.Clear();
		this.DFACBPKFCOM.Clear();
		this.MPIKPDLCLHG.Clear();
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0001CB30 File Offset: 0x0001AD30
	public JSONArray JOKIEEMBKOA(int KBGHGCLLMGF)
	{
		JSONArray jsonarray = new JSONArray();
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null)
		{
			int num = KBGHGCLLMGF;
			if (GeoLocationManager.IsRussia())
			{
				num = KBGHGCLLMGF / 4;
			}
			int num2 = 0;
			int num3 = 0;
			while (num3 < this.CEKAJNFMIKL.Count && num2 < num)
			{
				JSONObject jsonobject = new JSONObject();
				try
				{
					if (AKLOMMOOFNG.CLCGKMNEICM("Snapshots/" + this.CEKAJNFMIKL[num3]))
					{
						string text = AKLOMMOOFNG.DJGJKOOOFEA("Snapshots/" + this.CEKAJNFMIKL[num3]);
						if (text != null && text.Length > 0)
						{
							JSONObject jsonobject2 = (JSONObject)JSON.Parse(text);
							if (null != jsonobject2)
							{
								jsonobject.Add("name", this.CEKAJNFMIKL[num3]);
								jsonobject.Add("json", jsonobject2);
								int num4 = PLFDAJJHMKO.KFLMEOECGGP(this.CEKAJNFMIKL[num3]);
								int num5 = PLFDAJJHMKO.NIIPCPEONGN(this.CEKAJNFMIKL[num3]);
								int num6 = PLFDAJJHMKO.OOPGAJPCEPB(this.CEKAJNFMIKL[num3]);
								AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(num4, false);
								int num7 = -1;
								if (null != assetAnthology)
								{
									for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
									{
										if (assetAnthology.header.availableStories[i] == num4)
										{
											num7 = i;
											break;
										}
									}
								}
								if (null != assetAnthology && num4 >= 0 && num5 >= 0 && num6 >= 0 && num7 >= 0)
								{
									jsonobject.Add("aind", assetAnthology.header.index);
									jsonobject.Add("sind", num4);
									jsonobject.Add("ssnind", num7);
									jsonobject.Add("cind", num5);
									jsonobject.Add("sltind", num6);
									jsonarray.Add(jsonobject);
									num2++;
								}
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				num3++;
			}
		}
		return jsonarray;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x0001CD6C File Offset: 0x0001AF6C
	public PLFDAJJHMKO FNFLJMLNCKK(int NLLCKPCKGOH, int FIFPKAGANHA, int ICKJPFOLJNF)
	{
		if (FIFPKAGANHA < 1 || FIFPKAGANHA > this.NHMMPGOKAOL.Length - 0 || ICKJPFOLJNF < 0 || ICKJPFOLJNF > this.NHMMPGOKAOL.Length - 1)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("MonitorAndKillInfiniteRequest() - lastCallbackObj is null!" + FIFPKAGANHA.ToString() + "OnPremiumChoiceExecutedHardBased" + ICKJPFOLJNF.ToString());
			return null;
		}
		if (FIFPKAGANHA == ICKJPFOLJNF)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("" + FIFPKAGANHA.ToString());
			return null;
		}
		PLFDAJJHMKO plfdajjhmko = this.PKNIPLDMJGG(NLLCKPCKGOH, FIFPKAGANHA);
		if (plfdajjhmko == null)
		{
			return null;
		}
		PLFDAJJHMKO result;
		try
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(plfdajjhmko.BNMFBKNEMIF(false).ToString());
			if (jsonobject == null)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("preview" + NLLCKPCKGOH.ToString());
				result = null;
			}
			else
			{
				AKLFPGMDKLA.FOFIKOAKBBL(jsonobject, ICKJPFOLJNF);
				PLFDAJJHMKO plfdajjhmko2 = new PLFDAJJHMKO(jsonobject, false);
				plfdajjhmko2.POJAPLKAJEF = ICKJPFOLJNF;
				plfdajjhmko2.KIHACLLJMDH.Clear();
				plfdajjhmko2.JJEONBFFBHP.Clear();
				plfdajjhmko2.NCAMFPGMCIG.PNBPEAFMKAC.Clear();
				plfdajjhmko2.NCAMFPGMCIG.DMKOGCBMHKA.Clear();
				plfdajjhmko2.NCAMFPGMCIG.NGJDCAEMEJO.Clear();
				plfdajjhmko2.NCAMFPGMCIG.KAKPOCFHGCC = 0;
				plfdajjhmko2.NCAMFPGMCIG.JFBCFLININB = 1;
				plfdajjhmko2.NCAMFPGMCIG.GEGFLAPCGAI = 0;
				plfdajjhmko2.PPBDMCOPPPD();
				bool flag = true;
				for (int i = 1; i < this.NHMMPGOKAOL[ICKJPFOLJNF].Count; i++)
				{
					if (this.NHMMPGOKAOL[ICKJPFOLJNF][i].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH)
					{
						plfdajjhmko2.DHONIOBOLEL.IMLEDFIDHDL = (plfdajjhmko2.DHONIOBOLEL.IMLEDFIDHDL | this.NHMMPGOKAOL[ICKJPFOLJNF][i].DHONIOBOLEL.IMLEDFIDHDL);
						this.NHMMPGOKAOL[ICKJPFOLJNF][i] = plfdajjhmko2;
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					this.NHMMPGOKAOL[ICKJPFOLJNF].Add(plfdajjhmko2);
				}
				this.EBNJHPICFGE(plfdajjhmko2, 0);
				plfdajjhmko.PFHCDMOJOKP();
				result = plfdajjhmko2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0001CF78 File Offset: 0x0001B178
	public void IGDFOFLIAIC()
	{
		try
		{
			AKLOMMOOFNG.GBICPNAPGNK("Snapshots");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0001CFAC File Offset: 0x0001B1AC
	public void KCEOCFNHABG(JSONArray CDEKICFPBGL)
	{
		this.AGKJNGPPPCJ = DPGJIJGOCIC.DDNFIDBDEGC(CDEKICFPBGL);
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0001CFBA File Offset: 0x0001B1BA
	public bool JBEPHLFCLEC()
	{
		return this.BMKEOCHKOLH();
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0001CFC2 File Offset: 0x0001B1C2
	public void LGFDPCALDAF()
	{
		if (this.CIPCINKGILF)
		{
			this.OEONCFGBLIF = this.OKGGLHOCENC;
			this.OKGGLHOCENC = null;
			this.CIPCINKGILF = false;
			DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(): userPublicProfileRefreshRequired");
		}
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0001CFF0 File Offset: 0x0001B1F0
	public bool MNHKPMBLEEK(string ICAHJJBAEHB, string IIJEMKOAPEL, List<string> LAOFACCOCFD, List<string> FILFOEOHKNF, int IPKECFBJIPF, string EIKFOACPDEB, FCABOFEGPGP KILBEPOBMNB, FCABOFEGPGP LLMPMBAJJPI, string LBGGLHDOICL, string BMOHOJGIEHH, string AHLOHDKPAMG, string BJHBCEKDLGC, string MEMFLCDMJKH, string LJLBJIHPKAE, PHALBCMBPPL IAGDJJCMNLF, PHALBCMBPPL ECFCKBBGNIP, int HCNAPDGGCDO)
	{
		if (this.OFNHOICCBAM.Count >= 100)
		{
			return false;
		}
		if (LAOFACCOCFD == null || LAOFACCOCFD.Count == 0)
		{
			LAOFACCOCFD = new List<string>();
			LAOFACCOCFD.Add("x");
		}
		if (FILFOEOHKNF == null || FILFOEOHKNF.Count == 0)
		{
			FILFOEOHKNF = new List<string>();
			FILFOEOHKNF.Add("x");
		}
		if (ICAHJJBAEHB == null || ICAHJJBAEHB.Length == 0)
		{
			ICAHJJBAEHB = "x";
		}
		if (IIJEMKOAPEL == null || IIJEMKOAPEL.Length == 0)
		{
			IIJEMKOAPEL = "x";
		}
		if (EIKFOACPDEB == null || EIKFOACPDEB.Length == 0)
		{
			EIKFOACPDEB = "x";
		}
		if (LBGGLHDOICL == null || LBGGLHDOICL.Length == 0)
		{
			LBGGLHDOICL = "x";
		}
		if (BMOHOJGIEHH == null || BMOHOJGIEHH.Length == 0)
		{
			BMOHOJGIEHH = "x";
		}
		if (BJHBCEKDLGC == null || BJHBCEKDLGC.Length == 0)
		{
			BJHBCEKDLGC = "x";
		}
		if (AHLOHDKPAMG == null || AHLOHDKPAMG.Length == 0)
		{
			AHLOHDKPAMG = "x";
		}
		if (MEMFLCDMJKH == null || MEMFLCDMJKH.Length == 0)
		{
			MEMFLCDMJKH = "x";
		}
		if (LJLBJIHPKAE == null || LJLBJIHPKAE.Length == 0)
		{
			LJLBJIHPKAE = "x";
		}
		string text = DPGJIJGOCIC.MKJLJPMEPCC() + "$";
		text = text + ICAHJJBAEHB + "$";
		string text2 = LAOFACCOCFD[0];
		for (int i = 1; i < LAOFACCOCFD.Count; i++)
		{
			text2 = text2 + "," + LAOFACCOCFD[i];
		}
		text = text + text2 + "$";
		text = text + EIKFOACPDEB + "$";
		text += "x$";
		text = text + LBGGLHDOICL + "$";
		text = text + BMOHOJGIEHH + "$";
		text += "x$";
		text = text + AHLOHDKPAMG + "$";
		text += "x$";
		text = text + HCNAPDGGCDO.ToString() + "$";
		text += "7$";
		text2 = FILFOEOHKNF[0];
		for (int j = 1; j < FILFOEOHKNF.Count; j++)
		{
			text2 = text2 + "," + FILFOEOHKNF[j];
		}
		text = text + text2 + "$";
		text = text + IPKECFBJIPF.ToString() + "$";
		string str = text;
		int num = (int)KILBEPOBMNB;
		text = str + num.ToString() + "$";
		string str2 = text;
		num = (int)LLMPMBAJJPI;
		text = str2 + num.ToString() + "$";
		text = text + LJLBJIHPKAE + "$";
		string str3 = text;
		num = (int)IAGDJJCMNLF;
		text = str3 + num.ToString() + "$";
		string str4 = text;
		num = (int)ECFCKBBGNIP;
		text = str4 + num.ToString() + "$";
		text = text + BJHBCEKDLGC + "$";
		text = text + MEMFLCDMJKH + "$";
		text += IIJEMKOAPEL;
		this.OFNHOICCBAM.Add(DPGJIJGOCIC.FAIFJDPENOP(text));
		return true;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0001D2BC File Offset: 0x0001B4BC
	public bool OHDLHKCNBLE(int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		for (int i = 0; i < this.NHMMPGOKAOL.Length; i++)
		{
			for (int j = 0; j < this.NHMMPGOKAOL[i].Count; j++)
			{
				if (this.NHMMPGOKAOL[i][j].DHONIOBOLEL.GGICIBLJIKI == NLLCKPCKGOH && this.NHMMPGOKAOL[i][j].DHONIOBOLEL.OHDLHKCNBLE(OLKMHHNMDLP))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0001D330 File Offset: 0x0001B530
	public EIOPLEFLLIM OMOJIEHBENF()
	{
		if (this.IEGJCPDCLMM >= 1)
		{
			return this.ODBNFKONDCF(GKJPOGNFKNK.GJAAHGIAPMH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM).header.index);
		}
		return this.LMGMHHLLOFN(GKJPOGNFKNK.GJAAHGIAPMH(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN).header.index);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0001D385 File Offset: 0x0001B585
	public bool KFJABIMKGOE()
	{
		return this.KPDKOKHHHOL < 0.001f;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x0001D394 File Offset: 0x0001B594
	public void ILNLMCECNNM(JSONArray LLLCAKGBPNC)
	{
		this.CPKFFFLFMMD = DPGJIJGOCIC.DDNFIDBDEGC(LLLCAKGBPNC);
		this.JADCONHBJGM();
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0001D3A8 File Offset: 0x0001B5A8
	public void MDMPJINECJD()
	{
		this.OHLMJHHMDJF = -1;
		this.PCMNOPFHKDJ = -1;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
	public void DHJHKAJIHCE(JSONArray NFLNIECCENE)
	{
		this.DPFOKICNKJL.Clear();
		for (int i = 0; i < NFLNIECCENE.Count; i += 0)
		{
			LMHHKDFCKFC lmhhkdfckfc = new LMHHKDFCKFC();
			lmhhkdfckfc.BGNGBJFGOBO(NFLNIECCENE[i].AsObject);
			this.DPFOKICNKJL.Add(lmhhkdfckfc);
		}
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x0001D408 File Offset: 0x0001B608
	public void ENFDIJBEHPM()
	{
		try
		{
			for (int i = 1; i < this.NHMMPGOKAOL.Length; i++)
			{
				for (int j = 1; j < this.NHMMPGOKAOL[i].Count; j += 0)
				{
					if (!this.NHMMPGOKAOL[i][j].DHONIOBOLEL.JOOMMPOMEMG())
					{
						this.NHMMPGOKAOL[i][j].DHONIOBOLEL.BIKCLHBNCEL(0);
						if (i != 0)
						{
							for (int k = 1; k < this.NHMMPGOKAOL[1].Count; k++)
							{
								if (this.NHMMPGOKAOL[1][k].DHONIOBOLEL.GGICIBLJIKI == this.NHMMPGOKAOL[i][j].DHONIOBOLEL.GGICIBLJIKI)
								{
									this.NHMMPGOKAOL[0][k].DHONIOBOLEL.OCMODCOLBAP(1);
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
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x0001D500 File Offset: 0x0001B700
	public void HKOBEKCGGEI(JAMPPNPOJJG NLIDEHHMLLP)
	{
		this.EPJCBEKHMNA(NLIDEHHMLLP);
		if (this.ADCLBEPMMCG == JAMPPNPOJJG.full)
		{
			EEIBKLDNBAP.JENCHCDPCLB();
		}
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x0001D518 File Offset: 0x0001B718
	private void EPBGODEAOOC()
	{
		if (AKLOMMOOFNG.CLCGKMNEICM("account.json"))
		{
			string text = AKLOMMOOFNG.DJGJKOOOFEA("account.json");
			if (text != null && text.Length > 0)
			{
				JSONObject eihojfgalmf = null;
				try
				{
					eihojfgalmf = (JSONObject)JSON.Parse(text);
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				this.FGJPKGLOGNC(eihojfgalmf, true, true);
			}
		}
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x0001D578 File Offset: 0x0001B778
	public PLFDAJJHMKO NBMLMNGHOPP()
	{
		if (this.IEGJCPDCLMM >= 0)
		{
			return this.HFBNIIHICBP(-1);
		}
		if (this.GLKNOFHEBKN < 0)
		{
			return null;
		}
		return this.JDCBFAPDJIM(this.GLKNOFHEBKN, -1);
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
	public void BMBCCPMCAIM(int MEFKFOHCOHK)
	{
		if (this.NFNKBNGDAIP.Contains(MEFKFOHCOHK))
		{
			this.NFNKBNGDAIP.Remove(MEFKFOHCOHK);
		}
		if (this.NFNKBNGDAIP.Count >= 3)
		{
			this.NFNKBNGDAIP.RemoveAt(0);
		}
		this.NFNKBNGDAIP.Add(MEFKFOHCOHK);
		if (this.DGBOBDAFHGC.Contains(MEFKFOHCOHK))
		{
			this.DGBOBDAFHGC.Remove(MEFKFOHCOHK);
		}
		if (this.DGBOBDAFHGC.Count >= 2)
		{
			this.DGBOBDAFHGC.RemoveAt(0);
		}
		this.DGBOBDAFHGC.Add(MEFKFOHCOHK);
	}

	// Token: 0x0400007D RID: 125
	public const string OEBAJCJPKDF = "OnAccountSave";

	// Token: 0x0400007E RID: 126
	public const string LNECHNMKACL = "account.json";

	// Token: 0x0400007F RID: 127
	public const int JFDKGCAPOKI = 10;

	// Token: 0x04000080 RID: 128
	private static AKLFPGMDKLA IKLAPGJDMNA;

	// Token: 0x04000081 RID: 129
	private JSONObject PGHADKMJMEM;

	// Token: 0x04000082 RID: 130
	private bool OELEMFGAOPH;

	// Token: 0x04000083 RID: 131
	public const float AMBMDBLAAKF = 1f;

	// Token: 0x04000084 RID: 132
	public bool NKAMGBCGCPM;

	// Token: 0x04000085 RID: 133
	public List<int> JBBAANGAFKO = new List<int>();

	// Token: 0x04000086 RID: 134
	public List<int> AILMCODLLCE = new List<int>();

	// Token: 0x04000087 RID: 135
	private List<int> DLCPABCHIDK = new List<int>();

	// Token: 0x04000088 RID: 136
	private List<int> EINPKOJBCGA = new List<int>();

	// Token: 0x04000089 RID: 137
	private List<int> DAPGFGNDIPG = new List<int>();

	// Token: 0x0400008A RID: 138
	public List<int> JINPALBNFHH = new List<int>();

	// Token: 0x0400008B RID: 139
	private List<int> IBKDIDKHCHO = new List<int>();

	// Token: 0x0400008C RID: 140
	private List<int> FLEFJPNPHPN = new List<int>();

	// Token: 0x0400008D RID: 141
	private List<int> KJCFKLGMOKG = new List<int>();

	// Token: 0x0400008E RID: 142
	private List<int> PDDGOPCBPHE = new List<int>();

	// Token: 0x0400008F RID: 143
	private List<int> HKOBGOJEBPK = new List<int>();

	// Token: 0x04000090 RID: 144
	private List<int> DFACBPKFCOM = new List<int>();

	// Token: 0x04000091 RID: 145
	private List<int> MPIKPDLCLHG = new List<int>();

	// Token: 0x04000092 RID: 146
	public bool EKEHBBGKMHA;

	// Token: 0x04000093 RID: 147
	public float MEDEIJGNEMB = 1f;

	// Token: 0x04000094 RID: 148
	public float GOEDFBDNADA = 1f;

	// Token: 0x04000095 RID: 149
	public float KPDKOKHHHOL = 1f;

	// Token: 0x04000096 RID: 150
	public int EGOCMDJBLNJ;

	// Token: 0x04000097 RID: 151
	public int MJPKIMHENNF;

	// Token: 0x04000098 RID: 152
	public string IPEMNDHJBHK = "";

	// Token: 0x04000099 RID: 153
	private List<IMMKFHKEEBF> FKDMPMKBCBL = new List<IMMKFHKEEBF>();

	// Token: 0x0400009A RID: 154
	private List<IMMKFHKEEBF> IOEACDCKKID = new List<IMMKFHKEEBF>();

	// Token: 0x0400009B RID: 155
	private List<IMMKFHKEEBF> MEFNCEJHMIF = new List<IMMKFHKEEBF>();

	// Token: 0x0400009C RID: 156
	private List<IMMKFHKEEBF> DDCKJCAOJHO = new List<IMMKFHKEEBF>();

	// Token: 0x0400009D RID: 157
	public int OOEJIIJLKPK;

	// Token: 0x0400009E RID: 158
	public int GGMNDJPGBOM;

	// Token: 0x0400009F RID: 159
	public int EIIJAHNFADO;

	// Token: 0x040000A0 RID: 160
	public int HNHHBENEBEL;

	// Token: 0x040000A1 RID: 161
	public int HEFJBOKIEGH = 1;

	// Token: 0x040000A2 RID: 162
	public int MDPMKICGGIJ;

	// Token: 0x040000A3 RID: 163
	public int ENCEBEJPGPL;

	// Token: 0x040000A4 RID: 164
	public int APLCOFLOAPA;

	// Token: 0x040000A5 RID: 165
	public int MCAGCFDCJID;

	// Token: 0x040000A6 RID: 166
	public int EIDLACNLJJP;

	// Token: 0x040000A7 RID: 167
	public int EPIBEOCFEGA;

	// Token: 0x040000A8 RID: 168
	public int HENCGDHCMIE;

	// Token: 0x040000A9 RID: 169
	public int DANIALBOJNN;

	// Token: 0x040000AA RID: 170
	public int EKHACLPEIBJ;

	// Token: 0x040000AB RID: 171
	public int IHMLBGPJKDO;

	// Token: 0x040000AC RID: 172
	public int MEDFMIPBDFD;

	// Token: 0x040000AD RID: 173
	public int AJLAADOFOLH;

	// Token: 0x040000AE RID: 174
	public int POIEMMMNOLI = 1;

	// Token: 0x040000AF RID: 175
	public JAMPPNPOJJG ADCLBEPMMCG;

	// Token: 0x040000B0 RID: 176
	public int NAGCLLBIPGP;

	// Token: 0x040000B1 RID: 177
	public int OBBFGMHLMHO;

	// Token: 0x040000B2 RID: 178
	public int PPBPBDLEKIG;

	// Token: 0x040000B3 RID: 179
	public int LODJGIJMGAA;

	// Token: 0x040000B4 RID: 180
	public HGCFJKCOKPM OJKHMNEIGPF = HGCFJKCOKPM.dark;

	// Token: 0x040000B5 RID: 181
	public HOHEIFDCPMF KEDFFDAAGGP;

	// Token: 0x040000B6 RID: 182
	public int PACMCEHMBGG = 1;

	// Token: 0x040000B7 RID: 183
	public int KFHJHOGCEOF;

	// Token: 0x040000B8 RID: 184
	public int COJFECEAKKI = -1;

	// Token: 0x040000B9 RID: 185
	public int KGDHECCPKOP = -1;

	// Token: 0x040000BA RID: 186
	public int EEDHNEIMAPN;

	// Token: 0x040000BB RID: 187
	public string EFENJAOHCIH = "";

	// Token: 0x040000BC RID: 188
	private List<int> HLCHHIIOLOL = new List<int>();

	// Token: 0x040000BD RID: 189
	private List<EIOPLEFLLIM> MMIGJNDJGMF = new List<EIOPLEFLLIM>();

	// Token: 0x040000BE RID: 190
	public string HFDMBCHLCOJ = "";

	// Token: 0x040000BF RID: 191
	public string EEHGLPEIIHD = "";

	// Token: 0x040000C0 RID: 192
	private string EHLLGNJPBIC = "";

	// Token: 0x040000C1 RID: 193
	public int IEGJCPDCLMM = -1;

	// Token: 0x040000C2 RID: 194
	public int EJLCEBPHPJE = -1;

	// Token: 0x040000C3 RID: 195
	public List<int> NFNKBNGDAIP = new List<int>();

	// Token: 0x040000C4 RID: 196
	public List<int> DGBOBDAFHGC = new List<int>();

	// Token: 0x040000C5 RID: 197
	public List<string> KHOHDCKFNPJ = new List<string>();

	// Token: 0x040000C6 RID: 198
	public List<string> NKGJLFEGGEL = new List<string>();

	// Token: 0x040000C7 RID: 199
	public List<string> LINEPLBMFNF = new List<string>();

	// Token: 0x040000C8 RID: 200
	public List<int> KINBCPBEAMI = new List<int>();

	// Token: 0x040000C9 RID: 201
	public List<int> KNDLFMMJFMK = new List<int>();

	// Token: 0x040000CA RID: 202
	public int AGGFKICPDAA;

	// Token: 0x040000CB RID: 203
	public int GLKNOFHEBKN = -1;

	// Token: 0x040000CC RID: 204
	private List<PLFDAJJHMKO>[] NHMMPGOKAOL;

	// Token: 0x040000CD RID: 205
	public DateTime EPFIHIAKPIH = DateTime.Now;

	// Token: 0x040000CE RID: 206
	public DateTime NEBCFBIEIFK = DateTime.Now;

	// Token: 0x040000CF RID: 207
	public DateTime EOOBBNJEEOG = DateTime.Now;

	// Token: 0x040000D0 RID: 208
	public DateTime MOINKAHNDKK = new DateTime(2025, 1, 1);

	// Token: 0x040000D1 RID: 209
	public List<string> OFNHOICCBAM = new List<string>();

	// Token: 0x040000D2 RID: 210
	public string GFDMIHHNFDA = "";

	// Token: 0x040000D3 RID: 211
	public string OCMDGMFAMJB = "";

	// Token: 0x040000D4 RID: 212
	public string MLEBKAIHGIO = "";

	// Token: 0x040000D5 RID: 213
	public string KAOAFBOEPFD = "";

	// Token: 0x040000D6 RID: 214
	public List<string> CEKAJNFMIKL = new List<string>();

	// Token: 0x040000D7 RID: 215
	public List<string> DLJBBDOEMLO = new List<string>();

	// Token: 0x040000D8 RID: 216
	public JSONArray PLLGPNGEHLL = new JSONArray();

	// Token: 0x040000D9 RID: 217
	public JSONArray FCJJDEKOIED = new JSONArray();

	// Token: 0x040000DA RID: 218
	public int KLPBIGJBOBE;

	// Token: 0x040000DB RID: 219
	public List<string> DJKLDDLCNKI = new List<string>();

	// Token: 0x040000DC RID: 220
	public List<int> CPKFFFLFMMD = new List<int>();

	// Token: 0x040000DD RID: 221
	public List<int> KGHMOKADNKK = new List<int>();

	// Token: 0x040000DE RID: 222
	public List<int> OCCKPEEMBJB = new List<int>();

	// Token: 0x040000DF RID: 223
	public List<int> BGMKEDLDMFN = new List<int>();

	// Token: 0x040000E0 RID: 224
	public List<int> PGGHMMFKCFC = new List<int>();

	// Token: 0x040000E1 RID: 225
	public long ILAIJIHFMGF;

	// Token: 0x040000E2 RID: 226
	public bool GIIJKGFONNN;

	// Token: 0x040000E3 RID: 227
	public List<int> LPIFCGOIENF = new List<int>();

	// Token: 0x040000E4 RID: 228
	public List<int> AGKJNGPPPCJ = new List<int>();

	// Token: 0x040000E5 RID: 229
	public string EGBMBHJGPMA = "";

	// Token: 0x040000E6 RID: 230
	public List<string> LAHPLEFAGLH = new List<string>();

	// Token: 0x040000E7 RID: 231
	public int GIJOJGMJKKG;

	// Token: 0x040000E8 RID: 232
	public LDLLJFOJCDF OJNBAMPGBLJ = new LDLLJFOJCDF(0);

	// Token: 0x040000E9 RID: 233
	public LDLLJFOJCDF DOFKEHNPCIJ = new LDLLJFOJCDF(0);

	// Token: 0x040000EA RID: 234
	public LDLLJFOJCDF PBEPCNFADAA = new LDLLJFOJCDF(0);

	// Token: 0x040000EB RID: 235
	public LDLLJFOJCDF ODMKLADKHMO = new LDLLJFOJCDF(0);

	// Token: 0x040000EC RID: 236
	public LDLLJFOJCDF MPMKMCJFHOG = new LDLLJFOJCDF(0);

	// Token: 0x040000ED RID: 237
	public LDLLJFOJCDF ABGNIKKFFAC = new LDLLJFOJCDF(0);

	// Token: 0x040000EE RID: 238
	public LDLLJFOJCDF DJLLDNNIMMK = new LDLLJFOJCDF(0);

	// Token: 0x040000EF RID: 239
	public LDLLJFOJCDF EAFDLIOEKCP = new LDLLJFOJCDF(0);

	// Token: 0x040000F0 RID: 240
	public LDLLJFOJCDF EJEKPNHAABH = new LDLLJFOJCDF(0);

	// Token: 0x040000F1 RID: 241
	public List<int> BKADBDBHFCP = new List<int>();

	// Token: 0x040000F2 RID: 242
	public string FDJKFAOBCOM = "";

	// Token: 0x040000F3 RID: 243
	public List<LMHHKDFCKFC> DPFOKICNKJL = new List<LMHHKDFCKFC>();

	// Token: 0x040000F4 RID: 244
	public int NNEFJNGKJMK = -1;

	// Token: 0x040000F5 RID: 245
	public int OHLMJHHMDJF = -1;

	// Token: 0x040000F6 RID: 246
	public int PCMNOPFHKDJ = -1;

	// Token: 0x040000F7 RID: 247
	public bool MLLOENOIKGA;

	// Token: 0x040000F8 RID: 248
	public int NHBLMCJBLAC;

	// Token: 0x040000F9 RID: 249
	public int BNGHKCHKMPB;

	// Token: 0x040000FA RID: 250
	public bool CBOKIJMGNFH;

	// Token: 0x040000FB RID: 251
	public int BLJDFLHCEDE;

	// Token: 0x040000FC RID: 252
	public bool CDFKCAKGOAH;

	// Token: 0x040000FD RID: 253
	public int KCFMAEFDGPK;

	// Token: 0x040000FE RID: 254
	public int PPIBBJPMJBN;

	// Token: 0x040000FF RID: 255
	public int PANBDFNFFJE;

	// Token: 0x04000100 RID: 256
	public int DNFICKOIFEM;

	// Token: 0x04000101 RID: 257
	public int ECPKIEMGLNN;

	// Token: 0x04000102 RID: 258
	public int DCIPLNCLIMF;

	// Token: 0x04000103 RID: 259
	public int JDMBJMHEPMD = -1;

	// Token: 0x04000104 RID: 260
	public int CGFOFGGHLEE = -1;

	// Token: 0x04000105 RID: 261
	public int BJIDACANAJH = -1;

	// Token: 0x04000106 RID: 262
	public int PNNHDJFBHOL = -1;

	// Token: 0x04000107 RID: 263
	public int DBJMOAOBHKE = -1;

	// Token: 0x04000108 RID: 264
	public int JHDDPLAMOPK = -1;

	// Token: 0x04000109 RID: 265
	private List<string> DBJKLGPNNDE = new List<string>();

	// Token: 0x0400010A RID: 266
	public bool CIPCINKGILF;

	// Token: 0x0400010B RID: 267
	public PMEPALPCEAF OEONCFGBLIF;

	// Token: 0x0400010C RID: 268
	public PMEPALPCEAF OKGGLHOCENC;

	// Token: 0x0400010D RID: 269
	public PMEPALPCEAF CLDBILNPMCN;

	// Token: 0x0400010E RID: 270
	public JSONObject ELAGGOHBOOA;

	// Token: 0x0400010F RID: 271
	public List<PMEPALPCEAF> AONCINPNHDD = new List<PMEPALPCEAF>();

	// Token: 0x04000110 RID: 272
	private List<string> EJGCCKMDDLG = new List<string>();
}
