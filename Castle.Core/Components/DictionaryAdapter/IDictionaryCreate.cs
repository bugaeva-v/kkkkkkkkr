using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000123 RID: 291
	public interface IDictionaryCreate
	{
		// Token: 0x060007F1 RID: 2033
		T Create<T>();

		// Token: 0x060007F2 RID: 2034
		object Create(Type type);

		// Token: 0x060007F3 RID: 2035
		T Create<T>(IDictionary dictionary);

		// Token: 0x060007F4 RID: 2036
		object Create(Type type, IDictionary dictionary);

		// Token: 0x060007F5 RID: 2037
		T Create<T>(Action<T> init);

		// Token: 0x060007F6 RID: 2038
		T Create<T>(IDictionary dictionary, Action<T> init);
	}
}
