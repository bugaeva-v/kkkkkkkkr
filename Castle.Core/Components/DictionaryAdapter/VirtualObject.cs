using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200014D RID: 333
	public abstract class VirtualObject<TNode> : IVirtual<TNode>, IVirtual
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x000178ED File Offset: 0x00015AED
		protected VirtualObject()
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000178F5 File Offset: 0x00015AF5
		protected VirtualObject(IVirtualSite<TNode> site)
		{
			this.sites = new List<IVirtualSite<TNode>>
			{
				site
			};
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000964 RID: 2404
		public abstract bool IsReal { get; }

		// Token: 0x06000965 RID: 2405 RVA: 0x0001790F File Offset: 0x00015B0F
		protected void AddSite(IVirtualSite<TNode> site)
		{
			if (this.sites != null)
			{
				this.sites.Add(site);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00017925 File Offset: 0x00015B25
		void IVirtual<!0>.AddSite(IVirtualSite<TNode> site)
		{
			this.AddSite(site);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00017930 File Offset: 0x00015B30
		protected void RemoveSite(IVirtualSite<TNode> site)
		{
			if (this.sites != null)
			{
				int num = this.sites.IndexOf(site);
				if (num != -1)
				{
					this.sites.RemoveAt(num);
				}
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00017962 File Offset: 0x00015B62
		void IVirtual<!0>.RemoveSite(IVirtualSite<TNode> site)
		{
			this.RemoveSite(site);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0001796C File Offset: 0x00015B6C
		public TNode Realize()
		{
			TNode tnode;
			if (this.TryRealize(out tnode))
			{
				if (this.sites != null)
				{
					int count = this.sites.Count;
					for (int i = 0; i < count; i++)
					{
						this.sites[i].OnRealizing(tnode);
					}
					this.sites = null;
				}
				this.OnRealized();
			}
			return tnode;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000179C3 File Offset: 0x00015BC3
		void IVirtual.Realize()
		{
			this.Realize();
		}

		// Token: 0x0600096B RID: 2411
		protected abstract bool TryRealize(out TNode node);

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600096C RID: 2412 RVA: 0x000179CC File Offset: 0x00015BCC
		// (remove) Token: 0x0600096D RID: 2413 RVA: 0x00017A04 File Offset: 0x00015C04
		public event EventHandler Realized;

		// Token: 0x0600096E RID: 2414 RVA: 0x00017A3C File Offset: 0x00015C3C
		protected virtual void OnRealized()
		{
			EventHandler realized = this.Realized;
			if (realized != null)
			{
				realized(this, EventArgs.Empty);
				this.Realized = null;
			}
		}

		// Token: 0x04000207 RID: 519
		private List<IVirtualSite<TNode>> sites;
	}
}
