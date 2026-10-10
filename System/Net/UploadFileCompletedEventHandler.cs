using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.UploadFileCompleted" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.UploadFileCompletedEventArgs" />, содержащий данные события.</param>
	// Token: 0x020005B2 RID: 1458
	// (Invoke) Token: 0x06002F9B RID: 12187
	public delegate void UploadFileCompletedEventHandler(object sender, UploadFileCompletedEventArgs e);
}
