using System;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000CC RID: 204
	public static class ArgumentMatcher
	{
		// Token: 0x0600035B RID: 859 RVA: 0x000088C0 File Offset: 0x00006AC0
		[return: Nullable(2)]
		public static ref T Enqueue<T>(IArgumentMatcher<T> argumentMatcher)
		{
			if (argumentMatcher == null)
			{
				throw new ArgumentNullException("argumentMatcher");
			}
			ArgumentMatcher.GenericToNonGenericMatcherProxy<T> genericToNonGenericMatcherProxy;
			if (argumentMatcher is IDescribeNonMatches)
			{
				genericToNonGenericMatcherProxy = new ArgumentMatcher.GenericToNonGenericMatcherProxyWithDescribe<T>(argumentMatcher);
			}
			else
			{
				genericToNonGenericMatcherProxy = new ArgumentMatcher.GenericToNonGenericMatcherProxy<T>(argumentMatcher);
			}
			IArgumentMatcher matcher = genericToNonGenericMatcherProxy;
			return ArgumentMatcher.EnqueueArgSpecification<T>(new ArgumentSpecification(typeof(T), matcher));
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000890A File Offset: 0x00006B0A
		[return: Nullable(2)]
		internal static ref T Enqueue<T>(IArgumentMatcher argumentMatcher)
		{
			return ArgumentMatcher.EnqueueArgSpecification<T>(new ArgumentSpecification(typeof(T), argumentMatcher));
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00008921 File Offset: 0x00006B21
		[return: Nullable(2)]
		internal static ref T Enqueue<T>(IArgumentMatcher argumentMatcher, [Nullable(new byte[]
		{
			0,
			2
		})] Action<object> action)
		{
			return ArgumentMatcher.EnqueueArgSpecification<T>(new ArgumentSpecification(typeof(T), argumentMatcher, action));
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00008939 File Offset: 0x00006B39
		[return: Nullable(2)]
		private static ref T EnqueueArgSpecification<T>(IArgumentSpecification specification)
		{
			SubstitutionContext.Current.ThreadContext.EnqueueArgumentSpecification(specification);
			return ref new ArgumentMatcher.DefaultValueContainer<T>().Value;
		}

		// Token: 0x0200014A RID: 330
		private class GenericToNonGenericMatcherProxy<T> : IArgumentMatcher
		{
			// Token: 0x060004FF RID: 1279 RVA: 0x0000A942 File Offset: 0x00008B42
			public GenericToNonGenericMatcherProxy(IArgumentMatcher<T> matcher)
			{
				this._matcher = matcher;
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x0000A951 File Offset: 0x00008B51
			[NullableContext(2)]
			public bool IsSatisfiedBy(object argument)
			{
				return this._matcher.IsSatisfiedBy((T)((object)argument));
			}

			// Token: 0x040001AC RID: 428
			protected readonly IArgumentMatcher<T> _matcher;
		}

		// Token: 0x0200014B RID: 331
		private class GenericToNonGenericMatcherProxyWithDescribe<T> : ArgumentMatcher.GenericToNonGenericMatcherProxy<T>, IDescribeNonMatches
		{
			// Token: 0x06000501 RID: 1281 RVA: 0x0000A964 File Offset: 0x00008B64
			public GenericToNonGenericMatcherProxyWithDescribe(IArgumentMatcher<T> matcher) : base(matcher)
			{
				if (!(matcher is IDescribeNonMatches))
				{
					throw new SubstituteInternalException("Should implement IDescribeNonMatches type.");
				}
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x0000A980 File Offset: 0x00008B80
			public string DescribeFor([Nullable(2)] object argument)
			{
				return ((IDescribeNonMatches)this._matcher).DescribeFor(argument);
			}
		}

		// Token: 0x0200014C RID: 332
		private class DefaultValueContainer<T>
		{
			// Token: 0x040001AD RID: 429
			[Nullable(2)]
			public T Value;
		}
	}
}
