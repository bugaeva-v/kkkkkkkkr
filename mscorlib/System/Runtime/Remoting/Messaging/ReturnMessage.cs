using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Содержит сообщение, возвращенное в ответ на вызов метода для удаленного объекта.</summary>
	// Token: 0x02000635 RID: 1589
	[ComVisible(true)]
	public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> со всей информацией, возвращаемой вызывающему оператору после вызова метода.</summary>
		/// <param name="ret">Объект, возвращенный вызванным методом, из которого создан текущий экземпляр <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</param>
		/// <param name="outArgs">Объекты, возвращенные из вызванного метода в качестве параметров <see langword="out" />.</param>
		/// <param name="outArgsCount">Число параметров <see langword="out" />, возвращенных из вызванного метода.</param>
		/// <param name="callCtx">
		///   <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> вызова метода.</param>
		/// <param name="mcm">Исходный вызов метода для вызванного метода.</param>
		// Token: 0x06003BF3 RID: 15347 RVA: 0x000D0A90 File Offset: 0x000CEC90
		public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
		{
			this._returnValue = ret;
			this._args = outArgs;
			this._callCtx = callCtx;
			if (mcm != null)
			{
				this._uri = mcm.Uri;
				this._methodBase = mcm.MethodBase;
			}
			if (this._args == null)
			{
				this._args = new object[outArgsCount];
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</summary>
		/// <param name="e">Исключение, инициированное при выполнении удаленно вызванного метода.</param>
		/// <param name="mcm">
		///   <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" />, с помощью которого создается экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</param>
		// Token: 0x06003BF4 RID: 15348 RVA: 0x000D0AEB File Offset: 0x000CECEB
		public ReturnMessage(Exception e, IMethodCallMessage mcm)
		{
			this._exception = e;
			if (mcm != null)
			{
				this._methodBase = mcm.MethodBase;
				this._callCtx = mcm.LogicalCallContext;
			}
			this._args = new object[0];
		}

		/// <summary>Возвращает число аргументов вызванного метода.</summary>
		/// <returns>Число аргументов вызванного метода.</returns>
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x000D0B21 File Offset: 0x000CED21
		public int ArgCount
		{
			[SecurityCritical]
			get
			{
				return this._args.Length;
			}
		}

		/// <summary>Возвращает указанный аргумент, переданный методу, вызванному для удаленного объекта.</summary>
		/// <returns>Аргумент, переданный методу, вызванному для удаленного объекта.</returns>
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x000D0B2B File Offset: 0x000CED2B
		public object[] Args
		{
			[SecurityCritical]
			get
			{
				return this._args;
			}
		}

		/// <summary>Возвращает значение, указывающее, принимает ли вызванный метод переменное число аргументов.</summary>
		/// <returns>
		///   <see langword="true" />, если вызванный метод принимает переменное число аргументов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x000D0B33 File Offset: 0x000CED33
		public bool HasVarArgs
		{
			[SecurityCritical]
			get
			{
				return !(this._methodBase == null) && (this._methodBase.CallingConvention | CallingConventions.VarArgs) > (CallingConventions)0;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> вызванного метода.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> вызванного метода.</returns>
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x000D0B55 File Offset: 0x000CED55
		public LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				if (this._callCtx == null)
				{
					this._callCtx = new LogicalCallContext();
				}
				return this._callCtx;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</returns>
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x000D0B70 File Offset: 0x000CED70
		public MethodBase MethodBase
		{
			[SecurityCritical]
			get
			{
				return this._methodBase;
			}
		}

		/// <summary>Возвращает имя вызванного метода.</summary>
		/// <returns>Имя метода, из которого возникло текущее <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</returns>
		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x000D0B78 File Offset: 0x000CED78
		public string MethodName
		{
			[SecurityCritical]
			get
			{
				if (this._methodBase != null && this._methodName == null)
				{
					this._methodName = this._methodBase.Name;
				}
				return this._methodName;
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, содержащих подпись метода.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, содержащих подпись метода.</returns>
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x000D0BA8 File Offset: 0x000CEDA8
		public object MethodSignature
		{
			[SecurityCritical]
			get
			{
				if (this._methodBase != null && this._methodSignature == null)
				{
					ParameterInfo[] parameters = this._methodBase.GetParameters();
					this._methodSignature = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						this._methodSignature[i] = parameters[i].ParameterType;
					}
				}
				return this._methodSignature;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Collections.IDictionary" /> свойств, содержащихся в текущем <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IDictionary" /> свойств, содержащихся в текущем <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</returns>
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x000D0C09 File Offset: 0x000CEE09
		public virtual IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				if (this._properties == null)
				{
					this._properties = new MethodReturnDictionary(this);
				}
				return this._properties;
			}
		}

		/// <summary>Возвращает имя типа, для которого был вызван удаленный метод.</summary>
		/// <returns>Имя типа удаленного объекта, для которого был вызван удаленный метод.</returns>
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x000D0C25 File Offset: 0x000CEE25
		public string TypeName
		{
			[SecurityCritical]
			get
			{
				if (this._methodBase != null && this._typeName == null)
				{
					this._typeName = this._methodBase.DeclaringType.AssemblyQualifiedName;
				}
				return this._typeName;
			}
		}

		/// <summary>Получает или задает URI удаленного объекта, для которого был вызван удаленный метод.</summary>
		/// <returns>URI удаленного объекта, для которого был вызван удаленный метод.</returns>
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x000D0C59 File Offset: 0x000CEE59
		// (set) Token: 0x06003BFF RID: 15359 RVA: 0x000D0C61 File Offset: 0x000CEE61
		public string Uri
		{
			[SecurityCritical]
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x000D0C6A File Offset: 0x000CEE6A
		// (set) Token: 0x06003C01 RID: 15361 RVA: 0x000D0C72 File Offset: 0x000CEE72
		string IInternalMessage.Uri
		{
			get
			{
				return this.Uri;
			}
			set
			{
				this.Uri = value;
			}
		}

		/// <summary>Возвращает указанный аргумент, переданный удаленному методу во время вызова метода.</summary>
		/// <param name="argNum">Индекс запрошенного аргумента (индексация ведется от нуля).</param>
		/// <returns>Аргумент, переданный удаленному методу во время вызова метода.</returns>
		// Token: 0x06003C02 RID: 15362 RVA: 0x000D0C7B File Offset: 0x000CEE7B
		[SecurityCritical]
		public object GetArg(int argNum)
		{
			return this._args[argNum];
		}

		/// <summary>Возвращает имя указанного аргумента метода.</summary>
		/// <param name="index">Индекс запрошенного имени аргумента (индексация ведется от нуля).</param>
		/// <returns>Имя указанного аргумента метода.</returns>
		// Token: 0x06003C03 RID: 15363 RVA: 0x000D0C85 File Offset: 0x000CEE85
		[SecurityCritical]
		public string GetArgName(int index)
		{
			return this._methodBase.GetParameters()[index].Name;
		}

		/// <summary>Возвращает исключение, инициированное во время удаленного вызова метода.</summary>
		/// <returns>Исключение, инициированное во время вызова метода, или <see langword="null" />, если исключение не возникло во время вызова.</returns>
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x000D0C99 File Offset: 0x000CEE99
		public Exception Exception
		{
			[SecurityCritical]
			get
			{
				return this._exception;
			}
		}

		/// <summary>Возвращает число аргументов <see langword="out" /> или <see langword="ref" /> вызванного метода.</summary>
		/// <returns>Число аргументов <see langword="out" /> или <see langword="ref" /> вызванного метода.</returns>
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x000D0CA1 File Offset: 0x000CEEA1
		public int OutArgCount
		{
			[SecurityCritical]
			get
			{
				if (this._args == null || this._args.Length == 0)
				{
					return 0;
				}
				if (this._inArgInfo == null)
				{
					this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
				}
				return this._inArgInfo.GetInOutArgCount();
			}
		}

		/// <summary>Возвращает указанный объект, переданный в качестве параметра <see langword="out" /> или <see langword="ref" /> вызванному методу.</summary>
		/// <returns>Объект, переданный в качестве параметра <see langword="out" /> или <see langword="ref" /> вызванному методу.</returns>
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x000D0CDC File Offset: 0x000CEEDC
		public object[] OutArgs
		{
			[SecurityCritical]
			get
			{
				if (this._outArgs == null && this._args != null)
				{
					if (this._inArgInfo == null)
					{
						this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
					}
					this._outArgs = this._inArgInfo.GetInOutArgs(this._args);
				}
				return this._outArgs;
			}
		}

		/// <summary>Возвращает объект, возвращенный вызванным методом.</summary>
		/// <returns>Объект, возвращенный вызванным методом.</returns>
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x000D0D30 File Offset: 0x000CEF30
		public virtual object ReturnValue
		{
			[SecurityCritical]
			get
			{
				return this._returnValue;
			}
		}

		/// <summary>Возвращает объект, переданный в качестве параметра <see langword="out" /> или <see langword="ref" /> при удаленном вызове метода.</summary>
		/// <param name="argNum">Индекс запрошенного параметра <see langword="out" /> или <see langword="ref" /> (индексация ведется от нуля).</param>
		/// <returns>Объект, переданный в качестве параметра <see langword="out" /> или <see langword="ref" /> при удаленном вызове метода.</returns>
		// Token: 0x06003C08 RID: 15368 RVA: 0x000D0D38 File Offset: 0x000CEF38
		[SecurityCritical]
		public object GetOutArg(int argNum)
		{
			if (this._inArgInfo == null)
			{
				this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
			}
			return this._args[this._inArgInfo.GetInOutArgIndex(argNum)];
		}

		/// <summary>Возвращает имя указанного параметра <see langword="out" /> или <see langword="ref" />, переданного удаленному методу.</summary>
		/// <param name="index">Индекс запрошенного аргумента (индексация ведется от нуля).</param>
		/// <returns>Строка, представляющая имя указанного параметра <see langword="out" /> или <see langword="ref" />, или <see langword="null" />, если текущий метод не реализован.</returns>
		// Token: 0x06003C09 RID: 15369 RVA: 0x000D0D67 File Offset: 0x000CEF67
		[SecurityCritical]
		public string GetOutArgName(int index)
		{
			if (this._inArgInfo == null)
			{
				this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
			}
			return this._inArgInfo.GetInOutArgName(index);
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x000D0D8F File Offset: 0x000CEF8F
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x000D0D97 File Offset: 0x000CEF97
		Identity IInternalMessage.TargetIdentity
		{
			get
			{
				return this._targetIdentity;
			}
			set
			{
				this._targetIdentity = value;
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x000D0DA0 File Offset: 0x000CEFA0
		bool IInternalMessage.HasProperties()
		{
			return this._properties != null;
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x000D0DA0 File Offset: 0x000CEFA0
		internal bool HasProperties()
		{
			return this._properties != null;
		}

		// Token: 0x040026DC RID: 9948
		private object[] _outArgs;

		// Token: 0x040026DD RID: 9949
		private object[] _args;

		// Token: 0x040026DE RID: 9950
		private LogicalCallContext _callCtx;

		// Token: 0x040026DF RID: 9951
		private object _returnValue;

		// Token: 0x040026E0 RID: 9952
		private string _uri;

		// Token: 0x040026E1 RID: 9953
		private Exception _exception;

		// Token: 0x040026E2 RID: 9954
		private MethodBase _methodBase;

		// Token: 0x040026E3 RID: 9955
		private string _methodName;

		// Token: 0x040026E4 RID: 9956
		private Type[] _methodSignature;

		// Token: 0x040026E5 RID: 9957
		private string _typeName;

		// Token: 0x040026E6 RID: 9958
		private MethodReturnDictionary _properties;

		// Token: 0x040026E7 RID: 9959
		private Identity _targetIdentity;

		// Token: 0x040026E8 RID: 9960
		private ArgInfo _inArgInfo;
	}
}
