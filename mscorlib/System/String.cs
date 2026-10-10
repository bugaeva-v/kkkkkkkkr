using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System
{
	/// <summary>Представляет текст как последовательность из частей кода UTF-16.</summary>
	// Token: 0x020000CD RID: 205
	[Serializable]
	public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x00017E10 File Offset: 0x00016010
		private unsafe static int CompareOrdinalIgnoreCaseHelper(string strA, string strB)
		{
			int num = Math.Min(strA.Length, strB.Length);
			fixed (char* ptr = &strA._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &strB._firstChar)
				{
					char* ptr4 = ptr3;
					char* ptr5 = ptr2;
					char* ptr6 = ptr4;
					while (num != 0)
					{
						int num2 = (int)(*ptr5);
						int num3 = (int)(*ptr6);
						if (num2 - 97 <= 25)
						{
							num2 -= 32;
						}
						if (num3 - 97 <= 25)
						{
							num3 -= 32;
						}
						if (num2 != num3)
						{
							return num2 - num3;
						}
						ptr5++;
						ptr6++;
						num--;
					}
					return strA.Length - strB.Length;
				}
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00017EA5 File Offset: 0x000160A5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool EqualsHelper(string strA, string strB)
		{
			return SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(strA.GetRawStringData()), Unsafe.As<char, byte>(strB.GetRawStringData()), (ulong)((long)strA.Length * 2L));
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00017ECC File Offset: 0x000160CC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			return SpanHelpers.SequenceCompareTo(Unsafe.Add<char>(strA.GetRawStringData(), indexA), countA, Unsafe.Add<char>(strB.GetRawStringData(), indexB), countB);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00017EF0 File Offset: 0x000160F0
		private unsafe static bool EqualsIgnoreCaseAsciiHelper(string strA, string strB)
		{
			int num = strA.Length;
			fixed (char* ptr = &strA._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &strB._firstChar)
				{
					char* ptr4 = ptr3;
					char* ptr5 = ptr2;
					char* ptr6 = ptr4;
					while (num != 0)
					{
						int num2 = (int)(*ptr5);
						int num3 = (int)(*ptr6);
						if (num2 != num3 && ((num2 | 32) != (num3 | 32) || (num2 | 32) - 97 > 25))
						{
							return false;
						}
						ptr5++;
						ptr6++;
						num--;
					}
					return true;
				}
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00017F60 File Offset: 0x00016160
		private unsafe static int CompareOrdinalHelper(string strA, string strB)
		{
			int i = Math.Min(strA.Length, strB.Length);
			fixed (char* ptr = &strA._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &strB._firstChar)
				{
					char* ptr4 = ptr3;
					char* ptr5 = ptr2;
					char* ptr6 = ptr4;
					if (ptr5[1] == ptr6[1])
					{
						i -= 2;
						ptr5 += 2;
						ptr6 += 2;
						while (i >= 12)
						{
							if (*(long*)ptr5 == *(long*)ptr6)
							{
								if (*(long*)(ptr5 + 4) == *(long*)(ptr6 + 4))
								{
									if (*(long*)(ptr5 + 8) == *(long*)(ptr6 + 8))
									{
										i -= 12;
										ptr5 += 12;
										ptr6 += 12;
										continue;
									}
									ptr5 += 4;
									ptr6 += 4;
								}
								ptr5 += 4;
								ptr6 += 4;
							}
							if (*(int*)ptr5 == *(int*)ptr6)
							{
								ptr5 += 2;
								ptr6 += 2;
							}
							IL_10E:
							if (*ptr5 != *ptr6)
							{
								return (int)(*ptr5 - *ptr6);
							}
							goto IL_11E;
						}
						while (i > 0)
						{
							if (*(int*)ptr5 != *(int*)ptr6)
							{
								goto IL_10E;
							}
							i -= 2;
							ptr5 += 2;
							ptr6 += 2;
						}
						return strA.Length - strB.Length;
					}
					IL_11E:
					return (int)(ptr5[1] - ptr6[1]);
				}
			}
		}

		/// <summary>Сравнивает два указанных объекта <see cref="T:System.String" /> и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая сравниваемая строка.</param>
		/// <param name="strB">Вторая сравниваемая строка.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  <paramref name="strA" /> предшествует <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///  <paramref name="strA" /> занимает ту же позицию в порядке сортировки, что и объект <paramref name="strB" />.  
		///
		///   Больше нуля 
		///  <paramref name="strA" /> следует за <paramref name="strB" /> в порядке сортировки.</returns>
		// Token: 0x060004E4 RID: 1252 RVA: 0x00018096 File Offset: 0x00016296
		public static int Compare(string strA, string strB)
		{
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		/// <summary>Сравнивает два указанных объекта <see cref="T:System.String" /> (с учетом или без учета регистра) и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая сравниваемая строка.</param>
		/// <param name="strB">Вторая сравниваемая строка.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при сравнении; в противном случае — значение <see langword="false" />.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  <paramref name="strA" /> предшествует <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///  <paramref name="strA" /> занимает ту же позицию в порядке сортировки, что и объект <paramref name="strB" />.  
		///
		///   Больше нуля 
		///  <paramref name="strA" /> следует за <paramref name="strB" /> в порядке сортировки.</returns>
		// Token: 0x060004E5 RID: 1253 RVA: 0x000180A0 File Offset: 0x000162A0
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			StringComparison comparisonType = ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
			return string.Compare(strA, strB, comparisonType);
		}

		/// <summary>Сравнивает два указанных объекта <see cref="T:System.String" /> с использованием заданных правил и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая сравниваемая строка.</param>
		/// <param name="strB">Вторая сравниваемая строка.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее используемые при сравнении правила.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  <paramref name="strA" /> предшествует <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///  <paramref name="strA" /> занимает ту же позицию в порядке сортировки, что и объект <paramref name="strB" />.  
		///
		///   Больше нуля 
		///  <paramref name="strA" /> следует за <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является значением <see cref="T:System.StringComparison" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <see cref="T:System.StringComparison" /> не поддерживается.</exception>
		// Token: 0x060004E6 RID: 1254 RVA: 0x000180C0 File Offset: 0x000162C0
		public static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			if (strA == strB)
			{
				string.CheckStringComparison(comparisonType);
				return 0;
			}
			if (strA == null)
			{
				string.CheckStringComparison(comparisonType);
				return -1;
			}
			if (strB == null)
			{
				string.CheckStringComparison(comparisonType);
				return 1;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.Compare(strA, strB, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(strA, strB, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				if (strA._firstChar != strB._firstChar)
				{
					return (int)(strA._firstChar - strB._firstChar);
				}
				return string.CompareOrdinalHelper(strA, strB);
			case StringComparison.OrdinalIgnoreCase:
				return CompareInfo.CompareOrdinalIgnoreCase(strA, 0, strA.Length, strB, 0, strB.Length);
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Сравнивает два заданных объекта <see cref="T:System.String" />, используя указанные параметры сравнения и сведения о языке и региональных параметрах, которые влияют на сравнение, и возвращает целое число, показывающее связь между двумя строками в порядке сортировки.</summary>
		/// <param name="strA">Первая сравниваемая строка.</param>
		/// <param name="strB">Вторая сравниваемая строка.</param>
		/// <param name="culture">Язык и региональные параметры, которые предоставляют сведения об особенностях сравнения с учетом языка и региональных параметров.</param>
		/// <param name="options">Параметры, которые используются во время сравнения (например, игнорирование регистра или символов).</param>
		/// <returns>32-разрядное целое число со знаком, которое указывает на лексические отношения между <paramref name="strA" /> и <paramref name="strB" />, как показано в следующей таблице. 
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  <paramref name="strA" /> предшествует <paramref name="strB" /> в порядке сортировки.  
		///   Нуль 
		///  <paramref name="strA" /> занимает ту же позицию в порядке сортировки, что и объект <paramref name="strB" />.  
		///   Больше нуля 
		///  <paramref name="strA" /> следует за <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является значением <see cref="T:System.Globalization.CompareOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> — <see langword="null" />.</exception>
		// Token: 0x060004E7 RID: 1255 RVA: 0x0001819A File Offset: 0x0001639A
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.CompareInfo.Compare(strA, strB, options);
		}

		/// <summary>Сравнивает два указанных объекта <see cref="T:System.String" /> (с учетом или без учета регистра), используя сведения о языке и региональных параметрах, и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая сравниваемая строка.</param>
		/// <param name="strB">Вторая сравниваемая строка.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при сравнении; в противном случае — значение <see langword="false" />.</param>
		/// <param name="culture">Объект, предоставляющий сведения об особенностях сравнения, определяемых языком и региональными параметрами.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  <paramref name="strA" /> предшествует <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///  <paramref name="strA" /> занимает ту же позицию в порядке сортировки, что и объект <paramref name="strB" />.  
		///
		///   Больше нуля 
		///  <paramref name="strA" /> следует за <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> — <see langword="null" />.</exception>
		// Token: 0x060004E8 RID: 1256 RVA: 0x000181B8 File Offset: 0x000163B8
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return string.Compare(strA, strB, culture, options);
		}

		/// <summary>Сравнивает подстроки двух указанных объектов <see cref="T:System.String" /> и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая из сравниваемых строк.</param>
		/// <param name="indexA">Позиция подстроки в <paramref name="strA" />.</param>
		/// <param name="strB">Вторая из сравниваемых строк.</param>
		/// <param name="indexB">Позиция подстроки в <paramref name="strB" />.</param>
		/// <param name="length">Максимальное число сравниваемых знаков в подстроках.</param>
		/// <returns>32-разрядное целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Подстрока в <paramref name="strA" /> предшествует подстроке в <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///   Подстроки появляются в той же позиции в порядке сортировки, или параметр <paramref name="length" /> равен нулю.  
		///
		///   Больше нуля 
		///   Подстрока в <paramref name="strA" /> следует за подстрокой в <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="indexA" /> больше значения <paramref name="strA" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  Значение <paramref name="indexB" /> больше значения <paramref name="strB" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  <paramref name="indexA" />, <paramref name="indexB" /> или <paramref name="length" /> является отрицательным значением.  
		/// -или- 
		/// <paramref name="indexA" /> или <paramref name="indexB" /> равно <see langword="null" />, а <paramref name="length" /> больше нуля.</exception>
		// Token: 0x060004E9 RID: 1257 RVA: 0x000181D6 File Offset: 0x000163D6
		public static int Compare(string strA, int indexA, string strB, int indexB, int length)
		{
			return string.Compare(strA, indexA, strB, indexB, length, false);
		}

		/// <summary>Сравнивает подстроки двух заданных объектов <see cref="T:System.String" /> (с учетом или без учета регистра) и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая из сравниваемых строк.</param>
		/// <param name="indexA">Позиция подстроки в <paramref name="strA" />.</param>
		/// <param name="strB">Вторая из сравниваемых строк.</param>
		/// <param name="indexB">Позиция подстроки в <paramref name="strB" />.</param>
		/// <param name="length">Максимальное число сравниваемых знаков в подстроках.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при сравнении; в противном случае — значение <see langword="false" />.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Подстрока в <paramref name="strA" /> предшествует подстроке в <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///   Подстроки появляются в той же позиции в порядке сортировки, или параметр <paramref name="length" /> равен нулю.  
		///
		///   Больше нуля 
		///   Подстрока в <paramref name="strA" /> следует за подстрокой в <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="indexA" /> больше значения <paramref name="strA" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  Значение <paramref name="indexB" /> больше значения <paramref name="strB" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  <paramref name="indexA" />, <paramref name="indexB" /> или <paramref name="length" /> является отрицательным значением.  
		/// -или- 
		/// <paramref name="indexA" /> или <paramref name="indexB" /> равно <see langword="null" />, а <paramref name="length" /> больше нуля.</exception>
		// Token: 0x060004EA RID: 1258 RVA: 0x000181E4 File Offset: 0x000163E4
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
		{
			int num = length;
			int num2 = length;
			if (strA != null)
			{
				num = Math.Min(num, strA.Length - indexA);
			}
			if (strB != null)
			{
				num2 = Math.Min(num2, strB.Length - indexB);
			}
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, options);
		}

		/// <summary>Сравнивает подстроки двух заданных объектов <see cref="T:System.String" /> (с учетом или без учета регистра), используя сведения о языке и региональных параметрах, и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая из сравниваемых строк.</param>
		/// <param name="indexA">Позиция подстроки в <paramref name="strA" />.</param>
		/// <param name="strB">Вторая из сравниваемых строк.</param>
		/// <param name="indexB">Позиция подстроки в <paramref name="strB" />.</param>
		/// <param name="length">Максимальное число сравниваемых знаков в подстроках.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при сравнении; в противном случае — значение <see langword="false" />.</param>
		/// <param name="culture">Объект, предоставляющий сведения об особенностях сравнения, определяемых языком и региональными параметрами.</param>
		/// <returns>Целое число, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Подстрока в <paramref name="strA" /> предшествует подстроке в <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///   Подстроки появляются в той же позиции в порядке сортировки, или параметр <paramref name="length" /> равен нулю.  
		///
		///   Больше нуля 
		///   Подстрока в <paramref name="strA" /> следует за подстрокой в <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="indexA" /> больше значения <paramref name="strA" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  Значение <paramref name="indexB" /> больше значения <paramref name="strB" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  <paramref name="indexA" />, <paramref name="indexB" /> или <paramref name="length" /> является отрицательным значением.  
		/// -или- 
		/// <paramref name="strA" /> или <paramref name="strB" /> равно <see langword="null" />, а <paramref name="length" /> больше нуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> — <see langword="null" />.</exception>
		// Token: 0x060004EB RID: 1259 RVA: 0x0001823C File Offset: 0x0001643C
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
		{
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return string.Compare(strA, indexA, strB, indexB, length, culture, options);
		}

		/// <summary>Сравнивает подстроки двух заданных объектов <see cref="T:System.String" />, используя указанные параметры сравнения и сведения о языке и региональных параметрах, которые влияют на сравнение, и возвращает целое число, показывающее связь между двумя подстроками в порядке сортировки.</summary>
		/// <param name="strA">Первая из сравниваемых строк.</param>
		/// <param name="indexA">Начальная позиция подстроки в пределах <paramref name="strA" />.</param>
		/// <param name="strB">Вторая из сравниваемых строк.</param>
		/// <param name="indexB">Начальная позиция подстроки в пределах <paramref name="strB" />.</param>
		/// <param name="length">Максимальное число сравниваемых знаков в подстроках.</param>
		/// <param name="culture">Объект, предоставляющий сведения об особенностях сравнения, определяемых языком и региональными параметрами.</param>
		/// <param name="options">Параметры, которые используются во время сравнения (например, игнорирование регистра или символов).</param>
		/// <returns>Целое число, которое указывает на лексические отношения между двумя подстроками, как показано в следующей таблице.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Подстрока в <paramref name="strA" /> предшествует подстроке в <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///   Подстроки появляются в той же позиции в порядке сортировки, или параметр <paramref name="length" /> равен нулю.  
		///
		///   Больше нуля 
		///   Подстрока в <paramref name="strA" /> следует за подстрокой в <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является значением <see cref="T:System.Globalization.CompareOptions" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="indexA" /> больше значения <paramref name="strA" /><see langword=".Length" />.  
		/// -или- 
		///  Значение <paramref name="indexB" /> больше значения <paramref name="strB" /><see langword=".Length" />.  
		/// -или- 
		///  <paramref name="indexA" />, <paramref name="indexB" /> или <paramref name="length" /> является отрицательным значением.  
		/// -или- 
		/// <paramref name="strA" /> или <paramref name="strB" /> равно <see langword="null" />, а <paramref name="length" /> больше нуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> — <see langword="null" />.</exception>
		// Token: 0x060004EC RID: 1260 RVA: 0x00018260 File Offset: 0x00016460
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			int num = length;
			int num2 = length;
			if (strA != null)
			{
				num = Math.Min(num, strA.Length - indexA);
			}
			if (strB != null)
			{
				num2 = Math.Min(num2, strB.Length - indexB);
			}
			return culture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, options);
		}

		/// <summary>Сравнивает подстроки двух указанных объектов <see cref="T:System.String" /> с использованием заданных правил и возвращает целое число, которое показывает их относительное положение в порядке сортировки.</summary>
		/// <param name="strA">Первая из сравниваемых строк.</param>
		/// <param name="indexA">Позиция подстроки в <paramref name="strA" />.</param>
		/// <param name="strB">Вторая из сравниваемых строк.</param>
		/// <param name="indexB">Позиция подстроки в <paramref name="strB" />.</param>
		/// <param name="length">Максимальное число сравниваемых знаков в подстроках.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее используемые при сравнении правила.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Подстрока в <paramref name="strA" /> предшествует подстроке в <paramref name="strB" /> в порядке сортировки.  
		///
		///   Нуль 
		///   Подстроки появляются в одной и той же позиции в порядке сортировки, или параметр <paramref name="length" /> равен нулю.  
		///
		///   Больше нуля 
		///   Подстрока в <paramref name="strA" /> следует за подстрокой в <paramref name="strB" /> в порядке сортировки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="indexA" /> больше значения <paramref name="strA" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  Значение <paramref name="indexB" /> больше значения <paramref name="strB" /><see cref="P:System.String.Length" />.  
		/// -или- 
		///  <paramref name="indexA" />, <paramref name="indexB" /> или <paramref name="length" /> является отрицательным значением.  
		/// -или- 
		/// <paramref name="indexA" /> или <paramref name="indexB" /> равно <see langword="null" />, а <paramref name="length" /> больше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060004ED RID: 1261 RVA: 0x000182BC File Offset: 0x000164BC
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			if (strA == null || strB == null)
			{
				if (strA == strB)
				{
					return 0;
				}
				if (strA != null)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (length < 0)
				{
					throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
				}
				if (indexA < 0 || indexB < 0)
				{
					throw new ArgumentOutOfRangeException((indexA < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (strA.Length - indexA < 0 || strB.Length - indexB < 0)
				{
					throw new ArgumentOutOfRangeException((strA.Length - indexA < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (length == 0 || (strA == strB && indexA == indexB))
				{
					return 0;
				}
				int num = Math.Min(length, strA.Length - indexA);
				int num2 = Math.Min(length, strB.Length - indexB);
				switch (comparisonType)
				{
				case StringComparison.CurrentCulture:
					return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
				case StringComparison.CurrentCultureIgnoreCase:
					return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase);
				case StringComparison.InvariantCulture:
					return CompareInfo.Invariant.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
				case StringComparison.InvariantCultureIgnoreCase:
					return CompareInfo.Invariant.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase);
				case StringComparison.Ordinal:
					return string.CompareOrdinalHelper(strA, indexA, num, strB, indexB, num2);
				case StringComparison.OrdinalIgnoreCase:
					return CompareInfo.CompareOrdinalIgnoreCase(strA, indexA, num, strB, indexB, num2);
				default:
					throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
				}
			}
		}

		/// <summary>Сравнивает два указанных объекта <see cref="T:System.String" />, оценивая числовые значения соответствующих объектов <see cref="T:System.Char" /> в каждой строке.</summary>
		/// <param name="strA">Первая сравниваемая строка.</param>
		/// <param name="strB">Вторая сравниваемая строка.</param>
		/// <returns>Целое число, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  Значение <paramref name="strA" /> меньше <paramref name="strB" />.  
		///
		///   Нуль 
		///  Значения параметров <paramref name="strA" /> и <paramref name="strB" /> равны.  
		///
		///   Больше нуля 
		///  Значение <paramref name="strA" /> больше значения <paramref name="strB" />.</returns>
		// Token: 0x060004EE RID: 1262 RVA: 0x0001841B File Offset: 0x0001661B
		public static int CompareOrdinal(string strA, string strB)
		{
			if (strA == strB)
			{
				return 0;
			}
			if (strA == null)
			{
				return -1;
			}
			if (strB == null)
			{
				return 1;
			}
			if (strA._firstChar != strB._firstChar)
			{
				return (int)(strA._firstChar - strB._firstChar);
			}
			return string.CompareOrdinalHelper(strA, strB);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00018450 File Offset: 0x00016650
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			return SpanHelpers.SequenceCompareTo(MemoryMarshal.GetReference<char>(strA), strA.Length, MemoryMarshal.GetReference<char>(strB), strB.Length);
		}

		/// <summary>Сравнивает подстроки двух указанных объектов <see cref="T:System.String" />, вычисляя числовые значения соответствующих объектов <see cref="T:System.Char" /> в каждой подстроке.</summary>
		/// <param name="strA">Первая из сравниваемых строк.</param>
		/// <param name="indexA">Начальный индекс подстроки в <paramref name="strA" />.</param>
		/// <param name="strB">Вторая из сравниваемых строк.</param>
		/// <param name="indexB">Начальный индекс подстроки в <paramref name="strB" />.</param>
		/// <param name="length">Максимальное число сравниваемых знаков в подстроках.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое отношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Подстрока в <paramref name="strA" /> меньше, чем подстрока в <paramref name="strB" />.  
		///
		///   Нуль 
		///   Подстроки равны, или значение параметра <paramref name="length" /> равно нулю.  
		///
		///   Больше нуля 
		///   Подстрока в <paramref name="strA" /> больше, чем подстрока в <paramref name="strB" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="strA" /> не имеет значение <see langword="null" />, и значение <paramref name="indexA" /> больше <paramref name="strA" />,<see cref="P:System.String.Length" />.  
		/// -или- 
		///  <paramref name="strB" /> не имеет значение <see langword="null" />, и значение <paramref name="indexB" /> больше <paramref name="strB" />,<see cref="P:System.String.Length" />.  
		/// -или- 
		///  <paramref name="indexA" />, <paramref name="indexB" /> или <paramref name="length" /> является отрицательным значением.</exception>
		// Token: 0x060004F0 RID: 1264 RVA: 0x00018474 File Offset: 0x00016674
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			if (strA == null || strB == null)
			{
				if (strA == strB)
				{
					return 0;
				}
				if (strA != null)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (length < 0)
				{
					throw new ArgumentOutOfRangeException("length", "Count cannot be less than zero.");
				}
				if (indexA < 0 || indexB < 0)
				{
					throw new ArgumentOutOfRangeException((indexA < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				int num = Math.Min(length, strA.Length - indexA);
				int num2 = Math.Min(length, strB.Length - indexB);
				if (num < 0 || num2 < 0)
				{
					throw new ArgumentOutOfRangeException((num < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (length == 0 || (strA == strB && indexA == indexB))
				{
					return 0;
				}
				return string.CompareOrdinalHelper(strA, indexA, num, strB, indexB, num2);
			}
		}

		/// <summary>Сравнивает данный экземпляр с указанным объектом <see cref="T:System.Object" /> и показывает, расположен ли экземпляр перед, после или в той же позиции в порядке сортировки, что и заданный объект <see cref="T:System.Object" />.</summary>
		/// <param name="value">Объект, имеющий значение <see cref="T:System.String" />.</param>
		/// <returns>32-битовое целое число со знаком, которое показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и параметр <paramref name="value" />.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Данный экземпляр предшествует параметру <paramref name="value" />.  
		///
		///   Нуль 
		///   Данный экземпляр имеет ту же позицию в порядке сортировки, что и <paramref name="value" />.  
		///
		///   Больше нуля 
		///   Данный экземпляр стоит после параметра <paramref name="value" />.  
		///
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.String" />.</exception>
		// Token: 0x060004F1 RID: 1265 RVA: 0x00018528 File Offset: 0x00016728
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			string text = value as string;
			if (text == null)
			{
				throw new ArgumentException("Object must be of type String.");
			}
			return this.CompareTo(text);
		}

		/// <summary>Сравнивает данный экземпляр с заданным объектом <see cref="T:System.String" /> и показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и заданная строка.</summary>
		/// <param name="strB">Строка, сравниваемая с данным экземпляром.</param>
		/// <returns>32-битовое целое число со знаком, которое показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и параметр <paramref name="strB" />.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///   Данный экземпляр предшествует параметру <paramref name="strB" />.  
		///
		///   Нуль 
		///   Данный экземпляр имеет ту же позицию в порядке сортировки, что и <paramref name="strB" />.  
		///
		///   Больше нуля 
		///   Данный экземпляр стоит после параметра <paramref name="strB" />.  
		///
		/// -или- 
		///  <paramref name="strB" /> — <see langword="null" />.</returns>
		// Token: 0x060004F2 RID: 1266 RVA: 0x00018096 File Offset: 0x00016296
		public int CompareTo(string strB)
		{
			return string.Compare(this, strB, StringComparison.CurrentCulture);
		}

		/// <summary>Определяет, совпадает ли конец данного экземпляра строки с указанной строкой.</summary>
		/// <param name="value">Строка, которую необходимо сравнить с подстрокой, расположенной в конце этого экземпляра.</param>
		/// <returns>
		///   <see langword="true" />, если конец этого экземпляра совпадает с <paramref name="value" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x060004F3 RID: 1267 RVA: 0x00018556 File Offset: 0x00016756
		public bool EndsWith(string value)
		{
			return this.EndsWith(value, StringComparison.CurrentCulture);
		}

		/// <summary>Определяет, совпадает ли конец экземпляра строки с заданной строкой при сравнении с учетом заданного параметра сравнения.</summary>
		/// <param name="value">Строка, которую необходимо сравнить с подстрокой, расположенной в конце этого экземпляра.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее способ сравнения данной строки со значением <paramref name="value" />.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> соответствует концу данной строки; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060004F4 RID: 1268 RVA: 0x00018560 File Offset: 0x00016760
		public bool EndsWith(string value, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value.Length == 0)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IsSuffix(this, value, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsSuffix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return this.Length >= value.Length && string.CompareOrdinalHelper(this, this.Length - value.Length, value.Length, value, 0, value.Length) == 0;
			case StringComparison.OrdinalIgnoreCase:
				return this.Length >= value.Length && CompareInfo.CompareOrdinalIgnoreCase(this, this.Length - value.Length, value.Length, value, 0, value.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Определяет, совпадает ли конец данного экземпляра строки с заданной строкой при сравнении с учетом заданного языка и региональных параметров.</summary>
		/// <param name="value">Строка, которую необходимо сравнить с подстрокой, расположенной в конце этого экземпляра.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при сравнении; в противном случае — значение <see langword="false" />.</param>
		/// <param name="culture">Связанные с языком и региональными параметрами сведения, определяющие, как выполняется сравнение этого экземпляра и <paramref name="value" />. Если значением параметра <paramref name="culture" /> является <see langword="null" />, используется текущий язык и региональные параметры.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> соответствует концу данной строки; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x060004F5 RID: 1269 RVA: 0x00018675 File Offset: 0x00016875
		public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return this == value || (culture ?? CultureInfo.CurrentCulture).CompareInfo.IsSuffix(this, value, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000186A8 File Offset: 0x000168A8
		public bool EndsWith(char value)
		{
			int length = this.Length;
			return length != 0 && this[length - 1] == value;
		}

		/// <summary>Определяет, равны ли значения этого экземпляра и указанного объекта, который также должен быть объектом <see cref="T:System.String" />.</summary>
		/// <param name="obj">Строка для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если объект <paramref name="obj" /> имеет тип <see cref="T:System.String" /> и его значение совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.  Если значением параметра <paramref name="obj" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x060004F7 RID: 1271 RVA: 0x000186D0 File Offset: 0x000168D0
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			string text = obj as string;
			return text != null && this.Length == text.Length && string.EqualsHelper(this, text);
		}

		/// <summary>Определяет, равны ли значения этого экземпляра и указанного объекта <see cref="T:System.String" />.</summary>
		/// <param name="value">Строка для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />. Если значением параметра <paramref name="value" /> является <see langword="null" />, метод возвращает <see langword="false" />.</returns>
		// Token: 0x060004F8 RID: 1272 RVA: 0x00018706 File Offset: 0x00016906
		public bool Equals(string value)
		{
			return this == value || (value != null && this.Length == value.Length && string.EqualsHelper(this, value));
		}

		/// <summary>Определяет, равны ли значения этой строки и указанного объекта <see cref="T:System.String" />. Параметр определяет язык и региональные параметры, учет регистра и правила сортировки, используемые при сравнении.</summary>
		/// <param name="value">Строка для сравнения с данным экземпляром.</param>
		/// <param name="comparisonType">Одно из значений перечисления, задающее способ сравнения строк.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> совпадает со значением данной строки; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060004F9 RID: 1273 RVA: 0x0001872C File Offset: 0x0001692C
		public bool Equals(string value, StringComparison comparisonType)
		{
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value == null)
			{
				string.CheckStringComparison(comparisonType);
				return false;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, CompareOptions.None) == 0;
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, CompareOptions.IgnoreCase) == 0;
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.Compare(this, value, CompareOptions.None) == 0;
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(this, value, CompareOptions.IgnoreCase) == 0;
			case StringComparison.Ordinal:
				return this.Length == value.Length && string.EqualsHelper(this, value);
			case StringComparison.OrdinalIgnoreCase:
				return this.Length == value.Length && CompareInfo.CompareOrdinalIgnoreCase(this, 0, this.Length, value, 0, value.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Определяет, совпадают ли значения двух указанных объектов <see cref="T:System.String" />.</summary>
		/// <param name="a">Первая сравниваемая строка или значение <see langword="null" />.</param>
		/// <param name="b">Вторая сравниваемая строка или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="a" /> совпадает со значением <paramref name="b" />; в противном случае — значение <see langword="false" />. Если оба параметра <paramref name="a" /> и <paramref name="b" /> имеют значение <see langword="null" />, метод возвращает значение <see langword="true" />.</returns>
		// Token: 0x060004FA RID: 1274 RVA: 0x00018811 File Offset: 0x00016A11
		public static bool Equals(string a, string b)
		{
			return a == b || (a != null && b != null && a.Length == b.Length && string.EqualsHelper(a, b));
		}

		/// <summary>Определяет, совпадают ли значения двух указанных объектов <see cref="T:System.String" />. Параметр определяет язык и региональные параметры, учет регистра и правила сортировки, используемые при сравнении.</summary>
		/// <param name="a">Первая сравниваемая строка или значение <see langword="null" />.</param>
		/// <param name="b">Вторая сравниваемая строка или значение <see langword="null" />.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> совпадают; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060004FB RID: 1275 RVA: 0x00018838 File Offset: 0x00016A38
		public static bool Equals(string a, string b, StringComparison comparisonType)
		{
			if (a == b)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (a == null || b == null)
			{
				string.CheckStringComparison(comparisonType);
				return false;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, CompareOptions.None) == 0;
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, CompareOptions.IgnoreCase) == 0;
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.Compare(a, b, CompareOptions.None) == 0;
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(a, b, CompareOptions.IgnoreCase) == 0;
			case StringComparison.Ordinal:
				return a.Length == b.Length && string.EqualsHelper(a, b);
			case StringComparison.OrdinalIgnoreCase:
				return a.Length == b.Length && CompareInfo.CompareOrdinalIgnoreCase(a, 0, a.Length, b, 0, b.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Определяет, равны ли значения двух указанных строк.</summary>
		/// <param name="a">Первая сравниваемая строка или значение <see langword="null" />.</param>
		/// <param name="b">Вторая сравниваемая строка или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="a" /> совпадает со значением <paramref name="b" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060004FC RID: 1276 RVA: 0x00018920 File Offset: 0x00016B20
		public static bool operator ==(string a, string b)
		{
			return string.Equals(a, b);
		}

		/// <summary>Определяет, различаются ли значения двух указанных строк.</summary>
		/// <param name="a">Первая сравниваемая строка или значение <see langword="null" />.</param>
		/// <param name="b">Вторая сравниваемая строка или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="a" /> отличается от значения <paramref name="b" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060004FD RID: 1277 RVA: 0x00018929 File Offset: 0x00016B29
		public static bool operator !=(string a, string b)
		{
			return !string.Equals(a, b);
		}

		/// <summary>Возвращает хэш-код для этой строки.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060004FE RID: 1278 RVA: 0x00018935 File Offset: 0x00016B35
		public override int GetHashCode()
		{
			return this.GetLegacyNonRandomizedHashCode();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001893D File Offset: 0x00016B3D
		public int GetHashCode(StringComparison comparisonType)
		{
			return StringComparer.FromComparison(comparisonType).GetHashCode(this);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001894C File Offset: 0x00016B4C
		internal unsafe int GetLegacyNonRandomizedHashCode()
		{
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				int num = 5381;
				int num2 = num;
				char* ptr3 = ptr2;
				int num3;
				while ((num3 = (int)(*ptr3)) != 0)
				{
					num = ((num << 5) + num ^ num3);
					num3 = (int)ptr3[1];
					if (num3 == 0)
					{
						break;
					}
					num2 = ((num2 << 5) + num2 ^ num3);
					ptr3 += 2;
				}
				return num + num2 * 1566083941;
			}
		}

		/// <summary>Определяет, совпадает ли начало данного экземпляра строки с указанной строкой.</summary>
		/// <param name="value">Строка, подлежащая сравнению.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> соответствует началу данной строки; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06000501 RID: 1281 RVA: 0x000189A0 File Offset: 0x00016BA0
		public bool StartsWith(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return this.StartsWith(value, StringComparison.CurrentCulture);
		}

		/// <summary>Определяет, совпадает ли начало этого экземпляра строки с заданной строкой при сравнении с учетом заданного параметра сравнения.</summary>
		/// <param name="value">Строка, подлежащая сравнению.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее способ сравнения данной строки со значением <paramref name="value" />.</param>
		/// <returns>Значение <see langword="true" />, если данный экземпляр начинается со значения <paramref name="value" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x06000502 RID: 1282 RVA: 0x000189B8 File Offset: 0x00016BB8
		public bool StartsWith(string value, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value.Length == 0)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IsPrefix(this, value, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsPrefix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return this.Length >= value.Length && this._firstChar == value._firstChar && (value.Length == 1 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(this.GetRawStringData()), Unsafe.As<char, byte>(value.GetRawStringData()), (ulong)((long)value.Length * 2L)));
			case StringComparison.OrdinalIgnoreCase:
				return this.Length >= value.Length && CompareInfo.CompareOrdinalIgnoreCase(this, 0, value.Length, value, 0, value.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Определяет, совпадает ли начало экземпляра строки с заданной строкой при сравнении с учетом заданного языка и региональных параметров.</summary>
		/// <param name="value">Строка, подлежащая сравнению.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при сравнении; в противном случае — значение <see langword="false" />.</param>
		/// <param name="culture">Связанные с языком и региональными параметрами сведения, определяющие, как выполняется сравнение этой строки и <paramref name="value" />. Если значением параметра <paramref name="culture" /> является <see langword="null" />, используется текущий язык и региональные параметры.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> соответствует началу данной строки; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06000503 RID: 1283 RVA: 0x00018ADB File Offset: 0x00016CDB
		public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return this == value || (culture ?? CultureInfo.CurrentCulture).CompareInfo.IsPrefix(this, value, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00018B0E File Offset: 0x00016D0E
		public bool StartsWith(char value)
		{
			return this.Length != 0 && this._firstChar == value;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00018B23 File Offset: 0x00016D23
		internal static void CheckStringComparison(StringComparison comparisonType)
		{
			if (comparisonType - StringComparison.CurrentCulture > 5)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.NotSupported_StringComparison, ExceptionArgument.comparisonType);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, заданным в виде массива знаков Юникода.</summary>
		/// <param name="value">Массив знаков Юникода.</param>
		// Token: 0x06000506 RID: 1286
		[PreserveDependency("CreateString(System.Char[])", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char[] value);

		// Token: 0x06000507 RID: 1287 RVA: 0x00018B34 File Offset: 0x00016D34
		private unsafe static string Ctor(char[] value)
		{
			if (value == null || value.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(value.Length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char[] array = value)
				{
					char* smem;
					if (value == null || array.Length == 0)
					{
						smem = null;
					}
					else
					{
						smem = &array[0];
					}
					string.wstrcpy(dmem, smem, value.Length);
					ptr = null;
				}
				return text;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, заданным массивом знаков Юникода, начальной позицией знака в пределах данного массива и длиной.</summary>
		/// <param name="value">Массив знаков Юникода.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <param name="length">Используемое количество знаков в <paramref name="value" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля.  
		/// -или- 
		/// Сумма <paramref name="startIndex" /> и <paramref name="length" /> больше, чем число элементов в <paramref name="value" />.</exception>
		// Token: 0x06000508 RID: 1288
		[PreserveDependency("CreateString(System.Char[], System.Int32, System.Int32)", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char[] value, int startIndex, int length);

		// Token: 0x06000509 RID: 1289 RVA: 0x00018B88 File Offset: 0x00016D88
		private unsafe static string Ctor(char[] value, int startIndex, int length)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (startIndex > value.Length - length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char[] array = value)
				{
					char* ptr2;
					if (value == null || array.Length == 0)
					{
						ptr2 = null;
					}
					else
					{
						ptr2 = &array[0];
					}
					string.wstrcpy(dmem, ptr2 + startIndex, length);
					ptr = null;
				}
				return text;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, определенным указателем на массив знаков Юникода.</summary>
		/// <param name="value">Указатель на строку знаков в кодировке Юникод, завершающуюся нулевым значением.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий процесс не имеет доступа на чтение ко всем рассматриваемым символам.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> указывает массив, содержащий недопустимый символ Юникода, или <paramref name="value" /> определяет адрес меньше 64 000.</exception>
		// Token: 0x0600050A RID: 1290
		[CLSCompliant(false)]
		[PreserveDependency("CreateString(System.Char*)", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(char* value);

		// Token: 0x0600050B RID: 1291 RVA: 0x00018C24 File Offset: 0x00016E24
		private unsafe static string Ctor(char* ptr)
		{
			if (ptr == null)
			{
				return string.Empty;
			}
			int num = string.wcslen(ptr);
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			fixed (char* ptr2 = &text._firstChar)
			{
				string.wstrcpy(ptr2, ptr, num);
			}
			return text;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, которое определяется заданным указателем на массив знаков Юникода, начальной позицией знака в этом массиве и длиной.</summary>
		/// <param name="value">Указатель на массив знаков Юникода.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <param name="length">Используемое количество знаков в <paramref name="value" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля, <paramref name="value" /> + <paramref name="startIndex" /> приводит к переполнению указателя, или текущий процесс не имеет доступа на чтение ко всем адресуемым символам.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> указывает массив, содержащий недопустимый символ Юникода, или <paramref name="value" /> + <paramref name="startIndex" /> определяет адрес меньше 64 000.</exception>
		// Token: 0x0600050C RID: 1292
		[PreserveDependency("CreateString(System.Char*, System.Int32, System.Int32)", "System.String")]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(char* value, int startIndex, int length);

		// Token: 0x0600050D RID: 1293 RVA: 0x00018C68 File Offset: 0x00016E68
		private unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			char* ptr2 = ptr + startIndex;
			if (ptr2 < ptr)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Pointer startIndex and length do not refer to a valid string.");
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (ptr == null)
			{
				throw new ArgumentOutOfRangeException("ptr", "Pointer startIndex and length do not refer to a valid string.");
			}
			string text = string.FastAllocateString(length);
			fixed (char* ptr3 = &text._firstChar)
			{
				string.wstrcpy(ptr3, ptr2, length);
			}
			return text;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, определенным указателем на массив 8-разрядных целых чисел со знаком.</summary>
		/// <param name="value">Указатель на массив 8-разрядных целых чисел со знаком, завершающийся нулевым значением. Целые числа интерпретируются с использованием текущей системы кодировки страницы системным кодом (то есть, кодировки, заданной <see cref="P:System.Text.Encoding.Default" />).</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Не удалось инициализировать новый экземпляр <see cref="T:System.String" /> с помощью <paramref name="value" />, если предполагается, что <paramref name="value" /> представлен в кодировке ANSI.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина новой инициализируемой строки, определяемая символом, завершающимся нулевым значением <paramref name="value" />, слишком велика для выделения.</exception>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="value" /> указывает недопустимый адрес.</exception>
		// Token: 0x0600050E RID: 1294
		[CLSCompliant(false)]
		[PreserveDependency("CreateString(System.SByte*)", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value);

		// Token: 0x0600050F RID: 1295 RVA: 0x00018CF0 File Offset: 0x00016EF0
		private unsafe static string Ctor(sbyte* value)
		{
			if (value == null)
			{
				return string.Empty;
			}
			int num = new ReadOnlySpan<byte>((void*)value, int.MaxValue).IndexOf(0);
			if (num < 0)
			{
				throw new ArgumentException("The string must be null-terminated.");
			}
			return string.CreateStringForSByteConstructor((byte*)value, num);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, определяемым заданным указателем на массив 8-разрядных целых чисел со знаком, начальной позицией в пределах массива и длиной.</summary>
		/// <param name="value">Указатель на массив 8-разрядных целых чисел со знаком. Целые числа интерпретируются с использованием текущей системы кодировки страницы системным кодом (то есть, кодировки, заданной <see cref="P:System.Text.Encoding.Default" />).</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <param name="length">Используемое количество знаков в <paramref name="value" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля.  
		/// -или- 
		/// Адрес, указанный значениями <paramref name="value" /> + <paramref name="startIndex" />, слишком велик для текущей платформы, то есть при вычислении адреса произошло переполнение.  
		/// -или- 
		/// Длина новой инициализируемой строки слишком велика для выделения.</exception>
		/// <exception cref="T:System.ArgumentException">Адрес, указанный значениями <paramref name="value" /> + <paramref name="startIndex" />, меньше 64 000.  
		/// -или- 
		/// Не удалось инициализировать новый экземпляр <see cref="T:System.String" /> с помощью <paramref name="value" />, исходя из предположения, что значение <paramref name="value" /> представлено в кодировке ANSI.</exception>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="value" />, <paramref name="startIndex" /> и <paramref name="length" /> совместно определяют недопустимый адрес.</exception>
		// Token: 0x06000510 RID: 1296
		[CLSCompliant(false)]
		[PreserveDependency("CreateString(System.SByte*, System.Int32, System.Int32)", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value, int startIndex, int length);

		// Token: 0x06000511 RID: 1297 RVA: 0x00018D34 File Offset: 0x00016F34
		private unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (value == null)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				throw new ArgumentNullException("value");
			}
			else
			{
				byte* ptr = (byte*)(value + startIndex);
				if (ptr < (byte*)value)
				{
					throw new ArgumentOutOfRangeException("value", "Pointer startIndex and length do not refer to a valid string.");
				}
				return string.CreateStringForSByteConstructor(ptr, length);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00018DA1 File Offset: 0x00016FA1
		private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			if (numBytes == 0)
			{
				return string.Empty;
			}
			return Encoding.UTF8.GetString(pb, numBytes);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, определенным заданным указателем на массив 8-разрядных целых чисел со знаком, начальной позицией в пределах этого массива, длиной и объектом <see cref="T:System.Text.Encoding" />.</summary>
		/// <param name="value">Указатель на массив 8-разрядных целых чисел со знаком.</param>
		/// <param name="startIndex">Начальная позиция в <paramref name="value" />.</param>
		/// <param name="length">Используемое количество знаков в <paramref name="value" />.</param>
		/// <param name="enc">Объект, определяющий способ кодировки массива, на который указывает параметр <paramref name="value" />. Если значением параметра <paramref name="enc" /> является <see langword="null" />, предполагается кодировка ANSI.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля.  
		/// -или- 
		/// Адрес, указанный значениями <paramref name="value" /> + <paramref name="startIndex" />, слишком велик для текущей платформы, то есть при вычислении адреса произошло переполнение.  
		/// -или- 
		/// Длина новой инициализируемой строки слишком велика для выделения.</exception>
		/// <exception cref="T:System.ArgumentException">Адрес, указанный значениями <paramref name="value" /> + <paramref name="startIndex" />, меньше 64 000.  
		/// -или- 
		/// Не удалось инициализировать новый экземпляр <see cref="T:System.String" /> с помощью <paramref name="value" />, если предполагается, что <paramref name="value" /> представлен в кодировке <paramref name="enc" />.</exception>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="value" />, <paramref name="startIndex" /> и <paramref name="length" /> совместно определяют недопустимый адрес.</exception>
		// Token: 0x06000513 RID: 1299
		[PreserveDependency("CreateString(System.SByte*, System.Int32, System.Int32, System.Text.Encoding)", "System.String")]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value, int startIndex, int length, Encoding enc);

		// Token: 0x06000514 RID: 1300 RVA: 0x00018DB8 File Offset: 0x00016FB8
		private unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
		{
			if (enc == null)
			{
				return new string(value, startIndex, length);
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Non-negative number required.");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (value == null)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				throw new ArgumentNullException("value");
			}
			else
			{
				byte* ptr = (byte*)(value + startIndex);
				if (ptr < (byte*)value)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Pointer startIndex and length do not refer to a valid string.");
				}
				return enc.GetString(new ReadOnlySpan<byte>((void*)ptr, length));
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.String" /> значением, полученным путем повторения заданного знака Юникода указанное число раз.</summary>
		/// <param name="c">Знак Юникода.</param>
		/// <param name="count">Количество повторов <paramref name="c" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		// Token: 0x06000515 RID: 1301
		[PreserveDependency("CreateString(System.Char, System.Int32)", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char c, int count);

		// Token: 0x06000516 RID: 1302 RVA: 0x00018E38 File Offset: 0x00017038
		private unsafe static string Ctor(char c, int count)
		{
			if (count > 0)
			{
				string text = string.FastAllocateString(count);
				fixed (char* ptr = &text._firstChar)
				{
					uint* ptr2 = (uint*)ptr;
					uint num = (uint)((uint)c << 16 | c);
					uint* ptr3 = ptr2;
					if (count >= 4)
					{
						count -= 4;
						do
						{
							*ptr3 = num;
							ptr3[1] = num;
							ptr3 += 2;
							count -= 4;
						}
						while (count >= 0);
					}
					if ((count & 2) != 0)
					{
						*ptr3 = num;
						ptr3++;
					}
					if ((count & 1) != 0)
					{
						*(short*)ptr3 = (short)c;
					}
				}
				return text;
			}
			if (count == 0)
			{
				return string.Empty;
			}
			throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
		}

		// Token: 0x06000517 RID: 1303
		[PreserveDependency("CreateString(System.ReadOnlySpan`1<System.Char>)", "System.String")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(ReadOnlySpan<char> value);

		// Token: 0x06000518 RID: 1304 RVA: 0x00018EB4 File Offset: 0x000170B4
		private unsafe static string Ctor(ReadOnlySpan<char> value)
		{
			if (value.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(value.Length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char* reference = MemoryMarshal.GetReference<char>(value))
				{
					char* smem = reference;
					string.wstrcpy(dmem, smem, value.Length);
					ptr = null;
				}
				return text;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00018F04 File Offset: 0x00017104
		public static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
		{
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			if (length > 0)
			{
				string text = string.FastAllocateString(length);
				action(new Span<char>(text.GetRawStringData(), length), state);
				return text;
			}
			if (length == 0)
			{
				return string.Empty;
			}
			throw new ArgumentOutOfRangeException("length");
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00018F54 File Offset: 0x00017154
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ReadOnlySpan<char>(string value)
		{
			if (value == null)
			{
				return default(ReadOnlySpan<char>);
			}
			return new ReadOnlySpan<char>(value.GetRawStringData(), value.Length);
		}

		/// <summary>Возвращает ссылку на данный экземпляр класса <see cref="T:System.String" />.</summary>
		/// <returns>Этот экземпляр <see cref="T:System.String" />.</returns>
		// Token: 0x0600051B RID: 1307 RVA: 0x0000270D File Offset: 0x0000090D
		public object Clone()
		{
			return this;
		}

		/// <summary>Создает экземпляр <see cref="T:System.String" />, имеющий то же значение, что и указанный экземпляр <see cref="T:System.String" />.</summary>
		/// <param name="str">Строка для копирования.</param>
		/// <returns>Новая строка с тем же значением, что и <paramref name="str" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> — <see langword="null" />.</exception>
		// Token: 0x0600051C RID: 1308 RVA: 0x00018F80 File Offset: 0x00017180
		public unsafe static string Copy(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			string text = string.FastAllocateString(str.Length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char* ptr2 = &str._firstChar)
				{
					char* smem = ptr2;
					string.wstrcpy(dmem, smem, str.Length);
					ptr = null;
				}
				return text;
			}
		}

		/// <summary>Копирует заданное число знаков, начиная с указанной позиции в этом экземпляре до указанной позиции в массиве знаков Юникода.</summary>
		/// <param name="sourceIndex">Индекс первого символа в этом экземпляре, который необходимо скопировать.</param>
		/// <param name="destination">Массив символов Юникода, в который копируются символы в этом экземпляре.</param>
		/// <param name="destinationIndex">Индекс в массиве <paramref name="destination" />, с которого начинается копирование.</param>
		/// <param name="count">Число знаков в этом экземпляре, копируемых в <paramref name="destination" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destination" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="sourceIndex" />, <paramref name="destinationIndex" /> или <paramref name="count" /> является отрицательным значением. 
		/// -или- 
		///  <paramref name="sourceIndex" /> не определяет позицию в текущем экземпляре.  
		/// -или- 
		///  <paramref name="destinationIndex" /> не определяет допустимый индекс в массиве <paramref name="destination" />.  
		/// -или- 
		///  <paramref name="count" /> больше, чем длина подстроки от <paramref name="sourceIndex" /> до конца данного экземпляра. 
		/// -или- 
		///  <paramref name="count" /> больше, чем длина подмассива от <paramref name="destinationIndex" /> до конца массива <paramref name="destination" />.</exception>
		// Token: 0x0600051D RID: 1309 RVA: 0x00018FCC File Offset: 0x000171CC
		public unsafe void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (sourceIndex < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > this.Length - sourceIndex)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Index and count must refer to a location within the string.");
			}
			if (destinationIndex > destination.Length - count || destinationIndex < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Index and count must refer to a location within the string.");
			}
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char[] array = destination)
				{
					char* ptr3;
					if (destination == null || array.Length == 0)
					{
						ptr3 = null;
					}
					else
					{
						ptr3 = &array[0];
					}
					string.wstrcpy(ptr3 + destinationIndex, ptr2 + sourceIndex, count);
					ptr = null;
				}
				return;
			}
		}

		/// <summary>Копирует знаки данного экземпляра в массив знаков Юникода.</summary>
		/// <returns>Массив знаков Юникода, элементами которого являются отдельные знаки из данного экземпляра. Если этот экземпляр является пустой строкой, то возвращаемый массив пуст и его длина равна нулю.</returns>
		// Token: 0x0600051E RID: 1310 RVA: 0x00019084 File Offset: 0x00017284
		public unsafe char[] ToCharArray()
		{
			if (this.Length == 0)
			{
				return Array.Empty<char>();
			}
			char[] array = new char[this.Length];
			fixed (char* ptr = &this._firstChar)
			{
				char* smem = ptr;
				fixed (char* ptr2 = &array[0])
				{
					string.wstrcpy(ptr2, smem, this.Length);
					ptr = null;
				}
				return array;
			}
		}

		/// <summary>Копирует знаки из указанной подстроки данного экземпляра в массив знаков Юникода.</summary>
		/// <param name="startIndex">Начальная позиция подстроки в данном экземпляре.</param>
		/// <param name="length">Длина подстроки в данном экземпляре.</param>
		/// <returns>Массив знаков Юникода, элементами которого являются <paramref name="length" /> знаков данного экземпляра начиная с позиции <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> + <paramref name="length" /> больше длины этого экземпляра.</exception>
		// Token: 0x0600051F RID: 1311 RVA: 0x000190D0 File Offset: 0x000172D0
		public unsafe char[] ToCharArray(int startIndex, int length)
		{
			if (startIndex < 0 || startIndex > this.Length || startIndex > this.Length - length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (length > 0)
			{
				char[] array = new char[length];
				fixed (char* ptr = &this._firstChar)
				{
					char* ptr2 = ptr;
					fixed (char* ptr3 = &array[0])
					{
						string.wstrcpy(ptr3, ptr2 + startIndex, length);
						ptr = null;
					}
					return array;
				}
			}
			if (length == 0)
			{
				return Array.Empty<char>();
			}
			throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
		}

		/// <summary>Указывает, действительно ли указанная строка является строкой <see langword="null" /> или пустой строкой ("").</summary>
		/// <param name="value">Строка для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> равен <see langword="null" /> или пустой строке (""); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000520 RID: 1312 RVA: 0x0001914E File Offset: 0x0001734E
		[NonVersionable]
		public static bool IsNullOrEmpty(string value)
		{
			return value == null || 0 >= value.Length;
		}

		/// <summary>Указывает, имеет ли указанная строка значение <see langword="null" />, является ли она пустой строкой или строкой, состоящей только из символов-разделителей.</summary>
		/// <param name="value">Строка для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />, либо если параметр <paramref name="value" /> содержит только символы-разделители.</returns>
		// Token: 0x06000521 RID: 1313 RVA: 0x00019160 File Offset: 0x00017360
		public static bool IsNullOrWhiteSpace(string value)
		{
			if (value == null)
			{
				return true;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (!char.IsWhiteSpace(value[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00019194 File Offset: 0x00017394
		internal ref char GetRawStringData()
		{
			return ref this._firstChar;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001919C File Offset: 0x0001739C
		internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			int charCount = encoding.GetCharCount(bytes, byteLength, null);
			if (charCount == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(charCount);
			fixed (char* ptr = &text._firstChar)
			{
				char* chars = ptr;
				encoding.GetChars(bytes, byteLength, chars, charCount, null);
			}
			return text;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000191DB File Offset: 0x000173DB
		internal static string CreateFromChar(char c)
		{
			string text = string.FastAllocateString(1);
			text._firstChar = c;
			return text;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000191EA File Offset: 0x000173EA
		internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
			Buffer.Memmove((byte*)dmem, (byte*)smem, (uint)(charCount * 2));
		}

		/// <summary>Возвращает этот экземпляр <see cref="T:System.String" />; реальное преобразование не осуществляется.</summary>
		/// <returns>Текущая строка.</returns>
		// Token: 0x06000526 RID: 1318 RVA: 0x0000270D File Offset: 0x0000090D
		public override string ToString()
		{
			return this;
		}

		/// <summary>Возвращает этот экземпляр <see cref="T:System.String" />; реальное преобразование не осуществляется.</summary>
		/// <param name="provider">(Зарезервирован.) Объект, предоставляющий сведения о форматировании, связанные с определенным языком и региональными параметрами.</param>
		/// <returns>Текущая строка.</returns>
		// Token: 0x06000527 RID: 1319 RVA: 0x0000270D File Offset: 0x0000090D
		public string ToString(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Извлекает объект, который может выполнять итерацию отдельных знаков данной строки.</summary>
		/// <returns>Объект перечислителя.</returns>
		// Token: 0x06000528 RID: 1320 RVA: 0x000191F6 File Offset: 0x000173F6
		public CharEnumerator GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000191F6 File Offset: 0x000173F6
		IEnumerator<char> IEnumerable<char>.GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		/// <summary>Возвращает перечислитель, выполняющий перебор элементов текущего объекта <see cref="T:System.String" />.</summary>
		/// <returns>Перечислитель, который можно использовать для перебора элементов текущей строки.</returns>
		// Token: 0x0600052A RID: 1322 RVA: 0x000191F6 File Offset: 0x000173F6
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00019200 File Offset: 0x00017400
		internal unsafe static int wcslen(char* ptr)
		{
			char* ptr2 = ptr;
			int num = IntPtr.Size - 1;
			while ((ptr2 & (uint)num) != 0U)
			{
				if (*ptr2 != '\0')
				{
					ptr2++;
				}
				else
				{
					IL_6E:
					int num2 = (int)((long)(ptr2 - ptr));
					if (ptr + num2 != ptr2)
					{
						throw new ArgumentException("The string must be null-terminated.");
					}
					return num2;
				}
			}
			for (;;)
			{
				if ((*(long*)ptr2 + 9223231297218904063L | 9223231297218904063L) == -1L)
				{
					ptr2 += 4;
				}
				else
				{
					if (*ptr2 == '\0')
					{
						goto IL_6E;
					}
					if (ptr2[1] == '\0')
					{
						goto IL_6A;
					}
					if (ptr2[2] == '\0')
					{
						goto IL_66;
					}
					if (ptr2[3] == '\0')
					{
						break;
					}
					ptr2 += 4;
				}
			}
			ptr2++;
			IL_66:
			ptr2++;
			IL_6A:
			ptr2++;
			goto IL_6E;
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для класса <see cref="T:System.String" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.String" />.</returns>
		// Token: 0x0600052C RID: 1324 RVA: 0x00019298 File Offset: 0x00017498
		public TypeCode GetTypeCode()
		{
			return TypeCode.String;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущей строки равно <see cref="F:System.Boolean.TrueString" />; <see langword="false" />, если значение текущей строки равно <see cref="F:System.Boolean.FalseString" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущей строки не равно <see cref="F:System.Boolean.TrueString" /> или <see cref="F:System.Boolean.FalseString" />.</exception>
		// Token: 0x0600052D RID: 1325 RVA: 0x0001929C File Offset: 0x0001749C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Знак с индексом 0 в текущем объекте <see cref="T:System.String" />.</returns>
		// Token: 0x0600052E RID: 1326 RVA: 0x000192A5 File Offset: 0x000174A5
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число больше <see cref="F:System.SByte.MaxValue" /> или меньше <see cref="F:System.SByte.MinValue" />.</exception>
		// Token: 0x0600052F RID: 1327 RVA: 0x000192AE File Offset: 0x000174AE
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число больше <see cref="F:System.Byte.MaxValue" /> или меньше <see cref="F:System.Byte.MinValue" />.</exception>
		// Token: 0x06000530 RID: 1328 RVA: 0x000192B7 File Offset: 0x000174B7
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число больше <see cref="F:System.Int16.MaxValue" /> или меньше <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x06000531 RID: 1329 RVA: 0x000192C0 File Offset: 0x000174C0
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число больше <see cref="F:System.UInt16.MaxValue" /> или меньше <see cref="F:System.UInt16.MinValue" />.</exception>
		// Token: 0x06000532 RID: 1330 RVA: 0x000192C9 File Offset: 0x000174C9
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		// Token: 0x06000533 RID: 1331 RVA: 0x000192D2 File Offset: 0x000174D2
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число больше <see cref="F:System.UInt32.MaxValue" /> или меньше <see cref="F:System.UInt32.MinValue" />.</exception>
		// Token: 0x06000534 RID: 1332 RVA: 0x000192DB File Offset: 0x000174DB
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		// Token: 0x06000535 RID: 1333 RVA: 0x000192E4 File Offset: 0x000174E4
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		// Token: 0x06000536 RID: 1334 RVA: 0x000192ED File Offset: 0x000174ED
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		// Token: 0x06000537 RID: 1335 RVA: 0x000192F6 File Offset: 0x000174F6
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x06000538 RID: 1336 RVA: 0x000192FF File Offset: 0x000174FF
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.FormatException">Значение текущего объекта <see cref="T:System.String" /> нельзя проанализировать.</exception>
		/// <exception cref="T:System.OverflowException">Значение текущего объекта <see cref="T:System.String" /> представляет собой число меньше <see cref="F:System.Decimal.MinValue" /> или больше <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x06000539 RID: 1337 RVA: 0x00019308 File Offset: 0x00017508
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDateTime(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		// Token: 0x0600053A RID: 1338 RVA: 0x00019311 File Offset: 0x00017511
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this, provider);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип возвращаемого объекта.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение текущего объекта <see cref="T:System.String" /> нельзя преобразовать в тип, заданный параметром <paramref name="type" />.</exception>
		// Token: 0x0600053B RID: 1339 RVA: 0x0001931A File Offset: 0x0001751A
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Указывает, находится ли данная строка в форме нормализации Юникода C.</summary>
		/// <returns>
		///   <see langword="true" />, если данная строка находится в форме нормализации Юникода C; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий экземпляр содержит недопустимые символы Юникода.</exception>
		// Token: 0x0600053C RID: 1340 RVA: 0x00019324 File Offset: 0x00017524
		public bool IsNormalized()
		{
			return this.IsNormalized(NormalizationForm.FormC);
		}

		/// <summary>Указывает, находится ли данная строка в заданной форме нормализации Юникода.</summary>
		/// <param name="normalizationForm">Форма нормализации Юникода.</param>
		/// <returns>
		///   <see langword="true" />, если строка находится в форме нормализации, указанной в параметре <paramref name="normalizationForm" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий экземпляр содержит недопустимые символы Юникода.</exception>
		// Token: 0x0600053D RID: 1341 RVA: 0x0001932D File Offset: 0x0001752D
		public bool IsNormalized(NormalizationForm normalizationForm)
		{
			return Normalization.IsNormalized(this, normalizationForm);
		}

		/// <summary>Возвращает новую строку, текстовое значение которой совпадает с данной строкой, а двоичное представление находится в нормализованной форме C Юникода.</summary>
		/// <returns>Новая нормализованная строка, текстовое значение которой совпадает с данной строкой, а двоичное представление находится в нормализованной форме C Юникода.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий экземпляр содержит недопустимые символы Юникода.</exception>
		// Token: 0x0600053E RID: 1342 RVA: 0x00019336 File Offset: 0x00017536
		public string Normalize()
		{
			return this.Normalize(NormalizationForm.FormC);
		}

		/// <summary>Возвращает новую строку, текстовое значение которой совпадает с данной строкой, а двоичное представление находится в заданной нормализованной форме Юникода.</summary>
		/// <param name="normalizationForm">Форма нормализации Юникода.</param>
		/// <returns>Новая строка, текстовое значение которой совпадает с данной строкой, а двоичное представление находится в форме нормализации, заданной в параметре <paramref name="normalizationForm" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий экземпляр содержит недопустимые символы Юникода.</exception>
		// Token: 0x0600053F RID: 1343 RVA: 0x0001933F File Offset: 0x0001753F
		public string Normalize(NormalizationForm normalizationForm)
		{
			return Normalization.Normalize(this, normalizationForm);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00019348 File Offset: 0x00017548
		private unsafe static void FillStringChecked(string dest, int destPos, string src)
		{
			if (src.Length > dest.Length - destPos)
			{
				throw new IndexOutOfRangeException();
			}
			fixed (char* ptr = &dest._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &src._firstChar)
				{
					char* smem = ptr3;
					string.wstrcpy(ptr2 + destPos, smem, src.Length);
				}
			}
		}

		/// <summary>Создает строковое представление указанного объекта.</summary>
		/// <param name="arg0">Объект для представления или значение <see langword="null" />.</param>
		/// <returns>Строковое представление значения параметра <paramref name="arg0" /> или <see cref="F:System.String.Empty" />, если значение параметра <paramref name="arg0" /> равно <see langword="null" />.</returns>
		// Token: 0x06000541 RID: 1345 RVA: 0x00019395 File Offset: 0x00017595
		public static string Concat(object arg0)
		{
			if (arg0 == null)
			{
				return string.Empty;
			}
			return arg0.ToString();
		}

		/// <summary>Сцепляет строковые представления двух указанных объектов.</summary>
		/// <param name="arg0">Первый из сцепляемых объектов.</param>
		/// <param name="arg1">Второй из сцепляемых объектов.</param>
		/// <returns>Сцепленные строковые представления значений <paramref name="arg0" /> и <paramref name="arg1" />.</returns>
		// Token: 0x06000542 RID: 1346 RVA: 0x000193A6 File Offset: 0x000175A6
		public static string Concat(object arg0, object arg1)
		{
			if (arg0 == null)
			{
				arg0 = string.Empty;
			}
			if (arg1 == null)
			{
				arg1 = string.Empty;
			}
			return arg0.ToString() + arg1.ToString();
		}

		/// <summary>Сцепляет строковые представления трех указанных объектов.</summary>
		/// <param name="arg0">Первый из сцепляемых объектов.</param>
		/// <param name="arg1">Второй из сцепляемых объектов.</param>
		/// <param name="arg2">Третий из сцепляемых объектов.</param>
		/// <returns>Сцепленные строковые представления значений <paramref name="arg0" />, <paramref name="arg1" /> и <paramref name="arg2" />.</returns>
		// Token: 0x06000543 RID: 1347 RVA: 0x000193CD File Offset: 0x000175CD
		public static string Concat(object arg0, object arg1, object arg2)
		{
			if (arg0 == null)
			{
				arg0 = string.Empty;
			}
			if (arg1 == null)
			{
				arg1 = string.Empty;
			}
			if (arg2 == null)
			{
				arg2 = string.Empty;
			}
			return arg0.ToString() + arg1.ToString() + arg2.ToString();
		}

		/// <summary>Сцепляет строковые представления элементов указанного массива <see cref="T:System.Object" />.</summary>
		/// <param name="args">Массив объектов, содержащий элементы, которые требуется сцепить.</param>
		/// <returns>Сцепленные строковые представления значений элементов параметра <paramref name="args" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="args" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти.</exception>
		// Token: 0x06000544 RID: 1348 RVA: 0x00019404 File Offset: 0x00017604
		public static string Concat(params object[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 1)
			{
				string result;
				if (args.Length != 0)
				{
					object obj = args[0];
					if ((result = ((obj != null) ? obj.ToString() : null)) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			string[] array = new string[args.Length];
			int num = 0;
			for (int i = 0; i < args.Length; i++)
			{
				object obj2 = args[i];
				string text = ((obj2 != null) ? obj2.ToString() : null) ?? string.Empty;
				array[i] = text;
				num += text.Length;
				if (num < 0)
				{
					throw new OutOfMemoryException();
				}
			}
			if (num == 0)
			{
				return string.Empty;
			}
			string text2 = string.FastAllocateString(num);
			int num2 = 0;
			foreach (string text3 in array)
			{
				string.FillStringChecked(text2, num2, text3);
				num2 += text3.Length;
			}
			return text2;
		}

		/// <summary>Сцепляет элементы реализации <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <param name="values">Объект коллекции, реализующий интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
		/// <typeparam name="T">Тип элементов параметра <paramref name="values" />.</typeparam>
		/// <returns>Сцепленные элементы в параметре <paramref name="values" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		// Token: 0x06000545 RID: 1349 RVA: 0x000194D8 File Offset: 0x000176D8
		public static string Concat<T>(IEnumerable<T> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (typeof(T) == typeof(char))
			{
				using (IEnumerator<char> enumerator = Unsafe.As<IEnumerable<char>>(values).GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						return string.Empty;
					}
					char c = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						return string.CreateFromChar(c);
					}
					StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
					stringBuilder.Append(c);
					do
					{
						c = enumerator.Current;
						stringBuilder.Append(c);
					}
					while (enumerator.MoveNext());
					return StringBuilderCache.GetStringAndRelease(stringBuilder);
				}
			}
			string result;
			using (IEnumerator<T> enumerator2 = values.GetEnumerator())
			{
				if (!enumerator2.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					T t = enumerator2.Current;
					string text = (t != null) ? t.ToString() : null;
					if (!enumerator2.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						StringBuilder stringBuilder2 = StringBuilderCache.Acquire(16);
						stringBuilder2.Append(text);
						do
						{
							t = enumerator2.Current;
							if (t != null)
							{
								stringBuilder2.Append(t.ToString());
							}
						}
						while (enumerator2.MoveNext());
						result = StringBuilderCache.GetStringAndRelease(stringBuilder2);
					}
				}
			}
			return result;
		}

		/// <summary>Сцепляет элементы созданной коллекции <see cref="T:System.Collections.Generic.IEnumerable`1" /> типа <see cref="T:System.String" />.</summary>
		/// <param name="values">Объект коллекции, реализующий интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> и имеющий аргумент универсального типа <see cref="T:System.String" />.</param>
		/// <returns>Сцепленные строки в параметре <paramref name="values" />. Или <see cref="F:System.String.Empty" />, если <paramref name="values" /> — это пустой элемент <see langword="IEnumerable(Of String)" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		// Token: 0x06000546 RID: 1350 RVA: 0x00019654 File Offset: 0x00017854
		public static string Concat(IEnumerable<string> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			string result;
			using (IEnumerator<string> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					string text = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
						stringBuilder.Append(text);
						do
						{
							stringBuilder.Append(enumerator.Current);
						}
						while (enumerator.MoveNext());
						result = StringBuilderCache.GetStringAndRelease(stringBuilder);
					}
				}
			}
			return result;
		}

		/// <summary>Сцепляет два указанных экземпляра <see cref="T:System.String" />.</summary>
		/// <param name="str0">Первая из сцепляемых строк.</param>
		/// <param name="str1">Вторая из сцепляемых строк.</param>
		/// <returns>Сцепление <paramref name="str0" /> и <paramref name="str1" />.</returns>
		// Token: 0x06000547 RID: 1351 RVA: 0x000196EC File Offset: 0x000178EC
		public static string Concat(string str0, string str1)
		{
			if (string.IsNullOrEmpty(str0))
			{
				if (string.IsNullOrEmpty(str1))
				{
					return string.Empty;
				}
				return str1;
			}
			else
			{
				if (string.IsNullOrEmpty(str1))
				{
					return str0;
				}
				int length = str0.Length;
				string text = string.FastAllocateString(length + str1.Length);
				string.FillStringChecked(text, 0, str0);
				string.FillStringChecked(text, length, str1);
				return text;
			}
		}

		/// <summary>Сцепляет три указанных экземпляра <see cref="T:System.String" />.</summary>
		/// <param name="str0">Первая из сцепляемых строк.</param>
		/// <param name="str1">Вторая из сцепляемых строк.</param>
		/// <param name="str2">Третья из сцепляемых строк.</param>
		/// <returns>Сцепление <paramref name="str0" />, <paramref name="str1" /> и <paramref name="str2" />.</returns>
		// Token: 0x06000548 RID: 1352 RVA: 0x00019740 File Offset: 0x00017940
		public static string Concat(string str0, string str1, string str2)
		{
			if (string.IsNullOrEmpty(str0))
			{
				return str1 + str2;
			}
			if (string.IsNullOrEmpty(str1))
			{
				return str0 + str2;
			}
			if (string.IsNullOrEmpty(str2))
			{
				return str0 + str1;
			}
			string text = string.FastAllocateString(str0.Length + str1.Length + str2.Length);
			string.FillStringChecked(text, 0, str0);
			string.FillStringChecked(text, str0.Length, str1);
			string.FillStringChecked(text, str0.Length + str1.Length, str2);
			return text;
		}

		/// <summary>Сцепляет четыре указанных экземпляра <see cref="T:System.String" />.</summary>
		/// <param name="str0">Первая из сцепляемых строк.</param>
		/// <param name="str1">Вторая из сцепляемых строк.</param>
		/// <param name="str2">Третья из сцепляемых строк.</param>
		/// <param name="str3">Четвертая из сцепляемых строк.</param>
		/// <returns>Сцепление <paramref name="str0" />, <paramref name="str1" />, <paramref name="str2" /> и <paramref name="str3" />.</returns>
		// Token: 0x06000549 RID: 1353 RVA: 0x000197C0 File Offset: 0x000179C0
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			if (string.IsNullOrEmpty(str0))
			{
				return str1 + str2 + str3;
			}
			if (string.IsNullOrEmpty(str1))
			{
				return str0 + str2 + str3;
			}
			if (string.IsNullOrEmpty(str2))
			{
				return str0 + str1 + str3;
			}
			if (string.IsNullOrEmpty(str3))
			{
				return str0 + str1 + str2;
			}
			string text = string.FastAllocateString(str0.Length + str1.Length + str2.Length + str3.Length);
			string.FillStringChecked(text, 0, str0);
			string.FillStringChecked(text, str0.Length, str1);
			string.FillStringChecked(text, str0.Length + str1.Length, str2);
			string.FillStringChecked(text, str0.Length + str1.Length + str2.Length, str3);
			return text;
		}

		/// <summary>Сцепляет элементы указанного массива <see cref="T:System.String" />.</summary>
		/// <param name="values">Массив строк.</param>
		/// <returns>Сцепленные элементы <paramref name="values" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти.</exception>
		// Token: 0x0600054A RID: 1354 RVA: 0x00019878 File Offset: 0x00017A78
		public static string Concat(params string[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length <= 1)
			{
				string result;
				if (values.Length != 0)
				{
					if ((result = values[0]) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			long num = 0L;
			foreach (string text in values)
			{
				if (text != null)
				{
					num += (long)text.Length;
				}
			}
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			int num2 = (int)num;
			if (num2 == 0)
			{
				return string.Empty;
			}
			string text2 = string.FastAllocateString(num2);
			int num3 = 0;
			foreach (string text3 in values)
			{
				if (!string.IsNullOrEmpty(text3))
				{
					int length = text3.Length;
					if (length > num2 - num3)
					{
						num3 = -1;
						break;
					}
					string.FillStringChecked(text2, num3, text3);
					num3 += length;
				}
			}
			if (num3 != num2)
			{
				return string.Concat((string[])values.Clone());
			}
			return text2;
		}

		/// <summary>Заменяет один или более элементов формата в строке строковым представлением указанного объекта.</summary>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="arg0">Объект для форматирования.</param>
		/// <returns>Копия <paramref name="format" />, в которой все элементы формата заменены строковыми представлениями <paramref name="arg0" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимый элемент формата в <paramref name="format" />.  
		/// -или- 
		/// Индекс элемента формата не равен нулю.</exception>
		// Token: 0x0600054B RID: 1355 RVA: 0x00019957 File Offset: 0x00017B57
		public static string Format(string format, object arg0)
		{
			return string.FormatHelper(null, format, new ParamsArray(arg0));
		}

		/// <summary>Заменяет элементы формата в строке строковым представлением двух указанных объектов.</summary>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="arg0">Первый объект для форматирования.</param>
		/// <param name="arg1">Второй объект для форматирования.</param>
		/// <returns>Копия <paramref name="format" />, в которой все элементы формата заменены строковыми представлениями <paramref name="arg0" /> и <paramref name="arg1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата не равен нулю или единице.</exception>
		// Token: 0x0600054C RID: 1356 RVA: 0x00019966 File Offset: 0x00017B66
		public static string Format(string format, object arg0, object arg1)
		{
			return string.FormatHelper(null, format, new ParamsArray(arg0, arg1));
		}

		/// <summary>Заменяет элементы формата в строке строковым представлением трех указанных объектов.</summary>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="arg0">Первый объект для форматирования.</param>
		/// <param name="arg1">Второй объект для форматирования.</param>
		/// <param name="arg2">Третий объект для форматирования.</param>
		/// <returns>Копия <paramref name="format" />, в которой все элементы формата заменены строковыми представлениями <paramref name="arg0" />, <paramref name="arg1" /> и <paramref name="arg2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата меньше нуля или больше двух.</exception>
		// Token: 0x0600054D RID: 1357 RVA: 0x00019976 File Offset: 0x00017B76
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			return string.FormatHelper(null, format, new ParamsArray(arg0, arg1, arg2));
		}

		/// <summary>Заменяет элемент формата в указанной строке строковым представлением соответствующего объекта в указанном массиве.</summary>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="args">Массив объектов, содержащий нуль или более форматируемых объектов.</param>
		/// <returns>Копия <paramref name="format" />, в которой элементы формата заменены строковыми представления соответствующих объектов в <paramref name="args" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="format" /> или <paramref name="args" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата меньше нуля или больше либо равен длине массива <paramref name="args" />.</exception>
		// Token: 0x0600054E RID: 1358 RVA: 0x00019987 File Offset: 0x00017B87
		public static string Format(string format, params object[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException((format == null) ? "format" : "args");
			}
			return string.FormatHelper(null, format, new ParamsArray(args));
		}

		/// <summary>Заменяет элементы формата в указанной строке строковым представлением соответствующего объекта. Параметр предоставляет сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="arg0">Объект для форматирования.</param>
		/// <returns>Копия <paramref name="format" />, в которой элементы форматирования были заменены строковым представлением <paramref name="arg0" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата не равен нулю.</exception>
		// Token: 0x0600054F RID: 1359 RVA: 0x000199AE File Offset: 0x00017BAE
		public static string Format(IFormatProvider provider, string format, object arg0)
		{
			return string.FormatHelper(provider, format, new ParamsArray(arg0));
		}

		/// <summary>Заменяет элементы формата в строке строковым представлением двух указанных объектов. Параметр предоставляет сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="arg0">Первый объект для форматирования.</param>
		/// <param name="arg1">Второй объект для форматирования.</param>
		/// <returns>Копия <paramref name="format" />, в которой все элементы формата заменены строковыми представлениями <paramref name="arg0" /> и <paramref name="arg1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата не равен нулю или единице.</exception>
		// Token: 0x06000550 RID: 1360 RVA: 0x000199BD File Offset: 0x00017BBD
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
		{
			return string.FormatHelper(provider, format, new ParamsArray(arg0, arg1));
		}

		/// <summary>Заменяет элементы формата в строке строковым представлением трех указанных объектов. Параметр предоставляет сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="arg0">Первый объект для форматирования.</param>
		/// <param name="arg1">Второй объект для форматирования.</param>
		/// <param name="arg2">Третий объект для форматирования.</param>
		/// <returns>Копия <paramref name="format" />, в которой все элементы формата заменены строковыми представлениями <paramref name="arg0" />, <paramref name="arg1" /> и <paramref name="arg2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата меньше нуля или больше двух.</exception>
		// Token: 0x06000551 RID: 1361 RVA: 0x000199CD File Offset: 0x00017BCD
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
		{
			return string.FormatHelper(provider, format, new ParamsArray(arg0, arg1, arg2));
		}

		/// <summary>Заменяет элементы формата в строке строковым представлениями соответствующих объектов в указанном массиве. Параметр предоставляет сведения об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="format">Строка составного форматирования.</param>
		/// <param name="args">Массив объектов, содержащий нуль или более форматируемых объектов.</param>
		/// <returns>Копия <paramref name="format" />, в которой элементы формата заменены строковыми представления соответствующих объектов в <paramref name="args" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="format" /> или <paramref name="args" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		/// -или- 
		/// Индекс элемента формата меньше нуля или больше либо равен длине массива <paramref name="args" />.</exception>
		// Token: 0x06000552 RID: 1362 RVA: 0x000199DF File Offset: 0x00017BDF
		public static string Format(IFormatProvider provider, string format, params object[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException((format == null) ? "format" : "args");
			}
			return string.FormatHelper(provider, format, new ParamsArray(args));
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00019A06 File Offset: 0x00017C06
		private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			return StringBuilderCache.GetStringAndRelease(StringBuilderCache.Acquire(format.Length + args.Length * 8).AppendFormatHelper(provider, format, args));
		}

		/// <summary>Возвращает новую строку, в которой указанная строка вставляется в указанной позиции индекса в данном экземпляре.</summary>
		/// <param name="startIndex">Положение отсчитываемого от нуля индекса вставки.</param>
		/// <param name="value">Строка, которую требуется вставить.</param>
		/// <returns>Новая строка, эквивалентная данному экземпляру, но с тем отличием, что в положение <paramref name="value" /> помещено значение <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> имеет отрицательное значение или больше длины этого экземпляра.</exception>
		// Token: 0x06000554 RID: 1364 RVA: 0x00019A38 File Offset: 0x00017C38
		public unsafe string Insert(int startIndex, string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0 || startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex");
			}
			int length = this.Length;
			int length2 = value.Length;
			if (length == 0)
			{
				return value;
			}
			if (length2 == 0)
			{
				return this;
			}
			string text = string.FastAllocateString(length + length2);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &value._firstChar)
				{
					char* smem = ptr3;
					fixed (char* ptr4 = &text._firstChar)
					{
						char* ptr5 = ptr4;
						string.wstrcpy(ptr5, ptr2, startIndex);
						string.wstrcpy(ptr5 + startIndex, smem, length2);
						string.wstrcpy(ptr5 + startIndex + length2, ptr2 + startIndex, length - startIndex);
					}
				}
			}
			return text;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00019AE6 File Offset: 0x00017CE6
		public static string Join(char separator, params string[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return string.Join(separator, value, 0, value.Length);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00019B01 File Offset: 0x00017D01
		public unsafe static string Join(char separator, params object[] values)
		{
			return string.JoinCore(&separator, 1, values);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00019B0D File Offset: 0x00017D0D
		public unsafe static string Join<T>(char separator, IEnumerable<T> values)
		{
			return string.JoinCore<T>(&separator, 1, values);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00019B19 File Offset: 0x00017D19
		public unsafe static string Join(char separator, string[] value, int startIndex, int count)
		{
			return string.JoinCore(&separator, 1, value, startIndex, count);
		}

		/// <summary>Сцепляет все элементы массива строк, помещая между ними заданный разделитель.</summary>
		/// <param name="separator">Строка для использования в качестве разделителя. <paramref name="separator" /> включается в возвращаемую строку, только если в <paramref name="value" /> более одного элемента.</param>
		/// <param name="value">Массив, содержащий элементы, которые требуется сцепить.</param>
		/// <returns>Строка, состоящая из элементов <paramref name="value" />, разделяемых строками <paramref name="separator" />. Если <paramref name="value" /> равен пустому массиву, метод возвращает значение <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06000559 RID: 1369 RVA: 0x00019B27 File Offset: 0x00017D27
		public static string Join(string separator, params string[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return string.Join(separator, value, 0, value.Length);
		}

		/// <summary>Сцепляет элементы массива объектов, помещая между ними заданный разделитель.</summary>
		/// <param name="separator">Строка для использования в качестве разделителя. <paramref name="separator" /> включается в возвращаемую строку, только если в <paramref name="values" /> более одного элемента.</param>
		/// <param name="values">Массив, содержащий элементы, которые требуется сцепить.</param>
		/// <returns>Строка, состоящая из элементов <paramref name="values" />, разделяемых строками <paramref name="separator" />. Если <paramref name="values" /> равен пустому массиву, метод возвращает значение <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		// Token: 0x0600055A RID: 1370 RVA: 0x00019B44 File Offset: 0x00017D44
		public unsafe static string Join(string separator, params object[] values)
		{
			separator = (separator ?? string.Empty);
			fixed (char* ptr = &separator._firstChar)
			{
				return string.JoinCore(ptr, separator.Length, values);
			}
		}

		/// <summary>Сцепляет элементы созданной коллекции, помещая между ними заданный разделитель.</summary>
		/// <param name="separator">Строка для использования в качестве разделителя.<paramref name="separator" /> включается в возвращаемую строку, только если в <paramref name="values" /> более одного элемента.</param>
		/// <param name="values">Коллекция, содержащая сцепляемые объекты.</param>
		/// <typeparam name="T">Тип элементов параметра <paramref name="values" />.</typeparam>
		/// <returns>Строка, состоящая из элементов <paramref name="values" />, разделяемых строками <paramref name="separator" />. Если <paramref name="values" /> не содержит членов, метод возвращает <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		// Token: 0x0600055B RID: 1371 RVA: 0x00019B74 File Offset: 0x00017D74
		public unsafe static string Join<T>(string separator, IEnumerable<T> values)
		{
			separator = (separator ?? string.Empty);
			fixed (char* ptr = &separator._firstChar)
			{
				return string.JoinCore<T>(ptr, separator.Length, values);
			}
		}

		/// <summary>Сцепляет элементы созданной коллекции <see cref="T:System.Collections.Generic.IEnumerable`1" /> типа <see cref="T:System.String" />, помещая между ними заданный разделитель.</summary>
		/// <param name="separator">Строка для использования в качестве разделителя.<paramref name="separator" /> включается в возвращаемую строку, только если в <paramref name="values" /> более одного элемента.</param>
		/// <param name="values">Коллекция, содержащая сцепляемые строки.</param>
		/// <returns>Строка, состоящая из элементов <paramref name="values" />, разделяемых строками <paramref name="separator" />. Если <paramref name="values" /> не содержит членов, метод возвращает <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> — <see langword="null" />.</exception>
		// Token: 0x0600055C RID: 1372 RVA: 0x00019BA4 File Offset: 0x00017DA4
		public static string Join(string separator, IEnumerable<string> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			string result;
			using (IEnumerator<string> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					string text = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
						stringBuilder.Append(text);
						do
						{
							stringBuilder.Append(separator);
							stringBuilder.Append(enumerator.Current);
						}
						while (enumerator.MoveNext());
						result = StringBuilderCache.GetStringAndRelease(stringBuilder);
					}
				}
			}
			return result;
		}

		/// <summary>Сцепляет указанные элементы массива строк, помещая между ними заданный разделитель.</summary>
		/// <param name="separator">Строка для использования в качестве разделителя. <paramref name="separator" /> включается в возвращаемую строку, только если в <paramref name="value" /> более одного элемента.</param>
		/// <param name="value">Массив, содержащий элементы, которые требуется сцепить.</param>
		/// <param name="startIndex">Первый используемый элемент массива <paramref name="value" />.</param>
		/// <param name="count">Число используемых элементов массива <paramref name="value" />.</param>
		/// <returns>Строка, состоящая из строк из параметра <paramref name="value" />, разделяемых строками <paramref name="separator" />.  
		/// -или- 
		///  <see cref="F:System.String.Empty" />, если параметр <paramref name="count" /> равен нулю, параметр <paramref name="value" /> не содержит элементов или параметр <paramref name="separator" /> и все элементы параметра <paramref name="value" /> равны <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="count" /> меньше 0.  
		/// -или- 
		///  <paramref name="startIndex" /> плюс <paramref name="count" /> больше, чем число элементов в <paramref name="value" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти.</exception>
		// Token: 0x0600055D RID: 1373 RVA: 0x00019C44 File Offset: 0x00017E44
		public unsafe static string Join(string separator, string[] value, int startIndex, int count)
		{
			separator = (separator ?? string.Empty);
			fixed (char* ptr = &separator._firstChar)
			{
				return string.JoinCore(ptr, separator.Length, value, startIndex, count);
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00019C74 File Offset: 0x00017E74
		private unsafe static string JoinCore(char* separator, int separatorLength, object[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				return string.Empty;
			}
			object obj = values[0];
			string text = (obj != null) ? obj.ToString() : null;
			if (values.Length == 1)
			{
				return text ?? string.Empty;
			}
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			stringBuilder.Append(text);
			for (int i = 1; i < values.Length; i++)
			{
				stringBuilder.Append(separator, separatorLength);
				object obj2 = values[i];
				if (obj2 != null)
				{
					stringBuilder.Append(obj2.ToString());
				}
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00019CFC File Offset: 0x00017EFC
		private unsafe static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			string result;
			using (IEnumerator<T> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					T t = enumerator.Current;
					string text = (t != null) ? t.ToString() : null;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
						stringBuilder.Append(text);
						do
						{
							t = enumerator.Current;
							stringBuilder.Append(separator, separatorLength);
							if (t != null)
							{
								stringBuilder.Append(t.ToString());
							}
						}
						while (enumerator.MoveNext());
						result = StringBuilderCache.GetStringAndRelease(stringBuilder);
					}
				}
			}
			return result;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00019DD4 File Offset: 0x00017FD4
		private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (startIndex > value.Length - count)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index and count must refer to a location within the buffer.");
			}
			if (count <= 1)
			{
				string result;
				if (count != 0)
				{
					if ((result = value[startIndex]) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			long num = (long)(count - 1) * (long)separatorLength;
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			int num2 = (int)num;
			int i = startIndex;
			int num3 = startIndex + count;
			while (i < num3)
			{
				string text = value[i];
				if (text != null)
				{
					num2 += text.Length;
					if (num2 < 0)
					{
						throw new OutOfMemoryException();
					}
				}
				i++;
			}
			string text2 = string.FastAllocateString(num2);
			int num4 = 0;
			int j = startIndex;
			int num5 = startIndex + count;
			while (j < num5)
			{
				string text3 = value[j];
				if (text3 != null)
				{
					int length = text3.Length;
					if (length > num2 - num4)
					{
						num4 = -1;
						break;
					}
					string.FillStringChecked(text2, num4, text3);
					num4 += length;
				}
				if (j < num5 - 1)
				{
					fixed (char* ptr = &text2._firstChar)
					{
						char* ptr2 = ptr;
						if (separatorLength == 1)
						{
							ptr2[num4] = *separator;
						}
						else
						{
							string.wstrcpy(ptr2 + num4, separator, separatorLength);
						}
					}
					num4 += separatorLength;
				}
				j++;
			}
			if (num4 != num2)
			{
				return string.JoinCore(separator, separatorLength, (string[])value.Clone(), startIndex, count);
			}
			return text2;
		}

		/// <summary>Возвращает новую строку, в которой знаки данного экземпляра выровнены по правому краю путем добавления слева символов-разделителей до указанной общей длины.</summary>
		/// <param name="totalWidth">Количество знаков в полученной строке, равное числу исходных знаков плюс некоторое количество добавленных для заполнения знаков.</param>
		/// <returns>Новая строка, эквивалентная данному экземпляру, но с выравниванием по правому краю и с добавленными слева пробелами, необходимыми для достижения длины <paramref name="totalWidth" />. Однако если значение параметра <paramref name="totalWidth" /> меньше длины данного экземпляра, метод возвращает ссылку на имеющийся экземпляр. Если значение параметра <paramref name="totalWidth" /> равно длине данного экземпляра, метод возвращает новую строку, идентичную данному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="totalWidth" /> меньше нуля.</exception>
		// Token: 0x06000561 RID: 1377 RVA: 0x00019F38 File Offset: 0x00018138
		public string PadLeft(int totalWidth)
		{
			return this.PadLeft(totalWidth, ' ');
		}

		/// <summary>Возвращает новую строку, в которой знаки данного экземпляра выровнены по правому краю путем добавления слева пробелов или указанного знака Юникода до указанной общей длины.</summary>
		/// <param name="totalWidth">Количество знаков в полученной строке, равное числу исходных знаков плюс некоторое количество добавленных для заполнения знаков.</param>
		/// <param name="paddingChar">Добавляемый в качестве заполнителя знак Юникода.</param>
		/// <returns>Новая строка, эквивалентная данному экземпляру, но с выравниванием по правому краю и с добавленными слева знаками <paramref name="paddingChar" />, необходимыми для достижения длины <paramref name="totalWidth" />. Однако если значение параметра <paramref name="totalWidth" /> меньше длины данного экземпляра, метод возвращает ссылку на имеющийся экземпляр. Если значение параметра <paramref name="totalWidth" /> равно длине данного экземпляра, метод возвращает новую строку, идентичную данному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="totalWidth" /> меньше нуля.</exception>
		// Token: 0x06000562 RID: 1378 RVA: 0x00019F44 File Offset: 0x00018144
		public unsafe string PadLeft(int totalWidth, char paddingChar)
		{
			if (totalWidth < 0)
			{
				throw new ArgumentOutOfRangeException("totalWidth", "Non-negative number required.");
			}
			int length = this.Length;
			int num = totalWidth - length;
			if (num <= 0)
			{
				return this;
			}
			string text = string.FastAllocateString(totalWidth);
			fixed (char* ptr = &text._firstChar)
			{
				char* ptr2 = ptr;
				for (int i = 0; i < num; i++)
				{
					ptr2[i] = paddingChar;
				}
				fixed (char* ptr3 = &this._firstChar)
				{
					char* smem = ptr3;
					string.wstrcpy(ptr2 + num, smem, length);
				}
			}
			return text;
		}

		/// <summary>Возвращает новую строку, в которой знаки данной строки выровнены по левому краю путем добавления справа символов-разделителей до указанной общей длины.</summary>
		/// <param name="totalWidth">Количество знаков в полученной строке, равное числу исходных знаков плюс некоторое количество добавленных для заполнения знаков.</param>
		/// <returns>Новая строка, эквивалентная данному экземпляру, но с выравниванием по левому краю и с добавленными справа пробелами, необходимыми для достижения длины <paramref name="totalWidth" />. Однако если значение параметра <paramref name="totalWidth" /> меньше длины данного экземпляра, метод возвращает ссылку на имеющийся экземпляр. Если значение параметра <paramref name="totalWidth" /> равно длине данного экземпляра, метод возвращает новую строку, идентичную данному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="totalWidth" /> меньше нуля.</exception>
		// Token: 0x06000563 RID: 1379 RVA: 0x00019FC6 File Offset: 0x000181C6
		public string PadRight(int totalWidth)
		{
			return this.PadRight(totalWidth, ' ');
		}

		/// <summary>Возвращает новую строку, в которой знаки данной строки выровнены по левому краю путем добавления справа пробелов или указанного знака Юникода до указанной общей длины.</summary>
		/// <param name="totalWidth">Количество знаков в полученной строке, равное числу исходных знаков плюс некоторое количество добавленных для заполнения знаков.</param>
		/// <param name="paddingChar">Добавляемый в качестве заполнителя знак Юникода.</param>
		/// <returns>Новая строка, эквивалентная данному экземпляру, но с выравниванием по левому краю и с добавленными справа знаками <paramref name="paddingChar" />, необходимыми для достижения длины <paramref name="totalWidth" />. Однако если значение параметра <paramref name="totalWidth" /> меньше длины данного экземпляра, метод возвращает ссылку на имеющийся экземпляр. Если значение параметра <paramref name="totalWidth" /> равно длине данного экземпляра, метод возвращает новую строку, идентичную данному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="totalWidth" /> меньше нуля.</exception>
		// Token: 0x06000564 RID: 1380 RVA: 0x00019FD4 File Offset: 0x000181D4
		public unsafe string PadRight(int totalWidth, char paddingChar)
		{
			if (totalWidth < 0)
			{
				throw new ArgumentOutOfRangeException("totalWidth", "Non-negative number required.");
			}
			int length = this.Length;
			int num = totalWidth - length;
			if (num <= 0)
			{
				return this;
			}
			string text = string.FastAllocateString(totalWidth);
			fixed (char* ptr = &text._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &this._firstChar)
				{
					char* smem = ptr3;
					string.wstrcpy(ptr2, smem, length);
				}
				for (int i = 0; i < num; i++)
				{
					ptr2[length + i] = paddingChar;
				}
			}
			return text;
		}

		/// <summary>Возвращает новую строку, в которой было удалено указанное число символов в указанной позиции.</summary>
		/// <param name="startIndex">Отсчитываемая от нуля позиция, с которой начинается удаление знаков.</param>
		/// <param name="count">Число символов для удаления.</param>
		/// <returns>Новая строка, эквивалентная данному экземпляру за минусом удаленных знаков.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> или <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> плюс <paramref name="count" /> указывает позицию за пределами этого экземпляра.</exception>
		// Token: 0x06000565 RID: 1381 RVA: 0x0001A054 File Offset: 0x00018254
		public unsafe string Remove(int startIndex, int count)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			int length = this.Length;
			if (count > length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Index and count must refer to a location within the string.");
			}
			if (count == 0)
			{
				return this;
			}
			int num = length - count;
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &text._firstChar)
				{
					char* ptr4 = ptr3;
					string.wstrcpy(ptr4, ptr2, startIndex);
					string.wstrcpy(ptr4 + startIndex, ptr2 + startIndex + count, num - startIndex);
				}
			}
			return text;
		}

		/// <summary>Возвращает новую строку, в которой были удалены все символы, начиная с указанной позиции и до конца в текущем экземпляре.</summary>
		/// <param name="startIndex">Отсчитываемая от нуля позиция, с которой начинается удаление знаков.</param>
		/// <returns>Новая строка, эквивалентная данной строке за минусом удаленных знаков.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> указывает положение, которое находится за пределами этой строки.</exception>
		// Token: 0x06000566 RID: 1382 RVA: 0x0001A0FA File Offset: 0x000182FA
		public string Remove(int startIndex)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (startIndex >= this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "startIndex must be less than length of string.");
			}
			return this.Substring(0, startIndex);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001A131 File Offset: 0x00018331
		public string Replace(string oldValue, string newValue, bool ignoreCase, CultureInfo culture)
		{
			return this.ReplaceCore(oldValue, newValue, culture, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001A144 File Offset: 0x00018344
		public string Replace(string oldValue, string newValue, StringComparison comparisonType)
		{
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return this.ReplaceCore(oldValue, newValue, CultureInfo.CurrentCulture, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return this.ReplaceCore(oldValue, newValue, CultureInfo.CurrentCulture, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return this.ReplaceCore(oldValue, newValue, CultureInfo.InvariantCulture, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return this.ReplaceCore(oldValue, newValue, CultureInfo.InvariantCulture, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return this.Replace(oldValue, newValue);
			case StringComparison.OrdinalIgnoreCase:
				return this.ReplaceCore(oldValue, newValue, CultureInfo.InvariantCulture, CompareOptions.OrdinalIgnoreCase);
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001A1D8 File Offset: 0x000183D8
		private unsafe string ReplaceCore(string oldValue, string newValue, CultureInfo culture, CompareOptions options)
		{
			if (oldValue == null)
			{
				throw new ArgumentNullException("oldValue");
			}
			if (oldValue.Length == 0)
			{
				throw new ArgumentException("String cannot be of zero length.", "oldValue");
			}
			if (newValue == null)
			{
				newValue = string.Empty;
			}
			CultureInfo cultureInfo = culture ?? CultureInfo.CurrentCulture;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			int num = 0;
			int num2 = 0;
			bool flag = false;
			CompareInfo compareInfo = cultureInfo.CompareInfo;
			for (;;)
			{
				int num3 = compareInfo.IndexOf(this, oldValue, num, this.Length - num, options, &num2);
				if (num3 >= 0)
				{
					stringBuilder.Append(this, num, num3 - num);
					stringBuilder.Append(newValue);
					num = num3 + num2;
					flag = true;
				}
				else
				{
					if (!flag)
					{
						break;
					}
					stringBuilder.Append(this, num, this.Length - num);
				}
				if (num3 < 0)
				{
					goto Block_7;
				}
			}
			StringBuilderCache.Release(stringBuilder);
			return this;
			Block_7:
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		/// <summary>Возвращает новую строку, в которой все вхождения заданного знака Юникода в текущем экземпляре заменены другим заданным знаком Юникода.</summary>
		/// <param name="oldChar">Заменяемый знак Юникода.</param>
		/// <param name="newChar">Знак Юникода для замены всех обнаруженных вхождений <paramref name="oldChar" />.</param>
		/// <returns>Строка, эквивалентная данному экземпляру, но с тем отличием, что все вхождения <paramref name="oldChar" /> заменены на <paramref name="newChar" />. Если <paramref name="oldChar" /> не обнаружен в текущем экземпляре метод возвращает текущий экземпляр без изменений.</returns>
		// Token: 0x0600056A RID: 1386 RVA: 0x0001A298 File Offset: 0x00018498
		public unsafe string Replace(char oldChar, char newChar)
		{
			if (oldChar == newChar)
			{
				return this;
			}
			int num = this.Length;
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				while (num > 0 && *ptr2 != oldChar)
				{
					num--;
					ptr2++;
				}
			}
			if (num == 0)
			{
				return this;
			}
			string text = string.FastAllocateString(this.Length);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr3 = ptr;
				fixed (char* ptr4 = &text._firstChar)
				{
					char* ptr5 = ptr4;
					int num2 = this.Length - num;
					if (num2 > 0)
					{
						string.wstrcpy(ptr5, ptr3, num2);
					}
					char* ptr6 = ptr3 + num2;
					char* ptr7 = ptr5 + num2;
					do
					{
						char c = *ptr6;
						if (c == oldChar)
						{
							c = newChar;
						}
						*ptr7 = c;
						num--;
						ptr6++;
						ptr7++;
					}
					while (num > 0);
				}
			}
			return text;
		}

		/// <summary>Возвращает новую строку, в которой все вхождения заданной строки в текущем экземпляре заменены другой заданной строкой.</summary>
		/// <param name="oldValue">Строка, которую требуется заменить.</param>
		/// <param name="newValue">Строка для замены всех вхождений <paramref name="oldValue" />.</param>
		/// <returns>Строка, эквивалентная текущей строке, но с тем отличием, что все вхождения <paramref name="oldValue" /> заменены на <paramref name="newValue" />. Если <paramref name="oldValue" /> не обнаружен в текущем экземпляре метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="oldValue" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="oldValue" /> является пустой строкой ("").</exception>
		// Token: 0x0600056B RID: 1387 RVA: 0x0001A358 File Offset: 0x00018558
		public unsafe string Replace(string oldValue, string newValue)
		{
			if (oldValue == null)
			{
				throw new ArgumentNullException("oldValue");
			}
			if (oldValue.Length == 0)
			{
				throw new ArgumentException("String cannot be of zero length.", "oldValue");
			}
			if (newValue == null)
			{
				newValue = string.Empty;
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				int i = 0;
				int num = this.Length - oldValue.Length;
				IL_B6:
				while (i <= num)
				{
					char* ptr3 = ptr2 + i;
					for (int j = 0; j < oldValue.Length; j++)
					{
						if (ptr3[j] != oldValue[j])
						{
							i++;
							goto IL_B6;
						}
					}
					valueListBuilder.Append(i);
					i += oldValue.Length;
				}
			}
			if (valueListBuilder.Length == 0)
			{
				return this;
			}
			string result = this.ReplaceHelper(oldValue.Length, newValue, valueListBuilder.AsSpan());
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0001A44C File Offset: 0x0001864C
		private unsafe string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
		{
			long num = (long)this.Length + (long)(newValue.Length - oldValueLength) * (long)indices.Length;
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			string text = string.FastAllocateString((int)num);
			Span<char> span = new Span<char>(text.GetRawStringData(), text.Length);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < indices.Length; i++)
			{
				int num4 = *indices[i];
				int num5 = num4 - num2;
				if (num5 != 0)
				{
					this.AsSpan(num2, num5).CopyTo(span.Slice(num3));
					num3 += num5;
				}
				num2 = num4 + oldValueLength;
				newValue.AsSpan().CopyTo(span.Slice(num3));
				num3 += newValue.Length;
			}
			this.AsSpan(num2).CopyTo(span.Slice(num3));
			return text;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001A523 File Offset: 0x00018723
		public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(new ReadOnlySpan<char>(ref separator, 1), int.MaxValue, options);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001A539 File Offset: 0x00018739
		public string[] Split(char separator, int count, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(new ReadOnlySpan<char>(ref separator, 1), count, options);
		}

		/// <summary>Разбивает строку на подстроки в зависимости от символов в массиве.</summary>
		/// <param name="separator">Массив символов, разделяющий подстроки в данной строке, пустой массив, не содержащий разделителей, или <see langword="null" />.</param>
		/// <returns>Массив, элементы которого содержат подстроки из этого экземпляра, разделенные символами из <paramref name="separator" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		// Token: 0x0600056F RID: 1391 RVA: 0x0001A54B File Offset: 0x0001874B
		public string[] Split(params char[] separator)
		{
			return this.SplitInternal(separator, int.MaxValue, StringSplitOptions.None);
		}

		/// <summary>Разбивает строку на максимальное число подстрок в зависимости от символов в массиве. Можно также указать максимальное число возвращаемых подстрок.</summary>
		/// <param name="separator">Массив символов, разделяющий подстроки в данной строке, пустой массив, не содержащий разделителей, или <see langword="null" />.</param>
		/// <param name="count">Максимальное число возвращаемых подстрок.</param>
		/// <returns>Массив, элементы которого содержат подстроки данного экземпляра, разделенные одним или более знаками из <paramref name="separator" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.</exception>
		// Token: 0x06000570 RID: 1392 RVA: 0x0001A55F File Offset: 0x0001875F
		public string[] Split(char[] separator, int count)
		{
			return this.SplitInternal(separator, count, StringSplitOptions.None);
		}

		/// <summary>Разбивает строку на подстроки в зависимости от символов в массиве. Можно указать, включают ли подстроки пустые элементы массива.</summary>
		/// <param name="separator">Массив символов, разделяющий подстроки в данной строке, пустой массив, не содержащий разделителей, или <see langword="null" />.</param>
		/// <param name="options">
		///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" />, чтобы исключить пустые элементы из возвращаемого массива; или <see cref="F:System.StringSplitOptions.None" /> для включения пустых элементов в возвращаемый массив.</param>
		/// <returns>Массив, элементы которого содержат подстроки данной строки, разделенные одним или более знаками из <paramref name="separator" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является одним из значений <see cref="T:System.StringSplitOptions" />.</exception>
		// Token: 0x06000571 RID: 1393 RVA: 0x0001A56F File Offset: 0x0001876F
		public string[] Split(char[] separator, StringSplitOptions options)
		{
			return this.SplitInternal(separator, int.MaxValue, options);
		}

		/// <summary>Разбивает строку на максимальное число подстрок в зависимости от символов в массиве.</summary>
		/// <param name="separator">Массив символов, разделяющий подстроки в данной строке, пустой массив, не содержащий разделителей, или <see langword="null" />.</param>
		/// <param name="count">Максимальное число возвращаемых подстрок.</param>
		/// <param name="options">
		///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" />, чтобы исключить пустые элементы из возвращаемого массива; или <see cref="F:System.StringSplitOptions.None" /> для включения пустых элементов в возвращаемый массив.</param>
		/// <returns>Массив, элементы которого содержат подстроки данной строки, разделенные одним или более знаками из <paramref name="separator" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является одним из значений <see cref="T:System.StringSplitOptions" />.</exception>
		// Token: 0x06000572 RID: 1394 RVA: 0x0001A583 File Offset: 0x00018783
		public string[] Split(char[] separator, int count, StringSplitOptions options)
		{
			return this.SplitInternal(separator, count, options);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0001A594 File Offset: 0x00018794
		private unsafe string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (options < StringSplitOptions.None || options > StringSplitOptions.RemoveEmptyEntries)
			{
				throw new ArgumentException(SR.Format("Illegal enum value: {0}.", options));
			}
			bool flag = options == StringSplitOptions.RemoveEmptyEntries;
			if (count == 0 || (flag && this.Length == 0))
			{
				return Array.Empty<string>();
			}
			if (count == 1)
			{
				return new string[]
				{
					this
				};
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			this.MakeSeparatorList(separators, ref valueListBuilder);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			if (sepList.Length == 0)
			{
				return new string[]
				{
					this
				};
			}
			string[] result = flag ? this.SplitOmitEmptyEntries(sepList, default(ReadOnlySpan<int>), 1, count) : this.SplitKeepEmptyEntries(sepList, default(ReadOnlySpan<int>), 1, count);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0001A66D File Offset: 0x0001886D
		public string[] Split(string separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(separator ?? string.Empty, null, int.MaxValue, options);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001A686 File Offset: 0x00018886
		public string[] Split(string separator, int count, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(separator ?? string.Empty, null, count, options);
		}

		/// <summary>Разбивает строку на подстроки в зависимости от строк в массиве. Можно указать, включают ли подстроки пустые элементы массива.</summary>
		/// <param name="separator">Массив строк, разделяющих подстроки в данной строке, пустой массив, не содержащий разделителей, или <see langword="null" />.</param>
		/// <param name="options">
		///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" />, чтобы исключить пустые элементы из возвращаемого массива; или <see cref="F:System.StringSplitOptions.None" /> для включения пустых элементов в возвращаемый массив.</param>
		/// <returns>Массив, элементы которого содержат подстроки данной строки, разделенные одной или более строками из <paramref name="separator" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является одним из значений <see cref="T:System.StringSplitOptions" />.</exception>
		// Token: 0x06000576 RID: 1398 RVA: 0x0001A69B File Offset: 0x0001889B
		public string[] Split(string[] separator, StringSplitOptions options)
		{
			return this.SplitInternal(null, separator, int.MaxValue, options);
		}

		/// <summary>Разбивает строку на максимальное число подстрок в зависимости от строк в массиве. Можно указать, включают ли подстроки пустые элементы массива.</summary>
		/// <param name="separator">Массив строк, разделяющих подстроки в данной строке, пустой массив, не содержащий разделителей, или <see langword="null" />.</param>
		/// <param name="count">Максимальное число возвращаемых подстрок.</param>
		/// <param name="options">
		///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" />, чтобы исключить пустые элементы из возвращаемого массива; или <see cref="F:System.StringSplitOptions.None" /> для включения пустых элементов в возвращаемый массив.</param>
		/// <returns>Массив, элементы которого содержат подстроки данной строки, разделенные одной или более строками из <paramref name="separator" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> не является одним из значений <see cref="T:System.StringSplitOptions" />.</exception>
		// Token: 0x06000577 RID: 1399 RVA: 0x0001A6AB File Offset: 0x000188AB
		public string[] Split(string[] separator, int count, StringSplitOptions options)
		{
			return this.SplitInternal(null, separator, count, options);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001A6B8 File Offset: 0x000188B8
		private unsafe string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (options < StringSplitOptions.None || options > StringSplitOptions.RemoveEmptyEntries)
			{
				throw new ArgumentException(SR.Format("Illegal enum value: {0}.", (int)options));
			}
			bool flag = options == StringSplitOptions.RemoveEmptyEntries;
			bool flag2 = separator != null;
			if (!flag2 && (separators == null || separators.Length == 0))
			{
				return this.SplitInternal(null, count, options);
			}
			if (count == 0 || (flag && this.Length == 0))
			{
				return Array.Empty<string>();
			}
			if (count == 1 || (flag2 && separator.Length == 0))
			{
				return new string[]
				{
					this
				};
			}
			if (flag2)
			{
				return this.SplitInternal(separator, count, options);
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			Span<int> initialSpan2 = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder2 = new ValueListBuilder<int>(initialSpan2);
			this.MakeSeparatorList(separators, ref valueListBuilder, ref valueListBuilder2);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			ReadOnlySpan<int> lengthList = valueListBuilder2.AsSpan();
			if (sepList.Length == 0)
			{
				return new string[]
				{
					this
				};
			}
			string[] result = flag ? this.SplitOmitEmptyEntries(sepList, lengthList, 0, count) : this.SplitKeepEmptyEntries(sepList, lengthList, 0, count);
			valueListBuilder.Dispose();
			valueListBuilder2.Dispose();
			return result;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001A7F0 File Offset: 0x000189F0
		private unsafe string[] SplitInternal(string separator, int count, StringSplitOptions options)
		{
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			this.MakeSeparatorList(separator, ref valueListBuilder);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			if (sepList.Length == 0)
			{
				return new string[]
				{
					this
				};
			}
			string[] result = (options == StringSplitOptions.RemoveEmptyEntries) ? this.SplitOmitEmptyEntries(sepList, default(ReadOnlySpan<int>), separator.Length, count) : this.SplitKeepEmptyEntries(sepList, default(ReadOnlySpan<int>), separator.Length, count);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001A878 File Offset: 0x00018A78
		private unsafe string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int num = 0;
			int num2 = 0;
			count--;
			int num3 = (sepList.Length < count) ? sepList.Length : count;
			string[] array = new string[num3 + 1];
			int num4 = 0;
			while (num4 < num3 && num < this.Length)
			{
				array[num2++] = this.Substring(num, *sepList[num4] - num);
				num = *sepList[num4] + (lengthList.IsEmpty ? defaultLength : (*lengthList[num4]));
				num4++;
			}
			if (num < this.Length && num3 >= 0)
			{
				array[num2] = this.Substring(num);
			}
			else if (num2 == num3)
			{
				array[num2] = string.Empty;
			}
			return array;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001A92C File Offset: 0x00018B2C
		private unsafe string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int length = sepList.Length;
			int num = (length < count) ? (length + 1) : count;
			string[] array = new string[num];
			int num2 = 0;
			int num3 = 0;
			int i = 0;
			while (i < length && num2 < this.Length)
			{
				if (*sepList[i] - num2 > 0)
				{
					array[num3++] = this.Substring(num2, *sepList[i] - num2);
				}
				num2 = *sepList[i] + (lengthList.IsEmpty ? defaultLength : (*lengthList[i]));
				if (num3 == count - 1)
				{
					while (i < length - 1)
					{
						if (num2 != *sepList[++i])
						{
							break;
						}
						num2 += (lengthList.IsEmpty ? defaultLength : (*lengthList[i]));
					}
					break;
				}
				i++;
			}
			if (num2 < this.Length)
			{
				array[num3++] = this.Substring(num2);
			}
			string[] array2 = array;
			if (num3 != num)
			{
				array2 = new string[num3];
				for (int j = 0; j < num3; j++)
				{
					array2[j] = array[j];
				}
			}
			return array2;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001AA4C File Offset: 0x00018C4C
		private unsafe void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
		{
			switch (separators.Length)
			{
			case 0:
				for (int i = 0; i < this.Length; i++)
				{
					if (char.IsWhiteSpace(this[i]))
					{
						sepListBuilder.Append(i);
					}
				}
				return;
			case 1:
			{
				char c = (char)(*separators[0]);
				for (int j = 0; j < this.Length; j++)
				{
					if (this[j] == c)
					{
						sepListBuilder.Append(j);
					}
				}
				return;
			}
			case 2:
			{
				char c = (char)(*separators[0]);
				char c2 = (char)(*separators[1]);
				for (int k = 0; k < this.Length; k++)
				{
					char c3 = this[k];
					if (c3 == c || c3 == c2)
					{
						sepListBuilder.Append(k);
					}
				}
				return;
			}
			case 3:
			{
				char c = (char)(*separators[0]);
				char c2 = (char)(*separators[1]);
				char c4 = (char)(*separators[2]);
				for (int l = 0; l < this.Length; l++)
				{
					char c5 = this[l];
					if (c5 == c || c5 == c2 || c5 == c4)
					{
						sepListBuilder.Append(l);
					}
				}
				return;
			}
			default:
			{
				string.ProbabilisticMap probabilisticMap = default(string.ProbabilisticMap);
				uint* charMap = (uint*)(&probabilisticMap);
				string.InitializeProbabilisticMap(charMap, separators);
				for (int m = 0; m < this.Length; m++)
				{
					char c6 = this[m];
					if (string.IsCharBitSet(charMap, (byte)c6) && string.IsCharBitSet(charMap, (byte)(c6 >> 8)) && separators.Contains(c6))
					{
						sepListBuilder.Append(m);
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
		{
			int length = separator.Length;
			for (int i = 0; i < this.Length; i++)
			{
				if (this[i] == separator[0] && length <= this.Length - i && (length == 1 || this.AsSpan(i, length).SequenceEqual(separator)))
				{
					sepListBuilder.Append(i);
					i += length - 1;
				}
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001AC40 File Offset: 0x00018E40
		private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
		{
			int num = separators.Length;
			for (int i = 0; i < this.Length; i++)
			{
				foreach (string text in separators)
				{
					if (!string.IsNullOrEmpty(text))
					{
						int length = text.Length;
						if (this[i] == text[0] && length <= this.Length - i && (length == 1 || this.AsSpan(i, length).SequenceEqual(text)))
						{
							sepListBuilder.Append(i);
							lengthListBuilder.Append(length);
							i += length - 1;
							break;
						}
					}
				}
			}
		}

		/// <summary>Извлекает подстроку из данного экземпляра. Подстрока начинается в указанном положении символов и продолжается до конца строки.</summary>
		/// <param name="startIndex">Отсчитываемая от нуля позиция первого знака подстроки в данном экземпляре.</param>
		/// <returns>Строка, эквивалентная подстроке, которая начинается с <paramref name="startIndex" /> в данном экземпляре, или <see cref="F:System.String.Empty" />, если значение <paramref name="startIndex" /> равно длине данного экземпляра.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> имеет значение меньше нуля или больше длины этого экземпляра.</exception>
		// Token: 0x0600057F RID: 1407 RVA: 0x0001ACCD File Offset: 0x00018ECD
		public string Substring(int startIndex)
		{
			return this.Substring(startIndex, this.Length - startIndex);
		}

		/// <summary>Извлекает подстроку из данного экземпляра. Подстрока начинается с указанной позиции знака и имеет указанную длину.</summary>
		/// <param name="startIndex">Отсчитываемая от нуля позиция первого знака подстроки в данном экземпляре.</param>
		/// <param name="length">Число символов в подстроке.</param>
		/// <returns>Строка, эквивалентная подстроке длиной <paramref name="length" />, которая начинается с <paramref name="startIndex" /> в данном экземпляре, или <see cref="F:System.String.Empty" />, если значение <paramref name="startIndex" /> равно длине данного экземпляра, а значение <paramref name="length" /> равно нулю.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> плюс <paramref name="length" /> указывает на позицию за пределами данного экземпляра.  
		/// -или- 
		///  Значение параметра <paramref name="startIndex" /> или <paramref name="length" /> меньше нуля.</exception>
		// Token: 0x06000580 RID: 1408 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		public string Substring(int startIndex, int length)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "startIndex cannot be larger than length of string.");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (startIndex > this.Length - length)
			{
				throw new ArgumentOutOfRangeException("length", "Index and length must refer to a location within the string.");
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (startIndex == 0 && length == this.Length)
			{
				return this;
			}
			return this.InternalSubString(startIndex, length);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001AD68 File Offset: 0x00018F68
		private unsafe string InternalSubString(int startIndex, int length)
		{
			string text = string.FastAllocateString(length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char* ptr2 = &this._firstChar)
				{
					char* ptr3 = ptr2;
					string.wstrcpy(dmem, ptr3 + startIndex, length);
				}
			}
			return text;
		}

		/// <summary>Возвращает копию этой строки, переведенную в нижний регистр.</summary>
		/// <returns>Строка в нижнем регистре.</returns>
		// Token: 0x06000582 RID: 1410 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		public string ToLower()
		{
			return CultureInfo.CurrentCulture.TextInfo.ToLower(this);
		}

		/// <summary>Возвращает копию этой строки, переведенную в нижний регистр, используя правила определения регистра заданного языка и региональных параметров.</summary>
		/// <param name="culture">Объект, задающий правила определения регистра для языка и региональных параметров.</param>
		/// <returns>Эквивалент текущей строки в нижнем регистре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> — <see langword="null" />.</exception>
		// Token: 0x06000583 RID: 1411 RVA: 0x0001ADB2 File Offset: 0x00018FB2
		public string ToLower(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToLower(this);
		}

		/// <summary>Возвращает копию этого объекта <see cref="T:System.String" />, переведенную в нижний регистр, используя правила учета регистра инвариантного языка и региональных параметров.</summary>
		/// <returns>Эквивалент текущей строки в нижнем регистре.</returns>
		// Token: 0x06000584 RID: 1412 RVA: 0x0001ADCE File Offset: 0x00018FCE
		public string ToLowerInvariant()
		{
			return CultureInfo.InvariantCulture.TextInfo.ToLower(this);
		}

		/// <summary>Возвращает копию этой строки, переведенную в верхний регистр.</summary>
		/// <returns>Эквивалент текущей строки в верхнем регистре.</returns>
		// Token: 0x06000585 RID: 1413 RVA: 0x0001ADE0 File Offset: 0x00018FE0
		public string ToUpper()
		{
			return CultureInfo.CurrentCulture.TextInfo.ToUpper(this);
		}

		/// <summary>Возвращает копию этой строки, переведенную в верхний регистр, используя правила определения регистра заданного языка и региональных параметров.</summary>
		/// <param name="culture">Объект, задающий правила определения регистра для языка и региональных параметров.</param>
		/// <returns>Эквивалент текущей строки в верхнем регистре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> — <see langword="null" />.</exception>
		// Token: 0x06000586 RID: 1414 RVA: 0x0001ADF2 File Offset: 0x00018FF2
		public string ToUpper(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToUpper(this);
		}

		/// <summary>Возвращает копию этого объекта <see cref="T:System.String" />, переведенную в верхний регистр, используя правила учета регистра инвариантного языка и региональных параметров.</summary>
		/// <returns>Эквивалент текущей строки в верхнем регистре.</returns>
		// Token: 0x06000587 RID: 1415 RVA: 0x0001AE0E File Offset: 0x0001900E
		public string ToUpperInvariant()
		{
			return CultureInfo.InvariantCulture.TextInfo.ToUpper(this);
		}

		/// <summary>Удаляет все начальные и конечные символы-разделители из текущего объекта <see cref="T:System.String" />.</summary>
		/// <returns>Строка, оставшаяся после удаления всех символов-разделителей из начала и конца текущей строки. Если в текущем экземпляре невозможно усечь символы, метод возвращает текущий экземпляр без изменений.</returns>
		// Token: 0x06000588 RID: 1416 RVA: 0x0001AE20 File Offset: 0x00019020
		public string Trim()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Both);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001AE29 File Offset: 0x00019029
		public unsafe string Trim(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, string.TrimType.Both);
		}

		/// <summary>Удаляет все начальные и конечные вхождения набора знаков, заданного в виде массива, из текущего объекта <see cref="T:System.String" />.</summary>
		/// <param name="trimChars">Массив удаляемых знаков Юникода или <see langword="null" />.</param>
		/// <returns>Строка, оставшаяся после удаления всех вхождений символов, заданных в параметре <paramref name="trimChars" />, из начала и конца текущей строки. Если значением параметра <paramref name="trimChars" /> является <see langword="null" /> или пустой массив, удаляются символы-разделители. Если в текущем экземпляре невозможно усечь символы, метод возвращает текущий экземпляр без изменений.</returns>
		// Token: 0x0600058A RID: 1418 RVA: 0x0001AE38 File Offset: 0x00019038
		public unsafe string Trim(params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(string.TrimType.Both);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, string.TrimType.Both);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001AE6A File Offset: 0x0001906A
		public string TrimStart()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Head);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0001AE73 File Offset: 0x00019073
		public unsafe string TrimStart(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, string.TrimType.Head);
		}

		/// <summary>Удаляет все начальные вхождения набора знаков, заданного в виде массива, из текущего объекта <see cref="T:System.String" />.</summary>
		/// <param name="trimChars">Массив удаляемых знаков Юникода или <see langword="null" />.</param>
		/// <returns>Строка, оставшаяся после удаления всех вхождений символов, заданных в параметре <paramref name="trimChars" />, из начала текущей строки. Если значением параметра <paramref name="trimChars" /> является <see langword="null" /> или пустой массив, удаляются символы-разделители.</returns>
		// Token: 0x0600058D RID: 1421 RVA: 0x0001AE80 File Offset: 0x00019080
		public unsafe string TrimStart(params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(string.TrimType.Head);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, string.TrimType.Head);
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001AEB2 File Offset: 0x000190B2
		public string TrimEnd()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Tail);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0001AEBB File Offset: 0x000190BB
		public unsafe string TrimEnd(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, string.TrimType.Tail);
		}

		/// <summary>Удаляет все конечные вхождения набора знаков, заданного в виде массива, из текущего объекта <see cref="T:System.String" />.</summary>
		/// <param name="trimChars">Массив удаляемых знаков Юникода или <see langword="null" />.</param>
		/// <returns>Строка, оставшаяся после удаления всех вхождений символов, заданных в параметре <paramref name="trimChars" />, из конца текущей строки. Если значением параметра <paramref name="trimChars" /> является <see langword="null" /> или пустой массив, удаляются символы-разделители в Юникоде. Если в текущем экземпляре невозможно усечь символы, метод возвращает текущий экземпляр без изменений.</returns>
		// Token: 0x06000590 RID: 1424 RVA: 0x0001AEC8 File Offset: 0x000190C8
		public unsafe string TrimEnd(params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(string.TrimType.Tail);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, string.TrimType.Tail);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0001AEFC File Offset: 0x000190FC
		private string TrimWhiteSpaceHelper(string.TrimType trimType)
		{
			int num = this.Length - 1;
			int num2 = 0;
			if (trimType != string.TrimType.Tail)
			{
				num2 = 0;
				while (num2 < this.Length && char.IsWhiteSpace(this[num2]))
				{
					num2++;
				}
			}
			if (trimType != string.TrimType.Head)
			{
				num = this.Length - 1;
				while (num >= num2 && char.IsWhiteSpace(this[num]))
				{
					num--;
				}
			}
			return this.CreateTrimmedString(num2, num);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001AF64 File Offset: 0x00019164
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType)
		{
			int i = this.Length - 1;
			int j = 0;
			if (trimType != string.TrimType.Tail)
			{
				for (j = 0; j < this.Length; j++)
				{
					char c = this[j];
					int num = 0;
					while (num < trimCharsLength && trimChars[num] != c)
					{
						num++;
					}
					if (num == trimCharsLength)
					{
						break;
					}
				}
			}
			if (trimType != string.TrimType.Head)
			{
				for (i = this.Length - 1; i >= j; i--)
				{
					char c2 = this[i];
					int num2 = 0;
					while (num2 < trimCharsLength && trimChars[num2] != c2)
					{
						num2++;
					}
					if (num2 == trimCharsLength)
					{
						break;
					}
				}
			}
			return this.CreateTrimmedString(j, i);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001B000 File Offset: 0x00019200
		private string CreateTrimmedString(int start, int end)
		{
			int num = end - start + 1;
			if (num == this.Length)
			{
				return this;
			}
			if (num != 0)
			{
				return this.InternalSubString(start, num);
			}
			return string.Empty;
		}

		/// <summary>Возвращает значение, указывающее, встречается ли указанная подстрока внутри этой строки.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> встречается в строке или <paramref name="value" /> является пустой строкой (""); в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06000594 RID: 1428 RVA: 0x0001B02F File Offset: 0x0001922F
		public bool Contains(string value)
		{
			return this.IndexOf(value, StringComparison.Ordinal) >= 0;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001B03F File Offset: 0x0001923F
		public bool Contains(string value, StringComparison comparisonType)
		{
			return this.IndexOf(value, comparisonType) >= 0;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001B04F File Offset: 0x0001924F
		public bool Contains(char value)
		{
			return this.IndexOf(value) != -1;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001B05E File Offset: 0x0001925E
		public bool Contains(char value, StringComparison comparisonType)
		{
			return this.IndexOf(value, comparisonType) != -1;
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения указанного символа Юникода в данной строке.</summary>
		/// <param name="value">Искомый знак Юникода.</param>
		/// <returns>Отсчитываемое от нуля значение индекса параметра <paramref name="value" />, если этот знак найден; в противном случае — значение -1.</returns>
		// Token: 0x06000598 RID: 1432 RVA: 0x0001B06E File Offset: 0x0001926E
		public int IndexOf(char value)
		{
			return SpanHelpers.IndexOf(ref this._firstChar, value, this.Length);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения указанного символа Юникода в данной строке. Поиск начинается с указанной позиции знака.</summary>
		/// <param name="value">Искомый знак Юникода.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <returns>Отсчитываемая от нуля позиция индекса параметра <paramref name="value" /> с начала строки, если символ найден. Значение –1, если символ не найден.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> имеет значение меньше нуля или больше длины строки.</exception>
		// Token: 0x06000599 RID: 1433 RVA: 0x0001B082 File Offset: 0x00019282
		public int IndexOf(char value, int startIndex)
		{
			return this.IndexOf(value, startIndex, this.Length - startIndex);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001B094 File Offset: 0x00019294
		public int IndexOf(char value, StringComparison comparisonType)
		{
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IndexOf(this, value, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IndexOf(this, value, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return CompareInfo.Invariant.IndexOf(this, value, CompareOptions.Ordinal);
			case StringComparison.OrdinalIgnoreCase:
				return CompareInfo.Invariant.IndexOf(this, value, CompareOptions.OrdinalIgnoreCase);
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения указанного символа в данном экземпляре. Поиск начинается с указанной позиции знака; проверяется заданное количество позиций.</summary>
		/// <param name="value">Искомый знак Юникода.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <returns>Отсчитываемая от нуля позиция индекса параметра <paramref name="value" /> с начала строки, если символ найден. Значение –1, если символ не найден.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> или <paramref name="startIndex" /> является отрицательным значением.  
		/// -или- 
		///  <paramref name="startIndex" /> больше длины этой строки.  
		/// -или- 
		///  <paramref name="count" /> больше, чем длина этой строки минус <paramref name="startIndex" />.</exception>
		// Token: 0x0600059B RID: 1435 RVA: 0x0001B138 File Offset: 0x00019338
		public int IndexOf(char value, int startIndex, int count)
		{
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > this.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			int num = SpanHelpers.IndexOf(Unsafe.Add<char>(ref this._firstChar, startIndex), value, count);
			if (num != -1)
			{
				return num + startIndex;
			}
			return num;
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого обнаруженного в данном экземпляре символа из указанного массива символов Юникода.</summary>
		/// <param name="anyOf">Массив знаков Юникода, содержащий один или несколько искомых знаков.</param>
		/// <returns>Начинающееся с нуля значение индекса первого вхождения какого-либо знака из <paramref name="anyOf" /> в данном экземпляре; -1, если не найден ни один знак из <paramref name="anyOf" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> — <see langword="null" />.</exception>
		// Token: 0x0600059C RID: 1436 RVA: 0x0001B196 File Offset: 0x00019396
		public int IndexOfAny(char[] anyOf)
		{
			return this.IndexOfAny(anyOf, 0, this.Length);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого обнаруженного в данном экземпляре символа из указанного массива символов Юникода. Поиск начинается с указанной позиции знака.</summary>
		/// <param name="anyOf">Массив знаков Юникода, содержащий один или несколько искомых знаков.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <returns>Начинающееся с нуля значение индекса первого вхождения какого-либо знака из <paramref name="anyOf" /> в данном экземпляре; -1, если не найден ни один знак из <paramref name="anyOf" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> является отрицательным значением.  
		/// -или- 
		///  <paramref name="startIndex" /> больше, чем количество символов в данном экземпляре.</exception>
		// Token: 0x0600059D RID: 1437 RVA: 0x0001B1A6 File Offset: 0x000193A6
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			return this.IndexOfAny(anyOf, startIndex, this.Length - startIndex);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого обнаруженного в данном экземпляре символа из указанного массива символов Юникода. Поиск начинается с указанной позиции знака; проверяется заданное количество позиций.</summary>
		/// <param name="anyOf">Массив знаков Юникода, содержащий один или несколько искомых знаков.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <returns>Начинающееся с нуля значение индекса первого вхождения какого-либо знака из <paramref name="anyOf" /> в данном экземпляре; -1, если не найден ни один знак из <paramref name="anyOf" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> или <paramref name="startIndex" /> является отрицательным значением.  
		/// -или- 
		///  <paramref name="count" /> + <paramref name="startIndex" /> больше, чем количество символов в этом экземпляре.</exception>
		// Token: 0x0600059E RID: 1438 RVA: 0x0001B1B8 File Offset: 0x000193B8
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf == null)
			{
				throw new ArgumentNullException("anyOf");
			}
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > this.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (anyOf.Length == 2)
			{
				return this.IndexOfAny(anyOf[0], anyOf[1], startIndex, count);
			}
			if (anyOf.Length == 3)
			{
				return this.IndexOfAny(anyOf[0], anyOf[1], anyOf[2], startIndex, count);
			}
			if (anyOf.Length > 3)
			{
				return this.IndexOfCharArray(anyOf, startIndex, count);
			}
			if (anyOf.Length == 1)
			{
				return this.IndexOf(anyOf[0], startIndex, count);
			}
			return -1;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001B258 File Offset: 0x00019458
		private unsafe int IndexOfAny(char value1, char value2, int startIndex, int count)
		{
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					char c = *ptr3;
					if (c == value1 || c == value2)
					{
						return (int)((long)(ptr3 - ptr2));
					}
					c = ptr3[1];
					if (c == value1 || c == value2)
					{
						if (count != 1)
						{
							return (int)((long)(ptr3 - ptr2)) + 1;
						}
						return -1;
					}
					else
					{
						ptr3 += 2;
						count -= 2;
					}
				}
				return -1;
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001B2BC File Offset: 0x000194BC
		private unsafe int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
		{
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					char c = *ptr3;
					if (c == value1 || c == value2 || c == value3)
					{
						return (int)((long)(ptr3 - ptr2));
					}
					ptr3++;
					count--;
				}
				return -1;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001B304 File Offset: 0x00019504
		private unsafe int IndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			string.ProbabilisticMap probabilisticMap = default(string.ProbabilisticMap);
			uint* charMap = (uint*)(&probabilisticMap);
			string.InitializeProbabilisticMap(charMap, anyOf);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					int num = (int)(*ptr3);
					if (string.IsCharBitSet(charMap, (byte)num) && string.IsCharBitSet(charMap, (byte)(num >> 8)) && string.ArrayContains((char)num, anyOf))
					{
						return (int)((long)(ptr3 - ptr2));
					}
					count--;
					ptr3++;
				}
				return -1;
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001B380 File Offset: 0x00019580
		private unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
		{
			bool flag = false;
			for (int i = 0; i < anyOf.Length; i++)
			{
				int num = (int)(*anyOf[i]);
				string.SetCharBit(charMap, (byte)num);
				num >>= 8;
				if (num == 0)
				{
					flag = true;
				}
				else
				{
					string.SetCharBit(charMap, (byte)num);
				}
			}
			if (flag)
			{
				*charMap |= 1U;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001B3D4 File Offset: 0x000195D4
		private static bool ArrayContains(char searchChar, char[] anyOf)
		{
			for (int i = 0; i < anyOf.Length; i++)
			{
				if (anyOf[i] == searchChar)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001B3F8 File Offset: 0x000195F8
		private unsafe static bool IsCharBitSet(uint* charMap, byte value)
		{
			return (charMap[value & 7] & 1U << (value >> 3)) > 0U;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001B40F File Offset: 0x0001960F
		private unsafe static void SetCharBit(uint* charMap, byte value)
		{
			charMap[value & 7] |= 1U << (value >> 3);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения значения указанной строки в данном экземпляре.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <returns>Положение в индексе (начиная с нуля) параметра <paramref name="value" />, если эта строка найдена, или значение -1, если она не найдена. Если значение <paramref name="value" /> равно <see cref="F:System.String.Empty" />, то возвращаемое значение равно 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x060005A6 RID: 1446 RVA: 0x0001B425 File Offset: 0x00019625
		public int IndexOf(string value)
		{
			return this.IndexOf(value, StringComparison.CurrentCulture);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения значения указанной строки в данном экземпляре. Поиск начинается с указанной позиции знака.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <returns>Отсчитываемая от нуля позиция индекса параметра <paramref name="value" /> с начала текущего экземпляра, если строка найдена. Значение –1, если строка не найдена. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> имеет значение меньше нуля или больше длины этой строки.</exception>
		// Token: 0x060005A7 RID: 1447 RVA: 0x0001B42F File Offset: 0x0001962F
		public int IndexOf(string value, int startIndex)
		{
			return this.IndexOf(value, startIndex, StringComparison.CurrentCulture);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения значения указанной строки в данном экземпляре. Поиск начинается с указанной позиции знака; проверяется заданное количество позиций.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <returns>Отсчитываемая от нуля позиция индекса параметра <paramref name="value" /> с начала текущего экземпляра, если строка найдена. Значение –1, если строка не найдена. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> или <paramref name="startIndex" /> является отрицательным значением.  
		/// -или- 
		///  <paramref name="startIndex" /> больше длины этой строки.  
		/// -или- 
		///  <paramref name="count" /> больше, чем длина этой строки минус <paramref name="startIndex" />.</exception>
		// Token: 0x060005A8 RID: 1448 RVA: 0x0001B43C File Offset: 0x0001963C
		public int IndexOf(string value, int startIndex, int count)
		{
			if (startIndex < 0 || startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count > this.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			return this.IndexOf(value, startIndex, count, StringComparison.CurrentCulture);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения указанной строки в текущем объекте <see cref="T:System.String" />. Параметр определяет тип поиска заданной строки.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила поиска.</param>
		/// <returns>Индекс позиции строки, заданной в параметре <paramref name="value" />, если она найдена, и -1, если нет. Если значение <paramref name="value" /> равно <see cref="F:System.String.Empty" />, то возвращаемое значение равно 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является допустимым значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060005A9 RID: 1449 RVA: 0x0001B48F File Offset: 0x0001968F
		public int IndexOf(string value, StringComparison comparisonType)
		{
			return this.IndexOf(value, 0, this.Length, comparisonType);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения указанной строки в текущем объекте <see cref="T:System.String" />. Параметры задают начальную позицию поиска в текущей строке и тип поиска.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила поиска.</param>
		/// <returns>Отсчитываемая от нуля позиция параметра <paramref name="value" /> с начала текущего экземпляра, если строка найдена, или -1, если нет. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> имеет значение меньше нуля или больше длины этой строки.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является допустимым значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060005AA RID: 1450 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return this.IndexOf(value, startIndex, this.Length - startIndex, comparisonType);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля первого вхождения указанной строки в текущем объекте <see cref="T:System.String" />. Параметры задают начальную позицию поиска в текущей строке, количество проверяемых знаков текущей строки и тип поиска.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила поиска.</param>
		/// <returns>Отсчитываемая от нуля позиция параметра <paramref name="value" /> с начала текущего экземпляра, если строка найдена, или -1, если нет. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> или <paramref name="startIndex" /> является отрицательным значением.  
		/// -или- 
		///  <paramref name="startIndex" /> больше длины этого экземпляра.  
		/// -или- 
		///  <paramref name="count" /> больше, чем длина этой строки минус <paramref name="startIndex" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является допустимым значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060005AB RID: 1451 RVA: 0x0001B4B4 File Offset: 0x000196B4
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0 || startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex > this.Length - count)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IndexOf(this, value, startIndex, count, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return CompareInfo.Invariant.IndexOfOrdinal(this, value, startIndex, count, false);
			case StringComparison.OrdinalIgnoreCase:
				return CompareInfo.Invariant.IndexOfOrdinal(this, value, startIndex, count, true);
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанного символа Юникода в пределах данного экземпляра.</summary>
		/// <param name="value">Знак Юникода, который необходимо найти.</param>
		/// <returns>Отсчитываемое от нуля значение индекса параметра <paramref name="value" />, если этот знак найден; в противном случае — значение -1.</returns>
		// Token: 0x060005AC RID: 1452 RVA: 0x0001B5A5 File Offset: 0x000197A5
		public int LastIndexOf(char value)
		{
			return SpanHelpers.LastIndexOf(ref this._firstChar, value, this.Length);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанного символа Юникода в пределах данного экземпляра. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки.</summary>
		/// <param name="value">Знак Юникода, который необходимо найти.</param>
		/// <param name="startIndex">Начальное положение поиска. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <returns>Отсчитываемая от нуля позиция параметра <paramref name="value" /> в индексе, если этот символ найден, или значение -1, если он не найден или текущий экземпляр равен <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> меньше нуля либо равно или превышает длину этого экземпляра.</exception>
		// Token: 0x060005AD RID: 1453 RVA: 0x0001B5B9 File Offset: 0x000197B9
		public int LastIndexOf(char value, int startIndex)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанного символа Юникода в подстроке в пределах данного экземпляра. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки для заданного числа позиций символов.</summary>
		/// <param name="value">Знак Юникода, который необходимо найти.</param>
		/// <param name="startIndex">Начальное положение поиска. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <returns>Отсчитываемая от нуля позиция параметра <paramref name="value" /> в индексе, если этот символ найден, или значение -1, если он не найден или текущий экземпляр равен <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> меньше нуля либо равно или превышает длину этого экземпляра.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> - <paramref name="count" /> + 1 является отрицательным числом.</exception>
		// Token: 0x060005AE RID: 1454 RVA: 0x0001B5C8 File Offset: 0x000197C8
		public int LastIndexOf(char value, int startIndex, int count)
		{
			if (this.Length == 0)
			{
				return -1;
			}
			if (startIndex >= this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > startIndex + 1)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			int num = startIndex + 1 - count;
			int num2 = SpanHelpers.LastIndexOf(Unsafe.Add<char>(ref this._firstChar, num), value, count);
			if (num2 != -1)
			{
				return num2 + num;
			}
			return num2;
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения в данном экземпляре какого-либо одного или нескольких символов, указанных в массиве символов Юникода.</summary>
		/// <param name="anyOf">Массив знаков Юникода, содержащий один или несколько искомых знаков.</param>
		/// <returns>Значение индекса последнего вхождения какого-либо знака из <paramref name="anyOf" /> в данном экземпляре; -1, если ни один знак из <paramref name="anyOf" /> не был найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> — <see langword="null" />.</exception>
		// Token: 0x060005AF RID: 1455 RVA: 0x0001B631 File Offset: 0x00019831
		public int LastIndexOfAny(char[] anyOf)
		{
			return this.LastIndexOfAny(anyOf, this.Length - 1, this.Length);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения в данном экземпляре какого-либо одного или нескольких символов, указанных в массиве символов Юникода. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки.</summary>
		/// <param name="anyOf">Массив знаков Юникода, содержащий один или несколько искомых знаков.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <returns>Значение индекса последнего вхождения какого-либо знака из <paramref name="anyOf" /> в данном экземпляре; -1, если ни один знак из <paramref name="anyOf" /> не был найден или текущий экземпляр равен <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> указывает позицию вне пределов данного экземпляра.</exception>
		// Token: 0x060005B0 RID: 1456 RVA: 0x0001B648 File Offset: 0x00019848
		public int LastIndexOfAny(char[] anyOf, int startIndex)
		{
			return this.LastIndexOfAny(anyOf, startIndex, startIndex + 1);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения в данном экземпляре какого-либо одного или нескольких символов, указанных в массиве символов Юникода. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки для заданного числа позиций символов.</summary>
		/// <param name="anyOf">Массив знаков Юникода, содержащий один или несколько искомых знаков.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <returns>Значение индекса последнего вхождения какого-либо знака из <paramref name="anyOf" /> в данном экземпляре; -1, если ни один знак из <paramref name="anyOf" /> не был найден или текущий экземпляр равен <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="count" /> или <paramref name="startIndex" /> является отрицательным числом.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а разность <paramref name="startIndex" /> и <paramref name="count" /> + 1 меньше нуля.</exception>
		// Token: 0x060005B1 RID: 1457 RVA: 0x0001B658 File Offset: 0x00019858
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf == null)
			{
				throw new ArgumentNullException("anyOf");
			}
			if (this.Length == 0)
			{
				return -1;
			}
			if (startIndex >= this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count - 1 > startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (anyOf.Length > 1)
			{
				return this.LastIndexOfCharArray(anyOf, startIndex, count);
			}
			if (anyOf.Length == 1)
			{
				return this.LastIndexOf(anyOf[0], startIndex, count);
			}
			return -1;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001B6D4 File Offset: 0x000198D4
		private unsafe int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			string.ProbabilisticMap probabilisticMap = default(string.ProbabilisticMap);
			uint* charMap = (uint*)(&probabilisticMap);
			string.InitializeProbabilisticMap(charMap, anyOf);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					int num = (int)(*ptr3);
					if (string.IsCharBitSet(charMap, (byte)num) && string.IsCharBitSet(charMap, (byte)(num >> 8)) && string.ArrayContains((char)num, anyOf))
					{
						return (int)((long)(ptr3 - ptr2));
					}
					count--;
					ptr3--;
				}
				return -1;
			}
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанной строки в данном экземпляре.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <returns>Положение в отсчитываемом от нуля индексе параметра <paramref name="value" />, если эта строка найдена, или значение -1, если она не найдена. Если параметр <paramref name="value" /> равен <see cref="F:System.String.Empty" />, возвращаемым значением является последняя позиция в индексе данного экземпляра.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x060005B3 RID: 1459 RVA: 0x0001B74E File Offset: 0x0001994E
		public int LastIndexOf(string value)
		{
			return this.LastIndexOf(value, this.Length - 1, this.Length, StringComparison.CurrentCulture);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанной строки в данном экземпляре. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <returns>Отсчитываемая от нуля начальная позиция индекса параметра <paramref name="value" />, если строка найдена; значение -1, если строка не найдена или значение текущего экземпляра равно <see cref="F:System.String.Empty" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является наименьшее значение из <paramref name="startIndex" /> и последнего значения индекса в данном экземпляре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> меньше нуля или больше длины текущего экземпляра.  
		/// -или- 
		/// Текущий экземпляр равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> меньше –1 или больше нуля.</exception>
		// Token: 0x060005B4 RID: 1460 RVA: 0x0001B766 File Offset: 0x00019966
		public int LastIndexOf(string value, int startIndex)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1, StringComparison.CurrentCulture);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанной строки в данном экземпляре. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки для заданного числа позиций символов.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <returns>Отсчитываемая от нуля начальная позиция индекса параметра <paramref name="value" />, если строка найдена; значение -1, если строка не найдена или значение текущего экземпляра равно <see cref="F:System.String.Empty" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является наименьшее значение из <paramref name="startIndex" /> и последнего значения индекса в данном экземпляре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> является отрицательным.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> превышает длину этого экземпляра.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> - <paramref name="count" /> + 1 указывает позицию вне пределов данного экземпляра.  
		/// -или- 
		/// Текущий экземпляр равен <see cref="F:System.String.Empty" />, а <paramref name="start" /> меньше -1 или больше нуля.  
		/// -или- 
		/// Текущий экземпляр равен <see cref="F:System.String.Empty" />, а <paramref name="count" /> больше 1.</exception>
		// Token: 0x060005B5 RID: 1461 RVA: 0x0001B774 File Offset: 0x00019974
		public int LastIndexOf(string value, int startIndex, int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			return this.LastIndexOf(value, startIndex, count, StringComparison.CurrentCulture);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля последнего вхождения указанной строки в текущем объекте <see cref="T:System.String" />. Параметр определяет тип поиска заданной строки.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила поиска.</param>
		/// <returns>Начальное положение в отсчитываемом от нуля индексе параметра <paramref name="value" />, если эта строка найдена, или значение -1, если она не найдена. Если параметр <paramref name="value" /> равен <see cref="F:System.String.Empty" />, возвращаемым значением является последняя позиция в индексе данного экземпляра.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является допустимым значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060005B6 RID: 1462 RVA: 0x0001B794 File Offset: 0x00019994
		public int LastIndexOf(string value, StringComparison comparisonType)
		{
			return this.LastIndexOf(value, this.Length - 1, this.Length, comparisonType);
		}

		/// <summary>Возвращает индекс с отсчетом от нуля последнего вхождения указанной строки в текущем объекте <see cref="T:System.String" />. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки. Параметр определяет тип сравнения для выполнения во время поиска заданной строки.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила поиска.</param>
		/// <returns>Отсчитываемая от нуля начальная позиция индекса параметра <paramref name="value" />, если эта строка найдена, или значение -1, если строка не найдена или текущий экземпляр равен <see cref="F:System.String.Empty" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является наименьшее значение из <paramref name="startIndex" /> и последнего значения индекса в данном экземпляре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> меньше нуля или больше длины текущего экземпляра.  
		/// -или- 
		/// Текущий экземпляр равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> меньше -1 или больше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является допустимым значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060005B7 RID: 1463 RVA: 0x0001B7AC File Offset: 0x000199AC
		public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1, comparisonType);
		}

		/// <summary>Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанной строки в данном экземпляре. Поиск начинается с указанной позиции символа и выполняется в обратном направлении до начала строки для заданного числа позиций символов. Параметр определяет тип сравнения для выполнения во время поиска заданной строки.</summary>
		/// <param name="value">Строка для поиска.</param>
		/// <param name="startIndex">Позиция, с которой начинается поиск. Поиск выполняется от индекса, заданного параметром <paramref name="startIndex" />, до начала данного экземпляра.</param>
		/// <param name="count">Количество позиций знаков для проверки.</param>
		/// <param name="comparisonType">Одно из значений перечисления, определяющее правила поиска.</param>
		/// <returns>Отсчитываемая от нуля начальная позиция индекса параметра <paramref name="value" />, если эта строка найдена, или значение -1, если строка не найдена или текущий экземпляр равен <see cref="F:System.String.Empty" />. Если значение параметра <paramref name="value" /> равно <see cref="F:System.String.Empty" />, возвращаемым значением является наименьшее значение из <paramref name="startIndex" /> и последнего значения индекса в данном экземпляре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> является отрицательным.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> превышает длину этого экземпляра.  
		/// -или- 
		/// Текущий экземпляр не равен <see cref="F:System.String.Empty" />, а <paramref name="startIndex" /> – <paramref name="count" /> + 1 указывает позицию вне пределов данного экземпляра.  
		/// -или- 
		/// Текущий экземпляр равен <see cref="F:System.String.Empty" />, а <paramref name="start" /> меньше -1 или больше нуля.  
		/// -или- 
		/// Текущий экземпляр равен <see cref="F:System.String.Empty" />, а <paramref name="count" /> больше 1.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> не является допустимым значением <see cref="T:System.StringComparison" />.</exception>
		// Token: 0x060005B8 RID: 1464 RVA: 0x0001B7BC File Offset: 0x000199BC
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.Length == 0 && (startIndex == -1 || startIndex == 0))
			{
				if (value.Length != 0)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (startIndex < 0 || startIndex > this.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (startIndex == this.Length)
				{
					startIndex--;
					if (count > 0)
					{
						count--;
					}
				}
				if (count < 0 || startIndex - count + 1 < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				if (value.Length == 0)
				{
					return startIndex;
				}
				switch (comparisonType)
				{
				case StringComparison.CurrentCulture:
					return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.None);
				case StringComparison.CurrentCultureIgnoreCase:
					return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
				case StringComparison.InvariantCulture:
					return CompareInfo.Invariant.LastIndexOf(this, value, startIndex, count, CompareOptions.None);
				case StringComparison.InvariantCultureIgnoreCase:
					return CompareInfo.Invariant.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
				case StringComparison.Ordinal:
					return CompareInfo.Invariant.LastIndexOfOrdinal(this, value, startIndex, count, false);
				case StringComparison.OrdinalIgnoreCase:
					return CompareInfo.Invariant.LastIndexOfOrdinal(this, value, startIndex, count, true);
				default:
					throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
				}
			}
		}

		/// <summary>Возвращает число знаков в текущем объекте <see cref="T:System.String" />.</summary>
		/// <returns>Количество знаков в текущей строке.</returns>
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001B8E6 File Offset: 0x00019AE6
		public int Length
		{
			get
			{
				return this._stringLength;
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		internal unsafe int IndexOfUnchecked(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 + count - length + 1;
					while (ptr4 != ptr5)
					{
						if (*ptr4 == *ptr3)
						{
							for (int i = 1; i < length; i++)
							{
								if (ptr4[i] != ptr3[i])
								{
									goto IL_7B;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_7B:
						ptr4++;
					}
					ptr = null;
				}
				return -1;
			}
		}

		/// <summary>Сцепляет строковые представления четырех указанных объектов и любые объекты, заданные в необязательном списке параметров переменной длины.</summary>
		/// <param name="arg0">Первый из сцепляемых объектов.</param>
		/// <param name="arg1">Второй из сцепляемых объектов.</param>
		/// <param name="arg2">Третий из сцепляемых объектов.</param>
		/// <param name="arg3">Четвертый из сцепляемых объектов.</param>
		/// 	  <param name="…">An optional comma-delimited list of one or more additional objects to concatenate.</param>
		/// <returns>Сцепленное строковое представление каждого значения в списке параметров.</returns>
		// Token: 0x060005BB RID: 1467 RVA: 0x0001B98B File Offset: 0x00019B8B
		[CLSCompliant(false)]
		public static string Concat(object arg0, object arg1, object arg2, object arg3, __arglist)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001B994 File Offset: 0x00019B94
		internal unsafe int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 + count - length + 1;
					char c = textInfo.ToUpper(*ptr3);
					while (ptr4 != ptr5)
					{
						if (textInfo.ToUpper(*ptr4) == c)
						{
							for (int i = 1; i < length; i++)
							{
								if (textInfo.ToUpper(ptr4[i]) != textInfo.ToUpper(ptr3[i]))
								{
									goto IL_A4;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_A4:
						ptr4++;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001BA5C File Offset: 0x00019C5C
		internal unsafe int LastIndexOfUnchecked(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 - count + length - 1;
					char* ptr6 = ptr3 + length - 1;
					while (ptr4 != ptr5)
					{
						if (*ptr4 == *ptr6)
						{
							char* ptr7 = ptr4;
							while (ptr3 != ptr6)
							{
								ptr6--;
								ptr4--;
								if (*ptr4 != *ptr6)
								{
									ptr6 = ptr3 + length - 1;
									ptr4 = ptr7;
									goto IL_92;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_92:
						ptr4--;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001BB10 File Offset: 0x00019D10
		internal unsafe int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 - count + length - 1;
					char* ptr6 = ptr3 + length - 1;
					char c = textInfo.ToUpper(*ptr6);
					while (ptr4 != ptr5)
					{
						if (textInfo.ToUpper(*ptr4) == c)
						{
							char* ptr7 = ptr4;
							while (ptr3 != ptr6)
							{
								ptr6--;
								ptr4--;
								if (textInfo.ToUpper(*ptr4) != textInfo.ToUpper(*ptr6))
								{
									ptr6 = ptr3 + length - 1;
									ptr4 = ptr7;
									goto IL_BB;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_BB:
						ptr4--;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001BBEC File Offset: 0x00019DEC
		internal bool StartsWithOrdinalUnchecked(string value)
		{
			return this.Length >= value.Length && this._firstChar == value._firstChar && (value.Length == 1 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(this.GetRawStringData()), Unsafe.As<char, byte>(value.GetRawStringData()), (ulong)((long)value.Length * 2L)));
		}

		// Token: 0x060005C0 RID: 1472
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string FastAllocateString(int length);

		// Token: 0x060005C1 RID: 1473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string InternalIsInterned(string str);

		// Token: 0x060005C2 RID: 1474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string InternalIntern(string str);

		// Token: 0x060005C3 RID: 1475 RVA: 0x0001BC48 File Offset: 0x00019E48
		private unsafe static int FastCompareStringHelper(uint* strAChars, int countA, uint* strBChars, int countB)
		{
			char* ptr = (char*)strAChars;
			char* ptr2 = (char*)strBChars;
			char* ptr3 = ptr + Math.Min(countA, countB);
			while (ptr < ptr3)
			{
				if (*ptr != *ptr2)
				{
					return (int)(*ptr - *ptr2);
				}
				ptr++;
				ptr2++;
			}
			return countA - countB;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001BC84 File Offset: 0x00019E84
		private unsafe static void memset(byte* dest, int val, int len)
		{
			if (len < 8)
			{
				while (len != 0)
				{
					*dest = (byte)val;
					dest++;
					len--;
				}
				return;
			}
			if (val != 0)
			{
				val |= val << 8;
				val |= val << 16;
			}
			int num = dest & 3;
			if (num != 0)
			{
				num = 4 - num;
				len -= num;
				do
				{
					*dest = (byte)val;
					dest++;
					num--;
				}
				while (num != 0);
			}
			while (len >= 16)
			{
				*(int*)dest = val;
				*(int*)(dest + 4) = val;
				*(int*)(dest + (IntPtr)2 * 4) = val;
				*(int*)(dest + (IntPtr)3 * 4) = val;
				dest += 16;
				len -= 16;
			}
			while (len >= 4)
			{
				*(int*)dest = val;
				dest += 4;
				len -= 4;
			}
			while (len > 0)
			{
				*dest = (byte)val;
				dest++;
				len--;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001BD2E File Offset: 0x00019F2E
		private unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			Buffer.Memcpy(dest, src, size, false);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001BD39 File Offset: 0x00019F39
		internal unsafe static void bzero(byte* dest, int len)
		{
			string.memset(dest, 0, len);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001BD43 File Offset: 0x00019F43
		internal unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			*dest = 0;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001BD48 File Offset: 0x00019F48
		internal unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			*(short*)dest = 0;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001BD4D File Offset: 0x00019F4D
		internal unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			*(int*)dest = 0;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0001BD52 File Offset: 0x00019F52
		internal unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			*(long*)dest = 0L;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0001BD58 File Offset: 0x00019F58
		internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			*dest = *src;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0001BD5E File Offset: 0x00019F5E
		internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			*(short*)dest = *(short*)src;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0001BD64 File Offset: 0x00019F64
		internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			*(int*)dest = *(int*)src;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001BD6A File Offset: 0x00019F6A
		internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			*(long*)dest = *(long*)src;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001BD70 File Offset: 0x00019F70
		private unsafe string CreateString(sbyte* value)
		{
			return string.Ctor(value);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001BD78 File Offset: 0x00019F78
		private unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			return string.Ctor(value, startIndex, length);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0001BD82 File Offset: 0x00019F82
		private unsafe string CreateString(char* value)
		{
			return string.Ctor(value);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0001BD8A File Offset: 0x00019F8A
		private unsafe string CreateString(char* value, int startIndex, int length)
		{
			return string.Ctor(value, startIndex, length);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001BD94 File Offset: 0x00019F94
		private string CreateString(char[] val, int startIndex, int length)
		{
			return string.Ctor(val, startIndex, length);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0001BD9E File Offset: 0x00019F9E
		private string CreateString(char[] val)
		{
			return string.Ctor(val);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001BDA6 File Offset: 0x00019FA6
		private string CreateString(char c, int count)
		{
			return string.Ctor(c, count);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001BDAF File Offset: 0x00019FAF
		private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			return string.Ctor(value, startIndex, length, enc);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001BDBB File Offset: 0x00019FBB
		private string CreateString(ReadOnlySpan<char> value)
		{
			return string.Ctor(value);
		}

		/// <summary>Возвращает объект <see cref="T:System.Char" /> в указанной позиции в текущем объекте <see cref="T:System.String" />.</summary>
		/// <param name="index">Позиция в текущей строке.</param>
		/// <returns>Объект в позиции <paramref name="index" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение <paramref name="index" /> больше или равно длине данного объекта или меньше нуля.</exception>
		// Token: 0x1700007F RID: 127
		[IndexerName("Chars")]
		public unsafe char this[int index]
		{
			[Intrinsic]
			get
			{
				if ((ulong)index >= (ulong)((long)this._stringLength))
				{
					ThrowHelper.ThrowIndexOutOfRangeException();
				}
				return *Unsafe.Add<char>(ref this._firstChar, index);
			}
		}

		/// <summary>Извлекает системную ссылку на указанный объект <see cref="T:System.String" />.</summary>
		/// <param name="str">Строка для поиска в пуле интернирования.</param>
		/// <returns>Системная ссылка на значение <paramref name="str" />, если оно уже интернировано; в противном случае возвращается новая ссылка на строку со значением <paramref name="str" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> — <see langword="null" />.</exception>
		// Token: 0x060005D9 RID: 1497 RVA: 0x0001BDE2 File Offset: 0x00019FE2
		public static string Intern(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return string.InternalIntern(str);
		}

		/// <summary>Извлекает ссылку на указанный объект <see cref="T:System.String" />.</summary>
		/// <param name="str">Строка для поиска в пуле интернирования.</param>
		/// <returns>Ссылка на значение <paramref name="str" />, если оно находится в пуле интернирования среды CLR; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> — <see langword="null" />.</exception>
		// Token: 0x060005DA RID: 1498 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		public static string IsInterned(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return string.InternalIsInterned(str);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001BE10 File Offset: 0x0001A010
		private unsafe int LegacyStringGetHashCode()
		{
			int num = 5381;
			int num2 = num;
			fixed (string text = this)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* ptr2 = ptr;
				int num3;
				while ((num3 = (int)(*ptr2)) != 0)
				{
					num = ((num << 5) + num ^ num3);
					num3 = (int)ptr2[1];
					if (num3 == 0)
					{
						break;
					}
					num2 = ((num2 << 5) + num2 ^ num3);
					ptr2 += 2;
				}
			}
			return num + num2 * 1566083941;
		}

		// Token: 0x04000FEA RID: 4074
		private const int StackallocIntBufferSizeLimit = 128;

		// Token: 0x04000FEB RID: 4075
		private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

		// Token: 0x04000FEC RID: 4076
		private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

		// Token: 0x04000FED RID: 4077
		private const int PROBABILISTICMAP_SIZE = 8;

		// Token: 0x04000FEE RID: 4078
		[NonSerialized]
		private int _stringLength;

		// Token: 0x04000FEF RID: 4079
		[NonSerialized]
		private char _firstChar;

		/// <summary>Представляет пустую строку. Это поле доступно только для чтения.</summary>
		// Token: 0x04000FF0 RID: 4080
		public static readonly string Empty;

		// Token: 0x020000CE RID: 206
		private enum TrimType
		{
			// Token: 0x04000FF2 RID: 4082
			Head,
			// Token: 0x04000FF3 RID: 4083
			Tail,
			// Token: 0x04000FF4 RID: 4084
			Both
		}

		// Token: 0x020000CF RID: 207
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private struct ProbabilisticMap
		{
		}
	}
}
