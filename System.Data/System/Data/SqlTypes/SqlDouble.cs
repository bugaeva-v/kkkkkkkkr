using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет число с плавающей запятой в диапазоне от -1,79E + 308 до 1,79E + 308, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x0200030F RID: 783
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlDouble : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x060023E8 RID: 9192 RVA: 0x000A513F File Offset: 0x000A333F
		private SqlDouble(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_value = 0.0;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> с использованием предоставленного параметра типа double для настройки нового свойства <see cref="T:System.Data.SqlTypes.SqlDouble" /> структуры <see cref="P:System.Data.SqlTypes.SqlDouble.Value" />.</summary>
		/// <param name="value">Значение типа double для новой структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		// Token: 0x060023E9 RID: 9193 RVA: 0x000A5157 File Offset: 0x000A3357
		public SqlDouble(double value)
		{
			if (!double.IsFinite(value))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this.m_value = value;
			this.m_fNotNull = true;
		}

		/// <summary>Возвращает логическое значение, показывающее, имеет ли данный экземпляр <see cref="T:System.Data.SqlTypes.SqlDouble" /> значение NULL.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> равно NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000A517A File Offset: 0x000A337A
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Значение структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x000A5185 File Offset: 0x000A3385
		public double Value
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

		/// <summary>Преобразует предоставленное значение типа double в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Преобразуемое значение типа double.</param>
		/// <returns>Параметр типа <see cref="T:System.Data.SqlTypes.SqlDouble" /> с тем же значением, что и у заданного параметра типа double.</returns>
		// Token: 0x060023EC RID: 9196 RVA: 0x000A519B File Offset: 0x000A339B
		public static implicit operator SqlDouble(double x)
		{
			return new SqlDouble(x);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в тип double.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Эквивалент типа double для значения заданной структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060023ED RID: 9197 RVA: 0x000A51A3 File Offset: 0x000A33A3
		public static explicit operator double(SqlDouble x)
		{
			return x.Value;
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в строку.</summary>
		/// <returns>Строка, представляющая <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060023EE RID: 9198 RVA: 0x000A51AC File Offset: 0x000A33AC
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует представление <see cref="T:System.String" /> числа в его эквивалент в виде числа с плавающей запятой с удвоенной точностью.</summary>
		/// <param name="s">Представление <see langword="String" />, которое необходимо проанализировать.</param>
		/// <returns>Объект <see cref="T:System.Data.SqlTypes.SqlDouble" />, содержащий значение, представленное параметром типа <see langword="String" />.</returns>
		// Token: 0x060023EF RID: 9199 RVA: 0x000A51C8 File Offset: 0x000A33C8
		public static SqlDouble Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlDouble.Null;
			}
			return new SqlDouble(double.Parse(s, CultureInfo.InvariantCulture));
		}

		/// <summary>Возвращает инвертированное значение заданной структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, содержащая противоположное значение.</returns>
		// Token: 0x060023F0 RID: 9200 RVA: 0x000A51ED File Offset: 0x000A33ED
		public static SqlDouble operator -(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble(-x.m_value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Оператор сложения вычисляет сумму двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Сумма двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060023F1 RID: 9201 RVA: 0x000A520A File Offset: 0x000A340A
		public static SqlDouble operator +(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			double num = x.m_value + y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>Оператор вычитания вычитает второй операнд <see cref="T:System.Data.SqlTypes.SqlDouble" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Результаты операции вычитания.</returns>
		// Token: 0x060023F2 RID: 9202 RVA: 0x000A5249 File Offset: 0x000A3449
		public static SqlDouble operator -(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			double num = x.m_value - y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>Оператор умножения вычисляет произведение двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Произведение двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060023F3 RID: 9203 RVA: 0x000A5288 File Offset: 0x000A3488
		public static SqlDouble operator *(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			double num = x.m_value * y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>Оператор деления делит первый операнд <see cref="T:System.Data.SqlTypes.SqlDouble" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, содержащая результаты операции деления.</returns>
		// Token: 0x060023F4 RID: 9204 RVA: 0x000A52C8 File Offset: 0x000A34C8
		public static SqlDouble operator /(SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDouble.Null;
			}
			if (y.m_value == 0.0)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			double num = x.m_value / y.m_value;
			if (double.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlDouble(num);
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно 0 или 1 в зависимости от свойства <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />. Если значение <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равно <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023F5 RID: 9205 RVA: 0x000A532E File Offset: 0x000A352E
		public static explicit operator SqlDouble(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.ByteValue);
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />. Если значение <see cref="T:System.Data.SqlTypes.SqlByte" /> равно <see cref="F:System.Data.SqlTypes.SqlByte.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023F6 RID: 9206 RVA: 0x000A534C File Offset: 0x000A354C
		public static implicit operator SqlDouble(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />. Если значение <see cref="T:System.Data.SqlTypes.SqlInt16" /> равно <see cref="F:System.Data.SqlTypes.SqlInt16.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023F7 RID: 9207 RVA: 0x000A536A File Offset: 0x000A356A
		public static implicit operator SqlDouble(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />. Если значение <see cref="T:System.Data.SqlTypes.SqlInt32" /> равно <see cref="F:System.Data.SqlTypes.SqlInt32.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023F8 RID: 9208 RVA: 0x000A5388 File Offset: 0x000A3588
		public static implicit operator SqlDouble(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />. Если значение <see cref="T:System.Data.SqlTypes.SqlInt64" /> равно <see cref="F:System.Data.SqlTypes.SqlInt64.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023F9 RID: 9209 RVA: 0x000A53A6 File Offset: 0x000A35A6
		public static implicit operator SqlDouble(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />. Если значение <see cref="T:System.Data.SqlTypes.SqlSingle" /> равно <see cref="F:System.Data.SqlTypes.SqlSingle.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023FA RID: 9210 RVA: 0x000A53C4 File Offset: 0x000A35C4
		public static implicit operator SqlDouble(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble((double)x.Value);
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />. Если значение <see cref="T:System.Data.SqlTypes.SqlMoney" /> равно <see cref="F:System.Data.SqlTypes.SqlMoney.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023FB RID: 9211 RVA: 0x000A53E2 File Offset: 0x000A35E2
		public static implicit operator SqlDouble(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble(x.ToDouble());
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />. Если значение <see cref="T:System.Data.SqlTypes.SqlDecimal" /> равно <see cref="F:System.Data.SqlTypes.SqlDecimal.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023FC RID: 9212 RVA: 0x000A53FF File Offset: 0x000A35FF
		public static implicit operator SqlDouble(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlDouble(x.ToDouble());
			}
			return SqlDouble.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> которой равно значению числа, представленного объектом <see cref="T:System.Data.SqlTypes.SqlString" />. Если значение <see cref="T:System.Data.SqlTypes.SqlString" /> равно <see cref="F:System.Data.SqlTypes.SqlString.Null" />, структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x060023FD RID: 9213 RVA: 0x000A541C File Offset: 0x000A361C
		public static explicit operator SqlDouble(SqlString x)
		{
			if (x.IsNull)
			{
				return SqlDouble.Null;
			}
			return SqlDouble.Parse(x.Value);
		}

		/// <summary>Выполняет логическое сравнение двух экземпляров <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060023FE RID: 9214 RVA: 0x000A5439 File Offset: 0x000A3639
		public static SqlBoolean operator ==(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDouble" /> с целью проверить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023FF RID: 9215 RVA: 0x000A5466 File Offset: 0x000A3666
		public static SqlBoolean operator !=(SqlDouble x, SqlDouble y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002400 RID: 9216 RVA: 0x000A5474 File Offset: 0x000A3674
		public static SqlBoolean operator <(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002401 RID: 9217 RVA: 0x000A54A1 File Offset: 0x000A36A1
		public static SqlBoolean operator >(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002402 RID: 9218 RVA: 0x000A54CE File Offset: 0x000A36CE
		public static SqlBoolean operator <=(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002403 RID: 9219 RVA: 0x000A54FE File Offset: 0x000A36FE
		public static SqlBoolean operator >=(SqlDouble x, SqlDouble y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Оператор сложения вычисляет сумму двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Сумма двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002404 RID: 9220 RVA: 0x000A552E File Offset: 0x000A372E
		public static SqlDouble Add(SqlDouble x, SqlDouble y)
		{
			return x + y;
		}

		/// <summary>Оператор вычитания вычитает второй операнд <see cref="T:System.Data.SqlTypes.SqlDouble" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Результаты операции вычитания.</returns>
		// Token: 0x06002405 RID: 9221 RVA: 0x000A5537 File Offset: 0x000A3737
		public static SqlDouble Subtract(SqlDouble x, SqlDouble y)
		{
			return x - y;
		}

		/// <summary>Оператор умножения вычисляет произведение двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Произведение двух операндов <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002406 RID: 9222 RVA: 0x000A5540 File Offset: 0x000A3740
		public static SqlDouble Multiply(SqlDouble x, SqlDouble y)
		{
			return x * y;
		}

		/// <summary>Оператор деления делит первый операнд <see cref="T:System.Data.SqlTypes.SqlDouble" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, содержащая результаты операции деления.</returns>
		// Token: 0x06002407 RID: 9223 RVA: 0x000A5549 File Offset: 0x000A3749
		public static SqlDouble Divide(SqlDouble x, SqlDouble y)
		{
			return x / y;
		}

		/// <summary>Выполняет логическое сравнение двух экземпляров <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002408 RID: 9224 RVA: 0x000A5552 File Offset: 0x000A3752
		public static SqlBoolean Equals(SqlDouble x, SqlDouble y)
		{
			return x == y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDouble" /> с целью определить, верно ли, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002409 RID: 9225 RVA: 0x000A555B File Offset: 0x000A375B
		public static SqlBoolean NotEquals(SqlDouble x, SqlDouble y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600240A RID: 9226 RVA: 0x000A5564 File Offset: 0x000A3764
		public static SqlBoolean LessThan(SqlDouble x, SqlDouble y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600240B RID: 9227 RVA: 0x000A556D File Offset: 0x000A376D
		public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y)
		{
			return x > y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600240C RID: 9228 RVA: 0x000A5576 File Offset: 0x000A3776
		public static SqlBoolean LessThanOrEqual(SqlDouble x, SqlDouble y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600240D RID: 9229 RVA: 0x000A557F File Offset: 0x000A377F
		public static SqlBoolean GreaterThanOrEqual(SqlDouble x, SqlDouble y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>Структура <see langword="SqlBoolean" />, <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> которой будет равно <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если для структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /><see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> не равно нулю, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если <see cref="T:System.Data.SqlTypes.SqlDouble" /> равно нулю, и <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />, если структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> имеет значение <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
		// Token: 0x0600240E RID: 9230 RVA: 0x000A5588 File Offset: 0x000A3788
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see langword="SqlByte" />, <see langword="Value" /> которой равно <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x0600240F RID: 9231 RVA: 0x000A5595 File Offset: 0x000A3795
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, свойство <see langword="Value" /> которой равно целой части значения структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002410 RID: 9232 RVA: 0x000A55A2 File Offset: 0x000A37A2
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, свойство <see langword="Value" /> которой равно целой части значения структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002411 RID: 9233 RVA: 0x000A55AF File Offset: 0x000A37AF
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, свойство <see langword="Value" /> которой равно целой части значения структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002412 RID: 9234 RVA: 0x000A55BC File Offset: 0x000A37BC
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Новая структура <see langword="SqlMoney" />, <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> которой равно значению данной структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002413 RID: 9235 RVA: 0x000A55C9 File Offset: 0x000A37C9
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see langword="SqlDecimal" />, преобразованное значение которой равно округленному значению данной структуры <see langword="SqlDouble" />.</returns>
		// Token: 0x06002414 RID: 9236 RVA: 0x000A55D6 File Offset: 0x000A37D6
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see langword="SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002415 RID: 9237 RVA: 0x000A55E3 File Offset: 0x000A37E3
		public SqlSingle ToSqlSingle()
		{
			return (SqlSingle)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see langword="SqlString" />, представляющая <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002416 RID: 9238 RVA: 0x000A55F0 File Offset: 0x000A37F0
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlDouble" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Сравниваемый шаблон <see cref="T:System.Object" />.</param>
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
		// Token: 0x06002417 RID: 9239 RVA: 0x000A5600 File Offset: 0x000A3800
		public int CompareTo(object value)
		{
			if (value is SqlDouble)
			{
				SqlDouble value2 = (SqlDouble)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlDouble));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlDouble" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlDouble" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlDouble" /> для сравнения.</param>
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
		// Token: 0x06002418 RID: 9240 RVA: 0x000A563C File Offset: 0x000A383C
		public int CompareTo(SqlDouble value)
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

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002419 RID: 9241 RVA: 0x000A5694 File Offset: 0x000A3894
		public override bool Equals(object value)
		{
			if (!(value is SqlDouble))
			{
				return false;
			}
			SqlDouble y = (SqlDouble)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код для структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600241A RID: 9242 RVA: 0x000A56EC File Offset: 0x000A38EC
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
		// Token: 0x0600241B RID: 9243 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />.</param>
		// Token: 0x0600241C RID: 9244 RVA: 0x000A5714 File Offset: 0x000A3914
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = XmlConvert.ToDouble(reader.ReadElementString());
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />.</param>
		// Token: 0x0600241D RID: 9245 RVA: 0x000A5764 File Offset: 0x000A3964
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
		// Token: 0x0600241E RID: 9246 RVA: 0x000A579A File Offset: 0x000A399A
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("double", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018A8 RID: 6312
		private bool m_fNotNull;

		// Token: 0x040018A9 RID: 6313
		private double m_value;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		// Token: 0x040018AA RID: 6314
		public static readonly SqlDouble Null = new SqlDouble(true);

		/// <summary>Представляет нулевое значение, которое можно присвоить свойству <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		// Token: 0x040018AB RID: 6315
		public static readonly SqlDouble Zero = new SqlDouble(0.0);

		/// <summary>Константа, представляющая минимальное возможное значение структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		// Token: 0x040018AC RID: 6316
		public static readonly SqlDouble MinValue = new SqlDouble(double.MinValue);

		/// <summary>Константа, представляющая максимальное значение для структуры <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		// Token: 0x040018AD RID: 6317
		public static readonly SqlDouble MaxValue = new SqlDouble(double.MaxValue);
	}
}
