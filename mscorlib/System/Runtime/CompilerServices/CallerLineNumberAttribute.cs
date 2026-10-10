using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Позволяет получить номер строки в исходном файле, в которой вызывается метод.</summary>
	// Token: 0x020007E0 RID: 2016
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class CallerLineNumberAttribute : Attribute
	{
	}
}
