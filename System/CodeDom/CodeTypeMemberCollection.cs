using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeTypeMember" />.</summary>
	// Token: 0x02000337 RID: 823
	[Serializable]
	public class CodeTypeMemberCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeMemberCollection" />.</summary>
		// Token: 0x06001A1F RID: 6687 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeTypeMemberCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeMemberCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeMemberCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		// Token: 0x06001A20 RID: 6688 RVA: 0x000614A3 File Offset: 0x0005F6A3
		public CodeTypeMemberCollection(CodeTypeMemberCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeMemberCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeTypeMember" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeTypeMember" />, которыми следует инициализировать коллекцию.</param>
		// Token: 0x06001A21 RID: 6689 RVA: 0x000614B2 File Offset: 0x0005F6B2
		public CodeTypeMemberCollection(CodeTypeMember[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает <see cref="T:System.CodeDom.CodeTypeMember" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeMember" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x1700054D RID: 1357
		public CodeTypeMember this[int index]
		{
			get
			{
				return (CodeTypeMember)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет <see cref="T:System.CodeDom.CodeTypeMember" /> с указанным значением к коллекции.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeTypeMember" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001A24 RID: 6692 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeTypeMember value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeTypeMember" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeTypeMember" />, содержащий объекты для добавления к коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A25 RID: 6693 RVA: 0x000614D4 File Offset: 0x0005F6D4
		public void AddRange(CodeTypeMember[] value)
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

		/// <summary>Добавляет содержимое другого объекта <see cref="T:System.CodeDom.CodeTypeMemberCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeMemberCollection" />, содержащий объекты для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A26 RID: 6694 RVA: 0x00061508 File Offset: 0x0005F708
		public void AddRange(CodeTypeMemberCollection value)
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

		/// <summary>Получает значение, показывающее, содержит ли коллекция указанную <see cref="T:System.CodeDom.CodeTypeMember" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeMember" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A27 RID: 6695 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeTypeMember value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр <see cref="T:System.Array" />, начинающийся с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeTypeMemberCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x06001A28 RID: 6696 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeTypeMember[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанной <see cref="T:System.CodeDom.CodeTypeMember" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeMember" /> для поиска в коллекции.</param>
		/// <returns>Индекс в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x06001A29 RID: 6697 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeTypeMember value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет в коллекцию заданный объект <see cref="T:System.CodeDom.CodeTypeMember" /> по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeTypeMember" />.</param>
		// Token: 0x06001A2A RID: 6698 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeTypeMember value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeTypeMember" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeMember" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001A2B RID: 6699 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeTypeMember value)
		{
			base.List.Remove(value);
		}
	}
}
