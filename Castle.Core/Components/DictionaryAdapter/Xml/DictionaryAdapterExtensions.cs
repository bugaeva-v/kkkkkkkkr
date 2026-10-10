using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A8 RID: 424
	public static class DictionaryAdapterExtensions
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x0001F878 File Offset: 0x0001DA78
		public static object CreateChildAdapter(this IDictionaryAdapter parent, Type type, XmlAdapter adapter)
		{
			return parent.CreateChildAdapter(type, adapter, null);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0001F884 File Offset: 0x0001DA84
		public static object CreateChildAdapter(this IDictionaryAdapter parent, Type type, XmlAdapter adapter, IDictionary dictionary)
		{
			if (dictionary == null)
			{
				dictionary = new Hashtable();
			}
			PropertyDescriptor propertyDescriptor = parent.Meta.CreateDescriptor();
			parent.This.Descriptor.CopyBehaviors(propertyDescriptor);
			propertyDescriptor.AddBehavior(adapter);
			return parent.This.Factory.GetAdapter(type, dictionary, propertyDescriptor);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		public static bool HasAccessor(this PropertyDescriptor property)
		{
			return property.ExtendedProperties.Contains("XmlAccessor");
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0001F8E6 File Offset: 0x0001DAE6
		public static XmlAccessor GetAccessor(this PropertyDescriptor property)
		{
			return (XmlAccessor)property.ExtendedProperties["XmlAccessor"];
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0001F8FD File Offset: 0x0001DAFD
		public static void SetAccessor(this PropertyDescriptor property, XmlAccessor accessor)
		{
			property.ExtendedProperties["XmlAccessor"] = accessor;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0001F910 File Offset: 0x0001DB10
		public static bool HasXmlMeta(this DictionaryAdapterMeta meta)
		{
			return meta.ExtendedProperties.Contains("XmlMeta");
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0001F922 File Offset: 0x0001DB22
		public static XmlMetadata GetXmlMeta(this DictionaryAdapterMeta meta)
		{
			return (XmlMetadata)meta.ExtendedProperties["XmlMeta"];
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0001F939 File Offset: 0x0001DB39
		public static void SetXmlMeta(this DictionaryAdapterMeta meta, XmlMetadata xmlMeta)
		{
			meta.ExtendedProperties["XmlMeta"] = xmlMeta;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0001F94C File Offset: 0x0001DB4C
		public static bool HasXmlType(this DictionaryAdapterMeta meta)
		{
			return meta.ExtendedProperties.Contains("XmlType");
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0001F95E File Offset: 0x0001DB5E
		public static string GetXmlType(this DictionaryAdapterMeta meta)
		{
			return (string)meta.ExtendedProperties["XmlType"];
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0001F975 File Offset: 0x0001DB75
		public static void SetXmlType(this DictionaryAdapterMeta meta, string value)
		{
			meta.ExtendedProperties["XmlType"] = value;
		}

		// Token: 0x040002DC RID: 732
		private const string XmlAccessorKey = "XmlAccessor";

		// Token: 0x040002DD RID: 733
		private const string XmlMetaKey = "XmlMeta";

		// Token: 0x040002DE RID: 734
		private const string XmlTypeKey = "XmlType";
	}
}
