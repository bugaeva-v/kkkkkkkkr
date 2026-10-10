using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что метод является методом расширения либо что класс или сборка содержат методы расширения.</summary>
	// Token: 0x020007F0 RID: 2032
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
	public sealed class ExtensionAttribute : Attribute
	{
	}
}
