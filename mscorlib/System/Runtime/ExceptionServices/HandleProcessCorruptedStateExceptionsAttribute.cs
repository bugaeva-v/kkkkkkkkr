using System;

namespace System.Runtime.ExceptionServices
{
	/// <summary>Позволяет управляемому коду обрабатывать исключения, указывающие на поврежденное состояние процесса.</summary>
	// Token: 0x020007D1 RID: 2001
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
	{
	}
}
