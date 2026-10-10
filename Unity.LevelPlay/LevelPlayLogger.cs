using System;
using System.Diagnostics;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200002E RID: 46
	internal static class LevelPlayLogger
	{
		// Token: 0x06000242 RID: 578 RVA: 0x0000607C File Offset: 0x0000427C
		public static void Log(object message)
		{
			Debug.Log(string.Format("{0}: {1}", "[LevelPlay]", message));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00006093 File Offset: 0x00004293
		public static void LogWarning(object message)
		{
			Debug.LogWarning(string.Format("{0}: {1}", "[LevelPlay]", message));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000060AA File Offset: 0x000042AA
		public static void LogError(object message)
		{
			Debug.LogError(string.Format("{0}: {1}", "[LevelPlay]", message));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000060C1 File Offset: 0x000042C1
		public static void LogException(Exception exception)
		{
			if (exception == null)
			{
				Debug.LogException(new Exception("[LevelPlay]: null exception"));
				return;
			}
			Debug.LogException(new Exception(string.Format("{0}: {1}: {2}", "[LevelPlay]", exception.GetType(), exception.Message)));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000060FB File Offset: 0x000042FB
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000060FD File Offset: 0x000042FD
		[Conditional("ENABLE_UNITY_SERVICES_LEVELPLAY_VERBOSE_LOGGING")]
		public static void LogVerbose(object message)
		{
			Debug.Log(string.Format("{0}: {1}", "[LevelPlay]", message));
		}

		// Token: 0x040000E7 RID: 231
		private const string k_Tag = "[LevelPlay]";

		// Token: 0x040000E8 RID: 232
		private const string k_VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_LEVELPLAY_VERBOSE_LOGGING";

		// Token: 0x040000E9 RID: 233
		private const string k_UnityAssertions = "UNITY_ASSERTIONS";
	}
}
