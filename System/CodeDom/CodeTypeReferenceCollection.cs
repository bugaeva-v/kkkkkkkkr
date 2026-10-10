using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeTypeReference" />.</summary>
	// Token: 0x020002EE RID: 750
	[Serializable]
	public class CodeTypeReferenceCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />.</summary>
		// Token: 0x060017F8 RID: 6136 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeTypeReferenceCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		// Token: 0x060017F9 RID: 6137 RVA: 0x0005EDC9 File Offset: 0x0005CFC9
		public CodeTypeReferenceCollection(CodeTypeReferenceCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeTypeReference" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeTypeReference" />, которыми следует инициализировать коллекцию.</param>
		// Token: 0x060017FA RID: 6138 RVA: 0x0005EDD8 File Offset: 0x0005CFD8
		public CodeTypeReferenceCollection(CodeTypeReference[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает <see cref="T:System.CodeDom.CodeTypeReference" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeReference" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x170004B2 RID: 1202
		public CodeTypeReference this[int index]
		{
			get
			{
				return (CodeTypeReference)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный параметр <see cref="T:System.CodeDom.CodeTypeReference" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeTypeReference" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x060017FD RID: 6141 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeTypeReference value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет <see cref="T:System.CodeDom.CodeTypeReference" /> к коллекции, используя указанное имя типа данных.</summary>
		/// <param name="value">Имя типа данных, для которого следует добавить <see cref="T:System.CodeDom.CodeTypeReference" /> к коллекции.</param>
		// Token: 0x060017FE RID: 6142 RVA: 0x0005EDFA File Offset: 0x0005CFFA
		public void Add(string value)
		{
			this.Add(new CodeTypeReference(value));
		}

		/// <summary>Добавляет <see cref="T:System.CodeDom.CodeTypeReference" /> к коллекции, используя указанный тип данных.</summary>
		/// <param name="value">Тип данных, для которого следует добавить <see cref="T:System.CodeDom.CodeTypeReference" /> к коллекции.</param>
		// Token: 0x060017FF RID: 6143 RVA: 0x0005EE09 File Offset: 0x0005D009
		public void Add(Type value)
		{
			this.Add(new CodeTypeReference(value));
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeTypeReference" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeTypeReference" />, содержащий объекты для добавления к коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001800 RID: 6144 RVA: 0x0005EE18 File Offset: 0x0005D018
		public void AddRange(CodeTypeReference[] value)
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

		/// <summary>Добавляет содержимое указанной <see cref="T:System.CodeDom.CodeTypeReferenceCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, содержащий объекты для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001801 RID: 6145 RVA: 0x0005EE4C File Offset: 0x0005D04C
		public void AddRange(CodeTypeReferenceCollection value)
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

		/// <summary>Получает значение, показывающее, содержит ли коллекция указанную <see cref="T:System.CodeDom.CodeTypeReference" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeReference" /> для поиска в коллекции.</param>
		/// <returns>Возвращается <see langword="true" />, если коллекция содержит элемент <see cref="T:System.CodeDom.CodeTypeReference" />. В противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x06001802 RID: 6146 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeTypeReference value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует элементы коллекции в указанный одномерный <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeTypeReferenceCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x06001803 RID: 6147 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeTypeReference[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанной <see cref="T:System.CodeDom.CodeTypeReference" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeReference" /> для поиска в коллекции.</param>
		/// <returns>Индекс указанной <see cref="T:System.CodeDom.CodeTypeReference" /> в коллекции, если найден; в противном случае — значение -1.</returns>
		// Token: 0x06001804 RID: 6148 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeTypeReference value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет <see cref="T:System.CodeDom.CodeTypeReference" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить элемент.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeTypeReference" />.</param>
		// Token: 0x06001805 RID: 6149 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeTypeReference value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeTypeReference" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeReference" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001806 RID: 6150 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeTypeReference value)
		{
			base.List.Remove(value);
		}
	}
}
