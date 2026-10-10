using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Предоставляет потокобезопасный список объектов <see cref="T:System.Diagnostics.TraceListener" />.</summary>
	// Token: 0x02000232 RID: 562
	public class TraceListenerCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x060010BF RID: 4287 RVA: 0x00049171 File Offset: 0x00047371
		internal TraceListenerCollection()
		{
			this.list = new ArrayList(1);
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Diagnostics.TraceListener" /> с заданным индексом.</summary>
		/// <param name="i">Индекс извлекаемого из списка объекта <see cref="T:System.Diagnostics.TraceListener" /> (начиная с нуля).</param>
		/// <returns>Объект <see cref="T:System.Diagnostics.TraceListener" /> с заданным индексом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение — <see langword="null" />.</exception>
		// Token: 0x170002CB RID: 715
		public TraceListener this[int i]
		{
			get
			{
				return (TraceListener)this.list[i];
			}
			set
			{
				this.InitializeListener(value);
				this.list[i] = value;
			}
		}

		/// <summary>Возвращает первый объект <see cref="T:System.Diagnostics.TraceListener" /> в списке с указанным именем.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Diagnostics.TraceListener" />, который требуется извлечь из списка.</param>
		/// <returns>Первый объект <see cref="T:System.Diagnostics.TraceListener" /> в списке с заданным значением свойства <see cref="P:System.Diagnostics.TraceListener.Name" />. Этот элемент возвращает значение <see langword="null" />, если не найден ни один объект <see cref="T:System.Diagnostics.TraceListener" /> с данным именем.</returns>
		// Token: 0x170002CC RID: 716
		public TraceListener this[string name]
		{
			get
			{
				foreach (object obj in this)
				{
					TraceListener traceListener = (TraceListener)obj;
					if (traceListener.Name == name)
					{
						return traceListener;
					}
				}
				return null;
			}
		}

		/// <summary>Возвращает число прослушивателей в списке.</summary>
		/// <returns>Число прослушивателей в списке.</returns>
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00049214 File Offset: 0x00047414
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Добавляет в список объект <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="listener">Объект <see cref="T:System.Diagnostics.TraceListener" />, который необходимо добавить в список.</param>
		/// <returns>Позиция, в которую был вставлен новый прослушиватель.</returns>
		// Token: 0x060010C4 RID: 4292 RVA: 0x00049224 File Offset: 0x00047424
		public int Add(TraceListener listener)
		{
			this.InitializeListener(listener);
			object critSec = TraceInternal.critSec;
			int result;
			lock (critSec)
			{
				result = this.list.Add(listener);
			}
			return result;
		}

		/// <summary>Добавляет в список массив объектов <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.Diagnostics.TraceListener" />, добавляемый в список.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060010C5 RID: 4293 RVA: 0x00049274 File Offset: 0x00047474
		public void AddRange(TraceListener[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.Length; i++)
			{
				this.Add(value[i]);
			}
		}

		/// <summary>Добавляет в список содержимое другой коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">Другая коллекция <see cref="T:System.Diagnostics.TraceListenerCollection" />, содержимое которой добавляется в список.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060010C6 RID: 4294 RVA: 0x000492A8 File Offset: 0x000474A8
		public void AddRange(TraceListenerCollection value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				this.Add(value[i]);
			}
		}

		/// <summary>Удаляет все прослушиватели в списке.</summary>
		// Token: 0x060010C7 RID: 4295 RVA: 0x000492E4 File Offset: 0x000474E4
		public void Clear()
		{
			this.list = new ArrayList();
		}

		/// <summary>Проверяет наличие в списке указанного прослушивателя.</summary>
		/// <param name="listener">Объект <see cref="T:System.Diagnostics.TraceListener" />, который требуется найти в списке.</param>
		/// <returns>Значение <see langword="true" />, если прослушиватель есть в списке, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060010C8 RID: 4296 RVA: 0x000492F1 File Offset: 0x000474F1
		public bool Contains(TraceListener listener)
		{
			return ((IList)this).Contains(listener);
		}

		/// <summary>Копирует часть текущего списка <see cref="T:System.Diagnostics.TraceListenerCollection" /> в позицию указанного массива с заданным индексом.</summary>
		/// <param name="listeners">Массив типа <see cref="T:System.Array" />, в который копируются элементы.</param>
		/// <param name="index">Числовой индекс, с которого начинается копирование.</param>
		// Token: 0x060010C9 RID: 4297 RVA: 0x000492FA File Offset: 0x000474FA
		public void CopyTo(TraceListener[] listeners, int index)
		{
			((ICollection)this).CopyTo(listeners, index);
		}

		/// <summary>Возвращает перечислитель для данного списка.</summary>
		/// <returns>Перечислитель типа <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x060010CA RID: 4298 RVA: 0x00049304 File Offset: 0x00047504
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00049311 File Offset: 0x00047511
		internal void InitializeListener(TraceListener listener)
		{
			if (listener == null)
			{
				throw new ArgumentNullException("listener");
			}
			listener.IndentSize = TraceInternal.IndentSize;
			listener.IndentLevel = TraceInternal.IndentLevel;
		}

		/// <summary>Возвращает индекс заданного прослушивателя.</summary>
		/// <param name="listener">Объект <see cref="T:System.Diagnostics.TraceListener" />, который требуется найти в списке.</param>
		/// <returns>Индекс прослушивателя (если его можно найти в списке), в противном случае значение -1.</returns>
		// Token: 0x060010CC RID: 4300 RVA: 0x00049337 File Offset: 0x00047537
		public int IndexOf(TraceListener listener)
		{
			return ((IList)this).IndexOf(listener);
		}

		/// <summary>Вставляет прослушиватель по указанному индексу.</summary>
		/// <param name="index">Позиция в списке для вставки нового объекта <see cref="T:System.Diagnostics.TraceListener" />.</param>
		/// <param name="listener">Объект <see cref="T:System.Diagnostics.TraceListener" />, который требуется вставить в список.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> не является допустимым индексом в списке.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="listener" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060010CD RID: 4301 RVA: 0x00049340 File Offset: 0x00047540
		public void Insert(int index, TraceListener listener)
		{
			this.InitializeListener(listener);
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.Insert(index, listener);
			}
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Diagnostics.TraceListener" /> из коллекции.</summary>
		/// <param name="listener">Объект <see cref="T:System.Diagnostics.TraceListener" />, который нужно удалить из списка.</param>
		// Token: 0x060010CE RID: 4302 RVA: 0x00049390 File Offset: 0x00047590
		public void Remove(TraceListener listener)
		{
			((IList)this).Remove(listener);
		}

		/// <summary>Удаляет из коллекции первый объект <see cref="T:System.Diagnostics.TraceListener" /> с указанным именем.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Diagnostics.TraceListener" />, который требуется удалить из списка.</param>
		// Token: 0x060010CF RID: 4303 RVA: 0x0004939C File Offset: 0x0004759C
		public void Remove(string name)
		{
			TraceListener traceListener = this[name];
			if (traceListener != null)
			{
				((IList)this).Remove(traceListener);
			}
		}

		/// <summary>Удаляет из коллекции параметр <see cref="T:System.Diagnostics.TraceListener" /> с заданным индексом.</summary>
		/// <param name="index">Индекс объекта <see cref="T:System.Diagnostics.TraceListener" /> (начиная с нуля), который требуется удалить из списка.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> не является допустимым индексом в списке.</exception>
		// Token: 0x060010D0 RID: 4304 RVA: 0x000493BC File Offset: 0x000475BC
		public void RemoveAt(int index)
		{
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.RemoveAt(index);
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Diagnostics.TraceListener" /> по указанному индексу в коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс получаемого объекта <paramref name="value" />.</param>
		/// <returns>Параметр <see cref="T:System.Diagnostics.TraceListener" /> по указанному индексу.</returns>
		// Token: 0x170002CE RID: 718
		object IList.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				TraceListener traceListener = value as TraceListener;
				if (traceListener == null)
				{
					throw new ArgumentException(SR.GetString("Only TraceListeners can be added to a TraceListenerCollection."), "value");
				}
				this.InitializeListener(traceListener);
				this.list[index] = traceListener;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, доступна ли коллекция <see cref="T:System.Diagnostics.TraceListenerCollection" /> только для чтения.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00003062 File Offset: 0x00001262
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Diagnostics.TraceListenerCollection" /> фиксированный размер.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00003062 File Offset: 0x00001262
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Добавляет прослушиватель трассировки в коллекцию <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">Объект, добавляемый в коллекцию <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <returns>Позиция, в которую вставляется новый прослушиватель трассировки.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="value" /> не является объектом <see cref="T:System.Diagnostics.TraceListener" />.</exception>
		// Token: 0x060010D5 RID: 4309 RVA: 0x00049454 File Offset: 0x00047654
		int IList.Add(object value)
		{
			TraceListener traceListener = value as TraceListener;
			if (traceListener == null)
			{
				throw new ArgumentException(SR.GetString("Only TraceListeners can be added to a TraceListenerCollection."), "value");
			}
			this.InitializeListener(traceListener);
			object critSec = TraceInternal.critSec;
			int result;
			lock (critSec)
			{
				result = this.list.Add(value);
			}
			return result;
		}

		/// <summary>Определяет наличие указанного объекта в коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">Объект для поиска в <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Object" /> найден в <see cref="T:System.Diagnostics.TraceListenerCollection" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060010D6 RID: 4310 RVA: 0x000494C4 File Offset: 0x000476C4
		bool IList.Contains(object value)
		{
			return this.list.Contains(value);
		}

		/// <summary>Определяет индекс заданного объекта в коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">Объект для поиска в <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <returns>Индекс параметра <paramref name="value" />, если он найден в коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />; в противном случае — значение -1.</returns>
		// Token: 0x060010D7 RID: 4311 RVA: 0x000494D2 File Offset: 0x000476D2
		int IList.IndexOf(object value)
		{
			return this.list.IndexOf(value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Diagnostics.TraceListener" /> в указанное положение в коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Diagnostics.TraceListener" />, вставляемый в коллекцию <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Diagnostics.TraceListener" />.</exception>
		// Token: 0x060010D8 RID: 4312 RVA: 0x000494E0 File Offset: 0x000476E0
		void IList.Insert(int index, object value)
		{
			TraceListener traceListener = value as TraceListener;
			if (traceListener == null)
			{
				throw new ArgumentException(SR.GetString("Only TraceListeners can be added to a TraceListenerCollection."), "value");
			}
			this.InitializeListener(traceListener);
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.Insert(index, value);
			}
		}

		/// <summary>Удаляет объект из коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">Объект, который необходимо удалить из коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		// Token: 0x060010D9 RID: 4313 RVA: 0x0004954C File Offset: 0x0004774C
		void IList.Remove(object value)
		{
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.Remove(value);
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Diagnostics.TraceListenerCollection" />.</returns>
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x000075E1 File Offset: 0x000057E1
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0000390E File Offset: 0x00001B0E
		bool ICollection.IsSynchronized
		{
			get
			{
				return true;
			}
		}

		/// <summary>Копирует раздел текущей коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" /> в указанный массив объектов <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="array">Одномерный массив объектов <see cref="T:System.Diagnostics.TraceListener" />, в который копируются элементы коллекции <see cref="T:System.Diagnostics.TraceListenerCollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x060010DC RID: 4316 RVA: 0x00049594 File Offset: 0x00047794
		void ICollection.CopyTo(Array array, int index)
		{
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.CopyTo(array, index);
			}
		}

		// Token: 0x040009FB RID: 2555
		private ArrayList list;
	}
}
