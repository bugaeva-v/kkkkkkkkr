using System;
using System.Collections.Generic;

namespace System
{
	/// <summary>Поддерживает тип значения, который можно присвоить <see langword="null" />. Этот класс не наследуется.</summary>
	// Token: 0x02000164 RID: 356
	public static class Nullable
	{
		/// <summary>Сравнивает значения двух объектов <see cref="T:System.Nullable`1" />.</summary>
		/// <param name="n1">Объект <see cref="T:System.Nullable`1" />.</param>
		/// <param name="n2">Объект <see cref="T:System.Nullable`1" />.</param>
		/// <typeparam name="T">Базовый тип значения параметров <paramref name="n1" /> и <paramref name="n2" />.</typeparam>
		/// <returns>Целое число, представляющее результат сравнений параметров <paramref name="n1" /> и <paramref name="n2" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Значение свойства <see cref="P:System.Nullable`1.HasValue" /> параметра <paramref name="n1" /> равно <see langword="false" />, а свойства <see cref="P:System.Nullable`1.HasValue" /> параметра <paramref name="n2" /> — <see langword="true" />.  
		///
		/// - или - 
		/// Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="true" />, а значение свойства <see cref="P:System.Nullable`1.Value" /> параметра <paramref name="n1" /> меньше значения свойства <see cref="P:System.Nullable`1.Value" /> параметра <paramref name="n2" />.  
		///
		///   Нуль 
		///   Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="false" />.  
		///
		/// - или - 
		/// Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="true" /> и при этом значение свойства <see cref="P:System.Nullable`1.Value" /> параметра <paramref name="n1" /> равно значению свойства <see cref="P:System.Nullable`1.Value" /> параметра <paramref name="n2" />.  
		///
		///   Больше нуля 
		///   Значение свойства <see cref="P:System.Nullable`1.HasValue" /> параметра <paramref name="n1" /> равно <see langword="true" />, а свойства <see cref="P:System.Nullable`1.HasValue" /> параметра <paramref name="n2" /> — <see langword="false" />.  
		///
		/// - или - 
		/// Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="true" />, а значение свойства <see cref="P:System.Nullable`1.Value" /> параметра <paramref name="n1" /> больше значения свойства <see cref="P:System.Nullable`1.Value" /> параметра <paramref name="n2" />.</returns>
		// Token: 0x06000DF5 RID: 3573 RVA: 0x00036152 File Offset: 0x00034352
		public static int Compare<T>(T? n1, T? n2) where T : struct
		{
			if (n1 != null)
			{
				if (n2 != null)
				{
					return Comparer<T>.Default.Compare(n1.value, n2.value);
				}
				return 1;
			}
			else
			{
				if (n2 != null)
				{
					return -1;
				}
				return 0;
			}
		}

		/// <summary>Указывает, равны ли значения двух заданных объектов <see cref="T:System.Nullable`1" />.</summary>
		/// <param name="n1">Объект <see cref="T:System.Nullable`1" />.</param>
		/// <param name="n2">Объект <see cref="T:System.Nullable`1" />.</param>
		/// <typeparam name="T">Базовый тип значения параметров <paramref name="n1" /> и <paramref name="n2" />.</typeparam>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="n1" /> равно значению параметра <paramref name="n2" />; в противном случае — значение <see langword="false" />.  
		/// Возвращаемое значение зависит от значений свойств <see cref="P:System.Nullable`1.HasValue" /> и <see cref="P:System.Nullable`1.Value" /> двух сравниваемых параметров.  
		///   Возвращаемое значение 
		///   Описание: 
		///  <see langword="true" /> Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="false" />.  
		///
		/// - или - 
		/// Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="true" /> и при этом значения свойств <see cref="P:System.Nullable`1.Value" /> у этих двух параметров равны.  
		///
		///  <see langword="false" /> Значение свойства <see cref="P:System.Nullable`1.HasValue" /> равно <see langword="true" /> для одного параметра и <see langword="false" /> для другого.  
		///
		/// - или - 
		/// Значения свойств <see cref="P:System.Nullable`1.HasValue" /> параметров <paramref name="n1" /> и <paramref name="n2" /> равны <see langword="true" /> и при этом значения свойств <see cref="P:System.Nullable`1.Value" /> у этих двух параметров неравны.</returns>
		// Token: 0x06000DF6 RID: 3574 RVA: 0x0003618B File Offset: 0x0003438B
		public static bool Equals<T>(T? n1, T? n2) where T : struct
		{
			if (n1 != null)
			{
				return n2 != null && EqualityComparer<T>.Default.Equals(n1.value, n2.value);
			}
			return n2 == null;
		}

		/// <summary>Возвращает аргумент заданного базового типа, допускающего значение NULL.</summary>
		/// <param name="nullableType">Объект <see cref="T:System.Type" />, описывающий закрытый универсальный тип, поддерживающий значение NULL.</param>
		/// <returns>Аргумент типа параметра <paramref name="nullableType" />, если параметр <paramref name="nullableType" /> является закрытым универсальным типом, допускающим значение NULL; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="nullableType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000DF7 RID: 3575 RVA: 0x000361C4 File Offset: 0x000343C4
		public static Type GetUnderlyingType(Type nullableType)
		{
			if (nullableType == null)
			{
				throw new ArgumentNullException("nullableType");
			}
			if (nullableType.IsGenericType && !nullableType.IsGenericTypeDefinition && nullableType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				return nullableType.GetGenericArguments()[0];
			}
			return null;
		}
	}
}
