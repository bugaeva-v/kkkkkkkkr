using System;
using System.Collections;
using System.Collections.Generic;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeNamespaceImport" />.</summary>
	// Token: 0x0200031F RID: 799
	[Serializable]
	public class CodeNamespaceImportCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeNamespaceImport" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeNamespaceImport" /> на каждом допустимом индексе.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000517 RID: 1303
		public CodeNamespaceImport this[int index]
		{
			get
			{
				return (CodeNamespaceImport)this._data[index];
			}
			set
			{
				this._data[index] = value;
				this.SyncKeys();
			}
		}

		/// <summary>Получает число пространств имен в коллекции.</summary>
		/// <returns>Число пространств имен в коллекции.</returns>
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0006075E File Offset: 0x0005E95E
		public int Count
		{
			get
			{
				return this._data.Count;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.  Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00003062 File Offset: 0x00001262
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.  Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00003062 File Offset: 0x00001262
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.CodeDom.CodeNamespaceImport" /> в коллекцию.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeNamespaceImport" /> для добавления в коллекцию.</param>
		// Token: 0x0600196F RID: 6511 RVA: 0x0006076B File Offset: 0x0005E96B
		public void Add(CodeNamespaceImport value)
		{
			if (!this._keys.ContainsKey(value.Namespace))
			{
				this._keys[value.Namespace] = value;
				this._data.Add(value);
			}
		}

		/// <summary>Добавляет набор объектов <see cref="T:System.CodeDom.CodeNamespaceImport" /> в коллекцию.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeNamespaceImport" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x06001970 RID: 6512 RVA: 0x000607A0 File Offset: 0x0005E9A0
		public void AddRange(CodeNamespaceImport[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			foreach (CodeNamespaceImport value2 in value)
			{
				this.Add(value2);
			}
		}

		/// <summary>Очищает коллекцию элементов.</summary>
		// Token: 0x06001971 RID: 6513 RVA: 0x000607D6 File Offset: 0x0005E9D6
		public void Clear()
		{
			this._data.Clear();
			this._keys.Clear();
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000607F0 File Offset: 0x0005E9F0
		private void SyncKeys()
		{
			this._keys.Clear();
			foreach (object obj in this._data)
			{
				CodeNamespaceImport codeNamespaceImport = (CodeNamespaceImport)obj;
				this._keys[codeNamespaceImport.Namespace] = codeNamespaceImport;
			}
		}

		/// <summary>Получает перечислитель, который перечисляет члены коллекции.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IEnumerator" />, указывающий элементы коллекции.</returns>
		// Token: 0x06001973 RID: 6515 RVA: 0x00060860 File Offset: 0x0005EA60
		public IEnumerator GetEnumerator()
		{
			return this._data.GetEnumerator();
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		// Token: 0x1700051B RID: 1307
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (CodeNamespaceImport)value;
				this.SyncKeys();
			}
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0006088B File Offset: 0x0005EA8B
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />. Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  Данное свойство всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x00002F6A File Offset: 0x0000116A
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.ICollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x06001979 RID: 6521 RVA: 0x00060893 File Offset: 0x0005EA93
		void ICollection.CopyTo(Array array, int index)
		{
			this._data.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x0600197A RID: 6522 RVA: 0x000608A2 File Offset: 0x0005EAA2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Добавляет объект в <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в список <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Позиция, в которой был вставлен новый элемент.</returns>
		// Token: 0x0600197B RID: 6523 RVA: 0x000608AA File Offset: 0x0005EAAA
		int IList.Add(object value)
		{
			return this._data.Add((CodeNamespaceImport)value);
		}

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.IList" />.</summary>
		// Token: 0x0600197C RID: 6524 RVA: 0x000608BD File Offset: 0x0005EABD
		void IList.Clear()
		{
			this.Clear();
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Значение <see langword="true" />, если значение присутствует в списке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600197D RID: 6525 RVA: 0x000608C5 File Offset: 0x0005EAC5
		bool IList.Contains(object value)
		{
			return this._data.Contains(value);
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Индекс <paramref name="value" />, если он существует в коллекции; в противном случае — значение -1.</returns>
		// Token: 0x0600197E RID: 6526 RVA: 0x000608D3 File Offset: 0x0005EAD3
		int IList.IndexOf(object value)
		{
			return this._data.IndexOf((CodeNamespaceImport)value);
		}

		/// <summary>Вставляет элемент <see cref="T:System.Collections.IList" /> на указанную позицию.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, вставляемый в <see cref="T:System.Collections.IList" />.</param>
		// Token: 0x0600197F RID: 6527 RVA: 0x000608E6 File Offset: 0x0005EAE6
		void IList.Insert(int index, object value)
		{
			this._data.Insert(index, (CodeNamespaceImport)value);
			this.SyncKeys();
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.IList" />.</param>
		// Token: 0x06001980 RID: 6528 RVA: 0x00060900 File Offset: 0x0005EB00
		void IList.Remove(object value)
		{
			this._data.Remove((CodeNamespaceImport)value);
			this.SyncKeys();
		}

		/// <summary>Удаляет элемент списка <see cref="T:System.Collections.IList" /> с указанным индексом.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		// Token: 0x06001981 RID: 6529 RVA: 0x00060919 File Offset: 0x0005EB19
		void IList.RemoveAt(int index)
		{
			this._data.RemoveAt(index);
			this.SyncKeys();
		}

		// Token: 0x04000DC3 RID: 3523
		private readonly ArrayList _data = new ArrayList();

		// Token: 0x04000DC4 RID: 3524
		private readonly Dictionary<string, CodeNamespaceImport> _keys = new Dictionary<string, CodeNamespaceImport>(StringComparer.OrdinalIgnoreCase);
	}
}
