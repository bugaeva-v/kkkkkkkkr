using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> для создания сообщения запроса, действующего как вызов метода для удаленного объекта.</summary>
	// Token: 0x02000625 RID: 1573
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage, ISerializationRootObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" /> из массива заголовков удаленного взаимодействия.</summary>
		/// <param name="h1">Массив заголовков удаленного взаимодействия, содержащий пары "ключ-значение". Этот массив используется для инициализации полей <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" /> для заголовков, принадлежащих пространству имен "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
		// Token: 0x06003B1A RID: 15130 RVA: 0x000CE370 File Offset: 0x000CC570
		public MethodCall(Header[] h1)
		{
			this.Init();
			if (h1 == null || h1.Length == 0)
			{
				return;
			}
			foreach (Header header in h1)
			{
				this.InitMethodProperty(header.Name, header.Value);
			}
			this.ResolveMethod();
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x000CE3C0 File Offset: 0x000CC5C0
		internal MethodCall(SerializationInfo info, StreamingContext context)
		{
			this.Init();
			foreach (SerializationEntry serializationEntry in info)
			{
				this.InitMethodProperty(serializationEntry.Name, serializationEntry.Value);
			}
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x000CE408 File Offset: 0x000CC608
		internal MethodCall(CADMethodCallMessage msg)
		{
			this._uri = string.Copy(msg.Uri);
			ArrayList arguments = msg.GetArguments();
			this._args = msg.GetArgs(arguments);
			this._callContext = msg.GetLogicalCallContext(arguments);
			if (this._callContext == null)
			{
				this._callContext = new LogicalCallContext();
			}
			this._methodBase = msg.GetMethod();
			this.Init();
			if (msg.PropertiesCount > 0)
			{
				CADMessageBase.UnmarshalProperties(this.Properties, msg.PropertiesCount, arguments);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" />, копируя существующее сообщение.</summary>
		/// <param name="msg">Сообщение удаленного взаимодействия.</param>
		// Token: 0x06003B1D RID: 15133 RVA: 0x000CE490 File Offset: 0x000CC690
		public MethodCall(IMessage msg)
		{
			if (msg is IMethodMessage)
			{
				this.CopyFrom((IMethodMessage)msg);
				return;
			}
			foreach (object obj in msg.Properties)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				this.InitMethodProperty((string)dictionaryEntry.Key, dictionaryEntry.Value);
			}
			this.Init();
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x000CE51C File Offset: 0x000CC71C
		internal MethodCall(string uri, string typeName, string methodName, object[] args)
		{
			this._uri = uri;
			this._typeName = typeName;
			this._methodName = methodName;
			this._args = args;
			this.Init();
			this.ResolveMethod();
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x000CE550 File Offset: 0x000CC750
		internal MethodCall(object handlerObject, BinaryMethodCallMessage smuggledMsg)
		{
			if (handlerObject != null)
			{
				this._uri = (handlerObject as string);
				if (this._uri == null && handlerObject is MarshalByRefObject)
				{
					throw new NotImplementedException("MarshalByRefObject.GetIdentity");
				}
			}
			this._typeName = smuggledMsg.TypeName;
			this._methodName = smuggledMsg.MethodName;
			this._methodSignature = (Type[])smuggledMsg.MethodSignature;
			this._args = smuggledMsg.Args;
			this._genericArguments = smuggledMsg.InstantiationArgs;
			this._callContext = smuggledMsg.LogicalCallContext;
			this.ResolveMethod();
			if (smuggledMsg.HasProperties)
			{
				smuggledMsg.PopulateMessageProperties(this.Properties);
			}
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x0000259F File Offset: 0x0000079F
		internal MethodCall()
		{
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x000CE5F4 File Offset: 0x000CC7F4
		internal void CopyFrom(IMethodMessage call)
		{
			this._uri = call.Uri;
			this._typeName = call.TypeName;
			this._methodName = call.MethodName;
			this._args = call.Args;
			this._methodSignature = (Type[])call.MethodSignature;
			this._methodBase = call.MethodBase;
			this._callContext = call.LogicalCallContext;
			this.Init();
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x000CE660 File Offset: 0x000CC860
		internal virtual void InitMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 1619225942U)
			{
				if (num != 990701179U)
				{
					if (num != 1201911322U)
					{
						if (num == 1619225942U)
						{
							if (key == "__Args")
							{
								this._args = (object[])value;
								return;
							}
						}
					}
					else if (key == "__CallContext")
					{
						this._callContext = (LogicalCallContext)value;
						return;
					}
				}
				else if (key == "__Uri")
				{
					this._uri = (string)value;
					return;
				}
			}
			else if (num <= 2850677384U)
			{
				if (num != 2010141056U)
				{
					if (num == 2850677384U)
					{
						if (key == "__GenericArguments")
						{
							this._genericArguments = (Type[])value;
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
			else if (num != 3166241401U)
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
			else if (key == "__MethodName")
			{
				this._methodName = (string)value;
				return;
			}
			this.Properties[key] = value;
		}

		/// <summary>Метод <see cref="M:System.Runtime.Remoting.Messaging.MethodCall.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> не реализован.</summary>
		/// <param name="info">Данные для сериализации или десериализации удаленного объекта.</param>
		/// <param name="context">Контекст определенного сериализуемого потока.</param>
		// Token: 0x06003B23 RID: 15139 RVA: 0x000CE7B4 File Offset: 0x000CC9B4
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("__TypeName", this._typeName);
			info.AddValue("__MethodName", this._methodName);
			info.AddValue("__MethodSignature", this._methodSignature);
			info.AddValue("__Args", this._args);
			info.AddValue("__CallContext", this._callContext);
			info.AddValue("__Uri", this._uri);
			info.AddValue("__GenericArguments", this._genericArguments);
			if (this.InternalProperties != null)
			{
				foreach (object obj in this.InternalProperties)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					info.AddValue((string)dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
		}

		/// <summary>Возвращает число аргументов, переданных методу.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов, переданных методу.</returns>
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x000CE8A0 File Offset: 0x000CCAA0
		public int ArgCount
		{
			[SecurityCritical]
			get
			{
				return this._args.Length;
			}
		}

		/// <summary>Возвращает массив аргументов, переданных методу.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы, переданные методу.</returns>
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x000CE8AA File Offset: 0x000CCAAA
		public object[] Args
		{
			[SecurityCritical]
			get
			{
				return this._args;
			}
		}

		/// <summary>Возвращает значение, указывающее, принимает ли метод переменное число аргументов.</summary>
		/// <returns>
		///   <see langword="true" />, если метод принимает переменное число аргументов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x000CE8B2 File Offset: 0x000CCAB2
		public bool HasVarArgs
		{
			[SecurityCritical]
			get
			{
				return (this.MethodBase.CallingConvention | CallingConventions.VarArgs) > (CallingConventions)0;
			}
		}

		/// <summary>Возвращает число аргументов в вызове метода, которые не помечены как параметры <see langword="out" />.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов в вызове метода, не помеченных как параметры <see langword="out" />.</returns>
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x000CE8C4 File Offset: 0x000CCAC4
		public int InArgCount
		{
			[SecurityCritical]
			get
			{
				if (this._inArgInfo == null)
				{
					this._inArgInfo = new ArgInfo(this._methodBase, ArgInfoType.In);
				}
				return this._inArgInfo.GetInOutArgCount();
			}
		}

		/// <summary>Возвращает массив аргументов в вызове метода, которые не помечены как параметры <see langword="out" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы в вызове метода, не помеченные как параметры <see langword="out" />.</returns>
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x000CE8EB File Offset: 0x000CCAEB
		public object[] InArgs
		{
			[SecurityCritical]
			get
			{
				if (this._inArgInfo == null)
				{
					this._inArgInfo = new ArgInfo(this._methodBase, ArgInfoType.In);
				}
				return this._inArgInfo.GetInOutArgs(this._args);
			}
		}

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</returns>
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06003B29 RID: 15145 RVA: 0x000CE918 File Offset: 0x000CCB18
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
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x000CE933 File Offset: 0x000CCB33
		public MethodBase MethodBase
		{
			[SecurityCritical]
			get
			{
				if (this._methodBase == null)
				{
					this.ResolveMethod();
				}
				return this._methodBase;
			}
		}

		/// <summary>Возвращает имя вызванного метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее имя вызванного метода.</returns>
		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x000CE94F File Offset: 0x000CCB4F
		public string MethodName
		{
			[SecurityCritical]
			get
			{
				if (this._methodName == null)
				{
					this._methodName = this._methodBase.Name;
				}
				return this._methodName;
			}
		}

		/// <summary>Возвращает объект, содержащий подпись метода.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий подпись метода.</returns>
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x000CE970 File Offset: 0x000CCB70
		public object MethodSignature
		{
			[SecurityCritical]
			get
			{
				if (this._methodSignature == null && this._methodBase != null)
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

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</returns>
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x000CE9D1 File Offset: 0x000CCBD1
		public virtual IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				if (this.ExternalProperties == null)
				{
					this.InitDictionary();
				}
				return this.ExternalProperties;
			}
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x000CE9E8 File Offset: 0x000CCBE8
		internal virtual void InitDictionary()
		{
			MCMDictionary mcmdictionary = new MCMDictionary(this);
			this.ExternalProperties = mcmdictionary;
			this.InternalProperties = mcmdictionary.GetInternalProperties();
		}

		/// <summary>Возвращает полное имя типа удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее полное имя типа удаленного объекта, к которому осуществляется вызов метода.</returns>
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x000CEA0F File Offset: 0x000CCC0F
		public string TypeName
		{
			[SecurityCritical]
			get
			{
				if (this._typeName == null)
				{
					this._typeName = this._methodBase.DeclaringType.AssemblyQualifiedName;
				}
				return this._typeName;
			}
		}

		/// <summary>Получает или задает универсальный код ресурса (URI) удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>URI удаленного объекта.</returns>
		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x000CEA35 File Offset: 0x000CCC35
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x000CEA3D File Offset: 0x000CCC3D
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

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x000CEA46 File Offset: 0x000CCC46
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x000CEA4E File Offset: 0x000CCC4E
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
		// Token: 0x06003B34 RID: 15156 RVA: 0x000CEA57 File Offset: 0x000CCC57
		[SecurityCritical]
		public object GetArg(int argNum)
		{
			return this._args[argNum];
		}

		/// <summary>Возвращает имя аргумента метода по указанному индексу.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента метода.</returns>
		// Token: 0x06003B35 RID: 15157 RVA: 0x000CEA61 File Offset: 0x000CCC61
		[SecurityCritical]
		public string GetArgName(int index)
		{
			return this._methodBase.GetParameters()[index].Name;
		}

		/// <summary>Возвращает аргумент метода по указанному индексу, не помеченный как параметр <see langword="out" />.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Аргумент метода, который не помечен как параметр <see langword="out" />.</returns>
		// Token: 0x06003B36 RID: 15158 RVA: 0x000CEA75 File Offset: 0x000CCC75
		[SecurityCritical]
		public object GetInArg(int argNum)
		{
			if (this._inArgInfo == null)
			{
				this._inArgInfo = new ArgInfo(this._methodBase, ArgInfoType.In);
			}
			return this._args[this._inArgInfo.GetInOutArgIndex(argNum)];
		}

		/// <summary>Возвращает имя аргумента метода по указанному индексу, не помеченного как параметр <see langword="out" />.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента метода, который не помечен как параметр <see langword="out" />.</returns>
		// Token: 0x06003B37 RID: 15159 RVA: 0x000CEAA4 File Offset: 0x000CCCA4
		[SecurityCritical]
		public string GetInArgName(int index)
		{
			if (this._inArgInfo == null)
			{
				this._inArgInfo = new ArgInfo(this._methodBase, ArgInfoType.In);
			}
			return this._inArgInfo.GetInOutArgName(index);
		}

		/// <summary>Инициализирует внутренний обработчик сериализации из массива заголовков удаленного взаимодействия, применяемых к методу.</summary>
		/// <param name="h">Массив заголовков удаленного взаимодействия, содержащих пары "ключ-значение". Этот массив используется для инициализации полей <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" /> для заголовков, принадлежащих пространству имен "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
		/// <returns>Внутренний обработчик сериализации.</returns>
		// Token: 0x06003B38 RID: 15160 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual object HeaderHandler(Header[] h)
		{
			throw new NotImplementedException();
		}

		/// <summary>Инициализирует <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" />.</summary>
		// Token: 0x06003B39 RID: 15161 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void Init()
		{
		}

		/// <summary>Задает информацию для метода из предварительно инициализированных свойств сообщения удаленного взаимодействия.</summary>
		// Token: 0x06003B3A RID: 15162 RVA: 0x000CEACC File Offset: 0x000CCCCC
		public void ResolveMethod()
		{
			if (this._uri != null)
			{
				Type serverTypeForUri = RemotingServices.GetServerTypeForUri(this._uri);
				if (serverTypeForUri == null)
				{
					string str = (this._typeName != null) ? (" (" + this._typeName + ")") : "";
					throw new RemotingException("Requested service not found" + str + ". No receiver for uri " + this._uri);
				}
				Type type = this.CastTo(this._typeName, serverTypeForUri);
				if (type == null)
				{
					throw new RemotingException(string.Concat(new string[]
					{
						"Cannot cast from client type '",
						this._typeName,
						"' to server type '",
						serverTypeForUri.FullName,
						"'"
					}));
				}
				this._methodBase = RemotingServices.GetMethodBaseFromName(type, this._methodName, this._methodSignature);
				if (this._methodBase == null)
				{
					string str2 = "Method ";
					string methodName = this._methodName;
					string str3 = " not found in ";
					Type type2 = type;
					throw new RemotingException(str2 + methodName + str3 + ((type2 != null) ? type2.ToString() : null));
				}
				if (type != serverTypeForUri && type.IsInterface && !serverTypeForUri.IsInterface)
				{
					this._methodBase = RemotingServices.GetVirtualMethod(serverTypeForUri, this._methodBase);
					if (this._methodBase == null)
					{
						string str4 = "Method ";
						string methodName2 = this._methodName;
						string str5 = " not found in ";
						Type type3 = serverTypeForUri;
						throw new RemotingException(str4 + methodName2 + str5 + ((type3 != null) ? type3.ToString() : null));
					}
				}
			}
			else
			{
				this._methodBase = RemotingServices.GetMethodBaseFromMethodMessage(this);
				if (this._methodBase == null)
				{
					throw new RemotingException("Method " + this._methodName + " not found in " + this.TypeName);
				}
			}
			if (this._methodBase.IsGenericMethod && this._methodBase.ContainsGenericParameters)
			{
				if (this.GenericArguments == null)
				{
					throw new RemotingException("The remoting infrastructure does not support open generic methods.");
				}
				this._methodBase = ((MethodInfo)this._methodBase).MakeGenericMethod(this.GenericArguments);
			}
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x000CECC8 File Offset: 0x000CCEC8
		private Type CastTo(string clientType, Type serverType)
		{
			clientType = MethodCall.GetTypeNameFromAssemblyQualifiedName(clientType);
			if (clientType == serverType.FullName)
			{
				return serverType;
			}
			Type baseType = serverType.BaseType;
			while (baseType != null)
			{
				if (clientType == baseType.FullName)
				{
					return baseType;
				}
				baseType = baseType.BaseType;
			}
			foreach (Type type in serverType.GetInterfaces())
			{
				if (clientType == type.FullName)
				{
					return type;
				}
			}
			return null;
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x000CED40 File Offset: 0x000CCF40
		private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			int num = aqname.IndexOf("]]");
			int num2 = aqname.IndexOf(',', (num == -1) ? 0 : (num + 2));
			if (num2 != -1)
			{
				aqname = aqname.Substring(0, num2).Trim();
			}
			return aqname;
		}

		/// <summary>Задает информацию для метода из настроек сериализации.</summary>
		/// <param name="info">Данные для сериализации или десериализации удаленного объекта.</param>
		/// <param name="ctx">Контекст заданного сериализуемого потока.</param>
		// Token: 0x06003B3D RID: 15165 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public void RootSetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x000CED80 File Offset: 0x000CCF80
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x000CED88 File Offset: 0x000CCF88
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

		// Token: 0x06003B40 RID: 15168 RVA: 0x000CED91 File Offset: 0x000CCF91
		bool IInternalMessage.HasProperties()
		{
			return this.ExternalProperties != null || this.InternalProperties != null;
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x000CEDA8 File Offset: 0x000CCFA8
		private Type[] GenericArguments
		{
			get
			{
				if (this._genericArguments != null)
				{
					return this._genericArguments;
				}
				return this._genericArguments = this.MethodBase.GetGenericArguments();
			}
		}

		// Token: 0x04002693 RID: 9875
		private string _uri;

		// Token: 0x04002694 RID: 9876
		private string _typeName;

		// Token: 0x04002695 RID: 9877
		private string _methodName;

		// Token: 0x04002696 RID: 9878
		private object[] _args;

		// Token: 0x04002697 RID: 9879
		private Type[] _methodSignature;

		// Token: 0x04002698 RID: 9880
		private MethodBase _methodBase;

		// Token: 0x04002699 RID: 9881
		private LogicalCallContext _callContext;

		// Token: 0x0400269A RID: 9882
		private ArgInfo _inArgInfo;

		// Token: 0x0400269B RID: 9883
		private Identity _targetIdentity;

		// Token: 0x0400269C RID: 9884
		private Type[] _genericArguments;

		/// <summary>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		// Token: 0x0400269D RID: 9885
		protected IDictionary ExternalProperties;

		/// <summary>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		// Token: 0x0400269E RID: 9886
		protected IDictionary InternalProperties;
	}
}
