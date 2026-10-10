using System;

namespace System.Configuration
{
	/// <summary>Содержит коллекцию объектов <see cref="T:System.Configuration.KeyValueConfigurationElement" />.</summary>
	// Token: 0x0200004F RID: 79
	[ConfigurationCollection(typeof(KeyValueConfigurationElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public class KeyValueConfigurationCollection : ConfigurationElementCollection
	{
		/// <summary>Добавляет объект <see cref="T:System.Configuration.KeyValueConfigurationElement" /> в коллекцию на основе указанных параметрах.</summary>
		/// <param name="keyValue">Объект <see cref="T:System.Configuration.KeyValueConfigurationElement" />.</param>
		// Token: 0x060002AA RID: 682 RVA: 0x00008349 File Offset: 0x00006549
		public void Add(KeyValueConfigurationElement keyValue)
		{
			keyValue.Init();
			this.BaseAdd(keyValue);
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.KeyValueConfigurationElement" /> в коллекцию на основе указанных параметрах.</summary>
		/// <param name="key">Строка, определяющая ключ.</param>
		/// <param name="value">Строка, определяющая значение.</param>
		// Token: 0x060002AB RID: 683 RVA: 0x00008358 File Offset: 0x00006558
		public void Add(string key, string value)
		{
			this.Add(new KeyValueConfigurationElement(key, value));
		}

		/// <summary>Очищает коллекцию <see cref="T:System.Configuration.KeyValueConfigurationCollection" />.</summary>
		// Token: 0x060002AC RID: 684 RVA: 0x000075D1 File Offset: 0x000057D1
		public void Clear()
		{
			base.BaseClear();
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.KeyValueConfigurationElement" /> из коллекции.</summary>
		/// <param name="key">Строка, определяющая <paramref name="key" />.</param>
		// Token: 0x060002AD RID: 685 RVA: 0x000075F0 File Offset: 0x000057F0
		public void Remove(string key)
		{
			base.BaseRemove(key);
		}

		/// <summary>Возвращает ключи всех элементов в коллекции <see cref="T:System.Configuration.KeyValueConfigurationCollection" />.</summary>
		/// <returns>Массив строк.</returns>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00008368 File Offset: 0x00006568
		public string[] AllKeys
		{
			get
			{
				string[] array = new string[base.Count];
				int num = 0;
				foreach (object obj in this)
				{
					KeyValueConfigurationElement keyValueConfigurationElement = (KeyValueConfigurationElement)obj;
					array[num++] = keyValueConfigurationElement.Key;
				}
				return array;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.KeyValueConfigurationElement" />, созданный на основе указанных параметров.</summary>
		/// <param name="key">Ключ объекта <see cref="T:System.Configuration.KeyValueConfigurationElement" />, содержащегося в коллекции.</param>
		/// <returns>Элемент конфигурации или <see langword="null" />, если ключ отсутствует в коллекции.</returns>
		// Token: 0x170000BF RID: 191
		public KeyValueConfigurationElement this[string key]
		{
			get
			{
				return (KeyValueConfigurationElement)base.BaseGet(key);
			}
		}

		/// <summary>При переопределении в производном классе метод <see cref="M:System.Configuration.KeyValueConfigurationCollection.CreateNewElement" />создает новый объект <see cref="T:System.Configuration.KeyValueConfigurationElement" />.</summary>
		/// <returns>Только что созданный объект <see cref="T:System.Configuration.KeyValueConfigurationElement" />.</returns>
		// Token: 0x060002B0 RID: 688 RVA: 0x000083E2 File Offset: 0x000065E2
		protected override ConfigurationElement CreateNewElement()
		{
			return new KeyValueConfigurationElement();
		}

		/// <summary>При переопределении в производном классе возвращает ключ указанного элемента конфигурации.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.KeyValueConfigurationElement" />, в который должен быть возвращен ключ.</param>
		/// <returns>Объект, используемый в качестве ключа для указанного элемента <see cref="T:System.Configuration.KeyValueConfigurationElement" />.</returns>
		// Token: 0x060002B1 RID: 689 RVA: 0x000083E9 File Offset: 0x000065E9
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((KeyValueConfigurationElement)element).Key;
		}

		/// <summary>Возвращает коллекцию свойств конфигурации.</summary>
		/// <returns>Коллекция свойств конфигурации.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000083F6 File Offset: 0x000065F6
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				if (this.properties == null)
				{
					this.properties = new ConfigurationPropertyCollection();
				}
				return this.properties;
			}
		}

		/// <summary>Возвращает значение, указывающее, выдаст ли исключение попытка добавить дубликат объекта <see cref="T:System.Configuration.KeyValueConfigurationElement" /> в коллекцию <see cref="T:System.Configuration.KeyValueConfigurationCollection" />.</summary>
		/// <returns>Значение <see langword="true" />, если попытка добавить дубликат объекта <see cref="T:System.Configuration.KeyValueConfigurationElement" /> в коллекцию <see cref="T:System.Configuration.KeyValueConfigurationCollection" /> приведет к вызову исключения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x000023BB File Offset: 0x000005BB
		protected override bool ThrowOnDuplicate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040000FF RID: 255
		private ConfigurationPropertyCollection properties;
	}
}
