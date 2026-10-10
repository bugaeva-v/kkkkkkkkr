using System;
using System.IO;
using UnityEngine;

namespace Firebase.Platform.Default
{
	// Token: 0x02000018 RID: 24
	internal class UnityConfigExtensions : AppConfigExtensions
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003954 File Offset: 0x00001B54
		public static IAppConfigExtensions DefaultInstance
		{
			get
			{
				return UnityConfigExtensions._instance;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000396C File Offset: 0x00001B6C
		public override string GetWriteablePath(IFirebaseAppPlatform app)
		{
			return FirebaseHandler.RunOnMainThread<string>(() => Application.persistentDataPath);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000039A4 File Offset: 0x00001BA4
		public override void SetEditorP12FileName(IFirebaseAppPlatform app, string p12Filename)
		{
			string text = FirebaseHandler.RunOnMainThread<string>(() => Application.dataPath);
			string text2 = p12Filename;
			bool flag = !string.IsNullOrEmpty(text2) && !File.Exists(text2);
			if (flag)
			{
				text2 = string.Concat(new string[]
				{
					text,
					Path.DirectorySeparatorChar.ToString(),
					"Editor Default Resources",
					Path.DirectorySeparatorChar.ToString(),
					text2
				});
			}
			bool flag2 = !string.IsNullOrEmpty(text2) && !File.Exists(text2);
			if (flag2)
			{
				FirebaseLogger.LogMessage(PlatformLogLevel.Warning, p12Filename + " was not found.  Also looked in " + text2);
			}
			base.SetEditorP12FileName(app, text2);
		}

		// Token: 0x0400002C RID: 44
		private static UnityConfigExtensions _instance = new UnityConfigExtensions();
	}
}
