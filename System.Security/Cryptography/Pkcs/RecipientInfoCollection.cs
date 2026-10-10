using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" /> представляет коллекцию объектов <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />. Класс <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" /> реализует интерфейс списка <see cref="T:System.Collections.ICollection" />.</summary>
	// Token: 0x02000081 RID: 129
	public sealed class RecipientInfoCollection : ICollection, IEnumerable
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x00012D0E File Offset: 0x00010F0E
		internal RecipientInfoCollection()
		{
			this._recipientInfos = Array.Empty<RecipientInfo>();
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00012D21 File Offset: 0x00010F21
		internal RecipientInfoCollection(RecipientInfo recipientInfo)
		{
			this._recipientInfos = new RecipientInfo[]
			{
				recipientInfo
			};
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00012D39 File Offset: 0x00010F39
		internal RecipientInfoCollection(ICollection<RecipientInfo> recipientInfos)
		{
			this._recipientInfos = new RecipientInfo[recipientInfos.Count];
			recipientInfos.CopyTo(this._recipientInfos, 0);
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfoCollection.Item(System.Int32)" /> возвращает объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, расположенный в коллекции по указанному индексу.</summary>
		/// <param name="index">Значение целочисленного типа, представляющее индекс в коллекции. Индексация начинается с нуля.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение аргумента находится вне допустимого диапазона значений, определенного вызываемым методом.</exception>
		// Token: 0x170000EF RID: 239
		public RecipientInfo this[int index]
		{
			get
			{
				if (index < 0 || index >= this._recipientInfos.Length)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				return this._recipientInfos[index];
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfoCollection.Count" /> возвращает число элементов в коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Целочисленное значение, представляющее число элементов в коллекции.</returns>
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00012D88 File Offset: 0x00010F88
		public int Count
		{
			get
			{
				return this._recipientInfos.Length;
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.RecipientInfoCollection.GetEnumerator" /> возвращает объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator" />, который служит для перебора элементов коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</returns>
		// Token: 0x06000430 RID: 1072 RVA: 0x00012D92 File Offset: 0x00010F92
		public RecipientInfoEnumerator GetEnumerator()
		{
			return new RecipientInfoEnumerator(this);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.RecipientInfoCollection.System#Collections#IEnumerable#GetEnumerator" /> возвращает объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator" />, который служит для перебора элементов коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</returns>
		// Token: 0x06000431 RID: 1073 RVA: 0x00012D9A File Offset: 0x00010F9A
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.RecipientInfoCollection.CopyTo(System.Array,System.Int32)" /> копирует коллекцию <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" /> в массив.</summary>
		/// <param name="array">Объект <see cref="T:System.Array" />, в который должна быть скопирована коллекция <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, который обозначает позицию для копирования коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">Один из переданных методу аргументов имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение аргумента находится вне допустимого диапазона значений, определенного вызываемым методом.</exception>
		// Token: 0x06000432 RID: 1074 RVA: 0x00012DA4 File Offset: 0x00010FA4
		public void CopyTo(Array array, int index)
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

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.RecipientInfoCollection.CopyTo(System.Security.Cryptography.Pkcs.RecipientInfo[],System.Int32)" /> копирует коллекцию <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" /> в массив <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, в который необходимо скопировать коллекцию <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, который обозначает позицию для копирования коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">Один из переданных методу аргументов имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение аргумента находится вне допустимого диапазона значений, определенного вызываемым методом.</exception>
		// Token: 0x06000433 RID: 1075 RVA: 0x00012E2F File Offset: 0x0001102F
		public void CopyTo(RecipientInfo[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this._recipientInfos.CopyTo(array, index);
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfoCollection.IsSynchronized" /> возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным). Это свойство всегда возвращает значение <see langword="false" />, что означает, что коллекция не является потокобезопасной.</summary>
		/// <returns>Значение типа <see cref="T:System.Boolean" />, равное <see langword="false" />, что означает, что коллекция не является потокобезопасной.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00002856 File Offset: 0x00000A56
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfoCollection.SyncRoot" /> возвращает объект <see cref="T:System.Object" />, который используется для синхронизации доступа к коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, используемый для синхронизации доступа к коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</returns>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00002859 File Offset: 0x00000A59
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0400029B RID: 667
		private readonly RecipientInfo[] _recipientInfos;
	}
}
