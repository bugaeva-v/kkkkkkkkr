using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к методу указывает, что метод вызывается после десериализации объекта в графе объекта. Порядок сериализации относительно других объектов в графе является недетерминированным.</summary>
	// Token: 0x0200066E RID: 1646
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class OnSerializedAttribute : Attribute
	{
	}
}
