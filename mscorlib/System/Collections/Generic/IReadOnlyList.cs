using System;

namespace System.Collections.Generic
{
	/// <summary>Представляет доступную только для чтения коллекцию элементов, доступ к которым может быть получен по индексу.</summary>
	/// <typeparam name="T">Тип элементов в списке, доступном только для чтения.</typeparam>
	// Token: 0x02000A9F RID: 2719
	public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<!0>, IEnumerable
	{
		/// <summary>Получает элемент в коллекции по указанному индексу в списке, доступном только для чтения.</summary>
		/// <param name="index">Индекс элемента (с нуля), который требуется получить.</param>
		/// <returns>Элемент в коллекции по указанному индексу в списке, доступном только для чтения.</returns>
		// Token: 0x1700114B RID: 4427
		T this[int index]
		{
			get;
		}
	}
}
