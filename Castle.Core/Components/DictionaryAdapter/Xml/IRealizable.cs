using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001AB RID: 427
	public interface IRealizable<T> : IRealizableSource
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000D21 RID: 3361
		bool IsReal { get; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000D22 RID: 3362
		T Value { get; }
	}
}
