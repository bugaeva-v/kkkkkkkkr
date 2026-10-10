using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Представляет кортеж значений с 3 компонентами.</summary>
	/// <typeparam name="T1">Тип первого элемента кортежа значений.</typeparam>
	/// <typeparam name="T2">Тип второго элемента кортежа значений.</typeparam>
	/// <typeparam name="T3">Тип третьего элемента кортежа значений.</typeparam>
	// Token: 0x020001B0 RID: 432
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ValueTuple`3" />.</summary>
		/// <param name="item1">Первый элемент кортежа значений.</param>
		/// <param name="item2">Второй элемент кортежа значений.</param>
		/// <param name="item3">Третий элемент кортежа значений.</param>
		// Token: 0x060012A6 RID: 4774 RVA: 0x00048CBA File Offset: 0x00046EBA
		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`3" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060012A7 RID: 4775 RVA: 0x00048CD1 File Offset: 0x00046ED1
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1, T2, T3> && this.Equals((ValueTuple<T1, T2, T3>)obj);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`3" /> указанному экземпляру <see cref="T:System.ValueTuple`3" />.</summary>
		/// <param name="other">Кортеж значений для сравнения с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному кортежу; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060012A8 RID: 4776 RVA: 0x00048CEC File Offset: 0x00046EEC
		public bool Equals(ValueTuple<T1, T2, T3> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(this.Item3, other.Item3);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`3" /> указанному объекту, на основе заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанным объектам; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060012A9 RID: 4777 RVA: 0x00048D44 File Offset: 0x00046F44
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1, T2, T3>))
			{
				return false;
			}
			ValueTuple<T1, T2, T3> valueTuple = (ValueTuple<T1, T2, T3>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2) && comparer.Equals(this.Item3, valueTuple.Item3);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`3" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		// Token: 0x060012AA RID: 4778 RVA: 0x00048DC0 File Offset: 0x00046FC0
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return this.CompareTo((ValueTuple<T1, T2, T3>)other);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`3" /> с указанным экземпляром <see cref="T:System.ValueTuple`3" />.</summary>
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
		// Token: 0x060012AB RID: 4779 RVA: 0x00048E10 File Offset: 0x00047010
		public int CompareTo(ValueTuple<T1, T2, T3> other)
		{
			int num = Comparer<T1>.Default.Compare(this.Item1, other.Item1);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T2>.Default.Compare(this.Item2, other.Item2);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T3>.Default.Compare(this.Item3, other.Item3);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`3" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		// Token: 0x060012AC RID: 4780 RVA: 0x00048E6C File Offset: 0x0004706C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1, T2, T3> valueTuple = (ValueTuple<T1, T2, T3>)other;
			int num = comparer.Compare(this.Item1, valueTuple.Item1);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.Item2, valueTuple.Item2);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.Item3, valueTuple.Item3);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`3" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`3" />.</returns>
		// Token: 0x060012AD RID: 4781 RVA: 0x00048F18 File Offset: 0x00047118
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
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			int h3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					h3 = 0;
					goto IL_9F;
				}
			}
			h3 = ptr3.GetHashCode();
			IL_9F:
			return ValueTuple.CombineHashCodes(h, h2, h3);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`3" />, используя указанный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего экземпляра <see cref="T:System.ValueTuple`3" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060012AE RID: 4782 RVA: 0x00048FC9 File Offset: 0x000471C9
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00048FD2 File Offset: 0x000471D2
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2), comparer.GetHashCode(this.Item3));
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00048FC9 File Offset: 0x000471C9
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.ValueTuple`3" />.</summary>
		/// <returns>Строковое представление этого экземпляра <see cref="T:System.ValueTuple`2" />.</returns>
		// Token: 0x060012B1 RID: 4785 RVA: 0x0004900C File Offset: 0x0004720C
		public override string ToString()
		{
			string[] array = new string[7];
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
			array[4] = ", ";
			int num3 = 5;
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			string text3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					text3 = null;
					goto IL_C5;
				}
			}
			text3 = ptr3.ToString();
			IL_C5:
			array[num3] = text3;
			array[6] = ")";
			return string.Concat(array);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000490EC File Offset: 0x000472EC
		string IValueTupleInternal.ToStringEnd()
		{
			string[] array = new string[6];
			int num = 0;
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
					goto IL_3D;
				}
			}
			text = ptr.ToString();
			IL_3D:
			array[num] = text;
			array[1] = ", ";
			int num2 = 2;
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
					goto IL_7D;
				}
			}
			text2 = ptr2.ToString();
			IL_7D:
			array[num2] = text2;
			array[3] = ", ";
			int num3 = 4;
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			string text3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					text3 = null;
					goto IL_BD;
				}
			}
			text3 = ptr3.ToString();
			IL_BD:
			array[num3] = text3;
			array[5] = ")";
			return string.Concat(array);
		}

		/// <summary>Возвращает количество элементов в <see langword="ValueTuple" />.</summary>
		/// <returns>3, количество элементов в объекте <see cref="T:System.ValueTuple`3" />.</returns>
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x000221D2 File Offset: 0x000203D2
		int ITuple.Length
		{
			get
			{
				return 3;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="ValueTuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="ValueTuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 2.</param>
		/// <returns>Значение элемента <see langword="ValueTuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 2.</exception>
		// Token: 0x170001B9 RID: 441
		object ITuple.this[int index]
		{
			get
			{
				switch (index)
				{
				case 0:
					return this.Item1;
				case 1:
					return this.Item2;
				case 2:
					return this.Item3;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		/// <summary>Получает значение первого элемента текущего экземпляра <see cref="T:System.ValueTuple`3" />.</summary>
		// Token: 0x04001369 RID: 4969
		public T1 Item1;

		/// <summary>Получает значение второго элемента текущего экземпляра <see cref="T:System.ValueTuple`3" />.</summary>
		// Token: 0x0400136A RID: 4970
		public T2 Item2;

		/// <summary>Получает значение третьего элемента текущего экземпляра <see cref="T:System.ValueTuple`3" />.</summary>
		// Token: 0x0400136B RID: 4971
		public T3 Item3;
	}
}
