using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
	/// <summary>Предоставляет способ регистрации, отмены регистрации и получения списка дескрипторов отслеживания.</summary>
	// Token: 0x0200057D RID: 1405
	[ComVisible(true)]
	public class TrackingServices
	{
		/// <summary>Регистрирует новый дескриптор отслеживания с помощью <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />.</summary>
		/// <param name="handler">Регистрируемый дескриптор отслеживания.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="handler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Дескриптор, указанный в параметре <paramref name="handler" />, уже зарегистрирован с помощью <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />.</exception>
		// Token: 0x0600370F RID: 14095 RVA: 0x000C6A78 File Offset: 0x000C4C78
		public static void RegisterTrackingHandler(ITrackingHandler handler)
		{
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			object syncRoot = TrackingServices._handlers.SyncRoot;
			lock (syncRoot)
			{
				if (-1 != TrackingServices._handlers.IndexOf(handler))
				{
					throw new RemotingException("handler already registered");
				}
				TrackingServices._handlers.Add(handler);
			}
		}

		/// <summary>Отменяет регистрацию заданного дескриптора отслеживания из <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />.</summary>
		/// <param name="handler">Дескриптор, регистрация которого отменяется.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="handler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Дескриптор, указанный в параметре <paramref name="handler" />, не  зарегистрирован с помощью <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />.</exception>
		// Token: 0x06003710 RID: 14096 RVA: 0x000C6AEC File Offset: 0x000C4CEC
		public static void UnregisterTrackingHandler(ITrackingHandler handler)
		{
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			object syncRoot = TrackingServices._handlers.SyncRoot;
			lock (syncRoot)
			{
				int num = TrackingServices._handlers.IndexOf(handler);
				if (num == -1)
				{
					throw new RemotingException("handler is not registered");
				}
				TrackingServices._handlers.RemoveAt(num);
			}
		}

		/// <summary>Возвращает массив дескрипторов отслеживания, которые в настоящее время регистрируются с помощью <see cref="T:System.Runtime.Remoting.Services.TrackingServices" /> в текущем <see cref="T:System.AppDomain" />.</summary>
		/// <returns>Массив дескрипторов отслеживания, которые в настоящее время регистрируются с помощью <see cref="T:System.Runtime.Remoting.Services.TrackingServices" /> в текущем <see cref="T:System.AppDomain" />.</returns>
		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x000C6B60 File Offset: 0x000C4D60
		public static ITrackingHandler[] RegisteredHandlers
		{
			get
			{
				object syncRoot = TrackingServices._handlers.SyncRoot;
				ITrackingHandler[] result;
				lock (syncRoot)
				{
					if (TrackingServices._handlers.Count == 0)
					{
						result = new ITrackingHandler[0];
					}
					else
					{
						result = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
					}
				}
				return result;
			}
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x000C6BD0 File Offset: 0x000C4DD0
		internal static void NotifyMarshaledObject(object obj, ObjRef or)
		{
			object syncRoot = TrackingServices._handlers.SyncRoot;
			ITrackingHandler[] array;
			lock (syncRoot)
			{
				if (TrackingServices._handlers.Count == 0)
				{
					return;
				}
				array = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MarshaledObject(obj, or);
			}
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x000C6C50 File Offset: 0x000C4E50
		internal static void NotifyUnmarshaledObject(object obj, ObjRef or)
		{
			object syncRoot = TrackingServices._handlers.SyncRoot;
			ITrackingHandler[] array;
			lock (syncRoot)
			{
				if (TrackingServices._handlers.Count == 0)
				{
					return;
				}
				array = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].UnmarshaledObject(obj, or);
			}
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x000C6CD0 File Offset: 0x000C4ED0
		internal static void NotifyDisconnectedObject(object obj)
		{
			object syncRoot = TrackingServices._handlers.SyncRoot;
			ITrackingHandler[] array;
			lock (syncRoot)
			{
				if (TrackingServices._handlers.Count == 0)
				{
					return;
				}
				array = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DisconnectedObject(obj);
			}
		}

		// Token: 0x04002576 RID: 9590
		private static ArrayList _handlers = new ArrayList();
	}
}
