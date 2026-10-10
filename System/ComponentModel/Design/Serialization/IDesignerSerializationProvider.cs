using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет интерфейс, позволяющий получать доступ к сериализатору.</summary>
	// Token: 0x02000489 RID: 1161
	public interface IDesignerSerializationProvider
	{
		/// <summary>Получает сериализатор с помощью указанных атрибутов.</summary>
		/// <param name="manager">Диспетчер сериализации, запрашивающий сериализатор.</param>
		/// <param name="currentSerializer">Экземпляр текущего сериализатора указанного типа. Может иметь значение <see langword="null" />, если сериализатор указанного типа не существует.</param>
		/// <param name="objectType">Тип данных объекта сериализации.</param>
		/// <param name="serializerType">Тип данных создаваемого сериализатора.</param>
		/// <returns>Экземпляр сериализатора запрошенного типа или значение <see langword="null" />, если не удалось выполнить запрос.</returns>
		// Token: 0x0600252D RID: 9517
		object GetSerializer(IDesignerSerializationManager manager, object currentSerializer, Type objectType, Type serializerType);
	}
}
