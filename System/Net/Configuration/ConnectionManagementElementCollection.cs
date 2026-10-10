using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет контейнер для элементов конфигурации управления подключениями. Этот класс не наследуется.</summary>
	// Token: 0x02000761 RID: 1889
	[ConfigurationCollection(typeof(ConnectionManagementElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
	{
		/// <summary>Возвращает или задает элемент в указанной позиции в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс элемента.</param>
		/// <returns>Класс <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> в заданном местоположении.</returns>
		// Token: 0x17000D7B RID: 3451
		[MonoTODO]
		public ConnectionManagementElement this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает или задает элемент с указанным ключом.</summary>
		/// <param name="name">Ключ для элемента в коллекции.</param>
		/// <returns>Элемент <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> с указанным ключом или значение <see langword="null" />, если элемент с указанным ключом отсутствует.</returns>
		// Token: 0x17000D7C RID: 3452
		public ConnectionManagementElement this[string name]
		{
			get
			{
				return (ConnectionManagementElement)base[name];
			}
			set
			{
				base[name] = value;
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="element">Параметр <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> для добавления в коллекцию.</param>
		// Token: 0x06003B9E RID: 15262 RVA: 0x000316DB File Offset: 0x0002F8DB
		public void Add(ConnectionManagementElement element)
		{
			this.BaseAdd(element);
		}

		/// <summary>Удаляет из коллекции все элементы.</summary>
		// Token: 0x06003B9F RID: 15263 RVA: 0x000316E4 File Offset: 0x0002F8E4
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x000CC610 File Offset: 0x000CA810
		protected override ConfigurationElement CreateNewElement()
		{
			return new ConnectionManagementElement();
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x000CC617 File Offset: 0x000CA817
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (!(element is ConnectionManagementElement))
			{
				throw new ArgumentException("element");
			}
			return ((ConnectionManagementElement)element).Address;
		}

		/// <summary>Возвращает индекс указанного элемента конфигурации.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.ConnectionManagementElement" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="element" />.</returns>
		// Token: 0x06003BA2 RID: 15266 RVA: 0x000CC425 File Offset: 0x000CA625
		public int IndexOf(ConnectionManagementElement element)
		{
			return base.BaseIndexOf(element);
		}

		/// <summary>Удаляет указанный элемент конфигурации из коллекции.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> для удаления.</param>
		// Token: 0x06003BA3 RID: 15267 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(ConnectionManagementElement element)
		{
			base.BaseRemove(element);
		}

		/// <summary>Удаляет элемент с указанным ключом.</summary>
		/// <param name="name">Ключ элемента, который требуется удалить.</param>
		// Token: 0x06003BA4 RID: 15268 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		/// <summary>Удаляет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		// Token: 0x06003BA5 RID: 15269 RVA: 0x000CC437 File Offset: 0x000CA637
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
	}
}
