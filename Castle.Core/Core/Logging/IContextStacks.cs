using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D0 RID: 208
	public interface IContextStacks
	{
		// Token: 0x170000BD RID: 189
		IContextStack this[string key]
		{
			get;
		}
	}
}
