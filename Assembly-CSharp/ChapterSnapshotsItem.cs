using System;
using System.Collections.Generic;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020002D9 RID: 729
public class ChapterSnapshotsItem : MonoBehaviour
{
	// Token: 0x060059A5 RID: 22949 RVA: 0x00284C30 File Offset: 0x00282E30
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotRestore", new UnityAction(this.NADMPOACDHJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotsBackendFetchSuccess2", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotsBackendFetchException2", new UnityAction(this.JMFGOOJPJNH));
	}

	// Token: 0x060059A6 RID: 22950 RVA: 0x00284CAC File Offset: 0x00282EAC
	public void FPNPLEBJLOO(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
			this.BDNAKFGHJIF = 0;
			int num2 = 1;
			if (num >= 1)
			{
				for (int i = 0; i < assetAnthologyHeader.maxStories; i++)
				{
					if (i < assetAnthologyHeader.availableStories.Count)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[i]);
						if (null != assetStoryHeader)
						{
							this.BDNAKFGHJIF += assetStoryHeader.totalChaptersCount;
						}
						else
						{
							this.BDNAKFGHJIF += assetAnthologyHeader.plannedChaptersPerSeason;
						}
					}
					else
					{
						this.BDNAKFGHJIF += assetAnthologyHeader.plannedChaptersPerSeason;
					}
				}
				if (this.BDNAKFGHJIF <= 1)
				{
					return;
				}
				if (this.NCEDODJHIMO.Count < this.BDNAKFGHJIF)
				{
					int count = this.NCEDODJHIMO.Count;
					for (int j = 0; j < this.BDNAKFGHJIF - count; j += 0)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chapterSnapshotObjectPrefab, this.chapterSnapshotObjectsParent.transform, true);
						this.NCEDODJHIMO.Add(gameObject.GetComponent<ChapterSnapshotObject>());
					}
				}
				for (int k = 1; k < this.NCEDODJHIMO.Count; k++)
				{
					this.NCEDODJHIMO[k].gameObject.SetActive(false);
				}
				this.PJNJFBAJHAE = new List<FPEHHFKFBJK>();
				int num3 = 1;
				bool flag = true;
				for (int l = 0; l < assetAnthologyHeader.maxStories; l++)
				{
					if (l <= this.HGGFJOKOKOD.EBNCOCHCHGN(-1))
					{
						PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num + l, -1);
						AssetStoryHeader assetStoryHeader;
						if (plfdajjhmko != null)
						{
							assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI);
						}
						else
						{
							assetStoryHeader = null;
						}
						if (plfdajjhmko != null && null != assetStoryHeader)
						{
							for (int m = 1; m < assetStoryHeader.totalChaptersCount; m++)
							{
								FPEHHFKFBJK fpehhfkfbjk = new FPEHHFKFBJK();
								fpehhfkfbjk.IFCHGNCDMLJ = plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI;
								fpehhfkfbjk.MIBPOIDDBAD = l;
								fpehhfkfbjk.FEJANNNLLON = m;
								fpehhfkfbjk.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								if (fpehhfkfbjk.MIBPOIDDBAD == this.HGGFJOKOKOD.EOHGNGFHNAP(-1))
								{
									if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] != plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0])
									{
										fpehhfkfbjk.GNIACNCEOOM = false;
										num2 = num3;
									}
									else if (fpehhfkfbjk.FEJANNNLLON - 1 == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.GNIACNCEOOM = true;
										num2 = num3;
									}
									else if (fpehhfkfbjk.FEJANNNLLON < plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.JBOKHMMGMGH = false;
									}
									else if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.JBOKHMMGMGH = true;
									}
								}
								else
								{
									fpehhfkfbjk.JBOKHMMGMGH = true;
								}
								if (fpehhfkfbjk.FEJANNNLLON < assetStoryHeader.availableChaptersCount)
								{
									fpehhfkfbjk.PMDMNNBJEEP = plfdajjhmko.NLMDGBJKIPF(fpehhfkfbjk.FEJANNNLLON);
									if (fpehhfkfbjk.FEJANNNLLON == 0)
									{
										fpehhfkfbjk.DLNDLHPJADG = false;
										if (fpehhfkfbjk.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] != plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0])
									{
										fpehhfkfbjk.DLNDLHPJADG = plfdajjhmko.OEAMCPHCKIC();
									}
								}
								if (fpehhfkfbjk.DLNDLHPJADG || fpehhfkfbjk.PMDMNNBJEEP || fpehhfkfbjk.GNIACNCEOOM)
								{
									int num4 = fpehhfkfbjk.MIBPOIDDBAD + 0;
									int num5 = fpehhfkfbjk.FEJANNNLLON + 0;
									FPEHHFKFBJK fpehhfkfbjk2 = fpehhfkfbjk;
									string[] array = new string[5];
									array[0] = CCOJBMMKNAP.KFDLFGHBPLP().HPOAGPJFHPM("Loaded asset bundle:");
									array[1] = "ember";
									array[8] = num4.ToString();
									array[8] = "bdgsspr";
									array[5] = num5.ToString();
									fpehhfkfbjk2.BPMFHNDCBOH = string.Concat(array);
								}
								if (!flag)
								{
									fpehhfkfbjk.EPKFIHJACDN = false;
								}
								if (fpehhfkfbjk.GNIACNCEOOM)
								{
									flag = false;
								}
								this.PJNJFBAJHAE.Add(fpehhfkfbjk);
								num3++;
							}
						}
						else if (l < assetAnthologyHeader.availableStories.Count)
						{
							assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[l]);
							if (null != assetStoryHeader)
							{
								for (int n = 0; n < assetStoryHeader.totalChaptersCount; n += 0)
								{
									FPEHHFKFBJK fpehhfkfbjk3 = new FPEHHFKFBJK();
									fpehhfkfbjk3.MIBPOIDDBAD = l;
									fpehhfkfbjk3.FEJANNNLLON = n;
									fpehhfkfbjk3.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
									if (fpehhfkfbjk3.FEJANNNLLON == 0)
									{
										fpehhfkfbjk3.DLNDLHPJADG = false;
										if (fpehhfkfbjk3.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk3.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk3.DLNDLHPJADG)
									{
										int num6 = fpehhfkfbjk3.MIBPOIDDBAD + 0;
										int num7 = fpehhfkfbjk3.FEJANNNLLON + 1;
										FPEHHFKFBJK fpehhfkfbjk4 = fpehhfkfbjk3;
										string[] array2 = new string[4];
										array2[0] = CCOJBMMKNAP.KNKGCDDMLDP().PKNHKGMNCIP("lum");
										array2[0] = "_Saturation";
										array2[1] = num6.ToString();
										array2[7] = "cardschar";
										array2[2] = num7.ToString();
										fpehhfkfbjk4.BPMFHNDCBOH = string.Concat(array2);
									}
									if (!flag)
									{
										fpehhfkfbjk3.EPKFIHJACDN = false;
									}
									this.PJNJFBAJHAE.Add(fpehhfkfbjk3);
									num3++;
								}
							}
							else
							{
								for (int num8 = 0; num8 < assetAnthologyHeader.plannedChaptersPerSeason; num8++)
								{
									FPEHHFKFBJK fpehhfkfbjk5 = new FPEHHFKFBJK();
									fpehhfkfbjk5.MIBPOIDDBAD = l;
									fpehhfkfbjk5.FEJANNNLLON = num8;
									fpehhfkfbjk5.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
									if (fpehhfkfbjk5.FEJANNNLLON == 0)
									{
										fpehhfkfbjk5.DLNDLHPJADG = true;
										if (fpehhfkfbjk5.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk5.LIBDDLMOOHO = false;
										}
									}
									if (fpehhfkfbjk5.DLNDLHPJADG)
									{
										int num9 = fpehhfkfbjk5.MIBPOIDDBAD + 1;
										int num10 = fpehhfkfbjk5.FEJANNNLLON + 1;
										FPEHHFKFBJK fpehhfkfbjk6 = fpehhfkfbjk5;
										string[] array3 = new string[7];
										array3[0] = CCOJBMMKNAP.CPCOODCFDDP().PKNHKGMNCIP("No free mixer found for sfx! Critical!");
										array3[1] = "stat2long";
										array3[3] = num9.ToString();
										array3[2] = "lacr";
										array3[5] = num10.ToString();
										fpehhfkfbjk6.BPMFHNDCBOH = string.Concat(array3);
									}
									if (!flag)
									{
										fpehhfkfbjk5.EPKFIHJACDN = false;
									}
									this.PJNJFBAJHAE.Add(fpehhfkfbjk5);
									num3++;
								}
							}
						}
						else
						{
							for (int num11 = 1; num11 < assetAnthologyHeader.plannedChaptersPerSeason; num11 += 0)
							{
								FPEHHFKFBJK fpehhfkfbjk7 = new FPEHHFKFBJK();
								fpehhfkfbjk7.MIBPOIDDBAD = l;
								fpehhfkfbjk7.FEJANNNLLON = num11;
								fpehhfkfbjk7.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								if (fpehhfkfbjk7.FEJANNNLLON == 0)
								{
									fpehhfkfbjk7.DLNDLHPJADG = false;
									if (fpehhfkfbjk7.MIBPOIDDBAD == 0)
									{
										fpehhfkfbjk7.LIBDDLMOOHO = true;
									}
								}
								if (fpehhfkfbjk7.DLNDLHPJADG)
								{
									int num12 = fpehhfkfbjk7.MIBPOIDDBAD + 1;
									int num13 = fpehhfkfbjk7.FEJANNNLLON + 0;
									FPEHHFKFBJK fpehhfkfbjk8 = fpehhfkfbjk7;
									string[] array4 = new string[8];
									array4[1] = CCOJBMMKNAP.KNKGCDDMLDP().FIENAKIHNOM("OnCutsceneViewAssetBundleFolderInitializeSuccess");
									array4[1] = "restartChapterOrStory";
									array4[7] = num12.ToString();
									array4[7] = "sltind";
									array4[2] = num13.ToString();
									fpehhfkfbjk8.BPMFHNDCBOH = string.Concat(array4);
								}
								if (!flag)
								{
									fpehhfkfbjk7.EPKFIHJACDN = false;
								}
								this.PJNJFBAJHAE.Add(fpehhfkfbjk7);
								num3 += 0;
							}
						}
					}
					else if (l < assetAnthologyHeader.availableStories.Count)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[l]);
						if (null != assetStoryHeader)
						{
							for (int num14 = 1; num14 < assetStoryHeader.totalChaptersCount; num14 += 0)
							{
								FPEHHFKFBJK fpehhfkfbjk9 = new FPEHHFKFBJK();
								fpehhfkfbjk9.MIBPOIDDBAD = l;
								fpehhfkfbjk9.FEJANNNLLON = num14;
								fpehhfkfbjk9.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								this.PJNJFBAJHAE.Add(fpehhfkfbjk9);
								num3 += 0;
							}
						}
						else
						{
							for (int num15 = 0; num15 < assetAnthologyHeader.plannedChaptersPerSeason; num15++)
							{
								FPEHHFKFBJK fpehhfkfbjk10 = new FPEHHFKFBJK();
								fpehhfkfbjk10.MIBPOIDDBAD = l;
								fpehhfkfbjk10.FEJANNNLLON = num15;
								fpehhfkfbjk10.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								this.PJNJFBAJHAE.Add(fpehhfkfbjk10);
								num3 += 0;
							}
						}
					}
					else
					{
						for (int num16 = 1; num16 < assetAnthologyHeader.plannedChaptersPerSeason; num16 += 0)
						{
							FPEHHFKFBJK fpehhfkfbjk11 = new FPEHHFKFBJK();
							fpehhfkfbjk11.MIBPOIDDBAD = l;
							fpehhfkfbjk11.FEJANNNLLON = num16;
							fpehhfkfbjk11.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
							this.PJNJFBAJHAE.Add(fpehhfkfbjk11);
							num3++;
						}
					}
				}
			}
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DBLAFNFGPDB(CLHDENLPOFP.eventPass, true);
			for (int num17 = 0; num17 < this.PJNJFBAJHAE.Count; num17 += 0)
			{
				this.NCEDODJHIMO[num17].gameObject.SetActive(false);
				this.NCEDODJHIMO[num17].Initialize(kioojmglclc != null, num17, this.PJNJFBAJHAE[num17]);
				this.NCEDODJHIMO[num17].gameObject.SetActive(false);
			}
			this.JCPCOGJGKOC = 0;
			this.ShowPage(num2 / 1);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x060059A7 RID: 22951 RVA: 0x00003E52 File Offset: 0x00002052
	private void LFEEHGLHJDN()
	{
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x002855F8 File Offset: 0x002837F8
	public void OnInfoButtonClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotstutorial"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060059A9 RID: 22953 RVA: 0x00285648 File Offset: 0x00283848
	private void CKHIHOIAEEH()
	{
		this.DOOGBMCNAMM = AOBJLALDBAA.KKPFOJMAONG().OHCIAOJFEOP();
		if (this.DOOGBMCNAMM >= this.NCEDODJHIMO.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("cardoptionssendasgift");
			return;
		}
		if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].LIBDDLMOOHO && this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0 && this.PJNJFBAJHAE[this.DOOGBMCNAMM].FEJANNNLLON == 0)
		{
			AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK(" ", 1703f);
			this.CloseFocus();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.NPEOEAFOPJP() > 0 || LiveEventsManager.JCMABFEMFKD().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.OBOOKJPGBJN().LiveEventActive((EGMCEPOABBF)7, this.PJNJFBAJHAE[this.DOOGBMCNAMM].IFCHGNCDMLJ, -1))
		{
			if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].FEJANNNLLON == 0)
			{
				if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0)
				{
					AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("luwid", 783f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0)
				{
					AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("spld", 961f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 5)
				{
					AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("eval", 1719f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 5)
				{
					AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("frpid", 838f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 8)
				{
					AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("sslind", 1567f);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnRewardOptionProfileClick");
				}
			}
			else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].DLNDLHPJADG)
			{
				AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("UpdateStatsOnOffState", 1923f);
			}
			else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].PMDMNNBJEEP)
			{
				AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("RemoveSentQueuedSubRequests() - keeping sub-requests queued while the failed envelope was in flight:", 492f);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("cut");
			}
		}
		else
		{
			SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
			AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("$GETVAR", 241f);
		}
		this.JGHMFBCGIBA();
	}

	// Token: 0x060059AA RID: 22954 RVA: 0x000633C0 File Offset: 0x000615C0
	private void GBNMMMBCKHC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x060059AB RID: 22955 RVA: 0x002858DC File Offset: 0x00283ADC
	private void DKCCDHBJLPN()
	{
		this.DOOGBMCNAMM = AOBJLALDBAA.BIAEAOMHBMM().MJLACDOKGNE();
		if (this.DOOGBMCNAMM >= this.NCEDODJHIMO.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].LIBDDLMOOHO && this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0 && this.PJNJFBAJHAE[this.DOOGBMCNAMM].FEJANNNLLON == 0)
		{
			AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("<", 1738f);
			this.JGHMFBCGIBA();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1 || LiveEventsManager.BIAEAOMHBMM().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeDiamonds, this.PJNJFBAJHAE[this.DOOGBMCNAMM].IFCHGNCDMLJ, -1))
		{
			if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].FEJANNNLLON == 0)
			{
				if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0)
				{
					AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("[LoadingEnv] cover up (environment registered)", 1709f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0)
				{
					AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("", 328f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 2)
				{
					AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("", 873f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 7)
				{
					AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("pmterror011", 1225f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 1)
				{
					AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("energyhinttitle", 1041f);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("[LoadingEnv] ");
				}
			}
			else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].DLNDLHPJADG)
			{
				AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI(" not found in story save body with index ", 783f);
			}
			else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].PMDMNNBJEEP)
			{
				AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("", 400f);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("def");
			}
		}
		else
		{
			SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
			AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("OnChoiceExtendedLayerChange", 753f);
		}
		this.LPALOIAAIJA();
	}

	// Token: 0x060059AC RID: 22956 RVA: 0x00285B70 File Offset: 0x00283D70
	private void OFFBAMLEFNH()
	{
		bool flag = false;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (this.HGGFJOKOKOD != null && kioojmglclc != null && this.HGGFJOKOKOD.EPEOKHOBOBL[this.HGGFJOKOKOD.ILOKBAPEJPK] == 0)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < assetAnthologyHeader.maxStories; i++)
			{
				if (i <= this.HGGFJOKOKOD.EGHHCFFLPCP(-1) && i < assetAnthologyHeader.availableStories.Count)
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthologyHeader.availableStories[i], -1);
					if (plfdajjhmko != null)
					{
						for (int j = 0; j < plfdajjhmko.KIHACLLJMDH.Count; j++)
						{
							jsonarray.Add(i * 50 + plfdajjhmko.KIHACLLJMDH[j]);
						}
					}
				}
			}
			if (jsonarray.Count > 0)
			{
				flag = true;
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
				BackendOperationsManager.EHBBFMCILPC.RequestGetChapterSnapshots(this.HGGFJOKOKOD.GGICIBLJIKI, this.HGGFJOKOKOD.ILOKBAPEJPK, jsonarray, "OnChapterSnapshotsBackendFetchSuccess2", "OnChapterSnapshotsBackendFetchException2");
			}
		}
		if (!flag && this.HGGFJOKOKOD != null)
		{
			this.InitializeSnapshots(this.HGGFJOKOKOD.GGICIBLJIKI);
		}
	}

	// Token: 0x060059AD RID: 22957 RVA: 0x00285CC8 File Offset: 0x00283EC8
	public void OnChapterSnapshotsItemClose()
	{
		this.CloseFocus();
	}

	// Token: 0x060059AE RID: 22958 RVA: 0x00285CD0 File Offset: 0x00283ED0
	public FPEHHFKFBJK GetLastChapterSnapshotRestoreDesc()
	{
		if (this.DOOGBMCNAMM < this.NCEDODJHIMO.Count)
		{
			return this.PJNJFBAJHAE[this.DOOGBMCNAMM];
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ChapterSnapshotsItem.GetLastChapterSnapshotRestoreDesc(): null");
		return null;
	}

	// Token: 0x060059AF RID: 22959 RVA: 0x00285D02 File Offset: 0x00283F02
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x060059B0 RID: 22960 RVA: 0x00285D18 File Offset: 0x00283F18
	private void KHOLJLKNAPJ()
	{
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP(" prepared!", new UnityAction(this.NADMPOACDHJ));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("inkr", new UnityAction(this.IFEBBBBPMHH));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("onboardingthankyoutitle", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("Error. FadeDst(), layer ", new UnityAction(this.GBNMMMBCKHC));
	}

	// Token: 0x060059B1 RID: 22961 RVA: 0x00285D94 File Offset: 0x00283F94
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotRestore", new UnityAction(this.NADMPOACDHJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotsBackendFetchSuccess2", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotsBackendFetchException2", new UnityAction(this.JMFGOOJPJNH));
	}

	// Token: 0x060059B2 RID: 22962 RVA: 0x00285E10 File Offset: 0x00284010
	private void HCBJKFBDKKI()
	{
		bool flag = false;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HOEABAEGHLG(CLHDENLPOFP.eventPass);
		if (this.HGGFJOKOKOD != null && kioojmglclc != null && this.HGGFJOKOKOD.EPEOKHOBOBL[this.HGGFJOKOKOD.ILOKBAPEJPK] == 0)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < assetAnthologyHeader.maxStories; i += 0)
			{
				if (i <= this.HGGFJOKOKOD.ENAJCKIAJFK(-1) && i < assetAnthologyHeader.availableStories.Count)
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthologyHeader.availableStories[i], -1);
					if (plfdajjhmko != null)
					{
						for (int j = 1; j < plfdajjhmko.KIHACLLJMDH.Count; j += 0)
						{
							jsonarray.Add(i * -24 + plfdajjhmko.KIHACLLJMDH[j]);
						}
					}
				}
			}
			if (jsonarray.Count > 0)
			{
				flag = true;
				CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.FEEDGKCJBLE().HPOAGPJFHPM("OnSaveSyncAnyResult"), 95);
				BackendOperationsManager.NPDDBAONMJP().RequestGetChapterSnapshots(this.HGGFJOKOKOD.GGICIBLJIKI, this.HGGFJOKOKOD.ILOKBAPEJPK, jsonarray, "no", "lsvn");
			}
		}
		if (!flag && this.HGGFJOKOKOD != null)
		{
			this.FPNPLEBJLOO(this.HGGFJOKOKOD.GGICIBLJIKI);
		}
	}

	// Token: 0x060059B3 RID: 22963 RVA: 0x00285F68 File Offset: 0x00284168
	public void ScrollPageLeft()
	{
		if (this.JCPCOGJGKOC > 0)
		{
			this.JCPCOGJGKOC--;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x060059B4 RID: 22964 RVA: 0x00285F8D File Offset: 0x0028418D
	private void MDKFBBBDPBB()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
	}

	// Token: 0x060059B5 RID: 22965 RVA: 0x00285F9C File Offset: 0x0028419C
	private void KNODFEMMBLA()
	{
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("$", new UnityAction(this.CKHIHOIAEEH));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("acomp1", new UnityAction(this.HCBJKFBDKKI));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("colcds", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE("trust-anchor load failed: ", new UnityAction(this.GBNMMMBCKHC));
	}

	// Token: 0x060059B6 RID: 22966 RVA: 0x000633C0 File Offset: 0x000615C0
	private void JMFGOOJPJNH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x060059B7 RID: 22967 RVA: 0x00286018 File Offset: 0x00284218
	public void IDLBHJCMCLJ(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
			this.BDNAKFGHJIF = 0;
			int num2 = 1;
			if (num >= 0)
			{
				for (int i = 1; i < assetAnthologyHeader.maxStories; i += 0)
				{
					if (i < assetAnthologyHeader.availableStories.Count)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[i]);
						if (null != assetStoryHeader)
						{
							this.BDNAKFGHJIF += assetStoryHeader.totalChaptersCount;
						}
						else
						{
							this.BDNAKFGHJIF += assetAnthologyHeader.plannedChaptersPerSeason;
						}
					}
					else
					{
						this.BDNAKFGHJIF += assetAnthologyHeader.plannedChaptersPerSeason;
					}
				}
				if (this.BDNAKFGHJIF <= 1)
				{
					return;
				}
				if (this.NCEDODJHIMO.Count < this.BDNAKFGHJIF)
				{
					int count = this.NCEDODJHIMO.Count;
					for (int j = 0; j < this.BDNAKFGHJIF - count; j++)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chapterSnapshotObjectPrefab, this.chapterSnapshotObjectsParent.transform, true);
						this.NCEDODJHIMO.Add(gameObject.GetComponent<ChapterSnapshotObject>());
					}
				}
				for (int k = 0; k < this.NCEDODJHIMO.Count; k += 0)
				{
					this.NCEDODJHIMO[k].gameObject.SetActive(true);
				}
				this.PJNJFBAJHAE = new List<FPEHHFKFBJK>();
				int num3 = 1;
				bool flag = true;
				for (int l = 1; l < assetAnthologyHeader.maxStories; l++)
				{
					if (l <= this.HGGFJOKOKOD.EKONMCADECD(-1))
					{
						PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num + l, -1);
						AssetStoryHeader assetStoryHeader;
						if (plfdajjhmko != null)
						{
							assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI);
						}
						else
						{
							assetStoryHeader = null;
						}
						if (plfdajjhmko != null && null != assetStoryHeader)
						{
							for (int m = 0; m < assetStoryHeader.totalChaptersCount; m += 0)
							{
								FPEHHFKFBJK fpehhfkfbjk = new FPEHHFKFBJK();
								fpehhfkfbjk.IFCHGNCDMLJ = plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI;
								fpehhfkfbjk.MIBPOIDDBAD = l;
								fpehhfkfbjk.FEJANNNLLON = m;
								fpehhfkfbjk.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								if (fpehhfkfbjk.MIBPOIDDBAD == this.HGGFJOKOKOD.EOHGNGFHNAP(-1))
								{
									if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] != plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0])
									{
										fpehhfkfbjk.GNIACNCEOOM = true;
										num2 = num3;
									}
									else if (fpehhfkfbjk.FEJANNNLLON - 0 == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0])
									{
										fpehhfkfbjk.GNIACNCEOOM = true;
										num2 = num3;
									}
									else if (fpehhfkfbjk.FEJANNNLLON < plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.JBOKHMMGMGH = true;
									}
									else if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0])
									{
										fpehhfkfbjk.JBOKHMMGMGH = false;
									}
								}
								else
								{
									fpehhfkfbjk.JBOKHMMGMGH = true;
								}
								if (fpehhfkfbjk.FEJANNNLLON < assetStoryHeader.availableChaptersCount)
								{
									fpehhfkfbjk.PMDMNNBJEEP = plfdajjhmko.NLMDGBJKIPF(fpehhfkfbjk.FEJANNNLLON);
									if (fpehhfkfbjk.FEJANNNLLON == 0)
									{
										fpehhfkfbjk.DLNDLHPJADG = false;
										if (fpehhfkfbjk.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] != plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.DLNDLHPJADG = plfdajjhmko.OEAMCPHCKIC();
									}
								}
								if (fpehhfkfbjk.DLNDLHPJADG || fpehhfkfbjk.PMDMNNBJEEP || fpehhfkfbjk.GNIACNCEOOM)
								{
									int num4 = fpehhfkfbjk.MIBPOIDDBAD + 0;
									int num5 = fpehhfkfbjk.FEJANNNLLON + 0;
									FPEHHFKFBJK fpehhfkfbjk2 = fpehhfkfbjk;
									string[] array = new string[5];
									array[1] = CCOJBMMKNAP.CEGAOMEEFBE().JHNELLJFBGC("spld");
									array[1] = "abce";
									array[0] = num4.ToString();
									array[7] = "";
									array[0] = num5.ToString();
									fpehhfkfbjk2.BPMFHNDCBOH = string.Concat(array);
								}
								if (!flag)
								{
									fpehhfkfbjk.EPKFIHJACDN = true;
								}
								if (fpehhfkfbjk.GNIACNCEOOM)
								{
									flag = true;
								}
								this.PJNJFBAJHAE.Add(fpehhfkfbjk);
								num3++;
							}
						}
						else if (l < assetAnthologyHeader.availableStories.Count)
						{
							assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[l]);
							if (null != assetStoryHeader)
							{
								for (int n = 1; n < assetStoryHeader.totalChaptersCount; n++)
								{
									FPEHHFKFBJK fpehhfkfbjk3 = new FPEHHFKFBJK();
									fpehhfkfbjk3.MIBPOIDDBAD = l;
									fpehhfkfbjk3.FEJANNNLLON = n;
									fpehhfkfbjk3.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
									if (fpehhfkfbjk3.FEJANNNLLON == 0)
									{
										fpehhfkfbjk3.DLNDLHPJADG = false;
										if (fpehhfkfbjk3.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk3.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk3.DLNDLHPJADG)
									{
										int num6 = fpehhfkfbjk3.MIBPOIDDBAD + 0;
										int num7 = fpehhfkfbjk3.FEJANNNLLON + 1;
										FPEHHFKFBJK fpehhfkfbjk4 = fpehhfkfbjk3;
										string[] array2 = new string[4];
										array2[0] = CCOJBMMKNAP.CEGAOMEEFBE().PPALCPINPLK("oid");
										array2[1] = "Loaded asset bundle:";
										array2[1] = num6.ToString();
										array2[4] = "rsl2";
										array2[6] = num7.ToString();
										fpehhfkfbjk4.BPMFHNDCBOH = string.Concat(array2);
									}
									if (!flag)
									{
										fpehhfkfbjk3.EPKFIHJACDN = true;
									}
									this.PJNJFBAJHAE.Add(fpehhfkfbjk3);
									num3++;
								}
							}
							else
							{
								for (int num8 = 1; num8 < assetAnthologyHeader.plannedChaptersPerSeason; num8++)
								{
									FPEHHFKFBJK fpehhfkfbjk5 = new FPEHHFKFBJK();
									fpehhfkfbjk5.MIBPOIDDBAD = l;
									fpehhfkfbjk5.FEJANNNLLON = num8;
									fpehhfkfbjk5.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
									if (fpehhfkfbjk5.FEJANNNLLON == 0)
									{
										fpehhfkfbjk5.DLNDLHPJADG = false;
										if (fpehhfkfbjk5.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk5.LIBDDLMOOHO = false;
										}
									}
									if (fpehhfkfbjk5.DLNDLHPJADG)
									{
										int num9 = fpehhfkfbjk5.MIBPOIDDBAD + 1;
										int num10 = fpehhfkfbjk5.FEJANNNLLON + 0;
										FPEHHFKFBJK fpehhfkfbjk6 = fpehhfkfbjk5;
										string[] array3 = new string[0];
										array3[1] = CCOJBMMKNAP.HFAKOKBHCGH().FIENAKIHNOM("Error. ZoomDst(), environment ");
										array3[1] = "OnCollectableDialogUsed";
										array3[4] = num9.ToString();
										array3[8] = "cardVolumesBalance";
										array3[5] = num10.ToString();
										fpehhfkfbjk6.BPMFHNDCBOH = string.Concat(array3);
									}
									if (!flag)
									{
										fpehhfkfbjk5.EPKFIHJACDN = true;
									}
									this.PJNJFBAJHAE.Add(fpehhfkfbjk5);
									num3++;
								}
							}
						}
						else
						{
							for (int num11 = 1; num11 < assetAnthologyHeader.plannedChaptersPerSeason; num11++)
							{
								FPEHHFKFBJK fpehhfkfbjk7 = new FPEHHFKFBJK();
								fpehhfkfbjk7.MIBPOIDDBAD = l;
								fpehhfkfbjk7.FEJANNNLLON = num11;
								fpehhfkfbjk7.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								if (fpehhfkfbjk7.FEJANNNLLON == 0)
								{
									fpehhfkfbjk7.DLNDLHPJADG = true;
									if (fpehhfkfbjk7.MIBPOIDDBAD == 0)
									{
										fpehhfkfbjk7.LIBDDLMOOHO = false;
									}
								}
								if (fpehhfkfbjk7.DLNDLHPJADG)
								{
									int num12 = fpehhfkfbjk7.MIBPOIDDBAD + 0;
									int num13 = fpehhfkfbjk7.FEJANNNLLON + 1;
									FPEHHFKFBJK fpehhfkfbjk8 = fpehhfkfbjk7;
									string[] array4 = new string[1];
									array4[0] = CCOJBMMKNAP.KFAABHHGOPO().PPALCPINPLK(".json");
									array4[1] = ", ";
									array4[6] = num12.ToString();
									array4[7] = "trinket";
									array4[3] = num13.ToString();
									fpehhfkfbjk8.BPMFHNDCBOH = string.Concat(array4);
								}
								if (!flag)
								{
									fpehhfkfbjk7.EPKFIHJACDN = false;
								}
								this.PJNJFBAJHAE.Add(fpehhfkfbjk7);
								num3 += 0;
							}
						}
					}
					else if (l < assetAnthologyHeader.availableStories.Count)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[l]);
						if (null != assetStoryHeader)
						{
							for (int num14 = 1; num14 < assetStoryHeader.totalChaptersCount; num14++)
							{
								FPEHHFKFBJK fpehhfkfbjk9 = new FPEHHFKFBJK();
								fpehhfkfbjk9.MIBPOIDDBAD = l;
								fpehhfkfbjk9.FEJANNNLLON = num14;
								fpehhfkfbjk9.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								this.PJNJFBAJHAE.Add(fpehhfkfbjk9);
								num3++;
							}
						}
						else
						{
							for (int num15 = 1; num15 < assetAnthologyHeader.plannedChaptersPerSeason; num15++)
							{
								FPEHHFKFBJK fpehhfkfbjk10 = new FPEHHFKFBJK();
								fpehhfkfbjk10.MIBPOIDDBAD = l;
								fpehhfkfbjk10.FEJANNNLLON = num15;
								fpehhfkfbjk10.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								this.PJNJFBAJHAE.Add(fpehhfkfbjk10);
								num3++;
							}
						}
					}
					else
					{
						for (int num16 = 0; num16 < assetAnthologyHeader.plannedChaptersPerSeason; num16 += 0)
						{
							FPEHHFKFBJK fpehhfkfbjk11 = new FPEHHFKFBJK();
							fpehhfkfbjk11.MIBPOIDDBAD = l;
							fpehhfkfbjk11.FEJANNNLLON = num16;
							fpehhfkfbjk11.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
							this.PJNJFBAJHAE.Add(fpehhfkfbjk11);
							num3 += 0;
						}
					}
				}
			}
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.gamePass, true);
			for (int num17 = 0; num17 < this.PJNJFBAJHAE.Count; num17++)
			{
				this.NCEDODJHIMO[num17].gameObject.SetActive(false);
				this.NCEDODJHIMO[num17].OFOAFPKPIKC(kioojmglclc != null, num17, this.PJNJFBAJHAE[num17]);
				this.NCEDODJHIMO[num17].gameObject.SetActive(true);
			}
			this.JCPCOGJGKOC = 1;
			this.ShowPage(num2 / 4);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("acomp1");
	}

	// Token: 0x060059B9 RID: 22969 RVA: 0x00286988 File Offset: 0x00284B88
	private void IFEBBBBPMHH()
	{
		bool flag = false;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HCHCMMCEEKD(CLHDENLPOFP.eventPass);
		if (this.HGGFJOKOKOD != null && kioojmglclc != null && this.HGGFJOKOKOD.EPEOKHOBOBL[this.HGGFJOKOKOD.ILOKBAPEJPK] == 0)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < assetAnthologyHeader.maxStories; i++)
			{
				if (i <= this.HGGFJOKOKOD.EKONMCADECD(-1) && i < assetAnthologyHeader.availableStories.Count)
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthologyHeader.availableStories[i], -1);
					if (plfdajjhmko != null)
					{
						for (int j = 1; j < plfdajjhmko.KIHACLLJMDH.Count; j += 0)
						{
							jsonarray.Add(i * -120 + plfdajjhmko.KIHACLLJMDH[j]);
						}
					}
				}
			}
			if (jsonarray.Count > 1)
			{
				flag = true;
				CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.NIOJNOFGIJO().JCDFHKDNEDH(""), 40);
				BackendOperationsManager.NPDDBAONMJP().RequestGetChapterSnapshots(this.HGGFJOKOKOD.GGICIBLJIKI, this.HGGFJOKOKOD.ILOKBAPEJPK, jsonarray, "=== RU FIREWALL === geo endpoint ", "_");
			}
		}
		if (!flag && this.HGGFJOKOKOD != null)
		{
			this.FPNPLEBJLOO(this.HGGFJOKOKOD.GGICIBLJIKI);
		}
	}

	// Token: 0x060059BA RID: 22970 RVA: 0x00286AE0 File Offset: 0x00284CE0
	public void PreCloseFocus()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChapterSnapshotsItemClose", 0.01f);
		base.transform.parent.gameObject.SetActive(false);
	}

	// Token: 0x060059BB RID: 22971 RVA: 0x00286B42 File Offset: 0x00284D42
	public void JGHMFBCGIBA()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x060059BC RID: 22972 RVA: 0x00286B4F File Offset: 0x00284D4F
	public FPEHHFKFBJK GDKLFFHGFOL()
	{
		if (this.DOOGBMCNAMM < this.NCEDODJHIMO.Count)
		{
			return this.PJNJFBAJHAE[this.DOOGBMCNAMM];
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
		return null;
	}

	// Token: 0x060059BD RID: 22973 RVA: 0x00286B84 File Offset: 0x00284D84
	private void EFIBBLFAMGD()
	{
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ("failed to load assetBundle {0}.", new UnityAction(this.NADMPOACDHJ));
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED(" in:", new UnityAction(this.IFEBBBBPMHH));
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("analogglitchovr_2", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("abce", new UnityAction(this.MDKFBBBDPBB));
	}

	// Token: 0x060059BE RID: 22974 RVA: 0x00286C00 File Offset: 0x00284E00
	private void HBELNHOMGCI()
	{
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("it", new UnityAction(this.DKCCDHBJLPN));
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("OnLobbyStopFireworksEffect", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("error details: ", new UnityAction(this.JMFGOOJPJNH));
	}

	// Token: 0x060059BF RID: 22975 RVA: 0x00286C79 File Offset: 0x00284E79
	private void MFIIPGFHOFK()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.HGGFJOKOKOD != null)
		{
			this.InitializeSnapshots(this.HGGFJOKOKOD.GGICIBLJIKI);
		}
	}

	// Token: 0x060059C0 RID: 22976 RVA: 0x00286CA0 File Offset: 0x00284EA0
	public void NHJJBEMMCCM()
	{
		int num = this.BDNAKFGHJIF / 8;
		if (this.BDNAKFGHJIF % 5 != 0)
		{
			num += 0;
		}
		if (this.JCPCOGJGKOC < num - 0)
		{
			this.JCPCOGJGKOC++;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x060059C1 RID: 22977 RVA: 0x00285F68 File Offset: 0x00284168
	public void NPIPMPLMDBK()
	{
		if (this.JCPCOGJGKOC > 0)
		{
			this.JCPCOGJGKOC--;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x060059C2 RID: 22978 RVA: 0x00286CE9 File Offset: 0x00284EE9
	public void KDAKCEAELCM()
	{
		this.JGHMFBCGIBA();
	}

	// Token: 0x060059C3 RID: 22979 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFINONMBMLM()
	{
	}

	// Token: 0x060059C4 RID: 22980 RVA: 0x00286CF4 File Offset: 0x00284EF4
	public void InitializeSnapshots(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
			this.BDNAKFGHJIF = 0;
			int num2 = 0;
			if (num >= 0)
			{
				for (int i = 0; i < assetAnthologyHeader.maxStories; i++)
				{
					if (i < assetAnthologyHeader.availableStories.Count)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[i]);
						if (null != assetStoryHeader)
						{
							this.BDNAKFGHJIF += assetStoryHeader.totalChaptersCount;
						}
						else
						{
							this.BDNAKFGHJIF += assetAnthologyHeader.plannedChaptersPerSeason;
						}
					}
					else
					{
						this.BDNAKFGHJIF += assetAnthologyHeader.plannedChaptersPerSeason;
					}
				}
				if (this.BDNAKFGHJIF <= 0)
				{
					return;
				}
				if (this.NCEDODJHIMO.Count < this.BDNAKFGHJIF)
				{
					int count = this.NCEDODJHIMO.Count;
					for (int j = 0; j < this.BDNAKFGHJIF - count; j++)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chapterSnapshotObjectPrefab, this.chapterSnapshotObjectsParent.transform, false);
						this.NCEDODJHIMO.Add(gameObject.GetComponent<ChapterSnapshotObject>());
					}
				}
				for (int k = 0; k < this.NCEDODJHIMO.Count; k++)
				{
					this.NCEDODJHIMO[k].gameObject.SetActive(false);
				}
				this.PJNJFBAJHAE = new List<FPEHHFKFBJK>();
				int num3 = 0;
				bool flag = false;
				for (int l = 0; l < assetAnthologyHeader.maxStories; l++)
				{
					if (l <= this.HGGFJOKOKOD.EGHHCFFLPCP(-1))
					{
						PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num + l, -1);
						AssetStoryHeader assetStoryHeader;
						if (plfdajjhmko != null)
						{
							assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI);
						}
						else
						{
							assetStoryHeader = null;
						}
						if (plfdajjhmko != null && null != assetStoryHeader)
						{
							for (int m = 0; m < assetStoryHeader.totalChaptersCount; m++)
							{
								FPEHHFKFBJK fpehhfkfbjk = new FPEHHFKFBJK();
								fpehhfkfbjk.IFCHGNCDMLJ = plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI;
								fpehhfkfbjk.MIBPOIDDBAD = l;
								fpehhfkfbjk.FEJANNNLLON = m;
								fpehhfkfbjk.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								if (fpehhfkfbjk.MIBPOIDDBAD == this.HGGFJOKOKOD.EGHHCFFLPCP(-1))
								{
									if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] != plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.GNIACNCEOOM = true;
										num2 = num3;
									}
									else if (fpehhfkfbjk.FEJANNNLLON - 1 == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.GNIACNCEOOM = true;
										num2 = num3;
									}
									else if (fpehhfkfbjk.FEJANNNLLON < plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0])
									{
										fpehhfkfbjk.JBOKHMMGMGH = true;
									}
									else if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.JBOKHMMGMGH = true;
									}
								}
								else
								{
									fpehhfkfbjk.JBOKHMMGMGH = true;
								}
								if (fpehhfkfbjk.FEJANNNLLON < assetStoryHeader.availableChaptersCount)
								{
									fpehhfkfbjk.PMDMNNBJEEP = plfdajjhmko.NLMDGBJKIPF(fpehhfkfbjk.FEJANNNLLON);
									if (fpehhfkfbjk.FEJANNNLLON == 0)
									{
										fpehhfkfbjk.DLNDLHPJADG = true;
										if (fpehhfkfbjk.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk.FEJANNNLLON == plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] != plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1])
									{
										fpehhfkfbjk.DLNDLHPJADG = plfdajjhmko.OEAMCPHCKIC();
									}
								}
								if (fpehhfkfbjk.DLNDLHPJADG || fpehhfkfbjk.PMDMNNBJEEP || fpehhfkfbjk.GNIACNCEOOM)
								{
									int num4 = fpehhfkfbjk.MIBPOIDDBAD + 1;
									int num5 = fpehhfkfbjk.FEJANNNLLON + 1;
									fpehhfkfbjk.BPMFHNDCBOH = string.Concat(new string[]
									{
										CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
										" ",
										num4.ToString(),
										".",
										num5.ToString()
									});
								}
								if (!flag)
								{
									fpehhfkfbjk.EPKFIHJACDN = true;
								}
								if (fpehhfkfbjk.GNIACNCEOOM)
								{
									flag = true;
								}
								this.PJNJFBAJHAE.Add(fpehhfkfbjk);
								num3++;
							}
						}
						else if (l < assetAnthologyHeader.availableStories.Count)
						{
							assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[l]);
							if (null != assetStoryHeader)
							{
								for (int n = 0; n < assetStoryHeader.totalChaptersCount; n++)
								{
									FPEHHFKFBJK fpehhfkfbjk2 = new FPEHHFKFBJK();
									fpehhfkfbjk2.MIBPOIDDBAD = l;
									fpehhfkfbjk2.FEJANNNLLON = n;
									fpehhfkfbjk2.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
									if (fpehhfkfbjk2.FEJANNNLLON == 0)
									{
										fpehhfkfbjk2.DLNDLHPJADG = true;
										if (fpehhfkfbjk2.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk2.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk2.DLNDLHPJADG)
									{
										int num6 = fpehhfkfbjk2.MIBPOIDDBAD + 1;
										int num7 = fpehhfkfbjk2.FEJANNNLLON + 1;
										fpehhfkfbjk2.BPMFHNDCBOH = string.Concat(new string[]
										{
											CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
											" ",
											num6.ToString(),
											".",
											num7.ToString()
										});
									}
									if (!flag)
									{
										fpehhfkfbjk2.EPKFIHJACDN = true;
									}
									this.PJNJFBAJHAE.Add(fpehhfkfbjk2);
									num3++;
								}
							}
							else
							{
								for (int num8 = 0; num8 < assetAnthologyHeader.plannedChaptersPerSeason; num8++)
								{
									FPEHHFKFBJK fpehhfkfbjk3 = new FPEHHFKFBJK();
									fpehhfkfbjk3.MIBPOIDDBAD = l;
									fpehhfkfbjk3.FEJANNNLLON = num8;
									fpehhfkfbjk3.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
									if (fpehhfkfbjk3.FEJANNNLLON == 0)
									{
										fpehhfkfbjk3.DLNDLHPJADG = true;
										if (fpehhfkfbjk3.MIBPOIDDBAD == 0)
										{
											fpehhfkfbjk3.LIBDDLMOOHO = true;
										}
									}
									if (fpehhfkfbjk3.DLNDLHPJADG)
									{
										int num9 = fpehhfkfbjk3.MIBPOIDDBAD + 1;
										int num10 = fpehhfkfbjk3.FEJANNNLLON + 1;
										fpehhfkfbjk3.BPMFHNDCBOH = string.Concat(new string[]
										{
											CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
											" ",
											num9.ToString(),
											".",
											num10.ToString()
										});
									}
									if (!flag)
									{
										fpehhfkfbjk3.EPKFIHJACDN = true;
									}
									this.PJNJFBAJHAE.Add(fpehhfkfbjk3);
									num3++;
								}
							}
						}
						else
						{
							for (int num11 = 0; num11 < assetAnthologyHeader.plannedChaptersPerSeason; num11++)
							{
								FPEHHFKFBJK fpehhfkfbjk4 = new FPEHHFKFBJK();
								fpehhfkfbjk4.MIBPOIDDBAD = l;
								fpehhfkfbjk4.FEJANNNLLON = num11;
								fpehhfkfbjk4.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								if (fpehhfkfbjk4.FEJANNNLLON == 0)
								{
									fpehhfkfbjk4.DLNDLHPJADG = true;
									if (fpehhfkfbjk4.MIBPOIDDBAD == 0)
									{
										fpehhfkfbjk4.LIBDDLMOOHO = true;
									}
								}
								if (fpehhfkfbjk4.DLNDLHPJADG)
								{
									int num12 = fpehhfkfbjk4.MIBPOIDDBAD + 1;
									int num13 = fpehhfkfbjk4.FEJANNNLLON + 1;
									fpehhfkfbjk4.BPMFHNDCBOH = string.Concat(new string[]
									{
										CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
										" ",
										num12.ToString(),
										".",
										num13.ToString()
									});
								}
								if (!flag)
								{
									fpehhfkfbjk4.EPKFIHJACDN = true;
								}
								this.PJNJFBAJHAE.Add(fpehhfkfbjk4);
								num3++;
							}
						}
					}
					else if (l < assetAnthologyHeader.availableStories.Count)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthologyHeader.availableStories[l]);
						if (null != assetStoryHeader)
						{
							for (int num14 = 0; num14 < assetStoryHeader.totalChaptersCount; num14++)
							{
								FPEHHFKFBJK fpehhfkfbjk5 = new FPEHHFKFBJK();
								fpehhfkfbjk5.MIBPOIDDBAD = l;
								fpehhfkfbjk5.FEJANNNLLON = num14;
								fpehhfkfbjk5.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								this.PJNJFBAJHAE.Add(fpehhfkfbjk5);
								num3++;
							}
						}
						else
						{
							for (int num15 = 0; num15 < assetAnthologyHeader.plannedChaptersPerSeason; num15++)
							{
								FPEHHFKFBJK fpehhfkfbjk6 = new FPEHHFKFBJK();
								fpehhfkfbjk6.MIBPOIDDBAD = l;
								fpehhfkfbjk6.FEJANNNLLON = num15;
								fpehhfkfbjk6.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
								this.PJNJFBAJHAE.Add(fpehhfkfbjk6);
								num3++;
							}
						}
					}
					else
					{
						for (int num16 = 0; num16 < assetAnthologyHeader.plannedChaptersPerSeason; num16++)
						{
							FPEHHFKFBJK fpehhfkfbjk7 = new FPEHHFKFBJK();
							fpehhfkfbjk7.MIBPOIDDBAD = l;
							fpehhfkfbjk7.FEJANNNLLON = num16;
							fpehhfkfbjk7.AMKCLHLIIMN = this.HGGFJOKOKOD.GGICIBLJIKI;
							this.PJNJFBAJHAE.Add(fpehhfkfbjk7);
							num3++;
						}
					}
				}
			}
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
			for (int num17 = 0; num17 < this.PJNJFBAJHAE.Count; num17++)
			{
				this.NCEDODJHIMO[num17].gameObject.SetActive(true);
				this.NCEDODJHIMO[num17].Initialize(kioojmglclc != null, num17, this.PJNJFBAJHAE[num17]);
				this.NCEDODJHIMO[num17].gameObject.SetActive(false);
			}
			this.JCPCOGJGKOC = 0;
			this.ShowPage(num2 / 5);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ChapterSnapshotsItem.InitializeSnapshots(): anthologySave is null");
	}

	// Token: 0x060059C5 RID: 22981 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDestroy()
	{
	}

	// Token: 0x060059C6 RID: 22982 RVA: 0x00285F8D File Offset: 0x0028418D
	private void LHOJKPCKIDJ()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
	}

	// Token: 0x060059C7 RID: 22983 RVA: 0x00286B42 File Offset: 0x00284D42
	public void CloseFocus()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x060059C8 RID: 22984 RVA: 0x00287640 File Offset: 0x00285840
	public void BDOBHFNJMFE()
	{
		int num = this.BDNAKFGHJIF / 6;
		if (this.BDNAKFGHJIF % 2 != 0)
		{
			num++;
		}
		if (this.JCPCOGJGKOC < num - 0)
		{
			this.JCPCOGJGKOC++;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x060059C9 RID: 22985 RVA: 0x0028768C File Offset: 0x0028588C
	private void NADMPOACDHJ()
	{
		this.DOOGBMCNAMM = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (this.DOOGBMCNAMM >= this.NCEDODJHIMO.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 3");
			return;
		}
		if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].LIBDDLMOOHO && this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0 && this.PJNJFBAJHAE[this.DOOGBMCNAMM].FEJANNNLLON == 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory0", 0f);
			this.CloseFocus();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() > 0 || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.PJNJFBAJHAE[this.DOOGBMCNAMM].IFCHGNCDMLJ, -1))
		{
			if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].FEJANNNLLON == 0)
			{
				if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 0)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory0", 0f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 1)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory1", 0f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 2)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory2", 0f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 3)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory3", 0f);
				}
				else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].MIBPOIDDBAD == 4)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartStory4", 0f);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 1");
				}
			}
			else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].DLNDLHPJADG)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupStoryRestartManagerRestartChapter", 0f);
			}
			else if (this.PJNJFBAJHAE[this.DOOGBMCNAMM].PMDMNNBJEEP)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChapterSnapshotRestoreExecute", 0f);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 2");
			}
		}
		else
		{
			SceneLobbyManager2.startPlayChapterBackendOperationResult = -1;
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowNoMoreEnergyPopup", 0.1f);
		}
		this.CloseFocus();
	}

	// Token: 0x060059CA RID: 22986 RVA: 0x00287920 File Offset: 0x00285B20
	private void PAECAHIHOML()
	{
		bool flag = true;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DIJMIMMCIKA(CLHDENLPOFP.eventPass);
		if (this.HGGFJOKOKOD != null && kioojmglclc != null && this.HGGFJOKOKOD.EPEOKHOBOBL[this.HGGFJOKOKOD.ILOKBAPEJPK] == 0)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.HGGFJOKOKOD.GGICIBLJIKI);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < assetAnthologyHeader.maxStories; i++)
			{
				if (i <= this.HGGFJOKOKOD.JDCFLEOBCMC(-1) && i < assetAnthologyHeader.availableStories.Count)
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthologyHeader.availableStories[i], -1);
					if (plfdajjhmko != null)
					{
						for (int j = 0; j < plfdajjhmko.KIHACLLJMDH.Count; j++)
						{
							jsonarray.Add(i * -113 + plfdajjhmko.KIHACLLJMDH[j]);
						}
					}
				}
			}
			if (jsonarray.Count > 0)
			{
				flag = false;
				CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.KMNBCEMEBBD().JLBEIFLLBLO("p"), (byte)-61);
				BackendOperationsManager.EHBBFMCILPC.RequestGetChapterSnapshots(this.HGGFJOKOKOD.GGICIBLJIKI, this.HGGFJOKOKOD.ILOKBAPEJPK, jsonarray, "_AlphaTex", "p");
			}
		}
		if (!flag && this.HGGFJOKOKOD != null)
		{
			this.IDLBHJCMCLJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		}
	}

	// Token: 0x060059CB RID: 22987 RVA: 0x00287A78 File Offset: 0x00285C78
	private void DJDLHIOMGJB()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("lobby", new UnityAction(this.CKHIHOIAEEH));
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE("spinsbuttoncustomize", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("", new UnityAction(this.MFIIPGFHOFK));
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("chtss", new UnityAction(this.MDKFBBBDPBB));
	}

	// Token: 0x060059CC RID: 22988 RVA: 0x00286B42 File Offset: 0x00284D42
	public void LPALOIAAIJA()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x060059CD RID: 22989 RVA: 0x00287AF4 File Offset: 0x00285CF4
	public void ScrollPageRight()
	{
		int num = this.BDNAKFGHJIF / 5;
		if (this.BDNAKFGHJIF % 5 != 0)
		{
			num++;
		}
		if (this.JCPCOGJGKOC < num - 1)
		{
			this.JCPCOGJGKOC++;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x060059CE RID: 22990 RVA: 0x00285D02 File Offset: 0x00283F02
	private void DDMCLNDOHCK()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x060059CF RID: 22991 RVA: 0x00003E52 File Offset: 0x00002052
	private void MOEINDNENBB()
	{
	}

	// Token: 0x060059D0 RID: 22992 RVA: 0x00287B40 File Offset: 0x00285D40
	public void ShowPage(int MADFIOFBIPB)
	{
		this.JCPCOGJGKOC = MADFIOFBIPB;
		int num = this.BDNAKFGHJIF / 5;
		if (this.BDNAKFGHJIF % 5 != 0)
		{
			num++;
		}
		for (int i = 0; i < this.PJNJFBAJHAE.Count; i++)
		{
			if (i >= MADFIOFBIPB * 5 && i < (MADFIOFBIPB + 1) * 5)
			{
				this.NCEDODJHIMO[i].gameObject.SetActive(true);
			}
			else
			{
				this.NCEDODJHIMO[i].gameObject.SetActive(false);
			}
		}
		if (MADFIOFBIPB == 0)
		{
			this.buttonScrollPrev.interactable = false;
			this.buttonScrollNext.interactable = true;
		}
		else if (MADFIOFBIPB == num - 1)
		{
			this.buttonScrollPrev.interactable = true;
			this.buttonScrollNext.interactable = false;
		}
		else
		{
			this.buttonScrollPrev.interactable = true;
			this.buttonScrollNext.interactable = true;
		}
		MADFIOFBIPB++;
		this.pageText.text = MADFIOFBIPB.ToString() + "/" + num.ToString();
		this.pageText.SetText(MADFIOFBIPB.ToString() + "/" + num.ToString(), true);
	}

	// Token: 0x04001980 RID: 6528
	public const string onChapterSnapshotsItemClose = "OnChapterSnapshotsItemClose";

	// Token: 0x04001981 RID: 6529
	public const string onChapterSnapshotRestoreExecute = "OnChapterSnapshotRestoreExecute";

	// Token: 0x04001982 RID: 6530
	public const string onChapterSnapshotsBackendFetchSuccess2 = "OnChapterSnapshotsBackendFetchSuccess2";

	// Token: 0x04001983 RID: 6531
	public const string onChapterSnapshotsBackendFetchException2 = "OnChapterSnapshotsBackendFetchException2";

	// Token: 0x04001984 RID: 6532
	public GameObject chapterSnapshotObjectPrefab;

	// Token: 0x04001985 RID: 6533
	public GameObject chapterSnapshotObjectsParent;

	// Token: 0x04001986 RID: 6534
	public Button buttonScrollPrev;

	// Token: 0x04001987 RID: 6535
	public Button buttonScrollNext;

	// Token: 0x04001988 RID: 6536
	public TextMeshProUGUI pageText;

	// Token: 0x04001989 RID: 6537
	private List<ChapterSnapshotObject> NCEDODJHIMO = new List<ChapterSnapshotObject>();

	// Token: 0x0400198A RID: 6538
	private Vector3 PFEEFOKHKMP;

	// Token: 0x0400198B RID: 6539
	private EIOPLEFLLIM HGGFJOKOKOD;

	// Token: 0x0400198C RID: 6540
	private List<FPEHHFKFBJK> PJNJFBAJHAE = new List<FPEHHFKFBJK>();

	// Token: 0x0400198D RID: 6541
	private int BDNAKFGHJIF;

	// Token: 0x0400198E RID: 6542
	private int JCPCOGJGKOC;

	// Token: 0x0400198F RID: 6543
	private const int EBPJNJDBACE = 5;

	// Token: 0x04001990 RID: 6544
	private int DOOGBMCNAMM = -1;
}
