using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200019F RID: 415
	public interface IXmlIncludedTypeMap
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000CD5 RID: 3285
		IXmlIncludedType Default { get; }

		// Token: 0x06000CD6 RID: 3286
		bool TryGet(XmlName xsiType, out IXmlIncludedType includedType);

		// Token: 0x06000CD7 RID: 3287
		bool TryGet(Type clrType, out IXmlIncludedType includedType);
	}
}
