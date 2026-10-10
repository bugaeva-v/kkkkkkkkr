using System;
using System.ComponentModel;

namespace System.Configuration
{
	/// <summary>Предоставляет базовый класс, используемый для поддержки параметров свойств пользователя.</summary>
	// Token: 0x020001C3 RID: 451
	public abstract class SettingsBase
	{
		/// <summary>Инициализирует внутренние свойства, используемые объектом <see cref="T:System.Configuration.SettingsBase" />.</summary>
		/// <param name="context">Контекст параметров, относящийся к свойствам параметров.</param>
		/// <param name="properties">Свойства параметров, которые будут доступны из экземпляра <see cref="T:System.Configuration.SettingsBase" />.</param>
		/// <param name="providers">Инициализированные поставщики, которые должны использоваться при загрузке и сохранении значений свойств.</param>
		// Token: 0x06000BDB RID: 3035 RVA: 0x00031A5D File Offset: 0x0002FC5D
		public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers)
		{
			this.context = context;
			this.properties = properties;
			this.providers = providers;
		}

		/// <summary>Сохраняет текущие значения свойств параметров.</summary>
		// Token: 0x06000BDC RID: 3036 RVA: 0x00031A74 File Offset: 0x0002FC74
		public virtual void Save()
		{
			if (this.sync)
			{
				lock (this)
				{
					this.SaveCore();
					return;
				}
			}
			this.SaveCore();
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00031AC0 File Offset: 0x0002FCC0
		private void SaveCore()
		{
			foreach (object obj in this.Providers)
			{
				SettingsProvider settingsProvider = (SettingsProvider)obj;
				SettingsPropertyValueCollection settingsPropertyValueCollection = new SettingsPropertyValueCollection();
				foreach (object obj2 in this.PropertyValues)
				{
					SettingsPropertyValue settingsPropertyValue = (SettingsPropertyValue)obj2;
					if (settingsPropertyValue.Property.Provider == settingsProvider)
					{
						settingsPropertyValueCollection.Add(settingsPropertyValue);
					}
				}
				if (settingsPropertyValueCollection.Count > 0)
				{
					settingsProvider.SetPropertyValues(this.Context, settingsPropertyValueCollection);
				}
			}
		}

		/// <summary>Предоставляет класс <see cref="T:System.Configuration.SettingsBase" />, являющийся синхронизированным (потокобезопасным).</summary>
		/// <param name="settingsBase">Класс, используемый для поддержки параметров свойств пользователя.</param>
		/// <returns>Синхронизированный класс <see cref="T:System.Configuration.SettingsBase" />.</returns>
		// Token: 0x06000BDE RID: 3038 RVA: 0x00031B90 File Offset: 0x0002FD90
		public static SettingsBase Synchronized(SettingsBase settingsBase)
		{
			settingsBase.sync = true;
			return settingsBase;
		}

		/// <summary>Возвращает связанный контекст параметров.</summary>
		/// <returns>
		///   <see cref="T:System.Configuration.SettingsContext" /> связан с экземпляром параметров.</returns>
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00031B9A File Offset: 0x0002FD9A
		public virtual SettingsContext Context
		{
			get
			{
				return this.context;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, является ли доступ к объекту синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции <see cref="T:System.Configuration.SettingsBase" /> является синхронизированным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00031BA2 File Offset: 0x0002FDA2
		[Browsable(false)]
		public bool IsSynchronized
		{
			get
			{
				return this.sync;
			}
		}

		/// <summary>Возвращает или задает значение определенного свойства параметров.</summary>
		/// <param name="propertyName">
		///   <see cref="T:System.String" />, содержащий имя свойства для доступа.</param>
		/// <returns>Если найдено, значение именованного свойства параметров.</returns>
		/// <exception cref="T:System.Configuration.SettingsPropertyNotFoundException">Нет свойств, связанных с текущим объектом, или указанное свойство не может быть найдено.</exception>
		/// <exception cref="T:System.Configuration.SettingsPropertyIsReadOnlyException">Предпринята попытка задать свойство, доступное только для чтения.</exception>
		/// <exception cref="T:System.Configuration.SettingsPropertyWrongTypeException">Предоставленное значение имеет несовместимый со свойством параметров тип значения во время операции установки.</exception>
		// Token: 0x170001FB RID: 507
		public virtual object this[string propertyName]
		{
			get
			{
				if (this.sync)
				{
					lock (this)
					{
						return this.GetPropertyValue(propertyName);
					}
				}
				return this.GetPropertyValue(propertyName);
			}
			set
			{
				if (this.sync)
				{
					lock (this)
					{
						this.SetPropertyValue(propertyName, value);
						return;
					}
				}
				this.SetPropertyValue(propertyName, value);
			}
		}

		/// <summary>Возвращает коллекцию свойств параметров.</summary>
		/// <returns>Коллекция <see cref="T:System.Configuration.SettingsPropertyCollection" />, содержащая все объекты <see cref="T:System.Configuration.SettingsProperty" />.</returns>
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00031C4C File Offset: 0x0002FE4C
		public virtual SettingsPropertyCollection Properties
		{
			get
			{
				return this.properties;
			}
		}

		/// <summary>Возвращает коллекцию значений свойств параметров.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.Configuration.SettingsPropertyValue" />, представляющих конкретные значения данных для свойств, управляемых экземпляром <see cref="T:System.Configuration.SettingsBase" />.</returns>
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00031C54 File Offset: 0x0002FE54
		public virtual SettingsPropertyValueCollection PropertyValues
		{
			get
			{
				if (this.sync)
				{
					lock (this)
					{
						return this.values;
					}
				}
				return this.values;
			}
		}

		/// <summary>Возвращает коллекцию поставщиков параметров.</summary>
		/// <returns>Коллекция <see cref="T:System.Configuration.SettingsProviderCollection" />, содержащая объекты <see cref="T:System.Configuration.SettingsProvider" />.</returns>
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00031CA0 File Offset: 0x0002FEA0
		public virtual SettingsProviderCollection Providers
		{
			get
			{
				return this.providers;
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00031CA8 File Offset: 0x0002FEA8
		private object GetPropertyValue(string propertyName)
		{
			SettingsProperty settingsProperty;
			if (this.Properties == null || (settingsProperty = this.Properties[propertyName]) == null)
			{
				throw new SettingsPropertyNotFoundException(string.Format("The settings property '{0}' was not found", propertyName));
			}
			if (this.values[propertyName] == null)
			{
				foreach (object obj in settingsProperty.Provider.GetPropertyValues(this.Context, this.Properties))
				{
					SettingsPropertyValue property = (SettingsPropertyValue)obj;
					this.values.Add(property);
				}
			}
			return this.PropertyValues[propertyName].PropertyValue;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00031D64 File Offset: 0x0002FF64
		private void SetPropertyValue(string propertyName, object value)
		{
			SettingsProperty settingsProperty;
			if (this.Properties == null || (settingsProperty = this.Properties[propertyName]) == null)
			{
				throw new SettingsPropertyNotFoundException(string.Format("The settings property '{0}' was not found", propertyName));
			}
			if (settingsProperty.IsReadOnly)
			{
				throw new SettingsPropertyIsReadOnlyException(string.Format("The settings property '{0}' is read only", propertyName));
			}
			if (settingsProperty.PropertyType != value.GetType())
			{
				throw new SettingsPropertyWrongTypeException(string.Format("The value supplied is of a type incompatible with the settings property '{0}'", propertyName));
			}
			this.PropertyValues[propertyName].PropertyValue = value;
		}

		// Token: 0x04000790 RID: 1936
		private bool sync;

		// Token: 0x04000791 RID: 1937
		private SettingsContext context;

		// Token: 0x04000792 RID: 1938
		private SettingsPropertyCollection properties;

		// Token: 0x04000793 RID: 1939
		private SettingsProviderCollection providers;

		// Token: 0x04000794 RID: 1940
		private SettingsPropertyValueCollection values = new SettingsPropertyValueCollection();
	}
}
