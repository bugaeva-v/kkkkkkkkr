using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, что свойства пользовательского атрибута предоставляют метаданные для экспортов, применяемых к тому же типу, свойству, полю или методу.</summary>
	// Token: 0x0200004B RID: 75
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class MetadataAttributeAttribute : Attribute
	{
	}
}
