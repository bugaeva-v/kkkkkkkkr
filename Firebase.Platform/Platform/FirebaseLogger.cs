using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Firebase.Platform
{
	// Token: 0x02000013 RID: 19
	internal class FirebaseLogger
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003000 File Offset: 0x00001200
		private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType)
		{
			return logType != StackTraceLogType.None && logType != StackTraceLogType.ScriptOnly;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003020 File Offset: 0x00001220
		private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs()
		{
			MethodInfo method = typeof(Application).GetMethod("GetStackTraceLogType");
			bool flag = method != null;
			if (flag)
			{
				LogType[] array = new LogType[5];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.2645F90AC4AC37B7007C26BF8B1EF0A570251899).FieldHandle);
				foreach (LogType logType in array)
				{
					bool flag2 = FirebaseLogger.IsStackTraceLogTypeIncompatibleWithNativeLogs((StackTraceLogType)method.Invoke(null, new object[]
					{
						logType
					}));
					if (flag2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000030AC File Offset: 0x000012AC
		internal static bool CanRedirectNativeLogs
		{
			get
			{
				bool value = FirebaseLogger.incompatibleStackUnwindingEnabled.Value;
				bool result;
				if (value)
				{
					result = false;
				}
				else
				{
					FieldInfo field = typeof(Application).GetField("stackTraceLogType");
					bool flag = field != null;
					if (flag)
					{
						bool flag2 = FirebaseLogger.IsStackTraceLogTypeIncompatibleWithNativeLogs((StackTraceLogType)field.GetValue(null));
						if (flag2)
						{
							return false;
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003110 File Offset: 0x00001310
		internal static void LogMessage(PlatformLogLevel logLevel, string message)
		{
			PlatformLogLevel logLevel2 = FirebaseHandler.AppUtils.GetLogLevel();
			bool flag = logLevel < logLevel2;
			if (!flag)
			{
				switch (logLevel)
				{
				case PlatformLogLevel.Verbose:
				case PlatformLogLevel.Debug:
				case PlatformLogLevel.Info:
					Debug.Log(message);
					break;
				case PlatformLogLevel.Warning:
					Debug.LogWarning(message);
					break;
				case PlatformLogLevel.Error:
					Debug.LogError(message);
					break;
				}
			}
		}

		// Token: 0x04000025 RID: 37
		private static MainThreadProperty<bool> incompatibleStackUnwindingEnabled = new MainThreadProperty<bool>(new Func<bool>(FirebaseLogger.CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs));
	}
}
