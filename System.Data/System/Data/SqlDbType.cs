using System;

namespace System.Data
{
	/// <summary>Указывает относящийся к SQL Server тип данных поля или свойства для использования в <see cref="T:System.Data.SqlClient.SqlParameter" />.</summary>
	// Token: 0x02000130 RID: 304
	public enum SqlDbType
	{
		/// <summary>
		///   <see cref="T:System.Int64" />. 64-разрядное целое число со знаком.</summary>
		// Token: 0x04000A23 RID: 2595
		BigInt,
		/// <summary>
		///   <see cref="T:System.Array" /> имеет тип данных <see cref="T:System.Byte" />. Поток фиксированной длины из двоичных данных, имеющий длину от 1 до 8000 байтов.</summary>
		// Token: 0x04000A24 RID: 2596
		Binary,
		/// <summary>
		///   <see cref="T:System.Boolean" />. Числовое значение без знака, которое может быть равно 0, 1 или <see langword="null" />.</summary>
		// Token: 0x04000A25 RID: 2597
		Bit,
		/// <summary>
		///   <see cref="T:System.String" />. Поток фиксированной длины из символов, не принадлежащих кодировке Юникод. В нем может быть от 1 до 8000 символов.</summary>
		// Token: 0x04000A26 RID: 2598
		Char,
		/// <summary>
		///   <see cref="T:System.DateTime" />. Значение даты и времени, лежащее в диапазоне от 1 января 1753 года до 31 декабря 9999 года и имеющее точность 3.33 миллисекунды.</summary>
		// Token: 0x04000A27 RID: 2599
		DateTime,
		/// <summary>
		///   <see cref="T:System.Decimal" />. Числовое значение с фиксированной точностью и масштабом в диапазоне от –10 38 –1 до 10 38 –1.</summary>
		// Token: 0x04000A28 RID: 2600
		Decimal,
		/// <summary>
		///   <see cref="T:System.Double" />. Числовое значение с плавающей запятой, лежащее в диапазоне от -1.79E +308 до 1.79E +308.</summary>
		// Token: 0x04000A29 RID: 2601
		Float,
		/// <summary>
		///   <see cref="T:System.Array" /> имеет тип данных <see cref="T:System.Byte" />. Поток переменной длины из двоичных данных, имеющий длину от 0 до 2 31 –1 (или 2 147 483 647) байтов.</summary>
		// Token: 0x04000A2A RID: 2602
		Image,
		/// <summary>
		///   <see cref="T:System.Int32" />. 32-разрядное знаковое целое число.</summary>
		// Token: 0x04000A2B RID: 2603
		Int,
		/// <summary>
		///   <see cref="T:System.Decimal" />. Значение типа currency, лежащее в диапазоне от –2 63 (или –9 223 372 036 854 775 808) до 2 63 –1 (или +9 223 372 036 854 775 807) и имеющее точность до одной десятитысячной денежной единицы.</summary>
		// Token: 0x04000A2C RID: 2604
		Money,
		/// <summary>
		///   <see cref="T:System.String" />. Поток фиксированной длины из символов кодировки Юникод. В нем может быть от 1 до 4 000 символов.</summary>
		// Token: 0x04000A2D RID: 2605
		NChar,
		/// <summary>
		///   <see cref="T:System.String" />. Поток переменной длины из данных Юникод, максимальная длина которого равна 2 30 – 1 (или 1 073 741 823) символов.</summary>
		// Token: 0x04000A2E RID: 2606
		NText,
		/// <summary>
		///   <see cref="T:System.String" />. Поток переменной длины из символов кодировки Юникод. В нем может быть от 1 до 4 000 символов. Неявное преобразование не может быть выполнено, если длина строки превышает 4 000 символов. Поэтому при работе со строками длиннее 4 000 символов нужно явно задавать значение этого объекта. Используйте <see cref="F:System.Data.SqlDbType.NVarChar" />, если столбец базы данных имеет тип <see langword="nvarchar(max)" />.</summary>
		// Token: 0x04000A2F RID: 2607
		NVarChar,
		/// <summary>
		///   <see cref="T:System.Single" />. Числовое значение с плавающей запятой, лежащее в диапазоне от -3,40E +38 до 3,40E +38.</summary>
		// Token: 0x04000A30 RID: 2608
		Real,
		/// <summary>
		///   <see cref="T:System.Guid" />. Глобальный уникальный идентификатор (GUID).</summary>
		// Token: 0x04000A31 RID: 2609
		UniqueIdentifier,
		/// <summary>
		///   <see cref="T:System.DateTime" />. Значение даты и времени, лежащее в диапазоне от 1 января 1900 года до 6 июня 2079 года, точность которого равна одной минуте.</summary>
		// Token: 0x04000A32 RID: 2610
		SmallDateTime,
		/// <summary>
		///   <see cref="T:System.Int16" />. 16-разрядное знаковое целое число.</summary>
		// Token: 0x04000A33 RID: 2611
		SmallInt,
		/// <summary>
		///   <see cref="T:System.Decimal" />. Денежная сумма в диапазоне от -214 748,3648 до +214 748,3647 с точностью, равной одной десятитысячной денежной единицы.</summary>
		// Token: 0x04000A34 RID: 2612
		SmallMoney,
		/// <summary>
		///   <see cref="T:System.String" />. Поток переменной длины из символов, не принадлежащих кодировке Юникод, максимальная длина которого равна 2 31 –1 (или 2 147 483 647) символов.</summary>
		// Token: 0x04000A35 RID: 2613
		Text,
		/// <summary>
		///   <see cref="T:System.Array" /> имеет тип данных <see cref="T:System.Byte" />. Автоматически создаваемые двоичные числа, которые гарантированно являются уникальными в пределах базы данных. Значения <see langword="timestamp" /> обычно используются для отметки версий строк таблицы. Размер при хранении — 8 байт.</summary>
		// Token: 0x04000A36 RID: 2614
		Timestamp,
		/// <summary>
		///   <see cref="T:System.Byte" />. 8-разрядное целое число без знака.</summary>
		// Token: 0x04000A37 RID: 2615
		TinyInt,
		/// <summary>
		///   <see cref="T:System.Array" /> имеет тип данных <see cref="T:System.Byte" />. Поток переменной длины из двоичных данных, имеющий длину от 1 до 8000 байт. Неявное преобразование не может быть выполнено, если длина массива превышает 8 000 байтов. Поэтому при работе с массивами байтов, состоящими из более чем 8000 байтов, нужно явно задать значение этого объекта.</summary>
		// Token: 0x04000A38 RID: 2616
		VarBinary,
		/// <summary>
		///   <see cref="T:System.String" />. Поток переменной длины из символов, не принадлежащих кодировке Юникод. В нем может быть от 1 до 8000 символов. Используйте <see cref="F:System.Data.SqlDbType.VarChar" />, если столбец базы данных имеет тип <see langword="varchar(max)" />.</summary>
		// Token: 0x04000A39 RID: 2617
		VarChar,
		/// <summary>
		///   <see cref="T:System.Object" />. Специальный тип данных, который может содержать числовые, строковые, двоичные данные, даты, а также значения Empty и Null, относящиеся к SQL Server. Если ни один тип не объявлен, считается, что данные имеют этот тип.</summary>
		// Token: 0x04000A3A RID: 2618
		Variant,
		/// <summary>Значение XML. Получает XML как строку с помощью метода <see cref="M:System.Data.SqlClient.SqlDataReader.GetValue(System.Int32)" /> или свойства <see cref="P:System.Data.SqlTypes.SqlXml.Value" />, или в качестве средства чтения <see cref="T:System.Xml.XmlReader" /> путем вызова метода <see cref="M:System.Data.SqlTypes.SqlXml.CreateReader" />.</summary>
		// Token: 0x04000A3B RID: 2619
		Xml = 25,
		/// <summary>Пользовательский тип (UDT) SQL Server.</summary>
		// Token: 0x04000A3C RID: 2620
		Udt = 29,
		/// <summary>Специальный тип данных для определения структурированных данных, содержащихся в параметрах табличных значений.</summary>
		// Token: 0x04000A3D RID: 2621
		Structured,
		/// <summary>Значение даты может находиться в диапазоне от 1 января 1 г. н. э. до 31 декабря 9999 года н. э.</summary>
		// Token: 0x04000A3E RID: 2622
		Date,
		/// <summary>Данные времени в 24-часовом формате. Значение времени может находиться в диапазоне от 00:00:00 до 23:59:59,9999999 с точностью до 100 наносекунд. Соответствует значению <see langword="time" /> SQL Server.</summary>
		// Token: 0x04000A3F RID: 2623
		Time,
		/// <summary>Данные даты и времени. Значение даты может находиться в диапазоне от 1 января 1 г. н. э. до 31 декабря 9999 года н. э. Значение времени может находиться в диапазоне от 00:00:00 до 23:59:59,9999999 с точностью до 100 наносекунд.</summary>
		// Token: 0x04000A40 RID: 2624
		DateTime2,
		/// <summary>Данные даты и времени с учетом часового пояса. Значение даты может находиться в диапазоне от 1 января 1 г. н. э. до 31 декабря 9999 года н. э. Значение времени может находиться в диапазоне от 00:00:00 до 23:59:59,9999999 с точностью до 100 наносекунд. Часовые пояса могут находиться в диапазоне от -14:00 до +14:00.</summary>
		// Token: 0x04000A41 RID: 2625
		DateTimeOffset
	}
}
