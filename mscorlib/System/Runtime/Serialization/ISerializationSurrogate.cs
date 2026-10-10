using System;

namespace System.Runtime.Serialization
{
	/// <summary>Реализует селектор суррогата сериализации, который позволяет одному объекту выполнять сериализацию и десериализацию другого.</summary>
	// Token: 0x02000652 RID: 1618
	public interface ISerializationSurrogate
	{
		/// <summary>Заполняет предоставленный <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации объекта.</summary>
		/// <param name="obj">Объект для сериализации.</param>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003C9A RID: 15514
		void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

		/// <summary>Заполняет объект с помощью сведений в <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="obj">Объект для заполнения.</param>
		/// <param name="info">Сведения для заполнения объекта.</param>
		/// <param name="context">Источник, из которого десериализуется объект.</param>
		/// <param name="selector">Суррогатный селектор, в котором начинается поиск совместимого знака-заместителя.</param>
		/// <returns>Заполняет десериализованный объект.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003C9B RID: 15515
		object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
	}
}
