using System;

namespace System
{
	/// <summary>Указывает на то, что потоковой моделью COM для приложения является многопотоковое подразделение (MTA).</summary>
	// Token: 0x02000190 RID: 400
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class MTAThreadAttribute : Attribute
	{
	}
}
