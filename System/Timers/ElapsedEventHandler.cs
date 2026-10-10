using System;

namespace System.Timers
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Timers.Timer.Elapsed" /> объекта <see cref="T:System.Timers.Timer" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Timers.ElapsedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000192 RID: 402
	// (Invoke) Token: 0x06000A87 RID: 2695
	public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);
}
