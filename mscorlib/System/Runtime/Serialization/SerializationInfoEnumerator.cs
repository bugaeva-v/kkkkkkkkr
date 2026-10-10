using System;
using System.Collections;
using Unity;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет удобный для форматера механизм синтаксического анализа данных в <see cref="T:System.Runtime.Serialization.SerializationInfo" />. Этот класс не наследуется.</summary>
	// Token: 0x0200064D RID: 1613
	public sealed class SerializationInfoEnumerator : IEnumerator
	{
		// Token: 0x06003C58 RID: 15448 RVA: 0x000D14F7 File Offset: 0x000CF6F7
		internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems)
		{
			this._members = members;
			this._data = info;
			this._types = types;
			this._numItems = numItems - 1;
			this._currItem = -1;
			this._current = false;
		}

		/// <summary>Обновляет перечислитель для следующего элемента.</summary>
		/// <returns>
		///   <see langword="true" />, если новый элемент найден; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003C59 RID: 15449 RVA: 0x000D152C File Offset: 0x000CF72C
		public bool MoveNext()
		{
			if (this._currItem < this._numItems)
			{
				this._currItem++;
				this._current = true;
			}
			else
			{
				this._current = false;
			}
			return this._current;
		}

		/// <summary>Возвращает текущий элемент в коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.SerializationEntry" />, содержащий сведения о текущей сериализации.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечисление либо еще не начато, либо уже завершено.</exception>
		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x000D1560 File Offset: 0x000CF760
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Возвращает проверяемый в настоящее время элемент.</summary>
		/// <returns>Проверяемый в настоящее время элемент.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель еще не начал или уже закончил перечисление элементов.</exception>
		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x000D1570 File Offset: 0x000CF770
		public SerializationEntry Current
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return new SerializationEntry(this._members[this._currItem], this._data[this._currItem], this._types[this._currItem]);
			}
		}

		/// <summary>Сбрасывает перечислитель к первому элементу.</summary>
		// Token: 0x06003C5C RID: 15452 RVA: 0x000D15BC File Offset: 0x000CF7BC
		public void Reset()
		{
			this._currItem = -1;
			this._current = false;
		}

		/// <summary>Возвращает имя для проверяемого в настоящее время элемента.</summary>
		/// <returns>Имя элемента.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель еще не начал или уже закончил перечисление элементов.</exception>
		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x000D15CC File Offset: 0x000CF7CC
		public string Name
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return this._members[this._currItem];
			}
		}

		/// <summary>Возвращает значение проверяемого в настоящее время элемента.</summary>
		/// <returns>Значение проверяемого в настоящее время элемента.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель еще не начал или уже закончил перечисление элементов.</exception>
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x000D15EE File Offset: 0x000CF7EE
		public object Value
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return this._data[this._currItem];
			}
		}

		/// <summary>Возвращает тип проверяемого в настоящее время элемента.</summary>
		/// <returns>Тип проверяемого в настоящее время элемента.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель еще не начал или уже закончил перечисление элементов.</exception>
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x000D1610 File Offset: 0x000CF810
		public Type ObjectType
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return this._types[this._currItem];
			}
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x000173AD File Offset: 0x000155AD
		internal SerializationInfoEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002719 RID: 10009
		private readonly string[] _members;

		// Token: 0x0400271A RID: 10010
		private readonly object[] _data;

		// Token: 0x0400271B RID: 10011
		private readonly Type[] _types;

		// Token: 0x0400271C RID: 10012
		private readonly int _numItems;

		// Token: 0x0400271D RID: 10013
		private int _currItem;

		// Token: 0x0400271E RID: 10014
		private bool _current;
	}
}
