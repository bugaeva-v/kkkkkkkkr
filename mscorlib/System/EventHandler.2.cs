using System;

namespace System
{
	/// <summary>Представляет метод, обрабатывающий событие, когда событие предоставляет данные.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект, содержащий данные о событии.</param>
	/// <typeparam name="TEventArgs">Тип данных события, создаваемых событием.</typeparam>
	// Token: 0x02000117 RID: 279
	// (Invoke) Token: 0x06000AD6 RID: 2774
	public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
}
