using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Запрещает программе Ildasm.exe (дизассемблер IL) дизассемблировать сборку. Этот класс не наследуется.</summary>
	// Token: 0x02000807 RID: 2055
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module)]
	public sealed class SuppressIldasmAttribute : Attribute
	{
	}
}
