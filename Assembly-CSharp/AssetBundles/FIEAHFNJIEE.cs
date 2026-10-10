using System;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x020003FA RID: 1018
	public class FIEAHFNJIEE : KFAMJDIMIFN
	{
		// Token: 0x06007845 RID: 30789 RVA: 0x003039F7 File Offset: 0x00301BF7
		public FIEAHFNJIEE(int EMJPOHAEEHN, string FNBFMGLJKFE, string COOOGACBAKN, Type OBKCKGHFMDN) : base(EMJPOHAEEHN, FNBFMGLJKFE, COOOGACBAKN, OBKCKGHFMDN)
		{
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x0035F1DC File Offset: 0x0035D3DC
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
			TextAsset textAsset = this.PCGAGHLGLIM<TextAsset>();
			if (textAsset != null)
			{
				PlayerPrefs.SetString(AssetBundleManager.GetAssetBundleManifestPrefsKey(this.NEFGOGNBKOC), textAsset.text);
				PlayerPrefs.Save();
			}
			else
			{
				Debug.LogError("AssetBundleLoadManifestHashBundleOperation: Could not get asset bundle manifest hash from remote hash container bundle.");
			}
			return false;
		}
	}
}
