using System;

namespace System
{
	/// <summary>Указывает, что значение статического поля уникально для каждого потока.</summary>
	// Token: 0x02000191 RID: 401
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[Serializable]
	public class ThreadStaticAttribute : Attribute
	{
	}
}
