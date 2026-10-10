using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет метод, обрабатывающий событие <see cref="E:System.Net.NetworkInformation.Ping.PingCompleted" /> объекта <see cref="T:System.Net.NetworkInformation.Ping" />.</summary>
	/// <param name="sender">Источник события <see cref="E:System.Net.NetworkInformation.Ping.PingCompleted" />.</param>
	/// <param name="e">Объект <see cref="T:System.Net.NetworkInformation.PingCompletedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000722 RID: 1826
	// (Invoke) Token: 0x06003A50 RID: 14928
	public delegate void PingCompletedEventHandler(object sender, PingCompletedEventArgs e);
}
