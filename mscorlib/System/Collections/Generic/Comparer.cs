using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Collections.Generic
{
	/// <summary>Представляет базовый класс для реализаций универсального интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
	/// <typeparam name="T">Тип объектов для сравнения.</typeparam>
	// Token: 0x02000AC0 RID: 2752
	[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
	[Serializable]
	public abstract class Comparer<T> : IComparer, IComparer<T>
	{
		/// <summary>Возвращает компаратор по умолчанию для порядка сортировки, соответствующий типу, указанному универсальным аргументом.</summary>
		/// <returns>Объект, который наследует <see cref="T:System.Collections.Generic.Comparer`1" /> и служит компаратором, используемым при установлении порядка сортировки для типа <paramref name="T" />.</returns>
		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06006274 RID: 25204 RVA: 0x00149B38 File Offset: 0x00147D38
		public static Comparer<T> Default
		{
			get
			{
				Comparer<T> comparer = Comparer<T>.defaultComparer;
				if (comparer == null)
				{
					comparer = Comparer<T>.CreateComparer();
					Comparer<T>.defaultComparer = comparer;
				}
				return comparer;
			}
		}

		/// <summary>Создает компаратор с использованием указанного сравнения.</summary>
		/// <param name="comparison">Используемое сравнение.</param>
		/// <returns>Новый компаратор.</returns>
		// Token: 0x06006275 RID: 25205 RVA: 0x00149B5F File Offset: 0x00147D5F
		public static Comparer<T> Create(Comparison<T> comparison)
		{
			if (comparison == null)
			{
				throw new ArgumentNullException("comparison");
			}
			return new ComparisonComparer<T>(comparison);
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x00149B78 File Offset: 0x00147D78
		[SecuritySafeCritical]
		private static Comparer<T> CreateComparer()
		{
			RuntimeType runtimeType = (RuntimeType)typeof(T);
			if (typeof(IComparable<T>).IsAssignableFrom(runtimeType))
			{
				return (Comparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(GenericComparer<>), runtimeType);
			}
			if (runtimeType.IsGenericType && runtimeType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				RuntimeType runtimeType2 = (RuntimeType)runtimeType.GetGenericArguments()[0];
				if (typeof(IComparable<>).MakeGenericType(new Type[]
				{
					runtimeType2
				}).IsAssignableFrom(runtimeType2))
				{
					return (Comparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(NullableComparer<>), runtimeType2);
				}
			}
			return new ObjectComparer<T>();
		}

		/// <summary>При переопределении в производном классе выполняет сравнение двух объектов одного типа и возвращает значение, показывающее, что один объект меньше или больше другого объекта или равен ему.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="x" /> и <paramref name="y" />, как показано в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///  Значение <paramref name="x" /> меньше <paramref name="y" />.  
		///
		///   Нуль 
		///  <paramref name="x" /> равняется <paramref name="y" />.  
		///
		///   Больше нуля 
		///  Значение <paramref name="x" /> больше значения <paramref name="y" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="T" /> не реализует универсальный интерфейс <see cref="T:System.IComparable`1" /> или интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06006277 RID: 25207
		public abstract int Compare(T x, T y);

		/// <summary>Сравнение двух объектов и возврат значения, указывающего, является ли один объект меньшим, равным или большим другого.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="x" /> и <paramref name="y" />, как показано в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///  Значение <paramref name="x" /> меньше <paramref name="y" />.  
		///
		///   Нуль 
		///  <paramref name="x" /> равняется <paramref name="y" />.  
		///
		///   Больше нуля 
		///  Значение <paramref name="x" /> больше значения <paramref name="y" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="x" /> или <paramref name="y" /> имеет тип, который не может быть приведен к типу <paramref name="T" />.  
		///
		/// или - 
		/// <paramref name="x" /> и <paramref name="y" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" /> или интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06006278 RID: 25208 RVA: 0x00149C26 File Offset: 0x00147E26
		int IComparer.Compare(object x, object y)
		{
			if (x == null)
			{
				if (y != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				if (x is T && y is T)
				{
					return this.Compare((T)((object)x), (T)((object)y));
				}
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
				return 0;
			}
		}

		// Token: 0x04003A34 RID: 14900
		private static volatile Comparer<T> defaultComparer;
	}
}
