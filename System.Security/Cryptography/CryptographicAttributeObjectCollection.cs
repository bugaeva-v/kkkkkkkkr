using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Security.Cryptography
{
	/// <summary>Содержит набор объектов <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />.</summary>
	// Token: 0x0200000E RID: 14
	public sealed class CryptographicAttributeObjectCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />.</summary>
		// Token: 0x0600002D RID: 45 RVA: 0x000026D4 File Offset: 0x000008D4
		public CryptographicAttributeObjectCollection()
		{
			this._list = new List<CryptographicAttributeObject>();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />, добавляя заданный объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" /> в коллекцию.</summary>
		/// <param name="attribute">Объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, добавляемый в коллекцию.</param>
		// Token: 0x0600002E RID: 46 RVA: 0x000026E7 File Offset: 0x000008E7
		public CryptographicAttributeObjectCollection(CryptographicAttributeObject attribute)
		{
			this._list = new List<CryptographicAttributeObject>();
			this._list.Add(attribute);
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в коллекцию.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> для добавления в коллекцию.</param>
		/// <returns>Значение <see langword="true" />, если метод возвращает отсчитываемый от нуля индекс добавленного элемента; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x0600002F RID: 47 RVA: 0x00002706 File Offset: 0x00000906
		public int Add(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			return this.Add(new CryptographicAttributeObject(asnEncodedData.Oid, new AsnEncodedDataCollection(asnEncodedData)));
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" /> в коллекцию.</summary>
		/// <param name="attribute">Объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" /> для добавления в коллекцию.</param>
		/// <returns>Значение <see langword="true" />, если метод возвращает отсчитываемый от нуля индекс добавленного элемента; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный элемент уже существует в коллекции.</exception>
		// Token: 0x06000030 RID: 48 RVA: 0x00002730 File Offset: 0x00000930
		public int Add(CryptographicAttributeObject attribute)
		{
			if (attribute == null)
			{
				throw new ArgumentNullException("attribute");
			}
			string value = attribute.Oid.Value;
			int i = 0;
			while (i < this._list.Count)
			{
				CryptographicAttributeObject cryptographicAttributeObject = this._list[i];
				if (cryptographicAttributeObject.Values == attribute.Values)
				{
					throw new InvalidOperationException("Duplicate items are not allowed in the collection.");
				}
				string value2 = cryptographicAttributeObject.Oid.Value;
				if (string.Equals(value, value2, StringComparison.OrdinalIgnoreCase))
				{
					if (string.Equals(value, "1.2.840.113549.1.9.5", StringComparison.OrdinalIgnoreCase))
					{
						throw new CryptographicException("Cannot add multiple PKCS 9 signing time attributes.");
					}
					foreach (AsnEncodedData asnEncodedData in attribute.Values)
					{
						cryptographicAttributeObject.Values.Add(asnEncodedData);
					}
					return i;
				}
				else
				{
					i++;
				}
			}
			int count = this._list.Count;
			this._list.Add(attribute);
			return count;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002810 File Offset: 0x00000A10
		internal void AddWithoutMerge(CryptographicAttributeObject attribute)
		{
			this._list.Add(attribute);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" /> из коллекции.</summary>
		/// <param name="attribute">Объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attribute" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000032 RID: 50 RVA: 0x0000281E File Offset: 0x00000A1E
		public void Remove(CryptographicAttributeObject attribute)
		{
			if (attribute == null)
			{
				throw new ArgumentNullException("attribute");
			}
			this._list.Remove(attribute);
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, соответствующий заданному индексу в коллекции.</summary>
		/// <param name="index">Значение <see cref="T:System.Int32" />, представляющее отсчитываемый от нуля индекс объекта <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, который необходимо извлечь.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, расположенный по указанному индексу.</returns>
		// Token: 0x17000009 RID: 9
		public CryptographicAttributeObject this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		/// <summary>Возвращает количество элементов в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002849 File Offset: 0x00000A49
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Получает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции является потокобезопасным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002856 File Offset: 0x00000A56
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Object" />, используемый для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, используемый для синхронизации доступа к коллекции <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />.</returns>
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002859 File Offset: 0x00000A59
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectEnumerator" /> для коллекции.</summary>
		/// <returns>Значение <see langword="true" />, если метод возвращает объект <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectEnumerator" />, который может использоваться для перечисления элементов коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000037 RID: 55 RVA: 0x0000285C File Offset: 0x00000A5C
		public CryptographicAttributeObjectEnumerator GetEnumerator()
		{
			return new CryptographicAttributeObjectEnumerator(this);
		}

		/// <summary>Возвращает перечислитель, выполняющий итерацию элементов коллекции <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерационного перебора элементов коллекции <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />.</returns>
		// Token: 0x06000038 RID: 56 RVA: 0x0000285C File Offset: 0x00000A5C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new CryptographicAttributeObjectEnumerator(this);
		}

		/// <summary>Копирует элементы этой коллекции <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" /> в массив <see cref="T:System.Array" />, начиная с определенного индекса.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из коллекции <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />. Индексация в массиве <see cref="T:System.Array" /> должна начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x06000039 RID: 57 RVA: 0x00002864 File Offset: 0x00000A64
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
			if (index > array.Length - this.Count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index);
				index++;
			}
		}

		/// <summary>Копирует коллекцию <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" /> в массив объектов <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, в который копируется коллекция.</param>
		/// <param name="index">Отсчитываемый от нуля индекс массива <paramref name="array" />, в который необходимо скопировать коллекцию.</param>
		/// <exception cref="T:System.ArgumentException">Один из переданных методу аргументов имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение <see langword="null" /> передано методу, для которого оно является недопустимым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение аргумента находится вне допустимого диапазона значений, определенного вызываемым методом.</exception>
		// Token: 0x0600003A RID: 58 RVA: 0x000028F0 File Offset: 0x00000AF0
		public void CopyTo(CryptographicAttributeObject[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (index > array.Length - this.Count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this._list.CopyTo(array, index);
		}

		// Token: 0x04000082 RID: 130
		private readonly List<CryptographicAttributeObject> _list;
	}
}
