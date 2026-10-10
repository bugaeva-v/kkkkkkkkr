using System;

namespace System.Collections
{
	/// <summary>Предоставляет хеш-код объекта, используя пользовательскую хеш-функцию.</summary>
	// Token: 0x02000A4F RID: 2639
	[Obsolete("Please use IEqualityComparer instead.")]
	public interface IHashCodeProvider
	{
		/// <summary>Возвращает хэш-код указанного объекта.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, для которого необходимо вернуть хэш-код.</param>
		/// <returns>Хэш-код указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Тип <paramref name="obj" /> является ссылочным типом и <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06005EAB RID: 24235
		int GetHashCode(object obj);
	}
}
