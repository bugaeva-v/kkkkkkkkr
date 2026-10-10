using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из двух компонентов.</summary>
	/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
	/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
	// Token: 0x02000199 RID: 409
	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение первого компонента текущего объекта <see cref="T:System.Tuple`2" />.</summary>
		/// <returns>Значение первого компонента текущего объекта <see cref="T:System.Tuple`2" />.</returns>
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00042844 File Offset: 0x00040A44
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Получает значение второго компонента текущего объекта <see cref="T:System.Tuple`2" />.</summary>
		/// <returns>Значение второго компонента текущего объекта <see cref="T:System.Tuple`2" />.</returns>
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0004284C File Offset: 0x00040A4C
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`2" />.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		// Token: 0x06001053 RID: 4179 RVA: 0x00042854 File Offset: 0x00040A54
		public Tuple(T1 item1, T2 item2)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`2" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001054 RID: 4180 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`2" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001055 RID: 4181 RVA: 0x0004286C File Offset: 0x00040A6C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2> tuple = other as Tuple<T1, T2>;
			return tuple != null && comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`2" /> с заданным объектом и возвращает целое число, указывающее, находится ли текущий объект в той же позиции, что и указанный объект, после него или перед ним в порядке сортировки.</summary>
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
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`2" />.</exception>
		// Token: 0x06001056 RID: 4182 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`2" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <param name="comparer">Объект, предоставляющий настраиваемые правила для сравнения.</param>
		/// <returns>Целое число со знаком, определяющее относительное положение экземпляра и параметра <paramref name="other" /> в порядке сортировки, как показано в следующей таблице.  
		///   Значение 
		///   Описание 
		///   Отрицательное целое число 
		///   Данный экземпляр предшествует параметру <paramref name="other" />.  
		///
		///   Нуль 
		///   У этого экземпляра та же позиция в порядке сортировки, что и у <paramref name="other" />.  
		///
		///   Положительное целое число 
		///   Данный экземпляр стоит после параметра <paramref name="other" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`2" />.</exception>
		// Token: 0x06001057 RID: 4183 RVA: 0x000428C8 File Offset: 0x00040AC8
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2> tuple = other as Tuple<T1, T2>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			int num = comparer.Compare(this.m_Item1, tuple.m_Item1);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item2, tuple.m_Item2);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Tuple`2" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001058 RID: 4184 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`2" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`2" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001059 RID: 4185 RVA: 0x00042944 File Offset: 0x00040B44
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2));
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`2" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`2" />.</returns>
		// Token: 0x0600105B RID: 4187 RVA: 0x00042970 File Offset: 0x00040B70
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00042994 File Offset: 0x00040B94
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>2, количество элементов в объекте <see cref="T:System.Tuple`2" />.</returns>
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00015831 File Offset: 0x00013A31
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		/// <summary>Получает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. Значение <paramref name="index" /> может быть в диапазоне от 0 до 1.</param>
		/// <returns>Значение элемента <see langword="Tuple" /> в заданной позиции.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 1.</exception>
		// Token: 0x17000135 RID: 309
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

		// Token: 0x0400131A RID: 4890
		private readonly T1 m_Item1;

		// Token: 0x0400131B RID: 4891
		private readonly T2 m_Item2;
	}
}
