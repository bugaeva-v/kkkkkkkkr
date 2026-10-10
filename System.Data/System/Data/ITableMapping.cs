using System;

namespace System.Data
{
	/// <summary>Связывает исходную таблицу с таблицей в <see cref="T:System.Data.DataSet" /> и реализуется классом <see cref="T:System.Data.Common.DataTableMapping" />, который обычно используется поставщиками данных .NET Framework.</summary>
	// Token: 0x02000108 RID: 264
	public interface ITableMapping
	{
		/// <summary>Получает производной коллекции <see cref="T:System.Data.Common.DataColumnMappingCollection" /> для объекта <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>Коллекция сопоставлений столбцов данных.</returns>
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000F76 RID: 3958
		IColumnMappingCollection ColumnMappings { get; }

		/// <summary>Возвращает или задает имя таблицы в <see cref="T:System.Data.DataSet" /> без учета регистра.</summary>
		/// <returns>Имя таблицы в <see cref="T:System.Data.DataSet" /> без учета регистра.</returns>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000F77 RID: 3959
		// (set) Token: 0x06000F78 RID: 3960
		string DataSetTable { get; set; }

		/// <summary>Возвращает или задает имя исходной таблицы с учетом регистра.</summary>
		/// <returns>Имя исходной таблицы с учетом регистра.</returns>
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000F79 RID: 3961
		// (set) Token: 0x06000F7A RID: 3962
		string SourceTable { get; set; }
	}
}
