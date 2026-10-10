using System;

namespace System.Security
{
	/// <summary>Указывает набор правил безопасности, которые применяются средой CLR к сборке.</summary>
	// Token: 0x020003D7 RID: 983
	public enum SecurityRuleSet : byte
	{
		/// <summary>Не поддерживается. При использовании этого значения выдается исключение <see cref="T:System.IO.FileLoadException" />.</summary>
		// Token: 0x04001EA3 RID: 7843
		None,
		/// <summary>Указывает, что средой выполнения применяются правила прозрачности 1 уровня (платформа .NET Framework версии 2.0).</summary>
		// Token: 0x04001EA4 RID: 7844
		Level1,
		/// <summary>Указывает, что средой выполнения применяются правила прозрачности уровня 2.</summary>
		// Token: 0x04001EA5 RID: 7845
		Level2
	}
}
