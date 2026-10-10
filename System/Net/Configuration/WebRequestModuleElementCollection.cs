using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет контейнер для элементов конфигурации модулей веб-запросов. Этот класс не наследуется.</summary>
	// Token: 0x0200077F RID: 1919
	[ConfigurationCollection(typeof(WebRequestModuleElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		/// <summary>Возвращает или задает элемент в указанной позиции в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс элемента.</param>
		/// <returns>Класс <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> в заданном местоположении.</returns>
		// Token: 0x17000DDA RID: 3546
		[MonoTODO]
		public WebRequestModuleElement this[int index]
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
		/// <returns>Элемент <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> с указанным ключом или значение <see langword="null" />, если элемент с указанным ключом отсутствует.</returns>
		// Token: 0x17000DDB RID: 3547
		[MonoTODO]
		public WebRequestModuleElement this[string name]
		{
			get
			{
				return (WebRequestModuleElement)base[name];
			}
			set
			{
				base[name] = value;
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="element">Параметр <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> для добавления в коллекцию.</param>
		// Token: 0x06003C80 RID: 15488 RVA: 0x000316DB File Offset: 0x0002F8DB
		public void Add(WebRequestModuleElement element)
		{
			this.BaseAdd(element);
		}

		/// <summary>Удаляет из коллекции все элементы.</summary>
		// Token: 0x06003C81 RID: 15489 RVA: 0x000316E4 File Offset: 0x0002F8E4
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x000CE3EE File Offset: 0x000CC5EE
		protected override ConfigurationElement CreateNewElement()
		{
			return new WebRequestModuleElement();
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x000CE3F5 File Offset: 0x000CC5F5
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (!(element is WebRequestModuleElement))
			{
				throw new ArgumentException("element");
			}
			return ((WebRequestModuleElement)element).Prefix;
		}

		/// <summary>Возвращает индекс указанного элемента конфигурации.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.WebRequestModuleElement" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="element" />.</returns>
		// Token: 0x06003C84 RID: 15492 RVA: 0x000CC425 File Offset: 0x000CA625
		public int IndexOf(WebRequestModuleElement element)
		{
			return base.BaseIndexOf(element);
		}

		/// <summary>Удаляет указанный элемент конфигурации из коллекции.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> для удаления.</param>
		// Token: 0x06003C85 RID: 15493 RVA: 0x000CE415 File Offset: 0x000CC615
		public void Remove(WebRequestModuleElement element)
		{
			base.BaseRemove(element.Prefix);
		}

		/// <summary>Удаляет элемент с указанным ключом.</summary>
		/// <param name="name">Ключ элемента, который требуется удалить.</param>
		// Token: 0x06003C86 RID: 15494 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		/// <summary>Удаляет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		// Token: 0x06003C87 RID: 15495 RVA: 0x000CC437 File Offset: 0x000CA637
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
	}
}
