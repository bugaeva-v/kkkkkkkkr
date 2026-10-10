using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Позволяет получить имя свойства или метода вызывающего метод объекта.</summary>
	// Token: 0x020007E1 RID: 2017
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class CallerMemberNameAttribute : Attribute
	{
	}
}
