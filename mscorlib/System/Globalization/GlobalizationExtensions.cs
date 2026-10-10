using System;

namespace System.Globalization
{
	/// <summary>Предоставляет методы расширения, относящиеся к глобализации.</summary>
	// Token: 0x02000965 RID: 2405
	public static class GlobalizationExtensions
	{
		/// <summary>Возвращает <see cref="T:System.StringComparer" /> в соответствии с правилами сравнения строк с учетом языка и региональных параметров указанного объекта <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <param name="compareInfo">Объект, поддерживающий сравнение строк с учетом языка и региональных параметров.</param>
		/// <param name="options">Значение, определяющее способ сравнения строк. <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, значением перечисления <see cref="F:System.Globalization.CompareOptions.OrdinalIgnoreCase" /> или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" /> и <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>Объект, который может использоваться для сравнения строк.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="compareInfo" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> недопустим.</exception>
		// Token: 0x0600553F RID: 21823 RVA: 0x0011DE9C File Offset: 0x0011C09C
		public static StringComparer GetStringComparer(this CompareInfo compareInfo, CompareOptions options)
		{
			if (compareInfo == null)
			{
				throw new ArgumentNullException("compareInfo");
			}
			if (options == CompareOptions.Ordinal)
			{
				return StringComparer.Ordinal;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return StringComparer.OrdinalIgnoreCase;
			}
			return new CultureAwareComparer(compareInfo, options);
		}
	}
}
