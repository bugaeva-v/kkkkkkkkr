using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Определяет метод, который не создает событие.</summary>
	// Token: 0x020009FD RID: 2557
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class NonEventAttribute : Attribute
	{
	}
}
