using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x02000070 RID: 112
	public class CallSpecification : ICallSpecification
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00005D7A File Offset: 0x00003F7A
		public CallSpecification(MethodInfo methodInfo, IEnumerable<IArgumentSpecification> argumentSpecifications)
		{
			this._methodInfo = methodInfo;
			this._argumentSpecifications = argumentSpecifications.ToArray<IArgumentSpecification>();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005D95 File Offset: 0x00003F95
		public MethodInfo GetMethodInfo()
		{
			return this._methodInfo;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005D9D File Offset: 0x00003F9D
		public Type ReturnType()
		{
			return this._methodInfo.ReturnType;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005DAA File Offset: 0x00003FAA
		public bool IsSatisfiedBy(ICall call)
		{
			return CallSpecification.AreComparable(this.GetMethodInfo(), call.GetMethodInfo()) && !this.HasDifferentNumberOfArguments(call) && this.IsMatchingArgumentSpecifications(call);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005DD8 File Offset: 0x00003FD8
		private static bool AreComparable(MethodInfo a, MethodInfo b)
		{
			return a == b || (a.IsGenericMethod && b.IsGenericMethod && CallSpecification.CanCompareGenericMethods(a, b));
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005DFE File Offset: 0x00003FFE
		private static bool CanCompareGenericMethods(MethodInfo a, MethodInfo b)
		{
			return CallSpecification.AreEquivalentDefinitions(a, b) && CallSpecification.TypesAreAllEquivalent(CallSpecification.ParameterTypes(a), CallSpecification.ParameterTypes(b)) && CallSpecification.TypesAreAllEquivalent(a.GetGenericArguments(), b.GetGenericArguments());
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005E2F File Offset: 0x0000402F
		private static Type[] ParameterTypes(MethodInfo info)
		{
			return (from p in info.GetParameters()
			select p.ParameterType).ToArray<Type>();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005E60 File Offset: 0x00004060
		private static bool TypesAreAllEquivalent(Type[] aArgs, Type[] bArgs)
		{
			if (aArgs.Length != bArgs.Length)
			{
				return false;
			}
			for (int i = 0; i < aArgs.Length; i++)
			{
				Type type = aArgs[i];
				Type type2 = bArgs[i];
				if (!type.IsAssignableFrom(type2) && !type2.IsAssignableFrom(type))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005EA5 File Offset: 0x000040A5
		private static bool AreEquivalentDefinitions(MethodInfo a, MethodInfo b)
		{
			return a.IsGenericMethod == b.IsGenericMethod && a.ReturnType == b.ReturnType && a.Name.Equals(b.Name, StringComparison.Ordinal);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00005EDC File Offset: 0x000040DC
		private bool IsMatchingArgumentSpecifications(ICall call)
		{
			object[] originalArguments = call.GetOriginalArguments();
			for (int i = 0; i < originalArguments.Length; i++)
			{
				if (!this._argumentSpecifications[i].IsSatisfiedBy(originalArguments[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005F13 File Offset: 0x00004113
		public IEnumerable<ArgumentMatchInfo> NonMatchingArguments(ICall call)
		{
			return from x in call.GetOriginalArguments().Select((object arg, int index) => new ArgumentMatchInfo(index, arg, this._argumentSpecifications[index]))
			where !x.IsMatch
			select x;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005F50 File Offset: 0x00004150
		public override string ToString()
		{
			string[] formattedArguments = (from x in this._argumentSpecifications
			select x.ToString() ?? string.Empty).ToArray<string>();
			return CallFormatter.Default.Format(this.GetMethodInfo(), formattedArguments);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005F9E File Offset: 0x0000419E
		public string Format(ICall call)
		{
			return CallFormatter.Default.Format(call.GetMethodInfo(), this.FormatArguments(call.GetOriginalArguments()));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005FBC File Offset: 0x000041BC
		private IEnumerable<string> FormatArguments([Nullable(new byte[]
		{
			0,
			2
		})] IEnumerable<object> arguments)
		{
			return arguments.Zip(this._argumentSpecifications, (object arg, IArgumentSpecification spec) => spec.FormatArgument(arg)).ToArray<string>();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005FF0 File Offset: 0x000041F0
		public ICallSpecification CreateCopyThatMatchesAnyArguments()
		{
			IArgumentSpecification[] argumentSpecifications = this.GetMethodInfo().GetParameters().Zip(this._argumentSpecifications, (ParameterInfo p, IArgumentSpecification spec) => spec.CreateCopyMatchingAnyArgOfType(p.ParameterType)).ToArray<IArgumentSpecification>();
			return new CallSpecification(this.GetMethodInfo(), argumentSpecifications);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006044 File Offset: 0x00004244
		public void InvokePerArgumentActions(CallInfo callInfo)
		{
			object[] array = callInfo.Args();
			IArgumentSpecification[] argumentSpecifications = this._argumentSpecifications;
			for (int i = 0; i < array.Length; i++)
			{
				argumentSpecifications[i].RunAction(array[i]);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006078 File Offset: 0x00004278
		private bool HasDifferentNumberOfArguments(ICall call)
		{
			return this._argumentSpecifications.Length != call.GetOriginalArguments().Length;
		}

		// Token: 0x0400008B RID: 139
		private readonly MethodInfo _methodInfo;

		// Token: 0x0400008C RID: 140
		private readonly IArgumentSpecification[] _argumentSpecifications;
	}
}
