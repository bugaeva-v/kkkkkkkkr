using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x020000AF RID: 175
	public static class ReflectionExtensions
	{
		// Token: 0x060002AD RID: 685 RVA: 0x000071FC File Offset: 0x000053FC
		[return: Nullable(2)]
		public static PropertyInfo GetPropertyFromSetterCallOrNull(this MethodInfo call)
		{
			if (!ReflectionExtensions.CanBePropertySetterCall(call))
			{
				return null;
			}
			foreach (PropertyInfo propertyInfo in ReflectionExtensions.GetAllProperties(call.DeclaringType))
			{
				if (propertyInfo.GetSetMethod(true) == call)
				{
					return propertyInfo;
				}
			}
			return null;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00007244 File Offset: 0x00005444
		[return: Nullable(2)]
		public static PropertyInfo GetPropertyFromGetterCallOrNull(this MethodInfo call)
		{
			return ReflectionExtensions.GetAllProperties(call.DeclaringType).FirstOrDefault((PropertyInfo x) => x.GetGetMethod(true) == call);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000727F File Offset: 0x0000547F
		public static bool IsParams(this ParameterInfo parameterInfo)
		{
			return parameterInfo.IsDefined(typeof(ParamArrayAttribute), false);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00007292 File Offset: 0x00005492
		private static bool CanBePropertySetterCall(MethodInfo call)
		{
			return call.Name.StartsWith("set_", StringComparison.Ordinal);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000072A5 File Offset: 0x000054A5
		private static PropertyInfo[] GetAllProperties([Nullable(2)] Type type)
		{
			if (!(type != null))
			{
				return new PropertyInfo[0];
			}
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}
}
