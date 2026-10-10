using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.MiniJSON;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x02000050 RID: 80
	[NullableContext(1)]
	[Nullable(0)]
	[Preserve]
	internal class ProductDetailsConverter : IProductDetailsConverter
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00007FE8 File Offset: 0x000061E8
		public List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions)
		{
			List<ProductDescription> list = new List<ProductDescription>();
			Dictionary<string, ProductType> dictionary = new Dictionary<string, ProductType>();
			HashSet<string> hashSet = new HashSet<string>();
			foreach (ProductDefinition productDefinition in productDefinitions)
			{
				try
				{
					dictionary.Add(productDefinition.storeSpecificId, productDefinition.type);
				}
				catch (ArgumentException ex) when (ex.Message.Contains("same key"))
				{
					Debug.LogError("Duplicate product definition found with store specific ID: " + productDefinition.storeSpecificId + ". Only the first definition will be used.");
				}
			}
			foreach (AndroidJavaObject androidJavaObject in productDetails)
			{
				try
				{
					string productId = this.GetProductId(androidJavaObject);
					ProductType productType;
					if (string.IsNullOrEmpty(productId))
					{
						Debug.LogWarning("Skipping product with empty or null ID from Google Play store response. Detail: " + (((androidJavaObject != null) ? androidJavaObject.ToString() : null) ?? "null"));
					}
					else if (!hashSet.Add(productId))
					{
						Debug.LogError("Duplicate product ID found in Google Play store response: " + productId + ". This product will be ignored to prevent dictionary key conflicts. Please ensure each product has a unique store-specific ID.");
					}
					else if (dictionary.TryGetValue(productId, out productType))
					{
						list.Add(this.ConvertToProductDescription(androidJavaObject, productType));
					}
					else
					{
						Debug.LogWarning("Product with ID " + productId + " found in store but not in definitions. Skipping.");
					}
				}
				catch (Exception exception)
				{
					Debug.unityLogger.LogIAPException(exception);
				}
			}
			return list;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00008188 File Offset: 0x00006388
		[return: Nullable(2)]
		public string GetProductId(AndroidJavaObject productDetails)
		{
			string result;
			try
			{
				result = productDetails.Call<string>("getProductId", Array.Empty<object>());
			}
			catch (Exception ex)
			{
				Debug.LogError("Failed to get product ID: " + ex.Message);
				result = null;
			}
			return result;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000081D4 File Offset: 0x000063D4
		public ProductDescription ConvertToProductDescription(AndroidJavaObject productDetails, ProductType productType)
		{
			ProductDescription result;
			try
			{
				result = ProductDetailsConverter.BuildProductDescription(productDetails, productType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008200 File Offset: 0x00006400
		internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails, ProductType productType = ProductType.Unknown)
		{
			string text = productDetails.Call<string>("getProductId", Array.Empty<object>());
			ProductDescription result;
			using (AndroidJavaObject androidJavaObject = productDetails.Call<AndroidJavaObject>("getOneTimePurchaseOfferDetails", Array.Empty<object>()))
			{
				using (AndroidJavaObject androidJavaObject2 = productDetails.Call<AndroidJavaObject>("getSubscriptionOfferDetails", Array.Empty<object>()).Enumerate().FirstOrDefault<AndroidJavaObject>())
				{
					using (AndroidJavaObject androidJavaObject3 = (androidJavaObject2 != null) ? androidJavaObject2.Call<AndroidJavaObject>("getPricingPhases", Array.Empty<object>()) : null)
					{
						using (AndroidJavaObject androidJavaObject4 = (androidJavaObject3 != null) ? androidJavaObject3.Call<AndroidJavaObject>("getPricingPhaseList", Array.Empty<object>()) : null)
						{
							List<AndroidJavaObject> list = (androidJavaObject4 != null) ? androidJavaObject4.Enumerate().ToList<AndroidJavaObject>() : null;
							AndroidJavaObject androidJavaObject5 = (list != null) ? list.LastOrDefault<AndroidJavaObject>() : null;
							AndroidJavaObject androidJavaObject6 = null;
							AndroidJavaObject androidJavaObject7 = null;
							if (list != null)
							{
								for (int i = list.Count - 2; i >= 0; i--)
								{
									AndroidJavaObject androidJavaObject8 = list[i];
									if (androidJavaObject8.Call<long>("getPriceAmountMicros", Array.Empty<object>()) == 0L)
									{
										androidJavaObject6 = androidJavaObject8;
									}
									else
									{
										androidJavaObject7 = androidJavaObject8;
									}
								}
							}
							string text2 = ((androidJavaObject != null) ? androidJavaObject.Call<string>("getFormattedPrice", Array.Empty<object>()) : null) ?? ((androidJavaObject5 != null) ? androidJavaObject5.Call<string>("getFormattedPrice", Array.Empty<object>()) : null);
							decimal d = (androidJavaObject != null) ? Convert.ToDecimal((androidJavaObject.Call<long>("getPriceAmountMicros", Array.Empty<object>()) > 0L) ? androidJavaObject.Call<long>("getPriceAmountMicros", Array.Empty<object>()) : 0L) : Convert.ToDecimal((androidJavaObject5 != null && androidJavaObject5.Call<long>("getPriceAmountMicros", Array.Empty<object>()) > 0L) ? androidJavaObject5.Call<long>("getPriceAmountMicros", Array.Empty<object>()) : 0L);
							decimal localizedPrice = d / 1000000m;
							string text3 = productDetails.Call<string>("getTitle", Array.Empty<object>());
							string text4 = productDetails.Call<string>("getDescription", Array.Empty<object>());
							string text5 = ((androidJavaObject != null) ? androidJavaObject.Call<string>("getPriceCurrencyCode", Array.Empty<object>()) : null) ?? ((androidJavaObject5 != null) ? androidJavaObject5.Call<string>("getPriceCurrencyCode", Array.Empty<object>()) : null);
							string text6 = (androidJavaObject5 != null) ? androidJavaObject5.Call<string>("getBillingPeriod", Array.Empty<object>()) : null;
							string text7 = (androidJavaObject6 != null) ? androidJavaObject6.Call<string>("getBillingPeriod", Array.Empty<object>()) : null;
							string text8 = (androidJavaObject7 != null) ? androidJavaObject7.Call<string>("getFormattedPrice", Array.Empty<object>()) : null;
							decimal num = (androidJavaObject7 == null) ? 0m : Convert.ToDecimal(androidJavaObject7.Call<long>("getPriceAmountMicros", Array.Empty<object>()));
							string text9 = (androidJavaObject7 != null) ? androidJavaObject7.Call<string>("getBillingPeriod", Array.Empty<object>()) : null;
							int num2 = (androidJavaObject7 != null) ? androidJavaObject7.Call<int>("getBillingCycleCount", Array.Empty<object>()) : 0;
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary["productId"] = text;
							dictionary["type"] = productDetails.Call<string>("getProductType", Array.Empty<object>());
							dictionary["title"] = text3;
							dictionary["name"] = productDetails.Call<string>("getName", Array.Empty<object>());
							dictionary["description"] = text4;
							dictionary["price"] = (text2 ?? "");
							dictionary["price_amount_micros"] = d.ToString();
							dictionary["price_currency_code"] = (text5 ?? "");
							if (androidJavaObject5 != null)
							{
								dictionary["subscriptionPeriod"] = (text6 ?? "");
							}
							if (androidJavaObject6 != null)
							{
								dictionary["freeTrialPeriod"] = (text7 ?? "");
							}
							if (androidJavaObject7 != null)
							{
								dictionary["introductoryPrice"] = (text8 ?? "");
								dictionary["introductoryPricePeriod"] = (text9 ?? "");
								dictionary["introductoryPriceCycles"] = num2;
								dictionary["introductoryPriceAmountMicros"] = num;
							}
							string originalJson = dictionary.toJson();
							GoogleProductMetadata metadata = new GoogleProductMetadata(text2, text3, text4, text5, localizedPrice)
							{
								originalJson = originalJson,
								subscriptionPeriod = text6,
								introductoryPrice = text8,
								introductoryPriceCycles = num2,
								introductoryPricePeriod = text9,
								freeTrialPeriod = text7
							};
							result = new ProductDescription(text, metadata, "", "", productType);
						}
					}
				}
			}
			return result;
		}
	}
}
