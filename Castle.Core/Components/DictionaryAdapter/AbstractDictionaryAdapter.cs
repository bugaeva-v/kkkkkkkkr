using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000F7 RID: 247
	public abstract class AbstractDictionaryAdapter : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x00012CD6 File Offset: 0x00010ED6
		public void Add(object key, object value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00012CDD File Offset: 0x00010EDD
		public void Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000690 RID: 1680
		public abstract bool Contains(object key);

		// Token: 0x06000691 RID: 1681 RVA: 0x00012CE4 File Offset: 0x00010EE4
		public IDictionaryEnumerator GetEnumerator()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00012CEB File Offset: 0x00010EEB
		public bool IsFixedSize
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000693 RID: 1683
		public abstract bool IsReadOnly { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00012CF2 File Offset: 0x00010EF2
		public ICollection Keys
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00012CF9 File Offset: 0x00010EF9
		public void Remove(object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00012D00 File Offset: 0x00010F00
		public ICollection Values
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170000F9 RID: 249
		public abstract object this[object key]
		{
			get;
			set;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00012D07 File Offset: 0x00010F07
		public void CopyTo(Array array, int index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00012D0E File Offset: 0x00010F0E
		public int Count
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00012D15 File Offset: 0x00010F15
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00012D18 File Offset: 0x00010F18
		public virtual object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00012D1B File Offset: 0x00010F1B
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotSupportedException();
		}
	}
}
