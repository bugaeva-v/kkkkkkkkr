using System;
using System.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x02000384 RID: 900
	public class ObjectPool<T> : IDisposable, IObjectPool<T> where T : class
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00031E31 File Offset: 0x00030031
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x00031E39 File Offset: 0x00030039
		public int CountAll { get; private set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00031E44 File Offset: 0x00030044
		public int CountActive
		{
			get
			{
				return this.CountAll - this.CountInactive;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00031E64 File Offset: 0x00030064
		public int CountInactive
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00031E84 File Offset: 0x00030084
		public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
		{
			bool flag = createFunc == null;
			if (flag)
			{
				throw new ArgumentNullException("createFunc");
			}
			bool flag2 = maxSize <= 0;
			if (flag2)
			{
				throw new ArgumentException("Max Size must be greater than 0", "maxSize");
			}
			this.m_List = new List<T>(defaultCapacity);
			this.m_CreateFunc = createFunc;
			this.m_MaxSize = maxSize;
			this.m_ActionOnGet = actionOnGet;
			this.m_ActionOnRelease = actionOnRelease;
			this.m_ActionOnDestroy = actionOnDestroy;
			this.m_CollectionCheck = collectionCheck;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00031F04 File Offset: 0x00030104
		public T Get()
		{
			bool flag = this.m_List.Count == 0;
			T t;
			if (flag)
			{
				t = this.m_CreateFunc();
				int countAll = this.CountAll;
				this.CountAll = countAll + 1;
			}
			else
			{
				int index = this.m_List.Count - 1;
				t = this.m_List[index];
				this.m_List.RemoveAt(index);
			}
			Action<T> actionOnGet = this.m_ActionOnGet;
			if (actionOnGet != null)
			{
				actionOnGet(t);
			}
			return t;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00031F8C File Offset: 0x0003018C
		public PooledObject<T> Get(out T v)
		{
			return new PooledObject<T>(v = this.Get(), this);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00031FB0 File Offset: 0x000301B0
		public void Release(T element)
		{
			Action<T> actionOnRelease = this.m_ActionOnRelease;
			if (actionOnRelease != null)
			{
				actionOnRelease(element);
			}
			bool flag = this.CountInactive < this.m_MaxSize;
			if (flag)
			{
				this.m_List.Add(element);
			}
			else
			{
				int countAll = this.CountAll;
				this.CountAll = countAll - 1;
				Action<T> actionOnDestroy = this.m_ActionOnDestroy;
				if (actionOnDestroy != null)
				{
					actionOnDestroy(element);
				}
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0003201C File Offset: 0x0003021C
		public void Clear()
		{
			bool flag = this.m_ActionOnDestroy != null;
			if (flag)
			{
				foreach (T obj in this.m_List)
				{
					this.m_ActionOnDestroy(obj);
				}
			}
			this.m_List.Clear();
			this.CountAll = 0;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000320A0 File Offset: 0x000302A0
		public void Dispose()
		{
			this.Clear();
		}

		// Token: 0x04000A12 RID: 2578
		internal readonly List<T> m_List;

		// Token: 0x04000A13 RID: 2579
		private readonly Func<T> m_CreateFunc;

		// Token: 0x04000A14 RID: 2580
		private readonly Action<T> m_ActionOnGet;

		// Token: 0x04000A15 RID: 2581
		private readonly Action<T> m_ActionOnRelease;

		// Token: 0x04000A16 RID: 2582
		private readonly Action<T> m_ActionOnDestroy;

		// Token: 0x04000A17 RID: 2583
		private readonly int m_MaxSize;

		// Token: 0x04000A18 RID: 2584
		internal bool m_CollectionCheck;
	}
}
