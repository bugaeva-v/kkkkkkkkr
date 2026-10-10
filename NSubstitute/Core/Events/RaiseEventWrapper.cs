using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core.Events
{
	// Token: 0x020000C2 RID: 194
	public abstract class RaiseEventWrapper
	{
		// Token: 0x06000335 RID: 821
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected abstract object[] WorkOutRequiredArguments(ICall call);

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000336 RID: 822
		protected abstract string RaiseMethodName { get; }

		// Token: 0x06000337 RID: 823 RVA: 0x000083D4 File Offset: 0x000065D4
		protected EventArgs GetDefaultForEventArgType(Type type)
		{
			if (type == typeof(EventArgs))
			{
				return EventArgs.Empty;
			}
			ConstructorInfo defaultConstructor = RaiseEventWrapper.GetDefaultConstructor(type);
			if (defaultConstructor == null)
			{
				throw new CannotCreateEventArgsException(string.Format("Cannot create {0} for this event as it has no default constructor. Provide arguments for this event by calling {1}({0}).", type.Name, this.RaiseMethodName));
			}
			return (EventArgs)defaultConstructor.Invoke(new object[0]);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00008434 File Offset: 0x00006634
		[return: Nullable(2)]
		private static ConstructorInfo GetDefaultConstructor(Type type)
		{
			return type.GetConstructor(Type.EmptyTypes);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00008444 File Offset: 0x00006644
		protected static void RaiseEvent(RaiseEventWrapper wrapper)
		{
			SubstitutionContext.Current.ThreadContext.SetPendingRaisingEventArgumentsFactory((ICall call) => wrapper.WorkOutRequiredArguments(call));
		}
	}
}
