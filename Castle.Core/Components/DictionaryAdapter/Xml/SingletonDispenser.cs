using System;
using System.Collections.Generic;
using System.Threading;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001AE RID: 430
	public class SingletonDispenser<TKey, TItem> where TItem : class
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x0001FB5D File Offset: 0x0001DD5D
		public SingletonDispenser(Func<TKey, TItem> factory)
		{
			if (factory == null)
			{
				throw Error.ArgumentNull("factory");
			}
			this.locker = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);
			this.items = new Dictionary<TKey, object>();
			this.factory = factory;
		}

		// Token: 0x17000277 RID: 631
		public TItem this[TKey key]
		{
			get
			{
				return this.GetOrCreate(key);
			}
			protected set
			{
				this.items[key] = value;
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		private TItem GetOrCreate(TKey key)
		{
			object obj;
			if (!this.TryGetExistingItem(key, out obj))
			{
				return this.Create(key, obj);
			}
			TItem result;
			if ((result = (obj as TItem)) == null)
			{
				result = this.WaitForCreate(key, obj);
			}
			return result;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		private bool TryGetExistingItem(TKey key, out object item)
		{
			this.locker.EnterReadLock();
			try
			{
				if (this.items.TryGetValue(key, out item))
				{
					return true;
				}
			}
			finally
			{
				this.locker.ExitReadLock();
			}
			this.locker.EnterUpgradeableReadLock();
			bool result;
			try
			{
				if (this.items.TryGetValue(key, out item))
				{
					result = true;
				}
				else
				{
					this.locker.EnterWriteLock();
					try
					{
						Dictionary<TKey, object> dictionary = this.items;
						object value;
						item = (value = new ManualResetEvent(false));
						dictionary[key] = value;
						result = false;
					}
					finally
					{
						this.locker.ExitWriteLock();
					}
				}
			}
			finally
			{
				this.locker.ExitUpgradeableReadLock();
			}
			return result;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		private TItem WaitForCreate(TKey key, object item)
		{
			((ManualResetEvent)item).WaitOne();
			this.locker.EnterReadLock();
			TItem result;
			try
			{
				result = (TItem)((object)this.items[key]);
			}
			finally
			{
				this.locker.ExitReadLock();
			}
			return result;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0001FD08 File Offset: 0x0001DF08
		private TItem Create(TKey key, object item)
		{
			ManualResetEvent manualResetEvent = (ManualResetEvent)item;
			TItem titem = this.factory(key);
			this.locker.EnterWriteLock();
			try
			{
				this.items[key] = titem;
			}
			finally
			{
				this.locker.ExitWriteLock();
			}
			manualResetEvent.Set();
			return titem;
		}

		// Token: 0x040002DF RID: 735
		private readonly ReaderWriterLockSlim locker;

		// Token: 0x040002E0 RID: 736
		private readonly Dictionary<TKey, object> items;

		// Token: 0x040002E1 RID: 737
		private readonly Func<TKey, TItem> factory;
	}
}
