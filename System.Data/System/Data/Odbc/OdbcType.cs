using System;

namespace System.Data.Odbc
{
	/// <summary>Задает тип данных поля или свойства для использования в объекте <see cref="T:System.Data.Odbc.OdbcParameter" />.</summary>
	// Token: 0x020002FD RID: 765
	public enum OdbcType
	{
		/// <summary>Точное числовое значение с точностью 19 (со знаком) или 20 (без знака) и масштабом 0 (со знаком: –2[63] &lt;= n &lt;= 2[63] – 1, без знака: 0 &lt;= n &lt;= 2[64] – 1) (SQL_BIGINT). Соответствует <see cref="T:System.Int64" />.</summary>
		// Token: 0x04001804 RID: 6148
		BigInt = 1,
		/// <summary>Поток двоичных данных (SQL_BINARY). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x04001805 RID: 6149
		Binary,
		/// <summary>Однобитовые двоичные данные (SQL_BIT). Соответствует <see cref="T:System.Boolean" />.</summary>
		// Token: 0x04001806 RID: 6150
		Bit,
		/// <summary>Строка символов фиксированной длины (SQL_CHAR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04001807 RID: 6151
		Char,
		/// <summary>Данные, представляющие дату в формате ггггммддччммсс (SQL_TYPE_TIMESTAMP). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04001808 RID: 6152
		DateTime,
		/// <summary>Точное числовое значение со знаком с точностью по крайней мере p и масштабом s, где 1 &lt;= p &lt;= 15 и s &lt;= p. Максимальная точность зависит от драйвера (SQL_DECIMAL). Соответствует <see cref="T:System.Decimal" />.</summary>
		// Token: 0x04001809 RID: 6153
		Decimal,
		/// <summary>Точное числовое значение со знаком с точностью p и масштабом s, где 1 &lt;= p &lt;= 15 и s &lt;= p (SQL_NUMERIC). Соответствует <see cref="T:System.Decimal" />.</summary>
		// Token: 0x0400180A RID: 6154
		Numeric,
		/// <summary>Приближенное числовое значение со знаком и двоичной точностью 53 (ноль или абсолютное значение от 10[–308] до 10[308]) (SQL_DOUBLE). Соответствует <see cref="T:System.Double" />.</summary>
		// Token: 0x0400180B RID: 6155
		Double,
		/// <summary>Двоичные данные с переменной длиной. Максимальная длина зависит от источника данных (SQL_LONGVARBINARY). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x0400180C RID: 6156
		Image,
		/// <summary>Точное числовое значение с точностью 10 и масштабом 0 (со знаком: –2[31] &lt;= n &lt;= 2[31] – 1, без знака: 0 &lt;= n &lt;= 2[32] – 1) (SQL_INTEGER). Соответствует <see cref="T:System.Int32" />.</summary>
		// Token: 0x0400180D RID: 6157
		Int,
		/// <summary>Строка символов Юникода с фиксированной длиной (SQL_WCHAR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x0400180E RID: 6158
		NChar,
		/// <summary>Символьные данные Юникода с переменной длиной. Максимальная длина зависит от источника данных. (SQL_WLONGVARCHAR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x0400180F RID: 6159
		NText,
		/// <summary>Поток символов Юникода с переменной длиной (SQL_WVARCHAR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04001810 RID: 6160
		NVarChar,
		/// <summary>Приближенное числовое значение со знаком и двоичной точностью 24 (ноль или абсолютное значение от 10[-38] до 10[38]) (SQL_REAL). Соответствует <see cref="T:System.Single" />.</summary>
		// Token: 0x04001811 RID: 6161
		Real,
		/// <summary>Идентификатор GUID с фиксированной длиной (SQL_GUID). Соответствует <see cref="T:System.Guid" />.</summary>
		// Token: 0x04001812 RID: 6162
		UniqueIdentifier,
		/// <summary>Данные, представляющие дату и время в формате ггггммддччммсс (SQL_TYPE_TIMESTAMP). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04001813 RID: 6163
		SmallDateTime,
		/// <summary>Точное числовое значение с точностью 5 и масштабом 0 (со знаком: –32 768 &lt;= n &lt;= 32 767, без знака: 0 &lt;= n &lt;= 65 535) (SQL_SMALLINT). Соответствует <see cref="T:System.Int16" />.</summary>
		// Token: 0x04001814 RID: 6164
		SmallInt,
		/// <summary>Символьные данные с переменной длиной. Максимальная длина зависит от источника данных (SQL_LONGVARCHAR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04001815 RID: 6165
		Text,
		/// <summary>Поток двоичных данных (SQL_BINARY). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x04001816 RID: 6166
		Timestamp,
		/// <summary>Точное числовое значение с точностью 3 и масштабом 0 (со знаком: –128 &lt;= n &lt;= 127, без знака: 0 &lt;= n &lt;= 255) (SQL_TINYINT). Соответствует <see cref="T:System.Byte" />.</summary>
		// Token: 0x04001817 RID: 6167
		TinyInt,
		/// <summary>Двоичные данные переменной длины. Максимальная длина задается пользователем (SQL_VARBINARY). Соответствует <see cref="T:System.Array" /> типа <see cref="T:System.Byte" />.</summary>
		// Token: 0x04001818 RID: 6168
		VarBinary,
		/// <summary>Потоковая символьная строка переменной длины (SQL_CHAR). Соответствует <see cref="T:System.String" />.</summary>
		// Token: 0x04001819 RID: 6169
		VarChar,
		/// <summary>Данные, представляющие дату в формате ггггммдд (SQL_TYPE_DATE). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x0400181A RID: 6170
		Date,
		/// <summary>Данные, представляющие дату в формате ччммсс (SQL_TYPE_TIMES). Соответствует <see cref="T:System.DateTime" />.</summary>
		// Token: 0x0400181B RID: 6171
		Time
	}
}
