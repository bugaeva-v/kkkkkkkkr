using System;

namespace System.Security
{
	/// <summary>Задает область действия атрибута <see cref="T:System.Security.SecurityCriticalAttribute" />.</summary>
	// Token: 0x020003D2 RID: 978
	[Obsolete("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
	public enum SecurityCriticalScope
	{
		/// <summary>Действие атрибута распространяется только на явно указанный элемент.</summary>
		// Token: 0x04001E9F RID: 7839
		Explicit,
		/// <summary>Действие атрибута распространяется на весь код после него.</summary>
		// Token: 0x04001EA0 RID: 7840
		Everything
	}
}
