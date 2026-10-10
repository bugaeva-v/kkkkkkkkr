using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	/// <summary>
	///         Представляет коллекцию объектов с общим ключом.
	///       </summary>
	/// <typeparam name="TKey">
	///           Тип ключа <see cref="T:System.Linq.IGrouping`2" />.
	///         </typeparam>
	/// <typeparam name="TElement">
	///           Тип значений в <see cref="T:System.Linq.IGrouping`2" />.
	///         </typeparam>
	// Token: 0x020000D0 RID: 208
	public interface IGrouping<out TKey, out TElement> : IEnumerable<!1>, IEnumerable
	{
		/// <summary>
		///         Возвращает ключ <see cref="T:System.Linq.IGrouping`2" />.
		///       </summary>
		/// <returns>
		///         Ключ <see cref="T:System.Linq.IGrouping`2" />.
		///       </returns>
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000777 RID: 1911
		TKey Key { get; }
	}
}
