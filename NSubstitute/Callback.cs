using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using NSubstitute.Callbacks;
using NSubstitute.Core;

namespace NSubstitute
{
	// Token: 0x02000013 RID: 19
	public class Callback
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000024CB File Offset: 0x000006CB
		public static ConfiguredCallback First(Action<CallInfo> doThis)
		{
			return new ConfiguredCallback().Then(doThis);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024D8 File Offset: 0x000006D8
		public static Callback Always(Action<CallInfo> doThis)
		{
			return new ConfiguredCallback().AndAlways(doThis);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024E5 File Offset: 0x000006E5
		public static ConfiguredCallback FirstThrow<TException>(Func<CallInfo, TException> throwThis) where TException : Exception
		{
			return new ConfiguredCallback().ThenThrow<TException>(throwThis);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024F4 File Offset: 0x000006F4
		public static ConfiguredCallback FirstThrow<TException>(TException exception) where TException : Exception
		{
			return new ConfiguredCallback().ThenThrow<TException>((CallInfo info) => exception);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002524 File Offset: 0x00000724
		public static Callback AlwaysThrow<TException>(Func<CallInfo, TException> throwThis) where TException : Exception
		{
			return new ConfiguredCallback().AndAlways(Callback.ToCallback<TException>(throwThis));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002536 File Offset: 0x00000736
		public static Callback AlwaysThrow<TException>(TException exception) where TException : Exception
		{
			return Callback.AlwaysThrow<TException>((CallInfo _) => exception);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002554 File Offset: 0x00000754
		protected static Action<CallInfo> ToCallback<[Nullable(1)] TException>(Func<CallInfo, TException> throwThis) where TException : Exception
		{
			return delegate(CallInfo ci)
			{
				if (throwThis != null)
				{
					throw throwThis(ci);
				}
			};
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002570 File Offset: 0x00000770
		internal Callback()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000025D8 File Offset: 0x000007D8
		protected void AddCallback(Action<CallInfo> doThis)
		{
			this.callbackQueue.Enqueue(doThis);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000025E6 File Offset: 0x000007E6
		protected void SetAlwaysDo(Action<CallInfo> always)
		{
			Action<CallInfo> action = always;
			if (always == null && (action = Callback.<>c.<>9__12_0) == null)
			{
				action = (Callback.<>c.<>9__12_0 = delegate(CallInfo _)
				{
				});
			}
			this.alwaysDo = action;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002612 File Offset: 0x00000812
		protected void SetKeepDoing(Action<CallInfo> keep)
		{
			Action<CallInfo> action = keep;
			if (keep == null && (action = Callback.<>c.<>9__13_0) == null)
			{
				action = (Callback.<>c.<>9__13_0 = delegate(CallInfo _)
				{
				});
			}
			this.keepDoing = action;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002640 File Offset: 0x00000840
		public void Call(CallInfo callInfo)
		{
			try
			{
				this.CallFromStack(callInfo);
			}
			finally
			{
				this.alwaysDo(callInfo);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002674 File Offset: 0x00000874
		private void CallFromStack(CallInfo callInfo)
		{
			Action<CallInfo> action;
			if (this.callbackQueue.TryDequeue(out action))
			{
				action(callInfo);
				return;
			}
			this.keepDoing(callInfo);
		}

		// Token: 0x0400000D RID: 13
		private readonly ConcurrentQueue<Action<CallInfo>> callbackQueue = new ConcurrentQueue<Action<CallInfo>>();

		// Token: 0x0400000E RID: 14
		private Action<CallInfo> alwaysDo = delegate(CallInfo x)
		{
		};

		// Token: 0x0400000F RID: 15
		private Action<CallInfo> keepDoing = delegate(CallInfo x)
		{
		};
	}
}
