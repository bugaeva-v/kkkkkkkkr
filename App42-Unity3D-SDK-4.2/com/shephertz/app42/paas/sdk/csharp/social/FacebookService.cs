using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.message;

namespace com.shephertz.app42.paas.sdk.csharp.social
{
	// Token: 0x02000045 RID: 69
	public class FacebookService : App42CallBack
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		public FacebookService(App42CallBack callback)
		{
			this.clientCall = callback;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		public void OnSuccess(object obj)
		{
			string payLoad = new QueueResponseBuilder().BuildResponse(obj.ToString()).GetMessageList()[0].GetPayLoad();
			this.clientCall.OnSuccess(payLoad);
			SocialService.isFBOAuthRunning = false;
			SocialService.isStoppedFBOAuth = true;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000F310 File Offset: 0x0000D510
		public void OnException(Exception ex)
		{
			string url = this.GetRequestParams()["resourceURL"].ToString();
			Dictionary<string, string> paramsDics = (Dictionary<string, string>)this.GetRequestParams()["queryParams"];
			Dictionary<string, string> headerParams = (Dictionary<string, string>)this.GetRequestParams()["headerParams"];
			Dictionary<string, string> signParams = new Dictionary<string, string>();
			if (this.counter >= SocialService.MAX_ACCESSTOKEN_ATTEMPT)
			{
				this.clientCall.OnException(ex);
				SocialService.isFBOAuthRunning = false;
				SocialService.isStoppedFBOAuth = true;
				return;
			}
			this.counter++;
			RESTConnectorWWW.GetInstance().ExecuteFBOAuth(url, paramsDics, signParams, headerParams, this);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000F3A9 File Offset: 0x0000D5A9
		public Dictionary<string, object> GetRequestParams()
		{
			return this.sendParams;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000F3B1 File Offset: 0x0000D5B1
		public void SetParams(string paramName, object obj)
		{
			this.sendParams.Add(paramName, obj);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		public static string GetRandomHexString(int numchars)
		{
			Random random = new Random();
			StringBuilder stringBuilder = new StringBuilder();
			while (stringBuilder.Length < numchars)
			{
				stringBuilder.Append(random.Next(0, numchars).ToString("X"));
			}
			return stringBuilder.ToString().Substring(0, numchars);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000F410 File Offset: 0x0000D610
		public static void CheckPermissions(string permission)
		{
			int num = Array.IndexOf<string>(FacebookService.permsArray, permission);
			if (num > -1)
			{
				return;
			}
			App42Log.Console("Permission : \"" + permission + "\" Not Found. Please Choose a Permission from FBPerms.");
			throw new App42Exception("Not a Valid Facebook Permission : \"" + permission + "\"");
		}

		// Token: 0x040000D8 RID: 216
		private App42CallBack clientCall;

		// Token: 0x040000D9 RID: 217
		private Dictionary<string, object> sendParams = new Dictionary<string, object>();

		// Token: 0x040000DA RID: 218
		public int counter;

		// Token: 0x040000DB RID: 219
		public static string[] permsArray = new string[]
		{
			"ads_management",
			"ads_read",
			"bookmarked",
			"create_event",
			"create_note",
			"email",
			"export_stream",
			"friends_about_me",
			"friends_activities",
			"friends_address",
			"friends_birthday",
			"friends_checkins",
			"friends_education_history",
			"friends_events",
			"friends_friends",
			"friends_game_friends",
			"friends_games_activity",
			"friends_groups",
			"friends_hometown",
			"friends_interests",
			"friends_likes",
			"friends_location",
			"friends_mobile_phone",
			"friends_notes",
			"friends_online_presence",
			"friends_photo_video_tags",
			"friends_photos",
			"friends_place_visits",
			"friends_questions",
			"friends_relationship_details",
			"friends_relationships",
			"friends_religion_politics",
			"friends_status",
			"friends_subscriptions",
			"friends_videos",
			"friends_website",
			"friends_work_history",
			"manage_friendlists",
			"manage_groups",
			"manage_notifications",
			"manage_pages",
			"photo_upload",
			"publish_actions",
			"publish_checkins",
			"publish_stream",
			"read_friendlists",
			"read_insights",
			"read_mailbox",
			"read_page_mailboxes",
			"read_requests",
			"read_stream",
			"rsvp_event",
			"share_item",
			"sms",
			"status_update",
			"tab_added",
			"uid",
			"user_about_me",
			"user_activities",
			"user_birthday",
			"user_education_history",
			"user_events",
			"user_friends",
			"user_games_activity",
			"user_hometown",
			"user_interests",
			"user_likes",
			"user_location",
			"user_notes",
			"user_online_presence",
			"user_photo_video_tags",
			"user_photos",
			"user_questions",
			"user_relationship_details",
			"user_relationships",
			"user_religion_politics",
			"user_subscriptions",
			"user_videos",
			"user_website",
			"user_work_history",
			"video_upload",
			"xmpp_login",
			"offline_access",
			"user_checkins"
		};
	}
}
