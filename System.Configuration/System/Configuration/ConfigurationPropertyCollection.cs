using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию свойств элементов конфигурации.</summary>
	// Token: 0x0200002B RID: 43
	public class ConfigurationPropertyCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationPropertyCollection" />.</summary>
		// Token: 0x06000188 RID: 392 RVA: 0x00006617 File Offset: 0x00004817
		public ConfigurationPropertyCollection()
		{
			this.collection = new List<ConfigurationProperty>();
		}

		/// <summary>Получает количество свойств в коллекции.</summary>
		/// <returns>Количество свойств в коллекции.</returns>
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000662A File Offset: 0x0000482A
		public int Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		/// <summary>Получает элемент коллекции с указанным именем.</summary>
		/// <param name="name">Возвращаемое значение <see cref="T:System.Configuration.ConfigurationProperty" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationProperty" /> с указанным именем <paramref name="name" />.</returns>
		// Token: 0x17000074 RID: 116
		public ConfigurationProperty this[string name]
		{
			get
			{
				foreach (ConfigurationProperty configurationProperty in this.collection)
				{
					if (configurationProperty.Name == name)
					{
						return configurationProperty;
					}
				}
				return null;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции <see cref="T:System.Configuration.ConfigurationPropertyCollection" /> является синхронизированным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000023BB File Offset: 0x000005BB
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, используемый для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, используемый для синхронизации доступа к коллекции.</returns>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000669C File Offset: 0x0000489C
		public object SyncRoot
		{
			get
			{
				return this.collection;
			}
		}

		/// <summary>Добавляет в коллекцию свойство конфигурации.</summary>
		/// <param name="property">Добавляемый объект <see cref="T:System.Configuration.ConfigurationProperty" />.</param>
		// Token: 0x0600018D RID: 397 RVA: 0x000066A4 File Offset: 0x000048A4
		public void Add(ConfigurationProperty property)
		{
			if (property == null)
			{
				throw new ArgumentNullException("property");
			}
			this.collection.Add(property);
		}

		/// <summary>Указывает, содержится ли свойство конфигурации в этой коллекции.</summary>
		/// <param name="name">Идентификатор для проверяемого свойства <see cref="T:System.Configuration.ConfigurationProperty" />.</param>
		/// <returns>Значение <see langword="true" />, если указанное свойство <see cref="T:System.Configuration.ConfigurationProperty" /> включено в коллекцию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600018E RID: 398 RVA: 0x000066C0 File Offset: 0x000048C0
		public bool Contains(string name)
		{
			ConfigurationProperty configurationProperty = this[name];
			return configurationProperty != null && this.collection.Contains(configurationProperty);
		}

		/// <summary>Копирует ConfigurationPropertyCollection в массив.</summary>
		/// <param name="array">Массив, в который выполняется копирование.</param>
		/// <param name="index">Индекс, с которого начинается копирование.</param>
		// Token: 0x0600018F RID: 399 RVA: 0x000066E6 File Offset: 0x000048E6
		public void CopyTo(ConfigurationProperty[] array, int index)
		{
			this.collection.CopyTo(array, index);
		}

		/// <summary>Копирует данную коллекцию в массив.</summary>
		/// <param name="array">Массив, в который выполняется копирование.</param>
		/// <param name="index">Расположение индекса, с которого начинается копирование.</param>
		// Token: 0x06000190 RID: 400 RVA: 0x000066F5 File Offset: 0x000048F5
		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this.collection).CopyTo(array, index);
		}

		/// <summary>Получает объект <see cref="T:System.Collections.IEnumerator" /> в том виде, в котором он применяется в данной коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" /> в том виде, в котором он применяется в данной коллекции.</returns>
		// Token: 0x06000191 RID: 401 RVA: 0x00006704 File Offset: 0x00004904
		public IEnumerator GetEnumerator()
		{
			return this.collection.GetEnumerator();
		}

		/// <summary>Удаляет свойство конфигурации из коллекции.</summary>
		/// <param name="name">Объект <see cref="T:System.Configuration.ConfigurationProperty" /> для удаления.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Configuration.ConfigurationProperty" /> удален; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000192 RID: 402 RVA: 0x00006716 File Offset: 0x00004916
		public bool Remove(string name)
		{
			return this.collection.Remove(this[name]);
		}

		/// <summary>Удаляет из коллекции все объекты свойств конфигурации.</summary>
		// Token: 0x06000193 RID: 403 RVA: 0x0000672A File Offset: 0x0000492A
		public void Clear()
		{
			this.collection.Clear();
		}

		// Token: 0x040000AA RID: 170
		private List<ConfigurationProperty> collection;
	}
}
