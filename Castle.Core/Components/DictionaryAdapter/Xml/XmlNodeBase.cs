using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000177 RID: 375
	public abstract class XmlNodeBase : IRealizableSource, IVirtual
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x0001B51A File Offset: 0x0001971A
		protected XmlNodeBase(IXmlNamespaceSource namespaces, IXmlNode parent)
		{
			if (namespaces == null)
			{
				throw Error.ArgumentNull("namespaces");
			}
			this.namespaces = namespaces;
			this.parent = parent;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0001B53E File Offset: 0x0001973E
		public virtual bool IsReal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0001B541 File Offset: 0x00019741
		public virtual Type ClrType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0001B549 File Offset: 0x00019749
		public IXmlNode Parent
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0001B551 File Offset: 0x00019751
		public IXmlNamespaceSource Namespaces
		{
			get
			{
				return this.namespaces;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0001B559 File Offset: 0x00019759
		public virtual CompiledXPath Path
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0001B55C File Offset: 0x0001975C
		IRealizable<T> IRealizableSource.AsRealizable<T>()
		{
			return this as IRealizable<T>;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001B564 File Offset: 0x00019764
		protected virtual void Realize()
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001B566 File Offset: 0x00019766
		void IVirtual.Realize()
		{
			this.Realize();
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000B2F RID: 2863 RVA: 0x0001B56E File Offset: 0x0001976E
		// (remove) Token: 0x06000B30 RID: 2864 RVA: 0x0001B570 File Offset: 0x00019770
		public virtual event EventHandler Realized
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x0400026C RID: 620
		protected Type type;

		// Token: 0x0400026D RID: 621
		private readonly IXmlNode parent;

		// Token: 0x0400026E RID: 622
		private readonly IXmlNamespaceSource namespaces;
	}
}
