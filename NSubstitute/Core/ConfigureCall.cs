using System;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x02000073 RID: 115
	public class ConfigureCall : IConfigureCall
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x000060FF File Offset: 0x000042FF
		public ConfigureCall(ICallResults configuredResults, ICallActions callActions, IGetCallSpec getCallSpec)
		{
			this._configuredResults = configuredResults;
			this._callActions = callActions;
			this._getCallSpec = getCallSpec;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000611C File Offset: 0x0000431C
		public ConfiguredCall SetResultForLastCall(IReturn valueToReturn, MatchArgs matchArgs, PendingSpecificationInfo pendingSpecInfo)
		{
			ICallSpecification spec = this._getCallSpec.FromPendingSpecification(matchArgs, pendingSpecInfo);
			ConfigureCall.CheckResultIsCompatibleWithCall(valueToReturn, spec);
			this._configuredResults.SetResult(spec, valueToReturn);
			return new ConfiguredCall(delegate(Action<CallInfo> action)
			{
				this._callActions.Add(spec, action);
			});
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006178 File Offset: 0x00004378
		public void SetResultForCall(ICall call, IReturn valueToReturn, MatchArgs matchArgs)
		{
			ICallSpecification callSpecification = this._getCallSpec.FromCall(call, matchArgs);
			ConfigureCall.CheckResultIsCompatibleWithCall(valueToReturn, callSpecification);
			this._configuredResults.SetResult(callSpecification, valueToReturn);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000061A8 File Offset: 0x000043A8
		private static void CheckResultIsCompatibleWithCall(IReturn valueToReturn, ICallSpecification spec)
		{
			Type t = spec.ReturnType();
			if (!valueToReturn.CanBeAssignedTo(t))
			{
				throw new CouldNotSetReturnDueToTypeMismatchException(valueToReturn.TypeOrNull(), spec.GetMethodInfo());
			}
		}

		// Token: 0x0400008E RID: 142
		private readonly ICallResults _configuredResults;

		// Token: 0x0400008F RID: 143
		private readonly ICallActions _callActions;

		// Token: 0x04000090 RID: 144
		private readonly IGetCallSpec _getCallSpec;
	}
}
