using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000170 RID: 368
	public interface IXmlNode : IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AD1 RID: 2769
		bool IsElement { get; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AD2 RID: 2770
		bool IsAttribute { get; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AD3 RID: 2771
		// (set) Token: 0x06000AD4 RID: 2772
		bool IsNil { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000AD5 RID: 2773
		// (set) Token: 0x06000AD6 RID: 2774
		string Value { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000AD7 RID: 2775
		string Xml { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000AD8 RID: 2776
		IXmlNode Parent { get; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000AD9 RID: 2777
		IXmlNamespaceSource Namespaces { get; }

		// Token: 0x06000ADA RID: 2778
		string GetAttribute(XmlName name);

		// Token: 0x06000ADB RID: 2779
		void SetAttribute(XmlName name, string value);

		// Token: 0x06000ADC RID: 2780
		string LookupPrefix(string namespaceUri);

		// Token: 0x06000ADD RID: 2781
		string LookupNamespaceUri(string prefix);

		// Token: 0x06000ADE RID: 2782
		void DefineNamespace(string prefix, string namespaceUri, bool root);

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000ADF RID: 2783
		object UnderlyingObject { get; }

		// Token: 0x06000AE0 RID: 2784
		bool UnderlyingPositionEquals(IXmlNode node);

		// Token: 0x06000AE1 RID: 2785
		IXmlNode Save();

		// Token: 0x06000AE2 RID: 2786
		IXmlCursor SelectSelf(Type clrType);

		// Token: 0x06000AE3 RID: 2787
		IXmlCursor SelectChildren(IXmlKnownTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags);

		// Token: 0x06000AE4 RID: 2788
		IXmlIterator SelectSubtree();

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000AE5 RID: 2789
		CompiledXPath Path { get; }

		// Token: 0x06000AE6 RID: 2790
		IXmlCursor Select(CompiledXPath path, IXmlIncludedTypeMap includedTypes, IXmlNamespaceSource namespaces, CursorFlags flags);

		// Token: 0x06000AE7 RID: 2791
		object Evaluate(CompiledXPath path);

		// Token: 0x06000AE8 RID: 2792
		void Clear();

		// Token: 0x06000AE9 RID: 2793
		XmlReader ReadSubtree();

		// Token: 0x06000AEA RID: 2794
		XmlWriter WriteAttributes();

		// Token: 0x06000AEB RID: 2795
		XmlWriter WriteChildren();
	}
}
