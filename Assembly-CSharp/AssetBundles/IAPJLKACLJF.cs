using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AssetBundles
{
	// Token: 0x02000382 RID: 898
	public class IAPJLKACLJF : NPOILPKELOJ
	{
		// Token: 0x06006945 RID: 26949 RVA: 0x00303880 File Offset: 0x00301A80
		public override bool HJOPIMGMGML()
		{
			return this.KFIPABBKJGG == null && this.MCJJOJMFIIH != null;
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00303895 File Offset: 0x00301A95
		public IAPJLKACLJF(string JELGLDNHLCG, string POFIFMJHHKJ, bool IEAFFPDOBEL, bool FEKDGMGBNIE = true)
		{
			this.IHMLDDEENLI = JELGLDNHLCG;
			this.AJONANPGLHH = POFIFMJHHKJ;
			this.BNLDGMBJLHO = IEAFFPDOBEL;
			this.IJDNKKOMGKK = FEKDGMGBNIE;
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x003038BA File Offset: 0x00301ABA
		public override string NCDEKILOHGF()
		{
			return this.IHMLDDEENLI;
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x003038C4 File Offset: 0x00301AC4
		public override bool BBHDMMHCDKO()
		{
			if (this.KFIPABBKJGG == null && this.MCJJOJMFIIH != null)
			{
				Debug.LogError("AssetBundleLoadLevelOperation: " + this.MCJJOJMFIIH);
				return true;
			}
			return (this.KFIPABBKJGG != null && !this.KFIPABBKJGG.allowSceneActivation && this.KFIPABBKJGG.progress >= 0.9f) || (this.KFIPABBKJGG != null && this.KFIPABBKJGG.isDone);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00303938 File Offset: 0x00301B38
		public override bool IIPBKOPAGBK()
		{
			if (this.KFIPABBKJGG != null || this.MCJJOJMFIIH != null)
			{
				return false;
			}
			if (AssetBundleManager.GetLoadedAssetBundle(this.IHMLDDEENLI, out this.MCJJOJMFIIH) != null)
			{
				this.KFIPABBKJGG = SceneManager.LoadSceneAsync(this.AJONANPGLHH, this.BNLDGMBJLHO ? LoadSceneMode.Additive : LoadSceneMode.Single);
				if (this.KFIPABBKJGG != null)
				{
					this.KFIPABBKJGG.allowSceneActivation = this.IJDNKKOMGKK;
					if (!this.IJDNKKOMGKK)
					{
						NPOILPKELOJ.DAPHAPLNFIE.Add(this.KFIPABBKJGG);
					}
				}
				return false;
			}
			if (AssetBundleManager.AssetBundleDependencyDeadLock(this.IHMLDDEENLI) && (float)base.JEJODCCFDCP() > NPOILPKELOJ.HNOPILBIIIO)
			{
				NPOILPKELOJ.DAEOMOJFKDN = true;
				this.MCJJOJMFIIH = "Asset bundle " + this.IHMLDDEENLI + " encountered a dependency deadlock. Aborting.";
			}
			return true;
		}

		// Token: 0x04001F01 RID: 7937
		public string IHMLDDEENLI;

		// Token: 0x04001F02 RID: 7938
		protected string AJONANPGLHH;

		// Token: 0x04001F03 RID: 7939
		protected bool BNLDGMBJLHO;

		// Token: 0x04001F04 RID: 7940
		protected string MCJJOJMFIIH;

		// Token: 0x04001F05 RID: 7941
		protected AsyncOperation KFIPABBKJGG;

		// Token: 0x04001F06 RID: 7942
		protected bool IJDNKKOMGKK;
	}
}
