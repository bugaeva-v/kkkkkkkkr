using System;

namespace System.Text
{
	/// <summary>Предоставляет механизм обработки ошибок, называемый резервным вариантом, для закодированной входной последовательности байтов, которая не может быть преобразована во входной символ. Этот резервный механизм выдает исключение вместо декодирования входной последовательности байтов. Этот класс не наследуется.</summary>
	// Token: 0x02000393 RID: 915
	[Serializable]
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		/// <summary>Возвращает буфер резерва декодера, который выдает исключение, когда не может преобразовать последовательность байтов в символ.</summary>
		/// <returns>Буфер резерва декодера, который выдает исключение, когда не может декодировать последовательность байтов.</returns>
		// Token: 0x060025A8 RID: 9640 RVA: 0x00085F0F File Offset: 0x0008410F
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return new DecoderExceptionFallbackBuffer();
		}

		/// <summary>Получает максимальное число символов, которые может вернуть этот экземпляр.</summary>
		/// <returns>Возвращаемое значение всегда равно нулю.</returns>
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int MaxCharCount
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Указывает, равен ли текущий объект <see cref="T:System.Text.DecoderExceptionFallback" /> указанному объекту.</summary>
		/// <param name="value">Объект, производный от класса <see cref="T:System.Text.DecoderExceptionFallback" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> не равняется <see langword="null" /> и является объектом <see cref="T:System.Text.DecoderExceptionFallback" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060025AA RID: 9642 RVA: 0x00085F16 File Offset: 0x00084116
		public override bool Equals(object value)
		{
			return value is DecoderExceptionFallback;
		}

		/// <summary>Извлекает хэш-код для этого экземпляра.</summary>
		/// <returns>Возвращаемое значение всегда является одинаковым произвольным значением и не имеет особой важности.</returns>
		// Token: 0x060025AB RID: 9643 RVA: 0x00085F23 File Offset: 0x00084123
		public override int GetHashCode()
		{
			return 879;
		}
	}
}
