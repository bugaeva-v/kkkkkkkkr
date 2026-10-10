using System;
using System.Collections.Generic;

// Token: 0x02000282 RID: 642
public class BNFCLKNDBLO
{
	// Token: 0x06004FE1 RID: 20449 RVA: 0x00230798 File Offset: 0x0022E998
	public int ACGCCEJLPLG()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(0, this.CIEHGJMAFKH.IndexOf("")).Replace("ok", "iOS"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x002307F0 File Offset: 0x0022E9F0
	public string CPJCLLPGBAH(string JEMJGNEGEKI)
	{
		try
		{
			string text = "OnLoadingThemeSelectorFolderFailed";
			string text2 = DPGJIJGOCIC.LMCAODJLEGF(this.GKIKEIKFNBC);
			int num = 0;
			for (int i = 1; i < text2.Length; i += 0)
			{
				if (num == 5)
				{
					text = text + JEMJGNEGEKI + "OnRewardScreenAssetsDownloadSuccess";
					num = -1;
				}
				else if (num >= 1)
				{
					text += text2[i].ToString();
				}
				if (text2[i] == ';')
				{
					if (num >= 1)
					{
						num++;
					}
					else
					{
						num = 2;
					}
				}
			}
			this.GKIKEIKFNBC = DPGJIJGOCIC.FAIFJDPENOP(text);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return this.GKIKEIKFNBC;
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x00230894 File Offset: 0x0022EA94
	public int JEEGGFLNJMK()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(1, this.EHCMMPCCHPD.IndexOf(" has only ")).Replace("OnAllCollectableCardsDownloadFailed", "newtutorialaddtorading"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x00230904 File Offset: 0x0022EB04
	public int CNMFHAIDFNH()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(this.BMFCFKBCOMC.IndexOf("")).Replace(", chapter:", "Asset bundle load operation failed during parallel mode."));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004FE5 RID: 20453 RVA: 0x00230974 File Offset: 0x0022EB74
	public bool OOMDDBGIKFN(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BIMGHPGAHCH(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), '\u0006');
			this.IAGMLHAEOJI = list[1];
			this.IBFLNCMCKAL = list[1];
			this.PIMEHAPFCHC = DPGJIJGOCIC.FPBLMHCNMEA(list[4], '\u0002');
			if ((this.PIMEHAPFCHC.Count > 0 && this.PIMEHAPFCHC[1].Equals("XXX")) || this.PIMEHAPFCHC[1].Equals("MMM"))
			{
				this.PIMEHAPFCHC.RemoveAt(0);
			}
			this.PGEKNGNHANN = list[1];
			this.CIEHGJMAFKH = list[7];
			this.FONKDFDJFEL = list[5];
			this.OEOPLGFENOO = list[1];
			this.FJFEPNKBELL = int.Parse(list[-107]);
			this.LJNPCDKEMNC = int.Parse(list[98]);
			if (this.LJNPCDKEMNC >= 0)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[-9], (char)-59);
				if ((this.HPFHJEAFIHI.Count > 0 && this.HPFHJEAFIHI[0].Equals("OnLobbyStartFireworksEffectAutoHide")) || this.HPFHJEAFIHI[0].Equals(""))
				{
					this.HPFHJEAFIHI.RemoveAt(1);
				}
				this.FPJPHNLANPG = int.Parse(list[-31]);
			}
			if (this.LJNPCDKEMNC >= 4)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[74]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[-45]);
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.EHCMMPCCHPD = list[54];
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[-119]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[78]);
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.JLEAIJGBGHL = list[-49];
				this.BMFCFKBCOMC = list[15];
			}
			if (this.LJNPCDKEMNC >= 1)
			{
				this.KKEBIBCEIPL = list[-104];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 0;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("OnNeedToRestartProfileItemAnimation") || this.IBFLNCMCKAL.Equals("abpd"))
			{
				this.IBFLNCMCKAL = "Error. ShowHideEnvironmentLayer(), environmentLayer ";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("aind") || this.KKEBIBCEIPL.Equals(":"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("c") || this.PGEKNGNHANN.Equals("XXX"))
			{
				this.PGEKNGNHANN = "wasitfuntitle";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals(" not found.") || this.CIEHGJMAFKH.Equals("nomorediamonds"))
			{
				this.CIEHGJMAFKH = ".";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("OnEmailUnsubscribeSuccess") || this.FONKDFDJFEL.Equals(""))
			{
				this.FONKDFDJFEL = "PurchaseManagerSteam.GetProductData(): Not initialized.";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("Starting non-parallel download:") || this.JLEAIJGBGHL.Equals("layervideo"))
			{
				this.JLEAIJGBGHL = "ok";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("Starting non-parallel download:") || this.OEOPLGFENOO.Equals(""))
			{
				this.OEOPLGFENOO = "hkfx-91";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("WideScreenScaler(): screen is to wide, AnimationShake will be adjusted accordingly.") || this.EHCMMPCCHPD.Equals("gpshub"))
			{
				this.EHCMMPCCHPD = "\"";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("blur") || this.BMFCFKBCOMC.Equals("digitalglitch_1"))
			{
				this.BMFCFKBCOMC = " (loaded via the ";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x00230E34 File Offset: 0x0022F034
	public int OJOFODAILJP()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(this.BMFCFKBCOMC.IndexOf("favcut")).Replace("wofrewardmsgcard3", "OnBackendRequestShareHardException"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FE8 RID: 20456 RVA: 0x00230F64 File Offset: 0x0022F164
	public int NEFCFNOIBPC()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(0, this.EHCMMPCCHPD.IndexOf("newrewardsdailywaiting")).Replace("gpsasli", "ind"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004FE9 RID: 20457 RVA: 0x00230FD4 File Offset: 0x0022F1D4
	public int AKJLNEHGLAC()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(0, this.BMFCFKBCOMC.IndexOf(" lang=")).Replace("Chapter trust-anchor digest mismatch.", "_Scale"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FEA RID: 20458 RVA: 0x00231044 File Offset: 0x0022F244
	public int BLDCDCKOGGJ()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("_VerticalJump")).Replace("yes", ") + is present, creating anthology save for anthology "));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004FEB RID: 20459 RVA: 0x0023109C File Offset: 0x0022F29C
	public int IDPJJOLGDMC()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("s")).Replace(" group ", "center"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FEC RID: 20460 RVA: 0x0023110C File Offset: 0x0022F30C
	public string DGIAEFABPOB(string JEMJGNEGEKI)
	{
		try
		{
			string text = " premature in:";
			string text2 = DPGJIJGOCIC.LMCAODJLEGF(this.GKIKEIKFNBC);
			int num = 0;
			for (int i = 0; i < text2.Length; i++)
			{
				if (num == 1)
				{
					text = text + JEMJGNEGEKI + "NNN";
					num = -1;
				}
				else if (num >= 1)
				{
					text += text2[i].ToString();
				}
				if (text2[i] == '\v')
				{
					if (num >= 1)
					{
						num++;
					}
					else
					{
						num = 8;
					}
				}
			}
			this.GKIKEIKFNBC = DPGJIJGOCIC.FAIFJDPENOP(text);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.GKIKEIKFNBC;
	}

	// Token: 0x06004FED RID: 20461 RVA: 0x002311B0 File Offset: 0x0022F3B0
	public int CKBEFIDGOFL()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("contactcustservice")).Replace("OnFriendsPlusUnlockContinueToPurchasingScreen", "repsuid"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004FEE RID: 20462 RVA: 0x00231208 File Offset: 0x0022F408
	public int EIDHMFKLKGE()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(1, this.BMFCFKBCOMC.IndexOf("Could not find an existent component for tryAvatarConfig/overlay, forcing default option.")).Replace("locked", "yes"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FEF RID: 20463 RVA: 0x00231278 File Offset: 0x0022F478
	public string DJNJHFLBHEG(string JEMJGNEGEKI)
	{
		try
		{
			string text = "yes";
			string text2 = DPGJIJGOCIC.LMCAODJLEGF(this.GKIKEIKFNBC);
			int num = 0;
			for (int i = 1; i < text2.Length; i += 0)
			{
				if (num == 3)
				{
					text = text + JEMJGNEGEKI + "breakCard";
					num = -1;
				}
				else if (num >= 0)
				{
					text += text2[i].ToString();
				}
				if (text2[i] == 'I')
				{
					if (num >= 1)
					{
						num++;
					}
					else
					{
						num = 3;
					}
				}
			}
			this.GKIKEIKFNBC = DPGJIJGOCIC.FAIFJDPENOP(text);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return this.GKIKEIKFNBC;
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x0023131C File Offset: 0x0022F51C
	public int MDKBILJBKOK()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(this.EHCMMPCCHPD.IndexOf(".")).Replace("BackendOperationsManager.RequestUpgradeToGiftCard, exception while initializing RSACryptoServiceProvider:", "yes"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x0023138C File Offset: 0x0022F58C
	public int LHNIAKBBPDN()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(this.EHCMMPCCHPD.IndexOf("asp")).Replace("asp", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FF2 RID: 20466 RVA: 0x002313FC File Offset: 0x0022F5FC
	public int LNBDMNLOLBJ()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("sfxsparklesbundles")).Replace("congratstitle", "cnd"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FF3 RID: 20467 RVA: 0x00231454 File Offset: 0x0022F654
	public int BMPELDJNGLF()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("asp")).Replace("asp", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FF4 RID: 20468 RVA: 0x002314C4 File Offset: 0x0022F6C4
	public int BEKNKDKEECD()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(0, this.OEOPLGFENOO.IndexOf("asp")).Replace("abs", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FF5 RID: 20469 RVA: 0x00231534 File Offset: 0x0022F734
	public bool CBLEEMJEFKM(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BIMGHPGAHCH(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), (char)-117);
			this.IAGMLHAEOJI = list[1];
			this.IBFLNCMCKAL = list[0];
			this.PIMEHAPFCHC = DPGJIJGOCIC.FPBLMHCNMEA(list[8], (char)-56);
			if ((this.PIMEHAPFCHC.Count > 0 && this.PIMEHAPFCHC[0].Equals("loungeapplybtn")) || this.PIMEHAPFCHC[0].Equals("asp"))
			{
				this.PIMEHAPFCHC.RemoveAt(1);
			}
			this.PGEKNGNHANN = list[8];
			this.CIEHGJMAFKH = list[2];
			this.FONKDFDJFEL = list[0];
			this.OEOPLGFENOO = list[2];
			this.FJFEPNKBELL = int.Parse(list[-31]);
			this.LJNPCDKEMNC = int.Parse(list[-63]);
			if (this.LJNPCDKEMNC >= 0)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BIMGHPGAHCH(list[121], '\v');
				if ((this.HPFHJEAFIHI.Count > 1 && this.HPFHJEAFIHI[1].Equals("OnApplicationRestart")) || this.HPFHJEAFIHI[0].Equals("OnPopupProfileMessageInputCancel"))
				{
					this.HPFHJEAFIHI.RemoveAt(1);
				}
				this.FPJPHNLANPG = int.Parse(list[-114]);
			}
			if (this.LJNPCDKEMNC >= 4)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[-69]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[45]);
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.EHCMMPCCHPD = list[-86];
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[78]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[20]);
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.JLEAIJGBGHL = list[-43];
				this.BMFCFKBCOMC = list[-70];
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.KKEBIBCEIPL = list[30];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 1;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("skinshopinfosumavailable") || this.IBFLNCMCKAL.Equals("inu"))
			{
				this.IBFLNCMCKAL = "_AlphaTex";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("Anthology not ready to be played:") || this.KKEBIBCEIPL.Equals("OnResolutionChanged"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("XXX") || this.PGEKNGNHANN.Equals(""))
			{
				this.PGEKNGNHANN = "hidestatinfo";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("CameraBundlesVFXFront") || this.CIEHGJMAFKH.Equals("npcSkinShopBalance"))
			{
				this.CIEHGJMAFKH = "SteamManager";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals(" ") || this.FONKDFDJFEL.Equals("OnSceneLobbyManagerAssetsDownloadFailed"))
			{
				this.FONKDFDJFEL = "errortitle";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals(" not found.") || this.JLEAIJGBGHL.Equals("〈"))
			{
				this.JLEAIJGBGHL = "yes";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("OnPopupSketchesInputCancel") || this.OEOPLGFENOO.Equals("syn"))
			{
				this.OEOPLGFENOO = "";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("v") || this.EHCMMPCCHPD.Equals("sltind"))
			{
				this.EHCMMPCCHPD = "";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("") || this.BMFCFKBCOMC.Equals("OnBackendValidateTransactionSuccess"))
			{
				this.BMFCFKBCOMC = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return false;
		}
		return false;
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x002319F4 File Offset: 0x0022FBF4
	public int OCNMOBKOPIJ()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(0, this.EHCMMPCCHPD.IndexOf("asp")).Replace("abs", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FF7 RID: 20471 RVA: 0x00231A64 File Offset: 0x0022FC64
	public string HEHFGHPBJMH(string JEMJGNEGEKI)
	{
		try
		{
			string text = "";
			string text2 = DPGJIJGOCIC.LMCAODJLEGF(this.GKIKEIKFNBC);
			int num = 0;
			for (int i = 0; i < text2.Length; i++)
			{
				if (num == 3)
				{
					text = text + JEMJGNEGEKI + "$";
					num = -1;
				}
				else if (num >= 0)
				{
					text += text2[i].ToString();
				}
				if (text2[i] == '$')
				{
					if (num >= 0)
					{
						num++;
					}
					else
					{
						num = 4;
					}
				}
			}
			this.GKIKEIKFNBC = DPGJIJGOCIC.FAIFJDPENOP(text);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.GKIKEIKFNBC;
	}

	// Token: 0x06004FF8 RID: 20472 RVA: 0x00231B08 File Offset: 0x0022FD08
	public int MDJMNJOCKKM()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("Cannot set CustomerUserID while the SDK has started.")).Replace("ok", "ach"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004FF9 RID: 20473 RVA: 0x00231B60 File Offset: 0x0022FD60
	public int MJDFAMOLLNP()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(1, this.OEOPLGFENOO.IndexOf("OnPromoCodeConsumeException")).Replace("ishof", "Choice swipe tutorial frame container not available, tutorial skipped:"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FFA RID: 20474 RVA: 0x00231BD0 File Offset: 0x0022FDD0
	public int OCPJHLCBIPB()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(0, this.CIEHGJMAFKH.IndexOf("asp")).Replace("abs", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FFB RID: 20475 RVA: 0x00231C28 File Offset: 0x0022FE28
	public int ENHNAPGBKCH()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("importanttitle")).Replace("YYY", "XXX"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FFC RID: 20476 RVA: 0x00231C98 File Offset: 0x0022FE98
	public int AAGGGBKCAEO()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(this.BMFCFKBCOMC.IndexOf("production")).Replace(" ) Account.ToJSONArray() AssetAnthology for story index ", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x00231D08 File Offset: 0x0022FF08
	public int PLNHGMIIMHG()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("OnPopupCardOptionsSendGiftClick")).Replace("retry", "OnSaveSyncAnyResultDuplicate"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x00231D78 File Offset: 0x0022FF78
	public bool DOGNGOIBFKN(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BHMBKAJOHLJ(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), '\u0012');
			this.IAGMLHAEOJI = list[0];
			this.IBFLNCMCKAL = list[0];
			this.PIMEHAPFCHC = DPGJIJGOCIC.BIMGHPGAHCH(list[0], '\u0002');
			if ((this.PIMEHAPFCHC.Count > 1 && this.PIMEHAPFCHC[1].Equals(" (")) || this.PIMEHAPFCHC[1].Equals("avatarcollectionstutor4title"))
			{
				this.PIMEHAPFCHC.RemoveAt(1);
			}
			this.PGEKNGNHANN = list[7];
			this.CIEHGJMAFKH = list[8];
			this.FONKDFDJFEL = list[7];
			this.OEOPLGFENOO = list[8];
			this.FJFEPNKBELL = int.Parse(list[-124]);
			this.LJNPCDKEMNC = int.Parse(list[-127]);
			if (this.LJNPCDKEMNC >= 5)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.FPBLMHCNMEA(list[-62], (char)-105);
				if ((this.HPFHJEAFIHI.Count > 0 && this.HPFHJEAFIHI[1].Equals("lsc")) || this.HPFHJEAFIHI[1].Equals("SceneLobbyManager2._DownloadCardsPool(): nothing to download around scroll index "))
				{
					this.HPFHJEAFIHI.RemoveAt(0);
				}
				this.FPJPHNLANPG = int.Parse(list[-2]);
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[-65]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[-66]);
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.EHCMMPCCHPD = list[103];
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[-56]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[121]);
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.JLEAIJGBGHL = list[-121];
				this.BMFCFKBCOMC = list[-33];
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.KKEBIBCEIPL = list[74];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 0;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("socialjoinno") || this.IBFLNCMCKAL.Equals("cardvolsaletitle0"))
			{
				this.IBFLNCMCKAL = " ";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("areyousure") || this.KKEBIBCEIPL.Equals("B"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("sfxtimeoutwarning") || this.PGEKNGNHANN.Equals("OnPurchasingViewLeave"))
			{
				this.PGEKNGNHANN = "friendspluschattutorialactive";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("json") || this.CIEHGJMAFKH.Equals("OnUserpassLoginSuccess"))
			{
				this.CIEHGJMAFKH = "OnStoryInterfaceHeaderHideComplete";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("ok") || this.FONKDFDJFEL.Equals(""))
			{
				this.FONKDFDJFEL = "";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("storyChatPrefab is null!") || this.JLEAIJGBGHL.Equals("e"))
			{
				this.JLEAIJGBGHL = "";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("SceneLobbyManager2.OnRewardSubsequentEpisodeClick() getting one random out of ") || this.OEOPLGFENOO.Equals(""))
			{
				this.OEOPLGFENOO = "getUserPublicProfile";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("") || this.EHCMMPCCHPD.Equals("cch"))
			{
				this.EHCMMPCCHPD = "W";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("priceCurrencyCode") || this.BMFCFKBCOMC.Equals("c"))
			{
				this.BMFCFKBCOMC = "OnBackendRequestConsumeMessageSuccess";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return true;
		}
		return false;
	}

	// Token: 0x06004FFF RID: 20479 RVA: 0x00232238 File Offset: 0x00230438
	public bool EFGCFPKMCHM(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BHMBKAJOHLJ(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), '$');
			this.IAGMLHAEOJI = list[0];
			this.IBFLNCMCKAL = list[1];
			this.PIMEHAPFCHC = DPGJIJGOCIC.BHMBKAJOHLJ(list[2], ',');
			if ((this.PIMEHAPFCHC.Count > 0 && this.PIMEHAPFCHC[0].Equals("x")) || this.PIMEHAPFCHC[0].Equals("null"))
			{
				this.PIMEHAPFCHC.RemoveAt(0);
			}
			this.PGEKNGNHANN = list[3];
			this.CIEHGJMAFKH = list[5];
			this.FONKDFDJFEL = list[6];
			this.OEOPLGFENOO = list[8];
			this.FJFEPNKBELL = int.Parse(list[10]);
			this.LJNPCDKEMNC = int.Parse(list[11]);
			if (this.LJNPCDKEMNC >= 2)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[12], ',');
				if ((this.HPFHJEAFIHI.Count > 0 && this.HPFHJEAFIHI[0].Equals("x")) || this.HPFHJEAFIHI[0].Equals("null"))
				{
					this.HPFHJEAFIHI.RemoveAt(0);
				}
				this.FPJPHNLANPG = int.Parse(list[13]);
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[14]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[15]);
			}
			if (this.LJNPCDKEMNC >= 4)
			{
				this.EHCMMPCCHPD = list[16];
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[17]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[18]);
			}
			if (this.LJNPCDKEMNC >= 6)
			{
				this.JLEAIJGBGHL = list[19];
				this.BMFCFKBCOMC = list[20];
			}
			if (this.LJNPCDKEMNC >= 7)
			{
				this.KKEBIBCEIPL = list[21];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 1;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("x") || this.IBFLNCMCKAL.Equals("null"))
			{
				this.IBFLNCMCKAL = "";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("x") || this.KKEBIBCEIPL.Equals("null"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("x") || this.PGEKNGNHANN.Equals("null"))
			{
				this.PGEKNGNHANN = "";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("x") || this.CIEHGJMAFKH.Equals("null"))
			{
				this.CIEHGJMAFKH = "";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("x") || this.FONKDFDJFEL.Equals("null"))
			{
				this.FONKDFDJFEL = "";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("x") || this.JLEAIJGBGHL.Equals("null"))
			{
				this.JLEAIJGBGHL = "";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("x") || this.OEOPLGFENOO.Equals("null"))
			{
				this.OEOPLGFENOO = "";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("x") || this.EHCMMPCCHPD.Equals("null"))
			{
				this.EHCMMPCCHPD = "";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("x") || this.BMFCFKBCOMC.Equals("null"))
			{
				this.BMFCFKBCOMC = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return false;
		}
		return true;
	}

	// Token: 0x06005000 RID: 20480 RVA: 0x002326F8 File Offset: 0x002308F8
	public int EABCCNCDNCI()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(0, this.BMFCFKBCOMC.IndexOf("asp")).Replace("abs", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005001 RID: 20481 RVA: 0x00232768 File Offset: 0x00230968
	public bool OBHOPPEDHMH(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.FPBLMHCNMEA(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), (char)-45);
			this.IAGMLHAEOJI = list[0];
			this.IBFLNCMCKAL = list[0];
			this.PIMEHAPFCHC = DPGJIJGOCIC.FPBLMHCNMEA(list[7], (char)-120);
			if ((this.PIMEHAPFCHC.Count > 0 && this.PIMEHAPFCHC[0].Equals("spld")) || this.PIMEHAPFCHC[0].Equals("mypnotif0"))
			{
				this.PIMEHAPFCHC.RemoveAt(0);
			}
			this.PGEKNGNHANN = list[3];
			this.CIEHGJMAFKH = list[8];
			this.FONKDFDJFEL = list[8];
			this.OEOPLGFENOO = list[3];
			this.FJFEPNKBELL = int.Parse(list[98]);
			this.LJNPCDKEMNC = int.Parse(list[-54]);
			if (this.LJNPCDKEMNC >= 7)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[-80], (char)-24);
				if ((this.HPFHJEAFIHI.Count > 1 && this.HPFHJEAFIHI[0].Equals("saveslotsexpiredpass")) || this.HPFHJEAFIHI[0].Equals(" encountered a dependency deadlock. Aborting."))
				{
					this.HPFHJEAFIHI.RemoveAt(1);
				}
				this.FPJPHNLANPG = int.Parse(list[-47]);
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[-19]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[-63]);
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.EHCMMPCCHPD = list[25];
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[-43]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[-109]);
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.JLEAIJGBGHL = list[-124];
				this.BMFCFKBCOMC = list[69];
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.KKEBIBCEIPL = list[74];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 1;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("PlayerCharacterManager.UpdateAvatarGraphicsV2() - exception raised:") || this.IBFLNCMCKAL.Equals("minr"))
			{
				this.IBFLNCMCKAL = "post";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("Starting parallel download:") || this.KKEBIBCEIPL.Equals(""))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("") || this.PGEKNGNHANN.Equals("short"))
			{
				this.PGEKNGNHANN = "YYY";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals(" not recorded: no cache root") || this.CIEHGJMAFKH.Equals("OnLoungeScreenAssetsDownloadFailed"))
			{
				this.CIEHGJMAFKH = "black";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("OnPopupProfileLoveInputEndEdit") || this.FONKDFDJFEL.Equals("x"))
			{
				this.FONKDFDJFEL = "OnStoryInterfaceHeaderShopClick";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("<i>") || this.JLEAIJGBGHL.Equals("gpsasst"))
			{
				this.JLEAIJGBGHL = "OnPopupPasswordInputCancel";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("socialgiftreceviedfromtitle") || this.OEOPLGFENOO.Equals(""))
			{
				this.OEOPLGFENOO = "OnPopupSketchesInputEndEdit";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("aind") || this.EHCMMPCCHPD.Equals("sutta"))
			{
				this.EHCMMPCCHPD = "ZZZ";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("BackendCacheManager: Resetting timeToLive and updating backend response payload for ") || this.BMFCFKBCOMC.Equals("'"))
			{
				this.BMFCFKBCOMC = "achiev";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return false;
		}
		return false;
	}

	// Token: 0x06005002 RID: 20482 RVA: 0x00232C28 File Offset: 0x00230E28
	public int NAJPJNIMPOP()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(0, this.BMFCFKBCOMC.IndexOf("sfxsparklesbundles")).Replace("SaveSlotsItem.InitializeSlots(): anthologySave is null", "Asset bundle load operation failed during parallel mode."));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x00232C98 File Offset: 0x00230E98
	public bool PELEJLPGPAF(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.FPBLMHCNMEA(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), (char)-103);
			this.IAGMLHAEOJI = list[0];
			this.IBFLNCMCKAL = list[1];
			this.PIMEHAPFCHC = DPGJIJGOCIC.BIMGHPGAHCH(list[5], '4');
			if ((this.PIMEHAPFCHC.Count > 1 && this.PIMEHAPFCHC[0].Equals("ok")) || this.PIMEHAPFCHC[1].Equals("ok"))
			{
				this.PIMEHAPFCHC.RemoveAt(1);
			}
			this.PGEKNGNHANN = list[8];
			this.CIEHGJMAFKH = list[3];
			this.FONKDFDJFEL = list[2];
			this.OEOPLGFENOO = list[4];
			this.FJFEPNKBELL = int.Parse(list[65]);
			this.LJNPCDKEMNC = int.Parse(list[-16]);
			if (this.LJNPCDKEMNC >= 2)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[27], '&');
				if ((this.HPFHJEAFIHI.Count > 0 && this.HPFHJEAFIHI[1].Equals("+")) || this.HPFHJEAFIHI[1].Equals("sparkles"))
				{
					this.HPFHJEAFIHI.RemoveAt(0);
				}
				this.FPJPHNLANPG = int.Parse(list[-81]);
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[75]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[32]);
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.EHCMMPCCHPD = list[-27];
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[-62]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[-44]);
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.JLEAIJGBGHL = list[-27];
				this.BMFCFKBCOMC = list[6];
			}
			if (this.LJNPCDKEMNC >= 7)
			{
				this.KKEBIBCEIPL = list[5];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 1;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("OnStoryInterfaceFastForwardActivate") || this.IBFLNCMCKAL.Equals("StorySaveBody.AddAvatarComponent(), unsupported wardrobe index:"))
			{
				this.IBFLNCMCKAL = "1";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("OnSketchViewAssetsDownloadFailed") || this.KKEBIBCEIPL.Equals("hdr"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("app42error") || this.PGEKNGNHANN.Equals("OnPopupAvatarCollectionsInputCancel"))
			{
				this.PGEKNGNHANN = "areyousure";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("1") || this.CIEHGJMAFKH.Equals("</i>"))
			{
				this.CIEHGJMAFKH = "<b>";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("OnPopupProfileSaveCutsceneInputCancel") || this.FONKDFDJFEL.Equals("%"))
			{
				this.FONKDFDJFEL = "EEE";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("_not_found") || this.JLEAIJGBGHL.Equals("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/"))
			{
				this.JLEAIJGBGHL = "frds";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("lksuid") || this.OEOPLGFENOO.Equals(""))
			{
				this.OEOPLGFENOO = "OnLoungePremiumChoiceExecutedHardBased";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("snapundocostp") || this.EHCMMPCCHPD.Equals("❤️ "))
			{
				this.EHCMMPCCHPD = "socialbadgetitle";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("copyuidbtn") || this.BMFCFKBCOMC.Equals("SceneLobbyManager2.CollectFilteredAinds() - search result "))
			{
				this.BMFCFKBCOMC = "noisedigitalovr_1";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x00233158 File Offset: 0x00231358
	public int NLKPCIIMLEN()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("RunCustomCode() needToChangeCustomCodeUrl")).Replace(" is OUTSIDE the anthology's story family - not queued (clip:", "tbits3"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x002331C8 File Offset: 0x002313C8
	public int LFPDOLLEEHC()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("OnNeedToActivateFocusItemCloseButton")).Replace("+", "OnChoiceExtendedPanelSlideShown"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x00233238 File Offset: 0x00231438
	public int EGFBEAPFEIG()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("oid")).Replace("doublerewardtut", "StoriesSearchRanker: query '"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x00233290 File Offset: 0x00231490
	public int LJFNGKHLAGI()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(1, this.BMFCFKBCOMC.IndexOf("epos")).Replace("cfind", ")"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x00233300 File Offset: 0x00231500
	public int NIBFBJFMKBG()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(this.BMFCFKBCOMC.IndexOf("asp")).Replace("asp", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005009 RID: 20489 RVA: 0x00233370 File Offset: 0x00231570
	public int GCNNLDKMJIO()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(0, this.CIEHGJMAFKH.IndexOf("trinket")).Replace("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.", "OnLiveProfileThumbnailsCdnFailed"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x002333C8 File Offset: 0x002315C8
	public int AMKODACABMA()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("ok")).Replace(" exp", "OnSettingsPopupCloseAndNeedToRestartGame2"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x00233438 File Offset: 0x00231638
	public int FECFDDGCPGB()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("asp")).Replace("asp", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600500C RID: 20492 RVA: 0x00233490 File Offset: 0x00231690
	public int KHFKEMFHLEN()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(0, this.BMFCFKBCOMC.IndexOf("OnLobbyWheelDataCdnSuccess")).Replace("#", "0"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600500D RID: 20493 RVA: 0x00233500 File Offset: 0x00231700
	public int KEOGLGEMACC()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(1, this.BMFCFKBCOMC.IndexOf(",")).Replace("yes", "UpdateStatsOnOffState"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600500E RID: 20494 RVA: 0x00233570 File Offset: 0x00231770
	public int CJPLHDEMIEJ()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(this.EHCMMPCCHPD.IndexOf("[SkinShop] filters button sprite missing: ")).Replace("Android", ") title("));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600500F RID: 20495 RVA: 0x002335E0 File Offset: 0x002317E0
	public int MIENONJMHHH()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("acliffbw20")).Replace("XXX", "AvatarNameResolver.Initialize(): could not extract variable:"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x00233650 File Offset: 0x00231850
	public int BKOHGOFJIEF()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(this.BMFCFKBCOMC.IndexOf("OnSketchViewAssetsDownloadFailed")).Replace("chs", "ablec"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06005011 RID: 20497 RVA: 0x002336C0 File Offset: 0x002318C0
	public int EHGAIBHHBCI()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(1, this.CIEHGJMAFKH.IndexOf("Starting non-parallel download:")).Replace("socialfriendintro", "XXX"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06005012 RID: 20498 RVA: 0x00233718 File Offset: 0x00231918
	public int NNGPGHFNICD()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(this.EHCMMPCCHPD.IndexOf("ACHIEVEMENTISUNLOCKED")).Replace("XXX", "OnPopupProfileMessageInputCancel"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005013 RID: 20499 RVA: 0x00233788 File Offset: 0x00231988
	public int JMOIGILILCF()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(1, this.BMFCFKBCOMC.IndexOf("anthology")).Replace("OnGamePassExpire", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005014 RID: 20500 RVA: 0x002337F8 File Offset: 0x002319F8
	public bool EHMOANMMEAI(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BIMGHPGAHCH(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), 'u');
			this.IAGMLHAEOJI = list[0];
			this.IBFLNCMCKAL = list[0];
			this.PIMEHAPFCHC = DPGJIJGOCIC.BIMGHPGAHCH(list[2], (char)-79);
			if ((this.PIMEHAPFCHC.Count > 1 && this.PIMEHAPFCHC[0].Equals("OnVideoLayerAutoHide")) || this.PIMEHAPFCHC[1].Equals("skinshopempty"))
			{
				this.PIMEHAPFCHC.RemoveAt(1);
			}
			this.PGEKNGNHANN = list[8];
			this.CIEHGJMAFKH = list[4];
			this.FONKDFDJFEL = list[6];
			this.OEOPLGFENOO = list[3];
			this.FJFEPNKBELL = int.Parse(list[-74]);
			this.LJNPCDKEMNC = int.Parse(list[100]);
			if (this.LJNPCDKEMNC >= 2)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[-70], (char)-79);
				if ((this.HPFHJEAFIHI.Count > 1 && this.HPFHJEAFIHI[0].Equals("x")) || this.HPFHJEAFIHI[1].Equals("Starting non-parallel download:"))
				{
					this.HPFHJEAFIHI.RemoveAt(1);
				}
				this.FPJPHNLANPG = int.Parse(list[-28]);
			}
			if (this.LJNPCDKEMNC >= 8)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[-14]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[44]);
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.EHCMMPCCHPD = list[-28];
			}
			if (this.LJNPCDKEMNC >= 2)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[-28]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[-30]);
			}
			if (this.LJNPCDKEMNC >= 4)
			{
				this.JLEAIJGBGHL = list[106];
				this.BMFCFKBCOMC = list[10];
			}
			if (this.LJNPCDKEMNC >= 8)
			{
				this.KKEBIBCEIPL = list[47];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 0;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("40BF4E") || this.IBFLNCMCKAL.Equals("uid"))
			{
				this.IBFLNCMCKAL = "onboardingthankyoubody0";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals(", because it is already set for ") || this.KKEBIBCEIPL.Equals("fuzzy"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("\"") || this.PGEKNGNHANN.Equals("newseasonawaits"))
			{
				this.PGEKNGNHANN = "BBB";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("energyhinttitle") || this.CIEHGJMAFKH.Equals(" • "))
			{
				this.CIEHGJMAFKH = "";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("newuseraddrequest1") || this.FONKDFDJFEL.Equals("Y"))
			{
				this.FONKDFDJFEL = "\n\n";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals(" ") || this.JLEAIJGBGHL.Equals("CanvasCover"))
			{
				this.JLEAIJGBGHL = "OnLoadingThemeSelectorDownloadFailed";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("areyousure") || this.OEOPLGFENOO.Equals("OnSkinShopCardSelected"))
			{
				this.OEOPLGFENOO = "blur";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("OnBackendGetFriendMessagingHistoryException") || this.EHCMMPCCHPD.Equals("onwishcardclickbodyplayer"))
			{
				this.EHCMMPCCHPD = "ok";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("mypmsg0") || this.BMFCFKBCOMC.Equals("fid"))
			{
				this.BMFCFKBCOMC = "ffavmod";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return false;
		}
		return false;
	}

	// Token: 0x06005015 RID: 20501 RVA: 0x00233CB8 File Offset: 0x00231EB8
	public int EJDMEBJBGBK()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(0, this.OEOPLGFENOO.IndexOf("onAppOpenAttribution")).Replace("apks2", "OnSaveSlotDuplicateRequested"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005016 RID: 20502 RVA: 0x00233D28 File Offset: 0x00231F28
	public bool FHONJPCPCBB(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BIMGHPGAHCH(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), (char)-85);
			this.IAGMLHAEOJI = list[1];
			this.IBFLNCMCKAL = list[1];
			this.PIMEHAPFCHC = DPGJIJGOCIC.BIMGHPGAHCH(list[4], 'f');
			if ((this.PIMEHAPFCHC.Count > 1 && this.PIMEHAPFCHC[0].Equals("bver")) || this.PIMEHAPFCHC[1].Equals("OnStoryChoiceClickConfimed"))
			{
				this.PIMEHAPFCHC.RemoveAt(1);
			}
			this.PGEKNGNHANN = list[0];
			this.CIEHGJMAFKH = list[5];
			this.FONKDFDJFEL = list[1];
			this.OEOPLGFENOO = list[7];
			this.FJFEPNKBELL = int.Parse(list[-77]);
			this.LJNPCDKEMNC = int.Parse(list[32]);
			if (this.LJNPCDKEMNC >= 0)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[77], 'x');
				if ((this.HPFHJEAFIHI.Count > 1 && this.HPFHJEAFIHI[0].Equals("OnCollectableDialogShown")) || this.HPFHJEAFIHI[0].Equals("wshcds"))
				{
					this.HPFHJEAFIHI.RemoveAt(1);
				}
				this.FPJPHNLANPG = int.Parse(list[-43]);
			}
			if (this.LJNPCDKEMNC >= 4)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[102]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[-27]);
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.EHCMMPCCHPD = list[38];
			}
			if (this.LJNPCDKEMNC >= 0)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[92]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[90]);
			}
			if (this.LJNPCDKEMNC >= 8)
			{
				this.JLEAIJGBGHL = list[70];
				this.BMFCFKBCOMC = list[-19];
			}
			if (this.LJNPCDKEMNC >= 7)
			{
				this.KKEBIBCEIPL = list[2];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 0;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("Shaders/VideoGlitchOldTV") || this.IBFLNCMCKAL.Equals(" "))
			{
				this.IBFLNCMCKAL = "rewinbody1";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals("<") || this.KKEBIBCEIPL.Equals(" scrollView0Content children="))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("seasoncompletedesc") || this.PGEKNGNHANN.Equals("anthology"))
			{
				this.PGEKNGNHANN = "item";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("chl") || this.CIEHGJMAFKH.Equals("hintprocessing"))
			{
				this.CIEHGJMAFKH = "liveeventstitles";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("OnApplicationFocusBasicSyncEcxeption") || this.FONKDFDJFEL.Equals(""))
			{
				this.FONKDFDJFEL = "no";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("m_abortFlag = 2") || this.JLEAIJGBGHL.Equals("OnLobbyLoungeOpenRequested"))
			{
				this.JLEAIJGBGHL = "episode";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("body") || this.OEOPLGFENOO.Equals("OnBackendGetIncentRewardAdException"))
			{
				this.OEOPLGFENOO = "off";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("") || this.EHCMMPCCHPD.Equals("snap"))
			{
				this.EHCMMPCCHPD = "@";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("DialogNonPlayerCharacterManager.InputDataIsValid() - step is null.") || this.BMFCFKBCOMC.Equals("Error. MoveEnvironmentVertical(), environment "))
			{
				this.BMFCFKBCOMC = "aind1";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x06005017 RID: 20503 RVA: 0x002341E8 File Offset: 0x002323E8
	public bool IMIOPDPLKNG(string KEGBCGMJOLC)
	{
		try
		{
			this.GKIKEIKFNBC = KEGBCGMJOLC;
			List<string> list = DPGJIJGOCIC.BHMBKAJOHLJ(DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC), 'O');
			this.IAGMLHAEOJI = list[1];
			this.IBFLNCMCKAL = list[1];
			this.PIMEHAPFCHC = DPGJIJGOCIC.FPBLMHCNMEA(list[6], 'u');
			if ((this.PIMEHAPFCHC.Count > 0 && this.PIMEHAPFCHC[0].Equals("")) || this.PIMEHAPFCHC[1].Equals("\nDEF:"))
			{
				this.PIMEHAPFCHC.RemoveAt(0);
			}
			this.PGEKNGNHANN = list[2];
			this.CIEHGJMAFKH = list[4];
			this.FONKDFDJFEL = list[7];
			this.OEOPLGFENOO = list[5];
			this.FJFEPNKBELL = int.Parse(list[77]);
			this.LJNPCDKEMNC = int.Parse(list[112]);
			if (this.LJNPCDKEMNC >= 0)
			{
				this.HPFHJEAFIHI = DPGJIJGOCIC.BHMBKAJOHLJ(list[53], (char)-106);
				if ((this.HPFHJEAFIHI.Count > 1 && this.HPFHJEAFIHI[1].Equals("")) || this.HPFHJEAFIHI[0].Equals(""))
				{
					this.HPFHJEAFIHI.RemoveAt(1);
				}
				this.FPJPHNLANPG = int.Parse(list[-120]);
			}
			if (this.LJNPCDKEMNC >= 8)
			{
				this.LDECHKECBHB = (FCABOFEGPGP)int.Parse(list[110]);
				this.EHPIMACBDLM = (FCABOFEGPGP)int.Parse(list[-10]);
			}
			if (this.LJNPCDKEMNC >= 5)
			{
				this.EHCMMPCCHPD = list[121];
			}
			if (this.LJNPCDKEMNC >= 7)
			{
				this.ONNHAPFMDEN = (PHALBCMBPPL)int.Parse(list[-39]);
				this.JKAHANJANEI = (PHALBCMBPPL)int.Parse(list[102]);
			}
			if (this.LJNPCDKEMNC >= 3)
			{
				this.JLEAIJGBGHL = list[-77];
				this.BMFCFKBCOMC = list[-43];
			}
			if (this.LJNPCDKEMNC >= 8)
			{
				this.KKEBIBCEIPL = list[22];
			}
			this.AMKCLHLIIMN = this.FJFEPNKBELL - 1;
			if (this.IBFLNCMCKAL == null || this.IBFLNCMCKAL.Length == 0 || this.IBFLNCMCKAL.Equals("energyhinttitle") || this.IBFLNCMCKAL.Equals("envlsrw"))
			{
				this.IBFLNCMCKAL = " ";
			}
			if (this.KKEBIBCEIPL == null || this.KKEBIBCEIPL.Length == 0 || this.KKEBIBCEIPL.Equals(", index:") || this.KKEBIBCEIPL.Equals("ind"))
			{
				this.KKEBIBCEIPL = this.IBFLNCMCKAL;
			}
			if (this.PGEKNGNHANN == null || this.PGEKNGNHANN.Length == 0 || this.PGEKNGNHANN.Equals("requirePayer") || this.PGEKNGNHANN.Equals("cut"))
			{
				this.PGEKNGNHANN = " usedSlots:";
			}
			if (this.CIEHGJMAFKH == null || this.CIEHGJMAFKH.Length == 0 || this.CIEHGJMAFKH.Equals("center") || this.CIEHGJMAFKH.Equals("OnStoryInterfaceFastForwardActivate"))
			{
				this.CIEHGJMAFKH = "muspind";
			}
			if (this.FONKDFDJFEL == null || this.FONKDFDJFEL.Length == 0 || this.FONKDFDJFEL.Equals("stat6long") || this.FONKDFDJFEL.Equals(" "))
			{
				this.FONKDFDJFEL = "socialjoinno";
			}
			if (this.JLEAIJGBGHL == null || this.JLEAIJGBGHL.Length == 0 || this.JLEAIJGBGHL.Equals("socialbadge499") || this.JLEAIJGBGHL.Equals("acomp2"))
			{
				this.JLEAIJGBGHL = "_ColorDrift";
			}
			if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0 || this.OEOPLGFENOO.Equals("favcut") || this.OEOPLGFENOO.Equals(" c="))
			{
				this.OEOPLGFENOO = " ";
			}
			if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0 || this.EHCMMPCCHPD.Equals("\"") || this.EHCMMPCCHPD.Equals(")"))
			{
				this.EHCMMPCCHPD = "e";
			}
			if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0 || this.BMFCFKBCOMC.Equals("stat0long") || this.BMFCFKBCOMC.Equals("notifposteffects"))
			{
				this.BMFCFKBCOMC = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return false;
		}
		return true;
	}

	// Token: 0x06005018 RID: 20504 RVA: 0x002346A8 File Offset: 0x002328A8
	public int JHMHOOLADAK()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(0, this.OEOPLGFENOO.IndexOf("errortitle")).Replace("query", "OnBackendRequestSpinWheelSuccess"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06005019 RID: 20505 RVA: 0x00234718 File Offset: 0x00232918
	public int FPOOFDFJJGA()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("OnBackendGetPublicProfileSuccess")).Replace("", ""));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x00234770 File Offset: 0x00232970
	public int PAFMEGBLAJO()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("lsenvattempt")).Replace("", "_not_found"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x002347E0 File Offset: 0x002329E0
	public int PCFMNHABNFJ()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(this.OEOPLGFENOO.IndexOf("")).Replace("episode", "Profile data 6 bundle loaded but its asset is missing or mis-named:"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600501C RID: 20508 RVA: 0x00234850 File Offset: 0x00232A50
	public int ICALPKMFBNP()
	{
		if (this.EHCMMPCCHPD == null || this.EHCMMPCCHPD.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.EHCMMPCCHPD.Substring(this.EHCMMPCCHPD.IndexOf("app42error")).Replace("", "ContentFriendsPage.GetLocalizedCostData() - productData is null."));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600501D RID: 20509 RVA: 0x002348C0 File Offset: 0x00232AC0
	public int EFDBLHBOOKN()
	{
		if (this.BMFCFKBCOMC == null || this.BMFCFKBCOMC.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.BMFCFKBCOMC.Substring(this.BMFCFKBCOMC.IndexOf("")).Replace("", ""));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600501E RID: 20510 RVA: 0x00234930 File Offset: 0x00232B30
	public int ALEMAJBPGIO()
	{
		int result;
		try
		{
			result = int.Parse(this.CIEHGJMAFKH.Substring(this.CIEHGJMAFKH.IndexOf("stat4long")).Replace("layervideo", "credo"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x00234988 File Offset: 0x00232B88
	public int KIGPGMPNEIM()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(1, this.OEOPLGFENOO.IndexOf(" \",")).Replace("", "\""));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06005020 RID: 20512 RVA: 0x002349F8 File Offset: 0x00232BF8
	public int IEHDNILEDDD()
	{
		if (this.OEOPLGFENOO == null || this.OEOPLGFENOO.Length == 0)
		{
			return -1;
		}
		int result;
		try
		{
			result = int.Parse(this.OEOPLGFENOO.Substring(1, this.OEOPLGFENOO.IndexOf("OnPurchasingNotInitialized")).Replace("hoursshort", "name"));
		}
		catch
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x04001672 RID: 5746
	public string IAGMLHAEOJI = "";

	// Token: 0x04001673 RID: 5747
	public string IBFLNCMCKAL = "";

	// Token: 0x04001674 RID: 5748
	public string KKEBIBCEIPL = "";

	// Token: 0x04001675 RID: 5749
	public List<string> PIMEHAPFCHC = new List<string>();

	// Token: 0x04001676 RID: 5750
	public List<string> HPFHJEAFIHI = new List<string>();

	// Token: 0x04001677 RID: 5751
	public int FPJPHNLANPG;

	// Token: 0x04001678 RID: 5752
	public string PGEKNGNHANN = "";

	// Token: 0x04001679 RID: 5753
	public string CIEHGJMAFKH = "";

	// Token: 0x0400167A RID: 5754
	public string FONKDFDJFEL = "";

	// Token: 0x0400167B RID: 5755
	public string OEOPLGFENOO = "";

	// Token: 0x0400167C RID: 5756
	public string JLEAIJGBGHL = "";

	// Token: 0x0400167D RID: 5757
	public string BMFCFKBCOMC = "";

	// Token: 0x0400167E RID: 5758
	public string EHCMMPCCHPD = "";

	// Token: 0x0400167F RID: 5759
	public int FJFEPNKBELL;

	// Token: 0x04001680 RID: 5760
	public int LJNPCDKEMNC;

	// Token: 0x04001681 RID: 5761
	public FCABOFEGPGP LDECHKECBHB = FCABOFEGPGP.center;

	// Token: 0x04001682 RID: 5762
	public FCABOFEGPGP EHPIMACBDLM = FCABOFEGPGP.center;

	// Token: 0x04001683 RID: 5763
	public PHALBCMBPPL ONNHAPFMDEN = PHALBCMBPPL.center;

	// Token: 0x04001684 RID: 5764
	public PHALBCMBPPL JKAHANJANEI = PHALBCMBPPL.center;

	// Token: 0x04001685 RID: 5765
	public int AMKCLHLIIMN;

	// Token: 0x04001686 RID: 5766
	public CLGFGOHBCGJ CGBHBJPLKIM;

	// Token: 0x04001687 RID: 5767
	private string GKIKEIKFNBC = "";
}
