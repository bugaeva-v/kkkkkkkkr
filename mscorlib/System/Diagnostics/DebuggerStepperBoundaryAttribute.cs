using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Указывает код, следующий за атрибутом, который должен выполняться в режиме выполнения, а не в пошаговом режиме.</summary>
	// Token: 0x020009B5 RID: 2485
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class DebuggerStepperBoundaryAttribute : Attribute
	{
	}
}
