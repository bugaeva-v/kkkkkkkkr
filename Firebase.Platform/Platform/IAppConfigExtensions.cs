using System;

namespace Firebase.Platform
{
	// Token: 0x02000007 RID: 7
	internal interface IAppConfigExtensions
	{
		// Token: 0x06000021 RID: 33
		string GetWriteablePath(IFirebaseAppPlatform app);

		// Token: 0x06000022 RID: 34
		void SetDatabaseUrl(IFirebaseAppPlatform app, string databaseUrl);

		// Token: 0x06000023 RID: 35
		string GetDatabaseUrl(IFirebaseAppPlatform app);

		// Token: 0x06000024 RID: 36
		void SetEditorP12Password(IFirebaseAppPlatform app, string p12Password);

		// Token: 0x06000025 RID: 37
		string GetEditorP12Password(IFirebaseAppPlatform app);

		// Token: 0x06000026 RID: 38
		void SetEditorP12FileName(IFirebaseAppPlatform app, string p12Filename);

		// Token: 0x06000027 RID: 39
		string GetEditorP12FileName(IFirebaseAppPlatform app);

		// Token: 0x06000028 RID: 40
		void SetEditorServiceAccountEmail(IFirebaseAppPlatform app, string email);

		// Token: 0x06000029 RID: 41
		string GetEditorServiceAccountEmail(IFirebaseAppPlatform app);

		// Token: 0x0600002A RID: 42
		void SetCertPemFile(IFirebaseAppPlatform app, string certName);

		// Token: 0x0600002B RID: 43
		string GetCertPemFile(IFirebaseAppPlatform app);

		// Token: 0x0600002C RID: 44
		void SetCertUpdateUrl(IFirebaseAppPlatform app, Uri certUrl);

		// Token: 0x0600002D RID: 45
		Uri GetCertUpdateUrl(IFirebaseAppPlatform app);
	}
}
