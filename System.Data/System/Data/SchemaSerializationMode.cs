using System;

namespace System.Data
{
	/// <summary>Указывает режим схемы сериализации для типизированного объекта <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000123 RID: 291
	public enum SchemaSerializationMode
	{
		/// <summary>Включает схему сериализации для типизированного объекта <see cref="T:System.Data.DataSet" />. По умолчанию.</summary>
		// Token: 0x040009E2 RID: 2530
		IncludeSchema = 1,
		/// <summary>Пропускает схему сериализации для типизированного объекта <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x040009E3 RID: 2531
		ExcludeSchema
	}
}
