using System;

namespace System
{
	/// <summary>Определяет порядок принудительной сборки мусора.</summary>
	// Token: 0x020001FC RID: 508
	[Serializable]
	public enum GCCollectionMode
	{
		/// <summary>Значение по умолчанию для данного перечисления, в настоящий момент — <see cref="F:System.GCCollectionMode.Forced" />.</summary>
		// Token: 0x04001537 RID: 5431
		Default,
		/// <summary>Вызывает немедленное выполнение принудительной сборки мусора.</summary>
		// Token: 0x04001538 RID: 5432
		Forced,
		/// <summary>Позволяет сборщику мусора определить, является ли текущий момент оптимальным для освобождения объектов.</summary>
		// Token: 0x04001539 RID: 5433
		Optimized
	}
}
