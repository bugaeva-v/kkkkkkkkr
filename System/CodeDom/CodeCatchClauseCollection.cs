using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeCatchClause" />.</summary>
	// Token: 0x020002FD RID: 765
	[Serializable]
	public class CodeCatchClauseCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClauseCollection" />.</summary>
		// Token: 0x06001872 RID: 6258 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeCatchClauseCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClauseCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCatchClauseCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001873 RID: 6259 RVA: 0x0005F581 File Offset: 0x0005D781
		public CodeCatchClauseCollection(CodeCatchClauseCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClauseCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeCatchClause" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeCatchClause" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько объектов в массиве имеют значение <see langword="null" />.</exception>
		// Token: 0x06001874 RID: 6260 RVA: 0x0005F590 File Offset: 0x0005D790
		public CodeCatchClauseCollection(CodeCatchClause[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeCatchClause" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeCatchClause" /> на каждом допустимом индексе.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x170004CD RID: 1229
		public CodeCatchClause this[int index]
		{
			get
			{
				return (CodeCatchClause)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeCatchClause" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeCatchClause" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001877 RID: 6263 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeCatchClause value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeCatchClause" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeCatchClause" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001878 RID: 6264 RVA: 0x0005F5B4 File Offset: 0x0005D7B4
		public void AddRange(CodeCatchClause[] value)
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

		/// <summary>Копирует содержимое другого объекта <see cref="T:System.CodeDom.CodeCatchClauseCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCatchClauseCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001879 RID: 6265 RVA: 0x0005F5E8 File Offset: 0x0005D7E8
		public void AddRange(CodeCatchClauseCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeCatchClause" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCatchClause" />, который требуется найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600187A RID: 6266 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeCatchClause value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр <see cref="T:System.Array" />, начинающийся с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeCatchClauseCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x0600187B RID: 6267 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeCatchClause[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.CodeCatchClause" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCatchClause" />, который требуется найти в коллекции.</param>
		/// <returns>Индекс в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x0600187C RID: 6268 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeCatchClause value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeCatchClause" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeCatchClause" />.</param>
		// Token: 0x0600187D RID: 6269 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeCatchClause value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeCatchClause" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeCatchClause" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x0600187E RID: 6270 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeCatchClause value)
		{
			base.List.Remove(value);
		}
	}
}
