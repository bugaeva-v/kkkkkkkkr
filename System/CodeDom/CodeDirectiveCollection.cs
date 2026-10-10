using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeDirective" />.</summary>
	// Token: 0x0200030A RID: 778
	[Serializable]
	public class CodeDirectiveCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDirectiveCollection" />.</summary>
		// Token: 0x060018CA RID: 6346 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeDirectiveCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDirectiveCollection" /> с элементами в заданной коллекции директив кода.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060018CB RID: 6347 RVA: 0x0005FACA File Offset: 0x0005DCCA
		public CodeDirectiveCollection(CodeDirectiveCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDirectiveCollection" /> с объектами директивы кода в заданном массиве.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeDirective" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060018CC RID: 6348 RVA: 0x0005FAD9 File Offset: 0x0005DCD9
		public CodeDirectiveCollection(CodeDirective[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeDirective" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Позиция индекса, по которому производится доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirective" /> на позиции индекса.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне диапазона допустимых позиций индексов коллекции.</exception>
		// Token: 0x170004E7 RID: 1255
		public CodeDirective this[int index]
		{
			get
			{
				return (CodeDirective)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeDirective" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeDirective" />.</param>
		/// <returns>Позиция индекса, на которой был вставлен новый элемент.</returns>
		// Token: 0x060018CF RID: 6351 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeDirective value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет массив объектов <see cref="T:System.CodeDom.CodeDirective" /> к концу коллекции.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeDirective" />, добавляемый в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060018D0 RID: 6352 RVA: 0x0005FAFC File Offset: 0x0005DCFC
		public void AddRange(CodeDirective[] value)
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

		/// <summary>Добавляет содержимое указанного объекта <see cref="T:System.CodeDom.CodeDirectiveCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий объекты <see cref="T:System.CodeDom.CodeDirective" /> для добавления к коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060018D1 RID: 6353 RVA: 0x0005FB30 File Offset: 0x0005DD30
		public void AddRange(CodeDirectiveCollection value)
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

		/// <summary>Получает значение, указывающее, содержится ли указанный объект <see cref="T:System.CodeDom.CodeDirective" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeDirective" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x060018D2 RID: 6354 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeDirective value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует содержимое коллекции в одномерный массив, начиная с указанного индекса.</summary>
		/// <param name="array">Массив типа <see cref="T:System.CodeDom.CodeDirective" />, являющийся назначением для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку объектов коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeDirectiveCollection" /> превышает доступное пространство между индексом конечного массива, указанного <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше минимального индекса целевого массива.</exception>
		// Token: 0x060018D3 RID: 6355 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeDirective[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.CodeDirective" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeDirective" />, который требуется найти в коллекции.</param>
		/// <returns>Позиция индекса в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x060018D4 RID: 6356 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeDirective value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeDirective" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Позиция индекса, отсчитываемая от нуля, по которой следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeDirective" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		// Token: 0x060018D5 RID: 6357 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeDirective value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeDirective" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeDirective" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x060018D6 RID: 6358 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeDirective value)
		{
			base.List.Remove(value);
		}
	}
}
