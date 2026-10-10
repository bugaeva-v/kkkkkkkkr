using System;

namespace System.Collections
{
	/// <summary>Перечисляет элементы неуниверсального словаря.</summary>
	// Token: 0x02000A15 RID: 2581
	public interface IDictionaryEnumerator : IEnumerator
	{
		/// <summary>Получает ключ текущего элемента словаря.</summary>
		/// <returns>Ключ текущего элемента перечисления.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> размещен перед первым элементом словаря или после последнего элемента.</exception>
		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06005B8E RID: 23438
		object Key { get; }

		/// <summary>Получает значение текущего элемента словаря.</summary>
		/// <returns>Значение текущего элемента перечисления.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> размещен перед первым элементом словаря или после последнего элемента.</exception>
		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06005B8F RID: 23439
		object Value { get; }

		/// <summary>Получает и ключ, и значение текущего элемента словаря.</summary>
		/// <returns>Объект <see cref="T:System.Collections.DictionaryEntry" />, содержащий и ключ, и значение текущего элемента словаря.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> размещен перед первым элементом словаря или после последнего элемента.</exception>
		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06005B90 RID: 23440
		DictionaryEntry Entry { get; }
	}
}
