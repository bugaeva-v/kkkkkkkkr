using System;
using System.Collections;

namespace System.Data
{
	/// <summary>Содержит коллекцию объектов TableMapping и реализуется коллекцией <see cref="T:System.Data.Common.DataTableMappingCollection" />, которая обычно используется поставщиками данных .NET Framework.</summary>
	// Token: 0x02000109 RID: 265
	public interface ITableMappingCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает экземпляр класса <see cref="T:System.Data.ITableMapping" /> с указанным именем <see cref="P:System.Data.ITableMapping.SourceTable" />.</summary>
		/// <param name="index">Имя <see langword="SourceTable" /> объекта <see cref="T:System.Data.ITableMapping" />.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Data.ITableMapping" /> с указанным именем <see langword="SourceTable" />.</returns>
		// Token: 0x170002B4 RID: 692
		object this[string index]
		{
			get;
			set;
		}

		/// <summary>Добавляет сопоставление таблицы в коллекцию.</summary>
		/// <param name="sourceTableName">Имя исходной таблицы с учетом регистра.</param>
		/// <param name="dataSetTableName">Имя таблицы <see cref="T:System.Data.DataSet" />.</param>
		/// <returns>Ссылка на вновь сопоставленный объект <see cref="T:System.Data.ITableMapping" />.</returns>
		// Token: 0x06000F7D RID: 3965
		ITableMapping Add(string sourceTableName, string dataSetTableName);

		/// <summary>Получает значение, указывающее на наличие в коллекции сопоставления таблицы с указанным именем исходной таблицы.</summary>
		/// <param name="sourceTableName">Имя исходной таблицы с учетом регистра.</param>
		/// <returns>Значение <see langword="true" />, если сопоставление таблицы с указанным именем исходной таблицы существует; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F7E RID: 3966
		bool Contains(string sourceTableName);

		/// <summary>Получает объект TableMapping с указанным именем таблицы <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetTableName">Имя таблицы <see langword="DataSet" /> в коллекции.</param>
		/// <returns>Объект TableMapping с указанным именем таблицы <see langword="DataSet" />.</returns>
		// Token: 0x06000F7F RID: 3967
		ITableMapping GetByDataSetTable(string dataSetTableName);

		/// <summary>Получает местоположение объекта <see cref="T:System.Data.ITableMapping" /> в коллекции.</summary>
		/// <param name="sourceTableName">Имя исходной таблицы с учетом регистра.</param>
		/// <returns>Получает местоположение объекта <see cref="T:System.Data.ITableMapping" /> в коллекции (отсчет ведется от нуля).</returns>
		// Token: 0x06000F80 RID: 3968
		int IndexOf(string sourceTableName);

		/// <summary>Удаляет объект <see cref="T:System.Data.ITableMapping" /> с указанным именем <see cref="P:System.Data.ITableMapping.SourceTable" /> из коллекции.</summary>
		/// <param name="sourceTableName">Имя <see langword="SourceTable" /> с учетом регистра.</param>
		// Token: 0x06000F81 RID: 3969
		void RemoveAt(string sourceTableName);
	}
}
