using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x02000019 RID: 25
public class DialogTitleManager : MonoBehaviour
{
	// Token: 0x060003FC RID: 1020 RVA: 0x0001D67C File Offset: 0x0001B87C
	private bool CAKAMPNELIM()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("overlay");
			return false;
		}
		return true;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0001D694 File Offset: 0x0001B894
	public void HPKILNBJCPH(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.PPAIOKKEENM())
		{
			return;
		}
		string text = ONEHEBIHPFB.DEOJEIEJGEE(JIKFCLOHJNN.DGBGJOAKOCN());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().NNNKIPGJMMF(text);
		}
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x0001D6EA File Offset: 0x0001B8EA
	public static float ELHMKJKMBPC()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.CPJMIPIKKMM(1771f);
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x0001D708 File Offset: 0x0001B908
	public void GPGCCIIOKON()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.PFGEKCANOFH());
		}
		this.PANMNKKODPC.DOFade(1407f, DialogTitleManager.animationAppearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.JAOJDFDDAEL(350f));
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x0001D758 File Offset: 0x0001B958
	private void GCDAAPBFLJK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 503f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 686f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x0001D7B0 File Offset: 0x0001B9B0
	private void LFOJBMBCOFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1482f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 150f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00003E52 File Offset: 0x00002052
	private void KPNNMDECEEH()
	{
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x0001D808 File Offset: 0x0001BA08
	private void MFFLABGBGAJ()
	{
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDisable()
	{
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x0001D818 File Offset: 0x0001BA18
	public void MPOEFJBEKIJ(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.PPAIOKKEENM())
		{
			return;
		}
		string text = ONEHEBIHPFB.LMDACNKELEC(JIKFCLOHJNN.PGDIEKPDAJN());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, true);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().NNNKIPGJMMF(text);
		}
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00003E52 File Offset: 0x00002052
	private void MDFOBFFGDAB()
	{
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0001D86E File Offset: 0x0001BA6E
	private bool DJPMKKGFDOG()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchBalance.Build() - JSON root is null");
			return false;
		}
		return false;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0001D885 File Offset: 0x0001BA85
	private bool LPLOHOJFFDL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return false;
		}
		return false;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEPMOBKFIMI()
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x0001D89C File Offset: 0x0001BA9C
	private bool EJFEBOMCBFL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>.");
			return false;
		}
		return true;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
	private void DBMENPFHHCM()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1044f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 502f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0001D90C File Offset: 0x0001BB0C
	public void PKJDJJDPNGD()
	{
		this.PANMNKKODPC.DOFade(1811f, DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.MLEPAJKOKEK(1725f));
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator ECEDKHCNNBM()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x0001D948 File Offset: 0x0001BB48
	private void HGEODIPIBPG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 982f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 594f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void LLHKEAOMBON()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x0001D9AF File Offset: 0x0001BBAF
	public void JAIBKPNINFE()
	{
		this.PANMNKKODPC.DOFade(1286f, DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.CPJMIPIKKMM(153f));
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x0001D808 File Offset: 0x0001BA08
	private void MBAJBIPOFCB()
	{
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00003E52 File Offset: 0x00002052
	private void HCKLMFNDKBC()
	{
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x0001D9DC File Offset: 0x0001BBDC
	public void ACGGMOACIHN(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.NDGNEHOHBJL())
		{
			return;
		}
		string text = ONEHEBIHPFB.DEOJEIEJGEE(JIKFCLOHJNN.PCNBFOOEPID());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().NNNKIPGJMMF(text);
		}
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void KNPBDPGCMOJ()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x0001DA32 File Offset: 0x0001BC32
	public void FJEFBBOMLEL()
	{
		this.PANMNKKODPC.DOFade(670f, DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.ILIONIOJMIC(1823f));
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x0001DA5F File Offset: 0x0001BC5F
	public static float MLLMMOPLLLA()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.HAKILJMJCLA(358f);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x0001DA7B File Offset: 0x0001BC7B
	public static float KDEBKEEFPPI()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.HAKILJMJCLA(405f);
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0001DA97 File Offset: 0x0001BC97
	private bool CJPOLFAHNJC()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sind");
			return true;
		}
		return true;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator DDBEMNCJIMJ()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0001DAB0 File Offset: 0x0001BCB0
	private void JDBJMNMBOMK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1363f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1099f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0001DB08 File Offset: 0x0001BD08
	private bool PPAIOKKEENM()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return false;
		}
		return true;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0001DB20 File Offset: 0x0001BD20
	public void BHNBBNFGNDH()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.OEABCNLMKMA());
		}
		this.PANMNKKODPC.DOFade(212f, DialogTitleManager.animationAppearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.BAPEJNBMNHC(1929f));
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void OnDestroy()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x0001DB70 File Offset: 0x0001BD70
	private void DBCGAKFDLGD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 48f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1673f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
	private void JFBEKHOJEAO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 216f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1298f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x0001DC20 File Offset: 0x0001BE20
	public static float CHOBNGHAPJG()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1723f);
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator GDEOHPJOBFA()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void LPMPMAJGALN()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00003E52 File Offset: 0x00002052
	private void BNOEAHFICOB()
	{
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x0001DC4B File Offset: 0x0001BE4B
	private bool OONENNLLFHL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("DialogTitleManager.InputDataIsValid() - step is null.");
			return false;
		}
		return true;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x0001DC71 File Offset: 0x0001BE71
	public void KPPCHKABMOM()
	{
		this.PANMNKKODPC.DOFade(1994f, DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.HAPIGPHMNHJ(921f));
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00003E52 File Offset: 0x00002052
	private void HEHFAKOFHPK()
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x0001DC9E File Offset: 0x0001BE9E
	private bool BLKBOGPEPKD()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("file://");
			return false;
		}
		return false;
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x0001DCB5 File Offset: 0x0001BEB5
	private bool NDGNEHOHBJL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("feature disabled by balance");
			return false;
		}
		return false;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x0001DCCC File Offset: 0x0001BECC
	public static float IHKCLPAFKLE()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1080f);
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
	private bool DAPPHPICICJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnSaveSlotsExpiredPassSubscribePositive");
			return false;
		}
		return false;
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator ADAOCKEKDKE()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x0001DCFF File Offset: 0x0001BEFF
	public static float BBJIHALBOGE()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.DCEHMKDEHIC(791f);
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00003E52 File Offset: 0x00002052
	private void FBACIBOFHJO()
	{
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0001DD1C File Offset: 0x0001BF1C
	public void HHJDKMJCKDP(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.NDGNEHOHBJL())
		{
			return;
		}
		string text = ONEHEBIHPFB.NCAMNNEOGKG(JIKFCLOHJNN.MEOJKNLIFLJ());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(text);
		}
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x0001DD74 File Offset: 0x0001BF74
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 0f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 0f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x0001DDCC File Offset: 0x0001BFCC
	public void AKPOHMDKCHP(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.NDFEGNOFHNJ())
		{
			return;
		}
		string text = ONEHEBIHPFB.LMDACNKELEC(JIKFCLOHJNN.OJBEMAINAFK());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().HDAHPNAHNJC(text);
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0001DE24 File Offset: 0x0001C024
	private void EPHNKBBGCAK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 765f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 726f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x0001DE7C File Offset: 0x0001C07C
	public static float COFCOMILJCH()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.DCEHMKDEHIC(1397f);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00003E52 File Offset: 0x00002052
	private void OLDLKHFCIHC()
	{
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator FJMNMKPKKLM()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x0001DE98 File Offset: 0x0001C098
	public void BMGPNCBPPBI()
	{
		this.PANMNKKODPC.DOFade(764f, DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.BAPEJNBMNHC(1119f));
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
	private void BOILGHBPIIN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 819f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 256f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x0001DF20 File Offset: 0x0001C120
	public static float APJBOGHNDBH()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.MLEPAJKOKEK(1985f);
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x0001DF3C File Offset: 0x0001C13C
	public static float AKJGCPIMHBP()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.JAOJDFDDAEL(40f);
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0001DF58 File Offset: 0x0001C158
	public void MDMNEFIADAL()
	{
		this.PANMNKKODPC.DOFade(1122f, DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.MLEPAJKOKEK(1372f));
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator CADDJNOBFFA()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00003E52 File Offset: 0x00002052
	private void AJFAJLELLDG()
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0001DF88 File Offset: 0x0001C188
	private void OKBGBJDJMNI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1755f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 808f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator BMLAKELOEGO()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMGJEJODDDE()
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
	public void FOGKCCEHJOH()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.GDEOHPJOBFA());
		}
		this.PANMNKKODPC.DOFade(1427f, DialogTitleManager.animationAppearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.JAOJDFDDAEL(767f));
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0001E045 File Offset: 0x0001C245
	private bool BFALNCJHIEK()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnLobbyWheelDataCdnSuccess");
			return true;
		}
		return true;
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x0001E05C File Offset: 0x0001C25C
	public static float GetDisappearAnimationLength()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x0001E078 File Offset: 0x0001C278
	private void EHECBKECKPA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 393f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 6f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0001E0D0 File Offset: 0x0001C2D0
	private void JDMOENJPHOE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 605f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 370f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x0001E128 File Offset: 0x0001C328
	public void LMONIENLNEG()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.MOIJCIPEFBF());
		}
		this.PANMNKKODPC.DOFade(580f, DialogTitleManager.animationAppearFadeTime * AppManager.AGANFKKBPFO().debugSettings.BAPEJNBMNHC(355f));
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x0001E175 File Offset: 0x0001C375
	public static float MEAIAAPFEDF()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.CPJMIPIKKMM(466f);
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x0001E191 File Offset: 0x0001C391
	public void NHFKFBGGPFL()
	{
		this.PANMNKKODPC.DOFade(1113f, DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.JJKAIPFFCLP(29f));
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x0001E1BE File Offset: 0x0001C3BE
	public void IMDJBODLCFK()
	{
		this.PANMNKKODPC.DOFade(1695f, DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.BJOBEINNJBL(118f));
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00003E52 File Offset: 0x00002052
	private void ABOIKHJHJHH()
	{
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00003E52 File Offset: 0x00002052
	private void LDLLCBDGGHN()
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator KMKOOCMGDBD()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator JLDEJMKFKML()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0001E1EB File Offset: 0x0001C3EB
	private bool DPBMEFEINDD()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.");
			return true;
		}
		return false;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x0001E204 File Offset: 0x0001C404
	public void PFENNHGBJCN()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.KMKOOCMGDBD());
		}
		this.PANMNKKODPC.DOFade(650f, DialogTitleManager.animationAppearFadeTime * AppManager.AGANFKKBPFO().debugSettings.FJKMBEMJAEA(1036f));
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCJFJIBBDLL()
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00003E52 File Offset: 0x00002052
	private void KCIHDOMDINL()
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void JGDLPGEJGEM()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x0001E251 File Offset: 0x0001C451
	public void INMJNLFJCLK()
	{
		this.PANMNKKODPC.DOFade(1952f, DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.BIMIMMJLMAP(698f));
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x0001E280 File Offset: 0x0001C480
	private void PCMFCIDHKCL()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 238f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 497f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
	private void GBPFDKIIHJG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1961f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1484f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLGBJHCIIGA()
	{
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x0001E330 File Offset: 0x0001C530
	private bool NDFEGNOFHNJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("', skipped");
			return true;
		}
		return false;
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x0001E348 File Offset: 0x0001C548
	public void FFILFBPCENC(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.CAKAMPNELIM())
		{
			return;
		}
		string text = ONEHEBIHPFB.PLHGCKCFLEN(JIKFCLOHJNN.OJBEMAINAFK());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(text);
		}
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
	private void PABAKDIDDML()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 901f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 359f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
	public void Initialize(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.OONENNLLFHL())
		{
			return;
		}
		string text = ONEHEBIHPFB.LMDACNKELEC(JIKFCLOHJNN.DKEOPDAFLNO());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, true);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(text);
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00003E52 File Offset: 0x00002052
	private void FCOKGLDPJJO()
	{
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x0001D808 File Offset: 0x0001BA08
	private void INJJOHNFBKH()
	{
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator OEABCNLMKMA()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x0001E44E File Offset: 0x0001C64E
	public void LNGHHEJJCIE()
	{
		this.PANMNKKODPC.DOFade(1327f, DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.EOJCCBAICOJ(1199f));
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00003E52 File Offset: 0x00002052
	private void NIHOGKGKBGK()
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator MMMHMJMAJDC()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x0001E47B File Offset: 0x0001C67B
	public static float FCDKHDJEHLE()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.DCEHMKDEHIC(1329f);
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private IEnumerator PFGEKCANOFH()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x0001E497 File Offset: 0x0001C697
	public void NDFJFELBAPK()
	{
		this.PANMNKKODPC.DOFade(362f, DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.DCEHMKDEHIC(1968f));
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator JIOMGEBPGFF()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0001E4C4 File Offset: 0x0001C6C4
	public void IBMHJOGCNHO()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.ADAOCKEKDKE());
		}
		this.PANMNKKODPC.DOFade(1073f, DialogTitleManager.animationAppearFadeTime * AppManager.EHBBFMCILPC.debugSettings.JAOJDFDDAEL(47f));
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0001E511 File Offset: 0x0001C711
	public static float EEMFLPAPOEA()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.OAEBOACHHOG(719f);
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00003E52 File Offset: 0x00002052
	private void CMAMNPDKNKM()
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x0001E52D File Offset: 0x0001C72D
	public static float GLHGAADNIAN()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.MLEPAJKOKEK(138f);
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void IGNHKDONHED()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x0001E549 File Offset: 0x0001C749
	private bool ALMKCODPAMI()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("aind");
			return true;
		}
		return true;
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0001E560 File Offset: 0x0001C760
	public void DisappearAnimation()
	{
		this.PANMNKKODPC.DOFade(0f, DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00003E52 File Offset: 0x00002052
	private void OFCOFGABMKD()
	{
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00003E52 File Offset: 0x00002052
	private void LMPBLJPPCKO()
	{
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0001D808 File Offset: 0x0001BA08
	private void JNKPKECPLCB()
	{
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0001E58D File Offset: 0x0001C78D
	private bool IALHAPGEGIH()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Custom effects bundle loaded but its asset is missing or mis-named:");
			return false;
		}
		return false;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void HFHLNEGFLOH()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0001D939 File Offset: 0x0001BB39
	private IEnumerator MOIJCIPEFBF()
	{
		DialogTitleManager.GKGIHPCJJEE gkgihpcjjee = new DialogTitleManager.GKGIHPCJJEE(1);
		gkgihpcjjee.<>4__this = this;
		return gkgihpcjjee;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
	private void LJCOLPBKBBH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 292f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 232f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x0001E5FC File Offset: 0x0001C7FC
	public void DEKNOHNIIEE(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.NDFEGNOFHNJ())
		{
			return;
		}
		string text = ONEHEBIHPFB.FOMGCOENOKO(JIKFCLOHJNN.PFPDBBDHDDJ());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, true);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(text);
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0001E654 File Offset: 0x0001C854
	private void GACMCJDDJJD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1522f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1605f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0001E6AC File Offset: 0x0001C8AC
	public void ONCMEAFFFIB(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.IALHAPGEGIH())
		{
			return;
		}
		string text = ONEHEBIHPFB.FOMGCOENOKO(JIKFCLOHJNN.OLDJBICDOGM());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, true);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().NNNKIPGJMMF(text);
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0001E704 File Offset: 0x0001C904
	public void IJAMOCBLICC(PKJJCOLONGL JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.NDGNEHOHBJL())
		{
			return;
		}
		string text = ONEHEBIHPFB.LCKCKFDDDLC(JIKFCLOHJNN.FCOEJIJOPJF());
		text = DPGJIJGOCIC.AKIAKADKBFK(text);
		this.textBody.SetText(text, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(text);
		}
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x0001E75A File Offset: 0x0001C95A
	private bool GCDPFCHAKLJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("spr");
			return false;
		}
		return false;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00003E52 File Offset: 0x00002052
	private void CCNFPNFDNDP()
	{
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0001E771 File Offset: 0x0001C971
	public void CCPAHLBFMJD()
	{
		this.PANMNKKODPC.DOFade(1503f, DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.MLEPAJKOKEK(902f));
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00003E52 File Offset: 0x00002052
	private void FAOADCFJPEL()
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00003E52 File Offset: 0x00002052
	private void GNJIMBFLDKO()
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0001E79E File Offset: 0x0001C99E
	public void NABADENNICC()
	{
		this.PANMNKKODPC.DOFade(181f, DialogTitleManager.animationDisappearFadeTime * AppManager.AGANFKKBPFO().debugSettings.HAKILJMJCLA(993f));
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0001E7CB File Offset: 0x0001C9CB
	public void MNBGBKOJBLO()
	{
		this.PANMNKKODPC.DOFade(1850f, DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.BAPEJNBMNHC(1235f));
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
	private bool CJLNGLGENON()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("drft");
			return true;
		}
		return true;
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x0001E810 File Offset: 0x0001CA10
	public void AppearAnimation()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		this.PANMNKKODPC.DOFade(1f, DialogTitleManager.animationAppearFadeTime * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0001E85D File Offset: 0x0001CA5D
	public static float MPEGHGJJMNN()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.EHBBFMCILPC.debugSettings.JJKAIPFFCLP(1523f);
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x0001E879 File Offset: 0x0001CA79
	public static float IHBABLAHCBP()
	{
		return DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.CPJMIPIKKMM(180f);
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x0001D808 File Offset: 0x0001BA08
	private void GGOHALPJGNL()
	{
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0001E898 File Offset: 0x0001CA98
	public void OJHJKHAEMCP()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.MOIJCIPEFBF());
		}
		this.PANMNKKODPC.DOFade(855f, DialogTitleManager.animationAppearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.FJKMBEMJAEA(1441f));
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00003E52 File Offset: 0x00002052
	private void GIHIKHJGOHN()
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x0001E8E5 File Offset: 0x0001CAE5
	public void JBHCOBIBMFK()
	{
		this.PANMNKKODPC.DOFade(1893f, DialogTitleManager.animationDisappearFadeTime * AppManager.PCJEMMDDCIF().debugSettings.BJOBEINNJBL(1646f));
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
	private void GNILOOJAEJL()
	{
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnEnable()
	{
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMNOCDEFEJL()
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x0001E912 File Offset: 0x0001CB12
	public void BKMMDNDKAAC()
	{
		this.PANMNKKODPC.DOFade(378f, DialogTitleManager.animationDisappearFadeTime * AppManager.JMDJPKKOHNI().debugSettings.DCEHMKDEHIC(393f));
	}

	// Token: 0x04000114 RID: 276
	public static float animationAppearFadeTime = 1f;

	// Token: 0x04000115 RID: 277
	public static float animationDisappearFadeTime = 1f;

	// Token: 0x04000116 RID: 278
	public TextMeshProUGUI textBody;

	// Token: 0x04000117 RID: 279
	public TextMeshProUGUI textBodyTypeAnimation;

	// Token: 0x04000118 RID: 280
	public bool textTypeAnimation = true;

	// Token: 0x04000119 RID: 281
	private PKJJCOLONGL IMPAHLIGELE;

	// Token: 0x0400011A RID: 282
	private CanvasGroup PANMNKKODPC;
}
