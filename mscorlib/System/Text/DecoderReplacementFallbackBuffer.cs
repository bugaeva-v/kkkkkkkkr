using System;

namespace System.Text
{
	/// <summary>Представляет заменяющую выходную строку, которая подставляется в случаях, когда не может быть декодирована первоначальная входная последовательность байтов. Этот класс не наследуется.</summary>
	// Token: 0x0200039A RID: 922
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderReplacementFallbackBuffer" />, используя значение объекта <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		/// <param name="fallback">Объект <see cref="T:System.Text.DecoderReplacementFallback" />, содержащий замещающую строку.</param>
		// Token: 0x060025E0 RID: 9696 RVA: 0x0008679B File Offset: 0x0008499B
		public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
		{
			this._strDefault = fallback.DefaultString;
		}

		/// <summary>Подготавливает замещающий резервный буфер для использования текущей замещающей строки.</summary>
		/// <param name="bytesUnknown">Входящая последовательность байтов. Этот параметр игнорируется, если не создается исключение.</param>
		/// <param name="index">Позиция байта в <paramref name="bytesUnknown" />. Этот параметр игнорируется в данной операции.</param>
		/// <returns>Значение <see langword="true" />, если замещающая строка не является пустой; значение <see langword="false" />, если замещающая строка пустая.</returns>
		/// <exception cref="T:System.ArgumentException">Этот метод вызывается снова, прежде чем метод <see cref="M:System.Text.DecoderReplacementFallbackBuffer.GetNextChar" /> считает все символы в замещающем резервном буфере.</exception>
		// Token: 0x060025E1 RID: 9697 RVA: 0x000867BD File Offset: 0x000849BD
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			if (this._fallbackCount >= 1)
			{
				base.ThrowLastBytesRecursive(bytesUnknown);
			}
			if (this._strDefault.Length == 0)
			{
				return false;
			}
			this._fallbackCount = this._strDefault.Length;
			this._fallbackIndex = -1;
			return true;
		}

		/// <summary>Извлекает следующий символ в замещающем резервном буфере.</summary>
		/// <returns>Следующий символ в замещающем резервном буфере.</returns>
		// Token: 0x060025E2 RID: 9698 RVA: 0x000867F8 File Offset: 0x000849F8
		public override char GetNextChar()
		{
			this._fallbackCount--;
			this._fallbackIndex++;
			if (this._fallbackCount < 0)
			{
				return '\0';
			}
			if (this._fallbackCount == 2147483647)
			{
				this._fallbackCount = -1;
				return '\0';
			}
			return this._strDefault[this._fallbackIndex];
		}

		/// <summary>Приводит к следующему вызову <see cref="M:System.Text.DecoderReplacementFallbackBuffer.GetNextChar" /> для получения доступа к позиции символа в замещающем резервном буфере, предшествующей текущей позиции символа.</summary>
		/// <returns>Значение <see langword="true" />, если операция <see cref="M:System.Text.DecoderReplacementFallbackBuffer.MovePrevious" /> выполнена успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060025E3 RID: 9699 RVA: 0x00086853 File Offset: 0x00084A53
		public override bool MovePrevious()
		{
			if (this._fallbackCount >= -1 && this._fallbackIndex >= 0)
			{
				this._fallbackIndex--;
				this._fallbackCount++;
				return true;
			}
			return false;
		}

		/// <summary>Получает количество символов в замещающем резервном буфере, которые нужно обработать.</summary>
		/// <returns>Количество символов в замещающем резервном буфере, которые еще не были обработаны.</returns>
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00086886 File Offset: 0x00084A86
		public override int Remaining
		{
			get
			{
				if (this._fallbackCount >= 0)
				{
					return this._fallbackCount;
				}
				return 0;
			}
		}

		/// <summary>Инициализирует все сведения о внутреннем состоянии и данные в объекте <see cref="T:System.Text.DecoderReplacementFallbackBuffer" />.</summary>
		// Token: 0x060025E5 RID: 9701 RVA: 0x00086899 File Offset: 0x00084A99
		public override void Reset()
		{
			this._fallbackCount = -1;
			this._fallbackIndex = -1;
			this.byteStart = null;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000868B1 File Offset: 0x00084AB1
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return this._strDefault.Length;
		}

		// Token: 0x04001DA1 RID: 7585
		private string _strDefault;

		// Token: 0x04001DA2 RID: 7586
		private int _fallbackCount = -1;

		// Token: 0x04001DA3 RID: 7587
		private int _fallbackIndex = -1;
	}
}
