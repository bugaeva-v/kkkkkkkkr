using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Позволяет управляемому коду вызывать неуправляемый код без обхода стека. Этот класс не наследуется.</summary>
	// Token: 0x020003CE RID: 974
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	public sealed class SuppressUnmanagedCodeSecurityAttribute : Attribute
	{
	}
}
