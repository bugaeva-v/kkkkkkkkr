using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EE RID: 494
	public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent where T : KeyboardEventBase<T>, new()
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0003FB31 File Offset: 0x0003DD31
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x0003FB39 File Offset: 0x0003DD39
		public EventModifiers modifiers { get; protected set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0003FB42 File Offset: 0x0003DD42
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x0003FB4A File Offset: 0x0003DD4A
		public char character { get; protected set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0003FB53 File Offset: 0x0003DD53
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x0003FB5B File Offset: 0x0003DD5B
		public KeyCode keyCode { get; protected set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0003FB64 File Offset: 0x0003DD64
		public bool shiftKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) > EventModifiers.None;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0003FB84 File Offset: 0x0003DD84
		public bool ctrlKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) > EventModifiers.None;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x0003FBA4 File Offset: 0x0003DDA4
		public bool commandKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) > EventModifiers.None;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		public bool altKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) > EventModifiers.None;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0003FBE4 File Offset: 0x0003DDE4
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

		// Token: 0x06000F8E RID: 3982 RVA: 0x0003FC1D File Offset: 0x0003DE1D
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0003FC2E File Offset: 0x0003DE2E
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
			this.modifiers = EventModifiers.None;
			this.character = '\0';
			this.keyCode = KeyCode.None;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0003FC54 File Offset: 0x0003DE54
		public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.modifiers = modifiers;
			pooled.character = c;
			pooled.keyCode = keyCode;
			return pooled;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0003FC94 File Offset: 0x0003DE94
		public static T GetPooled(Event systemEvent)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.imguiEvent = systemEvent;
			bool flag = systemEvent != null;
			if (flag)
			{
				pooled.modifiers = systemEvent.modifiers;
				pooled.character = systemEvent.character;
				pooled.keyCode = systemEvent.keyCode;
			}
			return pooled;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0003FCFA File Offset: 0x0003DEFA
		protected KeyboardEventBase()
		{
			this.LocalInit();
		}
	}
}
