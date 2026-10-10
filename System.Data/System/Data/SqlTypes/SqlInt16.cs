using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет 16-разрядное целое число со знаком, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000311 RID: 785
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlInt16 : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002447 RID: 9287 RVA: 0x000A5D13 File Offset: 0x000A3F13
		private SqlInt16(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> с использованием предоставленного параметра типа короткого целого.</summary>
		/// <param name="value">Короткое целое число.</param>
		// Token: 0x06002448 RID: 9288 RVA: 0x000A5D23 File Offset: 0x000A3F23
		public SqlInt16(short value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlInt16" /> значение null.</summary>
		/// <returns>Значение <see langword="true" />, если NULL. В противном случае — значение <see langword="false" />. Дополнительные сведения см. в разделе Handling Null Values.</returns>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000A5D33 File Offset: 0x000A3F33
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Получает значение этого экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Короткое целое число, представляющее значение этой структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000A5D3E File Offset: 0x000A3F3E
		public short Value
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

		/// <summary>Преобразует предоставленное короткое целое число в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Короткое целое число.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" /> со значением, равным заданному короткому целому числу.</returns>
		// Token: 0x0600244B RID: 9291 RVA: 0x000A5D54 File Offset: 0x000A3F54
		public static implicit operator SqlInt16(short x)
		{
			return new SqlInt16(x);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в короткое целое число.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Короткое целое число, значение которого является значением параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600244C RID: 9292 RVA: 0x000A5D5C File Offset: 0x000A3F5C
		public static explicit operator short(SqlInt16 x)
		{
			return x.Value;
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, представляющий <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> этого экземпляра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600244D RID: 9293 RVA: 0x000A5D65 File Offset: 0x000A3F65
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует представление <see cref="T:System.String" /> числа в эквивалентное ему 16-разрядное целое число со знаком.</summary>
		/// <param name="s">Представление <see langword="String" />, которое необходимо проанализировать.</param>
		/// <returns>16-разрядное целое число со знаком, эквивалентное значению указанной строки <see cref="T:System.String" />.</returns>
		// Token: 0x0600244E RID: 9294 RVA: 0x000A5D81 File Offset: 0x000A3F81
		public static SqlInt16 Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlInt16.Null;
			}
			return new SqlInt16(short.Parse(s, null));
		}

		/// <summary>Оператор "унарный минус" меняет знак <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> операнда <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, содержащая противоположное значение.</returns>
		// Token: 0x0600244F RID: 9295 RVA: 0x000A5DA2 File Offset: 0x000A3FA2
		public static SqlInt16 operator -(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(-x.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Оператор ~ выполняет битовую операцию дополнения до единицы над операндом <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит дополнение заданной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002450 RID: 9296 RVA: 0x000A5DC0 File Offset: 0x000A3FC0
		public static SqlInt16 operator ~(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(~x.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Вычисляет сумму двух операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит сумму двух операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002451 RID: 9297 RVA: 0x000A5DE0 File Offset: 0x000A3FE0
		public static SqlInt16 operator +(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			int num = (int)(x.m_value + y.m_value);
			if (((num >> 15 ^ num >> 16) & 1) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)num);
		}

		/// <summary>Вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты вычитания.</returns>
		// Token: 0x06002452 RID: 9298 RVA: 0x000A5E34 File Offset: 0x000A4034
		public static SqlInt16 operator -(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			int num = (int)(x.m_value - y.m_value);
			if (((num >> 15 ^ num >> 16) & 1) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)num);
		}

		/// <summary>Вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит произведение двух параметров.</returns>
		// Token: 0x06002453 RID: 9299 RVA: 0x000A5E88 File Offset: 0x000A4088
		public static SqlInt16 operator *(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			int num = (int)(x.m_value * y.m_value);
			int num2 = num & SqlInt16.s_MASKI2;
			if (num2 != 0 && num2 != SqlInt16.s_MASKI2)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)num);
		}

		/// <summary>Делит первый операнд <see cref="T:System.Data.SqlTypes.SqlInt16" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>
		///   <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x06002454 RID: 9300 RVA: 0x000A5EE0 File Offset: 0x000A40E0
		public static SqlInt16 operator /(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -32768 && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16(x.m_value / y.m_value);
		}

		/// <summary>Вычисляет остаток от деления первого операнда <see cref="T:System.Data.SqlTypes.SqlInt16" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит остаток.</returns>
		// Token: 0x06002455 RID: 9301 RVA: 0x000A5F4C File Offset: 0x000A414C
		public static SqlInt16 operator %(SqlInt16 x, SqlInt16 y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlInt16.Null;
			}
			if (y.m_value == 0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			if (x.m_value == -32768 && y.m_value == -1)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16(x.m_value % y.m_value);
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты битовой операции логического умножения.</returns>
		// Token: 0x06002456 RID: 9302 RVA: 0x000A5FB8 File Offset: 0x000A41B8
		public static SqlInt16 operator &(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt16(x.m_value & y.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Вычисляет результат битовой операции OR двух операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты битовой операции логического сложения.</returns>
		// Token: 0x06002457 RID: 9303 RVA: 0x000A5FE5 File Offset: 0x000A41E5
		public static SqlInt16 operator |(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt16((short)((ushort)x.m_value | (ushort)y.m_value));
			}
			return SqlInt16.Null;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты битовой операции исключающего логического сложения.</returns>
		// Token: 0x06002458 RID: 9304 RVA: 0x000A6014 File Offset: 0x000A4214
		public static SqlInt16 operator ^(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlInt16(x.m_value ^ y.m_value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06002459 RID: 9305 RVA: 0x000A6041 File Offset: 0x000A4241
		public static explicit operator SqlInt16(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16((short)x.ByteValue);
			}
			return SqlInt16.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x0600245A RID: 9306 RVA: 0x000A605E File Offset: 0x000A425E
		public static implicit operator SqlInt16(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16((short)x.Value);
			}
			return SqlInt16.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> предоставленного параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x0600245B RID: 9307 RVA: 0x000A607C File Offset: 0x000A427C
		public static explicit operator SqlInt16(SqlInt32 x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			int value = x.Value;
			if (value > 32767 || value < -32768)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x0600245C RID: 9308 RVA: 0x000A60C4 File Offset: 0x000A42C4
		public static explicit operator SqlInt16(SqlInt64 x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			long value = x.Value;
			if (value > 32767L || value < -32768L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600245D RID: 9309 RVA: 0x000A610C File Offset: 0x000A430C
		public static explicit operator SqlInt16(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			float value = x.Value;
			if (value < -32768f || value > 32767f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой равно целой части параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x0600245E RID: 9310 RVA: 0x000A6154 File Offset: 0x000A4354
		public static explicit operator SqlInt16(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlInt16.Null;
			}
			double value = x.Value;
			if (value < -32768.0 || value > 32767.0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlInt16((short)value);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600245F RID: 9311 RVA: 0x000A61A2 File Offset: 0x000A43A2
		public static explicit operator SqlInt16(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(checked((short)x.ToInt32()));
			}
			return SqlInt16.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06002460 RID: 9312 RVA: 0x000A61C0 File Offset: 0x000A43C0
		public static explicit operator SqlInt16(SqlDecimal x)
		{
			return (SqlInt16)((SqlInt32)x);
		}

		/// <summary>Преобразует предоставленный объект <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой равно значению, представленному параметром объекта <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x06002461 RID: 9313 RVA: 0x000A61CD File Offset: 0x000A43CD
		public static explicit operator SqlInt16(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlInt16(short.Parse(x.Value, null));
			}
			return SqlInt16.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002462 RID: 9314 RVA: 0x000A61F0 File Offset: 0x000A43F0
		public static SqlBoolean operator ==(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlInt16" /> с целью определить, отличаются ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002463 RID: 9315 RVA: 0x000A621D File Offset: 0x000A441D
		public static SqlBoolean operator !=(SqlInt16 x, SqlInt16 y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002464 RID: 9316 RVA: 0x000A622B File Offset: 0x000A442B
		public static SqlBoolean operator <(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002465 RID: 9317 RVA: 0x000A6258 File Offset: 0x000A4458
		public static SqlBoolean operator >(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, является ли первая меньше или равна второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002466 RID: 9318 RVA: 0x000A6285 File Offset: 0x000A4485
		public static SqlBoolean operator <=(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, превышает ли первая вторую или равна ли ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002467 RID: 9319 RVA: 0x000A62B5 File Offset: 0x000A44B5
		public static SqlBoolean operator >=(SqlInt16 x, SqlInt16 y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Оператор ~ выполняет битовую операцию дополнения до единицы над операндом <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит дополнение заданной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002468 RID: 9320 RVA: 0x000A62E5 File Offset: 0x000A44E5
		public static SqlInt16 OnesComplement(SqlInt16 x)
		{
			return ~x;
		}

		/// <summary>Вычисляет сумму двух операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит сумму двух операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002469 RID: 9321 RVA: 0x000A62ED File Offset: 0x000A44ED
		public static SqlInt16 Add(SqlInt16 x, SqlInt16 y)
		{
			return x + y;
		}

		/// <summary>Вычитает второй параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты вычитания.</returns>
		// Token: 0x0600246A RID: 9322 RVA: 0x000A62F6 File Offset: 0x000A44F6
		public static SqlInt16 Subtract(SqlInt16 x, SqlInt16 y)
		{
			return x - y;
		}

		/// <summary>Вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит произведение двух параметров.</returns>
		// Token: 0x0600246B RID: 9323 RVA: 0x000A62FF File Offset: 0x000A44FF
		public static SqlInt16 Multiply(SqlInt16 x, SqlInt16 y)
		{
			return x * y;
		}

		/// <summary>Делит первый операнд <see cref="T:System.Data.SqlTypes.SqlInt16" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>
		///   <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x0600246C RID: 9324 RVA: 0x000A6308 File Offset: 0x000A4508
		public static SqlInt16 Divide(SqlInt16 x, SqlInt16 y)
		{
			return x / y;
		}

		/// <summary>Вычисляет остаток от деления первого операнда <see cref="T:System.Data.SqlTypes.SqlInt16" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит остаток.</returns>
		// Token: 0x0600246D RID: 9325 RVA: 0x000A6311 File Offset: 0x000A4511
		public static SqlInt16 Mod(SqlInt16 x, SqlInt16 y)
		{
			return x % y;
		}

		/// <summary>Делит одно значение <see cref="T:System.Data.SqlTypes.SqlInt16" />на другое и возвращает остаток.</summary>
		/// <param name="x">Значение <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Значение <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Остаток, получившийся при делении <paramref name="x" /> на <paramref name="y" />.</returns>
		// Token: 0x0600246E RID: 9326 RVA: 0x000A6311 File Offset: 0x000A4511
		public static SqlInt16 Modulus(SqlInt16 x, SqlInt16 y)
		{
			return x % y;
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты битовой операции логического умножения.</returns>
		// Token: 0x0600246F RID: 9327 RVA: 0x000A631A File Offset: 0x000A451A
		public static SqlInt16 BitwiseAnd(SqlInt16 x, SqlInt16 y)
		{
			return x & y;
		}

		/// <summary>Вычисляет результат битовой операции OR двух операндов <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой содержит результаты битовой операции логического сложения.</returns>
		// Token: 0x06002470 RID: 9328 RVA: 0x000A6323 File Offset: 0x000A4523
		public static SqlInt16 BitwiseOr(SqlInt16 x, SqlInt16 y)
		{
			return x | y;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, содержащая результаты операции исключающего логического сложения.</returns>
		// Token: 0x06002471 RID: 9329 RVA: 0x000A632C File Offset: 0x000A452C
		public static SqlInt16 Xor(SqlInt16 x, SqlInt16 y)
		{
			return x ^ y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlInt16" /> будет иметь значение NULL.</returns>
		// Token: 0x06002472 RID: 9330 RVA: 0x000A6335 File Offset: 0x000A4535
		public static SqlBoolean Equals(SqlInt16 x, SqlInt16 y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlInt16" /> с целью определить, отличаются ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002473 RID: 9331 RVA: 0x000A633E File Offset: 0x000A453E
		public static SqlBoolean NotEquals(SqlInt16 x, SqlInt16 y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002474 RID: 9332 RVA: 0x000A6347 File Offset: 0x000A4547
		public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002475 RID: 9333 RVA: 0x000A6350 File Offset: 0x000A4550
		public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y)
		{
			return x > y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, является ли первая меньше или равна второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002476 RID: 9334 RVA: 0x000A6359 File Offset: 0x000A4559
		public static SqlBoolean LessThanOrEqual(SqlInt16 x, SqlInt16 y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />, чтобы определить, превышает ли первая вторую или равна ли ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002477 RID: 9335 RVA: 0x000A6362 File Offset: 0x000A4562
		public static SqlBoolean GreaterThanOrEqual(SqlInt16 x, SqlInt16 y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x06002478 RID: 9336 RVA: 0x000A636B File Offset: 0x000A456B
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />. Если значение <see cref="T:System.Data.SqlTypes.SqlInt16" /> меньше 0 или больше 255, происходит <see cref="T:System.OverflowException" />.</returns>
		// Token: 0x06002479 RID: 9337 RVA: 0x000A6378 File Offset: 0x000A4578
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see langword="Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600247A RID: 9338 RVA: 0x000A6385 File Offset: 0x000A4585
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, <see langword="Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600247B RID: 9339 RVA: 0x000A6392 File Offset: 0x000A4592
		public SqlInt32 ToSqlInt32()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, <see langword="Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600247C RID: 9340 RVA: 0x000A639F File Offset: 0x000A459F
		public SqlInt64 ToSqlInt64()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, <see langword="Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600247D RID: 9341 RVA: 0x000A63AC File Offset: 0x000A45AC
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, <see langword="Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600247E RID: 9342 RVA: 0x000A63B9 File Offset: 0x000A45B9
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see langword="Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600247F RID: 9343 RVA: 0x000A63C6 File Offset: 0x000A45C6
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.SqlTypes.SqlString" />, представляющий <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> этого экземпляра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002480 RID: 9344 RVA: 0x000A63D3 File Offset: 0x000A45D3
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt16" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
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
		/// объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x06002481 RID: 9345 RVA: 0x000A63E0 File Offset: 0x000A45E0
		public int CompareTo(object value)
		{
			if (value is SqlInt16)
			{
				SqlInt16 value2 = (SqlInt16)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlInt16));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlInt16" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlInt16" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlInt16" /> для сравнения.</param>
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
		// Token: 0x06002482 RID: 9346 RVA: 0x000A641C File Offset: 0x000A461C
		public int CompareTo(SqlInt16 value)
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

		/// <summary>Сравнивает заданный объект со свойством <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlInt16" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002483 RID: 9347 RVA: 0x000A6474 File Offset: 0x000A4674
		public override bool Equals(object value)
		{
			if (!(value is SqlInt16))
			{
				return false;
			}
			SqlInt16 y = (SqlInt16)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06002484 RID: 9348 RVA: 0x000A64CC File Offset: 0x000A46CC
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this.Value.GetHashCode();
			}
			return 0;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Схема XML, используемая платформой .NET Framework.</returns>
		// Token: 0x06002485 RID: 9349 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x06002486 RID: 9350 RVA: 0x000A64F4 File Offset: 0x000A46F4
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToInt16(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x06002487 RID: 9351 RVA: 0x000A6544 File Offset: 0x000A4744
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
		/// <returns>Значение <see cref="T:System.String" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002488 RID: 9352 RVA: 0x000A657A File Offset: 0x000A477A
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("short", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018B2 RID: 6322
		private bool m_fNotNull;

		// Token: 0x040018B3 RID: 6323
		private short m_value;

		// Token: 0x040018B4 RID: 6324
		private static readonly int s_MASKI2 = -32768;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		// Token: 0x040018B5 RID: 6325
		public static readonly SqlInt16 Null = new SqlInt16(true);

		/// <summary>Представляет нулевое значение, которое можно присвоить свойству <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		// Token: 0x040018B6 RID: 6326
		public static readonly SqlInt16 Zero = new SqlInt16(0);

		/// <summary>Константа, представляющая наименьшее возможное значение <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		// Token: 0x040018B7 RID: 6327
		public static readonly SqlInt16 MinValue = new SqlInt16(short.MinValue);

		/// <summary>Константа, представляющая наибольшее возможное значение <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		// Token: 0x040018B8 RID: 6328
		public static readonly SqlInt16 MaxValue = new SqlInt16(short.MaxValue);
	}
}
