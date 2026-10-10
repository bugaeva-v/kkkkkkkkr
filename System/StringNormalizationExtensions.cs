using System;
using System.Text;

namespace System
{
	/// <summary>Предоставляет методы расширения для работы с нормализацией строк.</summary>
	// Token: 0x02000147 RID: 327
	public static class StringNormalizationExtensions
	{
		/// <summary>Указывает, находится ли данная строка в заданной форме нормализации Юникода C.</summary>
		/// <param name="value">Строка.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="value" /> находится в форме нормализации Юникода C; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> содержит недопустимые символы Юникода.</exception>
		// Token: 0x060008C6 RID: 2246 RVA: 0x000207DB File Offset: 0x0001E9DB
		public static bool IsNormalized(this string strInput)
		{
			return strInput.IsNormalized(NormalizationForm.FormC);
		}

		/// <summary>Указывает, находится ли строка в заданной форме нормализации Юникода.</summary>
		/// <param name="value">Строка.</param>
		/// <param name="normalizationForm">Форма нормализации Юникода.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="value" /> находится в форме нормализации <see langword="false" />; в противном случае — <paramref name="normalizationForm" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> содержит недопустимые символы Юникода.</exception>
		// Token: 0x060008C7 RID: 2247 RVA: 0x000207E4 File Offset: 0x0001E9E4
		public static bool IsNormalized(this string strInput, NormalizationForm normalizationForm)
		{
			if (strInput == null)
			{
				throw new ArgumentNullException("strInput");
			}
			return strInput.IsNormalized(normalizationForm);
		}

		/// <summary>Нормализует строку в заданную нормализованную форму Юникода C.</summary>
		/// <param name="value">Строка для нормализации.</param>
		/// <returns>Новая строка, текстовое значение которой совпадает с <paramref name="value" />, а двоичное представление находится в нормализованной форме Юникода C.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> содержит недопустимые символы Юникода.</exception>
		// Token: 0x060008C8 RID: 2248 RVA: 0x000207FB File Offset: 0x0001E9FB
		public static string Normalize(this string strInput)
		{
			return strInput.Normalize(NormalizationForm.FormC);
		}

		/// <summary>Нормализует строку в заданную нормализованную форму Юникода.</summary>
		/// <param name="value">Строка для нормализации.</param>
		/// <param name="normalizationForm">Форма нормализации Юникода.</param>
		/// <returns>Новая строка, текстовое значение которой совпадает с <paramref name="value" />, а двоичное представление находится в нормализованной форме <paramref name="normalizationForm" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> содержит недопустимые символы Юникода.</exception>
		// Token: 0x060008C9 RID: 2249 RVA: 0x00020804 File Offset: 0x0001EA04
		public static string Normalize(this string strInput, NormalizationForm normalizationForm)
		{
			if (strInput == null)
			{
				throw new ArgumentNullException("strInput");
			}
			return strInput.Normalize(normalizationForm);
		}
	}
}
