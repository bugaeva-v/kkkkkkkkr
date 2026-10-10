using System;

namespace System.Diagnostics
{
	/// <summary>Предоставляет метод, обрабатывающий событие <see cref="E:System.Diagnostics.Process.OutputDataReceived" /> или событие <see cref="E:System.Diagnostics.Process.ErrorDataReceived" /> объекта <see cref="T:System.Diagnostics.Process" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Diagnostics.DataReceivedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000251 RID: 593
	// (Invoke) Token: 0x06001243 RID: 4675
	public delegate void DataReceivedEventHandler(object sender, DataReceivedEventArgs e);
}
