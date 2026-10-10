using System;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x02000189 RID: 393
	public abstract class LOKAMLMIIAA : NPOILPKELOJ
	{
		// Token: 0x060030D2 RID: 12498 RVA: 0x0014B7FF File Offset: 0x001499FF
		public override bool IIPBKOPAGBK()
		{
			if (!this.NPDICAEKBCM && this.EPBDMHGPFJN)
			{
				this.OFOIHGLENOL();
				this.NPDICAEKBCM = true;
			}
			this.LLCAGPCNKJB += Time.deltaTime;
			return !this.NPDICAEKBCM;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x0014B839 File Offset: 0x00149A39
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x0014B863 File Offset: 0x00149A63
		public string CIEHGJMAFKH { get; private set; }

		// Token: 0x060030D4 RID: 12500 RVA: 0x0014B841 File Offset: 0x00149A41
		public override bool BBHDMMHCDKO()
		{
			return this.NPDICAEKBCM;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0014B849 File Offset: 0x00149A49
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x0014B851 File Offset: 0x00149A51
		public string GCFILGFLALC { get; protected set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060030D6 RID: 12502
		protected abstract bool EPBDMHGPFJN { get; }

		// Token: 0x060030D7 RID: 12503
		protected abstract void OFOIHGLENOL();

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x0014B87B File Offset: 0x00149A7B
		// (set) Token: 0x060030D9 RID: 12505 RVA: 0x0014B85A File Offset: 0x00149A5A
		public GCFIOHOKPPN GHKBBDLNAGD { get; protected set; }

		// Token: 0x060030DB RID: 12507 RVA: 0x0014B86C File Offset: 0x00149A6C
		public LOKAMLMIIAA(string CIEHGJMAFKH)
		{
			this.CIEHGJMAFKH = CIEHGJMAFKH;
		}

		// Token: 0x060030DD RID: 12509
		public abstract string HPIFGCJIPKK();

		// Token: 0x04000EF5 RID: 3829
		private bool NPDICAEKBCM;
	}
}
