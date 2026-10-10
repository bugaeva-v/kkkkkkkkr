using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Представляет кодировку UTF-7 символов Юникода.</summary>
	// Token: 0x020003AF RID: 943
	[Serializable]
	public class UTF7Encoding : Encoding
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF7Encoding" />.</summary>
		// Token: 0x06002708 RID: 9992 RVA: 0x0008BADA File Offset: 0x00089CDA
		public UTF7Encoding() : this(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.UTF7Encoding" />. Параметр указывает, разрешены ли дополнительные символы.</summary>
		/// <param name="allowOptionals">Значение <see langword="true" /> указывает, что дополнительные символы разрешены; в противном случае используется значение <see langword="false" />.</param>
		// Token: 0x06002709 RID: 9993 RVA: 0x0008BAE3 File Offset: 0x00089CE3
		public UTF7Encoding(bool allowOptionals) : base(65000)
		{
			this._allowOptionals = allowOptionals;
			this.MakeTables();
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0008BB00 File Offset: 0x00089D00
		private void MakeTables()
		{
			this._base64Bytes = new byte[64];
			for (int i = 0; i < 64; i++)
			{
				this._base64Bytes[i] = (byte)"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"[i];
			}
			this._base64Values = new sbyte[128];
			for (int j = 0; j < 128; j++)
			{
				this._base64Values[j] = -1;
			}
			for (int k = 0; k < 64; k++)
			{
				this._base64Values[(int)this._base64Bytes[k]] = (sbyte)k;
			}
			this._directEncode = new bool[128];
			int length = "\t\n\r '(),-./0123456789:?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Length;
			for (int l = 0; l < length; l++)
			{
				this._directEncode[(int)"\t\n\r '(),-./0123456789:?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"[l]] = true;
			}
			if (this._allowOptionals)
			{
				length = "!\"#$%&*;<=>@[]^_`{|}".Length;
				for (int m = 0; m < length; m++)
				{
					this._directEncode[(int)"!\"#$%&*;<=>@[]^_`{|}"[m]] = true;
				}
			}
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0008BBF8 File Offset: 0x00089DF8
		internal override void SetDefaultFallbacks()
		{
			this.encoderFallback = new EncoderReplacementFallback(string.Empty);
			this.decoderFallback = new UTF7Encoding.DecoderUTF7Fallback();
		}

		/// <summary>Возвращает значение, позволяющее определить, равен ли указанный объект текущему объекту <see cref="T:System.Text.UTF7Encoding" />.</summary>
		/// <param name="value">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Text.UTF7Encoding" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> является объектом <see cref="T:System.Text.UTF7Encoding" /> и равен текущему объекту <see cref="T:System.Text.UTF7Encoding" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600270C RID: 9996 RVA: 0x0008BC18 File Offset: 0x00089E18
		public override bool Equals(object value)
		{
			UTF7Encoding utf7Encoding = value as UTF7Encoding;
			return utf7Encoding != null && (this._allowOptionals == utf7Encoding._allowOptionals && base.EncoderFallback.Equals(utf7Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf7Encoding.DecoderFallback);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Text.UTF7Encoding" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600270D RID: 9997 RVA: 0x0008BC65 File Offset: 0x00089E65
		public override int GetHashCode()
		{
			return this.CodePage + base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode();
		}

		/// <summary>Вычисляет число байтов, полученных при кодировании набора символов из указанного массива символов.</summary>
		/// <param name="chars">Массив символов, содержащий набор кодируемых символов.</param>
		/// <param name="index">Индекс первого кодируемого символа.</param>
		/// <param name="count">Число кодируемых символов.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
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
		// Token: 0x0600270E RID: 9998 RVA: 0x0008BC88 File Offset: 0x00089E88
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

		/// <summary>Вычисляет количество байтов, полученных при кодировании символов в указанном объекте <see cref="T:System.String" />.</summary>
		/// <param name="s">Объект <see cref="T:System.String" />, содержащий набор символов для кодирования.</param>
		/// <returns>Число байтов, полученных при кодировании заданных символов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600270F RID: 9999 RVA: 0x0008BD10 File Offset: 0x00089F10
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
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="chars" /> равно <see langword="null" /> (<see langword="Nothing" /> в Visual Basic .NET).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число байтов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002710 RID: 10000 RVA: 0x00084C95 File Offset: 0x00082E95
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
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).  
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
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002711 RID: 10001 RVA: 0x0008BD4C File Offset: 0x00089F4C
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
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002712 RID: 10002 RVA: 0x0008BE14 File Offset: 0x0008A014
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
		/// Параметру <see cref="P:System.Text.Encoding.EncoderFallback" /> задается значение <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06002713 RID: 10003 RVA: 0x0008BEE4 File Offset: 0x0008A0E4
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
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.  
		///
		/// или - 
		/// Результирующее число символов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002714 RID: 10004 RVA: 0x0008BF48 File Offset: 0x0008A148
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
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Результирующее число символов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002715 RID: 10005 RVA: 0x00084F4B File Offset: 0x0008314B
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
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).  
		///
		/// или - 
		/// <paramref name="chars" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
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
		// Token: 0x06002716 RID: 10006 RVA: 0x0008BFCC File Offset: 0x0008A1CC
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
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).  
		///
		/// или - 
		/// <paramref name="chars" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> или <paramref name="charCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="charCount" /> меньше результирующего числа символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002717 RID: 10007 RVA: 0x0008C09C File Offset: 0x0008A29C
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
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002718 RID: 10008 RVA: 0x0008C100 File Offset: 0x0008A300
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

		// Token: 0x06002719 RID: 10009 RVA: 0x0008C186 File Offset: 0x0008A386
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			return this.GetBytes(chars, count, null, 0, baseEncoder);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0008C194 File Offset: 0x0008A394
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			UTF7Encoding.Encoder encoder = (UTF7Encoding.Encoder)baseEncoder;
			int num = 0;
			int i = -1;
			Encoding.EncodingByteBuffer encodingByteBuffer = new Encoding.EncodingByteBuffer(this, encoder, bytes, byteCount, chars, charCount);
			if (encoder != null)
			{
				num = encoder.bits;
				i = encoder.bitCount;
				while (i >= 6)
				{
					i -= 6;
					if (!encodingByteBuffer.AddByte(this._base64Bytes[num >> i & 63]))
					{
						base.ThrowBytesOverflow(encoder, encodingByteBuffer.Count == 0);
					}
				}
			}
			while (encodingByteBuffer.MoreData)
			{
				char nextChar = encodingByteBuffer.GetNextChar();
				if (nextChar < '\u0080' && this._directEncode[(int)nextChar])
				{
					if (i >= 0)
					{
						if (i > 0)
						{
							if (!encodingByteBuffer.AddByte(this._base64Bytes[num << 6 - i & 63]))
							{
								break;
							}
							i = 0;
						}
						if (!encodingByteBuffer.AddByte(45))
						{
							break;
						}
						i = -1;
					}
					if (!encodingByteBuffer.AddByte((byte)nextChar))
					{
						break;
					}
				}
				else if (i < 0 && nextChar == '+')
				{
					if (!encodingByteBuffer.AddByte(43, 45))
					{
						break;
					}
				}
				else
				{
					if (i < 0)
					{
						if (!encodingByteBuffer.AddByte(43))
						{
							break;
						}
						i = 0;
					}
					num = (num << 16 | (int)nextChar);
					i += 16;
					while (i >= 6)
					{
						i -= 6;
						if (!encodingByteBuffer.AddByte(this._base64Bytes[num >> i & 63]))
						{
							i += 6;
							nextChar = encodingByteBuffer.GetNextChar();
							break;
						}
					}
					if (i >= 6)
					{
						break;
					}
				}
			}
			if (i >= 0 && (encoder == null || encoder.MustFlush))
			{
				if (i > 0 && encodingByteBuffer.AddByte(this._base64Bytes[num << 6 - i & 63]))
				{
					i = 0;
				}
				if (encodingByteBuffer.AddByte(45))
				{
					num = 0;
					i = -1;
				}
				else
				{
					encodingByteBuffer.GetNextChar();
				}
			}
			if (bytes != null && encoder != null)
			{
				encoder.bits = num;
				encoder.bitCount = i;
				encoder._charsUsed = encodingByteBuffer.CharsUsed;
			}
			return encodingByteBuffer.Count;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0008C346 File Offset: 0x0008A546
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			return this.GetChars(bytes, count, null, 0, baseDecoder);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0008C354 File Offset: 0x0008A554
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UTF7Encoding.Decoder decoder = (UTF7Encoding.Decoder)baseDecoder;
			Encoding.EncodingCharBuffer encodingCharBuffer = new Encoding.EncodingCharBuffer(this, decoder, chars, charCount, bytes, byteCount);
			int num = 0;
			int num2 = -1;
			bool flag = false;
			if (decoder != null)
			{
				num = decoder.bits;
				num2 = decoder.bitCount;
				flag = decoder.firstByte;
			}
			if (num2 >= 16)
			{
				if (!encodingCharBuffer.AddChar((char)(num >> num2 - 16 & 65535)))
				{
					base.ThrowCharsOverflow(decoder, true);
				}
				num2 -= 16;
			}
			while (encodingCharBuffer.MoreData)
			{
				byte nextByte = encodingCharBuffer.GetNextByte();
				int num3;
				if (num2 >= 0)
				{
					sbyte b;
					if (nextByte < 128 && (b = this._base64Values[(int)nextByte]) >= 0)
					{
						flag = false;
						num = (num << 6 | (int)((byte)b));
						num2 += 6;
						if (num2 < 16)
						{
							continue;
						}
						num3 = (num >> num2 - 16 & 65535);
						num2 -= 16;
					}
					else
					{
						num2 = -1;
						if (nextByte != 45)
						{
							if (!encodingCharBuffer.Fallback(nextByte))
							{
								break;
							}
							continue;
						}
						else
						{
							if (!flag)
							{
								continue;
							}
							num3 = 43;
						}
					}
				}
				else
				{
					if (nextByte == 43)
					{
						num2 = 0;
						flag = true;
						continue;
					}
					if (nextByte >= 128)
					{
						if (!encodingCharBuffer.Fallback(nextByte))
						{
							break;
						}
						continue;
					}
					else
					{
						num3 = (int)nextByte;
					}
				}
				if (num3 >= 0 && !encodingCharBuffer.AddChar((char)num3))
				{
					if (num2 >= 0)
					{
						encodingCharBuffer.AdjustBytes(1);
						num2 += 16;
						break;
					}
					break;
				}
			}
			if (chars != null && decoder != null)
			{
				if (decoder.MustFlush)
				{
					decoder.bits = 0;
					decoder.bitCount = -1;
					decoder.firstByte = false;
				}
				else
				{
					decoder.bits = num;
					decoder.bitCount = num2;
					decoder.firstByte = flag;
				}
				decoder._bytesUsed = encodingCharBuffer.BytesUsed;
			}
			return encodingCharBuffer.Count;
		}

		/// <summary>Получает средство декодирования, преобразующее последовательность байтов в кодировке UTF-7 в последовательность символов Юникода.</summary>
		/// <returns>Объект <see cref="T:System.Text.Decoder" />, преобразующий последовательность байтов в кодировке UTF-7 в последовательность символов Юникода.</returns>
		// Token: 0x0600271D RID: 10013 RVA: 0x0008C4D8 File Offset: 0x0008A6D8
		public override System.Text.Decoder GetDecoder()
		{
			return new UTF7Encoding.Decoder(this);
		}

		/// <summary>Получает средство кодирования, преобразующее последовательность символов Юникода в последовательность байтов в кодировке UTF-7.</summary>
		/// <returns>
		///   <see cref="T:System.Text.Encoder" />, преобразующий последовательность символов Юникода в последовательность байтов в кодировке UTF-7.</returns>
		// Token: 0x0600271E RID: 10014 RVA: 0x0008C4E0 File Offset: 0x0008A6E0
		public override System.Text.Encoder GetEncoder()
		{
			return new UTF7Encoding.Encoder(this);
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
		// Token: 0x0600271F RID: 10015 RVA: 0x0008C4E8 File Offset: 0x0008A6E8
		public override int GetMaxByteCount(int charCount)
		{
			if (charCount < 0)
			{
				throw new ArgumentOutOfRangeException("charCount", "Non-negative number required.");
			}
			long num = (long)charCount * 3L + 2L;
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
		/// Результирующее число символов больше максимального количества, которое можно вернуть как целочисленное значение.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошел откат (полное объяснение см. в статье Кодировка символов в .NET Framework). 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Encoding.DecoderFallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002720 RID: 10016 RVA: 0x0008C520 File Offset: 0x0008A720
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			int num = byteCount;
			if (num == 0)
			{
				num = 1;
			}
			return num;
		}

		// Token: 0x04001DE9 RID: 7657
		private const string base64Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

		// Token: 0x04001DEA RID: 7658
		private const string directChars = "\t\n\r '(),-./0123456789:?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		// Token: 0x04001DEB RID: 7659
		private const string optionalChars = "!\"#$%&*;<=>@[]^_`{|}";

		// Token: 0x04001DEC RID: 7660
		internal static readonly UTF7Encoding s_default = new UTF7Encoding();

		// Token: 0x04001DED RID: 7661
		private byte[] _base64Bytes;

		// Token: 0x04001DEE RID: 7662
		private sbyte[] _base64Values;

		// Token: 0x04001DEF RID: 7663
		private bool[] _directEncode;

		// Token: 0x04001DF0 RID: 7664
		private bool _allowOptionals;

		// Token: 0x04001DF1 RID: 7665
		private const int UTF7_CODEPAGE = 65000;

		// Token: 0x020003B0 RID: 944
		[Serializable]
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x06002722 RID: 10018 RVA: 0x0008BAA3 File Offset: 0x00089CA3
			public Decoder(UTF7Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002723 RID: 10019 RVA: 0x0008C555 File Offset: 0x0008A755
			public override void Reset()
			{
				this.bits = 0;
				this.bitCount = -1;
				this.firstByte = false;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x06002724 RID: 10020 RVA: 0x0008C57F File Offset: 0x0008A77F
			internal override bool HasState
			{
				get
				{
					return this.bitCount != -1;
				}
			}

			// Token: 0x04001DF2 RID: 7666
			internal int bits;

			// Token: 0x04001DF3 RID: 7667
			internal int bitCount;

			// Token: 0x04001DF4 RID: 7668
			internal bool firstByte;
		}

		// Token: 0x020003B1 RID: 945
		[Serializable]
		private sealed class Encoder : EncoderNLS
		{
			// Token: 0x06002725 RID: 10021 RVA: 0x0008C58D File Offset: 0x0008A78D
			public Encoder(UTF7Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002726 RID: 10022 RVA: 0x0008C596 File Offset: 0x0008A796
			public override void Reset()
			{
				this.bitCount = -1;
				this.bits = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x170004BF RID: 1215
			// (get) Token: 0x06002727 RID: 10023 RVA: 0x0008C5B9 File Offset: 0x0008A7B9
			internal override bool HasState
			{
				get
				{
					return this.bits != 0 || this.bitCount != -1;
				}
			}

			// Token: 0x04001DF5 RID: 7669
			internal int bits;

			// Token: 0x04001DF6 RID: 7670
			internal int bitCount;
		}

		// Token: 0x020003B2 RID: 946
		[Serializable]
		private sealed class DecoderUTF7Fallback : DecoderFallback
		{
			// Token: 0x06002729 RID: 10025 RVA: 0x0008C5D1 File Offset: 0x0008A7D1
			public override DecoderFallbackBuffer CreateFallbackBuffer()
			{
				return new UTF7Encoding.DecoderUTF7FallbackBuffer(this);
			}

			// Token: 0x170004C0 RID: 1216
			// (get) Token: 0x0600272A RID: 10026 RVA: 0x000040F7 File Offset: 0x000022F7
			public override int MaxCharCount
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x0600272B RID: 10027 RVA: 0x0008C5D9 File Offset: 0x0008A7D9
			public override bool Equals(object value)
			{
				return value is UTF7Encoding.DecoderUTF7Fallback;
			}

			// Token: 0x0600272C RID: 10028 RVA: 0x0008C5E6 File Offset: 0x0008A7E6
			public override int GetHashCode()
			{
				return 984;
			}
		}

		// Token: 0x020003B3 RID: 947
		private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
		{
			// Token: 0x0600272D RID: 10029 RVA: 0x0008C5ED File Offset: 0x0008A7ED
			public DecoderUTF7FallbackBuffer(UTF7Encoding.DecoderUTF7Fallback fallback)
			{
			}

			// Token: 0x0600272E RID: 10030 RVA: 0x0008C5FC File Offset: 0x0008A7FC
			public override bool Fallback(byte[] bytesUnknown, int index)
			{
				this.cFallback = (char)bytesUnknown[0];
				if (this.cFallback == '\0')
				{
					return false;
				}
				this.iCount = (this.iSize = 1);
				return true;
			}

			// Token: 0x0600272F RID: 10031 RVA: 0x0008C630 File Offset: 0x0008A830
			public override char GetNextChar()
			{
				int num = this.iCount;
				this.iCount = num - 1;
				if (num > 0)
				{
					return this.cFallback;
				}
				return '\0';
			}

			// Token: 0x06002730 RID: 10032 RVA: 0x0008C659 File Offset: 0x0008A859
			public override bool MovePrevious()
			{
				if (this.iCount >= 0)
				{
					this.iCount++;
				}
				return this.iCount >= 0 && this.iCount <= this.iSize;
			}

			// Token: 0x170004C1 RID: 1217
			// (get) Token: 0x06002731 RID: 10033 RVA: 0x0008C68E File Offset: 0x0008A88E
			public override int Remaining
			{
				get
				{
					if (this.iCount <= 0)
					{
						return 0;
					}
					return this.iCount;
				}
			}

			// Token: 0x06002732 RID: 10034 RVA: 0x0008C6A1 File Offset: 0x0008A8A1
			public override void Reset()
			{
				this.iCount = -1;
				this.byteStart = null;
			}

			// Token: 0x06002733 RID: 10035 RVA: 0x0008C6B2 File Offset: 0x0008A8B2
			internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
			{
				if (bytes.Length != 1)
				{
					throw new ArgumentException("String contains invalid Unicode code points.");
				}
				if (bytes[0] != 0)
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x04001DF7 RID: 7671
			private char cFallback;

			// Token: 0x04001DF8 RID: 7672
			private int iCount = -1;

			// Token: 0x04001DF9 RID: 7673
			private int iSize;
		}
	}
}
