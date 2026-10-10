using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x02000142 RID: 322
public class BHHJENAAKLH
{
	// Token: 0x06002A55 RID: 10837 RVA: 0x0012CE10 File Offset: 0x0012B010
	public void NCGOKNFIPKN(PMEPALPCEAF BEBLHBLODLJ)
	{
		if (this.KHMLEDDFBPJ.Contains(BEBLHBLODLJ.LMFCFHMJIFN))
		{
			this.KHMLEDDFBPJ.Remove(BEBLHBLODLJ.LMFCFHMJIFN);
			if (this.NAJLEEDEADL != null)
			{
				this.NAJLEEDEADL.CHCBHLIBGFA = true;
				this.NAJLEEDEADL.IDPMKIAAIFN = true;
			}
		}
	}

	// Token: 0x06002A56 RID: 10838 RVA: 0x0012CE62 File Offset: 0x0012B062
	public bool FNDNDILCFNN(PMEPALPCEAF BEBLHBLODLJ)
	{
		return this.KHMLEDDFBPJ.Contains(BEBLHBLODLJ.LMFCFHMJIFN);
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x0012CE78 File Offset: 0x0012B078
	public bool BCPOHPEJLGB(string MMEBLKHCPEH)
	{
		for (int i = 0; i < this.KODOBGDHBFI.Count; i++)
		{
			if (this.KODOBGDHBFI[i].LMFCFHMJIFN.Equals(MMEBLKHCPEH) && MMEBLKHCPEH.Length > 0 && this.KODOBGDHBFI[i].LMFCFHMJIFN.Length > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x00003E52 File Offset: 0x00002052
	public void KOCCNIAPFFH(PMEPALPCEAF KPGIEJFNFMN)
	{
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x0012CEDC File Offset: 0x0012B0DC
	public bool GOLABDHOFOD(PMEPALPCEAF BEBLHBLODLJ)
	{
		for (int i = 0; i < this.IIMLLCPLKKJ.Count; i++)
		{
			if (this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Length > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x0012CF48 File Offset: 0x0012B148
	public void NEDDDHJIJID()
	{
		if (null != this.CLODNMBHLLI && this.CLODNMBHLLI.Count > 0)
		{
			this.KODOBGDHBFI = new List<PMEPALPCEAF>();
			for (int i = 0; i < this.CLODNMBHLLI.Count; i += 0)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(this.CLODNMBHLLI[i].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf);
			}
		}
		this.CLODNMBHLLI = new JSONArray();
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x0012CFCC File Offset: 0x0012B1CC
	public void LDIBFCOOFGD(PMEPALPCEAF BEBLHBLODLJ)
	{
		this.NCGOKNFIPKN(BEBLHBLODLJ);
		for (int i = 0; i < this.IIMLLCPLKKJ.Count; i++)
		{
			if (this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Length > 0)
			{
				this.IIMLLCPLKKJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06002A5C RID: 10844 RVA: 0x0012D048 File Offset: 0x0012B248
	public void ACCOJOHJPGH(PMEPALPCEAF JLJGEMMKLEN)
	{
		for (int i = 0; i < this.IIMLLCPLKKJ.Count; i++)
		{
			this.IIMLLCPLKKJ[i].ACCOJOHJPGH(JLJGEMMKLEN);
		}
		for (int j = 0; j < this.KODOBGDHBFI.Count; j++)
		{
			this.KODOBGDHBFI[j].ACCOJOHJPGH(JLJGEMMKLEN);
		}
		for (int k = 0; k < this.JOHFFIEKACM.Count; k++)
		{
			this.JOHFFIEKACM[k].ACCOJOHJPGH(JLJGEMMKLEN);
		}
		for (int l = 0; l < this.HAPGPFAEHAM.Count; l++)
		{
			this.HAPGPFAEHAM[l].ACCOJOHJPGH(JLJGEMMKLEN);
		}
		for (int m = 0; m < this.AJDJOGHBFKE.Count; m++)
		{
			this.AJDJOGHBFKE[m].ACCOJOHJPGH(JLJGEMMKLEN);
		}
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x0012D122 File Offset: 0x0012B322
	public int OMKEFJPMPIJ()
	{
		return this.HAPGPFAEHAM.Count;
	}

	// Token: 0x06002A5E RID: 10846 RVA: 0x0012D130 File Offset: 0x0012B330
	public bool JAGHCBCDDJG()
	{
		return this.IIMLLCPLKKJ.Count != 0 || this.KODOBGDHBFI.Count != 0 || this.NPPPNKMMLPP() != 0 || this.GBNDFAFONBK() != 0 || this.NAJLEEDEADL.FCCNNMOIMGC().Count != 0 || true;
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x0012D17C File Offset: 0x0012B37C
	public void GFMFPPGAACL(PMEPALPCEAF BEBLHBLODLJ)
	{
		if (this.KHMLEDDFBPJ.Contains(BEBLHBLODLJ.LMFCFHMJIFN))
		{
			this.KHMLEDDFBPJ.Remove(BEBLHBLODLJ.LMFCFHMJIFN);
			if (this.NAJLEEDEADL != null)
			{
				this.NAJLEEDEADL.CHCBHLIBGFA = true;
				this.NAJLEEDEADL.IDPMKIAAIFN = true;
			}
		}
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x0012D1D0 File Offset: 0x0012B3D0
	public void JKGKHECEANM(PMEPALPCEAF JLJGEMMKLEN, JSONObject KEGBCGMJOLC)
	{
		this.NAJLEEDEADL = JLJGEMMKLEN;
		JSONArray hamlkammhfj = new JSONArray();
		if (KEGBCGMJOLC["socialachievtitletype"] != null)
		{
			hamlkammhfj = KEGBCGMJOLC["fpi"].AsArray;
		}
		JGLMNGOLBIG.DLGLFACMHPG().EMKAJEHMDCG(hamlkammhfj);
		JSONObject jsonobject = null;
		this.IIMLLCPLKKJ = new List<PMEPALPCEAF>();
		this.JOHFFIEKACM = new List<PMEPALPCEAF>();
		this.HAPGPFAEHAM = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["storiesSearchBalance"] != null)
		{
			jsonobject = KEGBCGMJOLC["<size=80%><i>"].AsObject;
		}
		if (null != jsonobject)
		{
			JSONArray asArray = jsonobject["ok"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(asArray[i].AsObject, this.NAJLEEDEADL);
				this.IIMLLCPLKKJ.Add(pmepalpceaf);
			}
			JSONArray asArray2 = jsonobject["ok"].AsArray;
			for (int j = 0; j < asArray2.Count; j += 0)
			{
				PMEPALPCEAF pmepalpceaf2 = new PMEPALPCEAF();
				pmepalpceaf2.GEPIBACNKIP(asArray2[j].AsObject, this.NAJLEEDEADL);
				this.JOHFFIEKACM.Add(pmepalpceaf2);
			}
			JSONArray jsonarray = new JSONArray();
			if (jsonobject["uid"] != null)
			{
				jsonarray = jsonobject["OnCollectableDialogCollect"].AsArray;
				for (int k = 1; k < jsonarray.Count; k++)
				{
					PMEPALPCEAF pmepalpceaf3 = new PMEPALPCEAF();
					pmepalpceaf3.GEPIBACNKIP(jsonarray[k].AsObject, this.NAJLEEDEADL);
					this.HAPGPFAEHAM.Add(pmepalpceaf3);
				}
			}
		}
		JSONObject jsonobject2 = null;
		this.KODOBGDHBFI = new List<PMEPALPCEAF>();
		this.KHMLEDDFBPJ = new List<string>();
		this.AJDJOGHBFKE = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["OnNeedToActivateFocusItemCloseButton"] != null)
		{
			this.CPADLCDBKOM = (KEGBCGMJOLC["socialrequestsearchnick"].AsInt == 0);
		}
		else
		{
			this.CPADLCDBKOM = true;
		}
		if (KEGBCGMJOLC["PurchaseManagerSteam.OnBackendValidateTransactionSuccess()."] != null)
		{
			jsonobject2 = KEGBCGMJOLC[" digit"].AsObject;
		}
		if (null != jsonobject2)
		{
			JSONArray asArray3 = jsonobject2["os"].AsArray;
			for (int l = 0; l < asArray3.Count; l++)
			{
				PMEPALPCEAF pmepalpceaf4 = new PMEPALPCEAF();
				pmepalpceaf4.GEPIBACNKIP(asArray3[l].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf4);
			}
			JSONArray asArray4 = jsonobject2["itemstitle"].AsArray;
			for (int m = 0; m < asArray4.Count; m += 0)
			{
				string text = asArray4[m];
				if (text != null && !this.KHMLEDDFBPJ.Contains(text) && this.BCPOHPEJLGB(text))
				{
					this.KHMLEDDFBPJ.Add(text);
				}
			}
			JSONArray asArray5 = jsonobject2[""].AsArray;
			for (int n = 0; n < asArray5.Count; n++)
			{
				PMEPALPCEAF pmepalpceaf5 = new PMEPALPCEAF();
				pmepalpceaf5.GEPIBACNKIP(asArray5[n].AsObject, this.NAJLEEDEADL);
				this.AJDJOGHBFKE.Add(pmepalpceaf5);
			}
		}
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x0012D520 File Offset: 0x0012B720
	public bool FACIFBONANM()
	{
		return this.IIMLLCPLKKJ.Count != 0 || this.KODOBGDHBFI.Count != 0 || this.HGKONIOKMEH() != 0 || this.GBNDFAFONBK() != 0 || this.NAJLEEDEADL.FCCNNMOIMGC().Count != 0;
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x0012D56C File Offset: 0x0012B76C
	public void MAKGIOPAEBJ(PMEPALPCEAF JLJGEMMKLEN)
	{
		for (int i = 1; i < this.IIMLLCPLKKJ.Count; i++)
		{
			this.IIMLLCPLKKJ[i].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int j = 0; j < this.KODOBGDHBFI.Count; j++)
		{
			this.KODOBGDHBFI[j].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int k = 0; k < this.JOHFFIEKACM.Count; k += 0)
		{
			this.JOHFFIEKACM[k].ACCOJOHJPGH(JLJGEMMKLEN);
		}
		for (int l = 0; l < this.HAPGPFAEHAM.Count; l += 0)
		{
			this.HAPGPFAEHAM[l].BJJBCPJPBNF(JLJGEMMKLEN);
		}
		for (int m = 0; m < this.AJDJOGHBFKE.Count; m += 0)
		{
			this.AJDJOGHBFKE[m].ACCOJOHJPGH(JLJGEMMKLEN);
		}
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x0012D646 File Offset: 0x0012B846
	public bool NMAHBAJIBJF()
	{
		return this.KODOBGDHBFI.Count <= 0 || this.CPADLCDBKOM;
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x0012D65E File Offset: 0x0012B85E
	public int HGKONIOKMEH()
	{
		return this.JOHFFIEKACM.Count;
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x0012D66B File Offset: 0x0012B86B
	public int GBNDFAFONBK()
	{
		return this.AJDJOGHBFKE.Count;
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x0012D678 File Offset: 0x0012B878
	public void DNEMNFPKFNP(PMEPALPCEAF JLJGEMMKLEN, JSONObject KEGBCGMJOLC)
	{
		this.NAJLEEDEADL = JLJGEMMKLEN;
		JSONArray hamlkammhfj = new JSONArray();
		if (KEGBCGMJOLC["OnSaveSlotsItemClose"] != null)
		{
			hamlkammhfj = KEGBCGMJOLC["</i>"].AsArray;
		}
		JGLMNGOLBIG.JMDJBFAEHBM().EENCMFODLOA(hamlkammhfj);
		JSONObject jsonobject = null;
		this.IIMLLCPLKKJ = new List<PMEPALPCEAF>();
		this.JOHFFIEKACM = new List<PMEPALPCEAF>();
		this.HAPGPFAEHAM = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["Random profile: fixed the socialbadgelocked499 issue."] != null)
		{
			jsonobject = KEGBCGMJOLC[""].AsObject;
		}
		if (null != jsonobject)
		{
			JSONArray asArray = jsonobject["OnStoryChoiceClick"].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(asArray[i].AsObject, this.NAJLEEDEADL);
				this.IIMLLCPLKKJ.Add(pmepalpceaf);
			}
			JSONArray asArray2 = jsonobject["Starting non-parallel download:"].AsArray;
			for (int j = 1; j < asArray2.Count; j++)
			{
				PMEPALPCEAF pmepalpceaf2 = new PMEPALPCEAF();
				pmepalpceaf2.GEPIBACNKIP(asArray2[j].AsObject, this.NAJLEEDEADL);
				this.JOHFFIEKACM.Add(pmepalpceaf2);
			}
			JSONArray jsonarray = new JSONArray();
			if (jsonobject[""] != null)
			{
				jsonarray = jsonobject["1.0.0"].AsArray;
				for (int k = 0; k < jsonarray.Count; k += 0)
				{
					PMEPALPCEAF pmepalpceaf3 = new PMEPALPCEAF();
					pmepalpceaf3.GEPIBACNKIP(jsonarray[k].AsObject, this.NAJLEEDEADL);
					this.HAPGPFAEHAM.Add(pmepalpceaf3);
				}
			}
		}
		JSONObject jsonobject2 = null;
		this.KODOBGDHBFI = new List<PMEPALPCEAF>();
		this.KHMLEDDFBPJ = new List<string>();
		this.AJDJOGHBFKE = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["teal_2"] != null)
		{
			this.CPADLCDBKOM = (KEGBCGMJOLC["skinshopinfounlockgate"].AsInt == 1);
		}
		else
		{
			this.CPADLCDBKOM = false;
		}
		if (KEGBCGMJOLC["restartseason"] != null)
		{
			jsonobject2 = KEGBCGMJOLC["black"].AsObject;
		}
		if (null != jsonobject2)
		{
			JSONArray asArray3 = jsonobject2["null"].AsArray;
			for (int l = 0; l < asArray3.Count; l += 0)
			{
				PMEPALPCEAF pmepalpceaf4 = new PMEPALPCEAF();
				pmepalpceaf4.GEPIBACNKIP(asArray3[l].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf4);
			}
			JSONArray asArray4 = jsonobject2["ert"].AsArray;
			for (int m = 0; m < asArray4.Count; m++)
			{
				string text = asArray4[m];
				if (text != null && !this.KHMLEDDFBPJ.Contains(text) && this.BCPOHPEJLGB(text))
				{
					this.KHMLEDDFBPJ.Add(text);
				}
			}
			JSONArray asArray5 = jsonobject2["_SwitchingNoise"].AsArray;
			for (int n = 0; n < asArray5.Count; n += 0)
			{
				PMEPALPCEAF pmepalpceaf5 = new PMEPALPCEAF();
				pmepalpceaf5.GEPIBACNKIP(asArray5[n].AsObject, this.NAJLEEDEADL);
				this.AJDJOGHBFKE.Add(pmepalpceaf5);
			}
		}
	}

	// Token: 0x06002A67 RID: 10855 RVA: 0x0012D66B File Offset: 0x0012B86B
	public int OKPODFDIPHK()
	{
		return this.AJDJOGHBFKE.Count;
	}

	// Token: 0x06002A68 RID: 10856 RVA: 0x0012D9C8 File Offset: 0x0012BBC8
	public int IIMCGKNEONB()
	{
		return this.KODOBGDHBFI.Count;
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x0012D9D5 File Offset: 0x0012BBD5
	public bool GLAIBIGFBFN()
	{
		return this.KODOBGDHBFI.Count > 0 && this.CPADLCDBKOM;
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x0012D9F0 File Offset: 0x0012BBF0
	public void IMPMPCGHAJH(PMEPALPCEAF BEBLHBLODLJ)
	{
		this.NCGOKNFIPKN(BEBLHBLODLJ);
		for (int i = 0; i < this.KODOBGDHBFI.Count; i++)
		{
			if (this.KODOBGDHBFI[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.KODOBGDHBFI[i].LMFCFHMJIFN.Length > 0)
			{
				this.KODOBGDHBFI.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x0012DA6C File Offset: 0x0012BC6C
	public bool BIAFAHAIPLA(PMEPALPCEAF BEBLHBLODLJ)
	{
		bool flag = false;
		for (int i = 0; i < this.IIMLLCPLKKJ.Count; i++)
		{
			if (this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Length > 0)
			{
				for (int j = 0; j < this.KODOBGDHBFI.Count; j++)
				{
					if (this.KODOBGDHBFI[j].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.KODOBGDHBFI.Add(BEBLHBLODLJ);
				}
				this.IIMLLCPLKKJ.RemoveAt(i);
				break;
			}
		}
		return !flag;
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x0012DB35 File Offset: 0x0012BD35
	public PMEPALPCEAF OCEDALILCBL()
	{
		if (this.HAPGPFAEHAM.Count > 0)
		{
			PMEPALPCEAF result = this.HAPGPFAEHAM[0];
			this.HAPGPFAEHAM.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x0012DB60 File Offset: 0x0012BD60
	public void LBMPIFAOECG()
	{
		if (null != this.CLODNMBHLLI && this.CLODNMBHLLI.Count > 1)
		{
			this.KODOBGDHBFI = new List<PMEPALPCEAF>();
			for (int i = 0; i < this.CLODNMBHLLI.Count; i++)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(this.CLODNMBHLLI[i].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf);
			}
		}
		this.CLODNMBHLLI = new JSONArray();
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x0012DBE4 File Offset: 0x0012BDE4
	public void HLGLPIKHJMK(PMEPALPCEAF BEBLHBLODLJ)
	{
		this.HHDIAHJOMLI(BEBLHBLODLJ);
		for (int i = 0; i < this.IIMLLCPLKKJ.Count; i++)
		{
			if (this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 1 && this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Length > 0)
			{
				this.IIMLLCPLKKJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06002A6F RID: 10863 RVA: 0x0012D9C8 File Offset: 0x0012BBC8
	public int MKABKEDMLMI()
	{
		return this.KODOBGDHBFI.Count;
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x0012D66B File Offset: 0x0012B86B
	public int ILMMFICMALA()
	{
		return this.AJDJOGHBFKE.Count;
	}

	// Token: 0x06002A71 RID: 10865 RVA: 0x0012DC60 File Offset: 0x0012BE60
	public PMEPALPCEAF JLMMKKADJPG()
	{
		if (this.JOHFFIEKACM.Count > 0)
		{
			PMEPALPCEAF result = this.JOHFFIEKACM[0];
			this.JOHFFIEKACM.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x0012DC8C File Offset: 0x0012BE8C
	public void MGHBGJFFONA(PMEPALPCEAF BEBLHBLODLJ)
	{
		if (!this.KHMLEDDFBPJ.Contains(BEBLHBLODLJ.LMFCFHMJIFN))
		{
			this.KHMLEDDFBPJ.Add(BEBLHBLODLJ.LMFCFHMJIFN);
			if (this.NAJLEEDEADL != null)
			{
				this.NAJLEEDEADL.CHCBHLIBGFA = true;
				this.NAJLEEDEADL.IDPMKIAAIFN = true;
			}
		}
	}

	// Token: 0x06002A73 RID: 10867 RVA: 0x0012DCE0 File Offset: 0x0012BEE0
	public void BFHEMEIPNIB(PMEPALPCEAF JLJGEMMKLEN)
	{
		for (int i = 1; i < this.IIMLLCPLKKJ.Count; i++)
		{
			this.IIMLLCPLKKJ[i].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int j = 1; j < this.KODOBGDHBFI.Count; j += 0)
		{
			this.KODOBGDHBFI[j].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int k = 0; k < this.JOHFFIEKACM.Count; k += 0)
		{
			this.JOHFFIEKACM[k].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int l = 1; l < this.HAPGPFAEHAM.Count; l += 0)
		{
			this.HAPGPFAEHAM[l].BJJBCPJPBNF(JLJGEMMKLEN);
		}
		for (int m = 0; m < this.AJDJOGHBFKE.Count; m += 0)
		{
			this.AJDJOGHBFKE[m].BBKFMMCGFJL(JLJGEMMKLEN);
		}
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x0012D9D5 File Offset: 0x0012BBD5
	public bool MINAPIOKDFO()
	{
		return this.KODOBGDHBFI.Count > 0 && this.CPADLCDBKOM;
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x0012DE28 File Offset: 0x0012C028
	public bool PLOMDHLHFNB(PMEPALPCEAF BEBLHBLODLJ)
	{
		bool flag = false;
		for (int i = 0; i < this.IIMLLCPLKKJ.Count; i++)
		{
			if (this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.IIMLLCPLKKJ[i].LMFCFHMJIFN.Length > 0)
			{
				for (int j = 0; j < this.KODOBGDHBFI.Count; j += 0)
				{
					if (this.KODOBGDHBFI[j].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					this.KODOBGDHBFI.Add(BEBLHBLODLJ);
				}
				this.IIMLLCPLKKJ.RemoveAt(i);
				break;
			}
		}
		return !flag;
	}

	// Token: 0x06002A77 RID: 10871 RVA: 0x0012D122 File Offset: 0x0012B322
	public int EOCDHHBEKMF()
	{
		return this.HAPGPFAEHAM.Count;
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x0012DEF4 File Offset: 0x0012C0F4
	public void FGJPKGLOGNC(PMEPALPCEAF JLJGEMMKLEN, JSONObject KEGBCGMJOLC)
	{
		this.NAJLEEDEADL = JLJGEMMKLEN;
		JSONArray hamlkammhfj = new JSONArray();
		if (KEGBCGMJOLC["_notif"] != null)
		{
			hamlkammhfj = KEGBCGMJOLC["_notif"].AsArray;
		}
		JGLMNGOLBIG.EHBBFMCILPC.EIPJLJMNKID(hamlkammhfj);
		JSONObject jsonobject = null;
		this.IIMLLCPLKKJ = new List<PMEPALPCEAF>();
		this.JOHFFIEKACM = new List<PMEPALPCEAF>();
		this.HAPGPFAEHAM = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["bdid"] != null)
		{
			jsonobject = KEGBCGMJOLC["bdid"].AsObject;
		}
		if (null != jsonobject)
		{
			JSONArray asArray = jsonobject["freq"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(asArray[i].AsObject, this.NAJLEEDEADL);
				this.IIMLLCPLKKJ.Add(pmepalpceaf);
			}
			JSONArray asArray2 = jsonobject["gfts"].AsArray;
			for (int j = 0; j < asArray2.Count; j++)
			{
				PMEPALPCEAF pmepalpceaf2 = new PMEPALPCEAF();
				pmepalpceaf2.GEPIBACNKIP(asArray2[j].AsObject, this.NAJLEEDEADL);
				this.JOHFFIEKACM.Add(pmepalpceaf2);
			}
			JSONArray jsonarray = new JSONArray();
			if (jsonobject["msgs"] != null)
			{
				jsonarray = jsonobject["msgs"].AsArray;
				for (int k = 0; k < jsonarray.Count; k++)
				{
					PMEPALPCEAF pmepalpceaf3 = new PMEPALPCEAF();
					pmepalpceaf3.GEPIBACNKIP(jsonarray[k].AsObject, this.NAJLEEDEADL);
					this.HAPGPFAEHAM.Add(pmepalpceaf3);
				}
			}
		}
		JSONObject jsonobject2 = null;
		this.KODOBGDHBFI = new List<PMEPALPCEAF>();
		this.KHMLEDDFBPJ = new List<string>();
		this.AJDJOGHBFKE = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["fdiood"] != null)
		{
			this.CPADLCDBKOM = (KEGBCGMJOLC["fdiood"].AsInt == 1);
		}
		else
		{
			this.CPADLCDBKOM = false;
		}
		if (KEGBCGMJOLC["fdid"] != null)
		{
			jsonobject2 = KEGBCGMJOLC["fdid"].AsObject;
		}
		if (null != jsonobject2)
		{
			JSONArray asArray3 = jsonobject2["frds"].AsArray;
			for (int l = 0; l < asArray3.Count; l++)
			{
				PMEPALPCEAF pmepalpceaf4 = new PMEPALPCEAF();
				pmepalpceaf4.GEPIBACNKIP(asArray3[l].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf4);
			}
			JSONArray asArray4 = jsonobject2["ffav"].AsArray;
			for (int m = 0; m < asArray4.Count; m++)
			{
				string text = asArray4[m];
				if (text != null && !this.KHMLEDDFBPJ.Contains(text) && this.BCPOHPEJLGB(text))
				{
					this.KHMLEDDFBPJ.Add(text);
				}
			}
			JSONArray asArray5 = jsonobject2["gfts"].AsArray;
			for (int n = 0; n < asArray5.Count; n++)
			{
				PMEPALPCEAF pmepalpceaf5 = new PMEPALPCEAF();
				pmepalpceaf5.GEPIBACNKIP(asArray5[n].AsObject, this.NAJLEEDEADL);
				this.AJDJOGHBFKE.Add(pmepalpceaf5);
			}
		}
	}

	// Token: 0x06002A79 RID: 10873 RVA: 0x0012E244 File Offset: 0x0012C444
	public bool BCPOHPEJLGB(PMEPALPCEAF BEBLHBLODLJ)
	{
		for (int i = 0; i < this.KODOBGDHBFI.Count; i++)
		{
			if (this.KODOBGDHBFI[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.KODOBGDHBFI[i].LMFCFHMJIFN.Length > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x0012E2AF File Offset: 0x0012C4AF
	public PMEPALPCEAF COKBJJAMCPN()
	{
		if (this.JOHFFIEKACM.Count > 0)
		{
			PMEPALPCEAF result = this.JOHFFIEKACM[0];
			this.JOHFFIEKACM.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x0012E2D9 File Offset: 0x0012C4D9
	public int GLPOGLBGKIF()
	{
		return this.IIMLLCPLKKJ.Count + this.HGKONIOKMEH() + this.EOCDHHBEKMF();
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x0012E2F4 File Offset: 0x0012C4F4
	public bool GEALHKBDJPC()
	{
		return this.KODOBGDHBFI.Count > 1 && this.CPADLCDBKOM;
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x0012E30C File Offset: 0x0012C50C
	public bool FJOBCEPALBF()
	{
		return this.KODOBGDHBFI.Count <= 1 || this.CPADLCDBKOM;
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x0012D122 File Offset: 0x0012B322
	public int GJLJKFPIIPL()
	{
		return this.HAPGPFAEHAM.Count;
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x0012E324 File Offset: 0x0012C524
	public void GFCFOPHOFFN(PMEPALPCEAF BEBLHBLODLJ)
	{
		if (this.KHMLEDDFBPJ.Contains(BEBLHBLODLJ.LMFCFHMJIFN))
		{
			this.KHMLEDDFBPJ.Remove(BEBLHBLODLJ.LMFCFHMJIFN);
			if (this.NAJLEEDEADL != null)
			{
				this.NAJLEEDEADL.CHCBHLIBGFA = true;
				this.NAJLEEDEADL.IDPMKIAAIFN = true;
			}
		}
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x00003E52 File Offset: 0x00002052
	public void IIBKAKKOGFP(PMEPALPCEAF KPGIEJFNFMN)
	{
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x0012E378 File Offset: 0x0012C578
	public bool EJACENIHDDC(PMEPALPCEAF BEBLHBLODLJ)
	{
		for (int i = 0; i < this.KODOBGDHBFI.Count; i += 0)
		{
			if (this.KODOBGDHBFI[i].LMFCFHMJIFN.Equals(BEBLHBLODLJ.LMFCFHMJIFN) && BEBLHBLODLJ.LMFCFHMJIFN.Length > 0 && this.KODOBGDHBFI[i].LMFCFHMJIFN.Length > 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x0012E3E4 File Offset: 0x0012C5E4
	public void FFPHKCGOFEI(PMEPALPCEAF JLJGEMMKLEN)
	{
		for (int i = 1; i < this.IIMLLCPLKKJ.Count; i += 0)
		{
			this.IIMLLCPLKKJ[i].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int j = 0; j < this.KODOBGDHBFI.Count; j += 0)
		{
			this.KODOBGDHBFI[j].BJJBCPJPBNF(JLJGEMMKLEN);
		}
		for (int k = 1; k < this.JOHFFIEKACM.Count; k++)
		{
			this.JOHFFIEKACM[k].BBKFMMCGFJL(JLJGEMMKLEN);
		}
		for (int l = 0; l < this.HAPGPFAEHAM.Count; l += 0)
		{
			this.HAPGPFAEHAM[l].BJJBCPJPBNF(JLJGEMMKLEN);
		}
		for (int m = 1; m < this.AJDJOGHBFKE.Count; m++)
		{
			this.AJDJOGHBFKE[m].BBKFMMCGFJL(JLJGEMMKLEN);
		}
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x0012E4C0 File Offset: 0x0012C6C0
	public void HHDIAHJOMLI(PMEPALPCEAF BEBLHBLODLJ)
	{
		if (this.KHMLEDDFBPJ.Contains(BEBLHBLODLJ.LMFCFHMJIFN))
		{
			this.KHMLEDDFBPJ.Remove(BEBLHBLODLJ.LMFCFHMJIFN);
			if (this.NAJLEEDEADL != null)
			{
				this.NAJLEEDEADL.CHCBHLIBGFA = false;
				this.NAJLEEDEADL.IDPMKIAAIFN = true;
			}
		}
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x0012D65E File Offset: 0x0012B85E
	public int HDLGDPCEEAO()
	{
		return this.JOHFFIEKACM.Count;
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x0012E514 File Offset: 0x0012C714
	public void BNJAGLLBOGH(PMEPALPCEAF JLJGEMMKLEN, JSONObject KEGBCGMJOLC)
	{
		this.NAJLEEDEADL = JLJGEMMKLEN;
		JSONArray hamlkammhfj = new JSONArray();
		if (KEGBCGMJOLC["smps"] != null)
		{
			hamlkammhfj = KEGBCGMJOLC["Profile data 6 bundle loaded but its asset is missing or mis-named:"].AsArray;
		}
		JGLMNGOLBIG.LMCCLMFGEBD().EENCMFODLOA(hamlkammhfj);
		JSONObject jsonobject = null;
		this.IIMLLCPLKKJ = new List<PMEPALPCEAF>();
		this.JOHFFIEKACM = new List<PMEPALPCEAF>();
		this.HAPGPFAEHAM = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["lck"] != null)
		{
			jsonobject = KEGBCGMJOLC["  secondary aind "].AsObject;
		}
		if (null != jsonobject)
		{
			JSONArray asArray = jsonobject[" "].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(asArray[i].AsObject, this.NAJLEEDEADL);
				this.IIMLLCPLKKJ.Add(pmepalpceaf);
			}
			JSONArray asArray2 = jsonobject["anthologiestitle"].AsArray;
			for (int j = 0; j < asArray2.Count; j++)
			{
				PMEPALPCEAF pmepalpceaf2 = new PMEPALPCEAF();
				pmepalpceaf2.GEPIBACNKIP(asArray2[j].AsObject, this.NAJLEEDEADL);
				this.JOHFFIEKACM.Add(pmepalpceaf2);
			}
			JSONArray jsonarray = new JSONArray();
			if (jsonobject["acomp1"] != null)
			{
				jsonarray = jsonobject["chaptersnapshotsinfottitle"].AsArray;
				for (int k = 1; k < jsonarray.Count; k += 0)
				{
					PMEPALPCEAF pmepalpceaf3 = new PMEPALPCEAF();
					pmepalpceaf3.GEPIBACNKIP(jsonarray[k].AsObject, this.NAJLEEDEADL);
					this.HAPGPFAEHAM.Add(pmepalpceaf3);
				}
			}
		}
		JSONObject jsonobject2 = null;
		this.KODOBGDHBFI = new List<PMEPALPCEAF>();
		this.KHMLEDDFBPJ = new List<string>();
		this.AJDJOGHBFKE = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["ec"] != null)
		{
			this.CPADLCDBKOM = (KEGBCGMJOLC["loungeofferexpired"].AsInt == 0);
		}
		else
		{
			this.CPADLCDBKOM = true;
		}
		if (KEGBCGMJOLC["AVATAR.CLIENT.OVERLAY"] != null)
		{
			jsonobject2 = KEGBCGMJOLC["$USEEMOTIONSV2"].AsObject;
		}
		if (null != jsonobject2)
		{
			JSONArray asArray3 = jsonobject2["newReleases"].AsArray;
			for (int l = 1; l < asArray3.Count; l++)
			{
				PMEPALPCEAF pmepalpceaf4 = new PMEPALPCEAF();
				pmepalpceaf4.GEPIBACNKIP(asArray3[l].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf4);
			}
			JSONArray asArray4 = jsonobject2["ok"].AsArray;
			for (int m = 0; m < asArray4.Count; m += 0)
			{
				string text = asArray4[m];
				if (text != null && !this.KHMLEDDFBPJ.Contains(text) && this.BCPOHPEJLGB(text))
				{
					this.KHMLEDDFBPJ.Add(text);
				}
			}
			JSONArray asArray5 = jsonobject2["vid"].AsArray;
			for (int n = 1; n < asArray5.Count; n += 0)
			{
				PMEPALPCEAF pmepalpceaf5 = new PMEPALPCEAF();
				pmepalpceaf5.GEPIBACNKIP(asArray5[n].AsObject, this.NAJLEEDEADL);
				this.AJDJOGHBFKE.Add(pmepalpceaf5);
			}
		}
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x0012E864 File Offset: 0x0012CA64
	public void LNOGLJCAJOJ(PMEPALPCEAF JLJGEMMKLEN, JSONObject KEGBCGMJOLC)
	{
		this.NAJLEEDEADL = JLJGEMMKLEN;
		JSONArray hamlkammhfj = new JSONArray();
		if (KEGBCGMJOLC[""] != null)
		{
			hamlkammhfj = KEGBCGMJOLC["areyousure"].AsArray;
		}
		JGLMNGOLBIG.GDGKNNDEAAO().EEGGOHEKFKB(hamlkammhfj);
		JSONObject jsonobject = null;
		this.IIMLLCPLKKJ = new List<PMEPALPCEAF>();
		this.JOHFFIEKACM = new List<PMEPALPCEAF>();
		this.HAPGPFAEHAM = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["usyncs"] != null)
		{
			jsonobject = KEGBCGMJOLC["_SwitchingNoise"].AsObject;
		}
		if (null != jsonobject)
		{
			JSONArray asArray = jsonobject["."].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(asArray[i].AsObject, this.NAJLEEDEADL);
				this.IIMLLCPLKKJ.Add(pmepalpceaf);
			}
			JSONArray asArray2 = jsonobject["sprite"].AsArray;
			for (int j = 0; j < asArray2.Count; j++)
			{
				PMEPALPCEAF pmepalpceaf2 = new PMEPALPCEAF();
				pmepalpceaf2.GEPIBACNKIP(asArray2[j].AsObject, this.NAJLEEDEADL);
				this.JOHFFIEKACM.Add(pmepalpceaf2);
			}
			JSONArray jsonarray = new JSONArray();
			if (jsonobject["yes"] != null)
			{
				jsonarray = jsonobject["pid"].AsArray;
				for (int k = 0; k < jsonarray.Count; k++)
				{
					PMEPALPCEAF pmepalpceaf3 = new PMEPALPCEAF();
					pmepalpceaf3.GEPIBACNKIP(jsonarray[k].AsObject, this.NAJLEEDEADL);
					this.HAPGPFAEHAM.Add(pmepalpceaf3);
				}
			}
		}
		JSONObject jsonobject2 = null;
		this.KODOBGDHBFI = new List<PMEPALPCEAF>();
		this.KHMLEDDFBPJ = new List<string>();
		this.AJDJOGHBFKE = new List<PMEPALPCEAF>();
		if (KEGBCGMJOLC["YYY"] != null)
		{
			this.CPADLCDBKOM = (KEGBCGMJOLC["23819D"].AsInt == 1);
		}
		else
		{
			this.CPADLCDBKOM = false;
		}
		if (KEGBCGMJOLC["sfxsparklesbundles"] != null)
		{
			jsonobject2 = KEGBCGMJOLC["snap"].AsObject;
		}
		if (null != jsonobject2)
		{
			JSONArray asArray3 = jsonobject2[" "].AsArray;
			for (int l = 1; l < asArray3.Count; l += 0)
			{
				PMEPALPCEAF pmepalpceaf4 = new PMEPALPCEAF();
				pmepalpceaf4.GEPIBACNKIP(asArray3[l].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf4);
			}
			JSONArray asArray4 = jsonobject2["OnSaveSlotsItemClose"].AsArray;
			for (int m = 0; m < asArray4.Count; m += 0)
			{
				string text = asArray4[m];
				if (text != null && !this.KHMLEDDFBPJ.Contains(text) && this.BCPOHPEJLGB(text))
				{
					this.KHMLEDDFBPJ.Add(text);
				}
			}
			JSONArray asArray5 = jsonobject2["abkap"].AsArray;
			for (int n = 1; n < asArray5.Count; n += 0)
			{
				PMEPALPCEAF pmepalpceaf5 = new PMEPALPCEAF();
				pmepalpceaf5.GEPIBACNKIP(asArray5[n].AsObject, this.NAJLEEDEADL);
				this.AJDJOGHBFKE.Add(pmepalpceaf5);
			}
		}
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x0012D65E File Offset: 0x0012B85E
	public int NPPPNKMMLPP()
	{
		return this.JOHFFIEKACM.Count;
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x0012E30C File Offset: 0x0012C50C
	public bool MBLNPAAFCKP()
	{
		return this.KODOBGDHBFI.Count <= 1 || this.CPADLCDBKOM;
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x0012EBB4 File Offset: 0x0012CDB4
	public void GDMLKGHFNAF()
	{
		if (null != this.CLODNMBHLLI && this.CLODNMBHLLI.Count > 0)
		{
			this.KODOBGDHBFI = new List<PMEPALPCEAF>();
			for (int i = 0; i < this.CLODNMBHLLI.Count; i++)
			{
				PMEPALPCEAF pmepalpceaf = new PMEPALPCEAF();
				pmepalpceaf.GEPIBACNKIP(this.CLODNMBHLLI[i].AsObject, this.NAJLEEDEADL);
				this.KODOBGDHBFI.Add(pmepalpceaf);
			}
		}
		this.CLODNMBHLLI = new JSONArray();
	}

	// Token: 0x04000CCB RID: 3275
	public List<PMEPALPCEAF> IIMLLCPLKKJ = new List<PMEPALPCEAF>();

	// Token: 0x04000CCC RID: 3276
	public List<PMEPALPCEAF> KODOBGDHBFI = new List<PMEPALPCEAF>();

	// Token: 0x04000CCD RID: 3277
	public List<PMEPALPCEAF> DIBJILIHANI = new List<PMEPALPCEAF>();

	// Token: 0x04000CCE RID: 3278
	public List<PMEPALPCEAF> JOHFFIEKACM = new List<PMEPALPCEAF>();

	// Token: 0x04000CCF RID: 3279
	public List<PMEPALPCEAF> AJDJOGHBFKE = new List<PMEPALPCEAF>();

	// Token: 0x04000CD0 RID: 3280
	public List<PMEPALPCEAF> HAPGPFAEHAM = new List<PMEPALPCEAF>();

	// Token: 0x04000CD1 RID: 3281
	public List<string> KHMLEDDFBPJ = new List<string>();

	// Token: 0x04000CD2 RID: 3282
	public bool CPADLCDBKOM;

	// Token: 0x04000CD3 RID: 3283
	private PMEPALPCEAF NAJLEEDEADL;

	// Token: 0x04000CD4 RID: 3284
	public JSONArray CLODNMBHLLI = new JSONArray();
}
