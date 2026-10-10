using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C7 RID: 455
	public class ChangeEvent<T> : EventBase<ChangeEvent<T>>, IChangeEvent
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0003D0F9 File Offset: 0x0003B2F9
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x0003D101 File Offset: 0x0003B301
		public T previousValue { get; protected set; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0003D10A File Offset: 0x0003B30A
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x0003D112 File Offset: 0x0003B312
		public T newValue { get; protected set; }

		// Token: 0x06000E90 RID: 3728 RVA: 0x0003D11B File Offset: 0x0003B31B
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0003D12C File Offset: 0x0003B32C
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown);
			this.previousValue = default(T);
			this.newValue = default(T);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0003D164 File Offset: 0x0003B364
		public static ChangeEvent<T> GetPooled(T previousValue, T newValue)
		{
			ChangeEvent<T> pooled = EventBase<ChangeEvent<T>>.GetPooled();
			pooled.previousValue = previousValue;
			pooled.newValue = newValue;
			return pooled;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0003D18D File Offset: 0x0003B38D
		public ChangeEvent()
		{
			this.LocalInit();
		}
	}
}
