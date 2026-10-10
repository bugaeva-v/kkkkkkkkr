using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>Исключение создается при сбое операции резервирования декодера. Этот класс не наследуется.</summary>
	// Token: 0x02000395 RID: 917
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderFallbackException" />.</summary>
		// Token: 0x060025B2 RID: 9650 RVA: 0x00085FC3 File Offset: 0x000841C3
		public DecoderFallbackException() : base("Value does not fall within the expected range.")
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderFallbackException" />. Через параметр задается сообщение об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке.</param>
		// Token: 0x060025B3 RID: 9651 RVA: 0x00085FDB File Offset: 0x000841DB
		public DecoderFallbackException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderFallbackException" />. Параметры указывают сообщение об ошибке и внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке.</param>
		/// <param name="innerException">Исключение, вызвавшее данное исключение.</param>
		// Token: 0x060025B4 RID: 9652 RVA: 0x00085FEF File Offset: 0x000841EF
		public DecoderFallbackException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderFallbackException" />. Параметры указывают сообщение об ошибке, декодируемый массив байтов и индекс байта, который не удается декодировать.</summary>
		/// <param name="message">Сообщение об ошибке.</param>
		/// <param name="bytesUnknown">Входной массив байтов.</param>
		/// <param name="index">Позиция байта, который не удается декодировать, в <paramref name="bytesUnknown" />.</param>
		// Token: 0x060025B5 RID: 9653 RVA: 0x00086004 File Offset: 0x00084204
		public DecoderFallbackException(string message, byte[] bytesUnknown, int index) : base(message)
		{
			this._bytesUnknown = bytesUnknown;
			this._index = index;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x0002110F File Offset: 0x0001F30F
		private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Получает входную последовательность байтов, вызвавшую исключение.</summary>
		/// <returns>Входной массив байтов, который не удается декодировать.</returns>
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0008601B File Offset: 0x0008421B
		public byte[] BytesUnknown
		{
			get
			{
				return this._bytesUnknown;
			}
		}

		/// <summary>Получает позицию байта, вызвавшего исключение, во входной последовательности байтов.</summary>
		/// <returns>Позиция байта, который не удается декодировать, во входном массиве байтов. Отсчет позиции начинается с нуля.</returns>
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00086023 File Offset: 0x00084223
		public int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x04001D96 RID: 7574
		private byte[] _bytesUnknown;

		// Token: 0x04001D97 RID: 7575
		private int _index;
	}
}
