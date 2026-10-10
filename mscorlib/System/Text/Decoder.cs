using System;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Конвертирует последовательность закодированных байтов в набор символов.</summary>
	// Token: 0x02000390 RID: 912
	[Serializable]
	public abstract class Decoder
	{
		/// <summary>Получает или задает объект <see cref="T:System.Text.DecoderFallback" /> для текущего объекта <see cref="T:System.Text.Decoder" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.DecoderFallback" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции задания значением является <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentException">Невозможно задать новое значение, поскольку текущий объект <see cref="T:System.Text.DecoderFallbackBuffer" /> содержит данные, которые еще не были декодированы.</exception>
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x000857D0 File Offset: 0x000839D0
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x000857D8 File Offset: 0x000839D8
		public DecoderFallback Fallback
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

		/// <summary>Получает объект <see cref="T:System.Text.DecoderFallbackBuffer" />, связанный с текущим объектом <see cref="T:System.Text.Decoder" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.DecoderFallbackBuffer" />.</returns>
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x00085827 File Offset: 0x00083A27
		public DecoderFallbackBuffer FallbackBuffer
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
						this._fallbackBuffer = DecoderFallback.ReplacementFallback.CreateFallbackBuffer();
					}
				}
				return this._fallbackBuffer;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x00085862 File Offset: 0x00083A62
		internal bool InternalHasFallbackBuffer
		{
			get
			{
				return this._fallbackBuffer != null;
			}
		}

		/// <summary>При переопределении в производном классе возвращает декодер в исходное состояние.</summary>
		// Token: 0x0600258D RID: 9613 RVA: 0x00085870 File Offset: 0x00083A70
		public virtual void Reset()
		{
			byte[] bytes = Array.Empty<byte>();
			char[] chars = new char[this.GetCharCount(bytes, 0, 0, true)];
			this.GetChars(bytes, 0, 0, chars, 0, true);
			DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
			if (fallbackBuffer == null)
			{
				return;
			}
			fallbackBuffer.Reset();
		}

		/// <summary>При переопределении в производном классе вычисляет количество символов, полученных при декодировании последовательности байтов из заданного массива байтов.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов и байтов во внутреннем буфере.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600258E RID: 9614
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		/// <summary>При переопределении в производном классе вычисляет количество символов, полученных при декодировании последовательности байтов из заданного массива байтов. Параметр указывает, следует ли очистить внутреннее состояние декодера после вычисления.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="index">Индекс первого декодируемого байта.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <param name="flush">
		///   <see langword="true" /> для имитации очистки внутреннего состояния кодировщика после расчета; в противном случае — <see langword="false" />.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов и байтов во внутреннем буфере.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <paramref name="bytes" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600258F RID: 9615 RVA: 0x000858B0 File Offset: 0x00083AB0
		public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return this.GetCharCount(bytes, index, count);
		}

		/// <summary>При переопределении в производном классе вычисляет количество символов, полученных при декодировании последовательности байтов, начало которой задается указателем байтов. Параметр указывает, следует ли очистить внутреннее состояние декодера после вычисления.</summary>
		/// <param name="bytes">Указатель на первый декодируемый байт.</param>
		/// <param name="count">Число байтов для декодирования.</param>
		/// <param name="flush">
		///   <see langword="true" /> для имитации очистки внутреннего состояния кодировщика после расчета; в противном случае — <see langword="false" />.</param>
		/// <returns>Число символов, полученных при декодировании заданной последовательности байтов и байтов во внутреннем буфере.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="bytes" /> равно <see langword="null" /> (<see langword="Nothing" /> в Visual Basic .NET).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002590 RID: 9616 RVA: 0x000858BC File Offset: 0x00083ABC
		[CLSCompliant(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			byte[] array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = bytes[i];
			}
			return this.GetCharCount(array, 0, count);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00085918 File Offset: 0x00083B18
		public unsafe virtual int GetCharCount(ReadOnlySpan<byte> bytes, bool flush)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				return this.GetCharCount(bytes2, bytes.Length, flush);
			}
		}

		/// <summary>При переопределении в производном классе декодирует последовательность байтов из заданного массива байтов и все байты, расположенные во внутреннем буфере, в указанный массив символов.</summary>
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
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002592 RID: 9618
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		/// <summary>При переопределении в производном классе декодирует последовательность байтов из заданного массива байтов и все байты, расположенные во внутреннем буфере, в указанный массив символов. Параметр указывает, следует ли очистить внутреннее состояние декодера после выполнения преобразования.</summary>
		/// <param name="bytes">Массив байтов, содержащий последовательность байтов, которую требуется декодировать.</param>
		/// <param name="byteIndex">Индекс первого декодируемого байта.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <param name="chars">Массив символов, в который будет помещен результирующий набор символов.</param>
		/// <param name="charIndex">Индекс, с которого начинается запись результирующего набора символов.</param>
		/// <param name="flush">Значение <see langword="true" /> соответствует очистке внутреннего состояния декодера после преобразования; в противоположном случае — значение <see langword="false" />.</param>
		/// <returns>Фактическое количество символов, записанных в параметр <paramref name="chars" />.</returns>
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
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002593 RID: 9619 RVA: 0x0008593E File Offset: 0x00083B3E
		public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		/// <summary>При переопределении в производном классе декодирует последовательность байтов, начало которой задается указателем байтов, и все байты, расположенные во внутреннем буфере, в набор символов, которые сохраняются, начиная с заданного указателя символов. Параметр указывает, следует ли очистить внутреннее состояние декодера после выполнения преобразования.</summary>
		/// <param name="bytes">Указатель на первый декодируемый байт.</param>
		/// <param name="byteCount">Число байтов для декодирования.</param>
		/// <param name="chars">Указатель на положение, с которого начинается запись результирующего набора символов.</param>
		/// <param name="charCount">Наибольшее количество символов для записи.</param>
		/// <param name="flush">Значение <see langword="true" /> соответствует очистке внутреннего состояния декодера после преобразования; в противоположном случае — значение <see langword="false" />.</param>
		/// <returns>Фактическое число символов, записанных в местоположение, которое задано параметром <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).  
		///
		/// или - 
		/// <paramref name="chars" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="byteCount" /> или <paramref name="charCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="charCount" /> меньше результирующего числа символов.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002594 RID: 9620 RVA: 0x00085950 File Offset: 0x00083B50
		[CLSCompliant(false)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (byteCount < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", "Non-negative number required.");
			}
			byte[] array = new byte[byteCount];
			for (int i = 0; i < byteCount; i++)
			{
				array[i] = bytes[i];
			}
			char[] array2 = new char[charCount];
			int chars2 = this.GetChars(array, 0, byteCount, array2, 0, flush);
			if (chars2 < charCount)
			{
				charCount = chars2;
			}
			for (int i = 0; i < charCount; i++)
			{
				chars[i] = array2[i];
			}
			return charCount;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000859F8 File Offset: 0x00083BF8
		public unsafe virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					return this.GetChars(bytes2, bytes.Length, chars2, chars.Length, flush);
				}
			}
		}

		/// <summary>Преобразует массив закодированных байтов в символы в кодировке UTF-16 и сохраняет результат в другом массиве символов.</summary>
		/// <param name="bytes">Преобразуемый массив байтов.</param>
		/// <param name="byteIndex">Первый элемент преобразуемого массива <paramref name="bytes" />.</param>
		/// <param name="byteCount">Число преобразуемых элементов <paramref name="bytes" />.</param>
		/// <param name="chars">Массив для сохранения преобразованных символов.</param>
		/// <param name="charIndex">Первый элемент массива <paramref name="chars" />, в котором сохраняются данные.</param>
		/// <param name="charCount">Максимальное число элементов в <paramref name="chars" /> для использования при преобразовании.</param>
		/// <param name="flush">Значение <see langword="true" /> указывает, что дальнейшие данные для преобразования отсутствуют. В противном случае — значение <see langword="false" />.</param>
		/// <param name="bytesUsed">При возврате этот метод содержит число байтов, которые использовались при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="charsUsed">При возврате этот метод содержит число символов из <paramref name="chars" />, которые были созданы при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="completed">При возврате этот метод содержит значение <see langword="true" />, если все символы, заданные с помощью <paramref name="byteCount" />, были преобразованы. В противном случае — значение <see langword="false" />. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> или <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="charIndex" />, <paramref name="charCount" />, <paramref name="byteIndex" /> или <paramref name="byteCount" /> меньше нуля.  
		///
		/// или - 
		/// Длина массива <paramref name="chars" /> - <paramref name="charIndex" /> меньше <paramref name="charCount" />.  
		///
		/// или - 
		/// Длина массива <paramref name="bytes" /> - <paramref name="byteIndex" /> меньше <paramref name="byteCount" />.</exception>
		/// <exception cref="T:System.ArgumentException">Выходной буфер слишком мал, чтобы содержать преобразованные входные данные. Размер выходного буфера должен быть больше или равен размеру, указанному методом <see cref="Overload:System.Text.Decoder.GetCharCount" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002596 RID: 9622 RVA: 0x00085A30 File Offset: 0x00083C30
		public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			for (bytesUsed = byteCount; bytesUsed > 0; bytesUsed /= 2)
			{
				if (this.GetCharCount(bytes, byteIndex, bytesUsed, flush) <= charCount)
				{
					charsUsed = this.GetChars(bytes, byteIndex, bytesUsed, chars, charIndex, flush);
					completed = (bytesUsed == byteCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException("Conversion buffer overflow.");
		}

		/// <summary>Преобразует буфер закодированных байтов в символы в кодировке UTF-16 и сохраняет результат в другом буфере.</summary>
		/// <param name="bytes">Адрес буфера, содержащего последовательности байтов для преобразования.</param>
		/// <param name="byteCount">Число байтов в <paramref name="bytes" />, которые требуется преобразовать.</param>
		/// <param name="chars">Адрес буфера для хранения преобразованных символов.</param>
		/// <param name="charCount">Максимальное число символов в <paramref name="chars" /> для использования при преобразовании.</param>
		/// <param name="flush">Значение <see langword="true" /> указывает, что дальнейшие данные для преобразования отсутствуют. В противном случае — значение <see langword="false" />.</param>
		/// <param name="bytesUsed">При возврате этот метод содержит число байтов, созданных при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="charsUsed">При возврате этот метод содержит число символов из <paramref name="chars" />, которые использовались при преобразовании. Этот параметр передается неинициализированным.</param>
		/// <param name="completed">При возврате этот метод содержит значение <see langword="true" />, если все символы, заданные с помощью <paramref name="byteCount" />, были преобразованы. В противном случае — значение <see langword="false" />. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="chars" /> или <paramref name="bytes" /> имеет значение <see langword="null" /> (<see langword="Nothing" />).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charCount" /> или <paramref name="byteCount" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Выходной буфер слишком мал, чтобы содержать преобразованные входные данные. Размер выходного буфера должен быть больше или равен размеру, указанному методом <see cref="Overload:System.Text.Decoder.GetCharCount" />.</exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">Произошла отработка отказа (см. полное объяснение в статье Кодировка символов в .NET Framework) 
		///
		/// и - 
		/// Параметру <see cref="P:System.Text.Decoder.Fallback" /> задается значение <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06002597 RID: 9623 RVA: 0x00085B48 File Offset: 0x00083D48
		[CLSCompliant(false)]
		public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (byteCount < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", "Non-negative number required.");
			}
			for (bytesUsed = byteCount; bytesUsed > 0; bytesUsed /= 2)
			{
				if (this.GetCharCount(bytes, bytesUsed, flush) <= charCount)
				{
					charsUsed = this.GetChars(bytes, bytesUsed, chars, charCount, flush);
					completed = (bytesUsed == byteCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException("Conversion buffer overflow.");
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00085C08 File Offset: 0x00083E08
		public unsafe virtual void Convert(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					this.Convert(bytes2, bytes.Length, chars2, chars.Length, flush, out bytesUsed, out charsUsed, out completed);
				}
			}
		}

		// Token: 0x04001D8C RID: 7564
		internal DecoderFallback _fallback;

		// Token: 0x04001D8D RID: 7565
		internal DecoderFallbackBuffer _fallbackBuffer;
	}
}
