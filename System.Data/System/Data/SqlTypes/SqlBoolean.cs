using System;
using System.Data.Common;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет целое значение 1 или 0, сохраняемое в базе данных или извлекаемое из нее.</summary>
	// Token: 0x02000306 RID: 774
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlBoolean : INullable, IComparable, IXmlSerializable
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> с использованием предоставленного логического значения.</summary>
		/// <param name="value">Значение для новой структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />; или <see langword="true" />, или <see langword="false" />.</param>
		// Token: 0x06002269 RID: 8809 RVA: 0x0009F3F9 File Offset: 0x0009D5F9
		public SqlBoolean(bool value)
		{
			this.m_value = (value ? 2 : 1);
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> с использованием заданного целого значения.</summary>
		/// <param name="value">Целое число, значение которого требуется использовать для новой структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		// Token: 0x0600226A RID: 8810 RVA: 0x0009F408 File Offset: 0x0009D608
		public SqlBoolean(int value)
		{
			this = new SqlBoolean(value, false);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0009F412 File Offset: 0x0009D612
		private SqlBoolean(int value, bool fNull)
		{
			if (fNull)
			{
				this.m_value = 0;
				return;
			}
			this.m_value = ((value != 0) ? 2 : 1);
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlBoolean" /> значение null.</summary>
		/// <returns>
		///   <see langword="true" /> Если <see cref="T:System.Data.SqlTypes.SqlBoolean" /> структура является null, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x0009F42C File Offset: 0x0009D62C
		public bool IsNull
		{
			get
			{
				return this.m_value == 0;
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.SqlTypes.SqlBoolean" /> имеет тип <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Для свойства задано значение NULL.</exception>
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x0009F438 File Offset: 0x0009D638
		public bool Value
		{
			get
			{
				byte value = this.m_value;
				if (value == 1)
				{
					return false;
				}
				if (value == 2)
				{
					return true;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Получает значение, указывающее имеет ли данный <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see langword="Value" /> имеет значение <see langword="true" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x0009F45D File Offset: 0x0009D65D
		public bool IsTrue
		{
			get
			{
				return this.m_value == 2;
			}
		}

		/// <summary>Показывает, задано ли для текущего свойства <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see langword="Value" /> имеет значение <see langword="False" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x0009F468 File Offset: 0x0009D668
		public bool IsFalse
		{
			get
			{
				return this.m_value == 1;
			}
		}

		/// <summary>Преобразует предоставленное значение байта в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Значение байта, преобразуемое в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlBoolean" />, содержащее 0 или 1.</returns>
		// Token: 0x06002270 RID: 8816 RVA: 0x0009F473 File Offset: 0x0009D673
		public static implicit operator SqlBoolean(bool x)
		{
			return new SqlBoolean(x);
		}

		/// <summary>Преобразует значение <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в логическое значение.</summary>
		/// <param name="x">Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которое требуется преобразовать.</param>
		/// <returns>Логическое значение, установленное для <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06002271 RID: 8817 RVA: 0x0009F47B File Offset: 0x0009D67B
		public static explicit operator bool(SqlBoolean x)
		{
			return x.Value;
		}

		/// <summary>Выполняет операцию логического отрицания со структурой <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, для которой будет выполняться операция логического отрицания.</param>
		/// <returns>
		///   <see cref="T:System.Data.SqlTypes.SqlBoolean" /> с <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /><see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если аргумент имел значение TRUE, <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />, если аргумент имел значение NULL; в противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</returns>
		// Token: 0x06002272 RID: 8818 RVA: 0x0009F484 File Offset: 0x0009D684
		public static SqlBoolean operator !(SqlBoolean x)
		{
			byte value = x.m_value;
			if (value == 1)
			{
				return SqlBoolean.True;
			}
			if (value == 2)
			{
				return SqlBoolean.False;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Оператор true может использоваться для проверки свойства <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> для структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, имеет ли оно значение TRUE.</summary>
		/// <param name="x">Проверяемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see langword="true" />, если предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" /> имеет значение <see langword="true" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002273 RID: 8819 RVA: 0x0009F4B1 File Offset: 0x0009D6B1
		public static bool operator true(SqlBoolean x)
		{
			return x.IsTrue;
		}

		/// <summary>Оператор false может использоваться для проверки свойства <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, имеет ли оно значение FALSE.</summary>
		/// <param name="x">Проверяемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see langword="true" />, если предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlBoolean" /> имеет значение <see langword="false" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002274 RID: 8820 RVA: 0x0009F4BA File Offset: 0x0009D6BA
		public static bool operator false(SqlBoolean x)
		{
			return x.IsFalse;
		}

		/// <summary>Вычисляет результат битовой операции логического умножения для двух указанных структур <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Результат операции логического умножения.</returns>
		// Token: 0x06002275 RID: 8821 RVA: 0x0009F4C3 File Offset: 0x0009D6C3
		public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y)
		{
			if (x.m_value == 1 || y.m_value == 1)
			{
				return SqlBoolean.False;
			}
			if (x.m_value == 2 && y.m_value == 2)
			{
				return SqlBoolean.True;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Вычисляет результат битовой операции логического сложения операндов.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Результаты операции логического сложения.</returns>
		// Token: 0x06002276 RID: 8822 RVA: 0x0009F4FA File Offset: 0x0009D6FA
		public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y)
		{
			if (x.m_value == 2 || y.m_value == 2)
			{
				return SqlBoolean.True;
			}
			if (x.m_value == 1 && y.m_value == 1)
			{
				return SqlBoolean.False;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в виде байта.</summary>
		/// <returns>Байт, представляющий значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x0009F531 File Offset: 0x0009D731
		public byte ByteValue
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				if (this.m_value != 2)
				{
					return 0;
				}
				return 1;
			}
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в строку.</summary>
		/// <returns>Строка, содержащая значение <see cref="T:System.Data.SqlTypes.SqlBoolean" />. Если данное значение равно NULL, строка будет содержать "NULL".</returns>
		// Token: 0x06002278 RID: 8824 RVA: 0x0009F550 File Offset: 0x0009D750
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.Value.ToString();
			}
			return SQLResource.NullString;
		}

		/// <summary>Преобразует заданное представление логического значения <see cref="T:System.String" /> в его эквивалент <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="s">Преобразуемая структура <see cref="T:System.String" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, содержащая анализируемое значение.</returns>
		// Token: 0x06002279 RID: 8825 RVA: 0x0009F57C File Offset: 0x0009D77C
		public static SqlBoolean Parse(string s)
		{
			if (s == null)
			{
				return new SqlBoolean(bool.Parse(s));
			}
			if (s == SQLResource.NullString)
			{
				return SqlBoolean.Null;
			}
			s = s.TrimStart();
			char c = s[0];
			if (char.IsNumber(c) || '-' == c || '+' == c)
			{
				return new SqlBoolean(int.Parse(s, null));
			}
			return new SqlBoolean(bool.Parse(s));
		}

		/// <summary>Выполняет операцию дополнения до единицы для предоставленных структур <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Дополнение до единицы предоставленной структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x0600227A RID: 8826 RVA: 0x0009F5E5 File Offset: 0x0009D7E5
		public static SqlBoolean operator ~(SqlBoolean x)
		{
			return !x;
		}

		/// <summary>Выполняет побитовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Результат операции исключающего логического сложения.</returns>
		// Token: 0x0600227B RID: 8827 RVA: 0x0009F5ED File Offset: 0x0009D7ED
		public static SqlBoolean operator ^(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value != y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlByte" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlByte" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, значение которой равно <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x0600227C RID: 8828 RVA: 0x0009F61D File Offset: 0x0009D81D
		public static explicit operator SqlBoolean(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value > 0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlInt16" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x0600227D RID: 8829 RVA: 0x0009F63D File Offset: 0x0009D83D
		public static explicit operator SqlBoolean(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlInt32" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x0600227E RID: 8830 RVA: 0x0009F65D File Offset: 0x0009D85D
		public static explicit operator SqlBoolean(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlInt64" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x0600227F RID: 8831 RVA: 0x0009F67D File Offset: 0x0009D87D
		public static explicit operator SqlBoolean(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0L);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlDouble" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlDouble" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x06002280 RID: 8832 RVA: 0x0009F69E File Offset: 0x0009D89E
		public static explicit operator SqlBoolean(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x.Value != 0.0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlSingle" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlSingle" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x06002281 RID: 8833 RVA: 0x0009F6C9 File Offset: 0x0009D8C9
		public static explicit operator SqlBoolean(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean((double)x.Value != 0.0);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlMoney" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x06002282 RID: 8834 RVA: 0x0009F6F5 File Offset: 0x0009D8F5
		public static explicit operator SqlBoolean(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return x != SqlMoney.Zero;
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x06002283 RID: 8835 RVA: 0x0009F711 File Offset: 0x0009D911
		public static explicit operator SqlBoolean(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlBoolean(x._data1 != 0U || x._data2 != 0U || x._data3 != 0U || x._data4 > 0U);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Параметр <see cref="T:System.Data.SqlTypes.SqlString" />, который требуется преобразовать в структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" />, у которой значение равно свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06002284 RID: 8836 RVA: 0x0009F74B File Offset: 0x0009D94B
		public static explicit operator SqlBoolean(SqlString x)
		{
			if (!x.IsNull)
			{
				return SqlBoolean.Parse(x.Value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает на равенство два экземпляра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002285 RID: 8837 RVA: 0x0009F768 File Offset: 0x0009D968
		public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value == y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlBoolean" /> с целью проверить, что они не равны.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002286 RID: 8838 RVA: 0x0009F795 File Offset: 0x0009D995
		public static SqlBoolean operator !=(SqlBoolean x, SqlBoolean y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002287 RID: 8839 RVA: 0x0009F7A3 File Offset: 0x0009D9A3
		public static SqlBoolean operator <(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value < y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, превышает ли первая вторую.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго, в противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</returns>
		// Token: 0x06002288 RID: 8840 RVA: 0x0009F7D0 File Offset: 0x0009D9D0
		public static SqlBoolean operator >(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value > y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше или равен второму экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002289 RID: 8841 RVA: 0x0009F7FD File Offset: 0x0009D9FD
		public static SqlBoolean operator <=(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value <= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, превышает ли первая вторую или равна ли ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше или равен второму экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600228A RID: 8842 RVA: 0x0009F82D File Offset: 0x0009DA2D
		public static SqlBoolean operator >=(SqlBoolean x, SqlBoolean y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_value >= y.m_value);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет операцию дополнения до единицы для предоставленных структур <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Дополнение до единицы предоставленной структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x0600228B RID: 8843 RVA: 0x0009F85D File Offset: 0x0009DA5D
		public static SqlBoolean OnesComplement(SqlBoolean x)
		{
			return ~x;
		}

		/// <summary>Вычисляет результат битовой операции логического умножения для двух указанных структур <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Результат операции логического умножения.</returns>
		// Token: 0x0600228C RID: 8844 RVA: 0x0009F865 File Offset: 0x0009DA65
		public static SqlBoolean And(SqlBoolean x, SqlBoolean y)
		{
			return x & y;
		}

		/// <summary>Выполняет битовую операцию ИЛИ с двумя указанными структурами <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, значение которой является результатом битовой операции логического сложения.</returns>
		// Token: 0x0600228D RID: 8845 RVA: 0x0009F86E File Offset: 0x0009DA6E
		public static SqlBoolean Or(SqlBoolean x, SqlBoolean y)
		{
			return x | y;
		}

		/// <summary>Выполняет битовую операцию исключающего логического сложения с предоставленными параметрами.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Результат операции исключающего логического сложения.</returns>
		// Token: 0x0600228E RID: 8846 RVA: 0x0009F877 File Offset: 0x0009DA77
		public static SqlBoolean Xor(SqlBoolean x, SqlBoolean y)
		{
			return x ^ y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, совпадают ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600228F RID: 8847 RVA: 0x0009F880 File Offset: 0x0009DA80
		public static SqlBoolean Equals(SqlBoolean x, SqlBoolean y)
		{
			return x == y;
		}

		/// <summary>Сравнивает на равенство два экземпляра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002290 RID: 8848 RVA: 0x0009F889 File Offset: 0x0009DA89
		public static SqlBoolean NotEquals(SqlBoolean x, SqlBoolean y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго, в противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</returns>
		// Token: 0x06002291 RID: 8849 RVA: 0x0009F892 File Offset: 0x0009DA92
		public static SqlBoolean GreaterThan(SqlBoolean x, SqlBoolean y)
		{
			return x > y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго, в противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</returns>
		// Token: 0x06002292 RID: 8850 RVA: 0x0009F89B File Offset: 0x0009DA9B
		public static SqlBoolean LessThan(SqlBoolean x, SqlBoolean y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше или равен второму экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002293 RID: 8851 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
		public static SqlBoolean GreaterThanOrEquals(SqlBoolean x, SqlBoolean y)
		{
			return x >= y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше или равен второму экземпляру; в противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</returns>
		// Token: 0x06002294 RID: 8852 RVA: 0x0009F8AD File Offset: 0x0009DAAD
		public static SqlBoolean LessThanOrEquals(SqlBoolean x, SqlBoolean y)
		{
			return x <= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlByte" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новая структура <see cref="T:System.Data.SqlTypes.SqlByte" /> имеет значение 1. В противном случае новое значение структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> — 0.</returns>
		// Token: 0x06002295 RID: 8853 RVA: 0x0009F8B6 File Offset: 0x0009DAB6
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> имеет значение 1. В противном случае новое значение структуры <see cref="T:System.Data.SqlTypes.SqlDouble" /> — 0.</returns>
		// Token: 0x06002296 RID: 8854 RVA: 0x0009F8C3 File Offset: 0x0009DAC3
		public SqlDouble ToSqlDouble()
		{
			return (SqlDouble)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see langword="SqlInt16" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" /> имеет значение 1. В противном случае новое значение структуры <see langword="SqlInt16" /> — 0.</returns>
		// Token: 0x06002297 RID: 8855 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see langword="SqlInt32" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" /> имеет значение 1. В противном случае новое значение структуры <see langword="SqlInt32" /> — 0.</returns>
		// Token: 0x06002298 RID: 8856 RVA: 0x0009F8DD File Offset: 0x0009DADD
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see langword="SqlInt64" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" /> имеет значение 1. В противном случае новое значение структуры <see langword="SqlInt64" /> — 0.</returns>
		// Token: 0x06002299 RID: 8857 RVA: 0x0009F8EA File Offset: 0x0009DAEA
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новое значение <see cref="T:System.Data.SqlTypes.SqlMoney" /> равняется 1. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="false" />, новое значение <see cref="T:System.Data.SqlTypes.SqlMoney" /> равняется 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> не равняется ни 1, ни 0, новое значение <see cref="T:System.Data.SqlTypes.SqlMoney" /> равняется <see cref="F:System.Data.SqlTypes.SqlMoney.Null" />.</returns>
		// Token: 0x0600229A RID: 8858 RVA: 0x0009F8F7 File Offset: 0x0009DAF7
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равняется <see langword="true" />, новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" /> имеет значение 1. В противном случае новое значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> — 0.</returns>
		// Token: 0x0600229B RID: 8859 RVA: 0x0009F904 File Offset: 0x0009DB04
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" /> со значением 1 или 0.  
		/// Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> равно TRUE, значение новой структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> равно 1; в противном случае значение новой структуры <see cref="T:System.Data.SqlTypes.SqlSingle" /> равно 0.</returns>
		// Token: 0x0600229C RID: 8860 RVA: 0x0009F911 File Offset: 0x0009DB11
		public SqlSingle ToSqlSingle()
		{
			return (SqlSingle)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlString" /> со значением 1 или 0. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> — <see langword="true" />, то значение структуры <see cref="T:System.Data.SqlTypes.SqlString" /> — 1. В противном случае новое значение структуры <see cref="T:System.Data.SqlTypes.SqlString" /> — 0.</returns>
		// Token: 0x0600229D RID: 8861 RVA: 0x0009F91E File Offset: 0x0009DB1E
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает данную структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> с заданным объектом и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Сравниваемый объект или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>Число со знаком, представляющее относительные значения экземпляра и значения.  
		///   Значение 
		///   Описание 
		///   Отрицательное целое число 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   Положительное целое число 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// - или - 
		///  Параметр <paramref name="value" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600229E RID: 8862 RVA: 0x0009F92C File Offset: 0x0009DB2C
		public int CompareTo(object value)
		{
			if (value is SqlBoolean)
			{
				SqlBoolean value2 = (SqlBoolean)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlBoolean));
		}

		/// <summary>Сравнивает этот объект <see cref="T:System.Data.SqlTypes.SqlBoolean" /> с предоставленным объектом <see cref="T:System.Data.SqlTypes.SqlBoolean" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Сравниваемый объект <see cref="T:System.Data.SqlTypes.SqlBoolean" /><see cref="T:System.Data.SqlTypes.SqlBoolean" /> или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>Число со знаком, представляющее относительные значения экземпляра и значения.  
		///   Значение 
		///   Описание: 
		///   Отрицательное целое число 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   Положительное целое число 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// -или- 
		///  Параметр <paramref name="value" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600229F RID: 8863 RVA: 0x0009F968 File Offset: 0x0009DB68
		public int CompareTo(SqlBoolean value)
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
				if (this.ByteValue < value.ByteValue)
				{
					return -1;
				}
				if (this.ByteValue > value.ByteValue)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Сравнивает параметр предоставленного объекта с <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060022A0 RID: 8864 RVA: 0x0009F9B8 File Offset: 0x0009DBB8
		public override bool Equals(object value)
		{
			if (!(value is SqlBoolean))
			{
				return false;
			}
			SqlBoolean y = (SqlBoolean)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060022A1 RID: 8865 RVA: 0x0009FA10 File Offset: 0x0009DC10
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
		// Token: 0x060022A2 RID: 8866 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x060022A3 RID: 8867 RVA: 0x0009FA38 File Offset: 0x0009DC38
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_value = 0;
				return;
			}
			this.m_value = (XmlConvert.ToBoolean(reader.ReadElementString()) ? 2 : 1);
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x060022A4 RID: 8868 RVA: 0x0009FA87 File Offset: 0x0009DC87
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString((this.m_value == 2) ? "true" : "false");
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x060022A5 RID: 8869 RVA: 0x0009FAC7 File Offset: 0x0009DCC7
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("boolean", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04001824 RID: 6180
		private byte m_value;

		// Token: 0x04001825 RID: 6181
		private const byte x_Null = 0;

		// Token: 0x04001826 RID: 6182
		private const byte x_False = 1;

		// Token: 0x04001827 RID: 6183
		private const byte x_True = 2;

		/// <summary>Представляет значение ИСТИНА, которое может быть присвоено свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		// Token: 0x04001828 RID: 6184
		public static readonly SqlBoolean True = new SqlBoolean(true);

		/// <summary>Представляет значение ЛОЖЬ, которое может быть присвоено свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		// Token: 0x04001829 RID: 6185
		public static readonly SqlBoolean False = new SqlBoolean(false);

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		// Token: 0x0400182A RID: 6186
		public static readonly SqlBoolean Null = new SqlBoolean(0, true);

		/// <summary>Представляет нулевое значение, которое можно присвоить свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		// Token: 0x0400182B RID: 6187
		public static readonly SqlBoolean Zero = new SqlBoolean(0);

		/// <summary>Представляет значение единицы, которое может быть назначено свойству <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		// Token: 0x0400182C RID: 6188
		public static readonly SqlBoolean One = new SqlBoolean(1);
	}
}
