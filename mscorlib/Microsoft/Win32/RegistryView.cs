using System;

namespace Microsoft.Win32
{
	/// <summary>Задает представление реестра, которое должны быть целевым в 64-разрядных операционных системах.</summary>
	// Token: 0x020000A9 RID: 169
	public enum RegistryView
	{
		/// <summary>Представление по умолчанию.</summary>
		// Token: 0x04000F7E RID: 3966
		Default,
		/// <summary>64-разрядное представление.</summary>
		// Token: 0x04000F7F RID: 3967
		Registry64 = 256,
		/// <summary>32-разрядное представление.</summary>
		// Token: 0x04000F80 RID: 3968
		Registry32 = 512
	}
}
