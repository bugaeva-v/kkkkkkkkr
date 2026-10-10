using System;

namespace System.Data
{
	/// <summary>Задает способ применения результатов команды запроса к обновляемой строке.</summary>
	// Token: 0x02000138 RID: 312
	public enum UpdateRowSource
	{
		/// <summary>Любые возвращенные параметры или строки пропускаются.</summary>
		// Token: 0x04000A51 RID: 2641
		None,
		/// <summary>Выходные параметры отображаются в измененной строке объекта <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x04000A52 RID: 2642
		OutputParameters,
		/// <summary>Данные первой возвращаемой строки отображаются в измененной строке объекта <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x04000A53 RID: 2643
		FirstReturnedRecord,
		/// <summary>Выходные параметры и первая возвращаемая строка отображаются в измененной строке объекта <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x04000A54 RID: 2644
		Both
	}
}
