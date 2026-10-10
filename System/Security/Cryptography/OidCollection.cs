using System;
using System.Collections;
using System.Collections.Generic;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Cryptography.Oid" />. Этот класс не наследуется.</summary>
	// Token: 0x020002B6 RID: 694
	public sealed class OidCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		// Token: 0x060015CF RID: 5583 RVA: 0x00057762 File Offset: 0x00055962
		public OidCollection()
		{
			this._list = new List<Oid>();
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Oid" /> в объект <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <param name="oid">Объект <see cref="T:System.Security.Cryptography.Oid" /> для добавления в коллекцию.</param>
		/// <returns>Индекс добавленного объекта <see cref="T:System.Security.Cryptography.Oid" />.</returns>
		// Token: 0x060015D0 RID: 5584 RVA: 0x00057775 File Offset: 0x00055975
		public int Add(Oid oid)
		{
			int count = this._list.Count;
			this._list.Add(oid);
			return count;
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.Oid" /> из объекта <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <param name="index">Расположение объекта <see cref="T:System.Security.Cryptography.Oid" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Oid" />.</returns>
		// Token: 0x17000415 RID: 1045
		public Oid this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		/// <summary>Возвращает первый объект <see cref="T:System.Security.Cryptography.Oid" />, содержащий значение свойства <see cref="P:System.Security.Cryptography.Oid.Value" /> или значение свойства <see cref="P:System.Security.Cryptography.Oid.FriendlyName" />, который соответствует указанному строковому значению из объекта <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <param name="oid">Строка, представляющая свойство <see cref="P:System.Security.Cryptography.Oid.Value" /> или свойство <see cref="P:System.Security.Cryptography.Oid.FriendlyName" /></param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Oid" />.</returns>
		// Token: 0x17000416 RID: 1046
		public Oid this[string oid]
		{
			get
			{
				string text = OidLookup.ToOid(oid, OidGroup.All, false);
				if (text == null)
				{
					text = oid;
				}
				foreach (Oid oid2 in this._list)
				{
					if (oid2.Value == text)
					{
						return oid2;
					}
				}
				return null;
			}
		}

		/// <summary>Получает число объектов <see cref="T:System.Security.Cryptography.Oid" /> в данной коллекции.</summary>
		/// <returns>Число объектов <see cref="T:System.Security.Cryptography.Oid" /> в коллекции.</returns>
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0005780C File Offset: 0x00055A0C
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.OidEnumerator" />, который может использоваться для перемещения объекта <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.OidEnumerator" />.</returns>
		// Token: 0x060015D4 RID: 5588 RVA: 0x00057819 File Offset: 0x00055A19
		public OidEnumerator GetEnumerator()
		{
			return new OidEnumerator(this);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.OidEnumerator" />, который может использоваться для перемещения объекта <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.OidEnumerator" />, который может использоваться для перемещения коллекции.</returns>
		// Token: 0x060015D5 RID: 5589 RVA: 0x00057821 File Offset: 0x00055A21
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Копирует объект <see cref="T:System.Security.Cryptography.OidCollection" />в массив.</summary>
		/// <param name="array">Массив, в который копируется объект <see cref="T:System.Security.Cryptography.OidCollection" />.</param>
		/// <param name="index">Расположение, где начинается операция копирования.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> не может быть многомерным массивом.  
		///
		/// или - 
		/// Длина <paramref name="array" /> имеет недопустимое смещение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> вне диапазона.</exception>
		// Token: 0x060015D6 RID: 5590 RVA: 0x0005782C File Offset: 0x00055A2C
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
			if (index + this.Count > array.Length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index);
				index++;
			}
		}

		/// <summary>Копирует объект <see cref="T:System.Security.Cryptography.OidCollection" />в массив.</summary>
		/// <param name="array">Массив, в который копируется объект <see cref="T:System.Security.Cryptography.OidCollection" />.</param>
		/// <param name="index">Расположение, где начинается операция копирования.</param>
		// Token: 0x060015D7 RID: 5591 RVA: 0x000578B7 File Offset: 0x00055AB7
		public void CopyTo(Oid[] array, int index)
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

		/// <summary>Получает значение, определяющее, является ли доступ к объекту <see cref="T:System.Security.Cryptography.OidCollection" /> потокобезопасным.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Security.Cryptography.OidCollection" />.</returns>
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x000075E1 File Offset: 0x000057E1
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000C35 RID: 3125
		private readonly List<Oid> _list;
	}
}
