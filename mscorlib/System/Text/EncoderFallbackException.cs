using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>Исключение, которое вызывается при сбое во время операции резервирования кодировщика. Этот класс не наследуется.</summary>
	// Token: 0x020003A0 RID: 928
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderFallbackException" />.</summary>
		// Token: 0x0600260F RID: 9743 RVA: 0x00085FC3 File Offset: 0x000841C3
		public EncoderFallbackException() : base("Value does not fall within the expected range.")
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderFallbackException" />. Через параметр задается сообщение об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке.</param>
		// Token: 0x06002610 RID: 9744 RVA: 0x00085FDB File Offset: 0x000841DB
		public EncoderFallbackException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderFallbackException" />. Параметры указывают сообщение об ошибке и внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке.</param>
		/// <param name="innerException">Исключение, вызвавшее данное исключение.</param>
		// Token: 0x06002611 RID: 9745 RVA: 0x00085FEF File Offset: 0x000841EF
		public EncoderFallbackException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x000870F9 File Offset: 0x000852F9
		internal EncoderFallbackException(string message, char charUnknown, int index) : base(message)
		{
			this._charUnknown = charUnknown;
			this._index = index;
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00087110 File Offset: 0x00085310
		internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index) : base(message)
		{
			if (!char.IsHighSurrogate(charUnknownHigh))
			{
				throw new ArgumentOutOfRangeException("charUnknownHigh", SR.Format("Valid values are between {0} and {1}, inclusive.", 55296, 56319));
			}
			if (!char.IsLowSurrogate(charUnknownLow))
			{
				throw new ArgumentOutOfRangeException("CharUnknownLow", SR.Format("Valid values are between {0} and {1}, inclusive.", 56320, 57343));
			}
			this._charUnknownHigh = charUnknownHigh;
			this._charUnknownLow = charUnknownLow;
			this._index = index;
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x0002110F File Offset: 0x0001F30F
		private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Получает входной символ, вызвавший исключение.</summary>
		/// <returns>Символ, который не может быть закодирован.</returns>
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0008719C File Offset: 0x0008539C
		public char CharUnknown
		{
			get
			{
				return this._charUnknown;
			}
		}

		/// <summary>Возвращает символ старшего компонента суррогатной пары, вызвавший исключение.</summary>
		/// <returns>Старший компонент суррогатной пары, который не может быть закодирован.</returns>
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000871A4 File Offset: 0x000853A4
		public char CharUnknownHigh
		{
			get
			{
				return this._charUnknownHigh;
			}
		}

		/// <summary>Возвращает символ младшего компонента суррогатной пары, вызвавший исключение.</summary>
		/// <returns>Символ младшего компонента суррогатной пары, который не может быть закодирован.</returns>
		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000871AC File Offset: 0x000853AC
		public char CharUnknownLow
		{
			get
			{
				return this._charUnknownLow;
			}
		}

		/// <summary>Получает позицию индекса во входном буфере символа, вызвавшего исключение.</summary>
		/// <returns>Позиция индекса во входном буфере символа, который не может быть закодирован.</returns>
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000871B4 File Offset: 0x000853B4
		public int Index
		{
			get
			{
				return this._index;
			}
		}

		/// <summary>Указывает, являются ли введенные денные, которые стали причиной исключения, суррогатной парой.</summary>
		/// <returns>Значение равно <see langword="true" />, если запрос был суррогатной парой; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002619 RID: 9753 RVA: 0x000871BC File Offset: 0x000853BC
		public bool IsUnknownSurrogate()
		{
			return this._charUnknownHigh > '\0';
		}

		// Token: 0x04001DAD RID: 7597
		private char _charUnknown;

		// Token: 0x04001DAE RID: 7598
		private char _charUnknownHigh;

		// Token: 0x04001DAF RID: 7599
		private char _charUnknownLow;

		// Token: 0x04001DB0 RID: 7600
		private int _index;
	}
}
