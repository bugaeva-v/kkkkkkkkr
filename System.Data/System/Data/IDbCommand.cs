using System;

namespace System.Data
{
	/// <summary>Представляет инструкцию SQL, выполняемую при подключении к источнику данных, которую реализуют поставщики данных платформы NET Framework, имеющие доступ к реляционным базам данных.</summary>
	// Token: 0x02000103 RID: 259
	public interface IDbCommand : IDisposable
	{
		/// <summary>Возвращает или задает объект <see cref="T:System.Data.IDbConnection" />, используемый этим экземпляром класса <see cref="T:System.Data.IDbCommand" />.</summary>
		/// <returns>Подключение к источнику данных.</returns>
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000F45 RID: 3909
		// (set) Token: 0x06000F46 RID: 3910
		IDbConnection Connection { get; set; }

		/// <summary>Возвращает или задает транзакцию, в рамках которой выполняется объект <see langword="Command" /> поставщика данных .NET Framework.</summary>
		/// <returns>выполняется объект <see langword="Command" /> поставщика данных .NET Framework. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000F47 RID: 3911
		// (set) Token: 0x06000F48 RID: 3912
		IDbTransaction Transaction { get; set; }

		/// <summary>Возвращает или задает текстовую команду для выполнения в отношении источника данных.</summary>
		/// <returns>Текстовая команда для выполнения. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000F49 RID: 3913
		// (set) Token: 0x06000F4A RID: 3914
		string CommandText { get; set; }

		/// <summary>Возвращает или задает время ожидания перед завершением попытки выполнить команду и созданием ошибки.</summary>
		/// <returns>Время (в секундах) ожидания выполнения команды. Значение по умолчанию - 30 секунды.</returns>
		/// <exception cref="T:System.ArgumentException">Присвоенное значение свойства меньше 0.</exception>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000F4B RID: 3915
		// (set) Token: 0x06000F4C RID: 3916
		int CommandTimeout { get; set; }

		/// <summary>Указывает или определяет, как интерпретируется свойство <see cref="P:System.Data.IDbCommand.CommandText" />.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.CommandType" />. Значение по умолчанию: <see langword="Text" />.</returns>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000F4D RID: 3917
		// (set) Token: 0x06000F4E RID: 3918
		CommandType CommandType { get; set; }

		/// <summary>Возвращает набор <see cref="T:System.Data.IDataParameterCollection" />.</summary>
		/// <returns>Параметры инструкции SQL или хранимой процедуры.</returns>
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000F4F RID: 3919
		IDataParameterCollection Parameters { get; }

		/// <summary>Создает подготовленную (или скомпилированную) версию команды в источнике данных.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> не указывается.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> не является методом <see cref="M:System.Data.OleDb.OleDbConnection.Open" />.</exception>
		// Token: 0x06000F50 RID: 3920
		void Prepare();

		/// <summary>Возвращает или задает способ применения результатов команды к объекту <see cref="T:System.Data.DataRow" /> при использовании метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" /> объекта <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.UpdateRowSource" />. Значение по умолчанию — <see langword="Both" />, если команда не создается автоматически. Значение по умолчанию — <see langword="None" />.</returns>
		/// <exception cref="T:System.ArgumentException">Введенное значение не являлось одним из значений <see cref="T:System.Data.UpdateRowSource" />.</exception>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000F51 RID: 3921
		// (set) Token: 0x06000F52 RID: 3922
		UpdateRowSource UpdatedRowSource { get; set; }

		/// <summary>Пытается отменить выполнение <see cref="T:System.Data.IDbCommand" />.</summary>
		// Token: 0x06000F53 RID: 3923
		void Cancel();

		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.IDbDataParameter" />.</summary>
		/// <returns>Объект <see langword="IDbDataParameter" />.</returns>
		// Token: 0x06000F54 RID: 3924
		IDbDataParameter CreateParameter();

		/// <summary>Выполняет инструкцию SQL для объекта <see langword="Connection" /> поставщика данных .NET Framework и возвращает число задействованных строк.</summary>
		/// <returns>Число обработанных строк.</returns>
		/// <exception cref="T:System.InvalidOperationException">Подключение не существует.  
		///
		/// или - 
		/// Соединение не открыто.</exception>
		// Token: 0x06000F55 RID: 3925
		int ExecuteNonQuery();

		/// <summary>Выполняет <see cref="P:System.Data.IDbCommand.CommandText" /> в <see cref="P:System.Data.IDbCommand.Connection" /> и создает <see cref="T:System.Data.IDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.IDataReader" />.</returns>
		// Token: 0x06000F56 RID: 3926
		IDataReader ExecuteReader();

		/// <summary>Выполняет <see cref="P:System.Data.IDbCommand.CommandText" /> в <see cref="P:System.Data.IDbCommand.Connection" /> и строит <see cref="T:System.Data.IDataReader" /> с помощью одного из значений <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="behavior">Одно из значений перечисления <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.IDataReader" />.</returns>
		// Token: 0x06000F57 RID: 3927
		IDataReader ExecuteReader(CommandBehavior behavior);

		/// <summary>Выполняет запрос и возвращает первый столбец первой строки результирующего набора, возвращаемого запросом. Дополнительные столбцы или строки не обрабатываются.</summary>
		/// <returns>Первый столбец или первая строка в результирующем наборе.</returns>
		// Token: 0x06000F58 RID: 3928
		object ExecuteScalar();
	}
}
