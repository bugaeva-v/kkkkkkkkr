using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D0 RID: 208
	public class ArgumentSpecificationFactory : IArgumentSpecificationFactory
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00008CFA File Offset: 0x00006EFA
		public IArgumentSpecification Create([Nullable(2)] object argument, IParameterInfo parameterInfo, ISuppliedArgumentSpecifications suppliedArgumentSpecifications)
		{
			if (!parameterInfo.IsParams)
			{
				return this.CreateSpecFromNonParamsArg(argument, parameterInfo, suppliedArgumentSpecifications);
			}
			return this.CreateSpecFromParamsArg(argument, parameterInfo, suppliedArgumentSpecifications);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00008D18 File Offset: 0x00006F18
		private IArgumentSpecification CreateSpecFromNonParamsArg([Nullable(2)] object argument, IParameterInfo parameterInfo, ISuppliedArgumentSpecifications suppliedArgumentSpecifications)
		{
			if (suppliedArgumentSpecifications.IsNextFor(argument, parameterInfo.ParameterType))
			{
				return suppliedArgumentSpecifications.Dequeue();
			}
			if (!suppliedArgumentSpecifications.AnyFor(argument, parameterInfo.ParameterType) || parameterInfo.IsOptional || parameterInfo.IsOut)
			{
				return new ArgumentSpecification(parameterInfo.ParameterType, new EqualsArgumentMatcher(argument));
			}
			throw new AmbiguousArgumentsException();
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00008D74 File Offset: 0x00006F74
		private IArgumentSpecification CreateSpecFromParamsArg([Nullable(2)] object argument, IParameterInfo parameterInfo, ISuppliedArgumentSpecifications suppliedArgumentSpecifications)
		{
			if (suppliedArgumentSpecifications.IsNextFor(argument, parameterInfo.ParameterType))
			{
				return suppliedArgumentSpecifications.Dequeue();
			}
			if (suppliedArgumentSpecifications.AnyFor(argument, parameterInfo.ParameterType))
			{
				throw new AmbiguousArgumentsException();
			}
			if (argument == null)
			{
				return new ArgumentSpecification(parameterInfo.ParameterType, new EqualsArgumentMatcher(null));
			}
			Array array = argument as Array;
			if (array == null)
			{
				throw new SubstituteInternalException("Expected to get array argument, but got argument of '" + argument.GetType().FullName + "' type.");
			}
			IEnumerable<IArgumentSpecification> argumentSpecifications = this.UnwrapParamsArguments(array.Cast<object>(), parameterInfo.ParameterType.GetElementType(), suppliedArgumentSpecifications);
			return new ArgumentSpecification(parameterInfo.ParameterType, new ArrayContentsArgumentMatcher(argumentSpecifications));
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00008E18 File Offset: 0x00007018
		private IEnumerable<IArgumentSpecification> UnwrapParamsArguments([Nullable(new byte[]
		{
			0,
			2
		})] IEnumerable<object> args, Type paramsElementType, ISuppliedArgumentSpecifications suppliedArgumentSpecifications)
		{
			ArgumentSpecificationFactory.ParameterInfoFromType parameterInfo = new ArgumentSpecificationFactory.ParameterInfoFromType(paramsElementType);
			List<IArgumentSpecification> list = new List<IArgumentSpecification>();
			foreach (object argument in args)
			{
				try
				{
					list.Add(this.CreateSpecFromNonParamsArg(argument, parameterInfo, suppliedArgumentSpecifications));
				}
				catch (AmbiguousArgumentsException ex)
				{
					ex.Data["NON_REPORTED_RESOLVED_SPECIFICATIONS"] = list;
					throw;
				}
			}
			return list;
		}

		// Token: 0x0200014E RID: 334
		private class ParameterInfoFromType : IParameterInfo
		{
			// Token: 0x06000507 RID: 1287 RVA: 0x0000A9B1 File Offset: 0x00008BB1
			public ParameterInfoFromType(Type parameterType)
			{
				this.ParameterType = parameterType;
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000A9C0 File Offset: 0x00008BC0
			public Type ParameterType { get; }

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000509 RID: 1289 RVA: 0x0000A9C8 File Offset: 0x00008BC8
			public bool IsParams
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000A9CB File Offset: 0x00008BCB
			public bool IsOptional
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600050B RID: 1291 RVA: 0x0000A9CE File Offset: 0x00008BCE
			public bool IsOut
			{
				get
				{
					return false;
				}
			}
		}
	}
}
