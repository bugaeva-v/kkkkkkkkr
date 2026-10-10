using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace System.Data
{
	/// <summary>Предоставляет базовую функциональность для создания коллекций.</summary>
	// Token: 0x020000A2 RID: 162
	public class InternalDataCollectionBase : ICollection, IEnumerable
	{
		/// <summary>Возвращает общее число элементов в коллекции.</summary>
		/// <returns>Общее число элементов в коллекции.</returns>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002AF4C File Offset: 0x0002914C
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				return this.List.Count;
			}
		}

		/// <summary>Копирует все элементы текущего объекта <see cref="T:System.Data.InternalDataCollectionBase" /> в одномерный массив <see cref="T:System.Array" />, начиная с указанного индекса <see cref="T:System.Data.InternalDataCollectionBase" />.</summary>
		/// <param name="ar">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы текущего объекта <see cref="T:System.Data.InternalDataCollectionBase" />.</param>
		/// <param name="index">Индекс целевого массива <see cref="T:System.Array" />, с которого начинается копирование.</param>
		// Token: 0x06000A38 RID: 2616 RVA: 0x0002AF59 File Offset: 0x00029159
		public virtual void CopyTo(Array ar, int index)
		{
			this.List.CopyTo(ar, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" /> для коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" /> для коллекции.</returns>
		// Token: 0x06000A39 RID: 2617 RVA: 0x0002AF68 File Offset: 0x00029168
		public virtual IEnumerator GetEnumerator()
		{
			return this.List.GetEnumerator();
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Data.InternalDataCollectionBase" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция доступна только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00006D64 File Offset: 0x00004F64
		[Browsable(false)]
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, указывающее, синхронизирована ли коллекция <see cref="T:System.Data.InternalDataCollectionBase" />.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция синхронизирована; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00006D64 File Offset: 0x00004F64
		[Browsable(false)]
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002AF75 File Offset: 0x00029175
		internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale)
		{
			if (fCaseSensitive)
			{
				if (string.Compare(s1, s2, false, locale) != 0)
				{
					return 0;
				}
				return 1;
			}
			else
			{
				if (locale.CompareInfo.Compare(s1, s2, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth) != 0)
				{
					return 0;
				}
				if (string.Compare(s1, s2, false, locale) != 0)
				{
					return -1;
				}
				return 1;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который используется для синхронизации коллекции.</returns>
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00005696 File Offset: 0x00003896
		[Browsable(false)]
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает элементы коллекции в виде списка.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ArrayList" />, содержащий коллекцию.</returns>
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00003E32 File Offset: 0x00002032
		protected virtual ArrayList List
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400075E RID: 1886
		internal static readonly CollectionChangeEventArgs s_refreshEventArgs = new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null);
	}
}
