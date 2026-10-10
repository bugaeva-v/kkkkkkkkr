using System;

namespace System.Configuration
{
	/// <summary>Задает параметры, применяемые к свойству.</summary>
	// Token: 0x0200002C RID: 44
	[Flags]
	public enum ConfigurationPropertyOptions
	{
		/// <summary>Указывает, что к свойству не применяются параметры.</summary>
		// Token: 0x040000AC RID: 172
		None = 0,
		/// <summary>Указывает, что свойство является коллекцией по умолчанию.</summary>
		// Token: 0x040000AD RID: 173
		IsDefaultCollection = 1,
		/// <summary>Указывает, что свойство является обязательным.</summary>
		// Token: 0x040000AE RID: 174
		IsRequired = 2,
		/// <summary>Указывает, что свойство является ключом коллекции.</summary>
		// Token: 0x040000AF RID: 175
		IsKey = 4,
		/// <summary>Указывает, требуется ли преобразование имени типа для свойства конфигурации при сериализации для более ранней версии .NET Framework.</summary>
		// Token: 0x040000B0 RID: 176
		IsTypeStringTransformationRequired = 8,
		/// <summary>Указывает, требуется ли преобразование имени сборки для свойства конфигурации при сериализации для более ранней версии .NET Framework.</summary>
		// Token: 0x040000B1 RID: 177
		IsAssemblyStringTransformationRequired = 16,
		/// <summary>Указывает, запрашивается ли во время сериализации родительский раздел конфигурации свойства конфигурации, чтобы определить, нужно ли выполнять сериализацию свойства конфигурации в формат XML.</summary>
		// Token: 0x040000B2 RID: 178
		IsVersionCheckRequired = 32
	}
}
