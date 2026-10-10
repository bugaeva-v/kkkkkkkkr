using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет контейнер для адресов ресурсов, которые обходят прокси-сервер. Этот класс не наследуется.</summary>
	// Token: 0x0200075F RID: 1887
	[ConfigurationCollection(typeof(BypassElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		/// <summary>Возвращает или задает элемент в указанной позиции в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс элемента.</param>
		/// <returns>Класс <see cref="T:System.Net.Configuration.BypassElement" /> в заданном местоположении.</returns>
		// Token: 0x17000D75 RID: 3445
		[MonoTODO]
		public BypassElement this[int index]
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
		/// <returns>Элемент <see cref="T:System.Net.Configuration.BypassElement" /> с указанным ключом или значение <see langword="null" />, если элемент для указанного ключа отсутствует.</returns>
		// Token: 0x17000D76 RID: 3446
		public BypassElement this[string name]
		{
			get
			{
				return (BypassElement)base[name];
			}
			set
			{
				base[name] = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x00003062 File Offset: 0x00001262
		protected override bool ThrowOnDuplicate
		{
			get
			{
				return false;
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="element">Параметр <see cref="T:System.Net.Configuration.BypassElement" /> для добавления в коллекцию.</param>
		// Token: 0x06003B89 RID: 15241 RVA: 0x000316DB File Offset: 0x0002F8DB
		public void Add(BypassElement element)
		{
			this.BaseAdd(element);
		}

		/// <summary>Удаляет из коллекции все элементы.</summary>
		// Token: 0x06003B8A RID: 15242 RVA: 0x000316E4 File Offset: 0x0002F8E4
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x000CC509 File Offset: 0x000CA709
		protected override ConfigurationElement CreateNewElement()
		{
			return new BypassElement();
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x000CC510 File Offset: 0x000CA710
		[MonoTODO("argument exception?")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (!(element is BypassElement))
			{
				throw new ArgumentException("element");
			}
			return ((BypassElement)element).Address;
		}

		/// <summary>Возвращает индекс указанного элемента конфигурации.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.BypassElement" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="element" />.</returns>
		// Token: 0x06003B8D RID: 15245 RVA: 0x000CC425 File Offset: 0x000CA625
		public int IndexOf(BypassElement element)
		{
			return base.BaseIndexOf(element);
		}

		/// <summary>Удаляет указанный элемент конфигурации из коллекции.</summary>
		/// <param name="element">Объект <see cref="T:System.Net.Configuration.BypassElement" /> для удаления.</param>
		// Token: 0x06003B8E RID: 15246 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(BypassElement element)
		{
			base.BaseRemove(element);
		}

		/// <summary>Удаляет элемент с указанным ключом.</summary>
		/// <param name="name">Ключ элемента, который требуется удалить.</param>
		// Token: 0x06003B8F RID: 15247 RVA: 0x000CC42E File Offset: 0x000CA62E
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		/// <summary>Удаляет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		// Token: 0x06003B90 RID: 15248 RVA: 0x000CC437 File Offset: 0x000CA637
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
	}
}
