using System;

namespace System.Threading
{
	/// <summary>Уведомляет один или более ожидающих потоков о том, что произошло событие. Этот класс не наследуется.</summary>
	// Token: 0x02000291 RID: 657
	public sealed class ManualResetEvent : EventWaitHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ManualResetEvent" /> логическим значением, показывающим наличие сигнального состояния.</summary>
		/// <param name="initialState">Значение <see langword="true" /> для задания начального состояния сигнальным; <see langword="false" /> для задания несигнального начального состояния.</param>
		// Token: 0x06001D8A RID: 7562 RVA: 0x0006E68E File Offset: 0x0006C88E
		public ManualResetEvent(bool initialState) : base(initialState, EventResetMode.ManualReset)
		{
		}
	}
}
