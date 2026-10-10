using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000C RID: 12
	internal static class LoggerExtensions
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000022DC File Offset: 0x000004DC
		public static void LogIAP(this ILogger logger, string message)
		{
			logger.Log("InAppPurchasing", message);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000022EA File Offset: 0x000004EA
		public static void LogIAPError(this ILogger logger, string message)
		{
			logger.LogError("InAppPurchasing", message);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022F8 File Offset: 0x000004F8
		public static void LogIAPException(this ILogger logger, Exception exception)
		{
			logger.LogFormat(LogType.Exception, string.Format("{0}: {1}", "InAppPurchasing", exception), Array.Empty<object>());
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002316 File Offset: 0x00000516
		public static void LogIAPWarning(this ILogger logger, string message)
		{
			logger.LogWarning("InAppPurchasing", message);
		}

		// Token: 0x04000007 RID: 7
		private const string k_IAPLogTag = "InAppPurchasing";
	}
}
