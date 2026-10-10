using System;

namespace System.Data.Common
{
	/// <summary>Предоставляет статические значения, которые используются для имен столбцов в объектах MetaDataCollection, содержащихся в <see cref="T:System.Data.DataTable" />. Объект <see cref="T:System.Data.DataTable" /> создан с помощью метода GetSchema.</summary>
	// Token: 0x0200039A RID: 922
	public static class DbMetaDataColumnNames
	{
		/// <summary>Используется методом GetSchema для создания столбца CollectionName в коллекции DataTypes.</summary>
		// Token: 0x04001B5E RID: 7006
		public static readonly string CollectionName = "CollectionName";

		/// <summary>Используется методом GetSchema для создания столбца ColumnSize в коллекции DataTypes.</summary>
		// Token: 0x04001B5F RID: 7007
		public static readonly string ColumnSize = "ColumnSize";

		/// <summary>Используется методом GetSchema для создания столбца CompositeIdentifierSeparatorPattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B60 RID: 7008
		public static readonly string CompositeIdentifierSeparatorPattern = "CompositeIdentifierSeparatorPattern";

		/// <summary>Используется методом GetSchema для создания столбца CreateFormat в коллекции DataTypes.</summary>
		// Token: 0x04001B61 RID: 7009
		public static readonly string CreateFormat = "CreateFormat";

		/// <summary>Используется методом GetSchema для создания столбца CreateParameters в коллекции DataTypes.</summary>
		// Token: 0x04001B62 RID: 7010
		public static readonly string CreateParameters = "CreateParameters";

		/// <summary>Используется методом GetSchema для создания столбца DataSourceProductName в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B63 RID: 7011
		public static readonly string DataSourceProductName = "DataSourceProductName";

		/// <summary>Используется методом GetSchema для создания столбца DataSourceProductVersion в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B64 RID: 7012
		public static readonly string DataSourceProductVersion = "DataSourceProductVersion";

		/// <summary>Используется методом GetSchema для создания столбца DataType в коллекции DataTypes.</summary>
		// Token: 0x04001B65 RID: 7013
		public static readonly string DataType = "DataType";

		/// <summary>Используется методом GetSchema для создания столбца DataSourceProductVersionNormalized в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B66 RID: 7014
		public static readonly string DataSourceProductVersionNormalized = "DataSourceProductVersionNormalized";

		/// <summary>Используется методом GetSchema для создания столбца GroupByBehavior в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B67 RID: 7015
		public static readonly string GroupByBehavior = "GroupByBehavior";

		/// <summary>Используется методом GetSchema для создания столбца IdentifierCase в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B68 RID: 7016
		public static readonly string IdentifierCase = "IdentifierCase";

		/// <summary>Используется методом GetSchema для создания столбца IdentifierPattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B69 RID: 7017
		public static readonly string IdentifierPattern = "IdentifierPattern";

		/// <summary>Используется методом GetSchema для создания столбца IsAutoIncrementable в коллекции DataTypes.</summary>
		// Token: 0x04001B6A RID: 7018
		public static readonly string IsAutoIncrementable = "IsAutoIncrementable";

		/// <summary>Используется методом GetSchema для создания столбца IsBestMatch в коллекции DataTypes.</summary>
		// Token: 0x04001B6B RID: 7019
		public static readonly string IsBestMatch = "IsBestMatch";

		/// <summary>Используется методом GetSchema для создания столбца IsCaseSensitive в коллекции DataTypes.</summary>
		// Token: 0x04001B6C RID: 7020
		public static readonly string IsCaseSensitive = "IsCaseSensitive";

		/// <summary>Используется методом GetSchema для создания столбца IsConcurrencyType в коллекции DataTypes.</summary>
		// Token: 0x04001B6D RID: 7021
		public static readonly string IsConcurrencyType = "IsConcurrencyType";

		/// <summary>Используется методом GetSchema для создания столбца IsFixedLengthв коллекции DataTypes.</summary>
		// Token: 0x04001B6E RID: 7022
		public static readonly string IsFixedLength = "IsFixedLength";

		/// <summary>Используется методом GetSchema для создания столбца IsFixedPrecisionScale в коллекции DataTypes.</summary>
		// Token: 0x04001B6F RID: 7023
		public static readonly string IsFixedPrecisionScale = "IsFixedPrecisionScale";

		/// <summary>Используется методом GetSchema для создания столбца IsLiteralSupported в коллекции DataTypes.</summary>
		// Token: 0x04001B70 RID: 7024
		public static readonly string IsLiteralSupported = "IsLiteralSupported";

		/// <summary>Используется методом GetSchema для создания столбца IsLong в коллекции DataTypes.</summary>
		// Token: 0x04001B71 RID: 7025
		public static readonly string IsLong = "IsLong";

		/// <summary>Используется методом GetSchema для создания столбца IsNullable в коллекции DataTypes.</summary>
		// Token: 0x04001B72 RID: 7026
		public static readonly string IsNullable = "IsNullable";

		/// <summary>Используется методом GetSchema для создания столбца IsSearchable в коллекции DataTypes.</summary>
		// Token: 0x04001B73 RID: 7027
		public static readonly string IsSearchable = "IsSearchable";

		/// <summary>Используется методом GetSchema для создания столбца IsSearchableWithLike в коллекции DataTypes.</summary>
		// Token: 0x04001B74 RID: 7028
		public static readonly string IsSearchableWithLike = "IsSearchableWithLike";

		/// <summary>Используется методом GetSchema для создания столбца IsUnsigned в коллекции DataTypes.</summary>
		// Token: 0x04001B75 RID: 7029
		public static readonly string IsUnsigned = "IsUnsigned";

		/// <summary>Используется методом GetSchema для создания столбца LiteralPrefix в коллекции DataTypes.</summary>
		// Token: 0x04001B76 RID: 7030
		public static readonly string LiteralPrefix = "LiteralPrefix";

		/// <summary>Используется методом GetSchema для создания столбца LiteralSuffix в коллекции DataTypes.</summary>
		// Token: 0x04001B77 RID: 7031
		public static readonly string LiteralSuffix = "LiteralSuffix";

		/// <summary>Используется методом GetSchema для создания столбца MaximumScale в коллекции DataTypes.</summary>
		// Token: 0x04001B78 RID: 7032
		public static readonly string MaximumScale = "MaximumScale";

		/// <summary>Используется методом GetSchema для создания столбца MinimumScale в коллекции DataTypes.</summary>
		// Token: 0x04001B79 RID: 7033
		public static readonly string MinimumScale = "MinimumScale";

		/// <summary>Используется методом GetSchema для создания столбца NumberOfIdentifierParts в коллекции MetaDataCollections.</summary>
		// Token: 0x04001B7A RID: 7034
		public static readonly string NumberOfIdentifierParts = "NumberOfIdentifierParts";

		/// <summary>Используется методом GetSchema для создания столбца NumberOfRestrictions в коллекции MetaDataCollections.</summary>
		// Token: 0x04001B7B RID: 7035
		public static readonly string NumberOfRestrictions = "NumberOfRestrictions";

		/// <summary>Используется методом GetSchema для создания столбца OrderByColumnsInSelect в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B7C RID: 7036
		public static readonly string OrderByColumnsInSelect = "OrderByColumnsInSelect";

		/// <summary>Используется методом GetSchema для создания столбца ParameterMarkerFormat в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B7D RID: 7037
		public static readonly string ParameterMarkerFormat = "ParameterMarkerFormat";

		/// <summary>Используется методом GetSchema для создания столбца ParameterMarkerPattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B7E RID: 7038
		public static readonly string ParameterMarkerPattern = "ParameterMarkerPattern";

		/// <summary>Используется методом GetSchema для создания столбца ParameterNameMaxLength в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B7F RID: 7039
		public static readonly string ParameterNameMaxLength = "ParameterNameMaxLength";

		/// <summary>Используется методом GetSchema для создания столбца ParameterNamePattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B80 RID: 7040
		public static readonly string ParameterNamePattern = "ParameterNamePattern";

		/// <summary>Используется методом GetSchema для создания столбца ProviderDbType в коллекции DataTypes.</summary>
		// Token: 0x04001B81 RID: 7041
		public static readonly string ProviderDbType = "ProviderDbType";

		/// <summary>Используется методом GetSchema для создания столбца QuotedIdentifierCase в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B82 RID: 7042
		public static readonly string QuotedIdentifierCase = "QuotedIdentifierCase";

		/// <summary>Используется методом GetSchema для создания столбца QuotedIdentifierPattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B83 RID: 7043
		public static readonly string QuotedIdentifierPattern = "QuotedIdentifierPattern";

		/// <summary>Используется методом GetSchema для создания столбца ReservedWord в коллекции ReservedWords.</summary>
		// Token: 0x04001B84 RID: 7044
		public static readonly string ReservedWord = "ReservedWord";

		/// <summary>Используется методом GetSchema для создания столбца StatementSeparatorPattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B85 RID: 7045
		public static readonly string StatementSeparatorPattern = "StatementSeparatorPattern";

		/// <summary>Используется методом GetSchema для создания столбца StringLiteralPattern в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B86 RID: 7046
		public static readonly string StringLiteralPattern = "StringLiteralPattern";

		/// <summary>Используется методом GetSchema для создания столбца SupportedJoinOperators в коллекции DataSourceInformation.</summary>
		// Token: 0x04001B87 RID: 7047
		public static readonly string SupportedJoinOperators = "SupportedJoinOperators";

		/// <summary>Используется методом GetSchema для создания столбца TypeName в коллекции DataTypes.</summary>
		// Token: 0x04001B88 RID: 7048
		public static readonly string TypeName = "TypeName";
	}
}
