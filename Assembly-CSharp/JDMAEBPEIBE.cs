using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200042A RID: 1066
public class JDMAEBPEIBE
{
	// Token: 0x06007F53 RID: 32595 RVA: 0x00385E08 File Offset: 0x00384008
	public void OIMFJKOBMJL()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.BCEIKLADKKF();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.DKCFAGFMCOP(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.NNPLKGHHMHK();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F54 RID: 32596 RVA: 0x00385EF0 File Offset: 0x003840F0
	public void GLCIIHOHLLD()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.IPMMLKCDMBH();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.MFDBAKPJDHF(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = true;
					}
				}
				else
				{
					this.PLBALAHDHNK();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F55 RID: 32597 RVA: 0x00385FD8 File Offset: 0x003841D8
	public static JDMAEBPEIBE KCAJDNGIDLL(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.KIHBMJFJHAI(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.OIMFJKOBMJL();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F56 RID: 32598 RVA: 0x0038603C File Offset: 0x0038423C
	private void EOEOLHMEGLD()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007F57 RID: 32599 RVA: 0x00386100 File Offset: 0x00384300
	public static void DKCFAGFMCOP(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F58 RID: 32600 RVA: 0x0038616C File Offset: 0x0038436C
	public static void CMLOJHFFCGE(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F59 RID: 32601 RVA: 0x003861D8 File Offset: 0x003843D8
	public static List<int> BDGBAFGLEMM()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007F5A RID: 32602 RVA: 0x00386290 File Offset: 0x00384490
	public static void KPPBLIMBGCB()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i -= 0)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.EHBBFMCILPC))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].APOIFLFKGLA();
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

	// Token: 0x06007F5B RID: 32603 RVA: 0x00386354 File Offset: 0x00384554
	public void GLLDFBGBLCM()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.EKIHEJGECAD();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.CMLOJHFFCGE(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.EKIHEJGECAD();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007F5C RID: 32604 RVA: 0x0038643C File Offset: 0x0038463C
	public static void ENHPGABFBIH()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F5D RID: 32605 RVA: 0x0038643C File Offset: 0x0038463C
	public static void IPOKMOOJBFI()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F5E RID: 32606 RVA: 0x00386450 File Offset: 0x00384650
	public static int HKBOKMPDEIJ(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 0; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F5F RID: 32607 RVA: 0x003864D8 File Offset: 0x003846D8
	public static void JEIHGECJJPE()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 1; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].EGNJHLLOHPD();
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

	// Token: 0x06007F60 RID: 32608 RVA: 0x0038659C File Offset: 0x0038479C
	private void PLBALAHDHNK()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007F61 RID: 32609 RVA: 0x00386660 File Offset: 0x00384860
	public static int JHGFLPMLPCD(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 1; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F62 RID: 32610 RVA: 0x0038643C File Offset: 0x0038463C
	public static void GHBKBOGICLH()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F64 RID: 32612 RVA: 0x003866FC File Offset: 0x003848FC
	private void EKIHEJGECAD()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007F65 RID: 32613 RVA: 0x003867C0 File Offset: 0x003849C0
	public static int KIHBMJFJHAI(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 1; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F66 RID: 32614 RVA: 0x00386848 File Offset: 0x00384A48
	public static int MHLOFOJCLIG(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F67 RID: 32615 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int KLBCOKMMALM()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F68 RID: 32616 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int PEPBNOHHIJE()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F69 RID: 32617 RVA: 0x003868DC File Offset: 0x00384ADC
	public static int JCMMJDCEPIA(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 0; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F6A RID: 32618 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int BFJCPJPLIGP()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F6B RID: 32619 RVA: 0x00386964 File Offset: 0x00384B64
	public static int LAIGBNOEBPK(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F6C RID: 32620 RVA: 0x003869EC File Offset: 0x00384BEC
	private void MGPFDGLEIIG()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007F6D RID: 32621 RVA: 0x00386AB0 File Offset: 0x00384CB0
	public static JDMAEBPEIBE NFAJKIIDGGI(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.HKBOKMPDEIJ(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.GLLDFBGBLCM();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F6E RID: 32622 RVA: 0x00386B14 File Offset: 0x00384D14
	public static List<int> DGGONJCHIDN()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 1 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007F6F RID: 32623 RVA: 0x00386BCC File Offset: 0x00384DCC
	public static void GKGLHAJEKJC()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 1; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.EHBBFMCILPC))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 1; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].DNBMMKFFPGC();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F70 RID: 32624 RVA: 0x00386C90 File Offset: 0x00384E90
	public static List<int> EBGLCAOAOKJ()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007F71 RID: 32625 RVA: 0x00386D48 File Offset: 0x00384F48
	public static void KKMCKKIFHNP(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F72 RID: 32626 RVA: 0x0038643C File Offset: 0x0038463C
	public static void MIJAEFDBJFJ()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F73 RID: 32627 RVA: 0x00386DB4 File Offset: 0x00384FB4
	public static JDMAEBPEIBE PGLGDHIGGJM(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.IKJGPCBBCBP(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.AEHAGKOKGAG();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F74 RID: 32628 RVA: 0x00386E18 File Offset: 0x00385018
	public static void IIJKCCAFECB()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i -= 0)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.MJBDMHPHMID().liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].EANINIIMIJG();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F75 RID: 32629 RVA: 0x00386EDC File Offset: 0x003850DC
	public void BKFNCKNDCJF()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.KJDGEAKAOML();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.COFFJFFHBGM(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.OIPLNIEENBK();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F76 RID: 32630 RVA: 0x00386FC4 File Offset: 0x003851C4
	public static void IGEMGEACAKI()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.MJBDMHPHMID().liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j++)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].EGNJHLLOHPD();
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

	// Token: 0x06007F77 RID: 32631 RVA: 0x00387088 File Offset: 0x00385288
	public void AEHAGKOKGAG()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.FGDBDFDBGNF();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.DKCFAGFMCOP(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.GOPMGGGGACI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007F78 RID: 32632 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int MDAMECNPMCI()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F79 RID: 32633 RVA: 0x00387170 File Offset: 0x00385370
	public static void DAMMOMOPBJK()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 1; i -= 0)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j++)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].IKPDDKAKIDL();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F7A RID: 32634 RVA: 0x00387234 File Offset: 0x00385434
	public static JDMAEBPEIBE FPDLNEHJAGB(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.JCMMJDCEPIA(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.OPIPBBCONNO();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F7B RID: 32635 RVA: 0x00387298 File Offset: 0x00385498
	public static void LHPOKHEHGFA()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.EHBBFMCILPC))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j++)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].GLLDFBGBLCM();
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

	// Token: 0x06007F7C RID: 32636 RVA: 0x0038643C File Offset: 0x0038463C
	public static void KCHMJKBKBBK()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F7D RID: 32637 RVA: 0x0038735C File Offset: 0x0038555C
	private void NNPLKGHHMHK()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007F7E RID: 32638 RVA: 0x00387420 File Offset: 0x00385620
	private void OIPLNIEENBK()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007F7F RID: 32639 RVA: 0x003874E4 File Offset: 0x003856E4
	public static List<int> AHAGELCGPOP()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007F80 RID: 32640 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int CIKILEEMGIF()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F81 RID: 32641 RVA: 0x0038759C File Offset: 0x0038579C
	private void IKGNMFAKDBA()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007F82 RID: 32642 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int DBAHENPMLCJ()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F83 RID: 32643 RVA: 0x0038643C File Offset: 0x0038463C
	public static void GLMDFIMEEIB()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F84 RID: 32644 RVA: 0x0038643C File Offset: 0x0038463C
	public static void OOHOLNKHFGK()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F85 RID: 32645 RVA: 0x00387660 File Offset: 0x00385860
	public static void NDLCKAHMDGF(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F86 RID: 32646 RVA: 0x003876CC File Offset: 0x003858CC
	public void IKPDDKAKIDL()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.AGBHDCBNAJH();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.BHMMJGLFNJN(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = true;
					}
				}
				else
				{
					this.PLBALAHDHNK();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F87 RID: 32647 RVA: 0x003877B4 File Offset: 0x003859B4
	public static JDMAEBPEIBE GPKMLNEHOJJ(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.LHMPJFCMNMB(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.GLLDFBGBLCM();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F88 RID: 32648 RVA: 0x00387818 File Offset: 0x00385A18
	public void DNBMMKFFPGC()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.FGDBDFDBGNF();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.LFKBDIEIOMH(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = true;
					}
				}
				else
				{
					this.OAGGLOHNLFI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F89 RID: 32649 RVA: 0x00387900 File Offset: 0x00385B00
	public void EANINIIMIJG()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.GOPMGGGGACI();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.NDLCKAHMDGF(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.PLBALAHDHNK();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007F8A RID: 32650 RVA: 0x003879E8 File Offset: 0x00385BE8
	public static JDMAEBPEIBE PBKJBPNLONI(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.LHMPJFCMNMB(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.BKFNCKNDCJF();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F8B RID: 32651 RVA: 0x00387A4C File Offset: 0x00385C4C
	public static int LMFBLLCKBFG(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F8C RID: 32652 RVA: 0x00387AD4 File Offset: 0x00385CD4
	public void OOOJMNAHBHE()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.EOEOLHMEGLD();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.BHMMJGLFNJN(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.PFIGHDBAPLI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007F8D RID: 32653 RVA: 0x00387BBC File Offset: 0x00385DBC
	public static void LEALDPHPFBK()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 1; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 1; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j++)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].OOOJMNAHBHE();
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

	// Token: 0x06007F8E RID: 32654 RVA: 0x00387C80 File Offset: 0x00385E80
	public void OPIPBBCONNO()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.IPMMLKCDMBH();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.DKCFAGFMCOP(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.FGDBDFDBGNF();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007F8F RID: 32655 RVA: 0x00387D68 File Offset: 0x00385F68
	public static JDMAEBPEIBE MKKBOGLMPBD(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.KIHBMJFJHAI(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.APOIFLFKGLA();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F90 RID: 32656 RVA: 0x0038643C File Offset: 0x0038463C
	public static void LOEMNDALIKJ()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F91 RID: 32657 RVA: 0x00387DCC File Offset: 0x00385FCC
	private void AGBHDCBNAJH()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007F92 RID: 32658 RVA: 0x00387E90 File Offset: 0x00386090
	public static void MFDBAKPJDHF(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F93 RID: 32659 RVA: 0x00387EFC File Offset: 0x003860FC
	public void GLMFMFCAMLE()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.EKIHEJGECAD();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.JBBLJAOPKBF(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = true;
					}
				}
				else
				{
					this.EKIHEJGECAD();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007F94 RID: 32660 RVA: 0x0038643C File Offset: 0x0038463C
	public static void IJHHMHAEKKE()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F95 RID: 32661 RVA: 0x00387FE4 File Offset: 0x003861E4
	public static void BHMMJGLFNJN(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F96 RID: 32662 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int PANCNDOBEKJ()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F97 RID: 32663 RVA: 0x00388050 File Offset: 0x00386250
	public static JDMAEBPEIBE KIIEJJOKODB(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.MHLOFOJCLIG(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.GLLDFBGBLCM();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F98 RID: 32664 RVA: 0x0038643C File Offset: 0x0038463C
	public static void KOPDPJCFGIF()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F99 RID: 32665 RVA: 0x003880B4 File Offset: 0x003862B4
	public void AGBMHKOEGLJ()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.BCEIKLADKKF();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.BHMMJGLFNJN(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.MGPFDGLEIIG();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007F9A RID: 32666 RVA: 0x0038819C File Offset: 0x0038639C
	public static JDMAEBPEIBE EJPHDFMMJNF(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.MNADABECONL(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.GLCIIHOHLLD();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007F9B RID: 32667 RVA: 0x00388200 File Offset: 0x00386400
	public static void LFKBDIEIOMH(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007F9C RID: 32668 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int IFEFIDHMMLH()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007F9D RID: 32669 RVA: 0x0038826C File Offset: 0x0038646C
	public static int MNADABECONL(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007F9E RID: 32670 RVA: 0x0038643C File Offset: 0x0038463C
	public static void FALGHMMGBBJ()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007F9F RID: 32671 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int INBDMKHDFMD()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FA0 RID: 32672 RVA: 0x003882F4 File Offset: 0x003864F4
	public static void COFFJFFHBGM(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FA1 RID: 32673 RVA: 0x00388360 File Offset: 0x00386560
	public static int FOCLHGGNKJP(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 0; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = true;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007FA2 RID: 32674 RVA: 0x003883E8 File Offset: 0x003865E8
	private void KJDGEAKAOML()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007FA3 RID: 32675 RVA: 0x0038643C File Offset: 0x0038463C
	public static void HMBHFOKMCBC()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FA4 RID: 32676 RVA: 0x003884AC File Offset: 0x003866AC
	public void HGAKPPHGONM()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.KJDGEAKAOML();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.CMLOJHFFCGE(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = true;
					}
				}
				else
				{
					this.OAGGLOHNLFI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FA5 RID: 32677 RVA: 0x00388594 File Offset: 0x00386794
	public static List<int> FPPPKJGHKFL()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 1 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FA6 RID: 32678 RVA: 0x0038864C File Offset: 0x0038684C
	public static JDMAEBPEIBE NBLFDOLOHCI(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.CJDEHHPKDMI(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.EDFNEODKEHE();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FA7 RID: 32679 RVA: 0x003886B0 File Offset: 0x003868B0
	private void OAGGLOHNLFI()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007FA8 RID: 32680 RVA: 0x00388774 File Offset: 0x00386974
	public static List<int> PBFOILADBHM()
	{
		List<int> list = new List<int>();
		for (int i = 1; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 1 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FA9 RID: 32681 RVA: 0x0038882C File Offset: 0x00386A2C
	private void GOPMGGGGACI()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007FAA RID: 32682 RVA: 0x003888F0 File Offset: 0x00386AF0
	public static List<int> EJIKJOHCJAO()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FAB RID: 32683 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int MBCIFJCPOKK()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FAC RID: 32684 RVA: 0x003889A8 File Offset: 0x00386BA8
	public static List<int> COEICJHHNLD()
	{
		List<int> list = new List<int>();
		for (int i = 1; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 1 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FAD RID: 32685 RVA: 0x00388A60 File Offset: 0x00386C60
	public static JDMAEBPEIBE OOKHAMKHIGH(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.LHMPJFCMNMB(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.OPIPBBCONNO();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FAE RID: 32686 RVA: 0x00388AC4 File Offset: 0x00386CC4
	public static List<int> KCBJNJOMJCN()
	{
		List<int> list = new List<int>();
		for (int i = 1; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 1 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FAF RID: 32687 RVA: 0x00388B7C File Offset: 0x00386D7C
	public static void MBEDPEONEIJ()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 1; i -= 0)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 1; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j++)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].EDFNEODKEHE();
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

	// Token: 0x06007FB0 RID: 32688 RVA: 0x00388C40 File Offset: 0x00386E40
	private void KKJNDMPLEJG()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007FB1 RID: 32689 RVA: 0x00388D04 File Offset: 0x00386F04
	public static JDMAEBPEIBE PEIJEMDJIPJ(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.CJDEHHPKDMI(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.APOIFLFKGLA();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FB2 RID: 32690 RVA: 0x00388D68 File Offset: 0x00386F68
	public void APOIFLFKGLA()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.NNPLKGHHMHK();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.IENKLMMGKOA(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.EKIHEJGECAD();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007FB3 RID: 32691 RVA: 0x00388E50 File Offset: 0x00387050
	public static JDMAEBPEIBE LFOJIJOKBKP(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.LAIGBNOEBPK(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.EDFNEODKEHE();
		if (num >= 0 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FB4 RID: 32692 RVA: 0x00388EB4 File Offset: 0x003870B4
	private void PFIGHDBAPLI()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007FB5 RID: 32693 RVA: 0x00388F78 File Offset: 0x00387178
	public static JDMAEBPEIBE PBLHLJOJFNM(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.MNADABECONL(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.OOOJMNAHBHE();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FB6 RID: 32694 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int BMCBBFJKHEG()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FB7 RID: 32695 RVA: 0x0038643C File Offset: 0x0038463C
	public static void KGFCCIAJGFF()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FB8 RID: 32696 RVA: 0x00388FDC File Offset: 0x003871DC
	public static int GFFAPCMJCFD(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 1; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007FB9 RID: 32697 RVA: 0x00389064 File Offset: 0x00387264
	private void IPMMLKCDMBH()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007FBA RID: 32698 RVA: 0x00389128 File Offset: 0x00387328
	public static List<int> LPBFPBJCAJA()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FBB RID: 32699 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int MOKIHMJKCHK()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FBC RID: 32700 RVA: 0x003891E0 File Offset: 0x003873E0
	public static void JLKEBFFEKPG(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FBD RID: 32701 RVA: 0x0038924C File Offset: 0x0038744C
	public static int LHMPJFCMNMB(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 1; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = false;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007FBE RID: 32702 RVA: 0x003892D4 File Offset: 0x003874D4
	public static JDMAEBPEIBE JHHDPCGCBHO(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.JHGFLPMLPCD(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.DNBMMKFFPGC();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FBF RID: 32703 RVA: 0x00389338 File Offset: 0x00387538
	public static List<int> JPBKCBJLBMG()
	{
		List<int> list = new List<int>();
		for (int i = 1; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FC0 RID: 32704 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int EBCLKAFELJH()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FC1 RID: 32705 RVA: 0x003893F0 File Offset: 0x003875F0
	private void GGKFKEEJMLD()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007FC2 RID: 32706 RVA: 0x0038643C File Offset: 0x0038463C
	public static void IPOOADBKNCN()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FC3 RID: 32707 RVA: 0x003894B4 File Offset: 0x003876B4
	private void GHOFLKJABKL()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = true;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007FC4 RID: 32708 RVA: 0x00389578 File Offset: 0x00387778
	public static void MCCKKCFCGGF(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FC5 RID: 32709 RVA: 0x0038643C File Offset: 0x0038463C
	public static void KELHJBKBMPI()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FC6 RID: 32710 RVA: 0x003895E4 File Offset: 0x003877E4
	public static void BMFKLKAHLPK()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.EHBBFMCILPC))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].AGBMHKOEGLJ();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FC7 RID: 32711 RVA: 0x0038643C File Offset: 0x0038463C
	public static void CEPBJMGDKPI()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FC8 RID: 32712 RVA: 0x003896A8 File Offset: 0x003878A8
	public static JDMAEBPEIBE COOBAKLDJEG(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.BIGKGBBKHNJ(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.HGAKPPHGONM();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FC9 RID: 32713 RVA: 0x0038970C File Offset: 0x0038790C
	public static int CJDEHHPKDMI(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 1; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = true;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007FCA RID: 32714 RVA: 0x00389794 File Offset: 0x00387994
	public static void BMNGHIPEEGE(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FCB RID: 32715 RVA: 0x00389800 File Offset: 0x00387A00
	public void EGNJHLLOHPD()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.IPMMLKCDMBH();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.IENKLMMGKOA(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.OAGGLOHNLFI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FCC RID: 32716 RVA: 0x003898E8 File Offset: 0x00387AE8
	public static List<int> PAIEMPGGHJK()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FCD RID: 32717 RVA: 0x003899A0 File Offset: 0x00387BA0
	public static int BIGKGBBKHNJ(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 0; i -= 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = true;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007FCE RID: 32718 RVA: 0x00389A28 File Offset: 0x00387C28
	public static void IKPLFPPAPGL(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FCF RID: 32719 RVA: 0x00389A94 File Offset: 0x00387C94
	private void FGDBDFDBGNF()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.BJCHEAFAIIP();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007FD0 RID: 32720 RVA: 0x00389B58 File Offset: 0x00387D58
	public static List<int> JONFILJGJKE()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 1 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FD1 RID: 32721 RVA: 0x00389C10 File Offset: 0x00387E10
	public static void IENKLMMGKOA(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FD2 RID: 32722 RVA: 0x00389C7C File Offset: 0x00387E7C
	public static int IKJGPCBBCBP(Image JFKDEMMNEGP)
	{
		int result = -1;
		if (null == JFKDEMMNEGP)
		{
			return result;
		}
		for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 0; i--)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD == JFKDEMMNEGP)
			{
				if (null != JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE)
				{
					JDMAEBPEIBE.GFCOGEKNBLG[i].CHDKPOMJHOE.enabled = true;
				}
				result = i;
				JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
			}
		}
		return result;
	}

	// Token: 0x06007FD3 RID: 32723 RVA: 0x00389D04 File Offset: 0x00387F04
	public void EJEMDNIDIAP()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.EOEOLHMEGLD();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.CMLOJHFFCGE(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = false;
						this.GBIABAHMEEG = false;
					}
				}
				else
				{
					this.MGPFDGLEIIG();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007FD4 RID: 32724 RVA: 0x00389DEC File Offset: 0x00387FEC
	public static List<int> KALPCFNEEGD()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FD5 RID: 32725 RVA: 0x00389EA4 File Offset: 0x003880A4
	public static List<int> LFNKLJLIJNG()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i++)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FD6 RID: 32726 RVA: 0x0038643C File Offset: 0x0038463C
	public static void NHAONAKHHNL()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FD7 RID: 32727 RVA: 0x00389F5C File Offset: 0x0038815C
	public static List<int> PLGGLLKJFMA()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < JDMAEBPEIBE.GFCOGEKNBLG.Count; i += 0)
		{
			if (JDMAEBPEIBE.GFCOGEKNBLG[i].GBIABAHMEEG && !(null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD) && JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD.gameObject.activeInHierarchy && JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK >= 0 && !list.Contains(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK))
			{
				list.Add(JDMAEBPEIBE.GFCOGEKNBLG[i].JABJKOHNGPK);
			}
		}
		return list;
	}

	// Token: 0x06007FD8 RID: 32728 RVA: 0x0038A014 File Offset: 0x00388214
	public static void DDCOAPNEAAN()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 1; i >= 1; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.EHBBFMCILPC))
			{
				int liveProfileThemesVersion = AssetsManager.MJBDMHPHMID().liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].GLLDFBGBLCM();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FD9 RID: 32729 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int HKFOCJDNMJO()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FDA RID: 32730 RVA: 0x0038643C File Offset: 0x0038463C
	public static void AANJPECHCHM()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FDB RID: 32731 RVA: 0x0038A0D8 File Offset: 0x003882D8
	private void BCEIKLADKKF()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(0);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = true;
	}

	// Token: 0x06007FDC RID: 32732 RVA: 0x0038A19C File Offset: 0x0038839C
	public static void PBLEJGPFJAH()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 0; i--)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.EHBBFMCILPC))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 0; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j += 0)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].EJEMDNIDIAP();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FDE RID: 32734 RVA: 0x0038A274 File Offset: 0x00388474
	public static JDMAEBPEIBE NANAAFLKGLO(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.MNADABECONL(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.OIMFJKOBMJL();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FDF RID: 32735 RVA: 0x0038A2D8 File Offset: 0x003884D8
	public void EDFNEODKEHE()
	{
		try
		{
			if (!(null == this.NNPPLMIKMHD))
			{
				if (GKJPOGNFKNK.AKJCGMFMGMK(this.JABJKOHNGPK))
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(this.JABJKOHNGPK);
					if (null == assetLiveProfileTheme || assetLiveProfileTheme.frames == null || assetLiveProfileTheme.frames.Count == 0)
					{
						this.MGPFDGLEIIG();
					}
					else
					{
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
						}
						if (null == this.CHDKPOMJHOE)
						{
							this.CHDKPOMJHOE = this.NNPPLMIKMHD.gameObject.AddComponent<ImageFrameAnimation>();
						}
						JDMAEBPEIBE.BMNGHIPEEGE(this.CHDKPOMJHOE, assetLiveProfileTheme);
						this.CHDKPOMJHOE.enabled = true;
						this.GBIABAHMEEG = true;
					}
				}
				else
				{
					this.PFIGHDBAPLI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FE0 RID: 32736 RVA: 0x0038A3C0 File Offset: 0x003885C0
	public static void GKIBGPHDKAD(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FE1 RID: 32737 RVA: 0x0038A42C File Offset: 0x0038862C
	public static void JBBLJAOPKBF(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x06007FE2 RID: 32738 RVA: 0x0038A498 File Offset: 0x00388698
	public static JDMAEBPEIBE EANEJFABNGK(Image JFKDEMMNEGP, int OAJKHHOKLHA)
	{
		if (null == JFKDEMMNEGP)
		{
			return null;
		}
		int num = JDMAEBPEIBE.MNADABECONL(JFKDEMMNEGP);
		JDMAEBPEIBE jdmaebpeibe = new JDMAEBPEIBE();
		jdmaebpeibe.NNPPLMIKMHD = JFKDEMMNEGP;
		jdmaebpeibe.JABJKOHNGPK = OAJKHHOKLHA;
		jdmaebpeibe.GLLDFBGBLCM();
		if (num >= 1 && num <= JDMAEBPEIBE.GFCOGEKNBLG.Count)
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Insert(num, jdmaebpeibe);
		}
		else
		{
			JDMAEBPEIBE.GFCOGEKNBLG.Add(jdmaebpeibe);
		}
		return jdmaebpeibe;
	}

	// Token: 0x06007FE3 RID: 32739 RVA: 0x0038A4FC File Offset: 0x003886FC
	public static void NNPBJJJGAKD()
	{
		try
		{
			for (int i = JDMAEBPEIBE.GFCOGEKNBLG.Count - 0; i >= 1; i -= 0)
			{
				if (null == JDMAEBPEIBE.GFCOGEKNBLG[i].NNPPLMIKMHD)
				{
					JDMAEBPEIBE.GFCOGEKNBLG.RemoveAt(i);
				}
			}
			if (!(null == AssetsManager.MJBDMHPHMID()))
			{
				int liveProfileThemesVersion = AssetsManager.EHBBFMCILPC.liveProfileThemesVersion;
				if (liveProfileThemesVersion != JDMAEBPEIBE.DLAPJBGFFGB)
				{
					JDMAEBPEIBE.DLAPJBGFFGB = liveProfileThemesVersion;
					for (int j = 1; j < JDMAEBPEIBE.GFCOGEKNBLG.Count; j++)
					{
						if (JDMAEBPEIBE.GFCOGEKNBLG[j].GBIABAHMEEG)
						{
							JDMAEBPEIBE.GFCOGEKNBLG[j].OOOJMNAHBHE();
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007FE4 RID: 32740 RVA: 0x003868CD File Offset: 0x00384ACD
	public static int OOOCBNDNGCE()
	{
		return JDMAEBPEIBE.GFCOGEKNBLG.Count;
	}

	// Token: 0x06007FE5 RID: 32741 RVA: 0x0038643C File Offset: 0x0038463C
	public static void ONJMMAGFPMD()
	{
		JDMAEBPEIBE.GFCOGEKNBLG.Clear();
		JDMAEBPEIBE.DLAPJBGFFGB = -1;
	}

	// Token: 0x06007FE6 RID: 32742 RVA: 0x0038A5C0 File Offset: 0x003887C0
	private void DPBHMIDOINB()
	{
		if (null == this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE = this.NNPPLMIKMHD.GetComponent<ImageFrameAnimation>();
		}
		if (null != this.CHDKPOMJHOE)
		{
			this.CHDKPOMJHOE.enabled = false;
		}
		Sprite sprite = null;
		if (null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(this.JABJKOHNGPK);
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(1);
			}
			if (null == sprite)
			{
				sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.PGPBFOGKCEI();
			}
		}
		this.NNPPLMIKMHD.sprite = sprite;
		this.GBIABAHMEEG = false;
	}

	// Token: 0x06007FE7 RID: 32743 RVA: 0x0038A684 File Offset: 0x00388884
	public static void GAJEHOOLCCK(ImageFrameAnimation EGAFPDKFGMO, AssetLiveProfileTheme NFJEHCIILMH)
	{
		if (null == EGAFPDKFGMO || null == NFJEHCIILMH || NFJEHCIILMH.frames == null)
		{
			return;
		}
		EGAFPDKFGMO.framesSD = NFJEHCIILMH.frames.ToArray();
		EGAFPDKFGMO.pauseTime = NFJEHCIILMH.pauseTime;
		EGAFPDKFGMO.pauseFrame = NFJEHCIILMH.pauseFrame;
		EGAFPDKFGMO.frameChangeInterval = NFJEHCIILMH.frameChangeInterval;
		EGAFPDKFGMO.reverseDirection = NFJEHCIILMH.reverseDirection;
	}

	// Token: 0x040024C8 RID: 9416
	public int JABJKOHNGPK = -1;

	// Token: 0x040024C9 RID: 9417
	public Image NNPPLMIKMHD;

	// Token: 0x040024CA RID: 9418
	public ImageFrameAnimation CHDKPOMJHOE;

	// Token: 0x040024CB RID: 9419
	public bool GBIABAHMEEG = true;

	// Token: 0x040024CC RID: 9420
	private static List<JDMAEBPEIBE> GFCOGEKNBLG = new List<JDMAEBPEIBE>();

	// Token: 0x040024CD RID: 9421
	private static int DLAPJBGFFGB = -1;
}
