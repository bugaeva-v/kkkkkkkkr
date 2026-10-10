using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000359 RID: 857
public class StoryItemManager : MonoBehaviour
{
	// Token: 0x060065B7 RID: 26039 RVA: 0x002F48A0 File Offset: 0x002F2AA0
	public void AHGGGOPFADO(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.DHIMNDDEPCB(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065B8 RID: 26040 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x060065B9 RID: 26041 RVA: 0x002F48F0 File Offset: 0x002F2AF0
	public void OBDDKENGDPH(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.PLOPJCKHGHN(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065BA RID: 26042 RVA: 0x00003E52 File Offset: 0x00002052
	private void HBLDAPMPKAB()
	{
	}

	// Token: 0x060065BB RID: 26043 RVA: 0x002F4940 File Offset: 0x002F2B40
	public void FPHEIFACBBG(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FHDDFOMHIOG(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065BC RID: 26044 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x060065BD RID: 26045 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFKPGJOMIOL()
	{
	}

	// Token: 0x060065BE RID: 26046 RVA: 0x002F4990 File Offset: 0x002F2B90
	public void NFBMPPHEKDG(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.PMGHBADFENE(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065BF RID: 26047 RVA: 0x002F49E0 File Offset: 0x002F2BE0
	public void HNKCJCLAFOK(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.KPKKNPAJGLA(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065C0 RID: 26048 RVA: 0x002F4A30 File Offset: 0x002F2C30
	public void IMADGDGPBOB(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sfxtimeoutwarning");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-59, (byte)-146, (byte)-20, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.EJIDHMKFONK(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(" "))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065C1 RID: 26049 RVA: 0x002F4B28 File Offset: 0x002F2D28
	public void OFOAFPKPIKC(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("focuswardrobetitle");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(191, 57, (byte)-67, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.FHDDFOMHIOG(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("syn"))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065C2 RID: 26050 RVA: 0x002F4C20 File Offset: 0x002F2E20
	public void BCEJLINOANG(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065C3 RID: 26051 RVA: 0x002F4C70 File Offset: 0x002F2E70
	public void KIDOILDEFEB(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("skinshopinfotoken");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-166, (byte)-145, 102, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.EJIDHMKFONK(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("\""))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065C4 RID: 26052 RVA: 0x002F4D68 File Offset: 0x002F2F68
	public void DOFLEONDCMI(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Ink asset is null!");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-89, (byte)-103, (byte)-173, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.HGNPHMEHDIF(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(""))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065C5 RID: 26053 RVA: 0x002F4E60 File Offset: 0x002F3060
	public void OCOOJNFJJPG(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("eval");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(75, (byte)-27, (byte)-44, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.EGJBINPMPAI(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(""))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065C6 RID: 26054 RVA: 0x002F4F58 File Offset: 0x002F3158
	public void PFJJGICHPAP(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.PBBECIJLHLB(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065C7 RID: 26055 RVA: 0x002F4FA8 File Offset: 0x002F31A8
	public void KKEAHIBMOHA(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.PPADAJFNNJO(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065C8 RID: 26056 RVA: 0x002F4FF8 File Offset: 0x002F31F8
	public void EGJBINPMPAI(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.PFJJGICHPAP(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065C9 RID: 26057 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x060065CA RID: 26058 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x060065CB RID: 26059 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPCIIBNLBAL()
	{
	}

	// Token: 0x060065CC RID: 26060 RVA: 0x002F5048 File Offset: 0x002F3248
	public void MIFPDCLHKDH(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceHeaderHideComplete");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(56, (byte)-199, 191, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.BCEJLINOANG(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("ok"))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065CD RID: 26061 RVA: 0x002F5140 File Offset: 0x002F3340
	public void GKHOKHFAODA(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065CE RID: 26062 RVA: 0x002F5190 File Offset: 0x002F3390
	public void KJDNFFJJLDN(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("retry");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(74, (byte)-85, 74, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.EJIDHMKFONK(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnWheelOfFortuneClick"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065CF RID: 26063 RVA: 0x002F5288 File Offset: 0x002F3488
	public void PBBECIJLHLB(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.MDIBLKOEEAL(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065D1 RID: 26065 RVA: 0x002F52EC File Offset: 0x002F34EC
	public void BGLIAHEKACL(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("avatarcollectionstutor4title");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-78, 64, (byte)-18, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.FindAllObjectsInChildren(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("trialmode"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065D2 RID: 26066 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x060065D3 RID: 26067 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x060065D4 RID: 26068 RVA: 0x002F53E4 File Offset: 0x002F35E4
	public void EJIDHMKFONK(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.OBDDKENGDPH(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065D5 RID: 26069 RVA: 0x002F5434 File Offset: 0x002F3634
	public void ECLFMKLKBOC(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.KPKKNPAJGLA(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065D6 RID: 26070 RVA: 0x002F5484 File Offset: 0x002F3684
	public void KPKKNPAJGLA(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.GKHOKHFAODA(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065D7 RID: 26071 RVA: 0x002F54D4 File Offset: 0x002F36D4
	public void HGNPHMEHDIF(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.PMGHBADFENE(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065D8 RID: 26072 RVA: 0x002F5524 File Offset: 0x002F3724
	public void MDIBLKOEEAL(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.HJEHPKBHEMA(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065D9 RID: 26073 RVA: 0x002F5574 File Offset: 0x002F3774
	public void HNHFFPPELIG(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("not");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-180, 189, 138, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.PFJJGICHPAP(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnStoryInterfaceHeaderBackClick"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065DA RID: 26074 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKPANMAFAIL()
	{
	}

	// Token: 0x060065DB RID: 26075 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x060065DC RID: 26076 RVA: 0x002F566C File Offset: 0x002F386C
	public void LBLHDPJGKKD(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FHDDFOMHIOG(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065DD RID: 26077 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x060065DE RID: 26078 RVA: 0x002F56BC File Offset: 0x002F38BC
	public void EAIKJONDAIP(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.PPADAJFNNJO(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065DF RID: 26079 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x060065E0 RID: 26080 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x060065E1 RID: 26081 RVA: 0x002F570C File Offset: 0x002F390C
	public void Initialize(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryItemManager.Initialize() - _item is null.");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.FindAllObjectsInChildren(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("flash"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065E2 RID: 26082 RVA: 0x002F5804 File Offset: 0x002F3A04
	public void KGFEFGNFPJO(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" tier=");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-77, 198, (byte)-114, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.FPHEIFACBBG(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("$it"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065E3 RID: 26083 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x060065E4 RID: 26084 RVA: 0x002F58FC File Offset: 0x002F3AFC
	public void PLOPJCKHGHN(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.DHIMNDDEPCB(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065E5 RID: 26085 RVA: 0x002F594C File Offset: 0x002F3B4C
	public void AJNNDKIIFDN(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ratethankyou");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-33, 96, (byte)-88, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.ECLFMKLKBOC(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(""))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065E6 RID: 26086 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060065E7 RID: 26087 RVA: 0x002F5A44 File Offset: 0x002F3C44
	public void FHDDFOMHIOG(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.BCEJLINOANG(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065E8 RID: 26088 RVA: 0x002F5A94 File Offset: 0x002F3C94
	public void HJEHPKBHEMA(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.PFJJGICHPAP(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065E9 RID: 26089 RVA: 0x002F5AE4 File Offset: 0x002F3CE4
	public void HBBFAAOICDH(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.GetNextUnsyncedAvatarCollections(): dropping ghost unsynced entry ");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-149, 179, (byte)-25, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.EGJBINPMPAI(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("StoryStepDialogReadInput.GetContentType() - unknown type."))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065EA RID: 26090 RVA: 0x002F5BDC File Offset: 0x002F3DDC
	public void PPADAJFNNJO(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.EAIKJONDAIP(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065EB RID: 26091 RVA: 0x002F5C2C File Offset: 0x002F3E2C
	public void PMGHBADFENE(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.OBDDKENGDPH(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065EC RID: 26092 RVA: 0x002F5C7C File Offset: 0x002F3E7C
	public void FindAllObjectsInChildren(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065ED RID: 26093 RVA: 0x002F5CCC File Offset: 0x002F3ECC
	public void MIOMPIGJKFE(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("loop");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(181, (byte)-101, (byte)-109, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.PLOPJCKHGHN(base.gameObject);
				}
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("StorySave.GetChapterSnapshotGuid(): false == chapterSnapshots.Contains(_chapterIndex)"))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065EE RID: 26094 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIHOIEGKJLA()
	{
	}

	// Token: 0x060065EF RID: 26095 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x060065F0 RID: 26096 RVA: 0x002F5DC4 File Offset: 0x002F3FC4
	public void NDACAKGFEFP(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("avtssnap2");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-163, 106, 136, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.PPADAJFNNJO(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("Critical error, could not load asset bundle:"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065F1 RID: 26097 RVA: 0x002F5EBC File Offset: 0x002F40BC
	public void KNHFGIOAAFD(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.PBBECIJLHLB(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065F2 RID: 26098 RVA: 0x002F5F0C File Offset: 0x002F410C
	public void GHIEBKPPAKB(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.ECLFMKLKBOC(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065F3 RID: 26099 RVA: 0x002F5F5C File Offset: 0x002F415C
	public void DGAFAPKAKIA(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("avatarcollectionsundotitle");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(124, 132, 109, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.ECLFMKLKBOC(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("CRT scale"))
					{
						this.CAPFGOKNDIM[i].SetActive(false);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065F4 RID: 26100 RVA: 0x002F6054 File Offset: 0x002F4254
	public void DHIMNDDEPCB(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
			{
				this.PLOPJCKHGHN(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060065F5 RID: 26101 RVA: 0x002F60A4 File Offset: 0x002F42A4
	public void HHBPGAMBAAE(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("p");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32(157, (byte)-8, (byte)-111, 0);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.KKEAHIBMOHA(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(" "))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060065F6 RID: 26102 RVA: 0x002F619C File Offset: 0x002F439C
	public void HJMIOBLIDKA(AssetStoryItem FHFAPLPBKOD, bool MOMCFCNKEJA = false)
	{
		if (null == FHFAPLPBKOD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("country_code");
			return;
		}
		this.itemImage.sprite = FHFAPLPBKOD.sprite;
		this.itemImage.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.itemImage, FHFAPLPBKOD);
		if (MOMCFCNKEJA)
		{
			base.gameObject.GetComponent<Image>().color = new Color32((byte)-5, (byte)-129, 63, 1);
			try
			{
				if (this.CAPFGOKNDIM.Count == 0)
				{
					this.NFBMPPHEKDG(base.gameObject);
				}
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("mpi"))
					{
						this.CAPFGOKNDIM[i].SetActive(true);
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x04001D5F RID: 7519
	public Image itemImage;

	// Token: 0x04001D60 RID: 7520
	private List<GameObject> CAPFGOKNDIM = new List<GameObject>();
}
