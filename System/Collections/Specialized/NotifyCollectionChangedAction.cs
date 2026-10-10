using System;

namespace System.Collections.Specialized
{
	/// <summary>Описывает действие, вызвавшее событие <see cref="E:System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged" />.</summary>
	// Token: 0x020004B4 RID: 1204
	public enum NotifyCollectionChangedAction
	{
		/// <summary>Элемент был добавлен в коллекцию.</summary>
		// Token: 0x04001516 RID: 5398
		Add,
		/// <summary>Элемент был удален из коллекции.</summary>
		// Token: 0x04001517 RID: 5399
		Remove,
		/// <summary>Элемент был заменен в коллекции.</summary>
		// Token: 0x04001518 RID: 5400
		Replace,
		/// <summary>Элемент был перемещен в пределах коллекции.</summary>
		// Token: 0x04001519 RID: 5401
		Move,
		/// <summary>Содержимое коллекции было удалено.</summary>
		// Token: 0x0400151A RID: 5402
		Reset
	}
}
