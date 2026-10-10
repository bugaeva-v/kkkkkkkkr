using System;

namespace System.Data
{
	/// <summary>Указывает тип параметра в запросе к объекту <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000113 RID: 275
	public enum ParameterDirection
	{
		/// <summary>Параметр является входным.</summary>
		// Token: 0x04000992 RID: 2450
		Input = 1,
		/// <summary>Параметр является выходным.</summary>
		// Token: 0x04000993 RID: 2451
		Output,
		/// <summary>Параметр может быть как входным, так и выходным.</summary>
		// Token: 0x04000994 RID: 2452
		InputOutput,
		/// <summary>Параметр представляет значение, возвращаемое как результат операции, например хранимой процедуры, встроенной функции или определяемой пользователем функции.</summary>
		// Token: 0x04000995 RID: 2453
		ReturnValue = 6
	}
}
