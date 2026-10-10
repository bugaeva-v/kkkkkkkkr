using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Token: 0x02000490 RID: 1168
public class HIOOJLFHBAH
{
	// Token: 0x06008DA2 RID: 36258 RVA: 0x003EB76D File Offset: 0x003E996D
	public void MPOEFJBEKIJ(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.NEDPAGFLFNO();
		this.FILFGDIGINA = FADIGFEOCND.JHMKFKNAADK(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DA4 RID: 36260 RVA: 0x003EB7A8 File Offset: 0x003E99A8
	public void IPFFMCBGCPP(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 0; i < this.MONOEFPDELM.Count; i++)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DA5 RID: 36261 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void HBKMEMLHCMI()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DA6 RID: 36262 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool KOHFAMMKCAB()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DA7 RID: 36263 RVA: 0x003EB820 File Offset: 0x003E9A20
	public void DHNMBIDKCEG()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.BGMALDJFMKE(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DA8 RID: 36264 RVA: 0x003EB83C File Offset: 0x003E9A3C
	public void BNCAGDKIEJI()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.HGCJDCDEHOK())
		{
			for (int i = 1; i < this.MONOEFPDELM.Count; i += 0)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 1)
			{
				AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC(this.GHJANNBEODN, 1699f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FILFGDIGINA.ODHBINFKIPL()), false);
			}
		}
	}

	// Token: 0x06008DA9 RID: 36265 RVA: 0x003EB968 File Offset: 0x003E9B68
	public void JCMJALODDBA(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 0; i < this.MONOEFPDELM.Count; i++)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DAA RID: 36266 RVA: 0x003EB9CC File Offset: 0x003E9BCC
	public void BCHHCAKLHLO(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.OHMAKIJIHAL();
		this.FILFGDIGINA = FADIGFEOCND.BJBLIEKKAPF(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DAB RID: 36267 RVA: 0x003EB9E8 File Offset: 0x003E9BE8
	public void ALOIMGKAJJP(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 1; i < this.MONOEFPDELM.Count; i += 0)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DAC RID: 36268 RVA: 0x003EBA4C File Offset: 0x003E9C4C
	public void BKNGGJFCHIK()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.BILMOCMPCON())
		{
			for (int i = 1; i < this.MONOEFPDELM.Count; i += 0)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND(this.GHJANNBEODN, 1026f);
			}
		}
		for (int j = 0; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FILFGDIGINA.ODBOJGMLKHA()), false);
			}
		}
	}

	// Token: 0x06008DAD RID: 36269 RVA: 0x003EBB78 File Offset: 0x003E9D78
	public void IFJKKPNBGOK(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 0; i < this.MONOEFPDELM.Count; i += 0)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DAE RID: 36270 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool EFGLBHGHAEN()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DAF RID: 36271 RVA: 0x003EBBDC File Offset: 0x003E9DDC
	public void LLMCLMAOLMC(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.GOKBFDPHGOJ();
		this.FILFGDIGINA = FADIGFEOCND.BJBLIEKKAPF(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DB0 RID: 36272 RVA: 0x003EBBF7 File Offset: 0x003E9DF7
	public void EOFNLAOCKGN()
	{
		this.MONOEFPDELM.Clear();
		this.BGMALDJFMKE();
	}

	// Token: 0x06008DB1 RID: 36273 RVA: 0x003EBC0A File Offset: 0x003E9E0A
	public void BAMHPOCKBML(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.BGMALDJFMKE();
		this.FILFGDIGINA = FADIGFEOCND.IMEFIJEKFGI(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DB2 RID: 36274 RVA: 0x003EBC28 File Offset: 0x003E9E28
	public void JMIEGJKLIJA()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.OGIIHGIBCDF())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(true);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM(this.GHJANNBEODN, 1162f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FILFGDIGINA.KDIFNBPNLPN()), true);
			}
		}
	}

	// Token: 0x06008DB3 RID: 36275 RVA: 0x003EBBDC File Offset: 0x003E9DDC
	public void BINMFOOKFPC(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.GOKBFDPHGOJ();
		this.FILFGDIGINA = FADIGFEOCND.BJBLIEKKAPF(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DB4 RID: 36276 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void BKKEIPDEHHB()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DB5 RID: 36277 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void NKFGODCEFIM()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DB6 RID: 36278 RVA: 0x003EBD54 File Offset: 0x003E9F54
	public void IGDGHFKGEOL()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.POFGLJODNHP())
		{
			for (int i = 1; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK(this.GHJANNBEODN, 530f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j += 0)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.KDIFNBPNLPN()), false);
			}
		}
	}

	// Token: 0x06008DB7 RID: 36279 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void DBKCKKKOBIC()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DB8 RID: 36280 RVA: 0x003EBE80 File Offset: 0x003EA080
	public void HIIFPFHIDEP()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.CKCGKEHFOOK())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i += 0)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(false);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 1)
			{
				AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI(this.GHJANNBEODN, 303f);
			}
		}
		for (int j = 0; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.KDIFNBPNLPN()), true);
			}
		}
	}

	// Token: 0x06008DB9 RID: 36281 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool BKBKILGDDFK()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DBA RID: 36282 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool LDKOPIMHGOG()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DBB RID: 36283 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void MAIFDKCPFDN()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DBC RID: 36284 RVA: 0x003EBFC8 File Offset: 0x003EA1C8
	public void CJHFPCNEHGB()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.HGCJDCDEHOK())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC(this.GHJANNBEODN, 1486f);
			}
		}
		for (int j = 0; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.EKJIJLMOBIG()), true);
			}
		}
	}

	// Token: 0x06008DBD RID: 36285 RVA: 0x003EC0F4 File Offset: 0x003EA2F4
	public void IIPBKOPAGBK()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.HACBALNLLPP())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.GHJANNBEODN, 0f);
			}
		}
		for (int j = 0; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.ODHBINFKIPL()), true);
			}
		}
	}

	// Token: 0x06008DBE RID: 36286 RVA: 0x003EC21E File Offset: 0x003EA41E
	public void KCCIKMEBLGF()
	{
		this.MONOEFPDELM.Clear();
		this.OHMAKIJIHAL();
	}

	// Token: 0x06008DBF RID: 36287 RVA: 0x003EC234 File Offset: 0x003EA434
	public void JDILGEPOJFA(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 1; i < this.MONOEFPDELM.Count; i += 0)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DC0 RID: 36288 RVA: 0x003EC298 File Offset: 0x003EA498
	public void NGCNFNNMPKC(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.DHNMBIDKCEG();
		this.FILFGDIGINA = FADIGFEOCND.JHMKFKNAADK(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DC1 RID: 36289 RVA: 0x003EC2B3 File Offset: 0x003EA4B3
	public void NLNAHILOFOM(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.GCGHHMILHEP();
		this.FILFGDIGINA = FADIGFEOCND.MPPPABFFGKJ(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DC2 RID: 36290 RVA: 0x003EC2CE File Offset: 0x003EA4CE
	public void MBMFLGKLEJI(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.JBDDABDBCEA();
		this.FILFGDIGINA = FADIGFEOCND.JHMKFKNAADK(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DC3 RID: 36291 RVA: 0x003EC2E9 File Offset: 0x003EA4E9
	public void JAHMBOAKMLG()
	{
		this.MONOEFPDELM.Clear();
		this.ICGEFHFBGEC();
	}

	// Token: 0x06008DC4 RID: 36292 RVA: 0x003EC2FC File Offset: 0x003EA4FC
	public void DFFMNJDFNJG(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.JBDDABDBCEA();
		this.FILFGDIGINA = FADIGFEOCND.IMEFIJEKFGI(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DC5 RID: 36293 RVA: 0x003EC317 File Offset: 0x003EA517
	public void DMDMBIHCEIB()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DC6 RID: 36294 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void LKEBGNIFHBG()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DC7 RID: 36295 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void CDCDGOIOCBP()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DC8 RID: 36296 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void KFAELIGAOMK()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DC9 RID: 36297 RVA: 0x003EC320 File Offset: 0x003EA520
	public void MIOMPIGJKFE(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.PAPONMIKCPA();
		this.FILFGDIGINA = FADIGFEOCND.IMEFIJEKFGI(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DCA RID: 36298 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void JBDDABDBCEA()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DCB RID: 36299 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool GEGPMDNGALM()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DCC RID: 36300 RVA: 0x003EC33C File Offset: 0x003EA53C
	public void ACJDLLIOGMJ()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.HACBALNLLPP())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i += 0)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(false);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK(this.GHJANNBEODN, 1179f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j += 0)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.EBAFNCLPHKM()), false);
			}
		}
	}

	// Token: 0x06008DCD RID: 36301 RVA: 0x003EC468 File Offset: 0x003EA668
	public void BMMJANPGBFK(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 0; i < this.MONOEFPDELM.Count; i += 0)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DCE RID: 36302 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void HHMLIJNHEML()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DCF RID: 36303 RVA: 0x003EC320 File Offset: 0x003EA520
	public void LPJCNKJFKJI(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.PAPONMIKCPA();
		this.FILFGDIGINA = FADIGFEOCND.IMEFIJEKFGI(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DD0 RID: 36304 RVA: 0x003EB820 File Offset: 0x003E9A20
	public void NEDPAGFLFNO()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.BGMALDJFMKE(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DD1 RID: 36305 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void GCGHHMILHEP()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DD2 RID: 36306 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void GOKBFDPHGOJ()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DD3 RID: 36307 RVA: 0x003EC4CC File Offset: 0x003EA6CC
	public void FBACPHFCHJK(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.GCGHHMILHEP();
		this.FILFGDIGINA = FADIGFEOCND.JHMKFKNAADK(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DD4 RID: 36308 RVA: 0x003EC4E8 File Offset: 0x003EA6E8
	public void OFEFHGNPCPE()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.LMKOIDOJNEJ())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i += 0)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(true);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(false);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 1)
			{
				AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI(this.GHJANNBEODN, 53f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j += 0)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FILFGDIGINA.EBAFNCLPHKM()), false);
			}
		}
	}

	// Token: 0x06008DD5 RID: 36309 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool OEFNNFAIJDP()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DD6 RID: 36310 RVA: 0x003EC317 File Offset: 0x003EA517
	public void OOBJMOMDIHE()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DD7 RID: 36311 RVA: 0x003EC317 File Offset: 0x003EA517
	public void LFDMAHOKDOI()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DD8 RID: 36312 RVA: 0x003EC612 File Offset: 0x003EA812
	public void JIMALBGDGGJ()
	{
		this.MONOEFPDELM.Clear();
		this.GCGHHMILHEP();
	}

	// Token: 0x06008DD9 RID: 36313 RVA: 0x003EC625 File Offset: 0x003EA825
	public void MCOMCHOLOOO(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.NEDPAGFLFNO();
		this.FILFGDIGINA = FADIGFEOCND.BJBLIEKKAPF(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DDA RID: 36314 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void IBFMGNHPONG()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DDB RID: 36315 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool PMPIODCNDAN()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DDC RID: 36316 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void CBOAJPHHFCI()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DDD RID: 36317 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void OHMAKIJIHAL()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DDE RID: 36318 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void OCDLJHPJNGO()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DDF RID: 36319 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool LLGCNDDABDK()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DE0 RID: 36320 RVA: 0x003EC640 File Offset: 0x003EA840
	public void CEIDMENJBNK()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.HILFMLEHIKF())
		{
			for (int i = 1; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(true);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND(this.GHJANNBEODN, 329f);
			}
		}
		for (int j = 0; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FILFGDIGINA.LEAIEAIEBJK()), false);
			}
		}
	}

	// Token: 0x06008DE1 RID: 36321 RVA: 0x003EC76A File Offset: 0x003EA96A
	public void LLJFPDHNPPI()
	{
		this.MONOEFPDELM.Clear();
		this.FCIONGCDIGH();
	}

	// Token: 0x06008DE2 RID: 36322 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void FCIONGCDIGH()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DE3 RID: 36323 RVA: 0x003EC21E File Offset: 0x003EA41E
	public void PMFNEJDGPPN()
	{
		this.MONOEFPDELM.Clear();
		this.OHMAKIJIHAL();
	}

	// Token: 0x06008DE4 RID: 36324 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void GEAJEFGKFLN()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DE5 RID: 36325 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool MFAKJKFHELL()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DE6 RID: 36326 RVA: 0x003EC77D File Offset: 0x003EA97D
	public void DHFBMDJPBNP()
	{
		this.MONOEFPDELM.Clear();
		this.MAIFDKCPFDN();
	}

	// Token: 0x06008DE7 RID: 36327 RVA: 0x003EC790 File Offset: 0x003EA990
	public void GAGKLKHJGPO()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.CKCGKEHFOOK())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(false);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 1)
			{
				AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK(this.GHJANNBEODN, 1547f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j++)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.EKJIJLMOBIG()), true);
			}
		}
	}

	// Token: 0x06008DE8 RID: 36328 RVA: 0x003EC8BA File Offset: 0x003EAABA
	public void MHKHGHMJDJJ(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.FCIONGCDIGH();
		this.FILFGDIGINA = FADIGFEOCND.IMEFIJEKFGI(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DE9 RID: 36329 RVA: 0x003EC317 File Offset: 0x003EA517
	public void LHIAGHLGLEB()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DEA RID: 36330 RVA: 0x003EC8D5 File Offset: 0x003EAAD5
	public void OIGPAKEFAGM(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.GOKBFDPHGOJ();
		this.FILFGDIGINA = FADIGFEOCND.JHMKFKNAADK(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DEB RID: 36331 RVA: 0x003EC8F0 File Offset: 0x003EAAF0
	public void MDBDJPIGPPI()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.IOAPKMHNIHM())
		{
			for (int i = 1; i < this.MONOEFPDELM.Count; i++)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 1)
			{
				AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK(this.GHJANNBEODN, 504f);
			}
		}
		for (int j = 1; j < this.MONOEFPDELM.Count; j += 0)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FILFGDIGINA.LFLAIPLKINK()), false);
			}
		}
	}

	// Token: 0x06008DEC RID: 36332 RVA: 0x003EC317 File Offset: 0x003EA517
	public void BMJDLMJCJMD()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DED RID: 36333 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool FACIFBONANM()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DEE RID: 36334 RVA: 0x003EBFAA File Offset: 0x003EA1AA
	public void PAPONMIKCPA()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.IOENHNIKIIC(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DEF RID: 36335 RVA: 0x003ECA1A File Offset: 0x003EAC1A
	public void JEPFODDLOFK(float BGGFINBILDM, string OEMJMJCPDLG = "")
	{
		this.ICGEFHFBGEC();
		this.FILFGDIGINA = FADIGFEOCND.JHMKFKNAADK(BGGFINBILDM);
		this.GHJANNBEODN = OEMJMJCPDLG;
	}

	// Token: 0x06008DF0 RID: 36336 RVA: 0x003EC317 File Offset: 0x003EA517
	public void DHINPLBIEEC()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DF1 RID: 36337 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool JBPEAIBJPFP()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x06008DF2 RID: 36338 RVA: 0x003EB820 File Offset: 0x003E9A20
	public void BGMALDJFMKE()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.BGMALDJFMKE(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DF3 RID: 36339 RVA: 0x003ECA35 File Offset: 0x003EAC35
	public void KEBLIIIACCM()
	{
		this.MONOEFPDELM.Clear();
		this.DHNMBIDKCEG();
	}

	// Token: 0x06008DF4 RID: 36340 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void HGPCHJEMJLL()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DF5 RID: 36341 RVA: 0x003EC317 File Offset: 0x003EA517
	public void LBGGPGIMLMF()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DF6 RID: 36342 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void PHPBKOEDKLP()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DF7 RID: 36343 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void IAKJBMKNFNE()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DF8 RID: 36344 RVA: 0x003ECA48 File Offset: 0x003EAC48
	public void FOPEDJBIAHA(TextMeshProUGUI AHFFAOEIBNA, GameObject PNMGPJFKFEP = null, GameObject EKMAGLGLAAE = null)
	{
		for (int i = 0; i < this.MONOEFPDELM.Count; i++)
		{
			if (this.MONOEFPDELM[i].DPLMFJDDAKD == AHFFAOEIBNA)
			{
				return;
			}
		}
		HJPFHJELFCB hjpfhjelfcb = new HJPFHJELFCB();
		hjpfhjelfcb.DPLMFJDDAKD = AHFFAOEIBNA;
		hjpfhjelfcb.EHMGEKKEGKJ = PNMGPJFKFEP;
		hjpfhjelfcb.POHLANMNPNH = EKMAGLGLAAE;
		this.MONOEFPDELM.Add(hjpfhjelfcb);
	}

	// Token: 0x06008DF9 RID: 36345 RVA: 0x003EC317 File Offset: 0x003EA517
	public void JNEMMBFBPNC()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06008DFA RID: 36346 RVA: 0x003ECAAC File Offset: 0x003EACAC
	public void MJBIDAKAFEN()
	{
		if (this.FILFGDIGINA == null || this.DPNFENJDCEO)
		{
			return;
		}
		if (this.FILFGDIGINA.HACBALNLLPP())
		{
			for (int i = 0; i < this.MONOEFPDELM.Count; i += 0)
			{
				if (null != this.MONOEFPDELM[i].EHMGEKKEGKJ)
				{
					this.MONOEFPDELM[i].EHMGEKKEGKJ.SetActive(false);
				}
				if (null != this.MONOEFPDELM[i].POHLANMNPNH)
				{
					this.MONOEFPDELM[i].POHLANMNPNH.SetActive(true);
				}
			}
			if (this.GHJANNBEODN != null && this.GHJANNBEODN.Length > 0)
			{
				AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC(this.GHJANNBEODN, 1266f);
			}
		}
		for (int j = 0; j < this.MONOEFPDELM.Count; j += 0)
		{
			if (this.MONOEFPDELM[j].DPLMFJDDAKD.gameObject.activeSelf)
			{
				this.MONOEFPDELM[j].DPLMFJDDAKD.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FILFGDIGINA.LEAIEAIEBJK()), false);
			}
		}
	}

	// Token: 0x06008DFB RID: 36347 RVA: 0x003EB80C File Offset: 0x003E9A0C
	public void GDOJDEACIGM()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06008DFC RID: 36348 RVA: 0x003EB820 File Offset: 0x003E9A20
	public void ICGEFHFBGEC()
	{
		if (this.FILFGDIGINA != null)
		{
			FADIGFEOCND.BGMALDJFMKE(this.FILFGDIGINA);
			this.FILFGDIGINA = null;
		}
	}

	// Token: 0x06008DFD RID: 36349 RVA: 0x003EB815 File Offset: 0x003E9A15
	public bool LHHMAAMNKAM()
	{
		return this.FILFGDIGINA != null;
	}

	// Token: 0x04002774 RID: 10100
	private List<HJPFHJELFCB> MONOEFPDELM = new List<HJPFHJELFCB>();

	// Token: 0x04002775 RID: 10101
	private FADIGFEOCND FILFGDIGINA;

	// Token: 0x04002776 RID: 10102
	private string GHJANNBEODN = "";

	// Token: 0x04002777 RID: 10103
	private bool DPNFENJDCEO;
}
