using System;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x0200008C RID: 140
	public class CHGCPKLJDJH : LOKAMLMIIAA
	{
		// Token: 0x0600142C RID: 5164 RVA: 0x0009C88E File Offset: 0x0009AA8E
		public override string NCDEKILOHGF()
		{
			return this.HPIFGCJIPKK();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0009C896 File Offset: 0x0009AA96
		protected override bool EPBDMHGPFJN
		{
			get
			{
				return this.JGGJNIPMFIK == null || this.JGGJNIPMFIK.isDone;
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0009C8AD File Offset: 0x0009AAAD
		public CHGCPKLJDJH(string CIEHGJMAFKH, string HPIGJNFGNDM, uint DAINNLOMMEG = 0U, ulong LLNGPLNPCAC = 0UL) : base(CIEHGJMAFKH)
		{
			this.JGGJNIPMFIK = AssetBundle.LoadFromFileAsync(HPIGJNFGNDM, DAINNLOMMEG, LLNGPLNPCAC);
			this.HIIPJMDOJAG = HPIGJNFGNDM;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0009C8CC File Offset: 0x0009AACC
		public override string HPIFGCJIPKK()
		{
			return this.HIIPJMDOJAG;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0009C8D4 File Offset: 0x0009AAD4
		protected override void OFOIHGLENOL()
		{
			AssetBundle assetBundle = this.JGGJNIPMFIK.assetBundle;
			if (assetBundle == null)
			{
				base.GCFILGFLALC = string.Format("failed to load assetBundle {0}.", base.CIEHGJMAFKH);
				return;
			}
			if (assetBundle == null)
			{
				base.GCFILGFLALC = string.Format("{0} is not a valid asset bundle.", base.CIEHGJMAFKH);
			}
			else
			{
				base.GHKBBDLNAGD = new GCFIOHOKPPN(assetBundle);
			}
			this.JGGJNIPMFIK = null;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		public override bool HJOPIMGMGML()
		{
			return false;
		}

		// Token: 0x0400066E RID: 1646
		private AssetBundleCreateRequest JGGJNIPMFIK;

		// Token: 0x0400066F RID: 1647
		private string HIIPJMDOJAG;
	}
}
