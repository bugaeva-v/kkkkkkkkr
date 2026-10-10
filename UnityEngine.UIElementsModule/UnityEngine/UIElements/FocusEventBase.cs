using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E2 RID: 482
	public abstract class FocusEventBase<T> : EventBase<T>, IFocusEvent where T : FocusEventBase<T>, new()
	{
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0003F3A8 File Offset: 0x0003D5A8
		public Focusable relatedTarget { get; private set; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0003F3B1 File Offset: 0x0003D5B1
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0003F3B9 File Offset: 0x0003D5B9
		public FocusChangeDirection direction { get; private set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0003F3C2 File Offset: 0x0003D5C2
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x0003F3CA File Offset: 0x0003D5CA
		private protected FocusController focusController { protected get; private set; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0003F3D3 File Offset: 0x0003D5D3
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x0003F3DB File Offset: 0x0003D5DB
		internal bool IsFocusDelegated { get; private set; }

		// Token: 0x06000F5A RID: 3930 RVA: 0x0003F3E4 File Offset: 0x0003D5E4
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0003F3F5 File Offset: 0x0003D5F5
		private void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.TricklesDown;
			this.relatedTarget = null;
			this.direction = FocusChangeDirection.unspecified;
			this.focusController = null;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0003F41C File Offset: 0x0003D61C
		public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.target = target;
			pooled.relatedTarget = relatedTarget;
			pooled.direction = direction;
			pooled.focusController = focusController;
			pooled.IsFocusDelegated = bIsFocusDelegated;
			return pooled;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0003F477 File Offset: 0x0003D677
		protected FocusEventBase()
		{
			this.LocalInit();
		}
	}
}
