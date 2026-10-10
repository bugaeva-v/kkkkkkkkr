using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Предоставляет методы для создания, изменения, поиска и сортировки массивов, то есть выступает в роли базового класса для всех массивов в среде CLR.</summary>
	// Token: 0x020001D1 RID: 465
	[Serializable]
	public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
	{
		/// <summary>Создает многомерный массив <see cref="T:System.Array" /> заданного типа <see cref="T:System.Type" /> с заданными длинами по измерениям и индексацией, начинающейся с нуля. Длины по измерениям задаются в массиве 64-битовых целых чисел.</summary>
		/// <param name="elementType">Тип <see cref="T:System.Type" /> массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="lengths">Массив 64-разрядных целых чисел, представляющих размер каждого измерения массива <see cref="T:System.Array" />, который нужно создать. Каждое целое число в массиве должно лежать в диапазоне от нуля до <see cref="F:System.Int32.MaxValue" /> включительно.</param>
		/// <returns>Новый многомерный массив <see cref="T:System.Array" /> заданного типа <see cref="T:System.Type" /> с заданной для каждого измерения длиной и индексацией, начинающейся с нуля.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="elementType" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="lengths" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementType" /> не является допустимым <see cref="T:System.Type" />.  
		/// -или- 
		/// Массив <paramref name="lengths" /> содержит менее одного элемента.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="elementType" /> не поддерживается. Например, <see cref="T:System.Void" /> не поддерживается.  
		/// -или- 
		///  <paramref name="elementType" /> представляет собой открытый универсальный тип.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в <paramref name="lengths" /> меньше нуля или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060013DB RID: 5083 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		public static Array CreateInstance(Type elementType, params long[] lengths)
		{
			if (lengths == null)
			{
				throw new ArgumentNullException("lengths");
			}
			if (lengths.Length == 0)
			{
				throw new ArgumentException("Must provide at least one rank.");
			}
			int[] array = new int[lengths.Length];
			for (int i = 0; i < lengths.Length; i++)
			{
				long num = lengths[i];
				if (num > 2147483647L || num < -2147483648L)
				{
					throw new ArgumentOutOfRangeException("len", "Arrays larger than 2GB are not supported.");
				}
				array[i] = (int)num;
			}
			return Array.CreateInstance(elementType, array);
		}

		/// <summary>Возвращает для заданного массива доступную только для чтения программу-оболочку.</summary>
		/// <param name="array">Одномерный индексируемый от нуля массив, для которого создается доступная только для чтения программа-оболочка <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Доступная только для чтения оболочка <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> для указанного массива.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		// Token: 0x060013DC RID: 5084 RVA: 0x0004ECFF File Offset: 0x0004CEFF
		public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return new ReadOnlyCollection<T>(array);
		}

		/// <summary>Изменяет количество элементов в одномерном массиве до указанной величины.</summary>
		/// <param name="array">Подлежащий изменению размера одномерный массив, индексация которого начинается с нуля, или значение <see langword="null" /> для создания нового массива заданного размера.</param>
		/// <param name="newSize">Размер нового массива.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="newSize" /> меньше нуля.</exception>
		// Token: 0x060013DD RID: 5085 RVA: 0x0004ED18 File Offset: 0x0004CF18
		public static void Resize<T>(ref T[] array, int newSize)
		{
			if (newSize < 0)
			{
				throw new ArgumentOutOfRangeException("newSize", "Non-negative number required.");
			}
			T[] array2 = array;
			if (array2 == null)
			{
				array = new T[newSize];
				return;
			}
			if (array2.Length != newSize)
			{
				T[] array3 = new T[newSize];
				Array.Copy(array2, 0, array3, 0, (array2.Length > newSize) ? newSize : array2.Length);
				array = array3;
			}
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Array" />.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0004ED6D File Offset: 0x0004CF6D
		int ICollection.Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Индекс элемента, который необходимо получить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ICollection.Count" />.</exception>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно одного измерения.</exception>
		// Token: 0x170001E1 RID: 481
		object IList.this[int index]
		{
			get
			{
				return this.GetValue(index);
			}
			set
			{
				this.SetValue(value, index);
			}
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">Объект, который должен быть добавлен в коллекцию <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Добавление значений в массив не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		// Token: 0x060013E2 RID: 5090 RVA: 0x0004ED88 File Offset: 0x0004CF88
		int IList.Add(object value)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект, который требуется найти в текущем списке. Элемент, который требуется найти, для ссылочных типов может быть равен <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> найден в коллекции <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060013E3 RID: 5091 RVA: 0x0004ED94 File Offset: 0x0004CF94
		bool IList.Contains(object value)
		{
			return Array.IndexOf(this, value) >= 0;
		}

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.</exception>
		// Token: 0x060013E4 RID: 5092 RVA: 0x0004EDA3 File Offset: 0x0004CFA3
		void IList.Clear()
		{
			Array.Clear(this, this.GetLowerBound(0), this.Length);
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект, который требуется найти в текущем списке.</param>
		/// <returns>Индекс значения, если оно найдено в списке; в противном случае — значение, равное -1.</returns>
		// Token: 0x060013E5 RID: 5093 RVA: 0x0004EDB8 File Offset: 0x0004CFB8
		int IList.IndexOf(object value)
		{
			return Array.IndexOf(this, value);
		}

		/// <summary>Вставляет элемент в список <see cref="T:System.Collections.IList" /> по указанному индексу.</summary>
		/// <param name="index">Индекс, по которому требуется вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Вставляемый объект.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="value" /> — пустая ссылка в списке <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x060013E6 RID: 5094 RVA: 0x0004ED88 File Offset: 0x0004CF88
		void IList.Insert(int index, object value)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		// Token: 0x060013E7 RID: 5095 RVA: 0x0004ED88 File Offset: 0x0004CF88
		void IList.Remove(object value)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Удаляет элемент <see cref="T:System.Collections.IList" />, расположенный по указанному индексу.</summary>
		/// <param name="index">Индекс элемента, который должен быть удален.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Индекс не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		// Token: 0x060013E8 RID: 5096 RVA: 0x0004ED88 File Offset: 0x0004CF88
		void IList.RemoveAt(int index)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Копирует все элементы текущего одномерного массива в заданный одномерный массив начиная с указанного индекса в массиве назначения. Индекс задается как 32-битовое целое число.</summary>
		/// <param name="array">Одномерный массив, который является массивом назначения для элементов, скопированных из текущего массива.</param>
		/// <param name="index">32-разрядное целое число, представляющее индекс в массиве <paramref name="array" />, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов в исходном массиве больше доступного числа элементов от индекса <paramref name="index" /> до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">Тип исходного массива <see cref="T:System.Array" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">Исходный массив — многомерный.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в исходном массиве <see cref="T:System.Array" /> нельзя привести к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060013E9 RID: 5097 RVA: 0x0004EDC1 File Offset: 0x0004CFC1
		public void CopyTo(Array array, int index)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			Array.Copy(this, this.GetLowerBound(0), array, index, this.Length);
		}

		/// <summary>Создает неполную копию <see cref="T:System.Array" />.</summary>
		/// <returns>Неполная копия <see cref="T:System.Array" />.</returns>
		// Token: 0x060013EA RID: 5098 RVA: 0x000231CD File Offset: 0x000213CD
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет позицию текущего объекта коллекции относительно другого объекта в порядке сортировки (находится перед другим объектов, на одной позиции с ним или после другого объекта).</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <param name="comparer">Объект, который сравнивает текущий объект и объект <paramref name="other" />.</param>
		/// <returns>Целое число, определяющее, как соотносятся между собой текущий объект коллекции и другой объект. Возможные соотношения показаны в следующей таблице.  
		///   Возвращаемое значение 
		///   Описание 
		///   -1 
		///   Текущий экземпляр стоит перед объектом <paramref name="other" />.  
		///
		///   0 
		///   Текущий экземпляр и объект <paramref name="other" /> равны.  
		///
		///   1 
		///   Текущий экземпляр стоит после объекта <paramref name="other" />.</returns>
		// Token: 0x060013EB RID: 5099 RVA: 0x0004EDF0 File Offset: 0x0004CFF0
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Array array = other as Array;
			if (array == null || this.Length != array.Length)
			{
				throw new ArgumentException("Object is not a array with the same number of elements as the array to compare it to.", "other");
			}
			int num = 0;
			int num2 = 0;
			while (num < array.Length && num2 == 0)
			{
				object value = this.GetValue(num);
				object value2 = array.GetValue(num);
				num2 = comparer.Compare(value, value2);
				num++;
			}
			return num2;
		}

		/// <summary>Определяет, равен ли объект текущему экземпляру.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <param name="comparer">Объект, определяющий, равны ли текущий экземпляр и объект <paramref name="other" />.</param>
		/// <returns>Значение <see langword="true" />, если эти два объекта равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060013EC RID: 5100 RVA: 0x0004EE5C File Offset: 0x0004D05C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			Array array = other as Array;
			if (array == null || array.Length != this.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				object value = this.GetValue(i);
				object value2 = array.GetValue(i);
				if (!comparer.Equals(value, value2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00033E4B File Offset: 0x0003204B
		internal static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <param name="comparer">Объект, вычисляющий хэш-код текущего объекта.</param>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x060013EE RID: 5102 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			int num = 0;
			for (int i = (this.Length >= 8) ? (this.Length - 8) : 0; i < this.Length; i++)
			{
				num = Array.CombineHashCodes(num, comparer.GetHashCode(this.GetValue(i)));
			}
			return num;
		}

		/// <summary>Выполняет поиск заданного элемента во всем отсортированном одномерном массиве, используя интерфейс <see cref="T:System.IComparable" />, реализуемый каждым элементом массива и заданным объектом.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, в котором выполняется поиск.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> относится к типу, который несовместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IComparable" />, и поиск обнаруживает элемент, который не реализует интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x060013EF RID: 5103 RVA: 0x0004EF12 File Offset: 0x0004D112
		public static int BinarySearch(Array array, object value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch(array, array.GetLowerBound(0), array.Length, value, null);
		}

		/// <summary>Преобразует массив одного типа в массив другого типа.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и который преобразуется в целевой тип.</param>
		/// <param name="converter">Объект <see cref="T:System.Converter`2" />, преобразующий каждый элемент из одного типа в другой.</param>
		/// <typeparam name="TInput">Тип элементов исходного массива.</typeparam>
		/// <typeparam name="TOutput">Тип элементов массива назначения.</typeparam>
		/// <returns>Массив целевого типа, содержащий преобразованные элементы исходного массива.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="converter" /> — <see langword="null" />.</exception>
		// Token: 0x060013F0 RID: 5104 RVA: 0x0004EF38 File Offset: 0x0004D138
		public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (converter == null)
			{
				throw new ArgumentNullException("converter");
			}
			TOutput[] array2 = new TOutput[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = converter(array[i]);
			}
			return array2;
		}

		/// <summary>Копирует диапазон элементов из массива <see cref="T:System.Array" />, начиная с первого элемента, и вставляет его в другой массив <see cref="T:System.Array" />, также начиная с первого элемента. Длина задается как 64-битовое целое число.</summary>
		/// <param name="sourceArray">Массив <see cref="T:System.Array" />, содержащий данные, которые требуется скопировать.</param>
		/// <param name="destinationArray">Массив <see cref="T:System.Array" />, принимающий данные.</param>
		/// <param name="length">64-битовое целое число, представляющее число копируемых элементов. Целое число должно лежать в диапазоне от 0 до <see cref="F:System.Int32.MaxValue" /> включительно.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceArray" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="destinationArray" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют различные ранги.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют несовместимые типы.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в <paramref name="sourceArray" /> не может быть приведен к типу <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="length" /> имеет значение меньше 0 или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="length" /> больше числа элементов в <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="length" /> больше числа элементов в <paramref name="destinationArray" />.</exception>
		// Token: 0x060013F1 RID: 5105 RVA: 0x0004EF8D File Offset: 0x0004D18D
		public static void Copy(Array sourceArray, Array destinationArray, long length)
		{
			if (length > 2147483647L || length < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("length", "Arrays larger than 2GB are not supported.");
			}
			Array.Copy(sourceArray, destinationArray, (int)length);
		}

		/// <summary>Копирует диапазон элементов из массива <see cref="T:System.Array" />, начиная с заданного индекса источника, и вставляет его в другой массив <see cref="T:System.Array" />, начиная с заданного индекса назначения. Длина и индексы задаются как 64-битовые целые числа.</summary>
		/// <param name="sourceArray">Массив <see cref="T:System.Array" />, содержащий данные, которые требуется скопировать.</param>
		/// <param name="sourceIndex">64-разрядное целое число, представляющее индекс в массиве <paramref name="sourceArray" />, с которого начинается копирование.</param>
		/// <param name="destinationArray">Массив <see cref="T:System.Array" />, принимающий данные.</param>
		/// <param name="destinationIndex">64-разрядное целое число, представляющее индекс в массиве <paramref name="destinationArray" />, с которого начинается сохранение.</param>
		/// <param name="length">64-битовое целое число, представляющее число копируемых элементов. Целое число должно лежать в диапазоне от 0 до <see cref="F:System.Int32.MaxValue" /> включительно.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceArray" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="destinationArray" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют различные ранги.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют несовместимые типы.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в <paramref name="sourceArray" /> не может быть приведен к типу <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="sourceIndex" /> находится вне диапазона допустимых индексов для <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="destinationIndex" /> находится вне диапазона допустимых индексов для <paramref name="destinationArray" />.  
		/// -или- 
		///  Параметр <paramref name="length" /> имеет значение меньше 0 или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="length" /> больше числа элементов с <paramref name="sourceIndex" /> до конца <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="length" /> больше числа элементов с <paramref name="destinationIndex" /> до конца <paramref name="destinationArray" />.</exception>
		// Token: 0x060013F2 RID: 5106 RVA: 0x0004EFBC File Offset: 0x0004D1BC
		public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
		{
			if (sourceIndex > 2147483647L || sourceIndex < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Arrays larger than 2GB are not supported.");
			}
			if (destinationIndex > 2147483647L || destinationIndex < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Arrays larger than 2GB are not supported.");
			}
			if (length > 2147483647L || length < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("length", "Arrays larger than 2GB are not supported.");
			}
			Array.Copy(sourceArray, (int)sourceIndex, destinationArray, (int)destinationIndex, (int)length);
		}

		/// <summary>Копирует все элементы текущего одномерного массива в заданный одномерный массив начиная с указанного индекса в массиве назначения. Индекс задается как 64-битовое целое число.</summary>
		/// <param name="array">Одномерный массив, который является массивом назначения для элементов, скопированных из текущего массива.</param>
		/// <param name="index">64-разрядное целое число, представляющее индекс в массиве <paramref name="array" />, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов в исходном массиве больше доступного числа элементов от индекса <paramref name="index" /> до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">Тип исходного массива <see cref="T:System.Array" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">Исходный массив <see cref="T:System.Array" /> — многомерный.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в исходном массиве <see cref="T:System.Array" /> нельзя привести к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060013F3 RID: 5107 RVA: 0x0004F03F File Offset: 0x0004D23F
		public void CopyTo(Array array, long index)
		{
			if (index > 2147483647L || index < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index", "Arrays larger than 2GB are not supported.");
			}
			this.CopyTo(array, (int)index);
		}

		/// <summary>Выполняет указанное действие с каждым элементом указанного массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и для элементов которого нужно выполнить данное действие.</param>
		/// <param name="action">Действие <see cref="T:System.Action`1" />, выполняемое для каждого элемента массива <paramref name="array" />.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="action" /> — <see langword="null" />.</exception>
		// Token: 0x060013F4 RID: 5108 RVA: 0x0004F06C File Offset: 0x0004D26C
		public static void ForEach<T>(T[] array, Action<T> action)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			for (int i = 0; i < array.Length; i++)
			{
				action(array[i]);
			}
		}

		/// <summary>Возвращает 64-разрядное целое число, представляющее общее число элементов во всех измерениях массива <see cref="T:System.Array" />.</summary>
		/// <returns>64-разрядное целое число, представляющее общее число элементов во всех измерениях массива <see cref="T:System.Array" />.</returns>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		public long LongLength
		{
			get
			{
				long num = (long)this.GetLength(0);
				for (int i = 1; i < this.Rank; i++)
				{
					num *= (long)this.GetLength(i);
				}
				return num;
			}
		}

		/// <summary>Возвращает 64-разрядное целое число, представляющее количество элементов в заданном измерении массива <see cref="T:System.Array" />.</summary>
		/// <param name="dimension">Измерение массива <see cref="T:System.Array" />, индексация которого начинается с нуля, для которого требуется определить длину.</param>
		/// <returns>64-битовое целое число, представляющее количество элементов в заданном измерении.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="dimension" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="dimension" /> больше или равно значению свойства <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x060013F6 RID: 5110 RVA: 0x0004F0E3 File Offset: 0x0004D2E3
		public long GetLongLength(int dimension)
		{
			return (long)this.GetLength(dimension);
		}

		/// <summary>Возвращает значение, хранящееся в указанной позиции одномерного массива <see cref="T:System.Array" />. Индекс задается как 64-битовое целое число.</summary>
		/// <param name="index">64-разрядное целое число, представляющее позицию возвращаемого элемента <see cref="T:System.Array" />.</param>
		/// <returns>Значение, хранящееся в указанной позиции одномерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно одного измерения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x060013F7 RID: 5111 RVA: 0x0004F0ED File Offset: 0x0004D2ED
		public object GetValue(long index)
		{
			if (index > 2147483647L || index < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index", "Arrays larger than 2GB are not supported.");
			}
			return this.GetValue((int)index);
		}

		/// <summary>Получает значение в заданной позиции двумерного массива <see cref="T:System.Array" />. Индексы задаются в виде 64-битовых целых чисел.</summary>
		/// <param name="index1">64-разрядное целое число, представляющее индекс возвращаемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">64-разрядное целое число, представляющее индекс возвращаемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <returns>Значение, находящееся в указанной позиции двумерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно двух измерений.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index1" /> или <paramref name="index2" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x060013F8 RID: 5112 RVA: 0x0004F11C File Offset: 0x0004D31C
		public object GetValue(long index1, long index2)
		{
			if (index1 > 2147483647L || index1 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index1", "Arrays larger than 2GB are not supported.");
			}
			if (index2 > 2147483647L || index2 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index2", "Arrays larger than 2GB are not supported.");
			}
			return this.GetValue((int)index1, (int)index2);
		}

		/// <summary>Получает значение, хранящееся в указанной позиции трехмерного массива <see cref="T:System.Array" />. Индексы задаются в виде 64-битовых целых чисел.</summary>
		/// <param name="index1">64-разрядное целое число, представляющее индекс возвращаемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">64-разрядное целое число, представляющее индекс возвращаемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index3">64-разрядное целое число, представляющее индекс возвращаемого элемента в третьем измерении массива <see cref="T:System.Array" />.</param>
		/// <returns>Значение, хранящееся в указанной позиции трехмерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно трех измерений.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index1" />, <paramref name="index2" /> или <paramref name="index3" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x060013F9 RID: 5113 RVA: 0x0004F178 File Offset: 0x0004D378
		public object GetValue(long index1, long index2, long index3)
		{
			if (index1 > 2147483647L || index1 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index1", "Arrays larger than 2GB are not supported.");
			}
			if (index2 > 2147483647L || index2 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index2", "Arrays larger than 2GB are not supported.");
			}
			if (index3 > 2147483647L || index3 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index3", "Arrays larger than 2GB are not supported.");
			}
			return this.GetValue((int)index1, (int)index2, (int)index3);
		}

		/// <summary>Получает значение, находящееся в указанной позиции многомерного массива <see cref="T:System.Array" />. Индексы задаются как массив 64-битовых целых чисел.</summary>
		/// <param name="indices">Одномерный массив 64-разрядных целых чисел, представляющих индексы, которые определяют позицию возвращаемого элемента <see cref="T:System.Array" />.</param>
		/// <returns>Значение, находящееся в указанной позиции многомерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="indices" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число измерений в текущем массиве <see cref="T:System.Array" /> не равно числу элементов в <paramref name="indices" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Любой элемент в <paramref name="indices" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x060013FA RID: 5114 RVA: 0x0004F1F8 File Offset: 0x0004D3F8
		public object GetValue(params long[] indices)
		{
			if (indices == null)
			{
				throw new ArgumentNullException("indices");
			}
			if (this.Rank != indices.Length)
			{
				throw new ArgumentException("Indices length does not match the array rank.");
			}
			int[] array = new int[indices.Length];
			for (int i = 0; i < indices.Length; i++)
			{
				long num = indices[i];
				if (num > 2147483647L || num < -2147483648L)
				{
					throw new ArgumentOutOfRangeException("index", "Arrays larger than 2GB are not supported.");
				}
				array[i] = (int)num;
			}
			return this.GetValue(array);
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Array" /> фиксированный размер.</summary>
		/// <returns>Данное свойство для всех массивов всегда имеет значение <see langword="true" />.</returns>
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Array" /> доступным только для чтения.</summary>
		/// <returns>Данное свойство для всех массивов всегда имеет значение <see langword="false" />.</returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Array" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Данное свойство для всех массивов всегда имеет значение <see langword="false" />.</returns>
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Array" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Array" />.</returns>
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0000270D File Offset: 0x0000090D
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Выполняет поиск значения в диапазоне элементов отсортированного одномерного массива, используя интерфейс <see cref="T:System.IComparable" />, реализуемый каждым элементом массива и заданным значением.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, в котором выполняется поиск.</param>
		/// <param name="index">Начальный индекс диапазона поиска.</param>
		/// <param name="length">Длина диапазона поиска.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.  
		/// -или- 
		///  <paramref name="value" /> относится к типу, который не совместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="value" /> не реализует интерфейс <see cref="T:System.IComparable" />, и поиск обнаруживает элемент, который не реализует интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x060013FF RID: 5119 RVA: 0x0004F272 File Offset: 0x0004D472
		public static int BinarySearch(Array array, int index, int length, object value)
		{
			return Array.BinarySearch(array, index, length, value, null);
		}

		/// <summary>Выполняет поиск значения во всем отсортированном одномерном массиве, используя указанный универсальный интерфейс <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, в котором выполняется поиск.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и <paramref name="value" /> относится к типу, который несовместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, <paramref name="value" /> не реализует интерфейс <see cref="T:System.IComparable" />, а при поиске обнаруживается элемент, который не реализует интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06001400 RID: 5120 RVA: 0x0004F27E File Offset: 0x0004D47E
		public static int BinarySearch(Array array, object value, IComparer comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch(array, array.GetLowerBound(0), array.Length, value, comparer);
		}

		/// <summary>Выполняет поиск значения в диапазоне элементов отсортированного одномерного массива, используя указанный интерфейс <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, в котором выполняется поиск.</param>
		/// <param name="index">Начальный индекс диапазона поиска.</param>
		/// <param name="length">Длина диапазона поиска.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.  
		/// -или- 
		///  <paramref name="comparer" /> имеет значение <see langword="null" />, и <paramref name="value" /> относится к типу, который несовместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, <paramref name="value" /> не реализует интерфейс <see cref="T:System.IComparable" />, а при поиске обнаруживается элемент, который не реализует интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06001401 RID: 5121 RVA: 0x0004F2A4 File Offset: 0x0004D4A4
		public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			if (comparer == null)
			{
				comparer = Comparer.Default;
			}
			int i = index;
			int num = index + length - 1;
			object[] array2 = array as object[];
			if (array2 != null)
			{
				while (i <= num)
				{
					int median = Array.GetMedian(i, num);
					int num2;
					try
					{
						num2 = comparer.Compare(array2[median], value);
					}
					catch (Exception innerException)
					{
						throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
					}
					if (num2 == 0)
					{
						return median;
					}
					if (num2 < 0)
					{
						i = median + 1;
					}
					else
					{
						num = median - 1;
					}
				}
			}
			else
			{
				while (i <= num)
				{
					int median2 = Array.GetMedian(i, num);
					int num3;
					try
					{
						num3 = comparer.Compare(array.GetValue(median2), value);
					}
					catch (Exception innerException2)
					{
						throw new InvalidOperationException("Failed to compare two elements in the array.", innerException2);
					}
					if (num3 == 0)
					{
						return median2;
					}
					if (num3 < 0)
					{
						i = median2 + 1;
					}
					else
					{
						num = median2 - 1;
					}
				}
			}
			return ~i;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
		private static int GetMedian(int low, int hi)
		{
			return low + (hi - low >> 1);
		}

		/// <summary>Выполняет поиск заданного элемента во всем отсортированном одномерном массиве, используя для этого универсальный интерфейс <see cref="T:System.IComparable`1" />, реализуемый каждым элементом массива <see cref="T:System.Array" /> и заданным объектом.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором выполняется поиск.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="T" /> не реализует универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001403 RID: 5123 RVA: 0x0004F3E1 File Offset: 0x0004D5E1
		public static int BinarySearch<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch<T>(array, 0, array.Length, value, null);
		}

		/// <summary>Выполняет поиск значения во всем отсортированном одномерном массиве, используя указанный универсальный интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором выполняется поиск.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable`1" /> каждого элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, а <paramref name="value" /> относится к типу, который несовместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, а <paramref name="T" /> не реализует универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001404 RID: 5124 RVA: 0x0004F3FD File Offset: 0x0004D5FD
		public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch<T>(array, 0, array.Length, value, comparer);
		}

		/// <summary>Выполняет поиск значения в диапазоне элементов отсортированного одномерного массива, используя для этого универсальный интерфейс <see cref="T:System.IComparable`1" />, реализуемый каждым элементом массива <see cref="T:System.Array" /> и заданным значением.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором выполняется поиск.</param>
		/// <param name="index">Начальный индекс диапазона поиска.</param>
		/// <param name="length">Длина диапазона поиска.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.  
		/// -или- 
		///  <paramref name="value" /> относится к типу, который не совместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="T" /> не реализует универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001405 RID: 5125 RVA: 0x0004F419 File Offset: 0x0004D619
		public static int BinarySearch<T>(T[] array, int index, int length, T value)
		{
			return Array.BinarySearch<T>(array, index, length, value, null);
		}

		/// <summary>Выполняет поиск значения в диапазоне элементов отсортированного одномерного массива, используя указанный универсальный интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="array">Отсортированный одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором выполняется поиск.</param>
		/// <param name="index">Начальный индекс диапазона поиска.</param>
		/// <param name="length">Длина диапазона поиска.</param>
		/// <param name="value">Объект, который нужно найти.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable`1" /> каждого элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Индекс заданного параметра <paramref name="value" /> в указанном массиве <paramref name="array" />, если параметр <paramref name="value" /> найден; в противном случае — отрицательное число. Если параметр <paramref name="value" /> не найден и значение параметра <paramref name="value" /> меньше одного или нескольких элементов массива <paramref name="array" />, возвращенное отрицательное число —это побитовое дополнение индекса первого элемента, превышающего по значению параметр <paramref name="value" />. Если параметр <paramref name="value" /> не найден и значение <paramref name="value" /> больше всех элементов массива <paramref name="array" />, возвращенное отрицательное число является побитовым дополнением увеличенного на 1 индекса последнего элемента. Если этот метод вызывается с неотсортированным <paramref name="array" />, возвращаемое значение может быть неправильным, и может быть возвращено отрицательное число, даже если <paramref name="value" /> присутствует в <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.  
		/// -или- 
		///  <paramref name="comparer" /> имеет значение <see langword="null" />, и <paramref name="value" /> относится к типу, который несовместим с элементами <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и <paramref name="T" /> не реализует универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001406 RID: 5126 RVA: 0x0004F428 File Offset: 0x0004D628
		public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return ArraySortHelper<T>.Default.BinarySearch(array, index, length, value, comparer);
		}

		/// <summary>Выполняет поиск указанного объекта внутри всего одномерного массива и возвращает индекс его первого вхождения.</summary>
		/// <param name="array">Одномерный массив для поиска.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <returns>Индекс первого вхождения <paramref name="value" /> в массиве <paramref name="array" />, если найден. В противном случае — нижняя граница массива минус 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x06001407 RID: 5127 RVA: 0x0004F489 File Offset: 0x0004D689
		public static int IndexOf(Array array, object value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.IndexOf(array, value, array.GetLowerBound(0), array.Length);
		}

		/// <summary>Выполняет поиск указанного объекта в диапазоне элементов одномерного массива и возвращает индекс первого найденного совпадения. Диапазон расширяется от указанного индекса до конца массива.</summary>
		/// <param name="array">Одномерный массив для поиска.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Начальный индекс поиска. Значение 0 (ноль) действительно в пустом массиве.</param>
		/// <returns>Индекс первого вхождения значения <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, начинающемся с элемента с индексом <paramref name="startIndex" /> и заканчивающемся последним элементом, если значение найдено; в противном случае нижняя граница массива минус 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x06001408 RID: 5128 RVA: 0x0004F4B0 File Offset: 0x0004D6B0
		public static int IndexOf(Array array, object value, int startIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int lowerBound = array.GetLowerBound(0);
			return Array.IndexOf(array, value, startIndex, array.Length - startIndex + lowerBound);
		}

		/// <summary>Выполняет поиск указанного объекта в диапазоне элементов одномерного массива и возвращает индекс первого найденного совпадения. Диапазон расширяется от указанного индекса заданного числа элементов.</summary>
		/// <param name="array">Одномерный массив для поиска.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Начальный индекс поиска. Значение 0 (ноль) действительно в пустом массиве.</param>
		/// <param name="count">Число искомых элементов.</param>
		/// <returns>Индекс первого вхождения значения <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, начинающемся с индекса <paramref name="startIndex" /> и заканчивающемся элементом с индексом <paramref name="startIndex" /> + <paramref name="count" /> — 1, если значение найдено. В противном случае нижняя граница массива минус 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x06001409 RID: 5129 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		public static int IndexOf(Array array, object value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			int lowerBound = array.GetLowerBound(0);
			if (startIndex < lowerBound || startIndex > array.Length + lowerBound)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count > array.Length - startIndex + lowerBound)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			object[] array2 = array as object[];
			int num = startIndex + count;
			if (array2 != null)
			{
				if (value == null)
				{
					for (int i = startIndex; i < num; i++)
					{
						if (array2[i] == null)
						{
							return i;
						}
					}
				}
				else
				{
					for (int j = startIndex; j < num; j++)
					{
						object obj = array2[j];
						if (obj != null && obj.Equals(value))
						{
							return j;
						}
					}
				}
			}
			else
			{
				for (int k = startIndex; k < num; k++)
				{
					object value2 = array.GetValue(k);
					if (value2 == null)
					{
						if (value == null)
						{
							return k;
						}
					}
					else if (value2.Equals(value))
					{
						return k;
					}
				}
			}
			return lowerBound - 1;
		}

		/// <summary>Выполняет поиск указанного объекта внутри всего одномерного массива и возвращает индекс его первого вхождения.</summary>
		/// <param name="array">Индексируемый от нуля одномерный массив, в котором выполняется поиск.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения объекта <paramref name="value" /> во всем массиве <paramref name="array" />; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		// Token: 0x0600140A RID: 5130 RVA: 0x0004F5E2 File Offset: 0x0004D7E2
		public static int IndexOf<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.IndexOfImpl<T>(array, value, 0, array.Length);
		}

		/// <summary>Выполняет поиск указанного объекта в диапазоне элементов одномерного массива и возвращает индекс первого найденного совпадения. Диапазон расширяется от указанного индекса до конца массива.</summary>
		/// <param name="array">Индексируемый от нуля одномерный массив, в котором выполняется поиск.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска. Значение 0 (ноль) действительно в пустом массиве.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента <paramref name="value" /> в диапазоне элементов списка <paramref name="array" />, начиная с позиции <paramref name="startIndex" /> и до конца списка, если элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		// Token: 0x0600140B RID: 5131 RVA: 0x0004F5FD File Offset: 0x0004D7FD
		public static int IndexOf<T>(T[] array, T value, int startIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.IndexOf<T>(array, value, startIndex, array.Length - startIndex);
		}

		/// <summary>Выполняет поиск указанного объекта в диапазоне элементов одномерного массива и возвращает индекс первого найденного совпадения. Диапазон расширяется от указанного индекса заданного числа элементов.</summary>
		/// <param name="array">Индексируемый от нуля одномерный массив, в котором выполняется поиск.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска. Значение 0 (ноль) действительно в пустом массиве.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, который начинается с позиции <paramref name="startIndex" /> и содержит количество элементов, указанное в <paramref name="count" />, если искомый объект найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <paramref name="array" />.</exception>
		// Token: 0x0600140C RID: 5132 RVA: 0x0004F61C File Offset: 0x0004D81C
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (startIndex < 0 || startIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count > array.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			return Array.IndexOfImpl<T>(array, value, startIndex, count);
		}

		/// <summary>Выполняет поиск заданного объекта и возвращает индекс его последнего вхождения внутри всего одномерного массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> для поиска.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <returns>Индекс последнего вхождения <paramref name="value" /> в массиве <paramref name="array" />, если найден; в противном случае — нижняя граница массива минус 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x0600140D RID: 5133 RVA: 0x0004F676 File Offset: 0x0004D876
		public static int LastIndexOf(Array array, object value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.LastIndexOf(array, value, array.Length - 1, array.Length);
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает индекс его последнего вхождения в диапазоне элементов одномерного массива <see cref="T:System.Array" />, который начинается с первого элемента и заканчивается элементом с заданным индексом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> для поиска.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Начальный индекс обратного поиска.</param>
		/// <returns>Индекс последнего вхождения значения <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, который начинается с первого элемента и заканчивается элементом с индексом <paramref name="startIndex" />, если объект найден; в противном случае — нижняя граница массива минус 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x0600140E RID: 5134 RVA: 0x0004F69B File Offset: 0x0004D89B
		public static int LastIndexOf(Array array, object value, int startIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.LastIndexOf(array, value, startIndex, startIndex + 1);
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает индекс последнего вхождения в диапазоне элементов одномерного массива <see cref="T:System.Array" />, который содержит указанное число элементов и заканчивается элементом с заданным индексом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> для поиска.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Начальный индекс обратного поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Индекс последнего вхождения значения <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, который содержит число элементов, заданных в параметре <paramref name="count" />, и заканчивается элементом с индексом <paramref name="startIndex" />, если объект найден; в противном случае — нижняя граница массива минус 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x0600140F RID: 5135 RVA: 0x0004F6B8 File Offset: 0x0004D8B8
		public static int LastIndexOf(Array array, object value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Length == 0)
			{
				return -1;
			}
			if (startIndex < 0 || startIndex >= array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (count > startIndex + 1)
			{
				throw new ArgumentOutOfRangeException("endIndex", "endIndex cannot be greater than startIndex.");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			object[] array2 = array as object[];
			int num = startIndex - count + 1;
			if (array2 != null)
			{
				if (value == null)
				{
					for (int i = startIndex; i >= num; i--)
					{
						if (array2[i] == null)
						{
							return i;
						}
					}
				}
				else
				{
					for (int j = startIndex; j >= num; j--)
					{
						object obj = array2[j];
						if (obj != null && obj.Equals(value))
						{
							return j;
						}
					}
				}
			}
			else
			{
				for (int k = startIndex; k >= num; k--)
				{
					object value2 = array.GetValue(k);
					if (value2 == null)
					{
						if (value == null)
						{
							return k;
						}
					}
					else if (value2.Equals(value))
					{
						return k;
					}
				}
			}
			return -1;
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает индекс последнего вхождения во всем массиве <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения <paramref name="value" /> в пределах всего массива <paramref name="array" />, если элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		// Token: 0x06001410 RID: 5136 RVA: 0x0004F7B5 File Offset: 0x0004D9B5
		public static int LastIndexOf<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.LastIndexOf<T>(array, value, array.Length - 1, array.Length);
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает индекс последнего вхождения в диапазоне элементов массива <see cref="T:System.Array" />, начиная с первого элемента и заканчивая элементом с заданным индексом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, начиная с первого элемента и до позиции <paramref name="startIndex" />, если элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		// Token: 0x06001411 RID: 5137 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
		public static int LastIndexOf<T>(T[] array, T value, int startIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.LastIndexOf<T>(array, value, startIndex, (array.Length == 0) ? 0 : (startIndex + 1));
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает индекс последнего вхождения в диапазоне элементов массива <see cref="T:System.Array" />, содержащем указанное число элементов и заканчивающемся в позиции с указанным индексом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="value">Объект, который требуется найти в <paramref name="array" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения <paramref name="value" /> в диапазоне элементов массива <paramref name="array" />, состоящем из элементов, заданных в <paramref name="count" />, и заканчивающемся в позиции <paramref name="startIndex" />, если элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <paramref name="array" />.</exception>
		// Token: 0x06001412 RID: 5138 RVA: 0x0004F7F8 File Offset: 0x0004D9F8
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Length == 0)
			{
				if (startIndex != -1 && startIndex != 0)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count != 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				return -1;
			}
			else
			{
				if (startIndex < 0 || startIndex >= array.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || startIndex - count + 1 < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				return Array.LastIndexOfImpl<T>(array, value, startIndex, count);
			}
		}

		/// <summary>Изменяет порядок элементов во всем одномерном массиве <see cref="T:System.Array" /> на обратный.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, порядок элементов которого нужно изменить на обратный.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		// Token: 0x06001413 RID: 5139 RVA: 0x0004F882 File Offset: 0x0004DA82
		public static void Reverse(Array array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Reverse(array, array.GetLowerBound(0), array.Length);
		}

		/// <summary>Изменяет последовательность элементов в диапазоне элементов одномерного массива <see cref="T:System.Array" /> на обратную.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, порядок элементов которого нужно изменить на обратный.</param>
		/// <param name="index">Начальный индекс той части массива, порядок элементов которой необходимо изменить на обратный.</param>
		/// <param name="length">Число элементов в части массива, порядок которых нужно изменить на обратный.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.</exception>
		// Token: 0x06001414 RID: 5140 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		public static void Reverse(Array array, int index, int length)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int lowerBound = array.GetLowerBound(0);
			if (index < lowerBound || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < lowerBound) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - (index - lowerBound) < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			object[] array2 = array as object[];
			if (array2 != null)
			{
				Array.Reverse<object>(array2, index, length);
				return;
			}
			int i = index;
			int num = index + length - 1;
			while (i < num)
			{
				object value = array.GetValue(i);
				array.SetValue(array.GetValue(num), i);
				array.SetValue(value, num);
				i++;
				num--;
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0004F963 File Offset: 0x0004DB63
		public static void Reverse<T>(T[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Reverse<T>(array, 0, array.Length);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0004F980 File Offset: 0x0004DB80
		public static void Reverse<T>(T[] array, int index, int length)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length <= 1)
			{
				return;
			}
			ref T ptr = ref Unsafe.Add<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()), index);
			ref T ptr2 = ref Unsafe.Add<T>(Unsafe.Add<T>(ref ptr, length), -1);
			do
			{
				T t = ptr;
				ptr = ptr2;
				ptr2 = t;
				ptr = Unsafe.Add<T>(ref ptr, 1);
				ptr2 = Unsafe.Add<T>(ref ptr2, -1);
			}
			while (Unsafe.IsAddressLessThan<T>(ref ptr, ref ptr2));
		}

		/// <summary>Присваивает значение элементу, находящемуся в указанной позиции одномерного массива <see cref="T:System.Array" />. Индекс задается как 64-битовое целое число.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="index">64-разрядное целое число, представляющее позицию элемента в массиве <see cref="T:System.Array" />, для которого требуется установить значение.</param>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно одного измерения.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x06001417 RID: 5143 RVA: 0x0004FA29 File Offset: 0x0004DC29
		public void SetValue(object value, long index)
		{
			if (index > 2147483647L || index < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index", "Arrays larger than 2GB are not supported.");
			}
			this.SetValue(value, (int)index);
		}

		/// <summary>Задает значение для элемента, находящегося в указанной позиции двумерного массива <see cref="T:System.Array" />. Индексы задаются в виде 64-битовых целых чисел.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="index1">64-разрядное целое число, представляющее индекс задаваемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">64-разрядное целое число, представляющее индекс задаваемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно двух измерений.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index1" /> или <paramref name="index2" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x06001418 RID: 5144 RVA: 0x0004FA58 File Offset: 0x0004DC58
		public void SetValue(object value, long index1, long index2)
		{
			if (index1 > 2147483647L || index1 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index1", "Arrays larger than 2GB are not supported.");
			}
			if (index2 > 2147483647L || index2 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index2", "Arrays larger than 2GB are not supported.");
			}
			this.SetValue(value, (int)index1, (int)index2);
		}

		/// <summary>Присваивает значение элементу, находящемуся в указанной позиции трехмерного массива <see cref="T:System.Array" />. Индексы задаются в виде 64-битовых целых чисел.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="index1">64-разрядное целое число, представляющее индекс задаваемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">64-разрядное целое число, представляющее индекс задаваемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index3">64-разрядное целое число, представляющее индекс задаваемого элемента в третьем измерении массива <see cref="T:System.Array" />.</param>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно трех измерений.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index1" />, <paramref name="index2" /> или <paramref name="index3" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x06001419 RID: 5145 RVA: 0x0004FAB4 File Offset: 0x0004DCB4
		public void SetValue(object value, long index1, long index2, long index3)
		{
			if (index1 > 2147483647L || index1 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index1", "Arrays larger than 2GB are not supported.");
			}
			if (index2 > 2147483647L || index2 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index2", "Arrays larger than 2GB are not supported.");
			}
			if (index3 > 2147483647L || index3 < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("index3", "Arrays larger than 2GB are not supported.");
			}
			this.SetValue(value, (int)index1, (int)index2, (int)index3);
		}

		/// <summary>Присваивает значение элементу, находящемуся в указанной позиции многомерного массива <see cref="T:System.Array" />. Индексы задаются как массив 64-битовых целых чисел.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="indices">Одномерный массив 64-битовых целых чисел, представляющий индексы, которые задают позицию задаваемого элемента в массиве.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="indices" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число измерений в текущем массиве <see cref="T:System.Array" /> не равно числу элементов в <paramref name="indices" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Любой элемент в <paramref name="indices" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x0600141A RID: 5146 RVA: 0x0004FB38 File Offset: 0x0004DD38
		public void SetValue(object value, params long[] indices)
		{
			if (indices == null)
			{
				throw new ArgumentNullException("indices");
			}
			if (this.Rank != indices.Length)
			{
				throw new ArgumentException("Indices length does not match the array rank.");
			}
			int[] array = new int[indices.Length];
			for (int i = 0; i < indices.Length; i++)
			{
				long num = indices[i];
				if (num > 2147483647L || num < -2147483648L)
				{
					throw new ArgumentOutOfRangeException("index", "Arrays larger than 2GB are not supported.");
				}
				array[i] = (int)num;
			}
			this.SetValue(value, array);
		}

		/// <summary>Сортирует элементы во всем одномерном массиве <see cref="T:System.Array" />, используя реализацию интерфейса <see cref="T:System.IComparable" /> каждого элемента массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> для сортировки.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в <paramref name="array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x0600141B RID: 5147 RVA: 0x0004FBB3 File Offset: 0x0004DDB3
		public static void Sort(Array array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Sort(array, null, array.GetLowerBound(0), array.Length, null);
		}

		/// <summary>Сортирует элементы в диапазоне элементов одномерного массива <see cref="T:System.Array" /> с помощью реализации интерфейса <see cref="T:System.IComparable" /> каждого элемента массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> для сортировки.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в <paramref name="array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x0600141C RID: 5148 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		public static void Sort(Array array, int index, int length)
		{
			Array.Sort(array, null, index, length, null);
		}

		/// <summary>Сортирует элементы в одномерном массиве <see cref="T:System.Array" />, используя указанный интерфейс <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="array">Одномерный массив для сортировки.</param>
		/// <param name="comparer">Реализация интерфейса, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		/// <exception cref="T:System.ArgumentException">Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		// Token: 0x0600141D RID: 5149 RVA: 0x0004FBE4 File Offset: 0x0004DDE4
		public static void Sort(Array array, IComparer comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Sort(array, null, array.GetLowerBound(0), array.Length, comparer);
		}

		/// <summary>Сортирует элементы в диапазоне элементов одномерного массива <see cref="T:System.Array" />, используя указанный интерфейс <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> для сортировки.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.  
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x0600141E RID: 5150 RVA: 0x0004FC09 File Offset: 0x0004DE09
		public static void Sort(Array array, int index, int length, IComparer comparer)
		{
			Array.Sort(array, null, index, length, comparer);
		}

		/// <summary>Сортирует пару одномерных объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя реализацию интерфейса <see cref="T:System.IComparable" /> каждого ключа.</summary>
		/// <param name="keys">Одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Одномерный массив <see cref="T:System.Array" />, который содержит элементы, соответствующие ключам в массиве <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  Значение <see langword="null" /> для сортировки только массива <paramref name="keys" /><see cref="T:System.Array" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="keys" /><see cref="T:System.Array" /> является многомерным.  
		/// -или- 
		/// Массив <paramref name="items" /><see cref="T:System.Array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x0600141F RID: 5151 RVA: 0x0004FC15 File Offset: 0x0004DE15
		public static void Sort(Array keys, Array items)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			Array.Sort(keys, items, keys.GetLowerBound(0), keys.Length, null);
		}

		/// <summary>Сортирует пару одномерных объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя указанный интерфейс <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="keys">Одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Одномерный массив <see cref="T:System.Array" />, который содержит элементы, соответствующие ключам в массиве <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  Значение <see langword="null" /> для сортировки только массива <paramref name="keys" /><see cref="T:System.Array" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="keys" /><see cref="T:System.Array" /> является многомерным.  
		/// -или- 
		/// Массив <paramref name="items" /><see cref="T:System.Array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.  
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06001420 RID: 5152 RVA: 0x0004FC3A File Offset: 0x0004DE3A
		public static void Sort(Array keys, Array items, IComparer comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			Array.Sort(keys, items, keys.GetLowerBound(0), keys.Length, comparer);
		}

		/// <summary>Сортирует диапазон элементов в паре одномерных объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя реализацию интерфейса <see cref="T:System.IComparable" /> каждого ключа.</summary>
		/// <param name="keys">Одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Одномерный массив <see cref="T:System.Array" />, который содержит элементы, соответствующие ключам в массиве <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  Значение <see langword="null" /> для сортировки только массива <paramref name="keys" /><see cref="T:System.Array" />.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="keys" /><see cref="T:System.Array" /> является многомерным.  
		/// -или- 
		/// Массив <paramref name="items" /><see cref="T:System.Array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="keys" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.  
		/// -или- 
		///  <paramref name="index" /> и <paramref name="length" /> не определяют допустимый диапазон в <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="items" /><see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06001421 RID: 5153 RVA: 0x0004FC5F File Offset: 0x0004DE5F
		public static void Sort(Array keys, Array items, int index, int length)
		{
			Array.Sort(keys, items, index, length, null);
		}

		/// <summary>Сортирует диапазон элементов в паре одномерных объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя указанный интерфейс <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="keys">Одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Одномерный массив <see cref="T:System.Array" />, который содержит элементы, соответствующие ключам в массиве <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  Значение <see langword="null" /> для сортировки только массива <paramref name="keys" /><see cref="T:System.Array" />.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" /> для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">Массив <paramref name="keys" /><see cref="T:System.Array" /> является многомерным.  
		/// -или- 
		/// Массив <paramref name="items" /><see cref="T:System.Array" /> является многомерным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="keys" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а нижняя граница массива <paramref name="keys" /> не соответствует нижней границе массива <paramref name="items" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.  
		/// -или- 
		///  <paramref name="index" /> и <paramref name="length" /> не определяют допустимый диапазон в <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="items" /><see cref="T:System.Array" />   
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06001422 RID: 5154 RVA: 0x0004FC6C File Offset: 0x0004DE6C
		public static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			if (keys.Rank != 1 || (items != null && items.Rank != 1))
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			int lowerBound = keys.GetLowerBound(0);
			if (items != null && lowerBound != items.GetLowerBound(0))
			{
				throw new ArgumentException("The arrays' lower bounds must be identical.");
			}
			if (index < lowerBound || length < 0)
			{
				throw new ArgumentOutOfRangeException((length < 0) ? "length" : "index", "Non-negative number required.");
			}
			if (keys.Length - (index - lowerBound) < length || (items != null && index - lowerBound > items.Length - length))
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length > 1)
			{
				Array.SortImpl(keys, items, index, length, comparer);
			}
		}

		/// <summary>Сортирует элементы во всем массиве <see cref="T:System.Array" />, используя реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> каждого элемента массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Сортируемый одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в массиве <paramref name="array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001423 RID: 5155 RVA: 0x0004FD21 File Offset: 0x0004DF21
		public static void Sort<T>(T[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Sort<T>(array, 0, array.Length, null);
		}

		/// <summary>Сортирует элементы в диапазоне элементов массива <see cref="T:System.Array" />, используя реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> каждого элемента массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Сортируемый одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в массиве <paramref name="array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001424 RID: 5156 RVA: 0x0004FD3C File Offset: 0x0004DF3C
		public static void Sort<T>(T[] array, int index, int length)
		{
			Array.Sort<T>(array, index, length, null);
		}

		/// <summary>Сортирует элементы в массиве <see cref="T:System.Array" />, используя указанный универсальный интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="array">Сортируемый одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля.</param>
		/// <param name="comparer">Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, используемая при сравнении элементов, или значение <see langword="null" /> для использования реализации универсального интерфейса <see cref="T:System.IComparable`1" /> каждого элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в массиве <paramref name="array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		/// <exception cref="T:System.ArgumentException">Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		// Token: 0x06001425 RID: 5157 RVA: 0x0004FD47 File Offset: 0x0004DF47
		public static void Sort<T>(T[] array, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Sort<T>(array, 0, array.Length, comparer);
		}

		/// <summary>Сортирует элементы в диапазоне элементов массива <see cref="T:System.Array" />, используя указанный универсальный интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="array">Сортируемый одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <param name="comparer">Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, используемая при сравнении элементов, или значение <see langword="null" /> для использования реализации универсального интерфейса <see cref="T:System.IComparable`1" /> каждого элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="array" />.  
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в массиве <paramref name="array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001426 RID: 5158 RVA: 0x0004FD64 File Offset: 0x0004DF64
		public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((length < 0) ? "length" : "index", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length > 1)
			{
				ArraySortHelper<T>.Default.Sort(array, index, length, comparer);
			}
		}

		/// <summary>Сортирует элементы массива <see cref="T:System.Array" /> с использованием указанного объекта <see cref="T:System.Comparison`1" />.</summary>
		/// <param name="array">Сортируемый одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля.</param>
		/// <param name="comparison">
		///   <see cref="T:System.Comparison`1" />, используемый при сравнении элементов.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="comparison" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Реализация <paramref name="comparison" /> вызвала ошибку во время сортировки. Например, <paramref name="comparison" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		// Token: 0x06001427 RID: 5159 RVA: 0x0004FDC7 File Offset: 0x0004DFC7
		public static void Sort<T>(T[] array, Comparison<T> comparison)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (comparison == null)
			{
				throw new ArgumentNullException("comparison");
			}
			ArraySortHelper<T>.Sort(array, 0, array.Length, comparison);
		}

		/// <summary>Сортирует пару объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> каждого ключа.</summary>
		/// <param name="keys">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий элементы, соответствующие ключам в массиве <paramref name="keys" />, или значение <see langword="null" /> для сортировки только массива <paramref name="keys" />.</param>
		/// <typeparam name="TKey">Тип элементов массива ключей.</typeparam>
		/// <typeparam name="TValue">Тип элементов массива элементов.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а нижняя граница массива <paramref name="keys" /> не соответствует нижней границе массива <paramref name="items" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001428 RID: 5160 RVA: 0x0004FDF0 File Offset: 0x0004DFF0
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			Array.Sort<TKey, TValue>(keys, items, 0, keys.Length, null);
		}

		/// <summary>Сортирует диапазон элементов в паре объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> каждого ключа.</summary>
		/// <param name="keys">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий элементы, соответствующие ключам в массиве <paramref name="keys" />, или значение <see langword="null" /> для сортировки только массива <paramref name="keys" />.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <typeparam name="TKey">Тип элементов массива ключей.</typeparam>
		/// <typeparam name="TValue">Тип элементов массива элементов.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="keys" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а нижняя граница массива <paramref name="keys" /> не соответствует нижней границе массива <paramref name="items" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.  
		/// -или- 
		///  <paramref name="index" /> и <paramref name="length" /> не определяют допустимый диапазон в <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="items" /><see cref="T:System.Array" /></exception>
		/// <exception cref="T:System.InvalidOperationException">Один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x06001429 RID: 5161 RVA: 0x0004FE0C File Offset: 0x0004E00C
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
		{
			Array.Sort<TKey, TValue>(keys, items, index, length, null);
		}

		/// <summary>Сортирует пару объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя указанный универсальный интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="keys">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий элементы, соответствующие ключам в массиве <paramref name="keys" />, или значение <see langword="null" /> для сортировки только массива <paramref name="keys" />.</param>
		/// <param name="comparer">Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, используемая при сравнении элементов, или значение <see langword="null" /> для использования реализации универсального интерфейса <see cref="T:System.IComparable`1" /> каждого элемента.</param>
		/// <typeparam name="TKey">Тип элементов массива ключей.</typeparam>
		/// <typeparam name="TValue">Тип элементов массива элементов.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а нижняя граница массива <paramref name="keys" /> не соответствует нижней границе массива <paramref name="items" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.  
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x0600142A RID: 5162 RVA: 0x0004FE18 File Offset: 0x0004E018
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			Array.Sort<TKey, TValue>(keys, items, 0, keys.Length, comparer);
		}

		/// <summary>Сортирует диапазон элементов в паре объектов <see cref="T:System.Array" /> (один содержит ключи, а другой — соответствующие элементы) по ключам в первом массиве <see cref="T:System.Array" />, используя указанный универсальный интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="keys">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий ключи для сортировки.</param>
		/// <param name="items">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, содержащий элементы, соответствующие ключам в массиве <paramref name="keys" />, или значение <see langword="null" /> для сортировки только массива <paramref name="keys" />.</param>
		/// <param name="index">Начальный индекс диапазона сортировки.</param>
		/// <param name="length">Число элементов в диапазоне сортировки.</param>
		/// <param name="comparer">Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, используемая при сравнении элементов, или значение <see langword="null" /> для использования реализации универсального интерфейса <see cref="T:System.IComparable`1" /> каждого элемента.</param>
		/// <typeparam name="TKey">Тип элементов массива ключей.</typeparam>
		/// <typeparam name="TValue">Тип элементов массива элементов.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keys" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="keys" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="items" /> не равно <see langword="null" />, а нижняя граница массива <paramref name="keys" /> не соответствует нижней границе массива <paramref name="items" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а длина <paramref name="keys" /> больше длины <paramref name="items" />.  
		/// -или- 
		///  <paramref name="index" /> и <paramref name="length" /> не определяют допустимый диапазон в <paramref name="keys" /><see cref="T:System.Array" />.  
		/// -или- 
		///  <paramref name="items" /> не равно <see langword="null" />, а <paramref name="index" /> и <paramref name="length" /> не указывают допустимый диапазон в <paramref name="items" /><see cref="T:System.Array" />   
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="keys" /><see cref="T:System.Array" /> не реализуют универсальный интерфейс <see cref="T:System.IComparable`1" />.</exception>
		// Token: 0x0600142B RID: 5163 RVA: 0x0004FE34 File Offset: 0x0004E034
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((length < 0) ? "length" : "index", "Non-negative number required.");
			}
			if (keys.Length - index < length || (items != null && index > items.Length - length))
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length > 1)
			{
				if (items == null)
				{
					Array.Sort<TKey>(keys, index, length, comparer);
					return;
				}
				ArraySortHelper<TKey, TValue>.Default.Sort(keys, items, index, length, comparer);
			}
		}

		/// <summary>Определяет, содержит ли заданный массив элементы, удовлетворяющие условиям указанного предиката.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элементов.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Значение <see langword="true" />, если массив <paramref name="array" /> содержит один или несколько элементов, удовлетворяющих условиям указанного предиката; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x0600142C RID: 5164 RVA: 0x0004FEB2 File Offset: 0x0004E0B2
		public static bool Exists<T>(T[] array, Predicate<T> match)
		{
			return Array.FindIndex<T>(array, match) != -1;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0004FEC4 File Offset: 0x0004E0C4
		public static void Fill<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = value;
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		public static void Fill<T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (startIndex < 0 || startIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex > array.Length - count)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			for (int i = startIndex; i < startIndex + count; i++)
			{
				array[i] = value;
			}
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает первое найденное вхождение в пределах всего списка <see cref="T:System.Array" />.</summary>
		/// <param name="array">Индексируемый от нуля одномерный массив, в котором выполняется поиск.</param>
		/// <param name="match">Предикат, определяющий условия элемента, который требуется найти.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Первый элемент, удовлетворяющий условиям указанного предиката, если такой элемент найден; в противном случае — значение по умолчанию для типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x0600142F RID: 5167 RVA: 0x0004FF60 File Offset: 0x0004E160
		public static T Find<T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (match(array[i]))
				{
					return array[i];
				}
			}
			return default(T);
		}

		/// <summary>Извлекает все элементы, удовлетворяющие условиям указанного предиката.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элементов.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Список <see cref="T:System.Array" />, содержащий все элементы, удовлетворяющие условиям указанного предиката, если такие элементы найдены; в противном случае — пустой список <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06001430 RID: 5168 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		public static T[] FindAll<T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			int num = 0;
			T[] array2 = Array.Empty<T>();
			for (int i = 0; i < array.Length; i++)
			{
				if (match(array[i]))
				{
					if (num == array2.Length)
					{
						Array.Resize<T>(ref array2, Math.Min((num == 0) ? 4 : (num * 2), array.Length));
					}
					array2[num++] = array[i];
				}
			}
			if (num != array2.Length)
			{
				Array.Resize<T>(ref array2, num);
			}
			return array2;
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс первого найденного вхождения в пределах всего списка <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента, отвечающего условиям предиката <paramref name="match" />, если такой элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06001431 RID: 5169 RVA: 0x00050045 File Offset: 0x0004E245
		public static int FindIndex<T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.FindIndex<T>(array, 0, array.Length, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Array" />, начиная с заданного индекса и заканчивая последним элементом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента, отвечающего условиям предиката <paramref name="match" />, если такой элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		// Token: 0x06001432 RID: 5170 RVA: 0x00050060 File Offset: 0x0004E260
		public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.FindIndex<T>(array, startIndex, array.Length - startIndex, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Array" />, начинающемся с заданного индекса и содержащем указанное число элементов.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента, отвечающего условиям предиката <paramref name="match" />, если такой элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <paramref name="array" />.</exception>
		// Token: 0x06001433 RID: 5171 RVA: 0x00050080 File Offset: 0x0004E280
		public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (startIndex < 0 || startIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex > array.Length - count)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (match(array[i]))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает последнее найденное вхождение в пределах всего списка <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Последний элемент, удовлетворяющий условиям указанного предиката, если такой элемент найден; в противном случае — значение по умолчанию для типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06001434 RID: 5172 RVA: 0x00050104 File Offset: 0x0004E304
		public static T FindLast<T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (match(array[i]))
				{
					return array[i];
				}
			}
			return default(T);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс последнего найденного вхождения в пределах всего списка <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента, удовлетворяющего условиям предиката <paramref name="match" />, если такой элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06001435 RID: 5173 RVA: 0x0005015D File Offset: 0x0004E35D
		public static int FindLastIndex<T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.FindLastIndex<T>(array, array.Length - 1, array.Length, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Array" />, начиная с первого элемента и заканчивая элементом с заданным индексом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента, удовлетворяющего условиям предиката <paramref name="match" />, если такой элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.</exception>
		// Token: 0x06001436 RID: 5174 RVA: 0x0005017C File Offset: 0x0004E37C
		public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.FindLastIndex<T>(array, startIndex, startIndex + 1, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Array" />, содержащем указанное число элементов и заканчивающемся элементом с заданным индексом.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, индексация которого начинается с нуля и в котором нужно выполнить поиск.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="match">Объект <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента, удовлетворяющего условиям предиката <paramref name="match" />, если такой элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <paramref name="array" />.</exception>
		// Token: 0x06001437 RID: 5175 RVA: 0x00050198 File Offset: 0x0004E398
		public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			if (array.Length == 0)
			{
				if (startIndex != -1)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
			}
			else if (startIndex < 0 || startIndex >= array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex - count + 1 < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			int num = startIndex - count;
			for (int i = startIndex; i > num; i--)
			{
				if (match(array[i]))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Определяет, все ли элементы массива удовлетворяют условиям указанного предиката.</summary>
		/// <param name="array">Индексируемый от нуля одномерный массив <see cref="T:System.Array" />, который необходимо проверить на соответствие условиям.</param>
		/// <param name="match">Предикат, определяющий условия, на соответствие которым проверяются элементы.</param>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Значение <see langword="true" />, если каждый элемент массива <paramref name="array" /> удовлетворяет условиям заданного предиката; в противном случае — значение <see langword="false" />. Если элементы в массиве отсутствуют, возвращается значение <see langword="true" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06001438 RID: 5176 RVA: 0x00050234 File Offset: 0x0004E434
		public static bool TrueForAll<T>(T[] array, Predicate<T> match)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (!match(array[i]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" /> для словаря <see cref="T:System.Array" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Array" />.</returns>
		// Token: 0x06001439 RID: 5177 RVA: 0x0005027D File Offset: 0x0004E47D
		public IEnumerator GetEnumerator()
		{
			return new Array.ArrayEnumerator(this);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0000259F File Offset: 0x0000079F
		private Array()
		{
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0004ED6D File Offset: 0x0004CF6D
		internal int InternalArray__ICollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000040F7 File Offset: 0x000022F7
		internal bool InternalArray__ICollection_get_IsReadOnly()
		{
			return true;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00050285 File Offset: 0x0004E485
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ref byte GetRawSzArrayData()
		{
			return ref Unsafe.As<Array.RawData>(this).Data;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00050292 File Offset: 0x0004E492
		internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			if (this.Length == 0)
			{
				return Array.EmptyInternalEnumerator<T>.Value;
			}
			return new Array.InternalEnumerator<T>(this);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000502AD File Offset: 0x0004E4AD
		internal void InternalArray__ICollection_Clear()
		{
			throw new NotSupportedException("Collection is read-only");
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000502B9 File Offset: 0x0004E4B9
		internal void InternalArray__ICollection_Add<T>(T item)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000502B9 File Offset: 0x0004E4B9
		internal bool InternalArray__ICollection_Remove<T>(T item)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000502C8 File Offset: 0x0004E4C8
		internal bool InternalArray__ICollection_Contains<T>(T item)
		{
			if (this.Rank > 1)
			{
				throw new RankException("Only single dimension arrays are supported.");
			}
			int length = this.Length;
			for (int i = 0; i < length; i++)
			{
				T t;
				this.GetGenericValueImpl<T>(i, out t);
				if (item == null)
				{
					if (t == null)
					{
						return true;
					}
				}
				else if (item.Equals(t))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0005032F File Offset: 0x0004E52F
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
		{
			Array.Copy(this, this.GetLowerBound(0), array, arrayIndex, this.Length);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00050348 File Offset: 0x0004E548
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			if (index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			T result;
			this.GetGenericValueImpl<T>(index, out result);
			return result;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0004ED6D File Offset: 0x0004CF6D
		internal int InternalArray__IReadOnlyCollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000502B9 File Offset: 0x0004E4B9
		internal void InternalArray__Insert<T>(int index, T item)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000502B9 File Offset: 0x0004E4B9
		internal void InternalArray__RemoveAt(int index)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00050374 File Offset: 0x0004E574
		internal int InternalArray__IndexOf<T>(T item)
		{
			if (this.Rank > 1)
			{
				throw new RankException("Only single dimension arrays are supported.");
			}
			int length = this.Length;
			for (int i = 0; i < length; i++)
			{
				T t;
				this.GetGenericValueImpl<T>(i, out t);
				if (item == null)
				{
					if (t == null)
					{
						return i + this.GetLowerBound(0);
					}
				}
				else if (t.Equals(item))
				{
					return i + this.GetLowerBound(0);
				}
			}
			return this.GetLowerBound(0) - 1;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000503F4 File Offset: 0x0004E5F4
		internal T InternalArray__get_Item<T>(int index)
		{
			if (index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			T result;
			this.GetGenericValueImpl<T>(index, out result);
			return result;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00050420 File Offset: 0x0004E620
		internal void InternalArray__set_Item<T>(int index, T item)
		{
			if (index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			object[] array = this as object[];
			if (array != null)
			{
				array[index] = item;
				return;
			}
			this.SetGenericValueImpl<T>(index, ref item);
		}

		// Token: 0x0600144B RID: 5195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGenericValue_icall<T>(ref Array self, int pos, out T value);

		// Token: 0x0600144C RID: 5196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGenericValue_icall<T>(ref Array self, int pos, ref T value);

		// Token: 0x0600144D RID: 5197 RVA: 0x00050460 File Offset: 0x0004E660
		internal void GetGenericValueImpl<T>(int pos, out T value)
		{
			Array array = this;
			Array.GetGenericValue_icall<T>(ref array, pos, out value);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00050478 File Offset: 0x0004E678
		internal void SetGenericValueImpl<T>(int pos, ref T value)
		{
			Array array = this;
			Array.SetGenericValue_icall<T>(ref array, pos, ref value);
		}

		/// <summary>Возвращает общее число элементов во всех измерениях массива <see cref="T:System.Array" />.</summary>
		/// <returns>Общее число элементов во всех измерениях массива <see cref="T:System.Array" />; ноль, если в массиве нет элементов.</returns>
		/// <exception cref="T:System.OverflowException">Массив является многомерным и содержит больше элементов, чем задано в <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00050490 File Offset: 0x0004E690
		public int Length
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				int num = this.GetLength(0);
				for (int i = 1; i < this.Rank; i++)
				{
					num *= this.GetLength(i);
				}
				return num;
			}
		}

		/// <summary>Получает ранг (число измерений) массива <see cref="T:System.Array" />. Например, одномерный массив возвращает 1, двухмерный массив возвращает 2 и т д</summary>
		/// <returns>Ранг (число измерений) массива <see cref="T:System.Array" />.</returns>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x000504C1 File Offset: 0x0004E6C1
		public int Rank
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.GetRank();
			}
		}

		// Token: 0x06001451 RID: 5201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetRank();

		/// <summary>Возвращает 32-разрядное целое число, представляющее количество элементов в заданном измерении массива <see cref="T:System.Array" />.</summary>
		/// <param name="dimension">Измерение массива <see cref="T:System.Array" />, индексация которого начинается с нуля, для которого требуется определить длину.</param>
		/// <returns>32-битовое целое число, представляющее количество элементов в заданном измерении.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="dimension" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="dimension" /> больше или равно значению свойства <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x06001452 RID: 5202
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetLength(int dimension);

		/// <summary>Получает Индекс первого элемента заданного измерения в массиве.</summary>
		/// <param name="dimension">Измерение массива основанное на нуле, для которого необходимо определить индекс начала.</param>
		/// <returns>Индекс первого элемента заданного измерения в массиве.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="dimension" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="dimension" /> больше или равно значению свойства <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x06001453 RID: 5203
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetLowerBound(int dimension);

		/// <summary>Получает значение, находящееся в указанной позиции многомерного массива <see cref="T:System.Array" />. Индексы задаются как массив 32-битовых целых чисел.</summary>
		/// <param name="indices">Одномерный массив 32-битовых целых чисел, представляющий индексы, которые задают позицию получаемого элемента <see cref="T:System.Array" />.</param>
		/// <returns>Значение, находящееся в указанной позиции многомерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="indices" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число измерений в текущем массиве <see cref="T:System.Array" /> не равно числу элементов в <paramref name="indices" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Любой элемент в <paramref name="indices" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x06001454 RID: 5204
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern object GetValue(params int[] indices);

		/// <summary>Присваивает значение элементу, находящемуся в указанной позиции многомерного массива <see cref="T:System.Array" />. Индексы задаются как массив 32-битовых целых чисел.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="indices">Одномерный массив 32-битовых целых чисел, представляющий индексы, которые задают позицию задаваемого элемента в массиве.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="indices" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число измерений в текущем массиве <see cref="T:System.Array" /> не равно числу элементов в <paramref name="indices" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Любой элемент в <paramref name="indices" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x06001455 RID: 5205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetValue(object value, params int[] indices);

		// Token: 0x06001456 RID: 5206
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern object GetValueImpl(int pos);

		// Token: 0x06001457 RID: 5207
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetValueImpl(object value, int pos);

		// Token: 0x06001458 RID: 5208
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length);

		// Token: 0x06001459 RID: 5209
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds);

		/// <summary>Получает Индекс последнего элемента заданного измерения в массиве.</summary>
		/// <param name="dimension">Измерение массива, индексация которого начинается с нуля, и для которого необходимо определить верхнюю границу.</param>
		/// <returns>Индекс последнего элемента указанного измерения в массиве или -1, если указанное измерение пусто.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="dimension" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="dimension" /> больше или равно значению свойства <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x0600145A RID: 5210 RVA: 0x000504C9 File Offset: 0x0004E6C9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int GetUpperBound(int dimension)
		{
			return this.GetLowerBound(dimension) + this.GetLength(dimension) - 1;
		}

		/// <summary>Возвращает значение, хранящееся в указанной позиции одномерного массива <see cref="T:System.Array" />. Индекс задается как 32-битовое целое число.</summary>
		/// <param name="index">32-разрядное целое, представляющее позицию получаемого элемента <see cref="T:System.Array" />.</param>
		/// <returns>Значение, хранящееся в указанной позиции одномерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно одного измерения.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x0600145B RID: 5211 RVA: 0x000504DC File Offset: 0x0004E6DC
		public object GetValue(int index)
		{
			if (this.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			int lowerBound = this.GetLowerBound(0);
			if (index < lowerBound || index > this.GetUpperBound(0))
			{
				throw new IndexOutOfRangeException("Index has to be between upper and lower bound of the array.");
			}
			if (base.GetType().GetElementType().IsPointer)
			{
				throw new NotSupportedException("Type is not supported.");
			}
			return this.GetValueImpl(index - lowerBound);
		}

		/// <summary>Получает значение в заданной позиции двумерного массива <see cref="T:System.Array" />. Индексы задаются в виде 32-битовых целых чисел.</summary>
		/// <param name="index1">32-разрядное целое число, представляющее индекс получаемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">32-разрядное целое число, представляющее индекс получаемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <returns>Значение, находящееся в указанной позиции двумерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно двух измерений.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index1" /> или <paramref name="index2" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x0600145C RID: 5212 RVA: 0x00050544 File Offset: 0x0004E744
		public object GetValue(int index1, int index2)
		{
			int[] indices = new int[]
			{
				index1,
				index2
			};
			return this.GetValue(indices);
		}

		/// <summary>Получает значение, хранящееся в указанной позиции трехмерного массива <see cref="T:System.Array" />. Индексы задаются в виде 32-битовых целых чисел.</summary>
		/// <param name="index1">32-разрядное целое число, представляющее индекс получаемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">32-разрядное целое число, представляющее индекс получаемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index3">32-разрядное целое число, представляющее индекс получаемого элемента в третьем измерении массива <see cref="T:System.Array" />.</param>
		/// <returns>Значение, хранящееся в указанной позиции трехмерного массива <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно трех измерений.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index1" />, <paramref name="index2" /> или <paramref name="index3" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x0600145D RID: 5213 RVA: 0x00050568 File Offset: 0x0004E768
		public object GetValue(int index1, int index2, int index3)
		{
			int[] indices = new int[]
			{
				index1,
				index2,
				index3
			};
			return this.GetValue(indices);
		}

		/// <summary>Присваивает значение элементу, находящемуся в указанной позиции одномерного массива <see cref="T:System.Array" />. Индекс задается как 32-битовое целое число.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="index">32-разрядное целое число, представляющее позицию элемента в массиве <see cref="T:System.Array" />, для которого требуется установить значение.</param>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно одного измерения.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x0600145E RID: 5214 RVA: 0x00050590 File Offset: 0x0004E790
		public void SetValue(object value, int index)
		{
			if (this.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			int lowerBound = this.GetLowerBound(0);
			if (index < lowerBound || index > this.GetUpperBound(0))
			{
				throw new IndexOutOfRangeException("Index has to be >= lower bound and <= upper bound of the array.");
			}
			if (base.GetType().GetElementType().IsPointer)
			{
				throw new NotSupportedException("Type is not supported.");
			}
			this.SetValueImpl(value, index - lowerBound);
		}

		/// <summary>Задает значение для элемента, находящегося в указанной позиции двумерного массива <see cref="T:System.Array" />. Индексы задаются в виде 32-битовых целых чисел.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="index1">32-разрядное целое число, представляющее индекс задаваемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">32-разрядное целое число, представляющее индекс задаваемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно двух измерений.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index1" /> или <paramref name="index2" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x0600145F RID: 5215 RVA: 0x000505FC File Offset: 0x0004E7FC
		public void SetValue(object value, int index1, int index2)
		{
			int[] indices = new int[]
			{
				index1,
				index2
			};
			this.SetValue(value, indices);
		}

		/// <summary>Присваивает значение элементу, находящемуся в указанной позиции трехмерного массива <see cref="T:System.Array" />. Индексы задаются в виде 32-битовых целых чисел.</summary>
		/// <param name="value">Новое значение указанного элемента.</param>
		/// <param name="index1">32-разрядное целое число, представляющее индекс задаваемого элемента в первом измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index2">32-разрядное целое число, представляющее индекс задаваемого элемента во втором измерении массива <see cref="T:System.Array" />.</param>
		/// <param name="index3">32-разрядное целое число, представляющее индекс задаваемого элемента в третьем измерении массива <see cref="T:System.Array" />.</param>
		/// <exception cref="T:System.ArgumentException">Текущий массив <see cref="T:System.Array" /> не имеет ровно трех измерений.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="value" /> не может быть приведен к типу элемента текущего массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index1" />, <paramref name="index2" /> или <paramref name="index3" /> находится вне диапазона допустимых индексов для соответствующего измерения текущего массива <see cref="T:System.Array" />.</exception>
		// Token: 0x06001460 RID: 5216 RVA: 0x00050620 File Offset: 0x0004E820
		public void SetValue(object value, int index1, int index2, int index3)
		{
			int[] indices = new int[]
			{
				index1,
				index2,
				index3
			};
			this.SetValue(value, indices);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00050649 File Offset: 0x0004E849
		internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			return Array.CreateInstance(elementType, lengths, lowerBounds);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00050653 File Offset: 0x0004E853
		internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2)
		{
			return Array.CreateInstance(elementType, length1, length2);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0005065D File Offset: 0x0004E85D
		internal static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
		{
			return Array.CreateInstance(elementType, lengths);
		}

		/// <summary>Создает одномерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> и длины, индексация которого начинается с нуля.</summary>
		/// <param name="elementType">Тип <see cref="T:System.Type" /> массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="length">Размер массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <returns>Новый одномерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> и длины, индексация которого начинается с нуля.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="elementType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementType" /> не является допустимым <see cref="T:System.Type" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="elementType" /> не поддерживается. Например, <see cref="T:System.Void" /> не поддерживается.  
		/// -или- 
		///  <paramref name="elementType" /> представляет собой открытый универсальный тип.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.</exception>
		// Token: 0x06001464 RID: 5220 RVA: 0x00050668 File Offset: 0x0004E868
		public static Array CreateInstance(Type elementType, int length)
		{
			int[] lengths = new int[]
			{
				length
			};
			return Array.CreateInstance(elementType, lengths);
		}

		/// <summary>Создает двумерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> с заданными длинами измерений и индексацией, начинающейся с нуля.</summary>
		/// <param name="elementType">Тип <see cref="T:System.Type" /> массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="length1">Размер первого измерения создаваемого массива <see cref="T:System.Array" />.</param>
		/// <param name="length2">Размер второго измерения создаваемого массива <see cref="T:System.Array" />.</param>
		/// <returns>Новый двумерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> с заданной для каждого измерения длиной и индексацией, начинающейся с нуля.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="elementType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementType" /> не является допустимым <see cref="T:System.Type" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="elementType" /> не поддерживается. Например, <see cref="T:System.Void" /> не поддерживается.  
		/// -или- 
		///  <paramref name="elementType" /> представляет собой открытый универсальный тип.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length1" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="length2" /> меньше нуля.</exception>
		// Token: 0x06001465 RID: 5221 RVA: 0x00050688 File Offset: 0x0004E888
		public static Array CreateInstance(Type elementType, int length1, int length2)
		{
			int[] lengths = new int[]
			{
				length1,
				length2
			};
			return Array.CreateInstance(elementType, lengths);
		}

		/// <summary>Создает трехмерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> с заданными длинами по измерениям и индексацией, начинающейся с нуля.</summary>
		/// <param name="elementType">Тип <see cref="T:System.Type" /> массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="length1">Размер первого измерения создаваемого массива <see cref="T:System.Array" />.</param>
		/// <param name="length2">Размер второго измерения массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="length3">Размер третьего измерения массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <returns>Новый трехмерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> с заданной для каждого измерения длиной и индексацией, начинающейся с нуля.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="elementType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementType" /> не является допустимым <see cref="T:System.Type" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="elementType" /> не поддерживается. Например, <see cref="T:System.Void" /> не поддерживается.  
		/// -или- 
		///  <paramref name="elementType" /> представляет собой открытый универсальный тип.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length1" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="length2" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="length3" /> меньше нуля.</exception>
		// Token: 0x06001466 RID: 5222 RVA: 0x000506AC File Offset: 0x0004E8AC
		public static Array CreateInstance(Type elementType, int length1, int length2, int length3)
		{
			int[] lengths = new int[]
			{
				length1,
				length2,
				length3
			};
			return Array.CreateInstance(elementType, lengths);
		}

		/// <summary>Создает многомерный массив <see cref="T:System.Array" /> заданного типа <see cref="T:System.Type" /> с заданными длинами по измерениям и индексацией, начинающейся с нуля. Длины по измерениям задаются в массиве 32-битовых целых чисел.</summary>
		/// <param name="elementType">Тип <see cref="T:System.Type" /> массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="lengths">Массив 32-разрядных целых чисел, представляющих размер каждого измерения массива <see cref="T:System.Array" />, который нужно создать.</param>
		/// <returns>Новый многомерный массив <see cref="T:System.Array" /> заданного типа <see cref="T:System.Type" /> с заданной для каждого измерения длиной и индексацией, начинающейся с нуля.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="elementType" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="lengths" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementType" /> не является допустимым <see cref="T:System.Type" />.  
		/// -или- 
		/// Массив <paramref name="lengths" /> содержит менее одного элемента.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="elementType" /> не поддерживается. Например, <see cref="T:System.Void" /> не поддерживается.  
		/// -или- 
		///  <paramref name="elementType" /> представляет собой открытый универсальный тип.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Любое значение в <paramref name="lengths" /> меньше нуля.</exception>
		// Token: 0x06001467 RID: 5223 RVA: 0x000506D4 File Offset: 0x0004E8D4
		public static Array CreateInstance(Type elementType, params int[] lengths)
		{
			if (elementType == null)
			{
				throw new ArgumentNullException("elementType");
			}
			if (lengths == null)
			{
				throw new ArgumentNullException("lengths");
			}
			if (lengths.Length > 255)
			{
				throw new TypeLoadException();
			}
			int[] bounds = null;
			elementType = (elementType.UnderlyingSystemType as RuntimeType);
			if (elementType == null)
			{
				throw new ArgumentException("Type must be a type provided by the runtime.", "elementType");
			}
			if (elementType.Equals(typeof(void)))
			{
				throw new NotSupportedException("Array type can not be void");
			}
			if (elementType.ContainsGenericParameters)
			{
				throw new NotSupportedException("Array type can not be an open generic type");
			}
			return Array.CreateInstanceImpl(elementType, lengths, bounds);
		}

		/// <summary>Создает многомерный массив <see cref="T:System.Array" /> с указанным типом <see cref="T:System.Type" /> и длиной по измерениям и с заданными нижними границами.</summary>
		/// <param name="elementType">Тип <see cref="T:System.Type" /> массива <see cref="T:System.Array" />, который требуется создать.</param>
		/// <param name="lengths">Одномерный массив, содержащий размер всех измерений массива <see cref="T:System.Array" />, который необходимо создать.</param>
		/// <param name="lowerBounds">Одномерный массив, содержащий нижние границы (начальные индексы) всех измерений массива <see cref="T:System.Array" />, который необходимо создать.</param>
		/// <returns>Новый многомерный массив <see cref="T:System.Array" /> указанного типа <see cref="T:System.Type" /> с заданной длиной и нижней границей каждого измерения.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="elementType" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="lengths" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="lowerBounds" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementType" /> не является допустимым <see cref="T:System.Type" />.  
		/// -или- 
		/// Массив <paramref name="lengths" /> содержит менее одного элемента.  
		/// -или- 
		/// Массивы <paramref name="lengths" /> и <paramref name="lowerBounds" /> содержат разное число элементов.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="elementType" /> не поддерживается. Например, <see cref="T:System.Void" /> не поддерживается.  
		/// -или- 
		///  <paramref name="elementType" /> представляет собой открытый универсальный тип.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Любое значение в <paramref name="lengths" /> меньше нуля.  
		/// -или- 
		/// Какое-либо значение в <paramref name="lowerBounds" /> очень велико, вследствие чего сумма нижней границы измерения и длины превышает значение <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001468 RID: 5224 RVA: 0x00050774 File Offset: 0x0004E974
		public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			if (elementType == null)
			{
				throw new ArgumentNullException("elementType");
			}
			if (lengths == null)
			{
				throw new ArgumentNullException("lengths");
			}
			if (lowerBounds == null)
			{
				throw new ArgumentNullException("lowerBounds");
			}
			elementType = (elementType.UnderlyingSystemType as RuntimeType);
			if (elementType == null)
			{
				throw new ArgumentException("Type must be a type provided by the runtime.", "elementType");
			}
			if (elementType.Equals(typeof(void)))
			{
				throw new NotSupportedException("Array type can not be void");
			}
			if (elementType.ContainsGenericParameters)
			{
				throw new NotSupportedException("Array type can not be an open generic type");
			}
			if (lengths.Length < 1)
			{
				throw new ArgumentException("Arrays must contain >= 1 elements.");
			}
			if (lengths.Length != lowerBounds.Length)
			{
				throw new ArgumentException("Arrays must be of same size.");
			}
			for (int i = 0; i < lowerBounds.Length; i++)
			{
				if (lengths[i] < 0)
				{
					throw new ArgumentOutOfRangeException("lengths", "Each value has to be >= 0.");
				}
				if ((long)lowerBounds[i] + (long)lengths[i] > 2147483647L)
				{
					throw new ArgumentOutOfRangeException("lengths", "Length + bound must not exceed Int32.MaxValue.");
				}
			}
			if (lengths.Length > 255)
			{
				throw new TypeLoadException();
			}
			return Array.CreateInstanceImpl(elementType, lengths, lowerBounds);
		}

		/// <summary>Задает для диапазона элементов в массиве значение, предусмотренное по умолчанию для каждого типа элементов.</summary>
		/// <param name="array">Массив, элементы которого необходимо очистить.</param>
		/// <param name="index">Начальный индекс диапазона элементов, которые необходимо очистить.</param>
		/// <param name="length">Число элементов, подлежащих очистке.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.  
		/// -или- 
		/// Сумма <paramref name="index" /> и <paramref name="length" /> больше, чем размер <paramref name="array" />.</exception>
		// Token: 0x06001469 RID: 5225 RVA: 0x00050888 File Offset: 0x0004EA88
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void Clear(Array array, int index, int length)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (length < 0)
			{
				throw new IndexOutOfRangeException("length < 0");
			}
			int lowerBound = array.GetLowerBound(0);
			if (index < lowerBound)
			{
				throw new IndexOutOfRangeException("index < lower bound");
			}
			index -= lowerBound;
			if (index > array.Length - length)
			{
				throw new IndexOutOfRangeException("index + length > size");
			}
			Array.ClearInternal(array, index, length);
		}

		// Token: 0x0600146A RID: 5226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ClearInternal(Array a, int index, int count);

		/// <summary>Копирует диапазон элементов из массива <see cref="T:System.Array" />, начиная с первого элемента, и вставляет его в другой массив <see cref="T:System.Array" />, также начиная с первого элемента. Длина задается как 32-битовое целое число.</summary>
		/// <param name="sourceArray">Массив <see cref="T:System.Array" />, содержащий данные, которые требуется скопировать.</param>
		/// <param name="destinationArray">Массив <see cref="T:System.Array" />, принимающий данные.</param>
		/// <param name="length">32-битовое целое число, представляющее число копируемых элементов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceArray" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="destinationArray" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют различные ранги.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют несовместимые типы.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в <paramref name="sourceArray" /> не может быть приведен к типу <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="length" /> больше числа элементов в <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="length" /> больше числа элементов в <paramref name="destinationArray" />.</exception>
		// Token: 0x0600146B RID: 5227 RVA: 0x000508EC File Offset: 0x0004EAEC
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, Array destinationArray, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			Array.Copy(sourceArray, sourceArray.GetLowerBound(0), destinationArray, destinationArray.GetLowerBound(0), length);
		}

		/// <summary>Копирует диапазон элементов из массива <see cref="T:System.Array" />, начиная с заданного индекса источника, и вставляет его в другой массив <see cref="T:System.Array" />, начиная с заданного индекса назначения. Длина и индексы задаются как 32-битовые целые числа.</summary>
		/// <param name="sourceArray">Массив <see cref="T:System.Array" />, содержащий данные, которые требуется скопировать.</param>
		/// <param name="sourceIndex">32-разрядное целое число, представляющее индекс в массиве <paramref name="sourceArray" />, с которого начинается копирование.</param>
		/// <param name="destinationArray">Массив <see cref="T:System.Array" />, принимающий данные.</param>
		/// <param name="destinationIndex">32-разрядное целое число, представляющее индекс в массиве <paramref name="destinationArray" />, с которого начинается сохранение.</param>
		/// <param name="length">32-битовое целое число, представляющее число копируемых элементов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceArray" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="destinationArray" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют различные ранги.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют несовместимые типы.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в <paramref name="sourceArray" /> не может быть приведен к типу <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="sourceIndex" /> меньше, чем нижняя граница первого измерения массива <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="destinationIndex" /> меньше, чем нижняя граница первого измерения массива <paramref name="destinationArray" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="length" /> больше числа элементов с <paramref name="sourceIndex" /> до конца <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="length" /> больше числа элементов с <paramref name="destinationIndex" /> до конца <paramref name="destinationArray" />.</exception>
		// Token: 0x0600146C RID: 5228 RVA: 0x00050920 File Offset: 0x0004EB20
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Value has to be >= 0.");
			}
			if (sourceArray.Rank != destinationArray.Rank)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			if (sourceIndex < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Value has to be >= 0.");
			}
			if (destinationIndex < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Value has to be >= 0.");
			}
			if (Array.FastCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length))
			{
				return;
			}
			int num = sourceIndex - sourceArray.GetLowerBound(0);
			int num2 = destinationIndex - destinationArray.GetLowerBound(0);
			if (num2 < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Index was less than the array's lower bound in the first dimension.");
			}
			if (num > sourceArray.Length - length)
			{
				throw new ArgumentException("length");
			}
			if (num2 > destinationArray.Length - length)
			{
				throw new ArgumentException("Destination array was not long enough. Check destIndex and length, and the array's lower bounds", "destinationArray");
			}
			Type elementType = sourceArray.GetType().GetElementType();
			Type elementType2 = destinationArray.GetType().GetElementType();
			bool isValueType = elementType2.IsValueType;
			if (sourceArray != destinationArray || num > num2)
			{
				for (int i = 0; i < length; i++)
				{
					object valueImpl = sourceArray.GetValueImpl(num + i);
					if (valueImpl == null && isValueType)
					{
						throw new InvalidCastException();
					}
					try
					{
						destinationArray.SetValueImpl(valueImpl, num2 + i);
					}
					catch (ArgumentException)
					{
						throw Array.CreateArrayTypeMismatchException();
					}
					catch (InvalidCastException)
					{
						if (Array.CanAssignArrayElement(elementType, elementType2))
						{
							throw;
						}
						throw Array.CreateArrayTypeMismatchException();
					}
				}
				return;
			}
			for (int j = length - 1; j >= 0; j--)
			{
				object valueImpl2 = sourceArray.GetValueImpl(num + j);
				try
				{
					destinationArray.SetValueImpl(valueImpl2, num2 + j);
				}
				catch (ArgumentException)
				{
					throw Array.CreateArrayTypeMismatchException();
				}
				catch
				{
					if (Array.CanAssignArrayElement(elementType, elementType2))
					{
						throw;
					}
					throw Array.CreateArrayTypeMismatchException();
				}
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0004DBD7 File Offset: 0x0004BDD7
		private static ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			return new ArrayTypeMismatchException();
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00050B00 File Offset: 0x0004ED00
		private static bool CanAssignArrayElement(Type source, Type target)
		{
			if (source.IsValueType)
			{
				return source.IsAssignableFrom(target);
			}
			if (source.IsInterface)
			{
				return !target.IsValueType;
			}
			if (target.IsInterface)
			{
				return !source.IsValueType;
			}
			return source.IsAssignableFrom(target) || target.IsAssignableFrom(source);
		}

		/// <summary>Копирует диапазон элементов из массива <see cref="T:System.Array" />, начиная с заданного индекса источника, и вставляет его в другой массив <see cref="T:System.Array" />, начиная с заданного индекса назначения.  Гарантирует, что в случае невозможности успешно скопировать весь диапазон, все изменения будут отменены.</summary>
		/// <param name="sourceArray">Массив <see cref="T:System.Array" />, содержащий данные, которые требуется скопировать.</param>
		/// <param name="sourceIndex">32-разрядное целое число, представляющее индекс в массиве <paramref name="sourceArray" />, с которого начинается копирование.</param>
		/// <param name="destinationArray">Массив <see cref="T:System.Array" />, принимающий данные.</param>
		/// <param name="destinationIndex">32-разрядное целое число, представляющее индекс в массиве <paramref name="destinationArray" />, с которого начинается сохранение.</param>
		/// <param name="length">32-битовое целое число, представляющее число копируемых элементов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceArray" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="destinationArray" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///   <paramref name="sourceArray" /> и <paramref name="destinationArray" /> имеют различные ранги.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">Тип <paramref name="sourceArray" /> не совпадает с типом <paramref name="destinationArray" /> и не является производным от него.</exception>
		/// <exception cref="T:System.InvalidCastException">По меньшей мере один элемент в <paramref name="sourceArray" /> не может быть приведен к типу <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="sourceIndex" /> меньше, чем нижняя граница первого измерения массива <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="destinationIndex" /> меньше, чем нижняя граница первого измерения массива <paramref name="destinationArray" />.  
		/// -или- 
		///  Значение параметра <paramref name="length" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="length" /> больше числа элементов с <paramref name="sourceIndex" /> до конца <paramref name="sourceArray" />.  
		/// -или- 
		///  <paramref name="length" /> больше числа элементов с <paramref name="destinationIndex" /> до конца <paramref name="destinationArray" />.</exception>
		// Token: 0x0600146F RID: 5231 RVA: 0x00050B53 File Offset: 0x0004ED53
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
		}

		/// <summary>Возвращает пустой массив.</summary>
		/// <typeparam name="T">Тип элементов массива.</typeparam>
		/// <returns>Пустой массив.</returns>
		// Token: 0x06001470 RID: 5232 RVA: 0x00050B60 File Offset: 0x0004ED60
		public static T[] Empty<T>()
		{
			return EmptyArray<T>.Value;
		}

		/// <summary>Инициализирует каждый элемент массива <see cref="T:System.Array" /> типа значения путем вызова конструктора по умолчанию для типа значений.</summary>
		// Token: 0x06001471 RID: 5233 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Initialize()
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00050B67 File Offset: 0x0004ED67
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			return EqualityComparer<T>.Default.IndexOf(array, value, startIndex, count);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00050B77 File Offset: 0x0004ED77
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			return EqualityComparer<T>.Default.LastIndexOf(array, value, startIndex, count);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00050B88 File Offset: 0x0004ED88
		private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
		{
			object[] array = keys as object[];
			object[] array2 = null;
			if (array != null)
			{
				array2 = (items as object[]);
			}
			if (array != null && (items == null || array2 != null))
			{
				Array.SorterObjectArray sorterObjectArray = new Array.SorterObjectArray(array, array2, comparer);
				sorterObjectArray.Sort(index, length);
				return;
			}
			Array.SorterGenericArray sorterGenericArray = new Array.SorterGenericArray(keys, items, comparer);
			sorterGenericArray.Sort(index, length);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00050BDA File Offset: 0x0004EDDA
		internal static T UnsafeLoad<T>(T[] array, int index)
		{
			return array[index];
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00050BE3 File Offset: 0x0004EDE3
		internal static void UnsafeStore<T>(T[] array, int index, T value)
		{
			array[index] = value;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00050BED File Offset: 0x0004EDED
		internal static R UnsafeMov<S, R>(S instance)
		{
			return (R)((object)instance);
		}

		// Token: 0x020001D2 RID: 466
		private sealed class ArrayEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06001478 RID: 5240 RVA: 0x00050BFA File Offset: 0x0004EDFA
			internal ArrayEnumerator(Array array)
			{
				this._array = array;
				this._index = -1;
				this._endIndex = array.Length;
			}

			// Token: 0x06001479 RID: 5241 RVA: 0x00050C1C File Offset: 0x0004EE1C
			public bool MoveNext()
			{
				if (this._index < this._endIndex)
				{
					this._index++;
					return this._index < this._endIndex;
				}
				return false;
			}

			// Token: 0x0600147A RID: 5242 RVA: 0x00050C4A File Offset: 0x0004EE4A
			public void Reset()
			{
				this._index = -1;
			}

			// Token: 0x0600147B RID: 5243 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x0600147C RID: 5244 RVA: 0x00050C54 File Offset: 0x0004EE54
			public object Current
			{
				get
				{
					if (this._index < 0)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					if (this._index >= this._endIndex)
					{
						throw new InvalidOperationException("Enumeration already finished.");
					}
					if (this._index == 0 && this._array.GetType().GetElementType().IsPointer)
					{
						throw new NotSupportedException("Type is not supported.");
					}
					return this._array.GetValueImpl(this._index);
				}
			}

			// Token: 0x0400145C RID: 5212
			private Array _array;

			// Token: 0x0400145D RID: 5213
			private int _index;

			// Token: 0x0400145E RID: 5214
			private int _endIndex;
		}

		// Token: 0x020001D3 RID: 467
		[StructLayout(LayoutKind.Sequential)]
		private class RawData
		{
			// Token: 0x0400145F RID: 5215
			public IntPtr Bounds;

			// Token: 0x04001460 RID: 5216
			public IntPtr Count;

			// Token: 0x04001461 RID: 5217
			public byte Data;
		}

		// Token: 0x020001D4 RID: 468
		internal struct InternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x0600147E RID: 5246 RVA: 0x00050CC9 File Offset: 0x0004EEC9
			internal InternalEnumerator(Array array)
			{
				this.array = array;
				this.idx = -2;
			}

			// Token: 0x0600147F RID: 5247 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public void Dispose()
			{
			}

			// Token: 0x06001480 RID: 5248 RVA: 0x00050CDC File Offset: 0x0004EEDC
			public bool MoveNext()
			{
				if (this.idx == -2)
				{
					this.idx = this.array.Length;
				}
				if (this.idx != -1)
				{
					int num = this.idx - 1;
					this.idx = num;
					return num != -1;
				}
				return false;
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x06001481 RID: 5249 RVA: 0x00050D28 File Offset: 0x0004EF28
			public T Current
			{
				get
				{
					if (this.idx == -2)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext");
					}
					if (this.idx == -1)
					{
						throw new InvalidOperationException("Enumeration already finished");
					}
					return this.array.InternalArray__get_Item<T>(this.array.Length - 1 - this.idx);
				}
			}

			// Token: 0x06001482 RID: 5250 RVA: 0x00050D7D File Offset: 0x0004EF7D
			void IEnumerator.Reset()
			{
				this.idx = -2;
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x06001483 RID: 5251 RVA: 0x00050D87 File Offset: 0x0004EF87
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x04001462 RID: 5218
			private const int NOT_STARTED = -2;

			// Token: 0x04001463 RID: 5219
			private const int FINISHED = -1;

			// Token: 0x04001464 RID: 5220
			private readonly Array array;

			// Token: 0x04001465 RID: 5221
			private int idx;
		}

		// Token: 0x020001D5 RID: 469
		internal class EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06001484 RID: 5252 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public void Dispose()
			{
			}

			// Token: 0x06001485 RID: 5253 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public bool MoveNext()
			{
				return false;
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x06001486 RID: 5254 RVA: 0x00050D94 File Offset: 0x0004EF94
			public T Current
			{
				get
				{
					throw new InvalidOperationException("Enumeration has not started. Call MoveNext");
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x06001487 RID: 5255 RVA: 0x00050DA0 File Offset: 0x0004EFA0
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06001488 RID: 5256 RVA: 0x00004BF9 File Offset: 0x00002DF9
			void IEnumerator.Reset()
			{
			}

			// Token: 0x04001466 RID: 5222
			public static readonly Array.EmptyInternalEnumerator<T> Value = new Array.EmptyInternalEnumerator<T>();
		}

		// Token: 0x020001D6 RID: 470
		internal sealed class FunctorComparer<T> : IComparer<T>
		{
			// Token: 0x0600148B RID: 5259 RVA: 0x00050DB9 File Offset: 0x0004EFB9
			public FunctorComparer(Comparison<T> comparison)
			{
				this.comparison = comparison;
			}

			// Token: 0x0600148C RID: 5260 RVA: 0x00050DC8 File Offset: 0x0004EFC8
			public int Compare(T x, T y)
			{
				return this.comparison(x, y);
			}

			// Token: 0x04001467 RID: 5223
			private Comparison<T> comparison;
		}

		// Token: 0x020001D7 RID: 471
		private struct SorterObjectArray
		{
			// Token: 0x0600148D RID: 5261 RVA: 0x00050DD7 File Offset: 0x0004EFD7
			internal SorterObjectArray(object[] keys, object[] items, IComparer comparer)
			{
				if (comparer == null)
				{
					comparer = Comparer.Default;
				}
				this.keys = keys;
				this.items = items;
				this.comparer = comparer;
			}

			// Token: 0x0600148E RID: 5262 RVA: 0x00050DF8 File Offset: 0x0004EFF8
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				if (a != b && this.comparer.Compare(this.keys[a], this.keys[b]) > 0)
				{
					object obj = this.keys[a];
					this.keys[a] = this.keys[b];
					this.keys[b] = obj;
					if (this.items != null)
					{
						object obj2 = this.items[a];
						this.items[a] = this.items[b];
						this.items[b] = obj2;
					}
				}
			}

			// Token: 0x0600148F RID: 5263 RVA: 0x00050E74 File Offset: 0x0004F074
			private void Swap(int i, int j)
			{
				object obj = this.keys[i];
				this.keys[i] = this.keys[j];
				this.keys[j] = obj;
				if (this.items != null)
				{
					object obj2 = this.items[i];
					this.items[i] = this.items[j];
					this.items[j] = obj2;
				}
			}

			// Token: 0x06001490 RID: 5264 RVA: 0x00050ECD File Offset: 0x0004F0CD
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x06001491 RID: 5265 RVA: 0x00050ED8 File Offset: 0x0004F0D8
			private void IntrospectiveSort(int left, int length)
			{
				if (length < 2)
				{
					return;
				}
				try
				{
					this.IntroSort(left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2PlusOne(this.keys.Length));
				}
				catch (IndexOutOfRangeException)
				{
					IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(this.comparer);
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
				}
			}

			// Token: 0x06001492 RID: 5266 RVA: 0x00050F40 File Offset: 0x0004F140
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				while (hi > lo)
				{
					int num = hi - lo + 1;
					if (num <= 16)
					{
						if (num == 1)
						{
							return;
						}
						if (num == 2)
						{
							this.SwapIfGreaterWithItems(lo, hi);
							return;
						}
						if (num == 3)
						{
							this.SwapIfGreaterWithItems(lo, hi - 1);
							this.SwapIfGreaterWithItems(lo, hi);
							this.SwapIfGreaterWithItems(hi - 1, hi);
							return;
						}
						this.InsertionSort(lo, hi);
						return;
					}
					else
					{
						if (depthLimit == 0)
						{
							this.Heapsort(lo, hi);
							return;
						}
						depthLimit--;
						int num2 = this.PickPivotAndPartition(lo, hi);
						this.IntroSort(num2 + 1, hi, depthLimit);
						hi = num2 - 1;
					}
				}
			}

			// Token: 0x06001493 RID: 5267 RVA: 0x00050FC4 File Offset: 0x0004F1C4
			private int PickPivotAndPartition(int lo, int hi)
			{
				int num = lo + (hi - lo) / 2;
				this.SwapIfGreaterWithItems(lo, num);
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(num, hi);
				object obj = this.keys[num];
				this.Swap(num, hi - 1);
				int i = lo;
				int num2 = hi - 1;
				while (i < num2)
				{
					while (this.comparer.Compare(this.keys[++i], obj) < 0)
					{
					}
					while (this.comparer.Compare(obj, this.keys[--num2]) < 0)
					{
					}
					if (i >= num2)
					{
						break;
					}
					this.Swap(i, num2);
				}
				this.Swap(i, hi - 1);
				return i;
			}

			// Token: 0x06001494 RID: 5268 RVA: 0x00051060 File Offset: 0x0004F260
			private void Heapsort(int lo, int hi)
			{
				int num = hi - lo + 1;
				for (int i = num / 2; i >= 1; i--)
				{
					this.DownHeap(i, num, lo);
				}
				for (int j = num; j > 1; j--)
				{
					this.Swap(lo, lo + j - 1);
					this.DownHeap(1, j - 1, lo);
				}
			}

			// Token: 0x06001495 RID: 5269 RVA: 0x000510B0 File Offset: 0x0004F2B0
			private void DownHeap(int i, int n, int lo)
			{
				object obj = this.keys[lo + i - 1];
				object obj2 = (this.items != null) ? this.items[lo + i - 1] : null;
				while (i <= n / 2)
				{
					int num = 2 * i;
					if (num < n && this.comparer.Compare(this.keys[lo + num - 1], this.keys[lo + num]) < 0)
					{
						num++;
					}
					if (this.comparer.Compare(obj, this.keys[lo + num - 1]) >= 0)
					{
						break;
					}
					this.keys[lo + i - 1] = this.keys[lo + num - 1];
					if (this.items != null)
					{
						this.items[lo + i - 1] = this.items[lo + num - 1];
					}
					i = num;
				}
				this.keys[lo + i - 1] = obj;
				if (this.items != null)
				{
					this.items[lo + i - 1] = obj2;
				}
			}

			// Token: 0x06001496 RID: 5270 RVA: 0x00051198 File Offset: 0x0004F398
			private void InsertionSort(int lo, int hi)
			{
				for (int i = lo; i < hi; i++)
				{
					int num = i;
					object obj = this.keys[i + 1];
					object obj2 = (this.items != null) ? this.items[i + 1] : null;
					while (num >= lo && this.comparer.Compare(obj, this.keys[num]) < 0)
					{
						this.keys[num + 1] = this.keys[num];
						if (this.items != null)
						{
							this.items[num + 1] = this.items[num];
						}
						num--;
					}
					this.keys[num + 1] = obj;
					if (this.items != null)
					{
						this.items[num + 1] = obj2;
					}
				}
			}

			// Token: 0x04001468 RID: 5224
			private object[] keys;

			// Token: 0x04001469 RID: 5225
			private object[] items;

			// Token: 0x0400146A RID: 5226
			private IComparer comparer;
		}

		// Token: 0x020001D8 RID: 472
		private struct SorterGenericArray
		{
			// Token: 0x06001497 RID: 5271 RVA: 0x00051245 File Offset: 0x0004F445
			internal SorterGenericArray(Array keys, Array items, IComparer comparer)
			{
				if (comparer == null)
				{
					comparer = Comparer.Default;
				}
				this.keys = keys;
				this.items = items;
				this.comparer = comparer;
			}

			// Token: 0x06001498 RID: 5272 RVA: 0x00051268 File Offset: 0x0004F468
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				if (a != b && this.comparer.Compare(this.keys.GetValue(a), this.keys.GetValue(b)) > 0)
				{
					object value = this.keys.GetValue(a);
					this.keys.SetValue(this.keys.GetValue(b), a);
					this.keys.SetValue(value, b);
					if (this.items != null)
					{
						object value2 = this.items.GetValue(a);
						this.items.SetValue(this.items.GetValue(b), a);
						this.items.SetValue(value2, b);
					}
				}
			}

			// Token: 0x06001499 RID: 5273 RVA: 0x00051310 File Offset: 0x0004F510
			private void Swap(int i, int j)
			{
				object value = this.keys.GetValue(i);
				this.keys.SetValue(this.keys.GetValue(j), i);
				this.keys.SetValue(value, j);
				if (this.items != null)
				{
					object value2 = this.items.GetValue(i);
					this.items.SetValue(this.items.GetValue(j), i);
					this.items.SetValue(value2, j);
				}
			}

			// Token: 0x0600149A RID: 5274 RVA: 0x00051389 File Offset: 0x0004F589
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x0600149B RID: 5275 RVA: 0x00051394 File Offset: 0x0004F594
			private void IntrospectiveSort(int left, int length)
			{
				if (length < 2)
				{
					return;
				}
				try
				{
					this.IntroSort(left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2PlusOne(this.keys.Length));
				}
				catch (IndexOutOfRangeException)
				{
					IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(this.comparer);
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
				}
			}

			// Token: 0x0600149C RID: 5276 RVA: 0x00051400 File Offset: 0x0004F600
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				while (hi > lo)
				{
					int num = hi - lo + 1;
					if (num <= 16)
					{
						if (num == 1)
						{
							return;
						}
						if (num == 2)
						{
							this.SwapIfGreaterWithItems(lo, hi);
							return;
						}
						if (num == 3)
						{
							this.SwapIfGreaterWithItems(lo, hi - 1);
							this.SwapIfGreaterWithItems(lo, hi);
							this.SwapIfGreaterWithItems(hi - 1, hi);
							return;
						}
						this.InsertionSort(lo, hi);
						return;
					}
					else
					{
						if (depthLimit == 0)
						{
							this.Heapsort(lo, hi);
							return;
						}
						depthLimit--;
						int num2 = this.PickPivotAndPartition(lo, hi);
						this.IntroSort(num2 + 1, hi, depthLimit);
						hi = num2 - 1;
					}
				}
			}

			// Token: 0x0600149D RID: 5277 RVA: 0x00051484 File Offset: 0x0004F684
			private int PickPivotAndPartition(int lo, int hi)
			{
				int num = lo + (hi - lo) / 2;
				this.SwapIfGreaterWithItems(lo, num);
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(num, hi);
				object value = this.keys.GetValue(num);
				this.Swap(num, hi - 1);
				int i = lo;
				int num2 = hi - 1;
				while (i < num2)
				{
					while (this.comparer.Compare(this.keys.GetValue(++i), value) < 0)
					{
					}
					while (this.comparer.Compare(value, this.keys.GetValue(--num2)) < 0)
					{
					}
					if (i >= num2)
					{
						break;
					}
					this.Swap(i, num2);
				}
				this.Swap(i, hi - 1);
				return i;
			}

			// Token: 0x0600149E RID: 5278 RVA: 0x0005152C File Offset: 0x0004F72C
			private void Heapsort(int lo, int hi)
			{
				int num = hi - lo + 1;
				for (int i = num / 2; i >= 1; i--)
				{
					this.DownHeap(i, num, lo);
				}
				for (int j = num; j > 1; j--)
				{
					this.Swap(lo, lo + j - 1);
					this.DownHeap(1, j - 1, lo);
				}
			}

			// Token: 0x0600149F RID: 5279 RVA: 0x0005157C File Offset: 0x0004F77C
			private void DownHeap(int i, int n, int lo)
			{
				object value = this.keys.GetValue(lo + i - 1);
				object value2 = (this.items != null) ? this.items.GetValue(lo + i - 1) : null;
				while (i <= n / 2)
				{
					int num = 2 * i;
					if (num < n && this.comparer.Compare(this.keys.GetValue(lo + num - 1), this.keys.GetValue(lo + num)) < 0)
					{
						num++;
					}
					if (this.comparer.Compare(value, this.keys.GetValue(lo + num - 1)) >= 0)
					{
						break;
					}
					this.keys.SetValue(this.keys.GetValue(lo + num - 1), lo + i - 1);
					if (this.items != null)
					{
						this.items.SetValue(this.items.GetValue(lo + num - 1), lo + i - 1);
					}
					i = num;
				}
				this.keys.SetValue(value, lo + i - 1);
				if (this.items != null)
				{
					this.items.SetValue(value2, lo + i - 1);
				}
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00051690 File Offset: 0x0004F890
			private void InsertionSort(int lo, int hi)
			{
				for (int i = lo; i < hi; i++)
				{
					int num = i;
					object value = this.keys.GetValue(i + 1);
					object value2 = (this.items != null) ? this.items.GetValue(i + 1) : null;
					while (num >= lo && this.comparer.Compare(value, this.keys.GetValue(num)) < 0)
					{
						this.keys.SetValue(this.keys.GetValue(num), num + 1);
						if (this.items != null)
						{
							this.items.SetValue(this.items.GetValue(num), num + 1);
						}
						num--;
					}
					this.keys.SetValue(value, num + 1);
					if (this.items != null)
					{
						this.items.SetValue(value2, num + 1);
					}
				}
			}

			// Token: 0x0400146B RID: 5227
			private Array keys;

			// Token: 0x0400146C RID: 5228
			private Array items;

			// Token: 0x0400146D RID: 5229
			private IComparer comparer;
		}
	}
}
