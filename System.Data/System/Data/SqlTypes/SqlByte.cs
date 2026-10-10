using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет 8-разрядное целое число без знака в диапазоне от 0 до 255, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000307 RID: 775
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlByte : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x060022A7 RID: 8871 RVA: 0x0009FB12 File Offset: 0x0009DD12
		private SqlByte(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> с использованием заданного байтового значения.</summary>
		/// <param name="value">Байтовое значение, сохраняемое в свойстве <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> новой структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		// Token: 0x060022A8 RID: 8872 RVA: 0x0009FB22 File Offset: 0x0009DD22
		public SqlByte(byte value)
		{
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Получает логическое значение, показывающее, имеет ли данная структура <see cref="T:System.Data.SqlTypes.SqlByte" /> значение NULL.</summary>
		/// <returns>Значение <see langword="true" />, если NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0009FB32 File Offset: 0x0009DD32
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlByte" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Значение структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0009FB3D File Offset: 0x0009DD3D
		public byte Value
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

		/// <summary>Преобразует предоставленное значение байта в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Значение байта, преобразуемое в <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно предоставленному параметру.</returns>
		// Token: 0x060022AB RID: 8875 RVA: 0x0009FB53 File Offset: 0x0009DD53
		public static implicit operator SqlByte(byte x)
		{
			return new SqlByte(x);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в байт.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, преобразуемая в байт.</param>
		/// <returns>Байт, значение которого равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022AC RID: 8876 RVA: 0x0009FB5B File Offset: 0x0009DD5B
		public static explicit operator byte(SqlByte x)
		{
			return x.Value;
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Строка, содержащая <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> типа <see cref="T:System.Data.SqlTypes.SqlByte" />. Если <see langword="Value" /> равно NULL, <see langword="String" /> будет пустой строкой.</returns>
		// Token: 0x060022AD RID: 8877 RVA: 0x0009FB64 File Offset: 0x0009DD64
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует представление <see cref="T:System.String" /> числа в эквивалентное ему 8-разрядное целое число без знака.</summary>
		/// <param name="s">Представление <see langword="String" />, которое необходимо проанализировать.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, содержащая 8-разрядное число, представленное параметром <see langword="String" />.</returns>
		// Token: 0x060022AE RID: 8878 RVA: 0x0009FB80 File Offset: 0x0009DD80
		public static SqlByte Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlByte.Null;
			}
			return new SqlByte(byte.Parse(s, null));
		}

		/// <summary>Оператор дополнения до единицы выполняет битовую операцию дополнения до единицы над своим операндом <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит дополнение до единицы параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022AF RID: 8879 RVA: 0x0009FBA1 File Offset: 0x0009DDA1
		public static SqlByte operator ~(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(~x.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Вычисляет сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, в свойстве <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержится сумма двух операндов.</returns>
		// Token: 0x060022B0 RID: 8880 RVA: 0x0009FBC0 File Offset: 0x0009DDC0
		public static SqlByte operator +(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			int num = (int)(x.m_value + y.m_value);
			if ((num & SqlByte.s_iBitNotByteMax) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlByte((byte)num);
		}

		/// <summary>Вычитает второй операнд <see cref="T:System.Data.SqlTypes.SqlByte" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты вычитания второго операнда <see cref="T:System.Data.SqlTypes.SqlByte" /> из первого.</returns>
		// Token: 0x060022B1 RID: 8881 RVA: 0x0009FC10 File Offset: 0x0009DE10
		public static SqlByte operator -(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			int num = (int)(x.m_value - y.m_value);
			if ((num & SqlByte.s_iBitNotByteMax) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlByte((byte)num);
		}

		/// <summary>Вычисляет произведение двух операндов <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит результат умножения.</returns>
		// Token: 0x060022B2 RID: 8882 RVA: 0x0009FC60 File Offset: 0x0009DE60
		public static SqlByte operator *(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			int num = (int)(x.m_value * y.m_value);
			if ((num & SqlByte.s_iBitNotByteMax) != 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlByte((byte)num);
		}

		/// <summary>Делит свой первый операнд <see cref="T:System.Data.SqlTypes.SqlByte" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x060022B3 RID: 8883 RVA: 0x0009FCAE File Offset: 0x0009DEAE
		public static SqlByte operator /(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			if (y.m_value != 0)
			{
				return new SqlByte(x.m_value / y.m_value);
			}
			throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
		}

		/// <summary>Вычисляет остаток от деления первого операнда <see cref="T:System.Data.SqlTypes.SqlByte" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит остаток.</returns>
		// Token: 0x060022B4 RID: 8884 RVA: 0x0009FCEE File Offset: 0x0009DEEE
		public static SqlByte operator %(SqlByte x, SqlByte y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlByte.Null;
			}
			if (y.m_value != 0)
			{
				return new SqlByte(x.m_value % y.m_value);
			}
			throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты битовой операции логического умножения.</returns>
		// Token: 0x060022B5 RID: 8885 RVA: 0x0009FD2E File Offset: 0x0009DF2E
		public static SqlByte operator &(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlByte(x.m_value & y.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Вычисляет результат битовой операции OR двух операндов <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты битовой операции логического сложения.</returns>
		// Token: 0x060022B6 RID: 8886 RVA: 0x0009FD5B File Offset: 0x0009DF5B
		public static SqlByte operator |(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlByte(x.m_value | y.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты битовой операции исключающего логического сложения.</returns>
		// Token: 0x060022B7 RID: 8887 RVA: 0x0009FD88 File Offset: 0x0009DF88
		public static SqlByte operator ^(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlByte(x.m_value ^ y.m_value);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" />, преобразуемый в <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> предоставленного параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x060022B8 RID: 8888 RVA: 0x0009FDB5 File Offset: 0x0009DFB5
		public static explicit operator SqlByte(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(x.ByteValue);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see langword="SqlMoney" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x060022B9 RID: 8889 RVA: 0x0009FDD2 File Offset: 0x0009DFD2
		public static explicit operator SqlByte(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(checked((byte)x.ToInt32()));
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x060022BA RID: 8890 RVA: 0x0009FDF0 File Offset: 0x0009DFF0
		public static explicit operator SqlByte(SqlInt16 x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255 || x.Value < 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060022BB RID: 8891 RVA: 0x0009FE4C File Offset: 0x0009E04C
		public static explicit operator SqlByte(SqlInt32 x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255 || x.Value < 0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see langword="SqlInt64" />.</returns>
		// Token: 0x060022BC RID: 8892 RVA: 0x0009FEA8 File Offset: 0x0009E0A8
		public static explicit operator SqlByte(SqlInt64 x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255L || x.Value < 0L)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x060022BD RID: 8893 RVA: 0x0009FF08 File Offset: 0x0009E108
		public static explicit operator SqlByte(SqlSingle x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255f || x.Value < 0f)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060022BE RID: 8894 RVA: 0x0009FF68 File Offset: 0x0009E168
		public static explicit operator SqlByte(SqlDouble x)
		{
			if (x.IsNull)
			{
				return SqlByte.Null;
			}
			if (x.Value > 255.0 || x.Value < 0.0)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (!x.IsNull)
			{
				return new SqlByte((byte)x.Value);
			}
			return SqlByte.Null;
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060022BF RID: 8895 RVA: 0x0009FFCF File Offset: 0x0009E1CF
		public static explicit operator SqlByte(SqlDecimal x)
		{
			return (SqlByte)((SqlInt32)x);
		}

		/// <summary>Преобразует предоставленное <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Экземпляр класса <see langword="SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно числовому значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060022C0 RID: 8896 RVA: 0x0009FFDC File Offset: 0x0009E1DC
		public static explicit operator SqlByte(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlByte(byte.Parse(x.Value, null));
			}
			return SqlByte.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022C1 RID: 8897 RVA: 0x0009FFFF File Offset: 0x0009E1FF
		public static SqlBoolean operator ==(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlByte" /> с целью проверить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022C2 RID: 8898 RVA: 0x000A002C File Offset: 0x0009E22C
		public static SqlBoolean operator !=(SqlByte x, SqlByte y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022C3 RID: 8899 RVA: 0x000A003A File Offset: 0x0009E23A
		public static SqlBoolean operator <(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022C4 RID: 8900 RVA: 0x000A0067 File Offset: 0x0009E267
		public static SqlBoolean operator >(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022C5 RID: 8901 RVA: 0x000A0094 File Offset: 0x0009E294
		public static SqlBoolean operator <=(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see langword="SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022C6 RID: 8902 RVA: 0x000A00C4 File Offset: 0x0009E2C4
		public static SqlBoolean operator >=(SqlByte x, SqlByte y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Оператор дополнения до единицы выполняет битовую операцию дополнения до единицы над своим операндом <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит дополнение до единицы параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022C7 RID: 8903 RVA: 0x000A00F4 File Offset: 0x0009E2F4
		public static SqlByte OnesComplement(SqlByte x)
		{
			return ~x;
		}

		/// <summary>Вычисляет сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see langword="Value" /> которой содержит результаты сложения.</returns>
		// Token: 0x060022C8 RID: 8904 RVA: 0x000A00FC File Offset: 0x0009E2FC
		public static SqlByte Add(SqlByte x, SqlByte y)
		{
			return x + y;
		}

		/// <summary>Вычитает второй операнд <see cref="T:System.Data.SqlTypes.SqlByte" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты вычитания второго операнда <see cref="T:System.Data.SqlTypes.SqlByte" /> из первого.</returns>
		// Token: 0x060022C9 RID: 8905 RVA: 0x000A0105 File Offset: 0x0009E305
		public static SqlByte Subtract(SqlByte x, SqlByte y)
		{
			return x - y;
		}

		/// <summary>Вычисляет произведение двух операндов <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит результат умножения.</returns>
		// Token: 0x060022CA RID: 8906 RVA: 0x000A010E File Offset: 0x0009E30E
		public static SqlByte Multiply(SqlByte x, SqlByte y)
		{
			return x * y;
		}

		/// <summary>Делит свой первый операнд <see cref="T:System.Data.SqlTypes.SqlByte" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, свойство <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x060022CB RID: 8907 RVA: 0x000A0117 File Offset: 0x0009E317
		public static SqlByte Divide(SqlByte x, SqlByte y)
		{
			return x / y;
		}

		/// <summary>Вычисляет остаток от деления первого операнда <see cref="T:System.Data.SqlTypes.SqlByte" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой содержит остаток.</returns>
		// Token: 0x060022CC RID: 8908 RVA: 0x000A0120 File Offset: 0x0009E320
		public static SqlByte Mod(SqlByte x, SqlByte y)
		{
			return x % y;
		}

		/// <summary>Делит одно значение <see cref="T:System.Data.SqlTypes.SqlByte" />на другое и возвращает остаток.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Остаток, получившийся при делении <paramref name="x" /> на <paramref name="y" />.</returns>
		// Token: 0x060022CD RID: 8909 RVA: 0x000A0120 File Offset: 0x0009E320
		public static SqlByte Modulus(SqlByte x, SqlByte y)
		{
			return x % y;
		}

		/// <summary>Выполняет битовую операцию логического умножения операндов <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты битовой операции логического умножения.</returns>
		// Token: 0x060022CE RID: 8910 RVA: 0x000A0129 File Offset: 0x0009E329
		public static SqlByte BitwiseAnd(SqlByte x, SqlByte y)
		{
			return x & y;
		}

		/// <summary>Вычисляет результат битовой операции OR двух операндов <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты битовой операции логического сложения.</returns>
		// Token: 0x060022CF RID: 8911 RVA: 0x000A0132 File Offset: 0x0009E332
		public static SqlByte BitwiseOr(SqlByte x, SqlByte y)
		{
			return x | y;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Результаты операции исключающего логического сложения.</returns>
		// Token: 0x060022D0 RID: 8912 RVA: 0x000A013B File Offset: 0x0009E33B
		public static SqlByte Xor(SqlByte x, SqlByte y)
		{
			return x ^ y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlByte" /> будет иметь значение NULL.</returns>
		// Token: 0x060022D1 RID: 8913 RVA: 0x000A0144 File Offset: 0x0009E344
		public static SqlBoolean Equals(SqlByte x, SqlByte y)
		{
			return x == y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlByte" /> с целью проверить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022D2 RID: 8914 RVA: 0x000A014D File Offset: 0x0009E34D
		public static SqlBoolean NotEquals(SqlByte x, SqlByte y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022D3 RID: 8915 RVA: 0x000A0156 File Offset: 0x0009E356
		public static SqlBoolean LessThan(SqlByte x, SqlByte y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022D4 RID: 8916 RVA: 0x000A015F File Offset: 0x0009E35F
		public static SqlBoolean GreaterThan(SqlByte x, SqlByte y)
		{
			return x > y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022D5 RID: 8917 RVA: 0x000A0168 File Offset: 0x0009E368
		public static SqlBoolean LessThanOrEqual(SqlByte x, SqlByte y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlByte" />, чтобы определить, превышает ли первая вторую или равна ли ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060022D6 RID: 8918 RVA: 0x000A0171 File Offset: 0x0009E371
		public static SqlBoolean GreaterThanOrEqual(SqlByte x, SqlByte y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x060022D7 RID: 8919 RVA: 0x000A017A File Offset: 0x0009E37A
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Структура <see langword="SqlDouble" />, имеющая то же значение, что и данная структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022D8 RID: 8920 RVA: 0x000A0187 File Offset: 0x0009E387
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Структура <see langword="SqlInt16" />, имеющая то же значение, что и данная структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022D9 RID: 8921 RVA: 0x000A0194 File Offset: 0x0009E394
		public SqlInt16 ToSqlInt16()
		{
			return this;
		}

		/// <summary>Преобразует <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Структура <see langword="SqlInt32" />, имеющая то же значение, что и данная структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022DA RID: 8922 RVA: 0x000A01A1 File Offset: 0x0009E3A1
		public SqlInt32 ToSqlInt32()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Структура <see langword="SqlInt64" />, <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022DB RID: 8923 RVA: 0x000A01AE File Offset: 0x0009E3AE
		public SqlInt64 ToSqlInt64()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Структура <see langword="SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022DC RID: 8924 RVA: 0x000A01BB File Offset: 0x0009E3BB
		public SqlMoney ToSqlMoney()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Структура <see langword="SqlDecimal" />, <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022DD RID: 8925 RVA: 0x000A01C8 File Offset: 0x0009E3C8
		public SqlDecimal ToSqlDecimal()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Структура <see langword="SqlSingle" />, имеющая то же <see cref="P:System.Data.SqlTypes.SqlSingle.Value" />, что и данная структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060022DE RID: 8926 RVA: 0x000A01D5 File Offset: 0x0009E3D5
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Преобразует этот экземпляр <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see langword="SqlString" />, содержащая строковое представление <see cref="T:System.Data.SqlTypes.SqlByte" /> структуры <see cref="P:System.Data.SqlTypes.SqlByte.Value" />.</returns>
		// Token: 0x060022DF RID: 8927 RVA: 0x000A01E2 File Offset: 0x0009E3E2
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр с предоставленным объектом <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
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
		/// Объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x060022E0 RID: 8928 RVA: 0x000A01F0 File Offset: 0x0009E3F0
		public int CompareTo(object value)
		{
			if (value is SqlByte)
			{
				SqlByte value2 = (SqlByte)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlByte));
		}

		/// <summary>Сравнивает данный экземпляр с предоставленным объектом <see cref="T:System.Data.SqlTypes.SqlByte" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Сравниваемый объект <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
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
		// Token: 0x060022E1 RID: 8929 RVA: 0x000A022C File Offset: 0x0009E42C
		public int CompareTo(SqlByte value)
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

		/// <summary>Сравнивает предоставленный параметр <see cref="T:System.Object" /> со свойством <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <param name="value">Выражение <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060022E2 RID: 8930 RVA: 0x000A0284 File Offset: 0x0009E484
		public override bool Equals(object value)
		{
			if (!(value is SqlByte))
			{
				return false;
			}
			SqlByte y = (SqlByte)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060022E3 RID: 8931 RVA: 0x000A02DC File Offset: 0x0009E4DC
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
		// Token: 0x060022E4 RID: 8932 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x060022E5 RID: 8933 RVA: 0x000A0304 File Offset: 0x0009E504
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToByte(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x060022E6 RID: 8934 RVA: 0x000A0354 File Offset: 0x0009E554
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
		// Token: 0x060022E7 RID: 8935 RVA: 0x000A038A File Offset: 0x0009E58A
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("unsignedByte", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x0400182D RID: 6189
		private bool m_fNotNull;

		// Token: 0x0400182E RID: 6190
		private byte m_value;

		// Token: 0x0400182F RID: 6191
		private static readonly int s_iBitNotByteMax = -256;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		// Token: 0x04001830 RID: 6192
		public static readonly SqlByte Null = new SqlByte(true);

		/// <summary>Представляет нулевое значение, которое можно присвоить свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		// Token: 0x04001831 RID: 6193
		public static readonly SqlByte Zero = new SqlByte(0);

		/// <summary>Константа, представляющая наименьшее возможное значение <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		// Token: 0x04001832 RID: 6194
		public static readonly SqlByte MinValue = new SqlByte(0);

		/// <summary>Константа, представляющая наибольшее возможное значение <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		// Token: 0x04001833 RID: 6195
		public static readonly SqlByte MaxValue = new SqlByte(byte.MaxValue);
	}
}
