using System;
using System.Text;

namespace System.Collections.Specialized
{
	/// <summary>Представляет простую структуру с объемом памяти 32 бита, в которой хранятся логические значения и двухбайтовые целые числа.</summary>
	// Token: 0x020004A3 RID: 1187
	public struct BitVector32
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Collections.Specialized.BitVector32" />, содержащий данные, представленные в целом числе.</summary>
		/// <param name="data">Целое число, представляющее данные новой структуры <see cref="T:System.Collections.Specialized.BitVector32" />.</param>
		// Token: 0x06002611 RID: 9745 RVA: 0x00085816 File Offset: 0x00083A16
		public BitVector32(int data)
		{
			this._data = (uint)data;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Collections.Specialized.BitVector32" />, содержащий данные, представленные в существующей структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <param name="value">Структура <see cref="T:System.Collections.Specialized.BitVector32" />, содержащая данные, которые требуется скопировать.</param>
		// Token: 0x06002612 RID: 9746 RVA: 0x0008581F File Offset: 0x00083A1F
		public BitVector32(BitVector32 value)
		{
			this._data = value._data;
		}

		/// <summary>Получает или задает состояние одноразрядного флага, указанного определенной маской.</summary>
		/// <param name="bit">Маска, которая указывает разряд, который требуется получить или задать.</param>
		/// <returns>Значение <see langword="true" />, если указанный одноразрядный флаг установлен в (1); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007A7 RID: 1959
		public bool this[int bit]
		{
			get
			{
				return ((ulong)this._data & (ulong)((long)bit)) == (ulong)bit;
			}
			set
			{
				if (value)
				{
					this._data |= (uint)bit;
					return;
				}
				this._data &= (uint)(~(uint)bit);
			}
		}

		/// <summary>Получает или задает значение, хранящееся в указанной структуре <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
		/// <param name="section">Структура <see cref="T:System.Collections.Specialized.BitVector32.Section" />, содержащая значение, которое требуется получить или задать.</param>
		/// <returns>Значение, хранящееся в указанной структуре <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
		// Token: 0x170007A8 RID: 1960
		public int this[BitVector32.Section section]
		{
			get
			{
				return (int)((this._data & (uint)((uint)section.Mask << (int)section.Offset)) >> (int)section.Offset);
			}
			set
			{
				value <<= (int)section.Offset;
				int num = (65535 & (int)section.Mask) << (int)section.Offset;
				this._data = ((this._data & (uint)(~(uint)num)) | (uint)(value & num));
			}
		}

		/// <summary>Получает значение структуры <see cref="T:System.Collections.Specialized.BitVector32" /> в виде целого числа.</summary>
		/// <returns>Значение структуры <see cref="T:System.Collections.Specialized.BitVector32" /> в виде целого числа.</returns>
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000858CF File Offset: 0x00083ACF
		public int Data
		{
			get
			{
				return (int)this._data;
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000858D8 File Offset: 0x00083AD8
		private static short CountBitsSet(short mask)
		{
			short num = 0;
			while ((mask & 1) != 0)
			{
				num += 1;
				mask = (short)(mask >> 1);
			}
			return num;
		}

		/// <summary>Создает первую маску в наборе масок, которую можно использовать для получения отдельных разрядов в структуре <see cref="T:System.Collections.Specialized.BitVector32" />, которая построена в виде одноразрядных флагов.</summary>
		/// <returns>Маска, которая изолирует первый одноразрядный флаг в структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x06002619 RID: 9753 RVA: 0x000858FA File Offset: 0x00083AFA
		public static int CreateMask()
		{
			return BitVector32.CreateMask(0);
		}

		/// <summary>Создает дополнительную маску, следующую за указанной маской в наборе масок, которую можно использовать для получения отдельных разрядов в структуре <see cref="T:System.Collections.Specialized.BitVector32" />, построенной в виде одноразрядных флагов.</summary>
		/// <param name="previous">Маска, которая указывает на предыдущий одноразрядный флаг.</param>
		/// <returns>Маска, которая изолирует одноразрядный флаг, следующий за тем, на который указывает параметр <paramref name="previous" /> в структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="previous" /> указывает на последний одноразрядный флаг в структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</exception>
		// Token: 0x0600261A RID: 9754 RVA: 0x00085902 File Offset: 0x00083B02
		public static int CreateMask(int previous)
		{
			if (previous == 0)
			{
				return 1;
			}
			if (previous == -2147483648)
			{
				throw new InvalidOperationException("Bit vector is full.");
			}
			return previous << 1;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00085920 File Offset: 0x00083B20
		private static short CreateMaskFromHighValue(short highValue)
		{
			short num = 16;
			while (((int)highValue & 32768) == 0)
			{
				num -= 1;
				highValue = (short)(highValue << 1);
			}
			ushort num2 = 0;
			while (num > 0)
			{
				num -= 1;
				num2 = (ushort)(num2 << 1);
				num2 |= 1;
			}
			return (short)num2;
		}

		/// <summary>Создает первую структуру <see cref="T:System.Collections.Specialized.BitVector32.Section" /> в наборе разделов, который содержит двухбайтовые целые числа.</summary>
		/// <param name="maxValue">16-битное целое число со знаком, которое определяет максимальное значение для новой структуры <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
		/// <returns>Структура <see cref="T:System.Collections.Specialized.BitVector32.Section" />, которая может содержать числа от нуля до значения параметра <paramref name="maxValue" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="maxValue" /> меньше 1.</exception>
		// Token: 0x0600261C RID: 9756 RVA: 0x0008595F File Offset: 0x00083B5F
		public static BitVector32.Section CreateSection(short maxValue)
		{
			return BitVector32.CreateSectionHelper(maxValue, 0, 0);
		}

		/// <summary>Создает новую структуру <see cref="T:System.Collections.Specialized.BitVector32.Section" />, следующую за указанной структурой <see cref="T:System.Collections.Specialized.BitVector32.Section" /> в наборе разделов, который содержит двухбайтовые целые числа.</summary>
		/// <param name="maxValue">16-битное целое число со знаком, которое определяет максимальное значение для новой структуры <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
		/// <param name="previous">Предыдущая структура <see cref="T:System.Collections.Specialized.BitVector32.Section" /> в структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</param>
		/// <returns>Структура <see cref="T:System.Collections.Specialized.BitVector32.Section" />, которая может содержать числа от нуля до значения параметра <paramref name="maxValue" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="maxValue" /> меньше 1.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="previous" /> содержит последний разряд структуры <see cref="T:System.Collections.Specialized.BitVector32" />.  
		/// -или- 
		///  Значение параметра <paramref name="maxValue" /> больше, чем самое большое значение, которое может быть представлено количеством разрядов после параметра <paramref name="previous" />.</exception>
		// Token: 0x0600261D RID: 9757 RVA: 0x00085969 File Offset: 0x00083B69
		public static BitVector32.Section CreateSection(short maxValue, BitVector32.Section previous)
		{
			return BitVector32.CreateSectionHelper(maxValue, previous.Mask, previous.Offset);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00085980 File Offset: 0x00083B80
		private static BitVector32.Section CreateSectionHelper(short maxValue, short priorMask, short priorOffset)
		{
			if (maxValue < 1)
			{
				throw new ArgumentException(SR.Format("Argument {0} should be larger than {1}.", "maxValue", 1), "maxValue");
			}
			short num = priorOffset + BitVector32.CountBitsSet(priorMask);
			if (num >= 32)
			{
				throw new InvalidOperationException("Bit vector is full.");
			}
			return new BitVector32.Section(BitVector32.CreateMaskFromHighValue(maxValue), num);
		}

		/// <summary>Определяет, равен ли указанный объект структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Collections.Specialized.BitVector32" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект равен объекту <see cref="T:System.Collections.Specialized.BitVector32" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600261F RID: 9759 RVA: 0x000859D7 File Offset: 0x00083BD7
		public override bool Equals(object o)
		{
			return o is BitVector32 && this._data == ((BitVector32)o)._data;
		}

		/// <summary>Играет роль хэш-функции для структуры <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>Хэш-код для <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x06002620 RID: 9760 RVA: 0x000859F6 File Offset: 0x00083BF6
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает строку, представляющую указанный объект <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <param name="value">Представляемый объект <see cref="T:System.Collections.Specialized.BitVector32" />.</param>
		/// <returns>Строка, представляющая указанную структуру <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x06002621 RID: 9761 RVA: 0x00085A08 File Offset: 0x00083C08
		public static string ToString(BitVector32 value)
		{
			StringBuilder stringBuilder = new StringBuilder(45);
			stringBuilder.Append("BitVector32{");
			int num = (int)value._data;
			for (int i = 0; i < 32; i++)
			{
				if (((long)num & (long)((ulong)-2147483648)) != 0L)
				{
					stringBuilder.Append('1');
				}
				else
				{
					stringBuilder.Append('0');
				}
				num <<= 1;
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>Строка, представляющая текущий <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x06002622 RID: 9762 RVA: 0x00085A6F File Offset: 0x00083C6F
		public override string ToString()
		{
			return BitVector32.ToString(this);
		}

		// Token: 0x040014E1 RID: 5345
		private uint _data;

		/// <summary>Представляет раздел вектора, который может содержать целое число.</summary>
		// Token: 0x020004A4 RID: 1188
		public readonly struct Section
		{
			// Token: 0x06002623 RID: 9763 RVA: 0x00085A7C File Offset: 0x00083C7C
			internal Section(short mask, short offset)
			{
				this._mask = mask;
				this._offset = offset;
			}

			/// <summary>Получает маску, которая изолирует этот раздел в структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
			/// <returns>Маска, которая изолирует этот раздел в структуре <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06002624 RID: 9764 RVA: 0x00085A8C File Offset: 0x00083C8C
			public short Mask
			{
				get
				{
					return this._mask;
				}
			}

			/// <summary>Получает смещение этого раздела от начала структуры <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
			/// <returns>Смещение этого раздела от начала структуры <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06002625 RID: 9765 RVA: 0x00085A94 File Offset: 0x00083C94
			public short Offset
			{
				get
				{
					return this._offset;
				}
			}

			/// <summary>Определяет, является ли указанный объект тем же самым, что и текущий объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <param name="o">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <returns>Значение <see langword="true" />, если указанный объект является тем же, что и текущий объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />; в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x06002626 RID: 9766 RVA: 0x00085A9C File Offset: 0x00083C9C
			public override bool Equals(object o)
			{
				return o is BitVector32.Section && this.Equals((BitVector32.Section)o);
			}

			/// <summary>Определяет, является ли указанный объект <see cref="T:System.Collections.Specialized.BitVector32.Section" /> тем же самым, что и текущий объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <param name="obj">Объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />, сравниваемый с текущим объектом <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> совпадает с текущим объектом <see cref="T:System.Collections.Specialized.BitVector32.Section" />; в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x06002627 RID: 9767 RVA: 0x00085AB4 File Offset: 0x00083CB4
			public bool Equals(BitVector32.Section obj)
			{
				return obj._mask == this._mask && obj._offset == this._offset;
			}

			/// <summary>Определение равенства двух заданных объектов <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <param name="a">Объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <param name="b">Объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <returns>Значение <see langword="true" />, если параметры <paramref name="a" /> и <paramref name="b" /> представляют один и тот же объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />, в противном случае — <see langword="false" />.</returns>
			// Token: 0x06002628 RID: 9768 RVA: 0x00085AD4 File Offset: 0x00083CD4
			public static bool operator ==(BitVector32.Section a, BitVector32.Section b)
			{
				return a.Equals(b);
			}

			/// <summary>Определяет, имеют ли два объекта <see cref="T:System.Collections.Specialized.BitVector32.Section" /> различные значения.</summary>
			/// <param name="a">Объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <param name="b">Объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <returns>Значение <see langword="true" />, если параметры <paramref name="a" /> и <paramref name="b" /> представляют различные объекты <see cref="T:System.Collections.Specialized.BitVector32.Section" />, в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x06002629 RID: 9769 RVA: 0x00085ADE File Offset: 0x00083CDE
			public static bool operator !=(BitVector32.Section a, BitVector32.Section b)
			{
				return !(a == b);
			}

			/// <summary>Служит хэш-функцией текущего класса <see cref="T:System.Collections.Specialized.BitVector32.Section" /> для использования в алгоритмах и структурах данных хеширования, например в хэш-таблице.</summary>
			/// <returns>Хэш-код для текущего объекта <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
			// Token: 0x0600262A RID: 9770 RVA: 0x00085AEA File Offset: 0x00083CEA
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			/// <summary>Возвращает строку, представляющую указанный объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <param name="value">Представляемый объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			/// <returns>Строка, представляющая указанный объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
			// Token: 0x0600262B RID: 9771 RVA: 0x00085AFC File Offset: 0x00083CFC
			public static string ToString(BitVector32.Section value)
			{
				return string.Concat(new string[]
				{
					"Section{0x",
					Convert.ToString(value.Mask, 16),
					", 0x",
					Convert.ToString(value.Offset, 16),
					"}"
				});
			}

			/// <summary>Возвращает строку, которая представляет текущий объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <returns>Строка, представляющая текущий объект <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
			// Token: 0x0600262C RID: 9772 RVA: 0x00085B4E File Offset: 0x00083D4E
			public override string ToString()
			{
				return BitVector32.Section.ToString(this);
			}

			// Token: 0x040014E2 RID: 5346
			private readonly short _mask;

			// Token: 0x040014E3 RID: 5347
			private readonly short _offset;
		}
	}
}
