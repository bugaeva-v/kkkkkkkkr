using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;

namespace System.Data.Odbc
{
	/// <summary>Автоматически генерирует однотабличные команды, которые позволяют согласовать изменения, вносимые в объект <see cref="T:System.Data.DataSet" />, со связанным источником данных. Этот класс не наследуется.</summary>
	// Token: 0x020002D7 RID: 727
	public sealed class OdbcCommandBuilder : DbCommandBuilder
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcCommandBuilder" />.</summary>
		// Token: 0x06001FB3 RID: 8115 RVA: 0x00095220 File Offset: 0x00093420
		public OdbcCommandBuilder()
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcCommandBuilder" /> вместе со связанным объектом <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</summary>
		/// <param name="adapter">Объект <see cref="T:System.Data.Odbc.OdbcDataAdapter" />, который необходимо связать с объектом <see cref="T:System.Data.Odbc.OdbcCommandBuilder" />.</param>
		// Token: 0x06001FB4 RID: 8116 RVA: 0x0009522E File Offset: 0x0009342E
		public OdbcCommandBuilder(OdbcDataAdapter adapter) : this()
		{
			this.DataAdapter = adapter;
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Odbc.OdbcDataAdapter" />, для которого данный объект <see cref="T:System.Data.Odbc.OdbcCommandBuilder" /> будет генерировать операторы SQL.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcDataAdapter" />, связанный с этим объектом <see cref="T:System.Data.Odbc.OdbcCommandBuilder" />.</returns>
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0009523D File Offset: 0x0009343D
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00065525 File Offset: 0x00063725
		public new OdbcDataAdapter DataAdapter
		{
			get
			{
				return base.DataAdapter as OdbcDataAdapter;
			}
			set
			{
				base.DataAdapter = value;
			}
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000655CD File Offset: 0x000637CD
		private void OdbcRowUpdatingHandler(object sender, OdbcRowUpdatingEventArgs ruevent)
		{
			base.RowUpdatingHandler(ruevent);
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который требуется для выполнения операций вставки в источнике данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, необходимый для выполнения операций вставки.</returns>
		// Token: 0x06001FB8 RID: 8120 RVA: 0x0009524A File Offset: 0x0009344A
		public new OdbcCommand GetInsertCommand()
		{
			return (OdbcCommand)base.GetInsertCommand();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который требуется для выполнения операций вставки в источнике данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значение равно <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, необходимый для выполнения операций вставки.</returns>
		// Token: 0x06001FB9 RID: 8121 RVA: 0x00095257 File Offset: 0x00093457
		public new OdbcCommand GetInsertCommand(bool useColumnsForParameterNames)
		{
			return (OdbcCommand)base.GetInsertCommand(useColumnsForParameterNames);
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который требуется для выполнения операций обновления в источнике данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, необходимый для выполнения операций обновления.</returns>
		// Token: 0x06001FBA RID: 8122 RVA: 0x00095265 File Offset: 0x00093465
		public new OdbcCommand GetUpdateCommand()
		{
			return (OdbcCommand)base.GetUpdateCommand();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который требуется для выполнения операций обновления в источнике данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значение равно <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, необходимый для выполнения операций обновления.</returns>
		// Token: 0x06001FBB RID: 8123 RVA: 0x00095272 File Offset: 0x00093472
		public new OdbcCommand GetUpdateCommand(bool useColumnsForParameterNames)
		{
			return (OdbcCommand)base.GetUpdateCommand(useColumnsForParameterNames);
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который требуется для выполнения операций удаления в источнике данных.</summary>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, необходимый для выполнения операций удаления.</returns>
		// Token: 0x06001FBC RID: 8124 RVA: 0x00095280 File Offset: 0x00093480
		public new OdbcCommand GetDeleteCommand()
		{
			return (OdbcCommand)base.GetDeleteCommand();
		}

		/// <summary>Возвращает автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который требуется для выполнения операций удаления в источнике данных.</summary>
		/// <param name="useColumnsForParameterNames">Если значение равно <see langword="true" />, создаются имена параметров, совпадающие с именами столбцов, если это возможно. Если значение равно <see langword="false" />, создаются @p1, @p2 и т. д.</param>
		/// <returns>Автоматически созданный объект <see cref="T:System.Data.Odbc.OdbcCommand" />, необходимый для выполнения операций удаления.</returns>
		// Token: 0x06001FBD RID: 8125 RVA: 0x0009528D File Offset: 0x0009348D
		public new OdbcCommand GetDeleteCommand(bool useColumnsForParameterNames)
		{
			return (OdbcCommand)base.GetDeleteCommand(useColumnsForParameterNames);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0009529B File Offset: 0x0009349B
		protected override string GetParameterName(int parameterOrdinal)
		{
			return "p" + parameterOrdinal.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000056BA File Offset: 0x000038BA
		protected override string GetParameterName(string parameterName)
		{
			return parameterName;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000952B3 File Offset: 0x000934B3
		protected override string GetParameterPlaceholder(int parameterOrdinal)
		{
			return "?";
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000952BC File Offset: 0x000934BC
		protected override void ApplyParameterInfo(DbParameter parameter, DataRow datarow, StatementType statementType, bool whereClause)
		{
			OdbcParameter odbcParameter = (OdbcParameter)parameter;
			object obj = datarow[SchemaTableColumn.ProviderType];
			odbcParameter.OdbcType = (OdbcType)obj;
			object obj2 = datarow[SchemaTableColumn.NumericPrecision];
			if (DBNull.Value != obj2)
			{
				byte b = (byte)((short)obj2);
				odbcParameter.PrecisionInternal = ((byte.MaxValue != b) ? b : 0);
			}
			obj2 = datarow[SchemaTableColumn.NumericScale];
			if (DBNull.Value != obj2)
			{
				byte b2 = (byte)((short)obj2);
				odbcParameter.ScaleInternal = ((byte.MaxValue != b2) ? b2 : 0);
			}
		}

		/// <summary>Извлекает сведения о параметрах из хранимой процедуры, указанной в объекте <see cref="T:System.Data.Odbc.OdbcCommand" />, и включает их в коллекцию параметров <see cref="P:System.Data.Odbc.OdbcCommand.Parameters" /> указанного объекта <see cref="T:System.Data.Odbc.OdbcCommand" />.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.Odbc.OdbcCommand" /> ссылается на хранимую процедуру, из которой необходимо извлечь сведения о параметрах. Извлеченные параметры добавляются в коллекцию параметров <see cref="P:System.Data.Odbc.OdbcCommand.Parameters" /> объекта <see cref="T:System.Data.Odbc.OdbcCommand" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Основной драйвер ODBC не поддерживает возврат сведений о параметрах хранимой процедуры, или текст команды содержит неверное имя хранимой процедуры, или указанный объект <see cref="T:System.Data.CommandType" /> не является <see langword="CommandType.StoredProcedure" />.</exception>
		// Token: 0x06001FC2 RID: 8130 RVA: 0x00095348 File Offset: 0x00093548
		public static void DeriveParameters(OdbcCommand command)
		{
			if (command == null)
			{
				throw ADP.ArgumentNull("command");
			}
			CommandType commandType = command.CommandType;
			if (commandType == CommandType.Text)
			{
				throw ADP.DeriveParametersNotSupported(command);
			}
			if (commandType != CommandType.StoredProcedure)
			{
				if (commandType != CommandType.TableDirect)
				{
					throw ADP.InvalidCommandType(command.CommandType);
				}
				throw ADP.DeriveParametersNotSupported(command);
			}
			else
			{
				if (string.IsNullOrEmpty(command.CommandText))
				{
					throw ADP.CommandTextRequired("DeriveParameters");
				}
				OdbcConnection connection = command.Connection;
				if (connection == null)
				{
					throw ADP.ConnectionRequired("DeriveParameters");
				}
				ConnectionState state = connection.State;
				if (ConnectionState.Open != state)
				{
					throw ADP.OpenConnectionRequired("DeriveParameters", state);
				}
				OdbcParameter[] array = OdbcCommandBuilder.DeriveParametersFromStoredProcedure(connection, command);
				OdbcParameterCollection parameters = command.Parameters;
				parameters.Clear();
				int num = array.Length;
				if (0 < num)
				{
					for (int i = 0; i < array.Length; i++)
					{
						parameters.Add(array[i]);
					}
				}
				return;
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0009541C File Offset: 0x0009361C
		private static OdbcParameter[] DeriveParametersFromStoredProcedure(OdbcConnection connection, OdbcCommand command)
		{
			List<OdbcParameter> list = new List<OdbcParameter>();
			CMDWrapper statementHandle = command.GetStatementHandle();
			OdbcStatementHandle statementHandle2 = statementHandle.StatementHandle;
			string text = connection.QuoteChar("DeriveParameters");
			string[] array = MultipartIdentifier.ParseMultipartIdentifier(command.CommandText, text, text, '.', 4, true, "OdbcCommandBuilder.DeriveParameters failed because the OdbcCommand.CommandText property value is an invalid multipart name", false);
			if (array[3] == null)
			{
				array[3] = command.CommandText;
			}
			ODBC32.RetCode retCode = statementHandle2.ProcedureColumns(array[1], array[2], array[3], null);
			if (retCode != ODBC32.RetCode.SUCCESS)
			{
				connection.HandleError(statementHandle2, retCode);
			}
			using (OdbcDataReader odbcDataReader = new OdbcDataReader(command, statementHandle, CommandBehavior.Default))
			{
				odbcDataReader.FirstResult();
				int fieldCount = odbcDataReader.FieldCount;
				while (odbcDataReader.Read())
				{
					OdbcParameter odbcParameter = new OdbcParameter();
					odbcParameter.ParameterName = odbcDataReader.GetString(3);
					switch (odbcDataReader.GetInt16(4))
					{
					case 1:
						odbcParameter.Direction = ParameterDirection.Input;
						break;
					case 2:
						odbcParameter.Direction = ParameterDirection.InputOutput;
						break;
					case 4:
						odbcParameter.Direction = ParameterDirection.Output;
						break;
					case 5:
						odbcParameter.Direction = ParameterDirection.ReturnValue;
						break;
					}
					odbcParameter.OdbcType = TypeMap.FromSqlType((ODBC32.SQL_TYPE)odbcDataReader.GetInt16(5))._odbcType;
					odbcParameter.Size = odbcDataReader.GetInt32(7);
					OdbcType odbcType = odbcParameter.OdbcType;
					if (odbcType - OdbcType.Decimal <= 1)
					{
						odbcParameter.ScaleInternal = (byte)odbcDataReader.GetInt16(9);
						odbcParameter.PrecisionInternal = (byte)odbcDataReader.GetInt16(10);
					}
					list.Add(odbcParameter);
				}
			}
			retCode = statementHandle2.CloseCursor();
			return list.ToArray();
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом корректно исключаются встроенные в идентификатор кавычки.</summary>
		/// <param name="unquotedIdentifier">Исходный идентификатор без кавычек.</param>
		/// <returns>Версия идентификатора, заключенного кавычки. Кавычки, внедренные в идентификатор, корректно исключаются.</returns>
		// Token: 0x06001FC4 RID: 8132 RVA: 0x000955B4 File Offset: 0x000937B4
		public override string QuoteIdentifier(string unquotedIdentifier)
		{
			return this.QuoteIdentifier(unquotedIdentifier, null);
		}

		/// <summary>При заданном идентификаторе без кавычек в каталоге, набранном в правильном регистре, возвращает заключенный в кавычки идентификатор в корректной форме. При этом корректно исключаются встроенные в идентификатор кавычки.</summary>
		/// <param name="unquotedIdentifier">Исходный идентификатор без кавычек.</param>
		/// <param name="connection">Если подключение выполнено, заставляет управляемую оболочку получить символ кавычки от драйвера ODBC, вызывая SQLGetInfo (SQL_IDENTIFIER_QUOTE_CHAR). Если подключение не выполнено, строка заключается в кавычки, используя значения из свойств <see cref="P:System.Data.Common.DbCommandBuilder.QuotePrefix" /> и <see cref="P:System.Data.Common.DbCommandBuilder.QuoteSuffix" />.</param>
		/// <returns>Версия идентификатора, заключенного кавычки. Кавычки, внедренные в идентификатор, корректно исключаются.</returns>
		// Token: 0x06001FC5 RID: 8133 RVA: 0x000955C0 File Offset: 0x000937C0
		public string QuoteIdentifier(string unquotedIdentifier, OdbcConnection connection)
		{
			ADP.CheckArgumentNull(unquotedIdentifier, "unquotedIdentifier");
			string text = this.QuotePrefix;
			string quoteSuffix = this.QuoteSuffix;
			if (string.IsNullOrEmpty(text))
			{
				if (connection == null)
				{
					OdbcDataAdapter dataAdapter = this.DataAdapter;
					OdbcConnection odbcConnection;
					if (dataAdapter == null)
					{
						odbcConnection = null;
					}
					else
					{
						OdbcCommand selectCommand = dataAdapter.SelectCommand;
						odbcConnection = ((selectCommand != null) ? selectCommand.Connection : null);
					}
					connection = odbcConnection;
					if (connection == null)
					{
						throw ADP.QuotePrefixNotSet("QuoteIdentifier");
					}
				}
				text = connection.QuoteChar("QuoteIdentifier");
				quoteSuffix = text;
			}
			if (!string.IsNullOrEmpty(text) && text != " ")
			{
				return ADP.BuildQuotedString(text, quoteSuffix, unquotedIdentifier);
			}
			return unquotedIdentifier;
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0009564C File Offset: 0x0009384C
		protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
		{
			if (adapter == base.DataAdapter)
			{
				((OdbcDataAdapter)adapter).RowUpdating -= this.OdbcRowUpdatingHandler;
				return;
			}
			((OdbcDataAdapter)adapter).RowUpdating += this.OdbcRowUpdatingHandler;
		}

		/// <summary>Если идентификатор заключен в кавычки, возвращает правильную форму этого идентификатора без кавычек, при этом корректно учитываются кавычки, внедренные в идентификатор.</summary>
		/// <param name="quotedIdentifier">Идентификатор, из которого будут удалены внедренные кавычки.</param>
		/// <returns>Идентификатор без кавычек, в котором корректно сохранены все внедренные кавычки.</returns>
		// Token: 0x06001FC7 RID: 8135 RVA: 0x00095686 File Offset: 0x00093886
		public override string UnquoteIdentifier(string quotedIdentifier)
		{
			return this.UnquoteIdentifier(quotedIdentifier, null);
		}

		/// <summary>Если идентификатор заключен в кавычки, возвращает правильную форму этого идентификатора без кавычек, при этом корректно учитываются кавычки, внедренные в идентификатор.</summary>
		/// <param name="quotedIdentifier">Идентификатор, из которого будут удалены внедренные кавычки.</param>
		/// <param name="connection">
		///   <see cref="T:System.Data.Odbc.OdbcConnection" />.</param>
		/// <returns>Идентификатор без кавычек, в котором корректно сохранены все внедренные кавычки.</returns>
		// Token: 0x06001FC8 RID: 8136 RVA: 0x00095690 File Offset: 0x00093890
		public string UnquoteIdentifier(string quotedIdentifier, OdbcConnection connection)
		{
			ADP.CheckArgumentNull(quotedIdentifier, "quotedIdentifier");
			string text = this.QuotePrefix;
			string quoteSuffix = this.QuoteSuffix;
			if (string.IsNullOrEmpty(text))
			{
				if (connection == null)
				{
					OdbcDataAdapter dataAdapter = this.DataAdapter;
					OdbcConnection odbcConnection;
					if (dataAdapter == null)
					{
						odbcConnection = null;
					}
					else
					{
						OdbcCommand selectCommand = dataAdapter.SelectCommand;
						odbcConnection = ((selectCommand != null) ? selectCommand.Connection : null);
					}
					connection = odbcConnection;
					if (connection == null)
					{
						throw ADP.QuotePrefixNotSet("UnquoteIdentifier");
					}
				}
				text = connection.QuoteChar("UnquoteIdentifier");
				quoteSuffix = text;
			}
			string result;
			if (!string.IsNullOrEmpty(text) || text != " ")
			{
				ADP.RemoveStringQuotes(text, quoteSuffix, quotedIdentifier, out result);
			}
			else
			{
				result = quotedIdentifier;
			}
			return result;
		}
	}
}
