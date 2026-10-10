using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из четырех компонентов.</summary>
	/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
	/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
	/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
	/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
	// Token: 0x0200019B RID: 411
	[Serializable]
	public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение первого компонента текущего объекта <see cref="T:System.Tuple`4" />.</summary>
		/// <returns>Значение первого компонента текущего объекта <see cref="T:System.Tuple`4" />.</returns>
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00042C5D File Offset: 0x00040E5D
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Получает значение второго компонента текущего объекта <see cref="T:System.Tuple`4" />.</summary>
		/// <returns>Значение второго компонента текущего объекта <see cref="T:System.Tuple`4" />.</returns>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00042C65 File Offset: 0x00040E65
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Получает значение третьего компонента текущего объекта <see cref="T:System.Tuple`4" />.</summary>
		/// <returns>Значение третьего компонента текущего объекта <see cref="T:System.Tuple`4" />.</returns>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00042C6D File Offset: 0x00040E6D
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Получает значение четвертого компонента текущего объекта <see cref="T:System.Tuple`4" />.</summary>
		/// <returns>Значение четвертого компонента текущего объекта <see cref="T:System.Tuple`4" />.</returns>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00042C75 File Offset: 0x00040E75
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`4" />.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		// Token: 0x06001072 RID: 4210 RVA: 0x00042C7D File Offset: 0x00040E7D
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`4" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001073 RID: 4211 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`4" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001074 RID: 4212 RVA: 0x00042CA4 File Offset: 0x00040EA4
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4> tuple = other as Tuple<T1, T2, T3, T4>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3)) && comparer.Equals(this.m_Item4, tuple.m_Item4);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`4" /> с заданным объектом и возвращает целое число, указывающее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`4" />.</exception>
		// Token: 0x06001075 RID: 4213 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`4" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`4" />.</exception>
		// Token: 0x06001076 RID: 4214 RVA: 0x00042D3C File Offset: 0x00040F3C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4> tuple = other as Tuple<T1, T2, T3, T4>;
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
			return comparer.Compare(this.m_Item4, tuple.m_Item4);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Tuple`4" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001077 RID: 4215 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`4" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`4" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001078 RID: 4216 RVA: 0x00042DFC File Offset: 0x00040FFC
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4));
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`4" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`4" />.</returns>
		// Token: 0x0600107A RID: 4218 RVA: 0x00042E54 File Offset: 0x00041054
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00042E78 File Offset: 0x00041078
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(", ");
			sb.Append(this.m_Item4);
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>4, количество элементов в объекте <see cref="T:System.Tuple`4" />.</returns>
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00022807 File Offset: 0x00020A07
		int ITuple.Length
		{
			get
			{
				return 4;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 3.</param>
		/// <returns>Значение элемента <see langword="Tuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 3.</exception>
		// Token: 0x17000140 RID: 320
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
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x0400131F RID: 4895
		private readonly T1 m_Item1;

		// Token: 0x04001320 RID: 4896
		private readonly T2 m_Item2;

		// Token: 0x04001321 RID: 4897
		private readonly T3 m_Item3;

		// Token: 0x04001322 RID: 4898
		private readonly T4 m_Item4;
	}
}
