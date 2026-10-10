using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Определяет среду для объектов, которые находятся внутри нее и для которых может быть реализована политика.</summary>
	// Token: 0x0200058B RID: 1419
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public class Context
	{
		// Token: 0x0600378A RID: 14218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterContext(Context ctx);

		// Token: 0x0600378B RID: 14219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReleaseContext(Context ctx);

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Contexts.Context" />.</summary>
		// Token: 0x0600378C RID: 14220 RVA: 0x000C8108 File Offset: 0x000C6308
		public Context()
		{
			this.domain_id = Thread.GetDomainID();
			this.context_id = Interlocked.Increment(ref Context.global_count);
			Context.RegisterContext(this);
		}

		/// <summary>Очищает вспомогательные объекты для контекстов не по умолчанию.</summary>
		// Token: 0x0600378D RID: 14221 RVA: 0x000C8134 File Offset: 0x000C6334
		~Context()
		{
			Context.ReleaseContext(this);
		}

		/// <summary>Возвращает контекст по умолчанию для текущего домена приложения.</summary>
		/// <returns>Контекст по умолчанию для пространства имен <see cref="T:System.AppDomain" />.</returns>
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x000C8160 File Offset: 0x000C6360
		public static Context DefaultContext
		{
			get
			{
				return AppDomain.InternalGetDefaultContext();
			}
		}

		/// <summary>Возвращает идентификатор текущего контекста.</summary>
		/// <returns>Идентификатор текущего контекста.</returns>
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x000C8167 File Offset: 0x000C6367
		public virtual int ContextID
		{
			get
			{
				return this.context_id;
			}
		}

		/// <summary>Возвращает массив текущих контекстных свойств.</summary>
		/// <returns>Массив текущих контекстных свойств. Если у контекста нет приписываемых свойств, то <see langword="null" />.</returns>
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x000C816F File Offset: 0x000C636F
		public virtual IContextProperty[] ContextProperties
		{
			get
			{
				if (this.context_properties == null)
				{
					return new IContextProperty[0];
				}
				return this.context_properties.ToArray();
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x000C818B File Offset: 0x000C638B
		internal bool IsDefaultContext
		{
			get
			{
				return this.context_id == 0;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x000C8196 File Offset: 0x000C6396
		internal bool NeedsContextSink
		{
			get
			{
				return this.context_id != 0 || (Context.global_dynamic_properties != null && Context.global_dynamic_properties.HasProperties) || (this.context_dynamic_properties != null && this.context_dynamic_properties.HasProperties);
			}
		}

		/// <summary>Регистрирует динамическое свойство, реализующее интерфейс <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" /> с помощью службы удаленного взаимодействия.</summary>
		/// <param name="prop">Регистрируемое динамическое свойство.</param>
		/// <param name="obj">Объект или прокси, для которого регистрируется свойство, заданное в параметре property.</param>
		/// <param name="ctx">Контекст, для которого регистрируется свойство, заданное в параметре property.</param>
		/// <returns>
		///   <see langword="true" />, если свойство было успешно зарегистрировано; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство, заданное параметром <paramref name="prop" />, или его имя имеют значение <see langword="null" />, либо свойство не является динамическим (не реализует интерфейс <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" />).</exception>
		/// <exception cref="T:System.ArgumentException">Указан и объект, и контекст (оба параметра <paramref name="obj" /> и <paramref name="ctx" /> не равны <see langword="null" />).</exception>
		// Token: 0x06003793 RID: 14227 RVA: 0x000C81CA File Offset: 0x000C63CA
		public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
		{
			return Context.GetDynamicPropertyCollection(obj, ctx).RegisterDynamicProperty(prop);
		}

		/// <summary>Отменяет регистрацию динамического свойства, реализующего интерфейс <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" />.</summary>
		/// <param name="name">Имя динамического свойства, регистрация которого отменяется.</param>
		/// <param name="obj">Объект или прокси, для которого регистрируется свойство, заданное в параметре property.</param>
		/// <param name="ctx">Контекст, для которого регистрируется свойство, заданное в параметре property.</param>
		/// <returns>
		///   <see langword="true" />, если объект был успешно снят с регистрации; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Указан и объект, и контекст (оба параметра <paramref name="obj" /> и <paramref name="ctx" /> не равны <see langword="null" />).</exception>
		// Token: 0x06003794 RID: 14228 RVA: 0x000C81D9 File Offset: 0x000C63D9
		public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
		{
			return Context.GetDynamicPropertyCollection(obj, ctx).UnregisterDynamicProperty(name);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000C81E8 File Offset: 0x000C63E8
		private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
		{
			if (ctx == null && obj != null)
			{
				if (RemotingServices.IsTransparentProxy(obj))
				{
					return RemotingServices.GetRealProxy(obj).ObjectIdentity.ClientDynamicProperties;
				}
				return obj.ObjectIdentity.ServerDynamicProperties;
			}
			else
			{
				if (ctx != null && obj == null)
				{
					if (ctx.context_dynamic_properties == null)
					{
						ctx.context_dynamic_properties = new DynamicPropertyCollection();
					}
					return ctx.context_dynamic_properties;
				}
				if (ctx == null && obj == null)
				{
					if (Context.global_dynamic_properties == null)
					{
						Context.global_dynamic_properties = new DynamicPropertyCollection();
					}
					return Context.global_dynamic_properties;
				}
				throw new ArgumentException("Either obj or ctx must be null");
			}
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x000C8267 File Offset: 0x000C6467
		internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (Context.global_dynamic_properties != null && Context.global_dynamic_properties.HasProperties)
			{
				Context.global_dynamic_properties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x000C828A File Offset: 0x000C648A
		internal static bool HasGlobalDynamicSinks
		{
			get
			{
				return Context.global_dynamic_properties != null && Context.global_dynamic_properties.HasProperties;
			}
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x000C829F File Offset: 0x000C649F
		internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (this.context_dynamic_properties != null && this.context_dynamic_properties.HasProperties)
			{
				this.context_dynamic_properties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x000C82C6 File Offset: 0x000C64C6
		internal bool HasDynamicSinks
		{
			get
			{
				return this.context_dynamic_properties != null && this.context_dynamic_properties.HasProperties;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x000C82DD File Offset: 0x000C64DD
		internal bool HasExitSinks
		{
			get
			{
				return !(this.GetClientContextSinkChain() is ClientContextTerminatorSink) || this.HasDynamicSinks || Context.HasGlobalDynamicSinks;
			}
		}

		/// <summary>Возвращает контекстное свойство, указанное именем.</summary>
		/// <param name="name">Имя свойства.</param>
		/// <returns>Указанное контекстное свойство.</returns>
		// Token: 0x0600379B RID: 14235 RVA: 0x000C82FC File Offset: 0x000C64FC
		public virtual IContextProperty GetProperty(string name)
		{
			if (this.context_properties == null)
			{
				return null;
			}
			foreach (IContextProperty contextProperty in this.context_properties)
			{
				if (contextProperty.Name == name)
				{
					return contextProperty;
				}
			}
			return null;
		}

		/// <summary>Устанавливает значение контекстного свойства, указанного именем.</summary>
		/// <param name="prop">Действительное контекстное свойство.</param>
		/// <exception cref="T:System.InvalidOperationException">Контекст является замороженным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства или имени свойства — <see langword="null" />.</exception>
		// Token: 0x0600379C RID: 14236 RVA: 0x000C8368 File Offset: 0x000C6568
		public virtual void SetProperty(IContextProperty prop)
		{
			if (prop == null)
			{
				throw new ArgumentNullException("IContextProperty");
			}
			if (this == Context.DefaultContext)
			{
				throw new InvalidOperationException("Can not add properties to default context");
			}
			if (this.context_properties == null)
			{
				this.context_properties = new List<IContextProperty>();
			}
			this.context_properties.Add(prop);
		}

		/// <summary>Замораживает контекст, делая невозможным добавление и удаление контекстных свойств из текущего контекста.</summary>
		/// <exception cref="T:System.InvalidOperationException">Контекст уже является замороженным.</exception>
		// Token: 0x0600379D RID: 14237 RVA: 0x000C83B8 File Offset: 0x000C65B8
		public virtual void Freeze()
		{
			if (this.context_properties != null)
			{
				foreach (IContextProperty contextProperty in this.context_properties)
				{
					contextProperty.Freeze(this);
				}
			}
		}

		/// <summary>Возвращает представление текущего контекста объектом класса <see cref="T:System.String" />.</summary>
		/// <returns>Представление текущего контекста объектом класса <see cref="T:System.String" />.</returns>
		// Token: 0x0600379E RID: 14238 RVA: 0x000C8414 File Offset: 0x000C6614
		public override string ToString()
		{
			return "ContextID: " + this.context_id.ToString();
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000C842C File Offset: 0x000C662C
		internal IMessageSink GetServerContextSinkChain()
		{
			if (this.server_context_sink_chain == null)
			{
				if (Context.default_server_context_sink == null)
				{
					Context.default_server_context_sink = new ServerContextTerminatorSink();
				}
				this.server_context_sink_chain = Context.default_server_context_sink;
				if (this.context_properties != null)
				{
					for (int i = this.context_properties.Count - 1; i >= 0; i--)
					{
						IContributeServerContextSink contributeServerContextSink = this.context_properties[i] as IContributeServerContextSink;
						if (contributeServerContextSink != null)
						{
							this.server_context_sink_chain = contributeServerContextSink.GetServerContextSink(this.server_context_sink_chain);
						}
					}
				}
			}
			return this.server_context_sink_chain;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x000C84AC File Offset: 0x000C66AC
		internal IMessageSink GetClientContextSinkChain()
		{
			if (this.client_context_sink_chain == null)
			{
				this.client_context_sink_chain = new ClientContextTerminatorSink(this);
				if (this.context_properties != null)
				{
					foreach (IContextProperty contextProperty in this.context_properties)
					{
						IContributeClientContextSink contributeClientContextSink = contextProperty as IContributeClientContextSink;
						if (contributeClientContextSink != null)
						{
							this.client_context_sink_chain = contributeClientContextSink.GetClientContextSink(this.client_context_sink_chain);
						}
					}
				}
			}
			return this.client_context_sink_chain;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000C8534 File Offset: 0x000C6734
		internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
		{
			IMessageSink messageSink = new StackBuilderSink(obj, forceInternalExecute);
			messageSink = new ServerObjectTerminatorSink(messageSink);
			messageSink = new LeaseSink(messageSink);
			if (this.context_properties != null)
			{
				for (int i = this.context_properties.Count - 1; i >= 0; i--)
				{
					IContributeObjectSink contributeObjectSink = this.context_properties[i] as IContributeObjectSink;
					if (contributeObjectSink != null)
					{
						messageSink = contributeObjectSink.GetObjectSink(obj, messageSink);
					}
				}
			}
			return messageSink;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000C8598 File Offset: 0x000C6798
		internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			IMessageSink messageSink = EnvoyTerminatorSink.Instance;
			if (this.context_properties != null)
			{
				foreach (IContextProperty contextProperty in this.context_properties)
				{
					IContributeEnvoySink contributeEnvoySink = contextProperty as IContributeEnvoySink;
					if (contributeEnvoySink != null)
					{
						messageSink = contributeEnvoySink.GetEnvoySink(serverObject, messageSink);
					}
				}
			}
			return messageSink;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x000C8604 File Offset: 0x000C6804
		internal static Context SwitchToContext(Context newContext)
		{
			return AppDomain.InternalSetContext(newContext);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x000C860C File Offset: 0x000C680C
		internal static Context CreateNewContext(IConstructionCallMessage msg)
		{
			Context context = new Context();
			foreach (object obj in msg.ContextProperties)
			{
				IContextProperty contextProperty = (IContextProperty)obj;
				if (context.GetProperty(contextProperty.Name) == null)
				{
					context.SetProperty(contextProperty);
				}
			}
			context.Freeze();
			using (IEnumerator enumerator = msg.ContextProperties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!((IContextProperty)enumerator.Current).IsNewContextOK(context))
					{
						throw new RemotingException("A context property did not approve the candidate context for activating the object");
					}
				}
			}
			return context;
		}

		/// <summary>Выполняет код в другом контексте.</summary>
		/// <param name="deleg">Делегат, используемый для запроса обратного вызова.</param>
		// Token: 0x060037A5 RID: 14245 RVA: 0x000C86D4 File Offset: 0x000C68D4
		public void DoCallBack(CrossContextDelegate deleg)
		{
			lock (this)
			{
				if (this.callback_object == null)
				{
					Context newContext = Context.SwitchToContext(this);
					this.callback_object = new ContextCallbackObject();
					Context.SwitchToContext(newContext);
				}
			}
			this.callback_object.DoCallBack(deleg);
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x000C8734 File Offset: 0x000C6934
		private LocalDataStore MyLocalStore
		{
			get
			{
				if (this._localDataStore == null)
				{
					LocalDataStoreMgr localDataStoreMgr = Context._localDataStoreMgr;
					lock (localDataStoreMgr)
					{
						if (this._localDataStore == null)
						{
							this._localDataStore = Context._localDataStoreMgr.CreateLocalDataStore();
						}
					}
				}
				return this._localDataStore.Store;
			}
		}

		/// <summary>Выделяет неименованную область данных.</summary>
		/// <returns>Локальная область данных.</returns>
		// Token: 0x060037A7 RID: 14247 RVA: 0x000C87A0 File Offset: 0x000C69A0
		public static LocalDataStoreSlot AllocateDataSlot()
		{
			return Context._localDataStoreMgr.AllocateDataSlot();
		}

		/// <summary>Выделяет именованную область данных.</summary>
		/// <param name="name">Требуемое имя области данных.</param>
		/// <returns>объект локальной области данных.</returns>
		// Token: 0x060037A8 RID: 14248 RVA: 0x000C87AC File Offset: 0x000C69AC
		public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			return Context._localDataStoreMgr.AllocateNamedDataSlot(name);
		}

		/// <summary>Освобождает именованную область данных во всех контекстах.</summary>
		/// <param name="name">Имя освобождаемой области данных.</param>
		// Token: 0x060037A9 RID: 14249 RVA: 0x000C87B9 File Offset: 0x000C69B9
		public static void FreeNamedDataSlot(string name)
		{
			Context._localDataStoreMgr.FreeNamedDataSlot(name);
		}

		/// <summary>Ищет именованную область данных.</summary>
		/// <param name="name">Имя области данных.</param>
		/// <returns>Локальная область данных.</returns>
		// Token: 0x060037AA RID: 14250 RVA: 0x000C87C6 File Offset: 0x000C69C6
		public static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			return Context._localDataStoreMgr.GetNamedDataSlot(name);
		}

		/// <summary>Получает значение из указанной области данных текущего контекста.</summary>
		/// <param name="slot">Область данных.</param>
		/// <returns>Данные, связанные с <paramref name="slot" />.</returns>
		// Token: 0x060037AB RID: 14251 RVA: 0x000C87D3 File Offset: 0x000C69D3
		public static object GetData(LocalDataStoreSlot slot)
		{
			return Thread.CurrentContext.MyLocalStore.GetData(slot);
		}

		/// <summary>Помещает данные в указанную область данных текущего контекста.</summary>
		/// <param name="slot">Область данных, куда должны быть добавлены данные.</param>
		/// <param name="data">Добавляемые данные.</param>
		// Token: 0x060037AC RID: 14252 RVA: 0x000C87E5 File Offset: 0x000C69E5
		public static void SetData(LocalDataStoreSlot slot, object data)
		{
			Thread.CurrentContext.MyLocalStore.SetData(slot, data);
		}

		// Token: 0x0400259F RID: 9631
		private int domain_id;

		// Token: 0x040025A0 RID: 9632
		private int context_id;

		// Token: 0x040025A1 RID: 9633
		private UIntPtr static_data;

		// Token: 0x040025A2 RID: 9634
		private UIntPtr data;

		// Token: 0x040025A3 RID: 9635
		[ContextStatic]
		private static object[] local_slots;

		// Token: 0x040025A4 RID: 9636
		private static IMessageSink default_server_context_sink;

		// Token: 0x040025A5 RID: 9637
		private IMessageSink server_context_sink_chain;

		// Token: 0x040025A6 RID: 9638
		private IMessageSink client_context_sink_chain;

		// Token: 0x040025A7 RID: 9639
		private List<IContextProperty> context_properties;

		// Token: 0x040025A8 RID: 9640
		private static int global_count;

		// Token: 0x040025A9 RID: 9641
		private volatile LocalDataStoreHolder _localDataStore;

		// Token: 0x040025AA RID: 9642
		private static LocalDataStoreMgr _localDataStoreMgr = new LocalDataStoreMgr();

		// Token: 0x040025AB RID: 9643
		private static DynamicPropertyCollection global_dynamic_properties;

		// Token: 0x040025AC RID: 9644
		private DynamicPropertyCollection context_dynamic_properties;

		// Token: 0x040025AD RID: 9645
		private ContextCallbackObject callback_object;
	}
}
