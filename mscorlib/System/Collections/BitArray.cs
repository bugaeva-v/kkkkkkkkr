using System;
using System.Threading;

namespace System.Collections
{
	/// <summary>Управляет компактным массивом двоичных значений, представленных логическими значениями, где значение <see langword="true" /> соответствует включенному биту (1), а значение <see langword="false" /> соответствует отключенному биту (0).</summary>
	// Token: 0x02000A36 RID: 2614
	[Serializable]
	public sealed class BitArray : ICollection, IEnumerable, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.BitArray" />, который может содержать указанное количество битов с первоначально заданным значением <see langword="false" />.</summary>
		/// <param name="length">Число битовых значений в новом массиве <see cref="T:System.Collections.BitArray" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.</exception>
		// Token: 0x06005CDA RID: 23770 RVA: 0x00138133 File Offset: 0x00136333
		public BitArray(int length) : this(length, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.BitArray" />, который может содержать указанное количество двоичных значений, для которых установлены заданные начальные значения.</summary>
		/// <param name="length">Число битовых значений в новом массиве <see cref="T:System.Collections.BitArray" />.</param>
		/// <param name="defaultValue">Логическое значение, присваиваемое каждому биту.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.</exception>
		// Token: 0x06005CDB RID: 23771 RVA: 0x00138140 File Offset: 0x00136340
		public BitArray(int length, bool defaultValue)
		{
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", length, "Non-negative number required.");
			}
			this.m_array = new int[BitArray.GetArrayLength(length, 32)];
			this.m_length = length;
			int num = defaultValue ? -1 : 0;
			for (int i = 0; i < this.m_array.Length; i++)
			{
				this.m_array[i] = num;
			}
			this._version = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.BitArray" />, который содержит двоичные значения, скопированные из заданного массива байтов.</summary>
		/// <param name="bytes">Массив байтов, содержащий копируемые значения, где каждый байт представляет собой восемь последовательных битов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="bytes" /> больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06005CDC RID: 23772 RVA: 0x001381B4 File Offset: 0x001363B4
		public BitArray(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (bytes.Length > 268435455)
			{
				throw new ArgumentException(SR.Format("The input array length must not exceed Int32.MaxValue / {0}. Otherwise BitArray.Length would exceed Int32.MaxValue.", 8), "bytes");
			}
			this.m_array = new int[BitArray.GetArrayLength(bytes.Length, 4)];
			this.m_length = bytes.Length * 8;
			int num = 0;
			int num2 = 0;
			while (bytes.Length - num2 >= 4)
			{
				this.m_array[num++] = ((int)(bytes[num2] & byte.MaxValue) | (int)(bytes[num2 + 1] & byte.MaxValue) << 8 | (int)(bytes[num2 + 2] & byte.MaxValue) << 16 | (int)(bytes[num2 + 3] & byte.MaxValue) << 24);
				num2 += 4;
			}
			switch (bytes.Length - num2)
			{
			case 1:
				goto IL_FA;
			case 2:
				break;
			case 3:
				this.m_array[num] = (int)(bytes[num2 + 2] & byte.MaxValue) << 16;
				break;
			default:
				goto IL_113;
			}
			this.m_array[num] |= (int)(bytes[num2 + 1] & byte.MaxValue) << 8;
			IL_FA:
			this.m_array[num] |= (int)(bytes[num2] & byte.MaxValue);
			IL_113:
			this._version = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.BitArray" />, который содержит двоичные значения, скопированные из заданного массива логических значений.</summary>
		/// <param name="values">Массив логических значений, который нужно скопировать.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		// Token: 0x06005CDD RID: 23773 RVA: 0x001382DC File Offset: 0x001364DC
		public BitArray(bool[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.m_array = new int[BitArray.GetArrayLength(values.Length, 32)];
			this.m_length = values.Length;
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i])
				{
					this.m_array[i / 32] |= 1 << i % 32;
				}
			}
			this._version = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.BitArray" />, который содержит двоичные значения, скопированные из указанного массива 32-битных целых чисел.</summary>
		/// <param name="values">Массив целых чисел, содержащий копируемые значения, где каждое целое число представлено 32 последовательными битами.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="values" /> больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06005CDE RID: 23774 RVA: 0x00138354 File Offset: 0x00136554
		public BitArray(int[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length > 67108863)
			{
				throw new ArgumentException(SR.Format("The input array length must not exceed Int32.MaxValue / {0}. Otherwise BitArray.Length would exceed Int32.MaxValue.", 32), "values");
			}
			this.m_array = new int[values.Length];
			Array.Copy(values, 0, this.m_array, 0, values.Length);
			this.m_length = values.Length * 32;
			this._version = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.BitArray" />, содержащий двоичные значения, скопированные из указанного массива <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="bits">Копируемый <see cref="T:System.Collections.BitArray" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bits" /> — <see langword="null" />.</exception>
		// Token: 0x06005CDF RID: 23775 RVA: 0x001383D0 File Offset: 0x001365D0
		public BitArray(BitArray bits)
		{
			if (bits == null)
			{
				throw new ArgumentNullException("bits");
			}
			int arrayLength = BitArray.GetArrayLength(bits.m_length, 32);
			this.m_array = new int[arrayLength];
			Array.Copy(bits.m_array, 0, this.m_array, 0, arrayLength);
			this.m_length = bits.m_length;
			this._version = bits._version;
		}

		/// <summary>Возвращает или задает значение в указанной позиции в массиве <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс возвращаемого или задаваемого значения.</param>
		/// <returns>Значение бита в позиции <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.BitArray.Count" />.</exception>
		// Token: 0x1700102C RID: 4140
		public bool this[int index]
		{
			get
			{
				return this.Get(index);
			}
			set
			{
				this.Set(index, value);
			}
		}

		/// <summary>Возвращает значение бита в указанной позиции в массиве <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс значения, которое нужно получить.</param>
		/// <returns>Значение бита в позиции <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Индекс <paramref name="index" /> больше или равен количеству элементов в массиве <see cref="T:System.Collections.BitArray" />.</exception>
		// Token: 0x06005CE2 RID: 23778 RVA: 0x0013844A File Offset: 0x0013664A
		public bool Get(int index)
		{
			if (index < 0 || index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return (this.m_array[index / 32] & 1 << index % 32) != 0;
		}

		/// <summary>Устанавливает заданное значение бита в указанной позиции в массиве <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс задаваемого бита.</param>
		/// <param name="value">Логическое значение, которое требуется присвоить биту.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Индекс <paramref name="index" /> больше или равен количеству элементов в массиве <see cref="T:System.Collections.BitArray" />.</exception>
		// Token: 0x06005CE3 RID: 23779 RVA: 0x00138488 File Offset: 0x00136688
		public void Set(int index, bool value)
		{
			if (index < 0 || index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (value)
			{
				this.m_array[index / 32] |= 1 << index % 32;
			}
			else
			{
				this.m_array[index / 32] &= ~(1 << index % 32);
			}
			this._version++;
		}

		/// <summary>Присваивает указанное значение всем битам в массиве <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="value">Логическое значение, которое требуется присвоить всем битам.</param>
		// Token: 0x06005CE4 RID: 23780 RVA: 0x00138504 File Offset: 0x00136704
		public void SetAll(bool value)
		{
			int num = value ? -1 : 0;
			int arrayLength = BitArray.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] = num;
			}
			this._version++;
		}

		/// <summary>Выполняет битовую операцию И между элементами текущего объекта <see cref="T:System.Collections.BitArray" /> с соответствующими элементами указанного массива. Текущий <see cref="T:System.Collections.BitArray" /> объект будет изменен для хранения результата битовой операции И.</summary>
		/// <param name="value">Массив, в котором выполняется битовая операция И.</param>
		/// <returns>Массив, содержащий результат битовой операции И, который представляет собой ссылку на текущий объект <see cref="T:System.Collections.BitArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в <paramref name="value" /> и текущем <see cref="T:System.Collections.BitArray" /> не совпадает.</exception>
		// Token: 0x06005CE5 RID: 23781 RVA: 0x0013854C File Offset: 0x0013674C
		public BitArray And(BitArray value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.Length != value.Length)
			{
				throw new ArgumentException("Array lengths must be the same.");
			}
			int arrayLength = BitArray.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] &= value.m_array[i];
			}
			this._version++;
			return this;
		}

		/// <summary>Выполняет побитовую операцию ИЛИ для элементов текущего объекта <see cref="T:System.Collections.BitArray" /> и соответствующих элементов указанного массива. В текущем объекте <see cref="T:System.Collections.BitArray" /> будет сохранен результат побитовой операции ИЛИ.</summary>
		/// <param name="value">Массив, в котором выполняется битовая операция ИЛИ.</param>
		/// <returns>Массив, содержащий результат побитовой операции ИЛИ, который представляет собой ссылку на текущий объект <see cref="T:System.Collections.BitArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в <paramref name="value" /> и текущем <see cref="T:System.Collections.BitArray" /> не совпадает.</exception>
		// Token: 0x06005CE6 RID: 23782 RVA: 0x001385C4 File Offset: 0x001367C4
		public BitArray Or(BitArray value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.Length != value.Length)
			{
				throw new ArgumentException("Array lengths must be the same.");
			}
			int arrayLength = BitArray.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] |= value.m_array[i];
			}
			this._version++;
			return this;
		}

		/// <summary>Выполняет побитовую операцию исключающего ИЛИ применительно к элементам текущего объекта <see cref="T:System.Collections.BitArray" /> и соответствующим элементам указанного массива. В текущем <see cref="T:System.Collections.BitArray" /> объекте будет сохранен результат побитовой операции исключающего ИЛИ.</summary>
		/// <param name="value">Массив, с которым производится битовая операция исключающего ИЛИ.</param>
		/// <returns>Массив, содержащий результат побитовой операции исключающего ИЛИ, который представляет собой ссылку на текущий объект <see cref="T:System.Collections.BitArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в <paramref name="value" /> и текущем <see cref="T:System.Collections.BitArray" /> не совпадает.</exception>
		// Token: 0x06005CE7 RID: 23783 RVA: 0x0013863C File Offset: 0x0013683C
		public BitArray Xor(BitArray value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.Length != value.Length)
			{
				throw new ArgumentException("Array lengths must be the same.");
			}
			int arrayLength = BitArray.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] ^= value.m_array[i];
			}
			this._version++;
			return this;
		}

		/// <summary>Обращает все двоичные значения в текущем массиве <see cref="T:System.Collections.BitArray" /> таким образом, чтобы каждому элементу со значением <see langword="true" /> было присвоено значение <see langword="false" />, а каждому элементу со значением <see langword="false" /> было присвоено значение <see langword="true" />.</summary>
		/// <returns>Текущие экземпляры с обращенными двоичными значениями.</returns>
		// Token: 0x06005CE8 RID: 23784 RVA: 0x001386B4 File Offset: 0x001368B4
		public BitArray Not()
		{
			int arrayLength = BitArray.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] = ~this.m_array[i];
			}
			this._version++;
			return this;
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x001386FC File Offset: 0x001368FC
		public BitArray RightShift(int count)
		{
			if (count > 0)
			{
				int num = 0;
				int arrayLength = BitArray.GetArrayLength(this.m_length, 32);
				if (count < this.m_length)
				{
					int i = count / 32;
					int num2 = count - i * 32;
					if (num2 == 0)
					{
						uint num3 = uint.MaxValue >> 32 - this.m_length % 32;
						this.m_array[arrayLength - 1] &= (int)num3;
						Array.Copy(this.m_array, i, this.m_array, 0, arrayLength - i);
						num = arrayLength - i;
					}
					else
					{
						int num4 = arrayLength - 1;
						while (i < num4)
						{
							uint num5 = (uint)this.m_array[i] >> num2;
							int num6 = this.m_array[++i] << (32 - num2 & 31);
							this.m_array[num++] = (num6 | (int)num5);
						}
						uint num7 = uint.MaxValue >> 32 - this.m_length % 32;
						num7 &= (uint)this.m_array[i];
						this.m_array[num++] = (int)(num7 >> num2);
					}
				}
				Array.Clear(this.m_array, num, arrayLength - num);
				this._version++;
				return this;
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", count, "Non-negative number required.");
			}
			this._version++;
			return this;
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x00138838 File Offset: 0x00136A38
		public BitArray LeftShift(int count)
		{
			if (count > 0)
			{
				int num2;
				if (count < this.m_length)
				{
					int num = (this.m_length - 1) / 32;
					num2 = count / 32;
					int num3 = count - num2 * 32;
					if (num3 == 0)
					{
						Array.Copy(this.m_array, 0, this.m_array, num2, num + 1 - num2);
					}
					else
					{
						int i = num - num2;
						while (i > 0)
						{
							int num4 = this.m_array[i] << num3;
							uint num5 = (uint)this.m_array[--i] >> (32 - num3 & 31);
							this.m_array[num] = (num4 | (int)num5);
							num--;
						}
						this.m_array[num] = this.m_array[i] << num3;
					}
				}
				else
				{
					num2 = BitArray.GetArrayLength(this.m_length, 32);
				}
				Array.Clear(this.m_array, 0, num2);
				this._version++;
				return this;
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", count, "Non-negative number required.");
			}
			this._version++;
			return this;
		}

		/// <summary>Получает или задает число элементов в массиве <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>Число элементов в массиве <see cref="T:System.Collections.BitArray" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойству присвоено значение меньше нуля.</exception>
		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x00138935 File Offset: 0x00136B35
		// (set) Token: 0x06005CEC RID: 23788 RVA: 0x00138940 File Offset: 0x00136B40
		public int Length
		{
			get
			{
				return this.m_length;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value", value, "Non-negative number required.");
				}
				int arrayLength = BitArray.GetArrayLength(value, 32);
				if (arrayLength > this.m_array.Length || arrayLength + 256 < this.m_array.Length)
				{
					Array.Resize<int>(ref this.m_array, arrayLength);
				}
				if (value > this.m_length)
				{
					int num = BitArray.GetArrayLength(this.m_length, 32) - 1;
					int num2 = this.m_length % 32;
					if (num2 > 0)
					{
						this.m_array[num] &= (1 << num2) - 1;
					}
					Array.Clear(this.m_array, num + 1, arrayLength - num - 1);
				}
				this.m_length = value;
				this._version++;
			}
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.BitArray" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.BitArray" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов в исходной коллекции <see cref="T:System.Collections.BitArray" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.BitArray" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005CED RID: 23789 RVA: 0x00138A00 File Offset: 0x00136C00
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			int[] array2 = array as int[];
			if (array2 != null)
			{
				int num = BitArray.GetArrayLength(this.m_length, 32) - 1;
				int num2 = this.m_length % 32;
				if (num2 == 0)
				{
					Array.Copy(this.m_array, 0, array2, index, BitArray.GetArrayLength(this.m_length, 32));
					return;
				}
				Array.Copy(this.m_array, 0, array2, index, BitArray.GetArrayLength(this.m_length, 32) - 1);
				array2[index + num] = (this.m_array[num] & (1 << num2) - 1);
				return;
			}
			else if (array is byte[])
			{
				int num3 = this.m_length % 8;
				int num4 = BitArray.GetArrayLength(this.m_length, 8);
				if (array.Length - index < num4)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (num3 > 0)
				{
					num4--;
				}
				byte[] array3 = (byte[])array;
				for (int i = 0; i < num4; i++)
				{
					array3[index + i] = (byte)(this.m_array[i / 4] >> i % 4 * 8 & 255);
				}
				if (num3 > 0)
				{
					int num5 = num4;
					array3[index + num5] = (byte)(this.m_array[num5 / 4] >> num5 % 4 * 8 & (1 << num3) - 1);
					return;
				}
				return;
			}
			else
			{
				if (!(array is bool[]))
				{
					throw new ArgumentException("Only supported array types for CopyTo on BitArrays are Boolean[], Int32[] and Byte[].", "array");
				}
				if (array.Length - index < this.m_length)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				bool[] array4 = (bool[])array;
				for (int j = 0; j < this.m_length; j++)
				{
					array4[index + j] = ((this.m_array[j / 32] >> j % 32 & 1) != 0);
				}
				return;
			}
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x00138935 File Offset: 0x00136B35
		public int Count
		{
			get
			{
				return this.m_length;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x00138BE8 File Offset: 0x00136DE8
		public object SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.BitArray" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Данное свойство всегда имеет значение <see langword="false" />.</returns>
		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.BitArray" /> доступным только для чтения.</summary>
		/// <returns>Данное свойство всегда имеет значение <see langword="false" />.</returns>
		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Создает неполную копию <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>Неполная копия <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x06005CF2 RID: 23794 RVA: 0x00138C0A File Offset: 0x00136E0A
		public object Clone()
		{
			return new BitArray(this);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IEnumerator" /> для всей коллекции <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x06005CF3 RID: 23795 RVA: 0x00138C12 File Offset: 0x00136E12
		public IEnumerator GetEnumerator()
		{
			return new BitArray.BitArrayEnumeratorSimple(this);
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00138C1A File Offset: 0x00136E1A
		private static int GetArrayLength(int n, int div)
		{
			if (n <= 0)
			{
				return 0;
			}
			return (n - 1) / div + 1;
		}

		// Token: 0x040038C2 RID: 14530
		private int[] m_array;

		// Token: 0x040038C3 RID: 14531
		private int m_length;

		// Token: 0x040038C4 RID: 14532
		private int _version;

		// Token: 0x040038C5 RID: 14533
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x040038C6 RID: 14534
		private const int _ShrinkThreshold = 256;

		// Token: 0x040038C7 RID: 14535
		private const int BitsPerInt32 = 32;

		// Token: 0x040038C8 RID: 14536
		private const int BytesPerInt32 = 4;

		// Token: 0x040038C9 RID: 14537
		private const int BitsPerByte = 8;

		// Token: 0x02000A37 RID: 2615
		[Serializable]
		private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
		{
			// Token: 0x06005CF5 RID: 23797 RVA: 0x00138C29 File Offset: 0x00136E29
			internal BitArrayEnumeratorSimple(BitArray bitarray)
			{
				this.bitarray = bitarray;
				this.index = -1;
				this.version = bitarray._version;
			}

			// Token: 0x06005CF6 RID: 23798 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06005CF7 RID: 23799 RVA: 0x00138C4C File Offset: 0x00136E4C
			public virtual bool MoveNext()
			{
				ICollection collection = this.bitarray;
				if (this.version != this.bitarray._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this.index < collection.Count - 1)
				{
					this.index++;
					this.currentElement = this.bitarray.Get(this.index);
					return true;
				}
				this.index = collection.Count;
				return false;
			}

			// Token: 0x17001032 RID: 4146
			// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x00138CC2 File Offset: 0x00136EC2
			public virtual object Current
			{
				get
				{
					if (this.index == -1)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					if (this.index >= ((ICollection)this.bitarray).Count)
					{
						throw new InvalidOperationException("Enumeration already finished.");
					}
					return this.currentElement;
				}
			}

			// Token: 0x06005CF9 RID: 23801 RVA: 0x00138D01 File Offset: 0x00136F01
			public void Reset()
			{
				if (this.version != this.bitarray._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this.index = -1;
			}

			// Token: 0x040038CA RID: 14538
			private BitArray bitarray;

			// Token: 0x040038CB RID: 14539
			private int index;

			// Token: 0x040038CC RID: 14540
			private int version;

			// Token: 0x040038CD RID: 14541
			private bool currentElement;
		}
	}
}
