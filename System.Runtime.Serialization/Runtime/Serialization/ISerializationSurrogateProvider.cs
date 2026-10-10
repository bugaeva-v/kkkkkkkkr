using System;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет методы, необходимые для создания суррогата сериализации, который расширяет <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. Суррогат сериализации используется во время сериализации и десериализации для замены одного типа другим.</summary>
	// Token: 0x020000A9 RID: 169
	public interface ISerializationSurrogateProvider
	{
		/// <summary>При выполнении сериализации, десериализации, а также импорта и экспорта схемы возвращает тип контракта данных, заменяющий указанный тип.</summary>
		/// <param name="type">Заменяемый тип.</param>
		/// <returns>Тип <see cref="T:System.Type" />, заменяемый значением <paramref name="type" />.</returns>
		// Token: 0x06000905 RID: 2309
		Type GetSurrogateType(Type type);

		/// <summary>При выполнении сериализации возвращает объект, заменяющий указанный объект.</summary>
		/// <param name="obj">Заменяемый объект.</param>
		/// <param name="targetType">Тип <see cref="T:System.Type" />, который назначается замененному объекту.</param>
		/// <returns>Замененный объект, который будет сериализован.</returns>
		// Token: 0x06000906 RID: 2310
		object GetObjectToSerialize(object obj, Type targetType);

		/// <summary>При выполнении десериализации возвращает объект, являющийся заменой указанного объекта.</summary>
		/// <param name="obj">Заменяемый десериализованный объект.</param>
		/// <param name="targetType">Тип <see cref="T:System.Type" />, который назначается замененному объекту.</param>
		/// <returns>Замененный десериализованный объект.</returns>
		// Token: 0x06000907 RID: 2311
		object GetDeserializedObject(object obj, Type targetType);
	}
}
