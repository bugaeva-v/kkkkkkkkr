using System;
using System.Collections.Specialized;

namespace System.Configuration.Provider
{
	/// <summary>Предоставляет базовую реализацию для расширяемой модели поставщика.</summary>
	// Token: 0x02000077 RID: 119
	public abstract class ProviderBase
	{
		/// <summary>Инициализирует построитель конфигураций.</summary>
		/// <param name="name">Понятное имя поставщика.</param>
		/// <param name="config">Коллекция пар "имя-значение", представляющих атрибуты поставщика, указанные в конфигурации для этого поставщика.</param>
		/// <exception cref="T:System.ArgumentNullException">Имя поставщика: <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Имя поставщика имеет нулевую длину.</exception>
		/// <exception cref="T:System.InvalidOperationException">Предпринятая попытка вызвать <see cref="M:System.Configuration.Provider.ProviderBase.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> в поставщике после инициализации поставщика.</exception>
		// Token: 0x060003E5 RID: 997 RVA: 0x0000AE50 File Offset: 0x00009050
		public virtual void Initialize(string name, NameValueCollection config)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Provider name cannot be null or empty.", "name");
			}
			if (this.alreadyInitialized)
			{
				throw new InvalidOperationException("This provider instance has already been initialized.");
			}
			this.alreadyInitialized = true;
			this._name = name;
			if (config != null)
			{
				this._description = config["description"];
				config.Remove("description");
			}
			if (string.IsNullOrEmpty(this._description))
			{
				this._description = this._name;
			}
		}

		/// <summary>Возвращает понятное имя, используемое для ссылки на поставщика во время конфигурирования.</summary>
		/// <returns>Понятное имя, используемое для ссылки на поставщика во время конфигурирования.</returns>
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000AEDC File Offset: 0x000090DC
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		/// <summary>Возвращает краткое, понятное описание, подходящее для отображения в инструментах администрирования или других пользовательских интерфейсах (UI).</summary>
		/// <returns>Краткое, понятное описание, подходящее для отображения в инструментах администрирования или других пользовательских интерфейсах.</returns>
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000AEE4 File Offset: 0x000090E4
		public virtual string Description
		{
			get
			{
				return this._description;
			}
		}

		// Token: 0x04000160 RID: 352
		private bool alreadyInitialized;

		// Token: 0x04000161 RID: 353
		private string _description;

		// Token: 0x04000162 RID: 354
		private string _name;
	}
}
