using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, какой конструктор должен использоваться при создании части.</summary>
	// Token: 0x02000049 RID: 73
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
	public class ImportingConstructorAttribute : Attribute
	{
	}
}
