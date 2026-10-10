using System;
using System.Diagnostics;
using System.Globalization;

namespace System.Numerics
{
	/// <summary>Представляет произвольно большое целое число со знаком.</summary>
	// Token: 0x0200000D RID: 13
	[Serializable]
	public readonly struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя 32-разрядное знаковое целое число.</summary>
		/// <param name="value">32-разрядное знаковое целое число.</param>
		// Token: 0x06000136 RID: 310 RVA: 0x0000AF6D File Offset: 0x0000916D
		public BigInteger(int value)
		{
			if (value == -2147483648)
			{
				this = BigInteger.s_bnMinInt;
				return;
			}
			this._sign = value;
			this._bits = null;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя 32-разрядное целое число без знака.</summary>
		/// <param name="value">32-разрядное целое значение без знака.</param>
		// Token: 0x06000137 RID: 311 RVA: 0x0000AF91 File Offset: 0x00009191
		[CLSCompliant(false)]
		public BigInteger(uint value)
		{
			if (value <= 2147483647U)
			{
				this._sign = (int)value;
				this._bits = null;
				return;
			}
			this._sign = 1;
			this._bits = new uint[1];
			this._bits[0] = value;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя 64-разрядное целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число со знаком.</param>
		// Token: 0x06000138 RID: 312 RVA: 0x0000AFC8 File Offset: 0x000091C8
		public BigInteger(long value)
		{
			if (-2147483648L < value && value <= 2147483647L)
			{
				this._sign = (int)value;
				this._bits = null;
				return;
			}
			if (value == -2147483648L)
			{
				this = BigInteger.s_bnMinInt;
				return;
			}
			ulong num;
			if (value < 0L)
			{
				num = (ulong)(-(ulong)value);
				this._sign = -1;
			}
			else
			{
				num = (ulong)value;
				this._sign = 1;
			}
			if (num <= (ulong)-1)
			{
				this._bits = new uint[1];
				this._bits[0] = (uint)num;
				return;
			}
			this._bits = new uint[2];
			this._bits[0] = (uint)num;
			this._bits[1] = (uint)(num >> 32);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя 64-разрядное целое число без знака.</summary>
		/// <param name="value">64-разрядное целое число без знака.</param>
		// Token: 0x06000139 RID: 313 RVA: 0x0000B068 File Offset: 0x00009268
		[CLSCompliant(false)]
		public BigInteger(ulong value)
		{
			if (value <= 2147483647UL)
			{
				this._sign = (int)value;
				this._bits = null;
				return;
			}
			if (value <= (ulong)-1)
			{
				this._sign = 1;
				this._bits = new uint[1];
				this._bits[0] = (uint)value;
				return;
			}
			this._sign = 1;
			this._bits = new uint[2];
			this._bits[0] = (uint)value;
			this._bits[1] = (uint)(value >> 32);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя значение с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Значение с плавающей точкой одинарной точности.</param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> имеет значение <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NegativeInfinity" /> или <see cref="F:System.Single.PositiveInfinity" />.</exception>
		// Token: 0x0600013A RID: 314 RVA: 0x0000B0DB File Offset: 0x000092DB
		public BigInteger(float value)
		{
			this = new BigInteger((double)value);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя значение с плавающей запятой двойной точности.</summary>
		/// <param name="value">Значение с плавающей точкой двойной точности.</param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> имеет значение <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" /> или <see cref="F:System.Double.PositiveInfinity" />.</exception>
		// Token: 0x0600013B RID: 315 RVA: 0x0000B0E8 File Offset: 0x000092E8
		public BigInteger(double value)
		{
			if (!double.IsFinite(value))
			{
				if (double.IsInfinity(value))
				{
					throw new OverflowException("BigInteger cannot represent infinity.");
				}
				throw new OverflowException("The value is not a number.");
			}
			else
			{
				this._sign = 0;
				this._bits = null;
				int num;
				int num2;
				ulong num3;
				bool flag;
				NumericsHelpers.GetDoubleParts(value, out num, out num2, out num3, out flag);
				if (num3 == 0UL)
				{
					this = BigInteger.Zero;
					return;
				}
				if (num2 <= 0)
				{
					if (num2 <= -64)
					{
						this = BigInteger.Zero;
						return;
					}
					this = num3 >> -num2;
					if (num < 0)
					{
						this._sign = -this._sign;
						return;
					}
				}
				else if (num2 <= 11)
				{
					this = num3 << num2;
					if (num < 0)
					{
						this._sign = -this._sign;
						return;
					}
				}
				else
				{
					num3 <<= 11;
					num2 -= 11;
					int num4 = (num2 - 1) / 32 + 1;
					int num5 = num4 * 32 - num2;
					this._bits = new uint[num4 + 2];
					this._bits[num4 + 1] = (uint)(num3 >> num5 + 32);
					this._bits[num4] = (uint)(num3 >> num5);
					if (num5 > 0)
					{
						this._bits[num4 - 1] = (uint)num3 << 32 - num5;
					}
					this._sign = num;
				}
				return;
			}
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя значение <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Десятичное число.</param>
		// Token: 0x0600013C RID: 316 RVA: 0x0000B224 File Offset: 0x00009424
		public BigInteger(decimal value)
		{
			int[] bits = decimal.GetBits(decimal.Truncate(value));
			int num = 3;
			while (num > 0 && bits[num - 1] == 0)
			{
				num--;
			}
			if (num == 0)
			{
				this = BigInteger.s_bnZeroInt;
				return;
			}
			if (num == 1 && bits[0] > 0)
			{
				this._sign = bits[0];
				this._sign *= (((bits[3] & int.MinValue) != 0) ? -1 : 1);
				this._bits = null;
				return;
			}
			this._bits = new uint[num];
			this._bits[0] = (uint)bits[0];
			if (num > 1)
			{
				this._bits[1] = (uint)bits[1];
			}
			if (num > 2)
			{
				this._bits[2] = (uint)bits[2];
			}
			this._sign = (((bits[3] & int.MinValue) != 0) ? -1 : 1);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Numerics.BigInteger" />, используя значения в массиве типа byte.</summary>
		/// <param name="value">Массив значений типа byte в прямом порядке байтов.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600013D RID: 317 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[CLSCompliant(false)]
		public BigInteger(byte[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this = new BigInteger(new ReadOnlySpan<byte>(value), false, false);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B300 File Offset: 0x00009500
		public unsafe BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
		{
			int num = value.Length;
			bool flag;
			if (num > 0)
			{
				byte b = isBigEndian ? (*value[0]) : (*value[num - 1]);
				flag = ((b & 128) != 0 && !isUnsigned);
				if (b == 0)
				{
					if (isBigEndian)
					{
						int num2 = 1;
						while (num2 < num && *value[num2] == 0)
						{
							num2++;
						}
						value = value.Slice(num2);
						num = value.Length;
					}
					else
					{
						num -= 2;
						while (num >= 0 && *value[num] == 0)
						{
							num--;
						}
						num++;
					}
				}
			}
			else
			{
				flag = false;
			}
			if (num == 0)
			{
				this._sign = 0;
				this._bits = null;
				return;
			}
			if (num <= 4)
			{
				this._sign = (flag ? -1 : 0);
				if (isBigEndian)
				{
					for (int i = 0; i < num; i++)
					{
						this._sign = (this._sign << 8 | (int)(*value[i]));
					}
				}
				else
				{
					for (int j = num - 1; j >= 0; j--)
					{
						this._sign = (this._sign << 8 | (int)(*value[j]));
					}
				}
				this._bits = null;
				if (this._sign < 0 && !flag)
				{
					this._bits = new uint[]
					{
						(uint)this._sign
					};
					this._sign = 1;
				}
				if (this._sign == -2147483648)
				{
					this = BigInteger.s_bnMinInt;
					return;
				}
			}
			else
			{
				int num3 = num % 4;
				int num4 = num / 4 + ((num3 == 0) ? 0 : 1);
				uint[] array = new uint[num4];
				int num5 = num - 1;
				int l;
				if (isBigEndian)
				{
					int k = num - 4;
					for (l = 0; l < num4 - ((num3 == 0) ? 0 : 1); l++)
					{
						for (int m = 0; m < 4; m++)
						{
							byte b2 = *value[k];
							array[l] = (array[l] << 8 | (uint)b2);
							k++;
						}
						k -= 8;
					}
				}
				else
				{
					int k = 3;
					for (l = 0; l < num4 - ((num3 == 0) ? 0 : 1); l++)
					{
						for (int n = 0; n < 4; n++)
						{
							byte b3 = *value[k];
							array[l] = (array[l] << 8 | (uint)b3);
							k--;
						}
						k += 8;
					}
				}
				if (num3 != 0)
				{
					if (flag)
					{
						array[num4 - 1] = uint.MaxValue;
					}
					if (isBigEndian)
					{
						for (int k = 0; k < num3; k++)
						{
							byte b4 = *value[k];
							array[l] = (array[l] << 8 | (uint)b4);
						}
					}
					else
					{
						for (int k = num5; k >= num - num3; k--)
						{
							byte b5 = *value[k];
							array[l] = (array[l] << 8 | (uint)b5);
						}
					}
				}
				if (flag)
				{
					NumericsHelpers.DangerousMakeTwosComplement(array);
					int num6 = array.Length - 1;
					while (num6 >= 0 && array[num6] == 0U)
					{
						num6--;
					}
					num6++;
					if (num6 == 1)
					{
						uint num7 = array[0];
						if (num7 == 1U)
						{
							this = BigInteger.s_bnMinusOneInt;
							return;
						}
						if (num7 == 2147483648U)
						{
							this = BigInteger.s_bnMinInt;
							return;
						}
						if (array[0] > 0U)
						{
							this._sign = (int)(uint.MaxValue * array[0]);
							this._bits = null;
							return;
						}
					}
					if (num6 != array.Length)
					{
						this._sign = -1;
						this._bits = new uint[num6];
						Array.Copy(array, 0, this._bits, 0, num6);
						return;
					}
					this._sign = -1;
					this._bits = array;
					return;
				}
				else
				{
					this._sign = 1;
					this._bits = array;
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000B662 File Offset: 0x00009862
		internal BigInteger(int n, uint[] rgu)
		{
			this._sign = n;
			this._bits = rgu;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000B674 File Offset: 0x00009874
		internal BigInteger(uint[] value, bool negative)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int num = value.Length;
			while (num > 0 && value[num - 1] == 0U)
			{
				num--;
			}
			if (num == 0)
			{
				this = BigInteger.s_bnZeroInt;
				return;
			}
			if (num == 1 && value[0] < 2147483648U)
			{
				this._sign = (int)(negative ? (-(int)value[0]) : value[0]);
				this._bits = null;
				if (this._sign == -2147483648)
				{
					this = BigInteger.s_bnMinInt;
					return;
				}
			}
			else
			{
				this._sign = (negative ? -1 : 1);
				this._bits = new uint[num];
				Array.Copy(value, 0, this._bits, 0, num);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000B71C File Offset: 0x0000991C
		private BigInteger(uint[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int num = value.Length;
			bool flag = num > 0 && (value[num - 1] & 2147483648U) == 2147483648U;
			while (num > 0 && value[num - 1] == 0U)
			{
				num--;
			}
			if (num == 0)
			{
				this = BigInteger.s_bnZeroInt;
				return;
			}
			if (num == 1)
			{
				if (value[0] < 0U && !flag)
				{
					this._bits = new uint[1];
					this._bits[0] = value[0];
					this._sign = 1;
					return;
				}
				if (2147483648U == value[0])
				{
					this = BigInteger.s_bnMinInt;
					return;
				}
				this._sign = (int)value[0];
				this._bits = null;
				return;
			}
			else if (!flag)
			{
				if (num != value.Length)
				{
					this._sign = 1;
					this._bits = new uint[num];
					Array.Copy(value, 0, this._bits, 0, num);
					return;
				}
				this._sign = 1;
				this._bits = value;
				return;
			}
			else
			{
				NumericsHelpers.DangerousMakeTwosComplement(value);
				int num2 = value.Length;
				while (num2 > 0 && value[num2 - 1] == 0U)
				{
					num2--;
				}
				if (num2 == 1 && value[0] > 0U)
				{
					if (value[0] == 1U)
					{
						this = BigInteger.s_bnMinusOneInt;
						return;
					}
					if (value[0] == 2147483648U)
					{
						this = BigInteger.s_bnMinInt;
						return;
					}
					this._sign = (int)(uint.MaxValue * value[0]);
					this._bits = null;
					return;
				}
				else
				{
					if (num2 != value.Length)
					{
						this._sign = -1;
						this._bits = new uint[num2];
						Array.Copy(value, 0, this._bits, 0, num2);
						return;
					}
					this._sign = -1;
					this._bits = value;
					return;
				}
			}
		}

		/// <summary>Получает значение, представляющее 0 (нуль).</summary>
		/// <returns>Целое число, равное нулю (0).</returns>
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000B89A File Offset: 0x00009A9A
		public static BigInteger Zero
		{
			get
			{
				return BigInteger.s_bnZeroInt;
			}
		}

		/// <summary>Получает значение, представляющее единицу (1).</summary>
		/// <returns>Целое число, равное единице (1).</returns>
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000B8A1 File Offset: 0x00009AA1
		public static BigInteger One
		{
			get
			{
				return BigInteger.s_bnOneInt;
			}
		}

		/// <summary>Получает значение, представляющее минус единицу (-1).</summary>
		/// <returns>Целое число, равное минус единице (-1).</returns>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public static BigInteger MinusOne
		{
			get
			{
				return BigInteger.s_bnMinusOneInt;
			}
		}

		/// <summary>Указывает, равно ли значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> степени двух.</summary>
		/// <returns>Значение <see langword="true" />, если значение объекта <see cref="T:System.Numerics.BigInteger" /> равно степени двух; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		public bool IsPowerOfTwo
		{
			get
			{
				if (this._bits == null)
				{
					return (this._sign & this._sign - 1) == 0 && this._sign != 0;
				}
				if (this._sign != 1)
				{
					return false;
				}
				int num = this._bits.Length - 1;
				if ((this._bits[num] & this._bits[num] - 1U) != 0U)
				{
					return false;
				}
				while (--num >= 0)
				{
					if (this._bits[num] != 0U)
					{
						return false;
					}
				}
				return true;
			}
		}

		/// <summary>Указывает, равно ли значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> значению <see cref="P:System.Numerics.BigInteger.Zero" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Numerics.BigInteger" /> имеет значение <see cref="P:System.Numerics.BigInteger.Zero" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000B924 File Offset: 0x00009B24
		public bool IsZero
		{
			get
			{
				return this._sign == 0;
			}
		}

		/// <summary>Указывает, равно ли значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> значению <see cref="P:System.Numerics.BigInteger.One" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Numerics.BigInteger" /> имеет значение <see cref="P:System.Numerics.BigInteger.One" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000B92F File Offset: 0x00009B2F
		public bool IsOne
		{
			get
			{
				return this._sign == 1 && this._bits == null;
			}
		}

		/// <summary>Указывает, равно ли значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> четному числу.</summary>
		/// <returns>Значение <see langword="true" />, если значение объекта <see cref="T:System.Numerics.BigInteger" /> равно четному числу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000B945 File Offset: 0x00009B45
		public bool IsEven
		{
			get
			{
				if (this._bits != null)
				{
					return (this._bits[0] & 1U) == 0U;
				}
				return (this._sign & 1) == 0;
			}
		}

		/// <summary>Получает число, указывающее знак (минус, плюс или нуль) текущего объекта <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <returns>Число, которое указывает знак объекта <see cref="T:System.Numerics.BigInteger" />, как показано в следующей таблице.  
		///   Число 
		///   Описание 
		///   -1 
		///   Этот объект имеет отрицательное значение.  
		///
		///   0 
		///   Этот объект имеет значение 0 (нуль).  
		///
		///   1 
		///   Этот объект имеет положительное значение.</returns>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000B968 File Offset: 0x00009B68
		public int Sign
		{
			get
			{
				return (this._sign >> 31) - (-this._sign >> 31);
			}
		}

		/// <summary>Преобразует строковое представление числа в его эквивалент типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <returns>Значение, эквивалентное числу, которое задается параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат.</exception>
		// Token: 0x0600014A RID: 330 RVA: 0x0000B97E File Offset: 0x00009B7E
		public static BigInteger Parse(string value)
		{
			return BigInteger.Parse(value, NumberStyles.Integer);
		}

		/// <summary>Преобразует строковое представление числа с указанным стилем в его эквивалент в формате <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, которое показывает разрешенный формат параметра <paramref name="value" />.</param>
		/// <returns>Значение, эквивалентное числу, которое задается параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> включает флаги <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" /> вместе с другим значениями.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не соответствует образцу ввода, заданному <see cref="T:System.Globalization.NumberStyles" />.</exception>
		// Token: 0x0600014B RID: 331 RVA: 0x0000B987 File Offset: 0x00009B87
		public static BigInteger Parse(string value, NumberStyles style)
		{
			return BigInteger.Parse(value, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате, связанном с определенным языком и региональными параметрами, в его эквивалент типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании параметра <paramref name="value" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Значение, эквивалентное числу, которое задается параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> имеет неправильный формат.</exception>
		// Token: 0x0600014C RID: 332 RVA: 0x0000B995 File Offset: 0x00009B95
		public static BigInteger Parse(string value, IFormatProvider provider)
		{
			return BigInteger.Parse(value, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в указанном стиле и формате, связанном с определенным языком и региональными параметрами, в его эквивалент типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, которое показывает разрешенный формат параметра <paramref name="value" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании параметра <paramref name="value" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Значение, эквивалентное числу, которое задается параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> включает флаги <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" /> вместе с другим значениями.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="value" /> не соответствует образцу ввода, заданному <paramref name="style" />.</exception>
		// Token: 0x0600014D RID: 333 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider)
		{
			return BigNumber.ParseBigInteger(value, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Предпринимает попытку преобразования строкового представления числа в его эквивалент типа <see cref="T:System.Numerics.BigInteger" /> и возвращает значение, позволяющее определить, успешно ли выполнено преобразование.</summary>
		/// <param name="value">Строковое представление числа.</param>
		/// <param name="result">После выполнения этого метода содержит эквивалент типа <see cref="T:System.Numerics.BigInteger" /> числа, содержащегося в параметре <paramref name="value" />, или нуль (0), если выполнить преобразование не удалось. Преобразование не удается выполнить, если значение параметра <paramref name="value" /> равно <see langword="null" /> или задано в неверном формате, Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600014E RID: 334 RVA: 0x0000B9B3 File Offset: 0x00009BB3
		public static bool TryParse(string value, out BigInteger result)
		{
			return BigInteger.TryParse(value, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Предпринимает попытку преобразования числа в формате, который определяется заданным стилем и языком и региональными параметрами, в эквивалент типа <see cref="T:System.Numerics.BigInteger" /> и возвращает значение, определяющее, успешно ли выполнено преобразование.</summary>
		/// <param name="value">Строковое представление числа. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="value" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="value" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">После выполнения этого метода содержит эквивалент типа <see cref="T:System.Numerics.BigInteger" /> числа, содержащегося в параметре <paramref name="value" />, или <see cref="P:System.Numerics.BigInteger.Zero" />, если выполнить преобразование не удалось. Преобразование не удается выполнить, если параметр <paramref name="value" /> имеет значение <see langword="null" /> или имеет формат, несовместимый со значением <paramref name="style" />, Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> включает флаги <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" /> вместе с другим значениями.</exception>
		// Token: 0x0600014F RID: 335 RVA: 0x0000B9C2 File Offset: 0x00009BC2
		public static bool TryParse(string value, NumberStyles style, IFormatProvider provider, out BigInteger result)
		{
			return BigNumber.TryParseBigInteger(value, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000B9D2 File Offset: 0x00009BD2
		public static BigInteger Parse(ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			return BigNumber.ParseBigInteger(value, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000B9E1 File Offset: 0x00009BE1
		public static bool TryParse(ReadOnlySpan<char> value, out BigInteger result)
		{
			return BigNumber.TryParseBigInteger(value, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public static bool TryParse(ReadOnlySpan<char> value, NumberStyles style, IFormatProvider provider, out BigInteger result)
		{
			return BigNumber.TryParseBigInteger(value, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		/// <summary>Сравнивает два значения <see cref="T:System.Numerics.BigInteger" /> и возвращает целое значение, которое показывает, больше или меньше первое значение по сравнению со вторым или равно ему.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="left" /> и <paramref name="right" />, как показано в следующей таблице.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  Значение <paramref name="left" /> меньше <paramref name="right" />.  
		///
		///   Нуль 
		///  <paramref name="left" /> равняется <paramref name="right" />.  
		///
		///   Больше нуля 
		///  Значение <paramref name="left" /> больше значения <paramref name="right" />.</returns>
		// Token: 0x06000153 RID: 339 RVA: 0x0000BA00 File Offset: 0x00009C00
		public static int Compare(BigInteger left, BigInteger right)
		{
			return left.CompareTo(right);
		}

		/// <summary>Получает абсолютное значение объекта <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Число.</param>
		/// <returns>Абсолютное значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000154 RID: 340 RVA: 0x0000BA0A File Offset: 0x00009C0A
		public static BigInteger Abs(BigInteger value)
		{
			if (!(value >= BigInteger.Zero))
			{
				return -value;
			}
			return value;
		}

		/// <summary>Складывает два значения <see cref="T:System.Numerics.BigInteger" /> и возвращает результат.</summary>
		/// <param name="left">Первое из складываемых значений.</param>
		/// <param name="right">Второе из складываемых значений.</param>
		/// <returns>Сумма <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000155 RID: 341 RVA: 0x0000BA21 File Offset: 0x00009C21
		public static BigInteger Add(BigInteger left, BigInteger right)
		{
			return left + right;
		}

		/// <summary>Вычитает одно значение <see cref="T:System.Numerics.BigInteger" /> из другого и возвращает результат.</summary>
		/// <param name="left">Значение, из которого следует вычитать (уменьшаемое).</param>
		/// <param name="right">Значение для вычитания (вычитаемое).</param>
		/// <returns>Результат вычитания <paramref name="right" /> из <paramref name="left" />.</returns>
		// Token: 0x06000156 RID: 342 RVA: 0x0000BA2A File Offset: 0x00009C2A
		public static BigInteger Subtract(BigInteger left, BigInteger right)
		{
			return left - right;
		}

		/// <summary>Возвращает произведение двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое число для умножения.</param>
		/// <param name="right">Второе число для умножения.</param>
		/// <returns>Произведение параметров <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000157 RID: 343 RVA: 0x0000BA33 File Offset: 0x00009C33
		public static BigInteger Multiply(BigInteger left, BigInteger right)
		{
			return left * right;
		}

		/// <summary>Делит одно значение <see cref="T:System.Numerics.BigInteger" /> на другое и возвращает результат.</summary>
		/// <param name="dividend">Значение, которое необходимо разделить.</param>
		/// <param name="divisor">Значение, на которое необходимо разделить.</param>
		/// <returns>Частное от деления.</returns>
		/// <exception cref="T:System.DivideByZeroException">Значение параметра <paramref name="divisor" /> равно нулю (0).</exception>
		// Token: 0x06000158 RID: 344 RVA: 0x0000BA3C File Offset: 0x00009C3C
		public static BigInteger Divide(BigInteger dividend, BigInteger divisor)
		{
			return dividend / divisor;
		}

		/// <summary>Выполняет целочисленное деление двух значений <see cref="T:System.Numerics.BigInteger" /> и возвращает остаток.</summary>
		/// <param name="dividend">Значение, которое необходимо разделить.</param>
		/// <param name="divisor">Значение, на которое необходимо разделить.</param>
		/// <returns>Остаток от деления <paramref name="dividend" /> на <paramref name="divisor" />.</returns>
		/// <exception cref="T:System.DivideByZeroException">Значение параметра <paramref name="divisor" /> равно нулю (0).</exception>
		// Token: 0x06000159 RID: 345 RVA: 0x0000BA45 File Offset: 0x00009C45
		public static BigInteger Remainder(BigInteger dividend, BigInteger divisor)
		{
			return dividend % divisor;
		}

		/// <summary>Делит одно значение <see cref="T:System.Numerics.BigInteger" /> на другое, возвращает результат, а также возвращает остаток в виде параметра вывода.</summary>
		/// <param name="dividend">Значение, которое необходимо разделить.</param>
		/// <param name="divisor">Значение, на которое необходимо разделить.</param>
		/// <param name="remainder">После выполнения данного метода содержит значение <see cref="T:System.Numerics.BigInteger" />, представляющее остаток от деления. Этот параметр передается неинициализированным.</param>
		/// <returns>Частное от деления.</returns>
		/// <exception cref="T:System.DivideByZeroException">Значение параметра <paramref name="divisor" /> равно нулю (0).</exception>
		// Token: 0x0600015A RID: 346 RVA: 0x0000BA50 File Offset: 0x00009C50
		public static BigInteger DivRem(BigInteger dividend, BigInteger divisor, out BigInteger remainder)
		{
			bool flag = dividend._bits == null;
			bool flag2 = divisor._bits == null;
			if (flag && flag2)
			{
				remainder = dividend._sign % divisor._sign;
				return dividend._sign / divisor._sign;
			}
			if (flag)
			{
				remainder = dividend;
				return BigInteger.s_bnZeroInt;
			}
			if (flag2)
			{
				uint num;
				uint[] value = BigIntegerCalculator.Divide(dividend._bits, NumericsHelpers.Abs(divisor._sign), out num);
				remainder = (long)((dividend._sign < 0) ? (ulong.MaxValue * (ulong)num) : ((ulong)num));
				return new BigInteger(value, dividend._sign < 0 ^ divisor._sign < 0);
			}
			if (dividend._bits.Length < divisor._bits.Length)
			{
				remainder = dividend;
				return BigInteger.s_bnZeroInt;
			}
			uint[] value3;
			uint[] value2 = BigIntegerCalculator.Divide(dividend._bits, divisor._bits, out value3);
			remainder = new BigInteger(value3, dividend._sign < 0);
			return new BigInteger(value2, dividend._sign < 0 ^ divisor._sign < 0);
		}

		/// <summary>Меняет знак указанного значения <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Инвертируемое значение.</param>
		/// <returns>Результат умножения параметра <paramref name="value" /> на минус единицу (-1).</returns>
		// Token: 0x0600015B RID: 347 RVA: 0x0000BB61 File Offset: 0x00009D61
		public static BigInteger Negate(BigInteger value)
		{
			return -value;
		}

		/// <summary>Возвращает натуральный логарифм (с основанием <see langword="e" />) указанного числа.</summary>
		/// <param name="value">Число, логарифм которого требуется найти.</param>
		/// <returns>Натуральный (по основанию <see langword="e" />) логарифм числа <paramref name="value" />, как показано в таблице в разделе примечаний.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Натуральный логарифм <paramref name="value" /> находится вне диапазона типа данных <see cref="T:System.Double" />.</exception>
		// Token: 0x0600015C RID: 348 RVA: 0x0000BB69 File Offset: 0x00009D69
		public static double Log(BigInteger value)
		{
			return BigInteger.Log(value, 2.718281828459045);
		}

		/// <summary>Возвращает логарифм указанного числа в системе счисления с указанным основанием.</summary>
		/// <param name="value">Число, логарифм которого должен быть найден.</param>
		/// <param name="baseValue">Основание логарифма.</param>
		/// <returns>Логарифм по основанию <paramref name="baseValue" /> числа <paramref name="value" />, как показано в таблице в разделе примечаний.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Логарифм <paramref name="value" /> находится вне диапазона типа данных <see cref="T:System.Double" />.</exception>
		// Token: 0x0600015D RID: 349 RVA: 0x0000BB7C File Offset: 0x00009D7C
		public static double Log(BigInteger value, double baseValue)
		{
			if (value._sign < 0 || baseValue == 1.0)
			{
				return double.NaN;
			}
			if (baseValue == double.PositiveInfinity)
			{
				if (!value.IsOne)
				{
					return double.NaN;
				}
				return 0.0;
			}
			else
			{
				if (baseValue == 0.0 && !value.IsOne)
				{
					return double.NaN;
				}
				if (value._bits == null)
				{
					return Math.Log((double)value._sign, baseValue);
				}
				ulong num = (ulong)value._bits[value._bits.Length - 1];
				ulong num2 = (ulong)((value._bits.Length > 1) ? value._bits[value._bits.Length - 2] : 0U);
				ulong num3 = (ulong)((value._bits.Length > 2) ? value._bits[value._bits.Length - 3] : 0U);
				int num4 = NumericsHelpers.CbitHighZero((uint)num);
				long num5 = (long)value._bits.Length * 32L - (long)num4;
				return Math.Log(num << 32 + num4 | num2 << num4 | num3 >> 32 - num4, baseValue) + (double)(num5 - 64L) / Math.Log(baseValue, 2.0);
			}
		}

		/// <summary>Возвращает логарифм с основанием 10 указанного числа.</summary>
		/// <param name="value">Число, логарифм которого должен быть найден.</param>
		/// <returns>Логарифм по основанию 10 числа <paramref name="value" />, как показано в таблице в разделе примечаний.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Десятичный логарифм <paramref name="value" /> находится вне диапазона типа данных <see cref="T:System.Double" />.</exception>
		// Token: 0x0600015E RID: 350 RVA: 0x0000BCAB File Offset: 0x00009EAB
		public static double Log10(BigInteger value)
		{
			return BigInteger.Log(value, 10.0);
		}

		/// <summary>Находит наибольший общий делитель двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое значение в вычитании.</param>
		/// <param name="right">Второе значение в вычитании.</param>
		/// <returns>Наибольший общий делитель значений <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x0600015F RID: 351 RVA: 0x0000BCBC File Offset: 0x00009EBC
		public static BigInteger GreatestCommonDivisor(BigInteger left, BigInteger right)
		{
			bool flag = left._bits == null;
			bool flag2 = right._bits == null;
			if (flag && flag2)
			{
				return BigIntegerCalculator.Gcd(NumericsHelpers.Abs(left._sign), NumericsHelpers.Abs(right._sign));
			}
			if (flag)
			{
				if (left._sign == 0)
				{
					return new BigInteger(right._bits, false);
				}
				return BigIntegerCalculator.Gcd(right._bits, NumericsHelpers.Abs(left._sign));
			}
			else if (flag2)
			{
				if (right._sign == 0)
				{
					return new BigInteger(left._bits, false);
				}
				return BigIntegerCalculator.Gcd(left._bits, NumericsHelpers.Abs(right._sign));
			}
			else
			{
				if (BigIntegerCalculator.Compare(left._bits, right._bits) < 0)
				{
					return BigInteger.GreatestCommonDivisor(right._bits, left._bits);
				}
				return BigInteger.GreatestCommonDivisor(left._bits, right._bits);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		private static BigInteger GreatestCommonDivisor(uint[] leftBits, uint[] rightBits)
		{
			if (rightBits.Length == 1)
			{
				uint right = BigIntegerCalculator.Remainder(leftBits, rightBits[0]);
				return BigIntegerCalculator.Gcd(rightBits[0], right);
			}
			if (rightBits.Length == 2)
			{
				uint[] array = BigIntegerCalculator.Remainder(leftBits, rightBits);
				ulong left = (ulong)rightBits[1] << 32 | (ulong)rightBits[0];
				ulong right2 = (ulong)array[1] << 32 | (ulong)array[0];
				return BigIntegerCalculator.Gcd(left, right2);
			}
			return new BigInteger(BigIntegerCalculator.Gcd(leftBits, rightBits), false);
		}

		/// <summary>Возвращает наибольшее из двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Большее из значений параметров <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000161 RID: 353 RVA: 0x0000BE10 File Offset: 0x0000A010
		public static BigInteger Max(BigInteger left, BigInteger right)
		{
			if (left.CompareTo(right) < 0)
			{
				return right;
			}
			return left;
		}

		/// <summary>Возвращает наименьшее из двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Меньшее из значений параметров <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000162 RID: 354 RVA: 0x0000BE20 File Offset: 0x0000A020
		public static BigInteger Min(BigInteger left, BigInteger right)
		{
			if (left.CompareTo(right) <= 0)
			{
				return left;
			}
			return right;
		}

		/// <summary>Выполняет модульное деление числа, возведенного в степень другого числа.</summary>
		/// <param name="value">Число, возведенное в степень <paramref name="exponent" />.</param>
		/// <param name="exponent">Показатель степени, в которую будет возведено значение <paramref name="value" />.</param>
		/// <param name="modulus">Число, на которое делится значение <paramref name="value" />, возведенное в степень <paramref name="exponent" />.</param>
		/// <returns>Остаток от деления <paramref name="value" />exponent на <paramref name="modulus" />.</returns>
		/// <exception cref="T:System.DivideByZeroException">
		///   <paramref name="modulus" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="exponent" /> является отрицательным значением.</exception>
		// Token: 0x06000163 RID: 355 RVA: 0x0000BE30 File Offset: 0x0000A030
		public static BigInteger ModPow(BigInteger value, BigInteger exponent, BigInteger modulus)
		{
			if (exponent.Sign < 0)
			{
				throw new ArgumentOutOfRangeException("exponent", "The number must be greater than or equal to zero.");
			}
			bool flag = value._bits == null;
			bool flag2 = exponent._bits == null;
			if (modulus._bits == null)
			{
				uint num = (flag && flag2) ? BigIntegerCalculator.Pow(NumericsHelpers.Abs(value._sign), NumericsHelpers.Abs(exponent._sign), NumericsHelpers.Abs(modulus._sign)) : (flag ? BigIntegerCalculator.Pow(NumericsHelpers.Abs(value._sign), exponent._bits, NumericsHelpers.Abs(modulus._sign)) : (flag2 ? BigIntegerCalculator.Pow(value._bits, NumericsHelpers.Abs(exponent._sign), NumericsHelpers.Abs(modulus._sign)) : BigIntegerCalculator.Pow(value._bits, exponent._bits, NumericsHelpers.Abs(modulus._sign))));
				return (long)((value._sign < 0 && !exponent.IsEven) ? (ulong.MaxValue * (ulong)num) : ((ulong)num));
			}
			return new BigInteger((flag && flag2) ? BigIntegerCalculator.Pow(NumericsHelpers.Abs(value._sign), NumericsHelpers.Abs(exponent._sign), modulus._bits) : (flag ? BigIntegerCalculator.Pow(NumericsHelpers.Abs(value._sign), exponent._bits, modulus._bits) : (flag2 ? BigIntegerCalculator.Pow(value._bits, NumericsHelpers.Abs(exponent._sign), modulus._bits) : BigIntegerCalculator.Pow(value._bits, exponent._bits, modulus._bits))), value._sign < 0 && !exponent.IsEven);
		}

		/// <summary>Возводит значение <see cref="T:System.Numerics.BigInteger" /> в заданную степень.</summary>
		/// <param name="value">Число, возведенное в степень <paramref name="exponent" />.</param>
		/// <param name="exponent">Показатель степени, в которую будет возведено значение <paramref name="value" />.</param>
		/// <returns>Результат возведения <paramref name="value" /> в степень <paramref name="exponent" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="exponent" /> является отрицательным значением.</exception>
		// Token: 0x06000164 RID: 356 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public static BigInteger Pow(BigInteger value, int exponent)
		{
			if (exponent < 0)
			{
				throw new ArgumentOutOfRangeException("exponent", "The number must be greater than or equal to zero.");
			}
			if (exponent == 0)
			{
				return BigInteger.s_bnOneInt;
			}
			if (exponent == 1)
			{
				return value;
			}
			bool flag = value._bits == null;
			if (flag)
			{
				if (value._sign == 1)
				{
					return value;
				}
				if (value._sign == -1)
				{
					if ((exponent & 1) == 0)
					{
						return BigInteger.s_bnOneInt;
					}
					return value;
				}
				else if (value._sign == 0)
				{
					return value;
				}
			}
			return new BigInteger(flag ? BigIntegerCalculator.Pow(NumericsHelpers.Abs(value._sign), NumericsHelpers.Abs(exponent)) : BigIntegerCalculator.Pow(value._bits, NumericsHelpers.Abs(exponent)), value._sign < 0 && (exponent & 1) != 0);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000165 RID: 357 RVA: 0x0000C078 File Offset: 0x0000A278
		public override int GetHashCode()
		{
			if (this._bits == null)
			{
				return this._sign;
			}
			int num = this._sign;
			int num2 = this._bits.Length;
			while (--num2 >= 0)
			{
				num = NumericsHelpers.CombineHash(num, (int)this._bits[num2]);
			}
			return num;
		}

		/// <summary>Возвращает значение, определяющее, равны ли текущий экземпляр и указанный объект.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если аргумент <paramref name="obj" /> — это объект <see cref="T:System.Numerics.BigInteger" />, и его значение равно значению текущего экземпляра <see cref="T:System.Numerics.BigInteger" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000166 RID: 358 RVA: 0x0000C0BE File Offset: 0x0000A2BE
		public override bool Equals(object obj)
		{
			return obj is BigInteger && this.Equals((BigInteger)obj);
		}

		/// <summary>Возвращает значение, определяющее, равны ли текущий экземпляр и 64-разрядное целое число со знаком.</summary>
		/// <param name="other">64-разрядное целое число со знаком для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если 64-разрядное целое число со знаком и текущий экземпляр равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000167 RID: 359 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		public bool Equals(long other)
		{
			if (this._bits == null)
			{
				return (long)this._sign == other;
			}
			int num;
			if (((long)this._sign ^ other) < 0L || (num = this._bits.Length) > 2)
			{
				return false;
			}
			ulong num2 = (ulong)((other < 0L) ? (-(ulong)other) : other);
			if (num == 1)
			{
				return (ulong)this._bits[0] == num2;
			}
			return NumericsHelpers.MakeUlong(this._bits[1], this._bits[0]) == num2;
		}

		/// <summary>Возвращает значение, определяющее, равны ли текущий экземпляр и 64-разрядное целое число без знака.</summary>
		/// <param name="other">64-разрядное целое число без знака для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр и 64-разрядное целое число без знака равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000168 RID: 360 RVA: 0x0000C148 File Offset: 0x0000A348
		[CLSCompliant(false)]
		public bool Equals(ulong other)
		{
			if (this._sign < 0)
			{
				return false;
			}
			if (this._bits == null)
			{
				return (long)this._sign == (long)other;
			}
			int num = this._bits.Length;
			if (num > 2)
			{
				return false;
			}
			if (num == 1)
			{
				return (ulong)this._bits[0] == other;
			}
			return NumericsHelpers.MakeUlong(this._bits[1], this._bits[0]) == other;
		}

		/// <summary>Возвращает значение, определяющее равны ли текущий экземпляр и указанный объект <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="other">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения данного объекта <see cref="T:System.Numerics.BigInteger" /> и объекта <paramref name="other" /> совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000169 RID: 361 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		public bool Equals(BigInteger other)
		{
			if (this._sign != other._sign)
			{
				return false;
			}
			if (this._bits == other._bits)
			{
				return true;
			}
			if (this._bits == null || other._bits == null)
			{
				return false;
			}
			int num = this._bits.Length;
			return num == other._bits.Length && BigInteger.GetDiffLength(this._bits, other._bits, num) == 0;
		}

		/// <summary>Сравнивает данный экземпляр с 64-разрядным знаковым целым числом и возвращает целое число, которое показывает, является ли значение данного экземпляра меньшим, большим или равным значению 64-битового знакового целого числа.</summary>
		/// <param name="other">64-разрядное знаковое целое число для сравнения.</param>
		/// <returns>Знаковое целое число, определяющее, как соотносятся между собой данный экземпляр и объект <paramref name="other" />. Возможные соотношения показаны в следующей таблице.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Текущий экземпляр меньше значения параметра <paramref name="other" />.  
		///
		///   Нуль 
		///   Текущий экземпляр равен значению параметра <paramref name="other" />.  
		///
		///   Больше нуля 
		///   Текущий экземпляр больше значения параметра <paramref name="other" />.</returns>
		// Token: 0x0600016A RID: 362 RVA: 0x0000C218 File Offset: 0x0000A418
		public int CompareTo(long other)
		{
			if (this._bits == null)
			{
				return ((long)this._sign).CompareTo(other);
			}
			int num;
			if (((long)this._sign ^ other) < 0L || (num = this._bits.Length) > 2)
			{
				return this._sign;
			}
			ulong value = (ulong)((other < 0L) ? (-(ulong)other) : other);
			ulong num2 = (num == 2) ? NumericsHelpers.MakeUlong(this._bits[1], this._bits[0]) : ((ulong)this._bits[0]);
			return this._sign * num2.CompareTo(value);
		}

		/// <summary>Сравнивает данный экземпляр с 64-разрядным целым числом без знака и возвращает целое число, которое показывает, является ли значение данного экземпляра меньшим или большим по сравнению со значением 64-битового целого числа без знака или равным ему.</summary>
		/// <param name="other">64-разрядное целое число без знака для сравнения.</param>
		/// <returns>Целое число со знаком, определяющее, как соотносятся между собой данный экземпляр и объект <paramref name="other" />. Возможные соотношения показаны в следующей таблице.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Текущий экземпляр меньше значения параметра <paramref name="other" />.  
		///
		///   Нуль 
		///   Текущий экземпляр равен значению параметра <paramref name="other" />.  
		///
		///   Больше нуля 
		///   Текущий экземпляр больше значения параметра <paramref name="other" />.</returns>
		// Token: 0x0600016B RID: 363 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[CLSCompliant(false)]
		public int CompareTo(ulong other)
		{
			if (this._sign < 0)
			{
				return -1;
			}
			if (this._bits == null)
			{
				return ((ulong)((long)this._sign)).CompareTo(other);
			}
			int num = this._bits.Length;
			if (num > 2)
			{
				return 1;
			}
			return ((num == 2) ? NumericsHelpers.MakeUlong(this._bits[1], this._bits[0]) : ((ulong)this._bits[0])).CompareTo(other);
		}

		/// <summary>Сравнивает данный экземпляр с другим экземпляром <see cref="T:System.Numerics.BigInteger" /> и возвращает целое число, которое показывает, является ли значение данного экземпляра меньшим, большим или равным значению указанного объекта.</summary>
		/// <param name="other">Объект для сравнения.</param>
		/// <returns>Знаковое целое число, определяющее, как соотносятся между собой данный экземпляр и объект <paramref name="other" />. Возможные соотношения показаны в следующей таблице.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Текущий экземпляр меньше значения параметра <paramref name="other" />.  
		///
		///   Нуль 
		///   Текущий экземпляр равен значению параметра <paramref name="other" />.  
		///
		///   Больше нуля 
		///   Текущий экземпляр больше значения параметра <paramref name="other" />.</returns>
		// Token: 0x0600016C RID: 364 RVA: 0x0000C310 File Offset: 0x0000A510
		public int CompareTo(BigInteger other)
		{
			if ((this._sign ^ other._sign) < 0)
			{
				if (this._sign >= 0)
				{
					return 1;
				}
				return -1;
			}
			else if (this._bits == null)
			{
				if (other._bits != null)
				{
					return -other._sign;
				}
				if (this._sign < other._sign)
				{
					return -1;
				}
				if (this._sign <= other._sign)
				{
					return 0;
				}
				return 1;
			}
			else
			{
				int num;
				int num2;
				if (other._bits == null || (num = this._bits.Length) > (num2 = other._bits.Length))
				{
					return this._sign;
				}
				if (num < num2)
				{
					return -this._sign;
				}
				int diffLength = BigInteger.GetDiffLength(this._bits, other._bits, num);
				if (diffLength == 0)
				{
					return 0;
				}
				if (this._bits[diffLength - 1] >= other._bits[diffLength - 1])
				{
					return this._sign;
				}
				return -this._sign;
			}
		}

		/// <summary>Сравнивает данный экземпляр с указанным объектом и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равно значению заданного объекта.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Знаковое целое число, определяющее, как соотносятся между собой текущий экземпляр и параметр <paramref name="obj" />. Возможные соотношения показаны в следующей таблице.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Текущий экземпляр меньше значения параметра <paramref name="obj" />.  
		///
		///   Нуль 
		///   Текущий экземпляр равен значению параметра <paramref name="obj" />.  
		///
		///   Больше нуля 
		///   Текущий экземпляр больше значения параметра <paramref name="obj" /> или параметр <paramref name="obj" /> равен <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Numerics.BigInteger" />.</exception>
		// Token: 0x0600016D RID: 365 RVA: 0x0000C3E1 File Offset: 0x0000A5E1
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is BigInteger))
			{
				throw new ArgumentException("The parameter must be a BigInteger.", "obj");
			}
			return this.CompareTo((BigInteger)obj);
		}

		/// <summary>Преобразует значение <see cref="T:System.Numerics.BigInteger" /> в массив байтов.</summary>
		/// <returns>Значение текущего объекта <see cref="T:System.Numerics.BigInteger" />, преобразованное в массив байтов.</returns>
		// Token: 0x0600016E RID: 366 RVA: 0x0000C40C File Offset: 0x0000A60C
		public byte[] ToByteArray()
		{
			return this.ToByteArray(false, false);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000C418 File Offset: 0x0000A618
		public byte[] ToByteArray(bool isUnsigned = false, bool isBigEndian = false)
		{
			int num = 0;
			return this.TryGetBytes(BigInteger.GetBytesMode.AllocateArray, default(Span<byte>), isUnsigned, isBigEndian, ref num);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000C43B File Offset: 0x0000A63B
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			bytesWritten = 0;
			if (this.TryGetBytes(BigInteger.GetBytesMode.Span, destination, isUnsigned, isBigEndian, ref bytesWritten) == null)
			{
				bytesWritten = 0;
				return false;
			}
			return true;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000C454 File Offset: 0x0000A654
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			bytesWritten = 0;
			return this.TryGetBytes(BigInteger.GetBytesMode.Span, destination, isUnsigned, isBigEndian, ref bytesWritten) != null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000C468 File Offset: 0x0000A668
		public int GetByteCount(bool isUnsigned = false)
		{
			int result = 0;
			this.TryGetBytes(BigInteger.GetBytesMode.Count, default(Span<byte>), isUnsigned, false, ref result);
			return result;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000C490 File Offset: 0x0000A690
		private unsafe byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
		{
			int sign = this._sign;
			if (sign == 0)
			{
				if (mode == BigInteger.GetBytesMode.AllocateArray)
				{
					return new byte[1];
				}
				if (mode == BigInteger.GetBytesMode.Count)
				{
					bytesWritten = 1;
					return null;
				}
				bytesWritten = 1;
				if (destination.Length != 0)
				{
					*destination[0] = 0;
					return BigInteger.s_success;
				}
				return null;
			}
			else
			{
				if (isUnsigned && sign < 0)
				{
					throw new OverflowException("Negative values do not have an unsigned representation.");
				}
				int num = 0;
				uint[] bits = this._bits;
				byte b;
				uint num2;
				if (bits == null)
				{
					b = ((sign < 0) ? byte.MaxValue : 0);
					num2 = (uint)sign;
				}
				else if (sign == -1)
				{
					b = byte.MaxValue;
					while (bits[num] == 0U)
					{
						num++;
					}
					num2 = ~bits[bits.Length - 1];
					if (bits.Length - 1 == num)
					{
						num2 += 1U;
					}
				}
				else
				{
					b = 0;
					num2 = bits[bits.Length - 1];
				}
				byte b2;
				int num3;
				if ((b2 = (byte)(num2 >> 24)) != b)
				{
					num3 = 3;
				}
				else if ((b2 = (byte)(num2 >> 16)) != b)
				{
					num3 = 2;
				}
				else if ((b2 = (byte)(num2 >> 8)) != b)
				{
					num3 = 1;
				}
				else
				{
					b2 = (byte)num2;
					num3 = 0;
				}
				bool flag = (b2 & 128) != (b & 128) && !isUnsigned;
				int num4 = num3 + 1 + (flag ? 1 : 0);
				if (bits != null)
				{
					num4 = checked(4 * (bits.Length - 1) + num4);
				}
				byte[] result;
				if (mode != BigInteger.GetBytesMode.AllocateArray)
				{
					if (mode == BigInteger.GetBytesMode.Count)
					{
						bytesWritten = num4;
						return null;
					}
					bytesWritten = num4;
					if (destination.Length < num4)
					{
						return null;
					}
					result = BigInteger.s_success;
				}
				else
				{
					destination = (result = new byte[num4]);
				}
				int num5 = isBigEndian ? (num4 - 1) : 0;
				int num6 = isBigEndian ? -1 : 1;
				if (bits != null)
				{
					for (int i = 0; i < bits.Length - 1; i++)
					{
						uint num7 = bits[i];
						if (sign == -1)
						{
							num7 = ~num7;
							if (i <= num)
							{
								num7 += 1U;
							}
						}
						*destination[num5] = (byte)num7;
						num5 += num6;
						*destination[num5] = (byte)(num7 >> 8);
						num5 += num6;
						*destination[num5] = (byte)(num7 >> 16);
						num5 += num6;
						*destination[num5] = (byte)(num7 >> 24);
						num5 += num6;
					}
				}
				*destination[num5] = (byte)num2;
				if (num3 != 0)
				{
					num5 += num6;
					*destination[num5] = (byte)(num2 >> 8);
					if (num3 != 1)
					{
						num5 += num6;
						*destination[num5] = (byte)(num2 >> 16);
						if (num3 != 2)
						{
							num5 += num6;
							*destination[num5] = (byte)(num2 >> 24);
						}
					}
				}
				if (flag)
				{
					num5 += num6;
					*destination[num5] = b;
				}
				return result;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000C714 File Offset: 0x0000A914
		private uint[] ToUInt32Array()
		{
			if (this._bits == null && this._sign == 0)
			{
				return new uint[1];
			}
			uint[] array;
			uint num;
			if (this._bits == null)
			{
				array = new uint[]
				{
					(uint)this._sign
				};
				num = ((this._sign < 0) ? uint.MaxValue : 0U);
			}
			else if (this._sign == -1)
			{
				array = (uint[])this._bits.Clone();
				NumericsHelpers.DangerousMakeTwosComplement(array);
				num = uint.MaxValue;
			}
			else
			{
				array = this._bits;
				num = 0U;
			}
			int num2 = array.Length - 1;
			while (num2 > 0 && array[num2] == num)
			{
				num2--;
			}
			bool flag = (array[num2] & 2147483648U) != (num & 2147483648U);
			uint[] array2 = new uint[num2 + 1 + (flag ? 1 : 0)];
			Array.Copy(array, 0, array2, 0, num2 + 1);
			if (flag)
			{
				array2[array2.Length - 1] = num;
			}
			return array2;
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.Numerics.BigInteger" />.</returns>
		// Token: 0x06000175 RID: 373 RVA: 0x0000C7E7 File Offset: 0x0000A9E7
		public override string ToString()
		{
			return BigNumber.FormatBigInteger(this, null, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> в эквивалентное ему строковое представление, используя указанные сведения об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.Numerics.BigInteger" /> в формате, заданном параметром <paramref name="provider" />.</returns>
		// Token: 0x06000176 RID: 374 RVA: 0x0000C7FA File Offset: 0x0000A9FA
		public string ToString(IFormatProvider provider)
		{
			return BigNumber.FormatBigInteger(this, null, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> в эквивалентное строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.Numerics.BigInteger" /> в формате, заданном параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> не является допустимым форматом строки.</exception>
		// Token: 0x06000177 RID: 375 RVA: 0x0000C80E File Offset: 0x0000AA0E
		public string ToString(string format)
		{
			return BigNumber.FormatBigInteger(this, format, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.Numerics.BigInteger" /> в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях формата для определенного языка и региональных параметров.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление текущего значения <see cref="T:System.Numerics.BigInteger" /> в виде, заданном параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> не является допустимым форматом строки.</exception>
		// Token: 0x06000178 RID: 376 RVA: 0x0000C821 File Offset: 0x0000AA21
		public string ToString(string format, IFormatProvider provider)
		{
			return BigNumber.FormatBigInteger(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000C835 File Offset: 0x0000AA35
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return BigNumber.TryFormatBigInteger(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000C84C File Offset: 0x0000AA4C
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			bool flag = leftBits == null;
			bool flag2 = rightBits == null;
			if (flag && flag2)
			{
				return (long)leftSign + (long)rightSign;
			}
			if (flag)
			{
				return new BigInteger(BigIntegerCalculator.Add(rightBits, NumericsHelpers.Abs(leftSign)), leftSign < 0);
			}
			if (flag2)
			{
				return new BigInteger(BigIntegerCalculator.Add(leftBits, NumericsHelpers.Abs(rightSign)), leftSign < 0);
			}
			if (leftBits.Length < rightBits.Length)
			{
				return new BigInteger(BigIntegerCalculator.Add(rightBits, leftBits), leftSign < 0);
			}
			return new BigInteger(BigIntegerCalculator.Add(leftBits, rightBits), leftSign < 0);
		}

		/// <summary>Вычитает значение <see cref="T:System.Numerics.BigInteger" /> из другого значения <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Значение, из которого следует вычитать (уменьшаемое).</param>
		/// <param name="right">Значение для вычитания (вычитаемое).</param>
		/// <returns>Результат вычитания <paramref name="right" /> из <paramref name="left" />.</returns>
		// Token: 0x0600017B RID: 379 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		public static BigInteger operator -(BigInteger left, BigInteger right)
		{
			if (left._sign < 0 != right._sign < 0)
			{
				return BigInteger.Add(left._bits, left._sign, right._bits, -1 * right._sign);
			}
			return BigInteger.Subtract(left._bits, left._sign, right._bits, right._sign);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000C930 File Offset: 0x0000AB30
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			bool flag = leftBits == null;
			bool flag2 = rightBits == null;
			if (flag && flag2)
			{
				return (long)leftSign - (long)rightSign;
			}
			if (flag)
			{
				return new BigInteger(BigIntegerCalculator.Subtract(rightBits, NumericsHelpers.Abs(leftSign)), leftSign >= 0);
			}
			if (flag2)
			{
				return new BigInteger(BigIntegerCalculator.Subtract(leftBits, NumericsHelpers.Abs(rightSign)), leftSign < 0);
			}
			if (BigIntegerCalculator.Compare(leftBits, rightBits) < 0)
			{
				return new BigInteger(BigIntegerCalculator.Subtract(rightBits, leftBits), leftSign >= 0);
			}
			return new BigInteger(BigIntegerCalculator.Subtract(leftBits, rightBits), leftSign < 0);
		}

		/// <summary>Определяет неявное преобразование значения типа byte без знака в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x0600017D RID: 381 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		public static implicit operator BigInteger(byte value)
		{
			return new BigInteger((int)value);
		}

		/// <summary>Определяет неявное преобразование 8-битового знакового целого числа в значение <see cref="T:System.Numerics.BigInteger" />.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="M:System.Numerics.BigInteger.#ctor(System.Int32)" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x0600017E RID: 382 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		[CLSCompliant(false)]
		public static implicit operator BigInteger(sbyte value)
		{
			return new BigInteger((int)value);
		}

		/// <summary>Определяет неявное преобразование 16-битового знакового целого числа в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x0600017F RID: 383 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		public static implicit operator BigInteger(short value)
		{
			return new BigInteger((int)value);
		}

		/// <summary>Определяет неявное преобразование 16-битового целого числа без знака в значение <see cref="T:System.Numerics.BigInteger" />.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="M:System.Numerics.BigInteger.op_Implicit(System.Int32)~System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000180 RID: 384 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ushort value)
		{
			return new BigInteger((int)value);
		}

		/// <summary>Определяет неявное преобразование 32-разрядного целого числа со знаком в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000181 RID: 385 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		public static implicit operator BigInteger(int value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет неявное преобразование 32-разрядного целого числа без знака в значение <see cref="T:System.Numerics.BigInteger" />.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="M:System.Numerics.BigInteger.op_Implicit(System.Int64)~System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000182 RID: 386 RVA: 0x0000C9C2 File Offset: 0x0000ABC2
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет неявное преобразование 64-разрядного целого числа со знаком в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000183 RID: 387 RVA: 0x0000C9CA File Offset: 0x0000ABCA
		public static implicit operator BigInteger(long value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет неявное преобразование 64-разрядного целого числа без знака в значение <see cref="T:System.Numerics.BigInteger" />.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="T:System.Double" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000184 RID: 388 RVA: 0x0000C9D2 File Offset: 0x0000ABD2
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ulong value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет явное преобразование значения <see cref="T:System.Single" /> в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> имеет значение <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" /> или <see cref="F:System.Single.NegativeInfinity" />.</exception>
		// Token: 0x06000185 RID: 389 RVA: 0x0000C9DA File Offset: 0x0000ABDA
		public static explicit operator BigInteger(float value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет явное преобразование значения <see cref="T:System.Double" /> в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> имеет значение <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" /> или <see cref="F:System.Double.NegativeInfinity" />.</exception>
		// Token: 0x06000186 RID: 390 RVA: 0x0000C9E2 File Offset: 0x0000ABE2
		public static explicit operator BigInteger(double value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Decimal" /> в значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Numerics.BigInteger" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000187 RID: 391 RVA: 0x0000C9EA File Offset: 0x0000ABEA
		public static explicit operator BigInteger(decimal value)
		{
			return new BigInteger(value);
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в байтовое значение без знака.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Byte" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000188 RID: 392 RVA: 0x0000C9F2 File Offset: 0x0000ABF2
		public static explicit operator byte(BigInteger value)
		{
			return checked((byte)((int)value));
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 8-битового числа со знаком.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="T:System.Int16" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в значение 8-разрядного знакового числа.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000189 RID: 393 RVA: 0x0000C9FB File Offset: 0x0000ABFB
		[CLSCompliant(false)]
		public static explicit operator sbyte(BigInteger value)
		{
			return checked((sbyte)((int)value));
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 16-битового знакового целого числа.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в 16-разрядное знаковое целое число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x0600018A RID: 394 RVA: 0x0000CA04 File Offset: 0x0000AC04
		public static explicit operator short(BigInteger value)
		{
			return checked((short)((int)value));
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 16-битового целого числа без знака.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="T:System.Int32" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в 16-разрядное целое число без знака.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x0600018B RID: 395 RVA: 0x0000CA0D File Offset: 0x0000AC0D
		[CLSCompliant(false)]
		public static explicit operator ushort(BigInteger value)
		{
			return checked((ushort)((int)value));
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 32-разрядного целого числа со знаком.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в 32-разрядное целое число со знаком.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x0600018C RID: 396 RVA: 0x0000CA18 File Offset: 0x0000AC18
		public static explicit operator int(BigInteger value)
		{
			if (value._bits == null)
			{
				return value._sign;
			}
			if (value._bits.Length > 1)
			{
				throw new OverflowException("Value was either too large or too small for an Int32.");
			}
			if (value._sign > 0)
			{
				return checked((int)value._bits[0]);
			}
			if (value._bits[0] > 2147483648U)
			{
				throw new OverflowException("Value was either too large or too small for an Int32.");
			}
			return (int)(-(int)value._bits[0]);
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 32-разрядного целого числа без знака.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="T:System.Int64" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в 32-разрядное целое число без знака.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x0600018D RID: 397 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[CLSCompliant(false)]
		public static explicit operator uint(BigInteger value)
		{
			if (value._bits == null)
			{
				return checked((uint)value._sign);
			}
			if (value._bits.Length > 1 || value._sign < 0)
			{
				throw new OverflowException("Value was either too large or too small for a UInt32.");
			}
			return value._bits[0];
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 64-разрядного целого числа со знаком.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в 64-разрядное знаковое целое число.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.Int64.MinValue" /> или больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x0600018E RID: 398 RVA: 0x0000CABC File Offset: 0x0000ACBC
		public static explicit operator long(BigInteger value)
		{
			if (value._bits == null)
			{
				return (long)value._sign;
			}
			int num = value._bits.Length;
			if (num > 2)
			{
				throw new OverflowException("Value was either too large or too small for an Int64.");
			}
			ulong num2;
			if (num > 1)
			{
				num2 = NumericsHelpers.MakeUlong(value._bits[1], value._bits[0]);
			}
			else
			{
				num2 = (ulong)value._bits[0];
			}
			long num3 = (long)((value._sign > 0) ? num2 : (-(long)num2));
			if ((num3 > 0L && value._sign > 0) || (num3 < 0L && value._sign < 0))
			{
				return num3;
			}
			throw new OverflowException("Value was either too large or too small for an Int64.");
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение 64-разрядного целого числа без знака.  
		/// Этот интерфейс API CLS-несовместим. Совместимая альтернатива — <see cref="T:System.Double" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в 64-разрядное целое число без знака.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x0600018F RID: 399 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		[CLSCompliant(false)]
		public static explicit operator ulong(BigInteger value)
		{
			if (value._bits == null)
			{
				return checked((ulong)value._sign);
			}
			int num = value._bits.Length;
			if (num > 2 || value._sign < 0)
			{
				throw new OverflowException("Value was either too large or too small for a UInt64.");
			}
			if (num > 1)
			{
				return NumericsHelpers.MakeUlong(value._bits[1], value._bits[0]);
			}
			return (ulong)value._bits[0];
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение числа с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в значение числа с плавающей запятой одиночной точности.</param>
		/// <returns>Объект, содержащий ближайшее возможное представление параметра <paramref name="value" />.</returns>
		// Token: 0x06000190 RID: 400 RVA: 0x0000CBAB File Offset: 0x0000ADAB
		public static explicit operator float(BigInteger value)
		{
			return (float)((double)value);
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение <see cref="T:System.Double" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Double" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		// Token: 0x06000191 RID: 401 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		public static explicit operator double(BigInteger value)
		{
			int sign = value._sign;
			uint[] bits = value._bits;
			if (bits == null)
			{
				return (double)sign;
			}
			int num = bits.Length;
			if (num <= 32)
			{
				ulong num2 = (ulong)bits[num - 1];
				ulong num3 = (ulong)((num > 1) ? bits[num - 2] : 0U);
				ulong num4 = (ulong)((num > 2) ? bits[num - 3] : 0U);
				int num5 = NumericsHelpers.CbitHighZero((uint)num2);
				int exp = (num - 2) * 32 - num5;
				ulong man = num2 << 32 + num5 | num3 << num5 | num4 >> 32 - num5;
				return NumericsHelpers.GetDoubleFromParts(sign, exp, man);
			}
			if (sign == 1)
			{
				return double.PositiveInfinity;
			}
			return double.NegativeInfinity;
		}

		/// <summary>Определяет явное преобразование объекта <see cref="T:System.Numerics.BigInteger" /> в значение <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение, которое необходимо преобразовать в тип <see cref="T:System.Decimal" />.</param>
		/// <returns>Объект, содержащий значение параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.Decimal.MinValue" /> или больше <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x06000192 RID: 402 RVA: 0x0000CC5C File Offset: 0x0000AE5C
		public static explicit operator decimal(BigInteger value)
		{
			if (value._bits == null)
			{
				return value._sign;
			}
			int num = value._bits.Length;
			if (num > 3)
			{
				throw new OverflowException("Value was either too large or too small for a Decimal.");
			}
			int lo = 0;
			int mid = 0;
			int hi = 0;
			if (num > 2)
			{
				hi = (int)value._bits[2];
			}
			if (num > 1)
			{
				mid = (int)value._bits[1];
			}
			if (num > 0)
			{
				lo = (int)value._bits[0];
			}
			return new decimal(lo, mid, hi, value._sign < 0, 0);
		}

		/// <summary>Выполняет битовую операцию <see langword="And" /> для двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое значение в вычитании.</param>
		/// <param name="right">Второе значение в вычитании.</param>
		/// <returns>Результат битовой операции <see langword="And" />.</returns>
		// Token: 0x06000193 RID: 403 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		public static BigInteger operator &(BigInteger left, BigInteger right)
		{
			if (left.IsZero || right.IsZero)
			{
				return BigInteger.Zero;
			}
			if (left._bits == null && right._bits == null)
			{
				return left._sign & right._sign;
			}
			uint[] array = left.ToUInt32Array();
			uint[] array2 = right.ToUInt32Array();
			uint[] array3 = new uint[Math.Max(array.Length, array2.Length)];
			uint num = (left._sign < 0) ? uint.MaxValue : 0U;
			uint num2 = (right._sign < 0) ? uint.MaxValue : 0U;
			for (int i = 0; i < array3.Length; i++)
			{
				uint num3 = (i < array.Length) ? array[i] : num;
				uint num4 = (i < array2.Length) ? array2[i] : num2;
				array3[i] = (num3 & num4);
			}
			return new BigInteger(array3);
		}

		/// <summary>Выполняет битовую операцию <see langword="Or" /> для двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое значение в вычитании.</param>
		/// <param name="right">Второе значение в вычитании.</param>
		/// <returns>Результат битовой операции <see langword="Or" />.</returns>
		// Token: 0x06000194 RID: 404 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public static BigInteger operator |(BigInteger left, BigInteger right)
		{
			if (left.IsZero)
			{
				return right;
			}
			if (right.IsZero)
			{
				return left;
			}
			if (left._bits == null && right._bits == null)
			{
				return left._sign | right._sign;
			}
			uint[] array = left.ToUInt32Array();
			uint[] array2 = right.ToUInt32Array();
			uint[] array3 = new uint[Math.Max(array.Length, array2.Length)];
			uint num = (left._sign < 0) ? uint.MaxValue : 0U;
			uint num2 = (right._sign < 0) ? uint.MaxValue : 0U;
			for (int i = 0; i < array3.Length; i++)
			{
				uint num3 = (i < array.Length) ? array[i] : num;
				uint num4 = (i < array2.Length) ? array2[i] : num2;
				array3[i] = (num3 | num4);
			}
			return new BigInteger(array3);
		}

		/// <summary>Выполняет битовую операцию исключающего <see langword="Or" /> (<see langword="XOr" />) для двух значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое значение в вычитании.</param>
		/// <param name="right">Второе значение в вычитании.</param>
		/// <returns>Результат битовой операции <see langword="Or" />.</returns>
		// Token: 0x06000195 RID: 405 RVA: 0x0000CE64 File Offset: 0x0000B064
		public static BigInteger operator ^(BigInteger left, BigInteger right)
		{
			if (left._bits == null && right._bits == null)
			{
				return left._sign ^ right._sign;
			}
			uint[] array = left.ToUInt32Array();
			uint[] array2 = right.ToUInt32Array();
			uint[] array3 = new uint[Math.Max(array.Length, array2.Length)];
			uint num = (left._sign < 0) ? uint.MaxValue : 0U;
			uint num2 = (right._sign < 0) ? uint.MaxValue : 0U;
			for (int i = 0; i < array3.Length; i++)
			{
				uint num3 = (i < array.Length) ? array[i] : num;
				uint num4 = (i < array2.Length) ? array2[i] : num2;
				array3[i] = (num3 ^ num4);
			}
			return new BigInteger(array3);
		}

		/// <summary>Сдвигает значение <see cref="T:System.Numerics.BigInteger" /> на указанное число битов влево.</summary>
		/// <param name="value">Значение, для которого необходимо выполнить побитовый сдвиг.</param>
		/// <param name="shift">Количество битов, на которое необходимо сдвинуть влево значение <paramref name="value" />.</param>
		/// <returns>Значение, которое было сдвинуто влево на указанное число бит.</returns>
		// Token: 0x06000196 RID: 406 RVA: 0x0000CF14 File Offset: 0x0000B114
		public static BigInteger operator <<(BigInteger value, int shift)
		{
			if (shift == 0)
			{
				return value;
			}
			if (shift == -2147483648)
			{
				return value >> int.MaxValue >> 1;
			}
			if (shift < 0)
			{
				return value >> -shift;
			}
			int num = shift / 32;
			int num2 = shift - num * 32;
			uint[] array;
			int num3;
			bool partsForBitManipulation = BigInteger.GetPartsForBitManipulation(ref value, out array, out num3);
			uint[] array2 = new uint[num3 + num + 1];
			if (num2 == 0)
			{
				for (int i = 0; i < num3; i++)
				{
					array2[i + num] = array[i];
				}
			}
			else
			{
				int num4 = 32 - num2;
				uint num5 = 0U;
				int j;
				for (j = 0; j < num3; j++)
				{
					uint num6 = array[j];
					array2[j + num] = (num6 << num2 | num5);
					num5 = num6 >> num4;
				}
				array2[j + num] = num5;
			}
			return new BigInteger(array2, partsForBitManipulation);
		}

		/// <summary>Сдвигает значение <see cref="T:System.Numerics.BigInteger" /> на указанное число битов вправо.</summary>
		/// <param name="value">Значение, для которого необходимо выполнить побитовый сдвиг.</param>
		/// <param name="shift">Количество битов, на которое необходимо сдвинуть <paramref name="value" /> вправо.</param>
		/// <returns>Значение, которое было сдвинуто вправо на указанное число бит.</returns>
		// Token: 0x06000197 RID: 407 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
		public static BigInteger operator >>(BigInteger value, int shift)
		{
			if (shift == 0)
			{
				return value;
			}
			if (shift == -2147483648)
			{
				return value << int.MaxValue << 1;
			}
			if (shift < 0)
			{
				return value << -shift;
			}
			int num = shift / 32;
			int num2 = shift - num * 32;
			uint[] array;
			int num3;
			bool partsForBitManipulation = BigInteger.GetPartsForBitManipulation(ref value, out array, out num3);
			if (partsForBitManipulation)
			{
				if (shift >= 32 * num3)
				{
					return BigInteger.MinusOne;
				}
				uint[] array2 = new uint[num3];
				Array.Copy(array, 0, array2, 0, num3);
				array = array2;
				NumericsHelpers.DangerousMakeTwosComplement(array);
			}
			int num4 = num3 - num;
			if (num4 < 0)
			{
				num4 = 0;
			}
			uint[] array3 = new uint[num4];
			if (num2 == 0)
			{
				for (int i = num3 - 1; i >= num; i--)
				{
					array3[i - num] = array[i];
				}
			}
			else
			{
				int num5 = 32 - num2;
				uint num6 = 0U;
				for (int j = num3 - 1; j >= num; j--)
				{
					uint num7 = array[j];
					if (partsForBitManipulation && j == num3 - 1)
					{
						array3[j - num] = (num7 >> num2 | uint.MaxValue << num5);
					}
					else
					{
						array3[j - num] = (num7 >> num2 | num6);
					}
					num6 = num7 << num5;
				}
			}
			if (partsForBitManipulation)
			{
				NumericsHelpers.DangerousMakeTwosComplement(array3);
			}
			return new BigInteger(array3, partsForBitManipulation);
		}

		/// <summary>Возвращает результат битовой операции дополнения до единицы для значения <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="value">Целочисленное значение.</param>
		/// <returns>Битовое дополнение значения <paramref name="value" /> до единицы.</returns>
		// Token: 0x06000198 RID: 408 RVA: 0x0000D10A File Offset: 0x0000B30A
		public static BigInteger operator ~(BigInteger value)
		{
			return -(value + BigInteger.One);
		}

		/// <summary>Меняет знак указанного значения BigInteger.</summary>
		/// <param name="value">Инвертируемое значение.</param>
		/// <returns>Результат умножения параметра <paramref name="value" /> на минус единицу (-1).</returns>
		// Token: 0x06000199 RID: 409 RVA: 0x0000D11C File Offset: 0x0000B31C
		public static BigInteger operator -(BigInteger value)
		{
			return new BigInteger(-value._sign, value._bits);
		}

		/// <summary>Возвращает значение операнда <see cref="T:System.Numerics.BigInteger" />. (Знак операнда не изменяется.)</summary>
		/// <param name="value">Целочисленное значение.</param>
		/// <returns>Значение операнда <paramref name="value" />.</returns>
		// Token: 0x0600019A RID: 410 RVA: 0x00002068 File Offset: 0x00000268
		public static BigInteger operator +(BigInteger value)
		{
			return value;
		}

		/// <summary>Увеличивает значение <see cref="T:System.Numerics.BigInteger" /> на 1.</summary>
		/// <param name="value">Увеличиваемое значение.</param>
		/// <returns>Значение параметра <paramref name="value" />, увеличенное на 1.</returns>
		// Token: 0x0600019B RID: 411 RVA: 0x0000D130 File Offset: 0x0000B330
		public static BigInteger operator ++(BigInteger value)
		{
			return value + BigInteger.One;
		}

		/// <summary>Уменьшает значение <see cref="T:System.Numerics.BigInteger" /> на 1.</summary>
		/// <param name="value">Уменьшаемое значение.</param>
		/// <returns>Значение параметра <paramref name="value" />, уменьшенное на 1.</returns>
		// Token: 0x0600019C RID: 412 RVA: 0x0000D13D File Offset: 0x0000B33D
		public static BigInteger operator --(BigInteger value)
		{
			return value - BigInteger.One;
		}

		/// <summary>Складывает значения двух указанных объектов <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое из складываемых значений.</param>
		/// <param name="right">Второе из складываемых значений.</param>
		/// <returns>Сумма <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x0600019D RID: 413 RVA: 0x0000D14C File Offset: 0x0000B34C
		public static BigInteger operator +(BigInteger left, BigInteger right)
		{
			if (left._sign < 0 != right._sign < 0)
			{
				return BigInteger.Subtract(left._bits, left._sign, right._bits, -1 * right._sign);
			}
			return BigInteger.Add(left._bits, left._sign, right._bits, right._sign);
		}

		/// <summary>Умножает два заданных значения <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое значение для перемножения.</param>
		/// <param name="right">Второе значение для перемножения.</param>
		/// <returns>Произведение <paramref name="left" /> на <paramref name="right" />.</returns>
		// Token: 0x0600019E RID: 414 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		public static BigInteger operator *(BigInteger left, BigInteger right)
		{
			bool flag = left._bits == null;
			bool flag2 = right._bits == null;
			if (flag && flag2)
			{
				return (long)left._sign * (long)right._sign;
			}
			if (flag)
			{
				return new BigInteger(BigIntegerCalculator.Multiply(right._bits, NumericsHelpers.Abs(left._sign)), left._sign < 0 ^ right._sign < 0);
			}
			if (flag2)
			{
				return new BigInteger(BigIntegerCalculator.Multiply(left._bits, NumericsHelpers.Abs(right._sign)), left._sign < 0 ^ right._sign < 0);
			}
			if (left._bits == right._bits)
			{
				return new BigInteger(BigIntegerCalculator.Square(left._bits), left._sign < 0 ^ right._sign < 0);
			}
			if (left._bits.Length < right._bits.Length)
			{
				return new BigInteger(BigIntegerCalculator.Multiply(right._bits, left._bits), left._sign < 0 ^ right._sign < 0);
			}
			return new BigInteger(BigIntegerCalculator.Multiply(left._bits, right._bits), left._sign < 0 ^ right._sign < 0);
		}

		/// <summary>Делит указанное значение <see cref="T:System.Numerics.BigInteger" /> на другое указанное значение <see cref="T:System.Numerics.BigInteger" />, используя целочисленное деление.</summary>
		/// <param name="dividend">Значение, которое необходимо разделить.</param>
		/// <param name="divisor">Значение, на которое необходимо разделить.</param>
		/// <returns>Целочисленный результат деления.</returns>
		/// <exception cref="T:System.DivideByZeroException">Значение параметра <paramref name="divisor" /> равно нулю (0).</exception>
		// Token: 0x0600019F RID: 415 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		public static BigInteger operator /(BigInteger dividend, BigInteger divisor)
		{
			bool flag = dividend._bits == null;
			bool flag2 = divisor._bits == null;
			if (flag && flag2)
			{
				return dividend._sign / divisor._sign;
			}
			if (flag)
			{
				return BigInteger.s_bnZeroInt;
			}
			if (flag2)
			{
				return new BigInteger(BigIntegerCalculator.Divide(dividend._bits, NumericsHelpers.Abs(divisor._sign)), dividend._sign < 0 ^ divisor._sign < 0);
			}
			if (dividend._bits.Length < divisor._bits.Length)
			{
				return BigInteger.s_bnZeroInt;
			}
			return new BigInteger(BigIntegerCalculator.Divide(dividend._bits, divisor._bits), dividend._sign < 0 ^ divisor._sign < 0);
		}

		/// <summary>Возвращает остаток от деления двух заданных значений <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="dividend">Значение, которое необходимо разделить.</param>
		/// <param name="divisor">Значение, на которое необходимо разделить.</param>
		/// <returns>Остаток от деления.</returns>
		/// <exception cref="T:System.DivideByZeroException">Значение параметра <paramref name="divisor" /> равно нулю (0).</exception>
		// Token: 0x060001A0 RID: 416 RVA: 0x0000D39C File Offset: 0x0000B59C
		public static BigInteger operator %(BigInteger dividend, BigInteger divisor)
		{
			bool flag = dividend._bits == null;
			bool flag2 = divisor._bits == null;
			if (flag && flag2)
			{
				return dividend._sign % divisor._sign;
			}
			if (flag)
			{
				return dividend;
			}
			if (flag2)
			{
				uint num = BigIntegerCalculator.Remainder(dividend._bits, NumericsHelpers.Abs(divisor._sign));
				return (long)((dividend._sign < 0) ? (ulong.MaxValue * (ulong)num) : ((ulong)num));
			}
			if (dividend._bits.Length < divisor._bits.Length)
			{
				return dividend;
			}
			return new BigInteger(BigIntegerCalculator.Remainder(dividend._bits, divisor._bits), dividend._sign < 0);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение типа <see cref="T:System.Numerics.BigInteger" /> меньше другого значения типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A1 RID: 417 RVA: 0x0000D43F File Offset: 0x0000B63F
		public static bool operator <(BigInteger left, BigInteger right)
		{
			return left.CompareTo(right) < 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение типа <see cref="T:System.Numerics.BigInteger" /> меньше или равно другому значению типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A2 RID: 418 RVA: 0x0000D44C File Offset: 0x0000B64C
		public static bool operator <=(BigInteger left, BigInteger right)
		{
			return left.CompareTo(right) <= 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение типа <see cref="T:System.Numerics.BigInteger" /> больше другого значения типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A3 RID: 419 RVA: 0x0000D45C File Offset: 0x0000B65C
		public static bool operator >(BigInteger left, BigInteger right)
		{
			return left.CompareTo(right) > 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение типа <see cref="T:System.Numerics.BigInteger" /> больше или равно другому значению типа <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A4 RID: 420 RVA: 0x0000D469 File Offset: 0x0000B669
		public static bool operator >=(BigInteger left, BigInteger right)
		{
			return left.CompareTo(right) >= 0;
		}

		/// <summary>Возвращает значение, указывающее, равны ли значения двух объектов <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> имеют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001A5 RID: 421 RVA: 0x0000D479 File Offset: 0x0000B679
		public static bool operator ==(BigInteger left, BigInteger right)
		{
			return left.Equals(right);
		}

		/// <summary>Возвращает значение, указывающее, различаются ли значения двух объектов <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001A6 RID: 422 RVA: 0x0000D483 File Offset: 0x0000B683
		public static bool operator !=(BigInteger left, BigInteger right)
		{
			return !left.Equals(right);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> меньше 64-битового знакового целого числа.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A7 RID: 423 RVA: 0x0000D490 File Offset: 0x0000B690
		public static bool operator <(BigInteger left, long right)
		{
			return left.CompareTo(right) < 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> меньше или равно 64-разрядному знаковому целому числу.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A8 RID: 424 RVA: 0x0000D49D File Offset: 0x0000B69D
		public static bool operator <=(BigInteger left, long right)
		{
			return left.CompareTo(right) <= 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> больше значения 64-битового знакового целого числа.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A9 RID: 425 RVA: 0x0000D4AD File Offset: 0x0000B6AD
		public static bool operator >(BigInteger left, long right)
		{
			return left.CompareTo(right) > 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> больше или равно значению 64-битового знакового целого числа.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001AA RID: 426 RVA: 0x0000D4BA File Offset: 0x0000B6BA
		public static bool operator >=(BigInteger left, long right)
		{
			return left.CompareTo(right) >= 0;
		}

		/// <summary>Возвращает значение, указывающее, равны ли значение <see cref="T:System.Numerics.BigInteger" /> и длинное знаковое целое число.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> имеют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001AB RID: 427 RVA: 0x0000D4CA File Offset: 0x0000B6CA
		public static bool operator ==(BigInteger left, long right)
		{
			return left.Equals(right);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> и 64-разрядное знаковое целое число не равны.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001AC RID: 428 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		public static bool operator !=(BigInteger left, long right)
		{
			return !left.Equals(right);
		}

		/// <summary>Возвращает значение, определяющее, действительно 64-разрядное знаковое целое число меньше значения <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001AD RID: 429 RVA: 0x0000D4E1 File Offset: 0x0000B6E1
		public static bool operator <(long left, BigInteger right)
		{
			return right.CompareTo(left) > 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное знаковое целое число меньше или равно значению <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001AE RID: 430 RVA: 0x0000D4EE File Offset: 0x0000B6EE
		public static bool operator <=(long left, BigInteger right)
		{
			return right.CompareTo(left) >= 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно 64-разрядное знаковое целое число больше или равно значению <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001AF RID: 431 RVA: 0x0000D4FE File Offset: 0x0000B6FE
		public static bool operator >(long left, BigInteger right)
		{
			return right.CompareTo(left) < 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное знаковое целое число больше или равно значению <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001B0 RID: 432 RVA: 0x0000D50B File Offset: 0x0000B70B
		public static bool operator >=(long left, BigInteger right)
		{
			return right.CompareTo(left) <= 0;
		}

		/// <summary>Возвращает значение, указывающее, равны ли длинное знаковое целое число и значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> имеют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B1 RID: 433 RVA: 0x0000D51B File Offset: 0x0000B71B
		public static bool operator ==(long left, BigInteger right)
		{
			return right.Equals(left);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное знаковое целое число и значение <see cref="T:System.Numerics.BigInteger" /> не равны.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B2 RID: 434 RVA: 0x0000D525 File Offset: 0x0000B725
		public static bool operator !=(long left, BigInteger right)
		{
			return !right.Equals(left);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> меньше 64-битового целого числа без знака.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001B3 RID: 435 RVA: 0x0000D532 File Offset: 0x0000B732
		[CLSCompliant(false)]
		public static bool operator <(BigInteger left, ulong right)
		{
			return left.CompareTo(right) < 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> меньше или равно 64-разрядному целому числу без знака.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001B4 RID: 436 RVA: 0x0000D53F File Offset: 0x0000B73F
		[CLSCompliant(false)]
		public static bool operator <=(BigInteger left, ulong right)
		{
			return left.CompareTo(right) <= 0;
		}

		/// <summary>Возвращает значение, определяющее действительно ли значение <see cref="T:System.Numerics.BigInteger" /> больше 64-битового целого числа без знака.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001B5 RID: 437 RVA: 0x0000D54F File Offset: 0x0000B74F
		[CLSCompliant(false)]
		public static bool operator >(BigInteger left, ulong right)
		{
			return left.CompareTo(right) > 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> больше или равно значению 64-битового целого числа без знака.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001B6 RID: 438 RVA: 0x0000D55C File Offset: 0x0000B75C
		[CLSCompliant(false)]
		public static bool operator >=(BigInteger left, ulong right)
		{
			return left.CompareTo(right) >= 0;
		}

		/// <summary>Возвращает значение, указывающее, равны ли значение <see cref="T:System.Numerics.BigInteger" /> и длинное целое число без знака.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> имеют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B7 RID: 439 RVA: 0x0000D56C File Offset: 0x0000B76C
		[CLSCompliant(false)]
		public static bool operator ==(BigInteger left, ulong right)
		{
			return left.Equals(right);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли значение <see cref="T:System.Numerics.BigInteger" /> и 64-разрядное целое число без знака не равны.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001B8 RID: 440 RVA: 0x0000D576 File Offset: 0x0000B776
		[CLSCompliant(false)]
		public static bool operator !=(BigInteger left, ulong right)
		{
			return !left.Equals(right);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное целое число без знака меньше значения <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001B9 RID: 441 RVA: 0x0000D583 File Offset: 0x0000B783
		[CLSCompliant(false)]
		public static bool operator <(ulong left, BigInteger right)
		{
			return right.CompareTo(left) > 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное целое число без знака меньше или равно значению <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001BA RID: 442 RVA: 0x0000D590 File Offset: 0x0000B790
		[CLSCompliant(false)]
		public static bool operator <=(ulong left, BigInteger right)
		{
			return right.CompareTo(left) >= 0;
		}

		/// <summary>Возвращает значение, определяющее действительно ли значение <see cref="T:System.Numerics.BigInteger" /> больше 64-битового целого числа без знака.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001BB RID: 443 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		[CLSCompliant(false)]
		public static bool operator >(ulong left, BigInteger right)
		{
			return right.CompareTo(left) < 0;
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное целое число без знака больше или равно значению <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001BC RID: 444 RVA: 0x0000D5AD File Offset: 0x0000B7AD
		[CLSCompliant(false)]
		public static bool operator >=(ulong left, BigInteger right)
		{
			return right.CompareTo(left) <= 0;
		}

		/// <summary>Возвращает значение, указывающее, равны ли длинное целое число без знака и значение <see cref="T:System.Numerics.BigInteger" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> имеют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001BD RID: 445 RVA: 0x0000D5BD File Offset: 0x0000B7BD
		[CLSCompliant(false)]
		public static bool operator ==(ulong left, BigInteger right)
		{
			return right.Equals(left);
		}

		/// <summary>Возвращает значение, определяющее, действительно ли 64-разрядное целое число без знака и значение <see cref="T:System.Numerics.BigInteger" /> не равны.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001BE RID: 446 RVA: 0x0000D5C7 File Offset: 0x0000B7C7
		[CLSCompliant(false)]
		public static bool operator !=(ulong left, BigInteger right)
		{
			return !right.Equals(left);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl)
		{
			if (x._bits == null)
			{
				if (x._sign < 0)
				{
					xd = new uint[]
					{
						(uint)(-(uint)x._sign)
					};
				}
				else
				{
					xd = new uint[]
					{
						(uint)x._sign
					};
				}
			}
			else
			{
				xd = x._bits;
			}
			xl = ((x._bits == null) ? 1 : x._bits.Length);
			return x._sign < 0;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000D640 File Offset: 0x0000B840
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu)
		{
			int num = cu;
			while (--num >= 0)
			{
				if (rgu1[num] != rgu2[num])
				{
					return num + 1;
				}
			}
			return 0;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000D666 File Offset: 0x0000B866
		[Conditional("DEBUG")]
		private void AssertValid()
		{
			uint[] bits = this._bits;
		}

		// Token: 0x0400006B RID: 107
		private const int knMaskHighBit = -2147483648;

		// Token: 0x0400006C RID: 108
		private const uint kuMaskHighBit = 2147483648U;

		// Token: 0x0400006D RID: 109
		private const int kcbitUint = 32;

		// Token: 0x0400006E RID: 110
		private const int kcbitUlong = 64;

		// Token: 0x0400006F RID: 111
		private const int DecimalScaleFactorMask = 16711680;

		// Token: 0x04000070 RID: 112
		private const int DecimalSignMask = -2147483648;

		// Token: 0x04000071 RID: 113
		internal readonly int _sign;

		// Token: 0x04000072 RID: 114
		internal readonly uint[] _bits;

		// Token: 0x04000073 RID: 115
		private static readonly BigInteger s_bnMinInt = new BigInteger(-1, new uint[]
		{
			2147483648U
		});

		// Token: 0x04000074 RID: 116
		private static readonly BigInteger s_bnOneInt = new BigInteger(1);

		// Token: 0x04000075 RID: 117
		private static readonly BigInteger s_bnZeroInt = new BigInteger(0);

		// Token: 0x04000076 RID: 118
		private static readonly BigInteger s_bnMinusOneInt = new BigInteger(-1);

		// Token: 0x04000077 RID: 119
		private static readonly byte[] s_success = Array.Empty<byte>();

		// Token: 0x0200000E RID: 14
		private enum GetBytesMode
		{
			// Token: 0x04000079 RID: 121
			AllocateArray,
			// Token: 0x0400007A RID: 122
			Count,
			// Token: 0x0400007B RID: 123
			Span
		}
	}
}
