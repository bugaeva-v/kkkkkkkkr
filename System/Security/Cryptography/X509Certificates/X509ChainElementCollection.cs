using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" />. Этот класс не наследуется.</summary>
	// Token: 0x020002DB RID: 731
	public sealed class X509ChainElementCollection : ICollection, IEnumerable
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x0005B6D6 File Offset: 0x000598D6
		internal X509ChainElementCollection()
		{
			this._list = new ArrayList();
		}

		/// <summary>Возвращает количество элементов в коллекции.</summary>
		/// <returns>Целое число, представляющее количество элементов в коллекции.</returns>
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0005B6E9 File Offset: 0x000598E9
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Получает значение, позволяющее определить, является ли коллекция элементов цепочки синхронизированной.</summary>
		/// <returns>Всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0005B6F6 File Offset: 0x000598F6
		public bool IsSynchronized
		{
			get
			{
				return this._list.IsSynchronized;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> по указанному индексу.</summary>
		/// <param name="index">Целочисленное значение.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" />больше или равно длине коллекции.</exception>
		// Token: 0x17000473 RID: 1139
		public X509ChainElement this[int index]
		{
			get
			{
				return (X509ChainElement)this._list[index];
			}
		}

		/// <summary>Получает объект, который можно использовать для синхронизации доступа к объекту <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>Ссылка на текущий объект.</returns>
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0005B716 File Offset: 0x00059916
		public object SyncRoot
		{
			get
			{
				return this._list.SyncRoot;
			}
		}

		/// <summary>Копирует объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> в массив, начиная с указанного индекса.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" />.</param>
		/// <param name="index">Целое число, представляющее значение индекса.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение параметра <paramref name="index" /> меньше нуля или больше или равно длине массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="index" /> вместе с текущим количеством больше, чем длина массива.</exception>
		// Token: 0x06001712 RID: 5906 RVA: 0x0005B723 File Offset: 0x00059923
		public void CopyTo(X509ChainElement[] array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Копирует объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> в массив, начиная с указанного индекса.</summary>
		/// <param name="array">Массив для копирования объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</param>
		/// <param name="index">Индекс объекта <paramref name="array" />, с которого требуется начать копирование.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение параметра <paramref name="index" /> меньше нуля или больше или равно длине массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="index" /> вместе с текущим количеством больше, чем длина массива.</exception>
		// Token: 0x06001713 RID: 5907 RVA: 0x0005B723 File Offset: 0x00059923
		void ICollection.CopyTo(Array array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator" />, который может использоваться для перехода в коллекции элементов цепочки.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator" />.</returns>
		// Token: 0x06001714 RID: 5908 RVA: 0x0005B732 File Offset: 0x00059932
		public X509ChainElementEnumerator GetEnumerator()
		{
			return new X509ChainElementEnumerator(this._list);
		}

		/// <summary>Получает объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для перехода в коллекции элементов цепочки.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06001715 RID: 5909 RVA: 0x0005B732 File Offset: 0x00059932
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new X509ChainElementEnumerator(this._list);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0005B73F File Offset: 0x0005993F
		internal void Add(X509Certificate2 certificate)
		{
			this._list.Add(new X509ChainElement(certificate));
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0005B753 File Offset: 0x00059953
		internal void Clear()
		{
			this._list.Clear();
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0005B760 File Offset: 0x00059960
		internal bool Contains(X509Certificate2 certificate)
		{
			for (int i = 0; i < this._list.Count; i++)
			{
				if (certificate.Equals((this._list[i] as X509ChainElement).Certificate))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000D07 RID: 3335
		private ArrayList _list;
	}
}
