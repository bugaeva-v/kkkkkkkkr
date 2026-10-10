using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000105 RID: 261
	internal static class ProductDefinitionExtensions
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x0000B30C File Offset: 0x0000950C
		internal static List<ProductDefinition> DecodeJSON(this List<object> productsList, string storeName)
		{
			List<ProductDefinition> list = new List<ProductDefinition>();
			List<ProductDefinition> result;
			try
			{
				foreach (object obj in productsList)
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)obj;
					object obj2;
					dictionary.TryGetValue("id", out obj2);
					object obj3;
					dictionary.TryGetValue("store_ids", out obj3);
					object obj4;
					dictionary.TryGetValue("type", out obj4);
					Dictionary<string, object> dictionary2 = obj3 as Dictionary<string, object>;
					string storeSpecificId = (string)obj2;
					if (dictionary2 != null)
					{
						using (Dictionary<string, object>.Enumerator enumerator2 = dictionary2.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								KeyValuePair<string, object> keyValuePair = enumerator2.Current;
								string b = keyValuePair.Key.ToLower();
								string text = (string)keyValuePair.Value;
								if (!string.IsNullOrEmpty(text) && storeName.ToLower() == b)
								{
									storeSpecificId = text;
								}
							}
							goto IL_E2;
						}
						goto IL_C3;
					}
					goto IL_C3;
					IL_E2:
					ProductType type = (ProductType)Enum.Parse(typeof(ProductType), (string)obj4);
					ProductDefinition item = new ProductDefinition((string)obj2, storeSpecificId, type);
					list.Add(item);
					continue;
					IL_C3:
					object obj5;
					dictionary.TryGetValue("storeSpecificId", out obj5);
					string text2 = (string)obj5;
					if (text2 != null)
					{
						storeSpecificId = text2;
						goto IL_E2;
					}
					goto IL_E2;
				}
				result = list;
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
