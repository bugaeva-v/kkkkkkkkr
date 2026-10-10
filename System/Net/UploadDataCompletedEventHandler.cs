using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.UploadDataCompleted" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.UploadDataCompletedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020005B1 RID: 1457
	// (Invoke) Token: 0x06002F97 RID: 12183
	public delegate void UploadDataCompletedEventHandler(object sender, UploadDataCompletedEventArgs e);
}
