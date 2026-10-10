using System;

namespace System.Data.Odbc
{
	/// <summary>Предоставляет список констант для использования с методом GetSchema в целях извлечения коллекций метаданных.</summary>
	// Token: 0x020002EF RID: 751
	public static class OdbcMetaDataCollectionNames
	{
		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию Columns.</summary>
		// Token: 0x040017C0 RID: 6080
		public static readonly string Columns = "Columns";

		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию Indexes.</summary>
		// Token: 0x040017C1 RID: 6081
		public static readonly string Indexes = "Indexes";

		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию Procedures.</summary>
		// Token: 0x040017C2 RID: 6082
		public static readonly string Procedures = "Procedures";

		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию ProcedureColumns.</summary>
		// Token: 0x040017C3 RID: 6083
		public static readonly string ProcedureColumns = "ProcedureColumns";

		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию ProcedureParameters.</summary>
		// Token: 0x040017C4 RID: 6084
		public static readonly string ProcedureParameters = "ProcedureParameters";

		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию Tables.</summary>
		// Token: 0x040017C5 RID: 6085
		public static readonly string Tables = "Tables";

		/// <summary>Константа для использования с методом GetSchema, представляющая коллекцию Views.</summary>
		// Token: 0x040017C6 RID: 6086
		public static readonly string Views = "Views";
	}
}
