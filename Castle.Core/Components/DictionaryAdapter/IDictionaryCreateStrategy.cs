using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000124 RID: 292
	public interface IDictionaryCreateStrategy
	{
		// Token: 0x060007F7 RID: 2039
		object Create(IDictionaryAdapter adapter, Type type, IDictionary dictionary);
	}
}
