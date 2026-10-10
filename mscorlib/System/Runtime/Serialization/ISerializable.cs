using System;

namespace System.Runtime.Serialization
{
	/// <summary>Позволяет объекту управлять его собственной сериализацией и десериализацией.</summary>
	// Token: 0x0200064A RID: 1610
	public interface ISerializable
	{
		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003C4E RID: 15438
		void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}
