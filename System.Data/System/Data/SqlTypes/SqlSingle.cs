using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет число с плавающей запятой в диапазоне от -3,40E +38 до 3,40E +38, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000315 RID: 789
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlSingle : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002555 RID: 9557 RVA: 0x000A822B File Offset: 0x000A642B
		private SqlSingle(bool fNull)
		{
			this._fNotNull = false;
			this._value = 0f;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="value">Число с плавающей десятичной запятой, которое будет использоваться в качестве <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> новой структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		// Token: 0x06002556 RID: 9558 RVA: 0x000A823F File Offset: 0x000A643F
		public SqlSingle(float value)
		{
			if (!float.IsFinite(value))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this._fNotNull = true;
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> с использованием предоставленного параметра типа double.</summary>
		/// <param name="value">Значение типа double, которое будет использоваться в качестве <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> новой структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		// Token: 0x06002557 RID: 9559 RVA: 0x000A8262 File Offset: 0x000A6462
		public SqlSingle(double value)
		{
			this = new SqlSingle((float)value);
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlSingle" /> значение null.</summary>
		/// <returns>Значение <see langword="true" />, если NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000A826C File Offset: 0x000A646C
		public bool IsNull
		{
			get
			{
				return !this._fNotNull;
			}
		}

		/// <summary>Получает значение этой структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Значение с плавающей десятичной запятой в диапазоне от -3,40E+38 до 3,40E+38.</returns>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000A8277 File Offset: 0x000A6477
		public float Value
		{
			get
			{
				if (this._fNotNull)
				{
					return this._value;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Преобразует заданное значение с плавающей десятичной запятой в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Значение с плавающей десятичной запятой, преобразуемое в структуру <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая значение заданного числа с плавающей запятой.</returns>
		// Token: 0x0600255A RID: 9562 RVA: 0x000A828D File Offset: 0x000A648D
		public static implicit operator SqlSingle(float x)
		{
			return new SqlSingle(x);
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в число с плавающей запятой.</summary>
		/// <param name="x">Значение <see cref="T:System.Data.SqlTypes.SqlSingle" />, преобразуемое в число с плавающей запятой.</param>
		/// <returns>Число с плавающей запятой, содержащее значение структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600255B RID: 9563 RVA: 0x000A8295 File Offset: 0x000A6495
		public static explicit operator float(SqlSingle x)
		{
			return x.Value;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see langword="String" />, представляющий значение данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600255C RID: 9564 RVA: 0x000A829E File Offset: 0x000A649E
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this._value.ToString(null);
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.String" /> в структуру <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="s">Представление <see cref="T:System.String" />, которое необходимо проанализировать.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlSingle" />, эквивалентное значению, которое содержится в заданном представлении <see cref="T:System.String" />.</returns>
		// Token: 0x0600255D RID: 9565 RVA: 0x000A82BA File Offset: 0x000A64BA
		public static SqlSingle Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlSingle.Null;
			}
			return new SqlSingle(float.Parse(s, CultureInfo.InvariantCulture));
		}

		/// <summary>Инвертирует <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> заданной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая противоположное значение.</returns>
		// Token: 0x0600255E RID: 9566 RVA: 0x000A82DF File Offset: 0x000A64DF
		public static SqlSingle operator -(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(-x._value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Вычисляет сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600255F RID: 9567 RVA: 0x000A82FC File Offset: 0x000A64FC
		public static SqlSingle operator +(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			float num = x._value + y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Вычитает вторую структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> из первой.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая результаты вычитания.</returns>
		// Token: 0x06002560 RID: 9568 RVA: 0x000A833B File Offset: 0x000A653B
		public static SqlSingle operator -(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			float num = x._value - y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Вычисляет произведение двух заданных структур <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая результат умножения.</returns>
		// Token: 0x06002561 RID: 9569 RVA: 0x000A837A File Offset: 0x000A657A
		public static SqlSingle operator *(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			float num = x._value * y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Делит первую структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> на вторую.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая результаты деления.</returns>
		// Token: 0x06002562 RID: 9570 RVA: 0x000A83BC File Offset: 0x000A65BC
		public static SqlSingle operator /(SqlSingle x, SqlSingle y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlSingle.Null;
			}
			if (y._value == 0f)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			float num = x._value / y._value;
			if (float.IsInfinity(num))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			return new SqlSingle(num);
		}

		/// <summary>Этот неявный оператор преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06002563 RID: 9571 RVA: 0x000A841E File Offset: 0x000A661E
		public static explicit operator SqlSingle(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.ByteValue);
			}
			return SqlSingle.Null;
		}

		/// <summary>Этот неявный оператор преобразует параметр <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, свойство <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x06002564 RID: 9572 RVA: 0x000A843C File Offset: 0x000A663C
		public static implicit operator SqlSingle(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002565 RID: 9573 RVA: 0x000A845A File Offset: 0x000A665A
		public static implicit operator SqlSingle(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06002566 RID: 9574 RVA: 0x000A8478 File Offset: 0x000A6678
		public static implicit operator SqlSingle(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002567 RID: 9575 RVA: 0x000A8496 File Offset: 0x000A6696
		public static implicit operator SqlSingle(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle((float)x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002568 RID: 9576 RVA: 0x000A84B4 File Offset: 0x000A66B4
		public static implicit operator SqlSingle(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(x.ToDouble());
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06002569 RID: 9577 RVA: 0x000A84D1 File Offset: 0x000A66D1
		public static implicit operator SqlSingle(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(x.ToDouble());
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемый параметр <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x0600256A RID: 9578 RVA: 0x000A84EE File Offset: 0x000A66EE
		public static explicit operator SqlSingle(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlSingle(x.Value);
			}
			return SqlSingle.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Преобразуемый объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> которой равен значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x0600256B RID: 9579 RVA: 0x000A850B File Offset: 0x000A670B
		public static explicit operator SqlSingle(SqlString x)
		{
			if (x.IsNull)
			{
				return SqlSingle.Null;
			}
			return SqlSingle.Parse(x.Value);
		}

		/// <summary>Выполняет логическое сравнение двух параметров SqlSingle с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600256C RID: 9580 RVA: 0x000A8528 File Offset: 0x000A6728
		public static SqlBoolean operator ==(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value == y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600256D RID: 9581 RVA: 0x000A8555 File Offset: 0x000A6755
		public static SqlBoolean operator !=(SqlSingle x, SqlSingle y)
		{
			return !(x == y);
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600256E RID: 9582 RVA: 0x000A8563 File Offset: 0x000A6763
		public static SqlBoolean operator <(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value < y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600256F RID: 9583 RVA: 0x000A8590 File Offset: 0x000A6790
		public static SqlBoolean operator >(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value > y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002570 RID: 9584 RVA: 0x000A85BD File Offset: 0x000A67BD
		public static SqlBoolean operator <=(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value <= y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, верно ли, что первая больше второй или равна ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002571 RID: 9585 RVA: 0x000A85ED File Offset: 0x000A67ED
		public static SqlBoolean operator >=(SqlSingle x, SqlSingle y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x._value >= y._value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Вычисляет сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая сумму двух заданных структур <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002572 RID: 9586 RVA: 0x000A861D File Offset: 0x000A681D
		public static SqlSingle Add(SqlSingle x, SqlSingle y)
		{
			return x + y;
		}

		/// <summary>Вычитает вторую структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> из первой.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая результаты вычитания.</returns>
		// Token: 0x06002573 RID: 9587 RVA: 0x000A8626 File Offset: 0x000A6826
		public static SqlSingle Subtract(SqlSingle x, SqlSingle y)
		{
			return x - y;
		}

		/// <summary>Вычисляет произведение двух заданных структур <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, содержащая результат умножения.</returns>
		// Token: 0x06002574 RID: 9588 RVA: 0x000A862F File Offset: 0x000A682F
		public static SqlSingle Multiply(SqlSingle x, SqlSingle y)
		{
			return x * y;
		}

		/// <summary>Делит первую структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> на вторую.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Структура <see langword="SqlInt64" />, содержащая результаты деления.</returns>
		// Token: 0x06002575 RID: 9589 RVA: 0x000A8638 File Offset: 0x000A6838
		public static SqlSingle Divide(SqlSingle x, SqlSingle y)
		{
			return x / y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlSingle" /> будет иметь значение NULL.</returns>
		// Token: 0x06002576 RID: 9590 RVA: 0x000A8641 File Offset: 0x000A6841
		public static SqlBoolean Equals(SqlSingle x, SqlSingle y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002577 RID: 9591 RVA: 0x000A864A File Offset: 0x000A684A
		public static SqlBoolean NotEquals(SqlSingle x, SqlSingle y)
		{
			return x != y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002578 RID: 9592 RVA: 0x000A8653 File Offset: 0x000A6853
		public static SqlBoolean LessThan(SqlSingle x, SqlSingle y)
		{
			return x < y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002579 RID: 9593 RVA: 0x000A865C File Offset: 0x000A685C
		public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y)
		{
			return x > y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600257A RID: 9594 RVA: 0x000A8665 File Offset: 0x000A6865
		public static SqlBoolean LessThanOrEqual(SqlSingle x, SqlSingle y)
		{
			return x <= y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlSingle" /> с целью определить, верно ли, что первая больше второй или равна ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600257B RID: 9595 RVA: 0x000A866E File Offset: 0x000A686E
		public static SqlBoolean GreaterThanOrEqual(SqlSingle x, SqlSingle y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x0600257C RID: 9596 RVA: 0x000A8677 File Offset: 0x000A6877
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see langword="Value" /> которой равно <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> равняется <see langword="true" />, значение <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> будет равняться 1. В противном случае значение <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> будет равняться 0.</returns>
		// Token: 0x0600257D RID: 9597 RVA: 0x000A8684 File Offset: 0x000A6884
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see langword="SqlDouble" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600257E RID: 9598 RVA: 0x000A8691 File Offset: 0x000A6891
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see langword="SqlInt16" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600257F RID: 9599 RVA: 0x000A869E File Offset: 0x000A689E
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002580 RID: 9600 RVA: 0x000A86AB File Offset: 0x000A68AB
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002581 RID: 9601 RVA: 0x000A86B8 File Offset: 0x000A68B8
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002582 RID: 9602 RVA: 0x000A86C5 File Offset: 0x000A68C5
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see langword="SqlDecimal" />, равная значению данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002583 RID: 9603 RVA: 0x000A86D2 File Offset: 0x000A68D2
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.SqlTypes.SqlString" />, представляющий значение данной структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002584 RID: 9604 RVA: 0x000A86DF File Offset: 0x000A68DF
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlSingle" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
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
		// Token: 0x06002585 RID: 9605 RVA: 0x000A86EC File Offset: 0x000A68EC
		public int CompareTo(object value)
		{
			if (value is SqlSingle)
			{
				SqlSingle value2 = (SqlSingle)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlSingle));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlSingle" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlSingle" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlSingle" /> для сравнения.</param>
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
		// Token: 0x06002586 RID: 9606 RVA: 0x000A8728 File Offset: 0x000A6928
		public int CompareTo(SqlSingle value)
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

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> и они равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002587 RID: 9607 RVA: 0x000A8780 File Offset: 0x000A6980
		public override bool Equals(object value)
		{
			if (!(value is SqlSingle))
			{
				return false;
			}
			SqlSingle y = (SqlSingle)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Получает хэш-код для этого экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06002588 RID: 9608 RVA: 0x000A87D8 File Offset: 0x000A69D8
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
		// Token: 0x06002589 RID: 9609 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x0600258A RID: 9610 RVA: 0x000A8800 File Offset: 0x000A6A00
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._fNotNull = false;
				return;
			}
			this._value = XmlConvert.ToSingle(reader.ReadElementString());
			this._fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x0600258B RID: 9611 RVA: 0x000A8850 File Offset: 0x000A6A50
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this._value));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x0600258C RID: 9612 RVA: 0x000A8886 File Offset: 0x000A6A86
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("float", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018D4 RID: 6356
		private bool _fNotNull;

		// Token: 0x040018D5 RID: 6357
		private float _value;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		// Token: 0x040018D6 RID: 6358
		public static readonly SqlSingle Null = new SqlSingle(true);

		/// <summary>Представляет нулевое значение, которое можно назначить свойству <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> экземпляра класса <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		// Token: 0x040018D7 RID: 6359
		public static readonly SqlSingle Zero = new SqlSingle(0f);

		/// <summary>Представляет минимальное значение, которое можно назначить свойству <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> экземпляра класса <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		// Token: 0x040018D8 RID: 6360
		public static readonly SqlSingle MinValue = new SqlSingle(float.MinValue);

		/// <summary>Представляет максимальное значение, которое можно назначить свойству <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> экземпляра класса <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		// Token: 0x040018D9 RID: 6361
		public static readonly SqlSingle MaxValue = new SqlSingle(float.MaxValue);
	}
}
