using System;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, который может обрабатывать события, которые могут требовать или не требовать дальнейшей обработки после возвращения из обработчика событий.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.HandledEventArgs" />, содержащий данные события.</param>
	// Token: 0x020003AE RID: 942
	// (Invoke) Token: 0x06001EDB RID: 7899
	public delegate void HandledEventHandler(object sender, HandledEventArgs e);
}
