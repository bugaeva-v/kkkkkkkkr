using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeCommentStatement" />.</summary>
	// Token: 0x02000301 RID: 769
	[Serializable]
	public class CodeCommentStatementCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatementCollection" />.</summary>
		// Token: 0x06001894 RID: 6292 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeCommentStatementCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatementCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCommentStatementCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001895 RID: 6293 RVA: 0x0005F726 File Offset: 0x0005D926
		public CodeCommentStatementCollection(CodeCommentStatementCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatementCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeCommentStatement" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeCommentStatement" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько объектов в массиве имеют значение <see langword="null" />.</exception>
		// Token: 0x06001896 RID: 6294 RVA: 0x0005F735 File Offset: 0x0005D935
		public CodeCommentStatementCollection(CodeCommentStatement[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeCommentStatement" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeCommentStatement" /> на каждом допустимом индексе.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x170004D4 RID: 1236
		public CodeCommentStatement this[int index]
		{
			get
			{
				return (CodeCommentStatement)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeCommentStatement" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeCommentStatement" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001899 RID: 6297 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeCommentStatement value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeCommentStatement" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeCommentStatement" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600189A RID: 6298 RVA: 0x0005F758 File Offset: 0x0005D958
		public void AddRange(CodeCommentStatement[] value)
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

		/// <summary>Копирует содержимое другого объекта <see cref="T:System.CodeDom.CodeCommentStatementCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCommentStatementCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600189B RID: 6299 RVA: 0x0005F78C File Offset: 0x0005D98C
		public void AddRange(CodeCommentStatementCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeCommentStatement" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCommentStatement" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600189C RID: 6300 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeCommentStatement value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в указанный одномерный экземпляр <see cref="T:System.Array" />, начинающийся с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeCommentStatementCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x0600189D RID: 6301 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeCommentStatement[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.CodeCommentStatement" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCommentStatement" />, который требуется обнаружить.</param>
		/// <returns>Индекс в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x0600189E RID: 6302 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeCommentStatement value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет объект <see cref="T:System.CodeDom.CodeCommentStatement" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить элемент.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeCommentStatement" />.</param>
		// Token: 0x0600189F RID: 6303 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeCommentStatement value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeCommentStatement" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCommentStatement" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x060018A0 RID: 6304 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeCommentStatement value)
		{
			base.List.Remove(value);
		}
	}
}
