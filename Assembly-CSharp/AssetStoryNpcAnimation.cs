using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000120 RID: 288
[CreateAssetMenu(fileName = "assetNpcAnimationPackX", menuName = "ROMANCE/Create assetNpcAnimationPackX", order = 1)]
public class AssetStoryNpcAnimation : ScriptableObject
{
	// Token: 0x06002601 RID: 9729 RVA: 0x00114260 File Offset: 0x00112460
	public AssetStoryNpcAnimationPropDesc NJAMGHDMCPI(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x001142FE File Offset: 0x001124FE
	public bool BOOLEIGIFDG(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.CJHKBHDCKHO() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x00114320 File Offset: 0x00112520
	public bool DEFHEJHJKJF(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.IGLJHJMEKKF() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x00114344 File Offset: 0x00112544
	public void FPJEAGHCNKA()
	{
		if (this.npcId != null && this.npcId.Contains("abpp"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("Asset bundle load operation failed during parallel mode."));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("OnLoungePremiumChoicesHistoryException"))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf("OnRestorePurchasesZeroResult"));
		}
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x001143C9 File Offset: 0x001125C9
	public bool EFAPKLEFNND()
	{
		return this.bodyFrames == null || this.bodyFrames.Count <= 1 || true;
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x001143E4 File Offset: 0x001125E4
	public void HBGENHLPEIL()
	{
		if (this.npcId != null && this.npcId.Contains("body"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("importanttitle"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("lowendversion"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("mystoriespattern"));
		}
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x00114469 File Offset: 0x00112669
	public bool LFMBIEKKHLE(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.AIJDBPCBMLP() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x001142FE File Offset: 0x001124FE
	public bool FBJCCFJEBHO(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.CJHKBHDCKHO() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x0011448C File Offset: 0x0011268C
	public void DCLGCJEMHDK()
	{
		if (this.npcId != null && this.npcId.Contains("$"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("Shaders/VideoGlitchRGBDisplay"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("LLL"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf(" "));
		}
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x00114514 File Offset: 0x00112714
	public AssetStoryNpcAnimationEmotionDesc IKFPNBGDBHJ(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 1; i < this.emotions.Count; i++)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 0)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x00114469 File Offset: 0x00112669
	public bool GOJJEMOBNFC(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.AIJDBPCBMLP() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x0011458F File Offset: 0x0011278F
	public bool GHPDNHIPHIK()
	{
		return this.bodyFrames == null || this.bodyFrames.Count <= 0;
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x001145AC File Offset: 0x001127AC
	public void IKFHBLPAGIP()
	{
		if (this.npcId != null && this.npcId.Contains(""))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("ok"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(" "))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("liveeventstitles"));
		}
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x00114634 File Offset: 0x00112834
	public AssetStoryNpcAnimationEmotionDesc FADPOKPJMJC(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 1; i < this.emotions.Count; i += 0)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 0)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x001146AF File Offset: 0x001128AF
	public bool IGLJHJMEKKF()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 0;
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x001146CC File Offset: 0x001128CC
	public AssetStoryNpcAnimationPropDesc ENLGBCIDOMO(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x0011476C File Offset: 0x0011296C
	public AssetStoryNpcAnimationPropDesc EODDDMHOFLD(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x0011480C File Offset: 0x00112A0C
	public void PGFEFJDBIME()
	{
		if (this.npcId != null && this.npcId.Contains(" "))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf(" "));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(" "))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf(" "));
		}
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x00114894 File Offset: 0x00112A94
	public AssetStoryNpcAnimationPropDesc DBCHMGNCAOJ(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x00114934 File Offset: 0x00112B34
	public void FMBAJJBEDAA()
	{
		if (this.npcId != null && this.npcId.Contains("lsenvattempt"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("mpi"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(""))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf("uid"));
		}
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x001149BC File Offset: 0x00112BBC
	public AssetStoryNpcAnimationPropDesc JDAKMFAIJGE(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x00114A5C File Offset: 0x00112C5C
	public void NCBEDLGHDJP()
	{
		if (this.npcId != null && this.npcId.Contains("newtutorialgifts"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("smpd"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("OnStoryInterfaceHeaderRewindClick"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("tdgcds"));
		}
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x001146AF File Offset: 0x001128AF
	public bool ELLKFBKGCDD()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 0;
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x00114AE1 File Offset: 0x00112CE1
	public bool AIJDBPCBMLP()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 0 && false;
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x00114AFC File Offset: 0x00112CFC
	public bool OPBBMCJENAM()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 1;
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x00114B18 File Offset: 0x00112D18
	public void DOOCPADPLHE()
	{
		if (this.npcId != null && this.npcId.Contains(", sku:'"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("OnApplicationFocusBasicSyncSuccess"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("chsnap2"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("idmr"));
		}
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x00114BA0 File Offset: 0x00112DA0
	public void CMAKGOODMGJ()
	{
		if (this.npcId != null && this.npcId.Contains("inu"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("epi"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf(""));
		}
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x00114C28 File Offset: 0x00112E28
	public AssetStoryNpcAnimationPropDesc JOPCLFADPHN(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x00114CC6 File Offset: 0x00112EC6
	public bool CJHKBHDCKHO()
	{
		return this.bodyFrames == null || this.bodyFrames.Count <= 1;
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x00114CE4 File Offset: 0x00112EE4
	public AssetStoryNpcAnimationPropDesc MICJIJDNBPH(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x00114D84 File Offset: 0x00112F84
	public AssetStoryNpcAnimationPropDesc EMJJIMMLAED(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x00114E24 File Offset: 0x00113024
	public AssetStoryNpcAnimationPropDesc AMDKIMOKDMG(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x00114EC4 File Offset: 0x001130C4
	public void MFIGLMBOBHC()
	{
		if (this.npcId != null && this.npcId.Contains("ActivateSystemBackButtonManager"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf(""));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(""))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("sparkles"));
		}
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x00114F4C File Offset: 0x0011314C
	public AssetStoryNpcAnimationPropDesc FKIEMACEONL(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x00114FEA File Offset: 0x001131EA
	public bool LBKIMJDKNCI(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.ELLKFBKGCDD() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x0011500C File Offset: 0x0011320C
	public bool DOHJLGDLALN(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.IGLJHJMEKKF() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x001143C9 File Offset: 0x001125C9
	public bool CPAIKJEFBHN()
	{
		return this.bodyFrames == null || this.bodyFrames.Count <= 1 || true;
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x00115030 File Offset: 0x00113230
	public void BINIGJLMHAG()
	{
		if (this.npcId != null && this.npcId.Contains("shadowflag"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("%"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(""))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("OnFacebookLoginSuccess"));
		}
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x001150B5 File Offset: 0x001132B5
	public bool AOCHAEMOFHF(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.GKCAEKLKFLG() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x001150D8 File Offset: 0x001132D8
	public AssetStoryNpcAnimationPropDesc LIHKEGFCMHE(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x00115176 File Offset: 0x00113376
	public bool CLDCEFKBHCH(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.PAGDABAMFPN() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x00115198 File Offset: 0x00113398
	public AssetStoryNpcAnimationPropDesc MPGPHLGNEDM(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x00115176 File Offset: 0x00113376
	public bool CEDJBDLFNFG(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.PAGDABAMFPN() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x00115238 File Offset: 0x00113438
	public AssetStoryNpcAnimationEmotionDesc KDLNDBMNBGJ(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 0; i < this.emotions.Count; i++)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 0)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x001152B4 File Offset: 0x001134B4
	public void EIEGCDELJKL()
	{
		if (this.npcId != null && this.npcId.Contains("OnPopupCardOptionsUnlockWithSpSuccessContinue"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("energyhinttitle"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("errortitle"))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf("OnLoungePremiumChoiceExecutedHardBased"));
		}
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x0011533C File Offset: 0x0011353C
	public AssetStoryNpcAnimationPropDesc HAFONHNDNIF(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x001153DA File Offset: 0x001135DA
	public bool CIOPFDILOPP(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.EFAPKLEFNND() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x001153FC File Offset: 0x001135FC
	public void IGDPBGKEHII()
	{
		if (this.npcId != null && this.npcId.Contains("string_not_found"))
		{
			this.npcId = this.npcId.Substring(1, this.npcId.IndexOf("CameraBundlesVFXTopMost"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("gamepassdurationtitle"))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf("OnBackendGetDropChancesException"));
		}
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x00115484 File Offset: 0x00113684
	public void BEBFILEHCCE()
	{
		if (this.npcId != null && this.npcId.Contains("id"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("[ "));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("varConditionValue"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("OnAvatarCollectionRestoreEntry"));
		}
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x0011550C File Offset: 0x0011370C
	public AssetStoryNpcAnimationEmotionDesc MKALCAMHPEB(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 1; i < this.emotions.Count; i++)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 1)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x00114AFC File Offset: 0x00112CFC
	public bool HIFMJCMGDCL()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 1;
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x001155C4 File Offset: 0x001137C4
	public void FMDFIDJKNKM()
	{
		if (this.npcId != null && this.npcId.Contains("gftcds"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("XXX"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("timerIsHidden"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("OnGetCdnDataBeforeOnDemandSuccess"));
		}
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x00115649 File Offset: 0x00113849
	public bool ACICDEDPLCB(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.AIJDBPCBMLP() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x0011566C File Offset: 0x0011386C
	public void OHEDNECDNDB()
	{
		if (this.npcId != null && this.npcId.Contains("Error. ZoomDst(), environment "))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("ChoiceExtendedManager - no shop button sprite (scene or ChoicePremium prefab), premium art kept"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("popupcardoptionscollectedcopyinfo"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("docid"));
		}
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x00114AE1 File Offset: 0x00112CE1
	public bool GKCAEKLKFLG()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 0 && false;
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x001156F4 File Offset: 0x001138F4
	public AssetStoryNpcAnimationEmotionDesc BPHKBMFHMPN(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 0; i < this.emotions.Count; i++)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 0)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x00115770 File Offset: 0x00113970
	public AssetStoryNpcAnimationPropDesc IFIKDJHLBLE(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x00115810 File Offset: 0x00113A10
	public void OOAFFHCOAEL()
	{
		if (this.npcId != null && this.npcId.Contains(""))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf(""));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("uid"))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf(""));
		}
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x00115895 File Offset: 0x00113A95
	public bool KGADINEIDMD()
	{
		return this.bodyFrames != null && this.bodyFrames.Count > 1 && false;
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x00114CC6 File Offset: 0x00112EC6
	public bool PAGDABAMFPN()
	{
		return this.bodyFrames == null || this.bodyFrames.Count <= 1;
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x001158B0 File Offset: 0x00113AB0
	public AssetStoryNpcAnimationPropDesc CPIIEFLMLLL(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x0011594E File Offset: 0x00113B4E
	public bool DJDOADNFCIA(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.GKCAEKLKFLG() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x00115970 File Offset: 0x00113B70
	public AssetStoryNpcAnimationPropDesc OCDEPOBGBNI(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x00114FEA File Offset: 0x001131EA
	public bool JMIPEAMMHKI(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.ELLKFBKGCDD() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x00115A10 File Offset: 0x00113C10
	public AssetStoryNpcAnimationEmotionDesc DMECLMJAKMI(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 0; i < this.emotions.Count; i += 0)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 1)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x00115A8C File Offset: 0x00113C8C
	public AssetStoryNpcAnimationPropDesc BEPGNKMPLIL(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x00115B2C File Offset: 0x00113D2C
	public AssetStoryNpcAnimationEmotionDesc DKKNHDJFGEC(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 0; i < this.emotions.Count; i += 0)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 1)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x0011594E File Offset: 0x00113B4E
	public bool ODDOGCABAOJ(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.GKCAEKLKFLG() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x00115BA7 File Offset: 0x00113DA7
	public bool BGNGFPOJFEO(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.HIFMJCMGDCL() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x00115BCC File Offset: 0x00113DCC
	public void PNFNHINDFND()
	{
		if (this.npcId != null && this.npcId.Contains("OnNeedToShowNoMoreHardPopup"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf(", index:"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(""))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf("abs"));
		}
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x00115C54 File Offset: 0x00113E54
	public void IPJMGBEMPOA()
	{
		if (this.npcId != null && this.npcId.Contains("OnSketchThumbnailEmptyClick"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("per"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains(""))
		{
			this.npcProperty = this.npcProperty.Substring(1, this.npcProperty.IndexOf("0"));
		}
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x00115CDC File Offset: 0x00113EDC
	public void OAKLONCJIEB()
	{
		if (this.npcId != null && this.npcId.Contains("friendsmaxlimitdefaultfp"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("SocialStatsUserPublicProfile.modified = true, SyncCutscenes()"));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("eml"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("importanttitle"));
		}
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x001142FE File Offset: 0x001124FE
	public bool IEPEAFAGIKJ(int JHIPOFCNIBA)
	{
		return this.frameSyncEnabled && this.CJHKBHDCKHO() && JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x00115D64 File Offset: 0x00113F64
	public void HIHEICCNEBE()
	{
		if (this.npcId != null && this.npcId.Contains("vhspauseovr_1"))
		{
			this.npcId = this.npcId.Substring(0, this.npcId.IndexOf("Cdn host asset {0} is a {1} host. It must reference a {2} one."));
		}
		if (this.npcProperty != null && this.npcProperty.Contains("areyousure"))
		{
			this.npcProperty = this.npcProperty.Substring(0, this.npcProperty.IndexOf("=== RU FIREWALL === geo endpoint "));
		}
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x00115DEC File Offset: 0x00113FEC
	public AssetStoryNpcAnimationPropDesc DFHNNLHHEIJ(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 1)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x0011500C File Offset: 0x0011320C
	public bool EOKLEKLABFC(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.IGLJHJMEKKF() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x00115E8C File Offset: 0x0011408C
	public AssetStoryNpcAnimationEmotionDesc PGDHNLCNPIF(FLNOFHCNJDM PBKAAIONJOB)
	{
		if (this.emotions == null)
		{
			return null;
		}
		for (int i = 1; i < this.emotions.Count; i++)
		{
			if (this.emotions[i].type == PBKAAIONJOB && this.emotions[i].frames != null && this.emotions[i].frames.Count > 1)
			{
				return this.emotions[i];
			}
		}
		return null;
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x0011594E File Offset: 0x00113B4E
	public bool LHEFKIOLDGA(int JHIPOFCNIBA)
	{
		return !this.frameSyncEnabled || !this.GKCAEKLKFLG() || JHIPOFCNIBA == this.bodyFrames.Count;
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x00115F08 File Offset: 0x00114108
	public AssetStoryNpcAnimationPropDesc EEFPNDPJELD(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < this.props.Count; i += 0)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x00115FA8 File Offset: 0x001141A8
	public AssetStoryNpcAnimationPropDesc IMJGIMOGNKK(string GGPDDIECHHA)
	{
		if (this.props == null || GGPDDIECHHA == null || GGPDDIECHHA.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < this.props.Count; i++)
		{
			if (this.props[i].property != null && this.props[i].property.Equals(GGPDDIECHHA) && this.props[i].frames != null && this.props[i].frames.Count > 0)
			{
				return this.props[i];
			}
		}
		return null;
	}

	// Token: 0x04000BE6 RID: 3046
	public int index;

	// Token: 0x04000BE7 RID: 3047
	public string npcId;

	// Token: 0x04000BE8 RID: 3048
	public string npcProperty = "";

	// Token: 0x04000BE9 RID: 3049
	public List<Sprite> bodyFrames;

	// Token: 0x04000BEA RID: 3050
	public int bodyFramesOffsetX;

	// Token: 0x04000BEB RID: 3051
	public int bodyFramesOffsetY;

	// Token: 0x04000BEC RID: 3052
	public float bodyFrameChangeInterval = 0.1f;

	// Token: 0x04000BED RID: 3053
	public bool bodyFramesReplaceBody;

	// Token: 0x04000BEE RID: 3054
	public bool frameSyncEnabled = true;

	// Token: 0x04000BEF RID: 3055
	public bool fallbackToAnimatedNeutralOrNothing;

	// Token: 0x04000BF0 RID: 3056
	public float emotionFrameChangeInterval = 0.1f;

	// Token: 0x04000BF1 RID: 3057
	public List<AssetStoryNpcAnimationEmotionDesc> emotions;

	// Token: 0x04000BF2 RID: 3058
	public float propFrameChangeInterval = 0.1f;

	// Token: 0x04000BF3 RID: 3059
	public List<AssetStoryNpcAnimationPropDesc> props;
}
