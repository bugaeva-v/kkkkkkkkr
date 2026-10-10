using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200010C RID: 268
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class SuppressNotificationsAttribute : DictionaryBehaviorAttribute, IPropertyDescriptorInitializer, IDictionaryBehavior
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00013AF4 File Offset: 0x00011CF4
		public void Initialize(PropertyDescriptor propertyDescriptor, object[] behaviors)
		{
			propertyDescriptor.SuppressNotifications = true;
		}
	}
}
