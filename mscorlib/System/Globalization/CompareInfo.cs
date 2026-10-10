using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Mono.Globalization.Unicode;
using Unity;

namespace System.Globalization
{
	/// <summary>Реализует ряд методов для сравнения строк с учетом языка и региональных параметров.</summary>
	// Token: 0x02000955 RID: 2389
	[Serializable]
	public class CompareInfo : IDeserializationCallback
	{
		// Token: 0x0600542E RID: 21550 RVA: 0x001191C0 File Offset: 0x001173C0
		internal unsafe static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			char* ptr = source;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = value;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			int num = CompareInfo.InvariantFindString(ptr + startIndex, count, ptr2, value.Length, ignoreCase, true);
			if (num >= 0)
			{
				return num + startIndex;
			}
			return -1;
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x00119214 File Offset: 0x00117414
		internal unsafe static int InvariantIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* source2 = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(value))
				{
					char* value2 = reference2;
					return CompareInfo.InvariantFindString(source2, source.Length, value2, value.Length, ignoreCase, true);
				}
			}
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0011924C File Offset: 0x0011744C
		internal unsafe static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			char* ptr = source;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = value;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			int num = CompareInfo.InvariantFindString(ptr + (startIndex - count + 1), count, ptr2, value.Length, ignoreCase, false);
			if (num >= 0)
			{
				return num + startIndex - count + 1;
			}
			return -1;
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x001192A8 File Offset: 0x001174A8
		private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
		{
			if (valueCount == 0)
			{
				if (!start)
				{
					return sourceCount - 1;
				}
				return 0;
			}
			else
			{
				if (sourceCount < valueCount)
				{
					return -1;
				}
				if (start)
				{
					int num = sourceCount - valueCount;
					if (ignoreCase)
					{
						char c = CompareInfo.InvariantToUpper(*value);
						for (int i = 0; i <= num; i++)
						{
							if (CompareInfo.InvariantToUpper(source[i]) == c)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c2 = CompareInfo.InvariantToUpper(source[i + j]);
									char c3 = CompareInfo.InvariantToUpper(value[j]);
									if (c2 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
					else
					{
						char c4 = *value;
						for (int i = 0; i <= num; i++)
						{
							if (source[i] == c4)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c5 = source[i + j];
									char c3 = value[j];
									if (c5 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
				}
				else
				{
					int num = sourceCount - valueCount;
					if (ignoreCase)
					{
						char c6 = CompareInfo.InvariantToUpper(*value);
						for (int i = num; i >= 0; i--)
						{
							if (CompareInfo.InvariantToUpper(source[i]) == c6)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c7 = CompareInfo.InvariantToUpper(source[i + j]);
									char c3 = CompareInfo.InvariantToUpper(value[j]);
									if (c7 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
					else
					{
						char c8 = *value;
						for (int i = num; i >= 0; i--)
						{
							if (source[i] == c8)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c9 = source[i + j];
									char c3 = value[j];
									if (c9 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
				}
				return -1;
			}
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0011941C File Offset: 0x0011761C
		private static char InvariantToUpper(char c)
		{
			if (c - 'a' > '\u0019')
			{
				return c;
			}
			return c - ' ';
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x00119430 File Offset: 0x00117630
		private unsafe SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			byte[] array;
			if (source.Length == 0)
			{
				array = Array.Empty<byte>();
			}
			else
			{
				array = new byte[source.Length * 2];
				fixed (string text = source)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					byte[] array2;
					byte* ptr2;
					if ((array2 = array) == null || array2.Length == 0)
					{
						ptr2 = null;
					}
					else
					{
						ptr2 = &array2[0];
					}
					if ((options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) != CompareOptions.None)
					{
						short* ptr3 = (short*)ptr2;
						for (int i = 0; i < source.Length; i++)
						{
							ptr3[i] = (short)CompareInfo.InvariantToUpper(source[i]);
						}
					}
					else
					{
						Buffer.MemoryCopy((void*)ptr, (void*)ptr2, (long)array.Length, (long)array.Length);
					}
					array2 = null;
				}
			}
			return new SortKey(this.Name, source, options, array);
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0011950C File Offset: 0x0011770C
		internal CompareInfo(CultureInfo culture)
		{
			this.m_name = culture._name;
			this.InitSort(culture);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с указанным языком и региональными параметрами и использующий методы сравнения строк в указанном объекте <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="culture">Целое число, представляющее идентификатор языка и региональных параметров.</param>
		/// <param name="assembly">Класс <see cref="T:System.Reflection.Assembly" />, содержащий используемые методы сравнения строк.</param>
		/// <returns>Новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с языком и региональными параметрами с заданным идентификатором и использующий методы сравнения строк в текущем объекте <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assembly" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assembly" /> относится к недопустимому типу.</exception>
		// Token: 0x06005435 RID: 21557 RVA: 0x00119528 File Offset: 0x00117728
		public static CompareInfo GetCompareInfo(int culture, Assembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			if (assembly != typeof(object).Module.Assembly)
			{
				throw new ArgumentException("Only mscorlib's assembly is valid.");
			}
			return CompareInfo.GetCompareInfo(culture);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с указанным языком и региональными параметрами и использующий методы сравнения строк в указанном объекте <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="name">Строка, представляющая имя языка и региональных параметров.</param>
		/// <param name="assembly">Класс <see cref="T:System.Reflection.Assembly" />, содержащий используемые методы сравнения строк.</param>
		/// <returns>Новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с языком и региональными параметрами с заданным идентификатором и использующий методы сравнения строк в текущем объекте <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="assembly" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> не является допустимым именем языка и региональных параметров.  
		/// -или- 
		///  Параметр <paramref name="assembly" /> относится к недопустимому типу.</exception>
		// Token: 0x06005436 RID: 21558 RVA: 0x00119578 File Offset: 0x00117778
		public static CompareInfo GetCompareInfo(string name, Assembly assembly)
		{
			if (name == null || assembly == null)
			{
				throw new ArgumentNullException((name == null) ? "name" : "assembly");
			}
			if (assembly != typeof(object).Module.Assembly)
			{
				throw new ArgumentException("Only mscorlib's assembly is valid.");
			}
			return CompareInfo.GetCompareInfo(name);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с языком и региональными параметрами с заданным идентификатором.</summary>
		/// <param name="culture">Целое число, представляющее идентификатор языка и региональных параметров.</param>
		/// <returns>Новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с языком и региональными параметрами с заданным идентификатором и использующий методы сравнения строк в текущем объекте <see cref="T:System.Reflection.Assembly" />.</returns>
		// Token: 0x06005437 RID: 21559 RVA: 0x001195D3 File Offset: 0x001177D3
		public static CompareInfo GetCompareInfo(int culture)
		{
			if (CultureData.IsCustomCultureId(culture))
			{
				throw new ArgumentException("Customized cultures cannot be passed by LCID, only by name.", "culture");
			}
			return CultureInfo.GetCultureInfo(culture).CompareInfo;
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с языком и региональными параметрами с заданным именем.</summary>
		/// <param name="name">Строка, представляющая имя языка и региональных параметров.</param>
		/// <returns>Новый объект <see cref="T:System.Globalization.CompareInfo" />, связанный с языком и региональными параметрами с заданным идентификатором и использующий методы сравнения строк в текущем объекте <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> не является допустимым именем языка и региональных параметров.</exception>
		// Token: 0x06005438 RID: 21560 RVA: 0x001195F8 File Offset: 0x001177F8
		public static CompareInfo GetCompareInfo(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return CultureInfo.GetCultureInfo(name).CompareInfo;
		}

		/// <summary>Показывает, подлежит ли указанный знак Юникода сортировке.</summary>
		/// <param name="ch">Знак Юникода.</param>
		/// <returns>Значение <see langword="true" />, если параметр  <paramref name="ch" /> подлежит сортировке; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005439 RID: 21561 RVA: 0x00119613 File Offset: 0x00117813
		public unsafe static bool IsSortable(char ch)
		{
			return GlobalizationMode.Invariant || CompareInfo.IsSortable(&ch, 1);
		}

		/// <summary>Показывает, подлежит ли указанная строка Юникода сортировке.</summary>
		/// <param name="text">Строка длиной от нуля и более знаков Юникода.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="str" /> не является пустой строкой (""), а все знаки Юникода в параметре <paramref name="str" /> подлежат сортировке; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> — <see langword="null" />.</exception>
		// Token: 0x0600543A RID: 21562 RVA: 0x00119628 File Offset: 0x00117828
		public unsafe static bool IsSortable(string text)
		{
			if (text == null)
			{
				throw new ArgumentNullException("text");
			}
			if (text.Length == 0)
			{
				return false;
			}
			if (GlobalizationMode.Invariant)
			{
				return true;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return CompareInfo.IsSortable(ptr, text.Length);
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00119672 File Offset: 0x00117872
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.m_name = null;
		}

		/// <summary>Выполняется, когда полностью десериализован граф объектов.</summary>
		/// <param name="sender">Объект, который инициализирует обратный вызов.</param>
		// Token: 0x0600543C RID: 21564 RVA: 0x0011967B File Offset: 0x0011787B
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x0011967B File Offset: 0x0011787B
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x00119684 File Offset: 0x00117884
		private void OnDeserialized()
		{
			if (this.m_name == null)
			{
				CultureInfo cultureInfo = CultureInfo.GetCultureInfo(this.culture);
				this.m_name = cultureInfo._name;
				return;
			}
			this.InitSort(CultureInfo.GetCultureInfo(this.m_name));
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x001196C3 File Offset: 0x001178C3
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.culture = CultureInfo.GetCultureInfo(this.Name).LCID;
		}

		/// <summary>Получает имя используемого языка и региональных параметров для операций сортировки по данному объекту <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <returns>Имя языка и региональных параметров.</returns>
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06005440 RID: 21568 RVA: 0x001196DB File Offset: 0x001178DB
		public virtual string Name
		{
			get
			{
				if (this.m_name == "zh-CHT" || this.m_name == "zh-CHS")
				{
					return this.m_name;
				}
				return this._sortName;
			}
		}

		/// <summary>Сравнивает две строки.</summary>
		/// <param name="string1">Первая сравниваемая строка.</param>
		/// <param name="string2">Вторая сравниваемая строка.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   нуль 
		///   Эти две строки совпадают.  
		///
		///   меньше нуля 
		///  Значение параметра <paramref name="string1" /> меньше значения <paramref name="string2" />.  
		///
		///   больше нуля 
		///  Значение <paramref name="string1" /> больше значения <paramref name="string2" />.</returns>
		// Token: 0x06005441 RID: 21569 RVA: 0x0011970E File Offset: 0x0011790E
		public virtual int Compare(string string1, string string2)
		{
			return this.Compare(string1, string2, CompareOptions.None);
		}

		/// <summary>Сравнивает две строки с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="string1">Первая сравниваемая строка.</param>
		/// <param name="string2">Вторая сравниваемая строка.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="string1" /> и <paramref name="string2" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" /> и <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   нуль 
		///   Эти две строки совпадают.  
		///
		///   меньше нуля 
		///  Значение параметра <paramref name="string1" /> меньше значения <paramref name="string2" />.  
		///
		///   больше нуля 
		///  Значение <paramref name="string1" /> больше значения <paramref name="string2" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005442 RID: 21570 RVA: 0x0011971C File Offset: 0x0011791C
		public virtual int Compare(string string1, string string2, CompareOptions options)
		{
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return string.Compare(string1, string2, StringComparison.OrdinalIgnoreCase);
			}
			if ((options & CompareOptions.Ordinal) != CompareOptions.None)
			{
				if (options != CompareOptions.Ordinal)
				{
					throw new ArgumentException("CompareOption.Ordinal cannot be used with other options.", "options");
				}
				return string.CompareOrdinal(string1, string2);
			}
			else
			{
				if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (string1 == null)
				{
					if (string2 == null)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (string2 == null)
					{
						return 1;
					}
					if (!GlobalizationMode.Invariant)
					{
						return this.internal_compare_switch(string1, 0, string1.Length, string2, 0, string2.Length, options);
					}
					if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
					{
						return CompareInfo.CompareOrdinalIgnoreCase(string1, string2);
					}
					return string.CompareOrdinal(string1, string2);
				}
			}
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x001197C8 File Offset: 0x001179C8
		internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return CompareInfo.CompareOrdinalIgnoreCase(string1, string2.AsSpan());
			}
			if ((options & CompareOptions.Ordinal) != CompareOptions.None)
			{
				if (options != CompareOptions.Ordinal)
				{
					throw new ArgumentException("CompareOption.Ordinal cannot be used with other options.", "options");
				}
				return string.CompareOrdinal(string1, string2.AsSpan());
			}
			else
			{
				if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (string2 == null)
				{
					return 1;
				}
				if (!GlobalizationMode.Invariant)
				{
					return this.CompareString(string1, string2, options);
				}
				if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					return string.CompareOrdinal(string1, string2.AsSpan());
				}
				return CompareInfo.CompareOrdinalIgnoreCase(string1, string2.AsSpan());
			}
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00119865 File Offset: 0x00117A65
		internal int CompareOptionNone(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
		{
			if (string1.Length == 0 || string2.Length == 0)
			{
				return string1.Length - string2.Length;
			}
			if (!GlobalizationMode.Invariant)
			{
				return this.CompareString(string1, string2, CompareOptions.None);
			}
			return string.CompareOrdinal(string1, string2);
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x001198A1 File Offset: 0x00117AA1
		internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
		{
			if (string1.Length == 0 || string2.Length == 0)
			{
				return string1.Length - string2.Length;
			}
			if (!GlobalizationMode.Invariant)
			{
				return this.CompareString(string1, string2, CompareOptions.IgnoreCase);
			}
			return CompareInfo.CompareOrdinalIgnoreCase(string1, string2);
		}

		/// <summary>Сравнивает часть одной строки с частью другой строки.</summary>
		/// <param name="string1">Первая сравниваемая строка.</param>
		/// <param name="offset1">Отсчитываемый от нуля индекс знака в строке <paramref name="string1" />, с которого начинается сравнение.</param>
		/// <param name="length1">Число последовательных знаков в строке <paramref name="string1" /> для сравнения.</param>
		/// <param name="string2">Вторая сравниваемая строка.</param>
		/// <param name="offset2">Отсчитываемый от нуля индекс знака в строке <paramref name="string2" />, с которого начинается сравнение.</param>
		/// <param name="length2">Число последовательных знаков в строке <paramref name="string2" /> для сравнения.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   нуль 
		///   Эти две строки совпадают.  
		///
		///   меньше нуля 
		///   Заданная часть <paramref name="string1" /> меньше заданной части <paramref name="string2" />.  
		///
		///   Больше нуля 
		///   Заданная часть <paramref name="string1" /> больше заданной части <paramref name="string2" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметров <paramref name="offset1" /> или <paramref name="length1" />, или <paramref name="offset2" />, или <paramref name="length2" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="offset1" /> больше или равно количеству символов в строке <paramref name="string1" />.  
		/// -или- 
		///  Значение параметра <paramref name="offset2" /> больше или равно количеству символов в строке <paramref name="string2" />.  
		/// -или- 
		///  <paramref name="length1" /> больше количества символов от <paramref name="offset1" /> до конца <paramref name="string1" />.  
		/// -или- 
		///  <paramref name="length2" /> больше количества символов от <paramref name="offset2" /> до конца <paramref name="string2" />.</exception>
		// Token: 0x06005446 RID: 21574 RVA: 0x001198DD File Offset: 0x00117ADD
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			return this.Compare(string1, offset1, length1, string2, offset2, length2, CompareOptions.None);
		}

		/// <summary>Сравнивает конечную часть одной строки с конечной частью другой строки с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="string1">Первая сравниваемая строка.</param>
		/// <param name="offset1">Отсчитываемый от нуля индекс знака в строке <paramref name="string1" />, с которого начинается сравнение.</param>
		/// <param name="string2">Вторая сравниваемая строка.</param>
		/// <param name="offset2">Отсчитываемый от нуля индекс знака в строке <paramref name="string2" />, с которого начинается сравнение.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="string1" /> и <paramref name="string2" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" /> и <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   нуль 
		///   Эти две строки совпадают.  
		///
		///   меньше нуля 
		///   Заданная часть <paramref name="string1" /> меньше заданной части <paramref name="string2" />.  
		///
		///   Больше нуля 
		///   Заданная часть <paramref name="string1" /> больше заданной части <paramref name="string2" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset1" /> или <paramref name="offset2" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="offset1" /> больше или равно количеству символов в строке <paramref name="string1" />.  
		/// -или- 
		///  Значение параметра <paramref name="offset2" /> больше или равно количеству символов в строке <paramref name="string2" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005447 RID: 21575 RVA: 0x001198EF File Offset: 0x00117AEF
		public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
		{
			return this.Compare(string1, offset1, (string1 == null) ? 0 : (string1.Length - offset1), string2, offset2, (string2 == null) ? 0 : (string2.Length - offset2), options);
		}

		/// <summary>Сравнивает конечную часть одной строки с конечной частью другой строки.</summary>
		/// <param name="string1">Первая сравниваемая строка.</param>
		/// <param name="offset1">Отсчитываемый от нуля индекс знака в строке <paramref name="string1" />, с которого начинается сравнение.</param>
		/// <param name="string2">Вторая сравниваемая строка.</param>
		/// <param name="offset2">Отсчитываемый от нуля индекс знака в строке <paramref name="string2" />, с которого начинается сравнение.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   нуль 
		///   Эти две строки совпадают.  
		///
		///   меньше нуля 
		///   Заданная часть <paramref name="string1" /> меньше заданной части <paramref name="string2" />.  
		///
		///   Больше нуля 
		///   Заданная часть <paramref name="string1" /> больше заданной части <paramref name="string2" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset1" /> или <paramref name="offset2" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="offset1" /> больше или равно количеству символов в строке <paramref name="string1" />.  
		/// -или- 
		///  Значение параметра <paramref name="offset2" /> больше или равно количеству символов в строке <paramref name="string2" />.</exception>
		// Token: 0x06005448 RID: 21576 RVA: 0x0011991B File Offset: 0x00117B1B
		public virtual int Compare(string string1, int offset1, string string2, int offset2)
		{
			return this.Compare(string1, offset1, string2, offset2, CompareOptions.None);
		}

		/// <summary>Сравнивает часть одной строки с частью другой строки с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="string1">Первая сравниваемая строка.</param>
		/// <param name="offset1">Отсчитываемый от нуля индекс знака в строке <paramref name="string1" />, с которого начинается сравнение.</param>
		/// <param name="length1">Число последовательных знаков в строке <paramref name="string1" /> для сравнения.</param>
		/// <param name="string2">Вторая сравниваемая строка.</param>
		/// <param name="offset2">Отсчитываемый от нуля индекс знака в строке <paramref name="string2" />, с которого начинается сравнение.</param>
		/// <param name="length2">Число последовательных знаков в строке <paramref name="string2" /> для сравнения.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="string1" /> и <paramref name="string2" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" /> и <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>32-битовое целое число со знаком, выражающее лексическое соотношение двух сравниваемых значений.  
		///   Значение 
		///   Условие 
		///   нуль 
		///   Эти две строки совпадают.  
		///
		///   меньше нуля 
		///   Заданная часть <paramref name="string1" /> меньше заданной части <paramref name="string2" />.  
		///
		///   Больше нуля 
		///   Заданная часть <paramref name="string1" /> больше заданной части <paramref name="string2" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметров <paramref name="offset1" /> или <paramref name="length1" />, или <paramref name="offset2" />, или <paramref name="length2" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="offset1" /> больше или равно количеству символов в строке <paramref name="string1" />.  
		/// -или- 
		///  Значение параметра <paramref name="offset2" /> больше или равно количеству символов в строке <paramref name="string2" />.  
		/// -или- 
		///  <paramref name="length1" /> больше количества символов от <paramref name="offset1" /> до конца <paramref name="string1" />.  
		/// -или- 
		///  <paramref name="length2" /> больше количества символов от <paramref name="offset2" /> до конца <paramref name="string2" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005449 RID: 21577 RVA: 0x0011992C File Offset: 0x00117B2C
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				int num = string.Compare(string1, offset1, string2, offset2, (length1 < length2) ? length1 : length2, StringComparison.OrdinalIgnoreCase);
				if (length1 == length2 || num != 0)
				{
					return num;
				}
				if (length1 <= length2)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (length1 < 0 || length2 < 0)
				{
					throw new ArgumentOutOfRangeException((length1 < 0) ? "length1" : "length2", "Positive number required.");
				}
				if (offset1 < 0 || offset2 < 0)
				{
					throw new ArgumentOutOfRangeException((offset1 < 0) ? "offset1" : "offset2", "Positive number required.");
				}
				if (offset1 > ((string1 == null) ? 0 : string1.Length) - length1)
				{
					throw new ArgumentOutOfRangeException("string1", "Offset and length must refer to a position in the string.");
				}
				if (offset2 > ((string2 == null) ? 0 : string2.Length) - length2)
				{
					throw new ArgumentOutOfRangeException("string2", "Offset and length must refer to a position in the string.");
				}
				if ((options & CompareOptions.Ordinal) != CompareOptions.None)
				{
					if (options != CompareOptions.Ordinal)
					{
						throw new ArgumentException("CompareOption.Ordinal cannot be used with other options.", "options");
					}
				}
				else if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (string1 == null)
				{
					if (string2 == null)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (string2 == null)
					{
						return 1;
					}
					ReadOnlySpan<char> strA = string1.AsSpan(offset1, length1);
					ReadOnlySpan<char> strB = string2.AsSpan(offset2, length2);
					if (options == CompareOptions.Ordinal)
					{
						return string.CompareOrdinal(strA, strB);
					}
					if (!GlobalizationMode.Invariant)
					{
						return this.internal_compare_switch(string1, offset1, length1, string2, offset2, length2, options);
					}
					if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
					{
						return CompareInfo.CompareOrdinalIgnoreCase(strA, strB);
					}
					return string.CompareOrdinal(strA, strB);
				}
			}
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00119A9C File Offset: 0x00117C9C
		internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
		{
			return CompareInfo.CompareOrdinalIgnoreCase(strA.AsSpan(indexA, lengthA), strB.AsSpan(indexB, lengthB));
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00119AB8 File Offset: 0x00117CB8
		internal unsafe static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			int num = Math.Min(strA.Length, strB.Length);
			int num2 = num;
			fixed (char* reference = MemoryMarshal.GetReference<char>(strA))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(strB))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					char c = GlobalizationMode.Invariant ? char.MaxValue : '\u007f';
					while (num != 0 && *ptr3 <= c && *ptr4 <= c)
					{
						int num3 = (int)(*ptr3);
						int num4 = (int)(*ptr4);
						if (num3 == num4)
						{
							ptr3++;
							ptr4++;
							num--;
						}
						else
						{
							if (num3 - 97 <= 25)
							{
								num3 -= 32;
							}
							if (num4 - 97 <= 25)
							{
								num4 -= 32;
							}
							if (num3 != num4)
							{
								return num3 - num4;
							}
							ptr3++;
							ptr4++;
							num--;
						}
					}
					if (num == 0)
					{
						return strA.Length - strB.Length;
					}
					num2 -= num;
					return CompareInfo.CompareStringOrdinalIgnoreCase(ptr3, strA.Length - num2, ptr4, strB.Length - num2);
				}
			}
		}

		/// <summary>Определяет, начинается ли указанная строка источника с указанного префикса, с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка, в которой выполняется поиск.</param>
		/// <param name="prefix">Строка, сравниваемая с началом <paramref name="source" />.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="prefix" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>
		///   <see langword="true" />, если длина <paramref name="prefix" /> меньше или равна длине <paramref name="source" /> и <paramref name="source" /> начинается с <paramref name="prefix" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="prefix" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600544C RID: 21580 RVA: 0x00119BAC File Offset: 0x00117DAC
		public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			if (source == null || prefix == null)
			{
				throw new ArgumentNullException((source == null) ? "source" : "prefix", "String reference not set to an instance of a String.");
			}
			if (prefix.Length == 0)
			{
				return true;
			}
			if (source.Length == 0)
			{
				return false;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return source.StartsWith(prefix, StringComparison.OrdinalIgnoreCase);
			}
			if (options == CompareOptions.Ordinal)
			{
				return source.StartsWith(prefix, StringComparison.Ordinal);
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (GlobalizationMode.Invariant)
			{
				return source.StartsWith(prefix, ((options & CompareOptions.IgnoreCase) != CompareOptions.None) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
			}
			return this.StartsWith(source, prefix, options);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00119C46 File Offset: 0x00117E46
		internal bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options)
		{
			return this.StartsWith(source, prefix, options);
		}

		/// <summary>Определяет, начинается ли указанная строка источника с указанного префикса.</summary>
		/// <param name="source">Строка, в которой выполняется поиск.</param>
		/// <param name="prefix">Строка, сравниваемая с началом <paramref name="source" />.</param>
		/// <returns>
		///   <see langword="true" />, если длина <paramref name="prefix" /> меньше или равна длине <paramref name="source" /> и <paramref name="source" /> начинается с <paramref name="prefix" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="prefix" /> — <see langword="null" />.</exception>
		// Token: 0x0600544E RID: 21582 RVA: 0x00119C51 File Offset: 0x00117E51
		public virtual bool IsPrefix(string source, string prefix)
		{
			return this.IsPrefix(source, prefix, CompareOptions.None);
		}

		/// <summary>Определяет, заканчивается ли указанная строка источника указанным суффиксом, с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка, в которой выполняется поиск.</param>
		/// <param name="suffix">Строка, сравниваемая с концом <paramref name="source" />.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="suffix" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>
		///   <see langword="true" />, если длина <paramref name="suffix" /> меньше или равна длине <paramref name="source" /> и <paramref name="source" /> заканчивается  <paramref name="suffix" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="suffix" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600544F RID: 21583 RVA: 0x00119C5C File Offset: 0x00117E5C
		public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			if (source == null || suffix == null)
			{
				throw new ArgumentNullException((source == null) ? "source" : "suffix", "String reference not set to an instance of a String.");
			}
			if (suffix.Length == 0)
			{
				return true;
			}
			if (source.Length == 0)
			{
				return false;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return source.EndsWith(suffix, StringComparison.OrdinalIgnoreCase);
			}
			if (options == CompareOptions.Ordinal)
			{
				return source.EndsWith(suffix, StringComparison.Ordinal);
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (GlobalizationMode.Invariant)
			{
				return source.EndsWith(suffix, ((options & CompareOptions.IgnoreCase) != CompareOptions.None) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
			}
			return this.EndsWith(source, suffix, options);
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00119CF6 File Offset: 0x00117EF6
		internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return this.EndsWith(source, suffix, options);
		}

		/// <summary>Определяет, заканчивается ли указанная строка источника указанным суффиксом.</summary>
		/// <param name="source">Строка, в которой выполняется поиск.</param>
		/// <param name="suffix">Строка, сравниваемая с концом <paramref name="source" />.</param>
		/// <returns>
		///   <see langword="true" />, если длина <paramref name="suffix" /> меньше или равна длине <paramref name="source" /> и <paramref name="source" /> заканчивается  <paramref name="suffix" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="suffix" /> — <see langword="null" />.</exception>
		// Token: 0x06005451 RID: 21585 RVA: 0x00119D01 File Offset: 0x00117F01
		public virtual bool IsSuffix(string source, string suffix)
		{
			return this.IsSuffix(source, suffix, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс первого найденного экземпляра во всей строке источника.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" />; если не найден — значение -1. Возвращает значение 0 (ноль), если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		// Token: 0x06005452 RID: 21586 RVA: 0x00119D0C File Offset: 0x00117F0C
		public virtual int IndexOf(string source, char value)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, 0, source.Length, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс первого найденного экземпляра во всей строке источника.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" />; если не найден — значение -1. Возвращает значение 0 (ноль), если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06005453 RID: 21587 RVA: 0x00119D2C File Offset: 0x00117F2C
		public virtual int IndexOf(string source, string value)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, 0, source.Length, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс первого найденного экземпляра во всей строке источника с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="options">Значение, определяющее способ сравнения строк. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" /> с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает значение 0 (ноль), если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005454 RID: 21588 RVA: 0x00119D4C File Offset: 0x00117F4C
		public virtual int IndexOf(string source, char value, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, 0, source.Length, options);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс первого найденного экземпляра во всей строке источника с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" /> с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает значение 0 (ноль), если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005455 RID: 21589 RVA: 0x00119D6C File Offset: 0x00117F6C
		public virtual int IndexOf(string source, string value, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, 0, source.Length, options);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс первого экземпляра в разделе строки источника от указанного индекса до конца строки.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, начиная с <paramref name="startIndex" /> и заканчивая <paramref name="source" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		// Token: 0x06005456 RID: 21590 RVA: 0x00119D8C File Offset: 0x00117F8C
		public virtual int IndexOf(string source, char value, int startIndex)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, startIndex, source.Length - startIndex, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс первого экземпляра в разделе строки источника от указанного индекса до конца строки.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, начиная с <paramref name="startIndex" /> и заканчивая <paramref name="source" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		// Token: 0x06005457 RID: 21591 RVA: 0x00119DAE File Offset: 0x00117FAE
		public virtual int IndexOf(string source, string value, int startIndex)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, startIndex, source.Length - startIndex, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск заданного знака и возвращает отсчитываемый от нуля индекс первого экземпляра в разделе исходной строки от заданного индекса до конца строки с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, начиная с <paramref name="startIndex" /> и заканчивая <paramref name="source" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005458 RID: 21592 RVA: 0x00119DD0 File Offset: 0x00117FD0
		public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, startIndex, source.Length - startIndex, options);
		}

		/// <summary>Осуществляет поиск заданной подстроки и возвращает отсчитываемый от нуля индекс первого экземпляра в разделе исходной строки от заданного индекса до конца строки с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, начиная с <paramref name="startIndex" /> и заканчивая <paramref name="source" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005459 RID: 21593 RVA: 0x00119DF3 File Offset: 0x00117FF3
		public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, startIndex, source.Length - startIndex, options);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс первого экземпляра в разделе строки источника, который начинается с указанного индекса и содержит указанное количество элементов.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который начинается с <paramref name="startIndex" /> и содержит количество элементов, определяемое параметром <paramref name="count" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		// Token: 0x0600545A RID: 21594 RVA: 0x00119E16 File Offset: 0x00118016
		public virtual int IndexOf(string source, char value, int startIndex, int count)
		{
			return this.IndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс первого экземпляра в разделе строки источника, который начинается с указанного индекса и содержит указанное число элементов.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который начинается с <paramref name="startIndex" /> и содержит количество элементов, определяемое параметром <paramref name="count" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		// Token: 0x0600545B RID: 21595 RVA: 0x00119E24 File Offset: 0x00118024
		public virtual int IndexOf(string source, string value, int startIndex, int count)
		{
			return this.IndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс первого экземпляра в разделе строки источника, который начинается с указанного индекса и содержит указанное количество элементов, с использованием указанного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который начинается с <paramref name="startIndex" /> и содержит количество элементов, определяемое параметром <paramref name="count" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600545C RID: 21596 RVA: 0x00119E34 File Offset: 0x00118034
		public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (startIndex < 0 || startIndex > source.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex > source.Length - count)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (source.Length == 0)
			{
				return -1;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return source.IndexOf(value.ToString(), startIndex, count, StringComparison.OrdinalIgnoreCase);
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (GlobalizationMode.Invariant)
			{
				return this.IndexOfOrdinal(source, new string(value, 1), startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
			}
			return this.IndexOfCore(source, new string(value, 1), startIndex, count, options, null);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс первого экземпляра в разделе строки источника, который начинается с указанного индекса и содержит указанное количество элементов, с использованием указанного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который начинается с <paramref name="startIndex" /> и содержит количество элементов, определяемое параметром <paramref name="count" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600545D RID: 21597 RVA: 0x00119F0C File Offset: 0x0011810C
		public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex > source.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (source.Length == 0)
			{
				if (value.Length == 0)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || startIndex > source.Length - count)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return this.IndexOfOrdinal(source, value, startIndex, count, true);
				}
				if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (GlobalizationMode.Invariant)
				{
					return this.IndexOfOrdinal(source, value, startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
				}
				return this.IndexOfCore(source, value, startIndex, count, options, null);
			}
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00119FFA File Offset: 0x001181FA
		internal int IndexOfOrdinal(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase)
		{
			return this.IndexOfOrdinalCore(source, value, ignoreCase);
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0011A005 File Offset: 0x00118205
		internal int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options)
		{
			return this.IndexOfCore(source, value, options, null);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0011A014 File Offset: 0x00118214
		internal unsafe int IndexOf(string source, string value, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			*matchLengthPtr = 0;
			if (source.Length == 0)
			{
				if (value.Length == 0)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (startIndex >= source.Length)
				{
					return -1;
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					int num = this.IndexOfOrdinal(source, value, startIndex, count, true);
					if (num >= 0)
					{
						*matchLengthPtr = value.Length;
					}
					return num;
				}
				if (GlobalizationMode.Invariant)
				{
					int num2 = this.IndexOfOrdinal(source, value, startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
					if (num2 >= 0)
					{
						*matchLengthPtr = value.Length;
					}
					return num2;
				}
				return this.IndexOfCore(source, value, startIndex, count, options, matchLengthPtr);
			}
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0011A0A1 File Offset: 0x001182A1
		internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantIndexOf(source, value, startIndex, count, ignoreCase);
			}
			return CompareInfo.IndexOfOrdinalCore(source, value, startIndex, count, ignoreCase);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс последнего найденного экземпляра во всей строке источника.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" />; если не найден — значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		// Token: 0x06005462 RID: 21602 RVA: 0x0011A0C3 File Offset: 0x001182C3
		public virtual int LastIndexOf(string source, char value)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.LastIndexOf(source, value, source.Length - 1, source.Length, CompareOptions.None);
		}

		/// <summary>Выполняет поиск указанной подстроки и возвращает начинающийся с нуля индекс последнего экземпляра в рамках всей исходной строки.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" />; если не найден — значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06005463 RID: 21603 RVA: 0x0011A0EA File Offset: 0x001182EA
		public virtual int LastIndexOf(string source, string value)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.LastIndexOf(source, value, source.Length - 1, source.Length, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс последнего найденного экземпляра во всей строке источника с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" /> с использованием указанных параметров сравнения; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005464 RID: 21604 RVA: 0x0011A111 File Offset: 0x00118311
		public virtual int LastIndexOf(string source, char value, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.LastIndexOf(source, value, source.Length - 1, source.Length, options);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс последнего найденного экземпляра во всей строке источника с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в <paramref name="source" /> с использованием указанных параметров сравнения; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005465 RID: 21605 RVA: 0x0011A138 File Offset: 0x00118338
		public virtual int LastIndexOf(string source, string value, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.LastIndexOf(source, value, source.Length - 1, source.Length, options);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс последнего экземпляра в разделе строки источника от начала строки до указанного индекса.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который начинается с <paramref name="source" /> и заканчивается на <paramref name="startIndex" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		// Token: 0x06005466 RID: 21606 RVA: 0x0011A15F File Offset: 0x0011835F
		public virtual int LastIndexOf(string source, char value, int startIndex)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс последнего экземпляра в разделе строки источника от начала строки до указанного индекса.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который начинается с <paramref name="source" /> и заканчивается на <paramref name="startIndex" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		// Token: 0x06005467 RID: 21607 RVA: 0x0011A16E File Offset: 0x0011836E
		public virtual int LastIndexOf(string source, string value, int startIndex)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск заданного знака и возвращает отсчитываемый от нуля индекс последнего экземпляра в разделе исходной строки от начала строки до заданного индекса с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, начиная с <paramref name="source" /> и заканчивая <paramref name="startIndex" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005468 RID: 21608 RVA: 0x0011A17D File Offset: 0x0011837D
		public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, options);
		}

		/// <summary>Осуществляет поиск заданной подстроки и возвращает отсчитываемый от нуля индекс последнего экземпляра в разделе исходной строки от начала строки до заданного индекса с использованием заданного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, начиная с <paramref name="source" /> и заканчивая <paramref name="startIndex" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x06005469 RID: 21609 RVA: 0x0011A18D File Offset: 0x0011838D
		public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, options);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс последнего экземпляра в разделе строки источника, который содержит указанное количество элементов и заканчивается на указанном индексе.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего экземпляра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который содержит количество элементов, определяемое параметром <paramref name="count" /> заканчивается на <paramref name="startIndex" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		// Token: 0x0600546A RID: 21610 RVA: 0x0011A19D File Offset: 0x0011839D
		public virtual int LastIndexOf(string source, char value, int startIndex, int count)
		{
			return this.LastIndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс последнего экземпляра в разделе строки источника, который содержит указанное количество элементов и заканчивается на указанном индексе.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего экземпляра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который содержит количество элементов, определяемое параметром <paramref name="count" /> заканчивается на <paramref name="startIndex" />; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		// Token: 0x0600546B RID: 21611 RVA: 0x0011A1AB File Offset: 0x001183AB
		public virtual int LastIndexOf(string source, string value, int startIndex, int count)
		{
			return this.LastIndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		/// <summary>Осуществляет поиск указанного знака и возвращает отсчитываемый с нуля индекс последнего экземпляра в разделе строки источника, который содержит указанное количество элементов и заканчивается на указанном индексе, с использованием указанного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Знак, который нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который содержит количество элементов, определяемое параметром <paramref name="count" /> и заканчивается на <paramref name="startIndex" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600546C RID: 21612 RVA: 0x0011A1BC File Offset: 0x001183BC
		public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal && options != CompareOptions.OrdinalIgnoreCase)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (source.Length == 0 && (startIndex == -1 || startIndex == 0))
			{
				return -1;
			}
			if (startIndex < 0 || startIndex > source.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (startIndex == source.Length)
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
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return source.LastIndexOf(value.ToString(), startIndex, count, StringComparison.OrdinalIgnoreCase);
			}
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantLastIndexOf(source, new string(value, 1), startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
			}
			return this.LastIndexOfCore(source, value.ToString(), startIndex, count, options);
		}

		/// <summary>Осуществляет поиск указанной подстроки и возвращает отсчитываемый с нуля индекс последнего экземпляра в разделе строки источника, который содержит указанное количество элементов и заканчивается на указанном индексе, с использованием указанного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка для поиска.</param>
		/// <param name="value">Строка, которую нужно найти в <paramref name="source" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="options">Значение, определяющее способ сравнения <paramref name="source" /> и <paramref name="value" />. Параметр <paramref name="options" /> является значением перечисления <see cref="F:System.Globalization.CompareOptions.Ordinal" />, используемым самостоятельно, или побитовой комбинацией одного или нескольких следующих значений: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" /> и <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения параметра <paramref name="value" />, если есть, в разделе <paramref name="source" />, который содержит количество элементов, определяемое параметром <paramref name="count" /> и заканчивается на <paramref name="startIndex" />, с использованием указанных параметров сравнения; в противном случае — значение -1. Возвращает <paramref name="startIndex" />, если <paramref name="value" /> — игнорируемый символ.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startIndex" /> находится вне диапазона допустимых индексов параметра <paramref name="source" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Параметры <paramref name="startIndex" /> и <paramref name="count" /> не определяют допустимую часть объекта <paramref name="source" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600546D RID: 21613 RVA: 0x0011A2B8 File Offset: 0x001184B8
		public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal && options != CompareOptions.OrdinalIgnoreCase)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (source.Length == 0 && (startIndex == -1 || startIndex == 0))
			{
				if (value.Length != 0)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (startIndex < 0 || startIndex > source.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (startIndex == source.Length)
				{
					startIndex--;
					if (count > 0)
					{
						count--;
					}
					if (value.Length == 0 && count >= 0 && startIndex - count + 1 >= 0)
					{
						return startIndex;
					}
				}
				if (count < 0 || startIndex - count + 1 < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return this.LastIndexOfOrdinal(source, value, startIndex, count, true);
				}
				if (GlobalizationMode.Invariant)
				{
					return CompareInfo.InvariantLastIndexOf(source, value, startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
				}
				return this.LastIndexOfCore(source, value, startIndex, count, options);
			}
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x0011A3D1 File Offset: 0x001185D1
		internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantLastIndexOf(source, value, startIndex, count, ignoreCase);
			}
			return CompareInfo.LastIndexOfOrdinalCore(source, value, startIndex, count, ignoreCase);
		}

		/// <summary>Получает объект <see cref="T:System.Globalization.SortKey" /> для указанной строки с использованием указанного значения <see cref="T:System.Globalization.CompareOptions" />.</summary>
		/// <param name="source">Строка, для которой получен объект <see cref="T:System.Globalization.SortKey" />.</param>
		/// <param name="options">Битовая комбинация одного или нескольких из следующих значений перечисления, указывающих, как вычисляется ключ сортировки: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" /> и <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>Объект <see cref="T:System.Globalization.SortKey" />, который содержит ключ сортировки для указанной строки.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> содержит недопустимое значение <see cref="T:System.Globalization.CompareOptions" />.</exception>
		// Token: 0x0600546F RID: 21615 RVA: 0x0011A3F3 File Offset: 0x001185F3
		public virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			if (GlobalizationMode.Invariant)
			{
				return this.InvariantCreateSortKey(source, options);
			}
			return this.CreateSortKey(source, options);
		}

		/// <summary>Получает ключ сортировки для указанной строки.</summary>
		/// <param name="source">Строка, для которой получен объект <see cref="T:System.Globalization.SortKey" />.</param>
		/// <returns>Объект <see cref="T:System.Globalization.SortKey" />, который содержит ключ сортировки для указанной строки.</returns>
		// Token: 0x06005470 RID: 21616 RVA: 0x0011A40D File Offset: 0x0011860D
		public virtual SortKey GetSortKey(string source)
		{
			if (GlobalizationMode.Invariant)
			{
				return this.InvariantCreateSortKey(source, CompareOptions.None);
			}
			return this.CreateSortKey(source, CompareOptions.None);
		}

		/// <summary>Определяет, равен ли заданный объект текущему объекту <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <param name="value">Объект для сравнения с текущим объектом <see cref="T:System.Globalization.CompareInfo" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект равен текущему объекту <see cref="T:System.Globalization.CompareInfo" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005471 RID: 21617 RVA: 0x0011A428 File Offset: 0x00118628
		public override bool Equals(object value)
		{
			CompareInfo compareInfo = value as CompareInfo;
			return compareInfo != null && this.Name == compareInfo.Name;
		}

		/// <summary>Служит хэш-функцией текущего класса <see cref="T:System.Globalization.CompareInfo" /> для алгоритмов хэширования и структур данных, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Globalization.CompareInfo" />.</returns>
		// Token: 0x06005472 RID: 21618 RVA: 0x0011A452 File Offset: 0x00118652
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x0011A460 File Offset: 0x00118660
		internal unsafe static int GetIgnoreCaseHash(string source)
		{
			if (source.Length == 0)
			{
				return source.GetHashCode();
			}
			char[] array = null;
			Span<char> span;
			if (source.Length <= 255)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)510], 255);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(source.Length));
			}
			Span<char> destination = span;
			int length = source.AsSpan().ToUpperInvariant(destination);
			int result = Marvin.ComputeHash32(MemoryMarshal.AsBytes<char>(destination.Slice(0, length)), Marvin.DefaultSeed);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x0011A4F4 File Offset: 0x001186F4
		internal int GetHashCodeOfString(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (!GlobalizationMode.Invariant)
			{
				return this.GetHashCodeOfStringCore(source, options);
			}
			if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
			{
				return source.GetHashCode();
			}
			return CompareInfo.GetIgnoreCaseHash(source);
		}

		/// <summary>Возвращает хэш-код для строки на основе указанных параметров сравнения.</summary>
		/// <param name="source">Строка, для которой нужно вернуть хэш-код.</param>
		/// <param name="options">Значение, определяющее способ сравнения строк.</param>
		/// <returns>Хэш-код в виде 32-битовым целым числом со знаком.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		// Token: 0x06005475 RID: 21621 RVA: 0x0011A547 File Offset: 0x00118747
		public virtual int GetHashCode(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (options == CompareOptions.Ordinal)
			{
				return source.GetHashCode();
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return CompareInfo.GetIgnoreCaseHash(source);
			}
			return this.GetHashCodeOfString(source, options);
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Globalization.CompareInfo" />.</returns>
		// Token: 0x06005476 RID: 21622 RVA: 0x0011A57D File Offset: 0x0011877D
		public override string ToString()
		{
			return "CompareInfo - " + this.Name;
		}

		/// <summary>Получает сведения о версии Юникода, используемой для сравнения и сортировки строк.</summary>
		/// <returns>Объект, содержащий сведения о версии Юникода, используемой для сравнения и сортировки строк.</returns>
		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06005477 RID: 21623 RVA: 0x0011A590 File Offset: 0x00118790
		public SortVersion Version
		{
			get
			{
				if (this.m_SortVersion == null)
				{
					if (GlobalizationMode.Invariant)
					{
						this.m_SortVersion = new SortVersion(0, 127, new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 127));
					}
					else
					{
						this.m_SortVersion = this.GetSortVersion();
					}
				}
				return this.m_SortVersion;
			}
		}

		/// <summary>Возвращает идентификатор языка и региональных параметров, соответствующий текущему классу <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <returns>Идентификатор языка и региональных параметров, соответствующий текущему классу <see cref="T:System.Globalization.CompareInfo" />.</returns>
		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x0011A5E5 File Offset: 0x001187E5
		public int LCID
		{
			get
			{
				return CultureInfo.GetCultureInfo(this.Name).LCID;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x0011A5F7 File Offset: 0x001187F7
		private static bool UseManagedCollation
		{
			get
			{
				if (!CompareInfo.managedCollationChecked)
				{
					CompareInfo.managedCollation = (Environment.internalGetEnvironmentVariable("MONO_DISABLE_MANAGED_COLLATION") != "yes" && MSCompatUnicodeTable.IsReady);
					CompareInfo.managedCollationChecked = true;
				}
				return CompareInfo.managedCollation;
			}
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x0011A630 File Offset: 0x00118830
		private ISimpleCollator GetCollator()
		{
			if (this.collator != null)
			{
				return this.collator;
			}
			if (CompareInfo.collators == null)
			{
				Interlocked.CompareExchange<Dictionary<string, ISimpleCollator>>(ref CompareInfo.collators, new Dictionary<string, ISimpleCollator>(StringComparer.Ordinal), null);
			}
			Dictionary<string, ISimpleCollator> obj = CompareInfo.collators;
			lock (obj)
			{
				if (!CompareInfo.collators.TryGetValue(this._sortName, out this.collator))
				{
					this.collator = new SimpleCollator(CultureInfo.GetCultureInfo(this.m_name));
					CompareInfo.collators[this._sortName] = this.collator;
				}
			}
			return this.collator;
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0011A6E0 File Offset: 0x001188E0
		private SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			if (CompareInfo.UseManagedCollation)
			{
				return this.GetCollator().GetSortKey(source, options);
			}
			return new SortKey(this.culture, source, options);
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0011A704 File Offset: 0x00118904
		private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			if (opt == CompareOptions.Ordinal)
			{
				if (!first)
				{
					return s1.LastIndexOfUnchecked(s2, sindex, count);
				}
				return s1.IndexOfUnchecked(s2, sindex, count);
			}
			else
			{
				if (!CompareInfo.UseManagedCollation)
				{
					return CompareInfo.internal_index(s1, sindex, count, s2, first);
				}
				return this.internal_index_managed(s1, sindex, count, s2, opt, first);
			}
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0011A757 File Offset: 0x00118957
		private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			if (!CompareInfo.UseManagedCollation)
			{
				return CompareInfo.internal_compare(str1, offset1, length1, str2, offset2, length2, options);
			}
			return this.internal_compare_managed(str1, offset1, length1, str2, offset2, length2, options);
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x0011A782 File Offset: 0x00118982
		private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			return this.GetCollator().Compare(str1, offset1, length1, str2, offset2, length2, options);
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0011A79A File Offset: 0x0011899A
		private int internal_index_managed(string s, int sindex, int count, char c, CompareOptions opt, bool first)
		{
			if (!first)
			{
				return this.GetCollator().LastIndexOf(s, c, sindex, count, opt);
			}
			return this.GetCollator().IndexOf(s, c, sindex, count, opt);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0011A7C5 File Offset: 0x001189C5
		private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			if (!first)
			{
				return this.GetCollator().LastIndexOf(s1, s2, sindex, count, opt);
			}
			return this.GetCollator().IndexOf(s1, s2, sindex, count, opt);
		}

		// Token: 0x06005481 RID: 21633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options);

		// Token: 0x06005482 RID: 21634 RVA: 0x0011A7F0 File Offset: 0x001189F0
		private unsafe static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			char* ptr = str1;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = str2;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return CompareInfo.internal_compare_icall(ptr + offset1, length1, ptr2 + offset2, length2, options);
		}

		// Token: 0x06005483 RID: 21635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first);

		// Token: 0x06005484 RID: 21636 RVA: 0x0011A834 File Offset: 0x00118A34
		private unsafe static int internal_index(string source, int sindex, int count, string value, bool first)
		{
			char* ptr = source;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = value;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return CompareInfo.internal_index_icall(ptr, sindex, count, ptr2, (value != null) ? value.Length : 0, first);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0011A878 File Offset: 0x00118A78
		private void InitSort(CultureInfo culture)
		{
			this._sortName = culture.SortName;
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x0011A888 File Offset: 0x00118A88
		private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
		{
			TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
			int num = 0;
			while (num < length1 && num < length2 && textInfo.ToUpper(*pString1) == textInfo.ToUpper(*pString2))
			{
				num++;
				pString1++;
				pString2++;
			}
			if (num >= length1)
			{
				if (num >= length2)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (num >= length2)
				{
					return 1;
				}
				return (int)(textInfo.ToUpper(*pString1) - textInfo.ToUpper(*pString2));
			}
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x0011A8EF File Offset: 0x00118AEF
		internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (!ignoreCase)
			{
				return source.IndexOfUnchecked(value, startIndex, count);
			}
			return source.IndexOfUncheckedIgnoreCase(value, startIndex, count);
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0011A908 File Offset: 0x00118B08
		internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (!ignoreCase)
			{
				return source.LastIndexOfUnchecked(value, startIndex, count);
			}
			return source.LastIndexOfUncheckedIgnoreCase(value, startIndex, count);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x0011A921 File Offset: 0x00118B21
		private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
		{
			return this.internal_index_switch(source, startIndex, count, target, options, false);
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x0011A931 File Offset: 0x00118B31
		private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			if (matchLengthPtr != null)
			{
				throw new NotImplementedException();
			}
			return this.internal_index_switch(source, startIndex, count, target, options, true);
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x0011A950 File Offset: 0x00118B50
		private unsafe int IndexOfCore(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr)
		{
			string text = new string(source);
			string target2 = new string(target);
			return this.IndexOfCore(text, target2, 0, text.Length, options, matchLengthPtr);
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x0011A980 File Offset: 0x00118B80
		private int IndexOfOrdinalCore(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase)
		{
			string text = new string(source);
			string value2 = new string(value);
			if (!ignoreCase)
			{
				return text.IndexOfUnchecked(value2, 0, text.Length);
			}
			return text.IndexOfUncheckedIgnoreCase(value2, 0, text.Length);
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x0011A9BC File Offset: 0x00118BBC
		private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			string text = new string(string1);
			return this.internal_compare_switch(text, 0, text.Length, string2, 0, string2.Length, options);
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x0011A9E8 File Offset: 0x00118BE8
		private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			string text = new string(string1);
			string text2 = new string(string2);
			return this.internal_compare_switch(text, 0, text.Length, new string(text2), 0, text2.Length, options);
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x0011AA24 File Offset: 0x00118C24
		private unsafe static bool IsSortable(char* text, int length)
		{
			return MSCompatUnicodeTable.IsSortable(new string(text, 0, length));
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x0011AA33 File Offset: 0x00118C33
		private SortKey CreateSortKey(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			return this.CreateSortKeyCore(source, options);
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x0011AA64 File Offset: 0x00118C64
		private bool StartsWith(string source, string prefix, CompareOptions options)
		{
			if (CompareInfo.UseManagedCollation)
			{
				return this.GetCollator().IsPrefix(source, prefix, options);
			}
			return source.Length >= prefix.Length && this.Compare(source, 0, prefix.Length, prefix, 0, prefix.Length, options) == 0;
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x0011AAB1 File Offset: 0x00118CB1
		private bool StartsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options)
		{
			return this.StartsWith(new string(source), new string(prefix), options);
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x0011AAC8 File Offset: 0x00118CC8
		private bool EndsWith(string source, string suffix, CompareOptions options)
		{
			if (CompareInfo.UseManagedCollation)
			{
				return this.GetCollator().IsSuffix(source, suffix, options);
			}
			return source.Length >= suffix.Length && this.Compare(source, source.Length - suffix.Length, suffix.Length, suffix, 0, suffix.Length, options) == 0;
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x0011AB21 File Offset: 0x00118D21
		private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return this.EndsWith(new string(source), new string(suffix), options);
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x0011AB36 File Offset: 0x00118D36
		internal int GetHashCodeOfStringCore(string source, CompareOptions options)
		{
			return this.GetSortKey(source, options).GetHashCode();
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x000479F8 File Offset: 0x00045BF8
		private SortVersion GetSortVersion()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x000173AD File Offset: 0x000155AD
		internal CompareInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040033BB RID: 13243
		private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x040033BC RID: 13244
		private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x040033BD RID: 13245
		private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x040033BE RID: 13246
		private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x040033BF RID: 13247
		internal static readonly CompareInfo Invariant = CultureInfo.InvariantCulture.CompareInfo;

		// Token: 0x040033C0 RID: 13248
		[OptionalField(VersionAdded = 2)]
		private string m_name;

		// Token: 0x040033C1 RID: 13249
		[NonSerialized]
		private string _sortName;

		// Token: 0x040033C2 RID: 13250
		[OptionalField(VersionAdded = 3)]
		private SortVersion m_SortVersion;

		// Token: 0x040033C3 RID: 13251
		private int culture;

		// Token: 0x040033C4 RID: 13252
		[NonSerialized]
		private ISimpleCollator collator;

		// Token: 0x040033C5 RID: 13253
		private static Dictionary<string, ISimpleCollator> collators;

		// Token: 0x040033C6 RID: 13254
		private static bool managedCollation;

		// Token: 0x040033C7 RID: 13255
		private static bool managedCollationChecked;
	}
}
