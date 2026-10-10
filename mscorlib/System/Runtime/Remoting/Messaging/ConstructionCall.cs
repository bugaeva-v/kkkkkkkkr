using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> для создания сообщения запроса, представляющего собой вызов конструктора удаленного объекта.</summary>
	// Token: 0x02000613 RID: 1555
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.ConstructionCall" />, копируя существующее сообщение.</summary>
		/// <param name="m">Сообщение удаленного взаимодействия.</param>
		// Token: 0x06003AB9 RID: 15033 RVA: 0x000CDEC7 File Offset: 0x000CC0C7
		public ConstructionCall(IMessage m) : base(m)
		{
			this._activationTypeName = base.TypeName;
			this._isContextOk = true;
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x000CDEE3 File Offset: 0x000CC0E3
		internal ConstructionCall(Type type)
		{
			this._activationType = type;
			this._activationTypeName = type.AssemblyQualifiedName;
			this._isContextOk = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.ConstructionCall" /> из массива заголовков удаленного взаимодействия.</summary>
		/// <param name="headers">Массив заголовков удаленного взаимодействия, содержащих пары "ключ-значение". Этот массив используется для инициализации полей <see cref="T:System.Runtime.Remoting.Messaging.ConstructionCall" /> для заголовков, принадлежащих пространству имен "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
		// Token: 0x06003ABB RID: 15035 RVA: 0x000CDF05 File Offset: 0x000CC105
		public ConstructionCall(Header[] headers) : base(headers)
		{
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000CDF0E File Offset: 0x000CC10E
		internal ConstructionCall(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000CDF18 File Offset: 0x000CC118
		internal override void InitDictionary()
		{
			ConstructionCallDictionary constructionCallDictionary = new ConstructionCallDictionary(this);
			this.ExternalProperties = constructionCallDictionary;
			this.InternalProperties = constructionCallDictionary.GetInternalProperties();
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x000CDF3F File Offset: 0x000CC13F
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x000CDF47 File Offset: 0x000CC147
		internal bool IsContextOk
		{
			get
			{
				return this._isContextOk;
			}
			set
			{
				this._isContextOk = value;
			}
		}

		/// <summary>Возвращает тип удаленного объекта, подлежащего активации.</summary>
		/// <returns>Тип <see cref="T:System.Type" /> удаленного объекта, подлежащего активации.</returns>
		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x000CDF50 File Offset: 0x000CC150
		public Type ActivationType
		{
			[SecurityCritical]
			get
			{
				if (this._activationType == null)
				{
					this._activationType = Type.GetType(this._activationTypeName);
				}
				return this._activationType;
			}
		}

		/// <summary>Возвращает полное имя типа удаленного объекта, подлежащего активации.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее полное имя типа удаленного объекта, подлежащего активации.</returns>
		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x000CDF77 File Offset: 0x000CC177
		public string ActivationTypeName
		{
			[SecurityCritical]
			get
			{
				return this._activationTypeName;
			}
		}

		/// <summary>Получает или задает активатор, который активирует удаленные объекты.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Activation.IActivator" />, который активирует удаленный объект.</returns>
		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x000CDF7F File Offset: 0x000CC17F
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x000CDF87 File Offset: 0x000CC187
		public IActivator Activator
		{
			[SecurityCritical]
			get
			{
				return this._activator;
			}
			[SecurityCritical]
			set
			{
				this._activator = value;
			}
		}

		/// <summary>Возвращает атрибуты активации узла вызова для удаленного объекта.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, содержащий атрибуты активации узла вызова для удаленного объекта.</returns>
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x000CDF90 File Offset: 0x000CC190
		public object[] CallSiteActivationAttributes
		{
			[SecurityCritical]
			get
			{
				return this._activationAttributes;
			}
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x000CDF98 File Offset: 0x000CC198
		internal void SetActivationAttributes(object[] attributes)
		{
			this._activationAttributes = attributes;
		}

		/// <summary>Возвращает список свойств, определяющих контекст, в котором создается удаленный объект.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IList" />, содержащий список свойств, определяющих контекст, в котором создается удаленный объект.</returns>
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x000CDFA1 File Offset: 0x000CC1A1
		public IList ContextProperties
		{
			[SecurityCritical]
			get
			{
				if (this._contextProperties == null)
				{
					this._contextProperties = new ArrayList();
				}
				return this._contextProperties;
			}
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x000CDFBC File Offset: 0x000CC1BC
		internal override void InitMethodProperty(string key, object value)
		{
			if (key == "__Activator")
			{
				this._activator = (IActivator)value;
				return;
			}
			if (key == "__CallSiteActivationAttributes")
			{
				this._activationAttributes = (object[])value;
				return;
			}
			if (key == "__ActivationType")
			{
				this._activationType = (Type)value;
				return;
			}
			if (key == "__ContextProperties")
			{
				this._contextProperties = (IList)value;
				return;
			}
			if (!(key == "__ActivationTypeName"))
			{
				base.InitMethodProperty(key, value);
				return;
			}
			this._activationTypeName = (string)value;
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x000CE058 File Offset: 0x000CC258
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			IList list = this._contextProperties;
			if (list != null && list.Count == 0)
			{
				list = null;
			}
			info.AddValue("__Activator", this._activator);
			info.AddValue("__CallSiteActivationAttributes", this._activationAttributes);
			info.AddValue("__ActivationType", null);
			info.AddValue("__ContextProperties", list);
			info.AddValue("__ActivationTypeName", this._activationTypeName);
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</returns>
		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x000CE0CC File Offset: 0x000CC2CC
		public override IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				return base.Properties;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x000CE0D4 File Offset: 0x000CC2D4
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x000CE0DC File Offset: 0x000CC2DC
		internal RemotingProxy SourceProxy
		{
			get
			{
				return this._sourceProxy;
			}
			set
			{
				this._sourceProxy = value;
			}
		}

		// Token: 0x04002684 RID: 9860
		private IActivator _activator;

		// Token: 0x04002685 RID: 9861
		private object[] _activationAttributes;

		// Token: 0x04002686 RID: 9862
		private IList _contextProperties;

		// Token: 0x04002687 RID: 9863
		private Type _activationType;

		// Token: 0x04002688 RID: 9864
		private string _activationTypeName;

		// Token: 0x04002689 RID: 9865
		private bool _isContextOk;

		// Token: 0x0400268A RID: 9866
		[NonSerialized]
		private RemotingProxy _sourceProxy;
	}
}
