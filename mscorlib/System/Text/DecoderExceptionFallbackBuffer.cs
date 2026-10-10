using System;
using System.Globalization;

namespace System.Text
{
	/// <summary>Создает исключение <see cref="T:System.Text.DecoderFallbackException" />, если закодированная входная последовательность байтов не может быть преобразована в декодированный выходной символ. Этот класс не наследуется.</summary>
	// Token: 0x02000394 RID: 916
	public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
	{
		/// <summary>Создает исключение <see cref="T:System.Text.DecoderFallbackException" />, если входная последовательность байтов не может быть декодирована. Номинальное возвращаемое значение не используется.</summary>
		/// <param name="bytesUnknown">Входной массив байтов.</param>
		/// <param name="index">Позиция индекса байта во входной последовательности.</param>
		/// <returns>Отсутствует. Значение не возвращается, так как метод <see cref="M:System.Text.DecoderExceptionFallbackBuffer.Fallback(System.Byte[],System.Int32)" /> всегда создает исключение.  
		/// Номинальное возвращаемое значение равно <see langword="true" />. Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		/// <exception cref="T:System.Text.DecoderFallbackException">Этот метод всегда создает исключение, которое сообщает значение и позицию индекса входного байта, который не может быть декодирован.</exception>
		// Token: 0x060025AC RID: 9644 RVA: 0x00085F2A File Offset: 0x0008412A
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			this.Throw(bytesUnknown, index);
			return true;
		}

		/// <summary>Извлекает следующий символ в буфере данных исключения.</summary>
		/// <returns>Возвращаемое значение всегда является символом (U+0000) кодировки Юникод.  
		/// Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		// Token: 0x060025AD RID: 9645 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override char GetNextChar()
		{
			return '\0';
		}

		/// <summary>Приводит к тому, что следующий вызов <see cref="M:System.Text.DecoderExceptionFallbackBuffer.GetNextChar" /> получает доступ к позиции символа в буфере данных, предшествующей текущей позиции символа.</summary>
		/// <returns>Возвращаемое значение всегда равно <see langword="false" />.  
		/// Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		// Token: 0x060025AE RID: 9646 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool MovePrevious()
		{
			return false;
		}

		/// <summary>Получает количество символов в текущем объекте <see cref="T:System.Text.DecoderExceptionFallbackBuffer" />, которые нужно обработать.</summary>
		/// <returns>Возвращаемое значение всегда равно нулю.  
		/// Возвращаемое значение определено, хотя оно не изменяется, так как этот метод реализовывает абстрактный метод.</returns>
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int Remaining
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x00085F38 File Offset: 0x00084138
		private void Throw(byte[] bytesUnknown, int index)
		{
			StringBuilder stringBuilder = new StringBuilder(bytesUnknown.Length * 3);
			int num = 0;
			while (num < bytesUnknown.Length && num < 20)
			{
				stringBuilder.Append('[');
				stringBuilder.Append(bytesUnknown[num].ToString("X2", CultureInfo.InvariantCulture));
				stringBuilder.Append(']');
				num++;
			}
			if (num == 20)
			{
				stringBuilder.Append(" ...");
			}
			throw new DecoderFallbackException(SR.Format("Unable to translate bytes {0} at index {1} from specified code page to Unicode.", stringBuilder, index), bytesUnknown, index);
		}
	}
}
