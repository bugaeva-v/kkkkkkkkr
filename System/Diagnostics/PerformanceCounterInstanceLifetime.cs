using System;

namespace System.Diagnostics
{
	/// <summary>Задает время существования экземпляра счетчика производительности.</summary>
	// Token: 0x02000274 RID: 628
	public enum PerformanceCounterInstanceLifetime
	{
		/// <summary>Удаляет экземпляр счетчика производительности, если категория процесса не использует ни одного счетчика.</summary>
		// Token: 0x04000B21 RID: 2849
		Global,
		/// <summary>Удаляет экземпляр счетчика производительности, если процесс закрыт.</summary>
		// Token: 0x04000B22 RID: 2850
		Process
	}
}
