using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Не рекомендуется. Замораживает строковый литерал при создании машинных образов с помощью программы Ngen.exe (средство создания машинных образов). Этот класс не наследуется.</summary>
	// Token: 0x02000806 RID: 2054
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	[Serializable]
	public sealed class StringFreezingAttribute : Attribute
	{
	}
}
