using System;

namespace System.Threading
{
	/// <summary>Уведомляет ожидающий поток о том, что произошло событие. Этот класс не наследуется.</summary>
	// Token: 0x0200028C RID: 652
	public sealed class AutoResetEvent : EventWaitHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AutoResetEvent" /> логическим значением, показывающим наличие сигнального состояния.</summary>
		/// <param name="initialState">Значение <see langword="true" /> для задания начального состояния сигнальным; <see langword="false" /> для задания несигнального начального состояния.</param>
		// Token: 0x06001D7A RID: 7546 RVA: 0x0006E41C File Offset: 0x0006C61C
		public AutoResetEvent(bool initialState) : base(initialState, EventResetMode.AutoReset)
		{
		}
	}
}
