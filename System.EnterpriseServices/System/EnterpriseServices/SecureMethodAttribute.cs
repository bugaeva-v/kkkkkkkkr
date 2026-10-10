using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Гарантирует, что инфраструктура вызывается посредством интерфейса для метода или для каждого метода в классе, когда используется служба безопасности. Для использования служб безопасности классы должны использовать интерфейсы. Этот класс не наследуется.</summary>
	// Token: 0x02000041 RID: 65
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	[ComVisible(false)]
	public sealed class SecureMethodAttribute : Attribute
	{
	}
}
