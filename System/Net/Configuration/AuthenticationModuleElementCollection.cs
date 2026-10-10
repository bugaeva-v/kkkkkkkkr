using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет контейнер для элементов конфигурации модулей проверки подлинности. Этот класс не наследуется.</summary>
	// Token: 0x0200075C RID: 1884
	[ConfigurationCollection(typeof(AuthenticationModuleElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.AuthenticationModuleElementCollection" />.</summary>
		// Token: 0x06003B6A RID: 15210 RVA: 0x000316D3 File Offset: 0x0002F8D3
		[MonoTODO]
		public AuthenticationModuleElementCollection()
		{
		}

		/// <summary>Возвращает или задает элемент в указанной позиции в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс элемента.</param>
		/// <returns>Класс <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> в заданном местоположении.</returns>
		// Token: 0x17000D6F RID: 3439
		[MonoTODO]
		public AuthenticationModuleElement this[int index]
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
		/// <returns>Элемент <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> с указанным ключом или значение <see langword="null" />, если элемент с указанным ключом отсутствует.</returns>
		// Token: 0x17000D70 RID: 3440
		[MonoTODO]
		public AuthenticationModuleElement this[string name]
		{
			get
			{
				return (AuthenticationModuleElement)base[name];
			}
			set
			{
				base[name] = value;
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="element">Параметр <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> для добавления в коллекцию.</param>
		// Token: 0x06003B6F RID: 15215 RVA: 0x000316DB File Offset: 0x0002F8DB
		public void Add(AuthenticationModuleElement element)
		{
			this.BaseAdd(element);
		}

		/// <summary>Удаляет из коллекции все элементы.</summary>
		// Token: 0x06003B70 RID: 15216 RVA: 0x000316E4 File Offset: 0x0002F8E4
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x000CC3FE File Offset: 0x000CA5FE
		protected override ConfigurationElement CreateNewElement()
		{
			return new AuthenticationModuleElement();
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x000CC405 File Offset: 0x000CA605
		[MonoTODO("argument exception?")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (!(element is AuthenticationModuleElement))
			{
				throw new ArgumentException("element");
			}
			return ((AuthenticationModuleElement)element).Type;
		}

		/// <summary>Возвращает индекс указанного элемента конфигурации.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.AuthenticationModuleElement" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="element" />.</returns>
		// Token: 0x06003B73 RID: 15219 RVA: 0x000CC425 File Offset: 0x000CA625
		public int IndexOf(AuthenticationModuleElement element)
		{
			return base.BaseIndexOf(element);
		}

		/// <summary>Удаляет указанный элемент конфигурации из коллекции.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> для удаления.</param>
		// Token: 0x06003B74 RID: 15220 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(AuthenticationModuleElement element)
		{
			base.BaseRemove(element);
		}

		/// <summary>Удаляет элемент с указанным ключом.</summary>
		/// <param name="name">Ключ элемента, который требуется удалить.</param>
		// Token: 0x06003B75 RID: 15221 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		/// <summary>Удаляет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		// Token: 0x06003B76 RID: 15222 RVA: 0x000CC437 File Offset: 0x000CA637
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
	}
}
