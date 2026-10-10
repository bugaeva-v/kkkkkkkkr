using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>Предоставляет функциональные возможности для разбиения строки на текстовые элементы и их последующего перебора.</summary>
	// Token: 0x02000995 RID: 2453
	[ComVisible(true)]
	[Serializable]
	public class StringInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.StringInfo" />.</summary>
		// Token: 0x060057D8 RID: 22488 RVA: 0x00128786 File Offset: 0x00126986
		public StringInfo() : this("")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.StringInfo" /> в указанной строке.</summary>
		/// <param name="value">Строка для инициализации объекта <see cref="T:System.Globalization.StringInfo" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060057D9 RID: 22489 RVA: 0x00128793 File Offset: 0x00126993
		public StringInfo(string value)
		{
			this.String = value;
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x001287A2 File Offset: 0x001269A2
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.m_str = string.Empty;
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x001287AF File Offset: 0x001269AF
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			if (this.m_str.Length == 0)
			{
				this.m_indexes = null;
			}
		}

		/// <summary>Указывает, равен ли текущий объект <see cref="T:System.Globalization.StringInfo" /> указанному объекту.</summary>
		/// <param name="value">Объект.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> является объектом <see cref="T:System.Globalization.StringInfo" /> и его свойство <see cref="P:System.Globalization.StringInfo.String" /> равняется свойству <see cref="P:System.Globalization.StringInfo.String" /> этого объекта <see cref="T:System.Globalization.StringInfo" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060057DC RID: 22492 RVA: 0x001287C8 File Offset: 0x001269C8
		[ComVisible(false)]
		public override bool Equals(object value)
		{
			StringInfo stringInfo = value as StringInfo;
			return stringInfo != null && this.m_str.Equals(stringInfo.m_str);
		}

		/// <summary>Рассчитывает хэш-код для значения текущего объекта <see cref="T:System.Globalization.StringInfo" />.</summary>
		/// <returns>32-битное целое число хэш-кода со знаком, основанное на значении строки этого объекта <see cref="T:System.Globalization.StringInfo" />.</returns>
		// Token: 0x060057DD RID: 22493 RVA: 0x001287F2 File Offset: 0x001269F2
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return this.m_str.GetHashCode();
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060057DE RID: 22494 RVA: 0x001287FF File Offset: 0x001269FF
		private int[] Indexes
		{
			get
			{
				if (this.m_indexes == null && 0 < this.String.Length)
				{
					this.m_indexes = StringInfo.ParseCombiningCharacters(this.String);
				}
				return this.m_indexes;
			}
		}

		/// <summary>Получает или задает значение текущего объекта <see cref="T:System.Globalization.StringInfo" />.</summary>
		/// <returns>Строка, представляющая значение текущего объекта <see cref="T:System.Globalization.StringInfo" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции задания значением является <see langword="null" />.</exception>
		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060057DF RID: 22495 RVA: 0x0012882E File Offset: 0x00126A2E
		// (set) Token: 0x060057E0 RID: 22496 RVA: 0x00128836 File Offset: 0x00126A36
		public string String
		{
			get
			{
				return this.m_str;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("String", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.m_str = value;
				this.m_indexes = null;
			}
		}

		/// <summary>Получает число текстовых элементов в текущем объекте <see cref="T:System.Globalization.StringInfo" />.</summary>
		/// <returns>Количество базовых символов, суррогатных пар и последовательностей несамостоятельных знаков в этом объекте <see cref="T:System.Globalization.StringInfo" />.</returns>
		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x0012885E File Offset: 0x00126A5E
		public int LengthInTextElements
		{
			get
			{
				if (this.Indexes == null)
				{
					return 0;
				}
				return this.Indexes.Length;
			}
		}

		/// <summary>Получает подстроку элементов текста из текущего объекта <see cref="T:System.Globalization.StringInfo" />, начиная с указанного элемента текста и продолжая до самого последнего элемента.</summary>
		/// <param name="startingTextElement">Отсчитываемый от нуля индекс текстового элемента в этом объекте <see cref="T:System.Globalization.StringInfo" />.</param>
		/// <returns>Подстрока элементов текста в этом объекте <see cref="T:System.Globalization.StringInfo" />, начиная с индекса элементов текста, указанного в параметре <paramref name="startingTextElement" /> и продолжая до последнего элемента текста в этом объекте.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startingTextElement" /> меньше нуля.  
		///
		/// или - 
		/// Строка, являющаяся значением текущего объекта <see cref="T:System.Globalization.StringInfo" />, является пустой строкой ("").</exception>
		// Token: 0x060057E2 RID: 22498 RVA: 0x00128874 File Offset: 0x00126A74
		public string SubstringByTextElements(int startingTextElement)
		{
			if (this.Indexes != null)
			{
				return this.SubstringByTextElements(startingTextElement, this.Indexes.Length - startingTextElement);
			}
			if (startingTextElement < 0)
			{
				throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("Positive number required."));
			}
			throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("Specified argument was out of the range of valid values."));
		}

		/// <summary>Получает подстроку элементов текста из текущего объекта <see cref="T:System.Globalization.StringInfo" />, начиная с указанного элемента текста и продолжая до указанного количества элементов текста.</summary>
		/// <param name="startingTextElement">Отсчитываемый от нуля индекс текстового элемента в этом объекте <see cref="T:System.Globalization.StringInfo" />.</param>
		/// <param name="lengthInTextElements">Количество извлекаемых элементов текста.</param>
		/// <returns>Подстрока элементов текста в этом объекте <see cref="T:System.Globalization.StringInfo" />. Подстрока состоит из некоторого количества элементов текста, определенных параметром <paramref name="lengthInTextElements" />, начиная с индекса элемента текста, указанного в параметре <paramref name="startingTextElement" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="startingTextElement" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="startingTextElement" /> больше или равен длине строки, которая является значением текущего объекта <see cref="T:System.Globalization.StringInfo" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="lengthInTextElements" /> меньше нуля.  
		///
		/// или - 
		/// Строка, являющаяся значением текущего объекта <see cref="T:System.Globalization.StringInfo" />, является пустой строкой ("").  
		///
		/// или - 
		/// <paramref name="startingTextElement" /> + <paramref name="lengthInTextElements" /> определяет индекс, который больше количества элементов текста в этом объекте <see cref="T:System.Globalization.StringInfo" />.</exception>
		// Token: 0x060057E3 RID: 22499 RVA: 0x001288C8 File Offset: 0x00126AC8
		public string SubstringByTextElements(int startingTextElement, int lengthInTextElements)
		{
			if (startingTextElement < 0)
			{
				throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("Positive number required."));
			}
			if (this.String.Length == 0 || startingTextElement >= this.Indexes.Length)
			{
				throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("Specified argument was out of the range of valid values."));
			}
			if (lengthInTextElements < 0)
			{
				throw new ArgumentOutOfRangeException("lengthInTextElements", Environment.GetResourceString("Positive number required."));
			}
			if (startingTextElement > this.Indexes.Length - lengthInTextElements)
			{
				throw new ArgumentOutOfRangeException("lengthInTextElements", Environment.GetResourceString("Specified argument was out of the range of valid values."));
			}
			int num = this.Indexes[startingTextElement];
			if (startingTextElement + lengthInTextElements == this.Indexes.Length)
			{
				return this.String.Substring(num);
			}
			return this.String.Substring(num, this.Indexes[lengthInTextElements + startingTextElement] - num);
		}

		/// <summary>Возвращает первый текстовый элемент в заданной строке.</summary>
		/// <param name="str">Строка, из которой нужно получить элемент текста.</param>
		/// <returns>Строка, содержащая первый текстовый элемент в заданной строке.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060057E4 RID: 22500 RVA: 0x00128991 File Offset: 0x00126B91
		public static string GetNextTextElement(string str)
		{
			return StringInfo.GetNextTextElement(str, 0);
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x0012899C File Offset: 0x00126B9C
		internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount)
		{
			if (index + currentCharCount == len)
			{
				return currentCharCount;
			}
			int num;
			UnicodeCategory unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, index + currentCharCount, out num);
			if (CharUnicodeInfo.IsCombiningCategory(unicodeCategory) && !CharUnicodeInfo.IsCombiningCategory(ucCurrent) && ucCurrent != UnicodeCategory.Format && ucCurrent != UnicodeCategory.Control && ucCurrent != UnicodeCategory.OtherNotAssigned && ucCurrent != UnicodeCategory.Surrogate)
			{
				int num2 = index;
				for (index += currentCharCount + num; index < len; index += num)
				{
					unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, index, out num);
					if (!CharUnicodeInfo.IsCombiningCategory(unicodeCategory))
					{
						ucCurrent = unicodeCategory;
						currentCharCount = num;
						break;
					}
				}
				return index - num2;
			}
			int result = currentCharCount;
			ucCurrent = unicodeCategory;
			currentCharCount = num;
			return result;
		}

		/// <summary>Возвращает элемент текста по указанному индексу заданной строки.</summary>
		/// <param name="str">Строка, из которой нужно получить элемент текста.</param>
		/// <param name="index">Отсчитываемый от нуля индекс, с которого начинается элемент текста.</param>
		/// <returns>Строка, содержащая элемент текста по указанному индексу заданной строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <paramref name="str" />.</exception>
		// Token: 0x060057E6 RID: 22502 RVA: 0x00128A2C File Offset: 0x00126C2C
		public static string GetNextTextElement(string str, int index)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			int length = str.Length;
			if (index >= 0 && index < length)
			{
				int num;
				UnicodeCategory unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, index, out num);
				return str.Substring(index, StringInfo.GetCurrentTextElementLen(str, index, length, ref unicodeCategory, ref num));
			}
			if (index == length)
			{
				return string.Empty;
			}
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("Index was out of range. Must be non-negative and less than the size of the collection."));
		}

		/// <summary>Возвращает перечислитель, который выполняет итерацию по текстовым элементам всей строки.</summary>
		/// <param name="str">Строка, в выполняется итерация.</param>
		/// <returns>Объект <see cref="T:System.Globalization.TextElementEnumerator" /> для всей строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060057E7 RID: 22503 RVA: 0x00128A92 File Offset: 0x00126C92
		public static TextElementEnumerator GetTextElementEnumerator(string str)
		{
			return StringInfo.GetTextElementEnumerator(str, 0);
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию по текстовым элементам строки, начиная с указанного индекса.</summary>
		/// <param name="str">Строка, в выполняется итерация.</param>
		/// <param name="index">Отсчитываемый от нуля индекс, с которого необходимо начать итерацию.</param>
		/// <returns>Параметр <see cref="T:System.Globalization.TextElementEnumerator" /> для всей строки, начиная с индекса <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <paramref name="str" />.</exception>
		// Token: 0x060057E8 RID: 22504 RVA: 0x00128A9C File Offset: 0x00126C9C
		public static TextElementEnumerator GetTextElementEnumerator(string str, int index)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			int length = str.Length;
			if (index < 0 || index > length)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("Index was out of range. Must be non-negative and less than the size of the collection."));
			}
			return new TextElementEnumerator(str, index, length);
		}

		/// <summary>Возвращает индексы каждого базового знака, старший символ-заместитель или знак элемента управления в пределах указанной строки.</summary>
		/// <param name="str">Строка для поиска.</param>
		/// <returns>Массив целочисленных чисел, который содержит отсчитываемые с нуля индексы каждого базового знака, старший символ-заместитель или знак элемента управления в пределах указанной строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060057E9 RID: 22505 RVA: 0x00128AE4 File Offset: 0x00126CE4
		public static int[] ParseCombiningCharacters(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			int length = str.Length;
			int[] array = new int[length];
			if (length == 0)
			{
				return array;
			}
			int num = 0;
			int i = 0;
			int num2;
			UnicodeCategory unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, 0, out num2);
			while (i < length)
			{
				array[num++] = i;
				i += StringInfo.GetCurrentTextElementLen(str, i, length, ref unicodeCategory, ref num2);
			}
			if (num < length)
			{
				int[] array2 = new int[num];
				Array.Copy(array, array2, num);
				return array2;
			}
			return array;
		}

		// Token: 0x0400368C RID: 13964
		[OptionalField(VersionAdded = 2)]
		private string m_str;

		// Token: 0x0400368D RID: 13965
		[NonSerialized]
		private int[] m_indexes;
	}
}
