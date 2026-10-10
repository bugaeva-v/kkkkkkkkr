using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Ink.Runtime;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

// Token: 0x0200022C RID: 556
public class SceneStoryManager : MonoBehaviour
{
	// Token: 0x06004662 RID: 18018 RVA: 0x001E6840 File Offset: 0x001E4A40
	private void CKMIFCMPFLL(string KHJMANDEDMA, float JHBAIJIJIBN)
	{
		if (null != this.DMNJMLDEILJ)
		{
			this.DMNJMLDEILJ.CancelImmediateIfBusy();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 0)
		{
			bool flag = true;
			for (int i = 1; i < this.fadeLayers.Count; i += 0)
			{
				if (this.fadeLayers[i].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag = false;
					this.fadeLayers[i].HCMMPBLKCEF(JHBAIJIJIBN);
					this.fadeLayers[i].FadeIn(null);
				}
				else
				{
					this.fadeLayers[i].EBHGDIEBJKI();
				}
			}
			if (!flag)
			{
				KHJMANDEDMA = "Z";
				for (int j = 1; j < this.fadeLayers.Count; j += 0)
				{
					if (this.fadeLayers[j].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag = false;
						this.fadeLayers[j].NPOEBKBOCJG(JHBAIJIJIBN);
						this.fadeLayers[j].PACBMBLIGNN(null);
					}
					else
					{
						this.fadeLayers[j].Reset();
					}
				}
				if (!flag)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("ffd496" + KHJMANDEDMA + "OnSaveSyncAnyResultDuplicate");
					return;
				}
			}
		}
		else
		{
			bool flag2 = true;
			for (int k = 1; k < this.fadeLayers.Count; k++)
			{
				if (this.fadeLayers[k].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag2 = true;
					this.fadeLayers[k].HCMMPBLKCEF(JHBAIJIJIBN);
					if (!this.fadeLayers[k].gameObject.activeSelf)
					{
						this.fadeLayers[k].BJIGLKGLAKM(null);
					}
					else
					{
						this.fadeLayers[k].DOLHLEBOPCA(null);
					}
				}
				else
				{
					this.fadeLayers[k].JDPKNGACIJL();
				}
			}
			if (!flag2)
			{
				KHJMANDEDMA = "XXX";
				for (int l = 0; l < this.fadeLayers.Count; l += 0)
				{
					if (this.fadeLayers[l].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag2 = false;
						this.fadeLayers[l].NPOEBKBOCJG(JHBAIJIJIBN);
						this.fadeLayers[l].FadeIn(null);
					}
					else
					{
						this.fadeLayers[l].NCNBINOFOJM();
					}
				}
				if (!flag2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("\n\n<align=\"center\"><size=120%>" + KHJMANDEDMA + "OnBackendStartPlayChapterException");
				}
			}
		}
	}

	// Token: 0x06004663 RID: 18019 RVA: 0x001E6ACC File Offset: 0x001E4CCC
	private void JAPJDIMHOIB()
	{
		SceneStoryManager.inkInterpretingIsPaused = true;
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		if (!SemaphoreManager.GreenLight(JLDJNIGMHLC.popups))
		{
			this.EMKPOOMPLON = true;
			this.GJDIJIAENCJ = true;
			return;
		}
		if (this.NEDLEEPJJIC)
		{
			return;
		}
		if (this.MBBFJHBFPNB)
		{
			return;
		}
		SceneStoryManager.inkInterpretingIsPaused = false;
		if (KGLBKJKNPFD.NIBNMKJIMAD == 1 && null != this.storyChatPrefab && !this.GJDIJIAENCJ && null != this.MLDGHPCEFNN() && this.MLDGHPCEFNN().IsInScrollState())
		{
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				if (DPGJIJGOCIC.KLPPJLLBJAP().y > 0.85f && null != this.storyInterfaceHeaderManager && !ChoiceExtendedManager.SwipeConsumedRelease())
				{
					this.APDAMLCHICH();
					this.OPLBCELFMLI();
					this.storyInterfaceHeaderManager.Show(this.CEBPKAAGJPJ());
				}
				if (DPGJIJGOCIC.KLPPJLLBJAP().y > 0.6f)
				{
					this.OGNJFHPEDNN();
					return;
				}
				if (null != this.storyInterfaceHeaderManager)
				{
					this.storyInterfaceHeaderManager.Hide();
					return;
				}
			}
			else if (DPGJIJGOCIC.PCOOFHCMKGI())
			{
				if (DPGJIJGOCIC.AHELOLJOHLJ().y > 0.85f && null != this.storyInterfaceHeaderManager && !ChoiceExtendedManager.SwipeConsumedRelease())
				{
					this.APDAMLCHICH();
					this.OPLBCELFMLI();
					this.storyInterfaceHeaderManager.Show(this.CEBPKAAGJPJ());
				}
				if (DPGJIJGOCIC.AHELOLJOHLJ().y > 0.6f)
				{
					this.OGNJFHPEDNN();
					return;
				}
				if (null != this.storyInterfaceHeaderManager)
				{
					this.storyInterfaceHeaderManager.Hide();
				}
			}
			return;
		}
		if (!this.GFIFDKBLLBL.canContinue && this.GFIFDKBLLBL.currentChoices.Count == 0 && !this.HFOPCMIHDOL.KDCHHKDPGKB())
		{
			this.NEDLEEPJJIC = true;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("storyloaderr5"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnBackClick), new UnityAction(this.OnBackClick), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
		}
		else if (this.HFOPCMIHDOL.FMLECLNJAJM() || this.HFOPCMIHDOL.BBHDMMHCDKO())
		{
			if (this.GFIFDKBLLBL.canContinue && (this.HFOPCMIHDOL.BNDEOLKJAPJ() > 0 || this.GFIFDKBLLBL.currentText.Length == 0))
			{
				this.GFIFDKBLLBL.Continue();
				this.BKCFFNNPOHC();
				this.INIEOPFGBEG = this.BHCPLGJJOPA;
				if (this.GFIFDKBLLBL.currentText != null && this.GFIFDKBLLBL.currentText.Length > 0 && this.GFIFDKBLLBL.currentText.Contains("$en"))
				{
					this.BHCPLGJJOPA = this.GFIFDKBLLBL.currentText;
				}
				if (this.GKHNIMJJLJL.NCAMFPGMCIG.FEDCIMMIJCI == 1)
				{
					if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
					{
						this.LPCBDEBKAIM();
						this.GKHNIMJJLJL.AKJIFLCHGGC(SceneStoryManager.localizedChoice);
						SceneStoryManager.localizedChoice = "";
					}
					else
					{
						this.GKHNIMJJLJL.LNCIMPFKHAO();
						SceneStoryManager.localizedChoice = "";
					}
				}
			}
			if (this.GFIFDKBLLBL.canContinue && this.GFIFDKBLLBL.currentChoices.Count == 0 && this.GFIFDKBLLBL.currentText != null && this.GFIFDKBLLBL.currentText.Contains("$CHOICEMETA") && this.GFIFDKBLLBL.currentText.Contains("asset(") && this.GFIFDKBLLBL.currentText.Contains("type(") && !this.GFIFDKBLLBL.currentText.Contains("(text)") && KDCJJBLGCBH.EHBBFMCILPC.FOEJANNAICF())
			{
				this.GFIFDKBLLBL.Continue();
				this.BKCFFNNPOHC();
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.bugRep.ToString(), FFPHBMFGCNN.handBfix.ToString(), BGHLMGPPCNN.bugCmeta0Ch.ToString(), false, false);
			}
			while (this.GFIFDKBLLBL.canContinue && this.GFIFDKBLLBL.currentText != null && this.GFIFDKBLLBL.currentText.Length == 1 && this.GFIFDKBLLBL.currentText.Equals("\n"))
			{
				this.GFIFDKBLLBL.Continue();
				this.BKCFFNNPOHC();
			}
			this.HFOPCMIHDOL.HFALHCEIDPM(this.GFIFDKBLLBL, false, false, true, true);
			this.JOKJBAIECCA(true);
			AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(this.GKHNIMJJLJL, 0);
		}
		else
		{
			while (this.HFOPCMIHDOL.GEGMEMHHANF())
			{
				this.HFOPCMIHDOL.DCCDNOIBDPB();
				for (int i = 0; i < this.HFOPCMIHDOL.BNDEOLKJAPJ(); i++)
				{
					if (this.MBBFJHBFPNB)
					{
						return;
					}
					if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).FJBPCALKDLD() && !this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().AHNJLFHIKNI() && !this.HFOPCMIHDOL.ONECLDMJKEE(i).BBHDMMHCDKO())
					{
						switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).LPCMANPEDKJ())
						{
						case KGLBKJKNPFD.LBFFMOMMAPK.chapterStart:
							this.APDAMLCHICH();
							this.DNGIDKHONMB();
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).AJEBDLHFFAM().MIBGHAHJDGJ > AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0])
							{
								string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).KPLINMNLKBN(this.HFOPCMIHDOL.ONECLDMJKEE(i).AJEBDLHFFAM().MIBGHAHJDGJ);
								if (text.Length > 0 && !AKLFPGMDKLA.EHBBFMCILPC.CEKAJNFMIKL.Contains(text))
								{
									AKLFPGMDKLA.EHBBFMCILPC.CEKAJNFMIKL.Add(text);
								}
								if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
								{
									this.GKHNIMJJLJL.AKJIFLCHGGC("");
								}
								else
								{
									this.GKHNIMJJLJL.LNCIMPFKHAO();
								}
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0] = this.HFOPCMIHDOL.ONECLDMJKEE(i).AJEBDLHFFAM().MIBGHAHJDGJ;
							}
							if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 14)
							{
								int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
							}
							this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chapterEnd:
							this.APDAMLCHICH();
							this.DNGIDKHONMB();
							this.HGLBOPHFCPH();
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PDLJOKJFALM().MIBGHAHJDGJ > AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[1])
							{
								this.OKAECILDDIK();
								this.DMIPDJJBFLN = false;
								this.NHAEMEAFLGA();
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[1] = this.HFOPCMIHDOL.ONECLDMJKEE(i).PDLJOKJFALM().MIBGHAHJDGJ;
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0] != AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[1])
								{
									DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager - Account.Instance.GetActiveStory().header.progress[0] != Account.Instance.GetActiveStory().header.progress[1] check failed.");
								}
								this.IOIBPOKHBHD = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LGKCPNJJKMC;
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).ACCBHCBPNJA();
								SceneLobbyManager2.returnedFromCompletedStoryChapter = true;
								if (this.NJAAOCMPKCD.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN()) && null != this.HFFIIBBJBMH)
								{
									for (int j = 0; j < this.HFFIIBBJBMH.header.availableStories.Count; j++)
									{
										if (this.HFFIIBBJBMH.header.availableStories[j] == this.NJAAOCMPKCD.index)
										{
											AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).LDPCILACGCO(j + 1, -1);
											if (this.NJAAOCMPKCD.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN()))
											{
												AKLFPGMDKLA.EHBBFMCILPC.HNKHBPMAAEJ(AKLFPGMDKLA.ACFJMCBMOFG(this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).ILOKBAPEJPK));
												if (j + 1 < this.HFFIIBBJBMH.header.availableStories.Count)
												{
													SceneLobbyManager2.showNewSeasonUnlocked = true;
													SceneLobbyManager2.returnedFromCompletedStoryChapter = false;
													AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = this.HFFIIBBJBMH.header.availableStories[j + 1];
													this.FMKKICOINFK(this.HFFIIBBJBMH.header.availableStories[j + 1]);
												}
												else if (j + 1 == this.HFFIIBBJBMH.header.maxStories)
												{
													SceneLobbyManager2.showAnthologyComplete = true;
													SceneLobbyManager2.returnedFromCompletedStoryChapter = false;
													if (this.NJAAOCMPKCD.totalChaptersCount == 1)
													{
														SceneLobbyManager2.showAnthologyCompleteSpecialEpisode = true;
													}
												}
												else
												{
													DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStep.StoryStepType.chapterEnd: unhandled scenario.");
												}
											}
										}
									}
								}
								this.LoadRewardScene();
							}
							else
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentSet:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().BOPJOMGIJIA)
							{
							case OHAAGENIEMD.BMHGEBOHLHH.start:
								if (!(null != this.DMNJMLDEILJ) || !this.DMNJMLDEILJ.IsCapturing())
								{
									this.HJKLOODDLDE(1);
									if (Mathf.Abs(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NFHNOJACGHO) > 0.001f)
									{
										this.EJOGKNNMMGO(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NFHNOJACGHO);
									}
									if (this.EPPLEFDBBAM(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK) && !this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().EAKLBCIFDEI)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 7);
									}
									else
									{
										this.HGLBOPHFCPH();
										if (this.preWarmFader.gameObject.activeSelf)
										{
											this.preWarmFader.FadeOut(null);
										}
										if (this.MPHBLJIACJI())
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().KPPJINFHMIP.Length > 0)
											{
												AudioManager.EHBBFMCILPC.KillMusic("", 0f);
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = "";
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().DKPPAALFKMO.Length > 0)
											{
												AudioManager.EHBBFMCILPC.KillAmbient("", 0f);
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = "";
											}
											if (this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 2 && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL.Count > 0)
											{
												for (int k = 0; k < this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL.Count; k++)
												{
													if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL[k].Contains("layervideo"))
													{
														this.OFMCEFLLLHO(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HCMBDDEOADO.OCNOFIDCBIH, 0f);
														break;
													}
												}
											}
											this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
										}
										else
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().KPPJINFHMIP.Length > 0)
											{
												AudioManager.EHBBFMCILPC.KillMusic("", this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG);
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = "";
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().DKPPAALFKMO.Length > 0)
											{
												AudioManager.EHBBFMCILPC.KillAmbient("", this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG);
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = "";
											}
											bool flag = false;
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().ILBOLKIAOGK != AKNNGFCMEEA.none)
											{
												flag = this.PPOAAOKBFCN(this.HFOPCMIHDOL.ONECLDMJKEE(i));
											}
											if (!flag)
											{
												if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 2)
												{
													this.OFMCEFLLLHO(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HCMBDDEOADO.OCNOFIDCBIH, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG);
												}
												else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG >= 0.001f || this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH >= 0.001f)
												{
													this.OFMCEFLLLHO(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HCMBDDEOADO.OCNOFIDCBIH, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG);
												}
												if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HNNHBPDBCGG != null)
												{
													this.IEMADPMFPOF(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HNNHBPDBCGG.FKOHEKBAOEK, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG);
												}
												this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG, 1);
											}
										}
									}
								}
								break;
							case OHAAGENIEMD.BMHGEBOHLHH.changeEnvironment:
							{
								AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
								this.GCADKBKMJFP(NGLGPHBGDPD.narrator, 0f);
								this.MEBPBAJKLAP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK);
								this.NFGHFMEEBHN(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NLAPFLNBDLC, DBONHDHEKDG.immediate, Ease.InOutCubic);
								this.MEEKOPBHLDB(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().BIBACLNGIOD, DBONHDHEKDG.immediate, Ease.InOutCubic);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL = this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK;
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = (int)this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NLAPFLNBDLC;
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ONNHAPFMDEN = (int)this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().BIBACLNGIOD;
								float bichmdeifki = 0f;
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 2 && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL.Count > 0)
								{
									for (int l = 0; l < this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL.Count; l++)
									{
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL[l].Contains("layervideo"))
										{
											this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL[l], 0f, 0f, 0f, true, true);
											bichmdeifki = KHPGPLAMAIN.ALOONLDKBHD();
										}
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(bichmdeifki, 1);
								break;
							}
							case OHAAGENIEMD.BMHGEBOHLHH.changeEnvironmentVideoPrepared:
							{
								float num = -1f;
								if (null != this.DMNJMLDEILJ && this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().ILBOLKIAOGK != AKNNGFCMEEA.none && this.DMNJMLDEILJ.HasSnapshot())
								{
									num = this.LLIFOIJCBAE(this.HFOPCMIHDOL.ONECLDMJKEE(i));
								}
								if (num < 0f)
								{
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 2)
									{
										this.MHKLLCIENGM(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HCMBDDEOADO.MOFGINHMBGG, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NCKKJGPMGHG >= 0.001f || this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH >= 0.001f)
									{
										this.MHKLLCIENGM(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HCMBDDEOADO.MOFGINHMBGG, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH);
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HNNHBPDBCGG != null)
								{
									if (num > 0f)
									{
										this.BAMIANEOKAP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HNNHBPDBCGG.ILHCFECFMDI, num);
									}
									else
									{
										this.BAMIANEOKAP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().FLPGNPNHJNK, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().HNNHBPDBCGG.ILHCFECFMDI, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH);
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL.Count > 0)
								{
									for (int m = 0; m < this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL.Count; m++)
									{
										this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL[m], 1f, 1f, 0f, true, false);
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MFCIIAJJMOB(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().GIPMNEKDKIL[m], false);
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().AEEAPPMCNNL.Count > 0)
								{
									for (int n = 0; n < this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().AEEAPPMCNNL.Count; n++)
									{
										this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().AEEAPPMCNNL[n], 0f, 0f, 0f, false, false);
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBCACCKOABP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().AEEAPPMCNNL[n], false);
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().DKPPAALFKMO.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().DKPPAALFKMO), this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().DKPPAALFKMO;
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().MHCAKNHEPDE);
								}
								this.BFOEOHEAPEK(true);
								if (num > 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(num, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().CICCPMFOCGH, 1);
								}
								break;
							}
							case OHAAGENIEMD.BMHGEBOHLHH.attemptToShowAd:
								AKLFPGMDKLA.EHBBFMCILPC.OBBFGMHLMHO++;
								if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && AKLFPGMDKLA.EHBBFMCILPC.OBBFGMHLMHO >= KDCJJBLGCBH.EHBBFMCILPC.BIMOIEHFDAL() && KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyNonRewarded() && CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(PopupRemoveAdsManager.removeAdsProductId) != null && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(PopupRemoveAdsManager.removeAdsProductId) != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CFOHHKJPJPA == 1 && this.HPBFGMAFKDD > 100 && !this.HFOPCMIHDOL.ONECLDMJKEE(i).JPHIPBEBNGD().NGNDOALIKAK.Contains("noads"))
								{
									CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnReadyToWatchIntrusiveAd), new UnityAction(this.OnReadyToWatchIntrusiveAd), DFGILFBGPLN.popupSponsoredAdNotification, 0f, 28);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 4);
								}
								break;
							case OHAAGENIEMD.BMHGEBOHLHH.showRemoveAdsOffer:
								CommonUserInterface.EHBBFMCILPC.ShowPopupRemoveAds();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentFlip:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MCHIHNHANDJ().BOPJOMGIJIA == ANOALPEBPEB.BMHGEBOHLHH.start)
							{
								this.EJOGKNNMMGO(this.HFOPCMIHDOL.ONECLDMJKEE(i).MCHIHNHANDJ().FLPGNPNHJNK, this.HFOPCMIHDOL.ONECLDMJKEE(i).MCHIHNHANDJ().CBANOPDMNEI);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentMove:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().BOPJOMGIJIA == NMCDFDAHPAM.BMHGEBOHLHH.startMove)
							{
								int num2 = this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().NLAPFLNBDLC - (FCABOFEGPGP)AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB;
								this.MINLCJENJIB = -1f;
								float num3;
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().LJLHCJFDNGL < 0f)
								{
									num3 = this.NFGHFMEEBHN(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().NLAPFLNBDLC, this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().GDBFCDHEMKI, Ease.InOutCubic);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(num3, 1);
								}
								else
								{
									num3 = this.NFGHFMEEBHN(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().NLAPFLNBDLC, this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().GDBFCDHEMKI, Ease.InOutSine);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().LJLHCJFDNGL, 1);
									this.MINLCJENJIB = num3 - this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().LJLHCJFDNGL;
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().LLODADPOMJB, -1f, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().MHCAKNHEPDE);
								}
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB != (int)this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().NLAPFLNBDLC || this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().BPOGNJJFAJH != FFHLPKAFOKH.player || this.LLEHEBBHAOD.Count <= 0)
								{
									this.HGLBOPHFCPH();
								}
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = (int)this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().NLAPFLNBDLC;
								if (num3 > 0.001f && num2 != 0 && this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().BPOGNJJFAJH != FFHLPKAFOKH.unknown)
								{
									FFHLPKAFOKH bpognjjfajh = this.HFOPCMIHDOL.ONECLDMJKEE(i).CEDPMMDOCFH().BPOGNJJFAJH;
									if (bpognjjfajh != FFHLPKAFOKH.npc)
									{
										if (bpognjjfajh == FFHLPKAFOKH.player)
										{
											this.GCADKBKMJFP(NGLGPHBGDPD.playerCharacter, num3);
										}
									}
									else
									{
										this.GCADKBKMJFP(NGLGPHBGDPD.nonPlayerCharacter, num3);
									}
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentMoveVertical:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().BOPJOMGIJIA == LPGHIPDCAAA.BMHGEBOHLHH.startMove)
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().LJLHCJFDNGL < 0f)
								{
									float bichmdeifki2 = this.MEEKOPBHLDB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().NLAPFLNBDLC, this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().GDBFCDHEMKI, Ease.InOutCubic);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(bichmdeifki2, 1);
								}
								else
								{
									float bichmdeifki2 = this.MEEKOPBHLDB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().NLAPFLNBDLC, this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().GDBFCDHEMKI, Ease.InOutSine);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().LJLHCJFDNGL, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().LLODADPOMJB, -1f, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().MHCAKNHEPDE);
								}
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ONNHAPFMDEN != (int)this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().NLAPFLNBDLC || this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().BPOGNJJFAJH != FFHLPKAFOKH.player || this.LLEHEBBHAOD.Count <= 0)
								{
									this.HGLBOPHFCPH();
								}
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ONNHAPFMDEN = (int)this.HFOPCMIHDOL.ONECLDMJKEE(i).LCCKBAKGJON().NLAPFLNBDLC;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentFade:
						{
							JPCOGBMHOCI.BMHGEBOHLHH bopjomgijia = this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().BOPJOMGIJIA;
							if (bopjomgijia != JPCOGBMHOCI.BMHGEBOHLHH.fadeIn)
							{
								if (bopjomgijia == JPCOGBMHOCI.BMHGEBOHLHH.fadeOut)
								{
									this.MHKLLCIENGM(this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().DCPHGFEEHHM, this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().AKCEKJFIGJH);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().AKCEKJFIGJH, 1);
								}
							}
							else
							{
								this.HGLBOPHFCPH();
								this.OFMCEFLLLHO(this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().DCPHGFEEHHM, this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().AKCEKJFIGJH);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().AKCEKJFIGJH, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().MHCAKNHEPDE);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).KAKNDMGCNFL().AKCEKJFIGJH, 1);
							}
							break;
						}
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentFadeSrc:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().BOPJOMGIJIA == CHFCDOAMNKH.BMHGEBOHLHH.fadeIn)
							{
								this.HGLBOPHFCPH();
								this.OFMCEFLLLHO(this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().DCPHGFEEHHM, this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().AKCEKJFIGJH);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().AKCEKJFIGJH, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().MHCAKNHEPDE);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).HPKELLKEHEC().AKCEKJFIGJH, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.environmentFadeDst:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().BOPJOMGIJIA == OMAAAEFJKJP.BMHGEBOHLHH.fadeOut)
							{
								this.HGLBOPHFCPH();
								this.MHKLLCIENGM(this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().DCPHGFEEHHM, this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().AKCEKJFIGJH);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().AKCEKJFIGJH, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().MHCAKNHEPDE);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).ALIGABLLBBC().AKCEKJFIGJH, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.dialogNarrator:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().BOPJOMGIJIA)
							{
							case HIHOFCENBBP.BMHGEBOHLHH.show:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count > 0)
								{
									this.APDAMLCHICH();
									this.JOKJBAIECCA(false);
								}
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.KDBHFEDEMBH(null);
								this.KGELMKIBOIJ(null);
								this.MKJBKIKPJEM(null);
								this.MDGOPJKEIAN(null);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().JMNMOHIKHLB = this.JMNMOHIKHLB;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case HIHOFCENBBP.BMHGEBOHLHH.showDialog:
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count > 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.LLGKJGFBKKG, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.OPNHKEEICPG * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								}
								GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.dialogNarratorPrefab);
								gameObject.transform.SetParent(this.narratorDialogPivot.transform, false);
								DialogNarratorManager component = gameObject.GetComponent<DialogNarratorManager>();
								if (component.Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), this.OAPJBCFENNF()))
								{
									this.JCCNMENAHKG(true);
									if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
									{
										this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
									}
								}
								if (SceneStoryManager.localizedLine.Length > 0)
								{
									if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
									{
										this.GKHNIMJJLJL.JLACJIMEGGL(SceneStoryManager.localizedLine);
									}
									else
									{
										this.GKHNIMJJLJL.LNCIMPFKHAO();
									}
									SceneStoryManager.localizedLine = "";
								}
								try
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count > 0 && this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count < 4)
									{
										gameObject.transform.GetComponent<RectTransform>().AHLJBONHHKL(0, component.GetAdditionalVerticalOffset() + component.additionalDialogOffsetY);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count == 4)
									{
										gameObject.transform.GetComponent<RectTransform>().AHLJBONHHKL(0, 64 + component.GetAdditionalVerticalOffset() + component.additionalDialogOffsetY);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count == 5)
									{
										gameObject.transform.GetComponent<RectTransform>().AHLJBONHHKL(0, 96 + component.GetAdditionalVerticalOffset() + component.additionalDialogOffsetY);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count > 5)
									{
										gameObject.transform.GetComponent<RectTransform>().AHLJBONHHKL(0, 160 + component.GetAdditionalVerticalOffset() + component.additionalDialogOffsetY);
									}
								}
								catch (Exception aklgbjkdomm)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
								}
								component.AppearAnimation();
								this.BLNNJFAAHDP.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject));
								this.PKKPMENAIGC = this.GLLFKOJEBPC;
								this.GLLFKOJEBPC = this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().DKEOPDAFLNO();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().JLEAIJGBGHL, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.PlayVoiceOver(iglaigejgho, -1f, -1f);
								}
								if (this.JMNMOHIKHLB != null && this.JMNMOHIKHLB.FILFGDIGINA > 0)
								{
									this.BPKMDANBJKG(true);
								}
								break;
							}
							case HIHOFCENBBP.BMHGEBOHLHH.executeChoice:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() >= 0)
								{
									if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.DBBEJLKKJDA.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.GEAIOJHBEBI.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.EDFDNECFDPA.Count)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOAEANAABEF(this.JMNMOHIKHLB.DBBEJLKKJDA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.EDFDNECFDPA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.GEAIOJHBEBI[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()]);
									}
									this.PKCNCMBMJCI();
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case HIHOFCENBBP.BMHGEBOHLHH.hide:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.KillVoiceOver(iglaigejgho2, -1f);
								}
								this.BAPFLDGINPI();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG.Count > 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.1f, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() >= 0)
								{
									this.GFIFDKBLLBL.ChooseChoiceIndex(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM());
									try
									{
										if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
										{
											this.GKHNIMJJLJL.CFGNAKJMDOL();
											SceneStoryManager.localizedChoice = this.HFOPCMIHDOL.ONECLDMJKEE(i).HANPKNCPKPE().COEFNFJMBDG[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].LONDJHFBEFM();
										}
										else
										{
											this.GKHNIMJJLJL.LNCIMPFKHAO();
											SceneStoryManager.localizedChoice = "";
										}
									}
									catch (Exception aklgbjkdomm2)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
									}
								}
								ApplicationFocusManager.Deactivate();
								this.DHJLICMCKEO();
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.dialogNonPlayerCharacter:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().BOPJOMGIJIA)
							{
							case FEMKDIHKJCM.BMHGEBOHLHH.show:
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.MDGOPJKEIAN(null);
								this.KGELMKIBOIJ(null);
								if (this.MINLCJENJIB > 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.MINLCJENJIB, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.GCADKBKMJFP(NGLGPHBGDPD.nonPlayerCharacter, -1f) * 0.48f, 2);
								}
								break;
							case FEMKDIHKJCM.BMHGEBOHLHH.waitForEnvmove:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.GCADKBKMJFP(NGLGPHBGDPD.nonPlayerCharacter, -1f) * 0.48f, 1);
								break;
							case FEMKDIHKJCM.BMHGEBOHLHH.showCharacter:
							{
								this.MINLCJENJIB = -1f;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.OPNHKEEICPG * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								string text2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().IHCMBIBJBJD);
								DOLBFGIPPOG dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FELDBGLLPBL(text2);
								if (dolbfgippog != null)
								{
									FGINKFGNNEK fginkfgnnek = this.AHBCDMIMLGA(dolbfgippog);
									if (fginkfgnnek == null)
									{
										this.KIPNOKOPJMI(dolbfgippog, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LECOLKOALNK)), HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().EMMOPBJCKGE)));
									}
									else
									{
										fginkfgnnek.DBHMNECMIAB = this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB;
										fginkfgnnek.IACFDHCDEME.GetComponent<PlayerCharacterManager>().SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LECOLKOALNK)), KBACNADIIDP.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().EMMOPBJCKGE)));
									}
									LPEMDECEIAO.EIGLJFIOJPE("");
								}
								else
								{
									try
									{
										if (null == GKJPOGNFKNK.IAJMHBFGKBA(text2, ""))
										{
											for (int num4 = 0; num4 < this.ODNCKIKLFCM.Count; num4++)
											{
												if (null != this.ODNCKIKLFCM[num4])
												{
													for (int num5 = 0; num5 < this.ODNCKIKLFCM[num4].mappings.Count; num5++)
													{
														if (this.ODNCKIKLFCM[num4].mappings[num5].Equals(text2))
														{
															DPGJIJGOCIC.ADFCDFHBDAF("Character " + text2 + " not found, replacing with " + this.ODNCKIKLFCM[num4].id);
															text2 = this.ODNCKIKLFCM[num4].id;
															break;
														}
													}
												}
											}
										}
									}
									catch (Exception aklgbjkdomm3)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
									}
									text2 = this.CIEJIFJDIKE(text2);
								}
								FGINKFGNNEK fginkfgnnek2 = this.DBGJNLEBFFL(text2, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ());
								if (fginkfgnnek2 == null)
								{
									CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
									if (dolbfgippog == null)
									{
										ahlneabnmoa = this.DFPBPDICPMM(text2, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LECOLKOALNK)), HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().EMMOPBJCKGE)));
									}
									try
									{
										GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
										gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
										gameObject2.transform.SetParent(this.nonPlayerCharacterPivot.transform, false);
										NonPlayerCharacterManager component2 = gameObject2.GetComponent<NonPlayerCharacterManager>();
										component2.Initialize(text2, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.right, false);
										SceneStoryManager.OMOGKJCMCKF(text2);
										component2.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromRight);
										component2.SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LECOLKOALNK)), BIDPEOLOIIG.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().EMMOPBJCKGE)));
										component2.ShowDialog(this.dialogNonPlayerCharacterPrefab, this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB(), FJOIFOINENC.animationAppear);
										this.PKPMIABFBON.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject2));
										if (dolbfgippog != null || ahlneabnmoa != null)
										{
											component2.SetVisibility(false);
										}
										goto IL_38F5;
									}
									catch (Exception aklgbjkdomm4)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
										if (ahlneabnmoa != null)
										{
											FGINKFGNNEK fginkfgnnek3 = this.LBCMMKJBNFH(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB);
											if (fginkfgnnek3 != null)
											{
												this.JOFJNLHIJOB.Remove(fginkfgnnek3);
											}
											if (null != this.EBHJLLIHIFE)
											{
												this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
											}
										}
										throw;
									}
									goto IL_379F;
								}
								goto IL_379F;
								IL_38F5:
								if (SceneStoryManager.localizedLine.Length > 0)
								{
									if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
									{
										this.GKHNIMJJLJL.JLACJIMEGGL(SceneStoryManager.localizedLine);
									}
									SceneStoryManager.localizedLine = "";
								}
								LPEMDECEIAO.EIGLJFIOJPE(text2);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().JLEAIJGBGHL, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho3 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.PlayVoiceOver(iglaigejgho3, -1f, -1f);
								}
								this.PKKPMENAIGC = this.GLLFKOJEBPC;
								this.GLLFKOJEBPC = this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().DKEOPDAFLNO();
								this.KDBHFEDEMBH(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB);
								this.MKJBKIKPJEM(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB);
								break;
								IL_379F:
								FGINKFGNNEK fginkfgnnek4 = null;
								if (dolbfgippog == null)
								{
									fginkfgnnek4 = this.LBCMMKJBNFH(fginkfgnnek2.DBHMNECMIAB);
								}
								fginkfgnnek2.DBHMNECMIAB = this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB;
								NonPlayerCharacterManager component3 = fginkfgnnek2.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
								component3.SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LECOLKOALNK)), BIDPEOLOIIG.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().EMMOPBJCKGE)));
								component3.ShowDialog(this.dialogNonPlayerCharacterPrefab, this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB(), FJOIFOINENC.animationAppearCached);
								if (fginkfgnnek4 != null)
								{
									fginkfgnnek4.DBHMNECMIAB = this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB;
									fginkfgnnek4.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LECOLKOALNK)), BIDPEOLOIIG.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().EMMOPBJCKGE)));
								}
								if (dolbfgippog != null)
								{
									component3.SetVisibility(false);
									goto IL_38F5;
								}
								goto IL_38F5;
							}
							case FEMKDIHKJCM.BMHGEBOHLHH.hide:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho4 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).FOBPNFBAJGB().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.KillVoiceOver(iglaigejgho4, -1f);
								}
								ApplicationFocusManager.Deactivate();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.dialogPlayerCharacter:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().BOPJOMGIJIA)
							{
							case HDKFHLFLDGG.BMHGEBOHLHH.show:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG.Count > 0)
								{
									this.APDAMLCHICH();
									this.JOKJBAIECCA(false);
								}
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.KDBHFEDEMBH(null);
								this.MKJBKIKPJEM(null);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().JMNMOHIKHLB = this.JMNMOHIKHLB;
								if (this.MINLCJENJIB > 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.MINLCJENJIB, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.GCADKBKMJFP(NGLGPHBGDPD.playerCharacter, -1f) * 0.48f, 2);
								}
								break;
							case HDKFHLFLDGG.BMHGEBOHLHH.waitForEnvmove:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.GCADKBKMJFP(NGLGPHBGDPD.playerCharacter, -1f) * 0.48f, 1);
								break;
							case HDKFHLFLDGG.BMHGEBOHLHH.showCharacter:
							{
								this.MINLCJENJIB = -1f;
								this.AGFCAHIAAPL();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG.Count > 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.LLGKJGFBKKG, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.OPNHKEEICPG * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								}
								int jbhkmnmmlca = 0;
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0)
								{
									string text3 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI);
									try
									{
										if (null == GKJPOGNFKNK.IAJMHBFGKBA(text3, ""))
										{
											for (int num6 = 0; num6 < this.ODNCKIKLFCM.Count; num6++)
											{
												if (null != this.ODNCKIKLFCM[num6])
												{
													for (int num7 = 0; num7 < this.ODNCKIKLFCM[num6].mappings.Count; num7++)
													{
														if (this.ODNCKIKLFCM[num6].mappings[num7].Equals(text3))
														{
															DPGJIJGOCIC.ADFCDFHBDAF("Character " + text3 + " not found, replacing with " + this.ODNCKIKLFCM[num6].id);
															text3 = this.ODNCKIKLFCM[num6].id;
															break;
														}
													}
												}
											}
										}
									}
									catch (Exception aklgbjkdomm5)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
									}
									text3 = this.CIEJIFJDIKE(text3);
									FGINKFGNNEK fginkfgnnek5 = this.NPMBAFIMPOF(text3, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ());
									AssetStoryNpc assetStoryNpc = GKJPOGNFKNK.IAJMHBFGKBA(text3, "");
									if (null != assetStoryNpc && assetStoryNpc.dialogOffsetAppliesToPlayerSide)
									{
										jbhkmnmmlca = assetStoryNpc.dialogOffsetY;
										if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
										{
											int num8 = 0;
											if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.EOOJNNAHGCM().CONFKFOJHHM(assetStoryNpc.id, out num8))
											{
												jbhkmnmmlca = num8;
											}
										}
									}
									if (fginkfgnnek5 == null)
									{
										GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterRenderTexturePrefab);
										gameObject3.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
										gameObject3.GetComponent<RectTransform>().AMPMCKEAACJ(-1f, 1f, 1f);
										gameObject3.transform.SetParent(this.playerCharacterPivot.transform, false);
										int num9 = -1;
										for (int num10 = 0; num10 < this.LLEHEBBHAOD.Count; num10++)
										{
											if (this.LLEHEBBHAOD[num10] != null && !(null == this.LLEHEBBHAOD[num10].IACFDHCDEME) && !(this.LLEHEBBHAOD[num10].IACFDHCDEME.transform.parent != this.playerCharacterPivot.transform))
											{
												num9 = this.LLEHEBBHAOD[num10].IACFDHCDEME.transform.GetSiblingIndex();
												if (this.LLEHEBBHAOD[num10].DBHMNECMIAB != null && this.LLEHEBBHAOD[num10].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
												{
													break;
												}
											}
										}
										if (num9 >= 0)
										{
											gameObject3.transform.SetSiblingIndex(num9);
										}
										else
										{
											gameObject3.transform.SetAsFirstSibling();
										}
										NonPlayerCharacterManager component4 = gameObject3.GetComponent<NonPlayerCharacterManager>();
										component4.Initialize(text3, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.left, false);
										SceneStoryManager.OMOGKJCMCKF(text3);
										component4.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromLeft);
										component4.RecordLineEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LECOLKOALNK)), HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().EMMOPBJCKGE)));
										component4.SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LECOLKOALNK)), BIDPEOLOIIG.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().EMMOPBJCKGE)));
										component4.DisableFadeOnAppearAndDisappar();
										this.CMBLMOJFGAE.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject3));
									}
									else
									{
										fginkfgnnek5.DBHMNECMIAB = this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB;
										NonPlayerCharacterManager component5 = fginkfgnnek5.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
										component5.RecordLineEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LECOLKOALNK)), HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().EMMOPBJCKGE)));
										component5.SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LECOLKOALNK)), BIDPEOLOIIG.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().EMMOPBJCKGE)));
									}
									LPEMDECEIAO.EIGLJFIOJPE(text3);
								}
								FGINKFGNNEK fginkfgnnek6 = this.BFBFBGHBPFM(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ());
								if (fginkfgnnek6 == null)
								{
									GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterRenderTexturePrefab);
									gameObject4.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
									PlayerCharacterManager component6 = gameObject4.GetComponent<PlayerCharacterManager>();
									component6.InitializeFromSaveData(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.PONLMNGHCAP);
									gameObject4.transform.SetParent(this.playerCharacterPivot.transform, false);
									component6.AnimateAppearance(BKBCKPMDFOD.animationStoryAppearFromLeft);
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length == 0)
									{
										component6.SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LECOLKOALNK)), KBACNADIIDP.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().EMMOPBJCKGE)));
									}
									if (component6.ShowDialog(this.dialogPlayerCharacterPrefab, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM(), this.OAPJBCFENNF(), jbhkmnmmlca, MFAONGBCHJE.animationAppear))
									{
										this.JCCNMENAHKG(true);
										if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
										{
											this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
										}
									}
									this.LLEHEBBHAOD.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject4));
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0)
									{
										component6.SetVisibility(false);
									}
								}
								else
								{
									fginkfgnnek6.DBHMNECMIAB = this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB;
									PlayerCharacterManager component7 = fginkfgnnek6.IACFDHCDEME.GetComponent<PlayerCharacterManager>();
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length == 0)
									{
										component7.SetEmotion(HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LECOLKOALNK)), KBACNADIIDP.appearDelayed, HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().EMMOPBJCKGE)));
									}
									if (component7.ShowDialog(this.dialogPlayerCharacterPrefab, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM(), this.OAPJBCFENNF(), jbhkmnmmlca, MFAONGBCHJE.animationAppearCached))
									{
										this.JCCNMENAHKG(true);
										if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
										{
											this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
										}
									}
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0)
									{
										component7.SetVisibility(false);
									}
								}
								if (SceneStoryManager.localizedLine.Length > 0)
								{
									if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
									{
										this.GKHNIMJJLJL.JLACJIMEGGL(SceneStoryManager.localizedLine);
									}
									SceneStoryManager.localizedLine = "";
								}
								LPEMDECEIAO.EIGLJFIOJPE("");
								if (this.JMNMOHIKHLB != null && this.JMNMOHIKHLB.FILFGDIGINA > 0)
								{
									this.BPKMDANBJKG(true);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().JLEAIJGBGHL, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho5 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.PlayVoiceOver(iglaigejgho5, -1f, -1f);
								}
								this.PKKPMENAIGC = this.GLLFKOJEBPC;
								this.GLLFKOJEBPC = this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().DKEOPDAFLNO();
								this.KGELMKIBOIJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB);
								this.MDGOPJKEIAN(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB);
								break;
							}
							case HDKFHLFLDGG.BMHGEBOHLHH.executeChoice:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() >= 0)
								{
									if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.DBBEJLKKJDA.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.GEAIOJHBEBI.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.EDFDNECFDPA.Count)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOAEANAABEF(this.JMNMOHIKHLB.DBBEJLKKJDA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.EDFDNECFDPA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.GEAIOJHBEBI[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()]);
									}
									this.PKCNCMBMJCI();
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case HDKFHLFLDGG.BMHGEBOHLHH.hide:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho6 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.KillVoiceOver(iglaigejgho6, -1f);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG.Count > 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.1f, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() >= 0)
								{
									this.GFIFDKBLLBL.ChooseChoiceIndex(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM());
									try
									{
										if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
										{
											this.GKHNIMJJLJL.CFGNAKJMDOL();
											SceneStoryManager.localizedChoice = this.HFOPCMIHDOL.ONECLDMJKEE(i).JCHILPICPPM().COEFNFJMBDG[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].LONDJHFBEFM();
										}
										else
										{
											this.GKHNIMJJLJL.LNCIMPFKHAO();
											SceneStoryManager.localizedChoice = "";
										}
									}
									catch (Exception aklgbjkdomm6)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
									}
								}
								ApplicationFocusManager.Deactivate();
								this.DHJLICMCKEO();
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.playAmbient:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNDGMOAMHGF().BOPJOMGIJIA == HLIEMKBHHLB.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).DNDGMOAMHGF().HCOFJONDHDE), this.HFOPCMIHDOL.ONECLDMJKEE(i).DNDGMOAMHGF().PMMCLCMDNGA);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = this.HFOPCMIHDOL.ONECLDMJKEE(i).DNDGMOAMHGF().HCOFJONDHDE;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.stopAmbient:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CAHIONMJKFG().BOPJOMGIJIA == JBONAGNDJGI.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AudioManager.EHBBFMCILPC.KillAmbient("", this.HFOPCMIHDOL.ONECLDMJKEE(i).CAHIONMJKFG().PMMCLCMDNGA);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = "";
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.playMusic:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KHIEMPEAENI().BOPJOMGIJIA == KIPEMGKHALH.BMHGEBOHLHH.start)
							{
								if (this.HFFIIBBJBMH.header.ambientFreeAudio)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).KHIEMPEAENI().KKMKFJLDDNJ = true;
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).KHIEMPEAENI().HCOFJONDHDE, this.HFOPCMIHDOL.ONECLDMJKEE(i).KHIEMPEAENI().KKMKFJLDDNJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).KHIEMPEAENI().PMMCLCMDNGA, false);
								if (this.HFFIIBBJBMH.header.ambientFreeAudio)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).KHIEMPEAENI().HCOFJONDHDE;
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.stopMusic:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BBNBMLJAGME().BOPJOMGIJIA == ONAOILNFLHL.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AudioManager.EHBBFMCILPC.KillMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).BBNBMLJAGME().HCOFJONDHDE, this.HFOPCMIHDOL.ONECLDMJKEE(i).BBNBMLJAGME().PMMCLCMDNGA);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = "";
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.playSfx:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().BOPJOMGIJIA == LFIBINADNJI.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().KKMKFJLDDNJ)
								{
									AudioManager.EHBBFMCILPC.PlaySfxLooped(this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().HCOFJONDHDE, true, this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().PMMCLCMDNGA, this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().LJLHCJFDNGL);
								}
								else
								{
									AudioManager.EHBBFMCILPC.PlaySfxNoLoop(this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().HCOFJONDHDE, true, this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().PMMCLCMDNGA, this.HFOPCMIHDOL.ONECLDMJKEE(i).MJKKOOBIJBF().LJLHCJFDNGL);
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.choiceMeta:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EIOHHHIDOLB().BOPJOMGIJIA == PMNHKIDIMLM.BMHGEBOHLHH.start)
							{
								this.APDAMLCHICH();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PCOFJMBNBNL(this.HFOPCMIHDOL.ONECLDMJKEE(i).EIOHHHIDOLB().APJLHOCPOEO);
								this.JMNMOHIKHLB = new PMNHKIDIMLM(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JMNMOHIKHLB);
								this.ABDHFNHFBMP(this.JMNMOHIKHLB);
								try
								{
									if (this.JMNMOHIKHLB.AIOHLJPBHGH())
									{
										ApplicationFocusManager.Activate();
									}
								}
								catch (Exception aklgbjkdomm7)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
								}
								if (this.JMNMOHIKHLB.GAOKFGHCIAF != PMNHKIDIMLM.NMGJJGIPDJP.text)
								{
									if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
									{
										this.preWarmFader.FadeOut(null);
									}
									this.HFOPCMIHDOL.HFALHCEIDPM(this.GFIFDKBLLBL, true, false, true, false);
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.choiceMetaOneToMany:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JHJMNDAKKAM().BOPJOMGIJIA == JJBCFINBFKL.BMHGEBOHLHH.start)
							{
								this.APDAMLCHICH();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OBFBHGHEADP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JHJMNDAKKAM().APJLHOCPOEO);
								this.JGEDOIDOPLA = new JJBCFINBFKL(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JGEDOIDOPLA);
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.HFOPCMIHDOL.HFALHCEIDPM(this.GFIFDKBLLBL, false, true, true, false);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.choiceExtended:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).CFBKBPNDMGD().BOPJOMGIJIA)
							{
							case LHBFJJIJNMI.BMHGEBOHLHH.show:
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								this.HGLBOPHFCPH();
								this.HJKLOODDLDE(100);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).CFBKBPNDMGD().JMNMOHIKHLB = this.JMNMOHIKHLB;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).CFBKBPNDMGD().PKGCGJFFEPM();
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 2)
								{
									this.EDOBNNLBBDC = false;
									this.JMNMOHIKHLB.PFJKBHDJBKN = false;
								}
								if (this.JMNMOHIKHLB != null)
								{
									if (this.EDOBNNLBBDC)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
									}
									else
									{
										this.OFMCEFLLLHO(this.JMNMOHIKHLB.DCPHGFEEHHM, 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
									}
								}
								else
								{
									this.OFMCEFLLLHO("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								}
								this.EDOBNNLBBDC = false;
								break;
							case LHBFJJIJNMI.BMHGEBOHLHH.showChoice:
							{
								if (this.JMNMOHIKHLB != null)
								{
									this.MHKLLCIENGM(this.JMNMOHIKHLB.DCPHGFEEHHM, 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								}
								else
								{
									this.MHKLLCIENGM("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								}
								if (this.LHBMEFGCPHK() && null != this.imageEffects)
								{
									if (this.JMNMOHIKHLB == null)
									{
										this.imageEffects.ShowAllEffectsWithTag("blur");
									}
									else if (this.JMNMOHIKHLB.GAOKFGHCIAF != PMNHKIDIMLM.NMGJJGIPDJP.environment)
									{
										this.imageEffects.ShowAllEffectsWithTag("blur");
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.extendedChoicePrefab);
								gameObject5.transform.SetParent(this.extendedChoicePivot.transform, false);
								gameObject5.GetComponent<ChoiceExtendedManager>().SetSwipeToBrowseHostGate(new Func<bool>(this.LAHJKCAFPHA));
								if (gameObject5.GetComponent<ChoiceExtendedManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).CFBKBPNDMGD(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), this.OAPJBCFENNF(), this.ODNCKIKLFCM, this.PCDHECPEOAJ()))
								{
									this.JCCNMENAHKG(true);
									if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
									{
										this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
									}
								}
								this.KICOPFEHKJF.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject5));
								this.BPKMDANBJKG(true);
								break;
							}
							case LHBFJJIJNMI.BMHGEBOHLHH.executeChoice:
								switch (this.JMNMOHIKHLB.GAOKFGHCIAF)
								{
								case PMNHKIDIMLM.NMGJJGIPDJP.clothes:
									if (this.JMNMOHIKHLB.OEJMMCNBNKK.Length > 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.JMNMOHIKHLB.OEJMMCNBNKK, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, false);
									}
									if (!this.JMNMOHIKHLB.NGNDOALIKAK.Contains("trialmode"))
									{
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].EKDGAODNDOP() == HKCCMACFNEO.bulk)
										{
											for (int num11 = 0; num11 < this.JMNMOHIKHLB.AOANDELCCEL.Count; num11++)
											{
												if (num11 < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[num11].EKDGAODNDOP() != HKCCMACFNEO.bulk)
												{
													this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[num11].COOOGACBAKN), "", false);
												}
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() - 1].COOOGACBAKN), "", true);
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.clothes: bulk choice index must be > 0.");
											}
										}
										else
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN), "", true);
										}
									}
									break;
								case PMNHKIDIMLM.NMGJJGIPDJP.hair:
									if (this.JMNMOHIKHLB.OEJMMCNBNKK.Length > 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.JMNMOHIKHLB.OEJMMCNBNKK, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, false);
									}
									if (!this.JMNMOHIKHLB.NGNDOALIKAK.Contains("trialmode"))
									{
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].EKDGAODNDOP() == HKCCMACFNEO.bulk)
										{
											for (int num12 = 0; num12 < this.JMNMOHIKHLB.AOANDELCCEL.Count; num12++)
											{
												if (num12 < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[num12].EKDGAODNDOP() != HKCCMACFNEO.bulk)
												{
													this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[num12].COOOGACBAKN), "", false);
												}
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() - 1].COOOGACBAKN), "", true);
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.hair: bulk choice index must be > 0.");
											}
										}
										else
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN), "", true);
										}
									}
									break;
								case PMNHKIDIMLM.NMGJJGIPDJP.trinket:
									if (this.JMNMOHIKHLB.OEJMMCNBNKK.Length > 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.JMNMOHIKHLB.OEJMMCNBNKK, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, false);
									}
									if (!this.JMNMOHIKHLB.NGNDOALIKAK.Contains("trialmode"))
									{
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].EKDGAODNDOP() == HKCCMACFNEO.bulk)
										{
											for (int num13 = 0; num13 < this.JMNMOHIKHLB.AOANDELCCEL.Count; num13++)
											{
												if (num13 < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[num13].EKDGAODNDOP() != HKCCMACFNEO.bulk)
												{
													this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[num13].COOOGACBAKN), "", false);
												}
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() - 1].COOOGACBAKN), "", true);
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.trinket: bulk choice index must be > 0.");
											}
										}
										else
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN), "", true);
										}
									}
									break;
								case PMNHKIDIMLM.NMGJJGIPDJP.item:
								case PMNHKIDIMLM.NMGJJGIPDJP.npc:
								case PMNHKIDIMLM.NMGJJGIPDJP.environment:
									if (this.JMNMOHIKHLB.OEJMMCNBNKK.Length > 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.JMNMOHIKHLB.OEJMMCNBNKK, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, false);
									}
									break;
								case PMNHKIDIMLM.NMGJJGIPDJP.overlay:
									if (this.JMNMOHIKHLB.OEJMMCNBNKK.Length > 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.JMNMOHIKHLB.OEJMMCNBNKK, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, false);
									}
									if (!this.JMNMOHIKHLB.NGNDOALIKAK.Contains("trialmode"))
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.overlay, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN), "", true);
									}
									break;
								case PMNHKIDIMLM.NMGJJGIPDJP.face:
									if (this.JMNMOHIKHLB.OEJMMCNBNKK.Length > 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.JMNMOHIKHLB.OEJMMCNBNKK, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].GEMBCIPGIEB, false);
									}
									if (!this.JMNMOHIKHLB.NGNDOALIKAK.Contains("trialmode"))
									{
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].EKDGAODNDOP() == HKCCMACFNEO.bulk)
										{
											for (int num14 = 0; num14 < this.JMNMOHIKHLB.AOANDELCCEL.Count; num14++)
											{
												if (num14 < this.JMNMOHIKHLB.MKPMEKKGEIL.Count && this.JMNMOHIKHLB.MKPMEKKGEIL[num14].EKDGAODNDOP() != HKCCMACFNEO.bulk)
												{
													this.NGGHOOIELJP(KFIHMMIGPLO.face, this.JMNMOHIKHLB.AOANDELCCEL[num14].COOOGACBAKN, "", false);
												}
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.face, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() - 1].COOOGACBAKN, "", true);
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.face: bulk choice index must be > 0.");
											}
										}
										else
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.face, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, "", true);
										}
									}
									break;
								case PMNHKIDIMLM.NMGJJGIPDJP.body:
									if (!this.JMNMOHIKHLB.NGNDOALIKAK.Contains("trialmode"))
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.body, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, "", true);
										AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.IIHLMMBEPMB(KFIHMMIGPLO.face, this.JMNMOHIKHLB.AOANDELCCEL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].COOOGACBAKN, this.PCDHECPEOAJ());
										if (null != assetAvatarComponent)
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.face, assetAvatarComponent.id, "", true);
										}
										else
										{
											DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice: - firstAvailableFaceAsset is null.");
										}
									}
									break;
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.DBBEJLKKJDA.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.GEAIOJHBEBI.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.EDFDNECFDPA.Count)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOAEANAABEF(this.JMNMOHIKHLB.DBBEJLKKJDA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.EDFDNECFDPA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.GEAIOJHBEBI[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()]);
								}
								if (this.JMNMOHIKHLB.AEEAPPMCNNL.Count > 0)
								{
									this.OKIHENOGDKD(this.JMNMOHIKHLB.AEEAPPMCNNL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], 1f, 0f, 1f, false, false);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBCACCKOABP(this.JMNMOHIKHLB.AEEAPPMCNNL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], false);
								}
								if (this.JMNMOHIKHLB.GIPMNEKDKIL.Count > 0)
								{
									this.OKIHENOGDKD(this.JMNMOHIKHLB.GIPMNEKDKIL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], 0f, 1f, 1f, true, false);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MFCIIAJJMOB(this.JMNMOHIKHLB.GIPMNEKDKIL[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], false);
								}
								if (this.JMNMOHIKHLB.KIDPANPCBFF.Count > 0)
								{
									List<string> list = new List<string>();
									list.Add(this.JMNMOHIKHLB.KIDPANPCBFF[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()]);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JMJKIMJKPOE(list);
								}
								this.IOLCAEIBHCD();
								for (int num15 = 0; num15 < this.KICOPFEHKJF.Count; num15++)
								{
									if (this.KICOPFEHKJF[num15].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.KICOPFEHKJF[num15].IACFDHCDEME.GetComponent<ChoiceExtendedManager>().GetChoiceExecutedAnimationTime(), 1);
										break;
									}
								}
								break;
							case LHBFJJIJNMI.BMHGEBOHLHH.fadeIn:
								if (this.JMNMOHIKHLB != null)
								{
									this.OFMCEFLLLHO(this.JMNMOHIKHLB.DCPHGFEEHHM, 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								}
								else
								{
									this.OFMCEFLLLHO("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								break;
							case LHBFJJIJNMI.BMHGEBOHLHH.fadeOut:
								if (this.JMNMOHIKHLB != null)
								{
									if (!this.JMNMOHIKHLB.PFJKBHDJBKN)
									{
										this.MHKLLCIENGM(this.JMNMOHIKHLB.DCPHGFEEHHM, 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
									}
								}
								else
								{
									this.MHKLLCIENGM("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								}
								this.EDOBNNLBBDC = this.JMNMOHIKHLB.PFJKBHDJBKN;
								this.JMNMOHIKHLB = null;
								ApplicationFocusManager.Deactivate();
								if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
								{
									this.imageEffects.HideAllEffectsWithTag("blur");
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case LHBFJJIJNMI.BMHGEBOHLHH.hide:
								for (int num16 = 0; num16 < this.KICOPFEHKJF.Count; num16++)
								{
									if (this.KICOPFEHKJF[num16].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.KICOPFEHKJF[num16].IACFDHCDEME);
										this.KICOPFEHKJF.RemoveAt(num16);
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								this.GFIFDKBLLBL.ChooseChoiceIndex(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM());
								try
								{
									if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
									{
										this.GKHNIMJJLJL.CFGNAKJMDOL();
										SceneStoryManager.localizedChoice = this.HFOPCMIHDOL.ONECLDMJKEE(i).CFBKBPNDMGD().COEFNFJMBDG[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].LONDJHFBEFM();
									}
									else
									{
										this.GKHNIMJJLJL.LNCIMPFKHAO();
										SceneStoryManager.localizedChoice = "";
									}
								}
								catch (Exception aklgbjkdomm8)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm8);
								}
								this.DHJLICMCKEO();
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.choiceExtendedOneToMany:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOBCADDLPGG().BOPJOMGIJIA)
							{
							case BAAFDFAEKIH.BMHGEBOHLHH.show:
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								this.HGLBOPHFCPH();
								this.HJKLOODDLDE(100);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).JOBCADDLPGG().JGEDOIDOPLA = this.JGEDOIDOPLA;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).JOBCADDLPGG().PKGCGJFFEPM();
								this.OFMCEFLLLHO("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								break;
							case BAAFDFAEKIH.BMHGEBOHLHH.showChoice:
							{
								this.MHKLLCIENGM("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								if (this.LHBMEFGCPHK() && null != this.imageEffects)
								{
									this.imageEffects.ShowAllEffectsWithTag("blur");
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.extendedChoiceOneToManyPrefab);
								gameObject6.transform.SetParent(this.extendedChoiceOneToManyPivot.transform, false);
								if (gameObject6.GetComponent<ChoiceExtendedOneToManyManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOBCADDLPGG(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), this.OAPJBCFENNF(), this.ODNCKIKLFCM))
								{
									this.JCCNMENAHKG(true);
									if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
									{
										this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
									}
								}
								this.BPKMDANBJKG(true);
								this.ADIPBAHEMFF.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject6));
								break;
							}
							case BAAFDFAEKIH.BMHGEBOHLHH.executeChoice:
								this.PKCNCMBMJCI();
								for (int num17 = 0; num17 < this.ADIPBAHEMFF.Count; num17++)
								{
									if (this.ADIPBAHEMFF[num17].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.ADIPBAHEMFF[num17].IACFDHCDEME.GetComponent<ChoiceExtendedOneToManyManager>().GetChoiceExecutedAnimationTime(), 1);
										break;
									}
								}
								break;
							case BAAFDFAEKIH.BMHGEBOHLHH.fadeIn:
								this.OFMCEFLLLHO("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
								break;
							case BAAFDFAEKIH.BMHGEBOHLHH.fadeOut:
								this.MHKLLCIENGM("black", 0.75f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
								ApplicationFocusManager.Deactivate();
								if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
								{
									this.imageEffects.HideAllEffectsWithTag("blur");
								}
								this.JGEDOIDOPLA = null;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case BAAFDFAEKIH.BMHGEBOHLHH.hide:
								for (int num18 = 0; num18 < this.ADIPBAHEMFF.Count; num18++)
								{
									if (this.ADIPBAHEMFF[num18].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.ADIPBAHEMFF[num18].IACFDHCDEME);
										this.ADIPBAHEMFF.RemoveAt(num18);
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								this.GFIFDKBLLBL.ChooseChoiceIndex(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM());
								try
								{
									if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
									{
										this.GKHNIMJJLJL.CFGNAKJMDOL();
										SceneStoryManager.localizedChoice = this.HFOPCMIHDOL.ONECLDMJKEE(i).JOBCADDLPGG().COEFNFJMBDG[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()].LONDJHFBEFM();
									}
									else
									{
										this.GKHNIMJJLJL.LNCIMPFKHAO();
										SceneStoryManager.localizedChoice = "";
									}
								}
								catch (Exception aklgbjkdomm9)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm9);
								}
								this.DHJLICMCKEO();
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.noteShow:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().BOPJOMGIJIA)
							{
							case MPEEFIAIDBE.BMHGEBOHLHH.show:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f + 2f * (float)this.JGCFEBDMBMC.Count + 1.5f * (float)this.AGKKCOENLOJ.Count, 1);
								this.JGCFEBDMBMC.Add(1);
								break;
							case MPEEFIAIDBE.BMHGEBOHLHH.delayBeforeDisappear:
							{
								try
								{
									for (int num19 = 0; num19 < this.PBPHFLJDNBH.Count; num19++)
									{
										if (this.PBPHFLJDNBH[num19] != null && null != this.PBPHFLJDNBH[num19].IACFDHCDEME && !this.PBPHFLJDNBH[num19].IACFDHCDEME.GetComponent<StoryNoteManager>().IsDisappearing())
										{
											this.PBPHFLJDNBH[num19].IACFDHCDEME.GetComponent<StoryNoteManager>().DisappearAnimationLong();
										}
									}
								}
								catch (Exception aklgbjkdomm10)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm10);
								}
								try
								{
									for (int num20 = 0; num20 < this.BBNLMENIFNJ.Count; num20++)
									{
										if (this.BBNLMENIFNJ[num20] != null && null != this.BBNLMENIFNJ[num20].IACFDHCDEME && !this.BBNLMENIFNJ[num20].IACFDHCDEME.GetComponent<StatPointManager>().IsDisappearing())
										{
											this.BBNLMENIFNJ[num20].IACFDHCDEME.GetComponent<StatPointManager>().DisappearAnimationLong();
										}
									}
								}
								catch (Exception aklgbjkdomm11)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm11);
								}
								if (!AudioManager.EHBBFMCILPC.PlaySfx("sfxnotification", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxnotification" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
								{
									AudioManager.EHBBFMCILPC.PlaySfx("notification", false);
								}
								GameObject gameObject7;
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().CPKDONIMHML.Length > 0)
								{
									gameObject7 = UnityEngine.Object.Instantiate<GameObject>(this.noteStoryAchievementPrefab);
								}
								else
								{
									gameObject7 = UnityEngine.Object.Instantiate<GameObject>(this.noteStoryPrefab);
								}
								gameObject7.transform.SetParent(this.notesPivot.transform, false);
								gameObject7.GetComponent<StoryNoteManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().PFLJLFGCIFB(), this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().EEKMOHDNCKF(), this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().CPKDONIMHML);
								this.PBPHFLJDNBH.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject7));
								DPGJIJGOCIC.NFIDPOMCNLP("StoryStepNoteShow.StoryStepStage.delayBeforeDisappear timeToNextStage:" + this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().PMMCLCMDNGA.ToString() + this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().LJLHCJFDNGL.ToString());
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().PMMCLCMDNGA + this.HFOPCMIHDOL.ONECLDMJKEE(i).BKBJDPEFGCE().LJLHCJFDNGL, 1);
								break;
							}
							case MPEEFIAIDBE.BMHGEBOHLHH.disappear:
							{
								int num21 = 0;
								while (num21 < this.PBPHFLJDNBH.Count)
								{
									if (this.PBPHFLJDNBH[num21].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										if (!this.PBPHFLJDNBH[num21].IACFDHCDEME.GetComponent<StoryNoteManager>().IsDisappearing())
										{
											this.PBPHFLJDNBH[num21].IACFDHCDEME.GetComponent<StoryNoteManager>().DisappearAnimation();
											break;
										}
										break;
									}
									else
									{
										num21++;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							}
							case MPEEFIAIDBE.BMHGEBOHLHH.destroy:
								for (int num22 = 0; num22 < this.PBPHFLJDNBH.Count; num22++)
								{
									if (this.PBPHFLJDNBH[num22].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.PBPHFLJDNBH[num22].IACFDHCDEME);
										this.PBPHFLJDNBH.RemoveAt(num22);
										break;
									}
								}
								if (this.JGCFEBDMBMC.Count > 0)
								{
									this.JGCFEBDMBMC.RemoveAt(0);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.layerShow:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().BOPJOMGIJIA == JABCGEIIPEI.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								for (int num23 = 0; num23 < this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC.Count; num23++)
								{
									this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num23], this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().ABLPJMDMIPB, this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().AHHCLMBOCON, this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().PMMCLCMDNGA, true, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().PMMCLCMDNGA, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().DKPPAALFKMO.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().DKPPAALFKMO), this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().PMMCLCMDNGA);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().DKPPAALFKMO;
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().MHCAKNHEPDE);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LJLHCJFDNGL < 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().PMMCLCMDNGA, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LJLHCJFDNGL, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().HABIIFFBHEA > 1E-05f)
								{
									if (null != this.animationShakeEnvironmentFront)
									{
										this.animationShakeEnvironmentFront.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().HABIIFFBHEA;
										this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
										this.animationShakeEnvironmentFront.PlayAnimation();
									}
									if (null != this.animationShakeEnvironmentBack)
									{
										this.animationShakeEnvironmentBack.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().HABIIFFBHEA;
										this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
										this.animationShakeEnvironmentBack.PlayAnimation();
									}
								}
								for (int num24 = 0; num24 < this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC.Count; num24++)
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24].Contains("CLIENT.SCREEN.REWARD."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GFLJFEANKPE(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GFLJFEANKPE(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24].Contains("CLIENT.SCREEN.AVATAR."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FDOLKJHBBGN(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().FDOLKJHBBGN(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
									}
									else
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MFCIIAJJMOB(this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().LOCCINPEPKC[num24], this.HFOPCMIHDOL.ONECLDMJKEE(i).EDLDKCHGEFJ().FPHDAKHOBMO);
									}
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.layerHide:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().BOPJOMGIJIA == IDMFLDBGAEE.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								for (int num25 = 0; num25 < this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC.Count; num25++)
								{
									this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num25], this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().ABLPJMDMIPB, this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().AHHCLMBOCON, this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().PMMCLCMDNGA, false, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().PMMCLCMDNGA, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().DKPPAALFKMO.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().DKPPAALFKMO), this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().PMMCLCMDNGA);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().DKPPAALFKMO;
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().MHCAKNHEPDE);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LJLHCJFDNGL < 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().PMMCLCMDNGA, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LJLHCJFDNGL, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().HABIIFFBHEA > 1E-05f)
								{
									if (null != this.animationShakeEnvironmentFront)
									{
										this.animationShakeEnvironmentFront.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().HABIIFFBHEA;
										this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
										this.animationShakeEnvironmentFront.PlayAnimation();
									}
									if (null != this.animationShakeEnvironmentBack)
									{
										this.animationShakeEnvironmentBack.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().HABIIFFBHEA;
										this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
										this.animationShakeEnvironmentBack.PlayAnimation();
									}
								}
								for (int num26 = 0; num26 < this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC.Count; num26++)
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26].Contains("CLIENT.SCREEN.REWARD."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PLOKEOLNPLI(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().PLOKEOLNPLI(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26].Contains("CLIENT.SCREEN.AVATAR."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KEGCLEKKCPB(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().KEGCLEKKCPB(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
									}
									else
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBCACCKOABP(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().LOCCINPEPKC[num26], this.HFOPCMIHDOL.ONECLDMJKEE(i).BOOINHJMFPI().FPHDAKHOBMO);
									}
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.delay:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ILLKODLIAKB().BOPJOMGIJIA == LDPKIDKFDKG.BMHGEBOHLHH.start)
							{
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.KEFMLJIGODO() == 2)
								{
									this.HGLBOPHFCPH();
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).ILLKODLIAKB().JCIAOPBKNCH, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.shakeScreen:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().BOPJOMGIJIA == FLODDPAJCAP.BMHGEBOHLHH.start)
							{
								if (null != this.animationShakeEnvironmentFront)
								{
									this.animationShakeEnvironmentFront.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().PMMCLCMDNGA;
									this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
									this.animationShakeEnvironmentFront.PlayAnimation();
								}
								if (null != this.animationShakeEnvironmentBack)
								{
									this.animationShakeEnvironmentBack.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().PMMCLCMDNGA;
									this.animationShakeEnvironmentBack.frameUpdateInterval = 0.04f;
									this.animationShakeEnvironmentBack.PlayAnimation();
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().MHCAKNHEPDE);
								}
								base.StartCoroutine(this.GBKPAADANKO(this.HFOPCMIHDOL.ONECLDMJKEE(i).MFJFFCKGDOB().PMMCLCMDNGA));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.ignoreChoice:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GNJMKOFGKNM().BOPJOMGIJIA == PGFFKNAEFDE.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.emptyStep:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CDOKGKIPKOC().BOPJOMGIJIA == CPFJIACDGEP.BMHGEBOHLHH.start)
							{
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.BAABIIPPLCE = 3f;
								this.BAABIIPPLCE *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
								this.HGLBOPHFCPH();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.dummy:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NBHLCADGGEK().BOPJOMGIJIA == ODDDCGEMPFK.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.cacheAssetPack:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GBOPIHGLAHA().BOPJOMGIJIA == NDFKFMPHODF.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOAEANAABEF(this.HFOPCMIHDOL.ONECLDMJKEE(i).GBOPIHGLAHA().KIMBCEKMBNG, this.HFOPCMIHDOL.ONECLDMJKEE(i).GBOPIHGLAHA().IFCHGNCDMLJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).GBOPIHGLAHA().KKJNKAFMANA);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.uncacheAssetPack:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GCCNPOAEMNN().BOPJOMGIJIA == CHGMJKIAOLJ.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LBFDCJNJCFN(this.HFOPCMIHDOL.ONECLDMJKEE(i).GCCNPOAEMNN().KIMBCEKMBNG);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.enableAvatarExtension:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OCGDEKMFBAD().BOPJOMGIJIA == NEHHFJNIMNM.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().CAKCMKHENBI(this.HFOPCMIHDOL.ONECLDMJKEE(i).OCGDEKMFBAD().OOIOCDOGCNE);
								AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OELDOMFJLOP(0).CAKCMKHENBI(this.HFOPCMIHDOL.ONECLDMJKEE(i).OCGDEKMFBAD().OOIOCDOGCNE);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.disableAvatarExtension:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BOEKBKLMOGC().BOPJOMGIJIA == ILHOIOKDMMD.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().PIIBPPMMIHG(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOEKBKLMOGC().OOIOCDOGCNE);
								AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OELDOMFJLOP(0).PIIBPPMMIHG(this.HFOPCMIHDOL.ONECLDMJKEE(i).BOEKBKLMOGC().OOIOCDOGCNE);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.invokeAvatarExtension:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MPOLMMOACFJ().BOPJOMGIJIA == MCHHEPGNIAL.BMHGEBOHLHH.start)
							{
								this.ACPDJAEHHGN(this.HFOPCMIHDOL.ONECLDMJKEE(i).MPOLMMOACFJ().OOIOCDOGCNE);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).MPOLMMOACFJ().AKCEKJFIGJH, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.showAds:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LKJPPBFLGFL().BOPJOMGIJIA == HMGFCPHOIKO.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CFOHHKJPJPA = 1;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.hideAds:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LFEPOHPPBHD().BOPJOMGIJIA == MGOLMNDHGNG.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CFOHHKJPJPA = 0;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.defaultLang:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CANBODCFLCG().BOPJOMGIJIA == DFKBHGBFNHB.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IMIDHJMEGOG = this.HFOPCMIHDOL.ONECLDMJKEE(i).CANBODCFLCG().NCFJPLBAGDP;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.readInput:
						{
							MLGNGCLDHJO.BMHGEBOHLHH bopjomgijia2 = this.HFOPCMIHDOL.ONECLDMJKEE(i).JLLMJEEPGIM().BOPJOMGIJIA;
							if (bopjomgijia2 != MLGNGCLDHJO.BMHGEBOHLHH.start)
							{
								if (bopjomgijia2 == MLGNGCLDHJO.BMHGEBOHLHH.hide)
								{
									if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
									{
										this.imageEffects.HideAllEffectsWithTag("blur");
									}
									for (int num27 = 0; num27 < this.PGNIDAAHCOI.Count; num27++)
									{
										if (this.PGNIDAAHCOI[num27].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
										{
											UnityEngine.Object.Destroy(this.PGNIDAAHCOI[num27].IACFDHCDEME);
											this.PGNIDAAHCOI.RemoveAt(num27);
											break;
										}
									}
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
							}
							else
							{
								if (this.LHBMEFGCPHK() && null != this.imageEffects)
								{
									this.imageEffects.ShowAllEffectsWithTag("blur");
								}
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.HGLBOPHFCPH();
								this.HJKLOODDLDE(100);
								GameObject gameObject8 = UnityEngine.Object.Instantiate<GameObject>(this.dialogReadInputPrefab);
								gameObject8.transform.SetParent(this.readInputPivot.transform, false);
								gameObject8.GetComponent<DialogReadInputManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).JLLMJEEPGIM(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), this.ODNCKIKLFCM);
								this.PGNIDAAHCOI.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject8));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						}
						case KGLBKJKNPFD.LBFFMOMMAPK.avatarConfig:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().BOPJOMGIJIA == IKICLNCOBMC.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().PLPCLJFJFNG.Length > 0)
								{
									this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().PLPCLJFJFNG), this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().JHHKEPGLHKD.Length > 0)
								{
									this.NGGHOOIELJP(KFIHMMIGPLO.body, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().JHHKEPGLHKD, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
									AssetAvatarComponent assetAvatarComponent2 = GKJPOGNFKNK.IIHLMMBEPMB(KFIHMMIGPLO.face, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.PCDHECPEOAJ());
									if (null != assetAvatarComponent2)
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.face, assetAvatarComponent2.id, "", true);
									}
									else
									{
										DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStep.StoryStepType.avatarConfig - firstAvailableFaceAsset is null.");
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().KGOAGNFNFIJ.Length > 0)
								{
									if (GKJPOGNFKNK.GBIHAFHGMEL(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().KGOAGNFNFIJ, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.PCDHECPEOAJ()))
									{
										AssetAvatarComponent assetAvatarComponent3 = GKJPOGNFKNK.KGFLNLPJGAL(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().KGOAGNFNFIJ, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.PCDHECPEOAJ());
										if (null != assetAvatarComponent3)
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.face, assetAvatarComponent3.id, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
										}
										else
										{
											DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStep.StoryStepType.avatarConfig - finalAvatarComponentAsset is null.");
										}
									}
									else
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().KGOAGNFNFIJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().OMGLOJOIOCK.Length > 0)
								{
									this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().OMGLOJOIOCK), this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().PBOKDNDMCDL.Length > 0)
								{
									this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().PBOKDNDMCDL), this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().GHALDHOOFKN.Length > 0)
								{
									this.NGGHOOIELJP(KFIHMMIGPLO.overlay, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().GHALDHOOFKN), this.HFOPCMIHDOL.ONECLDMJKEE(i).EBEGNIBCMDM().DIGBLIJOKJE, true);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.tryAvatarConfig:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().BOPJOMGIJIA == LMIJCBDNGIK.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								try
								{
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOLCAAOOOCN() >= 2 && this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().KGOAGNFNFIJ.Count > 0)
									{
										bool flag2 = false;
										AssetAvatarComponent assetAvatarComponent4 = null;
										for (int num28 = 0; num28 < this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().KGOAGNFNFIJ.Count; num28++)
										{
											if (GKJPOGNFKNK.GBIHAFHGMEL(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().KGOAGNFNFIJ[num28], AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.PCDHECPEOAJ()))
											{
												AssetAvatarComponent assetAvatarComponent5 = GKJPOGNFKNK.KGFLNLPJGAL(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().KGOAGNFNFIJ[num28], AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.PCDHECPEOAJ());
												if (null != assetAvatarComponent5)
												{
													if (null == assetAvatarComponent4)
													{
														assetAvatarComponent4 = assetAvatarComponent5;
													}
													if (this.GKHNIMJJLJL.NCAMFPGMCIG.NIJAJALPEDL(assetAvatarComponent5.id))
													{
														this.NGGHOOIELJP(KFIHMMIGPLO.face, assetAvatarComponent5.id, "", true);
														flag2 = true;
														break;
													}
												}
												else
												{
													DPGJIJGOCIC.ANOPFDLPKGC("ERROR: StoryStep.StoryStepType.tryAvatarConfig - finalAvatarComponentAsset is null.");
												}
											}
										}
										if (!flag2 && null != assetAvatarComponent4)
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.face, assetAvatarComponent4.id, "", true);
											DPGJIJGOCIC.ADFCDFHBDAF("Could not find an existent component for tryAvatarConfig/face, forcing default option.");
										}
									}
								}
								catch (Exception aklgbjkdomm12)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm12);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PLPCLJFJFNG.Count > 0)
								{
									bool flag3 = false;
									for (int num29 = 0; num29 < this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PLPCLJFJFNG.Count; num29++)
									{
										if (this.GKHNIMJJLJL.NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PLPCLJFJFNG[num29]))
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PLPCLJFJFNG[num29]), "", true);
											flag3 = true;
											break;
										}
									}
									if (!flag3)
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PLPCLJFJFNG[0]), "", true);
										DPGJIJGOCIC.ADFCDFHBDAF("Could not find an existent component for tryAvatarConfig/clothes, forcing default option.");
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().OMGLOJOIOCK.Count > 0)
								{
									bool flag4 = false;
									for (int num30 = 0; num30 < this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().OMGLOJOIOCK.Count; num30++)
									{
										if (this.GKHNIMJJLJL.NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().OMGLOJOIOCK[num30]))
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().OMGLOJOIOCK[num30]), "", true);
											flag4 = true;
											break;
										}
									}
									if (!flag4)
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().OMGLOJOIOCK[0]), "", true);
										DPGJIJGOCIC.ADFCDFHBDAF("Could not find an existent component for tryAvatarConfig/hair, forcing default option.");
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PBOKDNDMCDL.Count > 0)
								{
									bool flag5 = false;
									for (int num31 = 0; num31 < this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PBOKDNDMCDL.Count; num31++)
									{
										if (this.GKHNIMJJLJL.NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PBOKDNDMCDL[num31]))
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PBOKDNDMCDL[num31]), "", true);
											flag5 = true;
											break;
										}
									}
									if (!flag5)
									{
										this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().PBOKDNDMCDL[0]), "", true);
										DPGJIJGOCIC.ADFCDFHBDAF("Could not find an existent component for tryAvatarConfig/trinket, forcing default option.");
									}
								}
								try
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().GHALDHOOFKN.Count > 0)
									{
										bool flag6 = false;
										for (int num32 = 0; num32 < this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().GHALDHOOFKN.Count; num32++)
										{
											if (this.GKHNIMJJLJL.NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().GHALDHOOFKN[num32]))
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.overlay, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().GHALDHOOFKN[num32]), "", true);
												flag6 = true;
												break;
											}
										}
										if (!flag6)
										{
											this.NGGHOOIELJP(KFIHMMIGPLO.overlay, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NDPPOCAHKAL().GHALDHOOFKN[0]), "", true);
											DPGJIJGOCIC.ADFCDFHBDAF("Could not find an existent component for tryAvatarConfig/overlay, forcing default option.");
										}
									}
								}
								catch (Exception aklgbjkdomm13)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm13);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcFromAvatar:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONLCFHFCCIA().BOPJOMGIJIA == HEIBLHGMPLD.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NDHDKHEFOFO(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONLCFHFCCIA().IHCMBIBJBJD, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONLCFHFCCIA().PLPCLJFJFNG, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONLCFHFCCIA().OMGLOJOIOCK, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONLCFHFCCIA().PBOKDNDMCDL, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONLCFHFCCIA().GHALDHOOFKN);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.removeAvatarComponent:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().BOPJOMGIJIA == GBGJNJIPNNL.BMHGEBOHLHH.start)
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().PLPCLJFJFNG.Length > 0)
								{
									this.HLPMCCEDBLF(KFIHMMIGPLO.clothes, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().PLPCLJFJFNG));
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().JHHKEPGLHKD.Length > 0)
								{
									this.HLPMCCEDBLF(KFIHMMIGPLO.body, this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().JHHKEPGLHKD);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().KGOAGNFNFIJ.Length > 0)
								{
									this.HLPMCCEDBLF(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().KGOAGNFNFIJ);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().OMGLOJOIOCK.Length > 0)
								{
									this.HLPMCCEDBLF(KFIHMMIGPLO.hair, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().OMGLOJOIOCK));
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().PBOKDNDMCDL.Length > 0)
								{
									this.HLPMCCEDBLF(KFIHMMIGPLO.trinket, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().PBOKDNDMCDL));
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().GHALDHOOFKN.Length > 0)
								{
									this.HLPMCCEDBLF(KFIHMMIGPLO.overlay, this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).NPBJGANFHIN().GHALDHOOFKN));
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.addAvatarComponent:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().BOPJOMGIJIA == FOJAGMPBLGJ.BMHGEBOHLHH.start)
							{
								try
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PLPCLJFJFNG.Count > 0)
									{
										for (int num33 = 0; num33 < this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PLPCLJFJFNG.Count; num33++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PLPCLJFJFNG[num33] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PLPCLJFJFNG[num33].Length > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.clothes, this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PLPCLJFJFNG[num33], "", false);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().JHHKEPGLHKD.Count > 0)
									{
										for (int num34 = 0; num34 < this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().JHHKEPGLHKD.Count; num34++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().JHHKEPGLHKD[num34] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().JHHKEPGLHKD[num34].Length > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.body, this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().JHHKEPGLHKD[num34], "", false);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().KGOAGNFNFIJ.Count > 0)
									{
										for (int num35 = 0; num35 < this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().KGOAGNFNFIJ.Count; num35++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().KGOAGNFNFIJ[num35] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().KGOAGNFNFIJ[num35].Length > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.face, this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().KGOAGNFNFIJ[num35], "", false);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().OMGLOJOIOCK.Count > 0)
									{
										for (int num36 = 0; num36 < this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().OMGLOJOIOCK.Count; num36++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().OMGLOJOIOCK[num36] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().OMGLOJOIOCK[num36].Length > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.hair, this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().OMGLOJOIOCK[num36], "", false);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PBOKDNDMCDL.Count > 0)
									{
										for (int num37 = 0; num37 < this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PBOKDNDMCDL.Count; num37++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PBOKDNDMCDL[num37] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PBOKDNDMCDL[num37].Length > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.trinket, this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().PBOKDNDMCDL[num37], "", false);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().GHALDHOOFKN.Count > 0)
									{
										for (int num38 = 0; num38 < this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().GHALDHOOFKN.Count; num38++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().GHALDHOOFKN[num38] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().GHALDHOOFKN[num38].Length > 0)
											{
												this.NGGHOOIELJP(KFIHMMIGPLO.overlay, this.HFOPCMIHDOL.ONECLDMJKEE(i).DNCIHBMLLHH().GHALDHOOFKN[num38], "", false);
											}
										}
									}
								}
								catch (Exception aklgbjkdomm14)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm14);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.exportVars:
						{
							KAKODAHAJKD.BMHGEBOHLHH bopjomgijia3 = this.HFOPCMIHDOL.ONECLDMJKEE(i).FFFGKEIGMGE().BOPJOMGIJIA;
							if (bopjomgijia3 != KAKODAHAJKD.BMHGEBOHLHH.start)
							{
								if (bopjomgijia3 == KAKODAHAJKD.BMHGEBOHLHH.export)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KDDFKPDLEJO();
									for (int num39 = 0; num39 < this.HFOPCMIHDOL.ONECLDMJKEE(i).FFFGKEIGMGE().CHKCLEEFHHI.Count; num39++)
									{
										string text4 = this.HFOPCMIHDOL.ONECLDMJKEE(i).FFFGKEIGMGE().CHKCLEEFHHI[num39];
										string text5 = "_" + this.HFOPCMIHDOL.ONECLDMJKEE(i).FFFGKEIGMGE().NJPHDOPOFHD[num39];
										if (ONEHEBIHPFB.POLPJMIBJNN(text4))
										{
											if (text5.ToLower().Equals(LFOLOKPIPHB._bool.ToString()))
											{
												if (ONEHEBIHPFB.IOLOGAHIJMI(text4))
												{
													AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBPNNGHNDKK(text4 + text5, "1");
												}
												else
												{
													AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBPNNGHNDKK(text4 + text5, "0");
												}
											}
											else if (text5.ToLower().Equals(LFOLOKPIPHB._int.ToString()))
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBPNNGHNDKK(text4 + text5, ONEHEBIHPFB.HPFKIKJIGNF(text4).ToString());
											}
											else if (text5.ToLower().Equals(LFOLOKPIPHB._string.ToString()))
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBPNNGHNDKK(text4 + text5, ONEHEBIHPFB.NNOFJONAKKH(text4));
											}
											else if (text5.ToLower().Equals(LFOLOKPIPHB._list.ToString()))
											{
												InkList inkList = ONEHEBIHPFB.MCGKCBGBGKA(text4);
												if (inkList != null)
												{
													AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBPNNGHNDKK(text4 + text5, inkList.ToString());
												}
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("Error. Unknown export variable type:" + text5);
											}
										}
										else
										{
											DPGJIJGOCIC.ANOPFDLPKGC("Warning. Export variable not found in ink file:" + text4);
										}
									}
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
							}
							else
							{
								this.APDAMLCHICH();
								this.DNGIDKHONMB();
								this.HGLBOPHFCPH();
								StarRatingSelector.RememberLastRating(false);
								base.StartCoroutine(this.EJAAMGDGIEB());
							}
							break;
						}
						case KGLBKJKNPFD.LBFFMOMMAPK.importVars:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OOPDAHMOLCK().BOPJOMGIJIA == AIEIBBHCAMH.BMHGEBOHLHH.start)
							{
								if (this.NJAAOCMPKCD.prequelsIndices != null && this.NJAAOCMPKCD.prequelsIndices.Count > 0)
								{
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0] <= 0)
									{
										for (int num40 = 0; num40 < this.NJAAOCMPKCD.prequelsIndices.Count; num40++)
										{
											if (this.NJAAOCMPKCD.prequelsIndices[num40] >= 0)
											{
												PLFDAJJHMKO aeibifjbkfp = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.prequelsIndices[num40], -1);
												this.IFKIKHPKFLC(aeibifjbkfp, this.HFOPCMIHDOL.ONECLDMJKEE(i).OOPDAHMOLCK().CHKCLEEFHHI);
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("Error. Trying to use $IMPORTVARS without declaring a prequel story index.");
											}
										}
									}
									else
									{
										PLFDAJJHMKO aeibifjbkfp = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
										this.IFKIKHPKFLC(aeibifjbkfp, this.HFOPCMIHDOL.ONECLDMJKEE(i).OOPDAHMOLCK().CHKCLEEFHHI);
									}
								}
								else
								{
									PLFDAJJHMKO aeibifjbkfp2;
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0] <= 0)
									{
										if (this.NJAAOCMPKCD.prequelIndex < 0)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("Error. Trying to use $IMPORTVARS without declaring a prequel story index.");
											this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
											break;
										}
										aeibifjbkfp2 = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.prequelIndex, -1);
									}
									else
									{
										aeibifjbkfp2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
									}
									this.IFKIKHPKFLC(aeibifjbkfp2, this.HFOPCMIHDOL.ONECLDMJKEE(i).OOPDAHMOLCK().CHKCLEEFHHI);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.getVar:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().BOPJOMGIJIA == ELFBAKJMBOA.BMHGEBOHLHH.start)
							{
								try
								{
									BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().AMKCLHLIIMN >= 0)
									{
										AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().AMKCLHLIIMN);
										if (null != assetAnthology)
										{
											EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(assetAnthology.header.index);
											if (eioplefllim != null && eioplefllim.EGHHCFFLPCP(-1) >= 0)
											{
												int num41 = eioplefllim.EGHHCFFLPCP(-1);
												if (num41 > assetAnthology.header.availableStories.Count - 1)
												{
													num41 = assetAnthology.header.availableStories.Count - 1;
												}
												PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num41], -1);
												if (plfdajjhmko == null && num41 > 0)
												{
													num41--;
													plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num41], -1);
												}
												if (plfdajjhmko != null)
												{
													ncamfpgmcig = plfdajjhmko.NCAMFPGMCIG;
												}
											}
										}
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().IFCHGNCDMLJ >= 0 && AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().IFCHGNCDMLJ, -1) != null)
									{
										ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().IFCHGNCDMLJ, -1).NCAMFPGMCIG;
									}
									if (ncamfpgmcig == null)
									{
										ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.CLOTHES"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().OHCMCJHDMOH[2]);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.TRINKET"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().OHCMCJHDMOH[4]);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.HAIR"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().OHCMCJHDMOH[1]);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.FACE"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().OHCMCJHDMOH[3]);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.BODY"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().OHCMCJHDMOH[0]);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.OVERLAY"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().OHCMCJHDMOH[5]);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.BEHAVIOR.CHOICEDECISIONTIME"))
									{
										int kidhbamjgdo = (int)SceneStoryManager.choiceDecisionTime;
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, kidhbamjgdo);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.AVATAR.INDEX"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, ncamfpgmcig.OHODCBKFNGJ().GGICIBLJIKI);
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.LANGUAGE"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString());
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.GEO"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, GeoLocationManager.GetCountryCode());
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.VERSION"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, AppManager.EHBBFMCILPC.GetRevision());
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.TIME.SEASON"))
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, SceneStoryManager.AKLCNEOHFFB.AJODGEBFJPJ(DateTime.Today).ToString());
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA.Equals("CLIENT.FEATURESET.VIDEOSUPPORT"))
									{
										if (KHPGPLAMAIN.DFJHJCAIFJO())
										{
											ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, 1);
										}
										else
										{
											ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, 0);
										}
									}
									else
									{
										string lolcbckjoda = this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA;
										string text6 = ncamfpgmcig.MPMJOPGMNPB(ref lolcbckjoda);
										if (text6 != null && text6.Length > 0)
										{
											if (lolcbckjoda.ToLower().EndsWith(LFOLOKPIPHB._bool.ToString()))
											{
												if (text6.Equals("1"))
												{
													ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, true);
												}
												else
												{
													ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, false);
												}
											}
											else if (lolcbckjoda.ToLower().EndsWith(LFOLOKPIPHB._int.ToString()))
											{
												ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, Convert.ToInt32(text6));
											}
											else if (lolcbckjoda.ToLower().EndsWith(LFOLOKPIPHB._string.ToString()))
											{
												ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, text6);
											}
											else if (lolcbckjoda.ToLower().EndsWith(LFOLOKPIPHB._list.ToString()))
											{
												ONEHEBIHPFB.HFEEFOJDNPL(this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().EHELHLOCOGG, text6);
											}
											else
											{
												DPGJIJGOCIC.ANOPFDLPKGC("Error. StoryStep.StoryStepType.getVar unknown variable type:" + lolcbckjoda);
											}
										}
										else
										{
											DPGJIJGOCIC.ANOPFDLPKGC("Error. StoryStep.StoryStepType.getVar " + this.HFOPCMIHDOL.ONECLDMJKEE(i).JOPNKEACPIG().LOLCBCKJODA + " not found in story save body with index " + ncamfpgmcig.GGICIBLJIKI.ToString());
										}
									}
								}
								catch (Exception aklgbjkdomm15)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm15);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.hasAvatarComponent:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().BOPJOMGIJIA == IGCNHEDDNGD.BMHGEBOHLHH.start)
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().LOLCBCKJODA.Length > 0)
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().EHELHLOCOGG, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().LOLCBCKJODA));
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().KAGAHEIHFBP.Count > 0)
								{
									bool flag7 = false;
									for (int num42 = 0; num42 < this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().KAGAHEIHFBP.Count; num42++)
									{
										if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().KAGAHEIHFBP[num42]))
										{
											flag7 = true;
											break;
										}
									}
									if (flag7)
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().EHELHLOCOGG, true);
									}
									else
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().EHELHLOCOGG, false);
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().JFPBFKIADPK.Count > 0)
								{
									bool flag8 = true;
									for (int num43 = 0; num43 < this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().JFPBFKIADPK.Count; num43++)
									{
										if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIJAJALPEDL(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().JFPBFKIADPK[num43]))
										{
											flag8 = false;
											break;
										}
									}
									if (flag8)
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().EHELHLOCOGG, true);
									}
									else
									{
										ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).COCGPABOIKN().EHELHLOCOGG, false);
									}
								}
								else
								{
									DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager.StoryStep.StoryStepType.hasAvatarComponent, neither get() nor getany() nor getall() defined, but at least one of them is required.");
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.choiceExecuted:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OBOKBHPDBMB().BOPJOMGIJIA == BFNCOLBCJCP.BMHGEBOHLHH.start)
							{
								ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).OBOKBHPDBMB().EHELHLOCOGG, SceneStoryManager.PremiumChoicePurchasedReal(this.HFOPCMIHDOL.ONECLDMJKEE(i).OBOKBHPDBMB().JCJNJNMPPOK));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.addMappingInfo:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BILBAFMAJFM().BOPJOMGIJIA == AAGADILJKBJ.BMHGEBOHLHH.start)
							{
								string text7 = this.HFOPCMIHDOL.ONECLDMJKEE(i).BILBAFMAJFM().NEOFEIFAGLF;
								if (text7.Equals("CLIENT.AVATAR.CLOTHES"))
								{
									text7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[2];
								}
								else if (text7.Equals("CLIENT.AVATAR.TRINKET"))
								{
									text7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[4];
								}
								else if (text7.Equals("CLIENT.AVATAR.OVERLAY"))
								{
									text7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[5];
								}
								else if (text7.Equals("CLIENT.AVATAR.HAIR"))
								{
									text7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1];
								}
								else if (text7.Equals("CLIENT.AVATAR.FACE"))
								{
									text7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[3];
								}
								else if (text7.Equals("CLIENT.AVATAR.FACE.ALIAS"))
								{
									AssetAvatarComponent assetAvatarComponent6 = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[3], null);
									if (null != assetAvatarComponent6)
									{
										text7 = assetAvatarComponent6.alias;
									}
								}
								else if (text7.Equals("CLIENT.AVATAR.BODY"))
								{
									text7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
								}
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLCOPCMBIAH(this.HFOPCMIHDOL.ONECLDMJKEE(i).BILBAFMAJFM().PNAKACGNLGL, text7, this.HFOPCMIHDOL.ONECLDMJKEE(i).BILBAFMAJFM().HKFCEIJMLCI);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.removeMappingInfo:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OEHIBLJDBBA().BOPJOMGIJIA == OALNAEIPOII.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LGAEPNNJLHI(this.HFOPCMIHDOL.ONECLDMJKEE(i).OEHIBLJDBBA().PNAKACGNLGL);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.strContains:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().BOPJOMGIJIA == IIOLDNNPIFP.BMHGEBOHLHH.start)
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().LOLCBCKJODA.Length > 0 && this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().EHELHLOCOGG.Length > 0 && this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().FNNJMLFAHJD().Length > 0)
								{
									string text8 = ONEHEBIHPFB.NNOFJONAKKH(this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().LOLCBCKJODA);
									if (text8 != null && text8.Length > 0)
									{
										if (text8.ToLower().Contains(this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().FNNJMLFAHJD().ToLower()))
										{
											ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().EHELHLOCOGG, true);
										}
										else
										{
											ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).MHDMBHLMAEK().EHELHLOCOGG, false);
										}
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.getRandomInt:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OIMDJODBEMO().BOPJOMGIJIA == NDBPNOABBCL.BMHGEBOHLHH.start)
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OIMDJODBEMO().EHELHLOCOGG.Length > 0)
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).OIMDJODBEMO().EHELHLOCOGG, DPGJIJGOCIC.IOOHGEJIPFP(this.HFOPCMIHDOL.ONECLDMJKEE(i).OIMDJODBEMO().IMOFIGHOIFM, this.HFOPCMIHDOL.ONECLDMJKEE(i).OIMDJODBEMO().DNHFLKKAHHH + 1));
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setPov:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PPLBIKBPAKG().BOPJOMGIJIA == FPHIPLMOLID.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PPLBIKBPAKG().IHCMBIBJBJD.Equals("player"))
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI = "";
									if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC == 0)
									{
										this.BPKMDANBJKG(false);
									}
								}
								else
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI = this.HFOPCMIHDOL.ONECLDMJKEE(i).PPLBIKBPAKG().IHCMBIBJBJD;
									this.BPKMDANBJKG(true);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.4f * this.PGLKLNNMKMO * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setAvatar:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().BOPJOMGIJIA == CKJNHELNAFB.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().PFCEGDBAGHC)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BICJPDDANIF(1);
									AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().JLJAFHFHDFD(1, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
									AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().LBDCGMKCGHB(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
								}
								else if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ALIGDEHMGOP() == 1 || AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().NHFBKIIMBOC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME) == 1)
								{
									DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager.StoryStep.StoryStepType.setAvatar, using SETAVATAR is not allowed once autosuffix() had been enabled, use TAKE/RESTORE avatar snapshot");
								}
								else
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BICJPDDANIF(0);
									AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().JLJAFHFHDFD(0, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().GNNDOOOJHCK && !this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().PFCEGDBAGHC && !this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().ICOCHNCELHL)
								{
									AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().LBDCGMKCGHB(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().ICOCHNCELHL)
								{
									DOLBFGIPPOG cciagbpilgf = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ();
									DOLBFGIPPOG dolbfgippog2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OELDOMFJLOP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME == 0)
									{
										dolbfgippog2.DFGBIMKKNAH(cciagbpilgf, "");
									}
									else
									{
										dolbfgippog2.DFGBIMKKNAH(cciagbpilgf, "+" + this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME.ToString());
									}
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEEPFAEGGJF(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
									for (int num44 = 0; num44 < 6; num44++)
									{
										this.NGGHOOIELJP((KFIHMMIGPLO)num44, dolbfgippog2.OHCMCJHDMOH[num44], "", true);
									}
									try
									{
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME == 0)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JFAJNMHGMAI("");
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().FECDHEKJDDF("", AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JFAJNMHGMAI("+" + this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME.ToString());
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().FECDHEKJDDF("+" + this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME.ToString(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
										}
										goto IL_11058;
									}
									catch (Exception aklgbjkdomm16)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm16);
										goto IL_11058;
									}
									goto IL_10D53;
								}
								goto IL_10D53;
								IL_11058:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.4f * this.PGLKLNNMKMO * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), 1);
								break;
								IL_10D53:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().LFEPCGFNMFJ || this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NCAMFPGMCIG || this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().KEANPACAICH || this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().FCHPMLBDPKJ || this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().GOJKOJGKMHI || this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().EBCKBKHBNKH)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIKBGHPHBLF(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJCPKGCLEPD(), this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().LFEPCGFNMFJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NCAMFPGMCIG, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().KEANPACAICH, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().FCHPMLBDPKJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().GOJKOJGKMHI, this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().EBCKBKHBNKH);
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().AIDFMFOBLNC)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BJNIPBIDAIC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJCPKGCLEPD(), this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
									}
									DOLBFGIPPOG dolbfgippog3 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OELDOMFJLOP(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEEPFAEGGJF(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
									for (int num45 = 0; num45 < 6; num45++)
									{
										this.NGGHOOIELJP((KFIHMMIGPLO)num45, dolbfgippog3.OHCMCJHDMOH[num45], "", true);
									}
									goto IL_11058;
								}
								DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().AIDFMFOBLNC)
								{
									dolbfgippog4 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BJNIPBIDAIC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJCPKGCLEPD(), this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
								}
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEEPFAEGGJF(this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().NFDKDACMHME);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JCFBPNFKFBA().AIDFMFOBLNC)
								{
									this.NGGHOOIELJP(KFIHMMIGPLO.body, dolbfgippog4.OHCMCJHDMOH[0], "", true);
									this.NGGHOOIELJP(KFIHMMIGPLO.face, dolbfgippog4.OHCMCJHDMOH[3], "", true);
									goto IL_11058;
								}
								goto IL_11058;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.incStat:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().BOPJOMGIJIA)
							{
							case FKEMPHIFKNI.BMHGEBOHLHH.show:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.01f, 1);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().IHMKJMPEPHK != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().IHMKJMPEPHK.Length > 0)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NHJCPGBHOFC(this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().JONCLHNEMIO, ONEHEBIHPFB.HPFKIKJIGNF(this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().IHMKJMPEPHK), this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().HNIFEKBNNDB);
								}
								else
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NHJCPGBHOFC(this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().JONCLHNEMIO, this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().AJLPALFJHCC, this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().HNIFEKBNNDB);
								}
								break;
							case FKEMPHIFKNI.BMHGEBOHLHH.instantiateDelay:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f + 1.5f * (float)this.AGKKCOENLOJ.Count + 2f * (float)this.JGCFEBDMBMC.Count, 1);
								this.AGKKCOENLOJ.Add(1);
								break;
							case FKEMPHIFKNI.BMHGEBOHLHH.instantiate:
							{
								try
								{
									for (int num46 = 0; num46 < this.BBNLMENIFNJ.Count; num46++)
									{
										if (this.BBNLMENIFNJ[num46] != null && null != this.BBNLMENIFNJ[num46].IACFDHCDEME && !this.BBNLMENIFNJ[num46].IACFDHCDEME.GetComponent<StatPointManager>().IsDisappearing())
										{
											this.BBNLMENIFNJ[num46].IACFDHCDEME.GetComponent<StatPointManager>().DisappearAnimationLong();
										}
									}
								}
								catch (Exception aklgbjkdomm17)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm17);
								}
								try
								{
									for (int num47 = 0; num47 < this.PBPHFLJDNBH.Count; num47++)
									{
										if (this.PBPHFLJDNBH[num47] != null && null != this.PBPHFLJDNBH[num47].IACFDHCDEME && !this.PBPHFLJDNBH[num47].IACFDHCDEME.GetComponent<StoryNoteManager>().IsDisappearing())
										{
											this.PBPHFLJDNBH[num47].IACFDHCDEME.GetComponent<StoryNoteManager>().DisappearAnimationLong();
										}
									}
								}
								catch (Exception aklgbjkdomm18)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm18);
								}
								if (!AudioManager.EHBBFMCILPC.PlaySfx("sfxstatreceived", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxstatreceived" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
								{
									AudioManager.EHBBFMCILPC.PlaySfx("statreceived", false);
								}
								GameObject gameObject9;
								switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().JONCLHNEMIO)
								{
								case CHEEGEJNIDB.stat0:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat0Prefab);
									break;
								case CHEEGEJNIDB.stat1:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat1Prefab);
									break;
								case CHEEGEJNIDB.stat2:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat2Prefab);
									break;
								case CHEEGEJNIDB.stat3:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat3Prefab);
									break;
								case CHEEGEJNIDB.stat4:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat4Prefab);
									break;
								case CHEEGEJNIDB.stat5:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat5Prefab);
									break;
								case CHEEGEJNIDB.stat6:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat6Prefab);
									break;
								default:
									gameObject9 = UnityEngine.Object.Instantiate<GameObject>(this.stat0Prefab);
									break;
								}
								gameObject9.transform.SetParent(this.statsPivot.transform, false);
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().IHMKJMPEPHK != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().IHMKJMPEPHK.Length > 0)
								{
									gameObject9.GetComponent<StatPointManager>().Initialize(this.HFFIIBBJBMH.header.index, this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().JONCLHNEMIO, ONEHEBIHPFB.HPFKIKJIGNF(this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().IHMKJMPEPHK));
								}
								else
								{
									gameObject9.GetComponent<StatPointManager>().Initialize(this.HFFIIBBJBMH.header.index, this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().JONCLHNEMIO, this.HFOPCMIHDOL.ONECLDMJKEE(i).FMNEHCODJJM().AJLPALFJHCC);
								}
								this.BBNLMENIFNJ.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject9));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							case FKEMPHIFKNI.BMHGEBOHLHH.delayBeforeHide:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(StatPointManager.GetAnimationLength(), 1);
								break;
							case FKEMPHIFKNI.BMHGEBOHLHH.hide:
								for (int num48 = 0; num48 < this.BBNLMENIFNJ.Count; num48++)
								{
									if (this.BBNLMENIFNJ[num48].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.BBNLMENIFNJ[num48].IACFDHCDEME);
										this.BBNLMENIFNJ.RemoveAt(num48);
										break;
									}
								}
								if (this.AGKKCOENLOJ.Count > 0)
								{
									this.AGKKCOENLOJ.RemoveAt(0);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.giveItem:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).CINFODGCOFO().BOPJOMGIJIA)
							{
							case DNFBGCGNLKA.BMHGEBOHLHH.show:
							{
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.HGLBOPHFCPH();
								this.HJKLOODDLDE(100);
								GameObject gameObject10 = UnityEngine.Object.Instantiate<GameObject>(this.dialogItemFoundPrefab);
								gameObject10.transform.SetParent(this.itemFoundDialogPivot.transform, false);
								gameObject10.GetComponent<DialogItemFoundManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).CINFODGCOFO(), this.HFFIIBBJBMH.header.CKACBBGHJGI());
								this.IJMGENDHKMP.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject10));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							}
							case DNFBGCGNLKA.BMHGEBOHLHH.showNote:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case DNFBGCGNLKA.BMHGEBOHLHH.executeItemCollected:
								if (!AudioManager.EHBBFMCILPC.PlaySfx("sfxitemreceived", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxitemreceived" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
								{
									AudioManager.EHBBFMCILPC.PlaySfx("itemreceived", false);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case DNFBGCGNLKA.BMHGEBOHLHH.hide:
								for (int num49 = 0; num49 < this.IJMGENDHKMP.Count; num49++)
								{
									if (this.IJMGENDHKMP[num49].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.IJMGENDHKMP[num49].IACFDHCDEME);
										this.IJMGENDHKMP.RemoveAt(num49);
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useItem:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).DGBDMJFAPMD().BOPJOMGIJIA)
							{
							case GANPAGHHNOD.BMHGEBOHLHH.show:
							{
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.HGLBOPHFCPH();
								this.HJKLOODDLDE(100);
								GameObject gameObject11 = UnityEngine.Object.Instantiate<GameObject>(this.dialogItemUsedPrefab);
								gameObject11.transform.SetParent(this.itemFoundDialogPivot.transform, false);
								gameObject11.GetComponent<DialogItemUsedManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).DGBDMJFAPMD(), this.HFFIIBBJBMH.header.CKACBBGHJGI());
								this.IJMGENDHKMP.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject11));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							}
							case GANPAGHHNOD.BMHGEBOHLHH.executeItemUsed:
								if (!AudioManager.EHBBFMCILPC.PlaySfx("sfxitemused", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxitemused" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
								{
									AudioManager.EHBBFMCILPC.PlaySfx("itemused", false);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case GANPAGHHNOD.BMHGEBOHLHH.hide:
								for (int num50 = 0; num50 < this.IJMGENDHKMP.Count; num50++)
								{
									if (this.IJMGENDHKMP[num50].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.IJMGENDHKMP[num50].IACFDHCDEME);
										this.IJMGENDHKMP.RemoveAt(num50);
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.showItem:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).HDLGLJBHCPJ().BOPJOMGIJIA)
							{
							case IPJEBHDFOKM.BMHGEBOHLHH.show:
							{
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.HGLBOPHFCPH();
								this.HJKLOODDLDE(100);
								GameObject gameObject12;
								if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).HDLGLJBHCPJ().JHOBDDLPIBD)
								{
									gameObject12 = UnityEngine.Object.Instantiate<GameObject>(this.dialogItemShownPrefab);
									gameObject12.transform.SetParent(this.itemFoundDialogPivot.transform, false);
									gameObject12.GetComponent<DialogItemShownManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).HDLGLJBHCPJ(), this.HFFIIBBJBMH.header.CKACBBGHJGI());
								}
								else
								{
									gameObject12 = UnityEngine.Object.Instantiate<GameObject>(this.dialogItemShownFullscreenPrefab);
									gameObject12.transform.SetParent(this.itemFoundDialogPivot.transform, false);
									gameObject12.GetComponent<DialogItemShownFullscreenManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).HDLGLJBHCPJ(), this.HFFIIBBJBMH.header.CKACBBGHJGI());
								}
								this.IJMGENDHKMP.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject12));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							}
							case IPJEBHDFOKM.BMHGEBOHLHH.executeItemShown:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case IPJEBHDFOKM.BMHGEBOHLHH.hide:
								for (int num51 = 0; num51 < this.IJMGENDHKMP.Count; num51++)
								{
									if (this.IJMGENDHKMP[num51].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.IJMGENDHKMP[num51].IACFDHCDEME);
										this.IJMGENDHKMP.RemoveAt(num51);
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.avatarLock:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CIGNLOJJBIM().BOPJOMGIJIA == NLOBMNMNKOG.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC = 1;
								this.BPKMDANBJKG(true);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.avatarUnlock:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KABEBDBPGAK().BOPJOMGIJIA == PNLLLEKHFHO.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC = 0;
								this.BPKMDANBJKG(false);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.avatarSetup:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LFKJLOOLLEK().BOPJOMGIJIA == INPPHKFPFLO.BMHGEBOHLHH.start)
							{
								this.APDAMLCHICH();
								this.JOKJBAIECCA(false);
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.HGLBOPHFCPH();
								this.OnAvatarClick();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcPropEnable:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IAFCBDBCFPG().BOPJOMGIJIA == IGBLCIEDOBE.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JMJKIMJKPOE(this.HFOPCMIHDOL.ONECLDMJKEE(i).IAFCBDBCFPG().OLPMONKMBPO);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcPropDisable:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CBOHEJEILFO().BOPJOMGIJIA == IGMOFFJDEAK.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NGBODKEHKHJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).CBOHEJEILFO().OLPMONKMBPO);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcPropIgnore:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BGHJBKHAPFA().BOPJOMGIJIA == POBNOGHGLMK.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LMFJGLCBACL(this.HFOPCMIHDOL.ONECLDMJKEE(i).BGHJBKHAPFA().OLPMONKMBPO);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcPropIgnoreClear:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).POLCNBMNLGB().BOPJOMGIJIA == OCBGFGNOHPF.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.EGCCPENLDDO();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcHideDialog:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHMNDDBNMEE().BOPJOMGIJIA == OLHOPDNIDLB.BMHGEBOHLHH.start)
							{
								if (this.PKPMIABFBON.Count > 0)
								{
									this.PKPMIABFBON[this.PKPMIABFBON.Count - 1].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().DestroyDialogs();
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(DialogNonPlayerCharacterManager.GetDisappearAnimationLength() + this.HFOPCMIHDOL.ONECLDMJKEE(i).GHMNDDBNMEE().EBMMGNEEBIC, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcFadeOut:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).LFDPLJJFHGL().BOPJOMGIJIA)
							{
							case MDNBCCCEJBF.BMHGEBOHLHH.start:
								if (this.PKPMIABFBON.Count > 0)
								{
									this.PKPMIABFBON[this.PKPMIABFBON.Count - 1].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().FadeOut(this.HFOPCMIHDOL.ONECLDMJKEE(i).LFDPLJJFHGL().PMMCLCMDNGA);
									FGINKFGNNEK fginkfgnnek7 = this.LBCMMKJBNFH(this.PKPMIABFBON[this.PKPMIABFBON.Count - 1].DBHMNECMIAB);
									if (fginkfgnnek7 != null && null != fginkfgnnek7.IACFDHCDEME)
									{
										fginkfgnnek7.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().FadeOut(this.HFOPCMIHDOL.ONECLDMJKEE(i).LFDPLJJFHGL().PMMCLCMDNGA);
									}
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).LFDPLJJFHGL().PMMCLCMDNGA, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								break;
							case MDNBCCCEJBF.BMHGEBOHLHH.fadeOutDone:
								if (this.PKPMIABFBON.Count > 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).LFDPLJJFHGL().EBMMGNEEBIC, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								break;
							case MDNBCCCEJBF.BMHGEBOHLHH.delayBeforeDone:
								this.HGLBOPHFCPH();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.npcFadeIn:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EOPLAMEPHJO().BOPJOMGIJIA == EDKPLPNPCEG.BMHGEBOHLHH.start)
							{
								NonPlayerCharacterManager.SetCustomFadeInTime(this.HFOPCMIHDOL.ONECLDMJKEE(i).EOPLAMEPHJO().PMMCLCMDNGA);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.takeAvatarSnapshot:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().BOPJOMGIJIA == KIMAEDGOGEF.BMHGEBOHLHH.start)
							{
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOLCAAOOOCN() >= 2)
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().NFDKDACMHME < 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FJBBDEAALCC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().LFEPCGFNMFJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().NCAMFPGMCIG, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().KEANPACAICH, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().FCHPMLBDPKJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().GOJKOJGKMHI, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().EBCKBKHBNKH);
									}
									else
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.EIJHNPONAOG(this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().FPHDAKHOBMO, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().NFDKDACMHME, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().LFEPCGFNMFJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().NCAMFPGMCIG, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().KEANPACAICH, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().FCHPMLBDPKJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().GOJKOJGKMHI, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().EBCKBKHBNKH);
									}
								}
								else
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FJBBDEAALCC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().LFEPCGFNMFJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().NCAMFPGMCIG, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().KEANPACAICH, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().FCHPMLBDPKJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().GOJKOJGKMHI, this.HFOPCMIHDOL.ONECLDMJKEE(i).ANGIOECMNND().EBCKBKHBNKH);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.restoreAvatarSnapshot:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CHAJNNIKKFJ().BOPJOMGIJIA == INKADLHKELF.BMHGEBOHLHH.start)
							{
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOLCAAOOOCN() >= 2)
								{
									this.HGLBOPHFCPH();
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CHAJNNIKKFJ().NFDKDACMHME < 0)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBHPMDFLOIN();
									}
									else
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHNIPNLLIMJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).CHAJNNIKKFJ().NFDKDACMHME);
									}
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								}
								else
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBHPMDFLOIN();
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.takeAndRestoreAvatarSnapshot:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().BOPJOMGIJIA == MFJOEANDAPH.BMHGEBOHLHH.start)
							{
								DOLBFGIPPOG enamjpnbnmk = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBLOENEECHF();
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FJBBDEAALCC(this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().LFEPCGFNMFJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().NCAMFPGMCIG, this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().KEANPACAICH, this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().FCHPMLBDPKJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().GOJKOJGKMHI, this.HFOPCMIHDOL.ONECLDMJKEE(i).IKHEMAFKDEG().EBCKBKHBNKH);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MBIPLFLHJFP(enamjpnbnmk);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.takeEnvSnapshot:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KFDLECBCAGH().BOPJOMGIJIA == DIFKIAHHPJP.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ELAONABCDMI();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.restoreEnvSnapshot:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OOOJHLDHBKD().BOPJOMGIJIA == MMCOALBJOGE.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.EIOINHAMCDG();
								this.HAEPBGACFDC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.onDemandResoucesCheckpointHit:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).BPHJKELOKKA().BOPJOMGIJIA)
							{
							case KGLMPKPMPDN.BMHGEBOHLHH.start:
								this.APDAMLCHICH();
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								if (NBDLBFJOEGN.LCNGCDFHFOM(this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH]))
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 4);
								}
								break;
							case KGLMPKPMPDN.BMHGEBOHLHH.destroyAssets:
							{
								List<AssetStoryNpc> list2 = new List<AssetStoryNpc>();
								for (int num52 = 0; num52 < this.ODNCKIKLFCM.Count; num52++)
								{
									if (this.ODNCKIKLFCM[num52].KBDAEIHELPE() < 0)
									{
										list2.Add(this.ODNCKIKLFCM[num52]);
									}
									else
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Npc id has been destroyed according to on demand data:" + this.ODNCKIKLFCM[num52].id);
									}
								}
								this.ODNCKIKLFCM.Clear();
								this.ODNCKIKLFCM = list2;
								List<StoryEnvironmentManager> list3 = new List<StoryEnvironmentManager>();
								for (int num53 = 0; num53 < this.CHHIBBOICAD.Count; num53++)
								{
									if (this.CHHIBBOICAD[num53].GetOnDemandResourcesCheckpointIndex() < 0)
									{
										list3.Add(this.CHHIBBOICAD[num53]);
									}
									else
									{
										this.CHHIBBOICAD[num53].gameObject.transform.SetParent(null);
										UnityEngine.Object.Destroy(this.CHHIBBOICAD[num53].gameObject);
										DPGJIJGOCIC.ADFCDFHBDAF("Back environment has been destroyed according to on demand data:" + this.CHHIBBOICAD[num53].name);
									}
								}
								this.CHHIBBOICAD.Clear();
								this.CHHIBBOICAD = list3;
								List<StoryEnvironmentManager> list4 = new List<StoryEnvironmentManager>();
								for (int num54 = 0; num54 < this.KEPHFKAHILM.Count; num54++)
								{
									if (this.KEPHFKAHILM[num54].GetOnDemandResourcesCheckpointIndex() < 0)
									{
										list4.Add(this.KEPHFKAHILM[num54]);
									}
									else
									{
										this.KEPHFKAHILM[num54].gameObject.transform.SetParent(null);
										UnityEngine.Object.Destroy(this.KEPHFKAHILM[num54].gameObject);
										DPGJIJGOCIC.ADFCDFHBDAF("Front environment has been destroyed according to on demand data:" + this.KEPHFKAHILM[num54].name);
									}
								}
								this.KEPHFKAHILM.Clear();
								this.KEPHFKAHILM = list4;
								List<StoryEnvironmentLayerManager> list5 = new List<StoryEnvironmentLayerManager>();
								for (int num55 = 0; num55 < this.FAEEEHDCNDN.Count; num55++)
								{
									if (this.FAEEEHDCNDN[num55].GetOnDemandResourcesCheckpointIndex() < 0)
									{
										list5.Add(this.FAEEEHDCNDN[num55]);
									}
									else
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Environment layer has been destroyed according to on demand data:" + this.FAEEEHDCNDN[num55].name);
									}
								}
								this.FAEEEHDCNDN.Clear();
								this.FAEEEHDCNDN = list5;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							}
							case KGLMPKPMPDN.BMHGEBOHLHH.cleanMemory:
								GC.Collect();
								Resources.UnloadUnusedAssets();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case KGLMPKPMPDN.BMHGEBOHLHH.downloadAssets:
								if (this.OILFDHGPCOB() == 0)
								{
									GC.Collect();
									Resources.UnloadUnusedAssets();
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								}
								break;
							case KGLMPKPMPDN.BMHGEBOHLHH.saveCheckpoint:
								this.LFFONLGJFBH();
								this.GKHNIMJJLJL.DHONIOBOLEL.AOPIMPMDEHO = this.HFOPCMIHDOL.ONECLDMJKEE(i).BPHJKELOKKA().GGICIBLJIKI;
								CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
								this.BFOEOHEAPEK(false);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useLayersV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GGGPGLDHLOO().BOPJOMGIJIA == FGECAAAJCFB.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OBEJOFPPDIA(2);
								StoryEnvironmentLayerManager.SetLayersSystemVersion(this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM());
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useLayersV3:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NOPHCLGGDDP().BOPJOMGIJIA == IOCAAABPDJH.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OBEJOFPPDIA(3);
								StoryEnvironmentLayerManager.SetLayersSystemVersion(this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM());
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useDelayV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).DGIOLLAGPFB().BOPJOMGIJIA == JMPCBLPMAGG.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DIBCMHBFDPH(2);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useMappingV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NNGJNILLBBJ().BOPJOMGIJIA == COIACILKKDE.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LMPHEMAIPDI(2);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.syncAvatar:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().BOPJOMGIJIA == OKKMLKPFGCF.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIKBGHPHBLF(this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().PNAKACGNLGL, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().NEOFEIFAGLF, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().LFEPCGFNMFJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().NCAMFPGMCIG, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().KEANPACAICH, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().FCHPMLBDPKJ, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().GOJKOJGKMHI, this.HFOPCMIHDOL.ONECLDMJKEE(i).BMPGGNAFOCF().EBCKBKHBNKH);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setVar:
							try
							{
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.DESATURATE"))
								{
									if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
									{
										if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											this.imageEffects.ShowAllEffectsWithTag("grayscale");
										}
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("grayscale_2");
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("grayscale_1");
										}
									}
									else
									{
										if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											this.imageEffects.HideAllEffectsWithTag("grayscale");
										}
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("grayscale_1");
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("grayscale_2");
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.TEAL"))
								{
									if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
									{
										if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											this.imageEffects.ShowAllEffectsWithTag("teal");
										}
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("teal_2");
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("teal_1");
										}
									}
									else
									{
										if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											this.imageEffects.HideAllEffectsWithTag("teal");
										}
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("teal_1");
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("teal_2");
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.BLUR"))
								{
									if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
									{
										if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											this.imageEffects.ShowAllEffectsWithTag("blur");
										}
										if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("blur_2");
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("blur_1");
										}
									}
									else
									{
										if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
										{
											this.imageEffects.HideAllEffectsWithTag("blur");
										}
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("blur_1");
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("blur_2");
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.ANALOGGLITCH"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("analogglitch");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitch_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitch_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("analogglitch");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitch_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitch_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.ANALOGGLITCH20"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("analogglitch20");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitch20_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitch20_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("analogglitch20");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitch20_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitch20_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.DIGITALGLITCH"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("digitalglitch");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("digitalglitch_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("digitalglitch_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("digitalglitch");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("digitalglitch_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("digitalglitch_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.NOISEANALOG"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("noiseanalog");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noiseanalog_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noiseanalog_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("noiseanalog");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noiseanalog_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noiseanalog_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.NOISEDIGITAL"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("noisedigital");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noisedigital_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noisedigital_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("noisedigital");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noisedigital_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noisedigital_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.OLDVHS"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("oldvhs");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("oldvhs_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("oldvhs_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("oldvhs");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("oldvhs_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("oldvhs_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.SPECTRUM"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("spectrum");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("spectrum_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("spectrum_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("spectrum");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("spectrum_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("spectrum_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.VHSPAUSE"))
								{
									if (null != this.imageEffects)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.ShowAllEffectsWithTag("vhspause");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("vhspause_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("vhspause_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffects.HideAllEffectsWithTag("vhspause");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("vhspause_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("vhspause_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.ANALOGGLITCH.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("analogglitchovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitchovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitchovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("analogglitchovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitchovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitchovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.ANALOGGLITCH20.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("analogglitch20ovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitch20ovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("analogglitch20ovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("analogglitch20ovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitch20ovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("analogglitch20ovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.DIGITALGLITCH.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("digitalglitchovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("digitalglitchovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("digitalglitchovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("digitalglitchovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("digitalglitchovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("digitalglitchovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.NOISEANALOG.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("noiseanalogovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noiseanalogovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noiseanalogovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("noiseanalogovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noiseanalogovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noiseanalogovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.NOISEDIGITAL.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("noisedigitalovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noisedigitalovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("noisedigitalovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("noisedigitalovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noisedigitalovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("noisedigitalovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.OLDVHS.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("oldvhsovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("oldvhsovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("oldvhsovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("oldvhsovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("oldvhsovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("oldvhsovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.SPECTRUM.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("spectrumovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("spectrumovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("spectrumovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("spectrumovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("spectrumovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("spectrumovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.POSTEFFECTS.VHSPAUSE.OVR"))
								{
									if (null != this.imageEffectsOvr)
									{
										if (int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA()) == 1)
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.ShowAllEffectsWithTag("vhspauseovr");
											}
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("vhspauseovr_2");
											}
											else
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PICADKCOBIN("vhspauseovr_1");
											}
										}
										else
										{
											if (this.LHBMEFGCPHK() || this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().HNKOCOFLKMP == 1)
											{
												this.imageEffectsOvr.HideAllEffectsWithTag("vhspauseovr");
											}
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("vhspauseovr_1");
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKKGBCFNFNG("vhspauseovr_2");
										}
									}
								}
								else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG.Equals("CLIENT.SCREEN.REWARD.INDEX"))
								{
									int lgkcpnjjkmc = int.Parse(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA());
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LGKCPNJJKMC = lgkcpnjjkmc;
								}
								else
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().EHELHLOCOGG, this.HFOPCMIHDOL.ONECLDMJKEE(i).CLOKBFEMAKB().MLDFBCPLODA());
								}
							}
							catch (Exception aklgbjkdomm19)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm19);
							}
							this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useEnvmoveV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).AONHAFGLLNF().BOPJOMGIJIA == DILMKCBFMIG.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BLEFLPOCEEB(2);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useFadersV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NHILAOBANMM().BOPJOMGIJIA == KBEMFPIGLJF.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIBDMALIGIH(2);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useEmotionsV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JNMBNNKPDNE().BOPJOMGIJIA == MLICLNDBCHP.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NNMLHBHGOCG(2);
								NonPlayerCharacterManager.SetEmotionsSystemVersion(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBFMMELGCLM());
								PlayerCharacterManager.SetEmotionsSystemVersion(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBFMMELGCLM());
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useAvatarConfigV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MIDNKMDOFCJ().BOPJOMGIJIA == KFBPJLBMEGG.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OMLFMDENBOD(2);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useDynamicMeta:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MEMLMEDGLJN().BOPJOMGIJIA == FACIPHCKHJM.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.preloadAsset:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PDGHAKKKBEI().BOPJOMGIJIA == FPEOCIGDBKK.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.dialogTitle:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().BOPJOMGIJIA)
							{
							case PKJJCOLONGL.BMHGEBOHLHH.show:
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.KDBHFEDEMBH(null);
								this.KGELMKIBOIJ(null);
								this.MKJBKIKPJEM(null);
								this.MDGOPJKEIAN(null);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case PKJJCOLONGL.BMHGEBOHLHH.showDialog:
								if (null != this.dialogTitlePrefab && null != this.titleDialogPivot)
								{
									if (this.LHBMEFGCPHK() && null != this.imageEffects)
									{
										this.imageEffects.ShowAllEffectsWithTag("blur");
									}
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.OPNHKEEICPG * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
									GameObject gameObject13 = UnityEngine.Object.Instantiate<GameObject>(this.dialogTitlePrefab);
									gameObject13.transform.SetParent(this.titleDialogPivot.transform, false);
									DialogTitleManager component8 = gameObject13.GetComponent<DialogTitleManager>();
									component8.Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF());
									component8.AppearAnimation();
									this.JCGPMCONNBM.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject13));
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().JLEAIJGBGHL.Length > 0)
									{
										AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().MHCAKNHEPDE);
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().LPLILOPPNMN.Length > 0)
									{
										string iglaigejgho7 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().LPLILOPPNMN);
										AudioManager.EHBBFMCILPC.PlayVoiceOver(iglaigejgho7, -1f, -1f);
									}
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 2);
								}
								break;
							case PKJJCOLONGL.BMHGEBOHLHH.hide:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho8 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).MNNCBNFLOIF().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.KillVoiceOver(iglaigejgho8, -1f);
								}
								if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
								{
									this.imageEffects.HideAllEffectsWithTag("blur");
								}
								this.FGBOHIGNOAD();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(DialogTitleManager.GetDisappearAnimationLength(), 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.layerUtil:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BOPJOMGIJIA == JLHBIPMDLNH.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								for (int num56 = 0; num56 < this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF.Count; num56++)
								{
									this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num56], 0f, 1f, this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().PMMCLCMDNGA, true, false);
								}
								for (int num57 = 0; num57 < this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH.Count; num57++)
								{
									this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num57], 1f, 0f, this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().PMMCLCMDNGA, false, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().KPPJINFHMIP.Length > 0)
								{
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().LLODADPOMJB = true;
									}
									AudioManager.EHBBFMCILPC.PlayMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().KPPJINFHMIP, this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().LLODADPOMJB, this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().PMMCLCMDNGA, false);
									if (this.HFFIIBBJBMH.header.ambientFreeAudio)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL = this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().KPPJINFHMIP;
									}
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().DKPPAALFKMO.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().DKPPAALFKMO), this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().PMMCLCMDNGA);
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().DKPPAALFKMO;
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().JLEAIJGBGHL, this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MHCAKNHEPDE);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().LJLHCJFDNGL < 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().PMMCLCMDNGA, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().LJLHCJFDNGL, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().HABIIFFBHEA > 1E-05f)
								{
									if (null != this.animationShakeEnvironmentFront)
									{
										this.animationShakeEnvironmentFront.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().HABIIFFBHEA;
										this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
										this.animationShakeEnvironmentFront.PlayAnimation();
									}
									if (null != this.animationShakeEnvironmentBack)
									{
										this.animationShakeEnvironmentBack.animationTime = this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().HABIIFFBHEA;
										this.animationShakeEnvironmentFront.frameUpdateInterval = 0.04f;
										this.animationShakeEnvironmentBack.PlayAnimation();
									}
								}
								for (int num58 = 0; num58 < this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF.Count; num58++)
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58].Contains("CLIENT.SCREEN.REWARD."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GFLJFEANKPE(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GFLJFEANKPE(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58].Contains("CLIENT.SCREEN.AVATAR."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FDOLKJHBBGN(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().FDOLKJHBBGN(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
									}
									else
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MFCIIAJJMOB(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().MCMOGGKILMF[num58], this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().FPHDAKHOBMO);
									}
								}
								for (int num59 = 0; num59 < this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH.Count; num59++)
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59].Contains("CLIENT.SCREEN.REWARD."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PLOKEOLNPLI(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().PLOKEOLNPLI(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59].Replace("CLIENT.SCREEN.REWARD.", ""));
										}
									}
									else if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59].Contains("CLIENT.SCREEN.AVATAR."))
									{
										if (!this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().FPHDAKHOBMO)
										{
											AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KEGCLEKKCPB(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
										else
										{
											AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().KEGCLEKKCPB(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59].Replace("CLIENT.SCREEN.AVATAR.", ""));
										}
									}
									else
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBCACCKOABP(this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().BNDPGIPOGOH[num59], this.HFOPCMIHDOL.ONECLDMJKEE(i).KGBBGCGFGOL().FPHDAKHOBMO);
									}
								}
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.stopSfx:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PELOMDILLGG().BOPJOMGIJIA == FBFJEIPLFIP.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AudioManager.EHBBFMCILPC.KillSfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).PELOMDILLGG().HCOFJONDHDE, this.HFOPCMIHDOL.ONECLDMJKEE(i).PELOMDILLGG().PMMCLCMDNGA);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.fadeMusic:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OMOCBOOKICL().BOPJOMGIJIA == NFGDDHHLPDA.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NPAFPMIMGLH = this.HFOPCMIHDOL.ONECLDMJKEE(i).OMOCBOOKICL().GAMOMEFNKML;
								AudioManager.EHBBFMCILPC.FadeMusic(this.HFOPCMIHDOL.ONECLDMJKEE(i).OMOCBOOKICL().GAMOMEFNKML, this.HFOPCMIHDOL.ONECLDMJKEE(i).OMOCBOOKICL().PMMCLCMDNGA);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.subtitleShow:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).AOBCMOLEGHA().BOPJOMGIJIA)
							{
							case EKOPCOHPOFG.BMHGEBOHLHH.show:
							{
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								GameObject gameObject14 = UnityEngine.Object.Instantiate<GameObject>(this.subtitleStoryPrefab);
								gameObject14.transform.SetParent(this.subtitlesPivot.transform, false);
								gameObject14.GetComponent<StorySubtitleManager>().Initialize(this.HFOPCMIHDOL.ONECLDMJKEE(i).AOBCMOLEGHA().EEKMOHDNCKF());
								this.KKNOHEBIDFL.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject14));
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).AOBCMOLEGHA().LJLHCJFDNGL < 0f)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).AOBCMOLEGHA().PMMCLCMDNGA, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).AOBCMOLEGHA().LJLHCJFDNGL, 1);
								}
								break;
							}
							case EKOPCOHPOFG.BMHGEBOHLHH.disappear:
								for (int num60 = 0; num60 < this.KKNOHEBIDFL.Count; num60++)
								{
									if (this.KKNOHEBIDFL[num60].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										this.KKNOHEBIDFL[num60].IACFDHCDEME.GetComponent<StorySubtitleManager>().DisappearAnimation();
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							case EKOPCOHPOFG.BMHGEBOHLHH.destroy:
								for (int num61 = 0; num61 < this.KKNOHEBIDFL.Count; num61++)
								{
									if (this.KKNOHEBIDFL[num61].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB))
									{
										UnityEngine.Object.Destroy(this.KKNOHEBIDFL[num61].IACFDHCDEME);
										this.KKNOHEBIDFL.RemoveAt(num61);
										break;
									}
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.storyLogo:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).KDPNKLAOEMG().BOPJOMGIJIA)
							{
							case JHOEPBJLDOH.BMHGEBOHLHH.show:
								if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
								{
									this.preWarmFader.FadeOut(null);
								}
								this.KDBHFEDEMBH(null);
								this.KGELMKIBOIJ(null);
								this.MKJBKIKPJEM(null);
								this.MDGOPJKEIAN(null);
								this.HJKLOODDLDE(100);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case JHOEPBJLDOH.BMHGEBOHLHH.showDialog:
								if (null != this.storyLogoPrefab && null != this.titleDialogPivot)
								{
									Sprite sprite = null;
									for (int num62 = 0; num62 < this.availableStoryLogos.Count; num62++)
									{
										if (this.availableStoryLogos[num62].name.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).KDPNKLAOEMG().JCPJMCKPAFC))
										{
											sprite = this.availableStoryLogos[num62];
											break;
										}
									}
									if (null != sprite)
									{
										if (this.LHBMEFGCPHK() && null != this.imageEffects)
										{
											this.imageEffects.ShowAllEffectsWithTag("blur");
										}
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.OPNHKEEICPG * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), 1);
										GameObject gameObject15 = UnityEngine.Object.Instantiate<GameObject>(this.storyLogoPrefab);
										gameObject15.transform.SetParent(this.titleDialogPivot.transform, false);
										StoryLogoManager component9 = gameObject15.GetComponent<StoryLogoManager>();
										component9.Initialize(sprite);
										component9.AppearAnimation();
										this.MPNBBKODANC.Add(this.GLDAJFNCFKC(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().DBHMNECMIAB, gameObject15));
									}
									else
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 2);
									}
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 2);
								}
								break;
							case JHOEPBJLDOH.BMHGEBOHLHH.hide:
								if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
								{
									this.imageEffects.HideAllEffectsWithTag("blur");
								}
								this.AKLAHGGGGNF();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(StoryLogoManager.GetDisappearAnimationLength(), 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useVideoV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CLEMHBDEKBL().BOPJOMGIJIA == DFFNHBJMFMP.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KDIEAECHDHH(2);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useAnimV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JMGPKBHDBFN().BOPJOMGIJIA == HECMIBFLKMM.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LHLHFMFPCAM(2);
								ImageFrameAnimation.SetAnimationSystemVersionOverride(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CEIOOCHCDCF());
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.useTranslationV2:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).JOGFCOACILH().BOPJOMGIJIA == ALAELCDLPCP.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ABDLICPKKPG(2);
								AnimationTranslation.SetTranslationSystemVersion(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BPCDDHNOJNF());
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.prepareVideo:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IBAEILKKEML().BOPJOMGIJIA == LPFFPEPIPAL.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								for (int num63 = 0; num63 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IBAEILKKEML().LOCCINPEPKC.Count; num63++)
								{
									this.OKIHENOGDKD(this.HFOPCMIHDOL.ONECLDMJKEE(i).IBAEILKKEML().LOCCINPEPKC[num63], 0f, 0f, 0f, true, true);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.emotionLoopStart:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GDMJFIDJNAA().BOPJOMGIJIA == CFAMJFEPAAG.BMHGEBOHLHH.start)
							{
								LPEMDECEIAO.NPOKGKEDFFA(this.HFOPCMIHDOL.ONECLDMJKEE(i).GDMJFIDJNAA().GEODIDKODMB, this.HFOPCMIHDOL.ONECLDMJKEE(i).GDMJFIDJNAA().PPMGNKCCIPG, this.HFOPCMIHDOL.ONECLDMJKEE(i).GDMJFIDJNAA().MIIILPBNHHA, this.HFOPCMIHDOL.ONECLDMJKEE(i).GDMJFIDJNAA().NGNDOALIKAK);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.emotionLoopEnd:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).MMDHLFJHOLL().BOPJOMGIJIA == POKJIPLIHMH.BMHGEBOHLHH.End)
							{
								LPEMDECEIAO.ELBGKBANCDP(this.HFOPCMIHDOL.ONECLDMJKEE(i).MMDHLFJHOLL().GEODIDKODMB);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.hideAvatarComponent:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().BOPJOMGIJIA == GCHKBABPNFC.BMHGEBOHLHH.start)
							{
								try
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PLPCLJFJFNG.Count > 0)
									{
										for (int num64 = 0; num64 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PLPCLJFJFNG.Count; num64++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PLPCLJFJFNG[num64] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PLPCLJFJFNG[num64].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHMBINIOBDO(this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PLPCLJFJFNG[num64]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().JHHKEPGLHKD.Count > 0)
									{
										for (int num65 = 0; num65 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().JHHKEPGLHKD.Count; num65++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().JHHKEPGLHKD[num65] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().JHHKEPGLHKD[num65].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHMBINIOBDO(this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().JHHKEPGLHKD[num65]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().KGOAGNFNFIJ.Count > 0)
									{
										for (int num66 = 0; num66 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().KGOAGNFNFIJ.Count; num66++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().KGOAGNFNFIJ[num66] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().KGOAGNFNFIJ[num66].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHMBINIOBDO(this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().KGOAGNFNFIJ[num66]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().OMGLOJOIOCK.Count > 0)
									{
										for (int num67 = 0; num67 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().OMGLOJOIOCK.Count; num67++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().OMGLOJOIOCK[num67] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().OMGLOJOIOCK[num67].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHMBINIOBDO(this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().OMGLOJOIOCK[num67]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PBOKDNDMCDL.Count > 0)
									{
										for (int num68 = 0; num68 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PBOKDNDMCDL.Count; num68++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PBOKDNDMCDL[num68] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PBOKDNDMCDL[num68].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHMBINIOBDO(this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().PBOKDNDMCDL[num68]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().GHALDHOOFKN.Count > 0)
									{
										for (int num69 = 0; num69 < this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().GHALDHOOFKN.Count; num69++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().GHALDHOOFKN[num69] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().GHALDHOOFKN[num69].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHMBINIOBDO(this.HFOPCMIHDOL.ONECLDMJKEE(i).IGHODLHGKAI().GHALDHOOFKN[num69]);
											}
										}
									}
								}
								catch (Exception aklgbjkdomm20)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm20);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.unhideAvatarComponent:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().BOPJOMGIJIA == AMAJHPOEPOI.BMHGEBOHLHH.start)
							{
								try
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PLPCLJFJFNG.Count > 0)
									{
										for (int num70 = 0; num70 < this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PLPCLJFJFNG.Count; num70++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PLPCLJFJFNG[num70] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PLPCLJFJFNG[num70].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKBADCKFCAK(this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PLPCLJFJFNG[num70]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().JHHKEPGLHKD.Count > 0)
									{
										for (int num71 = 0; num71 < this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().JHHKEPGLHKD.Count; num71++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().JHHKEPGLHKD[num71] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().JHHKEPGLHKD[num71].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKBADCKFCAK(this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().JHHKEPGLHKD[num71]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().KGOAGNFNFIJ.Count > 0)
									{
										for (int num72 = 0; num72 < this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().KGOAGNFNFIJ.Count; num72++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().KGOAGNFNFIJ[num72] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().KGOAGNFNFIJ[num72].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKBADCKFCAK(this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().KGOAGNFNFIJ[num72]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().OMGLOJOIOCK.Count > 0)
									{
										for (int num73 = 0; num73 < this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().OMGLOJOIOCK.Count; num73++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().OMGLOJOIOCK[num73] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().OMGLOJOIOCK[num73].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKBADCKFCAK(this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().OMGLOJOIOCK[num73]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PBOKDNDMCDL.Count > 0)
									{
										for (int num74 = 0; num74 < this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PBOKDNDMCDL.Count; num74++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PBOKDNDMCDL[num74] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PBOKDNDMCDL[num74].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKBADCKFCAK(this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().PBOKDNDMCDL[num74]);
											}
										}
									}
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().GHALDHOOFKN.Count > 0)
									{
										for (int num75 = 0; num75 < this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().GHALDHOOFKN.Count; num75++)
										{
											if (this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().GHALDHOOFKN[num75] != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().GHALDHOOFKN[num75].Length > 0)
											{
												AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKBADCKFCAK(this.HFOPCMIHDOL.ONECLDMJKEE(i).GHNECFBIMMB().GHALDHOOFKN[num75]);
											}
										}
									}
								}
								catch (Exception aklgbjkdomm21)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm21);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.showHints:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).NJHFBODDDIA().BOPJOMGIJIA == PPDLJBIOJFK.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ALLDBPCKMLF = 1;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.hideHints:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).LOKGNMBKMCB().BOPJOMGIJIA == JFCBIAFCKPK.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ALLDBPCKMLF = 0;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.saveCutscene:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IGFMONBFODD().BOPJOMGIJIA == MNGDMIHKNDB.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								if (null != this.saveCutsceneButton)
								{
									this.saveCutsceneButton.gameObject.SetActive(true);
								}
								this.CODFIPHLBLE = this.HFOPCMIHDOL.HJOANJHIHAI().IGFMONBFODD();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.achievementUnlock:
						{
							ALPHHLOPBLC.BMHGEBOHLHH bopjomgijia4 = this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().BOPJOMGIJIA;
							if (bopjomgijia4 != ALPHHLOPBLC.BMHGEBOHLHH.start)
							{
								if (bopjomgijia4 == ALPHHLOPBLC.BMHGEBOHLHH.delay)
								{
									CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
									BackendOperationsManager.EHBBFMCILPC.RequestAchievementsSync("OnAchievementSyncSuccess", "OnAchievementSyncException");
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
							}
							else
							{
								this.HGLBOPHFCPH();
								bool flag9 = true;
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().ONBBPLAIGDF.Count > 0)
								{
									for (int num76 = 0; num76 < this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().ONBBPLAIGDF.Count; num76++)
									{
										if (!AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().CCLEJFEFBJM(this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().ONBBPLAIGDF[num76]))
										{
											flag9 = false;
											break;
										}
									}
								}
								if (!SceneStoryManager.AchievementIsUnlocked(this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().FNAOJFMDPEL, SceneStoryManager.achievements) && null != this.noteStoryAchievementPrefab && flag9)
								{
									this.APDAMLCHICH();
									this.JOKJBAIECCA(false);
									string str = GKJPOGNFKNK.DNILNCLIHAP(this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().FNAOJFMDPEL, "achievdesc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
									string str2 = GKJPOGNFKNK.DNILNCLIHAP(this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().FNAOJFMDPEL, "achievtitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
									string text9 = "<i>" + str2 + "</i>";
									text9 = text9 + "\n\n" + str;
									text9 = text9.Replace(",", "،");
									text9 = text9.Replace("(", "〈");
									text9 = text9.Replace(")", "〉");
									this.HFOPCMIHDOL.HFALHCEIDPM(string.Concat(new string[]
									{
										"$NOTESHOW body(",
										text9,
										") title(",
										CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("achievunlocked"),
										") icon(",
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().FNAOJFMDPEL,
										") delay(",
										KDCJJBLGCBH.EHBBFMCILPC.OANLIHOLCFE().ToString(),
										")"
									}), new List<string>(), new List<Choice>(), false, false, false, false);
									AKLFPGMDKLA.EHBBFMCILPC.OBOEKFOEBLM(this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().FNAOJFMDPEL, this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().ENBBONPKHBC);
									try
									{
										SteamManager.EHBBFMCILPC.GetComponent<AchievementsManagerSteam>().UnlockAchievement(this.HFOPCMIHDOL.ONECLDMJKEE(i).FGEGHJDDJFA().FNAOJFMDPEL);
									}
									catch (Exception aklgbjkdomm22)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm22);
									}
									float bichmdeifki3 = 0.5f + (KDCJJBLGCBH.EHBBFMCILPC.OANLIHOLCFE() + (float)text9.Length * 0.08f) * 0.75f;
									DPGJIJGOCIC.NFIDPOMCNLP("StoryStep.StoryStepType.achievementUnlock timeToNextStage:" + bichmdeifki3.ToString());
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(bichmdeifki3, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 3);
								}
							}
							break;
						}
						case KGLBKJKNPFD.LBFFMOMMAPK.achievementIsUnlocked:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).HJONJFLONAP().BOPJOMGIJIA == GLDNGEEJAHP.BMHGEBOHLHH.start)
							{
								if (SceneStoryManager.AchievementIsUnlocked(this.HFOPCMIHDOL.ONECLDMJKEE(i).HJONJFLONAP().FNAOJFMDPEL, SceneStoryManager.achievements))
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).HJONJFLONAP().EHELHLOCOGG, true);
								}
								else
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).HJONJFLONAP().EHELHLOCOGG, false);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setBit:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PEAAMAOHDEK().BOPJOMGIJIA == AMGALGOMMDF.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OEMEPBMFEEP(this.HFOPCMIHDOL.ONECLDMJKEE(i).PEAAMAOHDEK().GGICIBLJIKI);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.isBitSet:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).AGHPBNIBPOA().BOPJOMGIJIA == BOPBCIBJLAN.BMHGEBOHLHH.start)
							{
								if (AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().CCLEJFEFBJM(this.HFOPCMIHDOL.ONECLDMJKEE(i).AGHPBNIBPOA().GGICIBLJIKI))
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).AGHPBNIBPOA().EHELHLOCOGG, true);
								}
								else
								{
									ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).AGHPBNIBPOA().EHELHLOCOGG, false);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chatOpen:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IHMNHINALAJ().BOPJOMGIJIA == CKBCHMOAKLK.BMHGEBOHLHH.start)
							{
								this.HGLBOPHFCPH();
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JGMCFGNAICC(this.HFOPCMIHDOL.ONECLDMJKEE(i).IHMNHINALAJ().APJLHOCPOEO);
								this.GOPGELMBMMK = new CKBCHMOAKLK(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GOPGELMBMMK);
								this.ICJLNPJOIHP(1);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chatMeta:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PALFFPGGNLJ().BOPJOMGIJIA == PFADAFAHNNJ.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DLGFOOFLKAE(this.HFOPCMIHDOL.ONECLDMJKEE(i).PALFFPGGNLJ().APJLHOCPOEO);
								this.HPAEFOJDLFC = new PFADAFAHNNJ(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPAEFOJDLFC);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chatMessage:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().BOPJOMGIJIA)
							{
							case LJFIKKKBMDG.BMHGEBOHLHH.show:
								this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().JMNMOHIKHLB = this.JMNMOHIKHLB;
								this.PKKPMENAIGC = this.GLLFKOJEBPC;
								this.GLLFKOJEBPC = this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().DKEOPDAFLNO();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().JLEAIJGBGHL.Length > 0)
								{
									AudioManager.EHBBFMCILPC.PlaySfx(this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().JLEAIJGBGHL, false);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho9 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.PlayVoiceOver(iglaigejgho9, -1f, -1f);
								}
								if (this.JMNMOHIKHLB != null && this.JMNMOHIKHLB.FILFGDIGINA > 0)
								{
									this.BPKMDANBJKG(true);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().COEFNFJMBDG.Count > 0)
								{
									this.APDAMLCHICH();
									this.JOKJBAIECCA(false);
									this.MLDGHPCEFNN().PushChoices(this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME(), this.GKHNIMJJLJL, this.OAPJBCFENNF());
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.LLGKJGFBKKG, 1);
								}
								else
								{
									float bichmdeifki4 = this.MLDGHPCEFNN().PushMessage(this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME(), this.HPAEFOJDLFC);
									if (!this.HPAEFOJDLFC.EFBJNOAJGDA && this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().FPGGOGKKNPK(this.HPAEFOJDLFC).GLDFFFJIACO == 0)
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
									}
									else
									{
										this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(bichmdeifki4, 3);
									}
								}
								break;
							case LJFIKKKBMDG.BMHGEBOHLHH.executeChoice:
								this.MLDGHPCEFNN().UserInputProcessed();
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() >= 0)
								{
									if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.DBBEJLKKJDA.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.GEAIOJHBEBI.Count && this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.EDFDNECFDPA.Count)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IOAEANAABEF(this.JMNMOHIKHLB.DBBEJLKKJDA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.EDFDNECFDPA[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.GEAIOJHBEBI[this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()]);
									}
									this.PKCNCMBMJCI();
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							case LJFIKKKBMDG.BMHGEBOHLHH.hide:
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().LPLILOPPNMN.Length > 0)
								{
									string iglaigejgho10 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().LPLILOPPNMN);
									AudioManager.EHBBFMCILPC.KillVoiceOver(iglaigejgho10, -1f);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().COEFNFJMBDG != null && this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().COEFNFJMBDG.Count > 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.MLDGHPCEFNN().PushMessageChoice(this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME(), this.HPAEFOJDLFC, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM()), 1);
								}
								else if (!this.HPAEFOJDLFC.EFBJNOAJGDA && this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().FPGGOGKKNPK(this.HPAEFOJDLFC).GLDFFFJIACO == 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.MLDGHPCEFNN().GetLastPostMessageWaitTime(), 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM() >= 0)
								{
									this.GFIFDKBLLBL.ChooseChoiceIndex(this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM());
									GNKBFDPLGOE gnkbfdplgoe = this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().MLENDOEHFKA(this.HPAEFOJDLFC, this.HFOPCMIHDOL.ONECLDMJKEE(i).ONECLDMJKEE().EKOIFOBAHDM());
									try
									{
										if (ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
										{
											this.GKHNIMJJLJL.CFGNAKJMDOL();
											if (gnkbfdplgoe != null)
											{
												SceneStoryManager.localizedChoice = gnkbfdplgoe.NCAMFPGMCIG;
											}
											else
											{
												SceneStoryManager.localizedChoice = "";
											}
										}
										else
										{
											this.GKHNIMJJLJL.LNCIMPFKHAO();
											SceneStoryManager.localizedChoice = "";
										}
									}
									catch (Exception aklgbjkdomm23)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm23);
									}
									if (gnkbfdplgoe != null)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AABIMKHJJFJ().HHMAAPADAFB(gnkbfdplgoe.BMKJBDCFMDO());
									}
								}
								else
								{
									GNKBFDPLGOE gnkbfdplgoe2 = this.HFOPCMIHDOL.ONECLDMJKEE(i).PGDPEBMIOME().FPGGOGKKNPK(this.HPAEFOJDLFC);
									if (gnkbfdplgoe2 != null && gnkbfdplgoe2.NCAMFPGMCIG.Length > 0 && ODLJHDIGLGO.ALFGPLALKCN(CLHDENLPOFP.gamePass))
									{
										string str3 = ONEHEBIHPFB.LMDACNKELEC(gnkbfdplgoe2.BPMFHNDCBOH);
										this.GKHNIMJJLJL.JLACJIMEGGL(str3 + ": " + gnkbfdplgoe2.NCAMFPGMCIG);
									}
									SceneStoryManager.localizedLine = "";
									if (gnkbfdplgoe2 != null)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AABIMKHJJFJ().HHMAAPADAFB(gnkbfdplgoe2.BMKJBDCFMDO());
									}
								}
								ApplicationFocusManager.Deactivate();
								this.DHJLICMCKEO();
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chatDelay:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).PEIHFNOCIPO().BOPJOMGIJIA == EPAGGJIALMP.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).PEIHFNOCIPO().JCIAOPBKNCH, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chatClose:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).PBCEIHIALKB().BOPJOMGIJIA)
							{
							case BPBCEIJBEEK.BMHGEBOHLHH.start:
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIBNMKJIMAD == 0)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 3);
								}
								else if (this.HPAEFOJDLFC != null && this.HPAEFOJDLFC.BPNGIDAMBEJ)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).PBCEIHIALKB().IMBBIDKPOBM = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK;
									if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
									{
										this.imageEffects.HideAllEffectsWithTag("blur");
									}
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 3);
								}
								else
								{
									this.MLDGHPCEFNN().PushMessageWaitForInput();
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								}
								break;
							case BPBCEIJBEEK.BMHGEBOHLHH.delay:
								this.MLDGHPCEFNN().UserInputProcessed();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).PBCEIHIALKB().IMBBIDKPOBM = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK;
								this.MLDGHPCEFNN().DisappearAnimation();
								if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
								{
									this.imageEffects.HideAllEffectsWithTag("blur");
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								break;
							case BPBCEIJBEEK.BMHGEBOHLHH.destroy:
								for (int num77 = 0; num77 < this.BOALOCEGFOO.Count; num77++)
								{
									if (this.BOALOCEGFOO[num77].DBHMNECMIAB.Equals(this.HFOPCMIHDOL.ONECLDMJKEE(i).PBCEIHIALKB().IMBBIDKPOBM))
									{
										UnityEngine.Object.Destroy(this.BOALOCEGFOO[num77].IACFDHCDEME);
										this.BOALOCEGFOO.RemoveAt(num77);
										break;
									}
								}
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIBNMKJIMAD = 0;
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK = "";
								this.BLECFOJBLLC();
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.sendNotif:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).EMHLIDKIPGI().BOPJOMGIJIA == KODCEBPPCMK.BMHGEBOHLHH.show)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.hintShow:
							switch (this.HFOPCMIHDOL.ONECLDMJKEE(i).GPAOEANDEGB().BOPJOMGIJIA)
							{
							case KPGLEKJJAGH.BMHGEBOHLHH.show:
								try
								{
									if (null != this.hintText && this.HDKIOPAGLHH >= 1 && !this.hintText.GetComponent<AnimationCanvasGroupAlpha>().IsPlaying())
									{
										this.hintText.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
										this.hintText.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
									}
								}
								catch (Exception aklgbjkdomm24)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm24);
								}
								this.HDKIOPAGLHH++;
								if (null != this.hintText)
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 3);
								}
								break;
							case KPGLEKJJAGH.BMHGEBOHLHH.delayBeforeDisappear:
								if (null != this.hintText)
								{
									this.hintText.gameObject.SetActive(true);
									this.hintText.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(false);
									this.hintText.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
									this.hintText.SetText(this.HFOPCMIHDOL.ONECLDMJKEE(i).GPAOEANDEGB().EEKMOHDNCKF(), true);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.HFOPCMIHDOL.ONECLDMJKEE(i).GPAOEANDEGB().PMMCLCMDNGA, 1);
								break;
							case KPGLEKJJAGH.BMHGEBOHLHH.disappear:
								if (null != this.hintText && this.HDKIOPAGLHH == 1)
								{
									this.hintText.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
									this.hintText.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(this.hintText.GetComponent<AnimationCanvasGroupAlpha>().animationTime, 1);
								}
								else
								{
									this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0.5f, 1);
								}
								break;
							case KPGLEKJJAGH.BMHGEBOHLHH.destroy:
								this.HDKIOPAGLHH--;
								if (null != this.hintText && this.HDKIOPAGLHH == 0)
								{
									this.hintText.gameObject.SetActive(false);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								break;
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.chatDiscard:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CGOLDGOMHJI().BOPJOMGIJIA == IEPEFGOCFAF.BMHGEBOHLHH.start)
							{
								try
								{
									for (int num78 = 0; num78 < this.HFOPCMIHDOL.ONECLDMJKEE(i).CGOLDGOMHJI().BFJIAPJJLDD.Count; num78++)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PDNIIIMLAII(this.HFOPCMIHDOL.ONECLDMJKEE(i).CGOLDGOMHJI().BFJIAPJJLDD[num78]);
									}
								}
								catch (Exception aklgbjkdomm25)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm25);
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.enableLocalizationExtension:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).COIOIOFAHCH().BOPJOMGIJIA == ANLOFHPPBLC.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NCPKDCADCAM(this.HFOPCMIHDOL.ONECLDMJKEE(i).COIOIOFAHCH().GGICIBLJIKI);
								KGLBKJKNPFD.DMAGAHMIKDE = this.HFOPCMIHDOL.ONECLDMJKEE(i).COIOIOFAHCH().GGICIBLJIKI;
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setWardrobe:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).AJJCALKIFMG().BOPJOMGIJIA == IPPJMENKOFC.BMHGEBOHLHH.start)
							{
								if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME != this.HFOPCMIHDOL.ONECLDMJKEE(i).AJJCALKIFMG().OIBGFPEGLME)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME = this.HFOPCMIHDOL.ONECLDMJKEE(i).AJJCALKIFMG().OIBGFPEGLME;
									this.CJLNNMCHOEB();
									this.CEDDGIABDKF();
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setWardrobeMeta:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KKOEBOJJAMK().BOPJOMGIJIA == BDACKNLJJOI.BMHGEBOHLHH.start)
							{
								List<int> list6 = new List<int>();
								for (int num79 = 0; num79 < this.HFOPCMIHDOL.ONECLDMJKEE(i).KKOEBOJJAMK().BFFOPDBKCHF.Count; num79++)
								{
									if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KKOEBOJJAMK().BFFOPDBKCHF[num79] < 0)
									{
										list6.Clear();
										break;
									}
									list6.Add(this.HFOPCMIHDOL.ONECLDMJKEE(i).KKOEBOJJAMK().BFFOPDBKCHF[num79]);
								}
								bool flag10 = list6.Count != AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFFOPDBKCHF.Count;
								if (!flag10)
								{
									for (int num80 = 0; num80 < list6.Count; num80++)
									{
										if (list6[num80] != AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFFOPDBKCHF[num80])
										{
											flag10 = true;
											break;
										}
									}
								}
								if (flag10)
								{
									AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFFOPDBKCHF.Clear();
									for (int num81 = 0; num81 < list6.Count; num81++)
									{
										AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFFOPDBKCHF.Add(list6[num81]);
									}
								}
								if (flag10)
								{
									this.UpdateTopMatchData();
									this.CJLNNMCHOEB();
									this.CEDDGIABDKF();
								}
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.removeSuperMapping:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).IFBNOHOGHHG().BOPJOMGIJIA == JIMEADEBKFF.BMHGEBOHLHH.start)
							{
								this.EMBJDGJMJHA(this.HFOPCMIHDOL.ONECLDMJKEE(i).IFBNOHOGHHG().KALBADOPCDN);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.setFaderFx:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).OADDPLMEGKC().BOPJOMGIJIA == MLDGBANOMAA.BMHGEBOHLHH.start)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKCAKJMDBBL = this.HFOPCMIHDOL.ONECLDMJKEE(i).OADDPLMEGKC().AKCAKJMDBBL;
								this.OHAIEJKIMFG(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKCAKJMDBBL);
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.playVoiceOver:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).ILHPEOGNNDJ().BOPJOMGIJIA == LLNGEIMFHBB.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								string iglaigejgho11 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).ILHPEOGNNDJ().HCOFJONDHDE);
								AudioManager.EHBBFMCILPC.PlayVoiceOver(iglaigejgho11, this.HFOPCMIHDOL.ONECLDMJKEE(i).ILHPEOGNNDJ().PMMCLCMDNGA, this.HFOPCMIHDOL.ONECLDMJKEE(i).ILHPEOGNNDJ().LJLHCJFDNGL);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.stopVoiceOver:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).KADNGBBDGKJ().BOPJOMGIJIA == DHADKGOGGOK.BMHGEBOHLHH.start)
							{
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
								string iglaigejgho12 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(this.HFOPCMIHDOL.ONECLDMJKEE(i).KADNGBBDGKJ().HCOFJONDHDE);
								AudioManager.EHBBFMCILPC.KillVoiceOver(iglaigejgho12, this.HFOPCMIHDOL.ONECLDMJKEE(i).KADNGBBDGKJ().PMMCLCMDNGA);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.skinUnlocked:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).BGODOHHKNMH().BOPJOMGIJIA == AOHBGKKOMGD.BMHGEBOHLHH.start)
							{
								ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).BGODOHHKNMH().EHELHLOCOGG, this.HFOPCMIHDOL.ONECLDMJKEE(i).BGODOHHKNMH().OBLBNLBFBNI >= 0 && AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(this.HFOPCMIHDOL.ONECLDMJKEE(i).BGODOHHKNMH().OBLBNLBFBNI));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.skinApplied:
							if (this.HFOPCMIHDOL.ONECLDMJKEE(i).CCCABJLNECJ().BOPJOMGIJIA == EAFFJFDFDOM.BMHGEBOHLHH.start)
							{
								ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.ONECLDMJKEE(i).CCCABJLNECJ().EHELHLOCOGG, this.DEPGGCJLMMD(this.HFOPCMIHDOL.ONECLDMJKEE(i).CCCABJLNECJ().BIKHKADNPLO));
								this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							}
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.skinCheckpointStart:
							this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							break;
						case KGLBKJKNPFD.LBFFMOMMAPK.skinCheckpointEnd:
							this.HFOPCMIHDOL.ONECLDMJKEE(i).FEHODJMIAJL(0f, 1);
							break;
						}
					}
				}
			}
			if (null != this.KOCJONIGKNH && this.KOCJONIGKNH.gameObject.activeSelf)
			{
				try
				{
					bool userInputRequired = false;
					if (this.GFIFDKBLLBL.currentChoices.Count > 0)
					{
						userInputRequired = true;
					}
					else if (this.HFOPCMIHDOL.HJOANJHIHAI().PINCOCDOOGH())
					{
						KGLBKJKNPFD.LBFFMOMMAPK obkckghfmdn = this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN;
						if (obkckghfmdn == KGLBKJKNPFD.LBFFMOMMAPK.giveItem || obkckghfmdn == KGLBKJKNPFD.LBFFMOMMAPK.useItem || obkckghfmdn == KGLBKJKNPFD.LBFFMOMMAPK.showItem || obkckghfmdn == KGLBKJKNPFD.LBFFMOMMAPK.readInput)
						{
							userInputRequired = true;
						}
					}
					this.KOCJONIGKNH.SetUserInputRequired(userInputRequired);
				}
				catch (Exception aklgbjkdomm26)
				{
					if (!this.ACAMCLIBIAF)
					{
						this.ACAMCLIBIAF = true;
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm26);
					}
				}
			}
			if (!this.EMKPOOMPLON && this.HFOPCMIHDOL.HJOANJHIHAI().PINCOCDOOGH() && this.GFIFDKBLLBL.currentChoices.Count == 0 && this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN != KGLBKJKNPFD.LBFFMOMMAPK.giveItem && this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN != KGLBKJKNPFD.LBFFMOMMAPK.useItem && this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN != KGLBKJKNPFD.LBFFMOMMAPK.showItem && this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN != KGLBKJKNPFD.LBFFMOMMAPK.readInput)
			{
				if (this.HFOPCMIHDOL.HJOANJHIHAI().FEACFCIJFNM().ODHBINFKIPL() > this.BAABIIPPLCE && this.HNNPNKKLNBM.Count == 0 && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIBNMKJIMAD == 0)
				{
					GameObject gameObject16 = UnityEngine.Object.Instantiate<GameObject>(this.tapToContinuePrefab);
					gameObject16.transform.SetParent(this.tapToContinuePivot.transform, false);
					this.HNNPNKKLNBM.Add(gameObject16);
				}
				if (null != this.KOCJONIGKNH && this.KOCJONIGKNH.gameObject.activeSelf)
				{
					try
					{
						bool ibnknalgfhl = true;
						if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.IsShowingOrVisible())
						{
							ibnknalgfhl = false;
						}
						if (StoryInterfaceHeaderManager.modalDialogActive)
						{
							ibnknalgfhl = false;
						}
						if (1 == AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIBNMKJIMAD)
						{
							StoryChatManager storyChatManager = this.MLDGHPCEFNN();
							if (null != storyChatManager && (storyChatManager.IsInScrollState() || storyChatManager.IsBusyTyping()))
							{
								ibnknalgfhl = false;
							}
						}
						string jebmmjifila = "";
						KGLBKJKNPFD.LBFFMOMMAPK obkckghfmdn2 = this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN;
						if (obkckghfmdn2 - KGLBKJKNPFD.LBFFMOMMAPK.dialogNarrator > 2)
						{
							if (obkckghfmdn2 != KGLBKJKNPFD.LBFFMOMMAPK.dialogTitle)
							{
								if (obkckghfmdn2 != KGLBKJKNPFD.LBFFMOMMAPK.chatMessage)
								{
									goto IL_11376;
								}
							}
							else
							{
								if (this.HFOPCMIHDOL.HJOANJHIHAI().MNNCBNFLOIF() != null)
								{
									jebmmjifila = this.HFOPCMIHDOL.HJOANJHIHAI().MNNCBNFLOIF().DKEOPDAFLNO();
									goto IL_11376;
								}
								goto IL_11376;
							}
						}
						jebmmjifila = this.GLLFKOJEBPC;
						IL_11376:
						this.KOCJONIGKNH.TickAdvanceProgress(ibnknalgfhl, this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().DBHMNECMIAB, jebmmjifila);
					}
					catch (Exception aklgbjkdomm27)
					{
						if (!this.ACAMCLIBIAF)
						{
							this.ACAMCLIBIAF = true;
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm27);
						}
					}
				}
				bool flag11 = false;
				if (null != this.FNHFGLHODBG && this.FNHFGLHODBG.gameObject.activeSelf && this.FNHFGLHODBG.PopIntervalHit())
				{
					flag11 = true;
				}
				else if (null != this.KOCJONIGKNH && this.KOCJONIGKNH.gameObject.activeSelf && this.KOCJONIGKNH.PopIntervalHit())
				{
					flag11 = true;
				}
				else if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
				{
					if (DPGJIJGOCIC.KLPPJLLBJAP().y > 0.03f && DPGJIJGOCIC.KLPPJLLBJAP().y < this.OFCOFBDHBHE)
					{
						flag11 = true;
						if (null != this.FNHFGLHODBG && this.FNHFGLHODBG.gameObject.activeSelf && this.FNHFGLHODBG.IsTouchInside(true))
						{
							flag11 = false;
						}
						if (null != this.KOCJONIGKNH && this.KOCJONIGKNH.gameObject.activeSelf && this.KOCJONIGKNH.IsTouchInside(true))
						{
							flag11 = false;
						}
						if (flag11 && null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.IsVisible() && this.storyInterfaceHeaderManager.IsTouchInside(true))
						{
							flag11 = false;
						}
					}
				}
				else if (DPGJIJGOCIC.PCOOFHCMKGI() && DPGJIJGOCIC.AHELOLJOHLJ().y > 0.03f && DPGJIJGOCIC.AHELOLJOHLJ().y < this.OFCOFBDHBHE)
				{
					flag11 = true;
					if (null != this.FNHFGLHODBG && this.FNHFGLHODBG.gameObject.activeSelf && this.FNHFGLHODBG.IsTouchInside(false))
					{
						flag11 = false;
					}
					if (null != this.KOCJONIGKNH && this.KOCJONIGKNH.gameObject.activeSelf && this.KOCJONIGKNH.IsTouchInside(false))
					{
						flag11 = false;
					}
					if (flag11 && null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.IsVisible() && this.storyInterfaceHeaderManager.IsTouchInside(false))
					{
						flag11 = false;
					}
				}
				if (!flag11 && (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.Space)))
				{
					flag11 = true;
				}
				if (flag11)
				{
					if (this.GKHNIMJJLJL.DHONIOBOLEL.NFGLCEHILCN() && this.GKHNIMJJLJL.DHONIOBOLEL.AJPIKAACMKL == 0 && this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
					{
						this.GKHNIMJJLJL.DHONIOBOLEL.BMJOOOAJEPL(5);
						this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
					}
					if (this.GKHNIMJJLJL.DHONIOBOLEL.MEABNNFHPDL())
					{
						if (null != this.storyInterfaceHeaderManager)
						{
							this.storyInterfaceHeaderManager.HideInterfaceUndoButton();
						}
						this.GKHNIMJJLJL.PFHCDMOJOKP();
					}
					this.HJKLOODDLDE(1);
					if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
					{
						AKLFPGMDKLA.EHBBFMCILPC.KFHJHOGCEOF++;
						if (AKLFPGMDKLA.EHBBFMCILPC.KFHJHOGCEOF <= 100 && AKLFPGMDKLA.EHBBFMCILPC.KFHJHOGCEOF % 10 == 0)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1StoryTap.ToString() + AKLFPGMDKLA.EHBBFMCILPC.KFHJHOGCEOF.ToString(), true, false);
						}
					}
					this.HPBFGMAFKDD++;
					base.StartCoroutine(this.LIOPBCPKCFP());
					this.BAABIIPPLCE = 15f;
					this.OGNJFHPEDNN();
					this.JPKENCCOBEA = false;
					if (null != this.storyInterfaceHeaderManager)
					{
						this.JPKENCCOBEA = this.storyInterfaceHeaderManager.Hide();
					}
					if (!this.JPKENCCOBEA)
					{
						this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
					}
				}
			}
			if (this.EMKPOOMPLON)
			{
				this.GLOEGOPLGDN();
				this.AIGBJLAPFLH();
			}
			this.EMKPOOMPLON = false;
		}
		if (!this.GJDIJIAENCJ)
		{
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
			{
				if (DPGJIJGOCIC.KLPPJLLBJAP().y > 0.85f && null != this.storyInterfaceHeaderManager && !ChoiceExtendedManager.SwipeConsumedRelease())
				{
					this.APDAMLCHICH();
					this.OPLBCELFMLI();
					this.storyInterfaceHeaderManager.Show(this.CEBPKAAGJPJ());
				}
				if (DPGJIJGOCIC.KLPPJLLBJAP().y > 0.6f)
				{
					this.OGNJFHPEDNN();
				}
				else if (null != this.storyInterfaceHeaderManager)
				{
					this.storyInterfaceHeaderManager.Hide();
				}
			}
			else if (DPGJIJGOCIC.PCOOFHCMKGI())
			{
				if (DPGJIJGOCIC.AHELOLJOHLJ().y > 0.85f && null != this.storyInterfaceHeaderManager && !ChoiceExtendedManager.SwipeConsumedRelease())
				{
					this.APDAMLCHICH();
					this.OPLBCELFMLI();
					this.storyInterfaceHeaderManager.Show(this.CEBPKAAGJPJ());
				}
				if (DPGJIJGOCIC.AHELOLJOHLJ().y > 0.6f)
				{
					this.OGNJFHPEDNN();
				}
				else if (null != this.storyInterfaceHeaderManager)
				{
					this.storyInterfaceHeaderManager.Hide();
				}
			}
		}
		this.GJDIJIAENCJ = false;
		this.PKAPHFPDCCG();
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x001F8634 File Offset: 0x001F6834
	private static void PHICJMOJKKH(List<string> LMPEBGDAGEP, string HJEJJGAFHAM)
	{
		if (HJEJJGAFHAM == null)
		{
			return;
		}
		HJEJJGAFHAM = HJEJJGAFHAM.Replace(" ", "");
		if (HJEJJGAFHAM.Length == 0 || LMPEBGDAGEP.Contains(HJEJJGAFHAM))
		{
			return;
		}
		LMPEBGDAGEP.Add(HJEJJGAFHAM);
	}

	// Token: 0x06004665 RID: 18021 RVA: 0x001F8668 File Offset: 0x001F6868
	private void LADAAACBEIB(string ICAHJJBAEHB, string JINBEAPCPAF, int KILBEPOBMNB)
	{
		if (ICAHJJBAEHB != null && ICAHJJBAEHB.Length > 1)
		{
			if (this.LJNABDDPANA(ICAHJJBAEHB))
			{
				this.GCADKBKMJFP(NGLGPHBGDPD.nonPlayerCharacter, 1113f);
				this.MEBPBAJKLAP(ICAHJJBAEHB);
				this.NFGHFMEEBHN(ICAHJJBAEHB, (FCABOFEGPGP)KILBEPOBMNB, DBONHDHEKDG.immediate, (Ease)52);
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL = ICAHJJBAEHB;
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = KILBEPOBMNB;
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("" + ICAHJJBAEHB);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("spr" + ICAHJJBAEHB);
		}
		if (JINBEAPCPAF != null && JINBEAPCPAF.Length > 1)
		{
			AudioManager.DBFLIEGGGNN().PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.KNBOMEDEPAD(JINBEAPCPAF), 1257f);
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = JINBEAPCPAF;
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ratePopupResult" + JINBEAPCPAF);
	}

	// Token: 0x06004666 RID: 18022 RVA: 0x001F8750 File Offset: 0x001F6950
	private void CBNBDIMFAII()
	{
		if (DNPIKPDMKKI.LEMILALILKP("story") != null && DNPIKPDMKKI.LEMILALILKP("story").NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BCGIONNIFIA(DNPIKPDMKKI.LEMILALILKP("story").OKHMNFLFDOM);
			if (kioojmglclc != null && kioojmglclc.ALFGPLALKCN())
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(DNPIKPDMKKI.LEMILALILKP("story").BDKJOHKAFFO, 0.5f);
			}
		}
		DNPIKPDMKKI.GFEOFIABBKM();
	}

	// Token: 0x06004667 RID: 18023 RVA: 0x001F87C0 File Offset: 0x001F69C0
	private FGINKFGNNEK BFBFBGHBPFM(DOLBFGIPPOG EEPJKGBBBHC)
	{
		for (int i = 0; i < this.LLEHEBBHAOD.Count; i++)
		{
			if (this.LLEHEBBHAOD[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().IsEqual(EEPJKGBBBHC))
			{
				return this.LLEHEBBHAOD[i];
			}
		}
		return null;
	}

	// Token: 0x06004668 RID: 18024 RVA: 0x001F8810 File Offset: 0x001F6A10
	private void LBNCMCAAICC()
	{
		AudioManager.EHBBFMCILPC.FadeMusic(1f, 1f);
		AudioManager.EHBBFMCILPC.KillMusic("", -1f);
		AudioManager.EHBBFMCILPC.KillAmbient("", -1f);
		BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
		base.StartCoroutine(this.AEBANPJGMDI());
	}

	// Token: 0x06004669 RID: 18025 RVA: 0x001F8870 File Offset: 0x001F6A70
	private void OKIHENOGDKD(string OIPOAEPAJHO, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG, bool PCPPCAEJICE)
	{
		bool flag = false;
		bool flag2 = false;
		string text = OIPOAEPAJHO;
		if (this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 3)
		{
			text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(OIPOAEPAJHO);
		}
		if (text.Contains("*"))
		{
			flag2 = true;
			text = text.Replace("*", "");
		}
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(text))
				{
					flag = true;
					if (CHOBEDPLLOG)
					{
						this.FAEEEHDCNDN[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
					}
					else
					{
						this.FAEEEHDCNDN[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
					}
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(text))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.FAEEEHDCNDN[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
				}
				else
				{
					this.FAEEEHDCNDN[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			try
			{
				if (CHOBEDPLLOG && text.Contains("layervideo") && this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 2 && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
				{
					string value = text.Substring(0, text.IndexOf("layer"));
					GameObject gameObject = null;
					for (int j = 0; j < this.KEPHFKAHILM.Count; j++)
					{
						if (this.KEPHFKAHILM[j].gameObject.name.Equals(value))
						{
							gameObject = new GameObject(text);
							gameObject.SetActive(false);
							gameObject.transform.SetParent(this.KEPHFKAHILM[j].gameObject.transform, false);
							gameObject.AddComponent<CanvasGroup>();
							gameObject.layer = LayerMask.NameToLayer("UIEnvironmentsFront");
							StoryEnvironmentLayerManager storyEnvironmentLayerManager = gameObject.AddComponent<StoryEnvironmentLayerManager>();
							storyEnvironmentLayerManager.SetOnDemandResourcesCheckpointIndex(this.KEPHFKAHILM[j].GetOnDemandResourcesCheckpointIndex());
							this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager);
							break;
						}
					}
					if (null == gameObject)
					{
						for (int k = 0; k < this.CHHIBBOICAD.Count; k++)
						{
							if (this.CHHIBBOICAD[k].gameObject.name.Equals(value))
							{
								gameObject = new GameObject(text);
								gameObject.SetActive(false);
								gameObject.transform.SetParent(this.CHHIBBOICAD[k].gameObject.transform, false);
								gameObject.AddComponent<CanvasGroup>();
								gameObject.layer = LayerMask.NameToLayer("UIEnvironmentsFront");
								StoryEnvironmentLayerManager storyEnvironmentLayerManager2 = gameObject.AddComponent<StoryEnvironmentLayerManager>();
								storyEnvironmentLayerManager2.SetOnDemandResourcesCheckpointIndex(this.CHHIBBOICAD[k].GetOnDemandResourcesCheckpointIndex());
								this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager2);
								break;
							}
						}
					}
					if (null != gameObject)
					{
						for (int l = 0; l < this.FAEEEHDCNDN.Count; l++)
						{
							if (!flag2)
							{
								if (this.FAEEEHDCNDN[l].gameObject.name.Equals(text))
								{
									flag = true;
									if (CHOBEDPLLOG)
									{
										this.FAEEEHDCNDN[l].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
									}
									else
									{
										this.FAEEEHDCNDN[l].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
									}
								}
							}
							else if (this.FAEEEHDCNDN[l].gameObject.name.Contains(text))
							{
								flag = true;
								if (CHOBEDPLLOG)
								{
									this.FAEEEHDCNDN[l].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
								}
								else
								{
									this.FAEEEHDCNDN[l].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
								}
							}
						}
					}
					if (!flag)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowHideEnvironmentLayer(), environmentLayer " + text + " not found.");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowHideEnvironmentLayer(), environmentLayer " + text + " not found.");
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600466A RID: 18026 RVA: 0x001F8CD8 File Offset: 0x001F6ED8
	private void FMKKICOINFK(int NLLCKPCKGOH)
	{
		try
		{
			if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.CHOFDAELJIH())
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(NLLCKPCKGOH, -1);
				if (plfdajjhmko != null && plfdajjhmko != this.GKHNIMJJLJL)
				{
					plfdajjhmko.NCAMFPGMCIG.OJHGKJECIBK(0, this.GKHNIMJJLJL.NCAMFPGMCIG.NJEPIPLACPC, this.GKHNIMJJLJL.NCAMFPGMCIG.CFFGADJPBLO, this.GKHNIMJJLJL.NCAMFPGMCIG.EIEIDFBDPKO);
					plfdajjhmko.NCAMFPGMCIG.CMNFNOLANGL(this.GKHNIMJJLJL.NCAMFPGMCIG.GNPAKEFPGPB);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600466B RID: 18027 RVA: 0x001F8D8C File Offset: 0x001F6F8C
	private void AMBEPJCICOF()
	{
		this.LHGNMIOGHGJ = 0f;
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x001F8DB0 File Offset: 0x001F6FB0
	private void IKFEBEDGOIG()
	{
		if (!KDCJJBLGCBH.EHBBFMCILPC.FFDKEENNENC() && !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(16))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeintrobody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn1"), new UnityAction(this.CIBKGEHJKCC), new UnityAction(this.HOJKLCFKFLL), new UnityAction(this.HOJKLCFKFLL), DFGILFBGPLN.popupTools, 0.15f, 28);
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(16);
			return;
		}
		if (KHPGPLAMAIN.EJCNHEBIOJF())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn0") + " (" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontitle").ToLower() + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeintrobody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn1") + " (" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontitle").ToLower() + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeintrobody2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x0600466D RID: 18029 RVA: 0x001F8F5B File Offset: 0x001F715B
	private void CHDPABJGOOC()
	{
		base.StartCoroutine(this.EIJIIEBPOFE(false, false));
	}

	// Token: 0x0600466E RID: 18030 RVA: 0x001F8F6C File Offset: 0x001F716C
	private void ODOPEGPBCCD()
	{
		for (int i = 0; i < this.canvases.Count; i++)
		{
			this.canvases[i].enabled = true;
		}
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x001F8FA4 File Offset: 0x001F71A4
	private void BKCFFNNPOHC()
	{
		if (KGLBKJKNPFD.NIBNMKJIMAD == 1 && null != this.storyChatPrefab && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AABIMKHJJFJ() != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AABIMKHJJFJ().CNLPKOGIJNM();
		}
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x001F8FF8 File Offset: 0x001F71F8
	private void MPKCDMNJBPH()
	{
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("CameraBundlesVFXTopMost"))
			{
				if (null != this.cameras[i].gameObject.GetComponent<BlurOptimized>())
				{
					this.cameras[i].gameObject.GetComponent<BlurOptimized>().enabled = false;
					return;
				}
				break;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x001F9078 File Offset: 0x001F7278
	private void OnDisable()
	{
		if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffects();
		}
		if (null != this.imageEffectsOvr)
		{
			this.imageEffectsOvr.HideAllEffects();
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToOpenLoveInterestsLounge", new UnityAction(this.EPKNCKGNNCE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungePremiumChoicesHistorySuccess", new UnityAction(this.CEPAKBBPHHF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungePremiumChoicesHistoryException", new UnityAction(this.OHCHDKJDMLI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileSaveCutsceneInputCancel", new UnityAction(this.NFOGAJKHADD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileSaveCutsceneInputEndEdit", new UnityAction(this.IKFCJJIMBIJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryManInTheMiddleAttackDetected", new UnityAction(this.BGEHIGPMFEB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderBackClick", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderShopClick", new UnityAction(this.KFGNHIOJGON));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderAvatarClick", new UnityAction(this.MCNFLPPFNEE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderSettingsClick", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderRewindClick", new UnityAction(this.AAPGFNICDAH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPostEffectSettingsChanged", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupClose", new UnityAction(this.EJIFFJPANGA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToRestartGame", new UnityAction(this.CMKPNGPCDAB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToRestartGame2", new UnityAction(this.DNGHLBFEODC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", new UnityAction(this.OCIAMGMLMLG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToShowGameModeNotif", new UnityAction(this.IKFEBEDGOIG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAccountSignInSuccess", new UnityAction(this.GMFFLAFLGHH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnOnDemandResourcesDownloadSuccess", new UnityAction(this.MJODBGBOCOF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnOnDemandResourcesDownloadFailed", new UnityAction(this.GIADKBIIGKK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedPlayNewAmbient", new UnityAction(this.AAPDFHFPILE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedLayerChange", new UnityAction(this.EFCDGMAMICG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedEnvironmentChangeOnInit", new UnityAction(this.BNLOHKAPOAH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedEnvironmentChange", new UnityAction(this.OFLKKJDKNEE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardScreenAssetsDownloadSuccess", new UnityAction(this.AOAIPKJEPFL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardScreenAssetsDownloadFailed", new UnityAction(this.FKAPLBDKMBM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPremiumChoiceRetry", new UnityAction(this.NLBMHEGAMBK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPremiumChoiceException", new UnityAction(this.KOADIHAKPPK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPremiumChoiceSuccess", new UnityAction(this.HBHDBDHBEPD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAchievementSyncSuccess", new UnityAction(this.LBIHJLKIOHH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAchievementSyncException", new UnityAction(this.FKKNKFIFLID));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryCurrencyInfoClick", new UnityAction(this.JNFIBEFKKBO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClick", new UnityAction(this.MNJMFEMJHGI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCollectableDialogCollect", new UnityAction(this.IKOEGDKKEBF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCollectableDialogUsed", new UnityAction(this.CMNOPAIJJDP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCollectableDialogShown", new UnityAction(this.COPCJKBGNCB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnDialogReadInputEndEdit", new UnityAction(this.HBLMNLBCGMD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAccountSave", new UnityAction(this.FACKGDFNJJD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerAssetsDownloadSuccess", new UnityAction(this.BHKOKKMDLAM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarScreenClosed", new UnityAction(this.CEBONOIKIIB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryAdsProviderAdSuccess", new UnityAction(this.OnStoryAdsProviderAdSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupRemoveAdsManagerDismissed", new UnityAction(this.NEEGOLNHIIJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onAvatarScreenLeft, new UnityAction(this.GPNFLDDKLAJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarScreenAssetsDownloadSuccess", new UnityAction(this.OINFFDNGJHF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarScreenAssetsDownloadFailed", new UnityAction(this.GNEIAKDLELG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneLoungeManager.onLoungeScreenLeft, new UnityAction(this.CENEGBNNOOM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungeScreenAssetsDownloadSuccess", new UnityAction(this.DCGMIOFFAMN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungeScreenAssetsDownloadFailed", new UnityAction(this.HJDHHDGNMII));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess", new UnityAction(this.IOIGJPJIBEL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", new UnityAction(this.MBOJMJOEGDH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupRemoveAdsManagerContinueToPurchasingScreen", new UnityAction(this.OPDNFDDHIDB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGetCdnDataForAvatarScreenSuccess", new UnityAction(this.OnGetCdnDataForAvatarScreenSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGetCdnDataForAvatarScreenException", new UnityAction(this.OnGetCdnDataForAvatarScreenException));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGetCdnDataBeforeOnDemandSuccess", new UnityAction(this.OnGetCdnDataBeforeOnDemandSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGetCdnDataBeforeOnDemandException", new UnityAction(this.OnGetCdnDataBeforeOnDemandException));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnVideoLayerAutoHide", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnConsumeEnergySuccess", new UnityAction(this.FGBMKKIFDKD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnConsumeEnergyException", new UnityAction(this.JLPFFPDJALD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnTryToFireNoteshowTimer", new UnityAction(this.OGNJFHPEDNN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFullscreenLiveOfferContinueToPurchasingScreen", new UnityAction(this.GHOHFJCGAMJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPassResourcesChangedType0", new UnityAction(this.BGECHBHBLBM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceButtonUndoClick", new UnityAction(this.MHPPFDJGNHF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnShowStoryHeaderInterfaceGamePassAndUndoButton", new UnityAction(this.NJJEBHJGNOJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendUndoPremiumChoiceException", new UnityAction(this.GEMEKBNAHAO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendUndoPremiumChoiceSuccess", new UnityAction(this.EIBAHCAEHDL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceFastForwardActivate", new UnityAction(this.MJILKOBLFAL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceFastForwardStop", new UnityAction(this.APDAMLCHICH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderShown", new UnityAction(this.JKAABKKGNKP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.IHPFNMOOCLL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderFastForwardEnable", new UnityAction(this.LHJADJAAJOO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderFastForwardDisable", new UnityAction(this.IDLBEHCKBEH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceAutoReaderActivate", new UnityAction(this.BBFANIMJIIK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceAutoReaderStop", new UnityAction(this.DNGIDKHONMB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderAutoReadEnable", new UnityAction(this.NJBECPDOIEE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderAutoReadDisable", new UnityAction(this.GINDNBPIIIG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, new UnityAction(this.MDMJIDKABLD));
		ODJKHCHFKNL.GFEOFIABBKM();
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x001F992C File Offset: 0x001F7B2C
	private IEnumerator CMBJPFEGDLI()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
		yield return new WaitForSeconds(1f);
		this.LBNCMCAAICC();
		yield break;
	}

	// Token: 0x06004673 RID: 18035 RVA: 0x001F993B File Offset: 0x001F7B3B
	private IEnumerator LLIADLBNGBN()
	{
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("achievtutorial"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.COIAOPMCJMA), new UnityAction(this.COIAOPMCJMA), DFGILFBGPLN.popupTools, 0f, 28);
		yield break;
	}

	// Token: 0x06004674 RID: 18036 RVA: 0x001F994C File Offset: 0x001F7B4C
	private void Update()
	{
		this.FDEBLDDCGGB = 0;
		if (!this.GLIMDKBANOI)
		{
			return;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.ALIGDEHMGOP() == 1)
		{
			KGLBKJKNPFD.AFKAMBFMMOH = this.GKHNIMJJLJL.NCAMFPGMCIG.OJCPKGCLEPD();
		}
		else
		{
			KGLBKJKNPFD.AFKAMBFMMOH = -1;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.ALLDBPCKMLF == 1)
		{
			KGLBKJKNPFD.ALLDBPCKMLF = this.GKHNIMJJLJL.NCAMFPGMCIG.ALLDBPCKMLF;
		}
		else
		{
			KGLBKJKNPFD.ALLDBPCKMLF = 0;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD == 1 && null != this.storyChatPrefab)
		{
			KGLBKJKNPFD.NIBNMKJIMAD = this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD;
		}
		else
		{
			KGLBKJKNPFD.NIBNMKJIMAD = 0;
		}
		if (this.GKHNIMJJLJL != null)
		{
			KGLBKJKNPFD.FIMJIINAFFK = this.GKHNIMJJLJL.NCAMFPGMCIG.FIMJIINAFFK;
			KGLBKJKNPFD.DMAGAHMIKDE = this.GKHNIMJJLJL.NCAMFPGMCIG.DMAGAHMIKDE;
		}
		else
		{
			KGLBKJKNPFD.FIMJIINAFFK = 0;
			KGLBKJKNPFD.DMAGAHMIKDE = -1;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.IOLCAAOOOCN() >= 2)
		{
			OCCBADNHFHK.KHBNNKGNNGJ = true;
		}
		else
		{
			OCCBADNHFHK.KHBNNKGNNGJ = false;
		}
		this.HFOPCMIHDOL.IIPBKOPAGBK();
		this.CMINODMJCPI();
		this.JAPJDIMHOIB();
		this.PBFBEEGCFHF();
		if (AssetsManager.EHBBFMCILPC.GetOperationState() != JLINKDNLADM.Failed)
		{
			CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress(AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().AHPMFHMACME());
		}
		if (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			if (this.LHGNMIOGHGJ >= (float)KBOJLHAJPCP.NGPHPLGAPHG)
			{
				if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("longdownloadhint"), DFGILFBGPLN.popupTools, 0f, 28);
				}
			}
			else if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				this.LHGNMIOGHGJ += Time.deltaTime;
			}
		}
		else
		{
			this.LHGNMIOGHGJ = 0f;
		}
		if (this.MINLCJENJIB >= 0f)
		{
			this.MINLCJENJIB -= Time.deltaTime;
		}
	}

	// Token: 0x06004675 RID: 18037 RVA: 0x001F9B70 File Offset: 0x001F7D70
	private void CEBONOIKIIB()
	{
		if (this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN == KGLBKJKNPFD.LBFFMOMMAPK.avatarSetup && this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().BOPJOMGIJIA == INPPHKFPFLO.BMHGEBOHLHH.avatarConfig)
		{
			this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
		}
		if (this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN != KGLBKJKNPFD.LBFFMOMMAPK.avatarSetup && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL.Length > 0 && this.HFFIIBBJBMH.header.ambientFreeAudio)
		{
			AudioManager.EHBBFMCILPC.PlayMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL, true, 1f, false);
		}
		if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.FKLHOKAGBJN("blur"))
		{
			this.imageEffects.HideAllEffectsWithTag("blur");
		}
		AudioManager.EHBBFMCILPC.FadeMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NPAFPMIMGLH, 1f);
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
	}

	// Token: 0x06004676 RID: 18038 RVA: 0x001F9C98 File Offset: 0x001F7E98
	public void OnBackClick()
	{
		if (this.MCIGJBFKOIJ)
		{
			return;
		}
		this.MCIGJBFKOIJ = true;
		this.MBBFJHBFPNB = true;
		this.LPCBDEBKAIM();
		AudioManager.EHBBFMCILPC.FadeMusic(1f, 1f);
		AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		AudioManager.EHBBFMCILPC.KillAmbient("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnBackClickPart2));
		if (!EEIBKLDNBAP.ALFGPLALKCN())
		{
			BackendOperationsManager.EHBBFMCILPC.RequestLoadDefaultBundles("OnBackendGetDefaultBundlesSuccess", "OnBackendGetDefaultBundlesException", true);
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		AdsManagerLP.EHBBFMCILPC.RefreshAdUnits();
		ApplicationFocusManager.Deactivate();
	}

	// Token: 0x06004677 RID: 18039 RVA: 0x001F9D74 File Offset: 0x001F7F74
	public void OnReadyToWatchIntrusiveAd()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (AdsManagerLP.EHBBFMCILPC.IsReadyNonRewarded())
		{
			AdsManagerLP.EHBBFMCILPC.ShowAdNonRewarded("OnStoryAdsProviderAdSuccess", "OnStoryAdsProviderAdSuccess", "OnStoryAdsProviderAdSuccess");
		}
		else
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryAdsProviderAdSuccess", 0.1f);
		}
		AKLFPGMDKLA.EHBBFMCILPC.OBBFGMHLMHO = 0;
		this.HPBFGMAFKDD = 0;
	}

	// Token: 0x06004678 RID: 18040 RVA: 0x001F9DE8 File Offset: 0x001F7FE8
	private void CJJLCCONOJE()
	{
		string lfmcdfbankd = AOBJLALDBAA.AGANFKKBPFO().FCCJMMNBEAI();
		base.StartCoroutine(this.MDNEDHHGBCO(lfmcdfbankd, true));
	}

	// Token: 0x06004679 RID: 18041 RVA: 0x001F9E0F File Offset: 0x001F800F
	private void OEHEOHDOCGO(bool NIEJFHHKNGN)
	{
		if (NIEJFHHKNGN && this.KKIGOAKNCIE >= 0)
		{
			return;
		}
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null && ODLJHDIGLGO.NEABBOKICBA(CLHDENLPOFP.gamePass).CGOECMIINGM())
		{
			this.KBBPBKJEFCJ();
			this.KKIGOAKNCIE++;
		}
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x001F9E47 File Offset: 0x001F8047
	private void JCNICMFKAOL()
	{
		this.playerCharacterOffscreenRenderCamera.gameObject.SetActive(false);
		this.playerCharacterRenderTextureCanvas.enabled = false;
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x001F9E68 File Offset: 0x001F8068
	private float CEBPKAAGJPJ()
	{
		try
		{
			if (this.PKKPMENAIGC.Length > 12 && this.GLLFKOJEBPC.Length > 12 && this.PEGKFFIEEEF > 0)
			{
				string text = this.GLLFKOJEBPC;
				string text2 = this.PKKPMENAIGC;
				text2 = text2.Replace("\n", "").Replace("\r", "").Replace("\"", "\\\"");
				text2 = text2.Substring(0, text2.Length - 1);
				text = text.Replace("\n", "").Replace("\r", "").Replace("\"", "\\\"");
				text = text.Substring(0, text.Length - 1);
				int num = this.IFLGCDMCEGD.IndexOf(text2);
				int num2 = this.IFLGCDMCEGD.IndexOf(text);
				if (num < 0)
				{
					text2 = text2.Replace(",", "،");
					text2 = text2.Replace("(", "〈");
					text2 = text2.Replace(")", "〉");
					num = this.IFLGCDMCEGD.IndexOf(text2);
				}
				if (num2 < 0)
				{
					text = text.Replace(",", "،");
					text = text.Replace("(", "〈");
					text = text.Replace(")", "〉");
					num2 = this.IFLGCDMCEGD.IndexOf(text);
				}
				if (num < 0 && num2 < 0 && this.INIEOPFGBEG.Length > 24 && this.BHCPLGJJOPA.Length > 24)
				{
					string text3 = this.BHCPLGJJOPA;
					string text4 = this.INIEOPFGBEG;
					text4 = text4.Replace("\n", "").Replace("\r", "");
					text4 = text4.Substring(0, text4.Length - 1);
					text3 = text3.Replace("\n", "").Replace("\r", "");
					text3 = text3.Substring(0, text3.Length - 1);
					num = this.IFLGCDMCEGD.IndexOf(text4);
					num2 = this.IFLGCDMCEGD.IndexOf(text3);
					if (num < 0)
					{
						text4 = text4.Replace(",", "،");
						text4 = text4.Replace("(", "〈");
						text4 = text4.Replace(")", "〉");
						num = this.IFLGCDMCEGD.IndexOf(text4);
					}
					if (num2 < 0)
					{
						text3 = text3.Replace(",", "،");
						text3 = text3.Replace("(", "〈");
						text3 = text3.Replace(")", "〉");
						num2 = this.IFLGCDMCEGD.IndexOf(text3);
					}
				}
				if (num > 0 && num2 > 0 && Mathf.Abs(num2 - num) < 4096)
				{
					this.PKKPMENAIGC = "";
					this.INIEOPFGBEG = "";
					if (num <= this.PEGKFFIEEEF && num2 <= this.PEGKFFIEEEF)
					{
						float num3 = (float)((num + num2) / 2) / (float)this.PEGKFFIEEEF;
						if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CHHLDEBHDPE > 1f)
						{
							if (num3 > 1f && num3 > AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CHHLDEBHDPE)
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CHHLDEBHDPE = num3;
							}
						}
						else
						{
							AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CHHLDEBHDPE = num3;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CHHLDEBHDPE;
	}

	// Token: 0x0600467C RID: 18044 RVA: 0x001FA234 File Offset: 0x001F8434
	public static bool AchievementIsUnlocked(string JJJGEOBAMDI, JSONArray HJMCHDMMHIO)
	{
		if (SceneStoryManager.achievements.Count > 0)
		{
			int mefkfohcohk = int.Parse(JJJGEOBAMDI.Substring(JJJGEOBAMDI.IndexOf("id") + 2));
			int num = int.Parse(JJJGEOBAMDI.Substring(0, JJJGEOBAMDI.IndexOf("id")).Replace("a", ""));
			for (int i = 0; i < HJMCHDMMHIO.Count; i++)
			{
				FHHNOOKHGCE fhhnookhgce = new FHHNOOKHGCE();
				fhhnookhgce.HELBJBBCBHG(HJMCHDMMHIO[i]);
				if (fhhnookhgce.IFCHGNCDMLJ == num && fhhnookhgce.MDFHILDNGKK(mefkfohcohk))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x001FA2CC File Offset: 0x001F84CC
	private void FGBOHIGNOAD()
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.JCGPMCONNBM.Count; i++)
		{
			list.Add(this.JCGPMCONNBM[i]);
		}
		this.JCGPMCONNBM.Clear();
		base.StartCoroutine(this.IINJKALCHKG(list));
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x001FA320 File Offset: 0x001F8520
	private void DNGHLBFEODC()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x0600467F RID: 18047 RVA: 0x001FA388 File Offset: 0x001F8588
	public void UpdateTopMatchData()
	{
		if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL == null || this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count <= 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("UpdateTopMatchData(): currentStorySave.body.topMatch.Count == 0");
			return;
		}
		if (null == AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			return;
		}
		JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
		if (null == jsonarray)
		{
			return;
		}
		for (int i = 0; i < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; i++)
		{
			if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].OMEEKCMIEJM >= 0)
			{
				try
				{
					JSONObject asObject = jsonarray[this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].OMEEKCMIEJM].AsObject;
					if (asObject["ant"].AsInt != this.HFFIIBBJBMH.header.index)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("UpdateTopMatchData(): topMatchAnthology != currentAnthology.header.index");
						this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
					}
					else
					{
						string text = asObject["var"];
						text = text.Replace(" ", "");
						string text2 = asObject["max"];
						text2 = text2.Replace(" ", "");
						if (text.Length == 0 || text2.Length == 0)
						{
							this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
						}
						else
						{
							List<int> activeWardrobeMixList = SceneStoryManager.GetActiveWardrobeMixList();
							bool flag;
							if (activeWardrobeMixList != null)
							{
								flag = (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PDKKPKCAILC < 0 || activeWardrobeMixList.Contains(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PDKKPKCAILC));
							}
							else
							{
								flag = (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME == this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PDKKPKCAILC || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME < 0 || this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PDKKPKCAILC < 0);
							}
							if (!flag)
							{
								this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
							}
							else if (this.HFFIIBBJBMH.header.CJJOGBNCCCH(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.GGICIBLJIKI) >= this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].KJNJOOHIBDF)
							{
								if (this.HFFIIBBJBMH.header.CJJOGBNCCCH(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.GGICIBLJIKI) == this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].KJNJOOHIBDF && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0] < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].DNOIMFDKCEM)
								{
									this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
								}
								else if (!ONEHEBIHPFB.GJBMBHGKNHN(text))
								{
									this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 1;
									try
									{
										for (int j = 0; j < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; j++)
										{
											if (i != j && this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB == 1 && this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PPACJFFFBFB == 1 && this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].DKDECIHBGJE().Equals(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].DKDECIHBGJE()))
											{
												if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].BIBKFNMPHIK >= this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].BIBKFNMPHIK)
												{
													this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PPACJFFFBFB = 0;
												}
												else
												{
													this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
												}
												if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP == 1 || this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].MJKICDJIFIP == 1)
												{
													this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP = (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].MJKICDJIFIP = 1);
												}
											}
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
									}
								}
								else
								{
									float num = (float)asObject["max"].AsInt;
									float num2 = (float)ONEHEBIHPFB.HPFKIKJIGNF(text);
									this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PHIEEHJCHAK = (int)(100f * num2 / num);
									this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PHIEEHJCHAK = Math.Clamp(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PHIEEHJCHAK, 0, 100);
									if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PHIEEHJCHAK > this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].BIBKFNMPHIK)
									{
										this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].KDODAAICNDO = 1;
									}
									else if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PHIEEHJCHAK < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].BIBKFNMPHIK)
									{
										this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].KDODAAICNDO = -1;
									}
									else
									{
										this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].KDODAAICNDO = 0;
									}
									string text3 = asObject["varCondition"];
									text3 = text3.Replace(" ", "");
									int asInt = asObject["varConditionValue"].AsInt;
									string text4 = asObject["varConditionLocked"];
									text4 = text4.Replace(" ", "");
									int asInt2 = asObject["varConditionLockedValue"].AsInt;
									if (text3.Length > 0)
									{
										if (ONEHEBIHPFB.GJBMBHGKNHN(text3))
										{
											if (ONEHEBIHPFB.HPFKIKJIGNF(text3) == asInt)
											{
												this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 1;
											}
											else
											{
												this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
											}
										}
										else
										{
											this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
										}
									}
									else
									{
										this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 1;
									}
									if (text4.Length > 0 && ONEHEBIHPFB.GJBMBHGKNHN(text4))
									{
										if (ONEHEBIHPFB.HPFKIKJIGNF(text4) == asInt2)
										{
											this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP = 1;
										}
										else
										{
											this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP = 0;
										}
									}
									else
									{
										this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP = 0;
									}
									try
									{
										for (int k = 0; k < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; k++)
										{
											if (i != k && this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB == 1 && this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[k].PPACJFFFBFB == 1 && this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].DKDECIHBGJE().Equals(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[k].DKDECIHBGJE()))
											{
												if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].BIBKFNMPHIK >= this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[k].BIBKFNMPHIK)
												{
													this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[k].PPACJFFFBFB = 0;
												}
												else
												{
													this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
												}
												if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP == 1 || this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[k].MJKICDJIFIP == 1)
												{
													this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].MJKICDJIFIP = (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[k].MJKICDJIFIP = 1);
												}
											}
										}
									}
									catch (Exception aklgbjkdomm2)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
									}
								}
							}
							else
							{
								this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
							}
						}
					}
				}
				catch (Exception aklgbjkdomm3)
				{
					this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB = 0;
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
				}
			}
		}
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x001FADCC File Offset: 0x001F8FCC
	private bool MPHBLJIACJI()
	{
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x001FAE0C File Offset: 0x001F900C
	private void LBIHJLKIOHH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (SceneStoryManager.achievementSyncReward > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("youreceived"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.AADJGGEMOJD), new UnityAction(this.AADJGGEMOJD), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamonds(SceneStoryManager.achievementSyncReward);
			return;
		}
		this.AADJGGEMOJD();
	}

	// Token: 0x06004682 RID: 18050 RVA: 0x001FAE94 File Offset: 0x001F9094
	private void EMBJDGJMJHA(string OKDNLCOEOIJ)
	{
		try
		{
			if (OKDNLCOEOIJ == null || OKDNLCOEOIJ.Length == 0)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] $REMOVESUPERMAPPING with an empty id() - ignored");
			}
			else
			{
				string fbkapcppnka = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GLBDHEKDNDC(OKDNLCOEOIJ);
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.EAHMPCPAMOF(OKDNLCOEOIJ);
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				this.ReleaseSuperMappedLookNpcAnimationPacks(fbkapcppnka);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004683 RID: 18051 RVA: 0x001FAF10 File Offset: 0x001F9110
	private void NEEGOLNHIIJ()
	{
		if (this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN == KGLBKJKNPFD.LBFFMOMMAPK.environmentSet && this.HFOPCMIHDOL.HJOANJHIHAI().JPHIPBEBNGD().BOPJOMGIJIA == OHAAGENIEMD.BMHGEBOHLHH.waitingForRemoveAdsOfferResponse)
		{
			this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
		}
	}

	// Token: 0x06004684 RID: 18052 RVA: 0x001FAF64 File Offset: 0x001F9164
	private bool EPPLEFDBBAM(string KHJMANDEDMA)
	{
		string value = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.name.Equals(value) && this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004685 RID: 18053 RVA: 0x001FAFD2 File Offset: 0x001F91D2
	public void OnBackClickPart2()
	{
		SceneManager.LoadScene("SceneTransitionToLobby");
	}

	// Token: 0x06004686 RID: 18054 RVA: 0x001FAFDE File Offset: 0x001F91DE
	public static List<int> MNGLGGGJLEA()
	{
		return SceneStoryManager.GetActiveWardrobeMixList(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
	}

	// Token: 0x06004687 RID: 18055 RVA: 0x001FAFEF File Offset: 0x001F91EF
	private void JOKJBAIECCA(bool COHPEIPNOMM)
	{
		if (null != this.FNHFGLHODBG)
		{
			this.FNHFGLHODBG.SetState(COHPEIPNOMM);
		}
		if (null != this.KOCJONIGKNH)
		{
			this.KOCJONIGKNH.SetState(COHPEIPNOMM);
		}
	}

	// Token: 0x06004688 RID: 18056 RVA: 0x000AD70A File Offset: 0x000AB90A
	private void GMFFLAFLGHH()
	{
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x06004689 RID: 18057 RVA: 0x001FB028 File Offset: 0x001F9228
	private void GJNPKGALKGG()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.MCIGJBFKOIJ = true;
		ApplicationFocusManager.Restore();
		this.ODOPEGPBCCD();
		this.ANPFJKKHIJG();
		this.GOLDLGPECBJ();
		this.KBBPBKJEFCJ();
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL.Length > 1 && this.HFFIIBBJBMH.header.ambientFreeAudio)
		{
			AudioManager.IFDLAMLHKIJ().HBMNHHMJIEP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL, false, 6f, false);
		}
		AudioManager.APGODIBBPOD().KLLPGEAGBLA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NPAFPMIMGLH, 919f);
		this.IDLBNMFGLKE();
		this.AIGBJLAPFLH();
		base.StartCoroutine(this.PCNKEKEMDKJ());
	}

	// Token: 0x0600468A RID: 18058 RVA: 0x001FB105 File Offset: 0x001F9305
	public void OnGetCdnDataBeforeOnDemandSuccess()
	{
		this.KFFKDDGBLBD();
	}

	// Token: 0x0600468B RID: 18059 RVA: 0x001FB110 File Offset: 0x001F9310
	public void PromoteLoungeNpcAssetToChapterLifetime(string NHKFAAIIPKM)
	{
		for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
		{
			if (((this.ODNCKIKLFCM[i].id != null && this.ODNCKIKLFCM[i].id.Equals(NHKFAAIIPKM)) || (this.ODNCKIKLFCM[i].idAka != null && this.ODNCKIKLFCM[i].idAka.Equals(NHKFAAIIPKM))) && this.ODNCKIKLFCM[i].KBDAEIHELPE() >= 0)
			{
				this.ODNCKIKLFCM[i].GFFPDIBOIIK(-1);
			}
		}
	}

	// Token: 0x0600468C RID: 18060 RVA: 0x001FB1C0 File Offset: 0x001F93C0
	private void KIPNOKOPJMI(DOLBFGIPPOG EEPJKGBBBHC, string CCKEOHHEKFF, FLNOFHCNJDM GFIMGNJBJHH, FLNOFHCNJDM PMDGGEDPHJC)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		GameObject gameObject = null;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.GetOrCreate();
			if (null != this.EBHJLLIHIFE)
			{
				RectTransform component = this.nonPlayerCharacterPivot.GetComponent<RectTransform>();
				ahlneabnmoa = this.EBHJLLIHIFE.AcquirePlayerCharacter(component, component);
			}
			PlayerCharacterManager playerCharacterManager;
			if (ahlneabnmoa != null)
			{
				gameObject = ahlneabnmoa.JAGHCEBFABP;
				gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
				gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(-1f, 1f, 1f);
				playerCharacterManager = ahlneabnmoa.GOAEECPPHIB;
				playerCharacterManager.InitializeFromSaveData(EEPJKGBBBHC, EBFHKCOGJLB.left, ahlneabnmoa.AJDMCHIOJAK);
			}
			else
			{
				gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
				gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
				gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(-1f, 1f, 1f);
				playerCharacterManager = gameObject.GetComponent<PlayerCharacterManager>();
				playerCharacterManager.InitializeFromSaveData(EEPJKGBBBHC, EBFHKCOGJLB.left, null);
				gameObject.transform.SetParent(this.nonPlayerCharacterPivot.transform, false);
			}
			playerCharacterManager.AnimateAppearance(BKBCKPMDFOD.animationChoiceMetaAppearFromRight);
			playerCharacterManager.SetEmotion(GFIMGNJBJHH, KBACNADIIDP.appearDelayed, PMDGGEDPHJC);
			this.NALOEFHHCCH.Add(this.GLDAJFNCFKC(CCKEOHHEKFF, gameObject));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			bool flag = false;
			for (int i = 0; i < this.NALOEFHHCCH.Count; i++)
			{
				if (null != gameObject && this.NALOEFHHCCH[i].IACFDHCDEME == gameObject)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				if (null != this.EBHJLLIHIFE && ahlneabnmoa != null)
				{
					this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
				}
				else if (null != gameObject)
				{
					UnityEngine.Object.Destroy(gameObject);
				}
			}
			throw;
		}
	}

	// Token: 0x0600468D RID: 18061 RVA: 0x001FB35C File Offset: 0x001F955C
	public static bool AnyShopRowListedInShopMode(int PLKMJJIIJNO)
	{
		try
		{
			FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(PLKMJJIIJNO);
			if (fjlgcknojmj == null)
			{
				return false;
			}
			for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
			{
				for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
				{
					if (SceneStoryManager.LoungeMappingListedInShopMode(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j]))
					{
						return true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600468E RID: 18062 RVA: 0x001FB3FC File Offset: 0x001F95FC
	public void HMLJPBFKGIP()
	{
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().profileDataAsset))
			{
				JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
				if (!(null == jsonarray))
				{
					List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
					this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
					PLFDAJJHMKO gkhnimjjljl = this.GKHNIMJJLJL;
					for (int i = jsonarray.Count - 1; i >= 1; i--)
					{
						JSONObject asObject = jsonarray[i].AsObject;
						int asInt = asObject["OnStorySplashManagerAssetBundleFolderInitializeSuccess"].AsInt;
						if (asInt == this.HFFIIBBJBMH.header.index)
						{
							string text = asObject["YYY"];
							text = text.Replace("Swipe tutorial shown, frames:", "@");
							string text2 = asObject["_DistortionSteps"];
							text2 = text2.Replace(" holds ", "");
							string text3 = asObject["ok"];
							text3 = text3.Replace("High version preview2 assets loaded:", "MMM");
							if (text.Length != 0 && text3.Length != 0)
							{
								int asInt2 = asObject["avatarcollectionsalltitle"].AsInt;
								string text4 = text;
								string text5 = gkhnimjjljl.NCAMFPGMCIG.JLANBLCOLNI(ref text4);
								try
								{
									IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
									float num = 1728f;
									if (text5 != null && text5.Length > 0)
									{
										num = (float)int.Parse(text5);
									}
									float num2 = (float)asInt2;
									immkfhkeebf.BIBKFNMPHIK = (int)(1192f * num / num2);
									immkfhkeebf.BIBKFNMPHIK = Math.Clamp(immkfhkeebf.BIBKFNMPHIK, 0, -101);
									immkfhkeebf.ODGNIFJGEHL = text + asInt.ToString();
									immkfhkeebf.PFFCLABCNHI = text2;
									immkfhkeebf.PPACJFFFBFB = 1;
									immkfhkeebf.MJKICDJIFIP = 0;
									immkfhkeebf.OMEEKCMIEJM = i;
									if (asObject["mine"] != null)
									{
										immkfhkeebf.KJNJOOHIBDF = asObject["skuAuto"].AsInt;
									}
									if (asObject["words"] != null)
									{
										immkfhkeebf.DNOIMFDKCEM = asObject[""].AsInt;
									}
									if (asObject["</i>"] != null)
									{
										immkfhkeebf.PDKKPKCAILC = asObject["anthologiestitle"].AsInt;
									}
									list.Add(immkfhkeebf);
								}
								catch (Exception aklgbjkdomm)
								{
									DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
								}
							}
						}
					}
					int num3 = 1;
					while (list.Count > 0)
					{
						int num4 = -1;
						int num5 = -1;
						for (int j = 0; j < list.Count; j++)
						{
							if (list[j].BIBKFNMPHIK > num4)
							{
								num4 = list[j].BIBKFNMPHIK;
								num5 = j;
							}
						}
						if (num5 >= 1)
						{
							this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Add(list[num5]);
							list.RemoveAt(num5);
						}
						num3++;
						if (num3 > 167)
						{
							break;
						}
					}
					DPGJIJGOCIC.CMGOAFDBAOH("+" + num3.ToString());
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x001FB75C File Offset: 0x001F995C
	private void BHFGFBKNLOM()
	{
		this.HAFFEDMEIAF = false;
		int ajpngblhoec = -76;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != CEIBHCNNIDC.en)
		{
			ajpngblhoec = -87;
		}
		this.GKHNIMJJLJL.PPBDMCOPPPD();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.LMLMBINLJHM();
		}
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverrideGreen(CCOJBMMKNAP.BOFMCPPFAMO().DNILNCLIHAP("rid"), CCOJBMMKNAP.EHBBFMCILPC.IKMNGFIDCLM("NEWSAVE: Error: tempAnthologySave is null for story index "), CCOJBMMKNAP.COKDLDOAACJ().OHLNGCKIACD("hacomp"), CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA("anm"), new UnityAction(this.IJKFOHENBDA), new UnityAction(this.BMFMDBHJDMI), new UnityAction(this.ADNEJCGMIHK), (DFGILFBGPLN)(-55), 999f, -38).MHMHGHCDHGE().MJGMOLANPEG(ajpngblhoec);
	}

	// Token: 0x06004690 RID: 18064 RVA: 0x001FB824 File Offset: 0x001F9A24
	private bool CILHBPNJDFA(int OLKMHHNMDLP, int GPIKAPMPCNL, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (OLKMHHNMDLP >= this.NJAAOCMPKCD.chapterAssetPacks.Count)
		{
			return false;
		}
		for (int i = 0; i < this.NJAAOCMPKCD.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count; i++)
		{
			if (this.NJAAOCMPKCD.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[i].revision == GPIKAPMPCNL)
			{
				for (int j = 0; j < this.NJAAOCMPKCD.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[i].supportedLanguages.Count; j++)
				{
					if (NIIIMDHGGEN == this.NJAAOCMPKCD.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[i].supportedLanguages[j])
					{
						return true;
					}
				}
				break;
			}
		}
		return false;
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x001FB8F8 File Offset: 0x001F9AF8
	private void KOADIHAKPPK()
	{
		this.BODLAMJCHJO = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.NLBMHEGAMBK), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x001FB97C File Offset: 0x001F9B7C
	private bool JGPIOKPMGDG(int MEFKFOHCOHK)
	{
		if (null == this.NJAAOCMPKCD || this.NJAAOCMPKCD.chapterAssetPacks == null || this.HODJEPIPDFH < 0 || this.HODJEPIPDFH >= this.NJAAOCMPKCD.chapterAssetPacks.Count)
		{
			return false;
		}
		List<int> npcAnimationPacks = this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH].npcAnimationPacks;
		return npcAnimationPacks != null && npcAnimationPacks.Contains(MEFKFOHCOHK);
	}

	// Token: 0x06004693 RID: 18067 RVA: 0x001FB9F0 File Offset: 0x001F9BF0
	private void CMINODMJCPI()
	{
		for (int i = 0; i < this.KICOPFEHKJF.Count; i++)
		{
			if (this.KICOPFEHKJF[i] != null && null != this.KICOPFEHKJF[i].IACFDHCDEME)
			{
				ChoiceExtendedManager component = this.KICOPFEHKJF[i].IACFDHCDEME.GetComponent<ChoiceExtendedManager>();
				if (null != component)
				{
					component.UpdateSwipeToBrowse();
				}
			}
		}
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x001FBA60 File Offset: 0x001F9C60
	private void ABDHFNHFBMP(PMNHKIDIMLM GAILKDGBMPD)
	{
		try
		{
			if (GAILKDGBMPD != null && GAILKDGBMPD.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.npc)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count != 0)
				{
					for (int i = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count - 1; i >= 0; i--)
					{
						string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG[i];
						DMDNKJKEPKO dmdnkjkepko = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DLCFCKOCIGB(text);
						int num = 0;
						for (int j = 0; j < GAILKDGBMPD.AOANDELCCEL.Count; j++)
						{
							string text2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OBFABLFHPMP(GAILKDGBMPD.AOANDELCCEL[j].COOOGACBAKN);
							if (text.Equals(GAILKDGBMPD.AOANDELCCEL[j].COOOGACBAKN) || text.Equals(text2) || (dmdnkjkepko != null && (dmdnkjkepko.GGGHIJNOHAK(GAILKDGBMPD.AOANDELCCEL[j].COOOGACBAKN) || dmdnkjkepko.GGGHIJNOHAK(text2))))
							{
								num++;
							}
						}
						if (GAILKDGBMPD.AOANDELCCEL.Count >= 2 && num == GAILKDGBMPD.AOANDELCCEL.Count)
						{
							string fbkapcppnka = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GLBDHEKDNDC(text);
							AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.EAHMPCPAMOF(text);
							this.ReleaseSuperMappedLookNpcAnimationPacks(fbkapcppnka);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004695 RID: 18069 RVA: 0x001FBC18 File Offset: 0x001F9E18
	private IEnumerator AEBANPJGMDI()
	{
		if (StarRatingSelector.lastRating > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ratethankyou"), 96);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
		}
		yield return new WaitForSeconds(1.5f);
		AssetsManager.EHBBFMCILPC.CleanupDownloadQueue();
		int afennobclfn = -1;
		if (this.HFFIIBBJBMH.header.rewardSceneIndices != null && this.HFFIIBBJBMH.header.rewardSceneIndices.Count > 0)
		{
			int num = -1;
			for (int i = 0; i < this.HFFIIBBJBMH.header.availableStories.Count; i++)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI)
				{
					num = i;
					break;
				}
			}
			if (num >= 0 && num < this.HFFIIBBJBMH.header.rewardSceneIndices.Count && this.HFFIIBBJBMH.header.rewardSceneIndices[num] >= 0)
			{
				afennobclfn = this.HFFIIBBJBMH.header.rewardSceneIndices[num];
			}
		}
		try
		{
			if (null != this.NJAAOCMPKCD && this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH].customRewardSceneIndex >= 0)
			{
				afennobclfn = this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH].customRewardSceneIndex;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.IOIBPOKHBHD >= 0)
		{
			afennobclfn = this.IOIBPOKHBHD;
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyReward, this.HFFIIBBJBMH.header.CKACBBGHJGI(), afennobclfn, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		this.LHGNMIOGHGJ = 0f;
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnRewardScreenAssetsDownloadSuccess", "OnRewardScreenAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06004696 RID: 18070 RVA: 0x001FBC27 File Offset: 0x001F9E27
	private void MEKNONIOLGP()
	{
		this.MPKCDMNJBPH();
	}

	// Token: 0x06004697 RID: 18071 RVA: 0x001FBC30 File Offset: 0x001F9E30
	private void ANNDEKNDDEB()
	{
		this.BODLAMJCHJO = false;
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (this.HFOPCMIHDOL.NEOIHFPBBCP() == null)
		{
			this.GKHNIMJJLJL.PPBDMCOPPPD();
			return;
		}
		if (SceneStoryManager.premiumChoiceManInTheMiddleAttack == 1)
		{
			this.GKHNIMJJLJL.PPBDMCOPPPD();
			return;
		}
		if (SceneStoryManager.premiumChoiceBackendOperationResult >= 0)
		{
			if (SceneStoryManager.premiumChoiceBackendOperationResultKey.Length > 0)
			{
				this.GKHNIMJJLJL.BPNNGAEGIDP(SceneStoryManager.premiumChoiceBackendOperationResult, SceneStoryManager.premiumChoiceBackendOperationResult2, SceneStoryManager.premiumChoiceBackendOperationResultKey);
			}
			else
			{
				this.GKHNIMJJLJL.PFHCDMOJOKP();
			}
			AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("p", 695f);
			if (this.ILJAFHPEKDC)
			{
				AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("p", 1345f);
			}
			else
			{
				AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("Starting parallel download:", 1249f);
			}
			if (this.JGEDOIDOPLA != null)
			{
				if (this.HFOPCMIHDOL.FPKLAKCOHIA().ONECLDMJKEE().EKOIFOBAHDM() < this.JGEDOIDOPLA.KAJNELPPCIJ.Count)
				{
					List<string> collection = this.JGEDOIDOPLA.MKPMEKKGEIL[this.HFOPCMIHDOL.ICCKBEPPKDJ().ONECLDMJKEE().EKOIFOBAHDM()].JMAAJGGCOEE();
					SceneStoryManager.freePremiumChoicesFallback.AddRange(collection);
				}
			}
			else if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.PLNMMCEBJGO().ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.KAJNELPPCIJ.Count)
			{
				List<string> collection2 = this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()].PKKENNAKGGC();
				SceneStoryManager.freePremiumChoicesFallback.AddRange(collection2);
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.energy) != 0)
			{
				if (this.JGEDOIDOPLA != null)
				{
					if (this.HFOPCMIHDOL.ABJAMADKAEG().ONECLDMJKEE().EKOIFOBAHDM() < this.JGEDOIDOPLA.KAJNELPPCIJ.Count && AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0)
					{
					}
				}
				else if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.LGEKNFFAJHF().ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.KAJNELPPCIJ.Count)
				{
					int klpbigjbobe = AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE;
				}
			}
			for (int i = 0; i < SceneStoryManager.choiceSecurityIdList.Count; i++)
			{
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKHJLJJJDAA(SceneStoryManager.choiceSecurityIdList[i], SceneStoryManager.choiceSecurityKeyList[i]);
			}
			this.HFOPCMIHDOL.FPKLAKCOHIA().FEHODJMIAJL(1779f, 0);
			return;
		}
		this.GKHNIMJJLJL.PPBDMCOPPPD();
		CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.INKJIBDDMLL().MEPECBDCOLG("noisedigitalovr_2"), CCOJBMMKNAP.FEEDGKCJBLE().MEPECBDCOLG("OnPopupStoryRestartManagerRestartStory"), CCOJBMMKNAP.HEDIEIICOOG().JCDFHKDNEDH("/"), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyDecline), (DFGILFBGPLN)(-56), 1553f, 115).ECCFLOFCFNN(SceneStoryManager.premiumChoiceBackendOperationResult);
	}

	// Token: 0x06004698 RID: 18072 RVA: 0x001FBF1C File Offset: 0x001FA11C
	private bool NJFGACHFENE()
	{
		int num = 1;
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i += 0)
		{
			if (null != this.FAEEEHDCNDN[i] && this.FAEEEHDCNDN[i].gameObject.name.Contains("usynachtk") && !this.FAEEEHDCNDN[i].gameObject.name.Contains("") && this.FAEEEHDCNDN[i].gameObject.activeSelf)
			{
				num += this.FAEEEHDCNDN[i].FJMPAOOMDGK();
			}
		}
		return num > 1;
	}

	// Token: 0x06004699 RID: 18073 RVA: 0x001FBFD0 File Offset: 0x001FA1D0
	private void IGHFKBDKAED()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = AOBJLALDBAA.NMGMNAKLLMI().BMFAMELDAIL();
		AudioManager.IFDLAMLHKIJ().NIJLAJDLDJD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO, 1016f);
	}

	// Token: 0x0600469A RID: 18074 RVA: 0x001FC020 File Offset: 0x001FA220
	public void OHJJJMKCFIC()
	{
		SceneManager.LoadScene("actant");
	}

	// Token: 0x0600469B RID: 18075 RVA: 0x001FC02C File Offset: 0x001FA22C
	private void HKEMJLNFCFF()
	{
		string text = AOBJLALDBAA.NMGMNAKLLMI().CLCKLHEDEBJ();
		string[] array = new string[]
		{
			null,
			"congratstitle"
		};
		array[1] = "OnPurchasingViewLeave";
		string[] array2 = array;
		if (text != null)
		{
			if (!text.Contains("OnPopupCardOptionsBackClickLobby"))
			{
				array2[0] = text;
			}
			else
			{
				array2 = DPGJIJGOCIC.NHEBLMBJNPI(text, (char)-116);
			}
		}
		base.StartCoroutine(this.DLGCDPAFEOB(array2[1], array2[0]));
	}

	// Token: 0x0600469C RID: 18076 RVA: 0x001FC08D File Offset: 0x001FA28D
	private void NAAFDMKMKHI()
	{
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
	}

	// Token: 0x0600469D RID: 18077 RVA: 0x001FC0A4 File Offset: 0x001FA2A4
	private void FEBLJJOEPOK()
	{
		AudioManager.BFCHJBOOJKE().FadeMusic(440f, 1991f);
		AudioManager.DMAAFFFEJGA().KillMusic("kind", 581f);
		AudioManager.BFCHJBOOJKE().KillAmbient("</i>", 141f);
		BackendOperationsManager.EHBBFMCILPC.OLHKGABJNPB();
		base.StartCoroutine(this.AEBANPJGMDI());
	}

	// Token: 0x0600469E RID: 18078 RVA: 0x001FC104 File Offset: 0x001FA304
	private void PKAPHFPDCCG()
	{
		if (HLDNEMHDEDH.OODFOAELBEA == 1 && HLDNEMHDEDH.CJFFKMIHFJJ == 0)
		{
			if (this.GKHNIMJJLJL.DHONIOBOLEL.AJPIKAACMKL == 0 && this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
			{
				this.GKHNIMJJLJL.DHONIOBOLEL.BMJOOOAJEPL(5);
				this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
				return;
			}
		}
		else if (HLDNEMHDEDH.OODFOAELBEA == 0 && HLDNEMHDEDH.CJFFKMIHFJJ == 0)
		{
			if (this.GKHNIMJJLJL.DHONIOBOLEL.IHFABMOJKHD == 0 && this.GKHNIMJJLJL.DHONIOBOLEL.AJPIKAACMKL == 0 && this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
			{
				this.GKHNIMJJLJL.DHONIOBOLEL.DBMFHIADEOH(2);
				return;
			}
		}
		else if (HLDNEMHDEDH.OODFOAELBEA == 0 && HLDNEMHDEDH.CJFFKMIHFJJ == 1)
		{
			this.GKHNIMJJLJL.DHONIOBOLEL.IHFABMOJKHD = -1;
		}
	}

	// Token: 0x0600469F RID: 18079 RVA: 0x001FC08D File Offset: 0x001FA28D
	private void GHOHFJCGAMJ()
	{
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
	}

	// Token: 0x060046A0 RID: 18080 RVA: 0x001FC1F2 File Offset: 0x001FA3F2
	private void DMOCOBKPJHK()
	{
		this.BIMHNCJHLBO();
	}

	// Token: 0x060046A1 RID: 18081 RVA: 0x001FC1FC File Offset: 0x001FA3FC
	private void AAPGFNICDAH()
	{
		try
		{
			if (this.GKHNIMJJLJL.NCAMFPGMCIG.IMJDADKEEJC != null && this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count > 0)
			{
				string text;
				string text4;
				int num;
				string eempglhpkjg;
				if (this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO[0].Length > 0)
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewinbody0");
					int mopanaokang = 128;
					string text2 = DPGJIJGOCIC.LMCAODJLEGF(this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO[0]);
					if (text2.Contains(">") && text2.LastIndexOf(">") + 1 > 128)
					{
						mopanaokang = text2.LastIndexOf(">") + 1;
					}
					string text3 = DPGJIJGOCIC.PABDHGIJMHJ(text2, mopanaokang, "...");
					text3 = text3.Replace("\n", "");
					text3 = text3.Replace("<b>", "");
					text3 = text3.Replace("</b>", "");
					text3 = text3.Replace("<i>", "");
					text3 = text3.Replace("</i>", "");
					if (this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count == 1)
					{
						text4 = "<size=80%><i><b>[" + text3 + "]</b>";
						text4 = text4 + "\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chapterrewindhint0") + "\n<alpha=#C0>...";
					}
					else
					{
						text4 = "<size=80%><i><b>[" + text3 + "]</b>\n";
						text4 = text4 + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chapterrewindhint0") + "\n<alpha=#C0>...\n";
					}
					text4 += "<alpha=#C0>";
					num = this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count - 3;
					if (num < 1)
					{
						num = 1;
					}
					eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewindtitle0");
				}
				else
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewinbody1");
					if (this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count == 1)
					{
						text4 = "<size=80%><i>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chapterrewindhint1") + "\n<alpha=#C0>...";
					}
					else
					{
						text4 = "<size=80%><i>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chapterrewindhint1") + "\n<alpha=#C0>...\n";
					}
					text4 += "<alpha=#C0>";
					num = this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count - 3;
					if (num < 1)
					{
						num = 1;
					}
					eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewindtitle1");
				}
				int num2 = 0;
				for (int i = num; i < this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count; i++)
				{
					int mopanaokang2 = 128;
					string text5 = DPGJIJGOCIC.LMCAODJLEGF(this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO[i]);
					if (text5.Contains(">") && text5.LastIndexOf(">") + 1 > 128)
					{
						mopanaokang2 = text5.LastIndexOf(">") + 1;
					}
					string text6 = DPGJIJGOCIC.PABDHGIJMHJ(text5, mopanaokang2, "...");
					text6 = text6.Replace("\n", "");
					text6 = text6.Replace("<b>", "");
					text6 = text6.Replace("</b>", "");
					text6 = text6.Replace("<i>", "");
					text6 = text6.Replace("</i>", "");
					string str = "<i>" + text6 + "</i>";
					num2++;
					text4 += str;
					if (num2 >= 4)
					{
						break;
					}
					if (i != this.GKHNIMJJLJL.NCAMFPGMCIG.DNMPCOHNAHO.Count - 1)
					{
						text4 += "\n";
					}
				}
				text4 += "</i></b><size=100%><alpha=#FF>";
				text = text.Replace("XXX", text4);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.OMPADIHCHEM), new UnityAction(this.AOAIJGHPEPH), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewindmissing"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060046A2 RID: 18082 RVA: 0x001FC6B4 File Offset: 0x001FA8B4
	private string EPAIPMEJOJB()
	{
		string text = "";
		if (null == AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			return text;
		}
		JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
		if (null == jsonarray)
		{
			return text;
		}
		List<string> list = new List<string>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		List<int> list4 = new List<int>();
		for (int i = 0; i < jsonarray.Count; i++)
		{
			try
			{
				JSONObject asObject = jsonarray[i].AsObject;
				if (asObject["ant"].AsInt == this.HFFIIBBJBMH.header.index)
				{
					string text2 = asObject["var"].Replace(" ", "");
					string text3 = asObject["max"].Replace(" ", "");
					if (text2.Length != 0 && text3.Length != 0)
					{
						string text4 = "";
						if (null != asObject["sprite"])
						{
							text4 = asObject["sprite"].Replace(" ", "");
						}
						if (SceneStoryManager.LoungeSnapshotSpriteUsable(text4))
						{
							bool flag = true;
							if (ECJCFGAOPHJ.LPBPEBLGMFN() && asObject["acb"] != null && asObject["acb"].AsInt == 0)
							{
								flag = false;
							}
							string text5 = (asObject["varCondition"] != null) ? asObject["varCondition"].Replace(" ", "") : "";
							if (flag && text5.Length > 0)
							{
								int num = 0;
								flag = (ONEHEBIHPFB.GJBMBHGKNHN(text5) && asObject["varConditionValue"] != null && int.TryParse(asObject["varConditionValue"].Replace(" ", ""), out num) && ONEHEBIHPFB.HPFKIKJIGNF(text5) == num);
							}
							int num2 = 0;
							int num3 = 0;
							if (int.TryParse(text3, out num3) && num3 > 0 && ONEHEBIHPFB.GJBMBHGKNHN(text2))
							{
								num2 = Math.Clamp((int)(100f * (float)ONEHEBIHPFB.HPFKIKJIGNF(text2) / (float)num3), 0, 100);
							}
							int num4 = 0;
							string text6 = (asObject["varConditionLocked"] != null) ? asObject["varConditionLocked"].Replace(" ", "") : "";
							if (text6.Length > 0 && ONEHEBIHPFB.GJBMBHGKNHN(text6))
							{
								int num5 = 0;
								if (asObject["varConditionLockedValue"] != null && int.TryParse(asObject["varConditionLockedValue"].Replace(" ", ""), out num5) && ONEHEBIHPFB.HPFKIKJIGNF(text6) == num5)
								{
									num4 = 1;
								}
							}
							int num6 = 0;
							if (flag)
							{
								num6 = 1;
							}
							int num7 = list.IndexOf(text4);
							if (num7 < 0)
							{
								list.Add(text4);
								list2.Add(num6);
								list3.Add(num2);
								list4.Add(num4);
							}
							else
							{
								if (num6 > list2[num7])
								{
									list2[num7] = num6;
									list3[num7] = num2;
								}
								else if (num6 == list2[num7] && num2 > list3[num7])
								{
									list3[num7] = num2;
								}
								if (1 == num4)
								{
									list4[num7] = 1;
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			text = string.Concat(new string[]
			{
				text,
				list[j],
				":",
				list2[j].ToString(),
				":",
				list3[j].ToString(),
				":",
				list4[j].ToString(),
				";"
			});
		}
		return text;
	}

	// Token: 0x060046A3 RID: 18083 RVA: 0x000FAFD0 File Offset: 0x000F91D0
	private void LOMDMMBJPFP()
	{
		Application.Quit();
	}

	// Token: 0x060046A4 RID: 18084 RVA: 0x001FCB0C File Offset: 0x001FAD0C
	private void HAEPBGACFDC(string ICAHJJBAEHB, string JINBEAPCPAF, int KILBEPOBMNB)
	{
		if (ICAHJJBAEHB != null && ICAHJJBAEHB.Length > 0)
		{
			if (this.LJNABDDPANA(ICAHJJBAEHB))
			{
				this.GCADKBKMJFP(NGLGPHBGDPD.narrator, 0f);
				this.MEBPBAJKLAP(ICAHJJBAEHB);
				this.NFGHFMEEBHN(ICAHJJBAEHB, (FCABOFEGPGP)KILBEPOBMNB, DBONHDHEKDG.immediate, Ease.InOutCubic);
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL = ICAHJJBAEHB;
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = KILBEPOBMNB;
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Error. InstantEnvironmentChange(), _envId not found:" + ICAHJJBAEHB);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. InstantEnvironmentChange(), _envId is null or length is 0:" + ICAHJJBAEHB);
		}
		if (JINBEAPCPAF != null && JINBEAPCPAF.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(JINBEAPCPAF), 1f);
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = JINBEAPCPAF;
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. InstantEnvironmentChange(), ambId is null or length is 0:" + JINBEAPCPAF);
	}

	// Token: 0x060046A5 RID: 18085 RVA: 0x001FCBF4 File Offset: 0x001FADF4
	public static bool QualifiesAsAdBasedChoice(BELMEMPLMGE IFBOGLJOJLJ, string AECHGGMNGLC, bool EFKKHOCLPFD)
	{
		return ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge && (AECHGGMNGLC.Equals("micro") && AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyRewarded() && AKLFPGMDKLA.EHBBFMCILPC.PANBDFNFFJE == 0 && !SceneStoryManager.PremiumChoicePurchased(IFBOGLJOJLJ, EFKKHOCLPFD, -1));
	}

	// Token: 0x060046A6 RID: 18086 RVA: 0x001FCC51 File Offset: 0x001FAE51
	private void AIABOAANNNF()
	{
		if (SceneStoryManager.loungePremiumChoicesHistoryState == 0)
		{
			SceneStoryManager.loungePremiumChoicesHistoryState = 0;
		}
	}

	// Token: 0x060046A7 RID: 18087 RVA: 0x001FCC64 File Offset: 0x001FAE64
	private void NHAEMEAFLGA()
	{
		int num = this.HNHECDGGJMP();
		for (int i = 0; i < num; i++)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ANPGJMAGFAP(i);
			try
			{
				int num2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CGPADEOMODB(i);
				for (int j = 0; j < num2; j++)
				{
					DOLBFGIPPOG dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCMBEHBNPML(j, i);
					for (int k = 0; k < 6; k++)
					{
						if (dolbfgippog != null && dolbfgippog.OHCMCJHDMOH[k] != null && dolbfgippog.OHCMCJHDMOH[k].Length > 0)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)k, dolbfgippog.OHCMCJHDMOH[k], this.PCDHECPEOAJ());
							if (null != assetAvatarComponent && (assetAvatarComponent.exposition == HPKJCKOHAAI.exposed || assetAvatarComponent.exposition == HPKJCKOHAAI.hidden))
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GGKPAGAGMGA(assetAvatarComponent.MBPKGBDCGFC().index, i);
							}
						}
					}
				}
				int num3 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BAPGEMBKFEM(i);
				for (int l = 0; l < num3; l++)
				{
					DOLBFGIPPOG dolbfgippog2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PLLBOBIHPLK(l, i);
					for (int m = 0; m < 6; m++)
					{
						if (dolbfgippog2 != null && dolbfgippog2.OHCMCJHDMOH[m] != null && dolbfgippog2.OHCMCJHDMOH[m].Length > 0)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)m, dolbfgippog2.OHCMCJHDMOH[m], this.PCDHECPEOAJ());
							if (null != assetAvatarComponent && (assetAvatarComponent.exposition == HPKJCKOHAAI.exposed || assetAvatarComponent.exposition == HPKJCKOHAAI.hidden))
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GGKPAGAGMGA(assetAvatarComponent.MBPKGBDCGFC().index, i);
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060046A8 RID: 18088 RVA: 0x001FCE60 File Offset: 0x001FB060
	private void HJGGLBOFNNM()
	{
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains(" • "))
			{
				if (null != this.cameras[i].gameObject.GetComponent<BlurOptimized>())
				{
					this.cameras[i].gameObject.GetComponent<BlurOptimized>().enabled = true;
					return;
				}
				break;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x060046A9 RID: 18089 RVA: 0x001FCEE0 File Offset: 0x001FB0E0
	private void AKHOHHEMFFN()
	{
		if (KGLBKJKNPFD.NIBNMKJIMAD == 0 && null != this.storyChatPrefab && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AABIMKHJJFJ() != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AABIMKHJJFJ().GGLGABLNADC();
		}
	}

	// Token: 0x060046AA RID: 18090 RVA: 0x001FCF34 File Offset: 0x001FB134
	private void NGGHOOIELJP(KFIHMMIGPLO PBKAAIONJOB, string KHJMANDEDMA, string HAAMAKMPMJL, bool EPNOEHIJIJD = true)
	{
		if (KHJMANDEDMA.Length > 0)
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(PBKAAIONJOB, KHJMANDEDMA, null);
			if (null == assetAvatarComponent && HAAMAKMPMJL != null && HAAMAKMPMJL.Length > 0)
			{
				KHJMANDEDMA = HAAMAKMPMJL;
				assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(PBKAAIONJOB, KHJMANDEDMA, null);
			}
			if (null != assetAvatarComponent)
			{
				if (assetAvatarComponent.exposition == HPKJCKOHAAI.exposable)
				{
					AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().APLDMAMDDLL(KHJMANDEDMA, assetAvatarComponent.MBPKGBDCGFC().index, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME);
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MLDFBDDMFLC(KHJMANDEDMA, assetAvatarComponent.MBPKGBDCGFC().index);
				}
				if (EPNOEHIJIJD)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[(int)PBKAAIONJOB] = KHJMANDEDMA;
					return;
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager.UpdateAvatarConfiguration(), avatar component asset missing:" + KHJMANDEDMA);
			}
		}
	}

	// Token: 0x060046AB RID: 18091 RVA: 0x001FD00C File Offset: 0x001FB20C
	public void KOAPFPDBLFL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (AdsManagerLP.OOGPALHPNGM().DEGINHKBOOK())
		{
			AdsManagerLP.NODMIFMPFLK().ICGFPPHDHOB("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.body is null.", "OnBackendValidateTransactionFailed", "digitalglitch");
		}
		else
		{
			AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("dropChancesBalance", 1767f);
		}
		AKLFPGMDKLA.EHBBFMCILPC.OBBFGMHLMHO = 1;
		this.HPBFGMAFKDD = 0;
	}

	// Token: 0x060046AC RID: 18092 RVA: 0x001FBC27 File Offset: 0x001F9E27
	private void IHPFNMOOCLL()
	{
		this.MPKCDMNJBPH();
	}

	// Token: 0x060046AD RID: 18093 RVA: 0x001FD080 File Offset: 0x001FB280
	private IEnumerator FBJPMNDLLID(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			if (null != EFBLHGECEJA[i].IACFDHCDEME)
			{
				EFBLHGECEJA[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().AnimateDisappearance(GFEJBOAKPMP.animationStoryDisappearToRight);
			}
		}
		yield return new WaitForSeconds(NonPlayerCharacterManager.GetAnimationDisappearTime());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
			if (null != this.EBHJLLIHIFE)
			{
				ahlneabnmoa = this.EBHJLLIHIFE.GetSlotByCharacterObject(EFBLHGECEJA[j].IACFDHCDEME);
			}
			if (ahlneabnmoa != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
			}
			else if (null != EFBLHGECEJA[j].IACFDHCDEME)
			{
				UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
			}
		}
		yield return null;
		yield break;
	}

	// Token: 0x060046AE RID: 18094 RVA: 0x001FD098 File Offset: 0x001FB298
	public static bool RequestLoungePremiumChoicesHistory()
	{
		bool result;
		try
		{
			if (SceneStoryManager.loungePremiumChoicesHistoryState == 1)
			{
				result = true;
			}
			else
			{
				FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(StoryInterfaceHeaderManager.anthologyIndex);
				if (fjlgcknojmj == null)
				{
					result = false;
				}
				else
				{
					List<int> list = new List<int>();
					for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
					{
						if (SceneStoryManager.CHPFNHINCOG(fjlgcknojmj.OINAAMKLNLO[i]))
						{
							for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
							{
								int pbgkgchmhop = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].PBGKGCHMHOP;
								if (pbgkgchmhop > 0 && !list.Contains(pbgkgchmhop))
								{
									list.Add(pbgkgchmhop);
								}
							}
						}
					}
					if (list.Count == 0)
					{
						result = false;
					}
					else
					{
						SceneStoryManager.loungePremiumChoicesHistoryState = 1;
						SceneStoryManager.BLMFAKBBMOE.Clear();
						for (int k = 8; k < list.Count; k++)
						{
							SceneStoryManager.BLMFAKBBMOE.Add(list[k]);
						}
						List<int> list2 = new List<int>();
						int num = 0;
						while (num < list.Count && num < 8)
						{
							list2.Add(list[num]);
							num++;
						}
						BackendOperationsManager.EHBBFMCILPC.RequestGetPremiumChoicesHistory(list2, "OnLoungePremiumChoicesHistorySuccess", "OnLoungePremiumChoicesHistoryException");
						result = (SceneStoryManager.loungePremiumChoicesHistoryState == 1);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			SceneStoryManager.loungePremiumChoicesHistoryState = 3;
			SceneStoryManager.BLMFAKBBMOE.Clear();
			result = false;
		}
		return result;
	}

	// Token: 0x060046AF RID: 18095 RVA: 0x001FD238 File Offset: 0x001FB438
	private int FNHMCKAFCMM(ECJCFGAOPHJ FFACCDIEBIA)
	{
		int num = 0;
		if (FFACCDIEBIA == null || FFACCDIEBIA.APDJNDIIILK == null)
		{
			return num;
		}
		for (int i = 1; i < FFACCDIEBIA.APDJNDIIILK.Count; i += 0)
		{
			int num2 = FFACCDIEBIA.APDJNDIIILK[i];
			if (num2 / -46 != this.HFFIIBBJBMH.header.CKACBBGHJGI())
			{
				string[] array = new string[6];
				array[0] = "OnSketchViewShowWI";
				array[1] = num2.ToString();
				array[8] = "verify threw: ";
				array[3] = FFACCDIEBIA.IJEEKLNDJGE;
				array[2] = ";";
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
			}
			else
			{
				if (!this.AHKDFKBDBJG.Contains(num2))
				{
					this.AHKDFKBDBJG.Add(num2);
				}
				if (AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundle(num2))
				{
					num += 0;
					if (!this.PCGFKFFPODD.Contains(num2))
					{
						this.PCGFKFFPODD.Add(num2);
					}
				}
			}
		}
		return num;
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x001FD319 File Offset: 0x001FB519
	private void NKHNNNKCCCF()
	{
		if (ODJKHCHFKNL.BBBJIGCHMCG() == DFGILFBGPLN.popupBackendErrorStartPlayChapter)
		{
			return;
		}
		this.ILJAFHPEKDC = true;
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.OHHFFMMMMAC();
		}
		this.FNDBICLIGKO();
	}

	// Token: 0x060046B1 RID: 18097 RVA: 0x001FD354 File Offset: 0x001FB554
	private void BNCFCMBOBGM()
	{
		StarRatingSelector.RememberLastRating(true);
		if ((this.HODJEPIPDFH == 0 && this.NJAAOCMPKCD.index % 5 == 0) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, GKJPOGNFKNK.BKBCNMEHGFA(this.HFFIIBBJBMH.header.index), -1))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartepbody0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.HMOKDIODADD), new UnityAction(this.GLMFCONMBID), DFGILFBGPLN.popupSignInQuestion, 0.2f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartepbody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.HMOKDIODADD), new UnityAction(this.GLMFCONMBID), DFGILFBGPLN.popupSignInQuestion, 0.2f, 28);
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x001FD481 File Offset: 0x001FB681
	private IEnumerator OFIDKCECPGJ(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<DialogTitleManager>().DisappearAnimation();
		}
		yield return new WaitForSeconds(DialogTitleManager.GetDisappearAnimationLength());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060046B3 RID: 18099 RVA: 0x001FD490 File Offset: 0x001FB690
	private void DHDBJIFLFJF(FGINKFGNNEK JKJMDNFAFBB, string KCOMIMHDJJP)
	{
		NonPlayerCharacterManager component = JKJMDNFAFBB.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
		string dbhmnecmiab = JKJMDNFAFBB.DBHMNECMIAB;
		FLNOFHCNJDM lastEmotionRequested = component.GetLastEmotionRequested();
		FLNOFHCNJDM pmdggedphjc = component.CCHPKAOEAFF();
		this.PromoteLoungeNpcAssetToChapterLifetime(KCOMIMHDJJP);
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		list.Add(JKJMDNFAFBB);
		this.CMBLMOJFGAE.Remove(JKJMDNFAFBB);
		component.HideAtOnce();
		GameObject gameObject = null;
		try
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterRenderTexturePrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
			gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(1075f, 1851f, 421f);
			gameObject.transform.SetParent(this.playerCharacterPivot.transform, false);
			int num = -1;
			for (int i = 1; i < this.LLEHEBBHAOD.Count; i++)
			{
				if (this.LLEHEBBHAOD[i] != null && !(null == this.LLEHEBBHAOD[i].IACFDHCDEME) && !(this.LLEHEBBHAOD[i].IACFDHCDEME.transform.parent != this.playerCharacterPivot.transform))
				{
					num = this.LLEHEBBHAOD[i].IACFDHCDEME.transform.GetSiblingIndex();
					if (this.LLEHEBBHAOD[i].DBHMNECMIAB != null && this.LLEHEBBHAOD[i].DBHMNECMIAB.Equals(dbhmnecmiab))
					{
						break;
					}
				}
			}
			if (num >= 0)
			{
				gameObject.transform.SetSiblingIndex(num);
			}
			else
			{
				gameObject.transform.SetAsFirstSibling();
			}
			NonPlayerCharacterManager component2 = gameObject.GetComponent<NonPlayerCharacterManager>();
			component2.Initialize(KCOMIMHDJJP, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.left, true);
			SceneStoryManager.OMOGKJCMCKF(KCOMIMHDJJP);
			component2.MAHHJBLOJFA(GFEJBOAKPMP.animationStoryAppearFromRight);
			component2.SetEmotion(lastEmotionRequested, (BIDPEOLOIIG)3, pmdggedphjc);
			component2.RecordLineEmotion(lastEmotionRequested, pmdggedphjc);
			component2.DisableFadeOnAppearAndDisappar();
			this.CMBLMOJFGAE.Add(this.GLDAJFNCFKC(dbhmnecmiab, gameObject));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			if (null != gameObject)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		base.StartCoroutine(this.JHDEBFCKKJA(list));
		LPEMDECEIAO.CKNCICNJKIA(KCOMIMHDJJP);
	}

	// Token: 0x060046B4 RID: 18100 RVA: 0x001FD6C8 File Offset: 0x001FB8C8
	private void OINFFDNGJHF()
	{
		this.AMBEPJCICOF();
		this.MCIGJBFKOIJ = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnAvatarClickPart2));
		this.CMDIKMNEGEN();
	}

	// Token: 0x060046B5 RID: 18101 RVA: 0x001FD704 File Offset: 0x001FB904
	private void HOJKLCFKFLL()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmFull.ToString(), BGHLMGPPCNN.gmLocSett.ToString(), false, false);
		this.DNGHLBFEODC();
	}

	// Token: 0x060046B6 RID: 18102 RVA: 0x001FD760 File Offset: 0x001FB960
	private void OMGGLEDEGMP(string KHJMANDEDMA, float BFLBCFEGMIB, float JHBAIJIJIBN)
	{
		bool flag = false;
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].IJHJGCPCINP(BFLBCFEGMIB, JHBAIJIJIBN);
				this.KEPHFKAHILM[i].EBBNGDPMKDE(null);
			}
			else
			{
				this.KEPHFKAHILM[i].FGAOBOJNGJL();
			}
		}
		for (int j = 1; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				flag = false;
				this.CHHIBBOICAD[j].AKCICJFLEBA(BFLBCFEGMIB, JHBAIJIJIBN);
				this.CHHIBBOICAD[j].ZoomOut(null);
			}
			else
			{
				this.CHHIBBOICAD[j].EHMCCHLIDMF();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("XXX" + text + "/");
		}
	}

	// Token: 0x060046B7 RID: 18103 RVA: 0x001FD873 File Offset: 0x001FBA73
	private bool BEDGKOBBMCD(ECJCFGAOPHJ FFACCDIEBIA)
	{
		return SceneStoryManager.LoungeMappingIsEligible(FFACCDIEBIA, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP(), null, SceneStoryManager.PNKPJFHFGHJ);
	}

	// Token: 0x060046B8 RID: 18104 RVA: 0x001FD88C File Offset: 0x001FBA8C
	private int CPDCOODDHDE(ECJCFGAOPHJ FFACCDIEBIA)
	{
		int num = 0;
		if (FFACCDIEBIA == null || FFACCDIEBIA.APDJNDIIILK == null)
		{
			return num;
		}
		for (int i = 0; i < FFACCDIEBIA.APDJNDIIILK.Count; i++)
		{
			int num2 = FFACCDIEBIA.APDJNDIIILK[i];
			if (num2 / 100000 != this.HFFIIBBJBMH.header.CKACBBGHJGI())
			{
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[Lounge] npc animation pack of another anthology skipped: ",
					num2.ToString(),
					" (",
					FFACCDIEBIA.IJEEKLNDJGE,
					")"
				}));
			}
			else
			{
				if (!this.AHKDFKBDBJG.Contains(num2))
				{
					this.AHKDFKBDBJG.Add(num2);
				}
				if (AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundle(num2))
				{
					num++;
					if (!this.PCGFKFFPODD.Contains(num2))
					{
						this.PCGFKFFPODD.Add(num2);
					}
				}
			}
		}
		return num;
	}

	// Token: 0x060046B9 RID: 18105 RVA: 0x001FD970 File Offset: 0x001FBB70
	private void ACJDLLIOGMJ()
	{
		this.FDEBLDDCGGB = 1;
		if (!this.GLIMDKBANOI)
		{
			return;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.ALIGDEHMGOP() == 0)
		{
			KGLBKJKNPFD.AFKAMBFMMOH = this.GKHNIMJJLJL.NCAMFPGMCIG.OJCPKGCLEPD();
		}
		else
		{
			KGLBKJKNPFD.AFKAMBFMMOH = -1;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.ALLDBPCKMLF == 0)
		{
			KGLBKJKNPFD.ALLDBPCKMLF = this.GKHNIMJJLJL.NCAMFPGMCIG.ALLDBPCKMLF;
		}
		else
		{
			KGLBKJKNPFD.ALLDBPCKMLF = 1;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD == 0 && null != this.storyChatPrefab)
		{
			KGLBKJKNPFD.NIBNMKJIMAD = this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD;
		}
		else
		{
			KGLBKJKNPFD.NIBNMKJIMAD = 0;
		}
		if (this.GKHNIMJJLJL != null)
		{
			KGLBKJKNPFD.FIMJIINAFFK = this.GKHNIMJJLJL.NCAMFPGMCIG.FIMJIINAFFK;
			KGLBKJKNPFD.DMAGAHMIKDE = this.GKHNIMJJLJL.NCAMFPGMCIG.DMAGAHMIKDE;
		}
		else
		{
			KGLBKJKNPFD.FIMJIINAFFK = 0;
			KGLBKJKNPFD.DMAGAHMIKDE = -1;
		}
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.IOLCAAOOOCN() >= 1)
		{
			OCCBADNHFHK.KHBNNKGNNGJ = false;
		}
		else
		{
			OCCBADNHFHK.KHBNNKGNNGJ = true;
		}
		this.HFOPCMIHDOL.EBKJPEHJLDE();
		this.LBJAADKIANK();
		this.JAPJDIMHOIB();
		this.PBFBEEGCFHF();
		if (AssetsManager.MJBDMHPHMID().DIFLGADHJCH() != JLINKDNLADM.Success)
		{
			CommonUserInterface.IKNOFBFMPGA().CDNICMFGIID(AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().IPOLABEPNNC());
		}
		if (AssetsManager.MJBDMHPHMID().ELMHLBHEKDM())
		{
			if (this.LHGNMIOGHGJ >= (float)KBOJLHAJPCP.NGPHPLGAPHG)
			{
				if (!CommonUserInterface.EHBBFMCILPC.LHBOBMDENGJ())
				{
					CommonUserInterface.EHBBFMCILPC.MJNDCBAPEOP(CCOJBMMKNAP.HFAKOKBHCGH().PKNHKGMNCIP("lang"), CCOJBMMKNAP.OEPENBHJAHO().OBDCPLLLGBB("OnBackendPremiumChoiceException"), (DFGILFBGPLN)102, 1774f, 49);
				}
			}
			else if (!CommonUserInterface.EHBBFMCILPC.LHBOBMDENGJ())
			{
				this.LHGNMIOGHGJ += Time.deltaTime;
			}
		}
		else
		{
			this.LHGNMIOGHGJ = 1535f;
		}
		if (this.MINLCJENJIB >= 152f)
		{
			this.MINLCJENJIB -= Time.deltaTime;
		}
	}

	// Token: 0x060046BA RID: 18106 RVA: 0x001FDB93 File Offset: 0x001FBD93
	private void JKAABKKGNKP()
	{
		this.UpdateTopMatchData();
		this.storyInterfaceHeaderManager.SetCurrentStorySave(this.GKHNIMJJLJL);
		this.storyInterfaceHeaderManager.UpdateStatsData(this.GHGFGDHNNHG(), this.statsIcons);
	}

	// Token: 0x060046BB RID: 18107 RVA: 0x001FDBC4 File Offset: 0x001FBDC4
	private void BAPFLDGINPI()
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.BLNNJFAAHDP.Count; i++)
		{
			list.Add(this.BLNNJFAAHDP[i]);
		}
		this.BLNNJFAAHDP.Clear();
		base.StartCoroutine(this.CDOOJOJAHDP(list));
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x001FDC18 File Offset: 0x001FBE18
	private IEnumerator HPFHBMJAGIE(float LJLHCJFDNGL)
	{
		yield return new WaitForSeconds(LJLHCJFDNGL);
		this.KBBPBKJEFCJ();
		yield break;
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x001FDC2E File Offset: 0x001FBE2E
	private void KJKDMIBJIOL()
	{
		if (!this.GLIMDKBANOI)
		{
			return;
		}
		if (this.DMIPDJJBFLN)
		{
			AKLFPGMDKLA.EHBBFMCILPC.CGLOLLKIDDF(this.NJAAOCMPKCD.index, this.GFIFDKBLLBL.state.ToJson());
			this.MECFCFPBLEF();
		}
	}

	// Token: 0x060046BE RID: 18110 RVA: 0x001FDC6C File Offset: 0x001FBE6C
	private void ENLBAEECIGP()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		if (SceneStoryManager.achievementSyncReward > 1)
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.CPCOODCFDDP().HIPJILDCHJC("OnBackendRequestCollectGiftException"), CCOJBMMKNAP.GIOAFDDKKHI().BDGPNPNIAPA("aindas2"), CCOJBMMKNAP.JMDJPKKOHNI().FCOCLEHKLDJ("ok"), new UnityAction(this.AADJGGEMOJD), new UnityAction(this.AADJGGEMOJD), DFGILFBGPLN.popupCdnDownloadFailed, 1583f, 90).JFGNJBKKIKD(SceneStoryManager.achievementSyncReward);
			return;
		}
		this.AADJGGEMOJD();
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x001FDCF4 File Offset: 0x001FBEF4
	private void DCGMIOFFAMN()
	{
		this.AMBEPJCICOF();
		this.MCIGJBFKOIJ = false;
		this.LFFONLGJFBH();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnNeedToOpenLoveInterestsLoungePart2));
		this.CMDIKMNEGEN();
	}

	// Token: 0x060046C0 RID: 18112 RVA: 0x001FDD34 File Offset: 0x001FBF34
	private void DDAHFNNPJJB()
	{
		string text = DPGJIJGOCIC.JJEBFOINJGF(AOBJLALDBAA.FILDBDMENPG().BMFAMELDAIL());
		if (text != null && text.Length > 1 && this.CODFIPHLBLE != null)
		{
			StoryEnvironmentManager component = this.LDLPKDIFOAD(this.CODFIPHLBLE.IBFLNCMCKAL).GetComponent<StoryEnvironmentManager>();
			if (null != component)
			{
				List<string> list = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.COFAHJCNONO(component.name);
				List<string> list2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIBJOMEMBOK(component.name);
				string ljlbjihpkae = "ok";
				if (StoryEnvironmentLayerManager.lastVideoLayerName.Length > 0 && StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName.Length > 0)
				{
					string text2 = StoryEnvironmentLayerManager.lastVideoLayerName;
					if (this.GKHNIMJJLJL.NCAMFPGMCIG.LMCJOCDIJGP() >= 7)
					{
						text2 = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(text2);
					}
					if (text2.StartsWith(component.name + "SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerAcceptClick()") && !list.Contains(text2))
					{
						ljlbjihpkae = StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName;
						list.Add(text2);
					}
				}
				string ahlohdkpamg = "importanttitle";
				AudioContainer audioContainer = AudioManager.BFCHJBOOJKE().AKCHIENBELK(CCEMAFOMLLK.music, this.CODFIPHLBLE.KPPJINFHMIP);
				if (null != audioContainer)
				{
					ahlohdkpamg = audioContainer.FPNFLIHGLNO();
				}
				string memflcdmjkh = "\n";
				AudioContainer audioContainer2 = AudioManager.DBFLIEGGGNN().KOLAAEJGPEK(CCEMAFOMLLK.ambient, this.CODFIPHLBLE.JLEAIJGBGHL);
				if (null != audioContainer2)
				{
					memflcdmjkh = audioContainer2.NGNOCMEILIM();
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.MNHKPMBLEEK(component.name, this.CODFIPHLBLE.EFCOEEJBKNF(component.name), this.LANHEHAJDJJ(component, list, list2), list2, this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM(), text, this.CODFIPHLBLE.NLAPFLNBDLC, this.CODFIPHLBLE.DBIEKGOEKKH, component.OPOBHOIBOMB(), this.CODFIPHLBLE.KPPJINFHMIP, ahlohdkpamg, this.CODFIPHLBLE.JLEAIJGBGHL, memflcdmjkh, ljlbjihpkae, this.CODFIPHLBLE.BIBACLNGIOD, this.CODFIPHLBLE.OOLMNPHJOFA, component.MHFHGPPMHIC()))
				{
					string text3 = CCOJBMMKNAP.GIOAFDDKKHI().HPOAGPJFHPM("OnStoryChoiceClick");
					text3 = text3.Replace(" dropped (no same-row neighbour)", "prof" + text + "anthologiestitle");
					text3 = text3.Replace("BackendOperationsManager.ProcessApp42Success() - exception when processing the web purchases history:", " not found.");
					text3 = text3.Replace("", "%");
					text3 = text3.Replace("favchrstr2", "top");
					this.HFOPCMIHDOL.COFCFNNEGKM("passhintevent" + text3 + "", new List<string>(), new List<Choice>(), false, true, false, false);
					FirebaseAnalyticsManager.DMAAFFFEJGA().AAIABAKHLAH(true, ((AGEHCPDNBFD)118).ToString(), ((FFPHBMFGCNN)(-72)).ToString(), BGHLMGPPCNN.d1LobbyOfrC1.ToString(), true, true);
				}
				else
				{
					string str = CCOJBMMKNAP.BOFMCPPFAMO().IKMNGFIDCLM("errortitle");
					this.HFOPCMIHDOL.COFCFNNEGKM("YYY" + str + "OnStoryInterfaceAutoReaderActivate", new List<string>(), new List<Choice>(), true, true, true, false);
				}
			}
			this.DDDEHHANLKH(true);
		}
		this.JOKJBAIECCA(true);
		this.IDLBNMFGLKE();
		this.AIGBJLAPFLH();
	}

	// Token: 0x060046C1 RID: 18113 RVA: 0x001FE06C File Offset: 0x001FC26C
	private void JDOOLLFBHLK(string KHJMANDEDMA, float JHBAIJIJIBN)
	{
		if (null != this.DMNJMLDEILJ)
		{
			this.DMNJMLDEILJ.NGHMPDLANMH();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HEFOPKOFLBG() < 3)
		{
			bool flag = true;
			for (int i = 1; i < this.fadeLayers.Count; i += 0)
			{
				if (this.fadeLayers[i].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag = true;
					this.fadeLayers[i].HCMMPBLKCEF(JHBAIJIJIBN);
					this.fadeLayers[i].BJIGLKGLAKM(null);
				}
				else
				{
					this.fadeLayers[i].NCNBINOFOJM();
				}
			}
			if (!flag)
			{
				KHJMANDEDMA = "app42error";
				for (int j = 1; j < this.fadeLayers.Count; j += 0)
				{
					if (this.fadeLayers[j].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag = true;
						this.fadeLayers[j].OOKMEJPHCBB(JHBAIJIJIBN);
						this.fadeLayers[j].FadeIn(null);
					}
					else
					{
						this.fadeLayers[j].Reset();
					}
				}
				if (!flag)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("max" + KHJMANDEDMA + "envpind");
					return;
				}
			}
		}
		else
		{
			bool flag2 = true;
			for (int k = 0; k < this.fadeLayers.Count; k += 0)
			{
				if (this.fadeLayers[k].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag2 = true;
					this.fadeLayers[k].BEHIOPAHKKI(JHBAIJIJIBN);
					if (!this.fadeLayers[k].gameObject.activeSelf)
					{
						this.fadeLayers[k].BJIGLKGLAKM(null);
					}
					else
					{
						this.fadeLayers[k].FNLEFALMANJ(null);
					}
				}
				else
				{
					this.fadeLayers[k].EBHGDIEBJKI();
				}
			}
			if (!flag2)
			{
				KHJMANDEDMA = "@";
				for (int l = 1; l < this.fadeLayers.Count; l++)
				{
					if (this.fadeLayers[l].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag2 = true;
						this.fadeLayers[l].OOKMEJPHCBB(JHBAIJIJIBN);
						this.fadeLayers[l].FadeIn(null);
					}
					else
					{
						this.fadeLayers[l].Reset();
					}
				}
				if (!flag2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnBackendRequestShareHardSuccess" + KHJMANDEDMA + "mussind");
				}
			}
		}
	}

	// Token: 0x060046C2 RID: 18114 RVA: 0x001FE2F7 File Offset: 0x001FC4F7
	private void BMKHLLHPFGD()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		this.HBPLGJFPFKM();
	}

	// Token: 0x060046C3 RID: 18115 RVA: 0x001FE304 File Offset: 0x001FC504
	private void EIBHCPKNLGA()
	{
		if (ODJKHCHFKNL.NMEIBDCALLA() != DFGILFBGPLN.screenHub)
		{
			return;
		}
		this.APDAMLCHICH();
		if (null != this.FNHFGLHODBG)
		{
			this.FNHFGLHODBG.gameObject.SetActive(false);
		}
	}

	// Token: 0x060046C4 RID: 18116 RVA: 0x001FE334 File Offset: 0x001FC534
	private void OnEnable()
	{
		this.IGMHKFOFHDL();
		if (null != this.NJAAOCMPKCD)
		{
			StoryInterfaceHeaderManager.storyIndex = this.NJAAOCMPKCD.index;
		}
		if (null != this.HFFIIBBJBMH)
		{
			StoryInterfaceHeaderManager.anthologyIndex = this.HFFIIBBJBMH.header.index;
		}
		this.OFCOFBDHBHE = 0.85f;
		SceneLobbyManager2.returnedFromStory = true;
		ApplicationFocusManager.Deactivate();
		SceneLobbyManager2.anthologyPropertiesInitializationCounter++;
		PopupSettingsManager.excludeCurrentChapterMissingLanguages = true;
		this.HODJEPIPDFH = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN();
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1ChaptSt.ToString(), true, false);
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LOKHOADFCDF() && null != this.NJAAOCMPKCD && this.NJAAOCMPKCD.index % 5 == 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN();
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		this.DMIPDJJBFLN = true;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToOpenLoveInterestsLounge", new UnityAction(this.EPKNCKGNNCE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungePremiumChoicesHistorySuccess", new UnityAction(this.CEPAKBBPHHF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungePremiumChoicesHistoryException", new UnityAction(this.OHCHDKJDMLI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileSaveCutsceneInputCancel", new UnityAction(this.NFOGAJKHADD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileSaveCutsceneInputEndEdit", new UnityAction(this.IKFCJJIMBIJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryManInTheMiddleAttackDetected", new UnityAction(this.BGEHIGPMFEB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderBackClick", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderShopClick", new UnityAction(this.KFGNHIOJGON));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderAvatarClick", new UnityAction(this.MCNFLPPFNEE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderSettingsClick", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderRewindClick", new UnityAction(this.AAPGFNICDAH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPostEffectSettingsChanged", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupClose", new UnityAction(this.EJIFFJPANGA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToRestartGame", new UnityAction(this.CMKPNGPCDAB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToRestartGame2", new UnityAction(this.DNGHLBFEODC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", new UnityAction(this.OCIAMGMLMLG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToShowGameModeNotif", new UnityAction(this.IKFEBEDGOIG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAccountSignInSuccess", new UnityAction(this.GMFFLAFLGHH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnOnDemandResourcesDownloadSuccess", new UnityAction(this.MJODBGBOCOF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnOnDemandResourcesDownloadFailed", new UnityAction(this.GIADKBIIGKK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedPlayNewAmbient", new UnityAction(this.AAPDFHFPILE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedLayerChange", new UnityAction(this.EFCDGMAMICG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedEnvironmentChange", new UnityAction(this.OFLKKJDKNEE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedEnvironmentChangeOnInit", new UnityAction(this.BNLOHKAPOAH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardScreenAssetsDownloadSuccess", new UnityAction(this.AOAIPKJEPFL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardScreenAssetsDownloadFailed", new UnityAction(this.FKAPLBDKMBM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPremiumChoiceRetry", new UnityAction(this.NLBMHEGAMBK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPremiumChoiceException", new UnityAction(this.KOADIHAKPPK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPremiumChoiceSuccess", new UnityAction(this.HBHDBDHBEPD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAchievementSyncSuccess", new UnityAction(this.LBIHJLKIOHH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAchievementSyncException", new UnityAction(this.FKKNKFIFLID));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryCurrencyInfoClick", new UnityAction(this.JNFIBEFKKBO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClick", new UnityAction(this.MNJMFEMJHGI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCollectableDialogCollect", new UnityAction(this.IKOEGDKKEBF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCollectableDialogUsed", new UnityAction(this.CMNOPAIJJDP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCollectableDialogShown", new UnityAction(this.COPCJKBGNCB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnDialogReadInputEndEdit", new UnityAction(this.HBLMNLBCGMD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAccountSave", new UnityAction(this.FACKGDFNJJD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerAssetsDownloadSuccess", new UnityAction(this.BHKOKKMDLAM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarScreenClosed", new UnityAction(this.CEBONOIKIIB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryAdsProviderAdSuccess", new UnityAction(this.OnStoryAdsProviderAdSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupRemoveAdsManagerDismissed", new UnityAction(this.NEEGOLNHIIJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onAvatarScreenLeft, new UnityAction(this.GPNFLDDKLAJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarScreenAssetsDownloadSuccess", new UnityAction(this.OINFFDNGJHF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarScreenAssetsDownloadFailed", new UnityAction(this.GNEIAKDLELG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneLoungeManager.onLoungeScreenLeft, new UnityAction(this.CENEGBNNOOM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungeScreenAssetsDownloadSuccess", new UnityAction(this.DCGMIOFFAMN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungeScreenAssetsDownloadFailed", new UnityAction(this.HJDHHDGNMII));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess", new UnityAction(this.IOIGJPJIBEL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", new UnityAction(this.MBOJMJOEGDH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupRemoveAdsManagerContinueToPurchasingScreen", new UnityAction(this.OPDNFDDHIDB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGetCdnDataForAvatarScreenSuccess", new UnityAction(this.OnGetCdnDataForAvatarScreenSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGetCdnDataForAvatarScreenException", new UnityAction(this.OnGetCdnDataForAvatarScreenException));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGetCdnDataBeforeOnDemandSuccess", new UnityAction(this.OnGetCdnDataBeforeOnDemandSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGetCdnDataBeforeOnDemandException", new UnityAction(this.OnGetCdnDataBeforeOnDemandException));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnVideoLayerAutoHide", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnConsumeEnergySuccess", new UnityAction(this.FGBMKKIFDKD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnConsumeEnergyException", new UnityAction(this.JLPFFPDJALD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnTryToFireNoteshowTimer", new UnityAction(this.OGNJFHPEDNN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFullscreenLiveOfferContinueToPurchasingScreen", new UnityAction(this.GHOHFJCGAMJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPassResourcesChangedType0", new UnityAction(this.BGECHBHBLBM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceButtonUndoClick", new UnityAction(this.MHPPFDJGNHF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnShowStoryHeaderInterfaceGamePassAndUndoButton", new UnityAction(this.NJJEBHJGNOJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendUndoPremiumChoiceException", new UnityAction(this.GEMEKBNAHAO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendUndoPremiumChoiceSuccess", new UnityAction(this.EIBAHCAEHDL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceFastForwardActivate", new UnityAction(this.MJILKOBLFAL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceFastForwardStop", new UnityAction(this.APDAMLCHICH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderShown", new UnityAction(this.JKAABKKGNKP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.IHPFNMOOCLL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderFastForwardEnable", new UnityAction(this.LHJADJAAJOO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderFastForwardDisable", new UnityAction(this.IDLBEHCKBEH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceAutoReaderActivate", new UnityAction(this.BBFANIMJIIK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceAutoReaderStop", new UnityAction(this.DNGIDKHONMB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderAutoReadEnable", new UnityAction(this.NJBECPDOIEE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderAutoReadDisable", new UnityAction(this.GINDNBPIIIG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, new UnityAction(this.MDMJIDKABLD));
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenStory);
	}

	// Token: 0x060046C5 RID: 18117 RVA: 0x001FECFC File Offset: 0x001FCEFC
	private StoryChatManager MLDGHPCEFNN()
	{
		for (int i = 0; i < this.BOALOCEGFOO.Count; i++)
		{
			if (this.BOALOCEGFOO[i].DBHMNECMIAB.Equals(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK))
			{
				return this.BOALOCEGFOO[i].IACFDHCDEME.GetComponent<StoryChatManager>();
			}
		}
		return null;
	}

	// Token: 0x060046C6 RID: 18118 RVA: 0x001FED64 File Offset: 0x001FCF64
	private void DJOALKMNJEM()
	{
		AssetsManager.EHBBFMCILPC.ActivatePendingScenes();
	}

	// Token: 0x060046C7 RID: 18119 RVA: 0x001FED70 File Offset: 0x001FCF70
	private IEnumerator INOLIJEKCAB(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		this.LDAPOBMECNI++;
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().AnimateDisappearance(BKBCKPMDFOD.animationStoryDisappearToLeft, false);
		}
		yield return new WaitForSeconds(PlayerCharacterManager.GetAnimationDisappearTime());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		this.LDAPOBMECNI--;
		yield return null;
		yield break;
	}

	// Token: 0x060046C8 RID: 18120 RVA: 0x001FED88 File Offset: 0x001FCF88
	private void KCLCJADHJEH()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.IsBusy())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
			AudioManager.EHBBFMCILPC.ResetAudioSettings();
		}
	}

	// Token: 0x060046C9 RID: 18121 RVA: 0x001FC08D File Offset: 0x001FA28D
	private void OPDNFDDHIDB()
	{
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
	}

	// Token: 0x060046CA RID: 18122 RVA: 0x001FEE10 File Offset: 0x001FD010
	private void CMNOPAIJJDP()
	{
		if (this.HFOPCMIHDOL.PMCHHGLPPAJ() == null)
		{
			return;
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		if (this.HFOPCMIHDOL.PMCHHGLPPAJ().PINCOCDOOGH())
		{
			this.HFOPCMIHDOL.PMCHHGLPPAJ().FEHODJMIAJL(0f, 1);
		}
	}

	// Token: 0x060046CB RID: 18123 RVA: 0x001FEE74 File Offset: 0x001FD074
	private void KGELMKIBOIJ(string FOCIFOLONJD)
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.CMBLMOJFGAE.Count; i++)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.CMBLMOJFGAE[i].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list.Add(this.CMBLMOJFGAE[i]);
			}
			else
			{
				list2.Add(this.CMBLMOJFGAE[i]);
			}
		}
		this.CMBLMOJFGAE = list2;
		base.StartCoroutine(this.JHDEBFCKKJA(list));
	}

	// Token: 0x060046CC RID: 18124 RVA: 0x001FEF0C File Offset: 0x001FD10C
	private void MDGOPJKEIAN(string FOCIFOLONJD)
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.LLEHEBBHAOD.Count; i++)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.LLEHEBBHAOD[i].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list.Add(this.LLEHEBBHAOD[i]);
			}
			else
			{
				list2.Add(this.LLEHEBBHAOD[i]);
			}
		}
		this.LLEHEBBHAOD = list2;
		base.StartCoroutine(this.EDMPMIMIFED(list));
	}

	// Token: 0x060046CD RID: 18125 RVA: 0x001FEFA3 File Offset: 0x001FD1A3
	private void MDMJIDKABLD()
	{
		this.KBBPBKJEFCJ();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.UpdateGamePassOptions(false, true, true);
		}
	}

	// Token: 0x060046CE RID: 18126 RVA: 0x001FEFC8 File Offset: 0x001FD1C8
	private bool LHBMEFGCPHK()
	{
		int num;
		if (PlayerPrefs.HasKey("post"))
		{
			num = PlayerPrefs.GetInt("post");
		}
		else
		{
			num = 1;
		}
		return num == 1 && NBDLBFJOEGN.LHBMEFGCPHK();
	}

	// Token: 0x060046CF RID: 18127 RVA: 0x001FF000 File Offset: 0x001FD200
	private bool LJNABDDPANA(string KHJMANDEDMA)
	{
		string value = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.name.Equals(value))
			{
				return true;
			}
		}
		try
		{
			for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
			{
				for (int k = 0; k < this.CHHIBBOICAD[j].mappings.Count; k++)
				{
					if (this.CHHIBBOICAD[j].mappings[k].Equals(value))
					{
						return true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060046D0 RID: 18128 RVA: 0x001FF0D0 File Offset: 0x001FD2D0
	private void GCFJDDOEPBN(int MCLBOIFEFGH)
	{
		try
		{
			if (!(null == this.HFFIIBBJBMH) && !(null == this.HFFIIBBJBMH.header))
			{
				if (MCLBOIFEFGH != 100 || (!KHPGPLAMAIN.EJCNHEBIOJF() && KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd))
				{
					CustomFaderSettings customFaderSettings = this.HFFIIBBJBMH.header.HGIIJABNDCD(MCLBOIFEFGH);
					if (customFaderSettings != null)
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCustomFader, customFaderSettings.assetIndex, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060046D1 RID: 18129 RVA: 0x001FF168 File Offset: 0x001FD368
	public static List<int> GetActiveWardrobeMixList(PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (LFLOCKNKAKC == null)
		{
			return null;
		}
		try
		{
			AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI);
			int num = LFLOCKNKAKC.DHONIOBOLEL.DDEDAHCFHJN();
			if (null != assetStoryHeader && num >= 0 && num < assetStoryHeader.chapterAssetPacks.Count)
			{
				List<int> list = SceneStoryManager.ParseWardrobeMixOverride(assetStoryHeader.chapterAssetPacks[num].wardrobeMixOverride);
				if (list != null)
				{
					return list;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (LFLOCKNKAKC.NCAMFPGMCIG.BFFOPDBKCHF.Count > 0)
		{
			return LFLOCKNKAKC.NCAMFPGMCIG.BFFOPDBKCHF;
		}
		return null;
	}

	// Token: 0x060046D2 RID: 18130 RVA: 0x001FF20C File Offset: 0x001FD40C
	public static bool LoungeMappingUnlockReached(ECJCFGAOPHJ FFACCDIEBIA, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return SceneStoryManager.LoungeMappingGateReached(LFLOCKNKAKC, FFACCDIEBIA.PBGKGCHMHOP, FFACCDIEBIA.CGKKPPEIFJH);
	}

	// Token: 0x060046D3 RID: 18131 RVA: 0x001FF220 File Offset: 0x001FD420
	private List<string> LANHEHAJDJJ(StoryEnvironmentManager DCEEBNNKPGJ, List<string> MLEIAEEFNEB, List<string> IJKHEHEJOAM)
	{
		List<GameObject> list = new List<GameObject>();
		try
		{
			SceneStoryManager.FindAllObjectsInChildren(DCEEBNNKPGJ.gameObject, list);
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < this.FAEEEHDCNDN.Count; j++)
				{
					if (this.FAEEEHDCNDN[j].gameObject == list[i] && list[i].activeSelf && !list[i].name.Contains("layervideo") && !MLEIAEEFNEB.Contains(list[i].name))
					{
						if (!IJKHEHEJOAM.Contains(list[i].name))
						{
							MLEIAEEFNEB.Add(list[i].name);
						}
						else
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Layer " + list[i].name + " stripped from saved cutscene data because it was earlier hidden with LAYERHIDE. Looks like this might be a sleeping particle emitter.");
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return MLEIAEEFNEB;
	}

	// Token: 0x060046D4 RID: 18132 RVA: 0x001FF330 File Offset: 0x001FD530
	private IEnumerator IEJEKBFECKP()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		if (this.BBAHMGCCIHJ() > 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyLounge, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueCustomEffectsBundles(this.HFFIIBBJBMH.header);
		if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && AssetsManager.EHBBFMCILPC.lobbyDataAsset.PIECGBHMOCB())
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData5, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.QueueFrameContainerBundle(0);
		}
		this.GCFJDDOEPBN(100);
		if (this.HFFIIBBJBMH.header.CKACBBGHJGI() != this.HFFIIBBJBMH.header.index)
		{
			AssetsManager.EHBBFMCILPC.QueueCustomEffectsBundles(GKJPOGNFKNK.BDEJIINKEHH(this.HFFIIBBJBMH.header.CKACBBGHJGI()));
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		this.LHGNMIOGHGJ = 0f;
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLoungeScreenAssetsDownloadSuccess", "OnLoungeScreenAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x060046D5 RID: 18133 RVA: 0x001FF33F File Offset: 0x001FD53F
	public void OnAvatarClick()
	{
		if (this.MCIGJBFKOIJ)
		{
			return;
		}
		this.MCIGJBFKOIJ = true;
		base.StartCoroutine(this.LCNJLBEOKPB());
	}

	// Token: 0x060046D6 RID: 18134 RVA: 0x001FF360 File Offset: 0x001FD560
	private CharacterRenderTexturePool.AHLNEABNMOA COBFDNJNGJM(string PDEADFPONFH, string CCKEOHHEKFF, FLNOFHCNJDM GFIMGNJBJHH, FLNOFHCNJDM PMDGGEDPHJC)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		GameObject gameObject = null;
		float num = 1238f;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KMEJKFACOIC())
			{
				result = null;
			}
			else
			{
				this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
				if (null == this.EBHJLLIHIFE)
				{
					result = null;
				}
				else
				{
					RectTransform component = this.nonPlayerCharacterPivot.GetComponent<RectTransform>();
					ahlneabnmoa = this.EBHJLLIHIFE.JLJJGLCLLLE(component, component);
					if (ahlneabnmoa == null)
					{
						result = null;
					}
					else
					{
						gameObject = ahlneabnmoa.JAGHCEBFABP;
						gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
						NonPlayerCharacterManager oidnmecilmm = ahlneabnmoa.OIDNMECILMM;
						oidnmecilmm.Initialize(PDEADFPONFH, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.center, false);
						SceneStoryManager.OMOGKJCMCKF(PDEADFPONFH);
						num = NonPlayerCharacterManager.KHKGMAFGLGH();
						oidnmecilmm.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromRight);
						if (num > 1110f)
						{
							NonPlayerCharacterManager.SetCustomFadeInTime(num);
						}
						oidnmecilmm.CFKKICCKOAI(GFIMGNJBJHH, BIDPEOLOIIG.appearImmediateFade, PMDGGEDPHJC);
						this.JOFJNLHIJOB.Add(this.GLDAJFNCFKC(CCKEOHHEKFF, gameObject));
						result = ahlneabnmoa;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			bool flag = false;
			for (int i = 1; i < this.JOFJNLHIJOB.Count; i += 0)
			{
				if (null != gameObject && this.JOFJNLHIJOB[i].IACFDHCDEME == gameObject)
				{
					flag = false;
					break;
				}
			}
			if (!flag && null != this.EBHJLLIHIFE && ahlneabnmoa != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(ahlneabnmoa);
			}
			if (num > 1469f && NonPlayerCharacterManager.DEMKCBJMEFL() <= 28f)
			{
				NonPlayerCharacterManager.SetCustomFadeInTime(num);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x060046D7 RID: 18135 RVA: 0x001FF4EC File Offset: 0x001FD6EC
	private void OPLBCELFMLI()
	{
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("CameraBundlesVFXTopMost"))
			{
				if (null != this.cameras[i].gameObject.GetComponent<BlurOptimized>())
				{
					this.cameras[i].gameObject.GetComponent<BlurOptimized>().enabled = true;
					return;
				}
				break;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x060046D8 RID: 18136 RVA: 0x001FF56C File Offset: 0x001FD76C
	private void DDDEHHANLKH(bool HDEDCEHDHJD)
	{
		if (null != this.saveCutsceneButton && (HDEDCEHDHJD || this.saveCutsceneButton.GetVisibilityTime() > 10f))
		{
			this.CODFIPHLBLE = null;
			this.saveCutsceneButton.Hide();
			this.GLOEGOPLGDN();
			this.AIGBJLAPFLH();
		}
	}

	// Token: 0x060046D9 RID: 18137 RVA: 0x001FF5BC File Offset: 0x001FD7BC
	private void HJDHHDGNMII()
	{
		this.AMBEPJCICOF();
		this.MCIGJBFKOIJ = false;
		this.NHDMFANLHPE++;
		if (this.NHDMFANLHPE >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			this.NHDMFANLHPE = 0;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnStyToLng.ToString(), false, false);
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverrideWithCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.EPKNCKGNNCE), new UnityAction(this.NPHADLHOLJF), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		base.StartCoroutine(this.MCGBMAOMOIC());
	}

	// Token: 0x060046DA RID: 18138 RVA: 0x001FF6A8 File Offset: 0x001FD8A8
	private void NILCOMEBIJN(FGINKFGNNEK FMGKDBELFJN)
	{
		NonPlayerCharacterManager component = FMGKDBELFJN.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
		FEMKDIHKJCM lastDialogStep = component.GetLastDialogStep();
		string dbhmnecmiab = FMGKDBELFJN.DBHMNECMIAB;
		string text = this.PDPBHJFFFDD(lastDialogStep.IHCMBIBJBJD);
		FLNOFHCNJDM gfimgnjbjhh = HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(lastDialogStep.LECOLKOALNK));
		FLNOFHCNJDM pmdggedphjc = HLDNEMHDEDH.INAHLPLJEDP(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(lastDialogStep.EMMOPBJCKGE));
		this.PromoteLoungeNpcAssetToChapterLifetime(text);
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		list.Add(FMGKDBELFJN);
		this.PKPMIABFBON.Remove(FMGKDBELFJN);
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		FGINKFGNNEK fginkfgnnek = this.LBCMMKJBNFH(dbhmnecmiab);
		if (fginkfgnnek != null)
		{
			list2.Add(fginkfgnnek);
			this.JOFJNLHIJOB.Remove(fginkfgnnek);
		}
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		GameObject gameObject = null;
		try
		{
			ahlneabnmoa = this.DFPBPDICPMM(text, dbhmnecmiab, gfimgnjbjhh, pmdggedphjc);
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
			gameObject.transform.SetParent(this.nonPlayerCharacterPivot.transform, false);
			NonPlayerCharacterManager component2 = gameObject.GetComponent<NonPlayerCharacterManager>();
			component2.Initialize(text, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.right, false);
			SceneStoryManager.OMOGKJCMCKF(text);
			component2.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromRight);
			component2.SetEmotion(gfimgnjbjhh, BIDPEOLOIIG.appearDelayed, pmdggedphjc);
			component2.RecordLineEmotion(gfimgnjbjhh, pmdggedphjc);
			if (component.DialogsDestroyedByStep())
			{
				component2.SetLastDialogStep(lastDialogStep);
				component2.MarkDialogsDestroyedByStep();
			}
			else
			{
				component2.ShowDialog(this.dialogNonPlayerCharacterPrefab, lastDialogStep, FJOIFOINENC.animationAppear);
			}
			this.PKPMIABFBON.Add(this.GLDAJFNCFKC(dbhmnecmiab, gameObject));
			if (ahlneabnmoa != null)
			{
				component2.SetVisibility(false);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != gameObject)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
			if (ahlneabnmoa != null)
			{
				FGINKFGNNEK fginkfgnnek2 = this.LBCMMKJBNFH(dbhmnecmiab);
				if (fginkfgnnek2 != null)
				{
					this.JOFJNLHIJOB.Remove(fginkfgnnek2);
					if (null != fginkfgnnek2.IACFDHCDEME)
					{
						UnityEngine.Object.Destroy(fginkfgnnek2.IACFDHCDEME);
					}
				}
				if (null != this.EBHJLLIHIFE)
				{
					this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
				}
			}
		}
		component.HideDialogsAtOnce();
		component.HideAtOnce();
		if (fginkfgnnek != null && null != fginkfgnnek.IACFDHCDEME)
		{
			NonPlayerCharacterManager component3 = fginkfgnnek.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
			if (null != component3)
			{
				component3.HideAtOnce();
			}
		}
		base.StartCoroutine(this.MPFIIEOFHIM(list));
		if (list2.Count > 0)
		{
			base.StartCoroutine(this.FBJPMNDLLID(list2));
		}
		LPEMDECEIAO.EIGLJFIOJPE(text);
	}

	// Token: 0x060046DB RID: 18139 RVA: 0x001FF930 File Offset: 0x001FDB30
	private void HBLMNLBCGMD()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 1)
		{
			if (this.GFIFDKBLLBL.variablesState[this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF] != null)
			{
				if (this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NNPHNLPDFBC() == ABNHFKAOGPO.integer)
				{
					ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF, DPGJIJGOCIC.NGPBBENCADG(text));
				}
				else
				{
					this.GFIFDKBLLBL.variablesState[this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF] = text;
				}
			}
		}
		else if (DialogReadInputManager.GetPlaceholderText() != null && DialogReadInputManager.GetPlaceholderText().Length > 0)
		{
			if (this.GFIFDKBLLBL.variablesState[this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF] != null)
			{
				if (this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NNPHNLPDFBC() == ABNHFKAOGPO.integer)
				{
					ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF, DPGJIJGOCIC.NGPBBENCADG(DialogReadInputManager.GetPlaceholderText()));
				}
				else
				{
					this.GFIFDKBLLBL.variablesState[this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF] = DialogReadInputManager.GetPlaceholderText();
				}
			}
		}
		else if (this.GFIFDKBLLBL.variablesState[this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF] != null)
		{
			if (this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NNPHNLPDFBC() == ABNHFKAOGPO.integer)
			{
				ONEHEBIHPFB.PAOFLKEKLMA(this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF, 123456);
			}
			else
			{
				this.GFIFDKBLLBL.variablesState[this.HFOPCMIHDOL.MPNOOGGNKAJ().JLLMJEEPGIM().NBKPJCODNKF] = "error";
			}
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		this.HFOPCMIHDOL.MPNOOGGNKAJ().FEHODJMIAJL(0f, 1);
	}

	// Token: 0x060046DC RID: 18140 RVA: 0x001FFB68 File Offset: 0x001FDD68
	private bool PPOAAOKBFCN(MOLKEIABAOJ DLKCKCKOCOI)
	{
		SceneStoryManager.KODEFAMOIKH kodefamoikh = new SceneStoryManager.KODEFAMOIKH();
		kodefamoikh.<>4__this = this;
		bool result;
		try
		{
			if (!EnvironmentMorphManager.MorphFeatureAllowed())
			{
				result = false;
			}
			else
			{
				if (null == this.DMNJMLDEILJ)
				{
					this.DMNJMLDEILJ = base.gameObject.AddComponent<EnvironmentMorphManager>();
				}
				if (this.DMNJMLDEILJ.IsCapturing())
				{
					result = true;
				}
				else
				{
					for (int i = 0; i < DLKCKCKOCOI.JPHIPBEBNGD().GIPMNEKDKIL.Count; i++)
					{
						if (DLKCKCKOCOI.JPHIPBEBNGD().GIPMNEKDKIL[i].Contains("layervideo"))
						{
							return false;
						}
					}
					for (int j = 0; j < this.FAEEEHDCNDN.Count; j++)
					{
						if (null != this.FAEEEHDCNDN[j] && this.FAEEEHDCNDN[j].gameObject.activeInHierarchy && this.FAEEEHDCNDN[j].gameObject.name.ToLowerInvariant().Contains("layervideo"))
						{
							return false;
						}
					}
					for (int k = 0; k < this.fadeLayers.Count; k++)
					{
						if (null != this.fadeLayers[k] && this.fadeLayers[k].gameObject.activeSelf)
						{
							return false;
						}
					}
					Camera camera = null;
					for (int l = 0; l < this.cameras.Count; l++)
					{
						if (this.cameras[l].gameObject.name.Contains("CameraBundlesVFXFront"))
						{
							camera = this.cameras[l];
							break;
						}
					}
					if (null == camera)
					{
						result = false;
					}
					else
					{
						BlurOptimized component = camera.gameObject.GetComponent<BlurOptimized>();
						if (null != component && component.enabled)
						{
							result = false;
						}
						else if (!this.DMNJMLDEILJ.MorphAvailable())
						{
							result = false;
						}
						else
						{
							kodefamoikh.stepDesc = DLKCKCKOCOI;
							this.DMNJMLDEILJ.BeginCapture(camera, new TweenCallback(kodefamoikh.NDALNHLFPHD), new TweenCallback(kodefamoikh.LINOAKGHBLF));
							result = true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x001FFDB0 File Offset: 0x001FDFB0
	public void OnPopupNotEnoughEnergyOrHardCurrencyGetMore2()
	{
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
		if (this.HAFFEDMEIAF)
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(true);
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x001FFE0C File Offset: 0x001FE00C
	private void OJHDFOGKIBN()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (SceneStoryManager.achievementSyncReward > 0)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.INKJIBDDMLL().OGKGHLHHAAI("large"), CCOJBMMKNAP.DLGLFACMHPG().OBDCPLLLGBB(""), CCOJBMMKNAP.DLGLFACMHPG().HHLECNIFHCO("OnStoryChoiceClick"), new UnityAction(this.AADJGGEMOJD), new UnityAction(this.AADJGGEMOJD), (DFGILFBGPLN)(-21), 1388f, 43).ECCFLOFCFNN(SceneStoryManager.achievementSyncReward);
			return;
		}
		this.AADJGGEMOJD();
	}

	// Token: 0x060046DF RID: 18143 RVA: 0x001FFE94 File Offset: 0x001FE094
	public List<AssetStoryItem> GetStoryItemsAssets()
	{
		return this.BAFONBJIKLA;
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x001FFE9C File Offset: 0x001FE09C
	private void MLDJOHGCHEB()
	{
		if (this.GKHNIMJJLJL.DHONIOBOLEL.AJPIKAACMKL > 0 && this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
		}
	}

	// Token: 0x060046E1 RID: 18145 RVA: 0x001FFED8 File Offset: 0x001FE0D8
	private float FPDIPLAGOAL()
	{
		float result = 0f;
		NonPlayerCharacterManager.SetEmotionsSystemVersion(0);
		PlayerCharacterManager.SetEmotionsSystemVersion(0);
		ImageFrameAnimation.SetAnimationSystemVersionOverride(-1);
		if (null != this.FJIBKABPIGJ)
		{
			if (SceneStoryManager.chapterSecurityKey.Length != 0)
			{
				HLDNEMHDEDH.KFLJAOIIFIC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BNPGFECDNAM, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HIEEGGEJEEG);
				try
				{
					this.IFLGCDMCEGD = DPGJIJGOCIC.FPEMHPCGMNJ(this.FJIBKABPIGJ.text, SceneStoryManager.chapterSecurityKey);
				}
				catch (Exception aklgbjkdomm)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("storyloaderr4"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnBackClick), new UnityAction(this.OnBackClick), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					return 0f;
				}
				if (this.IFLGCDMCEGD.Contains("DEFAULTLANG"))
				{
					try
					{
						this.GFIFDKBLLBL = new Story(this.IFLGCDMCEGD);
						ONEHEBIHPFB.DKGAAPOONJJ(this.GFIFDKBLLBL);
					}
					catch (Exception aklgbjkdomm2)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("storyloaderr1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnBackClick), new UnityAction(this.OnBackClick), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						return 0f;
					}
					this.OALBPJBKNNN();
					this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
					if (null != this.HFFIIBBJBMH)
					{
						DHGFCJGJFOB.KPHNADKJHMJ = this.HFFIIBBJBMH.header;
					}
					else
					{
						DHGFCJGJFOB.KPHNADKJHMJ = null;
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE.Length > 0 && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0] == AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[1])
					{
						AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE = "";
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("savecorrupterr"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE.Length > 0)
					{
						try
						{
							this.GFIFDKBLLBL.state.LoadJson(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE);
						}
						catch (Exception aklgbjkdomm3)
						{
							CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("storyloaderr2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnBackClick), new UnityAction(this.OnBackClick), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							return 0f;
						}
					}
					if (this.LJNABDDPANA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL))
					{
						this.MEBPBAJKLAP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL);
						this.NFGHFMEEBHN(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, (FCABOFEGPGP)AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB, DBONHDHEKDG.immediate, Ease.InOutCubic);
						this.MEEKOPBHLDB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL, (PHALBCMBPPL)AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ONNHAPFMDEN, DBONHDHEKDG.immediate, Ease.InOutCubic);
						this.preWarmFader.gameObject.SetActive(false);
					}
					else
					{
						this.preWarmFader.gameObject.SetActive(true);
					}
					if (this.BFOEOHEAPEK(false) && this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 2 && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
					{
						result = KHPGPLAMAIN.ALOONLDKBHD();
					}
					AudioManager.EHBBFMCILPC.FadeMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NPAFPMIMGLH, 1f);
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO.Length > 0)
					{
						AudioManager.EHBBFMCILPC.PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO), -1f);
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL.Length > 0)
					{
						if (this.HFFIIBBJBMH.header.ambientFreeAudio)
						{
							AudioManager.EHBBFMCILPC.PlayMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL, true, 1f, false);
						}
						else
						{
							AudioManager.EHBBFMCILPC.PlayMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL, false, 1f, false);
						}
					}
					DFKBHGBFNHB.IMIDHJMEGOG = LanguageManager.FromString(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IMIDHJMEGOG);
					if (null != this.storyChatPrefab)
					{
						if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPAEFOJDLFC != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPAEFOJDLFC.Length > 0)
						{
							this.HPAEFOJDLFC = new PFADAFAHNNJ(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPAEFOJDLFC);
						}
						else
						{
							this.HPAEFOJDLFC = null;
						}
						if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GOPGELMBMMK != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GOPGELMBMMK.Length > 0)
						{
							this.GOPGELMBMMK = new CKBCHMOAKLK(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GOPGELMBMMK);
							this.ICJLNPJOIHP(0);
						}
						else
						{
							this.GOPGELMBMMK = null;
						}
					}
					else
					{
						if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPAEFOJDLFC != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPAEFOJDLFC.Length > 0)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("storyChatPrefab is null!");
						}
						if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GOPGELMBMMK != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GOPGELMBMMK.Length > 0)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("storyChatPrefab is null!");
						}
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JMNMOHIKHLB != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JMNMOHIKHLB.Length > 0)
					{
						this.JMNMOHIKHLB = new PMNHKIDIMLM(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JMNMOHIKHLB);
						this.ABDHFNHFBMP(this.JMNMOHIKHLB);
						try
						{
							if (this.JMNMOHIKHLB.AIOHLJPBHGH())
							{
								ApplicationFocusManager.Activate();
							}
							goto IL_7A7;
						}
						catch (Exception aklgbjkdomm4)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
							goto IL_7A7;
						}
					}
					this.JMNMOHIKHLB = null;
					IL_7A7:
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JGEDOIDOPLA != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JGEDOIDOPLA.Length > 0)
					{
						this.JGEDOIDOPLA = new JJBCFINBFKL(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JGEDOIDOPLA);
					}
					else
					{
						this.JGEDOIDOPLA = null;
					}
					this.BPKMDANBJKG(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC == 1 || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0);
					this.GLIMDKBANOI = true;
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FHOEAHABNJI = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GLGECPFJIKB;
					this.HLBIEIAFBFK();
					NonPlayerCharacterManager.SetEmotionsSystemVersion(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBFMMELGCLM());
					PlayerCharacterManager.SetEmotionsSystemVersion(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBFMMELGCLM());
					ImageFrameAnimation.SetAnimationSystemVersionOverride(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CEIOOCHCDCF());
					AnimationTranslation.SetTranslationSystemVersion(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BPCDDHNOJNF());
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKCAKJMDBBL >= 2)
					{
						this.OHAIEJKIMFG(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKCAKJMDBBL);
					}
					this.AMBEPJCICOF();
					return result;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("storyloaderr3"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnBackClick), new UnityAction(this.OnBackClick), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
				return result;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("storyloaderr0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnBackClick), new UnityAction(this.OnBackClick), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Ink asset is null!");
		}
		return result;
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x002008A0 File Offset: 0x001FEAA0
	private void BMFMDBHJDMI()
	{
		this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
	}

	// Token: 0x060046E3 RID: 18147 RVA: 0x000AD70A File Offset: 0x000AB90A
	private void FKPLFIDCPLP()
	{
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x060046E4 RID: 18148 RVA: 0x002008B8 File Offset: 0x001FEAB8
	public static bool AnyLoungeCharacterInActiveWardrobe()
	{
		return SceneStoryManager.AnyLoungeCharacterInActiveWardrobe(StoryInterfaceHeaderManager.anthologyIndex, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
	}

	// Token: 0x060046E5 RID: 18149 RVA: 0x002008CE File Offset: 0x001FEACE
	private IEnumerator BHBBJJCHMDF()
	{
		SceneStoryManager.BDCPNLEEMCJ bdcpnleemcj = new SceneStoryManager.BDCPNLEEMCJ(1);
		bdcpnleemcj.<>4__this = this;
		return bdcpnleemcj;
	}

	// Token: 0x060046E6 RID: 18150 RVA: 0x002008E0 File Offset: 0x001FEAE0
	private void AEIMHFMIIJH(string NPDMAHPIBOB)
	{
		if (null != this.imageEffects)
		{
			for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN.Count; i++)
			{
				string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN[i];
				if (text.Contains("CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution." + NPDMAHPIBOB))
				{
					text = text.Substring(1, text.IndexOf("OnRewardFreeSpinsClick"));
				}
				this.imageEffects.NILOLGICBNO(text);
			}
		}
		if (null != this.imageEffectsOvr)
		{
			for (int j = 1; j < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN.Count; j++)
			{
				string text2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN[j];
				if (text2.Contains("</i>" + NPDMAHPIBOB))
				{
					text2 = text2.Substring(0, text2.IndexOf("  "));
				}
				this.imageEffectsOvr.PHFIOBNKDAG(text2);
			}
		}
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x002009F0 File Offset: 0x001FEBF0
	private void KGANLLIIMPF()
	{
		int num = this.HNHECDGGJMP();
		for (int i = 0; i < num; i++)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.ANPGJMAGFAP(i);
			try
			{
				int num2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CGPADEOMODB(i);
				for (int j = 0; j < num2; j++)
				{
					DOLBFGIPPOG dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LBKGOLJABNI(j, i);
					for (int k = 0; k < 0; k++)
					{
						if (dolbfgippog != null && dolbfgippog.OHCMCJHDMOH[k] != null && dolbfgippog.OHCMCJHDMOH[k].Length > 1)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)k, dolbfgippog.OHCMCJHDMOH[k], this.PCDHECPEOAJ());
							if (null != assetAvatarComponent && (assetAvatarComponent.exposition == HPKJCKOHAAI.exposed || assetAvatarComponent.exposition == HPKJCKOHAAI.exposed))
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GGKPAGAGMGA(assetAvatarComponent.GHCGNMLDCHF().index, i);
							}
						}
					}
				}
				int num3 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CICAPKJLJNI(i);
				for (int l = 0; l < num3; l += 0)
				{
					DOLBFGIPPOG dolbfgippog2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PLLBOBIHPLK(l, i);
					for (int m = 1; m < 2; m++)
					{
						if (dolbfgippog2 != null && dolbfgippog2.OHCMCJHDMOH[m] != null && dolbfgippog2.OHCMCJHDMOH[m].Length > 1)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)m, dolbfgippog2.OHCMCJHDMOH[m], this.PCDHECPEOAJ());
							if (null != assetAvatarComponent && (assetAvatarComponent.exposition == HPKJCKOHAAI.exposed || assetAvatarComponent.exposition == (HPKJCKOHAAI)3))
							{
								AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GGKPAGAGMGA(assetAvatarComponent.KOEBNCFMFJD().index, i);
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x00200BEC File Offset: 0x001FEDEC
	private static bool OLHKLMOGABO(int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		return SceneStoryManager.LoungeMappingGateReached(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP(), NLLCKPCKGOH, OLKMHHNMDLP);
	}

	// Token: 0x060046E9 RID: 18153 RVA: 0x00200BFF File Offset: 0x001FEDFF
	public void FKBBHHHNHFJ()
	{
		PurchaseManagerBridge.IDMLJFBNHML().CMAKHBMINLG().Initialize();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.CJMBIPFMBKG));
	}

	// Token: 0x060046EA RID: 18154 RVA: 0x00200C2C File Offset: 0x001FEE2C
	private void GIADKBIIGKK()
	{
		if (this.CBHGEFCFOKP != null)
		{
			base.StopCoroutine(this.CBHGEFCFOKP);
		}
		this.CBHGEFCFOKP = null;
		if (this.FKDGGOOAPEP != null)
		{
			base.StopCoroutine(this.FKDGGOOAPEP);
		}
		this.FKDGGOOAPEP = null;
		this.AMBEPJCICOF();
		this.FJIAGECENLF++;
		if (this.FJIAGECENLF >= KBOJLHAJPCP.JMHLAIKKJCB)
		{
			this.FJIAGECENLF = 0;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnStyOnDemand.ToString(), false, false);
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.KFFKDDGBLBD), new UnityAction(this.KFFKDDGBLBD), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		if (this.FKDGGOOAPEP != null)
		{
			base.StopCoroutine(this.FKDGGOOAPEP);
		}
		this.FKDGGOOAPEP = base.StartCoroutine(this.IOKKBJPPMOL());
	}

	// Token: 0x060046EB RID: 18155 RVA: 0x00200D60 File Offset: 0x001FEF60
	public void LoadRewardScene()
	{
		this.GKHNIMJJLJL.PFHCDMOJOKP();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.HideInterfaceUndoButton();
		}
		SceneStoryManager.anyChapterCompleted = true;
		AdsManagerLP.EHBBFMCILPC.RefreshAdUnits();
		ApplicationFocusManager.Deactivate();
		AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(this.GKHNIMJJLJL, 0);
		this.MBBFJHBFPNB = true;
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NPAFPMIMGLH = 1f;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		SceneRewardManager.storyHeader = this.NJAAOCMPKCD;
		this.LPCBDEBKAIM();
		this.DINBJCKMOMB();
		for (int i = 0; i < this.HFFIIBBJBMH.header.inkStatVariables.Count; i++)
		{
			if (ONEHEBIHPFB.POLPJMIBJNN(this.HFFIIBBJBMH.header.inkStatVariables[i]))
			{
				SceneRewardManager.stats[i] = this.ANIMANJDNII[i].GALKFKBPLCK();
			}
			else
			{
				SceneRewardManager.stats[i] = this.HFFIIBBJBMH.header.inkStatVariablesDefaultValues[i];
			}
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1ChaptEnd.ToString(), true, false);
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		this.LBNCMCAAICC();
	}

	// Token: 0x060046EC RID: 18156 RVA: 0x00200EE0 File Offset: 0x001FF0E0
	private string EGCDKGLDALD(string PDEADFPONFH)
	{
		string result;
		try
		{
			if (PDEADFPONFH == null || PDEADFPONFH.Length == 0)
			{
				result = PDEADFPONFH;
			}
			else
			{
				string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MEHLFOPAOBP(PDEADFPONFH);
				if (text == null || text.Length == 0 || text.Equals(PDEADFPONFH))
				{
					result = PDEADFPONFH;
				}
				else if (null == GKJPOGNFKNK.IAJMHBFGKBA(text, "pmtsuccess"))
				{
					result = PDEADFPONFH;
				}
				else
				{
					result = text;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = PDEADFPONFH;
		}
		return result;
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x000AE1D0 File Offset: 0x000AC3D0
	private void IBMBALMKDBB()
	{
		AppManager.EHBBFMCILPC.RestartApp(true, true);
	}

	// Token: 0x060046EE RID: 18158 RVA: 0x00200F60 File Offset: 0x001FF160
	private void LJCCMKJHIBJ()
	{
		this.NJEPIPLACPC = null;
		try
		{
			if (!(null == this.HFFIIBBJBMH) && !(null == this.HFFIIBBJBMH.header))
			{
				FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(this.HFFIIBBJBMH.header.index);
				if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB)
				{
					List<string> list = new List<string>();
					for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
					{
						for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
						{
							SceneStoryManager.PHICJMOJKKH(list, fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AHKJFFOIBCP);
							SceneStoryManager.PHICJMOJKKH(list, fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].OMDMNLFMICP);
						}
					}
					JSONArray jsonarray = (null != AssetsManager.EHBBFMCILPC.profileDataAsset) ? AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD() : null;
					if (null != jsonarray)
					{
						for (int k = 0; k < jsonarray.Count; k++)
						{
							JSONObject asObject = jsonarray[k].AsObject;
							if (asObject["ant"].AsInt == this.HFFIIBBJBMH.header.index)
							{
								SceneStoryManager.PHICJMOJKKH(list, asObject["var"]);
								SceneStoryManager.PHICJMOJKKH(list, asObject["varCondition"]);
								SceneStoryManager.PHICJMOJKKH(list, asObject["varConditionLocked"]);
							}
						}
					}
					this.NJEPIPLACPC = list;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.NJEPIPLACPC = null;
		}
	}

	// Token: 0x060046EF RID: 18159 RVA: 0x0020114C File Offset: 0x001FF34C
	private void MJILKOBLFAL()
	{
		this.DNGIDKHONMB();
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("CameraBundlesVFXTopMost"))
			{
				if (!(null != this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>()))
				{
					break;
				}
				if (this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().GetLerpDirection() != 0)
				{
					this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().ResetLerp(0);
				}
				this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().enabled = true;
				if (this.ECBMIHCALBG != null)
				{
					base.StopCoroutine(this.ECBMIHCALBG);
					break;
				}
				break;
			}
			else
			{
				i++;
			}
		}
		if (null != this.FNHFGLHODBG)
		{
			DebugSettings.customSpeedFactor = this.FNHFGLHODBG.GetSpeedFactor();
		}
	}

	// Token: 0x060046F0 RID: 18160 RVA: 0x0020124C File Offset: 0x001FF44C
	private bool DEPGGCJLMMD(string BHMFCANHGPF)
	{
		bool result;
		try
		{
			if (BHMFCANHGPF == null || BHMFCANHGPF.Length == 0)
			{
				result = false;
			}
			else
			{
				string text = BHMFCANHGPF;
				int gelbbkhciba = -1;
				if (int.TryParse(BHMFCANHGPF, out gelbbkhciba))
				{
					ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().AFCGFNJNEPD(gelbbkhciba);
					if (ecjcfgaophj == null)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] $SKINAPPLIED: no mapping row with shop index " + gelbbkhciba.ToString() + " - false");
						return false;
					}
					text = ecjcfgaophj.IJEEKLNDJGE;
				}
				bool flag = false;
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH.Count; i++)
				{
					if (text.Equals(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]))
					{
						flag = true;
						break;
					}
				}
				result = (flag && KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC() && AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().EGICLNGPAJO(text));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060046F1 RID: 18161 RVA: 0x00201358 File Offset: 0x001FF558
	private void OFLKKJDKNEE()
	{
		string lfmcdfbankd = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		base.StartCoroutine(this.MDNEDHHGBCO(lfmcdfbankd, false));
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x0020137F File Offset: 0x001FF57F
	private void OHCHDKJDMLI()
	{
		SceneStoryManager.loungePremiumChoicesHistoryState = 3;
		SceneStoryManager.BLMFAKBBMOE.Clear();
		if (this.MNDOHKJIFDD)
		{
			this.MNDOHKJIFDD = false;
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			this.IBMJEMBGAMJ();
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060046F3 RID: 18163 RVA: 0x002013B0 File Offset: 0x001FF5B0
	public static SceneStoryManager EHBBFMCILPC
	{
		get
		{
			if (!SceneStoryManager.IKLAPGJDMNA)
			{
				SceneStoryManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneStoryManager)) as SceneStoryManager);
				if (!SceneStoryManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active SceneStoryManager script on a GameObject in your scene.");
				}
			}
			return SceneStoryManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x060046F4 RID: 18164 RVA: 0x00201400 File Offset: 0x001FF600
	private void EJOGKNNMMGO(string KHJMANDEDMA, float ABJLFDECAAE)
	{
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].Flip(ABJLFDECAAE);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				this.CHHIBBOICAD[j].Flip(ABJLFDECAAE);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. FlipEnvironment(), environment " + text + " not found.");
	}

	// Token: 0x060046F5 RID: 18165 RVA: 0x002014C4 File Offset: 0x001FF6C4
	private bool FKLHOKAGBJN(string LLKODMBJNCF)
	{
		for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN.Count; i++)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN[i].StartsWith(LLKODMBJNCF + "_"))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060046F6 RID: 18166 RVA: 0x00201528 File Offset: 0x001FF728
	private void FKAPLBDKMBM()
	{
		this.AMBEPJCICOF();
		this.DCFBAMCJCFK++;
		if (this.DCFBAMCJCFK >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			this.DCFBAMCJCFK = 0;
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnStyToRew.ToString(), false, false);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.LBNCMCAAICC), new UnityAction(this.LBNCMCAAICC), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		base.StartCoroutine(this.DIIMKKCDBAI());
	}

	// Token: 0x060046F7 RID: 18167 RVA: 0x00201610 File Offset: 0x001FF810
	private void KDBHFEDEMBH(string FOCIFOLONJD)
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.PKPMIABFBON.Count; i++)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.PKPMIABFBON[i].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list.Add(this.PKPMIABFBON[i]);
			}
			else
			{
				list2.Add(this.PKPMIABFBON[i]);
			}
		}
		this.PKPMIABFBON = list2;
		base.StartCoroutine(this.MPFIIEOFHIM(list));
		List<FGINKFGNNEK> list3 = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list4 = new List<FGINKFGNNEK>();
		for (int j = 0; j < this.JOFJNLHIJOB.Count; j++)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.JOFJNLHIJOB[j].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list3.Add(this.JOFJNLHIJOB[j]);
			}
			else
			{
				list4.Add(this.JOFJNLHIJOB[j]);
			}
		}
		this.JOFJNLHIJOB = list4;
		if (list3.Count > 0)
		{
			base.StartCoroutine(this.FBJPMNDLLID(list3));
		}
	}

	// Token: 0x060046F8 RID: 18168 RVA: 0x00201748 File Offset: 0x001FF948
	private void NFOGAJKHADD()
	{
		this.JOKJBAIECCA(true);
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
	}

	// Token: 0x060046F9 RID: 18169 RVA: 0x0020175D File Offset: 0x001FF95D
	private IEnumerator LCNJLBEOKPB()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		if (this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK() == null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		}
		yield return new WaitForSeconds(0.2f);
		for (int i = 0; i < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks.Count; i++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int j = 0; j < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks1.Count; j++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks1[j], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int k = 0; k < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks2.Count; k++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks2[k], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH.Count; l++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI.Count; m++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA.Count; n++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int num = 0; num < this.HFFIIBBJBMH.header.avatarScreenAvatarExtensionPacks.Count; num++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.HFFIIBBJBMH.header.avatarScreenAvatarExtensionPacks[num], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyAvatar, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.QueueFrameContainerBundle(0);
		}
		this.GCFJDDOEPBN(1);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		this.LHGNMIOGHGJ = 0f;
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAvatarScreenAssetsDownloadSuccess", "OnAvatarScreenAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x060046FA RID: 18170 RVA: 0x0020176C File Offset: 0x001FF96C
	private void HJKLOODDLDE(int KIGDFMIENGJ)
	{
		if (this.CODFIPHLBLE != null)
		{
			this.CODFIPHLBLE.APCKKMLICMN += KIGDFMIENGJ;
			if (this.CODFIPHLBLE.APCKKMLICMN >= 3)
			{
				this.DDDEHHANLKH(false);
			}
		}
	}

	// Token: 0x060046FB RID: 18171 RVA: 0x002017A0 File Offset: 0x001FF9A0
	private float GCADKBKMJFP(NGLGPHBGDPD HDBNMILCDGF, float EPLIPBGHKKL = -1f)
	{
		this.GFFLNCOEEKP.DOKill(true);
		this.MGDOAFNHBHP.DOKill(true);
		float num = (float)(HDBNMILCDGF - NGLGPHBGDPD.narrator) * 50f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
		if (Mathf.Abs(num - this.GFFLNCOEEKP.anchoredPosition.x) <= 0.001f)
		{
			return 0f;
		}
		if (EPLIPBGHKKL * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA() >= 0f)
		{
			this.GFFLNCOEEKP.DOAnchorPosX(num, EPLIPBGHKKL * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.InOutCubic);
			this.MGDOAFNHBHP.DOAnchorPosX(num, EPLIPBGHKKL * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.InOutCubic);
			return EPLIPBGHKKL * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA();
		}
		this.GFFLNCOEEKP.DOAnchorPosX(num, this.PGLKLNNMKMO * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.InOutCubic);
		this.MGDOAFNHBHP.DOAnchorPosX(num, this.PGLKLNNMKMO * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.InOutCubic);
		return this.PGLKLNNMKMO * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f) * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA();
	}

	// Token: 0x060046FC RID: 18172 RVA: 0x00201904 File Offset: 0x001FFB04
	private int HNHECDGGJMP()
	{
		try
		{
			if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.HNKINNNFKEO())
			{
				return this.HFFIIBBJBMH.header.customWardrobeSettings.Count;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1;
	}

	// Token: 0x060046FD RID: 18173 RVA: 0x00201968 File Offset: 0x001FFB68
	private void LBJAADKIANK()
	{
		for (int i = 1; i < this.KICOPFEHKJF.Count; i++)
		{
			if (this.KICOPFEHKJF[i] != null && null != this.KICOPFEHKJF[i].IACFDHCDEME)
			{
				ChoiceExtendedManager component = this.KICOPFEHKJF[i].IACFDHCDEME.GetComponent<ChoiceExtendedManager>();
				if (null != component)
				{
					component.UpdateSwipeToBrowse();
				}
			}
		}
	}

	// Token: 0x060046FE RID: 18174 RVA: 0x002019D8 File Offset: 0x001FFBD8
	private IEnumerator IOKKBJPPMOL()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		this.OnGetCdnDataBeforeOnDemandSuccess();
		yield break;
	}

	// Token: 0x060046FF RID: 18175 RVA: 0x002019E8 File Offset: 0x001FFBE8
	public void OnSettingsClick()
	{
		if (FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowSettings(false, this.HFFIIBBJBMH.header.enablePostEffects, true);
			if (this.MOCHJHMLGBG())
			{
				this.ACJLMIELCME();
				return;
			}
		}
		else
		{
			base.StartCoroutine(this.DEMIIEHPNIH());
		}
	}

	// Token: 0x06004700 RID: 18176 RVA: 0x00201A3C File Offset: 0x001FFC3C
	private void CKPJOCNMMIC(string OIPOAEPAJHO)
	{
		bool flag = false;
		bool flag2 = false;
		if (OIPOAEPAJHO.Contains("*"))
		{
			flag2 = true;
			OIPOAEPAJHO = OIPOAEPAJHO.Replace("*", "");
		}
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(OIPOAEPAJHO))
				{
					flag = true;
					this.FAEEEHDCNDN[i].PlayParticles();
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(OIPOAEPAJHO))
			{
				flag = true;
				this.FAEEEHDCNDN[i].PlayParticles();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. PlayParticlesForEnvironmentLayer(), environmentLayer " + OIPOAEPAJHO + " not found.");
		}
	}

	// Token: 0x06004701 RID: 18177 RVA: 0x00201B03 File Offset: 0x001FFD03
	private void CPEELJJHCNA()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
	}

	// Token: 0x06004702 RID: 18178 RVA: 0x00201B20 File Offset: 0x001FFD20
	private void EFCDGMAMICG()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		string[] array = new string[]
		{
			"",
			""
		};
		if (text != null)
		{
			if (!text.Contains(","))
			{
				array[0] = text;
			}
			else
			{
				array = DPGJIJGOCIC.NHEBLMBJNPI(text, ',');
			}
		}
		base.StartCoroutine(this.DLGCDPAFEOB(array[0], array[1]));
	}

	// Token: 0x06004703 RID: 18179 RVA: 0x00201B84 File Offset: 0x001FFD84
	public void OnSaveCutsceneClick()
	{
		this.APDAMLCHICH();
		this.JOKJBAIECCA(false);
		if (this.MOCHJHMLGBG())
		{
			this.ACJLMIELCME();
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(20))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("savecutsceneinfo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.HJLPPAPNOHF), new UnityAction(this.JPCHBHHHCNA), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.HJLPPAPNOHF();
	}

	// Token: 0x06004704 RID: 18180 RVA: 0x00201C1A File Offset: 0x001FFE1A
	private void PLKPCLACANE()
	{
		if (ODJKHCHFKNL.JPEMKKDHHDP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		if (null != this.KOCJONIGKNH)
		{
			this.KOCJONIGKNH.KLHPHJNAJLJ();
			this.KOCJONIGKNH.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004705 RID: 18181 RVA: 0x00201C4F File Offset: 0x001FFE4F
	private void NHOICHJCFKE()
	{
		SceneStoryManager.loungePremiumChoicesHistoryState = 7;
		SceneStoryManager.BLMFAKBBMOE.Clear();
		if (this.MNDOHKJIFDD)
		{
			this.MNDOHKJIFDD = true;
			CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
			this.IBMJEMBGAMJ();
		}
	}

	// Token: 0x06004706 RID: 18182 RVA: 0x00201C80 File Offset: 0x001FFE80
	private void IKDJBGKLNNN()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.INKJIBDDMLL().OGKGHLHHAAI("acomp"), CCOJBMMKNAP.BIAEAOMHBMM().JHNELLJFBGC("lgbtq"), CCOJBMMKNAP.DBFFFOMCLKM().IKMNGFIDCLM("sfxtimeoutwarning"), (DFGILFBGPLN)(-84), 1336f, -54);
	}

	// Token: 0x06004707 RID: 18183 RVA: 0x00201CCE File Offset: 0x001FFECE
	private IEnumerator GIOKPEDGHLA()
	{
		LPEMDECEIAO.IJJJHIGEANA();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(null);
		AudioManager.EHBBFMCILPC.KillMusic("splash", 1f);
		AudioManager.EHBBFMCILPC.KillMusic("mussplash", 1f);
		AudioManager.EHBBFMCILPC.KillMusic("mussplash" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		yield return new WaitForSeconds(CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		StorySplashManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(StorySplashManager)) as StorySplashManager[];
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
		SceneManager.LoadScene("SceneStoryAssetPackSharedClient", LoadSceneMode.Additive);
		while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded("SceneStoryAssetPackSharedClient"))
		{
			yield return null;
		}
		if (this.NJAAOCMPKCD.assetsIndex < 0)
		{
			SceneManager.MergeScenes(SceneManager.GetSceneByName(OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStoryAssetPackSharedClient, -1, -1, -1)), SceneManager.GetSceneByName(OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStory, this.NJAAOCMPKCD.index, -1, -1)));
		}
		else
		{
			SceneManager.MergeScenes(SceneManager.GetSceneByName(OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStoryAssetPackSharedClient, -1, -1, -1)), SceneManager.GetSceneByName(OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStory, this.NJAAOCMPKCD.assetsIndex, -1, -1)));
		}
		this.LFFONLGJFBH();
		if (AssetsManager.IsInitialized())
		{
			AssetsManager.EHBBFMCILPC.RegisterStoryAssets(this);
		}
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStorySplash, -1);
		float num = this.FPDIPLAGOAL();
		LanguageManager.EHBBFMCILPC.ClearCurrentChapterMissingLanguages();
		for (int j = 0; j < LanguageManager.EHBBFMCILPC.environmentSettings.supportedLanguages.Count; j++)
		{
			if (!this.CILHBPNJDFA(this.HODJEPIPDFH, this.GKHNIMJJLJL.DHONIOBOLEL.CFGFOEEEJKJ, LanguageManager.EHBBFMCILPC.environmentSettings.supportedLanguages[j]))
			{
				LanguageManager.EHBBFMCILPC.RegisterCurrenChapterMissingLanguages(LanguageManager.EHBBFMCILPC.environmentSettings.supportedLanguages[j]);
			}
		}
		if (num > 0f)
		{
			base.StartCoroutine(this.GLNGPMHCOEC(num));
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		}
		base.StartCoroutine(this.AHGMHCLFGPL(2.25f + num));
		if (this.GKHNIMJJLJL == null || this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD != 1 || !(null != this.storyChatPrefab) || this.HPAEFOJDLFC == null || this.GOPGELMBMMK == null)
		{
			bool flag = false;
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(56))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(56);
				flag = true;
			}
			else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(57))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(57);
				flag = true;
			}
			else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(58))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(58);
				flag = true;
			}
			if (flag && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLGDMBAINDE.Length > 0)
			{
				base.StartCoroutine(this.HPFHBMJAGIE(1.25f + num));
			}
			else if (null != this.storyInterfaceHeaderManager)
			{
				this.storyInterfaceHeaderManager.PrewarmComponents();
			}
		}
		this.InitTopMatchData();
		this.LJCCMKJHIBJ();
		this.OKAECILDDIK();
		yield return null;
		yield break;
	}

	// Token: 0x06004708 RID: 18184 RVA: 0x00201CE0 File Offset: 0x001FFEE0
	public static bool PremiumChoicePurchasedReal(string EGGMJKBNCJL)
	{
		for (int i = 0; i < SceneStoryManager.freePremiumChoicesFallback.Count; i++)
		{
			if (SceneStoryManager.freePremiumChoicesFallback[i].Equals(EGGMJKBNCJL))
			{
				return true;
			}
		}
		int num = -1;
		try
		{
			num = int.Parse(EGGMJKBNCJL.Substring(EGGMJKBNCJL.IndexOf("id") + 2));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PremiumChoicePurchased(2) - Could not parse choice data:" + EGGMJKBNCJL);
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (int.Parse(EGGMJKBNCJL.Substring(1, EGGMJKBNCJL.IndexOf("id") - 1)) != AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		for (int j = 0; j < SceneStoryManager.freePremiumChoices.Count; j++)
		{
			if (SceneStoryManager.freePremiumChoices[j] == num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004709 RID: 18185 RVA: 0x00201DCC File Offset: 0x001FFFCC
	private void HALIFDCOJJF()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestUndoPremiumChoice(this.GKHNIMJJLJL.DHONIOBOLEL.EBFMKGPBEBO, this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index), "OnBackendUndoPremiumChoiceSuccess", "OnBackendUndoPremiumChoiceException");
	}

	// Token: 0x0600470A RID: 18186 RVA: 0x00201E2C File Offset: 0x0020002C
	private void NLBMHEGAMBK()
	{
		if (this.HFOPCMIHDOL.ACJPLCIFNPO() == null)
		{
			return;
		}
		if (this.JMNMOHIKHLB != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestPremiumChoice(this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.JMNMOHIKHLB.JGLEMENLPJP(this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()), AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index), this.ILJAFHPEKDC, "OnBackendPremiumChoiceSuccess", "OnBackendPremiumChoiceException", false);
			return;
		}
		if (this.JGEDOIDOPLA != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestPremiumChoice(this.JGEDOIDOPLA.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.JGEDOIDOPLA.JGLEMENLPJP(this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()), AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index), this.ILJAFHPEKDC, "OnBackendPremiumChoiceSuccess", "OnBackendPremiumChoiceException", false);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnBackendPremiumChoiceRetry() - invalid situation.");
	}

	// Token: 0x0600470B RID: 18187 RVA: 0x00201FAC File Offset: 0x002001AC
	private void CBHBCGDDMJA()
	{
		this.NJEPIPLACPC = null;
		try
		{
			if (!(null == this.HFFIIBBJBMH) && !(null == this.HFFIIBBJBMH.header))
			{
				FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.KDLMKNDHCIO().MCCJAKIGLBH(this.HFFIIBBJBMH.header.index);
				if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB)
				{
					List<string> list = new List<string>();
					for (int i = 1; i < fjlgcknojmj.OINAAMKLNLO.Count; i += 0)
					{
						for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j += 0)
						{
							SceneStoryManager.PHICJMOJKKH(list, fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AHKJFFOIBCP);
							SceneStoryManager.PHICJMOJKKH(list, fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].OMDMNLFMICP);
						}
					}
					JSONArray jsonarray = (null != AssetsManager.MJBDMHPHMID().profileDataAsset) ? AssetsManager.MJBDMHPHMID().profileDataAsset.GIOFKDDKAPD() : null;
					if (null != jsonarray)
					{
						for (int k = 1; k < jsonarray.Count; k += 0)
						{
							JSONObject asObject = jsonarray[k].AsObject;
							if (asObject[""].AsInt == this.HFFIIBBJBMH.header.index)
							{
								SceneStoryManager.PHICJMOJKKH(list, asObject["sltind"]);
								SceneStoryManager.PHICJMOJKKH(list, asObject["OnBackendGetPublicProfileHallOfFameMoreSuccess"]);
								SceneStoryManager.PHICJMOJKKH(list, asObject[" could not be applied"]);
							}
						}
					}
					this.NJEPIPLACPC = list;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.NJEPIPLACPC = null;
		}
	}

	// Token: 0x0600470C RID: 18188 RVA: 0x00202198 File Offset: 0x00200398
	private int NDBBEDDIOPG(ECJCFGAOPHJ FFACCDIEBIA)
	{
		int num = 0;
		if (FFACCDIEBIA == null || FFACCDIEBIA.APDJNDIIILK == null)
		{
			return num;
		}
		for (int i = 0; i < FFACCDIEBIA.APDJNDIIILK.Count; i++)
		{
			int num2 = FFACCDIEBIA.APDJNDIIILK[i];
			if (num2 / -74 != this.HFFIIBBJBMH.header.CKACBBGHJGI())
			{
				string[] array = new string[5];
				array[1] = "storyChatPrefab is null!";
				array[0] = num2.ToString();
				array[6] = "#";
				array[1] = FFACCDIEBIA.IJEEKLNDJGE;
				array[4] = " <i>";
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
			}
			else
			{
				if (!this.AHKDFKBDBJG.Contains(num2))
				{
					this.AHKDFKBDBJG.Add(num2);
				}
				if (AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundle(num2))
				{
					num += 0;
					if (!this.PCGFKFFPODD.Contains(num2))
					{
						this.PCGFKFFPODD.Add(num2);
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600470D RID: 18189 RVA: 0x00202279 File Offset: 0x00200479
	private void BLECFOJBLLC()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DLGFOOFLKAE("");
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JGMCFGNAICC("");
	}

	// Token: 0x0600470E RID: 18190 RVA: 0x002022B0 File Offset: 0x002004B0
	private void KGMDMKOMOHK(string NPDMAHPIBOB)
	{
		if (null != this.imageEffects)
		{
			for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN.Count; i++)
			{
				string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN[i];
				if (text.Contains("_" + NPDMAHPIBOB))
				{
					text = text.Substring(0, text.IndexOf("_"));
				}
				this.imageEffects.ShowAllEffectsWithTag(text);
			}
		}
		if (null != this.imageEffectsOvr)
		{
			for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN.Count; j++)
			{
				string text2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN[j];
				if (text2.Contains("_" + NPDMAHPIBOB))
				{
					text2 = text2.Substring(0, text2.IndexOf("_"));
				}
				this.imageEffectsOvr.ShowAllEffectsWithTag(text2);
			}
		}
	}

	// Token: 0x0600470F RID: 18191 RVA: 0x002023BF File Offset: 0x002005BF
	private IEnumerator DIIMKKCDBAI()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		this.LBNCMCAAICC();
		yield break;
	}

	// Token: 0x06004710 RID: 18192 RVA: 0x002023D0 File Offset: 0x002005D0
	private void IGNHKDONHED()
	{
		if (CommonUserInterface.FFJPNCFBLLH())
		{
			this.AMBEPJCICOF();
		}
		if (NBDLBFJOEGN.PEGBAOFPMHE(this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH]))
		{
			this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH].KIHLEEJKOOI();
		}
		ONEHEBIHPFB.CIPNAPKAINN(null);
		this.CHHIBBOICAD.Clear();
		this.KEPHFKAHILM.Clear();
		this.FAEEEHDCNDN.Clear();
		this.BAFONBJIKLA.Clear();
		this.ODNCKIKLFCM.Clear();
		if (null != this.IAJFFABJAHB)
		{
			UnityEngine.Object.Destroy(this.IAJFFABJAHB);
			this.IAJFFABJAHB = null;
		}
		try
		{
			if (null != this.IKKEDBBANCO)
			{
				UnityEngine.Object.Destroy(this.IKKEDBBANCO);
				this.IKKEDBBANCO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.GFFLNCOEEKP.DOKill(false);
		this.MGDOAFNHBHP.DOKill(true);
		SceneStoryManager.freePremiumChoicesFallback.Clear();
		SceneStoryManager.freePremiumChoices.Clear();
		SceneStoryManager.loungePremiumChoicesHistoryState = 1;
		SceneStoryManager.BLMFAKBBMOE.Clear();
		this.MNDOHKJIFDD = true;
		SceneStoryManager.achievements = new JSONArray();
		SceneStoryManager.achievementSyncReward = 0;
		if (AssetsManager.IsInitialized())
		{
			AssetsManager.EHBBFMCILPC.UnregisterStoryAssets(this);
		}
		if (this.HFOPCMIHDOL != null)
		{
			this.HFOPCMIHDOL.ILPDFGDNABG();
		}
		this.GFIFDKBLLBL = null;
		this.HFFIIBBJBMH = null;
		DHGFCJGJFOB.KPHNADKJHMJ = null;
		if (SceneStoryManager.IKLAPGJDMNA == this)
		{
			SceneStoryManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06004711 RID: 18193 RVA: 0x0020255C File Offset: 0x0020075C
	private IEnumerator GPFELLDIKJE()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
		}
		this.OHPEONMNFNJ(1);
		if (null != AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0) && !this.NJAAOCMPKCD.chapterAssetPacks[AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN()].preloadAvatarScene)
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
		}
		yield break;
	}

	// Token: 0x06004712 RID: 18194 RVA: 0x0020256C File Offset: 0x0020076C
	private void OGDCCEMFMMG()
	{
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK(" path: loading the chain", 553f);
		this.JGEDOIDOPLA = null;
		this.BPKMDANBJKG(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC != 0 && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0);
	}

	// Token: 0x06004713 RID: 18195 RVA: 0x002025D4 File Offset: 0x002007D4
	private string PDPBHJFFFDD(string DEDFDFBPLFB)
	{
		string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(DEDFDFBPLFB);
		if (text == null || text.Length == 0)
		{
			return DEDFDFBPLFB;
		}
		if (null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
		{
			for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
			{
				if (!(null == this.ODNCKIKLFCM[i]) && this.ODNCKIKLFCM[i].mappings != null)
				{
					for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j++)
					{
						if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
						{
							text = this.ODNCKIKLFCM[i].id;
							break;
						}
					}
				}
			}
		}
		return this.CIEJIFJDIKE(text);
	}

	// Token: 0x06004714 RID: 18196 RVA: 0x002026B8 File Offset: 0x002008B8
	private void DINBJCKMOMB()
	{
		this.DKIDEPAIFED();
		for (int i = 0; i < this.HFFIIBBJBMH.header.inkStatVariables.Count; i++)
		{
			if (ONEHEBIHPFB.POLPJMIBJNN(this.HFFIIBBJBMH.header.inkStatVariables[i]))
			{
				this.ANIMANJDNII[i].EKDHFAODNHF(ONEHEBIHPFB.HPFKIKJIGNF(this.HFFIIBBJBMH.header.inkStatVariables[i]));
			}
			else
			{
				this.ANIMANJDNII[i].EKDHFAODNHF(this.HFFIIBBJBMH.header.inkStatVariablesDefaultValues[i]);
			}
		}
	}

	// Token: 0x06004715 RID: 18197 RVA: 0x00202758 File Offset: 0x00200958
	private CharacterRenderTexturePool.AHLNEABNMOA DFPBPDICPMM(string PDEADFPONFH, string CCKEOHHEKFF, FLNOFHCNJDM GFIMGNJBJHH, FLNOFHCNJDM PMDGGEDPHJC)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		GameObject gameObject = null;
		float num = -1f;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KMEJKFACOIC())
			{
				result = null;
			}
			else
			{
				this.EBHJLLIHIFE = CharacterRenderTexturePool.GetOrCreate();
				if (null == this.EBHJLLIHIFE)
				{
					result = null;
				}
				else
				{
					RectTransform component = this.nonPlayerCharacterPivot.GetComponent<RectTransform>();
					ahlneabnmoa = this.EBHJLLIHIFE.AcquireNonPlayerCharacter(component, component);
					if (ahlneabnmoa == null)
					{
						result = null;
					}
					else
					{
						gameObject = ahlneabnmoa.JAGHCEBFABP;
						gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
						NonPlayerCharacterManager oidnmecilmm = ahlneabnmoa.OIDNMECILMM;
						oidnmecilmm.Initialize(PDEADFPONFH, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.right, false);
						SceneStoryManager.OMOGKJCMCKF(PDEADFPONFH);
						num = NonPlayerCharacterManager.GetCustomFadeInTime();
						oidnmecilmm.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromRight);
						if (num > 0f)
						{
							NonPlayerCharacterManager.SetCustomFadeInTime(num);
						}
						oidnmecilmm.SetEmotion(GFIMGNJBJHH, BIDPEOLOIIG.appearDelayed, PMDGGEDPHJC);
						this.JOFJNLHIJOB.Add(this.GLDAJFNCFKC(CCKEOHHEKFF, gameObject));
						result = ahlneabnmoa;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			bool flag = false;
			for (int i = 0; i < this.JOFJNLHIJOB.Count; i++)
			{
				if (null != gameObject && this.JOFJNLHIJOB[i].IACFDHCDEME == gameObject)
				{
					flag = true;
					break;
				}
			}
			if (!flag && null != this.EBHJLLIHIFE && ahlneabnmoa != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
			}
			if (num > 0f && NonPlayerCharacterManager.GetCustomFadeInTime() <= 0f)
			{
				NonPlayerCharacterManager.SetCustomFadeInTime(num);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06004716 RID: 18198 RVA: 0x002028E4 File Offset: 0x00200AE4
	private void FONKDHOANOH()
	{
		this.KBBPBKJEFCJ();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.UpdateGamePassOptions(false, true, false);
		}
	}

	// Token: 0x06004717 RID: 18199 RVA: 0x00202908 File Offset: 0x00200B08
	private void IAIIODBDKHK()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.ODOPEGPBCCD();
		this.OPEGJAEFAJL();
		this.GOLDLGPECBJ();
		this.KBBPBKJEFCJ();
		if (this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN == KGLBKJKNPFD.LBFFMOMMAPK.environmentSet && this.HFOPCMIHDOL.HJOANJHIHAI().JPHIPBEBNGD().BOPJOMGIJIA == OHAAGENIEMD.BMHGEBOHLHH.waitingForRemoveAdsOfferResponse)
		{
			this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
		}
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
		if (this.HAFFEDMEIAF)
		{
			this.BIMHNCJHLBO();
		}
		this.CBNBDIMFAII();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			this.HBPLGJFPFKM();
		}
	}

	// Token: 0x06004718 RID: 18200 RVA: 0x001FB105 File Offset: 0x001F9305
	public void CJAFGJGJMBC()
	{
		this.KFFKDDGBLBD();
	}

	// Token: 0x06004719 RID: 18201 RVA: 0x002029C2 File Offset: 0x00200BC2
	private void GINDNBPIIIG()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		if (null != this.KOCJONIGKNH)
		{
			this.KOCJONIGKNH.OnAutoReaderStopNoEventDispatch();
			this.KOCJONIGKNH.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600471A RID: 18202 RVA: 0x002029F7 File Offset: 0x00200BF7
	public List<AssetStoryNpc> GetStoryNpcAssets()
	{
		return this.ODNCKIKLFCM;
	}

	// Token: 0x0600471B RID: 18203 RVA: 0x002029FF File Offset: 0x00200BFF
	private void HOPOGGDLFBJ()
	{
		this.NDMCKOKIEMP(true);
		if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
		}
	}

	// Token: 0x0600471C RID: 18204 RVA: 0x00202A30 File Offset: 0x00200C30
	private void POPIBGGFPDL()
	{
		try
		{
			PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
			if (plfdajjhmko != null && plfdajjhmko.NCAMFPGMCIG.DJIGFDJOHCI != null && plfdajjhmko.NCAMFPGMCIG.DJIGFDJOHCI.Length != 0)
			{
				string text = this.PDPBHJFFFDD(plfdajjhmko.NCAMFPGMCIG.DJIGFDJOHCI);
				if (text != null && text.Length != 0)
				{
					List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
					for (int i = 0; i < this.CMBLMOJFGAE.Count; i++)
					{
						if (this.CMBLMOJFGAE[i] != null && !(null == this.CMBLMOJFGAE[i].IACFDHCDEME))
						{
							NonPlayerCharacterManager component = this.CMBLMOJFGAE[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
							if (!(null == component) && (!component.IsEqual(text, plfdajjhmko.NCAMFPGMCIG.AKHCBFGADPJ()) || component.EffectiveLoungePropsChanged()) && (component.GetNpcId() == null || !component.GetNpcId().Equals(text) || component.EffectiveLoungePropsChanged()) && !component.FadedOutByStep() && !(null == GKJPOGNFKNK.IAJMHBFGKBA(text, "")))
							{
								list.Add(this.CMBLMOJFGAE[i]);
							}
						}
					}
					for (int j = 0; j < list.Count; j++)
					{
						this.GJCPKOIJAFK(list[j], text);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600471D RID: 18205 RVA: 0x00202BBC File Offset: 0x00200DBC
	public void OnNeedToOpenLoveInterestsLoungePart2()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.PauseEvents();
			this.storyInterfaceHeaderManager.Hide();
		}
		this.ALGIAIKDEPH();
		this.JCNICMFKAOL();
		if (this.MOCHJHMLGBG())
		{
			this.ACJLMIELCME();
		}
		this.OKKBOFKILEA();
		SceneLoungeManager sceneLoungeManager = AssetsManager.EHBBFMCILPC.GetSceneLoungeManager(0);
		sceneLoungeManager.SetLoungeCharacters(this.LMFEMNCAICA);
		for (int i = 0; i < this.GFIAPGFHIGM.Count; i++)
		{
			GameObject gameObject = this.LDLPKDIFOAD(this.GFIAPGFHIGM[i]);
			if (null == gameObject)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnNeedToOpenLoveInterestsLoungePart2(), lounge environment not found:" + this.GFIAPGFHIGM[i]);
			}
			else
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
				gameObject2.name = gameObject.name;
				sceneLoungeManager.SetLoungeEnvironment(this.GGPMPJOEIJN[i], gameObject2);
				GameObject gameObject3 = this.OBGGHPHGPIO(this.GFIAPGFHIGM[i]);
				if (null != gameObject3)
				{
					GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(gameObject3);
					gameObject4.name = gameObject3.name;
					sceneLoungeManager.SetLoungeEnvironment(this.GGPMPJOEIJN[i], gameObject4);
				}
			}
		}
		sceneLoungeManager.Show(false);
		AudioManager.EHBBFMCILPC.FadeMusic(1f, 1f);
	}

	// Token: 0x0600471E RID: 18206 RVA: 0x00202D05 File Offset: 0x00200F05
	private void MNJMFEMJHGI()
	{
		if (ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.ILJAFHPEKDC = false;
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		this.FNDBICLIGKO();
	}

	// Token: 0x0600471F RID: 18207 RVA: 0x00202D40 File Offset: 0x00200F40
	private void EOKKKLDKJFH()
	{
		this.BODLAMJCHJO = false;
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.OBOOKJPGBJN().IPEIONBNIPH("sai"), CCOJBMMKNAP.COKDLDOAACJ().HHLECNIFHCO("processTransaction"), CCOJBMMKNAP.BFHKGNBFHCH().IKMNGFIDCLM(", to:"), (DFGILFBGPLN)83, 1943f, -72);
	}

	// Token: 0x06004720 RID: 18208 RVA: 0x00202D98 File Offset: 0x00200F98
	public static void JDIGHCGIEPG(GameObject PHLJNFHEEIB, List<GameObject> DCCIKANAEEM)
	{
		DCCIKANAEEM.Add(PHLJNFHEEIB);
		for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i += 0)
		{
			SceneStoryManager.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject, DCCIKANAEEM);
		}
	}

	// Token: 0x06004721 RID: 18209 RVA: 0x00202DDC File Offset: 0x00200FDC
	private void IJKFOHENBDA()
	{
		StarRatingSelector.NDAHJJEONIN(false);
		if ((this.HODJEPIPDFH == 0 && this.NJAAOCMPKCD.index % 2 == 0) || LiveEventsManager.EHBBFMCILPC.AJKBOOKAPBL(EGMCEPOABBF.liveEventMessage, -1, -1) || LiveEventsManager.ONCPHEEJLOP().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeStory, GKJPOGNFKNK.BKBCNMEHGFA(this.HFFIIBBJBMH.header.index), -1))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.AEELGGPEJCC().PGKBCNBAOJN("<"), CCOJBMMKNAP.BFHKGNBFHCH().BDGPNPNIAPA("MonitorAndKillInfiniteRequest() can kill "), CCOJBMMKNAP.APGODIBBPOD().FIENAKIHNOM("layervideo"), CCOJBMMKNAP.KMNBCEMEBBD().PGKBCNBAOJN("Opened from Gley Notification"), new UnityAction(this.HMOKDIODADD), new UnityAction(this.GLMFCONMBID), (DFGILFBGPLN)(-33), 970f, -93);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.CEGAOMEEFBE().JHNELLJFBGC("wdb"), CCOJBMMKNAP.ILACPHFEDEP().DNILNCLIHAP("sig"), CCOJBMMKNAP.CPCOODCFDDP().JLBEIFLLBLO("getHallOfFame"), CCOJBMMKNAP.NIOJNOFGIJO().OGKGHLHHAAI("ok"), new UnityAction(this.COJKOKBNOHM), new UnityAction(this.GLMFCONMBID), (DFGILFBGPLN)(-72), 2f, -90);
	}

	// Token: 0x06004722 RID: 18210 RVA: 0x00202F0C File Offset: 0x0020110C
	public static bool LoungeCharacterInActiveWardrobe(DMDNKJKEPKO CMENACFAEGD, PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (CMENACFAEGD.OIBGFPEGLME < 0)
		{
			return true;
		}
		if (LFLOCKNKAKC == null)
		{
			return false;
		}
		List<int> activeWardrobeMixList = SceneStoryManager.GetActiveWardrobeMixList(LFLOCKNKAKC);
		if (activeWardrobeMixList != null)
		{
			return activeWardrobeMixList.Contains(CMENACFAEGD.OIBGFPEGLME);
		}
		return CMENACFAEGD.OIBGFPEGLME == LFLOCKNKAKC.NCAMFPGMCIG.OIBGFPEGLME;
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x00202F54 File Offset: 0x00201154
	private void ANGDMCODIKK(int MCLBOIFEFGH)
	{
		try
		{
			if (!(null == this.HFFIIBBJBMH) && !(null == this.HFFIIBBJBMH.header))
			{
				CustomFaderSettings customFaderSettings = this.HFFIIBBJBMH.header.HGIIJABNDCD(MCLBOIFEFGH);
				if (customFaderSettings != null)
				{
					for (int i = 0; i < this.HFFIIBBJBMH.header.customFaderSettings.Count; i += 0)
					{
						CustomFaderSettings customFaderSettings2 = this.HFFIIBBJBMH.header.customFaderSettings[i];
						if (customFaderSettings2 != null && customFaderSettings2.index >= 2 && customFaderSettings2.index < -33 && customFaderSettings2.assetIndex == customFaderSettings.assetIndex)
						{
							return;
						}
					}
					AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets((NMKDCBPMCKI)94, customFaderSettings.assetIndex);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004724 RID: 18212 RVA: 0x00203028 File Offset: 0x00201228
	private IEnumerator CDOOJOJAHDP(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<DialogNarratorManager>().DisappearAnimation();
		}
		yield return new WaitForSeconds(DialogNarratorManager.GetDisappearAnimationLength());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		yield return null;
		yield break;
	}

	// Token: 0x06004725 RID: 18213 RVA: 0x00203038 File Offset: 0x00201238
	private void NHEPFIOMFGE()
	{
		try
		{
			PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
			if (plfdajjhmko != null && plfdajjhmko.NCAMFPGMCIG.DJIGFDJOHCI != null && plfdajjhmko.NCAMFPGMCIG.DJIGFDJOHCI.Length != 0)
			{
				string text = this.PDPBHJFFFDD(plfdajjhmko.NCAMFPGMCIG.DJIGFDJOHCI);
				if (text != null && text.Length != 0)
				{
					List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
					for (int i = 0; i < this.CMBLMOJFGAE.Count; i++)
					{
						if (this.CMBLMOJFGAE[i] != null && !(null == this.CMBLMOJFGAE[i].IACFDHCDEME))
						{
							NonPlayerCharacterManager component = this.CMBLMOJFGAE[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
							if (!(null == component) && (!component.IsEqual(text, plfdajjhmko.NCAMFPGMCIG.AKHCBFGADPJ()) || component.EffectiveLoungePropsChanged()) && (component.GetNpcId() == null || !component.GetNpcId().Equals(text) || component.EffectiveLoungePropsChanged()) && !component.FadedOutByStep() && !(null == GKJPOGNFKNK.IAJMHBFGKBA(text, "40BF4E")))
							{
								list.Add(this.CMBLMOJFGAE[i]);
							}
						}
					}
					for (int j = 1; j < list.Count; j++)
					{
						this.GJCPKOIJAFK(list[j], text);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004726 RID: 18214 RVA: 0x002031C4 File Offset: 0x002013C4
	private void EJIFFJPANGA()
	{
		this.KBBPBKJEFCJ();
	}

	// Token: 0x06004727 RID: 18215 RVA: 0x002031CC File Offset: 0x002013CC
	private FGINKFGNNEK MOFKDMPBONJ(string PDEADFPONFH, List<string> MPLEPCPGJBA)
	{
		for (int i = 1; i < this.CMBLMOJFGAE.Count; i += 0)
		{
			if (this.CMBLMOJFGAE[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().IsEqual(PDEADFPONFH, MPLEPCPGJBA))
			{
				return this.CMBLMOJFGAE[i];
			}
		}
		return null;
	}

	// Token: 0x06004728 RID: 18216 RVA: 0x0020321C File Offset: 0x0020141C
	private IEnumerator IPONDEAABJD(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<StoryLogoManager>().DisappearAnimation();
		}
		yield return new WaitForSeconds(StoryLogoManager.GetDisappearAnimationLength());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		yield return null;
		yield break;
	}

	// Token: 0x06004729 RID: 18217 RVA: 0x0020322C File Offset: 0x0020142C
	private void DIIBIOIMPIH()
	{
		BackendOperationsManager.EHBBFMCILPC.RequestUndoPremiumChoice(this.GKHNIMJJLJL.DHONIOBOLEL.EBFMKGPBEBO, this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index), "OnBackendUndoPremiumChoiceSuccess", "OnBackendUndoPremiumChoiceException");
	}

	// Token: 0x0600472A RID: 18218 RVA: 0x00203280 File Offset: 0x00201480
	private void OALBPJBKNNN()
	{
		try
		{
			if (this.IFLGCDMCEGD.Length > 0)
			{
				this.PEGKFFIEEEF = this.IFLGCDMCEGD.IndexOf("$CHAPTEND");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.PEGKFFIEEEF <= 0)
		{
			this.PEGKFFIEEEF = -1;
		}
	}

	// Token: 0x0600472B RID: 18219 RVA: 0x002032DC File Offset: 0x002014DC
	private void MFNKNNHLJAJ()
	{
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		int num4 = 1;
		List<AssetStoryNpc> list = new List<AssetStoryNpc>();
		for (int i = 0; i < this.ODNCKIKLFCM.Count; i += 0)
		{
			if (this.ODNCKIKLFCM[i].LEABBNNGENA() != -118)
			{
				list.Add(this.ODNCKIKLFCM[i]);
			}
			else
			{
				num += 0;
				DPGJIJGOCIC.ADFCDFHBDAF(" (bonus now " + this.ODNCKIKLFCM[i].id);
			}
		}
		this.ODNCKIKLFCM.Clear();
		this.ODNCKIKLFCM = list;
		List<StoryEnvironmentManager> list2 = new List<StoryEnvironmentManager>();
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].DDBEFLAIEIN() != 32)
			{
				list2.Add(this.CHHIBBOICAD[j]);
			}
			else
			{
				num2++;
				this.CHHIBBOICAD[j].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.CHHIBBOICAD[j].gameObject);
				DPGJIJGOCIC.ADFCDFHBDAF("OnSceneLobbyManagerAssetsDownloadFailed" + this.CHHIBBOICAD[j].name);
			}
		}
		this.CHHIBBOICAD.Clear();
		this.CHHIBBOICAD = list2;
		List<StoryEnvironmentManager> list3 = new List<StoryEnvironmentManager>();
		for (int k = 0; k < this.KEPHFKAHILM.Count; k += 0)
		{
			if (this.KEPHFKAHILM[k].GetOnDemandResourcesCheckpointIndex() != -165)
			{
				list3.Add(this.KEPHFKAHILM[k]);
			}
			else
			{
				num3 += 0;
				this.KEPHFKAHILM[k].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.KEPHFKAHILM[k].gameObject);
				DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchRanker - non-lobby UI language " + this.KEPHFKAHILM[k].name);
			}
		}
		this.KEPHFKAHILM.Clear();
		this.KEPHFKAHILM = list3;
		List<StoryEnvironmentLayerManager> list4 = new List<StoryEnvironmentLayerManager>();
		for (int l = 1; l < this.FAEEEHDCNDN.Count; l += 0)
		{
			if (this.FAEEEHDCNDN[l].GetOnDemandResourcesCheckpointIndex() != 73)
			{
				list4.Add(this.FAEEEHDCNDN[l]);
			}
			else
			{
				num4 += 0;
				DPGJIJGOCIC.PJCLICBPPDA("ok" + this.FAEEEHDCNDN[l].name);
			}
		}
		this.FAEEEHDCNDN.Clear();
		this.FAEEEHDCNDN = list4;
	}

	// Token: 0x0600472C RID: 18220 RVA: 0x00203588 File Offset: 0x00201788
	private void AAAGGJBFDLD(string KHJMANDEDMA, float JHBAIJIJIBN)
	{
		if (null != this.DMNJMLDEILJ)
		{
			this.DMNJMLDEILJ.NGHMPDLANMH();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HEFOPKOFLBG() < 5)
		{
			bool flag = true;
			for (int i = 0; i < this.fadeLayers.Count; i += 0)
			{
				if (this.fadeLayers[i].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag = false;
					this.fadeLayers[i].SetFadeInDuration(JHBAIJIJIBN);
					this.fadeLayers[i].FadeIn(null);
				}
				else
				{
					this.fadeLayers[i].JDPKNGACIJL();
				}
			}
			if (!flag)
			{
				KHJMANDEDMA = "[Lounge] half-authored shop row (";
				for (int j = 0; j < this.fadeLayers.Count; j++)
				{
					if (this.fadeLayers[j].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag = true;
						this.fadeLayers[j].NPOEBKBOCJG(JHBAIJIJIBN);
						this.fadeLayers[j].BJIGLKGLAKM(null);
					}
					else
					{
						this.fadeLayers[j].JDPKNGACIJL();
					}
				}
				if (!flag)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("wshcdshc" + KHJMANDEDMA + "cardoptionsloadingthemelostlite");
					return;
				}
			}
		}
		else
		{
			bool flag2 = true;
			for (int k = 0; k < this.fadeLayers.Count; k++)
			{
				if (this.fadeLayers[k].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag2 = true;
					this.fadeLayers[k].OOKMEJPHCBB(JHBAIJIJIBN);
					if (!this.fadeLayers[k].gameObject.activeSelf)
					{
						this.fadeLayers[k].PACBMBLIGNN(null);
					}
					else
					{
						this.fadeLayers[k].FadeInFromCurrent(null);
					}
				}
				else
				{
					this.fadeLayers[k].NCNBINOFOJM();
				}
			}
			if (!flag2)
			{
				KHJMANDEDMA = "OnRewardFreeDiamondsClick";
				for (int l = 0; l < this.fadeLayers.Count; l++)
				{
					if (this.fadeLayers[l].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag2 = true;
						this.fadeLayers[l].BEHIOPAHKKI(JHBAIJIJIBN);
						this.fadeLayers[l].FadeIn(null);
					}
					else
					{
						this.fadeLayers[l].NCNBINOFOJM();
					}
				}
				if (!flag2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("p" + KHJMANDEDMA + "ok");
				}
			}
		}
	}

	// Token: 0x0600472D RID: 18221 RVA: 0x00203814 File Offset: 0x00201A14
	public void OnPopupNotEnoughEnergyOrHardCurrencyDecline()
	{
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(lmhhkdfckfc.DEJCCBNPFEC) != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOffer(lmhhkdfckfc.DEJCCBNPFEC, CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().GetProductThumbnailGraphics(lmhhkdfckfc.DEJCCBNPFEC));
		}
	}

	// Token: 0x0600472E RID: 18222 RVA: 0x0020386C File Offset: 0x00201A6C
	private void OGNJFHPEDNN()
	{
		if (this.FDEBLDDCGGB == 1)
		{
			return;
		}
		try
		{
			if (this.HFOPCMIHDOL.OHOOKBGJFHC() != null)
			{
				MPEEFIAIDBE mpeefiaidbe = this.HFOPCMIHDOL.OHOOKBGJFHC().BKBJDPEFGCE();
				if (mpeefiaidbe != null && (mpeefiaidbe.BOPJOMGIJIA == MPEEFIAIDBE.BMHGEBOHLHH.show || mpeefiaidbe.BOPJOMGIJIA == MPEEFIAIDBE.BMHGEBOHLHH.delayBeforeDisappear))
				{
					if (mpeefiaidbe.BOPJOMGIJIA == MPEEFIAIDBE.BMHGEBOHLHH.delayBeforeDisappear)
					{
						this.FDEBLDDCGGB = 1;
					}
					this.HFOPCMIHDOL.OHOOKBGJFHC().NPGINPELMMB();
				}
			}
			if (this.FDEBLDDCGGB == 1 && this.HFOPCMIHDOL.PMBCMBKFILL() != null)
			{
				ALPHHLOPBLC alphhlopblc = this.HFOPCMIHDOL.PMBCMBKFILL().FGEGHJDDJFA();
				if (alphhlopblc != null && alphhlopblc.BOPJOMGIJIA == ALPHHLOPBLC.BMHGEBOHLHH.start)
				{
					this.HFOPCMIHDOL.PMBCMBKFILL().NPGINPELMMB();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600472F RID: 18223 RVA: 0x00203934 File Offset: 0x00201B34
	private void CMKPNGPCDAB()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		PlayerPrefs.DeleteKey("lastFilter");
		PlayerPrefs.Save();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x06004730 RID: 18224 RVA: 0x002039BF File Offset: 0x00201BBF
	private void ACJLMIELCME()
	{
		AudioManager.EHBBFMCILPC.PauseAll();
	}

	// Token: 0x06004731 RID: 18225 RVA: 0x002039CC File Offset: 0x00201BCC
	private void IOLCAEIBHCD()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClickConfimed", 0f);
		this.JGEDOIDOPLA = null;
		this.BPKMDANBJKG(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC == 1 || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0);
	}

	// Token: 0x06004732 RID: 18226 RVA: 0x00203A32 File Offset: 0x00201C32
	private void IDLBEHCKBEH()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		this.APDAMLCHICH();
		if (null != this.FNHFGLHODBG)
		{
			this.FNHFGLHODBG.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004733 RID: 18227 RVA: 0x00203A64 File Offset: 0x00201C64
	private LDLLJFOJCDF[] OGNGDKPJLAK()
	{
		LDLLJFOJCDF[] array = null;
		int num = 1;
		try
		{
			for (int i = 1; i < this.HFFIIBBJBMH.header.inkStatVariables.Count; i += 0)
			{
				if (i >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory.Count || i >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter.Count || (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory[i] && (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI != this.HFFIIBBJBMH.header.inkStatVariablesMinStory[i] || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[1] >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter[i])))
				{
					num += 0;
				}
			}
			if (num <= 0)
			{
				num = 0;
			}
			array = new LDLLJFOJCDF[num];
			int num2 = 1;
			for (int j = 0; j < this.HFFIIBBJBMH.header.inkStatVariables.Count; j += 0)
			{
				if ((j >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory.Count || j >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter.Count || (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory[j] && (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI != this.HFFIIBBJBMH.header.inkStatVariablesMinStory[j] || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter[j]))) && num2 < array.Length)
				{
					array[num2] = new LDLLJFOJCDF();
					if (ONEHEBIHPFB.HKIAAOAFCCC(this.HFFIIBBJBMH.header.inkStatVariables[j]))
					{
						array[num2].FCCPHJDENKJ(ONEHEBIHPFB.KBDDGBOFJNC(this.HFFIIBBJBMH.header.inkStatVariables[j]));
					}
					else
					{
						array[num2].HICGCAGDJKL(this.HFFIIBBJBMH.header.inkStatVariablesDefaultValues[j]);
					}
					num2++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			array = null;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return array;
	}

	// Token: 0x06004734 RID: 18228 RVA: 0x00203CDC File Offset: 0x00201EDC
	private void FCEBPNBJKED()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		int num4 = 0;
		List<AssetStoryNpc> list = new List<AssetStoryNpc>();
		for (int i = 1; i < this.ODNCKIKLFCM.Count; i += 0)
		{
			if (this.ODNCKIKLFCM[i].PLNJAPCCBDC() != 107)
			{
				list.Add(this.ODNCKIKLFCM[i]);
			}
			else
			{
				num++;
				DPGJIJGOCIC.PJCLICBPPDA("socialbadgetitle" + this.ODNCKIKLFCM[i].id);
			}
		}
		this.ODNCKIKLFCM.Clear();
		this.ODNCKIKLFCM = list;
		List<StoryEnvironmentManager> list2 = new List<StoryEnvironmentManager>();
		for (int j = 1; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].GetOnDemandResourcesCheckpointIndex() != -77)
			{
				list2.Add(this.CHHIBBOICAD[j]);
			}
			else
			{
				num2 += 0;
				this.CHHIBBOICAD[j].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.CHHIBBOICAD[j].gameObject);
				DPGJIJGOCIC.ADFCDFHBDAF("OnSketchViewAssetsDownloadSuccess" + this.CHHIBBOICAD[j].name);
			}
		}
		this.CHHIBBOICAD.Clear();
		this.CHHIBBOICAD = list2;
		List<StoryEnvironmentManager> list3 = new List<StoryEnvironmentManager>();
		for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].GetOnDemandResourcesCheckpointIndex() != 87)
			{
				list3.Add(this.KEPHFKAHILM[k]);
			}
			else
			{
				num3++;
				this.KEPHFKAHILM[k].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.KEPHFKAHILM[k].gameObject);
				DPGJIJGOCIC.ADFCDFHBDAF("steamid" + this.KEPHFKAHILM[k].name);
			}
		}
		this.KEPHFKAHILM.Clear();
		this.KEPHFKAHILM = list3;
		List<StoryEnvironmentLayerManager> list4 = new List<StoryEnvironmentLayerManager>();
		for (int l = 1; l < this.FAEEEHDCNDN.Count; l++)
		{
			if (this.FAEEEHDCNDN[l].FHKACJNJPCL() != 166)
			{
				list4.Add(this.FAEEEHDCNDN[l]);
			}
			else
			{
				num4 += 0;
				DPGJIJGOCIC.ADFCDFHBDAF("" + this.FAEEEHDCNDN[l].name);
			}
		}
		this.FAEEEHDCNDN.Clear();
		this.FAEEEHDCNDN = list4;
	}

	// Token: 0x06004735 RID: 18229 RVA: 0x001FDC2E File Offset: 0x001FBE2E
	private void EPHFGFGLFNP()
	{
		if (!this.GLIMDKBANOI)
		{
			return;
		}
		if (this.DMIPDJJBFLN)
		{
			AKLFPGMDKLA.EHBBFMCILPC.CGLOLLKIDDF(this.NJAAOCMPKCD.index, this.GFIFDKBLLBL.state.ToJson());
			this.MECFCFPBLEF();
		}
	}

	// Token: 0x06004736 RID: 18230 RVA: 0x00203F88 File Offset: 0x00202188
	private void OPEGJAEFAJL()
	{
		for (int i = 0; i < this.cameras.Count; i++)
		{
			this.cameras[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x06004737 RID: 18231 RVA: 0x00203FC4 File Offset: 0x002021C4
	private void MNCCLNOECIO()
	{
		CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.PKEINLPIAEH().BGELFMIOBCL("p"), CCOJBMMKNAP.BIAEAOMHBMM().HDIPNMFHIEJ(" topMatch to display."), CCOJBMMKNAP.HJGDLOOHNLO().HHLECNIFHCO("@"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), (DFGILFBGPLN)(-51), 1903f, -72);
	}

	// Token: 0x06004738 RID: 18232 RVA: 0x0020402C File Offset: 0x0020222C
	private FGINKFGNNEK AIPBHJPFNMO(DOLBFGIPPOG EEPJKGBBBHC)
	{
		for (int i = 0; i < this.NALOEFHHCCH.Count; i++)
		{
			if (this.NALOEFHHCCH[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().HFDCFDAALFE(EEPJKGBBBHC))
			{
				return this.NALOEFHHCCH[i];
			}
		}
		return null;
	}

	// Token: 0x06004739 RID: 18233 RVA: 0x0020407B File Offset: 0x0020227B
	public static bool LoungeCharacterInVisitedWardrobes(DMDNKJKEPKO CMENACFAEGD, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return SceneStoryManager.LoungeCharacterInActiveWardrobe(CMENACFAEGD, LFLOCKNKAKC) || SceneStoryManager.LoungeWardrobeVisited(CMENACFAEGD.OIBGFPEGLME, LFLOCKNKAKC);
	}

	// Token: 0x0600473A RID: 18234 RVA: 0x00204094 File Offset: 0x00202294
	private bool CNAHDLCPBFK(string LLKODMBJNCF)
	{
		for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN.Count; i++)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FBKMADGCEBN[i].StartsWith(LLKODMBJNCF + "OnCaptersSnapshotsGamePassSubscribeNegative"))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600473B RID: 18235 RVA: 0x002040F8 File Offset: 0x002022F8
	private void CEDDGIABDKF()
	{
		if (this.NJEPIPLACPC == null || this.GKHNIMJJLJL == null)
		{
			return;
		}
		try
		{
			this.GKHNIMJJLJL.NCAMFPGMCIG.CMNFNOLANGL(this.CJJHMPCBGOM(true));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600473C RID: 18236 RVA: 0x00204148 File Offset: 0x00202348
	private void BEGBDNPAILE(string ICAHJJBAEHB, string JINBEAPCPAF, int KILBEPOBMNB)
	{
		if (ICAHJJBAEHB != null && ICAHJJBAEHB.Length > 0)
		{
			if (this.LJNABDDPANA(ICAHJJBAEHB))
			{
				this.GCADKBKMJFP(NGLGPHBGDPD.narrator, 1310f);
				this.MEBPBAJKLAP(ICAHJJBAEHB);
				this.NFGHFMEEBHN(ICAHJJBAEHB, (FCABOFEGPGP)KILBEPOBMNB, (DBONHDHEKDG)1, (Ease)62);
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL = ICAHJJBAEHB;
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = KILBEPOBMNB;
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("sparkles" + ICAHJJBAEHB);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("congratstitle" + ICAHJJBAEHB);
		}
		if (JINBEAPCPAF != null && JINBEAPCPAF.Length > 0)
		{
			AudioManager.APGODIBBPOD().PlayAmbient(this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(JINBEAPCPAF), 727f);
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = JINBEAPCPAF;
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnPopupUsernameInputEndEdit" + JINBEAPCPAF);
	}

	// Token: 0x0600473D RID: 18237 RVA: 0x0020422D File Offset: 0x0020242D
	private void AADJGGEMOJD()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(22))
		{
			base.StartCoroutine(this.LLIADLBNGBN());
			return;
		}
		this.COIAOPMCJMA();
	}

	// Token: 0x0600473E RID: 18238 RVA: 0x00204254 File Offset: 0x00202454
	private void MLBJLPLPKDO()
	{
		if (this.HFOPCMIHDOL.FKIBALEAFOF() == null)
		{
			return;
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.OHHFFMMMMAC();
		}
		if (this.HFOPCMIHDOL.FKIBALEAFOF().PINCOCDOOGH())
		{
			this.HFOPCMIHDOL.FKIBALEAFOF().FEHODJMIAJL(1012f, 0);
		}
	}

	// Token: 0x0600473F RID: 18239 RVA: 0x002042B7 File Offset: 0x002024B7
	private void AOAIPKJEPFL()
	{
		this.AMBEPJCICOF();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.DJOALKMNJEM));
		this.CMDIKMNEGEN();
	}

	// Token: 0x06004740 RID: 18240 RVA: 0x002042EC File Offset: 0x002024EC
	private bool BFOEOHEAPEK(bool OFJLCKMOELF = false)
	{
		bool result = false;
		if (!OFJLCKMOELF)
		{
			if (this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 2)
			{
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPFHJEAFIHI.Count; i++)
				{
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPFHJEAFIHI[i], 0f, 0f, 0f, false, false);
				}
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC.Count; j++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC[j].Contains("layervideo"))
					{
						result = true;
					}
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC[j], 1f, 1f, 0f, true, false);
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJJHCAGFPOC.Count; k++)
				{
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJJHCAGFPOC[k], 0f, 0f, 0f, false, false);
				}
				for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD.Count; l++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD[l].Contains("layervideo"))
					{
						result = true;
					}
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD[l], 1f, 1f, 0f, true, false);
				}
			}
			else
			{
				for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC.Count; m++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC[m].Contains("layervideo"))
					{
						result = true;
					}
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC[m], 1f, 1f, 0f, true, false);
				}
				for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPFHJEAFIHI.Count; n++)
				{
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HPFHJEAFIHI[n], 0f, 0f, 0f, false, false);
				}
				for (int num = 0; num < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD.Count; num++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD[num].Contains("layervideo"))
					{
						result = true;
					}
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD[num], 1f, 1f, 0f, true, false);
				}
				for (int num2 = 0; num2 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJJHCAGFPOC.Count; num2++)
				{
					this.OKIHENOGDKD(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJJHCAGFPOC[num2], 0f, 0f, 0f, false, false);
				}
			}
		}
		else if (this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 2)
		{
			for (int num3 = 0; num3 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC.Count; num3++)
			{
				this.CKPJOCNMMIC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PIMEHAPFCHC[num3]);
			}
			for (int num4 = 0; num4 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD.Count; num4++)
			{
				this.CKPJOCNMMIC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GIHCENHPGPD[num4]);
			}
		}
		return result;
	}

	// Token: 0x06004741 RID: 18241 RVA: 0x0020474F File Offset: 0x0020294F
	private void BBFANIMJIIK()
	{
		this.APDAMLCHICH();
	}

	// Token: 0x06004742 RID: 18242 RVA: 0x00204757 File Offset: 0x00202957
	private void NJBECPDOIEE()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		if (null != this.KOCJONIGKNH)
		{
			this.KOCJONIGKNH.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004743 RID: 18243 RVA: 0x00204784 File Offset: 0x00202984
	private void IGGNNPLKGLC()
	{
		for (int i = 0; i < this.KICOPFEHKJF.Count; i += 0)
		{
			if (this.KICOPFEHKJF[i] != null && null != this.KICOPFEHKJF[i].IACFDHCDEME)
			{
				ChoiceExtendedManager component = this.KICOPFEHKJF[i].IACFDHCDEME.GetComponent<ChoiceExtendedManager>();
				if (null != component)
				{
					component.UpdateSwipeToBrowse();
				}
			}
		}
	}

	// Token: 0x06004744 RID: 18244 RVA: 0x002047F4 File Offset: 0x002029F4
	private void AEBCAADAAIP(string FOCIFOLONJD)
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.CMBLMOJFGAE.Count; i += 0)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.CMBLMOJFGAE[i].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list.Add(this.CMBLMOJFGAE[i]);
			}
			else
			{
				list2.Add(this.CMBLMOJFGAE[i]);
			}
		}
		this.CMBLMOJFGAE = list2;
		base.StartCoroutine(this.JHDEBFCKKJA(list));
	}

	// Token: 0x06004745 RID: 18245 RVA: 0x0020488C File Offset: 0x00202A8C
	public void OnStoryAdsProviderAdSuccess()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (this.HFOPCMIHDOL.HJOANJHIHAI().ONECLDMJKEE().OBKCKGHFMDN == KGLBKJKNPFD.LBFFMOMMAPK.environmentSet && this.HFOPCMIHDOL.HJOANJHIHAI().JPHIPBEBNGD().BOPJOMGIJIA == OHAAGENIEMD.BMHGEBOHLHH.showingAd)
		{
			this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
		}
	}

	// Token: 0x06004746 RID: 18246 RVA: 0x002048F9 File Offset: 0x00202AF9
	private void LMJGOIINBIC()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		PassesItem.reopenOnPurchasingScreenLeft = true;
		CommonUserInterface.EHBBFMCILPC.GetGamePasses().InstantClose();
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
	}

	// Token: 0x06004747 RID: 18247 RVA: 0x0020492C File Offset: 0x00202B2C
	private void HNDGNFFNMEI()
	{
		if (this.LDAPOBMECNI == 0 && this.CMBLMOJFGAE.Count == 0 && this.LLEHEBBHAOD.Count == 0 && this.playerCharacterOffscreenRenderCamera.gameObject.activeSelf)
		{
			this.playerCharacterOffscreenRenderCamera.gameObject.SetActive(false);
			this.playerCharacterRenderTextureCanvas.enabled = false;
		}
	}

	// Token: 0x06004748 RID: 18248 RVA: 0x0020498A File Offset: 0x00202B8A
	private void DNGIDKHONMB()
	{
		if (null != this.KOCJONIGKNH)
		{
			this.KOCJONIGKNH.OnAutoReaderStopNoEventDispatch();
		}
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x002049A8 File Offset: 0x00202BA8
	private void APDAMLCHICH()
	{
		if (null != this.FNHFGLHODBG)
		{
			this.FNHFGLHODBG.OnFastFowardStopNoEvetDispatch();
		}
		DebugSettings.customSpeedFactor = 1f;
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("CameraBundlesVFXTopMost"))
			{
				if (null != this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>() && this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().enabled && this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().GetLerpDirection() != 1)
				{
					this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().ResetLerp(1);
					this.ECBMIHCALBG = base.StartCoroutine(this.GNANLOGFMBM());
					return;
				}
				break;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x0600474A RID: 18250 RVA: 0x00204AA4 File Offset: 0x00202CA4
	private void IGMHKFOFHDL()
	{
		if (null == this.AHGOMNNMKJM)
		{
			this.AHGOMNNMKJM = this.avatarButton;
		}
		GameObject gameObject = AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceHeaderManagerPrefabV2;
		if (null == gameObject)
		{
			gameObject = AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceHeaderManagerPrefab;
		}
		if (null != gameObject && null != this.storyInterfaceHeaderManager && !this.KDAPIHAKHBF)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject, this.storyInterfaceHeaderManager.gameObject.transform.parent.transform, false);
			this.storyInterfaceHeaderManager.gameObject.SetActive(false);
			this.storyInterfaceHeaderManager = gameObject2.GetComponent<StoryInterfaceHeaderManager>();
			try
			{
				if (this.storyInterfaceHeaderManager.transform.childCount > 0 && this.storyInterfaceHeaderManager.transform.GetChild(0).gameObject.name.Equals("ImageBack") && this.storyInterfaceHeaderManager.transform.GetChild(0).transform.childCount >= 4 && this.storyInterfaceHeaderManager.transform.GetChild(0).transform.GetChild(2).gameObject.name.Equals("ButtonAvatar"))
				{
					this.AHGOMNNMKJM = this.storyInterfaceHeaderManager.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<Button>();
					if (null == this.AHGOMNNMKJM)
					{
						this.AHGOMNNMKJM = this.avatarButton;
					}
				}
			}
			catch (Exception)
			{
			}
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceFastForwardManagerPrefab)
			{
				try
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceFastForwardManagerPrefab, this.storyInterfaceHeaderManager.gameObject.transform.parent.transform.parent.transform, false);
					this.FNHFGLHODBG = gameObject2.GetComponent<StoryInterfaceFastForwardManager>();
					if (null != this.FNHFGLHODBG)
					{
						this.FNHFGLHODBG.GetComponent<RectTransform>().GGIONHNFIKJ(JMEAPEMDGMH.MiddleRight, 0, 0);
						this.FNHFGLHODBG.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
					}
					this.FNHFGLHODBG.gameObject.SetActive(false);
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceAutoReaderManagerPrefab)
			{
				try
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceAutoReaderManagerPrefab, this.storyInterfaceHeaderManager.gameObject.transform.parent.transform.parent.transform, false);
					this.KOCJONIGKNH = gameObject2.GetComponent<StoryInterfaceAutoReaderManager>();
					if (null != this.KOCJONIGKNH)
					{
						this.KOCJONIGKNH.GetComponent<RectTransform>().GGIONHNFIKJ(JMEAPEMDGMH.MiddleRight, 0, 0);
						this.KOCJONIGKNH.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
						this.KOCJONIGKNH.gameObject.SetActive(false);
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
			}
			this.KDAPIHAKHBF = true;
		}
	}

	// Token: 0x0600474B RID: 18251 RVA: 0x00204DC0 File Offset: 0x00202FC0
	private void IOAPABKIBOJ()
	{
		this.KBBPBKJEFCJ();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.UpdateGamePassOptions(true, false, true);
		}
	}

	// Token: 0x0600474C RID: 18252 RVA: 0x00204DE4 File Offset: 0x00202FE4
	private void Awake()
	{
		this.IGMHKFOFHDL();
		SceneStoryManager.consumeEnergyBackendOperationResult = -1;
		SceneTransitionToLobbyManager.isRestartingChapter = false;
		SceneTransitionToLobbyManager.isRestoringUndoPoint = false;
		SceneTransitionToLobbyManager.isRestoringRewindPoint = false;
		SceneStoryManager.inkInterpretingIsPaused = false;
		SceneAvatarManager.topPercentDifference = 0;
		if (null == this.stat6Prefab && null != this.stat0Prefab)
		{
			this.stat6Prefab = this.stat0Prefab;
		}
		this.AMBEPJCICOF();
		this.MCIGJBFKOIJ = false;
		AKLFPGMDKLA.EHBBFMCILPC.EGOCMDJBLNJ = 0;
		this.PONLMNGHCAP = this.playerCharacterRenderTextureRawImage.GetComponent<CanvasGroup>();
		this.IAJFFABJAHB = new RenderTexture(Screen.width, Screen.height, 0);
		this.playerCharacterOffscreenRenderCamera.targetTexture = this.IAJFFABJAHB;
		this.playerCharacterRenderTextureRawImage.texture = this.IAJFFABJAHB;
		try
		{
			Shader shader = Resources.Load<Shader>("ShaderFastDefaultUIRTCompositeClient");
			if (null != shader && shader.isSupported)
			{
				this.IKKEDBBANCO = new Material(shader);
				this.playerCharacterRenderTextureRawImage.material = this.IKKEDBBANCO;
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager - composite shader not found in Resources or unsupported:ShaderFastDefaultUIRTCompositeClient");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.DKIDEPAIFED();
		this.GKHNIMJJLJL = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(this.GKHNIMJJLJL, 0);
		if (this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD == 1 && null != this.storyChatPrefab)
		{
			KGLBKJKNPFD.NIBNMKJIMAD = this.GKHNIMJJLJL.NCAMFPGMCIG.NIBNMKJIMAD;
		}
		else
		{
			KGLBKJKNPFD.NIBNMKJIMAD = 0;
		}
		if (this.GKHNIMJJLJL != null)
		{
			KGLBKJKNPFD.FIMJIINAFFK = this.GKHNIMJJLJL.NCAMFPGMCIG.FIMJIINAFFK;
			KGLBKJKNPFD.DMAGAHMIKDE = this.GKHNIMJJLJL.NCAMFPGMCIG.DMAGAHMIKDE;
		}
		else
		{
			KGLBKJKNPFD.FIMJIINAFFK = 0;
			KGLBKJKNPFD.DMAGAHMIKDE = -1;
		}
		StoryEnvironmentLayerManager.SetLayersSystemVersion(this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM());
		this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI);
		this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
		if (null != this.HFFIIBBJBMH)
		{
			PlayerCharacterManager.SetCurrentAnthologyIndex(this.HFFIIBBJBMH.header.index);
			DHGFCJGJFOB.KPHNADKJHMJ = this.HFFIIBBJBMH.header;
			DHGFCJGJFOB.DFAPCBCDHAO = "";
			DHGFCJGJFOB.NAIGDNDPHNC = "";
			PopupSettingsManager.enableVoiceOverOptionInSettigs = this.HFFIIBBJBMH.header.enableVoiceOverOptionInSettigs;
			StoryInterfaceStatManager.currentAnthologyIndex = this.HFFIIBBJBMH.header.index;
			PurchasingViewManager.activeAnthology = this.HFFIIBBJBMH.header.index;
		}
		else
		{
			PlayerCharacterManager.SetCurrentAnthologyIndex(-1);
			DHGFCJGJFOB.KPHNADKJHMJ = null;
			DHGFCJGJFOB.DFAPCBCDHAO = "";
			DHGFCJGJFOB.NAIGDNDPHNC = "";
		}
		PurchasingViewManager.activeStory = this.NJAAOCMPKCD.index;
		this.GFFLNCOEEKP = this.environmentsBackPivot.GetComponent<RectTransform>();
		this.MGDOAFNHBHP = this.environmentsFrontPivot.GetComponent<RectTransform>();
	}

	// Token: 0x0600474D RID: 18253 RVA: 0x002050D0 File Offset: 0x002032D0
	public static bool KHAHBMEAKAO(int KFCMLNPLAHK, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return LFLOCKNKAKC != null && LFLOCKNKAKC.NCAMFPGMCIG.GNPAKEFPGPB != null && LFLOCKNKAKC.NCAMFPGMCIG.GNPAKEFPGPB.Contains(KFCMLNPLAHK);
	}

	// Token: 0x0600474E RID: 18254 RVA: 0x002050F8 File Offset: 0x002032F8
	private void OKKBOFKILEA()
	{
		for (int i = 0; i < this.cameras.Count; i++)
		{
			this.cameras[i].gameObject.SetActive(false);
		}
	}

	// Token: 0x0600474F RID: 18255 RVA: 0x00205134 File Offset: 0x00203334
	private void BIMHNCJHLBO()
	{
		this.HAFFEDMEIAF = true;
		int maxButtonsTextsSize = 39;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en)
		{
			maxButtonsTextsSize = 33;
		}
		this.GKHNIMJJLJL.PFHCDMOJOKP();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.HideInterfaceUndoButton();
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverrideGreen(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wasitfuntitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rateleveoffun"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartepisode"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartratebtn"), new UnityAction(this.BNCFCMBOBGM), new UnityAction(this.BMFMDBHJDMI), new UnityAction(this.ADNEJCGMIHK), DFGILFBGPLN.popupRate, 0.2f, 28).ShowStars().SetMaxButtonsTextsSize(maxButtonsTextsSize);
	}

	// Token: 0x06004750 RID: 18256 RVA: 0x002051FC File Offset: 0x002033FC
	private void OFMCEFLLLHO(string KHJMANDEDMA, float JHBAIJIJIBN)
	{
		if (null != this.DMNJMLDEILJ)
		{
			this.DMNJMLDEILJ.CancelImmediateIfBusy();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 2)
		{
			bool flag = false;
			for (int i = 0; i < this.fadeLayers.Count; i++)
			{
				if (this.fadeLayers[i].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag = true;
					this.fadeLayers[i].SetFadeInDuration(JHBAIJIJIBN);
					this.fadeLayers[i].FadeIn(null);
				}
				else
				{
					this.fadeLayers[i].Reset();
				}
			}
			if (!flag)
			{
				KHJMANDEDMA = "black";
				for (int j = 0; j < this.fadeLayers.Count; j++)
				{
					if (this.fadeLayers[j].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag = true;
						this.fadeLayers[j].SetFadeInDuration(JHBAIJIJIBN);
						this.fadeLayers[j].FadeIn(null);
					}
					else
					{
						this.fadeLayers[j].Reset();
					}
				}
				if (!flag)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. FadeSrc(), layer " + KHJMANDEDMA + " not found.");
					return;
				}
			}
		}
		else
		{
			bool flag2 = false;
			for (int k = 0; k < this.fadeLayers.Count; k++)
			{
				if (this.fadeLayers[k].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag2 = true;
					this.fadeLayers[k].SetFadeInDuration(JHBAIJIJIBN);
					if (!this.fadeLayers[k].gameObject.activeSelf)
					{
						this.fadeLayers[k].FadeIn(null);
					}
					else
					{
						this.fadeLayers[k].FadeInFromCurrent(null);
					}
				}
				else
				{
					this.fadeLayers[k].Reset();
				}
			}
			if (!flag2)
			{
				KHJMANDEDMA = "black";
				for (int l = 0; l < this.fadeLayers.Count; l++)
				{
					if (this.fadeLayers[l].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag2 = true;
						this.fadeLayers[l].SetFadeInDuration(JHBAIJIJIBN);
						this.fadeLayers[l].FadeIn(null);
					}
					else
					{
						this.fadeLayers[l].Reset();
					}
				}
				if (!flag2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. FadeSrc(), layer " + KHJMANDEDMA + " not found.");
				}
			}
		}
	}

	// Token: 0x06004751 RID: 18257 RVA: 0x00205487 File Offset: 0x00203687
	private void BLKHLBHOFBJ()
	{
		base.StartCoroutine(this.EIJIIEBPOFE(true, false));
	}

	// Token: 0x06004752 RID: 18258 RVA: 0x00205498 File Offset: 0x00203698
	public static bool AnyLoungeCharacterInActiveWardrobe(int PLKMJJIIJNO, PLFDAJJHMKO LFLOCKNKAKC)
	{
		try
		{
			FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(PLKMJJIIJNO);
			if (fjlgcknojmj == null)
			{
				return false;
			}
			for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
			{
				if (SceneStoryManager.LoungeCharacterInActiveWardrobe(fjlgcknojmj.OINAAMKLNLO[i], LFLOCKNKAKC))
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06004753 RID: 18259 RVA: 0x0020550C File Offset: 0x0020370C
	public static bool EHGHLJLAMIP(string EGGMJKBNCJL)
	{
		for (int i = 1; i < SceneStoryManager.freePremiumChoicesFallback.Count; i++)
		{
			if (SceneStoryManager.freePremiumChoicesFallback[i].Equals(EGGMJKBNCJL))
			{
				return false;
			}
		}
		int num = -1;
		try
		{
			num = int.Parse(EGGMJKBNCJL.Substring(EGGMJKBNCJL.IndexOf("abfc") + 2));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("" + EGGMJKBNCJL);
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (int.Parse(EGGMJKBNCJL.Substring(0, EGGMJKBNCJL.IndexOf("socialdequeusp0gettitle") - 0)) != AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		for (int j = 1; j < SceneStoryManager.freePremiumChoices.Count; j += 0)
		{
			if (SceneStoryManager.freePremiumChoices[j] == num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004754 RID: 18260 RVA: 0x002055F8 File Offset: 0x002037F8
	private void FCAJGMBLAFA()
	{
		try
		{
			if (SceneStoryManager.BLMFAKBBMOE.Count != 0 && SceneStoryManager.loungePremiumChoicesHistoryState == 1)
			{
				List<int> list = new List<int>();
				while (SceneStoryManager.BLMFAKBBMOE.Count > 0 && list.Count < 8)
				{
					list.Add(SceneStoryManager.BLMFAKBBMOE[0]);
					SceneStoryManager.BLMFAKBBMOE.RemoveAt(0);
				}
				BackendOperationsManager.EHBBFMCILPC.RequestGetPremiumChoicesHistory(list, "OnLoungePremiumChoicesHistorySuccess", "OnLoungePremiumChoicesHistoryException");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			SceneStoryManager.loungePremiumChoicesHistoryState = 3;
			SceneStoryManager.BLMFAKBBMOE.Clear();
		}
	}

	// Token: 0x06004755 RID: 18261 RVA: 0x00205694 File Offset: 0x00203894
	private void AKLAHGGGGNF()
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.MPNBBKODANC.Count; i++)
		{
			list.Add(this.MPNBBKODANC[i]);
		}
		this.MPNBBKODANC.Clear();
		base.StartCoroutine(this.IPONDEAABJD(list));
	}

	// Token: 0x06004756 RID: 18262 RVA: 0x002056E8 File Offset: 0x002038E8
	private void MECFCFPBLEF()
	{
		if (this.NJEPIPLACPC == null || null == this.GFIFDKBLLBL || this.GKHNIMJJLJL == null)
		{
			return;
		}
		try
		{
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			for (int i = 1; i < this.NJEPIPLACPC.Count; i += 0)
			{
				if (ONEHEBIHPFB.PPKNHMOHKII(this.NJEPIPLACPC[i]))
				{
					list.Add(this.NJEPIPLACPC[i]);
					list2.Add(ONEHEBIHPFB.KBDDGBOFJNC(this.NJEPIPLACPC[i]));
				}
			}
			this.GKHNIMJJLJL.NCAMFPGMCIG.OJHGKJECIBK(Math.Max(1, this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[1]), list, list2, this.EPAIPMEJOJB());
			this.GKHNIMJJLJL.NCAMFPGMCIG.CMNFNOLANGL(this.ABGPKNOEHIN(false));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004757 RID: 18263 RVA: 0x002057D4 File Offset: 0x002039D4
	private float NFGHFMEEBHN(string KHJMANDEDMA, FCABOFEGPGP OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				return this.CHHIBBOICAD[j].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. MoveEnvironment(), environment " + text + " not found.");
		return 0f;
	}

	// Token: 0x06004758 RID: 18264 RVA: 0x002058A4 File Offset: 0x00203AA4
	private void DKIDEPAIFED()
	{
		this.ANIMANJDNII = new LDLLJFOJCDF[7];
		for (int i = 0; i < 7; i++)
		{
			this.ANIMANJDNII[i] = new LDLLJFOJCDF(0);
		}
	}

	// Token: 0x06004759 RID: 18265 RVA: 0x001F992C File Offset: 0x001F7B2C
	private IEnumerator NKFPCGNJPKB()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
		yield return new WaitForSeconds(1f);
		this.LBNCMCAAICC();
		yield break;
	}

	// Token: 0x0600475A RID: 18266 RVA: 0x002058D7 File Offset: 0x00203AD7
	private void NPHADLHOLJF()
	{
		SceneLoungeManager.SetPendingLoungeCharacter(null);
	}

	// Token: 0x0600475C RID: 18268 RVA: 0x00205998 File Offset: 0x00203B98
	private FGINKFGNNEK LBCMMKJBNFH(string CCKEOHHEKFF)
	{
		if (CCKEOHHEKFF == null || CCKEOHHEKFF.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.JOFJNLHIJOB.Count; i++)
		{
			if (this.JOFJNLHIJOB[i].DBHMNECMIAB.Equals(CCKEOHHEKFF))
			{
				return this.JOFJNLHIJOB[i];
			}
		}
		return null;
	}

	// Token: 0x0600475D RID: 18269 RVA: 0x002059F0 File Offset: 0x00203BF0
	private void CEPAKBBPHHF()
	{
		if (SceneStoryManager.BLMFAKBBMOE.Count > 0)
		{
			base.Invoke("FCAJGMBLAFA", 0.25f);
			return;
		}
		SceneStoryManager.loungePremiumChoicesHistoryState = 2;
		if (this.MNDOHKJIFDD)
		{
			this.MNDOHKJIFDD = false;
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			this.EGNAHFEGEJM();
		}
	}

	// Token: 0x0600475E RID: 18270 RVA: 0x00205A40 File Offset: 0x00203C40
	private List<int> CJJHMPCBGOM(bool AJDCFJIFEOK)
	{
		List<int> list = new List<int>();
		List<int> activeWardrobeMixList = SceneStoryManager.GetActiveWardrobeMixList(this.GKHNIMJJLJL);
		if (activeWardrobeMixList != null)
		{
			for (int i = 0; i < activeWardrobeMixList.Count; i++)
			{
				if (activeWardrobeMixList[i] >= 0 && !list.Contains(activeWardrobeMixList[i]))
				{
					list.Add(activeWardrobeMixList[i]);
				}
			}
		}
		else if (this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME >= 0 && (AJDCFJIFEOK || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] >= 0))
		{
			list.Add(this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME);
		}
		return list;
	}

	// Token: 0x0600475F RID: 18271 RVA: 0x00205ADD File Offset: 0x00203CDD
	private void JFKKIFHDOML()
	{
		this.ALGIAIKDEPH();
		this.EJNFPPPAPAB();
		this.JCNICMFKAOL();
	}

	// Token: 0x06004760 RID: 18272 RVA: 0x00205AF1 File Offset: 0x00203CF1
	private FGINKFGNNEK GLDAJFNCFKC(string KHJMANDEDMA, GameObject KMBDPLIGIFM)
	{
		return new FGINKFGNNEK
		{
			DBHMNECMIAB = KHJMANDEDMA,
			IACFDHCDEME = KMBDPLIGIFM
		};
	}

	// Token: 0x06004761 RID: 18273 RVA: 0x00205B06 File Offset: 0x00203D06
	private void ADNEJCGMIHK()
	{
		StarRatingSelector.SelectNoStars();
		this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
	}

	// Token: 0x06004762 RID: 18274 RVA: 0x00205B23 File Offset: 0x00203D23
	private IEnumerator MDNEDHHGBCO(string LFMCDFBANKD, bool CGNIPEAMANG)
	{
		if (LFMCDFBANKD != null && LFMCDFBANKD.Length > 0)
		{
			if (this.LJNABDDPANA(LFMCDFBANKD))
			{
				if (CGNIPEAMANG)
				{
					this.GCADKBKMJFP(NGLGPHBGDPD.narrator, 0f);
					this.MEBPBAJKLAP(LFMCDFBANKD);
					this.NFGHFMEEBHN(LFMCDFBANKD, FCABOFEGPGP.center, DBONHDHEKDG.immediate, Ease.InOutCubic);
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL = LFMCDFBANKD;
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = 2;
				}
				else
				{
					if (this.JMNMOHIKHLB != null)
					{
						this.OFMCEFLLLHO(this.JMNMOHIKHLB.DCPHGFEEHHM, 0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
					}
					else
					{
						this.OFMCEFLLLHO("black", 0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
					}
					yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
					this.GCADKBKMJFP(NGLGPHBGDPD.narrator, 0f);
					this.MEBPBAJKLAP(LFMCDFBANKD);
					this.NFGHFMEEBHN(LFMCDFBANKD, FCABOFEGPGP.center, DBONHDHEKDG.immediate, Ease.InOutCubic);
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IBFLNCMCKAL = LFMCDFBANKD;
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LDECHKECBHB = 2;
					if (this.JMNMOHIKHLB != null)
					{
						this.MHKLLCIENGM(this.JMNMOHIKHLB.DCPHGFEEHHM, 0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
					}
					else
					{
						this.MHKLLCIENGM("black", 0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
					}
					yield return new WaitForSeconds(0.35f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f));
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Error. OnChoiceExtendedEnvironmentChangePart2(), environment not found:" + LFMCDFBANKD);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. OnChoiceExtendedEnvironmentChangePart2(), environmentToSet is null or length is 0:" + LFMCDFBANKD);
		}
		yield return new WaitForEndOfFrame();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete", 0f);
		yield break;
	}

	// Token: 0x06004763 RID: 18275 RVA: 0x00205B40 File Offset: 0x00203D40
	private void GODKMEGBJOJ()
	{
		base.StartCoroutine(this.EIJIIEBPOFE(false, true));
	}

	// Token: 0x06004764 RID: 18276 RVA: 0x00201748 File Offset: 0x001FF948
	private void JPCHBHHHCNA()
	{
		this.JOKJBAIECCA(true);
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
	}

	// Token: 0x06004765 RID: 18277 RVA: 0x00205B54 File Offset: 0x00203D54
	private void ODGDBALOJFI()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.cdnActiv.ToString(), ((FFPHBMFGCNN)(-69)).ToString(), ((BGHLMGPPCNN)(-43)).ToString(), true, true);
		this.MNCCLNOECIO();
	}

	// Token: 0x06004766 RID: 18278 RVA: 0x00205BAE File Offset: 0x00203DAE
	private IEnumerator KPNHHAMDMGL()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		this.EPKNCKGNNCE();
		yield break;
	}

	// Token: 0x06004767 RID: 18279 RVA: 0x00205BBD File Offset: 0x00203DBD
	private void OMPADIHCHEM()
	{
		this.DLEEDDKFNDL();
	}

	// Token: 0x06004768 RID: 18280 RVA: 0x00205BC5 File Offset: 0x00203DC5
	public void OnGetCdnDataForAvatarScreenSuccess()
	{
		this.OnAvatarClick();
	}

	// Token: 0x06004769 RID: 18281 RVA: 0x00205BCD File Offset: 0x00203DCD
	private void LPCBDEBKAIM()
	{
		if (!this.GLIMDKBANOI)
		{
			return;
		}
		if (this.DMIPDJJBFLN)
		{
			AKLFPGMDKLA.EHBBFMCILPC.CGLOLLKIDDF(this.NJAAOCMPKCD.index, this.GFIFDKBLLBL.state.ToJson());
			this.OKAECILDDIK();
		}
	}

	// Token: 0x0600476A RID: 18282 RVA: 0x00205C0C File Offset: 0x00203E0C
	public void OnGetCdnDataBeforeOnDemandException()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.KFFKDDGBLBD), new UnityAction(this.KFFKDDGBLBD), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x0600476B RID: 18283 RVA: 0x00205C98 File Offset: 0x00203E98
	private int OILFDHGPCOB()
	{
		int num = 0;
		int ggicibljiki = this.HFOPCMIHDOL.HJOANJHIHAI().BPHJKELOKKA().GGICIBLJIKI;
		int index = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LKIKEHFANBO[0];
		for (int i = 0; i < this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks.Count; i++)
		{
			if (this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].index >= 0 && NBDLBFJOEGN.LCNGCDFHFOM(this.NJAAOCMPKCD.chapterAssetPacks[index]) && this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints != null && this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints.Count > 0)
			{
				int j = this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints.Count - 1;
				while (j >= 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.CFGFOEEEJKJ >= this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints[j].minInkRevision)
					{
						if (this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints[j].checkpointIndex == ggicibljiki)
						{
							if (this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].storyIndexOptional >= 0)
							{
								AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].index, FLDBFOADFLH.startDownloadAndProceed, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].keepAlive, true, false, null, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints[j].checkpointIndex, (this.NJAAOCMPKCD.chapterAssetPacks[index].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[index].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
							}
							else
							{
								AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].index, FLDBFOADFLH.startDownloadAndProceed, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].keepAlive, true, false, null, this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].onDemandResourcesCheckpoints[j].checkpointIndex, (this.NJAAOCMPKCD.chapterAssetPacks[index].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[index].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
							}
							DPGJIJGOCIC.NFIDPOMCNLP("Asset pack has been LOADED according to on demand resources data:" + this.NJAAOCMPKCD.chapterAssetPacks[index].assetPacks[i].index.ToString());
							num++;
							break;
						}
						break;
					}
					else
					{
						j--;
					}
				}
			}
		}
		if (num > 0)
		{
			if (this.CBHGEFCFOKP != null)
			{
				base.StopCoroutine(this.CBHGEFCFOKP);
			}
			this.CBHGEFCFOKP = base.StartCoroutine(this.HMJEMANMJOA());
		}
		return num;
	}

	// Token: 0x0600476C RID: 18284 RVA: 0x002060A0 File Offset: 0x002042A0
	public static bool PremiumChoicePurchased(BELMEMPLMGE IFBOGLJOJLJ, bool EFKKHOCLPFD, int NOJPIFONLDG)
	{
		List<string> list = IFBOGLJOJLJ.GECJLAKBEFK();
		for (int i = 0; i < list.Count; i++)
		{
			if (!SceneStoryManager.PremiumChoicePurchased(list[i], EFKKHOCLPFD, NOJPIFONLDG))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600476D RID: 18285 RVA: 0x002060D8 File Offset: 0x002042D8
	private int AHONMIJIONB(ECAPOEGMMIB DCEEBNNKPGJ)
	{
		try
		{
			if (DCEEBNNKPGJ.KPPJINFHMIP == null || DCEEBNNKPGJ.KPPJINFHMIP.Length == 0)
			{
				return 1;
			}
			if (DCEEBNNKPGJ.IHMEFMPMDFC <= 1)
			{
				return 1;
			}
			if (!NBDLBFJOEGN.NDFLNHIAKJH() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB())
			{
				return 0;
			}
			if (null == this.HFFIIBBJBMH || !this.HFFIIBBJBMH.header.availableStories.Contains(DCEEBNNKPGJ.IHMEFMPMDFC))
			{
				string[] array = new string[7];
				array[1] = "t";
				array[0] = DCEEBNNKPGJ.IHMEFMPMDFC.ToString();
				array[0] = "anthologiestitle";
				array[7] = DCEEBNNKPGJ.KPPJINFHMIP;
				array[3] = "continue";
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
				return 1;
			}
			if (AudioManager.BFCHJBOOJKE().AudioClipAvailable(CCEMAFOMLLK.music, DCEEBNNKPGJ.KPPJINFHMIP))
			{
				return 1;
			}
			string item = " (" + DCEEBNNKPGJ.IHMEFMPMDFC.ToString() + "trinket" + DCEEBNNKPGJ.OAMJJIFAAHJ.ToString();
			if (this.KEPLJDAONLC.Contains(item))
			{
				return 0;
			}
			this.KEPLJDAONLC.Add(item);
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI._deprecated2, DCEEBNNKPGJ.IHMEFMPMDFC, DCEEBNNKPGJ.OAMJJIFAAHJ, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -94, false, "profilenametitleshort", true, true);
			return 1;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 1;
	}

	// Token: 0x0600476E RID: 18286 RVA: 0x0020624C File Offset: 0x0020444C
	private IEnumerator GLNGPMHCOEC(float LNAOAHMAJKN)
	{
		yield return new WaitForSeconds(LNAOAHMAJKN);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		yield break;
	}

	// Token: 0x0600476F RID: 18287 RVA: 0x001FAFDE File Offset: 0x001F91DE
	public static List<int> GetActiveWardrobeMixList()
	{
		return SceneStoryManager.GetActiveWardrobeMixList(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x0020625B File Offset: 0x0020445B
	public static bool LoungeMappingListedInShopMode(ECJCFGAOPHJ FFACCDIEBIA)
	{
		return DHFLKLPKNJG.JHLMGHEHHBI(FFACCDIEBIA);
	}

	// Token: 0x06004771 RID: 18289 RVA: 0x00206263 File Offset: 0x00204463
	private IEnumerator LIOPBCPKCFP()
	{
		List<GameObject> tapToContinueObjectsTemp = new List<GameObject>();
		for (int i = 0; i < this.HNNPNKKLNBM.Count; i++)
		{
			tapToContinueObjectsTemp.Add(this.HNNPNKKLNBM[i]);
		}
		this.HNNPNKKLNBM.Clear();
		for (int j = 0; j < tapToContinueObjectsTemp.Count; j++)
		{
			tapToContinueObjectsTemp[j].GetComponent<TapToContinueManager>().FadeOut();
		}
		yield return new WaitForSeconds(0.45f);
		for (int k = 0; k < tapToContinueObjectsTemp.Count; k++)
		{
			UnityEngine.Object.Destroy(tapToContinueObjectsTemp[k]);
		}
		tapToContinueObjectsTemp.Clear();
		yield break;
	}

	// Token: 0x06004772 RID: 18290 RVA: 0x00206272 File Offset: 0x00204472
	private IEnumerator FONKPNMGMGO()
	{
		yield return new WaitForSeconds(1f);
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("CameraBundlesVFXTopMost"))
			{
				if (null != this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>() && this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().enabled)
				{
					this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().ResetLerp(0);
					this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().enabled = false;
					break;
				}
				break;
			}
			else
			{
				i++;
			}
		}
		this.ECBMIHCALBG = null;
		yield break;
	}

	// Token: 0x06004773 RID: 18291 RVA: 0x00206284 File Offset: 0x00204484
	private bool MOCHJHMLGBG()
	{
		int num = 0;
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (null != this.FAEEEHDCNDN[i] && this.FAEEEHDCNDN[i].gameObject.name.Contains("layervideo") && !this.FAEEEHDCNDN[i].gameObject.name.Contains("loop") && this.FAEEEHDCNDN[i].gameObject.activeSelf)
			{
				num += this.FAEEEHDCNDN[i].PauseVideoIfPlaying();
			}
		}
		return num > 0;
	}

	// Token: 0x06004774 RID: 18292 RVA: 0x00206337 File Offset: 0x00204537
	private void KBBPBKJEFCJ()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.OGNJFHPEDNN();
			this.APDAMLCHICH();
			this.OPLBCELFMLI();
			this.storyInterfaceHeaderManager.Show(0f);
		}
	}

	// Token: 0x06004775 RID: 18293 RVA: 0x0020636C File Offset: 0x0020456C
	private void HBHDBDHBEPD()
	{
		this.BODLAMJCHJO = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.HFOPCMIHDOL.ACJPLCIFNPO() == null)
		{
			this.GKHNIMJJLJL.PFHCDMOJOKP();
			return;
		}
		if (SceneStoryManager.premiumChoiceManInTheMiddleAttack == 1)
		{
			this.GKHNIMJJLJL.PFHCDMOJOKP();
			return;
		}
		if (SceneStoryManager.premiumChoiceBackendOperationResult >= 0)
		{
			if (SceneStoryManager.premiumChoiceBackendOperationResultKey.Length > 0)
			{
				this.GKHNIMJJLJL.MLOIILKHFBJ(SceneStoryManager.premiumChoiceBackendOperationResult, SceneStoryManager.premiumChoiceBackendOperationResult2, SceneStoryManager.premiumChoiceBackendOperationResultKey);
			}
			else
			{
				this.GKHNIMJJLJL.PFHCDMOJOKP();
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPremiumChoiceExecuted", 0f);
			if (this.ILJAFHPEKDC)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPremiumChoiceExecutedAdBased", 0f);
			}
			else
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPremiumChoiceExecutedHardBased", 0f);
			}
			if (this.JGEDOIDOPLA != null)
			{
				if (this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JGEDOIDOPLA.KAJNELPPCIJ.Count)
				{
					List<string> collection = this.JGEDOIDOPLA.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()].GECJLAKBEFK();
					SceneStoryManager.freePremiumChoicesFallback.AddRange(collection);
				}
			}
			else if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.KAJNELPPCIJ.Count)
			{
				List<string> collection2 = this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()].GECJLAKBEFK();
				SceneStoryManager.freePremiumChoicesFallback.AddRange(collection2);
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.hardCurrency) != 0)
			{
				if (this.JGEDOIDOPLA != null)
				{
					if (this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JGEDOIDOPLA.KAJNELPPCIJ.Count && AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 1)
					{
					}
				}
				else if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.KAJNELPPCIJ.Count)
				{
					int klpbigjbobe = AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE;
				}
			}
			for (int i = 0; i < SceneStoryManager.choiceSecurityIdList.Count; i++)
			{
				AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PKHJLJJJDAA(SceneStoryManager.choiceSecurityIdList[i], SceneStoryManager.choiceSecurityKeyList[i]);
			}
			this.HFOPCMIHDOL.ACJPLCIFNPO().FEHODJMIAJL(0f, 1);
			return;
		}
		this.GKHNIMJJLJL.PFHCDMOJOKP();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nomorediamonds"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyDecline), DFGILFBGPLN.popupNotEnoughHardCurrency, 0f, 28).ShowDiamonds(SceneStoryManager.premiumChoiceBackendOperationResult);
	}

	// Token: 0x06004776 RID: 18294 RVA: 0x00206658 File Offset: 0x00204858
	private GameObject KOPNJMINIMC(string KHJMANDEDMA)
	{
		string value = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(value))
			{
				return this.KEPHFKAHILM[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06004777 RID: 18295 RVA: 0x002066C0 File Offset: 0x002048C0
	public void NAIHPJHPLPH()
	{
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
		if (this.HAFFEDMEIAF)
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().PLLFCKGMHCF(true);
	}

	// Token: 0x06004778 RID: 18296 RVA: 0x0020671C File Offset: 0x0020491C
	private void OHAIEJKIMFG(int MEFKFOHCOHK)
	{
		try
		{
			if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.MHJMNIHFFEN())
			{
				if (MEFKFOHCOHK >= 2)
				{
					if (this.HFFIIBBJBMH.header.HGIIJABNDCD(MEFKFOHCOHK) != null)
					{
						for (int i = 0; i < this.fadeLayers.Count; i++)
						{
							this.fadeLayers[i].SetCustomFader(GKJPOGNFKNK.PBGGBOADBPJ(this.HFFIIBBJBMH.header.HGIIJABNDCD(MEFKFOHCOHK).assetIndex), this.HFFIIBBJBMH.header.HGIIJABNDCD(MEFKFOHCOHK));
						}
					}
				}
				else
				{
					for (int j = 0; j < this.fadeLayers.Count; j++)
					{
						this.fadeLayers[j].SetCustomFader(null, null);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004779 RID: 18297 RVA: 0x00206800 File Offset: 0x00204A00
	private void BGECHBHBLBM()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		this.JCCNMENAHKG(false);
	}

	// Token: 0x0600477A RID: 18298 RVA: 0x00205BAE File Offset: 0x00203DAE
	private IEnumerator MCGBMAOMOIC()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		this.EPKNCKGNNCE();
		yield break;
	}

	// Token: 0x0600477B RID: 18299 RVA: 0x00206814 File Offset: 0x00204A14
	private void IDLBNMFGLKE()
	{
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (null != this.FAEEEHDCNDN[i] && this.FAEEEHDCNDN[i].gameObject.name.Contains("OnApplicationFocusBasicSyncSuccess") && !this.FAEEEHDCNDN[i].gameObject.name.Contains(", discounted cost:") && this.FAEEEHDCNDN[i].gameObject.activeSelf)
			{
				this.FAEEEHDCNDN[i].ResumeVideoIfPaused();
			}
		}
	}

	// Token: 0x0600477C RID: 18300 RVA: 0x002068C0 File Offset: 0x00204AC0
	private void OHPEONMNFNJ(int MCLBOIFEFGH)
	{
		try
		{
			if (!(null == this.HFFIIBBJBMH) && !(null == this.HFFIIBBJBMH.header))
			{
				CustomFaderSettings customFaderSettings = this.HFFIIBBJBMH.header.HGIIJABNDCD(MCLBOIFEFGH);
				if (customFaderSettings != null)
				{
					for (int i = 0; i < this.HFFIIBBJBMH.header.customFaderSettings.Count; i++)
					{
						CustomFaderSettings customFaderSettings2 = this.HFFIIBBJBMH.header.customFaderSettings[i];
						if (customFaderSettings2 != null && customFaderSettings2.index >= 2 && customFaderSettings2.index < 100 && customFaderSettings2.assetIndex == customFaderSettings.assetIndex)
						{
							return;
						}
					}
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, customFaderSettings.assetIndex);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600477D RID: 18301 RVA: 0x00206994 File Offset: 0x00204B94
	private void GEMEKBNAHAO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.DIIBIOIMPIH), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x0600477E RID: 18302 RVA: 0x00206A14 File Offset: 0x00204C14
	private void KHLOPOIMPHL()
	{
		this.BODLAMJCHJO = false;
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.HJGDLOOHNLO().JHNELLJFBGC("AvatarCollectionsItem.OnAvatarCollectionSelect(): index out of range"), CCOJBMMKNAP.INKJIBDDMLL().JLBEIFLLBLO("continue") + "layervideo" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified", CCOJBMMKNAP.COKDLDOAACJ().JCDFHKDNEDH("tradewishcardoption1"), new UnityAction(this.NLBMHEGAMBK), (DFGILFBGPLN)(-124), 82f, -24);
	}

	// Token: 0x0600477F RID: 18303 RVA: 0x000AE414 File Offset: 0x000AC614
	private void OCAELJPNEBN()
	{
		AppManager.PCJEMMDDCIF().KKNKNOELPPO(false, false);
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x00206A98 File Offset: 0x00204C98
	private void MKJBKIKPJEM(string FOCIFOLONJD)
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.NALOEFHHCCH.Count; i++)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.NALOEFHHCCH[i].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list.Add(this.NALOEFHHCCH[i]);
			}
			else
			{
				list2.Add(this.NALOEFHHCCH[i]);
			}
		}
		this.NALOEFHHCCH = list2;
		base.StartCoroutine(this.DKJCIENFCDJ(list));
	}

	// Token: 0x06004781 RID: 18305 RVA: 0x00206B30 File Offset: 0x00204D30
	private List<int> ABGPKNOEHIN(bool AJDCFJIFEOK)
	{
		List<int> list = new List<int>();
		List<int> activeWardrobeMixList = SceneStoryManager.GetActiveWardrobeMixList(this.GKHNIMJJLJL);
		if (activeWardrobeMixList != null)
		{
			for (int i = 0; i < activeWardrobeMixList.Count; i += 0)
			{
				if (activeWardrobeMixList[i] >= 0 && !list.Contains(activeWardrobeMixList[i]))
				{
					list.Add(activeWardrobeMixList[i]);
				}
			}
		}
		else if (this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME >= 0 && (AJDCFJIFEOK || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] >= 1))
		{
			list.Add(this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME);
		}
		return list;
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x00206BCD File Offset: 0x00204DCD
	public static bool LoungeMappingIsLockedPreview(ECJCFGAOPHJ FFACCDIEBIA)
	{
		return !SceneStoryManager.LoungeMappingUnlockReached(FFACCDIEBIA, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x00206BE4 File Offset: 0x00204DE4
	private void HLBIEIAFBFK()
	{
		if (this.LHBMEFGCPHK())
		{
			if (null != this.imageEffects)
			{
				if (null != this.imageEffectsOvr)
				{
					this.imageEffectsOvr.ShowAllEffectsWithTag("");
				}
				this.imageEffects.ShowAllEffectsWithTag("");
				this.KGMDMKOMOHK("");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			if (null != this.imageEffectsOvr)
			{
				this.imageEffectsOvr.HideAllEffects();
			}
			this.imageEffects.HideAllEffects();
			this.KGMDMKOMOHK("2");
		}
	}

	// Token: 0x06004784 RID: 18308 RVA: 0x00206C7E File Offset: 0x00204E7E
	private IEnumerator MPFIIEOFHIM(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().AnimateDisappearance(GFEJBOAKPMP.animationStoryDisappearToRight);
		}
		yield return new WaitForSeconds(NonPlayerCharacterManager.GetAnimationDisappearTime());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		yield return null;
		yield break;
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x00206C90 File Offset: 0x00204E90
	private void DNLMDAKNCBN()
	{
		if (this.HFOPCMIHDOL.JACPIGBEAFH() == null)
		{
			return;
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		if (this.HFOPCMIHDOL.BNNMNMDEDBH().PINCOCDOOGH())
		{
			this.HFOPCMIHDOL.JACPIGBEAFH().FEHODJMIAJL(1953f, 0);
		}
	}

	// Token: 0x06004786 RID: 18310 RVA: 0x00206CF4 File Offset: 0x00204EF4
	private void LBJMEEGMCNL()
	{
		if (this.NJEPIPLACPC == null || null == this.GFIFDKBLLBL || this.GKHNIMJJLJL == null)
		{
			return;
		}
		try
		{
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			for (int i = 1; i < this.NJEPIPLACPC.Count; i += 0)
			{
				if (ONEHEBIHPFB.NGBNMODJCFJ(this.NJEPIPLACPC[i]))
				{
					list.Add(this.NJEPIPLACPC[i]);
					list2.Add(ONEHEBIHPFB.POPKPNOCLIH(this.NJEPIPLACPC[i]));
				}
			}
			this.GKHNIMJJLJL.NCAMFPGMCIG.OJHGKJECIBK(Math.Max(1, this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[1]), list, list2, this.EPAIPMEJOJB());
			this.GKHNIMJJLJL.NCAMFPGMCIG.CMNFNOLANGL(this.CJJHMPCBGOM(false));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004787 RID: 18311 RVA: 0x001FC1F2 File Offset: 0x001FA3F2
	private void KJFKCEOLMND()
	{
		this.BIMHNCJHLBO();
	}

	// Token: 0x06004788 RID: 18312 RVA: 0x00206DE0 File Offset: 0x00204FE0
	private void OJPAMNKMOMA()
	{
		int i = 1;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("OnSketchViewShowWI"))
			{
				if (null != this.cameras[i].gameObject.GetComponent<BlurOptimized>())
				{
					this.cameras[i].gameObject.GetComponent<BlurOptimized>().enabled = false;
					return;
				}
				break;
			}
			else
			{
				i += 0;
			}
		}
	}

	// Token: 0x06004789 RID: 18313 RVA: 0x00206E60 File Offset: 0x00205060
	private void AMHDGFKGIIE()
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		for (int i = 1; i < this.MPNBBKODANC.Count; i += 0)
		{
			list.Add(this.MPNBBKODANC[i]);
		}
		this.MPNBBKODANC.Clear();
		base.StartCoroutine(this.JFKNHKBKFPM(list));
	}

	// Token: 0x0600478A RID: 18314 RVA: 0x00206EB4 File Offset: 0x002050B4
	private float LLIFOIJCBAE(MOLKEIABAOJ DLKCKCKOCOI)
	{
		float result;
		try
		{
			float idhbpdacmaa = DLKCKCKOCOI.JPHIPBEBNGD().NCKKJGPMGHG + DLKCKCKOCOI.JPHIPBEBNGD().CICCPMFOCGH;
			float fehfgenfbpp = 1f;
			if (DLKCKCKOCOI.JPHIPBEBNGD().HNNHBPDBCGG != null)
			{
				fehfgenfbpp = DLKCKCKOCOI.JPHIPBEBNGD().HNNHBPDBCGG.FKOHEKBAOEK;
			}
			result = this.DMNJMLDEILJ.Play(DLKCKCKOCOI.JPHIPBEBNGD().ILBOLKIAOGK, DLKCKCKOCOI.JPHIPBEBNGD().JCGHCKFAOKI, DLKCKCKOCOI.JPHIPBEBNGD().AJFDHJEKIBO, fehfgenfbpp, idhbpdacmaa);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != this.DMNJMLDEILJ)
			{
				this.DMNJMLDEILJ.CancelImmediate();
			}
			result = -1f;
		}
		return result;
	}

	// Token: 0x0600478B RID: 18315 RVA: 0x0005F01E File Offset: 0x0005D21E
	private void HBPLGJFPFKM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x0600478C RID: 18316 RVA: 0x001FF20C File Offset: 0x001FD40C
	public static bool CIMEKEGFFAE(ECJCFGAOPHJ FFACCDIEBIA, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return SceneStoryManager.LoungeMappingGateReached(LFLOCKNKAKC, FFACCDIEBIA.PBGKGCHMHOP, FFACCDIEBIA.CGKKPPEIFJH);
	}

	// Token: 0x0600478D RID: 18317 RVA: 0x00206F68 File Offset: 0x00205168
	private void KFGNHIOJGON()
	{
		if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.CanInteract())
		{
			if (this.storyInterfaceHeaderManager.IsPaused())
			{
				return;
			}
			this.JNFIBEFKKBO();
		}
	}

	// Token: 0x0600478E RID: 18318 RVA: 0x00206F9C File Offset: 0x0020519C
	private void MPHBOEIKDEI()
	{
		if (SceneStoryManager.BLMFAKBBMOE.Count > 0)
		{
			base.Invoke("eventType", 88f);
			return;
		}
		SceneStoryManager.loungePremiumChoicesHistoryState = 1;
		if (this.MNDOHKJIFDD)
		{
			this.MNDOHKJIFDD = false;
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			this.EGNAHFEGEJM();
		}
	}

	// Token: 0x0600478F RID: 18319 RVA: 0x00206FEC File Offset: 0x002051EC
	private int BBAHMGCCIHJ()
	{
		int num = 0;
		this.GGPMPJOEIJN.Clear();
		this.GFIAPGFHIGM.Clear();
		this.LMFEMNCAICA.Clear();
		FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(StoryInterfaceHeaderManager.anthologyIndex);
		if (fjlgcknojmj == null)
		{
			return 0;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
		{
			if (SceneStoryManager.CHPFNHINCOG(fjlgcknojmj.OINAAMKLNLO[i]))
			{
				bool flag = false;
				GHMINFEGBGN ghminfegbgn = new GHMINFEGBGN();
				ghminfegbgn.KALBADOPCDN = fjlgcknojmj.OINAAMKLNLO[i].KALBADOPCDN;
				ghminfegbgn.OIBGFPEGLME = fjlgcknojmj.OINAAMKLNLO[i].OIBGFPEGLME;
				for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
				{
					if (this.BEDGKOBBMCD(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j]))
					{
						bool flag2 = null != GKJPOGNFKNK.IAJMHBFGKBA(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].IJEEKLNDJGE, "");
						if (fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AJPBPJDHFOH > 0 || flag2)
						{
							if (!flag2 && fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AJPBPJDHFOH > 0 && (null == this.HFFIIBBJBMH || !this.HFFIIBBJBMH.header.availableStories.Contains(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AJPBPJDHFOH)))
							{
								DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] look pack eps:" + fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AJPBPJDHFOH.ToString() + " is OUTSIDE the anthology's published story family - look not offered: " + fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].IJEEKLNDJGE);
							}
							else
							{
								flag = true;
								AFIBCKPKDHB afibckpkdhb = new AFIBCKPKDHB();
								afibckpkdhb.BDIHOCKCCBL = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].IJEEKLNDJGE;
								afibckpkdhb.CENMIEOCAMN = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].CENMIEOCAMN;
								afibckpkdhb.JCJNJNMPPOK = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].JCJNJNMPPOK;
								afibckpkdhb.ENBBONPKHBC = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].ENBBONPKHBC;
								afibckpkdhb.KEFMKINFOFA = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].KEFMKINFOFA;
								afibckpkdhb.NLCHIGHHAEC = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].PBGKGCHMHOP;
								afibckpkdhb.PKJHDFINDHP = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].CGKKPPEIFJH;
								afibckpkdhb.MJLAEJCFCEF = SceneStoryManager.LoungeMappingIsLockedPreview(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j]);
								afibckpkdhb.OLAKHHEICKO = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].OLAKHHEICKO;
								afibckpkdhb.MDKIKKJNJKK = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].MDKIKKJNJKK;
								afibckpkdhb.JNCJNLEAFLG = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].JNCJNLEAFLG;
								afibckpkdhb.IENEDGACMMK = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].LMEALGJPGDA();
								afibckpkdhb.OBLBNLBFBNI = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].OBLBNLBFBNI;
								afibckpkdhb.LOFFJOKOOKD = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].LOFFJOKOOKD;
								afibckpkdhb.PODGFLMDBEC = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].PODGFLMDBEC;
								afibckpkdhb.CECLJNKHJEE = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].CECLJNKHJEE;
								afibckpkdhb.MNBBOAPGCMM = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].MNBBOAPGCMM;
								afibckpkdhb.HKLEKGFCMFI = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].NIOGHOKEKDI(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA());
								afibckpkdhb.CGCLCPOHJEP = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].BMJIGANCIDG(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA());
								afibckpkdhb.CBLPKDDMLBL = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].CBLPKDDMLBL;
								afibckpkdhb.JBFCIJKENJP = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].JBFCIJKENJP;
								afibckpkdhb.PMFNECKIMBG = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].PMFNECKIMBG;
								afibckpkdhb.DENODLCMDAL = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j];
								ghminfegbgn.LJFCMJJFCOI.Add(afibckpkdhb);
								this.PCFBCHNFMBG += this.CPDCOODDHDE(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j]);
								if (!flag2)
								{
									AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].AJPBPJDHFOH, fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].BACMOGGNBNH, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, 900000, false, "", false, false);
									num++;
								}
							}
						}
					}
				}
				if (flag)
				{
					this.LMFEMNCAICA.Add(ghminfegbgn);
					int oibgfpeglme = fjlgcknojmj.OINAAMKLNLO[i].OIBGFPEGLME;
					if (oibgfpeglme < 0)
					{
						oibgfpeglme = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.OIBGFPEGLME;
					}
					if (!list.Contains(oibgfpeglme))
					{
						list.Add(oibgfpeglme);
					}
				}
			}
		}
		for (int k = 0; k < fjlgcknojmj.NAAGOKCKHEC.Count; k++)
		{
			if (list.Contains(fjlgcknojmj.NAAGOKCKHEC[k].OIBGFPEGLME))
			{
				num += this.ACDAJNPBBNG(fjlgcknojmj.NAAGOKCKHEC[k]);
				this.GGPMPJOEIJN.Add(fjlgcknojmj.NAAGOKCKHEC[k].OIBGFPEGLME);
				this.GFIAPGFHIGM.Add(fjlgcknojmj.NAAGOKCKHEC[k].FLPGNPNHJNK);
				if (!(null != this.LDLPKDIFOAD(fjlgcknojmj.NAAGOKCKHEC[k].FLPGNPNHJNK)) && fjlgcknojmj.NAAGOKCKHEC[k].HAHPPPLJJPE > 0)
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, fjlgcknojmj.NAAGOKCKHEC[k].HAHPPPLJJPE, fjlgcknojmj.NAAGOKCKHEC[k].FOMDAACIIJN, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, 900000, false, "", false, false);
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06004790 RID: 18320 RVA: 0x0020775C File Offset: 0x0020595C
	private void HGFJJFKDBFI()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text != null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1) != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBCACCKOABP(text, false);
		}
	}

	// Token: 0x06004791 RID: 18321 RVA: 0x0020779C File Offset: 0x0020599C
	private void GLOEGOPLGDN()
	{
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (null != this.FAEEEHDCNDN[i] && this.FAEEEHDCNDN[i].gameObject.name.Contains("layervideo") && !this.FAEEEHDCNDN[i].gameObject.name.Contains("loop") && this.FAEEEHDCNDN[i].gameObject.activeSelf)
			{
				this.FAEEEHDCNDN[i].ResumeVideoIfPaused();
			}
		}
	}

	// Token: 0x06004792 RID: 18322 RVA: 0x00207848 File Offset: 0x00205A48
	private void BAMIANEOKAP(string KHJMANDEDMA, float BFLBCFEGMIB, float JHBAIJIJIBN)
	{
		bool flag = false;
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].SetZoomOutParams(BFLBCFEGMIB, JHBAIJIJIBN);
				this.KEPHFKAHILM[i].ZoomOut(null);
			}
			else
			{
				this.KEPHFKAHILM[i].ResetZoom();
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				flag = true;
				this.CHHIBBOICAD[j].SetZoomOutParams(BFLBCFEGMIB, JHBAIJIJIBN);
				this.CHHIBBOICAD[j].ZoomOut(null);
			}
			else
			{
				this.CHHIBBOICAD[j].ResetZoom();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. ZoomDst(), environment " + text + " not found.");
		}
	}

	// Token: 0x06004793 RID: 18323 RVA: 0x0020795C File Offset: 0x00205B5C
	private int AGPACBCOAEI(ECAPOEGMMIB DCEEBNNKPGJ)
	{
		try
		{
			if (DCEEBNNKPGJ.KPPJINFHMIP == null || DCEEBNNKPGJ.KPPJINFHMIP.Length == 0)
			{
				return 1;
			}
			if (DCEEBNNKPGJ.IHMEFMPMDFC <= 1)
			{
				return 0;
			}
			if (!NBDLBFJOEGN.NDFLNHIAKJH() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB())
			{
				return 1;
			}
			if (null == this.HFFIIBBJBMH || !this.HFFIIBBJBMH.header.availableStories.Contains(DCEEBNNKPGJ.IHMEFMPMDFC))
			{
				string[] array = new string[0];
				array[0] = "";
				array[0] = DCEEBNNKPGJ.IHMEFMPMDFC.ToString();
				array[6] = "";
				array[4] = DCEEBNNKPGJ.KPPJINFHMIP;
				array[7] = "rewardtitle";
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return 0;
			}
			if (AudioManager.DMAAFFFEJGA().GMJMEHGBFKK(CCEMAFOMLLK.ambient, DCEEBNNKPGJ.KPPJINFHMIP))
			{
				return 1;
			}
			string item = "cardoptionsloadingthemelostbonus" + DCEEBNNKPGJ.IHMEFMPMDFC.ToString() + "trialmode" + DCEEBNNKPGJ.OAMJJIFAAHJ.ToString();
			if (this.KEPLJDAONLC.Contains(item))
			{
				return 1;
			}
			this.KEPLJDAONLC.Add(item);
			AssetsManager.MJBDMHPHMID().QueueAssetBundleDownload(NMKDCBPMCKI._deprecated0, DCEEBNNKPGJ.IHMEFMPMDFC, DCEEBNNKPGJ.OAMJJIFAAHJ, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, 104, true, "PurchaseManagerUnity.CompletePurchase(): Not initialized.", false, false);
			return 0;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 0;
	}

	// Token: 0x06004794 RID: 18324 RVA: 0x00207AD0 File Offset: 0x00205CD0
	private void NJJEBHJGNOJ()
	{
		this.JCCNMENAHKG(true);
		if (this.GKHNIMJJLJL.HPNLAJDDAFE() && null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ShowInterfaceUndoButton();
		}
	}

	// Token: 0x06004795 RID: 18325 RVA: 0x00206272 File Offset: 0x00204472
	private IEnumerator GNANLOGFMBM()
	{
		yield return new WaitForSeconds(1f);
		int i = 0;
		while (i < this.cameras.Count)
		{
			if (this.cameras[i].gameObject.name.Contains("CameraBundlesVFXTopMost"))
			{
				if (null != this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>() && this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().enabled)
				{
					this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().ResetLerp(0);
					this.cameras[i].gameObject.GetComponent<VignetteFisheyeGrayscale>().enabled = false;
					break;
				}
				break;
			}
			else
			{
				i++;
			}
		}
		this.ECBMIHCALBG = null;
		yield break;
	}

	// Token: 0x06004796 RID: 18326 RVA: 0x00207B00 File Offset: 0x00205D00
	private FGINKFGNNEK DBGJNLEBFFL(string PDEADFPONFH, List<string> MPLEPCPGJBA)
	{
		for (int i = 0; i < this.PKPMIABFBON.Count; i++)
		{
			if (this.PKPMIABFBON[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().IsEqual(PDEADFPONFH, MPLEPCPGJBA))
			{
				return this.PKPMIABFBON[i];
			}
		}
		return null;
	}

	// Token: 0x06004797 RID: 18327 RVA: 0x00207B50 File Offset: 0x00205D50
	private void BGECFOJDPAD()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.LMCCLMFGEBD().HPOAGPJFHPM("$TAKEAVATARSNAPSHOT"), CCOJBMMKNAP.JMNIGPHCAEJ().BDGPNPNIAPA("/") + "Steps" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "", CCOJBMMKNAP.PLJMLDOCPNM().JLBEIFLLBLO("StoryStepDialogNarrator.RemoveChoiceAtEnd - _choicesToRemove is <= 0."), new UnityAction(this.COJKOKBNOHM), new UnityAction(this.BIMHNCJHLBO), DFGILFBGPLN.popupPurchaseError, 1285f, -114);
	}

	// Token: 0x06004798 RID: 18328 RVA: 0x001FD481 File Offset: 0x001FB681
	private IEnumerator IINJKALCHKG(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<DialogTitleManager>().DisappearAnimation();
		}
		yield return new WaitForSeconds(DialogTitleManager.GetDisappearAnimationLength());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		yield return null;
		yield break;
	}

	// Token: 0x06004799 RID: 18329 RVA: 0x00207BD9 File Offset: 0x00205DD9
	private IEnumerator EIJIIEBPOFE(bool KGAMNDCLMJP, bool NNIPFOCMAFI)
	{
		if (this.MCIGJBFKOIJ)
		{
			yield break;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			if (!KGAMNDCLMJP)
			{
				this.storyInterfaceHeaderManager.Hide();
			}
			this.storyInterfaceHeaderManager.HideInterfaceUndoButton();
		}
		this.MCIGJBFKOIJ = true;
		this.MBBFJHBFPNB = true;
		this.LPCBDEBKAIM();
		if (KGAMNDCLMJP)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			SceneTransitionToLobbyManager.isRestoringRewindPoint = false;
			SceneTransitionToLobbyManager.isRestoringUndoPoint = true;
			SceneTransitionToLobbyManager.isRestartingChapter = false;
		}
		else if (NNIPFOCMAFI)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			SceneTransitionToLobbyManager.isRestoringRewindPoint = true;
			SceneTransitionToLobbyManager.isRestoringUndoPoint = false;
			SceneTransitionToLobbyManager.isRestartingChapter = false;
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
			SceneTransitionToLobbyManager.isRestoringRewindPoint = false;
			SceneTransitionToLobbyManager.isRestoringUndoPoint = false;
			SceneTransitionToLobbyManager.isRestartingChapter = true;
		}
		if (SceneTransitionToLobbyManager.isRestoringUndoPoint)
		{
			yield return new WaitForSeconds(1f);
		}
		else
		{
			yield return new WaitForSeconds(1f);
		}
		AudioManager.EHBBFMCILPC.FadeMusic(1f, 1f);
		AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		AudioManager.EHBBFMCILPC.KillAmbient("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnBackClickPart2));
		ApplicationFocusManager.Deactivate();
		yield break;
	}

	// Token: 0x0600479A RID: 18330 RVA: 0x00207BF6 File Offset: 0x00205DF6
	private void LHJADJAAJOO()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		if (null != this.FNHFGLHODBG)
		{
			this.FNHFGLHODBG.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600479B RID: 18331 RVA: 0x00207C20 File Offset: 0x00205E20
	private CustomWardrobeSettings PCDHECPEOAJ()
	{
		try
		{
			if (this.GKHNIMJJLJL != null && null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.HNKINNNFKEO() && this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME < this.HFFIIBBJBMH.header.customWardrobeSettings.Count)
			{
				return this.HFFIIBBJBMH.header.customWardrobeSettings[this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x0600479C RID: 18332 RVA: 0x00200BEC File Offset: 0x001FEDEC
	private static bool PLJCEBOJHHM(int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		return SceneStoryManager.LoungeMappingGateReached(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP(), NLLCKPCKGOH, OLKMHHNMDLP);
	}

	// Token: 0x0600479D RID: 18333 RVA: 0x00207CC0 File Offset: 0x00205EC0
	private void CIBKGEHJKCC()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.lite);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmLite.ToString(), BGHLMGPPCNN.gmLocSett.ToString(), false, false);
		this.DNGHLBFEODC();
	}

	// Token: 0x0600479E RID: 18334 RVA: 0x00207D1C File Offset: 0x00205F1C
	private void MPOMCODNAOB()
	{
		if (SceneStoryManager.BLMFAKBBMOE.Count > 1)
		{
			base.Invoke("rat", 1786f);
			return;
		}
		SceneStoryManager.loungePremiumChoicesHistoryState = 8;
		if (this.MNDOHKJIFDD)
		{
			this.MNDOHKJIFDD = false;
			CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
			this.EGNAHFEGEJM();
		}
	}

	// Token: 0x0600479F RID: 18335 RVA: 0x00207D6C File Offset: 0x00205F6C
	private void HLPMCCEDBLF(KFIHMMIGPLO PBKAAIONJOB, string KHJMANDEDMA)
	{
		if (KHJMANDEDMA.Length > 0)
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(PBKAAIONJOB, KHJMANDEDMA, null);
			if (null != assetAvatarComponent)
			{
				if (assetAvatarComponent.exposition == HPKJCKOHAAI.exposable)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HLPMCCEDBLF(KHJMANDEDMA);
					return;
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager.UpdateAvatarConfiguration(), avatar component asset missing:" + KHJMANDEDMA);
			}
		}
	}

	// Token: 0x060047A0 RID: 18336 RVA: 0x00207DC4 File Offset: 0x00205FC4
	private void OnDestroy()
	{
		if (CommonUserInterface.IsInitialized())
		{
			this.AMBEPJCICOF();
		}
		if (NBDLBFJOEGN.LCNGCDFHFOM(this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH]))
		{
			this.NJAAOCMPKCD.chapterAssetPacks[this.HODJEPIPDFH].KMMFCKHINBO();
		}
		ONEHEBIHPFB.DKGAAPOONJJ(null);
		this.CHHIBBOICAD.Clear();
		this.KEPHFKAHILM.Clear();
		this.FAEEEHDCNDN.Clear();
		this.BAFONBJIKLA.Clear();
		this.ODNCKIKLFCM.Clear();
		if (null != this.IAJFFABJAHB)
		{
			UnityEngine.Object.Destroy(this.IAJFFABJAHB);
			this.IAJFFABJAHB = null;
		}
		try
		{
			if (null != this.IKKEDBBANCO)
			{
				UnityEngine.Object.Destroy(this.IKKEDBBANCO);
				this.IKKEDBBANCO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.GFFLNCOEEKP.DOKill(false);
		this.MGDOAFNHBHP.DOKill(false);
		SceneStoryManager.freePremiumChoicesFallback.Clear();
		SceneStoryManager.freePremiumChoices.Clear();
		SceneStoryManager.loungePremiumChoicesHistoryState = 0;
		SceneStoryManager.BLMFAKBBMOE.Clear();
		this.MNDOHKJIFDD = false;
		SceneStoryManager.achievements = new JSONArray();
		SceneStoryManager.achievementSyncReward = 0;
		if (AssetsManager.IsInitialized())
		{
			AssetsManager.EHBBFMCILPC.UnregisterStoryAssets(this);
		}
		if (this.HFOPCMIHDOL != null)
		{
			this.HFOPCMIHDOL.ILPDFGDNABG();
		}
		this.GFIFDKBLLBL = null;
		this.HFFIIBBJBMH = null;
		DHGFCJGJFOB.KPHNADKJHMJ = null;
		if (SceneStoryManager.IKLAPGJDMNA == this)
		{
			SceneStoryManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060047A1 RID: 18337 RVA: 0x00207F50 File Offset: 0x00206150
	public void OnPopupNotEnoughEnergyOrHardCurrencyGetMore()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore2));
	}

	// Token: 0x060047A2 RID: 18338 RVA: 0x00207F7C File Offset: 0x0020617C
	private void NBJLCHMLOLA()
	{
		this.AMBEPJCICOF();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.DJOALKMNJEM));
		this.CMDIKMNEGEN();
	}

	// Token: 0x060047A3 RID: 18339 RVA: 0x002008B8 File Offset: 0x001FEAB8
	public static bool IDHKAPHEIPF()
	{
		return SceneStoryManager.AnyLoungeCharacterInActiveWardrobe(StoryInterfaceHeaderManager.anthologyIndex, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
	}

	// Token: 0x060047A4 RID: 18340 RVA: 0x00207FB0 File Offset: 0x002061B0
	private void IEMADPMFPOF(string KHJMANDEDMA, float BFLBCFEGMIB, float JHBAIJIJIBN)
	{
		bool flag = false;
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].SetZoomInParams(BFLBCFEGMIB, JHBAIJIJIBN);
				this.KEPHFKAHILM[i].ZoomIn(null);
			}
			else
			{
				this.KEPHFKAHILM[i].ResetZoom();
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				flag = true;
				this.CHHIBBOICAD[j].SetZoomInParams(BFLBCFEGMIB, JHBAIJIJIBN);
				this.CHHIBBOICAD[j].ZoomIn(null);
			}
			else
			{
				this.CHHIBBOICAD[j].ResetZoom();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. ZoomSrc(), environment " + text + " not found.");
		}
	}

	// Token: 0x060047A5 RID: 18341 RVA: 0x002080C3 File Offset: 0x002062C3
	private void NFACNJFPKCF(bool NIEJFHHKNGN)
	{
		if (NIEJFHHKNGN && this.KKIGOAKNCIE >= 1)
		{
			return;
		}
		if (ODLJHDIGLGO.NEABBOKICBA(CLHDENLPOFP.eventPass) != null && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass).OFINCPJNPJC())
		{
			this.KBBPBKJEFCJ();
			this.KKIGOAKNCIE += 0;
		}
	}

	// Token: 0x060047A6 RID: 18342 RVA: 0x002080FC File Offset: 0x002062FC
	private void CIKCCGDOFNI()
	{
		if (ODJKHCHFKNL.APEDECLDPKM() != DFGILFBGPLN.screenHub)
		{
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.ODOPEGPBCCD();
		this.ANPFJKKHIJG();
		this.GOLDLGPECBJ();
		this.KBBPBKJEFCJ();
		if (this.HFOPCMIHDOL.DMDPCOFOLEK().ONECLDMJKEE().OBKCKGHFMDN == KGLBKJKNPFD.LBFFMOMMAPK.chapterEnd && this.HFOPCMIHDOL.HFFBFNNEOPB().JPHIPBEBNGD().BOPJOMGIJIA == OHAAGENIEMD.BMHGEBOHLHH.showRemoveAdsOffer)
		{
			this.HFOPCMIHDOL.DMDPCOFOLEK().FEHODJMIAJL(1100f, 0);
		}
		this.IDLBNMFGLKE();
		this.AIGBJLAPFLH();
		if (this.HAFFEDMEIAF)
		{
			this.BIMHNCJHLBO();
		}
		this.CBNBDIMFAII();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			this.HBPLGJFPFKM();
		}
	}

	// Token: 0x060047A7 RID: 18343 RVA: 0x0020255C File Offset: 0x0020075C
	private IEnumerator KLPHDBHBAMK()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
		}
		this.OHPEONMNFNJ(1);
		if (null != AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0) && !this.NJAAOCMPKCD.chapterAssetPacks[AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN()].preloadAvatarScene)
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
		}
		yield break;
	}

	// Token: 0x060047A8 RID: 18344 RVA: 0x002081B8 File Offset: 0x002063B8
	private void GNEIAKDLELG()
	{
		this.AMBEPJCICOF();
		this.MCIGJBFKOIJ = false;
		this.OBPPPNCALNP++;
		if (this.OBPPPNCALNP < KBOJLHAJPCP.LPJOFEDNKHA)
		{
			base.StartCoroutine(this.JPEPPPHJIBN());
			return;
		}
		this.OBPPPNCALNP = 0;
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnStyToAvt.ToString(), false, false);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK() == null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnAvatarClick), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnAvatarClick), new UnityAction(this.OnAvatarClick), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
	}

	// Token: 0x060047A9 RID: 18345 RVA: 0x00208304 File Offset: 0x00206504
	private List<int> PNEAHBGAEPD(bool AJDCFJIFEOK)
	{
		List<int> list = new List<int>();
		List<int> activeWardrobeMixList = SceneStoryManager.GetActiveWardrobeMixList(this.GKHNIMJJLJL);
		if (activeWardrobeMixList != null)
		{
			for (int i = 0; i < activeWardrobeMixList.Count; i += 0)
			{
				if (activeWardrobeMixList[i] >= 1 && !list.Contains(activeWardrobeMixList[i]))
				{
					list.Add(activeWardrobeMixList[i]);
				}
			}
		}
		else if (this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME >= 0 && (AJDCFJIFEOK || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[1] >= 1))
		{
			list.Add(this.GKHNIMJJLJL.NCAMFPGMCIG.OIBGFPEGLME);
		}
		return list;
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x002083A4 File Offset: 0x002065A4
	public void HCFGFLKKEKN()
	{
		if (FacebookManager.OJPLEEFDGHB().DOOCDOBEBPJ())
		{
			CommonUserInterface.IKNOFBFMPGA().CLOBADKFEOG(true, this.HFFIIBBJBMH.header.enablePostEffects, false);
			if (this.NJFGACHFENE())
			{
				this.ACJLMIELCME();
				return;
			}
		}
		else
		{
			base.StartCoroutine(this.DEMIIEHPNIH());
		}
	}

	// Token: 0x060047AB RID: 18347 RVA: 0x002083F8 File Offset: 0x002065F8
	private void AAPDFHFPILE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		AudioManager.EHBBFMCILPC.PlayAmbient(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FODGKMIIHFO, 1.5f);
	}

	// Token: 0x060047AC RID: 18348 RVA: 0x00208448 File Offset: 0x00206648
	private void ACPDJAEHHGN(string MAEAPOCGBII)
	{
		FGINKFGNNEK fginkfgnnek = this.BFBFBGHBPFM(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ());
		if (fginkfgnnek != null)
		{
			fginkfgnnek.IACFDHCDEME.GetComponent<PlayerCharacterManager>().InvokeExtension(MAEAPOCGBII);
		}
	}

	// Token: 0x060047AD RID: 18349 RVA: 0x00208488 File Offset: 0x00206688
	private void GOLDLGPECBJ()
	{
		if (this.LDAPOBMECNI > 0 || this.CMBLMOJFGAE.Count > 0 || this.LLEHEBBHAOD.Count > 0)
		{
			this.playerCharacterOffscreenRenderCamera.gameObject.SetActive(true);
			this.playerCharacterRenderTextureCanvas.enabled = true;
		}
	}

	// Token: 0x060047AE RID: 18350 RVA: 0x002084D8 File Offset: 0x002066D8
	private void JNFIBEFKKBO()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnStoryCurrencyInfoClickPart2));
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x00208534 File Offset: 0x00206734
	public static void FindAllObjectsInChildren(GameObject PHLJNFHEEIB, List<GameObject> DCCIKANAEEM)
	{
		DCCIKANAEEM.Add(PHLJNFHEEIB);
		for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
		{
			SceneStoryManager.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject, DCCIKANAEEM);
		}
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x00208578 File Offset: 0x00206778
	public static bool LoungeSnapshotSpriteUsable(string HAPADEOFKBP)
	{
		if (HAPADEOFKBP == null || HAPADEOFKBP.Length == 0)
		{
			return false;
		}
		if (HAPADEOFKBP.StartsWith("temp", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		int num = 0;
		return !int.TryParse(HAPADEOFKBP, out num) && HAPADEOFKBP.IndexOf(':') < 0 && HAPADEOFKBP.IndexOf(';') < 0;
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x002085CC File Offset: 0x002067CC
	private void BGEHIGPMFEB()
	{
		SceneStoryManager.premiumChoiceManInTheMiddleAttack = 1;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("notgenuinecopy") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x0020865C File Offset: 0x0020685C
	private FGINKFGNNEK AHBCDMIMLGA(DOLBFGIPPOG EEPJKGBBBHC)
	{
		for (int i = 0; i < this.NALOEFHHCCH.Count; i++)
		{
			if (this.NALOEFHHCCH[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().IsEqual(EEPJKGBBBHC))
			{
				return this.NALOEFHHCCH[i];
			}
		}
		return null;
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x002086AC File Offset: 0x002068AC
	private bool DAOELEMFFHB(MOLKEIABAOJ DLKCKCKOCOI)
	{
		SceneStoryManager.KODEFAMOIKH kodefamoikh = new SceneStoryManager.KODEFAMOIKH();
		kodefamoikh.<>4__this = this;
		bool result;
		try
		{
			if (!EnvironmentMorphManager.FJDEOFJMLAO())
			{
				result = true;
			}
			else
			{
				if (null == this.DMNJMLDEILJ)
				{
					this.DMNJMLDEILJ = base.gameObject.AddComponent<EnvironmentMorphManager>();
				}
				if (this.DMNJMLDEILJ.LOJAGMLGPCC())
				{
					result = false;
				}
				else
				{
					for (int i = 1; i < DLKCKCKOCOI.JPHIPBEBNGD().GIPMNEKDKIL.Count; i += 0)
					{
						if (DLKCKCKOCOI.JPHIPBEBNGD().GIPMNEKDKIL[i].Contains("importanttitle"))
						{
							return false;
						}
					}
					for (int j = 1; j < this.FAEEEHDCNDN.Count; j += 0)
					{
						if (null != this.FAEEEHDCNDN[j] && this.FAEEEHDCNDN[j].gameObject.activeInHierarchy && this.FAEEEHDCNDN[j].gameObject.name.ToLowerInvariant().Contains("StorySaveBody.AvatarPackIsUsedByAnyAvatarWardrobe(), unsupported wardrobe index:"))
						{
							return false;
						}
					}
					for (int k = 0; k < this.fadeLayers.Count; k += 0)
					{
						if (null != this.fadeLayers[k] && this.fadeLayers[k].gameObject.activeSelf)
						{
							return true;
						}
					}
					Camera camera = null;
					for (int l = 0; l < this.cameras.Count; l += 0)
					{
						if (this.cameras[l].gameObject.name.Contains("OnLoungePremiumChoicesHistoryException"))
						{
							camera = this.cameras[l];
							break;
						}
					}
					if (null == camera)
					{
						result = true;
					}
					else
					{
						BlurOptimized component = camera.gameObject.GetComponent<BlurOptimized>();
						if (null != component && component.enabled)
						{
							result = false;
						}
						else if (!this.DMNJMLDEILJ.BPBIINCPFGA())
						{
							result = true;
						}
						else
						{
							kodefamoikh.stepDesc = DLKCKCKOCOI;
							this.DMNJMLDEILJ.DDHNIBOFANM(camera, new TweenCallback(kodefamoikh.NDALNHLFPHD), new TweenCallback(kodefamoikh.LINOAKGHBLF));
							result = true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x002088F4 File Offset: 0x00206AF4
	private void DJAIKHPDFJA(string KHJMANDEDMA, float ABJLFDECAAE)
	{
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i += 0)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].Flip(ABJLFDECAAE);
			}
		}
		for (int j = 1; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				this.CHHIBBOICAD[j].NNFGIOLJOIC(ABJLFDECAAE);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("" + text + ") > totalOffloadedCounter (");
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x002089B5 File Offset: 0x00206BB5
	private void CJLNNMCHOEB()
	{
		if (SceneStoryManager.loungePremiumChoicesHistoryState == 2)
		{
			SceneStoryManager.loungePremiumChoicesHistoryState = 0;
		}
	}

	// Token: 0x060047B6 RID: 18358 RVA: 0x002089C8 File Offset: 0x00206BC8
	private void HMOKDIODADD()
	{
		if (this.HODJEPIPDFH == 0 && this.NJAAOCMPKCD.index % 5 == 0)
		{
			this.CHDPABJGOOC();
			return;
		}
		SceneStoryManager.consumeEnergyBackendOperationResult = -1;
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestConsumeEnergy("OnConsumeEnergySuccess", "OnConsumeEnergyException", AKLFPGMDKLA.ACFJMCBMOFG(this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index)), this.HODJEPIPDFH, this.HFFIIBBJBMH.header.index);
	}

	// Token: 0x060047B7 RID: 18359 RVA: 0x00208A54 File Offset: 0x00206C54
	private void MHKLLCIENGM(string KHJMANDEDMA, float JHBAIJIJIBN)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 2)
		{
			bool flag = false;
			for (int i = 0; i < this.fadeLayers.Count; i++)
			{
				if (this.fadeLayers[i].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag = true;
					this.fadeLayers[i].SetFadeOutDuration(JHBAIJIJIBN);
					this.fadeLayers[i].FadeOut(null);
				}
				else
				{
					this.fadeLayers[i].Reset();
				}
			}
			if (!flag)
			{
				KHJMANDEDMA = "black";
				for (int j = 0; j < this.fadeLayers.Count; j++)
				{
					if (this.fadeLayers[j].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag = true;
						this.fadeLayers[j].SetFadeOutDuration(JHBAIJIJIBN);
						this.fadeLayers[j].FadeOut(null);
					}
					else
					{
						this.fadeLayers[j].Reset();
					}
				}
				if (!flag)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. FadeDst(), layer " + KHJMANDEDMA + " not found.");
					return;
				}
			}
		}
		else
		{
			bool flag2 = false;
			for (int k = 0; k < this.fadeLayers.Count; k++)
			{
				if (this.fadeLayers[k].gameObject.name.Equals(KHJMANDEDMA))
				{
					flag2 = true;
					this.fadeLayers[k].SetFadeOutDuration(JHBAIJIJIBN);
					this.fadeLayers[k].FadeOutFromCurrent(null);
				}
				else
				{
					this.fadeLayers[k].Reset();
				}
			}
			if (!flag2)
			{
				KHJMANDEDMA = "black";
				for (int l = 0; l < this.fadeLayers.Count; l++)
				{
					if (this.fadeLayers[l].gameObject.name.Equals(KHJMANDEDMA))
					{
						flag2 = true;
						this.fadeLayers[l].SetFadeOutDuration(JHBAIJIJIBN);
						this.fadeLayers[l].FadeOut(null);
					}
					else
					{
						this.fadeLayers[l].Reset();
					}
				}
				if (!flag2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. FadeDst(), layer " + KHJMANDEDMA + " not found.");
				}
			}
		}
	}

	// Token: 0x060047B8 RID: 18360 RVA: 0x002050D0 File Offset: 0x002032D0
	public static bool LoungeWardrobeVisited(int KFCMLNPLAHK, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return LFLOCKNKAKC != null && LFLOCKNKAKC.NCAMFPGMCIG.GNPAKEFPGPB != null && LFLOCKNKAKC.NCAMFPGMCIG.GNPAKEFPGPB.Contains(KFCMLNPLAHK);
	}

	// Token: 0x060047B9 RID: 18361 RVA: 0x00208C92 File Offset: 0x00206E92
	private IEnumerator JPEPPPHJIBN()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		this.OnGetCdnDataForAvatarScreenSuccess();
		yield break;
	}

	// Token: 0x060047BA RID: 18362 RVA: 0x00208CA4 File Offset: 0x00206EA4
	private void LFFONLGJFBH()
	{
		SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array[i].environmentsBackList.Count; j++)
			{
				if (null != array[i].environmentsBackList[j])
				{
					array[i].environmentsBackList[j].transform.SetParent(this.environmentsBackPivot.transform, false);
					this.CHHIBBOICAD.Add(array[i].environmentsBackList[j]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].environmentsBackList[j] is null!");
				}
			}
			for (int k = 0; k < array[i].environmentsFrontList.Count; k++)
			{
				if (null != array[i].environmentsFrontList[k])
				{
					array[i].environmentsFrontList[k].transform.SetParent(this.environmentsFrontPivot.transform, false);
					this.KEPHFKAHILM.Add(array[i].environmentsFrontList[k]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].environmentsFrontList[j] is null!");
				}
			}
			for (int l = 0; l < array[i].environmentsLayersList.Count; l++)
			{
				if (null != array[i].environmentsLayersList[l])
				{
					this.FAEEEHDCNDN.Add(array[i].environmentsLayersList[l]);
					if (null != this.sharedLayersFrontPivot && array[i].environmentsLayersList[l].isShared)
					{
						array[i].environmentsLayersList[l].transform.SetParent(this.sharedLayersFrontPivot.transform, false);
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].environmentsFrontList[j] is null!");
				}
			}
			for (int m = 0; m < array[i].storyItemsAssets.Count; m++)
			{
				if (null != array[i].storyItemsAssets[m])
				{
					this.BAFONBJIKLA.Add(array[i].storyItemsAssets[m]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].storyItemsAssets[j] is null!");
				}
			}
			for (int n = 0; n < array[i].storyNpcAssets.Count; n++)
			{
				if (null != array[i].storyNpcAssets[n])
				{
					this.ODNCKIKLFCM.Add(array[i].storyNpcAssets[n]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].storyNpcAssets[j] is null!");
				}
			}
			if (array[i].chapterInk != null)
			{
				this.FJIBKABPIGJ = array[i].chapterInk;
			}
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
	}

	// Token: 0x060047BB RID: 18363 RVA: 0x00208F50 File Offset: 0x00207150
	private void MEBPBAJKLAP(string KHJMANDEDMA)
	{
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(false);
			}
		}
		for (int j = 0; j < this.KEPHFKAHILM.Count; j++)
		{
			if (this.KEPHFKAHILM[j].gameObject.activeSelf)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(false);
			}
		}
		for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[k].OptimizeParticleSystems();
				this.KEPHFKAHILM[k].gameObject.SetActive(true);
				break;
			}
		}
		for (int l = 0; l < this.CHHIBBOICAD.Count; l++)
		{
			if (this.CHHIBBOICAD[l].gameObject.name.Equals(text))
			{
				this.CHHIBBOICAD[l].OptimizeParticleSystems();
				this.CHHIBBOICAD[l].gameObject.SetActive(true);
				return;
			}
		}
		try
		{
			for (int m = 0; m < this.CHHIBBOICAD.Count; m++)
			{
				for (int n = 0; n < this.CHHIBBOICAD[m].mappings.Count; n++)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(text))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Environment " + text + " not found, replacing with " + this.CHHIBBOICAD[m].name);
						text = this.CHHIBBOICAD[m].name;
						for (int num = 0; num < this.CHHIBBOICAD.Count; num++)
						{
							if (this.CHHIBBOICAD[num].gameObject.activeSelf)
							{
								this.CHHIBBOICAD[num].gameObject.SetActive(false);
							}
						}
						for (int num2 = 0; num2 < this.KEPHFKAHILM.Count; num2++)
						{
							if (this.KEPHFKAHILM[num2].gameObject.activeSelf)
							{
								this.KEPHFKAHILM[num2].gameObject.SetActive(false);
							}
						}
						for (int num3 = 0; num3 < this.KEPHFKAHILM.Count; num3++)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(text))
							{
								this.KEPHFKAHILM[num3].OptimizeParticleSystems();
								this.KEPHFKAHILM[num3].gameObject.SetActive(true);
								break;
							}
						}
						for (int num4 = 0; num4 < this.CHHIBBOICAD.Count; num4++)
						{
							if (this.CHHIBBOICAD[num4].gameObject.name.Equals(text))
							{
								this.CHHIBBOICAD[num4].OptimizeParticleSystems();
								this.CHHIBBOICAD[num4].gameObject.SetActive(true);
								return;
							}
						}
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowEnvironment(), environment " + text + " not found.");
		if (!text.Equals("default"))
		{
			this.MEBPBAJKLAP("default");
		}
	}

	// Token: 0x060047BC RID: 18364 RVA: 0x00209320 File Offset: 0x00207520
	private void JCCNMENAHKG(bool NIEJFHHKNGN)
	{
		if (NIEJFHHKNGN && this.KKIGOAKNCIE >= 1)
		{
			return;
		}
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass).ALFGPLALKCN())
		{
			this.KBBPBKJEFCJ();
			this.KKIGOAKNCIE++;
		}
	}

	// Token: 0x060047BD RID: 18365 RVA: 0x00209358 File Offset: 0x00207558
	private void NFCDJBPAFEI()
	{
		if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.CanInteract())
		{
			if (this.storyInterfaceHeaderManager.IsPaused())
			{
				return;
			}
			this.OnSettingsClick();
		}
	}

	// Token: 0x060047BE RID: 18366 RVA: 0x0020938C File Offset: 0x0020758C
	public static bool PremiumChoicePurchased(string EGGMJKBNCJL, bool EFKKHOCLPFD, int NOJPIFONLDG)
	{
		int hagceedcojm = -1;
		try
		{
			hagceedcojm = int.Parse(EGGMJKBNCJL.Substring(1, EGGMJKBNCJL.IndexOf("id") - 1));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PremiumChoicePurchased(1) - Could not parse choice data:" + EGGMJKBNCJL);
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeDiamonds, -1, NOJPIFONLDG) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, hagceedcojm, NOJPIFONLDG))
		{
			return true;
		}
		if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, NOJPIFONLDG) && EFKKHOCLPFD)
		{
			return true;
		}
		for (int i = 0; i < SceneStoryManager.freePremiumChoicesFallback.Count; i++)
		{
			if (SceneStoryManager.freePremiumChoicesFallback[i].Equals(EGGMJKBNCJL))
			{
				return true;
			}
		}
		int num = -1;
		try
		{
			num = int.Parse(EGGMJKBNCJL.Substring(EGGMJKBNCJL.IndexOf("id") + 2));
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PremiumChoicePurchased(2) - Could not parse choice data:" + EGGMJKBNCJL);
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (int.Parse(EGGMJKBNCJL.Substring(1, EGGMJKBNCJL.IndexOf("id") - 1)) != AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		for (int j = 0; j < SceneStoryManager.freePremiumChoices.Count; j++)
		{
			if (SceneStoryManager.freePremiumChoices[j] == num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060047BF RID: 18367 RVA: 0x000FAFD0 File Offset: 0x000F91D0
	private void JDFKJADDMAN()
	{
		Application.Quit();
	}

	// Token: 0x060047C0 RID: 18368 RVA: 0x002094F4 File Offset: 0x002076F4
	private void MCNFLPPFNEE()
	{
		if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.CanInteract())
		{
			if (this.storyInterfaceHeaderManager.IsPaused())
			{
				return;
			}
			this.OnAvatarClick();
		}
	}

	// Token: 0x060047C1 RID: 18369 RVA: 0x00209525 File Offset: 0x00207725
	private void DHJLICMCKEO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.PCOFJMBNBNL("");
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OBFBHGHEADP("");
	}

	// Token: 0x060047C2 RID: 18370 RVA: 0x0020955C File Offset: 0x0020775C
	public void InitTopMatchData()
	{
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.profileDataAsset))
			{
				JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
				if (!(null == jsonarray))
				{
					List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
					this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
					PLFDAJJHMKO gkhnimjjljl = this.GKHNIMJJLJL;
					for (int i = jsonarray.Count - 1; i >= 0; i--)
					{
						JSONObject asObject = jsonarray[i].AsObject;
						int asInt = asObject["ant"].AsInt;
						if (asInt == this.HFFIIBBJBMH.header.index)
						{
							string text = asObject["var"];
							text = text.Replace(" ", "");
							string text2 = asObject["sprite"];
							text2 = text2.Replace(" ", "");
							string text3 = asObject["max"];
							text3 = text3.Replace(" ", "");
							if (text.Length != 0 && text3.Length != 0)
							{
								int asInt2 = asObject["max"].AsInt;
								string text4 = text;
								string text5 = gkhnimjjljl.NCAMFPGMCIG.MPMJOPGMNPB(ref text4);
								try
								{
									IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
									float num = 0f;
									if (text5 != null && text5.Length > 0)
									{
										num = (float)int.Parse(text5);
									}
									float num2 = (float)asInt2;
									immkfhkeebf.BIBKFNMPHIK = (int)(100f * num / num2);
									immkfhkeebf.BIBKFNMPHIK = Math.Clamp(immkfhkeebf.BIBKFNMPHIK, 0, 100);
									immkfhkeebf.ODGNIFJGEHL = text + asInt.ToString();
									immkfhkeebf.PFFCLABCNHI = text2;
									immkfhkeebf.PPACJFFFBFB = 0;
									immkfhkeebf.MJKICDJIFIP = 0;
									immkfhkeebf.OMEEKCMIEJM = i;
									if (asObject["mins"] != null)
									{
										immkfhkeebf.KJNJOOHIBDF = asObject["mins"].AsInt;
									}
									if (asObject["mine"] != null)
									{
										immkfhkeebf.DNOIMFDKCEM = asObject["mine"].AsInt;
									}
									if (asObject["wdb"] != null)
									{
										immkfhkeebf.PDKKPKCAILC = asObject["wdb"].AsInt;
									}
									list.Add(immkfhkeebf);
								}
								catch (Exception aklgbjkdomm)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
								}
							}
						}
					}
					int num3 = 0;
					while (list.Count > 0)
					{
						int num4 = -1;
						int num5 = -1;
						for (int j = 0; j < list.Count; j++)
						{
							if (list[j].BIBKFNMPHIK > num4)
							{
								num4 = list[j].BIBKFNMPHIK;
								num5 = j;
							}
						}
						if (num5 >= 0)
						{
							this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Add(list[num5]);
							list.RemoveAt(num5);
						}
						num3++;
						if (num3 > 100000)
						{
							break;
						}
					}
					DPGJIJGOCIC.NFIDPOMCNLP("InitTopMatchData(): total while iterations:" + num3.ToString());
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x060047C3 RID: 18371 RVA: 0x002098BC File Offset: 0x00207ABC
	public static List<int> ParseWardrobeMixOverride(string CPAGLIHICLH)
	{
		if (CPAGLIHICLH == null || CPAGLIHICLH.Length == 0)
		{
			return null;
		}
		List<int> list = null;
		string[] array = CPAGLIHICLH.Split(',', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			int num = -1;
			if (int.TryParse(array[i].Trim(), out num) && num >= 0)
			{
				if (list == null)
				{
					list = new List<int>();
				}
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x060047C4 RID: 18372 RVA: 0x00003E52 File Offset: 0x00002052
	private void GGCGIOMBLKM()
	{
	}

	// Token: 0x060047C5 RID: 18373 RVA: 0x00209918 File Offset: 0x00207B18
	private string CIEJIFJDIKE(string PDEADFPONFH)
	{
		string result;
		try
		{
			if (PDEADFPONFH == null || PDEADFPONFH.Length == 0)
			{
				result = PDEADFPONFH;
			}
			else
			{
				string text = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MEHLFOPAOBP(PDEADFPONFH);
				if (text == null || text.Length == 0 || text.Equals(PDEADFPONFH))
				{
					result = PDEADFPONFH;
				}
				else if (null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
				{
					result = PDEADFPONFH;
				}
				else
				{
					result = text;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = PDEADFPONFH;
		}
		return result;
	}

	// Token: 0x060047C6 RID: 18374 RVA: 0x00209998 File Offset: 0x00207B98
	private void JLPFFPDJALD()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.HMOKDIODADD), new UnityAction(this.BIMHNCJHLBO), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x060047C7 RID: 18375 RVA: 0x00209A24 File Offset: 0x00207C24
	private bool PKECMBKMKGN()
	{
		int num;
		if (PlayerPrefs.HasKey("envlsav"))
		{
			num = PlayerPrefs.GetInt(" not found.");
		}
		else
		{
			num = 1;
		}
		return num == 0 && NBDLBFJOEGN.LHBMEFGCPHK();
	}

	// Token: 0x060047C8 RID: 18376 RVA: 0x00205B40 File Offset: 0x00203D40
	private void DLEEDDKFNDL()
	{
		base.StartCoroutine(this.EIJIIEBPOFE(false, true));
	}

	// Token: 0x060047C9 RID: 18377 RVA: 0x00209A5C File Offset: 0x00207C5C
	private void IFKIKHPKFLC(PLFDAJJHMKO AEIBIFJBKFP, List<string> GOAKEHAFJMC)
	{
		for (int i = 0; i < GOAKEHAFJMC.Count; i++)
		{
			string text = GOAKEHAFJMC[i];
			string text2 = AEIBIFJBKFP.NCAMFPGMCIG.MPMJOPGMNPB(ref text);
			if (text2 != null)
			{
				if (text.ToLower().EndsWith(LFOLOKPIPHB._bool.ToString()))
				{
					if (ONEHEBIHPFB.POLPJMIBJNN(text.Substring(0, text.IndexOf(LFOLOKPIPHB._bool.ToString()))))
					{
						if (text2.Equals("1"))
						{
							ONEHEBIHPFB.PAOFLKEKLMA(text.Substring(0, text.IndexOf(LFOLOKPIPHB._bool.ToString())), true);
						}
						else
						{
							ONEHEBIHPFB.PAOFLKEKLMA(text.Substring(0, text.IndexOf(LFOLOKPIPHB._bool.ToString())), false);
						}
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Warning. Import variable not found in ink file:" + text);
					}
				}
				else if (text.ToLower().EndsWith(LFOLOKPIPHB._int.ToString()))
				{
					if (ONEHEBIHPFB.POLPJMIBJNN(text.Substring(0, text.IndexOf(LFOLOKPIPHB._int.ToString()))))
					{
						ONEHEBIHPFB.PAOFLKEKLMA(text.Substring(0, text.IndexOf(LFOLOKPIPHB._int.ToString())), Convert.ToInt32(text2));
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Warning. Import variable not found in ink file:" + text);
					}
				}
				else if (text.ToLower().EndsWith(LFOLOKPIPHB._string.ToString()))
				{
					if (ONEHEBIHPFB.POLPJMIBJNN(text.Substring(0, text.IndexOf(LFOLOKPIPHB._string.ToString()))))
					{
						ONEHEBIHPFB.PAOFLKEKLMA(text.Substring(0, text.IndexOf(LFOLOKPIPHB._string.ToString())), text2);
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Warning. Import variable not found in ink file:" + text);
					}
				}
				else if (text.ToLower().EndsWith(LFOLOKPIPHB._list.ToString()))
				{
					if (ONEHEBIHPFB.POLPJMIBJNN(text.Substring(0, text.IndexOf(LFOLOKPIPHB._list.ToString()))))
					{
						ONEHEBIHPFB.HFEEFOJDNPL(text.Substring(0, text.IndexOf(LFOLOKPIPHB._list.ToString())), text2);
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Warning. Import variable not found in ink file:" + text);
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. Unknown import variable type:" + text);
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Warning. Import variable not found in save data:" + text + ". This is not critical.");
			}
		}
	}

	// Token: 0x060047CA RID: 18378 RVA: 0x00209CE8 File Offset: 0x00207EE8
	private void EIBAHCAEHDL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (SceneStoryManager.premiumChoiceManInTheMiddleAttack == 1)
		{
			this.GKHNIMJJLJL.PFHCDMOJOKP();
			return;
		}
		if (SceneStoryManager.premiumChoiceBackendOperationResultKey.Length > 0)
		{
			this.BLKHLBHOFBJ();
			return;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		string text;
		if (kioojmglclc != null)
		{
			if (kioojmglclc.ALFGPLALKCN())
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passnotmoreundos2");
				text = text.Replace("XXX", DPGJIJGOCIC.LCOMEDGJNMP(kioojmglclc.FHHLFACIIDF(), false, true));
			}
			else
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passnotmoreundos3");
			}
		}
		else
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passnotmoreundos");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x00209DC0 File Offset: 0x00207FC0
	private void MHPPFDJGNHF()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (kioojmglclc == null || !kioojmglclc.ALFGPLALKCN())
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subUndo);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passundochoicetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passundosubrequired"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (this.GKHNIMJJLJL.HPNLAJDDAFE())
		{
			string str = "short";
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(50))
			{
				str = "";
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(50);
			}
			else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(51))
			{
				str = "";
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(51);
			}
			else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(52))
			{
				str = "";
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(52);
			}
			string text;
			if (this.GKHNIMJJLJL.DHONIOBOLEL.CDDKCMPAHMG > 0)
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passundobodymsgpaid" + str);
			}
			else if (this.GKHNIMJJLJL.DHONIOBOLEL.FGOHPIBCCHB > 0)
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passundobodymsgpaid2" + str);
			}
			else
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passundobodymsgfree" + str);
			}
			text = text.Replace("XXX", this.GKHNIMJJLJL.DHONIOBOLEL.CDDKCMPAHMG.ToString() + KBOJLHAJPCP.BGMADCKNKAD);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passundochoicetitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.HALIFDCOJJF), new UnityAction(this.HEMEDGIGOMK), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x00209FC0 File Offset: 0x002081C0
	private IEnumerator EJAAMGDGIEB()
	{
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		if (this.LHBMEFGCPHK() && null != this.imageEffects)
		{
			this.imageEffects.ShowAllEffectsWithTag("blur");
		}
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.BIMHNCJHLBO();
		yield break;
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x00209FCF File Offset: 0x002081CF
	private void EGNAHFEGEJM()
	{
		this.MCIGJBFKOIJ = true;
		base.StartCoroutine(this.IEJEKBFECKP());
	}

	// Token: 0x060047CE RID: 18382 RVA: 0x00209FE8 File Offset: 0x002081E8
	private void FKFFMIDEDCF()
	{
		try
		{
			List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
			for (int i = 0; i < this.PKPMIABFBON.Count; i++)
			{
				if (this.PKPMIABFBON[i] != null && !(null == this.PKPMIABFBON[i].IACFDHCDEME))
				{
					NonPlayerCharacterManager component = this.PKPMIABFBON[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
					if (!(null == component))
					{
						FEMKDIHKJCM lastDialogStep = component.GetLastDialogStep();
						if (lastDialogStep != null && lastDialogStep.IHCMBIBJBJD != null)
						{
							string text = this.PDPBHJFFFDD(lastDialogStep.IHCMBIBJBJD);
							if (text != null && (!component.IsEqual(text, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ()) || component.EffectiveLoungePropsChanged()) && (component.GetNpcId() == null || !component.GetNpcId().Equals(text) || component.EffectiveLoungePropsChanged()) && !component.FadedOutByStep() && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FELDBGLLPBL(text) == null && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FELDBGLLPBL(component.GetNpcId()) == null && !(null == GKJPOGNFKNK.IAJMHBFGKBA(text, "")))
							{
								list.Add(this.PKPMIABFBON[i]);
							}
						}
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				this.NILCOMEBIJN(list[j]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060047CF RID: 18383 RVA: 0x001FDC18 File Offset: 0x001FBE18
	private IEnumerator KBBKEFGDGPO(float LJLHCJFDNGL)
	{
		yield return new WaitForSeconds(LJLHCJFDNGL);
		this.KBBPBKJEFCJ();
		yield break;
	}

	// Token: 0x060047D0 RID: 18384 RVA: 0x0020A18C File Offset: 0x0020838C
	public void OnStoryCurrencyInfoClickPart2()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.PauseEvents();
		}
		this.ALGIAIKDEPH();
		this.OKKBOFKILEA();
		this.JCNICMFKAOL();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(false);
		if (this.MOCHJHMLGBG())
		{
			this.ACJLMIELCME();
		}
		ApplicationFocusManager.Activate();
	}

	// Token: 0x060047D1 RID: 18385 RVA: 0x0020A1F7 File Offset: 0x002083F7
	private IEnumerator HMJEMANMJOA()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Normal);
		this.LHGNMIOGHGJ = 0f;
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnOnDemandResourcesDownloadSuccess", "OnOnDemandResourcesDownloadFailed", false);
		yield break;
	}

	// Token: 0x060047D2 RID: 18386 RVA: 0x0020A206 File Offset: 0x00208406
	private void KFFKDDGBLBD()
	{
		this.OILFDHGPCOB();
	}

	// Token: 0x060047D3 RID: 18387 RVA: 0x0020A210 File Offset: 0x00208410
	private static void OMOGKJCMCKF(string PDEADFPONFH)
	{
		try
		{
			if (PDEADFPONFH != null && PDEADFPONFH.Length != 0)
			{
				string text = PDEADFPONFH;
				if (text.Contains(" "))
				{
					text = text.Substring(0, text.IndexOf(" "));
				}
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.NCAMFPGMCIG.KPOLFHBLLII(text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060047D4 RID: 18388 RVA: 0x0020A284 File Offset: 0x00208484
	private void COJKOKBNOHM()
	{
		if (this.HODJEPIPDFH == 0 && this.NJAAOCMPKCD.index % 0 == 0)
		{
			this.CHDPABJGOOC();
			return;
		}
		SceneStoryManager.consumeEnergyBackendOperationResult = -1;
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-108);
		BackendOperationsManager.EHBBFMCILPC.CFPGDIAGJFA("grayscale", " could not be loaded", AKLFPGMDKLA.ACFJMCBMOFG(this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index)), this.HODJEPIPDFH, this.HFFIIBBJBMH.header.index);
	}

	// Token: 0x060047D5 RID: 18389 RVA: 0x0020A310 File Offset: 0x00208510
	private bool FIICDGAOKDH()
	{
		try
		{
			if (SceneStoryManager.loungePremiumChoicesHistoryState == 2)
			{
				return false;
			}
			FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(StoryInterfaceHeaderManager.anthologyIndex);
			if (fjlgcknojmj == null)
			{
				return false;
			}
			for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
			{
				if (SceneStoryManager.CHPFNHINCOG(fjlgcknojmj.OINAAMKLNLO[i]))
				{
					for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
					{
						int pbgkgchmhop = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].PBGKGCHMHOP;
						if (pbgkgchmhop > 0 && pbgkgchmhop != AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI)
						{
							return true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060047D6 RID: 18390 RVA: 0x0020A3F8 File Offset: 0x002085F8
	private GameObject LDLPKDIFOAD(string KHJMANDEDMA)
	{
		string value = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.name.Equals(value))
			{
				return this.CHHIBBOICAD[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x060047D7 RID: 18391 RVA: 0x0020A460 File Offset: 0x00208660
	private GameObject OBGGHPHGPIO(string KHJMANDEDMA)
	{
		string value = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(value))
			{
				return this.KEPHFKAHILM[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x060047D8 RID: 18392 RVA: 0x0020A4C6 File Offset: 0x002086C6
	private void IOIGJPJIBEL()
	{
		this.BODLAMJCHJO = false;
		this.ILJAFHPEKDC = true;
		this.FNDBICLIGKO();
	}

	// Token: 0x060047D9 RID: 18393 RVA: 0x0020A4DC File Offset: 0x002086DC
	private void PBFBEEGCFHF()
	{
		if (this.LDAPOBMECNI == 0 && this.CMBLMOJFGAE.Count == 0 && this.LLEHEBBHAOD.Count == 0 && this.playerCharacterOffscreenRenderCamera.gameObject.activeSelf)
		{
			this.playerCharacterOffscreenRenderCamera.gameObject.SetActive(false);
			this.playerCharacterRenderTextureCanvas.enabled = false;
		}
	}

	// Token: 0x060047DA RID: 18394 RVA: 0x0020A53C File Offset: 0x0020873C
	private void ICJLNPJOIHP(int GMLIEKDKEAG)
	{
		if (this.preWarmFader.gameObject.activeSelf && !this.preWarmFader.IsBusy())
		{
			this.preWarmFader.FadeOut(null);
		}
		this.HJKLOODDLDE(100);
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NIBNMKJIMAD = 1;
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK = this.GOPGELMBMMK.IMBBIDKPOBM;
		JCAJMGJFHBD jcajmgjfhbd = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BPONDPKBEPN(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK, this.GOPGELMBMMK.FPHDAKHOBMO);
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.storyChatPrefab);
		gameObject.transform.SetParent(this.itemFoundDialogPivot.transform, false);
		if (this.HPAEFOJDLFC.BPNGIDAMBEJ)
		{
			gameObject.transform.GetComponent<RectTransform>().AHLJBONHHKL(4096, 4096);
		}
		gameObject.GetComponent<StoryChatManager>().Initialize(jcajmgjfhbd.OGPCOFKKDLA(), this.HPAEFOJDLFC, this.GKHNIMJJLJL);
		if (GMLIEKDKEAG == 0)
		{
			gameObject.GetComponent<StoryChatManager>().AppearAnimation0();
		}
		else
		{
			gameObject.GetComponent<StoryChatManager>().AppearAnimation1();
			if (null != this.storyInterfaceHeaderManager)
			{
				this.storyInterfaceHeaderManager.Hide();
			}
		}
		this.BOALOCEGFOO.Add(this.GLDAJFNCFKC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNOFDJKKPMK, gameObject));
		if (this.LHBMEFGCPHK() && null != this.imageEffects && !this.HPAEFOJDLFC.BPNGIDAMBEJ)
		{
			this.imageEffects.ShowAllEffectsWithTag("blur");
		}
	}

	// Token: 0x060047DB RID: 18395 RVA: 0x0020A6DE File Offset: 0x002088DE
	private static bool CHPFNHINCOG(DMDNKJKEPKO CMENACFAEGD)
	{
		return SceneStoryManager.LoungeCharacterInActiveWardrobe(CMENACFAEGD, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x0020A6F0 File Offset: 0x002088F0
	private IEnumerator GBKPAADANKO(float LNAOAHMAJKN)
	{
		yield return new WaitForSeconds(LNAOAHMAJKN);
		yield break;
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x0020A6FF File Offset: 0x002088FF
	private void AIGBJLAPFLH()
	{
		AudioManager.EHBBFMCILPC.ResumeAll();
	}

	// Token: 0x060047DE RID: 18398 RVA: 0x0020A70C File Offset: 0x0020890C
	private void IKOEGDKKEBF()
	{
		if (this.HFOPCMIHDOL.LOFLEEKGFJH() == null)
		{
			return;
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		if (this.HFOPCMIHDOL.LOFLEEKGFJH().PINCOCDOOGH())
		{
			this.HFOPCMIHDOL.LOFLEEKGFJH().FEHODJMIAJL(0f, 1);
		}
	}

	// Token: 0x060047DF RID: 18399 RVA: 0x001FED70 File Offset: 0x001FCF70
	private IEnumerator EDMPMIMIFED(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		this.LDAPOBMECNI++;
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().AnimateDisappearance(BKBCKPMDFOD.animationStoryDisappearToLeft, false);
		}
		yield return new WaitForSeconds(PlayerCharacterManager.GetAnimationDisappearTime());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		this.LDAPOBMECNI--;
		yield return null;
		yield break;
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x0020A770 File Offset: 0x00208970
	private void HDCPBLICGNA()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		List<AssetStoryNpc> list = new List<AssetStoryNpc>();
		for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
		{
			if (this.ODNCKIKLFCM[i].KBDAEIHELPE() != 900000)
			{
				list.Add(this.ODNCKIKLFCM[i]);
			}
			else
			{
				num++;
				DPGJIJGOCIC.ADFCDFHBDAF("Npc id has been destroyed according to lounge data:" + this.ODNCKIKLFCM[i].id);
			}
		}
		this.ODNCKIKLFCM.Clear();
		this.ODNCKIKLFCM = list;
		List<StoryEnvironmentManager> list2 = new List<StoryEnvironmentManager>();
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].GetOnDemandResourcesCheckpointIndex() != 900000)
			{
				list2.Add(this.CHHIBBOICAD[j]);
			}
			else
			{
				num2++;
				this.CHHIBBOICAD[j].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.CHHIBBOICAD[j].gameObject);
				DPGJIJGOCIC.ADFCDFHBDAF("Back environment has been destroyed according to lounge data:" + this.CHHIBBOICAD[j].name);
			}
		}
		this.CHHIBBOICAD.Clear();
		this.CHHIBBOICAD = list2;
		List<StoryEnvironmentManager> list3 = new List<StoryEnvironmentManager>();
		for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].GetOnDemandResourcesCheckpointIndex() != 900000)
			{
				list3.Add(this.KEPHFKAHILM[k]);
			}
			else
			{
				num3++;
				this.KEPHFKAHILM[k].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.KEPHFKAHILM[k].gameObject);
				DPGJIJGOCIC.ADFCDFHBDAF("Front environment has been destroyed according to lounge data:" + this.KEPHFKAHILM[k].name);
			}
		}
		this.KEPHFKAHILM.Clear();
		this.KEPHFKAHILM = list3;
		List<StoryEnvironmentLayerManager> list4 = new List<StoryEnvironmentLayerManager>();
		for (int l = 0; l < this.FAEEEHDCNDN.Count; l++)
		{
			if (this.FAEEEHDCNDN[l].GetOnDemandResourcesCheckpointIndex() != 900000)
			{
				list4.Add(this.FAEEEHDCNDN[l]);
			}
			else
			{
				num4++;
				DPGJIJGOCIC.ADFCDFHBDAF("Environment layer has been destroyed according to lounge data:" + this.FAEEEHDCNDN[l].name);
			}
		}
		this.FAEEEHDCNDN.Clear();
		this.FAEEEHDCNDN = list4;
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x0020AA1C File Offset: 0x00208C1C
	private void ACINBDPEDJN(PLFDAJJHMKO AEIBIFJBKFP, List<string> GOAKEHAFJMC)
	{
		for (int i = 0; i < GOAKEHAFJMC.Count; i++)
		{
			string text = GOAKEHAFJMC[i];
			string text2 = AEIBIFJBKFP.NCAMFPGMCIG.JLANBLCOLNI(ref text);
			if (text2 != null)
			{
				if (text.ToLower().EndsWith(((LFOLOKPIPHB)7).ToString()))
				{
					if (ONEHEBIHPFB.JAKGIPODLDB(text.Substring(1, text.IndexOf(LFOLOKPIPHB._list.ToString()))))
					{
						if (text2.Equals("OnStorySplashManagerAssetsDownloadFailed"))
						{
							ONEHEBIHPFB.PEFHMIECDFN(text.Substring(1, text.IndexOf(((LFOLOKPIPHB)5).ToString())), false);
						}
						else
						{
							ONEHEBIHPFB.JKJDAMAOCKO(text.Substring(1, text.IndexOf(((LFOLOKPIPHB)7).ToString())), true);
						}
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC(", but an anthology asset was not loaded for this story, falling back to lobby loading." + text);
					}
				}
				else if (text.ToLower().EndsWith(LFOLOKPIPHB._string.ToString()))
				{
					if (ONEHEBIHPFB.JBFGFINPNKH(text.Substring(0, text.IndexOf(LFOLOKPIPHB._string.ToString()))))
					{
						ONEHEBIHPFB.IPINPJBNLHA(text.Substring(1, text.IndexOf(LFOLOKPIPHB._int.ToString())), Convert.ToInt32(text2));
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("<i>" + text);
					}
				}
				else if (text.ToLower().EndsWith(LFOLOKPIPHB._int.ToString()))
				{
					if (ONEHEBIHPFB.HKMBHNFKMFM(text.Substring(1, text.IndexOf(LFOLOKPIPHB._string.ToString()))))
					{
						ONEHEBIHPFB.HADIPJOPIFJ(text.Substring(1, text.IndexOf(LFOLOKPIPHB._int.ToString())), text2);
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC(") + is present, creating anthology save for anthology " + text);
					}
				}
				else if (text.ToLower().EndsWith(LFOLOKPIPHB.count.ToString()))
				{
					if (ONEHEBIHPFB.BBNNGKDEMLN(text.Substring(0, text.IndexOf(((LFOLOKPIPHB)7).ToString()))))
					{
						ONEHEBIHPFB.LBOFDEABJPO(text.Substring(1, text.IndexOf(LFOLOKPIPHB.count.ToString())), text2);
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("SocialStatsUserPublicProfile.modified = false, OnPopupProfileUIDInputEndEdit()" + text);
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("</Modulus></RSAKeyValue>" + text);
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok" + text + "There needs to be one active GooglePlayServicesManager script on a GameObject in your scene.");
			}
		}
	}

	// Token: 0x060047E2 RID: 18402 RVA: 0x0020ACA8 File Offset: 0x00208EA8
	private int ACDAJNPBBNG(ECAPOEGMMIB DCEEBNNKPGJ)
	{
		try
		{
			if (DCEEBNNKPGJ.KPPJINFHMIP == null || DCEEBNNKPGJ.KPPJINFHMIP.Length == 0)
			{
				return 0;
			}
			if (DCEEBNNKPGJ.IHMEFMPMDFC <= 0)
			{
				return 0;
			}
			if (!NBDLBFJOEGN.NDFLNHIAKJH() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB())
			{
				return 0;
			}
			if (null == this.HFFIIBBJBMH || !this.HFFIIBBJBMH.header.availableStories.Contains(DCEEBNNKPGJ.IHMEFMPMDFC))
			{
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[Lounge] wardrobe music pack mps:",
					DCEEBNNKPGJ.IHMEFMPMDFC.ToString(),
					" is OUTSIDE the anthology's story family - not queued (clip:",
					DCEEBNNKPGJ.KPPJINFHMIP,
					")"
				}));
				return 0;
			}
			if (AudioManager.EHBBFMCILPC.AudioClipAvailable(CCEMAFOMLLK.music, DCEEBNNKPGJ.KPPJINFHMIP))
			{
				return 0;
			}
			string item = "abs" + DCEEBNNKPGJ.IHMEFMPMDFC.ToString() + "asp" + DCEEBNNKPGJ.OAMJJIFAAHJ.ToString();
			if (this.KEPLJDAONLC.Contains(item))
			{
				return 0;
			}
			this.KEPLJDAONLC.Add(item);
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, DCEEBNNKPGJ.IHMEFMPMDFC, DCEEBNNKPGJ.OAMJJIFAAHJ, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, 900000, false, "", false, false);
			return 1;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 0;
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x0020AE1C File Offset: 0x0020901C
	private float MEEKOPBHLDB(string KHJMANDEDMA, PHALBCMBPPL OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		string text = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(text))
			{
				this.KEPHFKAHILM[i].SetPositionVertical(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(text))
			{
				return this.CHHIBBOICAD[j].SetPositionVertical(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. MoveEnvironmentVertical(), environment " + text + " not found.");
		return 0f;
	}

	// Token: 0x060047E4 RID: 18404 RVA: 0x001FD873 File Offset: 0x001FBA73
	private bool MDCKOPJGOMO(ECJCFGAOPHJ FFACCDIEBIA)
	{
		return SceneStoryManager.LoungeMappingIsEligible(FFACCDIEBIA, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP(), null, SceneStoryManager.PNKPJFHFGHJ);
	}

	// Token: 0x060047E5 RID: 18405 RVA: 0x0020AEEC File Offset: 0x002090EC
	private static void IBNPEHNMGJB()
	{
		try
		{
			if (!SceneLoungeManager.HasPendingLoungeCharacter())
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null)
				{
					string text = plfdajjhmko.NCAMFPGMCIG.HJKMONKHGNK();
					if (text.Length != 0)
					{
						DMDNKJKEPKO dmdnkjkepko = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().EDFEBMGAGOE(text);
						if (dmdnkjkepko != null)
						{
							SceneLoungeManager.SetPendingLoungeCharacter(dmdnkjkepko.KALBADOPCDN);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060047E6 RID: 18406 RVA: 0x0020AF68 File Offset: 0x00209168
	private void BNLOHKAPOAH()
	{
		string lfmcdfbankd = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		base.StartCoroutine(this.MDNEDHHGBCO(lfmcdfbankd, true));
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x0020AF8F File Offset: 0x0020918F
	private void FACKGDFNJJD()
	{
		this.LPCBDEBKAIM();
	}

	// Token: 0x060047E8 RID: 18408 RVA: 0x0020AF98 File Offset: 0x00209198
	private void OKAECILDDIK()
	{
		if (this.NJEPIPLACPC == null || null == this.GFIFDKBLLBL || this.GKHNIMJJLJL == null)
		{
			return;
		}
		try
		{
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < this.NJEPIPLACPC.Count; i++)
			{
				if (ONEHEBIHPFB.GJBMBHGKNHN(this.NJEPIPLACPC[i]))
				{
					list.Add(this.NJEPIPLACPC[i]);
					list2.Add(ONEHEBIHPFB.HPFKIKJIGNF(this.NJEPIPLACPC[i]));
				}
			}
			this.GKHNIMJJLJL.NCAMFPGMCIG.OJHGKJECIBK(Math.Max(0, this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0]), list, list2, this.EPAIPMEJOJB());
			this.GKHNIMJJLJL.NCAMFPGMCIG.CMNFNOLANGL(this.CJJHMPCBGOM(false));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060047E9 RID: 18409 RVA: 0x0020B084 File Offset: 0x00209284
	private IEnumerator DLGCDPAFEOB(string HPHFJNKGPBB, string CHFOGPKMBDD)
	{
		if (HPHFJNKGPBB != null && HPHFJNKGPBB.Length > 0)
		{
			this.OKIHENOGDKD(HPHFJNKGPBB, 0f, 1f, 1f, true, false);
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.MFCIIAJJMOB(HPHFJNKGPBB, true);
		}
		if (CHFOGPKMBDD != null && CHFOGPKMBDD.Length > 0)
		{
			this.OKIHENOGDKD(CHFOGPKMBDD, 1f, 0f, 1f, false, false);
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NBCACCKOABP(CHFOGPKMBDD, true);
		}
		yield return new WaitForSeconds(1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryScreenChoiceExtendedManagerLayerChangeComplete", 0f);
		yield break;
	}

	// Token: 0x060047EA RID: 18410 RVA: 0x0020B0A4 File Offset: 0x002092A4
	private void GJCPKOIJAFK(FGINKFGNNEK JKJMDNFAFBB, string KCOMIMHDJJP)
	{
		NonPlayerCharacterManager component = JKJMDNFAFBB.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
		string dbhmnecmiab = JKJMDNFAFBB.DBHMNECMIAB;
		FLNOFHCNJDM lastEmotionRequested = component.GetLastEmotionRequested();
		FLNOFHCNJDM lastDelayedDefaultEmotionRequested = component.GetLastDelayedDefaultEmotionRequested();
		this.PromoteLoungeNpcAssetToChapterLifetime(KCOMIMHDJJP);
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		list.Add(JKJMDNFAFBB);
		this.CMBLMOJFGAE.Remove(JKJMDNFAFBB);
		component.HideAtOnce();
		GameObject gameObject = null;
		try
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterRenderTexturePrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
			gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(-1f, 1f, 1f);
			gameObject.transform.SetParent(this.playerCharacterPivot.transform, false);
			int num = -1;
			for (int i = 0; i < this.LLEHEBBHAOD.Count; i++)
			{
				if (this.LLEHEBBHAOD[i] != null && !(null == this.LLEHEBBHAOD[i].IACFDHCDEME) && !(this.LLEHEBBHAOD[i].IACFDHCDEME.transform.parent != this.playerCharacterPivot.transform))
				{
					num = this.LLEHEBBHAOD[i].IACFDHCDEME.transform.GetSiblingIndex();
					if (this.LLEHEBBHAOD[i].DBHMNECMIAB != null && this.LLEHEBBHAOD[i].DBHMNECMIAB.Equals(dbhmnecmiab))
					{
						break;
					}
				}
			}
			if (num >= 0)
			{
				gameObject.transform.SetSiblingIndex(num);
			}
			else
			{
				gameObject.transform.SetAsFirstSibling();
			}
			NonPlayerCharacterManager component2 = gameObject.GetComponent<NonPlayerCharacterManager>();
			component2.Initialize(KCOMIMHDJJP, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.left, false);
			SceneStoryManager.OMOGKJCMCKF(KCOMIMHDJJP);
			component2.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromLeft);
			component2.SetEmotion(lastEmotionRequested, BIDPEOLOIIG.appearDelayed, lastDelayedDefaultEmotionRequested);
			component2.RecordLineEmotion(lastEmotionRequested, lastDelayedDefaultEmotionRequested);
			component2.DisableFadeOnAppearAndDisappar();
			this.CMBLMOJFGAE.Add(this.GLDAJFNCFKC(dbhmnecmiab, gameObject));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != gameObject)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		base.StartCoroutine(this.JHDEBFCKKJA(list));
		LPEMDECEIAO.EIGLJFIOJPE(KCOMIMHDJJP);
	}

	// Token: 0x060047EB RID: 18411 RVA: 0x0020B2DC File Offset: 0x002094DC
	private void OCIAMGMLMLG()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("notifposteffects"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x060047EC RID: 18412 RVA: 0x0020B32C File Offset: 0x0020952C
	public void CCDLDDJGEAB()
	{
		if (this.MCIGJBFKOIJ)
		{
			return;
		}
		this.MCIGJBFKOIJ = false;
		this.MBBFJHBFPNB = false;
		this.EPHFGFGLFNP();
		AudioManager.APGODIBBPOD().FadeMusic(1211f, 121f);
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("[LoadingEnv] skipped, stored theme parked", CommonUserInterface.IKNOFBFMPGA().GetFader().KGPNPLBKBDA());
		AudioManager.DMAAFFFEJGA().GKPNAOJJEHG("OnGooglePlayServicesLoginFailed", CommonUserInterface.IKNOFBFMPGA().GetFader().GKLEDGCKENH());
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.OnBackClickPart2));
		if (!EEIBKLDNBAP.ALFGPLALKCN())
		{
			BackendOperationsManager.NPDDBAONMJP().RequestLoadDefaultBundles("p", "OnNeedToShowConnectingAnimation", false);
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		AdsManagerLP.OHCOHPNEOEG().CLKOIPPIMGP();
		ApplicationFocusManager.Deactivate();
	}

	// Token: 0x060047ED RID: 18413 RVA: 0x0020B406 File Offset: 0x00209606
	private void CMDIKMNEGEN()
	{
		this.DCFBAMCJCFK = 0;
		this.OBPPPNCALNP = 0;
		this.FJIAGECENLF = 0;
		this.NHDMFANLHPE = 0;
	}

	// Token: 0x060047EE RID: 18414 RVA: 0x0020B424 File Offset: 0x00209624
	private void BHKOKKMDLAM()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		AssetsManager.EHBBFMCILPC.ResetForceNoParallelLoadOperations();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.AMBEPJCICOF();
		base.StartCoroutine(this.GIOKPEDGHLA());
	}

	// Token: 0x060047EF RID: 18415 RVA: 0x0020B45C File Offset: 0x0020965C
	private LDLLJFOJCDF[] GHGFGDHNNHG()
	{
		LDLLJFOJCDF[] array = null;
		int num = 0;
		try
		{
			for (int i = 0; i < this.HFFIIBBJBMH.header.inkStatVariables.Count; i++)
			{
				if (i >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory.Count || i >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter.Count || (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory[i] && (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI != this.HFFIIBBJBMH.header.inkStatVariablesMinStory[i] || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter[i])))
				{
					num++;
				}
			}
			if (num <= 0)
			{
				num = 1;
			}
			array = new LDLLJFOJCDF[num];
			int num2 = 0;
			for (int j = 0; j < this.HFFIIBBJBMH.header.inkStatVariables.Count; j++)
			{
				if ((j >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory.Count || j >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter.Count || (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI >= this.HFFIIBBJBMH.header.inkStatVariablesMinStory[j] && (this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI != this.HFFIIBBJBMH.header.inkStatVariablesMinStory[j] || this.GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] >= this.HFFIIBBJBMH.header.inkStatVariablesMinChapter[j]))) && num2 < array.Length)
				{
					array[num2] = new LDLLJFOJCDF();
					if (ONEHEBIHPFB.POLPJMIBJNN(this.HFFIIBBJBMH.header.inkStatVariables[j]))
					{
						array[num2].EKDHFAODNHF(ONEHEBIHPFB.HPFKIKJIGNF(this.HFFIIBBJBMH.header.inkStatVariables[j]));
					}
					else
					{
						array[num2].EKDHFAODNHF(this.HFFIIBBJBMH.header.inkStatVariablesDefaultValues[j]);
					}
					num2++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			array = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return array;
	}

	// Token: 0x060047F0 RID: 18416 RVA: 0x0020B6D4 File Offset: 0x002098D4
	public void OnAvatarClickPart2()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.PauseEvents();
		}
		this.ALGIAIKDEPH();
		this.JCNICMFKAOL();
		if (this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK() == null)
		{
			if (this.MOCHJHMLGBG())
			{
				this.ACJLMIELCME();
			}
			this.OKKBOFKILEA();
			AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0).Show(null, null, null, null, null, true, false, true, false);
		}
		else if (null == this.LDLPKDIFOAD(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().FLPGNPNHJNK))
		{
			AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0).Show(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().NENOCECJMIJ, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().PILOOLIIPBN, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().BHKEBHFKFNG, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().IMBPFPKLLCK, this.LDLPKDIFOAD(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().FLPGNPNHJNK), false, true, false, false);
		}
		else if (this.LHBMEFGCPHK() && null != this.imageEffects)
		{
			this.imageEffects.ShowAllEffectsWithTag("blur");
			AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0).Show(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().NENOCECJMIJ, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().PILOOLIIPBN, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().BHKEBHFKFNG, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().IMBPFPKLLCK, this.LDLPKDIFOAD(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().FLPGNPNHJNK), false, true, false, false);
		}
		else
		{
			AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0).Show(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().NENOCECJMIJ, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().PILOOLIIPBN, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().BHKEBHFKFNG, this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().IMBPFPKLLCK, this.LDLPKDIFOAD(this.HFOPCMIHDOL.HJOANJHIHAI().LFKJLOOLLEK().FLPGNPNHJNK), false, true, false, true);
		}
		AudioManager.EHBBFMCILPC.FadeMusic(1f, 1f);
	}

	// Token: 0x060047F1 RID: 18417 RVA: 0x0020B944 File Offset: 0x00209B44
	private void PMDLNBNBMKP()
	{
		try
		{
			if (this.IFLGCDMCEGD.Length > 0)
			{
				this.PEGKFFIEEEF = this.IFLGCDMCEGD.IndexOf("importanttitle");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (this.PEGKFFIEEEF <= 0)
		{
			this.PEGKFFIEEEF = -1;
		}
	}

	// Token: 0x060047F2 RID: 18418 RVA: 0x0020B9A0 File Offset: 0x00209BA0
	public void ReleaseSuperMappedLookNpcAnimationPacks(string FBKAPCPPNKA)
	{
		try
		{
			if (FBKAPCPPNKA != null && FBKAPCPPNKA.Length != 0)
			{
				ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DCPPCOHEAFA(FBKAPCPPNKA);
				if (ecjcfgaophj != null)
				{
					for (int i = 0; i < ecjcfgaophj.APDJNDIIILK.Count; i++)
					{
						if (!this.GCMPNMKDFAD(ecjcfgaophj.APDJNDIIILK[i], false))
						{
							AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, ecjcfgaophj.APDJNDIIILK[i]);
							this.PCGFKFFPODD.Remove(ecjcfgaophj.APDJNDIIILK[i]);
							this.AHKDFKBDBJG.Remove(ecjcfgaophj.APDJNDIIILK[i]);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x0020BA64 File Offset: 0x00209C64
	private void JIGOKCCEANC()
	{
		if (this.HFOPCMIHDOL.HMBGGHGFNBD() == null)
		{
			return;
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		if (this.HFOPCMIHDOL.JACPIGBEAFH().PINCOCDOOGH())
		{
			this.HFOPCMIHDOL.IBBDMLJGHOB().FEHODJMIAJL(1349f, 0);
		}
	}

	// Token: 0x060047F4 RID: 18420 RVA: 0x0020BAC7 File Offset: 0x00209CC7
	private void HGLBOPHFCPH()
	{
		this.KDBHFEDEMBH(null);
		this.MDGOPJKEIAN(null);
		this.KGELMKIBOIJ(null);
		this.MKJBKIKPJEM(null);
	}

	// Token: 0x060047F5 RID: 18421 RVA: 0x00003E52 File Offset: 0x00002052
	private void GFMFGEEFCDG()
	{
	}

	// Token: 0x060047F6 RID: 18422 RVA: 0x0020BAE8 File Offset: 0x00209CE8
	private void FNDBICLIGKO()
	{
		if (this.HFOPCMIHDOL.ACJPLCIFNPO() == null || this.BODLAMJCHJO)
		{
			return;
		}
		this.BODLAMJCHJO = true;
		if (!this.HFOPCMIHDOL.ACJPLCIFNPO().PINCOCDOOGH())
		{
			this.BODLAMJCHJO = false;
			return;
		}
		if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.IPALJDCNBBG.Count && this.JMNMOHIKHLB.IPALJDCNBBG[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()] > 0)
		{
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
			bool flag = false;
			if (this.JMNMOHIKHLB.CKLNCCAGCKE(this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM(), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)) && (kioojmglclc == null || !kioojmglclc.ALFGPLALKCN()))
			{
				flag = true;
			}
			if (flag)
			{
				this.BODLAMJCHJO = false;
				FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subLook);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passrequiredtoplay"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
				return;
			}
			try
			{
				if (null != this.storyInterfaceHeaderManager)
				{
					this.storyInterfaceHeaderManager.HideInterfaceUndoButton();
				}
				this.GKHNIMJJLJL.LNCIMPFKHAO();
				List<string> list = this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()].GECJLAKBEFK();
				if (list.Count > 0)
				{
					this.LPCBDEBKAIM();
					this.GKHNIMJJLJL.BJEAFBANAHP(list);
				}
				else
				{
					this.GKHNIMJJLJL.PFHCDMOJOKP();
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (!this.ILJAFHPEKDC && SceneStoryManager.QualifiesAsAdBasedChoice(this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.KAJNELPPCIJ[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.JMNMOHIKHLB.KMFABKNKFAJ))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				AdsManagerLP.EHBBFMCILPC.ShowAdRewarded("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess", "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed");
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestPremiumChoice(this.JMNMOHIKHLB.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.JMNMOHIKHLB.JGLEMENLPJP(this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()), AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index), this.ILJAFHPEKDC, "OnBackendPremiumChoiceSuccess", "OnBackendPremiumChoiceException", false);
			return;
		}
		else if (this.JMNMOHIKHLB != null && this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.JMNMOHIKHLB.ENJDGEOFPAA[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()] > 0)
		{
			this.BODLAMJCHJO = false;
			if (this.OAPJBCFENNF()[(int)this.JMNMOHIKHLB.ADHIIAONMDJ[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()]].GALKFKBPLCK() >= this.JMNMOHIKHLB.ENJDGEOFPAA[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()])
			{
				this.HFOPCMIHDOL.ACJPLCIFNPO().FEHODJMIAJL(0f, 1);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("notenoughstats"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupNotEnoughStats, 0f, 28);
			return;
		}
		else if (this.JGEDOIDOPLA != null && this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() < this.JGEDOIDOPLA.IPALJDCNBBG.Count && this.JGEDOIDOPLA.IPALJDCNBBG[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()] > 0)
		{
			KIOOJMGLCLC kioojmglclc2 = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
			bool flag2 = false;
			if (this.JGEDOIDOPLA.CKLNCCAGCKE(this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM(), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)) && (kioojmglclc2 == null || !kioojmglclc2.ALFGPLALKCN()))
			{
				flag2 = true;
			}
			if (flag2)
			{
				this.BODLAMJCHJO = false;
				FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subLook);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passrequiredtoplay"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0.2f, 28);
				return;
			}
			try
			{
				if (null != this.storyInterfaceHeaderManager)
				{
					this.storyInterfaceHeaderManager.HideInterfaceUndoButton();
				}
				this.GKHNIMJJLJL.LNCIMPFKHAO();
				List<string> list2 = this.JGEDOIDOPLA.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()].GECJLAKBEFK();
				if (list2.Count > 0)
				{
					this.LPCBDEBKAIM();
					this.GKHNIMJJLJL.BJEAFBANAHP(list2);
				}
				else
				{
					this.GKHNIMJJLJL.PFHCDMOJOKP();
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
			if (!this.ILJAFHPEKDC && SceneStoryManager.QualifiesAsAdBasedChoice(this.JGEDOIDOPLA.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.JGEDOIDOPLA.KAJNELPPCIJ[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.JGEDOIDOPLA.KMFABKNKFAJ))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				AdsManagerLP.EHBBFMCILPC.ShowAdRewarded("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess", "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed");
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestPremiumChoice(this.JGEDOIDOPLA.MKPMEKKGEIL[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()], this.NJAAOCMPKCD.index, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.JGEDOIDOPLA.JGLEMENLPJP(this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()), AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.NJAAOCMPKCD.index), this.ILJAFHPEKDC, "OnBackendPremiumChoiceSuccess", "OnBackendPremiumChoiceException", false);
			return;
		}
		else
		{
			if (this.JGEDOIDOPLA == null || this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM() >= this.JGEDOIDOPLA.ENJDGEOFPAA.Count || this.JGEDOIDOPLA.ENJDGEOFPAA[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()] <= 0)
			{
				this.BODLAMJCHJO = false;
				this.HFOPCMIHDOL.ACJPLCIFNPO().FEHODJMIAJL(0f, 1);
				return;
			}
			this.BODLAMJCHJO = false;
			if (this.OAPJBCFENNF()[(int)this.JGEDOIDOPLA.ADHIIAONMDJ[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()]].GALKFKBPLCK() >= this.JGEDOIDOPLA.ENJDGEOFPAA[this.HFOPCMIHDOL.ACJPLCIFNPO().ONECLDMJKEE().EKOIFOBAHDM()])
			{
				this.HFOPCMIHDOL.ACJPLCIFNPO().FEHODJMIAJL(0f, 1);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("notenoughstats"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupNotEnoughStats, 0f, 28);
			return;
		}
	}

	// Token: 0x060047F7 RID: 18423 RVA: 0x0020C338 File Offset: 0x0020A538
	private void BPKMDANBJKG(bool DDCJMKCBFLB)
	{
		if (null != this.AHGOMNNMKJM)
		{
			this.AHGOMNNMKJM.interactable = !DDCJMKCBFLB;
		}
	}

	// Token: 0x060047F8 RID: 18424 RVA: 0x0020321C File Offset: 0x0020141C
	private IEnumerator JFKNHKBKFPM(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<StoryLogoManager>().DisappearAnimation();
		}
		yield return new WaitForSeconds(StoryLogoManager.GetDisappearAnimationLength());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		yield return null;
		yield break;
	}

	// Token: 0x060047F9 RID: 18425 RVA: 0x0020C358 File Offset: 0x0020A558
	private bool GCMPNMKDFAD(int MEFKFOHCOHK, bool IABMFJGOCFA)
	{
		if (this.JGPIOKPMGDG(MEFKFOHCOHK))
		{
			return true;
		}
		try
		{
			HFDAGKJJHOA hfdagkjjhoa = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE();
			for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.JOJKAIBEPGH.Count; i++)
			{
				ECJCFGAOPHJ ecjcfgaophj = hfdagkjjhoa.DCPPCOHEAFA(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.JOJKAIBEPGH[i]);
				if (ecjcfgaophj != null && ecjcfgaophj.APDJNDIIILK.Contains(MEFKFOHCOHK))
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return !IABMFJGOCFA && ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge && this.AHKDFKBDBJG.Contains(MEFKFOHCOHK);
	}

	// Token: 0x060047FA RID: 18426 RVA: 0x0020C414 File Offset: 0x0020A614
	private void AINGAFFKBIJ(FGINKFGNNEK JKJMDNFAFBB, string KCOMIMHDJJP)
	{
		NonPlayerCharacterManager component = JKJMDNFAFBB.IACFDHCDEME.GetComponent<NonPlayerCharacterManager>();
		string dbhmnecmiab = JKJMDNFAFBB.DBHMNECMIAB;
		FLNOFHCNJDM lastEmotionRequested = component.GetLastEmotionRequested();
		FLNOFHCNJDM lastDelayedDefaultEmotionRequested = component.GetLastDelayedDefaultEmotionRequested();
		this.PromoteLoungeNpcAssetToChapterLifetime(KCOMIMHDJJP);
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		list.Add(JKJMDNFAFBB);
		this.CMBLMOJFGAE.Remove(JKJMDNFAFBB);
		component.HideAtOnce();
		GameObject gameObject = null;
		try
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterRenderTexturePrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
			gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(66f, 415f, 1250f);
			gameObject.transform.SetParent(this.playerCharacterPivot.transform, false);
			int num = -1;
			for (int i = 0; i < this.LLEHEBBHAOD.Count; i++)
			{
				if (this.LLEHEBBHAOD[i] != null && !(null == this.LLEHEBBHAOD[i].IACFDHCDEME) && !(this.LLEHEBBHAOD[i].IACFDHCDEME.transform.parent != this.playerCharacterPivot.transform))
				{
					num = this.LLEHEBBHAOD[i].IACFDHCDEME.transform.GetSiblingIndex();
					if (this.LLEHEBBHAOD[i].DBHMNECMIAB != null && this.LLEHEBBHAOD[i].DBHMNECMIAB.Equals(dbhmnecmiab))
					{
						break;
					}
				}
			}
			if (num >= 0)
			{
				gameObject.transform.SetSiblingIndex(num);
			}
			else
			{
				gameObject.transform.SetAsFirstSibling();
			}
			NonPlayerCharacterManager component2 = gameObject.GetComponent<NonPlayerCharacterManager>();
			component2.Initialize(KCOMIMHDJJP, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.left, true);
			SceneStoryManager.OMOGKJCMCKF(KCOMIMHDJJP);
			component2.AnimateAppearance(GFEJBOAKPMP.animationStoryAppearFromLeft);
			component2.SetEmotion(lastEmotionRequested, (BIDPEOLOIIG)8, lastDelayedDefaultEmotionRequested);
			component2.RecordLineEmotion(lastEmotionRequested, lastDelayedDefaultEmotionRequested);
			component2.EKPHEMHBNNN();
			this.CMBLMOJFGAE.Add(this.GLDAJFNCFKC(dbhmnecmiab, gameObject));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != gameObject)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		base.StartCoroutine(this.JHDEBFCKKJA(list));
		LPEMDECEIAO.ILEIHOFGKGC(KCOMIMHDJJP);
	}

	// Token: 0x060047FB RID: 18427 RVA: 0x0020C64C File Offset: 0x0020A84C
	private void HKFLIHJGOHN()
	{
		List<int> list = new List<int>(this.PCGFKFFPODD);
		for (int i = 0; i < this.AHKDFKBDBJG.Count; i++)
		{
			if (!list.Contains(this.AHKDFKBDBJG[i]))
			{
				list.Add(this.AHKDFKBDBJG[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			if (!this.GCMPNMKDFAD(list[j], true))
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, list[j]);
			}
		}
		this.PCGFKFFPODD.Clear();
		this.AHKDFKBDBJG.Clear();
		this.PCFBCHNFMBG = 0;
	}

	// Token: 0x060047FC RID: 18428 RVA: 0x0020C6F4 File Offset: 0x0020A8F4
	private void GPNFLDDKLAJ()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.MCIGJBFKOIJ = false;
		this.ODOPEGPBCCD();
		this.OPEGJAEFAJL();
		this.GOLDLGPECBJ();
		for (int i = 0; i < this.LLEHEBBHAOD.Count; i++)
		{
			this.LLEHEBBHAOD[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().InitializeFromSaveData(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.PONLMNGHCAP);
		}
		this.KBBPBKJEFCJ();
		base.StartCoroutine(this.KLPHDBHBAMK());
	}

	// Token: 0x060047FD RID: 18429 RVA: 0x0020C794 File Offset: 0x0020A994
	private void FGBMKKIFDKD()
	{
		if (SceneStoryManager.consumeEnergyBackendOperationResult < 0)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartnotea"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore), new UnityAction(this.DMOCOBKPJHK), DFGILFBGPLN.popupNotEnoughHardCurrency, 0f, 28).ShowEnergy(SceneStoryManager.consumeEnergyBackendOperationResult);
			return;
		}
		this.CHDPABJGOOC();
	}

	// Token: 0x060047FE RID: 18430 RVA: 0x0020C81C File Offset: 0x0020AA1C
	private void OCINDEPGGCP()
	{
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		int num4 = 1;
		List<AssetStoryNpc> list = new List<AssetStoryNpc>();
		for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
		{
			if (this.ODNCKIKLFCM[i].IENHFCPBKBA() != 185)
			{
				list.Add(this.ODNCKIKLFCM[i]);
			}
			else
			{
				num++;
				DPGJIJGOCIC.ADFCDFHBDAF("" + this.ODNCKIKLFCM[i].id);
			}
		}
		this.ODNCKIKLFCM.Clear();
		this.ODNCKIKLFCM = list;
		List<StoryEnvironmentManager> list2 = new List<StoryEnvironmentManager>();
		for (int j = 1; j < this.CHHIBBOICAD.Count; j += 0)
		{
			if (this.CHHIBBOICAD[j].BKCLBCIKKKB() != -116)
			{
				list2.Add(this.CHHIBBOICAD[j]);
			}
			else
			{
				num2++;
				this.CHHIBBOICAD[j].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.CHHIBBOICAD[j].gameObject);
				DPGJIJGOCIC.PJCLICBPPDA("/" + this.CHHIBBOICAD[j].name);
			}
		}
		this.CHHIBBOICAD.Clear();
		this.CHHIBBOICAD = list2;
		List<StoryEnvironmentManager> list3 = new List<StoryEnvironmentManager>();
		for (int k = 1; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].BKCLBCIKKKB() != 121)
			{
				list3.Add(this.KEPHFKAHILM[k]);
			}
			else
			{
				num3++;
				this.KEPHFKAHILM[k].gameObject.transform.SetParent(null);
				UnityEngine.Object.Destroy(this.KEPHFKAHILM[k].gameObject);
				DPGJIJGOCIC.PJCLICBPPDA("chsf" + this.KEPHFKAHILM[k].name);
			}
		}
		this.KEPHFKAHILM.Clear();
		this.KEPHFKAHILM = list3;
		List<StoryEnvironmentLayerManager> list4 = new List<StoryEnvironmentLayerManager>();
		for (int l = 0; l < this.FAEEEHDCNDN.Count; l++)
		{
			if (this.FAEEEHDCNDN[l].NAKBKDAMOCE() != 13)
			{
				list4.Add(this.FAEEEHDCNDN[l]);
			}
			else
			{
				num4 += 0;
				DPGJIJGOCIC.ADFCDFHBDAF(" not found, replacing with " + this.FAEEEHDCNDN[l].name);
			}
		}
		this.FAEEEHDCNDN.Clear();
		this.FAEEEHDCNDN = list4;
	}

	// Token: 0x060047FF RID: 18431 RVA: 0x0020CAC8 File Offset: 0x0020ACC8
	private void ALGIAIKDEPH()
	{
		for (int i = 0; i < this.canvases.Count; i++)
		{
			this.canvases[i].enabled = false;
		}
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x0020CB00 File Offset: 0x0020AD00
	private void EJNFPPPAPAB()
	{
		for (int i = 0; i < this.cameras.Count; i += 0)
		{
			this.cameras[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x0020CB3C File Offset: 0x0020AD3C
	public static bool AnyLoungeCharacterInVisitedWardrobes(int PLKMJJIIJNO, PLFDAJJHMKO LFLOCKNKAKC)
	{
		try
		{
			FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(PLKMJJIIJNO);
			if (fjlgcknojmj == null)
			{
				return false;
			}
			for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
			{
				if (SceneStoryManager.LoungeCharacterInVisitedWardrobes(fjlgcknojmj.OINAAMKLNLO[i], LFLOCKNKAKC))
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06004802 RID: 18434 RVA: 0x001FC1F2 File Offset: 0x001FA3F2
	private void GLMFCONMBID()
	{
		this.BIMHNCJHLBO();
	}

	// Token: 0x06004803 RID: 18435 RVA: 0x0020CBB0 File Offset: 0x0020ADB0
	public static bool LoungeMappingIsEligible(ECJCFGAOPHJ FFACCDIEBIA, PLFDAJJHMKO LFLOCKNKAKC, APNIHJMGNIM JHIABHGNMKM, FIGIKDMPGCI ICMKGDALKHH)
	{
		if (!FFACCDIEBIA.HLEOLMIFCGI())
		{
			return false;
		}
		if (FFACCDIEBIA.MNBBOAPGCMM > 0 && AppManager.EHBBFMCILPC.UnsupportedRevision(FFACCDIEBIA.MNBBOAPGCMM))
		{
			return false;
		}
		if (FFACCDIEBIA.PPBPOPEEPDJ(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA()) && (FFACCDIEBIA.OBLBNLBFBNI < 0 || !AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(FFACCDIEBIA.OBLBNLBFBNI)))
		{
			return false;
		}
		if (!SceneStoryManager.LoungeMappingUnlockReached(FFACCDIEBIA, LFLOCKNKAKC) && (JHIABHGNMKM == null || !JHIABHGNMKM.LMGFNJAFOLC(FFACCDIEBIA.PBGKGCHMHOP, FFACCDIEBIA.CGKKPPEIFJH)) && !DHFLKLPKNJG.FIPHMDGKAAH(FFACCDIEBIA) && (FFACCDIEBIA.HANJMGHBMMG <= 0 || !SceneStoryManager.LoungeMappingGateReached(LFLOCKNKAKC, FFACCDIEBIA.HANJMGHBMMG, FFACCDIEBIA.HDCCOIKLCDM)))
		{
			return false;
		}
		bool flag = DHFLKLPKNJG.FIPHMDGKAAH(FFACCDIEBIA);
		if (!flag && FFACCDIEBIA.AHKJFFOIBCP != null && FFACCDIEBIA.AHKJFFOIBCP.Length > 0)
		{
			int num = 0;
			if (ICMKGDALKHH == null || !ICMKGDALKHH.OKDMBGDGGHF(FFACCDIEBIA.AHKJFFOIBCP, out num))
			{
				return false;
			}
			int num2 = 0;
			if (!int.TryParse(FFACCDIEBIA.EIIDBBOONCO, out num2))
			{
				return false;
			}
			if (num != num2)
			{
				return false;
			}
		}
		if (!flag && FFACCDIEBIA.OMDMNLFMICP != null && FFACCDIEBIA.OMDMNLFMICP.Length > 0)
		{
			int num3 = 0;
			if (ICMKGDALKHH != null && ICMKGDALKHH.OKDMBGDGGHF(FFACCDIEBIA.OMDMNLFMICP, out num3))
			{
				int num4 = 0;
				if (!int.TryParse(FFACCDIEBIA.CHJMIKCCLML, out num4))
				{
					return false;
				}
				if (num3 == num4)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06004804 RID: 18436 RVA: 0x0020CCF7 File Offset: 0x0020AEF7
	private IEnumerator PCNKEKEMDKJ()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		int loungePopWaitFrames = 0;
		while (ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge && loungePopWaitFrames < 10)
		{
			int num = loungePopWaitFrames;
			loungePopWaitFrames = num + 1;
			yield return null;
		}
		this.FKFFMIDEDCF();
		this.POPIBGGFPDL();
		if (null != AssetsManager.EHBBFMCILPC.GetSceneLoungeManager(0))
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
		}
		this.HDCPBLICGNA();
		this.HKFLIHJGOHN();
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
		}
		this.OHPEONMNFNJ(100);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
		GC.Collect();
		Resources.UnloadUnusedAssets();
		this.MCIGJBFKOIJ = false;
		yield break;
	}

	// Token: 0x06004805 RID: 18437 RVA: 0x0020CD08 File Offset: 0x0020AF08
	private void HFBKFDFIHKD()
	{
		if (ODJKHCHFKNL.PJMEPGPHDAD() != DFGILFBGPLN.screenPurchasing)
		{
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.ODOPEGPBCCD();
		this.ANPFJKKHIJG();
		this.GOLDLGPECBJ();
		this.KBBPBKJEFCJ();
		if (this.HFOPCMIHDOL.DMDPCOFOLEK().ONECLDMJKEE().OBKCKGHFMDN == KGLBKJKNPFD.LBFFMOMMAPK.environmentFadeSrc && this.HFOPCMIHDOL.FEAPDNPCKLG().JPHIPBEBNGD().BOPJOMGIJIA == OHAAGENIEMD.BMHGEBOHLHH.showRemoveAdsOffer)
		{
			this.HFOPCMIHDOL.PINDIBFKIHH().FEHODJMIAJL(0f, 1);
		}
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
		if (this.HAFFEDMEIAF)
		{
			this.BHFGFBKNLOM();
		}
		this.CBNBDIMFAII();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			this.HBPLGJFPFKM();
		}
	}

	// Token: 0x06004806 RID: 18438 RVA: 0x0020CDC4 File Offset: 0x0020AFC4
	private void IBMJEMBGAMJ()
	{
		SceneLoungeManager.SetPendingLoungeCharacter(null);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06004807 RID: 18439 RVA: 0x0020CE31 File Offset: 0x0020B031
	public static bool LoungeMappingIsLockedPreview(ECJCFGAOPHJ FFACCDIEBIA, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return !SceneStoryManager.LoungeMappingUnlockReached(FFACCDIEBIA, LFLOCKNKAKC);
	}

	// Token: 0x06004808 RID: 18440 RVA: 0x0020CE3D File Offset: 0x0020B03D
	private bool LAHJKCAFPHA()
	{
		return this.GLIMDKBANOI && !this.MCIGJBFKOIJ && !this.MBBFJHBFPNB && ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenStory;
	}

	// Token: 0x06004809 RID: 18441 RVA: 0x0020CE61 File Offset: 0x0020B061
	private void NDMCKOKIEMP(bool NIEJFHHKNGN)
	{
		if (NIEJFHHKNGN && this.KKIGOAKNCIE >= 0)
		{
			return;
		}
		if (ODLJHDIGLGO.NEABBOKICBA(CLHDENLPOFP.gamePass) != null && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass).CGOECMIINGM())
		{
			this.KBBPBKJEFCJ();
			this.KKIGOAKNCIE++;
		}
	}

	// Token: 0x0600480A RID: 18442 RVA: 0x0020CE99 File Offset: 0x0020B099
	private void COIAOPMCJMA()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(22);
		SceneStoryManager.achievementSyncReward = 0;
		this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
	}

	// Token: 0x0600480B RID: 18443 RVA: 0x0020CEC4 File Offset: 0x0020B0C4
	private void JLGGFBHBGPB(string OIPOAEPAJHO, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG, bool PCPPCAEJICE)
	{
		bool flag = true;
		bool flag2 = true;
		string text = OIPOAEPAJHO;
		if (this.GKHNIMJJLJL.NCAMFPGMCIG.PJNNJCABGIF() >= 8)
		{
			text = this.GKHNIMJJLJL.NCAMFPGMCIG.KNBOMEDEPAD(OIPOAEPAJHO);
		}
		if (text.Contains("OnChapterSnapshotsItemClose"))
		{
			flag2 = false;
			text = text.Replace("XXX", "XXX");
		}
		for (int i = 1; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(text))
				{
					flag = true;
					if (CHOBEDPLLOG)
					{
						this.FAEEEHDCNDN[i].ECDNEHIKLIH(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
					}
					else
					{
						this.FAEEEHDCNDN[i].CEMMEKGFOIE(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
					}
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(text))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.FAEEEHDCNDN[i].DJKKGMHJFNG(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
				}
				else
				{
					this.FAEEEHDCNDN[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			try
			{
				if (CHOBEDPLLOG && text.Contains("id") && this.GKHNIMJJLJL.NCAMFPGMCIG.LMCJOCDIJGP() >= 6 && null != this.videoPlaybackCamera && KHPGPLAMAIN.GHJOJANKGHM() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					string value = text.Substring(0, text.IndexOf(""));
					GameObject gameObject = null;
					for (int j = 1; j < this.KEPHFKAHILM.Count; j += 0)
					{
						if (this.KEPHFKAHILM[j].gameObject.name.Equals(value))
						{
							gameObject = new GameObject(text);
							gameObject.SetActive(true);
							gameObject.transform.SetParent(this.KEPHFKAHILM[j].gameObject.transform, false);
							gameObject.AddComponent<CanvasGroup>();
							gameObject.layer = LayerMask.NameToLayer("");
							StoryEnvironmentLayerManager storyEnvironmentLayerManager = gameObject.AddComponent<StoryEnvironmentLayerManager>();
							storyEnvironmentLayerManager.BGOKOJOBPHJ(this.KEPHFKAHILM[j].GetOnDemandResourcesCheckpointIndex());
							this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager);
							break;
						}
					}
					if (null == gameObject)
					{
						for (int k = 1; k < this.CHHIBBOICAD.Count; k += 0)
						{
							if (this.CHHIBBOICAD[k].gameObject.name.Equals(value))
							{
								gameObject = new GameObject(text);
								gameObject.SetActive(false);
								gameObject.transform.SetParent(this.CHHIBBOICAD[k].gameObject.transform, false);
								gameObject.AddComponent<CanvasGroup>();
								gameObject.layer = LayerMask.NameToLayer("");
								StoryEnvironmentLayerManager storyEnvironmentLayerManager2 = gameObject.AddComponent<StoryEnvironmentLayerManager>();
								storyEnvironmentLayerManager2.LALPGAGDOMN(this.CHHIBBOICAD[k].BKCLBCIKKKB());
								this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager2);
								break;
							}
						}
					}
					if (null != gameObject)
					{
						for (int l = 1; l < this.FAEEEHDCNDN.Count; l += 0)
						{
							if (!flag2)
							{
								if (this.FAEEEHDCNDN[l].gameObject.name.Equals(text))
								{
									flag = true;
									if (CHOBEDPLLOG)
									{
										this.FAEEEHDCNDN[l].ELECAPNEBAA(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
									}
									else
									{
										this.FAEEEHDCNDN[l].KEGLFLIHIJC(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
									}
								}
							}
							else if (this.FAEEEHDCNDN[l].gameObject.name.Contains(text))
							{
								flag = true;
								if (CHOBEDPLLOG)
								{
									this.FAEEEHDCNDN[l].DJKKGMHJFNG(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
								}
								else
								{
									this.FAEEEHDCNDN[l].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
								}
							}
						}
					}
					if (!flag)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("OnPopupProfileSaveCutsceneInputCancel" + text + "socialsimplegiftcollect");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("ZZZ" + text + "stat0");
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600480C RID: 18444 RVA: 0x0020D32C File Offset: 0x0020B52C
	private IEnumerator JHDEBFCKKJA(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		this.LDAPOBMECNI++;
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().AnimateDisappearance(GFEJBOAKPMP.animationStoryDisappearToLeft);
		}
		yield return new WaitForSeconds(NonPlayerCharacterManager.GetAnimationDisappearTime());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
		}
		this.LDAPOBMECNI--;
		yield return null;
		yield break;
	}

	// Token: 0x0600480D RID: 18445 RVA: 0x0020D344 File Offset: 0x0020B544
	private void CENEGBNNOOM()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.MCIGJBFKOIJ = true;
		ApplicationFocusManager.Restore();
		this.ODOPEGPBCCD();
		this.OPEGJAEFAJL();
		this.GOLDLGPECBJ();
		this.KBBPBKJEFCJ();
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL.Length > 0 && this.HFFIIBBJBMH.header.ambientFreeAudio)
		{
			AudioManager.EHBBFMCILPC.PlayMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FONKDFDJFEL, true, 1f, false);
		}
		AudioManager.EHBBFMCILPC.FadeMusic(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NPAFPMIMGLH, 1f);
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
		base.StartCoroutine(this.PCNKEKEMDKJ());
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x0020D421 File Offset: 0x0020B621
	public static bool LoungeMappingGateReached(PLFDAJJHMKO LFLOCKNKAKC, int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		return LFLOCKNKAKC != null && LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI >= NLLCKPCKGOH && (LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI != NLLCKPCKGOH || LFLOCKNKAKC.DHONIOBOLEL.DDEDAHCFHJN() >= OLKMHHNMDLP);
	}

	// Token: 0x0600480F RID: 18447 RVA: 0x0020D458 File Offset: 0x0020B658
	private void PKCNCMBMJCI()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClickConfimed", 0f);
		this.JMNMOHIKHLB = null;
		this.JGEDOIDOPLA = null;
		ApplicationFocusManager.Deactivate();
		this.BPKMDANBJKG(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHNAACHLPIC == 1 || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DJIGFDJOHCI.Length > 0);
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x0020D4CA File Offset: 0x0020B6CA
	private IEnumerator DEMIIEHPNIH()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		yield return new WaitForSeconds(0.5f);
		FacebookManager.EHBBFMCILPC.InitializeFacebookManager();
		int num;
		for (int i = 0; i < 6; i = num + 1)
		{
			if (!FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
			{
				yield return new WaitForSeconds(0.5f);
			}
			num = i;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowSettings(false, this.HFFIIBBJBMH.header.enablePostEffects, true);
		if (this.MOCHJHMLGBG())
		{
			this.ACJLMIELCME();
		}
		yield break;
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x0020D4D9 File Offset: 0x0020B6D9
	private void GDIAFPNOKHP()
	{
		if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.CanInteract())
		{
			if (this.storyInterfaceHeaderManager.EHLFLGKONOM())
			{
				return;
			}
			this.OnAvatarClick();
		}
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x0020D50C File Offset: 0x0020B70C
	private void EPKNCKGNNCE()
	{
		if (this.MCIGJBFKOIJ)
		{
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			return;
		}
		if (this.JMNMOHIKHLB != null && this.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.npc)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			return;
		}
		if (!SceneStoryManager.AnyLoungeCharacterInActiveWardrobe())
		{
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			return;
		}
		SceneStoryManager.IBNPEHNMGJB();
		if (this.FIICDGAOKDH())
		{
			this.MNDOHKJIFDD = true;
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			if (!SceneStoryManager.RequestLoungePremiumChoicesHistory() && this.MNDOHKJIFDD)
			{
				this.MNDOHKJIFDD = false;
				CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
				this.IBMJEMBGAMJ();
			}
			return;
		}
		this.EGNAHFEGEJM();
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x0020D5E4 File Offset: 0x0020B7E4
	private void LLNENMOMNKP()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			if (this.storyInterfaceHeaderManager.IsPaused())
			{
				return;
			}
			if (this.storyInterfaceHeaderManager.CanInteract())
			{
				this.OGNJFHPEDNN();
				this.OnBackClick();
				return;
			}
			this.OGNJFHPEDNN();
			this.APDAMLCHICH();
			this.OPLBCELFMLI();
			this.storyInterfaceHeaderManager.Show(0f);
		}
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x001FE2F7 File Offset: 0x001FC4F7
	private void PMIEIFKANGO()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		this.HBPLGJFPFKM();
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x0020D64C File Offset: 0x0020B84C
	private void DEDGJBBGODI(string FOCIFOLONJD)
	{
		List<FGINKFGNNEK> list = new List<FGINKFGNNEK>();
		List<FGINKFGNNEK> list2 = new List<FGINKFGNNEK>();
		for (int i = 0; i < this.NALOEFHHCCH.Count; i += 0)
		{
			if (FOCIFOLONJD == null || FOCIFOLONJD.Length == 0 || (FOCIFOLONJD.Length > 0 && !this.NALOEFHHCCH[i].DBHMNECMIAB.Equals(FOCIFOLONJD)))
			{
				list.Add(this.NALOEFHHCCH[i]);
			}
			else
			{
				list2.Add(this.NALOEFHHCCH[i]);
			}
		}
		this.NALOEFHHCCH = list2;
		base.StartCoroutine(this.DKJCIENFCDJ(list));
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x0020D6E3 File Offset: 0x0020B8E3
	private IEnumerator AHGMHCLFGPL(float LJLHCJFDNGL)
	{
		yield return new WaitForSeconds(LJLHCJFDNGL);
		this.MLDJOHGCHEB();
		yield break;
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x0020D6F9 File Offset: 0x0020B8F9
	private IEnumerator DKJCIENFCDJ(List<FGINKFGNNEK> EFBLHGECEJA)
	{
		this.LDAPOBMECNI++;
		for (int i = 0; i < EFBLHGECEJA.Count; i++)
		{
			EFBLHGECEJA[i].IACFDHCDEME.GetComponent<PlayerCharacterManager>().AnimateDisappearance(BKBCKPMDFOD.animationStoryDisappearToRight, true);
		}
		yield return new WaitForSeconds(PlayerCharacterManager.GetAnimationDisappearTime());
		for (int j = 0; j < EFBLHGECEJA.Count; j++)
		{
			CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
			if (null != this.EBHJLLIHIFE)
			{
				ahlneabnmoa = this.EBHJLLIHIFE.GetSlotByCharacterObject(EFBLHGECEJA[j].IACFDHCDEME);
			}
			if (ahlneabnmoa != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
			}
			else if (null != EFBLHGECEJA[j].IACFDHCDEME)
			{
				UnityEngine.Object.Destroy(EFBLHGECEJA[j].IACFDHCDEME);
			}
		}
		this.LDAPOBMECNI--;
		yield return null;
		yield break;
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x0020D710 File Offset: 0x0020B910
	private void CCNGMJLPLLK(int MCLBOIFEFGH)
	{
		try
		{
			if (!(null == this.HFFIIBBJBMH) && !(null == this.HFFIIBBJBMH.header))
			{
				CustomFaderSettings customFaderSettings = this.HFFIIBBJBMH.header.HGIIJABNDCD(MCLBOIFEFGH);
				if (customFaderSettings != null)
				{
					for (int i = 0; i < this.HFFIIBBJBMH.header.customFaderSettings.Count; i++)
					{
						CustomFaderSettings customFaderSettings2 = this.HFFIIBBJBMH.header.customFaderSettings[i];
						if (customFaderSettings2 != null && customFaderSettings2.index >= 4 && customFaderSettings2.index < -10 && customFaderSettings2.assetIndex == customFaderSettings.assetIndex)
						{
							return;
						}
					}
					AssetsManager.MJBDMHPHMID().FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleCustomEffects, customFaderSettings.assetIndex);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x0020D7E4 File Offset: 0x0020B9E4
	private FGINKFGNNEK NPMBAFIMPOF(string PDEADFPONFH, List<string> MPLEPCPGJBA)
	{
		for (int i = 0; i < this.CMBLMOJFGAE.Count; i++)
		{
			if (this.CMBLMOJFGAE[i].IACFDHCDEME.GetComponent<NonPlayerCharacterManager>().IsEqual(PDEADFPONFH, MPLEPCPGJBA))
			{
				return this.CMBLMOJFGAE[i];
			}
		}
		return null;
	}

	// Token: 0x0600481A RID: 18458 RVA: 0x00003E52 File Offset: 0x00002052
	private void HEMEDGIGOMK()
	{
	}

	// Token: 0x0600481B RID: 18459 RVA: 0x0020D834 File Offset: 0x0020BA34
	private void MJODBGBOCOF()
	{
		if (this.CBHGEFCFOKP != null)
		{
			base.StopCoroutine(this.CBHGEFCFOKP);
		}
		this.CBHGEFCFOKP = null;
		if (this.FKDGGOOAPEP != null)
		{
			base.StopCoroutine(this.FKDGGOOAPEP);
		}
		this.FKDGGOOAPEP = null;
		this.AMBEPJCICOF();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.HFOPCMIHDOL.HJOANJHIHAI().FEHODJMIAJL(0f, 1);
		this.CMDIKMNEGEN();
	}

	// Token: 0x0600481C RID: 18460 RVA: 0x0020D8A4 File Offset: 0x0020BAA4
	private void COPCJKBGNCB()
	{
		if (this.HFOPCMIHDOL.CDIHGDMGCEK() == null)
		{
			return;
		}
		this.OGNJFHPEDNN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		if (this.HFOPCMIHDOL.CDIHGDMGCEK().PINCOCDOOGH())
		{
			this.HFOPCMIHDOL.CDIHGDMGCEK().FEHODJMIAJL(0f, 1);
		}
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x0020DB28 File Offset: 0x0020BD28
	public void OnGetCdnDataForAvatarScreenException()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnAvatarClick), new UnityAction(this.OnAvatarClick), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x0020DBB1 File Offset: 0x0020BDB1
	private LDLLJFOJCDF[] OAPJBCFENNF()
	{
		this.DINBJCKMOMB();
		return this.ANIMANJDNII;
	}

	// Token: 0x06004820 RID: 18464 RVA: 0x0020DBC0 File Offset: 0x0020BDC0
	public void CJMBIPFMBKG()
	{
		this.ALGIAIKDEPH();
		this.EJNFPPPAPAB();
		this.JCNICMFKAOL();
		if (this.HAFFEDMEIAF)
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().PLLFCKGMHCF(true);
	}

	// Token: 0x06004821 RID: 18465 RVA: 0x0020DC19 File Offset: 0x0020BE19
	private void HJLPPAPNOHF()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(20);
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileSaveCutsceneInput();
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x0020DC31 File Offset: 0x0020BE31
	public static bool JCIIBCPNONE(ECJCFGAOPHJ FFACCDIEBIA, PLFDAJJHMKO LFLOCKNKAKC)
	{
		return SceneStoryManager.CIMEKEGFFAE(FFACCDIEBIA, LFLOCKNKAKC);
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x0020DC3D File Offset: 0x0020BE3D
	private void FKKNKFIFLID()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.AADJGGEMOJD();
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOAIJGHPEPH()
	{
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x0020DC50 File Offset: 0x0020BE50
	private void ANPFJKKHIJG()
	{
		for (int i = 0; i < this.cameras.Count; i += 0)
		{
			this.cameras[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x0020DC8C File Offset: 0x0020BE8C
	private void MBOJMJOEGDH()
	{
		this.BODLAMJCHJO = false;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("adserrorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupIncentAd2Failed, 0f, 28);
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x0020DCE4 File Offset: 0x0020BEE4
	private void IKFCJJIMBIJ()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0 && this.CODFIPHLBLE != null)
		{
			StoryEnvironmentManager component = this.LDLPKDIFOAD(this.CODFIPHLBLE.IBFLNCMCKAL).GetComponent<StoryEnvironmentManager>();
			if (null != component)
			{
				List<string> list = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.COFAHJCNONO(component.name);
				List<string> list2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.NDELGCAHKFO(component.name);
				string ljlbjihpkae = "";
				if (StoryEnvironmentLayerManager.lastVideoLayerName.Length > 0 && StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName.Length > 0)
				{
					string text2 = StoryEnvironmentLayerManager.lastVideoLayerName;
					if (this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM() >= 3)
					{
						text2 = this.GKHNIMJJLJL.NCAMFPGMCIG.GCOHKKMPJKJ(text2);
					}
					if (text2.StartsWith(component.name + "layervideo") && !list.Contains(text2))
					{
						ljlbjihpkae = StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName;
						list.Add(text2);
					}
				}
				string ahlohdkpamg = "";
				AudioContainer containerForAudioClip = AudioManager.EHBBFMCILPC.GetContainerForAudioClip(CCEMAFOMLLK.music, this.CODFIPHLBLE.KPPJINFHMIP);
				if (null != containerForAudioClip)
				{
					ahlohdkpamg = containerForAudioClip.GetAssetBundleName();
				}
				string memflcdmjkh = "";
				AudioContainer containerForAudioClip2 = AudioManager.EHBBFMCILPC.GetContainerForAudioClip(CCEMAFOMLLK.sfx, this.CODFIPHLBLE.JLEAIJGBGHL);
				if (null != containerForAudioClip2)
				{
					memflcdmjkh = containerForAudioClip2.GetAssetBundleName();
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.MNHKPMBLEEK(component.name, this.CODFIPHLBLE.OHFLBJGOAOO(component.name), this.LANHEHAJDJJ(component, list, list2), list2, this.GKHNIMJJLJL.NCAMFPGMCIG.JGAKEIBKKGM(), text, this.CODFIPHLBLE.NLAPFLNBDLC, this.CODFIPHLBLE.DBIEKGOEKKH, component.GetAssetBundleName(), this.CODFIPHLBLE.KPPJINFHMIP, ahlohdkpamg, this.CODFIPHLBLE.JLEAIJGBGHL, memflcdmjkh, ljlbjihpkae, this.CODFIPHLBLE.BIBACLNGIOD, this.CODFIPHLBLE.OOLMNPHJOFA, component.GetAssetBundleFolderIndex()))
				{
					string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("savecutscenedone");
					text3 = text3.Replace("(X)", "<i>\"" + text + "\"</i>");
					text3 = text3.Replace(",", "،");
					text3 = text3.Replace("(", "〈");
					text3 = text3.Replace(")", "〉");
					this.HFOPCMIHDOL.HFALHCEIDPM("$NOTESHOW body(" + text3 + ")", new List<string>(), new List<Choice>(), false, false, false, false);
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socCut.ToString(), BGHLMGPPCNN.socCutSave.ToString(), false, false);
				}
				else
				{
					string str = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cutscenesavefailed");
					this.HFOPCMIHDOL.HFALHCEIDPM("$NOTESHOW body(" + str + ")", new List<string>(), new List<Choice>(), false, false, false, false);
				}
			}
			this.DDDEHHANLKH(true);
		}
		this.JOKJBAIECCA(true);
		this.GLOEGOPLGDN();
		this.AIGBJLAPFLH();
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x0020E01C File Offset: 0x0020C21C
	private void AGFCAHIAAPL()
	{
		this.playerCharacterOffscreenRenderCamera.gameObject.SetActive(true);
		this.playerCharacterRenderTextureCanvas.enabled = true;
	}

	// Token: 0x040013B0 RID: 5040
	public static int consumeEnergyBackendOperationResult = -1;

	// Token: 0x040013B1 RID: 5041
	public const string onShowStoryHeaderInterfaceGamePassAndUndoButton = "OnShowStoryHeaderInterfaceGamePassAndUndoButton";

	// Token: 0x040013B2 RID: 5042
	public const string onStoryScreenChoiceExtendedManagerEnvironmentChangeComplete = "OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete";

	// Token: 0x040013B3 RID: 5043
	public const string onStoryScreenChoiceExtendedManagerLayerChangeComplete = "OnStoryScreenChoiceExtendedManagerLayerChangeComplete";

	// Token: 0x040013B4 RID: 5044
	public const string onRewardScreenAssetsDownloadSuccess = "OnRewardScreenAssetsDownloadSuccess";

	// Token: 0x040013B5 RID: 5045
	public const string onRewardScreenAssetsDownloadFailed = "OnRewardScreenAssetsDownloadFailed";

	// Token: 0x040013B6 RID: 5046
	public const string onSceneStoryManagerPremiumChoiceAdsProviderAdSuccess = "OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess";

	// Token: 0x040013B7 RID: 5047
	public const string onSceneStoryManagerPremiumChoiceAdsProviderAdFailed = "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed";

	// Token: 0x040013B8 RID: 5048
	public const string onAvatarScreenAssetsDownloadSuccess = "OnAvatarScreenAssetsDownloadSuccess";

	// Token: 0x040013B9 RID: 5049
	public const string onAvatarScreenAssetsDownloadFailed = "OnAvatarScreenAssetsDownloadFailed";

	// Token: 0x040013BA RID: 5050
	public const string onLoungeScreenAssetsDownloadSuccess = "OnLoungeScreenAssetsDownloadSuccess";

	// Token: 0x040013BB RID: 5051
	public const string onLoungeScreenAssetsDownloadFailed = "OnLoungeScreenAssetsDownloadFailed";

	// Token: 0x040013BC RID: 5052
	public const string onOnDemandResourcesDownloadSuccess = "OnOnDemandResourcesDownloadSuccess";

	// Token: 0x040013BD RID: 5053
	public const string onOnDemandResourcesDownloadFailed = "OnOnDemandResourcesDownloadFailed";

	// Token: 0x040013BE RID: 5054
	public const string onStoryChoiceClick = "OnStoryChoiceClick";

	// Token: 0x040013BF RID: 5055
	public const string onStoryChoiceClickConfirmed = "OnStoryChoiceClickConfimed";

	// Token: 0x040013C0 RID: 5056
	public const string onCollectableDialogCollect = "OnCollectableDialogCollect";

	// Token: 0x040013C1 RID: 5057
	public const string onCollectableDialogUsed = "OnCollectableDialogUsed";

	// Token: 0x040013C2 RID: 5058
	public const string onCollectableDialogShown = "OnCollectableDialogShown";

	// Token: 0x040013C3 RID: 5059
	public const string onBackendPremiumChoiceRetry = "OnBackendPremiumChoiceRetry";

	// Token: 0x040013C4 RID: 5060
	public const string onBackendPremiumChoiceException = "OnBackendPremiumChoiceException";

	// Token: 0x040013C5 RID: 5061
	public const string onBackendPremiumChoiceSuccess = "OnBackendPremiumChoiceSuccess";

	// Token: 0x040013C6 RID: 5062
	public const string onBackendUndoPremiumChoiceException = "OnBackendUndoPremiumChoiceException";

	// Token: 0x040013C7 RID: 5063
	public const string onBackendUndoPremiumChoiceSuccess = "OnBackendUndoPremiumChoiceSuccess";

	// Token: 0x040013C8 RID: 5064
	public const string onAchievementSyncSuccess = "OnAchievementSyncSuccess";

	// Token: 0x040013C9 RID: 5065
	public const string onAchievementSyncException = "OnAchievementSyncException";

	// Token: 0x040013CA RID: 5066
	public const string onStoryCurrencyInfoClick = "OnStoryCurrencyInfoClick";

	// Token: 0x040013CB RID: 5067
	public const string onAvatarScreenClosed = "OnAvatarScreenClosed";

	// Token: 0x040013CC RID: 5068
	public const string onStoryAdsProviderAdSuccess = "OnStoryAdsProviderAdSuccess";

	// Token: 0x040013CD RID: 5069
	public const string onPremiumChoiceExecuted = "OnPremiumChoiceExecuted";

	// Token: 0x040013CE RID: 5070
	public const string onPremiumChoiceExecutedHardBased = "OnPremiumChoiceExecutedHardBased";

	// Token: 0x040013CF RID: 5071
	public const string onPremiumChoiceExecutedAdBased = "OnPremiumChoiceExecutedAdBased";

	// Token: 0x040013D0 RID: 5072
	public const string onGetCdnDataForAvatarScreenSuccess = "OnGetCdnDataForAvatarScreenSuccess";

	// Token: 0x040013D1 RID: 5073
	public const string onGetCdnDataForAvatarScreenException = "OnGetCdnDataForAvatarScreenException";

	// Token: 0x040013D2 RID: 5074
	public const string onGetCdnDataBeforeOnDemandSuccess = "OnGetCdnDataBeforeOnDemandSuccess";

	// Token: 0x040013D3 RID: 5075
	public const string onGetCdnDataBeforeOnDemandException = "OnGetCdnDataBeforeOnDemandException";

	// Token: 0x040013D4 RID: 5076
	public const string onStoryManInTheMiddleAttackDetected = "OnStoryManInTheMiddleAttackDetected";

	// Token: 0x040013D5 RID: 5077
	public const string onConsumeEnergyException = "OnConsumeEnergyException";

	// Token: 0x040013D6 RID: 5078
	public const string onConsumeEnergySuccess = "OnConsumeEnergySuccess";

	// Token: 0x040013D7 RID: 5079
	public const string onTryToFireNoteshowTimer = "OnTryToFireNoteshowTimer";

	// Token: 0x040013D8 RID: 5080
	public const string onBackendPassResourcesChangedType0 = "OnBackendPassResourcesChangedType0";

	// Token: 0x040013D9 RID: 5081
	public const string onNeedToOpenLoveInterestsLounge = "OnNeedToOpenLoveInterestsLounge";

	// Token: 0x040013DA RID: 5082
	public static bool inkInterpretingIsPaused = false;

	// Token: 0x040013DB RID: 5083
	public static List<string> freePremiumChoicesFallback = new List<string>();

	// Token: 0x040013DC RID: 5084
	public static List<int> freePremiumChoices = new List<int>();

	// Token: 0x040013DD RID: 5085
	public const int LOUNGE_HISTORY_NONE = 0;

	// Token: 0x040013DE RID: 5086
	public const int LOUNGE_HISTORY_IN_FLIGHT = 1;

	// Token: 0x040013DF RID: 5087
	public const int LOUNGE_HISTORY_SUCCESS = 2;

	// Token: 0x040013E0 RID: 5088
	public const int LOUNGE_HISTORY_FAILED = 3;

	// Token: 0x040013E1 RID: 5089
	public static int loungePremiumChoicesHistoryState = 0;

	// Token: 0x040013E2 RID: 5090
	private static List<int> BLMFAKBBMOE = new List<int>();

	// Token: 0x040013E3 RID: 5091
	public static JSONArray achievements = new JSONArray();

	// Token: 0x040013E4 RID: 5092
	public static int achievementSyncReward = 0;

	// Token: 0x040013E5 RID: 5093
	public static int premiumChoiceBackendOperationResult = 0;

	// Token: 0x040013E6 RID: 5094
	public static int premiumChoiceBackendOperationResult2 = 0;

	// Token: 0x040013E7 RID: 5095
	public static string premiumChoiceBackendOperationResultKey = "";

	// Token: 0x040013E8 RID: 5096
	public static string chapterSecurityKey = "";

	// Token: 0x040013E9 RID: 5097
	public static List<string> choiceSecurityKeyList = new List<string>();

	// Token: 0x040013EA RID: 5098
	public static List<string> choiceSecurityIdList = new List<string>();

	// Token: 0x040013EB RID: 5099
	public static float choiceDecisionTime = 0f;

	// Token: 0x040013EC RID: 5100
	public static bool anyChapterCompleted = false;

	// Token: 0x040013ED RID: 5101
	public List<FaderManager> fadeLayers = new List<FaderManager>();

	// Token: 0x040013EE RID: 5102
	public Camera playerCharacterOffscreenRenderCamera;

	// Token: 0x040013EF RID: 5103
	public RawImage playerCharacterRenderTextureRawImage;

	// Token: 0x040013F0 RID: 5104
	public Canvas playerCharacterRenderTextureCanvas;

	// Token: 0x040013F1 RID: 5105
	public GameObject environmentsBackPivot;

	// Token: 0x040013F2 RID: 5106
	public GameObject environmentsFrontPivot;

	// Token: 0x040013F3 RID: 5107
	public GameObject sharedLayersFrontPivot;

	// Token: 0x040013F4 RID: 5108
	public Button avatarButton;

	// Token: 0x040013F5 RID: 5109
	public GameObject dialogNarratorPrefab;

	// Token: 0x040013F6 RID: 5110
	public GameObject dialogTitlePrefab;

	// Token: 0x040013F7 RID: 5111
	public GameObject storyLogoPrefab;

	// Token: 0x040013F8 RID: 5112
	public List<Sprite> availableStoryLogos = new List<Sprite>();

	// Token: 0x040013F9 RID: 5113
	public GameObject narratorDialogPivot;

	// Token: 0x040013FA RID: 5114
	public GameObject titleDialogPivot;

	// Token: 0x040013FB RID: 5115
	public GameObject playerCharacterPivot;

	// Token: 0x040013FC RID: 5116
	public GameObject nonPlayerCharacterPivot;

	// Token: 0x040013FD RID: 5117
	public GameObject dialogPlayerCharacterPrefab;

	// Token: 0x040013FE RID: 5118
	public GameObject dialogNonPlayerCharacterPrefab;

	// Token: 0x040013FF RID: 5119
	public GameObject tapToContinuePivot;

	// Token: 0x04001400 RID: 5120
	public GameObject notesPivot;

	// Token: 0x04001401 RID: 5121
	public GameObject noteStoryPrefab;

	// Token: 0x04001402 RID: 5122
	public GameObject noteStoryAchievementPrefab;

	// Token: 0x04001403 RID: 5123
	public GameObject subtitlesPivot;

	// Token: 0x04001404 RID: 5124
	public GameObject subtitleStoryPrefab;

	// Token: 0x04001405 RID: 5125
	public GameObject readInputPivot;

	// Token: 0x04001406 RID: 5126
	public GameObject dialogReadInputPrefab;

	// Token: 0x04001407 RID: 5127
	public GameObject extendedChoicePivot;

	// Token: 0x04001408 RID: 5128
	public GameObject extendedChoicePrefab;

	// Token: 0x04001409 RID: 5129
	public GameObject extendedChoiceOneToManyPivot;

	// Token: 0x0400140A RID: 5130
	public GameObject extendedChoiceOneToManyPrefab;

	// Token: 0x0400140B RID: 5131
	public GameObject statsPivot;

	// Token: 0x0400140C RID: 5132
	public GameObject dialogItemFoundPrefab;

	// Token: 0x0400140D RID: 5133
	public GameObject dialogItemUsedPrefab;

	// Token: 0x0400140E RID: 5134
	public GameObject dialogItemShownPrefab;

	// Token: 0x0400140F RID: 5135
	public GameObject dialogItemShownFullscreenPrefab;

	// Token: 0x04001410 RID: 5136
	public GameObject itemFoundDialogPivot;

	// Token: 0x04001411 RID: 5137
	public GameObject tapToContinuePrefab;

	// Token: 0x04001412 RID: 5138
	public GameObject stat0Prefab;

	// Token: 0x04001413 RID: 5139
	public GameObject stat1Prefab;

	// Token: 0x04001414 RID: 5140
	public GameObject stat2Prefab;

	// Token: 0x04001415 RID: 5141
	public GameObject stat3Prefab;

	// Token: 0x04001416 RID: 5142
	public GameObject stat4Prefab;

	// Token: 0x04001417 RID: 5143
	public GameObject stat5Prefab;

	// Token: 0x04001418 RID: 5144
	public GameObject stat6Prefab;

	// Token: 0x04001419 RID: 5145
	public List<Canvas> canvases = new List<Canvas>();

	// Token: 0x0400141A RID: 5146
	public List<Camera> cameras = new List<Camera>();

	// Token: 0x0400141B RID: 5147
	public FaderManager preWarmFader;

	// Token: 0x0400141C RID: 5148
	public AnimationShake animationShakeEnvironmentFront;

	// Token: 0x0400141D RID: 5149
	public AnimationShake animationShakeEnvironmentBack;

	// Token: 0x0400141E RID: 5150
	public StoryInterfaceHeaderManager storyInterfaceHeaderManager;

	// Token: 0x0400141F RID: 5151
	public ImageEffectsSelector imageEffects;

	// Token: 0x04001420 RID: 5152
	public ImageEffectsSelectorOvr imageEffectsOvr;

	// Token: 0x04001421 RID: 5153
	public Camera videoPlaybackCamera;

	// Token: 0x04001422 RID: 5154
	public SaveCutsceneButtonManager saveCutsceneButton;

	// Token: 0x04001423 RID: 5155
	public GameObject storyChatPrefab;

	// Token: 0x04001424 RID: 5156
	public TextMeshProUGUI hintText;

	// Token: 0x04001425 RID: 5157
	public List<Sprite> statsIcons = new List<Sprite>();

	// Token: 0x04001426 RID: 5158
	private int HDKIOPAGLHH;

	// Token: 0x04001427 RID: 5159
	private static SceneStoryManager IKLAPGJDMNA;

	// Token: 0x04001428 RID: 5160
	private Story GFIFDKBLLBL;

	// Token: 0x04001429 RID: 5161
	private TextAsset FJIBKABPIGJ;

	// Token: 0x0400142A RID: 5162
	private List<StoryEnvironmentManager> CHHIBBOICAD = new List<StoryEnvironmentManager>();

	// Token: 0x0400142B RID: 5163
	private List<StoryEnvironmentManager> KEPHFKAHILM = new List<StoryEnvironmentManager>();

	// Token: 0x0400142C RID: 5164
	private List<StoryEnvironmentLayerManager> FAEEEHDCNDN = new List<StoryEnvironmentLayerManager>();

	// Token: 0x0400142D RID: 5165
	private List<AssetStoryItem> BAFONBJIKLA = new List<AssetStoryItem>();

	// Token: 0x0400142E RID: 5166
	private List<AssetStoryNpc> ODNCKIKLFCM = new List<AssetStoryNpc>();

	// Token: 0x0400142F RID: 5167
	private IJOKIIKBDLI HFOPCMIHDOL = new IJOKIIKBDLI();

	// Token: 0x04001430 RID: 5168
	private List<FGINKFGNNEK> KKNOHEBIDFL = new List<FGINKFGNNEK>();

	// Token: 0x04001431 RID: 5169
	private List<FGINKFGNNEK> PBPHFLJDNBH = new List<FGINKFGNNEK>();

	// Token: 0x04001432 RID: 5170
	private List<int> JGCFEBDMBMC = new List<int>();

	// Token: 0x04001433 RID: 5171
	private List<FGINKFGNNEK> BLNNJFAAHDP = new List<FGINKFGNNEK>();

	// Token: 0x04001434 RID: 5172
	private List<FGINKFGNNEK> JCGPMCONNBM = new List<FGINKFGNNEK>();

	// Token: 0x04001435 RID: 5173
	private List<FGINKFGNNEK> MPNBBKODANC = new List<FGINKFGNNEK>();

	// Token: 0x04001436 RID: 5174
	private List<FGINKFGNNEK> PKPMIABFBON = new List<FGINKFGNNEK>();

	// Token: 0x04001437 RID: 5175
	private List<FGINKFGNNEK> JOFJNLHIJOB = new List<FGINKFGNNEK>();

	// Token: 0x04001438 RID: 5176
	private List<FGINKFGNNEK> CMBLMOJFGAE = new List<FGINKFGNNEK>();

	// Token: 0x04001439 RID: 5177
	private List<FGINKFGNNEK> NALOEFHHCCH = new List<FGINKFGNNEK>();

	// Token: 0x0400143A RID: 5178
	private List<FGINKFGNNEK> LLEHEBBHAOD = new List<FGINKFGNNEK>();

	// Token: 0x0400143B RID: 5179
	private List<GameObject> HNNPNKKLNBM = new List<GameObject>();

	// Token: 0x0400143C RID: 5180
	private List<FGINKFGNNEK> PGNIDAAHCOI = new List<FGINKFGNNEK>();

	// Token: 0x0400143D RID: 5181
	private List<FGINKFGNNEK> KICOPFEHKJF = new List<FGINKFGNNEK>();

	// Token: 0x0400143E RID: 5182
	private List<FGINKFGNNEK> ADIPBAHEMFF = new List<FGINKFGNNEK>();

	// Token: 0x0400143F RID: 5183
	private List<FGINKFGNNEK> BBNLMENIFNJ = new List<FGINKFGNNEK>();

	// Token: 0x04001440 RID: 5184
	private List<int> AGKKCOENLOJ = new List<int>();

	// Token: 0x04001441 RID: 5185
	private List<FGINKFGNNEK> IJMGENDHKMP = new List<FGINKFGNNEK>();

	// Token: 0x04001442 RID: 5186
	private List<FGINKFGNNEK> BOALOCEGFOO = new List<FGINKFGNNEK>();

	// Token: 0x04001443 RID: 5187
	private MNGDMIHKNDB CODFIPHLBLE;

	// Token: 0x04001444 RID: 5188
	private PMNHKIDIMLM JMNMOHIKHLB;

	// Token: 0x04001445 RID: 5189
	private JJBCFINBFKL JGEDOIDOPLA;

	// Token: 0x04001446 RID: 5190
	private CKBCHMOAKLK GOPGELMBMMK;

	// Token: 0x04001447 RID: 5191
	private PFADAFAHNNJ HPAEFOJDLFC;

	// Token: 0x04001448 RID: 5192
	private bool GLIMDKBANOI;

	// Token: 0x04001449 RID: 5193
	private RectTransform GFFLNCOEEKP;

	// Token: 0x0400144A RID: 5194
	private RectTransform MGDOAFNHBHP;

	// Token: 0x0400144B RID: 5195
	private float PGLKLNNMKMO = 0.5f;

	// Token: 0x0400144C RID: 5196
	private const float EDFEIKLAOJK = 50f;

	// Token: 0x0400144D RID: 5197
	private bool DMIPDJJBFLN;

	// Token: 0x0400144E RID: 5198
	private bool NEDLEEPJJIC;

	// Token: 0x0400144F RID: 5199
	private bool MBBFJHBFPNB;

	// Token: 0x04001450 RID: 5200
	private bool MCIGJBFKOIJ;

	// Token: 0x04001451 RID: 5201
	private PLFDAJJHMKO GKHNIMJJLJL;

	// Token: 0x04001452 RID: 5202
	private AssetStoryHeader NJAAOCMPKCD;

	// Token: 0x04001453 RID: 5203
	private AssetAnthology HFFIIBBJBMH;

	// Token: 0x04001454 RID: 5204
	private LDLLJFOJCDF[] ANIMANJDNII;

	// Token: 0x04001455 RID: 5205
	private RenderTexture IAJFFABJAHB;

	// Token: 0x04001456 RID: 5206
	private Material IKKEDBBANCO;

	// Token: 0x04001457 RID: 5207
	private CharacterRenderTexturePool EBHJLLIHIFE;

	// Token: 0x04001458 RID: 5208
	private EnvironmentMorphManager DMNJMLDEILJ;

	// Token: 0x04001459 RID: 5209
	private int LDAPOBMECNI;

	// Token: 0x0400145A RID: 5210
	private CanvasGroup PONLMNGHCAP;

	// Token: 0x0400145B RID: 5211
	private float OPNHKEEICPG = 0.35f;

	// Token: 0x0400145C RID: 5212
	private float LLGKJGFBKKG = 1f;

	// Token: 0x0400145D RID: 5213
	private const float MNJCFDOOLKM = 15f;

	// Token: 0x0400145E RID: 5214
	private float BAABIIPPLCE = 15f;

	// Token: 0x0400145F RID: 5215
	private int HPBFGMAFKDD;

	// Token: 0x04001460 RID: 5216
	private bool ILJAFHPEKDC;

	// Token: 0x04001461 RID: 5217
	private bool BODLAMJCHJO;

	// Token: 0x04001462 RID: 5218
	private int HODJEPIPDFH;

	// Token: 0x04001463 RID: 5219
	private int DCFBAMCJCFK;

	// Token: 0x04001464 RID: 5220
	private int OBPPPNCALNP;

	// Token: 0x04001465 RID: 5221
	private int FJIAGECENLF;

	// Token: 0x04001466 RID: 5222
	private int NHDMFANLHPE;

	// Token: 0x04001467 RID: 5223
	private bool EDOBNNLBBDC;

	// Token: 0x04001468 RID: 5224
	private float LHGNMIOGHGJ;

	// Token: 0x04001469 RID: 5225
	private string IFLGCDMCEGD = "";

	// Token: 0x0400146A RID: 5226
	private string PKKPMENAIGC = "";

	// Token: 0x0400146B RID: 5227
	private string GLLFKOJEBPC = "";

	// Token: 0x0400146C RID: 5228
	private string INIEOPFGBEG = "";

	// Token: 0x0400146D RID: 5229
	private string BHCPLGJJOPA = "";

	// Token: 0x0400146E RID: 5230
	private int PEGKFFIEEEF;

	// Token: 0x0400146F RID: 5231
	private float MINLCJENJIB = -1f;

	// Token: 0x04001470 RID: 5232
	private Coroutine CBHGEFCFOKP;

	// Token: 0x04001471 RID: 5233
	private Coroutine FKDGGOOAPEP;

	// Token: 0x04001472 RID: 5234
	private bool EMKPOOMPLON;

	// Token: 0x04001473 RID: 5235
	private bool GJDIJIAENCJ;

	// Token: 0x04001474 RID: 5236
	private int IOIBPOKHBHD = -1;

	// Token: 0x04001475 RID: 5237
	public static int premiumChoiceManInTheMiddleAttack = 0;

	// Token: 0x04001476 RID: 5238
	private bool HAFFEDMEIAF;

	// Token: 0x04001477 RID: 5239
	private int FDEBLDDCGGB;

	// Token: 0x04001478 RID: 5240
	private float OFCOFBDHBHE = 0.85f;

	// Token: 0x04001479 RID: 5241
	private int KKIGOAKNCIE;

	// Token: 0x0400147A RID: 5242
	private bool KDAPIHAKHBF;

	// Token: 0x0400147B RID: 5243
	private StoryInterfaceFastForwardManager FNHFGLHODBG;

	// Token: 0x0400147C RID: 5244
	private StoryInterfaceAutoReaderManager KOCJONIGKNH;

	// Token: 0x0400147D RID: 5245
	private bool ACAMCLIBIAF;

	// Token: 0x0400147E RID: 5246
	private bool JPKENCCOBEA;

	// Token: 0x0400147F RID: 5247
	private Coroutine ECBMIHCALBG;

	// Token: 0x04001480 RID: 5248
	private Button AHGOMNNMKJM;

	// Token: 0x04001481 RID: 5249
	public static string localizedLine = "";

	// Token: 0x04001482 RID: 5250
	public static string localizedChoice = "";

	// Token: 0x04001483 RID: 5251
	public const int LOUNGE_ASSETS_CHECKPOINT_INDEX = 900000;

	// Token: 0x04001484 RID: 5252
	private List<int> GGPMPJOEIJN = new List<int>();

	// Token: 0x04001485 RID: 5253
	private List<string> GFIAPGFHIGM = new List<string>();

	// Token: 0x04001486 RID: 5254
	private List<GHMINFEGBGN> LMFEMNCAICA = new List<GHMINFEGBGN>();

	// Token: 0x04001487 RID: 5255
	private bool MNDOHKJIFDD;

	// Token: 0x04001488 RID: 5256
	private static readonly OJEPOPKPJML PNKPJFHFGHJ = new OJEPOPKPJML();

	// Token: 0x04001489 RID: 5257
	private List<string> KEPLJDAONLC = new List<string>();

	// Token: 0x0400148A RID: 5258
	private List<string> NJEPIPLACPC;

	// Token: 0x0400148B RID: 5259
	private List<int> PCGFKFFPODD = new List<int>();

	// Token: 0x0400148C RID: 5260
	private List<int> AHKDFKBDBJG = new List<int>();

	// Token: 0x0400148D RID: 5261
	private int PCFBCHNFMBG;

	// Token: 0x0200022D RID: 557
	public enum LMJAGOPMGHH
	{
		// Token: 0x0400148F RID: 5263
		spring,
		// Token: 0x04001490 RID: 5264
		summer,
		// Token: 0x04001491 RID: 5265
		autumn,
		// Token: 0x04001492 RID: 5266
		winter
	}

	// Token: 0x0200022E RID: 558
	public static class AKLCNEOHFFB
	{
		// Token: 0x06004829 RID: 18473 RVA: 0x0020E03C File Offset: 0x0020C23C
		public static SceneStoryManager.LMJAGOPMGHH AJODGEBFJPJ(DateTime HIPDGIIBBMN)
		{
			int month = HIPDGIIBBMN.Month;
			if (month >= 3 && month <= 5)
			{
				return SceneStoryManager.LMJAGOPMGHH.spring;
			}
			if (month >= 6 && month <= 8)
			{
				return SceneStoryManager.LMJAGOPMGHH.summer;
			}
			if (month >= 9 && month <= 11)
			{
				return SceneStoryManager.LMJAGOPMGHH.autumn;
			}
			return SceneStoryManager.LMJAGOPMGHH.winter;
		}
	}

	// Token: 0x02000240 RID: 576
	[CompilerGenerated]
	private sealed class KODEFAMOIKH
	{
		// Token: 0x06004890 RID: 18576 RVA: 0x0020F58E File Offset: 0x0020D78E
		internal void NDALNHLFPHD()
		{
			this.stepDesc.FEHODJMIAJL(0f, 1);
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x0020F5A4 File Offset: 0x0020D7A4
		internal void LINOAKGHBLF()
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IHPEAIDMDAC() < 2 || this.stepDesc.JPHIPBEBNGD().NCKKJGPMGHG >= 0.001f || this.stepDesc.JPHIPBEBNGD().CICCPMFOCGH >= 0.001f)
			{
				this.<>4__this.OFMCEFLLLHO(this.stepDesc.JPHIPBEBNGD().HCMBDDEOADO.OCNOFIDCBIH, 0f);
			}
			this.stepDesc.FEHODJMIAJL(0f, 1);
		}

		// Token: 0x040014D3 RID: 5331
		public SceneStoryManager <>4__this;

		// Token: 0x040014D4 RID: 5332
		public MOLKEIABAOJ stepDesc;
	}
}
