using System;
using System.Collections;

namespace System.Data
{
	/// <summary>Содержит коллекцию объектов DataColumnMapping. Этот интерфейс реализуется классом <see cref="T:System.Data.Common.DataColumnMappingCollection" />, который совместно используется поставщиками данных .NET Framework.</summary>
	// Token: 0x020000FD RID: 253
	public interface IColumnMappingCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает объект <see cref="T:System.Data.IColumnMapping" /> с указанным именем <see langword="SourceColumn" />.</summary>
		/// <param name="index">Имя <see langword="SourceColumn" /> для искомого объекта <see langword="IColumnMapping" />.</param>
		/// <returns>Объект <see langword="IColumnMapping" /> с указанным именем <see langword="SourceColumn" />.</returns>
		// Token: 0x1700028B RID: 651
		object this[string index]
		{
			get;
			set;
		}

		/// <summary>Добавляет объект ColumnMapping к коллекции ColumnMapping, используя имена столбца-источника и столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="sourceColumnName">Зависящее от регистра имя исходного столбца.</param>
		/// <param name="dataSetColumnName">Имя столбца <see cref="T:System.Data.DataSet" />.</param>
		/// <returns>Объект ColumnMapping, который был добавлен в коллекцию.</returns>
		// Token: 0x06000F05 RID: 3845
		IColumnMapping Add(string sourceColumnName, string dataSetColumnName);

		/// <summary>Возвращает значение, указывающее, содержится ли в коллекции <see cref="T:System.Data.Common.DataColumnMappingCollection" /> объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем столбца-источника.</summary>
		/// <param name="sourceColumnName">Зависящее от регистра имя исходного столбца.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем столбца-источника существует; в обратном случае – значение <see langword="false" />.</returns>
		// Token: 0x06000F06 RID: 3846
		bool Contains(string sourceColumnName);

		/// <summary>Возвращает объект ColumnMapping, соответствующий указанному имени столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetColumnName">Имя столбца <see cref="T:System.Data.DataSet" /> в коллекции.</param>
		/// <returns>Объект ColumnMapping, соответствующий указанному имени <see langword="DataSet" />.</returns>
		// Token: 0x06000F07 RID: 3847
		IColumnMapping GetByDataSetColumn(string dataSetColumnName);

		/// <summary>Возвращает расположение объекта <see cref="T:System.Data.Common.DataColumnMapping" />, соответствующего указанному имени столбца-источника. Имя указано с учетом регистра.</summary>
		/// <param name="sourceColumnName">Зависящее от регистра имя исходного столбца.</param>
		/// <returns>Расположение объекта <see langword="DataColumnMapping" />, соответствующего указанному имени столбца-источника (отсчет ведется с нуля).</returns>
		// Token: 0x06000F08 RID: 3848
		int IndexOf(string sourceColumnName);

		/// <summary>Удаляет объект <see cref="T:System.Data.IColumnMapping" /> с указанным именем <see cref="P:System.Data.IColumnMapping.SourceColumn" /> из коллекции.</summary>
		/// <param name="sourceColumnName">Имя <see langword="SourceColumn" /> с учетом регистра.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">Объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем <see langword="SourceColumn" /> не существует.</exception>
		// Token: 0x06000F09 RID: 3849
		void RemoveAt(string sourceColumnName);
	}
}
