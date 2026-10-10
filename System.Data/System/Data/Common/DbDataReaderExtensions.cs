using System;
using System.Collections.ObjectModel;

namespace System.Data.Common
{
	/// <summary>Этот класс содержит методы расширения схемы столбца для <see cref="T:System.Data.Common.DbDataReader" />.</summary>
	// Token: 0x02000393 RID: 915
	public static class DbDataReaderExtensions
	{
		/// <summary>Получает схему столбца (коллекцию <see cref="T:System.Data.Common.DbColumn" />) для <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <param name="reader">
		///   <see cref="T:System.Data.Common.DbDataReader" /> для возврата схемы столбца.</param>
		/// <returns>Схема столбца (коллекция <see cref="T:System.Data.Common.DbColumn" />) для <see cref="T:System.Data.Common.DbDataReader" />.</returns>
		// Token: 0x06002C77 RID: 11383 RVA: 0x000BEA54 File Offset: 0x000BCC54
		public static ReadOnlyCollection<DbColumn> GetColumnSchema(this DbDataReader reader)
		{
			if (reader.CanGetColumnSchema())
			{
				return ((IDbColumnSchemaGenerator)reader).GetColumnSchema();
			}
			throw new NotSupportedException();
		}

		/// <summary>Получает значение, которое указывает, может ли <see cref="T:System.Data.Common.DbDataReader" /> получить схему столбца.</summary>
		/// <param name="reader">
		///   <see cref="T:System.Data.Common.DbDataReader" />, который следует проверить на поддержку схемы столбца.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.Common.DbDataReader" /> может получить схему столбца; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002C78 RID: 11384 RVA: 0x000BEA6F File Offset: 0x000BCC6F
		public static bool CanGetColumnSchema(this DbDataReader reader)
		{
			return reader is IDbColumnSchemaGenerator;
		}
	}
}
