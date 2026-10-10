using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Представляет кодировку символов Юникода в формате UTF-32.</summary>
	// Token: 0x020003AD RID: 941
	[Serializable]
	public sealed class UTF32Encoding : Encoding
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF32Encoding" />.</summary>
		// Token: 0x060026E6 RID: 9958 RVA: 0x0008AA53 File Offset: 0x00088C53
		public UTF32Encoding() : this(false, true, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF32Encoding" />. Параметры указывают, следует ли использовать обратный порядок байтов и возвращает ли метод <see cref="M:System.Text.UTF32Encoding.GetPreamble" /> метку порядка байтов Юникода.</summary>
		/// <param name="bigEndian">Значение <see langword="true" /> соответствует использованию обратного порядка байтов (самый старший байт располагается на первом месте); значение <see langword="false" /> соответствует использованию прямого порядка байтов (на первом месте находится самый младший байт).</param>
		/// <param name="byteOrderMark">Значение <see langword="true" /> указывает, что предоставляется метка порядка байтов Юникода; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060026E7 RID: 9959 RVA: 0x0008AA5E File Offset: 0x00088C5E
		public UTF32Encoding(bool bigEndian, bool byteOrderMark) : this(bigEndian, byteOrderMark, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF32Encoding" />. Параметры указывают, следует ли использовать обратный порядок байтов, должна ли предоставляться метка порядка байтов Юникода и следует ли создавать исключение при обнаружении недопустимой кодировки.</summary>
		/// <param name="bigEndian">Значение <see langword="true" /> соответствует использованию обратного порядка байтов (самый старший байт располагается на первом месте); значение <see langword="false" /> соответствует использованию прямого порядка байтов (на первом месте находится самый младший байт).</param>
		/// <param name="byteOrderMark">Значение <see langword="true" /> указывает, что предоставляется метка порядка байтов Юникода; в противном случае — значение <see langword="false" />.</param>
		/// <param name="throwOnInvalidCharacters">
		///   <see langword="true" />, чтобы указать, что следует выдавать исключение при обнаружении недопустимой кодировки; в противном случае — <see langword="false" />.</param>
		// Token: 0x060026E8 RID: 9960 RVA: 0x0008AA69 File Offset: 0x00088C69
		public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) : base(bigEndian ? 12001 : 12000)
		{
			this._bigEndian = bigEndian;
			this._emitUTF32ByteOrderMark = byteOrderMark;
			this._isThrowException = throwOnInvalidCharacters;
			if (this._isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0008AAA4 File Offset: 0x00088CA4
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
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060026EA RID: 9962 RVA: 0x0008AAF0 File Offset: 0x00088CF0
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
		/// <param name="s">Объект <see cref="T:System.String" />, содержащий кодируемый набор символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Обнаружение ошибок включено, и <paramref name="s" /> содержит недопустимую последовательность символов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060026EB RID: 9963 RVA: 0x0008AB78 File Offset: 0x00088D78
		public unsafe override int GetByteCount(string s)
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
			return this.GetByteCount(ptr, s.Length, null);
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
		// Token: 0x060026EC RID: 9964 RVA: 0x00084C95 File Offset: 0x00082E95
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
		// Token: 0x060026ED RID: 9965 RVA: 0x0008ABB4 File Offset: 0x00088DB4
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
		// Token: 0x060026EE RID: 9966 RVA: 0x0008AC7C File Offset: 0x00088E7C
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
		/// <returns>Фактическое число байтов, записанных в местоположение, которое задано параметром <paramref name="bytes" />.</returns>
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
		// Token: 0x060026EF RID: 9967 RVA: 0x0008AD4C File Offset: 0x00088F4C
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
		// Token: 0x060026F0 RID: 9968 RVA: 0x0008ADB0 File Offset: 0x00088FB0
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
		// Token: 0x060026F1 RID: 9969 RVA: 0x00084F4B File Offset: 0x0008314B
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
		// Token: 0x060026F2 RID: 9970 RVA: 0x0008AE34 File Offset: 0x00089034
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
		// Token: 0x060026F3 RID: 9971 RVA: 0x0008AF04 File Offset: 0x00089104
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
		/// <returns>Строка, содержащая результаты декодирования заданной последовательности байтов.</returns>
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
		// Token: 0x060026F4 RID: 9972 RVA: 0x0008AF68 File Offset: 0x00089168
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

		// Token: 0x060026F5 RID: 9973 RVA: 0x0008AFF0 File Offset: 0x000891F0
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			char* ptr = chars + count;
			char* charStart = chars;
			int num = 0;
			char c = '\0';
			EncoderFallbackBuffer encoderFallbackBuffer;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				encoderFallbackBuffer = encoder.FallbackBuffer;
				if (encoderFallbackBuffer.Remaining > 0)
				{
					throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, encoder.Fallback.GetType()));
				}
			}
			else
			{
				encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
			}
			encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
			for (;;)
			{
				char c2;
				if ((c2 = encoderFallbackBuffer.InternalGetNextChar()) == '\0' && chars >= ptr)
				{
					if ((encoder != null && !encoder.MustFlush) || c <= '\0')
					{
						break;
					}
					char* ptr2 = chars;
					encoderFallbackBuffer.InternalFallback(c, ref ptr2);
					chars = ptr2;
					c = '\0';
				}
				else
				{
					if (c2 == '\0')
					{
						c2 = *chars;
						chars++;
					}
					if (c != '\0')
					{
						if (char.IsLowSurrogate(c2))
						{
							c = '\0';
							num += 4;
						}
						else
						{
							chars--;
							char* ptr2 = chars;
							encoderFallbackBuffer.InternalFallback(c, ref ptr2);
							chars = ptr2;
							c = '\0';
						}
					}
					else if (char.IsHighSurrogate(c2))
					{
						c = c2;
					}
					else if (char.IsLowSurrogate(c2))
					{
						char* ptr2 = chars;
						encoderFallbackBuffer.InternalFallback(c2, ref ptr2);
						chars = ptr2;
					}
					else
					{
						num += 4;
					}
				}
			}
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Too many characters. The resulting number of bytes is larger than what can be returned as an int.");
			}
			return num;
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x0008B11C File Offset: 0x0008931C
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			char* ptr = chars;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			byte* ptr4 = bytes + byteCount;
			char c = '\0';
			EncoderFallbackBuffer encoderFallbackBuffer;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				encoderFallbackBuffer = encoder.FallbackBuffer;
				if (encoder._throwOnOverflow && encoderFallbackBuffer.Remaining > 0)
				{
					throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, encoder.Fallback.GetType()));
				}
			}
			else
			{
				encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
			}
			encoderFallbackBuffer.InternalInitialize(ptr, ptr2, encoder, true);
			for (;;)
			{
				char c2;
				char* ptr5;
				if ((c2 = encoderFallbackBuffer.InternalGetNextChar()) != '\0' || chars < ptr2)
				{
					if (c2 == '\0')
					{
						c2 = *chars;
						chars++;
					}
					if (c != '\0')
					{
						if (!char.IsLowSurrogate(c2))
						{
							chars--;
							ptr5 = chars;
							encoderFallbackBuffer.InternalFallback(c, ref ptr5);
							chars = ptr5;
							c = '\0';
							continue;
						}
						uint surrogate = this.GetSurrogate(c, c2);
						c = '\0';
						if (bytes + 3 >= ptr4)
						{
							if (encoderFallbackBuffer.bFallingBack)
							{
								encoderFallbackBuffer.MovePrevious();
								encoderFallbackBuffer.MovePrevious();
							}
							else
							{
								chars -= 2;
							}
							base.ThrowBytesOverflow(encoder, bytes == ptr3);
							c = '\0';
						}
						else
						{
							if (this._bigEndian)
							{
								*(bytes++) = 0;
								*(bytes++) = (byte)(surrogate >> 16);
								*(bytes++) = (byte)(surrogate >> 8);
								*(bytes++) = (byte)surrogate;
								continue;
							}
							*(bytes++) = (byte)surrogate;
							*(bytes++) = (byte)(surrogate >> 8);
							*(bytes++) = (byte)(surrogate >> 16);
							*(bytes++) = 0;
							continue;
						}
					}
					else
					{
						if (char.IsHighSurrogate(c2))
						{
							c = c2;
							continue;
						}
						if (char.IsLowSurrogate(c2))
						{
							ptr5 = chars;
							encoderFallbackBuffer.InternalFallback(c2, ref ptr5);
							chars = ptr5;
							continue;
						}
						if (bytes + 3 >= ptr4)
						{
							if (encoderFallbackBuffer.bFallingBack)
							{
								encoderFallbackBuffer.MovePrevious();
							}
							else
							{
								chars--;
							}
							base.ThrowBytesOverflow(encoder, bytes == ptr3);
						}
						else
						{
							if (this._bigEndian)
							{
								*(bytes++) = 0;
								*(bytes++) = 0;
								*(bytes++) = (byte)(c2 >> 8);
								*(bytes++) = (byte)c2;
								continue;
							}
							*(bytes++) = (byte)c2;
							*(bytes++) = (byte)(c2 >> 8);
							*(bytes++) = 0;
							*(bytes++) = 0;
							continue;
						}
					}
				}
				if ((encoder != null && !encoder.MustFlush) || c <= '\0')
				{
					break;
				}
				ptr5 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr5);
				chars = ptr5;
				c = '\0';
			}
			if (encoder != null)
			{
				encoder._charLeftOver = c;
				encoder._charsUsed = (int)((long)(chars - ptr));
			}
			return (int)((long)(bytes - ptr3));
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0008B3B4 File Offset: 0x000895B4
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			UTF32Encoding.UTF32Decoder utf32Decoder = (UTF32Encoding.UTF32Decoder)baseDecoder;
			int num = 0;
			byte* ptr = bytes + count;
			byte* byteStart = bytes;
			int i = 0;
			uint num2 = 0U;
			DecoderFallbackBuffer decoderFallbackBuffer;
			if (utf32Decoder != null)
			{
				i = utf32Decoder.readByteCount;
				num2 = (uint)utf32Decoder.iChar;
				decoderFallbackBuffer = utf32Decoder.FallbackBuffer;
			}
			else
			{
				decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
			}
			decoderFallbackBuffer.InternalInitialize(byteStart, null);
			while (bytes < ptr && num >= 0)
			{
				if (this._bigEndian)
				{
					num2 <<= 8;
					num2 += (uint)(*(bytes++));
				}
				else
				{
					num2 >>= 8;
					num2 += (uint)((uint)(*(bytes++)) << 24);
				}
				i++;
				if (i >= 4)
				{
					i = 0;
					if (num2 > 1114111U || (num2 >= 55296U && num2 <= 57343U))
					{
						byte[] bytes2;
						if (this._bigEndian)
						{
							bytes2 = new byte[]
							{
								(byte)(num2 >> 24),
								(byte)(num2 >> 16),
								(byte)(num2 >> 8),
								(byte)num2
							};
						}
						else
						{
							bytes2 = new byte[]
							{
								(byte)num2,
								(byte)(num2 >> 8),
								(byte)(num2 >> 16),
								(byte)(num2 >> 24)
							};
						}
						num += decoderFallbackBuffer.InternalFallback(bytes2, bytes);
						num2 = 0U;
					}
					else
					{
						if (num2 >= 65536U)
						{
							num++;
						}
						num++;
						num2 = 0U;
					}
				}
			}
			if (i > 0 && (utf32Decoder == null || utf32Decoder.MustFlush))
			{
				byte[] array = new byte[i];
				if (this._bigEndian)
				{
					while (i > 0)
					{
						array[--i] = (byte)num2;
						num2 >>= 8;
					}
				}
				else
				{
					while (i > 0)
					{
						array[--i] = (byte)(num2 >> 24);
						num2 <<= 8;
					}
				}
				num += decoderFallbackBuffer.InternalFallback(array, bytes);
			}
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Too many characters. The resulting number of bytes is larger than what can be returned as an int.");
			}
			return num;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0008B574 File Offset: 0x00089774
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UTF32Encoding.UTF32Decoder utf32Decoder = (UTF32Encoding.UTF32Decoder)baseDecoder;
			char* ptr = chars;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			byte* ptr4 = bytes + byteCount;
			int num = 0;
			uint num2 = 0U;
			DecoderFallbackBuffer decoderFallbackBuffer;
			if (utf32Decoder != null)
			{
				num = utf32Decoder.readByteCount;
				num2 = (uint)utf32Decoder.iChar;
				decoderFallbackBuffer = baseDecoder.FallbackBuffer;
			}
			else
			{
				decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
			}
			decoderFallbackBuffer.InternalInitialize(bytes, chars + charCount);
			while (bytes < ptr4)
			{
				if (this._bigEndian)
				{
					num2 <<= 8;
					num2 += (uint)(*(bytes++));
				}
				else
				{
					num2 >>= 8;
					num2 += (uint)((uint)(*(bytes++)) << 24);
				}
				num++;
				if (num >= 4)
				{
					num = 0;
					if (num2 > 1114111U || (num2 >= 55296U && num2 <= 57343U))
					{
						byte[] bytes2;
						if (this._bigEndian)
						{
							bytes2 = new byte[]
							{
								(byte)(num2 >> 24),
								(byte)(num2 >> 16),
								(byte)(num2 >> 8),
								(byte)num2
							};
						}
						else
						{
							bytes2 = new byte[]
							{
								(byte)num2,
								(byte)(num2 >> 8),
								(byte)(num2 >> 16),
								(byte)(num2 >> 24)
							};
						}
						char* ptr5 = chars;
						bool flag = decoderFallbackBuffer.InternalFallback(bytes2, bytes, ref ptr5);
						chars = ptr5;
						if (!flag)
						{
							bytes -= 4;
							num2 = 0U;
							decoderFallbackBuffer.InternalReset();
							base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
							break;
						}
						num2 = 0U;
					}
					else
					{
						if (num2 >= 65536U)
						{
							if (chars >= ptr2 - 1)
							{
								bytes -= 4;
								num2 = 0U;
								base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
								break;
							}
							*(chars++) = this.GetHighSurrogate(num2);
							num2 = (uint)this.GetLowSurrogate(num2);
						}
						else if (chars >= ptr2)
						{
							bytes -= 4;
							num2 = 0U;
							base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
							break;
						}
						*(chars++) = (char)num2;
						num2 = 0U;
					}
				}
			}
			if (num > 0 && (utf32Decoder == null || utf32Decoder.MustFlush))
			{
				byte[] array = new byte[num];
				int i = num;
				if (this._bigEndian)
				{
					while (i > 0)
					{
						array[--i] = (byte)num2;
						num2 >>= 8;
					}
				}
				else
				{
					while (i > 0)
					{
						array[--i] = (byte)(num2 >> 24);
						num2 <<= 8;
					}
				}
				char* ptr5 = chars;
				bool flag2 = decoderFallbackBuffer.InternalFallback(array, bytes, ref ptr5);
				chars = ptr5;
				if (!flag2)
				{
					decoderFallbackBuffer.InternalReset();
					base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
				}
				else
				{
					num = 0;
					num2 = 0U;
				}
			}
			if (utf32Decoder != null)
			{
				utf32Decoder.iChar = (int)num2;
				utf32Decoder.readByteCount = num;
				utf32Decoder._bytesUsed = (int)((long)(bytes - ptr3));
			}
			return (int)((long)(chars - ptr));
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0008B7F7 File Offset: 0x000899F7
		private uint GetSurrogate(char cHigh, char cLow)
		{
			return (uint)((cHigh - '\ud800') * 'Ѐ' + (cLow - '\udc00')) + 65536U;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0008B814 File Offset: 0x00089A14
		private char GetHighSurrogate(uint iChar)
		{
			return (char)((iChar - 65536U) / 1024U + 55296U);
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x0008B82A File Offset: 0x00089A2A
		private char GetLowSurrogate(uint iChar)
		{
			return (char)((iChar - 65536U) % 1024U + 56320U);
		}

		/// <summary>Получает средство декодирования, преобразующее последовательность байтов в кодировке UTF-32 в последовательность символов Юникода.</summary>
		/// <returns>Объект <see cref="T:System.Text.Decoder" />, преобразующий последовательность байтов в кодировке UTF-32 в последовательность символов Юникода.</returns>
		// Token: 0x060026FC RID: 9980 RVA: 0x0008B840 File Offset: 0x00089A40
		public override Decoder GetDecoder()
		{
			return new UTF32Encoding.UTF32Decoder(this);
		}

		/// <summary>Получает средство кодирования, преобразующее последовательность символов Юникода в последовательность байтов в кодировке UTF-32.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoder" />, преобразующий последовательность символов Юникода в последовательность байтов в кодировке UTF-32.</returns>
		// Token: 0x060026FD RID: 9981 RVA: 0x000857B4 File Offset: 0x000839B4
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
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
		// Token: 0x060026FE RID: 9982 RVA: 0x0008B848 File Offset: 0x00089A48
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
			num *= 4L;
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
		// Token: 0x060026FF RID: 9983 RVA: 0x0008B8AC File Offset: 0x00089AAC
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			int num = byteCount / 2 + 2;
			if (base.DecoderFallback.MaxCharCount > 2)
			{
				num *= base.DecoderFallback.MaxCharCount;
				num /= 2;
			}
			if (num > 2147483647)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Too many bytes. The resulting number of chars is larger than what can be returned as an int.");
			}
			return num;
		}

		/// <summary>Возвращает метку порядка байтов Юникода в кодировке UTF-32, если объект <see cref="T:System.Text.UTF32Encoding" /> настроен для ее предоставления.</summary>
		/// <returns>Массив байтов, содержащий метку порядка байтов Юникода, если объект <see cref="T:System.Text.UTF32Encoding" /> настроен для его предоставления. В противном случае этот метод возвращает массив байтов нулевой длины.</returns>
		// Token: 0x06002700 RID: 9984 RVA: 0x0008B90C File Offset: 0x00089B0C
		public override byte[] GetPreamble()
		{
			if (!this._emitUTF32ByteOrderMark)
			{
				return Array.Empty<byte>();
			}
			if (this._bigEndian)
			{
				return new byte[]
				{
					0,
					0,
					254,
					byte.MaxValue
				};
			}
			byte[] array = new byte[4];
			array[0] = byte.MaxValue;
			array[1] = 254;
			return array;
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x0008B95C File Offset: 0x00089B5C
		public override ReadOnlySpan<byte> Preamble
		{
			get
			{
				return (base.GetType() != typeof(UTF32Encoding)) ? this.GetPreamble() : (this._emitUTF32ByteOrderMark ? (this._bigEndian ? UTF32Encoding.s_bigEndianPreamble : UTF32Encoding.s_littleEndianPreamble) : Array.Empty<byte>());
			}
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Text.UTF32Encoding" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> является экземпляром класса <see cref="T:System.Text.UTF32Encoding" /> и равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002702 RID: 9986 RVA: 0x0008B9B0 File Offset: 0x00089BB0
		public override bool Equals(object value)
		{
			UTF32Encoding utf32Encoding = value as UTF32Encoding;
			return utf32Encoding != null && (this._emitUTF32ByteOrderMark == utf32Encoding._emitUTF32ByteOrderMark && this._bigEndian == utf32Encoding._bigEndian && base.EncoderFallback.Equals(utf32Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf32Encoding.DecoderFallback);
		}

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Text.UTF32Encoding" />.</returns>
		// Token: 0x06002703 RID: 9987 RVA: 0x0008BA0B File Offset: 0x00089C0B
		public override int GetHashCode()
		{
			return base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + this.CodePage + (this._emitUTF32ByteOrderMark ? 4 : 0) + (this._bigEndian ? 8 : 0);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x0008BA48 File Offset: 0x00089C48
		// Note: this type is marked as 'beforefieldinit'.
		static UTF32Encoding()
		{
			byte[] array = new byte[4];
			array[0] = byte.MaxValue;
			array[1] = 254;
			UTF32Encoding.s_littleEndianPreamble = array;
		}

		// Token: 0x04001DE0 RID: 7648
		internal static readonly UTF32Encoding s_default = new UTF32Encoding(false, true);

		// Token: 0x04001DE1 RID: 7649
		internal static readonly UTF32Encoding s_bigEndianDefault = new UTF32Encoding(true, true);

		// Token: 0x04001DE2 RID: 7650
		private static readonly byte[] s_bigEndianPreamble = new byte[]
		{
			0,
			0,
			254,
			byte.MaxValue
		};

		// Token: 0x04001DE3 RID: 7651
		private static readonly byte[] s_littleEndianPreamble;

		// Token: 0x04001DE4 RID: 7652
		private bool _emitUTF32ByteOrderMark;

		// Token: 0x04001DE5 RID: 7653
		private bool _isThrowException;

		// Token: 0x04001DE6 RID: 7654
		private bool _bigEndian;

		// Token: 0x020003AE RID: 942
		[Serializable]
		private sealed class UTF32Decoder : DecoderNLS
		{
			// Token: 0x06002705 RID: 9989 RVA: 0x0008BAA3 File Offset: 0x00089CA3
			public UTF32Decoder(UTF32Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002706 RID: 9990 RVA: 0x0008BAAC File Offset: 0x00089CAC
			public override void Reset()
			{
				this.iChar = 0;
				this.readByteCount = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x170004BD RID: 1213
			// (get) Token: 0x06002707 RID: 9991 RVA: 0x0008BACF File Offset: 0x00089CCF
			internal override bool HasState
			{
				get
				{
					return this.readByteCount != 0;
				}
			}

			// Token: 0x04001DE7 RID: 7655
			internal int iChar;

			// Token: 0x04001DE8 RID: 7656
			internal int readByteCount;
		}
	}
}
