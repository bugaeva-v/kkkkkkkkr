using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000121 RID: 289
	public interface IDictionaryCoerceStrategy
	{
		// Token: 0x060007EF RID: 2031
		object Coerce(IDictionaryAdapter adapter, Type type);
	}
}
