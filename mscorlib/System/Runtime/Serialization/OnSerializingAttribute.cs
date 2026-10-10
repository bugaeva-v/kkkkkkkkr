using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к методу указывает, что метод вызывается во время сериализации объекта в графе объекта. Порядок сериализации относительно других объектов в графе является недетерминированным.</summary>
	// Token: 0x0200066D RID: 1645
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnSerializingAttribute : Attribute
	{
	}
}
