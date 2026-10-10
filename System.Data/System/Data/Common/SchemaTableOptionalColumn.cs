using System;

namespace System.Data.Common
{
	/// <summary>Описывает дополнительные метаданные столбца схемы для таблицы базы данных.</summary>
	// Token: 0x020003BB RID: 955
	public static class SchemaTableOptionalColumn
	{
		/// <summary>Указывает зависящий от поставщика тип данных в столбце.</summary>
		// Token: 0x04001BCC RID: 7116
		public static readonly string ProviderSpecificDataType = "ProviderSpecificDataType";

		/// <summary>Указывает, увеличиваются ли автоматически значения столбца в столбце.</summary>
		// Token: 0x04001BCD RID: 7117
		public static readonly string IsAutoIncrement = "IsAutoIncrement";

		/// <summary>Указывает, является ли этот столбец скрытым.</summary>
		// Token: 0x04001BCE RID: 7118
		public static readonly string IsHidden = "IsHidden";

		/// <summary>Указывает, является ли этот столбец доступным только для чтения.</summary>
		// Token: 0x04001BCF RID: 7119
		public static readonly string IsReadOnly = "IsReadOnly";

		/// <summary>Указывает, содержит ли данный столбец сведения о версии строки.</summary>
		// Token: 0x04001BD0 RID: 7120
		public static readonly string IsRowVersion = "IsRowVersion";

		/// <summary>Имя сервера столбца.</summary>
		// Token: 0x04001BD1 RID: 7121
		public static readonly string BaseServerName = "BaseServerName";

		/// <summary>Имя каталога, связанного с результатами последнего запроса.</summary>
		// Token: 0x04001BD2 RID: 7122
		public static readonly string BaseCatalogName = "BaseCatalogName";

		/// <summary>Указывает значение, при котором назначается ряд для новых столбцов идентификаторов.</summary>
		// Token: 0x04001BD3 RID: 7123
		public static readonly string AutoIncrementSeed = "AutoIncrementSeed";

		/// <summary>Указывает увеличение между значениями в столбце идентификаторов.</summary>
		// Token: 0x04001BD4 RID: 7124
		public static readonly string AutoIncrementStep = "AutoIncrementStep";

		/// <summary>Значение по умолчанию для столбца.</summary>
		// Token: 0x04001BD5 RID: 7125
		public static readonly string DefaultValue = "DefaultValue";

		/// <summary>Выражение, используемое для вычисления столбца.</summary>
		// Token: 0x04001BD6 RID: 7126
		public static readonly string Expression = "Expression";

		/// <summary>Пространство имен для таблицы, содержащей данный столбец.</summary>
		// Token: 0x04001BD7 RID: 7127
		public static readonly string BaseTableNamespace = "BaseTableNamespace";

		/// <summary>Пространство имен столбца.</summary>
		// Token: 0x04001BD8 RID: 7128
		public static readonly string BaseColumnNamespace = "BaseColumnNamespace";

		/// <summary>Указывает сопоставление для столбца.</summary>
		// Token: 0x04001BD9 RID: 7129
		public static readonly string ColumnMapping = "ColumnMapping";
	}
}
