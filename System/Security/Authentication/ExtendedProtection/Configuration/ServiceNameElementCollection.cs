using System;
using System.Configuration;
using Unity;

namespace System.Security.Authentication.ExtendedProtection.Configuration
{
	/// <summary>Класс <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" /> представляет коллекцию имен участника-службы, представляющих элемент конфигурации для объекта <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</summary>
	// Token: 0x020002AD RID: 685
	[ConfigurationCollection(typeof(ServiceNameElement))]
	public sealed class ServiceNameElementCollection : ConfigurationElementCollection
	{
		/// <summary>Свойство <see cref="P:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Item(System.String)" /> получает или задает экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> по указанному расположению в индексе.</summary>
		/// <param name="index">Индекс экземпляра <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> в данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		/// <returns>Запрошенный экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />. Если запрошенный экземпляр не найден, возвращается <see langword="null" />.</returns>
		// Token: 0x17000407 RID: 1031
		public ServiceNameElement this[int index]
		{
			get
			{
				return (ServiceNameElement)base.BaseGet(index);
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Item(System.String)" /> получает или задает экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> на основе строки, представляющей экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, представляющий экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> в данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		/// <returns>Запрошенный экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />. Если запрошенный экземпляр не найден, возвращается <see langword="null" />.</returns>
		// Token: 0x17000408 RID: 1032
		public ServiceNameElement this[string name]
		{
			get
			{
				return (ServiceNameElement)base.BaseGet(name);
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Add(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement)" /> добавляет экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> к этому объекту <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</summary>
		/// <param name="element">Экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />, который нужно добавить в данную коллекцию <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		// Token: 0x06001551 RID: 5457 RVA: 0x0000829A File Offset: 0x0000649A
		public void Add(ServiceNameElement element)
		{
			throw new NotImplementedException();
		}

		/// <summary>Метод <see cref="M:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Clear" /> удаляет все объекты элементов конфигурации из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</summary>
		// Token: 0x06001552 RID: 5458 RVA: 0x0000829A File Offset: 0x0000649A
		public void Clear()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00055CE6 File Offset: 0x00053EE6
		protected override ConfigurationElement CreateNewElement()
		{
			return new ServiceNameElement();
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00055CED File Offset: 0x00053EED
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return ((ServiceNameElement)element).Name;
		}

		/// <summary>Метод <see cref="M:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.IndexOf(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement)" /> извлекает индекс указанного элемента конфигурации в данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</summary>
		/// <param name="element">Экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />, индекс которого нужно получить в данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		/// <returns>Индекс указанного объекта <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> в данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</returns>
		// Token: 0x06001555 RID: 5461 RVA: 0x0000829A File Offset: 0x0000649A
		public int IndexOf(ServiceNameElement element)
		{
			throw new NotImplementedException();
		}

		/// <summary>Метод <see cref="M:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Remove(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement)" /> удаляет экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" /> на основе заданной строки <see cref="T:System.String" />.</summary>
		/// <param name="name">Строка <see cref="T:System.String" />, представляющая экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />, который следует удалить из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" /></param>
		// Token: 0x06001556 RID: 5462 RVA: 0x0000829A File Offset: 0x0000649A
		public void Remove(string name)
		{
			throw new NotImplementedException();
		}

		/// <summary>Метод <see cref="M:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Remove(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement)" /> удаляет экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</summary>
		/// <param name="element">Экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />, который следует удалить из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001557 RID: 5463 RVA: 0x0000829A File Offset: 0x0000649A
		public void Remove(ServiceNameElement element)
		{
			throw new NotImplementedException();
		}

		/// <summary>Метод <see cref="M:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Remove(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement)" /> удаляет экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" /> на основе заданного индекса.</summary>
		/// <param name="index">Индекс экземпляра <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />, удаляемого из данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		// Token: 0x06001558 RID: 5464 RVA: 0x0000829A File Offset: 0x0000649A
		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00013BCA File Offset: 0x00011DCA
		public void set_Item(int index, ServiceNameElement value)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Свойство <see cref="P:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection.Item(System.String)" /> получает или задает экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> на основе строки, представляющей экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, представляющий экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" /> в данной коллекции <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection" />.</param>
		/// <returns>Запрошенный экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement" />. Если запрошенный экземпляр не найден, возвращается <see langword="null" />.</returns>
		// Token: 0x17000409 RID: 1033
		public string this[string name]
		{
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}
	}
}
