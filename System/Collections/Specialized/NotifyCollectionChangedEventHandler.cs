using System;

namespace System.Collections.Specialized
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged" />.</summary>
	/// <param name="sender">Объект, создавший событие.</param>
	/// <param name="e">Сведения о событии.</param>
	// Token: 0x020004B6 RID: 1206
	// (Invoke) Token: 0x06002702 RID: 9986
	public delegate void NotifyCollectionChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e);
}
