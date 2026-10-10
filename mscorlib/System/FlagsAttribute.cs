using System;

namespace System
{
	/// <summary>Указывает, что перечисление может обрабатываться как битовое поле (т. е. набор флагов).</summary>
	// Token: 0x0200011A RID: 282
	[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
	[Serializable]
	public class FlagsAttribute : Attribute
	{
	}
}
