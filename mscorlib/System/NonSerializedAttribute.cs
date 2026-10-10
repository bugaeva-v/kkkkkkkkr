using System;

namespace System
{
	/// <summary>Указывает, что поле сериализуемого класса не должно быть сериализовано. Этот класс не наследуется.</summary>
	// Token: 0x0200015E RID: 350
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class NonSerializedAttribute : Attribute
	{
	}
}
