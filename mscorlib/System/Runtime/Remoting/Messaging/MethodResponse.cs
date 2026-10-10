using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> для создания сообщения, действующего как ответ метода для удаленного объекта.</summary>
	// Token: 0x0200062B RID: 1579
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage, ISerializationRootObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.MethodResponse" /> из массива заголовков удаленного взаимодействия и сообщения запроса.</summary>
		/// <param name="h1">Массив заголовков удаленного взаимодействия, содержащий пары "ключ-значение". Этот массив используется для инициализации полей <see cref="T:System.Runtime.Remoting.Messaging.MethodResponse" /> для заголовков, принадлежащих пространству имен "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
		/// <param name="mcm">Сообщение запроса, действующее как вызов метода удаленного объекта.</param>
		// Token: 0x06003B7E RID: 15230 RVA: 0x000CF850 File Offset: 0x000CDA50
		public MethodResponse(Header[] h1, IMethodCallMessage mcm)
		{
			if (mcm != null)
			{
				this._methodName = mcm.MethodName;
				this._uri = mcm.Uri;
				this._typeName = mcm.TypeName;
				this._methodBase = mcm.MethodBase;
				this._methodSignature = (Type[])mcm.MethodSignature;
				this._args = mcm.Args;
			}
			if (h1 != null)
			{
				foreach (Header header in h1)
				{
					this.InitMethodProperty(header.Name, header.Value);
				}
			}
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x000CF8DC File Offset: 0x000CDADC
		internal MethodResponse(Exception e, IMethodCallMessage msg)
		{
			this._callMsg = msg;
			if (msg != null)
			{
				this._uri = msg.Uri;
			}
			else
			{
				this._uri = string.Empty;
			}
			this._exception = e;
			this._returnValue = null;
			this._outArgs = new object[0];
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x000CF92C File Offset: 0x000CDB2C
		internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
			this._callMsg = msg;
			this._uri = msg.Uri;
			this._exception = null;
			this._returnValue = returnValue;
			this._args = outArgs;
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x000CF960 File Offset: 0x000CDB60
		internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
		{
			this._callMsg = msg;
			this._methodBase = msg.MethodBase;
			this._uri = msg.Uri;
			this._methodName = msg.MethodName;
			ArrayList arguments = retmsg.GetArguments();
			this._exception = retmsg.GetException(arguments);
			this._returnValue = retmsg.GetReturnValue(arguments);
			this._args = retmsg.GetArgs(arguments);
			this._callContext = retmsg.GetLogicalCallContext(arguments);
			if (this._callContext == null)
			{
				this._callContext = new LogicalCallContext();
			}
			if (retmsg.PropertiesCount > 0)
			{
				CADMessageBase.UnmarshalProperties(this.Properties, retmsg.PropertiesCount, arguments);
			}
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x000CFA08 File Offset: 0x000CDC08
		internal MethodResponse(IMethodCallMessage msg, object handlerObject, BinaryMethodReturnMessage smuggledMrm)
		{
			if (msg != null)
			{
				this._methodBase = msg.MethodBase;
				this._methodName = msg.MethodName;
				this._uri = msg.Uri;
			}
			this._returnValue = smuggledMrm.ReturnValue;
			this._args = smuggledMrm.Args;
			this._exception = smuggledMrm.Exception;
			this._callContext = smuggledMrm.LogicalCallContext;
			if (smuggledMrm.HasProperties)
			{
				smuggledMrm.PopulateMessageProperties(this.Properties);
			}
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x000CFA88 File Offset: 0x000CDC88
		internal MethodResponse(SerializationInfo info, StreamingContext context)
		{
			foreach (SerializationEntry serializationEntry in info)
			{
				this.InitMethodProperty(serializationEntry.Name, serializationEntry.Value);
			}
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
		internal void InitMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 1960967436U)
			{
				if (num <= 1201911322U)
				{
					if (num != 990701179U)
					{
						if (num == 1201911322U)
						{
							if (key == "__CallContext")
							{
								this._callContext = (LogicalCallContext)value;
								return;
							}
						}
					}
					else if (key == "__Uri")
					{
						this._uri = (string)value;
						return;
					}
				}
				else if (num != 1637783905U)
				{
					if (num == 1960967436U)
					{
						if (key == "__OutArgs")
						{
							this._args = (object[])value;
							return;
						}
					}
				}
				else if (key == "__Return")
				{
					this._returnValue = value;
					return;
				}
			}
			else if (num <= 3166241401U)
			{
				if (num != 2010141056U)
				{
					if (num == 3166241401U)
					{
						if (key == "__MethodName")
						{
							this._methodName = (string)value;
							return;
						}
					}
				}
				else if (key == "__TypeName")
				{
					this._typeName = (string)value;
					return;
				}
			}
			else if (num != 3626951189U)
			{
				if (num == 3679129400U)
				{
					if (key == "__MethodSignature")
					{
						this._methodSignature = (Type[])value;
						return;
					}
				}
			}
			else if (key == "__fault")
			{
				this._exception = (Exception)value;
				return;
			}
			this.Properties[key] = value;
		}

		/// <summary>Возвращает число аргументов, переданных методу.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов, переданных методу.</returns>
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x000CFC4E File Offset: 0x000CDE4E
		public int ArgCount
		{
			[SecurityCritical]
			get
			{
				if (this._args == null)
				{
					return 0;
				}
				return this._args.Length;
			}
		}

		/// <summary>Возвращает массив аргументов, переданных методу.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы, переданные методу.</returns>
		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x000CFC62 File Offset: 0x000CDE62
		public object[] Args
		{
			[SecurityCritical]
			get
			{
				return this._args;
			}
		}

		/// <summary>Возвращает исключение, инициированное во время вызова метода, или <see langword="null" />, если метод не выдал исключение.</summary>
		/// <returns>Исключение <see cref="T:System.Exception" />, выданное во время вызова метода, или <see langword="null" />, если метод не выдал исключение.</returns>
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x000CFC6A File Offset: 0x000CDE6A
		public Exception Exception
		{
			[SecurityCritical]
			get
			{
				return this._exception;
			}
		}

		/// <summary>Возвращает значение, указывающее, принимает ли метод переменное число аргументов.</summary>
		/// <returns>
		///   <see langword="true" />, если метод принимает переменное число аргументов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x000CFC72 File Offset: 0x000CDE72
		public bool HasVarArgs
		{
			[SecurityCritical]
			get
			{
				return (this.MethodBase.CallingConvention | CallingConventions.VarArgs) > (CallingConventions)0;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</returns>
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06003B89 RID: 15241 RVA: 0x000CFC84 File Offset: 0x000CDE84
		public LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				if (this._callContext == null)
				{
					this._callContext = new LogicalCallContext();
				}
				return this._callContext;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</returns>
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x000CFCA0 File Offset: 0x000CDEA0
		public MethodBase MethodBase
		{
			[SecurityCritical]
			get
			{
				if (null == this._methodBase)
				{
					if (this._callMsg != null)
					{
						this._methodBase = this._callMsg.MethodBase;
					}
					else if (this.MethodName != null && this.TypeName != null)
					{
						this._methodBase = RemotingServices.GetMethodBaseFromMethodMessage(this);
					}
				}
				return this._methodBase;
			}
		}

		/// <summary>Возвращает имя вызванного метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее имя вызванного метода.</returns>
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x000CFCF8 File Offset: 0x000CDEF8
		public string MethodName
		{
			[SecurityCritical]
			get
			{
				if (this._methodName == null && this._callMsg != null)
				{
					this._methodName = this._callMsg.MethodName;
				}
				return this._methodName;
			}
		}

		/// <summary>Возвращает объект, содержащий подпись метода.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий подпись метода.</returns>
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x000CFD21 File Offset: 0x000CDF21
		public object MethodSignature
		{
			[SecurityCritical]
			get
			{
				if (this._methodSignature == null && this._callMsg != null)
				{
					this._methodSignature = (Type[])this._callMsg.MethodSignature;
				}
				return this._methodSignature;
			}
		}

		/// <summary>Возвращает число аргументов в вызове метода, помеченных как параметры <see langword="ref" /> или <see langword="out" />.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов в вызове метода, не помеченных как параметры <see langword="ref" /> или <see langword="out" />.</returns>
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003B8D RID: 15245 RVA: 0x000CFD4F File Offset: 0x000CDF4F
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

		/// <summary>Возвращает массив аргументов в вызове метода, которые помечены как параметры <see langword="ref" /> или <see langword="out" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы в вызове метода, помеченные как параметры <see langword="ref" /> или <see langword="out" />.</returns>
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x000CFD8C File Offset: 0x000CDF8C
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

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</returns>
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
		public virtual IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				if (this.ExternalProperties == null)
				{
					MethodReturnDictionary methodReturnDictionary = new MethodReturnDictionary(this);
					this.ExternalProperties = methodReturnDictionary;
					this.InternalProperties = methodReturnDictionary.GetInternalProperties();
				}
				return this.ExternalProperties;
			}
		}

		/// <summary>Возвращает возвращаемое значение вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий возвращаемое значение вызова метода.</returns>
		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x000CFE15 File Offset: 0x000CE015
		public object ReturnValue
		{
			[SecurityCritical]
			get
			{
				return this._returnValue;
			}
		}

		/// <summary>Возвращает полное имя типа удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее полное имя типа удаленного объекта, к которому осуществляется вызов метода.</returns>
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06003B91 RID: 15249 RVA: 0x000CFE1D File Offset: 0x000CE01D
		public string TypeName
		{
			[SecurityCritical]
			get
			{
				if (this._typeName == null && this._callMsg != null)
				{
					this._typeName = this._callMsg.TypeName;
				}
				return this._typeName;
			}
		}

		/// <summary>Возвращает универсальный код ресурса (URI) удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>URI удаленного объекта.</returns>
		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x000CFE46 File Offset: 0x000CE046
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x000CFE6F File Offset: 0x000CE06F
		public string Uri
		{
			[SecurityCritical]
			get
			{
				if (this._uri == null && this._callMsg != null)
				{
					this._uri = this._callMsg.Uri;
				}
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x000CFE78 File Offset: 0x000CE078
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x000CFE80 File Offset: 0x000CE080
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

		/// <summary>Возвращает аргумент метода в виде объекта по указанному индексу.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Аргумент метода в виде объекта.</returns>
		// Token: 0x06003B96 RID: 15254 RVA: 0x000CFE89 File Offset: 0x000CE089
		[SecurityCritical]
		public object GetArg(int argNum)
		{
			if (this._args == null)
			{
				return null;
			}
			return this._args[argNum];
		}

		/// <summary>Возвращает имя аргумента метода по указанному индексу.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента метода.</returns>
		// Token: 0x06003B97 RID: 15255 RVA: 0x000CFE9D File Offset: 0x000CE09D
		[SecurityCritical]
		public string GetArgName(int index)
		{
			return this.MethodBase.GetParameters()[index].Name;
		}

		/// <summary>Метод <see cref="M:System.Runtime.Remoting.Messaging.MethodResponse.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> не реализован.</summary>
		/// <param name="info">Данные для сериализации или десериализации удаленного объекта.</param>
		/// <param name="context">Контекст определенного сериализуемого потока.</param>
		// Token: 0x06003B98 RID: 15256 RVA: 0x000CFEB4 File Offset: 0x000CE0B4
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (this._exception == null)
			{
				info.AddValue("__TypeName", this._typeName);
				info.AddValue("__MethodName", this._methodName);
				info.AddValue("__MethodSignature", this._methodSignature);
				info.AddValue("__Uri", this._uri);
				info.AddValue("__Return", this._returnValue);
				info.AddValue("__OutArgs", this._args);
			}
			else
			{
				info.AddValue("__fault", this._exception);
			}
			info.AddValue("__CallContext", this._callContext);
			if (this.InternalProperties != null)
			{
				foreach (object obj in this.InternalProperties)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					info.AddValue((string)dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
		}

		/// <summary>Возвращает указанный аргумент, отмеченный как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Указанный аргумент, помеченный как параметр <see langword="ref" /> или <see langword="out" />.</returns>
		// Token: 0x06003B99 RID: 15257 RVA: 0x000CFFBC File Offset: 0x000CE1BC
		[SecurityCritical]
		public object GetOutArg(int argNum)
		{
			if (this._args == null)
			{
				return null;
			}
			if (this._inArgInfo == null)
			{
				this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
			}
			return this._args[this._inArgInfo.GetInOutArgIndex(argNum)];
		}

		/// <summary>Возвращает имя указанного аргумента, помеченного как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента или <see langword="null" />, если текущий метод не реализован.</returns>
		// Token: 0x06003B9A RID: 15258 RVA: 0x000CFFF8 File Offset: 0x000CE1F8
		[SecurityCritical]
		public string GetOutArgName(int index)
		{
			if (null == this._methodBase)
			{
				return "__method_" + index.ToString();
			}
			if (this._inArgInfo == null)
			{
				this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
			}
			return this._inArgInfo.GetInOutArgName(index);
		}

		/// <summary>Инициализирует внутренний обработчик сериализации из массива заголовков удаленного взаимодействия, применяемых к методу.</summary>
		/// <param name="h">Массив заголовков удаленного взаимодействия, содержащих пары "ключ-значение". Этот массив используется для инициализации полей <see cref="T:System.Runtime.Remoting.Messaging.MethodResponse" /> для заголовков, принадлежащих пространству имен "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
		/// <returns>Внутренний обработчик сериализации.</returns>
		// Token: 0x06003B9B RID: 15259 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual object HeaderHandler(Header[] h)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает информацию для метода из настроек сериализации.</summary>
		/// <param name="info">Данные для сериализации или десериализации удаленного объекта.</param>
		/// <param name="ctx">Контекст определенного сериализуемого потока.</param>
		// Token: 0x06003B9C RID: 15260 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public void RootSetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x000D004B File Offset: 0x000CE24B
		// (set) Token: 0x06003B9E RID: 15262 RVA: 0x000D0053 File Offset: 0x000CE253
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

		// Token: 0x06003B9F RID: 15263 RVA: 0x000D005C File Offset: 0x000CE25C
		bool IInternalMessage.HasProperties()
		{
			return this.ExternalProperties != null || this.InternalProperties != null;
		}

		// Token: 0x040026AC RID: 9900
		private string _methodName;

		// Token: 0x040026AD RID: 9901
		private string _uri;

		// Token: 0x040026AE RID: 9902
		private string _typeName;

		// Token: 0x040026AF RID: 9903
		private MethodBase _methodBase;

		// Token: 0x040026B0 RID: 9904
		private object _returnValue;

		// Token: 0x040026B1 RID: 9905
		private Exception _exception;

		// Token: 0x040026B2 RID: 9906
		private Type[] _methodSignature;

		// Token: 0x040026B3 RID: 9907
		private ArgInfo _inArgInfo;

		// Token: 0x040026B4 RID: 9908
		private object[] _args;

		// Token: 0x040026B5 RID: 9909
		private object[] _outArgs;

		// Token: 0x040026B6 RID: 9910
		private IMethodCallMessage _callMsg;

		// Token: 0x040026B7 RID: 9911
		private LogicalCallContext _callContext;

		// Token: 0x040026B8 RID: 9912
		private Identity _targetIdentity;

		/// <summary>Задает интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		// Token: 0x040026B9 RID: 9913
		protected IDictionary ExternalProperties;

		/// <summary>Задает интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		// Token: 0x040026BA RID: 9914
		protected IDictionary InternalProperties;
	}
}
