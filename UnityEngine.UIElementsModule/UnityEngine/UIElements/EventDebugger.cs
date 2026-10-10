using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x02000237 RID: 567
	internal class EventDebugger
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000436AF File Offset: 0x000418AF
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x000436B7 File Offset: 0x000418B7
		public IPanel panel { get; set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000436C0 File Offset: 0x000418C0
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x000436C8 File Offset: 0x000418C8
		public bool isReplaying { get; private set; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000436D1 File Offset: 0x000418D1
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x000436D9 File Offset: 0x000418D9
		public float playbackSpeed { get; set; } = 1f;

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000436E2 File Offset: 0x000418E2
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x000436EA File Offset: 0x000418EA
		public bool isPlaybackPaused { get; set; }

		// Token: 0x06001113 RID: 4371 RVA: 0x000436F4 File Offset: 0x000418F4
		public void UpdateModificationCount()
		{
			bool flag = this.panel == null;
			if (!flag)
			{
				long num;
				bool flag2 = !this.m_ModificationCount.TryGetValue(this.panel, out num);
				if (flag2)
				{
					num = 0L;
				}
				num += 1L;
				this.m_ModificationCount[this.panel] = num;
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00043748 File Offset: 0x00041948
		public void BeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			this.AddBeginProcessEvent(evt, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0004375B File Offset: 0x0004195B
		public void EndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddEndProcessEvent(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00043770 File Offset: 0x00041970
		public void LogCall(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			this.AddCallObject(cbHashCode, cbName, evt, propagationHasStopped, immediatePropagationHasStopped, defaultHasBeenPrevented, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00043799 File Offset: 0x00041999
		public void LogIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddIMGUICall(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000437AD File Offset: 0x000419AD
		public void LogExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			this.AddExecuteDefaultAction(evt, phase, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00002166 File Offset: 0x00000366
		public static void LogPropagationPaths(EventBase evt, PropagationPaths paths)
		{
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x000437C4 File Offset: 0x000419C4
		private void LogPropagationPathsInternal(EventBase evt, PropagationPaths paths)
		{
			PropagationPaths paths2 = (paths == null) ? new PropagationPaths() : new PropagationPaths(paths);
			this.AddPropagationPaths(evt, paths2);
			this.UpdateModificationCount();
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000437F4 File Offset: 0x000419F4
		public List<EventDebuggerCallTrace> GetCalls(IPanel panel, EventDebuggerEventRecord evt = null)
		{
			List<EventDebuggerCallTrace> list;
			bool flag = !this.m_EventCalledObjects.TryGetValue(panel, out list);
			List<EventDebuggerCallTrace> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = evt != null && list != null;
				if (flag2)
				{
					List<EventDebuggerCallTrace> list2 = new List<EventDebuggerCallTrace>();
					foreach (EventDebuggerCallTrace eventDebuggerCallTrace in list)
					{
						bool flag3 = eventDebuggerCallTrace.eventBase.eventId == evt.eventId;
						if (flag3)
						{
							list2.Add(eventDebuggerCallTrace);
						}
					}
					list = list2;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000438A4 File Offset: 0x00041AA4
		public List<EventDebuggerDefaultActionTrace> GetDefaultActions(IPanel panel, EventDebuggerEventRecord evt = null)
		{
			List<EventDebuggerDefaultActionTrace> list;
			bool flag = !this.m_EventDefaultActionObjects.TryGetValue(panel, out list);
			List<EventDebuggerDefaultActionTrace> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = evt != null && list != null;
				if (flag2)
				{
					List<EventDebuggerDefaultActionTrace> list2 = new List<EventDebuggerDefaultActionTrace>();
					foreach (EventDebuggerDefaultActionTrace eventDebuggerDefaultActionTrace in list)
					{
						bool flag3 = eventDebuggerDefaultActionTrace.eventBase.eventId == evt.eventId;
						if (flag3)
						{
							list2.Add(eventDebuggerDefaultActionTrace);
						}
					}
					list = list2;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00043954 File Offset: 0x00041B54
		public List<EventDebuggerPathTrace> GetPropagationPaths(IPanel panel, EventDebuggerEventRecord evt = null)
		{
			List<EventDebuggerPathTrace> list;
			bool flag = !this.m_EventPathObjects.TryGetValue(panel, out list);
			List<EventDebuggerPathTrace> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = evt != null && list != null;
				if (flag2)
				{
					List<EventDebuggerPathTrace> list2 = new List<EventDebuggerPathTrace>();
					foreach (EventDebuggerPathTrace eventDebuggerPathTrace in list)
					{
						bool flag3 = eventDebuggerPathTrace.eventBase.eventId == evt.eventId;
						if (flag3)
						{
							list2.Add(eventDebuggerPathTrace);
						}
					}
					list = list2;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00043A04 File Offset: 0x00041C04
		public List<EventDebuggerTrace> GetBeginEndProcessedEvents(IPanel panel, EventDebuggerEventRecord evt = null)
		{
			List<EventDebuggerTrace> list;
			bool flag = !this.m_EventProcessedEvents.TryGetValue(panel, out list);
			List<EventDebuggerTrace> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = evt != null && list != null;
				if (flag2)
				{
					List<EventDebuggerTrace> list2 = new List<EventDebuggerTrace>();
					foreach (EventDebuggerTrace eventDebuggerTrace in list)
					{
						bool flag3 = eventDebuggerTrace.eventBase.eventId == evt.eventId;
						if (flag3)
						{
							list2.Add(eventDebuggerTrace);
						}
					}
					list = list2;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00043AB4 File Offset: 0x00041CB4
		public long GetModificationCount(IPanel panel)
		{
			bool flag = panel == null;
			long result;
			if (flag)
			{
				result = -1L;
			}
			else
			{
				long num;
				bool flag2 = !this.m_ModificationCount.TryGetValue(panel, out num);
				if (flag2)
				{
					num = -1L;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00043AF0 File Offset: 0x00041CF0
		public void ClearLogs()
		{
			this.UpdateModificationCount();
			bool flag = this.panel == null;
			if (flag)
			{
				this.m_EventCalledObjects.Clear();
				this.m_EventDefaultActionObjects.Clear();
				this.m_EventPathObjects.Clear();
				this.m_EventProcessedEvents.Clear();
				this.m_StackOfProcessedEvent.Clear();
				this.m_EventTypeProcessedCount.Clear();
			}
			else
			{
				this.m_EventCalledObjects.Remove(this.panel);
				this.m_EventDefaultActionObjects.Remove(this.panel);
				this.m_EventPathObjects.Remove(this.panel);
				this.m_EventProcessedEvents.Remove(this.panel);
				this.m_StackOfProcessedEvent.Remove(this.panel);
				Dictionary<long, int> dictionary;
				bool flag2 = this.m_EventTypeProcessedCount.TryGetValue(this.panel, out dictionary);
				if (flag2)
				{
					dictionary.Clear();
				}
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00043BD8 File Offset: 0x00041DD8
		public void SaveReplaySessionFromSelection(string path, List<EventDebuggerEventRecord> eventList)
		{
			bool flag = string.IsNullOrEmpty(path);
			if (!flag)
			{
				EventDebuggerRecordList obj = new EventDebuggerRecordList
				{
					eventList = eventList
				};
				string contents = JsonUtility.ToJson(obj);
				File.WriteAllText(path, contents);
				Debug.Log("Saved under: " + path);
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00043C20 File Offset: 0x00041E20
		public EventDebuggerRecordList LoadReplaySession(string path)
		{
			bool flag = string.IsNullOrEmpty(path);
			EventDebuggerRecordList result;
			if (flag)
			{
				result = null;
			}
			else
			{
				string json = File.ReadAllText(path);
				result = JsonUtility.FromJson<EventDebuggerRecordList>(json);
			}
			return result;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00043C4D File Offset: 0x00041E4D
		public IEnumerator ReplayEvents(IEnumerable<EventDebuggerEventRecord> eventBases, Action<int, int> refreshList)
		{
			bool flag = eventBases == null;
			if (flag)
			{
				yield break;
			}
			this.isReplaying = true;
			IEnumerator doReplay = this.DoReplayEvents(eventBases, refreshList);
			while (doReplay.MoveNext())
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00043C6A File Offset: 0x00041E6A
		public void StopPlayback()
		{
			this.isReplaying = false;
			this.isPlaybackPaused = false;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00043C7D File Offset: 0x00041E7D
		private IEnumerator DoReplayEvents(IEnumerable<EventDebuggerEventRecord> eventBases, Action<int, int> refreshList)
		{
			EventDebugger.<>c__DisplayClass34_0 CS$<>8__locals1 = new EventDebugger.<>c__DisplayClass34_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.sortedEvents = (from e in eventBases
			orderby e.timestamp
			select e).ToList<EventDebuggerEventRecord>();
			int sortedEventsCount = CS$<>8__locals1.sortedEvents.Count;
			int i = 0;
			while (i < sortedEventsCount)
			{
				bool flag = !this.isReplaying;
				if (flag)
				{
					break;
				}
				EventDebuggerEventRecord eventBase = CS$<>8__locals1.sortedEvents[i];
				Event newEvent = new Event
				{
					button = eventBase.button,
					clickCount = eventBase.clickCount,
					modifiers = eventBase.modifiers,
					mousePosition = eventBase.mousePosition
				};
				bool flag2 = eventBase.eventTypeId == EventBase<MouseMoveEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag2)
				{
					newEvent.type = EventType.MouseMove;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseMove), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag3 = eventBase.eventTypeId == EventBase<MouseDownEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag3)
				{
					newEvent.type = EventType.MouseDown;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseDown), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag4 = eventBase.eventTypeId == EventBase<MouseUpEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag4)
				{
					newEvent.type = EventType.MouseUp;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseUp), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag5 = eventBase.eventTypeId == EventBase<ContextClickEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag5)
				{
					newEvent.type = EventType.ContextClick;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.ContextClick), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag6 = eventBase.eventTypeId == EventBase<MouseEnterWindowEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag6)
				{
					newEvent.type = EventType.MouseEnterWindow;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseEnterWindow), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag7 = eventBase.eventTypeId == EventBase<MouseLeaveWindowEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag7)
				{
					newEvent.type = EventType.MouseLeaveWindow;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseLeaveWindow), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag8 = eventBase.eventTypeId == EventBase<PointerMoveEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag8)
				{
					newEvent.type = EventType.MouseMove;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseMove), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag9 = eventBase.eventTypeId == EventBase<PointerDownEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag9)
				{
					newEvent.type = EventType.MouseDown;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseDown), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag10 = eventBase.eventTypeId == EventBase<PointerUpEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag10)
				{
					newEvent.type = EventType.MouseUp;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.MouseUp), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag11 = eventBase.eventTypeId == EventBase<WheelEvent>.TypeId() && eventBase.hasUnderlyingPhysicalEvent;
				if (flag11)
				{
					newEvent.type = EventType.ScrollWheel;
					newEvent.delta = eventBase.delta;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.ScrollWheel), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag12 = eventBase.eventTypeId == EventBase<KeyDownEvent>.TypeId();
				if (flag12)
				{
					newEvent.type = EventType.KeyDown;
					newEvent.character = eventBase.character;
					newEvent.keyCode = eventBase.keyCode;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.KeyDown), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag13 = eventBase.eventTypeId == EventBase<KeyUpEvent>.TypeId();
				if (flag13)
				{
					newEvent.type = EventType.KeyUp;
					newEvent.character = eventBase.character;
					newEvent.keyCode = eventBase.keyCode;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.KeyUp), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag14 = eventBase.eventTypeId == EventBase<ValidateCommandEvent>.TypeId();
				if (flag14)
				{
					newEvent.type = EventType.ValidateCommand;
					newEvent.commandName = eventBase.commandName;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.ValidateCommand), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag15 = eventBase.eventTypeId == EventBase<ExecuteCommandEvent>.TypeId();
				if (flag15)
				{
					newEvent.type = EventType.ExecuteCommand;
					newEvent.commandName = eventBase.commandName;
					this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(newEvent, EventType.ExecuteCommand), this.panel, DispatchMode.Default);
					goto IL_868;
				}
				bool flag16 = eventBase.eventTypeId == EventBase<IMGUIEvent>.TypeId();
				if (flag16)
				{
					string str = "Skipped IMGUI event (";
					string eventBaseName = eventBase.eventBaseName;
					string str2 = "): ";
					EventDebuggerEventRecord eventDebuggerEventRecord = eventBase;
					Debug.Log(str + eventBaseName + str2 + ((eventDebuggerEventRecord != null) ? eventDebuggerEventRecord.ToString() : null));
					IEnumerator awaitSkipped = CS$<>8__locals1.<DoReplayEvents>g__AwaitForNextEvent|1(i);
					while (awaitSkipped.MoveNext())
					{
						yield return null;
					}
				}
				else
				{
					string str3 = "Skipped event (";
					string eventBaseName2 = eventBase.eventBaseName;
					string str4 = "): ";
					EventDebuggerEventRecord eventDebuggerEventRecord2 = eventBase;
					Debug.Log(str3 + eventBaseName2 + str4 + ((eventDebuggerEventRecord2 != null) ? eventDebuggerEventRecord2.ToString() : null));
					IEnumerator awaitSkipped2 = CS$<>8__locals1.<DoReplayEvents>g__AwaitForNextEvent|1(i);
					while (awaitSkipped2.MoveNext())
					{
						yield return null;
					}
				}
				IL_912:
				int num = i;
				i = num + 1;
				continue;
				IL_868:
				if (refreshList != null)
				{
					refreshList(i, sortedEventsCount);
				}
				Debug.Log(string.Format("Replayed event {0} ({1}): {2}", eventBase.eventId.ToString(), eventBase.eventBaseName, newEvent));
				IEnumerator await = CS$<>8__locals1.<DoReplayEvents>g__AwaitForNextEvent|1(i);
				while (await.MoveNext())
				{
					yield return null;
				}
				eventBase = null;
				newEvent = null;
				await = null;
				goto IL_912;
			}
			this.isReplaying = false;
			yield break;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00043C9C File Offset: 0x00041E9C
		public Dictionary<string, EventDebugger.HistogramRecord> ComputeHistogram(List<EventDebuggerEventRecord> eventBases)
		{
			List<EventDebuggerTrace> list;
			bool flag = this.panel == null || !this.m_EventProcessedEvents.TryGetValue(this.panel, out list);
			Dictionary<string, EventDebugger.HistogramRecord> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = list == null;
				if (flag2)
				{
					result = null;
				}
				else
				{
					Dictionary<string, EventDebugger.HistogramRecord> dictionary = new Dictionary<string, EventDebugger.HistogramRecord>();
					foreach (EventDebuggerTrace eventDebuggerTrace in list)
					{
						bool flag3 = eventBases == null || eventBases.Count == 0 || eventBases.Contains(eventDebuggerTrace.eventBase);
						if (flag3)
						{
							string eventBaseName = eventDebuggerTrace.eventBase.eventBaseName;
							long num = eventDebuggerTrace.duration;
							long num2 = 1L;
							EventDebugger.HistogramRecord histogramRecord;
							bool flag4 = dictionary.TryGetValue(eventBaseName, out histogramRecord);
							if (flag4)
							{
								num += histogramRecord.duration;
								num2 += histogramRecord.count;
							}
							dictionary[eventBaseName] = new EventDebugger.HistogramRecord
							{
								count = num2,
								duration = num
							};
						}
					}
					result = dictionary;
				}
			}
			return result;
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00043DC8 File Offset: 0x00041FC8
		public Dictionary<long, int> eventTypeProcessedCount
		{
			get
			{
				Dictionary<long, int> dictionary;
				return this.m_EventTypeProcessedCount.TryGetValue(this.panel, out dictionary) ? dictionary : null;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00043DEE File Offset: 0x00041FEE
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x00043DF6 File Offset: 0x00041FF6
		public bool suspended { get; set; }

		// Token: 0x0600112A RID: 4394 RVA: 0x00043E00 File Offset: 0x00042000
		public EventDebugger()
		{
			this.m_EventCalledObjects = new Dictionary<IPanel, List<EventDebuggerCallTrace>>();
			this.m_EventDefaultActionObjects = new Dictionary<IPanel, List<EventDebuggerDefaultActionTrace>>();
			this.m_EventPathObjects = new Dictionary<IPanel, List<EventDebuggerPathTrace>>();
			this.m_StackOfProcessedEvent = new Dictionary<IPanel, Stack<EventDebuggerTrace>>();
			this.m_EventProcessedEvents = new Dictionary<IPanel, List<EventDebuggerTrace>>();
			this.m_EventTypeProcessedCount = new Dictionary<IPanel, Dictionary<long, int>>();
			this.m_ModificationCount = new Dictionary<IPanel, long>();
			this.m_Log = true;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00043E74 File Offset: 0x00042074
		private void AddCallObject(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			bool suspended = this.suspended;
			if (!suspended)
			{
				bool log = this.m_Log;
				if (log)
				{
					EventDebuggerCallTrace item = new EventDebuggerCallTrace(this.panel, evt, cbHashCode, cbName, propagationHasStopped, immediatePropagationHasStopped, defaultHasBeenPrevented, duration, mouseCapture);
					List<EventDebuggerCallTrace> list;
					bool flag = !this.m_EventCalledObjects.TryGetValue(this.panel, out list);
					if (flag)
					{
						list = new List<EventDebuggerCallTrace>();
						this.m_EventCalledObjects.Add(this.panel, list);
					}
					list.Add(item);
				}
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00043EF4 File Offset: 0x000420F4
		private void AddExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			bool suspended = this.suspended;
			if (!suspended)
			{
				bool log = this.m_Log;
				if (log)
				{
					EventDebuggerDefaultActionTrace item = new EventDebuggerDefaultActionTrace(this.panel, evt, phase, duration, mouseCapture);
					List<EventDebuggerDefaultActionTrace> list;
					bool flag = !this.m_EventDefaultActionObjects.TryGetValue(this.panel, out list);
					if (flag)
					{
						list = new List<EventDebuggerDefaultActionTrace>();
						this.m_EventDefaultActionObjects.Add(this.panel, list);
					}
					list.Add(item);
				}
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00043F6C File Offset: 0x0004216C
		private void AddPropagationPaths(EventBase evt, PropagationPaths paths)
		{
			bool suspended = this.suspended;
			if (!suspended)
			{
				bool log = this.m_Log;
				if (log)
				{
					EventDebuggerPathTrace item = new EventDebuggerPathTrace(this.panel, evt, paths);
					List<EventDebuggerPathTrace> list;
					bool flag = !this.m_EventPathObjects.TryGetValue(this.panel, out list);
					if (flag)
					{
						list = new List<EventDebuggerPathTrace>();
						this.m_EventPathObjects.Add(this.panel, list);
					}
					list.Add(item);
				}
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00043FE0 File Offset: 0x000421E0
		private void AddIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			bool suspended = this.suspended;
			if (!suspended)
			{
				bool log = this.m_Log;
				if (log)
				{
					EventDebuggerCallTrace item = new EventDebuggerCallTrace(this.panel, evt, 0, "OnGUI", false, false, false, duration, mouseCapture);
					List<EventDebuggerCallTrace> list;
					bool flag = !this.m_EventCalledObjects.TryGetValue(this.panel, out list);
					if (flag)
					{
						list = new List<EventDebuggerCallTrace>();
						this.m_EventCalledObjects.Add(this.panel, list);
					}
					list.Add(item);
				}
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00044060 File Offset: 0x00042260
		private void AddBeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			bool suspended = this.suspended;
			if (!suspended)
			{
				EventDebuggerTrace eventDebuggerTrace = new EventDebuggerTrace(this.panel, evt, -1L, mouseCapture);
				Stack<EventDebuggerTrace> stack;
				bool flag = !this.m_StackOfProcessedEvent.TryGetValue(this.panel, out stack);
				if (flag)
				{
					stack = new Stack<EventDebuggerTrace>();
					this.m_StackOfProcessedEvent.Add(this.panel, stack);
				}
				List<EventDebuggerTrace> list;
				bool flag2 = !this.m_EventProcessedEvents.TryGetValue(this.panel, out list);
				if (flag2)
				{
					list = new List<EventDebuggerTrace>();
					this.m_EventProcessedEvents.Add(this.panel, list);
				}
				list.Add(eventDebuggerTrace);
				stack.Push(eventDebuggerTrace);
				Dictionary<long, int> dictionary;
				bool flag3 = !this.m_EventTypeProcessedCount.TryGetValue(this.panel, out dictionary);
				if (!flag3)
				{
					int num;
					bool flag4 = !dictionary.TryGetValue(eventDebuggerTrace.eventBase.eventTypeId, out num);
					if (flag4)
					{
						num = 0;
					}
					dictionary[eventDebuggerTrace.eventBase.eventTypeId] = num + 1;
				}
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00044160 File Offset: 0x00042360
		private void AddEndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			bool suspended = this.suspended;
			if (!suspended)
			{
				bool flag = false;
				Stack<EventDebuggerTrace> stack;
				bool flag2 = this.m_StackOfProcessedEvent.TryGetValue(this.panel, out stack);
				if (flag2)
				{
					bool flag3 = stack.Count > 0;
					if (flag3)
					{
						EventDebuggerTrace eventDebuggerTrace = stack.Peek();
						bool flag4 = eventDebuggerTrace.eventBase.eventId == evt.eventId;
						if (flag4)
						{
							stack.Pop();
							eventDebuggerTrace.duration = duration;
							bool flag5 = eventDebuggerTrace.eventBase.target == null;
							if (flag5)
							{
								eventDebuggerTrace.eventBase.target = evt.target;
							}
							flag = true;
						}
					}
				}
				bool flag6 = !flag;
				if (flag6)
				{
					EventDebuggerTrace eventDebuggerTrace2 = new EventDebuggerTrace(this.panel, evt, duration, mouseCapture);
					List<EventDebuggerTrace> list;
					bool flag7 = !this.m_EventProcessedEvents.TryGetValue(this.panel, out list);
					if (flag7)
					{
						list = new List<EventDebuggerTrace>();
						this.m_EventProcessedEvents.Add(this.panel, list);
					}
					list.Add(eventDebuggerTrace2);
					Dictionary<long, int> dictionary;
					bool flag8 = !this.m_EventTypeProcessedCount.TryGetValue(this.panel, out dictionary);
					if (!flag8)
					{
						int num;
						bool flag9 = !dictionary.TryGetValue(eventDebuggerTrace2.eventBase.eventTypeId, out num);
						if (flag9)
						{
							num = 0;
						}
						dictionary[eventDebuggerTrace2.eventBase.eventTypeId] = num + 1;
					}
				}
			}
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x000442C4 File Offset: 0x000424C4
		public static string GetObjectDisplayName(object obj, bool withHashCode = true)
		{
			bool flag = obj == null;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				Type type = obj.GetType();
				string text = EventDebugger.GetTypeDisplayName(type);
				bool flag2 = obj is VisualElement;
				if (flag2)
				{
					VisualElement visualElement = obj as VisualElement;
					bool flag3 = !string.IsNullOrEmpty(visualElement.name);
					if (flag3)
					{
						text = text + "#" + visualElement.name;
					}
				}
				if (withHashCode)
				{
					text = text + " (" + obj.GetHashCode().ToString("x8") + ")";
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0004436C File Offset: 0x0004256C
		public static string GetTypeDisplayName(Type type)
		{
			return type.IsGenericType ? (type.Name.TrimEnd(new char[]
			{
				'`',
				'1'
			}) + "<" + type.GetGenericArguments()[0].Name + ">") : type.Name;
		}

		// Token: 0x0400077B RID: 1915
		private Dictionary<IPanel, List<EventDebuggerCallTrace>> m_EventCalledObjects;

		// Token: 0x0400077C RID: 1916
		private Dictionary<IPanel, List<EventDebuggerDefaultActionTrace>> m_EventDefaultActionObjects;

		// Token: 0x0400077D RID: 1917
		private Dictionary<IPanel, List<EventDebuggerPathTrace>> m_EventPathObjects;

		// Token: 0x0400077E RID: 1918
		private Dictionary<IPanel, List<EventDebuggerTrace>> m_EventProcessedEvents;

		// Token: 0x0400077F RID: 1919
		private Dictionary<IPanel, Stack<EventDebuggerTrace>> m_StackOfProcessedEvent;

		// Token: 0x04000780 RID: 1920
		private Dictionary<IPanel, Dictionary<long, int>> m_EventTypeProcessedCount;

		// Token: 0x04000781 RID: 1921
		private readonly Dictionary<IPanel, long> m_ModificationCount;

		// Token: 0x04000782 RID: 1922
		private readonly bool m_Log;

		// Token: 0x02000238 RID: 568
		internal struct HistogramRecord
		{
			// Token: 0x04000784 RID: 1924
			public long count;

			// Token: 0x04000785 RID: 1925
			public long duration;
		}
	}
}
