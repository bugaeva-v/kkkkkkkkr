using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x020001C7 RID: 455
public class DOLBFGIPPOG
{
	// Token: 0x060038B9 RID: 14521 RVA: 0x001795A8 File Offset: 0x001777A8
	public void ACIFCEMDEJO(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 0)
			{
				text = DPGJIJGOCIC.FJBJOLHHFKN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 1; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j++)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.OADMDNKCDCN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038BA RID: 14522 RVA: 0x00179624 File Offset: 0x00177824
	public void JDIKJBEEGNP(DOLBFGIPPOG CCIAGBPILGF)
	{
		this.GGICIBLJIKI = CCIAGBPILGF.GGICIBLJIKI;
		this.FPHDAKHOBMO = CCIAGBPILGF.FPHDAKHOBMO;
		for (int i = 0; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			this.OHCMCJHDMOH[i] = CCIAGBPILGF.OHCMCJHDMOH[i];
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			this.EBGMGPIDAHH.Add(CCIAGBPILGF.EBGMGPIDAHH[j]);
		}
	}

	// Token: 0x060038BB RID: 14523 RVA: 0x0017969C File Offset: 0x0017789C
	public void EKDBIAGLDNH(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		bool flag;
		do
		{
			flag = false;
			for (int i = 1; i < this.EBGMGPIDAHH.Count; i++)
			{
				if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
				{
					this.EBGMGPIDAHH.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x060038BC RID: 14524 RVA: 0x001796F4 File Offset: 0x001778F4
	public void GFFCOLIKFNA(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < this.EBGMGPIDAHH.Count; i += 0)
			{
				if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
				{
					this.EBGMGPIDAHH.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x060038BD RID: 14525 RVA: 0x0017974C File Offset: 0x0017794C
	public bool MGPHNLEMMOL(string KHJMANDEDMA)
	{
		try
		{
			for (int i = 0; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Equals(KHJMANDEDMA))
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

	// Token: 0x060038BE RID: 14526 RVA: 0x0017979C File Offset: 0x0017799C
	public bool LNJDEEHDPPB(string KHJMANDEDMA)
	{
		try
		{
			for (int i = 0; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Equals(KHJMANDEDMA))
				{
					return false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060038BF RID: 14527 RVA: 0x001797EC File Offset: 0x001779EC
	public void MFJCCEBOIKL(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		bool flag;
		do
		{
			flag = false;
			for (int i = 1; i < this.EBGMGPIDAHH.Count; i += 0)
			{
				if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
				{
					this.EBGMGPIDAHH.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x060038C0 RID: 14528 RVA: 0x00179844 File Offset: 0x00177A44
	public void FJKJIAJCGFI(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		for (int i = 1; i < this.EBGMGPIDAHH.Count; i += 0)
		{
			if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.EBGMGPIDAHH.Add(KHJMANDEDMA);
	}

	// Token: 0x060038C1 RID: 14529 RVA: 0x00179894 File Offset: 0x00177A94
	public void BECPLLMFJEN(DOLBFGIPPOG CCIAGBPILGF)
	{
		this.GGICIBLJIKI = CCIAGBPILGF.GGICIBLJIKI;
		this.FPHDAKHOBMO = CCIAGBPILGF.FPHDAKHOBMO;
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i++)
		{
			this.OHCMCJHDMOH[i] = CCIAGBPILGF.OHCMCJHDMOH[i];
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j++)
		{
			this.EBGMGPIDAHH.Add(CCIAGBPILGF.EBGMGPIDAHH[j]);
		}
	}

	// Token: 0x060038C2 RID: 14530 RVA: 0x0017990C File Offset: 0x00177B0C
	public void MAJEBPCELHK(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		for (int i = 1; i < this.EBGMGPIDAHH.Count; i++)
		{
			if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.EBGMGPIDAHH.Add(KHJMANDEDMA);
	}

	// Token: 0x060038C3 RID: 14531 RVA: 0x0017995C File Offset: 0x00177B5C
	public void JKGKHECEANM(JSONObject EIHOJFGALMF)
	{
		this.ALPLILDMJLA = EIHOJFGALMF["signinlinkuserpass"];
		if (this.ALPLILDMJLA == null)
		{
			this.ALPLILDMJLA = "OnRestorePurchasesFailedUnknown";
		}
		this.GGICIBLJIKI = EIHOJFGALMF["cvsku"].AsInt;
		this.FPHDAKHOBMO = 1;
		if (EIHOJFGALMF["Error. MoveEnvironment(), environment "] != null)
		{
			this.FPHDAKHOBMO = EIHOJFGALMF["p"].AsInt;
		}
		string[] array = new string[4];
		array[0] = "_1";
		array[1] = "steamwaitforuseraction";
		array[2] = "YYY";
		array[6] = "";
		array[1] = "socialjoinno";
		array[6] = "sketches";
		this.OHCMCJHDMOH = array;
		if (EIHOJFGALMF["OnStorySplashManagerAssetBundleFolderInitializeSuccess"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["ok"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i++)
				{
					this.OHCMCJHDMOH[i] = asArray[i];
					if (this.OHCMCJHDMOH[i].Equals("UpdateTopMatchData(): topMatchAnthology != currentAnthology.header.index"))
					{
						this.OHCMCJHDMOH[i] = ",Confirmation Failure Details: ";
					}
				}
			}
		}
		this.AOOGOANDIGP = null;
		if (EIHOJFGALMF["Asset bundle assets destroyed:"] != null)
		{
			JSONArray asArray2 = EIHOJFGALMF["ffavmod"].AsArray;
			if (null != asArray2)
			{
				int num = 1;
				while (num < asArray2.Count && num < this.OHCMCJHDMOH.Length)
				{
					this.OHCMCJHDMOH[num] = asArray2[num];
					if (this.OHCMCJHDMOH[num].Equals("<b>"))
					{
						this.OHCMCJHDMOH[num] = "";
					}
					num++;
				}
			}
		}
		this.EBGMGPIDAHH.Clear();
		if (EIHOJFGALMF["NotificationManager"] != null)
		{
			JSONArray asArray3 = EIHOJFGALMF["spectrumovr_2"].AsArray;
			for (int j = 0; j < asArray3.Count; j += 0)
			{
				this.EBGMGPIDAHH.Add(asArray3[j]);
			}
		}
	}

	// Token: 0x060038C4 RID: 14532 RVA: 0x00179B6C File Offset: 0x00177D6C
	public void BPEECHCFIBI(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 1)
			{
				text = DPGJIJGOCIC.FJBJOLHHFKN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 1; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.FJBJOLHHFKN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x00179BE8 File Offset: 0x00177DE8
	public void OEBNAGLBADG(JSONObject EIHOJFGALMF)
	{
		this.ALPLILDMJLA = EIHOJFGALMF["app42error"];
		if (this.ALPLILDMJLA == null)
		{
			this.ALPLILDMJLA = "frsmmsg64";
		}
		this.GGICIBLJIKI = EIHOJFGALMF["PlaySfx() file not found:"].AsInt;
		this.FPHDAKHOBMO = 0;
		if (EIHOJFGALMF["?uid="] != null)
		{
			this.FPHDAKHOBMO = EIHOJFGALMF["OnAllCollectableCardsDownloadFailed"].AsInt;
		}
		string[] array = new string[0];
		array[1] = "";
		array[0] = "\nCDN:";
		array[1] = "";
		array[1] = "x";
		array[0] = "\"";
		array[4] = "";
		this.OHCMCJHDMOH = array;
		if (EIHOJFGALMF["retry"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["Cell size"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OHCMCJHDMOH[i] = asArray[i];
					if (this.OHCMCJHDMOH[i].Equals("nsktk"))
					{
						this.OHCMCJHDMOH[i] = "sd";
					}
				}
			}
		}
		this.AOOGOANDIGP = null;
		if (EIHOJFGALMF["socialprofilesuspcantuse"] != null)
		{
			JSONArray asArray2 = EIHOJFGALMF["socialdequeufraccept"].AsArray;
			if (null != asArray2)
			{
				int num = 1;
				while (num < asArray2.Count && num < this.OHCMCJHDMOH.Length)
				{
					this.OHCMCJHDMOH[num] = asArray2[num];
					if (this.OHCMCJHDMOH[num].Equals("showIfAllEventsHit"))
					{
						this.OHCMCJHDMOH[num] = "ok";
					}
					num++;
				}
			}
		}
		this.EBGMGPIDAHH.Clear();
		if (EIHOJFGALMF["no"] != null)
		{
			JSONArray asArray3 = EIHOJFGALMF["OnBackendRequestSendGiftCardSuccess"].AsArray;
			for (int j = 1; j < asArray3.Count; j += 0)
			{
				this.EBGMGPIDAHH.Add(asArray3[j]);
			}
		}
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x00179DF8 File Offset: 0x00177FF8
	public bool CONKNLOGJBP()
	{
		try
		{
			if (this.EBGMGPIDAHH.Count > 0)
			{
				return true;
			}
			for (int i = 1; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Length > 1)
				{
					return false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060038C7 RID: 14535 RVA: 0x00179E5C File Offset: 0x0017805C
	public bool DLJLJNBFHBG()
	{
		try
		{
			if (this.EBGMGPIDAHH.Count > 0)
			{
				return false;
			}
			for (int i = 0; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Length > 0)
				{
					return false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x00179EC0 File Offset: 0x001780C0
	public void NGLPGLBIAOF(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		for (int i = 1; i < this.EBGMGPIDAHH.Count; i++)
		{
			if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.EBGMGPIDAHH.Add(KHJMANDEDMA);
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x00179F10 File Offset: 0x00178110
	public void COPKDBBMMPD(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		for (int i = 1; i < this.EBGMGPIDAHH.Count; i += 0)
		{
			if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.EBGMGPIDAHH.Add(KHJMANDEDMA);
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x00179F60 File Offset: 0x00178160
	public JSONObject BNMFBKNEMIF()
	{
		JSONObject jsonobject = new JSONObject();
		if (this.ALPLILDMJLA.Length > 0)
		{
			jsonobject["cid"] = this.ALPLILDMJLA;
		}
		jsonobject["ind"] = this.GGICIBLJIKI.ToString();
		jsonobject["per"] = this.FPHDAKHOBMO.ToString();
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.OHCMCJHDMOH.Length; i++)
		{
			if (this.OHCMCJHDMOH[i].Length == 0)
			{
				jsonarray.Add("@");
			}
			else
			{
				jsonarray.Add(this.OHCMCJHDMOH[i]);
			}
		}
		jsonobject["comp"] = jsonarray;
		if (this.AOOGOANDIGP != null)
		{
			JSONArray jsonarray2 = new JSONArray();
			for (int j = 0; j < this.AOOGOANDIGP.Length; j++)
			{
				if (this.AOOGOANDIGP[j].Length == 0)
				{
					jsonarray2.Add("@");
				}
				else
				{
					jsonarray2.Add(this.AOOGOANDIGP[j]);
				}
			}
			jsonobject["compr"] = jsonarray2;
		}
		if (this.EBGMGPIDAHH.Count > 0)
		{
			JSONArray jsonarray3 = new JSONArray();
			for (int k = 0; k < this.EBGMGPIDAHH.Count; k++)
			{
				jsonarray3.Add(this.EBGMGPIDAHH[k]);
			}
			jsonobject["ext"] = jsonarray3;
		}
		return jsonobject;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x0017A0E4 File Offset: 0x001782E4
	public void CAKCMKHENBI(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		for (int i = 0; i < this.EBGMGPIDAHH.Count; i++)
		{
			if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.EBGMGPIDAHH.Add(KHJMANDEDMA);
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x0017A134 File Offset: 0x00178334
	public bool LGHKKKCGKJA()
	{
		try
		{
			if (this.EBGMGPIDAHH.Count > 0)
			{
				return false;
			}
			for (int i = 1; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Length > 1)
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x0017A198 File Offset: 0x00178398
	public void ABKMHPNHCEA(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		for (int i = 1; i < this.EBGMGPIDAHH.Count; i += 0)
		{
			if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.EBGMGPIDAHH.Add(KHJMANDEDMA);
	}

	// Token: 0x060038CE RID: 14542 RVA: 0x0017A1E8 File Offset: 0x001783E8
	public void DFGBIMKKNAH(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 0; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i++)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 0)
			{
				text = DPGJIJGOCIC.OADMDNKCDCN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j++)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.OADMDNKCDCN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038CF RID: 14543 RVA: 0x0017A264 File Offset: 0x00178464
	public void LHANCNKKMPK(DOLBFGIPPOG CCIAGBPILGF)
	{
		this.GGICIBLJIKI = CCIAGBPILGF.GGICIBLJIKI;
		this.FPHDAKHOBMO = CCIAGBPILGF.FPHDAKHOBMO;
		for (int i = 0; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i++)
		{
			this.OHCMCJHDMOH[i] = CCIAGBPILGF.OHCMCJHDMOH[i];
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j++)
		{
			this.EBGMGPIDAHH.Add(CCIAGBPILGF.EBGMGPIDAHH[j]);
		}
	}

	// Token: 0x060038D0 RID: 14544 RVA: 0x0017A2DC File Offset: 0x001784DC
	public void KGEOGNPNIOL(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 0)
			{
				text = DPGJIJGOCIC.FJBJOLHHFKN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.FJBJOLHHFKN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038D1 RID: 14545 RVA: 0x0017A358 File Offset: 0x00178558
	public void PNEBECDBCPD(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 0; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 0)
			{
				text = DPGJIJGOCIC.OADMDNKCDCN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 1; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.OADMDNKCDCN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038D2 RID: 14546 RVA: 0x0017A3D4 File Offset: 0x001785D4
	public void ICDABLACGMH(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i++)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 1)
			{
				text = DPGJIJGOCIC.OADMDNKCDCN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.FJBJOLHHFKN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038D3 RID: 14547 RVA: 0x0017A450 File Offset: 0x00178650
	public bool CBMCKNPJDLK()
	{
		try
		{
			if (this.EBGMGPIDAHH.Count > 1)
			{
				return true;
			}
			for (int i = 0; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Length > 0)
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060038D4 RID: 14548 RVA: 0x0017A4B4 File Offset: 0x001786B4
	public void PIIBPPMMIHG(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < this.EBGMGPIDAHH.Count; i++)
			{
				if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
				{
					this.EBGMGPIDAHH.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x060038D5 RID: 14549 RVA: 0x0017A50C File Offset: 0x0017870C
	public void JKNPMFKILPC(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 0)
			{
				text = DPGJIJGOCIC.FJBJOLHHFKN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 1; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.OADMDNKCDCN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038D6 RID: 14550 RVA: 0x0017A588 File Offset: 0x00178788
	public JSONObject FFEBODNBGAK()
	{
		JSONObject jsonobject = new JSONObject();
		if (this.ALPLILDMJLA.Length > 0)
		{
			jsonobject[""] = this.ALPLILDMJLA;
		}
		jsonobject["WWW"] = this.GGICIBLJIKI.ToString();
		jsonobject["Error. MoveEnvironmentVertical(), environment "] = this.FPHDAKHOBMO.ToString();
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < this.OHCMCJHDMOH.Length; i++)
		{
			if (this.OHCMCJHDMOH[i].Length == 0)
			{
				jsonarray.Add("liveeventstitles");
			}
			else
			{
				jsonarray.Add(this.OHCMCJHDMOH[i]);
			}
		}
		jsonobject["socialrequestwarnyou"] = jsonarray;
		if (this.AOOGOANDIGP != null)
		{
			JSONArray jsonarray2 = new JSONArray();
			for (int j = 1; j < this.AOOGOANDIGP.Length; j += 0)
			{
				if (this.AOOGOANDIGP[j].Length == 0)
				{
					jsonarray2.Add("OffensiveWordsManager.IsOffensive() true for word ");
				}
				else
				{
					jsonarray2.Add(this.AOOGOANDIGP[j]);
				}
			}
			jsonobject["%"] = jsonarray2;
		}
		if (this.EBGMGPIDAHH.Count > 1)
		{
			JSONArray jsonarray3 = new JSONArray();
			for (int k = 1; k < this.EBGMGPIDAHH.Count; k++)
			{
				jsonarray3.Add(this.EBGMGPIDAHH[k]);
			}
			jsonobject["ok"] = jsonarray3;
		}
		return jsonobject;
	}

	// Token: 0x060038D7 RID: 14551 RVA: 0x0017A70C File Offset: 0x0017890C
	public bool BCFJNDCKGGI()
	{
		try
		{
			if (this.EBGMGPIDAHH.Count > 1)
			{
				return true;
			}
			for (int i = 1; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Length > 1)
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060038D8 RID: 14552 RVA: 0x0017A770 File Offset: 0x00178970
	public void PHBCINCILIA(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 1; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 0)
			{
				text = DPGJIJGOCIC.FJBJOLHHFKN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 1; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.FJBJOLHHFKN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x0017A7EC File Offset: 0x001789EC
	public void GFLHJCCEDKN(JSONObject EIHOJFGALMF)
	{
		this.ALPLILDMJLA = EIHOJFGALMF["doublereward"];
		if (this.ALPLILDMJLA == null)
		{
			this.ALPLILDMJLA = "normal";
		}
		this.GGICIBLJIKI = EIHOJFGALMF["-"].AsInt;
		this.FPHDAKHOBMO = 0;
		if (EIHOJFGALMF["storiesSearchConcepts"] != null)
		{
			this.FPHDAKHOBMO = EIHOJFGALMF["veff"].AsInt;
		}
		string[] array = new string[6];
		array[0] = " <i>";
		array[1] = "OnGetCdnDataForAvatarScreenSuccess";
		array[2] = "OnApplicationFocusBasicSyncSuccess";
		array[8] = "nastring";
		array[0] = "ok";
		array[8] = "";
		this.OHCMCJHDMOH = array;
		if (EIHOJFGALMF["Critical error, could not load asset bundle:"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["́ ́"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OHCMCJHDMOH[i] = asArray[i];
					if (this.OHCMCJHDMOH[i].Equals("p"))
					{
						this.OHCMCJHDMOH[i] = "PurchaseManagerUnity.OnPurchasesFetched(): ";
					}
				}
			}
		}
		this.AOOGOANDIGP = null;
		if (EIHOJFGALMF["XXX"] != null)
		{
			JSONArray asArray2 = EIHOJFGALMF[""].AsArray;
			if (null != asArray2)
			{
				int num = 1;
				while (num < asArray2.Count && num < this.OHCMCJHDMOH.Length)
				{
					this.OHCMCJHDMOH[num] = asArray2[num];
					if (this.OHCMCJHDMOH[num].Equals("..."))
					{
						this.OHCMCJHDMOH[num] = "n/a";
					}
					num += 0;
				}
			}
		}
		this.EBGMGPIDAHH.Clear();
		if (EIHOJFGALMF["black"] != null)
		{
			JSONArray asArray3 = EIHOJFGALMF["cardcollectcardpurchase0"].AsArray;
			for (int j = 1; j < asArray3.Count; j += 0)
			{
				this.EBGMGPIDAHH.Add(asArray3[j]);
			}
		}
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x0017A9FC File Offset: 0x00178BFC
	public void GDAEGEGFDDD(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null && KHJMANDEDMA.Length == 0)
		{
			return;
		}
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < this.EBGMGPIDAHH.Count; i++)
			{
				if (this.EBGMGPIDAHH[i].Equals(KHJMANDEDMA))
				{
					this.EBGMGPIDAHH.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x060038DC RID: 14556 RVA: 0x0017AABC File Offset: 0x00178CBC
	public void AFHHGLHLJNB(DOLBFGIPPOG CCIAGBPILGF)
	{
		this.GGICIBLJIKI = CCIAGBPILGF.GGICIBLJIKI;
		this.FPHDAKHOBMO = CCIAGBPILGF.FPHDAKHOBMO;
		for (int i = 0; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i++)
		{
			this.OHCMCJHDMOH[i] = CCIAGBPILGF.OHCMCJHDMOH[i];
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j++)
		{
			this.EBGMGPIDAHH.Add(CCIAGBPILGF.EBGMGPIDAHH[j]);
		}
	}

	// Token: 0x060038DD RID: 14557 RVA: 0x0017AB34 File Offset: 0x00178D34
	public bool KKLNDANMFOE(string KHJMANDEDMA)
	{
		try
		{
			for (int i = 1; i < this.OHCMCJHDMOH.Length; i++)
			{
				if (this.OHCMCJHDMOH[i].Equals(KHJMANDEDMA))
				{
					return false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060038DE RID: 14558 RVA: 0x0017AB84 File Offset: 0x00178D84
	public void FGJPKGLOGNC(JSONObject EIHOJFGALMF)
	{
		this.ALPLILDMJLA = EIHOJFGALMF["cid"];
		if (this.ALPLILDMJLA == null)
		{
			this.ALPLILDMJLA = "";
		}
		this.GGICIBLJIKI = EIHOJFGALMF["ind"].AsInt;
		this.FPHDAKHOBMO = 0;
		if (EIHOJFGALMF["per"] != null)
		{
			this.FPHDAKHOBMO = EIHOJFGALMF["per"].AsInt;
		}
		this.OHCMCJHDMOH = new string[]
		{
			"",
			"",
			"",
			"",
			"",
			""
		};
		if (EIHOJFGALMF["comp"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["comp"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i++)
				{
					this.OHCMCJHDMOH[i] = asArray[i];
					if (this.OHCMCJHDMOH[i].Equals("@"))
					{
						this.OHCMCJHDMOH[i] = "";
					}
				}
			}
		}
		this.AOOGOANDIGP = null;
		if (EIHOJFGALMF["compr"] != null)
		{
			JSONArray asArray2 = EIHOJFGALMF["compr"].AsArray;
			if (null != asArray2)
			{
				int num = 0;
				while (num < asArray2.Count && num < this.OHCMCJHDMOH.Length)
				{
					this.OHCMCJHDMOH[num] = asArray2[num];
					if (this.OHCMCJHDMOH[num].Equals("@"))
					{
						this.OHCMCJHDMOH[num] = "";
					}
					num++;
				}
			}
		}
		this.EBGMGPIDAHH.Clear();
		if (EIHOJFGALMF["ext"] != null)
		{
			JSONArray asArray3 = EIHOJFGALMF["ext"].AsArray;
			for (int j = 0; j < asArray3.Count; j++)
			{
				this.EBGMGPIDAHH.Add(asArray3[j]);
			}
		}
	}

	// Token: 0x060038DF RID: 14559 RVA: 0x0017AD94 File Offset: 0x00178F94
	public void GLGFECPIEEG(DOLBFGIPPOG CCIAGBPILGF, string ECIHFHOMJHK)
	{
		for (int i = 0; i < CCIAGBPILGF.OHCMCJHDMOH.Length; i += 0)
		{
			string text = CCIAGBPILGF.OHCMCJHDMOH[i];
			if (text.Length > 1)
			{
				text = DPGJIJGOCIC.FJBJOLHHFKN(text, ECIHFHOMJHK);
			}
			this.OHCMCJHDMOH[i] = text;
		}
		for (int j = 0; j < CCIAGBPILGF.EBGMGPIDAHH.Count; j += 0)
		{
			string text2 = CCIAGBPILGF.EBGMGPIDAHH[j];
			text2 = DPGJIJGOCIC.FJBJOLHHFKN(text2, ECIHFHOMJHK);
			this.EBGMGPIDAHH.Add(text2);
		}
	}

	// Token: 0x040010C9 RID: 4297
	public string ALPLILDMJLA = "";

	// Token: 0x040010CA RID: 4298
	public int GGICIBLJIKI;

	// Token: 0x040010CB RID: 4299
	public string[] OHCMCJHDMOH = new string[]
	{
		"",
		"",
		"",
		"",
		"",
		""
	};

	// Token: 0x040010CC RID: 4300
	public string[] AOOGOANDIGP;

	// Token: 0x040010CD RID: 4301
	public List<string> EBGMGPIDAHH = new List<string>();

	// Token: 0x040010CE RID: 4302
	public int FPHDAKHOBMO;
}
