using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001C5 RID: 453
public class PopupStoryRestartManager : MonoBehaviour
{
	// Token: 0x060037DA RID: 14298 RVA: 0x00171DF4 File Offset: 0x0016FFF4
	public void IIJMOFEFKCN()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.LPKLANAEIFF() > 1 || LiveEventsManager.BBGECIKOICE().OPHKFJNACGB(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().OEHDOMDPHDN((EGMCEPOABBF)7, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("tutorialsigninrec", 208f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("NEWSAVE: Using new save system.", 1633f);
		this.AFENKJOMCML();
	}

	// Token: 0x060037DB RID: 14299 RVA: 0x00171E6C File Offset: 0x0017006C
	public void HHBPGAMBAAE(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IFCHGNCDMLJ = NLLCKPCKGOH;
		this.AADKBMMGFDF();
		for (int i = 0; i < this.varOldObjects.Count; i++)
		{
			this.varOldObjects[i].SetActive(false);
		}
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j += 0)
			{
				if (assetAnthology.header.availableStories[j] == JFCABBGNNKJ.index)
				{
					num = j;
					break;
				}
			}
		}
		this.storyRestartText.SetText(CCOJBMMKNAP.EHBBFMCILPC.FCOCLEHKLDJ("OnAccountForgetException") + "" + (num + 0).ToString(), false);
		this.storyRestartText0.SetText(CCOJBMMKNAP.INKJIBDDMLL().BDGPNPNIAPA("k") + "" + 0.ToString(), true);
		this.storyRestartTextOff.SetText(CCOJBMMKNAP.KFAABHHGOPO().BGELFMIOBCL("p") + "Removing duplicated cutscene data entry:" + (num + 0).ToString(), true);
		this.chapterRestartText.SetText(CCOJBMMKNAP.KFAABHHGOPO().OHLNGCKIACD("cind") + "OnSaveSlotDuplicateRequested" + (OLKMHHNMDLP + 1).ToString(), true);
		this.chapterRestartTextOff.SetText(CCOJBMMKNAP.CPCOODCFDDP().JLBEIFLLBLO("CameraEnvironmentsBack") + "" + (OLKMHHNMDLP + 0).ToString(), false);
		bool flag = true;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = true;
			if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, OLKMHHNMDLP))
			{
				this.currencyInfoEpisode.SetActive(false);
			}
			else
			{
				this.currencyInfoEpisode.SetActive(true);
			}
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.buttonRestartChapter.gameObject.SetActive(false);
		}
		else
		{
			this.currencyInfoEpisode.SetActive(true);
			this.buttonRestartChapterOff.gameObject.SetActive(true);
			this.buttonRestartChapter.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, 0))
		{
			this.currencyInfoSeason.SetActive(true);
		}
		else
		{
			this.currencyInfoSeason.SetActive(true);
		}
		this.buttonRestartStory.gameObject.SetActive(false);
		this.buttonRestartStoryOff.gameObject.SetActive(false);
		if (OLKMHHNMDLP == 0 && this.buttonRestartChapterOff.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(false);
			this.currencyInfoSeason.SetActive(false);
		}
		if (num == 0)
		{
			this.buttonRestartStory0.gameObject.SetActive(false);
		}
		else
		{
			this.buttonRestartStory0.gameObject.SetActive(false);
		}
		if (OLKMHHNMDLP == 0 && num > 0 && this.buttonRestartChapter.gameObject.activeSelf && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.currencyInfoEpisode.gameObject.SetActive(false);
		}
		if (num > 1 && this.buttonRestartChapter.gameObject.activeSelf)
		{
			this.currencyInfoEpisode.gameObject.SetActive(false);
		}
		if (num > 1 && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.currencyInfoSeason.gameObject.SetActive(true);
		}
		if (LiveEventsManager.OOGPALHPNGM().LBOPJBMIINE(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().LiveEventActive((EGMCEPOABBF)6, NLLCKPCKGOH, -1))
		{
			this.currencyInfoEpisode.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
		if (JFCABBGNNKJ.totalChaptersCount == 1 && !BAOKJBJIFBH.DHONIOBOLEL.GEMOAPPJPMP())
		{
			if (flag)
			{
				this.buttonRestartStory.gameObject.SetActive(false);
				this.buttonRestartStory0.gameObject.SetActive(true);
				this.buttonRestartStoryOff.gameObject.SetActive(false);
				this.currencyInfoSeason.gameObject.SetActive(true);
				return;
			}
			this.buttonRestartChapter.gameObject.SetActive(true);
			this.buttonRestartChapterOff.gameObject.SetActive(true);
			this.currencyInfoEpisode.SetActive(true);
			this.buttonRestartStory.gameObject.SetActive(false);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.storyRestartText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().HHLECNIFHCO("af_order_id"), false);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
	}

	// Token: 0x060037DC RID: 14300 RVA: 0x00172318 File Offset: 0x00170518
	public void FMMLEDHMEKE()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.NPEOEAFOPJP() > 0 || LiveEventsManager.BBGECIKOICE().HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BBGECIKOICE().LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("lstm", 1130f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("layervideo", 1589f);
		this.PMBIJMCONLE();
	}

	// Token: 0x060037DD RID: 14301 RVA: 0x00172390 File Offset: 0x00170590
	public bool ENIAALLOCEG(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		bool result;
		try
		{
			this.Initialize(JFCABBGNNKJ, BAOKJBJIFBH, OLKMHHNMDLP, NLLCKPCKGOH);
			if (this.buttonRestartChapterOff.gameObject.activeSelf && this.buttonRestartStoryOff.gameObject.activeSelf && !this.buttonRestartChapter.gameObject.activeSelf && !this.buttonRestartStory.gameObject.activeSelf && !this.buttonRestartStory0.gameObject.activeSelf)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060037DE RID: 14302 RVA: 0x00172424 File Offset: 0x00170624
	public void CDEICMLOHNH()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("", 920f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 0 || LiveEventsManager.OBOOKJPGBJN().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BBGECIKOICE().OEHDOMDPHDN(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("textsClient", 387f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("anthologycompletetitle", 253f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x060037DF RID: 14303 RVA: 0x001724C4 File Offset: 0x001706C4
	public void OAMEOLLPAFN()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("XXX", 1102f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 1 || LiveEventsManager.PIPOLIAKGDM().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BIAEAOMHBMM().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("json", 801f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("importanttitle", 906f);
		this.NHFEAMFBOIC();
	}

	// Token: 0x060037E0 RID: 14304 RVA: 0x00172562 File Offset: 0x00170762
	public void LFCEPINKDEE()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060037E1 RID: 14305 RVA: 0x00172562 File Offset: 0x00170762
	public void MOLFJIOCFIC()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060037E2 RID: 14306 RVA: 0x00172570 File Offset: 0x00170770
	public void DKCAFGMJFFO()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("RunCustomCode() repeat:", 567f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.CJLDJAJHMMA() > 0 || LiveEventsManager.EHBBFMCILPC.CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.NMGMNAKLLMI().LiveEventActive(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("XXX", 1728f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("laebs", 1145f);
		this.MMMBCEMOBPG();
	}

	// Token: 0x060037E3 RID: 14307 RVA: 0x00172610 File Offset: 0x00170810
	public void JPBDHFBBKLM()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("OnAccountSignInSuccess", 698f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MOBKGNBCIJF() > 0 || LiveEventsManager.OOGPALHPNGM().AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("socialbadgelocked", 1577f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(", index:", 253f);
		this.HHDLACJKDON();
	}

	// Token: 0x060037E4 RID: 14308 RVA: 0x001726B0 File Offset: 0x001708B0
	public void KJBJPPPEEBN()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.PONAPMOOLIN() > 1 || LiveEventsManager.ONCPHEEJLOP().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("$USEMAPPINGV2", 1829f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("<color=#FF7670>", 1360f);
		this.AKBFJMLJOHP();
	}

	// Token: 0x060037E5 RID: 14309 RVA: 0x00172727 File Offset: 0x00170927
	public void DHBCDGMFDMK()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("%>", 1440f);
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("OnPopupStoryRestartManagerRestartStory0", 1341f);
	}

	// Token: 0x060037E6 RID: 14310 RVA: 0x00172764 File Offset: 0x00170964
	public void ODFOJEDGBAE()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK(",", 1295f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BADNAGEMINF() > 1 || LiveEventsManager.JCMABFEMFKD().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OOGPALHPNGM().HLCKJEIFAFM(EGMCEPOABBF.liveEventBonusStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("shown", 1766f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("Environment ", 355f);
		this.EDAEKFNAJAH();
	}

	// Token: 0x060037E7 RID: 14311 RVA: 0x00172802 File Offset: 0x00170A02
	public void EOAJFGJAIIC()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("/", 515f);
	}

	// Token: 0x060037E8 RID: 14312 RVA: 0x00172818 File Offset: 0x00170A18
	public void GMBJCNLLIJM()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("string_not_found", 1689f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 1 || LiveEventsManager.PIPOLIAKGDM().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.JCMABFEMFKD().AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND(" not found.", 253f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("0.000", 1299f);
		this.PIPADCCGHBA();
	}

	// Token: 0x060037E9 RID: 14313 RVA: 0x00003E52 File Offset: 0x00002052
	private void EBBIFAMPCCI()
	{
	}

	// Token: 0x060037EA RID: 14314 RVA: 0x001728B8 File Offset: 0x00170AB8
	public void NMPJICCGLFO()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1 || LiveEventsManager.BIAEAOMHBMM().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OBOOKJPGBJN().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("", 965f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("ok", 166f);
		this.AFENKJOMCML();
	}

	// Token: 0x060037EB RID: 14315 RVA: 0x00172930 File Offset: 0x00170B30
	public void ICCDJFHOEEO()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MOBKGNBCIJF() > 0 || LiveEventsManager.BBGECIKOICE().CENBCALNAJN(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.GIPAKOPBBEO().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("ontradingcardclickbodyplayer", 712f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("HeaderAnthology", 1502f);
		this.AFENKJOMCML();
	}

	// Token: 0x060037EC RID: 14316 RVA: 0x001729A8 File Offset: 0x00170BA8
	public void EKIOOMMCGPC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.BBGECIKOICE().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.BIAEAOMHBMM().CENBCALNAJN((EGMCEPOABBF)6, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("skinshopall", 1572f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("OnBackendValidateTransactionFailed", 1305f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x060037ED RID: 14317 RVA: 0x00172A20 File Offset: 0x00170C20
	public void BAMMFNGFPIP()
	{
		for (int i = 1; i < this.varOldObjects.Count; i += 0)
		{
			this.varOldObjects[i].SetActive(false);
		}
		for (int j = 1; j < this.var1Objects.Count; j++)
		{
			this.var1Objects[j].SetActive(true);
		}
		for (int k = 0; k < this.var2Objects.Count; k += 0)
		{
			this.var2Objects[k].SetActive(false);
		}
		for (int l = 1; l < this.var3Objects.Count; l += 0)
		{
			this.var3Objects[l].SetActive(true);
		}
		for (int m = 1; m < this.var4Objects.Count; m += 0)
		{
			this.var4Objects[m].SetActive(false);
		}
		for (int n = 0; n < this.var5Objects.Count; n++)
		{
			this.var5Objects[n].SetActive(false);
		}
		for (int num = 0; num < this.var6Objects.Count; num++)
		{
			this.var6Objects[num].SetActive(false);
		}
		for (int num2 = 1; num2 < this.var7Objects.Count; num2++)
		{
			this.var7Objects[num2].SetActive(false);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3++)
		{
			this.var8Objects[num3].SetActive(true);
		}
		for (int num4 = 1; num4 < this.var9Objects.Count; num4 += 0)
		{
			this.var9Objects[num4].SetActive(true);
		}
		for (int num5 = 1; num5 < this.var10Objects.Count; num5 += 0)
		{
			this.var10Objects[num5].SetActive(true);
		}
		for (int num6 = 1; num6 < this.var11Objects.Count; num6++)
		{
			this.var11Objects[num6].SetActive(true);
		}
		for (int num7 = 0; num7 < this.var12Objects.Count; num7 += 0)
		{
			this.var12Objects[num7].SetActive(false);
		}
		for (int num8 = 1; num8 < this.var13Objects.Count; num8 += 0)
		{
			this.var13Objects[num8].SetActive(true);
		}
		for (int num9 = 1; num9 < this.var14Objects.Count; num9 += 0)
		{
			this.var14Objects[num9].SetActive(true);
		}
		for (int num10 = 1; num10 < this.var15Objects.Count; num10 += 0)
		{
			this.var15Objects[num10].SetActive(false);
		}
		for (int num11 = 0; num11 < this.var16Objects.Count; num11 += 0)
		{
			this.var16Objects[num11].SetActive(true);
		}
		for (int num12 = 1; num12 < this.var17Objects.Count; num12 += 0)
		{
			this.var17Objects[num12].SetActive(false);
		}
		for (int num13 = 1; num13 < this.var18Objects.Count; num13++)
		{
			this.var18Objects[num13].SetActive(true);
		}
		for (int num14 = 0; num14 < this.var19Objects.Count; num14 += 0)
		{
			this.var19Objects[num14].SetActive(true);
		}
		for (int num15 = 0; num15 < this.var20Objects.Count; num15++)
		{
			this.var20Objects[num15].SetActive(false);
		}
	}

	// Token: 0x060037EE RID: 14318 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void HHDLACJKDON()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x060037EF RID: 14319 RVA: 0x00172DD8 File Offset: 0x00170FD8
	public void MHDHEJOFMDL()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("<space=0.125em>", 914f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 1 || LiveEventsManager.OOGPALHPNGM().LBOPJBMIINE(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.OOGPALHPNGM().LiveEventActive(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("", 1521f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("skinshopinfoidentity", 1810f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x060037F0 RID: 14320 RVA: 0x00172E76 File Offset: 0x00171076
	public void PGDKHKALHNO()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("OnRewardFreeSpinsClick", 164f);
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("acli20", 964f);
	}

	// Token: 0x060037F1 RID: 14321 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060037F2 RID: 14322 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x060037F3 RID: 14323 RVA: 0x00172EB4 File Offset: 0x001710B4
	public void BFPICCKOBEK()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("aind", 238f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 0 || LiveEventsManager.JCMABFEMFKD().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().EFBNBFIDEOK("", 1971f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("age", 105f);
		this.Hide();
	}

	// Token: 0x060037F4 RID: 14324 RVA: 0x00172F54 File Offset: 0x00171154
	public void NewRestartStory2Tea()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory2", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x060037F5 RID: 14325 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void EBBKBGAGLAM()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x060037F6 RID: 14326 RVA: 0x00172FCB File Offset: 0x001711CB
	public void ECIBMLEHMAE()
	{
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("AdsManagerLP: Received RewardedVideoOnAdRewardedEvent", 1634f);
	}

	// Token: 0x060037F7 RID: 14327 RVA: 0x00172FE4 File Offset: 0x001711E4
	public void JFGOANPMJEL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 1 || LiveEventsManager.OBOOKJPGBJN().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.GIPAKOPBBEO().LiveEventActive(EGMCEPOABBF.liveEventFreeDiamonds, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("%", 1940f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("abs", 774f);
		this.PIPADCCGHBA();
	}

	// Token: 0x060037F8 RID: 14328 RVA: 0x00172562 File Offset: 0x00170762
	public void OCHCJLJEAGF()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060037F9 RID: 14329 RVA: 0x00172562 File Offset: 0x00170762
	public void Hide()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060037FA RID: 14330 RVA: 0x0017305C File Offset: 0x0017125C
	public void GKIECFKOHHD()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("socialtop", 212f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.KGEGKPHEMOJ() > 1 || LiveEventsManager.OOGPALHPNGM().OPHKFJNACGB(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BIAEAOMHBMM().AJKBOOKAPBL((EGMCEPOABBF)8, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("var", 15f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG(". Retrieving persistent save data is impossible.", 108f);
		this.NHFEAMFBOIC();
	}

	// Token: 0x060037FB RID: 14331 RVA: 0x001730FC File Offset: 0x001712FC
	public void DPGAELFHIEG()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.KGEGKPHEMOJ() > 0 || LiveEventsManager.ONCPHEEJLOP().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OBOOKJPGBJN().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("itemstitle", 1962f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("p", 231f);
		this.AFENKJOMCML();
	}

	// Token: 0x060037FC RID: 14332 RVA: 0x00173174 File Offset: 0x00171374
	public void JNAKOEBOCAB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.BIAEAOMHBMM().HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.JCMABFEMFKD().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI(" is already loaded elsewhere", 1478f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("OSX", 165f);
		this.HHDLACJKDON();
	}

	// Token: 0x060037FD RID: 14333 RVA: 0x001731EB File Offset: 0x001713EB
	public void BGEDCCBNMJB()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("[LoadingEnv] loading theme set: ", 1031f);
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("eventIsHidden", 303f);
	}

	// Token: 0x060037FE RID: 14334 RVA: 0x00173228 File Offset: 0x00171428
	public void KBFPAJJADBL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.LPKLANAEIFF() > 1 || LiveEventsManager.ONCPHEEJLOP().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.ONCPHEEJLOP().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeAvatar, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("〃", 835f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("tids", 1995f);
		this.NHFEAMFBOIC();
	}

	// Token: 0x060037FF RID: 14335 RVA: 0x0017329F File Offset: 0x0017149F
	public void AEMNFMAPPEM()
	{
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("blur", 1182f);
	}

	// Token: 0x06003800 RID: 14336 RVA: 0x001732B8 File Offset: 0x001714B8
	public void JFOMKMMEGJM()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG(", index:", 728f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.HOJDOEDDIBD() > 1 || LiveEventsManager.PIPOLIAKGDM().AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.PIPOLIAKGDM().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("SceneLobbyManager2._DownloadLiveProfileThemesBackground(): downloading live profile themes ", 1763f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("sid", 1486f);
		this.HHDLACJKDON();
	}

	// Token: 0x06003801 RID: 14337 RVA: 0x00173358 File Offset: 0x00171558
	public void AIAECLMKCEM()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 1 || LiveEventsManager.BBGECIKOICE().LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.JCMABFEMFKD().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess", 779f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("", 1860f);
		this.OMPKGJDLLAB();
	}

	// Token: 0x06003802 RID: 14338 RVA: 0x001733D0 File Offset: 0x001715D0
	public void LNIFHALMGJF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.LPKLANAEIFF() > 1 || LiveEventsManager.OBOOKJPGBJN().LiveEventActive(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.OOGPALHPNGM().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeDiamonds, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("/", 597f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("ok", 580f);
		this.Hide();
	}

	// Token: 0x06003803 RID: 14339 RVA: 0x00173448 File Offset: 0x00171648
	public void IDALOEMCENJ(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IEDKBEACDAF();
		int num = 1;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				if (assetAnthology.header.availableStories[i] == JFCABBGNNKJ.index)
				{
					num = i;
					break;
				}
			}
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.MLIDICIPNDK(assetAnthology.header.index);
		if (eioplefllim.EGHHCFFLPCP(-1) == 1 && eioplefllim.EKONMCADECD(-1) == assetAnthology.header.maxStories)
		{
			for (int j = 0; j < this.var3Objects.Count; j += 0)
			{
				this.var3Objects[j].SetActive(true);
			}
			return;
		}
		if (eioplefllim.JDCFLEOBCMC(-1) == 2 && eioplefllim.ENAJCKIAJFK(-1) == assetAnthology.header.maxStories)
		{
			for (int k = 0; k < this.var7Objects.Count; k += 0)
			{
				this.var7Objects[k].SetActive(true);
			}
			return;
		}
		if (eioplefllim.JDCFLEOBCMC(-1) == 0 && eioplefllim.EBNCOCHCHGN(-1) == assetAnthology.header.maxStories)
		{
			for (int l = 0; l < this.var11Objects.Count; l += 0)
			{
				this.var11Objects[l].SetActive(true);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 7 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int m = 0; m < this.var15Objects.Count; m += 0)
			{
				this.var15Objects[m].SetActive(false);
			}
			return;
		}
		if (eioplefllim.JDCFLEOBCMC(-1) == 7 && eioplefllim.ENAJCKIAJFK(-1) == assetAnthology.header.maxStories)
		{
			for (int n = 0; n < this.var19Objects.Count; n++)
			{
				this.var19Objects[n].SetActive(true);
			}
			return;
		}
		bool flag = false;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = true;
		}
		if (num == 0)
		{
			if (!flag)
			{
				for (int num2 = 1; num2 < this.var3Objects.Count; num2 += 0)
				{
					this.var3Objects[num2].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num3 = 0; num3 < this.var1Objects.Count; num3 += 0)
				{
					this.var1Objects[num3].SetActive(false);
				}
				return;
			}
			for (int num4 = 0; num4 < this.var2Objects.Count; num4 += 0)
			{
				this.var2Objects[num4].SetActive(false);
			}
			return;
		}
		else if (num == 1)
		{
			if (flag)
			{
				for (int num5 = 1; num5 < this.var6Objects.Count; num5 += 0)
				{
					this.var6Objects[num5].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num6 = 1; num6 < this.var5Objects.Count; num6++)
				{
					this.var5Objects[num6].SetActive(true);
				}
				return;
			}
			for (int num7 = 1; num7 < this.var7Objects.Count; num7++)
			{
				this.var7Objects[num7].SetActive(false);
			}
			return;
		}
		else if (num == 4)
		{
			if (flag)
			{
				for (int num8 = 1; num8 < this.var10Objects.Count; num8 += 0)
				{
					this.var10Objects[num8].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num9 = 1; num9 < this.var9Objects.Count; num9 += 0)
				{
					this.var9Objects[num9].SetActive(false);
				}
				return;
			}
			for (int num10 = 1; num10 < this.var11Objects.Count; num10 += 0)
			{
				this.var11Objects[num10].SetActive(true);
			}
			return;
		}
		else
		{
			if (num != 2)
			{
				if (num == 3)
				{
					if (flag)
					{
						for (int num11 = 1; num11 < this.var18Objects.Count; num11++)
						{
							this.var18Objects[num11].SetActive(false);
						}
						return;
					}
					if (OLKMHHNMDLP == 0)
					{
						for (int num12 = 0; num12 < this.var17Objects.Count; num12 += 0)
						{
							this.var17Objects[num12].SetActive(true);
						}
						return;
					}
					for (int num13 = 1; num13 < this.var19Objects.Count; num13 += 0)
					{
						this.var19Objects[num13].SetActive(true);
					}
				}
				return;
			}
			if (flag)
			{
				for (int num14 = 1; num14 < this.var14Objects.Count; num14++)
				{
					this.var14Objects[num14].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num15 = 1; num15 < this.var13Objects.Count; num15 += 0)
				{
					this.var13Objects[num15].SetActive(true);
				}
				return;
			}
			for (int num16 = 1; num16 < this.var15Objects.Count; num16 += 0)
			{
				this.var15Objects[num16].SetActive(true);
			}
			return;
		}
	}

	// Token: 0x06003804 RID: 14340 RVA: 0x00173947 File Offset: 0x00171B47
	public void ILDJFEOFMGG()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("mypsuspendedbody", 1774f);
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("importanttitle", 477f);
	}

	// Token: 0x06003805 RID: 14341 RVA: 0x00172562 File Offset: 0x00170762
	public void NJDHLGBEPBE()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003806 RID: 14342 RVA: 0x00173984 File Offset: 0x00171B84
	public void NewRestartChapterTea()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartChapter", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x06003807 RID: 14343 RVA: 0x001739FC File Offset: 0x00171BFC
	public void IOOEJJOKIMC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 1 || LiveEventsManager.GIPAKOPBBEO().LiveEventActive(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.GIPAKOPBBEO().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND(" not found.", 298f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("<alpha=#FF><align=\"left\">", 1402f);
		this.OCHCJLJEAGF();
	}

	// Token: 0x06003808 RID: 14344 RVA: 0x00173A74 File Offset: 0x00171C74
	public void DAGECLLDIKI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MOBKGNBCIJF() > 1 || LiveEventsManager.JCMABFEMFKD().HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.GIPAKOPBBEO().OPHKFJNACGB(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("prof", 1780f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("", 321f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x06003809 RID: 14345 RVA: 0x00173AEC File Offset: 0x00171CEC
	public void LIIDMFNOHPD()
	{
		for (int i = 0; i < this.varOldObjects.Count; i += 0)
		{
			this.varOldObjects[i].SetActive(true);
		}
		for (int j = 1; j < this.var1Objects.Count; j++)
		{
			this.var1Objects[j].SetActive(true);
		}
		for (int k = 1; k < this.var2Objects.Count; k += 0)
		{
			this.var2Objects[k].SetActive(true);
		}
		for (int l = 0; l < this.var3Objects.Count; l += 0)
		{
			this.var3Objects[l].SetActive(false);
		}
		for (int m = 1; m < this.var4Objects.Count; m++)
		{
			this.var4Objects[m].SetActive(true);
		}
		for (int n = 1; n < this.var5Objects.Count; n += 0)
		{
			this.var5Objects[n].SetActive(true);
		}
		for (int num = 0; num < this.var6Objects.Count; num++)
		{
			this.var6Objects[num].SetActive(true);
		}
		for (int num2 = 0; num2 < this.var7Objects.Count; num2++)
		{
			this.var7Objects[num2].SetActive(false);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3 += 0)
		{
			this.var8Objects[num3].SetActive(true);
		}
		for (int num4 = 1; num4 < this.var9Objects.Count; num4++)
		{
			this.var9Objects[num4].SetActive(false);
		}
		for (int num5 = 1; num5 < this.var10Objects.Count; num5++)
		{
			this.var10Objects[num5].SetActive(true);
		}
		for (int num6 = 1; num6 < this.var11Objects.Count; num6 += 0)
		{
			this.var11Objects[num6].SetActive(true);
		}
		for (int num7 = 1; num7 < this.var12Objects.Count; num7 += 0)
		{
			this.var12Objects[num7].SetActive(false);
		}
		for (int num8 = 0; num8 < this.var13Objects.Count; num8 += 0)
		{
			this.var13Objects[num8].SetActive(false);
		}
		for (int num9 = 0; num9 < this.var14Objects.Count; num9 += 0)
		{
			this.var14Objects[num9].SetActive(false);
		}
		for (int num10 = 1; num10 < this.var15Objects.Count; num10++)
		{
			this.var15Objects[num10].SetActive(true);
		}
		for (int num11 = 1; num11 < this.var16Objects.Count; num11++)
		{
			this.var16Objects[num11].SetActive(true);
		}
		for (int num12 = 0; num12 < this.var17Objects.Count; num12 += 0)
		{
			this.var17Objects[num12].SetActive(true);
		}
		for (int num13 = 0; num13 < this.var18Objects.Count; num13 += 0)
		{
			this.var18Objects[num13].SetActive(false);
		}
		for (int num14 = 1; num14 < this.var19Objects.Count; num14++)
		{
			this.var19Objects[num14].SetActive(true);
		}
		for (int num15 = 1; num15 < this.var20Objects.Count; num15 += 0)
		{
			this.var20Objects[num15].SetActive(false);
		}
	}

	// Token: 0x0600380A RID: 14346 RVA: 0x00173E98 File Offset: 0x00172098
	public void MJIBDOJHDEF()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("%", 1838f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BADNAGEMINF() > 0 || LiveEventsManager.NMGMNAKLLMI().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.BIAEAOMHBMM().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("WWW", 1149f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("\"", 1024f);
		this.NHFEAMFBOIC();
	}

	// Token: 0x0600380B RID: 14347 RVA: 0x00173F38 File Offset: 0x00172138
	public void EIGHGNHOIGF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MOBKGNBCIJF() > 0 || LiveEventsManager.EHBBFMCILPC.AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BBGECIKOICE().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("", 992f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("There needs to be one active UserpassSignInManager script on a GameObject in your scene.", 1894f);
		this.AKBFJMLJOHP();
	}

	// Token: 0x0600380C RID: 14348 RVA: 0x00173FB0 File Offset: 0x001721B0
	public void OKKAFFJIMAP()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BADNAGEMINF() > 1 || LiveEventsManager.EHBBFMCILPC.HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.PIPOLIAKGDM().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("psk", 1873f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("bver", 101f);
		this.PMBIJMCONLE();
	}

	// Token: 0x0600380D RID: 14349 RVA: 0x00174028 File Offset: 0x00172228
	public void JJJJLLFMNFC(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.AADKBMMGFDF();
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				if (assetAnthology.header.availableStories[i] == JFCABBGNNKJ.index)
				{
					num = i;
					break;
				}
			}
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.EDHKCJCAFIO(assetAnthology.header.index);
		if (eioplefllim.ENAJCKIAJFK(-1) == 1 && eioplefllim.EBNCOCHCHGN(-1) == assetAnthology.header.maxStories)
		{
			for (int j = 1; j < this.var3Objects.Count; j += 0)
			{
				this.var3Objects[j].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EBNCOCHCHGN(-1) == 4 && eioplefllim.EBNCOCHCHGN(-1) == assetAnthology.header.maxStories)
		{
			for (int k = 0; k < this.var7Objects.Count; k += 0)
			{
				this.var7Objects[k].SetActive(true);
			}
			return;
		}
		if (eioplefllim.JDCFLEOBCMC(-1) == 7 && eioplefllim.EKONMCADECD(-1) == assetAnthology.header.maxStories)
		{
			for (int l = 1; l < this.var11Objects.Count; l += 0)
			{
				this.var11Objects[l].SetActive(false);
			}
			return;
		}
		if (eioplefllim.ENAJCKIAJFK(-1) == 6 && eioplefllim.EOHGNGFHNAP(-1) == assetAnthology.header.maxStories)
		{
			for (int m = 1; m < this.var15Objects.Count; m += 0)
			{
				this.var15Objects[m].SetActive(false);
			}
			return;
		}
		if (eioplefllim.ENAJCKIAJFK(-1) == 4 && eioplefllim.EKONMCADECD(-1) == assetAnthology.header.maxStories)
		{
			for (int n = 1; n < this.var19Objects.Count; n++)
			{
				this.var19Objects[n].SetActive(true);
			}
			return;
		}
		bool flag = true;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = true;
		}
		if (num == 0)
		{
			if (!flag)
			{
				for (int num2 = 1; num2 < this.var3Objects.Count; num2 += 0)
				{
					this.var3Objects[num2].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num3 = 0; num3 < this.var1Objects.Count; num3++)
				{
					this.var1Objects[num3].SetActive(true);
				}
				return;
			}
			for (int num4 = 0; num4 < this.var2Objects.Count; num4 += 0)
			{
				this.var2Objects[num4].SetActive(true);
			}
			return;
		}
		else if (num == 1)
		{
			if (flag)
			{
				for (int num5 = 1; num5 < this.var6Objects.Count; num5 += 0)
				{
					this.var6Objects[num5].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num6 = 1; num6 < this.var5Objects.Count; num6 += 0)
				{
					this.var5Objects[num6].SetActive(false);
				}
				return;
			}
			for (int num7 = 1; num7 < this.var7Objects.Count; num7++)
			{
				this.var7Objects[num7].SetActive(true);
			}
			return;
		}
		else if (num == 2)
		{
			if (flag)
			{
				for (int num8 = 1; num8 < this.var10Objects.Count; num8++)
				{
					this.var10Objects[num8].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num9 = 1; num9 < this.var9Objects.Count; num9++)
				{
					this.var9Objects[num9].SetActive(false);
				}
				return;
			}
			for (int num10 = 0; num10 < this.var11Objects.Count; num10++)
			{
				this.var11Objects[num10].SetActive(false);
			}
			return;
		}
		else
		{
			if (num != 5)
			{
				if (num == 1)
				{
					if (flag)
					{
						for (int num11 = 1; num11 < this.var18Objects.Count; num11 += 0)
						{
							this.var18Objects[num11].SetActive(false);
						}
						return;
					}
					if (OLKMHHNMDLP == 0)
					{
						for (int num12 = 1; num12 < this.var17Objects.Count; num12++)
						{
							this.var17Objects[num12].SetActive(false);
						}
						return;
					}
					for (int num13 = 1; num13 < this.var19Objects.Count; num13++)
					{
						this.var19Objects[num13].SetActive(true);
					}
				}
				return;
			}
			if (flag)
			{
				for (int num14 = 0; num14 < this.var14Objects.Count; num14++)
				{
					this.var14Objects[num14].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num15 = 0; num15 < this.var13Objects.Count; num15++)
				{
					this.var13Objects[num15].SetActive(true);
				}
				return;
			}
			for (int num16 = 1; num16 < this.var15Objects.Count; num16++)
			{
				this.var15Objects[num16].SetActive(true);
			}
			return;
		}
	}

	// Token: 0x0600380E RID: 14350 RVA: 0x00174528 File Offset: 0x00172728
	public void JHIANBJMNLP()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 0 || LiveEventsManager.JCMABFEMFKD().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.CENBCALNAJN(EGMCEPOABBF.liveEventFreeAvatar, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().EFBNBFIDEOK("OnBackendGetPublicProfileSuccess", 429f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND(" DIRECT CACHE FILES path SUCCEEDED: chain loaded from the recorded cache files", 559f);
		this.OMPKGJDLLAB();
	}

	// Token: 0x0600380F RID: 14351 RVA: 0x001745A0 File Offset: 0x001727A0
	public void DAJAMILFHPA()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("yes", 989f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MDJHNAEGCCM() > 1 || LiveEventsManager.EHBBFMCILPC.OEHDOMDPHDN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.OOGPALHPNGM().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("prir", 1656f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("〉", 834f);
		this.LFCEPINKDEE();
	}

	// Token: 0x06003810 RID: 14352 RVA: 0x00174640 File Offset: 0x00172840
	public void LIFELEFKJNB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 0 || LiveEventsManager.OBOOKJPGBJN().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.NMGMNAKLLMI().PKHPPBPKOEE((EGMCEPOABBF)6, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("<i>", 1785f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("favchrstr", 117f);
		this.MMMBCEMOBPG();
	}

	// Token: 0x06003811 RID: 14353 RVA: 0x001746B8 File Offset: 0x001728B8
	public void FNBDBMLBCOH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 0 || LiveEventsManager.BBGECIKOICE().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.BIAEAOMHBMM().LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("importanttitle", 1547f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("rep", 485f);
		this.NJDHLGBEPBE();
	}

	// Token: 0x06003812 RID: 14354 RVA: 0x00174730 File Offset: 0x00172930
	public void HGELPFDIMJK(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IFCHGNCDMLJ = NLLCKPCKGOH;
		this.LLIHNPELOJD();
		for (int i = 1; i < this.varOldObjects.Count; i += 0)
		{
			this.varOldObjects[i].SetActive(false);
		}
		int num = 1;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j += 0)
			{
				if (assetAnthology.header.availableStories[j] == JFCABBGNNKJ.index)
				{
					num = j;
					break;
				}
			}
		}
		this.storyRestartText.SetText(CCOJBMMKNAP.EHBBFMCILPC.JCDFHKDNEDH("$e1ro") + "There needs to be one active LobbyUserInterface script on a GameObject in your scene." + (num + 1).ToString(), true);
		this.storyRestartText0.SetText(CCOJBMMKNAP.ONCPHEEJLOP().OHLNGCKIACD("dr") + "pmtsuccess" + 1.ToString(), false);
		this.storyRestartTextOff.SetText(CCOJBMMKNAP.INKJIBDDMLL().JLBEIFLLBLO("sparkles") + "XXX" + (num + 1).ToString(), true);
		this.chapterRestartText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().HHLECNIFHCO("err") + "" + (OLKMHHNMDLP + 0).ToString(), false);
		this.chapterRestartTextOff.SetText(CCOJBMMKNAP.BBGECIKOICE().HPOAGPJFHPM("") + "errortitle" + (OLKMHHNMDLP + 0).ToString(), true);
		bool flag = false;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = false;
			if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, OLKMHHNMDLP))
			{
				this.currencyInfoEpisode.SetActive(true);
			}
			else
			{
				this.currencyInfoEpisode.SetActive(false);
			}
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.buttonRestartChapter.gameObject.SetActive(true);
		}
		else
		{
			this.currencyInfoEpisode.SetActive(true);
			this.buttonRestartChapterOff.gameObject.SetActive(true);
			this.buttonRestartChapter.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, 0))
		{
			this.currencyInfoSeason.SetActive(false);
		}
		else
		{
			this.currencyInfoSeason.SetActive(false);
		}
		this.buttonRestartStory.gameObject.SetActive(true);
		this.buttonRestartStoryOff.gameObject.SetActive(true);
		if (OLKMHHNMDLP == 0 && this.buttonRestartChapterOff.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(false);
			this.buttonRestartStoryOff.gameObject.SetActive(false);
			this.currencyInfoSeason.SetActive(true);
		}
		if (num == 0)
		{
			this.buttonRestartStory0.gameObject.SetActive(true);
		}
		else
		{
			this.buttonRestartStory0.gameObject.SetActive(false);
		}
		if (OLKMHHNMDLP == 0 && num > 0 && this.buttonRestartChapter.gameObject.activeSelf && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.currencyInfoEpisode.gameObject.SetActive(false);
		}
		if (num > 1 && this.buttonRestartChapter.gameObject.activeSelf)
		{
			this.currencyInfoEpisode.gameObject.SetActive(false);
		}
		if (num > 0 && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
		if (LiveEventsManager.PIPOLIAKGDM().LBOPJBMIINE(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.PIPOLIAKGDM().LBOPJBMIINE((EGMCEPOABBF)6, NLLCKPCKGOH, -1))
		{
			this.currencyInfoEpisode.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
		if (JFCABBGNNKJ.totalChaptersCount == 0 && !BAOKJBJIFBH.DHONIOBOLEL.KBKMOCINBEB())
		{
			if (flag)
			{
				this.buttonRestartStory.gameObject.SetActive(true);
				this.buttonRestartStory0.gameObject.SetActive(true);
				this.buttonRestartStoryOff.gameObject.SetActive(true);
				this.currencyInfoSeason.gameObject.SetActive(true);
				return;
			}
			this.buttonRestartChapter.gameObject.SetActive(true);
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.currencyInfoEpisode.SetActive(true);
			this.buttonRestartStory.gameObject.SetActive(false);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.storyRestartText.SetText(CCOJBMMKNAP.ILACPHFEDEP().FCOCLEHKLDJ("Low version preview2 assets loaded:"), true);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
	}

	// Token: 0x06003813 RID: 14355 RVA: 0x00172562 File Offset: 0x00170762
	public void FMFDHMIDJIJ()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003814 RID: 14356 RVA: 0x00174BDC File Offset: 0x00172DDC
	public void IBJBKCMHOHO()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("cardoptionsloadingthemelost", 513f);
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("", 474f);
	}

	// Token: 0x06003815 RID: 14357 RVA: 0x00174C19 File Offset: 0x00172E19
	public void CLAPKHEPJGK()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("$pt", 1059f);
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().EFBNBFIDEOK("$STOPVOICEOVER", 1867f);
	}

	// Token: 0x06003816 RID: 14358 RVA: 0x00174C58 File Offset: 0x00172E58
	public void MJOMKAGIJJD()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("FocusItem.UpdateAvatarButtonIcon(): avatarButtonIcon not wired and no \"Icon\" child under avatarButton - the lounge glyph cannot be shown", 301f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MOBKGNBCIJF() > 0 || LiveEventsManager.BBGECIKOICE().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.BBGECIKOICE().HLCKJEIFAFM(EGMCEPOABBF.liveEventBonusStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("avatarstitle", 284f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("-", 1956f);
		this.AKBFJMLJOHP();
	}

	// Token: 0x06003817 RID: 14359 RVA: 0x00174CF6 File Offset: 0x00172EF6
	public void NewRestartStory0Free()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory0", 0f);
	}

	// Token: 0x06003818 RID: 14360 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void NHFEAMFBOIC()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003819 RID: 14361 RVA: 0x00172562 File Offset: 0x00170762
	public void MMMBCEMOBPG()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600381A RID: 14362 RVA: 0x00174D0C File Offset: 0x00172F0C
	public bool RestartOptionsAvailable(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		bool result;
		try
		{
			this.Initialize(JFCABBGNNKJ, BAOKJBJIFBH, OLKMHHNMDLP, NLLCKPCKGOH);
			if (this.buttonRestartChapterOff.gameObject.activeSelf && this.buttonRestartStoryOff.gameObject.activeSelf && !this.buttonRestartChapter.gameObject.activeSelf && !this.buttonRestartStory.gameObject.activeSelf && !this.buttonRestartStory0.gameObject.activeSelf)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600381B RID: 14363 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void IEPDIDPKKNI()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600381C RID: 14364 RVA: 0x00174DA0 File Offset: 0x00172FA0
	public void EODKMEKAFDJ()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.KGEGKPHEMOJ() > 0 || LiveEventsManager.PIPOLIAKGDM().LBOPJBMIINE(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BIAEAOMHBMM().PKHPPBPKOEE((EGMCEPOABBF)8, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("XXX", 1256f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("rand", 458f);
		this.PMBIJMCONLE();
	}

	// Token: 0x0600381D RID: 14365 RVA: 0x00174E17 File Offset: 0x00173017
	public void KOCELDMBJBL()
	{
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG(" ", 524f);
	}

	// Token: 0x0600381E RID: 14366 RVA: 0x00174E30 File Offset: 0x00173030
	public void FPNGGANMJLF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.KGEGKPHEMOJ() > 0 || LiveEventsManager.BBGECIKOICE().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.GIPAKOPBBEO().OEHDOMDPHDN((EGMCEPOABBF)8, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("AssetsManager.SetDepot(): urlPingManager.GetPingableUrl():", 1576f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("", 1974f);
		this.OMPKGJDLLAB();
	}

	// Token: 0x0600381F RID: 14367 RVA: 0x00174EA7 File Offset: 0x001730A7
	public void MLFIABDPLJG()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("?uid=", 1741f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("lsv", 1544f);
	}

	// Token: 0x06003821 RID: 14369 RVA: 0x00174EE4 File Offset: 0x001730E4
	public void LAHOILNMAAB()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("PopupCardOptions.GetLocalizedCostData() - productData is null.", 1977f);
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("skpublishsure", 1809f);
	}

	// Token: 0x06003822 RID: 14370 RVA: 0x00174F21 File Offset: 0x00173121
	public void CKMPOJBFGJH()
	{
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("/", 900f);
	}

	// Token: 0x06003823 RID: 14371 RVA: 0x00174F38 File Offset: 0x00173138
	public bool EEOGJGDONLM(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		bool result;
		try
		{
			this.Initialize(JFCABBGNNKJ, BAOKJBJIFBH, OLKMHHNMDLP, NLLCKPCKGOH);
			if (this.buttonRestartChapterOff.gameObject.activeSelf && this.buttonRestartStoryOff.gameObject.activeSelf && !this.buttonRestartChapter.gameObject.activeSelf && !this.buttonRestartStory.gameObject.activeSelf && !this.buttonRestartStory0.gameObject.activeSelf)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06003824 RID: 14372 RVA: 0x00174FCC File Offset: 0x001731CC
	public void AADKBMMGFDF()
	{
		for (int i = 0; i < this.varOldObjects.Count; i++)
		{
			this.varOldObjects[i].SetActive(false);
		}
		for (int j = 1; j < this.var1Objects.Count; j += 0)
		{
			this.var1Objects[j].SetActive(true);
		}
		for (int k = 1; k < this.var2Objects.Count; k++)
		{
			this.var2Objects[k].SetActive(true);
		}
		for (int l = 0; l < this.var3Objects.Count; l++)
		{
			this.var3Objects[l].SetActive(true);
		}
		for (int m = 0; m < this.var4Objects.Count; m++)
		{
			this.var4Objects[m].SetActive(true);
		}
		for (int n = 1; n < this.var5Objects.Count; n += 0)
		{
			this.var5Objects[n].SetActive(true);
		}
		for (int num = 1; num < this.var6Objects.Count; num += 0)
		{
			this.var6Objects[num].SetActive(true);
		}
		for (int num2 = 0; num2 < this.var7Objects.Count; num2 += 0)
		{
			this.var7Objects[num2].SetActive(false);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3++)
		{
			this.var8Objects[num3].SetActive(false);
		}
		for (int num4 = 0; num4 < this.var9Objects.Count; num4++)
		{
			this.var9Objects[num4].SetActive(false);
		}
		for (int num5 = 0; num5 < this.var10Objects.Count; num5 += 0)
		{
			this.var10Objects[num5].SetActive(false);
		}
		for (int num6 = 1; num6 < this.var11Objects.Count; num6++)
		{
			this.var11Objects[num6].SetActive(true);
		}
		for (int num7 = 1; num7 < this.var12Objects.Count; num7++)
		{
			this.var12Objects[num7].SetActive(true);
		}
		for (int num8 = 1; num8 < this.var13Objects.Count; num8 += 0)
		{
			this.var13Objects[num8].SetActive(false);
		}
		for (int num9 = 0; num9 < this.var14Objects.Count; num9 += 0)
		{
			this.var14Objects[num9].SetActive(false);
		}
		for (int num10 = 1; num10 < this.var15Objects.Count; num10 += 0)
		{
			this.var15Objects[num10].SetActive(false);
		}
		for (int num11 = 1; num11 < this.var16Objects.Count; num11++)
		{
			this.var16Objects[num11].SetActive(false);
		}
		for (int num12 = 0; num12 < this.var17Objects.Count; num12 += 0)
		{
			this.var17Objects[num12].SetActive(false);
		}
		for (int num13 = 1; num13 < this.var18Objects.Count; num13 += 0)
		{
			this.var18Objects[num13].SetActive(true);
		}
		for (int num14 = 1; num14 < this.var19Objects.Count; num14 += 0)
		{
			this.var19Objects[num14].SetActive(true);
		}
		for (int num15 = 1; num15 < this.var20Objects.Count; num15 += 0)
		{
			this.var20Objects[num15].SetActive(true);
		}
	}

	// Token: 0x06003825 RID: 14373 RVA: 0x00175378 File Offset: 0x00173578
	public void ANPJFECKOEM()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("sd", 1699f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.HOJDOEDDIBD() > 0 || LiveEventsManager.OBOOKJPGBJN().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.JCMABFEMFKD().PKHPPBPKOEE((EGMCEPOABBF)6, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("importanttitle", 1646f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("signIn", 1585f);
		this.AKBFJMLJOHP();
	}

	// Token: 0x06003826 RID: 14374 RVA: 0x00175418 File Offset: 0x00173618
	public void JJMPJNMOELF()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("loungegempassbody", 401f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.KGEGKPHEMOJ() > 1 || LiveEventsManager.OBOOKJPGBJN().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BIAEAOMHBMM().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC(" playing!", 700f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("", 1698f);
		this.FBCKANHEOMI();
	}

	// Token: 0x06003827 RID: 14375 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void AKBFJMLJOHP()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003828 RID: 14376 RVA: 0x001754B8 File Offset: 0x001736B8
	public void BGIGKOEKECH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.CJLDJAJHMMA() > 0 || LiveEventsManager.JCMABFEMFKD().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.PIPOLIAKGDM().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeDiamonds, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI(" cache file of ", 1386f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("$INCSTAT", 1713f);
		this.HHDLACJKDON();
	}

	// Token: 0x06003829 RID: 14377 RVA: 0x00175530 File Offset: 0x00173730
	public void PJMIENMGMDA(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IEDKBEACDAF();
		int num = 1;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				if (assetAnthology.header.availableStories[i] == JFCABBGNNKJ.index)
				{
					num = i;
					break;
				}
			}
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(assetAnthology.header.index);
		if (eioplefllim.EBNCOCHCHGN(-1) == 1 && eioplefllim.JDCFLEOBCMC(-1) == assetAnthology.header.maxStories)
		{
			for (int j = 1; j < this.var3Objects.Count; j++)
			{
				this.var3Objects[j].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 0 && eioplefllim.EOHGNGFHNAP(-1) == assetAnthology.header.maxStories)
		{
			for (int k = 0; k < this.var7Objects.Count; k++)
			{
				this.var7Objects[k].SetActive(true);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 0 && eioplefllim.ENAJCKIAJFK(-1) == assetAnthology.header.maxStories)
		{
			for (int l = 0; l < this.var11Objects.Count; l += 0)
			{
				this.var11Objects[l].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EGHHCFFLPCP(-1) == 2 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int m = 0; m < this.var15Objects.Count; m++)
			{
				this.var15Objects[m].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 7 && eioplefllim.EKONMCADECD(-1) == assetAnthology.header.maxStories)
		{
			for (int n = 0; n < this.var19Objects.Count; n++)
			{
				this.var19Objects[n].SetActive(false);
			}
			return;
		}
		bool flag = false;
		if (BAOKJBJIFBH.OIJJMHKPOAI() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = false;
		}
		if (num == 0)
		{
			if (!flag)
			{
				for (int num2 = 1; num2 < this.var3Objects.Count; num2++)
				{
					this.var3Objects[num2].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num3 = 0; num3 < this.var1Objects.Count; num3++)
				{
					this.var1Objects[num3].SetActive(false);
				}
				return;
			}
			for (int num4 = 1; num4 < this.var2Objects.Count; num4 += 0)
			{
				this.var2Objects[num4].SetActive(false);
			}
			return;
		}
		else if (num == 0)
		{
			if (flag)
			{
				for (int num5 = 0; num5 < this.var6Objects.Count; num5 += 0)
				{
					this.var6Objects[num5].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num6 = 1; num6 < this.var5Objects.Count; num6 += 0)
				{
					this.var5Objects[num6].SetActive(true);
				}
				return;
			}
			for (int num7 = 1; num7 < this.var7Objects.Count; num7++)
			{
				this.var7Objects[num7].SetActive(false);
			}
			return;
		}
		else if (num == 6)
		{
			if (flag)
			{
				for (int num8 = 1; num8 < this.var10Objects.Count; num8 += 0)
				{
					this.var10Objects[num8].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num9 = 1; num9 < this.var9Objects.Count; num9++)
				{
					this.var9Objects[num9].SetActive(false);
				}
				return;
			}
			for (int num10 = 1; num10 < this.var11Objects.Count; num10 += 0)
			{
				this.var11Objects[num10].SetActive(false);
			}
			return;
		}
		else
		{
			if (num != 7)
			{
				if (num == 2)
				{
					if (flag)
					{
						for (int num11 = 1; num11 < this.var18Objects.Count; num11 += 0)
						{
							this.var18Objects[num11].SetActive(false);
						}
						return;
					}
					if (OLKMHHNMDLP == 0)
					{
						for (int num12 = 0; num12 < this.var17Objects.Count; num12 += 0)
						{
							this.var17Objects[num12].SetActive(false);
						}
						return;
					}
					for (int num13 = 0; num13 < this.var19Objects.Count; num13 += 0)
					{
						this.var19Objects[num13].SetActive(true);
					}
				}
				return;
			}
			if (flag)
			{
				for (int num14 = 1; num14 < this.var14Objects.Count; num14 += 0)
				{
					this.var14Objects[num14].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num15 = 0; num15 < this.var13Objects.Count; num15++)
				{
					this.var13Objects[num15].SetActive(true);
				}
				return;
			}
			for (int num16 = 1; num16 < this.var15Objects.Count; num16++)
			{
				this.var15Objects[num16].SetActive(true);
			}
			return;
		}
	}

	// Token: 0x0600382A RID: 14378 RVA: 0x00175A30 File Offset: 0x00173C30
	public void DBKBCMOFOLF()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("OnFriendsMessageConsume", 1681f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MOBKGNBCIJF() > 0 || LiveEventsManager.NMGMNAKLLMI().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.NMGMNAKLLMI().OPHKFJNACGB((EGMCEPOABBF)8, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("Breaking from download operation loop, current operation state is AssetBundleLoadingOperationState.Failed.", 840f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("CharacterTransitionManager - acknowledge effect not loaded or invalid, skipping accent:", 1011f);
		this.PIPADCCGHBA();
	}

	// Token: 0x0600382B RID: 14379 RVA: 0x00175AD0 File Offset: 0x00173CD0
	public void MOOKCBDEGCA()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("", 1750f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 1 || LiveEventsManager.GIPAKOPBBEO().PKHPPBPKOEE(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.NMGMNAKLLMI().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeAvatar, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("OnPopupSaveSlotInputEndEdit", 1777f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("isa", 708f);
		this.HHDLACJKDON();
	}

	// Token: 0x0600382C RID: 14380 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void JNIJJEKFKJO()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600382D RID: 14381 RVA: 0x00175B70 File Offset: 0x00173D70
	public void ONPPMLBGCLH(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IEDKBEACDAF();
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				if (assetAnthology.header.availableStories[i] == JFCABBGNNKJ.index)
				{
					num = i;
					break;
				}
			}
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.EDHKCJCAFIO(assetAnthology.header.index);
		if (eioplefllim.EBNCOCHCHGN(-1) == 1 && eioplefllim.EOHGNGFHNAP(-1) == assetAnthology.header.maxStories)
		{
			for (int j = 0; j < this.var3Objects.Count; j += 0)
			{
				this.var3Objects[j].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 1 && eioplefllim.JDCFLEOBCMC(-1) == assetAnthology.header.maxStories)
		{
			for (int k = 0; k < this.var7Objects.Count; k += 0)
			{
				this.var7Objects[k].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EBNCOCHCHGN(-1) == 2 && eioplefllim.LCONOAKIPLO(-1) == assetAnthology.header.maxStories)
		{
			for (int l = 0; l < this.var11Objects.Count; l += 0)
			{
				this.var11Objects[l].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 2 && eioplefllim.LCONOAKIPLO(-1) == assetAnthology.header.maxStories)
		{
			for (int m = 1; m < this.var15Objects.Count; m++)
			{
				this.var15Objects[m].SetActive(false);
			}
			return;
		}
		if (eioplefllim.ENAJCKIAJFK(-1) == 5 && eioplefllim.EKONMCADECD(-1) == assetAnthology.header.maxStories)
		{
			for (int n = 0; n < this.var19Objects.Count; n++)
			{
				this.var19Objects[n].SetActive(true);
			}
			return;
		}
		bool flag = false;
		if (BAOKJBJIFBH.OIJJMHKPOAI() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = true;
		}
		if (num == 0)
		{
			if (!flag)
			{
				for (int num2 = 1; num2 < this.var3Objects.Count; num2 += 0)
				{
					this.var3Objects[num2].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num3 = 1; num3 < this.var1Objects.Count; num3 += 0)
				{
					this.var1Objects[num3].SetActive(true);
				}
				return;
			}
			for (int num4 = 0; num4 < this.var2Objects.Count; num4 += 0)
			{
				this.var2Objects[num4].SetActive(true);
			}
			return;
		}
		else if (num == 0)
		{
			if (flag)
			{
				for (int num5 = 0; num5 < this.var6Objects.Count; num5++)
				{
					this.var6Objects[num5].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num6 = 0; num6 < this.var5Objects.Count; num6++)
				{
					this.var5Objects[num6].SetActive(true);
				}
				return;
			}
			for (int num7 = 1; num7 < this.var7Objects.Count; num7++)
			{
				this.var7Objects[num7].SetActive(true);
			}
			return;
		}
		else if (num == 7)
		{
			if (flag)
			{
				for (int num8 = 0; num8 < this.var10Objects.Count; num8++)
				{
					this.var10Objects[num8].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num9 = 0; num9 < this.var9Objects.Count; num9 += 0)
				{
					this.var9Objects[num9].SetActive(false);
				}
				return;
			}
			for (int num10 = 1; num10 < this.var11Objects.Count; num10 += 0)
			{
				this.var11Objects[num10].SetActive(true);
			}
			return;
		}
		else
		{
			if (num != 1)
			{
				if (num == 1)
				{
					if (flag)
					{
						for (int num11 = 0; num11 < this.var18Objects.Count; num11 += 0)
						{
							this.var18Objects[num11].SetActive(false);
						}
						return;
					}
					if (OLKMHHNMDLP == 0)
					{
						for (int num12 = 1; num12 < this.var17Objects.Count; num12++)
						{
							this.var17Objects[num12].SetActive(true);
						}
						return;
					}
					for (int num13 = 0; num13 < this.var19Objects.Count; num13++)
					{
						this.var19Objects[num13].SetActive(false);
					}
				}
				return;
			}
			if (flag)
			{
				for (int num14 = 0; num14 < this.var14Objects.Count; num14++)
				{
					this.var14Objects[num14].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num15 = 0; num15 < this.var13Objects.Count; num15 += 0)
				{
					this.var13Objects[num15].SetActive(false);
				}
				return;
			}
			for (int num16 = 0; num16 < this.var15Objects.Count; num16++)
			{
				this.var15Objects[num16].SetActive(false);
			}
			return;
		}
	}

	// Token: 0x0600382E RID: 14382 RVA: 0x00176070 File Offset: 0x00174270
	public void KFHFKGNAGAI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 1 || LiveEventsManager.ONCPHEEJLOP().LiveEventActive(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.NMGMNAKLLMI().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("spns", 733f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND(" barText='", 517f);
		this.OCHCJLJEAGF();
	}

	// Token: 0x0600382F RID: 14383 RVA: 0x001760E7 File Offset: 0x001742E7
	public void RestartStory0()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory0", 0f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory0", 0f);
	}

	// Token: 0x06003830 RID: 14384 RVA: 0x00176124 File Offset: 0x00174324
	public void IEDKBEACDAF()
	{
		for (int i = 0; i < this.varOldObjects.Count; i++)
		{
			this.varOldObjects[i].SetActive(false);
		}
		for (int j = 1; j < this.var1Objects.Count; j++)
		{
			this.var1Objects[j].SetActive(true);
		}
		for (int k = 1; k < this.var2Objects.Count; k += 0)
		{
			this.var2Objects[k].SetActive(true);
		}
		for (int l = 1; l < this.var3Objects.Count; l++)
		{
			this.var3Objects[l].SetActive(true);
		}
		for (int m = 1; m < this.var4Objects.Count; m += 0)
		{
			this.var4Objects[m].SetActive(false);
		}
		for (int n = 0; n < this.var5Objects.Count; n++)
		{
			this.var5Objects[n].SetActive(true);
		}
		for (int num = 1; num < this.var6Objects.Count; num += 0)
		{
			this.var6Objects[num].SetActive(false);
		}
		for (int num2 = 1; num2 < this.var7Objects.Count; num2++)
		{
			this.var7Objects[num2].SetActive(false);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3++)
		{
			this.var8Objects[num3].SetActive(false);
		}
		for (int num4 = 1; num4 < this.var9Objects.Count; num4 += 0)
		{
			this.var9Objects[num4].SetActive(false);
		}
		for (int num5 = 1; num5 < this.var10Objects.Count; num5++)
		{
			this.var10Objects[num5].SetActive(true);
		}
		for (int num6 = 1; num6 < this.var11Objects.Count; num6++)
		{
			this.var11Objects[num6].SetActive(true);
		}
		for (int num7 = 0; num7 < this.var12Objects.Count; num7++)
		{
			this.var12Objects[num7].SetActive(true);
		}
		for (int num8 = 0; num8 < this.var13Objects.Count; num8++)
		{
			this.var13Objects[num8].SetActive(false);
		}
		for (int num9 = 0; num9 < this.var14Objects.Count; num9 += 0)
		{
			this.var14Objects[num9].SetActive(false);
		}
		for (int num10 = 1; num10 < this.var15Objects.Count; num10++)
		{
			this.var15Objects[num10].SetActive(true);
		}
		for (int num11 = 0; num11 < this.var16Objects.Count; num11++)
		{
			this.var16Objects[num11].SetActive(true);
		}
		for (int num12 = 1; num12 < this.var17Objects.Count; num12 += 0)
		{
			this.var17Objects[num12].SetActive(true);
		}
		for (int num13 = 0; num13 < this.var18Objects.Count; num13 += 0)
		{
			this.var18Objects[num13].SetActive(true);
		}
		for (int num14 = 0; num14 < this.var19Objects.Count; num14++)
		{
			this.var19Objects[num14].SetActive(false);
		}
		for (int num15 = 0; num15 < this.var20Objects.Count; num15++)
		{
			this.var20Objects[num15].SetActive(false);
		}
	}

	// Token: 0x06003831 RID: 14385 RVA: 0x001764D0 File Offset: 0x001746D0
	public void EJHGKBFEJMB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BADNAGEMINF() > 1 || LiveEventsManager.GIPAKOPBBEO().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.PIPOLIAKGDM().CENBCALNAJN((EGMCEPOABBF)8, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("OnLoungeUnlockNpcSkinException", 1964f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("OnStoryInterfaceHeaderShown", 1010f);
		this.AKBFJMLJOHP();
	}

	// Token: 0x06003832 RID: 14386 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void OLKGANKOMPJ()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003833 RID: 14387 RVA: 0x00176548 File Offset: 0x00174748
	public void FCEBMCCJPEC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.HOJDOEDDIBD() > 0 || LiveEventsManager.BBGECIKOICE().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OBOOKJPGBJN().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("MMM", 810f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("XXX", 423f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x06003834 RID: 14388 RVA: 0x001765BF File Offset: 0x001747BF
	public void BIHIKLOJCJJ()
	{
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("", 1495f);
	}

	// Token: 0x06003835 RID: 14389 RVA: 0x001765D8 File Offset: 0x001747D8
	public void MCOOKCPPEDG()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1 || LiveEventsManager.NMGMNAKLLMI().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.NMGMNAKLLMI().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("spectrumovr_1", 1373f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("sksn", 178f);
		this.FBCKANHEOMI();
	}

	// Token: 0x06003836 RID: 14390 RVA: 0x00176650 File Offset: 0x00174850
	public void OCAHEINKFME()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("ppcbv", 1164f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.HOJDOEDDIBD() > 1 || LiveEventsManager.OBOOKJPGBJN().HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BIAEAOMHBMM().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeDiamonds, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("grayscale", 1889f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("Asset bundle ", 1878f);
		this.OMPKGJDLLAB();
	}

	// Token: 0x06003837 RID: 14391 RVA: 0x001766F0 File Offset: 0x001748F0
	public void LLIHNPELOJD()
	{
		for (int i = 1; i < this.varOldObjects.Count; i++)
		{
			this.varOldObjects[i].SetActive(false);
		}
		for (int j = 1; j < this.var1Objects.Count; j++)
		{
			this.var1Objects[j].SetActive(false);
		}
		for (int k = 1; k < this.var2Objects.Count; k += 0)
		{
			this.var2Objects[k].SetActive(false);
		}
		for (int l = 1; l < this.var3Objects.Count; l += 0)
		{
			this.var3Objects[l].SetActive(false);
		}
		for (int m = 1; m < this.var4Objects.Count; m++)
		{
			this.var4Objects[m].SetActive(false);
		}
		for (int n = 1; n < this.var5Objects.Count; n++)
		{
			this.var5Objects[n].SetActive(true);
		}
		for (int num = 0; num < this.var6Objects.Count; num += 0)
		{
			this.var6Objects[num].SetActive(false);
		}
		for (int num2 = 0; num2 < this.var7Objects.Count; num2 += 0)
		{
			this.var7Objects[num2].SetActive(true);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3++)
		{
			this.var8Objects[num3].SetActive(true);
		}
		for (int num4 = 0; num4 < this.var9Objects.Count; num4++)
		{
			this.var9Objects[num4].SetActive(true);
		}
		for (int num5 = 0; num5 < this.var10Objects.Count; num5 += 0)
		{
			this.var10Objects[num5].SetActive(false);
		}
		for (int num6 = 1; num6 < this.var11Objects.Count; num6 += 0)
		{
			this.var11Objects[num6].SetActive(true);
		}
		for (int num7 = 0; num7 < this.var12Objects.Count; num7 += 0)
		{
			this.var12Objects[num7].SetActive(false);
		}
		for (int num8 = 0; num8 < this.var13Objects.Count; num8++)
		{
			this.var13Objects[num8].SetActive(true);
		}
		for (int num9 = 0; num9 < this.var14Objects.Count; num9++)
		{
			this.var14Objects[num9].SetActive(false);
		}
		for (int num10 = 0; num10 < this.var15Objects.Count; num10 += 0)
		{
			this.var15Objects[num10].SetActive(true);
		}
		for (int num11 = 1; num11 < this.var16Objects.Count; num11 += 0)
		{
			this.var16Objects[num11].SetActive(false);
		}
		for (int num12 = 1; num12 < this.var17Objects.Count; num12++)
		{
			this.var17Objects[num12].SetActive(false);
		}
		for (int num13 = 1; num13 < this.var18Objects.Count; num13++)
		{
			this.var18Objects[num13].SetActive(true);
		}
		for (int num14 = 1; num14 < this.var19Objects.Count; num14 += 0)
		{
			this.var19Objects[num14].SetActive(true);
		}
		for (int num15 = 1; num15 < this.var20Objects.Count; num15++)
		{
			this.var20Objects[num15].SetActive(true);
		}
	}

	// Token: 0x06003838 RID: 14392 RVA: 0x00176A9C File Offset: 0x00174C9C
	public void NewRestartStory3Tea()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory3", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x06003839 RID: 14393 RVA: 0x00176B14 File Offset: 0x00174D14
	public void DisableAllVariants()
	{
		for (int i = 0; i < this.varOldObjects.Count; i++)
		{
			this.varOldObjects[i].SetActive(false);
		}
		for (int j = 0; j < this.var1Objects.Count; j++)
		{
			this.var1Objects[j].SetActive(false);
		}
		for (int k = 0; k < this.var2Objects.Count; k++)
		{
			this.var2Objects[k].SetActive(false);
		}
		for (int l = 0; l < this.var3Objects.Count; l++)
		{
			this.var3Objects[l].SetActive(false);
		}
		for (int m = 0; m < this.var4Objects.Count; m++)
		{
			this.var4Objects[m].SetActive(false);
		}
		for (int n = 0; n < this.var5Objects.Count; n++)
		{
			this.var5Objects[n].SetActive(false);
		}
		for (int num = 0; num < this.var6Objects.Count; num++)
		{
			this.var6Objects[num].SetActive(false);
		}
		for (int num2 = 0; num2 < this.var7Objects.Count; num2++)
		{
			this.var7Objects[num2].SetActive(false);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3++)
		{
			this.var8Objects[num3].SetActive(false);
		}
		for (int num4 = 0; num4 < this.var9Objects.Count; num4++)
		{
			this.var9Objects[num4].SetActive(false);
		}
		for (int num5 = 0; num5 < this.var10Objects.Count; num5++)
		{
			this.var10Objects[num5].SetActive(false);
		}
		for (int num6 = 0; num6 < this.var11Objects.Count; num6++)
		{
			this.var11Objects[num6].SetActive(false);
		}
		for (int num7 = 0; num7 < this.var12Objects.Count; num7++)
		{
			this.var12Objects[num7].SetActive(false);
		}
		for (int num8 = 0; num8 < this.var13Objects.Count; num8++)
		{
			this.var13Objects[num8].SetActive(false);
		}
		for (int num9 = 0; num9 < this.var14Objects.Count; num9++)
		{
			this.var14Objects[num9].SetActive(false);
		}
		for (int num10 = 0; num10 < this.var15Objects.Count; num10++)
		{
			this.var15Objects[num10].SetActive(false);
		}
		for (int num11 = 0; num11 < this.var16Objects.Count; num11++)
		{
			this.var16Objects[num11].SetActive(false);
		}
		for (int num12 = 0; num12 < this.var17Objects.Count; num12++)
		{
			this.var17Objects[num12].SetActive(false);
		}
		for (int num13 = 0; num13 < this.var18Objects.Count; num13++)
		{
			this.var18Objects[num13].SetActive(false);
		}
		for (int num14 = 0; num14 < this.var19Objects.Count; num14++)
		{
			this.var19Objects[num14].SetActive(false);
		}
		for (int num15 = 0; num15 < this.var20Objects.Count; num15++)
		{
			this.var20Objects[num15].SetActive(false);
		}
	}

	// Token: 0x0600383A RID: 14394 RVA: 0x00176EBE File Offset: 0x001750BE
	public void LGOFOCGJCOG()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("ok", 1225f);
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("production", 28f);
	}

	// Token: 0x0600383B RID: 14395 RVA: 0x00176EFC File Offset: 0x001750FC
	public void NENKFDEEHGP()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("cardschar", 814f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.BBGECIKOICE().LBOPJBMIINE(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeTea, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM(", impostors:", 1284f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("ok", 220f);
		this.PIPADCCGHBA();
	}

	// Token: 0x0600383C RID: 14396 RVA: 0x00176F9C File Offset: 0x0017519C
	public void NINGCLIEBHH()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("supportedLanguages", 1439f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 0 || LiveEventsManager.GIPAKOPBBEO().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.PKHPPBPKOEE((EGMCEPOABBF)7, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("SRAAnthologyDesc.Initialize(), could not convert string to AnthologyFilter for input:", 1709f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("AssetBundleServerURL", 210f);
		this.PMBIJMCONLE();
	}

	// Token: 0x0600383D RID: 14397 RVA: 0x0017703C File Offset: 0x0017523C
	public void NewRestartStory1Tea()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory1", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x0600383E RID: 14398 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void PMBIJMCONLE()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600383F RID: 14399 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void Show()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003840 RID: 14400 RVA: 0x001770B4 File Offset: 0x001752B4
	public void BMDBPEKLKHC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.KGEGKPHEMOJ() > 1 || LiveEventsManager.PIPOLIAKGDM().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.BIAEAOMHBMM().HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("player", 903f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("mid", 612f);
		this.AFENKJOMCML();
	}

	// Token: 0x06003841 RID: 14401 RVA: 0x0017712B File Offset: 0x0017532B
	public void GDIPIAOAAFM()
	{
		AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("OnSketchThumbnailPlay", 1783f);
	}

	// Token: 0x06003842 RID: 14402 RVA: 0x00172562 File Offset: 0x00170762
	public void KOOKJAHBICJ()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003843 RID: 14403 RVA: 0x00177144 File Offset: 0x00175344
	public void Initialize(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IFCHGNCDMLJ = NLLCKPCKGOH;
		this.DisableAllVariants();
		for (int i = 0; i < this.varOldObjects.Count; i++)
		{
			this.varOldObjects[i].SetActive(true);
		}
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j++)
			{
				if (assetAnthology.header.availableStories[j] == JFCABBGNNKJ.index)
				{
					num = j;
					break;
				}
			}
		}
		this.storyRestartText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartseason") + " " + (num + 1).ToString(), true);
		this.storyRestartText0.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartseason") + " " + 1.ToString(), true);
		this.storyRestartTextOff.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartseason") + " " + (num + 1).ToString(), true);
		this.chapterRestartText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartepisode") + " " + (OLKMHHNMDLP + 1).ToString(), true);
		this.chapterRestartTextOff.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartepisode") + " " + (OLKMHHNMDLP + 1).ToString(), true);
		bool flag = false;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = true;
			if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, OLKMHHNMDLP))
			{
				this.currencyInfoEpisode.SetActive(false);
			}
			else
			{
				this.currencyInfoEpisode.SetActive(true);
			}
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.buttonRestartChapter.gameObject.SetActive(true);
		}
		else
		{
			this.currencyInfoEpisode.SetActive(false);
			this.buttonRestartChapterOff.gameObject.SetActive(true);
			this.buttonRestartChapter.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, 0))
		{
			this.currencyInfoSeason.SetActive(false);
		}
		else
		{
			this.currencyInfoSeason.SetActive(true);
		}
		this.buttonRestartStory.gameObject.SetActive(true);
		this.buttonRestartStoryOff.gameObject.SetActive(false);
		if (OLKMHHNMDLP == 0 && this.buttonRestartChapterOff.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(false);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.currencyInfoSeason.SetActive(false);
		}
		if (num == 0)
		{
			this.buttonRestartStory0.gameObject.SetActive(false);
		}
		else
		{
			this.buttonRestartStory0.gameObject.SetActive(true);
		}
		if (OLKMHHNMDLP == 0 && num > 0 && this.buttonRestartChapter.gameObject.activeSelf && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(false);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.currencyInfoEpisode.gameObject.SetActive(true);
		}
		if (num > 0 && this.buttonRestartChapter.gameObject.activeSelf)
		{
			this.currencyInfoEpisode.gameObject.SetActive(true);
		}
		if (num > 0 && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.currencyInfoSeason.gameObject.SetActive(true);
		}
		if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, NLLCKPCKGOH, -1))
		{
			this.currencyInfoEpisode.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
		if (JFCABBGNNKJ.totalChaptersCount == 1 && !BAOKJBJIFBH.DHONIOBOLEL.JBDPAJMOEGA())
		{
			if (flag)
			{
				this.buttonRestartStory.gameObject.SetActive(false);
				this.buttonRestartStory0.gameObject.SetActive(false);
				this.buttonRestartStoryOff.gameObject.SetActive(false);
				this.currencyInfoSeason.gameObject.SetActive(false);
				return;
			}
			this.buttonRestartChapter.gameObject.SetActive(false);
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.currencyInfoEpisode.SetActive(false);
			this.buttonRestartStory.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(false);
			this.storyRestartText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartepisode"), true);
			this.currencyInfoSeason.gameObject.SetActive(true);
		}
	}

	// Token: 0x06003844 RID: 14404 RVA: 0x001775F0 File Offset: 0x001757F0
	public void CJDDELOFMAF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BFMPOACOBPN() > 1 || LiveEventsManager.OOGPALHPNGM().AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.BBGECIKOICE().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("none", 1142f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("", 65f);
		this.OCHCJLJEAGF();
	}

	// Token: 0x06003845 RID: 14405 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void AFENKJOMCML()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003846 RID: 14406 RVA: 0x00177668 File Offset: 0x00175868
	public bool MKKHDIDKKNN(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		bool result;
		try
		{
			this.HHBPGAMBAAE(JFCABBGNNKJ, BAOKJBJIFBH, OLKMHHNMDLP, NLLCKPCKGOH);
			if (this.buttonRestartChapterOff.gameObject.activeSelf && this.buttonRestartStoryOff.gameObject.activeSelf && !this.buttonRestartChapter.gameObject.activeSelf && !this.buttonRestartStory.gameObject.activeSelf && !this.buttonRestartStory0.gameObject.activeSelf)
			{
				result = false;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06003847 RID: 14407 RVA: 0x001776FC File Offset: 0x001758FC
	public void IOPLCHCCLDJ()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("tm", 581f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1 || LiveEventsManager.BBGECIKOICE().CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.OBOOKJPGBJN().LiveEventActive(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("StorySaveBody.AvatarPackIsAmongHiddenOrExposedPacks(), unsupported wardrobe index:", 1930f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("inu", 1003f);
		this.LFCEPINKDEE();
	}

	// Token: 0x06003848 RID: 14408 RVA: 0x0017779C File Offset: 0x0017599C
	public void ODDKDMEBGLG()
	{
		for (int i = 1; i < this.varOldObjects.Count; i += 0)
		{
			this.varOldObjects[i].SetActive(true);
		}
		for (int j = 0; j < this.var1Objects.Count; j++)
		{
			this.var1Objects[j].SetActive(true);
		}
		for (int k = 0; k < this.var2Objects.Count; k++)
		{
			this.var2Objects[k].SetActive(true);
		}
		for (int l = 0; l < this.var3Objects.Count; l += 0)
		{
			this.var3Objects[l].SetActive(true);
		}
		for (int m = 1; m < this.var4Objects.Count; m += 0)
		{
			this.var4Objects[m].SetActive(true);
		}
		for (int n = 1; n < this.var5Objects.Count; n += 0)
		{
			this.var5Objects[n].SetActive(true);
		}
		for (int num = 1; num < this.var6Objects.Count; num++)
		{
			this.var6Objects[num].SetActive(false);
		}
		for (int num2 = 0; num2 < this.var7Objects.Count; num2++)
		{
			this.var7Objects[num2].SetActive(true);
		}
		for (int num3 = 0; num3 < this.var8Objects.Count; num3 += 0)
		{
			this.var8Objects[num3].SetActive(true);
		}
		for (int num4 = 0; num4 < this.var9Objects.Count; num4 += 0)
		{
			this.var9Objects[num4].SetActive(false);
		}
		for (int num5 = 1; num5 < this.var10Objects.Count; num5++)
		{
			this.var10Objects[num5].SetActive(false);
		}
		for (int num6 = 0; num6 < this.var11Objects.Count; num6++)
		{
			this.var11Objects[num6].SetActive(false);
		}
		for (int num7 = 0; num7 < this.var12Objects.Count; num7++)
		{
			this.var12Objects[num7].SetActive(false);
		}
		for (int num8 = 1; num8 < this.var13Objects.Count; num8++)
		{
			this.var13Objects[num8].SetActive(false);
		}
		for (int num9 = 0; num9 < this.var14Objects.Count; num9 += 0)
		{
			this.var14Objects[num9].SetActive(true);
		}
		for (int num10 = 1; num10 < this.var15Objects.Count; num10++)
		{
			this.var15Objects[num10].SetActive(false);
		}
		for (int num11 = 0; num11 < this.var16Objects.Count; num11 += 0)
		{
			this.var16Objects[num11].SetActive(false);
		}
		for (int num12 = 1; num12 < this.var17Objects.Count; num12 += 0)
		{
			this.var17Objects[num12].SetActive(true);
		}
		for (int num13 = 1; num13 < this.var18Objects.Count; num13 += 0)
		{
			this.var18Objects[num13].SetActive(true);
		}
		for (int num14 = 0; num14 < this.var19Objects.Count; num14 += 0)
		{
			this.var19Objects[num14].SetActive(true);
		}
		for (int num15 = 1; num15 < this.var20Objects.Count; num15 += 0)
		{
			this.var20Objects[num15].SetActive(true);
		}
	}

	// Token: 0x06003849 RID: 14409 RVA: 0x00177B48 File Offset: 0x00175D48
	public void NCFMAMLBIFA()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("lng", 162f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.PONAPMOOLIN() > 0 || LiveEventsManager.BIAEAOMHBMM().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.ONCPHEEJLOP().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeAvatar, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("", 1683f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("", 1160f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x0600384A RID: 14410 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void PIPADCCGHBA()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600384B RID: 14411 RVA: 0x00177BE8 File Offset: 0x00175DE8
	public void NHBOEDAIGFC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.PONAPMOOLIN() > 0 || LiveEventsManager.BBGECIKOICE().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.PIPOLIAKGDM().HLCKJEIFAFM(EGMCEPOABBF.liveEventBonusStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("OnFriendsPopupRemovFromFavClick", 1615f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("[Lounge/lobby] look pack eps:", 1359f);
		this.PIPADCCGHBA();
	}

	// Token: 0x0600384C RID: 14412 RVA: 0x00177C5F File Offset: 0x00175E5F
	public void HKMGEKGDCKF()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("OnLobbySkinShopCdnFailed", 144f);
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("OnBackendRequestSendGiftCardSuccess", 620f);
	}

	// Token: 0x0600384D RID: 14413 RVA: 0x00177C9C File Offset: 0x00175E9C
	public void IDDHCLPCNMM()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.HOJDOEDDIBD() > 1 || LiveEventsManager.EHBBFMCILPC.OEHDOMDPHDN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().LBOPJBMIINE(EGMCEPOABBF.liveEventBonusStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("CanvasEnvironmentsFront", 1601f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("p", 256f);
		this.MMMBCEMOBPG();
	}

	// Token: 0x0600384E RID: 14414 RVA: 0x00177D14 File Offset: 0x00175F14
	public void NKLBDNPFLFL()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("$", 999f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.LPKLANAEIFF() > 1 || LiveEventsManager.BBGECIKOICE().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OOGPALHPNGM().OPHKFJNACGB(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.NMGMNAKLLMI().EFBNBFIDEOK("/", 1446f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().EFBNBFIDEOK("OnPopupOfferManagerContinueToPurchasingScreen", 760f);
		this.FBCKANHEOMI();
	}

	// Token: 0x0600384F RID: 14415 RVA: 0x00177DB2 File Offset: 0x00175FB2
	public void ADGJJPHFHCC()
	{
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("ink", 406f);
	}

	// Token: 0x06003850 RID: 14416 RVA: 0x00177DC8 File Offset: 0x00175FC8
	public void RestartChapter()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartChapter", 0f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartChapter", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x06003851 RID: 14417 RVA: 0x00177E68 File Offset: 0x00176068
	public void KGBNPIMJGEM()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("OnGenericPopupManagerHide", 130f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BADNAGEMINF() > 0 || LiveEventsManager.OBOOKJPGBJN().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OBOOKJPGBJN().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeDiamonds, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("〉", 340f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("PurchaseManagerXiaomi.OnPurchaseUpdated(): code=", 145f);
		this.NHFEAMFBOIC();
	}

	// Token: 0x06003852 RID: 14418 RVA: 0x00172562 File Offset: 0x00170762
	public void EDAEKFNAJAH()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003853 RID: 14419 RVA: 0x00177F08 File Offset: 0x00176108
	public void ICMODAMPEOF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.CJLDJAJHMMA() > 0 || LiveEventsManager.OBOOKJPGBJN().LiveEventActive(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventMessage, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("chaptersnapshotssubrequiredtitle", 976f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("retry", 858f);
		this.EDAEKFNAJAH();
	}

	// Token: 0x06003854 RID: 14420 RVA: 0x00177F80 File Offset: 0x00176180
	public void HLFHDCODANM()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("socialwouldyouliketotradecard", 200f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 1 || LiveEventsManager.OOGPALHPNGM().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.ONCPHEEJLOP().HLCKJEIFAFM((EGMCEPOABBF)8, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("sketches", 189f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM(" ", 177f);
		this.FBCKANHEOMI();
	}

	// Token: 0x06003855 RID: 14421 RVA: 0x00178020 File Offset: 0x00176220
	public void HJMIOBLIDKA(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.IFCHGNCDMLJ = NLLCKPCKGOH;
		this.LLIHNPELOJD();
		for (int i = 1; i < this.varOldObjects.Count; i += 0)
		{
			this.varOldObjects[i].SetActive(true);
		}
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j++)
			{
				if (assetAnthology.header.availableStories[j] == JFCABBGNNKJ.index)
				{
					num = j;
					break;
				}
			}
		}
		this.storyRestartText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().BGELFMIOBCL("Account.ResolveSaveSlots(): Slots sharing not needed") + "availableAchievementsBalance" + (num + 0).ToString(), false);
		this.storyRestartText0.SetText(CCOJBMMKNAP.JMDJPKKOHNI().BGELFMIOBCL("OnNeedToActivateFocusItemCloseButton") + "no" + 0.ToString(), false);
		this.storyRestartTextOff.SetText(CCOJBMMKNAP.OEPENBHJAHO().PGKBCNBAOJN("socialbadge") + " query='" + (num + 1).ToString(), true);
		this.chapterRestartText.SetText(CCOJBMMKNAP.EHBBFMCILPC.JHNELLJFBGC("") + "; " + (OLKMHHNMDLP + 0).ToString(), true);
		this.chapterRestartTextOff.SetText(CCOJBMMKNAP.DBFFFOMCLKM().DNILNCLIHAP(", ") + "" + (OLKMHHNMDLP + 1).ToString(), true);
		bool flag = false;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = false;
			if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, OLKMHHNMDLP))
			{
				this.currencyInfoEpisode.SetActive(true);
			}
			else
			{
				this.currencyInfoEpisode.SetActive(false);
			}
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.buttonRestartChapter.gameObject.SetActive(true);
		}
		else
		{
			this.currencyInfoEpisode.SetActive(true);
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.buttonRestartChapter.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(NLLCKPCKGOH, 1))
		{
			this.currencyInfoSeason.SetActive(true);
		}
		else
		{
			this.currencyInfoSeason.SetActive(true);
		}
		this.buttonRestartStory.gameObject.SetActive(true);
		this.buttonRestartStoryOff.gameObject.SetActive(false);
		if (OLKMHHNMDLP == 0 && this.buttonRestartChapterOff.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(true);
			this.currencyInfoSeason.SetActive(false);
		}
		if (num == 0)
		{
			this.buttonRestartStory0.gameObject.SetActive(false);
		}
		else
		{
			this.buttonRestartStory0.gameObject.SetActive(false);
		}
		if (OLKMHHNMDLP == 0 && num > 1 && this.buttonRestartChapter.gameObject.activeSelf && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.buttonRestartStory.gameObject.SetActive(true);
			this.currencyInfoSeason.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(false);
			this.currencyInfoEpisode.gameObject.SetActive(true);
		}
		if (num > 0 && this.buttonRestartChapter.gameObject.activeSelf)
		{
			this.currencyInfoEpisode.gameObject.SetActive(true);
		}
		if (num > 1 && this.buttonRestartStory.gameObject.activeSelf)
		{
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
		if (LiveEventsManager.EHBBFMCILPC.AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.JCMABFEMFKD().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeTea, NLLCKPCKGOH, -1))
		{
			this.currencyInfoEpisode.gameObject.SetActive(false);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
		if (JFCABBGNNKJ.totalChaptersCount == 1 && !BAOKJBJIFBH.DHONIOBOLEL.GEMOAPPJPMP())
		{
			if (flag)
			{
				this.buttonRestartStory.gameObject.SetActive(false);
				this.buttonRestartStory0.gameObject.SetActive(true);
				this.buttonRestartStoryOff.gameObject.SetActive(true);
				this.currencyInfoSeason.gameObject.SetActive(true);
				return;
			}
			this.buttonRestartChapter.gameObject.SetActive(true);
			this.buttonRestartChapterOff.gameObject.SetActive(false);
			this.currencyInfoEpisode.SetActive(true);
			this.buttonRestartStory.gameObject.SetActive(true);
			this.buttonRestartStoryOff.gameObject.SetActive(false);
			this.storyRestartText.SetText(CCOJBMMKNAP.AEELGGPEJCC().OHLNGCKIACD("continue"), true);
			this.currencyInfoSeason.gameObject.SetActive(false);
		}
	}

	// Token: 0x06003856 RID: 14422 RVA: 0x001784CC File Offset: 0x001766CC
	public void OOGKGEEMKIE()
	{
		if (!this.currencyInfoEpisode.gameObject.activeSelf)
		{
			AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("Asset bundle assets destroyed:", 1190f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.PONAPMOOLIN() > 1 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.NMGMNAKLLMI().AJKBOOKAPBL((EGMCEPOABBF)7, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("nick", 114f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("ok", 139f);
		this.LFCEPINKDEE();
	}

	// Token: 0x06003858 RID: 14424 RVA: 0x00178574 File Offset: 0x00176774
	public void PGLKOOJCFMM()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1 || LiveEventsManager.OBOOKJPGBJN().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.JCMABFEMFKD().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeAvatar, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("ok", 523f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("OnSaveSyncAnyResult", 577f);
		this.PMBIJMCONLE();
	}

	// Token: 0x06003859 RID: 14425 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void OMPKGJDLLAB()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600385A RID: 14426 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x001785EC File Offset: 0x001767EC
	public bool ODKJCEPNICD(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		bool result;
		try
		{
			this.Initialize(JFCABBGNNKJ, BAOKJBJIFBH, OLKMHHNMDLP, NLLCKPCKGOH);
			if (this.buttonRestartChapterOff.gameObject.activeSelf && this.buttonRestartStoryOff.gameObject.activeSelf && !this.buttonRestartChapter.gameObject.activeSelf && !this.buttonRestartStory.gameObject.activeSelf && !this.buttonRestartStory0.gameObject.activeSelf)
			{
				result = false;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600385C RID: 14428 RVA: 0x00178680 File Offset: 0x00176880
	public void MPLKIIOOEIN()
	{
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("ant", 1919f);
	}

	// Token: 0x0600385D RID: 14429 RVA: 0x00178698 File Offset: 0x00176898
	public void DOJHLKBBFJE()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.CJLDJAJHMMA() > 0 || LiveEventsManager.ONCPHEEJLOP().OPHKFJNACGB(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().CENBCALNAJN(EGMCEPOABBF.liveEventFreeDiamonds, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("blur", 1716f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND(">", 565f);
		this.EBBKBGAGLAM();
	}

	// Token: 0x0600385E RID: 14430 RVA: 0x00178710 File Offset: 0x00176910
	public bool FODAKMKBFIP(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		bool result;
		try
		{
			this.HJMIOBLIDKA(JFCABBGNNKJ, BAOKJBJIFBH, OLKMHHNMDLP, NLLCKPCKGOH);
			if (this.buttonRestartChapterOff.gameObject.activeSelf && this.buttonRestartStoryOff.gameObject.activeSelf && !this.buttonRestartChapter.gameObject.activeSelf && !this.buttonRestartStory.gameObject.activeSelf && !this.buttonRestartStory0.gameObject.activeSelf)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600385F RID: 14431 RVA: 0x001787A4 File Offset: 0x001769A4
	public void InitializeVariants(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.DisableAllVariants();
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
			{
				if (assetAnthology.header.availableStories[i] == JFCABBGNNKJ.index)
				{
					num = i;
					break;
				}
			}
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(assetAnthology.header.index);
		if (eioplefllim.EGHHCFFLPCP(-1) == 1 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int j = 0; j < this.var3Objects.Count; j++)
			{
				this.var3Objects[j].SetActive(true);
			}
			return;
		}
		if (eioplefllim.EGHHCFFLPCP(-1) == 2 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int k = 0; k < this.var7Objects.Count; k++)
			{
				this.var7Objects[k].SetActive(true);
			}
			return;
		}
		if (eioplefllim.EGHHCFFLPCP(-1) == 3 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int l = 0; l < this.var11Objects.Count; l++)
			{
				this.var11Objects[l].SetActive(true);
			}
			return;
		}
		if (eioplefllim.EGHHCFFLPCP(-1) == 4 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int m = 0; m < this.var15Objects.Count; m++)
			{
				this.var15Objects[m].SetActive(true);
			}
			return;
		}
		if (eioplefllim.EGHHCFFLPCP(-1) == 5 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int n = 0; n < this.var19Objects.Count; n++)
			{
				this.var19Objects[n].SetActive(true);
			}
			return;
		}
		bool flag = false;
		if (BAOKJBJIFBH.OEAMCPHCKIC() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = true;
		}
		if (num == 0)
		{
			if (!flag)
			{
				for (int num2 = 0; num2 < this.var3Objects.Count; num2++)
				{
					this.var3Objects[num2].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num3 = 0; num3 < this.var1Objects.Count; num3++)
				{
					this.var1Objects[num3].SetActive(true);
				}
				return;
			}
			for (int num4 = 0; num4 < this.var2Objects.Count; num4++)
			{
				this.var2Objects[num4].SetActive(true);
			}
			return;
		}
		else if (num == 1)
		{
			if (flag)
			{
				for (int num5 = 0; num5 < this.var6Objects.Count; num5++)
				{
					this.var6Objects[num5].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num6 = 0; num6 < this.var5Objects.Count; num6++)
				{
					this.var5Objects[num6].SetActive(true);
				}
				return;
			}
			for (int num7 = 0; num7 < this.var7Objects.Count; num7++)
			{
				this.var7Objects[num7].SetActive(true);
			}
			return;
		}
		else if (num == 2)
		{
			if (flag)
			{
				for (int num8 = 0; num8 < this.var10Objects.Count; num8++)
				{
					this.var10Objects[num8].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num9 = 0; num9 < this.var9Objects.Count; num9++)
				{
					this.var9Objects[num9].SetActive(true);
				}
				return;
			}
			for (int num10 = 0; num10 < this.var11Objects.Count; num10++)
			{
				this.var11Objects[num10].SetActive(true);
			}
			return;
		}
		else
		{
			if (num != 3)
			{
				if (num == 4)
				{
					if (flag)
					{
						for (int num11 = 0; num11 < this.var18Objects.Count; num11++)
						{
							this.var18Objects[num11].SetActive(true);
						}
						return;
					}
					if (OLKMHHNMDLP == 0)
					{
						for (int num12 = 0; num12 < this.var17Objects.Count; num12++)
						{
							this.var17Objects[num12].SetActive(true);
						}
						return;
					}
					for (int num13 = 0; num13 < this.var19Objects.Count; num13++)
					{
						this.var19Objects[num13].SetActive(true);
					}
				}
				return;
			}
			if (flag)
			{
				for (int num14 = 0; num14 < this.var14Objects.Count; num14++)
				{
					this.var14Objects[num14].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num15 = 0; num15 < this.var13Objects.Count; num15++)
				{
					this.var13Objects[num15].SetActive(true);
				}
				return;
			}
			for (int num16 = 0; num16 < this.var15Objects.Count; num16++)
			{
				this.var15Objects[num16].SetActive(true);
			}
			return;
		}
	}

	// Token: 0x06003860 RID: 14432 RVA: 0x00178CA4 File Offset: 0x00176EA4
	public void RestartStory()
	{
		if (!this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory", 0f);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x06003861 RID: 14433 RVA: 0x00178D44 File Offset: 0x00176F44
	public void IMOFIHBNJEJ()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1 || LiveEventsManager.OOGPALHPNGM().OEHDOMDPHDN(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.JCMABFEMFKD().LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("<", 39f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("vhspause", 483f);
		this.HHDLACJKDON();
	}

	// Token: 0x06003862 RID: 14434 RVA: 0x00178DBB File Offset: 0x00176FBB
	public void FGFADMFOGFB()
	{
		AOBJLALDBAA.DBLAIDPICIG().EFBNBFIDEOK("anthologiestitle", 823f);
	}

	// Token: 0x06003863 RID: 14435 RVA: 0x00172562 File Offset: 0x00170762
	public void FBCKANHEOMI()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003864 RID: 14436 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void CCEDMIEHNNP()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003865 RID: 14437 RVA: 0x00178DD1 File Offset: 0x00176FD1
	public void AJAKLDENEBB()
	{
		if (this.currencyInfoSeason.gameObject.activeSelf)
		{
			AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("OnBackendRequestSendMessageException", 294f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("no", 1071f);
	}

	// Token: 0x06003866 RID: 14438 RVA: 0x00178E10 File Offset: 0x00177010
	public void JJLHGOAEIDI(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH, int OLKMHHNMDLP, int NLLCKPCKGOH)
	{
		this.LLIHNPELOJD();
		int num = 0;
		AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(JFCABBGNNKJ.index);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i++)
			{
				if (assetAnthology.header.availableStories[i] == JFCABBGNNKJ.index)
				{
					num = i;
					break;
				}
			}
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.MLIDICIPNDK(assetAnthology.header.index);
		if (eioplefllim.EGHHCFFLPCP(-1) == 1 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int j = 1; j < this.var3Objects.Count; j += 0)
			{
				this.var3Objects[j].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EKONMCADECD(-1) == 4 && eioplefllim.EGHHCFFLPCP(-1) == assetAnthology.header.maxStories)
		{
			for (int k = 0; k < this.var7Objects.Count; k++)
			{
				this.var7Objects[k].SetActive(false);
			}
			return;
		}
		if (eioplefllim.EBNCOCHCHGN(-1) == 6 && eioplefllim.JDCFLEOBCMC(-1) == assetAnthology.header.maxStories)
		{
			for (int l = 0; l < this.var11Objects.Count; l += 0)
			{
				this.var11Objects[l].SetActive(false);
			}
			return;
		}
		if (eioplefllim.JDCFLEOBCMC(-1) == 2 && eioplefllim.LCONOAKIPLO(-1) == assetAnthology.header.maxStories)
		{
			for (int m = 0; m < this.var15Objects.Count; m++)
			{
				this.var15Objects[m].SetActive(true);
			}
			return;
		}
		if (eioplefllim.ENAJCKIAJFK(-1) == 7 && eioplefllim.LCONOAKIPLO(-1) == assetAnthology.header.maxStories)
		{
			for (int n = 1; n < this.var19Objects.Count; n += 0)
			{
				this.var19Objects[n].SetActive(true);
			}
			return;
		}
		bool flag = true;
		if (BAOKJBJIFBH.OIJJMHKPOAI() && PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage)
		{
			flag = false;
		}
		if (num == 0)
		{
			if (!flag)
			{
				for (int num2 = 0; num2 < this.var3Objects.Count; num2 += 0)
				{
					this.var3Objects[num2].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num3 = 1; num3 < this.var1Objects.Count; num3++)
				{
					this.var1Objects[num3].SetActive(true);
				}
				return;
			}
			for (int num4 = 1; num4 < this.var2Objects.Count; num4 += 0)
			{
				this.var2Objects[num4].SetActive(true);
			}
			return;
		}
		else if (num == 1)
		{
			if (flag)
			{
				for (int num5 = 0; num5 < this.var6Objects.Count; num5 += 0)
				{
					this.var6Objects[num5].SetActive(false);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num6 = 0; num6 < this.var5Objects.Count; num6++)
				{
					this.var5Objects[num6].SetActive(false);
				}
				return;
			}
			for (int num7 = 1; num7 < this.var7Objects.Count; num7++)
			{
				this.var7Objects[num7].SetActive(true);
			}
			return;
		}
		else if (num == 1)
		{
			if (flag)
			{
				for (int num8 = 1; num8 < this.var10Objects.Count; num8 += 0)
				{
					this.var10Objects[num8].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num9 = 0; num9 < this.var9Objects.Count; num9 += 0)
				{
					this.var9Objects[num9].SetActive(true);
				}
				return;
			}
			for (int num10 = 1; num10 < this.var11Objects.Count; num10 += 0)
			{
				this.var11Objects[num10].SetActive(false);
			}
			return;
		}
		else
		{
			if (num != 8)
			{
				if (num == 0)
				{
					if (flag)
					{
						for (int num11 = 0; num11 < this.var18Objects.Count; num11 += 0)
						{
							this.var18Objects[num11].SetActive(false);
						}
						return;
					}
					if (OLKMHHNMDLP == 0)
					{
						for (int num12 = 0; num12 < this.var17Objects.Count; num12++)
						{
							this.var17Objects[num12].SetActive(false);
						}
						return;
					}
					for (int num13 = 0; num13 < this.var19Objects.Count; num13++)
					{
						this.var19Objects[num13].SetActive(false);
					}
				}
				return;
			}
			if (flag)
			{
				for (int num14 = 1; num14 < this.var14Objects.Count; num14 += 0)
				{
					this.var14Objects[num14].SetActive(true);
				}
				return;
			}
			if (OLKMHHNMDLP == 0)
			{
				for (int num15 = 1; num15 < this.var13Objects.Count; num15++)
				{
					this.var13Objects[num15].SetActive(false);
				}
				return;
			}
			for (int num16 = 0; num16 < this.var15Objects.Count; num16++)
			{
				this.var15Objects[num16].SetActive(true);
			}
			return;
		}
	}

	// Token: 0x06003867 RID: 14439 RVA: 0x00179310 File Offset: 0x00177510
	public void NewRestartStory4Tea()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory4", 0f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0f);
		this.Hide();
	}

	// Token: 0x06003868 RID: 14440 RVA: 0x00179388 File Offset: 0x00177588
	public void PGKNEIMPFMI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.BADNAGEMINF() > 0 || LiveEventsManager.JCMABFEMFKD().LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.AJKBOOKAPBL(EGMCEPOABBF.liveEventBonusStory, this.IFCHGNCDMLJ, -1))
		{
			AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("", 186f);
			return;
		}
		SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("errortitle", 1257f);
		this.FBCKANHEOMI();
	}

	// Token: 0x0400109E RID: 4254
	public const string onPopupStoryRestartManagerRestartChapter = "OnPopupStoryRestartManagerRestartChapter";

	// Token: 0x0400109F RID: 4255
	public const string onPopupStoryRestartManagerRestartStory = "OnPopupStoryRestartManagerRestartStory";

	// Token: 0x040010A0 RID: 4256
	public const string onPopupStoryRestartManagerRestartStory0 = "OnPopupStoryRestartManagerRestartStory0";

	// Token: 0x040010A1 RID: 4257
	public const string onPopupStoryRestartManagerRestartStory1 = "OnPopupStoryRestartManagerRestartStory1";

	// Token: 0x040010A2 RID: 4258
	public const string onPopupStoryRestartManagerRestartStory2 = "OnPopupStoryRestartManagerRestartStory2";

	// Token: 0x040010A3 RID: 4259
	public const string onPopupStoryRestartManagerRestartStory3 = "OnPopupStoryRestartManagerRestartStory3";

	// Token: 0x040010A4 RID: 4260
	public const string onPopupStoryRestartManagerRestartStory4 = "OnPopupStoryRestartManagerRestartStory4";

	// Token: 0x040010A5 RID: 4261
	public static bool currentChapterAvailableForSelectedLanguage = true;

	// Token: 0x040010A6 RID: 4262
	public Button buttonRestartChapter;

	// Token: 0x040010A7 RID: 4263
	public Button buttonRestartChapterOff;

	// Token: 0x040010A8 RID: 4264
	public Button buttonRestartStory;

	// Token: 0x040010A9 RID: 4265
	public Button buttonRestartStoryOff;

	// Token: 0x040010AA RID: 4266
	public Button buttonRestartStory0;

	// Token: 0x040010AB RID: 4267
	public TextMeshProUGUI storyRestartText;

	// Token: 0x040010AC RID: 4268
	public TextMeshProUGUI storyRestartTextOff;

	// Token: 0x040010AD RID: 4269
	public TextMeshProUGUI storyRestartText0;

	// Token: 0x040010AE RID: 4270
	public TextMeshProUGUI chapterRestartText;

	// Token: 0x040010AF RID: 4271
	public TextMeshProUGUI chapterRestartTextOff;

	// Token: 0x040010B0 RID: 4272
	public GameObject currencyInfoEpisode;

	// Token: 0x040010B1 RID: 4273
	public GameObject currencyInfoSeason;

	// Token: 0x040010B2 RID: 4274
	public List<GameObject> varOldObjects;

	// Token: 0x040010B3 RID: 4275
	public List<GameObject> var1Objects;

	// Token: 0x040010B4 RID: 4276
	public List<GameObject> var2Objects;

	// Token: 0x040010B5 RID: 4277
	public List<GameObject> var3Objects;

	// Token: 0x040010B6 RID: 4278
	public List<GameObject> var4Objects;

	// Token: 0x040010B7 RID: 4279
	public List<GameObject> var5Objects;

	// Token: 0x040010B8 RID: 4280
	public List<GameObject> var6Objects;

	// Token: 0x040010B9 RID: 4281
	public List<GameObject> var7Objects;

	// Token: 0x040010BA RID: 4282
	public List<GameObject> var8Objects;

	// Token: 0x040010BB RID: 4283
	public List<GameObject> var9Objects;

	// Token: 0x040010BC RID: 4284
	public List<GameObject> var10Objects;

	// Token: 0x040010BD RID: 4285
	public List<GameObject> var11Objects;

	// Token: 0x040010BE RID: 4286
	public List<GameObject> var12Objects;

	// Token: 0x040010BF RID: 4287
	public List<GameObject> var13Objects;

	// Token: 0x040010C0 RID: 4288
	public List<GameObject> var14Objects;

	// Token: 0x040010C1 RID: 4289
	public List<GameObject> var15Objects;

	// Token: 0x040010C2 RID: 4290
	public List<GameObject> var16Objects;

	// Token: 0x040010C3 RID: 4291
	public List<GameObject> var17Objects;

	// Token: 0x040010C4 RID: 4292
	public List<GameObject> var18Objects;

	// Token: 0x040010C5 RID: 4293
	public List<GameObject> var19Objects;

	// Token: 0x040010C6 RID: 4294
	public List<GameObject> var20Objects;

	// Token: 0x040010C7 RID: 4295
	private int IFCHGNCDMLJ;
}
