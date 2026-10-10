using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Scripting;

namespace Firebase.Unity
{
	// Token: 0x02000006 RID: 6
	[Preserve]
	internal class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000250F File Offset: 0x0000070F
		private UnitySynchronizationContext(GameObject gameObject)
		{
			this.mainThreadId = Thread.CurrentThread.ManagedThreadId;
			this.behavior = gameObject.AddComponent<UnitySynchronizationContext.SynchronizationContextBehavoir>();
			this.queue = this.behavior.CallbackQueue;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002548 File Offset: 0x00000748
		public static UnitySynchronizationContext Instance
		{
			get
			{
				bool flag = UnitySynchronizationContext._instance == null;
				if (flag)
				{
					throw new InvalidOperationException("SyncContext not initialized.");
				}
				return UnitySynchronizationContext._instance;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002578 File Offset: 0x00000778
		public static void Create(GameObject gameObject)
		{
			bool flag = UnitySynchronizationContext._instance == null;
			if (flag)
			{
				UnitySynchronizationContext._instance = new UnitySynchronizationContext(gameObject);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000259F File Offset: 0x0000079F
		public static void Destroy()
		{
			UnitySynchronizationContext._instance = null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025A8 File Offset: 0x000007A8
		private ManualResetEvent GetThreadEvent()
		{
			Dictionary<int, ManualResetEvent> obj = UnitySynchronizationContext.signalDictionary;
			ManualResetEvent manualResetEvent;
			lock (obj)
			{
				bool flag2 = !UnitySynchronizationContext.signalDictionary.TryGetValue(Thread.CurrentThread.ManagedThreadId, out manualResetEvent);
				if (flag2)
				{
					manualResetEvent = new ManualResetEvent(false);
					UnitySynchronizationContext.signalDictionary[Thread.CurrentThread.ManagedThreadId] = manualResetEvent;
				}
			}
			manualResetEvent.Reset();
			return manualResetEvent;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002630 File Offset: 0x00000830
		public void PostCoroutine(Func<IEnumerator> coroutine)
		{
			this.Post(delegate(object x)
			{
				Func<IEnumerator> func = (Func<IEnumerator>)x;
				this.behavior.StartCoroutine(func());
			}, coroutine);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002647 File Offset: 0x00000847
		private IEnumerator SignaledCoroutine(Func<IEnumerator> coroutine, ManualResetEvent newSignal)
		{
			yield return coroutine();
			newSignal.Set();
			yield break;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002664 File Offset: 0x00000864
		public void SendCoroutine(Func<IEnumerator> coroutine, int timeout = 15000)
		{
			bool flag = this.mainThreadId == Thread.CurrentThread.ManagedThreadId;
			if (flag)
			{
				this.behavior.StartCoroutine(coroutine());
			}
			else
			{
				ManualResetEvent newSignal = this.GetThreadEvent();
				this.PostCoroutine(() => this.SignaledCoroutine(coroutine, newSignal));
				newSignal.WaitOne(timeout);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000026F4 File Offset: 0x000008F4
		public override void Post(SendOrPostCallback d, object state)
		{
			Queue<Tuple<SendOrPostCallback, object>> obj = this.queue;
			lock (obj)
			{
				this.queue.Enqueue(new Tuple<SendOrPostCallback, object>(d, state));
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002748 File Offset: 0x00000948
		public override void Send(SendOrPostCallback d, object state)
		{
			bool flag = this.mainThreadId == Thread.CurrentThread.ManagedThreadId;
			if (flag)
			{
				d(state);
			}
			else
			{
				ManualResetEvent newSignal = this.GetThreadEvent();
				this.Post(delegate(object x)
				{
					try
					{
						d(x);
					}
					catch (Exception ex)
					{
						Debug.Log(ex.ToString());
					}
					newSignal.Set();
				}, state);
				newSignal.WaitOne(15000);
			}
		}

		// Token: 0x04000005 RID: 5
		private static UnitySynchronizationContext _instance = null;

		// Token: 0x04000006 RID: 6
		private Queue<Tuple<SendOrPostCallback, object>> queue;

		// Token: 0x04000007 RID: 7
		private UnitySynchronizationContext.SynchronizationContextBehavoir behavior;

		// Token: 0x04000008 RID: 8
		private int mainThreadId;

		// Token: 0x04000009 RID: 9
		private const int Timeout = 15000;

		// Token: 0x0400000A RID: 10
		private static Dictionary<int, ManualResetEvent> signalDictionary = new Dictionary<int, ManualResetEvent>();

		// Token: 0x0200001D RID: 29
		private class SynchronizationContextBehavoir : MonoBehaviour
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00003B54 File Offset: 0x00001D54
			public Queue<Tuple<SendOrPostCallback, object>> CallbackQueue
			{
				get
				{
					bool flag = this.callbackQueue == null;
					if (flag)
					{
						this.callbackQueue = new Queue<Tuple<SendOrPostCallback, object>>();
					}
					return this.callbackQueue;
				}
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00003B86 File Offset: 0x00001D86
			[Preserve]
			private IEnumerator Start()
			{
				for (;;)
				{
					Tuple<SendOrPostCallback, object> entry = null;
					Queue<Tuple<SendOrPostCallback, object>> obj = this.CallbackQueue;
					lock (obj)
					{
						bool flag2 = this.CallbackQueue.Count > 0;
						if (flag2)
						{
							entry = this.CallbackQueue.Dequeue();
						}
					}
					obj = null;
					bool flag3 = entry != null && entry.Item1 != null;
					if (flag3)
					{
						try
						{
							entry.Item1(entry.Item2);
						}
						catch (Exception ex)
						{
							Exception e = ex;
							Debug.Log(e.ToString());
						}
					}
					yield return null;
					entry = null;
				}
				yield break;
			}

			// Token: 0x04000035 RID: 53
			private Queue<Tuple<SendOrPostCallback, object>> callbackQueue;
		}
	}
}
