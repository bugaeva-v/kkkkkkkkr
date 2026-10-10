using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из n компонентов, где n равно 8 или больше.</summary>
	/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
	/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
	/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
	/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
	/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
	/// <typeparam name="T6">Тип шестого компонента кортежа.</typeparam>
	/// <typeparam name="T7">Тип седьмого компонента кортежа.</typeparam>
	/// <typeparam name="TRest">Любой универсальный объект <see langword="Tuple" />, который определяет типы остальных компонентов кортежа.</typeparam>
	// Token: 0x0200019F RID: 415
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение первого компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение первого компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00043BB6 File Offset: 0x00041DB6
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Получает значение второго компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение второго компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00043BBE File Offset: 0x00041DBE
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Получает значение третьего компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение третьего компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00043BC6 File Offset: 0x00041DC6
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Получает значение четвертого компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение четвертого компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00043BCE File Offset: 0x00041DCE
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		/// <summary>Получает значение пятого компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение пятого компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00043BD6 File Offset: 0x00041DD6
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		/// <summary>Получает значение шестого компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение шестого компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00043BDE File Offset: 0x00041DDE
		public T6 Item6
		{
			get
			{
				return this.m_Item6;
			}
		}

		/// <summary>Получает значение седьмого компонента текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение седьмого компонента текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00043BE6 File Offset: 0x00041DE6
		public T7 Item7
		{
			get
			{
				return this.m_Item7;
			}
		}

		/// <summary>Получает остальные компоненты текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Значение остальных компонентов текущего объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00043BEE File Offset: 0x00041DEE
		public TRest Rest
		{
			get
			{
				return this.m_Rest;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`8" />.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <param name="item6">Значение шестого компонента кортежа.</param>
		/// <param name="item7">Значение седьмого компонента кортежа.</param>
		/// <param name="rest">Любой универсальный объект <see langword="Tuple" />, который содержит значения остальных компонентов кортежа.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rest" /> не является универсальным объектом <see langword="Tuple" />.</exception>
		// Token: 0x060010BC RID: 4284 RVA: 0x00043BF8 File Offset: 0x00041DF8
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
			if (!(rest is ITupleInternal))
			{
				throw new ArgumentException("The last element of an eight element tuple must be a Tuple.");
			}
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
			this.m_Item6 = item6;
			this.m_Item7 = item7;
			this.m_Rest = rest;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`8" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060010BD RID: 4285 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`8" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060010BE RID: 4286 RVA: 0x00043C64 File Offset: 0x00041E64
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4) && comparer.Equals(this.m_Item5, tuple.m_Item5) && comparer.Equals(this.m_Item6, tuple.m_Item6) && comparer.Equals(this.m_Item7, tuple.m_Item7)) && comparer.Equals(this.m_Rest, tuple.m_Rest);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`8" /> с заданным объектом и возвращает целое число, указывающее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Целое число со знаком, определяющее относительное положение экземпляра и параметра <paramref name="obj" /> в порядке сортировки, как показано в следующей таблице.  
		///   Значение 
		///   Описание: 
		///   Отрицательное целое число 
		///   Данный экземпляр предшествует параметру <paramref name="obj" />.  
		///
		///   Нуль 
		///   У этого экземпляра та же позиция в порядке сортировки, что и у <paramref name="obj" />.  
		///
		///   Положительное целое число 
		///   Данный экземпляр стоит после параметра <paramref name="obj" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`8" />.</exception>
		// Token: 0x060010BF RID: 4287 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`8" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`8" />.</exception>
		// Token: 0x060010C0 RID: 4288 RVA: 0x00043D7C File Offset: 0x00041F7C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			int num = comparer.Compare(this.m_Item1, tuple.m_Item1);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item2, tuple.m_Item2);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item3, tuple.m_Item3);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item4, tuple.m_Item4);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item5, tuple.m_Item5);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item6, tuple.m_Item6);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item7, tuple.m_Item7);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Rest, tuple.m_Rest);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060010C1 RID: 4289 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`8" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`8" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060010C2 RID: 4290 RVA: 0x00043EC4 File Offset: 0x000420C4
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			ITupleInternal tupleInternal = (ITupleInternal)((object)this.m_Rest);
			if (tupleInternal.Length >= 8)
			{
				return tupleInternal.GetHashCode(comparer);
			}
			switch (8 - tupleInternal.Length)
			{
			case 1:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 2:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 3:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 4:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 5:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 6:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 7:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			default:
				return -1;
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`8" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`8" />.</returns>
		// Token: 0x060010C4 RID: 4292 RVA: 0x00044160 File Offset: 0x00042360
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00044184 File Offset: 0x00042384
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(", ");
			sb.Append(this.m_Item4);
			sb.Append(", ");
			sb.Append(this.m_Item5);
			sb.Append(", ");
			sb.Append(this.m_Item6);
			sb.Append(", ");
			sb.Append(this.m_Item7);
			sb.Append(", ");
			return ((ITupleInternal)((object)this.m_Rest)).ToString(sb);
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>Число элементов в массиве <see langword="Tuple" />.</returns>
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00044279 File Offset: 0x00042479
		int ITuple.Length
		{
			get
			{
				return 7 + ((ITupleInternal)((object)this.Rest)).Length;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. <paramref name="index" /> может находиться в диапазоне от 0 для <see langword="Item1" /> до значения, на единицу меньше, чем число элементов в <see langword="Tuple" />.</param>
		/// <returns>Значение элемента <see langword="Tuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше или равно <see cref="P:System.Tuple`8.System#Runtime#CompilerServices#ITuple#Length" />.</exception>
		// Token: 0x17000162 RID: 354
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
				case 5:
					return this.Item6;
				case 6:
					return this.Item7;
				default:
					return ((ITupleInternal)((object)this.Rest))[index - 7];
				}
			}
		}

		// Token: 0x04001335 RID: 4917
		private readonly T1 m_Item1;

		// Token: 0x04001336 RID: 4918
		private readonly T2 m_Item2;

		// Token: 0x04001337 RID: 4919
		private readonly T3 m_Item3;

		// Token: 0x04001338 RID: 4920
		private readonly T4 m_Item4;

		// Token: 0x04001339 RID: 4921
		private readonly T5 m_Item5;

		// Token: 0x0400133A RID: 4922
		private readonly T6 m_Item6;

		// Token: 0x0400133B RID: 4923
		private readonly T7 m_Item7;

		// Token: 0x0400133C RID: 4924
		private readonly TRest m_Rest;
	}
}
