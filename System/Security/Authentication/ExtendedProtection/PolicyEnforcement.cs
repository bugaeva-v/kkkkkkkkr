using System;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Перечисление <see cref="T:System.Security.Authentication.ExtendedProtection.PolicyEnforcement" /> указывает, когда следует применять <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</summary>
	// Token: 0x020002A8 RID: 680
	public enum PolicyEnforcement
	{
		/// <summary>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, никогда не используется, а расширенная защита отключена.</summary>
		// Token: 0x04000BFA RID: 3066
		Never,
		/// <summary>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" /> используется, только если клиент и сервер поддерживают расширенную защиту.</summary>
		// Token: 0x04000BFB RID: 3067
		WhenSupported,
		/// <summary>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" /> применяется всегда. Клиенты, не поддерживающие расширенную защиту, не смогут пройти проверку подлинности.</summary>
		// Token: 0x04000BFC RID: 3068
		Always
	}
}
