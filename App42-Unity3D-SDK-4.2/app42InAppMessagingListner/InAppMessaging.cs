using System;

namespace app42InAppMessagingListner
{
	// Token: 0x0200005F RID: 95
	public class InAppMessaging
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000146F8 File Offset: 0x000128F8
		// (set) Token: 0x06000398 RID: 920 RVA: 0x000146FF File Offset: 0x000128FF
		public static bool IsInAppMessagingEnabled
		{
			get
			{
				return InAppMessaging.isInAppMessagingEnabled;
			}
			set
			{
				InAppMessaging.isInAppMessagingEnabled = value;
			}
		}

		// Token: 0x0400017E RID: 382
		private static bool isInAppMessagingEnabled;
	}
}
