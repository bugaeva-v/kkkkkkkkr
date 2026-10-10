using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Возвращает строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.InstanceDataCollection" />.</summary>
	// Token: 0x0200026B RID: 619
	public class InstanceDataCollectionCollection : DictionaryBase
	{
		// Token: 0x06001378 RID: 4984 RVA: 0x000517FF File Offset: 0x0004F9FF
		private static void CheckNull(object value, string name)
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.InstanceDataCollectionCollection" />.</summary>
		// Token: 0x06001379 RID: 4985 RVA: 0x0005188D File Offset: 0x0004FA8D
		[Obsolete("Use PerformanceCounterCategory.ReadCategory()")]
		public InstanceDataCollectionCollection()
		{
		}

		/// <summary>Возвращает данные экземпляра для указанного счетчика.</summary>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <returns>Элемент <see cref="T:System.Diagnostics.InstanceDataCollection" />, по которому индексируется объект <see cref="T:System.Diagnostics.InstanceDataCollectionCollection" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x170003A6 RID: 934
		public InstanceDataCollection this[string counterName]
		{
			get
			{
				InstanceDataCollectionCollection.CheckNull(counterName, "counterName");
				return (InstanceDataCollection)base.Dictionary[counterName];
			}
		}

		/// <summary>Возвращает объект и разделы реестра счетчика для объектов, связанных с этой коллекцией данных экземпляра.</summary>
		/// <returns>Класс <see cref="T:System.Collections.ICollection" />, представляющий набор разделов реестра, связанных с объектами.</returns>
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0005184B File Offset: 0x0004FA4B
		public ICollection Keys
		{
			get
			{
				return base.Dictionary.Keys;
			}
		}

		/// <summary>Возвращает значения данных экземпляра, в которых содержится коллекция экземпляров счетчика.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, предоставляющий экземпляры счетчика и связанные с ними значения данных.</returns>
		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00051858 File Offset: 0x0004FA58
		public ICollection Values
		{
			get
			{
				return base.Dictionary.Values;
			}
		}

		/// <summary>Определяет наличие коллекции данных экземпляра для указанного счетчика (определяется по одному из индексированных объектов <see cref="T:System.Diagnostics.InstanceDataCollection" />) в соответствующей коллекции.</summary>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <returns>Значение <see langword="true" />, если в коллекции присутствует коллекция данных экземпляра, содержащая указанный счетчик; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600137D RID: 4989 RVA: 0x000518B3 File Offset: 0x0004FAB3
		public bool Contains(string counterName)
		{
			InstanceDataCollectionCollection.CheckNull(counterName, "counterName");
			return base.Dictionary.Contains(counterName);
		}

		/// <summary>Копирует массив экземпляров <see cref="T:System.Diagnostics.InstanceDataCollection" /> в коллекцию по указанному индексу.</summary>
		/// <param name="counters">Добавляемый в коллекцию массив экземпляров <see cref="T:System.Diagnostics.InstanceDataCollection" /> (определяются по содержащимся в них счетчикам).</param>
		/// <param name="index">Расположение, в которое добавляются новые экземпляры.</param>
		// Token: 0x0600137E RID: 4990 RVA: 0x0005187E File Offset: 0x0004FA7E
		public void CopyTo(InstanceDataCollection[] counters, int index)
		{
			base.Dictionary.CopyTo(counters, index);
		}
	}
}
