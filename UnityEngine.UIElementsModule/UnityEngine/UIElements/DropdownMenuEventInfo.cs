using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000020 RID: 32
	public class DropdownMenuEventInfo
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004FE3 File Offset: 0x000031E3
		public EventModifiers modifiers { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004FEB File Offset: 0x000031EB
		public Vector2 mousePosition { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004FF3 File Offset: 0x000031F3
		public Vector2 localMousePosition { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00004FFB File Offset: 0x000031FB
		private char character { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005003 File Offset: 0x00003203
		private KeyCode keyCode { get; }

		// Token: 0x060000DD RID: 221 RVA: 0x0000500C File Offset: 0x0000320C
		public DropdownMenuEventInfo(EventBase e)
		{
			IMouseEvent mouseEvent = e as IMouseEvent;
			bool flag = mouseEvent != null;
			if (flag)
			{
				this.mousePosition = mouseEvent.mousePosition;
				this.localMousePosition = mouseEvent.localMousePosition;
				this.modifiers = mouseEvent.modifiers;
				this.character = 0;
				this.keyCode = 0;
			}
			else
			{
				IKeyboardEvent keyboardEvent = e as IKeyboardEvent;
				bool flag2 = keyboardEvent != null;
				if (flag2)
				{
					this.character = keyboardEvent.character;
					this.keyCode = keyboardEvent.keyCode;
					this.modifiers = keyboardEvent.modifiers;
					this.mousePosition = Vector2.zero;
					this.localMousePosition = Vector2.zero;
				}
			}
		}
	}
}
