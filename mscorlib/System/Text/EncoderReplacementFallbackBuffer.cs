using System;

namespace System.Text
{
	/// <summary>Представляет заменяющую входную строку, которая используется в случаях, когда входной символ не может быть декодирован. Этот класс не наследуется.</summary>
	// Token: 0x020003A5 RID: 933
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderReplacementFallbackBuffer" />, используя значение объекта <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		/// <param name="fallback">Объект <see cref="T:System.Text.EncoderReplacementFallback" />.</param>
		// Token: 0x06002641 RID: 9793 RVA: 0x00087917 File Offset: 0x00085B17
		public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
		{
			this._strDefault = fallback.DefaultString + fallback.DefaultString;
		}

		/// <summary>Подготавливает замещающий резервный буфер для использования текущей замещающей строки.</summary>
		/// <param name="charUnknown">Входной символ. Этот параметр игнорируется в этой операции, если не создается исключение.</param>
		/// <param name="index">Позиция индекса символа во входном буфере. Этот параметр игнорируется в данной операции.</param>
		/// <returns>Значение <see langword="true" />, если замещающая строка не является пустой; значение <see langword="false" />, если замещающая строка пустая.</returns>
		/// <exception cref="T:System.ArgumentException">Этот метод вызывается снова, прежде чем метод <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> считает все символы в замещающем резервном буфере.</exception>
		// Token: 0x06002642 RID: 9794 RVA: 0x00087944 File Offset: 0x00085B44
		public override bool Fallback(char charUnknown, int index)
		{
			if (this._fallbackCount >= 1)
			{
				if (char.IsHighSurrogate(charUnknown) && this._fallbackCount >= 0 && char.IsLowSurrogate(this._strDefault[this._fallbackIndex + 1]))
				{
					base.ThrowLastCharRecursive(char.ConvertToUtf32(charUnknown, this._strDefault[this._fallbackIndex + 1]));
				}
				base.ThrowLastCharRecursive((int)charUnknown);
			}
			this._fallbackCount = this._strDefault.Length / 2;
			this._fallbackIndex = -1;
			return this._fallbackCount != 0;
		}

		/// <summary>Указывает, может ли замещающая строка использоваться, если входная суррогатная пара не может быть расшифрована, или же следует игнорировать суррогатную пару. Параметры указывают суррогатную пару и позицию индекса пары при вводе.</summary>
		/// <param name="charUnknownHigh">Старший символ-заместитель входной пары.</param>
		/// <param name="charUnknownLow">Младший символ-заместитель входной пары.</param>
		/// <param name="index">Позиция индекса суррогатной пары во входном буфере.</param>
		/// <returns>Значение <see langword="true" />, если замещающая строка не является пустой; значение <see langword="false" />, если замещающая строка пустая.</returns>
		/// <exception cref="T:System.ArgumentException">Этот метод вызывается снова, прежде чем метод <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> считает все символы замещающей строки.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="charUnknownHigh" /> меньше U+D800 или больше U+D8FF.  
		///
		/// или - 
		/// Значение <paramref name="charUnknownLow" /> меньше U+DC00 или больше U+DFFF.</exception>
		// Token: 0x06002643 RID: 9795 RVA: 0x000879D0 File Offset: 0x00085BD0
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
			if (this._fallbackCount >= 1)
			{
				base.ThrowLastCharRecursive(char.ConvertToUtf32(charUnknownHigh, charUnknownLow));
			}
			this._fallbackCount = this._strDefault.Length;
			this._fallbackIndex = -1;
			return this._fallbackCount != 0;
		}

		/// <summary>Извлекает следующий символ в замещающем резервном буфере.</summary>
		/// <returns>Следующий символ в кодировке Юникод в замещающем резервном буфере, который может быть закодирован приложением.</returns>
		// Token: 0x06002644 RID: 9796 RVA: 0x00087A78 File Offset: 0x00085C78
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

		/// <summary>Приводит к тому, что в следующем вызове метод <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> получает доступ к позиции символа в замещающем резервном буфере, предшествующей текущей позиции символа.</summary>
		/// <returns>Значение <see langword="true" />, если операция <see cref="M:System.Text.EncoderReplacementFallbackBuffer.MovePrevious" /> выполнена успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002645 RID: 9797 RVA: 0x00087AD3 File Offset: 0x00085CD3
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
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x00087B06 File Offset: 0x00085D06
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

		/// <summary>Инициализирует все сведения о внутреннем состоянии и данных в этом экземпляре объекта <see cref="T:System.Text.EncoderReplacementFallbackBuffer" />.</summary>
		// Token: 0x06002647 RID: 9799 RVA: 0x00087B19 File Offset: 0x00085D19
		public override void Reset()
		{
			this._fallbackCount = -1;
			this._fallbackIndex = 0;
			this.charStart = null;
			this.bFallingBack = false;
		}

		// Token: 0x04001DC1 RID: 7617
		private string _strDefault;

		// Token: 0x04001DC2 RID: 7618
		private int _fallbackCount = -1;

		// Token: 0x04001DC3 RID: 7619
		private int _fallbackIndex = -1;
	}
}
