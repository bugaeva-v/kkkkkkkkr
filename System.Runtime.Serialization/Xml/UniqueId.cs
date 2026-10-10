using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Xml
{
	/// <summary>Уникальный идентификатор, оптимизированный для GUID.</summary>
	// Token: 0x02000024 RID: 36
	public class UniqueId
	{
		/// <summary>Создает новый экземпляр этого класса с новым GUID.</summary>
		// Token: 0x060000CD RID: 205 RVA: 0x0000407E File Offset: 0x0000227E
		public UniqueId() : this(Guid.NewGuid())
		{
		}

		/// <summary>Создает новый экземпляр данного класса, используя идентификатор <see cref="T:System.Guid" />.</summary>
		/// <param name="guid">Объект <see cref="T:System.Guid" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="guid" /> — <see langword="null" />.</exception>
		// Token: 0x060000CE RID: 206 RVA: 0x0000408B File Offset: 0x0000228B
		public UniqueId(Guid guid) : this(guid.ToByteArray())
		{
		}

		/// <summary>Создает новый экземпляр этого класса, используя массив байтов, представляющий идентификатор <see cref="T:System.Guid" />.</summary>
		/// <param name="guid">Массив байтов, представляющий идентификатор <see cref="T:System.Guid" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="guid" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="guid" /> предоставляет менее 16 допустимых байтов.</exception>
		// Token: 0x060000CF RID: 207 RVA: 0x0000409A File Offset: 0x0000229A
		public UniqueId(byte[] guid) : this(guid, 0)
		{
		}

		/// <summary>Создает новый экземпляр данного класса, начиная со смещения в пределах массива <see langword="byte" />, представляющего <see cref="T:System.Guid" />.</summary>
		/// <param name="guid">Массив <see langword="byte" />, представляющий <see cref="T:System.Guid" />.</param>
		/// <param name="offset">Позиция смещения внутри массива <see langword="byte" />, представляющего <see cref="T:System.Guid" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="guid" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="offset" /> имеет значение меньше нуля или больше длины массива.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="guid" /> и <paramref name="offset" /> предоставляют менее 16 допустимых байтов.</exception>
		// Token: 0x060000D0 RID: 208 RVA: 0x000040A4 File Offset: 0x000022A4
		[SecuritySafeCritical]
		public unsafe UniqueId(byte[] guid, int offset)
		{
			if (guid == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("guid"));
			}
			if (offset < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The value of this argument must be non-negative.")));
			}
			if (offset > guid.Length)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The specified offset exceeds the buffer size ({0} bytes).", new object[]
				{
					guid.Length
				})));
			}
			if (16 > guid.Length - offset)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(System.Runtime.Serialization.SR.GetString("Array too small.  Length of available data must be at least {0}.", new object[]
				{
					16
				}), "guid"));
			}
			fixed (byte* ptr = &guid[offset])
			{
				byte* ptr2 = ptr;
				this.idLow = this.UnsafeGetInt64(ptr2);
				this.idHigh = this.UnsafeGetInt64(ptr2 + 8);
			}
		}

		/// <summary>Создает новый экземпляр данного класса, используя строку.</summary>
		/// <param name="value">Строка, используемая для создания объекта <see cref="T:System.Xml.UniqueId" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Длина параметра <paramref name="value" /> равна нулю.</exception>
		// Token: 0x060000D1 RID: 209 RVA: 0x00004178 File Offset: 0x00002378
		[SecuritySafeCritical]
		public unsafe UniqueId(string value)
		{
			if (value == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
			}
			if (value.Length == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new FormatException(System.Runtime.Serialization.SR.GetString("UniqueId cannot be zero length.")));
			}
			fixed (string text = value)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				this.UnsafeParse(ptr, value.Length);
			}
			this.s = value;
		}

		/// <summary>Создает новый экземпляр данного класса, начиная со смещения в пределах массива <see langword="char" />, используя заданное количество записей.</summary>
		/// <param name="chars">Массив <see langword="char" />, представляющий <see cref="T:System.Guid" />.</param>
		/// <param name="offset">Позиция смещения внутри массива <see langword="char" />, представляющего <see cref="T:System.Guid" />.</param>
		/// <param name="count">Количество используемых записей массива, начиная со смещения <paramref name="offset" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="offset" /> имеет значение меньше нуля или больше длины массива.
		/// -или-
		/// Параметр <paramref name="count" /> имеет значение меньше нуля или больше длины массива минус смещение <paramref name="offset" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="count" /> равен нулю.</exception>
		// Token: 0x060000D2 RID: 210 RVA: 0x000041DC File Offset: 0x000023DC
		[SecuritySafeCritical]
		public unsafe UniqueId(char[] chars, int offset, int count)
		{
			if (chars == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("chars"));
			}
			if (offset < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The value of this argument must be non-negative.")));
			}
			if (offset > chars.Length)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The specified offset exceeds the buffer size ({0} bytes).", new object[]
				{
					chars.Length
				})));
			}
			if (count < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("count", System.Runtime.Serialization.SR.GetString("The value of this argument must be non-negative.")));
			}
			if (count > chars.Length - offset)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("count", System.Runtime.Serialization.SR.GetString("The specified size exceeds the remaining buffer space ({0} bytes).", new object[]
				{
					chars.Length - offset
				})));
			}
			if (count == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new FormatException(System.Runtime.Serialization.SR.GetString("UniqueId cannot be zero length.")));
			}
			fixed (char* ptr = &chars[offset])
			{
				char* chars2 = ptr;
				this.UnsafeParse(chars2, count);
			}
			if (!this.IsGuid)
			{
				this.s = new string(chars, offset, count);
			}
		}

		/// <summary>Возвращает значение длины строкового представления <see cref="T:System.Xml.UniqueId" />.</summary>
		/// <returns>Длина строкового представления <see cref="T:System.Xml.UniqueId" />.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000042E8 File Offset: 0x000024E8
		public int CharArrayLength
		{
			[SecuritySafeCritical]
			get
			{
				if (this.s != null)
				{
					return this.s.Length;
				}
				return 45;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004300 File Offset: 0x00002500
		[SecurityCritical]
		private unsafe int UnsafeDecode(short* char2val, char ch1, char ch2)
		{
			if ((ch1 | ch2) >= '\u0080')
			{
				return 256;
			}
			return (int)(char2val[(IntPtr)ch1] | char2val[(IntPtr)('\u0080' + ch2)]);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004327 File Offset: 0x00002527
		[SecurityCritical]
		private unsafe void UnsafeEncode(char* val2char, byte b, char* pch)
		{
			*pch = val2char[b >> 4];
			pch[1] = val2char[b & 15];
		}

		/// <summary>Указывает, является ли идентификатор <see cref="T:System.Xml.UniqueId" /> объектом <see cref="T:System.Guid" />.</summary>
		/// <returns>Значение <see langword="true" />, если параметр <see cref="T:System.Xml.UniqueId" /> имеет значение <see cref="T:System.Guid" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004342 File Offset: 0x00002542
		public bool IsGuid
		{
			get
			{
				return (this.idLow | this.idHigh) != 0L;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004358 File Offset: 0x00002558
		[SecurityCritical]
		private unsafe void UnsafeParse(char* chars, int charCount)
		{
			if (charCount != 45 || *chars != 'u' || chars[1] != 'r' || chars[2] != 'n' || chars[3] != ':' || chars[4] != 'u' || chars[5] != 'u' || chars[6] != 'i' || chars[7] != 'd' || chars[8] != ':' || chars[17] != '-' || chars[22] != '-' || chars[27] != '-' || chars[32] != '-')
			{
				return;
			}
			byte* ptr = stackalloc byte[(UIntPtr)16];
			int num = 0;
			short[] array;
			short* ptr2;
			if ((array = UniqueId.char2val) == null || array.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &array[0];
			}
			short* ptr3 = ptr2;
			int num2 = this.UnsafeDecode(ptr3, chars[15], chars[16]);
			*ptr = (byte)num2;
			int num3 = num | num2;
			num2 = this.UnsafeDecode(ptr3, chars[13], chars[14]);
			ptr[1] = (byte)num2;
			int num4 = num3 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[11], chars[12]);
			ptr[2] = (byte)num2;
			int num5 = num4 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[9], chars[10]);
			ptr[3] = (byte)num2;
			int num6 = num5 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[20], chars[21]);
			ptr[4] = (byte)num2;
			int num7 = num6 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[18], chars[19]);
			ptr[5] = (byte)num2;
			int num8 = num7 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[25], chars[26]);
			ptr[6] = (byte)num2;
			int num9 = num8 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[23], chars[24]);
			ptr[7] = (byte)num2;
			int num10 = num9 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[28], chars[29]);
			ptr[8] = (byte)num2;
			int num11 = num10 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[30], chars[31]);
			ptr[9] = (byte)num2;
			int num12 = num11 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[33], chars[34]);
			ptr[10] = (byte)num2;
			int num13 = num12 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[35], chars[36]);
			ptr[11] = (byte)num2;
			int num14 = num13 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[37], chars[38]);
			ptr[12] = (byte)num2;
			int num15 = num14 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[39], chars[40]);
			ptr[13] = (byte)num2;
			int num16 = num15 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[41], chars[42]);
			ptr[14] = (byte)num2;
			int num17 = num16 | num2;
			num2 = this.UnsafeDecode(ptr3, chars[43], chars[44]);
			ptr[15] = (byte)num2;
			if ((num17 | num2) >= 256)
			{
				return;
			}
			this.idLow = this.UnsafeGetInt64(ptr);
			this.idHigh = this.UnsafeGetInt64(ptr + 8);
			array = null;
		}

		/// <summary>Помещает значение <see cref="T:System.Xml.UniqueId" /> в массив <see langword="char" />.</summary>
		/// <param name="chars">Массив <see langword="char" />.</param>
		/// <param name="offset">Позиция в массиве <see langword="char" /> для начала вставки значения <see cref="T:System.Xml.UniqueId" />.</param>
		/// <returns>Количество записей в массиве <see langword="char" />, заполненных значением <see cref="T:System.Xml.UniqueId" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="offset" /> имеет значение меньше нуля или больше длины массива.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="guid" /> и <paramref name="offset" /> предоставляют менее 16 допустимых байтов.</exception>
		// Token: 0x060000D8 RID: 216 RVA: 0x00004660 File Offset: 0x00002860
		[SecuritySafeCritical]
		public unsafe int ToCharArray(char[] chars, int offset)
		{
			int charArrayLength = this.CharArrayLength;
			if (chars == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("chars"));
			}
			if (offset < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The value of this argument must be non-negative.")));
			}
			if (offset > chars.Length)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The specified offset exceeds the buffer size ({0} bytes).", new object[]
				{
					chars.Length
				})));
			}
			if (charArrayLength > chars.Length - offset)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("chars", System.Runtime.Serialization.SR.GetString("Array too small.  Must be able to hold at least {0}.", new object[]
				{
					charArrayLength
				})));
			}
			if (this.s != null)
			{
				this.s.CopyTo(0, chars, offset, charArrayLength);
			}
			else
			{
				byte* ptr = stackalloc byte[(UIntPtr)16];
				this.UnsafeSetInt64(this.idLow, ptr);
				this.UnsafeSetInt64(this.idHigh, ptr + 8);
				fixed (char* ptr2 = &chars[offset])
				{
					char* ptr3 = ptr2;
					*ptr3 = 'u';
					ptr3[1] = 'r';
					ptr3[2] = 'n';
					ptr3[3] = ':';
					ptr3[4] = 'u';
					ptr3[5] = 'u';
					ptr3[6] = 'i';
					ptr3[7] = 'd';
					ptr3[8] = ':';
					ptr3[17] = '-';
					ptr3[22] = '-';
					ptr3[27] = '-';
					ptr3[32] = '-';
					fixed (string text = "0123456789abcdef")
					{
						char* ptr4 = text;
						if (ptr4 != null)
						{
							ptr4 += RuntimeHelpers.OffsetToStringData / 2;
						}
						char* ptr5 = ptr4;
						this.UnsafeEncode(ptr5, *ptr, ptr3 + 15);
						this.UnsafeEncode(ptr5, ptr[1], ptr3 + 13);
						this.UnsafeEncode(ptr5, ptr[2], ptr3 + 11);
						this.UnsafeEncode(ptr5, ptr[3], ptr3 + 9);
						this.UnsafeEncode(ptr5, ptr[4], ptr3 + 20);
						this.UnsafeEncode(ptr5, ptr[5], ptr3 + 18);
						this.UnsafeEncode(ptr5, ptr[6], ptr3 + 25);
						this.UnsafeEncode(ptr5, ptr[7], ptr3 + 23);
						this.UnsafeEncode(ptr5, ptr[8], ptr3 + 28);
						this.UnsafeEncode(ptr5, ptr[9], ptr3 + 30);
						this.UnsafeEncode(ptr5, ptr[10], ptr3 + 33);
						this.UnsafeEncode(ptr5, ptr[11], ptr3 + 35);
						this.UnsafeEncode(ptr5, ptr[12], ptr3 + 37);
						this.UnsafeEncode(ptr5, ptr[13], ptr3 + 39);
						this.UnsafeEncode(ptr5, ptr[14], ptr3 + 41);
						this.UnsafeEncode(ptr5, ptr[15], ptr3 + 43);
					}
				}
			}
			return charArrayLength;
		}

		/// <summary>Предпринимает попытку получения значения <see cref="T:System.Xml.UniqueId" /> в виде <see cref="T:System.Guid" />.</summary>
		/// <param name="guid">Имеет значение <see cref="T:System.Guid" /> в случае успешного выполнения; иначе — <see cref="F:System.Guid.Empty" />.</param>
		/// <returns>
		///   <see langword="true" />, если UniqueId представляет элемент <see cref="T:System.Guid" />, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="buffer" /> и <paramref name="offset" /> предоставляют менее 16 допустимых байтов.</exception>
		// Token: 0x060000D9 RID: 217 RVA: 0x0000492C File Offset: 0x00002B2C
		public bool TryGetGuid(out Guid guid)
		{
			byte[] array = new byte[16];
			if (!this.TryGetGuid(array, 0))
			{
				guid = Guid.Empty;
				return false;
			}
			guid = new Guid(array);
			return true;
		}

		/// <summary>Предпринимает попытку получения значения <see cref="T:System.Xml.UniqueId" /> в виде <see cref="T:System.Guid" /> и сохранения его в данном массиве байтов после заданного смещения.</summary>
		/// <param name="buffer">Массив <see langword="byte" />, который будет содержать объект <see cref="T:System.Guid" />.</param>
		/// <param name="offset">Позиция в массиве <see langword="byte" /> для начала вставки значения <see cref="T:System.Guid" />.</param>
		/// <returns>Значение <see langword="true" />, если значение, хранящееся в экземпляре <see cref="T:System.Xml.UniqueId" /> является <see cref="T:System.Guid" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="offset" /> имеет значение меньше нуля или больше длины массива.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="buffer" /> и <paramref name="offset" /> предоставляют менее 16 допустимых байтов.</exception>
		// Token: 0x060000DA RID: 218 RVA: 0x00004968 File Offset: 0x00002B68
		[SecuritySafeCritical]
		public unsafe bool TryGetGuid(byte[] buffer, int offset)
		{
			if (!this.IsGuid)
			{
				return false;
			}
			if (buffer == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("buffer"));
			}
			if (offset < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The value of this argument must be non-negative.")));
			}
			if (offset > buffer.Length)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("The specified offset exceeds the buffer size ({0} bytes).", new object[]
				{
					buffer.Length
				})));
			}
			if (16 > buffer.Length - offset)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("buffer", System.Runtime.Serialization.SR.GetString("Array too small.  Must be able to hold at least {0}.", new object[]
				{
					16
				})));
			}
			fixed (byte* ptr = &buffer[offset])
			{
				byte* ptr2 = ptr;
				this.UnsafeSetInt64(this.idLow, ptr2);
				this.UnsafeSetInt64(this.idHigh, ptr2 + 8);
			}
			return true;
		}

		/// <summary>Отображает значение <see cref="T:System.Xml.UniqueId" /> в строковом формате.</summary>
		/// <returns>Строковое представление значения <see cref="T:System.Xml.UniqueId" />.</returns>
		// Token: 0x060000DB RID: 219 RVA: 0x00004A40 File Offset: 0x00002C40
		[SecuritySafeCritical]
		public override string ToString()
		{
			if (this.s == null)
			{
				int charArrayLength = this.CharArrayLength;
				char[] array = new char[charArrayLength];
				this.ToCharArray(array, 0);
				this.s = new string(array, 0, charArrayLength);
			}
			return this.s;
		}

		/// <summary>Переопределяет оператор равенства для проверки равенства двух объектов <see cref="T:System.Xml.UniqueId" />.</summary>
		/// <param name="id1">Первая коллекция <see cref="T:System.Xml.UniqueId" />.</param>
		/// <param name="id2">Вторая категория <see cref="T:System.Xml.UniqueId" />.</param>
		/// <returns>Значение <see langword="true" />, если оба объекта <see cref="T:System.Xml.UniqueId" /> равны или оба имеют значение <see langword="null" />; значение <see langword="false" />, если объекты не равны или только один из них имеет значение <see langword="null" />.</returns>
		// Token: 0x060000DC RID: 220 RVA: 0x00004A80 File Offset: 0x00002C80
		public static bool operator ==(UniqueId id1, UniqueId id2)
		{
			if (id1 == null && id2 == null)
			{
				return true;
			}
			if (id1 == null || id2 == null)
			{
				return false;
			}
			if (id1.IsGuid && id2.IsGuid)
			{
				return id1.idLow == id2.idLow && id1.idHigh == id2.idHigh;
			}
			return id1.ToString() == id2.ToString();
		}

		/// <summary>Переопределяет оператор равенства для проверки неравенства двух объектов <see cref="T:System.Xml.UniqueId" />.</summary>
		/// <param name="id1">Первая коллекция <see cref="T:System.Xml.UniqueId" />.</param>
		/// <param name="id2">Вторая категория <see cref="T:System.Xml.UniqueId" />.</param>
		/// <returns>Значение <see langword="true" />, если переопределенный оператор равенства возвращает значение <see langword="false" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000DD RID: 221 RVA: 0x00004ADD File Offset: 0x00002CDD
		public static bool operator !=(UniqueId id1, UniqueId id2)
		{
			return !(id1 == id2);
		}

		/// <summary>Проверяет, равен ли объект этому идентификатору <see cref="T:System.Xml.UniqueId" />.</summary>
		/// <param name="obj">Сравниваемый объект.</param>
		/// <returns>Значение <see langword="true" />, если объект равен этому <see cref="T:System.Xml.UniqueId" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000DE RID: 222 RVA: 0x00004AE9 File Offset: 0x00002CE9
		public override bool Equals(object obj)
		{
			return this == obj as UniqueId;
		}

		/// <summary>Создает хэш-код, представляющий идентификатор <see cref="T:System.Xml.UniqueId" />.</summary>
		/// <returns>Целочисленный хэш-код, представляющий <see cref="T:System.Xml.UniqueId" />.</returns>
		// Token: 0x060000DF RID: 223 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public override int GetHashCode()
		{
			if (this.IsGuid)
			{
				long num = this.idLow ^ this.idHigh;
				return (int)(num >> 32) ^ (int)num;
			}
			return this.ToString().GetHashCode();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004B30 File Offset: 0x00002D30
		[SecurityCritical]
		private unsafe long UnsafeGetInt64(byte* pb)
		{
			int num = this.UnsafeGetInt32(pb);
			return (long)this.UnsafeGetInt32(pb + 4) << 32 | (long)((ulong)num);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004B56 File Offset: 0x00002D56
		[SecurityCritical]
		private unsafe int UnsafeGetInt32(byte* pb)
		{
			return (((int)pb[3] << 8 | (int)pb[2]) << 8 | (int)pb[1]) << 8 | (int)(*pb);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004B6F File Offset: 0x00002D6F
		[SecurityCritical]
		private unsafe void UnsafeSetInt64(long value, byte* pb)
		{
			this.UnsafeSetInt32((int)value, pb);
			this.UnsafeSetInt32((int)(value >> 32), pb + 4);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004B89 File Offset: 0x00002D89
		[SecurityCritical]
		private unsafe void UnsafeSetInt32(int value, byte* pb)
		{
			*pb = (byte)value;
			value >>= 8;
			pb[1] = (byte)value;
			value >>= 8;
			pb[2] = (byte)value;
			value >>= 8;
			pb[3] = (byte)value;
		}

		// Token: 0x04000066 RID: 102
		private long idLow;

		// Token: 0x04000067 RID: 103
		private long idHigh;

		// Token: 0x04000068 RID: 104
		[SecurityCritical]
		private string s;

		// Token: 0x04000069 RID: 105
		private const int guidLength = 16;

		// Token: 0x0400006A RID: 106
		private const int uuidLength = 45;

		// Token: 0x0400006B RID: 107
		private static short[] char2val = new short[]
		{
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			0,
			16,
			32,
			48,
			64,
			80,
			96,
			112,
			128,
			144,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			160,
			176,
			192,
			208,
			224,
			240,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
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
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			10,
			11,
			12,
			13,
			14,
			15,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256,
			256
		};

		// Token: 0x0400006C RID: 108
		private const string val2char = "0123456789abcdef";
	}
}
