using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Analytics;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000008 RID: 8
	[NullableContext(1)]
	[Nullable(0)]
	internal class CoreAnalyticsAdapter : IAnalyticsAdapter
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000021C8 File Offset: 0x000003C8
		[Preserve]
		internal CoreAnalyticsAdapter(IAnalyticsServiceWrapper analytics, ILogger logger)
		{
			this.m_Logger = logger;
			this.m_TransactionEventHelper = new TransactionEventHelper(analytics, logger);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021E4 File Offset: 0x000003E4
		public void SendTransactionEvent(CartItem item, string receipt)
		{
			IAnalyticsStandardEventComponent analyticsStandardEventComponent = this.CoreAnalyticsComponent();
			if (analyticsStandardEventComponent == null)
			{
				return;
			}
			analyticsStandardEventComponent.Record("transaction", this.BuildTransactionParameters(item, receipt), 1, "com.unity.purchasing");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000220C File Offset: 0x0000040C
		[return: Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private Dictionary<string, object> BuildTransactionParameters(CartItem item, string receipt)
		{
			UnifiedReceipt unifiedReceipt = JsonUtility.FromJson<UnifiedReceipt>(receipt);
			AnalyticsTransactionReceipt analyticsTransactionReceipt = unifiedReceipt.ToReceiptAndSignature();
			return new Dictionary<string, object>
			{
				{
					"transactionID",
					unifiedReceipt.TransactionID
				},
				{
					"transactionName",
					CommonTransactionEventHelper.GetTransactionName(item.Product)
				},
				{
					"transactionReceipt",
					analyticsTransactionReceipt.transactionReceipt
				},
				{
					"transactionReceiptSignature",
					analyticsTransactionReceipt.transactionReceiptSignature
				},
				{
					"transactionServer",
					analyticsTransactionReceipt.transactionServer
				},
				{
					"transactionType",
					TransactionType.PURCHASE
				},
				{
					"productID",
					item.Product.definition.storeSpecificId
				},
				{
					"productsSpent",
					this.GenerateRealCurrencySpentOnPurchase(item.Product)
				},
				{
					"productsReceived",
					CoreAnalyticsAdapter.GenerateItemReceivedForPurchase(item)
				}
			};
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022DF File Offset: 0x000004DF
		public void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription)
		{
			IAnalyticsStandardEventComponent analyticsStandardEventComponent = this.CoreAnalyticsComponent();
			if (analyticsStandardEventComponent == null)
			{
				return;
			}
			analyticsStandardEventComponent.Record("transactionFailed", this.BuildTransactionFailedParameters(failureDescription.product, TransactionFailedEventHelper.BuildFailureReason(failureDescription)), 1, "com.unity.purchasing");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002314 File Offset: 0x00000514
		[NullableContext(2)]
		private IAnalyticsStandardEventComponent CoreAnalyticsComponent()
		{
			IAnalyticsStandardEventComponent analyticsStandardEventComponent2;
			try
			{
				IAnalyticsStandardEventComponent analyticsStandardEventComponent;
				if ((analyticsStandardEventComponent = this.m_CoreAnalytics) == null)
				{
					analyticsStandardEventComponent2 = (this.m_CoreAnalytics = CoreRegistry.Instance.GetServiceComponent<IAnalyticsStandardEventComponent>());
					analyticsStandardEventComponent = analyticsStandardEventComponent2;
				}
				analyticsStandardEventComponent2 = analyticsStandardEventComponent;
			}
			catch (KeyNotFoundException)
			{
				analyticsStandardEventComponent2 = null;
			}
			return analyticsStandardEventComponent2;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002358 File Offset: 0x00000558
		private Dictionary<string, object> BuildTransactionFailedParameters(CartItem item, string failureReason)
		{
			return new Dictionary<string, object>
			{
				{
					"transactionName",
					CommonTransactionEventHelper.GetTransactionName(item.Product)
				},
				{
					"transactionType",
					TransactionType.PURCHASE
				},
				{
					"productID",
					item.Product.definition.storeSpecificId
				},
				{
					"failureReason",
					failureReason
				},
				{
					"productsSpent",
					this.GenerateRealCurrencySpentOnPurchase(item.Product)
				},
				{
					"productsReceived",
					CoreAnalyticsAdapter.GenerateItemReceivedForPurchase(item)
				}
			};
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023E0 File Offset: 0x000005E0
		private static Dictionary<string, object> GenerateItemReceivedForPurchase(CartItem item)
		{
			return new Dictionary<string, object>
			{
				{
					"items",
					new List<object>
					{
						new Dictionary<string, object>
						{
							{
								"item",
								new Dictionary<string, object>
								{
									{
										"itemName",
										item.Product.definition.id
									},
									{
										"itemAmount",
										item.Quantity
									},
									{
										"itemType",
										item.Product.definition.type.ToString()
									}
								}
							}
						}
					}
				}
			};
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002477 File Offset: 0x00000677
		private Dictionary<string, object> GenerateRealCurrencySpentOnPurchase(Product product)
		{
			return new Dictionary<string, object>
			{
				{
					"realCurrency",
					this.CreateRealCurrencyFromProduct(product)
				}
			};
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002490 File Offset: 0x00000690
		private Dictionary<string, object> CreateRealCurrencyFromProduct(Product product)
		{
			return new Dictionary<string, object>
			{
				{
					"realCurrencyAmount",
					this.m_TransactionEventHelper.CheckCurrencyCodeAndExtractRealCurrencyAmount(product)
				},
				{
					"realCurrencyType",
					product.metadata.isoCurrencyCode ?? ""
				}
			};
		}

		// Token: 0x04000004 RID: 4
		private readonly ILogger m_Logger;

		// Token: 0x04000005 RID: 5
		[Nullable(2)]
		private IAnalyticsStandardEventComponent m_CoreAnalytics;

		// Token: 0x04000006 RID: 6
		private const string k_TransactionEventName = "transaction";

		// Token: 0x04000007 RID: 7
		private const string k_TransactionFailedEventName = "transactionFailed";

		// Token: 0x04000008 RID: 8
		private const string k_PurchasingPackageName = "com.unity.purchasing";

		// Token: 0x04000009 RID: 9
		private const int k_TransactionEventVersion = 1;

		// Token: 0x0400000A RID: 10
		private const int k_TransactionFailedEventVersion = 1;

		// Token: 0x0400000B RID: 11
		private TransactionEventHelper m_TransactionEventHelper;
	}
}
