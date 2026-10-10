using System;

namespace Castle.Core.Configuration
{
	// Token: 0x020000F4 RID: 244
	public interface IConfiguration
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600067C RID: 1660
		string Name { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600067D RID: 1661
		string Value { get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600067E RID: 1662
		ConfigurationCollection Children { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600067F RID: 1663
		ConfigurationAttributeCollection Attributes { get; }

		// Token: 0x06000680 RID: 1664
		object GetValue(Type type, object defaultValue);
	}
}
