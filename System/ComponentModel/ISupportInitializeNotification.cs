using System;

namespace System.ComponentModel
{
	/// <summary>Позволяет выполнить инициализацию компонента и его зависимых свойств.</summary>
	// Token: 0x020003BB RID: 955
	public interface ISupportInitializeNotification : ISupportInitialize
	{
		/// <summary>Возвращает значение, показывающее, инициализирован ли компонент.</summary>
		/// <returns>Значение <see langword="true" /> указывает, что компонент завершил инициализацию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001F1A RID: 7962
		bool IsInitialized { get; }

		/// <summary>Возникает при завершении инициализации компонента.</summary>
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06001F1B RID: 7963
		// (remove) Token: 0x06001F1C RID: 7964
		event EventHandler Initialized;
	}
}
