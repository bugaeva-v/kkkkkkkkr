using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000130 RID: 304
	public interface IPropertyDescriptorInitializer : IDictionaryBehavior
	{
		// Token: 0x06000819 RID: 2073
		void Initialize(PropertyDescriptor propertyDescriptor, object[] behaviors);
	}
}
