using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeAttributeArgument" />.</summary>
	// Token: 0x020002F5 RID: 757
	[Serializable]
	public class CodeAttributeArgumentCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" />.</summary>
		// Token: 0x06001835 RID: 6197 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeAttributeArgumentCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001836 RID: 6198 RVA: 0x0005F1CB File Offset: 0x0005D3CB
		public CodeAttributeArgumentCollection(CodeAttributeArgumentCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeAttributeArgument" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeAttributeArgument" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько объектов в массиве имеют значение <see langword="null" />.</exception>
		// Token: 0x06001837 RID: 6199 RVA: 0x0005F1DA File Offset: 0x0005D3DA
		public CodeAttributeArgumentCollection(CodeAttributeArgument[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeAttributeArgument" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeAttributeArgument" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x170004C0 RID: 1216
		public CodeAttributeArgument this[int index]
		{
			get
			{
				return (CodeAttributeArgument)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeAttributeArgument" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeAttributeArgument" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x0600183A RID: 6202 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeAttributeArgument value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeAttributeArgument" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeAttributeArgument" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600183B RID: 6203 RVA: 0x0005F1FC File Offset: 0x0005D3FC
		public void AddRange(CodeAttributeArgument[] value)
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

		/// <summary>Копирует содержимое другого объекта <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600183C RID: 6204 RVA: 0x0005F230 File Offset: 0x0005D430
		public void AddRange(CodeAttributeArgumentCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.CodeAttributeArgument" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeArgument" />, который требуется найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600183D RID: 6205 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeAttributeArgument value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр <see cref="T:System.Array" />, начинающийся с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x0600183E RID: 6206 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeAttributeArgument[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.CodeAttributeArgument" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeArgument" />, который требуется найти в коллекции.</param>
		/// <returns>Индекс в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x0600183F RID: 6207 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeAttributeArgument value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeAttributeArgument" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeAttributeArgument" />.</param>
		// Token: 0x06001840 RID: 6208 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeAttributeArgument value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeAttributeArgument" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeAttributeArgument" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001841 RID: 6209 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeAttributeArgument value)
		{
			base.List.Remove(value);
		}
	}
}
