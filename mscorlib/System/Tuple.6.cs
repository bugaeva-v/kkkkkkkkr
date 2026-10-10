using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из пяти компонентов.</summary>
	/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
	/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
	/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
	/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
	/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
	// Token: 0x0200019C RID: 412
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение первого компонента текущего объекта <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Значение первого компонента текущего объекта <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00042F5A File Offset: 0x0004115A
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Получает значение второго компонента текущего объекта <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Значение второго компонента текущего объекта <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00042F62 File Offset: 0x00041162
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Получает значение третьего компонента текущего объекта <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Значение третьего компонента текущего объекта <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00042F6A File Offset: 0x0004116A
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Получает значение четвертого компонента текущего объекта <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Значение четвертого компонента текущего объекта <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00042F72 File Offset: 0x00041172
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		/// <summary>Получает значение пятого компонента текущего объекта <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Значение пятого компонента текущего объекта <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00042F7A File Offset: 0x0004117A
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`5" />.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		// Token: 0x06001083 RID: 4227 RVA: 0x00042F82 File Offset: 0x00041182
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`5" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001084 RID: 4228 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`5" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001085 RID: 4229 RVA: 0x00042FB0 File Offset: 0x000411B0
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5> tuple = other as Tuple<T1, T2, T3, T4, T5>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4)) && comparer.Equals(this.m_Item5, tuple.m_Item5);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`5" /> с заданным объектом и возвращает целое число, указывающее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`5" />.</exception>
		// Token: 0x06001086 RID: 4230 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`5" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`5" />.</exception>
		// Token: 0x06001087 RID: 4231 RVA: 0x00043064 File Offset: 0x00041264
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5> tuple = other as Tuple<T1, T2, T3, T4, T5>;
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
			return comparer.Compare(this.m_Item5, tuple.m_Item5);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001088 RID: 4232 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`5" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`5" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001089 RID: 4233 RVA: 0x00043148 File Offset: 0x00041348
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5));
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`5" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x0600108B RID: 4235 RVA: 0x000431B0 File Offset: 0x000413B0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000431D4 File Offset: 0x000413D4
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
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>5, количество элементов в объекте <see cref="T:System.Tuple`5" />.</returns>
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		int ITuple.Length
		{
			get
			{
				return 5;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 4.</param>
		/// <returns>Значение элемента <see langword="Tuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 4.</exception>
		// Token: 0x17000147 RID: 327
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

		// Token: 0x04001323 RID: 4899
		private readonly T1 m_Item1;

		// Token: 0x04001324 RID: 4900
		private readonly T2 m_Item2;

		// Token: 0x04001325 RID: 4901
		private readonly T3 m_Item3;

		// Token: 0x04001326 RID: 4902
		private readonly T4 m_Item4;

		// Token: 0x04001327 RID: 4903
		private readonly T5 m_Item5;
	}
}
