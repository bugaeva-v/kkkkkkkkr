using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Помечает метод как односторонний без возвращаемого значения и параметров <see langword="out" /> или <see langword="ref" />.</summary>
	// Token: 0x02000631 RID: 1585
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method)]
	public class OneWayAttribute : Attribute
	{
	}
}
