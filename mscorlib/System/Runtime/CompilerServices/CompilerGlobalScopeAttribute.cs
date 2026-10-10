using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что класс следует интерпретировать как имеющий глобальную область.</summary>
	// Token: 0x020007E3 RID: 2019
	[AttributeUsage(AttributeTargets.Class)]
	[Serializable]
	public class CompilerGlobalScopeAttribute : Attribute
	{
	}
}
