using System;

namespace System.Net.Security
{
	/// <summary>Указывает службы безопасности, запрошенные для потока с проверкой подлинности.</summary>
	// Token: 0x02000858 RID: 2136
	public enum ProtectionLevel
	{
		/// <summary>Только проверка подлинности.</summary>
		// Token: 0x04002917 RID: 10519
		None,
		/// <summary>Подписывание данных для обеспечения целостности передаваемых данных.</summary>
		// Token: 0x04002918 RID: 10520
		Sign,
		/// <summary>Шифрование и подписывание данных для обеспечения конфиденциальности и целостности передаваемых данных.</summary>
		// Token: 0x04002919 RID: 10521
		EncryptAndSign
	}
}
