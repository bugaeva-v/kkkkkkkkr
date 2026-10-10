using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023F RID: 575
	[Serializable]
	internal class EventDebuggerEventRecord
	{
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00044F86 File Offset: 0x00043186
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x00044F8E File Offset: 0x0004318E
		public string eventBaseName { get; private set; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00044F97 File Offset: 0x00043197
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00044F9F File Offset: 0x0004319F
		public long eventTypeId { get; private set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00044FA8 File Offset: 0x000431A8
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00044FB0 File Offset: 0x000431B0
		public ulong eventId { get; private set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00044FB9 File Offset: 0x000431B9
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x00044FC1 File Offset: 0x000431C1
		private ulong triggerEventId { get; set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00044FCA File Offset: 0x000431CA
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x00044FD2 File Offset: 0x000431D2
		internal long timestamp { get; private set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x00044FDB File Offset: 0x000431DB
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x00044FE3 File Offset: 0x000431E3
		public IEventHandler target { get; set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x00044FEC File Offset: 0x000431EC
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x00044FF4 File Offset: 0x000431F4
		private List<IEventHandler> skipElements { get; set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00044FFD File Offset: 0x000431FD
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00045005 File Offset: 0x00043205
		public bool hasUnderlyingPhysicalEvent { get; private set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0004500E File Offset: 0x0004320E
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x00045016 File Offset: 0x00043216
		private bool isPropagationStopped { get; set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0004501F File Offset: 0x0004321F
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x00045027 File Offset: 0x00043227
		private bool isImmediatePropagationStopped { get; set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x00045030 File Offset: 0x00043230
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x00045038 File Offset: 0x00043238
		private bool isDefaultPrevented { get; set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00045041 File Offset: 0x00043241
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x00045049 File Offset: 0x00043249
		public PropagationPhase propagationPhase { get; private set; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00045052 File Offset: 0x00043252
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0004505A File Offset: 0x0004325A
		private IEventHandler currentTarget { get; set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00045063 File Offset: 0x00043263
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0004506B File Offset: 0x0004326B
		private bool dispatch { get; set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00045074 File Offset: 0x00043274
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0004507C File Offset: 0x0004327C
		private Vector2 originalMousePosition { get; set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x00045085 File Offset: 0x00043285
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0004508D File Offset: 0x0004328D
		public EventModifiers modifiers { get; private set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00045096 File Offset: 0x00043296
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0004509E File Offset: 0x0004329E
		public Vector2 mousePosition { get; private set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000450A7 File Offset: 0x000432A7
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x000450AF File Offset: 0x000432AF
		public int clickCount { get; private set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x000450B8 File Offset: 0x000432B8
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x000450C0 File Offset: 0x000432C0
		public int button { get; private set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x000450C9 File Offset: 0x000432C9
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x000450D1 File Offset: 0x000432D1
		public int pressedButtons { get; private set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000450DA File Offset: 0x000432DA
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x000450E2 File Offset: 0x000432E2
		public Vector3 delta { get; private set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x000450EB File Offset: 0x000432EB
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x000450F3 File Offset: 0x000432F3
		public char character { get; private set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000450FC File Offset: 0x000432FC
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x00045104 File Offset: 0x00043304
		public KeyCode keyCode { get; private set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0004510D File Offset: 0x0004330D
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x00045115 File Offset: 0x00043315
		public string commandName { get; private set; }

		// Token: 0x0600117B RID: 4475 RVA: 0x00045120 File Offset: 0x00043320
		private void Init(EventBase evt)
		{
			Type type = evt.GetType();
			this.eventBaseName = EventDebugger.GetTypeDisplayName(type);
			this.eventTypeId = evt.eventTypeId;
			this.eventId = evt.eventId;
			this.triggerEventId = evt.triggerEventId;
			this.timestamp = evt.timestamp;
			this.target = evt.target;
			this.skipElements = evt.skipElements;
			this.isPropagationStopped = evt.isPropagationStopped;
			this.isImmediatePropagationStopped = evt.isImmediatePropagationStopped;
			this.isDefaultPrevented = evt.isDefaultPrevented;
			IMouseEvent mouseEvent = evt as IMouseEvent;
			IMouseEventInternal mouseEventInternal = evt as IMouseEventInternal;
			this.hasUnderlyingPhysicalEvent = (mouseEvent != null && mouseEventInternal != null && mouseEventInternal.triggeredByOS);
			this.propagationPhase = evt.propagationPhase;
			this.originalMousePosition = evt.originalMousePosition;
			this.currentTarget = evt.currentTarget;
			this.dispatch = evt.dispatch;
			bool flag = mouseEvent != null;
			if (flag)
			{
				this.modifiers = mouseEvent.modifiers;
				this.mousePosition = mouseEvent.mousePosition;
				this.button = mouseEvent.button;
				this.pressedButtons = mouseEvent.pressedButtons;
				this.clickCount = mouseEvent.clickCount;
				WheelEvent wheelEvent = mouseEvent as WheelEvent;
				bool flag2 = wheelEvent != null;
				if (flag2)
				{
					this.delta = wheelEvent.delta;
				}
			}
			IPointerEvent pointerEvent = evt as IPointerEvent;
			bool flag3 = pointerEvent != null;
			if (flag3)
			{
				IPointerEventInternal pointerEventInternal = evt as IPointerEventInternal;
				this.hasUnderlyingPhysicalEvent = (pointerEvent != null && pointerEventInternal != null && pointerEventInternal.triggeredByOS);
				this.modifiers = pointerEvent.modifiers;
				this.mousePosition = pointerEvent.position;
				this.button = pointerEvent.button;
				this.pressedButtons = pointerEvent.pressedButtons;
				this.clickCount = pointerEvent.clickCount;
			}
			IKeyboardEvent keyboardEvent = evt as IKeyboardEvent;
			bool flag4 = keyboardEvent != null;
			if (flag4)
			{
				this.modifiers = keyboardEvent.modifiers;
				this.character = keyboardEvent.character;
				this.keyCode = keyboardEvent.keyCode;
			}
			ICommandEvent commandEvent = evt as ICommandEvent;
			bool flag5 = commandEvent != null;
			if (flag5)
			{
				this.commandName = commandEvent.commandName;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0004535A File Offset: 0x0004355A
		public EventDebuggerEventRecord(EventBase evt)
		{
			this.Init(evt);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0004536C File Offset: 0x0004356C
		public string TimestampString()
		{
			long ticks = (long)((float)this.timestamp / 1000f * 10000000f);
			return new DateTime(ticks).ToString("HH:mm:ss.ffffff");
		}
	}
}
