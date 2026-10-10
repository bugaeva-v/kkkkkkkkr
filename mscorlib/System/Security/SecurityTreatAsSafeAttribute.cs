using System;

namespace System.Security
{
	/// <summary>Определяет не являющиеся открытыми члены <see cref="T:System.Security.SecurityCriticalAttribute" />, доступные для прозрачного кода внутри сборки.</summary>
	// Token: 0x020003D4 RID: 980
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Obsolete("SecurityTreatAsSafe is only used for .NET 2.0 transparency compatibility.  Please use the SecuritySafeCriticalAttribute instead.")]
	public sealed class SecurityTreatAsSafeAttribute : Attribute
	{
	}
}
