using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DD RID: 477
	internal class EventCallbackList
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0003E8AF File Offset: 0x0003CAAF
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x0003E8B7 File Offset: 0x0003CAB7
		public int trickleDownCallbackCount { get; private set; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0003E8C0 File Offset: 0x0003CAC0
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x0003E8C8 File Offset: 0x0003CAC8
		public int bubbleUpCallbackCount { get; private set; }

		// Token: 0x06000F20 RID: 3872 RVA: 0x0003E8D1 File Offset: 0x0003CAD1
		public EventCallbackList()
		{
			this.m_List = new List<EventCallbackFunctorBase>();
			this.trickleDownCallbackCount = 0;
			this.bubbleUpCallbackCount = 0;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0003E8F6 File Offset: 0x0003CAF6
		public EventCallbackList(EventCallbackList source)
		{
			this.m_List = new List<EventCallbackFunctorBase>(source.m_List);
			this.trickleDownCallbackCount = 0;
			this.bubbleUpCallbackCount = 0;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0003E924 File Offset: 0x0003CB24
		public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return this.Find(eventTypeId, callback, phase) != null;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0003E944 File Offset: 0x0003CB44
		public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			for (int i = 0; i < this.m_List.Count; i++)
			{
				bool flag = this.m_List[i].IsEquivalentTo(eventTypeId, callback, phase);
				if (flag)
				{
					return this.m_List[i];
				}
			}
			return null;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0003E99C File Offset: 0x0003CB9C
		public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			for (int i = 0; i < this.m_List.Count; i++)
			{
				bool flag = this.m_List[i].IsEquivalentTo(eventTypeId, callback, phase);
				if (flag)
				{
					this.m_List.RemoveAt(i);
					bool flag2 = phase == CallbackPhase.TrickleDownAndTarget;
					if (flag2)
					{
						int num = this.trickleDownCallbackCount;
						this.trickleDownCallbackCount = num - 1;
					}
					else
					{
						bool flag3 = phase == CallbackPhase.TargetAndBubbleUp;
						if (flag3)
						{
							int num = this.bubbleUpCallbackCount;
							this.bubbleUpCallbackCount = num - 1;
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0003EA34 File Offset: 0x0003CC34
		public void Add(EventCallbackFunctorBase item)
		{
			this.m_List.Add(item);
			bool flag = item.phase == CallbackPhase.TrickleDownAndTarget;
			if (flag)
			{
				int num = this.trickleDownCallbackCount;
				this.trickleDownCallbackCount = num + 1;
			}
			else
			{
				bool flag2 = item.phase == CallbackPhase.TargetAndBubbleUp;
				if (flag2)
				{
					int num = this.bubbleUpCallbackCount;
					this.bubbleUpCallbackCount = num + 1;
				}
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0003EA94 File Offset: 0x0003CC94
		public void AddRange(EventCallbackList list)
		{
			this.m_List.AddRange(list.m_List);
			foreach (EventCallbackFunctorBase eventCallbackFunctorBase in list.m_List)
			{
				bool flag = eventCallbackFunctorBase.phase == CallbackPhase.TrickleDownAndTarget;
				if (flag)
				{
					int num = this.trickleDownCallbackCount;
					this.trickleDownCallbackCount = num + 1;
				}
				else
				{
					bool flag2 = eventCallbackFunctorBase.phase == CallbackPhase.TargetAndBubbleUp;
					if (flag2)
					{
						int num = this.bubbleUpCallbackCount;
						this.bubbleUpCallbackCount = num + 1;
					}
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0003EB3C File Offset: 0x0003CD3C
		public int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x17000334 RID: 820
		public EventCallbackFunctorBase this[int i]
		{
			get
			{
				return this.m_List[i];
			}
			set
			{
				this.m_List[i] = value;
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0003EB8B File Offset: 0x0003CD8B
		public void Clear()
		{
			this.m_List.Clear();
			this.trickleDownCallbackCount = 0;
			this.bubbleUpCallbackCount = 0;
		}

		// Token: 0x04000701 RID: 1793
		private List<EventCallbackFunctorBase> m_List;
	}
}
