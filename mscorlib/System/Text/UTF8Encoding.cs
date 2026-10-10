using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Представляет кодировку символов Юникода в формате UTF-8.</summary>
	// Token: 0x020003B4 RID: 948
	[Serializable]
	public class UTF8Encoding : Encoding
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF8Encoding" />.</summary>
		// Token: 0x06002734 RID: 10036 RVA: 0x0008C6CD File Offset: 0x0008A8CD
		public UTF8Encoding() : this(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF8Encoding" />. Параметр указывает, нужно ли предоставлять метку порядка байтов Юникода.</summary>
		/// <param name="encoderShouldEmitUTF8Identifier">Значение <see langword="true" /> указывает, что метод <see cref="M:System.Text.UTF8Encoding.GetPreamble" /> возвращает метку порядка байтов Юникода; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002735 RID: 10037 RVA: 0x0008C6D6 File Offset: 0x0008A8D6
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) : this(encoderShouldEmitUTF8Identifier, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF8Encoding" />. Параметры указывают, должна ли предоставляться метка порядка байтов Юникода и следует ли создавать исключение при обнаружении недопустимой кодировки.</summary>
		/// <param name="encoderShouldEmitUTF8Identifier">Значение <see langword="true" /> указывает, что метод <see cref="M:System.Text.UTF8Encoding.GetPreamble" /> должен возвращать метку порядка байтов Юникода; в противном случае — значение <see langword="false" />.</param>
		/// <param name="throwOnInvalidBytes">Значение <see langword="true" /> указывает, что следует создавать исключение при обнаружении недопустимой кодировки; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002736 RID: 10038 RVA: 0x0008C6E0 File Offset: 0x0008A8E0
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) : base(65001)
		{
			this._emitUTF8Identifier = encoderShouldEmitUTF8Identifier;
			this._isThrowException = throwOnInvalidBytes;
			if (this._isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0008C70C File Offset: 0x0008A90C
		internal override void SetDefaultFallbacks()
		{
			if (this._isThrowException)
			{
				this.encoderFallback = EncoderFallback.ExceptionFallback;
				this.decoderFallback = DecoderFallback.ExceptionFallback;
				return;
			}
			this.encoderFallback = new EncoderReplacementFallback("�");
			this.decoderFallback = new DecoderReplacementFallback("�");
		}

		/// <summary>Вычисляет число байтов, полученных при кодировании набора символов из указанного массива символов.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="index">Индекс первого кодируемого символа.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="chars" />.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="chars" /> содержит недопустимую последовательность символов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Свойству <see cref="P:System.Text.Encoding.EncoderFallback" /> задано значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002738 RID: 10040 RVA: 0x0008C758 File Offset: 0x0008A958
		public unsafe override int GetByteCount(char[] chars, int index, int count)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (chars.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (count == 0)
			{
				return 0;
			}
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			return this.GetByteCount(ptr + index, count, null);
		}

		/// <summary>Вычисляет количество байтов, полученных при кодировании символов в заданном объекте <see cref="T:System.String" />.</summary>
		/// <param name="chars">Объект <see cref="T:System.String" />, содержащий кодируемый набор символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="chars" /> содержит недопустимую последовательность символов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002739 RID: 10041 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		public unsafe override int GetByteCount(string chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("s");
			}
			char* ptr = chars;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return this.GetByteCount(ptr, chars.Length, null);
		}

		/// <summary>Вычисляет число байтов, полученных при кодировании набора символов начиная с заданного указателя символа.</summary>
		/// <param name="chars">Указатель на первый кодируемый символ.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="chars" /> содержит недопустимую последовательность символов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600273A RID: 10042 RVA: 0x00084C95 File Offset: 0x00082E95
		[CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			return this.GetByteCount(chars, count, null);
		}

		/// <summary>Кодирует набор символов из заданного объекта <see cref="T:System.String" /> в указанный массив байтов.</summary>
		/// <param name="s">Объект <see cref="T:System.String" />, содержащий кодируемый набор символов.</param>
		/// <param name="charIndex">Индекс первого кодируемого символа.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Массив байтов, в который будет помещена результирующая последовательность байтов.</param>
		/// <param name="byteIndex">Индекс, с которого начинается запись результирующей последовательности байтов.</param>
		/// <returns>Фактическое число байтов, записанных в <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charIndex" />, <paramref name="charCount" /> или <paramref name="byteIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="charIndex" /> и <paramref name="charCount" /> не указывают допустимый диапазон в <paramref name="chars" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="byteIndex" /> не является допустимым индексом в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="s" /> содержит недопустимую последовательность символов.  
		///
		/// или - 
		/// Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600273B RID: 10043 RVA: 0x0008C81C File Offset: 0x0008AA1C
		public unsafe override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (s == null || bytes == null)
			{
				throw new ArgumentNullException((s == null) ? "s" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (s.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("s", "Index and count must refer to a location within the string.");
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr2 = reference;
				return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}

		/// <summary>Кодирует набор символов из заданного массива символов в указанный массив байтов.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="charIndex">Индекс первого кодируемого символа.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Массив байтов, в который будет помещена результирующая последовательность байтов.</param>
		/// <param name="byteIndex">Индекс, с которого начинается запись результирующей последовательности байтов.</param>
		/// <returns>Фактическое число байтов, записанных в <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charIndex" />, <paramref name="charCount" /> или <paramref name="byteIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="charIndex" /> и <paramref name="charCount" /> не указывают допустимый диапазон в <paramref name="chars" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="byteIndex" /> не является допустимым индексом в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="chars" /> содержит недопустимую последовательность символов.  
		///
		/// или - 
		/// Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600273C RID: 10044 RVA: 0x0008C8E4 File Offset: 0x0008AAE4
		public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (charCount == 0)
			{
				return 0;
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr2 = reference;
				return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}

		/// <summary>Кодирует набор символов, начало которого задается указателем символа, в последовательность байтов, которые сохраняются начиная с заданного указателя байта.</summary>
		/// <param name="chars">Указатель на первый кодируемый символ.</param>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <param name="bytes">Указатель на положение, с которого начинается запись результирующей последовательности байтов.</param>
		/// <param name="byteCount">Максимальное число байтов для записи.</param>
		/// <returns>Фактическое число байтов, записанных в местоположение, указанное с помощью параметра <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> или <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="chars" /> содержит недопустимую последовательность символов.  
		///
		/// или - 
		/// <paramref name="byteCount" /> меньше результирующего числа байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600273D RID: 10045 RVA: 0x0008C9B4 File Offset: 0x0008ABB4
		[CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			return this.GetBytes(chars, charCount, bytes, byteCount, null);
		}

		/// <summary>Вычисляет количество символов, полученных при декодировании последовательности байтов из заданного массива байтов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и параметр <paramref name="bytes" /> содержит недопустимую последовательность байтов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600273E RID: 10046 RVA: 0x0008CA18 File Offset: 0x0008AC18
		public unsafe override int GetCharCount(byte[] bytes, int index, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (count == 0)
			{
				return 0;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return this.GetCharCount(ptr + index, count, null);
		}

		/// <summary>Вычисляет количество символов, полученных при декодировании последовательности байтов начиная с заданного указателя байта.</summary>
		/// <param name="bytes">Указатель на первый декодируемый байт.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и параметр <paramref name="bytes" /> содержит недопустимую последовательность байтов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600273F RID: 10047 RVA: 0x00084F4B File Offset: 0x0008314B
		[CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			return this.GetCharCount(bytes, count, null);
		}

		/// <summary>Декодирует последовательность байтов из заданного массива байтов в указанный массив символов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="byteIndex">Индекс первого декодируемого байта.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <param name="chars">Массив символов, в который будет помещен результирующий набор символов.</param>
		/// <param name="charIndex">Индекс, с которого начинается запись результирующего набора символов.</param>
		/// <returns>Фактическое число символов, записанных в <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteIndex" />, <paramref name="byteCount" /> или <paramref name="charIndex" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="byteindex" /> и <paramref name="byteCount" /> не указывают допустимый диапазон в <paramref name="bytes" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="charIndex" /> не является допустимым индексом в <paramref name="chars" />.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и параметр <paramref name="bytes" /> содержит недопустимую последовательность байтов.  
		///
		/// или - 
		/// Недостаточно емкости <paramref name="chars" /> от <paramref name="charIndex" /> до конца массива для размещения полученных символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002740 RID: 10048 RVA: 0x0008CA9C File Offset: 0x0008AC9C
		public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (charIndex < 0 || charIndex > chars.Length)
			{
				throw new ArgumentOutOfRangeException("charIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (byteCount == 0)
			{
				return 0;
			}
			int charCount = chars.Length - charIndex;
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* ptr2 = reference;
				return this.GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, null);
			}
		}

		/// <summary>Декодирует последовательность байтов, начало которой задается указателем байта, в набор символов, которые сохраняются начиная с заданного указателя символа.</summary>
		/// <param name="bytes">Указатель на первый декодируемый байт.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <param name="chars">Указатель на положение, с которого начинается запись результирующего набора символов.</param>
		/// <param name="charCount">Наибольшее количество символов для записи.</param>
		/// <returns>Фактическое число символов, записанных в местоположение, указанное с помощью параметра <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> или <paramref name="charCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и параметр <paramref name="bytes" /> содержит недопустимую последовательность байтов.  
		///
		/// или - 
		/// <paramref name="charCount" /> меньше результирующего числа символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002741 RID: 10049 RVA: 0x0008CB6C File Offset: 0x0008AD6C
		[CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			return this.GetChars(bytes, byteCount, chars, charCount, null);
		}

		/// <summary>Декодирует диапазон байтов из массива байтов в строку.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Объект <see cref="T:System.String" />, содержащий результаты декодирования заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и параметр <paramref name="bytes" /> содержит недопустимую последовательность байтов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002742 RID: 10050 RVA: 0x0008CBD0 File Offset: 0x0008ADD0
		public unsafe override string GetString(byte[] bytes, int index, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (count == 0)
			{
				return string.Empty;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return string.CreateStringFromEncoding(ptr + index, count, this);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0008CC58 File Offset: 0x0008AE58
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			char* ptr = chars;
			char* ptr2 = ptr + count;
			int num = count;
			int num2 = 0;
			if (baseEncoder != null)
			{
				UTF8Encoding.UTF8Encoder utf8Encoder = (UTF8Encoding.UTF8Encoder)baseEncoder;
				num2 = utf8Encoder.surrogateChar;
				if (utf8Encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = utf8Encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, utf8Encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(chars, ptr2, utf8Encoder, false);
				}
			}
			for (;;)
			{
				if (ptr >= ptr2)
				{
					if (num2 == 0)
					{
						num2 = (int)((encoderFallbackBuffer != null) ? encoderFallbackBuffer.InternalGetNextChar() : '\0');
						if (num2 > 0)
						{
							num++;
							goto IL_14C;
						}
					}
					else if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
					{
						num2 = (int)encoderFallbackBuffer.InternalGetNextChar();
						num++;
						if (UTF8Encoding.InRange(num2, 56320, 57343))
						{
							num2 = 65533;
							num++;
							goto IL_16A;
						}
						if (num2 <= 0)
						{
							break;
						}
						goto IL_14C;
					}
					if (num2 > 0 && (baseEncoder == null || baseEncoder.MustFlush))
					{
						num++;
						goto IL_16A;
					}
					goto IL_432;
				}
				else if (num2 > 0)
				{
					int ch = (int)(*ptr);
					num++;
					if (UTF8Encoding.InRange(ch, 56320, 57343))
					{
						num2 = 65533;
						ptr++;
						goto IL_16A;
					}
					goto IL_16A;
				}
				else
				{
					if (encoderFallbackBuffer != null)
					{
						num2 = (int)encoderFallbackBuffer.InternalGetNextChar();
						if (num2 > 0)
						{
							num++;
							goto IL_14C;
						}
					}
					num2 = (int)(*ptr);
					ptr++;
				}
				IL_14C:
				if (UTF8Encoding.InRange(num2, 55296, 56319))
				{
					num--;
					continue;
				}
				IL_16A:
				if (UTF8Encoding.InRange(num2, 55296, 57343))
				{
					if (encoderFallbackBuffer == null)
					{
						if (baseEncoder == null)
						{
							encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
						}
						else
						{
							encoderFallbackBuffer = baseEncoder.FallbackBuffer;
						}
						encoderFallbackBuffer.InternalInitialize(chars, chars + count, baseEncoder, false);
					}
					char* ptr3 = ptr;
					encoderFallbackBuffer.InternalFallback((char)num2, ref ptr3);
					ptr = ptr3;
					num--;
					num2 = 0;
				}
				else
				{
					if (num2 > 127)
					{
						if (num2 > 2047)
						{
							num++;
						}
						num++;
					}
					if (num < 0)
					{
						goto IL_432;
					}
					if (encoderFallbackBuffer != null && (num2 = (int)encoderFallbackBuffer.InternalGetNextChar()) != 0)
					{
						num++;
						goto IL_14C;
					}
					int num3 = UTF8Encoding.PtrDiff(ptr2, ptr);
					if (num3 <= 13)
					{
						char* ptr4 = ptr2;
						while (ptr < ptr4)
						{
							num2 = (int)(*ptr);
							ptr++;
							if (num2 > 127)
							{
								goto IL_14C;
							}
						}
						goto Block_28;
					}
					num3 &= 268435455;
					char* ptr5 = ptr + num3 - 7;
					IL_422:
					while (ptr < ptr5)
					{
						num2 = (int)(*ptr);
						ptr++;
						if (num2 > 127)
						{
							if (num2 > 2047)
							{
								if ((num2 & 63488) == 55296)
								{
									goto IL_3D0;
								}
								num++;
							}
							num++;
						}
						if ((ptr & 2) != 0)
						{
							num2 = (int)(*ptr);
							ptr++;
							if (num2 > 127)
							{
								if (num2 > 2047)
								{
									if ((num2 & 63488) == 55296)
									{
										goto IL_3D0;
									}
									num++;
								}
								num++;
							}
						}
						while (ptr < ptr5)
						{
							num2 = *(int*)ptr;
							int num4 = *(int*)(ptr + 2);
							if (((num2 | num4) & -8323200) != 0)
							{
								if (((num2 | num4) & -134154240) != 0)
								{
									goto IL_3B1;
								}
								if ((num2 & -8388608) != 0)
								{
									num++;
								}
								if ((num2 & 65408) != 0)
								{
									num++;
								}
								if ((num4 & -8388608) != 0)
								{
									num++;
								}
								if ((num4 & 65408) != 0)
								{
									num++;
								}
							}
							ptr += 4;
							num2 = *(int*)ptr;
							num4 = *(int*)(ptr + 2);
							if (((num2 | num4) & -8323200) != 0)
							{
								if (((num2 | num4) & -134154240) != 0)
								{
									goto IL_3B1;
								}
								if ((num2 & -8388608) != 0)
								{
									num++;
								}
								if ((num2 & 65408) != 0)
								{
									num++;
								}
								if ((num4 & -8388608) != 0)
								{
									num++;
								}
								if ((num4 & 65408) != 0)
								{
									num++;
								}
							}
							ptr += 4;
							continue;
							IL_3B1:
							if (BitConverter.IsLittleEndian)
							{
								num2 = (int)((ushort)num2);
							}
							else
							{
								num2 = (int)((uint)num2 >> 16);
							}
							ptr++;
							if (num2 > 127)
							{
								goto IL_3D0;
							}
							goto IL_422;
						}
						break;
						IL_3D0:
						if (num2 > 2047)
						{
							if (UTF8Encoding.InRange(num2, 55296, 57343))
							{
								int ch2 = (int)(*ptr);
								if (num2 > 56319 || !UTF8Encoding.InRange(ch2, 56320, 57343))
								{
									ptr--;
									break;
								}
								ptr++;
							}
							num++;
						}
						num++;
					}
					num2 = 0;
				}
			}
			num--;
			Block_28:
			IL_432:
			if (num < 0)
			{
				throw new ArgumentException("Conversion buffer overflow.");
			}
			return num;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0008D0A9 File Offset: 0x0008B2A9
		private unsafe static int PtrDiff(char* a, char* b)
		{
			return (int)((uint)((long)((a - b) / 1 * 2)) >> 1);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0008D0B4 File Offset: 0x0008B2B4
		private unsafe static int PtrDiff(byte* a, byte* b)
		{
			return (int)((long)(a - b));
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0008D0BD File Offset: 0x0008B2BD
		private static bool InRange(int ch, int start, int end)
		{
			return ch - start <= end - start;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0008D0CC File Offset: 0x0008B2CC
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			UTF8Encoding.UTF8Encoder utf8Encoder = null;
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			char* ptr = chars;
			byte* ptr2 = bytes;
			char* ptr3 = ptr + charCount;
			byte* ptr4 = ptr2 + byteCount;
			int num = 0;
			if (baseEncoder != null)
			{
				utf8Encoder = (UTF8Encoding.UTF8Encoder)baseEncoder;
				num = utf8Encoder.surrogateChar;
				if (utf8Encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = utf8Encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0 && utf8Encoder._throwOnOverflow)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, utf8Encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(chars, ptr3, utf8Encoder, true);
				}
			}
			for (;;)
			{
				if (ptr >= ptr3)
				{
					if (num == 0)
					{
						num = (int)((encoderFallbackBuffer != null) ? encoderFallbackBuffer.InternalGetNextChar() : '\0');
						if (num > 0)
						{
							goto IL_147;
						}
					}
					else if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
					{
						int num2 = num;
						num = (int)encoderFallbackBuffer.InternalGetNextChar();
						if (UTF8Encoding.InRange(num, 56320, 57343))
						{
							num = num + (num2 << 10) + -56613888;
							goto IL_15D;
						}
						if (num > 0)
						{
							goto IL_147;
						}
						goto IL_53C;
					}
					if (num <= 0)
					{
						goto IL_53C;
					}
					if (utf8Encoder == null)
					{
						goto IL_15D;
					}
					if (utf8Encoder.MustFlush)
					{
						goto IL_15D;
					}
					goto IL_53C;
				}
				else if (num > 0)
				{
					int num3 = (int)(*ptr);
					if (UTF8Encoding.InRange(num3, 56320, 57343))
					{
						num = num3 + (num << 10) + -56613888;
						ptr++;
						goto IL_15D;
					}
					goto IL_15D;
				}
				else
				{
					if (encoderFallbackBuffer != null)
					{
						num = (int)encoderFallbackBuffer.InternalGetNextChar();
						if (num > 0)
						{
							goto IL_147;
						}
					}
					num = (int)(*ptr);
					ptr++;
				}
				IL_147:
				if (UTF8Encoding.InRange(num, 55296, 56319))
				{
					continue;
				}
				IL_15D:
				if (UTF8Encoding.InRange(num, 55296, 57343))
				{
					if (encoderFallbackBuffer == null)
					{
						if (baseEncoder == null)
						{
							encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
						}
						else
						{
							encoderFallbackBuffer = baseEncoder.FallbackBuffer;
						}
						encoderFallbackBuffer.InternalInitialize(chars, ptr3, baseEncoder, true);
					}
					char* ptr5 = ptr;
					encoderFallbackBuffer.InternalFallback((char)num, ref ptr5);
					ptr = ptr5;
					num = 0;
				}
				else
				{
					int num4 = 1;
					if (num > 127)
					{
						if (num > 2047)
						{
							if (num > 65535)
							{
								num4++;
							}
							num4++;
						}
						num4++;
					}
					if (ptr2 != ptr4 - num4)
					{
						break;
					}
					if (num <= 127)
					{
						*ptr2 = (byte)num;
					}
					else
					{
						int num5;
						if (num <= 2047)
						{
							num5 = (int)((byte)(-64 | num >> 6));
						}
						else
						{
							if (num <= 65535)
							{
								num5 = (int)((byte)(-32 | num >> 12));
							}
							else
							{
								*ptr2 = (byte)(-16 | num >> 18);
								ptr2++;
								num5 = (-128 | (num >> 12 & 63));
							}
							*ptr2 = (byte)num5;
							ptr2++;
							num5 = (-128 | (num >> 6 & 63));
						}
						*ptr2 = (byte)num5;
						ptr2++;
						*ptr2 = (byte)(-128 | (num & 63));
					}
					ptr2++;
					if (encoderFallbackBuffer != null && (num = (int)encoderFallbackBuffer.InternalGetNextChar()) != 0)
					{
						goto IL_147;
					}
					int num6 = UTF8Encoding.PtrDiff(ptr3, ptr);
					int num7 = UTF8Encoding.PtrDiff(ptr4, ptr2);
					if (num6 <= 13)
					{
						if (num7 >= num6)
						{
							char* ptr6 = ptr3;
							while (ptr < ptr6)
							{
								num = (int)(*ptr);
								ptr++;
								if (num > 127)
								{
									goto IL_147;
								}
								*ptr2 = (byte)num;
								ptr2++;
							}
							goto Block_37;
						}
						num = 0;
					}
					else
					{
						if (num7 < num6)
						{
							num6 = num7;
						}
						char* ptr7 = ptr + num6 - 5;
						while (ptr < ptr7)
						{
							num = (int)(*ptr);
							ptr++;
							if (num <= 127)
							{
								*ptr2 = (byte)num;
								ptr2++;
								if ((ptr & 2) != 0)
								{
									num = (int)(*ptr);
									ptr++;
									if (num > 127)
									{
										goto IL_44F;
									}
									*ptr2 = (byte)num;
									ptr2++;
								}
								while (ptr < ptr7)
								{
									num = *(int*)ptr;
									int num8 = *(int*)(ptr + 2);
									if (((num | num8) & -8323200) == 0)
									{
										if (BitConverter.IsLittleEndian)
										{
											*ptr2 = (byte)num;
											ptr2[1] = (byte)(num >> 16);
											ptr += 4;
											ptr2[2] = (byte)num8;
											ptr2[3] = (byte)(num8 >> 16);
											ptr2 += 4;
										}
										else
										{
											*ptr2 = (byte)(num >> 16);
											ptr2[1] = (byte)num;
											ptr += 4;
											ptr2[2] = (byte)(num8 >> 16);
											ptr2[3] = (byte)num8;
											ptr2 += 4;
										}
									}
									else
									{
										if (BitConverter.IsLittleEndian)
										{
											num = (int)((ushort)num);
										}
										else
										{
											num = (int)((uint)num >> 16);
										}
										ptr++;
										if (num <= 127)
										{
											*ptr2 = (byte)num;
											ptr2++;
											break;
										}
										goto IL_44F;
									}
								}
								continue;
							}
							IL_44F:
							int num9;
							if (num <= 2047)
							{
								num9 = (-64 | num >> 6);
							}
							else
							{
								if (!UTF8Encoding.InRange(num, 55296, 57343))
								{
									num9 = (-32 | num >> 12);
								}
								else
								{
									if (num > 56319)
									{
										ptr--;
										break;
									}
									num9 = (int)(*ptr);
									ptr++;
									if (!UTF8Encoding.InRange(num9, 56320, 57343))
									{
										ptr -= 2;
										break;
									}
									num = num9 + (num << 10) + -56613888;
									*ptr2 = (byte)(-16 | num >> 18);
									ptr2++;
									num9 = (-128 | (num >> 12 & 63));
								}
								*ptr2 = (byte)num9;
								ptr7--;
								ptr2++;
								num9 = (-128 | (num >> 6 & 63));
							}
							*ptr2 = (byte)num9;
							ptr7--;
							ptr2++;
							*ptr2 = (byte)(-128 | (num & 63));
							ptr2++;
						}
						num = 0;
					}
				}
			}
			if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
			{
				encoderFallbackBuffer.MovePrevious();
				if (num > 65535)
				{
					encoderFallbackBuffer.MovePrevious();
				}
			}
			else
			{
				ptr--;
				if (num > 65535)
				{
					ptr--;
				}
			}
			base.ThrowBytesOverflow(utf8Encoder, ptr2 == bytes);
			num = 0;
			goto IL_53C;
			Block_37:
			num = 0;
			IL_53C:
			if (utf8Encoder != null)
			{
				utf8Encoder.surrogateChar = num;
				utf8Encoder._charsUsed = (int)((long)(ptr - chars));
			}
			return (int)((long)(ptr2 - bytes));
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0008D638 File Offset: 0x0008B838
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			byte* ptr = bytes;
			byte* ptr2 = ptr + count;
			int num = count;
			int num2 = 0;
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			if (baseDecoder != null)
			{
				num2 = ((UTF8Encoding.UTF8Decoder)baseDecoder).bits;
				num -= num2 >> 30;
			}
			IL_23:
			while (ptr < ptr2)
			{
				if (num2 == 0)
				{
					num2 = (int)(*ptr);
					ptr++;
					goto IL_106;
				}
				int num3 = (int)(*ptr);
				ptr++;
				if ((num3 & -64) != 128)
				{
					ptr--;
					num += num2 >> 30;
				}
				else
				{
					num2 = (num2 << 6 | (num3 & 63));
					if ((num2 & 536870912) == 0)
					{
						if ((num2 & 268435456) != 0)
						{
							if ((num2 & 8388608) != 0 || UTF8Encoding.InRange(num2 & 496, 16, 256))
							{
								continue;
							}
						}
						else if ((num2 & 992) != 0)
						{
							if ((num2 & 992) != 864)
							{
								continue;
							}
						}
					}
					else
					{
						if ((num2 & 270467072) == 268435456)
						{
							num--;
							goto IL_17C;
						}
						goto IL_17C;
					}
				}
				IL_C3:
				if (decoderFallbackBuffer == null)
				{
					if (baseDecoder == null)
					{
						decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
					}
					else
					{
						decoderFallbackBuffer = baseDecoder.FallbackBuffer;
					}
					decoderFallbackBuffer.InternalInitialize(bytes, null);
				}
				num += this.FallbackInvalidByteSequence(ptr, num2, decoderFallbackBuffer);
				num2 = 0;
				continue;
				IL_17C:
				int num4 = UTF8Encoding.PtrDiff(ptr2, ptr);
				if (num4 <= 13)
				{
					byte* ptr3 = ptr2;
					while (ptr < ptr3)
					{
						num2 = (int)(*ptr);
						ptr++;
						if (num2 > 127)
						{
							goto IL_106;
						}
					}
					num2 = 0;
					break;
				}
				byte* ptr4 = ptr + num4 - 7;
				while (ptr < ptr4)
				{
					num2 = (int)(*ptr);
					ptr++;
					if (num2 <= 127)
					{
						if ((ptr & 1) != 0)
						{
							num2 = (int)(*ptr);
							ptr++;
							if (num2 > 127)
							{
								goto IL_26F;
							}
						}
						if ((ptr & 2) != 0)
						{
							num2 = (int)(*(ushort*)ptr);
							if ((num2 & 32896) != 0)
							{
								goto IL_24E;
							}
							ptr += 2;
						}
						while (ptr < ptr4)
						{
							num2 = *(int*)ptr;
							int num5 = *(int*)(ptr + 4);
							if (((num2 | num5) & -2139062144) == 0)
							{
								ptr += 8;
								if (ptr >= ptr4)
								{
									break;
								}
								num2 = *(int*)ptr;
								num5 = *(int*)(ptr + 4);
								if (((num2 | num5) & -2139062144) == 0)
								{
									ptr += 8;
									continue;
								}
							}
							if (BitConverter.IsLittleEndian)
							{
								num2 &= 255;
								goto IL_24E;
							}
							num2 = (int)((uint)num2 >> 16);
							goto IL_24E;
						}
						break;
						IL_24E:
						if (BitConverter.IsLittleEndian)
						{
							num2 &= 255;
						}
						else
						{
							num2 = (int)((uint)num2 >> 8);
						}
						ptr++;
						if (num2 <= 127)
						{
							continue;
						}
					}
					IL_26F:
					int num6 = (int)(*ptr);
					ptr++;
					if ((num2 & 64) != 0 && (num6 & -64) == 128)
					{
						num6 &= 63;
						if ((num2 & 32) != 0)
						{
							num6 |= (num2 & 15) << 6;
							if ((num2 & 16) != 0)
							{
								num2 = (int)(*ptr);
								if (!UTF8Encoding.InRange(num6 >> 4, 1, 16) || (num2 & -64) != 128)
								{
									goto IL_33B;
								}
								num6 = (num6 << 6 | (num2 & 63));
								num2 = (int)ptr[1];
								if ((num2 & -64) != 128)
								{
									goto IL_33B;
								}
								ptr += 2;
								num--;
							}
							else
							{
								num2 = (int)(*ptr);
								if ((num6 & 992) == 0 || (num6 & 992) == 864 || (num2 & -64) != 128)
								{
									goto IL_33B;
								}
								ptr++;
								num--;
							}
						}
						else if ((num2 & 30) == 0)
						{
							goto IL_33B;
						}
						num--;
						continue;
					}
					IL_33B:
					ptr -= 2;
					num2 = 0;
					goto IL_23;
				}
				num2 = 0;
				continue;
				IL_106:
				if (num2 <= 127)
				{
					goto IL_17C;
				}
				num--;
				if ((num2 & 64) == 0)
				{
					goto IL_C3;
				}
				if ((num2 & 32) != 0)
				{
					if ((num2 & 16) != 0)
					{
						num2 &= 15;
						if (num2 > 4)
						{
							num2 |= 240;
							goto IL_C3;
						}
						num2 |= 1347226624;
						num--;
					}
					else
					{
						num2 = ((num2 & 15) | 1210220544);
						num--;
					}
				}
				else
				{
					num2 &= 31;
					if (num2 <= 1)
					{
						num2 |= 192;
						goto IL_C3;
					}
					num2 |= 8388608;
				}
			}
			if (num2 != 0)
			{
				num += num2 >> 30;
				if (baseDecoder == null || baseDecoder.MustFlush)
				{
					if (decoderFallbackBuffer == null)
					{
						if (baseDecoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = baseDecoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(bytes, null);
					}
					num += this.FallbackInvalidByteSequence(ptr, num2, decoderFallbackBuffer);
				}
			}
			return num;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0008D9D8 File Offset: 0x0008BBD8
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			byte* ptr = bytes;
			char* ptr2 = chars;
			byte* ptr3 = ptr + byteCount;
			char* ptr4 = ptr2 + charCount;
			int num = 0;
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			if (baseDecoder != null)
			{
				num = ((UTF8Encoding.UTF8Decoder)baseDecoder).bits;
			}
			IL_28:
			while (ptr < ptr3)
			{
				if (num == 0)
				{
					num = (int)(*ptr);
					ptr++;
					goto IL_169;
				}
				int num2 = (int)(*ptr);
				ptr++;
				if ((num2 & -64) != 128)
				{
					ptr--;
				}
				else
				{
					num = (num << 6 | (num2 & 63));
					if ((num & 536870912) == 0)
					{
						if ((num & 268435456) != 0)
						{
							if ((num & 8388608) != 0 || UTF8Encoding.InRange(num & 496, 16, 256))
							{
								continue;
							}
						}
						else if ((num & 992) != 0)
						{
							if ((num & 992) != 864)
							{
								continue;
							}
						}
					}
					else
					{
						if ((num & 270467072) > 268435456 && ptr2 < ptr4)
						{
							*ptr2 = (char)((num >> 10 & 2047) + -10304);
							ptr2++;
							num = (num & 1023) + 56320;
							goto IL_1EA;
						}
						goto IL_1EA;
					}
				}
				IL_F9:
				if (decoderFallbackBuffer == null)
				{
					if (baseDecoder == null)
					{
						decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
					}
					else
					{
						decoderFallbackBuffer = baseDecoder.FallbackBuffer;
					}
					decoderFallbackBuffer.InternalInitialize(bytes, ptr4);
				}
				byte* ptr5 = ptr;
				char* ptr6 = ptr2;
				bool flag = this.FallbackInvalidByteSequence(ref ptr5, num, decoderFallbackBuffer, ref ptr6);
				ptr = ptr5;
				ptr2 = ptr6;
				if (!flag)
				{
					decoderFallbackBuffer.InternalReset();
					base.ThrowCharsOverflow(baseDecoder, ptr2 == chars);
					num = 0;
					break;
				}
				num = 0;
				continue;
				IL_1EA:
				if (ptr2 >= ptr4)
				{
					num &= 2097151;
					if (num > 127)
					{
						if (num > 2047)
						{
							if (num >= 56320 && num <= 57343)
							{
								ptr--;
								ptr2--;
							}
							else if (num > 65535)
							{
								ptr--;
							}
							ptr--;
						}
						ptr--;
					}
					ptr--;
					base.ThrowCharsOverflow(baseDecoder, ptr2 == chars);
					num = 0;
					break;
				}
				*ptr2 = (char)num;
				ptr2++;
				int num3 = UTF8Encoding.PtrDiff(ptr4, ptr2);
				int num4 = UTF8Encoding.PtrDiff(ptr3, ptr);
				if (num4 > 13)
				{
					if (num3 < num4)
					{
						num4 = num3;
					}
					char* ptr7 = ptr2 + num4 - 7;
					while (ptr2 < ptr7)
					{
						num = (int)(*ptr);
						ptr++;
						if (num <= 127)
						{
							*ptr2 = (char)num;
							ptr2++;
							if ((ptr & 1) != 0)
							{
								num = (int)(*ptr);
								ptr++;
								if (num > 127)
								{
									goto IL_4DC;
								}
								*ptr2 = (char)num;
								ptr2++;
							}
							if ((ptr & 2) != 0)
							{
								num = (int)(*(ushort*)ptr);
								if ((num & 32896) != 0)
								{
									goto IL_4AB;
								}
								if (BitConverter.IsLittleEndian)
								{
									*ptr2 = (char)(num & 127);
									ptr += 2;
									ptr2[1] = (char)(num >> 8 & 127);
									ptr2 += 2;
								}
								else
								{
									*ptr2 = (char)(num >> 8 & 127);
									ptr += 2;
									ptr2[1] = (char)(num & 127);
									ptr2 += 2;
								}
							}
							while (ptr2 < ptr7)
							{
								num = *(int*)ptr;
								int num5 = *(int*)(ptr + 4);
								if (((num | num5) & -2139062144) == 0)
								{
									if (BitConverter.IsLittleEndian)
									{
										*ptr2 = (char)(num & 127);
										ptr2[1] = (char)(num >> 8 & 127);
										ptr2[2] = (char)(num >> 16 & 127);
										ptr2[3] = (char)(num >> 24 & 127);
										ptr += 8;
										ptr2[4] = (char)(num5 & 127);
										ptr2[5] = (char)(num5 >> 8 & 127);
										ptr2[6] = (char)(num5 >> 16 & 127);
										ptr2[7] = (char)(num5 >> 24 & 127);
										ptr2 += 8;
									}
									else
									{
										*ptr2 = (char)(num >> 24 & 127);
										ptr2[1] = (char)(num >> 16 & 127);
										ptr2[2] = (char)(num >> 8 & 127);
										ptr2[3] = (char)(num & 127);
										ptr += 8;
										ptr2[4] = (char)(num5 >> 24 & 127);
										ptr2[5] = (char)(num5 >> 16 & 127);
										ptr2[6] = (char)(num5 >> 8 & 127);
										ptr2[7] = (char)(num5 & 127);
										ptr2 += 8;
									}
								}
								else
								{
									if (BitConverter.IsLittleEndian)
									{
										num &= 255;
										goto IL_4AB;
									}
									num = (int)((uint)num >> 16);
									goto IL_4AB;
								}
							}
							break;
							IL_4AB:
							if (BitConverter.IsLittleEndian)
							{
								num &= 255;
							}
							else
							{
								num = (int)((uint)num >> 8);
							}
							ptr++;
							if (num <= 127)
							{
								*ptr2 = (char)num;
								ptr2++;
								continue;
							}
						}
						IL_4DC:
						int num6 = (int)(*ptr);
						ptr++;
						if ((num & 64) != 0 && (num6 & -64) == 128)
						{
							num6 &= 63;
							if ((num & 32) != 0)
							{
								num6 |= (num & 15) << 6;
								if ((num & 16) != 0)
								{
									num = (int)(*ptr);
									if (!UTF8Encoding.InRange(num6 >> 4, 1, 16) || (num & -64) != 128)
									{
										goto IL_61E;
									}
									num6 = (num6 << 6 | (num & 63));
									num = (int)ptr[1];
									if ((num & -64) != 128)
									{
										goto IL_61E;
									}
									ptr += 2;
									num = (num6 << 6 | (num & 63));
									*ptr2 = (char)((num >> 10 & 2047) + -10304);
									ptr2++;
									num = (num & 1023) + -9216;
									ptr7--;
								}
								else
								{
									num = (int)(*ptr);
									if ((num6 & 992) == 0 || (num6 & 992) == 864 || (num & -64) != 128)
									{
										goto IL_61E;
									}
									ptr++;
									num = (num6 << 6 | (num & 63));
									ptr7--;
								}
							}
							else
							{
								num &= 31;
								if (num <= 1)
								{
									goto IL_61E;
								}
								num = (num << 6 | num6);
							}
							*ptr2 = (char)num;
							ptr2++;
							ptr7--;
							continue;
						}
						IL_61E:
						ptr -= 2;
						num = 0;
						goto IL_28;
					}
					num = 0;
					continue;
				}
				if (num3 < num4)
				{
					num = 0;
					continue;
				}
				byte* ptr8 = ptr3;
				while (ptr < ptr8)
				{
					num = (int)(*ptr);
					ptr++;
					if (num > 127)
					{
						goto IL_169;
					}
					*ptr2 = (char)num;
					ptr2++;
				}
				num = 0;
				break;
				IL_169:
				if (num <= 127)
				{
					goto IL_1EA;
				}
				if ((num & 64) == 0)
				{
					goto IL_F9;
				}
				if ((num & 32) != 0)
				{
					if ((num & 16) != 0)
					{
						num &= 15;
						if (num > 4)
						{
							num |= 240;
							goto IL_F9;
						}
						num |= 1347226624;
					}
					else
					{
						num = ((num & 15) | 1210220544);
					}
				}
				else
				{
					num &= 31;
					if (num <= 1)
					{
						num |= 192;
						goto IL_F9;
					}
					num |= 8388608;
				}
			}
			if (num != 0 && (baseDecoder == null || baseDecoder.MustFlush))
			{
				if (decoderFallbackBuffer == null)
				{
					if (baseDecoder == null)
					{
						decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
					}
					else
					{
						decoderFallbackBuffer = baseDecoder.FallbackBuffer;
					}
					decoderFallbackBuffer.InternalInitialize(bytes, ptr4);
				}
				byte* ptr5 = ptr;
				char* ptr6 = ptr2;
				bool flag2 = this.FallbackInvalidByteSequence(ref ptr5, num, decoderFallbackBuffer, ref ptr6);
				ptr = ptr5;
				ptr2 = ptr6;
				if (!flag2)
				{
					decoderFallbackBuffer.InternalReset();
					base.ThrowCharsOverflow(baseDecoder, ptr2 == chars);
				}
				num = 0;
			}
			if (baseDecoder != null)
			{
				((UTF8Encoding.UTF8Decoder)baseDecoder).bits = num;
				baseDecoder._bytesUsed = (int)((long)(ptr - bytes));
			}
			return UTF8Encoding.PtrDiff(ptr2, chars);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0008E0A4 File Offset: 0x0008C2A4
		private unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
		{
			byte* ptr = pSrc;
			byte[] bytesUnknown = this.GetBytesUnknown(ref ptr, ch);
			if (!fallback.InternalFallback(bytesUnknown, pSrc, ref pTarget))
			{
				pSrc = ptr;
				return false;
			}
			return true;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0008E0D4 File Offset: 0x0008C2D4
		private unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
		{
			byte[] bytesUnknown = this.GetBytesUnknown(ref pSrc, ch);
			return fallback.InternalFallback(bytesUnknown, pSrc);
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0008E0F4 File Offset: 0x0008C2F4
		private unsafe byte[] GetBytesUnknown(ref byte* pSrc, int ch)
		{
			byte[] result;
			if (ch < 256 && ch >= 0)
			{
				pSrc--;
				result = new byte[]
				{
					(byte)ch
				};
			}
			else if ((ch & 402653184) == 0)
			{
				pSrc--;
				result = new byte[]
				{
					(byte)((ch & 31) | 192)
				};
			}
			else if ((ch & 268435456) != 0)
			{
				if ((ch & 8388608) != 0)
				{
					pSrc -= 3;
					result = new byte[]
					{
						(byte)((ch >> 12 & 7) | 240),
						(byte)((ch >> 6 & 63) | 128),
						(byte)((ch & 63) | 128)
					};
				}
				else if ((ch & 131072) != 0)
				{
					pSrc -= 2;
					result = new byte[]
					{
						(byte)((ch >> 6 & 7) | 240),
						(byte)((ch & 63) | 128)
					};
				}
				else
				{
					pSrc--;
					result = new byte[]
					{
						(byte)((ch & 7) | 240)
					};
				}
			}
			else if ((ch & 8388608) != 0)
			{
				pSrc -= 2;
				result = new byte[]
				{
					(byte)((ch >> 6 & 15) | 224),
					(byte)((ch & 63) | 128)
				};
			}
			else
			{
				pSrc--;
				result = new byte[]
				{
					(byte)((ch & 15) | 224)
				};
			}
			return result;
		}

		/// <summary>Получает средство декодирования, преобразующее последовательность байтов в кодировке UTF-8 в последовательность символов Юникода.</summary>
		/// <returns>Средство декодирования, преобразующее последовательность байтов в кодировке UTF-8 в последовательность символов Юникода.</returns>
		// Token: 0x0600274D RID: 10061 RVA: 0x0008E247 File Offset: 0x0008C447
		public override Decoder GetDecoder()
		{
			return new UTF8Encoding.UTF8Decoder(this);
		}

		/// <summary>Получает средство кодирования, преобразующее последовательность символов Юникода в последовательность байтов в кодировке UTF-8.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoder" />, преобразующий последовательность символов Юникода в последовательность байтов в кодировке UTF-8.</returns>
		// Token: 0x0600274E RID: 10062 RVA: 0x0008E24F File Offset: 0x0008C44F
		public override Encoder GetEncoder()
		{
			return new UTF8Encoding.UTF8Encoder(this);
		}

		/// <summary>Вычисляет максимальное количество байтов, полученных при кодировании заданного числа символов.</summary>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <returns>Максимальное количество байтов, полученных при кодировании заданного количества символов.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600274F RID: 10063 RVA: 0x0008E258 File Offset: 0x0008C458
		public override int GetMaxByteCount(int charCount)
		{
			if (charCount < 0)
			{
				throw new ArgumentOutOfRangeException("charCount", "Non-negative number required.");
			}
			long num = (long)charCount + 1L;
			if (base.EncoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.EncoderFallback.MaxCharCount;
			}
			num *= 3L;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", "Too many characters. The resulting number of bytes is larger than what can be returned as an int.");
			}
			return (int)num;
		}

		/// <summary>Вычисляет максимальное количество символов, полученных при декодировании заданного числа байтов.</summary>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <returns>Максимальное количество символов, полученных при декодировании заданного количества байтов.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002750 RID: 10064 RVA: 0x0008E2BC File Offset: 0x0008C4BC
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			long num = (long)byteCount + 1L;
			if (base.DecoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.DecoderFallback.MaxCharCount;
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Too many bytes. The resulting number of chars is larger than what can be returned as an int.");
			}
			return (int)num;
		}

		/// <summary>Возвращает метку порядка байтов Юникода в кодировке UTF-8, если кодирующий объект <see cref="T:System.Text.UTF8Encoding" /> настроен для ее предоставления.</summary>
		/// <returns>Массив байтов, содержащий метку порядка байтов Юникода, если кодирующий объект <see cref="T:System.Text.UTF8Encoding" /> настроен для ее предоставления. В противном случае этот метод возвращает массив байтов нулевой длины.</returns>
		// Token: 0x06002751 RID: 10065 RVA: 0x0008E31B File Offset: 0x0008C51B
		public override byte[] GetPreamble()
		{
			if (this._emitUTF8Identifier)
			{
				return new byte[]
				{
					239,
					187,
					191
				};
			}
			return Array.Empty<byte>();
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x0008E33C File Offset: 0x0008C53C
		public override ReadOnlySpan<byte> Preamble
		{
			get
			{
				return (base.GetType() != typeof(UTF8Encoding)) ? this.GetPreamble() : (this._emitUTF8Identifier ? UTF8Encoding.s_preamble : Array.Empty<byte>());
			}
		}

		/// <summary>Определяет, равен ли заданный объект текущему объекту <see cref="T:System.Text.UTF8Encoding" />.</summary>
		/// <param name="value">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> является экземпляром класса <see cref="T:System.Text.UTF8Encoding" /> и равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002753 RID: 10067 RVA: 0x0008E378 File Offset: 0x0008C578
		public override bool Equals(object value)
		{
			UTF8Encoding utf8Encoding = value as UTF8Encoding;
			return utf8Encoding != null && (this._emitUTF8Identifier == utf8Encoding._emitUTF8Identifier && base.EncoderFallback.Equals(utf8Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf8Encoding.DecoderFallback);
		}

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x06002754 RID: 10068 RVA: 0x0008E3C5 File Offset: 0x0008C5C5
		public override int GetHashCode()
		{
			return base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + 65001 + (this._emitUTF8Identifier ? 1 : 0);
		}

		// Token: 0x04001DFA RID: 7674
		private const int UTF8_CODEPAGE = 65001;

		// Token: 0x04001DFB RID: 7675
		internal static readonly UTF8Encoding.UTF8EncodingSealed s_default = new UTF8Encoding.UTF8EncodingSealed(true);

		// Token: 0x04001DFC RID: 7676
		internal static readonly byte[] s_preamble = new byte[]
		{
			239,
			187,
			191
		};

		// Token: 0x04001DFD RID: 7677
		internal readonly bool _emitUTF8Identifier;

		// Token: 0x04001DFE RID: 7678
		private bool _isThrowException;

		// Token: 0x04001DFF RID: 7679
		private const int FinalByte = 536870912;

		// Token: 0x04001E00 RID: 7680
		private const int SupplimentarySeq = 268435456;

		// Token: 0x04001E01 RID: 7681
		private const int ThreeByteSeq = 134217728;

		// Token: 0x020003B5 RID: 949
		internal sealed class UTF8EncodingSealed : UTF8Encoding
		{
			// Token: 0x06002756 RID: 10070 RVA: 0x0008E414 File Offset: 0x0008C614
			public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) : base(encoderShouldEmitUTF8Identifier)
			{
			}

			// Token: 0x170004C3 RID: 1219
			// (get) Token: 0x06002757 RID: 10071 RVA: 0x0008E41D File Offset: 0x0008C61D
			public override ReadOnlySpan<byte> Preamble
			{
				get
				{
					return this._emitUTF8Identifier ? UTF8Encoding.s_preamble : Array.Empty<byte>();
				}
			}
		}

		// Token: 0x020003B6 RID: 950
		[Serializable]
		private sealed class UTF8Encoder : EncoderNLS
		{
			// Token: 0x06002758 RID: 10072 RVA: 0x0008C58D File Offset: 0x0008A78D
			public UTF8Encoder(UTF8Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002759 RID: 10073 RVA: 0x0008E438 File Offset: 0x0008C638
			public override void Reset()
			{
				this.surrogateChar = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x170004C4 RID: 1220
			// (get) Token: 0x0600275A RID: 10074 RVA: 0x0008E454 File Offset: 0x0008C654
			internal override bool HasState
			{
				get
				{
					return this.surrogateChar != 0;
				}
			}

			// Token: 0x04001E02 RID: 7682
			internal int surrogateChar;
		}

		// Token: 0x020003B7 RID: 951
		[Serializable]
		private sealed class UTF8Decoder : DecoderNLS
		{
			// Token: 0x0600275B RID: 10075 RVA: 0x0008BAA3 File Offset: 0x00089CA3
			public UTF8Decoder(UTF8Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x0600275C RID: 10076 RVA: 0x0008E45F File Offset: 0x0008C65F
			public override void Reset()
			{
				this.bits = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x170004C5 RID: 1221
			// (get) Token: 0x0600275D RID: 10077 RVA: 0x0008E47B File Offset: 0x0008C67B
			internal override bool HasState
			{
				get
				{
					return this.bits != 0;
				}
			}

			// Token: 0x04001E03 RID: 7683
			internal int bits;
		}
	}
}
