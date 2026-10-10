using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, что экспорты данного типа не будут включены в объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" />.</summary>
	// Token: 0x02000052 RID: 82
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class PartNotDiscoverableAttribute : Attribute
	{
	}
}
