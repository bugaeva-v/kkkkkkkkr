using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Security.Cryptography
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Cryptography.AsnEncodedData" />. Этот класс не наследуется.</summary>
	// Token: 0x020002B3 RID: 691
	public sealed class AsnEncodedDataCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		// Token: 0x060015B2 RID: 5554 RVA: 0x0005742F File Offset: 0x0005562F
		public AsnEncodedDataCollection()
		{
			this._list = new List<AsnEncodedData>();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" /> и добавляет объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в коллекцию.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> для добавления в коллекцию.</param>
		// Token: 0x060015B3 RID: 5555 RVA: 0x00057442 File Offset: 0x00055642
		public AsnEncodedDataCollection(AsnEncodedData asnEncodedData) : this()
		{
			this._list.Add(asnEncodedData);
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в объект <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> для добавления в коллекцию.</param>
		/// <returns>Индекс добавленного объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Идентификаторы объекта не равны <see langword="null" /> и не совпадают.
		/// -или-
		/// Один из идентификаторов объекта равен <see langword="null" />, и идентификаторы объекта не совпадают.</exception>
		// Token: 0x060015B4 RID: 5556 RVA: 0x00057456 File Offset: 0x00055656
		public int Add(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			int count = this._list.Count;
			this._list.Add(asnEncodedData);
			return count;
		}

		/// <summary>Удаляет объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> из объекта <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <param name="asnEncodedData">Удаляемый объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060015B5 RID: 5557 RVA: 0x0005747D File Offset: 0x0005567D
		public void Remove(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			this._list.Remove(asnEncodedData);
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> из объекта <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <param name="index">Расположение в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</returns>
		// Token: 0x1700040D RID: 1037
		public AsnEncodedData this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		/// <summary>Получает число объектов <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в данной коллекции.</summary>
		/// <returns>Число объектов <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</returns>
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000574A8 File Offset: 0x000556A8
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.AsnEncodedDataEnumerator" />, который может использоваться для перемещения объекта <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.AsnEncodedDataEnumerator" />.</returns>
		// Token: 0x060015B8 RID: 5560 RVA: 0x000574B5 File Offset: 0x000556B5
		public AsnEncodedDataEnumerator GetEnumerator()
		{
			return new AsnEncodedDataEnumerator(this);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.AsnEncodedDataEnumerator" />, который может использоваться для перемещения объекта <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.AsnEncodedDataEnumerator" />, который может использоваться для перемещения коллекции.</returns>
		// Token: 0x060015B9 RID: 5561 RVA: 0x000574BD File Offset: 0x000556BD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Копирует объект <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />в массив.</summary>
		/// <param name="array">Массив, в который требуется скопировать объект <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</param>
		/// <param name="index">Расположение, где начинается операция копирования.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> является многомерным массивом, который не поддерживается этим методом.
		///
		/// или - 
		/// Недопустимая длина значения параметра <paramref name="index" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="index" /> выходит за пределы диапазона.</exception>
		// Token: 0x060015BA RID: 5562 RVA: 0x000574C8 File Offset: 0x000556C8
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (this.Count > array.Length - index)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index);
				index++;
			}
		}

		/// <summary>Копирует объект <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />в массив.</summary>
		/// <param name="array">Массив, в который требуется скопировать объект <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</param>
		/// <param name="index">Расположение, где начинается операция копирования.</param>
		// Token: 0x060015BB RID: 5563 RVA: 0x00057553 File Offset: 0x00055753
		public void CopyTo(AsnEncodedData[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this._list.CopyTo(array, index);
		}

		/// <summary>Получает значение, определяющее, является ли доступ к объекту <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" /> потокобезопасным.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <returns>Объект, используемый для синхронизации доступа к объекту <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</returns>
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x000075E1 File Offset: 0x000057E1
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000C2F RID: 3119
		private readonly List<AsnEncodedData> _list;
	}
}
