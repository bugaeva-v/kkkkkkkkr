using System;

namespace Firebase.Messaging
{
	// Token: 0x02000004 RID: 4
	public sealed class AndroidNotificationParams
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002344 File Offset: 0x00000544
		internal static AndroidNotificationParams FromInternal(AndroidNotificationParamsInternal other)
		{
			bool flag = other == null;
			AndroidNotificationParams result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new AndroidNotificationParams
				{
					ChannelId = other.channel_id
				};
			}
			return result;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002376 File Offset: 0x00000576
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000237E File Offset: 0x0000057E
		public string ChannelId { get; private set; }

		// Token: 0x06000031 RID: 49 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose(bool disposing)
		{
		}
	}
}
