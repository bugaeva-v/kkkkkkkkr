using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000159 RID: 345
	public interface IXmlBehaviorSemantics<T>
	{
		// Token: 0x06000A13 RID: 2579
		string GetLocalName(T behavior);

		// Token: 0x06000A14 RID: 2580
		string GetNamespaceUri(T behavior);

		// Token: 0x06000A15 RID: 2581
		Type GetClrType(T behavior);
	}
}
