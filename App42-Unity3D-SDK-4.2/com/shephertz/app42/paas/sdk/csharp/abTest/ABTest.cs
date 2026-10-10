using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.abTest
{
	// Token: 0x02000003 RID: 3
	public class ABTest : App42Response
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000209A File Offset: 0x0000029A
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020A2 File Offset: 0x000002A2
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020AB File Offset: 0x000002AB
		public bool IsActive()
		{
			return this.isActive;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B3 File Offset: 0x000002B3
		public void SetIsActive(bool isActive)
		{
			this.isActive = isActive;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BC File Offset: 0x000002BC
		public new string GetType()
		{
			return this.type;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C4 File Offset: 0x000002C4
		public void SetType(string type)
		{
			this.type = type;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020CD File Offset: 0x000002CD
		public IList<ABTest.Variant> GetVariantList()
		{
			return this.variantList;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020D5 File Offset: 0x000002D5
		public void SetVariantList(IList<ABTest.Variant> variantList)
		{
			this.variantList = variantList;
		}

		// Token: 0x04000004 RID: 4
		public string name;

		// Token: 0x04000005 RID: 5
		public bool isActive;

		// Token: 0x04000006 RID: 6
		public string type;

		// Token: 0x04000007 RID: 7
		public IList<ABTest.Variant> variantList = new List<ABTest.Variant>();

		// Token: 0x02000004 RID: 4
		public class Variant
		{
			// Token: 0x06000012 RID: 18 RVA: 0x000020F1 File Offset: 0x000002F1
			public Variant(ABTest abTest)
			{
				abTest.variantList.Add(this);
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00002105 File Offset: 0x00000305
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000014 RID: 20 RVA: 0x0000210D File Offset: 0x0000030D
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002116 File Offset: 0x00000316
			public string GetProfileJSON()
			{
				return this.profile;
			}

			// Token: 0x06000016 RID: 22 RVA: 0x0000211E File Offset: 0x0000031E
			public void SetProfileJSON(string profile)
			{
				this.profile = profile;
			}

			// Token: 0x04000008 RID: 8
			public string name;

			// Token: 0x04000009 RID: 9
			public string profile;
		}
	}
}
