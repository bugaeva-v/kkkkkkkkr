using System;

namespace System.Data
{
	/// <summary>Предоставляет средства чтения одного или нескольких прямонаправленных потоков наборов результатов, полученных вследствие выполнения команды в источнике данных. Реализацию осуществляют поставщики данных .NET Framework, которые имеют доступ к реляционным базам данных.</summary>
	// Token: 0x02000101 RID: 257
	public interface IDataReader : IDisposable, IDataRecord
	{
		/// <summary>Возвращает значение, показывающее глубину вложенности для текущей строки.</summary>
		/// <returns>Уровень вложенности.</returns>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000F25 RID: 3877
		int Depth { get; }

		/// <summary>Возвращает значение, которое указывает, является ли модуль чтения закрытым.</summary>
		/// <returns>
		///   <see langword="true" />, если модуль чтения данных закрытый. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000F26 RID: 3878
		bool IsClosed { get; }

		/// <summary>Возвращает число строк, которые были изменены, вставлены или удалены инструкцией SQL.</summary>
		/// <returns>Число измененных, вставленных или удаленных строк. Значение 0, если строки не были затронуты или инструкция завершилась ошибкой. Значение -1 для инструкций SELECT.</returns>
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000F27 RID: 3879
		int RecordsAffected { get; }

		/// <summary>Закрывает объект <see cref="T:System.Data.IDataReader" />.</summary>
		// Token: 0x06000F28 RID: 3880
		void Close();

		/// <summary>Возвращает объект <see cref="T:System.Data.DataTable" />, описывающий метаданные столбцов модуля чтения данных <see cref="T:System.Data.IDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, описывающий метаданные столбцов.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.IDataReader" /> закрыт.</exception>
		// Token: 0x06000F29 RID: 3881
		DataTable GetSchemaTable();

		/// <summary>Перемещает модуль чтения данных к следующему результату при чтении результатов из пакета инструкций SQL.</summary>
		/// <returns>Значение <see langword="true" />, если имеются другие строки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F2A RID: 3882
		bool NextResult();

		/// <summary>Перемещает <see cref="T:System.Data.IDataReader" /> к следующей записи.</summary>
		/// <returns>Значение <see langword="true" />, если имеются другие строки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F2B RID: 3883
		bool Read();
	}
}
