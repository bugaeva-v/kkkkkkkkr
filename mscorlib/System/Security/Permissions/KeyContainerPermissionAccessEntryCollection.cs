using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />. Этот класс не наследуется.</summary>
	// Token: 0x02000447 RID: 1095
	[ComVisible(true)]
	[Serializable]
	public sealed class KeyContainerPermissionAccessEntryCollection : ICollection, IEnumerable
	{
		// Token: 0x06002C6A RID: 11370 RVA: 0x0009FA91 File Offset: 0x0009DC91
		internal KeyContainerPermissionAccessEntryCollection()
		{
			this._list = new ArrayList();
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0009FAA4 File Offset: 0x0009DCA4
		internal KeyContainerPermissionAccessEntryCollection(KeyContainerPermissionAccessEntry[] entries)
		{
			if (entries != null)
			{
				foreach (KeyContainerPermissionAccessEntry accessEntry in entries)
				{
					this.Add(accessEntry);
				}
			}
		}

		/// <summary>Получает число элементов коллекции.</summary>
		/// <returns>Число объектов <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> в коллекции.</returns>
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x0009FAD6 File Offset: 0x0009DCD6
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Получает значение, позволяющее определить, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="false" /> во всех случаях.</returns>
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает элемент, содержащийся в коллекции по указанному индексу.</summary>
		/// <param name="index">Начинающийся с нуля индекс элемента для получения доступа.</param>
		/// <returns>Объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, содержащийся в коллекции по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> больше или равно количеству коллекций.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение <paramref name="index" /> отрицательно.</exception>
		// Token: 0x170005A2 RID: 1442
		public KeyContainerPermissionAccessEntry this[int index]
		{
			get
			{
				return (KeyContainerPermissionAccessEntry)this._list[index];
			}
		}

		/// <summary>Получает объект, который может использоваться для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x0000270D File Offset: 0x0000090D
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> в коллекцию.</summary>
		/// <param name="accessEntry">Добавляемый объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="accessEntry" /> — <see langword="null" />.</exception>
		// Token: 0x06002C70 RID: 11376 RVA: 0x0009FAF6 File Offset: 0x0009DCF6
		public int Add(KeyContainerPermissionAccessEntry accessEntry)
		{
			return this._list.Add(accessEntry);
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> из коллекции.</summary>
		// Token: 0x06002C71 RID: 11377 RVA: 0x0009FB04 File Offset: 0x0009DD04
		public void Clear()
		{
			this._list.Clear();
		}

		/// <summary>Копирует элементы коллекции в совместимый одномерный массив, начиная с указанного индекса конечного массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, который является целевым массивом для элементов, копируемых из текущей коллекции.</param>
		/// <param name="index">Индекс в массиве <paramref name="array" />, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше значения нижней границы массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Количество элементов в коллекции превышает доступное пространство, начиная с индекса <paramref name="index" /> и до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06002C72 RID: 11378 RVA: 0x0009FB11 File Offset: 0x0009DD11
		public void CopyTo(KeyContainerPermissionAccessEntry[] array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Копирует элементы коллекции в совместимый одномерный массив, начиная с указанного индекса конечного массива.</summary>
		/// <param name="array">Одномерный массив, который является целевым массивом для элементов, копируемых из текущей коллекции.</param>
		/// <param name="index">Индекс в массиве <paramref name="array" />, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше значения нижней границы массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Количество элементов в коллекции превышает доступное пространство, начиная с индекса <paramref name="index" /> и до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06002C73 RID: 11379 RVA: 0x0009FB11 File Offset: 0x0009DD11
		void ICollection.CopyTo(Array array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator" />, который может использоваться для перебора объектов в коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator" />, который может использоваться для перебора элементов коллекции.</returns>
		// Token: 0x06002C74 RID: 11380 RVA: 0x0009FB20 File Offset: 0x0009DD20
		public KeyContainerPermissionAccessEntryEnumerator GetEnumerator()
		{
			return new KeyContainerPermissionAccessEntryEnumerator(this._list);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator" />, который может использоваться для перебора объектов в коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator" />, который может использоваться для перебора элементов коллекции.</returns>
		// Token: 0x06002C75 RID: 11381 RVA: 0x0009FB20 File Offset: 0x0009DD20
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new KeyContainerPermissionAccessEntryEnumerator(this._list);
		}

		/// <summary>Получает индекс в коллекции указанного объекта <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, если он существует в коллекции.</summary>
		/// <param name="accessEntry">Объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, который требуется обнаружить.</param>
		/// <returns>Индекс указанного объекта <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> в коллекции, или –1, если не найдено совпадение.</returns>
		// Token: 0x06002C76 RID: 11382 RVA: 0x0009FB30 File Offset: 0x0009DD30
		public int IndexOf(KeyContainerPermissionAccessEntry accessEntry)
		{
			if (accessEntry == null)
			{
				throw new ArgumentNullException("accessEntry");
			}
			for (int i = 0; i < this._list.Count; i++)
			{
				if (accessEntry.Equals(this._list[i]))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> из коллекции.</summary>
		/// <param name="accessEntry">Удаляемый объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="accessEntry" /> — <see langword="null" />.</exception>
		// Token: 0x06002C77 RID: 11383 RVA: 0x0009FB78 File Offset: 0x0009DD78
		public void Remove(KeyContainerPermissionAccessEntry accessEntry)
		{
			if (accessEntry == null)
			{
				throw new ArgumentNullException("accessEntry");
			}
			for (int i = 0; i < this._list.Count; i++)
			{
				if (accessEntry.Equals(this._list[i]))
				{
					this._list.RemoveAt(i);
				}
			}
		}

		// Token: 0x04002053 RID: 8275
		private ArrayList _list;
	}
}
