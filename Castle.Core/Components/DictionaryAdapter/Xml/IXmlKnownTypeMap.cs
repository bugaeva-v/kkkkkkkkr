using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A2 RID: 418
	public interface IXmlKnownTypeMap
	{
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CDA RID: 3290
		IXmlKnownType Default { get; }

		// Token: 0x06000CDB RID: 3291
		bool TryGet(IXmlIdentity xmlNode, out IXmlKnownType knownType);

		// Token: 0x06000CDC RID: 3292
		bool TryGet(Type clrType, out IXmlKnownType knownType);
	}
}
