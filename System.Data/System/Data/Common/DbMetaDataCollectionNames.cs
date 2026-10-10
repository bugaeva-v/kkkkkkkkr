using System;

namespace System.Data.Common
{
	/// <summary>Предоставляет список констант для хорошо известных коллекций MetaDataCollections: DataSourceInformation, DataTypes, MetaDataCollections, ReservedWords и Restrictions.</summary>
	// Token: 0x02000399 RID: 921
	public static class DbMetaDataCollectionNames
	{
		/// <summary>Константа для использования с методом <see cref="M:System.Data.Common.DbConnection.GetSchema" />, представляющим коллекцию MetaDataCollections.</summary>
		// Token: 0x04001B59 RID: 7001
		public static readonly string MetaDataCollections = "MetaDataCollections";

		/// <summary>Константа для использования с методом <see cref="M:System.Data.Common.DbConnection.GetSchema" />, представляющим коллекцию DataSourceInformation.</summary>
		// Token: 0x04001B5A RID: 7002
		public static readonly string DataSourceInformation = "DataSourceInformation";

		/// <summary>Константа для использования с методом <see cref="M:System.Data.Common.DbConnection.GetSchema" />, представляющим коллекцию DataTypes.</summary>
		// Token: 0x04001B5B RID: 7003
		public static readonly string DataTypes = "DataTypes";

		/// <summary>Константа для использования с методом <see cref="M:System.Data.Common.DbConnection.GetSchema" />, представляющим коллекцию Restrictions.</summary>
		// Token: 0x04001B5C RID: 7004
		public static readonly string Restrictions = "Restrictions";

		/// <summary>Константа для использования с методом <see cref="M:System.Data.Common.DbConnection.GetSchema" />, представляющим коллекцию ReservedWords.</summary>
		// Token: 0x04001B5D RID: 7005
		public static readonly string ReservedWords = "ReservedWords";
	}
}
