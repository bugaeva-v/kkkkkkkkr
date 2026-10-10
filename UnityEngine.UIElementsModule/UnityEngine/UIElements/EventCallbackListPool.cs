using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DC RID: 476
	internal class EventCallbackListPool
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x0003E824 File Offset: 0x0003CA24
		public EventCallbackList Get(EventCallbackList initializer)
		{
			bool flag = this.m_Stack.Count == 0;
			EventCallbackList eventCallbackList;
			if (flag)
			{
				bool flag2 = initializer != null;
				if (flag2)
				{
					eventCallbackList = new EventCallbackList(initializer);
				}
				else
				{
					eventCallbackList = new EventCallbackList();
				}
			}
			else
			{
				eventCallbackList = this.m_Stack.Pop();
				bool flag3 = initializer != null;
				if (flag3)
				{
					eventCallbackList.AddRange(initializer);
				}
			}
			return eventCallbackList;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0003E884 File Offset: 0x0003CA84
		public void Release(EventCallbackList element)
		{
			element.Clear();
			this.m_Stack.Push(element);
		}

		// Token: 0x04000700 RID: 1792
		private readonly Stack<EventCallbackList> m_Stack = new Stack<EventCallbackList>();
	}
}
