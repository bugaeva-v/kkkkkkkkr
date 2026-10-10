using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D1 RID: 209
	public class ArgumentSpecificationsFactory : IArgumentSpecificationsFactory
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00008EA0 File Offset: 0x000070A0
		public ArgumentSpecificationsFactory(IArgumentSpecificationFactory argumentSpecificationFactory, ISuppliedArgumentSpecificationsFactory suppliedArgumentSpecificationsFactory)
		{
			this._argumentSpecificationFactory = argumentSpecificationFactory;
			this._suppliedArgumentSpecificationsFactory = suppliedArgumentSpecificationsFactory;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00008EB8 File Offset: 0x000070B8
		public IEnumerable<IArgumentSpecification> Create(IList<IArgumentSpecification> argumentSpecs, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, IParameterInfo[] parameterInfos, MethodInfo methodInfo, MatchArgs matchArgs)
		{
			ISuppliedArgumentSpecifications suppliedArgumentSpecifications = this._suppliedArgumentSpecificationsFactory.Create(argumentSpecs);
			List<IArgumentSpecification> list = new List<IArgumentSpecification>();
			for (int i = 0; i < arguments.Length; i++)
			{
				object argument = arguments[i];
				IParameterInfo parameterInfo = parameterInfos[i];
				try
				{
					list.Add(this._argumentSpecificationFactory.Create(argument, parameterInfo, suppliedArgumentSpecifications));
				}
				catch (AmbiguousArgumentsException ex) when (ex.ContainsDefaultMessage)
				{
					IEnumerable<IArgumentSpecification> enumerable = list;
					IEnumerable<IArgumentSpecification> enumerable2 = ex.Data["NON_REPORTED_RESOLVED_SPECIFICATIONS"] as IEnumerable<IArgumentSpecification>;
					if (enumerable2 != null)
					{
						enumerable = enumerable.Concat(enumerable2);
					}
					throw new AmbiguousArgumentsException(methodInfo, arguments, enumerable, argumentSpecs);
				}
			}
			IEnumerable<IArgumentSpecification> enumerable3 = suppliedArgumentSpecifications.DequeueRemaining();
			if (enumerable3.Any<IArgumentSpecification>())
			{
				throw new RedundantArgumentMatcherException(enumerable3, argumentSpecs);
			}
			if (matchArgs != MatchArgs.Any)
			{
				return list;
			}
			return ArgumentSpecificationsFactory.ConvertToMatchAnyValue(list);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00008F98 File Offset: 0x00007198
		private static IEnumerable<IArgumentSpecification> ConvertToMatchAnyValue(IEnumerable<IArgumentSpecification> specs)
		{
			return (from x in specs
			select x.CreateCopyMatchingAnyArgOfType(x.ForType)).ToArray<IArgumentSpecification>();
		}

		// Token: 0x04000100 RID: 256
		private readonly IArgumentSpecificationFactory _argumentSpecificationFactory;

		// Token: 0x04000101 RID: 257
		private readonly ISuppliedArgumentSpecificationsFactory _suppliedArgumentSpecificationsFactory;
	}
}
