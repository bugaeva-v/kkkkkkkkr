using System;

namespace System.Security.Cryptography
{
	/// <summary>Задает область защиты данных, которая устанавливается с помощью метода <see cref="M:System.Security.Cryptography.ProtectedData.Protect(System.Byte[],System.Byte[],System.Security.Cryptography.DataProtectionScope)" />.</summary>
	// Token: 0x02000010 RID: 16
	public enum DataProtectionScope
	{
		/// <summary>Защищенные данные связаны с текущим пользователем. Снимать защиту с данных могут только потоки, запускаемые от имени текущего пользователя.</summary>
		// Token: 0x04000086 RID: 134
		CurrentUser,
		/// <summary>Защищенные данные связаны с контекстом компьютера. Снимать защиту с данных могут все запускаемые на компьютере процессы. Это значение перечисления обычно используется в приложениях, которые запускаются на серверах, к которым не получают доступ пользователи без доверия.</summary>
		// Token: 0x04000087 RID: 135
		LocalMachine
	}
}
