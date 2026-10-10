using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для событий, которые могут быть полностью обработаны в обработчике событий.</summary>
	// Token: 0x020003AD RID: 941
	public class HandledEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.HandledEventArgs" />, используя значение по умолчанию свойства <see cref="P:System.ComponentModel.HandledEventArgs.Handled" />, <see langword="false" />.</summary>
		// Token: 0x06001ED6 RID: 7894 RVA: 0x0006CC82 File Offset: 0x0006AE82
		public HandledEventArgs() : this(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.HandledEventArgs" />, используя указанное значение по умолчанию для свойства <see cref="P:System.ComponentModel.HandledEventArgs.Handled" />.</summary>
		/// <param name="defaultHandledValue">Значение по умолчанию для свойства<see cref="P:System.ComponentModel.HandledEventArgs.Handled" />.</param>
		// Token: 0x06001ED7 RID: 7895 RVA: 0x0006CC8B File Offset: 0x0006AE8B
		public HandledEventArgs(bool defaultHandledValue)
		{
			this.Handled = defaultHandledValue;
		}

		/// <summary>Получает или задает значение, показывающее, полностью ли обработчик событий обработал событие или система должна продолжить собственную обработку.</summary>
		/// <returns>Значение <see langword="true" />, если событие было обработано полностью; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x0006CC9A File Offset: 0x0006AE9A
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x0006CCA2 File Offset: 0x0006AEA2
		public bool Handled { get; set; }
	}
}
