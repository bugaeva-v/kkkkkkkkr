using System;

namespace System.Data.OleDb
{
	/// <summary>Возвращает тип таблицы схемы, указываемой методом <see cref="M:System.Data.OleDb.OleDbConnection.GetOleDbSchemaTable(System.Guid,System.Object[])" />.</summary>
	// Token: 0x02000173 RID: 371
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbSchemaGuid
	{
		/// <summary>Возвращает утверждения, определенные в каталоге, владельцем которого является указанный пользователь.</summary>
		// Token: 0x04000C02 RID: 3074
		public static readonly Guid Assertions;

		/// <summary>Возвращает физические атрибуты, связанные с каталогами, доступными из источника данных. Возвращает утверждения, определенные в каталоге, владельцем которого является указанный пользователь.</summary>
		// Token: 0x04000C03 RID: 3075
		public static readonly Guid Catalogs;

		/// <summary>Возвращает наборы символов, определенные в каталоге, который доступен указанному пользователю.</summary>
		// Token: 0x04000C04 RID: 3076
		public static readonly Guid Character_Sets;

		/// <summary>Возвращает ограничения проверки, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C05 RID: 3077
		public static readonly Guid Check_Constraints;

		/// <summary>Возвращает ограничения проверки, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C06 RID: 3078
		public static readonly Guid Check_Constraints_By_Table;

		/// <summary>Возвращает сравнения знаков, определенные в каталоге, который доступен указанному пользователю.</summary>
		// Token: 0x04000C07 RID: 3079
		public static readonly Guid Collations;

		/// <summary>Возвращает столбцы, определенные в каталоге и зависящие от домена, определенного в каталоге и принадлежащего указанному пользователю.</summary>
		// Token: 0x04000C08 RID: 3080
		public static readonly Guid Column_Domain_Usage;

		/// <summary>Возвращает привилегии для столбцов таблиц, определенные в каталоге и доступные указанному пользователю или предоставленные ему.</summary>
		// Token: 0x04000C09 RID: 3081
		public static readonly Guid Column_Privileges;

		/// <summary>Возвращает столбцы таблиц (включая представления), определенные в каталоге, который доступен указанному пользователю.</summary>
		// Token: 0x04000C0A RID: 3082
		public static readonly Guid Columns;

		/// <summary>Возвращает столбцы, используемые ссылочными ограничениями, уникальными ограничениями, ограничениями проверки и утверждениями, определенными в каталоге и принадлежащими указанному пользователю.</summary>
		// Token: 0x04000C0B RID: 3083
		public static readonly Guid Constraint_Column_Usage;

		/// <summary>Возвращает таблицы, используемые ссылочными ограничениями, уникальными ограничениями, ограничениями проверки и утверждениями, определенными в каталоге и принадлежащими указанному пользователю.</summary>
		// Token: 0x04000C0C RID: 3084
		public static readonly Guid Constraint_Table_Usage;

		/// <summary>Возвращает список ключевых слов, специфичных для конкретного поставщика.</summary>
		// Token: 0x04000C0D RID: 3085
		public static readonly Guid DbInfoKeywords;

		/// <summary>Возвращает список литералов, используемых в текстовых командах и специфичных для конкретного поставщика.</summary>
		// Token: 0x04000C0E RID: 3086
		public static readonly Guid DbInfoLiterals;

		/// <summary>Возвращает столбцы внешнего ключа, определенные в каталоге данным пользователем.</summary>
		// Token: 0x04000C0F RID: 3087
		public static readonly Guid Foreign_Keys;

		/// <summary>Возвращает индексы, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C10 RID: 3088
		public static readonly Guid Indexes;

		/// <summary>Возвращает столбцы, определенные в каталоге, который ограничивается ключами данным пользователем.</summary>
		// Token: 0x04000C11 RID: 3089
		public static readonly Guid Key_Column_Usage;

		/// <summary>Возвращает столбцы первичного ключа, определенные в каталоге данным пользователем.</summary>
		// Token: 0x04000C12 RID: 3090
		public static readonly Guid Primary_Keys;

		/// <summary>Возвращает сведения о столбцах наборов строк, возвращаемых процедурами.</summary>
		// Token: 0x04000C13 RID: 3091
		public static readonly Guid Procedure_Columns;

		/// <summary>Возвращает сведения о параметрах и кодах возврата процедур.</summary>
		// Token: 0x04000C14 RID: 3092
		public static readonly Guid Procedure_Parameters;

		/// <summary>Возвращает процедуры, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C15 RID: 3093
		public static readonly Guid Procedures;

		/// <summary>Возвращает основные типы данных, поддерживаемые поставщиком данных .NET Framework для OLE DB.</summary>
		// Token: 0x04000C16 RID: 3094
		public static readonly Guid Provider_Types;

		/// <summary>Возвращает ссылочные ограничения, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C17 RID: 3095
		public static readonly Guid Referential_Constraints;

		/// <summary>Возвращает список наборов строк схемы, идентифицируемых по их идентификаторам GUID, и указатель на описания столбцов ограничений.</summary>
		// Token: 0x04000C18 RID: 3096
		public static readonly Guid SchemaGuids;

		/// <summary>Возвращает объекты схемы, принадлежащие указанному пользователю.</summary>
		// Token: 0x04000C19 RID: 3097
		public static readonly Guid Schemata;

		/// <summary>Возвращает уровни соответствия, параметры и диалекты, поддерживаемые данными обработки реализации SQL, которые определены в каталоге.</summary>
		// Token: 0x04000C1A RID: 3098
		public static readonly Guid Sql_Languages;

		/// <summary>Возвращает статистические данные, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C1B RID: 3099
		public static readonly Guid Statistics;

		/// <summary>Возвращает табличные ограничения, определенные в каталоге, который принадлежит указанному пользователю.</summary>
		// Token: 0x04000C1C RID: 3100
		public static readonly Guid Table_Constraints;

		/// <summary>Возвращает привилегии для таблиц, определенных в каталоге и доступных указанному пользователю или предоставленных им.</summary>
		// Token: 0x04000C1D RID: 3101
		public static readonly Guid Table_Privileges;

		/// <summary>Описывает доступный набор статистических данных по таблицам для поставщика.</summary>
		// Token: 0x04000C1E RID: 3102
		public static readonly Guid Table_Statistics;

		/// <summary>Возвращает таблицы (включая представления), определенные в каталоге и доступные указанному пользователю.</summary>
		// Token: 0x04000C1F RID: 3103
		public static readonly Guid Tables;

		/// <summary>Возвращает таблицы (включая представления), доступные указанному пользователю.</summary>
		// Token: 0x04000C20 RID: 3104
		public static readonly Guid Tables_Info;

		/// <summary>Возвращает преобразования знаков, определенные в каталоге, который доступен указанному пользователю.</summary>
		// Token: 0x04000C21 RID: 3105
		public static readonly Guid Translations;

		/// <summary>Определяет доверенные объекты, заданные в источнике данных.</summary>
		// Token: 0x04000C22 RID: 3106
		public static readonly Guid Trustee;

		/// <summary>Возвращает привилегии USAGE для объектов, определенные в каталоге и доступные указанному пользователю или предоставленные им.</summary>
		// Token: 0x04000C23 RID: 3107
		public static readonly Guid Usage_Privileges;

		/// <summary>Возвращает столбцы, от которых зависят просматриваемые таблицы, определенные в каталоге и принадлежащие данному пользователю.</summary>
		// Token: 0x04000C24 RID: 3108
		public static readonly Guid View_Column_Usage;

		/// <summary>Возвращает таблицы, от которых зависят просматриваемые таблицы, определенные в каталоге и принадлежащие данному пользователю.</summary>
		// Token: 0x04000C25 RID: 3109
		public static readonly Guid View_Table_Usage;

		/// <summary>Возвращает представления, определенные в каталоге, который доступен указанному пользователю.</summary>
		// Token: 0x04000C26 RID: 3110
		public static readonly Guid Views;
	}
}
