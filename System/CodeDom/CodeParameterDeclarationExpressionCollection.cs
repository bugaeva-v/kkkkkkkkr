using System;
using System.Collections;

namespace System.CodeDom
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />.</summary>
	// Token: 0x02000322 RID: 802
	[Serializable]
	public class CodeParameterDeclarationExpressionCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />.</summary>
		// Token: 0x06001996 RID: 6550 RVA: 0x0004E358 File Offset: 0x0004C558
		public CodeParameterDeclarationExpressionCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />, содержащий элементы указанной исходной коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001997 RID: 6551 RVA: 0x00060AF5 File Offset: 0x0005ECF5
		public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpressionCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />, которыми следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">один или несколько объектов в массиве имеют значение <see langword="null" />.</exception>
		// Token: 0x06001998 RID: 6552 RVA: 0x00060B04 File Offset: 0x0005ED04
		public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpression[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Получает или задает <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс коллекции, к которой требуется получить доступ.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000525 RID: 1317
		public CodeParameterDeclarationExpression this[int index]
		{
			get
			{
				return (CodeParameterDeclarationExpression)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный параметр <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> в коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x0600199B RID: 6555 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CodeParameterDeclarationExpression value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы указанного массива в конец коллекции.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />, содержащий объекты для добавления к коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600199C RID: 6556 RVA: 0x00060B28 File Offset: 0x0005ED28
		public void AddRange(CodeParameterDeclarationExpression[] value)
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

		/// <summary>Добавляет содержимое другого объекта <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" /> в конец коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />, содержащий объекты для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600199D RID: 6557 RVA: 0x00060B5C File Offset: 0x0005ED5C
		public void AddRange(CodeParameterDeclarationExpressionCollection value)
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

		/// <summary>Получает значение, показывающее, содержит ли коллекция указанную <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />.</summary>
		/// <param name="value">
		///   <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600199E RID: 6558 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CodeParameterDeclarationExpression value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр <see cref="T:System.Array" />, начинающийся с указанного индекса.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с позиции которого требуется начать вставку.</param>
		/// <exception cref="T:System.ArgumentException">Массив назначения является многомерным.  
		/// -или- 
		/// Количество элементов в <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" /> превышает доступное пространство между индексом конечного массива, указанного параметром <paramref name="index" />, и концом конечного массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше, чем минимальный индекс целевого массива.</exception>
		// Token: 0x0600199F RID: 6559 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CodeParameterDeclarationExpression[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает индекс в коллекции указанной <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />, если он существует в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> для поиска в коллекции.</param>
		/// <returns>Индекс в коллекции указанного объекта, если найден; в противном случае — значение -1.</returns>
		// Token: 0x060019A0 RID: 6560 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CodeParameterDeclarationExpression value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет в коллекцию заданный объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> по указанному индексу.</summary>
		/// <param name="index">Индекс, отсчитываемый от нуля, по которому следует вставить указанный объект.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />.</param>
		// Token: 0x060019A1 RID: 6561 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CodeParameterDeclarationExpression value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x060019A2 RID: 6562 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CodeParameterDeclarationExpression value)
		{
			base.List.Remove(value);
		}
	}
}
