using System;

namespace System.Collections.Generic
{
	/// <summary>Возвращает строго типизированную коллекцию элементов, доступную только для чтения.</summary>
	/// <typeparam name="T">Тип элементов.</typeparam>
	// Token: 0x02000A9D RID: 2717
	public interface IReadOnlyCollection<out T> : IEnumerable<!0>, IEnumerable
	{
		/// <summary>Возвращает количество элементов в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06006130 RID: 24880
		int Count { get; }
	}
}
