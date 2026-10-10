using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeTypeParameter" />.</summary>
	// Token: 0x0200033A RID: 826
	[Serializable]
	public class CodeTypeParameterCollection : CollectionBase
	{
		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.CodeDom.CodeTypeParameterCollection" />.</summary>
		// Token: 0x06001A3A RID: 6714 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeTypeParameterCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeParameterCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeParameterCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		// Token: 0x06001A3B RID: 6715 RVA: 0x00061636 File Offset: 0x0005F836
		public CodeTypeParameterCollection(CodeTypeParameterCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeParameterCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeTypeParameter" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeTypeParameter" />, которыми следует инициализировать коллекцию.</param>
		// Token: 0x06001A3C RID: 6716 RVA: 0x00061645 File Offset: 0x0005F845
		public CodeTypeParameterCollection(CodeTypeParameter[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает объект <see cref="T:System.CodeDom.CodeTypeParameter" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс объект коллекции, к которому производится доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeParameter" />, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000553 RID: 1363
		public CodeTypeParameter this[int index]
		{
			get
			{
				return (CodeTypeParameter)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeTypeParameter" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeTypeParameter" />.</param>
		/// <returns>Индекс (с нуля), указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001A3F RID: 6719 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeTypeParameter value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.CodeDom.CodeTypeParameter" /> к коллекции, используя указанное имя типа данных.</summary>
		/// <param name="value">Имя типа данных, для которого следует добавить объект <see cref="T:System.CodeDom.CodeTypeParameter" /> к коллекции.</param>
		// Token: 0x06001A40 RID: 6720 RVA: 0x00061667 File Offset: 0x0005F867
		public void Add(string value)
		{
			this.Add(new CodeTypeParameter(value));
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.CodeDom.CodeTypeParameter" /> в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeTypeParameter" />, содержащий объекты для добавления к коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A41 RID: 6721 RVA: 0x00061678 File Offset: 0x0005F878
		public void AddRange(CodeTypeParameter[] value)
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

		/// <summary>Копирует элементы указанного объекта <see cref="T:System.CodeDom.CodeTypeParameterCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeParameterCollection" />, содержащий объекты <see cref="T:System.CodeDom.CodeTypeParameter" />, для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A42 RID: 6722 RVA: 0x000616AC File Offset: 0x0005F8AC
		public void AddRange(CodeTypeParameterCollection value)
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

		/// <summary>Определяет, содержит ли коллекция указанный объект <see cref="T:System.CodeDom.CodeTypeParameter" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeParameter" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.CodeDom.CodeTypeParameter" /> находится в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A43 RID: 6723 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeTypeParameter value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует элементы коллекции в указанный одномерный <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeTypeParameterCollection" /> превышает доступное пространство между индексом конечного массива, указанного <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше наименьшего индекса целевого массива.</exception>
		// Token: 0x06001A44 RID: 6724 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeTypeParameter[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.CodeTypeParameter" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeParameter" />, который требуется найти в коллекции.</param>
		/// <returns>Отсчитываемый с нуля индекс указанного объекта <see cref="T:System.CodeDom.CodeTypeParameter" /> в коллекции (если найден); в противном случае — значение -1.</returns>
		// Token: 0x06001A45 RID: 6725 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeTypeParameter value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет указанный объект <see cref="T:System.CodeDom.CodeTypeParameter" /> в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому нужно вставить элемент.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeTypeParameter" />.</param>
		// Token: 0x06001A46 RID: 6726 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeTypeParameter value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeTypeParameter" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeTypeParameter" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001A47 RID: 6727 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeTypeParameter value)
		{
			base.List.Remove(value);
		}
	}
}
