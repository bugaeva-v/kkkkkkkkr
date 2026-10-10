using System;

namespace System.Data
{
	/// <summary>Указывает действие, которое должно быть выполнено для обеспечения ограничения <see cref="T:System.Data.ForeignKeyConstraint" />.</summary>
	// Token: 0x02000122 RID: 290
	public enum Rule
	{
		/// <summary>К связанным строкам действия не применялись.</summary>
		// Token: 0x040009DD RID: 2525
		None,
		/// <summary>Удалить или обновить связанные строки. Это значение по умолчанию.</summary>
		// Token: 0x040009DE RID: 2526
		Cascade,
		/// <summary>Задайте связанным строкам значение <see langword="DBNull" />.</summary>
		// Token: 0x040009DF RID: 2527
		SetNull,
		/// <summary>Задайте связанным строкам значения, содержащиеся в свойстве <see cref="P:System.Data.DataColumn.DefaultValue" />.</summary>
		// Token: 0x040009E0 RID: 2528
		SetDefault
	}
}
