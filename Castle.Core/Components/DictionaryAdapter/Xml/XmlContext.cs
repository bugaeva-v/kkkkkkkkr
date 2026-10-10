using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000172 RID: 370
	public class XmlContext : XmlContextBase, IXmlContext, IXmlNamespaceSource
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x0001AD0C File Offset: 0x00018F0C
		public XmlContext(XmlMetadata metadata)
		{
			if (metadata == null)
			{
				throw Error.ArgumentNull("metadata");
			}
			this.metadata = metadata;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001AD29 File Offset: 0x00018F29
		protected XmlContext(XmlContext parent) : base(parent)
		{
			this.metadata = parent.metadata;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0001AD3E File Offset: 0x00018F3E
		public IXmlContext Clone()
		{
			return new XmlContext(this);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0001AD46 File Offset: 0x00018F46
		public string ChildNamespaceUri
		{
			get
			{
				return this.metadata.ChildNamespaceUri;
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0001AD53 File Offset: 0x00018F53
		public bool IsReservedNamespaceUri(string namespaceUri)
		{
			return this.metadata.IsReservedNamespaceUri(namespaceUri);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0001AD61 File Offset: 0x00018F61
		public XmlName GetDefaultXsiType(Type clrType)
		{
			return this.metadata.GetDefaultXsiType(clrType);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001AD6F File Offset: 0x00018F6F
		public IEnumerable<IXmlIncludedType> GetIncludedTypes(Type baseType)
		{
			return this.metadata.GetIncludedTypes(baseType);
		}

		// Token: 0x0400025F RID: 607
		private readonly XmlMetadata metadata;
	}
}
