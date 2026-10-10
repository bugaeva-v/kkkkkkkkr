using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System
{
	/// <summary>Представляет кортеж значений с одним компонентом.</summary>
	/// <typeparam name="T1">Тип единственного элемента кортежа значений.</typeparam>
	// Token: 0x020001AE RID: 430
	[Serializable]
	public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ValueTuple`1" />.</summary>
		/// <param name="item1">Первый элемент кортежа значений.</param>
		// Token: 0x06001289 RID: 4745 RVA: 0x0004867F File Offset: 0x0004687F
		public ValueTuple(T1 item1)
		{
			this.Item1 = item1;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`1" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600128A RID: 4746 RVA: 0x00048688 File Offset: 0x00046888
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1> && this.Equals((ValueTuple<T1>)obj);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`1" /> указанному экземпляру <see cref="T:System.ValueTuple`1" />.</summary>
		/// <param name="other">Кортеж значений для сравнения с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному кортежу; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600128B RID: 4747 RVA: 0x000486A0 File Offset: 0x000468A0
		public bool Equals(ValueTuple<T1> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`1" /> указанному объекту, на основе заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600128C RID: 4748 RVA: 0x000486B8 File Offset: 0x000468B8
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1>))
			{
				return false;
			}
			ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`1" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Целое число со знаком, определяющее относительное положение экземпляра и параметра <paramref name="obj" /> в порядке сортировки, как показано в следующей таблице.  
		///   Значение 
		///   Описание: 
		///   Отрицательное целое число 
		///   Данный экземпляр предшествует параметру <paramref name="other" />.  
		///
		///   Нуль 
		///   У этого экземпляра та же позиция в порядке сортировки, что и у <paramref name="other" />.  
		///
		///   Положительное целое число 
		///   Данный экземпляр стоит после параметра <paramref name="other" />.</returns>
		// Token: 0x0600128D RID: 4749 RVA: 0x000486F8 File Offset: 0x000468F8
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
			return Comparer<T1>.Default.Compare(this.Item1, valueTuple.Item1);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`1" /> с указанным экземпляром <see cref="T:System.ValueTuple`1" />.</summary>
		/// <param name="other">Кортеж значений для сравнения с этим экземпляром.</param>
		/// <returns>Целое число со знаком, определяющее относительное положение экземпляра и параметра <paramref name="other" /> в порядке сортировки, как показано в следующей таблице.  
		///   Значение 
		///   Описание: 
		///   Отрицательное целое число 
		///   Данный экземпляр предшествует параметру <paramref name="other" />.  
		///
		///   Нуль 
		///   У этого экземпляра та же позиция в порядке сортировки, что и у <paramref name="other" />.  
		///
		///   Положительное целое число 
		///   Данный экземпляр стоит после параметра <paramref name="other" />.</returns>
		// Token: 0x0600128E RID: 4750 RVA: 0x00048759 File Offset: 0x00046959
		public int CompareTo(ValueTuple<T1> other)
		{
			return Comparer<T1>.Default.Compare(this.Item1, other.Item1);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`1" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <param name="comparer">Объект, предоставляющий настраиваемые правила для сравнения.</param>
		/// <returns>Целое число со знаком, определяющее относительное положение экземпляра и параметра <paramref name="other" /> в порядке сортировки, как показано в следующей таблице.  
		///   Значение 
		///   Описание: 
		///   Отрицательное целое число 
		///   Данный экземпляр предшествует параметру <paramref name="other" />.  
		///
		///   Нуль 
		///   У этого экземпляра та же позиция в порядке сортировки, что и у <paramref name="other" />.  
		///
		///   Положительное целое число 
		///   Данный экземпляр стоит после параметра <paramref name="other" />.</returns>
		// Token: 0x0600128F RID: 4751 RVA: 0x00048774 File Offset: 0x00046974
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
			return comparer.Compare(this.Item1, valueTuple.Item1);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`1" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`1" />.</returns>
		// Token: 0x06001290 RID: 4752 RVA: 0x000487DC File Offset: 0x000469DC
		public override int GetHashCode()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					return 0;
				}
			}
			return ptr.GetHashCode();
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`1" />, используя указанный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего экземпляра <see cref="T:System.ValueTuple`1" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001291 RID: 4753 RVA: 0x0004881D File Offset: 0x00046A1D
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.Item1);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0004881D File Offset: 0x00046A1D
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.Item1);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.ValueTuple`1" />.</summary>
		/// <returns>Строковое представление этого экземпляра <see cref="T:System.ValueTuple`1" />.</returns>
		// Token: 0x06001293 RID: 4755 RVA: 0x00048830 File Offset: 0x00046A30
		public override string ToString()
		{
			string str = "(";
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string str2;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					str2 = null;
					goto IL_3A;
				}
			}
			str2 = ptr.ToString();
			IL_3A:
			return str + str2 + ")";
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00048884 File Offset: 0x00046A84
		string IValueTupleInternal.ToStringEnd()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string str;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					str = null;
					goto IL_35;
				}
			}
			str = ptr.ToString();
			IL_35:
			return str + ")";
		}

		/// <summary>Возвращает количество элементов в <see langword="ValueTuple" />.</summary>
		/// <returns>1, количество элементов в объекте <see cref="T:System.ValueTuple`1" />.</returns>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x000040F7 File Offset: 0x000022F7
		int ITuple.Length
		{
			get
			{
				return 1;
			}
		}

		/// <summary>Получает значение элемента <see langword="ValueTuple" />.</summary>
		/// <param name="index">Индекс элемента <see langword="ValueTuple" />. <paramref name="index" /> должно быть равно 0.</param>
		/// <returns>Значение элемента <see langword="ValueTuple" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 0.</exception>
		// Token: 0x170001B5 RID: 437
		object ITuple.this[int index]
		{
			get
			{
				if (index != 0)
				{
					throw new IndexOutOfRangeException();
				}
				return this.Item1;
			}
		}

		/// <summary>Получает значение первого элемента текущего экземпляра <see cref="T:System.ValueTuple`1" />.</summary>
		// Token: 0x04001366 RID: 4966
		public T1 Item1;
	}
}
