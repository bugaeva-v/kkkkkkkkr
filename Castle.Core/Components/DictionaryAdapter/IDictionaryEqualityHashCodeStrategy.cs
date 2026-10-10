using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000126 RID: 294
	public interface IDictionaryEqualityHashCodeStrategy
	{
		// Token: 0x060007FF RID: 2047
		bool Equals(IDictionaryAdapter adapter1, IDictionaryAdapter adapter2);

		// Token: 0x06000800 RID: 2048
		bool GetHashCode(IDictionaryAdapter adapter, out int hashCode);
	}
}
