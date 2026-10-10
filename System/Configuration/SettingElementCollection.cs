using System;

namespace System.Configuration
{
	/// <summary>Содержит коллекцию объектов <see cref="T:System.Configuration.SettingElement" />. Этот класс не наследуется.</summary>
	// Token: 0x020001C0 RID: 448
	public sealed class SettingElementCollection : ConfigurationElementCollection
	{
		/// <summary>Добавляет объект <see cref="T:System.Configuration.SettingElement" /> в коллекцию.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.SettingElement" /> для добавления в коллекцию.</param>
		// Token: 0x06000BBF RID: 3007 RVA: 0x000316DB File Offset: 0x0002F8DB
		public void Add(SettingElement element)
		{
			this.BaseAdd(element);
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Configuration.SettingElement" /> из коллекции.</summary>
		// Token: 0x06000BC0 RID: 3008 RVA: 0x000316E4 File Offset: 0x0002F8E4
		public void Clear()
		{
			base.BaseClear();
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.SettingElement" /> из коллекции.</summary>
		/// <param name="elementKey">Любое значение строки представляет объект <see cref="T:System.Configuration.SettingElement" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Configuration.SettingElement" />.</returns>
		// Token: 0x06000BC1 RID: 3009 RVA: 0x000316EC File Offset: 0x0002F8EC
		public SettingElement Get(string elementKey)
		{
			foreach (object obj in this)
			{
				SettingElement settingElement = (SettingElement)obj;
				if (settingElement.Name == elementKey)
				{
					return settingElement;
				}
			}
			return null;
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.SettingElement" /> из коллекции.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.SettingElement" />.</param>
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00031750 File Offset: 0x0002F950
		public void Remove(SettingElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			base.BaseRemove(element.Name);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0003176C File Offset: 0x0002F96C
		protected override ConfigurationElement CreateNewElement()
		{
			return new SettingElement();
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00031773 File Offset: 0x0002F973
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((SettingElement)element).Name;
		}

		/// <summary>Возвращает тип коллекции конфигураций.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationElementCollectionType" /> коллекции.</returns>
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00003062 File Offset: 0x00001262
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00031780 File Offset: 0x0002F980
		protected override string ElementName
		{
			get
			{
				return "setting";
			}
		}
	}
}
