using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Представляет кортеж значений с 2 компонентами.</summary>
	/// <typeparam name="T1">Тип первого элемента кортежа значений.</typeparam>
	/// <typeparam name="T2">Тип второго элемента кортежа значений.</typeparam>
	// Token: 0x020001AF RID: 431
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ValueTuple`2" />.</summary>
		/// <param name="item1">Первый элемент кортежа значений.</param>
		/// <param name="item2">Второй элемент кортежа значений.</param>
		// Token: 0x06001297 RID: 4759 RVA: 0x000488E6 File Offset: 0x00046AE6
		public ValueTuple(T1 item1, T2 item2)
		{
			this.Item1 = item1;
			this.Item2 = item2;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`2" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001298 RID: 4760 RVA: 0x000488F6 File Offset: 0x00046AF6
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1, T2> && this.Equals((ValueTuple<T1, T2>)obj);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`2" /> указанному экземпляру <see cref="T:System.ValueTuple`2" />.</summary>
		/// <param name="other">Кортеж значений для сравнения с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному кортежу; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001299 RID: 4761 RVA: 0x0004890E File Offset: 0x00046B0E
		public bool Equals(ValueTuple<T1, T2> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`2" /> указанному объекту, на основе заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанным объектам; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600129A RID: 4762 RVA: 0x00048940 File Offset: 0x00046B40
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1, T2>))
			{
				return false;
			}
			ValueTuple<T1, T2> valueTuple = (ValueTuple<T1, T2>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`2" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		// Token: 0x0600129B RID: 4763 RVA: 0x000489A0 File Offset: 0x00046BA0
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return this.CompareTo((ValueTuple<T1, T2>)other);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`2" /> с указанным экземпляром <see cref="T:System.ValueTuple`2" />.</summary>
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
		// Token: 0x0600129C RID: 4764 RVA: 0x000489F0 File Offset: 0x00046BF0
		public int CompareTo(ValueTuple<T1, T2> other)
		{
			int num = Comparer<T1>.Default.Compare(this.Item1, other.Item1);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T2>.Default.Compare(this.Item2, other.Item2);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`2" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		// Token: 0x0600129D RID: 4765 RVA: 0x00048A30 File Offset: 0x00046C30
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1, T2> valueTuple = (ValueTuple<T1, T2>)other;
			int num = comparer.Compare(this.Item1, valueTuple.Item1);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.Item2, valueTuple.Item2);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`2" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`2" />.</returns>
		// Token: 0x0600129E RID: 4766 RVA: 0x00048ABC File Offset: 0x00046CBC
		public override int GetHashCode()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			int h;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					h = 0;
					goto IL_35;
				}
			}
			h = ptr.GetHashCode();
			IL_35:
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			int h2;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					h2 = 0;
					goto IL_6A;
				}
			}
			h2 = ptr2.GetHashCode();
			IL_6A:
			return ValueTuple.CombineHashCodes(h, h2);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`2" />, используя указанный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего экземпляра <see cref="T:System.ValueTuple`2" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600129F RID: 4767 RVA: 0x00048B38 File Offset: 0x00046D38
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00048B41 File Offset: 0x00046D41
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2));
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00048B38 File Offset: 0x00046D38
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.ValueTuple`2" />.</summary>
		/// <returns>Строковое представление этого экземпляра <see cref="T:System.ValueTuple`2" />.</returns>
		// Token: 0x060012A2 RID: 4770 RVA: 0x00048B6C File Offset: 0x00046D6C
		public override string ToString()
		{
			string[] array = new string[5];
			array[0] = "(";
			int num = 1;
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string text;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					text = null;
					goto IL_45;
				}
			}
			text = ptr.ToString();
			IL_45:
			array[num] = text;
			array[2] = ", ";
			int num2 = 3;
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			string text2;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					text2 = null;
					goto IL_85;
				}
			}
			text2 = ptr2.ToString();
			IL_85:
			array[num2] = text2;
			array[4] = ")";
			return string.Concat(array);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00048C0C File Offset: 0x00046E0C
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
			string str2 = ", ";
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			string str3;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					str3 = null;
					goto IL_6F;
				}
			}
			str3 = ptr2.ToString();
			IL_6F:
			return str + str2 + str3 + ")";
		}

		/// <summary>Возвращает количество элементов в <see langword="ValueTuple" />.</summary>
		/// <returns>2, количество элементов в объекте <see cref="T:System.ValueTuple`2" />.</returns>
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00015831 File Offset: 0x00013A31
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="ValueTuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="ValueTuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 1.</param>
		/// <returns>Значение элемента <see langword="ValueTuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 1.</exception>
		// Token: 0x170001B7 RID: 439
		object ITuple.this[int index]
		{
			get
			{
				if (index == 0)
				{
					return this.Item1;
				}
				if (index != 1)
				{
					throw new IndexOutOfRangeException();
				}
				return this.Item2;
			}
		}

		/// <summary>Получает значение первого элемента текущего экземпляра <see cref="T:System.ValueTuple`2" />.</summary>
		// Token: 0x04001367 RID: 4967
		public T1 Item1;

		/// <summary>Получает значение второго элемента текущего экземпляра <see cref="T:System.ValueTuple`2" />.</summary>
		// Token: 0x04001368 RID: 4968
		public T2 Item2;
	}
}
