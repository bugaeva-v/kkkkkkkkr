using System;
using System.Collections.Generic;

namespace Firebase.Messaging
{
	// Token: 0x02000005 RID: 5
	public sealed class FirebaseNotification
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002388 File Offset: 0x00000588
		internal static FirebaseNotification FromInternal(FirebaseNotificationInternal other)
		{
			bool flag = other == null;
			FirebaseNotification result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new FirebaseNotification
				{
					Android = AndroidNotificationParams.FromInternal(other.android),
					Badge = other.badge,
					Body = other.body,
					BodyLocalizationArgs = new List<string>(other.body_loc_args),
					BodyLocalizationKey = other.body_loc_key,
					ClickAction = other.click_action,
					Color = other.color,
					Icon = other.icon,
					Sound = other.sound,
					Tag = other.tag,
					Title = other.title,
					TitleLocalizationArgs = new List<string>(other.title_loc_args),
					TitleLocalizationKey = other.title_loc_key
				};
			}
			return result;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002468 File Offset: 0x00000668
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002470 File Offset: 0x00000670
		public AndroidNotificationParams Android { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002479 File Offset: 0x00000679
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002481 File Offset: 0x00000681
		public string Badge { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000248A File Offset: 0x0000068A
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002492 File Offset: 0x00000692
		public string Body { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000249B File Offset: 0x0000069B
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000024A3 File Offset: 0x000006A3
		public IEnumerable<string> BodyLocalizationArgs { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000024AC File Offset: 0x000006AC
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000024B4 File Offset: 0x000006B4
		public string BodyLocalizationKey { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000024BD File Offset: 0x000006BD
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000024C5 File Offset: 0x000006C5
		public string ClickAction { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000024CE File Offset: 0x000006CE
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000024D6 File Offset: 0x000006D6
		public string Color { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000024DF File Offset: 0x000006DF
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000024E7 File Offset: 0x000006E7
		public string Icon { get; private set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000024F8 File Offset: 0x000006F8
		public string Sound { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002501 File Offset: 0x00000701
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002509 File Offset: 0x00000709
		public string Tag { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002512 File Offset: 0x00000712
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000251A File Offset: 0x0000071A
		public string Title { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002523 File Offset: 0x00000723
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000252B File Offset: 0x0000072B
		public IEnumerable<string> TitleLocalizationArgs { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000253C File Offset: 0x0000073C
		public string TitleLocalizationKey { get; private set; }

		// Token: 0x0600004F RID: 79 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose(bool disposing)
		{
		}
	}
}
