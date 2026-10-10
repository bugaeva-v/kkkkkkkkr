using System;

namespace System.Threading
{
	/// <summary>Класс, предоставляющий сведения об изменениях данных экземплярам <see cref="T:System.Threading.AsyncLocal`1" />, которые зарегистрированы для получения уведомлений об изменениях.</summary>
	/// <typeparam name="T">Тип данных.</typeparam>
	// Token: 0x02000283 RID: 643
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
		/// <summary>Получает предыдущее значение данных.</summary>
		/// <returns>Предыдущее значение данных.</returns>
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0006DB32 File Offset: 0x0006BD32
		public T PreviousValue { get; }

		/// <summary>Получает текущее значение данных.</summary>
		/// <returns>Текущее значение данных.</returns>
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0006DB3A File Offset: 0x0006BD3A
		public T CurrentValue { get; }

		/// <summary>Возвращает значение, указывающее, изменяется ли значение из-за изменения контекста выполнения.</summary>
		/// <returns>Значение <see langword="true" />, если значение изменено из-за изменения контекста выполнения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0006DB42 File Offset: 0x0006BD42
		public bool ThreadContextChanged { get; }

		// Token: 0x06001D63 RID: 7523 RVA: 0x0006DB4A File Offset: 0x0006BD4A
		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
			this = default(AsyncLocalValueChangedArgs<T>);
			this.PreviousValue = previousValue;
			this.CurrentValue = currentValue;
			this.ThreadContextChanged = contextChanged;
		}
	}
}
