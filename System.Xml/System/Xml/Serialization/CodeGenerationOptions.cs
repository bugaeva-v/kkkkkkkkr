using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Определяет различные параметры, которые применяются при создании типов платформы .NET Framework, используемых с веб-службой XML.
	///       </summary>
	// Token: 0x02000267 RID: 615
	[Flags]
	public enum CodeGenerationOptions
	{
		/// <summary>
		///         Представляет простые типы по полям и по типам пространств имен <see cref="N:System" />.
		///       </summary>
		// Token: 0x04001843 RID: 6211
		[XmlIgnore]
		None = 0,
		/// <summary>
		///         Представление простых типов по свойствам.
		///       </summary>
		// Token: 0x04001844 RID: 6212
		[XmlEnum("properties")]
		GenerateProperties = 1,
		/// <summary>
		///         Создание событий для асинхронного вызова веб-методов.
		///       </summary>
		// Token: 0x04001845 RID: 6213
		[XmlEnum("newAsync")]
		GenerateNewAsync = 2,
		/// <summary>
		///         Создание методов Begin и End для асинхронного вызова веб-методов.
		///       </summary>
		// Token: 0x04001846 RID: 6214
		[XmlEnum("oldAsync")]
		GenerateOldAsync = 4,
		/// <summary>
		///         Создает код сериализации в явно заданном порядке в соответствии со свойством <see langword="Order" /> атрибутов <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />, <see cref="T:System.Xml.Serialization.XmlArrayAttribute" /> и <see cref="T:System.Xml.Serialization.XmlElementAttribute" />.
		///       </summary>
		// Token: 0x04001847 RID: 6215
		[XmlEnum("order")]
		GenerateOrder = 8,
		/// <summary>
		///         Включение привязки данных.
		///       </summary>
		// Token: 0x04001848 RID: 6216
		[XmlEnum("enableDataBinding")]
		EnableDataBinding = 16
	}
}
