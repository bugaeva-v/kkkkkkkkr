using System;

namespace com.shephertz.app42.paas.sdk.csharp.social
{
	// Token: 0x02000046 RID: 70
	public sealed class FBPerms
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x0000F75E File Offset: 0x0000D95E
		private FBPerms(string value)
		{
			this.value = value;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000F76D File Offset: 0x0000D96D
		public string GetValue()
		{
			return this.value;
		}

		// Token: 0x040000DC RID: 220
		public static readonly string ads_management = "ads_management";

		// Token: 0x040000DD RID: 221
		public static readonly string ads_read = "ads_read";

		// Token: 0x040000DE RID: 222
		public static readonly string bookmarked = "bookmarked";

		// Token: 0x040000DF RID: 223
		public static readonly string create_event = "create_event";

		// Token: 0x040000E0 RID: 224
		public static readonly string create_note = "create_note";

		// Token: 0x040000E1 RID: 225
		public static readonly string email = "email";

		// Token: 0x040000E2 RID: 226
		public static readonly string export_stream = "export_stream";

		// Token: 0x040000E3 RID: 227
		public static readonly string friends_about_me = "friends_about_me";

		// Token: 0x040000E4 RID: 228
		public static readonly string friends_activities = "friends_activities";

		// Token: 0x040000E5 RID: 229
		public static readonly string friends_address = "friends_address";

		// Token: 0x040000E6 RID: 230
		public static readonly string friends_birthday = "friends_birthday";

		// Token: 0x040000E7 RID: 231
		public static readonly string friends_checkins = "friends_checkins";

		// Token: 0x040000E8 RID: 232
		public static readonly string friends_education_history = "friends_education_history";

		// Token: 0x040000E9 RID: 233
		public static readonly string friends_events = "friends_events";

		// Token: 0x040000EA RID: 234
		public static readonly string friends_friends = "friends_friends";

		// Token: 0x040000EB RID: 235
		public static readonly string friends_game_friends = "friends_game_friends";

		// Token: 0x040000EC RID: 236
		public static readonly string friends_games_activity = "friends_games_activity";

		// Token: 0x040000ED RID: 237
		public static readonly string friends_groups = "friends_groups";

		// Token: 0x040000EE RID: 238
		public static readonly string friends_hometown = "friends_hometown";

		// Token: 0x040000EF RID: 239
		public static readonly string friends_interests = "friends_interests";

		// Token: 0x040000F0 RID: 240
		public static readonly string friends_likes = "friends_likes";

		// Token: 0x040000F1 RID: 241
		public static readonly string friends_location = "friends_location";

		// Token: 0x040000F2 RID: 242
		public static readonly string friends_mobile_phone = "friends_mobile_phone";

		// Token: 0x040000F3 RID: 243
		public static readonly string friends_notes = "friends_notes";

		// Token: 0x040000F4 RID: 244
		public static readonly string friends_online_presence = "friends_online_presence";

		// Token: 0x040000F5 RID: 245
		public static readonly string friends_photo_video_tags = "friends_photo_video_tags";

		// Token: 0x040000F6 RID: 246
		public static readonly string friends_photos = "friends_photos";

		// Token: 0x040000F7 RID: 247
		public static readonly string friends_place_visits = "friends_place_visits";

		// Token: 0x040000F8 RID: 248
		public static readonly string friends_questions = "friends_questions";

		// Token: 0x040000F9 RID: 249
		public static readonly string friends_relationship_details = "friends_relationship_details";

		// Token: 0x040000FA RID: 250
		public static readonly string friends_relationships = "friends_relationships";

		// Token: 0x040000FB RID: 251
		public static readonly string friends_religion_politics = "friends_religion_politics";

		// Token: 0x040000FC RID: 252
		public static readonly string friends_status = "friends_status";

		// Token: 0x040000FD RID: 253
		public static readonly string friends_subscriptions = "friends_subscriptions";

		// Token: 0x040000FE RID: 254
		public static readonly string friends_videos = "friends_videos";

		// Token: 0x040000FF RID: 255
		public static readonly string friends_website = "friends_website";

		// Token: 0x04000100 RID: 256
		public static readonly string friends_work_history = "friends_work_history";

		// Token: 0x04000101 RID: 257
		public static readonly string manage_friendlists = "manage_friendlists";

		// Token: 0x04000102 RID: 258
		public static readonly string manage_groups = "manage_groups";

		// Token: 0x04000103 RID: 259
		public static readonly string manage_notifications = "manage_notifications";

		// Token: 0x04000104 RID: 260
		public static readonly string manage_pages = "manage_pages";

		// Token: 0x04000105 RID: 261
		public static readonly string photo_upload = "photo_upload";

		// Token: 0x04000106 RID: 262
		public static readonly string publish_actions = "publish_actions";

		// Token: 0x04000107 RID: 263
		public static readonly string publish_checkins = "publish_checkins";

		// Token: 0x04000108 RID: 264
		public static readonly string publish_stream = "publish_stream";

		// Token: 0x04000109 RID: 265
		public static readonly string read_friendlists = "read_friendlists";

		// Token: 0x0400010A RID: 266
		public static readonly string read_insights = "read_insights";

		// Token: 0x0400010B RID: 267
		public static readonly string read_mailbox = "read_mailbox";

		// Token: 0x0400010C RID: 268
		public static readonly string read_page_mailboxes = "read_page_mailboxes";

		// Token: 0x0400010D RID: 269
		public static readonly string read_requests = "read_requests";

		// Token: 0x0400010E RID: 270
		public static readonly string read_stream = "read_stream";

		// Token: 0x0400010F RID: 271
		public static readonly string rsvp_event = "rsvp_event";

		// Token: 0x04000110 RID: 272
		public static readonly string share_item = "share_item";

		// Token: 0x04000111 RID: 273
		public static readonly string sms = "sms";

		// Token: 0x04000112 RID: 274
		public static readonly string status_update = "status_update";

		// Token: 0x04000113 RID: 275
		public static readonly string tab_added = "tab_added";

		// Token: 0x04000114 RID: 276
		public static readonly string uid = "uid";

		// Token: 0x04000115 RID: 277
		public static readonly string user_about_me = "user_about_me";

		// Token: 0x04000116 RID: 278
		public static readonly string user_activities = "user_activities";

		// Token: 0x04000117 RID: 279
		public static readonly string user_birthday = "user_birthday";

		// Token: 0x04000118 RID: 280
		public static readonly string user_education_history = "user_education_history";

		// Token: 0x04000119 RID: 281
		public static readonly string user_events = "user_events";

		// Token: 0x0400011A RID: 282
		public static readonly string user_friends = "user_friends";

		// Token: 0x0400011B RID: 283
		public static readonly string user_games_activity = "user_games_activity";

		// Token: 0x0400011C RID: 284
		public static readonly string user_groups = "user_groups";

		// Token: 0x0400011D RID: 285
		public static readonly string user_hometown = "user_hometown";

		// Token: 0x0400011E RID: 286
		public static readonly string user_interests = "user_interests";

		// Token: 0x0400011F RID: 287
		public static readonly string user_likes = "user_likes";

		// Token: 0x04000120 RID: 288
		public static readonly string user_location = "user_location";

		// Token: 0x04000121 RID: 289
		public static readonly string user_notes = "user_notes";

		// Token: 0x04000122 RID: 290
		public static readonly string user_online_presence = "user_online_presence";

		// Token: 0x04000123 RID: 291
		public static readonly string user_photo_video_tags = "user_photo_video_tags";

		// Token: 0x04000124 RID: 292
		public static readonly string user_photos = "user_photos";

		// Token: 0x04000125 RID: 293
		public static readonly string user_questions = "user_questions";

		// Token: 0x04000126 RID: 294
		public static readonly string user_relationship_details = "user_relationship_details";

		// Token: 0x04000127 RID: 295
		public static readonly string user_relationships = "user_relationships";

		// Token: 0x04000128 RID: 296
		public static readonly string user_religion_politics = "user_religion_politics";

		// Token: 0x04000129 RID: 297
		public static readonly string user_status = "user_status";

		// Token: 0x0400012A RID: 298
		public static readonly string user_subscriptions = "user_subscriptions";

		// Token: 0x0400012B RID: 299
		public static readonly string user_videos = "user_videos";

		// Token: 0x0400012C RID: 300
		public static readonly string user_website = "user_website";

		// Token: 0x0400012D RID: 301
		public static readonly string user_work_history = "user_work_history";

		// Token: 0x0400012E RID: 302
		public static readonly string video_upload = "video_upload";

		// Token: 0x0400012F RID: 303
		public static readonly string xmpp_login = "xmpp_login";

		// Token: 0x04000130 RID: 304
		public static readonly string offline_access = "offline_access";

		// Token: 0x04000131 RID: 305
		public static readonly string user_checkins = "user_checkins";

		// Token: 0x04000132 RID: 306
		private string value;
	}
}
