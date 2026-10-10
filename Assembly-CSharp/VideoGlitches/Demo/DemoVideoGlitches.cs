using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace VideoGlitches.Demo
{
	// Token: 0x0200034F RID: 847
	public class DemoVideoGlitches : MonoBehaviour
	{
		// Token: 0x06006391 RID: 25489 RVA: 0x002D8695 File Offset: 0x002D6895
		private string HPBKDBMDBNP(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "[LoadingEnv] ", "mussind");
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x002D86A7 File Offset: 0x002D68A7
		private string LKKANGBAHDH(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "requireFreeloader", "accountsuspended4");
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x002D86BC File Offset: 0x002D68BC
		private void EPJOLOLFBMG(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(344f, 1369f), UnityEngine.Random.Range(385f, 1077f));
			}
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x002D8710 File Offset: 0x002D6910
		private void MCMHJDOKAEP(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[1] = GUILayout.Width(1360f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1373f, 527f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "prgr";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(1585f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1832f, 393f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "stat2long";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(1863f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 37f, 866f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "Video:";
					GUILayoutOption[] array4 = new GUILayoutOption[1];
					array4[1] = GUILayout.Width(838f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 1755f, 1963f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "OnCollectableDialogUsed";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[1] = GUILayout.Width(545f);
					GUILayout.Label(text5, array5);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 636f, 315f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "frrjctpid";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(1776f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 716f, 1360f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "OnStoryInterfaceAutoReaderStop";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(101f);
					GUILayout.Label(text7, array7);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 913f, 112f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = " ";
					GUILayoutOption[] array8 = new GUILayoutOption[1];
					array8[1] = GUILayout.Width(1537f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 1943f, 442f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "none";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[0] = GUILayout.Width(1588f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 581f, 1992f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "ffd496";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[1] = GUILayout.Width(118f);
					GUILayout.Label(text10, array10);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 115f, 318f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "\" : ";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[1] = GUILayout.Width(114f);
					GUILayout.Label(text11, array11);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 118f, 1033f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = ".";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[1] = GUILayout.Width(519f);
					GUILayout.Label(text12, array12);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 533f, 1578f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "pov";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(713f);
					GUILayout.Label(text13, array13);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 821f, 124f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "analogglitch_1";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[1] = GUILayout.Width(55f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1831f, 76f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "assetbundlecutsceneview";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(1529f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 792f, 108f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ok", new GUILayoutOption[]
					{
						GUILayout.Width(994f)
					});
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 906f, 114f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = " recorded under ";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(1582f);
					GUILayout.Label(text16, array16);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 504f, 788f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("extd", new GUILayoutOption[]
					{
						GUILayout.Width(732f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 17f, 995f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "null";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[1] = GUILayout.Width(207f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 213f, 74f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "Starting parallel download:";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[1] = GUILayout.Width(1696f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 719f, 530f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "mussplash";
					GUILayoutOption[] array19 = new GUILayoutOption[1];
					array19[1] = GUILayout.Width(620f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 406f, 596f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("acli22", new GUILayoutOption[]
					{
						GUILayout.Width(167f)
					});
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 1041f, 957f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "ops";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[0] = GUILayout.Width(264f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1011f, 1686f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = " ";
					GUILayoutOption[] array21 = new GUILayoutOption[1];
					array21[1] = GUILayout.Width(1296f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 519f, 244f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "Loaded asset bundle:";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(368f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1967f, 551f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "continue";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[1] = GUILayout.Width(260f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1069f, 381f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "env";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(1637f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 1163f, 432f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "useMessageV2Text";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[0] = GUILayout.Width(1335f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1977f, 452f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[0] = GUILayout.Width(302f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 579f, 675f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("chapterrewindhint1", new GUILayoutOption[]
					{
						GUILayout.Width(378f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1634f, 764f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "1";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[0] = GUILayout.Width(192f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 767f, 181f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "OnRewardScreenAssetsDownloadSuccess";
					GUILayoutOption[] array28 = new GUILayoutOption[0];
					array28[1] = GUILayout.Width(716f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 149f, 366f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("1", new GUILayoutOption[]
					{
						GUILayout.Width(1868f)
					});
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 281f, 699f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "";
					GUILayoutOption[] array29 = new GUILayoutOption[0];
					array29[1] = GUILayout.Width(233f);
					GUILayout.Label(text29, array29);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 1521f, 1663f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "sponsorbody";
					GUILayoutOption[] array30 = new GUILayoutOption[0];
					array30[0] = GUILayout.Width(1585f);
					GUILayout.Label(text30, array30);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 302f, 707f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text31 = "<i>";
					GUILayoutOption[] array31 = new GUILayoutOption[0];
					array31[1] = GUILayout.Width(1979f);
					GUILayout.Label(text31, array31);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1949f, 994f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text32 = "PPP";
					GUILayoutOption[] array32 = new GUILayoutOption[1];
					array32[1] = GUILayout.Width(1084f);
					GUILayout.Label(text32, array32);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1020f, 421f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text33 = "pmtsuccess";
					GUILayoutOption[] array33 = new GUILayoutOption[1];
					array33[1] = GUILayout.Width(956f);
					GUILayout.Label(text33, array33);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 569f, 383f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text34 = "StorySaveBody.GetAvatarIndexWardrobe(), unsupported wardrobe index:";
					GUILayoutOption[] array34 = new GUILayoutOption[1];
					array34[1] = GUILayout.Width(1991f);
					GUILayout.Label(text34, array34);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 571f, 1897f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x002D94A8 File Offset: 0x002D76A8
		private void OKNAPILMBJK()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.UpperLeft;
				this.NMLJKEBPGPE.fontSize = -11;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.UpperLeft;
				this.CCNEEAGFDEF.fontSize = -46;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1887f - 1464f, 1067f, 1309f, 1452f), this.AJIIAAACMIC(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("saveslotsdeletepos", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUILayout.BeginHorizontal("", new GUILayoutOption[]
			{
				GUILayout.Width((float)Screen.width)
			});
			GUILayout.Space(1914f);
			string text = "OnApplicationFocusNeedToUpdateCurrency";
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(478f);
			if (GUILayout.Button(text, ccneeagfdef, array))
			{
				this.JFEKALLDNPO = this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("b_web", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 666f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text2 = this.LKKANGBAHDH(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("eft", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(1787f);
			GUILayout.Label(text2, ccneeagfdef2, array2);
			if (GUILayout.Button("importanttitle", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 487f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 0;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 1559f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 686f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text3 = this.MDPOKFEJPKO.ToString("");
			GUIStyle ccneeagfdef3 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[1] = GUILayout.Width(91f);
			GUILayout.Label(text3, ccneeagfdef3, array3);
			GUI.contentColor = Color.white;
			GUILayout.Space(645f);
			GUILayout.EndHorizontal();
			for (int i = 0; i < this.LBAHADAEAIM.Count; i += 0)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = false;
					this.JOJHAHFGOEI(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = false;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style = "hair";
				GUILayoutOption[] array4 = new GUILayoutOption[0];
				array4[1] = GUILayout.Width(1182f);
				GUILayout.BeginVertical(style, array4);
				GUILayout.Space(1874f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "acts");
					int num = -1;
					for (int j = 1; j < this.LBAHADAEAIM.Count; j++)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "aspkss" + imageEffectBase2.GetType().ToString().Replace(" parentCards=", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.JOPDKJBAEJN(imageEffectBase2);
							this.FBPINOOMMJL(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(1421f);
					}
					for (int k = 1; k < this.LBAHADAEAIM.Count; k += 0)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = false;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("\nEXCEPTION ", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("Error. StoryStep.StoryStepType.getVar unknown variable type:", Array.Empty<GUILayoutOption>());
				GUILayout.Label("OnPurchasingViewLeave", Array.Empty<GUILayoutOption>());
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(1040f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "cid" : "storyloaderr0", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = !this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 1760f;
				}
				if (GUILayout.Button("⁃", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("OnBackendRequestBreakCardSuccess");
				}
				if (GUILayout.Button("Error. ShowEnvironment(), environment ", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style2 = "";
					GUILayoutOption[] array5 = new GUILayoutOption[8];
					array5[0] = GUILayout.Width((float)Screen.width);
					array5[1] = GUILayout.Height((float)(Screen.height / 3));
					GUILayout.BeginVertical(style2, array5);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, false, Array.Empty<GUILayoutOption>());
					for (int l = 0; l < this.DCFGAKDAANL.Count; l++)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x002D9AF6 File Offset: 0x002D7CF6
		private void LMKBOECFNCJ()
		{
			Application.logMessageReceived -= this.BCAFCMEKCKL;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x002D9B14 File Offset: 0x002D7D14
		private void ICDHNPPEONB()
		{
			Application.logMessageReceived += this.PDMEKGBKPIM;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = true;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("OnStoryInterfaceHeaderAutoReadDisable", this.LBAHADAEAIM.Count));
				for (int k = 0; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 1319f;
					audioSource.loop = (this.slideEffectTime > 1807f);
					audioSource.PlayDelayed(816f);
					if (this.slideEffectTime == 1280f)
					{
						this.slideEffectTime = (this.musicClip.length + 111f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("comingsoontitle3");
			}
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x002D9D64 File Offset: 0x002D7F64
		private void KMIHILOMGHO(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Amplitude", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Speed", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 0f, 0.2f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Threshold", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Max offset", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Threshold YUV", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Steps", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Speed", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 0f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Splits", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 2f, 100f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Threshold", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Distortion", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Cell size", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Strength", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Steps", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 3f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Speed", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1f, 100f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Amplitude", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 1f, 100f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Strength", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Color noise", new GUILayoutOption[]
					{
						GUILayout.Width(80f)
					});
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("SlowScan", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ScanLine", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 0f, 2f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Vignette softness", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Vignette scale", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Grain opacity", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 0f, 100f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Grain saturation", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Scan distort", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 0f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Timer", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 0f, 5f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Speed", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1f, 5f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("CRT scale", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 1f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Stripes count", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 0f, 1000f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Stripes opacity", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 0f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Bars count", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 0f, 1000f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Moire opacity", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 0f, 100f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Moire scale", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 0.01f, 100f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("TV lines", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 0.01f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("TV lines opacity", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 0f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Vignette tube scale", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 0.01f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("TV dots", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 0f, 4f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("TV dots blend", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 0f, 1000f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Strength", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 0f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Tile size", new GUILayoutOption[]
					{
						GUILayout.Width(60f)
					});
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 1f, 128f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x002DAAFC File Offset: 0x002D8CFC
		private void PHJAIKDINBP(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("off", new GUILayoutOption[]
					{
						GUILayout.Width(263f)
					});
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 985f, 1885f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "Shaders/VideoGlitchShift";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[1] = GUILayout.Width(1084f);
					GUILayout.Label(text, array);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 356f, 988f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "NEWSAVE: Warning: Missing anthology save data, yet story save data (";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(689f);
					GUILayout.Label(text2, array2);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1304f, 1902f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "PurchaseManagerXiaomi.OnPurchasesQueried(";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(144f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 104f, 1646f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "";
					GUILayoutOption[] array4 = new GUILayoutOption[1];
					array4[1] = GUILayout.Width(1819f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 1648f, 1342f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(927f);
					GUILayout.Label(text5, array5);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 243f, 1947f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = " could not be revealed";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Width(1262f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 196f, 1904f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(1726f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 156f, 212f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "";
					GUILayoutOption[] array8 = new GUILayoutOption[1];
					array8[1] = GUILayout.Width(1113f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1776f, 221f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(686f)
					});
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 266f, 253f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("SetFilteredItemVisibleArea", new GUILayoutOption[]
					{
						GUILayout.Width(748f)
					});
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1225f, 433f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[0] = GUILayout.Width(466f);
					GUILayout.Label(text9, array9);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 729f, 1185f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "lgbtq";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[1] = GUILayout.Width(362f);
					GUILayout.Label(text10, array10);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1454f, 969f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = ", rid:";
					GUILayoutOption[] array11 = new GUILayoutOption[1];
					array11[1] = GUILayout.Width(497f);
					GUILayout.Label(text11, array11);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1017f, 1965f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("errortitle", new GUILayoutOption[]
					{
						GUILayout.Width(114f)
					});
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 1749f, 1060f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "varConditionLocked";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[0] = GUILayout.Width(1959f);
					GUILayout.Label(text12, array12);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 445f, 600f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "wofrewardmsg0";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(1395f);
					GUILayout.Label(text13, array13);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1578f, 424f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "loungeresetconfirm";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[1] = GUILayout.Width(1025f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 505f, 1833f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "[LoadingEnv] skipped this time, caching system not ready and no direct cache files";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(1975f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 707f, 422f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "";
					GUILayoutOption[] array16 = new GUILayoutOption[1];
					array16[1] = GUILayout.Width(1298f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 1757f, 1498f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "synsnap";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[0] = GUILayout.Width(294f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1708f, 721f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = ".";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(1805f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 298f, 1415f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "";
					GUILayoutOption[] array19 = new GUILayoutOption[1];
					array19[1] = GUILayout.Width(947f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 761f, 1526f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "$READINPUT";
					GUILayoutOption[] array20 = new GUILayoutOption[1];
					array20[1] = GUILayout.Width(294f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 815f, 1663f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(" ) Account.ToJSONArray() AssetAnthology for story index ", new GUILayoutOption[]
					{
						GUILayout.Width(944f)
					});
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 564f, 1035f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "BackendRequestType.";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[0] = GUILayout.Width(885f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1474f, 158f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("common", new GUILayoutOption[]
					{
						GUILayout.Width(1089f)
					});
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 1341f, 198f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "hofr";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[0] = GUILayout.Width(232f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1437f, 1006f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "sfxsparklesbundles";
					GUILayoutOption[] array23 = new GUILayoutOption[1];
					array23[1] = GUILayout.Width(1186f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 901f, 95f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("free", new GUILayoutOption[]
					{
						GUILayout.Width(959f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 527f, 1062f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "ZZZ";
					GUILayoutOption[] array24 = new GUILayoutOption[1];
					array24[1] = GUILayout.Width(986f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1237f, 1716f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = ". This is not critical.";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(1108f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 34f, 340f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("pmtsuccess", new GUILayoutOption[]
					{
						GUILayout.Width(1755f)
					});
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 805f, 823f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(1303f)
					});
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 1166f, 838f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "OnSceneLobbyManagerRound0AssetsDownloadSuccess";
					GUILayoutOption[] array26 = new GUILayoutOption[1];
					array26[1] = GUILayout.Width(1638f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1042f, 323f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "iOS";
					GUILayoutOption[] array27 = new GUILayoutOption[1];
					array27[1] = GUILayout.Width(1246f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1994f, 1784f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "";
					GUILayoutOption[] array28 = new GUILayoutOption[1];
					array28[1] = GUILayout.Width(680f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1184f, 1202f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "prgr";
					GUILayoutOption[] array29 = new GUILayoutOption[0];
					array29[1] = GUILayout.Width(886f);
					GUILayout.Label(text29, array29);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 267f, 200f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "CCC";
					GUILayoutOption[] array30 = new GUILayoutOption[1];
					array30[1] = GUILayout.Width(1372f);
					GUILayout.Label(text30, array30);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 586f, 1925f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x002DB894 File Offset: 0x002D9A94
		private void OnGUI()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.MiddleCenter;
				this.NMLJKEBPGPE.fontSize = 22;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.MiddleCenter;
				this.CCNEEAGFDEF.fontSize = 14;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 0.5f - 150f, 20f, 300f, 30f), this.HJAHLACNLEI(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("VideoGlitches.VideoGlitch", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUILayout.BeginHorizontal("box", new GUILayoutOption[]
			{
				GUILayout.Width((float)Screen.width)
			});
			GUILayout.Space(10f);
			if (GUILayout.Button("MENU", this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(80f)
			}))
			{
				this.JFEKALLDNPO = !this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("<<<", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 0f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			GUILayout.Label(this.HJAHLACNLEI(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("VideoGlitches.VideoGlitch", string.Empty)).ToUpper(), this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(200f)
			});
			if (GUILayout.Button(">>>", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 0f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 0;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 30f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 15f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			GUILayout.Label(this.MDPOKFEJPKO.ToString("000"), this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(40f)
			});
			GUI.contentColor = Color.white;
			GUILayout.Space(10f);
			GUILayout.EndHorizontal();
			for (int i = 0; i < this.LBAHADAEAIM.Count; i++)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = true;
					this.CLNLALBDKHK(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = false;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUILayout.BeginVertical("box", new GUILayoutOption[]
				{
					GUILayout.Width(200f)
				});
				GUILayout.Space(10f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "box");
					int num = -1;
					for (int j = 0; j < this.LBAHADAEAIM.Count; j++)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("box", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "   " + imageEffectBase2.GetType().ToString().Replace("VideoGlitches.VideoGlitch", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.MJFPNHDOABA(imageEffectBase2);
							this.KMIHILOMGHO(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(5f);
					}
					for (int k = 0; k < this.LBAHADAEAIM.Count; k++)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = !imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = false;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("No 'Video Glitches' found.", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("box", Array.Empty<GUILayoutOption>());
				GUILayout.Label("F1 - Hide/Show gui.", Array.Empty<GUILayoutOption>());
				GUILayout.Label("PageUp\nPageDown - Change effects.", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(10f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "Close console" : "Open console", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = !this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = float.PositiveInfinity;
				}
				if (GUILayout.Button("Open Web", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("http://www.ibuprogames.com/2015/07/02/video-glitches/ ‎");
				}
				if (GUILayout.Button("Quit", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUILayout.BeginVertical("box", new GUILayoutOption[]
					{
						GUILayout.Width((float)Screen.width),
						GUILayout.Height((float)(Screen.height / 4))
					});
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, true, Array.Empty<GUILayoutOption>());
					for (int l = 0; l < this.DCFGAKDAANL.Count; l++)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x002DBEE4 File Offset: 0x002DA0E4
		private void JOPDKJBAEJN(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Label("yes", new GUILayoutOption[]
			{
				GUILayout.Width(1882f)
			});
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 832f, 943f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x002DBF40 File Offset: 0x002DA140
		private void MMPBGNBPLAG(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "sid";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(979f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 384f, 1607f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "onboardingthankyoubody1";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(229f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1071f, 572f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "suttl";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(1877f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 849f, 147f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("chtss", new GUILayoutOption[]
					{
						GUILayout.Width(1171f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 534f, 182f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("</i>.", new GUILayoutOption[]
					{
						GUILayout.Width(652f)
					});
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 1004f, 144f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "body";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(887f);
					GUILayout.Label(text4, array4);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 712f, 499f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "apkshe2";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(1347f);
					GUILayout.Label(text5, array5);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1400f, 1451f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "layervideo";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Width(237f);
					GUILayout.Label(text6, array6);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 1823f, 1680f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = " recorded for the next boot";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(697f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 887f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "FadeBottom";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[1] = GUILayout.Width(1855f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1747f, 1804f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "OnRewardFirstEpisodeClick";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(1875f);
					GUILayout.Label(text9, array9);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1286f, 761f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(913f);
					GUILayout.Label(text10, array10);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 1622f, 178f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "dynamic";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[1] = GUILayout.Width(1336f);
					GUILayout.Label(text11, array11);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1342f, 832f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:", new GUILayoutOption[]
					{
						GUILayout.Width(1018f)
					});
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 869f, 836f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "  ";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[1] = GUILayout.Width(60f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 949f, 1221f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "x";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[0] = GUILayout.Width(1212f);
					GUILayout.Label(text13, array13);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 830f, 702f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = " \",";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[1] = GUILayout.Width(889f);
					GUILayout.Label(text14, array14);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1761f, 457f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(1045f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 1821f, 254f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnAllCollectableCardsDownloadFailed", new GUILayoutOption[]
					{
						GUILayout.Width(551f)
					});
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 1861f, 89f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "passrequiredtoplay";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(1016f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 1389f, 1392f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[0] = GUILayout.Width(1505f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 209f, 1970f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "common";
					GUILayoutOption[] array18 = new GUILayoutOption[1];
					array18[1] = GUILayout.Width(1548f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 678f, 1717f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("rsec", new GUILayoutOption[]
					{
						GUILayout.Width(394f)
					});
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1156f, 505f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("YYY", new GUILayoutOption[]
					{
						GUILayout.Width(158f)
					});
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 384f, 506f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "importanttitle";
					GUILayoutOption[] array19 = new GUILayoutOption[1];
					array19[1] = GUILayout.Width(1168f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1787f, 54f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("frsendhres", new GUILayoutOption[]
					{
						GUILayout.Width(609f)
					});
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 958f, 222f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ok", new GUILayoutOption[]
					{
						GUILayout.Width(1018f)
					});
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 440f, 1854f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "app42error";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[0] = GUILayout.Width(327f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1265f, 1046f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "socialjoinbody";
					GUILayoutOption[] array21 = new GUILayoutOption[1];
					array21[1] = GUILayout.Width(403f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1374f, 1432f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "smpd";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(1464f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1605f, 1443f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "cardschar";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[0] = GUILayout.Width(1337f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 390f, 1794f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "Error. ShowHideEnvironmentLayer(), environmentLayer ";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[1] = GUILayout.Width(1123f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1446f, 1305f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("authored look of ", new GUILayoutOption[]
					{
						GUILayout.Width(983f)
					});
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 414f, 667f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "_";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(1394f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 326f, 1297f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("RequestGetUserPublicProfile(): timer hit: ", new GUILayoutOption[]
					{
						GUILayout.Width(579f)
					});
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1383f, 1331f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "acb";
					GUILayoutOption[] array26 = new GUILayoutOption[1];
					array26[1] = GUILayout.Width(931f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 791f, 1583f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "analogglitch_2";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[0] = GUILayout.Width(497f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1549f, 46f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "PurchaseManagerSteam.OnBackendValidateTransactionSuccess().";
					GUILayoutOption[] array28 = new GUILayoutOption[1];
					array28[1] = GUILayout.Width(1905f);
					GUILayout.Label(text28, array28);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 1181f, 198f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "id";
					GUILayoutOption[] array29 = new GUILayoutOption[0];
					array29[0] = GUILayout.Width(1904f);
					GUILayout.Label(text29, array29);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 1419f, 1908f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x002DCCD8 File Offset: 0x002DAED8
		private void KNAEHKAMNKE(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "rid";
					GUILayoutOption[] array = new GUILayoutOption[1];
					array[1] = GUILayout.Width(1003f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1587f, 217f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("snap", new GUILayoutOption[]
					{
						GUILayout.Width(833f)
					});
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 373f, 1772f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "common";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[0] = GUILayout.Width(1716f);
					GUILayout.Label(text2, array2);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 30f, 1306f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("skinshopfiltertitle", new GUILayoutOption[]
					{
						GUILayout.Width(421f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 1999f, 1191f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("lstm", new GUILayoutOption[]
					{
						GUILayout.Width(1819f)
					});
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 278f, 1063f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "avatarcollectionsalltitle";
					GUILayoutOption[] array3 = new GUILayoutOption[1];
					array3[1] = GUILayout.Width(1115f);
					GUILayout.Label(text3, array3);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1763f, 1187f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "TryRepeatRunCustomCode():";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[1] = GUILayout.Width(1711f);
					GUILayout.Label(text4, array4);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1343f, 343f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "mps";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(361f);
					GUILayout.Label(text5, array5);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 797f, 1501f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(", ", new GUILayoutOption[]
					{
						GUILayout.Width(1550f)
					});
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1382f, 1940f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Trimming topMatchOngoing.Count by removing ", new GUILayoutOption[]
					{
						GUILayout.Width(1096f)
					});
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1234f, 1303f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "OnLiveProfileThemeBackgroundCdnSuccess";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(1124f);
					GUILayout.Label(text6, array6);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 695f, 1935f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "syn";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(1858f);
					GUILayout.Label(text7, array7);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 922f, 1346f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnPurchasingViewLeave", new GUILayoutOption[]
					{
						GUILayout.Width(404f)
					});
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1804f, 371f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(1554f)
					});
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1598f, 335f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[0] = GUILayout.Width(93f);
					GUILayout.Label(text8, array8);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 202f, 298f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("blur", new GUILayoutOption[]
					{
						GUILayout.Width(529f)
					});
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 721f, 350f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("</i>", new GUILayoutOption[]
					{
						GUILayout.Width(1017f)
					});
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1883f, 1877f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "itsub";
					GUILayoutOption[] array9 = new GUILayoutOption[1];
					array9[1] = GUILayout.Width(924f);
					GUILayout.Label(text9, array9);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 355f, 243f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "face";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[1] = GUILayout.Width(1017f);
					GUILayout.Label(text10, array10);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 689f, 1030f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "ZZZ";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[1] = GUILayout.Width(372f);
					GUILayout.Label(text11, array11);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 670f, 936f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ok", new GUILayoutOption[]
					{
						GUILayout.Width(1858f)
					});
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1613f, 1035f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "</b>";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[1] = GUILayout.Width(955f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 1750f, 441f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = " did not arrive";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(1681f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1914f, 1017f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("…", new GUILayoutOption[]
					{
						GUILayout.Width(1501f)
					});
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 665f, 1038f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "_Strength";
					GUILayoutOption[] array14 = new GUILayoutOption[1];
					array14[1] = GUILayout.Width(655f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 871f, 254f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "NNN";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[1] = GUILayout.Width(1062f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 466f, 1335f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "BackendOperationsManager.RequestSaveAvatarCollections, exception while initializing RSACryptoServiceProvider:";
					GUILayoutOption[] array16 = new GUILayoutOption[1];
					array16[1] = GUILayout.Width(772f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 146f, 1487f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "feature disabled by balance";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[0] = GUILayout.Width(1504f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 805f, 743f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "skinshopfilterbystory";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(1443f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1261f, 280f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("s", new GUILayoutOption[]
					{
						GUILayout.Width(222f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 439f, 1849f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("top", new GUILayoutOption[]
					{
						GUILayout.Width(1133f)
					});
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1255f, 1383f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("socialtop", new GUILayoutOption[]
					{
						GUILayout.Width(264f)
					});
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 891f, 540f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "importanttitle";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[1] = GUILayout.Width(710f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 1584f, 1437f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "%) with better variation from another slot:";
					GUILayoutOption[] array20 = new GUILayoutOption[1];
					array20[1] = GUILayout.Width(1883f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 1590f, 1934f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "retry";
					GUILayoutOption[] array21 = new GUILayoutOption[1];
					array21[1] = GUILayout.Width(392f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1170f, 678f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "Android";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(84f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1109f, 617f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "OnFullscreenLiveOfferContinueToCardsVolSaleMenu";
					GUILayoutOption[] array23 = new GUILayoutOption[1];
					array23[1] = GUILayout.Width(697f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1349f, 1773f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "acli22";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(696f);
					GUILayout.Label(text24, array24);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 1632f, 905f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "InitTopMatchData(): total while iterations:";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(1889f);
					GUILayout.Label(text25, array25);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 500f, 392f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x002DDA70 File Offset: 0x002DBC70
		private void PIPBMPODIKC(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(952f, 737f), UnityEngine.Random.Range(1205f, 1574f));
			}
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x002DDAC4 File Offset: 0x002DBCC4
		private void JJFCAPIAGIE(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = " scale to object ";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(824f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1312f, 1470f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(1236f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 782f, 1194f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "</i>";
					GUILayoutOption[] array3 = new GUILayoutOption[1];
					array3[1] = GUILayout.Width(1277f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 659f, 1118f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("no", new GUILayoutOption[]
					{
						GUILayout.Width(1250f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 494f, 1819f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "XXX";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[1] = GUILayout.Width(662f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 1085f, 44f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "OnStoryInterfaceHeaderHideComplete";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(488f);
					GUILayout.Label(text5, array5);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1594f, 418f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Width(1736f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1862f, 789f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[1] = GUILayout.Width(1550f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 1008f, 4f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()";
					GUILayoutOption[] array8 = new GUILayoutOption[1];
					array8[1] = GUILayout.Width(496f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1294f, 963f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "XXX";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(1907f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 979f, 1922f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "assetbundleprofiledata2";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[1] = GUILayout.Width(1600f);
					GUILayout.Label(text10, array10);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 365f, 1739f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "OnStorySplashManagerAssetsDownloadSuccess";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[0] = GUILayout.Width(1876f);
					GUILayout.Label(text11, array11);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 1462f, 1744f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "OnBackendUpdateFriendsDataSuccess";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(1143f);
					GUILayout.Label(text12, array12);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 677f, 545f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "$ct";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(1151f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1154f, 257f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "CLIENT.SCREEN.AVATAR.";
					GUILayoutOption[] array14 = new GUILayoutOption[1];
					array14[1] = GUILayout.Width(410f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 561f, 1793f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "OnSocialModeChanged";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(1613f);
					GUILayout.Label(text15, array15);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 887f, 1740f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(1500f);
					GUILayout.Label(text16, array16);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 229f, 931f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "";
					GUILayoutOption[] array17 = new GUILayoutOption[1];
					array17[1] = GUILayout.Width(1943f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 1227f, 275f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "query";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(863f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 1898f, 1527f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "lobby";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(830f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 154f, 1911f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "varConditionLocked";
					GUILayoutOption[] array20 = new GUILayoutOption[1];
					array20[1] = GUILayout.Width(1210f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 938f, 1846f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[1] = GUILayout.Width(1111f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 370f, 1386f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "gpsasst";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[1] = GUILayout.Width(185f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1167f, 1404f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "musavatar";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[0] = GUILayout.Width(65f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 520f, 1952f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "OnStorySplashManagerAdsProviderAdSuccess";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[1] = GUILayout.Width(1644f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1665f, 1672f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = ": ";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(576f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1476f, 1418f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "SceneStoryManager.StoryStep.StoryStepType.hasAvatarComponent, neither get() nor getany() nor getall() defined, but at least one of them is required.";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[0] = GUILayout.Width(666f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 835f, 281f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "OnPopupProfileCredoInputCancel";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[0] = GUILayout.Width(667f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 651f, 180f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "";
					GUILayoutOption[] array28 = new GUILayoutOption[1];
					array28[1] = GUILayout.Width(1309f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 457f, 1675f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("congratstitle", new GUILayoutOption[]
					{
						GUILayout.Width(203f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1159f, 860f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "OnAvatarScreenAssetsDownloadSuccess";
					GUILayoutOption[] array29 = new GUILayoutOption[1];
					array29[1] = GUILayout.Width(527f);
					GUILayout.Label(text29, array29);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1216f, 1103f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "fuzzy";
					GUILayoutOption[] array30 = new GUILayoutOption[0];
					array30[0] = GUILayout.Width(927f);
					GUILayout.Label(text30, array30);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1993f, 1465f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text31 = "";
					GUILayoutOption[] array31 = new GUILayoutOption[1];
					array31[1] = GUILayout.Width(1353f);
					GUILayout.Label(text31, array31);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 262f, 1590f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text32 = "clthb";
					GUILayoutOption[] array32 = new GUILayoutOption[1];
					array32[1] = GUILayout.Width(317f);
					GUILayout.Label(text32, array32);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 249f, 1260f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text33 = "CLIENT.POSTEFFECTS.NOISEDIGITAL";
					GUILayoutOption[] array33 = new GUILayoutOption[0];
					array33[0] = GUILayout.Width(1371f);
					GUILayout.Label(text33, array33);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1231f, 1705f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text34 = "";
					GUILayoutOption[] array34 = new GUILayoutOption[0];
					array34[1] = GUILayout.Width(510f);
					GUILayout.Label(text34, array34);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1064f, 320f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("F", new GUILayoutOption[]
					{
						GUILayout.Width(618f)
					});
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1004f, 1859f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text35 = "uniqueoffer2";
					GUILayoutOption[] array35 = new GUILayoutOption[1];
					array35[1] = GUILayout.Width(942f);
					GUILayout.Label(text35, array35);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 1210f, 1776f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text36 = "";
					GUILayoutOption[] array36 = new GUILayoutOption[0];
					array36[1] = GUILayout.Width(1605f);
					GUILayout.Label(text36, array36);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 758f, 697f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x002DE85C File Offset: 0x002DCA5C
		private void OPAPLDKCLPO()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC += 0;
			if (this.KOENBLJPMOA <= 959f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 1051f;
				this.DLGOAPLDOAC = 1;
			}
			if (this.slideEffectTime > 265f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.AELFPOLCIGN(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1662f;
				}
			}
			if (Input.GetKeyUp((KeyCode)128))
			{
				this.guiShow = this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)76) || Input.GetKeyUp((KeyCode)(-37)) || Input.GetKeyUp((KeyCode)(-47)) || Input.GetKeyUp((KeyCode)(-151)))
			{
				int num = 0;
				this.slideEffectTime = 236f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = true;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)(-140)) || Input.GetKeyUp((KeyCode)(-138)))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.JOJHAHFGOEI(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)(-103)) || Input.GetKeyUp((KeyCode)68))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 0) : (this.LBAHADAEAIM.Count - 0));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.GBBGGJOGOHE(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-95)))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x002DEB04 File Offset: 0x002DCD04
		private void MJFPNHDOABA(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Label("Amount", new GUILayoutOption[]
			{
				GUILayout.Width(70f)
			});
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 0f, 1f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x002DEB60 File Offset: 0x002DCD60
		private void IBEIEEMIDJD(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "XXX";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(1677f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1973f, 945f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = " CACHE API (fallback) path skipped, caching system not ready after ";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[0] = GUILayout.Width(811f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1197f, 885f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "loungeapplybtn";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[1] = GUILayout.Width(359f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1624f, 1247f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnPurchaseSuccess", new GUILayoutOption[]
					{
						GUILayout.Width(378f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 262f, 768f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "maxr";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[1] = GUILayout.Width(1543f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 1320f, 1125f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(") is null.", new GUILayoutOption[]
					{
						GUILayout.Width(1778f)
					});
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 377f, 1088f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("energyhinttitle", new GUILayoutOption[]
					{
						GUILayout.Width(1701f)
					});
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 619f, 929f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("$", new GUILayoutOption[]
					{
						GUILayout.Width(272f)
					});
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 1756f, 1004f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "cfp";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(740f);
					GUILayout.Label(text5, array5);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1244f, 1213f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "steamwaitforuseraction";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Width(1394f);
					GUILayout.Label(text6, array6);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1896f, 1410f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Choice swipe tutorial frame container not available, tutorial skipped:", new GUILayoutOption[]
					{
						GUILayout.Width(1234f)
					});
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 894f, 1387f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("_MaxOffset", new GUILayoutOption[]
					{
						GUILayout.Width(1566f)
					});
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 1876f, 19f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "OnLobbyStartFireworksEffect";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(1304f);
					GUILayout.Label(text7, array7);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1013f, 604f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "lsenvdrop";
					GUILayoutOption[] array8 = new GUILayoutOption[1];
					array8[1] = GUILayout.Width(1622f);
					GUILayout.Label(text8, array8);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 374f, 107f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "SceneLobbyManager.ShowStorySplash() - Body index is negative.";
					GUILayoutOption[] array9 = new GUILayoutOption[1];
					array9[1] = GUILayout.Width(669f);
					GUILayout.Label(text9, array9);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 418f, 211f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "value";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(120f);
					GUILayout.Label(text10, array10);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 1164f, 1153f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = ": '";
					GUILayoutOption[] array11 = new GUILayoutOption[1];
					array11[1] = GUILayout.Width(1247f);
					GUILayout.Label(text11, array11);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1335f, 171f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "_TileSize";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(692f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 856f, 361f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "Asset bundle load operation failed during parallel mode.";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(1098f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 607f, 190f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "OnChapterSnapshotsItemClose";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[1] = GUILayout.Width(974f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 182f, 375f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "shopcur";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[0] = GUILayout.Width(1620f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 641f, 1530f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("unknownerror", new GUILayoutOption[]
					{
						GUILayout.Width(1370f)
					});
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 106f, 118f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = ") delay(";
					GUILayoutOption[] array16 = new GUILayoutOption[1];
					array16[1] = GUILayout.Width(985f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 87f, 1399f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "<line-height=";
					GUILayoutOption[] array17 = new GUILayoutOption[1];
					array17[1] = GUILayout.Width(1977f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 995f, 1382f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "asp";
					GUILayoutOption[] array18 = new GUILayoutOption[1];
					array18[1] = GUILayout.Width(1892f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 145f, 1103f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "-";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(1306f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1833f, 1201f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "";
					GUILayoutOption[] array20 = new GUILayoutOption[1];
					array20[1] = GUILayout.Width(54f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 1908f, 1041f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "retry";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[0] = GUILayout.Width(1650f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 109f, 923f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "<b>";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[0] = GUILayout.Width(1588f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1927f, 1137f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "avtssnap1";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[1] = GUILayout.Width(1215f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1732f, 737f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "F0";
					GUILayoutOption[] array24 = new GUILayoutOption[1];
					array24[1] = GUILayout.Width(460f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 700f, 6f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "Frame container bundle loaded but its asset is missing or mis-named:";
					GUILayoutOption[] array25 = new GUILayoutOption[1];
					array25[1] = GUILayout.Width(1784f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1101f, 1455f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "congratstitle";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[1] = GUILayout.Width(160f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 425f, 1217f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "csnffb";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[1] = GUILayout.Width(76f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 1306f, 1142f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "slow";
					GUILayoutOption[] array28 = new GUILayoutOption[0];
					array28[1] = GUILayout.Width(1766f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 20f, 775f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "lightmodebtn1";
					GUILayoutOption[] array29 = new GUILayoutOption[1];
					array29[1] = GUILayout.Width(48f);
					GUILayout.Label(text29, array29);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 622f, 492f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "ant";
					GUILayoutOption[] array30 = new GUILayoutOption[0];
					array30[0] = GUILayout.Width(1400f);
					GUILayout.Label(text30, array30);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 171f, 1296f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnGooglePlayServicesLoginSuccess", new GUILayoutOption[]
					{
						GUILayout.Width(1722f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 1787f, 105f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnStoryInterfaceHeaderShopClick", new GUILayoutOption[]
					{
						GUILayout.Width(1832f)
					});
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 1462f, 1790f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x002DF8F8 File Offset: 0x002DDAF8
		private void EDFAPEMNFCH()
		{
			Application.logMessageReceived += this.BCAFCMEKCKL;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = false;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("lobby", this.LBAHADAEAIM.Count));
				for (int k = 1; k < this.LBAHADAEAIM.Count; k += 0)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 1699f;
					audioSource.loop = (this.slideEffectTime > 1785f);
					audioSource.PlayDelayed(801f);
					if (this.slideEffectTime == 1809f)
					{
						this.slideEffectTime = (this.musicClip.length + 63f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("p");
			}
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x002DFB48 File Offset: 0x002DDD48
		private void ONFDMCHBEFH(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(75f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 1579f, 933f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x002DFBA4 File Offset: 0x002DDDA4
		private void PDMEKGBKPIM(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("ok" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("socialsimplegiftcollect" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("no" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("p" + ECCGLJGCBGC);
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x002DFC14 File Offset: 0x002DDE14
		private void BHPGDHJACPM()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.MiddleCenter;
				this.NMLJKEBPGPE.fontSize = 97;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.MiddleRight;
				this.CCNEEAGFDEF.fontSize = 100;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1304f - 1062f, 370f, 1886f, 1958f), this.NMOOGLKLPIN(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("nam", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUIStyle style = "XXX";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width((float)Screen.width);
			GUILayout.BeginHorizontal(style, array);
			GUILayout.Space(591f);
			if (GUILayout.Button(" ", this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(0f)
			}))
			{
				this.JFEKALLDNPO = !this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("  ", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 928f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text = this.EEKEKOHIIDC(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("psk", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[1];
			array2[1] = GUILayout.Width(603f);
			GUILayout.Label(text, ccneeagfdef, array2);
			if (GUILayout.Button("tbits2", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 1450f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0)
				{
					this.KHEAPHJLFJM += 0;
				}
				else
				{
					this.KHEAPHJLFJM = 0;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 403f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 1517f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text2 = this.MDPOKFEJPKO.ToString("newuseraddrequest3");
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[0] = GUILayout.Width(459f);
			GUILayout.Label(text2, ccneeagfdef2, array3);
			GUI.contentColor = Color.white;
			GUILayout.Space(249f);
			GUILayout.EndHorizontal();
			for (int i = 1; i < this.LBAHADAEAIM.Count; i++)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = true;
					this.IDIHDMJCELH(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = false;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style2 = "OnBackendRequestCustomProfileSuccess";
				GUILayoutOption[] array4 = new GUILayoutOption[0];
				array4[0] = GUILayout.Width(900f);
				GUILayout.BeginVertical(style2, array4);
				GUILayout.Space(428f);
				if (this.LBAHADAEAIM.Count > 1)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "savetocloudbtn");
					int num = -1;
					for (int j = 1; j < this.LBAHADAEAIM.Count; j++)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("/", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "OnPopupProfileSaveCutsceneInputCancel" + imageEffectBase2.GetType().ToString().Replace("socialfriendevents", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.ONFDMCHBEFH(imageEffectBase2);
							this.KOCLPPKADOH(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(832f);
					}
					for (int k = 1; k < this.LBAHADAEAIM.Count; k++)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = true;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("FirebaseAnalyticsManager.Initialize() exception:", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("", Array.Empty<GUILayoutOption>());
				GUILayout.Label("chass", Array.Empty<GUILayoutOption>());
				GUILayout.Label("p", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(367f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "_notif" : "json", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = !this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 1973f;
				}
				if (GUILayout.Button("lsenvattempt", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("");
				}
				if (GUILayout.Button("OnUpdateSocialEventsCounter", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style3 = "a";
					GUILayoutOption[] array5 = new GUILayoutOption[6];
					array5[1] = GUILayout.Width((float)Screen.width);
					array5[1] = GUILayout.Height((float)(Screen.height / 3));
					GUILayout.BeginVertical(style3, array5);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, false, Array.Empty<GUILayoutOption>());
					for (int l = 0; l < this.DCFGAKDAANL.Count; l += 0)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x002E0264 File Offset: 0x002DE464
		private void NOGMIFLFIAA(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Label("PurchaseManagerSteam.GetProductData(): Not initialized.", new GUILayoutOption[]
			{
				GUILayout.Width(1721f)
			});
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 229f, 628f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x002E02C0 File Offset: 0x002DE4C0
		private void CBIDAMAGEPM(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1636f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 1523f, 879f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x002E031C File Offset: 0x002DE51C
		private void KBKLPEPOLDI()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.MiddleCenter;
				this.NMLJKEBPGPE.fontSize = 62;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.UpperRight;
				this.CCNEEAGFDEF.fontSize = -75;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 127f - 1882f, 436f, 1200f, 94f), this.GHFEIKAHKLG(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("char", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUIStyle style = "،";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width((float)Screen.width);
			GUILayout.BeginHorizontal(style, array);
			GUILayout.Space(1743f);
			if (GUILayout.Button("loungelockedinfo", this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(1356f)
			}))
			{
				this.JFEKALLDNPO = this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("ccc", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 442f;
				if (this.KHEAPHJLFJM > 1)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 0;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text = this.LHLCDGOMECI(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("saveslotsoptioncopy", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(617f);
			GUILayout.Label(text, ccneeagfdef, array2);
			if (GUILayout.Button("OnGooglePlayServicesLoginSuccess", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 397f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1)
				{
					this.KHEAPHJLFJM += 0;
				}
				else
				{
					this.KHEAPHJLFJM = 1;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 1299f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 1444f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text2 = this.MDPOKFEJPKO.ToString("Asset bundle load operation failed during parallel mode.");
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[1];
			array3[1] = GUILayout.Width(1592f);
			GUILayout.Label(text2, ccneeagfdef2, array3);
			GUI.contentColor = Color.white;
			GUILayout.Space(1781f);
			GUILayout.EndHorizontal();
			for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = true;
					this.NEEGJEMOIIG(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = true;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style2 = "OnChoiceExtendedPanelSlideShownComplete";
				GUILayoutOption[] array4 = new GUILayoutOption[0];
				array4[1] = GUILayout.Width(795f);
				GUILayout.BeginVertical(style2, array4);
				GUILayout.Space(6f);
				if (this.LBAHADAEAIM.Count > 1)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "OnLobbyStoryManagerDownloadSplashScreenFailed");
					int num = -1;
					for (int j = 1; j < this.LBAHADAEAIM.Count; j++)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("ok", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "..." + imageEffectBase2.GetType().ToString().Replace(" ms -> ", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.JOPDKJBAEJN(imageEffectBase2);
							this.DPJPMBJKONJ(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(807f);
					}
					for (int k = 1; k < this.LBAHADAEAIM.Count; k += 0)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = !imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = false;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("tids", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("avatarcollectionstutor6title", Array.Empty<GUILayoutOption>());
				GUILayout.Label("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()", Array.Empty<GUILayoutOption>());
				GUILayout.Label("AnthologySave.AddAvatarComponent(), unsupported wardrobe index:", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(1930f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "sslind" : "profilenametitleshort", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 1478f;
				}
				if (GUILayout.Button("XXX", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("");
				}
				if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style3 = "OnPurchasingNotInitialized";
					GUILayoutOption[] array5 = new GUILayoutOption[5];
					array5[1] = GUILayout.Width((float)Screen.width);
					array5[1] = GUILayout.Height((float)(Screen.height / 6));
					GUILayout.BeginVertical(style3, array5);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, true, false, Array.Empty<GUILayoutOption>());
					for (int l = 0; l < this.DCFGAKDAANL.Count; l++)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x002E096C File Offset: 0x002DEB6C
		private void DHNDICIEGEE()
		{
			Application.logMessageReceived += this.EFLMHKDLFCA;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = false;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j += 0)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("-", this.LBAHADAEAIM.Count));
				for (int k = 0; k < this.LBAHADAEAIM.Count; k += 0)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 1923f;
					audioSource.loop = (this.slideEffectTime > 1732f);
					audioSource.PlayDelayed(355f);
					if (this.slideEffectTime == 421f)
					{
						this.slideEffectTime = (this.musicClip.length + 101f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("yes");
			}
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x002E0BBC File Offset: 0x002DEDBC
		private void GDHFEHGIKNC(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "XXX";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(528f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 656f, 1285f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x002E0C18 File Offset: 0x002DEE18
		private void HDMGPBIOJBG(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Label("asp", new GUILayoutOption[]
			{
				GUILayout.Width(308f)
			});
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 175f, 298f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x002E0C71 File Offset: 0x002DEE71
		private string EEKEKOHIIDC(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "PopupCardOptions.PurchaseProductWeb(): productData or productBalanceData is null", "ok");
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x002E0C84 File Offset: 0x002DEE84
		private void DPJPMBJKONJ(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = " ";
					GUILayoutOption[] array = new GUILayoutOption[1];
					array[1] = GUILayout.Width(846f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 907f, 725f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = " \",";
					GUILayoutOption[] array2 = new GUILayoutOption[1];
					array2[1] = GUILayout.Width(834f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1161f, 1656f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "_OpacityMoire";
					GUILayoutOption[] array3 = new GUILayoutOption[1];
					array3[1] = GUILayout.Width(1958f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 515f, 41f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "AssetBundleLoadLevelOperation: ";
					GUILayoutOption[] array4 = new GUILayoutOption[1];
					array4[1] = GUILayout.Width(1100f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 13f, 1737f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "ok";
					GUILayoutOption[] array5 = new GUILayoutOption[1];
					array5[1] = GUILayout.Width(1103f);
					GUILayout.Label(text5, array5);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 121f, 776f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "@SD";
					GUILayoutOption[] array6 = new GUILayoutOption[1];
					array6[1] = GUILayout.Width(512f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1061f, 1769f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "WWW";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[1] = GUILayout.Width(1042f);
					GUILayout.Label(text7, array7);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1781f, 367f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "_ru";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[0] = GUILayout.Width(736f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 665f, 1047f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("bdid", new GUILayoutOption[]
					{
						GUILayout.Width(646f)
					});
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 719f, 167f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "__data";
					GUILayoutOption[] array9 = new GUILayoutOption[1];
					array9[1] = GUILayout.Width(1948f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 650f, 238f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "recommendationAlgorithmBalance";
					GUILayoutOption[] array10 = new GUILayoutOption[1];
					array10[1] = GUILayout.Width(1975f);
					GUILayout.Label(text10, array10);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1989f, 1385f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "vhspause";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[0] = GUILayout.Width(239f);
					GUILayout.Label(text11, array11);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 92f, 197f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = " ";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[0] = GUILayout.Width(1361f);
					GUILayout.Label(text12, array12);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1734f, 1215f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "OnStoryChoiceClick";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[0] = GUILayout.Width(504f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1676f, 737f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(">", new GUILayoutOption[]
					{
						GUILayout.Width(620f)
					});
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 1693f, 323f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "sslind";
					GUILayoutOption[] array14 = new GUILayoutOption[1];
					array14[1] = GUILayout.Width(93f);
					GUILayout.Label(text14, array14);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 764f, 1932f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "$ENVFADE";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(1716f);
					GUILayout.Label(text15, array15);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 631f, 1678f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "Color noise";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(115f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 1902f, 1388f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Avatar pack (hidden or exposed) has been LOADED:", new GUILayoutOption[]
					{
						GUILayout.Width(1962f)
					});
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 431f, 854f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "HKDF output capped at 255 * HashLen bytes.";
					GUILayoutOption[] array17 = new GUILayoutOption[1];
					array17[1] = GUILayout.Width(1820f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 361f, 1260f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "socialgiftreceviedfromtitle";
					GUILayoutOption[] array18 = new GUILayoutOption[1];
					array18[1] = GUILayout.Width(979f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1132f, 1065f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "<i>";
					GUILayoutOption[] array19 = new GUILayoutOption[1];
					array19[1] = GUILayout.Width(1531f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 44f, 855f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "envlsav";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(1886f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1559f, 1381f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnStoryInterfaceHeaderAutoReadEnable", new GUILayoutOption[]
					{
						GUILayout.Width(233f)
					});
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 191f, 1318f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "cardcollectcardismissing";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[0] = GUILayout.Width(541f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1469f, 1881f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "DDD";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(1758f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 96f, 1322f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "JSON Parse: Quotation marks seems to be messed up.";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[0] = GUILayout.Width(421f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 20f, 60f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "OnBackendInitiateSteamTransactionSuccess";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(1312f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 558f, 1084f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "p";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(328f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 835f, 1212f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("socialtop", new GUILayoutOption[]
					{
						GUILayout.Width(1331f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 544f, 1262f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = ")";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[1] = GUILayout.Width(1816f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1959f, 641f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "OnTryToFireNoteshowTimer";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[0] = GUILayout.Width(157f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 990f, 1124f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("StoryChatManager.Initialize(), _chatMeta is null", new GUILayoutOption[]
					{
						GUILayout.Width(503f)
					});
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 1017f, 1842f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = " focusOpened=";
					GUILayoutOption[] array28 = new GUILayoutOption[0];
					array28[0] = GUILayout.Width(1352f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 1810f, 485f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "</i>";
					GUILayoutOption[] array29 = new GUILayoutOption[0];
					array29[0] = GUILayout.Width(820f);
					GUILayout.Label(text29, array29);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1069f, 1454f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(" ", new GUILayoutOption[]
					{
						GUILayout.Width(1639f)
					});
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1623f, 1196f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = " ";
					GUILayoutOption[] array30 = new GUILayoutOption[1];
					array30[1] = GUILayout.Width(1143f);
					GUILayout.Label(text30, array30);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 905f, 486f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("spectrumovr_2", new GUILayoutOption[]
					{
						GUILayout.Width(1223f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 97f, 1370f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text31 = "〈";
					GUILayoutOption[] array31 = new GUILayoutOption[0];
					array31[1] = GUILayout.Width(269f);
					GUILayout.Label(text31, array31);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 539f, 1238f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x002E1A1C File Offset: 0x002DFC1C
		private void ICICKCBJMFF(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "p";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(276f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 95f, 448f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x002E1A78 File Offset: 0x002DFC78
		private void CLNLALBDKHK(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(-0.75f, 0.75f), UnityEngine.Random.Range(-0.75f, 0.75f));
			}
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x002E1ACC File Offset: 0x002DFCCC
		private void FBPINOOMMJL(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "loungetokensyouhave";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(1373f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1034f, 1699f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "/";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(151f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1847f, 1450f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(1057f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 278f, 880f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "chapterrewindhint0";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(1702f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 1118f, 1877f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Account.MarkAllStoriesAsSynced(): marking as unsynced client anthology ", new GUILayoutOption[]
					{
						GUILayout.Width(200f)
					});
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 719f, 310f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "</b>";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(286f);
					GUILayout.Label(text5, array5);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1779f, 587f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "\"";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(1301f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1797f, 1276f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "\"";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(1935f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 1877f, 1750f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "adserrorbody";
					GUILayoutOption[] array8 = new GUILayoutOption[1];
					array8[1] = GUILayout.Width(779f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1311f, 1790f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "layervideo";
					GUILayoutOption[] array9 = new GUILayoutOption[1];
					array9[1] = GUILayout.Width(1675f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1077f, 1398f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = ", resetting to zero.";
					GUILayoutOption[] array10 = new GUILayoutOption[1];
					array10[1] = GUILayout.Width(1605f);
					GUILayout.Label(text10, array10);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 406f, 837f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "lck";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[0] = GUILayout.Width(1242f);
					GUILayout.Label(text11, array11);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 993f, 1921f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "OnLiveProfileThemeBackgroundCdnFailed";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(731f);
					GUILayout.Label(text12, array12);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 780f, 1209f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "";
					GUILayoutOption[] array13 = new GUILayoutOption[1];
					array13[1] = GUILayout.Width(1172f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 351f, 929f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "preview";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[1] = GUILayout.Width(357f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 283f, 1954f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "$";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[0] = GUILayout.Width(1169f);
					GUILayout.Label(text15, array15);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 1491f, 1562f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = ", shopcur:";
					GUILayoutOption[] array16 = new GUILayoutOption[1];
					array16[1] = GUILayout.Width(366f);
					GUILayout.Label(text16, array16);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1627f, 41f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("HD", new GUILayoutOption[]
					{
						GUILayout.Width(1863f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 1399f, 692f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "$PLAYMUS";
					GUILayoutOption[] array17 = new GUILayoutOption[1];
					array17[1] = GUILayout.Width(850f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 381f, 1878f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "Could not find an existent component for tryAvatarConfig/face, forcing default option.";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(254f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 957f, 680f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = ".";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(1061f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1662f, 1654f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "OnSettingsPopupCloseAndNeedToRestartGame";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(1183f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 14f, 571f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "face";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[1] = GUILayout.Width(861f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1941f, 1560f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "XXX";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[0] = GUILayout.Width(621f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 1898f, 1003f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = " ";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[1] = GUILayout.Width(86f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1833f, 148f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "socialrequestfriendfail";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(1597f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 814f, 1052f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "x";
					GUILayoutOption[] array25 = new GUILayoutOption[1];
					array25[1] = GUILayout.Width(844f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 880f, 316f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "nick";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[0] = GUILayout.Width(1006f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1545f, 1529f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[1] = GUILayout.Width(89f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 849f, 1123f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("smps", new GUILayoutOption[]
					{
						GUILayout.Width(1570f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 712f, 1206f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "OnLobbyStartFireworksEffectAutoHide";
					GUILayoutOption[] array28 = new GUILayoutOption[1];
					array28[1] = GUILayout.Width(1499f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1287f, 1641f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("profRand", new GUILayoutOption[]
					{
						GUILayout.Width(1357f)
					});
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1877f, 190f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(619f)
					});
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 630f, 1339f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "no";
					GUILayoutOption[] array29 = new GUILayoutOption[1];
					array29[1] = GUILayout.Width(341f);
					GUILayout.Label(text29, array29);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 491f, 766f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "continue";
					GUILayoutOption[] array30 = new GUILayoutOption[0];
					array30[1] = GUILayout.Width(184f);
					GUILayout.Label(text30, array30);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 229f, 1816f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("seasoncompletedesc", new GUILayoutOption[]
					{
						GUILayout.Width(400f)
					});
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1905f, 1762f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text31 = "apkshe2";
					GUILayoutOption[] array31 = new GUILayoutOption[1];
					array31[1] = GUILayout.Width(286f);
					GUILayout.Label(text31, array31);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 192f, 1724f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("anthologycompletetitle", new GUILayoutOption[]
					{
						GUILayout.Width(1517f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 298f, 1785f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text32 = "profilenametitleshort";
					GUILayoutOption[] array32 = new GUILayoutOption[1];
					array32[1] = GUILayout.Width(458f);
					GUILayout.Label(text32, array32);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 696f, 1826f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x002E2864 File Offset: 0x002E0A64
		private void LLGBJHCIIGA()
		{
			Application.logMessageReceived += this.ANOMGDOBBGI;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = false;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 0; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("OnStoryInterfaceButtonUndoClick", this.LBAHADAEAIM.Count));
				for (int k = 1; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 1497f;
					audioSource.loop = (this.slideEffectTime > 1374f);
					audioSource.PlayDelayed(532f);
					if (this.slideEffectTime == 841f)
					{
						this.slideEffectTime = (this.musicClip.length + 1960f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("file://");
			}
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x002D9AF6 File Offset: 0x002D7CF6
		private void ELGAOFFOLPP()
		{
			Application.logMessageReceived -= this.BCAFCMEKCKL;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x002E2AB4 File Offset: 0x002E0CB4
		private void JPEKMDDFFEJ()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.MiddleLeft;
				this.NMLJKEBPGPE.fontSize = 29;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.LowerLeft;
				this.CCNEEAGFDEF.fontSize = 81;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1592f - 1284f, 1264f, 763f, 934f), this.HJAHLACNLEI(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace(")", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUILayout.BeginHorizontal(",", new GUILayoutOption[]
			{
				GUILayout.Width((float)Screen.width)
			});
			GUILayout.Space(1083f);
			string text = "ChoiceExtendedOneToManyManager.Initialize() - choice type not supported:";
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(363f);
			if (GUILayout.Button(text, ccneeagfdef, array))
			{
				this.JFEKALLDNPO = this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button(":", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 591f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text2 = this.NMOOGLKLPIN(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("x", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(1475f);
			GUILayout.Label(text2, ccneeagfdef2, array2);
			if (GUILayout.Button("energyhintbody", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 1064f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 0;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 682f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 1276f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text3 = this.MDPOKFEJPKO.ToString("    cand '");
			GUIStyle ccneeagfdef3 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[1];
			array3[1] = GUILayout.Width(1367f);
			GUILayout.Label(text3, ccneeagfdef3, array3);
			GUI.contentColor = Color.white;
			GUILayout.Space(1182f);
			GUILayout.EndHorizontal();
			for (int i = 1; i < this.LBAHADAEAIM.Count; i++)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = false;
					this.KDLKAKKALCE(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = true;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style = "null";
				GUILayoutOption[] array4 = new GUILayoutOption[1];
				array4[1] = GUILayout.Width(485f);
				GUILayout.BeginVertical(style, array4);
				GUILayout.Space(961f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, ">");
					int num = -1;
					for (int j = 0; j < this.LBAHADAEAIM.Count; j += 0)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("PremiumChoicePurchased(1) - Could not parse choice data:", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "priceCurrencyCode" + imageEffectBase2.GetType().ToString().Replace(" far card(s), unloading unused assets", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.ICICKCBJMFF(imageEffectBase2);
							this.KNAEHKAMNKE(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(441f);
					}
					for (int k = 0; k < this.LBAHADAEAIM.Count; k += 0)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = !imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = false;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("npcp", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("</b>", Array.Empty<GUILayoutOption>());
				GUILayout.Label("null", Array.Empty<GUILayoutOption>());
				GUILayout.Label("sutta", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(979f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "" : "congratstitle", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 158f;
				}
				if (GUILayout.Button("{tk}", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("a_web");
				}
				if (GUILayout.Button("<i>", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style2 = "avatarcollectionstutor1body";
					GUILayoutOption[] array5 = new GUILayoutOption[1];
					array5[1] = GUILayout.Width((float)Screen.width);
					array5[1] = GUILayout.Height((float)(Screen.height / 4));
					GUILayout.BeginVertical(style2, array5);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, false, Array.Empty<GUILayoutOption>());
					for (int l = 1; l < this.DCFGAKDAANL.Count; l++)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x002E3104 File Offset: 0x002E1304
		private void JLGGJKHGFCO(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("onboardingthankyoubody0" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("?" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)7)
			{
				this.DCFGAKDAANL.Add("ok" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("" + ECCGLJGCBGC);
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x002E3172 File Offset: 0x002E1372
		private string HJAHLACNLEI(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "((?<=\\p{Ll})\\p{Lu})|((?!\\A)\\p{Lu}(?>\\p{Ll}))", " $0");
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x002E3184 File Offset: 0x002E1384
		private void NIKBFENFMID()
		{
			Application.logMessageReceived += this.EDEFDPKACIC;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = false;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("OnFullscreenCardOptionClickLobby", this.LBAHADAEAIM.Count));
				for (int k = 1; k < this.LBAHADAEAIM.Count; k += 0)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 577f;
					audioSource.loop = (this.slideEffectTime > 502f);
					audioSource.PlayDelayed(825f);
					if (this.slideEffectTime == 850f)
					{
						this.slideEffectTime = (this.musicClip.length + 1209f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("</i>");
			}
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x002E33D4 File Offset: 0x002E15D4
		private void MKBADGCCNDJ()
		{
			Application.logMessageReceived += this.OPKKPHKOPPI;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = true;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 0; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("OnAvatarScreenClosed", this.LBAHADAEAIM.Count));
				for (int k = 1; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 708f;
					audioSource.loop = (this.slideEffectTime > 1037f);
					audioSource.PlayDelayed(1640f);
					if (this.slideEffectTime == 605f)
					{
						this.slideEffectTime = (this.musicClip.length + 1324f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("OnSketchViewAssetBundleFolderInitializeSuccess");
			}
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x002E3624 File Offset: 0x002E1824
		private void MOAHMBJJGOH()
		{
			Application.logMessageReceived += this.ANOMGDOBBGI;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = true;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j += 0)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("hoursshort", this.LBAHADAEAIM.Count));
				for (int k = 0; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 1432f;
					audioSource.loop = (this.slideEffectTime > 650f);
					audioSource.PlayDelayed(439f);
					if (this.slideEffectTime == 1067f)
					{
						this.slideEffectTime = (this.musicClip.length + 704f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("episode");
			}
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x002E3874 File Offset: 0x002E1A74
		private void NEEGJEMOIIG(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(875f, 41f), UnityEngine.Random.Range(1965f, 918f));
			}
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x002E38C8 File Offset: 0x002E1AC8
		private void CEHPNJKGGBO(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "OnFriendsPopupManagerAcceptClick";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(713f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 326f, 1436f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x002E3924 File Offset: 0x002E1B24
		private void BKLLPIBAGGO()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC++;
			if (this.KOENBLJPMOA <= 1621f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 1358f;
				this.DLGOAPLDOAC = 1;
			}
			if (this.slideEffectTime > 1703f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 1) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.IDIHDMJCELH(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 451f;
				}
			}
			if (Input.GetKeyUp((KeyCode)(-122)))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp(KeyCode.Greater) || Input.GetKeyUp((KeyCode)(-67)) || Input.GetKeyUp(KeyCode.Colon) || Input.GetKeyUp((KeyCode)185))
			{
				int num = 0;
				this.slideEffectTime = 1039f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = true;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)199) || Input.GetKeyUp((KeyCode)(-146)))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 1) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.AELFPOLCIGN(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)29) || Input.GetKeyUp((KeyCode)(-156)))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 0) : (this.LBAHADAEAIM.Count - 1));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.KECBIKDGCPP(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)15))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x002E3BCB File Offset: 0x002E1DCB
		private string GHFEIKAHKLG(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "socialdonotdisturb0", "");
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x002E3BE0 File Offset: 0x002E1DE0
		private void OEFAMBCLLAN(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("ok" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("$PLAYVOICEOVER" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)7)
			{
				this.DCFGAKDAANL.Add("\\\"" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add(") + is present, creating anthology save for anthology " + ECCGLJGCBGC);
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x002E3C50 File Offset: 0x002E1E50
		private void JILHEGGHJGH(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("ltwt" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("Critical error, type not implemented in ProcessAssetBundleLoadAssetOperationRequest():" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)7)
			{
				this.DCFGAKDAANL.Add("black" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("gcdsch" + ECCGLJGCBGC);
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x002E3CC0 File Offset: 0x002E1EC0
		private void NJINDDEAIDA()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC++;
			if (this.KOENBLJPMOA <= 1657f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 1302f;
				this.DLGOAPLDOAC = 0;
			}
			if (this.slideEffectTime > 629f && this.LBAHADAEAIM.Count > 1)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 0) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.EPJOLOLFBMG(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1370f;
				}
			}
			if (Input.GetKeyUp((KeyCode)149))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)(-182)) || Input.GetKeyUp((KeyCode)18) || Input.GetKeyUp((KeyCode)(-44)) || Input.GetKeyUp((KeyCode)15))
			{
				int num = 1;
				this.slideEffectTime = 1419f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i++)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = false;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)143) || Input.GetKeyUp((KeyCode)180))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 0) ? (num + 0) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.EPJOLOLFBMG(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.I))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 0) : (this.LBAHADAEAIM.Count - 1));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.NEEGJEMOIIG(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-9)))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x002E3F68 File Offset: 0x002E2168
		private void ELHFLJJKGFM(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1475f, 1454f), UnityEngine.Random.Range(694f, 1291f));
			}
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x002E3FBC File Offset: 0x002E21BC
		private void OPKKPHKOPPI(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("fps60" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("rwd" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)7)
			{
				this.DCFGAKDAANL.Add("" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("[" + ECCGLJGCBGC);
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x002E402C File Offset: 0x002E222C
		private void FJFMKBMBNGP(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "$";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(868f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 624f, 682f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "cid";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(720f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1819f, 1340f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[1] = GUILayout.Width(754f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1452f, 3f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "OnBackendInitiateSteamTransactionFailed";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(1851f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 1762f, 1678f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[1] = GUILayout.Width(1120f);
					GUILayout.Label(text5, array5);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 438f, 1273f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("sgk", new GUILayoutOption[]
					{
						GUILayout.Width(1393f)
					});
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 374f, 1102f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "energyhinttitle";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(978f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1000f, 162f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "@";
					GUILayoutOption[] array7 = new GUILayoutOption[1];
					array7[1] = GUILayout.Width(179f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 518f, 827f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "OnApplicationFocusBasicSyncSuccess";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[0] = GUILayout.Width(1065f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 576f, 1544f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = " not found.";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(1530f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 328f, 8f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "Collections/";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(927f);
					GUILayout.Label(text10, array10);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1910f, 863f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(335f)
					});
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 779f, 1513f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("sgk", new GUILayoutOption[]
					{
						GUILayout.Width(936f)
					});
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 228f, 404f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "blur";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[1] = GUILayout.Width(161f);
					GUILayout.Label(text11, array11);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1564f, 1126f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "OnPurchaseFailed";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[0] = GUILayout.Width(155f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 186f, 51f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnUserpassLoginFailed", new GUILayoutOption[]
					{
						GUILayout.Width(1828f)
					});
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 1703f, 1858f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "sp0";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(180f);
					GUILayout.Label(text13, array13);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1478f, 465f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("\"", new GUILayoutOption[]
					{
						GUILayout.Width(783f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 323f, 1486f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = " (";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[0] = GUILayout.Width(1231f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 471f, 452f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = ")";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[0] = GUILayout.Width(321f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 770f, 1461f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(1401f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1837f, 1523f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "errortitle";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[1] = GUILayout.Width(1210f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 1515f, 297f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "digitalglitchovr";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(1215f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 314f, 1712f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = ")";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[1] = GUILayout.Width(1786f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 413f, 858f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("-", new GUILayoutOption[]
					{
						GUILayout.Width(189f)
					});
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1832f, 1862f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("acomp1", new GUILayoutOption[]
					{
						GUILayout.Width(574f)
					});
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1492f, 1482f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("SceneLobbyManager.UpdateAnthologiesHints() - exception when adding anthology based on (add last 3 played anthologies):", new GUILayoutOption[]
					{
						GUILayout.Width(224f)
					});
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 688f, 285f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "wind";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(1290f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 700f, 10f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "HideDisclaimerImpers";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[1] = GUILayout.Width(179f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1785f, 528f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("XXX", new GUILayoutOption[]
					{
						GUILayout.Width(636f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 199f, 630f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "string_not_found";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(1449f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1379f, 1720f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "SceneLobbyManager2.OnReloadDelayed() CustomCodeUrlsHaveBeenPinged && DepotsUrlsHaveBeenPinged: break";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[1] = GUILayout.Width(716f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 824f, 1553f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[1] = GUILayout.Width(1171f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 1726f, 609f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "$ENVSET";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(281f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 390f, 1591f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "lck";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[1] = GUILayout.Width(908f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 169f, 1249f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[0] = GUILayout.Width(1990f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 1027f, 551f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "ltt";
					GUILayoutOption[] array28 = new GUILayoutOption[1];
					array28[1] = GUILayout.Width(1467f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1474f, 1701f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "";
					GUILayoutOption[] array29 = new GUILayoutOption[0];
					array29[1] = GUILayout.Width(1136f);
					GUILayout.Label(text29, array29);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 242f, 1126f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "hcfc";
					GUILayoutOption[] array30 = new GUILayoutOption[0];
					array30[0] = GUILayout.Width(595f);
					GUILayout.Label(text30, array30);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 1328f, 1867f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x002E4DC4 File Offset: 0x002E2FC4
		private void PJIOJHOMBCB()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC += 0;
			if (this.KOENBLJPMOA <= 1117f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 453f;
				this.DLGOAPLDOAC = 1;
			}
			if (this.slideEffectTime > 1609f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1) ? (this.KHEAPHJLFJM + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.EPJOLOLFBMG(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1860f;
				}
			}
			if (Input.GetKeyUp((KeyCode)(-10)))
			{
				this.guiShow = this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)187) || Input.GetKeyUp((KeyCode)186) || Input.GetKeyUp((KeyCode)14) || Input.GetKeyUp((KeyCode)5))
			{
				int num = 1;
				this.slideEffectTime = 467f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = true;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)(-192)) || Input.GetKeyUp((KeyCode)(-36)))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 0) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.ELHFLJJKGFM(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)(-113)) || Input.GetKeyUp((KeyCode)4))
				{
					this.KHEAPHJLFJM = ((num > 0) ? (num - 1) : (this.LBAHADAEAIM.Count - 1));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.JOJHAHFGOEI(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)66))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x002E506B File Offset: 0x002E326B
		private string NMOOGLKLPIN(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "timeoutwarning", "XXX");
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x002E507D File Offset: 0x002E327D
		private void NEKHLHGBMBP()
		{
			Application.logMessageReceived -= this.ANOMGDOBBGI;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x002E509C File Offset: 0x002E329C
		private void NOACBMMINBL()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.LowerRight;
				this.NMLJKEBPGPE.fontSize = 18;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.MiddleRight;
				this.CCNEEAGFDEF.fontSize = -58;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1400f - 1928f, 716f, 70f, 1110f), this.JJJPKCNKECJ(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("sfxtimeoutwarning", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUILayout.BeginHorizontal("wofrewardmsg0", new GUILayoutOption[]
			{
				GUILayout.Width((float)Screen.width)
			});
			GUILayout.Space(377f);
			string text = "SceneLobbyManager2._DownloadCardsPool(): nothing to download around scroll index ";
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(1800f);
			if (GUILayout.Button(text, ccneeagfdef, array))
			{
				this.JFEKALLDNPO = !this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("small", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 517f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM -= 0;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text2 = this.HPBKDBMDBNP(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("OnSketchThumbnailEditTitle", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1450f);
			GUILayout.Label(text2, ccneeagfdef2, array2);
			if (GUILayout.Button(" msg=", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 1186f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 0;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 1368f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 466f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text3 = this.MDPOKFEJPKO.ToString("");
			GUIStyle ccneeagfdef3 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[0] = GUILayout.Width(1997f);
			GUILayout.Label(text3, ccneeagfdef3, array3);
			GUI.contentColor = Color.white;
			GUILayout.Space(633f);
			GUILayout.EndHorizontal();
			for (int i = 1; i < this.LBAHADAEAIM.Count; i++)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = false;
					this.ELFPILHKOMH(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = true;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style = "";
				GUILayoutOption[] array4 = new GUILayoutOption[1];
				array4[1] = GUILayout.Width(377f);
				GUILayout.BeginVertical(style, array4);
				GUILayout.Space(703f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "eventended");
					int num = -1;
					for (int j = 1; j < this.LBAHADAEAIM.Count; j++)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical(".", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "_StripeCount" + imageEffectBase2.GetType().ToString().Replace("bundle ", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.KHFIFGADNMA(imageEffectBase2);
							this.DFKNDOMNFLJ(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(1958f);
					}
					for (int k = 1; k < this.LBAHADAEAIM.Count; k++)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = true;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("cch", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("spinsbuttoncustomize", Array.Empty<GUILayoutOption>());
				GUILayout.Label("uid", Array.Empty<GUILayoutOption>());
				GUILayout.Label("AvatarCollectionsItem.OnAvatarCollectionSelect(): index out of range", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(1436f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "OnStoryChoiceClick" : "avtssnap", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = !this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 100f;
				}
				if (GUILayout.Button("", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("ok");
				}
				if (GUILayout.Button("\"", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style2 = "";
					GUILayoutOption[] array5 = new GUILayoutOption[8];
					array5[0] = GUILayout.Width((float)Screen.width);
					array5[1] = GUILayout.Height((float)(Screen.height / 6));
					GUILayout.BeginVertical(style2, array5);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, false, Array.Empty<GUILayoutOption>());
					for (int l = 0; l < this.DCFGAKDAANL.Count; l++)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x002E56EC File Offset: 0x002E38EC
		private void OHHHLCLEMGB()
		{
			Application.logMessageReceived += this.EDEFDPKACIC;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = true;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("not", this.LBAHADAEAIM.Count));
				for (int k = 1; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 177f;
					audioSource.loop = (this.slideEffectTime > 1340f);
					audioSource.PlayDelayed(1649f);
					if (this.slideEffectTime == 699f)
					{
						this.slideEffectTime = (this.musicClip.length + 514f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("aindas2");
			}
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x002E593C File Offset: 0x002E3B3C
		private void BKFCGNCKFEC()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC++;
			if (this.KOENBLJPMOA <= 514f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 217f;
				this.DLGOAPLDOAC = 1;
			}
			if (this.slideEffectTime > 941f && this.LBAHADAEAIM.Count > 1)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 1) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.EPJOLOLFBMG(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 996f;
				}
			}
			if (Input.GetKeyUp((KeyCode)184))
			{
				this.guiShow = this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)(-178)) || Input.GetKeyUp(KeyCode.Comma) || Input.GetKeyUp((KeyCode)74) || Input.GetKeyUp((KeyCode)(-169)))
			{
				int num = 1;
				this.slideEffectTime = 908f;
				for (int i = 0; i < this.LBAHADAEAIM.Count; i++)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = false;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)(-116)) || Input.GetKeyUp((KeyCode)(-145)))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 0) ? (num + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.MKJNAELBHJD(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)(-116)) || Input.GetKeyUp((KeyCode)(-181)))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 1) : (this.LBAHADAEAIM.Count - 1));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.ELHFLJJKGFM(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x002E5BE4 File Offset: 0x002E3DE4
		private void PCDBBLIHGBP(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("continue" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("OnSketchViewLeft" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)7)
			{
				this.DCFGAKDAANL.Add("socialprofilesuspcantuse" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("." + ECCGLJGCBGC);
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x002E5CA5 File Offset: 0x002E3EA5
		private string AJIIAAACMIC(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "Asset bundle load operation failed during parallel mode.", "Error. ShowHideEnvironmentLayer(), environmentLayer ");
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x002E5CB8 File Offset: 0x002E3EB8
		private void HFNEKNCBBOA(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "OnStorySplashManagerCdnSuccess";
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(1140f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 685f, 1178f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x002E5D14 File Offset: 0x002E3F14
		private void OnEnable()
		{
			Application.logMessageReceived += this.AGFEHOJJOFP;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = false;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 0; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("{0} Video Glitches.", this.LBAHADAEAIM.Count));
				for (int k = 0; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 0.1f;
					audioSource.loop = (this.slideEffectTime > 0f);
					audioSource.PlayDelayed(0f);
					if (this.slideEffectTime == 0f)
					{
						this.slideEffectTime = (this.musicClip.length + 2f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("No camera found.");
			}
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x002E5F61 File Offset: 0x002E4161
		private string GDKFFFOLBIF(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "rwd", "common");
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x002E5F73 File Offset: 0x002E4173
		private string JJJPKCNKECJ(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "Custom effects bundle loaded but its asset is missing or mis-named:", "sku");
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x002E5F88 File Offset: 0x002E4188
		private void ACJDLLIOGMJ()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC++;
			if (this.KOENBLJPMOA <= 258f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 371f;
				this.DLGOAPLDOAC = 0;
			}
			if (this.slideEffectTime > 1967f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 0) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.IDIHDMJCELH(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1658f;
				}
			}
			if (Input.GetKeyUp((KeyCode)128))
			{
				this.guiShow = this.guiShow;
			}
			if (Input.GetKeyUp(KeyCode.RightBracket) || Input.GetKeyUp((KeyCode)67) || Input.GetKeyUp((KeyCode)(-24)) || Input.GetKeyUp(KeyCode.Equals))
			{
				int num = 0;
				this.slideEffectTime = 613f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = false;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)183) || Input.GetKeyUp((KeyCode)(-135)))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 0) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.JOJHAHFGOEI(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)75) || Input.GetKeyUp((KeyCode)(-115)))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 0) : (this.LBAHADAEAIM.Count - 0));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KECBIKDGCPP(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown(KeyCode.Percent))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x002E6230 File Offset: 0x002E4430
		private void PMLGOOKPPBP()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.LowerRight;
				this.NMLJKEBPGPE.fontSize = 44;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.LowerCenter;
				this.CCNEEAGFDEF.fontSize = 107;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1719f - 762f, 1533f, 431f, 1774f), this.GHFEIKAHKLG(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace(", slot 0, story ", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUIStyle style = "OnBackendValidateTransactionFailed";
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width((float)Screen.width);
			GUILayout.BeginHorizontal(style, array);
			GUILayout.Space(1408f);
			string text = "rwd";
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(126f);
			if (GUILayout.Button(text, ccneeagfdef, array2))
			{
				this.JFEKALLDNPO = this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("noiseanalog", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 1271f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text2 = this.AJIIAAACMIC(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[1] = GUILayout.Width(398f);
			GUILayout.Label(text2, ccneeagfdef2, array3);
			if (GUILayout.Button("</i>", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 1628f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 1;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 93f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 166f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text3 = this.MDPOKFEJPKO.ToString("+");
			GUIStyle ccneeagfdef3 = this.CCNEEAGFDEF;
			GUILayoutOption[] array4 = new GUILayoutOption[1];
			array4[1] = GUILayout.Width(656f);
			GUILayout.Label(text3, ccneeagfdef3, array4);
			GUI.contentColor = Color.white;
			GUILayout.Space(120f);
			GUILayout.EndHorizontal();
			for (int i = 0; i < this.LBAHADAEAIM.Count; i++)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = false;
					this.ELHFLJJKGFM(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = true;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUILayout.BeginVertical(".", new GUILayoutOption[]
				{
					GUILayout.Width(685f)
				});
				GUILayout.Space(32f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "w");
					int num = -1;
					for (int j = 1; j < this.LBAHADAEAIM.Count; j += 0)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("OnLobbySkinShopCdnSuccess", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "OnBackendGetPublicProfileHallOfFameMoreException" + imageEffectBase2.GetType().ToString().Replace("SceneLobbyManager2.OnReloadDelayed() CustomCodeUrlsHaveBeenPinged && DepotsUrlsHaveBeenPinged: break", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.CEHPNJKGGBO(imageEffectBase2);
							this.FJOIPKFJDAF(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(1026f);
					}
					for (int k = 0; k < this.LBAHADAEAIM.Count; k += 0)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = true;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("،", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("+", Array.Empty<GUILayoutOption>());
				GUILayout.Label("cardcollectcardpurchase0", Array.Empty<GUILayoutOption>());
				GUILayout.Label("PurchaseManagerXiaomi.StartPurchase(): Warning, there are waiting purchases to be validated, one more will be added to the list.", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(1405f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "$" : "frpid", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 934f;
				}
				if (GUILayout.Button("LoveInterestLoungeMapping - shop row sku '", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("laebs");
				}
				if (GUILayout.Button("assetBundleLoadOperationActiveCoroutines:", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style2 = "vhspause_1";
					GUILayoutOption[] array5 = new GUILayoutOption[4];
					array5[0] = GUILayout.Width((float)Screen.width);
					array5[0] = GUILayout.Height((float)(Screen.height / 3));
					GUILayout.BeginVertical(style2, array5);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, false, Array.Empty<GUILayoutOption>());
					for (int l = 1; l < this.DCFGAKDAANL.Count; l += 0)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x002E687E File Offset: 0x002E4A7E
		private void HMGJEJODDDE()
		{
			Application.logMessageReceived -= this.EDEFDPKACIC;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x002E689C File Offset: 0x002E4A9C
		private void BCAFCMEKCKL(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("OnNeedToOpenLoveInterestsLounge" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("notifposteffects" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)5)
			{
				this.DCFGAKDAANL.Add("+" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("OnLoungePremiumChoicesHistoryException" + ECCGLJGCBGC);
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x002E690C File Offset: 0x002E4B0C
		private void MILEMMBEKMM(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1523f, 1497f), UnityEngine.Random.Range(1094f, 1802f));
			}
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x002E6960 File Offset: 0x002E4B60
		private void AGFEHOJJOFP(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("[<color=red>ERROR</color>] " + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("[STACKTRACE] " + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == LogType.Warning)
			{
				this.DCFGAKDAANL.Add("[<color=yellow>WARNING</color>] " + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("[LOG] " + ECCGLJGCBGC);
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x002E69D0 File Offset: 0x002E4BD0
		private void GBBGGJOGOHE(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1494f, 552f), UnityEngine.Random.Range(607f, 1128f));
			}
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x002E6A24 File Offset: 0x002E4C24
		private void KLMFDGEGDPC()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.LowerRight;
				this.NMLJKEBPGPE.fontSize = -61;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.MiddleRight;
				this.CCNEEAGFDEF.fontSize = 98;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1986f - 1510f, 1630f, 461f, 579f), this.PBKHNNFEEPP(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("Account.GetSaveSlotForStory(), tempAnthologyAsset is null, using default slot index.", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUIStyle style = "fruidres";
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width((float)Screen.width);
			GUILayout.BeginHorizontal(style, array);
			GUILayout.Space(998f);
			if (GUILayout.Button("k", this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(1287f)
			}))
			{
				this.JFEKALLDNPO = !this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("box", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 692f;
				if (this.KHEAPHJLFJM > 0)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 1;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text = this.NMOOGLKLPIN(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace(" has no name in the text pack explore tab, group skipped", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[1] = GUILayout.Width(932f);
			GUILayout.Label(text, ccneeagfdef, array2);
			if (GUILayout.Button("errortitle", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 1205f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 1;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 1176f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 53f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			GUILayout.Label(this.MDPOKFEJPKO.ToString("hintvalidating"), this.CCNEEAGFDEF, new GUILayoutOption[]
			{
				GUILayout.Width(737f)
			});
			GUI.contentColor = Color.white;
			GUILayout.Space(1822f);
			GUILayout.EndHorizontal();
			for (int i = 0; i < this.LBAHADAEAIM.Count; i += 0)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = true;
					this.NEEGJEMOIIG(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = false;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style2 = "continue";
				GUILayoutOption[] array3 = new GUILayoutOption[1];
				array3[1] = GUILayout.Width(1976f);
				GUILayout.BeginVertical(style2, array3);
				GUILayout.Space(1700f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "Scan distort");
					int num = -1;
					for (int j = 0; j < this.LBAHADAEAIM.Count; j++)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("inkr", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, " searchCards=" + imageEffectBase2.GetType().ToString().Replace("", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.KHFIFGADNMA(imageEffectBase2);
							this.DFKNDOMNFLJ(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(485f);
					}
					for (int k = 1; k < this.LBAHADAEAIM.Count; k += 0)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = true;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("\n\n", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("OnSaveSyncAnyResultDuplicate", Array.Empty<GUILayoutOption>());
				GUILayout.Label("anthology", Array.Empty<GUILayoutOption>());
				GUILayout.Label("SRAAnthologyDesc.CorrectScoreByViewHit(): athology with index ", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(1211f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "StorySaveBody.RemoveAvatarPackWardrobe(), unsupported wardrobe index:" : "OnBackendGetPublicProfileHallOfFameException", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = !this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 1672f;
				}
				if (GUILayout.Button("ERROR: StoryStep.StoryStepType.chapterEnd: unhandled scenario.", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("anthologiestitle");
				}
				if (GUILayout.Button("ok", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style3 = "flip_down";
					GUILayoutOption[] array4 = new GUILayoutOption[1];
					array4[1] = GUILayout.Width((float)Screen.width);
					array4[1] = GUILayout.Height((float)(Screen.height / 3));
					GUILayout.BeginVertical(style3, array4);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, true, false, Array.Empty<GUILayoutOption>());
					for (int l = 1; l < this.DCFGAKDAANL.Count; l += 0)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x002E7074 File Offset: 0x002E5274
		private void FJOIPKFJDAF(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Starting non-parallel download:", new GUILayoutOption[]
					{
						GUILayout.Width(1245f)
					});
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1789f, 452f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "p";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(451f);
					GUILayout.Label(text, array);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1453f, 799f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnNeedToShowNoMoreHardPopup", new GUILayoutOption[]
					{
						GUILayout.Width(285f)
					});
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1275f, 1663f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(": ", new GUILayoutOption[]
					{
						GUILayout.Width(1559f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 775f, 1596f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "Critical error, could not load asset bundle:";
					GUILayoutOption[] array2 = new GUILayoutOption[1];
					array2[1] = GUILayout.Width(306f);
					GUILayout.Label(text2, array2);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 969f, 928f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("_TVLinesOpacity", new GUILayoutOption[]
					{
						GUILayout.Width(1161f)
					});
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1101f, 173f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "RT REPORT - ";
					GUILayoutOption[] array3 = new GUILayoutOption[1];
					array3[1] = GUILayout.Width(250f);
					GUILayout.Label(text3, array3);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 110f, 1713f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = ")";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(1955f);
					GUILayout.Label(text4, array4);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 811f, 286f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "Environment layer has been destroyed according to on demand data:";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(1205f);
					GUILayout.Label(text5, array5);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1386f, 1566f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "skspnotenough";
					GUILayoutOption[] array6 = new GUILayoutOption[1];
					array6[1] = GUILayout.Width(1050f);
					GUILayout.Label(text6, array6);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1410f, 444f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(45f);
					GUILayout.Label(text7, array7);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 604f, 848f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "OnBackendPassResourcesChangedType0";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[1] = GUILayout.Width(1842f);
					GUILayout.Label(text8, array8);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 124f, 379f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "YYY";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[0] = GUILayout.Width(997f);
					GUILayout.Label(text9, array9);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1081f, 1692f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "/";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(1949f);
					GUILayout.Label(text10, array10);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 874f, 377f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("syn", new GUILayoutOption[]
					{
						GUILayout.Width(344f)
					});
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 408f, 1632f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "BackendCacheManager: Using cached backend response payload for ";
					GUILayoutOption[] array11 = new GUILayoutOption[1];
					array11[1] = GUILayout.Width(546f);
					GUILayout.Label(text11, array11);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 448f, 1865f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("; ", new GUILayoutOption[]
					{
						GUILayout.Width(1265f)
					});
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 97f, 802f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(", index:", new GUILayoutOption[]
					{
						GUILayout.Width(444f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 646f, 404f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "Avatar pack has been SKIPPED:";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(193f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 214f, 1120f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "ERROR: ChoiceExtendedManager.InputDataIsValid() - choices count is greater than assetList count.";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(872f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 223f, 1490f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "OnBackendValidateTransactionSuccess";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[0] = GUILayout.Width(1407f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 448f, 1311f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "fsofl";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(11f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 1714f, 747f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "NarrowScreenScaler.CalculateNewScaleUtil(): returned a ";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(133f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 43f, 74f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "RT REPORT - CharacterRenderTexturePool - ";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[1] = GUILayout.Width(1551f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 1872f, 1932f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(5f)
					});
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 559f, 314f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "";
					GUILayoutOption[] array18 = new GUILayoutOption[1];
					array18[1] = GUILayout.Width(790f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1859f, 38f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(")", new GUILayoutOption[]
					{
						GUILayout.Width(50f)
					});
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 1145f, 1261f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "p";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(1531f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 59f, 116f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = " USD ";
					GUILayoutOption[] array20 = new GUILayoutOption[1];
					array20[1] = GUILayout.Width(1951f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1550f, 411f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "OnResolutionChanged";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[0] = GUILayout.Width(704f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1797f, 134f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(913f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1730f, 1531f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "StorySaveBody.AddAvatarComponent(), unsupported wardrobe index:";
					GUILayoutOption[] array23 = new GUILayoutOption[1];
					array23[1] = GUILayout.Width(623f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 219f, 788f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "</b>";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(1326f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 340f, 618f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("teal_2", new GUILayoutOption[]
					{
						GUILayout.Width(949f)
					});
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 1431f, 1600f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Critical error, could not load asset bundle:", new GUILayoutOption[]
					{
						GUILayout.Width(1673f)
					});
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1899f, 968f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = ">";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[0] = GUILayout.Width(957f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 247f, 170f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "SceneAvatarManager.RFInitializeAndBuildAvatar(), silent update for avatar index on active slot, was:";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[0] = GUILayout.Width(1370f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 553f, 1241f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ok", new GUILayoutOption[]
					{
						GUILayout.Width(1165f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 194f, 1652f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("p", new GUILayoutOption[]
					{
						GUILayout.Width(818f)
					});
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 1359f, 1677f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x002E7E0C File Offset: 0x002E600C
		private void AELFPOLCIGN(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(630f, 119f), UnityEngine.Random.Range(715f, 1503f));
			}
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x002E7E5E File Offset: 0x002E605E
		private void OOOHPJJOODA()
		{
			Application.logMessageReceived -= this.JDDMDOHCIEP;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x002E7E7C File Offset: 0x002E607C
		private void DFKNDOMNFLJ(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("friendsoutofdatetutor", new GUILayoutOption[]
					{
						GUILayout.Width(767f)
					});
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 267f, 240f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Shaders/VideoGlitchOldTV", new GUILayoutOption[]
					{
						GUILayout.Width(856f)
					});
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1459f, 838f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "[ ";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(128f);
					GUILayout.Label(text, array);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1034f, 1006f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("y", new GUILayoutOption[]
					{
						GUILayout.Width(1367f)
					});
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 395f, 1728f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "OnFriendsPopupSendSimpleClick";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(1871f);
					GUILayout.Label(text2, array2);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 698f, 1198f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "cs";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(1709f);
					GUILayout.Label(text3, array3);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 878f, 366f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "OnBackendGetIncentRewardAdSuccess";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[1] = GUILayout.Width(1288f);
					GUILayout.Label(text4, array4);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 363f, 1597f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "abpd5";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(357f);
					GUILayout.Label(text5, array5);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 278f, 381f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "achievtitle";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Width(1845f);
					GUILayout.Label(text6, array6);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1479f, 914f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "OnCollectableDialogCollect";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[1] = GUILayout.Width(144f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 245f, 1267f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "rsl";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[0] = GUILayout.Width(1938f);
					GUILayout.Label(text8, array8);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 620f, 477f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("loop", new GUILayoutOption[]
					{
						GUILayout.Width(1042f)
					});
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 1941f, 1970f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("High version preview2 assets loaded:", new GUILayoutOption[]
					{
						GUILayout.Width(130f)
					});
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 879f, 1626f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("hcfc", new GUILayoutOption[]
					{
						GUILayout.Width(1411f)
					});
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 282f, 982f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "〈";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(1553f);
					GUILayout.Label(text9, array9);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 1954f, 1697f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "$USEAVATARCONFIGV2";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(840f);
					GUILayout.Label(text10, array10);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 410f, 1354f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "OnBackendGetDefaultBundlesException";
					GUILayoutOption[] array11 = new GUILayoutOption[1];
					array11[1] = GUILayout.Width(1505f);
					GUILayout.Label(text11, array11);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1550f, 921f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "err";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(700f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 541f, 1910f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "AnthologySave.GetAvatarIndexWardrobe(), unsupported wardrobe index:";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[0] = GUILayout.Width(1772f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 1118f, 1663f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "socialjoinbody";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[0] = GUILayout.Width(345f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 1423f, 1441f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "+";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[0] = GUILayout.Width(1417f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 58f, 1923f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "plya";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(153f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 373f, 1815f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("dceoiv", new GUILayoutOption[]
					{
						GUILayout.Width(1723f)
					});
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 550f, 338f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "hint7";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[0] = GUILayout.Width(1426f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 486f, 1153f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "@";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[1] = GUILayout.Width(1688f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 434f, 1382f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("$", new GUILayoutOption[]
					{
						GUILayout.Width(1374f)
					});
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 284f, 1655f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "rsl3";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(1482f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 673f, 1069f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "no";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(1109f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1826f, 1934f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "$ENVSET";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[1] = GUILayout.Width(866f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 741f, 763f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "";
					GUILayoutOption[] array22 = new GUILayoutOption[1];
					array22[1] = GUILayout.Width(140f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1401f, 1638f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ZZZ", new GUILayoutOption[]
					{
						GUILayout.Width(153f)
					});
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 45f, 324f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "retry";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[0] = GUILayout.Width(1457f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 130f, 1790f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "avatarcollectionstutor6title";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[1] = GUILayout.Width(1250f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 1701f, 1801f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[0] = GUILayout.Width(1552f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 725f, 385f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(1493f)
					});
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 887f, 383f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "OnStoryChoiceClick";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[0] = GUILayout.Width(1086f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 803f, 1145f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(") for ", new GUILayoutOption[]
					{
						GUILayout.Width(1747f)
					});
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1975f, 1956f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "af_subscribe";
					GUILayoutOption[] array27 = new GUILayoutOption[1];
					array27[1] = GUILayout.Width(1559f);
					GUILayout.Label(text27, array27);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 1675f, 665f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(4f)
					});
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 451f, 211f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x002E8C14 File Offset: 0x002E6E14
		private void FKOPCAFJEKE()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC++;
			if (this.KOENBLJPMOA <= 1466f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 233f;
				this.DLGOAPLDOAC = 1;
			}
			if (this.slideEffectTime > 1461f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1) ? (this.KHEAPHJLFJM + 0) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.ELHFLJJKGFM(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1947f;
				}
			}
			if (Input.GetKeyUp((KeyCode)15))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)(-104)) || Input.GetKeyUp((KeyCode)183) || Input.GetKeyUp((KeyCode)187) || Input.GetKeyUp((KeyCode)(-143)))
			{
				int num = 0;
				this.slideEffectTime = 71f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = true;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp(KeyCode.Equals) || Input.GetKeyUp(KeyCode.Delete))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 0) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KECBIKDGCPP(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)(-59)) || Input.GetKeyUp(KeyCode.Alpha7))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 0) : (this.LBAHADAEAIM.Count - 1));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.IDIHDMJCELH(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-105)))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x002E8EBC File Offset: 0x002E70BC
		private void Update()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC++;
			if (this.KOENBLJPMOA <= 0f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 0f;
				this.DLGOAPLDOAC = 0;
			}
			if (this.slideEffectTime > 0f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1) ? (this.KHEAPHJLFJM + 1) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.CLNLALBDKHK(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 0f;
				}
			}
			if (Input.GetKeyUp(KeyCode.F1))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp(KeyCode.KeypadPlus) || Input.GetKeyUp(KeyCode.KeypadMinus) || Input.GetKeyUp(KeyCode.PageUp) || Input.GetKeyUp(KeyCode.PageDown))
			{
				int num = 0;
				this.slideEffectTime = 0f;
				for (int i = 0; i < this.LBAHADAEAIM.Count; i++)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = false;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp(KeyCode.KeypadPlus) || Input.GetKeyUp(KeyCode.PageUp))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 1) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.CLNLALBDKHK(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp(KeyCode.KeypadMinus) || Input.GetKeyUp(KeyCode.PageDown))
				{
					this.KHEAPHJLFJM = ((num > 0) ? (num - 1) : (this.LBAHADAEAIM.Count - 1));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.CLNLALBDKHK(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x002E9164 File Offset: 0x002E7364
		private void EFLMHKDLFCA(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("blizzard" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("SceneAvatarManager.FetchAvatarCollectionsFromBackend(): save not available" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)8)
			{
				this.DCFGAKDAANL.Add("OnChapterSnapshotsItemClose" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("Error. MoveEnvironmentVertical(), environment " + ECCGLJGCBGC);
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x002E91D4 File Offset: 0x002E73D4
		private void KOCLPPKADOH(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "F";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[0] = GUILayout.Width(1242f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1519f, 390f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("aind", new GUILayoutOption[]
					{
						GUILayout.Width(527f)
					});
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 141f, 230f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "OnBackendAddFriendByUIDException";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[0] = GUILayout.Width(576f);
					GUILayout.Label(text2, array2);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1373f, 1516f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "srvt";
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[1] = GUILayout.Width(1460f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 604f, 1941f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "StoriesSearchBalance - root key '";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[1] = GUILayout.Width(1108f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 1032f, 1764f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "\r";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(1823f);
					GUILayout.Label(text5, array5);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 1746f, 1527f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "Critical error, could not load asset bundle:";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(1294f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1292f, 104f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = " ";
					GUILayoutOption[] array7 = new GUILayoutOption[1];
					array7[1] = GUILayout.Width(267f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 635f, 465f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = ", trying to return any achievement sprite or null.";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[0] = GUILayout.Width(142f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 65f, 511f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "common";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(1266f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1712f, 741f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "avatarcollectionstutor6body";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(1346f);
					GUILayout.Label(text10, array10);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1229f, 1635f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[0] = GUILayout.Width(1670f);
					GUILayout.Label(text11, array11);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 102f, 388f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "OnStartFreePassException";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(647f);
					GUILayout.Label(text12, array12);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1054f, 884f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "importanttitle";
					GUILayoutOption[] array13 = new GUILayoutOption[1];
					array13[1] = GUILayout.Width(1741f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1120f, 767f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "+";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[0] = GUILayout.Width(988f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 1379f, 1739f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "XXX";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[0] = GUILayout.Width(1164f);
					GUILayout.Label(text15, array15);
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 520f, 627f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "PurchaseManagerSteam.CompletePurchase(): Not initialized.";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(445f);
					GUILayout.Label(text16, array16);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1439f, 878f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("<i>", new GUILayoutOption[]
					{
						GUILayout.Width(486f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 840f, 166f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = " ";
					GUILayoutOption[] array17 = new GUILayoutOption[0];
					array17[0] = GUILayout.Width(878f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 823f, 1172f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(1591f)
					});
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 1961f, 1520f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = ", as anthology ";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(1537f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 274f, 1753f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("importanttitle", new GUILayoutOption[]
					{
						GUILayout.Width(600f)
					});
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 282f, 1194f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[1] = GUILayout.Width(694f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 1133f, 1127f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(1260f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 1124f, 9f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "OnBackendGetDefaultBundlesException";
					GUILayoutOption[] array21 = new GUILayoutOption[1];
					array21[1] = GUILayout.Width(676f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1949f, 1613f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "slind";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[0] = GUILayout.Width(1713f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1187f, 97f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "rateChapter";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[0] = GUILayout.Width(1025f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 1421f, 900f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("There needs to be one active LanguageManager script on a GameObject in your scene.", new GUILayoutOption[]
					{
						GUILayout.Width(1054f)
					});
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1130f, 669f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("=== RU FIREWALL === chapter end request 2 returned, continuing to the bundles request", new GUILayoutOption[]
					{
						GUILayout.Width(1409f)
					});
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1799f, 39f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "pid";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(1055f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1838f, 66f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("storyChatPrefab is null!", new GUILayoutOption[]
					{
						GUILayout.Width(1810f)
					});
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1296f, 1125f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("_NoiseColor", new GUILayoutOption[]
					{
						GUILayout.Width(317f)
					});
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1516f, 1272f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "sia";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[0] = GUILayout.Width(30f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 1829f, 196f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(1315f)
					});
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 105f, 1403f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "areyousure";
					GUILayoutOption[] array26 = new GUILayoutOption[0];
					array26[1] = GUILayout.Width(1884f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 127f, 1434f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "actshl";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[1] = GUILayout.Width(1245f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 743f, 1581f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = " could not be opened";
					GUILayoutOption[] array28 = new GUILayoutOption[1];
					array28[1] = GUILayout.Width(1115f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 742f, 1533f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("o", new GUILayoutOption[]
					{
						GUILayout.Width(1298f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 1943f, 1278f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "OnSettingsPopupCloseAndNeedToShowGameModeNotif";
					GUILayoutOption[] array29 = new GUILayoutOption[0];
					array29[1] = GUILayout.Width(1879f);
					GUILayout.Label(text29, array29);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 491f, 1415f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x002E9F6C File Offset: 0x002E816C
		private void INGPBNNEPCE()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC += 0;
			if (this.KOENBLJPMOA <= 1521f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 596f;
				this.DLGOAPLDOAC = 0;
			}
			if (this.slideEffectTime > 1368f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 1) : 0);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.ELFPILHKOMH(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1985f;
				}
			}
			if (Input.GetKeyUp((KeyCode)69))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)(-21)) || Input.GetKeyUp((KeyCode)190) || Input.GetKeyUp((KeyCode)(-13)) || Input.GetKeyUp((KeyCode)(-91)))
			{
				int num = 1;
				this.slideEffectTime = 247f;
				for (int i = 1; i < this.LBAHADAEAIM.Count; i++)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = true;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp((KeyCode)155) || Input.GetKeyUp((KeyCode)(-135)))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.CLNLALBDKHK(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp(KeyCode.Slash) || Input.GetKeyUp((KeyCode)167))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 1) : (this.LBAHADAEAIM.Count - 0));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.GBBGGJOGOHE(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x002EA214 File Offset: 0x002E8414
		private void KPABBOHIKPH(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "ipwho.is";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(195f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 1391f, 919f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x002EA270 File Offset: 0x002E8470
		private void ILLMKMLEHMI()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC += 0;
			if (this.KOENBLJPMOA <= 1077f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 1856f;
				this.DLGOAPLDOAC = 1;
			}
			if (this.slideEffectTime > 1698f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KECBIKDGCPP(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 942f;
				}
			}
			if (Input.GetKeyUp((KeyCode)(-19)))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)16) || Input.GetKeyUp((KeyCode)(-139)) || Input.GetKeyUp((KeyCode)(-66)) || Input.GetKeyUp((KeyCode)31))
			{
				int num = 0;
				this.slideEffectTime = 167f;
				for (int i = 0; i < this.LBAHADAEAIM.Count; i++)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = true;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp(KeyCode.Percent) || Input.GetKeyUp((KeyCode)158))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 1) ? (num + 1) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.MKJNAELBHJD(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp((KeyCode)140) || Input.GetKeyUp((KeyCode)(-120)))
				{
					this.KHEAPHJLFJM = ((num > 1) ? (num - 0) : (this.LBAHADAEAIM.Count - 0));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.GBBGGJOGOHE(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-94)))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x002EA518 File Offset: 0x002E8718
		private void KEKDPGIHKNC(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Label("onPopupCardOptionsCloseClick", new GUILayoutOption[]
			{
				GUILayout.Width(1652f)
			});
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 1876f, 990f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x002EA574 File Offset: 0x002E8774
		private void HCJHLBFFNKA()
		{
			Application.logMessageReceived += this.AGFEHOJJOFP;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = true;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("+", this.LBAHADAEAIM.Count));
				for (int k = 1; k < this.LBAHADAEAIM.Count; k += 0)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 705f;
					audioSource.loop = (this.slideEffectTime > 872f);
					audioSource.PlayDelayed(91f);
					if (this.slideEffectTime == 1113f)
					{
						this.slideEffectTime = (this.musicClip.length + 1819f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("OnBackendUpdateFriendsDataException");
			}
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x002EA7C4 File Offset: 0x002E89C4
		private void KDLKAKKALCE(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1850f, 687f), UnityEngine.Random.Range(1822f, 1711f));
			}
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x002EA818 File Offset: 0x002E8A18
		private void KECBIKDGCPP(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1890f, 773f), UnityEngine.Random.Range(1699f, 1609f));
			}
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x002EA86A File Offset: 0x002E8A6A
		private void OnDisable()
		{
			Application.logMessageReceived -= this.AGFEHOJJOFP;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x002EA888 File Offset: 0x002E8A88
		private void NJHDBMAFPJI(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("YYY" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("etc2" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)6)
			{
				this.DCFGAKDAANL.Add("PurchaseManagerXiaomi.OnPurchaseUpdated(): code=" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add(" " + ECCGLJGCBGC);
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x002E687E File Offset: 0x002E4A7E
		private void EBEGEDOJCLC()
		{
			Application.logMessageReceived -= this.EDEFDPKACIC;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x002EA8F8 File Offset: 0x002E8AF8
		private void EDEFDPKACIC(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("sind" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("OnBackendGetUserSketchesSuccess" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == LogType.Exception)
			{
				this.DCFGAKDAANL.Add("fire" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("user" + ECCGLJGCBGC);
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x002EA968 File Offset: 0x002E8B68
		private void ANOMGDOBBGI(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("skinshopinfosummary" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("wmix" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)5)
			{
				this.DCFGAKDAANL.Add("" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("p" + ECCGLJGCBGC);
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x002EA9D8 File Offset: 0x002E8BD8
		private void PADHAHCNFNM()
		{
			Application.logMessageReceived += this.EDEFDPKACIC;
			this.KOENBLJPMOA = this.CDOMPFPDIPE;
			Camera camera = null;
			Camera[] array = UnityEngine.Object.FindObjectsOfType<Camera>();
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].enabled)
				{
					camera = array[i];
					break;
				}
			}
			if (camera != null)
			{
				if (camera.GetComponents<ImageEffectBase>().Length == 0)
				{
					camera.gameObject.AddComponent<VideoGlitchShift>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchNoiseDigital>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchNoiseAnalog>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchBlackWhiteDistortion>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchBrokenScreen>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchRGBDisplay>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchSpectrumOffset>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTape>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldTV>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchOldVHS>().enabled = true;
					camera.gameObject.AddComponent<VideoGlitchVHSPause>().enabled = false;
					camera.gameObject.AddComponent<VideoGlitchCorruptionDigital>().enabled = true;
					this.LBAHADAEAIM.AddRange(camera.GetComponents<ImageEffectBase>());
				}
				else
				{
					ImageEffectBase[] components = camera.GetComponents<ImageEffectBase>();
					for (int j = 1; j < components.Length; j++)
					{
						this.LBAHADAEAIM.Add(components[j]);
					}
				}
				Debug.Log(string.Format("skinshopfiltersbtnactive", this.LBAHADAEAIM.Count));
				for (int k = 0; k < this.LBAHADAEAIM.Count; k++)
				{
					this.LBAHADAEAIM[k].enabled = (k == this.KHEAPHJLFJM);
				}
				if (this.musicClip != null)
				{
					AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
					audioSource.clip = this.musicClip;
					audioSource.volume = 870f;
					audioSource.loop = (this.slideEffectTime > 1527f);
					audioSource.PlayDelayed(1851f);
					if (this.slideEffectTime == 1745f)
					{
						this.slideEffectTime = (this.musicClip.length + 1792f) / (float)this.LBAHADAEAIM.Count;
						return;
					}
				}
			}
			else
			{
				Debug.LogWarning("</i>");
			}
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x002EAC28 File Offset: 0x002E8E28
		private void OBDFIFGJKDC()
		{
			this.KOENBLJPMOA -= Time.deltaTime;
			this.HKHBAGONAGN += Time.timeScale / Time.deltaTime;
			this.DLGOAPLDOAC += 0;
			if (this.KOENBLJPMOA <= 1389f)
			{
				this.MDPOKFEJPKO = this.HKHBAGONAGN / (float)this.DLGOAPLDOAC;
				this.KOENBLJPMOA = this.CDOMPFPDIPE;
				this.HKHBAGONAGN = 335f;
				this.DLGOAPLDOAC = 0;
			}
			if (this.slideEffectTime > 1086f && this.LBAHADAEAIM.Count > 0)
			{
				this.MMIGFOEJONF += Time.deltaTime;
				if (this.MMIGFOEJONF >= this.slideEffectTime)
				{
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KHEAPHJLFJM = ((this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 0) ? (this.KHEAPHJLFJM + 0) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = true;
					this.KDLKAKKALCE(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
					this.MMIGFOEJONF = 1174f;
				}
			}
			if (Input.GetKeyUp((KeyCode)(-78)))
			{
				this.guiShow = !this.guiShow;
			}
			if (Input.GetKeyUp((KeyCode)(-46)) || Input.GetKeyUp((KeyCode)137) || Input.GetKeyUp((KeyCode)(-135)) || Input.GetKeyUp(KeyCode.Backspace))
			{
				int num = 0;
				this.slideEffectTime = 124f;
				for (int i = 0; i < this.LBAHADAEAIM.Count; i += 0)
				{
					if (this.LBAHADAEAIM[i].enabled)
					{
						this.LBAHADAEAIM[i].enabled = false;
						num = i;
						break;
					}
				}
				if (Input.GetKeyUp(KeyCode.G) || Input.GetKeyUp((KeyCode)135))
				{
					this.KHEAPHJLFJM = ((num < this.LBAHADAEAIM.Count - 0) ? (num + 0) : 1);
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.AELFPOLCIGN(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
				if (Input.GetKeyUp(KeyCode.Alpha7) || Input.GetKeyUp((KeyCode)22))
				{
					this.KHEAPHJLFJM = ((num > 0) ? (num - 0) : (this.LBAHADAEAIM.Count - 0));
					this.LBAHADAEAIM[this.KHEAPHJLFJM].enabled = false;
					this.CLNLALBDKHK(this.LBAHADAEAIM[this.KHEAPHJLFJM]);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-24)))
			{
				Application.Quit();
			}
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x002EAECF File Offset: 0x002E90CF
		private string LHLCDGOMECI(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "@", "mist");
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x002EAEE4 File Offset: 0x002E90E4
		private void JDDMDOHCIEP(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("OnRequestCheckForUpdatesSuccess" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == LogType.Exception)
			{
				this.DCFGAKDAANL.Add("ok" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("</i>" + ECCGLJGCBGC);
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x002EAF54 File Offset: 0x002E9154
		private void KPPFGBDIKBG(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "Loaded asset bundle:";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(1902f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 429f, 624f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x002EAFB0 File Offset: 0x002E91B0
		private void IDIHDMJCELH(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1731f, 290f), UnityEngine.Random.Range(887f, 1436f));
			}
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x002EB004 File Offset: 0x002E9204
		private void JOJHAHFGOEI(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(953f, 1702f), UnityEngine.Random.Range(174f, 247f));
			}
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x002EB058 File Offset: 0x002E9258
		private void MAOOGMKAALA(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("reward" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("OnSceneLobbyManagerAssetsDownloadFailed" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)6)
			{
				this.DCFGAKDAANL.Add("" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("SocialStatsUserPublicProfile.modified = false, RequestCustomProfile()" + ECCGLJGCBGC);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x002EB0C8 File Offset: 0x002E92C8
		private void CJJONFBBMJA()
		{
			if (this.LBAHADAEAIM.Count == 0)
			{
				return;
			}
			if (this.NMLJKEBPGPE == null)
			{
				this.NMLJKEBPGPE = new GUIStyle(GUI.skin.textArea);
				this.NMLJKEBPGPE.alignment = TextAnchor.MiddleCenter;
				this.NMLJKEBPGPE.fontSize = -20;
			}
			if (this.CCNEEAGFDEF == null)
			{
				this.CCNEEAGFDEF = new GUIStyle(GUI.skin.textArea);
				this.CCNEEAGFDEF.alignment = TextAnchor.UpperRight;
				this.CCNEEAGFDEF.fontSize = -108;
			}
			if (this.showEffectName && !this.guiShow)
			{
				GUILayout.BeginArea(new Rect((float)Screen.width * 1340f - 1062f, 70f, 72f, 1174f), this.EEKEKOHIIDC(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("@HD", string.Empty)).ToUpper(), this.NMLJKEBPGPE);
				GUILayout.EndArea();
			}
			if (!this.guiShow)
			{
				return;
			}
			GUIStyle style = "";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width((float)Screen.width);
			GUILayout.BeginHorizontal(style, array);
			GUILayout.Space(1416f);
			string text = "OnBackendValidateTransactionException";
			GUIStyle ccneeagfdef = this.CCNEEAGFDEF;
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(245f);
			if (GUILayout.Button(text, ccneeagfdef, array2))
			{
				this.JFEKALLDNPO = this.JFEKALLDNPO;
			}
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("OnStoryChoiceClick", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 303f;
				if (this.KHEAPHJLFJM > 1)
				{
					this.KHEAPHJLFJM--;
				}
				else
				{
					this.KHEAPHJLFJM = this.LBAHADAEAIM.Count - 0;
				}
				Event.current.Use();
			}
			GUI.contentColor = Color.white;
			string text2 = this.PBKHNNFEEPP(this.LBAHADAEAIM[this.KHEAPHJLFJM].GetType().ToString().Replace("...", string.Empty)).ToUpper();
			GUIStyle ccneeagfdef2 = this.CCNEEAGFDEF;
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[0] = GUILayout.Width(1379f);
			GUILayout.Label(text2, ccneeagfdef2, array3);
			if (GUILayout.Button("OnSettingsPopupClose", this.CCNEEAGFDEF, Array.Empty<GUILayoutOption>()))
			{
				this.slideEffectTime = 666f;
				if (this.KHEAPHJLFJM < this.LBAHADAEAIM.Count - 1)
				{
					this.KHEAPHJLFJM++;
				}
				else
				{
					this.KHEAPHJLFJM = 0;
				}
			}
			GUILayout.FlexibleSpace();
			if (this.MDPOKFEJPKO < 514f)
			{
				GUI.contentColor = Color.yellow;
			}
			else if (this.MDPOKFEJPKO < 985f)
			{
				GUI.contentColor = Color.red;
			}
			else
			{
				GUI.contentColor = Color.green;
			}
			string text3 = this.MDPOKFEJPKO.ToString("blur");
			GUIStyle ccneeagfdef3 = this.CCNEEAGFDEF;
			GUILayoutOption[] array4 = new GUILayoutOption[0];
			array4[1] = GUILayout.Width(1197f);
			GUILayout.Label(text3, ccneeagfdef3, array4);
			GUI.contentColor = Color.white;
			GUILayout.Space(716f);
			GUILayout.EndHorizontal();
			for (int i = 1; i < this.LBAHADAEAIM.Count; i += 0)
			{
				ImageEffectBase imageEffectBase = this.LBAHADAEAIM[i];
				if (this.KHEAPHJLFJM == i && !imageEffectBase.enabled)
				{
					imageEffectBase.enabled = false;
					this.ELFPILHKOMH(imageEffectBase);
				}
				if (imageEffectBase.enabled && this.KHEAPHJLFJM != i)
				{
					imageEffectBase.enabled = true;
				}
			}
			if (this.JFEKALLDNPO)
			{
				GUIStyle style2 = "hacomp1";
				GUILayoutOption[] array5 = new GUILayoutOption[0];
				array5[0] = GUILayout.Width(1311f);
				GUILayout.BeginVertical(style2, array5);
				GUILayout.Space(205f);
				if (this.LBAHADAEAIM.Count > 0)
				{
					this.KFKFGEOCEIB = GUILayout.BeginScrollView(this.KFKFGEOCEIB, "loungeofferexpired");
					int num = -1;
					for (int j = 1; j < this.LBAHADAEAIM.Count; j += 0)
					{
						ImageEffectBase imageEffectBase2 = this.LBAHADAEAIM[j];
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						if (imageEffectBase2.enabled)
						{
							GUILayout.BeginVertical("socialgiftpurchasevoltitl", Array.Empty<GUILayoutOption>());
						}
						if (GUILayout.Toggle(imageEffectBase2.enabled, "OnBackendRequestFriendDeleteException" + imageEffectBase2.GetType().ToString().Replace("?uid=", string.Empty), Array.Empty<GUILayoutOption>()) != imageEffectBase2.enabled)
						{
							num = j;
						}
						if (imageEffectBase2.enabled)
						{
							this.HDMGPBIOJBG(imageEffectBase2);
							this.DFKNDOMNFLJ(imageEffectBase2);
							GUILayout.EndVertical();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(82f);
					}
					for (int k = 1; k < this.LBAHADAEAIM.Count; k++)
					{
						ImageEffectBase imageEffectBase3 = this.LBAHADAEAIM[k];
						if (num == k)
						{
							imageEffectBase3.enabled = !imageEffectBase3.enabled;
							if (imageEffectBase3.enabled)
							{
								this.KHEAPHJLFJM = k;
							}
						}
						if (imageEffectBase3.enabled && this.KHEAPHJLFJM != k)
						{
							imageEffectBase3.enabled = false;
						}
					}
					GUILayout.EndScrollView();
				}
				else
				{
					GUILayout.Label("stat6long", Array.Empty<GUILayoutOption>());
				}
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical("", Array.Empty<GUILayoutOption>());
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				GUILayout.Label("era", Array.Empty<GUILayoutOption>());
				GUILayout.EndVertical();
				GUILayout.Space(995f);
				if (Debug.isDebugBuild && GUILayout.Button(this.MMGIPICEOCE ? "ok" : " ", Array.Empty<GUILayoutOption>()))
				{
					this.MMGIPICEOCE = this.MMGIPICEOCE;
					this.OIJCKMIBIAH.y = 532f;
				}
				if (GUILayout.Button("High/low version preview 2 assets scheme will be re-loaded: recommended setup changed.", Array.Empty<GUILayoutOption>()))
				{
					Application.OpenURL("OnBackendGetPublicProfileHallOfFameMoreSuccess");
				}
				if (GUILayout.Button("PurchaseManagerSteam.StartPurchase(): A purchase or validation is in progress. Aborting.", Array.Empty<GUILayoutOption>()))
				{
					Application.Quit();
				}
				GUILayout.EndVertical();
				if (this.MMGIPICEOCE)
				{
					GUIStyle style3 = "avatarcollectionstutor8body";
					GUILayoutOption[] array6 = new GUILayoutOption[6];
					array6[0] = GUILayout.Width((float)Screen.width);
					array6[0] = GUILayout.Height((float)(Screen.height / 2));
					GUILayout.BeginVertical(style3, array6);
					this.OIJCKMIBIAH = GUILayout.BeginScrollView(this.OIJCKMIBIAH, false, true, Array.Empty<GUILayoutOption>());
					for (int l = 0; l < this.DCFGAKDAANL.Count; l++)
					{
						GUILayout.Label(this.DCFGAKDAANL[l], Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndScrollView();
					GUILayout.EndVertical();
				}
			}
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x002EB718 File Offset: 0x002E9918
		private void MKJNAELBHJD(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(900f, 1258f), UnityEngine.Random.Range(877f, 1572f));
			}
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x002EB76C File Offset: 0x002E996C
		private void GIKMKCKOCAO(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "useMessageV2Text";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1049f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 603f, 185f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x002EB7C5 File Offset: 0x002E99C5
		private void OJIOGKJEBMM()
		{
			Application.logMessageReceived -= this.PCDBBLIHGBP;
			this.LBAHADAEAIM.Clear();
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x002EB7E4 File Offset: 0x002E99E4
		private void HFINMGOBNHF(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "\"";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[1] = GUILayout.Width(1082f);
					GUILayout.Label(text, array);
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1405f, 331f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "OnBackendValidateTransactionFailed";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[0] = GUILayout.Width(855f);
					GUILayout.Label(text2, array2);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 305f, 1624f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "\n\n";
					GUILayoutOption[] array3 = new GUILayoutOption[1];
					array3[1] = GUILayout.Width(765f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 1724f, 1644f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = " caching system still not ready after ";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(645f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 1734f, 6f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "_Strength";
					GUILayoutOption[] array5 = new GUILayoutOption[1];
					array5[1] = GUILayout.Width(119f);
					GUILayout.Label(text5, array5);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 11f, 326f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "fids";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(689f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 873f, 605f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(479f);
					GUILayout.Label(text7, array7);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 991f, 459f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "importanttitle";
					GUILayoutOption[] array8 = new GUILayoutOption[1];
					array8[1] = GUILayout.Width(1742f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 1694f, 676f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = "$CHOICEMETA";
					GUILayoutOption[] array9 = new GUILayoutOption[1];
					array9[1] = GUILayout.Width(1243f);
					GUILayout.Label(text9, array9);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 1924f, 586f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "OnRewardOptionProfileClick";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[1] = GUILayout.Width(1994f);
					GUILayout.Label(text10, array10);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 303f, 1934f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = ") > totalOffloadedCounter (";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[1] = GUILayout.Width(684f);
					GUILayout.Label(text11, array11);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 1476f, 617f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "OnLanguageChange";
					GUILayoutOption[] array12 = new GUILayoutOption[1];
					array12[1] = GUILayout.Width(1255f);
					GUILayout.Label(text12, array12);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 119f, 866f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "\"";
					GUILayoutOption[] array13 = new GUILayoutOption[1];
					array13[1] = GUILayout.Width(1369f);
					GUILayout.Label(text13, array13);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 1578f, 1904f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "stat4long";
					GUILayoutOption[] array14 = new GUILayoutOption[0];
					array14[1] = GUILayout.Width(826f);
					GUILayout.Label(text14, array14);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 414f, 463f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = " ";
					GUILayoutOption[] array15 = new GUILayoutOption[1];
					array15[1] = GUILayout.Width(440f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 1087f, 176f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("lobby", new GUILayoutOption[]
					{
						GUILayout.Width(1338f)
					});
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 499f, 1497f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ok", new GUILayoutOption[]
					{
						GUILayout.Width(46f)
					});
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1947f, 1010f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(":", new GUILayoutOption[]
					{
						GUILayout.Width(374f)
					});
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 209f, 997f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("assetbundleprofiledata3", new GUILayoutOption[]
					{
						GUILayout.Width(310f)
					});
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 933f, 1f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("e", new GUILayoutOption[]
					{
						GUILayout.Width(850f)
					});
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 1641f, 889f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("acts", new GUILayoutOption[]
					{
						GUILayout.Width(461f)
					});
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1754f, 1855f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("", new GUILayoutOption[]
					{
						GUILayout.Width(449f)
					});
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 1459f, 645f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnUpdateSocialEventsCounter", new GUILayoutOption[]
					{
						GUILayout.Width(921f)
					});
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 87f, 418f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[1] = GUILayout.Width(1917f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 600f, 409f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("energyhinttitle", new GUILayoutOption[]
					{
						GUILayout.Width(1829f)
					});
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 615f, 1100f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "OnSaveSlotCopyMarked";
					GUILayoutOption[] array17 = new GUILayoutOption[1];
					array17[1] = GUILayout.Width(1852f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 1933f, 870f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "Error. Unknown import variable type:";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(146f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 610f, 1825f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.face: bulk choice index must be > 0.";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(351f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1258f, 1102f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("<align=\"center\"><alpha=#88>", new GUILayoutOption[]
					{
						GUILayout.Width(842f)
					});
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1991f, 1927f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnBackendSavePublicProfileSuccess", new GUILayoutOption[]
					{
						GUILayout.Width(1068f)
					});
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 1248f, 550f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("newuseraddrequest1", new GUILayoutOption[]
					{
						GUILayout.Width(1109f)
					});
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1646f, 430f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("x", new GUILayoutOption[]
					{
						GUILayout.Width(400f)
					});
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1760f, 1476f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "ext";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(680f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 901f, 1318f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnConsumeEnergySuccess", new GUILayoutOption[]
					{
						GUILayout.Width(454f)
					});
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 6f, 673f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = "), treated as none";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[1] = GUILayout.Width(1994f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 1488f, 1571f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "<i>";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[1] = GUILayout.Width(534f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 720f, 464f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "$GETVAR";
					GUILayoutOption[] array23 = new GUILayoutOption[1];
					array23[1] = GUILayout.Width(672f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1776f, 406f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("QueueCustomCode() already contains this request:", new GUILayoutOption[]
					{
						GUILayout.Width(1709f)
					});
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 482f, 632f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "_";
					GUILayoutOption[] array24 = new GUILayoutOption[1];
					array24[1] = GUILayout.Width(257f);
					GUILayout.Label(text24, array24);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 722f, 558f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x002EC57C File Offset: 0x002EA77C
		private void NMMAKLKJMNN(string ECCGLJGCBGC, string PNPFMFGBFPC, LogType OBKCKGHFMDN)
		{
			if (OBKCKGHFMDN == LogType.Error)
			{
				this.DCFGAKDAANL.Add("OnPopupUsernameInputCancel" + ECCGLJGCBGC);
				this.DCFGAKDAANL.Add("abfc" + PNPFMFGBFPC);
				return;
			}
			if (OBKCKGHFMDN == (LogType)8)
			{
				this.DCFGAKDAANL.Add("noisedigitalovr" + ECCGLJGCBGC);
				return;
			}
			this.DCFGAKDAANL.Add("XXX" + ECCGLJGCBGC);
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x002EC5EC File Offset: 0x002EA7EC
		private void ELFPILHKOMH(ImageEffectBase BMFJMDHHEKK)
		{
			if (BMFJMDHHEKK.GetType() == typeof(VideoGlitchBrokenScreen))
			{
				((VideoGlitchBrokenScreen)BMFJMDHHEKK).impact = new Vector2(UnityEngine.Random.Range(1451f, 915f), UnityEngine.Random.Range(1761f, 412f));
			}
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x002EC63E File Offset: 0x002EA83E
		private string PBKHNNFEEPP(string ODGNIFJGEHL)
		{
			return Regex.Replace(ODGNIFJGEHL, "OnLobbyLoungeAssetsDownloadFailed", "shamt");
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x002EC650 File Offset: 0x002EA850
		private void KHFIFGADNMA(ImageEffectBase BMFJMDHHEKK)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			string text = "[FlagAnimator] Shader 'YourStory/FlagShadow' NOT FOUND. Check that FlagShadow.shader is imported in the project.";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1747f);
			GUILayout.Label(text, array);
			BMFJMDHHEKK.amount = GUILayout.HorizontalSlider(BMFJMDHHEKK.amount, 1146f, 324f, Array.Empty<GUILayoutOption>());
			GUILayout.EndHorizontal();
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x002EC6AC File Offset: 0x002EA8AC
		private void FFHBHEKLJEF(ImageEffectBase BMFJMDHHEKK)
		{
			Type type = BMFJMDHHEKK.GetType();
			if (type == typeof(VideoGlitchShift))
			{
				VideoGlitchShift videoGlitchShift = BMFJMDHHEKK as VideoGlitchShift;
				if (videoGlitchShift != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("OnValidatePendingProcessed", new GUILayoutOption[]
					{
						GUILayout.Width(1023f)
					});
					videoGlitchShift.amplitude = GUILayout.HorizontalSlider(videoGlitchShift.amplitude, 1643f, 1289f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text = "";
					GUILayoutOption[] array = new GUILayoutOption[0];
					array[1] = GUILayout.Width(1224f);
					GUILayout.Label(text, array);
					videoGlitchShift.speed = GUILayout.HorizontalSlider(videoGlitchShift.speed, 1852f, 1432f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchNoiseDigital))
			{
				VideoGlitchNoiseDigital videoGlitchNoiseDigital = BMFJMDHHEKK as VideoGlitchNoiseDigital;
				if (videoGlitchNoiseDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text2 = "importanttitle";
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(1640f);
					GUILayout.Label(text2, array2);
					videoGlitchNoiseDigital.threshold = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.threshold, 796f, 536f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text3 = "";
					GUILayoutOption[] array3 = new GUILayoutOption[1];
					array3[1] = GUILayout.Width(344f);
					GUILayout.Label(text3, array3);
					videoGlitchNoiseDigital.maxOffset = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.maxOffset, 1484f, 1704f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text4 = "avatarstitle";
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(855f);
					GUILayout.Label(text4, array4);
					videoGlitchNoiseDigital.thresholdYUV = GUILayout.HorizontalSlider(videoGlitchNoiseDigital.thresholdYUV, 561f, 1414f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBlackWhiteDistortion))
			{
				VideoGlitchBlackWhiteDistortion videoGlitchBlackWhiteDistortion = BMFJMDHHEKK as VideoGlitchBlackWhiteDistortion;
				if (videoGlitchBlackWhiteDistortion != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text5 = "BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:";
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[0] = GUILayout.Width(13f);
					GUILayout.Label(text5, array5);
					videoGlitchBlackWhiteDistortion.distortionSteps = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSteps, 766f, 1812f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text6 = "dialogOffsetYPlayerSideSeparate";
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(1761f);
					GUILayout.Label(text6, array6);
					videoGlitchBlackWhiteDistortion.distortionSpeed = GUILayout.HorizontalSlider(videoGlitchBlackWhiteDistortion.distortionSpeed, 1609f, 1964f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchBrokenScreen))
			{
				VideoGlitchBrokenScreen videoGlitchBrokenScreen = BMFJMDHHEKK as VideoGlitchBrokenScreen;
				if (videoGlitchBrokenScreen != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Asset bundle load operation failed during parallel mode.", new GUILayoutOption[]
					{
						GUILayout.Width(1866f)
					});
					videoGlitchBrokenScreen.splits = (int)GUILayout.HorizontalSlider((float)videoGlitchBrokenScreen.splits, 180f, 1382f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text7 = "ok";
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[1] = GUILayout.Width(155f);
					GUILayout.Label(text7, array7);
					videoGlitchBrokenScreen.splitThreshold = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.splitThreshold, 468f, 1812f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text8 = "htmeo";
					GUILayoutOption[] array8 = new GUILayoutOption[0];
					array8[1] = GUILayout.Width(1442f);
					GUILayout.Label(text8, array8);
					videoGlitchBrokenScreen.distortion = GUILayout.HorizontalSlider(videoGlitchBrokenScreen.distortion, 1466f, 1956f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchRGBDisplay))
			{
				VideoGlitchRGBDisplay videoGlitchRGBDisplay = BMFJMDHHEKK as VideoGlitchRGBDisplay;
				if (videoGlitchRGBDisplay != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text9 = ".";
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(540f);
					GUILayout.Label(text9, array9);
					videoGlitchRGBDisplay.cellSize = (int)GUILayout.HorizontalSlider((float)videoGlitchRGBDisplay.cellSize, 616f, 1833f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchSpectrumOffset))
			{
				VideoGlitchSpectrumOffset videoGlitchSpectrumOffset = BMFJMDHHEKK as VideoGlitchSpectrumOffset;
				if (videoGlitchSpectrumOffset != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text10 = "spld";
					GUILayoutOption[] array10 = new GUILayoutOption[0];
					array10[0] = GUILayout.Width(273f);
					GUILayout.Label(text10, array10);
					videoGlitchSpectrumOffset.strength = GUILayout.HorizontalSlider(videoGlitchSpectrumOffset.strength, 1540f, 1367f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text11 = "";
					GUILayoutOption[] array11 = new GUILayoutOption[0];
					array11[1] = GUILayout.Width(312f);
					GUILayout.Label(text11, array11);
					videoGlitchSpectrumOffset.steps = (int)GUILayout.HorizontalSlider((float)videoGlitchSpectrumOffset.steps, 256f, 1929f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTape))
			{
				VideoGlitchOldTape videoGlitchOldTape = BMFJMDHHEKK as VideoGlitchOldTape;
				if (videoGlitchOldTape != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text12 = "Shaders/VideoGlitchBlackWhiteDistortion";
					GUILayoutOption[] array12 = new GUILayoutOption[0];
					array12[1] = GUILayout.Width(665f);
					GUILayout.Label(text12, array12);
					videoGlitchOldTape.noiseSpeed = GUILayout.HorizontalSlider(videoGlitchOldTape.noiseSpeed, 1054f, 1716f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text13 = "w";
					GUILayoutOption[] array13 = new GUILayoutOption[0];
					array13[1] = GUILayout.Width(317f);
					GUILayout.Label(text13, array13);
					videoGlitchOldTape.noiseAmplitude = (float)((int)GUILayout.HorizontalSlider(videoGlitchOldTape.noiseAmplitude, 462f, 1553f, Array.Empty<GUILayoutOption>()));
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchVHSPause))
			{
				VideoGlitchVHSPause videoGlitchVHSPause = BMFJMDHHEKK as VideoGlitchVHSPause;
				if (videoGlitchVHSPause != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(" ", new GUILayoutOption[]
					{
						GUILayout.Width(1707f)
					});
					videoGlitchVHSPause.strength = GUILayout.HorizontalSlider(videoGlitchVHSPause.strength, 1516f, 1531f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text14 = "Asset bundle load operation failed during parallel mode.";
					GUILayoutOption[] array14 = new GUILayoutOption[1];
					array14[1] = GUILayout.Width(770f);
					GUILayout.Label(text14, array14);
					videoGlitchVHSPause.colorNoise = GUILayout.HorizontalSlider(videoGlitchVHSPause.colorNoise, 1322f, 127f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchOldTV))
			{
				VideoGlitchOldTV videoGlitchOldTV = BMFJMDHHEKK as VideoGlitchOldTV;
				if (videoGlitchOldTV != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text15 = "OnChoiceExtendedEnvironmentChange";
					GUILayoutOption[] array15 = new GUILayoutOption[0];
					array15[1] = GUILayout.Width(1988f);
					GUILayout.Label(text15, array15);
					videoGlitchOldTV.slowScan = GUILayout.HorizontalSlider(videoGlitchOldTV.slowScan, 1873f, 608f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("ok", new GUILayoutOption[]
					{
						GUILayout.Width(125f)
					});
					videoGlitchOldTV.scanLine = GUILayout.HorizontalSlider(videoGlitchOldTV.scanLine, 369f, 179f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text16 = "blur";
					GUILayoutOption[] array16 = new GUILayoutOption[0];
					array16[0] = GUILayout.Width(617f);
					GUILayout.Label(text16, array16);
					videoGlitchOldTV.vignetteSoftness = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteSoftness, 408f, 1545f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text17 = "1";
					GUILayoutOption[] array17 = new GUILayoutOption[1];
					array17[1] = GUILayout.Width(1850f);
					GUILayout.Label(text17, array17);
					videoGlitchOldTV.vignetteScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteScale, 1647f, 1828f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text18 = "CCC";
					GUILayoutOption[] array18 = new GUILayoutOption[0];
					array18[0] = GUILayout.Width(1486f);
					GUILayout.Label(text18, array18);
					videoGlitchOldTV.grainOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.grainOpacity, 591f, 763f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text19 = "ok";
					GUILayoutOption[] array19 = new GUILayoutOption[0];
					array19[0] = GUILayout.Width(629f);
					GUILayout.Label(text19, array19);
					videoGlitchOldTV.grainSaturation = GUILayout.HorizontalSlider(videoGlitchOldTV.grainSaturation, 774f, 1389f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text20 = "sfav";
					GUILayoutOption[] array20 = new GUILayoutOption[0];
					array20[1] = GUILayout.Width(339f);
					GUILayout.Label(text20, array20);
					videoGlitchOldTV.scanDistort = GUILayout.HorizontalSlider(videoGlitchOldTV.scanDistort, 743f, 0f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text21 = ". ";
					GUILayoutOption[] array21 = new GUILayoutOption[0];
					array21[0] = GUILayout.Width(614f);
					GUILayout.Label(text21, array21);
					videoGlitchOldTV.timer = GUILayout.HorizontalSlider(videoGlitchOldTV.timer, 1803f, 1000f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text22 = "ERROR: GetSketchesActorsBalance(), AssetsManager.Instance.headersPacksAssets is empty.";
					GUILayoutOption[] array22 = new GUILayoutOption[0];
					array22[1] = GUILayout.Width(1984f);
					GUILayout.Label(text22, array22);
					videoGlitchOldTV.speed = GUILayout.HorizontalSlider(videoGlitchOldTV.speed, 645f, 1191f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text23 = "p";
					GUILayoutOption[] array23 = new GUILayoutOption[0];
					array23[1] = GUILayout.Width(516f);
					GUILayout.Label(text23, array23);
					videoGlitchOldTV.crtScale = GUILayout.HorizontalSlider(videoGlitchOldTV.crtScale, 670f, 145f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("blur", new GUILayoutOption[]
					{
						GUILayout.Width(686f)
					});
					videoGlitchOldTV.stripesCount = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesCount, 1262f, 1191f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text24 = "err";
					GUILayoutOption[] array24 = new GUILayoutOption[0];
					array24[0] = GUILayout.Width(157f);
					GUILayout.Label(text24, array24);
					videoGlitchOldTV.stripesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.stripesOpacity, 1621f, 887f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text25 = "Asset bundle assets destroyed:";
					GUILayoutOption[] array25 = new GUILayoutOption[0];
					array25[1] = GUILayout.Width(81f);
					GUILayout.Label(text25, array25);
					videoGlitchOldTV.barsCount = GUILayout.HorizontalSlider(videoGlitchOldTV.barsCount, 892f, 1272f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text26 = "OnBackendSavePublicProfileException";
					GUILayoutOption[] array26 = new GUILayoutOption[1];
					array26[1] = GUILayout.Width(1338f);
					GUILayout.Label(text26, array26);
					videoGlitchOldTV.moireOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.moireOpacity, 1989f, 372f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text27 = "LobbySearchBar.SetQueryAndApply: bar inactive, query kept as text only";
					GUILayoutOption[] array27 = new GUILayoutOption[0];
					array27[1] = GUILayout.Width(1355f);
					GUILayout.Label(text27, array27);
					videoGlitchOldTV.moireScale = GUILayout.HorizontalSlider(videoGlitchOldTV.moireScale, 1860f, 1259f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text28 = "body";
					GUILayoutOption[] array28 = new GUILayoutOption[0];
					array28[0] = GUILayout.Width(588f);
					GUILayout.Label(text28, array28);
					videoGlitchOldTV.tvLines = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLines, 379f, 771f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label(" bundle", new GUILayoutOption[]
					{
						GUILayout.Width(941f)
					});
					videoGlitchOldTV.tvLinesOpacity = GUILayout.HorizontalSlider(videoGlitchOldTV.tvLinesOpacity, 599f, 1989f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text29 = "AAA";
					GUILayoutOption[] array29 = new GUILayoutOption[1];
					array29[1] = GUILayout.Width(1598f);
					GUILayout.Label(text29, array29);
					videoGlitchOldTV.vignetteTubeScale = GUILayout.HorizontalSlider(videoGlitchOldTV.vignetteTubeScale, 153f, 1970f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text30 = "[LoadingEnv] skipped, caching system not ready after ";
					GUILayoutOption[] array30 = new GUILayoutOption[0];
					array30[0] = GUILayout.Width(1535f);
					GUILayout.Label(text30, array30);
					videoGlitchOldTV.tvDots = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDots, 71f, 1834f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text31 = "$IGNORECHOICE";
					GUILayoutOption[] array31 = new GUILayoutOption[0];
					array31[1] = GUILayout.Width(737f);
					GUILayout.Label(text31, array31);
					videoGlitchOldTV.tvDotsBlend = GUILayout.HorizontalSlider(videoGlitchOldTV.tvDotsBlend, 1485f, 1805f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					return;
				}
			}
			else if (type == typeof(VideoGlitchCorruptionDigital))
			{
				VideoGlitchCorruptionDigital videoGlitchCorruptionDigital = BMFJMDHHEKK as VideoGlitchCorruptionDigital;
				if (videoGlitchCorruptionDigital != null)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text32 = "";
					GUILayoutOption[] array32 = new GUILayoutOption[1];
					array32[1] = GUILayout.Width(1588f);
					GUILayout.Label(text32, array32);
					videoGlitchCorruptionDigital.strength = GUILayout.HorizontalSlider(videoGlitchCorruptionDigital.strength, 133f, 749f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					string text33 = "small";
					GUILayoutOption[] array33 = new GUILayoutOption[0];
					array33[0] = GUILayout.Width(48f);
					GUILayout.Label(text33, array33);
					videoGlitchCorruptionDigital.tileSize = (int)GUILayout.HorizontalSlider((float)videoGlitchCorruptionDigital.tileSize, 650f, 900f, Array.Empty<GUILayoutOption>());
					GUILayout.EndHorizontal();
				}
			}
		}

		// Token: 0x04001D03 RID: 7427
		public bool guiShow = true;

		// Token: 0x04001D04 RID: 7428
		public bool showEffectName;

		// Token: 0x04001D05 RID: 7429
		public float slideEffectTime;

		// Token: 0x04001D06 RID: 7430
		public AudioClip musicClip;

		// Token: 0x04001D07 RID: 7431
		private float MMIGFOEJONF;

		// Token: 0x04001D08 RID: 7432
		private List<ImageEffectBase> LBAHADAEAIM = new List<ImageEffectBase>();

		// Token: 0x04001D09 RID: 7433
		private int KHEAPHJLFJM;

		// Token: 0x04001D0A RID: 7434
		private bool JFEKALLDNPO;

		// Token: 0x04001D0B RID: 7435
		private bool MMGIPICEOCE;

		// Token: 0x04001D0C RID: 7436
		private const float DKLCIFMNLNH = 10f;

		// Token: 0x04001D0D RID: 7437
		private const float OOJJAFJBNDC = 200f;

		// Token: 0x04001D0E RID: 7438
		private const string JHAIPPNHLNO = "   ";

		// Token: 0x04001D0F RID: 7439
		private Vector2 KFKFGEOCEIB = Vector2.zero;

		// Token: 0x04001D10 RID: 7440
		private Vector2 OIJCKMIBIAH = Vector2.zero;

		// Token: 0x04001D11 RID: 7441
		private float CDOMPFPDIPE = 0.5f;

		// Token: 0x04001D12 RID: 7442
		private float HKHBAGONAGN;

		// Token: 0x04001D13 RID: 7443
		private int DLGOAPLDOAC;

		// Token: 0x04001D14 RID: 7444
		private float KOENBLJPMOA;

		// Token: 0x04001D15 RID: 7445
		private float MDPOKFEJPKO;

		// Token: 0x04001D16 RID: 7446
		private GUIStyle NMLJKEBPGPE;

		// Token: 0x04001D17 RID: 7447
		private GUIStyle CCNEEAGFDEF;

		// Token: 0x04001D18 RID: 7448
		private List<string> DCFGAKDAANL = new List<string>();
	}
}
