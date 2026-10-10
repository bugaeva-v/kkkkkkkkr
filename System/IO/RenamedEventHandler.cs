using System;

namespace System.IO
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.IO.FileSystemWatcher.Renamed" /> класса <see cref="T:System.IO.FileSystemWatcher" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.IO.RenamedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020004F9 RID: 1273
	// (Invoke) Token: 0x060029A7 RID: 10663
	public delegate void RenamedEventHandler(object sender, RenamedEventArgs e);
}
