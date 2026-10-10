using System;
using System.Data.Common;
using System.Data.Sql;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Data.SqlClient
{
	/// <summary>Автоматически создает однотабличные команды, используемые для согласования изменений, внесенных в <see cref="T:System.Data.DataSet" />, со связанной базой данных SQL Server. Этот класс не наследуется.</summary>
	// Token: 0x020001C5 RID: 453
	public sealed class SqlCommandBuilder : DbCommandBuilder
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlCommandBuilder" />.</summary>
		// Token: 0x06001602 RID: 5634 RVA: 0x000654A9 File Offset: 0x000636A9
		public SqlCommandBuilder()
		{
			GC.SuppressFinalize(this);
			base.QuotePrefix = "[";
			base.QuoteSuffix = "]";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlCommandBuilder" /> вместе со связанным объектом <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</summary>
		/// <param name="adapter">Имя <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</param>
		// Token: 0x06001603 RID: 5635 RVA: 0x000654CD File Offset: 0x000636CD
		public SqlCommandBuilder(SqlDataAdapter adapter) : this()
		{
			this.DataAdapter = adapter;
		}

		/// <summary>Возвращает или задает <see cref="T:System.Data.Common.CatalogLocation" /> для экземпляра класса <see cref="T:System.Data.SqlClient.SqlCommandBuilder" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.CatalogLocation" />.</returns>
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x00006D61 File Offset: 0x00004F61
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x000654DC File Offset: 0x000636DC
		public override CatalogLocation CatalogLocation
		{
			get
			{
				return CatalogLocation.Start;
			}
			set
			{
				if (CatalogLocation.Start != value)
				{
					throw ADP.SingleValuedProperty("CatalogLocation", "Start");
				}
			}
		}

		/// <summary>Возвращает или задает строку, которую можно использовать в качестве разделителя каталогов, для экземпляра класса <see cref="T:System.Data.SqlClient.SqlCommandBuilder" />.</summary>
		/// <returns>Строка, указывающая разделитель каталогов, который используется в экземпляре класса <see cref="T:System.Data.SqlClient.SqlCommandBuilder" />.</returns>
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x000654F2 File Offset: 0x000636F2
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x000654F9 File Offset: 0x000636F9
		public override string CatalogSeparator
		{
			get
			{
				return ".";
			}
			set
			{
				if ("." != value)
				{
					throw ADP.SingleValuedProperty("CatalogSeparator", ".");
				}
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.SqlClient.SqlDataAdapter" />, для которого автоматически создаются инструкции Transact-SQL.</summary>
		/// <returns>Объект <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</returns>
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00065518 File Offset: 0x00063718
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00065525 File Offset: 0x00063725
		public new SqlDataAdapter DataAdapter
		{
			get
			{
				return (SqlDataAdapter)base.DataAdapter;
			}
			set
			{
				base.DataAdapter = value;
			}
		}

		/// <summary>Получает или задает начальный символ или символы, используемые для указания объектов базы данных SQL Server (например, таблиц или столбцов), имена которых содержат такие символы, как пробелы или зарезервированные токены.</summary>
		/// <returns>Используемый начальный символ или символы. Значение по умолчанию - пустая строка.</returns>
		/// <exception cref="T:System.InvalidOperationException">Это свойство не может быть изменено после создания команды INSERT, UPDATE или DELETE.</exception>
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x0006552E File Offset: 0x0006372E
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00065536 File Offset: 0x00063736
		public override string QuotePrefix
		{
			get
			{
				return base.QuotePrefix;
			}
			set
			{
				if ("[" != value && "\"" != value)
				{
					throw ADP.DoubleValuedProperty("QuotePrefix", "[", "\"");
				}
				base.QuotePrefix = value;
			}
		}

		/// <summary>Получает или задает конечный символ или символы, используемые для указания объектов базы данных SQL Server (например, таблиц или столбцов), имена которых содержат такие символы, как пробелы или зарезервированные токены.</summary>
		/// <returns>Используемый конечный символ или символы. Значение по умолчанию - пустая строка.</returns>
		/// <exception cref="T:System.InvalidOperationException">Это свойство не может быть изменено после создания команды INSERT, UPDATE или DELETE.</exception>
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0006556E File Offset: 0x0006376E
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00065576 File Offset: 0x00063776
		public override string QuoteSuffix
		{
			get
			{
				return base.QuoteSuffix;
			}
			set
			{
				if ("]" != value && "\"" != value)
				{
					throw ADP.DoubleValuedProperty("QuoteSuffix", "]", "\"");
				}
				base.QuoteSuffix = value;
			}
		}

		/// <summary>Возвращает или задает символ, который используется в качестве разделителя между идентификатором схемы и остальными идентификаторами.</summary>
		/// <returns>Символ, который необходимо использовать в схеме в качестве разделителя.</returns>
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000654F2 File Offset: 0x000636F2
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x000655AE File Offset: 0x000637AE
		public override string SchemaSeparator
		{
			get
			{
				return ".";
			}
			set
			{
				if ("." != value)
				{
					throw ADP.SingleValuedProperty("SchemaSeparator", ".");
				}
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000655CD File Offset: 0x000637CD
		private void SqlRowUpdatingHandler(object sender, SqlRowUpdatingEventArgs ruevent)
		{
			base.RowUpdatingHandler(ruevent);
		}

		/// <summary>Получает автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется для выполнения операций вставки в базу данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, необходимый для выполнения операций вставки.</returns>
		// Token: 0x06001611 RID: 5649 RVA: 0x000655D6 File Offset: 0x000637D6
		public new SqlCommand GetInsertCommand()
		{
			return (SqlCommand)base.GetInsertCommand();
		}

		/// <summary>Получает автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется для выполнения операций вставки в базе данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значением является <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, необходимый для выполнения операции вставки.</returns>
		// Token: 0x06001612 RID: 5650 RVA: 0x000655E3 File Offset: 0x000637E3
		public new SqlCommand GetInsertCommand(bool useColumnsForParameterNames)
		{
			return (SqlCommand)base.GetInsertCommand(useColumnsForParameterNames);
		}

		/// <summary>Получает автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется для выполнения обновлений базы данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, необходимый для выполнения операции обновления.</returns>
		// Token: 0x06001613 RID: 5651 RVA: 0x000655F1 File Offset: 0x000637F1
		public new SqlCommand GetUpdateCommand()
		{
			return (SqlCommand)base.GetUpdateCommand();
		}

		/// <summary>Получает автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется для выполнения обновлений базы данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значением является <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, необходимый для выполнения операций обновления.</returns>
		// Token: 0x06001614 RID: 5652 RVA: 0x000655FE File Offset: 0x000637FE
		public new SqlCommand GetUpdateCommand(bool useColumnsForParameterNames)
		{
			return (SqlCommand)base.GetUpdateCommand(useColumnsForParameterNames);
		}

		/// <summary>Получает автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется для выполнения операций удаления в базе данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, необходимый для выполнения операций удаления.</returns>
		// Token: 0x06001615 RID: 5653 RVA: 0x0006560C File Offset: 0x0006380C
		public new SqlCommand GetDeleteCommand()
		{
			return (SqlCommand)base.GetDeleteCommand();
		}

		/// <summary>Получает автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется для выполнения операций удаления в базе данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значением является <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.SqlClient.SqlCommand" /> позволяет выполнять операции удаления.</returns>
		// Token: 0x06001616 RID: 5654 RVA: 0x00065619 File Offset: 0x00063819
		public new SqlCommand GetDeleteCommand(bool useColumnsForParameterNames)
		{
			return (SqlCommand)base.GetDeleteCommand(useColumnsForParameterNames);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00065628 File Offset: 0x00063828
		protected override void ApplyParameterInfo(DbParameter parameter, DataRow datarow, StatementType statementType, bool whereClause)
		{
			SqlParameter sqlParameter = (SqlParameter)parameter;
			object obj = datarow[SchemaTableColumn.ProviderType];
			sqlParameter.SqlDbType = (SqlDbType)obj;
			sqlParameter.Offset = 0;
			if (sqlParameter.SqlDbType == SqlDbType.Udt && !sqlParameter.SourceColumnNullMapping)
			{
				sqlParameter.UdtTypeName = (datarow["DataTypeName"] as string);
			}
			else
			{
				sqlParameter.UdtTypeName = string.Empty;
			}
			object obj2 = datarow[SchemaTableColumn.NumericPrecision];
			if (DBNull.Value != obj2)
			{
				byte b = (byte)((short)obj2);
				sqlParameter.PrecisionInternal = ((byte.MaxValue != b) ? b : 0);
			}
			obj2 = datarow[SchemaTableColumn.NumericScale];
			if (DBNull.Value != obj2)
			{
				byte b2 = (byte)((short)obj2);
				sqlParameter.ScaleInternal = ((byte.MaxValue != b2) ? b2 : 0);
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000656EF File Offset: 0x000638EF
		protected override string GetParameterName(int parameterOrdinal)
		{
			return "@p" + parameterOrdinal.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00065707 File Offset: 0x00063907
		protected override string GetParameterName(string parameterName)
		{
			return "@" + parameterName;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000656EF File Offset: 0x000638EF
		protected override string GetParameterPlaceholder(int parameterOrdinal)
		{
			return "@p" + parameterOrdinal.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00065714 File Offset: 0x00063914
		private void ConsistentQuoteDelimiters(string quotePrefix, string quoteSuffix)
		{
			if (("\"" == quotePrefix && "\"" != quoteSuffix) || ("[" == quotePrefix && "]" != quoteSuffix))
			{
				throw ADP.InvalidPrefixSuffix();
			}
		}

		/// <summary>Извлекает сведения о параметрах из хранимой процедуры, указанной в объекте <see cref="T:System.Data.SqlClient.SqlCommand" />, и включает их в коллекцию параметров <see cref="P:System.Data.SqlClient.SqlCommand.Parameters" /> указанного объекта <see cref="T:System.Data.SqlClient.SqlCommand" />.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.SqlClient.SqlCommand" /> ссылается на хранимую процедуру, из которой необходимо извлечь сведения о параметрах. Извлеченные параметры добавляются в коллекцию параметров <see cref="P:System.Data.SqlClient.SqlCommand.Parameters" /> объекта <see cref="T:System.Data.SqlClient.SqlCommand" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Текст команды не является допустимым именем хранимой процедуры.</exception>
		// Token: 0x0600161C RID: 5660 RVA: 0x00065750 File Offset: 0x00063950
		public static void DeriveParameters(SqlCommand command)
		{
			if (command == null)
			{
				throw ADP.ArgumentNull("command");
			}
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				command.DeriveParameters();
			}
			catch (OutOfMemoryException e)
			{
				if (command != null)
				{
					SqlConnection connection = command.Connection;
					if (connection != null)
					{
						connection.Abort(e);
					}
				}
				throw;
			}
			catch (StackOverflowException e2)
			{
				if (command != null)
				{
					SqlConnection connection2 = command.Connection;
					if (connection2 != null)
					{
						connection2.Abort(e2);
					}
				}
				throw;
			}
			catch (ThreadAbortException e3)
			{
				if (command != null)
				{
					SqlConnection connection3 = command.Connection;
					if (connection3 != null)
					{
						connection3.Abort(e3);
					}
				}
				throw;
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000657E8 File Offset: 0x000639E8
		protected override DataTable GetSchemaTable(DbCommand srcCommand)
		{
			SqlCommand sqlCommand = srcCommand as SqlCommand;
			SqlNotificationRequest notification = sqlCommand.Notification;
			sqlCommand.Notification = null;
			DataTable schemaTable;
			try
			{
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
				{
					schemaTable = sqlDataReader.GetSchemaTable();
				}
			}
			finally
			{
				sqlCommand.Notification = notification;
			}
			return schemaTable;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0006584C File Offset: 0x00063A4C
		protected override DbCommand InitializeCommand(DbCommand command)
		{
			return (SqlCommand)base.InitializeCommand(command);
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом корректно исключаются встроенные в идентификатор кавычки.</summary>
		/// <param name="unquotedIdentifier">Исходный идентификатор без кавычек.</param>
		/// <returns>Версия идентификатора, заключенного кавычки. Кавычки, внедренные в идентификатор, корректно исключаются.</returns>
		// Token: 0x0600161F RID: 5663 RVA: 0x0006585C File Offset: 0x00063A5C
		public override string QuoteIdentifier(string unquotedIdentifier)
		{
			ADP.CheckArgumentNull(unquotedIdentifier, "unquotedIdentifier");
			string quoteSuffix = this.QuoteSuffix;
			string quotePrefix = this.QuotePrefix;
			this.ConsistentQuoteDelimiters(quotePrefix, quoteSuffix);
			return ADP.BuildQuotedString(quotePrefix, quoteSuffix, unquotedIdentifier);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00065892 File Offset: 0x00063A92
		protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
		{
			if (adapter == base.DataAdapter)
			{
				((SqlDataAdapter)adapter).RowUpdating -= this.SqlRowUpdatingHandler;
				return;
			}
			((SqlDataAdapter)adapter).RowUpdating += this.SqlRowUpdatingHandler;
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом все кавычки, внедренные в идентификатор, корректно сохраняются.</summary>
		/// <param name="quotedIdentifier">Идентификатор, из которого будут удалены внедренные кавычки.</param>
		/// <returns>Идентификатор без кавычек, в котором встроенные кавычки корректно сохранены.</returns>
		// Token: 0x06001621 RID: 5665 RVA: 0x000658CC File Offset: 0x00063ACC
		public override string UnquoteIdentifier(string quotedIdentifier)
		{
			ADP.CheckArgumentNull(quotedIdentifier, "quotedIdentifier");
			string quoteSuffix = this.QuoteSuffix;
			string quotePrefix = this.QuotePrefix;
			this.ConsistentQuoteDelimiters(quotePrefix, quoteSuffix);
			string result;
			ADP.RemoveStringQuotes(quotePrefix, quoteSuffix, quotedIdentifier, out result);
			return result;
		}
	}
}
