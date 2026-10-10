using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000082 RID: 130
	[NullableContext(1)]
	[Nullable(0)]
	internal class RetryRequest : IRetryRequest
	{
		// Token: 0x0600024A RID: 586 RVA: 0x000065C3 File Offset: 0x000047C3
		public RetryRequest(Action request, IRetryPolicy retryPolicy, IUtil util)
		{
			this.m_Request = request;
			this.m_RetryPolicy = retryPolicy;
			this.m_Util = util;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000065E0 File Offset: 0x000047E0
		public Task<bool> Invoke()
		{
			return this.RunTaskOnMainThread(new Func<Task<bool>>(this.InvokeFromMainThread));
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000065F4 File Offset: 0x000047F4
		public Task<bool> RunTaskOnMainThread(Func<Task<bool>> function)
		{
			RetryRequest.<>c__DisplayClass7_0 CS$<>8__locals1 = new RetryRequest.<>c__DisplayClass7_0();
			CS$<>8__locals1.function = function;
			CS$<>8__locals1.completionSource = new TaskCompletionSource<bool>();
			this.m_Util.RunOnMainThread(new Action(CS$<>8__locals1.<RunTaskOnMainThread>g__RunRequestAndSetResult|0));
			return CS$<>8__locals1.completionSource.Task;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000663C File Offset: 0x0000483C
		private Task<bool> InvokeFromMainThread()
		{
			RetryRequest.<InvokeFromMainThread>d__8 <InvokeFromMainThread>d__;
			<InvokeFromMainThread>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<InvokeFromMainThread>d__.<>4__this = this;
			<InvokeFromMainThread>d__.<>1__state = -1;
			<InvokeFromMainThread>d__.<>t__builder.Start<RetryRequest.<InvokeFromMainThread>d__8>(ref <InvokeFromMainThread>d__);
			return <InvokeFromMainThread>d__.<>t__builder.Task;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000667F File Offset: 0x0000487F
		private void FirstTry()
		{
			this.m_StartTime = Time.time;
			this.m_NumberOfAttempts++;
			this.m_Request();
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000066A8 File Offset: 0x000048A8
		public Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription)
		{
			RetryRequest.<Retry>d__10 <Retry>d__;
			<Retry>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<Retry>d__.<>4__this = this;
			<Retry>d__.requestFailureDescription = requestFailureDescription;
			<Retry>d__.<>1__state = -1;
			<Retry>d__.<>t__builder.Start<RetryRequest.<Retry>d__10>(ref <Retry>d__);
			return <Retry>d__.<>t__builder.Task;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000066F4 File Offset: 0x000048F4
		private Task<bool> RetryFromMainThread()
		{
			RetryRequest.<RetryFromMainThread>d__11 <RetryFromMainThread>d__;
			<RetryFromMainThread>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<RetryFromMainThread>d__.<>4__this = this;
			<RetryFromMainThread>d__.<>1__state = -1;
			<RetryFromMainThread>d__.<>t__builder.Start<RetryRequest.<RetryFromMainThread>d__11>(ref <RetryFromMainThread>d__);
			return <RetryFromMainThread>d__.<>t__builder.Task;
		}

		// Token: 0x040000B9 RID: 185
		private float m_StartTime;

		// Token: 0x040000BA RID: 186
		private int m_NumberOfAttempts;

		// Token: 0x040000BB RID: 187
		private readonly Action m_Request;

		// Token: 0x040000BC RID: 188
		private readonly IRetryPolicy m_RetryPolicy;

		// Token: 0x040000BD RID: 189
		private readonly IUtil m_Util;
	}
}
