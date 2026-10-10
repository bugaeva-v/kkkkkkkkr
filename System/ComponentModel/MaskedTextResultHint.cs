using System;

namespace System.ComponentModel
{
	/// <summary>Определяет значения, которые кратко описывают результаты операции разбора текста с маской.</summary>
	// Token: 0x020003D9 RID: 985
	public enum MaskedTextResultHint
	{
		/// <summary>Нет данных. Результат операции не удалось определить.</summary>
		// Token: 0x04000FA5 RID: 4005
		Unknown,
		/// <summary>Выполнено. Операция завершилась успешно, так как экранированным знаком является знак литерала, приглашения или пробела. Дополнительные сведения об экранированных знаках см. в описании метода <see cref="M:System.ComponentModel.MaskedTextProvider.VerifyEscapeChar(System.Char,System.Int32)" />.</summary>
		// Token: 0x04000FA6 RID: 4006
		CharacterEscaped,
		/// <summary>Выполнено. Основная операция не была выполнена, так как она не понадобилась, поэтому побочные эффекты отсутствуют.</summary>
		// Token: 0x04000FA7 RID: 4007
		NoEffect,
		/// <summary>Выполнено. Основная операция не была выполнена, так как она не понадобилась, но метод вызвал побочные эффекты. Например, метод <see cref="Overload:System.ComponentModel.MaskedTextProvider.RemoveAt" /> может удалить неназначенную редактируемую позицию, что приведет к сдвигу последующих знаков форматируемой строки влево.</summary>
		// Token: 0x04000FA8 RID: 4008
		SideEffect,
		/// <summary>Выполнено. Основная операция успешно завершена.</summary>
		// Token: 0x04000FA9 RID: 4009
		Success,
		/// <summary>Не удалось выполнить операцию. Обнаружен введенный знак, не являющийся элементом набора знаков ASCII.</summary>
		// Token: 0x04000FAA RID: 4010
		AsciiCharacterExpected = -1,
		/// <summary>Не удалось выполнить операцию. Обнаружен введенный знак, не являющийся алфавитно-цифровым. .</summary>
		// Token: 0x04000FAB RID: 4011
		AlphanumericCharacterExpected = -2,
		/// <summary>Не удалось выполнить операцию. Обнаружен введенный знак, не являющийся цифрой.</summary>
		// Token: 0x04000FAC RID: 4012
		DigitExpected = -3,
		/// <summary>Не удалось выполнить операцию. Обнаружен введенный знак, не являющийся буквой.</summary>
		// Token: 0x04000FAD RID: 4013
		LetterExpected = -4,
		/// <summary>Не удалось выполнить операцию. Обнаружен введенный знак, не являющийся цифрой со знаком.</summary>
		// Token: 0x04000FAE RID: 4014
		SignedDigitExpected = -5,
		/// <summary>Не удалось выполнить операцию. Программа обнаружила недопустимый введенный символ. Дополнительные сведения о знаках ,не являющихся допустимыми, см. в описании метода <see cref="M:System.ComponentModel.MaskedTextProvider.IsValidInputChar(System.Char)" />.</summary>
		// Token: 0x04000FAF RID: 4015
		InvalidInput = -51,
		/// <summary>Не удалось выполнить операцию. Знак приглашения нельзя использовать для ввода, возможно, потому что свойство <see cref="P:System.ComponentModel.MaskedTextProvider.AllowPromptAsInput" /> равно <see langword="false" />.</summary>
		// Token: 0x04000FB0 RID: 4016
		PromptCharNotAllowed = -52,
		/// <summary>Не удалось выполнить операцию. Недостаточно редактируемых позиций для выполнения запроса.</summary>
		// Token: 0x04000FB1 RID: 4017
		UnavailableEditPosition = -53,
		/// <summary>Не удалось выполнить операцию. Текущая позиция в форматируемой строке является литералом.</summary>
		// Token: 0x04000FB2 RID: 4018
		NonEditPosition = -54,
		/// <summary>Не удалось выполнить операцию. Заданная позиция находится вне диапазона конечной строки. Обычно это происходит, если это значение меньше нуля или больше длины конечной строки.</summary>
		// Token: 0x04000FB3 RID: 4019
		PositionOutOfRange = -55
	}
}
