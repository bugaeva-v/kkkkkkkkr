using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Позволяет неуправляемому методу вызвать управляемый метод.</summary>
	// Token: 0x020006E4 RID: 1764
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class AllowReversePInvokeCallsAttribute : Attribute
	{
	}
}
