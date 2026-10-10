using System;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001B1 RID: 433
	public static class TypeExtensions
	{
		// Token: 0x06000D2F RID: 3375 RVA: 0x0001FD8D File Offset: 0x0001DF8D
		public static Type NonNullable(this Type type)
		{
			if (!type.GetTypeInfo().IsGenericType || !(type.GetGenericTypeDefinition() == typeof(Nullable<>)))
			{
				return type;
			}
			return type.GetGenericArguments()[0];
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0001FDBD File Offset: 0x0001DFBD
		public static Type GetCollectionItemType(this Type type)
		{
			if (type.GetTypeInfo().IsArray)
			{
				return type.GetElementType();
			}
			if (type.GetTypeInfo().IsGenericType)
			{
				return type.GetGenericArguments().Single<Type>();
			}
			throw Error.NotCollectionType("type");
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		public static Type GetComponentType(this object obj)
		{
			IDictionaryAdapter dictionaryAdapter = obj as IDictionaryAdapter;
			if (dictionaryAdapter != null)
			{
				return dictionaryAdapter.Meta.Type;
			}
			return obj.GetType();
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0001FE21 File Offset: 0x0001E021
		internal static bool IsCustomSerializable(this Type type)
		{
			return typeof(IXmlSerializable).IsAssignableFrom(type);
		}
	}
}
