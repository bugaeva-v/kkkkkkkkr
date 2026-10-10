using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Фиксирует адрес поля со статическим типом значения в течение времени его существования. Этот класс не наследуется.</summary>
	// Token: 0x020007F1 RID: 2033
	[AttributeUsage(AttributeTargets.Field)]
	[Serializable]
	public sealed class FixedAddressValueTypeAttribute : Attribute
	{
	}
}
