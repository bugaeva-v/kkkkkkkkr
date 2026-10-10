using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Представляет кодировку ASCII символов Юникода.</summary>
	// Token: 0x0200038E RID: 910
	[Serializable]
	public class ASCIIEncoding : Encoding
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.ASCIIEncoding" />.</summary>
		// Token: 0x06002570 RID: 9584 RVA: 0x00084BAE File Offset: 0x00082DAE
		public ASCIIEncoding() : base(20127)
		{
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00084BBB File Offset: 0x00082DBB
		internal override void SetDefaultFallbacks()
		{
			this.encoderFallback = EncoderFallback.ReplacementFallback;
			this.decoderFallback = DecoderFallback.ReplacementFallback;
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
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002572 RID: 9586 RVA: 0x00084BD4 File Offset: 0x00082DD4
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
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002573 RID: 9587 RVA: 0x00084C5C File Offset: 0x00082E5C
		public unsafe override int GetByteCount(string chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars");
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
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002574 RID: 9588 RVA: 0x00084C95 File Offset: 0x00082E95
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
		/// <param name="chars">Объект <see cref="T:System.String" />, содержащий кодируемый набор символов.</param>
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
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002575 RID: 9589 RVA: 0x00084CCC File Offset: 0x00082ECC
		public unsafe override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
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
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the string.");
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr = chars;
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
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="bytes" /> от <paramref name="byteIndex" /> до конца массива для размещения полученных байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002576 RID: 9590 RVA: 0x00084D94 File Offset: 0x00082F94
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
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="byteCount" /> меньше результирующего числа байтов.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002577 RID: 9591 RVA: 0x00084E64 File Offset: 0x00083064
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
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002578 RID: 9592 RVA: 0x00084EC8 File Offset: 0x000830C8
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
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002579 RID: 9593 RVA: 0x00084F4B File Offset: 0x0008314B
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
		/// <exception cref="T:System.ArgumentException">Недостаточно емкости <paramref name="chars" /> от <paramref name="charIndex" /> до конца массива для размещения полученных символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600257A RID: 9594 RVA: 0x00084F80 File Offset: 0x00083180
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
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="charCount" /> меньше результирующего числа символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600257B RID: 9595 RVA: 0x00085050 File Offset: 0x00083250
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
		/// <param name="byteIndex">Индекс первого декодируемого байта.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <returns>Объект <see cref="T:System.String" />, содержащий результаты декодирования заданной последовательности байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="bytes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600257C RID: 9596 RVA: 0x000850B4 File Offset: 0x000832B4
		public unsafe override string GetString(byte[] bytes, int byteIndex, int byteCount)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (byteCount == 0)
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
			return string.CreateStringFromEncoding(ptr + byteIndex, byteCount, this);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x0008513C File Offset: 0x0008333C
		internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
		{
			char c = '\0';
			char* ptr = chars + charCount;
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			EncoderReplacementFallback encoderReplacementFallback;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				encoderReplacementFallback = (encoder.Fallback as EncoderReplacementFallback);
				if (encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0 && encoder._throwOnOverflow)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, false);
				}
			}
			else
			{
				encoderReplacementFallback = (base.EncoderFallback as EncoderReplacementFallback);
			}
			if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1)
			{
				if (c > '\0')
				{
					charCount++;
				}
				return charCount;
			}
			int num = 0;
			if (c > '\0')
			{
				encoderFallbackBuffer = encoder.FallbackBuffer;
				encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, false);
				char* ptr2 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr2);
				chars = ptr2;
			}
			char c2;
			while ((c2 = ((encoderFallbackBuffer == null) ? '\0' : encoderFallbackBuffer.InternalGetNextChar())) != '\0' || chars < ptr)
			{
				if (c2 == '\0')
				{
					c2 = *chars;
					chars++;
				}
				if (c2 > '\u007f')
				{
					if (encoderFallbackBuffer == null)
					{
						if (encoder == null)
						{
							encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
						}
						else
						{
							encoderFallbackBuffer = encoder.FallbackBuffer;
						}
						encoderFallbackBuffer.InternalInitialize(ptr - charCount, ptr, encoder, false);
					}
					char* ptr2 = chars;
					encoderFallbackBuffer.InternalFallback(c2, ref ptr2);
					chars = ptr2;
				}
				else
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00085278 File Offset: 0x00083478
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			char c = '\0';
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			char* ptr = chars + charCount;
			byte* ptr2 = bytes;
			char* ptr3 = chars;
			EncoderReplacementFallback encoderReplacementFallback;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				encoderReplacementFallback = (encoder.Fallback as EncoderReplacementFallback);
				if (encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0 && encoder._throwOnOverflow)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(ptr3, ptr, encoder, true);
				}
			}
			else
			{
				encoderReplacementFallback = (base.EncoderFallback as EncoderReplacementFallback);
			}
			if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1)
			{
				char c2 = encoderReplacementFallback.DefaultString[0];
				if (c2 <= '\u007f')
				{
					if (c > '\0')
					{
						if (byteCount == 0)
						{
							base.ThrowBytesOverflow(encoder, true);
						}
						*(bytes++) = (byte)c2;
						byteCount--;
					}
					if (byteCount < charCount)
					{
						base.ThrowBytesOverflow(encoder, byteCount < 1);
						ptr = chars + byteCount;
					}
					while (chars < ptr)
					{
						char c3 = *(chars++);
						if (c3 >= '\u0080')
						{
							*(bytes++) = (byte)c2;
						}
						else
						{
							*(bytes++) = (byte)c3;
						}
					}
					if (encoder != null)
					{
						encoder._charLeftOver = '\0';
						encoder._charsUsed = (int)((long)(chars - ptr3));
					}
					return (int)((long)(bytes - ptr2));
				}
			}
			byte* ptr4 = bytes + byteCount;
			if (c > '\0')
			{
				encoderFallbackBuffer = encoder.FallbackBuffer;
				encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, true);
				char* ptr5 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr5);
				chars = ptr5;
			}
			char c4;
			while ((c4 = ((encoderFallbackBuffer == null) ? '\0' : encoderFallbackBuffer.InternalGetNextChar())) != '\0' || chars < ptr)
			{
				if (c4 == '\0')
				{
					c4 = *chars;
					chars++;
				}
				if (c4 > '\u007f')
				{
					if (encoderFallbackBuffer == null)
					{
						if (encoder == null)
						{
							encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
						}
						else
						{
							encoderFallbackBuffer = encoder.FallbackBuffer;
						}
						encoderFallbackBuffer.InternalInitialize(ptr - charCount, ptr, encoder, true);
					}
					char* ptr5 = chars;
					encoderFallbackBuffer.InternalFallback(c4, ref ptr5);
					chars = ptr5;
				}
				else
				{
					if (bytes >= ptr4)
					{
						if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
						{
							chars--;
						}
						else
						{
							encoderFallbackBuffer.MovePrevious();
						}
						base.ThrowBytesOverflow(encoder, bytes == ptr2);
						break;
					}
					*bytes = (byte)c4;
					bytes++;
				}
			}
			if (encoder != null)
			{
				if (encoderFallbackBuffer != null && !encoderFallbackBuffer.bUsedEncoder)
				{
					encoder._charLeftOver = '\0';
				}
				encoder._charsUsed = (int)((long)(chars - ptr3));
			}
			return (int)((long)(bytes - ptr2));
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000854D4 File Offset: 0x000836D4
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			DecoderReplacementFallback decoderReplacementFallback;
			if (decoder == null)
			{
				decoderReplacementFallback = (base.DecoderFallback as DecoderReplacementFallback);
			}
			else
			{
				decoderReplacementFallback = (decoder.Fallback as DecoderReplacementFallback);
			}
			if (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1)
			{
				return count;
			}
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			int num = count;
			byte[] array = new byte[1];
			byte* ptr = bytes + count;
			while (bytes < ptr)
			{
				byte b = *bytes;
				bytes++;
				if (b >= 128)
				{
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = base.DecoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(ptr - count, null);
					}
					array[0] = b;
					num--;
					num += decoderFallbackBuffer.InternalFallback(array, bytes);
				}
			}
			return num;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00085574 File Offset: 0x00083774
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			byte* ptr = bytes + byteCount;
			byte* ptr2 = bytes;
			char* ptr3 = chars;
			DecoderReplacementFallback decoderReplacementFallback;
			if (decoder == null)
			{
				decoderReplacementFallback = (base.DecoderFallback as DecoderReplacementFallback);
			}
			else
			{
				decoderReplacementFallback = (decoder.Fallback as DecoderReplacementFallback);
			}
			if (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1)
			{
				char c = decoderReplacementFallback.DefaultString[0];
				if (charCount < byteCount)
				{
					base.ThrowCharsOverflow(decoder, charCount < 1);
					ptr = bytes + charCount;
				}
				while (bytes < ptr)
				{
					byte b = *(bytes++);
					if (b >= 128)
					{
						*(chars++) = c;
					}
					else
					{
						*(chars++) = (char)b;
					}
				}
				if (decoder != null)
				{
					decoder._bytesUsed = (int)((long)(bytes - ptr2));
				}
				return (int)((long)(chars - ptr3));
			}
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			byte[] array = new byte[1];
			char* ptr4 = chars + charCount;
			while (bytes < ptr)
			{
				byte b2 = *bytes;
				bytes++;
				if (b2 >= 128)
				{
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = base.DecoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(ptr - byteCount, ptr4);
					}
					array[0] = b2;
					char* ptr5 = chars;
					bool flag = decoderFallbackBuffer.InternalFallback(array, bytes, ref ptr5);
					chars = ptr5;
					if (!flag)
					{
						bytes--;
						decoderFallbackBuffer.InternalReset();
						base.ThrowCharsOverflow(decoder, chars == ptr3);
						break;
					}
				}
				else
				{
					if (chars >= ptr4)
					{
						bytes--;
						base.ThrowCharsOverflow(decoder, chars == ptr3);
						break;
					}
					*chars = (char)b2;
					chars++;
				}
			}
			if (decoder != null)
			{
				decoder._bytesUsed = (int)((long)(bytes - ptr2));
			}
			return (int)((long)(chars - ptr3));
		}

		/// <summary>Вычисляет максимальное количество байтов, полученных при кодировании заданного числа символов.</summary>
		/// <param name="charCount">Число кодируемых символов.</param>
		/// <returns>Максимальное количество байтов, полученных при кодировании заданного количества символов.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		// Token: 0x06002581 RID: 9601 RVA: 0x000856F0 File Offset: 0x000838F0
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
		// Token: 0x06002582 RID: 9602 RVA: 0x00085750 File Offset: 0x00083950
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			long num = (long)byteCount;
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

		/// <summary>Получает значение, указывающее, используются ли в текущей кодировке однобайтовые кодовые точки.</summary>
		/// <returns>Данное свойство всегда имеет значение <see langword="true" />.</returns>
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000040F7 File Offset: 0x000022F7
		public override bool IsSingleByte
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает декодер, преобразующий ASCII-закодированную последовательность байтов в последовательность символов Юникода.</summary>
		/// <returns>Объект <see cref="T:System.Text.Decoder" />, преобразующий ASCII-закодированную последовательность байтов в последовательность символов Юникода.</returns>
		// Token: 0x06002584 RID: 9604 RVA: 0x000857AC File Offset: 0x000839AC
		public override Decoder GetDecoder()
		{
			return new DecoderNLS(this);
		}

		/// <summary>Получает кодировщик, преобразующий последовательность символов Юникода в ASCII-закодированную последовательность байтов.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoder" />, преобразующий последовательность символов Юникода в ASCII-закодированную последовательность байтов.</returns>
		// Token: 0x06002585 RID: 9605 RVA: 0x000857B4 File Offset: 0x000839B4
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		// Token: 0x04001D8B RID: 7563
		internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default = new ASCIIEncoding.ASCIIEncodingSealed();

		// Token: 0x0200038F RID: 911
		internal sealed class ASCIIEncodingSealed : ASCIIEncoding
		{
		}
	}
}
