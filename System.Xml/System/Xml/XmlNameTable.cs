using System;

namespace System.Xml
{
	/// <summary>
	///         Таблица атомизированных строковых объектов.
	///       </summary>
	// Token: 0x0200023C RID: 572
	public abstract class XmlNameTable
	{
		/// <summary>
		///         При переопределении в производном классе получает атомизированную строку, содержащую те же символы, что и заданный диапазон символов в заданном массиве.
		///       </summary>
		/// <param name="array">
		///           Массив символов, содержащий искомое имя.
		///         </param>
		/// <param name="offset">
		///           Отсчитываемый от нуля индекс в массиве, задающий первый символ имени.
		///         </param>
		/// <param name="length">
		///           Количество символов в имени.
		///         </param>
		/// <returns>
		///         Атомизированную строку или <see langword="null" /> если строка еще не атомизирована.
		///          Если <paramref name="length" /> равно нулю, возвращается String.Empty.
		///       </returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///             0 &gt; <paramref name="offset" />
		///
		///             -или- 
		///
		///             <paramref name="offset" /> &gt;= <paramref name="array" />. Длина 
		///
		///             -или- 
		///
		///             <paramref name="length" /> &gt; <paramref name="array" />. Длина 
		///
		///             Выше условия не вызывают исключение, если <paramref name="length" /> = 0.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="length" /> &lt; 0.
		///           </exception>
		// Token: 0x06001572 RID: 5490
		public abstract string Get(char[] array, int offset, int length);

		/// <summary>
		///         При переопределении в производном классе получает атомизированную строку, содержащую то же значение, что и заданная строка.
		///       </summary>
		/// <param name="array">
		///           Имя для поиска.
		///         </param>
		/// <returns>
		///         Атомизированную строку или <see langword="null" /> если строка еще не атомизирована.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="array" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001573 RID: 5491
		public abstract string Get(string array);

		/// <summary>
		///         При переопределении в производном классе Разъединяет указанную строку и добавляет его в <see langword="XmlNameTable" />.
		///       </summary>
		/// <param name="array">
		///           Массив символов, содержащий добавляемое имя.
		///         </param>
		/// <param name="offset">
		///           Отсчитываемый от нуля индекс в массиве, задающий первый символ имени.
		///         </param>
		/// <param name="length">
		///           Количество символов в имени.
		///         </param>
		/// <returns>
		///         Новый атомизирована или существующая строка, если он уже существует.
		///          Если длина равна нулю, возвращается String.Empty.
		///       </returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///             0 &gt; <paramref name="offset" />
		///
		///             -или- 
		///
		///             <paramref name="offset" /> &gt;= <paramref name="array" />. Длина 
		///
		///             -или- 
		///
		///             <paramref name="length" /> &gt; <paramref name="array" />. Длина 
		///
		///             Выше условия не вызывают исключение, если <paramref name="length" /> = 0.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="length" /> &lt; 0.
		///           </exception>
		// Token: 0x06001574 RID: 5492
		public abstract string Add(char[] array, int offset, int length);

		/// <summary>
		///         При переопределении в производном классе Разъединяет указанную строку и добавляет его в <see langword="XmlNameTable" />.
		///       </summary>
		/// <param name="array">
		///           Добавляемое имя.
		///         </param>
		/// <returns>
		///         Новый атомизирована или существующая строка, если он уже существует.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="array" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001575 RID: 5493
		public abstract string Add(string array);
	}
}
