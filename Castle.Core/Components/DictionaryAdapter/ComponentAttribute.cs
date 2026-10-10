using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000F9 RID: 249
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class ComponentAttribute : DictionaryBehaviorAttribute, IDictionaryKeyBuilder, IDictionaryBehavior, IDictionaryPropertyGetter, IDictionaryPropertySetter
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00012F20 File Offset: 0x00011120
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00012F32 File Offset: 0x00011132
		public bool NoPrefix
		{
			get
			{
				return this.Prefix == "";
			}
			set
			{
				if (value)
				{
					this.Prefix = "";
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00012F42 File Offset: 0x00011142
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00012F4A File Offset: 0x0001114A
		public string Prefix { get; set; }

		// Token: 0x060006B2 RID: 1714 RVA: 0x00012F53 File Offset: 0x00011153
		string IDictionaryKeyBuilder.GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor property)
		{
			return this.Prefix ?? (key + "_");
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00012F6C File Offset: 0x0001116C
		object IDictionaryPropertyGetter.GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			if (storedValue == null)
			{
				object obj = dictionaryAdapter.This.ExtendedProperties[property.PropertyName];
				if (obj == null)
				{
					PropertyDescriptor propertyDescriptor = new PropertyDescriptor(property.Property, null);
					propertyDescriptor.AddBehavior(new KeyPrefixAttribute(key));
					obj = dictionaryAdapter.This.Factory.GetAdapter(property.Property.PropertyType, dictionaryAdapter.This.Dictionary, propertyDescriptor);
					dictionaryAdapter.This.ExtendedProperties[property.PropertyName] = obj;
				}
				return obj;
			}
			return storedValue;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00012FF6 File Offset: 0x000111F6
		public bool SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property)
		{
			dictionaryAdapter.This.ExtendedProperties.Remove(property.PropertyName);
			return false;
		}
	}
}
