using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000054 RID: 84
	internal class GenericUtil
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x0000A695 File Offset: 0x00008895
		public static GenericTypeParameterBuilder[] CopyGenericArguments(MethodInfo methodToCopyGenericsFrom, TypeBuilder builder, Dictionary<string, GenericTypeParameterBuilder> name2GenericType)
		{
			return GenericUtil.CopyGenericArguments(methodToCopyGenericsFrom, name2GenericType, new ApplyGenArgs(builder.DefineGenericParameters));
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000A6AA File Offset: 0x000088AA
		public static GenericTypeParameterBuilder[] CopyGenericArguments(MethodInfo methodToCopyGenericsFrom, MethodBuilder builder, Dictionary<string, GenericTypeParameterBuilder> name2GenericType)
		{
			return GenericUtil.CopyGenericArguments(methodToCopyGenericsFrom, name2GenericType, new ApplyGenArgs(builder.DefineGenericParameters));
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public static Type ExtractCorrectType(Type paramType, Dictionary<string, GenericTypeParameterBuilder> name2GenericType)
		{
			if (paramType.GetTypeInfo().IsArray)
			{
				int arrayRank = paramType.GetArrayRank();
				Type elementType = paramType.GetElementType();
				if (elementType.GetTypeInfo().IsGenericParameter)
				{
					GenericTypeParameterBuilder genericTypeParameterBuilder;
					if (!name2GenericType.TryGetValue(elementType.Name, out genericTypeParameterBuilder))
					{
						return paramType;
					}
					if (arrayRank == 1)
					{
						return genericTypeParameterBuilder.MakeArrayType();
					}
					return genericTypeParameterBuilder.MakeArrayType(arrayRank);
				}
				else
				{
					if (arrayRank == 1)
					{
						return elementType.MakeArrayType();
					}
					return elementType.MakeArrayType(arrayRank);
				}
			}
			else
			{
				GenericTypeParameterBuilder genericTypeParameterBuilder2;
				if (paramType.GetTypeInfo().IsGenericParameter && name2GenericType.TryGetValue(paramType.Name, out genericTypeParameterBuilder2))
				{
					return genericTypeParameterBuilder2.AsType();
				}
				return paramType;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000A754 File Offset: 0x00008954
		public static Type[] ExtractParametersTypes(ParameterInfo[] baseMethodParameters, Dictionary<string, GenericTypeParameterBuilder> name2GenericType)
		{
			Type[] array = new Type[baseMethodParameters.Length];
			for (int i = 0; i < baseMethodParameters.Length; i++)
			{
				Type parameterType = baseMethodParameters[i].ParameterType;
				array[i] = GenericUtil.ExtractCorrectType(parameterType, name2GenericType);
			}
			return array;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000A78C File Offset: 0x0000898C
		public static Dictionary<string, GenericTypeParameterBuilder> GetGenericArgumentsMap(AbstractTypeEmitter parentEmitter)
		{
			if (parentEmitter.GenericTypeParams == null || parentEmitter.GenericTypeParams.Length == 0)
			{
				return new Dictionary<string, GenericTypeParameterBuilder>(0);
			}
			Dictionary<string, GenericTypeParameterBuilder> dictionary = new Dictionary<string, GenericTypeParameterBuilder>(parentEmitter.GenericTypeParams.Length);
			foreach (GenericTypeParameterBuilder genericTypeParameterBuilder in parentEmitter.GenericTypeParams)
			{
				dictionary.Add(genericTypeParameterBuilder.Name, genericTypeParameterBuilder);
			}
			return dictionary;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000A7E8 File Offset: 0x000089E8
		private static Type AdjustConstraintToNewGenericParameters(Type constraint, MethodInfo methodToCopyGenericsFrom, Type[] originalGenericParameters, GenericTypeParameterBuilder[] newGenericParameters)
		{
			if (constraint.GetTypeInfo().IsGenericType)
			{
				Type[] genericArguments = constraint.GetGenericArguments();
				for (int i = 0; i < genericArguments.Length; i++)
				{
					genericArguments[i] = GenericUtil.AdjustConstraintToNewGenericParameters(genericArguments[i], methodToCopyGenericsFrom, originalGenericParameters, newGenericParameters);
				}
				return constraint.GetGenericTypeDefinition().MakeGenericType(genericArguments);
			}
			if (!constraint.GetTypeInfo().IsGenericParameter)
			{
				return constraint;
			}
			if (constraint.GetTypeInfo().DeclaringMethod != null)
			{
				int num = Array.IndexOf<Type>(originalGenericParameters, constraint);
				Trace.Assert(num != -1, "When a generic method parameter has a constraint on another method parameter, both parameters must be declared on the same method.");
				return newGenericParameters[num].AsType();
			}
			Trace.Assert(constraint.DeclaringType.GetTypeInfo().IsGenericTypeDefinition);
			Trace.Assert(methodToCopyGenericsFrom.DeclaringType.GetTypeInfo().IsGenericType && constraint.DeclaringType == methodToCopyGenericsFrom.DeclaringType.GetGenericTypeDefinition(), "When a generic method parameter has a constraint on a generic type parameter, the generic type must be the declaring typer of the method.");
			int num2 = Array.IndexOf<Type>(constraint.DeclaringType.GetGenericArguments(), constraint);
			Trace.Assert(num2 != -1, "The generic parameter comes from the given type.");
			return methodToCopyGenericsFrom.DeclaringType.GetGenericArguments()[num2];
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		private static Type[] AdjustGenericConstraints(MethodInfo methodToCopyGenericsFrom, GenericTypeParameterBuilder[] newGenericParameters, Type[] originalGenericArguments, Type[] constraints)
		{
			Type[] array = new Type[constraints.Length];
			for (int i = 0; i < constraints.Length; i++)
			{
				array[i] = GenericUtil.AdjustConstraintToNewGenericParameters(constraints[i], methodToCopyGenericsFrom, originalGenericArguments, newGenericParameters);
			}
			return array;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000A928 File Offset: 0x00008B28
		private static GenericTypeParameterBuilder[] CopyGenericArguments(MethodInfo methodToCopyGenericsFrom, Dictionary<string, GenericTypeParameterBuilder> name2GenericType, ApplyGenArgs genericParameterGenerator)
		{
			Type[] genericArguments = methodToCopyGenericsFrom.GetGenericArguments();
			if (genericArguments.Length == 0)
			{
				return null;
			}
			string[] argumentNames = GenericUtil.GetArgumentNames(genericArguments);
			GenericTypeParameterBuilder[] array = genericParameterGenerator(argumentNames);
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					GenericParameterAttributes genericParameterAttributes = genericArguments[i].GetTypeInfo().GenericParameterAttributes;
					array[i].SetGenericParameterAttributes(genericParameterAttributes);
					Type[] interfaceConstraints = GenericUtil.AdjustGenericConstraints(methodToCopyGenericsFrom, array, genericArguments, genericArguments[i].GetTypeInfo().GetGenericParameterConstraints());
					array[i].SetInterfaceConstraints(interfaceConstraints);
					GenericUtil.CopyNonInheritableAttributes(array[i], genericArguments[i]);
				}
				catch (NotSupportedException)
				{
					array[i].SetGenericParameterAttributes(GenericParameterAttributes.None);
				}
				name2GenericType[argumentNames[i]] = array[i];
			}
			return array;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		private static void CopyNonInheritableAttributes(GenericTypeParameterBuilder newGenericParameter, Type originalGenericArgument)
		{
			foreach (CustomAttributeInfo customAttributeInfo in originalGenericArgument.GetTypeInfo().GetNonInheritableAttributes())
			{
				newGenericParameter.SetCustomAttribute(customAttributeInfo.Builder);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000AA28 File Offset: 0x00008C28
		private static string[] GetArgumentNames(Type[] originalGenericArguments)
		{
			string[] array = new string[originalGenericArguments.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = originalGenericArguments[i].Name;
			}
			return array;
		}
	}
}
