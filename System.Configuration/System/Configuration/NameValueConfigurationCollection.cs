using System;

namespace System.Configuration
{
	/// <summary>Содержит коллекцию объектов <see cref="T:System.Configuration.NameValueConfigurationElement" />. Этот класс не наследуется.</summary>
	// Token: 0x02000054 RID: 84
	[ConfigurationCollection(typeof(NameValueConfigurationElement), AddItemName = "add", RemoveItemName = "remove", ClearItemsName = "clear", CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class NameValueConfigurationCollection : ConfigurationElementCollection
	{
		/// <summary>Возвращает ключи всех элементов, содержащихся в <see cref="T:System.Configuration.NameValueConfigurationCollection" />.</summary>
		/// <returns>Массив строк.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00008690 File Offset: 0x00006890
		public string[] AllKeys
		{
			get
			{
				return (string[])base.BaseGetAllKeys();
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Configuration.NameValueConfigurationElement" />, созданный на основе указанных параметров.</summary>
		/// <param name="name">Имя элемента <see cref="T:System.Configuration.NameValueConfigurationElement" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Configuration.NameValueConfigurationElement" />.</returns>
		// Token: 0x170000CA RID: 202
		public NameValueConfigurationElement this[string name]
		{
			get
			{
				return (NameValueConfigurationElement)base.BaseGet(name);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000086AB File Offset: 0x000068AB
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				return NameValueConfigurationCollection.properties;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.NameValueConfigurationElement" /> в коллекцию.</summary>
		/// <param name="nameValue">Объект <see cref="T:System.Configuration.NameValueConfigurationElement" />.</param>
		// Token: 0x060002D3 RID: 723 RVA: 0x000086B2 File Offset: 0x000068B2
		public void Add(NameValueConfigurationElement nameValue)
		{
			base.BaseAdd(nameValue, false);
		}

		/// <summary>Очищает <see cref="T:System.Configuration.NameValueConfigurationCollection" />.</summary>
		// Token: 0x060002D4 RID: 724 RVA: 0x000075D1 File Offset: 0x000057D1
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000086BC File Offset: 0x000068BC
		protected override ConfigurationElement CreateNewElement()
		{
			return new NameValueConfigurationElement("", "");
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000086CD File Offset: 0x000068CD
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((NameValueConfigurationElement)element).Name;
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.NameValueConfigurationElement" /> из коллекции, основанной на предоставленном параметре.</summary>
		/// <param name="nameValue">Объект <see cref="T:System.Configuration.NameValueConfigurationElement" />.</param>
		// Token: 0x060002D7 RID: 727 RVA: 0x0000371B File Offset: 0x0000191B
		public void Remove(NameValueConfigurationElement nameValue)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.NameValueConfigurationElement" /> из коллекции, основанной на предоставленном параметре.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</param>
		// Token: 0x060002D8 RID: 728 RVA: 0x000075F0 File Offset: 0x000057F0
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		// Token: 0x0400010B RID: 267
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
