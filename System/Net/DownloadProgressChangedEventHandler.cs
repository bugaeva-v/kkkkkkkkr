using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.DownloadProgressChangedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020005B4 RID: 1460
	// (Invoke) Token: 0x06002FA3 RID: 12195
	public delegate void DownloadProgressChangedEventHandler(object sender, DownloadProgressChangedEventArgs e);
}
