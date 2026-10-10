using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Предоставляет константы и статические методы для тригонометрических, логарифмических и иных общих математических функций.</summary>
	// Token: 0x02000154 RID: 340
	public static class Math
	{
		/// <summary>Возвращает абсолютное значение 16-битового целого числа со знаком.</summary>
		/// <param name="value">Число, которое больше значения <see cref="F:System.Int16.MinValue" />, но меньше или равно значению <see cref="F:System.Int16.MaxValue" />.</param>
		/// <returns>16-разрядное целое число х со знаком, такое, что 0 ≤ x ≤<see cref="F:System.Int16.MaxValue" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> равняется <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x06000CC8 RID: 3272 RVA: 0x00032FE8 File Offset: 0x000311E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short Abs(short value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowAbsOverflow();
				}
			}
			return value;
		}

		/// <summary>Возвращает абсолютное значение 32-битового целого числа со знаком.</summary>
		/// <param name="value">Число, которое больше значения <see cref="F:System.Int32.MinValue" />, но меньше или равно значению <see cref="F:System.Int32.MaxValue" />.</param>
		/// <returns>32-разрядное целое число х со знаком, такое, что 0 ≤ x ≤<see cref="F:System.Int32.MaxValue" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> равняется <see cref="F:System.Int32.MinValue" />.</exception>
		// Token: 0x06000CC9 RID: 3273 RVA: 0x00032FFD File Offset: 0x000311FD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(int value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowAbsOverflow();
				}
			}
			return value;
		}

		/// <summary>Возвращает абсолютное значение 64-битового целого числа со знаком.</summary>
		/// <param name="value">Число, которое больше значения <see cref="F:System.Int64.MinValue" />, но меньше или равно значению <see cref="F:System.Int64.MaxValue" />.</param>
		/// <returns>64-разрядное целое число х со знаком, такое, что 0 ≤ x ≤<see cref="F:System.Int64.MaxValue" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> равняется <see cref="F:System.Int64.MinValue" />.</exception>
		// Token: 0x06000CCA RID: 3274 RVA: 0x00033011 File Offset: 0x00031211
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Abs(long value)
		{
			if (value < 0L)
			{
				value = -value;
				if (value < 0L)
				{
					Math.ThrowAbsOverflow();
				}
			}
			return value;
		}

		/// <summary>Возвращает абсолютное значение 8-битового целого числа со знаком.</summary>
		/// <param name="value">Число, которое больше значения <see cref="F:System.SByte.MinValue" />, но меньше или равно значению <see cref="F:System.SByte.MaxValue" />.</param>
		/// <returns>8-разрядное целое число х со знаком, такое, что 0 ≤ x ≤<see cref="F:System.SByte.MaxValue" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> равняется <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x06000CCB RID: 3275 RVA: 0x00033027 File Offset: 0x00031227
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte Abs(sbyte value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowAbsOverflow();
				}
			}
			return value;
		}

		/// <summary>Возвращает абсолютное значение числа <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Число, которое больше или равно значению <see cref="F:System.Decimal.MinValue" />, но меньше или равно значению <see cref="F:System.Decimal.MaxValue" />.</param>
		/// <returns>Десятичное число x, такое, что 0 ≤ x ≤<see cref="F:System.Decimal.MaxValue" />.</returns>
		// Token: 0x06000CCC RID: 3276 RVA: 0x0003303C File Offset: 0x0003123C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Abs(decimal value)
		{
			return decimal.Abs(ref value);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00033045 File Offset: 0x00031245
		[StackTraceHidden]
		private static void ThrowAbsOverflow()
		{
			throw new OverflowException("Negating the minimum value of a twos complement number is invalid.");
		}

		/// <summary>Умножает два 32-битовых числа.</summary>
		/// <param name="a">Первое число для умножения.</param>
		/// <param name="b">Второе число для умножения.</param>
		/// <returns>Число, являющееся произведением указанных чисел.</returns>
		// Token: 0x06000CCE RID: 3278 RVA: 0x00033051 File Offset: 0x00031251
		public static long BigMul(int a, int b)
		{
			return (long)a * (long)b;
		}

		/// <summary>Вычисляет частное двух 32-битовых целых чисел со знаком и возвращает остаток в выходном параметре.</summary>
		/// <param name="a">Делимое.</param>
		/// <param name="b">Делитель.</param>
		/// <param name="result">Остаток.</param>
		/// <returns>Частное от деления указанных чисел.</returns>
		/// <exception cref="T:System.DivideByZeroException">
		///   <paramref name="b" /> равен нулю.</exception>
		// Token: 0x06000CCF RID: 3279 RVA: 0x00033058 File Offset: 0x00031258
		public static int DivRem(int a, int b, out int result)
		{
			int num = a / b;
			result = a - num * b;
			return num;
		}

		/// <summary>Вычисляет частное двух 64-битовых целых чисел со знаком и возвращает остаток в выходном параметре.</summary>
		/// <param name="a">Делимое.</param>
		/// <param name="b">Делитель.</param>
		/// <param name="result">Остаток.</param>
		/// <returns>Частное от деления указанных чисел.</returns>
		/// <exception cref="T:System.DivideByZeroException">
		///   <paramref name="b" /> равен нулю.</exception>
		// Token: 0x06000CD0 RID: 3280 RVA: 0x00033074 File Offset: 0x00031274
		public static long DivRem(long a, long b, out long result)
		{
			long num = a / b;
			result = a - num * b;
			return num;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00033090 File Offset: 0x00031290
		internal static uint DivRem(uint a, uint b, out uint result)
		{
			uint num = a / b;
			result = a - num * b;
			return num;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000330AC File Offset: 0x000312AC
		internal static ulong DivRem(ulong a, ulong b, out ulong result)
		{
			ulong num = a / b;
			result = a - num * b;
			return num;
		}

		/// <summary>Возвращает наименьшее целое число, которое больше или равно заданному десятичному числу.</summary>
		/// <param name="d">Десятичное число.</param>
		/// <returns>Наименьшее целочисленное значение, которое больше или равно <paramref name="d" />. Обратите внимание, что данный метод возвращает не целочисленное значение, а значение типа <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000CD3 RID: 3283 RVA: 0x000330C5 File Offset: 0x000312C5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Ceiling(decimal d)
		{
			return decimal.Ceiling(d);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000330CD File Offset: 0x000312CD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Clamp(byte value, byte min, byte max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<byte>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000330E7 File Offset: 0x000312E7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Clamp(decimal value, decimal min, decimal max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<decimal>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00033110 File Offset: 0x00031310
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Clamp(double value, double min, double max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<double>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0003312A File Offset: 0x0003132A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short Clamp(short value, short min, short max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<short>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00033144 File Offset: 0x00031344
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(int value, int min, int max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<int>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0003315E File Offset: 0x0003135E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Clamp(long value, long min, long max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<long>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00033178 File Offset: 0x00031378
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte Clamp(sbyte value, sbyte min, sbyte max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<sbyte>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00033192 File Offset: 0x00031392
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp(float value, float min, float max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<float>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x000331AC File Offset: 0x000313AC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort Clamp(ushort value, ushort min, ushort max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<ushort>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000331C6 File Offset: 0x000313C6
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Clamp(uint value, uint min, uint max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<uint>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000331E0 File Offset: 0x000313E0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Clamp(ulong value, ulong min, ulong max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<ulong>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		/// <summary>Возвращает наибольшее целое число, которое меньше или равно указанному десятичному числу.</summary>
		/// <param name="d">Десятичное число.</param>
		/// <returns>Наибольшее целое число, которое меньше или равно <paramref name="d" />.  Обратите внимание, что этот метод возвращает целочисленное значение типа <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000CDF RID: 3295 RVA: 0x000331FA File Offset: 0x000313FA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Floor(decimal d)
		{
			return decimal.Floor(d);
		}

		/// <summary>Возвращает остаток от деления одного указанного числа на другое указанное число.</summary>
		/// <param name="x">Делимое.</param>
		/// <param name="y">Делитель.</param>
		/// <returns>Число, равное <paramref name="x" /> – (<paramref name="y" /> Q), где Q является частным <paramref name="x" /> / <paramref name="y" />, округленным до ближайшего целого числа (если <paramref name="x" /> / <paramref name="y" /> находится на равном расстоянии от двух целых чисел, выбирается четное число).  
		/// Если значение <paramref name="x" /> - (<paramref name="y" />Q) равно нулю, возвращается значение +0 при положительном <paramref name="x" /> или значение -0 при отрицательном <paramref name="x" />.  
		/// Если значение параметра <paramref name="y" /> равно 0, возвращается значение <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000CE0 RID: 3296 RVA: 0x00033204 File Offset: 0x00031404
		public static double IEEERemainder(double x, double y)
		{
			if (double.IsNaN(x))
			{
				return x;
			}
			if (double.IsNaN(y))
			{
				return y;
			}
			double num = x % y;
			if (double.IsNaN(num))
			{
				return double.NaN;
			}
			if (num == 0.0 && double.IsNegative(x))
			{
				return --0.0;
			}
			double num2 = num - Math.Abs(y) * (double)Math.Sign(x);
			if (Math.Abs(num2) == Math.Abs(num))
			{
				double num3 = x / y;
				if (Math.Abs(Math.Round(num3)) > Math.Abs(num3))
				{
					return num2;
				}
				return num;
			}
			else
			{
				if (Math.Abs(num2) < Math.Abs(num))
				{
					return num2;
				}
				return num;
			}
		}

		/// <summary>Возвращает логарифм указанного числа в системе счисления с указанным основанием.</summary>
		/// <param name="a">Число, логарифм которого требуется найти.</param>
		/// <param name="newBase">Основание логарифма.</param>
		/// <returns>Одно из значений, перечисленных в следующей таблице. (+бесконечность обозначает <see cref="F:System.Double.PositiveInfinity" />, -бесконечность обозначает <see cref="F:System.Double.NegativeInfinity" />, а нечисловое значение обозначает <see cref="F:System.Double.NaN" />.) 
		///  <paramref name="a" /><paramref name="newBase" /> Возвращаемое значение 
		///  <paramref name="a" />&gt; 0 
		///   (0 &lt;<paramref name="newBase" />&lt; 1) -или-(<paramref name="newBase" />&gt; 1) 
		///   lognewBase(a) 
		///  <paramref name="a" />&lt; 0 
		///   (любое значение) 
		///   NaN 
		///   (любое значение) 
		///  <paramref name="newBase" />&lt; 0 
		///   NaN 
		///  <paramref name="a" /> != 1 
		///  <paramref name="newBase" /> = 0 
		///   NaN 
		///  <paramref name="a" /> != 1 
		///  <paramref name="newBase" /> = +бесконечность 
		///   NaN 
		///  <paramref name="a" /> = NaN 
		///   (любое значение) 
		///   NaN 
		///   (любое значение) 
		///  <paramref name="newBase" /> = NaN 
		///   NaN 
		///   (любое значение) 
		///  <paramref name="newBase" /> = 1 
		///   NaN 
		///  <paramref name="a" /> = 0 
		///   0 &lt;<paramref name="newBase" />&lt; 1 
		///   +бесконечность 
		///  <paramref name="a" /> = 0 
		///  <paramref name="newBase" />&gt; 1 
		///   -бесконечность 
		///  <paramref name="a" /> = +бесконечность 
		///   0 &lt;<paramref name="newBase" />&lt; 1 
		///   -бесконечность 
		///  <paramref name="a" /> = +бесконечность 
		///  <paramref name="newBase" />&gt; 1 
		///   +бесконечность 
		///  <paramref name="a" /> = 1 
		///  <paramref name="newBase" /> = 0 
		///   0 
		///  <paramref name="a" /> = 1 
		///  <paramref name="newBase" /> = +бесконечность 
		///   0</returns>
		// Token: 0x06000CE1 RID: 3297 RVA: 0x000332A4 File Offset: 0x000314A4
		public static double Log(double a, double newBase)
		{
			if (double.IsNaN(a))
			{
				return a;
			}
			if (double.IsNaN(newBase))
			{
				return newBase;
			}
			if (newBase == 1.0)
			{
				return double.NaN;
			}
			if (a != 1.0 && (newBase == 0.0 || double.IsPositiveInfinity(newBase)))
			{
				return double.NaN;
			}
			return Math.Log(a) / Math.Log(newBase);
		}

		/// <summary>Возвращает большее из двух 8-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 8-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 8-разрядных целых чисел без знака.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CE2 RID: 3298 RVA: 0x00033312 File Offset: 0x00031512
		[NonVersionable]
		public static byte Max(byte val1, byte val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух десятичных чисел.</summary>
		/// <param name="val1">Первое из двух сравниваемых десятичных чисел.</param>
		/// <param name="val2">Второе из двух сравниваемых десятичных чисел.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CE3 RID: 3299 RVA: 0x0003331B File Offset: 0x0003151B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static decimal Max(decimal val1, decimal val2)
		{
			return *decimal.Max(ref val1, ref val2);
		}

		/// <summary>Возвращает большее из двух чисел двойной точности с плавающей запятой.</summary>
		/// <param name="val1">Первое из двух сравниваемых чисел двойной точности с плавающей запятой.</param>
		/// <param name="val2">Второе из двух сравниваемых чисел двойной точности с плавающей запятой.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />. Если <paramref name="val1" />, <paramref name="val2" /> или оба параметра <paramref name="val1" /> и <paramref name="val2" /> равны <see cref="F:System.Double.NaN" />, возвращается значение <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000CE4 RID: 3300 RVA: 0x0003332B File Offset: 0x0003152B
		public static double Max(double val1, double val2)
		{
			if (val1 > val2)
			{
				return val1;
			}
			if (double.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Возвращает большее из двух 16-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 16-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 16-разрядных целых чисел со знаком.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CE5 RID: 3301 RVA: 0x00033312 File Offset: 0x00031512
		[NonVersionable]
		public static short Max(short val1, short val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух 32-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 32-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 32-разрядных целых чисел со знаком.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CE6 RID: 3302 RVA: 0x00033312 File Offset: 0x00031512
		[NonVersionable]
		public static int Max(int val1, int val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух 64-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 64-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 64-разрядных целых чисел со знаком.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CE7 RID: 3303 RVA: 0x00033312 File Offset: 0x00031512
		[NonVersionable]
		public static long Max(long val1, long val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух 8-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 8-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 8-разрядных целых чисел со знаком.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CE8 RID: 3304 RVA: 0x00033312 File Offset: 0x00031512
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Max(sbyte val1, sbyte val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух чисел одинарной точности с плавающей запятой.</summary>
		/// <param name="val1">Первое из двух сравниваемых чисел одинарной точности с плавающей запятой.</param>
		/// <param name="val2">Второе из двух сравниваемых чисел одинарной точности с плавающей запятой.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />. Если <paramref name="val1" />, <paramref name="val2" /> или оба параметра <paramref name="val1" /> и <paramref name="val2" /> равны <see cref="F:System.Single.NaN" />, возвращается значение <see cref="F:System.Single.NaN" />.</returns>
		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003333E File Offset: 0x0003153E
		public static float Max(float val1, float val2)
		{
			if (val1 > val2)
			{
				return val1;
			}
			if (float.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Возвращает большее из двух 16-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 16-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 16-разрядных целых чисел без знака.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CEA RID: 3306 RVA: 0x00033312 File Offset: 0x00031512
		[NonVersionable]
		[CLSCompliant(false)]
		public static ushort Max(ushort val1, ushort val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух 32-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 32-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 32-разрядных целых чисел без знака.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CEB RID: 3307 RVA: 0x00033351 File Offset: 0x00031551
		[NonVersionable]
		[CLSCompliant(false)]
		public static uint Max(uint val1, uint val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает большее из двух 64-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 64-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 64-разрядных целых чисел без знака.</param>
		/// <returns>Большее из значений двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CEC RID: 3308 RVA: 0x00033351 File Offset: 0x00031551
		[NonVersionable]
		[CLSCompliant(false)]
		public static ulong Max(ulong val1, ulong val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух 8-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 8-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 8-разрядных целых чисел без знака.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CED RID: 3309 RVA: 0x0003335A File Offset: 0x0003155A
		[NonVersionable]
		public static byte Min(byte val1, byte val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух десятичных чисел.</summary>
		/// <param name="val1">Первое из двух сравниваемых десятичных чисел.</param>
		/// <param name="val2">Второе из двух сравниваемых десятичных чисел.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CEE RID: 3310 RVA: 0x00033363 File Offset: 0x00031563
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static decimal Min(decimal val1, decimal val2)
		{
			return *decimal.Min(ref val1, ref val2);
		}

		/// <summary>Возвращает меньшее из двух чисел двойной точности с плавающей запятой.</summary>
		/// <param name="val1">Первое из двух сравниваемых чисел двойной точности с плавающей запятой.</param>
		/// <param name="val2">Второе из двух сравниваемых чисел двойной точности с плавающей запятой.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />. Если <paramref name="val1" />, <paramref name="val2" /> или оба параметра <paramref name="val1" /> и <paramref name="val2" /> равны <see cref="F:System.Double.NaN" />, возвращается значение <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000CEF RID: 3311 RVA: 0x00033373 File Offset: 0x00031573
		public static double Min(double val1, double val2)
		{
			if (val1 < val2)
			{
				return val1;
			}
			if (double.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Возвращает меньшее из двух 16-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 16-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 16-разрядных целых чисел со знаком.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003335A File Offset: 0x0003155A
		[NonVersionable]
		public static short Min(short val1, short val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух 32-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 32-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 32-разрядных целых чисел со знаком.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003335A File Offset: 0x0003155A
		[NonVersionable]
		public static int Min(int val1, int val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух 64-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 64-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 64-разрядных целых чисел со знаком.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003335A File Offset: 0x0003155A
		[NonVersionable]
		public static long Min(long val1, long val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух 8-битовых целых чисел со знаком.</summary>
		/// <param name="val1">Первое из двух сравниваемых 8-разрядных целых чисел со знаком.</param>
		/// <param name="val2">Второе из двух сравниваемых 8-разрядных целых чисел со знаком.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003335A File Offset: 0x0003155A
		[NonVersionable]
		[CLSCompliant(false)]
		public static sbyte Min(sbyte val1, sbyte val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух чисел одинарной точности с плавающей запятой.</summary>
		/// <param name="val1">Первое из двух сравниваемых чисел одинарной точности с плавающей запятой.</param>
		/// <param name="val2">Второе из двух сравниваемых чисел одинарной точности с плавающей запятой.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />. Если <paramref name="val1" />, <paramref name="val2" /> или оба параметра <paramref name="val1" /> и <paramref name="val2" /> равны <see cref="F:System.Single.NaN" />, возвращается значение <see cref="F:System.Single.NaN" />.</returns>
		// Token: 0x06000CF4 RID: 3316 RVA: 0x00033386 File Offset: 0x00031586
		public static float Min(float val1, float val2)
		{
			if (val1 < val2)
			{
				return val1;
			}
			if (float.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Возвращает меньшее из двух 16-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 16-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 16-разрядных целых чисел без знака.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003335A File Offset: 0x0003155A
		[NonVersionable]
		[CLSCompliant(false)]
		public static ushort Min(ushort val1, ushort val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух 32-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 32-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 32-разрядных целых чисел без знака.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF6 RID: 3318 RVA: 0x00033399 File Offset: 0x00031599
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Min(uint val1, uint val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Возвращает меньшее из двух 64-битовых целых чисел без знака.</summary>
		/// <param name="val1">Первое из двух сравниваемых 64-разрядных целых чисел без знака.</param>
		/// <param name="val2">Второе из двух сравниваемых 64-разрядных целых чисел без знака.</param>
		/// <returns>Меньший из двух параметров, <paramref name="val1" /> или <paramref name="val2" />.</returns>
		// Token: 0x06000CF7 RID: 3319 RVA: 0x00033399 File Offset: 0x00031599
		[NonVersionable]
		[CLSCompliant(false)]
		public static ulong Min(ulong val1, ulong val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Округляет десятичное значение до ближайшего целого значения; значения посередине округляются до ближайшего четного числа.</summary>
		/// <param name="d">Округляемое десятичное число.</param>
		/// <returns>Целое число, ближайшее к значению параметра <paramref name="d" />. Если дробная часть <paramref name="d" /> находится на равном расстоянии от двух целых чисел (четного и нечетного), возвращается четное число. Обратите внимание, что данный метод возвращает не целочисленное значение, а значение типа <see cref="T:System.Decimal" />.</returns>
		/// <exception cref="T:System.OverflowException">Полученное значение находится вне допустимого диапазона типа <see cref="T:System.Decimal" />.</exception>
		// Token: 0x06000CF8 RID: 3320 RVA: 0x000333A2 File Offset: 0x000315A2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d)
		{
			return decimal.Round(d, 0);
		}

		/// <summary>Округляет десятичное значение до указанного числа знаков после запятой; значения посередине округляются до ближайшего четного числа.</summary>
		/// <param name="d">Округляемое десятичное число.</param>
		/// <param name="decimals">Количество десятичных разрядов в возвращаемом значении.</param>
		/// <returns>Число, ближайшее к параметру <paramref name="d" />, количество цифр дробной части которого равно <paramref name="decimals" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="decimals" /> имеет значение меньше 0 или больше 28.</exception>
		/// <exception cref="T:System.OverflowException">Полученное значение находится вне допустимого диапазона типа <see cref="T:System.Decimal" />.</exception>
		// Token: 0x06000CF9 RID: 3321 RVA: 0x000333AB File Offset: 0x000315AB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d, int decimals)
		{
			return decimal.Round(d, decimals);
		}

		/// <summary>Округляет десятичное значение до ближайшего целого числа; использует указанное соглашение для округления значений посередине.</summary>
		/// <param name="d">Округляемое десятичное число.</param>
		/// <param name="mode">Значение, задающее правило округления параметра <paramref name="d" />, если его значение находится ровно посредине между двумя другими числами.</param>
		/// <returns>Целое число, ближайшее к значению параметра <paramref name="d" />. Если <paramref name="d" /> находится на равном расстоянии от двух чисел (четного и нечетного), то возвращаемое число определяется по значению параметра <paramref name="mode" />. Обратите внимание, что данный метод возвращает не целочисленное значение, а значение типа <see cref="T:System.Decimal" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.MidpointRounding" />.</exception>
		/// <exception cref="T:System.OverflowException">Полученное значение находится вне допустимого диапазона типа <see cref="T:System.Decimal" />.</exception>
		// Token: 0x06000CFA RID: 3322 RVA: 0x000333B4 File Offset: 0x000315B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d, MidpointRounding mode)
		{
			return decimal.Round(d, 0, mode);
		}

		/// <summary>Округляет десятичное значение до указанного числа знаков после запятой; использует указанное соглашение для округления значений посередине.</summary>
		/// <param name="d">Округляемое десятичное число.</param>
		/// <param name="decimals">Количество десятичных разрядов в возвращаемом значении.</param>
		/// <param name="mode">Значение, задающее правило округления параметра <paramref name="d" />, если его значение находится ровно посредине между двумя другими числами.</param>
		/// <returns>Число, ближайшее к параметру <paramref name="d" />, количество цифр дробной части которого равно <paramref name="decimals" />. Если <paramref name="d" /> имеет меньшее количество цифр дробной части, чем <paramref name="decimals" />, то <paramref name="d" /> возвращается без изменений.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="decimals" /> имеет значение меньше 0 или больше 28.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.MidpointRounding" />.</exception>
		/// <exception cref="T:System.OverflowException">Полученное значение находится вне допустимого диапазона типа <see cref="T:System.Decimal" />.</exception>
		// Token: 0x06000CFB RID: 3323 RVA: 0x000333BE File Offset: 0x000315BE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d, int decimals, MidpointRounding mode)
		{
			return decimal.Round(d, decimals, mode);
		}

		/// <summary>Округляет значение с плавающей запятой двойной точности до ближайшего целого значения; значения посередине округляются до ближайшего четного числа.</summary>
		/// <param name="a">Округляемое число двойной точности с плавающей запятой.</param>
		/// <returns>Целое число, ближайшее к значению параметра <paramref name="a" />. Если дробная часть <paramref name="a" /> находится на равном расстоянии от двух целых чисел (четного и нечетного), возвращается четное число. Обратите внимание, что данный метод возвращает не целочисленное значение, а значение типа <see cref="T:System.Double" />.</returns>
		// Token: 0x06000CFC RID: 3324
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Round(double a);

		/// <summary>Округляет значение с плавающей запятой двойной точности до указанного числа знаков после запятой; значения посередине округляются до ближайшего четного числа.</summary>
		/// <param name="value">Округляемое число двойной точности с плавающей запятой.</param>
		/// <param name="digits">Количество цифр дробной части в возвращаемом значении.</param>
		/// <returns>Число, ближайшее к параметру <paramref name="value" />, количество цифр дробной части которого равно <paramref name="digits" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="digits" /> имеет значение меньше 0 или больше 15.</exception>
		// Token: 0x06000CFD RID: 3325 RVA: 0x000333C8 File Offset: 0x000315C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, int digits)
		{
			return Math.Round(value, digits, MidpointRounding.ToEven);
		}

		/// <summary>Округляет значение с плавающей запятой двойной точности до ближайшего целого числа; использует указанное соглашение для округления значений посередине.</summary>
		/// <param name="value">Округляемое число двойной точности с плавающей запятой.</param>
		/// <param name="mode">Значение, задающее правило округления параметра <paramref name="value" />, если его значение находится ровно посредине между двумя другими числами.</param>
		/// <returns>Целое число, ближайшее к значению параметра <paramref name="value" />. Если <paramref name="value" /> находится на равном расстоянии от двух целых чисел (четного и нечетного), то возвращаемое число определяется по значению параметра <paramref name="mode" />. Обратите внимание, что данный метод возвращает не целочисленное значение, а значение типа <see cref="T:System.Double" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.MidpointRounding" />.</exception>
		// Token: 0x06000CFE RID: 3326 RVA: 0x000333D2 File Offset: 0x000315D2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, MidpointRounding mode)
		{
			return Math.Round(value, 0, mode);
		}

		/// <summary>Округляет значение с плавающей запятой двойной точности до указанного числа знаков после запятой; использует указанное соглашение для округления значений посередине.</summary>
		/// <param name="value">Округляемое число двойной точности с плавающей запятой.</param>
		/// <param name="digits">Количество цифр дробной части в возвращаемом значении.</param>
		/// <param name="mode">Значение, задающее правило округления параметра <paramref name="value" />, если его значение находится ровно посредине между двумя другими числами.</param>
		/// <returns>Число, ближайшее к параметру <paramref name="value" />, количество цифр дробной части которого равно <paramref name="digits" />. Если <paramref name="value" /> имеет меньшее количество цифр дробной части, чем <paramref name="digits" />, то <paramref name="value" /> возвращается без изменений.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="digits" /> имеет значение меньше 0 или больше 15.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.MidpointRounding" />.</exception>
		// Token: 0x06000CFF RID: 3327 RVA: 0x000333DC File Offset: 0x000315DC
		public unsafe static double Round(double value, int digits, MidpointRounding mode)
		{
			if (digits < 0 || digits > 15)
			{
				throw new ArgumentOutOfRangeException("digits", "Rounding digits must be between 0 and 15, inclusive.");
			}
			if (mode < MidpointRounding.ToEven || mode > MidpointRounding.AwayFromZero)
			{
				throw new ArgumentException(SR.Format("The value '{0}' is not valid for this usage of the type {1}.", mode, "MidpointRounding"), "mode");
			}
			if (Math.Abs(value) < Math.doubleRoundLimit)
			{
				double num = Math.roundPower10Double[digits];
				value *= num;
				if (mode == MidpointRounding.AwayFromZero)
				{
					double value2 = Math.ModF(value, &value);
					if (Math.Abs(value2) >= 0.5)
					{
						value += (double)Math.Sign(value2);
					}
				}
				else
				{
					value = Math.Round(value);
				}
				value /= num;
			}
			return value;
		}

		/// <summary>Возвращает целое число, указывающее знак десятичного числа.</summary>
		/// <param name="value">Десятичное число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		// Token: 0x06000D00 RID: 3328 RVA: 0x0003347E File Offset: 0x0003167E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(decimal value)
		{
			return decimal.Sign(ref value);
		}

		/// <summary>Возвращает целое число, обозначающее знак числа двойной точности с плавающей запятой.</summary>
		/// <param name="value">Число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		/// <exception cref="T:System.ArithmeticException">
		///   <paramref name="value" /> равно <see cref="F:System.Double.NaN" />.</exception>
		// Token: 0x06000D01 RID: 3329 RVA: 0x00033487 File Offset: 0x00031687
		public static int Sign(double value)
		{
			if (value < 0.0)
			{
				return -1;
			}
			if (value > 0.0)
			{
				return 1;
			}
			if (value == 0.0)
			{
				return 0;
			}
			throw new ArithmeticException("Function does not accept floating point Not-a-Number values.");
		}

		/// <summary>Возвращает целое число, указывающее знак 16-разрядного целого числа со знаком.</summary>
		/// <param name="value">Число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		// Token: 0x06000D02 RID: 3330 RVA: 0x000334BD File Offset: 0x000316BD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(short value)
		{
			return Math.Sign((int)value);
		}

		/// <summary>Возвращает целое число, указывающее знак 32-разрядного целого числа со знаком.</summary>
		/// <param name="value">Число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		// Token: 0x06000D03 RID: 3331 RVA: 0x000334C5 File Offset: 0x000316C5
		public static int Sign(int value)
		{
			return value >> 31 | (int)((uint)(-(uint)value) >> 31);
		}

		/// <summary>Возвращает целое число, указывающее знак 64-разрядного целого числа со знаком.</summary>
		/// <param name="value">Число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		// Token: 0x06000D04 RID: 3332 RVA: 0x000334D1 File Offset: 0x000316D1
		public static int Sign(long value)
		{
			return (int)(value >> 63 | (long)((ulong)(-(ulong)value) >> 63));
		}

		/// <summary>Возвращает целое число, указывающее знак 8-разрядного целого числа со знаком.</summary>
		/// <param name="value">Число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		// Token: 0x06000D05 RID: 3333 RVA: 0x000334BD File Offset: 0x000316BD
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(sbyte value)
		{
			return Math.Sign((int)value);
		}

		/// <summary>Возвращает целое число, обозначающее знак числа с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Число со знаком.</param>
		/// <returns>Число, которое указывает знак значения <paramref name="value" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   -1 
		///  Значение параметра <paramref name="value" /> меньше нуля.  
		///
		///   0 
		///  Значение параметра <paramref name="value" /> равно нулю.  
		///
		///   1 
		///  Значение параметра <paramref name="value" /> больше нуля.</returns>
		/// <exception cref="T:System.ArithmeticException">
		///   <paramref name="value" /> равно <see cref="F:System.Single.NaN" />.</exception>
		// Token: 0x06000D06 RID: 3334 RVA: 0x000334DE File Offset: 0x000316DE
		public static int Sign(float value)
		{
			if (value < 0f)
			{
				return -1;
			}
			if (value > 0f)
			{
				return 1;
			}
			if (value == 0f)
			{
				return 0;
			}
			throw new ArithmeticException("Function does not accept floating point Not-a-Number values.");
		}

		/// <summary>Вычисляет целую часть заданного десятичного числа.</summary>
		/// <param name="d">Усекаемое число.</param>
		/// <returns>Целая часть <paramref name="d" />, то есть число, остающееся после отбрасывания дробной части.</returns>
		// Token: 0x06000D07 RID: 3335 RVA: 0x00033508 File Offset: 0x00031708
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Truncate(decimal d)
		{
			return decimal.Truncate(d);
		}

		/// <summary>Вычисляет целую часть заданного числа двойной точности с плавающей запятой.</summary>
		/// <param name="d">Усекаемое число.</param>
		/// <returns>Целая часть <paramref name="d" />, то есть число, которое остается после отбрасывания всех цифр дробной части, или одно из значений, перечисленных в следующей таблице.  
		///  <paramref name="d" /> Возвращаемое значение 
		///  <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
		// Token: 0x06000D08 RID: 3336 RVA: 0x00033510 File Offset: 0x00031710
		public unsafe static double Truncate(double d)
		{
			Math.ModF(d, &d);
			return d;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00033520 File Offset: 0x00031720
		private static double copysign(double x, double y)
		{
			long num = BitConverter.DoubleToInt64Bits(x);
			long num2 = BitConverter.DoubleToInt64Bits(y);
			if ((num ^ num2) >> 63 != 0L)
			{
				return BitConverter.Int64BitsToDouble(num ^ long.MinValue);
			}
			return x;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00033555 File Offset: 0x00031755
		private static void ThrowMinMaxException<T>(T min, T max)
		{
			throw new ArgumentException(SR.Format("'{0}' cannot be greater than {1}.", min, max));
		}

		/// <summary>Возвращает абсолютное значение числа двойной точности с плавающей запятой.</summary>
		/// <param name="value">Число, которое больше или равно значению <see cref="F:System.Double.MinValue" />, но меньше или равно значению <see cref="F:System.Double.MaxValue" />.</param>
		/// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤<see cref="F:System.Double.MaxValue" />.</returns>
		// Token: 0x06000D0B RID: 3339
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Abs(double value);

		/// <summary>Возвращает абсолютное значение числа одинарной точности с плавающей запятой.</summary>
		/// <param name="value">Число, которое больше или равно значению <see cref="F:System.Single.MinValue" />, но меньше или равно значению <see cref="F:System.Single.MaxValue" />.</param>
		/// <returns>Число х одинарной точности с плавающей запятой, такое, что 0 ≤ x ≤<see cref="F:System.Single.MaxValue" />.</returns>
		// Token: 0x06000D0C RID: 3340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Abs(float value);

		/// <summary>Возвращает угол, косинус которого равен указанному числу.</summary>
		/// <param name="d">Число, представляющее косинус, где значение параметра <paramref name="d" /> должно быть больше или равно -1, но меньше или равно 1.</param>
		/// <returns>Угол θ, измеренный в радианах, такой, что 0 ≤θ≤π 
		/// -или- 
		///  Значение <see cref="F:System.Double.NaN" />, если <paramref name="d" /> &lt; –1 или <paramref name="d" /> &gt; 1 или значение параметра <paramref name="d" /> равно <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D0D RID: 3341
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Acos(double d);

		// Token: 0x06000D0E RID: 3342
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Acosh(double d);

		/// <summary>Возвращает угол, синус которого равен указанному числу.</summary>
		/// <param name="d">Число, представляющее синус, где значение параметра <paramref name="d" /> должно быть больше или равно -1, но меньше или равно 1.</param>
		/// <returns>Угол θ, измеренный в радианах, такой, что -π/2 ≤θ≤π/2 
		/// -или- 
		///  Значение <see cref="F:System.Double.NaN" />, если <paramref name="d" /> &lt; –1 или <paramref name="d" /> &gt; 1 или значение параметра <paramref name="d" /> равно <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D0F RID: 3343
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Asin(double d);

		// Token: 0x06000D10 RID: 3344
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Asinh(double d);

		/// <summary>Возвращает угол, тангенс которого равен указанному числу.</summary>
		/// <param name="d">Число, представляющее тангенс.</param>
		/// <returns>Угол θ, измеренный в радианах, такой, что -π/2 ≤θ≤π/2.  
		/// -или- 
		///  Значение <see cref="F:System.Double.NaN" />, если <paramref name="d" /> равно <see cref="F:System.Double.NaN" />, -π/2, округленное до двойной точности (–1,5707963267949), если <paramref name="d" /> равно <see cref="F:System.Double.NegativeInfinity" />, или π/2, округленное до двойной точности (1,5707963267949), если <paramref name="d" /> равно <see cref="F:System.Double.PositiveInfinity" />.</returns>
		// Token: 0x06000D11 RID: 3345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Atan(double d);

		/// <summary>Возвращает угол, тангенс которого равен отношению двух указанных чисел.</summary>
		/// <param name="y">Координата y точки.</param>
		/// <param name="x">Координата х точки.</param>
		/// <returns>Угол θ, измеренный в радианах, такой, что -π≤θ≤π, и tan(θ) = <paramref name="y" /> / <paramref name="x" />, где (<paramref name="x" />, <paramref name="y" />) — это точка в декартовой системе координат. Обратите внимание на следующее. 
		/// – Для (<paramref name="x" />, <paramref name="y" />) в квадранте 1, 0 &lt; θ &lt; π/2.  
		/// – Для (<paramref name="x" />, <paramref name="y" />) в квадранте 2, π/2 &lt; θ≤π.  
		/// – Для (<paramref name="x" />, <paramref name="y" />) в квадранте 3, -π &lt; θ &lt; -π/2.  
		/// – Для (<paramref name="x" />, <paramref name="y" />) в квадранте 4, -π/2 &lt; θ &lt; 0.  
		/// Для точек за пределами указанных квадрантов возвращаемое значение указано ниже. 
		/// – Если y равно 0, и x не является отрицательным, то θ = 0.  
		/// – Если y равно 0, и x является отрицательным, то θ = π.  
		/// – Если y — положительное число, а x равно 0, то θ = π/2.  
		/// – Если y — отрицательное число, а х равно 0, то θ = -π/2.  
		/// – Если y равен 0, и х равен 0, то θ = 0.  
		/// Если значение параметра <paramref name="x" /> или <paramref name="y" /> равно <see cref="F:System.Double.NaN" /> либо если значения параметров <paramref name="x" /> и <paramref name="y" /> равны значению <see cref="F:System.Double.PositiveInfinity" /> или <see cref="F:System.Double.NegativeInfinity" />, метод возвращает значение <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D12 RID: 3346
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Atan2(double y, double x);

		// Token: 0x06000D13 RID: 3347
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Atanh(double d);

		// Token: 0x06000D14 RID: 3348
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Cbrt(double d);

		/// <summary>Возвращает наименьшее целое число, которое больше или равно заданному числу с плавающей запятой двойной точности.</summary>
		/// <param name="a">Число двойной точности с плавающей запятой.</param>
		/// <returns>Наименьшее целочисленное значение, которое больше или равно <paramref name="a" />. Если значение параметра <paramref name="a" /> равно  <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />, возвращается это значение. Обратите внимание, что данный метод возвращает не целочисленное значение, а значение типа <see cref="T:System.Double" />.</returns>
		// Token: 0x06000D15 RID: 3349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Ceiling(double a);

		/// <summary>Возвращает косинус указанного угла.</summary>
		/// <param name="d">Угол, измеряемый в радианах.</param>
		/// <returns>Косинус <paramref name="d" />. Если значение параметра <paramref name="d" /> равно <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />, то данный метод возвращает <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D16 RID: 3350
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Cos(double d);

		/// <summary>Возвращает гиперболический косинус указанного угла.</summary>
		/// <param name="value">Угол, измеряемый в радианах.</param>
		/// <returns>Гиперболический косинус <paramref name="value" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />, возвращается значение <see cref="F:System.Double.PositiveInfinity" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.Double.NaN" />, возвращается значение <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D17 RID: 3351
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Cosh(double value);

		/// <summary>Возвращает значение <see langword="e" />, возведенное в указанную степень.</summary>
		/// <param name="d">Число, определяющее степень.</param>
		/// <returns>Число <see langword="e" />, возведенное в степень <paramref name="d" />. Если значение параметра <paramref name="d" /> равно <see cref="F:System.Double.NaN" /> или <see cref="F:System.Double.PositiveInfinity" />, возвращается это значение. Если значение параметра <paramref name="d" /> равно <see cref="F:System.Double.NegativeInfinity" />, возвращается значение 0.</returns>
		// Token: 0x06000D18 RID: 3352
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Exp(double d);

		/// <summary>Возвращает наибольшее целое число, которое меньше или равно заданному числу с плавающей запятой двойной точности.</summary>
		/// <param name="d">Число двойной точности с плавающей запятой.</param>
		/// <returns>Наибольшее целое число, которое меньше или равно <paramref name="d" />. Если значение параметра <paramref name="d" /> равно  <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />, возвращается это значение.</returns>
		// Token: 0x06000D19 RID: 3353
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Floor(double d);

		/// <summary>Возвращает натуральный логарифм (с основанием <see langword="e" />) указанного числа.</summary>
		/// <param name="d">Число, логарифм которого требуется найти.</param>
		/// <returns>Одно из значений, перечисленных в следующей таблице.  
		///  Параметр <paramref name="d" /> 
		///   Возвращаемое значение 
		///   Положительное число 
		///   Натуральный логарифм <paramref name="d" />, то есть ln <paramref name="d" /> или log e <paramref name="d" /> Нуль 
		///  <see cref="F:System.Double.NegativeInfinity" /> Отрицательное число 
		///  <see cref="F:System.Double.NaN" /> Равно значению <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /> Равно значению <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
		// Token: 0x06000D1A RID: 3354
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Log(double d);

		/// <summary>Возвращает логарифм с основанием 10 указанного числа.</summary>
		/// <param name="d">Число, логарифм которого должен быть найден.</param>
		/// <returns>Одно из значений, перечисленных в следующей таблице.  
		///  Параметр <paramref name="d" /> 
		///   Возвращаемое значение 
		///   Положительное число 
		///   Основание 10 логарифма <paramref name="d" />, то есть log 10<paramref name="d" />.  
		///
		///   Нуль 
		///  <see cref="F:System.Double.NegativeInfinity" /> Отрицательное число 
		///  <see cref="F:System.Double.NaN" /> Равно значению <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /> Равно значению <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
		// Token: 0x06000D1B RID: 3355
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Log10(double d);

		/// <summary>Возвращает указанное число, возведенное в указанную степень.</summary>
		/// <param name="x">Число двойной точности с плавающей запятой, возводимое в степень.</param>
		/// <param name="y">Число двойной точности с плавающей запятой, задающее степень.</param>
		/// <returns>Число <paramref name="x" />, возведенное в степень <paramref name="y" />.</returns>
		// Token: 0x06000D1C RID: 3356
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Pow(double x, double y);

		/// <summary>Возвращает синус указанного угла.</summary>
		/// <param name="a">Угол, измеряемый в радианах.</param>
		/// <returns>Синус <paramref name="a" />. Если значение параметра <paramref name="a" /> равно <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />, то данный метод возвращает <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D1D RID: 3357
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sin(double a);

		/// <summary>Возвращает гиперболический синус указанного угла.</summary>
		/// <param name="value">Угол, измеряемый в радианах.</param>
		/// <returns>Гиперболический синус <paramref name="value" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.Double.NegativeInfinity" />, <see cref="F:System.Double.PositiveInfinity" /> или <see cref="F:System.Double.NaN" />, то этот метод возвращает значение <see cref="T:System.Double" />, равное <paramref name="value" />.</returns>
		// Token: 0x06000D1E RID: 3358
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sinh(double value);

		/// <summary>Возвращает квадратный корень из указанного числа.</summary>
		/// <param name="d">Число, квадратный корень которого требуется найти.</param>
		/// <returns>Одно из значений, перечисленных в следующей таблице.  
		///  Параметр <paramref name="d" /> 
		///   Возвращаемое значение 
		///   Нуль или положительное число 
		///   Положительный квадратный корень из <paramref name="d" />.  
		///
		///   Отрицательное число 
		///  <see cref="F:System.Double.NaN" /> Равняется <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /> Равняется <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
		// Token: 0x06000D1F RID: 3359
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sqrt(double d);

		/// <summary>Возвращает тангенс указанного угла.</summary>
		/// <param name="a">Угол, измеряемый в радианах.</param>
		/// <returns>Тангенс <paramref name="a" />. Если значение параметра <paramref name="a" /> равно <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />, то данный метод возвращает <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D20 RID: 3360
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Tan(double a);

		/// <summary>Возвращает гиперболический тангенс указанного угла.</summary>
		/// <param name="value">Угол, измеряемый в радианах.</param>
		/// <returns>Гиперболический тангенс <paramref name="value" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.Double.NegativeInfinity" />, этот метод возвращает -1. Если значение равно <see cref="F:System.Double.PositiveInfinity" />, этот метод возвращает 1. Если значение параметра <paramref name="value" /> равно <see cref="F:System.Double.NaN" />, этот метод возвращает <see cref="F:System.Double.NaN" />.</returns>
		// Token: 0x06000D21 RID: 3361
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Tanh(double value);

		// Token: 0x06000D22 RID: 3362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double FMod(double x, double y);

		// Token: 0x06000D23 RID: 3363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern double ModF(double x, double* intptr);

		/// <summary>Представляет основание натурального логарифма, определяемое константой <see langword="e" />.</summary>
		// Token: 0x04001272 RID: 4722
		public const double E = 2.718281828459045;

		/// <summary>Представляет отношение длины окружности к ее диаметру, определяемое константой π.</summary>
		// Token: 0x04001273 RID: 4723
		public const double PI = 3.141592653589793;

		// Token: 0x04001274 RID: 4724
		private const int maxRoundingDigits = 15;

		// Token: 0x04001275 RID: 4725
		private static double doubleRoundLimit = 10000000000000000.0;

		// Token: 0x04001276 RID: 4726
		private static double[] roundPower10Double = new double[]
		{
			1.0,
			10.0,
			100.0,
			1000.0,
			10000.0,
			100000.0,
			1000000.0,
			10000000.0,
			100000000.0,
			1000000000.0,
			10000000000.0,
			100000000000.0,
			1000000000000.0,
			10000000000000.0,
			100000000000000.0,
			1000000000000000.0
		};
	}
}
