using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет код GUID, сохраняемый в базе данных или извлекаемый из нее.</summary>
	// Token: 0x02000310 RID: 784
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlGuid : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002420 RID: 9248 RVA: 0x000A57FD File Offset: 0x000A39FD
		private SqlGuid(bool fNull)
		{
			this.m_value = null;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> с использованием предоставленного параметра в виде массива байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		// Token: 0x06002421 RID: 9249 RVA: 0x000A5806 File Offset: 0x000A3A06
		public SqlGuid(byte[] value)
		{
			if (value == null || value.Length != SqlGuid.s_sizeOfGuid)
			{
				throw new ArgumentException(SQLResource.InvalidArraySizeMessage);
			}
			this.m_value = new byte[SqlGuid.s_sizeOfGuid];
			value.CopyTo(this.m_value, 0);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x000A583D File Offset: 0x000A3A3D
		internal SqlGuid(byte[] value, bool ignored)
		{
			if (value == null || value.Length != SqlGuid.s_sizeOfGuid)
			{
				throw new ArgumentException(SQLResource.InvalidArraySizeMessage);
			}
			this.m_value = value;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> с использованием заданного параметра <see cref="T:System.String" />.</summary>
		/// <param name="s">Объект <see cref="T:System.String" />.</param>
		// Token: 0x06002423 RID: 9251 RVA: 0x000A5860 File Offset: 0x000A3A60
		public SqlGuid(string s)
		{
			this.m_value = new Guid(s).ToByteArray();
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> с использованием заданного параметра <see cref="T:System.Guid" />.</summary>
		/// <param name="g">
		///   <see cref="T:System.Guid" />
		/// </param>
		// Token: 0x06002424 RID: 9252 RVA: 0x000A5881 File Offset: 0x000A3A81
		public SqlGuid(Guid g)
		{
			this.m_value = g.ToByteArray();
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> с использованием заданных значений.</summary>
		/// <param name="a">Первые четыре байта структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="b">Следующие два байта структуры  <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="c">Следующие два байта структуры  <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="d">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="e">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="f">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="g">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="h">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="i">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="j">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="k">Следующий байт структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		// Token: 0x06002425 RID: 9253 RVA: 0x000A5890 File Offset: 0x000A3A90
		public SqlGuid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			this = new SqlGuid(new Guid(a, b, c, d, e, f, g, h, i, j, k));
		}

		/// <summary>Получает логическое значение, показывающее, имеет ли данная структура <see cref="T:System.Data.SqlTypes.SqlGuid" /> значение NULL.</summary>
		/// <returns>
		///   <see langword="true" /> если <see langword="null" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x000A58BB File Offset: 0x000A3ABB
		public bool IsNull
		{
			get
			{
				return this.m_value == null;
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Структура <see cref="T:System.Guid" />.</returns>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000A58C6 File Offset: 0x000A3AC6
		public Guid Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return new Guid(this.m_value);
			}
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Guid" /> в <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Guid" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlGuid" />, <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> которого равен параметру <see cref="T:System.Guid" />.</returns>
		// Token: 0x06002428 RID: 9256 RVA: 0x000A58E1 File Offset: 0x000A3AE1
		public static implicit operator SqlGuid(Guid x)
		{
			return new SqlGuid(x);
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlGuid" /> в <see cref="T:System.Guid" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Новая структура <see cref="T:System.Guid" />, равная <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x06002429 RID: 9257 RVA: 0x000A58E9 File Offset: 0x000A3AE9
		public static explicit operator Guid(SqlGuid x)
		{
			return x.Value;
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> в массив байтов.</summary>
		/// <returns>Массив байтов, представляющий <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x0600242A RID: 9258 RVA: 0x000A58F4 File Offset: 0x000A3AF4
		public byte[] ToByteArray()
		{
			byte[] array = new byte[SqlGuid.s_sizeOfGuid];
			this.m_value.CopyTo(array, 0);
			return array;
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Структура <see cref="T:System.String" />, содержащая строковое представление структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x0600242B RID: 9259 RVA: 0x000A591C File Offset: 0x000A3B1C
		public override string ToString()
		{
			if (this.IsNull)
			{
				return SQLResource.NullString;
			}
			Guid guid = new Guid(this.m_value);
			return guid.ToString();
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.String" /> в <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <param name="s">Представление <see langword="String" />, которое необходимо проанализировать.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlGuid" />, эквивалентное значению, которое содержится в заданном представлении <see cref="T:System.String" />.</returns>
		// Token: 0x0600242C RID: 9260 RVA: 0x000A5951 File Offset: 0x000A3B51
		public static SqlGuid Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlGuid.Null;
			}
			return new SqlGuid(s);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x000A596C File Offset: 0x000A3B6C
		private static EComparison Compare(SqlGuid x, SqlGuid y)
		{
			int i = 0;
			while (i < SqlGuid.s_sizeOfGuid)
			{
				byte b = x.m_value[SqlGuid.s_rgiGuidOrder[i]];
				byte b2 = y.m_value[SqlGuid.s_rgiGuidOrder[i]];
				if (b != b2)
				{
					if (b >= b2)
					{
						return EComparison.GT;
					}
					return EComparison.LT;
				}
				else
				{
					i++;
				}
			}
			return EComparison.EQ;
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />, <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> которой равно значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x0600242E RID: 9262 RVA: 0x000A59B4 File Offset: 0x000A3BB4
		public static explicit operator SqlGuid(SqlString x)
		{
			if (!x.IsNull)
			{
				return new SqlGuid(x.Value);
			}
			return SqlGuid.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlBinary" /> в <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <param name="x">Объект <see langword="SqlBinary" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlGuid" />, <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlBinary" />.</returns>
		// Token: 0x0600242F RID: 9263 RVA: 0x000A59D1 File Offset: 0x000A3BD1
		public static explicit operator SqlGuid(SqlBinary x)
		{
			if (!x.IsNull)
			{
				return new SqlGuid(x.Value);
			}
			return SqlGuid.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002430 RID: 9264 RVA: 0x000A59EE File Offset: 0x000A3BEE
		public static SqlBoolean operator ==(SqlGuid x, SqlGuid y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(SqlGuid.Compare(x, y) == EComparison.EQ);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlGuid" /> с целью определить, верно ли, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002431 RID: 9265 RVA: 0x000A5A17 File Offset: 0x000A3C17
		public static SqlBoolean operator !=(SqlGuid x, SqlGuid y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002432 RID: 9266 RVA: 0x000A5A25 File Offset: 0x000A3C25
		public static SqlBoolean operator <(SqlGuid x, SqlGuid y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(SqlGuid.Compare(x, y) == EComparison.LT);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002433 RID: 9267 RVA: 0x000A5A4E File Offset: 0x000A3C4E
		public static SqlBoolean operator >(SqlGuid x, SqlGuid y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(SqlGuid.Compare(x, y) == EComparison.GT);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002434 RID: 9268 RVA: 0x000A5A78 File Offset: 0x000A3C78
		public static SqlBoolean operator <=(SqlGuid x, SqlGuid y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = SqlGuid.Compare(x, y);
			return new SqlBoolean(ecomparison == EComparison.LT || ecomparison == EComparison.EQ);
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002435 RID: 9269 RVA: 0x000A5AB4 File Offset: 0x000A3CB4
		public static SqlBoolean operator >=(SqlGuid x, SqlGuid y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = SqlGuid.Compare(x, y);
			return new SqlBoolean(ecomparison == EComparison.GT || ecomparison == EComparison.EQ);
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlGuid" /> будет иметь значение NULL.</returns>
		// Token: 0x06002436 RID: 9270 RVA: 0x000A5AF1 File Offset: 0x000A3CF1
		public static SqlBoolean Equals(SqlGuid x, SqlGuid y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlGuid" /> с целью определить, верно ли, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002437 RID: 9271 RVA: 0x000A5AFA File Offset: 0x000A3CFA
		public static SqlBoolean NotEquals(SqlGuid x, SqlGuid y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002438 RID: 9272 RVA: 0x000A5B03 File Offset: 0x000A3D03
		public static SqlBoolean LessThan(SqlGuid x, SqlGuid y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002439 RID: 9273 RVA: 0x000A5B0C File Offset: 0x000A3D0C
		public static SqlBoolean GreaterThan(SqlGuid x, SqlGuid y)
		{
			return x > y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600243A RID: 9274 RVA: 0x000A5B15 File Offset: 0x000A3D15
		public static SqlBoolean LessThanOrEqual(SqlGuid x, SqlGuid y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600243B RID: 9275 RVA: 0x000A5B1E File Offset: 0x000A3D1E
		public static SqlBoolean GreaterThanOrEqual(SqlGuid x, SqlGuid y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />, содержащая строковое представление структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x0600243C RID: 9276 RVA: 0x000A5B27 File Offset: 0x000A3D27
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> в <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <returns>Структура <see langword="SqlBinary" />, содержащая байты структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x0600243D RID: 9277 RVA: 0x000A5B34 File Offset: 0x000A3D34
		public SqlBinary ToSqlBinary()
		{
			return (SqlBinary)this;
		}

		/// <summary>Сравнивает эту структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> с предоставленным объектом и возвращает сведения об их относительных значениях. Сравнивает не только последние 6 байтов, но последние 6 байтов считаются наиболее важными при выполнении сравнения.</summary>
		/// <param name="value">Выражение <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше, чем объект.  
		///
		///   Нуль 
		///   Этот экземпляр равен объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше, чем объект, 
		/// -или- 
		/// объект является пустой ссылкой (<see langword="Nothing" />).</returns>
		// Token: 0x0600243E RID: 9278 RVA: 0x000A5B44 File Offset: 0x000A3D44
		public int CompareTo(object value)
		{
			if (value is SqlGuid)
			{
				SqlGuid value2 = (SqlGuid)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlGuid));
		}

		/// <summary>Сравнивает данную структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlGuid" /> и возвращает сведения об их относительных значениях. Сравнивает не только последние 6 байтов, но последние 6 байтов считаются наиболее важными при выполнении сравнения.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlGuid" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше, чем объект.  
		///
		///   Нуль 
		///   Этот экземпляр равен объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше, чем объект, 
		/// - или - 
		/// объект является пустой ссылкой (<see langword="Nothing" />).</returns>
		// Token: 0x0600243F RID: 9279 RVA: 0x000A5B80 File Offset: 0x000A3D80
		public int CompareTo(SqlGuid value)
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

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlGuid" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002440 RID: 9280 RVA: 0x000A5BD8 File Offset: 0x000A3DD8
		public override bool Equals(object value)
		{
			if (!(value is SqlGuid))
			{
				return false;
			}
			SqlGuid y = (SqlGuid)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данной структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06002441 RID: 9281 RVA: 0x000A5C30 File Offset: 0x000A3E30
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
		// Token: 0x06002442 RID: 9282 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x06002443 RID: 9283 RVA: 0x000A5C5C File Offset: 0x000A3E5C
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_value = null;
				return;
			}
			this.m_value = new Guid(reader.ReadElementString()).ToByteArray();
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x06002444 RID: 9284 RVA: 0x000A5CAD File Offset: 0x000A3EAD
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(new Guid(this.m_value)));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002445 RID: 9285 RVA: 0x000A15D3 File Offset: 0x0009F7D3
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018AE RID: 6318
		private static readonly int s_sizeOfGuid = 16;

		// Token: 0x040018AF RID: 6319
		private static readonly int[] s_rgiGuidOrder = new int[]
		{
			10,
			11,
			12,
			13,
			14,
			15,
			8,
			9,
			6,
			7,
			4,
			5,
			0,
			1,
			2,
			3
		};

		// Token: 0x040018B0 RID: 6320
		private byte[] m_value;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		// Token: 0x040018B1 RID: 6321
		public static readonly SqlGuid Null = new SqlGuid(true);
	}
}
