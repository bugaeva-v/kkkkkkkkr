using System;

namespace System.Data
{
	/// <summary>Связывает столбец источника данных со столбцом объекта <see cref="T:System.Data.DataSet" />. Этот интерфейс реализуется классом <see cref="T:System.Data.Common.DataColumnMapping" />, который совместно используется поставщиками данных .NET Framework.</summary>
	// Token: 0x020000FC RID: 252
	public interface IColumnMapping
	{
		/// <summary>Возвращает или задает имя столбца в объекте <see cref="T:System.Data.DataSet" /> для сопоставления.</summary>
		/// <returns>Имя столбца в объекте <see cref="T:System.Data.DataSet" /> для сопоставления. Имя без учета регистра.</returns>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000EFF RID: 3839
		// (set) Token: 0x06000F00 RID: 3840
		string DataSetColumn { get; set; }

		/// <summary>Возвращает или задает имя столбца в источнике данных для сопоставления. Имя указано с учетом регистра.</summary>
		/// <returns>Имя столбца в источнике данных, определяемое с учетом регистра.</returns>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000F01 RID: 3841
		// (set) Token: 0x06000F02 RID: 3842
		string SourceColumn { get; set; }
	}
}
