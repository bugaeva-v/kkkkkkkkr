using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000108 RID: 264
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public class StringFormatAttribute : DictionaryBehaviorAttribute, IDictionaryPropertyGetter, IDictionaryBehavior
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x000137B5 File Offset: 0x000119B5
		public StringFormatAttribute(string format, string properties)
		{
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			this.Format = format;
			this.Properties = properties;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000137D9 File Offset: 0x000119D9
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x000137E1 File Offset: 0x000119E1
		public string Format { get; private set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000137EA File Offset: 0x000119EA
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x000137F2 File Offset: 0x000119F2
		public string Properties { get; private set; }

		// Token: 0x060006F2 RID: 1778 RVA: 0x000137FB File Offset: 0x000119FB
		object IDictionaryPropertyGetter.GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			return string.Format(this.Format, this.GetFormatArguments(dictionaryAdapter, property.Property.Name)).Trim();
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00013820 File Offset: 0x00011A20
		private object[] GetFormatArguments(IDictionaryAdapter dictionaryAdapter, string formattedPropertyName)
		{
			string[] array = this.Properties.Split(StringFormatAttribute.PropertyDelimeters, StringSplitOptions.RemoveEmptyEntries);
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text != formattedPropertyName)
				{
					array2[i] = dictionaryAdapter.GetProperty(text, false);
				}
				else
				{
					array2[i] = "(recursive)";
				}
			}
			return array2;
		}

		// Token: 0x040001A2 RID: 418
		private static readonly char[] PropertyDelimeters = new char[]
		{
			',',
			' '
		};
	}
}
