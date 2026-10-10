using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200016C RID: 364
	public interface IXmlContext : IXmlNamespaceSource
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000ABF RID: 2751
		string ChildNamespaceUri { get; }

		// Token: 0x06000AC0 RID: 2752
		IXmlContext Clone();

		// Token: 0x06000AC1 RID: 2753
		XmlName GetDefaultXsiType(Type clrType);

		// Token: 0x06000AC2 RID: 2754
		IEnumerable<IXmlIncludedType> GetIncludedTypes(Type baseType);

		// Token: 0x06000AC3 RID: 2755
		bool IsReservedNamespaceUri(string namespaceUri);

		// Token: 0x06000AC4 RID: 2756
		void AddVariable(XPathVariableAttribute attribute);

		// Token: 0x06000AC5 RID: 2757
		void AddFunction(XPathFunctionAttribute attribute);

		// Token: 0x06000AC6 RID: 2758
		void Enlist(CompiledXPath path);
	}
}
