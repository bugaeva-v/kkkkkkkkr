using System;
using System.Data.Common;
using System.EnterpriseServices;
using System.Transactions;

namespace System.Data.OleDb
{
	/// <summary>Представляет открытое подключение к источнику данных.</summary>
	// Token: 0x0200015F RID: 351
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbConnection : DbConnection, IDbConnection, IDisposable, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
		// Token: 0x060012D9 RID: 4825 RVA: 0x0005AC08 File Offset: 0x00058E08
		public OleDbConnection()
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbConnection" /> с заданной строкой подключения.</summary>
		/// <param name="connectionString">Соединение, используемое для открытия базы данных.</param>
		// Token: 0x060012DA RID: 4826 RVA: 0x0005AC08 File Offset: 0x00058E08
		public OleDbConnection(string connectionString)
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает или задает строку, используемую для открытия базы данных.</summary>
		/// <returns>Строка подключения поставщика OLE DB, содержащая имя источника данных и другие параметры, необходимые для установки начального подключения. Значение по умолчанию - пустая строка.</returns>
		/// <exception cref="T:System.ArgumentException">Передан недопустимый аргумент строки соединения, или не задан обязательный аргумент строки соединения.</exception>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00007EED File Offset: 0x000060ED
		public override string ConnectionString
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Получает время ожидания при попытке установки подключения, по истечении которого попытка подключения завершается и создается ошибка.</summary>
		/// <returns>Выраженное в секундах время ожидания открытия подключения. Значение по умолчанию - 15 секунды.</returns>
		/// <exception cref="T:System.ArgumentException">Заданное значение меньше 0.</exception>
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int ConnectionTimeout
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает имя текущей базы данных или базы данных, которая будет использоваться после открытия подключения.</summary>
		/// <returns>Имя текущей базы данных или базы данных, которая будет использоваться после открытия подключения. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string Database
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает имя сервера или имя файла источника данных.</summary>
		/// <returns>Имя сервера или имя файла источника данных. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string DataSource
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает имя поставщика OLE DB, указанное в выражении "Provider= " строки подключения.</summary>
		/// <returns>Имя поставщика, указанное в выражении "Provider= " строки подключения. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string Provider
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает строку, содержащую номер версии сервера, к которому подключается клиент.</summary>
		/// <returns>Версия подключенного сервера.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение закрыто.</exception>
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string ServerVersion
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает текущее состояние подключения.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Data.ConnectionState" />. По умолчанию — "Closed" (Закрыто).</returns>
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override ConnectionState State
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
		{
			throw ADP.OleDb();
		}

		/// <summary>Запускает транзакцию базы данных с текущим значением <see cref="T:System.Data.IsolationLevel" />.</summary>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		/// <exception cref="T:System.InvalidOperationException">Параллельные транзакции не поддерживаются.</exception>
		// Token: 0x060012E4 RID: 4836 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbTransaction BeginTransaction()
		{
			throw ADP.OleDb();
		}

		/// <summary>Начинает транзакцию базы данных с указанным уровнем изоляции.</summary>
		/// <param name="isolationLevel">Уровень изоляции, с которым должна выполняться транзакция.</param>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		/// <exception cref="T:System.InvalidOperationException">Параллельные транзакции не поддерживаются.</exception>
		// Token: 0x060012E5 RID: 4837 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			throw ADP.OleDb();
		}

		/// <summary>Осуществляет смену текущей базы данных для открытого соединения <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
		/// <param name="value">Имя базы данных.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимое имя базы данных.</exception>
		/// <exception cref="T:System.InvalidOperationException">Соединение не открыто.</exception>
		/// <exception cref="T:System.Data.OleDb.OleDbException">Невозможно изменить базу данных.</exception>
		// Token: 0x060012E6 RID: 4838 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void ChangeDatabase(string value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Закрывает подключение к источнику данных.</summary>
		// Token: 0x060012E7 RID: 4839 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Close()
		{
			throw ADP.OleDb();
		}

		/// <summary>Создает и возвращает объект <see cref="T:System.Data.OleDb.OleDbCommand" />, связанный с объектом <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbCommand" />.</returns>
		// Token: 0x060012E8 RID: 4840 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand CreateCommand()
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbCommand CreateDbCommand()
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void Dispose(bool disposing)
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет присоединение указанной транзакции как распределенной транзакции.</summary>
		/// <param name="transaction">Ссылка на существующий объект <see cref="T:System.EnterpriseServices.ITransaction" />, к которому выполняется присоединение.</param>
		// Token: 0x060012EB RID: 4843 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void EnlistDistributedTransaction(ITransaction transaction)
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет присоединение указанной транзакции как распределенной транзакции.</summary>
		/// <param name="transaction">Ссылка на существующий объект <see cref="T:System.Transactions.Transaction" />, к которому выполняется присоединение.</param>
		// Token: 0x060012EC RID: 4844 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void EnlistTransaction(Transaction transaction)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает сведения схемы из источника данных, как указано в GUID, и после применения указанных ограничений.</summary>
		/// <param name="schema">Одно из значений <see cref="T:System.Data.OleDb.OleDbSchemaGuid" />, указывающее возвращаемую таблицу схемы.</param>
		/// <param name="restrictions">Массив <see cref="T:System.Object" /> значений ограничений. Они применяются в порядке следования столбцов ограничений. Это означает, что первое значение ограничения применяется к первому столбцу ограничений, второе — ко второму столбцу ограничений и т. д.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий запрошенные сведения о схеме.</returns>
		/// <exception cref="T:System.Data.OleDb.OleDbException">Указанный набор ограничений недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.OleDb.OleDbConnection" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentException">Указанный набор строк схемы не поддерживается поставщиком OLE DB.  
		/// -или- 
		/// Параметр <paramref name="schema" /> содержит значение <see cref="F:System.Data.OleDb.OleDbSchemaGuid.DbInfoLiterals" />, а параметр <paramref name="restrictions" /> содержит одно или несколько ограничений.</exception>
		// Token: 0x060012ED RID: 4845 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public DataTable GetOleDbSchemaTable(Guid schema, object[] restrictions)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает сведения о схеме для источника данных этого объекта <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме.</returns>
		// Token: 0x060012EE RID: 4846 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DataTable GetSchema()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает сведения о схеме для источника данных этого объекта <see cref="T:System.Data.OleDb.OleDbConnection" />, используя указанную строку в качестве имени схемы.</summary>
		/// <param name="collectionName">Определяет имя схемы, которая должна быть возвращена.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме.</returns>
		// Token: 0x060012EF RID: 4847 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DataTable GetSchema(string collectionName)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает сведения о схеме для источника данных этого объекта <see cref="T:System.Data.OleDb.OleDbConnection" />, используя указанную строку в качестве имени схемы и указанный массив строк для значений ограничений.</summary>
		/// <param name="collectionName">Определяет имя схемы, которая должна быть возвращена.</param>
		/// <param name="restrictionValues">Задает набор значений ограничений для запрошенной схемы.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме.</returns>
		// Token: 0x060012F0 RID: 4848 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DataTable GetSchema(string collectionName, string[] restrictionValues)
		{
			throw ADP.OleDb();
		}

		/// <summary>Открывает подключение к базе данных со значениями свойств, определяемыми объектом <see cref="P:System.Data.OleDb.OleDbConnection.ConnectionString" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Подключение уже открыто.</exception>
		/// <exception cref="T:System.Data.OleDb.OleDbException">При открытии подключения произошла ошибка на уровне подключения.</exception>
		// Token: 0x060012F1 RID: 4849 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Open()
		{
			throw ADP.OleDb();
		}

		/// <summary>Означает, что пул объектов <see cref="T:System.Data.OleDb.OleDbConnection" /> может быть освобожден, когда последнее основное подключение будет освобождено.</summary>
		// Token: 0x060012F2 RID: 4850 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public static void ReleaseObjectPool()
		{
			throw ADP.OleDb();
		}

		/// <summary>Обновляет свойство <see cref="P:System.Data.OleDb.OleDbConnection.State" /> объекта <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
		// Token: 0x060012F3 RID: 4851 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void ResetState()
		{
			throw ADP.OleDb();
		}

		/// <summary>Происходит, когда поставщик отправляет предупреждение или информационное сообщение.</summary>
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060012F4 RID: 4852 RVA: 0x0005AC18 File Offset: 0x00058E18
		// (remove) Token: 0x060012F5 RID: 4853 RVA: 0x0005AC50 File Offset: 0x00058E50
		public event OleDbInfoMessageEventHandler InfoMessage;

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, который является копией данного экземпляра.</returns>
		// Token: 0x060012F6 RID: 4854 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		object ICloneable.Clone()
		{
			throw ADP.OleDb();
		}
	}
}
