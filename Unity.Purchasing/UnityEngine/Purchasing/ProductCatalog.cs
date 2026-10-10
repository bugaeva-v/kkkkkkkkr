using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B7 RID: 183
	[Serializable]
	public class ProductCatalog
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000830B File Offset: 0x0000650B
		public ICollection<ProductCatalogItem> allProducts
		{
			get
			{
				return this.products;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00008313 File Offset: 0x00006513
		public ICollection<ProductCatalogItem> allValidProducts
		{
			get
			{
				return (from x in this.products
				where !string.IsNullOrEmpty(x.id) && x.id.Trim().Length != 0
				select x).ToList<ProductCatalogItem>();
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00008344 File Offset: 0x00006544
		internal static void Initialize()
		{
			if (ProductCatalog.instance == null)
			{
				ProductCatalog.Initialize(new ProductCatalogImpl());
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00008357 File Offset: 0x00006557
		public static void Initialize(IProductCatalogImpl productCatalogImpl)
		{
			ProductCatalog.instance = productCatalogImpl;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000835F File Offset: 0x0000655F
		public void Add(ProductCatalogItem item)
		{
			this.products.Add(item);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000836D File Offset: 0x0000656D
		public void Remove(ProductCatalogItem item)
		{
			this.products.Remove(item);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000837C File Offset: 0x0000657C
		public bool IsEmpty()
		{
			using (List<ProductCatalogItem>.Enumerator enumerator = this.products.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!string.IsNullOrEmpty(enumerator.Current.id))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000083DC File Offset: 0x000065DC
		public static string Serialize(ProductCatalog catalog)
		{
			return JsonUtility.ToJson(catalog);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000083E4 File Offset: 0x000065E4
		public static ProductCatalog Deserialize(string catalogJSON)
		{
			return JsonUtility.FromJson<ProductCatalog>(catalogJSON);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000083EC File Offset: 0x000065EC
		public static ProductCatalog FromTextAsset(TextAsset asset)
		{
			return ProductCatalog.Deserialize(asset.text);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000083F9 File Offset: 0x000065F9
		public static ProductCatalog LoadDefaultCatalog()
		{
			ProductCatalog.Initialize();
			return ProductCatalog.instance.LoadDefaultCatalog();
		}

		// Token: 0x04000162 RID: 354
		private static IProductCatalogImpl instance;

		// Token: 0x04000163 RID: 355
		public string appleSKU;

		// Token: 0x04000164 RID: 356
		public string appleTeamID;

		// Token: 0x04000165 RID: 357
		public bool enableCodelessAutoInitialization = true;

		// Token: 0x04000166 RID: 358
		public bool enableUnityGamingServicesAutoInitialization;

		// Token: 0x04000167 RID: 359
		[SerializeField]
		private List<ProductCatalogItem> products = new List<ProductCatalogItem>();

		// Token: 0x04000168 RID: 360
		public const string kCatalogPath = "Assets/Resources/IAPProductCatalog.json";

		// Token: 0x04000169 RID: 361
		public const string kPrevCatalogPath = "Assets/Plugins/UnityPurchasing/Resources/IAPProductCatalog.json";
	}
}
