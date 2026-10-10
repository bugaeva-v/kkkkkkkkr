using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A0 RID: 416
	public static class XmlIncludedTypeMapExtensions
	{
		// Token: 0x06000CD8 RID: 3288 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		public static IXmlIncludedType Require(this IXmlIncludedTypeMap includedTypes, Type clrType)
		{
			IXmlIncludedType result;
			if (includedTypes.TryGet(clrType, out result))
			{
				return result;
			}
			throw Error.NotXmlKnownType(clrType);
		}
	}
}
