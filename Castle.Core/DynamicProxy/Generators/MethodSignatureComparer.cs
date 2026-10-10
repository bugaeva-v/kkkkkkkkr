using System;
using System.Collections.Generic;
using System.Reflection;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000048 RID: 72
	public class MethodSignatureComparer : IEqualityComparer<MethodInfo>
	{
		// Token: 0x06000238 RID: 568 RVA: 0x00009078 File Offset: 0x00007278
		public bool EqualGenericParameters(MethodInfo x, MethodInfo y)
		{
			if (x.IsGenericMethod != y.IsGenericMethod)
			{
				return false;
			}
			if (x.IsGenericMethod)
			{
				Type[] genericArguments = x.GetGenericArguments();
				Type[] genericArguments2 = y.GetGenericArguments();
				if (genericArguments.Length != genericArguments2.Length)
				{
					return false;
				}
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (genericArguments[i].GetTypeInfo().IsGenericParameter != genericArguments2[i].GetTypeInfo().IsGenericParameter)
					{
						return false;
					}
					if (!genericArguments[i].GetTypeInfo().IsGenericParameter && !genericArguments[i].Equals(genericArguments2[i]))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009100 File Offset: 0x00007300
		public bool EqualParameters(MethodInfo x, MethodInfo y)
		{
			ParameterInfo[] parameters = x.GetParameters();
			ParameterInfo[] parameters2 = y.GetParameters();
			if (parameters.Length != parameters2.Length)
			{
				return false;
			}
			for (int i = 0; i < parameters.Length; i++)
			{
				if (!this.EqualSignatureTypes(parameters[i].ParameterType, parameters2[i].ParameterType))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009150 File Offset: 0x00007350
		public bool EqualSignatureTypes(Type x, Type y)
		{
			TypeInfo typeInfo = x.GetTypeInfo();
			TypeInfo typeInfo2 = y.GetTypeInfo();
			if (typeInfo.IsGenericParameter != typeInfo2.IsGenericParameter)
			{
				return false;
			}
			if (typeInfo.IsGenericType != typeInfo2.IsGenericType)
			{
				return false;
			}
			if (typeInfo.IsGenericParameter)
			{
				if (typeInfo.GenericParameterPosition != typeInfo2.GenericParameterPosition)
				{
					return false;
				}
			}
			else if (typeInfo.IsGenericType)
			{
				Type genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
				Type genericTypeDefinition2 = typeInfo2.GetGenericTypeDefinition();
				if (genericTypeDefinition != genericTypeDefinition2)
				{
					return false;
				}
				Type[] genericArguments = x.GetGenericArguments();
				Type[] genericArguments2 = y.GetGenericArguments();
				if (genericArguments.Length != genericArguments2.Length)
				{
					return false;
				}
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (!this.EqualSignatureTypes(genericArguments[i], genericArguments2[i]))
					{
						return false;
					}
				}
			}
			else if (!x.Equals(y))
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009210 File Offset: 0x00007410
		public bool Equals(MethodInfo x, MethodInfo y)
		{
			return (x == null && y == null) || (!(x == null) && !(y == null) && (this.EqualNames(x, y) && this.EqualGenericParameters(x, y) && this.EqualSignatureTypes(x.ReturnType, y.ReturnType)) && this.EqualParameters(x, y));
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00009277 File Offset: 0x00007477
		public int GetHashCode(MethodInfo obj)
		{
			return obj.Name.GetHashCode() ^ obj.GetParameters().Length;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000928D File Offset: 0x0000748D
		private bool EqualNames(MethodInfo x, MethodInfo y)
		{
			return x.Name == y.Name;
		}

		// Token: 0x04000097 RID: 151
		public static readonly MethodSignatureComparer Instance = new MethodSignatureComparer();
	}
}
