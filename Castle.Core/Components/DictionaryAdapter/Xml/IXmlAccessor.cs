using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000158 RID: 344
	public interface IXmlAccessor
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A0B RID: 2571
		Type ClrType { get; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A0C RID: 2572
		XmlTypeSerializer Serializer { get; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A0D RID: 2573
		IXmlContext Context { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A0E RID: 2574
		bool IsNillable { get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A0F RID: 2575
		bool IsReference { get; }

		// Token: 0x06000A10 RID: 2576
		object GetValue(IXmlNode node, IDictionaryAdapter parentObject, XmlReferenceManager references, bool nodeExists, bool orStub);

		// Token: 0x06000A11 RID: 2577
		void SetValue(IXmlCursor cursor, IDictionaryAdapter parentObject, XmlReferenceManager references, bool hasCurrent, object oldValue, ref object newValue);

		// Token: 0x06000A12 RID: 2578
		IXmlCollectionAccessor GetCollectionAccessor(Type itemType);
	}
}
