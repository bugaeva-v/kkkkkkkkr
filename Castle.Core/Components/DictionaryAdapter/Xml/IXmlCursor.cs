using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200016D RID: 365
	public interface IXmlCursor : IXmlIterator, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x06000AC7 RID: 2759
		void Reset();

		// Token: 0x06000AC8 RID: 2760
		void MoveTo(IXmlNode node);

		// Token: 0x06000AC9 RID: 2761
		void MoveToEnd();

		// Token: 0x06000ACA RID: 2762
		void Create(Type type);

		// Token: 0x06000ACB RID: 2763
		void Coerce(Type type);

		// Token: 0x06000ACC RID: 2764
		void Remove();

		// Token: 0x06000ACD RID: 2765
		void RemoveAllNext();
	}
}
