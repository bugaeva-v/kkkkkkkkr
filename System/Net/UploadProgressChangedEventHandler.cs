using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.UploadProgressChanged" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.UploadProgressChangedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020005B5 RID: 1461
	// (Invoke) Token: 0x06002FA7 RID: 12199
	public delegate void UploadProgressChangedEventHandler(object sender, UploadProgressChangedEventArgs e);
}
