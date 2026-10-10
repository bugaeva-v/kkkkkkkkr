using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Применяет к сборке метаданные, указывающие, что тип является неуправляемым.  Этот класс не наследуется.</summary>
	// Token: 0x02000846 RID: 2118
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Struct, Inherited = true)]
	[Serializable]
	public sealed class NativeCppClassAttribute : Attribute
	{
	}
}
