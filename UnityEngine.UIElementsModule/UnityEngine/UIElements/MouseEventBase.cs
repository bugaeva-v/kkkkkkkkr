using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F7 RID: 503
	public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal where T : MouseEventBase<T>, new()
	{
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000402D1 File Offset: 0x0003E4D1
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x000402D9 File Offset: 0x0003E4D9
		public EventModifiers modifiers { get; protected set; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x000402E2 File Offset: 0x0003E4E2
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x000402EA File Offset: 0x0003E4EA
		public Vector2 mousePosition { get; protected set; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000402F3 File Offset: 0x0003E4F3
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x000402FB File Offset: 0x0003E4FB
		public Vector2 localMousePosition { get; internal set; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00040304 File Offset: 0x0003E504
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0004030C File Offset: 0x0003E50C
		public Vector2 mouseDelta { get; protected set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00040315 File Offset: 0x0003E515
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0004031D File Offset: 0x0003E51D
		public int clickCount { get; protected set; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00040326 File Offset: 0x0003E526
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x0004032E File Offset: 0x0003E52E
		public int button { get; protected set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00040337 File Offset: 0x0003E537
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0004033F File Offset: 0x0003E53F
		public int pressedButtons { get; protected set; }

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00040348 File Offset: 0x0003E548
		public bool shiftKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) > EventModifiers.None;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00040368 File Offset: 0x0003E568
		public bool ctrlKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) > EventModifiers.None;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00040388 File Offset: 0x0003E588
		public bool commandKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) > EventModifiers.None;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000403A8 File Offset: 0x0003E5A8
		public bool altKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) > EventModifiers.None;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000403C8 File Offset: 0x0003E5C8
		public bool actionKey
		{
			get
			{
				bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
				bool result;
				if (flag)
				{
					result = this.commandKey;
				}
				else
				{
					result = this.ctrlKey;
				}
				return result;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00040401 File Offset: 0x0003E601
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00040409 File Offset: 0x0003E609
		bool IMouseEventInternal.triggeredByOS { get; set; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00040412 File Offset: 0x0003E612
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x0004041A File Offset: 0x0003E61A
		bool IMouseEventInternal.recomputeTopElementUnderMouse { get; set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00040423 File Offset: 0x0003E623
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x0004042B File Offset: 0x0003E62B
		IPointerEvent IMouseEventInternal.sourcePointerEvent { get; set; }

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00040434 File Offset: 0x0003E634
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00040448 File Offset: 0x0003E648
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable);
			this.modifiers = EventModifiers.None;
			this.mousePosition = Vector2.zero;
			this.localMousePosition = Vector2.zero;
			this.mouseDelta = Vector2.zero;
			this.clickCount = 0;
			this.button = 0;
			this.pressedButtons = 0;
			((IMouseEventInternal)this).triggeredByOS = false;
			((IMouseEventInternal)this).recomputeTopElementUnderMouse = true;
			((IMouseEventInternal)this).sourcePointerEvent = null;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000404BC File Offset: 0x0003E6BC
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x000404D4 File Offset: 0x0003E6D4
		public override IEventHandler currentTarget
		{
			get
			{
				return base.currentTarget;
			}
			internal set
			{
				base.currentTarget = value;
				VisualElement visualElement = this.currentTarget as VisualElement;
				bool flag = visualElement != null;
				if (flag)
				{
					this.localMousePosition = visualElement.WorldToLocal(this.mousePosition);
				}
				else
				{
					this.localMousePosition = this.mousePosition;
				}
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00040524 File Offset: 0x0003E724
		protected internal override void PreDispatch(IPanel panel)
		{
			base.PreDispatch(panel);
			bool triggeredByOS = ((IMouseEventInternal)this).triggeredByOS;
			if (triggeredByOS)
			{
				PointerDeviceState.SavePointerPosition(PointerId.mousePointerId, this.mousePosition, panel, panel.contextType);
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00040560 File Offset: 0x0003E760
		protected internal override void PostDispatch(IPanel panel)
		{
			EventBase eventBase = ((IMouseEventInternal)this).sourcePointerEvent as EventBase;
			bool flag = eventBase != null;
			if (flag)
			{
				Debug.Assert(eventBase.processed);
				BaseVisualElementPanel baseVisualElementPanel = panel as BaseVisualElementPanel;
				if (baseVisualElementPanel != null)
				{
					baseVisualElementPanel.CommitElementUnderPointers();
				}
				bool isPropagationStopped = base.isPropagationStopped;
				if (isPropagationStopped)
				{
					eventBase.StopPropagation();
				}
				bool isImmediatePropagationStopped = base.isImmediatePropagationStopped;
				if (isImmediatePropagationStopped)
				{
					eventBase.StopImmediatePropagation();
				}
				bool isDefaultPrevented = base.isDefaultPrevented;
				if (isDefaultPrevented)
				{
					eventBase.PreventDefault();
				}
				eventBase.processedByFocusController |= base.processedByFocusController;
			}
			base.PostDispatch(panel);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000405FC File Offset: 0x0003E7FC
		public static T GetPooled(Event systemEvent)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.imguiEvent = systemEvent;
			bool flag = systemEvent != null;
			if (flag)
			{
				pooled.modifiers = systemEvent.modifiers;
				pooled.mousePosition = systemEvent.mousePosition;
				pooled.localMousePosition = systemEvent.mousePosition;
				pooled.mouseDelta = systemEvent.delta;
				pooled.button = systemEvent.button;
				pooled.pressedButtons = PointerDeviceState.GetPressedButtons(PointerId.mousePointerId);
				pooled.clickCount = systemEvent.clickCount;
				pooled.triggeredByOS = true;
				pooled.recomputeTopElementUnderMouse = true;
			}
			return pooled;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000406CC File Offset: 0x0003E8CC
		public static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, EventModifiers modifiers = EventModifiers.None)
		{
			return MouseEventBase<T>.GetPooled(position, button, clickCount, delta, modifiers, false);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000406EC File Offset: 0x0003E8EC
		internal static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, EventModifiers modifiers, bool fromOS)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.modifiers = modifiers;
			pooled.mousePosition = position;
			pooled.localMousePosition = position;
			pooled.mouseDelta = delta;
			pooled.button = button;
			pooled.pressedButtons = PointerDeviceState.GetPressedButtons(PointerId.mousePointerId);
			pooled.clickCount = clickCount;
			pooled.triggeredByOS = fromOS;
			pooled.recomputeTopElementUnderMouse = true;
			return pooled;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00040788 File Offset: 0x0003E988
		internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse)
		{
			bool flag = triggerEvent != null;
			T result;
			if (flag)
			{
				result = MouseEventBase<T>.GetPooled(triggerEvent);
			}
			else
			{
				T pooled = EventBase<T>.GetPooled();
				pooled.mousePosition = mousePosition;
				pooled.localMousePosition = mousePosition;
				pooled.recomputeTopElementUnderMouse = recomputeTopElementUnderMouse;
				result = pooled;
			}
			return result;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000407DC File Offset: 0x0003E9DC
		public static T GetPooled(IMouseEvent triggerEvent)
		{
			T pooled = EventBase<T>.GetPooled(triggerEvent as EventBase);
			bool flag = triggerEvent != null;
			if (flag)
			{
				pooled.modifiers = triggerEvent.modifiers;
				pooled.mousePosition = triggerEvent.mousePosition;
				pooled.localMousePosition = triggerEvent.mousePosition;
				pooled.mouseDelta = triggerEvent.mouseDelta;
				pooled.button = triggerEvent.button;
				pooled.pressedButtons = triggerEvent.pressedButtons;
				pooled.clickCount = triggerEvent.clickCount;
				IMouseEventInternal mouseEventInternal = triggerEvent as IMouseEventInternal;
				bool flag2 = mouseEventInternal != null;
				if (flag2)
				{
					pooled.triggeredByOS = mouseEventInternal.triggeredByOS;
					pooled.recomputeTopElementUnderMouse = false;
				}
			}
			return pooled;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000408B8 File Offset: 0x0003EAB8
		protected static T GetPooled(IPointerEvent pointerEvent)
		{
			T pooled = EventBase<T>.GetPooled();
			EventBase eventBase = pooled;
			EventBase eventBase2 = pointerEvent as EventBase;
			eventBase.target = ((eventBase2 != null) ? eventBase2.target : null);
			EventBase eventBase3 = pooled;
			EventBase eventBase4 = pointerEvent as EventBase;
			eventBase3.imguiEvent = ((eventBase4 != null) ? eventBase4.imguiEvent : null);
			EventBase eventBase5 = pointerEvent as EventBase;
			bool flag = ((eventBase5 != null) ? eventBase5.path : null) != null;
			if (flag)
			{
				pooled.path = (pointerEvent as EventBase).path;
			}
			pooled.modifiers = pointerEvent.modifiers;
			pooled.mousePosition = pointerEvent.position;
			pooled.localMousePosition = pointerEvent.position;
			pooled.mouseDelta = pointerEvent.deltaPosition;
			pooled.button = ((pointerEvent.button == -1) ? 0 : pointerEvent.button);
			pooled.pressedButtons = pointerEvent.pressedButtons;
			pooled.clickCount = pointerEvent.clickCount;
			IPointerEventInternal pointerEventInternal = pointerEvent as IPointerEventInternal;
			bool flag2 = pointerEventInternal != null;
			if (flag2)
			{
				pooled.triggeredByOS = pointerEventInternal.triggeredByOS;
				pooled.recomputeTopElementUnderMouse = true;
				pooled.sourcePointerEvent = pointerEvent;
			}
			return pooled;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00040A15 File Offset: 0x0003EC15
		protected MouseEventBase()
		{
			this.LocalInit();
		}
	}
}
