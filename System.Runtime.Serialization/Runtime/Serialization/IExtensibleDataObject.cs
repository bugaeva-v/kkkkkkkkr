using System;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет структуру данных для хранения дополнительных данных, обнаруженных <see cref="T:System.Runtime.Serialization.XmlObjectSerializer" /> при десериализации типа, отмеченного атрибутом <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</summary>
	// Token: 0x020000E7 RID: 231
	public interface IExtensibleDataObject
	{
		/// <summary>Возвращает или задает структуру, содержащую дополнительные данные.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.ExtensionDataObject" />, содержащий данные, которые не были распознаны как принадлежащие к контракту данных.</returns>
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D3F RID: 3391
		// (set) Token: 0x06000D40 RID: 3392
		ExtensionDataObject ExtensionData { get; set; }
	}
}
