using System;

namespace System.ComponentModel.Design
{
	/// <summary>Определяет методы для хоста конструктора для отчета о состоянии транзакций.</summary>
	// Token: 0x0200045D RID: 1117
	public interface IDesignerHostTransactionState
	{
		/// <summary>Получает значение, показывающее, находится ли хост конструктора в процессе закрытия транзакции.</summary>
		/// <returns>Значение <see langword="true" />, если конструктор закрывает транзакцию; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600243F RID: 9279
		bool IsClosingTransaction { get; }
	}
}
