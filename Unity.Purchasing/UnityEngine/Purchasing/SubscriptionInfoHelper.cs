using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000064 RID: 100
	public class SubscriptionInfoHelper
	{
		// Token: 0x060001BB RID: 443 RVA: 0x000049B4 File Offset: 0x00002BB4
		public SubscriptionInfoHelper(Product product, string introJson)
		{
			this.m_Receipt = product.receipt;
			this.m_ProductId = product.definition.storeSpecificId;
			this.m_IntroJson = introJson;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000049E0 File Offset: 0x00002BE0
		public SubscriptionInfoHelper(string receipt, string id, string introJson)
		{
			this.m_Receipt = receipt;
			this.m_ProductId = id;
			this.m_IntroJson = introJson;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00004A00 File Offset: 0x00002C00
		public SubscriptionInfo GetSubscriptionInfo()
		{
			if (this.m_Receipt != null)
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(this.m_Receipt);
				object obj;
				bool flag = dictionary.TryGetValue("Payload", out obj);
				object obj2;
				bool flag2 = dictionary.TryGetValue("Store", out obj2);
				if (flag && flag2)
				{
					string payload = obj as string;
					string text = obj2 as string;
					if (text == "GooglePlay")
					{
						return SubscriptionInfoHelper.GetGooglePlayStoreSubInfo(payload);
					}
					if (!(text == "AppleAppStore") && !(text == "MacAppStore"))
					{
						throw new StoreSubscriptionInfoNotSupportedException("Store not supported: " + text);
					}
					if (this.m_ProductId == null)
					{
						throw new NullProductIdException();
					}
					return this.GetAppleAppStoreSubInfo(payload, this.m_ProductId);
				}
			}
			throw new NullReceiptException();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00004AC0 File Offset: 0x00002CC0
		private SubscriptionInfo GetAppleAppStoreSubInfo(string payload, string productId)
		{
			AppleReceipt appleReceipt = null;
			ILogger unityLogger = Debug.unityLogger;
			try
			{
				if (string.Empty.Equals(payload))
				{
					unityLogger.LogIAP("Apple receipt is empty. Call `IAppleStoreExtendedPurchaseService.RefreshAppReceipt` to refresh it.");
				}
				else
				{
					appleReceipt = new AppleReceiptParser().Parse(Convert.FromBase64String(payload));
				}
			}
			catch (ArgumentException arg)
			{
				unityLogger.LogIAP(string.Format("Unable to parse Apple receipt: {0}", arg));
			}
			catch (IAPSecurityException arg2)
			{
				unityLogger.LogIAP(string.Format("Unable to parse Apple receipt: {0}", arg2));
			}
			catch (NullReferenceException arg3)
			{
				unityLogger.LogIAP(string.Format("Unable to parse Apple receipt: {0}", arg3));
			}
			List<AppleInAppPurchaseReceipt> list = new List<AppleInAppPurchaseReceipt>();
			if (((appleReceipt != null) ? appleReceipt.inAppPurchaseReceipts : null) != null && appleReceipt.inAppPurchaseReceipts.Length != 0)
			{
				foreach (AppleInAppPurchaseReceipt appleInAppPurchaseReceipt in appleReceipt.inAppPurchaseReceipts)
				{
					if (appleInAppPurchaseReceipt.productID.Equals(productId))
					{
						list.Add(appleInAppPurchaseReceipt);
					}
				}
			}
			if (list.Count != 0)
			{
				return new SubscriptionInfo(SubscriptionInfoHelper.FindMostRecentReceipt(list), this.m_IntroJson);
			}
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004BDC File Offset: 0x00002DDC
		private static AppleInAppPurchaseReceipt FindMostRecentReceipt(List<AppleInAppPurchaseReceipt> receipts)
		{
			receipts.Sort((AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) => a.purchaseDate.CompareTo(b.purchaseDate));
			return receipts[0];
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00004C0C File Offset: 0x00002E0C
		private static SubscriptionInfo GetGooglePlayStoreSubInfo(string payload)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(payload);
			object obj9;
			dictionary.TryGetValue("skuDetails", out obj9);
			List<object> list = obj9 as List<object>;
			IEnumerable<string> enumerable;
			if (list == null)
			{
				enumerable = null;
			}
			else
			{
				enumerable = from obj in list
				select obj as string;
			}
			IEnumerable<string> enumerable2 = enumerable;
			Dictionary<string, object> dictionary2 = (Dictionary<string, object>)MiniJson.JsonDecode((string)dictionary["json"]);
			object obj2;
			bool flag = dictionary2.TryGetValue("autoRenewing", out obj2);
			bool isAutoRenewing = false;
			if (flag)
			{
				isAutoRenewing = (bool)obj2;
			}
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			object obj3;
			bool flag2 = dictionary2.TryGetValue("purchaseTime", out obj3);
			long num = 0L;
			if (flag2)
			{
				num = (long)obj3;
			}
			DateTime purchaseDate = dateTime.AddMilliseconds((double)num);
			object obj4;
			bool flag3 = dictionary2.TryGetValue("developerPayload", out obj4);
			bool isFreeTrial = false;
			bool hasIntroductoryPriceTrial = false;
			string updateMetadata = null;
			if (flag3)
			{
				Dictionary<string, object> dictionary3 = (Dictionary<string, object>)MiniJson.JsonDecode((string)obj4);
				object obj5;
				if (dictionary3.TryGetValue("is_free_trial", out obj5))
				{
					isFreeTrial = (bool)obj5;
				}
				object obj6;
				if (dictionary3.TryGetValue("has_introductory_price_trial", out obj6))
				{
					hasIntroductoryPriceTrial = (bool)obj6;
				}
				object obj7;
				bool flag4 = dictionary3.TryGetValue("is_updated", out obj7);
				bool flag5 = false;
				if (flag4)
				{
					flag5 = (bool)obj7;
				}
				object obj8;
				if (flag5 && dictionary3.TryGetValue("update_subscription_metadata", out obj8))
				{
					updateMetadata = (string)obj8;
				}
			}
			return new SubscriptionInfo((enumerable2 != null) ? enumerable2.First<string>() : null, isAutoRenewing, purchaseDate, isFreeTrial, hasIntroductoryPriceTrial, false, updateMetadata);
		}

		// Token: 0x04000089 RID: 137
		private readonly string m_Receipt;

		// Token: 0x0400008A RID: 138
		private readonly string m_ProductId;

		// Token: 0x0400008B RID: 139
		private readonly string m_IntroJson;
	}
}
