using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Events
{
	// Token: 0x020000C1 RID: 193
	public class EventHandlerWrapper<TEventArgs> : RaiseEventWrapper where TEventArgs : EventArgs
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00008347 File Offset: 0x00006547
		protected override string RaiseMethodName
		{
			get
			{
				return "Raise.EventWith";
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000834E File Offset: 0x0000654E
		public EventHandlerWrapper() : this(null, null)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00008358 File Offset: 0x00006558
		[NullableContext(2)]
		public EventHandlerWrapper(EventArgs eventArgs) : this(null, eventArgs)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00008362 File Offset: 0x00006562
		[NullableContext(2)]
		public EventHandlerWrapper(object sender, EventArgs eventArgs)
		{
			this._sender = sender;
			this._eventArgs = eventArgs;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00008378 File Offset: 0x00006578
		public static implicit operator EventHandler(EventHandlerWrapper<TEventArgs> wrapper)
		{
			RaiseEventWrapper.RaiseEvent(wrapper);
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00008381 File Offset: 0x00006581
		public static implicit operator EventHandler<TEventArgs>(EventHandlerWrapper<TEventArgs> wrapper)
		{
			RaiseEventWrapper.RaiseEvent(wrapper);
			return null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000838C File Offset: 0x0000658C
		protected override object[] WorkOutRequiredArguments(ICall call)
		{
			object obj = this._sender ?? call.Target();
			EventArgs eventArgs = this._eventArgs ?? base.GetDefaultForEventArgType(typeof(TEventArgs));
			return new object[]
			{
				obj,
				eventArgs
			};
		}

		// Token: 0x040000EC RID: 236
		[Nullable(2)]
		private readonly object _sender;

		// Token: 0x040000ED RID: 237
		[Nullable(2)]
		private readonly EventArgs _eventArgs;
	}
}
