using System;
using System.Collections.Generic;

namespace NSubstitute.Core
{
	// Token: 0x02000078 RID: 120
	public class EventHandlerRegistry : IEventHandlerRegistry
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00006444 File Offset: 0x00004644
		public void Add(string eventName, object handler)
		{
			List<Tuple<string, List<object>>> handlersForEvent = this._handlersForEvent;
			lock (handlersForEvent)
			{
				this.Handlers(eventName).Add(handler);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000648C File Offset: 0x0000468C
		public void Remove(string eventName, object handler)
		{
			List<Tuple<string, List<object>>> handlersForEvent = this._handlersForEvent;
			lock (handlersForEvent)
			{
				this.Handlers(eventName).Remove(handler);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000064D4 File Offset: 0x000046D4
		public IEnumerable<object> GetHandlers(string eventName)
		{
			List<Tuple<string, List<object>>> handlersForEvent = this._handlersForEvent;
			IEnumerable<object> result;
			lock (handlersForEvent)
			{
				result = this.Handlers(eventName).ToArray();
			}
			return result;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000651C File Offset: 0x0000471C
		private List<object> Handlers(string eventName)
		{
			foreach (Tuple<string, List<object>> tuple in this._handlersForEvent)
			{
				if (tuple.Item1 == eventName)
				{
					return tuple.Item2;
				}
			}
			Tuple<string, List<object>> tuple2 = Tuple.Create<string, List<object>>(eventName, new List<object>());
			this._handlersForEvent.Add(tuple2);
			return tuple2.Item2;
		}

		// Token: 0x0400009C RID: 156
		private readonly List<Tuple<string, List<object>>> _handlersForEvent = new List<Tuple<string, List<object>>>();
	}
}
