using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using NSubstitute.Core.Arguments;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x02000063 RID: 99
	public class Call : ICall, CallCollection.IReceivedCallEntry
	{
		// Token: 0x06000148 RID: 328 RVA: 0x000050CC File Offset: 0x000032CC
		[Obsolete("This constructor is deprecated and will be removed in future version of product.")]
		public Call(MethodInfo methodInfo, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, object target, IList<IArgumentSpecification> argumentSpecifications, IParameterInfo[] parameterInfos, Func<object> baseMethod) : this(methodInfo, arguments, target, argumentSpecifications, baseMethod)
		{
			if (parameterInfos == null)
			{
				throw new ArgumentNullException("parameterInfos");
			}
			this._parameterInfosCached = parameterInfos;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000050F2 File Offset: 0x000032F2
		public Call(MethodInfo methodInfo, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, object target, IList<IArgumentSpecification> argumentSpecifications, [Nullable(new byte[]
		{
			2,
			0
		})] Func<object> baseMethod)
		{
			this._methodInfo = methodInfo;
			this._arguments = arguments;
			this._target = target;
			this._argumentSpecifications = argumentSpecifications;
			this._baseMethod = baseMethod;
			this._originalArguments = this._arguments;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000512C File Offset: 0x0000332C
		public IParameterInfo[] GetParameterInfos()
		{
			IParameterInfo[] result;
			if ((result = this._parameterInfosCached) == null)
			{
				result = (this._parameterInfosCached = Call.GetParameterInfoFromMethod(this._methodInfo));
			}
			return result;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005157 File Offset: 0x00003357
		public IList<IArgumentSpecification> GetArgumentSpecifications()
		{
			return this._argumentSpecifications;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000515F File Offset: 0x0000335F
		public void AssignSequenceNumber(long number)
		{
			this._sequenceNumber = new long?(number);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005170 File Offset: 0x00003370
		public long GetSequenceNumber()
		{
			long? sequenceNumber = this._sequenceNumber;
			if (sequenceNumber == null)
			{
				throw new MissingSequenceNumberException();
			}
			return sequenceNumber.GetValueOrDefault();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000519A File Offset: 0x0000339A
		public bool CanCallBase
		{
			get
			{
				return this._baseMethod != null;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000051A5 File Offset: 0x000033A5
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public Maybe<object> TryCallBase()
		{
			if (this._baseMethod != null)
			{
				return Maybe.Just<object>(this._baseMethod());
			}
			return Maybe.Nothing<object>();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000051C5 File Offset: 0x000033C5
		public Type GetReturnType()
		{
			return this._methodInfo.ReturnType;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000051D2 File Offset: 0x000033D2
		public MethodInfo GetMethodInfo()
		{
			return this._methodInfo;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000051DC File Offset: 0x000033DC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public object[] GetArguments()
		{
			object[] originalArguments = this._originalArguments;
			if (originalArguments == this._arguments && originalArguments.Length != 0)
			{
				object[] value = originalArguments.ToArray<object>();
				Interlocked.CompareExchange<object[]>(ref this._originalArguments, value, originalArguments);
			}
			return this._arguments;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005218 File Offset: 0x00003418
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public object[] GetOriginalArguments()
		{
			return this._originalArguments;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005220 File Offset: 0x00003420
		public object Target()
		{
			return this._target;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005228 File Offset: 0x00003428
		private static IParameterInfo[] GetParameterInfoFromMethod(MethodInfo methodInfo)
		{
			ParameterInfo[] parameters = methodInfo.GetParameters();
			IParameterInfo[] array = new IParameterInfo[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = new ParameterInfoWrapper(parameters[i]);
			}
			return array;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000525F File Offset: 0x0000345F
		ICall CallCollection.IReceivedCallEntry.Call
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00005262 File Offset: 0x00003462
		bool CallCollection.IReceivedCallEntry.IsSkipped
		{
			get
			{
				return this._callEntryState == -1;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000526D File Offset: 0x0000346D
		void CallCollection.IReceivedCallEntry.Skip()
		{
			this._callEntryState = -1;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005276 File Offset: 0x00003476
		bool CallCollection.IReceivedCallEntry.TryTakeEntryOwnership()
		{
			return Interlocked.CompareExchange(ref this._callEntryState, 1, 0) == 0;
		}

		// Token: 0x0400006F RID: 111
		private readonly MethodInfo _methodInfo;

		// Token: 0x04000070 RID: 112
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly object[] _arguments;

		// Token: 0x04000071 RID: 113
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private object[] _originalArguments;

		// Token: 0x04000072 RID: 114
		private readonly object _target;

		// Token: 0x04000073 RID: 115
		private readonly IList<IArgumentSpecification> _argumentSpecifications;

		// Token: 0x04000074 RID: 116
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private IParameterInfo[] _parameterInfosCached;

		// Token: 0x04000075 RID: 117
		private long? _sequenceNumber;

		// Token: 0x04000076 RID: 118
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private readonly Func<object> _baseMethod;

		// Token: 0x04000077 RID: 119
		private int _callEntryState;
	}
}
