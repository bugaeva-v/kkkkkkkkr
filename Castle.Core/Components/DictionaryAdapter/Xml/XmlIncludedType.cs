using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A4 RID: 420
	public class XmlIncludedType : IXmlIncludedType
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x0001F234 File Offset: 0x0001D434
		public XmlIncludedType(XmlName xsiType, Type clrType)
		{
			if (xsiType.LocalName == null)
			{
				throw Error.ArgumentNull("xsiType.LocalName");
			}
			if (clrType == null)
			{
				throw Error.ArgumentNull("clrType");
			}
			this.xsiType = xsiType;
			this.clrType = clrType;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0001F272 File Offset: 0x0001D472
		public XmlIncludedType(string localName, string namespaceUri, Type clrType) : this(new XmlName(localName, namespaceUri), clrType)
		{
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0001F282 File Offset: 0x0001D482
		public XmlName XsiType
		{
			get
			{
				return this.xsiType;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0001F28A File Offset: 0x0001D48A
		public Type ClrType
		{
			get
			{
				return this.clrType;
			}
		}

		// Token: 0x040002CF RID: 719
		private readonly XmlName xsiType;

		// Token: 0x040002D0 RID: 720
		private readonly Type clrType;
	}
}
