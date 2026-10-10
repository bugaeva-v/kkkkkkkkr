using System;
using System.Collections;

namespace System.CodeDom.Compiler
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.CodeDom.Compiler.CompilerError" />.</summary>
	// Token: 0x0200034A RID: 842
	[Serializable]
	public class CompilerErrorCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />.</summary>
		// Token: 0x06001BBA RID: 7098 RVA: 0x0004E358 File Offset: 0x0004C558
		public CompilerErrorCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />, содержащий заданный объект <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />, с помощью которого следует инициализировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001BBB RID: 7099 RVA: 0x0006614F File Offset: 0x0006434F
		public CompilerErrorCollection(CompilerErrorCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />, содержащий указанный массив объектов <see cref="T:System.CodeDom.Compiler.CompilerError" />.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.CodeDom.Compiler.CompilerError" />, используемых для инициализации коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001BBC RID: 7100 RVA: 0x0006615E File Offset: 0x0006435E
		public CompilerErrorCollection(CompilerError[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.CodeDom.Compiler.CompilerError" /> с заданным индексом.</summary>
		/// <param name="index">Индекс (с нуля) записи, расположение которой требуется определить в коллекции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerError" /> по каждому допустимому индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение индекса, заданное параметром <paramref name="index" />, находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x17000584 RID: 1412
		public CompilerError this[int index]
		{
			get
			{
				return (CompilerError)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет заданный объект <see cref="T:System.CodeDom.Compiler.CompilerError" /> в коллекцию ошибок.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.CodeDom.Compiler.CompilerError" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		// Token: 0x06001BBF RID: 7103 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(CompilerError value)
		{
			return base.List.Add(value);
		}

		/// <summary>Копирует элементы массива в конец коллекции ошибок.</summary>
		/// <param name="value">Массив типа <see cref="T:System.CodeDom.Compiler.CompilerError" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001BC0 RID: 7104 RVA: 0x00066180 File Offset: 0x00064380
		public void AddRange(CompilerError[] value)
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

		/// <summary>Добавляет содержимое указанной коллекции ошибок компилятора в конец коллекции ошибок.</summary>
		/// <param name="value">Объект <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />, содержащий объекты, добавляемые в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001BC1 RID: 7105 RVA: 0x000661B4 File Offset: 0x000643B4
		public void AddRange(CompilerErrorCollection value)
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

		/// <summary>Получает значение, которое указывает, содержит ли коллекция заданный объект <see cref="T:System.CodeDom.Compiler.CompilerError" />.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.CodeDom.Compiler.CompilerError" />.</param>
		/// <returns>Возвращается <see langword="true" />, если коллекция содержит элемент <see cref="T:System.CodeDom.Compiler.CompilerError" />. В противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x06001BC2 RID: 7106 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(CompilerError value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует значения коллекции в одномерный экземпляр <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является целевым для значений, копируемых из <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />.</param>
		/// <param name="index">Индекс в массиве назначения, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentException">Массив, заданный параметром <paramref name="array" />, является многомерным.  
		///
		/// или - 
		/// Количество элементов в <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" /> превышает доступный промежуток между заданным в параметре <paramref name="arrayIndex" /> значением индекса в массиве, указанном в параметре <paramref name="array" />, и концом массива, указанного в параметре <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> меньше нижней границы массива, указанного параметром <paramref name="array" />.</exception>
		// Token: 0x06001BC3 RID: 7107 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(CompilerError[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Получает значение, показывающее, содержит ли коллекция ошибки.</summary>
		/// <returns>
		///   <see langword="true" />, если коллекция содержит ошибки, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x000661F0 File Offset: 0x000643F0
		public bool HasErrors
		{
			get
			{
				if (base.Count > 0)
				{
					using (IEnumerator enumerator = base.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (!((CompilerError)enumerator.Current).IsWarning)
							{
								return true;
							}
						}
					}
					return false;
				}
				return false;
			}
		}

		/// <summary>Получает значение, показывающее, содержит ли коллекция предупреждения.</summary>
		/// <returns>
		///   <see langword="true" />, если коллекция содержит предупреждения, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00066254 File Offset: 0x00064454
		public bool HasWarnings
		{
			get
			{
				if (base.Count > 0)
				{
					using (IEnumerator enumerator = base.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((CompilerError)enumerator.Current).IsWarning)
							{
								return true;
							}
						}
					}
					return false;
				}
				return false;
			}
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.CodeDom.Compiler.CompilerError" />, если он существует в коллекции.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.CodeDom.Compiler.CompilerError" />.</param>
		/// <returns>Индекс указанного объекта <see cref="T:System.CodeDom.Compiler.CompilerError" /> в <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />, если он найден; в противном случае — значение -1.</returns>
		// Token: 0x06001BC6 RID: 7110 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(CompilerError value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет в коллекцию заданный объект <see cref="T:System.CodeDom.Compiler.CompilerError" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить ошибку компилятора.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.CodeDom.Compiler.CompilerError" />.</param>
		// Token: 0x06001BC7 RID: 7111 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, CompilerError value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.CodeDom.Compiler.CompilerError" /> из коллекции.</summary>
		/// <param name="value">Элемент <see cref="T:System.CodeDom.Compiler.CompilerError" />, который требуется удалить из <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">Указанный объект не найден в коллекции.</exception>
		// Token: 0x06001BC8 RID: 7112 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(CompilerError value)
		{
			base.List.Remove(value);
		}
	}
}
