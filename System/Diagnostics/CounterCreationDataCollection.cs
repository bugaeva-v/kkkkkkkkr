using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Возвращает строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
	// Token: 0x0200024D RID: 589
	[Serializable]
	public class CounterCreationDataCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.CounterCreationDataCollection" /> без связанных экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		// Token: 0x0600121D RID: 4637 RVA: 0x0004E358 File Offset: 0x0004C558
		public CounterCreationDataCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.CounterCreationDataCollection" />, используя указанный массив экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="value">Массив экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />, с помощью которого инициализируется данная коллекция <see cref="T:System.Diagnostics.CounterCreationDataCollection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x0600121E RID: 4638 RVA: 0x0004E360 File Offset: 0x0004C560
		public CounterCreationDataCollection(CounterCreationData[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.CounterCreationDataCollection" />, используя указанную коллекцию экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="value">Класс <see cref="T:System.Diagnostics.CounterCreationDataCollection" />, содержащий экземпляры <see cref="T:System.Diagnostics.CounterCreationData" />, с помощью которых инициализируется класс <see cref="T:System.Diagnostics.CounterCreationDataCollection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x0600121F RID: 4639 RVA: 0x0004E36F File Offset: 0x0004C56F
		public CounterCreationDataCollection(CounterCreationDataCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Индексирует коллекцию <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="index">Индекс в коллекции <see cref="T:System.Diagnostics.CounterCreationDataCollection" />.</param>
		/// <returns>Индекс коллекции, используемый для доступа к отдельным элементам коллекции.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> равно количеству элементов в коллекции или превышает это значение.</exception>
		// Token: 0x1700033E RID: 830
		public CounterCreationData this[int index]
		{
			get
			{
				return (CounterCreationData)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		/// <summary>Добавляет в коллекцию экземпляр класса <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Diagnostics.CounterCreationData" />, добавляемый в конец существующей коллекции.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Diagnostics.CounterCreationData" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Diagnostics.CounterCreationData" />.</exception>
		// Token: 0x06001222 RID: 4642 RVA: 0x0004E3A0 File Offset: 0x0004C5A0
		public int Add(CounterCreationData value)
		{
			return base.InnerList.Add(value);
		}

		/// <summary>Добавляет в коллекцию указанный массив экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="value">Массив экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />, добавляемых в конец существующей коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06001223 RID: 4643 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		public void AddRange(CounterCreationData[] value)
		{
			foreach (CounterCreationData value2 in value)
			{
				this.Add(value2);
			}
		}

		/// <summary>Добавляет в коллекцию указанную коллекцию экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="value">Коллекция экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />, добавляемая в конец существующей коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06001224 RID: 4644 RVA: 0x0004E3DC File Offset: 0x0004C5DC
		public void AddRange(CounterCreationDataCollection value)
		{
			foreach (object obj in value)
			{
				CounterCreationData value2 = (CounterCreationData)obj;
				this.Add(value2);
			}
		}

		/// <summary>Определяет существование экземпляра <see cref="T:System.Diagnostics.CounterCreationData" /> в коллекции.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Diagnostics.CounterCreationData" /> в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Diagnostics.CounterCreationData" /> присутствует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001225 RID: 4645 RVA: 0x0004E434 File Offset: 0x0004C634
		public bool Contains(CounterCreationData value)
		{
			return base.InnerList.Contains(value);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Diagnostics.CounterCreationData" /> в массив, начиная с указанного индекса массива.</summary>
		/// <param name="array">Массив экземпляров <see cref="T:System.Diagnostics.CounterCreationData" />, добавляемый в коллекцию.</param>
		/// <param name="index">Расположение, в которое добавляются новые экземпляры.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Количество элементов в коллекции <see cref="T:System.Diagnostics.CounterCreationDataCollection" /> превышает доступное пространство от индекса <paramref name="index" /> до конца массива назначения.</exception>
		// Token: 0x06001226 RID: 4646 RVA: 0x0004E442 File Offset: 0x0004C642
		public void CopyTo(CounterCreationData[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}

		/// <summary>Возвращает индекс объекта <see cref="T:System.Diagnostics.CounterCreationData" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Diagnostics.CounterCreationData" />, который требуется найти в коллекции.</param>
		/// <returns>Отсчитываемый от нуля индекс объекта <see cref="T:System.Diagnostics.CounterCreationData" />, если он найден в коллекции; в противном случае — значение, равное -1.</returns>
		// Token: 0x06001227 RID: 4647 RVA: 0x0004E451 File Offset: 0x0004C651
		public int IndexOf(CounterCreationData value)
		{
			return base.InnerList.IndexOf(value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Diagnostics.CounterCreationData" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс места вставки объекта <see cref="T:System.Diagnostics.CounterCreationData" />.</param>
		/// <param name="value">Объект <see cref="T:System.Diagnostics.CounterCreationData" /> для вставки в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Diagnostics.CounterCreationData" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="index" />больше числа элементов в коллекции.</exception>
		// Token: 0x06001228 RID: 4648 RVA: 0x0004E45F File Offset: 0x0004C65F
		public void Insert(int index, CounterCreationData value)
		{
			base.InnerList.Insert(index, value);
		}

		/// <summary>Проверяет указанный объект и определяет, принадлежит ли он к допустимому типу <see cref="T:System.Diagnostics.CounterCreationData" />.</summary>
		/// <param name="value">Тип объекта, подлежащего проверке.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Diagnostics.CounterCreationData" />.</exception>
		// Token: 0x06001229 RID: 4649 RVA: 0x0004E46E File Offset: 0x0004C66E
		protected override void OnValidate(object value)
		{
			if (!(value is CounterCreationData))
			{
				throw new NotSupportedException(Locale.GetText("You can only insert CounterCreationData objects into the collection"));
			}
		}

		/// <summary>Удаляет объект <see cref="T:System.Diagnostics.CounterCreationData" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Diagnostics.CounterCreationData" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Diagnostics.CounterCreationData" />.  
		/// -или- 
		///  Объект <paramref name="value" /> отсутствует в коллекции.</exception>
		// Token: 0x0600122A RID: 4650 RVA: 0x0004E488 File Offset: 0x0004C688
		public virtual void Remove(CounterCreationData value)
		{
			base.InnerList.Remove(value);
		}
	}
}
