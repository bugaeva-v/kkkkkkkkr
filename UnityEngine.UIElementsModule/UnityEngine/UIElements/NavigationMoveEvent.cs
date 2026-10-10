using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000209 RID: 521
	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x00041734 File Offset: 0x0003F934
		internal static NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
		{
			bool flag = new Vector2(x, y).sqrMagnitude < deadZone * deadZone;
			NavigationMoveEvent.Direction result;
			if (flag)
			{
				result = NavigationMoveEvent.Direction.None;
			}
			else
			{
				bool flag2 = Mathf.Abs(x) > Mathf.Abs(y);
				if (flag2)
				{
					bool flag3 = x > 0f;
					if (flag3)
					{
						result = NavigationMoveEvent.Direction.Right;
					}
					else
					{
						result = NavigationMoveEvent.Direction.Left;
					}
				}
				else
				{
					bool flag4 = y > 0f;
					if (flag4)
					{
						result = NavigationMoveEvent.Direction.Up;
					}
					else
					{
						result = NavigationMoveEvent.Direction.Down;
					}
				}
			}
			return result;
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004179F File Offset: 0x0003F99F
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x000417A7 File Offset: 0x0003F9A7
		public NavigationMoveEvent.Direction direction { get; private set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000417B0 File Offset: 0x0003F9B0
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000417B8 File Offset: 0x0003F9B8
		public Vector2 move { get; private set; }

		// Token: 0x0600102A RID: 4138 RVA: 0x000417C4 File Offset: 0x0003F9C4
		public static NavigationMoveEvent GetPooled(Vector2 moveVector)
		{
			NavigationMoveEvent pooled = EventBase<NavigationMoveEvent>.GetPooled();
			pooled.direction = NavigationMoveEvent.DetermineMoveDirection(moveVector.x, moveVector.y, 0.6f);
			pooled.move = moveVector;
			return pooled;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00041804 File Offset: 0x0003FA04
		internal static NavigationMoveEvent GetPooled(NavigationMoveEvent.Direction direction)
		{
			NavigationMoveEvent pooled = EventBase<NavigationMoveEvent>.GetPooled();
			pooled.direction = direction;
			pooled.move = Vector2.zero;
			return pooled;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00041831 File Offset: 0x0003FA31
		protected override void Init()
		{
			base.Init();
			this.direction = NavigationMoveEvent.Direction.None;
			this.move = Vector2.zero;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004184F File Offset: 0x0003FA4F
		public NavigationMoveEvent()
		{
			this.Init();
		}

		// Token: 0x0200020A RID: 522
		public enum Direction
		{
			// Token: 0x04000731 RID: 1841
			None,
			// Token: 0x04000732 RID: 1842
			Left,
			// Token: 0x04000733 RID: 1843
			Up,
			// Token: 0x04000734 RID: 1844
			Right,
			// Token: 0x04000735 RID: 1845
			Down
		}
	}
}
