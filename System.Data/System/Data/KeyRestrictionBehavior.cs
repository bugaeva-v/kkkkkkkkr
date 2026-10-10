using System;

namespace System.Data
{
	/// <summary>Определяет список параметров строки подключения, определяемых свойством <see langword="KeyRestrictions" />, которые могут быть разрешены или запрещены.</summary>
	// Token: 0x0200010B RID: 267
	public enum KeyRestrictionBehavior
	{
		/// <summary>По умолчанию. Определяет только разрешенные дополнительные параметры строки подключения.</summary>
		// Token: 0x04000975 RID: 2421
		AllowOnly,
		/// <summary>Определяет запрещенные дополнительные параметры строки подключения.</summary>
		// Token: 0x04000976 RID: 2422
		PreventUsage
	}
}
