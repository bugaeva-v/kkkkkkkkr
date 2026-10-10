using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000E RID: 14
	[NullableContext(1)]
	[Nullable(0)]
	internal class TaskQueue
	{
		// Token: 0x0600003F RID: 63 RVA: 0x0000233C File Offset: 0x0000053C
		public TaskQueue()
		{
			this.semaphore = new SemaphoreSlim(1);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002350 File Offset: 0x00000550
		public Task<T> Enqueue<[Nullable(2)] T>(Func<Task<T>> taskGenerator)
		{
			TaskQueue.<Enqueue>d__2<T> <Enqueue>d__;
			<Enqueue>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<Enqueue>d__.<>4__this = this;
			<Enqueue>d__.taskGenerator = taskGenerator;
			<Enqueue>d__.<>1__state = -1;
			<Enqueue>d__.<>t__builder.Start<TaskQueue.<Enqueue>d__2<T>>(ref <Enqueue>d__);
			return <Enqueue>d__.<>t__builder.Task;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000239C File Offset: 0x0000059C
		public Task Enqueue(Func<Task> taskGenerator)
		{
			TaskQueue.<Enqueue>d__3 <Enqueue>d__;
			<Enqueue>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Enqueue>d__.<>4__this = this;
			<Enqueue>d__.taskGenerator = taskGenerator;
			<Enqueue>d__.<>1__state = -1;
			<Enqueue>d__.<>t__builder.Start<TaskQueue.<Enqueue>d__3>(ref <Enqueue>d__);
			return <Enqueue>d__.<>t__builder.Task;
		}

		// Token: 0x04000008 RID: 8
		private readonly SemaphoreSlim semaphore;
	}
}
