using System;
using System.Threading;

namespace System.Text
{
	/// <summary>Предоставляет механизм обработки ошибок, называемый резервным вариантом, для входного символа, который не может быть преобразован в выходную последовательность закодированных байтов.</summary>
	// Token: 0x020003A1 RID: 929
	[Serializable]
	public abstract class EncoderFallback
	{
		/// <summary>Получает объект, выводящий замещающую строку вместо входного символа, который не может быть закодирован.</summary>
		/// <returns>Тип, производный от класса <see cref="T:System.Text.EncoderFallback" />. Значением по умолчанию является объект <see cref="T:System.Text.EncoderReplacementFallback" />, замещающий неизвестные входные символы символом ЗНАКА ВОПРОСА ("?", U+003F).</returns>
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000871C7 File Offset: 0x000853C7
		public static EncoderFallback ReplacementFallback
		{
			get
			{
				if (EncoderFallback.s_replacementFallback == null)
				{
					Interlocked.CompareExchange<EncoderFallback>(ref EncoderFallback.s_replacementFallback, new EncoderReplacementFallback(), null);
				}
				return EncoderFallback.s_replacementFallback;
			}
		}

		/// <summary>Получает объект, который создает исключение, если входной символ не может быть закодирован.</summary>
		/// <returns>Тип, производный от класса <see cref="T:System.Text.EncoderFallback" />. Значение объекта по умолчанию равно <see cref="T:System.Text.EncoderExceptionFallback" />.</returns>
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x000871E6 File Offset: 0x000853E6
		public static EncoderFallback ExceptionFallback
		{
			get
			{
				if (EncoderFallback.s_exceptionFallback == null)
				{
					Interlocked.CompareExchange<EncoderFallback>(ref EncoderFallback.s_exceptionFallback, new EncoderExceptionFallback(), null);
				}
				return EncoderFallback.s_exceptionFallback;
			}
		}

		/// <summary>При переопределении в производном классе инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderFallbackBuffer" />.</summary>
		/// <returns>Объект, предоставляющий резервный буфер для кодировщика.</returns>
		// Token: 0x0600261C RID: 9756
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();

		/// <summary>При переопределении в производном классе возвращает максимальное число символов, которые могут быть возвращены текущим объектом <see cref="T:System.Text.EncoderFallback" />.</summary>
		/// <returns>Максимальное число символов, которые может вернуть текущий объект <see cref="T:System.Text.EncoderFallback" />.</returns>
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600261D RID: 9757
		public abstract int MaxCharCount { get; }

		// Token: 0x04001DB1 RID: 7601
		private static EncoderFallback s_replacementFallback;

		// Token: 0x04001DB2 RID: 7602
		private static EncoderFallback s_exceptionFallback;
	}
}
