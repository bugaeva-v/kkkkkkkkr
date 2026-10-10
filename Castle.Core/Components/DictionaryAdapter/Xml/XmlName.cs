using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000175 RID: 373
	public struct XmlName : IEquatable<XmlName>
	{
		// Token: 0x06000B16 RID: 2838 RVA: 0x0001B324 File Offset: 0x00019524
		public XmlName(string localName, string namespaceUri)
		{
			this.localName = localName;
			this.namespaceUri = namespaceUri;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0001B334 File Offset: 0x00019534
		public string LocalName
		{
			get
			{
				return this.localName;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0001B33C File Offset: 0x0001953C
		public string NamespaceUri
		{
			get
			{
				return this.namespaceUri;
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001B344 File Offset: 0x00019544
		public override int GetHashCode()
		{
			return XmlNameComparer.Default.GetHashCode(this);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001B356 File Offset: 0x00019556
		public bool Equals(XmlName other)
		{
			return XmlNameComparer.Default.Equals(this, other);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0001B369 File Offset: 0x00019569
		public override bool Equals(object obj)
		{
			return obj is XmlName && this.Equals((XmlName)obj);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0001B381 File Offset: 0x00019581
		public static bool operator ==(XmlName x, XmlName y)
		{
			return XmlNameComparer.Default.Equals(x, y);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0001B38F File Offset: 0x0001958F
		public static bool operator !=(XmlName x, XmlName y)
		{
			return !XmlNameComparer.Default.Equals(x, y);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001B3A0 File Offset: 0x000195A0
		public XmlName WithNamespaceUri(string namespaceUri)
		{
			return new XmlName(this.localName, namespaceUri);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001B3AE File Offset: 0x000195AE
		public override string ToString()
		{
			if (string.IsNullOrEmpty(this.localName))
			{
				return string.Empty;
			}
			if (string.IsNullOrEmpty(this.namespaceUri))
			{
				return this.localName;
			}
			return this.namespaceUri + ":" + this.localName;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001B3F0 File Offset: 0x000195F0
		public static XmlName ParseQName(string text)
		{
			if (text == null)
			{
				throw Error.ArgumentNull("text");
			}
			int num = text.IndexOf(':');
			if (num == -1)
			{
				return new XmlName(text, null);
			}
			if (num == 0)
			{
				return new XmlName(text.Substring(1), null);
			}
			if (num == text.Length)
			{
				return new XmlName(text.Substring(0, num), null);
			}
			return new XmlName(text.Substring(num + 1), text.Substring(0, num));
		}

		// Token: 0x04000266 RID: 614
		public static readonly XmlName Empty;

		// Token: 0x04000267 RID: 615
		private readonly string localName;

		// Token: 0x04000268 RID: 616
		private readonly string namespaceUri;
	}
}
