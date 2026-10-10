using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что тип содержит неуправляемый массив, который может переполниться. Этот класс не наследуется.</summary>
	// Token: 0x0200080B RID: 2059
	[AttributeUsage(AttributeTargets.Struct)]
	[Serializable]
	public sealed class UnsafeValueTypeAttribute : Attribute
	{
	}
}
