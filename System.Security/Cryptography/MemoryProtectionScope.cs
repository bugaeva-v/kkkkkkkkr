using System;

namespace System.Security.Cryptography
{
	/// <summary>Задает область защиты памяти, которая устанавливается с помощью метода <see cref="M:System.Security.Cryptography.ProtectedMemory.Protect(System.Byte[],System.Security.Cryptography.MemoryProtectionScope)" />.</summary>
	// Token: 0x02000013 RID: 19
	public enum MemoryProtectionScope
	{
		/// <summary>Только код, выполняющийся в том же процессе, что и код, вызвавший метод <see cref="M:System.Security.Cryptography.ProtectedMemory.Protect(System.Byte[],System.Security.Cryptography.MemoryProtectionScope)" />, может снимать защиту с хранящихся в оперативной памяти данных.</summary>
		// Token: 0x0400008E RID: 142
		SameProcess,
		/// <summary>Любой код в любом процессе может снимать защиту с хранящихся в оперативной памяти данных, которые были защищены с помощью метода <see cref="M:System.Security.Cryptography.ProtectedMemory.Protect(System.Byte[],System.Security.Cryptography.MemoryProtectionScope)" />.</summary>
		// Token: 0x0400008F RID: 143
		CrossProcess,
		/// <summary>Только код, выполняющийся в том же контексте пользователя, что и код, вызвавший метод <see cref="M:System.Security.Cryptography.ProtectedMemory.Protect(System.Byte[],System.Security.Cryptography.MemoryProtectionScope)" />, может снимать защиту с хранящихся в оперативной памяти данных.</summary>
		// Token: 0x04000090 RID: 144
		SameLogon
	}
}
