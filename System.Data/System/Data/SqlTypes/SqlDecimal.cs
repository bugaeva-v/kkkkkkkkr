using System;
using System.Data.Common;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет числовое значение с фиксированной точностью и масштабом в диапазоне от - 10^38 +1 и 10^38 - 1.</summary>
	// Token: 0x0200030E RID: 782
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlDecimal : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002375 RID: 9077 RVA: 0x000A23BC File Offset: 0x000A05BC
		private byte CalculatePrecision()
		{
			int num;
			uint[] array;
			uint num2;
			if (this._data4 != 0U)
			{
				num = 33;
				array = SqlDecimal.s_decimalHelpersHiHi;
				num2 = this._data4;
			}
			else if (this._data3 != 0U)
			{
				num = 24;
				array = SqlDecimal.s_decimalHelpersHi;
				num2 = this._data3;
			}
			else if (this._data2 != 0U)
			{
				num = 15;
				array = SqlDecimal.s_decimalHelpersMid;
				num2 = this._data2;
			}
			else
			{
				num = 5;
				array = SqlDecimal.s_decimalHelpersLo;
				num2 = this._data1;
			}
			if (num2 < array[num])
			{
				num -= 2;
				if (num2 < array[num])
				{
					num -= 2;
					if (num2 < array[num])
					{
						num--;
					}
					else
					{
						num++;
					}
				}
				else
				{
					num++;
				}
			}
			else
			{
				num += 2;
				if (num2 < array[num])
				{
					num--;
				}
				else
				{
					num++;
				}
			}
			if (num2 >= array[num])
			{
				num++;
				if (num == 37 && num2 >= array[num])
				{
					num++;
				}
			}
			byte b = (byte)(num + 1);
			if (b > 1 && this.VerifyPrecision(b - 1))
			{
				b -= 1;
			}
			return Math.Max(b, this._bScale);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000A24A8 File Offset: 0x000A06A8
		private bool VerifyPrecision(byte precision)
		{
			int num = (int)(checked(precision - 1));
			if (this._data4 < SqlDecimal.s_decimalHelpersHiHi[num])
			{
				return true;
			}
			if (this._data4 == SqlDecimal.s_decimalHelpersHiHi[num])
			{
				if (this._data3 < SqlDecimal.s_decimalHelpersHi[num])
				{
					return true;
				}
				if (this._data3 == SqlDecimal.s_decimalHelpersHi[num])
				{
					if (this._data2 < SqlDecimal.s_decimalHelpersMid[num])
					{
						return true;
					}
					if (this._data2 == SqlDecimal.s_decimalHelpersMid[num] && this._data1 < SqlDecimal.s_decimalHelpersLo[num])
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000A252C File Offset: 0x000A072C
		private SqlDecimal(bool fNull)
		{
			this._bLen = (this._bPrec = (this._bScale = 0));
			this._bStatus = 0;
			this._data1 = (this._data2 = (this._data3 = (this._data4 = SqlDecimal.s_uiZero)));
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с помощью предоставленного значения <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Decimal" />, сохраняемое как структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		// Token: 0x06002378 RID: 9080 RVA: 0x000A2580 File Offset: 0x000A0780
		public SqlDecimal(decimal value)
		{
			this._bStatus = SqlDecimal.s_bNotNull;
			int[] bits = decimal.GetBits(value);
			uint num = (uint)bits[3];
			this._data1 = (uint)bits[0];
			this._data2 = (uint)bits[1];
			this._data3 = (uint)bits[2];
			this._data4 = SqlDecimal.s_uiZero;
			this._bStatus |= (((num & 2147483648U) == 2147483648U) ? SqlDecimal.s_bNegative : 0);
			if (this._data3 != 0U)
			{
				this._bLen = 3;
			}
			else if (this._data2 != 0U)
			{
				this._bLen = 2;
			}
			else
			{
				this._bLen = 1;
			}
			this._bScale = (byte)((int)(num & 16711680U) >> 16);
			this._bPrec = 0;
			this._bPrec = this.CalculatePrecision();
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с использованием предоставленного целого значения.</summary>
		/// <param name="value">Предоставленное целое число, используемое в качестве значения новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		// Token: 0x06002379 RID: 9081 RVA: 0x000A263C File Offset: 0x000A083C
		public SqlDecimal(int value)
		{
			this._bStatus = SqlDecimal.s_bNotNull;
			uint data = (uint)value;
			if (value < 0)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
				if (value != -2147483648)
				{
					data = (uint)(-(uint)value);
				}
			}
			this._data1 = data;
			this._data2 = (this._data3 = (this._data4 = SqlDecimal.s_uiZero));
			this._bLen = 1;
			this._bPrec = SqlDecimal.BGetPrecUI4(this._data1);
			this._bScale = 0;
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с помощью предоставленного длинного целого значения.</summary>
		/// <param name="value">Предоставленное длинное целое число, используемое в качестве значения новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		// Token: 0x0600237A RID: 9082 RVA: 0x000A26BC File Offset: 0x000A08BC
		public SqlDecimal(long value)
		{
			this._bStatus = SqlDecimal.s_bNotNull;
			ulong num = (ulong)value;
			if (value < 0L)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
				if (value != -9223372036854775808L)
				{
					num = (ulong)(-(ulong)value);
				}
			}
			this._data1 = (uint)num;
			this._data2 = (uint)(num >> 32);
			this._data3 = (this._data4 = 0U);
			this._bLen = ((this._data2 == 0U) ? 1 : 2);
			this._bPrec = SqlDecimal.BGetPrecUI8(num);
			this._bScale = 0;
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с использованием предоставленных параметров.</summary>
		/// <param name="bPrecision">Максимальное число цифр, используемое для представления свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="bScale">Число десятичных разрядов, для которых будет осуществляться разрешение свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> для новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="fPositive">Логическое значение, указывающее, представляет ли новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" /> положительное или отрицательное число.</param>
		/// <param name="bits">128-разрядное целое число без знака, предоставляющее значение новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		// Token: 0x0600237B RID: 9083 RVA: 0x000A2748 File Offset: 0x000A0948
		public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int[] bits)
		{
			SqlDecimal.CheckValidPrecScale(bPrecision, bScale);
			if (bits == null)
			{
				throw new ArgumentNullException("bits");
			}
			if (bits.Length != 4)
			{
				throw new ArgumentException(SQLResource.InvalidArraySizeMessage, "bits");
			}
			this._bPrec = bPrecision;
			this._bScale = bScale;
			this._data1 = (uint)bits[0];
			this._data2 = (uint)bits[1];
			this._data3 = (uint)bits[2];
			this._data4 = (uint)bits[3];
			this._bLen = 1;
			for (int i = 3; i >= 0; i--)
			{
				if (bits[i] != 0)
				{
					this._bLen = (byte)(i + 1);
					break;
				}
			}
			this._bStatus = SqlDecimal.s_bNotNull;
			if (!fPositive)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
			if (bPrecision < this.CalculatePrecision())
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с использованием предоставленных параметров.</summary>
		/// <param name="bPrecision">Максимальное число цифр, используемое для представления свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="bScale">Число десятичных разрядов, для которых будет осуществляться разрешение свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> для новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="fPositive">Логическое значение, указывающее, представляет ли новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" /> положительное или отрицательное число.</param>
		/// <param name="data1">32-разрядное целое число без знака, объединяемое с data2, data3 и data4 при составлении 128-разрядного целого числа без знака, которое представляет новое значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="data2">32-разрядное целое число без знака, объединяемое с data1, data3 и data4 при составлении 128-разрядного целого числа без знака, которое представляет новое значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="data3">32-разрядное целое число без знака, объединяемое с data1, data2 и data4 при составлении 128-разрядного целого числа без знака, которое представляет новое значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="data4">32-разрядное целое число без знака, объединяемое с data1, data2 и data3 при составлении 128-разрядного целого числа без знака, которое представляет новое значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		// Token: 0x0600237C RID: 9084 RVA: 0x000A2820 File Offset: 0x000A0A20
		public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int data1, int data2, int data3, int data4)
		{
			SqlDecimal.CheckValidPrecScale(bPrecision, bScale);
			this._bPrec = bPrecision;
			this._bScale = bScale;
			this._data1 = (uint)data1;
			this._data2 = (uint)data2;
			this._data3 = (uint)data3;
			this._data4 = (uint)data4;
			this._bLen = 1;
			if (data4 == 0)
			{
				if (data3 == 0)
				{
					if (data2 == 0)
					{
						this._bLen = 1;
					}
					else
					{
						this._bLen = 2;
					}
				}
				else
				{
					this._bLen = 3;
				}
			}
			else
			{
				this._bLen = 4;
			}
			this._bStatus = SqlDecimal.s_bNotNull;
			if (!fPositive)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
			if (bPrecision < this.CalculatePrecision())
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с использованием предоставленного параметра типа double.</summary>
		/// <param name="dVal">Значение типа double для новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		// Token: 0x0600237D RID: 9085 RVA: 0x000A28DC File Offset: 0x000A0ADC
		public SqlDecimal(double dVal)
		{
			this = new SqlDecimal(false);
			this._bStatus = SqlDecimal.s_bNotNull;
			if (dVal < 0.0)
			{
				dVal = -dVal;
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (dVal >= SqlDecimal.s_DMAX_NUME)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			double num = Math.Floor(dVal);
			double num2 = dVal - num;
			this._bPrec = SqlDecimal.s_NUMERIC_MAX_PRECISION;
			this._bLen = 1;
			if (num > 0.0)
			{
				dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
				this._data1 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
				num = dVal;
				if (num > 0.0)
				{
					dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
					this._data2 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
					num = dVal;
					this._bLen += 1;
					if (num > 0.0)
					{
						dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
						this._data3 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
						num = dVal;
						this._bLen += 1;
						if (num > 0.0)
						{
							dVal = Math.Floor(num / SqlDecimal.s_DUINT_BASE);
							this._data4 = (uint)(num - dVal * SqlDecimal.s_DUINT_BASE);
							this._bLen += 1;
						}
					}
				}
			}
			uint num3 = (uint)(this.FZero() ? 0 : this.CalculatePrecision());
			if (num3 > SqlDecimal.s_DBL_DIG)
			{
				uint num4 = num3 - SqlDecimal.s_DBL_DIG;
				uint num5;
				do
				{
					num5 = this.DivByULong(10U);
					num4 -= 1U;
				}
				while (num4 > 0U);
				num4 = num3 - SqlDecimal.s_DBL_DIG;
				if (num5 >= 5U)
				{
					this.AddULong(1U);
					num3 = (uint)this.CalculatePrecision() + num4;
				}
				do
				{
					this.MultByULong(10U);
					num4 -= 1U;
				}
				while (num4 > 0U);
			}
			this._bScale = (byte)((num3 < SqlDecimal.s_DBL_DIG) ? (SqlDecimal.s_DBL_DIG - num3) : 0U);
			this._bPrec = (byte)(num3 + (uint)this._bScale);
			if (this._bScale > 0)
			{
				num3 = (uint)this._bScale;
				do
				{
					uint num6 = (num3 >= 9U) ? 9U : num3;
					num2 *= SqlDecimal.s_rgulShiftBase[(int)(num6 - 1U)];
					num3 -= num6;
					this.MultByULong(SqlDecimal.s_rgulShiftBase[(int)(num6 - 1U)]);
					this.AddULong((uint)num2);
					num2 -= Math.Floor(num2);
				}
				while (num3 > 0U);
			}
			if (num2 >= 0.5)
			{
				this.AddULong(1U);
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000A2B38 File Offset: 0x000A0D38
		private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
		{
			SqlDecimal.CheckValidPrecScale(bPrec, bScale);
			this._bLen = bLen;
			this._bPrec = bPrec;
			this._bScale = bScale;
			this._data1 = rglData[0];
			this._data2 = rglData[1];
			this._data3 = rglData[2];
			this._data4 = rglData[3];
			this._bStatus = SqlDecimal.s_bNotNull;
			if (!fPositive)
			{
				this._bStatus |= SqlDecimal.s_bNegative;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlDecimal" /> значение null.</summary>
		/// <returns>Значение <see langword="true" />, если данная структура <see cref="T:System.Data.SqlTypes.SqlDecimal" /> имеет значение NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000A2BB7 File Offset: 0x000A0DB7
		public bool IsNull
		{
			get
			{
				return (this._bStatus & SqlDecimal.s_bNullMask) == SqlDecimal.s_bIsNull;
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Число в диапазоне от -79 228 162 514 264 337 593 543 950 335 до 79 228 162 514 264 337 593 543 950 335.</returns>
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000A2BCC File Offset: 0x000A0DCC
		public decimal Value
		{
			get
			{
				return this.ToDecimal();
			}
		}

		/// <summary>Указывает, больше ли нуля <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>
		///   <see langword="true" />, если для <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> назначено значение NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000A2BD4 File Offset: 0x000A0DD4
		public bool IsPositive
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return (this._bStatus & SqlDecimal.s_bSignMask) == SqlDecimal.s_bPositive;
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x000A2BF7 File Offset: 0x000A0DF7
		private void SetPositive()
		{
			this._bStatus &= SqlDecimal.s_bReverseSignMask;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x000A2C0C File Offset: 0x000A0E0C
		private void SetSignBit(bool fPositive)
		{
			this._bStatus = (fPositive ? (this._bStatus & SqlDecimal.s_bReverseSignMask) : (this._bStatus | SqlDecimal.s_bNegative));
		}

		/// <summary>Получает максимальное число цифр, используемых для представления свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" />.</summary>
		/// <returns>Максимальное число цифр, используемых для представления <see langword="Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000A2C32 File Offset: 0x000A0E32
		public byte Precision
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this._bPrec;
			}
		}

		/// <summary>Получает число десятичных разрядов для разрешения <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" />.</summary>
		/// <returns>Число десятичных разрядов, используемых для разрешения свойства <see langword="Value" />.</returns>
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000A2C48 File Offset: 0x000A0E48
		public byte Scale
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return this._bScale;
			}
		}

		/// <summary>Получает двоичное представление данной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в виде массива целых чисел.</summary>
		/// <returns>Массив целых чисел, содержащий двоичное представление данной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000A2C5E File Offset: 0x000A0E5E
		public int[] Data
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				return new int[]
				{
					(int)this._data1,
					(int)this._data2,
					(int)this._data3,
					(int)this._data4
				};
			}
		}

		/// <summary>Получает двоичное представление значения данной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в виде массива байтов.</summary>
		/// <returns>Массив байтов, содержащий двоичное представление значения структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000A2C98 File Offset: 0x000A0E98
		public byte[] BinData
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				int num = (int)this._data1;
				int num2 = (int)this._data2;
				int num3 = (int)this._data3;
				int num4 = (int)this._data4;
				byte[] array = new byte[16];
				array[0] = (byte)(num & 255);
				num >>= 8;
				array[1] = (byte)(num & 255);
				num >>= 8;
				array[2] = (byte)(num & 255);
				num >>= 8;
				array[3] = (byte)(num & 255);
				array[4] = (byte)(num2 & 255);
				num2 >>= 8;
				array[5] = (byte)(num2 & 255);
				num2 >>= 8;
				array[6] = (byte)(num2 & 255);
				num2 >>= 8;
				array[7] = (byte)(num2 & 255);
				array[8] = (byte)(num3 & 255);
				num3 >>= 8;
				array[9] = (byte)(num3 & 255);
				num3 >>= 8;
				array[10] = (byte)(num3 & 255);
				num3 >>= 8;
				array[11] = (byte)(num3 & 255);
				array[12] = (byte)(num4 & 255);
				num4 >>= 8;
				array[13] = (byte)(num4 & 255);
				num4 >>= 8;
				array[14] = (byte)(num4 & 255);
				num4 >>= 8;
				array[15] = (byte)(num4 & 255);
				return array;
			}
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.String" />.</summary>
		/// <returns>Новый объект <see cref="T:System.String" />, содержащий строковое представление свойства <see cref="T:System.Data.SqlTypes.SqlDecimal" />, относящегося к структуре <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" />.</returns>
		// Token: 0x06002388 RID: 9096 RVA: 0x000A2DC0 File Offset: 0x000A0FC0
		public override string ToString()
		{
			if (this.IsNull)
			{
				return SQLResource.NullString;
			}
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			int bLen = (int)this._bLen;
			char[] array2 = new char[(int)(SqlDecimal.s_NUMERIC_MAX_PRECISION + 1)];
			int i = 0;
			while (bLen > 1 || array[0] != 0U)
			{
				uint uiDigit;
				SqlDecimal.MpDiv1(array, ref bLen, SqlDecimal.s_ulBase10, out uiDigit);
				array2[i++] = SqlDecimal.ChFromDigit(uiDigit);
			}
			while (i <= (int)this._bScale)
			{
				array2[i++] = SqlDecimal.ChFromDigit(0U);
			}
			int num = 0;
			int num2 = 0;
			if (this._bScale > 0)
			{
				num = 1;
			}
			char[] array3;
			if (this.IsPositive)
			{
				array3 = new char[num + i];
			}
			else
			{
				array3 = new char[num + i + 1];
				array3[num2++] = '-';
			}
			while (i > 0)
			{
				if (i-- == (int)this._bScale)
				{
					array3[num2++] = '.';
				}
				array3[num2++] = array2[i];
			}
			return new string(array3);
		}

		/// <summary>Преобразует представление числа типа <see cref="T:System.String" /> в эквивалентное ему значение <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="s">Представление <see langword="String" />, которое необходимо проанализировать.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlDecimal" />, эквивалентное значению, которое содержится в заданном представлении <see cref="T:System.String" />.</returns>
		// Token: 0x06002389 RID: 9097 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		public static SqlDecimal Parse(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s == SQLResource.NullString)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal @null = SqlDecimal.Null;
			char[] array = s.ToCharArray();
			int num = array.Length;
			int num2 = -1;
			int num3 = 0;
			@null._bPrec = 1;
			@null._bScale = 0;
			@null.SetToZero();
			while (num != 0 && array[num - 1] == ' ')
			{
				num--;
			}
			if (num == 0)
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			while (array[num3] == ' ')
			{
				num3++;
				num--;
			}
			if (array[num3] == '-')
			{
				@null.SetSignBit(false);
				num3++;
				num--;
			}
			else
			{
				@null.SetSignBit(true);
				if (array[num3] == '+')
				{
					num3++;
					num--;
				}
			}
			while (num > 2 && array[num3] == '0')
			{
				num3++;
				num--;
			}
			if (2 == num && '0' == array[num3] && '.' == array[num3 + 1])
			{
				array[num3] = '.';
				array[num3 + 1] = '0';
			}
			if (num == 0 || num > (int)(SqlDecimal.s_NUMERIC_MAX_PRECISION + 1))
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			while (num > 1 && array[num3] == '0')
			{
				num3++;
				num--;
			}
			int i;
			for (i = 0; i < num; i++)
			{
				char c = array[num3];
				num3++;
				if (c >= '0' && c <= '9')
				{
					c -= '0';
					@null.MultByULong(SqlDecimal.s_ulBase10);
					@null.AddULong((uint)c);
				}
				else
				{
					if (c != '.' || num2 >= 0)
					{
						throw new FormatException(SQLResource.FormatMessage);
					}
					num2 = i;
				}
			}
			if (num2 < 0)
			{
				@null._bPrec = (byte)i;
				@null._bScale = 0;
			}
			else
			{
				@null._bPrec = (byte)(i - 1);
				@null._bScale = (byte)((int)@null._bPrec - num2);
			}
			if (@null._bPrec > SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			if (@null._bPrec == 0)
			{
				throw new FormatException(SQLResource.FormatMessage);
			}
			if (@null.FZero())
			{
				@null.SetPositive();
			}
			return @null;
		}

		/// <summary>Возвращает число типа double, равное содержимому свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> данного экземпляра.</summary>
		/// <returns>Десятичное представление свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" />.</returns>
		// Token: 0x0600238A RID: 9098 RVA: 0x000A30CC File Offset: 0x000A12CC
		public double ToDouble()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			double num = this._data4;
			num = num * (double)SqlDecimal.s_lInt32Base + this._data3;
			num = num * (double)SqlDecimal.s_lInt32Base + this._data2;
			num = num * (double)SqlDecimal.s_lInt32Base + this._data1;
			num /= Math.Pow(10.0, (double)this._bScale);
			if (!this.IsPositive)
			{
				return -num;
			}
			return num;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x000A3154 File Offset: 0x000A1354
		private decimal ToDecimal()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			if (this._data4 != 0U || this._bScale > 28)
			{
				throw new OverflowException(SQLResource.ConversionOverflowMessage);
			}
			return new decimal((int)this._data1, (int)this._data2, (int)this._data3, !this.IsPositive, this._bScale);
		}

		/// <summary>Преобразует значение <see cref="T:System.Decimal" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемое значение <see cref="T:System.Decimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно значению параметра <see langword="Decimal" />.</returns>
		// Token: 0x0600238C RID: 9100 RVA: 0x000A31B2 File Offset: 0x000A13B2
		public static implicit operator SqlDecimal(decimal x)
		{
			return new SqlDecimal(x);
		}

		/// <summary>Преобразует параметр <see cref="T:System.Double" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Double" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, значение которой равно значению параметра <see cref="T:System.Double" />.</returns>
		// Token: 0x0600238D RID: 9101 RVA: 0x000A31BA File Offset: 0x000A13BA
		public static explicit operator SqlDecimal(double x)
		{
			return new SqlDecimal(x);
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Int64" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Int64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно значению параметра <see cref="T:System.Int64" />.</returns>
		// Token: 0x0600238E RID: 9102 RVA: 0x000A31C2 File Offset: 0x000A13C2
		public static implicit operator SqlDecimal(long x)
		{
			return new SqlDecimal(new decimal(x));
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Decimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see langword="Decimal" />, значение которой равно <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x0600238F RID: 9103 RVA: 0x000A31CF File Offset: 0x000A13CF
		public static explicit operator decimal(SqlDecimal x)
		{
			return x.Value;
		}

		/// <summary>Оператор "унарный минус" меняет знак параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, для которой выполняется инверсия.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, значение которой содержит инвертированный результат.</returns>
		// Token: 0x06002390 RID: 9104 RVA: 0x000A31D8 File Offset: 0x000A13D8
		public static SqlDecimal operator -(SqlDecimal x)
		{
			if (x.IsNull)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal result = x;
			if (result.FZero())
			{
				result.SetPositive();
			}
			else
			{
				result.SetSignBit(!result.IsPositive);
			}
			return result;
		}

		/// <summary>Вычисляет сумму двух операторов <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, у которой свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> содержит сумму.</returns>
		// Token: 0x06002391 RID: 9105 RVA: 0x000A321C File Offset: 0x000A141C
		public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDecimal.Null;
			}
			bool flag = true;
			bool flag2 = x.IsPositive;
			bool flag3 = y.IsPositive;
			int bScale = (int)x._bScale;
			int bScale2 = (int)y._bScale;
			int num = Math.Max((int)x._bPrec - bScale, (int)y._bPrec - bScale2);
			int num2 = Math.Max(bScale, bScale2);
			int num3 = num + num2 + 1;
			num3 = Math.Min((int)SqlDecimal.MaxPrecision, num3);
			if (num3 - num < num2)
			{
				num2 = num3 - num;
			}
			if (bScale != num2)
			{
				x.AdjustScale(num2 - bScale, true);
			}
			if (bScale2 != num2)
			{
				y.AdjustScale(num2 - bScale2, true);
			}
			if (!flag2)
			{
				flag2 = !flag2;
				flag3 = !flag3;
				flag = !flag;
			}
			int num4 = (int)x._bLen;
			int bLen = (int)y._bLen;
			uint[] array = new uint[]
			{
				x._data1,
				x._data2,
				x._data3,
				x._data4
			};
			uint[] array2 = new uint[]
			{
				y._data1,
				y._data2,
				y._data3,
				y._data4
			};
			byte bLen2;
			if (flag3)
			{
				ulong num5 = 0UL;
				int num6 = 0;
				while (num6 < num4 || num6 < bLen)
				{
					if (num6 < num4)
					{
						num5 += (ulong)array[num6];
					}
					if (num6 < bLen)
					{
						num5 += (ulong)array2[num6];
					}
					array[num6] = (uint)num5;
					num5 >>= 32;
					num6++;
				}
				if (num5 != 0UL)
				{
					if (num6 == SqlDecimal.s_cNumeMax)
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					array[num6] = (uint)num5;
					num6++;
				}
				bLen2 = (byte)num6;
			}
			else
			{
				int num7 = 0;
				if (x.LAbsCmp(y) < 0)
				{
					flag = !flag;
					uint[] array3 = array2;
					array2 = array;
					array = array3;
					num4 = bLen;
					bLen = (int)x._bLen;
				}
				ulong num5 = SqlDecimal.s_ulInt32Base;
				int num6 = 0;
				while (num6 < num4 || num6 < bLen)
				{
					if (num6 < num4)
					{
						num5 += (ulong)array[num6];
					}
					if (num6 < bLen)
					{
						num5 -= (ulong)array2[num6];
					}
					array[num6] = (uint)num5;
					if (array[num6] != 0U)
					{
						num7 = num6;
					}
					num5 >>= 32;
					num5 += SqlDecimal.s_ulInt32BaseForMod;
					num6++;
				}
				bLen2 = (byte)(num7 + 1);
			}
			SqlDecimal result = new SqlDecimal(array, bLen2, (byte)num3, (byte)num2, flag);
			if (result.FGt10_38() || result.CalculatePrecision() > SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			if (result.FZero())
			{
				result.SetPositive();
			}
			return result;
		}

		/// <summary>Вычисляет результаты вычитания второго операнда <see cref="T:System.Data.SqlTypes.SqlDecimal" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство Value которой содержит результаты вычитания.</returns>
		// Token: 0x06002392 RID: 9106 RVA: 0x000A3491 File Offset: 0x000A1691
		public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y)
		{
			return x + -y;
		}

		/// <summary>Оператор умножения вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой содержит результат умножения.</returns>
		// Token: 0x06002393 RID: 9107 RVA: 0x000A34A0 File Offset: 0x000A16A0
		public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDecimal.Null;
			}
			int bLen = (int)y._bLen;
			int num = (int)(x._bScale + y._bScale);
			int num2 = num;
			int num3 = (int)(x._bPrec - x._bScale + (y._bPrec - y._bScale) + 1);
			int num4 = num2 + num3;
			if (num4 > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				num4 = (int)SqlDecimal.s_NUMERIC_MAX_PRECISION;
			}
			if (num2 > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				num2 = (int)SqlDecimal.s_NUMERIC_MAX_PRECISION;
			}
			num2 = Math.Min(num4 - num3, num2);
			num2 = Math.Max(num2, Math.Min(num, (int)SqlDecimal.s_cNumeDivScaleMin));
			int num5 = num2 - num;
			bool fPositive = x.IsPositive == y.IsPositive;
			uint[] array = new uint[]
			{
				x._data1,
				x._data2,
				x._data3,
				x._data4
			};
			uint[] array2 = new uint[]
			{
				y._data1,
				y._data2,
				y._data3,
				y._data4
			};
			uint[] array3 = new uint[9];
			int i = 0;
			for (int j = 0; j < (int)x._bLen; j++)
			{
				uint num6 = array[j];
				ulong num7 = 0UL;
				i = j;
				for (int k = 0; k < bLen; k++)
				{
					ulong num8 = num7 + (ulong)array3[i];
					ulong num9 = (ulong)array2[k];
					num7 = (ulong)num6 * num9;
					num7 += num8;
					if (num7 < num8)
					{
						num8 = SqlDecimal.s_ulInt32Base;
					}
					else
					{
						num8 = 0UL;
					}
					array3[i++] = (uint)num7;
					num7 = (num7 >> 32) + num8;
				}
				if (num7 != 0UL)
				{
					array3[i++] = (uint)num7;
				}
			}
			while (array3[i] == 0U && i > 0)
			{
				i--;
			}
			int num10 = i + 1;
			if (num5 != 0)
			{
				if (num5 < 0)
				{
					uint num11;
					uint num12;
					do
					{
						if (num5 <= -9)
						{
							num11 = SqlDecimal.s_rgulShiftBase[8];
							num5 += 9;
						}
						else
						{
							num11 = SqlDecimal.s_rgulShiftBase[-num5 - 1];
							num5 = 0;
						}
						SqlDecimal.MpDiv1(array3, ref num10, num11, out num12);
					}
					while (num5 != 0);
					if (num10 > SqlDecimal.s_cNumeMax)
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					for (i = num10; i < SqlDecimal.s_cNumeMax; i++)
					{
						array3[i] = 0U;
					}
					SqlDecimal result = new SqlDecimal(array3, (byte)num10, (byte)num4, (byte)num2, fPositive);
					if (result.FGt10_38())
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					if (num12 >= num11 / 2U)
					{
						result.AddULong(1U);
					}
					if (result.FZero())
					{
						result.SetPositive();
					}
					return result;
				}
				else
				{
					if (num10 > SqlDecimal.s_cNumeMax)
					{
						throw new OverflowException(SQLResource.ArithOverflowMessage);
					}
					for (i = num10; i < SqlDecimal.s_cNumeMax; i++)
					{
						array3[i] = 0U;
					}
					SqlDecimal result = new SqlDecimal(array3, (byte)num10, (byte)num4, (byte)num, fPositive);
					if (result.FZero())
					{
						result.SetPositive();
					}
					result.AdjustScale(num5, true);
					return result;
				}
			}
			else
			{
				if (num10 > SqlDecimal.s_cNumeMax)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
				for (i = num10; i < SqlDecimal.s_cNumeMax; i++)
				{
					array3[i] = 0U;
				}
				SqlDecimal result = new SqlDecimal(array3, (byte)num10, (byte)num4, (byte)num2, fPositive);
				if (result.FGt10_38())
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
				if (result.FZero())
				{
					result.SetPositive();
				}
				return result;
			}
		}

		/// <summary>Оператор деления вычисляет результаты деления первого операнда <see cref="T:System.Data.SqlTypes.SqlDecimal" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x06002394 RID: 9108 RVA: 0x000A37E4 File Offset: 0x000A19E4
		public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (y.FZero())
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			bool fPositive = x.IsPositive == y.IsPositive;
			int num = Math.Max((int)(x._bScale + y._bPrec + 1), (int)SqlDecimal.s_cNumeDivScaleMin);
			int num2 = (int)(x._bPrec - x._bScale + y._bScale);
			int num3 = num + (int)x._bPrec + (int)y._bPrec + 1;
			int val = Math.Min(num, (int)SqlDecimal.s_cNumeDivScaleMin);
			num2 = Math.Min(num2, (int)SqlDecimal.s_NUMERIC_MAX_PRECISION);
			num3 = num2 + num;
			if (num3 > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				num3 = (int)SqlDecimal.s_NUMERIC_MAX_PRECISION;
			}
			num = Math.Min(num3 - num2, num);
			num = Math.Max(num, val);
			int digits = num - (int)x._bScale + (int)y._bScale;
			x.AdjustScale(digits, true);
			uint[] rgulU = new uint[]
			{
				x._data1,
				x._data2,
				x._data3,
				x._data4
			};
			uint[] rgulD = new uint[]
			{
				y._data1,
				y._data2,
				y._data3,
				y._data4
			};
			uint[] rgulR = new uint[SqlDecimal.s_cNumeMax + 1];
			uint[] array = new uint[SqlDecimal.s_cNumeMax];
			int num4;
			int num5;
			SqlDecimal.MpDiv(rgulU, (int)x._bLen, rgulD, (int)y._bLen, array, out num4, rgulR, out num5);
			SqlDecimal.ZeroToMaxLen(array, num4);
			SqlDecimal result = new SqlDecimal(array, (byte)num4, (byte)num3, (byte)num, fPositive);
			if (result.FZero())
			{
				result.SetPositive();
			}
			return result;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x06002395 RID: 9109 RVA: 0x000A3983 File Offset: 0x000A1B83
		public static explicit operator SqlDecimal(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((int)x.ByteValue);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x06002396 RID: 9110 RVA: 0x000A39A0 File Offset: 0x000A1BA0
		public static implicit operator SqlDecimal(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((int)x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x06002397 RID: 9111 RVA: 0x000A39BD File Offset: 0x000A1BBD
		public static implicit operator SqlDecimal(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((int)x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство которой <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> равно свойству <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x06002398 RID: 9112 RVA: 0x000A39DA File Offset: 0x000A1BDA
		public static implicit operator SqlDecimal(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlInt64" /> в SqlDecimal.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x06002399 RID: 9113 RVA: 0x000A39F7 File Offset: 0x000A1BF7
		public static implicit operator SqlDecimal(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует операнд <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x0600239A RID: 9114 RVA: 0x000A3A14 File Offset: 0x000A1C14
		public static implicit operator SqlDecimal(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.ToDecimal());
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно свойству <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x0600239B RID: 9115 RVA: 0x000A3A31 File Offset: 0x000A1C31
		public static explicit operator SqlDecimal(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal((double)x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленную структуру <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x0600239C RID: 9116 RVA: 0x000A3A4F File Offset: 0x000A1C4F
		public static explicit operator SqlDecimal(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlDecimal(x.Value);
			}
			return SqlDecimal.Null;
		}

		/// <summary>Преобразует предоставленный параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Преобразуемый объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой равно значению, представленному параметром <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x0600239D RID: 9117 RVA: 0x000A3A6C File Offset: 0x000A1C6C
		public static explicit operator SqlDecimal(SqlString x)
		{
			if (!x.IsNull)
			{
				return SqlDecimal.Parse(x.Value);
			}
			return SqlDecimal.Null;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000A3A8C File Offset: 0x000A1C8C
		[Conditional("DEBUG")]
		private void AssertValid()
		{
			if (this.IsNull)
			{
				return;
			}
			object obj = (new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			})[(int)(this._bLen - 1)];
			for (int i = (int)this._bLen; i < SqlDecimal.s_cNumeMax; i++)
			{
			}
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000A3AEC File Offset: 0x000A1CEC
		private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur)
		{
			switch (cUI4sCur)
			{
			case 1:
				rgulData[1] = (rgulData[2] = (rgulData[3] = 0U));
				return;
			case 2:
				rgulData[2] = (rgulData[3] = 0U);
				return;
			case 3:
				rgulData[3] = 0U;
				return;
			default:
				return;
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000A3B2E File Offset: 0x000A1D2E
		private static byte CLenFromPrec(byte bPrec)
		{
			return SqlDecimal.s_rgCLenFromPrec[(int)(bPrec - 1)];
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000A3B39 File Offset: 0x000A1D39
		private bool FZero()
		{
			return this._data1 == 0U && this._bLen <= 1;
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000A3B54 File Offset: 0x000A1D54
		private bool FGt10_38()
		{
			return (ulong)this._data4 >= 1262177448UL && this._bLen == 4 && ((ulong)this._data4 > 1262177448UL || (ulong)this._data3 > 1518781562UL || ((ulong)this._data3 == 1518781562UL && (ulong)this._data2 >= 160047680UL));
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
		private bool FGt10_38(uint[] rglData)
		{
			return (ulong)rglData[3] >= 1262177448UL && ((ulong)rglData[3] > 1262177448UL || (ulong)rglData[2] > 1518781562UL || ((ulong)rglData[2] == 1518781562UL && (ulong)rglData[1] >= 160047680UL));
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000A3C14 File Offset: 0x000A1E14
		private static byte BGetPrecUI4(uint value)
		{
			int num;
			if (value < SqlDecimal.s_ulT4)
			{
				if (value < SqlDecimal.s_ulT2)
				{
					num = ((value >= SqlDecimal.s_ulT1) ? 2 : 1);
				}
				else
				{
					num = ((value >= SqlDecimal.s_ulT3) ? 4 : 3);
				}
			}
			else if (value < SqlDecimal.s_ulT8)
			{
				if (value < SqlDecimal.s_ulT6)
				{
					num = ((value >= SqlDecimal.s_ulT5) ? 6 : 5);
				}
				else
				{
					num = ((value >= SqlDecimal.s_ulT7) ? 8 : 7);
				}
			}
			else
			{
				num = ((value >= SqlDecimal.s_ulT9) ? 10 : 9);
			}
			return (byte)num;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000A3C8E File Offset: 0x000A1E8E
		private static byte BGetPrecUI8(uint ulU0, uint ulU1)
		{
			return SqlDecimal.BGetPrecUI8((ulong)ulU0 + ((ulong)ulU1 << 32));
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000A3CA0 File Offset: 0x000A1EA0
		private static byte BGetPrecUI8(ulong dwlVal)
		{
			int num2;
			if (dwlVal < (ulong)SqlDecimal.s_ulT8)
			{
				uint num = (uint)dwlVal;
				if (num < SqlDecimal.s_ulT4)
				{
					if (num < SqlDecimal.s_ulT2)
					{
						num2 = ((num >= SqlDecimal.s_ulT1) ? 2 : 1);
					}
					else
					{
						num2 = ((num >= SqlDecimal.s_ulT3) ? 4 : 3);
					}
				}
				else if (num < SqlDecimal.s_ulT6)
				{
					num2 = ((num >= SqlDecimal.s_ulT5) ? 6 : 5);
				}
				else
				{
					num2 = ((num >= SqlDecimal.s_ulT7) ? 8 : 7);
				}
			}
			else if (dwlVal < SqlDecimal.s_dwlT16)
			{
				if (dwlVal < SqlDecimal.s_dwlT12)
				{
					if (dwlVal < SqlDecimal.s_dwlT10)
					{
						num2 = ((dwlVal >= (ulong)SqlDecimal.s_ulT9) ? 10 : 9);
					}
					else
					{
						num2 = ((dwlVal >= SqlDecimal.s_dwlT11) ? 12 : 11);
					}
				}
				else if (dwlVal < SqlDecimal.s_dwlT14)
				{
					num2 = ((dwlVal >= SqlDecimal.s_dwlT13) ? 14 : 13);
				}
				else
				{
					num2 = ((dwlVal >= SqlDecimal.s_dwlT15) ? 16 : 15);
				}
			}
			else if (dwlVal < SqlDecimal.s_dwlT18)
			{
				num2 = ((dwlVal >= SqlDecimal.s_dwlT17) ? 18 : 17);
			}
			else
			{
				num2 = ((dwlVal >= SqlDecimal.s_dwlT19) ? 20 : 19);
			}
			return (byte)num2;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000A3DA8 File Offset: 0x000A1FA8
		private void AddULong(uint ulAdd)
		{
			ulong num = (ulong)ulAdd;
			int bLen = (int)this._bLen;
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			int num2 = 0;
			for (;;)
			{
				num += (ulong)array[num2];
				array[num2] = (uint)num;
				num >>= 32;
				if (num == 0UL)
				{
					break;
				}
				num2++;
				if (num2 >= bLen)
				{
					goto Block_2;
				}
			}
			this.StoreFromWorkingArray(array);
			return;
			Block_2:
			if (num2 == SqlDecimal.s_cNumeMax)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			array[num2] = (uint)num;
			this._bLen += 1;
			if (this.FGt10_38(array))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this.StoreFromWorkingArray(array);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000A3E54 File Offset: 0x000A2054
		private void MultByULong(uint uiMultiplier)
		{
			int bLen = (int)this._bLen;
			ulong num = 0UL;
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			for (int i = 0; i < bLen; i++)
			{
				ulong num2 = (ulong)array[i] * (ulong)uiMultiplier;
				num += num2;
				if (num < num2)
				{
					num2 = SqlDecimal.s_ulInt32Base;
				}
				else
				{
					num2 = 0UL;
				}
				array[i] = (uint)num;
				num = (num >> 32) + num2;
			}
			if (num != 0UL)
			{
				if (bLen == SqlDecimal.s_cNumeMax)
				{
					throw new OverflowException(SQLResource.ArithOverflowMessage);
				}
				array[bLen] = (uint)num;
				this._bLen += 1;
			}
			if (this.FGt10_38(array))
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			this.StoreFromWorkingArray(array);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000A3F18 File Offset: 0x000A2118
		private uint DivByULong(uint iDivisor)
		{
			ulong num = (ulong)iDivisor;
			ulong num2 = 0UL;
			bool flag = true;
			if (num == 0UL)
			{
				throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
			}
			uint[] array = new uint[]
			{
				this._data1,
				this._data2,
				this._data3,
				this._data4
			};
			for (int i = (int)this._bLen; i > 0; i--)
			{
				num2 = (num2 << 32) + (ulong)array[i - 1];
				uint num3 = (uint)(num2 / num);
				array[i - 1] = num3;
				num2 %= num;
				if (flag && num3 == 0U)
				{
					this._bLen -= 1;
				}
				else
				{
					flag = false;
				}
			}
			this.StoreFromWorkingArray(array);
			if (flag)
			{
				this._bLen = 1;
			}
			return (uint)num2;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000A3FCC File Offset: 0x000A21CC
		internal void AdjustScale(int digits, bool fRound)
		{
			bool flag = false;
			int i = digits;
			if (i + (int)this._bScale < 0)
			{
				throw new SqlTruncateException();
			}
			if (i + (int)this._bScale > (int)SqlDecimal.s_NUMERIC_MAX_PRECISION)
			{
				throw new OverflowException(SQLResource.ArithOverflowMessage);
			}
			byte bScale = (byte)(i + (int)this._bScale);
			byte bPrec = (byte)Math.Min((int)SqlDecimal.s_NUMERIC_MAX_PRECISION, Math.Max(1, i + (int)this._bPrec));
			if (i > 0)
			{
				this._bScale = bScale;
				this._bPrec = bPrec;
				while (i > 0)
				{
					uint num;
					if (i >= 9)
					{
						num = SqlDecimal.s_rgulShiftBase[8];
						i -= 9;
					}
					else
					{
						num = SqlDecimal.s_rgulShiftBase[i - 1];
						i = 0;
					}
					this.MultByULong(num);
				}
			}
			else if (i < 0)
			{
				uint num;
				uint num2;
				do
				{
					if (i <= -9)
					{
						num = SqlDecimal.s_rgulShiftBase[8];
						i += 9;
					}
					else
					{
						num = SqlDecimal.s_rgulShiftBase[-i - 1];
						i = 0;
					}
					num2 = this.DivByULong(num);
				}
				while (i < 0);
				flag = (num2 >= num / 2U);
				this._bScale = bScale;
				this._bPrec = bPrec;
			}
			if (flag && fRound)
			{
				this.AddULong(1U);
				return;
			}
			if (this.FZero())
			{
				this.SetPositive();
			}
		}

		/// <summary>Масштаб операнда <see cref="T:System.Data.SqlTypes.SqlDecimal" /> будет согласован с количеством цифр, указанным в параметре digits. В зависимости от значения параметра fRound данное значение или округляется до соответствующего числа цифр, или усекается.</summary>
		/// <param name="n">Настраиваемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="digits">Число цифр в настраиваемой структуре.</param>
		/// <param name="fRound">Если этот параметр имеет значение <see langword="true" />, новое значение округляется, если <see langword="false" /> — значение усекается.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой содержит настроенное число.</returns>
		// Token: 0x060023AB RID: 9131 RVA: 0x000A40E8 File Offset: 0x000A22E8
		public static SqlDecimal AdjustScale(SqlDecimal n, int digits, bool fRound)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal result = n;
			result.AdjustScale(digits, fRound);
			return result;
		}

		/// <summary>Настраивает значение операнда <see cref="T:System.Data.SqlTypes.SqlDecimal" /> для достижения указанной точности и масштаба.</summary>
		/// <param name="n">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, значение которой требуется настроить.</param>
		/// <param name="precision">Точность для новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="scale">Масштаб для новой структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, значение которой настроено для достижения точности и масштаба, указанных в данных параметрах.</returns>
		// Token: 0x060023AC RID: 9132 RVA: 0x000A4110 File Offset: 0x000A2310
		public static SqlDecimal ConvertToPrecScale(SqlDecimal n, int precision, int scale)
		{
			SqlDecimal.CheckValidPrecScale(precision, scale);
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			SqlDecimal sqlDecimal = n;
			int digits = scale - (int)sqlDecimal._bScale;
			sqlDecimal.AdjustScale(digits, true);
			byte b = SqlDecimal.CLenFromPrec((byte)precision);
			if (b < sqlDecimal._bLen)
			{
				throw new SqlTruncateException();
			}
			if (b == sqlDecimal._bLen && precision < (int)sqlDecimal.CalculatePrecision())
			{
				throw new SqlTruncateException();
			}
			sqlDecimal._bPrec = (byte)precision;
			return sqlDecimal;
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000A4184 File Offset: 0x000A2384
		private int LAbsCmp(SqlDecimal snumOp)
		{
			int bLen = (int)snumOp._bLen;
			int bLen2 = (int)this._bLen;
			if (bLen != bLen2)
			{
				if (bLen2 <= bLen)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				uint[] array = new uint[]
				{
					this._data1,
					this._data2,
					this._data3,
					this._data4
				};
				uint[] array2 = new uint[]
				{
					snumOp._data1,
					snumOp._data2,
					snumOp._data3,
					snumOp._data4
				};
				int num = bLen - 1;
				while (array[num] == array2[num])
				{
					num--;
					if (num < 0)
					{
						return 0;
					}
				}
				if (array[num] <= array2[num])
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000A4228 File Offset: 0x000A2428
		private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD)
		{
			ciulD = ciulS;
			for (int i = 0; i < ciulS; i++)
			{
				rgulD[i] = rgulS[i];
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000A424A File Offset: 0x000A244A
		private static void MpSet(uint[] rgulD, out int ciulD, uint iulN)
		{
			ciulD = 1;
			rgulD[0] = iulN;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x000A4253 File Offset: 0x000A2453
		private static void MpNormalize(uint[] rgulU, ref int ciulU)
		{
			while (ciulU > 1 && rgulU[ciulU - 1] == 0U)
			{
				ciulU--;
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000A426C File Offset: 0x000A246C
		private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX)
		{
			uint num = 0U;
			int i;
			for (i = 0; i < ciulD; i++)
			{
				ulong num2 = (ulong)piulD[i];
				ulong x = (ulong)num + num2 * (ulong)iulX;
				num = SqlDecimal.HI(x);
				piulD[i] = SqlDecimal.LO(x);
			}
			if (num != 0U)
			{
				piulD[i] = num;
				ciulD++;
			}
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000A42B4 File Offset: 0x000A24B4
		private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
		{
			uint num = 0U;
			ulong num2 = (ulong)iulD;
			int i = ciulU;
			while (i > 0)
			{
				i--;
				ulong num3 = ((ulong)num << 32) + (ulong)rgulU[i];
				rgulU[i] = (uint)(num3 / num2);
				num = (uint)(num3 - (ulong)rgulU[i] * num2);
			}
			iulR = num;
			SqlDecimal.MpNormalize(rgulU, ref ciulU);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x000A42F9 File Offset: 0x000A24F9
		internal static ulong DWL(uint lo, uint hi)
		{
			return (ulong)lo + ((ulong)hi << 32);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000A4303 File Offset: 0x000A2503
		private static uint HI(ulong x)
		{
			return (uint)(x >> 32);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000A430A File Offset: 0x000A250A
		private static uint LO(ulong x)
		{
			return (uint)x;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x000A4310 File Offset: 0x000A2510
		private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR)
		{
			if (ciulD == 1 && rgulD[0] == 0U)
			{
				ciulQ = (ciulR = 0);
				return;
			}
			if (ciulU == 1 && ciulD == 1)
			{
				SqlDecimal.MpSet(rgulQ, out ciulQ, rgulU[0] / rgulD[0]);
				SqlDecimal.MpSet(rgulR, out ciulR, rgulU[0] % rgulD[0]);
				return;
			}
			if (ciulD > ciulU)
			{
				SqlDecimal.MpMove(rgulU, ciulU, rgulR, out ciulR);
				SqlDecimal.MpSet(rgulQ, out ciulQ, 0U);
				return;
			}
			if (ciulU <= 2)
			{
				ulong num = SqlDecimal.DWL(rgulU[0], rgulU[1]);
				ulong num2 = (ulong)rgulD[0];
				if (ciulD > 1)
				{
					num2 += (ulong)rgulD[1] << 32;
				}
				ulong x = num / num2;
				rgulQ[0] = SqlDecimal.LO(x);
				rgulQ[1] = SqlDecimal.HI(x);
				ciulQ = ((SqlDecimal.HI(x) != 0U) ? 2 : 1);
				x = num % num2;
				rgulR[0] = SqlDecimal.LO(x);
				rgulR[1] = SqlDecimal.HI(x);
				ciulR = ((SqlDecimal.HI(x) != 0U) ? 2 : 1);
				return;
			}
			if (ciulD == 1)
			{
				SqlDecimal.MpMove(rgulU, ciulU, rgulQ, out ciulQ);
				uint num3;
				SqlDecimal.MpDiv1(rgulQ, ref ciulQ, rgulD[0], out num3);
				rgulR[0] = num3;
				ciulR = 1;
				return;
			}
			ciulQ = (ciulR = 0);
			if (rgulU != rgulR)
			{
				SqlDecimal.MpMove(rgulU, ciulU, rgulR, out ciulR);
			}
			ciulQ = ciulU - ciulD + 1;
			uint num4 = rgulD[ciulD - 1];
			rgulR[ciulU] = 0U;
			int num5 = ciulU;
			uint num6 = (uint)(SqlDecimal.s_ulInt32Base / ((ulong)num4 + 1UL));
			if (num6 > 1U)
			{
				SqlDecimal.MpMul1(rgulD, ref ciulD, num6);
				num4 = rgulD[ciulD - 1];
				SqlDecimal.MpMul1(rgulR, ref ciulR, num6);
			}
			uint num7 = rgulD[ciulD - 2];
			do
			{
				ulong num8 = SqlDecimal.DWL(rgulR[num5 - 1], rgulR[num5]);
				uint num9;
				if (num4 == rgulR[num5])
				{
					num9 = (uint)(SqlDecimal.s_ulInt32Base - 1UL);
				}
				else
				{
					num9 = (uint)(num8 / (ulong)num4);
				}
				ulong num10 = (ulong)num9;
				uint num11 = (uint)(num8 - num10 * (ulong)num4);
				while ((ulong)num7 * num10 > SqlDecimal.DWL(rgulR[num5 - 2], num11))
				{
					num9 -= 1U;
					if (num11 >= -num4)
					{
						break;
					}
					num11 += num4;
					num10 = (ulong)num9;
				}
				num8 = SqlDecimal.s_ulInt32Base;
				ulong num12 = 0UL;
				int i = 0;
				int num13 = num5 - ciulD;
				while (i < ciulD)
				{
					ulong num14 = (ulong)rgulD[i];
					num12 += (ulong)num9 * num14;
					num8 += (ulong)rgulR[num13] - (ulong)SqlDecimal.LO(num12);
					num12 = (ulong)SqlDecimal.HI(num12);
					rgulR[num13] = SqlDecimal.LO(num8);
					num8 = (ulong)SqlDecimal.HI(num8) + SqlDecimal.s_ulInt32Base - 1UL;
					i++;
					num13++;
				}
				num8 += (ulong)rgulR[num13] - num12;
				rgulR[num13] = SqlDecimal.LO(num8);
				rgulQ[num5 - ciulD] = num9;
				if (SqlDecimal.HI(num8) == 0U)
				{
					rgulQ[num5 - ciulD] = num9 - 1U;
					uint num15 = 0U;
					i = 0;
					num13 = num5 - ciulD;
					while (i < ciulD)
					{
						num8 = (ulong)rgulD[i] + (ulong)rgulR[num13] + (ulong)num15;
						num15 = SqlDecimal.HI(num8);
						rgulR[num13] = SqlDecimal.LO(num8);
						i++;
						num13++;
					}
					rgulR[num13] += num15;
				}
				num5--;
			}
			while (num5 >= ciulD);
			SqlDecimal.MpNormalize(rgulQ, ref ciulQ);
			ciulR = ciulD;
			SqlDecimal.MpNormalize(rgulR, ref ciulR);
			if (num6 > 1U)
			{
				uint num16;
				SqlDecimal.MpDiv1(rgulD, ref ciulD, num6, out num16);
				SqlDecimal.MpDiv1(rgulR, ref ciulR, num6, out num16);
			}
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x000A462C File Offset: 0x000A282C
		private EComparison CompareNm(SqlDecimal snumOp)
		{
			int num = this.IsPositive ? 1 : -1;
			int num2 = snumOp.IsPositive ? 1 : -1;
			if (num == num2)
			{
				SqlDecimal sqlDecimal = this;
				SqlDecimal snumOp2 = snumOp;
				int num3 = (int)(this._bScale - snumOp._bScale);
				if (num3 < 0)
				{
					try
					{
						sqlDecimal.AdjustScale(-num3, true);
						goto IL_78;
					}
					catch (OverflowException)
					{
						return (num > 0) ? EComparison.GT : EComparison.LT;
					}
				}
				if (num3 > 0)
				{
					try
					{
						snumOp2.AdjustScale(num3, true);
					}
					catch (OverflowException)
					{
						return (num > 0) ? EComparison.LT : EComparison.GT;
					}
				}
				IL_78:
				int num4 = sqlDecimal.LAbsCmp(snumOp2);
				if (num4 == 0)
				{
					return EComparison.EQ;
				}
				if (num * num4 < 0)
				{
					return EComparison.LT;
				}
				return EComparison.GT;
			}
			if (num != 1)
			{
				return EComparison.LT;
			}
			return EComparison.GT;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000A46EC File Offset: 0x000A28EC
		private static void CheckValidPrecScale(byte bPrec, byte bScale)
		{
			if (bPrec < 1 || bPrec > SqlDecimal.MaxPrecision || bScale < 0 || bScale > SqlDecimal.MaxScale || bScale > bPrec)
			{
				throw new SqlTypeException(SQLResource.InvalidPrecScaleMessage);
			}
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x000A46EC File Offset: 0x000A28EC
		private static void CheckValidPrecScale(int iPrec, int iScale)
		{
			if (iPrec < 1 || iPrec > (int)SqlDecimal.MaxPrecision || iScale < 0 || iScale > (int)SqlDecimal.MaxScale || iScale > iPrec)
			{
				throw new SqlTypeException(SQLResource.InvalidPrecScaleMessage);
			}
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023BA RID: 9146 RVA: 0x000A4715 File Offset: 0x000A2915
		public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.CompareNm(y) == EComparison.EQ);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023BB RID: 9147 RVA: 0x000A473F File Offset: 0x000A293F
		public static SqlBoolean operator !=(SqlDecimal x, SqlDecimal y)
		{
			return !(x == y);
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlDecimal" />, чтобы определить, меньше ли первая структура, чем вторая.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023BC RID: 9148 RVA: 0x000A474D File Offset: 0x000A294D
		public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.CompareNm(y) == EComparison.LT);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlDecimal" />, чтобы определить, больше ли первая структура, чем вторая.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023BD RID: 9149 RVA: 0x000A4777 File Offset: 0x000A2977
		public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.CompareNm(y) == EComparison.GT);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023BE RID: 9150 RVA: 0x000A47A4 File Offset: 0x000A29A4
		public static SqlBoolean operator <=(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = x.CompareNm(y);
			return new SqlBoolean(ecomparison == EComparison.LT || ecomparison == EComparison.EQ);
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" />, чтобы определить, равны ли они, или же первый параметр больше второго.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023BF RID: 9151 RVA: 0x000A47E4 File Offset: 0x000A29E4
		public static SqlBoolean operator >=(SqlDecimal x, SqlDecimal y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			EComparison ecomparison = x.CompareNm(y);
			return new SqlBoolean(ecomparison == EComparison.GT || ecomparison == EComparison.EQ);
		}

		/// <summary>Вычисляет сумму двух операторов <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, у которой свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> содержит сумму.</returns>
		// Token: 0x060023C0 RID: 9152 RVA: 0x000A4822 File Offset: 0x000A2A22
		public static SqlDecimal Add(SqlDecimal x, SqlDecimal y)
		{
			return x + y;
		}

		/// <summary>Вычисляет результаты вычитания второго операнда <see cref="T:System.Data.SqlTypes.SqlDecimal" /> из первого.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство Value которой содержит результаты вычитания.</returns>
		// Token: 0x060023C1 RID: 9153 RVA: 0x000A482B File Offset: 0x000A2A2B
		public static SqlDecimal Subtract(SqlDecimal x, SqlDecimal y)
		{
			return x - y;
		}

		/// <summary>Оператор умножения вычисляет произведение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой содержит результат умножения.</returns>
		// Token: 0x060023C2 RID: 9154 RVA: 0x000A4834 File Offset: 0x000A2A34
		public static SqlDecimal Multiply(SqlDecimal x, SqlDecimal y)
		{
			return x * y;
		}

		/// <summary>Оператор деления вычисляет результаты деления первого операнда <see cref="T:System.Data.SqlTypes.SqlDecimal" /> на второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой содержит результаты деления.</returns>
		// Token: 0x060023C3 RID: 9155 RVA: 0x000A483D File Offset: 0x000A2A3D
		public static SqlDecimal Divide(SqlDecimal x, SqlDecimal y)
		{
			return x / y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если хотя бы один из экземпляров имеет значение NULL, значение <see langword="SqlDecimal" /> будет равно NULL.</returns>
		// Token: 0x060023C4 RID: 9156 RVA: 0x000A4846 File Offset: 0x000A2A46
		public static SqlBoolean Equals(SqlDecimal x, SqlDecimal y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с целью определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023C5 RID: 9157 RVA: 0x000A484F File Offset: 0x000A2A4F
		public static SqlBoolean NotEquals(SqlDecimal x, SqlDecimal y)
		{
			return x != y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlDecimal" />, чтобы определить, меньше ли первая структура, чем вторая.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023C6 RID: 9158 RVA: 0x000A4858 File Offset: 0x000A2A58
		public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y)
		{
			return x < y;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlDecimal" />, чтобы определить, больше ли первая структура, чем вторая.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023C7 RID: 9159 RVA: 0x000A4861 File Offset: 0x000A2A61
		public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y)
		{
			return x > y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с целью определить, верно ли, что первый параметр меньше второго или равен ему.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023C8 RID: 9160 RVA: 0x000A486A File Offset: 0x000A2A6A
		public static SqlBoolean LessThanOrEqual(SqlDecimal x, SqlDecimal y)
		{
			return x <= y;
		}

		/// <summary>Выполняет логическое сравнение двух параметров <see cref="T:System.Data.SqlTypes.SqlDecimal" />, чтобы определить, равны ли они, или же первый параметр больше второго.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060023C9 RID: 9161 RVA: 0x000A4873 File Offset: 0x000A2A73
		public static SqlBoolean GreaterThanOrEqual(SqlDecimal x, SqlDecimal y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x060023CA RID: 9162 RVA: 0x000A487C File Offset: 0x000A2A7C
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlByte" />, <see langword="Value" /> которой равно <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />. Если значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> равняется <see langword="true" />, значение <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> будет равняться 1. В противном случае значение <see langword="Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlByte" /> будет равняться 0.</returns>
		// Token: 0x060023CB RID: 9163 RVA: 0x000A4889 File Offset: 0x000A2A89
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDouble" /> с тем же значением, что и у данного экземпляра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023CC RID: 9164 RVA: 0x000A4896 File Offset: 0x000A2A96
		public SqlDouble ToSqlDouble()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt16" /> с тем же значением, что и у данного экземпляра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023CD RID: 9165 RVA: 0x000A48A3 File Offset: 0x000A2AA3
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt32" /> с тем же значением, что и у данного экземпляра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023CE RID: 9166 RVA: 0x000A48B0 File Offset: 0x000A2AB0
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlInt64" /> с тем же значением, что и у данного экземпляра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023CF RID: 9167 RVA: 0x000A48BD File Offset: 0x000A2ABD
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlMoney" /> с тем же значением, что и у данного экземпляра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023D0 RID: 9168 RVA: 0x000A48CA File Offset: 0x000A2ACA
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlSingle" /> с тем же значением, что и у данного экземпляра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023D1 RID: 9169 RVA: 0x000A48D7 File Offset: 0x000A2AD7
		public SqlSingle ToSqlSingle()
		{
			return this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />, значение которой является строкой, представляющей значение, содержащееся в данной структуре <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023D2 RID: 9170 RVA: 0x000A48E4 File Offset: 0x000A2AE4
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000A48F1 File Offset: 0x000A2AF1
		private static char ChFromDigit(uint uiDigit)
		{
			return (char)(uiDigit + 48U);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000A48F8 File Offset: 0x000A2AF8
		private void StoreFromWorkingArray(uint[] rguiData)
		{
			this._data1 = rguiData[0];
			this._data2 = rguiData[1];
			this._data3 = rguiData[2];
			this._data4 = rguiData[3];
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000A4920 File Offset: 0x000A2B20
		private void SetToZero()
		{
			this._bLen = 1;
			this._data1 = (this._data2 = (this._data3 = (this._data4 = 0U)));
			this._bStatus = (SqlDecimal.s_bNotNull | SqlDecimal.s_bPositive);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000A4968 File Offset: 0x000A2B68
		private void MakeInteger(out bool fFraction)
		{
			int i = (int)this._bScale;
			fFraction = false;
			while (i > 0)
			{
				uint num;
				if (i >= 9)
				{
					num = this.DivByULong(SqlDecimal.s_rgulShiftBase[8]);
					i -= 9;
				}
				else
				{
					num = this.DivByULong(SqlDecimal.s_rgulShiftBase[i - 1]);
					i = 0;
				}
				if (num != 0U)
				{
					fFraction = true;
				}
			}
			this._bScale = 0;
		}

		/// <summary>Метод Abs получает абсолютное значение параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="n">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, свойство <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> которой содержит число без знака, представляющее абсолютное значение параметра <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023D7 RID: 9175 RVA: 0x000A49BE File Offset: 0x000A2BBE
		public static SqlDecimal Abs(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			n.SetPositive();
			return n;
		}

		/// <summary>Возвращает наименьшее целое число, превышающее значение указанной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> или равное ему.</summary>
		/// <param name="n">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, для которой необходимо рассчитать предельное значение.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlDecimal" />, представляющее наименьшее целое число, превышающее значение указанной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> или равное ему.</returns>
		// Token: 0x060023D8 RID: 9176 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		public static SqlDecimal Ceiling(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (n._bScale == 0)
			{
				return n;
			}
			bool flag;
			n.MakeInteger(out flag);
			if (flag && n.IsPositive)
			{
				n.AddULong(1U);
			}
			if (n.FZero())
			{
				n.SetPositive();
			}
			return n;
		}

		/// <summary>Округляет заданное число <see cref="T:System.Data.SqlTypes.SqlDecimal" /> до ближайшего меньшего целого числа.</summary>
		/// <param name="n">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, для которой необходимо рассчитать наименьшее значение.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, содержащая целую часть числа данной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023D9 RID: 9177 RVA: 0x000A4A2C File Offset: 0x000A2C2C
		public static SqlDecimal Floor(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (n._bScale == 0)
			{
				return n;
			}
			bool flag;
			n.MakeInteger(out flag);
			if (flag && !n.IsPositive)
			{
				n.AddULong(1U);
			}
			if (n.FZero())
			{
				n.SetPositive();
			}
			return n;
		}

		/// <summary>Получает значение, определяющее в структуре <see cref="T:System.Data.SqlTypes.SqlDecimal" /> знак свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" />.</summary>
		/// <param name="n">Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, в которой необходимо определить знак.</param>
		/// <returns>Число, указывающее знак структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
		// Token: 0x060023DA RID: 9178 RVA: 0x000A4A80 File Offset: 0x000A2C80
		public static SqlInt32 Sign(SqlDecimal n)
		{
			if (n.IsNull)
			{
				return SqlInt32.Null;
			}
			if (n == new SqlDecimal(0))
			{
				return SqlInt32.Zero;
			}
			if (n.IsNull)
			{
				return SqlInt32.Null;
			}
			if (!n.IsPositive)
			{
				return new SqlInt32(-1);
			}
			return new SqlInt32(1);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000A4ADC File Offset: 0x000A2CDC
		private static SqlDecimal Round(SqlDecimal n, int lPosition, bool fTruncate)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			if (lPosition >= 0)
			{
				lPosition = Math.Min((int)SqlDecimal.s_NUMERIC_MAX_PRECISION, lPosition);
				if (lPosition >= (int)n._bScale)
				{
					return n;
				}
			}
			else
			{
				lPosition = Math.Max((int)(-(int)SqlDecimal.s_NUMERIC_MAX_PRECISION), lPosition);
				if (lPosition < (int)(n._bScale - n._bPrec))
				{
					n.SetToZero();
					return n;
				}
			}
			uint num = 0U;
			int i = Math.Abs(lPosition - (int)n._bScale);
			uint num2 = 1U;
			while (i > 0)
			{
				if (i >= 9)
				{
					num = n.DivByULong(SqlDecimal.s_rgulShiftBase[8]);
					num2 = SqlDecimal.s_rgulShiftBase[8];
					i -= 9;
				}
				else
				{
					num = n.DivByULong(SqlDecimal.s_rgulShiftBase[i - 1]);
					num2 = SqlDecimal.s_rgulShiftBase[i - 1];
					i = 0;
				}
			}
			if (num2 > 1U)
			{
				num /= num2 / 10U;
			}
			if (n.FZero() && (fTruncate || num < 5U))
			{
				n.SetPositive();
				return n;
			}
			if (num >= 5U && !fTruncate)
			{
				n.AddULong(1U);
			}
			i = Math.Abs(lPosition - (int)n._bScale);
			while (i-- > 0)
			{
				n.MultByULong(SqlDecimal.s_ulBase10);
			}
			return n;
		}

		/// <summary>Получает ближайшее к заданному значению структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> число с заданной точностью.</summary>
		/// <param name="n">Округляемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="position">Количество значащих цифр дробной части числа (точность) возвращаемого значения.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, содержащая результаты операции округления.</returns>
		// Token: 0x060023DC RID: 9180 RVA: 0x000A4BEB File Offset: 0x000A2DEB
		public static SqlDecimal Round(SqlDecimal n, int position)
		{
			return SqlDecimal.Round(n, position, false);
		}

		/// <summary>Усекает значение указанной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> до требуемой позиции.</summary>
		/// <param name="n">Усекаемая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="position">Десятичный разряд, до которого усекается число.</param>
		/// <returns>Для усечения данного значения до соответствующего разряда слева от десятичной запятой следует предоставить для параметра <paramref name="position" /> отрицательное значение.</returns>
		// Token: 0x060023DD RID: 9181 RVA: 0x000A4BF5 File Offset: 0x000A2DF5
		public static SqlDecimal Truncate(SqlDecimal n, int position)
		{
			return SqlDecimal.Round(n, position, true);
		}

		/// <summary>Возводит значение заданной структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в заданную экспоненциальную степень.</summary>
		/// <param name="n">Возводимая в степень структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</param>
		/// <param name="exp">Значение типа double, указывающее степень, в которую необходимо возвести число.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, содержащая результаты.</returns>
		// Token: 0x060023DE RID: 9182 RVA: 0x000A4C00 File Offset: 0x000A2E00
		public static SqlDecimal Power(SqlDecimal n, double exp)
		{
			if (n.IsNull)
			{
				return SqlDecimal.Null;
			}
			byte precision = n.Precision;
			int scale = (int)n.Scale;
			double x = n.ToDouble();
			n = new SqlDecimal(Math.Pow(x, exp));
			n.AdjustScale(scale - (int)n.Scale, true);
			n._bPrec = SqlDecimal.MaxPrecision;
			return n;
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
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
		// Token: 0x060023DF RID: 9183 RVA: 0x000A4C60 File Offset: 0x000A2E60
		public int CompareTo(object value)
		{
			if (value is SqlDecimal)
			{
				SqlDecimal value2 = (SqlDecimal)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlDecimal));
		}

		/// <summary>Сравнивает данный экземпляр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> с предоставленным объектом <see cref="T:System.Data.SqlTypes.SqlDecimal" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlDecimal" /> для сравнения.</param>
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
		// Token: 0x060023E0 RID: 9184 RVA: 0x000A4C9C File Offset: 0x000A2E9C
		public int CompareTo(SqlDecimal value)
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

		/// <summary>Сравнивает предоставленный параметр <see cref="T:System.Object" /> со свойством <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> экземпляра  <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <param name="value">Выражение <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" /> и они равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060023E1 RID: 9185 RVA: 0x000A4CF4 File Offset: 0x000A2EF4
		public override bool Equals(object value)
		{
			if (!(value is SqlDecimal))
			{
				return false;
			}
			SqlDecimal y = (SqlDecimal)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060023E2 RID: 9186 RVA: 0x000A4D4C File Offset: 0x000A2F4C
		public override int GetHashCode()
		{
			if (this.IsNull)
			{
				return 0;
			}
			SqlDecimal sqlDecimal = this;
			int num = (int)sqlDecimal.CalculatePrecision();
			sqlDecimal.AdjustScale((int)SqlDecimal.s_NUMERIC_MAX_PRECISION - num, true);
			int bLen = (int)sqlDecimal._bLen;
			int num2 = 0;
			int[] data = sqlDecimal.Data;
			for (int i = 0; i < bLen; i++)
			{
				int num3 = num2 >> 28 & 255;
				num2 <<= 4;
				num2 = (num2 ^ data[i] ^ num3);
			}
			return num2;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Объект <see langword="XmlSchema" />.</returns>
		// Token: 0x060023E3 RID: 9187 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x060023E4 RID: 9188 RVA: 0x000A4DC0 File Offset: 0x000A2FC0
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this._bStatus = (SqlDecimal.s_bReverseNullMask & this._bStatus);
				return;
			}
			SqlDecimal sqlDecimal = SqlDecimal.Parse(reader.ReadElementString());
			this._bStatus = sqlDecimal._bStatus;
			this._bLen = sqlDecimal._bLen;
			this._bPrec = sqlDecimal._bPrec;
			this._bScale = sqlDecimal._bScale;
			this._data1 = sqlDecimal._data1;
			this._data2 = sqlDecimal._data2;
			this._data3 = sqlDecimal._data3;
			this._data4 = sqlDecimal._data4;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x060023E5 RID: 9189 RVA: 0x000A4E70 File Offset: 0x000A3070
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(this.ToString());
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x060023E6 RID: 9190 RVA: 0x000A4EA7 File Offset: 0x000A30A7
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("decimal", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x04001868 RID: 6248
		internal byte _bStatus;

		// Token: 0x04001869 RID: 6249
		internal byte _bLen;

		// Token: 0x0400186A RID: 6250
		internal byte _bPrec;

		// Token: 0x0400186B RID: 6251
		internal byte _bScale;

		// Token: 0x0400186C RID: 6252
		internal uint _data1;

		// Token: 0x0400186D RID: 6253
		internal uint _data2;

		// Token: 0x0400186E RID: 6254
		internal uint _data3;

		// Token: 0x0400186F RID: 6255
		internal uint _data4;

		// Token: 0x04001870 RID: 6256
		private static readonly byte s_NUMERIC_MAX_PRECISION = 38;

		/// <summary>Константа, представляющая наибольшее возможное значение для свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Precision" />.</summary>
		// Token: 0x04001871 RID: 6257
		public static readonly byte MaxPrecision = SqlDecimal.s_NUMERIC_MAX_PRECISION;

		/// <summary>Константа, представляющая максимальное значение для свойства <see cref="P:System.Data.SqlTypes.SqlDecimal.Scale" />.</summary>
		// Token: 0x04001872 RID: 6258
		public static readonly byte MaxScale = SqlDecimal.s_NUMERIC_MAX_PRECISION;

		// Token: 0x04001873 RID: 6259
		private static readonly byte s_bNullMask = 1;

		// Token: 0x04001874 RID: 6260
		private static readonly byte s_bIsNull = 0;

		// Token: 0x04001875 RID: 6261
		private static readonly byte s_bNotNull = 1;

		// Token: 0x04001876 RID: 6262
		private static readonly byte s_bReverseNullMask = ~SqlDecimal.s_bNullMask;

		// Token: 0x04001877 RID: 6263
		private static readonly byte s_bSignMask = 2;

		// Token: 0x04001878 RID: 6264
		private static readonly byte s_bPositive = 0;

		// Token: 0x04001879 RID: 6265
		private static readonly byte s_bNegative = 2;

		// Token: 0x0400187A RID: 6266
		private static readonly byte s_bReverseSignMask = ~SqlDecimal.s_bSignMask;

		// Token: 0x0400187B RID: 6267
		private static readonly uint s_uiZero = 0U;

		// Token: 0x0400187C RID: 6268
		private static readonly int s_cNumeMax = 4;

		// Token: 0x0400187D RID: 6269
		private static readonly long s_lInt32Base = 4294967296L;

		// Token: 0x0400187E RID: 6270
		private static readonly ulong s_ulInt32Base = 4294967296UL;

		// Token: 0x0400187F RID: 6271
		private static readonly ulong s_ulInt32BaseForMod = SqlDecimal.s_ulInt32Base - 1UL;

		// Token: 0x04001880 RID: 6272
		internal static readonly ulong s_llMax = 9223372036854775807UL;

		// Token: 0x04001881 RID: 6273
		private static readonly uint s_ulBase10 = 10U;

		// Token: 0x04001882 RID: 6274
		private static readonly double s_DUINT_BASE = (double)SqlDecimal.s_lInt32Base;

		// Token: 0x04001883 RID: 6275
		private static readonly double s_DUINT_BASE2 = SqlDecimal.s_DUINT_BASE * SqlDecimal.s_DUINT_BASE;

		// Token: 0x04001884 RID: 6276
		private static readonly double s_DUINT_BASE3 = SqlDecimal.s_DUINT_BASE2 * SqlDecimal.s_DUINT_BASE;

		// Token: 0x04001885 RID: 6277
		private static readonly double s_DMAX_NUME = 1E+38;

		// Token: 0x04001886 RID: 6278
		private static readonly uint s_DBL_DIG = 17U;

		// Token: 0x04001887 RID: 6279
		private static readonly byte s_cNumeDivScaleMin = 6;

		// Token: 0x04001888 RID: 6280
		private static readonly uint[] s_rgulShiftBase = new uint[]
		{
			10U,
			100U,
			1000U,
			10000U,
			100000U,
			1000000U,
			10000000U,
			100000000U,
			1000000000U
		};

		// Token: 0x04001889 RID: 6281
		private static readonly uint[] s_decimalHelpersLo = new uint[]
		{
			10U,
			100U,
			1000U,
			10000U,
			100000U,
			1000000U,
			10000000U,
			100000000U,
			1000000000U,
			1410065408U,
			1215752192U,
			3567587328U,
			1316134912U,
			276447232U,
			2764472320U,
			1874919424U,
			1569325056U,
			2808348672U,
			2313682944U,
			1661992960U,
			3735027712U,
			2990538752U,
			4135583744U,
			2701131776U,
			1241513984U,
			3825205248U,
			3892314112U,
			268435456U,
			2684354560U,
			1073741824U,
			2147483648U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U
		};

		// Token: 0x0400188A RID: 6282
		private static readonly uint[] s_decimalHelpersMid = new uint[]
		{
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			2U,
			23U,
			232U,
			2328U,
			23283U,
			232830U,
			2328306U,
			23283064U,
			232830643U,
			2328306436U,
			1808227885U,
			902409669U,
			434162106U,
			46653770U,
			466537709U,
			370409800U,
			3704098002U,
			2681241660U,
			1042612833U,
			1836193738U,
			1182068202U,
			3230747430U,
			2242703233U,
			952195850U,
			932023908U,
			730304488U,
			3008077584U,
			16004768U,
			160047680U
		};

		// Token: 0x0400188B RID: 6283
		private static readonly uint[] s_decimalHelpersHi = new uint[]
		{
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			5U,
			54U,
			542U,
			5421U,
			54210U,
			542101U,
			5421010U,
			54210108U,
			542101086U,
			1126043566U,
			2670501072U,
			935206946U,
			762134875U,
			3326381459U,
			3199043520U,
			1925664130U,
			2076772117U,
			3587851993U,
			1518781562U
		};

		// Token: 0x0400188C RID: 6284
		private static readonly uint[] s_decimalHelpersHiHi = new uint[]
		{
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			1U,
			12U,
			126U,
			1262U,
			12621U,
			126217U,
			1262177U,
			12621774U,
			126217744U,
			1262177448U
		};

		// Token: 0x0400188D RID: 6285
		private const int HelperTableStartIndexLo = 5;

		// Token: 0x0400188E RID: 6286
		private const int HelperTableStartIndexMid = 15;

		// Token: 0x0400188F RID: 6287
		private const int HelperTableStartIndexHi = 24;

		// Token: 0x04001890 RID: 6288
		private const int HelperTableStartIndexHiHi = 33;

		// Token: 0x04001891 RID: 6289
		private static readonly byte[] s_rgCLenFromPrec = new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			2,
			3,
			3,
			3,
			3,
			3,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4
		};

		// Token: 0x04001892 RID: 6290
		private static readonly uint s_ulT1 = 10U;

		// Token: 0x04001893 RID: 6291
		private static readonly uint s_ulT2 = 100U;

		// Token: 0x04001894 RID: 6292
		private static readonly uint s_ulT3 = 1000U;

		// Token: 0x04001895 RID: 6293
		private static readonly uint s_ulT4 = 10000U;

		// Token: 0x04001896 RID: 6294
		private static readonly uint s_ulT5 = 100000U;

		// Token: 0x04001897 RID: 6295
		private static readonly uint s_ulT6 = 1000000U;

		// Token: 0x04001898 RID: 6296
		private static readonly uint s_ulT7 = 10000000U;

		// Token: 0x04001899 RID: 6297
		private static readonly uint s_ulT8 = 100000000U;

		// Token: 0x0400189A RID: 6298
		private static readonly uint s_ulT9 = 1000000000U;

		// Token: 0x0400189B RID: 6299
		private static readonly ulong s_dwlT10 = 10000000000UL;

		// Token: 0x0400189C RID: 6300
		private static readonly ulong s_dwlT11 = 100000000000UL;

		// Token: 0x0400189D RID: 6301
		private static readonly ulong s_dwlT12 = 1000000000000UL;

		// Token: 0x0400189E RID: 6302
		private static readonly ulong s_dwlT13 = 10000000000000UL;

		// Token: 0x0400189F RID: 6303
		private static readonly ulong s_dwlT14 = 100000000000000UL;

		// Token: 0x040018A0 RID: 6304
		private static readonly ulong s_dwlT15 = 1000000000000000UL;

		// Token: 0x040018A1 RID: 6305
		private static readonly ulong s_dwlT16 = 10000000000000000UL;

		// Token: 0x040018A2 RID: 6306
		private static readonly ulong s_dwlT17 = 100000000000000000UL;

		// Token: 0x040018A3 RID: 6307
		private static readonly ulong s_dwlT18 = 1000000000000000000UL;

		// Token: 0x040018A4 RID: 6308
		private static readonly ulong s_dwlT19 = 10000000000000000000UL;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру класса <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		// Token: 0x040018A5 RID: 6309
		public static readonly SqlDecimal Null = new SqlDecimal(true);

		/// <summary>Константа, представляющая минимальное значение для структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		// Token: 0x040018A6 RID: 6310
		public static readonly SqlDecimal MinValue = SqlDecimal.Parse("-99999999999999999999999999999999999999");

		/// <summary>Константа, представляющая максимальное значение структуры <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		// Token: 0x040018A7 RID: 6311
		public static readonly SqlDecimal MaxValue = SqlDecimal.Parse("99999999999999999999999999999999999999");
	}
}
