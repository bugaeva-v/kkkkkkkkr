using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Generic
{
	/// <summary>Представляет двунаправленный список.</summary>
	/// <typeparam name="T">Указывает тип элементов связанного списка.</typeparam>
	// Token: 0x020004CA RID: 1226
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		/// <summary>Инициализирует новый экземпляр пустого класса <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		// Token: 0x0600279F RID: 10143 RVA: 0x0000219B File Offset: 0x0000039B
		public LinkedList()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.LinkedList`1" />, содержащий элементы, скопированные из указанного класса <see cref="T:System.Collections.IEnumerable" />, и обладающий емкостью, достаточной для того, чтобы вместить количество скопированных элементов.</summary>
		/// <param name="collection">Объект <see cref="T:System.Collections.IEnumerable" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="collection" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027A0 RID: 10144 RVA: 0x000892D8 File Offset: 0x000874D8
		public LinkedList(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			foreach (T value in collection)
			{
				this.AddLast(value);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.LinkedList`1" />, сериализуемый с заданными объектами <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации коллекции <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с коллекцией <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		// Token: 0x060027A1 RID: 10145 RVA: 0x00089338 File Offset: 0x00087538
		protected LinkedList(SerializationInfo info, StreamingContext context)
		{
			this._siInfo = info;
		}

		/// <summary>Получает число узлов, которое в действительности хранится в <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <returns>Число узлов, которое в действительности хранится в <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x00089347 File Offset: 0x00087547
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		/// <summary>Получает первый узел объекта <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <returns>Первый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" /> объекта <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x0008934F File Offset: 0x0008754F
		public LinkedListNode<T> First
		{
			get
			{
				return this.head;
			}
		}

		/// <summary>Получает последний узел объекта <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <returns>Последний узел <see cref="T:System.Collections.Generic.LinkedListNode`1" /> объекта <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x00089357 File Offset: 0x00087557
		public LinkedListNode<T> Last
		{
			get
			{
				if (this.head != null)
				{
					return this.head.prev;
				}
				return null;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x0008936E File Offset: 0x0008756E
		void ICollection<!0>.Add(T value)
		{
			this.AddLast(value);
		}

		/// <summary>Добавляет новый узел, содержащий заданное значение, после заданного существующего узла в <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, после которого следует вставить новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий <paramref name="value" />.</param>
		/// <param name="value">Значение, добавляемое в <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> не находится в текущем объекте <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027A7 RID: 10151 RVA: 0x00089378 File Offset: 0x00087578
		public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
		{
			this.ValidateNode(node);
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(node.list, value);
			this.InternalInsertNodeBefore(node.next, linkedListNode);
			return linkedListNode;
		}

		/// <summary>Добавляет заданный новый узел после заданного существующего узла в <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">Узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, после которого следует вставить узел <paramref name="newNode" />.</param>
		/// <param name="newNode">Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, добавляемый к <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="newNode" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> не находится в текущем объекте <see cref="T:System.Collections.Generic.LinkedList`1" />.  
		///
		/// или - 
		/// Параметр <paramref name="newNode" /> принадлежит другому объекту <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027A8 RID: 10152 RVA: 0x000893A7 File Offset: 0x000875A7
		public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			this.ValidateNode(node);
			this.ValidateNewNode(newNode);
			this.InternalInsertNodeBefore(node.next, newNode);
			newNode.list = this;
		}

		/// <summary>Добавляет новый узел, содержащий заданное значение, перед заданным существующим узлом в <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, перед которым следует вставить новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий <paramref name="value" />.</param>
		/// <param name="value">Значение, добавляемое в <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> не находится в текущем объекте <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027A9 RID: 10153 RVA: 0x000893CC File Offset: 0x000875CC
		public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
		{
			this.ValidateNode(node);
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(node.list, value);
			this.InternalInsertNodeBefore(node, linkedListNode);
			if (node == this.head)
			{
				this.head = linkedListNode;
			}
			return linkedListNode;
		}

		/// <summary>Добавляет заданный новый узел перед заданным существующим узлом в <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">Узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, перед которым следует вставить узел <paramref name="newNode" />.</param>
		/// <param name="newNode">Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, добавляемый к <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="newNode" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> не находится в текущем объекте <see cref="T:System.Collections.Generic.LinkedList`1" />.  
		///
		/// или - 
		/// Параметр <paramref name="newNode" /> принадлежит другому объекту <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027AA RID: 10154 RVA: 0x00089406 File Offset: 0x00087606
		public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			this.ValidateNode(node);
			this.ValidateNewNode(newNode);
			this.InternalInsertNodeBefore(node, newNode);
			newNode.list = this;
			if (node == this.head)
			{
				this.head = newNode;
			}
		}

		/// <summary>Добавляет новый узел, содержащий заданное значение, в начало <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="value">Значение, добавляемое в начало <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий <paramref name="value" />.</returns>
		// Token: 0x060027AB RID: 10155 RVA: 0x00089438 File Offset: 0x00087638
		public LinkedListNode<T> AddFirst(T value)
		{
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(this, value);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(linkedListNode);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, linkedListNode);
				this.head = linkedListNode;
			}
			return linkedListNode;
		}

		/// <summary>Добавляет заданный новый узел в начало <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, добавляемый в начало <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> принадлежит другому объекту <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027AC RID: 10156 RVA: 0x00089473 File Offset: 0x00087673
		public void AddFirst(LinkedListNode<T> node)
		{
			this.ValidateNewNode(node);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(node);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, node);
				this.head = node;
			}
			node.list = this;
		}

		/// <summary>Добавляет новый узел, содержащий заданное значение, в конец <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="value">Значение, добавляемое в конец <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий <paramref name="value" />.</returns>
		// Token: 0x060027AD RID: 10157 RVA: 0x000894A8 File Offset: 0x000876A8
		public LinkedListNode<T> AddLast(T value)
		{
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(this, value);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(linkedListNode);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, linkedListNode);
			}
			return linkedListNode;
		}

		/// <summary>Добавляет заданный новый узел в конец <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">Новый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, добавляемый в конец <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> принадлежит другому объекту <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027AE RID: 10158 RVA: 0x000894DC File Offset: 0x000876DC
		public void AddLast(LinkedListNode<T> node)
		{
			this.ValidateNewNode(node);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(node);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, node);
			}
			node.list = this;
		}

		/// <summary>Удаляет все узлы из <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		// Token: 0x060027AF RID: 10159 RVA: 0x0008950C File Offset: 0x0008770C
		public void Clear()
		{
			LinkedListNode<T> next = this.head;
			while (next != null)
			{
				LinkedListNode<T> linkedListNode = next;
				next = next.Next;
				linkedListNode.Invalidate();
			}
			this.head = null;
			this.count = 0;
			this.version++;
		}

		/// <summary>Определяет, принадлежит ли значение объекту <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Generic.LinkedList`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> найден в коллекции <see cref="T:System.Collections.Generic.LinkedList`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060027B0 RID: 10160 RVA: 0x00089550 File Offset: 0x00087750
		public bool Contains(T value)
		{
			return this.Find(value) != null;
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.Generic.LinkedList`1" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.LinkedList`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.LinkedList`1" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x060027B1 RID: 10161 RVA: 0x0008955C File Offset: 0x0008775C
		public void CopyTo(T[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, "Must be less than or equal to the size of the collection.");
			}
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException("Insufficient space in the target location to copy the information.");
			}
			LinkedListNode<T> next = this.head;
			if (next != null)
			{
				do
				{
					array[index++] = next.item;
					next = next.next;
				}
				while (next != this.head);
			}
		}

		/// <summary>Находит первый узел, содержащий указанное значение.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Первый узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий указанное значение, если узел найден; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x060027B2 RID: 10162 RVA: 0x000895F4 File Offset: 0x000877F4
		public LinkedListNode<T> Find(T value)
		{
			LinkedListNode<T> next = this.head;
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			if (next != null)
			{
				if (value != null)
				{
					while (!@default.Equals(next.item, value))
					{
						next = next.next;
						if (next == this.head)
						{
							goto IL_5A;
						}
					}
					return next;
				}
				while (next.item != null)
				{
					next = next.next;
					if (next == this.head)
					{
						goto IL_5A;
					}
				}
				return next;
			}
			IL_5A:
			return null;
		}

		/// <summary>Находит последний узел, содержащий указанное значение.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Последний узел <see cref="T:System.Collections.Generic.LinkedListNode`1" />, содержащий указанное значение, если узел найден; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x060027B3 RID: 10163 RVA: 0x0008965C File Offset: 0x0008785C
		public LinkedListNode<T> FindLast(T value)
		{
			if (this.head == null)
			{
				return null;
			}
			LinkedListNode<T> prev = this.head.prev;
			LinkedListNode<T> linkedListNode = prev;
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			if (linkedListNode != null)
			{
				if (value != null)
				{
					while (!@default.Equals(linkedListNode.item, value))
					{
						linkedListNode = linkedListNode.prev;
						if (linkedListNode == prev)
						{
							goto IL_61;
						}
					}
					return linkedListNode;
				}
				while (linkedListNode.item != null)
				{
					linkedListNode = linkedListNode.prev;
					if (linkedListNode == prev)
					{
						goto IL_61;
					}
				}
				return linkedListNode;
			}
			IL_61:
			return null;
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.LinkedList`1.Enumerator" /> для <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		// Token: 0x060027B4 RID: 10164 RVA: 0x000896CB File Offset: 0x000878CB
		public LinkedList<T>.Enumerator GetEnumerator()
		{
			return new LinkedList<T>.Enumerator(this);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000896D3 File Offset: 0x000878D3
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Удаляет первое вхождение заданного значения из <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="value">Значение, которое необходимо удалить из <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <returns>Значение <see langword="true" />, если элемент, содержащий <paramref name="value" />, успешно удален; в противном случае — значение <see langword="false" />.  Этот метод также возвращает <see langword="false" />, если объект <paramref name="value" /> не был найден в исходной коллекции <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		// Token: 0x060027B6 RID: 10166 RVA: 0x000896E0 File Offset: 0x000878E0
		public bool Remove(T value)
		{
			LinkedListNode<T> linkedListNode = this.Find(value);
			if (linkedListNode != null)
			{
				this.InternalRemoveNode(linkedListNode);
				return true;
			}
			return false;
		}

		/// <summary>Удаляет заданный узел из объекта <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="node">Элемент <see cref="T:System.Collections.Generic.LinkedListNode`1" />, который требуется удалить из <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="node" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="node" /> не находится в текущем объекте <see cref="T:System.Collections.Generic.LinkedList`1" />.</exception>
		// Token: 0x060027B7 RID: 10167 RVA: 0x00089702 File Offset: 0x00087902
		public void Remove(LinkedListNode<T> node)
		{
			this.ValidateNode(node);
			this.InternalRemoveNode(node);
		}

		/// <summary>Удаляет узел в начале <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Очередь <see cref="T:System.Collections.Generic.LinkedList`1" /> является пустой.</exception>
		// Token: 0x060027B8 RID: 10168 RVA: 0x00089712 File Offset: 0x00087912
		public void RemoveFirst()
		{
			if (this.head == null)
			{
				throw new InvalidOperationException("The LinkedList is empty.");
			}
			this.InternalRemoveNode(this.head);
		}

		/// <summary>Удаляет узел в конце <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Очередь <see cref="T:System.Collections.Generic.LinkedList`1" /> является пустой.</exception>
		// Token: 0x060027B9 RID: 10169 RVA: 0x00089733 File Offset: 0x00087933
		public void RemoveLast()
		{
			if (this.head == null)
			{
				throw new InvalidOperationException("The LinkedList is empty.");
			}
			this.InternalRemoveNode(this.head.prev);
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и возвращает данные, необходимые для сериализации экземпляра <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации экземпляра <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализации потока, связанного с экземпляром класса <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027BA RID: 10170 RVA: 0x0008975C File Offset: 0x0008795C
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("Version", this.version);
			info.AddValue("Count", this.count);
			if (this.count != 0)
			{
				T[] array = new T[this.count];
				this.CopyTo(array, 0);
				info.AddValue("Data", array, typeof(T[]));
			}
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывает событие десериализации при завершении десериализации.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, связанный с текущим экземпляром класса <see cref="T:System.Collections.Generic.LinkedList`1" />, является недопустимым.</exception>
		// Token: 0x060027BB RID: 10171 RVA: 0x000897CC File Offset: 0x000879CC
		public virtual void OnDeserialization(object sender)
		{
			if (this._siInfo == null)
			{
				return;
			}
			int @int = this._siInfo.GetInt32("Version");
			if (this._siInfo.GetInt32("Count") != 0)
			{
				T[] array = (T[])this._siInfo.GetValue("Data", typeof(T[]));
				if (array == null)
				{
					throw new SerializationException("The values for this dictionary are missing.");
				}
				for (int i = 0; i < array.Length; i++)
				{
					this.AddLast(array[i]);
				}
			}
			else
			{
				this.head = null;
			}
			this.version = @int;
			this._siInfo = null;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00089868 File Offset: 0x00087A68
		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			newNode.next = node;
			newNode.prev = node.prev;
			node.prev.next = newNode;
			node.prev = newNode;
			this.version++;
			this.count++;
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000898B7 File Offset: 0x00087AB7
		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
			newNode.next = newNode;
			newNode.prev = newNode;
			this.head = newNode;
			this.version++;
			this.count++;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000898EC File Offset: 0x00087AEC
		internal void InternalRemoveNode(LinkedListNode<T> node)
		{
			if (node.next == node)
			{
				this.head = null;
			}
			else
			{
				node.next.prev = node.prev;
				node.prev.next = node.next;
				if (this.head == node)
				{
					this.head = node.next;
				}
			}
			node.Invalidate();
			this.count--;
			this.version++;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00089964 File Offset: 0x00087B64
		internal void ValidateNewNode(LinkedListNode<T> node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			if (node.list != null)
			{
				throw new InvalidOperationException("The LinkedList node already belongs to a LinkedList.");
			}
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00089987 File Offset: 0x00087B87
		internal void ValidateNode(LinkedListNode<T> node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			if (node.list != this)
			{
				throw new InvalidOperationException("The LinkedList node does not belong to current LinkedList.");
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.LinkedList`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.LinkedList`1" /> это свойство всегда возвращает текущий экземпляр.</returns>
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000899AB File Offset: 0x00087BAB
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Массив <paramref name="array" /> не имеет индексации, начинающейся с нуля.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.  
		///
		/// или - 
		/// Тип исходного массива <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060027C3 RID: 10179 RVA: 0x000899D0 File Offset: 0x00087BD0
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException("The lower bound of target array must be zero.", "array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException("Insufficient space in the target location to copy the information.");
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.", "array");
			}
			LinkedListNode<T> next = this.head;
			try
			{
				if (next != null)
				{
					do
					{
						array3[index++] = next.item;
						next = next.next;
					}
					while (next != this.head);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.", "array");
			}
		}

		/// <summary>Возвращает перечислитель, выполняющий перебор элементов связанного списка как коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для перебора элементов связанного списка как коллекции.</returns>
		// Token: 0x060027C4 RID: 10180 RVA: 0x000896D3 File Offset: 0x000878D3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400155C RID: 5468
		internal LinkedListNode<T> head;

		// Token: 0x0400155D RID: 5469
		internal int count;

		// Token: 0x0400155E RID: 5470
		internal int version;

		// Token: 0x0400155F RID: 5471
		private object _syncRoot;

		// Token: 0x04001560 RID: 5472
		private SerializationInfo _siInfo;

		// Token: 0x04001561 RID: 5473
		private const string VersionName = "Version";

		// Token: 0x04001562 RID: 5474
		private const string CountName = "Count";

		// Token: 0x04001563 RID: 5475
		private const string ValuesName = "Data";

		/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <typeparam name="T" />
		// Token: 0x020004CB RID: 1227
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			// Token: 0x060027C5 RID: 10181 RVA: 0x00089AD0 File Offset: 0x00087CD0
			internal Enumerator(LinkedList<T> list)
			{
				this._list = list;
				this._version = list.version;
				this._node = list.head;
				this._current = default(T);
				this._index = 0;
			}

			// Token: 0x060027C6 RID: 10182 RVA: 0x00011F54 File Offset: 0x00010154
			private Enumerator(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.LinkedList`1" />, находящийся в текущей позиции перечислителя.</returns>
			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x060027C7 RID: 10183 RVA: 0x00089B04 File Offset: 0x00087D04
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00089B0C File Offset: 0x00087D0C
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._list.Count + 1)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._current;
				}
			}

			/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
			/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x060027C9 RID: 10185 RVA: 0x00089B44 File Offset: 0x00087D44
			public bool MoveNext()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._node == null)
				{
					this._index = this._list.Count + 1;
					return false;
				}
				this._index++;
				this._current = this._node.item;
				this._node = this._node.next;
				if (this._node == this._list.head)
				{
					this._node = null;
				}
				return true;
			}

			/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции. Этот класс не наследуется.</summary>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x060027CA RID: 10186 RVA: 0x00089BD8 File Offset: 0x00087DD8
			void IEnumerator.Reset()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._current = default(T);
				this._node = this._list.head;
				this._index = 0;
			}

			/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.LinkedList`1.Enumerator" />.</summary>
			// Token: 0x060027CB RID: 10187 RVA: 0x00003917 File Offset: 0x00001B17
			public void Dispose()
			{
			}

			/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и возвращает данные, необходимые для сериализации экземпляра <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
			/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации экземпляра <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
			/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализации потока, связанного с экземпляром класса <see cref="T:System.Collections.Generic.LinkedList`1" />.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///   <paramref name="info" /> — <see langword="null" />.</exception>
			// Token: 0x060027CC RID: 10188 RVA: 0x00011F54 File Offset: 0x00010154
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывает событие десериализации при завершении десериализации.</summary>
			/// <param name="sender">Источник события десериализации.</param>
			/// <exception cref="T:System.Runtime.Serialization.SerializationException">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, связанный с текущим экземпляром класса <see cref="T:System.Collections.Generic.LinkedList`1" />, является недопустимым.</exception>
			// Token: 0x060027CD RID: 10189 RVA: 0x00011F54 File Offset: 0x00010154
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x04001564 RID: 5476
			private LinkedList<T> _list;

			// Token: 0x04001565 RID: 5477
			private LinkedListNode<T> _node;

			// Token: 0x04001566 RID: 5478
			private int _version;

			// Token: 0x04001567 RID: 5479
			private T _current;

			// Token: 0x04001568 RID: 5480
			private int _index;

			// Token: 0x04001569 RID: 5481
			private const string LinkedListName = "LinkedList";

			// Token: 0x0400156A RID: 5482
			private const string CurrentValueName = "Current";

			// Token: 0x0400156B RID: 5483
			private const string VersionName = "Version";

			// Token: 0x0400156C RID: 5484
			private const string IndexName = "Index";
		}
	}
}
