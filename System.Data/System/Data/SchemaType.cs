using System;

namespace System.Data
{
	/// <summary>Указывает, как будут обрабатываться существующие сопоставления схемы при выполнении операции <see cref="M:System.Data.Common.DataAdapter.FillSchema(System.Data.DataSet,System.Data.SchemaType)" />.</summary>
	// Token: 0x02000124 RID: 292
	public enum SchemaType
	{
		/// <summary>Все сопоставления таблиц в DataAdapter будут игнорироваться. При конфигурировании <see cref="T:System.Data.DataSet" /> будет использоваться непреобразованная входящая схема.</summary>
		// Token: 0x040009E5 RID: 2533
		Source = 1,
		/// <summary>Все существующие сопоставления таблиц будут применяться к входящей схеме. При конфигурировании <see cref="T:System.Data.DataSet" /> будет использоваться преобразованная схема.</summary>
		// Token: 0x040009E6 RID: 2534
		Mapped
	}
}
