using System;

namespace System.Collections
{
	/// <summary>Поддерживает простой перебор по неуниверсальной коллекции.</summary>
	// Token: 0x02000A17 RID: 2583
	public interface IEnumerator
	{
		/// <summary>Перемещает перечислитель к следующему элементу коллекции.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x06005B92 RID: 23442
		bool MoveNext();

		/// <summary>Возвращает элемент коллекции, соответствующий текущей позиции перечислителя.</summary>
		/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06005B93 RID: 23443
		object Current { get; }

		/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x06005B94 RID: 23444
		void Reset();
	}
}
