using System;

namespace System.IO
{
	/// <summary>Представляет метод, обрабатывающий события <see cref="E:System.IO.FileSystemWatcher.Changed" />, <see cref="E:System.IO.FileSystemWatcher.Created" /> или <see cref="E:System.IO.FileSystemWatcher.Deleted" /> класса <see cref="T:System.IO.FileSystemWatcher" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.IO.FileSystemEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020004F7 RID: 1271
	// (Invoke) Token: 0x060029A0 RID: 10656
	public delegate void FileSystemEventHandler(object sender, FileSystemEventArgs e);
}
