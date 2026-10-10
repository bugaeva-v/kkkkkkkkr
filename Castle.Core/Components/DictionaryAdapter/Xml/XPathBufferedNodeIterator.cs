using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000181 RID: 385
	internal class XPathBufferedNodeIterator : XPathNodeIterator
	{
		// Token: 0x06000BF2 RID: 3058 RVA: 0x0001CDAD File Offset: 0x0001AFAD
		public XPathBufferedNodeIterator(XPathNodeIterator iterator)
		{
			this.items = new List<XPathNavigator>();
			do
			{
				this.items.Add(iterator.Current.Clone());
			}
			while (iterator.MoveNext());
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0001CDDE File Offset: 0x0001AFDE
		private XPathBufferedNodeIterator(XPathBufferedNodeIterator iterator)
		{
			this.items = iterator.items;
			this.index = iterator.index;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0001CDFE File Offset: 0x0001AFFE
		public override int CurrentPosition
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0001CE06 File Offset: 0x0001B006
		public override int Count
		{
			get
			{
				return this.items.Count - 1;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0001CE15 File Offset: 0x0001B015
		public bool IsEmpty
		{
			get
			{
				return this.items.Count == 1;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0001CE25 File Offset: 0x0001B025
		public override XPathNavigator Current
		{
			get
			{
				return this.items[this.index];
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0001CE38 File Offset: 0x0001B038
		public void Reset()
		{
			this.index = 0;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0001CE44 File Offset: 0x0001B044
		public override bool MoveNext()
		{
			int num = this.index + 1;
			this.index = num;
			if (num < this.items.Count)
			{
				return true;
			}
			if (this.index > this.items.Count)
			{
				this.index--;
			}
			return false;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0001CE93 File Offset: 0x0001B093
		public void MoveToEnd()
		{
			this.index = this.items.Count;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0001CEA6 File Offset: 0x0001B0A6
		public override XPathNodeIterator Clone()
		{
			return new XPathBufferedNodeIterator(this);
		}

		// Token: 0x04000287 RID: 647
		private readonly IList<XPathNavigator> items;

		// Token: 0x04000288 RID: 648
		private int index;
	}
}
