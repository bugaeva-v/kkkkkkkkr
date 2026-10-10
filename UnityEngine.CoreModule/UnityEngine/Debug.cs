using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200010A RID: 266
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	public class Debug
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x000087CD File Offset: 0x000069CD
		public static ILogger unityLogger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000087D4 File Offset: 0x000069D4
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			bool depthTest = true;
			Debug.DrawLine(start, end, color, duration, depthTest);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000087F0 File Offset: 0x000069F0
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			bool depthTest = true;
			float duration = 0f;
			Debug.DrawLine(start, end, color, duration, depthTest);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00008814 File Offset: 0x00006A14
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end)
		{
			bool depthTest = true;
			float duration = 0f;
			Color white = Color.white;
			Debug.DrawLine(start, end, white, duration, depthTest);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000883B File Offset: 0x00006A3B
		[FreeFunction("DebugDrawLine", IsThreadSafe = true)]
		public static void DrawLine(Vector3 start, Vector3 end, [UnityEngine.Internal.DefaultValue("Color.white")] Color color, [UnityEngine.Internal.DefaultValue("0.0f")] float duration, [UnityEngine.Internal.DefaultValue("true")] bool depthTest)
		{
			Debug.DrawLine_Injected(ref start, ref end, ref color, duration, depthTest);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000884C File Offset: 0x00006A4C
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			bool depthTest = true;
			Debug.DrawRay(start, dir, color, duration, depthTest);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00008868 File Offset: 0x00006A68
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			bool depthTest = true;
			float duration = 0f;
			Debug.DrawRay(start, dir, color, duration, depthTest);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000888C File Offset: 0x00006A8C
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool depthTest = true;
			float duration = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, duration, depthTest);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000088B3 File Offset: 0x00006AB3
		public static void DrawRay(Vector3 start, Vector3 dir, [UnityEngine.Internal.DefaultValue("Color.white")] Color color, [UnityEngine.Internal.DefaultValue("0.0f")] float duration, [UnityEngine.Internal.DefaultValue("true")] bool depthTest)
		{
			Debug.DrawLine(start, start + dir, color, duration, depthTest);
		}

		// Token: 0x0600063E RID: 1598
		[FreeFunction("PauseEditor")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Break();

		// Token: 0x0600063F RID: 1599
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugBreak();

		// Token: 0x06000640 RID: 1600
		[ThreadSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);

		// Token: 0x06000641 RID: 1601 RVA: 0x000088C8 File Offset: 0x00006AC8
		public static void Log(object message)
		{
			Debug.unityLogger.Log(LogType.Log, message);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000088D8 File Offset: 0x00006AD8
		public static void Log(object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Log, message, context);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000088E9 File Offset: 0x00006AE9
		public static void LogFormat(string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Log, format, args);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000088FA File Offset: 0x00006AFA
		public static void LogFormat(Object context, string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Log, context, format, args);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000890C File Offset: 0x00006B0C
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
			DebugLogHandler debugLogHandler = Debug.unityLogger.logHandler as DebugLogHandler;
			bool flag = debugLogHandler == null;
			if (flag)
			{
				Debug.unityLogger.LogFormat(logType, context, format, args);
			}
			else
			{
				bool flag2 = Debug.unityLogger.IsLogTypeAllowed(logType);
				if (flag2)
				{
					debugLogHandler.LogFormat(logType, logOptions, context, format, args);
				}
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00008960 File Offset: 0x00006B60
		public static void LogError(object message)
		{
			Debug.unityLogger.Log(LogType.Error, message);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00008970 File Offset: 0x00006B70
		public static void LogError(object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Error, message, context);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00008981 File Offset: 0x00006B81
		public static void LogErrorFormat(string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Error, format, args);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00008992 File Offset: 0x00006B92
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Error, context, format, args);
		}

		// Token: 0x0600064A RID: 1610
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearDeveloperConsole();

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600064B RID: 1611
		// (set) Token: 0x0600064C RID: 1612
		public static extern bool developerConsoleVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600064D RID: 1613 RVA: 0x000089A4 File Offset: 0x00006BA4
		public static void LogException(Exception exception)
		{
			Debug.unityLogger.LogException(exception, null);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000089B4 File Offset: 0x00006BB4
		public static void LogException(Exception exception, Object context)
		{
			Debug.unityLogger.LogException(exception, context);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000089C4 File Offset: 0x00006BC4
		public static void LogWarning(object message)
		{
			Debug.unityLogger.Log(LogType.Warning, message);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000089D4 File Offset: 0x00006BD4
		public static void LogWarning(object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Warning, message, context);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000089E5 File Offset: 0x00006BE5
		public static void LogWarningFormat(string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Warning, format, args);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000089F6 File Offset: 0x00006BF6
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Warning, context, format, args);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00008A08 File Offset: 0x00006C08
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed");
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00008A30 File Offset: 0x00006C30
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed", context);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00008A58 File Offset: 0x00006C58
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00008A7C File Offset: 0x00006C7C
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00008AA0 File Offset: 0x00006CA0
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00008AC4 File Offset: 0x00006CC4
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00008AE8 File Offset: 0x00006CE8
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00008B0C File Offset: 0x00006D0C
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, Object context, string format, params object[] args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00008B31 File Offset: 0x00006D31
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
			Debug.unityLogger.Log(LogType.Assert, message);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00008B41 File Offset: 0x00006D41
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Assert, message, context);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00008B52 File Offset: 0x00006D52
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, format, args);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00008B63 File Offset: 0x00006D63
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(Object context, string format, params object[] args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600065F RID: 1631
		[NativeProperty(TargetType = TargetType.Field)]
		[StaticAccessor("GetBuildSettings()", StaticAccessorType.Dot)]
		public static extern bool isDebugBuild { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000660 RID: 1632
		[FreeFunction("DeveloperConsole_OpenConsoleFile")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void OpenConsoleFile();

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000661 RID: 1633
		[NativeThrows]
		internal static extern DiagnosticSwitch[] diagnosticSwitches { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000662 RID: 1634 RVA: 0x00008B78 File Offset: 0x00006D78
		internal static DiagnosticSwitch GetDiagnosticSwitch(string name)
		{
			foreach (DiagnosticSwitch diagnosticSwitch in Debug.diagnosticSwitches)
			{
				bool flag = diagnosticSwitch.name == name;
				if (flag)
				{
					return diagnosticSwitch;
				}
			}
			throw new ArgumentException("Could not find DiagnosticSwitch named " + name);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00008BCC File Offset: 0x00006DCC
		[RequiredByNativeCode]
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			bool flag = Debug.unityLogger.logHandler is DebugLogHandler;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					Debug.unityLogger.LogException(exception, obj);
				}
				catch (Exception arg)
				{
					Debug.s_DefaultLogger.LogError(string.Format("Invalid exception thrown from custom {0}.LogException(). Message: {1}", Debug.unityLogger.logHandler.GetType(), arg), obj);
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00008C48 File Offset: 0x00006E48
		[RequiredByNativeCode]
		internal static bool IsLoggingEnabled()
		{
			bool flag = Debug.unityLogger.logHandler is DebugLogHandler;
			bool logEnabled;
			if (flag)
			{
				logEnabled = Debug.unityLogger.logEnabled;
			}
			else
			{
				logEnabled = Debug.s_DefaultLogger.logEnabled;
			}
			return logEnabled;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00008C88 File Offset: 0x00006E88
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)", true)]
		public static void Assert(bool condition, string format, params object[] args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00008CAC File Offset: 0x00006EAC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
		public static ILogger logger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x06000669 RID: 1641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DrawLine_Injected(ref Vector3 start, ref Vector3 end, [UnityEngine.Internal.DefaultValue("Color.white")] ref Color color, [UnityEngine.Internal.DefaultValue("0.0f")] float duration, [UnityEngine.Internal.DefaultValue("true")] bool depthTest);

		// Token: 0x0400037F RID: 895
		internal static readonly ILogger s_DefaultLogger = new Logger(new DebugLogHandler());

		// Token: 0x04000380 RID: 896
		internal static ILogger s_Logger = new Logger(new DebugLogHandler());
	}
}
