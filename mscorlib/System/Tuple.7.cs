using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из шести компонентов.</summary>
	/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
	/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
	/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
	/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
	/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
	/// <typeparam name="T6">Тип шестого компонента кортежа.</typeparam>
	// Token: 0x0200019D RID: 413
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение первого компонента текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Значение первого компонента текущего объекта <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000432E6 File Offset: 0x000414E6
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Получает значение второго компонента текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Значение второго компонента текущего объекта <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x000432EE File Offset: 0x000414EE
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Получает значение третьего компонента текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Значение третьего компонента текущего объекта <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000432F6 File Offset: 0x000414F6
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Получает значение четвертого компонента текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Значение четвертого компонента текущего объекта <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x000432FE File Offset: 0x000414FE
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		/// <summary>Получает значение пятого компонента текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Значение текущего <see cref="T:System.Tuple`6" /> пятого компонента объекта.</returns>
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00043306 File Offset: 0x00041506
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		/// <summary>Получает значение шестого компонента текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Значение шестого компонента текущего объекта <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x0004330E File Offset: 0x0004150E
		public T6 Item6
		{
			get
			{
				return this.m_Item6;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`6" />.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <param name="item6">Значение шестого компонента кортежа.</param>
		// Token: 0x06001095 RID: 4245 RVA: 0x00043316 File Offset: 0x00041516
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
			this.m_Item6 = item6;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`6" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001096 RID: 4246 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`6" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001097 RID: 4247 RVA: 0x0004334C File Offset: 0x0004154C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6> tuple = other as Tuple<T1, T2, T3, T4, T5, T6>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4) && comparer.Equals(this.m_Item5, tuple.m_Item5)) && comparer.Equals(this.m_Item6, tuple.m_Item6);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`6" /> с заданным объектом и возвращает целое число, указывающее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`6" />.</exception>
		// Token: 0x06001098 RID: 4248 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`6" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`6" />.</exception>
		// Token: 0x06001099 RID: 4249 RVA: 0x00043424 File Offset: 0x00041624
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5, T6> tuple = other as Tuple<T1, T2, T3, T4, T5, T6>;
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
			return comparer.Compare(this.m_Item6, tuple.m_Item6);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600109A RID: 4250 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`6" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`6" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600109B RID: 4251 RVA: 0x00043528 File Offset: 0x00041728
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6));
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`6" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x0600109D RID: 4253 RVA: 0x000435A0 File Offset: 0x000417A0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x000435C4 File Offset: 0x000417C4
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
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>6, количество элементов в объекте <see cref="T:System.Tuple`6" />.</returns>
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x000224A3 File Offset: 0x000206A3
		int ITuple.Length
		{
			get
			{
				return 6;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 5.</param>
		/// <returns>Значение элемента <see langword="Tuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 5.</exception>
		// Token: 0x1700014F RID: 335
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
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x04001328 RID: 4904
		private readonly T1 m_Item1;

		// Token: 0x04001329 RID: 4905
		private readonly T2 m_Item2;

		// Token: 0x0400132A RID: 4906
		private readonly T3 m_Item3;

		// Token: 0x0400132B RID: 4907
		private readonly T4 m_Item4;

		// Token: 0x0400132C RID: 4908
		private readonly T5 m_Item5;

		// Token: 0x0400132D RID: 4909
		private readonly T6 m_Item6;
	}
}
