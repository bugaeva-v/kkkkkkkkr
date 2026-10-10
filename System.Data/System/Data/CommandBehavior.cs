using System;

namespace System.Data
{
	/// <summary>Предоставляет описание результатов запроса и его влияние на базу данных.</summary>
	// Token: 0x020000A4 RID: 164
	[Flags]
	public enum CommandBehavior
	{
		/// <summary>Запрос может вернуть несколько наборов результатов. Выполнение запроса может повлиять на состояние базы данных. Поле <see langword="Default" /> не задает флаги <see cref="T:System.Data.CommandBehavior" />, поэтому вызов метода <see langword="ExecuteReader(CommandBehavior.Default)" /> функционально эквивалентен вызову метода <see langword="ExecuteReader()" />.</summary>
		// Token: 0x04000762 RID: 1890
		Default = 0,
		/// <summary>Запрос возвращает один набор результатов.</summary>
		// Token: 0x04000763 RID: 1891
		SingleResult = 1,
		/// <summary>Запрос возвращает только сведения о столбце. При использовании <see cref="F:System.Data.CommandBehavior.SchemaOnly" /> поставщик данных .NET Framework для SQL Server предваряет оператор, выполняемый с параметром SET FMTONLY ON.</summary>
		// Token: 0x04000764 RID: 1892
		SchemaOnly = 2,
		/// <summary>Запрос возвращает информацию колонки и первичного ключа.</summary>
		// Token: 0x04000765 RID: 1893
		KeyInfo = 4,
		/// <summary>Ожидается, что запрос вернет одну строку из первого набора результатов. Выполнение запроса может повлиять на состояние базы данных. Некоторые поставщики данных .NET Framework могут, но не обязательно, использовать эту информацию для оптимизации производительности команды. При указании <see cref="F:System.Data.CommandBehavior.SingleRow" /> с методом <see cref="M:System.Data.OleDb.OleDbCommand.ExecuteReader" /> объекта <see cref="T:System.Data.OleDb.OleDbCommand" />, поставщик данных .NET Framework для OLE DB выполняет привязку с помощью интерфейса <see langword="IRow" /> OLE DB, если он доступен. В обратном случае, используется интерфейс <see langword="IRowset" />. Если оператор SQL должен вернуть только одну строку, рекомендуется указать <see cref="F:System.Data.CommandBehavior.SingleRow" /> для повышения производительности приложения. Можно также указать <see langword="SingleRow" /> при выполнении запросов, которые должны возвращать несколько наборов результатов.  В этом случае, если заданы и SQL-запрос с несколькими наборами результатом, и одна строка, возвращаемый результат будет содержать только первую строку первого набора результатов. Другие наборы результатов запроса не возвращаются.</summary>
		// Token: 0x04000766 RID: 1894
		SingleRow = 8,
		/// <summary>Содержит способ для <see langword="DataReader" /> для обработки строк, содержащих столбцы с большими двоичными значениями. Вместо загрузки всей строки, <see langword="SequentialAccess" /> позволяет <see langword="DataReader" /> загрузить данные как поток. Затем можно использовать метод <see langword="GetBytes" /> или метод <see langword="GetChars" />, чтобы указать положение байта для начала операции чтения и ограниченный размер буфера для возврата данных.</summary>
		// Token: 0x04000767 RID: 1895
		SequentialAccess = 16,
		/// <summary>При выполнении этой команды связанный объект <see langword="Connection" /> закрывается, когда закрывается связанный объект <see langword="DataReader" />.</summary>
		// Token: 0x04000768 RID: 1896
		CloseConnection = 32
	}
}
