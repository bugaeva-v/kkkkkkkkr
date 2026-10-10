using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x020002C8 RID: 712
	[Serializable]
	public class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x06001DAE RID: 7598 RVA: 0x00030328 File Offset: 0x0002E528
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00030339 File Offset: 0x0002E539
		public void AddListener(UnityAction<T0> call)
		{
			base.AddCall(UnityEvent<T0>.GetDelegate(call));
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00030213 File Offset: 0x0002E413
		public void RemoveListener(UnityAction<T0> call)
		{
			base.RemoveListener(call.Target, call.Method);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0003034C File Offset: 0x0002E54C
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return UnityEventBase.GetValidMethodInfo(targetObjType, name, new Type[]
			{
				typeof(T0)
			});
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00030378 File Offset: 0x0002E578
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0>(target, theFunction);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00030394 File Offset: 0x0002E594
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			return new InvokableCall<T0>(action);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000303AC File Offset: 0x0002E5AC
		public void Invoke(T0 arg0)
		{
			List<BaseInvokableCall> list = base.PrepareInvoke();
			for (int i = 0; i < list.Count; i++)
			{
				InvokableCall<T0> invokableCall = list[i] as InvokableCall<T0>;
				bool flag = invokableCall != null;
				if (flag)
				{
					invokableCall.Invoke(arg0);
				}
				else
				{
					InvokableCall invokableCall2 = list[i] as InvokableCall;
					bool flag2 = invokableCall2 != null;
					if (flag2)
					{
						invokableCall2.Invoke();
					}
					else
					{
						BaseInvokableCall baseInvokableCall = list[i];
						bool flag3 = this.m_InvokeArray == null;
						if (flag3)
						{
							this.m_InvokeArray = new object[1];
						}
						this.m_InvokeArray[0] = arg0;
						baseInvokableCall.Invoke(this.m_InvokeArray);
					}
				}
			}
		}

		// Token: 0x040009B2 RID: 2482
		private object[] m_InvokeArray = null;
	}
}
