using System;

namespace System.Collections.Specialized
{
	/// <summary>Создает коллекции, которые не учитывают регистр строк.</summary>
	// Token: 0x020004A2 RID: 1186
	public class CollectionsUtil
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр, с исходной емкостью по умолчанию.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр, с исходной емкостью по умолчанию.</returns>
		// Token: 0x0600260C RID: 9740 RVA: 0x000857E4 File Offset: 0x000839E4
		public static Hashtable CreateCaseInsensitiveHashtable()
		{
			return new Hashtable(StringComparer.CurrentCultureIgnoreCase);
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр, с указанной исходной емкостью.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может содержать класс <see cref="T:System.Collections.Hashtable" />.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр, с указанной исходной емкостью.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x0600260D RID: 9741 RVA: 0x000857F0 File Offset: 0x000839F0
		public static Hashtable CreateCaseInsensitiveHashtable(int capacity)
		{
			return new Hashtable(capacity, StringComparer.CurrentCultureIgnoreCase);
		}

		/// <summary>Копирует записи из указанного словаря в новый экземпляр класса <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр и исходная емкость которого равна количеству копируемых записей.</summary>
		/// <param name="d">Интерфейс <see cref="T:System.Collections.IDictionary" />, элементы которого требуется скопировать в новый класс <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Collections.Hashtable" />, в котором не учитывается регистр, содержащий записи из указанного интерфейса <see cref="T:System.Collections.IDictionary" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="d" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600260E RID: 9742 RVA: 0x000857FD File Offset: 0x000839FD
		public static Hashtable CreateCaseInsensitiveHashtable(IDictionary d)
		{
			return new Hashtable(d, StringComparer.CurrentCultureIgnoreCase);
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Collections.SortedList" />, в котором не учитывается регистр строк.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Collections.SortedList" />, в котором не учитывается регистр строк.</returns>
		// Token: 0x0600260F RID: 9743 RVA: 0x0008580A File Offset: 0x00083A0A
		public static SortedList CreateCaseInsensitiveSortedList()
		{
			return new SortedList(CaseInsensitiveComparer.Default);
		}
	}
}
