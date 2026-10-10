using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет элемент <see langword="&lt;ReferenceList&gt;" />, который используется при шифровании XML. Этот класс не наследуется.</summary>
	// Token: 0x02000052 RID: 82
	public sealed class ReferenceList : IList, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		// Token: 0x0600021D RID: 541 RVA: 0x00009CB4 File Offset: 0x00007EB4
		public ReferenceList()
		{
			this._references = new ArrayList();
		}

		/// <summary>Возвращает перечислитель, перебирающий элементы коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который можно использовать для перебора элементов коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</returns>
		// Token: 0x0600021E RID: 542 RVA: 0x00009CC7 File Offset: 0x00007EC7
		public IEnumerator GetEnumerator()
		{
			return this._references.GetEnumerator();
		}

		/// <summary>Получает число элементов, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <returns>Количество элементов, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</returns>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00009CD4 File Offset: 0x00007ED4
		public int Count
		{
			get
			{
				return this._references.Count;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> в коллекцию <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />, добавляемый в коллекцию <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</param>
		/// <returns>Позиция, в которой был вставлен новый элемент.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="value" /> не является объектом <see cref="T:System.Security.Cryptography.Xml.DataReference" />.  
		/// -или- 
		/// Параметр <paramref name="value" /> не является объектом <see cref="T:System.Security.Cryptography.Xml.KeyReference" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000220 RID: 544 RVA: 0x00009CE1 File Offset: 0x00007EE1
		public int Add(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(value is DataReference) && !(value is KeyReference))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			return this._references.Add(value);
		}

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		// Token: 0x06000221 RID: 545 RVA: 0x00009D1D File Offset: 0x00007F1D
		public void Clear()
		{
			this._references.Clear();
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Security.Cryptography.Xml.ReferenceList" /> определенный объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />, который требуется найти в коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> найден в коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000222 RID: 546 RVA: 0x00009D2A File Offset: 0x00007F2A
		public bool Contains(object value)
		{
			return this._references.Contains(value);
		}

		/// <summary>Определяет индекс указанного элемента в коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />, который требуется найти в коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</param>
		/// <returns>Индекс параметра <paramref name="value" />, если оно найдено в коллекции, в противном случае — -1.</returns>
		// Token: 0x06000223 RID: 547 RVA: 0x00009D38 File Offset: 0x00007F38
		public int IndexOf(object value)
		{
			return this._references.IndexOf(value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> в указанную позицию коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />, вставляемый в коллекцию <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="value" /> не является объектом <see cref="T:System.Security.Cryptography.Xml.DataReference" />.  
		/// -или- 
		/// Параметр <paramref name="value" /> не является объектом <see cref="T:System.Security.Cryptography.Xml.KeyReference" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000224 RID: 548 RVA: 0x00009D46 File Offset: 0x00007F46
		public void Insert(int index, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(value is DataReference) && !(value is KeyReference))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			this._references.Insert(index, value);
		}

		/// <summary>Удаляет первое вхождение определенного объекта <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> из коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />, удаляемый из коллекции <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</param>
		// Token: 0x06000225 RID: 549 RVA: 0x00009D83 File Offset: 0x00007F83
		public void Remove(object value)
		{
			this._references.Remove(value);
		}

		/// <summary>Удаляет объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого объекта <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />.</param>
		// Token: 0x06000226 RID: 550 RVA: 0x00009D91 File Offset: 0x00007F91
		public void RemoveAt(int index)
		{
			this._references.RemoveAt(index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> по указанному индексу.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />, расположенный по указанному индексу.</returns>
		// Token: 0x06000227 RID: 551 RVA: 0x00009D9F File Offset: 0x00007F9F
		public EncryptedReference Item(int index)
		{
			return (EncryptedReference)this._references[index];
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> по указанному индексу.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Security.Cryptography.Xml.DataReference" /> или <see cref="T:System.Security.Cryptography.Xml.KeyReference" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />, расположенный по указанному индексу.</returns>
		// Token: 0x1700006D RID: 109
		[IndexerName("ItemOf")]
		public EncryptedReference this[int index]
		{
			get
			{
				return this.Item(index);
			}
			set
			{
				((IList)this)[index] = value;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.IList.Item(System.Int32)" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x1700006E RID: 110
		object IList.this[int index]
		{
			get
			{
				return this._references[index];
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!(value is DataReference) && !(value is KeyReference))
				{
					throw new ArgumentException("Type of input object is invalid.", "value");
				}
				this._references[index] = value;
			}
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Security.Cryptography.Xml.ReferenceList" /> в массив, начиная с указанного индекса массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из объекта <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x0600022C RID: 556 RVA: 0x00009E06 File Offset: 0x00008006
		public void CopyTo(Array array, int index)
		{
			this._references.CopyTo(array, index);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00009E15 File Offset: 0x00008015
		bool IList.IsFixedSize
		{
			get
			{
				return this._references.IsFixedSize;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.IList.IsReadOnly" />.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00009E22 File Offset: 0x00008022
		bool IList.IsReadOnly
		{
			get
			{
				return this._references.IsReadOnly;
			}
		}

		/// <summary>Возвращает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.Xml.ReferenceList" />.</returns>
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00009E2F File Offset: 0x0000802F
		public object SyncRoot
		{
			get
			{
				return this._references.SyncRoot;
			}
		}

		/// <summary>Получает значение, указывающее, является ли доступ к объекту <see cref="T:System.Security.Cryptography.Xml.ReferenceList" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к объекту <see cref="T:System.Security.Cryptography.Xml.ReferenceList" /> является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00009E3C File Offset: 0x0000803C
		public bool IsSynchronized
		{
			get
			{
				return this._references.IsSynchronized;
			}
		}

		// Token: 0x040001C4 RID: 452
		private ArrayList _references;
	}
}
