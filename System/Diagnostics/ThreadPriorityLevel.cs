using System;

namespace System.Diagnostics
{
	/// <summary>Задает уровень приоритета потока.</summary>
	// Token: 0x02000281 RID: 641
	public enum ThreadPriorityLevel
	{
		/// <summary>Задает приоритет на один уровень выше нормального для связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B68 RID: 2920
		AboveNormal = 1,
		/// <summary>Задает приоритет на один уровень ниже нормального для связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B69 RID: 2921
		BelowNormal = -1,
		/// <summary>Задает высший приоритет. Он на два уровня выше нормального приоритета для связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B6A RID: 2922
		Highest = 2,
		/// <summary>Задает приоритет простоя. Это самое низкое из возможных значений приоритета всех потоков, независимо от значения связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B6B RID: 2923
		Idle = -15,
		/// <summary>Задает низший приоритет. Он на два уровня ниже нормального приоритета для связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B6C RID: 2924
		Lowest = -2,
		/// <summary>Задает нормальный приоритет для связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B6D RID: 2925
		Normal = 0,
		/// <summary>Задает критичный по времени приоритет. Это самый высокий приоритет всех потоков, независимо от значения связанного <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</summary>
		// Token: 0x04000B6E RID: 2926
		TimeCritical = 15
	}
}
