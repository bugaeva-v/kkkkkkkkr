using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет поток двоичных данных переменной длины, сохраняемый в базе данных или извлекаемый из нее.</summary>
	// Token: 0x02000305 RID: 773
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlBinary : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002243 RID: 8771 RVA: 0x0009EE33 File Offset: 0x0009D033
		private SqlBinary(bool fNull)
		{
			this._value = null;
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, задавая в качестве значения свойства <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> содержимое предоставленного массива байтов.</summary>
		/// <param name="value">Сохраняемый или извлекаемый массив байтов.</param>
		// Token: 0x06002244 RID: 8772 RVA: 0x0009EE3C File Offset: 0x0009D03C
		public SqlBinary(byte[] value)
		{
			if (value == null)
			{
				this._value = null;
				return;
			}
			this._value = new byte[value.Length];
			value.CopyTo(this._value, 0);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0009EE64 File Offset: 0x0009D064
		internal SqlBinary(byte[] value, bool ignored)
		{
			this._value = value;
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlBinary" /> значение null. Это свойство доступно только для чтения.</summary>
		/// <returns>
		///   <see langword="true" /> если <see langword="null" />. В противном случае <see langword="false" />.</returns>
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0009EE6D File Offset: 0x0009D06D
		public bool IsNull
		{
			get
			{
				return this._value == null;
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Значение структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Свойство <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> читается, когда свойство содержит <see cref="F:System.Data.SqlTypes.SqlBinary.Null" />.</exception>
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0009EE78 File Offset: 0x0009D078
		public byte[] Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				byte[] array = new byte[this._value.Length];
				this._value.CopyTo(array, 0);
				return array;
			}
		}

		/// <summary>Получает один байт из свойства <see cref="P:System.Data.SqlTypes.SqlBinary.Value" />, расположенный в позиции, на которую указывает целочисленный параметр <paramref name="index" />. Если <paramref name="index" /> указывает на позицию за пределами массива байтов, появится <see cref="T:System.Data.SqlTypes.SqlNullValueException" />. Это свойство доступно только для чтения.</summary>
		/// <param name="index">Позиция извлекаемого байта.</param>
		/// <returns>Байт, расположенный в позиции, на которую указывает целочисленный параметр.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Свойство читается, когда свойство <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> содержит <see cref="F:System.Data.SqlTypes.SqlBinary.Null" />.  
		/// -или- 
		/// Параметр <paramref name="index" /> указывает на позицию за пределами длины массива байтов, указанной в свойстве <see cref="P:System.Data.SqlTypes.SqlBinary.Length" />.</exception>
		// Token: 0x1700062D RID: 1581
		public byte this[int index]
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this._value[index];
			}
		}

		/// <summary>Получает длину в байтах для свойства <see cref="P:System.Data.SqlTypes.SqlBinary.Value" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Длина массива двоичных данных в свойстве <see cref="P:System.Data.SqlTypes.SqlBinary.Value" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Свойство <see cref="P:System.Data.SqlTypes.SqlBinary.Length" /> читается, когда свойство <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> содержит <see cref="F:System.Data.SqlTypes.SqlBinary.Null" />.</exception>
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x0009EEC7 File Offset: 0x0009D0C7
		public int Length
		{
			get
			{
				if (!this.IsNull)
				{
					return this._value.Length;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Преобразует массив байтов в структуру <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <param name="x">Преобразуемый массив байтов.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />, которая представляет преобразованный массив байтов.</returns>
		// Token: 0x0600224A RID: 8778 RVA: 0x0009EEDF File Offset: 0x0009D0DF
		public static implicit operator SqlBinary(byte[] x)
		{
			return new SqlBinary(x);
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlBinary" /> в массив <see cref="T:System.Byte" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Массив <see cref="T:System.Byte" />.</returns>
		// Token: 0x0600224B RID: 8779 RVA: 0x0009EEE7 File Offset: 0x0009D0E7
		public static explicit operator byte[](SqlBinary x)
		{
			return x.Value;
		}

		/// <summary>Преобразует этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> в строку.</summary>
		/// <returns>Строка, содержащая <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> типа <see cref="T:System.Data.SqlTypes.SqlBinary" />. Если <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> пусто, строка будет содержать "NULL".</returns>
		// Token: 0x0600224C RID: 8780 RVA: 0x0009EEF0 File Offset: 0x0009D0F0
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return "SqlBinary(" + this._value.Length.ToString(CultureInfo.InvariantCulture) + ")";
			}
			return SQLResource.NullString;
		}

		/// <summary>Сцепляет два параметра <see cref="T:System.Data.SqlTypes.SqlBinary" /> для создания новой структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Сцепленные значения параметров <paramref name="x" /> и <paramref name="y" />.</returns>
		// Token: 0x0600224D RID: 8781 RVA: 0x0009EF30 File Offset: 0x0009D130
		public static SqlBinary operator +(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBinary.Null;
			}
			byte[] array = new byte[x.Value.Length + y.Value.Length];
			x.Value.CopyTo(array, 0);
			y.Value.CopyTo(array, x.Value.Length);
			return new SqlBinary(array);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0009EF98 File Offset: 0x0009D198
		private static EComparison PerformCompareByte(byte[] x, byte[] y)
		{
			int num = (x.Length < y.Length) ? x.Length : y.Length;
			int i = 0;
			while (i < num)
			{
				if (x[i] != y[i])
				{
					if (x[i] < y[i])
					{
						return EComparison.LT;
					}
					return EComparison.GT;
				}
				else
				{
					i++;
				}
			}
			if (x.Length == y.Length)
			{
				return EComparison.EQ;
			}
			byte b = 0;
			if (x.Length < y.Length)
			{
				for (i = num; i < y.Length; i++)
				{
					if (y[i] != b)
					{
						return EComparison.LT;
					}
				}
			}
			else
			{
				for (i = num; i < x.Length; i++)
				{
					if (x[i] != b)
					{
						return EComparison.GT;
					}
				}
			}
			return EComparison.EQ;
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlGuid" /> в структуру <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x0600224F RID: 8783 RVA: 0x0009F019 File Offset: 0x0009D219
		public static explicit operator SqlBinary(SqlGuid x)
		{
			if (!x.IsNull)
			{
				return new SqlBinary(x.ToByteArray());
			}
			return SqlBinary.Null;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, совпадают ли они.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002250 RID: 8784 RVA: 0x0009F036 File Offset: 0x0009D236
		public static SqlBoolean operator ==(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			return new SqlBoolean(SqlBinary.PerformCompareByte(x.Value, y.Value) == EComparison.EQ);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> на неравенство.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002251 RID: 8785 RVA: 0x0009F06B File Offset: 0x0009D26B
		public static SqlBoolean operator !=(SqlBinary x, SqlBinary y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, является ли первая меньше второй.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002252 RID: 8786 RVA: 0x0009F079 File Offset: 0x0009D279
		public static SqlBoolean operator <(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			return new SqlBoolean(SqlBinary.PerformCompareByte(x.Value, y.Value) == EComparison.LT);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, превышает ли первая вторую.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002253 RID: 8787 RVA: 0x0009F0AE File Offset: 0x0009D2AE
		public static SqlBoolean operator >(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			return new SqlBoolean(SqlBinary.PerformCompareByte(x.Value, y.Value) == EComparison.GT);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, является ли первая меньше или равна второй.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002254 RID: 8788 RVA: 0x0009F0E4 File Offset: 0x0009D2E4
		public static SqlBoolean operator <=(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = SqlBinary.PerformCompareByte(x.Value, y.Value);
			return new SqlBoolean(ecomparison == EComparison.LT || ecomparison == EComparison.EQ);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, превышает ли первая вторую или равна ли ей.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002255 RID: 8789 RVA: 0x0009F12C File Offset: 0x0009D32C
		public static SqlBoolean operator >=(SqlBinary x, SqlBinary y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = SqlBinary.PerformCompareByte(x.Value, y.Value);
			return new SqlBoolean(ecomparison == EComparison.GT || ecomparison == EComparison.EQ);
		}

		/// <summary>Сцепляет два заданных значения <see cref="T:System.Data.SqlTypes.SqlBinary" /> для создания новой структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />, представляющая собой сцепленное значение, составленное из x и y.</returns>
		// Token: 0x06002256 RID: 8790 RVA: 0x0009F175 File Offset: 0x0009D375
		public static SqlBinary Add(SqlBinary x, SqlBinary y)
		{
			return x + y;
		}

		/// <summary>Сцепляет две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> для создания новой структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Сцепленные значения параметров <paramref name="x" /> и <paramref name="y" />.</returns>
		// Token: 0x06002257 RID: 8791 RVA: 0x0009F175 File Offset: 0x0009D375
		public static SqlBinary Concat(SqlBinary x, SqlBinary y)
		{
			return x + y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, совпадают ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlBinary" /> будет иметь значение NULL.</returns>
		// Token: 0x06002258 RID: 8792 RVA: 0x0009F17E File Offset: 0x0009D37E
		public static SqlBoolean Equals(SqlBinary x, SqlBinary y)
		{
			return x == y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> на неравенство.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002259 RID: 8793 RVA: 0x0009F187 File Offset: 0x0009D387
		public static SqlBoolean NotEquals(SqlBinary x, SqlBinary y)
		{
			return x != y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, является ли первая меньше второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600225A RID: 8794 RVA: 0x0009F190 File Offset: 0x0009D390
		public static SqlBoolean LessThan(SqlBinary x, SqlBinary y)
		{
			return x < y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, превышает ли первая вторую.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600225B RID: 8795 RVA: 0x0009F199 File Offset: 0x0009D399
		public static SqlBoolean GreaterThan(SqlBinary x, SqlBinary y)
		{
			return x > y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, является ли первая меньше или равна второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600225C RID: 8796 RVA: 0x0009F1A2 File Offset: 0x0009D3A2
		public static SqlBoolean LessThanOrEqual(SqlBinary x, SqlBinary y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />, чтобы определить, превышает ли первая вторую или равна ли ей.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600225D RID: 8797 RVA: 0x0009F1AB File Offset: 0x0009D3AB
		public static SqlBoolean GreaterThanOrEqual(SqlBinary x, SqlBinary y)
		{
			return x >= y;
		}

		/// <summary>Преобразует этот экземпляр <see cref="T:System.Data.SqlTypes.SqlBinary" /> в <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x0600225E RID: 8798 RVA: 0x0009F1B4 File Offset: 0x0009D3B4
		public SqlGuid ToSqlGuid()
		{
			return (SqlGuid)this;
		}

		/// <summary>Сравнивает этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> с предоставленным объектом и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Объект, который необходимо сравнить с этой структурой <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Число со знаком, представляющее относительные значения данной структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Значение этого объекта <see cref="T:System.Data.SqlTypes.SqlBinary" /> меньше, чем данный объект.  
		///
		///   Нуль 
		///   Этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> совпадает с объектом.  
		///
		///   Больше нуля 
		///   Этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> больше, чем объект.  
		///
		/// - или - 
		/// Объект является пустой ссылкой.</returns>
		// Token: 0x0600225F RID: 8799 RVA: 0x0009F1C4 File Offset: 0x0009D3C4
		public int CompareTo(object value)
		{
			if (value is SqlBinary)
			{
				SqlBinary value2 = (SqlBinary)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlBinary));
		}

		/// <summary>Сравнивает этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> с предоставленным объектом <see cref="T:System.Data.SqlTypes.SqlBinary" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> для сравнения с этой структурой <see cref="T:System.Data.SqlTypes.SqlBinary" />.</param>
		/// <returns>Число со знаком, представляющее относительные значения данной структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Значение этого объекта <see cref="T:System.Data.SqlTypes.SqlBinary" /> меньше, чем данный объект.  
		///
		///   Нуль 
		///   Этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> совпадает с объектом.  
		///
		///   Больше нуля 
		///   Этот объект <see cref="T:System.Data.SqlTypes.SqlBinary" /> больше, чем объект.  
		///
		/// -или- 
		/// Объект является пустой ссылкой.</returns>
		// Token: 0x06002260 RID: 8800 RVA: 0x0009F200 File Offset: 0x0009D400
		public int CompareTo(SqlBinary value)
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

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlBinary.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlBinary" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002261 RID: 8801 RVA: 0x0009F258 File Offset: 0x0009D458
		public override bool Equals(object value)
		{
			if (!(value is SqlBinary))
			{
				return false;
			}
			SqlBinary y = (SqlBinary)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0009F2B0 File Offset: 0x0009D4B0
		internal static int HashByteArray(byte[] rgbValue, int length)
		{
			if (length <= 0)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				int num2 = num >> 28 & 255;
				num <<= 4;
				num = (num ^ (int)rgbValue[i] ^ num2);
			}
			return num;
		}

		/// <summary>Возвращает хэш-код данной структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06002263 RID: 8803 RVA: 0x0009F2EC File Offset: 0x0009D4EC
		public override int GetHashCode()
		{
			if (this.IsNull)
			{
				return 0;
			}
			int num = this._value.Length;
			while (num > 0 && this._value[num - 1] == 0)
			{
				num--;
			}
			return SqlBinary.HashByteArray(this._value, num);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
		/// <returns>Экземпляр <see cref="T:System.Xml.Schema.XmlSchema" />.</returns>
		// Token: 0x06002264 RID: 8804 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />.</param>
		// Token: 0x06002265 RID: 8805 RVA: 0x0009F330 File Offset: 0x0009D530
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._value = null;
				return;
			}
			string text = reader.ReadElementString();
			if (text == null)
			{
				this._value = Array.Empty<byte>();
				return;
			}
			text = text.Trim();
			if (text.Length == 0)
			{
				this._value = Array.Empty<byte>();
				return;
			}
			this._value = Convert.FromBase64String(text);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />.</param>
		// Token: 0x06002266 RID: 8806 RVA: 0x0009F3A5 File Offset: 0x0009D5A5
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(Convert.ToBase64String(this._value));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002267 RID: 8807 RVA: 0x0009F3DB File Offset: 0x0009D5DB
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("base64Binary", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04001822 RID: 6178
		private byte[] _value;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlBinary" />.</summary>
		// Token: 0x04001823 RID: 6179
		public static readonly SqlBinary Null = new SqlBinary(true);
	}
}
