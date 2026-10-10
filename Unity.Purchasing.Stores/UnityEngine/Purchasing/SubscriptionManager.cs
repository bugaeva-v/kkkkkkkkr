using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004C RID: 76
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class SubscriptionManager : SubscriptionInfoHelper
	{
		// Token: 0x060001DC RID: 476 RVA: 0x00007B68 File Offset: 0x00005D68
		public static void UpdateSubscription(Product newProduct, Product oldProduct, string developerPayload, Action<Product, string> appleStore, Action<string, string> googleStore)
		{
			if (oldProduct.receipt == null)
			{
				Debug.unityLogger.LogIAPError("The product has not been purchased, a subscription can only be upgrade/downgrade when has already been purchased");
				return;
			}
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(oldProduct.receipt);
			if (dictionary == null || !dictionary.ContainsKey("Store") || !dictionary.ContainsKey("Payload"))
			{
				Debug.unityLogger.LogIAPWarning("The product receipt does not contain enough information");
				return;
			}
			string a = (string)dictionary["Store"];
			if ((string)dictionary["Payload"] != null)
			{
				if (a == "GooglePlay")
				{
					SubscriptionManager subscriptionManager = new SubscriptionManager(oldProduct, null);
					SubscriptionInfo subscriptionInfo;
					try
					{
						subscriptionInfo = subscriptionManager.getSubscriptionInfo();
					}
					catch (Exception arg)
					{
						Debug.unityLogger.LogIAPError("The product that will be updated does not have a " + string.Format("valid receipt: {0}", arg));
						return;
					}
					string storeSpecificId = newProduct.definition.storeSpecificId;
					googleStore(subscriptionInfo.GetSubscriptionInfoJsonString(), storeSpecificId);
					return;
				}
				if (!(a == "AppleAppStore") && !(a == "MacAppStore"))
				{
					Debug.unityLogger.LogIAPWarning("This store does not support update subscriptions");
					return;
				}
				appleStore(newProduct, developerPayload);
				return;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00007C98 File Offset: 0x00005E98
		public static void UpdateSubscriptionInGooglePlayStore(Product oldProduct, Product newProduct, Action<string, string> googlePlayUpdateCallback)
		{
			SubscriptionManager subscriptionManager = new SubscriptionManager(oldProduct, null);
			SubscriptionInfo subscriptionInfo;
			try
			{
				subscriptionInfo = subscriptionManager.getSubscriptionInfo();
			}
			catch (Exception arg)
			{
				Debug.unityLogger.LogIAPError("The product that will be updated does not have a valid " + string.Format("receipt: {0}", arg));
				return;
			}
			string storeSpecificId = newProduct.definition.storeSpecificId;
			googlePlayUpdateCallback(subscriptionInfo.GetSubscriptionInfoJsonString(), storeSpecificId);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007D04 File Offset: 0x00005F04
		public static void UpdateSubscriptionInAppleStore(Product newProduct, string developerPayload, Action<Product, string> appleStoreUpdateCallback)
		{
			appleStoreUpdateCallback(newProduct, developerPayload);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007D0E File Offset: 0x00005F0E
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public SubscriptionManager(Product product, string intro_json) : base(product, intro_json)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007D18 File Offset: 0x00005F18
		public SubscriptionManager(string receipt, string id, string intro_json) : base(receipt, id, intro_json)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007D23 File Offset: 0x00005F23
		public SubscriptionInfo getSubscriptionInfo()
		{
			return base.GetSubscriptionInfo();
		}
	}
}
