using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x02000002 RID: 2
	public static class AnalyticsEvent
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void Register(Action<IDictionary<string, object>> action)
		{
			AnalyticsEvent.s_StandardEventCallback = (Action<IDictionary<string, object>>)Delegate.Combine(AnalyticsEvent.s_StandardEventCallback, action);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002067 File Offset: 0x00000267
		public static void Unregister(Action<IDictionary<string, object>> action)
		{
			AnalyticsEvent.s_StandardEventCallback = (Action<IDictionary<string, object>>)Delegate.Remove(AnalyticsEvent.s_StandardEventCallback, action);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		public static string sdkVersion
		{
			get
			{
				return AnalyticsEvent.k_SdkVersion;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000208C File Offset: 0x0000028C
		public static bool debugMode
		{
			get
			{
				return AnalyticsEvent._debugMode;
			}
			set
			{
				AnalyticsEvent._debugMode = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002094 File Offset: 0x00000294
		private static void OnValidationFailed(string message)
		{
			throw new ArgumentException(message);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000209C File Offset: 0x0000029C
		private static void AddCustomEventData(IDictionary<string, object> eventData)
		{
			if (eventData == null)
			{
				return;
			}
			foreach (KeyValuePair<string, object> keyValuePair in eventData)
			{
				if (!AnalyticsEvent.m_EventData.ContainsKey(keyValuePair.Key))
				{
					AnalyticsEvent.m_EventData.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000210C File Offset: 0x0000030C
		public static AnalyticsResult Custom(string eventName, IDictionary<string, object> eventData = null)
		{
			AnalyticsResult analyticsResult = AnalyticsResult.UnsupportedPlatform;
			string text = string.Empty;
			if (string.IsNullOrEmpty(eventName))
			{
				AnalyticsEvent.OnValidationFailed("Custom event name cannot be set to null or an empty string.");
			}
			if (eventData == null)
			{
				analyticsResult = Analytics.CustomEvent(eventName);
			}
			else
			{
				AnalyticsEvent.s_StandardEventCallback(eventData);
				analyticsResult = Analytics.CustomEvent(eventName, eventData);
			}
			if (AnalyticsEvent.debugMode)
			{
				if (eventData == null)
				{
					text += "\n  Event Data (null)";
				}
				else
				{
					text += string.Format("\n  Event Data ({0} params):", eventData.Count);
					foreach (KeyValuePair<string, object> keyValuePair in eventData)
					{
						text += string.Format("\n    Key: '{0}';  Value: '{1}'", keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
			AnalyticsResult analyticsResult2 = analyticsResult;
			if (analyticsResult2 != AnalyticsResult.Ok)
			{
				if (analyticsResult2 != AnalyticsResult.TooManyItems && analyticsResult2 != AnalyticsResult.InvalidData)
				{
					Debug.LogWarningFormat("Unable to send '{0}' event (Result: '{1}').{2}", new object[]
					{
						eventName,
						analyticsResult,
						text
					});
				}
				else
				{
					Debug.LogErrorFormat("Failed to send '{0}' event (Result: '{1}').{2}", new object[]
					{
						eventName,
						analyticsResult,
						text
					});
				}
			}
			else if (AnalyticsEvent.debugMode)
			{
				Debug.LogFormat("Successfully sent '{0}' event (Result: '{1}').{2}", new object[]
				{
					eventName,
					analyticsResult,
					text
				});
			}
			return analyticsResult;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002274 File Offset: 0x00000474
		public static AnalyticsResult AchievementStep(int stepIndex, string achievementId, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("step_index", stepIndex);
			if (string.IsNullOrEmpty(achievementId))
			{
				throw new ArgumentException(achievementId);
			}
			AnalyticsEvent.m_EventData.Add("achievement_id", achievementId);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("achievement_step", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022D4 File Offset: 0x000004D4
		public static AnalyticsResult AchievementUnlocked(string achievementId, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(achievementId))
			{
				throw new ArgumentException(achievementId);
			}
			AnalyticsEvent.m_EventData.Add("achievement_id", achievementId);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("achievement_unlocked", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002314 File Offset: 0x00000514
		public static AnalyticsResult AdComplete(bool rewarded, AdvertisingNetwork network, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			AnalyticsEvent.m_EventData.Add("network", AnalyticsEvent.RenameEnum(network.ToString()));
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_complete", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000238C File Offset: 0x0000058C
		public static AnalyticsResult AdComplete(bool rewarded, string network = null, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			if (!string.IsNullOrEmpty(network))
			{
				AnalyticsEvent.m_EventData.Add("network", network);
			}
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_complete", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002400 File Offset: 0x00000600
		public static AnalyticsResult AdOffer(bool rewarded, AdvertisingNetwork network, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			AnalyticsEvent.m_EventData.Add("network", AnalyticsEvent.RenameEnum(network.ToString()));
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_offer", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002478 File Offset: 0x00000678
		public static AnalyticsResult AdOffer(bool rewarded, string network = null, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			if (!string.IsNullOrEmpty(network))
			{
				AnalyticsEvent.m_EventData.Add("network", network);
			}
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_offer", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000024EC File Offset: 0x000006EC
		public static AnalyticsResult AdSkip(bool rewarded, AdvertisingNetwork network, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			AnalyticsEvent.m_EventData.Add("network", AnalyticsEvent.RenameEnum(network.ToString()));
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002564 File Offset: 0x00000764
		public static AnalyticsResult AdSkip(bool rewarded, string network = null, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			if (!string.IsNullOrEmpty(network))
			{
				AnalyticsEvent.m_EventData.Add("network", network);
			}
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000025D8 File Offset: 0x000007D8
		public static AnalyticsResult AdStart(bool rewarded, AdvertisingNetwork network, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			AnalyticsEvent.m_EventData.Add("network", AnalyticsEvent.RenameEnum(network.ToString()));
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002650 File Offset: 0x00000850
		public static AnalyticsResult AdStart(bool rewarded, string network = null, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			if (!string.IsNullOrEmpty(network))
			{
				AnalyticsEvent.m_EventData.Add("network", network);
			}
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("ad_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000026C1 File Offset: 0x000008C1
		public static AnalyticsResult ChatMessageSent(IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("chat_message_sent", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026E2 File Offset: 0x000008E2
		public static AnalyticsResult CustomEvent(IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002703 File Offset: 0x00000903
		public static AnalyticsResult CutsceneSkip(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("scene_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("cutscene_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002743 File Offset: 0x00000943
		public static AnalyticsResult CutsceneStart(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("scene_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("cutscene_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002783 File Offset: 0x00000983
		public static AnalyticsResult FirstInteraction(string actionId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (!string.IsNullOrEmpty(actionId))
			{
				AnalyticsEvent.m_EventData.Add("action_id", actionId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("first_interaction", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027BC File Offset: 0x000009BC
		public static AnalyticsResult GameOver(int index, string name = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("level_index", index);
			if (!string.IsNullOrEmpty(name))
			{
				AnalyticsEvent.m_EventData.Add("level_name", name);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("game_over", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002815 File Offset: 0x00000A15
		public static AnalyticsResult GameOver(string name = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (!string.IsNullOrEmpty(name))
			{
				AnalyticsEvent.m_EventData.Add("level_name", name);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("game_over", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000284E File Offset: 0x00000A4E
		public static AnalyticsResult GameStart(IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("game_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002870 File Offset: 0x00000A70
		public static AnalyticsResult IAPTransaction(string transactionContext, float price, string itemId, string itemType = null, string level = null, string transactionId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(transactionContext))
			{
				throw new ArgumentException(transactionContext);
			}
			AnalyticsEvent.m_EventData.Add("transaction_context", transactionContext);
			AnalyticsEvent.m_EventData.Add("price", price);
			if (string.IsNullOrEmpty(itemId))
			{
				throw new ArgumentException(itemId);
			}
			AnalyticsEvent.m_EventData.Add("item_id", itemId);
			if (!string.IsNullOrEmpty(itemType))
			{
				AnalyticsEvent.m_EventData.Add("item_type", itemType);
			}
			if (!string.IsNullOrEmpty(level))
			{
				AnalyticsEvent.m_EventData.Add("level", level);
			}
			if (!string.IsNullOrEmpty(transactionId))
			{
				AnalyticsEvent.m_EventData.Add("transaction_id", transactionId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("iap_transaction", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000293C File Offset: 0x00000B3C
		public static AnalyticsResult ItemAcquired(AcquisitionType currencyType, string transactionContext, float amount, string itemId, float balance, string itemType = null, string level = null, string transactionId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("currency_type", AnalyticsEvent.RenameEnum(currencyType.ToString()));
			if (string.IsNullOrEmpty(transactionContext))
			{
				throw new ArgumentException(transactionContext);
			}
			AnalyticsEvent.m_EventData.Add("transaction_context", transactionContext);
			AnalyticsEvent.m_EventData.Add("amount", amount);
			if (string.IsNullOrEmpty(itemId))
			{
				throw new ArgumentException(itemId);
			}
			AnalyticsEvent.m_EventData.Add("item_id", itemId);
			AnalyticsEvent.m_EventData.Add("balance", balance);
			if (!string.IsNullOrEmpty(itemType))
			{
				AnalyticsEvent.m_EventData.Add("item_type", itemType);
			}
			if (!string.IsNullOrEmpty(level))
			{
				AnalyticsEvent.m_EventData.Add("level", level);
			}
			if (!string.IsNullOrEmpty(transactionId))
			{
				AnalyticsEvent.m_EventData.Add("transaction_id", transactionId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("item_acquired", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002A40 File Offset: 0x00000C40
		public static AnalyticsResult ItemAcquired(AcquisitionType currencyType, string transactionContext, float amount, string itemId, string itemType = null, string level = null, string transactionId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("currency_type", AnalyticsEvent.RenameEnum(currencyType.ToString()));
			if (string.IsNullOrEmpty(transactionContext))
			{
				throw new ArgumentException(transactionContext);
			}
			AnalyticsEvent.m_EventData.Add("transaction_context", transactionContext);
			AnalyticsEvent.m_EventData.Add("amount", amount);
			if (string.IsNullOrEmpty(itemId))
			{
				throw new ArgumentException(itemId);
			}
			AnalyticsEvent.m_EventData.Add("item_id", itemId);
			if (!string.IsNullOrEmpty(itemType))
			{
				AnalyticsEvent.m_EventData.Add("item_type", itemType);
			}
			if (!string.IsNullOrEmpty(level))
			{
				AnalyticsEvent.m_EventData.Add("level", level);
			}
			if (!string.IsNullOrEmpty(transactionId))
			{
				AnalyticsEvent.m_EventData.Add("transaction_id", transactionId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("item_acquired", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002B30 File Offset: 0x00000D30
		public static AnalyticsResult ItemSpent(AcquisitionType currencyType, string transactionContext, float amount, string itemId, float balance, string itemType = null, string level = null, string transactionId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("currency_type", AnalyticsEvent.RenameEnum(currencyType.ToString()));
			if (string.IsNullOrEmpty(transactionContext))
			{
				throw new ArgumentException(transactionContext);
			}
			AnalyticsEvent.m_EventData.Add("transaction_context", transactionContext);
			AnalyticsEvent.m_EventData.Add("amount", amount);
			if (string.IsNullOrEmpty(itemId))
			{
				throw new ArgumentException(itemId);
			}
			AnalyticsEvent.m_EventData.Add("item_id", itemId);
			AnalyticsEvent.m_EventData.Add("balance", balance);
			if (!string.IsNullOrEmpty(itemType))
			{
				AnalyticsEvent.m_EventData.Add("item_type", itemType);
			}
			if (!string.IsNullOrEmpty(level))
			{
				AnalyticsEvent.m_EventData.Add("level", level);
			}
			if (!string.IsNullOrEmpty(transactionId))
			{
				AnalyticsEvent.m_EventData.Add("transaction_id", transactionId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("item_spent", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002C34 File Offset: 0x00000E34
		public static AnalyticsResult ItemSpent(AcquisitionType currencyType, string transactionContext, float amount, string itemId, string itemType = null, string level = null, string transactionId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("currency_type", AnalyticsEvent.RenameEnum(currencyType.ToString()));
			if (string.IsNullOrEmpty(transactionContext))
			{
				throw new ArgumentException(transactionContext);
			}
			AnalyticsEvent.m_EventData.Add("transaction_context", transactionContext);
			AnalyticsEvent.m_EventData.Add("amount", amount);
			if (string.IsNullOrEmpty(itemId))
			{
				throw new ArgumentException(itemId);
			}
			AnalyticsEvent.m_EventData.Add("item_id", itemId);
			if (!string.IsNullOrEmpty(itemType))
			{
				AnalyticsEvent.m_EventData.Add("item_type", itemType);
			}
			if (!string.IsNullOrEmpty(level))
			{
				AnalyticsEvent.m_EventData.Add("level", level);
			}
			if (!string.IsNullOrEmpty(transactionId))
			{
				AnalyticsEvent.m_EventData.Add("transaction_id", transactionId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("item_spent", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D21 File Offset: 0x00000F21
		public static AnalyticsResult LevelComplete(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_complete", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D61 File Offset: 0x00000F61
		public static AnalyticsResult LevelComplete(int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_complete", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002D98 File Offset: 0x00000F98
		public static AnalyticsResult LevelComplete(string name, int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_complete", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002DF8 File Offset: 0x00000FF8
		public static AnalyticsResult LevelFail(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_fail", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002E38 File Offset: 0x00001038
		public static AnalyticsResult LevelFail(int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_fail", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002E70 File Offset: 0x00001070
		public static AnalyticsResult LevelFail(string name, int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_fail", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002ED0 File Offset: 0x000010D0
		public static AnalyticsResult LevelQuit(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_quit", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002F10 File Offset: 0x00001110
		public static AnalyticsResult LevelQuit(int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_quit", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002F48 File Offset: 0x00001148
		public static AnalyticsResult LevelQuit(string name, int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_quit", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002FA8 File Offset: 0x000011A8
		public static AnalyticsResult LevelSkip(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002FE8 File Offset: 0x000011E8
		public static AnalyticsResult LevelSkip(int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003020 File Offset: 0x00001220
		public static AnalyticsResult LevelSkip(string name, int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003080 File Offset: 0x00001280
		public static AnalyticsResult LevelStart(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000030C0 File Offset: 0x000012C0
		public static AnalyticsResult LevelStart(int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000030F8 File Offset: 0x000012F8
		public static AnalyticsResult LevelStart(string name, int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("level_name", name);
			AnalyticsEvent.m_EventData.Add("level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003158 File Offset: 0x00001358
		public static AnalyticsResult LevelUp(string name, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("new_level_name", name);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_up", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003198 File Offset: 0x00001398
		public static AnalyticsResult LevelUp(int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("new_level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_up", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000031D0 File Offset: 0x000013D0
		public static AnalyticsResult LevelUp(string name, int index, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(name);
			}
			AnalyticsEvent.m_EventData.Add("new_level_name", name);
			AnalyticsEvent.m_EventData.Add("new_level_index", index);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("level_up", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003230 File Offset: 0x00001430
		public static AnalyticsResult PostAdAction(bool rewarded, AdvertisingNetwork network, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			AnalyticsEvent.m_EventData.Add("network", AnalyticsEvent.RenameEnum(network.ToString()));
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("post_ad_action", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000032A8 File Offset: 0x000014A8
		public static AnalyticsResult PostAdAction(bool rewarded, string network = null, string placementId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("rewarded", rewarded);
			if (!string.IsNullOrEmpty(network))
			{
				AnalyticsEvent.m_EventData.Add("network", network);
			}
			if (!string.IsNullOrEmpty(placementId))
			{
				AnalyticsEvent.m_EventData.Add("placement_id", placementId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("post_ad_action", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003319 File Offset: 0x00001519
		public static AnalyticsResult PushNotificationClick(string message_id, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(message_id))
			{
				throw new ArgumentException(message_id);
			}
			AnalyticsEvent.m_EventData.Add("message_id", message_id);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("push_notification_click", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003359 File Offset: 0x00001559
		public static AnalyticsResult PushNotificationEnable(IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("push_notification_enable", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000337A File Offset: 0x0000157A
		public static AnalyticsResult ScreenVisit(ScreenName screenName, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("screen_name", AnalyticsEvent.RenameEnum(screenName.ToString()));
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("screen_visit", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000033BA File Offset: 0x000015BA
		public static AnalyticsResult ScreenVisit(string screenName, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(screenName))
			{
				throw new ArgumentException(screenName);
			}
			AnalyticsEvent.m_EventData.Add("screen_name", screenName);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("screen_visit", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000033FC File Offset: 0x000015FC
		public static AnalyticsResult SocialShare(ShareType shareType, SocialNetwork socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("share_type", AnalyticsEvent.RenameEnum(shareType.ToString()));
			AnalyticsEvent.m_EventData.Add("social_network", AnalyticsEvent.RenameEnum(socialNetwork.ToString()));
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003498 File Offset: 0x00001698
		public static AnalyticsResult SocialShare(ShareType shareType, string socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("share_type", AnalyticsEvent.RenameEnum(shareType.ToString()));
			if (string.IsNullOrEmpty(socialNetwork))
			{
				throw new ArgumentException(socialNetwork);
			}
			AnalyticsEvent.m_EventData.Add("social_network", socialNetwork);
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003534 File Offset: 0x00001734
		public static AnalyticsResult SocialShare(string shareType, SocialNetwork socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(shareType))
			{
				throw new ArgumentException(shareType);
			}
			AnalyticsEvent.m_EventData.Add("share_type", shareType);
			AnalyticsEvent.m_EventData.Add("social_network", AnalyticsEvent.RenameEnum(socialNetwork.ToString()));
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000035D0 File Offset: 0x000017D0
		public static AnalyticsResult SocialShare(string shareType, string socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(shareType))
			{
				throw new ArgumentException(shareType);
			}
			AnalyticsEvent.m_EventData.Add("share_type", shareType);
			if (string.IsNullOrEmpty(socialNetwork))
			{
				throw new ArgumentException(socialNetwork);
			}
			AnalyticsEvent.m_EventData.Add("social_network", socialNetwork);
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000366C File Offset: 0x0000186C
		public static AnalyticsResult SocialShareAccept(ShareType shareType, SocialNetwork socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("share_type", AnalyticsEvent.RenameEnum(shareType.ToString()));
			AnalyticsEvent.m_EventData.Add("social_network", AnalyticsEvent.RenameEnum(socialNetwork.ToString()));
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share_accept", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003708 File Offset: 0x00001908
		public static AnalyticsResult SocialShareAccept(ShareType shareType, string socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("share_type", AnalyticsEvent.RenameEnum(shareType.ToString()));
			if (string.IsNullOrEmpty(socialNetwork))
			{
				throw new ArgumentException(socialNetwork);
			}
			AnalyticsEvent.m_EventData.Add("social_network", socialNetwork);
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share_accept", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000037A4 File Offset: 0x000019A4
		public static AnalyticsResult SocialShareAccept(string shareType, SocialNetwork socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(shareType))
			{
				throw new ArgumentException(shareType);
			}
			AnalyticsEvent.m_EventData.Add("share_type", shareType);
			AnalyticsEvent.m_EventData.Add("social_network", AnalyticsEvent.RenameEnum(socialNetwork.ToString()));
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share_accept", AnalyticsEvent.m_EventData);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003840 File Offset: 0x00001A40
		public static AnalyticsResult SocialShareAccept(string shareType, string socialNetwork, string senderId = null, string recipientId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(shareType))
			{
				throw new ArgumentException(shareType);
			}
			AnalyticsEvent.m_EventData.Add("share_type", shareType);
			if (string.IsNullOrEmpty(socialNetwork))
			{
				throw new ArgumentException(socialNetwork);
			}
			AnalyticsEvent.m_EventData.Add("social_network", socialNetwork);
			if (!string.IsNullOrEmpty(senderId))
			{
				AnalyticsEvent.m_EventData.Add("sender_id", senderId);
			}
			if (!string.IsNullOrEmpty(recipientId))
			{
				AnalyticsEvent.m_EventData.Add("recipient_id", recipientId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("social_share_accept", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000038DC File Offset: 0x00001ADC
		public static AnalyticsResult StoreItemClick(StoreType storeType, string itemId, string itemName = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("type", AnalyticsEvent.RenameEnum(storeType.ToString()));
			if (string.IsNullOrEmpty(itemId))
			{
				throw new ArgumentException(itemId);
			}
			AnalyticsEvent.m_EventData.Add("item_id", itemId);
			if (!string.IsNullOrEmpty(itemName))
			{
				AnalyticsEvent.m_EventData.Add("item_name", itemName);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("store_item_click", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000395E File Offset: 0x00001B5E
		public static AnalyticsResult StoreOpened(StoreType storeType, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("type", AnalyticsEvent.RenameEnum(storeType.ToString()));
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("store_opened", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000399E File Offset: 0x00001B9E
		public static AnalyticsResult TutorialComplete(string tutorialId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (!string.IsNullOrEmpty(tutorialId))
			{
				AnalyticsEvent.m_EventData.Add("tutorial_id", tutorialId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("tutorial_complete", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000039D7 File Offset: 0x00001BD7
		public static AnalyticsResult TutorialSkip(string tutorialId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (!string.IsNullOrEmpty(tutorialId))
			{
				AnalyticsEvent.m_EventData.Add("tutorial_id", tutorialId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("tutorial_skip", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003A10 File Offset: 0x00001C10
		public static AnalyticsResult TutorialStart(string tutorialId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (!string.IsNullOrEmpty(tutorialId))
			{
				AnalyticsEvent.m_EventData.Add("tutorial_id", tutorialId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("tutorial_start", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003A4C File Offset: 0x00001C4C
		public static AnalyticsResult TutorialStep(int stepIndex, string tutorialId = null, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("step_index", stepIndex);
			if (!string.IsNullOrEmpty(tutorialId))
			{
				AnalyticsEvent.m_EventData.Add("tutorial_id", tutorialId);
			}
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("tutorial_step", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003AA5 File Offset: 0x00001CA5
		public static AnalyticsResult UserSignup(AuthorizationNetwork authorizationNetwork, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			AnalyticsEvent.m_EventData.Add("authorization_network", AnalyticsEvent.RenameEnum(authorizationNetwork.ToString()));
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("user_signup", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003AE5 File Offset: 0x00001CE5
		public static AnalyticsResult UserSignup(string authorizationNetwork, IDictionary<string, object> eventData = null)
		{
			AnalyticsEvent.m_EventData.Clear();
			if (string.IsNullOrEmpty(authorizationNetwork))
			{
				throw new ArgumentException(authorizationNetwork);
			}
			AnalyticsEvent.m_EventData.Add("authorization_network", authorizationNetwork);
			AnalyticsEvent.AddCustomEventData(eventData);
			return AnalyticsEvent.Custom("user_signup", AnalyticsEvent.m_EventData);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003B25 File Offset: 0x00001D25
		private static string RenameEnum(string enumName)
		{
			if (!AnalyticsEvent.enumRenameTable.ContainsKey(enumName))
			{
				return enumName.ToLower();
			}
			return AnalyticsEvent.enumRenameTable[enumName];
		}

		// Token: 0x04000001 RID: 1
		private static readonly string k_SdkVersion = "1.1.1";

		// Token: 0x04000002 RID: 2
		private static Action<IDictionary<string, object>> s_StandardEventCallback = delegate(IDictionary<string, object> param0)
		{
		};

		// Token: 0x04000003 RID: 3
		private static readonly Dictionary<string, object> m_EventData = new Dictionary<string, object>();

		// Token: 0x04000004 RID: 4
		private static bool _debugMode = false;

		// Token: 0x04000005 RID: 5
		private static Dictionary<string, string> enumRenameTable = new Dictionary<string, string>
		{
			{
				"RewardedAd",
				"rewarded_ad"
			},
			{
				"TimedReward",
				"timed_reward"
			},
			{
				"SocialReward",
				"social_reward"
			},
			{
				"MainMenu",
				"main_menu"
			},
			{
				"IAPPromo",
				"iap_promo"
			},
			{
				"CrossPromo",
				"cross_promo"
			},
			{
				"FeaturePromo",
				"feature_promo"
			},
			{
				"TextOnly",
				"text_only"
			}
		};
	}
}
