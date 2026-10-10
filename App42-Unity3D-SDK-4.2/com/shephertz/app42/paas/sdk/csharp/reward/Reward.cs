using System;

namespace com.shephertz.app42.paas.sdk.csharp.reward
{
	// Token: 0x02000095 RID: 149
	public class Reward : App42Response
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x00024E6B File Offset: 0x0002306B
		public string GetGameName()
		{
			return this.gameName;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00024E73 File Offset: 0x00023073
		public void SetGameName(string gameName)
		{
			this.gameName = gameName;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00024E7C File Offset: 0x0002307C
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00024E84 File Offset: 0x00023084
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00024E8D File Offset: 0x0002308D
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00024E95 File Offset: 0x00023095
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00024E9E File Offset: 0x0002309E
		public double GetPoints()
		{
			return this.points;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00024EA6 File Offset: 0x000230A6
		public void SetPoints(double points)
		{
			this.points = points;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00024EAF File Offset: 0x000230AF
		public string GetDesription()
		{
			return this.description;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00024EB7 File Offset: 0x000230B7
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00024EC0 File Offset: 0x000230C0
		public double GetRank()
		{
			return this.rank;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00024EC8 File Offset: 0x000230C8
		public void SetRank(double rank)
		{
			this.rank = rank;
		}

		// Token: 0x04000270 RID: 624
		public string gameName;

		// Token: 0x04000271 RID: 625
		public string userName;

		// Token: 0x04000272 RID: 626
		public string name;

		// Token: 0x04000273 RID: 627
		public double points;

		// Token: 0x04000274 RID: 628
		public string description;

		// Token: 0x04000275 RID: 629
		public double rank;
	}
}
