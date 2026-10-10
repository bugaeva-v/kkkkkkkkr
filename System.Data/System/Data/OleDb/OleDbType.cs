using System;

namespace System.Data.OleDb
{
	/// <summary>Задает тип данных поля или свойства для использования в объекте <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
	// Token: 0x0200015C RID: 348
	public enum OleDbType
	{
		/// <summary>64-разрядное целое число со знаком (DBTYPE_I8). Соответствует <see cref="T:System.Int64" />.</summary>
		// Token: 0x04000BAC RID: 2988
		BigInt = 20,
		/// <summary>Поток двоичных данных (DBTYPE_BYTES). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x04000BAD RID: 2989
		Binary = 128,
		/// <summary>Логическое значение (DBTYPE_BOOL). Соответствует <see cref="T:System.Boolean" />.</summary>
		// Token: 0x04000BAE RID: 2990
		Boolean = 11,
		/// <summary>Строка знаков Юникод, заканчивающаяся знаком null (DBTYPE_BSTR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BAF RID: 2991
		BSTR = 8,
		/// <summary>Строка знаков (DBTYPE_STR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BB0 RID: 2992
		Char = 129,
		/// <summary>Значение валюты в диапазоне от –2 63 (или –922 337 203 685 477,5808) до 2 63 –1 (или +922 337 203 685 477,5807) с точностью до десятитысячных единицы валюты (DBTYPE_CY). Соответствует <see cref="T:System.Decimal" />.</summary>
		// Token: 0x04000BB1 RID: 2993
		Currency = 6,
		/// <summary>Дата в формате двойного числа с плавающей точкой (DBTYPE_DATE). Целая часть числа равна числу дней, прошедшему с 30 декабря 1899 г., а десятичная часть равна части дня. Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04000BB2 RID: 2994
		Date,
		/// <summary>Данные, представляющие дату, в формате ггггммдд (DBTYPE_DBDATE). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04000BB3 RID: 2995
		DBDate = 133,
		/// <summary>Данные, представляющие время, в формате ччммсс (DBTYPE_DBTIME). Соответствует <see cref="T:System.TimeSpan" />.</summary>
		// Token: 0x04000BB4 RID: 2996
		DBTime,
		/// <summary>Данные, представляющие дату и время, в формате ггггммддччммсс (DBTYPE_DBTIMESTAMP). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04000BB5 RID: 2997
		DBTimeStamp,
		/// <summary>Числовое значение с фиксированной точностью и масштабом в диапазоне от –10 38 –1 до 10 38 –1 (DBTYPE_DECIMAL). Соответствует <see cref="T:System.Decimal" />.</summary>
		// Token: 0x04000BB6 RID: 2998
		Decimal = 14,
		/// <summary>Число с плавающей запятой в диапазоне от -1,79E +308 до 1,79E +308 (DBTYPE_R8). Соответствует <see cref="T:System.Double" />.</summary>
		// Token: 0x04000BB7 RID: 2999
		Double = 5,
		/// <summary>Нет значения (DBTYPE_EMPTY).</summary>
		// Token: 0x04000BB8 RID: 3000
		Empty = 0,
		/// <summary>32-разрядный код ошибки (DBTYPE_ERROR). Соответствует <see cref="T:System.Exception" />.</summary>
		// Token: 0x04000BB9 RID: 3001
		Error = 10,
		/// <summary>64-разрядное целое число без знака, представляющее число интервалов по 100 наносекунд, прошедших с 1 января 1601 г. (DBTYPE_FILETIME). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04000BBA RID: 3002
		Filetime = 64,
		/// <summary>Глобальный уникальный идентификатор (GUID) (DBTYPE_GUID). Соответствует <see cref="T:System.Guid" />.</summary>
		// Token: 0x04000BBB RID: 3003
		Guid = 72,
		/// <summary>Указатель на интерфейс <see langword="IDispatch" /> (DBTYPE_IDISPATCH). Соответствует <see cref="T:System.Object" />.</summary>
		// Token: 0x04000BBC RID: 3004
		IDispatch = 9,
		/// <summary>32-разрядное целое число со знаком (DBTYPE_I4). Соответствует <see cref="T:System.Int32" />.</summary>
		// Token: 0x04000BBD RID: 3005
		Integer = 3,
		/// <summary>Указатель на интерфейс <see langword="IUnknown" /> (DBTYPE_UNKNOWN). Соответствует <see cref="T:System.Object" />.</summary>
		// Token: 0x04000BBE RID: 3006
		IUnknown = 13,
		/// <summary>Длинное двоичное значение (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x04000BBF RID: 3007
		LongVarBinary = 205,
		/// <summary>Длинное строковое значение (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BC0 RID: 3008
		LongVarChar = 201,
		/// <summary>Длинное значение — строка Юникод, оканчивающаяся знаком null (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BC1 RID: 3009
		LongVarWChar = 203,
		/// <summary>Точное числовое значение с фиксированной точностью и масштабом (DBTYPE_NUMERIC). Соответствует <see cref="T:System.Decimal" />.</summary>
		// Token: 0x04000BC2 RID: 3010
		Numeric = 131,
		/// <summary>PROPVARIANT автоматизации (DBTYPE_PROP_VARIANT). Соответствует <see cref="T:System.Object" />.</summary>
		// Token: 0x04000BC3 RID: 3011
		PropVariant = 138,
		/// <summary>Число с плавающей запятой в диапазоне от -3,40E +38 до 3,40E +38 (DBTYPE_R4). Соответствует <see cref="T:System.Single" />.</summary>
		// Token: 0x04000BC4 RID: 3012
		Single = 4,
		/// <summary>16-разрядное целое число со знаком (DBTYPE_I2). Соответствует <see cref="T:System.Int16" />.</summary>
		// Token: 0x04000BC5 RID: 3013
		SmallInt = 2,
		/// <summary>8-разрядное целое число со знаком (DBTYPE_I1). Соответствует <see cref="T:System.SByte" />.</summary>
		// Token: 0x04000BC6 RID: 3014
		TinyInt = 16,
		/// <summary>64-разрядное целое число без знака (DBTYPE_UI8). Соответствует <see cref="T:System.UInt64" />.</summary>
		// Token: 0x04000BC7 RID: 3015
		UnsignedBigInt = 21,
		/// <summary>32-разрядное целое число без знака (DBTYPE_UI4). Соответствует <see cref="T:System.UInt32" />.</summary>
		// Token: 0x04000BC8 RID: 3016
		UnsignedInt = 19,
		/// <summary>16-разрядное целое число без знака (DBTYPE_UI2). Соответствует <see cref="T:System.UInt16" />.</summary>
		// Token: 0x04000BC9 RID: 3017
		UnsignedSmallInt = 18,
		/// <summary>8-разрядное целое число без знака (DBTYPE_UI1). Соответствует <see cref="T:System.Byte" />.</summary>
		// Token: 0x04000BCA RID: 3018
		UnsignedTinyInt = 17,
		/// <summary>Поток двоичных данных переменной длины (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x04000BCB RID: 3019
		VarBinary = 204,
		/// <summary>Поток знаков (отличных от знаков Юникода) переменной длины (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BCC RID: 3020
		VarChar = 200,
		/// <summary>Особый тип данных, который может содержать числовые, строковые, двоичные значения, даты, а также специальные значения Empty и Null (DBTYPE_VARIANT). Если не указан другой тип, предполагается этот тип. Соответствует <see cref="T:System.Object" />.</summary>
		// Token: 0x04000BCD RID: 3021
		Variant = 12,
		/// <summary>Числовое значение с переменной длиной (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.Decimal" />.</summary>
		// Token: 0x04000BCE RID: 3022
		VarNumeric = 139,
		/// <summary>Поток знаков Юникода переменной длины, заканчивающийся знаком null (только <see cref="T:System.Data.OleDb.OleDbParameter" />). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BCF RID: 3023
		VarWChar = 202,
		/// <summary>Поток знаков Юникода, заканчивающийся знаком null (DBTYPE_WSTR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04000BD0 RID: 3024
		WChar = 130
	}
}
