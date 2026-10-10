using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F1 RID: 497
	public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x0003FD7C File Offset: 0x0003DF7C
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
		{
			GeometryChangedEvent pooled = EventBase<GeometryChangedEvent>.GetPooled();
			pooled.oldRect = oldRect;
			pooled.newRect = newRect;
			return pooled;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0003FDA5 File Offset: 0x0003DFA5
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0003FDB6 File Offset: 0x0003DFB6
		private void LocalInit()
		{
			this.oldRect = Rect.zero;
			this.newRect = Rect.zero;
			this.layoutPass = 0;
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0003FDD9 File Offset: 0x0003DFD9
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x0003FDE1 File Offset: 0x0003DFE1
		public Rect oldRect { get; private set; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x0003FDEA File Offset: 0x0003DFEA
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x0003FDF2 File Offset: 0x0003DFF2
		public Rect newRect { get; private set; }

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0003FDFB File Offset: 0x0003DFFB
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x0003FE03 File Offset: 0x0003E003
		internal int layoutPass { get; set; }

		// Token: 0x06000F9F RID: 3999 RVA: 0x0003FE0C File Offset: 0x0003E00C
		public GeometryChangedEvent()
		{
			this.LocalInit();
		}
	}
}
