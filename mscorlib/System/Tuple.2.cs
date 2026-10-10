using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Представляет кортеж из одного компонента.</summary>
	/// <typeparam name="T1">Тип единственного компонента кортежа.</typeparam>
	// Token: 0x02000198 RID: 408
	[Serializable]
	public class Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Получает значение отдельного компонента объекта <see cref="T:System.Tuple`1" />.</summary>
		/// <returns>Значение отдельного компонента текущего объекта <see cref="T:System.Tuple`1" />.</returns>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000426F6 File Offset: 0x000408F6
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Tuple`1" />.</summary>
		/// <param name="item1">Значение единственного компонента кортежа.</param>
		// Token: 0x06001045 RID: 4165 RVA: 0x000426FE File Offset: 0x000408FE
		public Tuple(T1 item1)
		{
			this.m_Item1 = item1;
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект <see cref="T:System.Tuple`1" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001046 RID: 4166 RVA: 0x0004270D File Offset: 0x0004090D
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий атрибут <see cref="T:System.Tuple`1" /> указанному объекту при использовании заданного метода сравнения.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <param name="comparer">Объект, который определяет метод, используемый для вычисления равенства двух объектов.</param>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр равен указанному объекту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001047 RID: 4167 RVA: 0x0004271C File Offset: 0x0004091C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1> tuple = other as Tuple<T1>;
			return tuple != null && comparer.Equals(this.m_Item1, tuple.m_Item1);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`1" /> с указанным объектом и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		///   <paramref name="obj" /> не является объектом <see cref="T:System.Tuple`1" />.</exception>
		// Token: 0x06001048 RID: 4168 RVA: 0x00042756 File Offset: 0x00040956
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Tuple`1" /> с указанным объектом, используя заданный компаратор, и возвращает целое число, которое показывает положение текущего объекта относительно указанного объекта в порядке сортировки: перед объектом, после него или в той же позиции.</summary>
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
		///   <paramref name="other" /> не является объектом <see cref="T:System.Tuple`1" />.</exception>
		// Token: 0x06001049 RID: 4169 RVA: 0x00042764 File Offset: 0x00040964
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1> tuple = other as Tuple<T1>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return comparer.Compare(this.m_Item1, tuple.m_Item1);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Tuple`1" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600104A RID: 4170 RVA: 0x000427BC File Offset: 0x000409BC
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Вычисляет хэш-код для текущего объекта <see cref="T:System.Tuple`1" />, используя заданный метод вычисления.</summary>
		/// <param name="comparer">Объект, метод <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> которого вычисляет хэш-код текущего объекта <see cref="T:System.Tuple`1" />.</param>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600104B RID: 4171 RVA: 0x000427C9 File Offset: 0x000409C9
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.m_Item1);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000427DC File Offset: 0x000409DC
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return ((IStructuralEquatable)this).GetHashCode(comparer);
		}

		/// <summary>Возвращает строковое представление значения этого экземпляра <see cref="T:System.Tuple`1" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Tuple`1" />.</returns>
		// Token: 0x0600104D RID: 4173 RVA: 0x000427E8 File Offset: 0x000409E8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0004280B File Offset: 0x00040A0B
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Возвращает количество элементов в <see langword="Tuple" />.</summary>
		/// <returns>1, количество элементов в объекте <see cref="T:System.Tuple`1" />.</returns>
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x000040F7 File Offset: 0x000022F7
		int ITuple.Length
		{
			get
			{
				return 1;
			}
		}

		/// <summary>Получает значение элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс элемента <see langword="Tuple" />. <paramref name="index" /> должно быть равно 0.</param>
		/// <returns>Значение элемента <see langword="Tuple" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше 0 или больше 0.</exception>
		// Token: 0x17000131 RID: 305
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

		// Token: 0x04001319 RID: 4889
		private readonly T1 m_Item1;
	}
}
