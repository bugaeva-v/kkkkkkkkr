using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что машинное перечисление не уточняется именем типа перечисления. Этот класс не наследуется.</summary>
	// Token: 0x02000848 RID: 2120
	[AttributeUsage(AttributeTargets.Enum)]
	[Serializable]
	public sealed class ScopelessEnumAttribute : Attribute
	{
	}
}
