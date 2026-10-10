using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NSubstitute.ClearExtensions;
using NSubstitute.Core;
using NSubstitute.Exceptions;
using NSubstitute.ReceivedExtensions;

namespace NSubstitute
{
	// Token: 0x02000018 RID: 24
	public static class SubstituteExtensions
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000284A File Offset: 0x00000A4A
		public static T Received<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return substitute.Received(Quantity.AtLeastOne());
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002865 File Offset: 0x00000A65
		public static T Received<T>(this T substitute, int requiredNumberOfCalls) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return substitute.Received(Quantity.Exactly(requiredNumberOfCalls));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002881 File Offset: 0x00000A81
		public static T DidNotReceive<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return substitute.Received(Quantity.None());
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000289C File Offset: 0x00000A9C
		public static T ReceivedWithAnyArgs<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return substitute.ReceivedWithAnyArgs(Quantity.AtLeastOne());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000028B7 File Offset: 0x00000AB7
		public static T ReceivedWithAnyArgs<T>(this T substitute, int requiredNumberOfCalls) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return substitute.ReceivedWithAnyArgs(Quantity.Exactly(requiredNumberOfCalls));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000028D3 File Offset: 0x00000AD3
		public static T DidNotReceiveWithAnyArgs<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return substitute.ReceivedWithAnyArgs(Quantity.None());
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000028EE File Offset: 0x00000AEE
		public static IEnumerable<ICall> ReceivedCalls<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return SubstitutionContext.Current.GetCallRouterFor(substitute).ReceivedCalls();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002913 File Offset: 0x00000B13
		public static void ClearReceivedCalls<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			substitute.ClearSubstitute(ClearOptions.ReceivedCalls);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000292A File Offset: 0x00000B2A
		public static ConfiguredCall Returns<T>(this T value, T returnThis, params T[] returnThese)
		{
			return SubstituteExtensions.ConfigureReturn<T>(MatchArgs.AsSpecifiedInCall, returnThis, returnThese);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002938 File Offset: 0x00000B38
		public static ConfiguredCall Returns<T>(this T value, Func<CallInfo, T> returnThis, params Func<CallInfo, T>[] returnThese)
		{
			return SubstituteExtensions.ConfigureReturn<T>(MatchArgs.AsSpecifiedInCall, returnThis, returnThese);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002946 File Offset: 0x00000B46
		public static ConfiguredCall ReturnsForAnyArgs<T>(this T value, T returnThis, params T[] returnThese)
		{
			return SubstituteExtensions.ConfigureReturn<T>(MatchArgs.Any, returnThis, returnThese);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002954 File Offset: 0x00000B54
		public static ConfiguredCall ReturnsForAnyArgs<T>(this T value, Func<CallInfo, T> returnThis, params Func<CallInfo, T>[] returnThese)
		{
			return SubstituteExtensions.ConfigureReturn<T>(MatchArgs.Any, returnThis, returnThese);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002964 File Offset: 0x00000B64
		private static ConfiguredCall ConfigureReturn<T>(MatchArgs matchArgs, [Nullable(2)] T returnThis, [Nullable(2)] T[] returnThese)
		{
			IReturn value;
			if (returnThese == null || returnThese.Length == 0)
			{
				value = new ReturnValue(returnThis);
			}
			else
			{
				value = new ReturnMultipleValues<T>(new T[]
				{
					returnThis
				}.Concat(returnThese).ToArray<T>());
			}
			return SubstitutionContext.Current.ThreadContext.LastCallShouldReturn(value, matchArgs);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000029B8 File Offset: 0x00000BB8
		private static ConfiguredCall ConfigureReturn<T>(MatchArgs matchArgs, [Nullable(new byte[]
		{
			0,
			0,
			2
		})] Func<CallInfo, T> returnThis, [Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})] Func<CallInfo, T>[] returnThese)
		{
			IReturn value;
			if (returnThese == null || returnThese.Length == 0)
			{
				value = new ReturnValueFromFunc<T>(returnThis);
			}
			else
			{
				value = new ReturnMultipleFuncsValues<T>(new Func<CallInfo, T>[]
				{
					returnThis
				}.Concat(returnThese).ToArray<Func<CallInfo, T>>());
			}
			return SubstitutionContext.Current.ThreadContext.LastCallShouldReturn(value, matchArgs);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002A04 File Offset: 0x00000C04
		public static ConfiguredCall Returns<T>(this Task<T> value, T returnThis, params T[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			Task<T> returnThis2 = SubstituteExtensions.CompletedTask<T>(returnThis);
			Task<T>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<T, Task<T>>(SubstituteExtensions.CompletedTask<T>)).ToArray<Task<T>>() : null;
			return SubstituteExtensions.ConfigureReturn<Task<T>>(MatchArgs.AsSpecifiedInCall, returnThis2, returnThese2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A4C File Offset: 0x00000C4C
		public static ConfiguredCall Returns<T>(this Task<T> value, Func<CallInfo, T> returnThis, params Func<CallInfo, T>[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			Func<CallInfo, Task<T>> returnThis2 = SubstituteExtensions.WrapFuncInTask<T>(returnThis);
			Func<CallInfo, Task<T>>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<Func<CallInfo, T>, Func<CallInfo, Task<T>>>(SubstituteExtensions.WrapFuncInTask<T>)).ToArray<Func<CallInfo, Task<T>>>() : null;
			return SubstituteExtensions.ConfigureReturn<Task<T>>(MatchArgs.AsSpecifiedInCall, returnThis2, returnThese2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002A94 File Offset: 0x00000C94
		public static ConfiguredCall ReturnsForAnyArgs<T>(this Task<T> value, T returnThis, params T[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			Task<T> returnThis2 = SubstituteExtensions.CompletedTask<T>(returnThis);
			Task<T>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<T, Task<T>>(SubstituteExtensions.CompletedTask<T>)).ToArray<Task<T>>() : null;
			return SubstituteExtensions.ConfigureReturn<Task<T>>(MatchArgs.Any, returnThis2, returnThese2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002ADC File Offset: 0x00000CDC
		public static ConfiguredCall ReturnsForAnyArgs<T>(this Task<T> value, Func<CallInfo, T> returnThis, params Func<CallInfo, T>[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			Func<CallInfo, Task<T>> returnThis2 = SubstituteExtensions.WrapFuncInTask<T>(returnThis);
			Func<CallInfo, Task<T>>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<Func<CallInfo, T>, Func<CallInfo, Task<T>>>(SubstituteExtensions.WrapFuncInTask<T>)).ToArray<Func<CallInfo, Task<T>>>() : null;
			return SubstituteExtensions.ConfigureReturn<Task<T>>(MatchArgs.Any, returnThis2, returnThese2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002B24 File Offset: 0x00000D24
		private static void ReThrowOnNSubstituteFault<T>([Nullable(new byte[]
		{
			0,
			2
		})] Task<T> task)
		{
			if (task.IsFaulted && task.Exception.InnerExceptions.FirstOrDefault<Exception>() is SubstituteException)
			{
				task.GetAwaiter().GetResult();
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002B5F File Offset: 0x00000D5F
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static Task<T> CompletedTask<T>([Nullable(2)] T result)
		{
			return Task.FromResult<T>(result);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002B67 File Offset: 0x00000D67
		[return: Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})]
		private static Func<CallInfo, Task<T>> WrapFuncInTask<T>(Func<CallInfo, T> returnThis)
		{
			return (CallInfo x) => SubstituteExtensions.CompletedTask<T>(returnThis(x));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002B80 File Offset: 0x00000D80
		public static ConfiguredCall Returns<T>(this ValueTask<T> value, T returnThis, params T[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			ValueTask<T> returnThis2 = SubstituteExtensions.CompletedValueTask<T>(returnThis);
			ValueTask<T>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<T, ValueTask<T>>(SubstituteExtensions.CompletedValueTask<T>)).ToArray<ValueTask<T>>() : null;
			return SubstituteExtensions.ConfigureReturn<ValueTask<T>>(MatchArgs.AsSpecifiedInCall, returnThis2, returnThese2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public static ConfiguredCall Returns<T>(this ValueTask<T> value, Func<CallInfo, T> returnThis, params Func<CallInfo, T>[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			Func<CallInfo, ValueTask<T>> returnThis2 = SubstituteExtensions.WrapFuncInValueTask<T>(returnThis);
			Func<CallInfo, ValueTask<T>>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<Func<CallInfo, T>, Func<CallInfo, ValueTask<T>>>(SubstituteExtensions.WrapFuncInValueTask<T>)).ToArray<Func<CallInfo, ValueTask<T>>>() : null;
			return SubstituteExtensions.ConfigureReturn<ValueTask<T>>(MatchArgs.AsSpecifiedInCall, returnThis2, returnThese2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002C10 File Offset: 0x00000E10
		public static ConfiguredCall ReturnsForAnyArgs<T>(this ValueTask<T> value, T returnThis, params T[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			ValueTask<T> returnThis2 = SubstituteExtensions.CompletedValueTask<T>(returnThis);
			ValueTask<T>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<T, ValueTask<T>>(SubstituteExtensions.CompletedValueTask<T>)).ToArray<ValueTask<T>>() : null;
			return SubstituteExtensions.ConfigureReturn<ValueTask<T>>(MatchArgs.Any, returnThis2, returnThese2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002C58 File Offset: 0x00000E58
		public static ConfiguredCall ReturnsForAnyArgs<T>(this ValueTask<T> value, Func<CallInfo, T> returnThis, params Func<CallInfo, T>[] returnThese)
		{
			SubstituteExtensions.ReThrowOnNSubstituteFault<T>(value);
			Func<CallInfo, ValueTask<T>> returnThis2 = SubstituteExtensions.WrapFuncInValueTask<T>(returnThis);
			Func<CallInfo, ValueTask<T>>[] returnThese2 = (returnThese.Length != 0) ? returnThese.Select(new Func<Func<CallInfo, T>, Func<CallInfo, ValueTask<T>>>(SubstituteExtensions.WrapFuncInValueTask<T>)).ToArray<Func<CallInfo, ValueTask<T>>>() : null;
			return SubstituteExtensions.ConfigureReturn<ValueTask<T>>(MatchArgs.Any, returnThis2, returnThese2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002CA0 File Offset: 0x00000EA0
		private static void ReThrowOnNSubstituteFault<T>([Nullable(new byte[]
		{
			0,
			2
		})] ValueTask<T> task)
		{
			if (task.IsFaulted && task.AsTask().Exception.InnerExceptions.FirstOrDefault<Exception>() is SubstituteException)
			{
				task.GetAwaiter().GetResult();
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002CE3 File Offset: 0x00000EE3
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static ValueTask<T> CompletedValueTask<T>([Nullable(2)] T result)
		{
			return new ValueTask<T>(result);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002CEB File Offset: 0x00000EEB
		[return: Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})]
		private static Func<CallInfo, ValueTask<T>> WrapFuncInValueTask<T>(Func<CallInfo, T> returnThis)
		{
			return (CallInfo x) => SubstituteExtensions.CompletedValueTask<T>(returnThis(x));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002D04 File Offset: 0x00000F04
		public static WhenCalled<T> When<T>(this T substitute, Action<T> substituteCall) where T : class
		{
			return SubstituteExtensions.MakeWhenCalled<T>(substitute, substituteCall, MatchArgs.AsSpecifiedInCall);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002D12 File Offset: 0x00000F12
		public static WhenCalled<T> WhenForAnyArgs<T>(this T substitute, Action<T> substituteCall) where T : class
		{
			return SubstituteExtensions.MakeWhenCalled<T>(substitute, substituteCall, MatchArgs.Any);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002D20 File Offset: 0x00000F20
		private static WhenCalled<TSubstitute> MakeWhenCalled<TSubstitute>([Nullable(2)] TSubstitute substitute, Action<TSubstitute> action, MatchArgs matchArgs)
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			return new WhenCalled<TSubstitute>(SubstitutionContext.Current, substitute, action, matchArgs);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002D40 File Offset: 0x00000F40
		public static WhenCalled<T> When<T>(this T substitute, Func<T, Task> substituteCall) where T : class
		{
			return SubstituteExtensions.MakeWhenCalled<T>(substitute, delegate(T x)
			{
				substituteCall(x);
			}, MatchArgs.AsSpecifiedInCall);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002D74 File Offset: 0x00000F74
		public static WhenCalled<T> WhenForAnyArgs<T>(this T substitute, Func<T, Task> substituteCall) where T : class
		{
			return SubstituteExtensions.MakeWhenCalled<T>(substitute, delegate(T x)
			{
				substituteCall(x);
			}, MatchArgs.Any);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public static WhenCalled<TSubstitute> When<TSubstitute, TResult>(this TSubstitute substitute, Func<TSubstitute, ValueTask<TResult>> substituteCall) where TSubstitute : class
		{
			return SubstituteExtensions.MakeWhenCalled<TSubstitute>(substitute, delegate(TSubstitute x)
			{
				substituteCall(x);
			}, MatchArgs.AsSpecifiedInCall);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002DDC File Offset: 0x00000FDC
		public static WhenCalled<TSubstitute> WhenForAnyArgs<TSubstitute, TResult>(this TSubstitute substitute, Func<TSubstitute, ValueTask<TResult>> substituteCall) where TSubstitute : class
		{
			return SubstituteExtensions.MakeWhenCalled<TSubstitute>(substitute, delegate(TSubstitute x)
			{
				substituteCall(x);
			}, MatchArgs.Any);
		}
	}
}
