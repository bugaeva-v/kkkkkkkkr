using System;

namespace com.shephertz.app42.paas.sdk.csharp.achievement
{
	// Token: 0x02000009 RID: 9
	public class Achievement : App42Response
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003090 File Offset: 0x00001290
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003098 File Offset: 0x00001298
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030A1 File Offset: 0x000012A1
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030A9 File Offset: 0x000012A9
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000030B2 File Offset: 0x000012B2
		public string GetGameName()
		{
			return this.gameName;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000030BA File Offset: 0x000012BA
		public void SetGameName(string gameName)
		{
			this.gameName = gameName;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000030C3 File Offset: 0x000012C3
		public DateTime GetAchievedOn()
		{
			return this.achievedOn;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000030CB File Offset: 0x000012CB
		public void SetAchievedOn(DateTime achievedOn)
		{
			this.achievedOn = achievedOn;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000030D4 File Offset: 0x000012D4
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000030DC File Offset: 0x000012DC
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x0400001F RID: 31
		public string userName;

		// Token: 0x04000020 RID: 32
		public string name;

		// Token: 0x04000021 RID: 33
		public string description;

		// Token: 0x04000022 RID: 34
		public string gameName;

		// Token: 0x04000023 RID: 35
		public DateTime achievedOn;
	}
}
