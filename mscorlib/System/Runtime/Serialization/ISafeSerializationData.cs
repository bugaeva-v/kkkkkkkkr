using System;

namespace System.Runtime.Serialization
{
	/// <summary>Включает сериализацию данных пользовательского исключения в прозрачный с точки зрения безопасности код.</summary>
	// Token: 0x0200066A RID: 1642
	public interface ISafeSerializationData
	{
		/// <summary>Этот метод вызывается при десериализации экземпляра.</summary>
		/// <param name="deserialized">Объект, который содержит состояние экземпляра.</param>
		// Token: 0x06003D59 RID: 15705
		void CompleteDeserialization(object deserialized);
	}
}
