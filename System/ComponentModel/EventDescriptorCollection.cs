using System;
using System.Collections;
using System.Collections.Generic;

namespace System.ComponentModel
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
	// Token: 0x020003A7 RID: 935
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя заданный массив объектов <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <param name="events">Массив типа <see cref="T:System.ComponentModel.EventDescriptor" />, предоставляющий события для данной коллекции.</param>
		// Token: 0x06001E8B RID: 7819 RVA: 0x0006C2E8 File Offset: 0x0006A4E8
		public EventDescriptorCollection(EventDescriptor[] events)
		{
			if (events == null)
			{
				this._events = Array.Empty<EventDescriptor>();
			}
			else
			{
				this._events = events;
				this.Count = events.Length;
			}
			this._eventsOwned = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя заданный массив объектов <see cref="T:System.ComponentModel.EventDescriptor" />. При необходимости для коллекции может быть установлен режим только для чтения.</summary>
		/// <param name="events">Массив типа <see cref="T:System.ComponentModel.EventDescriptor" />, предоставляющий события для данной коллекции.</param>
		/// <param name="readOnly">Значение <see langword="true" />, чтобы задать коллекцию только для чтения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001E8C RID: 7820 RVA: 0x0006C317 File Offset: 0x0006A517
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) : this(events)
		{
			this._readOnly = readOnly;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0006C327 File Offset: 0x0006A527
		private EventDescriptorCollection(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer)
		{
			this._eventsOwned = false;
			if (namedSort != null)
			{
				this._namedSort = (string[])namedSort.Clone();
			}
			this._comparer = comparer;
			this._events = events;
			this.Count = eventCount;
			this._needSort = true;
		}

		/// <summary>Возвращает число дескрипторов событий в коллекции.</summary>
		/// <returns>Число дескрипторов событий в коллекции.</returns>
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0006C367 File Offset: 0x0006A567
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0006C36F File Offset: 0x0006A56F
		public int Count { get; private set; }

		/// <summary>Получает или задает событие с указанным номером индекса.</summary>
		/// <param name="index">Индекс (отсчитываемый от нуля) возвращаемого или задаваемого дескриптора <see cref="T:System.ComponentModel.EventDescriptor" />.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptor" /> с заданным индексом.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Индекс <paramref name="index" /> не является допустимым для свойства <see cref="P:System.ComponentModel.EventDescriptorCollection.Item(System.Int32)" />.</exception>
		// Token: 0x1700062F RID: 1583
		public virtual EventDescriptor this[int index]
		{
			get
			{
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				this.EnsureEventsOwned();
				return this._events[index];
			}
		}

		/// <summary>Получает или задает событие с заданным именем.</summary>
		/// <param name="name">Имя возвращаемого или устанавливаемого дескриптора <see cref="T:System.ComponentModel.EventDescriptor" />.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> с указанным именем или значение <see langword="null" />, если событие не существует.</returns>
		// Token: 0x17000630 RID: 1584
		public virtual EventDescriptor this[string name]
		{
			get
			{
				return this.Find(name, false);
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.ComponentModel.EventDescriptor" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.EventDescriptor" />, добавляемый в коллекцию.</param>
		/// <returns>Позиция объекта <see cref="T:System.ComponentModel.EventDescriptor" /> в коллекции.</returns>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001E92 RID: 7826 RVA: 0x0006C3A4 File Offset: 0x0006A5A4
		public int Add(EventDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			EventDescriptor[] events = this._events;
			int count = this.Count;
			this.Count = count + 1;
			events[count] = value;
			return this.Count - 1;
		}

		/// <summary>Удаляет все объекты из коллекции.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001E93 RID: 7827 RVA: 0x0006C3EE File Offset: 0x0006A5EE
		public void Clear()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.Count = 0;
		}

		/// <summary>Возвращает значение, показывающее, содержит ли коллекция данный дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> .</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.EventDescriptor" />, который требуется найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный параметр <paramref name="value" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E94 RID: 7828 RVA: 0x0006C405 File Offset: 0x0006A605
		public bool Contains(EventDescriptor value)
		{
			return this.IndexOf(value) >= 0;
		}

		/// <summary>Копирует элементы коллекции в <see cref="T:System.Array" /> начиная с определенного индекса в <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является конечным массивом для элементов, скопированных из коллекции. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x06001E95 RID: 7829 RVA: 0x0006C414 File Offset: 0x0006A614
		void ICollection.CopyTo(Array array, int index)
		{
			this.EnsureEventsOwned();
			Array.Copy(this._events, 0, array, index, this.Count);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0006C430 File Offset: 0x0006A630
		private void EnsureEventsOwned()
		{
			if (!this._eventsOwned)
			{
				this._eventsOwned = true;
				if (this._events != null)
				{
					EventDescriptor[] array = new EventDescriptor[this.Count];
					Array.Copy(this._events, 0, array, 0, this.Count);
					this._events = array;
				}
			}
			if (this._needSort)
			{
				this._needSort = false;
				this.InternalSort(this._namedSort);
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0006C498 File Offset: 0x0006A698
		private void EnsureSize(int sizeNeeded)
		{
			if (sizeNeeded <= this._events.Length)
			{
				return;
			}
			if (this._events.Length == 0)
			{
				this.Count = 0;
				this._events = new EventDescriptor[sizeNeeded];
				return;
			}
			this.EnsureEventsOwned();
			EventDescriptor[] array = new EventDescriptor[Math.Max(sizeNeeded, this._events.Length * 2)];
			Array.Copy(this._events, 0, array, 0, this.Count);
			this._events = array;
		}

		/// <summary>Возвращает описание события с указанным именем в коллекции.</summary>
		/// <param name="name">Имя события, извлекаемого из коллекции.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, если требуется игнорировать событие; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> с указанным именем или значение <see langword="null" />, если событие не существует.</returns>
		// Token: 0x06001E98 RID: 7832 RVA: 0x0006C508 File Offset: 0x0006A708
		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			EventDescriptor result = null;
			if (ignoreCase)
			{
				for (int i = 0; i < this.Count; i++)
				{
					if (string.Equals(this._events[i].Name, name, StringComparison.OrdinalIgnoreCase))
					{
						result = this._events[i];
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < this.Count; j++)
				{
					if (string.Equals(this._events[j].Name, name, StringComparison.Ordinal))
					{
						result = this._events[j];
						break;
					}
				}
			}
			return result;
		}

		/// <summary>Возвращает индекс данного дескриптора <see cref="T:System.ComponentModel.EventDescriptor" /> .</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.EventDescriptor" />, который требуется найти в коллекции.</param>
		/// <returns>Индекс данного дескриптора <see cref="T:System.ComponentModel.EventDescriptor" /> в коллекции.</returns>
		// Token: 0x06001E99 RID: 7833 RVA: 0x0006C581 File Offset: 0x0006A781
		public int IndexOf(EventDescriptor value)
		{
			return Array.IndexOf<EventDescriptor>(this._events, value, 0, this.Count);
		}

		/// <summary>Вставляет объект <see cref="T:System.ComponentModel.EventDescriptor" /> в коллекцию, используя указанный индекс.</summary>
		/// <param name="index">Индекс в коллекции, используемый для вставки параметра <paramref name="value" />.</param>
		/// <param name="value">Дескриптор <see cref="T:System.ComponentModel.EventDescriptor" />, вставляемый в коллекцию.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001E9A RID: 7834 RVA: 0x0006C598 File Offset: 0x0006A798
		public void Insert(int index, EventDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			if (index < this.Count)
			{
				Array.Copy(this._events, index, this._events, index + 1, this.Count - index);
			}
			this._events[index] = value;
			int count = this.Count;
			this.Count = count + 1;
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.ComponentModel.EventDescriptor" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.EventDescriptor" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001E9B RID: 7835 RVA: 0x0006C600 File Offset: 0x0006A800
		public void Remove(EventDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			int num = this.IndexOf(value);
			if (num != -1)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Удаляет из коллекции дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> с заданным индексом.</summary>
		/// <param name="index">Индекс удаляемого объекта <see cref="T:System.ComponentModel.EventDescriptor" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001E9C RID: 7836 RVA: 0x0006C630 File Offset: 0x0006A830
		public void RemoveAt(int index)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			if (index < this.Count - 1)
			{
				Array.Copy(this._events, index + 1, this._events, index, this.Count - index - 1);
			}
			this._events[this.Count - 1] = null;
			int count = this.Count;
			this.Count = count - 1;
		}

		/// <summary>Возвращает перечислитель для данной коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</summary>
		/// <returns>Перечислитель, реализующий <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06001E9D RID: 7837 RVA: 0x0006C695 File Offset: 0x0006A895
		public IEnumerator GetEnumerator()
		{
			if (this._events.Length == this.Count)
			{
				return this._events.GetEnumerator();
			}
			return new EventDescriptorCollection.ArraySubsetEnumerator(this._events, this.Count);
		}

		/// <summary>Выполняет сортировку элементов этой коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя установленный для этой коллекции по умолчанию порядок сортировки, обычно являющийся алфавитным.</summary>
		/// <returns>Новый объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		// Token: 0x06001E9E RID: 7838 RVA: 0x0006C6C4 File Offset: 0x0006A8C4
		public virtual EventDescriptorCollection Sort()
		{
			return new EventDescriptorCollection(this._events, this.Count, this._namedSort, this._comparer);
		}

		/// <summary>Выполняет сортировку элементов этой коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя заданный порядок сортировки.</summary>
		/// <param name="names">Массив строк, описывающий порядок сортировки объектов <see cref="T:System.ComponentModel.EventDescriptor" /> в коллекции.</param>
		/// <returns>Новый объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		// Token: 0x06001E9F RID: 7839 RVA: 0x0006C6E3 File Offset: 0x0006A8E3
		public virtual EventDescriptorCollection Sort(string[] names)
		{
			return new EventDescriptorCollection(this._events, this.Count, names, this._comparer);
		}

		/// <summary>Выполняет сортировку элементов этой коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя заданный порядок сортировки и средство сравнения <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="names">Массив строк, описывающий порядок сортировки объектов <see cref="T:System.ComponentModel.EventDescriptor" /> в коллекции.</param>
		/// <param name="comparer">Объект <see cref="T:System.Collections.IComparer" />, используемый для сортировки объектов <see cref="T:System.ComponentModel.EventDescriptor" /> в этой коллекции.</param>
		/// <returns>Новый объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		// Token: 0x06001EA0 RID: 7840 RVA: 0x0006C6FD File Offset: 0x0006A8FD
		public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			return new EventDescriptorCollection(this._events, this.Count, names, comparer);
		}

		/// <summary>Выполняет сортировку элементов этой коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя указанный объект <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="comparer">Объект <see cref="T:System.Collections.IComparer" />, используемый для сортировки объектов <see cref="T:System.ComponentModel.EventDescriptor" /> в этой коллекции.</param>
		/// <returns>Новый объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		// Token: 0x06001EA1 RID: 7841 RVA: 0x0006C712 File Offset: 0x0006A912
		public virtual EventDescriptorCollection Sort(IComparer comparer)
		{
			return new EventDescriptorCollection(this._events, this.Count, this._namedSort, comparer);
		}

		/// <summary>Выполняет сортировку элементов этой коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />. Сначала выполняется сортировка в указанном порядке, затем используется порядок сортировки по умолчанию, обычно являющийся алфавитным,.</summary>
		/// <param name="names">Массив строк, описывающий порядок сортировки для объектов <see cref="T:System.ComponentModel.EventDescriptor" /> в этой коллекции.</param>
		// Token: 0x06001EA2 RID: 7842 RVA: 0x0006C72C File Offset: 0x0006A92C
		protected void InternalSort(string[] names)
		{
			if (this._events.Length == 0)
			{
				return;
			}
			this.InternalSort(this._comparer);
			if (names != null && names.Length != 0)
			{
				List<EventDescriptor> list = new List<EventDescriptor>(this._events);
				int num = 0;
				int num2 = this._events.Length;
				for (int i = 0; i < names.Length; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						EventDescriptor eventDescriptor = list[j];
						if (eventDescriptor != null && eventDescriptor.Name.Equals(names[i]))
						{
							this._events[num++] = eventDescriptor;
							list[j] = null;
							break;
						}
					}
				}
				for (int k = 0; k < num2; k++)
				{
					if (list[k] != null)
					{
						this._events[num++] = list[k];
					}
				}
			}
		}

		/// <summary>Выполняет сортировку элементов этой коллекции <see cref="T:System.ComponentModel.EventDescriptorCollection" />, используя указанный объект <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="sorter">Средство сравнения, которое нужно использовать для сортировки объектов <see cref="T:System.ComponentModel.EventDescriptor" /> в данной коллекции.</param>
		// Token: 0x06001EA3 RID: 7843 RVA: 0x0006C7F7 File Offset: 0x0006A9F7
		protected void InternalSort(IComparer sorter)
		{
			if (sorter == null)
			{
				TypeDescriptor.SortDescriptorArray(this);
				return;
			}
			Array.Sort(this._events, sorter);
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным.</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к коллекции синхронизирован; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x00002F6A File Offset: 0x0000116A
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает количество элементов, содержащихся в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0006C80F File Offset: 0x0006AA0F
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06001EA7 RID: 7847 RVA: 0x0006C817 File Offset: 0x0006AA17
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
		// Token: 0x17000634 RID: 1588
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException();
				}
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				this.EnsureEventsOwned();
				this._events[index] = (EventDescriptor)value;
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="value">Параметр <see cref="T:System.Object" /> для добавления в коллекцию.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001EAA RID: 7850 RVA: 0x0006C85B File Offset: 0x0006AA5B
		int IList.Add(object value)
		{
			return this.Add((EventDescriptor)value);
		}

		/// <summary>Определяет, содержит ли коллекция указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Object" /> найден в коллекции; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001EAB RID: 7851 RVA: 0x0006C869 File Offset: 0x0006AA69
		bool IList.Contains(object value)
		{
			return this.Contains((EventDescriptor)value);
		}

		/// <summary>Удаляет из коллекции все элементы.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001EAC RID: 7852 RVA: 0x0006C877 File Offset: 0x0006AA77
		void IList.Clear()
		{
			this.Clear();
		}

		/// <summary>Определяет индекс определенного элемента в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для поиска в коллекции.</param>
		/// <returns>Индекс <paramref name="value" />, если он найден в списке; в противном случае — значение -1.</returns>
		// Token: 0x06001EAD RID: 7853 RVA: 0x0006C87F File Offset: 0x0006AA7F
		int IList.IndexOf(object value)
		{
			return this.IndexOf((EventDescriptor)value);
		}

		/// <summary>Вставляет элемент в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> для вставки в коллекцию.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001EAE RID: 7854 RVA: 0x0006C88D File Offset: 0x0006AA8D
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (EventDescriptor)value);
		}

		/// <summary>Удаляет первое вхождение конкретного объекта из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001EAF RID: 7855 RVA: 0x0006C89C File Offset: 0x0006AA9C
		void IList.Remove(object value)
		{
			this.Remove((EventDescriptor)value);
		}

		/// <summary>Удаляет элемент с указанным индексом.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06001EB0 RID: 7856 RVA: 0x0006C8AA File Offset: 0x0006AAAA
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция доступна только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x0006C8B3 File Offset: 0x0006AAB3
		bool IList.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Возвращает значение, указывающее, имеет ли коллекция фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0006C8B3 File Offset: 0x0006AAB3
		bool IList.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x04000F39 RID: 3897
		private EventDescriptor[] _events;

		// Token: 0x04000F3A RID: 3898
		private string[] _namedSort;

		// Token: 0x04000F3B RID: 3899
		private readonly IComparer _comparer;

		// Token: 0x04000F3C RID: 3900
		private bool _eventsOwned;

		// Token: 0x04000F3D RID: 3901
		private bool _needSort;

		// Token: 0x04000F3E RID: 3902
		private readonly bool _readOnly;

		/// <summary>Задает использование пустой коллекции вместо создания новой коллекции, не содержащей элементов. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000F3F RID: 3903
		public static readonly EventDescriptorCollection Empty = new EventDescriptorCollection(null, true);

		// Token: 0x020003A8 RID: 936
		private class ArraySubsetEnumerator : IEnumerator
		{
			// Token: 0x06001EB4 RID: 7860 RVA: 0x0006C8C9 File Offset: 0x0006AAC9
			public ArraySubsetEnumerator(Array array, int count)
			{
				this._array = array;
				this._total = count;
				this._current = -1;
			}

			// Token: 0x06001EB5 RID: 7861 RVA: 0x0006C8E6 File Offset: 0x0006AAE6
			public bool MoveNext()
			{
				if (this._current < this._total - 1)
				{
					this._current++;
					return true;
				}
				return false;
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x0006C909 File Offset: 0x0006AB09
			public void Reset()
			{
				this._current = -1;
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x0006C912 File Offset: 0x0006AB12
			public object Current
			{
				get
				{
					if (this._current == -1)
					{
						throw new InvalidOperationException();
					}
					return this._array.GetValue(this._current);
				}
			}

			// Token: 0x04000F41 RID: 3905
			private readonly Array _array;

			// Token: 0x04000F42 RID: 3906
			private readonly int _total;

			// Token: 0x04000F43 RID: 3907
			private int _current;
		}
	}
}
