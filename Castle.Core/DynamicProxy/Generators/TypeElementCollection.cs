using System;
using System.Collections;
using System.Collections.Generic;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200004B RID: 75
	public class TypeElementCollection<TElement> : ICollection<TElement>, IEnumerable<TElement>, IEnumerable where TElement : MetaTypeElement, IEquatable<TElement>
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000098C3 File Offset: 0x00007AC3
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000098D0 File Offset: 0x00007AD0
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000098D4 File Offset: 0x00007AD4
		public void Add(TElement item)
		{
			if (!item.CanBeImplementedExplicitly)
			{
				this.items.Add(item);
				return;
			}
			if (this.Contains(item))
			{
				item.SwitchToExplicitImplementation();
				if (this.Contains(item))
				{
					throw new ProxyGenerationException("Duplicate element: " + item);
				}
			}
			this.items.Add(item);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000993C File Offset: 0x00007B3C
		public bool Contains(TElement item)
		{
			using (IEnumerator<TElement> enumerator = this.items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Equals(item))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00009998 File Offset: 0x00007B98
		public IEnumerator<TElement> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000099A5 File Offset: 0x00007BA5
		void ICollection<!0>.Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000099AC File Offset: 0x00007BAC
		void ICollection<!0>.CopyTo(TElement[] array, int arrayIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000099B3 File Offset: 0x00007BB3
		bool ICollection<!0>.Remove(TElement item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000099BA File Offset: 0x00007BBA
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400009F RID: 159
		private readonly ICollection<TElement> items = new List<TElement>();
	}
}
