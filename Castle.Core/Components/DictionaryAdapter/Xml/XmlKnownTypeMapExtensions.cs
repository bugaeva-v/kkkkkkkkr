using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A3 RID: 419
	public static class XmlKnownTypeMapExtensions
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x0001F214 File Offset: 0x0001D414
		public static IXmlKnownType Require(this IXmlKnownTypeMap map, Type clrType)
		{
			IXmlKnownType result;
			if (map.TryGet(clrType, out result))
			{
				return result;
			}
			throw Error.NotXmlKnownType(clrType);
		}
	}
}
