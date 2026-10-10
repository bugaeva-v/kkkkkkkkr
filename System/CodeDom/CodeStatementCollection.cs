using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeStatement" />.</summary>
	// Token: 0x0200032E RID: 814
	[Serializable]
	public class CodeStatementCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeStatementCollection" />.</summary>
		// Token: 0x060019D2 RID: 6610 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeStatementCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeStatementCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060019D3 RID: 6611 RVA: 0x00060DC9 File Offset: 0x0005EFC9
		public CodeStatementCollection(CodeStatementCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeStatement" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeStatement" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060019D4 RID: 6612 RVA: 0x00060DD8 File Offset: 0x0005EFD8
		public CodeStatementCollection(CodeStatement[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeStatement" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeStatement" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000535 RID: 1333
		public CodeStatement this[int index]
		{
			get
			{
				return (CodeStatement)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeStatement" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeStatement" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x060019D7 RID: 6615 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeStatement value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeExpression" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeExpression" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x060019D8 RID: 6616 RVA: 0x00060DFA File Offset: 0x0005EFFA
		public int Add(CodeExpression value)
		{
			return this.Add(new CodeExpressionStatement(value));
		}

		/// <summary>Добавляет набор объектов <see cref="T:System.CodeDom.CodeStatement" /> в коллекцию.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeStatement" />, добавляемый в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060019D9 RID: 6617 RVA: 0x00060E08 File Offset: 0x0005F008
		public void AddRange(CodeStatement[] value)
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

		/// <summary>Добавляет содержимое другого объекта <see cref="T:System.CodeDom.CodeStatementCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060019DA RID: 6618 RVA: 0x00060E3C File Offset: 0x0005F03C
		public void AddRange(CodeStatementCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeStatement" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeStatement" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x060019DB RID: 6619 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeStatement value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.CodeDom.CodeStatementCollection" /> в одномерный экземпляр <see cref="T:System.Array" /> начиная с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeStatementCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x060019DC RID: 6620 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeStatement[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает значение указанного объекта <see cref="T:System.CodeDom.CodeStatement" /> в <see cref="T:System.CodeDom.CodeStatementCollection" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeStatement" /> для поиска в коллекции.</param>
		/// <returns>Индекс указанного объекта, если найден в коллекции; в противном случае — значение -1.</returns>
		// Token: 0x060019DD RID: 6621 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeStatement value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeStatement" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeStatement" />.</param>
		// Token: 0x060019DE RID: 6622 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeStatement value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeStatement" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeStatement" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x060019DF RID: 6623 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeStatement value)
		{
			base.List.Remove(value);
		}
	}
}
