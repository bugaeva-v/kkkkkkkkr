using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Events
{
	// Token: 0x020000C0 RID: 192
	public class DelegateEventWrapper<T> : RaiseEventWrapper
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00008173 File Offset: 0x00006373
		protected override string RaiseMethodName
		{
			get
			{
				return "Raise.Event";
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000817A File Offset: 0x0000637A
		public DelegateEventWrapper([Nullable(new byte[]
		{
			0,
			2
		})] params object[] arguments)
		{
			this._providedArguments = arguments;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000818C File Offset: 0x0000638C
		public static implicit operator T(DelegateEventWrapper<T> wrapper)
		{
			RaiseEventWrapper.RaiseEvent(wrapper);
			return default(T);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000081A8 File Offset: 0x000063A8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected override object[] WorkOutRequiredArguments(ICall call)
		{
			ParameterInfo[] parameters = typeof(T).GetInvokeMethod().GetParameters();
			if (this._providedArguments.Length < 2 && this.LooksLikeAnEventStyleCall(parameters))
			{
				return this.WorkOutSenderAndEventArgs(parameters[1].ParameterType, call);
			}
			if (!DelegateEventWrapper<T>.RequiredArgsHaveBeenProvided(this._providedArguments, parameters))
			{
				DelegateEventWrapper<T>.ThrowBecauseRequiredArgsNotProvided(parameters);
			}
			return this._providedArguments;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00008208 File Offset: 0x00006408
		private bool LooksLikeAnEventStyleCall(ParameterInfo[] parameters)
		{
			return parameters.Length == 2 && parameters[0].ParameterType == typeof(object) && typeof(EventArgs).IsAssignableFrom(parameters[1].ParameterType);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00008244 File Offset: 0x00006444
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private object[] WorkOutSenderAndEventArgs(Type eventArgsType, ICall call)
		{
			object obj;
			object obj2;
			if (this._providedArguments.Length == 0)
			{
				obj = call.Target();
				obj2 = base.GetDefaultForEventArgType(eventArgsType);
			}
			else if (this._providedArguments[0].IsCompatibleWith(eventArgsType))
			{
				obj = call.Target();
				obj2 = this._providedArguments[0];
			}
			else
			{
				obj = this._providedArguments[0];
				obj2 = base.GetDefaultForEventArgType(eventArgsType);
			}
			return new object[]
			{
				obj,
				obj2
			};
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000082AC File Offset: 0x000064AC
		private static bool RequiredArgsHaveBeenProvided([Nullable(new byte[]
		{
			0,
			2
		})] object[] providedArgs, ParameterInfo[] requiredArgs)
		{
			if (providedArgs.Length != requiredArgs.Length)
			{
				return false;
			}
			for (int i = 0; i < providedArgs.Length; i++)
			{
				Type parameterType = requiredArgs[i].ParameterType;
				if (!providedArgs[i].IsCompatibleWith(parameterType))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000082E8 File Offset: 0x000064E8
		private static void ThrowBecauseRequiredArgsNotProvided(ParameterInfo[] requiredArgs)
		{
			throw new ArgumentException(string.Format("Cannot raise event with the provided arguments. Use Raise.Event<{0}>({1}) to raise this event.", typeof(T).Name, string.Join(", ", (from x in requiredArgs
			select x.ParameterType.Name).ToArray<string>())));
		}

		// Token: 0x040000EB RID: 235
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly object[] _providedArguments;
	}
}
