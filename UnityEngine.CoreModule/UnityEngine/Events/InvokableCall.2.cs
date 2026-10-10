using System;
using System.Diagnostics;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002BB RID: 699
	internal class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06001D3E RID: 7486 RVA: 0x0002EE18 File Offset: 0x0002D018
		// (remove) Token: 0x06001D3F RID: 7487 RVA: 0x0002EE50 File Offset: 0x0002D050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event UnityAction<T1> Delegate;

		// Token: 0x06001D40 RID: 7488 RVA: 0x0002EE85 File Offset: 0x0002D085
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate += (UnityAction<T1>)System.Delegate.CreateDelegate(typeof(UnityAction<T1>), target, theFunction);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0002EEAE File Offset: 0x0002D0AE
		public InvokableCall(UnityAction<T1> action)
		{
			this.Delegate += action;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		public override void Invoke(object[] args)
		{
			bool flag = args.Length != 1;
			if (flag)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			bool flag2 = BaseInvokableCall.AllowInvoke(this.Delegate);
			if (flag2)
			{
				this.Delegate((T1)((object)args[0]));
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0002EF14 File Offset: 0x0002D114
		public virtual void Invoke(T1 args0)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			if (flag)
			{
				this.Delegate(args0);
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0002EF40 File Offset: 0x0002D140
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.Method.Equals(method);
		}
	}
}
