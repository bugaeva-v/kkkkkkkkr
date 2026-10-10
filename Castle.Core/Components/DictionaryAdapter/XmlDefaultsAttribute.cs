using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200010F RID: 271
	[AttributeUsage(AttributeTargets.Interface)]
	public class XmlDefaultsAttribute : Attribute
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00013B32 File Offset: 0x00011D32
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00013B3A File Offset: 0x00011D3A
		public bool Qualified { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00013B43 File Offset: 0x00011D43
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00013B4B File Offset: 0x00011D4B
		public bool IsNullable { get; set; }
	}
}
