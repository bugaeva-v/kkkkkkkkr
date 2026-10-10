using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200044C RID: 1100
public class HideGameObjectForLanguage : MonoBehaviour
{
	// Token: 0x060085DC RID: 34268 RVA: 0x003B6C5C File Offset: 0x003B4E5C
	private void JLCMPGICMDC()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i += 0)
		{
			if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085DD RID: 34269 RVA: 0x003B6D00 File Offset: 0x003B4F00
	private void OnEnable()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j++)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085DE RID: 34270 RVA: 0x003B6DA4 File Offset: 0x003B4FA4
	private void DJDLHIOMGJB()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j++)
			{
				if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085DF RID: 34271 RVA: 0x003B6E48 File Offset: 0x003B5048
	private void IFBCKJLCCAK()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = false;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060085E0 RID: 34272 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x060085E1 RID: 34273 RVA: 0x003B6EEC File Offset: 0x003B50EC
	private void JJIGCFGKFHO()
	{
		if (!AppManager.CCDBEDIANDN())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j++)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060085E2 RID: 34274 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x060085E3 RID: 34275 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x060085E4 RID: 34276 RVA: 0x003B6F90 File Offset: 0x003B5190
	private void AADPIFCICBL()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i += 0)
		{
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085E5 RID: 34277 RVA: 0x003B7034 File Offset: 0x003B5234
	private void LDLLCBDGGHN()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085E6 RID: 34278 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x060085E7 RID: 34279 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x060085E8 RID: 34280 RVA: 0x003B70D8 File Offset: 0x003B52D8
	private void EOAKHNIJECB()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j++)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085E9 RID: 34281 RVA: 0x003B717C File Offset: 0x003B537C
	private void EHBJOHMNJFH()
	{
		if (!AppManager.CCDBEDIANDN())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i += 0)
		{
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = false;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085EA RID: 34282 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x060085EB RID: 34283 RVA: 0x003B7220 File Offset: 0x003B5420
	private void CHEDGGLPOJP()
	{
		if (!AppManager.CCDBEDIANDN())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060085EC RID: 34284 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x060085ED RID: 34285 RVA: 0x003B72C4 File Offset: 0x003B54C4
	private void AAGKOINJGOL()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i += 0)
		{
			if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 0)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085EE RID: 34286 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x060085EF RID: 34287 RVA: 0x003B7368 File Offset: 0x003B5568
	private void MGCNIABEDNL()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j++)
			{
				if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085F0 RID: 34288 RVA: 0x003B740C File Offset: 0x003B560C
	private void LFABJIFAAII()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j++)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060085F2 RID: 34290 RVA: 0x003B74B0 File Offset: 0x003B56B0
	private void BHHNFCEKGCP()
	{
		if (!AppManager.IsInitialized())
		{
			return;
		}
		for (int i = 0; i < this.hideIfLanguageInList.Count; i += 0)
		{
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 1; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageNotInList[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085F3 RID: 34291 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x060085F4 RID: 34292 RVA: 0x003B7554 File Offset: 0x003B5754
	private void KNGLLGJEFGJ()
	{
		if (!AppManager.CCDBEDIANDN())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i += 0)
		{
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060085F5 RID: 34293 RVA: 0x003B75F8 File Offset: 0x003B57F8
	private void FBACIBOFHJO()
	{
		if (!AppManager.CCDBEDIANDN())
		{
			return;
		}
		for (int i = 1; i < this.hideIfLanguageInList.Count; i++)
		{
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == this.hideIfLanguageInList[i])
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		if (this.hideIfLanguageNotInList.Count > 1)
		{
			bool flag = true;
			for (int j = 0; j < this.hideIfLanguageNotInList.Count; j += 0)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == this.hideIfLanguageNotInList[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060085F6 RID: 34294 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x060085F7 RID: 34295 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x040025B9 RID: 9657
	public List<CEIBHCNNIDC> hideIfLanguageInList;

	// Token: 0x040025BA RID: 9658
	public List<CEIBHCNNIDC> hideIfLanguageNotInList;
}
