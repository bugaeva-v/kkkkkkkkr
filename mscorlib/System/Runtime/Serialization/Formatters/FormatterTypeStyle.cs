using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Указывает формат, в котором описания типов раскладываются в сериализованном потоке.</summary>
	// Token: 0x02000678 RID: 1656
	public enum FormatterTypeStyle
	{
		/// <summary>Указывает, что эти типы можно назначить для массивов объектов, членов объектов типа <see cref="T:System.Object" /> и неэлементарных типов значений <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary>
		// Token: 0x040027A6 RID: 10150
		TypesWhenNeeded,
		/// <summary>Указывает, что этот тип можно задавать для всех членов объектов и <see cref="T:System.Runtime.Serialization.ISerializable" /> членов объектов.</summary>
		// Token: 0x040027A7 RID: 10151
		TypesAlways,
		/// <summary>Указывает, что эти строки можно задавать в формате XSD вместо SOAP. Нет переданных строковых идентификаторов.</summary>
		// Token: 0x040027A8 RID: 10152
		XsdString
	}
}
