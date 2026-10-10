using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Runtime.Remoting.Proxies
{
	/// <summary>Предоставляет основные функциональные возможности для прокси.</summary>
	// Token: 0x02000580 RID: 1408
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class RealProxy
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> со значениями по умолчанию.</summary>
		// Token: 0x06003722 RID: 14114 RVA: 0x000C6F73 File Offset: 0x000C5173
		protected RealProxy()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />, который представляет удаленный объект заданного <see cref="T:System.Type" />.</summary>
		/// <param name="classToProxy">
		///   <see cref="T:System.Type" /> удаленного объекта, для которого создается прокси.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="classToProxy" /> не является интерфейсом и не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		// Token: 0x06003723 RID: 14115 RVA: 0x000C6F82 File Offset: 0x000C5182
		protected RealProxy(Type classToProxy) : this(classToProxy, IntPtr.Zero, null)
		{
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x000C6F91 File Offset: 0x000C5191
		internal RealProxy(Type classToProxy, ClientIdentity identity) : this(classToProxy, IntPtr.Zero, null)
		{
			this._objectIdentity = identity;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />.</summary>
		/// <param name="classToProxy">
		///   <see cref="T:System.Type" /> удаленного объекта, для которого создается прокси.</param>
		/// <param name="stub">Заглушка для связи с новым экземпляром прокси.</param>
		/// <param name="stubData">Данные заглушки для установки заданной заглушки и нового экземпляра прокси.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="classToProxy" /> не является интерфейсом и не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		// Token: 0x06003725 RID: 14117 RVA: 0x000C6FA8 File Offset: 0x000C51A8
		protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
		{
			if (!classToProxy.IsMarshalByRef && !classToProxy.IsInterface)
			{
				throw new ArgumentException("object must be MarshalByRef");
			}
			this.class_to_proxy = classToProxy;
			if (stub != IntPtr.Zero)
			{
				throw new NotSupportedException("stub is not used in Mono");
			}
		}

		// Token: 0x06003726 RID: 14118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type InternalGetProxyType(object transparentProxy);

		/// <summary>Возвращает <see cref="T:System.Type" /> объекта, представляемого текущим экземпляром <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />.</summary>
		/// <returns>
		///   <see cref="T:System.Type" /> объекта, представляемого текущим экземпляром <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />.</returns>
		// Token: 0x06003727 RID: 14119 RVA: 0x000C6FFC File Offset: 0x000C51FC
		public Type GetProxiedType()
		{
			if (this._objTP != null)
			{
				return RealProxy.InternalGetProxyType(this._objTP);
			}
			if (this.class_to_proxy.IsInterface)
			{
				return typeof(MarshalByRefObject);
			}
			return this.class_to_proxy;
		}

		/// <summary>Создает <see cref="T:System.Runtime.Remoting.ObjRef" /> для заданного типа объекта и регистрирует его с инфраструктурой удаленного взаимодействия в качестве объекта, вызываемого на стороне клиента.</summary>
		/// <param name="requestedType">Тип объекта, для которого создается <see cref="T:System.Runtime.Remoting.ObjRef" />.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Runtime.Remoting.ObjRef" />, создаваемый для указанного типа.</returns>
		// Token: 0x06003728 RID: 14120 RVA: 0x000C7030 File Offset: 0x000C5230
		public virtual ObjRef CreateObjRef(Type requestedType)
		{
			return RemotingServices.Marshal((MarshalByRefObject)this.GetTransparentProxy(), null, requestedType);
		}

		/// <summary>Добавляет прозрачный прокси объекта, представленного текущим экземпляром <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> для заданного <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="info">
		///   <see cref="T:System.Runtime.Serialization.SerializationInfo" />, в который сериализуется прозрачный прокси.</param>
		/// <param name="context">Новые источник и приемник сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="info" /> или параметра <paramref name="context" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий не имеет разрешения SerializationFormatter.</exception>
		// Token: 0x06003729 RID: 14121 RVA: 0x000C7044 File Offset: 0x000C5244
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			RemotingServices.GetObjectData(this.GetTransparentProxy(), info, context);
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x000C7053 File Offset: 0x000C5253
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x000C705B File Offset: 0x000C525B
		internal Identity ObjectIdentity
		{
			get
			{
				return this._objectIdentity;
			}
			set
			{
				this._objectIdentity = value;
			}
		}

		/// <summary>Запрашивает неуправляемую ссылку на объект, представленный текущим экземпляром прокси.</summary>
		/// <param name="fIsMarshalled">Значение <see langword="true" />, если ссылка на объект запрашивается для маршалинга в удаленное расположение. Значение <see langword="false" />, если ссылка на объект запрашивается для связи с неуправляемыми объектами в текущем процессе через COM.</param>
		/// <returns>Указатель на вызываемую оболочку COM, если ссылка на объект запрашивается для связи с неуправляемыми объектами в текущем процессе через COM, или указатель на кэшированный или новый COM-интерфейс <see langword="IUnknown" />, если ссылка на объект запрашивается для маршалинга в удаленное расположение.</returns>
		// Token: 0x0600372C RID: 14124 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual IntPtr GetCOMIUnknown(bool fIsMarshalled)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сохраняет неуправляемый прокси объекта, представленный текущим экземпляром.</summary>
		/// <param name="i">Указатель на интерфейс <see langword="IUnknown" /> для объекта, представленного текущим экземпляром прокси.</param>
		// Token: 0x0600372D RID: 14125 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual void SetCOMIUnknown(IntPtr i)
		{
			throw new NotImplementedException();
		}

		/// <summary>Запрашивает COM-интерфейс с заданным ID.</summary>
		/// <param name="iid">Ссылка на запрашиваемый интерфейс.</param>
		/// <returns>Указатель на запрашиваемый интерфейс.</returns>
		// Token: 0x0600372E RID: 14126 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual IntPtr SupportsInterface(ref Guid iid)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает данные заглушки, сохраненные для заданного прокси.</summary>
		/// <param name="rp">Прокси, для которого запрашиваются данные заглушки.</param>
		/// <returns>Данные заглушки для заданного прокси.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x0600372F RID: 14127 RVA: 0x000C7064 File Offset: 0x000C5264
		public static object GetStubData(RealProxy rp)
		{
			return rp._stubData;
		}

		/// <summary>Устанавливает данные заглушки для заданного прокси.</summary>
		/// <param name="rp">Прокси, для которого устанавливаются данные заглушки.</param>
		/// <param name="stubData">Новые данные заглушки.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x06003730 RID: 14128 RVA: 0x000C706C File Offset: 0x000C526C
		public static void SetStubData(RealProxy rp, object stubData)
		{
			rp._stubData = stubData;
		}

		/// <summary>При переопределении в производном классе вызывает метод, заданный в предоставленном <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> на удаленный объект, представленный текущим экземпляром.</summary>
		/// <param name="msg">
		///   <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />, содержащий <see cref="T:System.Collections.IDictionary" /> с информацией о вызове метода.</param>
		/// <returns>Сообщение, возвращенное вызванным методом, содержащее возвращаемое значение и любой из параметров <see langword="out" /> или <see langword="ref" />.</returns>
		// Token: 0x06003731 RID: 14129
		public abstract IMessage Invoke(IMessage msg);

		// Token: 0x06003732 RID: 14130 RVA: 0x000C7078 File Offset: 0x000C5278
		internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args)
		{
			MonoMethodMessage monoMethodMessage = (MonoMethodMessage)msg;
			monoMethodMessage.LogicalCallContext = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
			CallType callType = monoMethodMessage.CallType;
			bool flag = rp is RemotingProxy;
			out_args = null;
			IMethodReturnMessage methodReturnMessage = null;
			if (callType == CallType.BeginInvoke)
			{
				monoMethodMessage.AsyncResult.CallMessage = monoMethodMessage;
			}
			if (callType == CallType.EndInvoke)
			{
				methodReturnMessage = (IMethodReturnMessage)monoMethodMessage.AsyncResult.EndInvoke();
			}
			if (monoMethodMessage.MethodBase.IsConstructor)
			{
				if (flag)
				{
					methodReturnMessage = (IMethodReturnMessage)(rp as RemotingProxy).ActivateRemoteObject((IMethodMessage)msg);
				}
				else
				{
					msg = new ConstructionCall(rp.GetProxiedType());
				}
			}
			if (methodReturnMessage == null)
			{
				bool flag2 = false;
				try
				{
					methodReturnMessage = (IMethodReturnMessage)rp.Invoke(msg);
				}
				catch (Exception e)
				{
					flag2 = true;
					if (callType != CallType.BeginInvoke)
					{
						throw;
					}
					monoMethodMessage.AsyncResult.SyncProcessMessage(new ReturnMessage(e, msg as IMethodCallMessage));
					methodReturnMessage = new ReturnMessage(null, null, 0, null, msg as IMethodCallMessage);
				}
				if (!flag && callType == CallType.BeginInvoke && !flag2)
				{
					object ret = monoMethodMessage.AsyncResult.SyncProcessMessage(methodReturnMessage);
					out_args = methodReturnMessage.OutArgs;
					methodReturnMessage = new ReturnMessage(ret, null, 0, null, methodReturnMessage as IMethodCallMessage);
				}
			}
			if (methodReturnMessage.LogicalCallContext != null && methodReturnMessage.LogicalCallContext.HasInfo)
			{
				Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.Merge(methodReturnMessage.LogicalCallContext);
			}
			exc = methodReturnMessage.Exception;
			if (exc != null)
			{
				out_args = null;
				throw exc.FixRemotingException();
			}
			if (methodReturnMessage is IConstructionReturnMessage)
			{
				if (out_args == null)
				{
					out_args = methodReturnMessage.OutArgs;
				}
			}
			else if (monoMethodMessage.CallType != CallType.BeginInvoke)
			{
				if (monoMethodMessage.CallType == CallType.Sync)
				{
					out_args = RealProxy.ProcessResponse(methodReturnMessage, monoMethodMessage);
				}
				else if (monoMethodMessage.CallType == CallType.EndInvoke)
				{
					out_args = RealProxy.ProcessResponse(methodReturnMessage, monoMethodMessage.AsyncResult.CallMessage);
				}
				else if (out_args == null)
				{
					out_args = methodReturnMessage.OutArgs;
				}
			}
			return methodReturnMessage.ReturnValue;
		}

		// Token: 0x06003733 RID: 14131
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal virtual extern object InternalGetTransparentProxy(string className);

		/// <summary>Возвращает прозрачный прокси для текущего экземпляра <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />.</summary>
		/// <returns>Прозрачный прокси для текущего экземпляра прокси.</returns>
		// Token: 0x06003734 RID: 14132 RVA: 0x000C7248 File Offset: 0x000C5448
		public virtual object GetTransparentProxy()
		{
			if (this._objTP == null)
			{
				IRemotingTypeInfo remotingTypeInfo = this as IRemotingTypeInfo;
				string text;
				if (remotingTypeInfo != null)
				{
					text = remotingTypeInfo.TypeName;
					if (text == null || text == typeof(MarshalByRefObject).AssemblyQualifiedName)
					{
						text = this.class_to_proxy.AssemblyQualifiedName;
					}
				}
				else
				{
					text = this.class_to_proxy.AssemblyQualifiedName;
				}
				this._objTP = this.InternalGetTransparentProxy(text);
			}
			return this._objTP;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Type" /> удаленного объекта, представляемого текущим экземпляром <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> с заданным <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary>
		/// <param name="ctorMsg">Сообщение о вызове конструирования, содержащее параметры конструктора для нового экземпляра удаленного объекта, представленного текущим <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />. Может иметь значение <see langword="null" />.</param>
		/// <returns>Результат запроса конструирования.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x06003735 RID: 14133 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		[ComVisible(true)]
		public IConstructionReturnMessage InitializeServerObject(IConstructionCallMessage ctorMsg)
		{
			throw new NotImplementedException();
		}

		/// <summary>Присоединяет текущий экземпляр прокси к заданному удаленному <see cref="T:System.MarshalByRefObject" />.</summary>
		/// <param name="s">
		///   <see cref="T:System.MarshalByRefObject" />, который представляется текущим экземпляром прокси.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x06003736 RID: 14134 RVA: 0x000C72B5 File Offset: 0x000C54B5
		protected void AttachServer(MarshalByRefObject s)
		{
			this._server = s;
		}

		/// <summary>Отделяет текущий экземпляр прокси от удаленного серверного объекта, который он представляет.</summary>
		/// <returns>Обособленный серверный объект.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x06003737 RID: 14135 RVA: 0x000C72BE File Offset: 0x000C54BE
		protected MarshalByRefObject DetachServer()
		{
			MarshalByRefObject server = this._server;
			this._server = null;
			return server;
		}

		/// <summary>Возвращает серверный объект, представленный текущим экземпляром прокси.</summary>
		/// <returns>Серверный объект, представленный текущим экземпляром прокси.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x06003738 RID: 14136 RVA: 0x000C72CD File Offset: 0x000C54CD
		protected MarshalByRefObject GetUnwrappedServer()
		{
			return this._server;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x000C72D5 File Offset: 0x000C54D5
		internal void SetTargetDomain(int domainId)
		{
			this._targetDomainId = domainId;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x000C72E0 File Offset: 0x000C54E0
		internal object GetAppDomainTarget()
		{
			if (this._server == null)
			{
				ClientActivatedIdentity clientActivatedIdentity = RemotingServices.GetIdentityForUri(this._targetUri) as ClientActivatedIdentity;
				if (clientActivatedIdentity == null)
				{
					throw new RemotingException("Server for uri '" + this._targetUri + "' not found");
				}
				this._server = clientActivatedIdentity.GetServerObject();
			}
			return this._server;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x000C7338 File Offset: 0x000C5538
		private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
		{
			MethodInfo methodInfo = (MethodInfo)call.MethodBase;
			if (mrm.ReturnValue != null && !methodInfo.ReturnType.IsInstanceOfType(mrm.ReturnValue))
			{
				throw new InvalidCastException("Return value has an invalid type");
			}
			int num;
			if (call.NeedsOutProcessing(out num))
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				object[] array = new object[num];
				int num2 = 0;
				foreach (ParameterInfo parameterInfo in parameters)
				{
					if (parameterInfo.IsOut && !parameterInfo.ParameterType.IsByRef)
					{
						object obj = (parameterInfo.Position < mrm.ArgCount) ? mrm.GetArg(parameterInfo.Position) : null;
						if (obj != null)
						{
							object arg = call.GetArg(parameterInfo.Position);
							if (arg == null)
							{
								throw new RemotingException("Unexpected null value in local out parameter '" + parameterInfo.Name + "'");
							}
							RemotingServices.UpdateOutArgObject(parameterInfo, arg, obj);
						}
					}
					else if (parameterInfo.ParameterType.IsByRef)
					{
						object obj2 = (parameterInfo.Position < mrm.ArgCount) ? mrm.GetArg(parameterInfo.Position) : null;
						if (obj2 != null && !parameterInfo.ParameterType.GetElementType().IsInstanceOfType(obj2))
						{
							throw new InvalidCastException("Return argument '" + parameterInfo.Name + "' has an invalid type");
						}
						array[num2++] = obj2;
					}
				}
				return array;
			}
			return new object[0];
		}

		// Token: 0x0400257A RID: 9594
		private Type class_to_proxy;

		// Token: 0x0400257B RID: 9595
		internal Context _targetContext;

		// Token: 0x0400257C RID: 9596
		internal MarshalByRefObject _server;

		// Token: 0x0400257D RID: 9597
		private int _targetDomainId = -1;

		// Token: 0x0400257E RID: 9598
		internal string _targetUri;

		// Token: 0x0400257F RID: 9599
		internal Identity _objectIdentity;

		// Token: 0x04002580 RID: 9600
		private object _objTP;

		// Token: 0x04002581 RID: 9601
		private object _stubData;
	}
}
