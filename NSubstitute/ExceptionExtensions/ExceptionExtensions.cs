using System;
using System.Runtime.CompilerServices;
using NSubstitute.Core;

namespace NSubstitute.ExceptionExtensions
{
	// Token: 0x02000046 RID: 70
	public static class ExceptionExtensions
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00004668 File Offset: 0x00002868
		public static ConfiguredCall Throws(this object value, Exception ex)
		{
			return value.Returns(delegate(CallInfo _)
			{
				throw ex;
			}, new Func<CallInfo, object>[0]);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000469A File Offset: 0x0000289A
		public static ConfiguredCall Throws<[Nullable(1)] TException>(this object value) where TException : Exception, new()
		{
			return value.Returns(delegate(CallInfo _)
			{
				throw Activator.CreateInstance<TException>();
			}, new Func<CallInfo, object>[0]);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000046C8 File Offset: 0x000028C8
		public static ConfiguredCall Throws(this object value, Func<CallInfo, Exception> createException)
		{
			return value.Returns(delegate(CallInfo ci)
			{
				throw createException(ci);
			}, new Func<CallInfo, object>[0]);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000046FC File Offset: 0x000028FC
		public static ConfiguredCall ThrowsForAnyArgs(this object value, Exception ex)
		{
			return value.ReturnsForAnyArgs(delegate(CallInfo _)
			{
				throw ex;
			}, new Func<CallInfo, object>[0]);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000472E File Offset: 0x0000292E
		public static ConfiguredCall ThrowsForAnyArgs<[Nullable(1)] TException>(this object value) where TException : Exception, new()
		{
			return value.ReturnsForAnyArgs(delegate(CallInfo _)
			{
				throw Activator.CreateInstance<TException>();
			}, new Func<CallInfo, object>[0]);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000475C File Offset: 0x0000295C
		public static ConfiguredCall ThrowsForAnyArgs(this object value, Func<CallInfo, Exception> createException)
		{
			return value.ReturnsForAnyArgs(delegate(CallInfo ci)
			{
				throw createException(ci);
			}, new Func<CallInfo, object>[0]);
		}
	}
}
