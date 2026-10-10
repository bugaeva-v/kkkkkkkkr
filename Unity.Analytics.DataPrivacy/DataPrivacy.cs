using System;
using System.Text;
using UnityEngine.Networking;

namespace UnityEngine.Analytics
{
	// Token: 0x02000002 RID: 2
	public class DataPrivacy
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal static DataPrivacy.UserPostData GetUserData()
		{
			return new DataPrivacy.UserPostData
			{
				appid = Application.cloudProjectId,
				userid = AnalyticsSessionInfo.userId,
				sessionid = AnalyticsSessionInfo.sessionId,
				platform = Application.platform.ToString(),
				platformid = (uint)Application.platform,
				sdk_ver = Application.unityVersion,
				debug_device = Debug.isDebugBuild,
				deviceid = SystemInfo.deviceUniqueIdentifier,
				plugin_ver = "DataPrivacyPackage/3.0.0"
			};
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020E0 File Offset: 0x000002E0
		private static string GetUserAgent()
		{
			return string.Format("UnityPlayer/{0} ({1}/{2}{3} {4})", new object[]
			{
				Application.unityVersion,
				Application.platform.ToString(),
				(uint)Application.platform,
				Debug.isDebugBuild ? "-dev" : "",
				"DataPrivacyPackage/3.0.0"
			});
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002148 File Offset: 0x00000348
		private static string getErrorString(UnityWebRequest www)
		{
			string text = www.downloadHandler.text;
			string text2 = www.error;
			if (string.IsNullOrEmpty(text2))
			{
				text2 = "Empty response";
			}
			if (!string.IsNullOrEmpty(text))
			{
				text2 = text2 + ": " + text;
			}
			return text2;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000218C File Offset: 0x0000038C
		public static void FetchPrivacyUrl(Action<string> success, Action<string> failure = null)
		{
			string s = JsonUtility.ToJson(DataPrivacy.GetUserData());
			UploadHandlerRaw uploadHandlerRaw = new UploadHandlerRaw(Encoding.UTF8.GetBytes(s));
			uploadHandlerRaw.contentType = "application/json";
			UnityWebRequest www = UnityWebRequest.Post("https://data-optout-service.uca.cloud.unity3d.com/token", "");
			www.uploadHandler = uploadHandlerRaw;
			www.SetRequestHeader("User-Agent", DataPrivacy.GetUserAgent());
			www.SendWebRequest().completed += delegate(AsyncOperation async2)
			{
				string text = www.downloadHandler.text;
				if (!string.IsNullOrEmpty(www.error) || string.IsNullOrEmpty(text))
				{
					string errorString = DataPrivacy.getErrorString(www);
					if (failure != null)
					{
						failure(errorString);
						return;
					}
				}
				else
				{
					DataPrivacy.TokenData tokenData;
					tokenData.url = "";
					try
					{
						tokenData = JsonUtility.FromJson<DataPrivacy.TokenData>(text);
					}
					catch (Exception ex)
					{
						if (failure != null)
						{
							failure(ex.ToString());
						}
					}
					success(tokenData.url);
				}
			};
		}

		// Token: 0x04000001 RID: 1
		private const string kVersion = "3.0.0";

		// Token: 0x04000002 RID: 2
		private const string kVersionString = "DataPrivacyPackage/3.0.0";

		// Token: 0x04000003 RID: 3
		internal const string kBaseUrl = "https://data-optout-service.uca.cloud.unity3d.com";

		// Token: 0x04000004 RID: 4
		private const string kTokenUrl = "https://data-optout-service.uca.cloud.unity3d.com/token";

		// Token: 0x02000004 RID: 4
		[Serializable]
		internal struct UserPostData
		{
			// Token: 0x04000006 RID: 6
			public string appid;

			// Token: 0x04000007 RID: 7
			public string userid;

			// Token: 0x04000008 RID: 8
			public long sessionid;

			// Token: 0x04000009 RID: 9
			public string platform;

			// Token: 0x0400000A RID: 10
			public uint platformid;

			// Token: 0x0400000B RID: 11
			public string sdk_ver;

			// Token: 0x0400000C RID: 12
			public bool debug_device;

			// Token: 0x0400000D RID: 13
			public string deviceid;

			// Token: 0x0400000E RID: 14
			public string plugin_ver;
		}

		// Token: 0x02000005 RID: 5
		[Serializable]
		internal struct TokenData
		{
			// Token: 0x0400000F RID: 15
			public string url;

			// Token: 0x04000010 RID: 16
			public string token;
		}
	}
}
