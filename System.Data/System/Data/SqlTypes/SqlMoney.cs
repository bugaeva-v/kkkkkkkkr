using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет значение валюты в диапазоне от –2 63 (или –922 337 203 685 477,5808) до 2 63 –1 (или +922 337 203 685 477,5807) с точностью до десятитысячных единицы валюты, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000314 RID: 788
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlMoney : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002512 RID: 9490 RVA: 0x000A7923 File Offset: 0x000A5B23
		private SqlMoney(bool fNull)
		{
			this._fNotNull = false;
			this._value = 0L;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000A7934 File Offset: 0x000A5B34
		internal SqlMoney(long value, int ignored)
		{
			this._value = value;
			this._fNotNull = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlMoney" /> с заданным целым значением.</summary>
		/// <param name="value">Денежное значение для инициализации.</param>
		// Token: 0x06002514 RID: 9492 RVA: 0x000A7944 File Offset: 0x000A5B44
		public SqlMoney(int value)
		{
			this._value = (long)value * SqlMoney.s_lTickBase;
			this._fNotNull = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlMoney" /> с заданным значением типа длинное целое.</summary>
		/// <param name="value">Денежное значение для инициализации.</param>
		// Token: 0x06002515 RID: 9493 RVA: 0x000A795B File Offset: 0x000A5B5B
		public SqlMoney(long value)
		{
			if (value < SqlMoney.s_minLong || value > SqlMoney.s_maxLong)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this._value = value * SqlMoney.s_lTickBase;
			this._fNotNull = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlMoney" /> заданным значением <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Денежное значение для инициализации.</param>
		// Token: 0x06002516 RID: 9494 RVA: 0x000A798C File Offset: 0x000A5B8C
		public SqlMoney(decimal value)
		{
			SqlDecimal sqlDecimal = new SqlDecimal(value);
			sqlDecimal.AdjustScale(SqlMoney.s_iMoneyScale - (int)sqlDecimal.Scale, true);
			if (sqlDecimal._data3 != 0U || sqlDecimal._data4 != 0U)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			bool isPositive = sqlDecimal.IsPositive;
			ulong num = (ulong)sqlDecimal._data1 + ((ulong)sqlDecimal._data2 << 32);
			if ((isPositive && num > 9223372036854775807UL) || (!isPositive && num > 9223372036854775808UL))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this._value = (long)(isPositive ? num : (-(long)num));
			this._fNotNull = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlMoney" /> с заданным значением типа double.</summary>
		/// <param name="value">Денежное значение для инициализации.</param>
		// Token: 0x06002517 RID: 9495 RVA: 0x000A7A2A File Offset: 0x000A5C2A
		public SqlMoney(double value)
		{
			this = new SqlMoney(new decimal(value));
		}

		/// <summary>Возвращает логическое значение, показывающее, имеет ли данная структура <see cref="T:System.Data.SqlTypes.SqlMoney" /> значение NULL.</summary>
		/// <returns>Значение <see langword="true" />, если NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000A7A38 File Offset: 0x000A5C38
		public bool IsNull
		{
			get
			{
				return !this._fNotNull;
			}
		}

		/// <summary>Получает денежное значение экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Денежное значение экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Для свойства задано значение NULL.</exception>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000A7A43 File Offset: 0x000A5C43
		public decimal Value
		{
			get
			{
				if (this._fNotNull)
				{
					return this.ToDecimal();
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Преобразует значение этого экземпляра <see cref="T:System.Data.SqlTypes.SqlMoney" /> как структуру <see cref="T:System.Decimal" />.</summary>
		/// <returns>Структура <see cref="T:System.Decimal" />, значение которой равно свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600251A RID: 9498 RVA: 0x000A7A5C File Offset: 0x000A5C5C
		public decimal ToDecimal()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			bool isNegative = false;
			long num = this._value;
			if (this._value < 0L)
			{
				isNegative = true;
				num = -this._value;
			}
			return new decimal((int)num, (int)(num >> 32), 0, isNegative, (byte)SqlMoney.s_iMoneyScale);
		}

		/// <summary>Преобразует значение этой структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Int64" />.</summary>
		/// <returns>64-разрядное целое число, значение которого равно целой части этой структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600251B RID: 9499 RVA: 0x000A7AA8 File Offset: 0x000A5CA8
		public long ToInt64()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			long num = this._value / (SqlMoney.s_lTickBase / 10L);
			bool flag = num >= 0L;
			long num2 = num % 10L;
			num /= 10L;
			if (num2 >= 5L)
			{
				if (flag)
				{
					num += 1L;
				}
				else
				{
					num -= 1L;
				}
			}
			return num;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000A7AFE File Offset: 0x000A5CFE
		internal long ToSqlInternalRepresentation()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			return this._value;
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Int32" />.</summary>
		/// <returns>32-разрядное целое число, значение которого равно целой части этой структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600251D RID: 9501 RVA: 0x000A7B14 File Offset: 0x000A5D14
		public int ToInt32()
		{
			return checked((int)this.ToInt64());
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Double" />.</summary>
		/// <returns>Структура типа double со значением, равным этой структуре <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600251E RID: 9502 RVA: 0x000A7B1D File Offset: 0x000A5D1D
		public double ToDouble()
		{
			return decimal.ToDouble(this.ToDecimal());
		}

		/// <summary>Преобразует параметр <see cref="T:System.Decimal" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемое значение <see cref="T:System.Decimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно значению параметра <see cref="T:System.Decimal" />.</returns>
		// Token: 0x0600251F RID: 9503 RVA: 0x000A7B2A File Offset: 0x000A5D2A
		public static implicit operator SqlMoney(decimal x)
		{
			return new SqlMoney(x);
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002520 RID: 9504 RVA: 0x000A7B32 File Offset: 0x000A5D32
		public static explicit operator SqlMoney(double x)
		{
			return new SqlMoney(x);
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Int64" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Int64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно значению параметра <see cref="T:System.Int64" />.</returns>
		// Token: 0x06002521 RID: 9505 RVA: 0x000A7B3A File Offset: 0x000A5D3A
		public static implicit operator SqlMoney(long x)
		{
			return new SqlMoney(new decimal(x));
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Decimal" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Decimal" />, значение которой равно <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002522 RID: 9506 RVA: 0x000A7B47 File Offset: 0x000A5D47
		public static explicit operator decimal(SqlMoney x)
		{
			return x.Value;
		}

		/// <summary>Преобразует этот экземпляр <see cref="T:System.Data.SqlTypes.SqlMoney" /> в строку.</summary>
		/// <returns>Строка, значение которой является строковым представлением значения данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002523 RID: 9507 RVA: 0x000A7B50 File Offset: 0x000A5D50
		public override string ToString()
		{
			if (this.IsNull)
			{
				return SQLResource.NullString;
			}
			return this.ToDecimal().ToString("#0.00##", null);
		}

		/// <summary>Преобразует представление числа типа <see cref="T:System.String" /> в эквивалентное ему значение <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="s">Представление <see langword="String" />, которое необходимо проанализировать.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlMoney" />, эквивалентное значению, которое содержится в заданном представлении <see cref="T:System.String" />.</returns>
		// Token: 0x06002524 RID: 9508 RVA: 0x000A7B80 File Offset: 0x000A5D80
		public static SqlMoney Parse(string s)
		{
			SqlMoney @null;
			decimal value;
			if (s == SQLResource.NullString)
			{
				@null = SqlMoney.Null;
			}
			else if (decimal.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol, NumberFormatInfo.InvariantInfo, out value))
			{
				@null = new SqlMoney(value);
			}
			else
			{
				@null = new SqlMoney(decimal.Parse(s, NumberStyles.Currency, NumberFormatInfo.CurrentInfo));
			}
			return @null;
		}

		/// <summary>Оператор "унарный минус" меняет знак параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, для которой выполняется инверсия.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит результаты отрицания.</returns>
		// Token: 0x06002525 RID: 9509 RVA: 0x000A7BD8 File Offset: 0x000A5DD8
		public static SqlMoney operator -(SqlMoney x)
		{
			if (x.IsNull)
			{
				return SqlMoney.Null;
			}
			if (x._value == SqlMoney.s_minLong)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlMoney(-x._value, 0);
		}

		/// <summary>Вычисляет сумму двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит сумму двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002526 RID: 9510 RVA: 0x000A7C10 File Offset: 0x000A5E10
		public static SqlMoney operator +(SqlMoney x, SqlMoney y)
		{
			SqlMoney result;
			try
			{
				result = ((x.IsNull || y.IsNull) ? SqlMoney.Null : new SqlMoney(checked(x._value + y._value), 0));
			}
			catch (OverflowException)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return result;
		}

		/// <summary>Оператор вычитания вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, содержащая результаты вычитания.</returns>
		// Token: 0x06002527 RID: 9511 RVA: 0x000A7C6C File Offset: 0x000A5E6C
		public static SqlMoney operator -(SqlMoney x, SqlMoney y)
		{
			SqlMoney result;
			try
			{
				result = ((x.IsNull || y.IsNull) ? SqlMoney.Null : new SqlMoney(checked(x._value - y._value), 0));
			}
			catch (OverflowException)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return result;
		}

		/// <summary>Оператор умножения вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит результат умножения.</returns>
		// Token: 0x06002528 RID: 9512 RVA: 0x000A7CC8 File Offset: 0x000A5EC8
		public static SqlMoney operator *(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlMoney(decimal.Multiply(x.ToDecimal(), y.ToDecimal()));
			}
			return SqlMoney.Null;
		}

		/// <summary>Оператор деления делит первый параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x06002529 RID: 9513 RVA: 0x000A7CFA File Offset: 0x000A5EFA
		public static SqlMoney operator /(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlMoney(decimal.Divide(x.ToDecimal(), y.ToDecimal()));
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x0600252A RID: 9514 RVA: 0x000A7D2C File Offset: 0x000A5F2C
		public static explicit operator SqlMoney(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney((int)x.ByteValue);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x0600252B RID: 9515 RVA: 0x000A7D49 File Offset: 0x000A5F49
		public static implicit operator SqlMoney(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney((int)x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600252C RID: 9516 RVA: 0x000A7D66 File Offset: 0x000A5F66
		public static implicit operator SqlMoney(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney((int)x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x0600252D RID: 9517 RVA: 0x000A7D83 File Offset: 0x000A5F83
		public static implicit operator SqlMoney(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney(x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот неявный оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x0600252E RID: 9518 RVA: 0x000A7DA0 File Offset: 0x000A5FA0
		public static implicit operator SqlMoney(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney(x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600252F RID: 9519 RVA: 0x000A7DBD File Offset: 0x000A5FBD
		public static explicit operator SqlMoney(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney((double)x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002530 RID: 9520 RVA: 0x000A7DDB File Offset: 0x000A5FDB
		public static explicit operator SqlMoney(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney(x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот оператор преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06002531 RID: 9521 RVA: 0x000A7DF8 File Offset: 0x000A5FF8
		public static explicit operator SqlMoney(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney(x.Value);
			}
			return SqlMoney.Null;
		}

		/// <summary>Этот оператор преобразует параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Преобразуемый объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, свойство <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06002532 RID: 9522 RVA: 0x000A7E15 File Offset: 0x000A6015
		public static explicit operator SqlMoney(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlMoney(decimal.Parse(x.Value, NumberStyles.Currency, null));
			}
			return SqlMoney.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002533 RID: 9523 RVA: 0x000A7E3D File Offset: 0x000A603D
		public static SqlBoolean operator ==(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value == y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002534 RID: 9524 RVA: 0x000A7E6A File Offset: 0x000A606A
		public static SqlBoolean operator !=(SqlMoney x, SqlMoney y)
		{
			return !(x == y);
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002535 RID: 9525 RVA: 0x000A7E78 File Offset: 0x000A6078
		public static SqlBoolean operator <(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value < y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />, чтобы определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002536 RID: 9526 RVA: 0x000A7EA5 File Offset: 0x000A60A5
		public static SqlBoolean operator >(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value > y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002537 RID: 9527 RVA: 0x000A7ED2 File Offset: 0x000A60D2
		public static SqlBoolean operator <=(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value <= y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />, чтобы определить, равны ли они, или же первый параметр больше второго.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002538 RID: 9528 RVA: 0x000A7F02 File Offset: 0x000A6102
		public static SqlBoolean operator >=(SqlMoney x, SqlMoney y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value >= y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Вычисляет сумму двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит сумму двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002539 RID: 9529 RVA: 0x000A7F32 File Offset: 0x000A6132
		public static SqlMoney Add(SqlMoney x, SqlMoney y)
		{
			return x + y;
		}

		/// <summary>Оператор вычитания вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, содержащая результаты вычитания.</returns>
		// Token: 0x0600253A RID: 9530 RVA: 0x000A7F3B File Offset: 0x000A613B
		public static SqlMoney Subtract(SqlMoney x, SqlMoney y)
		{
			return x - y;
		}

		/// <summary>Оператор умножения вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит результат умножения.</returns>
		// Token: 0x0600253B RID: 9531 RVA: 0x000A7F44 File Offset: 0x000A6144
		public static SqlMoney Multiply(SqlMoney x, SqlMoney y)
		{
			return x * y;
		}

		/// <summary>Оператор деления делит первый параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x0600253C RID: 9532 RVA: 0x000A7F4D File Offset: 0x000A614D
		public static SqlMoney Divide(SqlMoney x, SqlMoney y)
		{
			return x / y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlMoney" /> будет иметь значение NULL.</returns>
		// Token: 0x0600253D RID: 9533 RVA: 0x000A7F56 File Offset: 0x000A6156
		public static SqlBoolean Equals(SqlMoney x, SqlMoney y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600253E RID: 9534 RVA: 0x000A7F5F File Offset: 0x000A615F
		public static SqlBoolean NotEquals(SqlMoney x, SqlMoney y)
		{
			return x != y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600253F RID: 9535 RVA: 0x000A7F68 File Offset: 0x000A6168
		public static SqlBoolean LessThan(SqlMoney x, SqlMoney y)
		{
			return x < y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />, чтобы определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002540 RID: 9536 RVA: 0x000A7F71 File Offset: 0x000A6171
		public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y)
		{
			return x > y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002541 RID: 9537 RVA: 0x000A7F7A File Offset: 0x000A617A
		public static SqlBoolean LessThanOrEqual(SqlMoney x, SqlMoney y)
		{
			return x <= y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlMoney" />, чтобы определить, равны ли они, или же первый параметр больше второго.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002542 RID: 9538 RVA: 0x000A7F83 File Offset: 0x000A6183
		public static SqlBoolean GreaterThanOrEqual(SqlMoney x, SqlMoney y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> равно нулю, значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />.</returns>
		// Token: 0x06002543 RID: 9539 RVA: 0x000A7F8C File Offset: 0x000A618C
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002544 RID: 9540 RVA: 0x000A7F99 File Offset: 0x000A6199
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002545 RID: 9541 RVA: 0x000A7FA6 File Offset: 0x000A61A6
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002546 RID: 9542 RVA: 0x000A7FB3 File Offset: 0x000A61B3
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002547 RID: 9543 RVA: 0x000A7FC0 File Offset: 0x000A61C0
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002548 RID: 9544 RVA: 0x000A7FCD File Offset: 0x000A61CD
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002549 RID: 9545 RVA: 0x000A7FDA File Offset: 0x000A61DA
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600254A RID: 9546 RVA: 0x000A7FE7 File Offset: 0x000A61E7
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />, значение которой является строкой, представляющей значение данной структуры <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600254B RID: 9547 RVA: 0x000A7FF4 File Offset: 0x000A61F4
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlMoney" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше данного объекта.  
		///
		///   Нуль 
		///   Этот экземпляр равен данному объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше данного объекта 
		/// -или- 
		/// Объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600254C RID: 9548 RVA: 0x000A8004 File Offset: 0x000A6204
		public int CompareTo(object value)
		{
			if (value is SqlMoney)
			{
				SqlMoney value2 = (SqlMoney)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlMoney));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlMoney" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlMoney" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlMoney" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше данного объекта.  
		///
		///   Нуль 
		///   Этот экземпляр равен данному объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше данного объекта 
		/// - или - 
		/// Объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600254D RID: 9549 RVA: 0x000A8040 File Offset: 0x000A6240
		public int CompareTo(SqlMoney value)
		{
			if (this.IsNull)
			{
				if (!value.IsNull)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (value.IsNull)
				{
					return 1;
				}
				if (this < value)
				{
					return -1;
				}
				if (this > value)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>Значение <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlMoney" /> и они равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600254E RID: 9550 RVA: 0x000A8098 File Offset: 0x000A6298
		public override bool Equals(object value)
		{
			if (!(value is SqlMoney))
			{
				return false;
			}
			SqlMoney y = (SqlMoney)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Получает хэш-код для этого экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600254F RID: 9551 RVA: 0x000A80ED File Offset: 0x000A62ED
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this._value.GetHashCode();
			}
			return 0;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Объект <see langword="XmlSchema" />.</returns>
		// Token: 0x06002550 RID: 9552 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x06002551 RID: 9553 RVA: 0x000A8104 File Offset: 0x000A6304
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._fNotNull = false;
				return;
			}
			SqlMoney sqlMoney = new SqlMoney(XmlConvert.ToDecimal(reader.ReadElementString()));
			this._fNotNull = sqlMoney._fNotNull;
			this._value = sqlMoney._value;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x06002552 RID: 9554 RVA: 0x000A8166 File Offset: 0x000A6366
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this.ToDecimal()));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002553 RID: 9555 RVA: 0x000A4EA7 File Offset: 0x000A30A7
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("decimal", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018C9 RID: 6345
		private bool _fNotNull;

		// Token: 0x040018CA RID: 6346
		private long _value;

		// Token: 0x040018CB RID: 6347
		internal static readonly int s_iMoneyScale = 4;

		// Token: 0x040018CC RID: 6348
		private static readonly long s_lTickBase = 10000L;

		// Token: 0x040018CD RID: 6349
		private static readonly double s_dTickBase = (double)SqlMoney.s_lTickBase;

		// Token: 0x040018CE RID: 6350
		private static readonly long s_minLong = long.MinValue / SqlMoney.s_lTickBase;

		// Token: 0x040018CF RID: 6351
		private static readonly long s_maxLong = long.MaxValue / SqlMoney.s_lTickBase;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру класса <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		// Token: 0x040018D0 RID: 6352
		public static readonly SqlMoney Null = new SqlMoney(true);

		/// <summary>Представляет нулевое значение, которое можно назначить свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> экземпляра класса <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		// Token: 0x040018D1 RID: 6353
		public static readonly SqlMoney Zero = new SqlMoney(0);

		/// <summary>Представляет минимальное значение, которое можно назначить свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> экземпляра класса <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		// Token: 0x040018D2 RID: 6354
		public static readonly SqlMoney MinValue = new SqlMoney(long.MinValue, 0);

		/// <summary>Представляет максимальное значение, которое можно назначить свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> экземпляра класса <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		// Token: 0x040018D3 RID: 6355
		public static readonly SqlMoney MaxValue = new SqlMoney(long.MaxValue, 0);
	}
}
