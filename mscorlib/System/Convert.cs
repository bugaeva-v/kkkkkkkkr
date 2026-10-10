using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Преобразует значение одного базового типа данных к другому базовому типу данных.</summary>
	// Token: 0x02000107 RID: 263
	public static class Convert
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x000232AC File Offset: 0x000214AC
		private unsafe static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
		{
			ref char reference = ref MemoryMarshal.GetReference<char>(utf16);
			ref byte reference2 = ref MemoryMarshal.GetReference<byte>(bytes);
			int num = utf16.Length & -4;
			int length = bytes.Length;
			int i = 0;
			int num2 = 0;
			if (utf16.Length != 0)
			{
				ref sbyte ptr = ref Convert.s_decodingMap[0];
				int num3;
				if (length >= (num >> 2) * 3)
				{
					num3 = num - 4;
				}
				else
				{
					num3 = length / 3 * 4;
				}
				while (i < num3)
				{
					int num4 = Convert.Decode(Unsafe.Add<char>(ref reference, i), ref ptr);
					if (num4 < 0)
					{
						IL_201:
						consumed = i;
						written = num2;
						return false;
					}
					Convert.WriteThreeLowOrderBytes(Unsafe.Add<byte>(ref reference2, num2), num4);
					num2 += 3;
					i += 4;
				}
				if (num3 != num - 4 || i == num)
				{
					goto IL_201;
				}
				int num5 = (int)(*Unsafe.Add<char>(ref reference, num - 4));
				int num6 = (int)(*Unsafe.Add<char>(ref reference, num - 3));
				int num7 = (int)(*Unsafe.Add<char>(ref reference, num - 2));
				int num8 = (int)(*Unsafe.Add<char>(ref reference, num - 1));
				if (((long)(num5 | num6 | num7 | num8) & (long)((ulong)-256)) != 0L)
				{
					goto IL_201;
				}
				num5 = (int)(*Unsafe.Add<sbyte>(ref ptr, num5));
				num6 = (int)(*Unsafe.Add<sbyte>(ref ptr, num6));
				num5 <<= 18;
				num6 <<= 12;
				num5 |= num6;
				if (num8 != 61)
				{
					num7 = (int)(*Unsafe.Add<sbyte>(ref ptr, num7));
					num8 = (int)(*Unsafe.Add<sbyte>(ref ptr, num8));
					num7 <<= 6;
					num5 |= num8;
					num5 |= num7;
					if (num5 < 0 || num2 > length - 3)
					{
						goto IL_201;
					}
					Convert.WriteThreeLowOrderBytes(Unsafe.Add<byte>(ref reference2, num2), num5);
					num2 += 3;
				}
				else if (num7 != 61)
				{
					num7 = (int)(*Unsafe.Add<sbyte>(ref ptr, num7));
					num7 <<= 6;
					num5 |= num7;
					if (num5 < 0 || num2 > length - 2)
					{
						goto IL_201;
					}
					*Unsafe.Add<byte>(ref reference2, num2) = (byte)(num5 >> 16);
					*Unsafe.Add<byte>(ref reference2, num2 + 1) = (byte)(num5 >> 8);
					num2 += 2;
				}
				else
				{
					if (num5 < 0 || num2 > length - 1)
					{
						goto IL_201;
					}
					*Unsafe.Add<byte>(ref reference2, num2) = (byte)(num5 >> 16);
					num2++;
				}
				i += 4;
				if (num != utf16.Length)
				{
					goto IL_201;
				}
			}
			consumed = i;
			written = num2;
			return true;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000234C4 File Offset: 0x000216C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static int Decode(ref char encodedChars, ref sbyte decodingMap)
		{
			int num = (int)encodedChars;
			int num2 = (int)(*Unsafe.Add<char>(ref encodedChars, 1));
			int num3 = (int)(*Unsafe.Add<char>(ref encodedChars, 2));
			int num4 = (int)(*Unsafe.Add<char>(ref encodedChars, 3));
			if (((long)(num | num2 | num3 | num4) & (long)((ulong)-256)) != 0L)
			{
				return -1;
			}
			num = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num));
			num2 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num2));
			num3 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num3));
			num4 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num4));
			num <<= 18;
			num2 <<= 12;
			num3 <<= 6;
			num |= num4;
			num2 |= num3;
			return num | num2;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00023541 File Offset: 0x00021741
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WriteThreeLowOrderBytes(ref byte destination, int value)
		{
			destination = (byte)(value >> 16);
			*Unsafe.Add<byte>(ref destination, 1) = (byte)(value >> 8);
			*Unsafe.Add<byte>(ref destination, 2) = (byte)value;
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для заданного объекта.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <returns>
		///   <see cref="T:System.TypeCode" /> для <paramref name="value" /> или <see cref="F:System.TypeCode.Empty" />, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		// Token: 0x06000839 RID: 2105 RVA: 0x00023560 File Offset: 0x00021760
		public static TypeCode GetTypeCode(object value)
		{
			if (value == null)
			{
				return TypeCode.Empty;
			}
			IConvertible convertible = value as IConvertible;
			if (convertible != null)
			{
				return convertible.GetTypeCode();
			}
			return TypeCode.Object;
		}

		/// <summary>Возвращает значение, указывающее, имеет ли заданный объект тип <see cref="T:System.DBNull" />.</summary>
		/// <param name="value">Объект.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="value" /> имеет тип <see cref="T:System.DBNull" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600083A RID: 2106 RVA: 0x00023584 File Offset: 0x00021784
		public static bool IsDBNull(object value)
		{
			if (value == System.DBNull.Value)
			{
				return true;
			}
			IConvertible convertible = value as IConvertible;
			return convertible != null && convertible.GetTypeCode() == TypeCode.DBNull;
		}

		/// <summary>Возвращает объект указанного типа, чье значение эквивалентно заданному объекту.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="typeCode">Тип возвращаемого объекта.</param>
		/// <returns>Объект, базовый тип которого равен <paramref name="typeCode" />, а значение эквивалентно <paramref name="value" />.  
		///
		/// или - 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если <paramref name="value" /> равняется <see langword="null" />, а <paramref name="typeCode" /> равняется <see cref="F:System.TypeCode.Empty" />, <see cref="F:System.TypeCode.String" /> или <see cref="F:System.TypeCode.Object" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.  
		///
		/// или - 
		/// <paramref name="value" /> равен <see langword="null" /> и <paramref name="typeCode" /> указывает тип значения.  
		///
		/// или - 
		/// <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является форматом, распознаваемым типом <paramref name="typeCode" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> представляет число, которое не входит в диапазон типа <paramref name="typeCode" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="typeCode" /> недопустим.</exception>
		// Token: 0x0600083B RID: 2107 RVA: 0x000235B0 File Offset: 0x000217B0
		public static object ChangeType(object value, TypeCode typeCode)
		{
			return Convert.ChangeType(value, typeCode, CultureInfo.CurrentCulture);
		}

		/// <summary>Возвращает объект указанного типа, чье значение эквивалентно заданному объекту. Параметр предоставляет сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="typeCode">Тип возвращаемого объекта.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Объект, базовый тип которого равен <paramref name="typeCode" />, а значение эквивалентно <paramref name="value" />.  
		///
		/// или - 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если <paramref name="value" /> равняется <see langword="null" />, а <paramref name="typeCode" /> равняется <see cref="F:System.TypeCode.Empty" />, <see cref="F:System.TypeCode.String" /> или <see cref="F:System.TypeCode.Object" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.  
		///
		/// или - 
		/// <paramref name="value" /> равен <see langword="null" /> и <paramref name="typeCode" /> указывает тип значения.  
		///
		/// или - 
		/// <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является форматом для типа <paramref name="typeCode" />, распознаваемым <paramref name="provider" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> представляет число, которое не входит в диапазон типа <paramref name="typeCode" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="typeCode" /> недопустим.</exception>
		// Token: 0x0600083C RID: 2108 RVA: 0x000235C0 File Offset: 0x000217C0
		public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
		{
			if (value == null && (typeCode == TypeCode.Empty || typeCode == TypeCode.String || typeCode == TypeCode.Object))
			{
				return null;
			}
			IConvertible convertible = value as IConvertible;
			if (convertible == null)
			{
				throw new InvalidCastException("Object must implement IConvertible.");
			}
			switch (typeCode)
			{
			case TypeCode.Empty:
				throw new InvalidCastException("Object cannot be cast to Empty.");
			case TypeCode.Object:
				return value;
			case TypeCode.DBNull:
				throw new InvalidCastException("Object cannot be cast to DBNull.");
			case TypeCode.Boolean:
				return convertible.ToBoolean(provider);
			case TypeCode.Char:
				return convertible.ToChar(provider);
			case TypeCode.SByte:
				return convertible.ToSByte(provider);
			case TypeCode.Byte:
				return convertible.ToByte(provider);
			case TypeCode.Int16:
				return convertible.ToInt16(provider);
			case TypeCode.UInt16:
				return convertible.ToUInt16(provider);
			case TypeCode.Int32:
				return convertible.ToInt32(provider);
			case TypeCode.UInt32:
				return convertible.ToUInt32(provider);
			case TypeCode.Int64:
				return convertible.ToInt64(provider);
			case TypeCode.UInt64:
				return convertible.ToUInt64(provider);
			case TypeCode.Single:
				return convertible.ToSingle(provider);
			case TypeCode.Double:
				return convertible.ToDouble(provider);
			case TypeCode.Decimal:
				return convertible.ToDecimal(provider);
			case TypeCode.DateTime:
				return convertible.ToDateTime(provider);
			case TypeCode.String:
				return convertible.ToString(provider);
			}
			throw new ArgumentException("Unknown TypeCode value.");
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0002372C File Offset: 0x0002192C
		internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
		{
			if (targetType == null)
			{
				throw new ArgumentNullException("targetType");
			}
			if (value.GetType() == targetType)
			{
				return value;
			}
			if (targetType == Convert.ConvertTypes[3])
			{
				return value.ToBoolean(provider);
			}
			if (targetType == Convert.ConvertTypes[4])
			{
				return value.ToChar(provider);
			}
			if (targetType == Convert.ConvertTypes[5])
			{
				return value.ToSByte(provider);
			}
			if (targetType == Convert.ConvertTypes[6])
			{
				return value.ToByte(provider);
			}
			if (targetType == Convert.ConvertTypes[7])
			{
				return value.ToInt16(provider);
			}
			if (targetType == Convert.ConvertTypes[8])
			{
				return value.ToUInt16(provider);
			}
			if (targetType == Convert.ConvertTypes[9])
			{
				return value.ToInt32(provider);
			}
			if (targetType == Convert.ConvertTypes[10])
			{
				return value.ToUInt32(provider);
			}
			if (targetType == Convert.ConvertTypes[11])
			{
				return value.ToInt64(provider);
			}
			if (targetType == Convert.ConvertTypes[12])
			{
				return value.ToUInt64(provider);
			}
			if (targetType == Convert.ConvertTypes[13])
			{
				return value.ToSingle(provider);
			}
			if (targetType == Convert.ConvertTypes[14])
			{
				return value.ToDouble(provider);
			}
			if (targetType == Convert.ConvertTypes[15])
			{
				return value.ToDecimal(provider);
			}
			if (targetType == Convert.ConvertTypes[16])
			{
				return value.ToDateTime(provider);
			}
			if (targetType == Convert.ConvertTypes[18])
			{
				return value.ToString(provider);
			}
			if (targetType == Convert.ConvertTypes[1])
			{
				return value;
			}
			if (targetType == Convert.EnumType)
			{
				return (Enum)value;
			}
			if (targetType == Convert.ConvertTypes[2])
			{
				throw new InvalidCastException("Object cannot be cast to DBNull.");
			}
			if (targetType == Convert.ConvertTypes[0])
			{
				throw new InvalidCastException("Object cannot be cast to Empty.");
			}
			throw new InvalidCastException(string.Format("Invalid cast from '{0}' to '{1}'.", value.GetType().FullName, targetType.FullName));
		}

		/// <summary>Возвращает объект указанного типа, значение которого эквивалентно заданному объекту.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="conversionType">Тип возвращаемого объекта.</param>
		/// <returns>Объект, тип которого равен <paramref name="conversionType" />, а значение эквивалентно <paramref name="value" />.  
		///
		/// или - 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если <paramref name="value" /> равняется <see langword="null" />, а <paramref name="conversionType" /> не является типом значения.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.  
		///
		/// или - 
		/// Значение <paramref name="value" /> — <see langword="null" />, а <paramref name="conversionType" /> — это тип значения.  
		///
		/// или - 
		/// <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является форматом, распознаваемым типом <paramref name="conversionType" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> представляет число, которое не входит в диапазон <paramref name="conversionType" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="conversionType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600083E RID: 2110 RVA: 0x0002391A File Offset: 0x00021B1A
		public static object ChangeType(object value, Type conversionType)
		{
			return Convert.ChangeType(value, conversionType, CultureInfo.CurrentCulture);
		}

		/// <summary>Возвращает объект указанного типа, чье значение эквивалентно заданному объекту. Параметр предоставляет сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="conversionType">Тип возвращаемого объекта.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Объект, тип которого равен <paramref name="conversionType" />, а значение эквивалентно <paramref name="value" />.  
		///
		/// или - 
		/// <paramref name="value" />, если <see cref="T:System.Type" /> параметра <paramref name="value" /> равен <paramref name="conversionType" />.  
		///
		/// или - 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если <paramref name="value" /> равняется <see langword="null" />, а <paramref name="conversionType" /> не является типом значения.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.  
		///
		/// или - 
		/// Значение <paramref name="value" /> — <see langword="null" />, а <paramref name="conversionType" /> — это тип значения.  
		///
		/// или - 
		/// <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является форматом для типа <paramref name="conversionType" />, распознаваемым поставщиком <paramref name="provider" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> представляет число, которое не входит в диапазон <paramref name="conversionType" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="conversionType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600083F RID: 2111 RVA: 0x00023928 File Offset: 0x00021B28
		public static object ChangeType(object value, Type conversionType, IFormatProvider provider)
		{
			if (conversionType == null)
			{
				throw new ArgumentNullException("conversionType");
			}
			if (value == null)
			{
				if (conversionType.IsValueType)
				{
					throw new InvalidCastException("Null object cannot be converted to a value type.");
				}
				return null;
			}
			else
			{
				IConvertible convertible = value as IConvertible;
				if (convertible == null)
				{
					if (value.GetType() == conversionType)
					{
						return value;
					}
					throw new InvalidCastException("Object must implement IConvertible.");
				}
				else
				{
					if (conversionType == Convert.ConvertTypes[3])
					{
						return convertible.ToBoolean(provider);
					}
					if (conversionType == Convert.ConvertTypes[4])
					{
						return convertible.ToChar(provider);
					}
					if (conversionType == Convert.ConvertTypes[5])
					{
						return convertible.ToSByte(provider);
					}
					if (conversionType == Convert.ConvertTypes[6])
					{
						return convertible.ToByte(provider);
					}
					if (conversionType == Convert.ConvertTypes[7])
					{
						return convertible.ToInt16(provider);
					}
					if (conversionType == Convert.ConvertTypes[8])
					{
						return convertible.ToUInt16(provider);
					}
					if (conversionType == Convert.ConvertTypes[9])
					{
						return convertible.ToInt32(provider);
					}
					if (conversionType == Convert.ConvertTypes[10])
					{
						return convertible.ToUInt32(provider);
					}
					if (conversionType == Convert.ConvertTypes[11])
					{
						return convertible.ToInt64(provider);
					}
					if (conversionType == Convert.ConvertTypes[12])
					{
						return convertible.ToUInt64(provider);
					}
					if (conversionType == Convert.ConvertTypes[13])
					{
						return convertible.ToSingle(provider);
					}
					if (conversionType == Convert.ConvertTypes[14])
					{
						return convertible.ToDouble(provider);
					}
					if (conversionType == Convert.ConvertTypes[15])
					{
						return convertible.ToDecimal(provider);
					}
					if (conversionType == Convert.ConvertTypes[16])
					{
						return convertible.ToDateTime(provider);
					}
					if (conversionType == Convert.ConvertTypes[18])
					{
						return convertible.ToString(provider);
					}
					if (conversionType == Convert.ConvertTypes[1])
					{
						return value;
					}
					return convertible.ToType(conversionType, provider);
				}
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00023AF1 File Offset: 0x00021CF1
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowCharOverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a character.");
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00023AFD File Offset: 0x00021CFD
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowByteOverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an unsigned byte.");
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00023B09 File Offset: 0x00021D09
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowSByteOverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a signed byte.");
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00023B15 File Offset: 0x00021D15
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowInt16OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an Int16.");
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00023B21 File Offset: 0x00021D21
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowUInt16OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a UInt16.");
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00023B2D File Offset: 0x00021D2D
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowInt32OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an Int32.");
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00023B39 File Offset: 0x00021D39
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowUInt32OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a UInt32.");
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00023B45 File Offset: 0x00021D45
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowInt64OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an Int64.");
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00023B51 File Offset: 0x00021D51
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowUInt64OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a UInt64.");
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное логическое значение.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" /> или <see langword="false" />, отражающее значение, возвращаемое методом <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> при вызове для базового типа параметра <paramref name="value" />. Если значением параметра <paramref name="value" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> является строкой, которая не равна <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование <paramref name="value" /> в <see cref="T:System.Boolean" /> не поддерживается.</exception>
		// Token: 0x06000849 RID: 2121 RVA: 0x00023B5D File Offset: 0x00021D5D
		public static bool ToBoolean(object value)
		{
			return value != null && ((IConvertible)value).ToBoolean(null);
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное логическое значение, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>
		///   <see langword="true" /> или <see langword="false" />, отражающее значение, возвращаемое методом <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> при вызове для базового типа параметра <paramref name="value" />. Если значением параметра <paramref name="value" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> является строкой, которая не равна <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование <paramref name="value" /> в <see cref="T:System.Boolean" /> не поддерживается.</exception>
		// Token: 0x0600084A RID: 2122 RVA: 0x00023B70 File Offset: 0x00021D70
		public static bool ToBoolean(object value, IFormatProvider provider)
		{
			return value != null && ((IConvertible)value).ToBoolean(provider);
		}

		/// <summary>Возвращает заданное логическое значение; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое логическое значение.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x0600084B RID: 2123 RVA: 0x0000270D File Offset: 0x0000090D
		public static bool ToBoolean(bool value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное логическое значение.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600084C RID: 2124 RVA: 0x00023B83 File Offset: 0x00021D83
		[CLSCompliant(false)]
		public static bool ToBoolean(sbyte value)
		{
			return value != 0;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600084D RID: 2125 RVA: 0x00023B89 File Offset: 0x00021D89
		public static bool ToBoolean(char value)
		{
			return ((IConvertible)value).ToBoolean(null);
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное логическое значение.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600084E RID: 2126 RVA: 0x00023B83 File Offset: 0x00021D83
		public static bool ToBoolean(byte value)
		{
			return value > 0;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное логическое значение.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600084F RID: 2127 RVA: 0x00023B83 File Offset: 0x00021D83
		public static bool ToBoolean(short value)
		{
			return value != 0;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное логическое значение.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000850 RID: 2128 RVA: 0x00023B83 File Offset: 0x00021D83
		[CLSCompliant(false)]
		public static bool ToBoolean(ushort value)
		{
			return value > 0;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное логическое значение.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000851 RID: 2129 RVA: 0x00023B83 File Offset: 0x00021D83
		public static bool ToBoolean(int value)
		{
			return value != 0;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное логическое значение.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000852 RID: 2130 RVA: 0x00023B83 File Offset: 0x00021D83
		[CLSCompliant(false)]
		public static bool ToBoolean(uint value)
		{
			return value > 0U;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное логическое значение.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000853 RID: 2131 RVA: 0x00023B97 File Offset: 0x00021D97
		public static bool ToBoolean(long value)
		{
			return value != 0L;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное логическое значение.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000854 RID: 2132 RVA: 0x00023B97 File Offset: 0x00021D97
		[CLSCompliant(false)]
		public static bool ToBoolean(ulong value)
		{
			return value > 0UL;
		}

		/// <summary>Преобразует заданное строковое представление логического значения в эквивалентное логическое значение.</summary>
		/// <param name="value">Строка, содержащая значение <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> имеет значение <see cref="F:System.Boolean.TrueString" />, или <see langword="false" />, если параметр <paramref name="value" /> имеет значение <see cref="F:System.Boolean.FalseString" /> либо <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> не равен <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</exception>
		// Token: 0x06000855 RID: 2133 RVA: 0x00023B9E File Offset: 0x00021D9E
		public static bool ToBoolean(string value)
		{
			return value != null && bool.Parse(value);
		}

		/// <summary>Преобразует заданное строковое представление логического значения в эквивалентное логическое значение, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая значение <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров. Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> имеет значение <see cref="F:System.Boolean.TrueString" />, или <see langword="false" />, если параметр <paramref name="value" /> имеет значение <see cref="F:System.Boolean.FalseString" /> либо <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> не равен <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</exception>
		// Token: 0x06000856 RID: 2134 RVA: 0x00023B9E File Offset: 0x00021D9E
		public static bool ToBoolean(string value, IFormatProvider provider)
		{
			return value != null && bool.Parse(value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное логическое значение.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000857 RID: 2135 RVA: 0x00023BAB File Offset: 0x00021DAB
		public static bool ToBoolean(float value)
		{
			return value != 0f;
		}

		/// <summary>Преобразует значение заданного числа двойной точности с плавающей запятой в эквивалентное логическое значение.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000858 RID: 2136 RVA: 0x00023BB8 File Offset: 0x00021DB8
		public static bool ToBoolean(double value)
		{
			return value != 0.0;
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное логическое значение.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000859 RID: 2137 RVA: 0x00023BC9 File Offset: 0x00021DC9
		public static bool ToBoolean(decimal value)
		{
			return value != 0m;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600085A RID: 2138 RVA: 0x00023BD6 File Offset: 0x00021DD6
		public static bool ToBoolean(DateTime value)
		{
			return ((IConvertible)value).ToBoolean(null);
		}

		/// <summary>Преобразует значение заданного объекта в знак Юникода.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <returns>Знак Юникода, который эквивалентен значению, или <see cref="F:System.Char.MinValue" />, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение <paramref name="value" /> является пустой строкой.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование <paramref name="value" /> в <see cref="T:System.Char" /> не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Char.MinValue" /> или больше <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x0600085B RID: 2139 RVA: 0x00023BE4 File Offset: 0x00021DE4
		public static char ToChar(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToChar(null);
			}
			return '\0';
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентный знак Юникода, используя указанные сведения о форматировании, связанные с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Знак Юникода, который эквивалентен <paramref name="value" />, или <see cref="F:System.Char.MinValue" />, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение <paramref name="value" /> является пустой строкой.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование <paramref name="value" /> в <see cref="T:System.Char" /> не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Char.MinValue" /> или больше <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x0600085C RID: 2140 RVA: 0x00023BF7 File Offset: 0x00021DF7
		public static char ToChar(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToChar(provider);
			}
			return '\0';
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600085D RID: 2141 RVA: 0x00023C0A File Offset: 0x00021E0A
		public static char ToChar(bool value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>Возвращает заданное значение символа Юникода; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемый знак Юникода.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x0600085E RID: 2142 RVA: 0x0000270D File Offset: 0x0000090D
		public static char ToChar(char value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентный символ Юникода.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Char.MinValue" />.</exception>
		// Token: 0x0600085F RID: 2143 RVA: 0x00023C18 File Offset: 0x00021E18
		[CLSCompliant(false)]
		public static char ToChar(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа без знака в эквивалентный символ Юникода.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		// Token: 0x06000860 RID: 2144 RVA: 0x0000270D File Offset: 0x0000090D
		public static char ToChar(byte value)
		{
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентный символ Юникода.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Char.MinValue" />.</exception>
		// Token: 0x06000861 RID: 2145 RVA: 0x00023C18 File Offset: 0x00021E18
		public static char ToChar(short value)
		{
			if (value < 0)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 16-разрядного целого числа без знака в эквивалентный символ Юникода.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		// Token: 0x06000862 RID: 2146 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static char ToChar(ushort value)
		{
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентный символ Юникода.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Char.MinValue" /> или больше <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x06000863 RID: 2147 RVA: 0x00023C25 File Offset: 0x00021E25
		public static char ToChar(int value)
		{
			if (value < 0 || value > 65535)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 32-разрядного целого числа без знака в эквивалентный символ Юникода.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x06000864 RID: 2148 RVA: 0x00023C3A File Offset: 0x00021E3A
		[CLSCompliant(false)]
		public static char ToChar(uint value)
		{
			if (value > 65535U)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентный символ Юникода.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Char.MinValue" /> или больше <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x06000865 RID: 2149 RVA: 0x00023C4B File Offset: 0x00021E4B
		public static char ToChar(long value)
		{
			if (value < 0L || value > 65535L)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентный символ Юникода.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>Знак Юникода, который эквивалентен значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x06000866 RID: 2150 RVA: 0x00023C62 File Offset: 0x00021E62
		[CLSCompliant(false)]
		public static char ToChar(ulong value)
		{
			if (value > 65535UL)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Преобразует первый знак указанной строки в знак Юникода.</summary>
		/// <param name="value">Строка длиной в 1 знак.</param>
		/// <returns>Знак Юникода, эквивалентный первому и единственному знаку в <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Длина <paramref name="value" /> не равна 1.</exception>
		// Token: 0x06000867 RID: 2151 RVA: 0x00023C74 File Offset: 0x00021E74
		public static char ToChar(string value)
		{
			return Convert.ToChar(value, null);
		}

		/// <summary>Преобразует первый знак заданной строки в знак Юникода, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка длиной в 1 знак или <see langword="null" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров. Этот параметр не учитывается.</param>
		/// <returns>Знак Юникода, эквивалентный первому и единственному знаку в <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Длина <paramref name="value" /> не равна 1.</exception>
		// Token: 0x06000868 RID: 2152 RVA: 0x00023C7D File Offset: 0x00021E7D
		public static char ToChar(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 1)
			{
				throw new FormatException("String must be exactly one character long.");
			}
			return value[0];
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000869 RID: 2153 RVA: 0x00023CA8 File Offset: 0x00021EA8
		public static char ToChar(float value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600086A RID: 2154 RVA: 0x00023CB6 File Offset: 0x00021EB6
		public static char ToChar(double value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600086B RID: 2155 RVA: 0x00023CC4 File Offset: 0x00021EC4
		public static char ToChar(decimal value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600086C RID: 2156 RVA: 0x00023CD2 File Offset: 0x00021ED2
		public static char ToChar(DateTime value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>Преобразует значение заданного объекта в 8-битовое целое число со знаком.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>8-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x0600086D RID: 2157 RVA: 0x00023CE0 File Offset: 0x00021EE0
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSByte(null);
			}
			return 0;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 8-разрядное знаковое целое число, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>8-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x0600086E RID: 2158 RVA: 0x00023CF3 File Offset: 0x00021EF3
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSByte(provider);
			}
			return 0;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x0600086F RID: 2159 RVA: 0x00023D06 File Offset: 0x00021F06
		[CLSCompliant(false)]
		public static sbyte ToSByte(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Возвращает заданное 8-битовое целое число со знаком; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 8-разрядное целое число со знаком.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000870 RID: 2160 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static sbyte ToSByte(sbyte value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000871 RID: 2161 RVA: 0x00023D0E File Offset: 0x00021F0E
		[CLSCompliant(false)]
		public static sbyte ToSByte(char value)
		{
			if (value > '\u007f')
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000872 RID: 2162 RVA: 0x00023D0E File Offset: 0x00021F0E
		[CLSCompliant(false)]
		public static sbyte ToSByte(byte value)
		{
			if (value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа со знаком в эквивалентное 16-разрядное целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000873 RID: 2163 RVA: 0x00023D1C File Offset: 0x00021F1C
		[CLSCompliant(false)]
		public static sbyte ToSByte(short value)
		{
			if (value < -128 || value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000874 RID: 2164 RVA: 0x00023D0E File Offset: 0x00021F0E
		[CLSCompliant(false)]
		public static sbyte ToSByte(ushort value)
		{
			if (value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000875 RID: 2165 RVA: 0x00023D1C File Offset: 0x00021F1C
		[CLSCompliant(false)]
		public static sbyte ToSByte(int value)
		{
			if (value < -128 || value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000876 RID: 2166 RVA: 0x00023D2F File Offset: 0x00021F2F
		[CLSCompliant(false)]
		public static sbyte ToSByte(uint value)
		{
			if ((ulong)value > 127UL)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000877 RID: 2167 RVA: 0x00023D3F File Offset: 0x00021F3F
		[CLSCompliant(false)]
		public static sbyte ToSByte(long value)
		{
			if (value < -128L || value > 127L)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000878 RID: 2168 RVA: 0x00023D54 File Offset: 0x00021F54
		[CLSCompliant(false)]
		public static sbyte ToSByte(ulong value)
		{
			if (value > 127UL)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 8-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000879 RID: 2169 RVA: 0x00023D63 File Offset: 0x00021F63
		[CLSCompliant(false)]
		public static sbyte ToSByte(float value)
		{
			return Convert.ToSByte((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 8-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x0600087A RID: 2170 RVA: 0x00023D6C File Offset: 0x00021F6C
		[CLSCompliant(false)]
		public static sbyte ToSByte(double value)
		{
			return Convert.ToSByte(Convert.ToInt32(value));
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 8-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x0600087B RID: 2171 RVA: 0x00023D79 File Offset: 0x00021F79
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			return decimal.ToSByte(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 8-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>8-разрядное целое число со знаком, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если значение равно <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x0600087C RID: 2172 RVA: 0x00023D87 File Offset: 0x00021F87
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return sbyte.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 8-битовое целое число со знаком, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следуют цифры (0-9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x0600087D RID: 2173 RVA: 0x00023D99 File Offset: 0x00021F99
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, IFormatProvider provider)
		{
			return sbyte.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600087E RID: 2174 RVA: 0x00023DA3 File Offset: 0x00021FA3
		[CLSCompliant(false)]
		public static sbyte ToSByte(DateTime value)
		{
			return ((IConvertible)value).ToSByte(null);
		}

		/// <summary>Преобразует значение заданного объекта в 8-разрядное целое число без знака.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>8-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является форматом свойства для значения <see cref="T:System.Byte" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование из <paramref name="value" /> в тип <see cref="T:System.Byte" /> не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x0600087F RID: 2175 RVA: 0x00023DB1 File Offset: 0x00021FB1
		public static byte ToByte(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToByte(null);
			}
			return 0;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 8-разрядное целое число без знака, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>8-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является форматом свойства для значения <see cref="T:System.Byte" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование из <paramref name="value" /> в тип <see cref="T:System.Byte" /> не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000880 RID: 2176 RVA: 0x00023DC4 File Offset: 0x00021FC4
		public static byte ToByte(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToByte(provider);
			}
			return 0;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x06000881 RID: 2177 RVA: 0x00023D06 File Offset: 0x00021F06
		public static byte ToByte(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Возвращает заданное 8-битовое целое число без знака; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 8-разрядное целое число без знака.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000882 RID: 2178 RVA: 0x0000270D File Offset: 0x0000090D
		public static byte ToByte(byte value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число, которое больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000883 RID: 2179 RVA: 0x00023DD7 File Offset: 0x00021FD7
		public static byte ToByte(char value)
		{
			if (value > 'ÿ')
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Byte.MinValue" />.</exception>
		// Token: 0x06000884 RID: 2180 RVA: 0x00023DE8 File Offset: 0x00021FE8
		[CLSCompliant(false)]
		public static byte ToByte(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000885 RID: 2181 RVA: 0x00023DF5 File Offset: 0x00021FF5
		public static byte ToByte(short value)
		{
			if (value < 0 || value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 16-разрядного целого числа без знака в эквивалентное 8-разрядное целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000886 RID: 2182 RVA: 0x00023DD7 File Offset: 0x00021FD7
		[CLSCompliant(false)]
		public static byte ToByte(ushort value)
		{
			if (value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000887 RID: 2183 RVA: 0x00023DF5 File Offset: 0x00021FF5
		public static byte ToByte(int value)
		{
			if (value < 0 || value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000888 RID: 2184 RVA: 0x00023E0A File Offset: 0x0002200A
		[CLSCompliant(false)]
		public static byte ToByte(uint value)
		{
			if (value > 255U)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000889 RID: 2185 RVA: 0x00023E1B File Offset: 0x0002201B
		public static byte ToByte(long value)
		{
			if (value < 0L || value > 255L)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентное 8-разрядное целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x0600088A RID: 2186 RVA: 0x00023E32 File Offset: 0x00022032
		[CLSCompliant(false)]
		public static byte ToByte(ulong value)
		{
			if (value > 255UL)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 8-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Byte.MaxValue" /> или меньше <see cref="F:System.Byte.MinValue" />.</exception>
		// Token: 0x0600088B RID: 2187 RVA: 0x00023E44 File Offset: 0x00022044
		public static byte ToByte(float value)
		{
			return Convert.ToByte((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 8-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Byte.MaxValue" /> или меньше <see cref="F:System.Byte.MinValue" />.</exception>
		// Token: 0x0600088C RID: 2188 RVA: 0x00023E4D File Offset: 0x0002204D
		public static byte ToByte(double value)
		{
			return Convert.ToByte(Convert.ToInt32(value));
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 8-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Byte.MaxValue" /> или меньше <see cref="F:System.Byte.MinValue" />.</exception>
		// Token: 0x0600088D RID: 2189 RVA: 0x00023E5A File Offset: 0x0002205A
		public static byte ToByte(decimal value)
		{
			return decimal.ToByte(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 8-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>8-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x0600088E RID: 2190 RVA: 0x00023E68 File Offset: 0x00022068
		public static byte ToByte(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return byte.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 8-разрядное целое число без знака, учитывая сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>8-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x0600088F RID: 2191 RVA: 0x00023E7A File Offset: 0x0002207A
		public static byte ToByte(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return byte.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000890 RID: 2192 RVA: 0x00023E89 File Offset: 0x00022089
		public static byte ToByte(DateTime value)
		{
			return ((IConvertible)value).ToByte(null);
		}

		/// <summary>Преобразует значение заданного объекта в 16-битовое целое число со знаком.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>16-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат для типа <see cref="T:System.Int16" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000891 RID: 2193 RVA: 0x00023E97 File Offset: 0x00022097
		public static short ToInt16(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt16(null);
			}
			return 0;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 16-битовое целое число со знаком, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>16-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат для типа <see cref="T:System.Int16" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000892 RID: 2194 RVA: 0x00023EAA File Offset: 0x000220AA
		public static short ToInt16(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt16(provider);
			}
			return 0;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x06000893 RID: 2195 RVA: 0x00023D06 File Offset: 0x00021F06
		public static short ToInt16(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000894 RID: 2196 RVA: 0x00023EBD File Offset: 0x000220BD
		public static short ToInt16(char value)
		{
			if (value > '翿')
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа со знаком в эквивалентное 16-разрядное целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000895 RID: 2197 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static short ToInt16(sbyte value)
		{
			return (short)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа без знака в эквивалентное 16-разрядное целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000896 RID: 2198 RVA: 0x0000270D File Offset: 0x0000090D
		public static short ToInt16(byte value)
		{
			return (short)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000897 RID: 2199 RVA: 0x00023EBD File Offset: 0x000220BD
		[CLSCompliant(false)]
		public static short ToInt16(ushort value)
		{
			if (value > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>16-разрядное целое число со знаком, эквивалентное <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int16.MaxValue" /> или меньше <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x06000898 RID: 2200 RVA: 0x00023ECE File Offset: 0x000220CE
		public static short ToInt16(int value)
		{
			if (value < -32768 || value > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000899 RID: 2201 RVA: 0x00023EE7 File Offset: 0x000220E7
		[CLSCompliant(false)]
		public static short ToInt16(uint value)
		{
			if ((ulong)value > 32767UL)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Возвращает заданное 16-битовое целое число со знаком; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 16-разрядное целое число со знаком.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x0600089A RID: 2202 RVA: 0x0000270D File Offset: 0x0000090D
		public static short ToInt16(short value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int16.MaxValue" /> или меньше <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x0600089B RID: 2203 RVA: 0x00023EFA File Offset: 0x000220FA
		public static short ToInt16(long value)
		{
			if (value < -32768L || value > 32767L)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x0600089C RID: 2204 RVA: 0x00023F15 File Offset: 0x00022115
		[CLSCompliant(false)]
		public static short ToInt16(ulong value)
		{
			if (value > 32767UL)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 16-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int16.MaxValue" /> или меньше <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x0600089D RID: 2205 RVA: 0x00023F27 File Offset: 0x00022127
		public static short ToInt16(float value)
		{
			return Convert.ToInt16((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 16-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int16.MaxValue" /> или меньше <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x0600089E RID: 2206 RVA: 0x00023F30 File Offset: 0x00022130
		public static short ToInt16(double value)
		{
			return Convert.ToInt16(Convert.ToInt32(value));
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 16-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int16.MaxValue" /> или меньше <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x0600089F RID: 2207 RVA: 0x00023F3D File Offset: 0x0002213D
		public static short ToInt16(decimal value)
		{
			return decimal.ToInt16(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 16-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x060008A0 RID: 2208 RVA: 0x00023F4B File Offset: 0x0002214B
		public static short ToInt16(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return short.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 16-битовое целое число со знаком, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x060008A1 RID: 2209 RVA: 0x00023F5D File Offset: 0x0002215D
		public static short ToInt16(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return short.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060008A2 RID: 2210 RVA: 0x00023F6C File Offset: 0x0002216C
		public static short ToInt16(DateTime value)
		{
			return ((IConvertible)value).ToInt16(null);
		}

		/// <summary>Преобразует значение заданного объекта в 16-битовое целое число без знака.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>16-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008A3 RID: 2211 RVA: 0x00023F7A File Offset: 0x0002217A
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt16(null);
			}
			return 0;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 16-битовое целое число без знака, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>16-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008A4 RID: 2212 RVA: 0x00023F8D File Offset: 0x0002218D
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt16(provider);
			}
			return 0;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x060008A5 RID: 2213 RVA: 0x00023D06 File Offset: 0x00021F06
		[CLSCompliant(false)]
		public static ushort ToUInt16(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>16-разрядное целое число без знака, эквивалентное <paramref name="value" />.</returns>
		// Token: 0x060008A6 RID: 2214 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static ushort ToUInt16(char value)
		{
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008A7 RID: 2215 RVA: 0x00023FA0 File Offset: 0x000221A0
		[CLSCompliant(false)]
		public static ushort ToUInt16(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа без знака в эквивалентное 16-разрядное целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008A8 RID: 2216 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte value)
		{
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008A9 RID: 2217 RVA: 0x00023FA0 File Offset: 0x000221A0
		[CLSCompliant(false)]
		public static ushort ToUInt16(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008AA RID: 2218 RVA: 0x00023FAD File Offset: 0x000221AD
		[CLSCompliant(false)]
		public static ushort ToUInt16(int value)
		{
			if (value < 0 || value > 65535)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Возвращает заданное 16-битовое целое число без знака; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 16-разрядное целое число без знака.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x060008AB RID: 2219 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static ushort ToUInt16(ushort value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 32-разрядного целого числа без знака в эквивалентное 16-разрядное целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008AC RID: 2220 RVA: 0x00023FC2 File Offset: 0x000221C2
		[CLSCompliant(false)]
		public static ushort ToUInt16(uint value)
		{
			if (value > 65535U)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008AD RID: 2221 RVA: 0x00023FD3 File Offset: 0x000221D3
		[CLSCompliant(false)]
		public static ushort ToUInt16(long value)
		{
			if (value < 0L || value > 65535L)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентное 16-разрядное целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008AE RID: 2222 RVA: 0x00023FEA File Offset: 0x000221EA
		[CLSCompliant(false)]
		public static ushort ToUInt16(ulong value)
		{
			if (value > 65535UL)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 16-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008AF RID: 2223 RVA: 0x00023FFC File Offset: 0x000221FC
		[CLSCompliant(false)]
		public static ushort ToUInt16(float value)
		{
			return Convert.ToUInt16((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 16-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008B0 RID: 2224 RVA: 0x00024005 File Offset: 0x00022205
		[CLSCompliant(false)]
		public static ushort ToUInt16(double value)
		{
			return Convert.ToUInt16(Convert.ToInt32(value));
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 16-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008B1 RID: 2225 RVA: 0x00024012 File Offset: 0x00022212
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			return decimal.ToUInt16(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 16-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008B2 RID: 2226 RVA: 0x00024020 File Offset: 0x00022220
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return ushort.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 16-битовое целое число без знака, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060008B3 RID: 2227 RVA: 0x00024032 File Offset: 0x00022232
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return ushort.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060008B4 RID: 2228 RVA: 0x00024041 File Offset: 0x00022241
		[CLSCompliant(false)]
		public static ushort ToUInt16(DateTime value)
		{
			return ((IConvertible)value).ToUInt16(null);
		}

		/// <summary>Преобразует значение заданного объекта в 32-битовое целое число со знаком.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>32-разрядное целое число со знаком, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060008B5 RID: 2229 RVA: 0x0002404F File Offset: 0x0002224F
		public static int ToInt32(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt32(null);
			}
			return 0;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 32-битовое целое число со знаком, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>32-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060008B6 RID: 2230 RVA: 0x00024062 File Offset: 0x00022262
		public static int ToInt32(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt32(provider);
			}
			return 0;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x060008B7 RID: 2231 RVA: 0x00023D06 File Offset: 0x00021F06
		public static int ToInt32(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008B8 RID: 2232 RVA: 0x0000270D File Offset: 0x0000090D
		public static int ToInt32(char value)
		{
			return (int)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа со знаком в эквивалентное 32-разрядное целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008B9 RID: 2233 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static int ToInt32(sbyte value)
		{
			return (int)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008BA RID: 2234 RVA: 0x0000270D File Offset: 0x0000090D
		public static int ToInt32(byte value)
		{
			return (int)value;
		}

		/// <summary>Преобразует значение заданного 16-разрядного целого числа со знаком в эквивалентное 32-разрядное целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008BB RID: 2235 RVA: 0x0000270D File Offset: 0x0000090D
		public static int ToInt32(short value)
		{
			return (int)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008BC RID: 2236 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static int ToInt32(ushort value)
		{
			return (int)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060008BD RID: 2237 RVA: 0x00024075 File Offset: 0x00022275
		[CLSCompliant(false)]
		public static int ToInt32(uint value)
		{
			if (value > 2147483647U)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		/// <summary>Возвращает заданное 32-битовое целое число со знаком; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 32-разрядное целое число со знаком.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x060008BE RID: 2238 RVA: 0x0000270D File Offset: 0x0000090D
		public static int ToInt32(int value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа со знаком в эквивалентное 32-разрядное целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int32.MaxValue" /> или меньше <see cref="F:System.Int32.MinValue" />.</exception>
		// Token: 0x060008BF RID: 2239 RVA: 0x00024085 File Offset: 0x00022285
		public static int ToInt32(long value)
		{
			if (value < -2147483648L || value > 2147483647L)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентное 32-разрядное целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060008C0 RID: 2240 RVA: 0x000240A0 File Offset: 0x000222A0
		[CLSCompliant(false)]
		public static int ToInt32(ulong value)
		{
			if (value > 2147483647UL)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 32-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int32.MaxValue" /> или меньше <see cref="F:System.Int32.MinValue" />.</exception>
		// Token: 0x060008C1 RID: 2241 RVA: 0x000240B2 File Offset: 0x000222B2
		public static int ToInt32(float value)
		{
			return Convert.ToInt32((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 32-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int32.MaxValue" /> или меньше <see cref="F:System.Int32.MinValue" />.</exception>
		// Token: 0x060008C2 RID: 2242 RVA: 0x000240BC File Offset: 0x000222BC
		public static int ToInt32(double value)
		{
			if (value >= 0.0)
			{
				if (value < 2147483647.5)
				{
					int num = (int)value;
					double num2 = value - (double)num;
					if (num2 > 0.5 || (num2 == 0.5 && (num & 1) != 0))
					{
						num++;
					}
					return num;
				}
			}
			else if (value >= -2147483648.5)
			{
				int num3 = (int)value;
				double num4 = value - (double)num3;
				if (num4 < -0.5 || (num4 == -0.5 && (num3 & 1) != 0))
				{
					num3--;
				}
				return num3;
			}
			throw new OverflowException("Value was either too large or too small for an Int32.");
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 32-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int32.MaxValue" /> или меньше <see cref="F:System.Int32.MinValue" />.</exception>
		// Token: 0x060008C3 RID: 2243 RVA: 0x0002414D File Offset: 0x0002234D
		public static int ToInt32(decimal value)
		{
			return decimal.ToInt32(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060008C4 RID: 2244 RVA: 0x0002415B File Offset: 0x0002235B
		public static int ToInt32(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return int.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число со знаком, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060008C5 RID: 2245 RVA: 0x0002416D File Offset: 0x0002236D
		public static int ToInt32(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return int.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060008C6 RID: 2246 RVA: 0x0002417C File Offset: 0x0002237C
		public static int ToInt32(DateTime value)
		{
			return ((IConvertible)value).ToInt32(null);
		}

		/// <summary>Преобразует значение заданного объекта в 32-битовое целое число без знака.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>32-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль (0), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008C7 RID: 2247 RVA: 0x0002418A File Offset: 0x0002238A
		[CLSCompliant(false)]
		public static uint ToUInt32(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt32(null);
			}
			return 0U;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 32-битовое целое число без знака, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>32-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008C8 RID: 2248 RVA: 0x0002419D File Offset: 0x0002239D
		[CLSCompliant(false)]
		public static uint ToUInt32(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt32(provider);
			}
			return 0U;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x060008C9 RID: 2249 RVA: 0x00023D06 File Offset: 0x00021F06
		[CLSCompliant(false)]
		public static uint ToUInt32(bool value)
		{
			if (!value)
			{
				return 0U;
			}
			return 1U;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008CA RID: 2250 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static uint ToUInt32(char value)
		{
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008CB RID: 2251 RVA: 0x000241B0 File Offset: 0x000223B0
		[CLSCompliant(false)]
		public static uint ToUInt32(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008CC RID: 2252 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static uint ToUInt32(byte value)
		{
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008CD RID: 2253 RVA: 0x000241B0 File Offset: 0x000223B0
		[CLSCompliant(false)]
		public static uint ToUInt32(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008CE RID: 2254 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static uint ToUInt32(ushort value)
		{
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008CF RID: 2255 RVA: 0x000241B0 File Offset: 0x000223B0
		[CLSCompliant(false)]
		public static uint ToUInt32(int value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Возвращает заданное 32-битовое целое число без знака; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 32-разрядное целое число без знака.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x060008D0 RID: 2256 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static uint ToUInt32(uint value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D1 RID: 2257 RVA: 0x000241BC File Offset: 0x000223BC
		[CLSCompliant(false)]
		public static uint ToUInt32(long value)
		{
			if (value < 0L || value > (long)((ulong)-1))
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентное 32-разрядное целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D2 RID: 2258 RVA: 0x000241CF File Offset: 0x000223CF
		[CLSCompliant(false)]
		public static uint ToUInt32(ulong value)
		{
			if (value > (ulong)-1)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 32-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D3 RID: 2259 RVA: 0x000241DD File Offset: 0x000223DD
		[CLSCompliant(false)]
		public static uint ToUInt32(float value)
		{
			return Convert.ToUInt32((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 32-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D4 RID: 2260 RVA: 0x000241E8 File Offset: 0x000223E8
		[CLSCompliant(false)]
		public static uint ToUInt32(double value)
		{
			if (value >= -0.5 && value < 4294967295.5)
			{
				uint num = (uint)value;
				double num2 = value - num;
				if (num2 > 0.5 || (num2 == 0.5 && (num & 1U) != 0U))
				{
					num += 1U;
				}
				return num;
			}
			throw new OverflowException("Value was either too large or too small for a UInt32.");
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 32-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D5 RID: 2261 RVA: 0x00024243 File Offset: 0x00022443
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal value)
		{
			return decimal.ToUInt32(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D6 RID: 2262 RVA: 0x00024251 File Offset: 0x00022451
		[CLSCompliant(false)]
		public static uint ToUInt32(string value)
		{
			if (value == null)
			{
				return 0U;
			}
			return uint.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число без знака, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060008D7 RID: 2263 RVA: 0x00024263 File Offset: 0x00022463
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0U;
			}
			return uint.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060008D8 RID: 2264 RVA: 0x00024272 File Offset: 0x00022472
		[CLSCompliant(false)]
		public static uint ToUInt32(DateTime value)
		{
			return ((IConvertible)value).ToUInt32(null);
		}

		/// <summary>Преобразует значение заданного объекта в 64-битовое целое число со знаком.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>64-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int64.MinValue" /> или больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060008D9 RID: 2265 RVA: 0x00024280 File Offset: 0x00022480
		public static long ToInt64(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt64(null);
			}
			return 0L;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 64-битовое целое число со знаком, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>64-разрядное знаковое целое число, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int64.MinValue" /> или больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060008DA RID: 2266 RVA: 0x00024294 File Offset: 0x00022494
		public static long ToInt64(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt64(provider);
			}
			return 0L;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x060008DB RID: 2267 RVA: 0x000242A8 File Offset: 0x000224A8
		public static long ToInt64(bool value)
		{
			return value ? 1L : 0L;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008DC RID: 2268 RVA: 0x000242B2 File Offset: 0x000224B2
		public static long ToInt64(char value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа со знаком в эквивалентное 64-разрядное целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008DD RID: 2269 RVA: 0x000242B6 File Offset: 0x000224B6
		[CLSCompliant(false)]
		public static long ToInt64(sbyte value)
		{
			return (long)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008DE RID: 2270 RVA: 0x000242B2 File Offset: 0x000224B2
		public static long ToInt64(byte value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008DF RID: 2271 RVA: 0x000242B6 File Offset: 0x000224B6
		public static long ToInt64(short value)
		{
			return (long)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008E0 RID: 2272 RVA: 0x000242B2 File Offset: 0x000224B2
		[CLSCompliant(false)]
		public static long ToInt64(ushort value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008E1 RID: 2273 RVA: 0x000242B6 File Offset: 0x000224B6
		public static long ToInt64(int value)
		{
			return (long)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008E2 RID: 2274 RVA: 0x000242B2 File Offset: 0x000224B2
		[CLSCompliant(false)]
		public static long ToInt64(uint value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> больше значения <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060008E3 RID: 2275 RVA: 0x000242BA File Offset: 0x000224BA
		[CLSCompliant(false)]
		public static long ToInt64(ulong value)
		{
			if (value > 9223372036854775807UL)
			{
				Convert.ThrowInt64OverflowException();
			}
			return (long)value;
		}

		/// <summary>Возвращает заданное 64-битовое целое число со знаком; фактическое преобразование не производится.</summary>
		/// <param name="value">64-разрядное целое число со знаком.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x060008E4 RID: 2276 RVA: 0x0000270D File Offset: 0x0000090D
		public static long ToInt64(long value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 64-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int64.MaxValue" /> или меньше <see cref="F:System.Int64.MinValue" />.</exception>
		// Token: 0x060008E5 RID: 2277 RVA: 0x000242CE File Offset: 0x000224CE
		public static long ToInt64(float value)
		{
			return Convert.ToInt64((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 64-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int64.MaxValue" /> или меньше <see cref="F:System.Int64.MinValue" />.</exception>
		// Token: 0x060008E6 RID: 2278 RVA: 0x000242D7 File Offset: 0x000224D7
		public static long ToInt64(double value)
		{
			return checked((long)Math.Round(value));
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 64-разрядного целого числа со знаком. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Int64.MaxValue" /> или меньше <see cref="F:System.Int64.MinValue" />.</exception>
		// Token: 0x060008E7 RID: 2279 RVA: 0x000242E0 File Offset: 0x000224E0
		public static long ToInt64(decimal value)
		{
			return decimal.ToInt64(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 64-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int64.MinValue" /> или больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060008E8 RID: 2280 RVA: 0x000242EE File Offset: 0x000224EE
		public static long ToInt64(string value)
		{
			if (value == null)
			{
				return 0L;
			}
			return long.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 64-битовое целое число со знаком, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int64.MinValue" /> или больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060008E9 RID: 2281 RVA: 0x00024301 File Offset: 0x00022501
		public static long ToInt64(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0L;
			}
			return long.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060008EA RID: 2282 RVA: 0x00024311 File Offset: 0x00022511
		public static long ToInt64(DateTime value)
		{
			return ((IConvertible)value).ToInt64(null);
		}

		/// <summary>Преобразует значение заданного объекта в 64-битовое целое число без знака.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>64-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008EB RID: 2283 RVA: 0x0002431F File Offset: 0x0002251F
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt64(null);
			}
			return 0UL;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное 64-битовое целое число без знака, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>64-разрядное целое число без знака, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008EC RID: 2284 RVA: 0x00024333 File Offset: 0x00022533
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt64(provider);
			}
			return 0UL;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x060008ED RID: 2285 RVA: 0x00024347 File Offset: 0x00022547
		[CLSCompliant(false)]
		public static ulong ToUInt64(bool value)
		{
			if (!value)
			{
				return 0UL;
			}
			return 1UL;
		}

		/// <summary>Преобразует значение заданного символа Юникода в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008EE RID: 2286 RVA: 0x000242B2 File Offset: 0x000224B2
		[CLSCompliant(false)]
		public static ulong ToUInt64(char value)
		{
			return (ulong)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008EF RID: 2287 RVA: 0x00024351 File Offset: 0x00022551
		[CLSCompliant(false)]
		public static ulong ToUInt64(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008F0 RID: 2288 RVA: 0x000242B2 File Offset: 0x000224B2
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte value)
		{
			return (ulong)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008F1 RID: 2289 RVA: 0x00024351 File Offset: 0x00022551
		[CLSCompliant(false)]
		public static ulong ToUInt64(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008F2 RID: 2290 RVA: 0x000242B2 File Offset: 0x000224B2
		[CLSCompliant(false)]
		public static ulong ToUInt64(ushort value)
		{
			return (ulong)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008F3 RID: 2291 RVA: 0x00024351 File Offset: 0x00022551
		[CLSCompliant(false)]
		public static ulong ToUInt64(int value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		/// <summary>Преобразует значение заданного 32-разрядного целого числа без знака в эквивалентное 64-разрядное целое число без знака.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008F4 RID: 2292 RVA: 0x000242B2 File Offset: 0x000224B2
		[CLSCompliant(false)]
		public static ulong ToUInt64(uint value)
		{
			return (ulong)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение параметра <paramref name="value" /> меньше нуля.</exception>
		// Token: 0x060008F5 RID: 2293 RVA: 0x0002435E File Offset: 0x0002255E
		[CLSCompliant(false)]
		public static ulong ToUInt64(long value)
		{
			if (value < 0L)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)value;
		}

		/// <summary>Возвращает заданное 64-битовое целое число без знака; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое 64-разрядное целое число без знака.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x060008F6 RID: 2294 RVA: 0x0000270D File Offset: 0x0000090D
		[CLSCompliant(false)]
		public static ulong ToUInt64(ulong value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 64-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008F7 RID: 2295 RVA: 0x0002436B File Offset: 0x0002256B
		[CLSCompliant(false)]
		public static ulong ToUInt64(float value)
		{
			return Convert.ToUInt64((double)value);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 64-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008F8 RID: 2296 RVA: 0x00024374 File Offset: 0x00022574
		[CLSCompliant(false)]
		public static ulong ToUInt64(double value)
		{
			return checked((ulong)Math.Round(value));
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Значение <paramref name="value" />, округленное до ближайшего 64-разрядного целого числа без знака. Если <paramref name="value" /> имеет среднее значение между двумя целыми числами, будет возвращено четное число; так, значение 4,5 преобразуется в 4, а 5,5 — в 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше нуля или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008F9 RID: 2297 RVA: 0x0002437D File Offset: 0x0002257D
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal value)
		{
			return decimal.ToUInt64(decimal.Round(value, 0));
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 64-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008FA RID: 2298 RVA: 0x0002438B File Offset: 0x0002258B
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value)
		{
			if (value == null)
			{
				return 0UL;
			}
			return ulong.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное 64-битовое целое число без знака, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060008FB RID: 2299 RVA: 0x0002439E File Offset: 0x0002259E
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0UL;
			}
			return ulong.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060008FC RID: 2300 RVA: 0x000243AE File Offset: 0x000225AE
		[CLSCompliant(false)]
		public static ulong ToUInt64(DateTime value)
		{
			return ((IConvertible)value).ToUInt64(null);
		}

		/// <summary>Преобразует значение заданного объекта в число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x060008FD RID: 2301 RVA: 0x000243BC File Offset: 0x000225BC
		public static float ToSingle(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSingle(null);
			}
			return 0f;
		}

		/// <summary>Преобразует значение заданного объекта в число с плавающей запятой одиночной точности, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="value" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x060008FE RID: 2302 RVA: 0x000243D3 File Offset: 0x000225D3
		public static float ToSingle(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSingle(provider);
			}
			return 0f;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное знаковое целое число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x060008FF RID: 2303 RVA: 0x000243EA File Offset: 0x000225EA
		[CLSCompliant(false)]
		public static float ToSingle(sbyte value)
		{
			return (float)value;
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000900 RID: 2304 RVA: 0x000243EA File Offset: 0x000225EA
		public static float ToSingle(byte value)
		{
			return (float)value;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000901 RID: 2305 RVA: 0x000243EE File Offset: 0x000225EE
		public static float ToSingle(char value)
		{
			return ((IConvertible)value).ToSingle(null);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000902 RID: 2306 RVA: 0x000243EA File Offset: 0x000225EA
		public static float ToSingle(short value)
		{
			return (float)value;
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000903 RID: 2307 RVA: 0x000243EA File Offset: 0x000225EA
		[CLSCompliant(false)]
		public static float ToSingle(ushort value)
		{
			return (float)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000904 RID: 2308 RVA: 0x000243EA File Offset: 0x000225EA
		public static float ToSingle(int value)
		{
			return (float)value;
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000905 RID: 2309 RVA: 0x000243FC File Offset: 0x000225FC
		[CLSCompliant(false)]
		public static float ToSingle(uint value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000906 RID: 2310 RVA: 0x000243EA File Offset: 0x000225EA
		public static float ToSingle(long value)
		{
			return (float)value;
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000907 RID: 2311 RVA: 0x000243FC File Offset: 0x000225FC
		[CLSCompliant(false)]
		public static float ToSingle(ulong value)
		{
			return value;
		}

		/// <summary>Возвращает заданное число с плавающей запятой одиночной точности; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое число с плавающей запятой одиночной точности.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000908 RID: 2312 RVA: 0x0000270D File Offset: 0x0000090D
		public static float ToSingle(float value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.  
		///  Значение <paramref name="value" /> округляется до ближайшего числа. Например, при округлении до второго знака после десятичной запятой значение 2,345 преобразуется в 2,34, а значение 2,355 — в 2,36.</returns>
		// Token: 0x06000909 RID: 2313 RVA: 0x000243EA File Offset: 0x000225EA
		public static float ToSingle(double value)
		{
			return (float)value;
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Число с плавающей запятой одиночной точности, которое эквивалентно значению <paramref name="value" />.  
		///  Значение <paramref name="value" /> округляется до ближайшего числа. Например, при округлении до второго знака после десятичной запятой значение 2,345 преобразуется в 2,34, а значение 2,355 — в 2,36.</returns>
		// Token: 0x0600090A RID: 2314 RVA: 0x00024401 File Offset: 0x00022601
		public static float ToSingle(decimal value)
		{
			return (float)value;
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное числу <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x0600090B RID: 2315 RVA: 0x0002440A File Offset: 0x0002260A
		public static float ToSingle(string value)
		{
			if (value == null)
			{
				return 0f;
			}
			return float.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное число с плавающей запятой одиночной точности, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное числу <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x0600090C RID: 2316 RVA: 0x00024420 File Offset: 0x00022620
		public static float ToSingle(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0f;
			}
			return float.Parse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное число с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x0600090D RID: 2317 RVA: 0x00024437 File Offset: 0x00022637
		public static float ToSingle(bool value)
		{
			return (float)(value ? 1 : 0);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600090E RID: 2318 RVA: 0x00024441 File Offset: 0x00022641
		public static float ToSingle(DateTime value)
		{
			return ((IConvertible)value).ToSingle(null);
		}

		/// <summary>Преобразует значение заданного объекта в число с плавающей запятой двойной точности.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>Число с плавающей запятой двойной точности, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат для типа <see cref="T:System.Double" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x0600090F RID: 2319 RVA: 0x0002444F File Offset: 0x0002264F
		public static double ToDouble(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDouble(null);
			}
			return 0.0;
		}

		/// <summary>Преобразует значение заданного объекта в число с плавающей запятой двойной точности, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой двойной точности, эквивалентное значению <paramref name="value" />, или нуль, если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат для типа <see cref="T:System.Double" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x06000910 RID: 2320 RVA: 0x0002446A File Offset: 0x0002266A
		public static double ToDouble(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDouble(provider);
			}
			return 0.0;
		}

		/// <summary>Преобразует значение заданного 8-разрядного знакового целого числа в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>8-разрядное целое число со знаком, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000911 RID: 2321 RVA: 0x00024485 File Offset: 0x00022685
		[CLSCompliant(false)]
		public static double ToDouble(sbyte value)
		{
			return (double)value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа без знака в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000912 RID: 2322 RVA: 0x00024485 File Offset: 0x00022685
		public static double ToDouble(byte value)
		{
			return (double)value;
		}

		/// <summary>Преобразует значение заданного 16-разрядного знакового целого числа в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, эквивалентное значению <paramref name="value" />.</returns>
		// Token: 0x06000913 RID: 2323 RVA: 0x00024485 File Offset: 0x00022685
		public static double ToDouble(short value)
		{
			return (double)value;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000914 RID: 2324 RVA: 0x00024489 File Offset: 0x00022689
		public static double ToDouble(char value)
		{
			return ((IConvertible)value).ToDouble(null);
		}

		/// <summary>Преобразует значение заданного 16-разрядного целого числа без знака в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000915 RID: 2325 RVA: 0x00024485 File Offset: 0x00022685
		[CLSCompliant(false)]
		public static double ToDouble(ushort value)
		{
			return (double)value;
		}

		/// <summary>Преобразует значение заданного 32-разрядного знакового целого числа в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000916 RID: 2326 RVA: 0x00024485 File Offset: 0x00022685
		public static double ToDouble(int value)
		{
			return (double)value;
		}

		/// <summary>Преобразует значение заданного 32-разрядного целого числа без знака в эквивалентное число двойной точности с плавающей запятой.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000917 RID: 2327 RVA: 0x00024497 File Offset: 0x00022697
		[CLSCompliant(false)]
		public static double ToDouble(uint value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного знакового целого числа в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000918 RID: 2328 RVA: 0x00024485 File Offset: 0x00022685
		public static double ToDouble(long value)
		{
			return (double)value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентное число двойной точности с плавающей запятой.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000919 RID: 2329 RVA: 0x00024497 File Offset: 0x00022697
		[CLSCompliant(false)]
		public static double ToDouble(ulong value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одинарной точности в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x0600091A RID: 2330 RVA: 0x00024485 File Offset: 0x00022685
		public static double ToDouble(float value)
		{
			return (double)value;
		}

		/// <summary>Возвращает заданное число с плавающей запятой двойной точности; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемое число с плавающей запятой двойной точности.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x0600091B RID: 2331 RVA: 0x0000270D File Offset: 0x0000090D
		public static double ToDouble(double value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x0600091C RID: 2332 RVA: 0x0002449C File Offset: 0x0002269C
		public static double ToDouble(decimal value)
		{
			return (double)value;
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>Число с плавающей запятой двойной точности, эквивалентное числу <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x0600091D RID: 2333 RVA: 0x000244A5 File Offset: 0x000226A5
		public static double ToDouble(string value)
		{
			if (value == null)
			{
				return 0.0;
			}
			return double.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное число с плавающей запятой двойной точности, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой двойной точности, эквивалентное числу <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x0600091E RID: 2334 RVA: 0x000244BF File Offset: 0x000226BF
		public static double ToDouble(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0.0;
			}
			return double.Parse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное число с плавающей запятой двойной точности.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x0600091F RID: 2335 RVA: 0x000244DA File Offset: 0x000226DA
		public static double ToDouble(bool value)
		{
			return (double)(value ? 1 : 0);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000920 RID: 2336 RVA: 0x000244E4 File Offset: 0x000226E4
		public static double ToDouble(DateTime value)
		{
			return ((IConvertible)value).ToDouble(null);
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное десятичное число.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>Десятичное число, эквивалентное <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> равняется <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат для типа <see cref="T:System.Decimal" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Decimal.MinValue" /> или больше <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x06000921 RID: 2337 RVA: 0x000244F2 File Offset: 0x000226F2
		public static decimal ToDecimal(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDecimal(null);
			}
			return 0m;
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное десятичное число, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Десятичное число, эквивалентное <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> равняется <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат для типа <see cref="T:System.Decimal" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Decimal.MinValue" /> или больше <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x06000922 RID: 2338 RVA: 0x00024509 File Offset: 0x00022709
		public static decimal ToDecimal(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDecimal(provider);
			}
			return 0m;
		}

		/// <summary>Преобразует значение заданного 8-разрядного знакового целого числа в эквивалентное десятичное число.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000923 RID: 2339 RVA: 0x00024520 File Offset: 0x00022720
		[CLSCompliant(false)]
		public static decimal ToDecimal(sbyte value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого число без знака в эквивалентное десятичное число.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000924 RID: 2340 RVA: 0x00024528 File Offset: 0x00022728
		public static decimal ToDecimal(byte value)
		{
			return value;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000925 RID: 2341 RVA: 0x00024530 File Offset: 0x00022730
		public static decimal ToDecimal(char value)
		{
			return ((IConvertible)value).ToDecimal(null);
		}

		/// <summary>Преобразует значение заданного 16-разрядного знакового целого числа в эквивалентное десятичное число.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000926 RID: 2342 RVA: 0x0002453E File Offset: 0x0002273E
		public static decimal ToDecimal(short value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 16-разрядного целого числа без знака в эквивалентное десятичное число.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000927 RID: 2343 RVA: 0x00024546 File Offset: 0x00022746
		[CLSCompliant(false)]
		public static decimal ToDecimal(ushort value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 32-разрядного знакового целого числа в эквивалентное десятичное число.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000928 RID: 2344 RVA: 0x0002454E File Offset: 0x0002274E
		public static decimal ToDecimal(int value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 32-разрядного целого числа без знака в эквивалентное десятичное число.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x06000929 RID: 2345 RVA: 0x00024556 File Offset: 0x00022756
		[CLSCompliant(false)]
		public static decimal ToDecimal(uint value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного знакового целого числа в эквивалентное десятичное число.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x0600092A RID: 2346 RVA: 0x0002455E File Offset: 0x0002275E
		public static decimal ToDecimal(long value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в эквивалентное десятичное число.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		// Token: 0x0600092B RID: 2347 RVA: 0x00024566 File Offset: 0x00022766
		[CLSCompliant(false)]
		public static decimal ToDecimal(ulong value)
		{
			return value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное десятичное число.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Decimal.MaxValue" /> или меньше <see cref="F:System.Decimal.MinValue" />.</exception>
		// Token: 0x0600092C RID: 2348 RVA: 0x0002456E File Offset: 0x0002276E
		public static decimal ToDecimal(float value)
		{
			return (decimal)value;
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное десятичное число.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Десятичное число, которое эквивалентно значению <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> больше <see cref="F:System.Decimal.MaxValue" /> или меньше <see cref="F:System.Decimal.MinValue" />.</exception>
		// Token: 0x0600092D RID: 2349 RVA: 0x00024576 File Offset: 0x00022776
		public static decimal ToDecimal(double value)
		{
			return (decimal)value;
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное десятичное число.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>Десятичное число, эквивалентное числу <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> равняется <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Decimal.MinValue" /> или больше <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x0600092E RID: 2350 RVA: 0x0002457E File Offset: 0x0002277E
		public static decimal ToDecimal(string value)
		{
			if (value == null)
			{
				return 0m;
			}
			return decimal.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное десятичное число, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Десятичное число, эквивалентное числу <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> равняется <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Decimal.MinValue" /> или больше <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x0600092F RID: 2351 RVA: 0x00024594 File Offset: 0x00022794
		public static decimal ToDecimal(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0m;
			}
			return decimal.Parse(value, NumberStyles.Number, provider);
		}

		/// <summary>Возвращает заданное десятичное число; фактическое преобразование не производится.</summary>
		/// <param name="value">Десятичное число.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000930 RID: 2352 RVA: 0x0000270D File Offset: 0x0000090D
		public static decimal ToDecimal(decimal value)
		{
			return value;
		}

		/// <summary>Преобразует заданное логическое значение в эквивалентное десятичное число.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Число 1, если <paramref name="value" /> имеет значение <see langword="true" />; в противном случае — 0.</returns>
		// Token: 0x06000931 RID: 2353 RVA: 0x000245A8 File Offset: 0x000227A8
		public static decimal ToDecimal(bool value)
		{
			return value ? 1 : 0;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000932 RID: 2354 RVA: 0x000245B6 File Offset: 0x000227B6
		public static decimal ToDecimal(DateTime value)
		{
			return ((IConvertible)value).ToDecimal(null);
		}

		/// <summary>Возвращает заданный объект <see cref="T:System.DateTime" />; фактическое преобразование не производится.</summary>
		/// <param name="value">Значение даты и времени.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000933 RID: 2355 RVA: 0x0000270D File Offset: 0x0000090D
		public static DateTime ToDateTime(DateTime value)
		{
			return value;
		}

		/// <summary>Преобразует значение указанного объекта в объект <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />, или значение <see langword="null" />.</param>
		/// <returns>Дата и время, эквивалентные значению <paramref name="value" />, или дата и время, эквивалентные значению <see cref="F:System.DateTime.MinValue" />, если значение <paramref name="value" /> равно <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является допустимым значением даты и времени.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		// Token: 0x06000934 RID: 2356 RVA: 0x000245C4 File Offset: 0x000227C4
		public static DateTime ToDateTime(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDateTime(null);
			}
			return DateTime.MinValue;
		}

		/// <summary>Преобразует значение заданного объекта в объект <see cref="T:System.DateTime" />, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Объект, реализующий интерфейс <see cref="T:System.IConvertible" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Дата и время, эквивалентные значению <paramref name="value" />, или дата и время, эквивалентные значению <see cref="F:System.DateTime.MinValue" />, если значение <paramref name="value" /> равно <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не является допустимым значением даты и времени.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IConvertible" />.  
		///
		/// или - 
		/// Преобразование не поддерживается.</exception>
		// Token: 0x06000935 RID: 2357 RVA: 0x000245DB File Offset: 0x000227DB
		public static DateTime ToDateTime(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDateTime(provider);
			}
			return DateTime.MinValue;
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в эквивалентное значение даты и времени.</summary>
		/// <param name="value">Строковое представление даты и времени.</param>
		/// <returns>Дата и время, эквивалентные значению <paramref name="value" />, или дата и время, эквивалентные значению <see cref="F:System.DateTime.MinValue" />, если значение <paramref name="value" /> равно <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> является неправильно отформатированной строкой даты и времени.</exception>
		// Token: 0x06000936 RID: 2358 RVA: 0x000245F2 File Offset: 0x000227F2
		public static DateTime ToDateTime(string value)
		{
			if (value == null)
			{
				return new DateTime(0L);
			}
			return DateTime.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует заданное строковое представление числа в эквивалентное значение даты и времени, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Дата и время, эквивалентные значению <paramref name="value" />, или дата и время, эквивалентные значению <see cref="F:System.DateTime.MinValue" />, если значение <paramref name="value" /> равно <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> является неправильно отформатированной строкой даты и времени.</exception>
		// Token: 0x06000937 RID: 2359 RVA: 0x0002460A File Offset: 0x0002280A
		public static DateTime ToDateTime(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return new DateTime(0L);
			}
			return DateTime.Parse(value, provider);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000938 RID: 2360 RVA: 0x0002461E File Offset: 0x0002281E
		[CLSCompliant(false)]
		public static DateTime ToDateTime(sbyte value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000939 RID: 2361 RVA: 0x0002462C File Offset: 0x0002282C
		public static DateTime ToDateTime(byte value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600093A RID: 2362 RVA: 0x0002463A File Offset: 0x0002283A
		public static DateTime ToDateTime(short value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600093B RID: 2363 RVA: 0x00024648 File Offset: 0x00022848
		[CLSCompliant(false)]
		public static DateTime ToDateTime(ushort value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600093C RID: 2364 RVA: 0x00024656 File Offset: 0x00022856
		public static DateTime ToDateTime(int value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600093D RID: 2365 RVA: 0x00024664 File Offset: 0x00022864
		[CLSCompliant(false)]
		public static DateTime ToDateTime(uint value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600093E RID: 2366 RVA: 0x00024672 File Offset: 0x00022872
		public static DateTime ToDateTime(long value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x0600093F RID: 2367 RVA: 0x00024680 File Offset: 0x00022880
		[CLSCompliant(false)]
		public static DateTime ToDateTime(ulong value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000940 RID: 2368 RVA: 0x0002468E File Offset: 0x0002288E
		public static DateTime ToDateTime(bool value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000941 RID: 2369 RVA: 0x0002469C File Offset: 0x0002289C
		public static DateTime ToDateTime(char value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000942 RID: 2370 RVA: 0x000246AA File Offset: 0x000228AA
		public static DateTime ToDateTime(float value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Значение с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000943 RID: 2371 RVA: 0x000246B8 File Offset: 0x000228B8
		public static DateTime ToDateTime(double value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000944 RID: 2372 RVA: 0x000246C6 File Offset: 0x000228C6
		public static DateTime ToDateTime(decimal value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Преобразует значение заданного объекта в эквивалентное строковое представление.</summary>
		/// <param name="value">Объект, содержащий значение для преобразования, или <see langword="null" />.</param>
		/// <returns>Строковое представление имеет значение <paramref name="value" /> или <see cref="F:System.String.Empty" />, если значение параметра <paramref name="value" /> равно <see langword="null" />.</returns>
		// Token: 0x06000945 RID: 2373 RVA: 0x000246D4 File Offset: 0x000228D4
		public static string ToString(object value)
		{
			return Convert.ToString(value, null);
		}

		/// <summary>Преобразует значение указанного объекта в эквивалентное строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="value">Объект, содержащий значение для преобразования, или <see langword="null" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения параметра <paramref name="value" /> или <see cref="F:System.String.Empty" />, если <paramref name="value" /> представляет собой объект, значение которого равно <see langword="null" />. Если значением параметра <paramref name="value" /> является <see langword="null" />, метод возвращает <see langword="null" />.</returns>
		// Token: 0x06000946 RID: 2374 RVA: 0x000246E0 File Offset: 0x000228E0
		public static string ToString(object value, IFormatProvider provider)
		{
			IConvertible convertible = value as IConvertible;
			if (convertible != null)
			{
				return convertible.ToString(provider);
			}
			IFormattable formattable = value as IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(null, provider);
			}
			if (value != null)
			{
				return value.ToString();
			}
			return string.Empty;
		}

		/// <summary>Преобразует указанное логическое значение в эквивалентное строковое представление.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000947 RID: 2375 RVA: 0x00024721 File Offset: 0x00022921
		public static string ToString(bool value)
		{
			return value.ToString();
		}

		/// <summary>Преобразует указанное логическое значение в эквивалентное строковое представление.</summary>
		/// <param name="value">Логическое значение, которое необходимо преобразовать.</param>
		/// <param name="provider">Экземпляр объекта. Этот параметр не учитывается.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000948 RID: 2376 RVA: 0x00024721 File Offset: 0x00022921
		public static string ToString(bool value, IFormatProvider provider)
		{
			return value.ToString();
		}

		/// <summary>Преобразует значение заданного знака Юникода в эквивалентное строковое представление.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000949 RID: 2377 RVA: 0x0002472A File Offset: 0x0002292A
		public static string ToString(char value)
		{
			return char.ToString(value);
		}

		/// <summary>Преобразует значение заданного знака Юникода в эквивалентное строковое представление, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Знак Юникода, который необходимо преобразовать.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров. Этот параметр не учитывается.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600094A RID: 2378 RVA: 0x00024732 File Offset: 0x00022932
		public static string ToString(char value, IFormatProvider provider)
		{
			return value.ToString();
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное строковое представление.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600094B RID: 2379 RVA: 0x0002473B File Offset: 0x0002293B
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа со знаком в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">8-разрядное целое число со знаком для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600094C RID: 2380 RVA: 0x00024749 File Offset: 0x00022949
		[CLSCompliant(false)]
		public static string ToString(sbyte value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное строковое представление.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600094D RID: 2381 RVA: 0x00024753 File Offset: 0x00022953
		public static string ToString(byte value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600094E RID: 2382 RVA: 0x00024761 File Offset: 0x00022961
		public static string ToString(byte value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное строковое представление.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600094F RID: 2383 RVA: 0x0002476B File Offset: 0x0002296B
		public static string ToString(short value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000950 RID: 2384 RVA: 0x00024779 File Offset: 0x00022979
		public static string ToString(short value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное строковое представление.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000951 RID: 2385 RVA: 0x00024783 File Offset: 0x00022983
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа без знака в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">16-разрядное целое число без знака для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000952 RID: 2386 RVA: 0x00024791 File Offset: 0x00022991
		[CLSCompliant(false)]
		public static string ToString(ushort value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное строковое представление.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000953 RID: 2387 RVA: 0x0002479B File Offset: 0x0002299B
		public static string ToString(int value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000954 RID: 2388 RVA: 0x000247A9 File Offset: 0x000229A9
		public static string ToString(int value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное строковое представление.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000955 RID: 2389 RVA: 0x000247B3 File Offset: 0x000229B3
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа без знака в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">32-разрядное целое число без знака для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000956 RID: 2390 RVA: 0x000247C1 File Offset: 0x000229C1
		[CLSCompliant(false)]
		public static string ToString(uint value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное строковое представление.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000957 RID: 2391 RVA: 0x000247CB File Offset: 0x000229CB
		public static string ToString(long value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000958 RID: 2392 RVA: 0x000247D9 File Offset: 0x000229D9
		public static string ToString(long value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное строковое представление.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000959 RID: 2393 RVA: 0x000247E3 File Offset: 0x000229E3
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа без знака в эквивалентное строковое представление, учитывая указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">64-разрядное целое число без знака для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600095A RID: 2394 RVA: 0x000247F1 File Offset: 0x000229F1
		[CLSCompliant(false)]
		public static string ToString(ulong value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное строковое представление.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600095B RID: 2395 RVA: 0x000247FB File Offset: 0x000229FB
		public static string ToString(float value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное строковое представление, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Число с плавающей запятой одиночной точности, которое нужно преобразовать.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600095C RID: 2396 RVA: 0x00024809 File Offset: 0x00022A09
		public static string ToString(float value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное строковое представление.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600095D RID: 2397 RVA: 0x00024813 File Offset: 0x00022A13
		public static string ToString(double value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного числа с плавающей запятой двойной точности в эквивалентное строковое представление.</summary>
		/// <param name="value">Число с плавающей запятой двойной точности, которое нужно преобразовать.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600095E RID: 2398 RVA: 0x00024821 File Offset: 0x00022A21
		public static string ToString(double value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное строковое представление.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x0600095F RID: 2399 RVA: 0x0002482B File Offset: 0x00022A2B
		public static string ToString(decimal value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение заданного десятичного числа в эквивалентное строковое представление, используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="value">Десятичное число для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000960 RID: 2400 RVA: 0x00024839 File Offset: 0x00022A39
		public static string ToString(decimal value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Преобразует значение заданного объекта <see cref="T:System.DateTime" /> в эквивалентное строковое представление.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000961 RID: 2401 RVA: 0x00024843 File Offset: 0x00022A43
		public static string ToString(DateTime value)
		{
			return value.ToString();
		}

		/// <summary>Преобразует значение заданного объекта <see cref="T:System.DateTime" /> в эквивалентное строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="value">Значение даты и времени для преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000962 RID: 2402 RVA: 0x0002484C File Offset: 0x00022A4C
		public static string ToString(DateTime value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Возвращает заданное строковое представление; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемая строка.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000963 RID: 2403 RVA: 0x0000270D File Offset: 0x0000090D
		public static string ToString(string value)
		{
			return value;
		}

		/// <summary>Возвращает заданное строковое представление; фактическое преобразование не производится.</summary>
		/// <param name="value">Возвращаемая строка.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров. Этот параметр не учитывается.</param>
		/// <returns>
		///   <paramref name="value" /> возвращается без изменений.</returns>
		// Token: 0x06000964 RID: 2404 RVA: 0x0000270D File Offset: 0x0000090D
		public static string ToString(string value, IFormatProvider provider)
		{
			return value;
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 8-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>8-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Параметру <paramref name="value" />, представляющему десятичное число без знака, предшествует знак минус.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000965 RID: 2405 RVA: 0x00024858 File Offset: 0x00022A58
		public static byte ToByte(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
			if (num < 0 || num > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)num;
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 8-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>8-разрядное целое число со знаком, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000966 RID: 2406 RVA: 0x000248AC File Offset: 0x00022AAC
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 5120);
			if (fromBase != 10 && num <= 255)
			{
				return (sbyte)num;
			}
			if (num < -128 || num > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)num;
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 16-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>16-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000967 RID: 2407 RVA: 0x00024910 File Offset: 0x00022B10
		public static short ToInt16(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 6144);
			if (fromBase != 10 && num <= 65535)
			{
				return (short)num;
			}
			if (num < -32768 || num > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)num;
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 16-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>16-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x06000968 RID: 2408 RVA: 0x00024978 File Offset: 0x00022B78
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
			if (num < 0 || num > 65535)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)num;
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 32-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>32-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06000969 RID: 2409 RVA: 0x000249CC File Offset: 0x00022BCC
		public static int ToInt32(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			return ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4096);
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 32-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>32-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x0600096A RID: 2410 RVA: 0x00024A01 File Offset: 0x00022C01
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0U;
			}
			return (uint)ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 64-битовое целое число со знаком.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>64-разрядное знаковое целое число, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значению <paramref name="value" />, представляющему недесятичное число со знаком, предшествует отрицательный знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число меньше <see cref="F:System.Int64.MinValue" /> или больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x0600096B RID: 2411 RVA: 0x00024A36 File Offset: 0x00022C36
		public static long ToInt64(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0L;
			}
			return ParseNumbers.StringToLong(value.AsSpan(), fromBase, 4096);
		}

		/// <summary>Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 64-битовое целое число без знака.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="fromBase">Основание системы счисления, используемой для представления числа, заданного в параметре <paramref name="value" />, равное 2, 8, 10 или 16.</param>
		/// <returns>64-разрядное целое число без знака, которое эквивалентно значению параметра <paramref name="value" />, или 0 (нуль), если <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fromBase" /> не равно 2, 8, 10 или 16.  
		///
		/// или - 
		/// Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="value" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> содержит символ, который не является допустимой цифрой в основании, заданном параметром <paramref name="fromBase" />. Сообщение об исключении указывает, что отсутствуют цифры для преобразования, если первый символ в <paramref name="value" /> недопустим; в противном случае сообщение указывает, что <paramref name="value" /> содержит недопустимые конечные символы.</exception>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" />, представляющее недесятичное число без знака, использовано со знаком минус.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> представляет число, которое меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x0600096C RID: 2412 RVA: 0x00024A6C File Offset: 0x00022C6C
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0UL;
			}
			return (ulong)ParseNumbers.StringToLong(value.AsSpan(), fromBase, 4608);
		}

		/// <summary>Преобразует значение заданного 8-битового целого числа без знака в эквивалентное строковое представление в указанной системе счисления.</summary>
		/// <param name="value">8-разрядное целое число без знака для преобразования.</param>
		/// <param name="toBase">Основание системы счисления возвращаемого значения, равное 2, 8, 10 или 16.</param>
		/// <returns>Строковое представление значения параметра <paramref name="value" /> в системе счисления с основанием <paramref name="toBase" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="toBase" /> не равно 2, 8, 10 или 16.</exception>
		// Token: 0x0600096D RID: 2413 RVA: 0x00024AA2 File Offset: 0x00022CA2
		public static string ToString(byte value, int toBase)
		{
			if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			return ParseNumbers.IntToString((int)value, toBase, -1, ' ', 64);
		}

		/// <summary>Преобразует значение заданного 16-битового целого числа со знаком в эквивалентное строковое представление в указанной системе счисления.</summary>
		/// <param name="value">16-разрядное целое число со знаком для преобразования.</param>
		/// <param name="toBase">Основание системы счисления возвращаемого значения, равное 2, 8, 10 или 16.</param>
		/// <returns>Строковое представление значения параметра <paramref name="value" /> в системе счисления с основанием <paramref name="toBase" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="toBase" /> не равно 2, 8, 10 или 16.</exception>
		// Token: 0x0600096E RID: 2414 RVA: 0x00024ACD File Offset: 0x00022CCD
		public static string ToString(short value, int toBase)
		{
			if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			return ParseNumbers.IntToString((int)value, toBase, -1, ' ', 128);
		}

		/// <summary>Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное строковое представление в указанной системе счисления.</summary>
		/// <param name="value">32-разрядное целое число со знаком для преобразования.</param>
		/// <param name="toBase">Основание системы счисления возвращаемого значения, равное 2, 8, 10 или 16.</param>
		/// <returns>Строковое представление значения параметра <paramref name="value" /> в системе счисления с основанием <paramref name="toBase" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="toBase" /> не равно 2, 8, 10 или 16.</exception>
		// Token: 0x0600096F RID: 2415 RVA: 0x00024AFB File Offset: 0x00022CFB
		public static string ToString(int value, int toBase)
		{
			if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			return ParseNumbers.IntToString(value, toBase, -1, ' ', 0);
		}

		/// <summary>Преобразует значение заданного 64-битового целого числа со знаком в эквивалентное строковое представление в указанной системе счисления.</summary>
		/// <param name="value">64-разрядное целое число со знаком для преобразования.</param>
		/// <param name="toBase">Основание системы счисления возвращаемого значения, равное 2, 8, 10 или 16.</param>
		/// <returns>Строковое представление значения параметра <paramref name="value" /> в системе счисления с основанием <paramref name="toBase" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="toBase" /> не равно 2, 8, 10 или 16.</exception>
		// Token: 0x06000970 RID: 2416 RVA: 0x00024B25 File Offset: 0x00022D25
		public static string ToString(long value, int toBase)
		{
			if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			return ParseNumbers.LongToString(value, toBase, -1, ' ', 0);
		}

		/// <summary>Преобразует массив 8-разрядных целых чисел без знака в эквивалентное строковое представление, состоящее из цифр в кодировке Base64.</summary>
		/// <param name="inArray">Массив 8-битовых целых чисел без знака.</param>
		/// <returns>Строковое представление содержимого массива <paramref name="inArray" /> в кодировке Base64.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inArray" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000971 RID: 2417 RVA: 0x00024B4F File Offset: 0x00022D4F
		public static string ToBase64String(byte[] inArray)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray), Base64FormattingOptions.None);
		}

		/// <summary>Преобразует массив 8-разрядных целых чисел без знака в эквивалентное строковое представление, состоящее из цифр в кодировке Base64. Параметр указывает, следует ли вставлять в возвращаемое значение разрывы строки.</summary>
		/// <param name="inArray">Массив 8-битовых целых чисел без знака.</param>
		/// <param name="options">
		///   <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> для вставки разрыва строки после каждых 76 знаков или <see cref="F:System.Base64FormattingOptions.None" />, чтобы разрывы строки не вставлялись.</param>
		/// <returns>Строковое представление элементов массива <paramref name="inArray" /> в кодировке Base64.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inArray" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является допустимым значением <see cref="T:System.Base64FormattingOptions" />.</exception>
		// Token: 0x06000972 RID: 2418 RVA: 0x00024B6B File Offset: 0x00022D6B
		public static string ToBase64String(byte[] inArray, Base64FormattingOptions options)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray), options);
		}

		/// <summary>Преобразует подмножество массива 8-разрядных целых чисел без знака в эквивалентное строковое представление, состоящее из цифр в кодировке Base64. В параметрах задается подмножество как смещение во входном массиве и количество преобразуемых элементов этого массива.</summary>
		/// <param name="inArray">Массив 8-битовых целых чисел без знака.</param>
		/// <param name="offset">Смещение в массиве <paramref name="inArray" />.</param>
		/// <param name="length">Число преобразуемых элементов <paramref name="inArray" />.</param>
		/// <returns>Строковое представление <paramref name="length" /> элементов массива <paramref name="inArray" /> в кодировке Base64, начиная с позиции <paramref name="offset" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inArray" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="length" /> является отрицательным значением.  
		///
		/// или - 
		/// Сумма значений <paramref name="offset" /> и <paramref name="length" /> превышает длину массива <paramref name="inArray" />.</exception>
		// Token: 0x06000973 RID: 2419 RVA: 0x00024B87 File Offset: 0x00022D87
		public static string ToBase64String(byte[] inArray, int offset, int length)
		{
			return Convert.ToBase64String(inArray, offset, length, Base64FormattingOptions.None);
		}

		/// <summary>Преобразует подмножество массива 8-разрядных целых чисел без знака в эквивалентное строковое представление, состоящее из цифр в кодировке Base64. В параметрах задаются подмножество как смещение во входном массиве и количество преобразуемых элементов этого массива, а также значение, указывающее, следует ли вставлять в выходной массив разрывы строки.</summary>
		/// <param name="inArray">Массив 8-битовых целых чисел без знака.</param>
		/// <param name="offset">Смещение в массиве <paramref name="inArray" />.</param>
		/// <param name="length">Число преобразуемых элементов <paramref name="inArray" />.</param>
		/// <param name="options">
		///   <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> для вставки разрыва строки после каждых 76 знаков или <see cref="F:System.Base64FormattingOptions.None" />, чтобы разрывы строки не вставлялись.</param>
		/// <returns>Строковое представление <paramref name="length" /> элементов массива <paramref name="inArray" /> в кодировке Base64, начиная с позиции <paramref name="offset" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inArray" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="length" /> является отрицательным значением.  
		///
		/// или - 
		/// Сумма значений <paramref name="offset" /> и <paramref name="length" /> превышает длину массива <paramref name="inArray" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является допустимым значением <see cref="T:System.Base64FormattingOptions" />.</exception>
		// Token: 0x06000974 RID: 2420 RVA: 0x00024B94 File Offset: 0x00022D94
		public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Value must be positive.");
			}
			if (offset > inArray.Length - length)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset and length must refer to a position in the string.");
			}
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray, offset, length), options);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00024C00 File Offset: 0x00022E00
		public unsafe static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
		{
			if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(string.Format("Illegal enum value: {0}.", (int)options), "options");
			}
			if (bytes.Length == 0)
			{
				return string.Empty;
			}
			bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
			string text = string.FastAllocateString(Convert.ToBase64_CalculateAndValidateOutputLength(bytes.Length, insertLineBreaks));
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* inData = reference;
				fixed (string text2 = text)
				{
					char* ptr = text2;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					Convert.ConvertToBase64Array(ptr, inData, 0, bytes.Length, insertLineBreaks);
				}
			}
			return text;
		}

		/// <summary>Преобразует подмножество массива 8-разрядных целых чисел без знака в эквивалентное подмножество массива знаков Юникода, состоящее из цифр в кодировке Base64. Подмножества задаются с помощью параметров как смещение во входном и выходном массивах и количеством преобразуемых элементов входного массива.</summary>
		/// <param name="inArray">Входной массив 8-битовых целых чисел без знака.</param>
		/// <param name="offsetIn">Позиция в массиве <paramref name="inArray" />.</param>
		/// <param name="length">Число преобразуемых элементов <paramref name="inArray" />.</param>
		/// <param name="outArray">Выходной массив знаков Юникода.</param>
		/// <param name="offsetOut">Позиция в массиве <paramref name="outArray" />.</param>
		/// <returns>32-битовое целое число со знаком, представляющее число байтов в массиве <paramref name="outArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inArray" /> или <paramref name="outArray" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offsetIn" />, <paramref name="offsetOut" /> или <paramref name="length" /> является отрицательным значением.  
		///
		/// или - 
		/// Сумма значений <paramref name="offsetIn" /> и <paramref name="length" /> превышает длину массива <paramref name="inArray" />.  
		///
		/// или - 
		/// <paramref name="offsetOut" /> плюс количество возвращаемых элементов превышает длину массива <paramref name="outArray" />.</exception>
		// Token: 0x06000976 RID: 2422 RVA: 0x00024C89 File Offset: 0x00022E89
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
		{
			return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, Base64FormattingOptions.None);
		}

		/// <summary>Преобразует подмножество массива 8-разрядных целых чисел без знака в эквивалентное подмножество массива знаков Юникода, состоящее из цифр в кодировке Base64. В параметрах задаются подмножества как смещение во входном и выходном массивах и количество преобразуемых элементов входного массива, а также значение, указывающее, следует ли вставлять в выходной массив разрывы строки.</summary>
		/// <param name="inArray">Входной массив 8-битовых целых чисел без знака.</param>
		/// <param name="offsetIn">Позиция в массиве <paramref name="inArray" />.</param>
		/// <param name="length">Число преобразуемых элементов <paramref name="inArray" />.</param>
		/// <param name="outArray">Выходной массив знаков Юникода.</param>
		/// <param name="offsetOut">Позиция в массиве <paramref name="outArray" />.</param>
		/// <param name="options">
		///   <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> для вставки разрыва строки после каждых 76 знаков или <see cref="F:System.Base64FormattingOptions.None" />, чтобы разрывы строки не вставлялись.</param>
		/// <returns>32-битовое целое число со знаком, представляющее число байтов в массиве <paramref name="outArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inArray" /> или <paramref name="outArray" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offsetIn" />, <paramref name="offsetOut" /> или <paramref name="length" /> является отрицательным значением.  
		///
		/// или - 
		/// Сумма значений <paramref name="offsetIn" /> и <paramref name="length" /> превышает длину массива <paramref name="inArray" />.  
		///
		/// или - 
		/// <paramref name="offsetOut" /> плюс количество возвращаемых элементов превышает длину массива <paramref name="outArray" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является допустимым значением <see cref="T:System.Base64FormattingOptions" />.</exception>
		// Token: 0x06000977 RID: 2423 RVA: 0x00024C98 File Offset: 0x00022E98
		public unsafe static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (outArray == null)
			{
				throw new ArgumentNullException("outArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (offsetIn < 0)
			{
				throw new ArgumentOutOfRangeException("offsetIn", "Value must be positive.");
			}
			if (offsetOut < 0)
			{
				throw new ArgumentOutOfRangeException("offsetOut", "Value must be positive.");
			}
			if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(string.Format("Illegal enum value: {0}.", (int)options), "options");
			}
			int num = inArray.Length;
			if (offsetIn > num - length)
			{
				throw new ArgumentOutOfRangeException("offsetIn", "Offset and length must refer to a position in the string.");
			}
			if (num == 0)
			{
				return 0;
			}
			bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
			int num2 = outArray.Length;
			int num3 = Convert.ToBase64_CalculateAndValidateOutputLength(length, insertLineBreaks);
			if (offsetOut > num2 - num3)
			{
				throw new ArgumentOutOfRangeException("offsetOut", "Either offset did not refer to a position in the string, or there is an insufficient length of destination character array.");
			}
			int result;
			fixed (char* ptr = &outArray[offsetOut])
			{
				char* outChars = ptr;
				fixed (byte* ptr2 = &inArray[0])
				{
					byte* inData = ptr2;
					result = Convert.ConvertToBase64Array(outChars, inData, offsetIn, length, insertLineBreaks);
				}
			}
			return result;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00024D9C File Offset: 0x00022F9C
		public unsafe static bool TryToBase64Chars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten, Base64FormattingOptions options = Base64FormattingOptions.None)
		{
			if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(string.Format("Illegal enum value: {0}.", (int)options), "options");
			}
			if (bytes.Length == 0)
			{
				charsWritten = 0;
				return true;
			}
			bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
			if (Convert.ToBase64_CalculateAndValidateOutputLength(bytes.Length, insertLineBreaks) > chars.Length)
			{
				charsWritten = 0;
				return false;
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* outChars = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* inData = reference2;
					charsWritten = Convert.ConvertToBase64Array(outChars, inData, 0, bytes.Length, insertLineBreaks);
					return true;
				}
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00024E24 File Offset: 0x00023024
		private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			int num = length % 3;
			int num2 = offset + (length - num);
			int num3 = 0;
			int num4 = 0;
			fixed (char* ptr = &Convert.base64Table[0])
			{
				char* ptr2 = ptr;
				int i;
				for (i = offset; i < num2; i += 3)
				{
					if (insertLineBreaks)
					{
						if (num4 == 76)
						{
							outChars[num3++] = '\r';
							outChars[num3++] = '\n';
							num4 = 0;
						}
						num4 += 4;
					}
					outChars[num3] = ptr2[(inData[i] & 252) >> 2];
					outChars[num3 + 1] = ptr2[(int)(inData[i] & 3) << 4 | (inData[i + 1] & 240) >> 4];
					outChars[num3 + 2] = ptr2[(int)(inData[i + 1] & 15) << 2 | (inData[i + 2] & 192) >> 6];
					outChars[num3 + 3] = ptr2[inData[i + 2] & 63];
					num3 += 4;
				}
				i = num2;
				if (insertLineBreaks && num != 0 && num4 == 76)
				{
					outChars[num3++] = '\r';
					outChars[num3++] = '\n';
				}
				if (num != 1)
				{
					if (num == 2)
					{
						outChars[num3] = ptr2[(inData[i] & 252) >> 2];
						outChars[num3 + 1] = ptr2[(int)(inData[i] & 3) << 4 | (inData[i + 1] & 240) >> 4];
						outChars[num3 + 2] = ptr2[(inData[i + 1] & 15) << 2];
						outChars[num3 + 3] = ptr2[64];
						num3 += 4;
					}
				}
				else
				{
					outChars[num3] = ptr2[(inData[i] & 252) >> 2];
					outChars[num3 + 1] = ptr2[(inData[i] & 3) << 4];
					outChars[num3 + 2] = ptr2[64];
					outChars[num3 + 3] = ptr2[64];
					num3 += 4;
				}
			}
			return num3;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002502C File Offset: 0x0002322C
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			long num = (long)inputLength / 3L * 4L;
			num += ((inputLength % 3 != 0) ? 4L : 0L);
			if (num == 0L)
			{
				return 0;
			}
			if (insertLineBreaks)
			{
				long num2 = num / 76L;
				if (num % 76L == 0L)
				{
					num2 -= 1L;
				}
				num += num2 * 2L;
			}
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			return (int)num;
		}

		/// <summary>Преобразует заданную строку, представляющую двоичные данные в виде цифр в кодировке Base64, в эквивалентный массив 8-разрядных целых чисел без знака.</summary>
		/// <param name="s">Преобразуемая строка.</param>
		/// <returns>Массив 8-разрядных целых чисел без знака, эквивалентный <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Длина <paramref name="s" />, не учитывая символы пробелов, не равна нулю и не кратна 4.  
		/// -или- 
		/// Недопустимый формат <paramref name="s" />. <paramref name="s" /> содержит символ в кодировке, отличной от Base 64, больше двух символов заполнения или символ, не являющийся пробелом, среди символов заполнения.</exception>
		// Token: 0x0600097B RID: 2427 RVA: 0x00025084 File Offset: 0x00023284
		public unsafe static byte[] FromBase64String(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Convert.FromBase64CharPtr(ptr, s.Length);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000250BB File Offset: 0x000232BB
		public static bool TryFromBase64String(string s, Span<byte> bytes, out int bytesWritten)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return Convert.TryFromBase64Chars(s.AsSpan(), bytes, out bytesWritten);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000250D8 File Offset: 0x000232D8
		public unsafe static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)8], 4);
			bytesWritten = 0;
			while (chars.Length != 0)
			{
				int start;
				int num;
				bool flag = Convert.TryDecodeFromUtf16(chars, bytes, out start, out num);
				bytesWritten += num;
				if (flag)
				{
					return true;
				}
				chars = chars.Slice(start);
				bytes = bytes.Slice(num);
				if (((char)(*chars[0])).IsSpace())
				{
					int num2 = 1;
					while (num2 != chars.Length && ((char)(*chars[num2])).IsSpace())
					{
						num2++;
					}
					chars = chars.Slice(num2);
					if (num % 3 != 0 && chars.Length != 0)
					{
						bytesWritten = 0;
						return false;
					}
				}
				else
				{
					int start2;
					int num3;
					Convert.CopyToTempBufferWithoutWhiteSpace(chars, span, out start2, out num3);
					if ((num3 & 3) != 0)
					{
						bytesWritten = 0;
						return false;
					}
					span = span.Slice(0, num3);
					int num4;
					int num5;
					if (!Convert.TryDecodeFromUtf16(span, bytes, out num4, out num5))
					{
						bytesWritten = 0;
						return false;
					}
					bytesWritten += num5;
					chars = chars.Slice(start2);
					bytes = bytes.Slice(num5);
					if (num5 % 3 != 0)
					{
						for (int i = 0; i < chars.Length; i++)
						{
							if (!((char)(*chars[i])).IsSpace())
							{
								bytesWritten = 0;
								return false;
							}
						}
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002520C File Offset: 0x0002340C
		private unsafe static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
		{
			charsWritten = 0;
			for (int i = 0; i < chars.Length; i++)
			{
				char c = (char)(*chars[i]);
				if (!c.IsSpace())
				{
					int num = charsWritten;
					charsWritten = num + 1;
					*tempBuffer[num] = c;
					if (charsWritten == tempBuffer.Length)
					{
						consumed = i + 1;
						return;
					}
				}
			}
			consumed = chars.Length;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002526C File Offset: 0x0002346C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSpace(this char c)
		{
			return c == ' ' || c == '\t' || c == '\r' || c == '\n';
		}

		/// <summary>Преобразует подмножество массива знаков Юникода, представляющих двоичные данные в виде цифр в кодировке Base64, в эквивалентный массив 8-разрядных целых чисел без знака. Параметры задают подмножество входного массива и количество преобразуемых элементов.</summary>
		/// <param name="inArray">Массив знаков Юникода.</param>
		/// <param name="offset">Позиция в массиве <paramref name="inArray" />.</param>
		/// <param name="length">Число преобразуемых элементов массива <paramref name="inArray" />.</param>
		/// <returns>Массив 8-битовых целых чисел без знака, эквивалентный <paramref name="length" /> элементам с позиции <paramref name="offset" /> в массиве <paramref name="inArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inArray" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="length" /> меньше 0.  
		///
		/// или - 
		/// <paramref name="offset" /> плюс <paramref name="length" /> указывает на позицию за пределами <paramref name="inArray" />.</exception>
		/// <exception cref="T:System.FormatException">Длина <paramref name="inArray" />, не учитывая символы пробелов, не равна нулю и не кратна 4.  
		/// -или- 
		/// Недопустимый формат <paramref name="inArray" />. <paramref name="inArray" /> содержит символ в кодировке, отличной от Base 64, больше двух символов заполнения или символ, не являющийся пробелом, среди символов заполнения.</exception>
		// Token: 0x06000980 RID: 2432 RVA: 0x00025284 File Offset: 0x00023484
		public unsafe static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Value must be positive.");
			}
			if (offset > inArray.Length - length)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset and length must refer to a position in the string.");
			}
			if (inArray.Length == 0)
			{
				return Array.Empty<byte>();
			}
			fixed (char* ptr = &inArray[0])
			{
				return Convert.FromBase64CharPtr(ptr + offset, length);
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00025300 File Offset: 0x00023500
		private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			while (inputLength > 0)
			{
				int num = (int)inputPtr[inputLength - 1];
				if (num != 32 && num != 10 && num != 13 && num != 9)
				{
					break;
				}
				inputLength--;
			}
			byte[] array = new byte[Convert.FromBase64_ComputeResultLength(inputPtr, inputLength)];
			int num2;
			if (!Convert.TryFromBase64Chars(new ReadOnlySpan<char>((void*)inputPtr, inputLength), array, out num2))
			{
				throw new FormatException("The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.");
			}
			return array;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00025368 File Offset: 0x00023568
		private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			char* ptr = inputPtr + inputLength;
			int num = inputLength;
			int num2 = 0;
			while (inputPtr < ptr)
			{
				uint num3 = (uint)(*inputPtr);
				inputPtr++;
				if (num3 <= 32U)
				{
					num--;
				}
				else if (num3 == 61U)
				{
					num--;
					num2++;
				}
			}
			if (num2 != 0)
			{
				if (num2 == 1)
				{
					num2 = 2;
				}
				else
				{
					if (num2 != 2)
					{
						throw new FormatException("The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.");
					}
					num2 = 1;
				}
			}
			return num / 4 * 3 + num2;
		}

		// Token: 0x04001084 RID: 4228
		private static readonly sbyte[] s_decodingMap = new sbyte[]
		{
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			62,
			-1,
			-1,
			-1,
			63,
			52,
			53,
			54,
			55,
			56,
			57,
			58,
			59,
			60,
			61,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			12,
			13,
			14,
			15,
			16,
			17,
			18,
			19,
			20,
			21,
			22,
			23,
			24,
			25,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			26,
			27,
			28,
			29,
			30,
			31,
			32,
			33,
			34,
			35,
			36,
			37,
			38,
			39,
			40,
			41,
			42,
			43,
			44,
			45,
			46,
			47,
			48,
			49,
			50,
			51,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1
		};

		// Token: 0x04001085 RID: 4229
		private const byte EncodingPad = 61;

		// Token: 0x04001086 RID: 4230
		internal static readonly Type[] ConvertTypes = new Type[]
		{
			typeof(Empty),
			typeof(object),
			typeof(DBNull),
			typeof(bool),
			typeof(char),
			typeof(sbyte),
			typeof(byte),
			typeof(short),
			typeof(ushort),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(float),
			typeof(double),
			typeof(decimal),
			typeof(DateTime),
			typeof(object),
			typeof(string)
		};

		// Token: 0x04001087 RID: 4231
		private static readonly Type EnumType = typeof(Enum);

		// Token: 0x04001088 RID: 4232
		internal static readonly char[] base64Table = new char[]
		{
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z',
			'a',
			'b',
			'c',
			'd',
			'e',
			'f',
			'g',
			'h',
			'i',
			'j',
			'k',
			'l',
			'm',
			'n',
			'o',
			'p',
			'q',
			'r',
			's',
			't',
			'u',
			'v',
			'w',
			'x',
			'y',
			'z',
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'+',
			'/',
			'='
		};

		// Token: 0x04001089 RID: 4233
		private const int base64LineBreakPosition = 76;

		/// <summary>Константа, представляющая не содержащий данных столбец базы данных, то есть значение NULL базы данных.</summary>
		// Token: 0x0400108A RID: 4234
		public static readonly object DBNull = System.DBNull.Value;
	}
}
