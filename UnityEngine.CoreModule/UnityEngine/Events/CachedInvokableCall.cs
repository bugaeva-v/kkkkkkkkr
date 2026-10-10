using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002BF RID: 703
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x06001D5A RID: 7514 RVA: 0x0002F3F0 File Offset: 0x0002D5F0
		public CachedInvokableCall(Object target, MethodInfo theFunction, T argument) : base(target, theFunction)
		{
			this.m_Arg1 = argument;
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0002F403 File Offset: 0x0002D603
		public override void Invoke(object[] args)
		{
			base.Invoke(this.m_Arg1);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0002F403 File Offset: 0x0002D603
		public override void Invoke(T arg0)
		{
			base.Invoke(this.m_Arg1);
		}

		// Token: 0x0400099E RID: 2462
		private readonly T m_Arg1;
	}
}
