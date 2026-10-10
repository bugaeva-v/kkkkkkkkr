using System;

namespace System.Collections
{
	/// <summary>Предоставляет перечислитель, который поддерживает простой перебор элементов неуниверсальной коллекции.</summary>
	// Token: 0x02000A16 RID: 2582
	public interface IEnumerable
	{
		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который используется для прохода по коллекции.</returns>
		// Token: 0x06005B91 RID: 23441
		IEnumerator GetEnumerator();
	}
}
