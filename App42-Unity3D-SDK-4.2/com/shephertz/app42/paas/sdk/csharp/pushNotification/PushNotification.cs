using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.pushNotification
{
	// Token: 0x0200007F RID: 127
	public class PushNotification : App42Response
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x0001C4A3 File Offset: 0x0001A6A3
		public DateTime GetExpiry()
		{
			return this.expiry;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001C4AB File Offset: 0x0001A6AB
		public void SetExpiry(DateTime expiry)
		{
			this.expiry = expiry;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001C4B4 File Offset: 0x0001A6B4
		public string GetMessage()
		{
			return this.message;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		public void SetMessage(string message)
		{
			this.message = message;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001C4C5 File Offset: 0x0001A6C5
		public string GetDeviceToken()
		{
			return this.deviceToken;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001C4CD File Offset: 0x0001A6CD
		public void SetDeviceToken(string deviceToken)
		{
			this.deviceToken = deviceToken;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001C4D6 File Offset: 0x0001A6D6
		public new string GetType()
		{
			return this.type;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001C4DE File Offset: 0x0001A6DE
		public void SetType(string type)
		{
			this.type = type;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001C4E7 File Offset: 0x0001A6E7
		public string GetState()
		{
			return this.state;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001C4EF File Offset: 0x0001A6EF
		public void SetState(string state)
		{
			this.state = state;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001C4F8 File Offset: 0x0001A6F8
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0001C500 File Offset: 0x0001A700
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0001C509 File Offset: 0x0001A709
		public string GetEventName()
		{
			return this.eventName;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0001C511 File Offset: 0x0001A711
		public void SetEventName(string eventName)
		{
			this.eventName = eventName;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001C51A File Offset: 0x0001A71A
		public IList<PushNotification.Channel> GetChannelList()
		{
			return this.channelList;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0001C522 File Offset: 0x0001A722
		public void SetChannelList(IList<PushNotification.Channel> channelList)
		{
			this.channelList = channelList;
		}

		// Token: 0x04000237 RID: 567
		public string message;

		// Token: 0x04000238 RID: 568
		public string userName;

		// Token: 0x04000239 RID: 569
		public string deviceToken;

		// Token: 0x0400023A RID: 570
		public string type;

		// Token: 0x0400023B RID: 571
		public string state;

		// Token: 0x0400023C RID: 572
		public string eventName;

		// Token: 0x0400023D RID: 573
		public DateTime expiry = default(DateTime);

		// Token: 0x0400023E RID: 574
		public IList<PushNotification.Channel> channelList = new List<PushNotification.Channel>();

		// Token: 0x02000080 RID: 128
		public class Channel
		{
			// Token: 0x06000552 RID: 1362 RVA: 0x0001C54A File Offset: 0x0001A74A
			public string GetName()
			{
				return this.channelName;
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x0001C552 File Offset: 0x0001A752
			public void SetName(string channelName)
			{
				this.channelName = channelName;
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x0001C55B File Offset: 0x0001A75B
			public string GetDescription()
			{
				return this.description;
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x0001C563 File Offset: 0x0001A763
			public void SetDescription(string description)
			{
				this.description = description;
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x0001C56C File Offset: 0x0001A76C
			public Channel(PushNotification pushNotification)
			{
				pushNotification.channelList.Add(this);
			}

			// Token: 0x0400023F RID: 575
			public string channelName;

			// Token: 0x04000240 RID: 576
			public string description;
		}
	}
}
