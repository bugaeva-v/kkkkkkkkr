using System;

namespace System.Data
{
	/// <summary>Определяет действие, выполняемое при добавлении данных к <see cref="T:System.Data.DataSet" />, если необходимые объекты <see cref="T:System.Data.DataTable" /> или <see cref="T:System.Data.DataColumn" /> отсутствуют.</summary>
	// Token: 0x02000112 RID: 274
	public enum MissingSchemaAction
	{
		/// <summary>Добавляет необходимые столбцы для завершения схемы.</summary>
		// Token: 0x0400098D RID: 2445
		Add = 1,
		/// <summary>Игнорирует лишние столбцы.</summary>
		// Token: 0x0400098E RID: 2446
		Ignore,
		/// <summary>Если отсутствует сопоставление указанного столбца, создается исключение <see cref="T:System.InvalidOperationException" />.</summary>
		// Token: 0x0400098F RID: 2447
		Error,
		/// <summary>Добавляет необходимые столбцы и сведения о первичном ключе для завершения схемы. Дополнительные сведения о порядке добавления сведений о первичном ключе к <see cref="T:System.Data.DataTable" /> см. в описании метода <see cref="M:System.Data.IDataAdapter.FillSchema(System.Data.DataSet,System.Data.SchemaType)" />. Для правильного функционирования <see langword="AddWithKey" /> с поставщиком данных .NET Framework для Microsoft OLE DB необходимо, чтобы собственный поставщик Microsoft OLE DB получил необходимые сведения о первичном ключе путем задания свойства DBPROP_UNIQUEROWS и определил столбцы первичного ключа с помощью проверки свойства DBCOLUMN_KEYCOLUMN в IColumnsRowset. В качестве альтернативного варианта пользователь может явно задать ограничения первичного ключа для каждого объекта <see cref="T:System.Data.DataTable" />. Это гарантирует, что при добавлении записей, соответствующих уже имеющимся записям, они будут обновляться, а не дописываться в конец. При использовании метода <see langword="AddWithKey" /> поставщик данных .NET Framework для SQL Server добавляет предложение FOR BROWSE к выполняемому оператору. Пользователь должен быть осведомлен о возможных побочных эффектах, например о проблемах, возникающих при использовании операторов SET FMTONLY ON. Дополнительные сведения см. в разделе SET FMTONLY (Transact-SQL).</summary>
		// Token: 0x04000990 RID: 2448
		AddWithKey
	}
}
