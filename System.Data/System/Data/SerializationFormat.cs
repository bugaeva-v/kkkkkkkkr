using System;

namespace System.Data
{
	/// <summary>Определяет формат сериализации для объекта <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x020000C9 RID: 201
	public enum SerializationFormat
	{
		/// <summary>Сериализация в качестве XML-содержимого. По умолчанию.</summary>
		// Token: 0x040007F9 RID: 2041
		Xml,
		/// <summary>Сериализация в качестве двоичного содержимого. Доступна только в ADO.NET 2.0.</summary>
		// Token: 0x040007FA RID: 2042
		Binary
	}
}
