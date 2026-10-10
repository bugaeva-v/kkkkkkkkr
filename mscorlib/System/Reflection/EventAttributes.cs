using System;

namespace System.Reflection
{
	/// <summary>Задает атрибуты события.</summary>
	// Token: 0x02000898 RID: 2200
	[Flags]
	public enum EventAttributes
	{
		/// <summary>Указывает, что у события отсутствуют атрибуты.</summary>
		// Token: 0x04002E87 RID: 11911
		None = 0,
		/// <summary>Определяет, что событие является специальным, что описано его именем.</summary>
		// Token: 0x04002E88 RID: 11912
		SpecialName = 512,
		/// <summary>Определяет, что общеязыковая среда выполнения должна проверять кодировку имени.</summary>
		// Token: 0x04002E89 RID: 11913
		RTSpecialName = 1024,
		/// <summary>Определяет зарезервированный флаг, предназначенный только для использования общеязыковой средой выполнения.</summary>
		// Token: 0x04002E8A RID: 11914
		ReservedMask = 1024
	}
}
