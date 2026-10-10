using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D0 RID: 464
	public abstract class EventBase : IDisposable
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x0003DA74 File Offset: 0x0003BC74
		protected static long RegisterEventType()
		{
			return EventBase.s_LastTypeId += 1L;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0003DA94 File Offset: 0x0003BC94
		public virtual long eventTypeId
		{
			get
			{
				return -1L;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0003DA98 File Offset: 0x0003BC98
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
		public long timestamp { get; private set; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0003DAA9 File Offset: 0x0003BCA9
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x0003DAB1 File Offset: 0x0003BCB1
		internal ulong eventId { get; private set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0003DABA File Offset: 0x0003BCBA
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x0003DAC2 File Offset: 0x0003BCC2
		internal ulong triggerEventId { get; private set; }

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0003DACB File Offset: 0x0003BCCB
		internal void SetTriggerEventId(ulong id)
		{
			this.triggerEventId = id;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0003DAD6 File Offset: 0x0003BCD6
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0003DADE File Offset: 0x0003BCDE
		internal EventBase.EventPropagation propagation { get; set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0003DAE8 File Offset: 0x0003BCE8
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0003DB50 File Offset: 0x0003BD50
		internal PropagationPaths path
		{
			get
			{
				bool flag = this.m_Path == null;
				if (flag)
				{
					PropagationPaths.Type type = this.tricklesDown ? PropagationPaths.Type.TrickleDown : PropagationPaths.Type.None;
					type |= (this.bubbles ? PropagationPaths.Type.BubbleUp : PropagationPaths.Type.None);
					this.m_Path = PropagationPaths.Build(this.leafTarget as VisualElement, this, type);
					EventDebugger.LogPropagationPaths(this, this.m_Path);
				}
				return this.m_Path;
			}
			set
			{
				bool flag = value != null;
				if (flag)
				{
					this.m_Path = PropagationPaths.Copy(value);
				}
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0003DB72 File Offset: 0x0003BD72
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x0003DB7A File Offset: 0x0003BD7A
		private EventBase.LifeCycleStatus lifeCycleStatus { get; set; }

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002166 File Offset: 0x00000366
		[Obsolete("Override PreDispatch(IPanel panel) instead.")]
		protected virtual void PreDispatch()
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0003DB83 File Offset: 0x0003BD83
		protected internal virtual void PreDispatch(IPanel panel)
		{
			this.PreDispatch();
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002166 File Offset: 0x00000366
		[Obsolete("Override PostDispatch(IPanel panel) instead.")]
		protected virtual void PostDispatch()
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003DB8D File Offset: 0x0003BD8D
		protected internal virtual void PostDispatch(IPanel panel)
		{
			this.PostDispatch();
			this.processed = true;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0003DBA0 File Offset: 0x0003BDA0
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0003DBC0 File Offset: 0x0003BDC0
		public bool bubbles
		{
			get
			{
				return (this.propagation & EventBase.EventPropagation.Bubbles) > EventBase.EventPropagation.None;
			}
			protected set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.Bubbles;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.Bubbles;
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0003DBF8 File Offset: 0x0003BDF8
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0003DC18 File Offset: 0x0003BE18
		public bool tricklesDown
		{
			get
			{
				return (this.propagation & EventBase.EventPropagation.TricklesDown) > EventBase.EventPropagation.None;
			}
			protected set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.TricklesDown;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.TricklesDown;
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0003DC50 File Offset: 0x0003BE50
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0003DC70 File Offset: 0x0003BE70
		internal bool skipDisabledElements
		{
			get
			{
				return (this.propagation & EventBase.EventPropagation.SkipDisabledElements) > EventBase.EventPropagation.None;
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.SkipDisabledElements;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.SkipDisabledElements;
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0003DCA8 File Offset: 0x0003BEA8
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0003DCC8 File Offset: 0x0003BEC8
		internal bool ignoreCompositeRoots
		{
			get
			{
				return (this.propagation & EventBase.EventPropagation.IgnoreCompositeRoots) > EventBase.EventPropagation.None;
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.IgnoreCompositeRoots;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.IgnoreCompositeRoots;
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0003DD01 File Offset: 0x0003BF01
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0003DD09 File Offset: 0x0003BF09
		internal IEventHandler leafTarget { get; private set; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0003DD14 File Offset: 0x0003BF14
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0003DD2C File Offset: 0x0003BF2C
		public IEventHandler target
		{
			get
			{
				return this.m_Target;
			}
			set
			{
				this.m_Target = value;
				bool flag = this.leafTarget == null;
				if (flag)
				{
					this.leafTarget = value;
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0003DD58 File Offset: 0x0003BF58
		internal List<IEventHandler> skipElements { get; } = new List<IEventHandler>();

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0003DD60 File Offset: 0x0003BF60
		internal bool Skip(IEventHandler h)
		{
			return this.skipElements.Contains(h);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0003DD80 File Offset: 0x0003BF80
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x0003DDA0 File Offset: 0x0003BFA0
		public bool isPropagationStopped
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.PropagationStopped) > EventBase.LifeCycleStatus.None;
			}
			private set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.PropagationStopped;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.PropagationStopped;
				}
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0003DDD8 File Offset: 0x0003BFD8
		public void StopPropagation()
		{
			this.isPropagationStopped = true;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0003DDE4 File Offset: 0x0003BFE4
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0003DE04 File Offset: 0x0003C004
		public bool isImmediatePropagationStopped
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.ImmediatePropagationStopped) > EventBase.LifeCycleStatus.None;
			}
			private set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.ImmediatePropagationStopped;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.ImmediatePropagationStopped;
				}
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0003DE3C File Offset: 0x0003C03C
		public void StopImmediatePropagation()
		{
			this.isPropagationStopped = true;
			this.isImmediatePropagationStopped = true;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0003DE50 File Offset: 0x0003C050
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0003DE70 File Offset: 0x0003C070
		public bool isDefaultPrevented
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.DefaultPrevented) > EventBase.LifeCycleStatus.None;
			}
			private set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.DefaultPrevented;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.DefaultPrevented;
				}
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0003DEA8 File Offset: 0x0003C0A8
		public void PreventDefault()
		{
			bool flag = (this.propagation & EventBase.EventPropagation.Cancellable) == EventBase.EventPropagation.Cancellable;
			if (flag)
			{
				this.isDefaultPrevented = true;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0003DECF File Offset: 0x0003C0CF
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0003DED7 File Offset: 0x0003C0D7
		public PropagationPhase propagationPhase { get; internal set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x0003DEF8 File Offset: 0x0003C0F8
		public virtual IEventHandler currentTarget
		{
			get
			{
				return this.m_CurrentTarget;
			}
			internal set
			{
				this.m_CurrentTarget = value;
				bool flag = this.imguiEvent != null;
				if (flag)
				{
					VisualElement visualElement = this.currentTarget as VisualElement;
					bool flag2 = visualElement != null;
					if (flag2)
					{
						this.imguiEvent.mousePosition = visualElement.WorldToLocal(this.originalMousePosition);
					}
					else
					{
						this.imguiEvent.mousePosition = this.originalMousePosition;
					}
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0003DF60 File Offset: 0x0003C160
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x0003DF80 File Offset: 0x0003C180
		public bool dispatch
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Dispatching) > EventBase.LifeCycleStatus.None;
			}
			internal set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Dispatching;
					this.dispatched = true;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.Dispatching;
				}
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003DFC0 File Offset: 0x0003C1C0
		internal void MarkReceivedByDispatcher()
		{
			Debug.Assert(!this.dispatched, "Events cannot be dispatched more than once.");
			this.dispatched = true;
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0003E004 File Offset: 0x0003C204
		private bool dispatched
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Dispatched) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Dispatched;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.Dispatched;
				}
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003E044 File Offset: 0x0003C244
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0003E068 File Offset: 0x0003C268
		internal bool processed
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Processed) > EventBase.LifeCycleStatus.None;
			}
			private set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Processed;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.Processed;
				}
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0003E0A8 File Offset: 0x0003C2A8
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0003E0CC File Offset: 0x0003C2CC
		internal bool processedByFocusController
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.ProcessedByFocusController) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.ProcessedByFocusController;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.ProcessedByFocusController;
				}
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0003E10C File Offset: 0x0003C30C
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0003E12C File Offset: 0x0003C32C
		internal bool stopDispatch
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.StopDispatch) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.StopDispatch;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.StopDispatch;
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0003E168 File Offset: 0x0003C368
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0003E18C File Offset: 0x0003C38C
		internal bool propagateToIMGUI
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.PropagateToIMGUI) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.PropagateToIMGUI;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.PropagateToIMGUI;
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0003E1CC File Offset: 0x0003C3CC
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0003E1EC File Offset: 0x0003C3EC
		private bool imguiEventIsValid
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.IMGUIEventIsValid) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.IMGUIEventIsValid;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.IMGUIEventIsValid;
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0003E228 File Offset: 0x0003C428
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0003E24C File Offset: 0x0003C44C
		public Event imguiEvent
		{
			get
			{
				return this.imguiEventIsValid ? this.m_ImguiEvent : null;
			}
			protected set
			{
				bool flag = this.m_ImguiEvent == null;
				if (flag)
				{
					this.m_ImguiEvent = new Event();
				}
				bool flag2 = value != null;
				if (flag2)
				{
					this.m_ImguiEvent.CopyFrom(value);
					this.imguiEventIsValid = true;
					this.originalMousePosition = value.mousePosition;
				}
				else
				{
					this.imguiEventIsValid = false;
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0003E2AC File Offset: 0x0003C4AC
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0003E2B4 File Offset: 0x0003C4B4
		public Vector2 originalMousePosition { get; private set; }

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003E2BD File Offset: 0x0003C4BD
		protected virtual void Init()
		{
			this.LocalInit();
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		private void LocalInit()
		{
			this.timestamp = Panel.TimeSinceStartupMs();
			this.triggerEventId = 0UL;
			ulong num = EventBase.s_NextEventId;
			EventBase.s_NextEventId = num + 1UL;
			this.eventId = num;
			this.propagation = EventBase.EventPropagation.None;
			PropagationPaths path = this.m_Path;
			if (path != null)
			{
				path.Release();
			}
			this.m_Path = null;
			this.leafTarget = null;
			this.target = null;
			this.skipElements.Clear();
			this.isPropagationStopped = false;
			this.isImmediatePropagationStopped = false;
			this.isDefaultPrevented = false;
			this.propagationPhase = PropagationPhase.None;
			this.originalMousePosition = Vector2.zero;
			this.m_CurrentTarget = null;
			this.dispatch = false;
			this.stopDispatch = false;
			this.propagateToIMGUI = true;
			this.dispatched = false;
			this.processed = false;
			this.processedByFocusController = false;
			this.imguiEventIsValid = false;
			this.pooled = false;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		protected EventBase()
		{
			this.m_ImguiEvent = null;
			this.LocalInit();
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0003E3D4 File Offset: 0x0003C5D4
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x0003E3F4 File Offset: 0x0003C5F4
		protected bool pooled
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Pooled) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Pooled;
				}
				else
				{
					this.lifeCycleStatus &= ~EventBase.LifeCycleStatus.Pooled;
				}
			}
		}

		// Token: 0x06000EF7 RID: 3831
		internal abstract void Acquire();

		// Token: 0x06000EF8 RID: 3832
		public abstract void Dispose();

		// Token: 0x040006CA RID: 1738
		private static long s_LastTypeId;

		// Token: 0x040006CB RID: 1739
		private static ulong s_NextEventId;

		// Token: 0x040006D0 RID: 1744
		private PropagationPaths m_Path;

		// Token: 0x040006D3 RID: 1747
		private IEventHandler m_Target;

		// Token: 0x040006D6 RID: 1750
		private IEventHandler m_CurrentTarget;

		// Token: 0x040006D7 RID: 1751
		private Event m_ImguiEvent;

		// Token: 0x020001D1 RID: 465
		[Flags]
		internal enum EventPropagation
		{
			// Token: 0x040006DA RID: 1754
			None = 0,
			// Token: 0x040006DB RID: 1755
			Bubbles = 1,
			// Token: 0x040006DC RID: 1756
			TricklesDown = 2,
			// Token: 0x040006DD RID: 1757
			Cancellable = 4,
			// Token: 0x040006DE RID: 1758
			SkipDisabledElements = 8,
			// Token: 0x040006DF RID: 1759
			IgnoreCompositeRoots = 16
		}

		// Token: 0x020001D2 RID: 466
		[Flags]
		private enum LifeCycleStatus
		{
			// Token: 0x040006E1 RID: 1761
			None = 0,
			// Token: 0x040006E2 RID: 1762
			PropagationStopped = 1,
			// Token: 0x040006E3 RID: 1763
			ImmediatePropagationStopped = 2,
			// Token: 0x040006E4 RID: 1764
			DefaultPrevented = 4,
			// Token: 0x040006E5 RID: 1765
			Dispatching = 8,
			// Token: 0x040006E6 RID: 1766
			Pooled = 16,
			// Token: 0x040006E7 RID: 1767
			IMGUIEventIsValid = 32,
			// Token: 0x040006E8 RID: 1768
			StopDispatch = 64,
			// Token: 0x040006E9 RID: 1769
			PropagateToIMGUI = 128,
			// Token: 0x040006EA RID: 1770
			Dispatched = 512,
			// Token: 0x040006EB RID: 1771
			Processed = 1024,
			// Token: 0x040006EC RID: 1772
			ProcessedByFocusController = 2048
		}
	}
}
