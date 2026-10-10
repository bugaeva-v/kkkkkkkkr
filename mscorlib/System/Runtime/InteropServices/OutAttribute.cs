using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, что данные необходимо маршалировать из вызываемого объекта обратно в вызывающий объект.</summary>
	// Token: 0x02000702 RID: 1794
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	[ComVisible(true)]
	public sealed class OutAttribute : Attribute
	{
		// Token: 0x06004096 RID: 16534 RVA: 0x000E120A File Offset: 0x000DF40A
		internal static Attribute GetCustomAttribute(RuntimeParameterInfo parameter)
		{
			if (!parameter.IsOut)
			{
				return null;
			}
			return new OutAttribute();
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x000E121B File Offset: 0x000DF41B
		internal static bool IsDefined(RuntimeParameterInfo parameter)
		{
			return parameter.IsOut;
		}
	}
}
