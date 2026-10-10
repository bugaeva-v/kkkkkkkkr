using System;
using System.Collections;
using System.Collections.Specialized;
using System.Xml;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200011D RID: 285
	public interface IDictionaryAdapterFactory
	{
		// Token: 0x060007DD RID: 2013
		T GetAdapter<T>(IDictionary dictionary);

		// Token: 0x060007DE RID: 2014
		object GetAdapter(Type type, IDictionary dictionary);

		// Token: 0x060007DF RID: 2015
		object GetAdapter(Type type, IDictionary dictionary, PropertyDescriptor descriptor);

		// Token: 0x060007E0 RID: 2016
		T GetAdapter<T>(NameValueCollection nameValues);

		// Token: 0x060007E1 RID: 2017
		object GetAdapter(Type type, NameValueCollection nameValues);

		// Token: 0x060007E2 RID: 2018
		T GetAdapter<T>(XmlNode xmlNode);

		// Token: 0x060007E3 RID: 2019
		object GetAdapter(Type type, XmlNode xmlNode);

		// Token: 0x060007E4 RID: 2020
		DictionaryAdapterMeta GetAdapterMeta(Type type);

		// Token: 0x060007E5 RID: 2021
		DictionaryAdapterMeta GetAdapterMeta(Type type, PropertyDescriptor descriptor);

		// Token: 0x060007E6 RID: 2022
		DictionaryAdapterMeta GetAdapterMeta(Type type, DictionaryAdapterMeta other);
	}
}
