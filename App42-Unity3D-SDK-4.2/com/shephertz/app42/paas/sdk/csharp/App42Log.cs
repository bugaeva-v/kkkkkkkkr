using System;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200001D RID: 29
	public class App42Log : MonoBehaviour
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00005E79 File Offset: 0x00004079
		public static bool IsDebug()
		{
			return App42Log.debug;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005E80 File Offset: 0x00004080
		public static void SetDebug(bool debug)
		{
			App42Log.debug = debug;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005E88 File Offset: 0x00004088
		public static void Info(string msg)
		{
			App42Log.Console(msg);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005E90 File Offset: 0x00004090
		public static void Console(string msg)
		{
			if (App42Log.debug)
			{
				Debug.Log(msg);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005E9F File Offset: 0x0000409F
		public static void Error(string msg)
		{
			App42Log.Console(msg);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005EA7 File Offset: 0x000040A7
		public static void Fatal(string msg)
		{
			App42Log.Console(msg);
		}

		// Token: 0x0400006F RID: 111
		private static bool debug;
	}
}
