using System;
using System.Collections.Generic;

namespace Firebase.Platform.Default
{
	// Token: 0x02000016 RID: 22
	internal class AppConfigExtensions : IAppConfigExtensions
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000035D8 File Offset: 0x000017D8
		public static IAppConfigExtensions Instance
		{
			get
			{
				return AppConfigExtensions._instance;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000035EF File Offset: 0x000017EF
		protected AppConfigExtensions()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000035FC File Offset: 0x000017FC
		public virtual string GetWriteablePath(IFirebaseAppPlatform app)
		{
			return string.Empty;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003613 File Offset: 0x00001813
		public virtual void SetDatabaseUrl(IFirebaseAppPlatform app, string databaseUrl)
		{
			AppConfigExtensions.SetState<string>(app, 0, databaseUrl, AppConfigExtensions.SStringState);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003624 File Offset: 0x00001824
		public virtual string GetDatabaseUrl(IFirebaseAppPlatform app)
		{
			string text = AppConfigExtensions.GetState<string>(app, 0, AppConfigExtensions.SStringState);
			bool flag = string.IsNullOrEmpty(text) && app != null;
			if (flag)
			{
				Uri databaseUrl = app.DatabaseUrl;
				text = ((databaseUrl != null) ? databaseUrl.ToString() : null);
			}
			return text;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003673 File Offset: 0x00001873
		public virtual void SetEditorP12Password(IFirebaseAppPlatform app, string p12Password)
		{
			AppConfigExtensions.SetState<string>(app, 2, p12Password, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003684 File Offset: 0x00001884
		public virtual string GetEditorP12Password(IFirebaseAppPlatform app)
		{
			return AppConfigExtensions.GetState<string>(app, 2, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000036A2 File Offset: 0x000018A2
		public virtual void SetEditorP12FileName(IFirebaseAppPlatform app, string p12Filename)
		{
			AppConfigExtensions.SetState<string>(app, 1, p12Filename, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000036B4 File Offset: 0x000018B4
		public virtual string GetEditorP12FileName(IFirebaseAppPlatform app)
		{
			return AppConfigExtensions.GetState<string>(app, 1, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000036D2 File Offset: 0x000018D2
		public virtual void SetEditorServiceAccountEmail(IFirebaseAppPlatform app, string email)
		{
			AppConfigExtensions.SetState<string>(app, 3, email, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000036E4 File Offset: 0x000018E4
		public virtual string GetEditorServiceAccountEmail(IFirebaseAppPlatform app)
		{
			return AppConfigExtensions.GetState<string>(app, 3, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003702 File Offset: 0x00001902
		public virtual void SetCertPemFile(IFirebaseAppPlatform app, string certName)
		{
			AppConfigExtensions.SetState<string>(app, 4, certName, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003714 File Offset: 0x00001914
		public virtual string GetCertPemFile(IFirebaseAppPlatform app)
		{
			return AppConfigExtensions.GetState<string>(app, 4, AppConfigExtensions.SStringState);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003732 File Offset: 0x00001932
		public void SetCertUpdateUrl(IFirebaseAppPlatform app, Uri certUrl)
		{
			AppConfigExtensions.SetState<string>(app, 5, certUrl.ToString(), AppConfigExtensions.SStringState);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003748 File Offset: 0x00001948
		public Uri GetCertUpdateUrl(IFirebaseAppPlatform app)
		{
			string state = AppConfigExtensions.GetState<string>(app, 5, AppConfigExtensions.SStringState);
			bool flag = string.IsNullOrEmpty(state);
			Uri result;
			if (flag)
			{
				result = AppConfigExtensions.DefaultUpdateUrl;
			}
			else
			{
				result = new Uri(state);
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003780 File Offset: 0x00001980
		private static T GetState<T>(IFirebaseAppPlatform app, int state, Dictionary<int, Dictionary<string, T>> store)
		{
			bool flag = app == null;
			if (flag)
			{
				app = FirebaseHandler.AppUtils.GetDefaultInstance();
			}
			object sync = AppConfigExtensions.Sync;
			T result;
			lock (sync)
			{
				string text = app.Name;
				bool flag3 = string.IsNullOrEmpty(text);
				if (flag3)
				{
					text = AppConfigExtensions.Default;
				}
				Dictionary<string, T> dictionary;
				bool flag4 = !store.TryGetValue(state, out dictionary);
				if (flag4)
				{
					dictionary = new Dictionary<string, T>();
					store[state] = dictionary;
				}
				T t;
				bool flag5 = !dictionary.TryGetValue(text, out t);
				if (flag5)
				{
					result = default(T);
				}
				else
				{
					result = t;
				}
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000383C File Offset: 0x00001A3C
		private static void SetState<T>(IFirebaseAppPlatform app, int state, T value, Dictionary<int, Dictionary<string, T>> store)
		{
			bool flag = app == null;
			if (flag)
			{
				app = FirebaseHandler.AppUtils.GetDefaultInstance();
			}
			object sync = AppConfigExtensions.Sync;
			lock (sync)
			{
				string text = app.Name;
				bool flag3 = string.IsNullOrEmpty(text);
				if (flag3)
				{
					text = AppConfigExtensions.Default;
				}
				Dictionary<string, T> dictionary;
				bool flag4 = !store.TryGetValue(state, out dictionary);
				if (flag4)
				{
					dictionary = new Dictionary<string, T>();
					store[state] = dictionary;
				}
				dictionary[text] = value;
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly Uri DefaultUpdateUrl = new Uri("https://www.gstatic.com/firebase/ssl/roots.pem");

		// Token: 0x04000027 RID: 39
		private static readonly string Default = "DEFAULT";

		// Token: 0x04000028 RID: 40
		private static readonly object Sync = new object();

		// Token: 0x04000029 RID: 41
		private static AppConfigExtensions _instance = new AppConfigExtensions();

		// Token: 0x0400002A RID: 42
		private static readonly Dictionary<int, Dictionary<string, string>> SStringState = new Dictionary<int, Dictionary<string, string>>();

		// Token: 0x02000027 RID: 39
		private enum ExtraStringState
		{
			// Token: 0x0400004A RID: 74
			DatabaseUrl,
			// Token: 0x0400004B RID: 75
			P12FileName,
			// Token: 0x0400004C RID: 76
			P12Password,
			// Token: 0x0400004D RID: 77
			ServiceAccountEmail,
			// Token: 0x0400004E RID: 78
			CertTxtFileName,
			// Token: 0x0400004F RID: 79
			WebCertUpdateUrl
		}
	}
}
