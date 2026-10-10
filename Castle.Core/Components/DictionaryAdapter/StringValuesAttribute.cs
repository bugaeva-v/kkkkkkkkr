using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200010B RID: 267
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class StringValuesAttribute : DictionaryBehaviorAttribute, IDictionaryPropertySetter, IDictionaryBehavior
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00013A67 File Offset: 0x00011C67
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00013A6F File Offset: 0x00011C6F
		public string Format { get; set; }

		// Token: 0x060006FF RID: 1791 RVA: 0x00013A78 File Offset: 0x00011C78
		bool IDictionaryPropertySetter.SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property)
		{
			if (value != null)
			{
				value = this.GetPropertyAsString(property, value);
			}
			return true;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00013A8C File Offset: 0x00011C8C
		private string GetPropertyAsString(PropertyDescriptor property, object value)
		{
			if (!string.IsNullOrEmpty(this.Format))
			{
				return string.Format(this.Format, value);
			}
			TypeConverter typeConverter = property.TypeConverter;
			if (typeConverter != null && typeConverter.CanConvertTo(typeof(string)))
			{
				return (string)typeConverter.ConvertTo(value, typeof(string));
			}
			return value.ToString();
		}
	}
}
