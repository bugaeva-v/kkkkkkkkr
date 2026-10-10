using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000104 RID: 260
	internal class JSONSerializer
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x0000A678 File Offset: 0x00008878
		public static string SerializeProductDef(ProductDefinition product)
		{
			return MiniJson.JsonEncode(JSONSerializer.EncodeProductDef(product));
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000A688 File Offset: 0x00008888
		public static string SerializeProductDefs(IEnumerable<ProductDefinition> products)
		{
			List<object> list = new List<object>();
			foreach (ProductDefinition product in products)
			{
				list.Add(JSONSerializer.EncodeProductDef(product));
			}
			return MiniJson.JsonEncode(list);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public static string SerializeProductStoreSpecificIds(IEnumerable<ProductDefinition> products)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			List<string> value = (from product in products
			select product.storeSpecificId).ToList<string>();
			dictionary.Add("products", value);
			return MiniJson.JsonEncode(dictionary);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000A732 File Offset: 0x00008932
		public static string SerializeProductDescs(ProductDescription product)
		{
			return MiniJson.JsonEncode(JSONSerializer.EncodeProductDesc(product));
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000A740 File Offset: 0x00008940
		public static string SerializeProductDescs(IEnumerable<ProductDescription> products)
		{
			List<object> list = new List<object>();
			foreach (ProductDescription product in products)
			{
				list.Add(JSONSerializer.EncodeProductDesc(product));
			}
			return MiniJson.JsonEncode(list);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000A79C File Offset: 0x0000899C
		public static Dictionary<string, Dictionary<string, object>> DeserializeFetchedPurchases(string json)
		{
			Dictionary<string, Dictionary<string, object>> dictionary = new Dictionary<string, Dictionary<string, object>>();
			try
			{
				foreach (KeyValuePair<string, object> keyValuePair in ((Dictionary<string, object>)MiniJson.JsonDecode(json)))
				{
					dictionary[keyValuePair.Key] = (Dictionary<string, object>)keyValuePair.Value;
				}
			}
			catch (Exception arg)
			{
				Debug.unityLogger.LogIAPError(string.Format("DeserializeFetchedPurchases - Error decoding json: {0}", arg));
			}
			return dictionary;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000A834 File Offset: 0x00008A34
		public static List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			IEnumerable source = (List<object>)MiniJson.JsonDecode(json);
			List<ProductDescription> list = new List<ProductDescription>();
			foreach (Dictionary<string, object> dictionary in source.Cast<Dictionary<string, object>>())
			{
				ProductMetadata metadata = JSONSerializer.DeserializeMetadata((Dictionary<string, object>)dictionary["metadata"]);
				ProductDescription item = new ProductDescription((string)dictionary["storeSpecificId"], metadata, dictionary.TryGetString("receipt"), dictionary.TryGetString("transactionId"), ProductType.NonConsumable);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		public static List<ProductDescription> DeserializeProductDescriptionsFromFetchProductsSk2(string json)
		{
			List<ProductDescription> list = new List<ProductDescription>();
			Dictionary<string, object> dictionary = MiniJson.JsonDecode(json) as Dictionary<string, object>;
			List<object> list2 = ((dictionary != null) ? dictionary["products"] : null) as List<object>;
			if (list2 != null)
			{
				foreach (object obj in list2)
				{
					Dictionary<string, object> dictionary2 = obj as Dictionary<string, object>;
					if (dictionary2 == null)
					{
						break;
					}
					string id = dictionary2["id"] as string;
					string priceString = dictionary2.TryGetString("displayPrice");
					string title = dictionary2.TryGetString("displayName");
					string description = dictionary2.TryGetString("description");
					string currencyCode = dictionary2.TryGetString("currencyCode");
					decimal localizedPrice;
					try
					{
						localizedPrice = Convert.ToDecimal(dictionary2["price"]);
					}
					catch
					{
						localizedPrice = 0.0m;
					}
					bool isFamilyShareable = Convert.ToBoolean(dictionary2.TryGetString("isFamilyShareable"));
					AppleProductMetadata metadata = new AppleProductMetadata(priceString, title, description, currencyCode, localizedPrice, isFamilyShareable);
					ProductType type = dictionary2.TryGetString("type").ToProductType();
					ProductDescription item = new ProductDescription(id, metadata, "", "", type);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public static Dictionary<string, object> DeserializePurchaseDetails(string purchaseDetailJson)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			try
			{
				foreach (KeyValuePair<string, object> keyValuePair in ((Dictionary<string, object>)MiniJson.JsonDecode(purchaseDetailJson)))
				{
					string text;
					object obj;
					keyValuePair.Deconstruct(out text, out obj);
					string key = text;
					object value = obj;
					dictionary[key] = value;
				}
			}
			catch (Exception arg)
			{
				Debug.unityLogger.LogIAPError(string.Format("DeserializePurchaseDetails - Error decoding json: {0}", arg));
			}
			return dictionary;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		public static Dictionary<string, string> DeserializeSubscriptionDescriptions(string json)
		{
			List<object> list = MiniJson.JsonDecode(json) as List<object>;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (list == null)
			{
				return dictionary;
			}
			foreach (Dictionary<string, object> dictionary2 in list.Cast<Dictionary<string, object>>())
			{
				Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
				object obj;
				if (dictionary2.TryGetValue("metadata", out obj))
				{
					Dictionary<string, object> dic = (Dictionary<string, object>)obj;
					dictionary3["introductoryPrice"] = dic.TryGetString("introductoryPrice");
					dictionary3["introductoryPriceLocale"] = dic.TryGetString("introductoryPriceLocale");
					dictionary3["introductoryPriceNumberOfPeriods"] = dic.TryGetString("introductoryPriceNumberOfPeriods");
					dictionary3["numberOfUnits"] = dic.TryGetString("numberOfUnits");
					dictionary3["unit"] = dic.TryGetString("unit");
					if (!string.IsNullOrEmpty(dictionary3["numberOfUnits"]) && string.IsNullOrEmpty(dictionary3["unit"]))
					{
						dictionary3["unit"] = "0";
					}
				}
				else
				{
					Debug.unityLogger.LogIAPWarning("metadata key not found in subscription description json");
				}
				object obj2;
				if (dictionary2.TryGetValue("storeSpecificId", out obj2))
				{
					string key = (string)obj2;
					dictionary.Add(key, MiniJson.JsonEncode(dictionary3));
				}
				else
				{
					Debug.unityLogger.LogIAPWarning("storeSpecificId key not found in subscription description json");
				}
			}
			return dictionary;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000AC48 File Offset: 0x00008E48
		public static Dictionary<string, string> DeserializeProductDetails(string json)
		{
			List<object> list = MiniJson.JsonDecode(json) as List<object>;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (list == null)
			{
				return dictionary;
			}
			foreach (Dictionary<string, object> dictionary2 in list.Cast<Dictionary<string, object>>())
			{
				Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
				object obj;
				if (dictionary2.TryGetValue("metadata", out obj))
				{
					Dictionary<string, object> dic = (Dictionary<string, object>)obj;
					dictionary3["subscriptionNumberOfUnits"] = dic.TryGetString("subscriptionNumberOfUnits");
					dictionary3["subscriptionPeriodUnit"] = dic.TryGetString("subscriptionPeriodUnit");
					dictionary3["localizedPrice"] = dic.TryGetString("localizedPrice");
					dictionary3["isoCurrencyCode"] = dic.TryGetString("isoCurrencyCode");
					dictionary3["localizedPriceString"] = dic.TryGetString("localizedPriceString");
					dictionary3["localizedTitle"] = dic.TryGetString("localizedTitle");
					dictionary3["localizedDescription"] = dic.TryGetString("localizedDescription");
					dictionary3["introductoryPrice"] = dic.TryGetString("introductoryPrice");
					dictionary3["introductoryPriceLocale"] = dic.TryGetString("introductoryPriceLocale");
					dictionary3["introductoryPriceNumberOfPeriods"] = dic.TryGetString("introductoryPriceNumberOfPeriods");
					dictionary3["numberOfUnits"] = dic.TryGetString("numberOfUnits");
					dictionary3["unit"] = dic.TryGetString("unit");
					if (!string.IsNullOrEmpty(dictionary3["subscriptionNumberOfUnits"]) && string.IsNullOrEmpty(dictionary3["subscriptionPeriodUnit"]))
					{
						dictionary3["subscriptionPeriodUnit"] = "0";
					}
					if (!string.IsNullOrEmpty(dictionary3["numberOfUnits"]) && string.IsNullOrEmpty(dictionary3["unit"]))
					{
						dictionary3["unit"] = "0";
					}
				}
				else
				{
					Debug.unityLogger.LogIAPWarning("metadata key not found in product details json");
				}
				object obj2;
				if (dictionary2.TryGetValue("storeSpecificId", out obj2))
				{
					string key = (string)obj2;
					dictionary.Add(key, MiniJson.JsonEncode(dictionary3));
				}
				else
				{
					Debug.unityLogger.LogIAPWarning("storeSpecificId key not found in product details json");
				}
			}
			return dictionary;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000AE9C File Offset: 0x0000909C
		public static PurchaseFailureDescription DeserializeFailureReason(string json, IProductCache productCache)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(json);
			PurchaseFailureReason reason = PurchaseFailureReason.Unknown;
			object obj;
			if (dictionary.TryGetValue("reason", out obj))
			{
				if (Enum.IsDefined(typeof(PurchaseFailureReason), (string)obj))
				{
					reason = (PurchaseFailureReason)Enum.Parse(typeof(PurchaseFailureReason), (string)obj);
				}
				object obj2;
				if (dictionary.TryGetValue("productId", out obj2))
				{
					return new PurchaseFailureDescription(productCache.FindOrDefault((string)obj2), reason, JSONSerializer.BuildPurchaseFailureDescriptionMessage(dictionary));
				}
			}
			else
			{
				Debug.unityLogger.LogIAPWarning("Reason key not found in purchase failure json: " + json);
			}
			return new PurchaseFailureDescription(Product.CreateUnknownProduct("Unknown ProductID"), reason, JSONSerializer.BuildPurchaseFailureDescriptionMessage(dictionary));
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000AF58 File Offset: 0x00009158
		private static ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
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

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000AFCC File Offset: 0x000091CC
		private static string BuildPurchaseFailureDescriptionMessage(Dictionary<string, object> dic)
		{
			string text = dic.TryGetString("message");
			string text2 = dic.TryGetString("storeSpecificErrorCode");
			if (text == null && text2 == null)
			{
				return null;
			}
			if (text2 != null)
			{
				text2 = " storeSpecificErrorCode: " + text2;
			}
			return text + text2;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000B010 File Offset: 0x00009210
		private static Dictionary<string, object> EncodeProductDef(ProductDefinition product)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"id",
					product.id
				},
				{
					"storeSpecificId",
					product.storeSpecificId
				},
				{
					"type",
					product.type.ToString()
				}
			};
			bool flag = true;
			PropertyInfo property = typeof(ProductDefinition).GetProperty("enabled");
			if (property != null)
			{
				try
				{
					flag = Convert.ToBoolean(property.GetValue(product, null));
				}
				catch
				{
					flag = true;
				}
			}
			dictionary.Add("enabled", flag);
			List<object> list = new List<object>();
			PropertyInfo property2 = typeof(ProductDefinition).GetProperty("payouts");
			if (property2 != null)
			{
				Array array = property2.GetValue(product, null) as Array;
				if (array != null)
				{
					foreach (object obj in array)
					{
						Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
						Type type = obj.GetType();
						dictionary2["t"] = type.GetField("typeString").GetValue(obj);
						dictionary2["st"] = type.GetField("subtype").GetValue(obj);
						dictionary2["q"] = type.GetField("quantity").GetValue(obj);
						dictionary2["d"] = type.GetField("data").GetValue(obj);
						list.Add(dictionary2);
					}
				}
			}
			dictionary.Add("payouts", list);
			return dictionary;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000B1E4 File Offset: 0x000093E4
		private static Dictionary<string, object> EncodeProductDesc(ProductDescription product)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"storeSpecificId",
					product.storeSpecificId
				}
			};
			FieldInfo field = typeof(ProductDescription).GetField("type");
			if (field != null)
			{
				object value = field.GetValue(product);
				dictionary.Add("type", value.ToString());
			}
			dictionary.Add("metadata", JSONSerializer.EncodeProductMeta(product.metadata));
			dictionary.Add("receipt", product.receipt);
			dictionary.Add("transactionId", product.transactionId);
			return dictionary;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000B278 File Offset: 0x00009478
		private static Dictionary<string, object> EncodeProductMeta(ProductMetadata product)
		{
			return new Dictionary<string, object>
			{
				{
					"localizedPriceString",
					product.localizedPriceString
				},
				{
					"localizedTitle",
					product.localizedTitle
				},
				{
					"localizedDescription",
					product.localizedDescription
				},
				{
					"isoCurrencyCode",
					product.isoCurrencyCode
				},
				{
					"localizedPrice",
					Convert.ToDouble(product.localizedPrice)
				}
			};
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000B2E9 File Offset: 0x000094E9
		public static StoreConnectionFailureDescription DeserializeConnectionFailureDescription(string json)
		{
			return JsonUtility.FromJson<StoreConnectionFailureDescription>(json);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000B2F1 File Offset: 0x000094F1
		public static ProductFetchFailureDescription DeserializeProductFetchFailureDescription(string json)
		{
			return JsonUtility.FromJson<ProductFetchFailureDescription>(json);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000B2F9 File Offset: 0x000094F9
		public static PurchasesFetchFailureDescription DeserializePurchasesFetchFailureDescription(string json)
		{
			return JsonUtility.FromJson<PurchasesFetchFailureDescription>(json);
		}
	}
}
