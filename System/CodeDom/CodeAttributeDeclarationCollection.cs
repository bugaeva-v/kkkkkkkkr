using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</summary>
	// Token: 0x020002F7 RID: 759
	[Serializable]
	public class CodeAttributeDeclarationCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />.</summary>
		// Token: 0x0600184B RID: 6219 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeAttributeDeclarationCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600184C RID: 6220 RVA: 0x0005F33C File Offset: 0x0005D53C
		public CodeAttributeDeclarationCollection(CodeAttributeDeclarationCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько объектов в массиве имеют значение <see langword="null" />.</exception>
		// Token: 0x0600184D RID: 6221 RVA: 0x0005F34B File Offset: 0x0005D54B
		public CodeAttributeDeclarationCollection(CodeAttributeDeclaration[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> по указанному индексу.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x170004C4 RID: 1220
		public CodeAttributeDeclaration this[int index]
		{
			get
			{
				return (CodeAttributeDeclaration)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> с указанным значением к коллекции.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001850 RID: 6224 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeAttributeDeclaration value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001851 RID: 6225 RVA: 0x0005F370 File Offset: 0x0005D570
		public void AddRange(CodeAttributeDeclaration[] value)
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

		/// <summary>Копирует содержимое другого объекта <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001852 RID: 6226 RVA: 0x0005F3A4 File Offset: 0x0005D5A4
		public void AddRange(CodeAttributeDeclarationCollection value)
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

		/// <summary>Получает или задает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, который требуется обнаружить.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001853 RID: 6227 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeAttributeDeclaration value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр <see cref="T:System.Array" />, начинающийся с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x06001854 RID: 6228 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeAttributeDeclaration[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, который требуется найти в коллекции.</param>
		/// <returns>Индекс в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x06001855 RID: 6229 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeAttributeDeclaration value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</param>
		// Token: 0x06001856 RID: 6230 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeAttributeDeclaration value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeDeclaration" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001857 RID: 6231 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeAttributeDeclaration value)
		{
			base.List.Remove(value);
		}
	}
}
