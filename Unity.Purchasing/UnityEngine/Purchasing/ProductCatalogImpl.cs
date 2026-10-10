using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B9 RID: 185
	internal class ProductCatalogImpl : IProductCatalogImpl
	{
		// Token: 0x0600035B RID: 859 RVA: 0x00008424 File Offset: 0x00006624
		public ProductCatalog LoadDefaultCatalog()
		{
			TextAsset textAsset = Resources.Load("IAPProductCatalog") as TextAsset;
			if (textAsset != null)
			{
				return ProductCatalog.FromTextAsset(textAsset);
			}
			return new ProductCatalog();
		}
	}
}
