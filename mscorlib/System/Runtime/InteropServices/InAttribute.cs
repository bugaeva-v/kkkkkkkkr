using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, что данные необходимо маршалировать из вызывающего в вызываемый объект и не возвращать вызывающему объекту.</summary>
	// Token: 0x02000701 RID: 1793
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	[ComVisible(true)]
	public sealed class InAttribute : Attribute
	{
		// Token: 0x06004093 RID: 16531 RVA: 0x000E11F1 File Offset: 0x000DF3F1
		internal static Attribute GetCustomAttribute(RuntimeParameterInfo parameter)
		{
			if (!parameter.IsIn)
			{
				return null;
			}
			return new InAttribute();
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x000E1202 File Offset: 0x000DF402
		internal static bool IsDefined(RuntimeParameterInfo parameter)
		{
			return parameter.IsIn;
		}
	}
}
