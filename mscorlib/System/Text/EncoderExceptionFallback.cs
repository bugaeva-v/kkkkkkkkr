using System;

namespace System.Text
{
	/// <summary>Предоставляет механизм обработки ошибок, называемый резервным вариантом, для входного символа, который не может быть преобразован в выходную последовательность байтов. Резервным механизм создает исключение, если входной символ не может быть преобразован в закодированную выходную последовательность байтов. Этот класс не наследуется.</summary>
	// Token: 0x0200039E RID: 926
	[Serializable]
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		/// <summary>Возвращает буфер резерва кодировщика, который выдает исключение, когда не может преобразовать последовательность символов в последовательность байтов.</summary>
		/// <returns>Буфер резерва кодировщика, который выдает исключение, когда не может закодировать последовательность символов.</returns>
		// Token: 0x06002605 RID: 9733 RVA: 0x0008701F File Offset: 0x0008521F
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderExceptionFallbackBuffer();
		}

		/// <summary>Получает максимальное число символов, которые может вернуть этот экземпляр.</summary>
		/// <returns>Возвращаемое значение всегда равно нулю.</returns>
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int MaxCharCount
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Указывает, равен ли текущий объект <see cref="T:System.Text.EncoderExceptionFallback" /> указанному объекту.</summary>
		/// <param name="value">Объект, производный от класса <see cref="T:System.Text.EncoderExceptionFallback" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> не равняется <see langword="null" /> (<see langword="Nothing" /> в Visual Basic .NET) и является объектом <see cref="T:System.Text.EncoderExceptionFallback" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002607 RID: 9735 RVA: 0x00087026 File Offset: 0x00085226
		public override bool Equals(object value)
		{
			return value is EncoderExceptionFallback;
		}

		/// <summary>Извлекает хэш-код для этого экземпляра.</summary>
		/// <returns>Возвращаемое значение всегда является одинаковым произвольным значением и не имеет особой важности.</returns>
		// Token: 0x06002608 RID: 9736 RVA: 0x00087033 File Offset: 0x00085233
		public override int GetHashCode()
		{
			return 654;
		}
	}
}
