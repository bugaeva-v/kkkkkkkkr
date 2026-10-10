using System;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x02000383 RID: 899
	public class PLOGDOACBMK : KFAMJDIMIFN
	{
		// Token: 0x0600694A RID: 26954 RVA: 0x003039F7 File Offset: 0x00301BF7
		public PLOGDOACBMK(int EMJPOHAEEHN, string FNBFMGLJKFE, string COOOGACBAKN, Type OBKCKGHFMDN) : base(EMJPOHAEEHN, FNBFMGLJKFE, COOOGACBAKN, OBKCKGHFMDN)
		{
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00303A04 File Offset: 0x00301C04
		public override bool IIPBKOPAGBK()
		{
			if (base.IIPBKOPAGBK())
			{
				return true;
			}
			if (this.MCJJOJMFIIH != null)
			{
				return false;
			}
			AssetBundleManager.SetAssetBundleManifest(this.PCGAGHLGLIM<AssetBundleManifest>(), this.NEFGOGNBKOC);
			return false;
		}
	}
}
