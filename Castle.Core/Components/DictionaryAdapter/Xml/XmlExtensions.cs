using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000174 RID: 372
	internal static class XmlExtensions
	{
		// Token: 0x06000B14 RID: 2836 RVA: 0x0001B271 File Offset: 0x00019471
		public static bool PositionEquals(this IXmlNode nodeA, IXmlNode nodeB)
		{
			return XmlPositionComparer.Instance.Equals(nodeA, nodeB);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0001B280 File Offset: 0x00019480
		public static void CopyTo(this IXmlNode source, IXmlNode target)
		{
			using (XmlReader xmlReader = source.ReadSubtree())
			{
				if (xmlReader.Read())
				{
					using (XmlWriter xmlWriter = target.WriteAttributes())
					{
						xmlWriter.WriteAttributes(xmlReader, false);
					}
					if (xmlReader.Read())
					{
						using (XmlWriter xmlWriter2 = target.WriteChildren())
						{
							do
							{
								xmlWriter2.WriteNode(xmlReader, false);
							}
							while (!xmlReader.EOF && xmlReader.NodeType != XmlNodeType.EndElement);
						}
					}
				}
			}
		}
	}
}
