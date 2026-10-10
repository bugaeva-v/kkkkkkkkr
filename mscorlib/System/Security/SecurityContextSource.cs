using System;

namespace System.Security
{
	/// <summary>Указывает источник контекста безопасности.</summary>
	// Token: 0x020003D9 RID: 985
	public enum SecurityContextSource
	{
		/// <summary>Источник контекста безопасности — текущий домен приложения.</summary>
		// Token: 0x04001EA9 RID: 7849
		CurrentAppDomain,
		/// <summary>Источник контекста безопасности — текущая сборка.</summary>
		// Token: 0x04001EAA RID: 7850
		CurrentAssembly
	}
}
