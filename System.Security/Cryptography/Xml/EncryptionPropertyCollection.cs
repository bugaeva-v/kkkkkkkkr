using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет коллекцию классов <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, используемых в XML-шифровании. Этот класс не наследуется.</summary>
	// Token: 0x0200003B RID: 59
	public sealed class EncryptionPropertyCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		// Token: 0x06000176 RID: 374 RVA: 0x00007928 File Offset: 0x00005B28
		public EncryptionPropertyCollection()
		{
			this._props = new ArrayList();
		}

		/// <summary>Возвращает перечислитель, который перебирает элементы объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который позволяет перебирать элементы объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</returns>
		// Token: 0x06000177 RID: 375 RVA: 0x0000793B File Offset: 0x00005B3B
		public IEnumerator GetEnumerator()
		{
			return this._props.GetEnumerator();
		}

		/// <summary>Получает число элементов, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		/// <returns>Количество элементов, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</returns>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00007948 File Offset: 0x00005B48
		public int Count
		{
			get
			{
				return this._props.Count;
			}
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в список <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		/// <exception cref="T:System.ArgumentException">Параметром <paramref name="value" /> используется неверный тип объекта.</exception>
		// Token: 0x06000179 RID: 377 RVA: 0x00007955 File Offset: 0x00005B55
		int IList.Add(object value)
		{
			if (!(value is EncryptionProperty))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			return this._props.Add(value);
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> в объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, добавляемый в объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</param>
		/// <returns>Позиция, в которой вставляется новый элемент.</returns>
		// Token: 0x0600017A RID: 378 RVA: 0x0000797B File Offset: 0x00005B7B
		public int Add(EncryptionProperty value)
		{
			return this._props.Add(value);
		}

		/// <summary>Удаляет все элементы из объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		// Token: 0x0600017B RID: 379 RVA: 0x00007989 File Offset: 0x00005B89
		public void Clear()
		{
			this._props.Clear();
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Object" /> найден в <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметром <paramref name="value" /> используется неверный тип объекта.</exception>
		// Token: 0x0600017C RID: 380 RVA: 0x00007996 File Offset: 0x00005B96
		bool IList.Contains(object value)
		{
			if (!(value is EncryptionProperty))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			return this._props.Contains(value);
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> определенный объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, который необходимо найти в объекте <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> найден в объекте <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600017D RID: 381 RVA: 0x000079BC File Offset: 0x00005BBC
		public bool Contains(EncryptionProperty value)
		{
			return this._props.Contains(value);
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Индекс <paramref name="value" />, если он найден в списке; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentException">Параметром <paramref name="value" /> используется неверный тип объекта.</exception>
		// Token: 0x0600017E RID: 382 RVA: 0x000079CA File Offset: 0x00005BCA
		int IList.IndexOf(object value)
		{
			if (!(value is EncryptionProperty))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			return this._props.IndexOf(value);
		}

		/// <summary>Определяет индекс конкретного элемента в объекте <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, который необходимо найти в объекте <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</param>
		/// <returns>Индекс параметра <paramref name="value" />, если оно найдено в коллекции, в противном случае — -1.</returns>
		// Token: 0x0600017F RID: 383 RVA: 0x000079F0 File Offset: 0x00005BF0
		public int IndexOf(EncryptionProperty value)
		{
			return this._props.IndexOf(value);
		}

		/// <summary>Вставляет элемент в список <see cref="T:System.Collections.IList" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, вставляемый в <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметром <paramref name="value" /> используется неверный тип объекта.</exception>
		// Token: 0x06000180 RID: 384 RVA: 0x000079FE File Offset: 0x00005BFE
		void IList.Insert(int index, object value)
		{
			if (!(value is EncryptionProperty))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			this._props.Insert(index, value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> в объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> по указанной позиции.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, вставляемый в объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</param>
		// Token: 0x06000181 RID: 385 RVA: 0x00007A25 File Offset: 0x00005C25
		public void Insert(int index, EncryptionProperty value)
		{
			this._props.Insert(index, value);
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметром <paramref name="value" /> используется неверный тип объекта.</exception>
		// Token: 0x06000182 RID: 386 RVA: 0x00007A34 File Offset: 0x00005C34
		void IList.Remove(object value)
		{
			if (!(value is EncryptionProperty))
			{
				throw new ArgumentException("Type of input object is invalid.", "value");
			}
			this._props.Remove(value);
		}

		/// <summary>Удаляет первое вхождение указанного объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> из объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, удаляемый из объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</param>
		// Token: 0x06000183 RID: 387 RVA: 0x00007A5A File Offset: 0x00005C5A
		public void Remove(EncryptionProperty value)
		{
			this._props.Remove(value);
		}

		/// <summary>Удаляет объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> по указанному индексу.</summary>
		/// <param name="index">Индекс (отсчет с нуля) удаляемого объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</param>
		// Token: 0x06000184 RID: 388 RVA: 0x00007A68 File Offset: 0x00005C68
		public void RemoveAt(int index)
		{
			this._props.RemoveAt(index);
		}

		/// <summary>Получает значение, указывающее, имеет ли объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> фиксированный размер.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> имеет фиксированный размер, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00007A76 File Offset: 0x00005C76
		public bool IsFixedSize
		{
			get
			{
				return this._props.IsFixedSize;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00007A83 File Offset: 0x00005C83
		public bool IsReadOnly
		{
			get
			{
				return this._props.IsReadOnly;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, расположенный по заданному индексу.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, расположенный по указанному индексу.</returns>
		// Token: 0x06000187 RID: 391 RVA: 0x00007A90 File Offset: 0x00005C90
		public EncryptionProperty Item(int index)
		{
			return (EncryptionProperty)this._props[index];
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> по указанному индексу.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, расположенный по указанному индексу.</returns>
		// Token: 0x17000051 RID: 81
		[IndexerName("ItemOf")]
		public EncryptionProperty this[int index]
		{
			get
			{
				return (EncryptionProperty)((IList)this)[index];
			}
			set
			{
				((IList)this)[index] = value;
			}
		}

		/// <summary>Получает элемент с указанным индексом.</summary>
		/// <param name="index">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		// Token: 0x17000052 RID: 82
		object IList.this[int index]
		{
			get
			{
				return this._props[index];
			}
			set
			{
				if (!(value is EncryptionProperty))
				{
					throw new ArgumentException("Type of input object is invalid.", "value");
				}
				this._props[index] = value;
			}
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> в массив, начиная с определенного индекса.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x0600018C RID: 396 RVA: 0x00007AF0 File Offset: 0x00005CF0
		public void CopyTo(Array array, int index)
		{
			this._props.CopyTo(array, index);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> в массив объектов <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, начиная с указанного индекса в массиве.</summary>
		/// <param name="array">Одномерный массив объектов <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />, являющийся назначением элементов, копируемых из объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x0600018D RID: 397 RVA: 0x00007AF0 File Offset: 0x00005CF0
		public void CopyTo(EncryptionProperty[] array, int index)
		{
			this._props.CopyTo(array, index);
		}

		/// <summary>Возвращает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" />.</returns>
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00007AFF File Offset: 0x00005CFF
		public object SyncRoot
		{
			get
			{
				return this._props.SyncRoot;
			}
		}

		/// <summary>Получает значение, указывающее, является ли доступ к объекту <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к объекту <see cref="T:System.Security.Cryptography.Xml.EncryptionPropertyCollection" /> является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00007B0C File Offset: 0x00005D0C
		public bool IsSynchronized
		{
			get
			{
				return this._props.IsSynchronized;
			}
		}

		// Token: 0x040001A0 RID: 416
		private ArrayList _props;
	}
}
