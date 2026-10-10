using System;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000414 RID: 1044
public class GlitchEffect : ImageEffectBase
{
	// Token: 0x06007C8C RID: 31884 RVA: 0x00374BDC File Offset: 0x00372DDC
	private void OKDDGMICCKG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("ant", this.intensity);
		base.material.SetFloat("envlhrw", this.colorIntensity);
		base.material.SetTexture("", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("mypofflinebody", UnityEngine.Random.Range(1299f, 1485f) * this.colorIntensity);
			base.material.SetVector("cardsvolchancesmsgtitle", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, -114) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1149f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 745f)
		{
			base.material.SetFloat("Npc animation bundle loaded but its asset is missing or mis-named:", 1070f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 129f * this.flipIntensity)
			{
				base.material.SetFloat("LastShowItemStep() - could not find a give item step.", UnityEngine.Random.Range(1465f, 7f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("Error deserializing JSON. Unknown tag: ", 1013f);
			}
			this.NKCIHBJFFAK = 1047f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 617f;
		}
		if (this.flipIntensity == 1016f)
		{
			base.material.SetFloat("yyyy/MM/dd HH:mm:ss", 1911f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 884f * this.flipIntensity)
			{
				base.material.SetFloat("", 1386f - UnityEngine.Random.Range(1601f, 1681f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("<line-height=", 1009f);
			}
			this.OCCAALADPLM = 1814f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 652f;
		}
		if (this.flipIntensity == 375f)
		{
			base.material.SetFloat("-", 335f);
		}
		if ((double)UnityEngine.Random.value < 1335.0 * (double)this.intensity)
		{
			base.material.SetFloat("abs", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("", 898f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("errortitle", 300f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C8D RID: 31885 RVA: 0x00374EDC File Offset: 0x003730DC
	private void BIPPKDNDLGB(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("", this.intensity);
		base.material.SetFloat("id", this.colorIntensity);
		base.material.SetTexture("eml", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("Asset bundle assets destroyed:", UnityEngine.Random.Range(896f, 1486f) * this.colorIntensity);
			base.material.SetVector(" cloud shop row(s) appended to ", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, -166) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 589f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1230f)
		{
			base.material.SetFloat("rev", 1112f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 350f * this.flipIntensity)
			{
				base.material.SetFloat("af_order_id", UnityEngine.Random.Range(340f, 1221f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("no", 1170f);
			}
			this.NKCIHBJFFAK = 1335f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1675f;
		}
		if (this.flipIntensity == 672f)
		{
			base.material.SetFloat("energyhinttitle", 1361f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 486f * this.flipIntensity)
			{
				base.material.SetFloat("〈", 1393f - UnityEngine.Random.Range(1925f, 1750f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("_AlphaTex", 1507f);
			}
			this.OCCAALADPLM = 793f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1904f;
		}
		if (this.flipIntensity == 81f)
		{
			base.material.SetFloat("", 831f);
		}
		if ((double)UnityEngine.Random.value < 781.0 * (double)this.intensity)
		{
			base.material.SetFloat("", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("pers", 1978f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("Loaded asset bundle:", 296f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C8E RID: 31886 RVA: 0x003751DC File Offset: 0x003733DC
	private void GPKFJJHFGJG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("", this.intensity);
		base.material.SetFloat("OnAccountSignInSuccess", this.colorIntensity);
		base.material.SetTexture("scene bundle ", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("fruidres2", UnityEngine.Random.Range(1362f, 352f) * this.colorIntensity);
			base.material.SetVector(" has only ", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -18) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 539f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1402f)
		{
			base.material.SetFloat("importanttitle", 284f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 253f * this.flipIntensity)
			{
				base.material.SetFloat("OnStoryCurrencyInfoClick", UnityEngine.Random.Range(1407f, 1382f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("socialbadgedesc", 1669f);
			}
			this.NKCIHBJFFAK = 1768f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 478f;
		}
		if (this.flipIntensity == 610f)
		{
			base.material.SetFloat("nam", 906f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 412f * this.flipIntensity)
			{
				base.material.SetFloat("slow", 243f - UnityEngine.Random.Range(698f, 292f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("layervideo", 754f);
			}
			this.OCCAALADPLM = 1972f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1885f;
		}
		if (this.flipIntensity == 715f)
		{
			base.material.SetFloat("continue", 570f);
		}
		if ((double)UnityEngine.Random.value < 581.0 * (double)this.intensity)
		{
			base.material.SetFloat("</Modulus></RSAKeyValue>", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("x$", 1653f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("x", 520f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C8F RID: 31887 RVA: 0x003754DC File Offset: 0x003736DC
	private void PEAMNCOFAEK(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("p", this.intensity);
		base.material.SetFloat("OnPurchaseFailed", this.colorIntensity);
		base.material.SetTexture("spectrumovr", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("</i>", UnityEngine.Random.Range(177f, 1906f) * this.colorIntensity);
			base.material.SetVector("signinlinkfb", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 29) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 482f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1347f)
		{
			base.material.SetFloat(" barAvailable=", 1217f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 143f * this.flipIntensity)
			{
				base.material.SetFloat("[LoadingEnv] cache file of ", UnityEngine.Random.Range(467f, 117f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("[LoadingEnv] stored theme parked after the unclean exit", 1941f);
			}
			this.NKCIHBJFFAK = 606f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 280f;
		}
		if (this.flipIntensity == 1335f)
		{
			base.material.SetFloat("loungetreasuresyouhave", 1793f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1364f * this.flipIntensity)
			{
				base.material.SetFloat("CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution.", 1186f - UnityEngine.Random.Range(180f, 910f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("errortitle", 1746f);
			}
			this.OCCAALADPLM = 209f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1116f;
		}
		if (this.flipIntensity == 1375f)
		{
			base.material.SetFloat("chaptersnapshotsmissingbody", 1779f);
		}
		if ((double)UnityEngine.Random.value < 969.0 * (double)this.intensity)
		{
			base.material.SetFloat("", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("lsenvdrop", 886f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat(" - false", 1642f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C90 RID: 31888 RVA: 0x003757DC File Offset: 0x003739DC
	private void PGMBJGOKOOJ(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("normal", this.intensity);
		base.material.SetFloat("clthbr", this.colorIntensity);
		base.material.SetTexture("", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat(" is OUTSIDE the anthology's story family - not queued (clip:", UnityEngine.Random.Range(4f, 1893f) * this.colorIntensity);
			base.material.SetVector(" not found.", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 80) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1226f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 855f)
		{
			base.material.SetFloat("SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()", 359f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 95f * this.flipIntensity)
			{
				base.material.SetFloat("StoriesSearchRanker: query '", UnityEngine.Random.Range(921f, 585f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("ok", 676f);
			}
			this.NKCIHBJFFAK = 1884f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 109f;
		}
		if (this.flipIntensity == 15f)
		{
			base.material.SetFloat("SceneLobbyManager2.CollectFilteredAinds() - search result ", 1911f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 193f * this.flipIntensity)
			{
				base.material.SetFloat("OnBackendAddFriendByUIDSuccess", 1729f - UnityEngine.Random.Range(808f, 1752f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("Starting non-parallel download:", 1329f);
			}
			this.OCCAALADPLM = 1036f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 861f;
		}
		if (this.flipIntensity == 1514f)
		{
			base.material.SetFloat("blur", 713f);
		}
		if ((double)UnityEngine.Random.value < 659.0 * (double)this.intensity)
		{
			base.material.SetFloat("Asset bundle load operation failed during parallel mode.", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("Trading/Wished cards userPublicProfile.modified = true hit", 1770f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("SceneLobbyManager.OpenFocusItem() - resetting activeSaveSlotIndex to 0, user is using a paid slot.", 67f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C91 RID: 31889 RVA: 0x00375ADC File Offset: 0x00373CDC
	private void LBEHEPKNCGM(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("errortitle", this.intensity);
		base.material.SetFloat("p", this.colorIntensity);
		base.material.SetTexture(" ", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("OnStoryChoiceClickConfimed", UnityEngine.Random.Range(1545f, 1710f) * this.colorIntensity);
			base.material.SetVector("abs", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 164) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 148f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 891f)
		{
			base.material.SetFloat("u", 141f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 11f * this.flipIntensity)
			{
				base.material.SetFloat("", UnityEngine.Random.Range(473f, 528f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("StoriesSearchRanker: nothing to search (anthologies ", 665f);
			}
			this.NKCIHBJFFAK = 337f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1426f;
		}
		if (this.flipIntensity == 465f)
		{
			base.material.SetFloat("OnStoryInterfaceHeaderAvatarClick", 765f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 75f * this.flipIntensity)
			{
				base.material.SetFloat("apks", 1027f - UnityEngine.Random.Range(709f, 1917f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("sltind", 1732f);
			}
			this.OCCAALADPLM = 967f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 754f;
		}
		if (this.flipIntensity == 149f)
		{
			base.material.SetFloat("continue", 1085f);
		}
		if ((double)UnityEngine.Random.value < 1572.0 * (double)this.intensity)
		{
			base.material.SetFloat("thmstr", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat(" (", 811f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat(" (", 1970f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C92 RID: 31890 RVA: 0x00375DDC File Offset: 0x00373FDC
	private void BACNHCOCPHM(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("", this.intensity);
		base.material.SetFloat("center", this.colorIntensity);
		base.material.SetTexture("Asset bundle load operation failed during parallel mode.", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("AssetAvatarComponent.StringToAssetFaceEmotionType() - unknown value", UnityEngine.Random.Range(883f, 1120f) * this.colorIntensity);
			base.material.SetVector("') is empty or not a number", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 57) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1713f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1758f)
		{
			base.material.SetFloat("OnBackendGetPublicProfileHallOfFameMoreSuccess", 1843f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 240f * this.flipIntensity)
			{
				base.material.SetFloat(" ", UnityEngine.Random.Range(1991f, 846f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 1645f);
			}
			this.NKCIHBJFFAK = 646f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 951f;
		}
		if (this.flipIntensity == 1403f)
		{
			base.material.SetFloat("sparklesbundles", 782f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 286f * this.flipIntensity)
			{
				base.material.SetFloat("'{0}' material null.", 1966f - UnityEngine.Random.Range(616f, 1053f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("OnSceneLobbyManagerRound0AssetsDownloadSuccess", 1469f);
			}
			this.OCCAALADPLM = 767f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 380f;
		}
		if (this.flipIntensity == 1561f)
		{
			base.material.SetFloat("CameraEnvironmentsFront", 356f);
		}
		if ((double)UnityEngine.Random.value < 1822.0 * (double)this.intensity)
		{
			base.material.SetFloat("energyhinttitle", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("-", 1315f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("PurchaseManagerXiaomi.OnBackendValidateTransactionSuccess().", 1502f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C93 RID: 31891 RVA: 0x003760DC File Offset: 0x003742DC
	private void JLINHKPNLHP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat(")", this.intensity);
		base.material.SetFloat("<i>", this.colorIntensity);
		base.material.SetTexture("OnLobbyProfileDataCdnFailed", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("", UnityEngine.Random.Range(1465f, 567f) * this.colorIntensity);
			base.material.SetVector("FocusItem.UpdateAvatarButtonIcon(): lounge glyph resource missing - focusavatarloungeicon", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 113) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 532f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1418f)
		{
			base.material.SetFloat("continue", 827f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1477f * this.flipIntensity)
			{
				base.material.SetFloat("،", UnityEngine.Random.Range(923f, 179f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("assetbundleprofiledata", 1732f);
			}
			this.NKCIHBJFFAK = 1543f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 672f;
		}
		if (this.flipIntensity == 1583f)
		{
			base.material.SetFloat("novideosupportmsg", 210f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 80f * this.flipIntensity)
			{
				base.material.SetFloat("0.000", 1532f - UnityEngine.Random.Range(1166f, 1117f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat(".", 1546f);
			}
			this.OCCAALADPLM = 791f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 239f;
		}
		if (this.flipIntensity == 1770f)
		{
			base.material.SetFloat("OnPopupStoryRestartManagerRestartStory0", 1341f);
		}
		if ((double)UnityEngine.Random.value < 473.0 * (double)this.intensity)
		{
			base.material.SetFloat(")", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("OnCutsceneViewAssetsDownloadFailed", 1370f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("spld", 1905f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C94 RID: 31892 RVA: 0x003763DC File Offset: 0x003745DC
	private void ICKBJBGJNFP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat(" lastFilter=", this.intensity);
		base.material.SetFloat("sparkles", this.colorIntensity);
		base.material.SetTexture("", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat(" aind ", UnityEngine.Random.Range(1424f, 1886f) * this.colorIntensity);
			base.material.SetVector("ru", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 6) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 630f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 711f)
		{
			base.material.SetFloat("OnPopupProfileSaveCutsceneInputCancel", 721f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1389f * this.flipIntensity)
			{
				base.material.SetFloat("OnBackendRequestFriendDeleteSuccess", UnityEngine.Random.Range(1592f, 1084f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("stat", 272f);
			}
			this.NKCIHBJFFAK = 892f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1262f;
		}
		if (this.flipIntensity == 1377f)
		{
			base.material.SetFloat("XXX", 1502f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1637f * this.flipIntensity)
			{
				base.material.SetFloat("-", 221f - UnityEngine.Random.Range(1912f, 113f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 396f);
			}
			this.OCCAALADPLM = 477f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 188f;
		}
		if (this.flipIntensity == 656f)
		{
			base.material.SetFloat("T", 1004f);
		}
		if ((double)UnityEngine.Random.value < 51.0 * (double)this.intensity)
		{
			base.material.SetFloat("cardcollectcardpurchase0", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("hintsigning", 1176f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("", 343f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C95 RID: 31893 RVA: 0x003766DC File Offset: 0x003748DC
	private void DHNFBAHKKAC(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("areyousure", this.intensity);
		base.material.SetFloat("AppsFlyerManagerSteam.Initialize() - Can not initialize, Steam client is not running.", this.colorIntensity);
		base.material.SetTexture("PlaySfx() file not found:", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("", UnityEngine.Random.Range(1883f, 1463f) * this.colorIntensity);
			base.material.SetVector("]' at storySaves[", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 126) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1297f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 778f)
		{
			base.material.SetFloat("asp", 1635f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 801f * this.flipIntensity)
			{
				base.material.SetFloat("OnFriendsGiftPopulCollectPart2", UnityEngine.Random.Range(1619f, 901f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("null", 1230f);
			}
			this.NKCIHBJFFAK = 615f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1669f;
		}
		if (this.flipIntensity == 489f)
		{
			base.material.SetFloat("Asset pack has been SKIPPED according to on demand resources data:", 1063f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1165f * this.flipIntensity)
			{
				base.material.SetFloat("$e1ct", 1379f - UnityEngine.Random.Range(260f, 1922f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("avts2", 1186f);
			}
			this.OCCAALADPLM = 1358f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 108f;
		}
		if (this.flipIntensity == 1246f)
		{
			base.material.SetFloat("TryRepeatRunCustomCodeOnInfiniteRequest():", 1166f);
		}
		if ((double)UnityEngine.Random.value < 1182.0 * (double)this.intensity)
		{
			base.material.SetFloat("</i>", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("sdcbq", 1675f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("varConditionLockedValue", 1788f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C96 RID: 31894 RVA: 0x003769DC File Offset: 0x00374BDC
	private void PBJHDBJBBLK(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("OnRestorePurchasesZeroResult", this.intensity);
		base.material.SetFloat("@SD", this.colorIntensity);
		base.material.SetTexture("getLiveOffers", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("iac", UnityEngine.Random.Range(706f, 105f) * this.colorIntensity);
			base.material.SetVector("assetbundleprofiledata6", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, -115) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 361f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 607f)
		{
			base.material.SetFloat("episode", 764f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1676f * this.flipIntensity)
			{
				base.material.SetFloat("XXX", UnityEngine.Random.Range(865f, 1823f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("envls", 1466f);
			}
			this.NKCIHBJFFAK = 55f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1592f;
		}
		if (this.flipIntensity == 1207f)
		{
			base.material.SetFloat(" rtMemory:", 259f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 250f * this.flipIntensity)
			{
				base.material.SetFloat("sto", 110f - UnityEngine.Random.Range(317f, 123f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("...", 212f);
			}
			this.OCCAALADPLM = 53f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1485f;
		}
		if (this.flipIntensity == 1472f)
		{
			base.material.SetFloat("a", 1682f);
		}
		if ((double)UnityEngine.Random.value < 1719.0 * (double)this.intensity)
		{
			base.material.SetFloat("CLIENT.POSTEFFECTS.ANALOGGLITCH.OVR", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("ok", 1972f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat(" (shopind:", 877f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C97 RID: 31895 RVA: 0x00376CDC File Offset: 0x00374EDC
	private void DBBGNAKILNB(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("", this.intensity);
		base.material.SetFloat("repsuid", this.colorIntensity);
		base.material.SetTexture("frrjctpid", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("CLIENT.POSTEFFECTS.SPECTRUM.OVR", UnityEngine.Random.Range(771f, 478f) * this.colorIntensity);
			base.material.SetVector("skpcut", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -102) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1461f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 68f)
		{
			base.material.SetFloat("ans", 1694f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1989f * this.flipIntensity)
			{
				base.material.SetFloat("PurchaseManagerUnity.OnPurchaseDeferred():Purchase deferred - Product: ", UnityEngine.Random.Range(452f, 1404f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("t", 164f);
			}
			this.NKCIHBJFFAK = 193f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1578f;
		}
		if (this.flipIntensity == 369f)
		{
			base.material.SetFloat("p", 1731f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1743f * this.flipIntensity)
			{
				base.material.SetFloat("crossfade", 296f - UnityEngine.Random.Range(973f, 432f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("p", 522f);
			}
			this.OCCAALADPLM = 1184f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 317f;
		}
		if (this.flipIntensity == 512f)
		{
			base.material.SetFloat("cardoptionssendasgift", 1809f);
		}
		if ((double)UnityEngine.Random.value < 170.0 * (double)this.intensity)
		{
			base.material.SetFloat("yes", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("OnBackendValidateTransactionSuccess", 1343f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("fsv", 510f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C98 RID: 31896 RVA: 0x00376FDC File Offset: 0x003751DC
	private void GILBMGKCFBG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("p", this.intensity);
		base.material.SetFloat("", this.colorIntensity);
		base.material.SetTexture("areyousure", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("actant", UnityEngine.Random.Range(1754f, 1230f) * this.colorIntensity);
			base.material.SetVector("sim", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 127) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 369f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 712f)
		{
			base.material.SetFloat("$", 596f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 745f * this.flipIntensity)
			{
				base.material.SetFloat("OnBackendValidateTransactionFailed", UnityEngine.Random.Range(61f, 1029f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("ord", 278f);
			}
			this.NKCIHBJFFAK = 1380f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1153f;
		}
		if (this.flipIntensity == 1061f)
		{
			base.material.SetFloat("ISBITSET", 240f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1113f * this.flipIntensity)
			{
				base.material.SetFloat("WheelItem.IssueRewards() - spinWheelCardIndex < 0", 1107f - UnityEngine.Random.Range(510f, 1379f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("User stats received for app {0}", 1f);
			}
			this.OCCAALADPLM = 1388f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 722f;
		}
		if (this.flipIntensity == 547f)
		{
			base.material.SetFloat(":", 1738f);
		}
		if ((double)UnityEngine.Random.value < 837.0 * (double)this.intensity)
		{
			base.material.SetFloat("p", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("", 935f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("energyhinttitle", 1290f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C99 RID: 31897 RVA: 0x003772DC File Offset: 0x003754DC
	private void FEEMJFDMPBC(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("OnSketchThumbnailsCdnFailed", this.intensity);
		base.material.SetFloat(" is OUTSIDE the anthology's story family - not queued (clip:", this.colorIntensity);
		base.material.SetTexture("errortitle", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat(".", UnityEngine.Random.Range(445f, 1262f) * this.colorIntensity);
			base.material.SetVector("@", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -167) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 83f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1484f)
		{
			base.material.SetFloat("7$", 277f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1530f * this.flipIntensity)
			{
				base.material.SetFloat("", UnityEngine.Random.Range(942f, 1575f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("[LoadingEnv] ", 1503f);
			}
			this.NKCIHBJFFAK = 200f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1918f;
		}
		if (this.flipIntensity == 1152f)
		{
			base.material.SetFloat("OnStoryChoiceClick", 1546f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1608f * this.flipIntensity)
			{
				base.material.SetFloat("socialrequestwarnyou", 672f - UnityEngine.Random.Range(956f, 1997f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("' is not 0 / 1, the npc animations stay ON: ", 1900f);
			}
			this.OCCAALADPLM = 1268f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 412f;
		}
		if (this.flipIntensity == 1966f)
		{
			base.material.SetFloat("areyousure", 1680f);
		}
		if ((double)UnityEngine.Random.value < 111.0 * (double)this.intensity)
		{
			base.material.SetFloat("epos", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("avataroverlay0", 1827f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("signinerror001", 1279f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C9A RID: 31898 RVA: 0x003775DC File Offset: 0x003757DC
	private void KEODJPBLKFL(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("actshlv2", this.intensity);
		base.material.SetFloat("ok", this.colorIntensity);
		base.material.SetTexture("AdsManagerLP: Received RewardedVideoOnAdDisplayedFailedEvent", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("fsharv2", UnityEngine.Random.Range(128f, 749f) * this.colorIntensity);
			base.material.SetVector("_UVRemap", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -89) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1759f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 24f)
		{
			base.material.SetFloat("", 1217f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1165f * this.flipIntensity)
			{
				base.material.SetFloat("friendspluschattutorialinactivebtn1", UnityEngine.Random.Range(715f, 1345f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("wind", 913f);
			}
			this.NKCIHBJFFAK = 1247f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 789f;
		}
		if (this.flipIntensity == 203f)
		{
			base.material.SetFloat("common", 99f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1377f * this.flipIntensity)
			{
				base.material.SetFloat("Starting parallel download:", 833f - UnityEngine.Random.Range(344f, 1159f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("<", 433f);
			}
			this.OCCAALADPLM = 1464f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 658f;
		}
		if (this.flipIntensity == 1500f)
		{
			base.material.SetFloat("OnLobbyLoungeOpenRequested", 331f);
		}
		if ((double)UnityEngine.Random.value < 1810.0 * (double)this.intensity)
		{
			base.material.SetFloat("OnConsumeEnergySuccess", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("importanttitle", 1350f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("$CHOICEMETA", 273f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C9B RID: 31899 RVA: 0x003778DC File Offset: 0x00375ADC
	private void FPAKHKDIPGK(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("ZZZ", this.intensity);
		base.material.SetFloat("", this.colorIntensity);
		base.material.SetTexture("SocialStatsUserPublicProfile.modified = false, OnFriendsMessageConsume()", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("", UnityEngine.Random.Range(1507f, 1847f) * this.colorIntensity);
			base.material.SetVector("</i>.", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 67) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1147f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1925f)
		{
			base.material.SetFloat("assetbundleprofiledata4", 383f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 138f * this.flipIntensity)
			{
				base.material.SetFloat("/", UnityEngine.Random.Range(1169f, 606f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("it", 718f);
			}
			this.NKCIHBJFFAK = 1036f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1043f;
		}
		if (this.flipIntensity == 326f)
		{
			base.material.SetFloat("StoriesSearchNormalizer.SetStopwords() - invalid lobby language index ", 320f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 253f * this.flipIntensity)
			{
				base.material.SetFloat("ok", 1755f - UnityEngine.Random.Range(1286f, 1394f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("PopupRemoveAdsManager.Show() - productData is null.", 1667f);
			}
			this.OCCAALADPLM = 155f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 975f;
		}
		if (this.flipIntensity == 1996f)
		{
			base.material.SetFloat("errortitle", 1256f);
		}
		if ((double)UnityEngine.Random.value < 609.0 * (double)this.intensity)
		{
			base.material.SetFloat(" (", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("$LAYERSHOW", 1532f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("makeup", 1448f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C9C RID: 31900 RVA: 0x00377BDC File Offset: 0x00375DDC
	private void GAJIFHKIBNL(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("OnApplicationFocusBasicSyncSuccess", this.intensity);
		base.material.SetFloat("x", this.colorIntensity);
		base.material.SetTexture("skhomelockmsg", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("achievtitle", UnityEngine.Random.Range(1778f, 604f) * this.colorIntensity);
			base.material.SetVector("_", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -17) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 276f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1137f)
		{
			base.material.SetFloat("sp", 1044f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 507f * this.flipIntensity)
			{
				base.material.SetFloat("OnPopupUsernameInputCancel", UnityEngine.Random.Range(1276f, 174f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat(" ", 604f);
			}
			this.NKCIHBJFFAK = 815f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1146f;
		}
		if (this.flipIntensity == 239f)
		{
			base.material.SetFloat(" having a percent of ", 1312f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 407f * this.flipIntensity)
			{
				base.material.SetFloat("SocialStatsUserPublicProfile.modified = true, SetAvatarIcon()", 829f - UnityEngine.Random.Range(77f, 1868f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("sid", 1627f);
			}
			this.OCCAALADPLM = 138f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 194f;
		}
		if (this.flipIntensity == 1061f)
		{
			base.material.SetFloat("[LoadingEnv] ", 35f);
		}
		if ((double)UnityEngine.Random.value < 1099.0 * (double)this.intensity)
		{
			base.material.SetFloat("importanttitle", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("myprofilelimitation", 297f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("_", 404f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C9D RID: 31901 RVA: 0x00377EDC File Offset: 0x003760DC
	private void AMKHNCGEMMF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat(" ", this.intensity);
		base.material.SetFloat("ok", this.colorIntensity);
		base.material.SetTexture("CharacterTransitionManager - transition not loaded or invalid, falling back to crossfade:", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("seasoncompletedescspecialepisode", UnityEngine.Random.Range(1162f, 133f) * this.colorIntensity);
			base.material.SetVector("tmp", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 37) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1222f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1124f)
		{
			base.material.SetFloat(",", 1795f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1132f * this.flipIntensity)
			{
				base.material.SetFloat("Error. PlayParticlesForEnvironmentLayer(), environmentLayer ", UnityEngine.Random.Range(351f, 1767f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("There needs to be one active AudioManager script on a GameObject in your scene.", 729f);
			}
			this.NKCIHBJFFAK = 1026f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 125f;
		}
		if (this.flipIntensity == 1019f)
		{
			base.material.SetFloat("%</b>", 1665f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 492f * this.flipIntensity)
			{
				base.material.SetFloat("\r", 317f - UnityEngine.Random.Range(1294f, 1496f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("error details: ", 1102f);
			}
			this.OCCAALADPLM = 1982f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1736f;
		}
		if (this.flipIntensity == 1930f)
		{
			base.material.SetFloat("OnSpinsUnlockContinueToPurchasingScreen", 1235f);
		}
		if ((double)UnityEngine.Random.value < 1475.0 * (double)this.intensity)
		{
			base.material.SetFloat("OnPopupProfileUIDInputCancel", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("OnSpinsUnlockContinueToPurchasingScreen", 859f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("\r", 1929f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C9E RID: 31902 RVA: 0x003781DC File Offset: 0x003763DC
	private void FBMGHEAMPCE(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("top", this.intensity);
		base.material.SetFloat("", this.colorIntensity);
		base.material.SetTexture(" ", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("tdgcds", UnityEngine.Random.Range(1703f, 373f) * this.colorIntensity);
			base.material.SetVector("h", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -128) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1957f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 112f)
		{
			base.material.SetFloat("onwishcardclickbodymatch", 339f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 234f * this.flipIntensity)
			{
				base.material.SetFloat("ActivateSystemBackButtonManager", UnityEngine.Random.Range(1298f, 1955f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("OnStoryInterfaceHeaderSettingsClick", 1693f);
			}
			this.NKCIHBJFFAK = 63f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 762f;
		}
		if (this.flipIntensity == 120f)
		{
			base.material.SetFloat("unity", 1419f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 324f * this.flipIntensity)
			{
				base.material.SetFloat("ltwt", 1210f - UnityEngine.Random.Range(645f, 924f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("Is success: ", 1971f);
			}
			this.OCCAALADPLM = 1980f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1940f;
		}
		if (this.flipIntensity == 99f)
		{
			base.material.SetFloat("OnPurchasingViewLeave", 1574f);
		}
		if ((double)UnityEngine.Random.value < 315.0 * (double)this.intensity)
		{
			base.material.SetFloat("mpi", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("ProfileItem2._DownloadCardsPool(): released ", 1978f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("Repeat Notification", 251f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007C9F RID: 31903 RVA: 0x003784DC File Offset: 0x003766DC
	private void OnRenderImage(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("_Intensity", this.intensity);
		base.material.SetFloat("_ColorIntensity", this.colorIntensity);
		base.material.SetTexture("_DispTex", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("filterRadius", UnityEngine.Random.Range(-3f, 3f) * this.colorIntensity);
			base.material.SetVector("direction", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 360) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 0f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 0f)
		{
			base.material.SetFloat("filterRadius", 0f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 0.1f * this.flipIntensity)
			{
				base.material.SetFloat("flip_up", UnityEngine.Random.Range(0f, 1f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("flip_up", 0f);
			}
			this.NKCIHBJFFAK = 0f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 10f;
		}
		if (this.flipIntensity == 0f)
		{
			base.material.SetFloat("flip_up", 0f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 0.1f * this.flipIntensity)
			{
				base.material.SetFloat("flip_down", 1f - UnityEngine.Random.Range(0f, 1f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("flip_down", 1f);
			}
			this.OCCAALADPLM = 0f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 10f;
		}
		if (this.flipIntensity == 0f)
		{
			base.material.SetFloat("flip_down", 1f);
		}
		if ((double)UnityEngine.Random.value < 0.05 * (double)this.intensity)
		{
			base.material.SetFloat("displace", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("scale", 1f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("displace", 0f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA0 RID: 31904 RVA: 0x003787DC File Offset: 0x003769DC
	private void BHEGLJNBAMP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("", this.intensity);
		base.material.SetFloat(", ", this.colorIntensity);
		base.material.SetTexture("XXX", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat(" bringing up ", UnityEngine.Random.Range(1110f, 1911f) * this.colorIntensity);
			base.material.SetVector("assetbundlelobbydata2", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, -200) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1573f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1392f)
		{
			base.material.SetFloat("OnPopupCardOptionsBackClickLobby", 945f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 64f * this.flipIntensity)
			{
				base.material.SetFloat("", UnityEngine.Random.Range(1647f, 484f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("blur", 1340f);
			}
			this.NKCIHBJFFAK = 831f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 227f;
		}
		if (this.flipIntensity == 1842f)
		{
			base.material.SetFloat("", 964f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 481f * this.flipIntensity)
			{
				base.material.SetFloat("uid", 657f - UnityEngine.Random.Range(15f, 1918f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("loungetreasuresyouhave", 688f);
			}
			this.OCCAALADPLM = 1056f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 246f;
		}
		if (this.flipIntensity == 609f)
		{
			base.material.SetFloat("@", 573f);
		}
		if ((double)UnityEngine.Random.value < 1894.0 * (double)this.intensity)
		{
			base.material.SetFloat("", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat(" secondary(pending)", 1394f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("$STRCONTAINS", 621f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA1 RID: 31905 RVA: 0x00378ADC File Offset: 0x00376CDC
	private void CLKOFKFCFIE(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("specialcurrencyoptionna", this.intensity);
		base.material.SetFloat("OnStoryChoiceClick", this.colorIntensity);
		base.material.SetTexture("\"", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("spr", UnityEngine.Random.Range(162f, 1623f) * this.colorIntensity);
			base.material.SetVector("OnSkinShopCardSelected", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, -160) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 456f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1776f)
		{
			base.material.SetFloat(" (", 1840f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 954f * this.flipIntensity)
			{
				base.material.SetFloat("Game Title", UnityEngine.Random.Range(1013f, 876f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 163f);
			}
			this.NKCIHBJFFAK = 1094f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1768f;
		}
		if (this.flipIntensity == 295f)
		{
			base.material.SetFloat("syn", 1440f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 669f * this.flipIntensity)
			{
				base.material.SetFloat("asp", 249f - UnityEngine.Random.Range(1349f, 164f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 1700f);
			}
			this.OCCAALADPLM = 20f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 67f;
		}
		if (this.flipIntensity == 289f)
		{
			base.material.SetFloat("", 6f);
		}
		if ((double)UnityEngine.Random.value < 879.0 * (double)this.intensity)
		{
			base.material.SetFloat("-", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("", 1744f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("", 1967f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA2 RID: 31906 RVA: 0x00378DDC File Offset: 0x00376FDC
	private void NJAACLEIHEF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("sfxsparklesbundles", this.intensity);
		base.material.SetFloat("nastring", this.colorIntensity);
		base.material.SetTexture("SceneLobbyManager2.OnLiveProfileThumbnailsCdnSuccess(): resident=", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat(":", UnityEngine.Random.Range(1731f, 1251f) * this.colorIntensity);
			base.material.SetVector(">", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 61) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1072f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1546f)
		{
			base.material.SetFloat("stat1", 128f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1476f * this.flipIntensity)
			{
				base.material.SetFloat("", UnityEngine.Random.Range(662f, 1064f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("PurchaseManagerXiaomi.OnBackendValidateTransactionException().", 1481f);
			}
			this.NKCIHBJFFAK = 1774f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 717f;
		}
		if (this.flipIntensity == 12f)
		{
			base.material.SetFloat("envsind", 1961f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 922f * this.flipIntensity)
			{
				base.material.SetFloat("", 204f - UnityEngine.Random.Range(1622f, 1194f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("\n", 551f);
			}
			this.OCCAALADPLM = 536f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 918f;
		}
		if (this.flipIntensity == 1806f)
		{
			base.material.SetFloat("OnStoryCurrencyInfoClick", 1253f);
		}
		if ((double)UnityEngine.Random.value < 331.0 * (double)this.intensity)
		{
			base.material.SetFloat("ok", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("ssfree", 578f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("OffensiveWords", 1269f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA3 RID: 31907 RVA: 0x003790DC File Offset: 0x003772DC
	private void FOMGMPOJDEO(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("<", this.intensity);
		base.material.SetFloat("responseCode", this.colorIntensity);
		base.material.SetTexture("</i>", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat(") + is present, creating anthology save for anthology ", UnityEngine.Random.Range(1389f, 1133f) * this.colorIntensity);
			base.material.SetVector("OnBackendRequestSendMessageException", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 145) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 997f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 41f)
		{
			base.material.SetFloat("Environment ", 1369f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1480f * this.flipIntensity)
			{
				base.material.SetFloat("apb", UnityEngine.Random.Range(1515f, 1525f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("anpcs", 1664f);
			}
			this.NKCIHBJFFAK = 1595f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 813f;
		}
		if (this.flipIntensity == 1185f)
		{
			base.material.SetFloat("avatarcollectionssubrequired1", 786f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1118f * this.flipIntensity)
			{
				base.material.SetFloat("\n", 1220f - UnityEngine.Random.Range(336f, 1035f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat(" appears twice, keeping the first row", 1220f);
			}
			this.OCCAALADPLM = 1472f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1938f;
		}
		if (this.flipIntensity == 1258f)
		{
			base.material.SetFloat("story", 439f);
		}
		if ((double)UnityEngine.Random.value < 1766.0 * (double)this.intensity)
		{
			base.material.SetFloat("Loading Asset Bundle ", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("ok", 830f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("PurchaseManagerSteam.OnProductsFetched(): ", 747f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA5 RID: 31909 RVA: 0x00379408 File Offset: 0x00377608
	private void IEKKGMAIJMF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("0.##", this.intensity);
		base.material.SetFloat("<i>", this.colorIntensity);
		base.material.SetTexture("hist", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("hids", UnityEngine.Random.Range(1600f, 1638f) * this.colorIntensity);
			base.material.SetVector("OnNeedToShowNoMoreEnergyPopup", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, -50) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 593f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1285f)
		{
			base.material.SetFloat("PurchaseManagerSteam.InitiateTransactionSteam(). Condition not passed: initiatedPurchase is null. Aborting.", 990f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1886f * this.flipIntensity)
			{
				base.material.SetFloat("xx", UnityEngine.Random.Range(708f, 1178f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("varCondition", 995f);
			}
			this.NKCIHBJFFAK = 857f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 622f;
		}
		if (this.flipIntensity == 402f)
		{
			base.material.SetFloat("null", 749f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 698f * this.flipIntensity)
			{
				base.material.SetFloat("le", 1752f - UnityEngine.Random.Range(282f, 964f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("XXX", 996f);
			}
			this.OCCAALADPLM = 341f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1258f;
		}
		if (this.flipIntensity == 1498f)
		{
			base.material.SetFloat("pmterror005", 1583f);
		}
		if ((double)UnityEngine.Random.value < 587.0 * (double)this.intensity)
		{
			base.material.SetFloat("", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("wind", 1645f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("OnStoryInterfaceHeaderBackClick", 1297f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA6 RID: 31910 RVA: 0x00379708 File Offset: 0x00377908
	private void OMCPEPKHOLD(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("loungelockedinfo", this.intensity);
		base.material.SetFloat("importanttitle", this.colorIntensity);
		base.material.SetTexture("0.000", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("Video:", UnityEngine.Random.Range(1815f, 874f) * this.colorIntensity);
			base.material.SetVector("CharacterRenderTexturePool - band blur alpha shader missing from Resources: ShaderFastBlurAlphaClient", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, -166) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1477f)
		{
			base.material.SetFloat(" cards=", 1556f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 762f * this.flipIntensity)
			{
				base.material.SetFloat("purchasingBalance", UnityEngine.Random.Range(35f, 35f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("AdsManagerLP: Received RewardedVideoOnAdClosedEvent", 1666f);
			}
			this.NKCIHBJFFAK = 1624f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1753f;
		}
		if (this.flipIntensity == 49f)
		{
			base.material.SetFloat("signincancel", 145f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1500f * this.flipIntensity)
			{
				base.material.SetFloat("cardoptionsloadingthemesubonly", 717f - UnityEngine.Random.Range(1301f, 1398f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("PendingPurchase.GetReceipt(): Receipt is null or empty", 335f);
			}
			this.OCCAALADPLM = 1620f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 352f;
		}
		if (this.flipIntensity == 1061f)
		{
			base.material.SetFloat("/", 1268f);
		}
		if ((double)UnityEngine.Random.value < 1629.0 * (double)this.intensity)
		{
			base.material.SetFloat("abip", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("OnRewardFreePassPlayStore", 861f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("ratethankyou", 1873f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA7 RID: 31911 RVA: 0x00379A08 File Offset: 0x00377C08
	private void AFECFKJKIMH(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("pl", this.intensity);
		base.material.SetFloat("importanttitle", this.colorIntensity);
		base.material.SetTexture("YYY", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("sfxtimeoutwarning", UnityEngine.Random.Range(631f, 1598f) * this.colorIntensity);
			base.material.SetVector("", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 190) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 927f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1256f)
		{
			base.material.SetFloat("OnSketchThumbnailEmptyClick", 1445f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1132f * this.flipIntensity)
			{
				base.material.SetFloat("ok", UnityEngine.Random.Range(1781f, 1695f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("SceneLobbyManager2.OnLiveProfileThemesLoaderStop(): aborting the in-flight live profile themes ", 1872f);
			}
			this.NKCIHBJFFAK = 1398f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 794f;
		}
		if (this.flipIntensity == 810f)
		{
			base.material.SetFloat("af_content_id", 1046f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1028f * this.flipIntensity)
			{
				base.material.SetFloat(" could not be loaded", 823f - UnityEngine.Random.Range(1958f, 1189f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 934f);
			}
			this.OCCAALADPLM = 128f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1719f;
		}
		if (this.flipIntensity == 68f)
		{
			base.material.SetFloat("XXX", 548f);
		}
		if ((double)UnityEngine.Random.value < 405.0 * (double)this.intensity)
		{
			base.material.SetFloat("pmterror010", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("Account.DuplicateAnthologySaveSlot(), a story save could not be copied, the target slot was cleared, anthology:", 825f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("XXX", 813f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA8 RID: 31912 RVA: 0x00379D08 File Offset: 0x00377F08
	private void HOAOKHKNCHI(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("", this.intensity);
		base.material.SetFloat(" already being downloaded, skip request but remember reference to it.", this.colorIntensity);
		base.material.SetTexture("OnFacebookLoginCanceled", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("onPopupCardOptionsCloseClick", UnityEngine.Random.Range(1673f, 1942f) * this.colorIntensity);
			base.material.SetVector("", Quaternion.AngleAxis((float)UnityEngine.Random.Range(1, 142) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 151f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1421f)
		{
			base.material.SetFloat("WWW", 775f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1792f * this.flipIntensity)
			{
				base.material.SetFloat("OnStoryInterfaceFastForwardActivate", UnityEngine.Random.Range(1238f, 935f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("ok", 454f);
			}
			this.NKCIHBJFFAK = 1252f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1720f;
		}
		if (this.flipIntensity == 1522f)
		{
			base.material.SetFloat("Asset bundle assets destroyed:", 1961f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 314f * this.flipIntensity)
			{
				base.material.SetFloat("\\\"", 764f - UnityEngine.Random.Range(597f, 289f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat(" ", 1712f);
			}
			this.OCCAALADPLM = 335f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1667f;
		}
		if (this.flipIntensity == 689f)
		{
			base.material.SetFloat("OnSketchThumbnailPublish", 1089f);
		}
		if ((double)UnityEngine.Random.value < 1396.0 * (double)this.intensity)
		{
			base.material.SetFloat("OnBackendGetPublicProfileProfileItemException", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("OnAvatarCollectionEdit", 1882f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("NonPlayerCharacterManager.SetEmotion() - npcAsset is null.", 280f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CA9 RID: 31913 RVA: 0x0037A008 File Offset: 0x00378208
	private void LPOODHHOEIF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("OnLoungePremiumChoicesHistoryException", this.intensity);
		base.material.SetFloat("Vol", this.colorIntensity);
		base.material.SetTexture("tmop", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("-", UnityEngine.Random.Range(1448f, 789f) * this.colorIntensity);
			base.material.SetVector("areyousurerestartchapter1", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 87) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1963f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 1322f)
		{
			base.material.SetFloat("OnAccountSave", 104f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 813f * this.flipIntensity)
			{
				base.material.SetFloat(" held bundles", UnityEngine.Random.Range(818f, 985f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("OnPopupOfferManagerContinueToPurchasingScreen", 1525f);
			}
			this.NKCIHBJFFAK = 464f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 96f;
		}
		if (this.flipIntensity == 796f)
		{
			base.material.SetFloat("\n", 1483f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 1170f * this.flipIntensity)
			{
				base.material.SetFloat("OnFriendsGiftPopulCollectPart2", 405f - UnityEngine.Random.Range(1929f, 480f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 897f);
			}
			this.OCCAALADPLM = 1811f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 1591f;
		}
		if (this.flipIntensity == 1851f)
		{
			base.material.SetFloat("eval", 1848f);
		}
		if ((double)UnityEngine.Random.value < 249.0 * (double)this.intensity)
		{
			base.material.SetFloat("smps", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()", 1258f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("OnRewardsItemClose", 926f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x06007CAA RID: 31914 RVA: 0x0037A308 File Offset: 0x00378508
	private void BNOBBMCJDNH(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
	{
		base.material.SetFloat("fubs", this.intensity);
		base.material.SetFloat("OnGooglePlayServicesLoginFailed", this.colorIntensity);
		base.material.SetTexture("sscsp", this.displacementMap);
		this.LLAEKHNLBBI += Time.deltaTime * this.colorIntensity;
		if (this.LLAEKHNLBBI > this.JDNKFIJALLB)
		{
			base.material.SetFloat("skuAuto", UnityEngine.Random.Range(208f, 597f) * this.colorIntensity);
			base.material.SetVector("snapundo", Quaternion.AngleAxis((float)UnityEngine.Random.Range(0, 62) * this.colorIntensity, Vector3.forward) * Vector4.one);
			this.LLAEKHNLBBI = 1432f;
			this.JDNKFIJALLB = UnityEngine.Random.value;
		}
		if (this.colorIntensity == 876f)
		{
			base.material.SetFloat("BackendOperationsManager.RequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:", 69f);
		}
		this.NKCIHBJFFAK += Time.deltaTime * this.flipIntensity;
		if (this.NKCIHBJFFAK > this.LGALMGAPKMP)
		{
			if (UnityEngine.Random.value < 1619f * this.flipIntensity)
			{
				base.material.SetFloat("af_currency", UnityEngine.Random.Range(1011f, 1249f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat("", 1643f);
			}
			this.NKCIHBJFFAK = 964f;
			this.LGALMGAPKMP = UnityEngine.Random.value / 1708f;
		}
		if (this.flipIntensity == 36f)
		{
			base.material.SetFloat("per", 710f);
		}
		this.OCCAALADPLM += Time.deltaTime * this.flipIntensity;
		if (this.OCCAALADPLM > this.BKGDPGFIGMF)
		{
			if (UnityEngine.Random.value < 368f * this.flipIntensity)
			{
				base.material.SetFloat("-", 883f - UnityEngine.Random.Range(1020f, 324f) * this.flipIntensity);
			}
			else
			{
				base.material.SetFloat(" \",", 1813f);
			}
			this.OCCAALADPLM = 872f;
			this.BKGDPGFIGMF = UnityEngine.Random.value / 973f;
		}
		if (this.flipIntensity == 381f)
		{
			base.material.SetFloat("https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/", 1791f);
		}
		if ((double)UnityEngine.Random.value < 280.0 * (double)this.intensity)
		{
			base.material.SetFloat(") assettitle(", UnityEngine.Random.value * this.intensity);
			base.material.SetFloat("OnApplicationFocusNeedToUpdateCurrency", 979f - UnityEngine.Random.value * this.intensity);
		}
		else
		{
			base.material.SetFloat("AvatarCollectionsItem.OnAvatarCollectionDelete(): index out of range", 438f);
		}
		Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, base.material);
	}

	// Token: 0x040023F5 RID: 9205
	public Texture2D displacementMap;

	// Token: 0x040023F6 RID: 9206
	private float NKCIHBJFFAK;

	// Token: 0x040023F7 RID: 9207
	private float OCCAALADPLM;

	// Token: 0x040023F8 RID: 9208
	private float LLAEKHNLBBI;

	// Token: 0x040023F9 RID: 9209
	private float LGALMGAPKMP = 0.05f;

	// Token: 0x040023FA RID: 9210
	private float BKGDPGFIGMF = 0.05f;

	// Token: 0x040023FB RID: 9211
	private float JDNKFIJALLB = 0.5f;

	// Token: 0x040023FC RID: 9212
	[Range(0f, 1f)]
	[Header("Glitch Intensity")]
	public float intensity;

	// Token: 0x040023FD RID: 9213
	[Range(0f, 1f)]
	public float flipIntensity;

	// Token: 0x040023FE RID: 9214
	[Range(0f, 1f)]
	public float colorIntensity;
}
