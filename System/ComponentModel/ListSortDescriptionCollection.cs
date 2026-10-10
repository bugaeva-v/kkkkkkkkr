using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
	// Token: 0x020003D1 RID: 977
	public class ListSortDescriptionCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />.</summary>
		// Token: 0x06001F84 RID: 8068 RVA: 0x0006D608 File Offset: 0x0006B808
		public ListSortDescriptionCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр коллекции <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> с помощью указанного массива объектов <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <param name="sorts">Массив объектов <see cref="T:System.ComponentModel.ListSortDescription" /> ,которые будет содержать коллекция.</param>
		// Token: 0x06001F85 RID: 8069 RVA: 0x0006D61C File Offset: 0x0006B81C
		public ListSortDescriptionCollection(ListSortDescription[] sorts)
		{
			if (sorts != null)
			{
				for (int i = 0; i < sorts.Length; i++)
				{
					this._sorts.Add(sorts[i]);
				}
			}
		}

		/// <summary>Получает или задает указанный объект <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс объекта <see cref="T:System.ComponentModel.ListSortDescription" /> в коллекции, который необходимо возвратить или установить.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.ListSortDescription" /> с заданным индексом.</returns>
		/// <exception cref="T:System.InvalidOperationException">Элемент устанавливается в коллекции <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />, доступной только для чтения.</exception>
		// Token: 0x1700066B RID: 1643
		public ListSortDescription this[int index]
		{
			get
			{
				return (ListSortDescription)this._sorts[index];
			}
			set
			{
				throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
			}
		}

		/// <summary>Возвращает значение, указывающее, имеет ли коллекция фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0000390E File Offset: 0x00001B0E
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0000390E File Offset: 0x00001B0E
		bool IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает указанный объект <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс объекта <see cref="T:System.ComponentModel.ListSortDescription" />, возвращаемого из коллекции.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.ListSortDescription" /> с заданным индексом.</returns>
		// Token: 0x1700066E RID: 1646
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="value">Элемент для добавления в коллекцию.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F8C RID: 8076 RVA: 0x0006D66D File Offset: 0x0006B86D
		int IList.Add(object value)
		{
			throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
		}

		/// <summary>Удаляет все элементы из коллекции.</summary>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F8D RID: 8077 RVA: 0x0006D66D File Offset: 0x0006B86D
		void IList.Clear()
		{
			throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
		}

		/// <summary>Определяет, содержит ли <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Object" /> найден в коллекции; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F8E RID: 8078 RVA: 0x0006D682 File Offset: 0x0006B882
		public bool Contains(object value)
		{
			return ((IList)this._sorts).Contains(value);
		}

		/// <summary>Возвращает индекс заданного элемента в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для поиска в коллекции.</param>
		/// <returns>Индекс <paramref name="value" />, если он найден в списке; в противном случае — значение -1.</returns>
		// Token: 0x06001F8F RID: 8079 RVA: 0x0006D690 File Offset: 0x0006B890
		public int IndexOf(object value)
		{
			return ((IList)this._sorts).IndexOf(value);
		}

		/// <summary>Вставляет элемент в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс объекта <see cref="T:System.ComponentModel.ListSortDescription" /> в коллекции, который необходимо задать или получить.</param>
		/// <param name="value">Элемент, вставляемый в коллекцию.</param>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F90 RID: 8080 RVA: 0x0006D66D File Offset: 0x0006B86D
		void IList.Insert(int index, object value)
		{
			throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
		}

		/// <summary>Удаляет первое вхождение элемента из коллекции.</summary>
		/// <param name="value">Элемент, который нужно удалить из коллекции.</param>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F91 RID: 8081 RVA: 0x0006D66D File Offset: 0x0006B86D
		void IList.Remove(object value)
		{
			throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
		}

		/// <summary>Удаляет элемент из коллекции по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс объекта <see cref="T:System.ComponentModel.ListSortDescription" />, удаляемого из коллекции.</param>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F92 RID: 8082 RVA: 0x0006D66D File Offset: 0x0006B86D
		void IList.RemoveAt(int index)
		{
			throw new InvalidOperationException("Once a ListSortDescriptionCollection has been created it can't be modified.");
		}

		/// <summary>Возвращает количество элементов в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0006D69E File Offset: 0x0006B89E
		public int Count
		{
			get
			{
				return this._sorts.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции потокобезопасным.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x0000390E File Offset: 0x00001B0E
		bool ICollection.IsSynchronized
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает текущий экземпляр, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Текущий экземпляр коллекции <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />.</returns>
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x000075E1 File Offset: 0x000057E1
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Копирует содержимое коллекции в заданный массив, начиная с указанного индекса конечного массива.</summary>
		/// <param name="array">Конечный массив для копирования элементов коллекции.</param>
		/// <param name="index">Индекс конечного массива назначения, начиная с которого выполняется копирование.</param>
		// Token: 0x06001F96 RID: 8086 RVA: 0x0006D6AB File Offset: 0x0006B8AB
		public void CopyTo(Array array, int index)
		{
			this._sorts.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" />, который может использоваться для перебора коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06001F97 RID: 8087 RVA: 0x0006D6BA File Offset: 0x0006B8BA
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._sorts.GetEnumerator();
		}

		// Token: 0x04000F6D RID: 3949
		private ArrayList _sorts = new ArrayList();
	}
}
