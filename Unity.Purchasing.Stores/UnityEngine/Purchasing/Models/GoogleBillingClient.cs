using System;
using System.Collections.Generic;
using System.Linq;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000051 RID: 81
	internal class GoogleBillingClient : IGoogleBillingClient
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000086C8 File Offset: 0x000068C8
		private static AndroidJavaClass GetProductParamsClass()
		{
			if (GoogleBillingClient.s_AndroidProductClassName == null)
			{
				GoogleBillingClient.s_AndroidProductClassName = new AndroidJavaClass("com.android.billingclient.api.QueryProductDetailsParams$Product");
			}
			return GoogleBillingClient.s_AndroidProductClassName;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000086E5 File Offset: 0x000068E5
		private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass()
		{
			if (GoogleBillingClient.s_AndroidQueryProductDetailsParamsClassName == null)
			{
				GoogleBillingClient.s_AndroidQueryProductDetailsParamsClassName = new AndroidJavaClass("com.android.billingclient.api.QueryProductDetailsParams");
			}
			return GoogleBillingClient.s_AndroidQueryProductDetailsParamsClassName;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008702 File Offset: 0x00006902
		private static AndroidJavaClass GetBillingFlowParamClass()
		{
			if (GoogleBillingClient.s_BillingFlowParamsClass == null)
			{
				GoogleBillingClient.s_BillingFlowParamsClass = new AndroidJavaClass("com.android.billingclient.api.BillingFlowParams");
			}
			return GoogleBillingClient.s_BillingFlowParamsClass;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000871F File Offset: 0x0000691F
		private static AndroidJavaClass GetProductDetailsParamsClass()
		{
			if (GoogleBillingClient.s_ProductDetailsParamsClass == null)
			{
				GoogleBillingClient.s_ProductDetailsParamsClass = new AndroidJavaClass("com.android.billingclient.api.BillingFlowParams$ProductDetailsParams");
			}
			return GoogleBillingClient.s_ProductDetailsParamsClass;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000873C File Offset: 0x0000693C
		private static AndroidJavaClass GetSubscriptionUpdateParamClass()
		{
			if (GoogleBillingClient.s_SubscriptionUpdateParamsClass == null)
			{
				GoogleBillingClient.s_SubscriptionUpdateParamsClass = new AndroidJavaClass("com.android.billingclient.api.BillingFlowParams$SubscriptionUpdateParams");
			}
			return GoogleBillingClient.s_SubscriptionUpdateParamsClass;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00008759 File Offset: 0x00006959
		private static AndroidJavaClass GetConsumeParamsClass()
		{
			if (GoogleBillingClient.s_ConsumeParamsClass == null)
			{
				GoogleBillingClient.s_ConsumeParamsClass = new AndroidJavaClass("com.android.billingclient.api.ConsumeParams");
			}
			return GoogleBillingClient.s_ConsumeParamsClass;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00008776 File Offset: 0x00006976
		private static AndroidJavaClass GetAcknowledgePurchaseParamsClass()
		{
			if (GoogleBillingClient.s_AcknowledgePurchaseParamsClass == null)
			{
				GoogleBillingClient.s_AcknowledgePurchaseParamsClass = new AndroidJavaClass("com.android.billingclient.api.AcknowledgePurchaseParams");
			}
			return GoogleBillingClient.s_AcknowledgePurchaseParamsClass;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00008793 File Offset: 0x00006993
		private static AndroidJavaClass GetBillingClientClass()
		{
			if (GoogleBillingClient.s_BillingClientClass == null)
			{
				GoogleBillingClient.s_BillingClientClass = new AndroidJavaClass("com.android.billingclient.api.BillingClient");
			}
			return GoogleBillingClient.s_BillingClientClass;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000087B0 File Offset: 0x000069B0
		private static AndroidJavaClass GetPendingPurchasesParamsClass()
		{
			if (GoogleBillingClient.s_PendingPurchasesParamsClass == null)
			{
				GoogleBillingClient.s_PendingPurchasesParamsClass = new AndroidJavaClass("com.android.billingclient.api.PendingPurchasesParams");
			}
			return GoogleBillingClient.s_PendingPurchasesParamsClass;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000087D0 File Offset: 0x000069D0
		private static AndroidJavaObject PendingPurchasesParams()
		{
			AndroidJavaObject result;
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetPendingPurchasesParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
			{
				androidJavaObject.Call<AndroidJavaObject>("enableOneTimeProducts", Array.Empty<object>()).Dispose();
				result = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>());
			}
			return result;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008838 File Offset: 0x00006A38
		private static AndroidJavaClass GetQueryPurchasesParamsClass()
		{
			if (GoogleBillingClient.s_QueryPurchasesParamsClass == null)
			{
				GoogleBillingClient.s_QueryPurchasesParamsClass = new AndroidJavaClass("com.android.billingclient.api.QueryPurchasesParams");
			}
			return GoogleBillingClient.s_QueryPurchasesParamsClass;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008858 File Offset: 0x00006A58
		private static AndroidJavaObject QueryPurchasesParams(string productType)
		{
			AndroidJavaObject result;
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetQueryPurchasesParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
			{
				androidJavaObject.Call<AndroidJavaObject>("setProductType", new object[]
				{
					productType
				}).Dispose();
				result = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>());
			}
			return result;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000088C4 File Offset: 0x00006AC4
		[Preserve]
		internal GoogleBillingClient(IGooglePurchasesUpdatedListener googlePurchasesUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
			this.m_Util = util;
			this.m_TelemetryDiagnostics = telemetryDiagnostics;
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetBillingClientClass().CallStatic<AndroidJavaObject>("newBuilder", new object[]
			{
				UnityActivity.GetCurrentActivity()
			}))
			{
				androidJavaObject.Call<AndroidJavaObject>("setListener", new object[]
				{
					googlePurchasesUpdatedListener
				}).Dispose();
				androidJavaObject.Call<AndroidJavaObject>("enablePendingPurchases", new object[]
				{
					GoogleBillingClient.PendingPurchasesParams()
				}).Dispose();
				this.m_BillingClient = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>());
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00008970 File Offset: 0x00006B70
		public void SetObfuscationAccountId(string obfuscationAccountId)
		{
			this.m_ObfuscatedAccountId = obfuscationAccountId;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00008979 File Offset: 0x00006B79
		public void SetObfuscationProfileId(string obfuscationProfileId)
		{
			this.m_ObfuscatedProfileId = obfuscationProfileId;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00008982 File Offset: 0x00006B82
		public void StartConnection(IBillingClientStateListener billingClientStateListener)
		{
			this.m_BillingClient.Call("startConnection", new object[]
			{
				billingClientStateListener
			});
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000899E File Offset: 0x00006B9E
		public void EndConnection()
		{
			this.m_BillingClient.Call("endConnection", Array.Empty<object>());
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000089B5 File Offset: 0x00006BB5
		public bool IsReady()
		{
			return this.m_BillingClient.Call<bool>("isReady", Array.Empty<object>());
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000089CC File Offset: 0x00006BCC
		public GoogleBillingConnectionState GetConnectionState()
		{
			return (GoogleBillingConnectionState)this.m_BillingClient.Call<int>("getConnectionState", Array.Empty<object>());
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000089E4 File Offset: 0x00006BE4
		public void QueryPurchasesAsync(string productType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse)
		{
			AndroidJavaObject androidJavaObject = GoogleBillingClient.QueryPurchasesParams(productType);
			GooglePurchasesResponseListener googlePurchasesResponseListener = new GooglePurchasesResponseListener(onQueryPurchasesResponse, this.m_Util);
			this.m_BillingClient.Call("queryPurchasesAsync", new object[]
			{
				androidJavaObject,
				googlePurchasesResponseListener
			});
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008A24 File Offset: 0x00006C24
		public void QueryProductDetailsAsync(List<string> products, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction)
		{
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.QueryProductDetailsParams(products, type))
			{
				ProductDetailsResponseListener productDetailsResponseListener = new ProductDetailsResponseListener(onProductDetailsResponseAction, this.m_Util, this.m_TelemetryDiagnostics);
				this.m_BillingClient.Call("queryProductDetailsAsync", new object[]
				{
					androidJavaObject,
					productDetailsResponseListener
				});
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008A88 File Offset: 0x00006C88
		private static AndroidJavaObject QueryProductDetailsParams(List<string> products, string type)
		{
			AndroidJavaObject result;
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetQueryProductDetailsParamsParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
			{
				using (AndroidJavaObject androidJavaObject2 = GoogleBillingClient.QueryProductDetailsParamsProductList(products, type))
				{
					androidJavaObject.Call<AndroidJavaObject>("setProductList", new object[]
					{
						androidJavaObject2
					}).Dispose();
					result = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>());
				}
			}
			return result;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008B10 File Offset: 0x00006D10
		private static AndroidJavaObject QueryProductDetailsParamsProductList(List<string> products, string type)
		{
			return (from product in products
			select GoogleBillingClient.QueryProductDetailsParamsProduct(type, product)).ToList<AndroidJavaObject>().ToJava<AndroidJavaObject>();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008B48 File Offset: 0x00006D48
		private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product)
		{
			AndroidJavaObject result;
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetProductParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
			{
				androidJavaObject.Call<AndroidJavaObject>("setProductId", new object[]
				{
					product
				}).Dispose();
				androidJavaObject.Call<AndroidJavaObject>("setProductType", new object[]
				{
					type
				}).Dispose();
				result = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>());
			}
			return result;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008BCC File Offset: 0x00006DCC
		public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			AndroidJavaObject result;
			using (AndroidJavaObject androidJavaObject = productDetails.Call<AndroidJavaObject>("getSubscriptionOfferDetails", Array.Empty<object>()))
			{
				AndroidJavaObject androidJavaObject2 = (androidJavaObject != null) ? androidJavaObject.Enumerate().ToList<AndroidJavaObject>().FirstOrDefault<AndroidJavaObject>() : null;
				string text = (androidJavaObject2 != null) ? androidJavaObject2.Call<string>("getOfferToken", Array.Empty<object>()) : null;
				using (AndroidJavaObject androidJavaObject3 = GoogleBillingClient.GetProductDetailsParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
				{
					androidJavaObject3.Call<AndroidJavaObject>("setProductDetails", new object[]
					{
						productDetails
					}).Dispose();
					if (text != null)
					{
						androidJavaObject3.Call<AndroidJavaObject>("setOfferToken", new object[]
						{
							text
						}).Dispose();
					}
					using (AndroidJavaObject androidJavaObject4 = androidJavaObject3.Call<AndroidJavaObject>("build", Array.Empty<object>()))
					{
						AndroidJavaObject productDetailsParamsList = new List<AndroidJavaObject>
						{
							androidJavaObject4
						}.ToJava<AndroidJavaObject>();
						result = this.m_BillingClient.Call<AndroidJavaObject>("launchBillingFlow", new object[]
						{
							UnityActivity.GetCurrentActivity(),
							this.MakeBillingFlowParams(productDetailsParamsList, oldPurchaseToken, replacementMode)
						});
					}
				}
			}
			return result;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008D00 File Offset: 0x00006F00
		private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			AndroidJavaObject androidJavaObject = GoogleBillingClient.GetBillingFlowParamClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>());
			androidJavaObject = this.SetObfuscatedAccountIdIfNeeded(androidJavaObject);
			androidJavaObject = this.SetObfuscatedProfileIdIfNeeded(androidJavaObject);
			androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setProductDetailsParamsList", new object[]
			{
				productDetailsParamsList
			});
			if (oldPurchaseToken != null && replacementMode != null)
			{
				AndroidJavaObject androidJavaObject2 = GoogleBillingClient.BuildSubscriptionUpdateParams(oldPurchaseToken, replacementMode.Value);
				androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setSubscriptionUpdateParams", new object[]
				{
					androidJavaObject2
				});
			}
			return androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>());
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00008D8C File Offset: 0x00006F8C
		private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayReplacementMode replacementMode)
		{
			return GoogleBillingClient.GetSubscriptionUpdateParamClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()).Call<AndroidJavaObject>("setSubscriptionReplacementMode", new object[]
			{
				(int)replacementMode
			}).Call<AndroidJavaObject>("setOldPurchaseToken", new object[]
			{
				oldPurchaseToken
			}).Call<AndroidJavaObject>("build", Array.Empty<object>());
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008DE9 File Offset: 0x00006FE9
		private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			if (this.m_ObfuscatedProfileId != null)
			{
				billingFlowParams = billingFlowParams.Call<AndroidJavaObject>("setObfuscatedProfileId", new object[]
				{
					this.m_ObfuscatedProfileId
				});
			}
			return billingFlowParams;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008E10 File Offset: 0x00007010
		private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			if (this.m_ObfuscatedAccountId != null)
			{
				billingFlowParams = billingFlowParams.Call<AndroidJavaObject>("setObfuscatedAccountId", new object[]
				{
					this.m_ObfuscatedAccountId
				});
			}
			return billingFlowParams;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00008E38 File Offset: 0x00007038
		public void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume)
		{
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetConsumeParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
			{
				androidJavaObject.Call<AndroidJavaObject>("setPurchaseToken", new object[]
				{
					purchaseToken
				}).Dispose();
				using (AndroidJavaObject androidJavaObject2 = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>()))
				{
					this.m_BillingClient.Call("consumeAsync", new object[]
					{
						androidJavaObject2,
						new GoogleConsumeResponseListener(onConsume, this.m_Util)
					});
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008EE0 File Offset: 0x000070E0
		public void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge)
		{
			using (AndroidJavaObject androidJavaObject = GoogleBillingClient.GetAcknowledgePurchaseParamsClass().CallStatic<AndroidJavaObject>("newBuilder", Array.Empty<object>()))
			{
				androidJavaObject.Call<AndroidJavaObject>("setPurchaseToken", new object[]
				{
					purchaseToken
				}).Dispose();
				using (AndroidJavaObject androidJavaObject2 = androidJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>()))
				{
					this.m_BillingClient.Call("acknowledgePurchase", new object[]
					{
						androidJavaObject2,
						new GoogleAcknowledgePurchaseListener(onAcknowledge, this.m_Util)
					});
				}
			}
		}

		// Token: 0x040000C4 RID: 196
		private const string k_AndroidProductClassName = "com.android.billingclient.api.QueryProductDetailsParams$Product";

		// Token: 0x040000C5 RID: 197
		private static AndroidJavaClass s_AndroidProductClassName;

		// Token: 0x040000C6 RID: 198
		private const string k_AndroidQueryProductDetailsParamsClassName = "com.android.billingclient.api.QueryProductDetailsParams";

		// Token: 0x040000C7 RID: 199
		private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName;

		// Token: 0x040000C8 RID: 200
		private const string k_AndroidBillingFlowParamClassName = "com.android.billingclient.api.BillingFlowParams";

		// Token: 0x040000C9 RID: 201
		private static AndroidJavaClass s_BillingFlowParamsClass;

		// Token: 0x040000CA RID: 202
		private const string k_AndroidProductDetailsParamsClassName = "com.android.billingclient.api.BillingFlowParams$ProductDetailsParams";

		// Token: 0x040000CB RID: 203
		private static AndroidJavaClass s_ProductDetailsParamsClass;

		// Token: 0x040000CC RID: 204
		private const string k_AndroidSubscriptionUpdateParamClassName = "com.android.billingclient.api.BillingFlowParams$SubscriptionUpdateParams";

		// Token: 0x040000CD RID: 205
		private static AndroidJavaClass s_SubscriptionUpdateParamsClass;

		// Token: 0x040000CE RID: 206
		private const string k_AndroidConsumeParamsClassName = "com.android.billingclient.api.ConsumeParams";

		// Token: 0x040000CF RID: 207
		private static AndroidJavaClass s_ConsumeParamsClass;

		// Token: 0x040000D0 RID: 208
		private const string k_AndroidAcknowledgePurchaseParamsClassName = "com.android.billingclient.api.AcknowledgePurchaseParams";

		// Token: 0x040000D1 RID: 209
		private static AndroidJavaClass s_AcknowledgePurchaseParamsClass;

		// Token: 0x040000D2 RID: 210
		private const string k_AndroidBillingClientClassName = "com.android.billingclient.api.BillingClient";

		// Token: 0x040000D3 RID: 211
		private static AndroidJavaClass s_BillingClientClass;

		// Token: 0x040000D4 RID: 212
		private const string k_AndroidPendingPurchasesParamsClassName = "com.android.billingclient.api.PendingPurchasesParams";

		// Token: 0x040000D5 RID: 213
		private static AndroidJavaClass s_PendingPurchasesParamsClass;

		// Token: 0x040000D6 RID: 214
		private const string k_AndroidQueryPurchasesParamsClassName = "com.android.billingclient.api.QueryPurchasesParams";

		// Token: 0x040000D7 RID: 215
		private static AndroidJavaClass s_QueryPurchasesParamsClass;

		// Token: 0x040000D8 RID: 216
		private readonly AndroidJavaObject m_BillingClient;

		// Token: 0x040000D9 RID: 217
		private string m_ObfuscatedAccountId;

		// Token: 0x040000DA RID: 218
		private string m_ObfuscatedProfileId;

		// Token: 0x040000DB RID: 219
		private readonly IUtil m_Util;

		// Token: 0x040000DC RID: 220
		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;
	}
}
