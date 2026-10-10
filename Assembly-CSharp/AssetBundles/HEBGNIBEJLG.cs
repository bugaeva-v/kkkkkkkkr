using System;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x0200046D RID: 1133
	public class HEBGNIBEJLG : NPOILPKELOJ
	{
		// Token: 0x060089F5 RID: 35317 RVA: 0x003D7F64 File Offset: 0x003D6164
		public override bool BBHDMMHCDKO()
		{
			if (this.PNOHFDMMKCI == null && this.MCJJOJMFIIH != null)
			{
				Debug.LogError("AssetBundleEmptyOperation: " + this.MCJJOJMFIIH);
				return true;
			}
			return this.PNOHFDMMKCI != null;
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x003D7F96 File Offset: 0x003D6196
		public override bool HJOPIMGMGML()
		{
			return this.PNOHFDMMKCI == null && this.MCJJOJMFIIH != null;
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x003D7FAB File Offset: 0x003D61AB
		public HEBGNIBEJLG(string JELGLDNHLCG)
		{
			this.IHMLDDEENLI = JELGLDNHLCG;
		}

		// Token: 0x060089F8 RID: 35320 RVA: 0x003D7FBA File Offset: 0x003D61BA
		public override string NCDEKILOHGF()
		{
			return this.IHMLDDEENLI;
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x003D7FC2 File Offset: 0x003D61C2
		public override bool IIPBKOPAGBK()
		{
			if (this.PNOHFDMMKCI != null || this.MCJJOJMFIIH != null)
			{
				return false;
			}
			this.PNOHFDMMKCI = AssetBundleManager.GetLoadedAssetBundle(this.IHMLDDEENLI, out this.MCJJOJMFIIH);
			return this.PNOHFDMMKCI == null;
		}

		// Token: 0x040026D2 RID: 9938
		public string IHMLDDEENLI;

		// Token: 0x040026D3 RID: 9939
		protected string MCJJOJMFIIH;

		// Token: 0x040026D4 RID: 9940
		protected GCFIOHOKPPN PNOHFDMMKCI;
	}
}
