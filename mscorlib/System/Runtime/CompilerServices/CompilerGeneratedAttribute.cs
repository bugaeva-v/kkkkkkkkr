using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Отличает элемент, созданный компилятором, от элемента, созданного пользователем. Этот класс не наследуется.</summary>
	// Token: 0x020007E2 RID: 2018
	[AttributeUsage(AttributeTargets.All, Inherited = true)]
	[Serializable]
	public sealed class CompilerGeneratedAttribute : Attribute
	{
	}
}
