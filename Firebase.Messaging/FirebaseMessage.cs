using System;
using System.Collections.Generic;

namespace Firebase.Messaging
{
	// Token: 0x02000002 RID: 2
	public sealed class FirebaseMessage
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal static FirebaseMessage FromInternal(FirebaseMessageInternal other)
		{
			bool flag = other == null;
			FirebaseMessage result;
			if (flag)
			{
				result = null;
			}
			else
			{
				FirebaseMessage firebaseMessage = new FirebaseMessage();
				firebaseMessage.CollapseKey = other.collapse_key;
				firebaseMessage.Data = new Dictionary<string, string>(other.data);
				firebaseMessage.Error = other.error;
				firebaseMessage.ErrorDescription = other.error_description;
				firebaseMessage.From = other.from;
				firebaseMessage.Link = FirebaseApp.UrlStringToUri(other.link);
				firebaseMessage.MessageId = other.message_id;
				firebaseMessage.MessageType = other.message_type;
				firebaseMessage.Notification = FirebaseNotification.FromInternal(other.notification);
				firebaseMessage.NotificationOpened = other.notification_opened;
				firebaseMessage.Priority = other.priority;
				firebaseMessage.RawData = new byte[other.raw_data.Count];
				other.raw_data.CopyTo(firebaseMessage.RawData);
				firebaseMessage.TimeToLive = TimeSpan.FromSeconds((double)other.time_to_live);
				firebaseMessage.To = other.to;
				result = firebaseMessage;
			}
			return result;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000215F File Offset: 0x0000035F
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002167 File Offset: 0x00000367
		public string CollapseKey { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002170 File Offset: 0x00000370
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002178 File Offset: 0x00000378
		public IDictionary<string, string> Data { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002181 File Offset: 0x00000381
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002189 File Offset: 0x00000389
		public string Error { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002192 File Offset: 0x00000392
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000219A File Offset: 0x0000039A
		public string ErrorDescription { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021A3 File Offset: 0x000003A3
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000021AB File Offset: 0x000003AB
		public string From { get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021B4 File Offset: 0x000003B4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000021BC File Offset: 0x000003BC
		public Uri Link { get; private set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021C5 File Offset: 0x000003C5
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000021CD File Offset: 0x000003CD
		public string MessageId { get; private set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021D6 File Offset: 0x000003D6
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000021DE File Offset: 0x000003DE
		public string MessageType { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021E7 File Offset: 0x000003E7
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000021EF File Offset: 0x000003EF
		public FirebaseNotification Notification { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021F8 File Offset: 0x000003F8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002200 File Offset: 0x00000400
		public bool NotificationOpened { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002209 File Offset: 0x00000409
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002211 File Offset: 0x00000411
		public string Priority { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000221A File Offset: 0x0000041A
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002222 File Offset: 0x00000422
		public byte[] RawData { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000222B File Offset: 0x0000042B
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002233 File Offset: 0x00000433
		public TimeSpan TimeToLive { get; private set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000223C File Offset: 0x0000043C
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002244 File Offset: 0x00000444
		public string To { get; private set; }

		// Token: 0x0600001E RID: 30 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose(bool disposing)
		{
		}
	}
}
