using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200014C RID: 332
	public class SetProjection<T> : ListProjection<T>, ISet<T>, ICollection<!0>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x00017671 File Offset: 0x00015871
		public SetProjection(ICollectionAdapter<T> adapter) : base(adapter)
		{
			this.set = new HashSet<T>();
			this.Repopulate();
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0001768B File Offset: 0x0001588B
		public override bool Contains(T item)
		{
			return this.set.Contains(item);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00017699 File Offset: 0x00015899
		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return this.set.IsSubsetOf(other);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000176A7 File Offset: 0x000158A7
		public bool IsSupersetOf(IEnumerable<T> other)
		{
			return this.set.IsSupersetOf(other);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000176B5 File Offset: 0x000158B5
		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			return this.set.IsProperSubsetOf(other);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000176C3 File Offset: 0x000158C3
		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			return this.set.IsProperSupersetOf(other);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000176D1 File Offset: 0x000158D1
		public bool Overlaps(IEnumerable<T> other)
		{
			return this.set.Overlaps(other);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000176DF File Offset: 0x000158DF
		public bool SetEquals(IEnumerable<T> other)
		{
			return this.set.SetEquals(other);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000176F0 File Offset: 0x000158F0
		private void Repopulate()
		{
			base.SuspendEvents();
			int num = base.Count;
			int i = 0;
			while (i < num)
			{
				T item = base[i];
				if (!this.set.Add(item))
				{
					this.RemoveAt(i);
					num--;
				}
				else
				{
					i++;
				}
			}
			base.ResumeEvents();
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00017740 File Offset: 0x00015940
		public override void EndNew(int index)
		{
			if (base.IsNew(index) && this.OnInserting(base[index]))
			{
				base.EndNew(index);
				return;
			}
			this.CancelNew(index);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00017769 File Offset: 0x00015969
		public override bool Add(T item)
		{
			return !this.set.Contains(item) && base.Add(item);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00017782 File Offset: 0x00015982
		protected override bool OnInserting(T value)
		{
			return this.set.Add(value);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00017790 File Offset: 0x00015990
		protected override bool OnReplacing(T oldValue, T newValue)
		{
			if (!this.set.Add(newValue))
			{
				return false;
			}
			this.set.Remove(oldValue);
			return true;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000177B0 File Offset: 0x000159B0
		public override bool Remove(T item)
		{
			return this.set.Remove(item) && base.Remove(item);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000177C9 File Offset: 0x000159C9
		public override void RemoveAt(int index)
		{
			this.set.Remove(base[index]);
			base.RemoveAt(index);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000177E5 File Offset: 0x000159E5
		public override void Clear()
		{
			this.set.Clear();
			base.Clear();
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000177F8 File Offset: 0x000159F8
		public void UnionWith(IEnumerable<T> other)
		{
			foreach (T item in other)
			{
				this.Add(item);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00017844 File Offset: 0x00015A44
		public void ExceptWith(IEnumerable<T> other)
		{
			foreach (T item in other)
			{
				this.Remove(item);
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00017890 File Offset: 0x00015A90
		public void IntersectWith(IEnumerable<T> other)
		{
			T[] other2 = this.set.Except(other).ToArray<T>();
			this.ExceptWith(other2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000178B8 File Offset: 0x00015AB8
		public void SymmetricExceptWith(IEnumerable<T> other)
		{
			T[] array = this.set.Intersect(other).ToArray<T>();
			IEnumerable<T> other2 = other.Except(array);
			this.ExceptWith(array);
			this.UnionWith(other2);
		}

		// Token: 0x04000206 RID: 518
		private readonly HashSet<T> set;
	}
}
