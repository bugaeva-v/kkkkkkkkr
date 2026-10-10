using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Указывает, что значение статического поля уникально для определенного контекста.</summary>
	// Token: 0x020001EF RID: 495
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public class ContextStaticAttribute : Attribute
	{
	}
}
