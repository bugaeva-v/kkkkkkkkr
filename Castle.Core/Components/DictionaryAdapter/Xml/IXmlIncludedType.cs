using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200019E RID: 414
	public interface IXmlIncludedType
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000CD3 RID: 3283
		XmlName XsiType { get; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000CD4 RID: 3284
		Type ClrType { get; }
	}
}
