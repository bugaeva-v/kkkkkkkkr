using System;
using System.Linq.Expressions;
using NSubstitute.Core.Arguments;

namespace NSubstitute
{
	// Token: 0x02000012 RID: 18
	public static class Arg
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000231C File Offset: 0x0000051C
		public static ref T Any<T>()
		{
			return ArgumentMatcher.Enqueue<T>(new AnyArgumentMatcher(typeof(T)));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002332 File Offset: 0x00000532
		public static ref T Is<T>(T value)
		{
			return ArgumentMatcher.Enqueue<T>(new EqualsArgumentMatcher(value));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002344 File Offset: 0x00000544
		public static ref T Is<T>(Expression<Predicate<T>> predicate)
		{
			return ArgumentMatcher.Enqueue<T>(new ExpressionArgumentMatcher<T>(predicate));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002351 File Offset: 0x00000551
		public static ref Action Invoke()
		{
			return ArgumentMatcher.Enqueue<Action>(new AnyArgumentMatcher(typeof(Action)), Arg.InvokeDelegateAction(new object[0]));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002372 File Offset: 0x00000572
		public static ref Action<T> Invoke<T>(T arg)
		{
			return ArgumentMatcher.Enqueue<Action<T>>(new AnyArgumentMatcher(typeof(Action<T>)), Arg.InvokeDelegateAction(new object[]
			{
				arg
			}));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000239C File Offset: 0x0000059C
		public static ref Action<T1, T2> Invoke<T1, T2>(T1 arg1, T2 arg2)
		{
			return ArgumentMatcher.Enqueue<Action<T1, T2>>(new AnyArgumentMatcher(typeof(Action<T1, T2>)), Arg.InvokeDelegateAction(new object[]
			{
				arg1,
				arg2
			}));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023CF File Offset: 0x000005CF
		public static ref Action<T1, T2, T3> Invoke<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
		{
			return ArgumentMatcher.Enqueue<Action<T1, T2, T3>>(new AnyArgumentMatcher(typeof(Action<T1, T2, T3>)), Arg.InvokeDelegateAction(new object[]
			{
				arg1,
				arg2,
				arg3
			}));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000240C File Offset: 0x0000060C
		public static ref Action<T1, T2, T3, T4> Invoke<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			return ArgumentMatcher.Enqueue<Action<T1, T2, T3, T4>>(new AnyArgumentMatcher(typeof(Action<T1, T2, T3, T4>)), Arg.InvokeDelegateAction(new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4
			}));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000245C File Offset: 0x0000065C
		public static ref TDelegate InvokeDelegate<TDelegate>(params object[] arguments)
		{
			return ArgumentMatcher.Enqueue<TDelegate>(new AnyArgumentMatcher(typeof(TDelegate)), Arg.InvokeDelegateAction(arguments));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002478 File Offset: 0x00000678
		public static ref T Do<T>(Action<T> useArgument)
		{
			return ArgumentMatcher.Enqueue<T>(new AnyArgumentMatcher(typeof(T)), delegate(object x)
			{
				useArgument((T)((object)x));
			});
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000024B2 File Offset: 0x000006B2
		private static Action<object> InvokeDelegateAction(params object[] arguments)
		{
			return delegate(object x)
			{
				((Delegate)x).DynamicInvoke(arguments);
			};
		}

		// Token: 0x020000E5 RID: 229
		public static class Compat
		{
			// Token: 0x060003BD RID: 957 RVA: 0x000093D2 File Offset: 0x000075D2
			public unsafe static T Any<T>()
			{
				return *Arg.Any<T>();
			}

			// Token: 0x060003BE RID: 958 RVA: 0x000093DE File Offset: 0x000075DE
			public unsafe static T Is<T>(T value)
			{
				return *Arg.Is<T>(value);
			}

			// Token: 0x060003BF RID: 959 RVA: 0x000093EB File Offset: 0x000075EB
			public unsafe static T Is<T>(Expression<Predicate<T>> predicate)
			{
				return *Arg.Is<T>(predicate);
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x000093F8 File Offset: 0x000075F8
			public unsafe static Action Invoke()
			{
				return *Arg.Invoke();
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00009400 File Offset: 0x00007600
			public unsafe static Action<T> Invoke<T>(T arg)
			{
				return *Arg.Invoke<T>(arg);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00009409 File Offset: 0x00007609
			public unsafe static Action<T1, T2> Invoke<T1, T2>(T1 arg1, T2 arg2)
			{
				return *Arg.Invoke<T1, T2>(arg1, arg2);
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00009413 File Offset: 0x00007613
			public unsafe static Action<T1, T2, T3> Invoke<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
			{
				return *Arg.Invoke<T1, T2, T3>(arg1, arg2, arg3);
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x0000941E File Offset: 0x0000761E
			public unsafe static Action<T1, T2, T3, T4> Invoke<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
			{
				return *Arg.Invoke<T1, T2, T3, T4>(arg1, arg2, arg3, arg4);
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000942A File Offset: 0x0000762A
			public unsafe static TDelegate InvokeDelegate<TDelegate>(params object[] arguments)
			{
				return *Arg.InvokeDelegate<TDelegate>(arguments);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00009437 File Offset: 0x00007637
			public unsafe static T Do<T>(Action<T> useArgument)
			{
				return *Arg.Do<T>(useArgument);
			}
		}
	}
}
