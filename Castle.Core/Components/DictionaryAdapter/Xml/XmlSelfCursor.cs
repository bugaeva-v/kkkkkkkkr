using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000179 RID: 377
	public class XmlSelfCursor : IXmlCursor, IXmlIterator, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x06000B34 RID: 2868 RVA: 0x0001B614 File Offset: 0x00019814
		public XmlSelfCursor(IXmlNode node, Type clrType)
		{
			this.node = node;
			this.clrType = clrType;
			this.Reset();
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0001B630 File Offset: 0x00019830
		public CursorFlags Flags
		{
			get
			{
				if (!this.node.IsAttribute)
				{
					return CursorFlags.Elements;
				}
				return CursorFlags.Attributes;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0001B642 File Offset: 0x00019842
		public CompiledXPath Path
		{
			get
			{
				return this.node.Path;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0001B64F File Offset: 0x0001984F
		public XmlName Name
		{
			get
			{
				return this.node.Name;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0001B65C File Offset: 0x0001985C
		public XmlName XsiType
		{
			get
			{
				return this.node.XsiType;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0001B669 File Offset: 0x00019869
		public Type ClrType
		{
			get
			{
				return this.clrType ?? this.node.ClrType;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0001B680 File Offset: 0x00019880
		public bool IsReal
		{
			get
			{
				return this.node.IsReal;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0001B68D File Offset: 0x0001988D
		public bool IsElement
		{
			get
			{
				return this.node.IsElement;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0001B69A File Offset: 0x0001989A
		public bool IsAttribute
		{
			get
			{
				return this.node.IsAttribute;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0001B6A7 File Offset: 0x000198A7
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0001B6B4 File Offset: 0x000198B4
		public bool IsNil
		{
			get
			{
				return this.node.IsNil;
			}
			set
			{
				throw Error.NotSupported();
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0001B6BB File Offset: 0x000198BB
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0001B6C8 File Offset: 0x000198C8
		public string Value
		{
			get
			{
				return this.node.Value;
			}
			set
			{
				this.node.Value = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0001B6D6 File Offset: 0x000198D6
		public string Xml
		{
			get
			{
				return this.node.Xml;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0001B6E3 File Offset: 0x000198E3
		public IXmlNode Parent
		{
			get
			{
				return this.node.Parent;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0001B6F0 File Offset: 0x000198F0
		public IXmlNamespaceSource Namespaces
		{
			get
			{
				return this.node.Namespaces;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0001B6FD File Offset: 0x000198FD
		public object UnderlyingObject
		{
			get
			{
				return this.node.UnderlyingObject;
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0001B70A File Offset: 0x0001990A
		public bool UnderlyingPositionEquals(IXmlNode node)
		{
			return this.node.UnderlyingPositionEquals(node);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0001B718 File Offset: 0x00019918
		public IRealizable<T> AsRealizable<T>()
		{
			return this.node.AsRealizable<T>();
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0001B725 File Offset: 0x00019925
		public void Realize()
		{
			this.node.Realize();
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000B48 RID: 2888 RVA: 0x0001B732 File Offset: 0x00019932
		// (remove) Token: 0x06000B49 RID: 2889 RVA: 0x0001B740 File Offset: 0x00019940
		public event EventHandler Realized
		{
			add
			{
				this.node.Realized += value;
			}
			remove
			{
				this.node.Realized -= value;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0001B74E File Offset: 0x0001994E
		public string GetAttribute(XmlName name)
		{
			return this.node.GetAttribute(name);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0001B75C File Offset: 0x0001995C
		public void SetAttribute(XmlName name, string value)
		{
			this.node.SetAttribute(name, value);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001B76B File Offset: 0x0001996B
		public string LookupPrefix(string namespaceUri)
		{
			return this.node.LookupPrefix(namespaceUri);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0001B779 File Offset: 0x00019979
		public string LookupNamespaceUri(string prefix)
		{
			return this.node.LookupNamespaceUri(prefix);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0001B787 File Offset: 0x00019987
		public void DefineNamespace(string prefix, string namespaceUri, bool root)
		{
			this.node.DefineNamespace(prefix, namespaceUri, root);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0001B798 File Offset: 0x00019998
		public bool MoveNext()
		{
			int num = this.position + 1;
			this.position = num;
			return num == 0;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0001B7B9 File Offset: 0x000199B9
		public void MoveToEnd()
		{
			this.position = 1;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0001B7C2 File Offset: 0x000199C2
		public void Reset()
		{
			this.position = -1;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001B7CB File Offset: 0x000199CB
		public void MoveTo(IXmlNode position)
		{
			if (position != this.node)
			{
				throw Error.NotSupported();
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001B7DC File Offset: 0x000199DC
		public IXmlNode Save()
		{
			if (this.position != 0)
			{
				return this;
			}
			return new XmlSelfCursor(this.node.Save(), this.clrType)
			{
				position = 0
			};
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0001B805 File Offset: 0x00019A05
		public IXmlCursor SelectSelf(Type clrType)
		{
			return new XmlSelfCursor(this.node, clrType);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0001B813 File Offset: 0x00019A13
		public IXmlCursor SelectChildren(IXmlKnownTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags)
		{
			return this.node.SelectChildren(knownTypes, namespaces, flags);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0001B823 File Offset: 0x00019A23
		public IXmlIterator SelectSubtree()
		{
			return this.node.SelectSubtree();
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0001B830 File Offset: 0x00019A30
		public IXmlCursor Select(CompiledXPath path, IXmlIncludedTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags)
		{
			return this.node.Select(path, knownTypes, namespaces, flags);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0001B842 File Offset: 0x00019A42
		public object Evaluate(CompiledXPath path)
		{
			return this.node.Evaluate(path);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0001B850 File Offset: 0x00019A50
		public XmlReader ReadSubtree()
		{
			return this.node.ReadSubtree();
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001B85D File Offset: 0x00019A5D
		public XmlWriter WriteAttributes()
		{
			return this.node.WriteAttributes();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0001B86A File Offset: 0x00019A6A
		public XmlWriter WriteChildren()
		{
			return this.node.WriteChildren();
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001B877 File Offset: 0x00019A77
		public void MakeNext(Type type)
		{
			if (!this.MoveNext())
			{
				throw Error.NotSupported();
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001B887 File Offset: 0x00019A87
		public void Create(Type type)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001B88E File Offset: 0x00019A8E
		public void Coerce(Type type)
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001B890 File Offset: 0x00019A90
		public void Clear()
		{
			this.node.Clear();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001B89D File Offset: 0x00019A9D
		public void Remove()
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001B89F File Offset: 0x00019A9F
		public void RemoveAllNext()
		{
		}

		// Token: 0x04000270 RID: 624
		private readonly IXmlNode node;

		// Token: 0x04000271 RID: 625
		private readonly Type clrType;

		// Token: 0x04000272 RID: 626
		private int position;
	}
}
