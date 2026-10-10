using System;

namespace System.Runtime.Serialization
{
	/// <summary>Позволяет пользователям управлять загрузкой классов и выбирать класс для загрузки.</summary>
	// Token: 0x02000655 RID: 1621
	[Serializable]
	public abstract class SerializationBinder
	{
		/// <summary>При переопределении в производном классе управляет привязкой сериализованного объекта к типу.</summary>
		/// <param name="serializedType">Тип объекта, экземпляр которого создается модулем форматирования.</param>
		/// <param name="assemblyName">Указывает имя <see cref="T:System.Reflection.Assembly" /> сериализованного объекта.</param>
		/// <param name="typeName">Указывает имя <see cref="T:System.Type" /> сериализованного объекта.</param>
		// Token: 0x06003CA2 RID: 15522 RVA: 0x000D1AFF File Offset: 0x000CFCFF
		public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			assemblyName = null;
			typeName = null;
		}

		/// <summary>При переопределении в производном классе управляет привязкой сериализованного объекта к типу.</summary>
		/// <param name="assemblyName">Указывает имя <see cref="T:System.Reflection.Assembly" /> сериализованного объекта.</param>
		/// <param name="typeName">Указывает имя <see cref="T:System.Type" /> сериализованного объекта.</param>
		/// <returns>Тип объекта, экземпляр которого создается модулем форматирования.</returns>
		// Token: 0x06003CA3 RID: 15523
		public abstract Type BindToType(string assemblyName, string typeName);
	}
}
