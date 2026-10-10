using System;
using System.Threading;

namespace System.Text
{
	/// <summary>Предоставляет механизм обработки ошибок, называемый резервным вариантом, закодированной входной последовательности байтов, которая не может быть преобразована в выходной символ.</summary>
	// Token: 0x02000396 RID: 918
	[Serializable]
	public abstract class DecoderFallback
	{
		/// <summary>Получает объект, выводящий замещающую строку вместо входной последовательности байтов, которая не может быть декодирована.</summary>
		/// <returns>Тип, производный от класса <see cref="T:System.Text.DecoderFallback" />. Значением по умолчанию является объект <see cref="T:System.Text.DecoderReplacementFallback" />, выпускающий символ ЗНАКА ВОПРОСА ("?", U+003F) вместо неизвестных последовательностей байтов.</returns>
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0008602B File Offset: 0x0008422B
		public static DecoderFallback ReplacementFallback
		{
			get
			{
				DecoderFallback result;
				if ((result = DecoderFallback.s_replacementFallback) == null)
				{
					result = (Interlocked.CompareExchange<DecoderFallback>(ref DecoderFallback.s_replacementFallback, new DecoderReplacementFallback(), null) ?? DecoderFallback.s_replacementFallback);
				}
				return result;
			}
		}

		/// <summary>Получает объект, который создает исключение, если входная последовательность байтов не может быть декодирована.</summary>
		/// <returns>Тип, производный от класса <see cref="T:System.Text.DecoderFallback" />. Значение объекта по умолчанию равно <see cref="T:System.Text.DecoderExceptionFallback" />.</returns>
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x0008604F File Offset: 0x0008424F
		public static DecoderFallback ExceptionFallback
		{
			get
			{
				DecoderFallback result;
				if ((result = DecoderFallback.s_exceptionFallback) == null)
				{
					result = (Interlocked.CompareExchange<DecoderFallback>(ref DecoderFallback.s_exceptionFallback, new DecoderExceptionFallback(), null) ?? DecoderFallback.s_exceptionFallback);
				}
				return result;
			}
		}

		/// <summary>При переопределении в производном классе инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderFallbackBuffer" />.</summary>
		/// <returns>Объект, предоставляющий резервный буфер для декодера.</returns>
		// Token: 0x060025BB RID: 9659
		public abstract DecoderFallbackBuffer CreateFallbackBuffer();

		/// <summary>При переопределении в производном классе возвращает максимальное число символов, которые могут быть возвращены текущим объектом <see cref="T:System.Text.DecoderFallback" />.</summary>
		/// <returns>Максимальное число символов, которые может вернуть текущий объект <see cref="T:System.Text.DecoderFallback" />.</returns>
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060025BC RID: 9660
		public abstract int MaxCharCount { get; }

		// Token: 0x04001D98 RID: 7576
		private static DecoderFallback s_replacementFallback;

		// Token: 0x04001D99 RID: 7577
		private static DecoderFallback s_exceptionFallback;
	}
}
