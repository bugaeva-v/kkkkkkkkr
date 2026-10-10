using System;
using System.Diagnostics;
using UnityEngine;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000036 RID: 54
	internal static class CoreLogger
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00002A74 File Offset: 0x00000C74
		public static void Log(object message)
		{
			UnityEngine.Debug.unityLogger.Log("[ServicesCore]", message);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002A86 File Offset: 0x00000C86
		public static void LogWarning(object message)
		{
			UnityEngine.Debug.unityLogger.LogWarning("[ServicesCore]", message);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002A98 File Offset: 0x00000C98
		public static void LogError(object message)
		{
			UnityEngine.Debug.unityLogger.LogError("[ServicesCore]", message);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002AAA File Offset: 0x00000CAA
		public static void LogException(Exception exception)
		{
			UnityEngine.Debug.unityLogger.Log(LogType.Exception, "[ServicesCore]", exception);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002ABD File Offset: 0x00000CBD
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
			UnityEngine.Debug.unityLogger.Log(LogType.Assert, "[ServicesCore]", message);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002AD0 File Offset: 0x00000CD0
		[Conditional("ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING")]
		public static void LogVerbose(object message)
		{
			UnityEngine.Debug.unityLogger.Log("[ServicesCore]", message);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002AE2 File Offset: 0x00000CE2
		[Conditional("ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING")]
		public static void LogTelemetry(object message)
		{
			UnityEngine.Debug.unityLogger.Log("[ServicesCore]", message);
		}

		// Token: 0x04000034 RID: 52
		internal const string Tag = "[ServicesCore]";

		// Token: 0x04000035 RID: 53
		internal const string VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING";

		// Token: 0x04000036 RID: 54
		private const string k_TelemetryLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING";
	}
}
