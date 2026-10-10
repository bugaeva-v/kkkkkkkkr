using System;

namespace Microsoft.Win32
{
	/// <summary>Задает параметры, которые необходимо использовать при создании раздела реестра.</summary>
	// Token: 0x020000A6 RID: 166
	[Flags]
	public enum RegistryOptions
	{
		/// <summary>Постоянный ключ. Это значение по умолчанию.</summary>
		// Token: 0x04000F6F RID: 3951
		None = 0,
		/// <summary>Временный ключ. Информация хранится в памяти и не сохраняется при выгрузке соответствующего куста реестра.</summary>
		// Token: 0x04000F70 RID: 3952
		Volatile = 1
	}
}
