using System;

namespace System.Data.Common
{
	/// <summary>Описывает метаданные столбца схемы для таблицы базы данных.</summary>
	// Token: 0x020003BA RID: 954
	public static class SchemaTableColumn
	{
		/// <summary>Указывает имя столбца в таблице схемы.</summary>
		// Token: 0x04001BBB RID: 7099
		public static readonly string ColumnName = "ColumnName";

		/// <summary>Указывает порядковый номер столбца.</summary>
		// Token: 0x04001BBC RID: 7100
		public static readonly string ColumnOrdinal = "ColumnOrdinal";

		/// <summary>Указывает размер столбца.</summary>
		// Token: 0x04001BBD RID: 7101
		public static readonly string ColumnSize = "ColumnSize";

		/// <summary>Указывает точность данных в столбце, если данные являются числовыми.</summary>
		// Token: 0x04001BBE RID: 7102
		public static readonly string NumericPrecision = "NumericPrecision";

		/// <summary>Указывает масштаб данных в столбце, если данные являются числовыми.</summary>
		// Token: 0x04001BBF RID: 7103
		public static readonly string NumericScale = "NumericScale";

		/// <summary>Указывает тип данных в столбце.</summary>
		// Token: 0x04001BC0 RID: 7104
		public static readonly string DataType = "DataType";

		/// <summary>Указывает зависящий от поставщика тип данных в столбце.</summary>
		// Token: 0x04001BC1 RID: 7105
		public static readonly string ProviderType = "ProviderType";

		/// <summary>Указывает зависящий от поставщика тип данных в столбце, которому не была присвоена версия.</summary>
		// Token: 0x04001BC2 RID: 7106
		public static readonly string NonVersionedProviderType = "NonVersionedProviderType";

		/// <summary>Указывает, содержит ли этот столбец большие объемы данных.</summary>
		// Token: 0x04001BC3 RID: 7107
		public static readonly string IsLong = "IsLong";

		/// <summary>Указывает, является ли допустимым значение <see langword="DBNull" />.</summary>
		// Token: 0x04001BC4 RID: 7108
		public static readonly string AllowDBNull = "AllowDBNull";

		/// <summary>Указывает, является ли этот столбец псевдонимом.</summary>
		// Token: 0x04001BC5 RID: 7109
		public static readonly string IsAliased = "IsAliased";

		/// <summary>Указывает, является ли этот столбец выражением.</summary>
		// Token: 0x04001BC6 RID: 7110
		public static readonly string IsExpression = "IsExpression";

		/// <summary>Указывает, является ли этот столбец ключом для таблицы.</summary>
		// Token: 0x04001BC7 RID: 7111
		public static readonly string IsKey = "IsKey";

		/// <summary>Указывает, применяется ли уникальное ограничение к этому столбцу.</summary>
		// Token: 0x04001BC8 RID: 7112
		public static readonly string IsUnique = "IsUnique";

		/// <summary>Указывает имя схемы в таблице схемы.</summary>
		// Token: 0x04001BC9 RID: 7113
		public static readonly string BaseSchemaName = "BaseSchemaName";

		/// <summary>Указывает имя таблицы в таблице схемы.</summary>
		// Token: 0x04001BCA RID: 7114
		public static readonly string BaseTableName = "BaseTableName";

		/// <summary>Указывает имя столбца в таблице схемы.</summary>
		// Token: 0x04001BCB RID: 7115
		public static readonly string BaseColumnName = "BaseColumnName";
	}
}
