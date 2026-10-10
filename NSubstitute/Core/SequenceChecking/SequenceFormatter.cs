using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core.SequenceChecking
{
	// Token: 0x020000BE RID: 190
	public class SequenceFormatter
	{
		// Token: 0x06000318 RID: 792 RVA: 0x00007EE8 File Offset: 0x000060E8
		public SequenceFormatter(string delimiter, CallSpecAndTarget[] querySpec, ICall[] matchingCallsInOrder)
		{
			this._delimiter = delimiter;
			InstanceTracker instances = new InstanceTracker();
			this._query = (from x in querySpec
			select new SequenceFormatter.CallData(instances.InstanceNumber(x.Target), x)).ToArray<SequenceFormatter.CallData>();
			this._actualCalls = (from x in matchingCallsInOrder
			select new SequenceFormatter.CallData(instances.InstanceNumber(x.Target()), x)).ToArray<SequenceFormatter.CallData>();
			this._hasMultipleInstances = (instances.NumberOfInstances() > 1);
			this._requiresInstanceNumbers = this.HasMultipleCallsOnSameType();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00007F6D File Offset: 0x0000616D
		public string FormatQuery()
		{
			return this.Format(this._query);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00007F7B File Offset: 0x0000617B
		public string FormatActualCalls()
		{
			return this.Format(this._actualCalls);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00007F89 File Offset: 0x00006189
		private string Format(SequenceFormatter.CallData[] calls)
		{
			return (from x in calls
			select x.Format(this._hasMultipleInstances, this._requiresInstanceNumbers)).Join(this._delimiter);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00007FA8 File Offset: 0x000061A8
		private bool HasMultipleCallsOnSameType()
		{
			Dictionary<Type, object> dictionary = new Dictionary<Type, object>();
			foreach (SequenceFormatter.CallData callData in this._query)
			{
				object obj;
				if (dictionary.TryGetValue(callData.DeclaringType, out obj))
				{
					if (callData.Target != obj)
					{
						return true;
					}
				}
				else
				{
					dictionary.Add(callData.DeclaringType, callData.Target);
				}
			}
			return false;
		}

		// Token: 0x040000E6 RID: 230
		private readonly string _delimiter;

		// Token: 0x040000E7 RID: 231
		private readonly SequenceFormatter.CallData[] _query;

		// Token: 0x040000E8 RID: 232
		private readonly SequenceFormatter.CallData[] _actualCalls;

		// Token: 0x040000E9 RID: 233
		private readonly bool _requiresInstanceNumbers;

		// Token: 0x040000EA RID: 234
		private readonly bool _hasMultipleInstances;

		// Token: 0x0200013D RID: 317
		private class CallData
		{
			// Token: 0x060004D2 RID: 1234 RVA: 0x0000A412 File Offset: 0x00008612
			public CallData(int instanceNumber, CallSpecAndTarget specAndTarget)
			{
				this._instanceNumber = instanceNumber;
				this._specAndTarget = specAndTarget;
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x0000A428 File Offset: 0x00008628
			public CallData(int instanceNumber, ICall call)
			{
				this._instanceNumber = instanceNumber;
				this._call = call;
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000A43E File Offset: 0x0000863E
			private MethodInfo MethodInfo
			{
				get
				{
					if (this._call == null)
					{
						return this._specAndTarget.CallSpecification.GetMethodInfo();
					}
					return this._call.GetMethodInfo();
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000A464 File Offset: 0x00008664
			public object Target
			{
				get
				{
					if (this._call == null)
					{
						return this._specAndTarget.Target;
					}
					return this._call.Target();
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000A485 File Offset: 0x00008685
			public Type DeclaringType
			{
				get
				{
					return this.MethodInfo.DeclaringType;
				}
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x0000A494 File Offset: 0x00008694
			public string Format(bool multipleInstances, bool includeInstanceNumber)
			{
				string text = (this._call != null) ? this.Format(this._call) : this.Format(this._specAndTarget);
				if (!multipleInstances)
				{
					return text;
				}
				string arg = includeInstanceNumber ? (this._instanceNumber.ToString() + "@") : "";
				string nonMangledTypeName = this.MethodInfo.DeclaringType.GetNonMangledTypeName();
				return string.Format("{1}{0}.{2}", nonMangledTypeName, arg, text);
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x0000A50A File Offset: 0x0000870A
			private string Format(CallSpecAndTarget x)
			{
				return x.CallSpecification.ToString() ?? string.Empty;
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x0000A520 File Offset: 0x00008720
			private string Format(ICall call)
			{
				MethodInfo methodInfo = call.GetMethodInfo();
				SequenceFormatter.ArgAndParamInfo[] arguments = methodInfo.GetParameters().Zip(call.GetOriginalArguments(), (ParameterInfo p, object a) => new SequenceFormatter.ArgAndParamInfo(p, a)).ToArray<SequenceFormatter.ArgAndParamInfo>();
				return CallFormatter.Default.Format(methodInfo, this.FormatArgs(arguments));
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x0000A57C File Offset: 0x0000877C
			private IEnumerable<string> FormatArgs(SequenceFormatter.ArgAndParamInfo[] arguments)
			{
				return (from x in arguments.SelectMany(delegate(SequenceFormatter.ArgAndParamInfo a)
				{
					if (!a.ParamInfo.IsParams())
					{
						return this.ToEnumerable<object>(a.Argument);
					}
					return ((IEnumerable)a.Argument).Cast<object>();
				})
				select ArgumentFormatter.Default.Format(x, false)).ToArray<string>();
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x0000A5B9 File Offset: 0x000087B9
			private IEnumerable<T> ToEnumerable<T>(T value)
			{
				yield return value;
				yield break;
			}

			// Token: 0x04000195 RID: 405
			private readonly int _instanceNumber;

			// Token: 0x04000196 RID: 406
			[Nullable(2)]
			private readonly ICall _call;

			// Token: 0x04000197 RID: 407
			[Nullable(2)]
			private readonly CallSpecAndTarget _specAndTarget;
		}

		// Token: 0x0200013E RID: 318
		private class ArgAndParamInfo
		{
			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000A5F5 File Offset: 0x000087F5
			public ParameterInfo ParamInfo { get; }

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000A5FD File Offset: 0x000087FD
			[Nullable(2)]
			public object Argument { [NullableContext(2)] get; }

			// Token: 0x060004DF RID: 1247 RVA: 0x0000A605 File Offset: 0x00008805
			public ArgAndParamInfo(ParameterInfo paramInfo, [Nullable(2)] object argument)
			{
				this.ParamInfo = paramInfo;
				this.Argument = argument;
			}
		}
	}
}
