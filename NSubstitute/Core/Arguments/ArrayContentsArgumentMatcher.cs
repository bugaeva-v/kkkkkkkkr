using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D2 RID: 210
	public class ArrayContentsArgumentMatcher : IArgumentMatcher, IArgumentFormatter
	{
		// Token: 0x06000380 RID: 896 RVA: 0x00008FC4 File Offset: 0x000071C4
		public ArrayContentsArgumentMatcher(IEnumerable<IArgumentSpecification> argumentSpecifications)
		{
			this._argumentSpecifications = argumentSpecifications.ToArray<IArgumentSpecification>();
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00008FD8 File Offset: 0x000071D8
		[NullableContext(2)]
		public bool IsSatisfiedBy(object argument)
		{
			if (argument != null)
			{
				object[] argumentArray = ((IEnumerable)argument).Cast<object>().ToArray<object>();
				if (argumentArray.Length == this._argumentSpecifications.Length)
				{
					return this._argumentSpecifications.Select((IArgumentSpecification spec, int index) => spec.IsSatisfiedBy(argumentArray[index])).All((bool x) => x);
				}
			}
			return false;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00009053 File Offset: 0x00007253
		public override string ToString()
		{
			return string.Join(", ", from x in this._argumentSpecifications
			select x.ToString());
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000908C File Offset: 0x0000728C
		public string Format([Nullable(2)] object argument, bool highlight)
		{
			IEnumerable enumerable = argument as IEnumerable;
			object[] args = (enumerable != null) ? enumerable.Cast<object>().ToArray<object>() : new object[0];
			return this.Format(args, this._argumentSpecifications).Join(", ");
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000090D0 File Offset: 0x000072D0
		private IEnumerable<string> Format(object[] args, IArgumentSpecification[] specs)
		{
			if (specs.Any<IArgumentSpecification>() && !args.Any<object>())
			{
				return new string[]
				{
					"**"
				};
			}
			return args.Select(delegate(object arg, int index)
			{
				if (index >= specs.Length)
				{
					return ArgumentFormatter.Default.Format(arg, true);
				}
				return specs[index].FormatArgument(arg);
			});
		}

		// Token: 0x04000102 RID: 258
		private readonly IArgumentSpecification[] _argumentSpecifications;
	}
}
