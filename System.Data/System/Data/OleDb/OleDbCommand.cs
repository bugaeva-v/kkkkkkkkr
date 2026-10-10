using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Представляет инструкцию SQL или хранимую процедуру, выполняемую с источником данных.</summary>
	// Token: 0x0200015D RID: 349
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbCommand : DbCommand, IDbCommand, IDisposable, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbCommand" />.</summary>
		// Token: 0x0600129E RID: 4766 RVA: 0x0005ABDF File Offset: 0x00058DDF
		public OleDbCommand()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbCommand" /> текстом запроса.</summary>
		/// <param name="cmdText">Текст запроса.</param>
		// Token: 0x0600129F RID: 4767 RVA: 0x0005ABE7 File Offset: 0x00058DE7
		public OleDbCommand(string cmdText)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbCommand" /> с использованием текста запроса и подключения <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
		/// <param name="cmdText">Текст запроса.</param>
		/// <param name="connection">
		///   <see cref="T:System.Data.OleDb.OleDbConnection" /> — представляет подключение к источнику данных.</param>
		// Token: 0x060012A0 RID: 4768 RVA: 0x0005ABE7 File Offset: 0x00058DE7
		public OleDbCommand(string cmdText, OleDbConnection connection)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbCommand" /> с использованием текста запроса, <see cref="T:System.Data.OleDb.OleDbConnection" /> и <see cref="P:System.Data.OleDb.OleDbCommand.Transaction" />.</summary>
		/// <param name="cmdText">Текст запроса.</param>
		/// <param name="connection">
		///   <see cref="T:System.Data.OleDb.OleDbConnection" /> — представляет подключение к источнику данных.</param>
		/// <param name="transaction">Транзакция, в которой выполняется <see cref="T:System.Data.OleDb.OleDbCommand" />.</param>
		// Token: 0x060012A1 RID: 4769 RVA: 0x0005ABE7 File Offset: 0x00058DE7
		public OleDbCommand(string cmdText, OleDbConnection connection, OleDbTransaction transaction)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает или задает оператор SQL или хранимую процедуру, выполняемую над источником данных.</summary>
		/// <returns>Инструкция или хранимая процедура SQL, подлежащая выполнению. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00007EED File Offset: 0x000060ED
		public override string CommandText
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает время ожидания перед прекращением попытки выполнить команду и выводом ошибки.</summary>
		/// <returns>Время (в секундах) ожидания выполнения команды. По умолчанию используется значение 30 секунд.</returns>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00007EED File Offset: 0x000060ED
		public override int CommandTimeout
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, как интерпретируется свойство <see cref="P:System.Data.OleDb.OleDbCommand.CommandText" />.</summary>
		/// <returns>Одно из значений <see cref="P:System.Data.OleDb.OleDbCommand.CommandType" />. Значение по умолчанию - Text.</returns>
		/// <exception cref="T:System.ArgumentException">Значение не является допустимым объектом <see cref="P:System.Data.OleDb.OleDbCommand.CommandType" />.</exception>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00007EED File Offset: 0x000060ED
		public override CommandType CommandType
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.OleDb.OleDbConnection" />, используемый этим экземпляром класса <see cref="T:System.Data.OleDb.OleDbCommand" />.</summary>
		/// <returns>Подключение к источнику данных. Значение по умолчанию — <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> изменилось в течение транзакции.</exception>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbConnection Connection
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x00007EED File Offset: 0x000060ED
		protected override DbConnection DbConnection
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbParameterCollection DbParameterCollection
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00007EED File Offset: 0x000060ED
		protected override DbTransaction DbTransaction
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, должен ли объект команды отображаться в настраиваемом элементе управления конструктора Windows Forms.</summary>
		/// <returns>Значение, которое указывает, должен ли объект команды быть видимым в элементе управления. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x00007EED File Offset: 0x000060ED
		public override bool DesignTimeVisible
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает набор <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <returns>Параметры инструкции SQL или хранимой процедуры. По умолчанию является пустой коллекцией.</returns>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbParameterCollection Parameters
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает или задает транзакцию <see cref="T:System.Data.OleDb.OleDbTransaction" />, в которой выполняется команда <see cref="T:System.Data.OleDb.OleDbCommand" />.</summary>
		/// <returns>
		///   <see cref="T:System.Data.OleDb.OleDbTransaction" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbTransaction Transaction
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает способы применения результатов команд к объекту <see cref="T:System.Data.DataRow" /> при использовании метода <see langword="Update" /> объекта <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.UpdateRowSource" />.</returns>
		/// <exception cref="T:System.ArgumentException">Введенное значение не являлось одним из значений <see cref="T:System.Data.UpdateRowSource" />.</exception>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x00007EED File Offset: 0x000060ED
		public override UpdateRowSource UpdatedRowSource
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Пытается отменить выполнение <see cref="T:System.Data.OleDb.OleDbCommand" />.</summary>
		// Token: 0x060012B6 RID: 4790 RVA: 0x00007EED File Offset: 0x000060ED
		public override void Cancel()
		{
		}

		/// <summary>Создает новый объект <see cref="T:System.Data.OleDb.OleDbCommand" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Новый объект <see cref="T:System.Data.OleDb.OleDbCommand" />, являющийся копией этого экземпляра.</returns>
		// Token: 0x060012B7 RID: 4791 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbCommand Clone()
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbParameter CreateDbParameter()
		{
			throw ADP.OleDb();
		}

		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		// Token: 0x060012B9 RID: 4793 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbParameter CreateParameter()
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void Dispose(bool disposing)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет оператор SQL применительно к свойству <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> и возвращает количество измененных командой строк.</summary>
		/// <returns>Число обработанных строк.</returns>
		/// <exception cref="T:System.InvalidOperationException">Подключение не существует.  
		/// -или- 
		/// Соединение не открыто.  
		/// -или- 
		/// Не удается выполнить команду в контексте транзакции, отличающемся от контекста, в котором подключение было изначально зарегистрировано.</exception>
		// Token: 0x060012BC RID: 4796 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int ExecuteNonQuery()
		{
			throw ADP.OleDb();
		}

		/// <summary>Отправляет свойство <see cref="P:System.Data.OleDb.OleDbCommand.CommandText" /> свойству <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> и создает объект <see cref="T:System.Data.OleDb.OleDbDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbDataReader" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Не удается выполнить команду в контексте транзакции, отличающемся от контекста, в котором подключение было изначально зарегистрировано.</exception>
		// Token: 0x060012BD RID: 4797 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbDataReader ExecuteReader()
		{
			throw ADP.OleDb();
		}

		/// <summary>Отправляет <see cref="P:System.Data.OleDb.OleDbCommand.CommandText" /> в <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> и создает <see cref="T:System.Data.OleDb.OleDbDataReader" />, используя одно из значений <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbDataReader" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Не удается выполнить команду в контексте транзакции, отличающемся от контекста, в котором подключение было изначально зарегистрировано.</exception>
		// Token: 0x060012BE RID: 4798 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbDataReader ExecuteReader(CommandBehavior behavior)
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет запрос и возвращает первый столбец первой строки результирующего набора, возвращаемого запросом. Дополнительные столбцы или строки не обрабатываются.</summary>
		/// <returns>Первый столбец первой строки набора результатов или пустая ссылка, если набор результатов пуст.</returns>
		/// <exception cref="T:System.InvalidOperationException">Не удается выполнить команду в контексте транзакции, отличающемся от контекста, в котором подключение было изначально зарегистрировано.</exception>
		// Token: 0x060012BF RID: 4799 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override object ExecuteScalar()
		{
			throw ADP.OleDb();
		}

		/// <summary>Создает подготовленную (или скомпилированную) версию команды в источнике данных.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> не указывается.  
		/// -или- 
		/// Подключение <see cref="P:System.Data.OleDb.OleDbCommand.Connection" /> не открыто.</exception>
		// Token: 0x060012C0 RID: 4800 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Prepare()
		{
			throw ADP.OleDb();
		}

		/// <summary>Сбрасывает значение свойства <see cref="P:System.Data.OleDb.OleDbCommand.CommandTimeout" /> и задает ему значение по умолчанию.</summary>
		// Token: 0x060012C1 RID: 4801 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void ResetCommandTimeout()
		{
			throw ADP.OleDb();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Data.IDbCommand.ExecuteReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.IDataReader" />.</returns>
		// Token: 0x060012C2 RID: 4802 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		IDataReader IDbCommand.ExecuteReader()
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет <see cref="P:System.Data.IDbCommand.CommandText" /> в <see cref="P:System.Data.IDbCommand.Connection" /> и строит <see cref="T:System.Data.IDataReader" /> с помощью одного из значений <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.IDataReader" />, построенный с использованием одного из значений <see cref="T:System.Data.CommandBehavior" />.</returns>
		// Token: 0x060012C3 RID: 4803 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		IDataReader IDbCommand.ExecuteReader(CommandBehavior behavior)
		{
			throw ADP.OleDb();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, который является копией данного экземпляра.</returns>
		// Token: 0x060012C4 RID: 4804 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		object ICloneable.Clone()
		{
			throw ADP.OleDb();
		}
	}
}
