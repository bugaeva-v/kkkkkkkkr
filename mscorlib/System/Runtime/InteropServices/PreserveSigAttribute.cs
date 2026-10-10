using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает, что преобразование значения HRESULT или сигнатуры <see langword="retval" />, происходящее в процессе вызовов COM-взаимодействия, следует запретить.</summary>
	// Token: 0x02000700 RID: 1792
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class PreserveSigAttribute : Attribute
	{
		// Token: 0x06004090 RID: 16528 RVA: 0x000E11C9 File Offset: 0x000DF3C9
		internal static Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
			if ((method.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) == MethodImplAttributes.IL)
			{
				return null;
			}
			return new PreserveSigAttribute();
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000E11E0 File Offset: 0x000DF3E0
		internal static bool IsDefined(RuntimeMethodInfo method)
		{
			return (method.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) > MethodImplAttributes.IL;
		}
	}
}
