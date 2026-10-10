using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000069 RID: 105
	internal abstract class ScheduledItem
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000AC60 File Offset: 0x00008E60
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000AC68 File Offset: 0x00008E68
		public long startMs { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000AC71 File Offset: 0x00008E71
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000AC79 File Offset: 0x00008E79
		public long delayMs { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000AC82 File Offset: 0x00008E82
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0000AC8A File Offset: 0x00008E8A
		public long intervalMs { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000AC93 File Offset: 0x00008E93
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000AC9B File Offset: 0x00008E9B
		public long endTimeMs { get; private set; }

		// Token: 0x060002FC RID: 764 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		public ScheduledItem()
		{
			this.ResetStartTime();
			this.timerUpdateStopCondition = ScheduledItem.OnceCondition;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		protected void ResetStartTime()
		{
			this.startMs = Panel.TimeSinceStartupMs();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000ACCF File Offset: 0x00008ECF
		public void SetDuration(long durationMs)
		{
			this.endTimeMs = this.startMs + durationMs;
		}

		// Token: 0x060002FF RID: 767
		public abstract void PerformTimerUpdate(TimerState state);

		// Token: 0x06000300 RID: 768 RVA: 0x00002166 File Offset: 0x00000366
		internal virtual void OnItemUnscheduled()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		public virtual bool ShouldUnschedule()
		{
			bool flag = this.timerUpdateStopCondition != null;
			return flag && this.timerUpdateStopCondition();
		}

		// Token: 0x04000154 RID: 340
		public Func<bool> timerUpdateStopCondition;

		// Token: 0x04000155 RID: 341
		public static readonly Func<bool> OnceCondition = () => true;

		// Token: 0x04000156 RID: 342
		public static readonly Func<bool> ForeverCondition = () => false;
	}
}
