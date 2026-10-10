using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020B RID: 523
	internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent>
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00041860 File Offset: 0x0003FA60
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x00041868 File Offset: 0x0003FA68
		public NavigationTabEvent.Direction direction { get; private set; }

		// Token: 0x06001030 RID: 4144 RVA: 0x00041874 File Offset: 0x0003FA74
		internal static NavigationTabEvent.Direction DetermineMoveDirection(int moveValue)
		{
			return (moveValue > 0) ? NavigationTabEvent.Direction.Next : ((moveValue < 0) ? NavigationTabEvent.Direction.Previous : NavigationTabEvent.Direction.None);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00041898 File Offset: 0x0003FA98
		public static NavigationTabEvent GetPooled(int moveValue)
		{
			NavigationTabEvent pooled = EventBase<NavigationTabEvent>.GetPooled();
			pooled.direction = NavigationTabEvent.DetermineMoveDirection(moveValue);
			return pooled;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000418BE File Offset: 0x0003FABE
		protected override void Init()
		{
			base.Init();
			this.direction = NavigationTabEvent.Direction.None;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000418D0 File Offset: 0x0003FAD0
		public NavigationTabEvent()
		{
			this.Init();
		}

		// Token: 0x0200020C RID: 524
		public enum Direction
		{
			// Token: 0x04000738 RID: 1848
			None,
			// Token: 0x04000739 RID: 1849
			Next,
			// Token: 0x0400073A RID: 1850
			Previous
		}
	}
}
