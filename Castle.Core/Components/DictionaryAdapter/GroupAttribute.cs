using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000FD RID: 253
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class GroupAttribute : Attribute
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00013088 File Offset: 0x00011288
		public GroupAttribute(object group)
		{
			this.Group = new object[]
			{
				group
			};
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000130A0 File Offset: 0x000112A0
		public GroupAttribute(params object[] group)
		{
			this.Group = group;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000130AF File Offset: 0x000112AF
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x000130B7 File Offset: 0x000112B7
		public object[] Group { get; private set; }
	}
}
