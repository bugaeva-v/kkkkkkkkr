using System;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Содержит объект стека, который может использоваться сериализатором для обеспечения доступности данных вложенным сериализаторам.</summary>
	// Token: 0x02000481 RID: 1153
	public sealed class ContextStack
	{
		/// <summary>Возвращает текущий объект в стеке.</summary>
		/// <returns>Текущий объект в стеке или значение <see langword="null" />, если в стек не отправлено ни одного объекта.</returns>
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000829FE File Offset: 0x00080BFE
		public object Current
		{
			get
			{
				if (this._contextStack != null && this._contextStack.Count > 0)
				{
					return this._contextStack[this._contextStack.Count - 1];
				}
				return null;
			}
		}

		/// <summary>Возвращает объект стека на указанном уровне.</summary>
		/// <param name="level">Уровень, с которого загружается объект стека. Уровень 0 является верхним в стеке, за ним идет уровень 1 и т. д. Этот уровень должен быть 0 или выше. Если уровень больше, чем количество уровней в стеке, возвращается значение <see langword="null" />.</param>
		/// <returns>Объект в стеке на указанном уровне или значение <see langword="null" />, если на уровне нет объектов.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="level" /> меньше 0.</exception>
		// Token: 0x17000779 RID: 1913
		public object this[int level]
		{
			get
			{
				if (level < 0)
				{
					throw new ArgumentOutOfRangeException("level");
				}
				if (this._contextStack != null && level < this._contextStack.Count)
				{
					return this._contextStack[this._contextStack.Count - 1 - level];
				}
				return null;
			}
		}

		/// <summary>Возвращает первый объект стека, который наследует или использует заданный тип.</summary>
		/// <param name="type">Тип, загружаемый из контекстного стека.</param>
		/// <returns>Первый объект стека, который наследует или использует заданный тип, либо значение <see langword="null" />, если тип не используется ни одним из объектов стека.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x1700077A RID: 1914
		public object this[Type type]
		{
			get
			{
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				if (this._contextStack != null)
				{
					int i = this._contextStack.Count;
					while (i > 0)
					{
						object obj = this._contextStack[--i];
						if (type.IsInstanceOfType(obj))
						{
							return obj;
						}
					}
				}
				return null;
			}
		}

		/// <summary>Добавляет объект в конец стека, но не отправляет его на верх стека.</summary>
		/// <param name="context">Контекстный объект, добавленный в стек.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="context" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002503 RID: 9475 RVA: 0x00082AD8 File Offset: 0x00080CD8
		public void Append(object context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (this._contextStack == null)
			{
				this._contextStack = new ArrayList();
			}
			this._contextStack.Insert(0, context);
		}

		/// <summary>Удаляет текущий объект из стека, возвращая его значение.</summary>
		/// <returns>Удаленный из стека объект; значение <see langword="null" />, если в стеке нет объектов.</returns>
		// Token: 0x06002504 RID: 9476 RVA: 0x00082B08 File Offset: 0x00080D08
		public object Pop()
		{
			object result = null;
			if (this._contextStack != null && this._contextStack.Count > 0)
			{
				int index = this._contextStack.Count - 1;
				result = this._contextStack[index];
				this._contextStack.RemoveAt(index);
			}
			return result;
		}

		/// <summary>Отправляет или помещает указанный объект в стек.</summary>
		/// <param name="context">Контекстный объект, отправленный в стек.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="context" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002505 RID: 9477 RVA: 0x00082B55 File Offset: 0x00080D55
		public void Push(object context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (this._contextStack == null)
			{
				this._contextStack = new ArrayList();
			}
			this._contextStack.Add(context);
		}

		// Token: 0x04001492 RID: 5266
		private ArrayList _contextStack;
	}
}
