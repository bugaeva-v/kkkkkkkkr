using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет 32-разрядное целое число со знаком, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000312 RID: 786
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlInt32 : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x0600248A RID: 9354 RVA: 0x000A65CB File Offset: 0x000A47CB
		private SqlInt32(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0;
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> с использованием предоставленного целого значения.</summary>
		/// <param name="value">Преобразуемое целое число.</param>
		// Token: 0x0600248B RID: 9355 RVA: 0x000A65DB File Offset: 0x000A47DB
		public SqlInt32(int value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlInt32" /> значение null.</summary>
		/// <returns>Это свойство имеет значение <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> имеет значение NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000A65EB File Offset: 0x000A47EB
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Получает значение этой структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Целое число, представляющее значение этой структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Данное свойство содержит <see cref="F:System.Data.SqlTypes.SqlInt32.Null" />.</exception>
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x000A65F6 File Offset: 0x000A47F6
		public int Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this.m_value;
			}
		}

		/// <summary>Преобразует предоставленное целое число в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Целочисленное значение.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство Value которой равно целочисленному параметру.</returns>
		// Token: 0x0600248E RID: 9358 RVA: 0x000A660C File Offset: 0x000A480C
		public static implicit operator SqlInt32(int x)
		{
			return new SqlInt32(x);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в целое число.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Преобразованное целое значение.</returns>
		// Token: 0x0600248F RID: 9359 RVA: 0x000A6614 File Offset: 0x000A4814
		public static explicit operator int(SqlInt32 x)
		{
			return x.Value;
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Структура <see cref="T:System.String" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06002490 RID: 9360 RVA: 0x000A661D File Offset: 0x000A481D
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует представление <see cref="T:System.String" /> числа в эквивалентное ему 32-разрядное целое число со знаком.</summary>
		/// <param name="s">Представление <see cref="T:System.String" />, которое необходимо проанализировать.</param>
		/// <returns>Эквивалент 32-разрядного целого числа со знаком значению, содержащемуся в заданном <see cref="T:System.String" />.</returns>
		// Token: 0x06002491 RID: 9361 RVA: 0x000A6639 File Offset: 0x000A4839
		public static SqlInt32 Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlInt32.Null;
			}
			return new SqlInt32(int.Parse(s, null));
		}

		/// <summary>Отрицает <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> операнда <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая противоположное значение.</returns>
		// Token: 0x06002492 RID: 9362 RVA: 0x000A665A File Offset: 0x000A485A
		public static SqlInt32 operator -(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(-x.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Выполняет битовую операцию дополнения до единицы над заданной структурой <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты операции дополнения до единицы.</returns>
		// Token: 0x06002493 RID: 9363 RVA: 0x000A6677 File Offset: 0x000A4877
		public static SqlInt32 operator ~(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(~x.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Вычисляет сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит сумму заданных структур <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06002494 RID: 9364 RVA: 0x000A6694 File Offset: 0x000A4894
		public static SqlInt32 operator +(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			int num = x.m_value + y.m_value;
			if (SqlInt32.SameSignInt(x.m_value, y.m_value) && !SqlInt32.SameSignInt(x.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(num);
		}

		/// <summary>Вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит результаты вычитания.</returns>
		// Token: 0x06002495 RID: 9365 RVA: 0x000A66FC File Offset: 0x000A48FC
		public static SqlInt32 operator -(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			int num = x.m_value - y.m_value;
			if (!SqlInt32.SameSignInt(x.m_value, y.m_value) && SqlInt32.SameSignInt(y.m_value, num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(num);
		}

		/// <summary>Вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит произведение двух параметров.</returns>
		// Token: 0x06002496 RID: 9366 RVA: 0x000A6764 File Offset: 0x000A4964
		public static SqlInt32 operator *(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			long num = (long)x.m_value * (long)y.m_value;
			long num2 = num & SqlInt32.s_lBitNotIntMax;
			if (num2 != 0L && num2 != SqlInt32.s_lBitNotIntMax)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)num);
		}

		/// <summary>Делит первый параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>
		///   <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x06002497 RID: 9367 RVA: 0x000A67C0 File Offset: 0x000A49C0
		public static SqlInt32 operator /(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if ((long)x.m_value == SqlInt32.s_iIntMin && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(x.m_value / y.m_value);
		}

		/// <summary>Вычисляет остаток после деления первого параметра <see cref="T:System.Data.SqlTypes.SqlInt32" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит остаток.</returns>
		// Token: 0x06002498 RID: 9368 RVA: 0x000A682C File Offset: 0x000A4A2C
		public static SqlInt32 operator %(SqlInt32 x, SqlInt32 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt32.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if ((long)x.m_value == SqlInt32.s_iIntMin && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32(x.m_value % y.m_value);
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты поразрядной операции логического умножения.</returns>
		// Token: 0x06002499 RID: 9369 RVA: 0x000A6898 File Offset: 0x000A4A98
		public static SqlInt32 operator &(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt32(x.m_value & y.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Выполняет поразрядную операцию логического сложения заданных структур <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты поразрядной операции логического сложения.</returns>
		// Token: 0x0600249A RID: 9370 RVA: 0x000A68C4 File Offset: 0x000A4AC4
		public static SqlInt32 operator |(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt32(x.m_value | y.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с заданными структурами <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты битовой операции исключающего логического сложения.</returns>
		// Token: 0x0600249B RID: 9371 RVA: 0x000A68F0 File Offset: 0x000A4AF0
		public static SqlInt32 operator ^(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt32(x.m_value ^ y.m_value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x0600249C RID: 9372 RVA: 0x000A691C File Offset: 0x000A4B1C
		public static explicit operator SqlInt32(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32((int)x.ByteValue);
			}
			return SqlInt32.Null;
		}

		/// <summary>Преобразует предоставленное свойство <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x0600249D RID: 9373 RVA: 0x000A6939 File Offset: 0x000A4B39
		public static implicit operator SqlInt32(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32((int)x.Value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600249E RID: 9374 RVA: 0x000A6956 File Offset: 0x000A4B56
		public static implicit operator SqlInt32(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32((int)x.Value);
			}
			return SqlInt32.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see langword="SqlInt64" />.</returns>
		// Token: 0x0600249F RID: 9375 RVA: 0x000A6974 File Offset: 0x000A4B74
		public static explicit operator SqlInt32(SqlInt64 x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			long value = x.Value;
			if (value > 2147483647L || value < -2147483648L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)value);
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x060024A0 RID: 9376 RVA: 0x000A69BC File Offset: 0x000A4BBC
		public static explicit operator SqlInt32(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			float value = x.Value;
			if (value > 2.1474836E+09f || value < -2.1474836E+09f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)value);
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060024A1 RID: 9377 RVA: 0x000A6A04 File Offset: 0x000A4C04
		public static explicit operator SqlInt32(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			double value = x.Value;
			if (value > 2147483647.0 || value < -2147483648.0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt32((int)value);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x060024A2 RID: 9378 RVA: 0x000A6A52 File Offset: 0x000A4C52
		public static explicit operator SqlInt32(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(x.ToInt32());
			}
			return SqlInt32.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060024A3 RID: 9379 RVA: 0x000A6A70 File Offset: 0x000A4C70
		public static explicit operator SqlInt32(SqlDecimal x)
		{
			if (x.IsNull)
			{
				return SqlInt32.Null;
			}
			x.AdjustScale((int)(-(int)x.Scale), true);
			long num = (long)((ulong)x._data1);
			if (!x.IsPositive)
			{
				num = -num;
			}
			if (x._bLen > 1 || num > 2147483647L || num < -2147483648L)
			{
				throw new OverflowException(SQLResource.ConversionOverflowMessage);
			}
			return new SqlInt32((int)num);
		}

		/// <summary>Преобразует предоставленный объект <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой равно значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060024A4 RID: 9380 RVA: 0x000A6ADD File Offset: 0x000A4CDD
		public static explicit operator SqlInt32(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlInt32(int.Parse(x.Value, null));
			}
			return SqlInt32.Null;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x000A6B00 File Offset: 0x000A4D00
		private static bool SameSignInt(int x, int y)
		{
			return ((long)(x ^ y) & (long)((ulong)int.MinValue)) == 0L;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt32" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024A6 RID: 9382 RVA: 0x000A6B11 File Offset: 0x000A4D11
		public static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt32" /> с целью определить, отличаются ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024A7 RID: 9383 RVA: 0x000A6B3E File Offset: 0x000A4D3E
		public static SqlBoolean operator !=(SqlInt32 x, SqlInt32 y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024A8 RID: 9384 RVA: 0x000A6B4C File Offset: 0x000A4D4C
		public static SqlBoolean operator <(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый большим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024A9 RID: 9385 RVA: 0x000A6B79 File Offset: 0x000A4D79
		public static SqlBoolean operator >(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый меньшим, чем второй, или равным ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024AA RID: 9386 RVA: 0x000A6BA6 File Offset: 0x000A4DA6
		public static SqlBoolean operator <=(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый большим, чем второй, или равным ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024AB RID: 9387 RVA: 0x000A6BD6 File Offset: 0x000A4DD6
		public static SqlBoolean operator >=(SqlInt32 x, SqlInt32 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет битовую операцию дополнения до единицы над заданной структурой <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты операции дополнения до единицы.</returns>
		// Token: 0x060024AC RID: 9388 RVA: 0x000A6C06 File Offset: 0x000A4E06
		public static SqlInt32 OnesComplement(SqlInt32 x)
		{
			return ~x;
		}

		/// <summary>Вычисляет сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит сумму заданных структур <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024AD RID: 9389 RVA: 0x000A6C0E File Offset: 0x000A4E0E
		public static SqlInt32 Add(SqlInt32 x, SqlInt32 y)
		{
			return x + y;
		}

		/// <summary>Вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит результаты вычитания.</returns>
		// Token: 0x060024AE RID: 9390 RVA: 0x000A6C17 File Offset: 0x000A4E17
		public static SqlInt32 Subtract(SqlInt32 x, SqlInt32 y)
		{
			return x - y;
		}

		/// <summary>Вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит произведение двух параметров.</returns>
		// Token: 0x060024AF RID: 9391 RVA: 0x000A6C20 File Offset: 0x000A4E20
		public static SqlInt32 Multiply(SqlInt32 x, SqlInt32 y)
		{
			return x * y;
		}

		/// <summary>Делит первый параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>
		///   <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x060024B0 RID: 9392 RVA: 0x000A6C29 File Offset: 0x000A4E29
		public static SqlInt32 Divide(SqlInt32 x, SqlInt32 y)
		{
			return x / y;
		}

		/// <summary>Вычисляет остаток после деления первого параметра <see cref="T:System.Data.SqlTypes.SqlInt32" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> которой содержит остаток.</returns>
		// Token: 0x060024B1 RID: 9393 RVA: 0x000A6C32 File Offset: 0x000A4E32
		public static SqlInt32 Mod(SqlInt32 x, SqlInt32 y)
		{
			return x % y;
		}

		/// <summary>Делит одно значение <see cref="T:System.Data.SqlTypes.SqlInt32" />на другое и возвращает остаток.</summary>
		/// <param name="x">Значение <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Значение <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Остаток, получившийся при делении <paramref name="x" /> на <paramref name="y" />.</returns>
		// Token: 0x060024B2 RID: 9394 RVA: 0x000A6C32 File Offset: 0x000A4E32
		public static SqlInt32 Modulus(SqlInt32 x, SqlInt32 y)
		{
			return x % y;
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты поразрядной операции логического умножения.</returns>
		// Token: 0x060024B3 RID: 9395 RVA: 0x000A6C3B File Offset: 0x000A4E3B
		public static SqlInt32 BitwiseAnd(SqlInt32 x, SqlInt32 y)
		{
			return x & y;
		}

		/// <summary>Выполняет поразрядную операцию логического сложения заданных структур <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты поразрядной операции логического сложения.</returns>
		// Token: 0x060024B4 RID: 9396 RVA: 0x000A6C44 File Offset: 0x000A4E44
		public static SqlInt32 BitwiseOr(SqlInt32 x, SqlInt32 y)
		{
			return x | y;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с заданными структурами <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, содержащая результаты битовой операции исключающего логического сложения.</returns>
		// Token: 0x060024B5 RID: 9397 RVA: 0x000A6C4D File Offset: 0x000A4E4D
		public static SqlInt32 Xor(SqlInt32 x, SqlInt32 y)
		{
			return x ^ y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt32" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlInt32" /> будет иметь значение NULL.</returns>
		// Token: 0x060024B6 RID: 9398 RVA: 0x000A6C56 File Offset: 0x000A4E56
		public static SqlBoolean Equals(SqlInt32 x, SqlInt32 y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt32" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024B7 RID: 9399 RVA: 0x000A6C5F File Offset: 0x000A4E5F
		public static SqlBoolean NotEquals(SqlInt32 x, SqlInt32 y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024B8 RID: 9400 RVA: 0x000A6C68 File Offset: 0x000A4E68
		public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый большим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024B9 RID: 9401 RVA: 0x000A6C71 File Offset: 0x000A4E71
		public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y)
		{
			return x > y;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый меньшим, чем второй, или равным ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024BA RID: 9402 RVA: 0x000A6C7A File Offset: 0x000A4E7A
		public static SqlBoolean LessThanOrEqual(SqlInt32 x, SqlInt32 y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает два параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />, чтобы определить, является ли первый большим, чем второй, или равным ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060024BB RID: 9403 RVA: 0x000A6C83 File Offset: 0x000A4E83
		public static SqlBoolean GreaterThanOrEqual(SqlInt32 x, SqlInt32 y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x060024BC RID: 9404 RVA: 0x000A6C8C File Offset: 0x000A4E8C
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see langword="Value" /> которой равно <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />. Если значение <see langword="SqlInt32" /> меньше 0 или больше 255, происходит <see cref="T:System.OverflowException" />.</returns>
		// Token: 0x060024BD RID: 9405 RVA: 0x000A6C99 File Offset: 0x000A4E99
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024BE RID: 9406 RVA: 0x000A6CA6 File Offset: 0x000A4EA6
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024BF RID: 9407 RVA: 0x000A6CB3 File Offset: 0x000A4EB3
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024C0 RID: 9408 RVA: 0x000A6CC0 File Offset: 0x000A4EC0
		public SqlInt64 ToSqlInt64()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024C1 RID: 9409 RVA: 0x000A6CCD File Offset: 0x000A4ECD
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024C2 RID: 9410 RVA: 0x000A6CDA File Offset: 0x000A4EDA
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024C3 RID: 9411 RVA: 0x000A6CE7 File Offset: 0x000A4EE7
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlString" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060024C4 RID: 9412 RVA: 0x000A6CF4 File Offset: 0x000A4EF4
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt32" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
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
		/// - или - 
		/// Данный объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x060024C5 RID: 9413 RVA: 0x000A6D04 File Offset: 0x000A4F04
		public int CompareTo(object value)
		{
			if (value is SqlInt32)
			{
				SqlInt32 value2 = (SqlInt32)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlInt32));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt32" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlInt32" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlInt32" /> для сравнения.</param>
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
		// Token: 0x060024C6 RID: 9414 RVA: 0x000A6D40 File Offset: 0x000A4F40
		public int CompareTo(SqlInt32 value)
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

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlInt32" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060024C7 RID: 9415 RVA: 0x000A6D98 File Offset: 0x000A4F98
		public override bool Equals(object value)
		{
			if (!(value is SqlInt32))
			{
				return false;
			}
			SqlInt32 y = (SqlInt32)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060024C8 RID: 9416 RVA: 0x000A6DF0 File Offset: 0x000A4FF0
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
		// Token: 0x060024C9 RID: 9417 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x060024CA RID: 9418 RVA: 0x000A6E18 File Offset: 0x000A5018
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToInt32(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x060024CB RID: 9419 RVA: 0x000A6E68 File Offset: 0x000A5068
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
		// Token: 0x060024CC RID: 9420 RVA: 0x000A6E9E File Offset: 0x000A509E
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("int", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018B9 RID: 6329
		private bool m_fNotNull;

		// Token: 0x040018BA RID: 6330
		private int m_value;

		// Token: 0x040018BB RID: 6331
		private static readonly long s_iIntMin = -2147483648L;

		// Token: 0x040018BC RID: 6332
		private static readonly long s_lBitNotIntMax = -2147483648L;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру класса <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		// Token: 0x040018BD RID: 6333
		public static readonly SqlInt32 Null = new SqlInt32(true);

		/// <summary>Представляет нулевое значение, которое можно присвоить свойству <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		// Token: 0x040018BE RID: 6334
		public static readonly SqlInt32 Zero = new SqlInt32(0);

		/// <summary>Константа, представляющая наименьшее возможное значение <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		// Token: 0x040018BF RID: 6335
		public static readonly SqlInt32 MinValue = new SqlInt32(int.MinValue);

		/// <summary>Константа, представляющая наибольшее возможное значение <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		// Token: 0x040018C0 RID: 6336
		public static readonly SqlInt32 MaxValue = new SqlInt32(int.MaxValue);
	}
}
