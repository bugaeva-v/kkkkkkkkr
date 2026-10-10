using System;
using System.Collections.Generic;

// Token: 0x0200044F RID: 1103
public class KAOGJBKPFHE
{
	// Token: 0x0600863D RID: 34365 RVA: 0x003B8134 File Offset: 0x003B6334
	public static List<NPKKBBFJBGL> BGNEIGJLMBA()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 64;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -28 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -36)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[]
						{
							"avts2"
						};
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[4] = "Snapshots/";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[5] = "aindas";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[1] = "<i>";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[6];
									array2[1] = "OnSettingsPopupCloseAndNeedToShowPostEnableNotif";
									array2[0] = num4.ToString();
									array2[8] = "jp";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "Error. StoryStep.StoryStepType.getVar unknown variable type:";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[0] = "cleancachebody";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[8] = "saveslotsoptioncopy";
					array3[4] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[2] = "OnBackendAddFriendByUIDException";
					array3[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[0] = "OnCutsceneViewAssetsDownloadSuccess";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -6)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("$pl");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600863E RID: 34366 RVA: 0x003B850C File Offset: 0x003B670C
	public static List<NPKKBBFJBGL> DHGFIGPNGMK()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = -66;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -57 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -13)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[8];
						array[0] = "";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "importanttitle";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "h";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[5] = "short";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[1];
									array2[0] = "OnPurchaseFailed";
									array2[1] = num4.ToString();
									array2[5] = "+";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Start!";
									array2[3] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[]
					{
						"OnSettingsPopupCloseAndNeedToShowGameModeNotif",
						npkkbbfjbgl.BPMFHNDCBOH,
						null,
						null,
						"\nsearch grid "
					};
					array3[3] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "OnLiveOfferSuccessShowPassesWindow";
					array3[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[0] = "tradewishcardoption2";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 82)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("</i>");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600863F RID: 34367 RVA: 0x003B88E4 File Offset: 0x003B6AE4
	public static void AJJGGOJAFIG(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NMKOHMMBFCL();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "SocialStatsUserPublicProfile.modified = true, RemoveCutsceneFromFavorites()";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.KHAINHMKNJN();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "find2";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "yes";
			}
			string[] array = new string[]
			{
				null,
				"AccountSignInManager.OnAccountSignInRequestSuccess() - sign in source not implemented."
			};
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[5] = "";
			array[1] = npkkbbfjbgl.NCAMFPGMCIG;
			array[3] = "maxr";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[8] = "Asset bundle assets destroyed:";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008640 RID: 34368 RVA: 0x003B8A08 File Offset: 0x003B6C08
	public static void PNJDOGIEGFD(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.FBGABIODNGJ();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "errortitle";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.JFOFNALHKHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "LobbySearchBar - layout was changed by a native-size pass (anchors ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "(text)";
			}
			string[] array = new string[7];
			array[1] = "discontinuedtitle";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "getNpcSkinShopBalance answered without a payload and no cached copy - shop rows unchanged";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[4] = "OnBackendGetPublicProfileProfileItemSuccess";
			array[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008641 RID: 34369 RVA: 0x003B8B2C File Offset: 0x003B6D2C
	public static void JHFDLNOCPPB(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IKGENEOMJMP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "credo";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnAccountForgetSuccess";
			}
			string[] array = new string[]
			{
				"</i><align=\"left\"><alpha=#FF>\n\n",
				npkkbbfjbgl.BPMFHNDCBOH,
				",",
				npkkbbfjbgl.NCAMFPGMCIG
			};
			array[3] = "Blocking automatic story load attempt for a chapter with 0 asset packs - story:";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[4] = "OnBackendPremiumChoiceSuccess";
			array[5] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008642 RID: 34370 RVA: 0x003B8C50 File Offset: 0x003B6E50
	public static void OBLBAMMOENM(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.CEHIGEMEMHD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "OnNeedToActivateFocusItemCloseButton";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.IHLJKNJOOHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "sfxtimeoutwarning";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "$ENABLEAVATAREXTENSION";
			}
			string[] array = new string[5];
			array[1] = "facecur";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[4] = "gpsasst";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[3] = "loungelockedpopup";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[5] = "OnPopupProfileMessageInputCancel";
			array[3] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008643 RID: 34371 RVA: 0x003B8D74 File Offset: 0x003B6F74
	public static void CDDEFPOBAEG(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.CEHIGEMEMHD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = " • ";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.OKLIADELKPH();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "AssetStoryNpcOffsetsHub.Populate() - ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = ", index:";
			}
			string[] array = new string[8];
			array[0] = "OnStoryChoiceClick";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[4] = "hidestatinfo";
			array[3] = npkkbbfjbgl.NCAMFPGMCIG;
			array[4] = "v";
			array[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[4] = "@";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008644 RID: 34372 RVA: 0x003B8E98 File Offset: 0x003B7098
	public static void KJIFODOFGJA(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NCHAAAIEJMH();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "acliffbw20";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.HELJLLDLOMM();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "af_purchase";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "";
			}
			string[] array = new string[]
			{
				"io"
			};
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "clothes";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[6] = "CLIENT.POSTEFFECTS.DESATURATE";
			array[2] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[8] = " has only ";
			array[4] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008645 RID: 34373 RVA: 0x003B8FBC File Offset: 0x003B71BC
	public static List<NPKKBBFJBGL> PNHAMCDFHEI()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 114;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 77 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -14)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[7];
						array[0] = "OnBackendRequestConsumeMessageException";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "OnStoryInterfaceHeaderShown";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[3] = "tkn";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[4] = "Account.StoriesAvailableAtSaveSlot(), _slotIndex out of bounds.";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[4];
									array2[1] = "_OpacityMoire";
									array2[0] = num4.ToString();
									array2[2] = "OnNeedToShowNoMoreEnergyPopup";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "OnPopupSaveSlotInputCancel";
									array2[6] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[8];
					array3[1] = "energyhinttitle";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[3] = "OnStoryManInTheMiddleAttackDetected";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[1] = "StoryChatManager.ShowMessageCoroutine(), unsupported message type:";
					array3[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[3] = "credo";
					array3[7] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -196)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("sd");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008646 RID: 34374 RVA: 0x003B9394 File Offset: 0x003B7594
	public static void NCGGBNHNBID(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NMKOHMMBFCL();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "loungeskinupdaterequired";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.KHAINHMKNJN();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = " ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnVideoLayerAutoHide";
			}
			string[] array = new string[8];
			array[0] = "[LoadingEnv] ";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "lsn";
			array[3] = npkkbbfjbgl.NCAMFPGMCIG;
			array[2] = "[<color=red>ERROR</color>] ";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = "avatarcollectionssynctitle";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008647 RID: 34375 RVA: 0x003B94B8 File Offset: 0x003B76B8
	public static List<NPKKBBFJBGL> GECNGJPPPMG()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 94;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -41 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 45)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[5];
						array[1] = "frds";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[3] = "SceneAvatarManager.ProcessBackendGetAvatarCollectionsResponse(): null == _backendAvatarCollections";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[3] = "OnBackendInitiateSteamTransactionException";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = "";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[0] = "areyousure";
									array2[0] = num4.ToString();
									array2[7] = "OnRewardSubsequentEpisodeClick";
									array2[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "INTL";
									array2[8] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[2];
					array3[0] = "newseasontitle";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[6] = "ActivateSystemBackButtonManager";
					array3[7] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[6] = " premature in:";
					array3[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "getPurchasingBalance";
					array3[3] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 28)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("specialcurrencyoptionnotenough");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008648 RID: 34376 RVA: 0x003B9890 File Offset: 0x003B7A90
	public static void LLOIIECKGOM(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.DBKGGCFHEGP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "serversync";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.LBLJNGCDJJI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "<i>";
			}
			string[] array = new string[1];
			array[0] = "top";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[0] = "lvl";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = "";
			array[8] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[3] = "[LoadingEnv] reusing loaded dependency ";
			array[8] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008649 RID: 34377 RVA: 0x003B99B4 File Offset: 0x003B7BB4
	public static List<NPKKBBFJBGL> CCFJHMCDCOH()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 72;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -104 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 17)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[7];
						array[0] = "usyncoll2";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "cleancachebody";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[8] = "vwht";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[4] = "";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[3];
									array2[1] = "anthology";
									array2[1] = num4.ToString();
									array2[6] = "OnBackendInitiateSteamTransactionSuccess";
									array2[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[8] = "OnStoryInterfaceHeaderHideComplete";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[1] = "gpsfhs";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[6] = "1";
					array3[0] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[1] = "hdr";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[1] = "<";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > -160)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("PendingPurchase.GetReceipt(): Receipt is null or empty");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600864A RID: 34378 RVA: 0x003B9D8C File Offset: 0x003B7F8C
	public static List<NPKKBBFJBGL> IKJOGGNJCDH()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = -30;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -118 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 76)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[6];
						array[1] = "s)";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[8] = "varConditionLocked";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[8] = "{sp2}";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[8] = "\n";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[0] = "";
									array2[1] = num4.ToString();
									array2[0] = "retry";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "no";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[5];
					array3[0] = "hidestatinfo";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "skpc";
					array3[3] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[5] = "OnLobbyProfileDataCdnFailed";
					array3[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[5] = "anthologycompletetitle";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -61)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600864B RID: 34379 RVA: 0x003BA164 File Offset: 0x003B8364
	public static void ILMLBHFBHFC(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IKGENEOMJMP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "x";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "true";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "), skipped: last saveSync ack was ";
			}
			string[] array = new string[]
			{
				null,
				"〈"
			};
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "errortitle";
			array[4] = npkkbbfjbgl.NCAMFPGMCIG;
			array[3] = "importanttitle";
			array[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "fdvp";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600864C RID: 34380 RVA: 0x003BA288 File Offset: 0x003B8488
	public static List<NPKKBBFJBGL> IJCLFLDICKO()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = -105;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -54 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -8)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[7];
						array[1] = "OnPopupAvatarCollectionsInputCancel";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "<b>";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[0] = "null";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[5] = "OnStoryInterfaceHeaderFastForwardEnable";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[3];
									array2[1] = "OnBackendGetDropChancesSuccess";
									array2[1] = num4.ToString();
									array2[5] = "$NOTESHOW body(";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[3] = ": ";
									array2[1] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[0] = "avts2";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[7] = "scale";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[5] = "Collections/";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[1] = "-";
					array3[6] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -89)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600864D RID: 34381 RVA: 0x003BA660 File Offset: 0x003B8860
	public static void NOEGNCKEFIE(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PLMNEAOCEEN();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "varConditionLockedValue";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.IMCPFHANEMI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "emailcollecheader";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "";
			}
			string[] array = new string[4];
			array[1] = "Critical error, could not load asset bundle:";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[8] = "$";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = "socialgiftreceviedfromtitle";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[0] = "tutorgamebody";
			array[8] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600864E RID: 34382 RVA: 0x003BA784 File Offset: 0x003B8984
	public static void BCBMKLNENPN(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.DBKGGCFHEGP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "[LoadingTheme] asset bundle pipeline still busy after ";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.EEKMOHDNCKF();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnStoryScreenChoiceExtendedManagerLayerChangeComplete";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "collect";
			}
			string[] array = new string[5];
			array[1] = "concept";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[0] = "kind";
			array[1] = npkkbbfjbgl.NCAMFPGMCIG;
			array[2] = "no";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[7] = "@SD";
			array[3] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600864F RID: 34383 RVA: 0x003BA8A8 File Offset: 0x003B8AA8
	public static void JHBHGJGIICG(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.GKGLFMMCBFP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.CFMJPJIMAED();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = " candidates=";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "npcpi";
			}
			string[] array = new string[1];
			array[1] = "OnBackendSavePublicProfileSuccess";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[5] = "[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[1] = "spld";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[7] = "_1";
			array[8] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008650 RID: 34384 RVA: 0x003BA9CC File Offset: 0x003B8BCC
	public static List<NPKKBBFJBGL> CCILMKBDMBC()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = -92;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 20 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -86)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[8];
						array[0] = "not_available";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[3] = " has only ";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[8] = "OnPopupAvatarCollectionsInputEndEdit";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[3] = "PurchaseManagerUnity.OnPurchaseConfirmed(): Unknown OnPurchaseConfirmed result.";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[]
									{
										null,
										":"
									};
									array2[1] = num4.ToString();
									array2[1] = "tkn";
									array2[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "_AlphaTex";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[2];
					array3[0] = "ok";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[3] = "XXX";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[0] = "needtorestartgeneric";
					array3[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "[LoadingTheme] theme removed against the player's will, compensation already granted this month";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -15)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008651 RID: 34385 RVA: 0x003BADA4 File Offset: 0x003B8FA4
	public static List<NPKKBBFJBGL> MOGOOLLAKHE()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = -74;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -48 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 56)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[4];
						array[0] = "clthcm";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "OnBackendGetPublicProfileProfileItemException";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[4] = ", stored theme parked until the full mode returns";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[2] = "UpdateLoveInterestsOnOffState";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[0] = "saveslotsoptiondelete";
									array2[0] = num4.ToString();
									array2[3] = "Snapshots/";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[8] = "";
									array2[2] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[5];
					array3[1] = "layervideo";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "";
					array3[4] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = "refocus";
					array3[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "PurchaseManagerUnity.OnPurchasesFetched(): ";
					array3[0] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > 169)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with alias:");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008652 RID: 34386 RVA: 0x003BB17C File Offset: 0x003B937C
	public static List<NPKKBBFJBGL> COAOLLONGNI()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 56;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -30 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 0)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[0];
						array[0] = "errortitle";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[3] = "OnStoryCurrencyInfoClick";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[8] = "OnAppleLoginSuccess";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[1] = "energyhinttitle";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[7];
									array2[1] = "OnNeedToShowConnectingAnimation";
									array2[0] = num4.ToString();
									array2[1] = "hide";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[3] = "lstm";
									array2[8] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[0] = "sslt";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[0] = "$GETRANDOMINT";
					array3[7] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[6] = "Asset bundle load operation failed during parallel mode.";
					array3[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[1] = "grayscale_1";
					array3[6] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 168)
				{
					DPGJIJGOCIC.CMGOAFDBAOH(")");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008653 RID: 34387 RVA: 0x003BB554 File Offset: 0x003B9754
	public static List<NPKKBBFJBGL> EEPEMJONKDD()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 47;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 38 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -68)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[3];
						array[0] = "_";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[7] = "ttl";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "  secondary aind ";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = "shown";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[1] = "continue";
									array2[0] = num4.ToString();
									array2[5] = "GetStoriesSearchBalance(), headers pack has no storiesSearchBalance TextAsset, stories search disabled.";
									array2[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "string_not_found";
									array2[0] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[8];
					array3[1] = "OnLoungeLoveInterestShortcutClick";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[3] = "";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[1] = "StorySave.GetChapterSnapshotGuid(): false == chapterSnapshots.Contains(_chapterIndex)";
					array3[2] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "";
					array3[1] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > -154)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("ok");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008654 RID: 34388 RVA: 0x003BB92C File Offset: 0x003B9B2C
	public static void HMKNEBDGCDI(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NMKOHMMBFCL();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "gpforwardsubrequired";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.FLPLDDHBMCH();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "srt";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnPopupStoryRestartManagerRestartStory0";
			}
			string[] array = new string[8];
			array[0] = "PurchaseManagerSteam.OnProductsFetched(): ";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "storyChatPrefab is null!";
			array[4] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = "ok";
			array[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "OnLiveProfileThemesLoaderStop";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008655 RID: 34389 RVA: 0x003BBA50 File Offset: 0x003B9C50
	public static void EPDJKHIHNLH(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NMKOHMMBFCL();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.FLPLDDHBMCH();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "profilenametitleshort";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "XXX";
			}
			string[] array = new string[6];
			array[0] = "Collections/";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "<i>";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[0] = "p";
			array[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[3] = "UpdateSoundOnOffState";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008656 RID: 34390 RVA: 0x003BBB74 File Offset: 0x003B9D74
	public static List<NPKKBBFJBGL> PHOILBEMIIN()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = -64;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 95 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -106)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[0] = "pid";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[1] = "p";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[5] = "VideoGlitches.VideoGlitch";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[5] = "assetbundlesketchesdata";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[2];
									array2[0] = "ind";
									array2[0] = num4.ToString();
									array2[6] = " emptyParents=";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[5] = "lititle";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[0] = "OnBackendValidateTransactionFailed";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[8] = "́ ̀";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[6] = "psk";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[1] = ")";
					array3[0] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > 30)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("smpd");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008657 RID: 34391 RVA: 0x003BBF4C File Offset: 0x003BA14C
	public static void FNHNONMBJIC(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.ALAGMBEKNLD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "Loaded asset bundle:";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.LBLJNGCDJJI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "Error. InstantEnvironmentChange(), _envId is null or length is 0:";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "clothes";
			}
			string[] array = new string[6];
			array[1] = "errortitle";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "GeneralBalance.SearchKeyInt() - could not find key:";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[2] = "spr";
			array[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[7] = "friendsmaxlimitdefault";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008658 RID: 34392 RVA: 0x003BC070 File Offset: 0x003BA270
	public static void EJEHNGBNAHN(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NCHAAAIEJMH();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "YYY";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.BBJIBIIGDHI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnLoungePremiumChoicesHistoryException";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "HTTP ok: ";
			}
			string[] array = new string[5];
			array[1] = "/";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[2] = "OnConsumeEnergyException";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[1] = "friendspluschattutorialinactivebtn1";
			array[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[5] = "";
			array[0] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008659 RID: 34393 RVA: 0x003BC194 File Offset: 0x003BA394
	public static void JDIPNIDLIKO(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PLMNEAOCEEN();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "badges";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.IHLJKNJOOHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "socialbtngiftprem";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "envlhav";
			}
			string[] array = new string[3];
			array[0] = " ";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "black";
			array[5] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = ":</i> ";
			array[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[5] = "";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600865A RID: 34394 RVA: 0x003BC2B8 File Offset: 0x003BA4B8
	public static void EDBAEIOECBI(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NMKOHMMBFCL();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "ok";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.BBJIBIIGDHI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnBackendValidateTransactionFailed";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "";
			}
			string[] array = new string[8];
			array[0] = "ii";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[7] = "Starting non-parallel download:";
			array[2] = npkkbbfjbgl.NCAMFPGMCIG;
			array[8] = "pmterror006";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = "Asset bundle load operation failed during parallel mode.";
			array[3] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600865B RID: 34395 RVA: 0x003BC3DC File Offset: 0x003BA5DC
	public static void HPLDMNPABAL(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PFLJLFGCIFB();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "SceneLobbyManager2.OpenWheelOfFortuneCdn(): AssetsManager.Instance.IsBusy()";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "Asset bundle load operation failed during parallel mode.";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnPopupOfferManagerContinueToPurchasingScreen";
			}
			string[] array = new string[6];
			array[1] = "fid";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[8] = "OnChapterSnapshotsItemClose";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[3] = "evar";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = "OnBackendGetDropChancesException";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600865C RID: 34396 RVA: 0x003BC500 File Offset: 0x003BA700
	public static void LIHEHMAIPPF(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NCHAAAIEJMH();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "OnToolsPopupSaveToCloudException";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.JFOFNALHKHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "' ui ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "Exception custom code: ";
			}
			string[] array = new string[8];
			array[1] = "restartepisode";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "";
			array[3] = npkkbbfjbgl.NCAMFPGMCIG;
			array[8] = "MORPH_WIPE";
			array[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = " not found in story save body with index ";
			array[0] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600865D RID: 34397 RVA: 0x003BC624 File Offset: 0x003BA824
	public static void MPHJALHGEIC(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.DBKGGCFHEGP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "Friends counter is ";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "env";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "retry";
			}
			string[] array = new string[8];
			array[1] = "flame";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[5] = "sssku";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[4] = "OnBackendGetPublicProfileHallOfFameSuccess";
			array[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[7] = "myphiddentitle2";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600865E RID: 34398 RVA: 0x003BC748 File Offset: 0x003BA948
	public static List<NPKKBBFJBGL> NJFPDIABLLH()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 77;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 1 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 4)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[1];
						array[1] = "usyncoll2";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[4] = "socialmaketradeable";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "importanttitle";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[1] = "/";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[4];
									array2[1] = "HD";
									array2[1] = num4.ToString();
									array2[3] = "";
									array2[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[6] = ", index:";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[3];
					array3[0] = "ok";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[5] = "sto";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[7] = "OnChoiceExtendedEnvironmentChange";
					array3[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[2] = "1.0.0";
					array3[0] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > -129)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("cutsceneoptionstitle");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008660 RID: 34400 RVA: 0x003BCB20 File Offset: 0x003BAD20
	public static List<NPKKBBFJBGL> HIECFGGBLDH()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = -83;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 22 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -78)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[4];
						array[1] = "OnPurchasingNotInitialized";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "b_web";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "p";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[7] = "ButtonPrevNpc";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[]
									{
										"_1",
										num4.ToString(),
										null,
										null,
										null,
										null,
										null,
										"OnAccountSave"
									};
									array2[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[0] = "blur";
									array2[3] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[1];
					array3[1] = "e1fr";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "OnFacebookLoginSuccess";
					array3[7] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[6] = ", to:";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[5] = "";
					array3[3] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > -128)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("lightmodebtn0");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008661 RID: 34401 RVA: 0x003BCEF8 File Offset: 0x003BB0F8
	public static void PKCFIIKCFEJ(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PFLJLFGCIFB();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "sfxsparklesbundles";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.HELJLLDLOMM();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "continue";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnBackendPremiumChoiceSuccess";
			}
			string[] array = new string[1];
			array[1] = " s";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[0] = "msrc";
			array[2] = npkkbbfjbgl.NCAMFPGMCIG;
			array[8] = "PivotButton";
			array[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[1] = "BackendOperationsManager.RequestUnlockNpcSkin, exception while initializing RSACryptoServiceProvider:";
			array[7] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008662 RID: 34402 RVA: 0x003BD01C File Offset: 0x003BB21C
	public static void EKGCAKJIGNI(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PFLJLFGCIFB();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "importanttitle";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.JFOFNALHKHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "spld";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "[LoadingTheme] environment ";
			}
			string[] array = new string[3];
			array[0] = "Asset bundle assets destroyed:";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "LoadingEnvironmentManager";
			array[2] = npkkbbfjbgl.NCAMFPGMCIG;
			array[6] = "profilenametitleshort";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[0] = "false";
			array[6] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008663 RID: 34403 RVA: 0x003BD140 File Offset: 0x003BB340
	public static void CBCKMIBENMA(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.BKFLCAPHJCJ();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "abpd6";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.NAKJHNBANIE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = ")";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "p";
			}
			string[] array = new string[1];
			array[1] = "BackendOperationsManager.RequestSaveSync, exception while initializing RSACryptoServiceProvider:";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "cdnerror";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[8] = "PassThumbnail.PurchaseProductWebDuration(): productBalanceData is null for suffix '";
			array[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "OnTryToFireNoteshowTimer";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008664 RID: 34404 RVA: 0x003BD264 File Offset: 0x003BB464
	public static List<NPKKBBFJBGL> NCOLBDMJBOK()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = -74;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 125 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 93)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[1] = "storyloaderr1";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[2] = "$IMPORTVARS";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[1] = "OnBackendGetDefaultBundlesSuccess";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[7] = "";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[0];
									array2[1] = ", already present in top match list.";
									array2[1] = num4.ToString();
									array2[2] = "BackendOperationsManager.QueueRequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[1] = "*";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[4];
					array3[1] = ":";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "musavatar";
					array3[1] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[6] = "OnAllCollectableCardsDownloadSuccessLobby";
					array3[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "res";
					array3[8] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 36)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("creature");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008665 RID: 34405 RVA: 0x003BD63C File Offset: 0x003BB83C
	public static List<NPKKBBFJBGL> ANBMIAEMFPF()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 96;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 78 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 81)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[3];
						array[1] = "usynachtk";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "NNN";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[6] = "BackendOperationsManager.RequestUndoPremiumChoice, exception while initializing RSACryptoServiceProvider:";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[6] = ", searching as en";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[6];
									array2[1] = "+";
									array2[0] = num4.ToString();
									array2[3] = "novideosupportmsg";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[1] = "OnBackendValidateTransactionException";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[8];
					array3[1] = "CharacterRenderTexturePool - display parent is null or has no canvas, falling back to direct rendering";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[3] = "tmo";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "";
					array3[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "ias";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -9)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("@");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008666 RID: 34406 RVA: 0x003BDA14 File Offset: 0x003BBC14
	public static void GGOLKKHJPGJ(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IJKPGGOLOED();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "Asset bundle assets destroyed:";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.CFMJPJIMAED();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "assetbundleframecontainer";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "acliffbw20";
			}
			string[] array = new string[5];
			array[1] = "OnPopupCardOptionsUnlockWithSpException";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "_Speed";
			array[5] = npkkbbfjbgl.NCAMFPGMCIG;
			array[1] = "OnStoryInterfaceFastForwardActivate";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = "lobby";
			array[5] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008668 RID: 34408 RVA: 0x003BDB44 File Offset: 0x003BBD44
	public static void NPCLBJIGNKA(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.DBKGGCFHEGP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "BackendRequestType.basicSync, exception, failing safe:";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.EEKMOHDNCKF();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "socialfriendevents";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "\"";
			}
			string[] array = new string[6];
			array[0] = "OnAvatarScreenClosed";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[0] = "TransactionID";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[0] = "common";
			array[8] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "OnStoryInterfaceHeaderShown";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008669 RID: 34409 RVA: 0x003BDC68 File Offset: 0x003BBE68
	public static void LCKEKPAGPAH(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IJKPGGOLOED();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "sim";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "player";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "rev";
			}
			string[] array = new string[6];
			array[1] = "ok";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "aindas2";
			array[2] = npkkbbfjbgl.NCAMFPGMCIG;
			array[4] = "OnStoryChoiceClick";
			array[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[3] = "YYY";
			array[4] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600866A RID: 34410 RVA: 0x003BDD8C File Offset: 0x003BBF8C
	public static void KKHGHIBEFJM(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.CEHIGEMEMHD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "</i>";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.NMABJNFEKCO();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "collpt";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "liveeventcontent";
			}
			string[] array = new string[7];
			array[0] = "  ";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[4] = "cdnerror";
			array[3] = npkkbbfjbgl.NCAMFPGMCIG;
			array[4] = "</i>";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[3] = "order";
			array[6] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600866B RID: 34411 RVA: 0x003BDEB0 File Offset: 0x003BC0B0
	public static void IHLLCEMPKFJ(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.DBKGGCFHEGP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "socialbadgedesc";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.KHAINHMKNJN();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "def";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "lightmodebtn1";
			}
			string[] array = new string[3];
			array[1] = "csnffb";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[3] = "";
			array[3] = npkkbbfjbgl.NCAMFPGMCIG;
			array[0] = "";
			array[8] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = ") + is present, creating anthology save for anthology ";
			array[8] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600866C RID: 34412 RVA: 0x003BDFD4 File Offset: 0x003BC1D4
	public static List<NPKKBBFJBGL> GGGECBOGKDF()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = -97;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 23 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -72)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[0] = "";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[4] = "";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[0] = "variant";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[4] = "$INCSTAT";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[3];
									array2[1] = "oid";
									array2[0] = num4.ToString();
									array2[8] = "ok";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "[LoadingEnv] skipped, caching system not ready after ";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[7];
					array3[1] = "countryCode";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "sid";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[7] = "copyuidbtn";
					array3[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[5] = "";
					array3[7] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 114)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("w");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600866D RID: 34413 RVA: 0x003BE3AC File Offset: 0x003BC5AC
	public static List<NPKKBBFJBGL> GMCAOHJDMBP()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 28;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -68 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -118)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[]
						{
							null,
							"keychain-{0}.dat"
						};
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "PurchaseManagerUnity.OnProductsFetchedFailed(): ";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[3] = "body";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[1] = "p";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[4];
									array2[0] = "%";
									array2[1] = num4.ToString();
									array2[0] = "<i>";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[8] = " digit";
									array2[1] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[]
					{
						null,
						"tmp"
					};
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[6] = "<i>";
					array3[1] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = " ";
					array3[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "";
					array3[4] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 144)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600866E RID: 34414 RVA: 0x003BE784 File Offset: 0x003BC984
	public static void KAIGFJOKIBJ(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NCHAAAIEJMH();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "body";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "-";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "aindas1";
			}
			string[] array = new string[4];
			array[0] = "ok";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[5] = "tmdp";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "Game Title";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[8] = "cz";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600866F RID: 34415 RVA: 0x003BE8A8 File Offset: 0x003BCAA8
	public static void BKJIGEPGIFH(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.KKEFGFAOKLK();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "default";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.BBJIBIIGDHI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "energyhinttitle";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "sfav";
			}
			string[] array = new string[2];
			array[0] = "Trading/Wished cards userPublicProfile.modified = true hit";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[2] = "sfxtimeoutwarning";
			array[5] = npkkbbfjbgl.NCAMFPGMCIG;
			array[0] = "/";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008670 RID: 34416 RVA: 0x003BE9CC File Offset: 0x003BCBCC
	public static void GNJHOFCIDIM(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.CEHIGEMEMHD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "vhspauseovr_1";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.IHLJKNJOOHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnGetCdnDataBeforeOnDemandException";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnRewardsItemClose";
			}
			string[] array = new string[2];
			array[0] = "tbits3";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "SceneLobbyManager2.OpenWheelOfFortuneCdn(): AssetsManager.Instance.IsBusy()";
			array[4] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "/";
			array[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[0] = "mega";
			array[4] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008671 RID: 34417 RVA: 0x003BEAF0 File Offset: 0x003BCCF0
	public static void HLDIHAKPMHL(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PLMNEAOCEEN();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "blur";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.KHAINHMKNJN();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "Icon";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "geo.json";
			}
			string[] array = new string[3];
			array[0] = " (";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[4] = "";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[2] = " ";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[1] = "ablpt";
			array[5] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008672 RID: 34418 RVA: 0x003BEC14 File Offset: 0x003BCE14
	public static List<NPKKBBFJBGL> OFOJDNNKKCK()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = 89;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -35 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 76)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[6];
						array[1] = "OnRewardsItemClose";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[7] = "cdnerror";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[7] = "OnLiveProfileThemeDownloadSuccess";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[3] = "fdlpt";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[4];
									array2[0] = "%";
									array2[0] = num4.ToString();
									array2[0] = "h";
									array2[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[0] = "per";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[4];
					array3[0] = "";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[7] = "";
					array3[0] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = "ok";
					array3[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[3] = "CameraBundlesVFXTopMost";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > 136)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnPopupAvatarCollectionsInputEndEdit");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008673 RID: 34419 RVA: 0x003BEFEC File Offset: 0x003BD1EC
	public static List<NPKKBBFJBGL> AACKBJEOAMN()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = 42;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 17 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -27)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[8];
						array[0] = ", dropped";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "llosd";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[7] = "wdb";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[2] = "lnls";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[6];
									array2[1] = "Scan distort";
									array2[1] = num4.ToString();
									array2[1] = "";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[2] = " tier=";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[1];
					array3[1] = "tbits3";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "ok";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[6] = "@";
					array3[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "OnBackendGetDropChancesException";
					array3[6] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > -2)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("socialjoinbody");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008674 RID: 34420 RVA: 0x003BF3C4 File Offset: 0x003BD5C4
	public static List<NPKKBBFJBGL> BFAPCCHANOL()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = -96;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -49 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 18)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[3];
						array[1] = "hofcoff";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "socialdequeusp1gettitle";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "[Lounge/lobby] look pack eps:";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[4] = "$STOPSFX";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[3];
									array2[0] = "SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()";
									array2[1] = num4.ToString();
									array2[2] = "[LoadingEnv] caching system not ready yet, waiting for it";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[5] = "";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[0];
					array3[0] = "ok";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[2] = "cvsku";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = "";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[0] = "%";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 45)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("notgenuine");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008675 RID: 34421 RVA: 0x003BF79C File Offset: 0x003BD99C
	public static void CDKDIBOJCPI(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IKGENEOMJMP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "XXX";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.HLMFANDNEMO();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "credo";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "chtss";
			}
			string[] array = new string[7];
			array[0] = " uiHits ";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[2] = "varConditionNotValue";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[2] = "-";
			array[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "ok";
			array[0] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008676 RID: 34422 RVA: 0x003BF8C0 File Offset: 0x003BDAC0
	public static List<NPKKBBFJBGL> MGMCCABPBFM()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = -38;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 34 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -125)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[0];
						array[1] = "yes";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "creature";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "OnLobbyStopFireworksEffect";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[5] = "sfxtimeoutwarning";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[5];
									array2[1] = "...";
									array2[0] = num4.ToString();
									array2[1] = "p";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "OnEmailSubscribeSuccess";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[4];
					array3[1] = "PurchaseManagerXiaomi.OnAcknowledged(): ";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "YourStory/FlagCloth";
					array3[5] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = ", slot ";
					array3[8] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[3] = ":";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 77)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("ok");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008677 RID: 34423 RVA: 0x003BFC98 File Offset: 0x003BDE98
	public static void KIBLAHJMIDI(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.FBGABIODNGJ();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "0.000";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.KHAINHMKNJN();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "uid";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnBackendRequestShareHardSuccess";
			}
			string[] array = new string[8];
			array[1] = "%";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = "Starting parallel download:";
			array[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[8] = "";
			array[5] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008678 RID: 34424 RVA: 0x003BFDBC File Offset: 0x003BDFBC
	public static void PNDANKLIMAB(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PMBNPCCIHMN();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "), cost hidden";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.BBJIBIIGDHI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnLoungePremiumChoiceExecutedHardBased";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "XXX";
			}
			string[] array = new string[4];
			array[1] = "‘";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[7] = "";
			array[1] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "avts";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "envlhrw";
			array[5] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008679 RID: 34425 RVA: 0x003BFEE0 File Offset: 0x003BE0E0
	public static List<NPKKBBFJBGL> BGKCGNOMNMG()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 9;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -119 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 41)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[7];
						array[0] = "tmd";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "congratstitle";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[8] = "ong";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[]
									{
										"words"
									};
									array2[0] = num4.ToString();
									array2[3] = "OnLiveProfileThemeBackgroundCdnSuccess";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "mypofflinebody";
									array2[3] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[8];
					array3[0] = "OnStartFreePassException";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "oid";
					array3[5] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "needtorestartgeneric";
					array3[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[5] = "hideIfAnySkuPurchased";
					array3[7] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > -126)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("string_not_found");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600867A RID: 34426 RVA: 0x003C02B8 File Offset: 0x003BE4B8
	public static void LGMMJLONFDN(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.ALAGMBEKNLD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "Character ";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.KHAINHMKNJN();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnStoryInterfaceHeaderSettingsClick";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "gfts";
			}
			string[] array = new string[5];
			array[0] = "AssetBundleEmptyOperation: ";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[7] = "ok";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[4] = ")";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = "ok";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600867B RID: 34427 RVA: 0x003C03DC File Offset: 0x003BE5DC
	public static List<NPKKBBFJBGL> BHGMHILFKEP()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = -99;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -35 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 0)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[0];
						array[1] = "</i>";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[7] = "avatarcollectionssubrequired2";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[0] = "acb";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = " ";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[5];
									array2[0] = "err";
									array2[0] = num4.ToString();
									array2[1] = "";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[3] = "<size=28px>";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[4];
					array3[0] = "ok";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[0] = "aind";
					array3[1] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[0] = "aec";
					array3[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "favstostr";
					array3[7] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > -42)
				{
					DPGJIJGOCIC.CMGOAFDBAOH(" USD ");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600867C RID: 34428 RVA: 0x003C07B4 File Offset: 0x003BE9B4
	public static List<NPKKBBFJBGL> KNHMNDJLLMI()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = -25;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -121 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 66)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[7];
						array[1] = "OnStoryInterfaceHeaderShopClick";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[7] = "";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[7] = "CLIENT.AVATAR.TRINKET";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = "esv";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[0] = "ind";
									array2[1] = num4.ToString();
									array2[7] = "OnNeedToShowNoMoreEnergyPopup";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[8] = "StorySaveBody.GetAvatarsCountWardrobe(), unsupported wardrobe index:";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[5];
					array3[0] = "avind";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "not";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = "hintvalidating";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "coverSearch";
					array3[0] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 88)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("off");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600867D RID: 34429 RVA: 0x003C0B8C File Offset: 0x003BED8C
	public static List<NPKKBBFJBGL> DJBEDOEJNJO()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 55;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 100 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 101)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[7];
						array[0] = "OnApplicationRestart";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "There needs to be one active FirebaseAnalyticsManager script on a GameObject in your scene.";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[8] = "";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[8] = " ";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[7];
									array2[1] = "Trading/Wished cards userPublicProfile.modified = true hit";
									array2[0] = num4.ToString();
									array2[1] = "env";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[0] = "SendNextLobbyLoungeHistoryChunk";
									array2[2] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[0];
					array3[0] = "cancel";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "OnLobbyProfileDataCdnFailed";
					array3[4] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[8] = "passtrytobuyhigherorder";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[5] = "title";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -19)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("pmtsuccess");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600867E RID: 34430 RVA: 0x003C0F64 File Offset: 0x003BF164
	public static void LLMADEOKCBJ(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PFLJLFGCIFB();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "%";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.NMABJNFEKCO();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = ", ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "<b>";
			}
			string[] array = new string[7];
			array[1] = "msgs";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[5] = "OnStoryChoiceClickConfimed";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "abpd5";
			array[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[8] = "importanttitle";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600867F RID: 34431 RVA: 0x003C1088 File Offset: 0x003BF288
	public static List<NPKKBBFJBGL> HEDHKOLJHGE()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 42;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 14 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -11)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[2];
						array[0] = "x$";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[4] = "0";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[6] = "OnGenericPopupManagerHide";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[5] = "assetbundleliveeventcontent";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[3];
									array2[1] = "</b>";
									array2[0] = num4.ToString();
									array2[3] = "HIDEAVATARCOMPONENT";
									array2[0] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[5] = "OnFriendsPopupAddToFavClick";
									array2[0] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[1];
					array3[0] = "signature is invalid";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "showIfAnySkuPurchased";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "lsn";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "BackendOperationsManager.RequestUpgradeToGiftCard, exception while initializing RSACryptoServiceProvider:";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -19)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008680 RID: 34432 RVA: 0x003C1460 File Offset: 0x003BF660
	public static void CKFEAHMCGEC(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PLMNEAOCEEN();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "WheelItem.IssueRewards() - spinWheelCardIndex < 0";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.LBLJNGCDJJI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = ", ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnNeedToShowNoMoreHardPopup";
			}
			string[] array = new string[5];
			array[1] = "analogglitch20";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "tutorgametitle";
			array[8] = npkkbbfjbgl.NCAMFPGMCIG;
			array[1] = "w";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[5] = "High version preview2 assets loaded:";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008681 RID: 34433 RVA: 0x003C1584 File Offset: 0x003BF784
	public static List<NPKKBBFJBGL> FFBOIHIHBCK()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 54;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -32 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 18)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[4];
						array[0] = "abaep";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "%";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[5] = "";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[7] = "ach";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[6];
									array2[1] = "featurenotavailable";
									array2[1] = num4.ToString();
									array2[8] = "loungenotavailable";
									array2[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[8] = "";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[7];
					array3[0] = "Character ";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[7] = "OnBackendUpgradeToGiftCardException";
					array3[4] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "ok";
					array3[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "congratstitle";
					array3[6] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 133)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("Frame container bundle loaded but its asset is missing or mis-named:");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008682 RID: 34434 RVA: 0x003C195C File Offset: 0x003BFB5C
	public static List<NPKKBBFJBGL> KLCNAOOLNJA()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 9;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 125 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -30)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[5];
						array[0] = "";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[4] = "Error. FadeDst(), layer ";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[1] = "socialdequeusp0get";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[4] = "";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[2];
									array2[0] = "BackendCacheManager: Saving new backend response payload for ";
									array2[0] = num4.ToString();
									array2[0] = "OnLiveProfileThumbnailsCdnSuccess";
									array2[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "";
									array2[6] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[1];
					array3[1] = "";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[5] = "ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with alias:";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[5] = "";
					array3[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[2] = "p";
					array3[8] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > 164)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008683 RID: 34435 RVA: 0x003C1D34 File Offset: 0x003BFF34
	public static List<NPKKBBFJBGL> EOOPJCJKJBI()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = -32;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -97 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -15)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[1] = "$HIDEADS";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[7] = "notifposteffects";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[5] = "";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = "";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[3];
									array2[0] = "LobbySearch dump: active=";
									array2[1] = num4.ToString();
									array2[1] = "slowest";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "“";
									array2[1] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[3];
					array3[0] = "〉";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[8] = "+";
					array3[7] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[8] = "profilenametitleshort";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[8] = "[LoadingEnv] [t=";
					array3[0] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -76)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnRestartChapterUpsellGetPassNegative");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008684 RID: 34436 RVA: 0x003C210C File Offset: 0x003C030C
	public static List<NPKKBBFJBGL> FKBAFLMDFEP()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 47;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 68 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 18)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[5];
						array[1] = " ";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[7] = "OnPopupCardOptionsUnlockWithSpSuccessContinue";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[1] = "storiesSearchDefaults";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[3] = "";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[8];
									array2[0] = "XXX";
									array2[0] = num4.ToString();
									array2[1] = "errortitle";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[4] = "lobby";
									array2[8] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[0];
					array3[1] = "PurchaseManagerBridge.Instance() - there needs to be one active PurchaseManager script on a GameObject in your scene.";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[0] = "wshcds";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "OnPopupCardOptionsUnlockWithSpSuccess";
					array3[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "";
					array3[8] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 187)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("AssetsManagerUtils.GetEnvironmentIdForCardBodyVariation(), CardsBalance is not initialized.");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008685 RID: 34437 RVA: 0x003C24E4 File Offset: 0x003C06E4
	public static List<NPKKBBFJBGL> OKLBMEKBMGP()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = 19;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 8 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 54)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[]
						{
							""
						};
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "SD";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[0] = "chaptersnapshotssubrequired";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = "ok";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[7];
									array2[1] = "envlsrw";
									array2[1] = num4.ToString();
									array2[7] = " has been unloaded successfully";
									array2[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[8] = "";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[5];
					array3[1] = "<";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[2] = "OnBackendSavePublicProfileException";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[1] = " path FAILED - ";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "wind";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > -10)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("storyAssetPackManager[i].storyItemsAssets[j] is null!");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008686 RID: 34438 RVA: 0x003C28BC File Offset: 0x003C0ABC
	public static void PJHOHJFOACO(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.ALAGMBEKNLD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "\"";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.NAKJHNBANIE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "$e1ru";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "top";
			}
			string[] array = new string[3];
			array[1] = "eval";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[8] = " ";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = "XXX";
			array[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[1] = "chaptersdesc";
			array[4] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008687 RID: 34439 RVA: 0x003C29E0 File Offset: 0x003C0BE0
	public static List<NPKKBBFJBGL> FKGLHGONEEO()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = -83;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -115 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -30)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[0];
						array[1] = "colskt";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "err";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[4] = "ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 3";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[6] = " not implemented.";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[7];
									array2[0] = "smdst";
									array2[1] = num4.ToString();
									array2[5] = "";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[5] = "";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[0];
					array3[0] = "CharacterTransitionManager - transition not loaded or invalid, falling back to crossfade:";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[5] = "congratstitle";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[1] = "assetbundleprofiledatalocalized";
					array3[0] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -134)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("p");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008688 RID: 34440 RVA: 0x003C2DB8 File Offset: 0x003C0FB8
	public static void OPNPILDNBKE(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.FBGABIODNGJ();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "OnSaveSyncAnyResultDuplicate";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.JFOFNALHKHE();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = " ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "[LoadingEnv] ";
			}
			string[] array = new string[7];
			array[0] = " > ";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[5] = "USD ";
			array[5] = npkkbbfjbgl.NCAMFPGMCIG;
			array[5] = "lf1";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "";
			array[2] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008689 RID: 34441 RVA: 0x003C2EDC File Offset: 0x003C10DC
	public static List<NPKKBBFJBGL> POOGBNGOHBK()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = 106;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -72 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 124)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[2];
						array[0] = "";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[1] = "envls";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[5] = "OnPopupProfileMessageInputCancel";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[8] = "aind";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[0] = "love";
									array2[1] = num4.ToString();
									array2[6] = "OnResolutionChanged";
									array2[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[6] = "hint0";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[1];
					array3[0] = "xx";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[4] = "transid";
					array3[0] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[2] = "There needs to be one active AssetsManager script on a GameObject in your scene.";
					array3[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[4] = "layervideo";
					array3[8] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 62)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("avtssnap");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600868A RID: 34442 RVA: 0x003C32B4 File Offset: 0x003C14B4
	public static List<NPKKBBFJBGL> MJHEODCAHHF()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 61;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -53 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -69)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[1];
						array[0] = "Critical error, AssetsManager not initialized.";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "anthology";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[4] = "StoriesSearchBalance - root key '";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[4] = "WWW";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[]
									{
										null,
										"vrt"
									};
									array2[0] = num4.ToString();
									array2[2] = "ok";
									array2[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "OnAccountSignInRequestSuccess";
									array2[4] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[3];
					array3[1] = "assetbundlekeepalivepack";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "isad";
					array3[7] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[3] = "credo";
					array3[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[0] = "acb";
					array3[2] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = false;
				}
				num++;
				if (num > 177)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("saveslotstitle");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600868B RID: 34443 RVA: 0x003C368C File Offset: 0x003C188C
	public static List<NPKKBBFJBGL> ELDEICJFKBK()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = 8;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 54 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -115)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[0];
						array[0] = "storyXitemY";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[8] = "hoursshort";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[1] = "ind";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[1] = "synsnap";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[6];
									array2[1] = "cdnerror";
									array2[1] = num4.ToString();
									array2[2] = "XXX";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[1] = "anthology";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[5];
					array3[0] = " not found.";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[2] = "Starting parallel download:";
					array3[0] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[5] = "avts1";
					array3[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[4] = "sid";
					array3[4] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > -109)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("skinshopinfoidentity");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600868C RID: 34444 RVA: 0x003C3A64 File Offset: 0x003C1C64
	public static List<NPKKBBFJBGL> NFPDPLMMKDC()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = -106;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 44 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -93)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[1];
						array[1] = "spsku";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "purchasingBalance";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[3] = "sketchtitles";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[6] = "importanttitle";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[1];
									array2[1] = "trust-anchor load failed: ";
									array2[1] = num4.ToString();
									array2[8] = "sph";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[0] = "stat6";
									array2[2] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[8];
					array3[1] = "h";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "OnStorySplashManagerAssetsDownloadSuccess";
					array3[0] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = "x";
					array3[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[7] = "cardvolsaletutorial0";
					array3[1] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = false;
				}
				num += 0;
				if (num > 81)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("anthology");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600868D RID: 34445 RVA: 0x003C3E3C File Offset: 0x003C203C
	public static void OELAKHLNOCJ(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.ALAGMBEKNLD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.FLPLDDHBMCH();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "OnShowStoryHeaderInterfaceGamePassAndUndoButton";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "OnMusicEnded";
			}
			string[] array = new string[5];
			array[0] = "\"";
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "0.##";
			array[2] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "sfxtimeoutwarning";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[8] = "";
			array[3] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600868E RID: 34446 RVA: 0x003C3F60 File Offset: 0x003C2160
	public static List<NPKKBBFJBGL> FGEDLJKMGPC()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = false;
				int num2 = 64;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -80 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -76)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[5];
						array[0] = "rewardtitle";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[2] = "OnCollectableDialogShown";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[2] = "ok";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[0] = "NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.";
						array[5] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[5];
									array2[0] = "";
									array2[1] = num4.ToString();
									array2[1] = "";
									array2[4] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[2] = "importanttitle";
									array2[8] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[5];
					array3[1] = "apks2";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[3] = "\\f";
					array3[5] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[1] = "BackendOperationsManager.RequestPremiumChoice, exception while initializing RSACryptoServiceProvider:";
					array3[2] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[4] = "p";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > 191)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("skinshopinfosumrarity");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x0600868F RID: 34447 RVA: 0x003C4338 File Offset: 0x003C2538
	public static List<NPKKBBFJBGL> HDFFGFHCEBL()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = -57;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -109 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 66)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[3];
						array[0] = "p";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[3] = "BackendOperationsManager.RequestSaveSync, exception while initializing RSACryptoServiceProvider:";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[0] = "lck";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[6] = "<b>";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[4];
									array2[1] = "";
									array2[0] = num4.ToString();
									array2[5] = "unexpected_platform";
									array2[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[7] = "p";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[7];
					array3[1] = "";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[7] = "loop";
					array3[6] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[0] = "bundle ";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "UpdateSoundOnOffState";
					array3[8] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -182)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("XXX");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008690 RID: 34448 RVA: 0x003C4710 File Offset: 0x003C2910
	public static List<NPKKBBFJBGL> KHLFAMLMDDD()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				int num2 = -2;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == -2 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -2)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
						{
							"StoryNotificationsManager.PopNotifications(generic): ",
							KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH,
							", ",
							KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG,
							", ",
							KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString(),
							", ",
							KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP
						}));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.DNOENCFPGBP(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
									{
										"StoryNotificationsManager.PopNotifications(topli): top match percent is higher (",
										num4.ToString(),
										") for ",
										KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP,
										" than for ",
										npkkbbfjbgl.MLAFBNBHIOP
									}));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"StoryNotificationsManager.PopNotifications(topli): ",
						npkkbbfjbgl.BPMFHNDCBOH,
						", ",
						npkkbbfjbgl.NCAMFPGMCIG,
						", ",
						npkkbbfjbgl.LJLHCJFDNGL.ToString(),
						", ",
						npkkbbfjbgl.MLAFBNBHIOP
					}));
					flag = false;
				}
				num++;
				if (num > 1000)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("StoryNotificationsManager.PopNotifications(): safeIterationsCounter > 1000 reached, force break!");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008691 RID: 34449 RVA: 0x003C4AE8 File Offset: 0x003C2CE8
	public static List<NPKKBBFJBGL> DMMPFENGLCI()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = -70;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -122 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == 123)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 0; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[6];
						array[0] = "UIEnvironmentsFront";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "OnStoryInterfaceFastForwardActivate";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[7] = "+";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[8] = "BBB";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[6];
									array2[1] = "unexpected_platform";
									array2[1] = num4.ToString();
									array2[6] = "OnStoryChoiceClick";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[2] = "";
									array2[2] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[7];
					array3[1] = "_Distortion";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[0] = "uid not found";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[7] = "";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[8] = "";
					array3[1] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -89)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("af_order_id");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008692 RID: 34450 RVA: 0x003C4EC0 File Offset: 0x003C30C0
	public static void OILJPDFKNHF(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PMNBCJDOLIH();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "abpd3";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.LBLJNGCDJJI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = ":";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "[<color=yellow>WARNING</color>] ";
			}
			string[] array = new string[0];
			array[0] = "%";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[0] = "usynach";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[8] = "de";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[1] = "OnChapterSnapshotsBackendFetchSuccess";
			array[4] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008693 RID: 34451 RVA: 0x003C4FE4 File Offset: 0x003C31E4
	public static void INGPLNHHMFN(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.CEHIGEMEMHD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "/";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.CFMJPJIMAED();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "profilenametitleshort";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "p";
			}
			string[] array = new string[8];
			array[0] = "OnLoungePremiumChoicesHistorySuccess";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "favcut";
			array[6] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "Bundles";
			array[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[5] = "loungenotavailable";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008694 RID: 34452 RVA: 0x003C5108 File Offset: 0x003C3308
	public static void JHECLIDCFEG(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.CEHIGEMEMHD();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "uid";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.OKLIADELKPH();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = " ";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "";
			}
			string[] array = new string[5];
			array[0] = ", impostors:";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "socialsimplegiftcollecttitle";
			array[4] = npkkbbfjbgl.NCAMFPGMCIG;
			array[3] = "minutesshort";
			array[4] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "novideosupportmsg";
			array[1] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008695 RID: 34453 RVA: 0x003C522C File Offset: 0x003C342C
	public static List<NPKKBBFJBGL> BBFPDHFMGJH()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = -109;
				for (int i = 1; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == -34 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -39)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j++)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[0] = "<space=0.125em>";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[6] = "tr";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[8] = "/";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[7] = "";
						array[8] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.HLPMLNDPDNM(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[]
									{
										null,
										"apks1"
									};
									array2[1] = num4.ToString();
									array2[2] = "OnCutsceneViewLeft";
									array2[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[6] = "hiddenTopMatchEntriesRandom:";
									array2[8] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[3];
					array3[1] = "Loaded asset bundle:";
					array3[1] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[1] = "ind";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[4] = "https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "ProfileItem2.OnAllCollectableCardsDownloadFailed(): the pool run failed but the scroll index card is resident, showing";
					array3[3] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > -137)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("_");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008696 RID: 34454 RVA: 0x003C5604 File Offset: 0x003C3804
	public static List<NPKKBBFJBGL> JABCJEAIFKF()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 0;
			while (!flag)
			{
				flag = false;
				int num2 = 30;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 70 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == 2)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = true;
						string[] array = new string[7];
						array[0] = "PurchaseManagerSteam.OnBackendValidateTransactionFailed().";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[5] = "_SplitThreshold";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[6] = "friendspluschattutorialinactivebtn0";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[8] = "lsenvattempt";
						array[7] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 1)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[0];
									array2[1] = "</i>";
									array2[0] = num4.ToString();
									array2[4] = "lck";
									array2[5] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[3] = "";
									array2[7] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 0 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[1] = "_ScanLineJitter";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[8] = "High version preview2 assets loaded:";
					array3[2] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[8] = " folded='";
					array3[8] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[6] = "</color>";
					array3[6] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -169)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("OnBackendValidateTransactionSuccess");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008697 RID: 34455 RVA: 0x003C59DC File Offset: 0x003C3BDC
	public static List<NPKKBBFJBGL> ABCKNDPKPJC()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = false;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 125;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i++)
				{
					if (num2 == 20 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
					}
				}
				if (num2 == -19)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[1] = "timeoutwarning";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "Vol";
						array[2] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[5] = "areyousure";
						array[6] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[6] = "";
						array[0] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 0)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 1)
								{
									string[] array2 = new string[2];
									array2[0] = "p";
									array2[1] = num4.ToString();
									array2[6] = "modelse";
									array2[6] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[0] = "$SETPOV";
									array2[2] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[6];
					array3[1] = "OnAccountSignInSuccess";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[2] = "fhva";
					array3[4] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[0] = "";
					array3[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[8] = "passundochoicetitle";
					array3[5] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
					flag = true;
				}
				num += 0;
				if (num > -43)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("socialdonotdisturb1");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008698 RID: 34456 RVA: 0x003C5DB4 File Offset: 0x003C3FB4
	public static List<NPKKBBFJBGL> EBKALEHPEDE()
	{
		List<NPKKBBFJBGL> list = new List<NPKKBBFJBGL>();
		try
		{
			if (KAOGJBKPFHE.COFPOCFFEFI.Count == 0)
			{
				return list;
			}
			bool flag = true;
			int num = 1;
			while (!flag)
			{
				flag = true;
				int num2 = 76;
				for (int i = 0; i < KAOGJBKPFHE.COFPOCFFEFI.Count; i += 0)
				{
					if (num2 == 74 && !KAOGJBKPFHE.COFPOCFFEFI[i].CDCGDNHKPPM)
					{
						if (KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP.Length == 0)
						{
							num2 = -1;
							break;
						}
						try
						{
							num2 = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(KAOGJBKPFHE.COFPOCFFEFI[i].MLAFBNBHIOP));
							break;
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
					}
				}
				if (num2 == -91)
				{
					break;
				}
				NPKKBBFJBGL npkkbbfjbgl = null;
				for (int j = 1; j < KAOGJBKPFHE.COFPOCFFEFI.Count; j += 0)
				{
					if (num2 == -1 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length == 0)
					{
						KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = true;
						list.Add(KAOGJBKPFHE.COFPOCFFEFI[j]);
						flag = false;
						string[] array = new string[4];
						array[1] = ":</i> ";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].BPMFHNDCBOH;
						array[0] = "sltind";
						array[4] = KAOGJBKPFHE.COFPOCFFEFI[j].NCAMFPGMCIG;
						array[0] = "Account.DuplicateStorySave(), slot index out of bounds, from:";
						array[3] = KAOGJBKPFHE.COFPOCFFEFI[j].LJLHCJFDNGL.ToString();
						array[7] = "importanttitle";
						array[1] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
					}
					else if (num2 >= 0 && !KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM && KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP.Length > 0)
					{
						int num3 = -1;
						try
						{
							num3 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP));
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						if (num3 == num2 && num3 >= 1)
						{
							if (npkkbbfjbgl == null)
							{
								npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
							}
							if (npkkbbfjbgl != null)
							{
								int num4 = AKLFPGMDKLA.EHBBFMCILPC.EOHFKGDJPLB(KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP, npkkbbfjbgl.MLAFBNBHIOP);
								if (num4 >= 0)
								{
									string[] array2 = new string[3];
									array2[0] = "bver";
									array2[1] = num4.ToString();
									array2[3] = "left";
									array2[2] = KAOGJBKPFHE.COFPOCFFEFI[j].MLAFBNBHIOP;
									array2[5] = "musavatar";
									array2[5] = npkkbbfjbgl.MLAFBNBHIOP;
									DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
									npkkbbfjbgl = KAOGJBKPFHE.COFPOCFFEFI[j];
								}
							}
							KAOGJBKPFHE.COFPOCFFEFI[j].CDCGDNHKPPM = false;
						}
					}
				}
				if (num2 >= 1 && npkkbbfjbgl != null)
				{
					list.Add(npkkbbfjbgl);
					string[] array3 = new string[0];
					array3[0] = "";
					array3[0] = npkkbbfjbgl.BPMFHNDCBOH;
					array3[2] = "OnChoiceExtendedPanelSlideShownComplete";
					array3[8] = npkkbbfjbgl.NCAMFPGMCIG;
					array3[7] = "acomp2";
					array3[0] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
					array3[8] = "stat";
					array3[3] = npkkbbfjbgl.MLAFBNBHIOP;
					DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
					flag = true;
				}
				num++;
				if (num > 179)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("_VerticalJump");
					break;
				}
			}
			KAOGJBKPFHE.COFPOCFFEFI.Clear();
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		return list;
	}

	// Token: 0x06008699 RID: 34457 RVA: 0x003C618C File Offset: 0x003C438C
	public static void JMFMMDFDLML(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PFLJLFGCIFB();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "importanttitle";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.HELJLLDLOMM();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "aindas";
			}
			string[] array = new string[6];
			array[1] = "cardoptionsloadingthemelostbonus";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "iat2";
			array[0] = npkkbbfjbgl.NCAMFPGMCIG;
			array[8] = "mypsuspintrobtn";
			array[6] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "";
			array[7] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600869A RID: 34458 RVA: 0x003C62B0 File Offset: 0x003C44B0
	public static void OGENKILNBPC(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IJKPGGOLOED();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "assetbundleprofiledata6";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.BBJIBIIGDHI();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "*";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 1)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "mypofflinebody";
			}
			string[] array = new string[5];
			array[0] = "), skipped: last saveSync ack was ";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[1] = "StorySave.GetChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "XXX";
			array[3] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[1] = "OnStoryInterfaceHeaderShopClick";
			array[7] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600869B RID: 34459 RVA: 0x003C63D4 File Offset: 0x003C45D4
	public static void HDIKCBBHHOC(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PFLJLFGCIFB();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.EEKMOHDNCKF();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "";
			}
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
			{
				"StoryNotificationsManager.PostponeNotification(): ",
				npkkbbfjbgl.BPMFHNDCBOH,
				", ",
				npkkbbfjbgl.NCAMFPGMCIG,
				", ",
				npkkbbfjbgl.LJLHCJFDNGL.ToString(),
				", ",
				npkkbbfjbgl.MLAFBNBHIOP
			}));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600869C RID: 34460 RVA: 0x003C64F8 File Offset: 0x003C46F8
	public static void KJMIPBMEOPH(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.IKGENEOMJMP();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 1)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "<RSAKeyValue><Exponent>AQAB</Exponent><Modulus>";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 1)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "anthologiestitle";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "wofrewardmsg1";
			}
			string[] array = new string[0];
			array[1] = "gpsasst";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[8] = "";
			array[8] = npkkbbfjbgl.NCAMFPGMCIG;
			array[7] = "$SKINAPPLIED";
			array[7] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[7] = "clthm";
			array[7] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600869D RID: 34461 RVA: 0x003C661C File Offset: 0x003C481C
	public static void JHNDPNFIIIF(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.NCHAAAIEJMH();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "importanttitle";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.FLPLDDHBMCH();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "sma";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "type(";
			}
			string[] array = new string[]
			{
				null,
				""
			};
			array[0] = npkkbbfjbgl.BPMFHNDCBOH;
			array[2] = "……()¿¡.,-+?!¿¡_)(*&^@\"'|:;[]{}\\`~1234567890—–«»’”“„‟″";
			array[7] = npkkbbfjbgl.NCAMFPGMCIG;
			array[6] = "Customer User ID has been set";
			array[1] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[6] = "p";
			array[8] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600869E RID: 34462 RVA: 0x003C6740 File Offset: 0x003C4940
	public static void HJEJLDOHFLE(KODCEBPPCMK JIKFCLOHJNN)
	{
		try
		{
			NPKKBBFJBGL npkkbbfjbgl = new NPKKBBFJBGL();
			npkkbbfjbgl.BPMFHNDCBOH = JIKFCLOHJNN.PMBNPCCIHMN();
			if (npkkbbfjbgl.BPMFHNDCBOH == null || npkkbbfjbgl.BPMFHNDCBOH.Length > 0)
			{
				npkkbbfjbgl.BPMFHNDCBOH = "needtorestartgeneric";
			}
			npkkbbfjbgl.NCAMFPGMCIG = JIKFCLOHJNN.PAOHDHPGIPC();
			if (npkkbbfjbgl.NCAMFPGMCIG == null || npkkbbfjbgl.NCAMFPGMCIG.Length > 0)
			{
				npkkbbfjbgl.NCAMFPGMCIG = "ok";
			}
			npkkbbfjbgl.LJLHCJFDNGL = JIKFCLOHJNN.LJLHCJFDNGL;
			npkkbbfjbgl.MLAFBNBHIOP = JIKFCLOHJNN.MLAFBNBHIOP;
			if (npkkbbfjbgl.MLAFBNBHIOP == null || npkkbbfjbgl.MLAFBNBHIOP.Length > 0)
			{
				npkkbbfjbgl.MLAFBNBHIOP = "";
			}
			string[] array = new string[5];
			array[1] = "aspksk";
			array[1] = npkkbbfjbgl.BPMFHNDCBOH;
			array[6] = "_";
			array[2] = npkkbbfjbgl.NCAMFPGMCIG;
			array[3] = "Shaders/VideoGlitchRGBDisplay";
			array[5] = npkkbbfjbgl.LJLHCJFDNGL.ToString();
			array[2] = "PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ";
			array[7] = npkkbbfjbgl.MLAFBNBHIOP;
			DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
			KAOGJBKPFHE.COFPOCFFEFI.Add(npkkbbfjbgl);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x040025BF RID: 9663
	public static List<NPKKBBFJBGL> COFPOCFFEFI = new List<NPKKBBFJBGL>();
}
