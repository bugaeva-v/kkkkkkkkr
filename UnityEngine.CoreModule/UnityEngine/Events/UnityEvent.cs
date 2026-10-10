using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x020002C6 RID: 710
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x000301F2 File Offset: 0x0002E3F2
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00030203 File Offset: 0x0002E403
		public void AddListener(UnityAction call)
		{
			base.AddCall(UnityEvent.GetDelegate(call));
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00030213 File Offset: 0x0002E413
		public void RemoveListener(UnityAction call)
		{
			base.RemoveListener(call.Target, call.Method);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0003022C File Offset: 0x0002E42C
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return UnityEventBase.GetValidMethodInfo(targetObjType, name, new Type[0]);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0003024C File Offset: 0x0002E44C
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall(target, theFunction);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00030268 File Offset: 0x0002E468
		private static BaseInvokableCall GetDelegate(UnityAction action)
		{
			return new InvokableCall(action);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00030280 File Offset: 0x0002E480
		public void Invoke()
		{
			List<BaseInvokableCall> list = base.PrepareInvoke();
			for (int i = 0; i < list.Count; i++)
			{
				InvokableCall invokableCall = list[i] as InvokableCall;
				bool flag = invokableCall != null;
				if (flag)
				{
					invokableCall.Invoke();
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
							this.m_InvokeArray = new object[0];
						}
						baseInvokableCall.Invoke(this.m_InvokeArray);
					}
				}
			}
		}

		// Token: 0x040009B1 RID: 2481
		private object[] m_InvokeArray = null;
	}
}
