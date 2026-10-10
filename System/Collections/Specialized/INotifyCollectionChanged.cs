using System;

namespace System.Collections.Specialized
{
	/// <summary>Информирует прослушиватели о динамических изменениях, например о добавлении или удалении элемента либо об очистке всего списка.</summary>
	// Token: 0x020004B3 RID: 1203
	public interface INotifyCollectionChanged
	{
		/// <summary>Происходит при изменении коллекции.</summary>
		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060026EA RID: 9962
		// (remove) Token: 0x060026EB RID: 9963
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}
}
