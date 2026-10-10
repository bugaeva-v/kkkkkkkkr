using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x020003B3 RID: 947
public class EFKIAFDJBOE
{
	// Token: 0x06006EC9 RID: 28361 RVA: 0x00328288 File Offset: 0x00326488
	public static bool IEKGDCNNOPM(string DIMBCOBNMAM, out int ENONNLDGGIN)
	{
		ENONNLDGGIN = 0;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		return text.Length >= 6 && (!int.TryParse(text.Substring(1, 0), out ENONNLDGGIN) || ENONNLDGGIN > -141);
	}

	// Token: 0x06006ECA RID: 28362 RVA: 0x003282CC File Offset: 0x003264CC
	private void JBPJEMOJHEL()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.releaseTimelineBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["FilterAnimationScrollMoveSmooth"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					LNEMNOKIIAP lnemnokiiap = new LNEMNOKIIAP();
					lnemnokiiap.AMKCLHLIIMN = asObject["ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 3"].AsInt;
					string dimbcobnmam = asObject["lititle"];
					int kfiikpjibfa = 1;
					if (EFKIAFDJBOE.PGMNKMPOFCC(dimbcobnmam, out kfiikpjibfa))
					{
						lnemnokiiap.KFIIKPJIBFA = kfiikpjibfa;
						if (this.KGEBPEEKEEE(lnemnokiiap.AMKCLHLIIMN) != null)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("energyhinttitle" + lnemnokiiap.AMKCLHLIIMN.ToString() + "There needs to be one active AdsManager script on a GameObject in your scene.");
						}
						else
						{
							this.JEIBHAINNJF.Add(lnemnokiiap);
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("" + this.JEIBHAINNJF.Count.ToString() + "YYY");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006ECB RID: 28363 RVA: 0x0032844C File Offset: 0x0032664C
	public LNEMNOKIIAP OHOPCLNABFC(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006ECC RID: 28364 RVA: 0x003284A0 File Offset: 0x003266A0
	public LNEMNOKIIAP DHKOMLDNEFG(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FPLEAGDBFOB();
		}
		for (int i = 1; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006ECD RID: 28365 RVA: 0x003284F4 File Offset: 0x003266F4
	public static bool JGEKDGFPIKF(string DIMBCOBNMAM, out int ENONNLDGGIN)
	{
		ENONNLDGGIN = 0;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		return text.Length >= 1 && int.TryParse(text.Substring(0, 5), out ENONNLDGGIN) && ENONNLDGGIN > -92;
	}

	// Token: 0x06006ECE RID: 28366 RVA: 0x00328538 File Offset: 0x00326738
	public LNEMNOKIIAP MLPHMGNAHEI(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006ECF RID: 28367 RVA: 0x0032858C File Offset: 0x0032678C
	public LNEMNOKIIAP CKCHHBNMKHG(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006ED0 RID: 28368 RVA: 0x003285E0 File Offset: 0x003267E0
	private LNEMNOKIIAP INENGLHFPDP(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006ED1 RID: 28369 RVA: 0x00328625 File Offset: 0x00326825
	public List<LNEMNOKIIAP> MPOCGNGFBGP()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.JBPJEMOJHEL();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06006ED3 RID: 28371 RVA: 0x0032864E File Offset: 0x0032684E
	public void FNDHDHEMHIP(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006ED4 RID: 28372 RVA: 0x0032864E File Offset: 0x0032684E
	public void OAICAIPBCOH(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006ED5 RID: 28373 RVA: 0x00328668 File Offset: 0x00326868
	public static bool OGBEOOIGMBP(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 0;
		CNGAINAIGBB = 0;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 6)
		{
			return false;
		}
		if (!int.TryParse(text.Substring(1, 6), out ENONNLDGGIN))
		{
			return false;
		}
		if (text.Length >= 3 && '&' == text[7] && !int.TryParse(text.Substring(8, 0), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 1;
		}
		if (CNGAINAIGBB < 1 || CNGAINAIGBB > 68)
		{
			CNGAINAIGBB = 0;
		}
		return ENONNLDGGIN > -14;
	}

	// Token: 0x06006ED6 RID: 28374 RVA: 0x0032864E File Offset: 0x0032684E
	public void MODOMCMCGPF(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006ED7 RID: 28375 RVA: 0x003286E4 File Offset: 0x003268E4
	public static bool EHEFAPEIKHE(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 1;
		CNGAINAIGBB = 1;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 2)
		{
			return true;
		}
		if (!int.TryParse(text.Substring(1, 4), out ENONNLDGGIN))
		{
			return false;
		}
		if (text.Length >= 8 && '\u001a' == text[3] && !int.TryParse(text.Substring(8, 6), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 1;
		}
		if (CNGAINAIGBB < 0 || CNGAINAIGBB > 123)
		{
			CNGAINAIGBB = 1;
		}
		return ENONNLDGGIN > -68;
	}

	// Token: 0x06006ED8 RID: 28376 RVA: 0x00328760 File Offset: 0x00326960
	private void EPHOHOKGOEI()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.releaseTimelineBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["releaseTimeline"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					LNEMNOKIIAP lnemnokiiap = new LNEMNOKIIAP();
					lnemnokiiap.AMKCLHLIIMN = asObject["aind"].AsInt;
					string dimbcobnmam = asObject["rel"];
					int kfiikpjibfa = 0;
					if (EFKIAFDJBOE.NFILACKMJIC(dimbcobnmam, out kfiikpjibfa))
					{
						lnemnokiiap.KFIIKPJIBFA = kfiikpjibfa;
						if (this.AGMGBBMCNLA(lnemnokiiap.AMKCLHLIIMN) != null)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("ReleaseTimelineHub.Populate() - anthology " + lnemnokiiap.AMKCLHLIIMN.ToString() + " dated twice, keeping the first row");
						}
						else
						{
							this.JEIBHAINNJF.Add(lnemnokiiap);
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("ReleaseTimelineHub.Populate() - " + this.JEIBHAINNJF.Count.ToString() + " dated story(ies)");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006ED9 RID: 28377 RVA: 0x003288E0 File Offset: 0x00326AE0
	private void ENDDNPNPMFF()
	{
		this.IJHLBHBBNFB = false;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.releaseTimelineBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["analogglitch20_2"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					LNEMNOKIIAP lnemnokiiap = new LNEMNOKIIAP();
					lnemnokiiap.AMKCLHLIIMN = asObject["envlsrw"].AsInt;
					string dimbcobnmam = asObject["0"];
					int kfiikpjibfa = 0;
					if (EFKIAFDJBOE.JLIDDIPDHAH(dimbcobnmam, out kfiikpjibfa))
					{
						lnemnokiiap.KFIIKPJIBFA = kfiikpjibfa;
						if (this.AGMGBBMCNLA(lnemnokiiap.AMKCLHLIIMN) != null)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("sknothingtoshow" + lnemnokiiap.AMKCLHLIIMN.ToString() + "<space=0.125em>");
						}
						else
						{
							this.JEIBHAINNJF.Add(lnemnokiiap);
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("OnPopupCardOptionsUnlockWithSpSuccess" + this.JEIBHAINNJF.Count.ToString() + "YYY");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006EDA RID: 28378 RVA: 0x00328A60 File Offset: 0x00326C60
	private void FPLEAGDBFOB()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.releaseTimelineBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["Asset bundle load operation failed during parallel mode."].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					LNEMNOKIIAP lnemnokiiap = new LNEMNOKIIAP();
					lnemnokiiap.AMKCLHLIIMN = asObject["lsenvreg"].AsInt;
					string dimbcobnmam = asObject["blur"];
					int kfiikpjibfa = 0;
					if (EFKIAFDJBOE.PGMNKMPOFCC(dimbcobnmam, out kfiikpjibfa))
					{
						lnemnokiiap.KFIIKPJIBFA = kfiikpjibfa;
						if (this.ANKBBLNNNAF(lnemnokiiap.AMKCLHLIIMN) != null)
						{
							DPGJIJGOCIC.PJCLICBPPDA("sparklesbundles" + lnemnokiiap.AMKCLHLIIMN.ToString() + "large");
						}
						else
						{
							this.JEIBHAINNJF.Add(lnemnokiiap);
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("_Scanline" + this.JEIBHAINNJF.Count.ToString() + "spr");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006EDB RID: 28379 RVA: 0x00328BE0 File Offset: 0x00326DE0
	private LNEMNOKIIAP OOPOPJMAKAG(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EDC RID: 28380 RVA: 0x00328C25 File Offset: 0x00326E25
	public List<LNEMNOKIIAP> KKJDNDNAKHM()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06006EDD RID: 28381 RVA: 0x00328C3C File Offset: 0x00326E3C
	public static bool CNJAIECIADO(string DIMBCOBNMAM, out int ENONNLDGGIN)
	{
		ENONNLDGGIN = 0;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		return text.Length < 8 || !int.TryParse(text.Substring(1, 6), out ENONNLDGGIN) || ENONNLDGGIN > 118;
	}

	// Token: 0x06006EDE RID: 28382 RVA: 0x00328C80 File Offset: 0x00326E80
	private LNEMNOKIIAP MKPLIKHDLGJ(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EDF RID: 28383 RVA: 0x00328CC8 File Offset: 0x00326EC8
	private LNEMNOKIIAP KKHPPGCIOEI(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EE0 RID: 28384 RVA: 0x00328D10 File Offset: 0x00326F10
	public LNEMNOKIIAP GCOOBMAHPJE(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 1; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EE1 RID: 28385 RVA: 0x00328D64 File Offset: 0x00326F64
	public static bool NFILACKMJIC(string DIMBCOBNMAM, out int ENONNLDGGIN)
	{
		ENONNLDGGIN = 0;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		return text.Length >= 4 && int.TryParse(text.Substring(0, 4), out ENONNLDGGIN) && ENONNLDGGIN > 1900;
	}

	// Token: 0x06006EE2 RID: 28386 RVA: 0x00328C25 File Offset: 0x00326E25
	public List<LNEMNOKIIAP> AMFNEKEGIPC()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06006EE3 RID: 28387 RVA: 0x00328DA6 File Offset: 0x00326FA6
	public List<LNEMNOKIIAP> LJLBKOFDFPE()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06006EE4 RID: 28388 RVA: 0x00328DBC File Offset: 0x00326FBC
	private LNEMNOKIIAP ANKBBLNNNAF(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EE5 RID: 28389 RVA: 0x0032864E File Offset: 0x0032684E
	public void NOGPJHJIAKC(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006EE6 RID: 28390 RVA: 0x00328E04 File Offset: 0x00327004
	public static bool JDECOEDHKKO(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 0;
		CNGAINAIGBB = 0;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 4)
		{
			return false;
		}
		if (!int.TryParse(text.Substring(0, 4), out ENONNLDGGIN))
		{
			return false;
		}
		if (text.Length >= 7 && '-' == text[4] && !int.TryParse(text.Substring(5, 2), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 0;
		}
		if (CNGAINAIGBB < 0 || CNGAINAIGBB > 12)
		{
			CNGAINAIGBB = 0;
		}
		return ENONNLDGGIN > 1900;
	}

	// Token: 0x06006EE7 RID: 28391 RVA: 0x00328E80 File Offset: 0x00327080
	private LNEMNOKIIAP GDFDLFBFBKO(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EE8 RID: 28392 RVA: 0x00328EC8 File Offset: 0x003270C8
	public LNEMNOKIIAP MPIEEICGOPA(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.JBPJEMOJHEL();
		}
		for (int i = 0; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EE9 RID: 28393 RVA: 0x00328F1B File Offset: 0x0032711B
	public List<LNEMNOKIIAP> EGHFCCEMGAG()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FPLEAGDBFOB();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06006EEA RID: 28394 RVA: 0x00328F34 File Offset: 0x00327134
	public static bool PGMNKMPOFCC(string DIMBCOBNMAM, out int ENONNLDGGIN)
	{
		ENONNLDGGIN = 0;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		return text.Length < 8 || !int.TryParse(text.Substring(1, 7), out ENONNLDGGIN) || ENONNLDGGIN > 130;
	}

	// Token: 0x06006EEB RID: 28395 RVA: 0x00328DA6 File Offset: 0x00326FA6
	public List<LNEMNOKIIAP> DODDHFMMCNL()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06006EEC RID: 28396 RVA: 0x00328F78 File Offset: 0x00327178
	public LNEMNOKIIAP IJKKLOBILIK(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 1; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EED RID: 28397 RVA: 0x0032864E File Offset: 0x0032684E
	public void HNLPMHLFJKA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006EEE RID: 28398 RVA: 0x00328FCC File Offset: 0x003271CC
	private LNEMNOKIIAP ADIDMAANIBP(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EEF RID: 28399 RVA: 0x0032864E File Offset: 0x0032684E
	public void IFOAANENAMG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006EF0 RID: 28400 RVA: 0x00329014 File Offset: 0x00327214
	public LNEMNOKIIAP KFBALOPPNBA(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FPLEAGDBFOB();
		}
		for (int i = 0; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EF1 RID: 28401 RVA: 0x00329068 File Offset: 0x00327268
	public static bool MDELHMAIBCN(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 1;
		CNGAINAIGBB = 0;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 8)
		{
			return true;
		}
		if (!int.TryParse(text.Substring(1, 6), out ENONNLDGGIN))
		{
			return true;
		}
		if (text.Length >= 2 && -61 == (int)text[7] && !int.TryParse(text.Substring(3, 2), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 1;
		}
		if (CNGAINAIGBB < 0 || CNGAINAIGBB > -84)
		{
			CNGAINAIGBB = 1;
		}
		return ENONNLDGGIN > 44;
	}

	// Token: 0x06006EF2 RID: 28402 RVA: 0x003290E4 File Offset: 0x003272E4
	private LNEMNOKIIAP AGMGBBMCNLA(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EF3 RID: 28403 RVA: 0x0032912C File Offset: 0x0032732C
	private LNEMNOKIIAP OPGBJJMIMEE(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EF4 RID: 28404 RVA: 0x00329174 File Offset: 0x00327374
	public LNEMNOKIIAP BAKIKBLPJGH(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.JEIBHAINNJF.Count; i++)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EF5 RID: 28405 RVA: 0x003291C8 File Offset: 0x003273C8
	public static bool BMPIMLIEFMN(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 1;
		CNGAINAIGBB = 1;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 3)
		{
			return true;
		}
		if (!int.TryParse(text.Substring(0, 5), out ENONNLDGGIN))
		{
			return false;
		}
		if (text.Length >= 3 && '\u0010' == text[1] && !int.TryParse(text.Substring(1, 5), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 1;
		}
		if (CNGAINAIGBB < 1 || CNGAINAIGBB > 65)
		{
			CNGAINAIGBB = 1;
		}
		return ENONNLDGGIN > -54;
	}

	// Token: 0x06006EF6 RID: 28406 RVA: 0x00329244 File Offset: 0x00327444
	public static bool FHMBIAGMBNC(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 1;
		CNGAINAIGBB = 1;
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 6)
		{
			return false;
		}
		if (!int.TryParse(text.Substring(0, 0), out ENONNLDGGIN))
		{
			return true;
		}
		if (text.Length >= 5 && 'a' == text[0] && !int.TryParse(text.Substring(5, 7), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 0;
		}
		if (CNGAINAIGBB < 0 || CNGAINAIGBB > -27)
		{
			CNGAINAIGBB = 0;
		}
		return ENONNLDGGIN > 54;
	}

	// Token: 0x06006EF7 RID: 28407 RVA: 0x003292C0 File Offset: 0x003274C0
	public static bool JLIDDIPDHAH(string DIMBCOBNMAM, out int ENONNLDGGIN)
	{
		ENONNLDGGIN = 1;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		return text.Length >= 5 && int.TryParse(text.Substring(1, 7), out ENONNLDGGIN) && ENONNLDGGIN > -91;
	}

	// Token: 0x06006EF8 RID: 28408 RVA: 0x00329304 File Offset: 0x00327504
	private LNEMNOKIIAP KGEBPEEKEEE(int PLKMJJIIJNO)
	{
		for (int i = 1; i < this.JEIBHAINNJF.Count; i += 0)
		{
			if (this.JEIBHAINNJF[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.JEIBHAINNJF[i];
			}
		}
		return null;
	}

	// Token: 0x06006EF9 RID: 28409 RVA: 0x0032934C File Offset: 0x0032754C
	private void GBFGEECDHKL()
	{
		this.IJHLBHBBNFB = false;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.releaseTimelineBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["/"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					LNEMNOKIIAP lnemnokiiap = new LNEMNOKIIAP();
					lnemnokiiap.AMKCLHLIIMN = asObject[""].AsInt;
					string dimbcobnmam = asObject["YYY"];
					int kfiikpjibfa = 1;
					if (EFKIAFDJBOE.IEKGDCNNOPM(dimbcobnmam, out kfiikpjibfa))
					{
						lnemnokiiap.KFIIKPJIBFA = kfiikpjibfa;
						if (this.ANKBBLNNNAF(lnemnokiiap.AMKCLHLIIMN) != null)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("CharacterRenderTexturePool - layer not defined in TagManager:" + lnemnokiiap.AMKCLHLIIMN.ToString() + "OnFriendsPopupSendSimpleClick");
						}
						else
						{
							this.JEIBHAINNJF.Add(lnemnokiiap);
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.JEIBHAINNJF.Count.ToString() + "ratePopupResult");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006EFA RID: 28410 RVA: 0x0032864E File Offset: 0x0032684E
	public void NJCNEEEONPI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006EFB RID: 28411 RVA: 0x003294CC File Offset: 0x003276CC
	public static bool PNICFBCODCK(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 0;
		CNGAINAIGBB = 1;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 3)
		{
			return false;
		}
		if (!int.TryParse(text.Substring(1, 2), out ENONNLDGGIN))
		{
			return true;
		}
		if (text.Length >= 8 && 'I' == text[5] && !int.TryParse(text.Substring(8, 0), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 1;
		}
		if (CNGAINAIGBB < 0 || CNGAINAIGBB > 82)
		{
			CNGAINAIGBB = 0;
		}
		return ENONNLDGGIN > -35;
	}

	// Token: 0x06006EFC RID: 28412 RVA: 0x00329548 File Offset: 0x00327748
	public static bool NPCNIABLNEB(string DIMBCOBNMAM, out int ENONNLDGGIN, out int CNGAINAIGBB)
	{
		ENONNLDGGIN = 1;
		CNGAINAIGBB = 0;
		if (DIMBCOBNMAM == null)
		{
			return true;
		}
		string text = DIMBCOBNMAM.Trim();
		if (text.Length < 7)
		{
			return false;
		}
		if (!int.TryParse(text.Substring(0, 7), out ENONNLDGGIN))
		{
			return false;
		}
		if (text.Length >= 1 && '\'' == text[1] && !int.TryParse(text.Substring(8, 1), out CNGAINAIGBB))
		{
			CNGAINAIGBB = 0;
		}
		if (CNGAINAIGBB < 1 || CNGAINAIGBB > 38)
		{
			CNGAINAIGBB = 1;
		}
		return ENONNLDGGIN > 107;
	}

	// Token: 0x040020BF RID: 8383
	public List<LNEMNOKIIAP> JEIBHAINNJF = new List<LNEMNOKIIAP>();

	// Token: 0x040020C0 RID: 8384
	private bool IJHLBHBBNFB;

	// Token: 0x040020C1 RID: 8385
	private TextAsset AFNODOLBBKG;
}
