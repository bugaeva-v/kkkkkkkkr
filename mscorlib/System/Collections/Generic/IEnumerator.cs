using System;

namespace System.Collections.Generic
{
	/// <summary>Поддерживает простой перебор элементов универсальной коллекции.</summary>
	/// <typeparam name="T">Тип объектов для перечисления.</typeparam>
	// Token: 0x02000A9A RID: 2714
	public interface IEnumerator<out T> : IDisposable, IEnumerator
	{
		/// <summary>Возвращает элемент коллекции, соответствующий текущей позиции перечислителя.</summary>
		/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06006128 RID: 24872
		T Current { get; }
	}
}
