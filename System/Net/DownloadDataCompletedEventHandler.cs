using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.DownloadDataCompleted" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.DownloadDataCompletedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020005AF RID: 1455
	// (Invoke) Token: 0x06002F8F RID: 12175
	public delegate void DownloadDataCompletedEventHandler(object sender, DownloadDataCompletedEventArgs e);
}
