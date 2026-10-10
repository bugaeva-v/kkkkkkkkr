using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000176 RID: 374
	public class XmlNameComparer : IEqualityComparer<XmlName>
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x0001B461 File Offset: 0x00019661
		private XmlNameComparer(StringComparer comparer)
		{
			this.comparer = comparer;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001B470 File Offset: 0x00019670
		public int GetHashCode(XmlName name)
		{
			int num = (name.LocalName != null) ? this.comparer.GetHashCode(name.LocalName) : 0;
			if (name.NamespaceUri != null)
			{
				num = ((num << 7 | num >> 25) ^ this.comparer.GetHashCode(name.NamespaceUri));
			}
			return num;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001B4C2 File Offset: 0x000196C2
		public bool Equals(XmlName x, XmlName y)
		{
			return this.comparer.Equals(x.LocalName, y.LocalName) && this.comparer.Equals(x.NamespaceUri, y.NamespaceUri);
		}

		// Token: 0x04000269 RID: 617
		public static readonly XmlNameComparer Default = new XmlNameComparer(StringComparer.Ordinal);

		// Token: 0x0400026A RID: 618
		public static readonly XmlNameComparer IgnoreCase = new XmlNameComparer(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400026B RID: 619
		private readonly StringComparer comparer;
	}
}
