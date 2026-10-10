using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200011C RID: 284
	public interface IDictionaryAdapter : IDictionaryEdit, IEditableObject, IRevertibleChangeTracking, IChangeTracking, IDictionaryNotify, INotifyPropertyChanging, INotifyPropertyChanged, IDictionaryValidate, IDataErrorInfo, IDictionaryCreate
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007CF RID: 1999
		DictionaryAdapterMeta Meta { get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007D0 RID: 2000
		DictionaryAdapterInstance This { get; }

		// Token: 0x060007D1 RID: 2001
		string GetKey(string propertyName);

		// Token: 0x060007D2 RID: 2002
		object GetProperty(string propertyName, bool ifExists);

		// Token: 0x060007D3 RID: 2003
		object ReadProperty(string key);

		// Token: 0x060007D4 RID: 2004
		T GetPropertyOfType<T>(string propertyName);

		// Token: 0x060007D5 RID: 2005
		bool SetProperty(string propertyName, ref object value);

		// Token: 0x060007D6 RID: 2006
		void StoreProperty(PropertyDescriptor property, string key, object value);

		// Token: 0x060007D7 RID: 2007
		void ClearProperty(PropertyDescriptor property, string key);

		// Token: 0x060007D8 RID: 2008
		bool ShouldClearProperty(PropertyDescriptor property, object value);

		// Token: 0x060007D9 RID: 2009
		void CopyTo(IDictionaryAdapter other);

		// Token: 0x060007DA RID: 2010
		void CopyTo(IDictionaryAdapter other, Func<PropertyDescriptor, bool> selector);

		// Token: 0x060007DB RID: 2011
		T Coerce<T>() where T : class;

		// Token: 0x060007DC RID: 2012
		object Coerce(Type type);
	}
}
