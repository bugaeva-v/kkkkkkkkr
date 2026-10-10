using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Возвращает строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.InstanceData" />.</summary>
	// Token: 0x0200026A RID: 618
	public class InstanceDataCollection : DictionaryBase
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x000517FF File Offset: 0x0004F9FF
		private static void CheckNull(object value, string name)
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.InstanceDataCollection" />, используя указанный счетчик производительности (который определяет экземпляр производительности).</summary>
		/// <param name="counterName">Имя счетчика, который часто описывает подсчитываемое количество.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001371 RID: 4977 RVA: 0x0005180B File Offset: 0x0004FA0B
		[Obsolete("Use InstanceDataCollectionCollection indexer instead.")]
		public InstanceDataCollection(string counterName)
		{
			InstanceDataCollection.CheckNull(counterName, "counterName");
			this.counterName = counterName;
		}

		/// <summary>Возвращает имя счетчика производительности, данные экземпляра которого нужно получить.</summary>
		/// <returns>Имя счетчика производительности.</returns>
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00051825 File Offset: 0x0004FA25
		public string CounterName
		{
			get
			{
				return this.counterName;
			}
		}

		/// <summary>Возвращает данные экземпляра, связанные с этим счетчиком. Как правило, это набор начальных значений счетчика.</summary>
		/// <param name="instanceName">Имя экземпляра категории счетчика производительности или пустая строка (""), если категория содержит единственный экземпляр.</param>
		/// <returns>Элемент <see cref="T:System.Diagnostics.InstanceData" />, по которому индексируется объект <see cref="T:System.Diagnostics.InstanceDataCollection" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="instanceName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x170003A3 RID: 931
		public InstanceData this[string instanceName]
		{
			get
			{
				InstanceDataCollection.CheckNull(instanceName, "instanceName");
				return (InstanceData)base.Dictionary[instanceName];
			}
		}

		/// <summary>Возвращает объект и разделы реестра счетчика для объектов, связанных с данными экземпляра.</summary>
		/// <returns>Класс <see cref="T:System.Collections.ICollection" />, представляющий набор разделов реестра, связанных с объектами.</returns>
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0005184B File Offset: 0x0004FA4B
		public ICollection Keys
		{
			get
			{
				return base.Dictionary.Keys;
			}
		}

		/// <summary>Возвращает начальные значения счетчика, которые содержат данные экземпляра для счетчика.</summary>
		/// <returns>Класс <see cref="T:System.Collections.ICollection" />, предоставляющий начальные значения счетчика.</returns>
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00051858 File Offset: 0x0004FA58
		public ICollection Values
		{
			get
			{
				return base.Dictionary.Values;
			}
		}

		/// <summary>Определяет наличие экземпляра производительности с указанным именем (определенное по одному из индексированных объектов <see cref="T:System.Diagnostics.InstanceData" />) в коллекции.</summary>
		/// <param name="instanceName">Имя экземпляра, который нужно найти в коллекции.</param>
		/// <returns>Значение <see langword="true" /> при наличии экземпляра в коллекции; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="instanceName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001376 RID: 4982 RVA: 0x00051865 File Offset: 0x0004FA65
		public bool Contains(string instanceName)
		{
			InstanceDataCollection.CheckNull(instanceName, "instanceName");
			return base.Dictionary.Contains(instanceName);
		}

		/// <summary>Копирует элементы коллекции в указанный одномерный массив по указанному индексу.</summary>
		/// <param name="instances">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Отсчитываемое от нуля значение индекса, по которому добавляются новые экземпляры.</param>
		// Token: 0x06001377 RID: 4983 RVA: 0x0005187E File Offset: 0x0004FA7E
		public void CopyTo(InstanceData[] instances, int index)
		{
			base.Dictionary.CopyTo(instances, index);
		}

		// Token: 0x04000B02 RID: 2818
		private string counterName;
	}
}
