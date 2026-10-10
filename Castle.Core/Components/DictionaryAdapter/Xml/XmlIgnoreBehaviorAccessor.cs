using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000162 RID: 354
	public class XmlIgnoreBehaviorAccessor : XmlAccessor
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x00019E4E File Offset: 0x0001804E
		private XmlIgnoreBehaviorAccessor() : base(typeof(object), XmlIgnoreBehaviorAccessor.DummyContext.Instance)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00019E65 File Offset: 0x00018065
		public override bool IsIgnored
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00019E68 File Offset: 0x00018068
		public override IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00019E6F File Offset: 0x0001806F
		public override IXmlCursor SelectPropertyNode(IXmlNode node, bool mutable)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00019E76 File Offset: 0x00018076
		public override IXmlCursor SelectCollectionNode(IXmlNode node, bool mutable)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00019E7D File Offset: 0x0001807D
		public override IXmlCursor SelectCollectionItems(IXmlNode node, bool mutable)
		{
			throw Error.NotSupported();
		}

		// Token: 0x04000242 RID: 578
		public static readonly XmlIgnoreBehaviorAccessor Instance = new XmlIgnoreBehaviorAccessor();

		// Token: 0x0200021B RID: 539
		private sealed class DummyContext : IXmlContext, IXmlNamespaceSource
		{
			// Token: 0x06000F1A RID: 3866 RVA: 0x00023C48 File Offset: 0x00021E48
			private DummyContext()
			{
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00023C50 File Offset: 0x00021E50
			public string ChildNamespaceUri
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000F1C RID: 3868 RVA: 0x00023C53 File Offset: 0x00021E53
			public IXmlContext Clone()
			{
				return this;
			}

			// Token: 0x06000F1D RID: 3869 RVA: 0x00023C56 File Offset: 0x00021E56
			public bool IsReservedNamespaceUri(string namespaceUri)
			{
				return false;
			}

			// Token: 0x06000F1E RID: 3870 RVA: 0x00023C59 File Offset: 0x00021E59
			public XmlName GetDefaultXsiType(Type clrType)
			{
				return new XmlName("anyType", "http://www.w3.org/2001/XMLSchema");
			}

			// Token: 0x06000F1F RID: 3871 RVA: 0x00023C6A File Offset: 0x00021E6A
			public IEnumerable<IXmlIncludedType> GetIncludedTypes(Type baseType)
			{
				throw Error.NotSupported();
			}

			// Token: 0x06000F20 RID: 3872 RVA: 0x00023C71 File Offset: 0x00021E71
			public void Enlist(CompiledXPath path)
			{
				throw Error.NotSupported();
			}

			// Token: 0x06000F21 RID: 3873 RVA: 0x00023C78 File Offset: 0x00021E78
			public string GetElementPrefix(IXmlNode node, string namespaceUri)
			{
				throw Error.NotSupported();
			}

			// Token: 0x06000F22 RID: 3874 RVA: 0x00023C7F File Offset: 0x00021E7F
			public string GetAttributePrefix(IXmlNode node, string namespaceUri)
			{
				throw Error.NotSupported();
			}

			// Token: 0x06000F23 RID: 3875 RVA: 0x00023C86 File Offset: 0x00021E86
			public void AddVariable(XPathVariableAttribute attribute)
			{
				throw Error.NotSupported();
			}

			// Token: 0x06000F24 RID: 3876 RVA: 0x00023C8D File Offset: 0x00021E8D
			public void AddFunction(XPathFunctionAttribute attribute)
			{
				throw Error.NotSupported();
			}

			// Token: 0x04000422 RID: 1058
			public static XmlIgnoreBehaviorAccessor.DummyContext Instance = new XmlIgnoreBehaviorAccessor.DummyContext();
		}
	}
}
