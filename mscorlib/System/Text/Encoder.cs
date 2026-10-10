using System;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Конвертирует набор символов в последовательность байтов.</summary>
	// Token: 0x0200039B RID: 923
	[Serializable]
	public abstract class Encoder
	{
		/// <summary>Получает или задает объект <see cref="T:System.Text.EncoderFallback" /> для текущего объекта <see cref="T:System.Text.Encoder" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.EncoderFallback" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции задания значением является <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentException">Невозможно задать новое значение, поскольку текущий объект <see cref="T:System.Text.EncoderFallbackBuffer" /> содержит данные, которые еще не были закодированы.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000868BE File Offset: 0x00084ABE
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x000868C8 File Offset: 0x00084AC8
		public EncoderFallback Fallback
		{
			get
			{
				return this._fallback;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (this._fallbackBuffer != null && this._fallbackBuffer.Remaining > 0)
				{
					throw new ArgumentException("Cannot change fallback when buffer is not empty. Previous Convert() call left data in the fallback buffer.", "value");
				}
				this._fallback = value;
				this._fallbackBuffer = null;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Text.EncoderFallbackBuffer" />, связанный с текущим объектом <see cref="T:System.Text.Encoder" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.EncoderFallbackBuffer" />.</returns>
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x00086917 File Offset: 0x00084B17
		public EncoderFallbackBuffer FallbackBuffer
		{
			get
			{
				if (this._fallbackBuffer == null)
				{
					if (this._fallback != null)
					{
						this._fallbackBuffer = this._fallback.CreateFallbackBuffer();
					}
					else
					{
						this._fallbackBuffer = EncoderFallback.ReplacementFallback.CreateFallbackBuffer();
					}
				}
				return this._fallbackBuffer;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x00086952 File Offset: 0x00084B52
		internal bool InternalHasFallbackBuffer
		{
			get
			{
				return this._fallbackBuffer != null;
			}
		}

		/// <summary>При переопределении в производном классе возвращает кодировщик в исходное состояние.</summary>
		// Token: 0x060025EC RID: 9708 RVA: 0x00086960 File Offset: 0x00084B60
		public virtual void Reset()
		{
			char[] chars = new char[0];
			byte[] bytes = new byte[this.GetByteCount(chars, 0, 0, true)];
			this.GetBytes(chars, 0, 0, bytes, 0, true);
			if (this._fallbackBuffer != null)
			{
				this._fallbackBuffer.Reset();
			}
		}

		/// <summary>При переопределении в производном классе вычисляет количество байтов, полученных при кодировании набора символов из указанного массива символов. Параметр указывает, следует ли очистить внутреннее состояние кодировщика после расчета.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="index">Индекс первого кодируемого символа.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <param name="flush">
		///   <see langword="true" /> для имитации очистки внутреннего состояния кодировщика после расчета; в противном случае — <see langword="false" />.</param>
		/// <returns>Количество байтов, полученных при кодировании заданных символов и всех символов, расположенных во внутреннем буфере.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="chars" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060025ED RID: 9709
		public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

		/// <summary>При переопределении в производном классе вычисляет количество байтов, полученных при кодировании набора символов, начиная с заданного указателя символа. Параметр указывает, следует ли очистить внутреннее состояние кодировщика после расчета.</summary>
		/// <param name="chars">Указатель на первый кодируемый символ.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <param name="flush">
		///   <see langword="true" /> для имитации очистки внутреннего состояния кодировщика после расчета; в противном случае — <see langword="false" />.</param>
		/// <returns>Количество байтов, полученных при кодировании заданных символов и всех символов, расположенных во внутреннем буфере.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="chars" /> равно <see langword="null" /> (<see langword="Nothing" /> в Visual Basic .NET).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060025EE RID: 9710 RVA: 0x000869A4 File Offset: 0x00084BA4
		[CLSCompliant(false)]
		public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			char[] array = new char[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = chars[i];
			}
			return this.GetByteCount(array, 0, count, flush);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00086A04 File Offset: 0x00084C04
		public unsafe virtual int GetByteCount(ReadOnlySpan<char> chars, bool flush)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				return this.GetByteCount(chars2, chars.Length, flush);
			}
		}

		/// <summary>При переопределении в производном классе кодирует набор символов из заданного массива символов и все символы, расположенные во внутреннем буфере, в указанный массив байтов. Параметр указывает, следует ли очистить внутреннее состояние кодировщика после выполнения преобразования.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="charIndex">Индекс первого кодируемого символа.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Массив байтов, в который будет помещена результирующая последовательность байтов.</param>
		/// <param name="byteIndex">Индекс, с которого начинается запись результирующей последовательности байтов.</param>
		/// <param name="flush">Значение <see langword="true" /> соответствует очистке внутреннего состояния кодировщика после преобразования; в противоположном случае — значение <see langword="false" />.</param>
		/// <returns>Фактическое число байтов, записанных в <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).  
		///
		/// или - 
		/// <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charIndex" />, <paramref name="charCount" /> или <paramref name="byteIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="charIndex" /> и <paramref name="charCount" /> не указывают допустимый диапазон в <paramref name="chars" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="byteIndex" /> не является допустимым индексом в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060025F0 RID: 9712
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

		/// <summary>При переопределении в производном классе кодирует набор символов, начало которого задается указателем символов, и все байты, расположенные во внутреннем буфере, в последовательность байтов, которые сохраняются, начиная с заданного указателя байтов. Параметр указывает, следует ли очистить внутреннее состояние кодировщика после выполнения преобразования.</summary>
		/// <param name="chars">Указатель на первый кодируемый символ.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Указатель на положение, с которого начинается запись результирующей последовательности байтов.</param>
		/// <param name="byteCount">Максимальное число байтов для записи.</param>
		/// <param name="flush">Значение <see langword="true" /> соответствует очистке внутреннего состояния кодировщика после преобразования; в противоположном случае — значение <see langword="false" />.</param>
		/// <returns>Фактическое число байтов, записанных в местоположение, которое задано параметром <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).  
		///
		/// или - 
		/// <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> или <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="byteCount" /> меньше результирующего числа байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060025F1 RID: 9713 RVA: 0x00086A2C File Offset: 0x00084C2C
		[CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			char[] array = new char[charCount];
			for (int i = 0; i < charCount; i++)
			{
				array[i] = chars[i];
			}
			byte[] array2 = new byte[byteCount];
			int bytes2 = this.GetBytes(array, 0, charCount, array2, 0, flush);
			if (bytes2 < byteCount)
			{
				byteCount = bytes2;
			}
			for (int i = 0; i < byteCount; i++)
			{
				bytes[i] = array2[i];
			}
			return byteCount;
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00086AD4 File Offset: 0x00084CD4
		public unsafe virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, bool flush)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					return this.GetBytes(chars2, chars.Length, bytes2, bytes.Length, flush);
				}
			}
		}

		/// <summary>Преобразует массив символов Юникода в закодированную последовательность байтов и сохраняет результат в массиве байтов.</summary>
		/// <param name="chars">Массив символов для преобразования.</param>
		/// <param name="charIndex">Первый элемент преобразуемого массива <paramref name="chars" />.</param>
		/// <param name="charCount">Число преобразуемых элементов <paramref name="chars" />.</param>
		/// <param name="bytes">Массив, где хранятся преобразованные байты.</param>
		/// <param name="byteIndex">Первый элемент массива <paramref name="bytes" />, в котором сохраняются данные.</param>
		/// <param name="byteCount">Максимальное число элементов в <paramref name="bytes" /> для использования при преобразовании.</param>
		/// <param name="flush">Значение <see langword="true" /> указывает, что дальнейшие данные для преобразования отсутствуют. В противном случае — значение <see langword="false" />.</param>
		/// <param name="charsUsed">При возврате этот метод содержит число символов из <paramref name="chars" />, которые использовались при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="bytesUsed">При возврате этот метод содержит число байтов, созданных при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="completed">При возврате этот метод содержит значение <see langword="true" />, если все символы, заданные с помощью <paramref name="charCount" />, были преобразованы. В противном случае — значение <see langword="false" />. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> или <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="charIndex" />, <paramref name="charCount" />, <paramref name="byteIndex" /> или <paramref name="byteCount" /> меньше нуля.  
		///
		/// или - 
		/// Длина массива <paramref name="chars" /> - <paramref name="charIndex" /> меньше <paramref name="charCount" />.  
		///
		/// или - 
		/// Длина массива <paramref name="bytes" /> - <paramref name="byteIndex" /> меньше <paramref name="byteCount" />.</exception>
		/// <exception cref="T:System.ArgumentException">Выходной буфер слишком мал, чтобы содержать преобразованные входные данные. Размер выходного буфера должен быть больше или равен размеру, указанному методом <see cref="Overload:System.Text.Encoder.GetByteCount" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060025F3 RID: 9715 RVA: 0x00086B0C File Offset: 0x00084D0C
		public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			for (charsUsed = charCount; charsUsed > 0; charsUsed /= 2)
			{
				if (this.GetByteCount(chars, charIndex, charsUsed, flush) <= byteCount)
				{
					bytesUsed = this.GetBytes(chars, charIndex, charsUsed, bytes, byteIndex, flush);
					completed = (charsUsed == charCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException("Conversion buffer overflow.");
		}

		/// <summary>Преобразует буфер символов Юникода в закодированную последовательность байтов и сохраняет результат в другом буфере.</summary>
		/// <param name="chars">Адрес строки символов в кодировке UTF-16 для преобразования.</param>
		/// <param name="charCount">Число символов в подстроке <paramref name="chars" />, подлежащих преобразованию.</param>
		/// <param name="bytes">Адрес буфера для хранения преобразованных байтов.</param>
		/// <param name="byteCount">Максимальное число байтов в <paramref name="bytes" /> для использования при преобразовании.</param>
		/// <param name="flush">Значение <see langword="true" /> указывает, что дальнейшие данные для преобразования отсутствуют. В противном случае — значение <see langword="false" />.</param>
		/// <param name="charsUsed">При возврате этот метод содержит число символов из <paramref name="chars" />, которые использовались при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="bytesUsed">При возврате этот метод содержит число байтов, которые использовались при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="completed">При возврате этот метод содержит значение <see langword="true" />, если все символы, заданные с помощью <paramref name="charCount" />, были преобразованы. В противном случае — значение <see langword="false" />. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> или <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> или <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Выходной буфер слишком мал, чтобы содержать преобразованные входные данные. Размер выходного буфера должен быть больше или равен размеру, указанному методом <see cref="Overload:System.Text.Encoder.GetByteCount" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoder.Fallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060025F4 RID: 9716 RVA: 0x00086C24 File Offset: 0x00084E24
		[CLSCompliant(false)]
		public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			for (charsUsed = charCount; charsUsed > 0; charsUsed /= 2)
			{
				if (this.GetByteCount(chars, charsUsed, flush) <= byteCount)
				{
					bytesUsed = this.GetBytes(chars, charsUsed, bytes, byteCount, flush);
					completed = (charsUsed == charCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException("Conversion buffer overflow.");
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00086CE4 File Offset: 0x00084EE4
		public unsafe virtual void Convert(ReadOnlySpan<char> chars, Span<byte> bytes, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					this.Convert(chars2, chars.Length, bytes2, bytes.Length, flush, out charsUsed, out bytesUsed, out completed);
				}
			}
		}

		// Token: 0x04001DA4 RID: 7588
		internal EncoderFallback _fallback;

		// Token: 0x04001DA5 RID: 7589
		internal EncoderFallbackBuffer _fallbackBuffer;
	}
}
