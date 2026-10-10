using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200019B RID: 411
	internal class XmlTypeSerializerCache : SingletonDispenser<Type, XmlTypeSerializer>
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x0001EDCC File Offset: 0x0001CFCC
		private XmlTypeSerializerCache() : base(new Func<Type, XmlTypeSerializer>(XmlTypeSerializerCache.CreateSerializer))
		{
			base[typeof(object)] = XmlDynamicSerializer.Instance;
			base[typeof(string)] = XmlStringSerializer.Instance;
			base[typeof(bool)] = XmlSimpleSerializer.ForBoolean;
			base[typeof(char)] = XmlSimpleSerializer.ForChar;
			base[typeof(sbyte)] = XmlSimpleSerializer.ForSByte;
			base[typeof(short)] = XmlSimpleSerializer.ForInt16;
			base[typeof(int)] = XmlSimpleSerializer.ForInt32;
			base[typeof(long)] = XmlSimpleSerializer.ForInt64;
			base[typeof(byte)] = XmlSimpleSerializer.ForByte;
			base[typeof(ushort)] = XmlSimpleSerializer.ForUInt16;
			base[typeof(uint)] = XmlSimpleSerializer.ForUInt32;
			base[typeof(ulong)] = XmlSimpleSerializer.ForUInt64;
			base[typeof(float)] = XmlSimpleSerializer.ForSingle;
			base[typeof(double)] = XmlSimpleSerializer.ForDouble;
			base[typeof(decimal)] = XmlSimpleSerializer.ForDecimal;
			base[typeof(TimeSpan)] = XmlSimpleSerializer.ForTimeSpan;
			base[typeof(DateTime)] = XmlSimpleSerializer.ForDateTime;
			base[typeof(DateTimeOffset)] = XmlSimpleSerializer.ForDateTimeOffset;
			base[typeof(Guid)] = XmlSimpleSerializer.ForGuid;
			base[typeof(byte[])] = XmlSimpleSerializer.ForByteArray;
			base[typeof(Uri)] = XmlSimpleSerializer.ForUri;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		private static XmlTypeSerializer CreateSerializer(Type type)
		{
			if (type.GetTypeInfo().IsArray)
			{
				return XmlArraySerializer.Instance;
			}
			if (type.GetTypeInfo().IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IEnumerable<>) || genericTypeDefinition == typeof(IBindingList<>))
				{
					return XmlListSerializer.Instance;
				}
				if (genericTypeDefinition == typeof(ISet<>))
				{
					return XmlSetSerializer.Instance;
				}
				if (genericTypeDefinition == typeof(IDictionary<, >) || genericTypeDefinition == typeof(Dictionary<, >) || genericTypeDefinition == typeof(SortedDictionary<, >) || genericTypeDefinition == typeof(List<>) || genericTypeDefinition == typeof(Stack<>) || genericTypeDefinition == typeof(Queue<>) || genericTypeDefinition == typeof(LinkedList<>) || genericTypeDefinition == typeof(SortedList<, >) || genericTypeDefinition == typeof(HashSet<>) || genericTypeDefinition == typeof(SortedSet<>) || genericTypeDefinition == typeof(BindingList<>))
				{
					throw Error.UnsupportedCollectionType(type);
				}
			}
			if (type.GetTypeInfo().IsInterface)
			{
				return XmlComponentSerializer.Instance;
			}
			if (type.GetTypeInfo().IsEnum)
			{
				return XmlEnumerationSerializer.Instance;
			}
			if (type.IsCustomSerializable())
			{
				return XmlCustomSerializer.Instance;
			}
			if (typeof(XmlNode).IsAssignableFrom(type))
			{
				return XmlXmlNodeSerializer.Instance;
			}
			return new XmlDefaultSerializer(type);
		}

		// Token: 0x040002CD RID: 717
		public static readonly XmlTypeSerializerCache Instance = new XmlTypeSerializerCache();
	}
}
