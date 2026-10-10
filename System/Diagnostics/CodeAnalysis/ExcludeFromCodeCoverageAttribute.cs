using System;

namespace System.Diagnostics.CodeAnalysis
{
	/// <summary>Указывает на то, что код с атрибутами следует исключить из данных о покрытии кода.</summary>
	// Token: 0x0200028C RID: 652
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
	public sealed class ExcludeFromCodeCoverageAttribute : Attribute
	{
	}
}
