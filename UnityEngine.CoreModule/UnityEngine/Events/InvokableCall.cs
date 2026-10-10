using System;
using System.Diagnostics;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002BA RID: 698
	internal class InvokableCall : BaseInvokableCall
	{
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06001D37 RID: 7479 RVA: 0x0002ECE4 File Offset: 0x0002CEE4
		// (remove) Token: 0x06001D38 RID: 7480 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event UnityAction Delegate;

		// Token: 0x06001D39 RID: 7481 RVA: 0x0002ED51 File Offset: 0x0002CF51
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate += (UnityAction)System.Delegate.CreateDelegate(typeof(UnityAction), target, theFunction);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0002ED7A File Offset: 0x0002CF7A
		public InvokableCall(UnityAction action)
		{
			this.Delegate += action;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0002ED8C File Offset: 0x0002CF8C
		public override void Invoke(object[] args)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			if (flag)
			{
				this.Delegate();
			}
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		public void Invoke()
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			if (flag)
			{
				this.Delegate();
			}
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.Method.Equals(method);
		}
	}
}
