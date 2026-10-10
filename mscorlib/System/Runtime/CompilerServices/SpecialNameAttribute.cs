using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что тип или член интерпретируется особым образом средой выполнения или инструментами.  Этот класс не наследуется.</summary>
	// Token: 0x02000804 RID: 2052
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class SpecialNameAttribute : Attribute
	{
	}
}
