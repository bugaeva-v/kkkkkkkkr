using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeNamespace" />.</summary>
	// Token: 0x0200031D RID: 797
	[Serializable]
	public class CodeNamespaceCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespaceCollection" />.</summary>
		// Token: 0x06001957 RID: 6487 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeNamespaceCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespaceCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">С помощью <see cref="T:System.CodeDom.CodeNamespaceCollection" /> следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001958 RID: 6488 RVA: 0x00060659 File Offset: 0x0005E859
		public CodeNamespaceCollection(CodeNamespaceCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespaceCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeNamespace" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeNamespace" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько объектов в массиве имеют значение <see langword="null" />.</exception>
		// Token: 0x06001959 RID: 6489 RVA: 0x00060668 File Offset: 0x0005E868
		public CodeNamespaceCollection(CodeNamespace[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeNamespaceCollection" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeNamespace" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000514 RID: 1300
		public CodeNamespace this[int index]
		{
			get
			{
				return (CodeNamespace)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeNamespace" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeNamespace" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x0600195C RID: 6492 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeNamespace value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeNamespace" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeNamespace" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600195D RID: 6493 RVA: 0x0006068C File Offset: 0x0005E88C
		public void AddRange(CodeNamespace[] value)
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

		/// <summary>Добавляет содержимое указанного объекта <see cref="T:System.CodeDom.CodeNamespaceCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeNamespaceCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600195E RID: 6494 RVA: 0x000606C0 File Offset: 0x0005E8C0
		public void AddRange(CodeNamespaceCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeNamespace" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeNamespace" /> для поиска в коллекции.</param>
		/// <returns>Возвращается <see langword="true" />, если коллекция содержит элемент <see cref="T:System.CodeDom.CodeNamespace" />. В противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x0600195F RID: 6495 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeNamespace value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр <see cref="T:System.Array" />, начиная с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeNamespaceCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x06001960 RID: 6496 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeNamespace[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает значение указанного объекта <see cref="T:System.CodeDom.CodeNamespace" /> в <see cref="T:System.CodeDom.CodeNamespaceCollection" />, если он существует в коллекции.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.CodeDom.CodeNamespace" />.</param>
		/// <returns>Индекс указанной <see cref="T:System.CodeDom.CodeNamespace" /> в коллекции, если найден; в противном случае — значение -1.</returns>
		// Token: 0x06001961 RID: 6497 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeNamespace value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeNamespace" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить новый элемент.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeNamespace" />.</param>
		// Token: 0x06001962 RID: 6498 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeNamespace value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeNamespace" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeNamespace" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001963 RID: 6499 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeNamespace value)
		{
			base.List.Remove(value);
		}
	}
}
