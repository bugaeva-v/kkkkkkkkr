using System;
using System.Linq.Expressions;

namespace NSubstitute.Compatibility
{
	// Token: 0x020000E2 RID: 226
	public class CompatArg
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x000092A4 File Offset: 0x000074A4
		private CompatArg()
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000092AC File Offset: 0x000074AC
		public unsafe T Any<T>()
		{
			return *Arg.Any<T>();
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000092B8 File Offset: 0x000074B8
		public unsafe T Is<T>(T value)
		{
			return *Arg.Is<T>(value);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000092C5 File Offset: 0x000074C5
		public unsafe T Is<T>(Expression<Predicate<T>> predicate)
		{
			return *Arg.Is<T>(predicate);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000092D2 File Offset: 0x000074D2
		public unsafe Action Invoke()
		{
			return *Arg.Invoke();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000092DA File Offset: 0x000074DA
		public unsafe Action<T> Invoke<T>(T arg)
		{
			return *Arg.Invoke<T>(arg);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000092E3 File Offset: 0x000074E3
		public unsafe Action<T1, T2> Invoke<T1, T2>(T1 arg1, T2 arg2)
		{
			return *Arg.Invoke<T1, T2>(arg1, arg2);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000092ED File Offset: 0x000074ED
		public unsafe Action<T1, T2, T3> Invoke<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
		{
			return *Arg.Invoke<T1, T2, T3>(arg1, arg2, arg3);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000092F8 File Offset: 0x000074F8
		public unsafe Action<T1, T2, T3, T4> Invoke<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			return *Arg.Invoke<T1, T2, T3, T4>(arg1, arg2, arg3, arg4);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00009305 File Offset: 0x00007505
		public unsafe TDelegate InvokeDelegate<TDelegate>(params object[] arguments)
		{
			return *Arg.InvokeDelegate<TDelegate>(arguments);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00009312 File Offset: 0x00007512
		public unsafe T Do<T>(Action<T> useArgument)
		{
			return *Arg.Do<T>(useArgument);
		}

		// Token: 0x0400010B RID: 267
		public static readonly CompatArg Instance = new CompatArg();
	}
}
