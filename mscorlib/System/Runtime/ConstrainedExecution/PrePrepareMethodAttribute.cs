using System;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Указывает службе генерирования машинных образов подготовить метод для включения в область с ограниченным исполнением (CER).</summary>
	// Token: 0x020007D6 RID: 2006
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	public sealed class PrePrepareMethodAttribute : Attribute
	{
	}
}
