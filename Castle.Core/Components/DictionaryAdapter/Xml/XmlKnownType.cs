using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A6 RID: 422
	public class XmlKnownType : IXmlKnownType, IXmlIdentity
	{
		// Token: 0x06000CEA RID: 3306 RVA: 0x0001F5C4 File Offset: 0x0001D7C4
		public XmlKnownType(XmlName name, XmlName xsiType, Type clrType)
		{
			if (name.LocalName == null)
			{
				throw Error.ArgumentNull("name.LocalName");
			}
			if (clrType == null)
			{
				throw Error.ArgumentNull("clrType");
			}
			this.name = name;
			this.xsiType = xsiType;
			this.clrType = clrType;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0001F614 File Offset: 0x0001D814
		public XmlKnownType(string nameLocalName, string nameNamespaceUri, string xsiTypeLocalName, string xsiTypeNamespaceUri, Type clrType) : this(new XmlName(nameLocalName, nameNamespaceUri), new XmlName(xsiTypeLocalName, xsiTypeNamespaceUri), clrType)
		{
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0001F62D File Offset: 0x0001D82D
		public XmlName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0001F635 File Offset: 0x0001D835
		public XmlName XsiType
		{
			get
			{
				return this.xsiType;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0001F63D File Offset: 0x0001D83D
		public Type ClrType
		{
			get
			{
				return this.clrType;
			}
		}

		// Token: 0x040002D4 RID: 724
		private readonly XmlName name;

		// Token: 0x040002D5 RID: 725
		private readonly XmlName xsiType;

		// Token: 0x040002D6 RID: 726
		private readonly Type clrType;
	}
}
