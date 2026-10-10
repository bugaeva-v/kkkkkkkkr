using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firebase.Analytics
{
	// Token: 0x02000004 RID: 4
	public static class FirebaseAnalytics
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static Task<string> GetAnalyticsInstanceIdAsync()
		{
			return FirebaseAnalyticsInternal.GetAnalyticsInstanceIdAsync();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public static Task<long> GetSessionIdAsync()
		{
			return FirebaseAnalyticsInternal.GetSessionIdAsync();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000207F File Offset: 0x0000027F
		public static void InitiateOnDeviceConversionMeasurementWithEmailAddress(string emailAddress)
		{
			FirebaseAnalyticsInternal.InitiateOnDeviceConversionMeasurementWithEmailAddress(emailAddress);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002089 File Offset: 0x00000289
		public static void InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(byte[] hashedEmailAddress)
		{
			FirebaseAnalyticsInternal.InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(new CharVector(hashedEmailAddress));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		public static void InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(byte[] hashedPhoneNumber)
		{
			FirebaseAnalyticsInternal.InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(new CharVector(hashedPhoneNumber));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A7 File Offset: 0x000002A7
		public static void InitiateOnDeviceConversionMeasurementWithPhoneNumber(string phoneNumber)
		{
			FirebaseAnalyticsInternal.InitiateOnDeviceConversionMeasurementWithPhoneNumber(phoneNumber);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020B1 File Offset: 0x000002B1
		public static void LogEvent(string name, string parameterName, string parameterValue)
		{
			FirebaseAnalyticsInternal.LogEvent(name, parameterName, parameterValue);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020BD File Offset: 0x000002BD
		public static void LogEvent(string name, string parameterName, double parameterValue)
		{
			FirebaseAnalyticsInternal.LogEvent(name, parameterName, parameterValue);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020C9 File Offset: 0x000002C9
		public static void LogEvent(string name, string parameterName, long parameterValue)
		{
			FirebaseAnalyticsInternal.LogEvent(name, parameterName, parameterValue);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020D5 File Offset: 0x000002D5
		public static void LogEvent(string name, string parameterName, int parameterValue)
		{
			FirebaseAnalyticsInternal.LogEvent(name, parameterName, parameterValue);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020E1 File Offset: 0x000002E1
		public static void LogEvent(string name)
		{
			FirebaseAnalyticsInternal.LogEvent(name);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020EC File Offset: 0x000002EC
		public static void LogEvent(string name, params Parameter[] parameters)
		{
			StringList stringList = new StringList();
			VariantList variantList = new VariantList();
			foreach (Parameter parameter in parameters)
			{
				stringList.Add(parameter.Name);
				variantList.Add(Variant.FromObject(parameter.Value));
			}
			FirebaseAnalyticsInternal.LogEvent(name, stringList, variantList);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002148 File Offset: 0x00000348
		public static void ResetAnalyticsData()
		{
			FirebaseAnalyticsInternal.ResetAnalyticsData();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002151 File Offset: 0x00000351
		public static void SetAnalyticsCollectionEnabled(bool enabled)
		{
			FirebaseAnalyticsInternal.SetAnalyticsCollectionEnabled(enabled);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000215C File Offset: 0x0000035C
		public static void SetConsent(IDictionary<ConsentType, ConsentStatus> consentSettings)
		{
			IntIntMap intIntMap = new IntIntMap();
			foreach (KeyValuePair<ConsentType, ConsentStatus> keyValuePair in consentSettings)
			{
				intIntMap[(int)keyValuePair.Key] = (int)keyValuePair.Value;
			}
			FirebaseAnalyticsInternal.SetConsentWithInts(intIntMap);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021C4 File Offset: 0x000003C4
		public static void SetSessionTimeoutDuration(TimeSpan timeSpan)
		{
			FirebaseAnalyticsInternal.SetSessionTimeoutDuration((long)timeSpan.TotalMilliseconds);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021D5 File Offset: 0x000003D5
		public static void SetUserId(string userId)
		{
			FirebaseAnalyticsInternal.SetUserId(userId);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021DF File Offset: 0x000003DF
		public static void SetUserProperty(string name, string property)
		{
			FirebaseAnalyticsInternal.SetUserProperty(name, property);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000021EC File Offset: 0x000003EC
		[Obsolete("Use ParameterGroupID instead.")]
		public static string ParameterGroupId
		{
			get
			{
				return FirebaseAnalytics.ParameterGroupID;
			}
		}

		// Token: 0x04000009 RID: 9
		public static string EventAdImpression = "ad_impression";

		// Token: 0x0400000A RID: 10
		public static string EventAddPaymentInfo = "add_payment_info";

		// Token: 0x0400000B RID: 11
		public static string EventAddShippingInfo = "add_shipping_info";

		// Token: 0x0400000C RID: 12
		public static string EventAddToCart = "add_to_cart";

		// Token: 0x0400000D RID: 13
		public static string EventAddToWishlist = "add_to_wishlist";

		// Token: 0x0400000E RID: 14
		public static string EventAppOpen = "app_open";

		// Token: 0x0400000F RID: 15
		public static string EventBeginCheckout = "begin_checkout";

		// Token: 0x04000010 RID: 16
		public static string EventCampaignDetails = "campaign_details";

		// Token: 0x04000011 RID: 17
		public static string EventEarnVirtualCurrency = "earn_virtual_currency";

		// Token: 0x04000012 RID: 18
		public static string EventGenerateLead = "generate_lead";

		// Token: 0x04000013 RID: 19
		public static string EventJoinGroup = "join_group";

		// Token: 0x04000014 RID: 20
		public static string EventLevelEnd = "level_end";

		// Token: 0x04000015 RID: 21
		public static string EventLevelStart = "level_start";

		// Token: 0x04000016 RID: 22
		public static string EventLevelUp = "level_up";

		// Token: 0x04000017 RID: 23
		public static string EventLogin = "login";

		// Token: 0x04000018 RID: 24
		public static string EventPostScore = "post_score";

		// Token: 0x04000019 RID: 25
		public static string EventPurchase = "purchase";

		// Token: 0x0400001A RID: 26
		public static string EventRefund = "refund";

		// Token: 0x0400001B RID: 27
		public static string EventRemoveFromCart = "remove_from_cart";

		// Token: 0x0400001C RID: 28
		public static string EventScreenView = "screen_view";

		// Token: 0x0400001D RID: 29
		public static string EventSearch = "search";

		// Token: 0x0400001E RID: 30
		public static string EventSelectContent = "select_content";

		// Token: 0x0400001F RID: 31
		public static string EventSelectItem = "select_item";

		// Token: 0x04000020 RID: 32
		public static string EventSelectPromotion = "select_promotion";

		// Token: 0x04000021 RID: 33
		public static string EventShare = "share";

		// Token: 0x04000022 RID: 34
		public static string EventSignUp = "sign_up";

		// Token: 0x04000023 RID: 35
		public static string EventSpendVirtualCurrency = "spend_virtual_currency";

		// Token: 0x04000024 RID: 36
		public static string EventTutorialBegin = "tutorial_begin";

		// Token: 0x04000025 RID: 37
		public static string EventTutorialComplete = "tutorial_complete";

		// Token: 0x04000026 RID: 38
		public static string EventUnlockAchievement = "unlock_achievement";

		// Token: 0x04000027 RID: 39
		public static string EventViewCart = "view_cart";

		// Token: 0x04000028 RID: 40
		public static string EventViewItem = "view_item";

		// Token: 0x04000029 RID: 41
		public static string EventViewItemList = "view_item_list";

		// Token: 0x0400002A RID: 42
		public static string EventViewPromotion = "view_promotion";

		// Token: 0x0400002B RID: 43
		public static string EventViewSearchResults = "view_search_results";

		// Token: 0x0400002C RID: 44
		public static string ParameterAchievementID = "achievement_id";

		// Token: 0x0400002D RID: 45
		public static string ParameterAdFormat = "ad_format";

		// Token: 0x0400002E RID: 46
		public static string ParameterAdNetworkClickID = "aclid";

		// Token: 0x0400002F RID: 47
		public static string ParameterAdPlatform = "ad_platform";

		// Token: 0x04000030 RID: 48
		public static string ParameterAdSource = "ad_source";

		// Token: 0x04000031 RID: 49
		public static string ParameterAdUnitName = "ad_unit_name";

		// Token: 0x04000032 RID: 50
		public static string ParameterAffiliation = "affiliation";

		// Token: 0x04000033 RID: 51
		public static string ParameterCP1 = "cp1";

		// Token: 0x04000034 RID: 52
		public static string ParameterCampaign = "campaign";

		// Token: 0x04000035 RID: 53
		public static string ParameterCampaignID = "campaign_id";

		// Token: 0x04000036 RID: 54
		public static string ParameterCharacter = "character";

		// Token: 0x04000037 RID: 55
		public static string ParameterContent = "content";

		// Token: 0x04000038 RID: 56
		public static string ParameterContentType = "content_type";

		// Token: 0x04000039 RID: 57
		public static string ParameterCoupon = "coupon";

		// Token: 0x0400003A RID: 58
		public static string ParameterCreativeFormat = "creative_format";

		// Token: 0x0400003B RID: 59
		public static string ParameterCreativeName = "creative_name";

		// Token: 0x0400003C RID: 60
		public static string ParameterCreativeSlot = "creative_slot";

		// Token: 0x0400003D RID: 61
		public static string ParameterCurrency = "currency";

		// Token: 0x0400003E RID: 62
		public static string ParameterDestination = "destination";

		// Token: 0x0400003F RID: 63
		public static string ParameterDiscount = "discount";

		// Token: 0x04000040 RID: 64
		public static string ParameterEndDate = "end_date";

		// Token: 0x04000041 RID: 65
		public static string ParameterExtendSession = "extend_session";

		// Token: 0x04000042 RID: 66
		public static string ParameterFlightNumber = "flight_number";

		// Token: 0x04000043 RID: 67
		public static string ParameterGroupID = "group_id";

		// Token: 0x04000044 RID: 68
		public static string ParameterIndex = "index";

		// Token: 0x04000045 RID: 69
		public static string ParameterItemBrand = "item_brand";

		// Token: 0x04000046 RID: 70
		public static string ParameterItemCategory = "item_category";

		// Token: 0x04000047 RID: 71
		public static string ParameterItemCategory2 = "item_category2";

		// Token: 0x04000048 RID: 72
		public static string ParameterItemCategory3 = "item_category3";

		// Token: 0x04000049 RID: 73
		public static string ParameterItemCategory4 = "item_category4";

		// Token: 0x0400004A RID: 74
		public static string ParameterItemCategory5 = "item_category5";

		// Token: 0x0400004B RID: 75
		public static string ParameterItemID = "item_id";

		// Token: 0x0400004C RID: 76
		public static string ParameterItemListID = "item_list_id";

		// Token: 0x0400004D RID: 77
		public static string ParameterItemListName = "item_list_name";

		// Token: 0x0400004E RID: 78
		public static string ParameterItemName = "item_name";

		// Token: 0x0400004F RID: 79
		public static string ParameterItemVariant = "item_variant";

		// Token: 0x04000050 RID: 80
		public static string ParameterItems = "items";

		// Token: 0x04000051 RID: 81
		public static string ParameterLevel = "level";

		// Token: 0x04000052 RID: 82
		public static string ParameterLevelName = "level_name";

		// Token: 0x04000053 RID: 83
		public static string ParameterLocation = "location";

		// Token: 0x04000054 RID: 84
		public static string ParameterLocationID = "location_id";

		// Token: 0x04000055 RID: 85
		public static string ParameterMarketingTactic = "marketing_tactic";

		// Token: 0x04000056 RID: 86
		public static string ParameterMedium = "medium";

		// Token: 0x04000057 RID: 87
		public static string ParameterMethod = "method";

		// Token: 0x04000058 RID: 88
		public static string ParameterNumberOfNights = "number_of_nights";

		// Token: 0x04000059 RID: 89
		public static string ParameterNumberOfPassengers = "number_of_passengers";

		// Token: 0x0400005A RID: 90
		public static string ParameterNumberOfRooms = "number_of_rooms";

		// Token: 0x0400005B RID: 91
		public static string ParameterOrigin = "origin";

		// Token: 0x0400005C RID: 92
		public static string ParameterPaymentType = "payment_type";

		// Token: 0x0400005D RID: 93
		public static string ParameterPrice = "price";

		// Token: 0x0400005E RID: 94
		public static string ParameterPromotionID = "promotion_id";

		// Token: 0x0400005F RID: 95
		public static string ParameterPromotionName = "promotion_name";

		// Token: 0x04000060 RID: 96
		public static string ParameterQuantity = "quantity";

		// Token: 0x04000061 RID: 97
		public static string ParameterScore = "score";

		// Token: 0x04000062 RID: 98
		public static string ParameterScreenClass = "screen_class";

		// Token: 0x04000063 RID: 99
		public static string ParameterScreenName = "screen_name";

		// Token: 0x04000064 RID: 100
		public static string ParameterSearchTerm = "search_term";

		// Token: 0x04000065 RID: 101
		public static string ParameterShipping = "shipping";

		// Token: 0x04000066 RID: 102
		public static string ParameterShippingTier = "shipping_tier";

		// Token: 0x04000067 RID: 103
		public static string ParameterSource = "source";

		// Token: 0x04000068 RID: 104
		public static string ParameterSourcePlatform = "source_platform";

		// Token: 0x04000069 RID: 105
		public static string ParameterStartDate = "start_date";

		// Token: 0x0400006A RID: 106
		public static string ParameterSuccess = "success";

		// Token: 0x0400006B RID: 107
		public static string ParameterTax = "tax";

		// Token: 0x0400006C RID: 108
		public static string ParameterTerm = "term";

		// Token: 0x0400006D RID: 109
		public static string ParameterTransactionID = "transaction_id";

		// Token: 0x0400006E RID: 110
		public static string ParameterTravelClass = "travel_class";

		// Token: 0x0400006F RID: 111
		public static string ParameterValue = "value";

		// Token: 0x04000070 RID: 112
		public static string ParameterVirtualCurrencyName = "virtual_currency_name";

		// Token: 0x04000071 RID: 113
		public static string UserPropertyAllowAdPersonalizationSignals = "allow_personalized_ads";

		// Token: 0x04000072 RID: 114
		public static string UserPropertySignUpMethod = "sign_up_method";
	}
}
