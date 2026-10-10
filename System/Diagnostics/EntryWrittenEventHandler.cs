using System;

namespace System.Diagnostics
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Diagnostics.EventLog.EntryWritten" /> для <see cref="T:System.Diagnostics.EventLog" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Diagnostics.EntryWrittenEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000257 RID: 599
	// (Invoke) Token: 0x06001275 RID: 4725
	public delegate void EntryWrittenEventHandler(object sender, EntryWrittenEventArgs e);
}
