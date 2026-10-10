using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Разрешает доступ к именам и типам полей объектов, которые поддерживают интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary>
	// Token: 0x0200067B RID: 1659
	public interface IFieldInfo
	{
		/// <summary>Получает или задает имена полей сериализованных объектов.</summary>
		/// <returns>Имена полей сериализованных объектов.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003DC6 RID: 15814
		// (set) Token: 0x06003DC7 RID: 15815
		string[] FieldNames { get; set; }

		/// <summary>Получает или задает типы полей сериализованных объектов.</summary>
		/// <returns>Типы полей сериализованных объектов.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003DC8 RID: 15816
		// (set) Token: 0x06003DC9 RID: 15817
		Type[] FieldTypes { get; set; }
	}
}
