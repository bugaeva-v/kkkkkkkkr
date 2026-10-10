using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к методу указывает, что метод вызывается во время десериализации объекта в графе объекта. Порядок десериализации относительно других объектов в графе является недетерминированным.</summary>
	// Token: 0x0200066F RID: 1647
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnDeserializingAttribute : Attribute
	{
	}
}
