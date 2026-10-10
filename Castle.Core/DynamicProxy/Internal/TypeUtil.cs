using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Internal
{
	// Token: 0x0200002C RID: 44
	public static class TypeUtil
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00005A3B File Offset: 0x00003C3B
		public static bool IsNullableType(this Type type)
		{
			return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005A64 File Offset: 0x00003C64
		public static FieldInfo[] GetAllFields(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.GetTypeInfo().IsClass)
			{
				throw new ArgumentException(string.Format("Type {0} is not a class type. This method supports only classes", type));
			}
			List<FieldInfo> list = new List<FieldInfo>();
			Type type2 = type;
			while (type2 != typeof(object))
			{
				FieldInfo[] fields = type2.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				list.AddRange(fields);
				type2 = type2.GetTypeInfo().BaseType;
			}
			return list.ToArray();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public static Type[] GetAllInterfaces(params Type[] types)
		{
			if (types == null)
			{
				return Type.EmptyTypes;
			}
			HashSet<Type> hashSet = new HashSet<Type>();
			foreach (Type type in types)
			{
				if (!(type == null) && (!type.GetTypeInfo().IsInterface || hashSet.Add(type)))
				{
					foreach (Type item in type.GetInterfaces())
					{
						hashSet.Add(item);
					}
				}
			}
			return TypeUtil.Sort(hashSet);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005B5F File Offset: 0x00003D5F
		public static Type[] GetAllInterfaces(this Type type)
		{
			return TypeUtil.GetAllInterfaces(new Type[]
			{
				type
			});
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005B70 File Offset: 0x00003D70
		public static Type GetClosedParameterType(this AbstractTypeEmitter type, Type parameter)
		{
			if (parameter.GetTypeInfo().IsGenericTypeDefinition)
			{
				return parameter.GetGenericTypeDefinition().MakeGenericType(type.GetGenericArgumentsFor(parameter));
			}
			if (parameter.GetTypeInfo().IsGenericType)
			{
				Type[] genericArguments = parameter.GetGenericArguments();
				if (TypeUtil.CloseGenericParametersIfAny(type, genericArguments))
				{
					return parameter.GetGenericTypeDefinition().MakeGenericType(genericArguments);
				}
			}
			if (parameter.GetTypeInfo().IsGenericParameter)
			{
				return type.GetGenericArgument(parameter.Name);
			}
			if (parameter.GetTypeInfo().IsArray)
			{
				Type closedParameterType = type.GetClosedParameterType(parameter.GetElementType());
				int arrayRank = parameter.GetArrayRank();
				if (arrayRank != 1)
				{
					return closedParameterType.MakeArrayType(arrayRank);
				}
				return closedParameterType.MakeArrayType();
			}
			else
			{
				if (parameter.GetTypeInfo().IsByRef)
				{
					return type.GetClosedParameterType(parameter.GetElementType()).MakeByRefType();
				}
				return parameter;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005C35 File Offset: 0x00003E35
		public static Type GetTypeOrNull(object target)
		{
			if (target == null)
			{
				return null;
			}
			return target.GetType();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005C44 File Offset: 0x00003E44
		public static Type[] AsTypeArray(this GenericTypeParameterBuilder[] typeInfos)
		{
			Type[] array = new Type[typeInfos.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = typeInfos[i].AsType();
			}
			return array;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005C74 File Offset: 0x00003E74
		public static bool IsFinalizer(this MethodInfo methodInfo)
		{
			return string.Equals("Finalize", methodInfo.Name) && methodInfo.GetBaseDefinition().DeclaringType == typeof(object);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public static bool IsGetType(this MethodInfo methodInfo)
		{
			return methodInfo.DeclaringType == typeof(object) && string.Equals("GetType", methodInfo.Name, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public static bool IsMemberwiseClone(this MethodInfo methodInfo)
		{
			return methodInfo.DeclaringType == typeof(object) && string.Equals("MemberwiseClone", methodInfo.Name, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005CFC File Offset: 0x00003EFC
		public static void SetStaticField(this Type type, string fieldName, BindingFlags additionalFlags, object value)
		{
			BindingFlags bindingAttr = additionalFlags | BindingFlags.Static;
			FieldInfo field = type.GetField(fieldName, bindingAttr);
			if (field == null)
			{
				throw new ProxyGenerationException(string.Format("Could not find field named '{0}' on type {1}. This is likely a bug in DynamicProxy. Please report it.", fieldName, type));
			}
			try
			{
				field.SetValue(null, value);
			}
			catch (MissingFieldException innerException)
			{
				throw new ProxyGenerationException(string.Format("Could not find field named '{0}' on type {1}. This is likely a bug in DynamicProxy. Please report it.", fieldName, type), innerException);
			}
			catch (TargetException innerException2)
			{
				throw new ProxyGenerationException(string.Format("There was an error trying to set field named '{0}' on type {1}. This is likely a bug in DynamicProxy. Please report it.", fieldName, type), innerException2);
			}
			catch (TargetInvocationException ex)
			{
				if (!(ex.InnerException is TypeInitializationException))
				{
					throw;
				}
				throw new ProxyGenerationException(string.Format("There was an error in static constructor on type {0}. This is likely a bug in DynamicProxy. Please report it.", type), ex);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public static MemberInfo[] Sort(MemberInfo[] members)
		{
			MemberInfo[] array = new MemberInfo[members.Length];
			Array.Copy(members, array, members.Length);
			Array.Sort<MemberInfo>(array, (MemberInfo l, MemberInfo r) => string.Compare(l.Name, r.Name, StringComparison.OrdinalIgnoreCase));
			return array;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005DFA File Offset: 0x00003FFA
		internal static bool IsDelegateType(this Type type)
		{
			return type.GetTypeInfo().BaseType == typeof(MulticastDelegate);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005E18 File Offset: 0x00004018
		private static bool CloseGenericParametersIfAny(AbstractTypeEmitter emitter, Type[] arguments)
		{
			bool result = false;
			for (int i = 0; i < arguments.Length; i++)
			{
				Type closedParameterType = emitter.GetClosedParameterType(arguments[i]);
				if (closedParameterType != null && closedParameterType != arguments[i])
				{
					arguments[i] = closedParameterType;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005E58 File Offset: 0x00004058
		private static Type[] Sort(ICollection<Type> types)
		{
			Type[] array = new Type[types.Count];
			types.CopyTo(array, 0);
			Array.Sort<Type>(array, TypeUtil.TypeNameComparer.Instance);
			return array;
		}

		// Token: 0x020001C1 RID: 449
		private sealed class TypeNameComparer : IComparer<Type>
		{
			// Token: 0x06000DB1 RID: 3505 RVA: 0x00021048 File Offset: 0x0001F248
			public int Compare(Type x, Type y)
			{
				int num = string.CompareOrdinal(x.FullName, y.FullName);
				if (num == 0)
				{
					return string.CompareOrdinal(x.GetTypeInfo().Assembly.FullName, y.GetTypeInfo().Assembly.FullName);
				}
				return num;
			}

			// Token: 0x0400030B RID: 779
			public static readonly TypeUtil.TypeNameComparer Instance = new TypeUtil.TypeNameComparer();
		}
	}
}
