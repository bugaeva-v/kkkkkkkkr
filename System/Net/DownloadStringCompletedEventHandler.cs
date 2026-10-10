using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.DownloadStringCompleted" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.DownloadStringCompletedEventArgs" />, содержащий данные события.</param>
	// Token: 0x020005AE RID: 1454
	// (Invoke) Token: 0x06002F8B RID: 12171
	public delegate void DownloadStringCompletedEventHandler(object sender, DownloadStringCompletedEventArgs e);
}
