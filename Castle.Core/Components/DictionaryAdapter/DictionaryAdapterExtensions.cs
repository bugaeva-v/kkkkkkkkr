using System;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000114 RID: 276
	public static class DictionaryAdapterExtensions
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x00014CC0 File Offset: 0x00012EC0
		public static IVirtual AsVirtual(this IDictionaryAdapter dictionaryAdapter)
		{
			PropertyDescriptor descriptor = dictionaryAdapter.This.Descriptor;
			if (descriptor == null)
			{
				return null;
			}
			return descriptor.Getters.OfType<IVirtual>().FirstOrDefault<IVirtual>();
		}
	}
}
