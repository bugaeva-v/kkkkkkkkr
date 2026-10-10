using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Отдает отладчику указание о сквозной обработке кода (вместо обработки изнутри). Этот класс не наследуется.</summary>
	// Token: 0x020009B4 RID: 2484
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class DebuggerStepThroughAttribute : Attribute
	{
	}
}
