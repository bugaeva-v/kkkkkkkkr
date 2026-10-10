using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001F9 RID: 505
public class StoryChatManager : MonoBehaviour
{
	// Token: 0x06003F1F RID: 16159 RVA: 0x001A87A2 File Offset: 0x001A69A2
	private void Start()
	{
		this.messagesScrollView.onValueChanged.AddListener(new UnityAction<Vector2>(this.CLBIPOBJKMJ));
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x001A87C0 File Offset: 0x001A69C0
	private void OODAOLBKEOH()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 0)
		{
			this.AKJMKGCPCCB--;
		}
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x001A87F1 File Offset: 0x001A69F1
	public float PushMessageChoice(LJFIKKKBMDG JIKFCLOHJNN, PFADAFAHNNJ PANKDLOEOHJ, int NBGCCMJAJKB)
	{
		return this.ONFFIJGMDMH(JIKFCLOHJNN.MLENDOEHFKA(PANKDLOEOHJ, NBGCCMJAJKB), PANKDLOEOHJ, true, false);
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x001A8804 File Offset: 0x001A6A04
	public static PAMDLEFCBDE BFNILDDMJEK(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("no"))
		{
			return (PAMDLEFCBDE)4;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("frsendhres"))
		{
			return (PAMDLEFCBDE)6;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnAvatarCollectionsGamePassSubscribePositive"))
		{
			return PAMDLEFCBDE.offscreen;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("avtssnap1"))
		{
			return PAMDLEFCBDE.offscreen;
		}
		return (PAMDLEFCBDE)4;
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x001A8864 File Offset: 0x001A6A64
	public void AppearAnimation0()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride);
		this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x001A88C0 File Offset: 0x001A6AC0
	private void ALKBENHJEPC()
	{
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "+" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		base.StartCoroutine(this.IDGADNIACLM());
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x001A8970 File Offset: 0x001A6B70
	public float PushMessage(LJFIKKKBMDG JIKFCLOHJNN, PFADAFAHNNJ PANKDLOEOHJ)
	{
		this.BKAPJIOECCK = this.ONFFIJGMDMH(JIKFCLOHJNN.FPGGOGKKNPK(PANKDLOEOHJ), PANKDLOEOHJ, true, true);
		return this.BKAPJIOECCK;
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x001A8990 File Offset: 0x001A6B90
	public static PAMDLEFCBDE StringToChatMessageInputSpeed(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("slow"))
		{
			return PAMDLEFCBDE.slow;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("normal"))
		{
			return PAMDLEFCBDE.normal;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("fast"))
		{
			return PAMDLEFCBDE.fast;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("offscreen"))
		{
			return PAMDLEFCBDE.offscreen;
		}
		return PAMDLEFCBDE.normal;
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x001A89F0 File Offset: 0x001A6BF0
	private void HBHDBDHBEPD()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(0);
			for (int i = 0; i < this.NDDGCFFDFJN.Count; i++)
			{
				this.NDDGCFFDFJN[i].GetComponent<ChoicePremiumManager>().HideTip();
			}
		}
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x001A8A41 File Offset: 0x001A6C41
	public void LHHJNHFKEAO(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		base.StartCoroutine(this.JDKJOMNFCON(JIKFCLOHJNN, BAOKJBJIFBH, OAGPAAMJOID));
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x001A8A54 File Offset: 0x001A6C54
	public void IDOPOMMGNJN()
	{
		this.PANMNKKODPC.DOFade(226f, 1021f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 1911f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(16f, 309f, 159f), 124f, (IMBLFHMKMAD)(-95));
		this.chatImageRectTransform.AHLJBONHHKL(-60, -16);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1876f, 1984f, 672f), 1624f, (IMBLFHMKMAD)4).x, 15f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(1766f, 1787f), 174f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x001A8B49 File Offset: 0x001A6D49
	private IEnumerator MHKFBCAFOAJ()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		int num;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.05f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.95f, 0.95f, 0.95f);
			component.DOScale(this.choicesScaleCoefficient, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x001A8B58 File Offset: 0x001A6D58
	private void HMAANNOPCDA()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 63;
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("", 863f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("", 1633f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("h" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 149f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("abs", 398f);
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x001A8C00 File Offset: 0x001A6E00
	private float BEHOCMNKFPH(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.BFMOAOBMBOA = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				this.BFMOAOBMBOA = true;
			}
			base.StartCoroutine(this.CEAHHDJFAPN(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.PAFOFNHKMDH(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.HIBNMBBAPHO(PANKDLOEOHJ.GINAOBOFOFC) / 1899f) * AppManager.JMDJPKKOHNI().debugSettings.DCEHMKDEHIC(292f) * this.ICCMDOHPDIL();
			}
			return 1617f;
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			base.StartCoroutine(this.IHGCNBGEKGA(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.LNAACMPDGEC(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.LBNIJEDGKPM(PANKDLOEOHJ.GINAOBOFOFC) / 1675f) * AppManager.JMDJPKKOHNI().debugSettings.MLEPAJKOKEK(1720f) * this.KMLIBPFHCFD();
			}
			return 1917f;
		}
		else
		{
			if (DKNNMLIDPHH.GLDFFFJIACO != 7)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("tbits" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
				return 195f;
			}
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return 491f * AppManager.PCJEMMDDCIF().debugSettings.DCEHMKDEHIC(1812f) * this.FBHBMAHJBAC();
			}
			return 1163f;
		}
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x001A8D4C File Offset: 0x001A6F4C
	private void CGPCLJHBMND()
	{
		AOBJLALDBAA.DBLAIDPICIG().ONIBLJOFFPG("sfxstatreceived", new UnityAction(this.MDGKJKBNDCO));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("pmtfailed", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x001A8D84 File Offset: 0x001A6F84
	private void BFLPEJILCCB()
	{
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 1)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "YourStory/FlagCloth" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		base.StartCoroutine(this.IDGADNIACLM());
	}

	// Token: 0x06003F2F RID: 16175 RVA: 0x001A8E34 File Offset: 0x001A7034
	private void OLGOAJEBMIK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06003F30 RID: 16176 RVA: 0x001A8EDC File Offset: 0x001A70DC
	private void CAKPAEBGEPN(Transform BFGBPKIGAJI, int ABECBDBCLJL)
	{
		if (null == BFGBPKIGAJI || ABECBDBCLJL <= 0)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		RectTransform cciagbpilgf = gameObject.AddComponent<RectTransform>();
		cciagbpilgf.ACBKFBBCNNC((float)ABECBDBCLJL);
		cciagbpilgf.EFOCKEJENAC((float)ABECBDBCLJL);
		gameObject.transform.SetParent(BFGBPKIGAJI, false);
		this.PDMKLEPMKLE.Add(gameObject);
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x001A8F2C File Offset: 0x001A712C
	private void BBKHGIBHCCB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -11;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("scki2", 290f);
		AudioManager.BFCHJBOOJKE().KillSfx("avind", 1803f);
		AudioManager.DBFLIEGGGNN().KillSfx("OnBackendGetPublicProfileHallOfFameSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1535f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("51B334", 440f);
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x001A8FD4 File Offset: 0x001A71D4
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPremiumChoiceSuccess", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003F33 RID: 16179 RVA: 0x001A900C File Offset: 0x001A720C
	private void DFCPGHJPBNA()
	{
		this.choicesPivot.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		for (int i = 1; i < this.AKFKCKHPIOA.Count; i += 0)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		this.LOJHEKCOFME = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.NGGBBCDPMJH = null;
		for (int j = 1; j < this.PDMKLEPMKLE.Count; j += 0)
		{
			if (null != this.PDMKLEPMKLE[j])
			{
				UnityEngine.Object.Destroy(this.PDMKLEPMKLE[j]);
			}
		}
		this.PDMKLEPMKLE.Clear();
		this.FLBNNNDBECB = -1;
		this.HNGBMIJHPLE = new List<int>();
		this.AKJMKGCPCCB = -1;
		this.CIPGFJLECDH = true;
	}

	// Token: 0x06003F34 RID: 16180 RVA: 0x001A914C File Offset: 0x001A734C
	public void DKOCPAEMIGP(List<string> OHHICBLFIDA, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (PANKDLOEOHJ == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("socialbadge");
			return;
		}
		this.BPNGIDAMBEJ = PANKDLOEOHJ.BPNGIDAMBEJ;
		if (this.BPNGIDAMBEJ && null != this.fadeObject)
		{
			this.fadeObject.SetActive(true);
		}
		if (null != this.titleText)
		{
			string text = PANKDLOEOHJ.AHDDFMHCDDJ();
			try
			{
				text = ONEHEBIHPFB.LCKCKFDDDLC(PANKDLOEOHJ.GJPPCPBIOOO());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.titleText.SetText(text, false);
			this.titleText.text = text;
		}
		for (int i = 1; i < OHHICBLFIDA.Count; i++)
		{
			GNKBFDPLGOE gnkbfdplgoe = new GNKBFDPLGOE();
			gnkbfdplgoe.DMBMAEENEDH(OHHICBLFIDA[i]);
			this.EAAABHEIFCG(gnkbfdplgoe, PANKDLOEOHJ, false, false);
		}
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x001A9220 File Offset: 0x001A7420
	private void FCCBGLDEHPP()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 79;
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("", 1993f);
		AudioManager.EHBBFMCILPC.KillSfx("prefixEnabled", 1598f);
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("socialprofilesuspcantuse" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 404f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("$ENVFADE", 733f);
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x001A92C8 File Offset: 0x001A74C8
	private int ICDKFHIDCCO(int MEFKFOHCOHK)
	{
		return MEFKFOHCOHK;
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x001A92CB File Offset: 0x001A74CB
	public bool BFCNIDBJBOO()
	{
		return this.GMEAMOEADME;
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x001A92D3 File Offset: 0x001A74D3
	private void HGCELCKMIOD()
	{
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("uid", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.CEGAOMEEFBE().KDIFKFKMCOH("fdmva", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x001A930B File Offset: 0x001A750B
	public float KEADMFFMAKP()
	{
		return this.BKAPJIOECCK;
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x001A9314 File Offset: 0x001A7514
	public void DisappearAnimation()
	{
		this.PANMNKKODPC.DOFade(0f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOScale(0.9f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride).x, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(50f, -25f), 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false);
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x001A93C8 File Offset: 0x001A75C8
	private IEnumerator OOKOMDIGCBE(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		while (this.IsInScrollState() || this.MCKPNELJNIC || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("dynamic"))
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
				{
					this.IMPAHLIGELE.JMNMOHIKHLB.AEMELJEDNJH(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
				}
			}
			else
			{
				try
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.bulk)
				{
					for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
					{
						this.HNGBMIJHPLE.Add(j);
					}
					break;
				}
			}
		}
		if (this.HNGBMIJHPLE.Count == 0)
		{
			for (int k = 0; k < 2; k++)
			{
				for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
				{
					int num = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
					{
						if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
						{
							num = 1;
						}
						else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 0)
						{
							num = 2;
						}
					}
					if ((k == 0 && num == 1) || (k != 0 && num != 1))
					{
						this.HNGBMIJHPLE.Add(l);
					}
				}
			}
		}
		try
		{
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					int num2 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 1;
						}
						else if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 2;
						}
					}
					if (num2 == 2)
					{
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								this.choicesPivot.SetActive(true);
								this.choicesPivot.transform.SetAsLastSibling();
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeStatInfo);
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.choicesPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].GALKFKBPLCK());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("hidestatinfo"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterStatInfo);
							}
							goto IL_648;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_648;
						}
					}
					if (num2 == 1 && null == this.LOJHEKCOFME && !SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						this.choicesPivot.SetActive(true);
						this.choicesPivot.transform.SetAsLastSibling();
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeGemsInfo);
						this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
						this.LOJHEKCOFME.transform.SetParent(this.choicesPivot.transform, false);
						this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterGemsInfo);
					}
				}
				IL_648:;
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		int ddmmddfiall = -1;
		if (KGLBKJKNPFD.ALLDBPCKMLF == 1)
		{
			ddmmddfiall = 520;
		}
		for (int n = 0; n < this.IMPAHLIGELE.COEFNFJMBDG.Count; n++)
		{
			if (!this.IMPAHLIGELE.COEFNFJMBDG[n].BEHENEHGPCP)
			{
				GameObject gameObject = null;
				int num3 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
				{
					if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 1;
					}
					else if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 2;
					}
				}
				if (num3 == 2)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)]].GALKFKBPLCK(), ddmmddfiall);
					gameObject.GetComponent<ChoiceStatManager>().ExtendRightSide();
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else if (num3 == 1)
				{
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], 0, ddmmddfiall, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], ddmmddfiall, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					this.NDDGCFFDFJN.Add(gameObject);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else
				{
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = n;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], ddmmddfiall);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				gameObject.GetComponent<RectTransform>();
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(n) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(n) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(n) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(n) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(n) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(n) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject);
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 0f;
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm5)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
		}
		if (null != this.LOJHEKCOFME)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnShowStoryHeaderInterfaceGamePassAndUndoButton", 0f);
		}
		yield break;
	}

	// Token: 0x06003F3C RID: 16188 RVA: 0x001A8A41 File Offset: 0x001A6C41
	public void PushChoices(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		base.StartCoroutine(this.JDKJOMNFCON(JIKFCLOHJNN, BAOKJBJIFBH, OAGPAAMJOID));
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x001A93EC File Offset: 0x001A75EC
	private void IDPCGCONADK(Vector2 KFKFGEOCEIB)
	{
		float y = this.messagesContainer.GetComponent<RectTransform>().anchoredPosition.y;
		if (y < 433f || y > 763f)
		{
			this.GMEAMOEADME = false;
			if (!this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(true);
			}
			if (null != this.JEPKCMADMIN && this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(true);
				return;
			}
		}
		else
		{
			this.GMEAMOEADME = true;
			if (this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && !this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
			}
		}
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x001A94C2 File Offset: 0x001A76C2
	private IEnumerator INOPBGHHEIH()
	{
		StoryChatManager.OIOHPMOHAGP oiohpmohagp = new StoryChatManager.OIOHPMOHAGP(1);
		oiohpmohagp.<>4__this = this;
		return oiohpmohagp;
	}

	// Token: 0x06003F3F RID: 16191 RVA: 0x001A94D4 File Offset: 0x001A76D4
	private void LAFMEAPKJKE(Transform BFGBPKIGAJI, int ABECBDBCLJL)
	{
		if (null == BFGBPKIGAJI || ABECBDBCLJL <= 1)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		RectTransform cciagbpilgf = gameObject.AddComponent<RectTransform>();
		cciagbpilgf.ACBKFBBCNNC((float)ABECBDBCLJL);
		cciagbpilgf.EFOCKEJENAC((float)ABECBDBCLJL);
		gameObject.transform.SetParent(BFGBPKIGAJI, true);
		this.PDMKLEPMKLE.Add(gameObject);
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x001A9524 File Offset: 0x001A7724
	private float DOHAALLBFJN(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.BFMOAOBMBOA = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				this.BFMOAOBMBOA = true;
			}
			base.StartCoroutine(this.IHGCNBGEKGA(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.FFKDJEIMDEL(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.LCNEOCMNAFI(PANKDLOEOHJ.GINAOBOFOFC) / 1101f) * AppManager.EHBBFMCILPC.debugSettings.HAKILJMJCLA(878f) * this.HJHMFFEJKIO();
			}
			return 1720f;
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.BFIDJEHCPDO(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.FKJHMDHDIGI(PANKDLOEOHJ.GINAOBOFOFC) / 1292f) * AppManager.EHBBFMCILPC.debugSettings.HAPIGPHMNHJ(1401f) * this.FBHBMAHJBAC();
			}
			return 384f;
		}
		else
		{
			if (DKNNMLIDPHH.GLDFFFJIACO != 3)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
				return 910f;
			}
			base.StartCoroutine(this.CEAHHDJFAPN(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return 238f * AppManager.JMDJPKKOHNI().debugSettings.HAKILJMJCLA(1163f) * this.HJHMFFEJKIO();
			}
			return 439f;
		}
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x001A9670 File Offset: 0x001A7870
	private void EMGLPBHECDO()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(0);
			for (int i = 1; i < this.NDDGCFFDFJN.Count; i += 0)
			{
				this.NDDGCFFDFJN[i].GetComponent<ChoicePremiumManager>().HideTip();
			}
		}
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x001A96C1 File Offset: 0x001A78C1
	public void CNCIAABFBOK()
	{
		this.BFMOAOBMBOA = true;
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x001A96CA File Offset: 0x001A78CA
	public bool ONJKLOMNLEP()
	{
		return this.MCKPNELJNIC && !this.BFMOAOBMBOA;
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x001A96DF File Offset: 0x001A78DF
	private IEnumerator HAHHLNKKKOO(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.MCKPNELJNIC = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (DKNNMLIDPHH.IPKLCGDNCEC)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			else if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
				this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
				this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
				while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
				yield return new WaitForSeconds(0.1f);
				this.JEPKCMADMIN = null;
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
			}
			else if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj in this.typeAnimationPivotPlayer.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				GameObject typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotPlayer.SetActive(true);
				this.typeAnimationPivotPlayer.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotPlayer.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(-1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotPlayer.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.playerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject);
			gameObject.transform.SetParent(this.messagesContainer.transform, false);
			gameObject.GetComponent<StoryChatPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj2 in this.typeAnimationPivotNpc.transform)
				{
					((Transform)obj2).gameObject.SetActive(false);
				}
				GameObject typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotNpc.SetActive(true);
				this.typeAnimationPivotNpc.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotNpc.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotNpc.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.nonPlayerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject2);
			gameObject2.transform.SetParent(this.messagesContainer.transform, false);
			gameObject2.GetComponent<StoryChatNonPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 2)
		{
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			if (PDOKEHMIIKF)
			{
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.systemMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject3);
			gameObject3.transform.SetParent(this.messagesContainer.transform, false);
			gameObject3.GetComponent<StoryChatSystemMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.ShowMessageCoroutine(), unsupported message type:" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
		}
		this.MCKPNELJNIC = false;
		yield break;
	}

	// Token: 0x06003F45 RID: 16197 RVA: 0x001A970B File Offset: 0x001A790B
	private float FBHBMAHJBAC()
	{
		if (this.BPNGIDAMBEJ)
		{
			return 0.1f;
		}
		return 1f;
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x001A9720 File Offset: 0x001A7920
	private void HLFCDCMJHIA()
	{
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "frsendhres" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		base.StartCoroutine(this.PDBBKBKDFFP());
	}

	// Token: 0x06003F47 RID: 16199 RVA: 0x001A97D0 File Offset: 0x001A79D0
	private void OPMBEDEIOCD(Transform BFGBPKIGAJI, int ABECBDBCLJL)
	{
		if (null == BFGBPKIGAJI || ABECBDBCLJL <= 0)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		RectTransform cciagbpilgf = gameObject.AddComponent<RectTransform>();
		cciagbpilgf.ACBKFBBCNNC((float)ABECBDBCLJL);
		cciagbpilgf.EFOCKEJENAC((float)ABECBDBCLJL);
		gameObject.transform.SetParent(BFGBPKIGAJI, false);
		this.PDMKLEPMKLE.Add(gameObject);
	}

	// Token: 0x06003F48 RID: 16200 RVA: 0x001A981F File Offset: 0x001A7A1F
	public void PNJPFAEKJFE()
	{
		this.BFMOAOBMBOA = false;
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x001A9828 File Offset: 0x001A7A28
	private void EIMLAEEOBPD()
	{
		this.messagesScrollView.onValueChanged.AddListener(new UnityAction<Vector2>(this.PJBIEICDNGG));
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x001A9848 File Offset: 0x001A7A48
	private void MNKPOPFBOOG(Vector2 KFKFGEOCEIB)
	{
		float y = this.messagesContainer.GetComponent<RectTransform>().anchoredPosition.y;
		if (y < 1905f || y > 725f)
		{
			this.GMEAMOEADME = true;
			if (!this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
				return;
			}
		}
		else
		{
			this.GMEAMOEADME = true;
			if (this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(true);
			}
			if (null != this.JEPKCMADMIN && !this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
			}
		}
	}

	// Token: 0x06003F4B RID: 16203 RVA: 0x001A96C1 File Offset: 0x001A78C1
	public void MBEIJENLNGK()
	{
		this.BFMOAOBMBOA = true;
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x001A991E File Offset: 0x001A7B1E
	public bool CIADCEOIFHI()
	{
		return !this.MCKPNELJNIC || this.BFMOAOBMBOA;
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x001A981F File Offset: 0x001A7A1F
	public void UserInputProcessed()
	{
		this.BFMOAOBMBOA = false;
	}

	// Token: 0x06003F4E RID: 16206 RVA: 0x001A9933 File Offset: 0x001A7B33
	private void BCBPODBLKEM()
	{
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("comsc2", new UnityAction(this.MDGKJKBNDCO));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("OnStoryInterfaceHeaderAvatarClick", new UnityAction(this.EMGLPBHECDO));
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x001A94C2 File Offset: 0x001A76C2
	private IEnumerator BLBHMHMHAJG()
	{
		StoryChatManager.OIOHPMOHAGP oiohpmohagp = new StoryChatManager.OIOHPMOHAGP(1);
		oiohpmohagp.<>4__this = this;
		return oiohpmohagp;
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x001A996C File Offset: 0x001A7B6C
	private float BPGDKKBEMPI(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.BFMOAOBMBOA = false;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				this.BFMOAOBMBOA = true;
			}
			base.StartCoroutine(this.MIBJPNHADEH(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.CAPHHJHOKIG(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.EADLOFBCKEM(PANKDLOEOHJ.GINAOBOFOFC) / 1184f) * AppManager.AGANFKKBPFO().debugSettings.DCEHMKDEHIC(346f) * this.HJHMFFEJKIO();
			}
			return 532f;
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			base.StartCoroutine(this.IHGCNBGEKGA(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.EADLOFBCKEM(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.PHAFBCJFOKL(PANKDLOEOHJ.GINAOBOFOFC) / 985f) * AppManager.JMDJPKKOHNI().debugSettings.BAPEJNBMNHC(1444f) * this.KMLIBPFHCFD();
			}
			return 914f;
		}
		else
		{
			if (DKNNMLIDPHH.GLDFFFJIACO != 0)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("energyhinttitle" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
				return 1300f;
			}
			base.StartCoroutine(this.IHGCNBGEKGA(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return 765f * AppManager.AGANFKKBPFO().debugSettings.BIMIMMJLMAP(1800f) * this.ICCMDOHPDIL();
			}
			return 714f;
		}
	}

	// Token: 0x06003F51 RID: 16209 RVA: 0x001A9AB8 File Offset: 0x001A7CB8
	private void DPIELDMNFIN()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -74;
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("signinlinkuserpass", 507f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("continue", 1712f);
		AudioManager.EHBBFMCILPC.KillSfx("fpi" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1208f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("-", 783f);
	}

	// Token: 0x06003F52 RID: 16210 RVA: 0x001A9B60 File Offset: 0x001A7D60
	private void OKBABBBHMIP()
	{
		this.messagesScrollView.onValueChanged.AddListener(new UnityAction<Vector2>(this.IDPCGCONADK));
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x001A9B80 File Offset: 0x001A7D80
	private void BDJDDMJGFAK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -125;
		AudioManager.DBFLIEGGGNN().KillSfx("profilenametitleshort", 1503f);
		AudioManager.BFCHJBOOJKE().KillSfx("errortitle", 200f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("OnPurchasingViewLeave" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 375f);
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI(" ", 1856f);
	}

	// Token: 0x06003F54 RID: 16212 RVA: 0x001A9C28 File Offset: 0x001A7E28
	private void FLFKJOACLBH(Transform BFGBPKIGAJI, int ABECBDBCLJL)
	{
		if (null == BFGBPKIGAJI || ABECBDBCLJL <= 1)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		RectTransform cciagbpilgf = gameObject.AddComponent<RectTransform>();
		cciagbpilgf.ACBKFBBCNNC((float)ABECBDBCLJL);
		cciagbpilgf.EFOCKEJENAC((float)ABECBDBCLJL);
		gameObject.transform.SetParent(BFGBPKIGAJI, true);
		this.PDMKLEPMKLE.Add(gameObject);
	}

	// Token: 0x06003F55 RID: 16213 RVA: 0x001A9C77 File Offset: 0x001A7E77
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 0f;
	}

	// Token: 0x06003F56 RID: 16214 RVA: 0x001A9C9C File Offset: 0x001A7E9C
	private void GMPJMMMIGLO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06003F57 RID: 16215 RVA: 0x001A92C8 File Offset: 0x001A74C8
	private int DDGLJHFNBGK(int MEFKFOHCOHK)
	{
		return MEFKFOHCOHK;
	}

	// Token: 0x06003F58 RID: 16216 RVA: 0x001A9D44 File Offset: 0x001A7F44
	private void HANKDAKNKFA(Transform BFGBPKIGAJI, int ABECBDBCLJL)
	{
		if (null == BFGBPKIGAJI || ABECBDBCLJL <= 1)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		RectTransform cciagbpilgf = gameObject.AddComponent<RectTransform>();
		cciagbpilgf.ACBKFBBCNNC((float)ABECBDBCLJL);
		cciagbpilgf.EFOCKEJENAC((float)ABECBDBCLJL);
		gameObject.transform.SetParent(BFGBPKIGAJI, false);
		this.PDMKLEPMKLE.Add(gameObject);
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x001A9D94 File Offset: 0x001A7F94
	private void OAPJPEMEMJH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 79;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("frcgft", 453f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("hacomp2", 442f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("spinWheel" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 97f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG(" <i>", 1325f);
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x001A92CB File Offset: 0x001A74CB
	public bool IsInScrollState()
	{
		return this.GMEAMOEADME;
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x001A9E3C File Offset: 0x001A803C
	public void KPPCHKABMOM()
	{
		this.PANMNKKODPC.DOFade(1351f, 998f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOScale(1558f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1204f, 904f, 362f), 1009f, (IMBLFHMKMAD)(-73)).x, 515f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(1041f, 1523f), 1943f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x001A9EF0 File Offset: 0x001A80F0
	private void AANCENPHIIK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 60;
		AudioManager.DBFLIEGGGNN().KillSfx("Speed", 965f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("", 1775f);
		AudioManager.IFDLAMLHKIJ().KillSfx("envs" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 718f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("OnGenericPopupManagerHide", 509f);
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x001A981F File Offset: 0x001A7A1F
	public void DPHHEDABGJO()
	{
		this.BFMOAOBMBOA = false;
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x001A92C8 File Offset: 0x001A74C8
	private int IOBMGFGMMKN(int MEFKFOHCOHK)
	{
		return MEFKFOHCOHK;
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x001A92CB File Offset: 0x001A74CB
	public bool BPBDNIBPLCD()
	{
		return this.GMEAMOEADME;
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x001A9F98 File Offset: 0x001A8198
	private IEnumerator IDGADNIACLM()
	{
		int num;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.05f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(0f, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			this.AKFKCKHPIOA[i].GetComponent<RectTransform>().DOScale(new Vector3(0.95f, 0.95f, 0.95f), 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield return new WaitForSeconds(0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.NOKDDOJJDCE();
		yield break;
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x001A9FA8 File Offset: 0x001A81A8
	private void IIDBNOPMHHH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 63;
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("invalid registry entry", 974f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("uid not confirmed", 479f);
		AudioManager.EHBBFMCILPC.KillSfx("" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 25f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("pmterror001", 2f);
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x001AA050 File Offset: 0x001A8250
	private void MPPMCMJMMMH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -124;
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("'{0}' shader not supported.", 893f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("OnChoiceExtendedViewedChoiceChanged", 338f);
		AudioManager.BFCHJBOOJKE().KillSfx("OnPopupCardOptionsNextClick" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1776f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("", 1776f);
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x001AA0F8 File Offset: 0x001A82F8
	private void LEKOKAOMCMF()
	{
		this.choicesPivot.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		this.LOJHEKCOFME = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.NGGBBCDPMJH = null;
		for (int j = 0; j < this.PDMKLEPMKLE.Count; j++)
		{
			if (null != this.PDMKLEPMKLE[j])
			{
				UnityEngine.Object.Destroy(this.PDMKLEPMKLE[j]);
			}
		}
		this.PDMKLEPMKLE.Clear();
		this.FLBNNNDBECB = -1;
		this.HNGBMIJHPLE = new List<int>();
		this.AKJMKGCPCCB = -1;
		this.CIPGFJLECDH = false;
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x001AA238 File Offset: 0x001A8438
	public void LKKADCAIFLI()
	{
		this.PANMNKKODPC.DOFade(388f, 606f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 433f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1939f, 239f, 67f), 234f, (IMBLFHMKMAD)156);
		this.chatImageRectTransform.AHLJBONHHKL(82, -124);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1971f, 1489f, 113f), 796f, (IMBLFHMKMAD)114).x, 1822f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(14f, 731f), 589f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false);
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x001AA330 File Offset: 0x001A8530
	public void KKDJFPPCIIL()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(536f, 497f, 717f), 740f, (IMBLFHMKMAD)(-162));
		this.PANMNKKODPC.DOFade(368f, 619f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x001AA38C File Offset: 0x001A858C
	public static PAMDLEFCBDE BJAFDKKCHOP(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("Asset bundle assets destroyed:"))
		{
			return PAMDLEFCBDE.offscreen;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("backend.json"))
		{
			return PAMDLEFCBDE.fast;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return PAMDLEFCBDE.fast;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology save not available"))
		{
			return PAMDLEFCBDE.fast;
		}
		return (PAMDLEFCBDE)5;
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x001A92C8 File Offset: 0x001A74C8
	private int HDBBHHBOJIN(int MEFKFOHCOHK)
	{
		return MEFKFOHCOHK;
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x001AA3EA File Offset: 0x001A85EA
	public void EEMHCMNLIEL()
	{
		this.BFMOAOBMBOA = false;
		base.StartCoroutine(this.HOKNOPINPFF());
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x001A92CB File Offset: 0x001A74CB
	public bool IPDBNMMLAEM()
	{
		return this.GMEAMOEADME;
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x001A96DF File Offset: 0x001A78DF
	private IEnumerator IHGCNBGEKGA(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.MCKPNELJNIC = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (DKNNMLIDPHH.IPKLCGDNCEC)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			else if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
				this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
				this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
				while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
				yield return new WaitForSeconds(0.1f);
				this.JEPKCMADMIN = null;
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
			}
			else if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj in this.typeAnimationPivotPlayer.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotPlayer.SetActive(true);
				this.typeAnimationPivotPlayer.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotPlayer.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(-1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotPlayer.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.playerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject);
			gameObject.transform.SetParent(this.messagesContainer.transform, false);
			gameObject.GetComponent<StoryChatPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj2 in this.typeAnimationPivotNpc.transform)
				{
					((Transform)obj2).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotNpc.SetActive(true);
				this.typeAnimationPivotNpc.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotNpc.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotNpc.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.nonPlayerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject2);
			gameObject2.transform.SetParent(this.messagesContainer.transform, false);
			gameObject2.GetComponent<StoryChatNonPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 2)
		{
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			if (PDOKEHMIIKF)
			{
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.systemMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject3);
			gameObject3.transform.SetParent(this.messagesContainer.transform, false);
			gameObject3.GetComponent<StoryChatSystemMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.ShowMessageCoroutine(), unsupported message type:" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
		}
		this.MCKPNELJNIC = false;
		yield break;
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x001AA400 File Offset: 0x001A8600
	private float KMLIBPFHCFD()
	{
		if (this.BPNGIDAMBEJ)
		{
			return 816f;
		}
		return 1597f;
	}

	// Token: 0x06003F6C RID: 16236 RVA: 0x001AA418 File Offset: 0x001A8618
	private void MCHODPOHNOH()
	{
		this.choicesPivot.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		for (int i = 1; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		this.LOJHEKCOFME = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.NGGBBCDPMJH = null;
		for (int j = 0; j < this.PDMKLEPMKLE.Count; j += 0)
		{
			if (null != this.PDMKLEPMKLE[j])
			{
				UnityEngine.Object.Destroy(this.PDMKLEPMKLE[j]);
			}
		}
		this.PDMKLEPMKLE.Clear();
		this.FLBNNNDBECB = -1;
		this.HNGBMIJHPLE = new List<int>();
		this.AKJMKGCPCCB = -1;
		this.CIPGFJLECDH = true;
	}

	// Token: 0x06003F6D RID: 16237 RVA: 0x001AA558 File Offset: 0x001A8758
	private void JKCINPGPDCB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -51;
		AudioManager.EHBBFMCILPC.KillSfx("$NPCPROPDISABLE", 882f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK(" ", 628f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("aspks" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 810f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("", 597f);
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x001A93C8 File Offset: 0x001A75C8
	private IEnumerator HFIHGBDOFAI(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		while (this.IsInScrollState() || this.MCKPNELJNIC || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("dynamic"))
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
				{
					this.IMPAHLIGELE.JMNMOHIKHLB.AEMELJEDNJH(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
				}
			}
			else
			{
				try
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.bulk)
				{
					for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
					{
						this.HNGBMIJHPLE.Add(j);
					}
					break;
				}
			}
		}
		if (this.HNGBMIJHPLE.Count == 0)
		{
			for (int k = 0; k < 2; k++)
			{
				for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
				{
					int num = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
					{
						if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
						{
							num = 1;
						}
						else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 0)
						{
							num = 2;
						}
					}
					if ((k == 0 && num == 1) || (k != 0 && num != 1))
					{
						this.HNGBMIJHPLE.Add(l);
					}
				}
			}
		}
		try
		{
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					int num2 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 1;
						}
						else if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 2;
						}
					}
					if (num2 == 2)
					{
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								this.choicesPivot.SetActive(true);
								this.choicesPivot.transform.SetAsLastSibling();
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeStatInfo);
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.choicesPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].GALKFKBPLCK());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("hidestatinfo"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterStatInfo);
							}
							goto IL_648;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_648;
						}
					}
					if (num2 == 1 && null == this.LOJHEKCOFME && !SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						this.choicesPivot.SetActive(true);
						this.choicesPivot.transform.SetAsLastSibling();
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeGemsInfo);
						this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
						this.LOJHEKCOFME.transform.SetParent(this.choicesPivot.transform, false);
						this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterGemsInfo);
					}
				}
				IL_648:;
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		int ddmmddfiall = -1;
		if (KGLBKJKNPFD.ALLDBPCKMLF == 1)
		{
			ddmmddfiall = 520;
		}
		for (int n = 0; n < this.IMPAHLIGELE.COEFNFJMBDG.Count; n++)
		{
			if (!this.IMPAHLIGELE.COEFNFJMBDG[n].BEHENEHGPCP)
			{
				GameObject gameObject = null;
				int num3 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
				{
					if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 1;
					}
					else if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 2;
					}
				}
				if (num3 == 2)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)]].GALKFKBPLCK(), ddmmddfiall);
					gameObject.GetComponent<ChoiceStatManager>().ExtendRightSide();
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else if (num3 == 1)
				{
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], 0, ddmmddfiall, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], ddmmddfiall, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					this.NDDGCFFDFJN.Add(gameObject);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else
				{
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = n;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], ddmmddfiall);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				gameObject.GetComponent<RectTransform>();
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(n) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(n) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(n) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(n) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(n) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(n) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject);
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 0f;
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm5)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
		}
		if (null != this.LOJHEKCOFME)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnShowStoryHeaderInterfaceGamePassAndUndoButton", 0f);
		}
		yield break;
	}

	// Token: 0x06003F6F RID: 16239 RVA: 0x001A96DF File Offset: 0x001A78DF
	private IEnumerator CALJGGNMOJD(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.MCKPNELJNIC = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (DKNNMLIDPHH.IPKLCGDNCEC)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			else if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
				this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
				this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
				while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
				yield return new WaitForSeconds(0.1f);
				this.JEPKCMADMIN = null;
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
			}
			else if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj in this.typeAnimationPivotPlayer.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotPlayer.SetActive(true);
				this.typeAnimationPivotPlayer.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotPlayer.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(-1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotPlayer.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.playerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject);
			gameObject.transform.SetParent(this.messagesContainer.transform, false);
			gameObject.GetComponent<StoryChatPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj2 in this.typeAnimationPivotNpc.transform)
				{
					((Transform)obj2).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotNpc.SetActive(true);
				this.typeAnimationPivotNpc.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotNpc.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotNpc.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.nonPlayerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject2);
			gameObject2.transform.SetParent(this.messagesContainer.transform, false);
			gameObject2.GetComponent<StoryChatNonPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 2)
		{
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			if (PDOKEHMIIKF)
			{
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.systemMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject3);
			gameObject3.transform.SetParent(this.messagesContainer.transform, false);
			gameObject3.GetComponent<StoryChatSystemMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.ShowMessageCoroutine(), unsupported message type:" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
		}
		this.MCKPNELJNIC = false;
		yield break;
	}

	// Token: 0x06003F70 RID: 16240 RVA: 0x001A930B File Offset: 0x001A750B
	public float GetLastPostMessageWaitTime()
	{
		return this.BKAPJIOECCK;
	}

	// Token: 0x06003F71 RID: 16241 RVA: 0x001A87C0 File Offset: 0x001A69C0
	private void Update()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 0)
		{
			this.AKJMKGCPCCB--;
		}
	}

	// Token: 0x06003F72 RID: 16242 RVA: 0x001AA600 File Offset: 0x001A8800
	public void PushMessageWaitForInput()
	{
		this.BFMOAOBMBOA = true;
		base.StartCoroutine(this.EPKCJEABBLC());
	}

	// Token: 0x06003F73 RID: 16243 RVA: 0x001AA616 File Offset: 0x001A8816
	private IEnumerator HOKNOPINPFF()
	{
		StoryChatManager.EHONMNJBEAA ehonmnjbeaa = new StoryChatManager.EHONMNJBEAA(1);
		ehonmnjbeaa.<>4__this = this;
		return ehonmnjbeaa;
	}

	// Token: 0x06003F74 RID: 16244 RVA: 0x001AA628 File Offset: 0x001A8828
	private void LAIEDFNEHLM()
	{
		this.choicesPivot.SetActive(true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		this.LOJHEKCOFME = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.NGGBBCDPMJH = null;
		for (int j = 1; j < this.PDMKLEPMKLE.Count; j += 0)
		{
			if (null != this.PDMKLEPMKLE[j])
			{
				UnityEngine.Object.Destroy(this.PDMKLEPMKLE[j]);
			}
		}
		this.PDMKLEPMKLE.Clear();
		this.FLBNNNDBECB = -1;
		this.HNGBMIJHPLE = new List<int>();
		this.AKJMKGCPCCB = -1;
		this.CIPGFJLECDH = true;
	}

	// Token: 0x06003F75 RID: 16245 RVA: 0x001AA768 File Offset: 0x001A8968
	private void GFHOEOBIDKD()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -22;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("OnApplicationFocusNeedToUpdateCurrency", 1519f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("hd", 93f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("frpid" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1385f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("): ", 59f);
	}

	// Token: 0x06003F76 RID: 16246 RVA: 0x001AA810 File Offset: 0x001A8A10
	private void OCCNPFLLOOB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -17;
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("smps", 611f);
		AudioManager.BFCHJBOOJKE().KillSfx(" padded=", 1583f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("loungepurchasetitle" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 555f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("tmo", 925f);
	}

	// Token: 0x06003F77 RID: 16247 RVA: 0x001AA8B8 File Offset: 0x001A8AB8
	private void HMHIJLKJGFN()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06003F78 RID: 16248 RVA: 0x001AA616 File Offset: 0x001A8816
	private IEnumerator FLCCFLHAJPJ()
	{
		StoryChatManager.EHONMNJBEAA ehonmnjbeaa = new StoryChatManager.EHONMNJBEAA(1);
		ehonmnjbeaa.<>4__this = this;
		return ehonmnjbeaa;
	}

	// Token: 0x06003F79 RID: 16249 RVA: 0x001AA960 File Offset: 0x001A8B60
	private void INFNNPJOONF(Vector2 KFKFGEOCEIB)
	{
		float y = this.messagesContainer.GetComponent<RectTransform>().anchoredPosition.y;
		if (y < 1269f || y > 446f)
		{
			this.GMEAMOEADME = true;
			if (!this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
				return;
			}
		}
		else
		{
			this.GMEAMOEADME = false;
			if (this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(true);
			}
			if (null != this.JEPKCMADMIN && !this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(true);
			}
		}
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x001AAA36 File Offset: 0x001A8C36
	public float OBIEDHBGAFP(LJFIKKKBMDG JIKFCLOHJNN, PFADAFAHNNJ PANKDLOEOHJ)
	{
		this.BKAPJIOECCK = this.ONFFIJGMDMH(JIKFCLOHJNN.LPIHPBMHECF(PANKDLOEOHJ), PANKDLOEOHJ, true, false);
		return this.BKAPJIOECCK;
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x001AAA54 File Offset: 0x001A8C54
	private void LBPCHKHFKIK()
	{
		this.JEPKCMADMIN = null;
		this.HHJOPCHBDOK();
		for (int i = 0; i < this.LHNFPOJPFIJ.Count; i++)
		{
			this.LHNFPOJPFIJ[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.LHNFPOJPFIJ[i]);
		}
		this.LHNFPOJPFIJ.Clear();
		this.PANMNKKODPC.DOKill(true);
		this.chatImageRectTransform.DOKill(true);
		this.messagesScrollView.onValueChanged.RemoveListener(new UnityAction<Vector2>(this.PJBIEICDNGG));
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x001AAAEE File Offset: 0x001A8CEE
	public float FKBMAKMDMIH(LJFIKKKBMDG JIKFCLOHJNN, PFADAFAHNNJ PANKDLOEOHJ, int NBGCCMJAJKB)
	{
		return this.FDILAOOCCHA(JIKFCLOHJNN.PFHAEDNONBO(PANKDLOEOHJ, NBGCCMJAJKB), PANKDLOEOHJ, true, true);
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x001AAB04 File Offset: 0x001A8D04
	private void BOGHFJKGCNK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x001AABAC File Offset: 0x001A8DAC
	private void PJBIEICDNGG(Vector2 KFKFGEOCEIB)
	{
		float y = this.messagesContainer.GetComponent<RectTransform>().anchoredPosition.y;
		if (y < 1911f || y > 686f)
		{
			this.GMEAMOEADME = true;
			if (!this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(true);
				return;
			}
		}
		else
		{
			this.GMEAMOEADME = false;
			if (this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && !this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
			}
		}
	}

	// Token: 0x06003F7F RID: 16255 RVA: 0x001AAC84 File Offset: 0x001A8E84
	private void JNOBNDBJHJI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 40;
		AudioManager.DBFLIEGGGNN().KillSfx("", 1083f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("h", 490f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("acfe" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 865f);
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI(".", 1704f);
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x001A8B49 File Offset: 0x001A6D49
	private IEnumerator DKNMJPDCBKD()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.05f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.95f, 0.95f, 0.95f);
			component.DOScale(this.choicesScaleCoefficient, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x001A96DF File Offset: 0x001A78DF
	private IEnumerator MIBJPNHADEH(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.MCKPNELJNIC = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (DKNNMLIDPHH.IPKLCGDNCEC)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			else if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
				this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
				this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
				while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
				yield return new WaitForSeconds(0.1f);
				this.JEPKCMADMIN = null;
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
			}
			else if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj in this.typeAnimationPivotPlayer.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotPlayer.SetActive(true);
				this.typeAnimationPivotPlayer.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotPlayer.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(-1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotPlayer.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.playerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject);
			gameObject.transform.SetParent(this.messagesContainer.transform, false);
			gameObject.GetComponent<StoryChatPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj2 in this.typeAnimationPivotNpc.transform)
				{
					((Transform)obj2).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotNpc.SetActive(true);
				this.typeAnimationPivotNpc.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotNpc.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotNpc.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.nonPlayerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject2);
			gameObject2.transform.SetParent(this.messagesContainer.transform, false);
			gameObject2.GetComponent<StoryChatNonPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 2)
		{
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			if (PDOKEHMIIKF)
			{
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.systemMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject3);
			gameObject3.transform.SetParent(this.messagesContainer.transform, false);
			gameObject3.GetComponent<StoryChatSystemMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.ShowMessageCoroutine(), unsupported message type:" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
		}
		this.MCKPNELJNIC = false;
		yield break;
	}

	// Token: 0x06003F82 RID: 16258 RVA: 0x001AAD2C File Offset: 0x001A8F2C
	public void Initialize(List<string> OHHICBLFIDA, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (PANKDLOEOHJ == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.Initialize(), _chatMeta is null");
			return;
		}
		this.BPNGIDAMBEJ = PANKDLOEOHJ.BPNGIDAMBEJ;
		if (this.BPNGIDAMBEJ && null != this.fadeObject)
		{
			this.fadeObject.SetActive(false);
		}
		if (null != this.titleText)
		{
			string text = PANKDLOEOHJ.PFLJLFGCIFB();
			try
			{
				text = ONEHEBIHPFB.LMDACNKELEC(PANKDLOEOHJ.PFLJLFGCIFB());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.titleText.SetText(text, true);
			this.titleText.text = text;
		}
		for (int i = 0; i < OHHICBLFIDA.Count; i++)
		{
			GNKBFDPLGOE gnkbfdplgoe = new GNKBFDPLGOE();
			gnkbfdplgoe.JDJJGCHPGKF(OHHICBLFIDA[i]);
			this.ONFFIJGMDMH(gnkbfdplgoe, PANKDLOEOHJ, false, false);
		}
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x001AAE00 File Offset: 0x001A9000
	private void AKOEOJDGKFI()
	{
		this.messagesScrollView.scrollSensitivity = 814f;
		AOBJLALDBAA.CEGAOMEEFBE().FNMOFCMDFJP("OnPopupStoryRestartManagerRestartStory2", new UnityAction(this.BFLPEJILCCB));
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("</i>", new UnityAction(this.EMGLPBHECDO));
	}

	// Token: 0x06003F84 RID: 16260 RVA: 0x001A92CB File Offset: 0x001A74CB
	public bool JDPPGKEPENI()
	{
		return this.GMEAMOEADME;
	}

	// Token: 0x06003F85 RID: 16261 RVA: 0x001AAE54 File Offset: 0x001A9054
	private void NBIMDEPPBON()
	{
		this.messagesScrollView.scrollSensitivity = 1784f;
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ("Loaded asset bundle:", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("EEE", new UnityAction(this.EMGLPBHECDO));
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x001AAEA7 File Offset: 0x001A90A7
	private IEnumerator PDBBKBKDFFP()
	{
		StoryChatManager.JEEPODLCKCD jeepodlckcd = new StoryChatManager.JEEPODLCKCD(1);
		jeepodlckcd.<>4__this = this;
		return jeepodlckcd;
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x001AAEB6 File Offset: 0x001A90B6
	private void JCOBBJJNHIJ()
	{
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("OnEmailUnsubscribeSuccess", new UnityAction(this.BFLPEJILCCB));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("frsmmsg64", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x001AAEF0 File Offset: 0x001A90F0
	private void NELDMBEONKD()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 23;
		AudioManager.IFDLAMLHKIJ().KillSfx("restartChapterOrStory", 1772f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("XXX", 1952f);
		AudioManager.BFCHJBOOJKE().KillSfx("contentIndex" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 66f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("loungenotavailable", 351f);
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x001AAF98 File Offset: 0x001A9198
	public static PAMDLEFCBDE BOIBAHKPALO(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return PAMDLEFCBDE.fast;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("e1it"))
		{
			return PAMDLEFCBDE.offscreen;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("getDepot"))
		{
			return PAMDLEFCBDE.fast;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("Starting parallel download:"))
		{
			return PAMDLEFCBDE.fast;
		}
		return (PAMDLEFCBDE)5;
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x001AAFF6 File Offset: 0x001A91F6
	private IEnumerator EPKCJEABBLC()
	{
		while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		if (this.enableChatOffsetOnInput)
		{
			this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		}
		this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
		this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
		this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
		while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
		yield return new WaitForSeconds(0.1f);
		this.JEPKCMADMIN = null;
		if (this.enableChatOffsetOnInput)
		{
			this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		}
		yield break;
	}

	// Token: 0x06003F8B RID: 16267 RVA: 0x001A94C2 File Offset: 0x001A76C2
	private IEnumerator IECMOJFOBIK()
	{
		StoryChatManager.OIOHPMOHAGP oiohpmohagp = new StoryChatManager.OIOHPMOHAGP(1);
		oiohpmohagp.<>4__this = this;
		return oiohpmohagp;
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x001A9F98 File Offset: 0x001A8198
	private IEnumerator OBJCANCEFBG()
	{
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.05f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(0f, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			this.AKFKCKHPIOA[i].GetComponent<RectTransform>().DOScale(new Vector3(0.95f, 0.95f, 0.95f), 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield return new WaitForSeconds(0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.NOKDDOJJDCE();
		yield break;
	}

	// Token: 0x06003F8D RID: 16269 RVA: 0x001A96DF File Offset: 0x001A78DF
	private IEnumerator CEAHHDJFAPN(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.MCKPNELJNIC = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (DKNNMLIDPHH.IPKLCGDNCEC)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			else if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
				this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
				this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
				while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
				yield return new WaitForSeconds(0.1f);
				this.JEPKCMADMIN = null;
				if (this.enableChatOffsetOnInput)
				{
					this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
			}
			else if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj in this.typeAnimationPivotPlayer.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotPlayer.SetActive(true);
				this.typeAnimationPivotPlayer.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotPlayer.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(-1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotPlayer.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.playerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject);
			gameObject.transform.SetParent(this.messagesContainer.transform, false);
			gameObject.GetComponent<StoryChatPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			if (ICLIOLFLKAM)
			{
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				foreach (object obj2 in this.typeAnimationPivotNpc.transform)
				{
					((Transform)obj2).gameObject.SetActive(false);
				}
				typeAnimationObject = UnityEngine.Object.Instantiate<GameObject>(this.typeAnimationPrefab);
				this.LHNFPOJPFIJ.Add(typeAnimationObject);
				this.typeAnimationPivotNpc.SetActive(true);
				this.typeAnimationPivotNpc.transform.SetAsLastSibling();
				typeAnimationObject.transform.SetParent(this.typeAnimationPivotNpc.transform, false);
				typeAnimationObject.GetComponent<StoryChatDelayManager>().SetScaleX(1);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				typeAnimationObject.GetComponent<StoryChatDelayManager>().FadeOut();
				yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
				while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
				{
					yield return new WaitForSeconds(0.1f);
				}
				this.typeAnimationPivotNpc.SetActive(false);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				typeAnimationObject = null;
			}
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.nonPlayerMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject2);
			gameObject2.transform.SetParent(this.messagesContainer.transform, false);
			gameObject2.GetComponent<StoryChatNonPlayerMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ, this.LMKDNPOKOBF);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 2)
		{
			while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
			{
				yield return new WaitForSeconds(0.1f);
			}
			if (PDOKEHMIIKF)
			{
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.systemMessagePrefab);
			this.LHNFPOJPFIJ.Add(gameObject3);
			gameObject3.transform.SetParent(this.messagesContainer.transform, false);
			gameObject3.GetComponent<StoryChatSystemMessageManager>().Initialize(DKNNMLIDPHH, PANKDLOEOHJ);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
			if (PDOKEHMIIKF)
			{
				if (!this.BPNGIDAMBEJ)
				{
					AudioManager.EHBBFMCILPC.PlaySfx("sfxchatnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false);
				}
				yield return new WaitForSeconds(0.5f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC());
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.ShowMessageCoroutine(), unsupported message type:" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
		}
		this.MCKPNELJNIC = false;
		yield break;
	}

	// Token: 0x06003F8E RID: 16270 RVA: 0x001AB008 File Offset: 0x001A9208
	private void GEBJHHNNCII()
	{
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 1)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		base.StartCoroutine(this.PDBBKBKDFFP());
	}

	// Token: 0x06003F8F RID: 16271 RVA: 0x001AB0B8 File Offset: 0x001A92B8
	public void HDNGGKLGDFG()
	{
		this.BFMOAOBMBOA = false;
		base.StartCoroutine(this.PNNKDAOMNLG());
	}

	// Token: 0x06003F91 RID: 16273 RVA: 0x001AB14C File Offset: 0x001A934C
	private void OCPEFOECHGC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -29;
		AudioManager.IFDLAMLHKIJ().KillSfx("errortitle", 1328f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("OnStoryChoiceClick", 1259f);
		AudioManager.BFCHJBOOJKE().KillSfx("" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 324f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("CharacterPoolCanvas", 208f);
	}

	// Token: 0x06003F92 RID: 16274 RVA: 0x001AB1F4 File Offset: 0x001A93F4
	private void FDHHCPPPKKI()
	{
		AOBJLALDBAA.NMGMNAKLLMI().MHLNJIACIGO("Plate", new UnityAction(this.BFLPEJILCCB));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("OSX", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003F93 RID: 16275 RVA: 0x001A8B49 File Offset: 0x001A6D49
	private IEnumerator NEKBMPGBLCJ()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.05f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.95f, 0.95f, 0.95f);
			component.DOScale(this.choicesScaleCoefficient, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x06003F94 RID: 16276 RVA: 0x001A93C8 File Offset: 0x001A75C8
	private IEnumerator PPEFNNNIBEF(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		while (this.IsInScrollState() || this.MCKPNELJNIC || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("dynamic"))
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
				{
					this.IMPAHLIGELE.JMNMOHIKHLB.AEMELJEDNJH(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
				}
			}
			else
			{
				try
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.bulk)
				{
					for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
					{
						this.HNGBMIJHPLE.Add(j);
					}
					break;
				}
			}
		}
		if (this.HNGBMIJHPLE.Count == 0)
		{
			for (int k = 0; k < 2; k++)
			{
				for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
				{
					int num = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
					{
						if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
						{
							num = 1;
						}
						else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 0)
						{
							num = 2;
						}
					}
					if ((k == 0 && num == 1) || (k != 0 && num != 1))
					{
						this.HNGBMIJHPLE.Add(l);
					}
				}
			}
		}
		try
		{
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					int num2 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 1;
						}
						else if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 2;
						}
					}
					if (num2 == 2)
					{
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								this.choicesPivot.SetActive(true);
								this.choicesPivot.transform.SetAsLastSibling();
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeStatInfo);
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.choicesPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].GALKFKBPLCK());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("hidestatinfo"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterStatInfo);
							}
							goto IL_648;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_648;
						}
					}
					if (num2 == 1 && null == this.LOJHEKCOFME && !SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						this.choicesPivot.SetActive(true);
						this.choicesPivot.transform.SetAsLastSibling();
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeGemsInfo);
						this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
						this.LOJHEKCOFME.transform.SetParent(this.choicesPivot.transform, false);
						this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterGemsInfo);
					}
				}
				IL_648:;
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		int ddmmddfiall = -1;
		if (KGLBKJKNPFD.ALLDBPCKMLF == 1)
		{
			ddmmddfiall = 520;
		}
		for (int n = 0; n < this.IMPAHLIGELE.COEFNFJMBDG.Count; n++)
		{
			if (!this.IMPAHLIGELE.COEFNFJMBDG[n].BEHENEHGPCP)
			{
				GameObject gameObject = null;
				int num3 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
				{
					if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 1;
					}
					else if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 2;
					}
				}
				if (num3 == 2)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)]].GALKFKBPLCK(), ddmmddfiall);
					gameObject.GetComponent<ChoiceStatManager>().ExtendRightSide();
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else if (num3 == 1)
				{
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], 0, ddmmddfiall, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], ddmmddfiall, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					this.NDDGCFFDFJN.Add(gameObject);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else
				{
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = n;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], ddmmddfiall);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				gameObject.GetComponent<RectTransform>();
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(n) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(n) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(n) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(n) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(n) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(n) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject);
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 0f;
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm5)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
		}
		if (null != this.LOJHEKCOFME)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnShowStoryHeaderInterfaceGamePassAndUndoButton", 0f);
		}
		yield break;
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x001AB22C File Offset: 0x001A942C
	public void KJHGKLAJGBG()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(490f, 72f, 181f), 1229f, (IMBLFHMKMAD)149);
		this.PANMNKKODPC.DOFade(1311f, 747f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x001AB288 File Offset: 0x001A9488
	private void LEEEOAHDCJD()
	{
		this.JEPKCMADMIN = null;
		this.LAIEDFNEHLM();
		for (int i = 0; i < this.LHNFPOJPFIJ.Count; i++)
		{
			this.LHNFPOJPFIJ[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.LHNFPOJPFIJ[i]);
		}
		this.LHNFPOJPFIJ.Clear();
		this.PANMNKKODPC.DOKill(false);
		this.chatImageRectTransform.DOKill(false);
		this.messagesScrollView.onValueChanged.RemoveListener(new UnityAction<Vector2>(this.IDPCGCONADK));
	}

	// Token: 0x06003F97 RID: 16279 RVA: 0x001AB324 File Offset: 0x001A9524
	public void APCBKOGALLK(List<string> OHHICBLFIDA, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (PANKDLOEOHJ == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnStartFreePassSuccess");
			return;
		}
		this.BPNGIDAMBEJ = PANKDLOEOHJ.BPNGIDAMBEJ;
		if (this.BPNGIDAMBEJ && null != this.fadeObject)
		{
			this.fadeObject.SetActive(false);
		}
		if (null != this.titleText)
		{
			string text = PANKDLOEOHJ.IJKPGGOLOED();
			try
			{
				text = ONEHEBIHPFB.LMDACNKELEC(PANKDLOEOHJ.HDNHFIPNDDC());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.titleText.SetText(text, false);
			this.titleText.text = text;
		}
		for (int i = 0; i < OHHICBLFIDA.Count; i++)
		{
			GNKBFDPLGOE gnkbfdplgoe = new GNKBFDPLGOE();
			gnkbfdplgoe.MIFHLEDLDIF(OHHICBLFIDA[i]);
			this.DOHAALLBFJN(gnkbfdplgoe, PANKDLOEOHJ, true, false);
		}
	}

	// Token: 0x06003F98 RID: 16280 RVA: 0x001AB3F8 File Offset: 0x001A95F8
	private void JFJICBDGEDH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 27;
		AudioManager.DMAAFFFEJGA().KillSfx("There needs to be one active AppleSignInManager script on a GameObject in your scene.", 342f);
		AudioManager.EHBBFMCILPC.KillSfx("layervideo", 858f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("AssetProfileData.GetCutsceneSprite(): invalid input data:" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1883f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("passhintactivesub", 1858f);
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x001A92C8 File Offset: 0x001A74C8
	private int BGPDLJLJLCH(int MEFKFOHCOHK)
	{
		return MEFKFOHCOHK;
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x001AB4A0 File Offset: 0x001A96A0
	private void FFDGLHACKON()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x001AB548 File Offset: 0x001A9748
	private void CLBIPOBJKMJ(Vector2 KFKFGEOCEIB)
	{
		float y = this.messagesContainer.GetComponent<RectTransform>().anchoredPosition.y;
		if (y < -0.5f || y > 0.5f)
		{
			this.GMEAMOEADME = true;
			if (!this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(true);
			}
			if (null != this.JEPKCMADMIN && this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
				return;
			}
		}
		else
		{
			this.GMEAMOEADME = false;
			if (this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && !this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(true);
			}
		}
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x001AB620 File Offset: 0x001A9820
	public void NMEFHEHBOPA()
	{
		this.PANMNKKODPC.DOFade(1210f, 1240f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 352f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1026f, 973f, 1548f), 513f, (IMBLFHMKMAD)61);
		this.chatImageRectTransform.AHLJBONHHKL(54, -53);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1692f, 1664f, 209f), 962f, (IMBLFHMKMAD)67).x, 1069f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(1757f, 1833f), 218f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false);
	}

	// Token: 0x06003F9D RID: 16285 RVA: 0x001A92C8 File Offset: 0x001A74C8
	private int BBDJPMHBAJK(int MEFKFOHCOHK)
	{
		return MEFKFOHCOHK;
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x001AA616 File Offset: 0x001A8816
	private IEnumerator DOHKIHKCODA()
	{
		StoryChatManager.EHONMNJBEAA ehonmnjbeaa = new StoryChatManager.EHONMNJBEAA(1);
		ehonmnjbeaa.<>4__this = this;
		return ehonmnjbeaa;
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x001AAEA7 File Offset: 0x001A90A7
	private IEnumerator JDBAIOMNMCA()
	{
		StoryChatManager.JEEPODLCKCD jeepodlckcd = new StoryChatManager.JEEPODLCKCD(1);
		jeepodlckcd.<>4__this = this;
		return jeepodlckcd;
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x001AB718 File Offset: 0x001A9918
	public void NMEKNAPFIML()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(391f, 747f, 405f), 808f, (IMBLFHMKMAD)(-80));
		this.PANMNKKODPC.DOFade(469f, 345f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x001AB774 File Offset: 0x001A9974
	private void LMAHHJACHGC(Vector2 KFKFGEOCEIB)
	{
		float y = this.messagesContainer.GetComponent<RectTransform>().anchoredPosition.y;
		if (y < 268f || y > 123f)
		{
			this.GMEAMOEADME = false;
			if (!this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(false);
				return;
			}
		}
		else
		{
			this.GMEAMOEADME = true;
			if (this.pausePivot.gameObject.activeSelf)
			{
				this.pausePivot.gameObject.SetActive(false);
			}
			if (null != this.JEPKCMADMIN && !this.JEPKCMADMIN.activeSelf)
			{
				this.JEPKCMADMIN.SetActive(true);
			}
		}
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x001AB84C File Offset: 0x001A9A4C
	public void NIBKGKIGFID()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1091f, 1640f, 796f), 1245f, (IMBLFHMKMAD)(-189));
		this.PANMNKKODPC.DOFade(1518f, 271f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x001AB8A8 File Offset: 0x001A9AA8
	public void AMKEBHPLFGD()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(886f, 1452f, 656f), 1340f, (IMBLFHMKMAD)(-66));
		this.PANMNKKODPC.DOFade(360f, 585f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x001AAEA7 File Offset: 0x001A90A7
	private IEnumerator BKEKAGODADH()
	{
		StoryChatManager.JEEPODLCKCD jeepodlckcd = new StoryChatManager.JEEPODLCKCD(1);
		jeepodlckcd.<>4__this = this;
		return jeepodlckcd;
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x001AB904 File Offset: 0x001A9B04
	public void DBPOPCMKEDH(List<string> OHHICBLFIDA, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (PANKDLOEOHJ == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnLiveOfferSuccessShowPassesWindow");
			return;
		}
		this.BPNGIDAMBEJ = PANKDLOEOHJ.BPNGIDAMBEJ;
		if (this.BPNGIDAMBEJ && null != this.fadeObject)
		{
			this.fadeObject.SetActive(true);
		}
		if (null != this.titleText)
		{
			string text = PANKDLOEOHJ.HKNHDGCFIGJ();
			try
			{
				text = ONEHEBIHPFB.LMDACNKELEC(PANKDLOEOHJ.GJPPCPBIOOO());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.titleText.SetText(text, false);
			this.titleText.text = text;
		}
		for (int i = 0; i < OHHICBLFIDA.Count; i++)
		{
			GNKBFDPLGOE gnkbfdplgoe = new GNKBFDPLGOE();
			gnkbfdplgoe.EIMEPHEOKEK(OHHICBLFIDA[i]);
			this.BEHOCMNKFPH(gnkbfdplgoe, PANKDLOEOHJ, false, false);
		}
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x001AB9D8 File Offset: 0x001A9BD8
	private float ONFFIJGMDMH(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.BFMOAOBMBOA = false;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				this.BFMOAOBMBOA = true;
			}
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC();
			}
			return 0f;
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 2f) * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC();
			}
			return 0f;
		}
		else
		{
			if (DKNNMLIDPHH.GLDFFFJIACO != 2)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoryChatManager.ShowMessage(), unsupported message type:" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
				return 0f;
			}
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return 1f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * this.FBHBMAHJBAC();
			}
			return 0f;
		}
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x001ABB24 File Offset: 0x001A9D24
	public void IEDNMDJDDDE()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(951f, 471f, 1506f), 23f, (IMBLFHMKMAD)(-93));
		this.PANMNKKODPC.DOFade(211f, 669f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003FA8 RID: 16296 RVA: 0x001A8B49 File Offset: 0x001A6D49
	private IEnumerator MFOEICJDFMK()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.05f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.95f, 0.95f, 0.95f);
			component.DOScale(this.choicesScaleCoefficient, 0.15f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x001A93C8 File Offset: 0x001A75C8
	private IEnumerator JDKJOMNFCON(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		while (this.IsInScrollState() || this.MCKPNELJNIC || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("dynamic"))
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
				{
					this.IMPAHLIGELE.JMNMOHIKHLB.AEMELJEDNJH(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
				}
			}
			else
			{
				try
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.bulk)
				{
					for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
					{
						this.HNGBMIJHPLE.Add(j);
					}
					break;
				}
			}
		}
		if (this.HNGBMIJHPLE.Count == 0)
		{
			for (int k = 0; k < 2; k++)
			{
				for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
				{
					int num = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
					{
						if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
						{
							num = 1;
						}
						else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 0)
						{
							num = 2;
						}
					}
					if ((k == 0 && num == 1) || (k != 0 && num != 1))
					{
						this.HNGBMIJHPLE.Add(l);
					}
				}
			}
		}
		try
		{
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					int num2 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 1;
						}
						else if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num2 = 2;
						}
					}
					if (num2 == 2)
					{
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								this.choicesPivot.SetActive(true);
								this.choicesPivot.transform.SetAsLastSibling();
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeStatInfo);
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.choicesPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].GALKFKBPLCK());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("hidestatinfo"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
								this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterStatInfo);
							}
							goto IL_648;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_648;
						}
					}
					if (num2 == 1 && null == this.LOJHEKCOFME && !SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						this.choicesPivot.SetActive(true);
						this.choicesPivot.transform.SetAsLastSibling();
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddBeforeGemsInfo);
						this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
						this.LOJHEKCOFME.transform.SetParent(this.choicesPivot.transform, false);
						this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
						this.CAKPAEBGEPN(this.choicesPivot.transform, this.verticalSpaceToAddAfterGemsInfo);
					}
				}
				IL_648:;
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		int ddmmddfiall = -1;
		if (KGLBKJKNPFD.ALLDBPCKMLF == 1)
		{
			ddmmddfiall = 520;
		}
		for (int n = 0; n < this.IMPAHLIGELE.COEFNFJMBDG.Count; n++)
		{
			if (!this.IMPAHLIGELE.COEFNFJMBDG[n].BEHENEHGPCP)
			{
				GameObject gameObject = null;
				int num3 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
				{
					if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 1;
					}
					else if (this.HDBBHHBOJIN(n) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)] > 0)
					{
						num3 = 2;
					}
				}
				if (num3 == 2)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(n)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(n)]].GALKFKBPLCK(), ddmmddfiall);
					gameObject.GetComponent<ChoiceStatManager>().ExtendRightSide();
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else if (num3 == 1)
				{
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], 0, ddmmddfiall, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], ddmmddfiall, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(n), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(n)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					this.NDDGCFFDFJN.Add(gameObject);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				else
				{
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = n;
					}
					this.choicesPivot.SetActive(true);
					this.choicesPivot.transform.SetAsLastSibling();
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(n)], ddmmddfiall);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.choicesPivot.GetComponent<RectTransform>());
					LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
				}
				gameObject.GetComponent<RectTransform>();
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(n) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(n) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(n) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(n) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(n) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(n) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject);
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 0f;
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm5)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
		}
		if (null != this.LOJHEKCOFME)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnShowStoryHeaderInterfaceGamePassAndUndoButton", 0f);
		}
		yield break;
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x001ABB80 File Offset: 0x001A9D80
	public void COGLNKANGFH(LJFIKKKBMDG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		base.StartCoroutine(this.HFIHGBDOFAI(JIKFCLOHJNN, BAOKJBJIFBH, OAGPAAMJOID));
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x001ABB92 File Offset: 0x001A9D92
	private void DKOOJKIGLBN()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 0)
		{
			this.AKJMKGCPCCB -= 0;
		}
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x001ABBC4 File Offset: 0x001A9DC4
	private void MIKBLMAOAIK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -101;
		AudioManager.APGODIBBPOD().KillSfx("", 1621f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("importanttitle", 1243f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("\nDEF:" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1127f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("$LAYERUTIL", 126f);
	}

	// Token: 0x06003FAD RID: 16301 RVA: 0x001ABC6C File Offset: 0x001A9E6C
	private void KGLPFNCMIEM()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -14;
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("RunCustomCode() repeat:", 63f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("oldvhsovr_2", 892f);
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1508f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("ok", 1145f);
	}

	// Token: 0x06003FAE RID: 16302 RVA: 0x001ABD14 File Offset: 0x001A9F14
	private float ICCMDOHPDIL()
	{
		if (this.BPNGIDAMBEJ)
		{
			return 1868f;
		}
		return 1900f;
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x001A92CB File Offset: 0x001A74CB
	public bool JGFJEHCPBEO()
	{
		return this.GMEAMOEADME;
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x001ABD2C File Offset: 0x001A9F2C
	private void DGEBDEGLEIJ()
	{
		this.messagesScrollView.scrollSensitivity = 875f;
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("Npc id has been destroyed according to on demand data:", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("onThemeChange", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x001ABD80 File Offset: 0x001A9F80
	private void OnDestroy()
	{
		this.JEPKCMADMIN = null;
		this.NOKDDOJJDCE();
		for (int i = 0; i < this.LHNFPOJPFIJ.Count; i++)
		{
			this.LHNFPOJPFIJ[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.LHNFPOJPFIJ[i]);
		}
		this.LHNFPOJPFIJ.Clear();
		this.PANMNKKODPC.DOKill(false);
		this.chatImageRectTransform.DOKill(false);
		this.messagesScrollView.onValueChanged.RemoveListener(new UnityAction<Vector2>(this.CLBIPOBJKMJ));
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x001ABE1C File Offset: 0x001AA01C
	public void LLNFNNHABMF()
	{
		this.PANMNKKODPC.DOFade(569f, 735f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOScale(1977f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1748f, 1073f, 1581f), 1556f, (IMBLFHMKMAD)(-65)).x, 325f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(1834f, 1544f), 342f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x001ABED0 File Offset: 0x001AA0D0
	public void AppearAnimation1()
	{
		this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 0.9f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride);
		this.chatImageRectTransform.AHLJBONHHKL(-50, 25);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride).x, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(50f, -25f), 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false);
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x001ABFC8 File Offset: 0x001AA1C8
	private void OOAMLBCKPLC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -101;
		AudioManager.APGODIBBPOD().KillSfx("timerIsHidden", 1764f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("aind", 1962f);
		AudioManager.EHBBFMCILPC.KillSfx("importanttitle" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1821f);
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("<i>", 1175f);
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x001AC070 File Offset: 0x001AA270
	public float BLKIKDMMMOB(LJFIKKKBMDG JIKFCLOHJNN, PFADAFAHNNJ PANKDLOEOHJ)
	{
		this.BKAPJIOECCK = this.DOHAALLBFJN(JIKFCLOHJNN.KLBCAFJDOIJ(PANKDLOEOHJ), PANKDLOEOHJ, true, true);
		return this.BKAPJIOECCK;
	}

	// Token: 0x06003FB6 RID: 16310 RVA: 0x001AC090 File Offset: 0x001AA290
	public void DLFDIIPBNPK()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(436f, 627f, 150f), 502f, (IMBLFHMKMAD)(-190));
		this.PANMNKKODPC.DOFade(524f, 635f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x001AA616 File Offset: 0x001A8816
	private IEnumerator DJNJMHBNNPF()
	{
		StoryChatManager.EHONMNJBEAA ehonmnjbeaa = new StoryChatManager.EHONMNJBEAA(1);
		ehonmnjbeaa.<>4__this = this;
		return ehonmnjbeaa;
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x001AC0EC File Offset: 0x001AA2EC
	private void LNGEBPKKFBO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -47;
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("frcmpidsuid", 1799f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("serversync", 86f);
		AudioManager.DMAAFFFEJGA().KillSfx("skinshopinfounlockgate" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 900f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK(" of ", 741f);
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x001AAFF6 File Offset: 0x001A91F6
	private IEnumerator PNNKDAOMNLG()
	{
		while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		if (this.enableChatOffsetOnInput)
		{
			this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		}
		this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
		this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
		this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
		while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
		yield return new WaitForSeconds(0.1f);
		this.JEPKCMADMIN = null;
		if (this.enableChatOffsetOnInput)
		{
			this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		}
		yield break;
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x001AC194 File Offset: 0x001AA394
	private void NOKDDOJJDCE()
	{
		this.choicesPivot.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		this.LOJHEKCOFME = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.NGGBBCDPMJH = null;
		for (int j = 0; j < this.PDMKLEPMKLE.Count; j++)
		{
			if (null != this.PDMKLEPMKLE[j])
			{
				UnityEngine.Object.Destroy(this.PDMKLEPMKLE[j]);
			}
		}
		this.PDMKLEPMKLE.Clear();
		this.FLBNNNDBECB = -1;
		this.HNGBMIJHPLE = new List<int>();
		this.AKJMKGCPCCB = -1;
		this.CIPGFJLECDH = false;
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x001AC2D4 File Offset: 0x001AA4D4
	public void GMHPNCFLJID()
	{
		this.PANMNKKODPC.DOFade(1674f, 1817f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 1769f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1933f, 768f, 223f), 1150f, (IMBLFHMKMAD)(-198));
		this.chatImageRectTransform.AHLJBONHHKL(-91, -102);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(770f, 1534f, 1603f), 1775f, (IMBLFHMKMAD)(-85)).x, 1719f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(535f, 1912f), 668f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x001AC3CC File Offset: 0x001AA5CC
	public void NJCFMGDBCKN()
	{
		this.PANMNKKODPC.DOFade(629f, 879f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 793f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(922f, 1950f, 1514f), 33f, (IMBLFHMKMAD)6);
		this.chatImageRectTransform.AHLJBONHHKL(77, -53);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1748f, 1961f, 1133f), 1283f, (IMBLFHMKMAD)(-108)).x, 1744f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(1951f, 862f), 574f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x001AC4C1 File Offset: 0x001AA6C1
	public void CPDHGHCIKBO()
	{
		this.BFMOAOBMBOA = false;
		base.StartCoroutine(this.FLCCFLHAJPJ());
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x001AC4D8 File Offset: 0x001AA6D8
	private void FHLGGHKJDHB(Transform BFGBPKIGAJI, int ABECBDBCLJL)
	{
		if (null == BFGBPKIGAJI || ABECBDBCLJL <= 1)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		RectTransform cciagbpilgf = gameObject.AddComponent<RectTransform>();
		cciagbpilgf.ACBKFBBCNNC((float)ABECBDBCLJL);
		cciagbpilgf.EFOCKEJENAC((float)ABECBDBCLJL);
		gameObject.transform.SetParent(BFGBPKIGAJI, true);
		this.PDMKLEPMKLE.Add(gameObject);
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x001AC527 File Offset: 0x001AA727
	public float IJEMOFPECOE(LJFIKKKBMDG JIKFCLOHJNN, PFADAFAHNNJ PANKDLOEOHJ)
	{
		this.BKAPJIOECCK = this.BEHOCMNKFPH(JIKFCLOHJNN.FEELKPKJBKA(PANKDLOEOHJ), PANKDLOEOHJ, true, true);
		return this.BKAPJIOECCK;
	}

	// Token: 0x06003FC0 RID: 16320 RVA: 0x001AC545 File Offset: 0x001AA745
	private void DCEHHOHHFDM()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1058f;
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x001AC568 File Offset: 0x001AA768
	private float FDILAOOCCHA(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.BFMOAOBMBOA = true;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				this.BFMOAOBMBOA = true;
			}
			base.StartCoroutine(this.CEAHHDJFAPN(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.CBHECHLLDPJ(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.GJMKEBIDNNN(PANKDLOEOHJ.GINAOBOFOFC) / 96f) * AppManager.EHBBFMCILPC.debugSettings.DCEHMKDEHIC(1227f) * this.ICCMDOHPDIL();
			}
			return 81f;
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.CDHKFFFDMHC(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.MLOOAIHFGFK(PANKDLOEOHJ.GINAOBOFOFC) / 1185f) * AppManager.AGANFKKBPFO().debugSettings.BIMIMMJLMAP(1017f) * this.HJHMFFEJKIO();
			}
			return 1538f;
		}
		else
		{
			if (DKNNMLIDPHH.GLDFFFJIACO != 0)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("…" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
				return 1870f;
			}
			base.StartCoroutine(this.HAHHLNKKKOO(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return 832f * AppManager.EHBBFMCILPC.debugSettings.JJKAIPFFCLP(1321f) * this.KMLIBPFHCFD();
			}
			return 239f;
		}
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x001AC6B4 File Offset: 0x001AA8B4
	public void BFFDDKJCLMC()
	{
		this.PANMNKKODPC.DOFade(672f, 131f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOScale(768f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1038f, 1199f, 734f), 389f, (IMBLFHMKMAD)(-127)).x, 58f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(1931f, 880f), 505f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003FC3 RID: 16323 RVA: 0x001A87A2 File Offset: 0x001A69A2
	private void PDEEDGHFAEJ()
	{
		this.messagesScrollView.onValueChanged.AddListener(new UnityAction<Vector2>(this.CLBIPOBJKMJ));
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x001AC768 File Offset: 0x001AA968
	private void OnEnable()
	{
		this.messagesScrollView.scrollSensitivity = 100f;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPremiumChoiceSuccess", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06003FC5 RID: 16325 RVA: 0x001AAFF6 File Offset: 0x001A91F6
	private IEnumerator HEFEJMMEKPP()
	{
		while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		if (this.enableChatOffsetOnInput)
		{
			this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetOnInput;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		}
		this.JEPKCMADMIN = UnityEngine.Object.Instantiate<GameObject>(this.inputAnimationPrefab);
		this.LHNFPOJPFIJ.Add(this.JEPKCMADMIN);
		this.JEPKCMADMIN.transform.SetParent(this.inputAnimationPivot.transform, false);
		while (this.BFMOAOBMBOA || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		while (this.IsInScrollState() || SceneStoryManager.inkInterpretingIsPaused)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.JEPKCMADMIN.GetComponent<TapToContinueManager>().FadeOut();
		yield return new WaitForSeconds(0.1f);
		this.JEPKCMADMIN = null;
		if (this.enableChatOffsetOnInput)
		{
			this.messagesContainer.GetComponent<VerticalLayoutGroup>().padding.bottom = this.chateOffsetRevertOnInput;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		}
		yield break;
	}

	// Token: 0x06003FC6 RID: 16326 RVA: 0x001AC7BC File Offset: 0x001AA9BC
	public void INBNIPJLJAL()
	{
		this.PANMNKKODPC.DOFade(1394f, 705f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.localScale = 447f * NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1871f, 1429f, 148f), 1607f, (IMBLFHMKMAD)106);
		this.chatImageRectTransform.AHLJBONHHKL(-52, -104);
		this.chatImageRectTransform.DOScale(NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(708f, 843f, 406f), 1296f, (IMBLFHMKMAD)123).x, 1430f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.chatImageRectTransform.DOAnchorPos(this.chatImageRectTransform.anchoredPosition + new Vector2(933f, 1872f), 12f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true);
	}

	// Token: 0x06003FC7 RID: 16327 RVA: 0x001AC8B4 File Offset: 0x001AAAB4
	private void NEBEJKALBFA()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 5;
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("VER:", 1493f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("</i>", 502f);
		AudioManager.BFCHJBOOJKE().KillSfx("cardoptionsloadingthemereset" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1947f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("muspind", 754f);
	}

	// Token: 0x06003FC8 RID: 16328 RVA: 0x001AC95C File Offset: 0x001AAB5C
	private void MDGKJKBNDCO()
	{
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "mfs" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		base.StartCoroutine(this.BKEKAGODADH());
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x001ACA0C File Offset: 0x001AAC0C
	private float HJHMFFEJKIO()
	{
		if (this.BPNGIDAMBEJ)
		{
			return 1064f;
		}
		return 122f;
	}

	// Token: 0x06003FCA RID: 16330 RVA: 0x001ACA24 File Offset: 0x001AAC24
	private void BENGHKGCLOG()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x001A96CA File Offset: 0x001A78CA
	public bool IsBusyTyping()
	{
		return this.MCKPNELJNIC && !this.BFMOAOBMBOA;
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x001ACACC File Offset: 0x001AACCC
	private void HHJOPCHBDOK()
	{
		this.choicesPivot.SetActive(true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.messagesContainer.GetComponent<RectTransform>());
		for (int i = 1; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		this.LOJHEKCOFME = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.NGGBBCDPMJH = null;
		for (int j = 0; j < this.PDMKLEPMKLE.Count; j++)
		{
			if (null != this.PDMKLEPMKLE[j])
			{
				UnityEngine.Object.Destroy(this.PDMKLEPMKLE[j]);
			}
		}
		this.PDMKLEPMKLE.Clear();
		this.FLBNNNDBECB = -1;
		this.HNGBMIJHPLE = new List<int>();
		this.AKJMKGCPCCB = -1;
		this.CIPGFJLECDH = true;
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x001ACC0C File Offset: 0x001AAE0C
	public void FABOEAJEKOF()
	{
		this.chatImageRectTransform.localScale = NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1934f, 1643f, 400f), 563f, (IMBLFHMKMAD)(-197));
		this.PANMNKKODPC.DOFade(1293f, 1212f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x001ACC68 File Offset: 0x001AAE68
	private void LEGMHPHBHHD()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 57;
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("normal", 1920f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("OnSceneLobbyManagerAssetsDownloadFailed", 1129f);
		AudioManager.DMAAFFFEJGA().KillSfx("OnAccountSignInSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1963f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("importanttitle", 748f);
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x001ACD10 File Offset: 0x001AAF10
	private void LGEJJBINCJP()
	{
		this.JEPKCMADMIN = null;
		this.LAIEDFNEHLM();
		for (int i = 0; i < this.LHNFPOJPFIJ.Count; i += 0)
		{
			this.LHNFPOJPFIJ[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.LHNFPOJPFIJ[i]);
		}
		this.LHNFPOJPFIJ.Clear();
		this.PANMNKKODPC.DOKill(true);
		this.chatImageRectTransform.DOKill(false);
		this.messagesScrollView.onValueChanged.RemoveListener(new UnityAction<Vector2>(this.CLBIPOBJKMJ));
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x001A94C2 File Offset: 0x001A76C2
	private IEnumerator CJIKJGKHNMJ()
	{
		StoryChatManager.OIOHPMOHAGP oiohpmohagp = new StoryChatManager.OIOHPMOHAGP(1);
		oiohpmohagp.<>4__this = this;
		return oiohpmohagp;
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x001ACDAC File Offset: 0x001AAFAC
	private void LLCAMLLJNOE()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -7;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("basicSync", 247f);
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("hdr", 1610f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("[LoadingTheme] bonus free change spent, " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1151f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("StoryChatManager.Initialize(), _chatMeta is null", 669f);
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x001ACE54 File Offset: 0x001AB054
	private float EAAABHEIFCG(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, bool PDOKEHMIIKF, bool ICLIOLFLKAM)
	{
		this.BFMOAOBMBOA = false;
		if (DKNNMLIDPHH.GLDFFFJIACO == 0)
		{
			if (!PANKDLOEOHJ.EFBJNOAJGDA && PDOKEHMIIKF)
			{
				this.BFMOAOBMBOA = false;
			}
			base.StartCoroutine(this.MIBJPNHADEH(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.AAHKJKKDHDA(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.BFNOKCJAFEO(PANKDLOEOHJ.GINAOBOFOFC) / 1695f) * AppManager.EHBBFMCILPC.debugSettings.FJKMBEMJAEA(534f) * this.HJHMFFEJKIO();
			}
			return 672f;
		}
		else if (DKNNMLIDPHH.GLDFFFJIACO == 1)
		{
			base.StartCoroutine(this.CALJGGNMOJD(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return (DKNNMLIDPHH.EKHNDIHGGAJ(PANKDLOEOHJ.GINAOBOFOFC) + DKNNMLIDPHH.IPKFMNJNLHF(PANKDLOEOHJ.GINAOBOFOFC) / 428f) * AppManager.EHBBFMCILPC.debugSettings.MLEPAJKOKEK(871f) * this.HJHMFFEJKIO();
			}
			return 87f;
		}
		else
		{
			if (DKNNMLIDPHH.GLDFFFJIACO != 8)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("refocus" + DKNNMLIDPHH.GLDFFFJIACO.ToString());
				return 190f;
			}
			base.StartCoroutine(this.MIBJPNHADEH(DKNNMLIDPHH, PANKDLOEOHJ, PDOKEHMIIKF, ICLIOLFLKAM));
			if (PDOKEHMIIKF)
			{
				return 342f * AppManager.AGANFKKBPFO().debugSettings.BIMIMMJLMAP(856f) * this.KMLIBPFHCFD();
			}
			return 1346f;
		}
	}

	// Token: 0x040011B2 RID: 4530
	public bool enableChatOffsetOnInput = true;

	// Token: 0x040011B3 RID: 4531
	public int chateOffsetOnInput = 80;

	// Token: 0x040011B4 RID: 4532
	public int chateOffsetRevertOnInput = 40;

	// Token: 0x040011B5 RID: 4533
	public int verticalSpaceToAddBeforeStatInfo;

	// Token: 0x040011B6 RID: 4534
	public int verticalSpaceToAddAfterStatInfo;

	// Token: 0x040011B7 RID: 4535
	public int verticalSpaceToAddBeforeGemsInfo;

	// Token: 0x040011B8 RID: 4536
	public int verticalSpaceToAddAfterGemsInfo;

	// Token: 0x040011B9 RID: 4537
	public float choicesScaleCoefficient = 1f;

	// Token: 0x040011BA RID: 4538
	public const float buttonFadeInTime = 0.15f;

	// Token: 0x040011BB RID: 4539
	public const float buttonWaitInLine = 0.05f;

	// Token: 0x040011BC RID: 4540
	public GameObject choiceStandardPrefab;

	// Token: 0x040011BD RID: 4541
	public GameObject choicePremiumPrefab;

	// Token: 0x040011BE RID: 4542
	public GameObject choiceStat0Prefab;

	// Token: 0x040011BF RID: 4543
	public GameObject choiceStat1Prefab;

	// Token: 0x040011C0 RID: 4544
	public GameObject choiceStat2Prefab;

	// Token: 0x040011C1 RID: 4545
	public GameObject choiceStat3Prefab;

	// Token: 0x040011C2 RID: 4546
	public GameObject choiceStat4Prefab;

	// Token: 0x040011C3 RID: 4547
	public GameObject choiceStat5Prefab;

	// Token: 0x040011C4 RID: 4548
	public GameObject choiceStat6Prefab;

	// Token: 0x040011C5 RID: 4549
	public GameObject choicesPivot;

	// Token: 0x040011C6 RID: 4550
	public GameObject statPivot;

	// Token: 0x040011C7 RID: 4551
	public GameObject pausePivot;

	// Token: 0x040011C8 RID: 4552
	public GameObject premiumInfoPrefab;

	// Token: 0x040011C9 RID: 4553
	public GameObject stat0InfoPrefab;

	// Token: 0x040011CA RID: 4554
	public GameObject stat1InfoPrefab;

	// Token: 0x040011CB RID: 4555
	public GameObject stat2InfoPrefab;

	// Token: 0x040011CC RID: 4556
	public GameObject stat3InfoPrefab;

	// Token: 0x040011CD RID: 4557
	public GameObject stat4InfoPrefab;

	// Token: 0x040011CE RID: 4558
	public GameObject stat5InfoPrefab;

	// Token: 0x040011CF RID: 4559
	public GameObject stat6InfoPrefab;

	// Token: 0x040011D0 RID: 4560
	public RectTransform chatImageRectTransform;

	// Token: 0x040011D1 RID: 4561
	public GameObject fadeObject;

	// Token: 0x040011D2 RID: 4562
	private GameObject LOJHEKCOFME;

	// Token: 0x040011D3 RID: 4563
	private GameObject NGGBBCDPMJH;

	// Token: 0x040011D4 RID: 4564
	private List<GameObject> PDMKLEPMKLE = new List<GameObject>();

	// Token: 0x040011D5 RID: 4565
	private List<GameObject> AKFKCKHPIOA = new List<GameObject>();

	// Token: 0x040011D6 RID: 4566
	private List<GameObject> NDDGCFFDFJN = new List<GameObject>();

	// Token: 0x040011D7 RID: 4567
	private List<GameObject> LHNFPOJPFIJ = new List<GameObject>();

	// Token: 0x040011D8 RID: 4568
	private int FLBNNNDBECB = -1;

	// Token: 0x040011D9 RID: 4569
	private LJFIKKKBMDG IMPAHLIGELE;

	// Token: 0x040011DA RID: 4570
	private List<int> HNGBMIJHPLE = new List<int>();

	// Token: 0x040011DB RID: 4571
	private int AKJMKGCPCCB = -1;

	// Token: 0x040011DC RID: 4572
	private bool CIPGFJLECDH;

	// Token: 0x040011DD RID: 4573
	private PLFDAJJHMKO LMKDNPOKOBF;

	// Token: 0x040011DE RID: 4574
	public GameObject inputAnimationPivot;

	// Token: 0x040011DF RID: 4575
	public GameObject typeAnimationPivotNpc;

	// Token: 0x040011E0 RID: 4576
	public GameObject typeAnimationPivotPlayer;

	// Token: 0x040011E1 RID: 4577
	public Transform messagesContainer;

	// Token: 0x040011E2 RID: 4578
	public ScrollRect messagesScrollView;

	// Token: 0x040011E3 RID: 4579
	public GameObject playerMessagePrefab;

	// Token: 0x040011E4 RID: 4580
	public GameObject nonPlayerMessagePrefab;

	// Token: 0x040011E5 RID: 4581
	public GameObject systemMessagePrefab;

	// Token: 0x040011E6 RID: 4582
	public GameObject typeAnimationPrefab;

	// Token: 0x040011E7 RID: 4583
	public GameObject inputAnimationPrefab;

	// Token: 0x040011E8 RID: 4584
	public TextMeshProUGUI titleText;

	// Token: 0x040011E9 RID: 4585
	private CanvasGroup PANMNKKODPC;

	// Token: 0x040011EA RID: 4586
	private bool BFMOAOBMBOA;

	// Token: 0x040011EB RID: 4587
	private float BKAPJIOECCK;

	// Token: 0x040011EC RID: 4588
	private bool GMEAMOEADME;

	// Token: 0x040011ED RID: 4589
	private GameObject JEPKCMADMIN;

	// Token: 0x040011EE RID: 4590
	private bool MCKPNELJNIC;

	// Token: 0x040011EF RID: 4591
	private bool BPNGIDAMBEJ;
}
