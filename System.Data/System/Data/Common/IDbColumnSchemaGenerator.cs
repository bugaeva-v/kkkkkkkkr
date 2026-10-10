using System;
using System.Collections.ObjectModel;

namespace System.Data.Common
{
	/// <summary>Создает схему столбца.</summary>
	// Token: 0x020003A3 RID: 931
	public interface IDbColumnSchemaGenerator
	{
		/// <summary>Получает схему столбца (коллекцию <see cref="T:System.Data.Common.DbColumn" />).</summary>
		/// <returns>Схема столбца (коллекция <see cref="T:System.Data.Common.DbColumn" />).</returns>
		// Token: 0x06002D2B RID: 11563
		ReadOnlyCollection<DbColumn> GetColumnSchema();
	}
}
