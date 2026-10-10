using System;
using System.Threading;
using System.Threading.Tasks;

namespace Firebase.Platform
{
	// Token: 0x02000010 RID: 16
	internal class MainThreadProperty<T>
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000028EB File Offset: 0x00000AEB
		public MainThreadProperty(Func<T> getPropertyDelegate)
		{
			this.getPropertyDelegate = getPropertyDelegate;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002904 File Offset: 0x00000B04
		public T Value
		{
			get
			{
				Func<T> obj = this.getPropertyDelegate;
				lock (obj)
				{
					bool flag2 = FirebaseHandler.TickCount == this.lastGetPropertyTickCount;
					if (flag2)
					{
						return this.cachedValue;
					}
				}
				Task<T> task = FirebaseHandler.RunOnMainThreadAsync<T>(delegate
				{
					T result = this.getPropertyDelegate();
					Func<T> obj3 = this.getPropertyDelegate;
					lock (obj3)
					{
						this.cachedValue = result;
						this.lastGetPropertyTickCount = FirebaseHandler.TickCount;
					}
					return result;
				});
				int num = 0;
				while (!task.IsCompleted && !task.IsFaulted && !task.IsCanceled && num < 100)
				{
					Thread.Sleep(1);
					num++;
				}
				bool isFaulted = task.IsFaulted;
				if (isFaulted)
				{
					throw task.Exception;
				}
				bool flag3 = !task.IsCompleted || task.IsCanceled;
				if (flag3)
				{
					Func<T> obj2 = this.getPropertyDelegate;
					lock (obj2)
					{
						this.lastGetPropertyTickCount = FirebaseHandler.TickCount;
						return this.cachedValue;
					}
				}
				return task.Result;
			}
		}

		// Token: 0x04000017 RID: 23
		private Func<T> getPropertyDelegate;

		// Token: 0x04000018 RID: 24
		private int lastGetPropertyTickCount = -1;

		// Token: 0x04000019 RID: 25
		private T cachedValue;
	}
}
