using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000153 RID: 339
	public interface IXmlReferenceFormat
	{
		// Token: 0x06000993 RID: 2451
		bool TryGetIdentity(IXmlNode node, out int id);

		// Token: 0x06000994 RID: 2452
		bool TryGetReference(IXmlNode node, out int id);

		// Token: 0x06000995 RID: 2453
		void SetIdentity(IXmlNode node, int id);

		// Token: 0x06000996 RID: 2454
		void SetReference(IXmlNode node, int id);

		// Token: 0x06000997 RID: 2455
		void ClearIdentity(IXmlNode node);

		// Token: 0x06000998 RID: 2456
		void ClearReference(IXmlNode node);
	}
}
