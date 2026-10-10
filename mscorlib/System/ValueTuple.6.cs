using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Представляет кортеж значений с 5 компонентами.</summary>
	/// <typeparam name="T1">Тип первого элемента кортежа значений.</typeparam>
	/// <typeparam name="T2">Тип второго элемента кортежа значений.</typeparam>
	/// <typeparam name="T3">Тип третьего элемента кортежа значений.</typeparam>
	/// <typeparam name="T4">Тип четвертого элемента кортежа значений.</typeparam>
	/// <typeparam name="T5">Тип пятого элемента кортежа значений.</typeparam>
	// Token: 0x020001B2 RID: 434
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ValueTuple`5" />.</summary>
		/// <param name="item1">Первый элемент кортежа значений.</param>
		/// <param name="item2">Второй элемент кортежа значений.</param>
		/// <param name="item3">Третий элемент кортежа значений.</param>
		/// <param name="item4">Четвертый элемент кортежа значений.</param>
		/// <param name="item5">Пятый элемент кортежа значений.</param>
		// Token: 0x060012C4 RID: 4804 RVA: 0x000498BE File Offset: 0x00047ABE
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`5" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060012C5 RID: 4805 RVA: 0x000498E5 File Offset: 0x00047AE5
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1, T2, T3, T4, T5> && this.Equals((ValueTuple<T1, T2, T3, T4, T5>)obj);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`5" /> указанному экземпляру <see cref="T:System.ValueTuple`5" />.</summary>
		/// <param name="other">Кортеж значений для сравнения с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному кортежу; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060012C6 RID: 4806 RVA: 0x00049900 File Offset: 0x00047B00
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(this.Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(this.Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(this.Item5, other.Item5);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий экземпляр <see cref="T:System.ValueTuple`5" /> указанному объекту, на основе заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанным объектам; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060012C7 RID: 4807 RVA: 0x00049988 File Offset: 0x00047B88
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1, T2, T3, T4, T5>))
			{
				return false;
			}
			ValueTuple<T1, T2, T3, T4, T5> valueTuple = (ValueTuple<T1, T2, T3, T4, T5>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2) && comparer.Equals(this.Item3, valueTuple.Item3) && comparer.Equals(this.Item4, valueTuple.Item4) && comparer.Equals(this.Item5, valueTuple.Item5);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`5" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		// Token: 0x060012C8 RID: 4808 RVA: 0x00049A40 File Offset: 0x00047C40
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3, T4, T5>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return this.CompareTo((ValueTuple<T1, T2, T3, T4, T5>)other);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`5" /> с указанным экземпляром <see cref="T:System.ValueTuple`5" />.</summary>
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
		// Token: 0x060012C9 RID: 4809 RVA: 0x00049A90 File Offset: 0x00047C90
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other)
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
			num = Comparer<T3>.Default.Compare(this.Item3, other.Item3);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T4>.Default.Compare(this.Item4, other.Item4);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T5>.Default.Compare(this.Item5, other.Item5);
		}

		/// <summary>Сравнивает текущий экземпляр <see cref="T:System.ValueTuple`5" /> с заданным объектом, используя указанную функцию сравнения, и возвращает целое число, определяющее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		// Token: 0x060012CA RID: 4810 RVA: 0x00049B24 File Offset: 0x00047D24
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3, T4, T5>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1, T2, T3, T4, T5> valueTuple = (ValueTuple<T1, T2, T3, T4, T5>)other;
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
			num = comparer.Compare(this.Item3, valueTuple.Item3);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.Item4, valueTuple.Item4);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.Item5, valueTuple.Item5);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`5" />.</returns>
		// Token: 0x060012CB RID: 4811 RVA: 0x00049C14 File Offset: 0x00047E14
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
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			int h4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					h4 = 0;
					goto IL_D4;
				}
			}
			h4 = ptr4.GetHashCode();
			IL_D4:
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			int h5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					h5 = 0;
					goto IL_10C;
				}
			}
			h5 = ptr5.GetHashCode();
			IL_10C:
			return ValueTuple.CombineHashCodes(h, h2, h3, h4, h5);
		}

		/// <summary>Вычисляет хэш-код для текущего экземпляра <see cref="T:System.ValueTuple`5" />, используя указанный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего экземпляра <see cref="T:System.ValueTuple`5" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060012CC RID: 4812 RVA: 0x00049D32 File Offset: 0x00047F32
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00049D3C File Offset: 0x00047F3C
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2), comparer.GetHashCode(this.Item3), comparer.GetHashCode(this.Item4), comparer.GetHashCode(this.Item5));
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00049D32 File Offset: 0x00047F32
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		/// <returns>Строковое представление этого экземпляра <see cref="T:System.ValueTuple`5" />.</returns>
		// Token: 0x060012CF RID: 4815 RVA: 0x00049DA4 File Offset: 0x00047FA4
		public override string ToString()
		{
			string[] array = new string[11];
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
					goto IL_46;
				}
			}
			text = ptr.ToString();
			IL_46:
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
					goto IL_86;
				}
			}
			text2 = ptr2.ToString();
			IL_86:
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
					goto IL_C6;
				}
			}
			text3 = ptr3.ToString();
			IL_C6:
			array[num3] = text3;
			array[6] = ", ";
			int num4 = 7;
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			string text4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					text4 = null;
					goto IL_106;
				}
			}
			text4 = ptr4.ToString();
			IL_106:
			array[num4] = text4;
			array[8] = ", ";
			int num5 = 9;
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			string text5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					text5 = null;
					goto IL_14A;
				}
			}
			text5 = ptr5.ToString();
			IL_14A:
			array[num5] = text5;
			array[10] = ")";
			return string.Concat(array);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00049F0C File Offset: 0x0004810C
		string IValueTupleInternal.ToStringEnd()
		{
			string[] array = new string[10];
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
					goto IL_3E;
				}
			}
			text = ptr.ToString();
			IL_3E:
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
					goto IL_7E;
				}
			}
			text2 = ptr2.ToString();
			IL_7E:
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
					goto IL_BE;
				}
			}
			text3 = ptr3.ToString();
			IL_BE:
			array[num3] = text3;
			array[5] = ", ";
			int num4 = 6;
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			string text4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					text4 = null;
					goto IL_FE;
				}
			}
			text4 = ptr4.ToString();
			IL_FE:
			array[num4] = text4;
			array[7] = ", ";
			int num5 = 8;
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			string text5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					text5 = null;
					goto IL_141;
				}
			}
			text5 = ptr5.ToString();
			IL_141:
			array[num5] = text5;
			array[9] = ")";
			return string.Concat(array);
		}

		/// <summary>Возвращает количество элементов в <see langword="ValueTuple" />.</summary>
		/// <returns>5, количество элементов в объекте <see cref="T:System.ValueTuple`5" />.</returns>
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		int ITuple.Length
		{
			get
			{
				return 5;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="ValueTuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="ValueTuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 4.</param>
		/// <returns>Значение элемента <see langword="ValueTuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 4.</exception>
		// Token: 0x170001BD RID: 445
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
				case 3:
					return this.Item4;
				case 4:
					return this.Item5;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		/// <summary>Получает значение первого элемента текущего экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		// Token: 0x04001370 RID: 4976
		public T1 Item1;

		/// <summary>Получает значение второго элемента текущего экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		// Token: 0x04001371 RID: 4977
		public T2 Item2;

		/// <summary>Получает значение третьего элемента текущего экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		// Token: 0x04001372 RID: 4978
		public T3 Item3;

		/// <summary>Получает значение четвертого элемента текущего экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		// Token: 0x04001373 RID: 4979
		public T4 Item4;

		/// <summary>Получает значение пятого элемента текущего экземпляра <see cref="T:System.ValueTuple`5" />.</summary>
		// Token: 0x04001374 RID: 4980
		public T5 Item5;
	}
}
