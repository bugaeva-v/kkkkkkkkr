using System;

namespace System
{
	/// <summary>Предоставляет функциональные возможности для форматирования значения объекта в представление строки.</summary>
	// Token: 0x02000140 RID: 320
	public interface IFormattable
	{
		/// <summary>Форматирует значение текущего экземпляра, используя указанный формат.</summary>
		/// <param name="format">Используемый формат.  
		///
		/// или - 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования формата по умолчанию, определенного для типа реализации<see cref="T:System.IFormattable" />.</param>
		/// <param name="formatProvider">Поставщик для использования формата значения.  
		///
		/// или - 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для получения сведений о формате чисел из текущего установленного в операционной системе языкового стандарта.</param>
		/// <returns>Значение текущего экземпляра в указанном формате.</returns>
		// Token: 0x06000C00 RID: 3072
		string ToString(string format, IFormatProvider formatProvider);
	}
}
