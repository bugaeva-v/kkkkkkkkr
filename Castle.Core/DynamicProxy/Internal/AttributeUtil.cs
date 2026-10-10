using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Internal
{
	// Token: 0x02000027 RID: 39
	public static class AttributeUtil
	{
		// Token: 0x06000148 RID: 328 RVA: 0x0000552C File Offset: 0x0000372C
		public static CustomAttributeInfo CreateInfo(CustomAttributeData attribute)
		{
			Type[] types;
			object[] constructorArgs;
			AttributeUtil.GetArguments(attribute.ConstructorArguments, out types, out constructorArgs);
			ConstructorInfo constructor = attribute.AttributeType.GetConstructor(types);
			PropertyInfo[] namedProperties;
			object[] propertyValues;
			FieldInfo[] namedFields;
			object[] fieldValues;
			AttributeUtil.GetSettersAndFields(attribute.AttributeType, attribute.NamedArguments, out namedProperties, out propertyValues, out namedFields, out fieldValues);
			return new CustomAttributeInfo(constructor, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000557C File Offset: 0x0000377C
		private static void GetArguments(IList<CustomAttributeTypedArgument> constructorArguments, out Type[] constructorArgTypes, out object[] constructorArgs)
		{
			constructorArgTypes = new Type[constructorArguments.Count];
			constructorArgs = new object[constructorArguments.Count];
			for (int i = 0; i < constructorArguments.Count; i++)
			{
				constructorArgTypes[i] = constructorArguments[i].ArgumentType;
				constructorArgs[i] = AttributeUtil.ReadAttributeValue(constructorArguments[i]);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000055D8 File Offset: 0x000037D8
		private static object[] GetArguments(IList<CustomAttributeTypedArgument> constructorArguments)
		{
			object[] array = new object[constructorArguments.Count];
			for (int i = 0; i < constructorArguments.Count; i++)
			{
				array[i] = AttributeUtil.ReadAttributeValue(constructorArguments[i]);
			}
			return array;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005614 File Offset: 0x00003814
		private static object ReadAttributeValue(CustomAttributeTypedArgument argument)
		{
			object value = argument.Value;
			if (!argument.ArgumentType.GetTypeInfo().IsArray)
			{
				return value;
			}
			object[] arguments = AttributeUtil.GetArguments((IList<CustomAttributeTypedArgument>)value);
			object[] array = new object[arguments.Length];
			arguments.CopyTo(array, 0);
			return array;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000565C File Offset: 0x0000385C
		private static void GetSettersAndFields(Type attributeType, IEnumerable<CustomAttributeNamedArgument> namedArguments, out PropertyInfo[] properties, out object[] propertyValues, out FieldInfo[] fields, out object[] fieldValues)
		{
			List<PropertyInfo> list = new List<PropertyInfo>();
			List<object> list2 = new List<object>();
			List<FieldInfo> list3 = new List<FieldInfo>();
			List<object> list4 = new List<object>();
			foreach (CustomAttributeNamedArgument customAttributeNamedArgument in namedArguments)
			{
				if (customAttributeNamedArgument.IsField)
				{
					list3.Add(attributeType.GetField(customAttributeNamedArgument.MemberName));
					list4.Add(AttributeUtil.ReadAttributeValue(customAttributeNamedArgument.TypedValue));
				}
				else
				{
					list.Add(attributeType.GetProperty(customAttributeNamedArgument.MemberName));
					list2.Add(AttributeUtil.ReadAttributeValue(customAttributeNamedArgument.TypedValue));
				}
			}
			properties = list.ToArray();
			propertyValues = list2.ToArray();
			fields = list3.ToArray();
			fieldValues = list4.ToArray();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005734 File Offset: 0x00003934
		public static IEnumerable<CustomAttributeInfo> GetNonInheritableAttributes(this MemberInfo member)
		{
			IEnumerable<CustomAttributeData> customAttributes = member.CustomAttributes;
			foreach (CustomAttributeData customAttributeData in customAttributes)
			{
				Type attributeType = customAttributeData.AttributeType;
				if (!AttributeUtil.ShouldSkipAttributeReplication(attributeType, false))
				{
					CustomAttributeInfo customAttributeInfo;
					try
					{
						customAttributeInfo = AttributeUtil.CreateInfo(customAttributeData);
					}
					catch (ArgumentException innerException)
					{
						throw new ProxyGenerationException(string.Format("Due to limitations in CLR, DynamicProxy was unable to successfully replicate non-inheritable attribute {0} on {1}{2}. To avoid this error you can chose not to replicate this attribute type by calling '{3}.Add(typeof({0}))'.", new object[]
						{
							attributeType.FullName,
							member.DeclaringType.FullName,
							(member is TypeInfo) ? "" : ("." + member.Name),
							typeof(AttributesToAvoidReplicating).FullName
						}), innerException);
					}
					if (customAttributeInfo != null)
					{
						yield return customAttributeInfo;
					}
				}
			}
			IEnumerator<CustomAttributeData> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005744 File Offset: 0x00003944
		public static IEnumerable<CustomAttributeInfo> GetNonInheritableAttributes(this ParameterInfo parameter)
		{
			IEnumerable<CustomAttributeData> customAttributes = parameter.CustomAttributes;
			bool ignoreInheritance = parameter.Member is ConstructorInfo;
			foreach (CustomAttributeData customAttributeData in customAttributes)
			{
				if (!AttributeUtil.ShouldSkipAttributeReplication(customAttributeData.AttributeType, ignoreInheritance))
				{
					CustomAttributeInfo customAttributeInfo = AttributeUtil.CreateInfo(customAttributeData);
					if (customAttributeInfo != null)
					{
						yield return customAttributeInfo;
					}
				}
			}
			IEnumerator<CustomAttributeData> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005754 File Offset: 0x00003954
		private static bool ShouldSkipAttributeReplication(Type attribute, bool ignoreInheritance)
		{
			if (!attribute.GetTypeInfo().IsPublic)
			{
				return true;
			}
			if (AttributesToAvoidReplicating.ShouldAvoid(attribute))
			{
				return true;
			}
			if (attribute == typeof(ParamArrayAttribute))
			{
				return false;
			}
			if (!ignoreInheritance)
			{
				AttributeUsageAttribute[] array = attribute.GetTypeInfo().GetCustomAttributes(true).ToArray<AttributeUsageAttribute>();
				return array.Length == 0 || array[0].Inherited;
			}
			return false;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000057B3 File Offset: 0x000039B3
		public static CustomAttributeInfo CreateInfo<TAttribute>() where TAttribute : Attribute, new()
		{
			return new CustomAttributeInfo(typeof(TAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000057D4 File Offset: 0x000039D4
		public static CustomAttributeInfo CreateInfo(Type attribute, object[] constructorArguments)
		{
			return new CustomAttributeInfo(attribute.GetConstructor(AttributeUtil.GetTypes(constructorArguments)), constructorArguments);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000057E8 File Offset: 0x000039E8
		private static Type[] GetTypes(object[] objects)
		{
			Type[] array = new Type[objects.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = objects[i].GetType();
			}
			return array;
		}
	}
}
