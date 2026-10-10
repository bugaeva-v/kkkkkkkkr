using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000271 RID: 625
public class SceneTransitionToLobbyManager : MonoBehaviour
{
	// Token: 0x06004C34 RID: 19508 RVA: 0x0021F045 File Offset: 0x0021D245
	private void ILBAMCJFAAP()
	{
		base.StartCoroutine(this.FKJELOMLONG());
	}

	// Token: 0x06004C35 RID: 19509 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLEFIJPAJMJ()
	{
	}

	// Token: 0x06004C36 RID: 19510 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x06004C37 RID: 19511 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x06004C38 RID: 19512 RVA: 0x0021F054 File Offset: 0x0021D254
	private IEnumerator FKJELOMLONG()
	{
		return new SceneTransitionToLobbyManager.GOPPGPMEHLA(1);
	}

	// Token: 0x06004C39 RID: 19513 RVA: 0x0021F045 File Offset: 0x0021D245
	private void KNGLLGJEFGJ()
	{
		base.StartCoroutine(this.FKJELOMLONG());
	}

	// Token: 0x06004C3B RID: 19515 RVA: 0x0021F07A File Offset: 0x0021D27A
	private void BDILEIAPNIM()
	{
		base.StartCoroutine(this.DPNNNACHFBM());
	}

	// Token: 0x06004C3C RID: 19516 RVA: 0x0021F089 File Offset: 0x0021D289
	private void BHHNFCEKGCP()
	{
		base.StartCoroutine(this.DOAHGGKFHNC());
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x0021F098 File Offset: 0x0021D298
	private void JJIGCFGKFHO()
	{
		base.StartCoroutine(this.CMJOBBIPMBA());
	}

	// Token: 0x06004C3E RID: 19518 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x06004C3F RID: 19519 RVA: 0x0021F0A7 File Offset: 0x0021D2A7
	private void LDLLCBDGGHN()
	{
		base.StartCoroutine(this.HIMJOOHPMFG());
	}

	// Token: 0x06004C40 RID: 19520 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator KCBBBEICKNF()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x06004C41 RID: 19521 RVA: 0x0021F0BE File Offset: 0x0021D2BE
	private void EFIBBLFAMGD()
	{
		base.StartCoroutine(this.EIDNKHOLDMH());
	}

	// Token: 0x06004C42 RID: 19522 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator LOEBHCHBLKG()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x06004C43 RID: 19523 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator CAFNFEPIFOB()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x06004C44 RID: 19524 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator DOAHGGKFHNC()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x06004C45 RID: 19525 RVA: 0x0021F054 File Offset: 0x0021D254
	private IEnumerator CMJOBBIPMBA()
	{
		return new SceneTransitionToLobbyManager.GOPPGPMEHLA(1);
	}

	// Token: 0x06004C46 RID: 19526 RVA: 0x0021F0BE File Offset: 0x0021D2BE
	private void OnEnable()
	{
		base.StartCoroutine(this.EIDNKHOLDMH());
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x0021F045 File Offset: 0x0021D245
	private void CHEDGGLPOJP()
	{
		base.StartCoroutine(this.FKJELOMLONG());
	}

	// Token: 0x06004C48 RID: 19528 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06004C49 RID: 19529 RVA: 0x0021F054 File Offset: 0x0021D254
	private IEnumerator DENEINKACKD()
	{
		return new SceneTransitionToLobbyManager.GOPPGPMEHLA(1);
	}

	// Token: 0x06004C4A RID: 19530 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x06004C4B RID: 19531 RVA: 0x0021F0CD File Offset: 0x0021D2CD
	private void EHBJOHMNJFH()
	{
		base.StartCoroutine(this.DENEINKACKD());
	}

	// Token: 0x06004C4C RID: 19532 RVA: 0x0021F0DC File Offset: 0x0021D2DC
	private void DHNDICIEGEE()
	{
		base.StartCoroutine(this.CAFNFEPIFOB());
	}

	// Token: 0x06004C4D RID: 19533 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator EIDNKHOLDMH()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x0021F054 File Offset: 0x0021D254
	private IEnumerator HIMJOOHPMFG()
	{
		return new SceneTransitionToLobbyManager.GOPPGPMEHLA(1);
	}

	// Token: 0x06004C4F RID: 19535 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004C50 RID: 19536 RVA: 0x0021F0A7 File Offset: 0x0021D2A7
	private void AAGKOINJGOL()
	{
		base.StartCoroutine(this.HIMJOOHPMFG());
	}

	// Token: 0x06004C51 RID: 19537 RVA: 0x0021F089 File Offset: 0x0021D289
	private void AADPIFCICBL()
	{
		base.StartCoroutine(this.DOAHGGKFHNC());
	}

	// Token: 0x06004C52 RID: 19538 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator INOJFNAJHEH()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x06004C54 RID: 19540 RVA: 0x0021F0B6 File Offset: 0x0021D2B6
	private IEnumerator DPNNNACHFBM()
	{
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		yield return new WaitForSeconds(0.05f);
		if (!SceneTransitionToLobbyManager.isRestartingChapter && !SceneTransitionToLobbyManager.isRestoringUndoPoint && !SceneTransitionToLobbyManager.isRestoringRewindPoint)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		AppManager.EHBBFMCILPC.RestartApp(false, false);
		yield break;
	}

	// Token: 0x040015FE RID: 5630
	public static readonly string _xfBack = "Z9YHv/Z5QWSVE9YnOWlrBuP81sIfYWU0h/zbTzl+Hw38FrMvqSmUveDa/J/YDXZrYgLUo";

	// Token: 0x040015FF RID: 5631
	public static bool isRestartingChapter = false;

	// Token: 0x04001600 RID: 5632
	public static bool isRestoringUndoPoint = false;

	// Token: 0x04001601 RID: 5633
	public static bool isRestoringRewindPoint = false;
}
