using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005F RID: 95
	public class SubscriptionInfo
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00003E6C File Offset: 0x0000206C
		public SubscriptionInfo(AppleInAppPurchaseReceipt r, string introJson)
		{
			AppleStoreProductType appleStoreProductType = (AppleStoreProductType)Enum.Parse(typeof(AppleStoreProductType), r.productType.ToString());
			if (appleStoreProductType == AppleStoreProductType.Consumable || appleStoreProductType == AppleStoreProductType.NonConsumable)
			{
				throw new InvalidProductTypeException();
			}
			if (!string.IsNullOrEmpty(introJson))
			{
				Dictionary<string, object> dic = (Dictionary<string, object>)MiniJson.JsonDecode(introJson);
				int num = -1;
				SubscriptionPeriodUnit subscriptionPeriodUnit = SubscriptionPeriodUnit.NotAvailable;
				this.m_IntroductoryPrice = dic.TryGetString("introductoryPrice") + dic.TryGetString("introductoryPriceLocale");
				if (string.IsNullOrEmpty(this.m_IntroductoryPrice))
				{
					this.m_IntroductoryPrice = "not available";
				}
				else
				{
					try
					{
						this.m_IntroductoryPriceCycles = Convert.ToInt64(dic.TryGetString("introductoryPriceNumberOfPeriods"));
						num = Convert.ToInt32(dic.TryGetString("numberOfUnits"));
						subscriptionPeriodUnit = (SubscriptionPeriodUnit)Convert.ToInt32(dic.TryGetString("unit"));
					}
					catch (Exception arg)
					{
						Debug.unityLogger.LogIAP("Unable to parse introductory period cycles and duration, " + string.Format("this product does not have configuration of introductory price period: {0}", arg));
						subscriptionPeriodUnit = SubscriptionPeriodUnit.NotAvailable;
					}
				}
				DateTime now = DateTime.Now;
				switch (subscriptionPeriodUnit)
				{
				case SubscriptionPeriodUnit.Day:
					this.m_IntroductoryPricePeriod = TimeSpan.FromTicks(TimeSpan.FromDays(1.0).Ticks * (long)num);
					break;
				case SubscriptionPeriodUnit.Week:
					this.m_IntroductoryPricePeriod = TimeSpan.FromTicks(TimeSpan.FromDays(7.0).Ticks * (long)num);
					break;
				case SubscriptionPeriodUnit.Month:
					this.m_IntroductoryPricePeriod = TimeSpan.FromTicks((now.AddMonths(1) - now).Ticks * (long)num);
					break;
				case SubscriptionPeriodUnit.Year:
					this.m_IntroductoryPricePeriod = TimeSpan.FromTicks((now.AddYears(1) - now).Ticks * (long)num);
					break;
				default:
					this.m_IntroductoryPricePeriod = TimeSpan.Zero;
					this.m_IntroductoryPriceCycles = 0L;
					break;
				}
			}
			else
			{
				this.m_IntroductoryPrice = "not available";
				this.m_IntroductoryPricePeriod = TimeSpan.Zero;
				this.m_IntroductoryPriceCycles = 0L;
			}
			DateTime utcNow = DateTime.UtcNow;
			this.m_PurchaseDate = r.purchaseDate;
			this.m_ProductId = r.productID;
			this.m_SubscriptionExpireDate = r.subscriptionExpirationDate;
			this.m_SubscriptionCancelDate = r.cancellationDate;
			if (appleStoreProductType == AppleStoreProductType.NonRenewingSubscription)
			{
				this.m_IsSubscribed = Result.Unsupported;
				this.m_IsExpired = Result.Unsupported;
				this.m_IsCancelled = Result.Unsupported;
				this.m_IsFreeTrial = Result.Unsupported;
				this.m_IsAutoRenewing = Result.Unsupported;
				this.m_IsIntroductoryPricePeriod = Result.Unsupported;
			}
			else
			{
				this.m_IsCancelled = ((r.cancellationDate.Ticks > 0L && r.cancellationDate.Ticks < utcNow.Ticks) ? Result.True : Result.False);
				this.m_IsSubscribed = ((r.subscriptionExpirationDate.Ticks >= utcNow.Ticks) ? Result.True : Result.False);
				this.m_IsExpired = ((r.subscriptionExpirationDate.Ticks > 0L && r.subscriptionExpirationDate.Ticks < utcNow.Ticks) ? Result.True : Result.False);
				this.m_IsFreeTrial = ((r.isFreeTrial == 1) ? Result.True : Result.False);
				this.m_IsAutoRenewing = ((appleStoreProductType == AppleStoreProductType.AutoRenewingSubscription && this.m_IsCancelled == Result.False && this.m_IsExpired == Result.False) ? Result.True : Result.False);
				this.m_IsIntroductoryPricePeriod = ((r.isIntroductoryPricePeriod == 1) ? Result.True : Result.False);
			}
			this.m_RemainedTime = ((this.m_IsSubscribed == Result.True) ? r.subscriptionExpirationDate.Subtract(utcNow) : TimeSpan.Zero);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000041DC File Offset: 0x000023DC
		public SubscriptionInfo(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(skuDetails);
			object obj = null;
			if (dictionary == null || !dictionary.TryGetValue("type", out obj) || (string)obj == "inapp")
			{
				throw new InvalidProductTypeException();
			}
			object obj2;
			bool flag = dictionary.TryGetValue("productId", out obj2);
			this.m_ProductId = null;
			if (flag)
			{
				this.m_ProductId = (obj2 as string);
			}
			this.m_PurchaseDate = purchaseDate;
			this.m_IsSubscribed = Result.True;
			this.m_IsAutoRenewing = (isAutoRenewing ? Result.True : Result.False);
			this.m_IsExpired = Result.False;
			this.m_IsCancelled = (isAutoRenewing ? Result.False : Result.True);
			this.m_IsFreeTrial = Result.False;
			string text = null;
			if (dictionary.ContainsKey("subscriptionPeriod"))
			{
				text = (string)dictionary["subscriptionPeriod"];
			}
			string text2 = null;
			if (dictionary.ContainsKey("freeTrialPeriod"))
			{
				text2 = (string)dictionary["freeTrialPeriod"];
			}
			string introductoryPrice = null;
			if (dictionary.ContainsKey("introductoryPrice"))
			{
				introductoryPrice = (string)dictionary["introductoryPrice"];
			}
			string text3 = null;
			if (dictionary.ContainsKey("introductoryPricePeriod"))
			{
				text3 = (string)dictionary["introductoryPricePeriod"];
			}
			long introductoryPriceCycles = 0L;
			if (dictionary.ContainsKey("introductoryPriceCycles"))
			{
				introductoryPriceCycles = (long)dictionary["introductoryPriceCycles"];
			}
			this.m_FreeTrialPeriodString = text2;
			this.m_SubscriptionPeriod = SubscriptionInfo.ComputePeriodTimeSpan(SubscriptionInfo.ParsePeriodTimeSpanUnits(text));
			this.m_FreeTrialPeriod = TimeSpan.Zero;
			if (isFreeTrial)
			{
				this.m_FreeTrialPeriod = SubscriptionInfo.ParseTimeSpan(text2);
			}
			this.m_IntroductoryPrice = introductoryPrice;
			this.m_IntroductoryPriceCycles = introductoryPriceCycles;
			this.m_IntroductoryPricePeriod = TimeSpan.Zero;
			this.m_IsIntroductoryPricePeriod = Result.False;
			TimeSpan ts = TimeSpan.Zero;
			if (hasIntroductoryPriceTrial)
			{
				this.m_IntroductoryPricePeriod = ((text3 != null && text3.Equals(text)) ? this.m_SubscriptionPeriod : SubscriptionInfo.ParseTimeSpan(text3));
				ts = SubscriptionInfo.AccumulateIntroductoryDuration(SubscriptionInfo.ParsePeriodTimeSpanUnits(text3), this.m_IntroductoryPriceCycles);
			}
			TimeSpan timeSpan = TimeSpan.FromSeconds((updateMetadata == null) ? 0.0 : SubscriptionInfo.ComputeExtraTime(updateMetadata, this.m_SubscriptionPeriod.TotalSeconds));
			TimeSpan t = DateTime.UtcNow.Subtract(purchaseDate);
			if (t <= timeSpan)
			{
				this.m_SubscriptionExpireDate = purchaseDate.Add(timeSpan);
			}
			else if (t <= this.m_FreeTrialPeriod.Add(timeSpan))
			{
				this.m_IsFreeTrial = Result.True;
				this.m_SubscriptionExpireDate = purchaseDate.Add(this.m_FreeTrialPeriod.Add(timeSpan));
			}
			else if (t < this.m_FreeTrialPeriod.Add(timeSpan).Add(ts))
			{
				this.m_IsIntroductoryPricePeriod = Result.True;
				DateTime billingBeginDate = this.m_PurchaseDate.Add(this.m_FreeTrialPeriod.Add(timeSpan));
				this.m_SubscriptionExpireDate = SubscriptionInfo.NextBillingDate(billingBeginDate, SubscriptionInfo.ParsePeriodTimeSpanUnits(text3));
			}
			else
			{
				DateTime billingBeginDate2 = this.m_PurchaseDate.Add(this.m_FreeTrialPeriod.Add(timeSpan).Add(ts));
				this.m_SubscriptionExpireDate = SubscriptionInfo.NextBillingDate(billingBeginDate2, SubscriptionInfo.ParsePeriodTimeSpanUnits(text));
			}
			this.m_RemainedTime = this.m_SubscriptionExpireDate.Subtract(DateTime.UtcNow);
			this.m_SKUDetails = skuDetails;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004508 File Offset: 0x00002708
		public SubscriptionInfo(string productId)
		{
			this.m_ProductId = productId;
			this.m_IsSubscribed = Result.True;
			this.m_IsExpired = Result.False;
			this.m_IsCancelled = Result.Unsupported;
			this.m_IsFreeTrial = Result.Unsupported;
			this.m_IsAutoRenewing = Result.Unsupported;
			this.m_RemainedTime = TimeSpan.MaxValue;
			this.m_IsIntroductoryPricePeriod = Result.Unsupported;
			this.m_IntroductoryPricePeriod = TimeSpan.MaxValue;
			this.m_IntroductoryPrice = null;
			this.m_IntroductoryPriceCycles = 0L;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004571 File Offset: 0x00002771
		public string GetProductId()
		{
			return this.m_ProductId;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00004579 File Offset: 0x00002779
		[Obsolete("getProductId is deprecated. Please use GetProductId instead.", false)]
		public string getProductId()
		{
			return this.GetProductId();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00004581 File Offset: 0x00002781
		public DateTime GetPurchaseDate()
		{
			return this.m_PurchaseDate;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004589 File Offset: 0x00002789
		[Obsolete("getPurchaseDate is deprecated. Please use GetPurchaseDate instead.", false)]
		public DateTime getPurchaseDate()
		{
			return this.GetPurchaseDate();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004591 File Offset: 0x00002791
		public Result IsSubscribed()
		{
			return this.m_IsSubscribed;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004599 File Offset: 0x00002799
		[Obsolete("isSubscribed is deprecated. Please use IsSubscribed instead.", false)]
		public Result isSubscribed()
		{
			return this.IsSubscribed();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000045A1 File Offset: 0x000027A1
		public Result IsExpired()
		{
			return this.m_IsExpired;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000045A9 File Offset: 0x000027A9
		[Obsolete("isExpired is deprecated. Please use IsExpired instead.", false)]
		public Result isExpired()
		{
			return this.IsExpired();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000045B1 File Offset: 0x000027B1
		public Result IsCancelled()
		{
			return this.m_IsCancelled;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000045B9 File Offset: 0x000027B9
		[Obsolete("isCancelled is deprecated. Please use IsCancelled instead.", false)]
		public Result isCancelled()
		{
			return this.IsCancelled();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000045C1 File Offset: 0x000027C1
		public Result IsFreeTrial()
		{
			return this.m_IsFreeTrial;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000045C9 File Offset: 0x000027C9
		[Obsolete("isFreeTrial is deprecated. Please use IsFreeTrial instead.", false)]
		public Result isFreeTrial()
		{
			return this.IsFreeTrial();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000045D1 File Offset: 0x000027D1
		public Result IsAutoRenewing()
		{
			return this.m_IsAutoRenewing;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000045D9 File Offset: 0x000027D9
		[Obsolete("isAutoRenewing is deprecated. Please use IsAutoRenewing instead.", false)]
		public Result isAutoRenewing()
		{
			return this.IsAutoRenewing();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000045E1 File Offset: 0x000027E1
		public TimeSpan GetRemainingTime()
		{
			return this.m_RemainedTime;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000045E9 File Offset: 0x000027E9
		[Obsolete("getRemainingTime is deprecated. Please use GetRemainingTime instead.", false)]
		public TimeSpan getRemainingTime()
		{
			return this.GetRemainingTime();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000045F1 File Offset: 0x000027F1
		public Result IsIntroductoryPricePeriod()
		{
			return this.m_IsIntroductoryPricePeriod;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000045F9 File Offset: 0x000027F9
		[Obsolete("isIntroductoryPricePeriod is deprecated. Please use IsIntroductoryPricePeriod instead.", false)]
		public Result isIntroductoryPricePeriod()
		{
			return this.IsIntroductoryPricePeriod();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004601 File Offset: 0x00002801
		public TimeSpan GetIntroductoryPricePeriod()
		{
			return this.m_IntroductoryPricePeriod;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004609 File Offset: 0x00002809
		[Obsolete("getIntroductoryPricePeriod is deprecated. Please use GetIntroductoryPricePeriod instead.", false)]
		public TimeSpan getIntroductoryPricePeriod()
		{
			return this.GetIntroductoryPricePeriod();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00004611 File Offset: 0x00002811
		public string GetIntroductoryPrice()
		{
			if (!string.IsNullOrEmpty(this.m_IntroductoryPrice))
			{
				return this.m_IntroductoryPrice;
			}
			return "not available";
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000462C File Offset: 0x0000282C
		[Obsolete("getIntroductoryPrice is deprecated. Please use GetIntroductoryPrice instead.", false)]
		public string getIntroductoryPrice()
		{
			return this.GetIntroductoryPrice();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00004634 File Offset: 0x00002834
		public long GetIntroductoryPricePeriodCycles()
		{
			return this.m_IntroductoryPriceCycles;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000463C File Offset: 0x0000283C
		[Obsolete("getIntroductoryPricePeriodCycles is deprecated. Please use GetIntroductoryPricePeriodCycles instead.", false)]
		public long getIntroductoryPricePeriodCycles()
		{
			return this.GetIntroductoryPricePeriodCycles();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00004644 File Offset: 0x00002844
		public DateTime GetExpireDate()
		{
			return this.m_SubscriptionExpireDate;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000464C File Offset: 0x0000284C
		[Obsolete("getExpireDate is deprecated. Please use GetExpireDate instead.", false)]
		public DateTime getExpireDate()
		{
			return this.GetExpireDate();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00004654 File Offset: 0x00002854
		public DateTime GetCancelDate()
		{
			return this.m_SubscriptionCancelDate;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000465C File Offset: 0x0000285C
		[Obsolete("getCancelDate is deprecated. Please use GetCancelDate instead.", false)]
		public DateTime getCancelDate()
		{
			return this.GetCancelDate();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00004664 File Offset: 0x00002864
		public TimeSpan GetFreeTrialPeriod()
		{
			return this.m_FreeTrialPeriod;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000466C File Offset: 0x0000286C
		[Obsolete("getFreeTrialPeriod is deprecated. Please use GetFreeTrialPeriod instead.", false)]
		public TimeSpan getFreeTrialPeriod()
		{
			return this.GetFreeTrialPeriod();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00004674 File Offset: 0x00002874
		public TimeSpan GetSubscriptionPeriod()
		{
			return this.m_SubscriptionPeriod;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000467C File Offset: 0x0000287C
		[Obsolete("getSubscriptionPeriod is deprecated. Please use GetSubscriptionPeriod instead.", false)]
		public TimeSpan getSubscriptionPeriod()
		{
			return this.GetSubscriptionPeriod();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00004684 File Offset: 0x00002884
		public string GetFreeTrialPeriodString()
		{
			return this.m_FreeTrialPeriodString;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000468C File Offset: 0x0000288C
		[Obsolete("getFreeTrialPeriodString is deprecated. Please use GetFreeTrialPeriodString instead.", false)]
		public string getFreeTrialPeriodString()
		{
			return this.GetFreeTrialPeriodString();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00004694 File Offset: 0x00002894
		public string GetSkuDetails()
		{
			return this.m_SKUDetails;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000469C File Offset: 0x0000289C
		[Obsolete("getSkuDetails is deprecated. Please use GetSkuDetails instead.", false)]
		public string getSkuDetails()
		{
			return this.GetSkuDetails();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000046A4 File Offset: 0x000028A4
		public string GetSubscriptionInfoJsonString()
		{
			return MiniJson.JsonEncode(new Dictionary<string, object>
			{
				{
					"productId",
					this.m_ProductId
				},
				{
					"is_free_trial",
					this.m_IsFreeTrial
				},
				{
					"is_introductory_price_period",
					this.m_IsIntroductoryPricePeriod == Result.True
				},
				{
					"remaining_time_in_seconds",
					this.m_RemainedTime.TotalSeconds
				}
			});
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00004719 File Offset: 0x00002919
		[Obsolete("getSubscriptionInfoJsonString is deprecated. Please use GetSubscriptionInfoJsonString instead.", false)]
		public string getSubscriptionInfoJsonString()
		{
			return this.GetSubscriptionInfoJsonString();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00004724 File Offset: 0x00002924
		private static DateTime NextBillingDate(DateTime billingBeginDate, TimeSpanUnits units)
		{
			if (units.days == 0.0 && units.months == 0 && units.years == 0)
			{
				return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			}
			DateTime dateTime = billingBeginDate;
			while (DateTime.Compare(dateTime, DateTime.UtcNow) <= 0)
			{
				dateTime = dateTime.AddDays(units.days).AddMonths(units.months).AddYears(units.years);
			}
			return dateTime;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000047A4 File Offset: 0x000029A4
		private static TimeSpan AccumulateIntroductoryDuration(TimeSpanUnits units, long cycles)
		{
			TimeSpan result = TimeSpan.Zero;
			for (long num = 0L; num < cycles; num += 1L)
			{
				result = result.Add(SubscriptionInfo.ComputePeriodTimeSpan(units));
			}
			return result;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000047D4 File Offset: 0x000029D4
		private static TimeSpan ComputePeriodTimeSpan(TimeSpanUnits units)
		{
			DateTime now = DateTime.Now;
			return now.AddDays(units.days).AddMonths(units.months).AddYears(units.years).Subtract(now);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000481C File Offset: 0x00002A1C
		private static double ComputeExtraTime(string metadata, double newSKUPeriodInSeconds)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(metadata);
			long num = (long)dictionary["old_sku_remaining_seconds"];
			long num2 = (long)dictionary["old_sku_price_in_micros"];
			double totalSeconds = SubscriptionInfo.ParseTimeSpan((string)dictionary["old_sku_period_string"]).TotalSeconds;
			long num3 = (long)dictionary["new_sku_price_in_micros"];
			return (double)num / totalSeconds * (double)num2 / (double)num3 * newSKUPeriodInSeconds;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00004894 File Offset: 0x00002A94
		private static TimeSpan ParseTimeSpan(string periodString)
		{
			TimeSpan result;
			try
			{
				result = XmlConvert.ToTimeSpan(periodString);
			}
			catch (Exception)
			{
				if (string.IsNullOrEmpty(periodString))
				{
					result = TimeSpan.Zero;
				}
				else
				{
					result = new TimeSpan(7, 0, 0, 0);
				}
			}
			return result;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000048DC File Offset: 0x00002ADC
		private static TimeSpanUnits ParsePeriodTimeSpanUnits(string timeSpan)
		{
			if (timeSpan == "P1W")
			{
				return new TimeSpanUnits(7.0, 0, 0);
			}
			if (timeSpan == "P1M")
			{
				return new TimeSpanUnits(0.0, 1, 0);
			}
			if (timeSpan == "P3M")
			{
				return new TimeSpanUnits(0.0, 3, 0);
			}
			if (timeSpan == "P6M")
			{
				return new TimeSpanUnits(0.0, 6, 0);
			}
			if (!(timeSpan == "P1Y"))
			{
				return new TimeSpanUnits((double)SubscriptionInfo.ParseTimeSpan(timeSpan).Days, 0, 0);
			}
			return new TimeSpanUnits(0.0, 0, 1);
		}

		// Token: 0x04000065 RID: 101
		private readonly Result m_IsSubscribed;

		// Token: 0x04000066 RID: 102
		private readonly Result m_IsExpired;

		// Token: 0x04000067 RID: 103
		private readonly Result m_IsCancelled;

		// Token: 0x04000068 RID: 104
		private readonly Result m_IsFreeTrial;

		// Token: 0x04000069 RID: 105
		private readonly Result m_IsAutoRenewing;

		// Token: 0x0400006A RID: 106
		private readonly Result m_IsIntroductoryPricePeriod;

		// Token: 0x0400006B RID: 107
		private readonly string m_ProductId;

		// Token: 0x0400006C RID: 108
		private readonly DateTime m_PurchaseDate;

		// Token: 0x0400006D RID: 109
		private readonly DateTime m_SubscriptionExpireDate;

		// Token: 0x0400006E RID: 110
		private readonly DateTime m_SubscriptionCancelDate;

		// Token: 0x0400006F RID: 111
		private readonly TimeSpan m_RemainedTime;

		// Token: 0x04000070 RID: 112
		private readonly string m_IntroductoryPrice;

		// Token: 0x04000071 RID: 113
		private readonly TimeSpan m_IntroductoryPricePeriod;

		// Token: 0x04000072 RID: 114
		private readonly long m_IntroductoryPriceCycles;

		// Token: 0x04000073 RID: 115
		private readonly TimeSpan m_FreeTrialPeriod;

		// Token: 0x04000074 RID: 116
		private readonly TimeSpan m_SubscriptionPeriod;

		// Token: 0x04000075 RID: 117
		private readonly string m_FreeTrialPeriodString;

		// Token: 0x04000076 RID: 118
		private readonly string m_SKUDetails;
	}
}
