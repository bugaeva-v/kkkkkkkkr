using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EB RID: 491
	public class InputEvent : EventBase<InputEvent>
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0003F9C1 File Offset: 0x0003DBC1
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0003F9C9 File Offset: 0x0003DBC9
		public string previousData { get; protected set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0003F9D2 File Offset: 0x0003DBD2
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0003F9DA File Offset: 0x0003DBDA
		public string newData { get; protected set; }

		// Token: 0x06000F74 RID: 3956 RVA: 0x0003F9E3 File Offset: 0x0003DBE3
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0003F9F4 File Offset: 0x0003DBF4
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown);
			this.previousData = null;
			this.newData = null;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0003FA10 File Offset: 0x0003DC10
		public static InputEvent GetPooled(string previousData, string newData)
		{
			InputEvent pooled = EventBase<InputEvent>.GetPooled();
			pooled.previousData = previousData;
			pooled.newData = newData;
			return pooled;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0003FA39 File Offset: 0x0003DC39
		public InputEvent()
		{
			this.LocalInit();
		}
	}
}
