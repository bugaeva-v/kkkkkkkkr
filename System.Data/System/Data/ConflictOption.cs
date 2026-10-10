using System;

namespace System.Data
{
	/// <summary>Указывает, каким образом конфликтующие изменения в источнике данных будут выявляться и разрешаться.</summary>
	// Token: 0x020000A7 RID: 167
	public enum ConflictOption
	{
		/// <summary>Операторы обновления и удаления будут включать все столбцы, по которым может осуществляться поиск, из таблицы в предложении WHERE. Это эквивалентно заданию <see langword="CompareAllValuesUpdate" /> | <see langword="CompareAllValuesDelete" />.</summary>
		// Token: 0x04000773 RID: 1907
		CompareAllSearchableValues = 1,
		/// <summary>Если в таблице имеются столбцы Timestamp, они используются в предложении WHERE для всех созданных операторов обновления. Это эквивалентно заданию <see langword="CompareRowVersionUpdate" /> | <see langword="CompareRowVersionDelete" />.</summary>
		// Token: 0x04000774 RID: 1908
		CompareRowVersion,
		/// <summary>Все операторы обновления и удаления включают только столбцы свойства <see cref="P:System.Data.DataTable.PrimaryKey" /> в предложении WHERE. Если не определено ни одно значение свойства <see cref="P:System.Data.DataTable.PrimaryKey" />, все столбцы, по которым может осуществляться поиск, включаются в предложение WHERE. Это эквивалентно <see langword="OverwriteChangesUpdate" /> | <see langword="OverwriteChangesDelete" />.</summary>
		// Token: 0x04000775 RID: 1909
		OverwriteChanges
	}
}
