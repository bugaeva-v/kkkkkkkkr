using System;

namespace System.Threading
{
	/// <summary>Задает приоритет выполнения потока <see cref="T:System.Threading.Thread" />.</summary>
	// Token: 0x02000296 RID: 662
	public enum ThreadPriority
	{
		/// <summary>Выполнение потока <see cref="T:System.Threading.Thread" /> может быть запланировано после выполнения потоков с любыми другими приоритетами.</summary>
		// Token: 0x04001A3F RID: 6719
		Lowest,
		/// <summary>Выполнение потока <see cref="T:System.Threading.Thread" /> может быть запланировано после выполнения потоков с приоритетом <see langword="Normal" /> и до потоков с приоритетом <see langword="Lowest" />.</summary>
		// Token: 0x04001A40 RID: 6720
		BelowNormal,
		/// <summary>Выполнение потока <see cref="T:System.Threading.Thread" /> может быть запланировано после выполнения потоков с приоритетом <see langword="AboveNormal" /> и до потоков с приоритетом <see langword="BelowNormal" />. По умолчанию потоки имеют приоритет <see langword="Normal" />.</summary>
		// Token: 0x04001A41 RID: 6721
		Normal,
		/// <summary>Выполнение потока <see cref="T:System.Threading.Thread" /> может быть запланировано после выполнения потоков с приоритетом <see langword="Highest" /> и до потоков с приоритетом <see langword="Normal" />.</summary>
		// Token: 0x04001A42 RID: 6722
		AboveNormal,
		/// <summary>Выполнение потока <see cref="T:System.Threading.Thread" /> может быть запланировано до выполнения потоков с любыми другими приоритетами.</summary>
		// Token: 0x04001A43 RID: 6723
		Highest
	}
}
