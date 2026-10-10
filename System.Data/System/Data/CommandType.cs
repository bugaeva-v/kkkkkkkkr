using System;

namespace System.Data
{
	/// <summary>Указывает способ интерпретации строки команды.</summary>
	// Token: 0x020000A5 RID: 165
	public enum CommandType
	{
		/// <summary>Текстовая команда SQL. (по умолчанию).</summary>
		// Token: 0x0400076A RID: 1898
		Text = 1,
		/// <summary>Имя хранимой процедуры.</summary>
		// Token: 0x0400076B RID: 1899
		StoredProcedure = 4,
		/// <summary>Имя таблицы.</summary>
		// Token: 0x0400076C RID: 1900
		TableDirect = 512
	}
}
