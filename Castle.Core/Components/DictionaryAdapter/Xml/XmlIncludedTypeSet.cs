using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A5 RID: 421
	public class XmlIncludedTypeSet : IXmlIncludedTypeMap, IEnumerable<IXmlIncludedType>, IEnumerable
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x0001F294 File Offset: 0x0001D494
		public XmlIncludedTypeSet()
		{
			this.itemsByXsiType = new Dictionary<XmlName, IXmlIncludedType>();
			this.itemsByClrType = new Dictionary<Type, IXmlIncludedType>();
			foreach (IXmlIncludedType includedType in XmlIncludedTypeSet.DefaultEntries)
			{
				this.Add(includedType);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0001F2FC File Offset: 0x0001D4FC
		IXmlIncludedType IXmlIncludedTypeMap.Default
		{
			get
			{
				throw Error.NoDefaultKnownType();
			}
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0001F303 File Offset: 0x0001D503
		public void Add(IXmlIncludedType includedType)
		{
			this.itemsByXsiType.Add(includedType.XsiType, includedType);
			this.itemsByClrType[includedType.ClrType] = includedType;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0001F329 File Offset: 0x0001D529
		public bool TryGet(XmlName xsiType, out IXmlIncludedType includedType)
		{
			return this.itemsByXsiType.TryGetValue(xsiType, out includedType);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0001F338 File Offset: 0x0001D538
		public bool TryGet(Type clrType, out IXmlIncludedType includedType)
		{
			return this.itemsByClrType.TryGetValue(clrType, out includedType);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0001F347 File Offset: 0x0001D547
		public IEnumerator<IXmlIncludedType> GetEnumerator()
		{
			return this.itemsByXsiType.Values.GetEnumerator();
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0001F35E File Offset: 0x0001D55E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040002D1 RID: 721
		private readonly Dictionary<XmlName, IXmlIncludedType> itemsByXsiType;

		// Token: 0x040002D2 RID: 722
		private readonly Dictionary<Type, IXmlIncludedType> itemsByClrType;

		// Token: 0x040002D3 RID: 723
		public static readonly IList<IXmlIncludedType> DefaultEntries = Array.AsReadOnly<IXmlIncludedType>(new IXmlIncludedType[]
		{
			new XmlIncludedType("anyType", "http://www.w3.org/2001/XMLSchema", typeof(object)),
			new XmlIncludedType("string", "http://www.w3.org/2001/XMLSchema", typeof(string)),
			new XmlIncludedType("boolean", "http://www.w3.org/2001/XMLSchema", typeof(bool)),
			new XmlIncludedType("byte", "http://www.w3.org/2001/XMLSchema", typeof(sbyte)),
			new XmlIncludedType("unsignedByte", "http://www.w3.org/2001/XMLSchema", typeof(byte)),
			new XmlIncludedType("short", "http://www.w3.org/2001/XMLSchema", typeof(short)),
			new XmlIncludedType("unsignedShort", "http://www.w3.org/2001/XMLSchema", typeof(ushort)),
			new XmlIncludedType("int", "http://www.w3.org/2001/XMLSchema", typeof(int)),
			new XmlIncludedType("unsignedInt", "http://www.w3.org/2001/XMLSchema", typeof(uint)),
			new XmlIncludedType("long", "http://www.w3.org/2001/XMLSchema", typeof(long)),
			new XmlIncludedType("unsignedLong", "http://www.w3.org/2001/XMLSchema", typeof(ulong)),
			new XmlIncludedType("float", "http://www.w3.org/2001/XMLSchema", typeof(float)),
			new XmlIncludedType("double", "http://www.w3.org/2001/XMLSchema", typeof(double)),
			new XmlIncludedType("decimal", "http://www.w3.org/2001/XMLSchema", typeof(decimal)),
			new XmlIncludedType("guid", "http://microsoft.com/wsdl/types/", typeof(Guid)),
			new XmlIncludedType("dateTime", "http://www.w3.org/2001/XMLSchema", typeof(DateTime)),
			new XmlIncludedType("duration", "http://www.w3.org/2001/XMLSchema", typeof(TimeSpan)),
			new XmlIncludedType("base64Binary", "http://www.w3.org/2001/XMLSchema", typeof(byte[])),
			new XmlIncludedType("anyURI", "http://www.w3.org/2001/XMLSchema", typeof(Uri)),
			new XmlIncludedType("QName", "http://www.w3.org/2001/XMLSchema", typeof(XmlQualifiedName))
		});
	}
}
