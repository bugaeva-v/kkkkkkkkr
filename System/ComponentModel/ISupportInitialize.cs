using System;

namespace System.ComponentModel
{
	/// <summary>Определяет, что этот объект поддерживает для пакетной инициализации простое уведомление с транзакциями.</summary>
	// Token: 0x02000370 RID: 880
	public interface ISupportInitialize
	{
		/// <summary>Подает сигнал объекту о начале инициализации.</summary>
		// Token: 0x06001D1A RID: 7450
		void BeginInit();

		/// <summary>Подает объекту сигнал о завершении инициализации.</summary>
		// Token: 0x06001D1B RID: 7451
		void EndInit();
	}
}
