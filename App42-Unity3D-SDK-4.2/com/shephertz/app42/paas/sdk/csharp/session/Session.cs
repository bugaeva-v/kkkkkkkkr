using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.session
{
	// Token: 0x0200009B RID: 155
	public class Session : App42Response
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x000278BC File Offset: 0x00025ABC
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000278C4 File Offset: 0x00025AC4
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000278CD File Offset: 0x00025ACD
		public string GetSessionId()
		{
			return this.sessionId;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000278D5 File Offset: 0x00025AD5
		public void SetSessionId(string sessionId)
		{
			this.sessionId = sessionId;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000278DE File Offset: 0x00025ADE
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000278E6 File Offset: 0x00025AE6
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000278EF File Offset: 0x00025AEF
		public DateTime GetInvalidatedOn()
		{
			return this.invalidatedOn;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000278F7 File Offset: 0x00025AF7
		public void SetInvalidatedOn(DateTime invalidatedOn)
		{
			this.invalidatedOn = invalidatedOn;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00027900 File Offset: 0x00025B00
		public IList<Session.Attribute> GetAttributeList()
		{
			return this.attributeList;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00027908 File Offset: 0x00025B08
		public void SetAttributeList(IList<Session.Attribute> attributeList)
		{
			this.attributeList = attributeList;
		}

		// Token: 0x04000279 RID: 633
		public string userName;

		// Token: 0x0400027A RID: 634
		public string sessionId;

		// Token: 0x0400027B RID: 635
		public DateTime createdOn;

		// Token: 0x0400027C RID: 636
		public DateTime invalidatedOn;

		// Token: 0x0400027D RID: 637
		public IList<Session.Attribute> attributeList = new List<Session.Attribute>();

		// Token: 0x0200009C RID: 156
		public class Attribute
		{
			// Token: 0x0600067F RID: 1663 RVA: 0x00027924 File Offset: 0x00025B24
			public Attribute(Session session)
			{
				session.attributeList.Add(this);
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x00027938 File Offset: 0x00025B38
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x00027940 File Offset: 0x00025B40
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x00027949 File Offset: 0x00025B49
			public string GetValue()
			{
				return this.value;
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x00027951 File Offset: 0x00025B51
			public void SetValue(string value)
			{
				this.value = value;
			}

			// Token: 0x0400027E RID: 638
			public string name;

			// Token: 0x0400027F RID: 639
			public string value;
		}
	}
}
