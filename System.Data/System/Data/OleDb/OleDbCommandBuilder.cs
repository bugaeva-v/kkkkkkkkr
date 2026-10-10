using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Автоматически генерирует однотабличные команды, которые позволяют согласовать изменения, вносимые в объект <see cref="T:System.Data.DataSet" />, со связанной базой данных. Этот класс не наследуется.</summary>
	// Token: 0x0200015E RID: 350
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbCommandBuilder : DbCommandBuilder
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbCommandBuilder" />.</summary>
		// Token: 0x060012C5 RID: 4805 RVA: 0x0005ABFB File Offset: 0x00058DFB
		public OleDbCommandBuilder()
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbCommandBuilder" /> вместе со связанным объектом <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</summary>
		/// <param name="adapter">Объект <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</param>
		// Token: 0x060012C6 RID: 4806 RVA: 0x0005ABFB File Offset: 0x00058DFB
		public OleDbCommandBuilder(OleDbDataAdapter adapter)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.OleDb.OleDbDataAdapter" />, для которого автоматически создаются операторы SQL.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</returns>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbDataAdapter DataAdapter
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void ApplyParameterInfo(DbParameter parameter, DataRow datarow, StatementType statementType, bool whereClause)
		{
			throw ADP.OleDb();
		}

		/// <summary>Извлекает сведения о параметрах из хранимой процедуры, указанной в объекте <see cref="T:System.Data.OleDb.OleDbCommand" />, и включает их в коллекцию параметров <see cref="P:System.Data.OleDb.OleDbCommand.Parameters" /> указанного объекта <see cref="T:System.Data.OleDb.OleDbCommand" />.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.OleDb.OleDbCommand" /> ссылается на хранимую процедуру, из которой необходимо извлечь сведения о параметрах. Извлеченные параметры добавляются в коллекцию параметров <see cref="P:System.Data.OleDb.OleDbCommand.Parameters" /> объекта <see cref="T:System.Data.OleDb.OleDbCommand" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Соответствующий поставщик OLE DB не поддерживает возврат сведений о параметрах хранимых процедур, текст команды не является допустимым именем хранимой процедуры, либо указанное значение <see cref="P:System.Data.OleDb.OleDbCommand.CommandType" /> не является <see langword="StoredProcedure" />.</exception>
		// Token: 0x060012CA RID: 4810 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public static void DeriveParameters(OleDbCommand command)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, который требуется для выполнения операций удаления в источнике данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, необходимый для выполнения операций удаления.</returns>
		// Token: 0x060012CB RID: 4811 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand GetDeleteCommand()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, который требуется для выполнения операций удаления в источнике данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значение равно <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, необходимый для выполнения операций удаления.</returns>
		// Token: 0x060012CC RID: 4812 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand GetDeleteCommand(bool useColumnsForParameterNames)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, который требуется для выполнения операций вставки в источнике данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, необходимый для выполнения операций вставки.</returns>
		// Token: 0x060012CD RID: 4813 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand GetInsertCommand()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, который требуется для выполнения операций вставки в источнике данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значение равно <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, необходимый для выполнения операций вставки.</returns>
		// Token: 0x060012CE RID: 4814 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand GetInsertCommand(bool useColumnsForParameterNames)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override string GetParameterName(int parameterOrdinal)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override string GetParameterName(string parameterName)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override string GetParameterPlaceholder(int parameterOrdinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, который требуется для выполнения операций обновления в источнике данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, необходимый для выполнения операций обновления.</returns>
		// Token: 0x060012D2 RID: 4818 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand GetUpdateCommand()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, который требуется для выполнения операций обновления в источнике данных (дополнительно могут использоваться столбцы для определения имен параметров).</summary>
		/// <param name="useColumnsForParameterNames">Если значение равно <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.OleDb.OleDbCommand" />, необходимый для выполнения операций обновления.</returns>
		// Token: 0x060012D3 RID: 4819 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand GetUpdateCommand(bool useColumnsForParameterNames)
		{
			throw ADP.OleDb();
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом корректно исключаются встроенные в идентификатор кавычки.</summary>
		/// <param name="unquotedIdentifier">Исходный идентификатор без кавычек.</param>
		/// <returns>Версия идентификатора, заключенного кавычки. Кавычки, внедренные в идентификатор, корректно исключаются.</returns>
		// Token: 0x060012D4 RID: 4820 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string QuoteIdentifier(string unquotedIdentifier)
		{
			throw ADP.OleDb();
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом корректно исключаются встроенные в идентификатор кавычки.</summary>
		/// <param name="unquotedIdentifier">Не заключенный в кавычки идентификатор должен возвращаться в формате с кавычками.</param>
		/// <param name="connection">Если подключение выполнено, заставляет управляемую оболочку получить символ кавычки от поставщика OLE DB. Если подключение не выполнено, строка заключается в кавычки, используя значения из свойств <see cref="P:System.Data.Common.DbCommandBuilder.QuotePrefix" /> и <see cref="P:System.Data.Common.DbCommandBuilder.QuoteSuffix" />.</param>
		/// <returns>Версия идентификатора, заключенного кавычки. Кавычки, внедренные в идентификатор, корректно исключаются.</returns>
		// Token: 0x060012D5 RID: 4821 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string QuoteIdentifier(string unquotedIdentifier, OleDbConnection connection)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
		{
			throw ADP.OleDb();
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом все кавычки, внедренные в идентификатор, корректно сохраняются.</summary>
		/// <param name="quotedIdentifier">Идентификатор, из которого будут удалены внедренные кавычки.</param>
		/// <returns>Идентификатор без кавычек, в котором корректно сохранены все внедренные кавычки.</returns>
		// Token: 0x060012D7 RID: 4823 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string UnquoteIdentifier(string quotedIdentifier)
		{
			throw ADP.OleDb();
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом все кавычки, внедренные в идентификатор, корректно сохраняются.</summary>
		/// <param name="quotedIdentifier">Идентификатор, из которого будут удалены внедренные кавычки.</param>
		/// <param name="connection">
		///   <see cref="T:System.Data.OleDb.OleDbConnection" />.</param>
		/// <returns>Идентификатор без кавычек, в котором корректно сохранены все внедренные кавычки.</returns>
		// Token: 0x060012D8 RID: 4824 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string UnquoteIdentifier(string quotedIdentifier, OleDbConnection connection)
		{
			throw ADP.OleDb();
		}
	}
}
