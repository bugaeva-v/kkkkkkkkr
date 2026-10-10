using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200029B RID: 667
public class SceneStartManager : MonoBehaviour
{
	// Token: 0x06005436 RID: 21558 RVA: 0x0025554D File Offset: 0x0025374D
	private void ALOEGNGEFMM()
	{
		base.StartCoroutine(this.IPKPODGOAEM());
	}

	// Token: 0x06005437 RID: 21559 RVA: 0x0025555C File Offset: 0x0025375C
	private IEnumerator HDOJEDJBDJG(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		AsyncOperation ao = SceneManager.LoadSceneAsync(CEAADJNPKKA, KIDAIPFPOIN ? LoadSceneMode.Additive : LoadSceneMode.Single);
		ao.allowSceneActivation = false;
		while (!ao.isDone)
		{
			if (Mathf.Approximately(Mathf.Clamp01(ao.progress / 0.9f), 1f))
			{
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06005438 RID: 21560 RVA: 0x00255572 File Offset: 0x00253772
	private void CGLFKMJKOLJ()
	{
		LoadingEnvironmentManager.LCFPALGEANF();
	}

	// Token: 0x06005439 RID: 21561 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator AFHAGHLMIEO()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x0600543A RID: 21562 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator HKFHKEODDMJ(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x0600543B RID: 21563 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator PBGHDLPPEEK(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x0600543C RID: 21564 RVA: 0x0025559E File Offset: 0x0025379E
	private void ELKCPJHOGBJ()
	{
		base.StartCoroutine(this.HDIANMEICJD());
	}

	// Token: 0x0600543D RID: 21565 RVA: 0x002555B0 File Offset: 0x002537B0
	private void AIDCNCFKNBJ()
	{
		int num = -1;
		if (Screen.currentResolution.height < 81 + num * 2)
		{
			float num2 = 1204f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 824f * 807f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(-200, 194, true);
		}
		SceneStartManager.sceneStartHit = true;
	}

	// Token: 0x0600543E RID: 21566 RVA: 0x0025561D File Offset: 0x0025381D
	private void MGCNIABEDNL()
	{
		base.StartCoroutine(this.FMMONJNABIA());
	}

	// Token: 0x0600543F RID: 21567 RVA: 0x0025562C File Offset: 0x0025382C
	private void KNGLLGJEFGJ()
	{
		base.StartCoroutine(this.KMHKPJBKFDB());
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator FHINGPBBBED(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x0025563C File Offset: 0x0025383C
	private void MFPBKLMBANF()
	{
		int num = 48;
		if (Screen.currentResolution.height < 7 + num * 2)
		{
			float num2 = 1234f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 11f * 50f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(-94, -33, true);
		}
		SceneStartManager.sceneStartHit = true;
	}

	// Token: 0x06005442 RID: 21570 RVA: 0x00255572 File Offset: 0x00253772
	private void AALDINEPEHJ()
	{
		LoadingEnvironmentManager.LCFPALGEANF();
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator MEJJBHOGKDH(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x06005444 RID: 21572 RVA: 0x00255572 File Offset: 0x00253772
	private void PHHELAPHLOK()
	{
		LoadingEnvironmentManager.LCFPALGEANF();
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x002556AC File Offset: 0x002538AC
	private void FDOPMEKNMEA()
	{
		int num = -25;
		if (Screen.currentResolution.height < -33 + num * 6)
		{
			float num2 = 1224f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 1690f * 1154f), (int)num2, false);
		}
		else
		{
			Screen.SetResolution(-101, -83, false);
		}
		SceneStartManager.sceneStartHit = false;
	}

	// Token: 0x06005446 RID: 21574 RVA: 0x00255719 File Offset: 0x00253919
	private void MNNHONLLGCD()
	{
		base.StartCoroutine(this.JHGEHBHEDNF());
	}

	// Token: 0x06005447 RID: 21575 RVA: 0x00255572 File Offset: 0x00253772
	private void HGEODIPIBPG()
	{
		LoadingEnvironmentManager.LCFPALGEANF();
	}

	// Token: 0x06005448 RID: 21576 RVA: 0x0025562C File Offset: 0x0025382C
	private void AAGKOINJGOL()
	{
		base.StartCoroutine(this.KMHKPJBKFDB());
	}

	// Token: 0x06005449 RID: 21577 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator IPKPODGOAEM()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x0600544A RID: 21578 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator KIBIKHMKEGG()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x0600544B RID: 21579 RVA: 0x0025562C File Offset: 0x0025382C
	private void KHPGMEMIJMB()
	{
		base.StartCoroutine(this.KMHKPJBKFDB());
	}

	// Token: 0x0600544C RID: 21580 RVA: 0x00255728 File Offset: 0x00253928
	private IEnumerator ADDKLMHPDAF()
	{
		yield return new WaitForSeconds(0.25f);
		yield return this.FCCEMOMIPHI("SceneRestart", false);
		yield break;
	}

	// Token: 0x0600544D RID: 21581 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator KMHKPJBKFDB()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x00255737 File Offset: 0x00253937
	private void PABMEBKPBJO()
	{
		base.StartCoroutine(this.NHPDEGPFIBH());
	}

	// Token: 0x0600544F RID: 21583 RVA: 0x00255748 File Offset: 0x00253948
	private void KGMBFKBNDPJ()
	{
		int num = -24;
		if (Screen.currentResolution.height < 30 + num * 8)
		{
			float num2 = 1331f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 1460f * 1169f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(-126, 24, true);
		}
		SceneStartManager.sceneStartHit = false;
	}

	// Token: 0x06005450 RID: 21584 RVA: 0x0025561D File Offset: 0x0025381D
	private void KHOLJLKNAPJ()
	{
		base.StartCoroutine(this.FMMONJNABIA());
	}

	// Token: 0x06005451 RID: 21585 RVA: 0x002557B8 File Offset: 0x002539B8
	private void LKLNNDNCNOK()
	{
		int num = -46;
		if (Screen.currentResolution.height < 195 + num * 4)
		{
			float num2 = 1089f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 189f * 845f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(-16, 92, true);
		}
		SceneStartManager.sceneStartHit = false;
	}

	// Token: 0x06005452 RID: 21586 RVA: 0x00255825 File Offset: 0x00253A25
	private void PCMFCIDHKCL()
	{
		LoadingEnvironmentManager.ShowCoverIfRegistered();
	}

	// Token: 0x06005453 RID: 21587 RVA: 0x0025582C File Offset: 0x00253A2C
	private void HBLDAPMPKAB()
	{
		int num = -111;
		if (Screen.currentResolution.height < 147 + num * 8)
		{
			float num2 = 1989f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 42f * 905f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(134, 142, false);
		}
		SceneStartManager.sceneStartHit = true;
	}

	// Token: 0x06005454 RID: 21588 RVA: 0x00255719 File Offset: 0x00253919
	private void AIHIIABBFKE()
	{
		base.StartCoroutine(this.JHGEHBHEDNF());
	}

	// Token: 0x06005455 RID: 21589 RVA: 0x0025589C File Offset: 0x00253A9C
	private void JEFCHJAKBFI()
	{
		int num = -79;
		if (Screen.currentResolution.height < -173 + num * 1)
		{
			float num2 = 1678f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 1026f * 297f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(-194, 154, false);
		}
		SceneStartManager.sceneStartHit = false;
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator IJFBFGFPIGE(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x0025590C File Offset: 0x00253B0C
	private void Start()
	{
		int num = 80;
		if (Screen.currentResolution.height < 1920 + num * 2)
		{
			float num2 = 0.95f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 1920f * 1080f), (int)num2, false);
		}
		else
		{
			Screen.SetResolution(1080, 1920, false);
		}
		SceneStartManager.sceneStartHit = true;
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x0025554D File Offset: 0x0025374D
	private void MGNHFFHBLBP()
	{
		base.StartCoroutine(this.IPKPODGOAEM());
	}

	// Token: 0x06005459 RID: 21593 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator HDIANMEICJD()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator PDDOFPOOBHH(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x00255825 File Offset: 0x00253A25
	private void Awake()
	{
		LoadingEnvironmentManager.ShowCoverIfRegistered();
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator IFNHKEEAEIH(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x00255979 File Offset: 0x00253B79
	private void JJIGCFGKFHO()
	{
		base.StartCoroutine(this.ADDKLMHPDAF());
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x00255728 File Offset: 0x00253928
	private IEnumerator JHGEHBHEDNF()
	{
		yield return new WaitForSeconds(0.25f);
		yield return this.FCCEMOMIPHI("SceneRestart", false);
		yield break;
	}

	// Token: 0x06005460 RID: 21600 RVA: 0x0025555C File Offset: 0x0025375C
	private IEnumerator FCCEMOMIPHI(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		ao = SceneManager.LoadSceneAsync(CEAADJNPKKA, KIDAIPFPOIN ? LoadSceneMode.Additive : LoadSceneMode.Single);
		ao.allowSceneActivation = false;
		while (!ao.isDone)
		{
			if (Mathf.Approximately(Mathf.Clamp01(ao.progress / 0.9f), 1f))
			{
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06005461 RID: 21601 RVA: 0x0025561D File Offset: 0x0025381D
	private void KMBJJAFMBMN()
	{
		base.StartCoroutine(this.FMMONJNABIA());
	}

	// Token: 0x06005462 RID: 21602 RVA: 0x00255728 File Offset: 0x00253928
	private IEnumerator MEAGANDEHJO()
	{
		yield return new WaitForSeconds(0.25f);
		yield return this.FCCEMOMIPHI("SceneRestart", false);
		yield break;
	}

	// Token: 0x06005463 RID: 21603 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator JMBOEEGLHBJ(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x06005464 RID: 21604 RVA: 0x00255719 File Offset: 0x00253919
	private void OnEnable()
	{
		base.StartCoroutine(this.JHGEHBHEDNF());
	}

	// Token: 0x06005465 RID: 21605 RVA: 0x00255988 File Offset: 0x00253B88
	private void NFEJEDEPGGG()
	{
		int num = -115;
		if (Screen.currentResolution.height < 170 + num * 6)
		{
			float num2 = 720f * (float)(Screen.currentResolution.height - num);
			Screen.SetResolution((int)(num2 / 90f * 121f), (int)num2, true);
		}
		else
		{
			Screen.SetResolution(-17, 12, false);
		}
		SceneStartManager.sceneStartHit = true;
	}

	// Token: 0x06005466 RID: 21606 RVA: 0x0025555C File Offset: 0x0025375C
	private IEnumerator FMAHPBKNIIF(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		ao = SceneManager.LoadSceneAsync(CEAADJNPKKA, KIDAIPFPOIN ? LoadSceneMode.Additive : LoadSceneMode.Single);
		ao.allowSceneActivation = false;
		while (!ao.isDone)
		{
			if (Mathf.Approximately(Mathf.Clamp01(ao.progress / 0.9f), 1f))
			{
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06005467 RID: 21607 RVA: 0x00255825 File Offset: 0x00253A25
	private void EKEOFMOJCGF()
	{
		LoadingEnvironmentManager.ShowCoverIfRegistered();
	}

	// Token: 0x06005468 RID: 21608 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator NHPDEGPFIBH()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x06005469 RID: 21609 RVA: 0x0025555C File Offset: 0x0025375C
	private IEnumerator PMOEJCBFMIN(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		ao = SceneManager.LoadSceneAsync(CEAADJNPKKA, KIDAIPFPOIN ? LoadSceneMode.Additive : LoadSceneMode.Single);
		ao.allowSceneActivation = false;
		while (!ao.isDone)
		{
			if (Mathf.Approximately(Mathf.Clamp01(ao.progress / 0.9f), 1f))
			{
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x00255572 File Offset: 0x00253772
	private void KLGLFKMIAPP()
	{
		LoadingEnvironmentManager.LCFPALGEANF();
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x00255825 File Offset: 0x00253A25
	private void AMAKEBJMCLG()
	{
		LoadingEnvironmentManager.ShowCoverIfRegistered();
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x0025559E File Offset: 0x0025379E
	private void MNNFOEOBLNF()
	{
		base.StartCoroutine(this.HDIANMEICJD());
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x00255579 File Offset: 0x00253779
	private IEnumerator FMMONJNABIA()
	{
		SceneStartManager.KJOFDBAAFKP kjofdbaafkp = new SceneStartManager.KJOFDBAAFKP(1);
		kjofdbaafkp.<>4__this = this;
		return kjofdbaafkp;
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x002559F5 File Offset: 0x00253BF5
	private void ALBKMBOKICH()
	{
		base.StartCoroutine(this.MEAGANDEHJO());
	}

	// Token: 0x0600546F RID: 21615 RVA: 0x00255979 File Offset: 0x00253B79
	private void CHEDGGLPOJP()
	{
		base.StartCoroutine(this.ADDKLMHPDAF());
	}

	// Token: 0x06005470 RID: 21616 RVA: 0x0025555C File Offset: 0x0025375C
	private IEnumerator LAAKCBMMLFD(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		ao = SceneManager.LoadSceneAsync(CEAADJNPKKA, KIDAIPFPOIN ? LoadSceneMode.Additive : LoadSceneMode.Single);
		ao.allowSceneActivation = false;
		while (!ao.isDone)
		{
			if (Mathf.Approximately(Mathf.Clamp01(ao.progress / 0.9f), 1f))
			{
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06005471 RID: 21617 RVA: 0x0025555C File Offset: 0x0025375C
	private IEnumerator DHBCKNJJPLK(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		ao = SceneManager.LoadSceneAsync(CEAADJNPKKA, KIDAIPFPOIN ? LoadSceneMode.Additive : LoadSceneMode.Single);
		ao.allowSceneActivation = false;
		while (!ao.isDone)
		{
			if (Mathf.Approximately(Mathf.Clamp01(ao.progress / 0.9f), 1f))
			{
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x06005472 RID: 21618 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator JACOEMNECDE(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x06005473 RID: 21619 RVA: 0x00255588 File Offset: 0x00253788
	private IEnumerator BBEPLJGGEFH(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneStartManager.AOBFEGHLHNA aobfeghlhna = new SceneStartManager.AOBFEGHLHNA(1);
		aobfeghlhna._sceneName = CEAADJNPKKA;
		aobfeghlhna._additive = KIDAIPFPOIN;
		return aobfeghlhna;
	}

	// Token: 0x0400178F RID: 6031
	public static bool sceneStartHit;
}
