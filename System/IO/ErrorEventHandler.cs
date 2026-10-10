using System;

namespace System.IO
{
	/// <summary>Предоставляет метод, обрабатывающий событие <see cref="E:System.IO.FileSystemWatcher.Error" /> объекта <see cref="T:System.IO.FileSystemWatcher" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.IO.ErrorEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x0200050B RID: 1291
	// (Invoke) Token: 0x060029ED RID: 10733
	public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
}
