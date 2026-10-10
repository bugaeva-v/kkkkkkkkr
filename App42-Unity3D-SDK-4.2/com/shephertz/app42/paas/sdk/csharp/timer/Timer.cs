using System;

namespace com.shephertz.app42.paas.sdk.csharp.timer
{
	// Token: 0x020000BB RID: 187
	public class Timer : App42Response
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x0002F7AD File Offset: 0x0002D9AD
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0002F7B5 File Offset: 0x0002D9B5
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002F7BE File Offset: 0x0002D9BE
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0002F7C6 File Offset: 0x0002D9C6
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0002F7CF File Offset: 0x0002D9CF
		public DateTime GetCurrentTime()
		{
			return this.currentTime;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0002F7D7 File Offset: 0x0002D9D7
		public void SetCurrentTime(DateTime currentTime)
		{
			this.currentTime = currentTime;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
		public long GetTimeInSeconds()
		{
			return this.timeInSeconds;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		public void SetTimeInSeconds(long timeInSeconds)
		{
			this.timeInSeconds = timeInSeconds;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0002F7F1 File Offset: 0x0002D9F1
		public DateTime GetStartTime()
		{
			return this.startTime;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0002F7F9 File Offset: 0x0002D9F9
		public void SetStartTime(DateTime startTime)
		{
			this.startTime = startTime;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0002F802 File Offset: 0x0002DA02
		public DateTime GetEndTime()
		{
			return this.endTime;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0002F80A File Offset: 0x0002DA0A
		public void SetEndTime(DateTime endTime)
		{
			this.endTime = endTime;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0002F813 File Offset: 0x0002DA13
		public bool GetIsTimerActive()
		{
			return this.isTimerActive;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0002F81B File Offset: 0x0002DA1B
		public void SetIsTimerActive(bool isTimerActive)
		{
			this.isTimerActive = isTimerActive;
		}

		// Token: 0x040002E5 RID: 741
		public string name;

		// Token: 0x040002E6 RID: 742
		public DateTime currentTime;

		// Token: 0x040002E7 RID: 743
		public long timeInSeconds;

		// Token: 0x040002E8 RID: 744
		public DateTime startTime;

		// Token: 0x040002E9 RID: 745
		public DateTime endTime;

		// Token: 0x040002EA RID: 746
		public string userName;

		// Token: 0x040002EB RID: 747
		public bool isTimerActive;
	}
}
