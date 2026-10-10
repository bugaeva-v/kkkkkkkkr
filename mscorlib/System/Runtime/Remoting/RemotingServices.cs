using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Services;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Threading;
using Mono.Interop;

namespace System.Runtime.Remoting
{
	/// <summary>Обеспечивает несколько методов для использования и публикации удаленных объектов и прокси. Этот класс не наследуется.</summary>
	// Token: 0x0200056B RID: 1387
	[ComVisible(true)]
	public static class RemotingServices
	{
		// Token: 0x0600366A RID: 13930 RVA: 0x000C4824 File Offset: 0x000C2A24
		static RemotingServices()
		{
			ISurrogateSelector selector = new RemotingSurrogateSelector();
			StreamingContext context = new StreamingContext(StreamingContextStates.Remoting, null);
			RemotingServices._serializationFormatter = new BinaryFormatter(selector, context);
			RemotingServices._deserializationFormatter = new BinaryFormatter(null, context);
			RemotingServices._serializationFormatter.AssemblyFormat = FormatterAssemblyStyle.Full;
			RemotingServices._deserializationFormatter.AssemblyFormat = FormatterAssemblyStyle.Full;
			RemotingServices.RegisterInternalChannels();
			RemotingServices.CreateWellKnownServerIdentity(typeof(RemoteActivator), "RemoteActivationService.rem", WellKnownObjectMode.Singleton);
			RemotingServices.FieldSetterMethod = typeof(object).GetMethod("FieldSetter", BindingFlags.Instance | BindingFlags.NonPublic);
			RemotingServices.FieldGetterMethod = typeof(object).GetMethod("FieldGetter", BindingFlags.Instance | BindingFlags.NonPublic);
		}

		// Token: 0x0600366B RID: 13931
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args);

		// Token: 0x0600366C RID: 13932
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MethodBase GetVirtualMethod(Type type, MethodBase method);

		/// <summary>Возвращает логическое значение, указывающее, является ли данный объект прозрачным прокси или настоящим объектом.</summary>
		/// <param name="proxy">Проверяемая ссылка на объект.</param>
		/// <returns>Логическое значение, указывающее, является ли объект, указанный в параметре <paramref name="proxy" />, прозрачным прокси или настоящим объектом.</returns>
		// Token: 0x0600366D RID: 13933
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTransparentProxy(object proxy);

		// Token: 0x0600366E RID: 13934 RVA: 0x000040F7 File Offset: 0x000022F7
		internal static bool ProxyCheckCast(RealProxy rp, RuntimeType castType)
		{
			return true;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x000C48D8 File Offset: 0x000C2AD8
		internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			Type type = target.GetType();
			MethodBase methodBase;
			if (reqMsg.MethodBase.DeclaringType == type || reqMsg.MethodBase == RemotingServices.FieldSetterMethod || reqMsg.MethodBase == RemotingServices.FieldGetterMethod)
			{
				methodBase = reqMsg.MethodBase;
			}
			else
			{
				methodBase = RemotingServices.GetVirtualMethod(type, reqMsg.MethodBase);
				if (methodBase == null)
				{
					throw new RemotingException(string.Format("Cannot resolve method {0}:{1}", type, reqMsg.MethodName));
				}
			}
			if (reqMsg.MethodBase.IsGenericMethod)
			{
				Type[] genericArguments = reqMsg.MethodBase.GetGenericArguments();
				methodBase = ((MethodInfo)methodBase).GetGenericMethodDefinition().MakeGenericMethod(genericArguments);
			}
			LogicalCallContext logicalCallContext = CallContext.SetLogicalCallContext(reqMsg.LogicalCallContext);
			ReturnMessage result;
			try
			{
				object[] array;
				object ret = RemotingServices.InternalExecute(methodBase, target, reqMsg.Args, out array);
				ParameterInfo[] parameters = methodBase.GetParameters();
				object[] array2 = new object[parameters.Length];
				int outArgsCount = 0;
				int num = 0;
				foreach (ParameterInfo parameterInfo in parameters)
				{
					if (parameterInfo.IsOut && !parameterInfo.ParameterType.IsByRef)
					{
						array2[outArgsCount++] = reqMsg.GetArg(parameterInfo.Position);
					}
					else if (parameterInfo.ParameterType.IsByRef)
					{
						array2[outArgsCount++] = array[num++];
					}
					else
					{
						array2[outArgsCount++] = null;
					}
				}
				LogicalCallContext logicalCallContext2 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
				result = new ReturnMessage(ret, array2, outArgsCount, logicalCallContext2, reqMsg);
			}
			catch (Exception e)
			{
				result = new ReturnMessage(e, reqMsg);
			}
			CallContext.SetLogicalCallContext(logicalCallContext);
			return result;
		}

		/// <summary>Подключается к указанному удаленному объекту и выполняет на нем предоставленный <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" />.</summary>
		/// <param name="target">Удаленные объекты, методы которых необходимо вызвать.</param>
		/// <param name="reqMsg">Сообщение вызова метода на указанный метод удаленного объекта.</param>
		/// <returns>Ответ удаленного метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Метод был вызван из контекста, отличного от заданного контекста объекта.</exception>
		// Token: 0x06003670 RID: 13936 RVA: 0x000C4A78 File Offset: 0x000C2C78
		public static IMethodReturnMessage ExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			if (RemotingServices.IsTransparentProxy(target))
			{
				return (IMethodReturnMessage)RemotingServices.GetRealProxy(target).Invoke(reqMsg);
			}
			return RemotingServices.InternalExecuteMessage(target, reqMsg);
		}

		/// <summary>Создает прокси для хорошо известного объекта, если заданы <see cref="T:System.Type" /> и URL-адрес.</summary>
		/// <param name="classToProxy">Тип <see cref="T:System.Type" /> хорошо известного объекта, к которому нужно подключиться.</param>
		/// <param name="url">URL-адрес класса сервера.</param>
		/// <returns>Прокси на удаленный объект, который указывает на конечную точка, обслуживаемую указанным хорошо известным объектом.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий оператор не имеет разрешения для конфигурации типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003671 RID: 13937 RVA: 0x000C4A9B File Offset: 0x000C2C9B
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url)
		{
			return RemotingServices.GetRemoteObject(new ObjRef(classToProxy, url, null), classToProxy);
		}

		/// <summary>Создает прокси для хорошо известного объекта, если заданы <see cref="T:System.Type" />, URL-адрес и данные указанного канала.</summary>
		/// <param name="classToProxy">Тип <see cref="T:System.Type" /> хорошо известного объекта, к которому нужно подключиться.</param>
		/// <param name="url">URL-адрес хорошо известного объекта.</param>
		/// <param name="data">Данные указанного канала. Может иметь значение <see langword="null" />.</param>
		/// <returns>Прокси указывают на конечную точка, обслуживаемую указанным хорошо известным объектом.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий оператор не имеет разрешения для конфигурации типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003672 RID: 13938 RVA: 0x000C4AAB File Offset: 0x000C2CAB
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url, object data)
		{
			return RemotingServices.GetRemoteObject(new ObjRef(classToProxy, url, data), classToProxy);
		}

		/// <summary>Прекращает получение дальнейших сообщений по зарегистрированным каналам удаленного доступа.</summary>
		/// <param name="obj">Объекты, отключаемые от своих каналов.</param>
		/// <returns>
		///   <see langword="true" />, если объект отключается от зарегистрированного канала удаленного доступа успешно; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> является прокси.</exception>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий оператор не имеет разрешения для конфигурации типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003673 RID: 13939 RVA: 0x000C4ABC File Offset: 0x000C2CBC
		public static bool Disconnect(MarshalByRefObject obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			ServerIdentity serverIdentity;
			if (RemotingServices.IsTransparentProxy(obj))
			{
				RealProxy realProxy = RemotingServices.GetRealProxy(obj);
				if (!realProxy.GetProxiedType().IsContextful || !(realProxy.ObjectIdentity is ServerIdentity))
				{
					throw new ArgumentException("The obj parameter is a proxy.");
				}
				serverIdentity = (realProxy.ObjectIdentity as ServerIdentity);
			}
			else
			{
				serverIdentity = obj.ObjectIdentity;
				obj.ObjectIdentity = null;
			}
			if (serverIdentity == null || !serverIdentity.IsConnected)
			{
				return false;
			}
			LifetimeServices.StopTrackingLifetime(serverIdentity);
			RemotingServices.DisposeIdentity(serverIdentity);
			TrackingServices.NotifyDisconnectedObject(obj);
			return true;
		}

		/// <summary>Возвращает тип <see cref="T:System.Type" /> объекта с указанным URI.</summary>
		/// <param name="URI">URI объекта, тип <see cref="T:System.Type" /> которого запрошен.</param>
		/// <returns>Тип <see cref="T:System.Type" /> объекта с указанным URI.</returns>
		/// <exception cref="T:System.Security.SecurityException">Или непосредственный вызывающий не имеет разрешения инфраструктуры, или ни один из вызывающих, находящихся на вершине стека вызовов, не имеет разрешения на извлечение сведений о типе членов, не являющихся открытыми.</exception>
		// Token: 0x06003674 RID: 13940 RVA: 0x000C4B48 File Offset: 0x000C2D48
		public static Type GetServerTypeForUri(string URI)
		{
			ServerIdentity serverIdentity = RemotingServices.GetIdentityForUri(URI) as ServerIdentity;
			if (serverIdentity == null)
			{
				return null;
			}
			return serverIdentity.ObjectType;
		}

		/// <summary>Извлекает URI для указанного объекта.</summary>
		/// <param name="obj">
		///   <see cref="T:System.MarshalByRefObject" /> для которого запрашивается URI.</param>
		/// <returns>URI указанного объекта, если существует, или <see langword="null" />, если объект не был упакован и передан.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003675 RID: 13941 RVA: 0x000C4B6C File Offset: 0x000C2D6C
		public static string GetObjectUri(MarshalByRefObject obj)
		{
			Identity objectIdentity = RemotingServices.GetObjectIdentity(obj);
			if (objectIdentity is ClientIdentity)
			{
				return ((ClientIdentity)objectIdentity).TargetUri;
			}
			if (objectIdentity != null)
			{
				return objectIdentity.ObjectUri;
			}
			return null;
		}

		/// <summary>Получает <see cref="T:System.Runtime.Remoting.ObjRef" /> и создает из него прокси-объект.</summary>
		/// <param name="objectRef">
		///   <see cref="T:System.Runtime.Remoting.ObjRef" />, который представляет удаленный объект, для которого создается прокси.</param>
		/// <returns>Прокси к объекту, который представлен данным <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		/// <exception cref="T:System.ArgumentException">Экземпляр <see cref="T:System.Runtime.Remoting.ObjRef" />, указанный в параметре <paramref name="objectRef" />, создан с ошибкой.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003676 RID: 13942 RVA: 0x000C4B9F File Offset: 0x000C2D9F
		public static object Unmarshal(ObjRef objectRef)
		{
			return RemotingServices.Unmarshal(objectRef, true);
		}

		/// <summary>Получает <see cref="T:System.Runtime.Remoting.ObjRef" /> и создает из него прокси-объект, подгоняя его к типу сервера.</summary>
		/// <param name="objectRef">
		///   <see cref="T:System.Runtime.Remoting.ObjRef" />, который представляет удаленный объект, для которого создается прокси.</param>
		/// <param name="fRefine">
		///   <see langword="true" />, чтобы уточнить прокси для типа сервера; иначе — <see langword="false" />.</param>
		/// <returns>Прокси к объекту, который представлен данным <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		/// <exception cref="T:System.ArgumentException">Экземпляр <see cref="T:System.Runtime.Remoting.ObjRef" />, указанный в параметре <paramref name="objectRef" />, создан с ошибкой.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003677 RID: 13943 RVA: 0x000C4BA8 File Offset: 0x000C2DA8
		public static object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			Type type = fRefine ? objectRef.ServerType : typeof(MarshalByRefObject);
			if (type == null)
			{
				type = typeof(MarshalByRefObject);
			}
			if (objectRef.IsReferenceToWellKnow)
			{
				object remoteObject = RemotingServices.GetRemoteObject(objectRef, type);
				TrackingServices.NotifyUnmarshaledObject(remoteObject, objectRef);
				return remoteObject;
			}
			if (type.IsContextful)
			{
				ProxyAttribute proxyAttribute = (ProxyAttribute)Attribute.GetCustomAttribute(type, typeof(ProxyAttribute), true);
				if (proxyAttribute != null)
				{
					object transparentProxy = proxyAttribute.CreateProxy(objectRef, type, null, null).GetTransparentProxy();
					TrackingServices.NotifyUnmarshaledObject(transparentProxy, objectRef);
					return transparentProxy;
				}
			}
			object proxyForRemoteObject = RemotingServices.GetProxyForRemoteObject(objectRef, type);
			TrackingServices.NotifyUnmarshaledObject(proxyForRemoteObject, objectRef);
			return proxyForRemoteObject;
		}

		/// <summary>Принимает <see cref="T:System.MarshalByRefObject" />, регистрирует его инфраструктурой удаленного взаимодействия и переводит в экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
		/// <param name="Obj">Преобразуемый объект.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" />, представляющий объект, указанный в параметре <paramref name="Obj" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Параметр <paramref name="Obj" /> является прокси объектом.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003678 RID: 13944 RVA: 0x000C4C3D File Offset: 0x000C2E3D
		public static ObjRef Marshal(MarshalByRefObject Obj)
		{
			return RemotingServices.Marshal(Obj, null, null);
		}

		/// <summary>Преобразует данный <see cref="T:System.MarshalByRefObject" /> в экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" /> с указанным URI.</summary>
		/// <param name="Obj">Преобразуемый объект.</param>
		/// <param name="URI">Указанный URI, с которым инициализируется новый <see cref="T:System.Runtime.Remoting.ObjRef" />. Может иметь значение <see langword="null" />.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" />, представляющий объект, указанный в параметре <paramref name="Obj" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="Obj" /> является прокси объектом и параметр <paramref name="URI" /> не равен <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003679 RID: 13945 RVA: 0x000C4C47 File Offset: 0x000C2E47
		public static ObjRef Marshal(MarshalByRefObject Obj, string URI)
		{
			return RemotingServices.Marshal(Obj, URI, null);
		}

		/// <summary>Получает <see cref="T:System.MarshalByRefObject" /> и переводит его в экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" /> с указанным URI, и предоставленным <see cref="T:System.Type" />.</summary>
		/// <param name="Obj">Объект, преобразуемый в <see cref="T:System.Runtime.Remoting.ObjRef" />.</param>
		/// <param name="ObjURI">URI, с которым упакован и передан объект, указанный в параметре <paramref name="Obj" />. Может иметь значение <see langword="null" />.</param>
		/// <param name="RequestedType">
		///   <see cref="T:System.Type" />, в качестве которого маршалируется <paramref name="Obj" />. Может иметь значение <see langword="null" />.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" />, представляющий объект, указанный в параметре <paramref name="Obj" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="Obj" /> является прокси удаленного объекта, и параметр <paramref name="ObjUri" /> не равен <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600367A RID: 13946 RVA: 0x000C4C54 File Offset: 0x000C2E54
		public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			if (RemotingServices.IsTransparentProxy(Obj))
			{
				RealProxy realProxy = RemotingServices.GetRealProxy(Obj);
				Identity objectIdentity = realProxy.ObjectIdentity;
				if (objectIdentity != null)
				{
					if (realProxy.GetProxiedType().IsContextful && !objectIdentity.IsConnected)
					{
						ClientActivatedIdentity clientActivatedIdentity = (ClientActivatedIdentity)objectIdentity;
						if (ObjURI == null)
						{
							ObjURI = RemotingServices.NewUri();
						}
						clientActivatedIdentity.ObjectUri = ObjURI;
						RemotingServices.RegisterServerIdentity(clientActivatedIdentity);
						clientActivatedIdentity.StartTrackingLifetime((ILease)Obj.InitializeLifetimeService());
						return clientActivatedIdentity.CreateObjRef(RequestedType);
					}
					if (ObjURI != null)
					{
						throw new RemotingException("It is not possible marshal a proxy of a remote object.");
					}
					ObjRef objRef = realProxy.ObjectIdentity.CreateObjRef(RequestedType);
					TrackingServices.NotifyMarshaledObject(Obj, objRef);
					return objRef;
				}
			}
			if (RequestedType == null)
			{
				RequestedType = Obj.GetType();
			}
			if (ObjURI == null)
			{
				if (Obj.ObjectIdentity == null)
				{
					ObjURI = RemotingServices.NewUri();
					RemotingServices.CreateClientActivatedServerIdentity(Obj, RequestedType, ObjURI);
				}
			}
			else
			{
				ClientActivatedIdentity clientActivatedIdentity2 = RemotingServices.GetIdentityForUri("/" + ObjURI) as ClientActivatedIdentity;
				if (clientActivatedIdentity2 == null || Obj != clientActivatedIdentity2.GetServerObject())
				{
					RemotingServices.CreateClientActivatedServerIdentity(Obj, RequestedType, ObjURI);
				}
			}
			ObjRef objRef2;
			if (RemotingServices.IsTransparentProxy(Obj))
			{
				objRef2 = RemotingServices.GetRealProxy(Obj).ObjectIdentity.CreateObjRef(RequestedType);
			}
			else
			{
				objRef2 = Obj.CreateObjRef(RequestedType);
			}
			TrackingServices.NotifyMarshaledObject(Obj, objRef2);
			return objRef2;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x000C4D70 File Offset: 0x000C2F70
		private static string NewUri()
		{
			if (RemotingServices.app_id == null)
			{
				object obj = RemotingServices.app_id_lock;
				lock (obj)
				{
					if (RemotingServices.app_id == null)
					{
						RemotingServices.app_id = Guid.NewGuid().ToString().Replace('-', '_') + "/";
					}
				}
			}
			int num = Interlocked.Increment(ref RemotingServices.next_id);
			return string.Concat(new string[]
			{
				RemotingServices.app_id,
				Environment.TickCount.ToString("x"),
				"_",
				num.ToString(),
				".rem"
			});
		}

		/// <summary>Возвращает настоящий прокси, поддерживающий указанный прозрачный прокси.</summary>
		/// <param name="proxy">Прозрачный прокси.</param>
		/// <returns>Настоящий прокси, поддерживающий указанный прозрачный прокси.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600367C RID: 13948 RVA: 0x000C4E30 File Offset: 0x000C3030
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static RealProxy GetRealProxy(object proxy)
		{
			if (!RemotingServices.IsTransparentProxy(proxy))
			{
				throw new RemotingException("Cannot get the real proxy from an object that is not a transparent proxy.");
			}
			return ((TransparentProxy)proxy)._rp;
		}

		/// <summary>Возвращает базу метода из данного <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" />.</summary>
		/// <param name="msg">Сообщение метода, из которого извлекается база метода.</param>
		/// <returns>База метода, извлеченная из параметра <paramref name="msg" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Или непосредственный вызывающий не имеет разрешения инфраструктуры, или ни один из вызывающих, находящихся на вершине стека вызовов, не имеет разрешения на извлечение сведений о типе членов, не являющихся открытыми.</exception>
		// Token: 0x0600367D RID: 13949 RVA: 0x000C4E50 File Offset: 0x000C3050
		public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			Type type = Type.GetType(msg.TypeName);
			if (type == null)
			{
				throw new RemotingException("Type '" + msg.TypeName + "' not found.");
			}
			return RemotingServices.GetMethodBaseFromName(type, msg.MethodName, (Type[])msg.MethodSignature);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x000C4EA4 File Offset: 0x000C30A4
		internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature)
		{
			if (type.IsInterface)
			{
				return RemotingServices.FindInterfaceMethod(type, methodName, signature);
			}
			MethodBase method;
			if (signature == null)
			{
				method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			else
			{
				method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null);
			}
			if (method != null)
			{
				return method;
			}
			if (methodName == "FieldSetter")
			{
				return RemotingServices.FieldSetterMethod;
			}
			if (methodName == "FieldGetter")
			{
				return RemotingServices.FieldGetterMethod;
			}
			if (signature == null)
			{
				return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			}
			return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null);
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x000C4F30 File Offset: 0x000C3130
		private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature)
		{
			MethodBase methodBase;
			if (signature == null)
			{
				methodBase = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			else
			{
				methodBase = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null);
			}
			if (methodBase != null)
			{
				return methodBase;
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				methodBase = RemotingServices.FindInterfaceMethod(interfaces[i], methodName, signature);
				if (methodBase != null)
				{
					return methodBase;
				}
			}
			return null;
		}

		/// <summary>Сериализует указанный упаковываемый и передаваемый по ссылке объект, в предоставленный <see cref="T:System.Runtime.Serialization.SerializationInfo" /> .</summary>
		/// <param name="obj">Объект для сериализации.</param>
		/// <param name="info">
		///   <see cref="T:System.Runtime.Serialization.SerializationInfo" />, в котором упорядочивается объект.</param>
		/// <param name="context">Новые источник и приемник сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> или параметра <paramref name="info" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003680 RID: 13952 RVA: 0x000C4F92 File Offset: 0x000C3192
		public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			RemotingServices.Marshal((MarshalByRefObject)obj).GetObjectData(info, context);
		}

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.ObjRef" />, который представляет удаленный объект из указанного прокси.</summary>
		/// <param name="obj">Прокси, подключенный к объекту, для которого создается <see cref="T:System.Runtime.Remoting.ObjRef" />.</param>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.ObjRef" />, представляющий удаленный объект, к которому подключен указанный прокси или <see langword="null" />, если объект или прокси не были упакованы и переданы.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003681 RID: 13953 RVA: 0x000C4FB4 File Offset: 0x000C31B4
		public static ObjRef GetObjRefForProxy(MarshalByRefObject obj)
		{
			Identity objectIdentity = RemotingServices.GetObjectIdentity(obj);
			if (objectIdentity == null)
			{
				return null;
			}
			return objectIdentity.CreateObjRef(null);
		}

		/// <summary>Возвращает объект службы времени жизни, который контролирует политику времени жизни указанного объекта.</summary>
		/// <param name="obj">Объект, для которого необходимо получить время жизни службы.</param>
		/// <returns>Объект, контролирующий время жизни <paramref name="obj" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003682 RID: 13954 RVA: 0x000C4FD4 File Offset: 0x000C31D4
		public static object GetLifetimeService(MarshalByRefObject obj)
		{
			if (obj == null)
			{
				return null;
			}
			return obj.GetLifetimeService();
		}

		/// <summary>Возвращает цепь приемников делегата, которые должны использоваться при пересылке сообщений на удаленный объект, представленный указанным прокси.</summary>
		/// <param name="obj">Прокси удаленного объекта, запросившего приемники связанного с ним делегата.</param>
		/// <returns>Цепь приемников делегата, связанных с указанным прокси.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003683 RID: 13955 RVA: 0x000C4FE1 File Offset: 0x000C31E1
		public static IMessageSink GetEnvoyChainForProxy(MarshalByRefObject obj)
		{
			if (RemotingServices.IsTransparentProxy(obj))
			{
				return ((ClientIdentity)RemotingServices.GetRealProxy(obj).ObjectIdentity).EnvoySink;
			}
			throw new ArgumentException("obj must be a proxy.", "obj");
		}

		/// <summary>Регистрирует этап удаленного обмена во внешнем отладчике.</summary>
		/// <param name="stage">Определенная внутри константа, определяющая этап удаленного обмена.</param>
		// Token: 0x06003684 RID: 13956 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete("It existed for only internal use in .NET and unimplemented in mono")]
		[Conditional("REMOTING_PERF")]
		[MonoTODO]
		public static void LogRemotingStage(int stage)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает идентификатор сессии для сообщения.</summary>
		/// <param name="msg">
		///   <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" />, для которого запрашивается идентификатор сессии.</param>
		/// <returns>Строка идентификатора сессии, однозначно определяющая текущую сессию.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003685 RID: 13957 RVA: 0x000C5010 File Offset: 0x000C3210
		public static string GetSessionIdForMethodMessage(IMethodMessage msg)
		{
			return msg.Uri;
		}

		/// <summary>Возвращает логическое значение, указывающее, перезагружен ли метод в данном сообщении.</summary>
		/// <param name="msg">Сообщение, содержащее вызов метода в вопросе.</param>
		/// <returns>
		///   <see langword="true" />, если метод, вызываемый в <paramref name="msg" />, перезагружен; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003686 RID: 13958 RVA: 0x000C5018 File Offset: 0x000C3218
		public static bool IsMethodOverloaded(IMethodMessage msg)
		{
			RuntimeType runtimeType = (RuntimeType)msg.MethodBase.DeclaringType;
			return runtimeType.GetMethodsByName(msg.MethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, RuntimeType.MemberListType.CaseSensitive, runtimeType).Length > 1;
		}

		/// <summary>Возвращает логическое значение, указывающее, находится ли объект, указанный данным прозрачным прокси, в домене приложения, отличном от объекта, который вызвал текущий метод.</summary>
		/// <param name="tp">Объект для проверки.</param>
		/// <returns>
		///   <see langword="true" />, если объект не принадлежит текущему домену приложения; иначе — <see langword="false" />.</returns>
		// Token: 0x06003687 RID: 13959 RVA: 0x000C504C File Offset: 0x000C324C
		public static bool IsObjectOutOfAppDomain(object tp)
		{
			MarshalByRefObject marshalByRefObject = tp as MarshalByRefObject;
			return marshalByRefObject != null && RemotingServices.GetObjectIdentity(marshalByRefObject) is ClientIdentity;
		}

		/// <summary>Возвращает логическое значение, указывающее находится ли объект, представленный данным прозрачным прокси, в контексте, отличном от объекта, который вызвал текущий метод.</summary>
		/// <param name="tp">Объект для проверки.</param>
		/// <returns>
		///   <see langword="true" />, если объект не принадлежит текущему контексту; иначе — <see langword="false" />.</returns>
		// Token: 0x06003688 RID: 13960 RVA: 0x000C5074 File Offset: 0x000C3274
		public static bool IsObjectOutOfContext(object tp)
		{
			MarshalByRefObject marshalByRefObject = tp as MarshalByRefObject;
			if (marshalByRefObject == null)
			{
				return false;
			}
			Identity objectIdentity = RemotingServices.GetObjectIdentity(marshalByRefObject);
			if (objectIdentity == null)
			{
				return false;
			}
			ServerIdentity serverIdentity = objectIdentity as ServerIdentity;
			return serverIdentity == null || serverIdentity.Context != Thread.CurrentContext;
		}

		/// <summary>Возвращает логическое значение, указывающее, ожидает ли клиент, вызывающий указанный в данном сообщении метод, окончание обработки метода сервером, до того как продолжить обработку.</summary>
		/// <param name="method">Метод в вопросе.</param>
		/// <returns>
		///   <see langword="true" />, если метод односторонний; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003689 RID: 13961 RVA: 0x000C50B5 File Offset: 0x000C32B5
		public static bool IsOneWay(MethodBase method)
		{
			return method.IsDefined(typeof(OneWayAttribute), false);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x000C50C8 File Offset: 0x000C32C8
		internal static bool IsAsyncMessage(IMessage msg)
		{
			return msg is MonoMethodMessage && (((MonoMethodMessage)msg).IsAsync || RemotingServices.IsOneWay(((MonoMethodMessage)msg).MethodBase));
		}

		/// <summary>Задает URI для дальнейшего вызова в метод <see cref="M:System.Runtime.Remoting.RemotingServices.Marshal(System.MarshalByRefObject)" />.</summary>
		/// <param name="obj">Объект, для которого задается URI.</param>
		/// <param name="uri">URI, которое приписывается заданному объекту.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="obj" /> не является локальным объектом, уже был упакован и передан или на него вызван текущий метод.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600368B RID: 13963 RVA: 0x000C50F8 File Offset: 0x000C32F8
		public static void SetObjectUriForMarshal(MarshalByRefObject obj, string uri)
		{
			if (RemotingServices.IsTransparentProxy(obj))
			{
				RealProxy realProxy = RemotingServices.GetRealProxy(obj);
				Identity objectIdentity = realProxy.ObjectIdentity;
				if (objectIdentity != null && !(objectIdentity is ServerIdentity) && !realProxy.GetProxiedType().IsContextful)
				{
					throw new RemotingException("SetObjectUriForMarshal method should only be called for MarshalByRefObjects that exist in the current AppDomain.");
				}
			}
			RemotingServices.Marshal(obj, uri);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x000C5148 File Offset: 0x000C3348
		internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
		{
			if (entry.ContextAttributes != null || activationAttributes != null)
			{
				ArrayList arrayList = new ArrayList();
				if (entry.ContextAttributes != null)
				{
					arrayList.AddRange(entry.ContextAttributes);
				}
				if (activationAttributes != null)
				{
					arrayList.AddRange(activationAttributes);
				}
				return RemotingServices.CreateClientProxy(entry.ObjectType, entry.ApplicationUrl, arrayList.ToArray());
			}
			return RemotingServices.CreateClientProxy(entry.ObjectType, entry.ApplicationUrl, null);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000C51B0 File Offset: 0x000C33B0
		internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes)
		{
			string text = url;
			if (!text.EndsWith("/"))
			{
				text += "/";
			}
			text += "RemoteActivationService.rem";
			string text2;
			RemotingServices.GetClientChannelSinkChain(text, null, out text2);
			return new RemotingProxy(objectType, text, activationAttributes).GetTransparentProxy();
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x000C51FB File Offset: 0x000C33FB
		internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			return RemotingServices.Connect(entry.ObjectType, entry.ObjectUrl, null);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x000C5210 File Offset: 0x000C3410
		internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes)
		{
			if (type.IsContextful)
			{
				ProxyAttribute proxyAttribute = (ProxyAttribute)Attribute.GetCustomAttribute(type, typeof(ProxyAttribute), true);
				if (proxyAttribute != null)
				{
					return proxyAttribute.CreateInstance(type);
				}
			}
			return new RemotingProxy(type, ChannelServices.CrossContextUrl, activationAttributes).GetTransparentProxy();
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x000C5258 File Offset: 0x000C3458
		internal static object CreateClientProxyForComInterop(Type type)
		{
			return ComInteropProxy.CreateProxy(type).GetTransparentProxy();
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000C5268 File Offset: 0x000C3468
		internal static Identity GetIdentityForUri(string uri)
		{
			string text = RemotingServices.GetNormalizedUri(uri);
			Hashtable obj = RemotingServices.uri_hash;
			Identity result;
			lock (obj)
			{
				Identity identity = (Identity)RemotingServices.uri_hash[text];
				if (identity == null)
				{
					text = RemotingServices.RemoveAppNameFromUri(uri);
					if (text != null)
					{
						identity = (Identity)RemotingServices.uri_hash[text];
					}
				}
				result = identity;
			}
			return result;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x000C52DC File Offset: 0x000C34DC
		private static string RemoveAppNameFromUri(string uri)
		{
			string text = RemotingConfiguration.ApplicationName;
			if (text == null)
			{
				return null;
			}
			text = "/" + text + "/";
			if (uri.StartsWith(text))
			{
				return uri.Substring(text.Length);
			}
			return null;
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x000C531C File Offset: 0x000C351C
		internal static Identity GetObjectIdentity(MarshalByRefObject obj)
		{
			if (RemotingServices.IsTransparentProxy(obj))
			{
				return RemotingServices.GetRealProxy(obj).ObjectIdentity;
			}
			return obj.ObjectIdentity;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x000C5338 File Offset: 0x000C3538
		internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy)
		{
			object channelData = (objRef.ChannelInfo != null) ? objRef.ChannelInfo.ChannelData : null;
			string uri;
			IMessageSink clientChannelSinkChain = RemotingServices.GetClientChannelSinkChain(objRef.URI, channelData, out uri);
			if (uri == null)
			{
				uri = objRef.URI;
			}
			Hashtable obj = RemotingServices.uri_hash;
			ClientIdentity result;
			lock (obj)
			{
				clientProxy = null;
				string normalizedUri = RemotingServices.GetNormalizedUri(objRef.URI);
				ClientIdentity clientIdentity = RemotingServices.uri_hash[normalizedUri] as ClientIdentity;
				if (clientIdentity != null)
				{
					clientProxy = clientIdentity.ClientProxy;
					if (clientProxy != null)
					{
						return clientIdentity;
					}
					RemotingServices.DisposeIdentity(clientIdentity);
				}
				clientIdentity = new ClientIdentity(uri, objRef);
				clientIdentity.ChannelSink = clientChannelSinkChain;
				RemotingServices.uri_hash[normalizedUri] = clientIdentity;
				if (proxyType != null)
				{
					RemotingProxy remotingProxy = new RemotingProxy(proxyType, clientIdentity);
					CrossAppDomainSink crossAppDomainSink = clientChannelSinkChain as CrossAppDomainSink;
					if (crossAppDomainSink != null)
					{
						remotingProxy.SetTargetDomain(crossAppDomainSink.TargetDomainId);
					}
					clientProxy = remotingProxy.GetTransparentProxy();
					clientIdentity.ClientProxy = (MarshalByRefObject)clientProxy;
				}
				result = clientIdentity;
			}
			return result;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x000C5450 File Offset: 0x000C3650
		private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri)
		{
			IMessageSink messageSink = ChannelServices.CreateClientChannelSinkChain(url, channelData, out objectUri);
			if (messageSink != null)
			{
				return messageSink;
			}
			if (url != null)
			{
				throw new RemotingException(string.Format("Cannot create channel sink to connect to URL {0}. An appropriate channel has probably not been registered.", url));
			}
			throw new RemotingException(string.Format("Cannot create channel sink to connect to the remote object. An appropriate channel has probably not been registered.", url));
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x000C5482 File Offset: 0x000C3682
		internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			return new ClientActivatedIdentity(null, objectType)
			{
				ChannelSink = ChannelServices.CrossContextChannel
			};
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x000C5496 File Offset: 0x000C3696
		internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			ClientActivatedIdentity clientActivatedIdentity = new ClientActivatedIdentity(objectUri, objectType);
			clientActivatedIdentity.AttachServerObject(realObject, Context.DefaultContext);
			RemotingServices.RegisterServerIdentity(clientActivatedIdentity);
			clientActivatedIdentity.StartTrackingLifetime((ILease)realObject.InitializeLifetimeService());
			return clientActivatedIdentity;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x000C54C4 File Offset: 0x000C36C4
		internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			ServerIdentity serverIdentity;
			if (mode == WellKnownObjectMode.SingleCall)
			{
				serverIdentity = new SingleCallIdentity(objectUri, Context.DefaultContext, objectType);
			}
			else
			{
				serverIdentity = new SingletonIdentity(objectUri, Context.DefaultContext, objectType);
			}
			RemotingServices.RegisterServerIdentity(serverIdentity);
			return serverIdentity;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x000C54F8 File Offset: 0x000C36F8
		private static void RegisterServerIdentity(ServerIdentity identity)
		{
			Hashtable obj = RemotingServices.uri_hash;
			lock (obj)
			{
				if (RemotingServices.uri_hash.ContainsKey(identity.ObjectUri))
				{
					throw new RemotingException("Uri already in use: " + identity.ObjectUri + ".");
				}
				RemotingServices.uri_hash[identity.ObjectUri] = identity;
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x000C5570 File Offset: 0x000C3770
		internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			ClientActivatedIdentity clientActivatedIdentity = RemotingServices.GetIdentityForUri(objref.URI) as ClientActivatedIdentity;
			if (clientActivatedIdentity != null)
			{
				return clientActivatedIdentity.GetServerObject();
			}
			return RemotingServices.GetRemoteObject(objref, classToProxy);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x000C55A0 File Offset: 0x000C37A0
		internal static object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			object result;
			RemotingServices.GetOrCreateClientIdentity(objRef, proxyType, out result);
			return result;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x000C55B8 File Offset: 0x000C37B8
		internal static object GetServerObject(string uri)
		{
			ClientActivatedIdentity clientActivatedIdentity = RemotingServices.GetIdentityForUri(uri) as ClientActivatedIdentity;
			if (clientActivatedIdentity == null)
			{
				throw new RemotingException("Server for uri '" + uri + "' not found");
			}
			return clientActivatedIdentity.GetServerObject();
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x000C55E4 File Offset: 0x000C37E4
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		internal static byte[] SerializeCallData(object obj)
		{
			LogicalCallContext.Reader logicalCallContext = Thread.CurrentThread.GetExecutionContextReader().LogicalCallContext;
			if (!logicalCallContext.IsNull)
			{
				obj = new RemotingServices.CACD
				{
					d = obj,
					c = logicalCallContext.Clone()
				};
			}
			if (obj == null)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter serializationFormatter = RemotingServices._serializationFormatter;
			lock (serializationFormatter)
			{
				RemotingServices._serializationFormatter.Serialize(memoryStream, obj);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000C5674 File Offset: 0x000C3874
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		internal static object DeserializeCallData(byte[] array)
		{
			if (array == null)
			{
				return null;
			}
			MemoryStream serializationStream = new MemoryStream(array);
			BinaryFormatter deserializationFormatter = RemotingServices._deserializationFormatter;
			object obj;
			lock (deserializationFormatter)
			{
				obj = RemotingServices._deserializationFormatter.Deserialize(serializationStream);
			}
			if (obj is RemotingServices.CACD)
			{
				RemotingServices.CACD cacd = (RemotingServices.CACD)obj;
				obj = cacd.d;
				LogicalCallContext logicalCallContext = (LogicalCallContext)cacd.c;
				if (logicalCallContext.HasInfo)
				{
					Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.Merge(logicalCallContext);
				}
			}
			return obj;
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x000C5708 File Offset: 0x000C3908
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		internal static byte[] SerializeExceptionData(Exception ex)
		{
			byte[] result = null;
			try
			{
			}
			finally
			{
				MemoryStream memoryStream = new MemoryStream();
				BinaryFormatter serializationFormatter = RemotingServices._serializationFormatter;
				lock (serializationFormatter)
				{
					RemotingServices._serializationFormatter.Serialize(memoryStream, ex);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x000C576C File Offset: 0x000C396C
		internal static object GetDomainProxy(AppDomain domain)
		{
			byte[] array = null;
			Context currentContext = Thread.CurrentContext;
			try
			{
				array = (byte[])AppDomain.InvokeInDomain(domain, typeof(AppDomain).GetMethod("GetMarshalledDomainObjRef", BindingFlags.Instance | BindingFlags.NonPublic), domain, null);
			}
			finally
			{
				AppDomain.InternalSetContext(currentContext);
			}
			byte[] array2 = new byte[array.Length];
			array.CopyTo(array2, 0);
			return (AppDomain)RemotingServices.Unmarshal((ObjRef)CADSerializer.DeserializeObject(new MemoryStream(array2)));
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x000C57EC File Offset: 0x000C39EC
		private static void RegisterInternalChannels()
		{
			CrossAppDomainChannel.RegisterCrossAppDomainChannel();
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x000C57F4 File Offset: 0x000C39F4
		internal static void DisposeIdentity(Identity ident)
		{
			Hashtable obj = RemotingServices.uri_hash;
			lock (obj)
			{
				if (!ident.Disposed)
				{
					ClientIdentity clientIdentity = ident as ClientIdentity;
					if (clientIdentity != null)
					{
						RemotingServices.uri_hash.Remove(RemotingServices.GetNormalizedUri(clientIdentity.TargetUri));
					}
					else
					{
						RemotingServices.uri_hash.Remove(ident.ObjectUri);
					}
					ident.Disposed = true;
				}
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x000C5870 File Offset: 0x000C3A70
		internal static Identity GetMessageTargetIdentity(IMessage msg)
		{
			if (msg is IInternalMessage)
			{
				return ((IInternalMessage)msg).TargetIdentity;
			}
			Hashtable obj = RemotingServices.uri_hash;
			Identity result;
			lock (obj)
			{
				string normalizedUri = RemotingServices.GetNormalizedUri(((IMethodMessage)msg).Uri);
				result = (RemotingServices.uri_hash[normalizedUri] as ServerIdentity);
			}
			return result;
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x000C58E0 File Offset: 0x000C3AE0
		internal static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
			if (msg is IInternalMessage)
			{
				((IInternalMessage)msg).TargetIdentity = ident;
			}
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x000C58F8 File Offset: 0x000C3AF8
		internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote)
		{
			if (pi.ParameterType.IsArray && ((Array)local).Rank == 1)
			{
				Array array = (Array)local;
				if (array.Rank == 1)
				{
					Array.Copy((Array)remote, array, array.Length);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000C5945 File Offset: 0x000C3B45
		private static string GetNormalizedUri(string uri)
		{
			if (uri.StartsWith("/"))
			{
				return uri.Substring(1);
			}
			return uri;
		}

		// Token: 0x0400254E RID: 9550
		private static Hashtable uri_hash = new Hashtable();

		// Token: 0x0400254F RID: 9551
		private static BinaryFormatter _serializationFormatter;

		// Token: 0x04002550 RID: 9552
		private static BinaryFormatter _deserializationFormatter;

		// Token: 0x04002551 RID: 9553
		private static string app_id;

		// Token: 0x04002552 RID: 9554
		private static readonly object app_id_lock = new object();

		// Token: 0x04002553 RID: 9555
		private static int next_id = 1;

		// Token: 0x04002554 RID: 9556
		private const BindingFlags methodBindings = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x04002555 RID: 9557
		private static readonly MethodInfo FieldSetterMethod;

		// Token: 0x04002556 RID: 9558
		private static readonly MethodInfo FieldGetterMethod;

		// Token: 0x0200056C RID: 1388
		[Serializable]
		private class CACD
		{
			// Token: 0x04002557 RID: 9559
			public object d;

			// Token: 0x04002558 RID: 9560
			public object c;
		}
	}
}
