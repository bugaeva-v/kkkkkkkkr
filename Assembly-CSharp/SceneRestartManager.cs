using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000A RID: 10
public class SceneRestartManager : MonoBehaviour
{
	// Token: 0x06000121 RID: 289 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator JMBOEEGLHBJ(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000122 RID: 290 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator AHNGGJIPNCC()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator HHPDPLOBCGM(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000124 RID: 292 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator AHDPEMAKMLO(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000125 RID: 293 RVA: 0x00009DC1 File Offset: 0x00007FC1
	private void KNGLLGJEFGJ()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.OGKBKLIFDGK());
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator PMOEJCBFMIN(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00009DFD File Offset: 0x00007FFD
	private void FBACIBOFHJO()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.BGEOMMJJBAC();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.KBAFJNHBGHG());
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00009E23 File Offset: 0x00008023
	private void NBIMDEPPBON()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.KKGNFHNGKKK();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.JAEDEEEHFON());
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator OEKGMGDHPEL(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator KLNFPOIGDLC(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x0600012B RID: 299 RVA: 0x00009E49 File Offset: 0x00008049
	private void MNNFOEOBLNF()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.BGEOMMJJBAC();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.JAEDEEEHFON());
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00009E6F File Offset: 0x0000806F
	private void DHNDICIEGEE()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.GJCEEECNMMN());
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator LBENDHGMDHK()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator LGLENNNBGHD()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator LPIICEIHNFP()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00009EA4 File Offset: 0x000080A4
	private void PABAKDIDDML()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00009EC3 File Offset: 0x000080C3
	private void JALCLCADMPK()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.CHHKIIJCHOF());
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator KBAFJNHBGHG()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00009EE9 File Offset: 0x000080E9
	private void LFABJIFAAII()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.KKGNFHNGKKK();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.KMGEJOFLJPM());
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator ICMCCNEIFIA(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000135 RID: 309 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator GLPGIFNGLBA()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator HNIFMKHMCDB(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000137 RID: 311 RVA: 0x00009F0F File Offset: 0x0000810F
	private void NPDBFEBICIK()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.OIMPBBKFKGP());
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00009F35 File Offset: 0x00008135
	private void PJCAGMOADBK()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.KHFKLEALDOO());
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00009F73 File Offset: 0x00008173
	private void AACGHELFCCL()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.BFEIIBIAJKL());
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00009D9C File Offset: 0x00007F9C
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

	// Token: 0x0600013C RID: 316 RVA: 0x00009F99 File Offset: 0x00008199
	private void JDMOENJPHOE()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator HDOJEDJBDJG(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x0600013E RID: 318 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator BFEIIBIAJKL()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator KGIGBIJHAMJ(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000140 RID: 320 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator NFJPFMLHNGN(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000141 RID: 321 RVA: 0x00009FB8 File Offset: 0x000081B8
	private void Awake()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator JJOALBJKCNA(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00009F99 File Offset: 0x00008199
	private void OPBNOGLBNDK()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00009EA4 File Offset: 0x000080A4
	private void IFHJKBHODGG()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00009FD7 File Offset: 0x000081D7
	private void CGLFKMJKOLJ()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator HOMKJPGBPJJ()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator NBGMFNKGFAK(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000148 RID: 328 RVA: 0x00009FF6 File Offset: 0x000081F6
	private void MFFEIHJPAMF()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.AFLBBCONLKM());
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator KHFKLEALDOO()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0000A01C File Offset: 0x0000821C
	private void HCJHLBFFNKA()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.BGEOMMJJBAC();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.CHHKIIJCHOF());
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000A042 File Offset: 0x00008242
	private void IFBCKJLCCAK()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.HOMKJPGBPJJ());
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00009FD7 File Offset: 0x000081D7
	private void PODHOCLABIO()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0000A068 File Offset: 0x00008268
	private void MFFLJDMOMPD()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.IAOGMMJPAIH());
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator DLALNBKIADB(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00009F99 File Offset: 0x00008199
	private void OAPJBCOGOMK()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000A08E File Offset: 0x0000828E
	private void IGLMKDPEKNF()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.FIJPIACDHND());
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator EPGNNDBCLHH()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000A0B4 File Offset: 0x000082B4
	private void EDANCCNNDMN()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.KKGNFHNGKKK();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.CCCFDACICOK());
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator MEJJBHOGKDH(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000154 RID: 340 RVA: 0x0000A0DA File Offset: 0x000082DA
	private void HCKLMFNDKBC()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.JAEDEEEHFON());
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator PHHDLMFEMDG()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000A100 File Offset: 0x00008300
	private void EPHNKBBGCAK()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00009EA4 File Offset: 0x000080A4
	private void NPFILNGGHGH()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000A11F File Offset: 0x0000831F
	private void FGFDLAIJMND()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.OMOHKEBAPLF());
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0000A145 File Offset: 0x00008345
	private void GMKJOIDPAIE()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.JAEDEEEHFON());
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator LJIPCBLABIM(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator GBMJEMKNFIL(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator FHINGPBBBED(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator FIJPIACDHND()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0000A16B File Offset: 0x0000836B
	private void GDKFOLEGMLF()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.JAEDEEEHFON());
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator OGGPPJNOHPN(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000160 RID: 352 RVA: 0x0000A191 File Offset: 0x00008391
	private void OHHHLCLEMGB()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.BGEOMMJJBAC();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.CHHKIIJCHOF());
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0000A1B7 File Offset: 0x000083B7
	private void IKHFPDLEJPE()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.AFLBBCONLKM());
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator CFPOEONLOFC(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00009EA4 File Offset: 0x000080A4
	private void JNCLGOBJGJD()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator APFDDKNOHLI()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0000A1DD File Offset: 0x000083DD
	private void AAGKOINJGOL()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.KKGNFHNGKKK();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.IAOGMMJPAIH());
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0000A203 File Offset: 0x00008403
	private void DBCGAKFDLGD()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000A222 File Offset: 0x00008422
	private void OPBHOAADDPA()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.KKGNFHNGKKK();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.GLPGIFNGLBA());
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000A100 File Offset: 0x00008300
	private void ECDLFGCLAGG()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0000A248 File Offset: 0x00008448
	private void BLNNGGKHGPF()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.AHNGGJIPNCC());
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00009FB8 File Offset: 0x000081B8
	private void HFICKGDOLBO()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00009FB8 File Offset: 0x000081B8
	private void CPHKLKGJEBH()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0000A26E File Offset: 0x0000846E
	private void MDFOBFFGDAB()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.CHHKIIJCHOF());
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator NMALODCILFK()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0000A294 File Offset: 0x00008494
	private void AADPIFCICBL()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.KHFFCNKIILD());
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00009F99 File Offset: 0x00008199
	private void LGPFPGKIMJG()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator KNLGJCLLGCC(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000171 RID: 369 RVA: 0x0000A2BA File Offset: 0x000084BA
	private void ALOJEMCBNOC()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.IAOGMMJPAIH());
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator NPGIPOEEOHJ(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000174 RID: 372 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator NFIPOGLECGI(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0000A2E8 File Offset: 0x000084E8
	private void MKBADGCCNDJ()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.EPGNNDBCLHH());
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator JMGGLIJOGOP(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator NEOCLFENPFD()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000A30E File Offset: 0x0000850E
	private void ALBKMBOKICH()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.AHNGGJIPNCC());
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator GGDEFLKANII(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000A334 File Offset: 0x00008534
	private void KONNFPPNJKM()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.KOLIEMCJLHO();
		base.StartCoroutine(this.MFKKOIBPFID());
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator JAEDEEEHFON()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator DLPOMBEHLCP()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator GAEOAHCBHOI(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000A35A File Offset: 0x0000855A
	private void LLGBJHCIIGA()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.BJFAJPFLPEM());
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator IGAKNJALMNN()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator PAAHBPEBLCN(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000181 RID: 385 RVA: 0x00009FB8 File Offset: 0x000081B8
	private void DOECDMINNOK()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator GJCEEECNMMN()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000A380 File Offset: 0x00008580
	private void OAJANHDGGEI()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.NLMJOHPAHLK();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.APFDDKNOHLI());
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator OMOHKEBAPLF()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator GAFENGJHMEO()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator IADHJIDNFIJ(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator CHHKIIJCHOF()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator DOJIPKCFIPP()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000A203 File Offset: 0x00008403
	private void LIBECOJEBKI()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator BOPIAPCAPFP(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator ICJCMLEGLPC()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator EKMCHBOIKGC()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00009FD7 File Offset: 0x000081D7
	private void OKBGBJDJMNI()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator KMGEJOFLJPM()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000A100 File Offset: 0x00008300
	private void OJGELECJGJC()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator IFNHKEEAEIH(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x06000191 RID: 401 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator EEJEPBJJFPE()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator IAOGMMJPAIH()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000A3A6 File Offset: 0x000085A6
	private void AECEPKMCKGB()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.APFDDKNOHLI());
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator OIMPBBKFKGP()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator MFKKOIBPFID()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator KOGJEIEFFFE()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000A3CC File Offset: 0x000085CC
	private void EHBJOHMNJFH()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.KKGNFHNGKKK();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.CCCFDACICOK());
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator NPDNIBNFGJL(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000A3F2 File Offset: 0x000085F2
	private void EHECBKECKPA()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator MNGDHBLFBGH(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x0600019B RID: 411 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator CCCFDACICOK()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000A411 File Offset: 0x00008611
	private void NIEEOIPNBAA()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.EGGIEEFMDNJ();
		base.StartCoroutine(this.LPIICEIHNFP());
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator NMAGNJDONFG(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x0600019E RID: 414 RVA: 0x00009DB2 File Offset: 0x00007FB2
	private IEnumerator HANCHMNKBOH()
	{
		SceneRestartManager.IMGOCIHMOMB imgocihmomb = new SceneRestartManager.IMGOCIHMOMB(1);
		imgocihmomb.<>4__this = this;
		return imgocihmomb;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000A437 File Offset: 0x00008637
	private void OnEnable()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.PHHDLMFEMDG());
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00009FB8 File Offset: 0x000081B8
	private void LFOJBMBCOFP()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
		}
		SceneRestartManager.clearProfile = false;
		PopupOnlineResources.textFlagDefault = 1;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00009DE7 File Offset: 0x00007FE7
	private IEnumerator DFFJGIMHNPF(string CEAADJNPKKA, bool KIDAIPFPOIN)
	{
		SceneRestartManager.AENDBAKHHAL aendbakhhal = new SceneRestartManager.AENDBAKHHAL(1);
		aendbakhhal._sceneName = CEAADJNPKKA;
		aendbakhhal._additive = KIDAIPFPOIN;
		return aendbakhhal;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00009D9C File Offset: 0x00007F9C
	private IEnumerator IJFBFGFPIGE(string CEAADJNPKKA, bool KIDAIPFPOIN)
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

	// Token: 0x060001A3 RID: 419 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator OGKBKLIFDGK()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator KHFFCNKIILD()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator AFLBBCONLKM()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0000A45D File Offset: 0x0000865D
	private void HDAHJCCAIAP()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MDMEJPNDOAN();
		LoadingEnvironmentManager.FOKFPDFLCFM();
		base.StartCoroutine(this.LPIICEIHNFP());
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0000A483 File Offset: 0x00008683
	private void NDFHKDJKHPP()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = false;
		NBDLBFJOEGN.MJPAJCBGDGE();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.LBENDHGMDHK());
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000A4A9 File Offset: 0x000086A9
	private void PEEKLFBDFEO()
	{
		SceneLobbyManager2.selectedFirstStoryOffering = -1;
		SceneRestartManager.sceneRestartManagerHit = true;
		NBDLBFJOEGN.IEIGAJKFNDA();
		LoadingEnvironmentManager.TryBegin();
		base.StartCoroutine(this.CHHKIIJCHOF());
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00009EA4 File Offset: 0x000080A4
	private void LPCKKJNJJCB()
	{
		if (SceneRestartManager.clearProfile)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GKMPFJPGLFL();
		}
		SceneRestartManager.clearProfile = true;
		PopupOnlineResources.textFlagDefault = 0;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00009E95 File Offset: 0x00008095
	private IEnumerator BJFAJPFLPEM()
	{
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.DisableRestartFade();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		yield return LoadingEnvironmentManager.WaitUntilSceneLoadIssued(1f);
		yield return this.FCCEMOMIPHI("SceneLobby2", false);
		yield break;
	}

	// Token: 0x04000021 RID: 33
	public static readonly string _rsPing = "vyFjBmG/8Er7no4UGQOh3U140UWxzQoq3WwD1fXhz2O1l8VSRKdzHUVHylJKh++tFQ==";

	// Token: 0x04000022 RID: 34
	public static bool sceneRestartManagerHit = false;

	// Token: 0x04000023 RID: 35
	public static bool clearProfile = false;
}
