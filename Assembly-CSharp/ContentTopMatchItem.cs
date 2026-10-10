using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020003D5 RID: 981
public class ContentTopMatchItem : MonoBehaviour
{
	// Token: 0x060071EC RID: 29164 RVA: 0x0033330E File Offset: 0x0033150E
	private void HEGACJIJHIJ()
	{
		this.BNPABBMJBIA = !this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x060071ED RID: 29165 RVA: 0x00333338 File Offset: 0x00331538
	public bool MFKDPFEGKMG(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "ok", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.title.text.EndsWith("OnPopupCardOptionsUnlockWithSpSuccessContinue"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "app42error", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		}
		this.thumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.HGFILJAIPEO(ACOLHLICHHG.PFFCLABCNHI, true);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(false);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 1)
		{
			this.unlocked.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 0)
		{
			this.upArrow.SetActive(true);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.MCCIJPDLMKN));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.NDKJNKCLKGN();
		return true;
	}

	// Token: 0x060071EE RID: 29166 RVA: 0x0033330E File Offset: 0x0033150E
	private void OAHEOPLNLME()
	{
		this.BNPABBMJBIA = !this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x060071EF RID: 29167 RVA: 0x003334CC File Offset: 0x003316CC
	private void HNPDAIBKJIO()
	{
		if (ContentTopMatchItem.LHFFFMJIFDM != 287f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentTopMatchItem.LHFFFMJIFDM = array[1].y - vector.y;
		ContentTopMatchItem.LHFFFMJIFDM += 773f;
	}

	// Token: 0x060071F0 RID: 29168 RVA: 0x0033330E File Offset: 0x0033150E
	private void KGDOLELAGAH()
	{
		this.BNPABBMJBIA = !this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x060071F1 RID: 29169 RVA: 0x00333530 File Offset: 0x00331730
	public void MJDCPDNMADN(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x060071F2 RID: 29170 RVA: 0x00333553 File Offset: 0x00331753
	private void DLBAEDOFAKM()
	{
		this.toggleButton.onClick.RemoveAllListeners();
		this.hide.onClick.RemoveAllListeners();
	}

	// Token: 0x060071F3 RID: 29171 RVA: 0x00333578 File Offset: 0x00331778
	public void CGJBINFGCBF(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x060071F4 RID: 29172 RVA: 0x0033359C File Offset: 0x0033179C
	private bool PLFLCHLCEHE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060071F5 RID: 29173 RVA: 0x003335F6 File Offset: 0x003317F6
	public void DBLMKBJCHGH()
	{
		this.BNPABBMJBIA = true;
		this.hide.gameObject.SetActive(true);
	}

	// Token: 0x060071F6 RID: 29174 RVA: 0x00333610 File Offset: 0x00331810
	private bool FNFKAKCADOJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060071F7 RID: 29175 RVA: 0x0033366C File Offset: 0x0033186C
	public void COKPNPABECJ()
	{
		this.NNLEPCNLKLO();
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x060071F8 RID: 29176 RVA: 0x003336AC File Offset: 0x003318AC
	public void GBLPLBBFLDP(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x060071F9 RID: 29177 RVA: 0x003336D0 File Offset: 0x003318D0
	public bool SetContent(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "%";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "lititle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (this.title.text.EndsWith("_not_found"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "lititle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		}
		this.thumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.HGFILJAIPEO(ACOLHLICHHG.PFFCLABCNHI, true);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(true);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 1)
		{
			this.unlocked.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 0)
		{
			this.upArrow.SetActive(true);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.NDBOCOPFHJO));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.NDKJNKCLKGN();
		return true;
	}

	// Token: 0x060071FA RID: 29178 RVA: 0x00333864 File Offset: 0x00331A64
	public void KELJCBEANBL()
	{
		this.BNPABBMJBIA = false;
		this.hide.gameObject.SetActive(false);
	}

	// Token: 0x060071FB RID: 29179 RVA: 0x00333880 File Offset: 0x00331A80
	public void HMJGFFKLFCF(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x060071FC RID: 29180 RVA: 0x00333553 File Offset: 0x00331753
	private void OnDestroy()
	{
		this.toggleButton.onClick.RemoveAllListeners();
		this.hide.onClick.RemoveAllListeners();
	}

	// Token: 0x060071FD RID: 29181 RVA: 0x003338A4 File Offset: 0x00331AA4
	private bool DNOJEDKGPGB()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060071FE RID: 29182 RVA: 0x00333900 File Offset: 0x00331B00
	public bool JHNALMOGJLO(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "\nEXCEPTION ";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "abs", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (this.title.text.EndsWith("CharacterTransitionManager - shader unsupported, falling back to crossfade:"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "0", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		}
		this.thumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.KAPKLPMOMEC(ACOLHLICHHG.PFFCLABCNHI, false);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(true);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 1)
		{
			this.unlocked.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 1)
		{
			this.upArrow.SetActive(true);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.OAHEOPLNLME));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.MOCBDNIBHLC();
		return false;
	}

	// Token: 0x060071FF RID: 29183 RVA: 0x00333A94 File Offset: 0x00331C94
	public bool GGNPLGJNJBA(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "Optional custom effects bundle failed to load, continuing without it:";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "OnFriendsGiftPopulCollectPart2", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (this.title.text.EndsWith("OnSketchViewShowWI"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "OnLobbyStartFireworksEffectAutoHide", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		}
		this.thumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.HGFILJAIPEO(ACOLHLICHHG.PFFCLABCNHI, true);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(false);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 1)
		{
			this.unlocked.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 1)
		{
			this.upArrow.SetActive(true);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.EJKHMCOCOHL));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.MKMMOFIHLFK();
		return false;
	}

	// Token: 0x06007200 RID: 29184 RVA: 0x00333C28 File Offset: 0x00331E28
	public void KLDLMHJLIEL()
	{
		this.UpdateHideState();
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x06007201 RID: 29185 RVA: 0x00333C67 File Offset: 0x00331E67
	private void EJKHMCOCOHL()
	{
		this.BNPABBMJBIA = this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x06007202 RID: 29186 RVA: 0x00333C90 File Offset: 0x00331E90
	private bool JMADOHNNPLP()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06007203 RID: 29187 RVA: 0x00333CEC File Offset: 0x00331EEC
	public void ResetOnUnhide()
	{
		this.UpdateHideState();
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x06007204 RID: 29188 RVA: 0x00333D2C File Offset: 0x00331F2C
	private void DFOBCCBLDJK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.FNFKAKCADOJ();
		this.background.SetActive(active);
	}

	// Token: 0x06007205 RID: 29189 RVA: 0x00333D70 File Offset: 0x00331F70
	public void MKCODFNINPA(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x06007206 RID: 29190 RVA: 0x00333D94 File Offset: 0x00331F94
	private void OLIACOCGJNA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.MMALIEFFBFO();
		this.background.SetActive(active);
	}

	// Token: 0x06007207 RID: 29191 RVA: 0x00333DD8 File Offset: 0x00331FD8
	private void NMEEMBCCKHA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.FNFKAKCADOJ();
		this.background.SetActive(active);
	}

	// Token: 0x06007208 RID: 29192 RVA: 0x00333E1C File Offset: 0x0033201C
	public bool IOPLLLDIKMP(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "...";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "anthology", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.title.text.EndsWith("mdtf"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "hoursshort", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		}
		this.thumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.EIMLGDBODGP(ACOLHLICHHG.PFFCLABCNHI, false);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(false);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.unlocked.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 1)
		{
			this.upArrow.SetActive(false);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.MCCIJPDLMKN));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.HNPDAIBKJIO();
		return false;
	}

	// Token: 0x06007209 RID: 29193 RVA: 0x00333FB0 File Offset: 0x003321B0
	public void DBDMJFFMOOP()
	{
		this.KELJCBEANBL();
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x0600720A RID: 29194 RVA: 0x00333FF0 File Offset: 0x003321F0
	private bool ADOPPDJOKDI()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600720B RID: 29195 RVA: 0x0033404C File Offset: 0x0033224C
	private void BODGLKJFBHM()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.background.SetActive(active);
	}

	// Token: 0x0600720C RID: 29196 RVA: 0x00334090 File Offset: 0x00332290
	public bool GIONKOFHDED(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 1).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "Error. InstantEnvironmentChange(), ambId is null or length is 0:";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "lck", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (this.title.text.EndsWith("ok"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "OnSceneLobbyManagerAssetsDownloadFailed", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		}
		this.thumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.HGFILJAIPEO(ACOLHLICHHG.PFFCLABCNHI, true);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(false);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 1)
		{
			this.unlocked.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 1)
		{
			this.upArrow.SetActive(false);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.NDBOCOPFHJO));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.MKMMOFIHLFK();
		return true;
	}

	// Token: 0x0600720D RID: 29197 RVA: 0x00334224 File Offset: 0x00332424
	private void MKMMOFIHLFK()
	{
		if (ContentTopMatchItem.LHFFFMJIFDM != 1110f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentTopMatchItem.LHFFFMJIFDM = array[0].y - vector.y;
		ContentTopMatchItem.LHFFFMJIFDM += 302f;
	}

	// Token: 0x0600720E RID: 29198 RVA: 0x0033330E File Offset: 0x0033150E
	private void MCCIJPDLMKN()
	{
		this.BNPABBMJBIA = !this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x0600720F RID: 29199 RVA: 0x00334288 File Offset: 0x00332488
	private void NPJIMHOPOGF()
	{
		if (ContentTopMatchItem.LHFFFMJIFDM != 1834f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentTopMatchItem.LHFFFMJIFDM = array[0].y - vector.y;
		ContentTopMatchItem.LHFFFMJIFDM += 863f;
	}

	// Token: 0x06007210 RID: 29200 RVA: 0x003342EC File Offset: 0x003324EC
	public void PDHFPIOLEFL(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x06007211 RID: 29201 RVA: 0x00333864 File Offset: 0x00331A64
	public void DKGPEDPJNCK()
	{
		this.BNPABBMJBIA = false;
		this.hide.gameObject.SetActive(false);
	}

	// Token: 0x06007212 RID: 29202 RVA: 0x00334310 File Offset: 0x00332510
	private void NDKJNKCLKGN()
	{
		if (ContentTopMatchItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentTopMatchItem.LHFFFMJIFDM = array[1].y - vector.y;
		ContentTopMatchItem.LHFFFMJIFDM += 1f;
	}

	// Token: 0x06007213 RID: 29203 RVA: 0x00334372 File Offset: 0x00332572
	public void NNLEPCNLKLO()
	{
		this.BNPABBMJBIA = true;
		this.hide.gameObject.SetActive(false);
	}

	// Token: 0x06007214 RID: 29204 RVA: 0x0033438C File Offset: 0x0033258C
	private void JAKPGAKGFHA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.NNELPFOLMED();
		this.background.SetActive(active);
	}

	// Token: 0x06007215 RID: 29205 RVA: 0x003343D0 File Offset: 0x003325D0
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06007216 RID: 29206 RVA: 0x0033442C File Offset: 0x0033262C
	public bool LHKLJOIGDBE(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, " ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.title.text.EndsWith("OnLanguageChange"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "rsind", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		}
		this.thumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.EIMLGDBODGP(ACOLHLICHHG.PFFCLABCNHI, true);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(true);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.unlocked.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 0)
		{
			this.downArrow.SetActive(true);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 1)
		{
			this.upArrow.SetActive(false);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.NDBOCOPFHJO));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.MKMMOFIHLFK();
		return true;
	}

	// Token: 0x06007217 RID: 29207 RVA: 0x003345C0 File Offset: 0x003327C0
	private bool MMALIEFFBFO()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06007218 RID: 29208 RVA: 0x0033461C File Offset: 0x0033281C
	public void NFHDCBCDKHI(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x06007219 RID: 29209 RVA: 0x00333864 File Offset: 0x00331A64
	public void AAGNJCJHBEL()
	{
		this.BNPABBMJBIA = false;
		this.hide.gameObject.SetActive(false);
	}

	// Token: 0x0600721A RID: 29210 RVA: 0x00333553 File Offset: 0x00331753
	private void JPPBJKKNIED()
	{
		this.toggleButton.onClick.RemoveAllListeners();
		this.hide.onClick.RemoveAllListeners();
	}

	// Token: 0x0600721B RID: 29211 RVA: 0x0033463F File Offset: 0x0033283F
	public void NIJGCFGOMFB()
	{
		this.BNPABBMJBIA = false;
		this.hide.gameObject.SetActive(true);
	}

	// Token: 0x0600721C RID: 29212 RVA: 0x0033330E File Offset: 0x0033150E
	private void GOKOEGAODAD()
	{
		this.BNPABBMJBIA = !this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x0600721E RID: 29214 RVA: 0x0033465C File Offset: 0x0033285C
	private void Update()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.background.SetActive(active);
	}

	// Token: 0x0600721F RID: 29215 RVA: 0x00334372 File Offset: 0x00332572
	public void BCDOJNAPFEM()
	{
		this.BNPABBMJBIA = true;
		this.hide.gameObject.SetActive(false);
	}

	// Token: 0x06007220 RID: 29216 RVA: 0x0033330E File Offset: 0x0033150E
	private void NDBOCOPFHJO()
	{
		this.BNPABBMJBIA = !this.BNPABBMJBIA;
		this.hide.gameObject.SetActive(this.BNPABBMJBIA);
	}

	// Token: 0x06007221 RID: 29217 RVA: 0x00333864 File Offset: 0x00331A64
	public void UpdateHideState()
	{
		this.BNPABBMJBIA = false;
		this.hide.gameObject.SetActive(false);
	}

	// Token: 0x06007222 RID: 29218 RVA: 0x003346A0 File Offset: 0x003328A0
	private bool HINGPJDKNCM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06007223 RID: 29219 RVA: 0x003346FC File Offset: 0x003328FC
	private bool NNELPFOLMED()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentTopMatchItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentTopMatchItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06007224 RID: 29220 RVA: 0x00334758 File Offset: 0x00332958
	public void PNIMPLNGNPM(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x06007225 RID: 29221 RVA: 0x00333553 File Offset: 0x00331753
	private void LDPOIIIAIOA()
	{
		this.toggleButton.onClick.RemoveAllListeners();
		this.hide.onClick.RemoveAllListeners();
	}

	// Token: 0x06007226 RID: 29222 RVA: 0x0033477C File Offset: 0x0033297C
	public void FIGCFIMDFLN()
	{
		this.DKGPEDPJNCK();
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x06007227 RID: 29223 RVA: 0x003347BC File Offset: 0x003329BC
	private void ADKKEBKIPJF()
	{
		if (ContentTopMatchItem.LHFFFMJIFDM != 325f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentTopMatchItem.LHFFFMJIFDM = array[1].y - vector.y;
		ContentTopMatchItem.LHFFFMJIFDM += 832f;
	}

	// Token: 0x06007228 RID: 29224 RVA: 0x00334820 File Offset: 0x00332A20
	private void MOCBDNIBHLC()
	{
		if (ContentTopMatchItem.LHFFFMJIFDM != 1504f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentTopMatchItem.LHFFFMJIFDM = array[0].y - vector.y;
		ContentTopMatchItem.LHFFFMJIFDM += 78f;
	}

	// Token: 0x06007229 RID: 29225 RVA: 0x00333553 File Offset: 0x00331753
	private void FGLAKBHMBFJ()
	{
		this.toggleButton.onClick.RemoveAllListeners();
		this.hide.onClick.RemoveAllListeners();
	}

	// Token: 0x0600722A RID: 29226 RVA: 0x00334884 File Offset: 0x00332A84
	public bool NMAFCCNIKLE(IMMKFHKEEBF ACOLHLICHHG, Vector2 ONKONHLJKPG, PMEPALPCEAF AEDICCFAKOM, UnityAction EICMPONIDCC, UnityAction FCPDEGHIGBJ)
	{
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
		this.percent.text = ACOLHLICHHG.BIBKFNMPHIK.ToString() + "sparklesbundles";
		this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.ODGNIFJGEHL, "socialgiftcollectinfodone", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (this.title.text.EndsWith("ok"))
		{
			this.title.text = GKJPOGNFKNK.DNILNCLIHAP(ACOLHLICHHG.PFFCLABCNHI, "not", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		}
		this.thumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.EIMLGDBODGP(ACOLHLICHHG.PFFCLABCNHI, true);
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.locked.SetActive(true);
		}
		if (ACOLHLICHHG.MJKICDJIFIP == 0)
		{
			this.unlocked.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO < 1)
		{
			this.downArrow.SetActive(false);
		}
		if (ACOLHLICHHG.KDODAAICNDO > 0)
		{
			this.upArrow.SetActive(false);
		}
		if (!AEDICCFAKOM.GIFPFPOPEJN && !AEDICCFAKOM.LAKHGAPCKBC)
		{
			this.toggleButton.onClick.AddListener(new UnityAction(this.OAHEOPLNLME));
			this.toggleButton.onClick.AddListener(EICMPONIDCC);
		}
		if (AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.toggleButton.onClick.AddListener(FCPDEGHIGBJ);
		}
		this.ADKKEBKIPJF();
		return false;
	}

	// Token: 0x0600722B RID: 29227 RVA: 0x00334A18 File Offset: 0x00332C18
	public void KJIFJOGIKLK()
	{
		this.KELJCBEANBL();
		this.GGICIBLJIKI = base.transform.GetSiblingIndex();
		this.orderNumber.text = (this.GGICIBLJIKI + 0).ToString();
	}

	// Token: 0x0600722C RID: 29228 RVA: 0x00334A58 File Offset: 0x00332C58
	public void IMLOGOCPJJJ(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x0600722D RID: 29229 RVA: 0x00334A7C File Offset: 0x00332C7C
	public void ResetIndexOrder(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x0600722E RID: 29230 RVA: 0x00334AA0 File Offset: 0x00332CA0
	public void JDBCIKINEAO(int GGICIBLJIKI)
	{
		this.orderNumber.text = (GGICIBLJIKI + 1).ToString();
	}

	// Token: 0x040021EA RID: 8682
	private static float LHFFFMJIFDM;

	// Token: 0x040021EB RID: 8683
	public Button hide;

	// Token: 0x040021EC RID: 8684
	[SerializeField]
	private TextMeshProUGUI orderNumber;

	// Token: 0x040021ED RID: 8685
	[SerializeField]
	private TextMeshProUGUI percent;

	// Token: 0x040021EE RID: 8686
	[SerializeField]
	private TextMeshProUGUI title;

	// Token: 0x040021EF RID: 8687
	[SerializeField]
	private Image thumb;

	// Token: 0x040021F0 RID: 8688
	[SerializeField]
	private GameObject background;

	// Token: 0x040021F1 RID: 8689
	[SerializeField]
	private GameObject locked;

	// Token: 0x040021F2 RID: 8690
	[SerializeField]
	private GameObject unlocked;

	// Token: 0x040021F3 RID: 8691
	[SerializeField]
	private GameObject upArrow;

	// Token: 0x040021F4 RID: 8692
	[SerializeField]
	private GameObject downArrow;

	// Token: 0x040021F5 RID: 8693
	[SerializeField]
	private Button toggleButton;

	// Token: 0x040021F6 RID: 8694
	private Vector2 ONKONHLJKPG;

	// Token: 0x040021F7 RID: 8695
	private int JFLPGONDKDB;

	// Token: 0x040021F8 RID: 8696
	private bool BNPABBMJBIA;

	// Token: 0x040021F9 RID: 8697
	private int GGICIBLJIKI;
}
