using System;

namespace System.Text
{
	/// <summary>Создает исключение <see cref="T:System.Text.EncoderFallbackException" />, когда входной символ не может быть преобразован в закодированную выходную последовательность байтов. Этот класс не наследуется.</summary>
	// Token: 0x0200039F RID: 927
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		/// <summary>Создает исключение, так как входной символ не может быть закодирован. Параметра указывает значение и позицию индекса символа, который не может быть преобразован.</summary>
		/// <param name="charUnknown">Входной символ.</param>
		/// <param name="index">Позиция индекса символа во входном буфере.</param>
		/// <returns>Отсутствует. Значение не возвращается, так как метод <see cref="M:System.Text.EncoderExceptionFallbackBuffer.Fallback(System.Char,System.Int32)" /> всегда создает исключение.</returns>
		/// <exception cref="T:System.Text.EncoderFallbackException">Параметр <paramref name="charUnknown" /> не может быть закодирован. Этот метод всегда создает исключение, сообщающее значение параметров <paramref name="charUnknown" /> и <paramref name="index" />.</exception>
		// Token: 0x0600260A RID: 9738 RVA: 0x00087042 File Offset: 0x00085242
		public override bool Fallback(char charUnknown, int index)
		{
			throw new EncoderFallbackException(SR.Format("Unable to translate Unicode character \\\\u{0:X4} at index {1} to specified code page.", (int)charUnknown, index), charUnknown, index);
		}

		/// <summary>Создает исключение, так как входной символ не может быть закодирован. Параметры указывают значение и позицию индекса суррогатной пары во входной последовательности, и номинальное возвращаемое значение не используется.</summary>
		/// <param name="charUnknownHigh">Старший символ-заместитель входной пары.</param>
		/// <param name="charUnknownLow">Младший символ-заместитель входной пары.</param>
		/// <param name="index">Позиция индекса суррогатной пары во входном буфере.</param>
		/// <returns>Отсутствует. Значение не возвращается, так как метод <see cref="M:System.Text.EncoderExceptionFallbackBuffer.Fallback(System.Char,System.Char,System.Int32)" /> всегда создает исключение.</returns>
		/// <exception cref="T:System.Text.EncoderFallbackException">Характер, представленный <paramref name="charUnknownHigh" /> и <paramref name="charUnknownLow" />, не может быть закодирован.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="charUnknownHigh" /> или <paramref name="charUnknownLow" /> является недопустимым. Значение параметра <paramref name="charUnknownHigh" /> находится за пределами диапазона от U+D800 до U+DBFF включительно или значение параметра <paramref name="charUnknownLow" /> находится за пределами диапазона от U+DC00 до U+DFFF включительно.</exception>
		// Token: 0x0600260B RID: 9739 RVA: 0x00087064 File Offset: 0x00085264
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			if (!char.IsHighSurrogate(charUnknownHigh))
			{
				throw new ArgumentOutOfRangeException("charUnknownHigh", SR.Format("Valid values are between {0} and {1}, inclusive.", 55296, 56319));
			}
			if (!char.IsLowSurrogate(charUnknownLow))
			{
				throw new ArgumentOutOfRangeException("charUnknownLow", SR.Format("Valid values are between {0} and {1}, inclusive.", 56320, 57343));
			}
			int num = char.ConvertToUtf32(charUnknownHigh, charUnknownLow);
			throw new EncoderFallbackException(SR.Format("Unable to translate Unicode character \\\\u{0:X4} at index {1} to specified code page.", num, index), charUnknownHigh, charUnknownLow, index);
		}

		/// <summary>Извлекает следующий символ в резервном буфере исключения.</summary>
		/// <returns>Возвращаемое значение всегда является символом NULL кодировки Юникод (U+0000).  
		/// Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		// Token: 0x0600260C RID: 9740 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override char GetNextChar()
		{
			return '\0';
		}

		/// <summary>Приводит к тому, что следующий вызов метода <see cref="M:System.Text.EncoderExceptionFallbackBuffer.GetNextChar" /> получает доступ к позиции символа в буфере данных, предшествующей текущей позиции символа.</summary>
		/// <returns>Возвращаемое значение всегда равно <see langword="false" />.  
		/// Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		// Token: 0x0600260D RID: 9741 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool MovePrevious()
		{
			return false;
		}

		/// <summary>Получает количество символов в текущем объекте <see cref="T:System.Text.EncoderExceptionFallbackBuffer" />, которые нужно обработать.</summary>
		/// <returns>Возвращаемое значение всегда равно нулю.  
		/// Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int Remaining
		{
			get
			{
				return 0;
			}
		}
	}
}
