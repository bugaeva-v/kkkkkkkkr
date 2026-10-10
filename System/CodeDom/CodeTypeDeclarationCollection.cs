using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeTypeDeclaration" />.</summary>
	// Token: 0x02000334 RID: 820
	[Serializable]
	public class CodeTypeDeclarationCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" />.</summary>
		// Token: 0x06001A01 RID: 6657 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeTypeDeclarationCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		// Token: 0x06001A02 RID: 6658 RVA: 0x00061279 File Offset: 0x0005F479
		public CodeTypeDeclarationCollection(CodeTypeDeclarationCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeTypeDeclaration" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeTypeDeclaration" />, которыми следует инициализировать коллекцию.</param>
		// Token: 0x06001A03 RID: 6659 RVA: 0x00061288 File Offset: 0x0005F488
		public CodeTypeDeclarationCollection(CodeTypeDeclaration[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000543 RID: 1347
		public CodeTypeDeclaration this[int index]
		{
			get
			{
				return (CodeTypeDeclaration)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001A06 RID: 6662 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeTypeDeclaration value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeTypeDeclaration" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A07 RID: 6663 RVA: 0x000612AC File Offset: 0x0005F4AC
		public void AddRange(CodeTypeDeclaration[] value)
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

		/// <summary>Добавляет содержимое другого объекта <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A08 RID: 6664 RVA: 0x000612E0 File Offset: 0x0005F4E0
		public void AddRange(CodeTypeDeclarationCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A09 RID: 6665 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeTypeDeclaration value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует элементы в объекте <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" /> в одномерный экземпляр <see cref="T:System.Array" /> начиная с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x06001A0A RID: 6666 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeTypeDeclaration[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает значение указанного объекта <see cref="T:System.CodeDom.CodeTypeDeclaration" /> в <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> для поиска в коллекции.</param>
		/// <returns>Индекс указанного объекта, если найден в коллекции; в противном случае — значение -1.</returns>
		// Token: 0x06001A0B RID: 6667 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeTypeDeclaration value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />.</param>
		// Token: 0x06001A0C RID: 6668 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeTypeDeclaration value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeTypeDeclaration" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001A0D RID: 6669 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeTypeDeclaration value)
		{
			base.List.Remove(value);
		}
	}
}
