using System;

namespace System.IO.Ports
{
	/// <summary>Предоставляет метод, обрабатывающий событие <see cref="E:System.IO.Ports.SerialPort.PinChanged" /> объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	/// <param name="sender">Источник события, которым является объект <see cref="T:System.IO.Ports.SerialPort" />.</param>
	/// <param name="e">Объект <see cref="T:System.IO.Ports.SerialPinChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000534 RID: 1332
	// (Invoke) Token: 0x06002AF9 RID: 11001
	public delegate void SerialPinChangedEventHandler(object sender, SerialPinChangedEventArgs e);
}
