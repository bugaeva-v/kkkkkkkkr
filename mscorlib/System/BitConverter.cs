using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Преобразует базовые типы данных в массив байтов, а массив байтов — в базовые типы данных.</summary>
	// Token: 0x02000100 RID: 256
	public static class BitConverter
	{
		/// <summary>Возвращает указанное логическое значение в виде массива байтов.</summary>
		/// <param name="value">Значение типа Boolean.</param>
		/// <returns>Массив байтов длиной 1.</returns>
		// Token: 0x06000765 RID: 1893 RVA: 0x0000A9B9 File Offset: 0x00008BB9
		public static byte[] GetBytes(bool value)
		{
			return new byte[]
			{
				value ? 1 : 0
			};
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000219D2 File Offset: 0x0001FBD2
		public static bool TryWriteBytes(Span<byte> destination, bool value)
		{
			if (destination.Length < 1)
			{
				return false;
			}
			Unsafe.WriteUnaligned<byte>(MemoryMarshal.GetReference<byte>(destination), value ? 1 : 0);
			return true;
		}

		/// <summary>Возвращает указанное значение знака Юникода в виде массива байтов.</summary>
		/// <param name="value">Преобразуемый знак.</param>
		/// <returns>Массив байтов длиной 2.</returns>
		// Token: 0x06000767 RID: 1895 RVA: 0x000219F3 File Offset: 0x0001FBF3
		public unsafe static byte[] GetBytes(char value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, char>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00021A09 File Offset: 0x0001FC09
		public static bool TryWriteBytes(Span<byte> destination, char value)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<char>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное значение 16-битового целого числа со знаком в виде массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов длиной 2.</returns>
		// Token: 0x06000769 RID: 1897 RVA: 0x00021A24 File Offset: 0x0001FC24
		public unsafe static byte[] GetBytes(short value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, short>(ref array[0]) = value;
			return array;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00021A3A File Offset: 0x0001FC3A
		public static bool TryWriteBytes(Span<byte> destination, short value)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное 32-разрядное целое число со знаком в качестве массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов длиной 4.</returns>
		// Token: 0x0600076B RID: 1899 RVA: 0x00021A55 File Offset: 0x0001FC55
		public unsafe static byte[] GetBytes(int value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, int>(ref array[0]) = value;
			return array;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00021A6B File Offset: 0x0001FC6B
		public static bool TryWriteBytes(Span<byte> destination, int value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<int>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное 64-разрядные целые числа со знаком в качестве массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов с шириной 8.</returns>
		// Token: 0x0600076D RID: 1901 RVA: 0x00021A86 File Offset: 0x0001FC86
		public unsafe static byte[] GetBytes(long value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, long>(ref array[0]) = value;
			return array;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00021A9C File Offset: 0x0001FC9C
		public static bool TryWriteBytes(Span<byte> destination, long value)
		{
			if (destination.Length < 8)
			{
				return false;
			}
			Unsafe.WriteUnaligned<long>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное значение 16-битового целого числа без знака в виде массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов длиной 2.</returns>
		// Token: 0x0600076F RID: 1903 RVA: 0x00021AB7 File Offset: 0x0001FCB7
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(ushort value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, ushort>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00021ACD File Offset: 0x0001FCCD
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, ushort value)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное 32-разрядное целое число без знака в виде массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов длиной 4.</returns>
		// Token: 0x06000771 RID: 1905 RVA: 0x00021AE8 File Offset: 0x0001FCE8
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(uint value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, uint>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00021AFE File Offset: 0x0001FCFE
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, uint value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное 64-разрядное целое число без знака в виде массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов с шириной 8.</returns>
		// Token: 0x06000773 RID: 1907 RVA: 0x00021B19 File Offset: 0x0001FD19
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(ulong value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, ulong>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00021B2F File Offset: 0x0001FD2F
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, ulong value)
		{
			if (destination.Length < 8)
			{
				return false;
			}
			Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное значение с плавающей запятой с обычной точностью в виде массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов длиной 4.</returns>
		// Token: 0x06000775 RID: 1909 RVA: 0x00021B4A File Offset: 0x0001FD4A
		public unsafe static byte[] GetBytes(float value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, float>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00021B60 File Offset: 0x0001FD60
		public static bool TryWriteBytes(Span<byte> destination, float value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<float>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает указанное значение двойной точности с плавающей запятой в виде массива байтов.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Массив байтов с шириной 8.</returns>
		// Token: 0x06000777 RID: 1911 RVA: 0x00021B7B File Offset: 0x0001FD7B
		public unsafe static byte[] GetBytes(double value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, double>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00021B91 File Offset: 0x0001FD91
		public static bool TryWriteBytes(Span<byte> destination, double value)
		{
			if (destination.Length < 8)
			{
				return false;
			}
			Unsafe.WriteUnaligned<double>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Возвращает знак Юникода, преобразованный из двух байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>Знак, образованный двумя байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="startIndex" /> равен длине <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x06000779 RID: 1913 RVA: 0x00021BAC File Offset: 0x0001FDAC
		public static char ToChar(byte[] value, int startIndex)
		{
			return (char)BitConverter.ToInt16(value, startIndex);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00021BB6 File Offset: 0x0001FDB6
		public static char ToChar(ReadOnlySpan<byte> value)
		{
			if (value.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<char>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает 16-битовое целое число со знаком, преобразованное из двух байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>16-битовое знаковое целое число, образованное двумя байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="startIndex" /> равен длине <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x0600077B RID: 1915 RVA: 0x00021BD4 File Offset: 0x0001FDD4
		public static short ToInt16(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (startIndex > value.Length - 2)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<short>(ref value[startIndex]);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00021C0B File Offset: 0x0001FE0B
		public static short ToInt16(ReadOnlySpan<byte> value)
		{
			if (value.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<short>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает 32-битовое целое число со знаком, преобразованное из четырех байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>32-битовое знаковое целое число, образованное четырьмя байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startIndex" /> больше или равно длине параметра <paramref name="value" /> минус 3 и меньше или равно длине параметра <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x0600077D RID: 1917 RVA: 0x00021C29 File Offset: 0x0001FE29
		public static int ToInt32(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (startIndex > value.Length - 4)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<int>(ref value[startIndex]);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00021C60 File Offset: 0x0001FE60
		public static int ToInt32(ReadOnlySpan<byte> value)
		{
			if (value.Length < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<int>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает 64-битовое целое число со знаком, преобразованное из восьми байт с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>64-битовое знаковое целое число, сформированное восемью байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startIndex" /> больше или равно длине параметра <paramref name="value" /> минус 7 и меньше или равно длине параметра <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x0600077F RID: 1919 RVA: 0x00021C7E File Offset: 0x0001FE7E
		public static long ToInt64(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (startIndex > value.Length - 8)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00021CB5 File Offset: 0x0001FEB5
		public static long ToInt64(ReadOnlySpan<byte> value)
		{
			if (value.Length < 8)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<long>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает 16-битовое целое число без знака, преобразованное из двух байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>16-битовое целое число без знака, образованное двумя байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="startIndex" /> равен длине <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x06000781 RID: 1921 RVA: 0x00021BAC File Offset: 0x0001FDAC
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte[] value, int startIndex)
		{
			return (ushort)BitConverter.ToInt16(value, startIndex);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00021CD3 File Offset: 0x0001FED3
		[CLSCompliant(false)]
		public static ushort ToUInt16(ReadOnlySpan<byte> value)
		{
			if (value.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<ushort>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает 32-битовое целое число без знака, преобразованное из четырех байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>32-битовое целое число без знака, образованное четырьмя байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startIndex" /> больше или равно длине параметра <paramref name="value" /> минус 3 и меньше или равно длине параметра <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x06000783 RID: 1923 RVA: 0x00021CF1 File Offset: 0x0001FEF1
		[CLSCompliant(false)]
		public static uint ToUInt32(byte[] value, int startIndex)
		{
			return (uint)BitConverter.ToInt32(value, startIndex);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00021CFA File Offset: 0x0001FEFA
		[CLSCompliant(false)]
		public static uint ToUInt32(ReadOnlySpan<byte> value)
		{
			if (value.Length < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<uint>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает 64-битовое целое число без знака, преобразованное из восьми байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>64-битовое целое число без знака, образованное восемью байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startIndex" /> больше или равно длине параметра <paramref name="value" /> минус 7 и меньше или равно длине параметра <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x06000785 RID: 1925 RVA: 0x00021D18 File Offset: 0x0001FF18
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte[] value, int startIndex)
		{
			return (ulong)BitConverter.ToInt64(value, startIndex);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00021D21 File Offset: 0x0001FF21
		[CLSCompliant(false)]
		public static ulong ToUInt64(ReadOnlySpan<byte> value)
		{
			if (value.Length < 8)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<ulong>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает число одинарной точности с плавающей запятой, преобразованное из четырех байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>Число одинарной точности с плавающей запятой, образованное четырьмя байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startIndex" /> больше или равно длине параметра <paramref name="value" /> минус 3 и меньше или равно длине параметра <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x06000787 RID: 1927 RVA: 0x00021D3F File Offset: 0x0001FF3F
		public static float ToSingle(byte[] value, int startIndex)
		{
			return BitConverter.Int32BitsToSingle(BitConverter.ToInt32(value, startIndex));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00021D4D File Offset: 0x0001FF4D
		public static float ToSingle(ReadOnlySpan<byte> value)
		{
			if (value.Length < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<float>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Возвращает число двойной точности с плавающей запятой, преобразованное из восьми байтов с указанной позицией в массив байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>Число двойной точности с плавающей запятой, образованное восемью байтами, начинающимися с <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startIndex" /> больше или равно длине параметра <paramref name="value" /> минус 7 и меньше или равно длине параметра <paramref name="value" /> минус 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x06000789 RID: 1929 RVA: 0x00021D6B File Offset: 0x0001FF6B
		public static double ToDouble(byte[] value, int startIndex)
		{
			return BitConverter.Int64BitsToDouble(BitConverter.ToInt64(value, startIndex));
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00021D79 File Offset: 0x0001FF79
		public static double ToDouble(ReadOnlySpan<byte> value)
		{
			if (value.Length < 8)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<double>(MemoryMarshal.GetReference<byte>(value));
		}

		/// <summary>Преобразует числовое значение каждого элемента заданного подмассива байтов в эквивалентное ему шестнадцатеричное строковое представление.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <param name="length">Количество преобразуемых элементов в массиве <paramref name="value" />.</param>
		/// <returns>Строка, состоящая из шестнадцатеричных пар, разделенных дефисами, где каждая пара предоставляет соответствующий элемент в подмассиве <paramref name="value" />; например, "7F-2C-4A-00".</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="startIndex" /> меньше нуля и больше или равно длине <paramref name="value" />.</exception>
		/// <exception cref="T:System.ArgumentException">Сочетание <paramref name="startIndex" /> и <paramref name="length" /> не задает позицию в <paramref name="value" />; то есть, параметр <paramref name="startIndex" /> больше, чем длина <paramref name="value" /> минус параметр <paramref name="length" />.</exception>
		// Token: 0x0600078B RID: 1931 RVA: 0x00021D98 File Offset: 0x0001FF98
		public unsafe static string ToString(byte[] value, int startIndex, int length)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex < 0 || (startIndex >= value.Length && startIndex > 0))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Value must be positive.");
			}
			if (startIndex > value.Length - length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (length > 715827882)
			{
				throw new ArgumentOutOfRangeException("length", SR.Format("The specified length exceeds the maximum value of {0}.", 715827882));
			}
			return string.Create<ValueTuple<byte[], int, int>>(length * 3 - 1, new ValueTuple<byte[], int, int>(value, startIndex, length), delegate(Span<char> dst, [TupleElementNames(new string[]
			{
				"value",
				"startIndex",
				"length"
			})] ValueTuple<byte[], int, int> state)
			{
				ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(state.Item1, state.Item2, state.Item3);
				int i = 0;
				int num = 0;
				byte b = *readOnlySpan[i++];
				*dst[num++] = "0123456789ABCDEF"[b >> 4];
				*dst[num++] = "0123456789ABCDEF"[(int)(b & 15)];
				while (i < readOnlySpan.Length)
				{
					b = *readOnlySpan[i++];
					*dst[num++] = '-';
					*dst[num++] = "0123456789ABCDEF"[b >> 4];
					*dst[num++] = "0123456789ABCDEF"[(int)(b & 15)];
				}
			});
		}

		/// <summary>Преобразует числовое значение каждого элемента заданного массива байтов в эквивалентное ему шестнадцатеричное строковое представление.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <returns>Строка, состоящая из шестнадцатеричных пар, разделенных дефисами, где каждая пара предоставляет соответствующий элемент в <paramref name="value" />; например: "7F-2C-4A-00".</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600078C RID: 1932 RVA: 0x00021E4B File Offset: 0x0002004B
		public static string ToString(byte[] value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return BitConverter.ToString(value, 0, value.Length);
		}

		/// <summary>Преобразует числовое значение каждого элемента заданного подмассива байтов в эквивалентное ему шестнадцатеричное строковое представление.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <returns>Строка, состоящая из шестнадцатеричных пар, разделенных дефисами, где каждая пара предоставляет соответствующий элемент в подмассиве <paramref name="value" />; например, "7F-2C-4A-00".</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x0600078D RID: 1933 RVA: 0x00021E61 File Offset: 0x00020061
		public static string ToString(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return BitConverter.ToString(value, startIndex, value.Length - startIndex);
		}

		/// <summary>Возвращает логическое значение, преобразованное из байта в указанной позиции в массиве байтов.</summary>
		/// <param name="value">Массив байтов.</param>
		/// <param name="startIndex">Индекс байта в <paramref name="value" />.</param>
		/// <returns>Значение <see langword="true" />, если байт в <paramref name="startIndex" /> в параметре <paramref name="value" /> отличен от нуля; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> меньше нуля или больше, чем длина <paramref name="value" /> минус 1.</exception>
		// Token: 0x0600078E RID: 1934 RVA: 0x00021E79 File Offset: 0x00020079
		public static bool ToBoolean(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (startIndex > value.Length - 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			return value[startIndex] > 0;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00021EA9 File Offset: 0x000200A9
		public static bool ToBoolean(ReadOnlySpan<byte> value)
		{
			if (value.Length < 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<byte>(MemoryMarshal.GetReference<byte>(value)) > 0;
		}

		/// <summary>Преобразует указанное число двойной точности с плавающей запятой в 64-битовое целое число со знаком.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Значение 64-битового знакового целого числа эквивалентно <paramref name="value" />.</returns>
		// Token: 0x06000790 RID: 1936 RVA: 0x00021ECA File Offset: 0x000200CA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			return *(long*)(&value);
		}

		/// <summary>Преобразует указанное 64-битовое целое число со знаком в число двойной точности с плавающей запятой.</summary>
		/// <param name="value">Преобразуемое число.</param>
		/// <returns>Значение числа двойной точности с плавающей запятой эквивалентно <paramref name="value" />.</returns>
		// Token: 0x06000791 RID: 1937 RVA: 0x00021ED0 File Offset: 0x000200D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static double Int64BitsToDouble(long value)
		{
			return *(double*)(&value);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00021ED6 File Offset: 0x000200D6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int SingleToInt32Bits(float value)
		{
			return *(int*)(&value);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00021EDC File Offset: 0x000200DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float Int32BitsToSingle(int value)
		{
			return *(float*)(&value);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00021EE4 File Offset: 0x000200E4
		unsafe static BitConverter()
		{
			ushort num = 4660;
			byte* ptr = (byte*)(&num);
			BitConverter.IsLittleEndian = (*ptr == 52);
		}

		/// <summary>Указывает порядок байтов (порядок следования байтов), по которому данные сохраняются в архитектуре этого компьютера.</summary>
		// Token: 0x0400106A RID: 4202
		[Intrinsic]
		public static readonly bool IsLittleEndian;
	}
}
