using System;

namespace System.Data
{
	/// <summary>Представляет набор связанных с командой свойств, которые используются для заполнения <see cref="T:System.Data.DataSet" /> и обновления источника данных, реализуемый поставщиками данных .NET Framework, осуществляющими доступ к реляционным базам данных.</summary>
	// Token: 0x02000105 RID: 261
	public interface IDbDataAdapter : IDataAdapter
	{
		/// <summary>Возвращает или задает оператор SQL для выбора записей в источнике данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для выбора записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000F64 RID: 3940
		// (set) Token: 0x06000F65 RID: 3941
		IDbCommand SelectCommand { get; set; }

		/// <summary>Возвращает или задает оператор SQL для вставки новых записей в источник данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для вставки записей в источник данных, соответствующих новым строкам в наборе данных.</returns>
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000F66 RID: 3942
		// (set) Token: 0x06000F67 RID: 3943
		IDbCommand InsertCommand { get; set; }

		/// <summary>Возвращает или задает оператор SQL для обновления записей в источнике данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для обновления записей в источнике данных, соответствующих измененным строкам в наборе данных.</returns>
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000F68 RID: 3944
		// (set) Token: 0x06000F69 RID: 3945
		IDbCommand UpdateCommand { get; set; }

		/// <summary>Возвращает или задает оператор SQL для удаления записей из набора данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для удаления записей в источнике данных, соответствующих удаленным строкам в наборе данных.</returns>
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000F6A RID: 3946
		// (set) Token: 0x06000F6B RID: 3947
		IDbCommand DeleteCommand { get; set; }
	}
}
