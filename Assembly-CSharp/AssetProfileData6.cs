using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200028D RID: 653
[CreateAssetMenu(fileName = "assetProfileData6", menuName = "ROMANCE/Create assetProfileData6", order = 1)]
public class AssetProfileData6 : ScriptableObject
{
	// Token: 0x060051A9 RID: 20905 RVA: 0x0023EB29 File Offset: 0x0023CD29
	public List<int> CPEIOOJEKBN()
	{
		this.EJNPEEPNNPN();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051AA RID: 20906 RVA: 0x0023EB3C File Offset: 0x0023CD3C
	public List<int> GELEINPOPDK()
	{
		this.BGJKMBKIEAD();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051AB RID: 20907 RVA: 0x0023EB4F File Offset: 0x0023CD4F
	public bool EEEIFCPLCIK()
	{
		this.OJEOIBJPDBK();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051AC RID: 20908 RVA: 0x0023EB68 File Offset: 0x0023CD68
	private void GBAOHEHDJIB()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 1; i < this.liveProfileThemeThumbnails.Count; i++)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith("digitalglitchovr_1"))
						{
							string s = DPGJIJGOCIC.MJAONCNGBKA(name.Substring("،".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 1 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060051AE RID: 20910 RVA: 0x0023EC6C File Offset: 0x0023CE6C
	public List<int> EACHCLDHLIJ()
	{
		this.GBAOHEHDJIB();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051AF RID: 20911 RVA: 0x0023EC80 File Offset: 0x0023CE80
	public Sprite NNFPJEMHMPO(int KIFAOAHAAIH)
	{
		this.PJNLAFPNNNN();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051B0 RID: 20912 RVA: 0x0023ECA8 File Offset: 0x0023CEA8
	public bool DEHIGEGPNOB(int KIFAOAHAAIH)
	{
		this.PKBODKJLPLG();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051B1 RID: 20913 RVA: 0x0023EB29 File Offset: 0x0023CD29
	public List<int> IFMEDCOLDBN()
	{
		this.EJNPEEPNNPN();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051B2 RID: 20914 RVA: 0x0023ECBC File Offset: 0x0023CEBC
	public bool ACFGBPNGDHP()
	{
		this.BGJKMBKIEAD();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051B3 RID: 20915 RVA: 0x0023ECD2 File Offset: 0x0023CED2
	public List<int> DABPNLKJIFK()
	{
		this.CCCCLPIAOMK();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051B4 RID: 20916 RVA: 0x0023ECE5 File Offset: 0x0023CEE5
	public bool CKJLIFJDOFM()
	{
		this.CCCCLPIAOMK();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051B5 RID: 20917 RVA: 0x0023ECFB File Offset: 0x0023CEFB
	public List<int> HKHFKCAHNKO()
	{
		this.LCGOHOCDDAJ();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051B6 RID: 20918 RVA: 0x0023ED10 File Offset: 0x0023CF10
	private void PJNLAFPNNNN()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 1; i < this.liveProfileThemeThumbnails.Count; i++)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith("errortitle"))
						{
							string s = DPGJIJGOCIC.MJAONCNGBKA(name.Substring("Loaded asset bundle:".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 0 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051B7 RID: 20919 RVA: 0x0023EE14 File Offset: 0x0023D014
	public bool HEDKCHKBBFK()
	{
		this.KCACFIPFBIE();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051B8 RID: 20920 RVA: 0x0023ECD2 File Offset: 0x0023CED2
	public List<int> HEPIPKKPLLE()
	{
		this.CCCCLPIAOMK();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051B9 RID: 20921 RVA: 0x0023EE2C File Offset: 0x0023D02C
	private void PKBODKJLPLG()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 0; i < this.liveProfileThemeThumbnails.Count; i++)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith(" card(s) around scroll index "))
						{
							string s = DPGJIJGOCIC.AMACOOGPPEC(name.Substring("ZZZ".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 1 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051BA RID: 20922 RVA: 0x0023EC6C File Offset: 0x0023CE6C
	public List<int> GNCPBJLOPCG()
	{
		this.GBAOHEHDJIB();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051BB RID: 20923 RVA: 0x0023EF30 File Offset: 0x0023D130
	public bool DBECCBDKKGP(int KIFAOAHAAIH)
	{
		this.GBAOHEHDJIB();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051BC RID: 20924 RVA: 0x0023EF44 File Offset: 0x0023D144
	private void LCGOHOCDDAJ()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 0; i < this.liveProfileThemeThumbnails.Count; i += 0)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith(""))
						{
							string s = DPGJIJGOCIC.AMACOOGPPEC(name.Substring("ias".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 1 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051BD RID: 20925 RVA: 0x0023F048 File Offset: 0x0023D248
	public Sprite PNPNLBFADCL(int KIFAOAHAAIH)
	{
		this.LCGOHOCDDAJ();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051BE RID: 20926 RVA: 0x0023F070 File Offset: 0x0023D270
	public bool KHPJCHBAFHK(int KIFAOAHAAIH)
	{
		this.CCCCLPIAOMK();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051BF RID: 20927 RVA: 0x0023F084 File Offset: 0x0023D284
	public Sprite BFNDAKDJJHM(int KIFAOAHAAIH)
	{
		this.GBAOHEHDJIB();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051C0 RID: 20928 RVA: 0x0023F0AC File Offset: 0x0023D2AC
	public bool EIAONDMJGJF(int KIFAOAHAAIH)
	{
		this.AFJJOGAPCMP();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051C1 RID: 20929 RVA: 0x0023F0C0 File Offset: 0x0023D2C0
	public bool NDHEHAOAOIN()
	{
		this.KCACFIPFBIE();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051C2 RID: 20930 RVA: 0x0023EB3C File Offset: 0x0023CD3C
	public List<int> MIAIKHHOGFE()
	{
		this.BGJKMBKIEAD();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051C3 RID: 20931 RVA: 0x0023F0D6 File Offset: 0x0023D2D6
	public bool JJDNDFHMKCF(int KIFAOAHAAIH)
	{
		this.EJNPEEPNNPN();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051C4 RID: 20932 RVA: 0x0023EB29 File Offset: 0x0023CD29
	public List<int> EMEODGLAGBL()
	{
		this.EJNPEEPNNPN();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051C5 RID: 20933 RVA: 0x0023EC6C File Offset: 0x0023CE6C
	public List<int> FHCMCNDDMIL()
	{
		this.GBAOHEHDJIB();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051C6 RID: 20934 RVA: 0x0023F0EA File Offset: 0x0023D2EA
	public bool IOBAGEDAJKE(int KIFAOAHAAIH)
	{
		this.KCACFIPFBIE();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051C7 RID: 20935 RVA: 0x0023F0C0 File Offset: 0x0023D2C0
	public bool IOPGANEPPDP()
	{
		this.KCACFIPFBIE();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051C8 RID: 20936 RVA: 0x0023F100 File Offset: 0x0023D300
	public Sprite OHNLFJJFFMH(int KIFAOAHAAIH)
	{
		this.KCACFIPFBIE();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051C9 RID: 20937 RVA: 0x0023F128 File Offset: 0x0023D328
	public Sprite OPDLCEGPACL(int KIFAOAHAAIH)
	{
		this.GBAOHEHDJIB();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051CA RID: 20938 RVA: 0x0023F150 File Offset: 0x0023D350
	public List<int> KPCLIJKKAGO()
	{
		this.AFJJOGAPCMP();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051CB RID: 20939 RVA: 0x0023F070 File Offset: 0x0023D270
	public bool KKHHDLJKEOK(int KIFAOAHAAIH)
	{
		this.CCCCLPIAOMK();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051CC RID: 20940 RVA: 0x0023F0EA File Offset: 0x0023D2EA
	public bool BHHGBKMJKAN(int KIFAOAHAAIH)
	{
		this.KCACFIPFBIE();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051CD RID: 20941 RVA: 0x0023ECBC File Offset: 0x0023CEBC
	public bool EMCMBBNJBDN()
	{
		this.BGJKMBKIEAD();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051CE RID: 20942 RVA: 0x0023F164 File Offset: 0x0023D364
	public Sprite KEIAKEHIDHB(int KIFAOAHAAIH)
	{
		this.PJNLAFPNNNN();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051CF RID: 20943 RVA: 0x0023F18C File Offset: 0x0023D38C
	public bool FKGPBDBHJAC(int KIFAOAHAAIH)
	{
		this.LCGOHOCDDAJ();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051D0 RID: 20944 RVA: 0x0023F1A0 File Offset: 0x0023D3A0
	public bool LGHBEPLIIGB()
	{
		this.PKBODKJLPLG();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051D1 RID: 20945 RVA: 0x0023F1B6 File Offset: 0x0023D3B6
	public bool DPBBKHFAJEA()
	{
		this.EJNPEEPNNPN();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051D2 RID: 20946 RVA: 0x0023F1CC File Offset: 0x0023D3CC
	private void AFJJOGAPCMP()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 1; i < this.liveProfileThemeThumbnails.Count; i += 0)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith(".json"))
						{
							string s = DPGJIJGOCIC.MJAONCNGBKA(name.Substring("miniversion".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 0 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051D3 RID: 20947 RVA: 0x0023F2D0 File Offset: 0x0023D4D0
	public Sprite HPNNKBNIFIM(int KIFAOAHAAIH)
	{
		this.AFJJOGAPCMP();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051D4 RID: 20948 RVA: 0x0023F2F8 File Offset: 0x0023D4F8
	public bool LLHKPIHNDJC()
	{
		this.PKBODKJLPLG();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051D5 RID: 20949 RVA: 0x0023F310 File Offset: 0x0023D510
	public Sprite HPDFDBOJOJB(int KIFAOAHAAIH)
	{
		this.EJNPEEPNNPN();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051D6 RID: 20950 RVA: 0x0023F338 File Offset: 0x0023D538
	public bool MIFBPJKLCIP(int KIFAOAHAAIH)
	{
		this.OJEOIBJPDBK();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051D7 RID: 20951 RVA: 0x0023EB3C File Offset: 0x0023CD3C
	public List<int> MOLIBIBCPNO()
	{
		this.BGJKMBKIEAD();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051D8 RID: 20952 RVA: 0x0023F34C File Offset: 0x0023D54C
	public List<int> LLGHDPJEECM()
	{
		this.KCACFIPFBIE();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051D9 RID: 20953 RVA: 0x0023F070 File Offset: 0x0023D270
	public bool OOJINMCHOPG(int KIFAOAHAAIH)
	{
		this.CCCCLPIAOMK();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051DA RID: 20954 RVA: 0x0023F35F File Offset: 0x0023D55F
	public List<int> DEDMLDLBOLB()
	{
		this.OJEOIBJPDBK();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051DB RID: 20955 RVA: 0x0023F374 File Offset: 0x0023D574
	private void EJNPEEPNNPN()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 0; i < this.liveProfileThemeThumbnails.Count; i += 0)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith("$e1ro"))
						{
							string s = DPGJIJGOCIC.MJAONCNGBKA(name.Substring("CameraEnvironmentsFront".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 0 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051DC RID: 20956 RVA: 0x0023F338 File Offset: 0x0023D538
	public bool DAFMOIHHOLL(int KIFAOAHAAIH)
	{
		this.OJEOIBJPDBK();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051DD RID: 20957 RVA: 0x0023F0AC File Offset: 0x0023D2AC
	public bool LDJDLOJBFKH(int KIFAOAHAAIH)
	{
		this.AFJJOGAPCMP();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051DE RID: 20958 RVA: 0x0023F34C File Offset: 0x0023D54C
	public List<int> JAABKEKOHFE()
	{
		this.KCACFIPFBIE();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051DF RID: 20959 RVA: 0x0023F478 File Offset: 0x0023D678
	private void CCCCLPIAOMK()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 1; i < this.liveProfileThemeThumbnails.Count; i += 0)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith("friendsmaxlimitdefaultfp"))
						{
							string s = DPGJIJGOCIC.AMACOOGPPEC(name.Substring("<i>".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 1 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051E0 RID: 20960 RVA: 0x0023F57C File Offset: 0x0023D77C
	public bool FLFEOFMMEAJ()
	{
		this.PJNLAFPNNNN();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051E1 RID: 20961 RVA: 0x0023F592 File Offset: 0x0023D792
	public bool CKKKAMLLJNL()
	{
		this.LCGOHOCDDAJ();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051E2 RID: 20962 RVA: 0x0023F0D6 File Offset: 0x0023D2D6
	public bool JAKFGHINPOB(int KIFAOAHAAIH)
	{
		this.EJNPEEPNNPN();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051E3 RID: 20963 RVA: 0x0023F5A8 File Offset: 0x0023D7A8
	public bool FOIFLKDGDKL(int KIFAOAHAAIH)
	{
		this.PJNLAFPNNNN();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051E4 RID: 20964 RVA: 0x0023F5BC File Offset: 0x0023D7BC
	public bool BNKAIKILGPL(int KIFAOAHAAIH)
	{
		this.BGJKMBKIEAD();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051E5 RID: 20965 RVA: 0x0023F5D0 File Offset: 0x0023D7D0
	private void BGJKMBKIEAD()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 0; i < this.liveProfileThemeThumbnails.Count; i += 0)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith("acli20"))
						{
							string s = DPGJIJGOCIC.AMACOOGPPEC(name.Substring("smsrc".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 0 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060051E6 RID: 20966 RVA: 0x0023F35F File Offset: 0x0023D55F
	public List<int> PMIONKNKOGH()
	{
		this.OJEOIBJPDBK();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051E7 RID: 20967 RVA: 0x0023F6D4 File Offset: 0x0023D8D4
	private void KCACFIPFBIE()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 0; i < this.liveProfileThemeThumbnails.Count; i++)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith("liveprofilethemethumb"))
						{
							string s = DPGJIJGOCIC.AMACOOGPPEC(name.Substring("liveprofilethemethumb".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 0 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060051E8 RID: 20968 RVA: 0x0023F7D8 File Offset: 0x0023D9D8
	public bool HECAPKOAEBM()
	{
		this.GBAOHEHDJIB();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051E9 RID: 20969 RVA: 0x0023F7EE File Offset: 0x0023D9EE
	public List<int> BBBCGDKJPFE()
	{
		this.PJNLAFPNNNN();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051EA RID: 20970 RVA: 0x0023F801 File Offset: 0x0023DA01
	public bool PDFPPKLJDCE()
	{
		this.LCGOHOCDDAJ();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051EB RID: 20971 RVA: 0x0023EB3C File Offset: 0x0023CD3C
	public List<int> OOHEJGDHKDP()
	{
		this.BGJKMBKIEAD();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051EC RID: 20972 RVA: 0x0023F818 File Offset: 0x0023DA18
	public Sprite KNHCMAOEGML(int KIFAOAHAAIH)
	{
		this.LCGOHOCDDAJ();
		Sprite result = null;
		if (this.thumbnailsByIndex.TryGetValue(KIFAOAHAAIH, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060051ED RID: 20973 RVA: 0x0023F1A0 File Offset: 0x0023D3A0
	public bool KNNFFEKOAKO()
	{
		this.PKBODKJLPLG();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051EE RID: 20974 RVA: 0x0023F840 File Offset: 0x0023DA40
	public bool COADBLHOMFG()
	{
		this.CCCCLPIAOMK();
		return this.thumbnailIndices.Count > 1;
	}

	// Token: 0x060051EF RID: 20975 RVA: 0x0023F34C File Offset: 0x0023D54C
	public List<int> JDNDKIOCCFP()
	{
		this.KCACFIPFBIE();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051F0 RID: 20976 RVA: 0x0023ECE5 File Offset: 0x0023CEE5
	public bool EPEHIABJJJM()
	{
		this.CCCCLPIAOMK();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x060051F1 RID: 20977 RVA: 0x0023F858 File Offset: 0x0023DA58
	private void OJEOIBJPDBK()
	{
		if (this.thumbnailsByIndex != null)
		{
			return;
		}
		this.thumbnailsByIndex = new Dictionary<int, Sprite>();
		this.thumbnailIndices = new List<int>();
		try
		{
			if (this.liveProfileThemeThumbnails != null)
			{
				for (int i = 0; i < this.liveProfileThemeThumbnails.Count; i++)
				{
					if (!(null == this.liveProfileThemeThumbnails[i]))
					{
						string name = this.liveProfileThemeThumbnails[i].name;
						if (name.StartsWith(">>>"))
						{
							string s = DPGJIJGOCIC.MJAONCNGBKA(name.Substring("_StripesCount".Length));
							int num = -1;
							if (int.TryParse(s, out num) && num >= 0 && !this.thumbnailsByIndex.ContainsKey(num))
							{
								this.thumbnailsByIndex.Add(num, this.liveProfileThemeThumbnails[i]);
								this.thumbnailIndices.Add(num);
							}
						}
					}
				}
				this.thumbnailIndices.Sort();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060051F2 RID: 20978 RVA: 0x0023F0D6 File Offset: 0x0023D2D6
	public bool GMCBMJOPHJH(int KIFAOAHAAIH)
	{
		this.EJNPEEPNNPN();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051F3 RID: 20979 RVA: 0x0023EC6C File Offset: 0x0023CE6C
	public List<int> GDDCNEKGJAI()
	{
		this.GBAOHEHDJIB();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051F4 RID: 20980 RVA: 0x0023F070 File Offset: 0x0023D270
	public bool AKMAMAPPEAK(int KIFAOAHAAIH)
	{
		this.CCCCLPIAOMK();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051F5 RID: 20981 RVA: 0x0023F5BC File Offset: 0x0023D7BC
	public bool GGCKHHFNNAD(int KIFAOAHAAIH)
	{
		this.BGJKMBKIEAD();
		return this.thumbnailsByIndex.ContainsKey(KIFAOAHAAIH);
	}

	// Token: 0x060051F6 RID: 20982 RVA: 0x0023EB3C File Offset: 0x0023CD3C
	public List<int> FLGNBADKFGA()
	{
		this.BGJKMBKIEAD();
		return new List<int>(this.thumbnailIndices);
	}

	// Token: 0x060051F7 RID: 20983 RVA: 0x0023F0C0 File Offset: 0x0023D2C0
	public bool JKANOAOODNO()
	{
		this.KCACFIPFBIE();
		return this.thumbnailIndices.Count > 0;
	}

	// Token: 0x04001703 RID: 5891
	public const string THUMBNAIL_NAME_PREFIX = "liveprofilethemethumb";

	// Token: 0x04001704 RID: 5892
	public List<Sprite> liveProfileThemeThumbnails;

	// Token: 0x04001705 RID: 5893
	[NonSerialized]
	private Dictionary<int, Sprite> thumbnailsByIndex;

	// Token: 0x04001706 RID: 5894
	[NonSerialized]
	private List<int> thumbnailIndices;
}
