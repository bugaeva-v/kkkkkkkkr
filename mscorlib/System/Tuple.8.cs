using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из семи компонентов.</summary>
	/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
	/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
	/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
	/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
	/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
	/// <typeparam name="T6">Тип шестого компонента кортежа.</typeparam>
	/// <typeparam name="T7">Тип седьмого компонента кортежа.</typeparam>
	// Token: 0x0200019E RID: 414
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение первого компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение первого компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00043702 File Offset: 0x00041902
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Получает значение второго компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение второго компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0004370A File Offset: 0x0004190A
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Получает значение третьего компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение третьего компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00043712 File Offset: 0x00041912
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Получает значение четвертого компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение четвертого компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0004371A File Offset: 0x0004191A
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		/// <summary>Получает значение пятого компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение пятого компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00043722 File Offset: 0x00041922
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		/// <summary>Получает значение шестого компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение шестого компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0004372A File Offset: 0x0004192A
		public T6 Item6
		{
			get
			{
				return this.m_Item6;
			}
		}

		/// <summary>Получает значение седьмого компонента текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Значение седьмого компонента текущего объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00043732 File Offset: 0x00041932
		public T7 Item7
		{
			get
			{
				return this.m_Item7;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`7" />.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <param name="item6">Значение шестого компонента кортежа.</param>
		/// <param name="item7">Значение седьмого компонента кортежа.</param>
		// Token: 0x060010A8 RID: 4264 RVA: 0x0004373A File Offset: 0x0004193A
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
			this.m_Item6 = item6;
			this.m_Item7 = item7;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`7" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060010A9 RID: 4265 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`7" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060010AA RID: 4266 RVA: 0x00043778 File Offset: 0x00041978
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4) && comparer.Equals(this.m_Item5, tuple.m_Item5) && comparer.Equals(this.m_Item6, tuple.m_Item6)) && comparer.Equals(this.m_Item7, tuple.m_Item7);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`7" /> с заданным объектом и возвращает целое число, указывающее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`7" />.</exception>
		// Token: 0x060010AB RID: 4267 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`7" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`7" />.</exception>
		// Token: 0x060010AC RID: 4268 RVA: 0x00043870 File Offset: 0x00041A70
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7>;
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
			return comparer.Compare(this.m_Item7, tuple.m_Item7);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060010AD RID: 4269 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`7" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`7" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060010AE RID: 4270 RVA: 0x00043998 File Offset: 0x00041B98
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7));
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`7" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x060010B0 RID: 4272 RVA: 0x00043A24 File Offset: 0x00041C24
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00043A48 File Offset: 0x00041C48
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
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>7, количество элементов в объекте <see cref="T:System.Tuple`7" />.</returns>
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0003227E File Offset: 0x0003047E
		int ITuple.Length
		{
			get
			{
				return 7;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 6.</param>
		/// <returns>Значение элемента <see langword="Tuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 6.</exception>
		// Token: 0x17000158 RID: 344
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
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x0400132E RID: 4910
		private readonly T1 m_Item1;

		// Token: 0x0400132F RID: 4911
		private readonly T2 m_Item2;

		// Token: 0x04001330 RID: 4912
		private readonly T3 m_Item3;

		// Token: 0x04001331 RID: 4913
		private readonly T4 m_Item4;

		// Token: 0x04001332 RID: 4914
		private readonly T5 m_Item5;

		// Token: 0x04001333 RID: 4915
		private readonly T6 m_Item6;

		// Token: 0x04001334 RID: 4916
		private readonly T7 m_Item7;
	}
}
