using System;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Представляет логическое значение (<see langword="true" /> или <see langword="false" />).</summary>
	// Token: 0x02000102 RID: 258
	[Serializable]
	public readonly struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool>
	{
		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Boolean" />.</returns>
		// Token: 0x06000798 RID: 1944 RVA: 0x00021FDF File Offset: 0x000201DF
		public override int GetHashCode()
		{
			if (!this)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Преобразовывает значение этого экземпляра в эквивалентное ему строковое представление ("True" или "False").</summary>
		/// <returns>"True" (значение свойства <see cref="F:System.Boolean.TrueString" />), если значение этого экземпляра равно <see langword="true" />, или "False" (значение свойства <see cref="F:System.Boolean.FalseString" />), если значение этого экземпляра равно <see langword="false" />.</returns>
		// Token: 0x06000799 RID: 1945 RVA: 0x00021FE8 File Offset: 0x000201E8
		public override string ToString()
		{
			if (!this)
			{
				return "False";
			}
			return "True";
		}

		/// <summary>Преобразовывает значение этого экземпляра в эквивалентное ему строковое представление ("True" или "False").</summary>
		/// <param name="provider">(Зарезервирован.) Объект <see cref="T:System.IFormatProvider" />.</param>
		/// <returns>
		///   <see cref="F:System.Boolean.TrueString" />, если значением данного экземпляра является <see langword="true" />, или <see cref="F:System.Boolean.FalseString" />, если его значением является <see langword="false" />.</returns>
		// Token: 0x0600079A RID: 1946 RVA: 0x00021FF9 File Offset: 0x000201F9
		public string ToString(IFormatProvider provider)
		{
			return this.ToString();
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00022004 File Offset: 0x00020204
		public bool TryFormat(Span<char> destination, out int charsWritten)
		{
			string text = this ? "True" : "False";
			if (text.AsSpan().TryCopyTo(destination))
			{
				charsWritten = text.Length;
				return true;
			}
			charsWritten = 0;
			return false;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="obj" /> имеет тип <see cref="T:System.Boolean" /> и содержит то же значение, что и данный экземпляр; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600079C RID: 1948 RVA: 0x00022041 File Offset: 0x00020241
		public override bool Equals(object obj)
		{
			return obj is bool && this == (bool)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр заданному объекту <see cref="T:System.Boolean" />.</summary>
		/// <param name="obj">Значение типа <see cref="T:System.Boolean" /> для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600079D RID: 1949 RVA: 0x00022057 File Offset: 0x00020257
		[NonVersionable]
		public bool Equals(bool obj)
		{
			return this == obj;
		}

		/// <summary>Сравнивает данный экземпляр с заданным объектом и возвращает целое число, которое показывает их связь друг с другом.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или <see langword="null" />.</param>
		/// <returns>Целое число со знаком, показывающее относительный порядок данного экземпляра и <paramref name="obj" />.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Данный экземпляр содержит значение <see langword="false" />, а параметр <paramref name="obj" /> — значение <see langword="true" />.  
		///
		///   Нуль 
		///   Данный экземпляр и параметр <paramref name="obj" /> равны (оба равны значению <see langword="true" /> или <see langword="false" />).  
		///
		///   Больше нуля 
		///   Данный экземпляр содержит значение <see langword="true" />, а параметр <paramref name="obj" /> — значение <see langword="false" />.  
		///
		/// -или- 
		///  Свойство <paramref name="obj" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Boolean" />.</exception>
		// Token: 0x0600079E RID: 1950 RVA: 0x0002205E File Offset: 0x0002025E
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is bool))
			{
				throw new ArgumentException("Object must be of type Boolean.");
			}
			if (this == (bool)obj)
			{
				return 0;
			}
			if (!this)
			{
				return -1;
			}
			return 1;
		}

		/// <summary>Сравнивает данный экземпляр с заданным объектом <see cref="T:System.Boolean" /> и возвращает целое число, которое показывает их связь друг с другом.</summary>
		/// <param name="value">Объект <see cref="T:System.Boolean" />, сравниваемый с этим экземпляром.</param>
		/// <returns>Целое число со знаком, представляющее результат сравнения значений этого экземпляра и параметра <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Данный экземпляр содержит значение <see langword="false" />, а параметр <paramref name="value" /> — значение <see langword="true" />.  
		///
		///   Нуль 
		///   Данный экземпляр и параметр <paramref name="value" /> равны (оба равны значению <see langword="true" /> или <see langword="false" />).  
		///
		///   Больше нуля 
		///   Данный экземпляр содержит значение <see langword="true" />, а параметр <paramref name="value" /> — значение <see langword="false" />.</returns>
		// Token: 0x0600079F RID: 1951 RVA: 0x0002208B File Offset: 0x0002028B
		public int CompareTo(bool value)
		{
			if (this == value)
			{
				return 0;
			}
			if (!this)
			{
				return -1;
			}
			return 1;
		}

		/// <summary>Преобразует заданное строковое представление логического значения в эквивалентное значение <see cref="T:System.Boolean" />.</summary>
		/// <param name="value">Строка, содержащая преобразуемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> эквивалентно <see cref="F:System.Boolean.TrueString" />. Значение <see langword="false" />, если <paramref name="value" /> эквивалентно <see cref="F:System.Boolean.FalseString" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не эквивалентно ни <see cref="F:System.Boolean.TrueString" />, ни <see cref="F:System.Boolean.FalseString" />.</exception>
		// Token: 0x060007A0 RID: 1952 RVA: 0x0002209B File Offset: 0x0002029B
		public static bool Parse(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return bool.Parse(value.AsSpan());
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000220B8 File Offset: 0x000202B8
		public static bool Parse(ReadOnlySpan<char> value)
		{
			bool result;
			if (!bool.TryParse(value, out result))
			{
				throw new FormatException("String was not recognized as a valid Boolean.");
			}
			return result;
		}

		/// <summary>Пытается преобразовать заданное строковое представление логического значения в его эквивалент типа <see cref="T:System.Boolean" />. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="value">Строка, содержащая преобразуемое значение.</param>
		/// <param name="result">Если после возврата из этого метода преобразование выполнено успешно, содержит <see langword="true" />, если значение параметра <paramref name="value" /> равно <see cref="F:System.Boolean.TrueString" /> или <see langword="false" />, если значение параметра <paramref name="value" /> равно <see cref="F:System.Boolean.FalseString" />. Если преобразование завершилось неудачей, содержит <see langword="false" />. Преобразование завершается неудачей, если значение параметра <paramref name="value" /> равно <see langword="null" /> или не равно значению в поле <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007A2 RID: 1954 RVA: 0x000220DB File Offset: 0x000202DB
		public static bool TryParse(string value, out bool result)
		{
			if (value == null)
			{
				result = false;
				return false;
			}
			return bool.TryParse(value.AsSpan(), out result);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000220F4 File Offset: 0x000202F4
		public static bool TryParse(ReadOnlySpan<char> value, out bool result)
		{
			ReadOnlySpan<char> span = "True".AsSpan();
			if (span.EqualsOrdinalIgnoreCase(value))
			{
				result = true;
				return true;
			}
			ReadOnlySpan<char> span2 = "False".AsSpan();
			if (span2.EqualsOrdinalIgnoreCase(value))
			{
				result = false;
				return true;
			}
			value = bool.TrimWhiteSpaceAndNull(value);
			if (span.EqualsOrdinalIgnoreCase(value))
			{
				result = true;
				return true;
			}
			if (span2.EqualsOrdinalIgnoreCase(value))
			{
				result = false;
				return true;
			}
			result = false;
			return false;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002215C File Offset: 0x0002035C
		private unsafe static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value)
		{
			int num = 0;
			while (num < value.Length && (char.IsWhiteSpace((char)(*value[num])) || *value[num] == 0))
			{
				num++;
			}
			int num2 = value.Length - 1;
			while (num2 >= num && (char.IsWhiteSpace((char)(*value[num2])) || *value[num2] == 0))
			{
				num2--;
			}
			return value.Slice(num, num2 - num + 1);
		}

		/// <summary>Возвращает код типа для типа значения <see cref="T:System.Boolean" />.</summary>
		/// <returns>Перечислимая константа типа <see cref="F:System.TypeCode.Boolean" />.</returns>
		// Token: 0x060007A5 RID: 1957 RVA: 0x000221D2 File Offset: 0x000203D2
		public TypeCode GetTypeCode()
		{
			return TypeCode.Boolean;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" /> или <see langword="false" />.</returns>
		// Token: 0x060007A6 RID: 1958 RVA: 0x000221D5 File Offset: 0x000203D5
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Попытка преобразования значения <see cref="T:System.Boolean" /> в значение <see cref="T:System.Char" />. Данное преобразование не поддерживается.</exception>
		// Token: 0x060007A7 RID: 1959 RVA: 0x000221D9 File Offset: 0x000203D9
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Boolean", "Char"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007A8 RID: 1960 RVA: 0x000221F4 File Offset: 0x000203F4
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если значение данного экземпляра — <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007A9 RID: 1961 RVA: 0x000221FD File Offset: 0x000203FD
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007AA RID: 1962 RVA: 0x00022206 File Offset: 0x00020406
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007AB RID: 1963 RVA: 0x0002220F File Offset: 0x0002040F
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007AC RID: 1964 RVA: 0x00022218 File Offset: 0x00020418
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007AD RID: 1965 RVA: 0x00022221 File Offset: 0x00020421
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007AE RID: 1966 RVA: 0x0002222A File Offset: 0x0002042A
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007AF RID: 1967 RVA: 0x00022233 File Offset: 0x00020433
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007B0 RID: 1968 RVA: 0x0002223C File Offset: 0x0002043C
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007B1 RID: 1969 RVA: 0x00022245 File Offset: 0x00020445
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение 1, если данный экземпляр равен <see langword="true" />; в противном случае значение 0.</returns>
		// Token: 0x060007B2 RID: 1970 RVA: 0x0002224E File Offset: 0x0002044E
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Попытка преобразования значения <see cref="T:System.Boolean" /> в значение <see cref="T:System.DateTime" />. Данное преобразование не поддерживается.</exception>
		// Token: 0x060007B3 RID: 1971 RVA: 0x00022257 File Offset: 0x00020457
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Boolean", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Требуемый тип.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения, связанные с языком и региональными параметрами.</param>
		/// <returns>Объект заданного типа, значение которого эквивалентно значению данного объекта <see langword="Boolean" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Запрошенное преобразование типа не поддерживается.</exception>
		// Token: 0x060007B4 RID: 1972 RVA: 0x00022272 File Offset: 0x00020472
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x0400106D RID: 4205
		private readonly bool m_value;

		// Token: 0x0400106E RID: 4206
		internal const int True = 1;

		// Token: 0x0400106F RID: 4207
		internal const int False = 0;

		// Token: 0x04001070 RID: 4208
		internal const string TrueLiteral = "True";

		// Token: 0x04001071 RID: 4209
		internal const string FalseLiteral = "False";

		/// <summary>Представляет логическое значение <see langword="true" /> в виде строки. Это поле доступно только для чтения.</summary>
		// Token: 0x04001072 RID: 4210
		public static readonly string TrueString = "True";

		/// <summary>Представляет логическое значение <see langword="false" /> в виде строки. Это поле доступно только для чтения.</summary>
		// Token: 0x04001073 RID: 4211
		public static readonly string FalseString = "False";
	}
}
