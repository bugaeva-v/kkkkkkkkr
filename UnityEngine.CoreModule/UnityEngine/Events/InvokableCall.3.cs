using System;
using System.Diagnostics;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002BC RID: 700
	internal class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06001D45 RID: 7493 RVA: 0x0002EF74 File Offset: 0x0002D174
		// (remove) Token: 0x06001D46 RID: 7494 RVA: 0x0002EFAC File Offset: 0x0002D1AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event UnityAction<T1, T2> Delegate;

		// Token: 0x06001D47 RID: 7495 RVA: 0x0002EFE1 File Offset: 0x0002D1E1
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2>)System.Delegate.CreateDelegate(typeof(UnityAction<T1, T2>), target, theFunction);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0002F009 File Offset: 0x0002D209
		public InvokableCall(UnityAction<T1, T2> action)
		{
			this.Delegate += action;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0002F01C File Offset: 0x0002D21C
		public override void Invoke(object[] args)
		{
			bool flag = args.Length != 2;
			if (flag)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			bool flag2 = BaseInvokableCall.AllowInvoke(this.Delegate);
			if (flag2)
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]));
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0002F080 File Offset: 0x0002D280
		public void Invoke(T1 args0, T2 args1)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			if (flag)
			{
				this.Delegate(args0, args1);
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.Method.Equals(method);
		}
	}
}
