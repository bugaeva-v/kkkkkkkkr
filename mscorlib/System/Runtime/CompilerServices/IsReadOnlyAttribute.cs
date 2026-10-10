using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Отмечает элемент программы как предназначенный только для чтения.</summary>
	// Token: 0x020007FD RID: 2045
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	public sealed class IsReadOnlyAttribute : Attribute
	{
	}
}
