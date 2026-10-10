using System;

namespace System.IO.Ports
{
	/// <summary>Предоставляет метод, обрабатывающий событие <see cref="E:System.IO.Ports.SerialPort.ErrorReceived" /> объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	/// <param name="sender">Отправитель события — объект <see cref="T:System.IO.Ports.SerialPort" />.</param>
	/// <param name="e">Объект <see cref="T:System.IO.Ports.SerialErrorReceivedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000535 RID: 1333
	// (Invoke) Token: 0x06002AFD RID: 11005
	public delegate void SerialErrorReceivedEventHandler(object sender, SerialErrorReceivedEventArgs e);
}
