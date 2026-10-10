using System;

namespace System.Data
{
	/// <summary>Позволяет объекту реализовать DataAdapter и представляет набор методов и соответствующие свойства, связанные с операциями, для заполнения и обновления объекта <see cref="T:System.Data.DataSet" /> и обновления источника данных.  
	///  Экземпляры <see cref="T:System.Data.IDbDataAdapter" /> — для источников данных, которые являются или напоминают реляционные базы данных с текстуальными командами (например, Transact-SQL), а экземпляры <see cref="T:System.Data.IDataAdapter" /> могут использовать любой тип источника данных.</summary>
	// Token: 0x020000FE RID: 254
	public interface IDataAdapter
	{
		/// <summary>Указывает, будут ли несопоставленные столбцы-источники или таблицы-источники передаваться со своими исходными именами, чтобы пройти через фильтр или вызвать ошибку.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.MissingMappingAction" />. Значение по умолчанию — <see langword="Passthrough" />.</returns>
		/// <exception cref="T:System.ArgumentException">Заданное значение не является одним из значений <see cref="T:System.Data.MissingMappingAction" />.</exception>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000F0A RID: 3850
		// (set) Token: 0x06000F0B RID: 3851
		MissingMappingAction MissingMappingAction { get; set; }

		/// <summary>Указывает или задает значение, определяющее, будут ли отсутствующие исходные таблицы, столбцы и их отношения добавляться в схему набора данных, игнорироваться или вызывать ошибку.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.MissingSchemaAction" />. Значение по умолчанию — <see langword="Add" />.</returns>
		/// <exception cref="T:System.ArgumentException">Заданное значение не является одним из значений <see cref="T:System.Data.MissingSchemaAction" />.</exception>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000F0C RID: 3852
		// (set) Token: 0x06000F0D RID: 3853
		MissingSchemaAction MissingSchemaAction { get; set; }

		/// <summary>Указывает, как исходная таблица сопоставлена с таблицей набора данных.</summary>
		/// <returns>Коллекция, обеспечивающая основное сопоставление между возвращенными записями и объектом <see cref="T:System.Data.DataSet" />. Значение по умолчанию — пустая коллекция.</returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000F0E RID: 3854
		ITableMappingCollection TableMappings { get; }

		/// <summary>Добавляет объект <see cref="T:System.Data.DataTable" /> с именем Table в указанный объект <see cref="T:System.Data.DataSet" /> и настраивает схему для соответствия этому объекту в источнике данных на основе указанного значения типа <see cref="T:System.Data.SchemaType" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения схемой из источника данных.</param>
		/// <param name="schemaType">Одно из значений перечисления <see cref="T:System.Data.SchemaType" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Data.DataTable" />, который содержит сведения схемы, возвращенные из источника данных.</returns>
		// Token: 0x06000F0F RID: 3855
		DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType);

		/// <summary>Добавляет или обновляет строки в объект <see cref="T:System.Data.DataSet" /> для получения соответствия со строками в источнике данных, используя имя объекта <see cref="T:System.Data.DataSet" /> и создает объект <see cref="T:System.Data.DataTable" /> с именем "Table".</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		// Token: 0x06000F10 RID: 3856
		int Fill(DataSet dataSet);

		/// <summary>Получает параметры, заданные пользователем при выполнении оператора SQL SELECT.</summary>
		/// <returns>Массив объектов <see cref="T:System.Data.IDataParameter" /> содержит параметры, заданные пользователем.</returns>
		// Token: 0x06000F11 RID: 3857
		IDataParameter[] GetFillParameters();

		/// <summary>Вызывает соответствующие операторы INSERT, UPDATE или DELETE для каждой вставленной, обновленной или удаленной строки в указанном объекте <see cref="T:System.Data.DataSet" /> из объекта <see cref="T:System.Data.DataTable" /> с именем "Table".</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" />, использованный для обновления источника данных.</param>
		/// <returns>Количество строк, успешно обновленных из объекта <see cref="T:System.Data.DataSet" />.</returns>
		/// <exception cref="T:System.Data.DBConcurrencyException">Попытка выполнить оператор INSERT, UPDATE или DELETE привела к нулевому количеству обработанных записей.</exception>
		// Token: 0x06000F12 RID: 3858
		int Update(DataSet dataSet);
	}
}
