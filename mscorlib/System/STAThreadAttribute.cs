using System;

namespace System
{
	/// <summary>Указывает, что потоковой моделью COM для приложения является однопотоковое подразделение (STA).</summary>
	// Token: 0x0200018F RID: 399
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class STAThreadAttribute : Attribute
	{
	}
}
