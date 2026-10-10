using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000317 RID: 791
	internal static class TaskAwaiters
	{
		// Token: 0x060021C4 RID: 8644 RVA: 0x0007918D File Offset: 0x0007738D
		public static ForceAsyncAwaiter ForceAsync(this Task task)
		{
			return new ForceAsyncAwaiter(task);
		}
	}
}
