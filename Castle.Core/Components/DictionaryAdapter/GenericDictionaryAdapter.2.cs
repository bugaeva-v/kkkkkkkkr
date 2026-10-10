using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200011B RID: 283
	public static class GenericDictionaryAdapter
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x00015FBE File Offset: 0x000141BE
		public static GenericDictionaryAdapter<TValue> ForDictionaryAdapter<TValue>(this IDictionary<string, TValue> dictionary)
		{
			return new GenericDictionaryAdapter<TValue>(dictionary);
		}
	}
}
