using System;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.DataColumnCollection.CollectionChanged" />, возникающее при добавлении или удалении элементов из коллекции.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.CollectionChangeEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200038C RID: 908
	// (Invoke) Token: 0x06001DDD RID: 7645
	public delegate void CollectionChangeEventHandler(object sender, CollectionChangeEventArgs e);
}
