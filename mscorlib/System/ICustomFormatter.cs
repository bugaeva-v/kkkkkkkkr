using System;

namespace System
{
	/// <summary>Определяет метод, поддерживающий пользовательское форматирование значения объекта.</summary>
	// Token: 0x0200013C RID: 316
	public interface ICustomFormatter
	{
		/// <summary>Преобразует значение указанного объекта в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка формата, содержащая спецификации форматирования.</param>
		/// <param name="arg">Объект для форматирования.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о формате для текущего экземпляра.</param>
		/// <returns>Строковое представление значения <paramref name="arg" />, отформатированное с использованием параметров <paramref name="format" /> и <paramref name="formatProvider" />.</returns>
		// Token: 0x06000BFC RID: 3068
		string Format(string format, object arg, IFormatProvider formatProvider);
	}
}
