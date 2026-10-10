using System;
using System.Reflection;
using NSubstitute.Core;
using NSubstitute.Core.Events;

namespace NSubstitute
{
	// Token: 0x02000015 RID: 21
	public static class Raise
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000026A4 File Offset: 0x000008A4
		public static EventHandlerWrapper<TEventArgs> EventWith<TEventArgs>(object sender, TEventArgs eventArgs) where TEventArgs : EventArgs
		{
			return new EventHandlerWrapper<TEventArgs>(sender, eventArgs);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000026B2 File Offset: 0x000008B2
		public static EventHandlerWrapper<TEventArgs> EventWith<TEventArgs>(TEventArgs eventArgs) where TEventArgs : EventArgs
		{
			return new EventHandlerWrapper<TEventArgs>(eventArgs);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000026BF File Offset: 0x000008BF
		public static EventHandlerWrapper<TEventArgs> EventWith<TEventArgs>() where TEventArgs : EventArgs
		{
			return new EventHandlerWrapper<TEventArgs>();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000026C6 File Offset: 0x000008C6
		public static EventHandlerWrapper<EventArgs> Event()
		{
			return new EventHandlerWrapper<EventArgs>();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000026CD File Offset: 0x000008CD
		public static DelegateEventWrapper<THandler> Event<THandler>(params object[] arguments)
		{
			return new DelegateEventWrapper<THandler>(Raise.FixParamsArrayAmbiguity(arguments, typeof(THandler)));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000026E4 File Offset: 0x000008E4
		private static object[] FixParamsArrayAmbiguity(object[] arguments, Type delegateType)
		{
			ParameterInfo[] parameters = delegateType.GetInvokeMethod().GetParameters();
			if (parameters.Length != 1)
			{
				return arguments;
			}
			Type parameterType = parameters[0].ParameterType;
			if (!parameterType.IsArray)
			{
				return arguments;
			}
			if (arguments.Length == 1 && parameterType.IsInstanceOfType(arguments[0]))
			{
				return arguments;
			}
			if (parameterType.IsInstanceOfType(arguments))
			{
				return new object[]
				{
					arguments
				};
			}
			return arguments;
		}
	}
}
