using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет 64-разрядное целое число со знаком, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000313 RID: 787
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlInt64 : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x000A6F07 File Offset: 0x000A5107
		private SqlInt64(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0L;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> с использованием предоставленного длинного целого значения.</summary>
		/// <param name="value">Длинное целое число.</param>
		// Token: 0x060024CF RID: 9423 RVA: 0x000A6F18 File Offset: 0x000A5118
		public SqlInt64(long value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Получает логическое значение, показывающее, имеет ли данная структура <see cref="T:System.Data.SqlTypes.SqlInt64" /> значение NULL.</summary>
		/// <returns>Значение <see langword="true" />, если NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000A6F28 File Offset: 0x000A5128
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Получает значение этой структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Длинное целое число, представляющее значение данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x000A6F33 File Offset: 0x000A5133
		public long Value
		{
			get
			{
				if (this.m_fNotNull)
				{
					return this.m_value;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Преобразует параметр типа LONG в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Длинное целое значение.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно значению параметра типа LONG.</returns>
		// Token: 0x060024D2 RID: 9426 RVA: 0x000A6F49 File Offset: 0x000A5149
		public static implicit operator SqlInt64(long x)
		{
			return new SqlInt64(x);
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в значение типа LONG.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новое значение типа LONG, равное <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024D3 RID: 9427 RVA: 0x000A6F51 File Offset: 0x000A5151
		public static explicit operator long(SqlInt64 x)
		{
			return x.Value;
		}

		/// <summary>Преобразует этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, представляющий значение данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024D4 RID: 9428 RVA: 0x000A6F5A File Offset: 0x000A515A
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует представление <see cref="T:System.String" /> числа в эквивалентное ему 64-разрядное целое число со знаком.</summary>
		/// <param name="s">Представление <see cref="T:System.String" />, которое необходимо проанализировать.</param>
		/// <returns>Эквивалент 64-разрядного целого числа со знаком значению, содержащемуся в заданном <see cref="T:System.String" />.</returns>
		// Token: 0x060024D5 RID: 9429 RVA: 0x000A6F76 File Offset: 0x000A5176
		public static SqlInt64 Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlInt64.Null;
			}
			return new SqlInt64(long.Parse(s, null));
		}

		/// <summary>Оператор "унарный минус" меняет знак <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> операнда <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно инвертированному <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024D6 RID: 9430 RVA: 0x000A6F97 File Offset: 0x000A5197
		public static SqlInt64 operator -(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(-x.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Выполняет битовую операцию дополнения до единицы над своим операндом <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно дополнению до единицы параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024D7 RID: 9431 RVA: 0x000A6FB4 File Offset: 0x000A51B4
		public static SqlInt64 operator ~(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(~x.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Вычисляет сумму двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно сумме двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024D8 RID: 9432 RVA: 0x000A6FD4 File Offset: 0x000A51D4
		public static SqlInt64 operator +(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			long num = x.m_value + y.m_value;
			if (SqlInt64.SameSignLong(x.m_value, y.m_value) && !SqlInt64.SameSignLong(x.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(num);
		}

		/// <summary>Вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно результатам операции вычитания.</returns>
		// Token: 0x060024D9 RID: 9433 RVA: 0x000A703C File Offset: 0x000A523C
		public static SqlInt64 operator -(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			long num = x.m_value - y.m_value;
			if (!SqlInt64.SameSignLong(x.m_value, y.m_value) && SqlInt64.SameSignLong(y.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(num);
		}

		/// <summary>Вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно произведению двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024DA RID: 9434 RVA: 0x000A70A4 File Offset: 0x000A52A4
		public static SqlInt64 operator *(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			bool flag = false;
			long num = x.m_value;
			long num2 = y.m_value;
			long num3 = 0L;
			if (num < 0L)
			{
				flag = true;
				num = -num;
			}
			if (num2 < 0L)
			{
				flag = !flag;
				num2 = -num2;
			}
			long num4 = num & SqlInt64.s_lLowIntMask;
			long num5 = num >> 32 & SqlInt64.s_lLowIntMask;
			long num6 = num2 & SqlInt64.s_lLowIntMask;
			long num7 = num2 >> 32 & SqlInt64.s_lLowIntMask;
			if (num5 != 0L && num7 != 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			long num8 = num4 * num6;
			if (num8 < 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (num5 != 0L)
			{
				num3 = num5 * num6;
				if (num3 < 0L || num3 > 9223372036854775807L)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
			}
			else if (num7 != 0L)
			{
				num3 = num4 * num7;
				if (num3 < 0L || num3 > 9223372036854775807L)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
			}
			num8 += num3 << 32;
			if (num8 < 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (flag)
			{
				num8 = -num8;
			}
			return new SqlInt64(num8);
		}

		/// <summary>Делит первый параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой содержит результаты операции деления.</returns>
		// Token: 0x060024DB RID: 9435 RVA: 0x000A71C0 File Offset: 0x000A53C0
		public static SqlInt64 operator /(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			if (y.m_value == 0L)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -9223372036854775808L && y.m_value == -1L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(x.m_value / y.m_value);
		}

		/// <summary>Вычисляет остаток после деления первого параметра <see cref="T:System.Data.SqlTypes.SqlInt64" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой содержит остаток.</returns>
		// Token: 0x060024DC RID: 9436 RVA: 0x000A7230 File Offset: 0x000A5430
		public static SqlInt64 operator %(SqlInt64 x, SqlInt64 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt64.Null;
			}
			if (y.m_value == 0L)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -9223372036854775808L && y.m_value == -1L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64(x.m_value % y.m_value);
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, содержащая результаты поразрядной операции логического умножения.</returns>
		// Token: 0x060024DD RID: 9437 RVA: 0x000A72A0 File Offset: 0x000A54A0
		public static SqlInt64 operator &(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt64(x.m_value & y.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Вычисляет результат битовой операции OR двух операндов <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, содержащая результаты поразрядной операции логического сложения.</returns>
		// Token: 0x060024DE RID: 9438 RVA: 0x000A72CC File Offset: 0x000A54CC
		public static SqlInt64 operator |(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt64(x.m_value | y.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, содержащая результаты битовой операции исключающего логического сложения.</returns>
		// Token: 0x060024DF RID: 9439 RVA: 0x000A72F8 File Offset: 0x000A54F8
		public static SqlInt64 operator ^(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt64(x.m_value ^ y.m_value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x060024E0 RID: 9440 RVA: 0x000A7324 File Offset: 0x000A5524
		public static explicit operator SqlInt64(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)((ulong)x.ByteValue));
			}
			return SqlInt64.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060024E1 RID: 9441 RVA: 0x000A7342 File Offset: 0x000A5542
		public static implicit operator SqlInt64(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)((ulong)x.Value));
			}
			return SqlInt64.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x060024E2 RID: 9442 RVA: 0x000A7360 File Offset: 0x000A5560
		public static implicit operator SqlInt64(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)x.Value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024E3 RID: 9443 RVA: 0x000A737E File Offset: 0x000A557E
		public static implicit operator SqlInt64(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64((long)x.Value);
			}
			return SqlInt64.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой содержит целую часть параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x060024E4 RID: 9444 RVA: 0x000A739C File Offset: 0x000A559C
		public static explicit operator SqlInt64(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlInt64.Null;
			}
			float value = x.Value;
			if (value > 9.223372E+18f || value < -9.223372E+18f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64((long)value);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060024E5 RID: 9445 RVA: 0x000A73E4 File Offset: 0x000A55E4
		public static explicit operator SqlInt64(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlInt64.Null;
			}
			double value = x.Value;
			if (value > 9.223372036854776E+18 || value < -9.223372036854776E+18)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt64((long)value);
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x060024E6 RID: 9446 RVA: 0x000A7432 File Offset: 0x000A5632
		public static explicit operator SqlInt64(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(x.ToInt64());
			}
			return SqlInt64.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060024E7 RID: 9447 RVA: 0x000A7450 File Offset: 0x000A5650
		public static explicit operator SqlInt64(SqlDecimal x)
		{
			if (x.IsNull)
			{
				return SqlInt64.Null;
			}
			SqlDecimal sqlDecimal = x;
			sqlDecimal.AdjustScale((int)(-(int)sqlDecimal._bScale), false);
			if (sqlDecimal._bLen > 2)
			{
				throw new OverflowException(SQLResource.ConversionOverflowMessage);
			}
			long num2;
			if (sqlDecimal._bLen == 2)
			{
				ulong num = SqlDecimal.DWL(sqlDecimal._data1, sqlDecimal._data2);
				if (num > SqlDecimal.s_llMax && (sqlDecimal.IsPositive || num != 1UL + SqlDecimal.s_llMax))
				{
					throw new OverflowException(SQLResource.ConversionOverflowMessage);
				}
				num2 = (long)num;
			}
			else
			{
				num2 = (long)((ulong)sqlDecimal._data1);
			}
			if (!sqlDecimal.IsPositive)
			{
				num2 = -num2;
			}
			return new SqlInt64(num2);
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Преобразуемый объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060024E8 RID: 9448 RVA: 0x000A74F1 File Offset: 0x000A56F1
		public static explicit operator SqlInt64(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlInt64(long.Parse(x.Value, null));
			}
			return SqlInt64.Null;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000A7514 File Offset: 0x000A5714
		private static bool SameSignLong(long x, long y)
		{
			return ((x ^ y) & long.MinValue) == 0L;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024EA RID: 9450 RVA: 0x000A7527 File Offset: 0x000A5727
		public static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров SqlInt64 с целью определить, верно ли, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024EB RID: 9451 RVA: 0x000A7554 File Offset: 0x000A5754
		public static SqlBoolean operator !=(SqlInt64 x, SqlInt64 y)
		{
			return !(x == y);
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024EC RID: 9452 RVA: 0x000A7562 File Offset: 0x000A5762
		public static SqlBoolean operator <(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />, чтобы определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024ED RID: 9453 RVA: 0x000A758F File Offset: 0x000A578F
		public static SqlBoolean operator >(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024EE RID: 9454 RVA: 0x000A75BC File Offset: 0x000A57BC
		public static SqlBoolean operator <=(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />, чтобы определить, равны ли они, или же первый параметр больше второго.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024EF RID: 9455 RVA: 0x000A75EC File Offset: 0x000A57EC
		public static SqlBoolean operator >=(SqlInt64 x, SqlInt64 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет битовую операцию дополнения до единицы над своим операндом <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно дополнению до единицы параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024F0 RID: 9456 RVA: 0x000A761C File Offset: 0x000A581C
		public static SqlInt64 OnesComplement(SqlInt64 x)
		{
			return ~x;
		}

		/// <summary>Вычисляет сумму двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно сумме двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024F1 RID: 9457 RVA: 0x000A7624 File Offset: 0x000A5824
		public static SqlInt64 Add(SqlInt64 x, SqlInt64 y)
		{
			return x + y;
		}

		/// <summary>Вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно результатам операции вычитания.</returns>
		// Token: 0x060024F2 RID: 9458 RVA: 0x000A762D File Offset: 0x000A582D
		public static SqlInt64 Subtract(SqlInt64 x, SqlInt64 y)
		{
			return x - y;
		}

		/// <summary>Вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно произведению двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060024F3 RID: 9459 RVA: 0x000A7636 File Offset: 0x000A5836
		public static SqlInt64 Multiply(SqlInt64 x, SqlInt64 y)
		{
			return x * y;
		}

		/// <summary>Делит первый параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой содержит результаты операции деления.</returns>
		// Token: 0x060024F4 RID: 9460 RVA: 0x000A763F File Offset: 0x000A583F
		public static SqlInt64 Divide(SqlInt64 x, SqlInt64 y)
		{
			return x / y;
		}

		/// <summary>Вычисляет остаток после деления первого параметра <see cref="T:System.Data.SqlTypes.SqlInt64" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой содержит остаток.</returns>
		// Token: 0x060024F5 RID: 9461 RVA: 0x000A7648 File Offset: 0x000A5848
		public static SqlInt64 Mod(SqlInt64 x, SqlInt64 y)
		{
			return x % y;
		}

		/// <summary>Делит одно значение <see cref="T:System.Data.SqlTypes.SqlInt64" />на другое и возвращает остаток.</summary>
		/// <param name="x">Значение <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Значение <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Остаток, получившийся при делении <paramref name="x" /> на <paramref name="y" />.</returns>
		// Token: 0x060024F6 RID: 9462 RVA: 0x000A7648 File Offset: 0x000A5848
		public static SqlInt64 Modulus(SqlInt64 x, SqlInt64 y)
		{
			return x % y;
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, содержащая результаты поразрядной операции логического умножения.</returns>
		// Token: 0x060024F7 RID: 9463 RVA: 0x000A7651 File Offset: 0x000A5851
		public static SqlInt64 BitwiseAnd(SqlInt64 x, SqlInt64 y)
		{
			return x & y;
		}

		/// <summary>Вычисляет результат битовой операции OR двух операндов <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, содержащая результаты поразрядной операции логического сложения.</returns>
		// Token: 0x060024F8 RID: 9464 RVA: 0x000A765A File Offset: 0x000A585A
		public static SqlInt64 BitwiseOr(SqlInt64 x, SqlInt64 y)
		{
			return x | y;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, содержащая результаты битовой операции исключающего логического сложения.</returns>
		// Token: 0x060024F9 RID: 9465 RVA: 0x000A7663 File Offset: 0x000A5863
		public static SqlInt64 Xor(SqlInt64 x, SqlInt64 y)
		{
			return x ^ y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlInt64" /> будет иметь значение NULL.</returns>
		// Token: 0x060024FA RID: 9466 RVA: 0x000A766C File Offset: 0x000A586C
		public static SqlBoolean Equals(SqlInt64 x, SqlInt64 y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров SqlInt64 с целью определить, верно ли, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024FB RID: 9467 RVA: 0x000A7675 File Offset: 0x000A5875
		public static SqlBoolean NotEquals(SqlInt64 x, SqlInt64 y)
		{
			return x != y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024FC RID: 9468 RVA: 0x000A767E File Offset: 0x000A587E
		public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y)
		{
			return x < y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />, чтобы определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024FD RID: 9469 RVA: 0x000A7687 File Offset: 0x000A5887
		public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y)
		{
			return x > y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024FE RID: 9470 RVA: 0x000A7690 File Offset: 0x000A5890
		public static SqlBoolean LessThanOrEqual(SqlInt64 x, SqlInt64 y)
		{
			return x <= y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt64" />, чтобы определить, равны ли они, или же первый параметр больше второго.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024FF RID: 9471 RVA: 0x000A7699 File Offset: 0x000A5899
		public static SqlBoolean GreaterThanOrEqual(SqlInt64 x, SqlInt64 y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x06002500 RID: 9472 RVA: 0x000A76A2 File Offset: 0x000A58A2
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see langword="Value" /> которой равно <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002501 RID: 9473 RVA: 0x000A76AF File Offset: 0x000A58AF
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002502 RID: 9474 RVA: 0x000A76BC File Offset: 0x000A58BC
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002503 RID: 9475 RVA: 0x000A76C9 File Offset: 0x000A58C9
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002504 RID: 9476 RVA: 0x000A76D6 File Offset: 0x000A58D6
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002505 RID: 9477 RVA: 0x000A76E3 File Offset: 0x000A58E3
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002506 RID: 9478 RVA: 0x000A76F0 File Offset: 0x000A58F0
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002507 RID: 9479 RVA: 0x000A76FD File Offset: 0x000A58FD
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.SqlTypes.SqlString" />, представляющий значение данной структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002508 RID: 9480 RVA: 0x000A770A File Offset: 0x000A590A
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt64" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
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
		/// Данный объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x06002509 RID: 9481 RVA: 0x000A7718 File Offset: 0x000A5918
		public int CompareTo(object value)
		{
			if (value is SqlInt64)
			{
				SqlInt64 value2 = (SqlInt64)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlInt64));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt64" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlInt64" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlInt64" /> для сравнения.</param>
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
		/// Данный объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600250A RID: 9482 RVA: 0x000A7754 File Offset: 0x000A5954
		public int CompareTo(SqlInt64 value)
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

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlInt64" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600250B RID: 9483 RVA: 0x000A77AC File Offset: 0x000A59AC
		public override bool Equals(object value)
		{
			if (!(value is SqlInt64))
			{
				return false;
			}
			SqlInt64 y = (SqlInt64)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600250C RID: 9484 RVA: 0x000A7804 File Offset: 0x000A5A04
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this.Value.GetHashCode();
			}
			return 0;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Объект <see langword="XmlSchema" />.</returns>
		// Token: 0x0600250D RID: 9485 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x0600250E RID: 9486 RVA: 0x000A782C File Offset: 0x000A5A2C
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToInt64(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x0600250F RID: 9487 RVA: 0x000A787C File Offset: 0x000A5A7C
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this.m_value));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002510 RID: 9488 RVA: 0x000A78B2 File Offset: 0x000A5AB2
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("long", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018C1 RID: 6337
		private bool m_fNotNull;

		// Token: 0x040018C2 RID: 6338
		private long m_value;

		// Token: 0x040018C3 RID: 6339
		private static readonly long s_lLowIntMask = (long)((ulong)-1);

		// Token: 0x040018C4 RID: 6340
		private static readonly long s_lHighIntMask = -4294967296L;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		// Token: 0x040018C5 RID: 6341
		public static readonly SqlInt64 Null = new SqlInt64(true);

		/// <summary>Представляет нулевое значение, которое можно присвоить свойству <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		// Token: 0x040018C6 RID: 6342
		public static readonly SqlInt64 Zero = new SqlInt64(0L);

		/// <summary>Константа, представляющая наименьшее возможное значение структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		// Token: 0x040018C7 RID: 6343
		public static readonly SqlInt64 MinValue = new SqlInt64(long.MinValue);

		/// <summary>Константа, представляющая наибольшее возможное значение структуры <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		// Token: 0x040018C8 RID: 6344
		public static readonly SqlInt64 MaxValue = new SqlInt64(long.MaxValue);
	}
}
