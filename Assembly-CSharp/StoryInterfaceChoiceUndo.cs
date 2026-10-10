using System;
using TMPro;
using UnityEngine;

// Token: 0x02000273 RID: 627
public class StoryInterfaceChoiceUndo : MonoBehaviour
{
	// Token: 0x06004C5B RID: 19547 RVA: 0x0021F17C File Offset: 0x0021D37C
	public void AGOLOLJOEAL(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "reward", false);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "id");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(false);
				return;
			}
			this.imageSign.SetActive(false);
		}
	}

	// Token: 0x06004C5C RID: 19548 RVA: 0x0021F1FC File Offset: 0x0021D3FC
	public void IHDBBIJJNBF()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C5D RID: 19549 RVA: 0x0021F220 File Offset: 0x0021D420
	public void JFJAMELFJAN(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 1277f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.PANMNKKODPC.alpha = 1786f;
		}
		if (this.PANMNKKODPC.alpha <= 594f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(true);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004C5E RID: 19550 RVA: 0x0021F2A9 File Offset: 0x0021D4A9
	public void OnButtonActionClick()
	{
		if (this.PANMNKKODPC.alpha > 0.1f)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceButtonUndoClick", 0f);
		}
	}

	// Token: 0x06004C5F RID: 19551 RVA: 0x0021F2D1 File Offset: 0x0021D4D1
	public void LPLIONODHAI(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(1731f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C60 RID: 19552 RVA: 0x0021F309 File Offset: 0x0021D509
	public void CKMMOLEMAGI()
	{
		if (this.PANMNKKODPC.alpha > 1801f)
		{
			AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("rt", 1248f);
		}
	}

	// Token: 0x06004C61 RID: 19553 RVA: 0x0021F331 File Offset: 0x0021D531
	public void OffsetVertical(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(0f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C62 RID: 19554 RVA: 0x0021F369 File Offset: 0x0021D569
	private void IFHJKBHODGG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C63 RID: 19555 RVA: 0x0021F1FC File Offset: 0x0021D3FC
	public void IPFFBNGLKBE()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C64 RID: 19556 RVA: 0x0021F39E File Offset: 0x0021D59E
	public void EKIFBDAKDKB(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(1431f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C65 RID: 19557 RVA: 0x0021F3D6 File Offset: 0x0021D5D6
	private void Update()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 0f;
			return;
		}
		this.PANMNKKODPC.alpha = 1f;
	}

	// Token: 0x06004C66 RID: 19558 RVA: 0x0021F408 File Offset: 0x0021D608
	public void EAPINJAIEMG(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 91f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 424f;
		}
		if (this.PANMNKKODPC.alpha <= 1258f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(false);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004C67 RID: 19559 RVA: 0x0021F494 File Offset: 0x0021D694
	public void SetText(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(false);
				return;
			}
			this.imageSign.SetActive(true);
		}
	}

	// Token: 0x06004C68 RID: 19560 RVA: 0x0021F514 File Offset: 0x0021D714
	public void LIGHPELLLFN(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 1341f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.PANMNKKODPC.alpha = 1320f;
		}
		if (this.PANMNKKODPC.alpha <= 660f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(false);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004C69 RID: 19561 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x06004C6A RID: 19562 RVA: 0x0021F369 File Offset: 0x0021D569
	private void DFEDGLDNOBH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C6B RID: 19563 RVA: 0x0021F59D File Offset: 0x0021D79D
	private void EMHDMMPMDJC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 66f;
			return;
		}
		this.PANMNKKODPC.alpha = 201f;
	}

	// Token: 0x06004C6C RID: 19564 RVA: 0x0021F5D0 File Offset: 0x0021D7D0
	public void EEGCDEGIDII(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "analogglitchovr_2", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(true);
		}
	}

	// Token: 0x06004C6D RID: 19565 RVA: 0x0021F650 File Offset: 0x0021D850
	private void HJKLMIHPEOB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 1739f;
			return;
		}
		this.PANMNKKODPC.alpha = 913f;
	}

	// Token: 0x06004C6E RID: 19566 RVA: 0x0021F369 File Offset: 0x0021D569
	private void OADBEGOCCBA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x0021F680 File Offset: 0x0021D880
	public void INLMKLLJABL(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "cleancache", false);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "p");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(false);
				return;
			}
			this.imageSign.SetActive(false);
		}
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x0021F700 File Offset: 0x0021D900
	public void JELAOLJGNGJ()
	{
		if (this.PANMNKKODPC.alpha > 807f)
		{
			AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("?", 476f);
		}
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x0021F728 File Offset: 0x0021D928
	public void JIGHFAEGHNM()
	{
		if (this.PANMNKKODPC.alpha > 720f)
		{
			AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("socialcreategiftcardtitle", 951f);
		}
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x0021F369 File Offset: 0x0021D569
	private void AOOANKECKCJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C73 RID: 19571 RVA: 0x0021F750 File Offset: 0x0021D950
	public void BNEJNIMOALM()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x0021F772 File Offset: 0x0021D972
	public void KNILAAEDIFF()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x0021F794 File Offset: 0x0021D994
	public void FOAAOKKNOGI(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 1594f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.PANMNKKODPC.alpha = 1701f;
		}
		if (this.PANMNKKODPC.alpha <= 1105f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(true);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
	}

	// Token: 0x06004C76 RID: 19574 RVA: 0x0021F820 File Offset: 0x0021DA20
	public void GLKMNAIEHNJ(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "oldvhs_2", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "NEWSAVE: Warning: Missing anthology save data, yet story save data (");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(true);
		}
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x0021F8A0 File Offset: 0x0021DAA0
	public void PNLMPIFAAIN()
	{
		if (this.PANMNKKODPC.alpha > 882f)
		{
			AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("orderid", 1152f);
		}
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x0021F8C8 File Offset: 0x0021DAC8
	public void HODHFPEBDBC()
	{
		if (this.PANMNKKODPC.alpha > 1027f)
		{
			AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("af_purchase", 1090f);
		}
	}

	// Token: 0x06004C79 RID: 19577 RVA: 0x0021F8F0 File Offset: 0x0021DAF0
	public void GLBCBNEDJBE()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C7A RID: 19578 RVA: 0x0021F912 File Offset: 0x0021DB12
	public void NJPMDHEHHPN()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x0021F934 File Offset: 0x0021DB34
	public void FOBGPCPBBMF(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(1525f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C7C RID: 19580 RVA: 0x0021F96C File Offset: 0x0021DB6C
	private void PAPNIONKJAP()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.PANMNKKODPC.alpha = 1139f;
			return;
		}
		this.PANMNKKODPC.alpha = 204f;
	}

	// Token: 0x06004C7D RID: 19581 RVA: 0x0021F99C File Offset: 0x0021DB9C
	public void MODKIBFCDED()
	{
		if (this.PANMNKKODPC.alpha > 74f)
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("yes", 967f);
		}
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x0021F9C4 File Offset: 0x0021DBC4
	public void DDNEPBJKCJI(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(467f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C7F RID: 19583 RVA: 0x0021F9FC File Offset: 0x0021DBFC
	public void NMCJJBNEJKK(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 307f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 1493f;
		}
		if (this.PANMNKKODPC.alpha <= 595f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(true);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004C80 RID: 19584 RVA: 0x0021FA85 File Offset: 0x0021DC85
	public void COEEAGIBGME()
	{
		if (this.PANMNKKODPC.alpha > 152f)
		{
			AOBJLALDBAA.NMGMNAKLLMI().EFBNBFIDEOK("aind", 960f);
		}
	}

	// Token: 0x06004C81 RID: 19585 RVA: 0x0021FAAD File Offset: 0x0021DCAD
	public void GGFODHMJMHC()
	{
		if (this.PANMNKKODPC.alpha > 807f)
		{
			AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("mfs", 593f);
		}
	}

	// Token: 0x06004C82 RID: 19586 RVA: 0x0021FAD5 File Offset: 0x0021DCD5
	public void HLPFBOJPACK()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004C83 RID: 19587 RVA: 0x0021FAF7 File Offset: 0x0021DCF7
	public void CDHFIMMCEKI()
	{
		if (this.PANMNKKODPC.alpha > 1572f)
		{
			AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("m_abortFlag = 2", 1159f);
		}
	}

	// Token: 0x06004C84 RID: 19588 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBCKGINANGF()
	{
	}

	// Token: 0x06004C85 RID: 19589 RVA: 0x0021FB20 File Offset: 0x0021DD20
	public void DJPPJCPPOME(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "steam", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "OnPopupProfileLoveInputEndEdit");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(true);
		}
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x0021F1FC File Offset: 0x0021D3FC
	public void CCFNNEJBBKD()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C87 RID: 19591 RVA: 0x0021FBA0 File Offset: 0x0021DDA0
	public void SetTransparency(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 1f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
		if (this.PANMNKKODPC.alpha <= 0.001f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(false);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x0021FC2C File Offset: 0x0021DE2C
	public void JGNMHKGNBAE(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "lightmodebtn0", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "friendspluschattutorialinactivebtn1");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(false);
		}
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x0021F912 File Offset: 0x0021DB12
	public void ShowButton()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x0021F1FC File Offset: 0x0021D3FC
	public void ABILINJKEBK()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C8B RID: 19595 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x06004C8C RID: 19596 RVA: 0x0021FCAC File Offset: 0x0021DEAC
	public void IFGFHCPMBMO()
	{
		if (this.PANMNKKODPC.alpha > 627f)
		{
			AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("af_currency", 831f);
		}
	}

	// Token: 0x06004C8D RID: 19597 RVA: 0x0021FCD4 File Offset: 0x0021DED4
	public void JCBICBLFKKJ(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "OnLoungePremiumChoiceSuccess", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "$ru");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(true);
		}
	}

	// Token: 0x06004C8E RID: 19598 RVA: 0x0021FD54 File Offset: 0x0021DF54
	public void PBIOKICCJDJ(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(1165f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C8F RID: 19599 RVA: 0x0021F369 File Offset: 0x0021D569
	private void MDNEOMGLGIN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x06004C91 RID: 19601 RVA: 0x0021F8F0 File Offset: 0x0021DAF0
	public void JLMOBCFKFIL()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C92 RID: 19602 RVA: 0x0021FD8C File Offset: 0x0021DF8C
	private void PNEBOIIJMDK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 1107f;
			return;
		}
		this.PANMNKKODPC.alpha = 775f;
	}

	// Token: 0x06004C93 RID: 19603 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOHKGEPBDIG()
	{
	}

	// Token: 0x06004C94 RID: 19604 RVA: 0x0021FDBC File Offset: 0x0021DFBC
	public void ELCFLIAAJPH()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C95 RID: 19605 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x06004C96 RID: 19606 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x0021F1FC File Offset: 0x0021D3FC
	public void AKGKJCBKNAD()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C98 RID: 19608 RVA: 0x0021F369 File Offset: 0x0021D569
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C99 RID: 19609 RVA: 0x0021F1FC File Offset: 0x0021D3FC
	public void HideButton()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004C9A RID: 19610 RVA: 0x0021FDDE File Offset: 0x0021DFDE
	private void BKNGGJFCHIK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 1366f;
			return;
		}
		this.PANMNKKODPC.alpha = 1660f;
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x0021FE10 File Offset: 0x0021E010
	public void EDGICEPFPFN(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "), skipped: last saveSync ack was ", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "OnGenericPopupManagerHide");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(false);
				return;
			}
			this.imageSign.SetActive(false);
		}
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x0021F369 File Offset: 0x0021D569
	private void OPPNHGEMHAB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x0021FE90 File Offset: 0x0021E090
	public void ODDELBMKEAP()
	{
		if (this.PANMNKKODPC.alpha > 775f)
		{
			AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("OnDialogReadInputEndEdit", 1228f);
		}
	}

	// Token: 0x06004C9E RID: 19614 RVA: 0x0021FEB8 File Offset: 0x0021E0B8
	public void PEEOLDOJLLP(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(450f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004C9F RID: 19615 RVA: 0x0021FEF0 File Offset: 0x0021E0F0
	public void EGIOBNBDCGM(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(1354f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004CA0 RID: 19616 RVA: 0x0021FDBC File Offset: 0x0021DFBC
	public void DOPONEKAIAL()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004CA1 RID: 19617 RVA: 0x0021FAD5 File Offset: 0x0021DCD5
	public void PFLPFJKEEDG()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004CA2 RID: 19618 RVA: 0x0021FF28 File Offset: 0x0021E128
	public void AAGDFKFEGOB(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(1981f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004CA3 RID: 19619 RVA: 0x0021FF60 File Offset: 0x0021E160
	private void KMEGABEIPBL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 1547f;
			return;
		}
		this.PANMNKKODPC.alpha = 1092f;
	}

	// Token: 0x06004CA4 RID: 19620 RVA: 0x00003E52 File Offset: 0x00002052
	private void JMCIGCLPJCA()
	{
	}

	// Token: 0x06004CA5 RID: 19621 RVA: 0x0021FAD5 File Offset: 0x0021DCD5
	public void KMMLCOEIEFK()
	{
		if (this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004CA6 RID: 19622 RVA: 0x0021FDBC File Offset: 0x0021DFBC
	public void FLEKFGGIIEG()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004CA7 RID: 19623 RVA: 0x0021FF90 File Offset: 0x0021E190
	public void HEPLCFCGOCA()
	{
		if (this.PANMNKKODPC.alpha > 708f)
		{
			AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("OnApplicationFocusBasicSyncSuccess", 209f);
		}
	}

	// Token: 0x06004CA8 RID: 19624 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFKPGJOMIOL()
	{
	}

	// Token: 0x06004CA9 RID: 19625 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004CAA RID: 19626 RVA: 0x0021F369 File Offset: 0x0021D569
	private void PMDCMEKGFNN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004CAB RID: 19627 RVA: 0x0021F369 File Offset: 0x0021D569
	private void PKJBCFKMGHE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004CAD RID: 19629 RVA: 0x0021F750 File Offset: 0x0021D950
	public void NLIEBEDMOGK()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = true;
	}

	// Token: 0x06004CAE RID: 19630 RVA: 0x0021FFC7 File Offset: 0x0021E1C7
	private void GKBKDDGBAGK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 1623f;
			return;
		}
		this.PANMNKKODPC.alpha = 1556f;
	}

	// Token: 0x06004CAF RID: 19631 RVA: 0x0021FFF7 File Offset: 0x0021E1F7
	public void AFMOIEEOBPK(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(856f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004CB0 RID: 19632 RVA: 0x00220030 File Offset: 0x0021E230
	public void GKHKIJMHJOE(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "body", false);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(false);
				return;
			}
			this.imageSign.SetActive(true);
		}
	}

	// Token: 0x06004CB1 RID: 19633 RVA: 0x002200B0 File Offset: 0x0021E2B0
	public void JFDMBIJDDAK(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(455f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004CB2 RID: 19634 RVA: 0x002200E8 File Offset: 0x0021E2E8
	public void INMCGPDDJEE(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 982f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.PANMNKKODPC.alpha = 165f;
		}
		if (this.PANMNKKODPC.alpha <= 1027f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(true);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004CB3 RID: 19635 RVA: 0x0021F369 File Offset: 0x0021D569
	private void HJMKOELKODM()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06004CB4 RID: 19636 RVA: 0x00220174 File Offset: 0x0021E374
	public void JLOLCGKNLDP(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 224f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.PANMNKKODPC.alpha = 790f;
		}
		if (this.PANMNKKODPC.alpha <= 1533f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(false);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
	}

	// Token: 0x06004CB5 RID: 19637 RVA: 0x00220200 File Offset: 0x0021E400
	public void LDHKCAFIJIG(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "hint7", true);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "_Strength");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(false);
		}
	}

	// Token: 0x06004CB6 RID: 19638 RVA: 0x00220280 File Offset: 0x0021E480
	public void LKIAJMEBJFM(float KJCLAIJCDIO)
	{
		this.PANMNKKODPC.alpha = 163f - KJCLAIJCDIO;
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.PANMNKKODPC.alpha = 1924f;
		}
		if (this.PANMNKKODPC.alpha <= 758f)
		{
			if (this.buttonAction.activeSelf)
			{
				this.buttonAction.SetActive(true);
				return;
			}
		}
		else if (this.LAECAJPGAMC && !this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
	}

	// Token: 0x06004CB7 RID: 19639 RVA: 0x0021FDBC File Offset: 0x0021DFBC
	public void IFHNIFAFGKD()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(false);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004CB8 RID: 19640 RVA: 0x00220309 File Offset: 0x0021E509
	public void MKKJPPJCILN()
	{
		if (!this.buttonAction.activeSelf)
		{
			this.buttonAction.SetActive(true);
		}
		this.LAECAJPGAMC = false;
	}

	// Token: 0x06004CB9 RID: 19641 RVA: 0x0022032B File Offset: 0x0021E52B
	public void OCEGDFOEAMF(float KJCLAIJCDIO, float CIHEONMCJCB)
	{
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		this.DGAAFGDHHHJ.AHLJBONHHKL(958f, KJCLAIJCDIO * CIHEONMCJCB);
	}

	// Token: 0x06004CBA RID: 19642 RVA: 0x00220364 File Offset: 0x0021E564
	public void OFDKGFIDLBO(int KIDHBAMJGDO, bool EGOHIHNHEOI)
	{
		if (this.BJDFLNIIDFA != KIDHBAMJGDO)
		{
			this.BJDFLNIIDFA = KIDHBAMJGDO;
			this.textCount.SetText(this.BJDFLNIIDFA.ToString() ?? "envlhrw", false);
			this.textCount.text = (this.BJDFLNIIDFA.ToString() ?? "cid");
			if (this.BJDFLNIIDFA == 0 && !EGOHIHNHEOI)
			{
				this.imageSign.SetActive(true);
				return;
			}
			this.imageSign.SetActive(false);
		}
	}

	// Token: 0x06004CBB RID: 19643 RVA: 0x002203E4 File Offset: 0x0021E5E4
	public void NONMMGLMNKG()
	{
		if (this.PANMNKKODPC.alpha > 984f)
		{
			AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("folder init done, cleaning failed cache entries: ", 433f);
		}
	}

	// Token: 0x04001604 RID: 5636
	public const string onStoryInterfaceButtonUndoClick = "OnStoryInterfaceButtonUndoClick";

	// Token: 0x04001605 RID: 5637
	public TextMeshProUGUI textCount;

	// Token: 0x04001606 RID: 5638
	public GameObject buttonAction;

	// Token: 0x04001607 RID: 5639
	public GameObject imageSign;

	// Token: 0x04001608 RID: 5640
	private int BJDFLNIIDFA = -1;

	// Token: 0x04001609 RID: 5641
	private Vector2 HCOLPEBENOF;

	// Token: 0x0400160A RID: 5642
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x0400160B RID: 5643
	private CanvasGroup PANMNKKODPC;

	// Token: 0x0400160C RID: 5644
	private bool LAECAJPGAMC;
}
