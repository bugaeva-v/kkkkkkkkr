using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B6 RID: 182
	[Serializable]
	public class ProductCatalogItem
	{
		// Token: 0x0600033E RID: 830 RVA: 0x00007F42 File Offset: 0x00006142
		public void AddPayout()
		{
			this.payouts.Add(new ProductCatalogPayout());
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00007F54 File Offset: 0x00006154
		public void RemovePayout(ProductCatalogPayout payout)
		{
			this.payouts.Remove(payout);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00007F63 File Offset: 0x00006163
		public IList<ProductCatalogPayout> Payouts
		{
			get
			{
				return this.payouts;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00007F6C File Offset: 0x0000616C
		public ProductCatalogItem Clone()
		{
			ProductCatalogItem productCatalogItem = new ProductCatalogItem
			{
				id = this.id,
				type = this.type
			};
			productCatalogItem.SetStoreIDs(this.allStoreIDs);
			productCatalogItem.defaultDescription = this.defaultDescription.Clone();
			productCatalogItem.screenshotPath = this.screenshotPath;
			productCatalogItem.applePriceTier = this.applePriceTier;
			productCatalogItem.googlePrice.value = this.googlePrice.value;
			productCatalogItem.pricingTemplateID = this.pricingTemplateID;
			foreach (LocalizedProductDescription localizedProductDescription in this.descriptions)
			{
				productCatalogItem.descriptions.Add(localizedProductDescription.Clone());
			}
			return productCatalogItem;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00008040 File Offset: 0x00006240
		public void SetStoreID(string aStore, string aId)
		{
			this.storeIDs.RemoveAll((StoreID obj) => obj.store == aStore);
			if (!string.IsNullOrEmpty(aId))
			{
				this.storeIDs.Add(new StoreID(aStore, aId));
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00008094 File Offset: 0x00006294
		public string GetStoreID(string store)
		{
			StoreID storeID = this.storeIDs.Find((StoreID obj) => obj.store == store);
			if (storeID != null)
			{
				return storeID.id;
			}
			return null;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000080D1 File Offset: 0x000062D1
		public ICollection<StoreID> allStoreIDs
		{
			get
			{
				return this.storeIDs;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000080DC File Offset: 0x000062DC
		public void SetStoreIDs(ICollection<StoreID> storeIds)
		{
			using (IEnumerator<StoreID> enumerator = storeIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					StoreID storeId = enumerator.Current;
					this.storeIDs.RemoveAll((StoreID obj) => obj.store == storeId.store);
					if (!string.IsNullOrEmpty(storeId.id))
					{
						this.storeIDs.Add(new StoreID(storeId.store, storeId.id));
					}
				}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00008178 File Offset: 0x00006378
		public LocalizedProductDescription GetDescription(TranslationLocale locale)
		{
			return this.descriptions.Find((LocalizedProductDescription obj) => obj.googleLocale == locale);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000081A9 File Offset: 0x000063A9
		public LocalizedProductDescription GetOrCreateDescription(TranslationLocale locale)
		{
			return this.GetDescription(locale) ?? this.AddDescription(locale);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000081C0 File Offset: 0x000063C0
		public LocalizedProductDescription AddDescription(TranslationLocale locale)
		{
			this.RemoveDescription(locale);
			LocalizedProductDescription localizedProductDescription = new LocalizedProductDescription
			{
				googleLocale = locale
			};
			this.descriptions.Add(localizedProductDescription);
			return localizedProductDescription;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000081F0 File Offset: 0x000063F0
		public void RemoveDescription(TranslationLocale locale)
		{
			this.descriptions.RemoveAll((LocalizedProductDescription obj) => obj.googleLocale == locale);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00008222 File Offset: 0x00006422
		public bool HasAvailableLocale
		{
			get
			{
				return Enum.GetValues(typeof(TranslationLocale)).Length > this.descriptions.Count + 1;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00008248 File Offset: 0x00006448
		public TranslationLocale NextAvailableLocale
		{
			get
			{
				foreach (object obj in Enum.GetValues(typeof(TranslationLocale)))
				{
					TranslationLocale translationLocale = (TranslationLocale)obj;
					if (this.GetDescription(translationLocale) == null && this.defaultDescription.googleLocale != translationLocale)
					{
						return translationLocale;
					}
				}
				return TranslationLocale.en_US;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000082C4 File Offset: 0x000064C4
		public ICollection<LocalizedProductDescription> translatedDescriptions
		{
			get
			{
				return this.descriptions;
			}
		}

		// Token: 0x04000158 RID: 344
		public string id;

		// Token: 0x04000159 RID: 345
		public ProductType type;

		// Token: 0x0400015A RID: 346
		[SerializeField]
		private List<StoreID> storeIDs = new List<StoreID>();

		// Token: 0x0400015B RID: 347
		public LocalizedProductDescription defaultDescription = new LocalizedProductDescription();

		// Token: 0x0400015C RID: 348
		public string screenshotPath;

		// Token: 0x0400015D RID: 349
		public int applePriceTier;

		// Token: 0x0400015E RID: 350
		public Price googlePrice = new Price();

		// Token: 0x0400015F RID: 351
		public string pricingTemplateID;

		// Token: 0x04000160 RID: 352
		[SerializeField]
		private List<LocalizedProductDescription> descriptions = new List<LocalizedProductDescription>();

		// Token: 0x04000161 RID: 353
		[SerializeField]
		private List<ProductCatalogPayout> payouts = new List<ProductCatalogPayout>();
	}
}
