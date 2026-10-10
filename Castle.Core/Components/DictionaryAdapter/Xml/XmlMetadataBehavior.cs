using System;
using System.Collections.Generic;
using System.Linq;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000156 RID: 342
	public class XmlMetadataBehavior : DictionaryBehaviorAttribute, IDictionaryMetaInitializer, IDictionaryBehavior
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00018C43 File Offset: 0x00016E43
		public IEnumerable<string> ReservedNamespaceUris
		{
			get
			{
				return this.reservedNamespaceUris.ToArray<string>();
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00018C50 File Offset: 0x00016E50
		public XmlMetadataBehavior AddReservedNamespaceUri(string uri)
		{
			this.reservedNamespaceUris.Add(uri);
			return this;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00018C60 File Offset: 0x00016E60
		void IDictionaryMetaInitializer.Initialize(IDictionaryAdapterFactory factory, DictionaryAdapterMeta meta)
		{
			meta.SetXmlMeta(new XmlMetadata(meta, this.reservedNamespaceUris));
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00018C74 File Offset: 0x00016E74
		bool IDictionaryMetaInitializer.ShouldHaveBehavior(object behavior)
		{
			return behavior is XmlDefaultsAttribute || behavior is XmlNamespaceAttribute || behavior is XPathVariableAttribute || behavior is XPathFunctionAttribute;
		}

		// Token: 0x0400022C RID: 556
		public static readonly XmlMetadataBehavior Default = new XmlMetadataBehavior();

		// Token: 0x0400022D RID: 557
		private readonly HashSet<string> reservedNamespaceUris = new HashSet<string>
		{
			"http://www.w3.org/2000/xmlns/",
			"http://www.w3.org/2001/XMLSchema-instance",
			"urn:schemas-castle-org:xml-reference"
		};
	}
}
