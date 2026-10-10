using System;

namespace System.Collections.Generic
{
	/// <summary>Предоставляет перечислитель, который поддерживает простой перебор элементов в указанной коллекции.</summary>
	/// <typeparam name="T">Тип объектов для перечисления.</typeparam>
	// Token: 0x02000A99 RID: 2713
	public interface IEnumerable<out T> : IEnumerable
	{
		/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
		/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
		// Token: 0x06006127 RID: 24871
		IEnumerator<T> GetEnumerator();
	}
}
