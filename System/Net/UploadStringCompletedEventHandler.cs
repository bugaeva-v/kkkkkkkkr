using System;

namespace System.Net
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.WebClient.UploadStringCompleted" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Net.UploadStringCompletedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020005B0 RID: 1456
	// (Invoke) Token: 0x06002F93 RID: 12179
	public delegate void UploadStringCompletedEventHandler(object sender, UploadStringCompletedEventArgs e);
}
