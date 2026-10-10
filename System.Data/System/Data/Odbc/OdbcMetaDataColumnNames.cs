using System;

namespace System.Data.Odbc
{
	/// <summary>Предоставляет статические значения, которые используются для имен столбцов в объектах <see cref="T:System.Data.Odbc.OdbcMetaDataCollectionNames" />, содержащихся в таблице <see cref="T:System.Data.DataTable" />. Объект <see cref="T:System.Data.DataTable" /> создан с помощью метода GetSchema.</summary>
	// Token: 0x020002F0 RID: 752
	public static class OdbcMetaDataColumnNames
	{
		/// <summary>Используется методом GetSchema для создания столбца BooleanFalseLiteral.</summary>
		// Token: 0x040017C7 RID: 6087
		public static readonly string BooleanFalseLiteral = "BooleanFalseLiteral";

		/// <summary>Используется методом GetSchema для создания столбца BooleanTrueLiteral.</summary>
		// Token: 0x040017C8 RID: 6088
		public static readonly string BooleanTrueLiteral = "BooleanTrueLiteral";

		/// <summary>Используется методом GetSchema для создания столбца SQLType.</summary>
		// Token: 0x040017C9 RID: 6089
		public static readonly string SQLType = "SQLType";
	}
}
