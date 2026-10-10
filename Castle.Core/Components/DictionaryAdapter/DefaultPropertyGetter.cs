using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000112 RID: 274
	public class DefaultPropertyGetter : IDictionaryPropertyGetter, IDictionaryBehavior
	{
		// Token: 0x0600071C RID: 1820 RVA: 0x00013C34 File Offset: 0x00011E34
		public DefaultPropertyGetter(TypeConverter converter)
		{
			this.converter = converter;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00013C43 File Offset: 0x00011E43
		public int ExecutionOrder
		{
			get
			{
				return int.MaxValue;
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00013C4C File Offset: 0x00011E4C
		public object GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			Type propertyType = property.PropertyType;
			if (storedValue != null && !propertyType.IsInstanceOfType(storedValue) && this.converter != null && this.converter.CanConvertFrom(storedValue.GetType()))
			{
				return this.converter.ConvertFrom(storedValue);
			}
			return storedValue;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00013C96 File Offset: 0x00011E96
		public IDictionaryBehavior Copy()
		{
			return this;
		}

		// Token: 0x040001AF RID: 431
		private readonly TypeConverter converter;
	}
}
