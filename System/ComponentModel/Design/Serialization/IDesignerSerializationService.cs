using System;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет интерфейс для вызова процессов сериализации и десериализации.</summary>
	// Token: 0x0200048A RID: 1162
	public interface IDesignerSerializationService
	{
		/// <summary>Выполняет десериализацию указанного объекта данных сериализации и возвращает коллекцию объектов, представляемых этими данными.</summary>
		/// <param name="serializationData">Объект, состоящий из сериализованных данных.</param>
		/// <returns>Класс <see cref="T:System.Collections.ICollection" /> объектов, восстановленных из указанного объекта данных сериализации.</returns>
		// Token: 0x0600252E RID: 9518
		ICollection Deserialize(object serializationData);

		/// <summary>Выполняет сериализацию указанной коллекции объектов и сохраняет их в объекте данных сериализации.</summary>
		/// <param name="objects">Коллекция объектов, которые необходимо сериализовать.</param>
		/// <returns>Объект, содержащий сериализованное состояние указанной коллекции объектов.</returns>
		// Token: 0x0600252F RID: 9519
		object Serialize(ICollection objects);
	}
}
