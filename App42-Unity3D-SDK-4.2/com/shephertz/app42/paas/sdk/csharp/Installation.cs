using System;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000061 RID: 97
	public class Installation
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x0001477C File Offset: 0x0001297C
		public static string Id()
		{
			Guid guid = Guid.NewGuid();
			try
			{
				if (PlayerPrefs.HasKey(Installation.installKey))
				{
					return PlayerPrefs.GetString(Installation.installKey);
				}
				PlayerPrefs.SetString(Installation.installKey, guid.ToString());
				PlayerPrefs.Save();
			}
			catch (PlayerPrefsException arg)
			{
				App42Log.Console("Exception while generating installtion id  : " + arg);
			}
			catch (Exception arg2)
			{
				App42Log.Console("Exception while generating installtion id  : " + arg2);
			}
			return guid.ToString();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00014818 File Offset: 0x00012A18
		public static void SetSessionId(string sessionId)
		{
			try
			{
				PlayerPrefs.SetString(Installation.loggedInSessionId, sessionId);
				PlayerPrefs.Save();
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception While Setting SessionId at Installation.SetSessionId : " + ex.Message);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00014860 File Offset: 0x00012A60
		public static string GetSessionId()
		{
			if (PlayerPrefs.HasKey(Installation.loggedInSessionId) && PlayerPrefs.GetString(Installation.loggedInSessionId) != null && !PlayerPrefs.GetString(Installation.loggedInSessionId).Equals(""))
			{
				return PlayerPrefs.GetString(Installation.loggedInSessionId);
			}
			return "";
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000148A0 File Offset: 0x00012AA0
		public static void RemoveSessionId()
		{
			try
			{
				if (PlayerPrefs.HasKey(Installation.loggedInSessionId))
				{
					PlayerPrefs.DeleteKey(Installation.loggedInSessionId);
				}
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception While Removing SessionId at Installation.RemoveSessionId : " + ex.Message);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000148F0 File Offset: 0x00012AF0
		public static void SetLoggedInUser(string loggedInUserName)
		{
			try
			{
				PlayerPrefs.SetString(Installation.loggedInUser, loggedInUserName);
				PlayerPrefs.Save();
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception While Setting LoggedInUserName at Installation.SetLoggedInUser : " + ex.Message);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00014938 File Offset: 0x00012B38
		public static string GetLoggedInUser()
		{
			if (PlayerPrefs.HasKey(Installation.loggedInUser) && PlayerPrefs.GetString(Installation.loggedInUser) != null && !PlayerPrefs.GetString(Installation.loggedInUser).Equals(""))
			{
				return PlayerPrefs.GetString(Installation.loggedInUser);
			}
			return "";
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00014978 File Offset: 0x00012B78
		public static void RemoveLoggedinUser()
		{
			try
			{
				if (PlayerPrefs.HasKey(Installation.loggedInUser))
				{
					PlayerPrefs.DeleteKey(Installation.loggedInUser);
				}
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception While Removing LoggedinUser at Installation.RemoveLoggedinUser : " + ex.Message);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000149C8 File Offset: 0x00012BC8
		public static void SetFBAccessToken(string FBAccessToken)
		{
			try
			{
				PlayerPrefs.SetString(Installation.fbAccessToken, FBAccessToken);
				PlayerPrefs.Save();
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception While Setting LoggedInUserName at Installation.SetFbAccessToken : " + ex.Message);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00014A10 File Offset: 0x00012C10
		public static string GetFBAccessToken()
		{
			if (PlayerPrefs.HasKey(Installation.fbAccessToken) && PlayerPrefs.GetString(Installation.fbAccessToken) != null && !PlayerPrefs.GetString(Installation.fbAccessToken).Equals(""))
			{
				return PlayerPrefs.GetString(Installation.fbAccessToken);
			}
			return "";
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00014A50 File Offset: 0x00012C50
		public static void RemoveFBAccessToken()
		{
			try
			{
				if (PlayerPrefs.HasKey(Installation.fbAccessToken))
				{
					PlayerPrefs.DeleteKey(Installation.fbAccessToken);
				}
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception While Removing LoggedinUser at Installation.RemoveFbAccessToken : " + ex.Message);
			}
		}

		// Token: 0x04000182 RID: 386
		public static string installKey = "Installation";

		// Token: 0x04000183 RID: 387
		private static string loggedInSessionId = "SessionId";

		// Token: 0x04000184 RID: 388
		private static string loggedInUser = "LoggedInUser";

		// Token: 0x04000185 RID: 389
		private static string fbAccessToken = "_fbAccessToken";
	}
}
