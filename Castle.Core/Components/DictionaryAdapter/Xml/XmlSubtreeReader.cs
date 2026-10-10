using System;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001B2 RID: 434
	public class XmlSubtreeReader : XmlReader
	{
		// Token: 0x06000D33 RID: 3379 RVA: 0x0001FE33 File Offset: 0x0001E033
		public XmlSubtreeReader(IXmlNode node, XmlRootAttribute root) : this(node, root.ElementName, root.Namespace)
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0001FE48 File Offset: 0x0001E048
		public XmlSubtreeReader(IXmlNode node, string rootLocalName, string rootNamespaceUri)
		{
			if (node == null)
			{
				throw Error.ArgumentNull("node");
			}
			if (rootLocalName == null)
			{
				throw Error.ArgumentNull("rootLocalName");
			}
			this.reader = node.ReadSubtree();
			this.rootLocalName = this.reader.NameTable.Add(rootLocalName);
			this.rootNamespaceURI = (rootNamespaceUri ?? string.Empty);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		protected override void Dispose(bool managed)
		{
			try
			{
				if (managed)
				{
					this.DisposeReader();
				}
			}
			finally
			{
				base.Dispose(managed);
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0001FEDC File Offset: 0x0001E0DC
		private void DisposeReader()
		{
			IDisposable disposable = Interlocked.Exchange<XmlReader>(ref this.reader, null);
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0001FEFF File Offset: 0x0001E0FF
		public bool IsDisposed
		{
			get
			{
				return this.reader == null;
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0001FF0A File Offset: 0x0001E10A
		private void RequireNotDisposed()
		{
			if (this.IsDisposed)
			{
				throw Error.ObjectDisposed("XmlSubtreeReader");
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0001FF1F File Offset: 0x0001E11F
		protected XmlReader Reader
		{
			get
			{
				this.RequireNotDisposed();
				return this.reader;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0001FF2D File Offset: 0x0001E12D
		public override ReadState ReadState
		{
			get
			{
				if (!this.IsDisposed)
				{
					return this.reader.ReadState;
				}
				return ReadState.Closed;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0001FF44 File Offset: 0x0001E144
		public override int Depth
		{
			get
			{
				return this.Reader.Depth;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0001FF51 File Offset: 0x0001E151
		public override XmlNodeType NodeType
		{
			get
			{
				return this.Reader.NodeType;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0001FF60 File Offset: 0x0001E160
		public bool IsAtRootElement
		{
			get
			{
				this.RequireNotDisposed();
				return this.reader.ReadState == ReadState.Interactive && this.reader.Depth == 0 && (this.reader.NodeType == XmlNodeType.Element || this.reader.NodeType == XmlNodeType.EndElement);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0001FFAF File Offset: 0x0001E1AF
		public override bool EOF
		{
			get
			{
				return this.Reader.EOF;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		public override string Prefix
		{
			get
			{
				return this.Reader.Prefix;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0001FFC9 File Offset: 0x0001E1C9
		public override string LocalName
		{
			get
			{
				if (!this.IsAtRootElement)
				{
					return this.Reader.LocalName;
				}
				return this.rootLocalName;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0001FFE5 File Offset: 0x0001E1E5
		public override string NamespaceURI
		{
			get
			{
				if (!this.IsAtRootElement)
				{
					return this.TranslateNamespaceURI();
				}
				return this.CaptureNamespaceUri();
			}
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		private string CaptureNamespaceUri()
		{
			if (this.underlyingNamespaceURI == null)
			{
				this.underlyingNamespaceURI = this.Reader.NamespaceURI;
			}
			return this.rootNamespaceURI;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00020020 File Offset: 0x0001E220
		private string TranslateNamespaceURI()
		{
			string namespaceURI = this.Reader.NamespaceURI;
			if (!(namespaceURI == this.underlyingNamespaceURI))
			{
				return namespaceURI;
			}
			return this.rootNamespaceURI;
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0002004F File Offset: 0x0001E24F
		public override string Value
		{
			get
			{
				return this.Reader.Value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0002005C File Offset: 0x0001E25C
		public override bool IsEmptyElement
		{
			get
			{
				return this.Reader.IsEmptyElement;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00020069 File Offset: 0x0001E269
		public override int AttributeCount
		{
			get
			{
				return this.Reader.AttributeCount;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00020076 File Offset: 0x0001E276
		public override string BaseURI
		{
			get
			{
				return this.Reader.BaseURI;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00020083 File Offset: 0x0001E283
		public override XmlNameTable NameTable
		{
			get
			{
				return this.Reader.NameTable;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00020090 File Offset: 0x0001E290
		public override bool Read()
		{
			return this.Reader.Read();
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0002009D File Offset: 0x0001E29D
		public override bool MoveToElement()
		{
			return this.Reader.MoveToElement();
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000200AA File Offset: 0x0001E2AA
		public override bool MoveToFirstAttribute()
		{
			return this.Reader.MoveToFirstAttribute();
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000200B7 File Offset: 0x0001E2B7
		public override bool MoveToNextAttribute()
		{
			return this.Reader.MoveToNextAttribute();
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000200C4 File Offset: 0x0001E2C4
		public override bool MoveToAttribute(string name)
		{
			return this.Reader.MoveToAttribute(name);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000200D2 File Offset: 0x0001E2D2
		public override bool MoveToAttribute(string name, string ns)
		{
			return this.Reader.MoveToAttribute(name, ns);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000200E1 File Offset: 0x0001E2E1
		public override bool ReadAttributeValue()
		{
			return this.Reader.ReadAttributeValue();
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000200EE File Offset: 0x0001E2EE
		public override string GetAttribute(int i)
		{
			return this.Reader.GetAttribute(i);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000200FC File Offset: 0x0001E2FC
		public override string GetAttribute(string name)
		{
			return this.Reader.GetAttribute(name);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0002010A File Offset: 0x0001E30A
		public override string GetAttribute(string name, string namespaceURI)
		{
			return this.Reader.GetAttribute(name, namespaceURI);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00020119 File Offset: 0x0001E319
		public override string LookupNamespace(string prefix)
		{
			return this.Reader.LookupNamespace(prefix);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00020127 File Offset: 0x0001E327
		public override void ResolveEntity()
		{
			this.Reader.ResolveEntity();
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00020134 File Offset: 0x0001E334
		public override void Close()
		{
			if (!this.IsDisposed)
			{
				this.reader.Close();
			}
		}

		// Token: 0x040002E2 RID: 738
		private readonly string rootLocalName;

		// Token: 0x040002E3 RID: 739
		private readonly string rootNamespaceURI;

		// Token: 0x040002E4 RID: 740
		private string underlyingNamespaceURI;

		// Token: 0x040002E5 RID: 741
		private XmlReader reader;
	}
}
