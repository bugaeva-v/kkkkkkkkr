using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000BA RID: 186
	public class SimpleCatalogProvider : IBaseCatalogProvider
	{
		// Token: 0x0600035D RID: 861 RVA: 0x0000845E File Offset: 0x0000665E
		public SimpleCatalogProvider(Action<Action<List<ProductDefinition>>> func)
		{
			this.m_Func = func;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000846D File Offset: 0x0000666D
		public void FetchProducts(Action<List<ProductDefinition>> callback)
		{
			Action<Action<List<ProductDefinition>>> func = this.m_Func;
			if (func == null)
			{
				return;
			}
			func(callback);
		}

		// Token: 0x0400016A RID: 362
		private readonly Action<Action<List<ProductDefinition>>> m_Func;
	}
}
