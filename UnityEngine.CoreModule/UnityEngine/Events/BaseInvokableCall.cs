using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002B9 RID: 697
	internal abstract class BaseInvokableCall
	{
		// Token: 0x06001D31 RID: 7473 RVA: 0x00008CE3 File Offset: 0x00006EE3
		protected BaseInvokableCall()
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		protected BaseInvokableCall(object target, MethodInfo function)
		{
			bool flag = function == null;
			if (flag)
			{
				throw new ArgumentNullException("function");
			}
			bool isStatic = function.IsStatic;
			if (isStatic)
			{
				bool flag2 = target != null;
				if (flag2)
				{
					throw new ArgumentException("target must be null");
				}
			}
			else
			{
				bool flag3 = target == null;
				if (flag3)
				{
					throw new ArgumentNullException("target");
				}
			}
		}

		// Token: 0x06001D33 RID: 7475
		public abstract void Invoke(object[] args);

		// Token: 0x06001D34 RID: 7476 RVA: 0x0002EC50 File Offset: 0x0002CE50
		protected static void ThrowOnInvalidArg<T>(object arg)
		{
			bool flag = arg != null && !(arg is T);
			if (flag)
			{
				throw new ArgumentException(UnityString.Format("Passed argument 'args[0]' is of the wrong type. Type:{0} Expected:{1}", new object[]
				{
					arg.GetType(),
					typeof(T)
				}));
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
		protected static bool AllowInvoke(Delegate @delegate)
		{
			object target = @delegate.Target;
			bool flag = target == null;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				Object @object = target as Object;
				bool flag2 = @object != null;
				result = (!flag2 || @object != null);
			}
			return result;
		}

		// Token: 0x06001D36 RID: 7478
		public abstract bool Find(object targetObj, MethodInfo method);
	}
}
