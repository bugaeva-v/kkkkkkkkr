using System;

namespace System.Data.SqlClient
{
	/// <summary>Задает способ сортировки строк.</summary>
	// Token: 0x0200018B RID: 395
	public enum SortOrder
	{
		/// <summary>По умолчанию. Порядок сортировки не задан.</summary>
		// Token: 0x04000CAA RID: 3242
		Unspecified = -1,
		/// <summary>Строки сортируются в порядке возрастания.</summary>
		// Token: 0x04000CAB RID: 3243
		Ascending,
		/// <summary>Строки сортируются в порядке убывания.</summary>
		// Token: 0x04000CAC RID: 3244
		Descending
	}
}
