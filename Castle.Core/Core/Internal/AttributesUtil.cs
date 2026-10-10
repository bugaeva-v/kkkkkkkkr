using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Castle.Core.Internal
{
	// Token: 0x020000DE RID: 222
	public static class AttributesUtil
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x00011ACD File Offset: 0x0000FCCD
		public static T GetAttribute<T>(this Type type) where T : Attribute
		{
			return type.GetAttributes<T>().FirstOrDefault<T>();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00011ADA File Offset: 0x0000FCDA
		public static IEnumerable<T> GetAttributes<T>(this Type type) where T : Attribute
		{
			object[] array = type.GetTypeInfo().GetCustomAttributes(typeof(T), false);
			for (int i = 0; i < array.Length; i++)
			{
				T t = (T)((object)array[i]);
				yield return t;
			}
			array = null;
			yield break;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00011AEA File Offset: 0x0000FCEA
		public static T GetAttribute<T>(this MemberInfo member) where T : Attribute
		{
			return member.GetAttributes<T>().FirstOrDefault<T>();
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00011AF7 File Offset: 0x0000FCF7
		public static IEnumerable<T> GetAttributes<T>(this MemberInfo member) where T : Attribute
		{
			object[] array = member.GetCustomAttributes(typeof(T), false);
			for (int i = 0; i < array.Length; i++)
			{
				T t = (T)((object)array[i]);
				yield return t;
			}
			array = null;
			yield break;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00011B08 File Offset: 0x0000FD08
		public static T GetTypeAttribute<T>(this Type type) where T : Attribute
		{
			T t = type.GetAttribute<T>();
			if (t == null)
			{
				Type[] interfaces = type.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					t = interfaces[i].GetTypeAttribute<T>();
					if (t != null)
					{
						break;
					}
				}
			}
			return t;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public static T[] GetTypeAttributes<T>(Type type) where T : Attribute
		{
			T[] array = type.GetAttributes<T>().ToArray<T>();
			if (array.Length == 0)
			{
				Type[] interfaces = type.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					array = AttributesUtil.GetTypeAttributes<T>(interfaces[i]);
					if (array.Length != 0)
					{
						break;
					}
				}
			}
			return array;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public static AttributeUsageAttribute GetAttributeUsage(this Type attributeType)
		{
			AttributeUsageAttribute[] array = attributeType.GetTypeInfo().GetCustomAttributes(true).ToArray<AttributeUsageAttribute>();
			if (array.Length == 0)
			{
				return AttributesUtil.DefaultAttributeUsage;
			}
			return array[0];
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00011BB8 File Offset: 0x0000FDB8
		public static Type GetTypeConverter(MemberInfo member)
		{
			TypeConverterAttribute attribute = member.GetAttribute<TypeConverterAttribute>();
			if (attribute != null)
			{
				return Type.GetType(attribute.ConverterTypeName);
			}
			return null;
		}

		// Token: 0x0400016D RID: 365
		private static readonly AttributeUsageAttribute DefaultAttributeUsage = new AttributeUsageAttribute(AttributeTargets.All);
	}
}
