using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к методу указывает, что метод вызывается сразу после десериализации объекта в графе объекта. Порядок десериализации относительно других объектов в графе является недетерминированным.</summary>
	// Token: 0x02000670 RID: 1648
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class OnDeserializedAttribute : Attribute
	{
	}
}
