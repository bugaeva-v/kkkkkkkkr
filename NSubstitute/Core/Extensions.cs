using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x02000079 RID: 121
	internal static class Extensions
	{
		// Token: 0x060001CA RID: 458 RVA: 0x000065B4 File Offset: 0x000047B4
		public static bool IsCompatibleWith([Nullable(2)] this object instance, Type type)
		{
			Type type2 = type.IsByRef ? type.GetElementType() : type;
			if (instance != null)
			{
				return type2.IsInstanceOfType(instance);
			}
			return Extensions.TypeCanBeNull(type2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000065E4 File Offset: 0x000047E4
		public static string Join(this IEnumerable<string> strings, string separator)
		{
			return string.Join(separator, strings);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000065ED File Offset: 0x000047ED
		public static bool IsDelegate(this Type type)
		{
			return type.GetTypeInfo().IsSubclassOf(typeof(MulticastDelegate));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006604 File Offset: 0x00004804
		public static MethodInfo GetInvokeMethod(this Type type)
		{
			MethodInfo method = type.GetMethod("Invoke");
			if (method == null)
			{
				throw new SubstituteInternalException("Expected delegate type");
			}
			return method;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006620 File Offset: 0x00004820
		private static bool TypeCanBeNull(Type type)
		{
			return !type.GetTypeInfo().IsValueType || Nullable.GetUnderlyingType(type) != null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006640 File Offset: 0x00004840
		public static string GetNonMangledTypeName(this Type type)
		{
			if (!type.GetTypeInfo().IsGenericType && !type.IsNested)
			{
				return type.Name;
			}
			Extensions.<>c__DisplayClass5_0 CS$<>8__locals1;
			CS$<>8__locals1.genericTypeArguments = type.GetGenericArguments();
			CS$<>8__locals1.alreadyHandledGenericArgumentsCount = 0;
			CS$<>8__locals1.resultTypeName = new StringBuilder();
			Extensions.<GetNonMangledTypeName>g__AppendTypeNameRecursively|5_0(type, ref CS$<>8__locals1);
			return CS$<>8__locals1.resultTypeName.ToString();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000066A0 File Offset: 0x000048A0
		public static T[] AsArray<T>(this IEnumerable<T> sequence)
		{
			T[] array = sequence as T[];
			if (array == null)
			{
				return sequence.ToArray<T>();
			}
			return array;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000066C0 File Offset: 0x000048C0
		[CompilerGenerated]
		internal static void <GetNonMangledTypeName>g__AppendTypeNameRecursively|5_0(Type currentType, ref Extensions.<>c__DisplayClass5_0 A_1)
		{
			Type declaringType = currentType.DeclaringType;
			if (declaringType != null)
			{
				Extensions.<GetNonMangledTypeName>g__AppendTypeNameRecursively|5_0(declaringType, ref A_1);
				A_1.resultTypeName.Append('+');
			}
			A_1.resultTypeName.Append(Extensions.<GetNonMangledTypeName>g__GetTypeNameWithoutGenericArity|5_1(currentType));
			string[] array = (from t in A_1.genericTypeArguments.Take(currentType.GetGenericArguments().Length).Skip(A_1.alreadyHandledGenericArgumentsCount)
			select t.GetNonMangledTypeName()).ToArray<string>();
			if (array.Length == 0)
			{
				return;
			}
			A_1.alreadyHandledGenericArgumentsCount += array.Length;
			A_1.resultTypeName.Append('<');
			A_1.resultTypeName.Append(array.Join(", "));
			A_1.resultTypeName.Append('>');
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006794 File Offset: 0x00004994
		[CompilerGenerated]
		internal static string <GetNonMangledTypeName>g__GetTypeNameWithoutGenericArity|5_1(Type type)
		{
			string name = type.Name;
			int num = name.IndexOf('`');
			if (num <= -1)
			{
				return name;
			}
			return name.Substring(0, num);
		}
	}
}
