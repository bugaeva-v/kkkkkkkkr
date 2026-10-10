using System;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Configuration.ProviderSettings" />.</summary>
	// Token: 0x02000062 RID: 98
	[ConfigurationCollection(typeof(ProviderSettings), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class ProviderSettingsCollection : ConfigurationElementCollection
	{
		/// <summary>Добавляет объект <see cref="T:System.Configuration.ProviderSettings" /> в коллекцию.</summary>
		/// <param name="provider">Добавляемый объект <see cref="T:System.Configuration.ProviderSettings" />.</param>
		// Token: 0x0600032D RID: 813 RVA: 0x000075C8 File Offset: 0x000057C8
		public void Add(ProviderSettings provider)
		{
			this.BaseAdd(provider);
		}

		/// <summary>Очищает коллекцию.</summary>
		// Token: 0x0600032E RID: 814 RVA: 0x000075D1 File Offset: 0x000057D1
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00008ED4 File Offset: 0x000070D4
		protected override ConfigurationElement CreateNewElement()
		{
			return new ProviderSettings();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00008EDB File Offset: 0x000070DB
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ProviderSettings)element).Name;
		}

		/// <summary>Удаляет элемент из коллекции.</summary>
		/// <param name="name">Имя удаляемого объекта <see cref="T:System.Configuration.ProviderSettings" />.</param>
		// Token: 0x06000331 RID: 817 RVA: 0x000075F0 File Offset: 0x000057F0
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		/// <summary>Возвращает или задает значение в коллекции <see cref="T:System.Configuration.ProviderSettingsCollection" /> по указанному индексу.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Configuration.ProviderSettings" />.</param>
		/// <returns>Указанный <see cref="T:System.Configuration.ProviderSettings" />.</returns>
		// Token: 0x170000EF RID: 239
		public ProviderSettings this[int index]
		{
			get
			{
				return (ProviderSettings)base.BaseGet(index);
			}
			set
			{
				this.BaseAdd(index, value);
			}
		}

		/// <summary>Возвращает элемент из коллекции.</summary>
		/// <param name="key">Строковая ссылка на объект <see cref="T:System.Configuration.ProviderSettings" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ProviderSettings" /> в коллекции.</returns>
		// Token: 0x170000F0 RID: 240
		public ProviderSettings this[string key]
		{
			get
			{
				return (ProviderSettings)base.BaseGet(key);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00008F0E File Offset: 0x0000710E
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ProviderSettingsCollection.props;
			}
		}

		// Token: 0x0400012B RID: 299
		private static ConfigurationPropertyCollection props = new ConfigurationPropertyCollection();
	}
}
