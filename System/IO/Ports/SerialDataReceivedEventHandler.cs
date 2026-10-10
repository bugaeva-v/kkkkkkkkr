using System;

namespace System.IO.Ports
{
	/// <summary>Предоставляет метод, обрабатывающий событие <see cref="E:System.IO.Ports.SerialPort.DataReceived" /> объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	/// <param name="sender">Отправитель события — объект <see cref="T:System.IO.Ports.SerialPort" />.</param>
	/// <param name="e">Объект <see cref="T:System.IO.Ports.SerialDataReceivedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000533 RID: 1331
	// (Invoke) Token: 0x06002AF5 RID: 10997
	public delegate void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e);
}
