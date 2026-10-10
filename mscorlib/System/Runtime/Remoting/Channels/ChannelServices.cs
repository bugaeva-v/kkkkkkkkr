using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает статические методы для регистрации канала удаленного взаимодействия, разрешения и поиска URL-адреса. Этот класс не наследуется.</summary>
	// Token: 0x020005A8 RID: 1448
	[ComVisible(true)]
	public sealed class ChannelServices
	{
		// Token: 0x0600382E RID: 14382 RVA: 0x0000259F File Offset: 0x0000079F
		private ChannelServices()
		{
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x000C95F5 File Offset: 0x000C77F5
		internal static CrossContextChannel CrossContextChannel
		{
			get
			{
				return ChannelServices._crossContextSink;
			}
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x000C95FC File Offset: 0x000C77FC
		internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri)
		{
			object[] channelDataArray = (object[])remoteChannelData;
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj in ChannelServices.registeredChannels)
				{
					IChannelSender channelSender = ((IChannel)obj) as IChannelSender;
					if (channelSender != null)
					{
						IMessageSink messageSink = ChannelServices.CreateClientChannelSinkChain(channelSender, url, channelDataArray, out objectUri);
						if (messageSink != null)
						{
							return messageSink;
						}
					}
				}
				RemotingConfiguration.LoadDefaultDelayedChannels();
				foreach (object obj2 in ChannelServices.delayedClientChannels)
				{
					IChannelSender channelSender2 = (IChannelSender)obj2;
					IMessageSink messageSink2 = ChannelServices.CreateClientChannelSinkChain(channelSender2, url, channelDataArray, out objectUri);
					if (messageSink2 != null)
					{
						ChannelServices.delayedClientChannels.Remove(channelSender2);
						ChannelServices.RegisterChannel(channelSender2);
						return messageSink2;
					}
				}
			}
			objectUri = null;
			return null;
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x000C9720 File Offset: 0x000C7920
		internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri)
		{
			objectUri = null;
			if (channelDataArray == null)
			{
				return sender.CreateMessageSink(url, null, out objectUri);
			}
			foreach (object obj in channelDataArray)
			{
				IMessageSink messageSink;
				if (obj is IChannelDataStore)
				{
					messageSink = sender.CreateMessageSink(null, obj, out objectUri);
				}
				else
				{
					messageSink = sender.CreateMessageSink(url, obj, out objectUri);
				}
				if (messageSink != null)
				{
					return messageSink;
				}
			}
			return null;
		}

		/// <summary>Получает список зарегистрированных в настоящее время каналов.</summary>
		/// <returns>Массив всех зарегистрированных в настоящее время каналов.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x000C9778 File Offset: 0x000C7978
		public static IChannel[] RegisteredChannels
		{
			get
			{
				object syncRoot = ChannelServices.registeredChannels.SyncRoot;
				IChannel[] result;
				lock (syncRoot)
				{
					List<IChannel> list = new List<IChannel>();
					for (int i = 0; i < ChannelServices.registeredChannels.Count; i++)
					{
						IChannel channel = (IChannel)ChannelServices.registeredChannels[i];
						if (!(channel is CrossAppDomainChannel))
						{
							list.Add(channel);
						}
					}
					result = list.ToArray();
				}
				return result;
			}
		}

		/// <summary>Создает новую цепь приемников канала для указанного канала.</summary>
		/// <param name="provider">Первый поставщик в цепи поставщиков приемников, которые создают цепь приемников канала.</param>
		/// <param name="channel">Объект <see cref="T:System.Runtime.Remoting.Channels.IChannelReceiver" />, для которого создается цепочка приемников каналов.</param>
		/// <returns>Новая цепь приемников канала для указанного канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003833 RID: 14387 RVA: 0x000C9800 File Offset: 0x000C7A00
		public static IServerChannelSink CreateServerChannelSinkChain(IServerChannelSinkProvider provider, IChannelReceiver channel)
		{
			IServerChannelSinkProvider serverChannelSinkProvider = provider;
			while (serverChannelSinkProvider.Next != null)
			{
				serverChannelSinkProvider = serverChannelSinkProvider.Next;
			}
			serverChannelSinkProvider.Next = new ServerDispatchSinkProvider();
			return provider.CreateSink(channel);
		}

		/// <summary>Отправляет входящие удаленные вызовы.</summary>
		/// <param name="sinkStack">Стек приемников каналов сервера, пройденный сообщением.</param>
		/// <param name="msg">Отправляемое сообщение.</param>
		/// <param name="replyMsg">Когда этот метод возвращается, он содержит сообщение <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />, в котором находится ответ сервера на сообщение, содержащееся в параметре <paramref name="msg" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Класс <see cref="T:System.Runtime.Remoting.Channels.ServerProcessing" />, который задает статус обработки сообщения сервера.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="msg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003834 RID: 14388 RVA: 0x000C9832 File Offset: 0x000C7A32
		public static ServerProcessing DispatchMessage(IServerChannelSinkStack sinkStack, IMessage msg, out IMessage replyMsg)
		{
			if (msg == null)
			{
				throw new ArgumentNullException("msg");
			}
			replyMsg = ChannelServices.SyncDispatchMessage(msg);
			if (RemotingServices.IsOneWay(((IMethodMessage)msg).MethodBase))
			{
				return ServerProcessing.OneWay;
			}
			return ServerProcessing.Complete;
		}

		/// <summary>Возвращает зарегистрированный канал с указанным именем.</summary>
		/// <param name="name">Имя канала.</param>
		/// <returns>Интерфейс зарегистрированного канала или <see langword="null" />, если канал не зарегистрирован.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003835 RID: 14389 RVA: 0x000C9860 File Offset: 0x000C7A60
		public static IChannel GetChannel(string name)
		{
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			IChannel result;
			lock (syncRoot)
			{
				foreach (object obj in ChannelServices.registeredChannels)
				{
					IChannel channel = (IChannel)obj;
					if (channel.ChannelName == name && !(channel is CrossAppDomainChannel))
					{
						return channel;
					}
				}
				result = null;
			}
			return result;
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionary" /> свойств для заданного прокси.</summary>
		/// <param name="obj">Прокси, свойства которого необходимо извлечь.</param>
		/// <returns>Интерфейс словаря свойств или <see langword="null" />, если свойства не найдены.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение настраивать типы и каналы удаленного взаимодействия.</exception>
		// Token: 0x06003836 RID: 14390 RVA: 0x000C9904 File Offset: 0x000C7B04
		public static IDictionary GetChannelSinkProperties(object obj)
		{
			if (!RemotingServices.IsTransparentProxy(obj))
			{
				throw new ArgumentException("obj must be a proxy", "obj");
			}
			IMessageSink messageSink = ((ClientIdentity)RemotingServices.GetRealProxy(obj).ObjectIdentity).ChannelSink;
			List<IDictionary> list = new List<IDictionary>();
			while (messageSink != null && !(messageSink is IClientChannelSink))
			{
				messageSink = messageSink.NextSink;
			}
			if (messageSink == null)
			{
				return new Hashtable();
			}
			for (IClientChannelSink clientChannelSink = messageSink as IClientChannelSink; clientChannelSink != null; clientChannelSink = clientChannelSink.NextChannelSink)
			{
				list.Add(clientChannelSink.Properties);
			}
			return new AggregateDictionary(list.ToArray());
		}

		/// <summary>Возвращает массив всех URL-адресов, которые могут быть использованы для доступа к указанному объекту.</summary>
		/// <param name="obj">Объект, для которого извлекается массив URL-адресов.</param>
		/// <returns>Массив строк, содержащий URL-адреса, которые могут быть использованы для удаленного определения объекта, или <see langword="null" />, если ни один объект не найден.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003837 RID: 14391 RVA: 0x000C998C File Offset: 0x000C7B8C
		public static string[] GetUrlsForObject(MarshalByRefObject obj)
		{
			string objectUri = RemotingServices.GetObjectUri(obj);
			if (objectUri == null)
			{
				return new string[0];
			}
			List<string> list = new List<string>();
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj2 in ChannelServices.registeredChannels)
				{
					if (!(obj2 is CrossAppDomainChannel))
					{
						IChannelReceiver channelReceiver = obj2 as IChannelReceiver;
						if (channelReceiver != null)
						{
							list.AddRange(channelReceiver.GetUrlsForUri(objectUri));
						}
					}
				}
			}
			return list.ToArray();
		}

		/// <summary>Регистрирует канал со службами канала. <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel)" /> устарел. Взамен рекомендуется использовать <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel,System.Boolean)" />.</summary>
		/// <param name="chnl">Канал для регистрации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="chnl" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Канал уже зарегистрирован.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003838 RID: 14392 RVA: 0x000C9A4C File Offset: 0x000C7C4C
		[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
		public static void RegisterChannel(IChannel chnl)
		{
			ChannelServices.RegisterChannel(chnl, false);
		}

		/// <summary>Регистрирует канал со службами канала.</summary>
		/// <param name="chnl">Канал для регистрации.</param>
		/// <param name="ensureSecurity">Значение <see langword="true" /> обеспечивает активизацию безопасности; в противном случае значение равно <see langword="false" />. Если задать значение <see langword="false" />, параметры безопасности в канале TCP или IPC не будут изменены.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="chnl" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Канал уже зарегистрирован.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение настраивать типы и каналы удаленного взаимодействия.</exception>
		/// <exception cref="T:System.NotSupportedException">Не поддерживается в Windows 98 для <see cref="T:System.Runtime.Remoting.Channels.Tcp.TcpServerChannel" /> и на всех платформах для <see cref="T:System.Runtime.Remoting.Channels.Http.HttpServerChannel" />. Разместите службу, используя IIS, если необходим защищенный HTTP-канал.</exception>
		// Token: 0x06003839 RID: 14393 RVA: 0x000C9A58 File Offset: 0x000C7C58
		public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			if (chnl == null)
			{
				throw new ArgumentNullException("chnl");
			}
			if (ensureSecurity)
			{
				ISecurableChannel securableChannel = chnl as ISecurableChannel;
				if (securableChannel == null)
				{
					throw new RemotingException(string.Format("Channel {0} is not securable while ensureSecurity is specified as true", chnl.ChannelName));
				}
				securableChannel.IsSecured = true;
			}
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				int num = -1;
				for (int i = 0; i < ChannelServices.registeredChannels.Count; i++)
				{
					IChannel channel = (IChannel)ChannelServices.registeredChannels[i];
					if (channel.ChannelName == chnl.ChannelName && chnl.ChannelName != "")
					{
						throw new RemotingException("Channel " + channel.ChannelName + " already registered");
					}
					if (channel.ChannelPriority < chnl.ChannelPriority && num == -1)
					{
						num = i;
					}
				}
				if (num != -1)
				{
					ChannelServices.registeredChannels.Insert(num, chnl);
				}
				else
				{
					ChannelServices.registeredChannels.Add(chnl);
				}
				IChannelReceiver channelReceiver = chnl as IChannelReceiver;
				if (channelReceiver != null && ChannelServices.oldStartModeTypes.Contains(chnl.GetType().ToString()))
				{
					channelReceiver.StartListening(null);
				}
			}
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x000C9B98 File Offset: 0x000C7D98
		internal static void RegisterChannelConfig(ChannelData channel)
		{
			IServerChannelSinkProvider serverChannelSinkProvider = null;
			IClientChannelSinkProvider clientChannelSinkProvider = null;
			for (int i = channel.ServerProviders.Count - 1; i >= 0; i--)
			{
				IServerChannelSinkProvider serverChannelSinkProvider2 = (IServerChannelSinkProvider)ChannelServices.CreateProvider(channel.ServerProviders[i] as ProviderData);
				serverChannelSinkProvider2.Next = serverChannelSinkProvider;
				serverChannelSinkProvider = serverChannelSinkProvider2;
			}
			for (int j = channel.ClientProviders.Count - 1; j >= 0; j--)
			{
				IClientChannelSinkProvider clientChannelSinkProvider2 = (IClientChannelSinkProvider)ChannelServices.CreateProvider(channel.ClientProviders[j] as ProviderData);
				clientChannelSinkProvider2.Next = clientChannelSinkProvider;
				clientChannelSinkProvider = clientChannelSinkProvider2;
			}
			Type type = Type.GetType(channel.Type);
			if (type == null)
			{
				throw new RemotingException("Type '" + channel.Type + "' not found");
			}
			bool flag = typeof(IChannelSender).IsAssignableFrom(type);
			bool flag2 = typeof(IChannelReceiver).IsAssignableFrom(type);
			Type[] types;
			object[] parameters;
			if (flag && flag2)
			{
				types = new Type[]
				{
					typeof(IDictionary),
					typeof(IClientChannelSinkProvider),
					typeof(IServerChannelSinkProvider)
				};
				parameters = new object[]
				{
					channel.CustomProperties,
					clientChannelSinkProvider,
					serverChannelSinkProvider
				};
			}
			else if (flag)
			{
				types = new Type[]
				{
					typeof(IDictionary),
					typeof(IClientChannelSinkProvider)
				};
				parameters = new object[]
				{
					channel.CustomProperties,
					clientChannelSinkProvider
				};
			}
			else
			{
				if (!flag2)
				{
					Type type2 = type;
					throw new RemotingException(((type2 != null) ? type2.ToString() : null) + " is not a valid channel type");
				}
				types = new Type[]
				{
					typeof(IDictionary),
					typeof(IServerChannelSinkProvider)
				};
				parameters = new object[]
				{
					channel.CustomProperties,
					serverChannelSinkProvider
				};
			}
			ConstructorInfo constructor = type.GetConstructor(types);
			if (constructor == null)
			{
				Type type3 = type;
				throw new RemotingException(((type3 != null) ? type3.ToString() : null) + " does not have a valid constructor");
			}
			IChannel channel2;
			try
			{
				channel2 = (IChannel)constructor.Invoke(parameters);
			}
			catch (TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				if (channel.DelayLoadAsClientChannel == "true" && !(channel2 is IChannelReceiver))
				{
					ChannelServices.delayedClientChannels.Add(channel2);
				}
				else
				{
					ChannelServices.RegisterChannel(channel2);
				}
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x000C9E24 File Offset: 0x000C8024
		private static object CreateProvider(ProviderData prov)
		{
			Type type = Type.GetType(prov.Type);
			if (type == null)
			{
				throw new RemotingException("Type '" + prov.Type + "' not found");
			}
			object[] args = new object[]
			{
				prov.CustomProperties,
				prov.CustomData
			};
			object result;
			try
			{
				result = Activator.CreateInstance(type, args);
			}
			catch (Exception innerException)
			{
				if (innerException is TargetInvocationException)
				{
					innerException = ((TargetInvocationException)innerException).InnerException;
				}
				string str = "An instance of provider '";
				Type type2 = type;
				throw new RemotingException(str + ((type2 != null) ? type2.ToString() : null) + "' could not be created: " + innerException.Message);
			}
			return result;
		}

		/// <summary>Синхронно отправляет входящие сообщения в цепочки на стороне сервера на основе универсального кода ресурса (URI), внедренного в сообщение.</summary>
		/// <param name="msg">Отправляемое сообщение.</param>
		/// <returns>Ответное сообщение возвращается вызовом в цепь на стороне сервера.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="msg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600383C RID: 14396 RVA: 0x000C9ED4 File Offset: 0x000C80D4
		public static IMessage SyncDispatchMessage(IMessage msg)
		{
			IMessage message = ChannelServices.CheckIncomingMessage(msg);
			if (message != null)
			{
				return ChannelServices.CheckReturnMessage(msg, message);
			}
			message = ChannelServices._crossContextSink.SyncProcessMessage(msg);
			return ChannelServices.CheckReturnMessage(msg, message);
		}

		/// <summary>Асинхронно отправляет данное сообщение в цепочки на стороне сервера, основанные на внедренном в сообщение URI.</summary>
		/// <param name="msg">Отправляемое сообщение.</param>
		/// <param name="replySink">Приемник, который обрабатывает возвращаемое сообщение, если оно не <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" />, используемый для контроля сообщения, отправляемого асинхронно.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="msg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600383D RID: 14397 RVA: 0x000C9F08 File Offset: 0x000C8108
		public static IMessageCtrl AsyncDispatchMessage(IMessage msg, IMessageSink replySink)
		{
			IMessage message = ChannelServices.CheckIncomingMessage(msg);
			if (message != null)
			{
				replySink.SyncProcessMessage(ChannelServices.CheckReturnMessage(msg, message));
				return null;
			}
			if (RemotingConfiguration.CustomErrorsEnabled(ChannelServices.IsLocalCall(msg)))
			{
				replySink = new ExceptionFilterSink(msg, replySink);
			}
			return ChannelServices._crossContextSink.AsyncProcessMessage(msg, replySink);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x000C9F54 File Offset: 0x000C8154
		private static ReturnMessage CheckIncomingMessage(IMessage msg)
		{
			IMethodMessage methodMessage = (IMethodMessage)msg;
			ServerIdentity serverIdentity = RemotingServices.GetIdentityForUri(methodMessage.Uri) as ServerIdentity;
			if (serverIdentity == null)
			{
				return new ReturnMessage(new RemotingException("No receiver for uri " + methodMessage.Uri), (IMethodCallMessage)msg);
			}
			RemotingServices.SetMessageTargetIdentity(msg, serverIdentity);
			return null;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x000C9FA8 File Offset: 0x000C81A8
		internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
		{
			IMethodReturnMessage methodReturnMessage = retMsg as IMethodReturnMessage;
			if (methodReturnMessage != null && methodReturnMessage.Exception != null && RemotingConfiguration.CustomErrorsEnabled(ChannelServices.IsLocalCall(callMsg)))
			{
				retMsg = new MethodResponse(new Exception("Server encountered an internal error. For more information, turn off customErrors in the server's .config file."), (IMethodCallMessage)callMsg);
			}
			return retMsg;
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000040F7 File Offset: 0x000022F7
		private static bool IsLocalCall(IMessage callMsg)
		{
			return true;
		}

		/// <summary>Отменяет регистрацию указанного канала в списке зарегистрированных каналов.</summary>
		/// <param name="chnl">Канал, регистрация которого отменяется.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="chnl" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Канал не зарегистрирован.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003841 RID: 14401 RVA: 0x000C9FEC File Offset: 0x000C81EC
		public static void UnregisterChannel(IChannel chnl)
		{
			if (chnl == null)
			{
				throw new ArgumentNullException();
			}
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				for (int i = 0; i < ChannelServices.registeredChannels.Count; i++)
				{
					if (ChannelServices.registeredChannels[i] == chnl)
					{
						ChannelServices.registeredChannels.RemoveAt(i);
						IChannelReceiver channelReceiver = chnl as IChannelReceiver;
						if (channelReceiver != null)
						{
							channelReceiver.StopListening(null);
						}
						return;
					}
				}
				throw new RemotingException("Channel not registered");
			}
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x000CA080 File Offset: 0x000C8280
		internal static object[] GetCurrentChannelInfo()
		{
			List<object> list = new List<object>();
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj in ChannelServices.registeredChannels)
				{
					IChannelReceiver channelReceiver = obj as IChannelReceiver;
					if (channelReceiver != null)
					{
						object channelData = channelReceiver.ChannelData;
						if (channelData != null)
						{
							list.Add(channelData);
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x040025D1 RID: 9681
		private static ArrayList registeredChannels = new ArrayList();

		// Token: 0x040025D2 RID: 9682
		private static ArrayList delayedClientChannels = new ArrayList();

		// Token: 0x040025D3 RID: 9683
		private static CrossContextChannel _crossContextSink = new CrossContextChannel();

		// Token: 0x040025D4 RID: 9684
		internal static string CrossContextUrl = "__CrossContext";

		// Token: 0x040025D5 RID: 9685
		private static IList oldStartModeTypes = new string[]
		{
			"Novell.Zenworks.Zmd.Public.UnixServerChannel",
			"Novell.Zenworks.Zmd.Public.UnixChannel"
		};
	}
}
