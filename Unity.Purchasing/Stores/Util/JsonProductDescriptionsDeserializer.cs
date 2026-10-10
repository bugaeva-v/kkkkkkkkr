using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Stores.Util
{
	// Token: 0x02000005 RID: 5
	internal class JsonProductDescriptionsDeserializer
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002090 File Offset: 0x00000290
		public List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			List<object> list = (List<object>)MiniJson.JsonDecode(json);
			List<ProductDescription> list2 = new List<ProductDescription>();
			foreach (object obj in list)
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)obj;
				ProductMetadata metadata = this.DeserializeMetadata((Dictionary<string, object>)dictionary["metadata"]);
				ProductDescription item = new ProductDescription((string)dictionary["storeSpecificId"], metadata, dictionary.TryGetString("receipt"), dictionary.TryGetString("transactionId"), ProductType.NonConsumable);
				list2.Add(item);
			}
			return list2;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000213C File Offset: 0x0000033C
		internal virtual ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
		{
			decimal localizedPrice;
			try
			{
				localizedPrice = Convert.ToDecimal(data["localizedPrice"]);
			}
			catch
			{
				localizedPrice = 0.0m;
			}
			return new ProductMetadata(data.TryGetString("localizedPriceString"), data.TryGetString("localizedTitle"), data.TryGetString("localizedDescription"), data.TryGetString("isoCurrencyCode"), localizedPrice);
		}
	}
}
