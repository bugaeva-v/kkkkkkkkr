using System;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x0200012A RID: 298
	public class KFAMJDIMIFN : DAJHCGFBHMO
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x001231D0 File Offset: 0x001213D0
		public override bool HJOPIMGMGML()
		{
			return this.KFIPABBKJGG == null && this.MCJJOJMFIIH != null;
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x001231E5 File Offset: 0x001213E5
		public KFAMJDIMIFN(int EMJPOHAEEHN, string FNBFMGLJKFE, string COOOGACBAKN, Type OBKCKGHFMDN)
		{
			this.NEFGOGNBKOC = EMJPOHAEEHN;
			this.IHMLDDEENLI = FNBFMGLJKFE;
			this.FHJHPPACOBB = COOOGACBAKN;
			this.NOILINCFENO = OBKCKGHFMDN;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0012320C File Offset: 0x0012140C
		public override bool IIPBKOPAGBK()
		{
			if (this.KFIPABBKJGG != null || this.MCJJOJMFIIH != null)
			{
				return this.MCJJOJMFIIH == null && (!this.KFIPABBKJGG.isDone || !(this.KFIPABBKJGG.asset != null));
			}
			GCFIOHOKPPN loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(this.IHMLDDEENLI, out this.MCJJOJMFIIH);
			if (loadedAssetBundle != null)
			{
				this.KFIPABBKJGG = loadedAssetBundle.HKLJGIGDKEE.LoadAssetAsync(this.FHJHPPACOBB, this.NOILINCFENO);
			}
			else if (AssetBundleManager.AssetBundleDependencyDeadLock(this.IHMLDDEENLI) && (float)base.JEJODCCFDCP() > NPOILPKELOJ.HNOPILBIIIO)
			{
				NPOILPKELOJ.DAEOMOJFKDN = true;
				this.MCJJOJMFIIH = "Asset bundle " + this.IHMLDDEENLI + " encountered a dependency deadlock. Aborting.";
			}
			return true;
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x001232CA File Offset: 0x001214CA
		public override bool BBHDMMHCDKO()
		{
			if (this.KFIPABBKJGG == null && this.MCJJOJMFIIH != null)
			{
				Debug.LogError("AssetBundleLoadAssetOperationFull: " + this.MCJJOJMFIIH);
				return true;
			}
			return this.KFIPABBKJGG != null && this.KFIPABBKJGG.isDone;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00123308 File Offset: 0x00121508
		public override string NCDEKILOHGF()
		{
			return this.IHMLDDEENLI;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00123310 File Offset: 0x00121510
		public override T PCGAGHLGLIM<T>()
		{
			if (this.KFIPABBKJGG != null && this.KFIPABBKJGG.isDone)
			{
				T t = this.KFIPABBKJGG.asset as T;
				NEMPDPJNKFN.EINNKDEHCAN(t, this.IHMLDDEENLI + "/" + this.FHJHPPACOBB);
				return t;
			}
			return default(T);
		}

		// Token: 0x04000C4F RID: 3151
		public string IHMLDDEENLI;

		// Token: 0x04000C50 RID: 3152
		public int NEFGOGNBKOC;

		// Token: 0x04000C51 RID: 3153
		protected string FHJHPPACOBB;

		// Token: 0x04000C52 RID: 3154
		protected string MCJJOJMFIIH;

		// Token: 0x04000C53 RID: 3155
		protected Type NOILINCFENO;

		// Token: 0x04000C54 RID: 3156
		protected AssetBundleRequest KFIPABBKJGG;
	}
}
