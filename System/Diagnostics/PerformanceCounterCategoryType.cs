using System;

namespace System.Diagnostics
{
	/// <summary>Указывает, может ли категория счетчиков производительности иметь несколько экземпляров.</summary>
	// Token: 0x02000272 RID: 626
	public enum PerformanceCounterCategoryType
	{
		/// <summary>Категория счетчиков производительности может обладать только одним экземпляром.</summary>
		// Token: 0x04000B1D RID: 2845
		SingleInstance,
		/// <summary>Категория счетчиков производительности может обладать несколькими экземплярами.</summary>
		// Token: 0x04000B1E RID: 2846
		MultiInstance,
		/// <summary>Возможности использования экземпляров для категории счетчика производительности неизвестны.</summary>
		// Token: 0x04000B1F RID: 2847
		Unknown = -1
	}
}
