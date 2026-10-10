using System;
using System.Collections.Generic;
using System.Threading;

namespace Castle.Core.Internal
{
	// Token: 0x020000EC RID: 236
	internal sealed class SynchronizedDictionary<TKey, TValue> : IDisposable
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x0001238F File Offset: 0x0001058F
		public SynchronizedDictionary()
		{
			this.items = new Dictionary<TKey, TValue>();
			this.itemsLock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000123AE File Offset: 0x000105AE
		[Obsolete]
		public ReaderWriterLockSlim Lock
		{
			get
			{
				return this.itemsLock;
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000123B6 File Offset: 0x000105B6
		public void AddOrUpdateWithoutTakingLock(TKey key, TValue value)
		{
			this.items[key] = value;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000123C5 File Offset: 0x000105C5
		public void Dispose()
		{
			this.itemsLock.Dispose();
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000123D4 File Offset: 0x000105D4
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			this.itemsLock.EnterReadLock();
			try
			{
				TValue tvalue;
				if (this.items.TryGetValue(key, out tvalue))
				{
					return tvalue;
				}
			}
			finally
			{
				this.itemsLock.ExitReadLock();
			}
			this.itemsLock.EnterUpgradeableReadLock();
			TValue result;
			try
			{
				TValue tvalue;
				if (this.items.TryGetValue(key, out tvalue))
				{
					result = tvalue;
				}
				else
				{
					tvalue = valueFactory(key);
					this.itemsLock.EnterWriteLock();
					try
					{
						this.items.Add(key, tvalue);
						result = tvalue;
					}
					finally
					{
						this.itemsLock.ExitWriteLock();
					}
				}
			}
			finally
			{
				this.itemsLock.ExitUpgradeableReadLock();
			}
			return result;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00012494 File Offset: 0x00010694
		public TValue GetOrAddWithoutTakingLock(TKey key, Func<TKey, TValue> valueFactory)
		{
			TValue tvalue;
			if (this.items.TryGetValue(key, out tvalue))
			{
				return tvalue;
			}
			tvalue = valueFactory(key);
			this.items.Add(key, tvalue);
			return tvalue;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000124CC File Offset: 0x000106CC
		public void ForEach(Action<TKey, TValue> action)
		{
			this.itemsLock.EnterReadLock();
			try
			{
				foreach (KeyValuePair<TKey, TValue> keyValuePair in this.items)
				{
					action(keyValuePair.Key, keyValuePair.Value);
				}
			}
			finally
			{
				this.itemsLock.ExitReadLock();
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00012550 File Offset: 0x00010750
		[Obsolete]
		public bool TryGetValueWithoutTakingLock(TKey key, out TValue value)
		{
			return this.items.TryGetValue(key, out value);
		}

		// Token: 0x04000181 RID: 385
		private Dictionary<TKey, TValue> items;

		// Token: 0x04000182 RID: 386
		private ReaderWriterLockSlim itemsLock;
	}
}
