using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004EA RID: 1258
public class SceneStoryAssetPackManager : MonoBehaviour
{
	// Token: 0x06009823 RID: 38947 RVA: 0x00425EB0 File Offset: 0x004240B0
	public void PMDEDKJMMBD(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].DAKJOPEHHCL(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].EAOFLCLKDOA(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009824 RID: 38948 RVA: 0x00425F60 File Offset: 0x00424160
	public void JLNPHPOHHFH(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009825 RID: 38949 RVA: 0x00425FC0 File Offset: 0x004241C0
	public void JCAEAPPFBBJ(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].GJFJBHNHELO(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009826 RID: 38950 RVA: 0x00426070 File Offset: 0x00424270
	public void LIKDEILMJBH(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009827 RID: 38951 RVA: 0x004260D0 File Offset: 0x004242D0
	public void NAHBABOMBIO(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].NNIBHMPJDHP(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].AONNOIPGDNC(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009828 RID: 38952 RVA: 0x00426180 File Offset: 0x00424380
	public void LDBDLIMJGHN(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009829 RID: 38953 RVA: 0x004261E0 File Offset: 0x004243E0
	public void MEDOPFEBBGC(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].OEDIABKJCFE(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].EAOFLCLKDOA(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600982A RID: 38954 RVA: 0x00426290 File Offset: 0x00424490
	public void CNOLAKCKPJC(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600982B RID: 38955 RVA: 0x004262F0 File Offset: 0x004244F0
	public void IOCKHACBAMB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600982C RID: 38956 RVA: 0x00426350 File Offset: 0x00424550
	public void OCDKFFDNIED(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].GHBPANFHFFL(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].LALPGAGDOMN(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600982D RID: 38957 RVA: 0x00426400 File Offset: 0x00424600
	private void JBCKGINANGF()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].INJJECBFANC();
		}
	}

	// Token: 0x0600982E RID: 38958 RVA: 0x00426434 File Offset: 0x00424634
	private void FDFMDEOMJBH()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].JPBEEKEAIJN();
		}
	}

	// Token: 0x0600982F RID: 38959 RVA: 0x00426468 File Offset: 0x00424668
	public void JCKHJCAKHOD(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009830 RID: 38960 RVA: 0x004264C8 File Offset: 0x004246C8
	private void NGCHDKEEPOG()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].OACGHBLJLAD();
		}
	}

	// Token: 0x06009831 RID: 38961 RVA: 0x004264FC File Offset: 0x004246FC
	public void JLCKANGMNMJ(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009832 RID: 38962 RVA: 0x0042655C File Offset: 0x0042475C
	public void MMGGCGDOIJG(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].OEDIABKJCFE(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].LALPGAGDOMN(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009833 RID: 38963 RVA: 0x0042660C File Offset: 0x0042480C
	private void BLEFIJPAJMJ()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].JPBEEKEAIJN();
		}
	}

	// Token: 0x06009834 RID: 38964 RVA: 0x00426640 File Offset: 0x00424840
	public void NJMMOIJCNID(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009835 RID: 38965 RVA: 0x004266A0 File Offset: 0x004248A0
	private void LLDCFHGMAML()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].COFJBFIOELE();
		}
	}

	// Token: 0x06009836 RID: 38966 RVA: 0x004266D4 File Offset: 0x004248D4
	public void CAHBMINNGEC(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].ENLLIFAEFIM(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009837 RID: 38967 RVA: 0x00426784 File Offset: 0x00424984
	private void EAKEDEEHEDD()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].CMAKGOODMGJ();
		}
	}

	// Token: 0x06009838 RID: 38968 RVA: 0x004267B8 File Offset: 0x004249B8
	private void PIBDCOBGMKC()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].OJBKCOHDHGO();
		}
	}

	// Token: 0x06009839 RID: 38969 RVA: 0x004267EC File Offset: 0x004249EC
	private void KGMBFKBNDPJ()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].FPMOMEMKMHB();
		}
	}

	// Token: 0x0600983A RID: 38970 RVA: 0x00426820 File Offset: 0x00424A20
	private void FEIFMJKGGBO()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].JPBEEKEAIJN();
		}
	}

	// Token: 0x0600983B RID: 38971 RVA: 0x00426854 File Offset: 0x00424A54
	public void JGHCHOBMMBL(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600983D RID: 38973 RVA: 0x004268D4 File Offset: 0x00424AD4
	public void SetOnDemandResourcesCheckpointIndex(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].GFFPDIBOIIK(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600983E RID: 38974 RVA: 0x00426984 File Offset: 0x00424B84
	public void MKJPICOHPPM(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].KGNHEEGIDOE(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].PIBKKEMMCBL(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600983F RID: 38975 RVA: 0x00426A34 File Offset: 0x00424C34
	private void AMLICNPKJNO()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].PGFEFJDBIME();
		}
	}

	// Token: 0x06009840 RID: 38976 RVA: 0x00426A68 File Offset: 0x00424C68
	private void JLHGINADNCA()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].ANIFLCAPHJB();
		}
	}

	// Token: 0x06009841 RID: 38977 RVA: 0x00426A9C File Offset: 0x00424C9C
	public void NCPFAGPDOJA(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].DAKJOPEHHCL(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009842 RID: 38978 RVA: 0x00426B4C File Offset: 0x00424D4C
	private void HBLDAPMPKAB()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].ANIFLCAPHJB();
		}
	}

	// Token: 0x06009843 RID: 38979 RVA: 0x00426B80 File Offset: 0x00424D80
	public void BJCEDINPLGI(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009844 RID: 38980 RVA: 0x00426BE0 File Offset: 0x00424DE0
	private void JFEKHEIGPJD()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].PGNFCDMJIGN();
		}
	}

	// Token: 0x06009845 RID: 38981 RVA: 0x00426C14 File Offset: 0x00424E14
	public void PMALOCMFDIG(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].KAJMCHKLDOH(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].AONNOIPGDNC(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009846 RID: 38982 RVA: 0x00426CC4 File Offset: 0x00424EC4
	public void BHOFEMOFKEM(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].JDDJBIEPACG(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009847 RID: 38983 RVA: 0x00426D74 File Offset: 0x00424F74
	public void ALJDDHGPLFB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009848 RID: 38984 RVA: 0x00426DD4 File Offset: 0x00424FD4
	public void OJNAHHOEIEN(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].EBHIMAOIAJE(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009849 RID: 38985 RVA: 0x00426E84 File Offset: 0x00425084
	public void NNILLEHDEDA(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600984A RID: 38986 RVA: 0x00426EE4 File Offset: 0x004250E4
	private void CPDNJAKBOBC()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].HGNBDIGDFDP();
		}
	}

	// Token: 0x0600984B RID: 38987 RVA: 0x00426F18 File Offset: 0x00425118
	public void GJFJBHNHELO(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].JJLJHAMGIOP(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].KGNHEEGIDOE(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600984C RID: 38988 RVA: 0x00426FC8 File Offset: 0x004251C8
	public void JDDJBIEPACG(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].PMALOCMFDIG(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600984D RID: 38989 RVA: 0x00427078 File Offset: 0x00425278
	public void LLLEKAJEEPC(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].AOLFBDHBINF(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].LALPGAGDOMN(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600984E RID: 38990 RVA: 0x00427128 File Offset: 0x00425328
	public void PJMDJIJHPPF(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600984F RID: 38991 RVA: 0x00427188 File Offset: 0x00425388
	public void OACBCEKKHLB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009850 RID: 38992 RVA: 0x004271E8 File Offset: 0x004253E8
	public void LMMINKOLMDA(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].EDBGHPOBCHI(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].KGNHEEGIDOE(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009851 RID: 38993 RVA: 0x00427298 File Offset: 0x00425498
	public void PFEEGBMABBD(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].JJLJHAMGIOP(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009852 RID: 38994 RVA: 0x00427348 File Offset: 0x00425548
	public void NNIBHMPJDHP(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].EAOFLCLKDOA(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].PIBKKEMMCBL(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009853 RID: 38995 RVA: 0x004273F8 File Offset: 0x004255F8
	public void IHGEGLMJBLB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009854 RID: 38996 RVA: 0x00427458 File Offset: 0x00425658
	public void PAGEEAPEOAM(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009855 RID: 38997 RVA: 0x004274B8 File Offset: 0x004256B8
	public void GPBHICPHIIG(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009856 RID: 38998 RVA: 0x00427518 File Offset: 0x00425718
	private void NDKAFCKLNBL()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].IKFHBLPAGIP();
		}
	}

	// Token: 0x06009857 RID: 38999 RVA: 0x0042754C File Offset: 0x0042574C
	private void HFCMCNBJPEE()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].COFJBFIOELE();
		}
	}

	// Token: 0x06009858 RID: 39000 RVA: 0x00427580 File Offset: 0x00425780
	public void BBCDJIFPDIJ(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].ENLLIFAEFIM(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].LALPGAGDOMN(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009859 RID: 39001 RVA: 0x00427630 File Offset: 0x00425830
	public void IOJICEFLNNM(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].GFFPDIBOIIK(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].PIBKKEMMCBL(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600985A RID: 39002 RVA: 0x004276E0 File Offset: 0x004258E0
	public void EAKCIKBNPLO(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600985B RID: 39003 RVA: 0x00427740 File Offset: 0x00425940
	private void FDOPMEKNMEA()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].HBGENHLPEIL();
		}
	}

	// Token: 0x0600985C RID: 39004 RVA: 0x00427774 File Offset: 0x00425974
	private void OHPNGFAIGEM()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].HGNBDIGDFDP();
		}
	}

	// Token: 0x0600985D RID: 39005 RVA: 0x004277A8 File Offset: 0x004259A8
	private void GANNEJBHDIM()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].FPJEAGHCNKA();
		}
	}

	// Token: 0x0600985E RID: 39006 RVA: 0x004277DC File Offset: 0x004259DC
	public void SaveSceneAndAssetBundleName(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600985F RID: 39007 RVA: 0x0042783C File Offset: 0x00425A3C
	public void OLOIGBDIBOB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009860 RID: 39008 RVA: 0x0042789C File Offset: 0x00425A9C
	public void KIFGCMEJOAI(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009861 RID: 39009 RVA: 0x004278FC File Offset: 0x00425AFC
	public void JBHJPFJMOPB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i += 0)
		{
			this.environmentsBackList[i].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009862 RID: 39010 RVA: 0x0042795C File Offset: 0x00425B5C
	private void PKPANMAFAIL()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].PGNFCDMJIGN();
		}
	}

	// Token: 0x06009863 RID: 39011 RVA: 0x00427990 File Offset: 0x00425B90
	public void JHEKBPJICHK(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].KAJMCHKLDOH(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].LALPGAGDOMN(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009864 RID: 39012 RVA: 0x00427A40 File Offset: 0x00425C40
	public void BGOKOJOBPHJ(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].EKAIANEDPAN(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].BGOKOJOBPHJ(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009865 RID: 39013 RVA: 0x00427AF0 File Offset: 0x00425CF0
	public void BJHLCIELBLH(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x06009866 RID: 39014 RVA: 0x00427B50 File Offset: 0x00425D50
	private void EIHOIEGKJLA()
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].GJAFCNJLBNN();
		}
	}

	// Token: 0x06009867 RID: 39015 RVA: 0x00427B84 File Offset: 0x00425D84
	private void Start()
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].PGFEFJDBIME();
		}
	}

	// Token: 0x06009868 RID: 39016 RVA: 0x00427BB8 File Offset: 0x00425DB8
	public void HJJODJIEMCP(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].PMALOCMFDIG(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].KCBBNCNEJLJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].KGNHEEGIDOE(MEFKFOHCOHK);
		}
	}

	// Token: 0x06009869 RID: 39017 RVA: 0x00427C68 File Offset: 0x00425E68
	public void MKHMGIHDAID(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 1; j < this.environmentsFrontList.Count; j += 0)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600986A RID: 39018 RVA: 0x00427CC8 File Offset: 0x00425EC8
	public void JBGMFFIHNPD(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i += 0)
		{
			this.storyNpcAssets[i].DDMKPOHMDLE(MEFKFOHCOHK);
		}
		for (int j = 0; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int l = 0; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].PIBKKEMMCBL(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600986B RID: 39019 RVA: 0x00427D78 File Offset: 0x00425F78
	public void NHMNPDNLMOH(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 1; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600986C RID: 39020 RVA: 0x00427DD8 File Offset: 0x00425FD8
	public void BEJHPHJKEOG(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		for (int i = 0; i < this.environmentsBackList.Count; i++)
		{
			this.environmentsBackList[i].IHGEGLMJBLB(LBGGLHDOICL, HCNAPDGGCDO);
		}
		for (int j = 0; j < this.environmentsFrontList.Count; j++)
		{
			this.environmentsFrontList[j].SaveSceneAndAssetBundleName(LBGGLHDOICL, HCNAPDGGCDO);
		}
	}

	// Token: 0x0600986D RID: 39021 RVA: 0x00427E38 File Offset: 0x00426038
	public void DLEDCDPCHAL(int MEFKFOHCOHK)
	{
		for (int i = 0; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].OGJAAECFENB(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j += 0)
		{
			this.environmentsBackList[j].OBAJDKJOIJC(MEFKFOHCOHK);
		}
		for (int k = 0; k < this.environmentsFrontList.Count; k++)
		{
			this.environmentsFrontList[k].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l++)
		{
			this.environmentsLayersList[l].PIBKKEMMCBL(MEFKFOHCOHK);
		}
	}

	// Token: 0x0600986E RID: 39022 RVA: 0x00427EE8 File Offset: 0x004260E8
	public void IOHGNLKDHCD(int MEFKFOHCOHK)
	{
		for (int i = 1; i < this.storyNpcAssets.Count; i++)
		{
			this.storyNpcAssets[i].PFEEGBMABBD(MEFKFOHCOHK);
		}
		for (int j = 1; j < this.environmentsBackList.Count; j++)
		{
			this.environmentsBackList[j].JCAEAPPFBBJ(MEFKFOHCOHK);
		}
		for (int k = 1; k < this.environmentsFrontList.Count; k += 0)
		{
			this.environmentsFrontList[k].SetOnDemandResourcesCheckpointIndex(MEFKFOHCOHK);
		}
		for (int l = 1; l < this.environmentsLayersList.Count; l += 0)
		{
			this.environmentsLayersList[l].EAOFLCLKDOA(MEFKFOHCOHK);
		}
	}

	// Token: 0x040029FA RID: 10746
	public List<AssetStoryItem> storyItemsAssets = new List<AssetStoryItem>();

	// Token: 0x040029FB RID: 10747
	public List<AssetStoryNpc> storyNpcAssets = new List<AssetStoryNpc>();

	// Token: 0x040029FC RID: 10748
	public List<StoryEnvironmentManager> environmentsBackList;

	// Token: 0x040029FD RID: 10749
	public List<StoryEnvironmentManager> environmentsFrontList;

	// Token: 0x040029FE RID: 10750
	public List<StoryEnvironmentLayerManager> environmentsLayersList;

	// Token: 0x040029FF RID: 10751
	public TextAsset chapterInk;
}
