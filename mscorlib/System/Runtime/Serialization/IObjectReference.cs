using System;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает, что конструктор текущего интерфейса является ссылкой на другой объект.</summary>
	// Token: 0x02000649 RID: 1609
	public interface IObjectReference
	{
		/// <summary>Возвращает реальный объект, который необходимо десериализовать, вместо объекта, задаваемого сериализованным потоком.</summary>
		/// <param name="context">
		///   <see cref="T:System.Runtime.Serialization.StreamingContext" />, из которого десериализуется текущий объект.</param>
		/// <returns>Реальный объект, который помещается в граф.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение. Вызов не будет работать на сервере со средним уровнем доверия.</exception>
		// Token: 0x06003C4D RID: 15437
		object GetRealObject(StreamingContext context);
	}
}
