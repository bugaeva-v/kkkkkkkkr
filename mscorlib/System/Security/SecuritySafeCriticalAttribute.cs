using System;

namespace System.Security
{
	/// <summary>Определяет типы или члены как критически важные для безопасности и безопасно доступные для прозрачного кода.</summary>
	// Token: 0x020003D5 RID: 981
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class SecuritySafeCriticalAttribute : Attribute
	{
	}
}
