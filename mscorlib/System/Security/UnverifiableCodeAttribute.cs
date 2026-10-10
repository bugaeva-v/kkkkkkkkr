using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Помечает модули, содержащие непроверяемый код. Этот класс не наследуется.</summary>
	// Token: 0x020003CF RID: 975
	[AttributeUsage(AttributeTargets.Module, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	public sealed class UnverifiableCodeAttribute : Attribute
	{
	}
}
