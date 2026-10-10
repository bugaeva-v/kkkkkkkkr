using System;

namespace System
{
	/// <summary>Указывает, что класс может быть сериализован. Этот класс не наследуется.</summary>
	// Token: 0x0200017B RID: 379
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
	public sealed class SerializableAttribute : Attribute
	{
	}
}
