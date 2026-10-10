using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000214 RID: 532
	internal static class PointerDeviceState
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x00041B48 File Offset: 0x0003FD48
		internal static void Reset()
		{
			for (int i = 0; i < PointerId.maxPointers; i++)
			{
				PointerDeviceState.s_PlayerPointerLocations[i].SetLocation(Vector2.zero, null);
				PointerDeviceState.s_PressedButtons[i] = 0;
				PointerDeviceState.s_PlayerPanelWithSoftPointerCapture[i] = null;
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00041B94 File Offset: 0x0003FD94
		internal static void RemovePanelData(IPanel panel)
		{
			for (int i = 0; i < PointerId.maxPointers; i++)
			{
				bool flag = PointerDeviceState.s_PlayerPointerLocations[i].Panel == panel;
				if (flag)
				{
					PointerDeviceState.s_PlayerPointerLocations[i].SetLocation(Vector2.zero, null);
				}
				bool flag2 = PointerDeviceState.s_PlayerPanelWithSoftPointerCapture[i] == panel;
				if (flag2)
				{
					PointerDeviceState.s_PlayerPanelWithSoftPointerCapture[i] = null;
				}
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00041BFC File Offset: 0x0003FDFC
		public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType)
		{
			if (contextType > ContextType.Editor)
			{
			}
			PointerDeviceState.s_PlayerPointerLocations[pointerId].SetLocation(position, panel);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00041C29 File Offset: 0x0003FE29
		public static void PressButton(int pointerId, int buttonId)
		{
			Debug.Assert(buttonId >= 0);
			Debug.Assert(buttonId < 32);
			PointerDeviceState.s_PressedButtons[pointerId] |= 1 << buttonId;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00041C59 File Offset: 0x0003FE59
		public static void ReleaseButton(int pointerId, int buttonId)
		{
			Debug.Assert(buttonId >= 0);
			Debug.Assert(buttonId < 32);
			PointerDeviceState.s_PressedButtons[pointerId] &= ~(1 << buttonId);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00041C8A File Offset: 0x0003FE8A
		public static void ReleaseAllButtons(int pointerId)
		{
			PointerDeviceState.s_PressedButtons[pointerId] = 0;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00041C98 File Offset: 0x0003FE98
		public static Vector2 GetPointerPosition(int pointerId, ContextType contextType)
		{
			if (contextType > ContextType.Editor)
			{
			}
			return PointerDeviceState.s_PlayerPointerLocations[pointerId].Position;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00041CC4 File Offset: 0x0003FEC4
		public static IPanel GetPanel(int pointerId, ContextType contextType)
		{
			if (contextType > ContextType.Editor)
			{
			}
			return PointerDeviceState.s_PlayerPointerLocations[pointerId].Panel;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00041CF0 File Offset: 0x0003FEF0
		private static bool HasFlagFast(PointerDeviceState.LocationFlag flagSet, PointerDeviceState.LocationFlag flag)
		{
			return (flagSet & flag) == flag;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00041D08 File Offset: 0x0003FF08
		public static bool HasLocationFlag(int pointerId, ContextType contextType, PointerDeviceState.LocationFlag flag)
		{
			if (contextType > ContextType.Editor)
			{
			}
			return PointerDeviceState.HasFlagFast(PointerDeviceState.s_PlayerPointerLocations[pointerId].Flags, flag);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00041D3C File Offset: 0x0003FF3C
		public static int GetPressedButtons(int pointerId)
		{
			return PointerDeviceState.s_PressedButtons[pointerId];
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00041D58 File Offset: 0x0003FF58
		internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
		{
			return (PointerDeviceState.s_PressedButtons[pointerId] & ~(1 << exceptButtonId)) != 0;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00041D7C File Offset: 0x0003FF7C
		internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel)
		{
			PointerDeviceState.s_PlayerPanelWithSoftPointerCapture[pointerId] = panel;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00041D88 File Offset: 0x0003FF88
		internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId)
		{
			return PointerDeviceState.s_PlayerPanelWithSoftPointerCapture[pointerId];
		}

		// Token: 0x0400073D RID: 1853
		private static PointerDeviceState.PointerLocation[] s_PlayerPointerLocations = new PointerDeviceState.PointerLocation[PointerId.maxPointers];

		// Token: 0x0400073E RID: 1854
		private static int[] s_PressedButtons = new int[PointerId.maxPointers];

		// Token: 0x0400073F RID: 1855
		private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture = new IPanel[PointerId.maxPointers];

		// Token: 0x02000215 RID: 533
		[Flags]
		internal enum LocationFlag
		{
			// Token: 0x04000741 RID: 1857
			None = 0,
			// Token: 0x04000742 RID: 1858
			OutsidePanel = 1
		}

		// Token: 0x02000216 RID: 534
		private struct PointerLocation
		{
			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06001052 RID: 4178 RVA: 0x00041DD0 File Offset: 0x0003FFD0
			// (set) Token: 0x06001053 RID: 4179 RVA: 0x00041DD8 File Offset: 0x0003FFD8
			internal Vector2 Position { readonly get; private set; }

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06001054 RID: 4180 RVA: 0x00041DE1 File Offset: 0x0003FFE1
			// (set) Token: 0x06001055 RID: 4181 RVA: 0x00041DE9 File Offset: 0x0003FFE9
			internal IPanel Panel { readonly get; private set; }

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06001056 RID: 4182 RVA: 0x00041DF2 File Offset: 0x0003FFF2
			// (set) Token: 0x06001057 RID: 4183 RVA: 0x00041DFA File Offset: 0x0003FFFA
			internal PointerDeviceState.LocationFlag Flags { readonly get; private set; }

			// Token: 0x06001058 RID: 4184 RVA: 0x00041E04 File Offset: 0x00040004
			internal void SetLocation(Vector2 position, IPanel panel)
			{
				this.Position = position;
				this.Panel = panel;
				this.Flags = PointerDeviceState.LocationFlag.None;
				bool flag = panel == null || !panel.visualTree.layout.Contains(position);
				if (flag)
				{
					this.Flags |= PointerDeviceState.LocationFlag.OutsidePanel;
				}
			}
		}
	}
}
