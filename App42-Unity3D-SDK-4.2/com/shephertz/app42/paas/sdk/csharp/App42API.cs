using System;
using System.Collections.Generic;
using com.shephertz.app42.paas.sdk.csharp.abTest;
using com.shephertz.app42.paas.sdk.csharp.achievement;
using com.shephertz.app42.paas.sdk.csharp.app42Event;
using com.shephertz.app42.paas.sdk.csharp.avatar;
using com.shephertz.app42.paas.sdk.csharp.bravoboard;
using com.shephertz.app42.paas.sdk.csharp.buddy;
using com.shephertz.app42.paas.sdk.csharp.customcode;
using com.shephertz.app42.paas.sdk.csharp.email;
using com.shephertz.app42.paas.sdk.csharp.gallery;
using com.shephertz.app42.paas.sdk.csharp.game;
using com.shephertz.app42.paas.sdk.csharp.geo;
using com.shephertz.app42.paas.sdk.csharp.gift;
using com.shephertz.app42.paas.sdk.csharp.imageProcessor;
using com.shephertz.app42.paas.sdk.csharp.log;
using com.shephertz.app42.paas.sdk.csharp.message;
using com.shephertz.app42.paas.sdk.csharp.pushNotification;
using com.shephertz.app42.paas.sdk.csharp.recommend;
using com.shephertz.app42.paas.sdk.csharp.review;
using com.shephertz.app42.paas.sdk.csharp.reward;
using com.shephertz.app42.paas.sdk.csharp.session;
using com.shephertz.app42.paas.sdk.csharp.shopping;
using com.shephertz.app42.paas.sdk.csharp.social;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp.timer;
using com.shephertz.app42.paas.sdk.csharp.upload;
using com.shephertz.app42.paas.sdk.csharp.user;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000012 RID: 18
	public class App42API
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00004690 File Offset: 0x00002890
		public static void SetOfflineStorage(bool enable)
		{
			App42API.offlineStorage = enable;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004698 File Offset: 0x00002898
		public static void SetOfflineStorage(bool enable, int maxRequestsToSave)
		{
			App42API.offlineStorage = enable;
			App42API.offlineRequestsCount = maxRequestsToSave;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000046A6 File Offset: 0x000028A6
		public static int GetMaxRequests()
		{
			return App42API.offlineRequestsCount;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000046AD File Offset: 0x000028AD
		public static void SetDbName(string dbName)
		{
			App42API.dbName = dbName;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000046B5 File Offset: 0x000028B5
		public static string GetDbName()
		{
			return App42API.dbName;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000046BC File Offset: 0x000028BC
		public static void UpdateDeviceInfo(Dictionary<string, object> newDeviceProps)
		{
			App42Log.Console(" Updating Device Info ");
			EventServiceUtils.UpdateDeviceStatus(newDeviceProps);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000046CE File Offset: 0x000028CE
		public static void EnableAppStateEventTracking(bool enable)
		{
			if (enable && !App42API.isAppSessionStarted)
			{
				App42API.isAppSessionStarted = true;
				App42EventTracker.GetInstance().TrackEvent();
				App42API.unlockEventService = true;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000046F0 File Offset: 0x000028F0
		public static void EnableEventService(bool enable)
		{
			if (enable)
			{
				App42API.unlockEventService = true;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000046FB File Offset: 0x000028FB
		public static void EnableCrashEventHandler(bool logEnable)
		{
			if (logEnable)
			{
				Application.RegisterLogCallback(new Application.LogCallback(App42API.HandleLog));
				return;
			}
			Application.RegisterLogCallback(null);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004718 File Offset: 0x00002918
		public static void HandleLog(string logString, string stackTrace, LogType type)
		{
			App42API.output = logString;
			App42API.stack = stackTrace;
			if ((type == LogType.Error || type == LogType.Exception) && App42API.counter < App42API.limit)
			{
				App42API.BuildLogService().Error(App42API.output, "_App42_App_Crash_Event", new HandleLogCallBack());
				App42API.counter++;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004769 File Offset: 0x00002969
		public static string GetInstallationId()
		{
			return App42API.installationId;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004770 File Offset: 0x00002970
		public static HashSet<ACL> GetDefaultACL()
		{
			return App42API.defaultACL;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004777 File Offset: 0x00002977
		public static void SetDefaultACL(HashSet<ACL> defaultACL)
		{
			App42API.defaultACL = defaultACL;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000477F File Offset: 0x0000297F
		public static string GetLoggedInUser()
		{
			return App42API.loggedInUser;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004786 File Offset: 0x00002986
		public static void SetLoggedInUser(string loggedInUser)
		{
			App42API.loggedInUser = loggedInUser;
			if (loggedInUser != null && !loggedInUser.Equals(""))
			{
				Installation.SetLoggedInUser(loggedInUser);
				if (App42API.unlockEventService)
				{
					EventServiceUtils.GetCurrentLoggedInUserProperties(App42API.app42ApiKey, App42API.app42SecretKey);
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000047BA File Offset: 0x000029BA
		public static string GetFBAccsssToken()
		{
			return App42API.fbAccessToken;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000047C1 File Offset: 0x000029C1
		public static void SetFBAccsssToken(string FBAccsssToken)
		{
			App42API.fbAccessToken = FBAccsssToken;
			if (FBAccsssToken != null && !FBAccsssToken.Equals(""))
			{
				Installation.SetFBAccessToken(FBAccsssToken);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000047DF File Offset: 0x000029DF
		public static string GetUserSessionId()
		{
			return App42API.userSessionId;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000047E6 File Offset: 0x000029E6
		public static void SetUserSessionId(string userSessionId)
		{
			App42API.userSessionId = userSessionId;
			if (userSessionId != null && !userSessionId.Equals(""))
			{
				Installation.SetSessionId(userSessionId);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004804 File Offset: 0x00002A04
		public static void RemoveLocalSession()
		{
			App42API.userSessionId = null;
			App42API.loggedInUser = null;
			App42API.fbAccessToken = null;
			if (App42API.userSessionId == null && App42API.loggedInUser == null)
			{
				Installation.RemoveSessionId();
				Installation.RemoveLoggedinUser();
				Installation.RemoveFBAccessToken();
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004835 File Offset: 0x00002A35
		public static void Initialize(string apiKey, string secretKey)
		{
			App42API.app42ApiKey = apiKey;
			App42API.app42SecretKey = secretKey;
			App42API.installationId = Installation.Id();
			App42API.userSessionId = Installation.GetSessionId();
			App42API.loggedInUser = Installation.GetLoggedInUser();
			App42API.fbAccessToken = Installation.GetFBAccessToken();
			EventServiceUtils.FireInstallEvent(apiKey, secretKey);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004872 File Offset: 0x00002A72
		public string GetApiKey()
		{
			return App42API.app42ApiKey;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004879 File Offset: 0x00002A79
		public void SetApiKey(string apiKey)
		{
			App42API.app42ApiKey = apiKey;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004881 File Offset: 0x00002A81
		public string GetSecretKey()
		{
			return App42API.app42SecretKey;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004888 File Offset: 0x00002A88
		public void SetSecretKey(string secretKey)
		{
			App42API.app42SecretKey = secretKey;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004890 File Offset: 0x00002A90
		public string GetBaseURL()
		{
			return App42API.config.GetBaseURL();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000489C File Offset: 0x00002A9C
		public static void SetBaseURL(string protocol, string host, int port)
		{
			App42API.config.SetBaseURL(protocol, host, port);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000048AB File Offset: 0x00002AAB
		public static void SetEventBaseURL(string protocol, string host, int port)
		{
			App42API.config.SetEventBaseURL(protocol, host, port);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000048BA File Offset: 0x00002ABA
		public static void SetEventBaseURL(string url)
		{
			App42API.config.SetEventBaseURL(url);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000048C7 File Offset: 0x00002AC7
		public static void SetBaseURL(string url)
		{
			App42API.config.SetBaseURL(url);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000048D4 File Offset: 0x00002AD4
		public static void SetCustomCodeURL(string url)
		{
			App42API.config.SetCustomCodeURL(url);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000048E4 File Offset: 0x00002AE4
		public static UserService BuildUserService()
		{
			return new UserService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004904 File Offset: 0x00002B04
		public static ReviewService BuildReviewService()
		{
			return new ReviewService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004924 File Offset: 0x00002B24
		public static UploadService BuildUploadService()
		{
			return new UploadService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004944 File Offset: 0x00002B44
		public static SessionService BuildSessionService()
		{
			return new SessionService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004964 File Offset: 0x00002B64
		public static RecommenderService BuildRecommenderService()
		{
			return new RecommenderService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004984 File Offset: 0x00002B84
		public static LogService BuildLogService()
		{
			return new LogService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000049A4 File Offset: 0x00002BA4
		public static PhotoService BuildPhotoService()
		{
			return new PhotoService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000049C4 File Offset: 0x00002BC4
		public static AlbumService BuildAlbumService()
		{
			return new AlbumService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000049E4 File Offset: 0x00002BE4
		public static GameService BuildGameService()
		{
			return new GameService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004A04 File Offset: 0x00002C04
		public static RewardService BuildRewardService()
		{
			return new RewardService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004A24 File Offset: 0x00002C24
		public static ScoreService BuildScoreService()
		{
			return new ScoreService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004A44 File Offset: 0x00002C44
		public static ScoreBoardService BuildScoreBoardService()
		{
			return new ScoreBoardService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004A64 File Offset: 0x00002C64
		public static CartService BuildCartService()
		{
			return new CartService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004A84 File Offset: 0x00002C84
		public static CatalogueService BuildCatalogueService()
		{
			return new CatalogueService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public static ImageProcessorService BuildImageProcessorService()
		{
			return new ImageProcessorService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public static StorageService BuildStorageService()
		{
			return new StorageService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004AE4 File Offset: 0x00002CE4
		public static EmailService BuildEmailService()
		{
			return new EmailService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004B04 File Offset: 0x00002D04
		public static GeoService BuildGeoService()
		{
			return new GeoService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004B24 File Offset: 0x00002D24
		public static SocialService BuildSocialService()
		{
			return new SocialService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004B44 File Offset: 0x00002D44
		public static BuddyService BuildBuddyService()
		{
			return new BuddyService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004B64 File Offset: 0x00002D64
		public static AchievementService BuildAchievementService()
		{
			return new AchievementService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004B84 File Offset: 0x00002D84
		public static AvatarService BuildAvatarService()
		{
			return new AvatarService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public static ABTestService BuildABTestService()
		{
			return new ABTestService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004BC4 File Offset: 0x00002DC4
		public static CustomCodeService BuildCustomCodeService()
		{
			return new CustomCodeService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004BE4 File Offset: 0x00002DE4
		public static QueueService BuildQueueService()
		{
			return new QueueService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004C04 File Offset: 0x00002E04
		public static PushNotificationService BuildPushNotificationService()
		{
			return new PushNotificationService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004C24 File Offset: 0x00002E24
		public static TimerService BuildTimerService()
		{
			return new TimerService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004C44 File Offset: 0x00002E44
		public static GiftService BuildGiftService()
		{
			return new GiftService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004C64 File Offset: 0x00002E64
		public static BravoBoardService BuildBravoBoardService()
		{
			return new BravoBoardService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004C84 File Offset: 0x00002E84
		public static EventService BuildEventService()
		{
			return new EventService(App42API.app42ApiKey, App42API.app42SecretKey);
		}

		// Token: 0x04000034 RID: 52
		public static string app42ApiKey = "";

		// Token: 0x04000035 RID: 53
		private static Config config = Config.GetInstance();

		// Token: 0x04000036 RID: 54
		public static string app42SecretKey = "";

		// Token: 0x04000037 RID: 55
		public static string loggedInUser = "";

		// Token: 0x04000038 RID: 56
		public static string userSessionId = "";

		// Token: 0x04000039 RID: 57
		public static string fbAccessToken = "";

		// Token: 0x0400003A RID: 58
		public static string installationId = "";

		// Token: 0x0400003B RID: 59
		public static string output = "";

		// Token: 0x0400003C RID: 60
		public static string stack;

		// Token: 0x0400003D RID: 61
		public static int counter = 0;

		// Token: 0x0400003E RID: 62
		public static int limit = 5;

		// Token: 0x0400003F RID: 63
		public static string dbName = "";

		// Token: 0x04000040 RID: 64
		internal static bool offlineStorage = false;

		// Token: 0x04000041 RID: 65
		internal static bool isAppSessionStarted = false;

		// Token: 0x04000042 RID: 66
		public static int offlineRequestsCount = 100;

		// Token: 0x04000043 RID: 67
		internal static bool unlockEventService = false;

		// Token: 0x04000044 RID: 68
		public static HashSet<ACL> defaultACL = new HashSet<ACL>();
	}
}
