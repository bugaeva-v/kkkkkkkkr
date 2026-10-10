using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000CE RID: 206
	public class ArgumentSpecification : IArgumentSpecification
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00008AB9 File Offset: 0x00006CB9
		public Type ForType { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00008AC1 File Offset: 0x00006CC1
		public bool HasAction
		{
			get
			{
				return this._action != ArgumentSpecification.NoOpAction;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00008AD3 File Offset: 0x00006CD3
		public ArgumentSpecification(Type forType, IArgumentMatcher matcher) : this(forType, matcher, ArgumentSpecification.NoOpAction)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00008AE2 File Offset: 0x00006CE2
		public ArgumentSpecification(Type forType, IArgumentMatcher matcher, [Nullable(new byte[]
		{
			0,
			2
		})] Action<object> action)
		{
			this.ForType = forType;
			this._matcher = matcher;
			this._action = action;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00008B00 File Offset: 0x00006D00
		[NullableContext(2)]
		public bool IsSatisfiedBy(object argument)
		{
			if (!this.IsCompatibleWith(argument))
			{
				return false;
			}
			bool result;
			try
			{
				result = this._matcher.IsSatisfiedBy(argument);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00008B40 File Offset: 0x00006D40
		public string DescribeNonMatch([Nullable(2)] object argument)
		{
			if (!this.IsCompatibleWith(argument))
			{
				return this.GetIncompatibleTypeMessage(argument);
			}
			IDescribeNonMatches describeNonMatches = this._matcher as IDescribeNonMatches;
			if (describeNonMatches == null)
			{
				return string.Empty;
			}
			return describeNonMatches.DescribeFor(argument);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00008B7C File Offset: 0x00006D7C
		public string FormatArgument([Nullable(2)] object argument)
		{
			bool flag = this.IsSatisfiedBy(argument);
			IArgumentFormatter argumentFormatter = this._matcher as IArgumentFormatter;
			if (argumentFormatter == null)
			{
				return ArgumentFormatter.Default.Format(argument, !flag);
			}
			return argumentFormatter.Format(argument, !flag);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00008BBB File Offset: 0x00006DBB
		public override string ToString()
		{
			return this._matcher.ToString() ?? string.Empty;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00008BD1 File Offset: 0x00006DD1
		public IArgumentSpecification CreateCopyMatchingAnyArgOfType(Type requiredType)
		{
			return new ArgumentSpecification(requiredType, new AnyArgumentMatcher(requiredType), (this._action == ArgumentSpecification.NoOpAction) ? ArgumentSpecification.NoOpAction : new Action<object>(this.RunActionIfTypeIsCompatible));
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00008C04 File Offset: 0x00006E04
		[NullableContext(2)]
		public void RunAction(object argument)
		{
			this._action(argument);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00008C12 File Offset: 0x00006E12
		[NullableContext(2)]
		private void RunActionIfTypeIsCompatible(object argument)
		{
			if (argument.IsCompatibleWith(this.ForType))
			{
				this._action(argument);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00008C2E File Offset: 0x00006E2E
		[NullableContext(2)]
		private bool IsCompatibleWith(object argument)
		{
			return argument.IsCompatibleWith(this.ForType);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00008C3C File Offset: 0x00006E3C
		private string GetIncompatibleTypeMessage([Nullable(2)] object argument)
		{
			Type arg = (argument == null) ? typeof(object) : argument.GetType();
			return string.Format("Expected an argument compatible with type '{0}'. Actual type was '{1}'.", this.ForType, arg);
		}

		// Token: 0x040000FB RID: 251
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private static readonly Action<object> NoOpAction = delegate(object _)
		{
		};

		// Token: 0x040000FC RID: 252
		private readonly IArgumentMatcher _matcher;

		// Token: 0x040000FD RID: 253
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly Action<object> _action;
	}
}
